#!/usr/bin/env python3
"""Portable monster research: snapshots, exact joins, report, checks and export."""
import collections, gzip, hashlib, html, json, re, shutil, struct, sys, zipfile
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
D=ROOT/'research-data/topics/monsters'
T=ROOT/'restored/configs/tables'
TABLES=['Character_entity','Character_HandBook','Character_HandBookTag','Character_MonsterAbility','Character_MonsterTrait','Character_MonsterTagName','Character_death','Weapon_Weapon','Weapon_BulletFormation','Bullet_Bullet','Skill_Main','Skill_Trigger','MonsterAIPool_Call','MonsterAIPool_Rush','MovePath_MovePath','Chapter_MainChapter','ChapterWave_Waves','MissionWaterfallMission_WaterfallMission','Mission_PositionGroupMonsterFlushConfig','Mission_PositionMonsterFlushConfig','Mission_RandomMonsterFlushConfig','Mission_BeeMonsterFlushConfig']
def read(p):
 if not p.exists() and p.suffix=='.json':p=p.with_suffix('.json.gz')
 return json.loads(gzip.decompress(p.read_bytes()) if p.suffix=='.gz' else p.read_text())
def write(p,v):
 p.parent.mkdir(parents=True,exist_ok=True);p.write_text(json.dumps(v,ensure_ascii=False,separators=(',',':'))+'\n')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def simple(v):
 if isinstance(v,dict):return v['decimal'] if 'decimal' in v else {k:simple(x) for k,x in v.items()}
 if isinstance(v,list):return [simple(x) for x in v]
 return v
def table(n):
 p=D/'inputs'/(n+'.json');return read(p if p.exists() else p.with_suffix('.json.gz'))
def keyed(n):return {r.get('id',r.get('ID')):r for r in table(n)}
class Reader:
 def __init__(self,b):self.b=b;self.o=0
 def take(self,n):
  assert 0<=n<=len(self.b)-self.o,(self.o,n,len(self.b))
  b=self.b[self.o:self.o+n];self.o+=n;return b
 def i(self):return struct.unpack('<i',self.take(4))[0]
 def q(self):return struct.unpack('<q',self.take(8))[0]
 def count(self):
  n=self.i();assert 0<=n<100000,n;return n
 def pos(self):return [self.q()/65536 for _ in range(3)]
 def rect(self):return [self.i() for _ in range(8)]
 def string(self):
  n=0;shift=0
  while True:
   x=self.take(1)[0];n|=(x&127)<<shift
   if x<128:break
   shift+=7;assert shift<=28
  return self.take(n).decode('utf-8')
def decode_map(b):
 # Exact serialized order from MissionData.Deserialize / ReadRect / ReadPos.
 r=Reader(b);w,h=r.i(),r.i();sky=r.take(1)[0];zero=r.pos();bound=r.rect();sky_zero=r.pos();sky_bound=r.rect()
 rects=[[r.rect() for _ in range(r.count())] for _ in range(4)]
 r.take(w*h)
 doors=[dict(position=r.pos(),type=r.i()) for _ in range(r.count())]
 groups=[]
 for _ in range(r.count()):
  name=r.string();items=[]
  for _ in range(r.count()):
   items.append(dict(entity=r.i(),position=r.pos(),rotation=r.q()/65536,delay=r.q()/65536,extra=[r.i() for _ in range(r.count())]))
  groups.append(dict(name=name,items=items))
 map_items=[dict(position=r.pos(),pool=r.i(),rotation=r.q()/65536) for _ in range(r.count())]
 decorations=[dict(id=r.i(),position=r.pos(),width=r.i(),height=r.i()) for _ in range(r.count())]
 assert r.o==len(b),(r.o,len(b))
 return dict(width=w,height=h,zero=zero,groups=groups,bytes_consumed=r.o)
