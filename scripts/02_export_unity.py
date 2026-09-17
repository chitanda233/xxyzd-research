from pathlib import Path
import sys, json, re, hashlib, collections, time
ROOT = Path(__file__).resolve().parents[1]
sys.path.insert(0, str(ROOT / 'tools/python'))
import UnityPy

EXPORT_MEDIA = '--media' in sys.argv  # Opt-in; current task focuses on systems and gameplay.

APK = ROOT / 'unpacked/apk'
OUT = ROOT / 'restored/resources'
INDEX = ROOT / 'indexes'

def clean(name):
    name = re.sub(r'[<>:"/\\|?*\x00-\x1f]', '_', str(name)).strip(' .')
    return (name or 'unnamed')[:100]

def serial(value):
    if isinstance(value, bytes):
        return {'_bytes_hex': value.hex()}
    return str(value)

def save(path, data):
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_bytes(data)
    return str(path.relative_to(ROOT)).replace('\\', '/')

def savejson(path, value):
    return save(path, json.dumps(value, ensure_ascii=True, indent=2, default=serial).encode('utf-8'))

def main():
    inputs = sorted((APK / 'assets').rglob('*.bundle'))
    # Built-in serialized files may have extensionless, hash-based names.
    for p in sorted((APK / 'assets/bin/Data').iterdir()):
        if p.is_file() and p.name not in ('boot.config', 'RuntimeInitializeOnLoads.json', 'ScriptingAssemblies.json') and not p.name.endswith(('.ress', '.resource', '.resS')):
            inputs.append(p)
    counts = collections.Counter()
    failures = []
    versions = set()
    total = 0
    with (INDEX / 'unity-objects.jsonl').open('w', encoding='utf-8', newline="\n") as index:
        for i, path in enumerate(inputs):
            source = path.relative_to(APK).as_posix()
            bundle_key = clean(path.stem)[:70] + '_' + hashlib.sha1(source.encode()).hexdigest()[:10]
            try:
                env = UnityPy.load(str(path))
                objects = list(env.objects)
                if not objects:
                    failures.append({'source': source, 'stage': 'load', 'error': 'No serialized objects'})
                for obj in objects:
                    total += 1
                    kind = obj.type.name
                    counts[kind] += 1
                    versions.add(str(obj.assets_file.unity_version))
                    asset_key = clean(obj.assets_file.name)[:50]
                    record = {'source': source, 'serialized_file': obj.assets_file.name, 'path_id': obj.path_id, 'type': kind, 'exports': []}
                    base = OUT / kind / bundle_key / asset_key
                    try:
                        raw = obj.get_raw_data()
                        record['raw_sha256'] = hashlib.sha256(raw).hexdigest()
                        record['exports'].append(save(base / f'{obj.path_id}.bin', raw))
                        tree = None
                        try:
                            tree = obj.read_typetree()
                            record['name'] = tree.get('m_Name', '') if isinstance(tree, dict) else ''
                            record['exports'].append(savejson(base / f'{obj.path_id}.json', tree))
                        except Exception as exc:
                            record['typetree_error'] = str(exc)[:800]
                        stem = f'{obj.path_id}_{clean(record.get("name", ""))}'
                        if kind == 'TextAsset':
                            data = obj.read()
                            body = data.m_Script
                            if isinstance(body, str):
                                body = body.encode('utf-8', 'surrogateescape')
                            name = clean(data.m_Name)
                            record['name'] = data.m_Name
                            record['exports'].append(save(ROOT / 'restored/configs/textassets' / bundle_key / f'{obj.path_id}_{name}', body))
                            try:
                                decoded = json.loads(body)
                                record['exports'].append(savejson(ROOT / 'restored/configs/json' / bundle_key / f'{obj.path_id}_{name}.json', decoded))
                            except (ValueError, UnicodeError):
                                pass
                        elif EXPORT_MEDIA and kind in ('Texture2D', 'Sprite'):
                            data = obj.read()
                            img = data.image
                            dest = base / f'{stem}.png'
                            dest.parent.mkdir(parents=True, exist_ok=True)
                            img.save(dest)
                            record['exports'].append(dest.relative_to(ROOT).as_posix())
                        elif EXPORT_MEDIA and kind == 'AudioClip':
                            data = obj.read()
                            for name, sample in data.samples.items():
                                record['exports'].append(save(base / f'{obj.path_id}_{clean(name)}', sample))
                        elif EXPORT_MEDIA and kind == 'Mesh':
                            exported = obj.read().export()
                            if isinstance(exported, str):
                                record['exports'].append(save(base / f'{stem}.obj', exported.encode('utf-8')))
                        elif EXPORT_MEDIA and kind == 'Font':
                            data = obj.read()
                            font = bytes(data.m_FontData)
                            if font:
                                ext = '.otf' if font[:4] == b'OTTO' else '.ttf'
                                record['exports'].append(save(base / f'{stem}{ext}', font))
                    except Exception as exc:
                        record['export_error'] = repr(exc)
                        failures.append({'source': source, 'path_id': obj.path_id, 'type': kind, 'stage': 'export', 'error': repr(exc)})
                    index.write(json.dumps(record, ensure_ascii=True) + '\n')
                if (i + 1) % 20 == 0:
                    index.flush()
                    print(f'{i+1}/{len(inputs)} inputs; {total} objects; {len(failures)} failures', flush=True)
            except Exception as exc:
                failures.append({'source': source, 'stage': 'load', 'error': repr(exc)})
    result = {'input_count': len(inputs), 'object_count': total, 'types': dict(counts), 'unity_versions': sorted(versions), 'failures': failures, 'tool': 'UnityPy ' + UnityPy.__version__}
    savejson(INDEX / 'unity-summary.json', result)
    print(json.dumps(result, ensure_ascii=True), flush=True)

if __name__ == '__main__':
    main()
