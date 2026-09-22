"""Monster topic presentation and portable QA; Python standard library only."""
import collections, html, json, re, shutil, sys, zipfile
from pathlib import Path
import monster_topic as m
ROOT,D=m.ROOT,m.D
TYPES={2:'普通怪',201:'精英',3:'首领'}
AI={
 'AIMoveInTwoPointsAndAttack':('两点往返＋周期射击','nextPointX/Z控制目标点参数；fireInterval与fireDelay分别控制循环间隔和延迟。移动和攻击任务组合。'),
 'AIMoveInTwoPointsAndAttackNew':('两点往返变体','增加条件回调；保留同名参数不代表与原类行为完全一致。'),
 'AIMoveToBottomAndAttack':('向下移位＋周期射击','nextPointOffsetZ常为−10；isLoop与needAttack决定配置意图，不能只按角色移动速度推算完整轨迹。'),
 'AIMoveToBottomAndAttackNew':('向下移位变体','主线用于精英眼球怪310023；实际类型仍是普通怪。'),
 'AICommonBoss':('首领随机动作组合','先按动作权重选择，再按武器权重选择；可进入召唤分支，不是依次轮播武器。'),
 'AIFixedBezierPath':('固定路径通行','初始化攻击循环实际添加固定路径移动任务；仅配置WeaponID不构成会开火的证据。'),
 'AIMoveDynamicRotateCenter':('绕中心变半径运动','参数定义中心、初始半径、角速度、收缩半径与等待时间；具体曲线由Behaviour任务执行。'),
 'AIMoveOnPathAttackLoopBorn':('沿路径移动并攻击','路径和射击参数共存；部分怪有自转速度，不可把模型自转等同于子弹转向。'),
 'AIMoveOnPathLoopBorn':('路径入场＋后续直行','原生入口包含路径任务、等待与向下直行任务；SecondMoveSpeedScale影响后段。'),
 'AIMoveReboundWall':('边界反弹型','初始朝向由OriginAngle配置；入口添加前进任务，反弹细节需要相应运动任务，不由类名推算角度。'),
 'AIMoveFollowTarget':('追随目标型','入口选择最近目标，FollowSpeedScale为追随速度参数。'),
 'AIMoveUpDown':('上下移动与冲刺','入口组合随机反向移动、等待、由上向下运动；尖刺护盾的RushSpeed为52。'),
 '200007':('距离判定后攻击','原生AI200007读取攻击距离并进入AddAttack；配置含等待与预警时间。'),
 '320013':('红线预警攻击','原生AI320013建立多红线预警与等待任务，激光小机使用该类。'),
 '340001':('首领随机反向移动','原生AI340001添加MonsterMoveRandomReverse；不能按名称中的ID推算技能周期。'),
}
FIELDS={'HP':'基础生命','Attack':'基础攻击','BodyAttack':'接触攻击','MoveSpeed':'移动速度','AttackDistance':'攻击距离参数','BulletLifeRange':'子弹距离参数','Shape':'碰撞形状','ModelScale':'模型缩放','WaveAIId':'主线行为类','WaveAIParameters':'主线行为参数','AIId':'常规行为类','AIParameters':'常规行为参数','WeaponID':'直接武器','MonsterAbility':'能力与抗性','MonsterTraitID':'特殊词缀','bornType':'出生类型','bornParameters':'出生参数','WaveleaveType':'主线离场类型','WaveleaveParameters':'主线离场参数','deathClassId':'死亡处理类型','deathParams':'死亡参数','MinBulletHurtTime':'同目标重复伤害间隔','LifeTime':'子弹寿命','Scale':'表内缩放值，未合成为碰撞缩放','hurtAttributes':'伤害表达式','ShapeOffset':'碰撞偏移','Trajectory':'弹道类型','TrajectoryParams':'弹道参数','FireCD':'通用射击冷却字段，不替代AI间隔','FireHoldTime':'弹道蓄力参数','fireInterval':'AI循环射击间隔','fireDelay':'AI射击延迟','PathId':'路径资源编号','WeaponSalvoMod':'齐射修饰器','FollowMod':'追踪修饰器','WeaponFireOnDeadMod':'死亡时触发后续武器','ThroughMod':'穿透修饰器','MinZs':'各武器动作纵向下界参数','MaxZs':'各武器动作纵向上界参数','base':'基础配置分支，不代表老手','B':'B配置分支，不代表新手','nextPointX':'两点运动横向参数','nextPointZ':'两点运动纵向参数','needAttack':'是否启用攻击任务','DeathOnFinish':'路径结束死亡参数','IsLoop':'路径循环参数','IsLoopSelf':'自身循环参数','Behaviour':'运动任务及其参数字符串'}
FIELDS.update({'CallCDTime':'召唤动作冷却参数','CallMonsterWeight':'召唤相对权重，不是百分比','CallMonsters':'召唤对象及时间参数','FollowSpeedScale':'追随速度倍率','IsIgnoreLaserWarning':'是否忽略激光预警','OriginAngle':'初始运动角度','RushSpeed':'冲刺速度','SecondMoveIsRotateToTarget':'第二段移动是否朝向目标','SecondMoveSpeedScale':'第二段移动速度倍率','SelfRotateSpeed':'自身旋转速度','ShadowFadeTime':'影子淡出时间','ShowShadow':'影子显示开关','WaitTimeMax':'最长等待时间','WaitTimeMin':'最短等待时间','WarnTime':'预警时间','WarningDir':'预警方向类型','WeaponMoveTypes':'各武器动作的移动类型','fireDirectionX':'射击方向横向分量','fireDirectionZ':'射击方向纵向分量','isLoop':'循环参数','isSelfRotate':'是否自转','nextPointOffsetX':'目标点横向偏移','nextPointOffsetZ':'目标点纵向偏移','noFindTarget':'不主动查找目标参数','rotateSpeed':'旋转速度','weaponWeights':'武器选择的相对权重','WeaponWeights':'武器选择的相对权重','Count':'数量参数，具体含义取决于所在修饰器','TotalAngle':'齐射分配总角度','StartAngle':'齐射起始角度','RotateSpeed':'转向速度参数','CallMonsterId':'被召唤的怪物实体ID','TotalDuration':'召唤持续时间','MinInterval':'召唤最小间隔','MaxInterval':'召唤最大间隔','CallAIType':'召唤怪的行为类型','FireDamageAddToSelf%':'自身承受火伤增加百分比','IceDamageResist%':'冰属性伤害抗性百分比','AttackTime':'离场攻击持续参数，须先确认离场类型启用','Duration':'持续时间','Parallel':'并行执行参数','RandomEdge':'随机边缘出生参数','ExplosionEffectId':'死亡爆炸表现特效编号','ThroughCount':'可穿透次数','ScaleAnimMod':'缩放动画修饰器','StartScale':'初始缩放','TargetScale':'目标缩放','ScaleTime':'缩放耗时','FireOnDeadMod':'死亡触发射击修饰器','MoveStraight':'直线弹道','Laser':'激光弹道','numberRandom':'随机路线实际目标生成数量，最后一个候选编队会截断','missionPool':'实际位置编队的模板名候选列表','Monster':'替换模板成员的怪物候选ID','flushPool':'组合编队子项列表','Delay':'子编队延迟','interval':'重复次数与重复间隔','effects':'实际属性效果表达式','Type':'实体类型或子弹类型，取决于所在配置表','leaveType':'离场逻辑类型，0表示未启用','CallMonsterWeight':'召唤动作相对权重，不能直接解释为百分比'})
def e(v):return html.escape(str(v))
def clean(v):return re.sub(r'</?(?:color|size|b|i)(?:=[^>]*)?>','',v)
def tip(k):return '<abbr title="'+e(FIELDS.get(k,AI.get(k,('配置字段，原值保存在数据中',))[0]))+'">'+e(k)+'</abbr>'
def js(v):return json.dumps(v,ensure_ascii=False,indent=2)
def n(v):return f'{v:,.4f}'.rstrip('0').rstrip('.') if isinstance(v,float) else str(v)
def bounds(v):return n(v[0]) if v[0]==v[1] else n(v[0])+'—'+n(v[1])
def table(head,rows):return '<div class="scroll"><table><thead><tr>'+''.join('<th>'+x+'</th>' for x in head)+'</tr></thead><tbody>'+''.join('<tr>'+''.join('<td>'+str(v)+'</td>' for v in row)+'</tr>' for row in rows)+'</tbody></table></div>'
def pre(v):
 s=e(js(v))
 for key in sorted(FIELDS,key=len,reverse=True):
  token='&quot;'+e(key)+'&quot;'
  s=s.replace(token,'&quot;<abbr title="'+e(FIELDS[key])+'">'+e(key)+'</abbr>&quot;')
 return '<pre>'+s+'</pre>'
