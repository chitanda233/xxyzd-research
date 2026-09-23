#!/usr/bin/env python3
"""Check editorial numbers against the packaged L2 data, without reading the APK."""
import gzip,json
from pathlib import Path
R=Path(__file__).resolve().parents[1]
def data(p):
    with (gzip.open(R/p,'rt') if p.endswith('.gz') else (R/p).open()) as f:return json.load(f)

waves=data('in-run/datasets/chapter-1.json')['waves']
plans={x['mission']:x for x in data('in-run/inputs/chapter-1-spawn-plans.json')}
assert len(waves)==15 and sum(x['experience_budget'] for x in waves)==14800
assert [x['configured_monster_count'] for x in waves][0]==28
assert waves[9]['configured_monster_count']==21 and waves[14]['configured_monster_count']==1
assert [x['wave'] for x in waves if x['death_gate']]==[10,15]
assert [x['wave'] for x in waves for y in x['events'] if y['kind']=='punchboard']==[6,11,15]
w1=plans[1001001]
assert w1['total']==[28,28] and w1['counts']['330006']==[26,26] and w1['counts']['320021']==[2,2]
assert len(w1['routes'][0]['options'][0]['items'])==20 and w1['hp_factors']=={'chapter':1.0,'wave':1.0,'mission':0.8}

chapters=[x for x in data('topics/chapter-planning/chapters.json') if not x['hidden']]
assert len(chapters)==70
assert [x['chapter'] for x in chapters if x['waves']==10]==[5,15,25,35,45,55,65]
assert sum(len(x['variants']['base']['chest_waves']) for x in chapters)==208
assert all(9 not in map(int,x['variants']['base']['random_npc_values']) for x in chapters)
assert next(x for x in chapters if x['chapter']==55)['variants']['B']['kill_waves']==[4,7,10]
assert next(x for x in chapters if x['chapter']==10)['variants']['base']['chest_waves']==[11,15]
assert next(x for x in chapters if x['chapter']==60)['variants']['base']['chest_waves']==[6,15]

weights=data('topics/choices-box-evolution/pool-weights.json')
init=[x for x in weights if x['pool']=='InitSurvivorGroup']
assert len(init)==10 and {10000101,10000401,10000601,10001701}<={x['skill_id'] for x in init}
assert len(data('topics/choices-box-evolution/evolution-recipes.json'))==22
assert data('topics/choices-box-evolution/mainline-chest-pool.json')['quantity']['base_weights']==[60,0,30,0,10]

monsters=[x for x in data('topics/monsters/catalog.json.gz') if x['mainline']]
assert len(monsters)==110 and len({x['base']['WaveAIId'] for x in monsters})==15
assert sum(x['first_chapter']<=30 for x in monsters)==100
assert sum(x['ai']!=x['normal_ai'] for x in monsters)==59

build=data('in-run/datasets/skill-build.json')
assert [x['count'] for x in build['pools']]==[18,57,111,22]
nodes={x['id']:x for x in build['nodes']}
assert sum(nodes[i]['type']==1 for i in build['pools'][0]['skill_ids'])==11

skins=data('planner/inputs/Role_Skin.json');stars=data('planner/inputs/Role_SkinStar.json')
assert len(skins)==8 and len(stars)==40
loot=data('planner/inputs/Shop_LootBox.json')
assert len(loot)==7
print('PASS: editorial numbers for 7 topics match packaged L2 data')
