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
 for ex in read('probability-examples.json'):
  assert abs(sum(ex['probabilities'])-1)<1e-12
  if 'weights' in ex:assert all(abs(w/sum(ex['weights'])-p)<1e-12 for w,p in zip(ex['weights'],ex['probabilities']))
 for hit in read('inputs/native-constant-arrays.json')['hits']:assert hashlib.sha256(bytes.fromhex(hit['bytes_hex'])).hexdigest().upper()==hit['field_hash']
 if (D/'manifest.json').exists():
  mm=read('manifest.json');actual={str(p.relative_to(D)) for p in D.rglob('*') if p.is_file() and p.name!='manifest.json'};assert actual==set(mm)
  for p,h in mm.items():assert sha(D/p)==h,p
 return {'status':'passed','facts':len(read('facts.json')),'recipes':len(r),'sources':len(read('sources.json')),'scope':'static references, hashes, recipe joins and conditional arithmetic; no live-game verification'}
def manifest():
 dump(D/'manifest.json',{str(p.relative_to(D)):sha(p) for p in sorted(D.rglob('*')) if p.is_file() and p.name!='manifest.json'})
def render():
 e=lambda x:html.escape(str(x));online=(ROOT/'restored').exists();base='https://github.com/chitanda233/xxyzd-research/blob/main/research-data/topics/choices-box-evolution/' if online else '../research-data/topics/choices-box-evolution/'
 def table(headers,rows):return '<div class="scroll"><table><thead><tr>'+''.join('<th>'+e(v)+'</th>' for v in headers)+'</tr></thead><tbody>'+''.join('<tr>'+''.join('<td>'+e(v)+'</td>' for v in row)+'</tr>' for row in rows)+'</tbody></table></div>'
 def refs(*ids):return '<p class="evidence">依据：'+' · '.join('<a href="#'+i+'">'+i+'</a>' for i in ids)+'</p>'
 parts=['''<!doctype html><html lang="zh-CN"><head><meta charset="utf-8"><meta name="viewport" content="width=device-width,initial-scale=1"><title>三选一、宝箱怪与武器进化 · 策划专题</title><link rel="stylesheet" href="assets/style.css"><style>details{padding:14px 0;border-bottom:1px solid #d4e2de}summary{cursor:pointer;font-weight:650}pre{white-space:pre-wrap;overflow-wrap:anywhere;background:#f3f7f6;padding:16px;border-radius:8px;font-size:13px}details:target{background:#edf4fb}td{vertical-align:top}</style></head><body><header class="page-head"><div class="hero"><div class="eyebrow">IN-RUN BUILD SYSTEM · RESEARCH TOPIC</div><h1>三选一、宝箱怪与武器进化</h1><p>研究成长机会如何出现、选项如何产生、武器如何进化，以及哪些差异真正来自章节、构筑、引导或分流。每项结论可回查配置与方法摘录。</p><div class="chips"><span>客户端 1.0.16</span><span>主线 SkillType=2</span><span>22 条配方</span><span>宝箱怪链路未闭合</span></div></div></header><main class="layout"><nav class="toc"><strong>专题目录</strong><ul>''']
 for k,v in [('scope','结论与边界'),('entry','成长入口'),('choice','三选一全链路'),('probability','概率控制'),('players','新手与老手'),('evolution','武器进化'),('treasure','宝箱怪与商店'),('data','复用数据'),('evidence','规则与证据')]:parts.append(f'<li><a href="#{k}">{v}</a></li>')
 parts.append('''</ul><a href="core.html">整体链路报告</a></nav><article class="article"><h2 id="scope">研究结论与适用边界</h2><p class="summary">主线的三选一是逐张抽取的构筑系统：章节权重决定技能倾向，已有技能与槽位决定候选范围，额外纠偏减少全被动结果；非_B武器进化要先满足配方、进入随机池，再通过选择落地。新手差异需要拆成引导覆盖、初始池、章节保护与A/B配置。</p><p>依据为同一APK的配置、原生方法和常量字节。主体解释基础（非_B）分支；涉及_B时单独注明。宝箱怪尚未连接成“击杀→拾取物→普通三选一”的完整链路；中途商店未确认。两项均不编造出现率、波次或收益，也不影响已独立核实的技能规则。</p>
<h2 id="entry">1. 成长入口：相似弹窗不能混为一个机制</h2>''')
 parts.append(table(['入口','何时发生 / 调用链','选择或收益','确认程度'],[
 ['普通成长','第一章 W1—W14 波末吸收经验、升级状态 → HeroComponentRandomSkill.RandomSkill → DankeSkillCreator','目标3个候选；玩家选取后更新构筑与技能池','静态确认；详见整体报告F06'],
 ['引导覆盖','OverrideGuideRandomSkill非空 → 直接复制指定列表 → 清空覆盖','本次候选来自指定列表','消费逻辑确认；覆盖初始化未闭合'],
 ['武器特殊选择','获得GetIsUpgrade=1节点 → 待处理特殊技能 → OpenSelectSpecialSkill','按该武器的UpgradeSkillId产生后续选项','静态确认；不等于额外升一级'],
 ['阶段技能事件','第一章脚本 W6/105s、W11/240s、W15/345s → Punchboard独立流程','数量档与已有/新技能、补位结果单独处理','不能当成额外普通三选一'],
 ['用户指定的宝箱怪','某怪物击杀 → 地面拾取物 → 拾取触发三选一','预期是独立拾取收益','具体怪物与拾取入口未闭合'],
 ['中途商店','用户记忆中的小关中间购买入口','库存、价格与刷新未知','本基线未确认']]))
 parts.append(refs('C01','C06','C10','C11','C12','C13'))
 parts.append('''<h2 id="choice">2. 主线三选一如何生成</h2><div class="flow"><div><b>① 判断入口</b>引导列表覆盖，或进入常规随机</div><div><b>② 判断池</b>Init计数大于0用初始池，否则常规池</div><div><b>③ 更新可用候选</b>已有/待学技能、槽位、前置、互斥与星级</div><div><b>④ 逐张抽取</b>检查类别可用性 → 类别权重 → 池内权重</div><div><b>⑤ 补足与纠偏</b>去重、轮转补池；全被动时尝试补武器</div><div><b>⑥ 选择后更新</b>学习/覆盖 → 更新下一阶与配方候选 → 必要时特殊选择</div></div><p>71条主线章节均配置SkillType=2，对应DankeSkillCreator。目标候选数为3，其GetNormalSkill循环调用单次取1个技能的GetRandomSkills。不要把普通随机器的整组品质抽签套进这里。</p><p>候选按当前构筑计算。武器与被动的可学槽位分别限制新入口；已学路线的升级候选另行处理。基础槽位常量为4武器+4被动，_B为5+5；_B后两个槽的开放阈值是6，函数用局内GetLevel()+1与阈值比较。这是局内开放条件，不是账号注册天数。</p><p>多候选结果没有武器类时，系统尝试将一个位置替换为武器候选；不足或没有合法目标时仍须走回退逻辑。因此“有武器纠偏”不等于“每屏必有一把未获得的新武器”。</p>'''+refs('C01','C04','C07'))
 parts.append('''<h2 id="probability">3. 概率控制：类别、技能权重和结果修正</h2>''')
 parts.append(table(['层次','控制内容','策划含义'],[
 ['类别权重','DankeSkillWeight=[0,200,300,300]；类别1被动、2武器、3特殊升级分类','先决定抽取方向；空池和状态会改变可用档'],
 ['类别映射','SkillType与GetIsUpgrade共同决定；入池函数参数会影响是否单列特殊升级','配方解锁传true且开关为0时，105系进入武器类别2；不可只看技能名'],
 ['章节技能权重','第一章用Weight_1；其他章按SkillGroupWeight选列','章节能独立调整构筑倾向，不能把Weight列当作所有章的权重'],
 ['初始池','10个武器入口，常规池18入口（11武器+7被动）','初始结构排除了被动入口，但是否启用仍由Init计数决定'],
 ['池内修正','星级入池乘数数组索引8为2，其余为1；条件保护临时+10%权重','改变相对机会，不能直接加到最终百分比上'],
 ['最终修正','去重、槽位、前置/互斥、补池、全被动纠偏、分支解析','各卡互相影响；不能假设独立同分布']]))
 parts.append('''<p><strong>条件概率示例：</strong>若只有类别1与2有效，且没有升档、刷新等修正，类别抽签是200/(200+300)=40%被动、60%武器。若1、2、3都有效，则为25% / 37.5% / 37.5%。这些仅是对应步骤的抽签比例，不是最终三张展示比例。</p><p>进入一个确定的有效候选池后，单项权重为w、总权重为W时，对应抽签机会为w/W；下一张因去重或候选变化应重新计算。要计算某技能本屏出现率，必须有当时完整池状态，不能直接套1−(1−p)³。</p><p>第一章常规入口中，机炮、冰刃弹的Weight_1都是300，部分其他武器为100，冰冻锯盘10001601为50；被动11000301为0，不能算作正权重候选。下面保留所有入口，供同事直接查数。</p>''')
 parts.append(table(['池','技能ID / 名称','类型','默认Weight','第一章Weight_1','WeightForNewplayer（本路由未读）'],[[r['pool'],str(r['skill_id'])+' '+r['name'],r['skill_type'],r['weight'],r['chapter_group_weights']['1'],r['weight_for_newplayer']] for r in read('pool-weights.json')]))
 parts.append('''<p><strong>属性与刷新：</strong>LevelUpSkillUpRate%修改普通品质数组，主线传入的是独立的Danke数组；不能据此宣称主线稀有技能概率提高。ExHighSkillRate%进入qualityUp判断，Danke内部按类别索引处理。刷新复用保存的索引，但不是保存三张牌各自的类别。Exp.randomSkillFactor虽然传入，APK的Danke.GetNormalSkill未消费它。长期同类增权的调用与公式存在，但已有证据中的应用fallback为空，暂不纳入生效概率。</p>'''+refs('C02','C03','C04','C07','C08'))
 parts.append('''<h3>阶段事件：数量概率还受构筑成熟度限制</h3><p>Punchboard基础数量权重为[60,0,30,0,10]，对应1/3/5档60%/30%/10%，未修正期望数量为2。函数把IsBattleSkill=1的已有技能按BattleSkillGroup去重计数：<strong>不同组数≤4时，5档权重清零</strong>。无其他修正时变成1档2/3、3档1/3，期望5/3。FiveSkillRate%只乘到最后一档权重；若随后被门槛清零，仍不会开放5档。</p><p>组数超过4、属性增幅a&gt;0且无其他覆盖时，5档权重为Round(10×(1+a))，还要与60和30重新归一化。因此“五档权重+100%”示例是20/110≈18.18%，并非从10%直接变成20%。这里的数量档也不等于净新增技能数。</p>'''+refs('C11'))
 parts.append('''<h2 id="players">4. 新手与老手：按实际条件拆分</h2>''')
 parts.append(table(['机制','实际条件','新手与重复游玩者的区别'],[
 ['引导覆盖','OverrideGuideRandomSkill有指定列表','有覆盖的一次抽取与普通抽取不同；是否仅新号赋值未闭合'],
 ['初始池','本局Init计数>0','计数是本局/存档状态；不能等同新账号专属'],
 ['临时保护','WorldType=1；章节保护含3；未持有10000101','第2—10章有配置，第1章没有；同条件的重复玩家也会走该分支'],
 ['章节权重','当前章的SkillGroupWeight','随章节变，不按新老账号直接分组'],
 ['槽位与已有技能','局内等级、当前持有技能、满槽情况','后期构筑与前期不同；这是局内状态差异'],
 ['_B分支','IsSkillABTestB','配方、星级和槽位有区别；没有证据把_B直接命名老玩家版']]))
 parts.append('''<p>第2—10章保护尝试对机炮10000101、冰刃弹10000601、灼热射线10001701临时加权10%，正常返回前撤销。这个条件还检查未持有机炮入口；不能简化为“新手第一次必中某武器”。配置中的WeightForNewplayer也不能因名字像新手就自动加入计算，当前核实的主线取权重路径按章节列选择。</p>'''+refs('C03','C04','C05','C06','C07'))
 parts.append('''<h2 id="evolution">5. 武器进化：从升星到配方，再到特殊选项</h2><div class="flow"><div><b>获得基础武器</b>普通候选选择后进入构筑</div><div><b>推进主线</b>NextSkill / CoverSkill推进升星与覆盖</div><div><b>普通改造分支</b>例如机炮2星挂104系分支</div><div><b>满足配方</b>指定武器节点 + 配套被动</div><div><b>解锁加权入口</b>候选权重5000，加入常规与Init池</div><div><b>抽到并选择</b>特殊节点进入后续专属选择</div></div><p>机炮示例：10000101 → 10000102 → 10000103；到3星节点10000103且已有暴击模块11000701，可解锁10500101。配方关系在武器与模块两侧都有记录，支持两种取得顺序，但每次检查仍以当时已有技能ID为准。</p><p>TryUnlockUpgradeSkills只向候选池加入口，没有直接授予进化。22个UpgradeSkillGroup入口的配置权重都是5000；实际机会仍受类别抽签、合法性与池内其他候选影响。10500101的IsUpgrade=1，选择后进入特殊技能队列，再经OpenSelectSpecialSkill处理9个配置深层子选项。</p><p><strong>_B必须单独读：</strong>TryUnlockUpgradeSkills在_B提前返回；机炮3星的IsUpgrade从基础2变为_B的1，UpgradeSkillId_B直接连接101系选项，最大星级从6变9。这证明它使用另一条特殊升级配置路径，不能把基础“武器+模块配方”强行套到_B，更不能据此称为老玩家福利。</p>'''+refs('C09','C10'))
 parts.append(table(['所需节点（配置ID）','解锁节点','候选权重','后续特殊子选项数'],[[' + '.join(f'{i} {n}' for i,n in zip(r['required_skill_ids'],r['required_names'])),str(r['result_skill_id'])+' '+r['result_name'],r['candidate_weight'],len(r['subchoice_ids'])] for r in read('evolution-recipes.json')]))
 parts.append('''<h2 id="treasure">6. 宝箱怪与中途商店：已排查到哪里</h2><p class="callout">本专题中的“宝箱怪”严格指你描述的“击杀怪物后掉落拾取物，拾取即可三选一”。目前没有足够证据给它绑定实体ID、掉落概率或出现波次。</p>''')
 parts.append(table(['已查线索','可确认结果','不能据此推出'],[
 ['EntityTreasure','玩家碰撞后CreateMonster创建怪物','不能证明是杀怪后掉三选一拾取物'],
 ['Box / BaseBoxState','传统GetBoxRandomSkills填写两个技能结果','不能当作用户描述的三选一'],
 ['DropItemScroll / Equip','收集路径登记掉落信息','尚未接上技能随机入口'],
 ['MainDropManager','特殊掉落CheckSpecialDrop的原生fallback返回false，普通路径继续AddDropItemFromGroup','空fallback不证明线上没有特殊掉落；可能被热更覆盖'],
 ['RandomSkill直接引用','命中初始化、升级、联机选择与刷新命令','未命中拾取直连不证明没有间接调用'],
 ['Punchboard','独立脚本事件和数量控制已确认','不能替代宝箱怪身份认定'],
 ['商店相关入口','补给站埋点来自UIDepotViewModule.OnOpen；购买埋点由Tracker.TrackShopBuy转发','无法证明中途商店的库存、币种、价格或刷新']]))
 parts.append('''<p>宝箱怪继续深查需要补上具体怪物ID→掉落ID→拾取处理→三选一状态的断边。最有价值的新材料是对应版本的热更方法体或能同时看到怪物、掉落物和界面的实机记录。中途商店当前停止扩大搜索，保持未确认；同事可以从已保存断点续查。</p>'''+refs('C12','C13'))
 parts.append('''<h2 id="data">7. 数据如何交接与复用</h2><p>报告是L3；专题目录是可移交的L2。先读facts和配方/权重JSON，再按证据路径核实。只有缺口要求新方法或新版本时，才回到L1反编译和L0 APK。</p><p><a href="downloads/xxyzd-in-run-handoff.zip">下载整体报告＋专题＋结构化数据</a> · <a href="research-data.html">整体研究数据</a></p>''')
 for p,label in [('README.md','专题数据说明'),('facts.json','规则与边界'),('chapters.json','71章配置映射'),('pool-weights.json','技能权重'),('evolution-recipes.json','22条配方'),('constants.json','原生常量'),('probability-examples.json','概率示例'),('questions.json','缺口与断点'),('sources.json','证据来源'),('manifest.json','哈希清单')]:parts.append(f'<p><a href="{base+p}">{label}</a></p>')
 parts.append('<pre>python3 research-data/tools/choice_topic.py validate\npython3 research-data/tools/choice_topic.py C05\npython3 research-data/tools/choice_topic.py skill:10000103</pre><h2 id="evidence">8. 规则与直接证据</h2>')
 for f in read('facts.json'):
  parts.append(f'<details id="{f["id"]}"><summary>{f["id"]} · {e(f["title"])} · '+('静态确认' if f['status']=='verified_static' else '未闭合')+'</summary><p>'+e(f['statement'])+'</p>')
  if f['parameters']:parts.append('<pre>'+e(json.dumps(f['parameters'],ensure_ascii=False,indent=2))+'</pre>')
  for s in f['limitations']:parts.append('<p>'+e(s)+'</p>')
  for p in f['evidence']:parts.append(f'<p><a href="{base+e(p)}">{e(p)}</a></p>')
  parts.append('</details>')
 parts.append('</article></main><a class="back" href="core.html">← 整体链路报告</a></body></html>')
 (ROOT/'docs/choices-box-evolution.html').write_text(''.join(parts))
if __name__=='__main__':
 arg=sys.argv[1] if len(sys.argv)>1 else 'validate'
 if arg=='manifest':manifest();print(json.dumps(validate(),ensure_ascii=False))
 elif arg=='validate':print(json.dumps(validate(),ensure_ascii=False))
 elif arg=='render':validate();render();print('Rendered canonical topic report')
 elif arg.startswith('skill:'):
  sid=int(arg[6:]);print(json.dumps([r for r in read('evolution-recipes.json') if sid in r['required_skill_ids']+[r['result_skill_id']]],ensure_ascii=False,indent=2))
 else:print(json.dumps([f for f in read('facts.json') if arg in json.dumps(f,ensure_ascii=False)],ensure_ascii=False,indent=2))