def shape(v):
 if len(v)==1:return '圆：基础半径 '+n(v[0])
 if len(v)==2:return '盒：基础半宽/半长 '+n(v[0])+' / '+n(v[1])
 return '特殊形状 '+e(v)
def assets():return {k:m.read(D/(k+'.json')) for k in ['catalog','chapters','waves','occurrences','weapons','bullets','links']}
def fact_data():
 specs=[
 ('M01','scope','305条敌方实体配置；主线70章基础/B脚本候选覆盖110种，按Type分为77普通、14精英、19首领。','Character_entity','WaterfallBattleManager--Create'),
 ('M02','spawn','固定位置、组合编队、随机怪路线可同时执行；interval控制重复；随机怪以numberRandom截断，不以候选组大小计总量。','MissionWaterfallMission','WaterfallBattleManager--CreateIntervalMonster','WaterfallBattleManager--CalRandomMonster','WaterfallBattleManager--CalTileSpecialMonsterCount'),
 ('M03','map','地图编队按MissionData二进制读序解码；完整文件字节消费验证；实际位置模板由missionPool引用。','Mission_PositionMonster','MissionData--Deserialize','MissionData--ReadPos','MissionData--ReadRect'),
 ('M04','ai','主线chapterType8采用WaveAIId/WaveAIParameters；自定义AI可覆盖。110种中59种与常规参数不同。','Character_entity','GameUtils--GetAI','CharacterComponentAI--Init'),
 ('M05','attribute','名义生命=本体×章节×波次×任务生命倍率；任务0跳过。攻击倍率同时参与攻击与接触攻击；额外属性与运行状态不包含在名义值中。','CommonUtils--CreateAttributeData','BattleManager--AddExBattleWaveAttr','BattleWorldContext--CreateEnemy'),
 ('M06','collision','角色初始化碰撞缩放为1；单元素Shape创建圆，双元素创建盒。模型缩放不直接代表碰撞尺寸。子弹碰撞另有类型、偏移及动态缩放。','EntityCharacterData--SetTableData','EntityCharacterData--SetShapeScale','BulletData--SetScaleShape','BulletData--CreateCircleShape'),
 ('M07','death','爆爆河豚的死亡参数指向70010，死亡完成回调FireNow触发死亡武器；常规fireDelay=9999不能解释成每1.5秒正常射击。','Character_entity','Weapon_Weapon','CharacterBackDeathFireBullet--OnEnterDeathComplete'),
 ('M08','random','AICommonBoss有两层权重选择；首领340014含召唤330008分支。静态投放数量不包含战斗内动态召唤。','AICommonBoss--InitAttackLoop','AICommonBoss--InitWeapons','AIStateController--SelectWeightedRandomIndex','Character_entity'),
 ('M09','traits','主线110种MonsterTraitID均为空。能力描述与effects分开保存；描述不是执行证据。FireDamageAddToSelf为承受伤害增加，不是输出加成。','Character_MonsterAbility','Character_MonsterTrait','Character_entity'),
 ('M10','interpretation','前30章首次引入100/110种脚本怪；后续更多依赖组合与数值扩展。此为配置归纳，不是开发者公开设计意图。','Character_entity','Chapter_MainChapter','MissionWaterfallMission'),
 ]
 sources=m.read(D/'sources.json');out=[]
 for fid,area,claim,*keys in specs:
  refs=sorted({s['path'] for s in sources if any(key in s['path'] for key in keys)})
  out.append(dict(id=fid,area=area,status='策划解读' if area=='interpretation' else '静态证据已核实',claim=claim,evidence=refs))
 return out
