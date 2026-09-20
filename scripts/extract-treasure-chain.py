"""Build reusable treasure event data from decoded APK tables; no decompilation needed."""
import json,hashlib,collections
from pathlib import Path
R=Path(__file__).resolve().parents[1];T=R/'restored/configs/tables';D=R/'research-data/topics/choices-box-evolution'
def read(n):return json.loads((T/(n+'.json')).read_text())
def write(n,v):(D/n).write_text(json.dumps(v,ensure_ascii=False,indent=2)+'\n')
chapters=read('Chapter_MainChapter');missions=read('MissionWaterfallMission_WaterfallMission');waves={r['id']:r for r in read('ChapterWave_Waves')}
by=collections.defaultdict(list)
for m in missions:by[m['id']//1000].append(m)
schedule=[];summary=[]
for c in chapters:
 for variant,suffix in [('base',''),('B','_B')]:
  rows=by[c['missionIdPrev'+suffix]];events=[]
  for m in rows:
   if m['missinType']==9:
    p=waves.get(c['waveId'+suffix]+m['wave']-1,{})
    e={'chapter':c['id'],'variant':variant,'mission_id':m['id'],'wave':m['wave'],'script_time_seconds':m['time']['runtime_value'],'delay_seconds':m['delayTime']['runtime_value'],'mission_type':m['missinType'],'random_npc':m['RandomNpc'],'previous_wave_stop_on_elite_or_boss_killed':p.get('StopByEliteOrBossKilled'),'mission_type_param':m['missionTypeParam']};events.append(e);schedule.append(e)
  summary.append({'chapter':c['id'],'variant':variant,'mission_prefix':c['missionIdPrev'+suffix],'mission_rows':len(rows),'scripted_chest_count':len(events),'waves':[e['wave'] for e in events],'random_npc_values':dict(collections.Counter(str(m['RandomNpc']) for m in rows)),'random_npc_9_rows':sum(m['RandomNpc']==9 for m in rows),'is_hidden':c['isHide']})
write('treasure-schedule.json',schedule);write('treasure-chapters.json',summary)
write('inputs/treasure-config-snapshot.json',{'sources':{n:{'path':'restored/configs/tables/'+n+'.json','sha256':hashlib.sha256((T/(n+'.json')).read_bytes()).hexdigest()} for n in ['Character_entity','Model_model','Consts_Const','MissionWaterfallMission_WaterfallMission','ChapterWave_Waves']},'entities':[r for r in read('Character_entity') if r['ID'] in [7,8,320033,360033]],'models':[r for r in read('Model_model') if r['ID'] in [400006,400010,120137,130015]],'constants':[r for r in read('Consts_Const') if 'Punchboard' in r['keyName']],'mission_scan':{'total_rows':len(missions),'RandomNpc_distribution':dict(collections.Counter(str(m['RandomNpc']) for m in missions)),'selected_fields':['id','wave','time','delayTime','missinType','RandomNpc','missionTypeParam'],'rows':[{k:m[k] for k in ['id','wave','time','delayTime','missinType','RandomNpc','missionTypeParam']} for m in missions if m['missinType']==9 or m['RandomNpc']>0]}})
print({'chapters_and_variants':len(summary),'scripted_events':len(schedule),'random_npc_9_rows':sum(x['random_npc_9_rows'] for x in summary)})
