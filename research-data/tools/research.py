#!/usr/bin/env python3
"""Portable in-run research: validate/query/rebuild/export, Python stdlib only.
No APK, database, decompiler, network or third-party packages required.
"""
import argparse, collections, hashlib, html, json, re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
DATA=ROOT/'research-data/in-run'
def read(path):return json.loads(path.read_text(encoding='utf-8'))
def write(path,value):path.parent.mkdir(parents=True,exist_ok=True);path.write_text(json.dumps(value,ensure_ascii=False,indent=2)+'\n',encoding='utf-8')
def digest(path):return hashlib.sha256(path.read_bytes()).hexdigest()
def table(name):return read(DATA/'inputs'/(name+'.json'))
def dec(value):return value['decimal'] if isinstance(value,dict) else value

def derive():
    ch=table('Chapter_MainChapter')[0];missions=table('MissionWaterfallMission_WaterfallMission')
    cfg={r['id']:r for r in table('ChapterWave_Waves')};entities={r['ID']:r for r in table('Character_entity')}
    plans={r['mission']:r for r in table('chapter-1-spawn-plans')}
    exp=table('Exp_exp');waves=[];cumulative=0
    for w in range(1,ch['waveNum']+1):
        rows=[r for r in missions if r['wave']==w];start=min(dec(r['time']) for r in rows)
        nr=[r for r in missions if r['wave']==w+1];next_start=min((dec(r['time']) for r in nr),default=None)
        events=[];counts=collections.Counter()
        for m in rows:
            base=dec(m['time'])
            if m['missinType']:
                events.append(dict(kind='punchboard' if m['missinType']==9 else 'boss_task' if m['missinType']==2 else 'mission_event',script_time_seconds=base,mission_id=m['id'],mission_type=m['missinType'],source_ref={'source_id':'T:MissionWaterfallMission_WaterfallMission','row_id':m['id']}))
            if m['missinType']==9:
                assert not m['Monster'] and not m['positionGroupMonster'] and not m['randomMonster'];continue
            plan=plans[m['id']]
            assert plan['total'][0]==plan['total'][1], 'Chapter 1 requires a distribution for non-fixed totals'
            composition={int(k):v[0] for k,v in plan['counts'].items()}
            assert all(v[0]==v[1] for v in plan['counts'].values())
            counts.update(composition)
            if composition:
                events.append(dict(kind='spawn_plan',script_time_seconds=base+dec(m['delayTime']),mission_id=m['id'],composition=composition,routes=plan['routes'],repeat=plan['repeat'],interval=plan['interval'],time_basis='mission_start; member delays and template positions remain in routes',source_ref={'source_id':'D:chapter-1-spawn-plans','row_id':m['id']}))
        wc=cfg[ch['waveId']+w];cumulative+=wc['WaveAllExp'];events.sort(key=lambda e:e['script_time_seconds'])
        waves.append(dict(wave=w,script_start_seconds=start,next_script_start_seconds=next_start,nominal_window_seconds=None if next_start is None else next_start-start,configured_monster_count=sum(counts.values()),count_semantics='scripted_maximum_not_guaranteed_realized' if wc['StopByEliteOrBossKilled'] else 'configured_spawn_count',composition=dict(sorted(counts.items())),special_entities=[eid for eid in sorted(counts) if entities[eid]['Type'] in [201,3]],death_gate=bool(wc['StopByEliteOrBossKilled']),experience_budget=wc['WaveAllExp'],cumulative_experience=cumulative,level_threshold=exp[w-1]['waveExp'],ordinary_growth_node=4 in wc['WaveEndSpecialUIType'],wave_start_ui=wc['WaveStartSpecialUIType'],wave_end_ui=wc['WaveEndSpecialUIType'],mission_ids=[r['id'] for r in rows],events=events,fact_ids=['F02','F03','F04','F05','F06'],source_ref={'source_id':'T:ChapterWave_Waves','row_id':wc['id']}))
    chapter=dict(chapter_id=ch['id'],variant='base_non_B',time_basis='configured_script_seconds_not_wall_clock',waves=waves,source_ids=['T:Chapter_MainChapter','T:MissionWaterfallMission_WaterfallMission','T:ChapterWave_Waves','T:Exp_exp'])
    lang={r['id']:r['chinesesimplified'] for r in table('Language_languagetable')};skills=table('Skill_Main');skillids={x['id'] for x in skills}
    nodes=[];edges=[];recipes=[];pools=[]
    for name in ['SurvivorGroup','BranchSurvivorGroup','UpgradeSurvivorGroup','UpgradeSkillGroup']:
        rr=table('SkillGroup_'+name);pools.append(dict(id=name,count=len(rr),skill_ids=[r['GetID'] for r in rr],source_id='T:SkillGroup_'+name))
    for s in skills:
        nodes.append(dict(id=s['id'],name=lang.get(s['LanguageNameId'],str(s['LanguageNameId'])),description_template=lang.get(s['LanguageInfoId'],str(s['LanguageInfoId'])),description_args=s['LanguageInfoArgs'],type=s['SkillType'],star=s['SkillStar'],quality=s['Quality'],source_ref={'source_id':'T:Skill_Main','row_id':s['id']}))
        for field in ['NextSkill','CoverSkill','UpgradeSkillId','PreSkillIds','RejectSkills','NeedSkills','BanSkillS','SuperNeedSkill','RepeatSkills']:
            v=s[field];v=v if isinstance(v,list) else [v]
            for target in v:
                if target:edges.append(dict(source=s['id'],target=target,relation=field,target_in_dataset=target in skillids,source_ref={'source_id':'T:Skill_Main','row_id':s['id'],'field':field}))
        needed=s['UnlockUpgradeNeddSkill'];results=s['UnlockUpgradeId']
        if needed or results:
            assert len(needed)==len(results),(s['id'],'parallel recipe arrays mismatch')
            for n,result in zip(needed,results):recipes.append(dict(owner_skill=s['id'],required_skill=n,result_skill=result,kind='configuration_dependency_not_guaranteed_draw',source_ref={'source_id':'T:Skill_Main','row_id':s['id']}))
    build=dict(variant='base_non_B',pools=pools,nodes=nodes,edges=edges,recipes=recipes,limits=['描述保留模板与参数，未伪装成已经插值的实机文案','关系是配置关系，不是已开放或必出保证；_B原始列只在inputs保留'])
    return json.loads(json.dumps({'chapter-1.json':chapter,'skill-build.json':build}))

