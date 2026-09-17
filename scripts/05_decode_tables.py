from pathlib import Path
import re, json, struct, hashlib, collections
from importlib import import_module
Native = import_module('04_native_evidence').Native
ROOT = Path(__file__).resolve().parents[1]

class Reader:
    def __init__(self, data):
        self.data, self.pos = data, 0
    def take(self, size):
        if size < 0 or self.pos + size > len(self.data):
            raise ValueError(f'Out of bounds: offset {self.pos}, size {size}')
        value = self.data[self.pos:self.pos+size]
        self.pos += size
        return value
    def unpack(self, fmt):
        return struct.unpack('>'+fmt, self.take(struct.calcsize('>'+fmt)))[0]
    def read(self, method):
        fmts = {'readInt':'i', 'readShort':'h', 'readLong':'q', 'readFloat':'f', 'readDouble':'d'}
        if method in fmts:
            return self.unpack(fmts[method])
        if method == 'readBool':
            return self.unpack('h') == 1
        if method == 'readDate':
            return {'serialized_date_int64': self.unpack('q')}
        if method == 'readFp':
            value = self.unpack('i')
            # readFp ARM64: signed (int32 << 16) / 10000, truncates toward zero.
            raw = (abs(value) * 65536 // 10000) * (-1 if value < 0 else 1)
            return {'serialized_int32':value, 'decimal':value/10000, 'fp_raw':raw, 'runtime_value':raw/65536}
        if method in ('readLocalString', 'readCommonString'):
            return self.take(self.unpack('h') - 2).decode('utf-8')
        arrays = {'readArrayint':'readInt', 'readArraylong':'readLong', 'readArrayfloat':'readFloat', 'readArrayfp':'readFp', 'readArraystring':'readLocalString', 'readArrayArrayint':'readArrayint'}
        if method in arrays:
            count = self.unpack('h')
            if count < 0:
                raise ValueError(f'Negative array count {count}')
            return [self.read(arrays[method]) for _ in range(count)]
        raise ValueError('Unsupported reader: '+method)

def main():
    native = Native()
    methods = {m['Name']:m for m in native.methods}
    schemas = {}
    for path in (ROOT / 'restored/code/il2cpp/assemblies').glob('*.cs'):
        if path.name not in ('HotFix.dll.cs','HotFixBattle.dll.cs'):
            continue
        for part in re.split(r'(?=^// Namespace:)', path.read_text(encoding='utf-8'), flags=re.M):
            match = re.search(r'^public class (\w+) : BaseLocalBean', part, re.M)
            if not match:
                continue
            name = match.group(1)
            fields = [{'type':t, 'name':n, 'offset':int(o,16)} for t,n,o in re.findall(r'private (\S+) <([^>]+)>k__BackingField; // 0x([0-9A-Fa-f]+)',part)]
            method = methods.get('LocalModels.Bean.'+name+'$$readImpl')
            if not method:
                continue
            calls = []
            for ins in native.disassemble(method['Address'], 128000):
                if ins.mnemonic not in ('bl','b') or not ins.op_str.startswith('#0x'):
                    continue
                target = native.by_address.get(int(ins.op_str[1:],16), [])
                for called in target:
                    if called.startswith('LocalModels.BaseLocalBean$$read'):
                        calls.append(called.split('$$')[-1])
                        break
            schema = {'name':name, 'assembly':path.name[:-3], 'read_impl_rva':hex(method['Address']), 'fields':fields, 'native_reader_calls':calls, 'field_count_matches_native_calls':len(fields)==len(calls)}
            if (name, fields[-1]['name'] if fields else '') in (('Chapter_MainChapter', 'bloodDropMinPower'), ('ChapterMulti_MultiPlayer', 'ResurrectionTimes')) and len(fields)==len(calls)+1:
                # Verified native readImpl returns immediately after the preceding field.
                schema['nonserialized_fields'] = fields[-1:]
                fields = fields[:-1]
                schema['fields'] = fields
                schema['field_count_matches_native_calls'] = True
            if len(fields)==len(calls):
                for field, call in zip(fields,calls):
                    field['reader'] = call
            schemas[name]=schema
    schema_dir = ROOT / 'restored/configs/schemas'
    tables_dir = ROOT / 'restored/configs/tables'
    for d in (schema_dir,tables_dir):
        d.mkdir(parents=True,exist_ok=True)
    for name,schema in schemas.items():
        (schema_dir/(name+'.json')).write_text(json.dumps(schema,ensure_ascii=False,indent=2),encoding='utf-8', newline="\n")
    results=[]
    for source in sorted((ROOT/'restored/configs/textassets').glob('localmodel*/*')):
        name = re.sub(r'^-?\d+_', '', source.name)
        schema = schemas.get(name)
        record = {'name':name, 'source':source.relative_to(ROOT).as_posix(), 'sha256':hashlib.sha256(source.read_bytes()).hexdigest()}
        try:
            if schema is None:
                raise ValueError('No matching current IL2CPP bean schema; preserved raw')
            if not schema['field_count_matches_native_calls']:
                raise ValueError(f'Field/reader count mismatch: {len(schema["fields"])}/{len(schema["native_reader_calls"])}')
            attempt_errors=[]
            for header_bytes in (4,2):
                try:
                    reader = Reader(source.read_bytes())
                    count = reader.unpack('i')
                    if not 0 <= count <= 1000000:
                        raise ValueError('Invalid table row count')
                    rows=[]
                    for i in range(count):
                        start=reader.pos
                        length=reader.unpack('i' if header_bytes==4 else 'h')
                        row={field['name']:reader.read(field['reader']) for field in schema['fields']}
                        if reader.pos-start != length:
                            raise ValueError(f'Row {i} boundary mismatch, expected {length}, consumed {reader.pos-start}')
                        rows.append(row)
                    if reader.pos != len(reader.data):
                        raise ValueError(f'Trailing bytes: {len(reader.data)-reader.pos}')
                    break
                except Exception as exc:
                    attempt_errors.append(str(exc))
            else:
                raise ValueError(' | '.join(attempt_errors))
            dest=tables_dir/(name+'.json')
            dest.write_text(json.dumps(rows,ensure_ascii=False,indent=2,allow_nan=False),encoding='utf-8', newline="\n")
            record.update(status='decoded',rows=count,output=dest.relative_to(ROOT).as_posix(),byte_boundaries_verified=True,reader_sequence_verified=True,row_header_bytes=header_bytes,layout='current_native' if header_bytes==4 else 'legacy_short_header_inferred_from_all_row_boundaries')
        except Exception as exc:
            record.update(status='unresolved',error=str(exc))
        results.append(record)
    summary={'schemas':len(schemas),'table_assets':len(results),'decoded_tables':sum(x['status']=='decoded' for x in results),'decoded_rows':sum(x.get('rows',0) for x in results),'unresolved':[x for x in results if x['status']!='decoded'],'notes':['Field names derive from backing-field metadata; read operation sequence derives from native readImpl calls.','All emitted tables pass every row boundary and end-of-file check.','FP includes original integer, decimal /10000 and exact Q16 runtime representation.','readCommonString is exported as localization key, not translated text.','Unmatched legacy tables are preserved raw without guessed field labels.']}
    (ROOT/'indexes/config-tables.json').write_text(json.dumps(results,ensure_ascii=False,indent=2),encoding='utf-8', newline="\n")
    (ROOT/'indexes/config-decode-summary.json').write_text(json.dumps(summary,ensure_ascii=False,indent=2),encoding='utf-8', newline="\n")
    print(json.dumps(summary,ensure_ascii=False,indent=2))

if __name__=='__main__':
    main()
