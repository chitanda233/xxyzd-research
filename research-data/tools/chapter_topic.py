#!/usr/bin/env python3
"""Chapter planning: portable snapshots, exact joins, report and validation. Python stdlib only."""
import collections, gzip, hashlib, html, json, re, shutil, sys, zipfile
from pathlib import Path
ROOT = Path(__file__).resolve().parents[2]
D = ROOT / 'research-data/topics/chapter-planning'
OLD = ROOT / 'research-data/topics/choices-box-evolution'
TABLES = ['Chapter_MainChapter', 'ChapterWave_Waves', 'MissionWaterfallMission_WaterfallMission',
          'Mission_RandomMonsterFlushConfig', 'Mission_PositionGroupMonsterFlushConfig',
          'Chapter_ProtectTemplate', 'Chapter_MapStyle', 'Exp_exp']
def read(p): return json.loads(gzip.decompress(p.read_bytes()) if p.suffix=='.gz' else p.read_text())
def write(p, v):
    p.parent.mkdir(parents=True, exist_ok=True)
    p.write_text(json.dumps(v, ensure_ascii=False, separators=(',', ':')) + '\n')
def digest(p): return hashlib.sha256(p.read_bytes()).hexdigest()
def val(v): return v['decimal'] if isinstance(v, dict) and 'decimal' in v else v
def table(n):
    p=D / 'inputs' / (n + '.json')
    return read(p if p.exists() else p.with_suffix('.json.gz'))
def snapshot():
    D.mkdir(parents=True, exist_ok=True)
    sources = []
    for n in TABLES:
        src = ROOT / 'restored/configs/tables' / (n + '.json')
        dst = D / 'inputs' / src.name
        write(dst, read(src))
        if dst.stat().st_size > 300000:
            compressed=dst.with_suffix('.json.gz')
            compressed.write_bytes(gzip.compress(dst.read_bytes(), compresslevel=9, mtime=0))
            dst.unlink(); dst=compressed
        sources.append(dict(path=str(dst.relative_to(D)), source=str(src.relative_to(ROOT)), source_sha256=digest(src), selection='full table'))
    for name in ['pool-weights.json', 'facts.json', 'baseline.json']:
        src = OLD / name if name != 'baseline.json' else ROOT / 'research-data/in-run/baseline.json'
        dst = D / 'inputs' / ('choice-' + name if name != 'baseline.json' else name)
        write(dst, read(src))
        sources.append(dict(path=str(dst.relative_to(D)), source=str(src.relative_to(ROOT)), source_sha256=digest(src)))
    native = ROOT / 'evidence/inrun-closure/annotated/HotFix.BattleLogic.WaterfallBattleManager.asm'
    text = native.read_text()
    (D / 'evidence').mkdir(exist_ok=True)
    for name in ['CalRandomMonster', 'CreateRandomMonster', 'RandomPos']:
        marker = '; HotFix.BattleLogic.WaterfallBattleManager$$' + name + '\n'
        start = text.index(marker); end = text.find('\n; HotFix.', start + len(marker))
        dst = D / 'evidence' / ('WaterfallBattleManager--' + name + '.asm')
        dst.write_text(text[start:end if end >= 0 else len(text)])
        sources.append(dict(path=str(dst.relative_to(D)), source=str(native.relative_to(ROOT)), method=marker[2:].strip(), source_sha256=digest(native)))
    for name in ['DankeSkillCreator--GetSkillWeight.asm', 'DankeSkillCreator--GetNormalSkill.asm', 'BattleWorldContext--IsDankeSkill.asm', 'HeroComponentRandomSkill--Init.asm', 'LocalModels.Bean.SkillGroup_SurvivorGroup--GetWeightByGroup.asm', 'LocalModels.Bean.Chapter_MainChapter--GetSkillGroupWeight.asm']:
        src = OLD / 'evidence' / name; dst = D / 'evidence' / name
        shutil.copyfile(src, dst)
        sources.append(dict(path=str(dst.relative_to(D)), source=str(src.relative_to(ROOT)), source_sha256=digest(src)))
    write(D / 'sources.json', sources)

