from pathlib import Path
import json, hashlib, re, collections
from importlib import import_module
Native=import_module('04_native_evidence').Native
ROOT=Path(__file__).resolve().parents[1]

def main():
    native=Native()
    store_results=[]
    for path in (ROOT/'restored/configs/schemas').glob('*.json'):
        schema=json.loads(path.read_text())
        instructions=native.disassemble(int(schema['read_impl_rva'],16),128000)
        readers=[]
        current=None
        aliases={'x19':0}
        for ins in instructions:
            if ins.mnemonic=='mov':
                operands=ins.op_str.split(', ')
                if len(operands)==2 and operands[1] in aliases:
                    aliases[operands[0]]=aliases[operands[1]]
                elif operands[0]!='x19':
                    aliases.pop(operands[0],None)
            elif ins.mnemonic=='add':
                m=re.fullmatch(r'(x\d+), (x\d+), #(0x[0-9a-f]+|\d+)',ins.op_str)
                if m and m.group(2) in aliases:
                    aliases[m.group(1)]=aliases[m.group(2)]+int(m.group(3),0)
            elif ins.mnemonic in ('ldr','adrp','adr'):
                aliases.pop(ins.op_str.split(',')[0],None)
            if ins.mnemonic in ('bl','b') and ins.op_str.startswith('#0x'):
                targets=native.by_address.get(int(ins.op_str[1:],16),[])
                if any(t.startswith('LocalModels.BaseLocalBean$$read') for t in targets):
                    current={'call':next(t.split('$$')[-1] for t in targets if t.startswith('LocalModels.BaseLocalBean$$read')),'stores':[]}
                    readers.append(current)
            if current is not None and ins.mnemonic in ('str','stur'):
                m=re.search(r'\[(x\d+)(?:, #(0x[0-9a-f]+|\d+))?\](!)?',ins.op_str)
                if m and m.group(1) in aliases:
                    dest=aliases[m.group(1)]+(int(m.group(2),0) if m.group(2) else 0)
                    current['stores'].append(dest)
                    if m.group(3):
                        aliases[m.group(1)]=dest
            if ins.mnemonic in ('bl','blr'):
                for register in [f'x{i}' for i in range(19)]:
                    aliases.pop(register,None)
        check=len(readers)==len(schema['fields']) and all(f['offset'] in r['stores'] for f,r in zip(schema['fields'],readers))
        store_results.append({'name':schema['name'],'all_field_destinations_verified':check,'reader_count':len(readers),'field_count':len(schema['fields'])})
    entries=json.loads((ROOT/'indexes/apk-files.json').read_text())
    bad=[]
    for entry in entries:
        path=ROOT/entry['extracted_path']
        with path.open('rb') as stream:
            digest=hashlib.file_digest(stream,'sha256').hexdigest()
        if digest!=entry['sha256']:
            bad.append(entry['path'])
    tables=json.loads((ROOT/'indexes/config-tables.json').read_text())
    invalid_tables=[]
    for record in tables:
        if record['status']!='decoded':
            continue
        decoded=json.loads((ROOT/record['output']).read_text())
        if len(decoded)!=record['rows']:
            invalid_tables.append(record['name'])
    report={'apk_extracted_files_verified':len(entries),'apk_hash_mismatches':bad,'decoded_json_row_count_mismatches':invalid_tables,'schemas_native_store_verified':sum(x['all_field_destinations_verified'] for x in store_results),'schemas_native_store_unverified':[x for x in store_results if not x['all_field_destinations_verified']],'schema_checks':store_results}
    (ROOT/'indexes/verification.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8', newline="\n")
    print(json.dumps({k:v for k,v in report.items() if k!='schema_checks'},ensure_ascii=False,indent=2))
    if bad or invalid_tables:
        raise SystemExit(1)

if __name__=='__main__':
    main()
