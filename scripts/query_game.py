from pathlib import Path
import sqlite3, json, sys
ROOT=Path(__file__).resolve().parents[1]
if len(sys.argv)<3 or sys.argv[1] not in ('methods','tables'):
    raise SystemExit('Usage: python scripts/query_game.py methods|tables keyword [limit]')
connection=sqlite3.connect(ROOT/'indexes/research.sqlite')
connection.row_factory=sqlite3.Row
limit=int(sys.argv[3]) if len(sys.argv)>3 else 30
rows=connection.execute(f'SELECT * FROM {sys.argv[1]} WHERE name LIKE ? LIMIT ?',('%'+sys.argv[2]+'%',limit)).fetchall()
for row in rows:
    record=dict(row)
    if 'address' in record:
        record['rva_hex']=hex(record['address'])
    print(json.dumps(record,ensure_ascii=False))