def derive():
    chapters = table('Chapter_MainChapter'); waves = {r['id']: r for r in table('ChapterWave_Waves')}
    missions = collections.defaultdict(list)
    for r in table('MissionWaterfallMission_WaterfallMission'): missions[r['id'] // 1000].append(r)
    summaries, wave_rows, differences = [], [], []
    for c in chapters:
        variants = {}
        for branch, suffix in [('base', ''), ('B', '_B')]:
            ms = sorted(missions[c['missionIdPrev' + suffix]], key=lambda r:r['id'])
            ws = [waves[c['waveId' + suffix] + i] for i in range(1, c['waveNum'] + 1)]
            cr = []
            for i, w in enumerate(ws, 1):
                mr = [r for r in ms if r['wave'] == i]
                row = dict(chapter=c['id'], branch=branch, wave=i, wave_row_id=w['id'], mission_ids=[r['id'] for r in mr],
                    start_seconds=min((val(r['time']) for r in mr), default=None), exp=w['WaveAllExp'],
                    kill_gate=w['StopByEliteOrBossKilled'], hp=val(w['hpUpgrade']), attack=val(w['attackUp']), gold=w['MonsterTotalGold'],
                    start_ui=w['WaveStartSpecialUIType'], end_ui=w['WaveEndSpecialUIType'],
                    chest_events=[dict(mission_id=r['id'], seconds=val(r['time'])) for r in mr if r['missinType']==9],
                    random_rows=sum(bool(r['randomMonster']) for r in mr),
                    multi_candidate_rows=sum(len(r['randomMonster']) > 1 for r in mr),
                    direct_monster_ids=sorted({v for r in mr for v in r['Monster']}))
                cr.append(row); wave_rows.append(row)
            variants[branch] = dict(mission_prefix=c['missionIdPrev'+suffix], wave_prefix=c['waveId'+suffix],
                mission_count=len(ms), final_wave_start=cr[-1]['start_seconds'],
                exp=sum(r['exp'] for r in cr), exp_curve=[r['exp'] for r in cr],
                kill_waves=[r['wave'] for r in cr if r['kill_gate']],
                chest_waves=[r['wave'] for r in cr for _ in r['chest_events']],
                final_hp=cr[-1]['hp'], final_attack=cr[-1]['attack'], gold_budget=sum(r['gold'] for r in cr),
                random_rows=sum(r['random_rows'] for r in cr), multi_candidate_rows=sum(r['multi_candidate_rows'] for r in cr),
                random_npc_values=dict(collections.Counter(str(r['RandomNpc']) for r in ms)))
        a = sorted(missions[c['missionIdPrev']], key=lambda r:r['id'])
        b = sorted(missions[c['missionIdPrev_B']], key=lambda r:r['id'])
        assert len(a)==len(b), c['id']
        for kind, aa, bb in [('mission',a,b), ('wave',[waves[c['waveId']+i] for i in range(1,c['waveNum']+1)],[waves[c['waveId_B']+i] for i in range(1,c['waveNum']+1)])]:
            for u,v in zip(aa,bb):
                for k in u:
                    if k!='id' and u[k]!=v[k]: differences.append(dict(chapter=c['id'], table=kind, base_id=u['id'], B_id=v['id'], field=k, base=u[k], B=v[k]))
        summaries.append(dict(chapter=c['id'], hidden=bool(c['isHide']), waves=c['waveNum'], skill_type=c['SkillType'],
            weight_group=c['SkillGroupWeight'], weight_group_B=c['SkillGroupWeight_B'], protect=c['NewPlayerProtect'], hp_protect_template=c['ProtectTemplate'],
            suggested_skills=c['SuggestedSkills'], suggested_functions=c['SuggestedFunction'], new_monsters=c['NewMonsters'], map=c['mapStyle'],
            hp_pickup=val(c['HPPickUpAddPercent']), resurrection_field=c['ResurrectionTimes'], reward_ids=c['FinishReward'], variants=variants))
    return summaries, wave_rows, differences

def rebuild():
    for name, content in zip(['chapters.json','waves.json','branch-differences.json'],derive()): write(D/name,content)
    write(D/'facts.json',[
        {'id':'P01','status':'verified_static','claim':'70个非隐藏章节；63章15波、7章10波，10波章为5+10k（k=0..6）。','evidence':['inputs/Chapter_MainChapter.json'],'derived':['chapters.json']},
        {'id':'P02','status':'verified_static','claim':'基础/B沿用相同经验序列，15波14800、10波7300。','evidence':['inputs/ChapterWave_Waves.json'],'derived':['waves.json']},
        {'id':'P03','status':'verified_static','claim':'每分支208次宝箱脚本事件；第10/60章仅2次，其余非隐藏章3次。','evidence':['inputs/MissionWaterfallMission_WaterfallMission.json'],'derived':['chapters.json','waves.json']},
        {'id':'P04','status':'verified_static','claim':'技能组1..6分别对应第1/2/3/4/6/8章；第11章起默认组，保护码3仅第2—10章。','evidence':['inputs/Chapter_MainChapter.json','evidence/DankeSkillCreator--GetSkillWeight.asm','evidence/LocalModels.Bean.SkillGroup_SurvivorGroup--GetWeightByGroup.asm'],'derived':['chapters.json']},
        {'id':'P05','status':'verified_static','claim':'第6/8章常规入口权重与默认相同；初始池分别突出灼热射线和磁暴枪。','evidence':['inputs/choice-pool-weights.json']},
        {'id':'P06','status':'verified_static','claim':'随机刷新weight进入成员坐标乘加，不能解释成抽怪权重。','evidence':['evidence/WaterfallBattleManager--CreateRandomMonster.asm'],'addresses':['0x65D07FC','0x65D0858','0x65D08B8']},
        {'id':'P07','status':'verified_static','claim':'基础/B的任务仅4个字段单元不同；第55章B额外锁定W4/W7。','evidence':['inputs/ChapterWave_Waves.json','inputs/MissionWaterfallMission_WaterfallMission.json'],'derived':['branch-differences.json']},
        {'id':'P08','status':'verified_static','claim':'章节层血量攻击倍率均1；前4章关联保护模板的40个倍率也全1。','evidence':['inputs/Chapter_MainChapter.json','inputs/Chapter_ProtectTemplate.json']},
        {'id':'P09','status':'interpretation','claim':'前10章强调构筑方向引导，后段通过内容复用和数值推进维持长线章节。','basis':['P01','P02','P04','P05','P08'],'evidence':['inputs/Chapter_MainChapter.json','inputs/ChapterWave_Waves.json']}
    ])
    write(D/'questions.json',[
        {'id':'P-Q1','question':'skill3SelectCreditsRandom / skill2SelectCreditsRandom 是否参与当前主线？','finding':'保留完整章节数组；已验证主线路由使用 DankeSkillCreator 和 SkillGroupWeight，不能把旧命名数组归一化为当前三选一概率。','next':'仅在需要解释这两组数组用途时追它们的消费者。'},
        {'id':'P-Q2','question':'复活资格、回血及章节解锁的最终规则？','finding':'ResurrectionTimes、HPPickUpAddPercent 和 unLockNeedLayer 仅报告配置值；尚不能单靠字段推出实际次数、单个血包效果或全章已开放。','next':'需要精确规则时核对对应资格、效果和服务端入口。'},
        {'id':'P-Q3','question':'失败降血量与随机算法的线上生效状态？','finding':'4个保护模板共40个倍率全为1；原生抽怪索引与位置流程可见，但随机函数底层、热更新覆盖和线上分流未验证。','next':'新的运行态材料或概率精度需求出现时定向复核。'}])
    facts=read(D/'facts.json')
    for fact in facts:
        fact['evidence']=[s+'.gz' if not (D/s).exists() and (D/(s+'.gz')).exists() else s for s in fact['evidence']]
    write(D/'facts.json',facts)
    write(D/'manifest.json',{str(p.relative_to(D)):digest(p) for p in sorted(D.rglob('*')) if p.is_file() and p.name!='manifest.json'})

def validate():
    for name, content in zip(['chapters.json','waves.json','branch-differences.json'],derive()): assert read(D/name)==content,name
    manifest=read(D/'manifest.json')
    assert set(manifest)=={str(p.relative_to(D)) for p in D.rglob('*') if p.is_file() and p.name!='manifest.json'}
    for name,sha in manifest.items(): assert digest(D/name)==sha,name
    for fact in read(D/'facts.json'):
        for source in fact['evidence']: assert (D/source).is_file(),source
    visible=[c for c in read(D/'chapters.json') if not c['hidden']]
    assert [c['chapter'] for c in visible]==list(range(1,71))
    assert [c['chapter'] for c in visible if c['waves']==10]==list(range(5,66,10))
    assert all(c['variants']['base']['exp']==(14800 if c['waves']==15 else 7300) for c in visible)
    assert all(c['variants']['base']['exp_curve']==c['variants']['B']['exp_curve'] for c in visible)
    assert sum(len(c['variants']['base']['chest_waves']) for c in visible)==208
    return {'status':'passed','visible_chapters':70,'hidden_chapters':1,'chapter_variants':142,'wave_rows':len(read(D/'waves.json')),'scope':'input joins, exact recomputation and hashes; static APK only'}

def render():
    cs=[c for c in read(D/'chapters.json') if not c['hidden']]; ws=read(D/'waves.json'); ds=read(D/'branch-differences.json')
    e=lambda v:html.escape(str(v))
    def grid(headers,rows):return '<div class="scroll"><table><thead><tr>'+''.join('<th>'+e(x)+'</th>' for x in headers)+'</tr></thead><tbody>'+''.join('<tr>'+''.join('<td>'+e(x)+'</td>' for x in row)+'</tr>' for row in rows)+'</tbody></table></div>'
    def nums(v):return '、'.join(map(str,v)) or '无'
    names={r['skill_id']:r['name'] for r in read(D/'inputs/choice-pool-weights.json')}
    sections=[('overview','规划结论'),('skeleton','波次与成长'),('random','章节随机规则'),('difficulty','压力与内容'),('branch','基础/B分支'),('all','70章对照'),('evidence','证据与复用')]
    parts=['''<!doctype html><html lang="zh-CN"><head><meta charset="utf-8"><meta name="viewport" content="width=device-width,initial-scale=1"><title>章节规划与规则差异 · 策划专题</title><link rel="stylesheet" href="assets/style.css"><style>td{vertical-align:top}details{padding:12px 0;border-bottom:1px solid #d4e2de}summary{cursor:pointer;font-weight:650}pre{white-space:pre-wrap;overflow-wrap:anywhere}.scroll th{white-space:nowrap}</style></head><body><header class="page-head"><div class="hero"><div class="eyebrow">章节设计研究</div><h1>章节规划与规则差异</h1><p>把70章拆成可比较的关卡骨架、成长预算、随机倾向、敌人压力和配置分支。结论来自客户端1.0.16静态配置与已核实的原生链路。</p><div class="chips"><span>70个非隐藏章节</span><span>基础 / B双分支</span><span>逐章逐波可复算</span></div></div></header><main class="layout"><nav class="toc"><strong>专题目录</strong><ul>''']
    parts += ['<li><a href="#'+k+'">'+v+'</a></li>' for k,v in sections]
    parts.append('''</ul><a href="core.html">整体链路报告</a><p><a href="choices-box-evolution.html">三选一与宝箱专题</a></p></nav><article class="article"><h2 id="overview">1. 章节怎样组织</h2><p class="summary">策划解读：这套章节把“稳定的局内成长预算”与“持续变化的敌人压力”分开控制。前10章承担技能方向引导，后续章节沿用共同成长规则，通过敌人组合、波次属性与场景复用持续扩展；周期性插入10波章节改变构筑长度和交战节奏。</p><p>章节表有1—70章与隐藏条目9999。以下统计只计70个非隐藏条目，隐藏条目保存在数据里；配置存在不代表线上已开放。规划意图属于从数据归纳的策划解读，不是开发团队声明。</p>''')
    parts.append(grid(['区间','实际配置','策划含义'],[
        ['第1章','15波；击杀门槛仅W10/W15；技能权重组1；前期保护数组为空','以较少强制验收建立首局构筑'],
        ['第2—4章','使用专用权重组2/3/4；保护码3；15波W5/W10/W15门槛','逐步引导选择不同武器和模块'],
        ['第5—10章','第5章10波；第6/8章专用权重组5/6，其余默认；保护码3仍在','关卡结构与推荐路线开始变化；专用组编号本身不保证权重有差异'],
        ['第11—70章','默认技能权重；保护码3关闭；推荐技能列表清空；保留功能推荐代码2/6/4','进入稳定成长规则下的内容、数值与组合迭代'],
        ['周期变化','第5、15、25、35、45、55、65章10波，其余63章15波','构筑长度有固定周期变化；10波并不保证实机用时更短']]))
    parts.append('''<h2 id="skeleton">2. 波次、经验和宝箱怎样搭配</h2><p>基础/B的普通章节都使用相同经验序列：15波总预算14800，10波直接使用同一序列前10项，总预算7300。敌人数量和血量变化，不增加这份配置预算。最后一波预算包含终局经验，不能把15波/10波机械写成15次/10次可用三选一。</p>''')
    parts.append(grid(['波','1','2','3','4','5','6','7','8','9','10','11','12','13','14','15'],[['经验',200,550,600,600,700,800,800,950,1000,1100,1200,1200,1400,1700,2000]]))
    parts.append('''<p>15波章节通常在W5、W10、W15要求特殊目标死亡后推进；第1章例外，W5不锁。10波章节中，第5/55章基础分支仅W10锁，其余W4/W7/W10锁；B分支把第55章也改为W4/W7/W10。</p><p>宝箱是独立脚本事件：61章在W6/W11/W15，7个10波章在W4/W7/W10；第10章仅W11/W15，第60章仅W6/W15。每个分支合计208次配置事件。事件次数不能等同新增技能数，领取仍按1/3/5档与当前构筑处理。</p>''')
    parts.append(grid(['章节','波数','终波脚本起点（秒）','基础击杀门槛','宝箱波次','经验预算'],[[c['chapter'],c['waves'],c['variants']['base']['final_wave_start'],nums(c['variants']['base']['kill_waves']),nums(c['variants']['base']['chest_waves']),c['variants']['base']['exp']] for c in cs if c['chapter'] in [1,3,5,10,15,35,55,60,65]]))
    parts.append('''<p class="callout">第35章虽只有10波，终波仍在脚本345秒开始，与许多15波章相同。脚本时间不含暂停选技和击杀等待，终波起点也不是通关用时。用“波数×固定秒数”推算时长会失真。</p><h2 id="random">3. 不同章节的随机规则</h2><h3>3.1 技能随机：共同算法，章节换权重列</h3><p>70章SkillType均为2，使用DankeSkillCreator；章节没有切换为另一套品质抽签算法。SkillGroupWeight负责选择具体技能的权重列，基础/B该字段逐章相同。它改变同池技能的相对机会，实际展示仍受类别抽签、槽位、前置、已有技能、去重和全被动纠偏约束。</p>''')
    parts.append(grid(['章节','权重列','保护码3','界面推荐（不保证抽中）'],[[c['chapter'],'Weight_'+str(c['weight_group']) if c['weight_group'] else 'Weight（默认）','有' if 3 in c['protect'] else '无','、'.join(names.get(s,str(s)) for s in c['suggested_skills']) or '无'] for c in cs[:11]]))
    pools=read(D/'inputs/choice-pool-weights.json')
    parts.append('<h3>初始池：第6/8章的倾向在这里</h3><p>初始池默认10个武器各权重200。第6章把灼热射线设为300，其余100；第8章把磁暴枪设为300，其余100。在没有其他过滤和修正、仅按这10个入口取一项的条件下，目标占300/1200=25%，默认占200/2000=10%。这是池内条件比例，不是三张最终展示率；本局是否使用初始池仍取决于Init计数。新开局计数初始化尚未闭合。</p>')
    parts.append(grid(['初始池武器','默认','第1章','第2章','第3章','第4章','第6章','第8章'],[[r['name'],r['weight']]+[r['chapter_group_weights'][str(i)] for i in range(1,7)] for r in pools if r['pool']=='InitSurvivorGroup']))
    parts.append('<h3>常规入口权重对照</h3><p>这是相对权重，不是百分比。组5/6在下列常规入口与默认列一致；第6/8章有专用组编号，不意味着普通入口概率必然特殊。初始池是另一个池，数值完整保存在输入快照。</p>')
    parts.append(grid(['技能','默认','第1章','第2章','第3章','第4章','第6章','第8章'],[[r['name'],r['weight']]+[r['chapter_group_weights'][str(i)] for i in range(1,7)] for r in pools if r['pool']=='SurvivorGroup']))
    parts.append('''<p>例如同一武器池里，第一章机炮与酸液枪的入口权重是300:100，默认列是100:100；这是两者的相对比值，不能直接说机炮有75%出现率。第4章提高光剑、冰冻锯盘及对应生命/攻击模块，显示其构筑引导方向。</p><h3>3.2 前期保护：按章节和本局条件，而非账号年龄</h3><p>第2—10章NewPlayerProtect含3；已核实分支还要求主线世界且未持有机炮入口，尝试给机炮、冰刃弹、灼热射线临时增权10%，抽取后撤销。第1章及第11章后不配置这项。引导覆盖与初始池计数另行判断，不能把“前10章”直接称为“新账号必中特定武器”。</p><p>第1—4章另挂血量保护模板1—4，但4个模板的10档HpRate全部为1。就当前配置值而言，没有失败次数对应的降血量幅度；不能仅凭ProtectTemplate这个名字推断越失败越简单。失败计数的实际入口留在待证问题中。</p><h3>3.3 刷怪随机：抽组合、放位置，不是随机生成整章</h3><p>章节先引用任务前缀，每条任务固定波次、时点和刷新方式。固定怪物列表、位置组与随机组可同时参与编排。随机路径先在任务的randomMonster候选数组中取索引、缓存选择，再读取该组entityId列表生成其成员，随后处理位置。单候选数组不会带来怪物组身份的变化；多候选才有组合选择空间。底层随机数分布未独立验证，本专题不据此承诺精确均匀概率。</p><p class="callout">Mission_RandomMonsterFlushConfig.weight不是这里的“抽中权重”：CreateRandomMonster在0x65D0858把该值乘成员索引并加到坐标，height也进入另一轴的坐标计算。这两个字段用于队形成员位置处理，不能直接归一化成怪物出现率。</p><p>RandomNpc是另一条NPC逻辑。已核实的宝箱补偿要求它等于9，当前章节任务没有9；不能把普通刷怪随机、NPC补偿和技能随机合并为一张概率表。skill3SelectCreditsRandom等字段虽随前几章变化，当前主线算法的证据不支持直接用它们计算三选一概率。</p><h2 id="difficulty">4. 压力与内容怎样递进</h2><p>章节层hpUpgrade/attackUp及其B值全为1。显著变化在波次层：每章每波单独配置血量、攻击与金币预算，任务层也有自己的属性字段。下表只比较终波的配置倍率，不是怪物最终生命、实测难度或玩家所需战力。</p>''')
    parts.append(grid(['章节','终波血量倍率：基础 / B','终波攻击倍率：基础 / B','任务行数','随机组任务行数'],[[c['chapter'],str(c['variants']['base']['final_hp'])+' / '+str(c['variants']['B']['final_hp']),str(c['variants']['base']['final_attack'])+' / '+str(c['variants']['B']['final_attack']),c['variants']['base']['mission_count'],c['variants']['base']['random_rows']] for c in cs if c['chapter'] in [1,2,3,4,5,6,10,15,20,30,40,50,60,70]]))
    parts.append('''<p>任务行数代表调度密度，事件也占行，不能当怪物数。跨章比较血量还需要怪物本体、任务属性、波次属性与玩家输出共同建模；例如第25章终波血量倍率低于第24章，也不能直接判定第25章更容易。</p><p>场景采用复用：第51—60章的mapStyle对应第41—50章；第61—70章复用前10章的mapStyle，其中第62/63/64章分别对应第4/3/2章。70章总计50个mapStyle ID，这只是配置样式数，不等于独立美术地图数量。后段的NewMonsters大多为空，第65章仍标记320020；该数组是“新怪展示标记”，不能当实际刷怪表或认定首次登场。</p><p>第11章起SuggestedSkills为空，SuggestedFunction固定[2,6,4]。结束奖励引用列表在第2、5、8、12、16、17、22、32、42章发生扩展；这是奖励入口配置变化，未把这些ID擅自解释为实际到账数量。复活字段第1章为0、其余为1，实际资格仍需结合复活流程。</p><h2 id="branch">5. 基础/B：节奏基本共用，数值与少量任务有差异</h2>''')
    visible_ds=[d for d in ds if d['chapter']<=70]
    count=collections.Counter((d['table'],d['field']) for d in visible_ds)
    parts.append(grid(['层','变化字段','不同配置单元数'],[[k[0],k[1],n] for k,n in sorted(count.items())]))
    parts.append('<p>基础主线共有756条任务使用randomMonster，其中37条有多个候选组，719条只有单个候选组；只计算是否具备组身份变化的配置空间，不统计最终生成怪数。明细按章、波保存，避免把所有标有random的行都误认为随机换怪。</p>')
    parts.append('''<p>对齐方法：波次以章内波号对齐，任务以各前缀内递增行号对齐，排除ID前缀本身。70章的波数、经验序列与宝箱波次都相同。基础/B不代表新手/老手，也不能简单称B更容易：第1章终波血量从11变9，第6章反而从65.452变80.31，攻击也提高。</p>''')
    parts.append(grid(['章节','层 / 基础行ID','字段','基础','B'],[[d['chapter'],d['table']+' / '+str(d['base_id']),d['field'],val(d['base']),val(d['B'])] for d in visible_ds if d['table']=='mission' or d['field']=='StopByEliteOrBossKilled']))
    parts.append('''<h2 id="all">6. 全部70章对照与逐波明细</h2><p>权重组0表示默认列；终波秒为脚本起点。下方每章可展开基础/B逐波数据。原始行ID可直接回查输入快照。</p>''')
    parts.append(grid(['章','波数','终波秒','经验','基础击杀波','宝箱波','权重组','保护码3','地图ID'],[[c['chapter'],c['waves'],c['variants']['base']['final_wave_start'],c['variants']['base']['exp'],nums(c['variants']['base']['kill_waves']),nums(c['variants']['base']['chest_waves']),c['weight_group'],'有' if 3 in c['protect'] else '无',c['map']] for c in cs]))
    for c in cs:
        parts.append('<details id="chapter-'+str(c['chapter'])+'"><summary>第'+str(c['chapter'])+'章 · '+str(c['waves'])+'波 · 逐波与分支明细</summary>')
        parts.append(grid(['分支','波','配置行ID','起点秒','经验','击杀锁','血量倍率','攻击倍率','金币预算','宝箱事件数'],[[r['branch'],r['wave'],r['wave_row_id'],r['start_seconds'],r['exp'],r['kill_gate'],r['hp'],r['attack'],r['gold'],len(r['chest_events'])] for r in ws if r['chapter']==c['chapter']]))
        parts.append('</details>')
    base='https://github.com/chitanda233/xxyzd-research/blob/main/research-data/topics/chapter-planning/'
    parts.append('''<h2 id="evidence">7. 证据、边界与同事复用</h2><p>配置事实来自本专题inputs中的章节、波次、任务、随机刷新组与保护模板；技能算法复用已核实的三选一专题C01—C08，原生方法摘录保存在evidence。正文涉及章节规划目的的表述为策划解读。完整来源路径、原始文件哈希和方法名见sources.json。</p>''')
    for name,label in [('facts.json','规则与策划解读'),('chapters.json','71条章节汇总'),('waves.json','双分支逐波数据'),('branch-differences.json','完整基础/B字段差异'),('sources.json','输入和原生方法来源'),('questions.json','待证问题与继续条件'),('manifest.json','数据哈希清单')]:parts.append('<p><a href="'+base+name+'">'+label+'</a></p>')
    parts.append('<p><a href="downloads/xxyzd-chapter-planning.zip">下载本专题＋结构化数据与证据</a></p><pre>python3 research-data/tools/chapter_topic.py validate\npython3 research-data/tools/chapter_topic.py chapter:55\npython3 research-data/tools/chapter_topic.py rebuild\npython3 research-data/tools/chapter_topic.py render</pre><p>离线复算只需包内输入和Python标准库，不需要APK或反编译环境。时间为配置值，倍率为解码十进制；输入同时保留运行定点数。未验证服务端开放、线上热更新、实际分流比例及玩家胜率。</p></article></main><a class="back" href="core.html">← 整体链路报告</a><script src="assets/term-tips.js"></script></body></html>')
    (ROOT/'docs/chapter-planning.html').write_text(''.join(parts))

def export():
    validate()
    out=ROOT/'docs/downloads/xxyzd-chapter-planning.zip'; out.parent.mkdir(exist_ok=True)
    files=list(D.rglob('*'))+[ROOT/'research-data/tools/chapter_topic.py',ROOT/'docs/chapter-planning.html']+list((ROOT/'docs/assets').glob('term-tips.*'))+[ROOT/'docs/assets/style.css']
    with zipfile.ZipFile(out,'w',zipfile.ZIP_DEFLATED,compresslevel=9) as z:
        for p in files:
            if not p.is_file():continue
            content=p.read_bytes()
            if p.suffix=='.html':
                s=content.decode().replace('https://github.com/chitanda233/xxyzd-research/blob/main/research-data/topics/chapter-planning/','../research-data/topics/chapter-planning/')
                for page in ['core.html','choices-box-evolution.html']:s=s.replace('href="'+page+'"','href="https://chitanda233.github.io/xxyzd-research/'+page+'"')
                s=s.replace('href="downloads/xxyzd-chapter-planning.zip"','href="../START-HERE.txt"');content=s.encode()
            z.writestr(str(p.relative_to(ROOT)),content)
        z.writestr('START-HERE.txt','打开 docs/chapter-planning.html 阅读专题。\n数据和证据位于 research-data/topics/chapter-planning/。\n校验：python3 research-data/tools/chapter_topic.py validate\n')
    return dict(package=str(out),bytes=out.stat().st_size,sha256=digest(out))

if __name__=='__main__':
    cmd=sys.argv[1] if len(sys.argv)>1 else 'validate'
    if cmd=='snapshot':snapshot();rebuild();render();print(validate())
    elif cmd=='rebuild':rebuild();print(validate())
    elif cmd=='render':validate();render();print('Rendered chapter report')
    elif cmd=='export':print(export())
    elif cmd.startswith('chapter:'):
        n=int(cmd.split(':')[1]);print(json.dumps({'chapter':next(c for c in read(D/'chapters.json') if c['chapter']==n),'waves':[r for r in read(D/'waves.json') if r['chapter']==n]},ensure_ascii=False,indent=2))
    else:print(validate())