def snapshot():
 sources=[]
 def save(src,dst,value=None):
  if value is None:value=read(src)
  write(dst,value)
  if dst.stat().st_size>300000:
   dst.with_suffix('.json.gz').write_bytes(gzip.compress(dst.read_bytes(),mtime=0));dst.unlink();dst=dst.with_suffix('.json.gz')
  sources.append(dict(path=str(dst.relative_to(D)),source=str(src.relative_to(ROOT)),source_sha256=sha(src)))
 for n in TABLES:save(T/(n+'.json'),D/'inputs'/(n+'.json'))
 language=read(T/'Language_languagetable.json')
 save(T/'Language_languagetable.json',D/'inputs/language-zh.json',{r['id']:r['chinesesimplified'] for r in language})
 save(ROOT/'research-data/in-run/baseline.json',D/'inputs/baseline.json')
 for p in (ROOT/'restored/configs/json').glob('bake-*/*_MovePath*.json'):
  save(p,D/'inputs/paths'/(p.name.split('_',1)[1]))
 needed={name for row in read(T/'Mission_PositionMonsterFlushConfig.json') for name in row['missionPool']}
 for p in (D/'inputs/maps').glob('*'):p.unlink()
 for p in (ROOT/'restored/configs/textassets').glob('qresource-tiledmap*/*'):
  if p.is_file():
   decoded=decode_map(p.read_bytes());decoded['groups']=[g for g in decoded['groups'] if g['name'] in needed]
   if decoded['groups']:save(p,D/'inputs/maps'/(p.name.split('_',1)[1]+'.json'),decoded)
 (D/'evidence').mkdir(parents=True,exist_ok=True)
 for p in (ROOT/'evidence/monster-topic').glob('*.asm'):
  dst=D/'evidence'/p.name;shutil.copyfile(p,dst);sources.append(dict(path=str(dst.relative_to(D)),source=str(p.relative_to(ROOT)),source_sha256=sha(p)))
 write(D/'sources.json',sources)
 print('snapshotted',len(sources),'sources')
def params(s):
 try:return json.loads(s) if isinstance(s,str) and s.strip() else {}
 except ValueError:return {'unparsed':s}
def references(value):
 """Explicit ID-bearing configuration fields only; not a runtime execution claim."""
 out=[]
 def walk(v,path=''):
  if isinstance(v,str):
   if v.lstrip().startswith(('{','[')):
    parsed=params(v)
    if not (isinstance(parsed,dict) and 'unparsed' in parsed):walk(parsed,path)
  elif isinstance(v,dict):
   for k,x in v.items():
    key=k.lower();kind=None
    if ('weapon' in key and 'id' in key):kind='weapon'
    elif ('bullet' in key and 'id' in key):kind='bullet'
    elif ('monster' in key and 'id' in key):kind='monster'
    elif key=='pathid':kind='path'
    if kind:
     vals=x if isinstance(x,list) else [x]
     for val in vals:
      if isinstance(val,int) and val>0:out.append(dict(kind=kind,id=val,field=path+'.'+k))
    walk(x,path+'.'+k)
  elif isinstance(v,list):
   for i,x in enumerate(v):walk(x,path+f'[{i}]')
 walk(value);return out
def merge_bounds(parts):
 out={}
 for part in parts:
  for k,v in part.items():
   z=out.setdefault(k,[0,0]);z[0]+=v[0];z[1]+=v[1]
 return out
def alternative_bounds(parts):
 ids={k for p in parts for k in p}
 return {k:[min(p.get(k,[0,0])[0] for p in parts),max(p.get(k,[0,0])[1] for p in parts)] for k in ids}