def rebuild():
    for name,value in derive().items():write(DATA/'datasets'/name,value)

def validate():
    sources=read(DATA/'sources.json');facts=read(DATA/'facts.json');questions=read(DATA/'questions.json');flow=read(DATA/'flow.json')
    sids={s['id'] for s in sources};fids={f['id'] for f in facts}
    assert len(sids)==len(sources) and len(fids)==len(facts)
    for s in sources:
        p=DATA/s['path'];assert p.is_file(),p;assert digest(p)==s['sha256'],str(p)+' changed: update source registry only after review'
        if s['kind'] in ['config_rows','derived_rows']:
            rr=read(p);assert [r[s['row_key']] for r in rr]==s['row_ids'];assert len(rr)==s['record_count']
    allowed={'verified_static','designed_only','interpretation'}
    for f in facts:
        assert f['status'] in allowed and f['source_ids'] and set(f['source_ids'])<=sids,f['id']
        assert all(k in f for k in ['statement','limitations','parameters','report_anchor','applies_to'])
    assert len({q['id'] for q in questions})==len(questions)
    for q in questions:assert set(q['fact_ids'])<=fids and q['already_checked'] and q['required_evidence']
    nodeids={n['id'] for n in flow['nodes']}
    for e in flow['edges']:assert e['source'] in nodeids and e['target'] in nodeids and set(e['fact_ids'])<=fids
    for n,v in derive().items():assert read(DATA/'datasets'/n)==v,n+' stale: run rebuild'
    waves=read(DATA/'datasets/chapter-1.json')['waves']
    assert [w['configured_monster_count'] for w in waves]==[28,18,26,36,39,41,9,49,65,21,15,87,105,130,1]
    assert [w['wave'] for w in waves if w['death_gate']]==[10,15]
    assert [w['wave'] for w in waves if w['ordinary_growth_node']]==list(range(1,15))
    assert all(w['cumulative_experience']==w['level_threshold'] for w in waves)
    assert [w['wave'] for w in waves for e in w['events'] if e['kind']=='punchboard']==[6,11,15]
    assert sum(len(w['mission_ids']) for w in waves)==78
    build=read(DATA/'datasets/skill-build.json');assert [p['count'] for p in build['pools']]==[18,57,111,22]
    types=collections.Counter(n['type'] for n in build['nodes'] if n['id'] in build['pools'][0]['skill_ids']);assert types[1]==11 and types[2]==7
    result={'status':'passed','baseline':read(DATA/'baseline.json')['dataset_id'],'sources_checked':len(sources),'facts_checked':len(facts),'waves_checked':15,'recomputed_from_packaged_inputs':True,'no_apk_or_decompiler_required':True,'scope':'Static baseline, references, hashes, relationships and exact recomputation; not live-game validation'}
    return result

