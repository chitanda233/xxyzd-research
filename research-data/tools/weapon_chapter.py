#!/usr/bin/env python3
"""Rebuild chapter-specific weapon controls from packaged L2 snapshots."""
import json
import sys
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]
TOPIC = ROOT / 'research-data/topics/choices-box-evolution'
CHAPTERS = ROOT / 'research-data/topics/chapter-planning'
OUTPUT = TOPIC / 'chapter-weapon-control.json'


def read(path):
    return json.loads(path.read_text())


def effective_weight(row, group):
    return row['chapter_group_weights'][str(group)] if group else row['weight']


def build():
    chapter_rows = read(TOPIC / 'chapters.json')
    weights = read(TOPIC / 'pool-weights.json')
    planning = {row['chapter']: row for row in read(CHAPTERS / 'chapters.json')}
    waves = read(CHAPTERS / 'waves.json')
    ordinary = {}
    for wave in waves:
        key = (wave['chapter'], wave['branch'])
        ordinary[key] = ordinary.get(key, 0) + (4 in wave['end_ui'])
    records = []
    for chapter in chapter_rows:
        cid = chapter['chapter']
        plan = planning[cid]
        assert chapter['weight_group'] == chapter['weight_group_B'] == plan['weight_group'] == plan['weight_group_B']
        assert chapter['protection_codes'] == plan['protect']
        group = chapter['weight_group']
        pools = {}
        for pool in ('InitSurvivorGroup', 'SurvivorGroup'):
            pools[pool] = {
                str(row['skill_id']): effective_weight(row, group)
                for row in weights if row['pool'] == pool
            }
        records.append({
            'chapter': cid,
            'hidden': plan['hidden'],
            'weight_group': group,
            'weight_column': f'Weight_{group}' if group else 'Weight',
            'skill_type': chapter['skill_type'],
            'new_player_protect_3': 3 in chapter['protection_codes'],
            'suggested_skill_ids': plan['suggested_skills'],
            'suggested_function_ids': plan['suggested_functions'],
            'init_pool_weights': pools['InitSurvivorGroup'],
            'regular_pool_weights': pools['SurvivorGroup'],
            'variants': {
                branch: {
                    'waves': plan['waves'],
                    'exp_budget': plan['variants'][branch]['exp'],
                    'ordinary_end_ui_flags': ordinary[(cid, branch)],
                    'chest_waves': plan['variants'][branch]['chest_waves'],
                } for branch in ('base', 'B')
            },
        })
    return {
        'scope': 'client_1.0.16_static_mainline',
        'records': records,
        'sources': [
            'topics/choices-box-evolution/chapters.json',
            'topics/choices-box-evolution/pool-weights.json',
            'topics/chapter-planning/chapters.json',
            'topics/chapter-planning/waves.json',
        ],
        'limitations': [
            'Weights are configured relative weights before pool filtering, protection, category draws, quality-up, deduplication and player choice.',
            'Init pool applies only while its runtime count is positive; the initialization writer is not established by this static package.',
            'Ordinary end UI flags are planned wave events, not the number of actual skill selections.',
            'Suggested skills are separate chapter fields and are not treated as pool gates.',
        ],
    }


def validate(data):
    rows = data['records']
    assert len(rows) == 71
    visible = [row for row in rows if not row['hidden']]
    assert [row['chapter'] for row in visible] == list(range(1, 71))
    assert {row['chapter'] for row in visible if row['weight_group']} == {1, 2, 3, 4, 6, 8}
    assert {row['chapter'] for row in visible if row['new_player_protect_3']} == set(range(2, 11))
    assert all(row['skill_type'] == 2 for row in rows)
    assert all(len(row['init_pool_weights']) == 10 and len(row['regular_pool_weights']) == 18 for row in rows)
    assert all(row['regular_pool_weights']['11000301'] == 0 for row in rows)
    assert all(row['variants']['base'] == row['variants']['B'] for row in rows)
    assert {row['chapter'] for row in visible if row['variants']['base']['waves'] == 10} == {5, 15, 25, 35, 45, 55, 65}
    assert {row['chapter'] for row in visible if len(row['variants']['base']['chest_waves']) == 2} == {10, 60}
    assert {row['chapter'] for row in visible if row['variants']['base']['ordinary_end_ui_flags'] != row['variants']['base']['waves'] - 1} == {4}
    assert next(row for row in visible if row['chapter'] == 4)['variants']['base']['ordinary_end_ui_flags'] == 15
    assert all(row['variants']['base']['exp_budget'] == (7300 if row['variants']['base']['waves'] == 10 else 14800) for row in visible)
    return {'status': 'passed', 'chapters': len(visible), 'weight_group_chapters': 6,
            'protected_chapters': 9}


if __name__ == '__main__':
    action = sys.argv[1] if len(sys.argv) > 1 else 'validate'
    data = build()
    result = validate(data)
    if action == 'rebuild':
        OUTPUT.write_text(json.dumps(data, ensure_ascii=False, indent=2) + '\n')
    elif action == 'validate':
        assert read(OUTPUT) == data
    else:
        raise SystemExit('usage: weapon_chapter.py [rebuild|validate]')
    print(json.dumps(result, ensure_ascii=False))
