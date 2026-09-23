# -*- coding: utf-8 -*-
#!/usr/bin/env python3
"""Read, validate and render the independently transferable choice topic. Standard library only."""
import json,hashlib,html,sys
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];D=ROOT/'research-data/topics/choices-box-evolution'
def read(p):return json.loads((D/p).read_text())
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def dump(p,v):p.write_text(json.dumps(v,ensure_ascii=False,indent=2)+'\n')
def validate():
 for s in read('sources.json'):assert sha(D/s['path'])==s['sha256'],s['path']
 for f in read('facts.json'):
  assert f['status'] in ['verified_static','unresolved']
  for p in f['evidence']:assert (D/p).is_file(),p
 c=read('chapters.json');assert len(c)==71 and all(r['skill_type']==2 for r in c)
 assert [r['chapter'] for r in c if 3 in r['protection_codes']]==list(range(2,11))
 s={r['id']:r for r in read('inputs/Skill_Main.json')};r=read('evolution-recipes.json');assert len(r)==22
 for row in r:
  assert row['candidate_weight']==5000
  for owner in row['source_rows']:
   a=s[owner];dep=next(i for i in row['required_skill_ids'] if i!=owner)
   assert (dep,row['result_skill_id']) in list(zip(a['UnlockUpgradeNeddSkill'],a['UnlockUpgradeId']))
 families={}
 for row in r:
  family=row['result_skill_id']//100;families.setdefault(family,{})[row['result_skill_id']%100]=row
 assert len(families)==11 and all(set(stages)=={1,2} for stages in families.values())
 for stages in families.values():
  first,second=stages[1],stages[2]
  assert s[first['required_skill_ids'][0]]['SkillStar']==3
  assert s[second['required_skill_ids'][0]]['SkillStar']==6
  assert s[first['required_skill_ids'][1]]['SkillStar']==1
  assert s[second['required_skill_ids'][1]]['SkillStar']==2
  assert s[second['result_skill_id']]['NeedSkills']==[first['result_skill_id']]
  assert 'BulletAttack%=50' in s[second['result_skill_id']]['AddAttributes']
 base_modules={x['skill_id'] for x in read('pool-weights.json') if x['pool']=='SurvivorGroup' and x['skill_type']==2}
 recipe_modules={row['required_skill_ids'][1] for row in r if row['result_skill_id']%100==1}
 assert len(base_modules)==7 and len(recipe_modules)==6 and base_modules-recipe_modules=={11000301}
 for ex in read('probability-examples.json'):
  assert abs(sum(ex['probabilities'])-1)<1e-12
  if 'weights' in ex:assert all(abs(w/sum(ex['weights'])-p)<1e-12 for w,p in zip(ex['weights'],ex['probabilities']))
 for hit in read('inputs/native-constant-arrays.json')['hits']:assert hashlib.sha256(bytes.fromhex(hit['bytes_hex'])).hexdigest().upper()==hit['field_hash']
 chain=read('treasure-chain.json')
 for step in chain['chain']:
  for p in step['evidence']:assert (D/p).is_file(),p
 tc=read('treasure-chapters.json');ts=read('treasure-schedule.json');snap=read('inputs/treasure-config-snapshot.json')
 assert len(tc)==142 and len(ts)==416
 assert sum(r['random_npc_9_rows'] for r in tc)==0
 assert sum(r['scripted_chest_count'] for r in tc)==len(ts)
 source={r['id']:r for r in snap['mission_scan']['rows']}
 for r in ts:
  a=source[r['mission_id']];assert (a['wave'],a['missinType'],a['time']['runtime_value'])==(r['wave'],9,r['script_time_seconds'])
 assert set(snap['mission_scan']['RandomNpc_distribution'])=={'0','1'}
 if (D/'manifest.json').exists():
  mm=read('manifest.json');actual={str(p.relative_to(D)) for p in D.rglob('*') if p.is_file() and p.name!='manifest.json'};assert actual==set(mm)
  for p,h in mm.items():assert sha(D/p)==h,p
 return {'status':'passed','facts':len(read('facts.json')),'recipes':len(read('evolution-recipes.json')),'sources':len(read('sources.json')),'scope':'static references, hashes, recipe joins and conditional arithmetic; no live-game verification'}
def manifest():
 dump(D/'manifest.json',{str(p.relative_to(D)):sha(p) for p in sorted(D.rglob('*')) if p.is_file() and p.name!='manifest.json'})
def render():
 __import__('planner_reports').render_page('choices-box-evolution')

if __name__=='__main__':
 arg=sys.argv[1] if len(sys.argv)>1 else 'validate'
 if arg=='manifest':manifest();print(json.dumps(validate(),ensure_ascii=False))
 elif arg=='validate':print(json.dumps(validate(),ensure_ascii=False))
 elif arg=='render':validate();render();print('Rendered canonical topic report')
 elif arg.startswith('skill:'):
  sid=int(arg[6:]);print(json.dumps([r for r in read('evolution-recipes.json') if sid in r['required_skill_ids']+[r['result_skill_id']]],ensure_ascii=False,indent=2))
 else:print(json.dumps([f for f in read('facts.json') if arg in json.dumps(f,ensure_ascii=False)],ensure_ascii=False,indent=2))
