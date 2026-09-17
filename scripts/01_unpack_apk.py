from pathlib import Path
import hashlib, json, shutil, struct, zipfile, collections

ROOT = Path(__file__).resolve().parents[1]
SOURCE = ROOT.parent / 'com.fhzj.game.apk'
for directory in ['original', 'unpacked/apk', 'restored/resources', 'restored/configs', 'restored/code/il2cpp', 'restored/code/android', 'indexes', 'logs', 'tools', 'notes']:
    (ROOT / directory).mkdir(parents=True, exist_ok=True)

def digest(path):
    with path.open('rb') as stream:
        return hashlib.file_digest(stream, 'sha256').hexdigest()

copy = ROOT / 'original' / SOURCE.name
if not copy.exists():
    shutil.copy2(SOURCE, copy)
assert digest(SOURCE) == digest(copy), 'Original copy hash mismatch'
out = ROOT / 'unpacked/apk'
entries = []
with zipfile.ZipFile(copy) as archive:
    folded = collections.Counter(x.filename.casefold() for x in archive.infolist() if not x.is_dir())
    for info in archive.infolist():
        target = (out / info.filename).resolve()
        if not target.is_relative_to(out.resolve()):
            raise ValueError(f'Unsafe archive path: {info.filename}')
        collision = not info.is_dir() and folded[info.filename.casefold()] > 1
        if collision:
            key = hashlib.sha256(info.filename.encode('utf-8')).hexdigest()[:16]
            target = ROOT / 'unpacked/case-preserved' / key / info.filename
        if info.is_dir():
            target.mkdir(parents=True, exist_ok=True)
            continue
        target.parent.mkdir(parents=True, exist_ok=True)
        data = archive.read(info)  # ZIP CRC is checked during reading.
        target.write_bytes(data)
        entries.append({'path': info.filename, 'extracted_path': target.relative_to(ROOT).as_posix(), 'case_collision': collision, 'size': len(data), 'compressed_size': info.compress_size, 'crc32': f'{info.CRC:08x}', 'sha256': hashlib.sha256(data).hexdigest()})
(ROOT / 'indexes/apk-files.json').write_text(json.dumps(entries, ensure_ascii=False, indent=2), encoding='utf-8', newline="\n")
metadata = out / 'assets/bin/Data/Managed/Metadata/global-metadata.dat'
magic, version = struct.unpack('<II', metadata.read_bytes()[:8])
result = {'source': str(SOURCE), 'apk_sha256': digest(copy), 'apk_bytes': copy.stat().st_size, 'file_count': len(entries), 'unpacked_bytes': sum(x['size'] for x in entries), 'zip_crc_verified': True, 'case_collision_entries': sum(x['case_collision'] for x in entries), 'metadata_magic': hex(magic), 'metadata_version': version}
(ROOT / 'indexes/apk-summary.json').write_text(json.dumps(result, indent=2), encoding='utf-8', newline="\n")
print(json.dumps(result, indent=2))