def manifest():
    files={str(p.relative_to(DATA)):dict(sha256=digest(p),bytes=p.stat().st_size) for p in sorted(DATA.rglob('*')) if p.is_file() and p.name!='manifest.json'}
    write(DATA/'manifest.json',{'schema_version':'1.0.0','dataset_id':read(DATA/'baseline.json')['dataset_id'],'files':files})

def main():
    ap=argparse.ArgumentParser(description=__doc__);ap.add_argument('command',choices=['validate','rebuild','query','manifest','export']);ap.add_argument('term',nargs='?');a=ap.parse_args()
    if a.command=='rebuild':rebuild();print(json.dumps(validate(),ensure_ascii=False));manifest()
    elif a.command=='validate':
        result=validate()
        if (DATA/'manifest.json').exists():
            m=read(DATA/'manifest.json')['files'];current={str(p.relative_to(DATA)) for p in DATA.rglob('*') if p.is_file() and p.name!='manifest.json'};assert current==set(m),'manifest file inventory mismatch'
            for path,meta in m.items():assert digest(DATA/path)==meta['sha256'],path
        print(json.dumps(result,ensure_ascii=False,indent=2))
    elif a.command=='manifest':validate();manifest()
    elif a.command=='query':
        term=a.term or ''
        if term.startswith('wave:'):result=next(w for w in read(DATA/'datasets/chapter-1.json')['waves'] if w['wave']==int(term[5:]))
        elif term.startswith('skill:'):
            sid=int(term[6:]);b=read(DATA/'datasets/skill-build.json');result={'node':next(n for n in b['nodes'] if n['id']==sid),'edges':[e for e in b['edges'] if sid in [e['source'],e['target']]],'recipes':[r for r in b['recipes'] if sid in [r['owner_skill'],r['required_skill'],r['result_skill']]]}
        else:
            found=[f for f in read(DATA/'facts.json') if term.lower() in json.dumps(f,ensure_ascii=False).lower()];needed={i for f in found for i in f['source_ids']};result={'facts':found,'sources':[s for s in read(DATA/'sources.json') if s['id'] in needed],'questions':[q for q in read(DATA/'questions.json') if set(q['fact_ids']) & {f['id'] for f in found}]}
        print(json.dumps(result,ensure_ascii=False,indent=2))
    elif a.command=='export':
        raise SystemExit('证据按目录交接，不生成压缩包；请查看 research-data/。')
if __name__=='__main__':main()