def metadata():
 m.write(D/'facts.json',fact_data())
 m.write(D/'questions.json',[
  dict(id='Q01',issue='线上热更新、分支分流及实际开放范围',impact='本报告适用于1.0.16客户端静态内容，不承诺线上完全一致。',next='拿到对应版本运行态配置后核对哈希与分支。'),
  dict(id='Q02',issue='完整逐帧碰撞与像素范围',impact='公开基础Shape与动态修饰器，不把模型大小或速度×寿命当精确有效射程。',next='需要命中框复现时，继续追踪CreateBulletData缩放实参、轨迹处理器和摄像机换算。'),
  dict(id='Q03',issue='每类怪物逐帧运动的精确时间曲线',impact='已给出行为家族、参数、路径锚点和执行入口；相机/出生变换与运动处理器未全部复现。',next='按具体怪物ID定向追踪相应任务Update，避免重新扫描全项目。'),
  dict(id='Q04',issue='首领最终动作百分比与动态召唤次数',impact='存在权重选择和召唤配置；冷却、任务持续时间与可用动作改变实际频率。',next='需要概率模拟时补齐权重初始化和可选动作状态，不直接把20解释成20%。'),
  dict(id='Q05',issue='22种主线怪缺少可确认的官方中文名称',impact='按类型与稳定ID显示，不按外形杜撰名称。',next='若需要美术图鉴，结合ModelID定向提取资源并人工匹配。'),
 ])
 (D/'README.md').write_text('''# 怪物专题：中间数据入口

适用：com.fhzj.game，客户端1.0.16。静态主线70章、基础/B双分支；不保证线上开放与热更新一致。

- `catalog.json.gz`：305条敌方实体完整属性；mainline=true的110条进入脚本分布，含中文名、能力、AI参数、武器/子弹关联和名义属性区间。
- `occurrences.json.gz`：20496条非宝箱任务行。chapter/branch/wave/mission定位；routes保留每种编队候选，counts是逐种数量上下界，total是独立计算的总量上下界。**不同怪的边界不一定同时成立，不能相加当总量**。
- `chapters.json`、`waves.json`：140章分支和2030波投放汇总；数量为脚本预算，排除动态召唤、宝箱、隐藏9999。
- `maps.json`：188个被主线引用的模板，坐标/旋转/延迟来自完整读取验证过的地图二进制。
- `weapons.json`、`bullets.json`、`links.json`：117武器、89子弹和显式关联；包含后续触发武器。配置关联不保证每条运行时触发。
- `inputs/`：完整22张表、中文词典、版本基线、30条烘焙路径、编队快照。保留定点原始字段；计算展示使用解码十进制，可能有定点舍入误差。
- `evidence/`、`sources.json`：最小原生方法摘录、原始路径及SHA-256。C#空方法体不是实现证据。
- `facts.json`：结论→证据；`questions.json`：具体边界和继续研究入口；`manifest.json`：包内哈希。

离线命令（只需Python标准库）：
```
python3 research-data/tools/monster_topic.py validate
python3 research-data/tools/monster_topic.py monster:320007
python3 research-data/tools/monster_topic.py chapter:19
python3 research-data/tools/monster_topic.py rebuild
python3 research-data/tools/monster_topic.py render
```
`snapshot`才需要L1；日常rebuild/render/query不需要APK。先读报告，再查上述数据，仅在questions所列需求出现时定向下挖。
''')
def render():
 data=assets();cs=[x for x in data['catalog'] if x['mainline']];byid={x['id']:x for x in cs}
 def link(i):return '<a href="#monster-'+str(i)+'">'+e(byid[i]['name'])+' · '+str(i)+'</a>'
 out=['''<!doctype html><html lang="zh-CN"><head><meta charset="utf-8"><meta name="viewport" content="width=device-width,initial-scale=1"><title>怪物设计、弹幕与章节分布 · 策划专题</title><link rel="stylesheet" href="assets/style.css"><style>td{vertical-align:top}details{padding:12px 0;border-bottom:1px solid #d4e2de}summary{cursor:pointer;font-weight:650}pre{white-space:pre-wrap;overflow-wrap:anywhere;max-height:420px;overflow:auto}abbr{cursor:help;text-decoration:underline dotted #8aaca1;text-underline-offset:4px}.filters{display:flex;flex-wrap:wrap;gap:12px;margin:16px 0}.filters input,.filters select{padding:10px;border:1px solid #abc7bc;border-radius:7px;font:inherit;max-width:100%}.monster-card[hidden]{display:none}.path-grid{display:grid;grid-template-columns:repeat(auto-fit,minmax(210px,1fr));gap:12px}.path-grid figure{margin:0;padding:12px;border:1px solid #d4e2de;border-radius:10px}.path-grid svg{width:100%;height:180px}.minor{color:#526b60;font-size:13px}.scroll{max-width:100%;overflow:auto}article{min-width:0}select{background:white}h2{scroll-margin-top:20px}</style></head><body><header class="page-head"><div class="hero"><div class="eyebrow">怪物设计研究 · 客户端1.0.16</div><h1>怪物、弹幕与章节分布</h1><p>从投放编队到行动、攻击、碰撞和死亡，解释怪物如何组成一章的压力。附逐怪档案、70章双分支逐波名单与可复算证据。</p><div class="chips"><span>110种主线脚本怪</span><span>15类主线行为</span><span>70章 × 基础/B</span><span>2030波</span></div></div></header><main class="layout"><nav class="toc"><strong>专题目录</strong><ul>''']
 sections=[('overview','设计结论'),('spawn','投放与随机'),('stats','数值与抗性'),('motion','行动轨迹'),('attack','子弹与范围'),('cases','代表怪物'),('catalog','110种怪物档案'),('chapters','章节与波次分布'),('evidence','证据与交接')]
 out+=[''.join('<li><a href="#'+k+'">'+v+'</a></li>' for k,v in sections)+'</ul><p><a href="core.html">整体链路</a></p><p><a href="chapter-planning.html">章节规划</a></p><p><a href="choices-box-evolution.html">三选一与宝箱</a></p></nav><article class="article">']
 out+=['''<h2 id="overview">1. 怪物体系的设计结论</h2><p class="summary">策划解读：主线用低生命的通行怪建立移动压力，用驻留射手和特殊弹道压缩安全空间，再用精英与首领检验输出和走位。前30章已引入100种脚本怪，之后更多通过已有怪的组合、编队与属性倍率扩展难度。</p><p>完整敌方配置305条；主线脚本可能投放110种：77普通怪、14精英、19首领。按实体类型分类，不按名字分类：例如“精英眼球怪310023”实际Type=2。未直接投放的195条保留在中间数据，不能据此认定游戏中不存在。名字缺失的22条保留稳定ID。</p>''']
 out.append(table(['首次进入脚本的章节区间','新实体种类','阅读方式'],[[f'{start}—{start+9}',sum(start<=x['first_chapter']<=start+9 for x in cs),'按实际投放候选反查；不使用“新怪展示”标记'] for start in range(1,71,10)]))
 out+=['''<h2 id="spawn">2. 出现条件、编队与随机控制</h2><p>章节选择任务前缀 → 波号与任务时点 → 位置/组合/随机路线 → 地图模板与实体覆盖 → 生成角色 → 主线行为参数 → 武器与子弹 → 碰撞、死亡和后续触发。宝箱任务type=9单独处理，不作为怪物数。</p>''',table(['投放方式','实际规则','策划意义'],[
 ['位置模板','按missionPool取地图编队；有Monster覆盖时替换模板成员。覆盖候选是整份模板的一次选择。','位置、延迟与怪种可分离复用。'],
 ['组合编队','候选组合中每个flushPool子项分别取位置模板、怪物候选与Delay。','一次事件可以同时形成多路压迫。'],
 ['随机怪','反复选候选组，累计到numberRandom，末组截断。当前主线目标数量为1—4。','候选成员数改变排列，不能直接当实际生成数。'],
 ['重复与叠加','interval给出重复次数和间隔；同一行可以同时走位置、组合、随机路线。','1242条主线任务同时带位置和随机投放，不可二选一计数。'],
 ['动态召唤','首领340014在19/35/51/66章可进入召唤330008分支。','战斗持续时间和动作选择会增加敌人，独立于脚本预算。']])]
 out+=['''<p class="callout">表中的数量是“任务完整执行时的计划投放量”，不是实机击杀数。分支、提前结束、场上限制、动态召唤都会影响实机结果；候选怪分别给上下界，总量另算，不能把互斥候选的最大值全部相加。</p><p>随机组中的weight/height参与队形坐标，并非出现权重。首领动作使用另一套权重选择；CallMonsterWeight=20不能直接写成20%召唤率。基础/B为配置分支，不能称为新手/老手。</p><h2 id="stats">3. 生命、攻击和怪物特性</h2><p>配置合成基准：生命 = 本体HP × 章节hpUpgrade × 波次hpUpgrade × 任务hpUpgrade；任务倍率0表示跳过该乘项，计算按1处理。攻击与接触攻击同样叠加章节/波次/任务攻击倍率。所有70章的章节层倍率均为1，主要变化来自波次和任务。</p><p>这是名义值，未把临时属性、额外血量保护、抗性与受伤公式当作已算清的最终战斗值。表内十进制计算还可能与运行定点逐步舍入存在微差。子弹伤害需继续应用hurtAttributes，基础Attack不是最终单次扣血。</p>''']
 out.append(table(['实体类型','主线种类','基础生命范围','基础攻击范围'],[[TYPES[t],len(z:= [x for x in cs if x['type']==t]),bounds([min(x['base']['HP'] for x in z),max(x['base']['HP'] for x in z)]),bounds([min(x['base']['Attack'] for x in z),max(x['base']['Attack'] for x in z)])] for t in [2,201,3]]))
 out+=['''<p>能力表同时包含图鉴描述与真正的effects属性。僵尸探子有冰伤抗性60%、承受火伤增加30%，后者是弱点，不是自己的火伤提高。主线110种MonsterTraitID全部为空；配置中存在的护盾、分裂等通用词缀不能直接套给主线怪。</p><h2 id="motion">4. 行动轨迹与攻击节奏</h2><p>主线采用WaveAIId与WaveAIParameters；110种中59种与常规参数不同。例如普通僵尸骑手主线fireInterval=2.5，常规为1.5。角色FireCD=0也不表示每帧攻击，必须看AI任务。出生参数、离场类型和死亡处理独立；leaveType=0时不能仅凭离场参数里的13秒断言会离场。</p>''']
 out.append(table(['行为家族','主线种类','动作与参数'],[[tip(k)+'<br>'+e(AI[k][0]),sum(x['base']['WaveAIId']==k for x in cs),e(AI[k][1])] for k in AI]))
 out+=['<h3>路径资源的空间锚点</h3><p>下图连线仅连接资源锚点，显示X/Z平面布局和顺序；不冒充实机贝塞尔采样轨迹。原始控制柄、烘焙长度、分辨率和闭合标记已保存。出生位置、朝向、循环重置与速度需结合具体行为类。</p><div class="path-grid">']
 paths=sorted({r['id'] for x in cs for r in x['references'] if r['kind']=='path'})
 for pid in paths:
  cfg=next(x for x in m.table('MovePath_MovePath') if x['ID']==pid);p=m.read(D/'inputs/paths'/(cfg['FileName']+'.json'));pts=[(v['position']['X'],v['position']['Z']) for v in p['Points']];size=max([abs(v) for pt in pts for v in pt]+[1]);xy=[(100+x/size*72,90-z/size*72) for x,z in pts]
  svg='<svg viewBox="0 0 200 180" role="img" aria-label="路径'+str(pid)+'锚点"><path d="M100 5V175M10 90H190" stroke="#ccdcd4"/><polyline points="'+' '.join(f'{x:.2f},{y:.2f}' for x,y in xy)+'" fill="none" stroke="#248365" stroke-width="2"/>'+''.join(f'<circle cx="{x}" cy="{y}" r="3" fill="#ca6b3c"/><text x="{x+5}" y="{y}" font-size="10">{i+1}</text>' for i,(x,y) in enumerate(xy))+'</svg>'
  out.append('<figure><figcaption>路径 '+str(pid)+' · '+str(len(pts))+' 锚点</figcaption>'+svg+'<p class="minor">'+e(pts)+'<br>资源长度 '+n(p['length'])+'；闭合 '+('是' if p['Close'] else '否')+'</p></figure>')
 out+=['</div><h2 id="attack">5. 子弹、打击范围与危险区域</h2><p>关联图覆盖117个武器与89种子弹，包含死亡触发和二段弹。每个怪物档案显示直接武器及后续关联；“配置引用到”与“本次战斗一定发射”分开判断。</p>',table(['维度','正确读法','容易误读的地方'],[
 ['角色碰撞','Shape一项为圆半径；两项为盒的半宽/半长；初始化碰撞缩放为1。','ModelScale是模型缩放，不直接乘入碰撞框。'],
 ['子弹碰撞','Shape、ShapeOffset、类型和运行缩放共同决定；下方仅展示基础形状。环形类型有独立分支。','Bullet.Scale不能未经调用链验证直接乘基础半径。'],
 ['攻击距离','AttackDistance参与AI攻击判定；BulletLifeRange参与子弹距离限制。','都不是肉眼可见的打击圆半径。'],
 ['持续命中','MinBulletHurtTime是同目标重复命中的时间约束。','不能当作敌人发射间隔。'],
 ['有效射程','寿命、速度、轨迹、追踪/反弹、销毁与距离截断共同决定。','速度×寿命仅适用于无遮挡匀速直线理想模型，不适用于激光和追踪全过程。'],
 ]),table(['案例链路','射击/弹道配置','基础形状与时间'],[
 ['骑手 → 70005 → 7005','3发齐射，配置总角60°；直线速度14','圆半径0.3；寿命10秒；重复伤害间隔0.1秒'],
 ['僵尸探子 → 70007 → 7007','直线轨迹叠加追踪，RotateSpeed=35；初速13','圆半径0.27；寿命10秒；主线射击间隔2.3秒'],
 ['激光小机 → 70006 → 7006','红线预警；激光蓄力参数3.2；伤害表达式Attack×50%','盒半宽0.2/半长50；寿命2秒；重复伤害间隔0.2秒'],
 ['爆爆河豚死亡 → 70010 → 7010','死亡完成回调射击；5发、配置总角360°','圆半径0.3；速度19；不要套常规fireInterval'],
 ['武器70041 → 死亡触发70042','二段武器4发，配置总角360°、起始角45°','需追后续武器，不能只看第一颗子弹'],
 ]),'<p>以上角度为修饰器参数，360°表示环向分配配置；精确每发夹角要结合相应处理器。激光基础盒全长100并不等于屏幕有效射程100，动态长度、方向、偏移和命中检查仍参与。</p>']
 out+=['<h2 id="cases">6. 代表怪物的策划用途</h2>',table(['怪物','核心威胁','策划解读'],[
 [link(330006),'生命150、路径7通行；初始化攻击循环只添加路径任务。','轻量移动障碍；虽然有激光武器配置，不能归类为持续激光射手。'],
 [link(320007),'两点移动＋追踪弹；冰抗60%，火弱30%。','追踪与抗性共同制造走位和构筑选择。'],
 [link(320013),'生命2450、预警激光、3.5秒射击间隔参数。','用预警给反应窗口，以长条攻击压缩通道。'],
 [link(320018),'常规射击延迟9999；死亡触发环向武器70010。','击杀本身引入后续危险，清怪节奏也需要规划。'],
 [link(340014),'19/35/51/66章；多武器＋召唤330008，召唤持续4秒、间隔参数0.4—0.85秒。','首领战叠加杂兵占位；不把配置间隔直接换成固定召唤次数。'],
 [link(330023),'中心(0,0)、半径15→11、旋转速度30、等待参数8秒。','用环绕/收缩轨迹重塑通行空间；效果需结合编队同时投放。'],
 ])]
 out+=['<h2 id="catalog">7. 逐怪档案</h2><p>搜索名称、ID、行为类或能力描述；按首次登场排序，可按类型与出现章节筛选。展开查看主线参数、常规参数、出生/离场、武器、子弹、抗性和全部章节。数值均来自本体表，名义范围另列。</p><div class="filters"><input id="monster-search" aria-label="搜索怪物" placeholder="名称 / ID / 行为 / 抗性"><select id="monster-type" aria-label="怪物类型"><option value="">全部类型</option><option value="2">普通怪</option><option value="201">精英</option><option value="3">首领</option></select><select id="monster-chapter" aria-label="怪物出现章节"><option value="">全部章节</option>'+''.join(f'<option value="{i}">第{i}章</option>' for i in range(1,71))+'</select></div><p id="monster-count" aria-live="polite">110种怪物</p>']
 for c in sorted(cs,key=lambda x:(x['first_chapter'],x['type'],x['id'])):
  b=c['base'];search=e(' '.join([str(c['id']),c['name'],b['WaveAIId'],js(c['abilities'])]).lower());out.append(f'<details class="monster-card" id="monster-{c["id"]}" data-type="{c["type"]}" data-chapters="{e(json.dumps(sorted(set(c["chapters"]["base"]+c["chapters"]["B"]))))}" data-search="{search}"><summary>{e(c["name"])} · {c["id"]} · {TYPES[c["type"]]} · 首见第{c["first_chapter"]}章</summary>')
  out.append(table(['基础属性','值','基础属性','值'],[[tip('HP'),n(b['HP']),tip('Attack'),n(b['Attack'])],[tip('BodyAttack'),n(b['BodyAttack']),tip('MoveSpeed'),n(b['MoveSpeed'])],[tip('Shape'),shape(b['Shape']),tip('ModelScale'),n(b['ModelScale'])],[tip('AttackDistance'),n(b['AttackDistance']),tip('BulletLifeRange'),n(b['BulletLifeRange'])]]))
  out.append('<p>行为：'+tip(b['WaveAIId'])+' · '+e(AI[b['WaveAIId']][0])+'。'+e(AI[b['WaveAIId']][1])+'</p>')
  for label,key in [('主线行为参数','ai'),('常规行为参数（其他场景，供核对）','normal_ai')]:out.append('<details><summary>'+label+'</summary>'+pre(c[key])+'</details>')
  out.append('<p>主线参数说明：'+ '；'.join(tip(k) for k in c['ai'])+'</p>')
  out.append('<h4>能力与抗性</h4>'+table(['能力ID','图鉴描述（不是执行证据）','属性效果'],[[a['id'],e(clean('；'.join(a['description']))),e(a['effects'])] for a in c['abilities']])+'<p>特殊词缀ID：'+e(b['MonsterTraitID'])+'</p>')
  out.append('<h4>投放与名义数值</h4>'+table(['分支','出现章节','名义生命范围','名义攻击范围'],[[tip(r['branch']),e('、'.join(map(str,c['chapters'][r['branch']]))),bounds([r['hp_nominal_min'],r['hp_nominal_max']]),bounds([r['attack_nominal_min'],r['attack_nominal_max']])] for r in c['nominal_ranges']]))
  out.append('<p>直接武器：'+e(c['weapon_ids'])+'；以下还包含条件触发的后续武器。</p>')
  for wd in c['weapon_details']:
   w,bu=wd['weapon'],wd['bullet'];wid=w['ID'];bid=bu.get('ID');out.append('<details><summary>武器 '+str(wid)+' → 子弹 '+str(bid)+(' · 直接配置' if wid in c['weapon_ids'] else ' · 后续关联')+'</summary>')
   out.append(table(['项目','配置'],[[tip('Trajectory'),e(w['Trajectory'])],[tip('TrajectoryParams'),e(w['TrajectoryParams'])],[tip('Shape'),e(bu.get('Shape'))+'；类型 '+str(bu.get('Type'))],[tip('ShapeOffset'),e(bu.get('ShapeOffset'))],[tip('Scale'),n(bu.get('Scale'))],[tip('MoveSpeed'),n(bu.get('MoveSpeed'))],[tip('LifeTime'),n(bu.get('LifeTime'))],[tip('MinBulletHurtTime'),n(bu.get('MinBulletHurtTime'))],[tip('hurtAttributes'),e(bu.get('hurtAttributes'))]]))
   mods={k:v for k,v in w.items() if 'Mod' in k and v};out.append('<p>弹道修饰器（完整参数）</p>'+pre(mods)+'</details>')
  out.append('<details><summary>出生、离场与死亡</summary>'+table(['字段','值'],[[tip(k),e(b[k])] for k in ['bornType','bornParameters','WaveleaveType','WaveleaveParameters','deathClassId','deathParams']])+'</details><details><summary>完整实体配置（用于进一步分析）</summary>'+pre(b)+'</details></details>')
 out+=['<h2 id="chapters">8. 逐章与逐波分布</h2><p>每章列出基础/B数量、全部候选名单，并细分普通/精英/首领的波次分布。点击怪物名进入档案；展开波次可看到每种怪的数量范围。动态召唤不计入这里。</p>']
 for cid in range(1,71):
  cc=[r for r in data['chapters'] if r['chapter']==cid];a,b=cc;out.append(f'<details id="chapter-{cid}"><summary>第{cid}章 · {a["waves"]}波 · 计划数量 {bounds(a["total"])} / {bounds(b["total"])}（基础/B）</summary>')
  ids=sorted(set(a['monster_ids']+b['monster_ids']));out.append(table(['类型','候选怪物'],[[TYPES[t],'；'.join(link(i) for i in ids if byid[i]['type']==t)] for t in [2,201,3]]))
  for branch in ['base','B']:
   ww=[r for r in data['waves'] if r['chapter']==cid and r['branch']==branch];out.append('<h4>'+('基础分支' if branch=='base' else 'B分支')+'</h4>')
   out.append(table(['波','总量','逐怪数量范围'],[[w['wave'],bounds(w['total']),'<br>'.join(link(int(k))+' × '+bounds(v) for k,v in sorted(w['counts'].items()) if v[1])] for w in ww]))
  out.append('</details>')
 out+=['<h2 id="evidence">9. 证据与可复用研究包</h2><p>结论按M01—M10编号保存，覆盖版本与范围、投放、地图解码、主线AI、数值、碰撞、死亡、随机与特性。每条结论都指向输入表或完整方法摘录，sources记录L1路径与哈希。</p>']
 base='https://github.com/chitanda233/xxyzd-research/blob/main/research-data/topics/monsters/'
 out.append('<p><a href="downloads/xxyzd-monsters.zip">下载怪物专题＋中间数据＋代码证据（离线可用）</a></p>')
 out.append(table(['文件','用途'],[['<a href="'+base+k+'">'+k+'</a>',v] for k,v in [('README.md','数据字典与复用流程'),('facts.json','已核实规则与证据索引'),('questions.json','具体边界与继续研究入口'),('sources.json','原始来源与哈希'),('catalog.json.gz','完整305条怪物档案'),('occurrences.json.gz','任务级投放、候选与属性因子'),('manifest.json','文件完整性清单')]]))
 out+=['<p>尚未把全部运动处理器复现为逐帧仿真，未测量像素命中框、线上动作频率或热更新差异。需要这些精度时，可从具体怪物ID、关联武器、路径和原生方法继续；当前章节分布和名义数值不依赖重新反编译。</p><pre>python3 research-data/tools/monster_topic.py validate\npython3 research-data/tools/monster_topic.py monster:320007\npython3 research-data/tools/monster_topic.py chapter:19\npython3 research-data/tools/monster_topic.py rebuild\npython3 research-data/tools/monster_topic.py render</pre></article></main><script>const cards=[...document.querySelectorAll(".monster-card")];function filter(){const q=document.getElementById("monster-search").value.trim().toLowerCase(),t=document.getElementById("monster-type").value,c=Number(document.getElementById("monster-chapter").value);let count=0;for(const x of cards){x.hidden=!!((q&&!x.dataset.search.includes(q))||(t&&x.dataset.type!==t)||(c&&!JSON.parse(x.dataset.chapters).includes(c)));if(!x.hidden)count++;}document.getElementById("monster-count").textContent=count+"种怪物";}document.querySelectorAll(".filters input,.filters select").forEach(x=>x.addEventListener("input",filter));function reveal(){const x=document.getElementById(location.hash.slice(1));if(x&&x.tagName==="DETAILS"){x.hidden=false;x.open=true;setTimeout(()=>x.scrollIntoView(),0);}}window.addEventListener("hashchange",reveal);reveal();</script><script src="assets/term-tips.js"></script></body></html>']
 p=ROOT/'docs/monsters.html';p.parent.mkdir(exist_ok=True);p.write_text('\n'.join(out));print('rendered',p,p.stat().st_size)
