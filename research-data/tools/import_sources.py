"""Explicit L1-to-L2 snapshot import. Full repository required; review changes before rebuild."""
import json,hashlib,re
from pathlib import Path
R=Path(__file__).resolve().parents[2];D=R/'research-data/in-run';T=R/'restored/configs/tables'
def read(n):return json.loads((T/(n+'.json')).read_text())
def write(p,d):p.write_text(json.dumps(d,ensure_ascii=False,indent=2)+'\n')
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
sources=[]; catalog={x['name']:x for x in json.loads((R/'indexes/config-tables.json').read_text())}
def table(n,rows,key='id'):
 p=D/'inputs'/(n+'.json');write(p,rows);meta=catalog[n]
 sources.append(dict(id='T:'+n,kind='config_rows',path=str(p.relative_to(D)),sha256=sha(p),row_key=key,record_count=len(rows),row_ids=[x[key] for x in rows],origin=dict(path=str((T/(n+'.json')).relative_to(R)),sha256=sha(T/(n+'.json')),raw_path=meta['source'],raw_sha256=meta['sha256'],layout=meta.get('layout'),reader_sequence_verified=meta.get('reader_sequence_verified'))))
 return rows
chapter=table('Chapter_MainChapter',[x for x in read('Chapter_MainChapter') if x['id']==1])[0]
missions=table('MissionWaterfallMission_WaterfallMission',[x for x in read('MissionWaterfallMission_WaterfallMission') if x['id']//1000==chapter['missionIdPrev']])
table('ChapterWave_Waves',[x for x in read('ChapterWave_Waves') if chapter['waveId']<x['id']<=chapter['waveId']+chapter['waveNum']])
gids={i for m in missions for i in m['positionGroupMonster']};rids={i for m in missions for i in m['randomMonster']}
groups=table('Mission_PositionGroupMonsterFlushConfig',[x for x in read('Mission_PositionGroupMonsterFlushConfig') if x['id'] in gids])
randoms=table('Mission_RandomMonsterFlushConfig',[x for x in read('Mission_RandomMonsterFlushConfig') if x['id'] in rids])
eids={i for m in missions for i in m['Monster']}|{i for r in randoms for i in r['entityId']}|{i for g in groups for a in json.loads(g['flushPool']) for i in a['Monster']}
table('Character_entity',[x for x in read('Character_entity') if x['ID'] in eids],'ID');table('Exp_exp',read('Exp_exp')[:15])
stars=table('ChapterReward_Star',[x for x in read('ChapterReward_Star') if x['id'] in chapter['starCondition']]);table('ChapterReward_StarReward',read('ChapterReward_StarReward'),'ID')
table('Shop_ShopGoods',[x for x in read('Shop_ShopGoods') if x['id']==601])
const=table('Consts_Const',[x for x in read('Consts_Const') if any(k in x['keyName'] for k in ['RandomSkillWeight','UseInitSkill','NewPlayerProtect','Punchboard','MainChapterRandomSkillCount'])])
table('Skill_SkillTypeWeight',read('Skill_SkillTypeWeight'))
pools=['SkillGroup_SurvivorGroup','SkillGroup_BranchSurvivorGroup','SkillGroup_UpgradeSurvivorGroup','SkillGroup_UpgradeSkillGroup']
ids=set()
for n in pools:
 rows=table(n,read(n),'EventID');ids.update(x['GetID'] for x in rows)
allskills={x['id']:x for x in read('Skill_Main')}
# Preserve all graph edges relevant to the four pools, including variant columns in input only.
relation_fields=['NextSkill','CoverSkill','UpgradeSkillId','UnlockUpgradeNeddSkill','UnlockUpgradeId','PreSkillIds','RejectSkills','NeedSkills','BanSkillS','SuperNeedSkill','RepeatSkills']
while True:
 more=set()
 for i in ids:
  for f in relation_fields:
   v=allskills[i].get(f,[]);more.update(v if isinstance(v,list) else [v])
 more={i for i in more if i and i in allskills}-ids
 if not more:break
 ids |= more
skills=table('Skill_Main',[allskills[i] for i in sorted(ids)])
langids={x['langId'] for x in stars}|{str(x.get(f)) for x in skills for f in ['LanguageNameId','LanguageInfoId']}
table('Language_languagetable',[x for x in read('Language_languagetable') if x['id'] in langids])
methods={
 'revive-ui':('evidence/report-native/RelivePopupViewModule-.asm','HotFix.RelivePopupViewModule$$OnOpen'),
 'punch-state':('evidence/inrun-closure/HotFix.BattleLogic.WaterfallStatePunchboard-OnEnter.asm',None),
 'punch-init':('evidence/inrun-closure/HotFix.BattleLogic.PlayerPunchboard-Init.asm',None),
 'punch-result':('evidence/inrun-closure/HotFix.BattleLogic.PlayerPunchboard-GetResultSkillList.asm',None),
 'wave-random':('restored/code/native-evidence/HotFix.BattleLogic.WaterfallBattleManager.asm','HotFix.BattleLogic.WaterfallBattleManager$$CalRandomMonster'),
 'wave-gate':('restored/code/native-evidence/HotFix.BattleLogic.WaterfallBattleManager.asm','HotFix.BattleLogic.WaterfallBattleManager$$EnemyDieSpecialLogic'),
 'wave-upgrade':('restored/code/native-evidence/HotFix.BattleLogic.WaterfallBattleManager.asm','HotFix.BattleLogic.WaterfallBattleManager$$OnProgressFinish'),
 'wave-exp':('restored/code/native-evidence/HotFix.BattleLogic.WaterfallBattleManager.asm','HotFix.BattleLogic.WaterfallBattleManager$$InitNewWaveData'),
 'quality':('restored/code/native-evidence/HotFix.BattleLogic.HeroSkillCreator.asm','HotFix.BattleLogic.HeroSkillCreator$$GetRandomSkills'),
 'normal-choice':('restored/code/native-evidence/HotFix.BattleLogic.HeroComponentRandomSkill.asm','HotFix.BattleLogic.HeroComponentRandomSkill$$GetNormalSkill'),
 'init-boost':('restored/code/native-evidence/HotFix.BattleLogic.SinglePlayerSkillCreator.asm','HotFix.BattleLogic.SinglePlayerSkillCreator$$GetNormalSkill'),
 'type-delta':('restored/code/native-evidence/HotFix.BattleLogic.HeroComponentRandomSkill.asm','HotFix.BattleLogic.HeroComponentRandomSkill$$GetDeltaWeightPercent'),
 'type-apply':('restored/code/native-evidence/HotFix.BattleLogic.HeroComponentRandomSkill.asm','HotFix.BattleLogic.HeroComponentRandomSkill$$AdjustWeightsForSkillGroup'),
 'weighted-draw':('restored/code/native-evidence/HotFix.BattleLogic.WeightRandom.asm','HotFix.BattleLogic.WeightRandom$$GetRandomCount'),
 'branch-choice':('restored/code/native-evidence/HotFix.BattleLogic.WeightRandom.asm','HotFix.BattleLogic.WeightRandom$$RandomOneSubSkillByParent'),
 'punch-count':('restored/code/native-evidence/HotFix.BattleLogic.HeroComponentRandomSkill.asm','HotFix.BattleLogic.HeroComponentRandomSkill$$GetPunchboardRandomCount'),
}
folder='evidence/continuation-2026-09-19/'
for key,file in [('revive-priority','HotFix.Common.AttributeData-GetRebornType'),('revive-input','HotFix.BattleLogic.BaseHeroDieState-OnPush'),('revive-ad','HotFix.BattleLogic.BaseHeroDieState-PlayerReliveByAd'),('revive-apply','HotFix.BattleLogic.BaseHeroDieState-PlayerRelive'),('revive-count','HotFix.BattleLogic.BattleWorldContext-AddReliveCount'),('revive-resume','HotFix.BattleLogic.WaterfallStateHeroDie-OnPlayerRelive'),('star-collect','HotFix.BattleLogic.BattleStarManager-CollectStar'),('star-revive','HotFix.BattleLogic.BattleStarManager-CheckAliveCount'),('star-hp','HotFix.BattleLogic.BattleStarManager-CheckHpPercent'),('result','SinglePlayerBattleManager-CreateBattleEndEvent'),('end-state','HotFix.BattleLogic.BaseEndState-OnUpdate'),('save-init','HotFix.BattleLogic.BattleData-InitFromSaveData')]:methods[key]=(folder+file+'.asm',None)
for key,(path,method) in methods.items():
 src=R/path;s=src.read_text()
 if method:
  blocks=re.split(r'(?=^; [^\n]+\$\$)',s,flags=re.M);matches=[b for b in blocks if b.splitlines() and b.splitlines()[0]=='; '+method];assert len(matches)==1,(key,len(matches));s=matches[0]
 else:method=s.splitlines()[0][2:]
 p=D/'evidence'/(key+'.asm');p.write_text(s)
 sources.append(dict(id='N:'+key,kind='native_excerpt',path=str(p.relative_to(D)),sha256=sha(p),method=method,rva=re.search(r'RVA (0x[\dA-Fa-f]+)',s)[1],origin={'path':path,'sha256':sha(src)},scope='APK ARM64 fallback; hotfix/indirect branches not fully resolved; original export may be capped at 16000 bytes'))
write(D/'sources.json',sources)
base=json.loads((R/'indexes/apk-summary.json').read_text());write(D/'baseline.json',dict(schema_version='1.0.0',dataset_id='xxyzd-in-run-1.0.16-base',package='com.fhzj.game',client='1.0.16',version_code=40,apk_sha256=base['apk_sha256'],apk_bytes=base['apk_bytes'],scope='主线第一章，非_B基础配置；APK静态分析，不代表线上热更/A-B路由或服务端已验证',updated='2026-09-20',source_layers={'L0':'original/ 与 unpacked/；APK只保留指纹，不随轻量包交付','L1':'restored/configs/tables、schemas 与 restored/code/native-evidence','L2':'research-data/in-run（独立快照、规则、数据、证据）','L3':'docs/core.html 与 docs/research-data.html'}))
print('sources',len(sources),'skill nodes',len(skills),'rows',sum(x.get('record_count',0) for x in sources))
