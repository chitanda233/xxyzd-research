from pathlib import Path
import bisect, collections, hashlib, json, re

ROOT = Path(__file__).resolve().parents[1]
CODE = ROOT / 'restored/code/il2cpp'
text = (CODE / 'dump.cs').read_text(encoding='utf-8-sig')
images = [{'index': int(i), 'name': n, 'first_type': int(t)} for i, n, t in re.findall(r'^// Image (\d+): (.+?) - (\d+)$', text, re.M)]
starts = [x['first_type'] for x in images]
parts = re.split(r'(?=^// Namespace:)', text, flags=re.M)[1:]
types = []
streams = {}
out = CODE / 'assemblies'
out.mkdir(exist_ok=True)
for part in parts:
    match = re.search(r'^(.+?) // TypeDefIndex: (\d+)$', part, re.M)
    if not match:
        continue
    declaration, idx = match.group(1), int(match.group(2))
    assembly = images[bisect.bisect_right(starts, idx) - 1]['name']
    if assembly not in streams:
        streams[assembly] = (out / (assembly + '.cs')).open('w', encoding='utf-8', newline="\n")
        streams[assembly].write('// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.\n\n')
    streams[assembly].write(part)
    types.append({'assembly': assembly, 'namespace': part.splitlines()[0].removeprefix('// Namespace: ').strip(), 'declaration': declaration, 'type_index': idx})
for stream in streams.values():
    stream.close()
counts = collections.Counter(x['assembly'] for x in types)
for img in images:
    img['type_count'] = counts[img['name']]
    img['structure_file'] = f'restored/code/il2cpp/assemblies/{img["name"]}.cs'
(ROOT / 'indexes/code-assemblies.json').write_text(json.dumps(images, indent=2), encoding='utf-8', newline="\n")
with (ROOT / 'indexes/code-types.jsonl').open('w', encoding='utf-8', newline="\n") as f:
    for item in types:
        f.write(json.dumps(item, ensure_ascii=False) + '\n')

catalog_path = ROOT / 'unpacked/apk/assets/aa/catalog.json'
catalog = json.loads(catalog_path.read_text(encoding='utf-8-sig'))
ids = catalog.get('m_InternalIds', [])
prefixes = catalog.get('m_InternalIdPrefixes', [])
decoded = []
for value in ids:
    expanded = value
    match = re.match(r'^(\d+)#(.*)', value)
    if match and int(match.group(1)) < len(prefixes):
        expanded = prefixes[int(match.group(1))] + match.group(2)
    decoded.append({'raw': value, 'expanded': expanded})
(ROOT / 'indexes/addressables-internal-ids.json').write_text(json.dumps(decoded, ensure_ascii=False, indent=2), encoding='utf-8', newline="\n")
(ROOT / 'indexes/addressables-paths.txt').write_text('\n'.join(x['expanded'] for x in decoded), encoding='utf-8', newline="\n")
bundles = list((ROOT / 'unpacked/apk/assets').rglob('*.bundle'))
listing = (ROOT / 'unpacked/apk/assets/FullRes/__bundle_list__.txt').read_text(encoding='utf-8-sig').splitlines()
missing = [x for x in listing if x and not (ROOT / 'unpacked/apk/assets/FullRes' / x).is_file()]
summary = {'assemblies': len(images), 'types': len(types), 'bundle_files_in_apk': len(bundles), 'bundle_list_entries': len(listing), 'bundle_list_missing_from_fullres': missing, 'addressables_internal_ids': len(ids), 'limitations': ['IL2CPP C# method bodies are placeholders; native code remains in libil2cpp.so.', 'Addressables entries describe packaged build; online current content is not verified.']}
(ROOT / 'indexes/code-catalog-summary.json').write_text(json.dumps(summary, ensure_ascii=False, indent=2), encoding='utf-8', newline="\n")
print(json.dumps(summary, ensure_ascii=False, indent=2))