def manifest():
 m.write(D/'manifest.json',{'files':[dict(path=str(p.relative_to(D)),sha256=m.sha(p),bytes=p.stat().st_size) for p in sorted(D.rglob('*')) if p.is_file() and p.name!='manifest.json']})
def validate():
 data=m.derive()
 for k,v in data.items():assert v==m.read(D/(k+'.json')),('stale derived',k)
 cs=[c for c in data['catalog'] if c['mainline']];assert len(cs)==110 and len(data['waves'])==2030 and len(data['chapters'])==140
 assert collections.Counter(c['type'] for c in cs)=={2:77,201:14,3:19}
 assert all(not c['traits'] for c in cs)
 for ev in data['occurrences']:
  assert ev['total'][0]<=ev['total'][1]
  for part in ev['routes']:
   if part['route']=='random':assert part['total']==[part['number']]*2
 for c in data['chapters']:
  ww=[w for w in data['waves'] if w['chapter']==c['chapter'] and w['branch']==c['branch']]
  assert len(ww)==c['waves'] and c['total']==[sum(w['total'][i] for w in ww) for i in [0,1]]
 for kind,tablename in [('weapon','Weapon_Weapon'),('bullet','Bullet_Bullet'),('monster','Character_entity'),('path','MovePath_MovePath')]:
  ids=set(m.keyed(tablename));assert all(r['id'] in ids for r in data['links'] if r['kind']==kind),kind
 for f in m.read(D/'facts.json'):
  assert f['evidence'] and all((D/p).exists() for p in f['evidence']),f['id']
 for f in m.read(D/'manifest.json')['files']:assert m.sha(D/f['path'])==f['sha256'],f['path']
 print('PASS: offline derivation, 110 enemies, 2030 waves, 140 branches, spawn totals, joins, evidence and hashes')
