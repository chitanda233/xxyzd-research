"""Validate a cloned gameplay handoff using only the Python standard library."""
from pathlib import Path
import hashlib
import json

ROOT = Path(__file__).resolve().parents[1]


def digest(path):
    with path.open('rb') as stream:
        return hashlib.file_digest(stream, 'sha256').hexdigest()


def main():
    errors = []
    files = json.loads((ROOT / 'indexes/apk-files.json').read_text(encoding='utf-8'))
    for entry in files:
        path = ROOT / entry['extracted_path']
        if not path.is_file() or digest(path) != entry['sha256']:
            errors.append(entry['extracted_path'])
    tables = json.loads((ROOT / 'indexes/config-tables.json').read_text(encoding='utf-8'))
    for table in tables:
        raw = ROOT / table['source']
        if not raw.is_file() or digest(raw) != table['sha256']:
            errors.append(table['source'])
        if table['status'] == 'decoded':
            rows = json.loads((ROOT / table['output']).read_text(encoding='utf-8'))
            if len(rows) != table['rows']:
                errors.append(table['output'])
    handoff = json.loads((ROOT / 'indexes/handoff-summary.json').read_text(encoding='utf-8'))
    for entry in handoff['lfs_files']:
        path = ROOT / entry['path']
        if not path.is_file() or digest(path) != entry['sha256']:
            errors.append(entry['path'] + ' (missing LFS content; run git lfs pull)')
    print(json.dumps({'apk_entries_checked': len(files), 'raw_tables_checked': len(tables),
                      'lfs_files_checked': len(handoff['lfs_files']), 'errors': errors},
                     ensure_ascii=False, indent=2))
    return 1 if errors else 0


if __name__ == '__main__':
    raise SystemExit(main())