def derive():
 entities={k:simple(v) for k,v in keyed('Character_entity').items()};chapters=table('Chapter_MainChapter');waves=keyed('ChapterWave_Waves')
 missions=collections.defaultdict(list)
 for r in table('MissionWaterfallMission_WaterfallMission'):missions[r['id']//1000].append(simple(r))
 positions=keyed('Mission_PositionMonsterFlushConfig');groups=keyed('Mission_PositionGroupMonsterFlushConfig');randoms=keyed('Mission_RandomMonsterFlushConfig')
 maps={}
 for p in sorted((D/'inputs/maps').glob('*')):
  for g in read(p)['groups']:
   assert g['name'] not in maps,g['name'];maps[g['name']]=g['items']
 missing=[]
 def tile(pid,overrides):
  cfg=positions[pid];opts=[]
  for name in cfg['missionPool']:
   if name not in maps:missing.append(name);continue
   rows=maps[name]
   for override in overrides or [None]:
    counts=collections.Counter(override if override is not None else r['entity'] for r in rows)
    opts.append(dict(template=name,override=override,slots=len(rows),counts={str(k):[v,v] for k,v in counts.items()}))
  return dict(config=pid,options=opts,counts=alternative_bounds([o['counts'] for o in opts]) if opts else {},total=[min(o['slots'] for o in opts),max(o['slots'] for o in opts)])
 occurrences=[];wave_totals=[];chapter_totals=[]
 for c in chapters:
  if c['isHide']:continue
  for branch,suf in [('base',''),('B','_B')]:
   events=[]
   for r in missions[c['missionIdPrev'+suf]]:
    if r['missinType']==9:continue
    components=[]
    if r['positionMonster']:
     part=tile(r['positionMonster'],r['Monster']);part['route']='position';components.append(part)
    if r['positionGroupMonster']:
     group_opts=[]
     for gid in r['positionGroupMonster']:
      items=[]
      for g in params(groups[gid]['flushPool']):
       t=tile(g['FlushConfigId'],g['Monster']);t['delay']=g['Delay'];items.append(t)
      group_opts.append(dict(id=gid,items=items,counts=merge_bounds([x['counts'] for x in items]),total=[sum(x['total'][i] for x in items) for i in (0,1)]))
     components.append(dict(route='group',options=group_opts,counts=alternative_bounds([x['counts'] for x in group_opts]),total=[min(x['total'][0] for x in group_opts),max(x['total'][1] for x in group_opts)]))
    if r['randomMonster']:
     opts=[]
     for rid in r['randomMonster']:
      counts=collections.Counter(randoms[rid]['entityId']);opts.append(dict(id=rid,counts={str(k):[v,v] for k,v in counts.items()}))
     sequences=[randoms[rid]['entityId'] for rid in r['randomMonster']]
     # CalRandomMonster appends groups until numberRandom is reached, truncating the last group.
     # Bounds over all possible sequences; no assumed probability distribution.
     dp={0:{}}
     for n in range(1,r['numberRandom']+1):
      alternatives=[]
      for seq in sequences:
       assert seq
       head=collections.Counter(seq[:n]);alternatives.append(merge_bounds([{str(k):[v,v] for k,v in head.items()},dp[max(0,n-len(seq))]]))
      dp[n]=alternative_bounds(alternatives)
     components.append(dict(route='random',options=opts,number=r['numberRandom'],counts=dp[r['numberRandom']],total=[r['numberRandom']]*2))
    counts=merge_bounds([p['counts'] for p in components]);repeat=int(r['interval'][0]) if r['interval'] else 1
    counts={k:[v[0]*repeat,v[1]*repeat] for k,v in counts.items()}
    for k in counts:assert int(k) in entities,(r['id'],k)
    w=simple(waves[c['waveId'+suf]+r['wave']]);hp=r['hpUpgrade'] or 1;atk=r['attackUp'] or 1
    event=dict(chapter=c['id'],branch=branch,wave=r['wave'],mission=r['id'],seconds=r['time'],delay=r['delayTime'],interval=r['interval'],repeat=repeat,mission_type=r['missinType'],routes=components,counts=counts,total=[repeat*sum(p['total'][i] for p in components) for i in (0,1)],
      hp_factors=dict(chapter=simple(c['hpUpgrade'+suf]),wave=w['hpUpgrade'],mission=hp),attack_factors=dict(chapter=simple(c['attackUp'+suf]),wave=w['attackUp'],mission=atk),multi_hp=r['MultiHp'],refresh_count=r['refreshCount'],mission_pool=r['missionPool'])
    events.append(event);occurrences.append(event)
   for i in range(1,c['waveNum']+1):
    selected=[r for r in events if r['wave']==i];counts=merge_bounds([r['counts'] for r in selected])
    wave_totals.append(dict(chapter=c['id'],branch=branch,wave=i,counts=counts,total=[sum(r['total'][j] for r in selected) for j in (0,1)],mission_ids=[r['mission'] for r in selected]))
   counts=merge_bounds([r['counts'] for r in events]);chapter_totals.append(dict(chapter=c['id'],branch=branch,counts=counts,total=[sum(r['total'][j] for r in events) for j in (0,1)],monster_ids=sorted(map(int,counts)),waves=c['waveNum']))
 assert not missing,sorted(set(missing))
 bymonster=collections.defaultdict(list)
 for r in occurrences:
  for k,v in r['counts'].items():
   if v[1]:bymonster[int(k)].append(r)
 lang=read(D/'inputs/language-zh.json');handbook=keyed('Character_HandBook');abilities=keyed('Character_MonsterAbility');traits=keyed('Character_MonsterTrait');skills=keyed('Skill_Main');weapons=keyed('Weapon_Weapon');bullets=keyed('Bullet_Bullet')
 catalog=[];all_links=[];combat_weapons=set();combat_bullets=set()
 for eid,e in entities.items():
  if e['Type'] not in (2,3,201):continue
  hb=handbook.get(eid,handbook.get(e['CharacterID'],{}));name=lang.get(hb.get('name',''),lang.get('MonsterName_'+str(eid),lang.get('MonsterName_'+str(e['CharacterID']),str(eid))))
  rows=bymonster[eid];ab=[]
  for aid in e['MonsterAbility']:
   a=abilities.get(aid,{});ab.append(dict(id=aid,effects=a.get('effects',[]),description=[lang.get(x,x) for x in a.get('des',[])]))
  tr=[]
  for tid in e['MonsterTraitID']:
   t=traits[tid];tr.append(dict(id=tid,skill=t['SkillId'],config=simple(skills.get(t['SkillId'],{}))))
  if name.isdigit():name={2:'未命名普通怪',201:'未命名精英',3:'未命名首领'}[e['Type']]+' '+str(eid)
  roots=[dict(kind='weapon',id=x,field='WeaponID') for x in e['WeaponID']]
  for k in ['deathParams','WaveAIParameters','BulletMod1','BulletMod2','BulletMod3','WeaponMod1','WeaponMod2','WeaponMod3']:
   roots.extend(dict(x,field=k+x['field']) for x in references(e[k]))
  refs=list(roots);seen=set();queue=[x['id'] for x in refs if x['kind']=='weapon'];linked_bullets=set()
  while queue:
   wid=queue.pop()
   if wid in seen:continue
   seen.add(wid)
   if wid not in weapons:continue
   wr=simple(weapons[wid]);linked_bullets.add(wr['BulletId'])
   refs.append(dict(kind='bullet',id=wr['BulletId'],field=f'weapon:{wid}.BulletId'))
   for x in references({k:v for k,v in wr.items() if 'Mod' in k or k=='TrajectoryParams'}):
    refs.append(dict(x,field=f'weapon:{wid}'+x['field']))
    if x['kind']=='weapon':queue.append(x['id'])
    elif x['kind']=='bullet':linked_bullets.add(x['id'])
  numeric=[]
  for b in ['base','B']:
   rr=[r for r in rows if r['branch']==b]
   if rr:
    hp=[e['HP']*r['hp_factors']['chapter']*r['hp_factors']['wave']*r['hp_factors']['mission'] for r in rr]
    atk=[e['Attack']*r['attack_factors']['chapter']*r['attack_factors']['wave']*r['attack_factors']['mission'] for r in rr]
    numeric.append(dict(branch=b,hp_nominal_min=min(hp),hp_nominal_max=max(hp),attack_nominal_min=min(atk),attack_nominal_max=max(atk)))
  c=dict(id=eid,name=name,family=e['CharacterID'],type=e['Type'],mainline=bool(rows),base=e,abilities=ab,traits=tr,ai=params(e['WaveAIParameters']),normal_ai=params(e['AIParameters']),
    chapters={b:sorted({r['chapter'] for r in rows if r['branch']==b}) for b in ['base','B']},first_chapter=min((r['chapter'] for r in rows),default=None),
    weapon_ids=e['WeaponID'],linked_weapon_ids=sorted(seen),linked_bullet_ids=sorted(linked_bullets),references=refs,nominal_ranges=numeric,
    weapon_details=[dict(weapon=simple(weapons[x]),bullet=simple(bullets.get(weapons[x]['BulletId'],{}))) for x in sorted(seen) if x in weapons])
  catalog.append(c)
  if rows:
   combat_weapons.update(seen);combat_bullets.update(linked_bullets);all_links.extend(dict(monster=eid,**x) for x in refs)
 return dict(catalog=catalog,occurrences=occurrences,waves=wave_totals,chapters=chapter_totals,maps=maps,links=all_links,
             weapons=[simple(weapons[i]) for i in sorted(combat_weapons) if i in weapons],bullets=[simple(bullets[i]) for i in sorted(combat_bullets) if i in bullets])
def rebuild():
 data=derive()
 for name,value in data.items():
  p=D/(name+'.json');write(p,value)
  if p.stat().st_size>1000000:
   p.with_suffix('.json.gz').write_bytes(gzip.compress(p.read_bytes(),mtime=0));p.unlink()
 print({k:len(v) for k,v in data.items()})
if __name__=='__main__':
 if sys.argv[1]=='snapshot':snapshot()
 elif sys.argv[1]=='rebuild':rebuild()
 else:
  import monster_report
  monster_report.main(sys.argv[1])