def export():
 manifest();validate();dest=ROOT/'docs/downloads/xxyzd-monsters.zip';dest.parent.mkdir(exist_ok=True)
 files=[p for p in D.rglob('*') if p.is_file()]+[ROOT/'research-data/tools/monster_topic.py',ROOT/'research-data/tools/monster_report.py',ROOT/'docs/monsters.html']+[ROOT/'docs/assets'/n for n in ['style.css','term-tips.css','term-tips.js']]
 with zipfile.ZipFile(dest,'w',zipfile.ZIP_DEFLATED,compresslevel=9) as z:
  for p in sorted(files):
   content=p.read_bytes()
   if p.name=='monsters.html':
    s=content.decode().replace('https://github.com/chitanda233/xxyzd-research/blob/main/research-data/','../research-data/').replace('href="downloads/xxyzd-monsters.zip"','href="../research-data/topics/monsters/README.md"')
    for page in ['core.html','chapter-planning.html','choices-box-evolution.html']:s=s.replace('href="'+page+'"','href="https://chitanda233.github.io/xxyzd-research/'+page+'"')
    content=s.encode()
   z.writestr(str(p.relative_to(ROOT)),content)
  z.writestr('START-HERE.txt','打开 docs/monsters.html；数据字典在 research-data/topics/monsters/README.md。\n离线校验：python3 research-data/tools/monster_topic.py validate\n无需APK或反编译环境。站内其他专题链接需联网。\n')
 print('exported',dest,dest.stat().st_size,m.sha(dest))
def main(cmd):
 if cmd=='render':metadata();render();manifest()
 elif cmd=='validate':validate()
 elif cmd=='export':export()
 elif cmd.startswith('monster:'):print(js(next(x for x in m.read(D/'catalog.json') if x['id']==int(cmd.split(':')[1]))))
 elif cmd.startswith('chapter:'):print(js({k:[x for x in m.read(D/(k+'.json')) if x['chapter']==int(cmd.split(':')[1])] for k in ['chapters','waves','occurrences']}))
 else:raise SystemExit('commands: snapshot rebuild render validate export monster:ID chapter:ID')
if __name__=='__main__':main(sys.argv[1])
