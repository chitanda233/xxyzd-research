"""Evidence-backed mechanism detail for planner reports. Uses only reusable L2 data."""
from pathlib import Path
import collections,gzip,html,json
ROOT=Path(__file__).resolve().parents[2]
R=ROOT/'research-data'
BASE='https://github.com/chitanda233/xxyzd-research/blob/main/research-data/'
def h(x):return html.escape(str(x),quote=True)
def data(p):
 b=(R/p).read_bytes()
 return json.loads(gzip.decompress(b) if p.endswith('.gz') else b)
def table(headers,rows,caption=''):
 def cell(value, first):
  tag='th' if first else 'td'
  scope=' scope="row"' if first else ''
  kind='cell-prose' if len(str(value))>24 else 'cell-compact'
  return f'<{tag}{scope} class="{kind}">{h(value)}</{tag}>'
 wrap='table-wrap report-data-wrap'+(' is-long' if len(rows)>12 else '')
 return f'<div class="{wrap}" tabindex="0"><table class="report-data-table">'+('<caption>'+h(caption)+'</caption>' if caption else '')+'<thead><tr>'+''.join('<th scope="col">'+h(x)+'</th>' for x in headers)+'</tr></thead><tbody>'+''.join('<tr>'+''.join(cell(v,i==0) for i,v in enumerate(row))+'</tr>' for row in rows)+'</tbody></table></div>'
def source(*paths):
 for p in paths:
  assert (R/p).is_file(),p
 return '<p class="detail-source">数据依据：'+' · '.join('<a href="'+BASE+h(p)+'">'+h(p)+'</a>' for p in paths)+'</p>'
def block(title,paragraphs,headers=None,rows=None,refs=(),note=''):
 x=['<section class="section deep"><h3>'+h(title)+'</h3>']
 for p in paragraphs:x.append('<p>'+h(p)+'</p>')
 if rows:x.append(table(headers,rows))
 if note:x.append('<p class="scope-note">'+h(note)+'</p>')
 if refs:x.append(source(*refs))
 return ''.join(x)+'</section>'
def core():
 waves=data('in-run/datasets/chapter-1.json')['waves']
 m={x['id']:x['name'] for x in data('topics/monsters/catalog.json.gz')}
 rows=[]
 for w in waves:
  names='、'.join(f'{m.get(int(k),k)} ×{v}' for k,v in w['composition'].items())
  stage=('击杀门槛' if w['death_gate'] else '普通波末成长' if w['ordinary_growth_node'] else '终局')
  if any(e['kind']=='punchboard' for e in w['events']):stage='接触宝箱；'+stage
  rows.append([f"W{w['wave']}",f"{w['script_start_seconds']:g}秒",str(w['configured_monster_count']),names,str(w['experience_budget']),str(w['cumulative_experience']),stage])
 out=['<h2 id="mechanism-detail">完整规则与数据：第一章一局怎样执行</h2>']
 out.append(block('15波完整计划、成长和门槛',['逐波怪量按编队模板实际成员展开。以下是任务完整执行时的计划数量，关键目标提前死亡会截断后续刷新。第15波虽有经验预算，未配置普通波末选牌界面。'],['波','脚本起点','计划怪量','怪物构成','本波经验','累计经验','本波处理'],rows,['in-run/datasets/chapter-1.json','in-run/inputs/chapter-1-spawn-plans.json'],note='脚本秒数不包含暂停、选牌和等待击杀。'))
 out.append(block('单局状态衔接的判断顺序',['每波读取脚本任务，位置组、组合编队与随机路线可能在同一任务中并行；按任务和模板时点创建怪物。普通波结束先收场上经验掉落，经验动画结束后按待升级次数逐次展示候选，全部处理后才进入下一波。','第10波与第15波的推进条件是特殊目标死亡；目标死亡后可清除尚未执行的怪物计划。因此完整计划数和一次实战的实际生成、击杀数不同。第6、11、15波的宝箱是独立事件，拾取与批量成长完成后继续本波流程。终局先收束掉落再结算星级、奖励。'],refs=['in-run/facts.json','in-run/flow.json']))
 out.append(block('死亡、复活与评价逐步判断',['死亡后优先检查技能剩余复活次数；其后将满血复活概率、普通复活概率与同一个随机值比较，再查弹窗复活资格。这两种概率不是独立掷两次骰。','弹窗购买成功或广告成功走类型3复活：购买入口绑定商品601、内置价格50钻石；广告先增加广告计数，再进入类型3。该类型会消耗资格并增加评价使用的复活计数。技能和属性复活不沿这条计数路径。成功恢复后返回战斗，并尝试续接被打断的波末成长。','成功通关且启用星级收集时，第一章检查通关、已计入的复活次数不超过0、结果收集时生命百分比达到100。满血条件看结束时，不是全程无伤。'],refs=['in-run/facts.json','in-run/inputs/Chapter_MainChapter.json']))
 return ''.join(out)
def choices():
 ch=data('topics/chapter-planning/chapters.json');weights=data('topics/choices-box-evolution/pool-weights.json');recipes=data('topics/choices-box-evolution/evolution-recipes.json')
 out=['<h2 id="mechanism-detail">完整规则与数据：候选、宝箱、进化</h2>']
 out.append(block('普通三选一：从入口到落地的七步',['① 先检查本次是否有引导指定列表，有则直接使用并清空。② 否则根据本局初始池计数选起步池或常规池。③ 结合章节技能权重列、已学技能、武器和被动槽位、前置与互斥关系过滤。④ 每张候选独立做类别抽签，再按该类别内的有效权重取技能。⑤ 去重、补位；若整组三张没有武器类且池内仍有合法目标，尝试替换一张。⑥ 玩家选中后学习或覆盖，更新下一星、分支和配方候选。⑦ 存在待处理特殊节点时再进入武器专属选择。','本局初始池计数>0才使用10个武器入口；计数消费已确认，但“新账号必然怎样赋值”尚未闭合。常规池18个入口只是配置规模。基础武器与被动槽位各4个；B分支槽位及开放条件另有配置。'],refs=['topics/choices-box-evolution/facts.json','topics/choices-box-evolution/treasure-chain.json']))
 winit=[x for x in weights if x['pool']=='InitSurvivorGroup']
 out.append(block('起步池：10个武器的基础权重与章节权重',['以下列的是池内相对权重，不是出现概率。第1、2、3、4、6、8章分别采用技能权重组1—6；第11章起回到默认列。对同一个武器，章节可改变它在起步池的相对机会。'],['武器入口','默认','第1章','第2章','第3章','第4章','第6章','第8章'],[[x['name']+' '+str(x['skill_id']),x['weight']]+[x['chapter_group_weights'][str(i)] for i in [1,2,3,4,5,6]] for x in winit],['topics/choices-box-evolution/pool-weights.json','topics/chapter-planning/chapters.json']))
 out.append(block('概率计算：同一个权重在不同条件下为什么不同',['类别基础权重为被动200、武器300、特殊升级300。仅被动与武器有效时，单次类别抽取是200/500=40%与300/500=60%；三类都有效则为25%／37.5%／37.5%。这一步之后仍要在类别内抽具体技能、处理同屏去重及补位，因此不是最终每屏比例。','第2—10章且WorldType=1、未持有机炮入口时，机炮、冰刃弹、灼热射线的有效入口权重临时提高10%，抽后撤销。这是相对权重乘数，不是最终出现率增加10个百分点。刷新复用保存的类别索引；高阶属性走其他判断，不能随意并入类别权重。','某个技能的可复算最终概率必须给定本次的章节、B分支、已有技能与星级、槽位、初始池计数、引导覆盖、属性和当次合法池。缺任一状态，只能报告相对权重。'],refs=['topics/choices-box-evolution/facts.json','topics/choices-box-evolution/probability-examples.json']))
 chest=[]
 for c in ch:
  if c['hidden']:continue
  chest.append([f"第{c['chapter']}章",f"{c['waves']}波",'、'.join('W'+str(w) for w in c['variants']['base']['chest_waves']),c['variants']['base']['exp']])
 out.append('<details class="annex"><summary>展开：70章宝箱出现波次与成长预算</summary>'+table(['章节','长度','宝箱波次','整章经验预算'],chest)+source('topics/chapter-planning/chapters.json','topics/choices-box-evolution/treasure-schedule.json')+'</details>')
 out.append(block('接触宝箱：出现、拾取、数量档、内容池和到账',['宝箱出现由章节任务的missinType=9固定安排：70个可见主线章节基础分支合计208次，B分支另有208次。当前全部任务里没有RandomNpc=9，因而源码中的随机遗漏补偿分支在这套配置下不触发；不能给固定宝箱再套一个“掉落概率”。当前证据也没有把某个击杀怪物接到这条奖励箱链上。','章节事件先创建宝箱实体。飞机接触宝箱后累积拾取进度：配置0.2秒，离开时以10秒的回退参数处理；状态和缓存还会门控，因此0.2秒只是配置阈值。进入宝箱奖励状态后，先决定1、3或5项，再逐项生成词条，最后批量学习。','数量基础权重为60、0、30、0、10，故超过4个不同战斗技能组且无修正时分别为60%／30%／10%。组数不超过4时五项权重清零，剩余60:30重新归一化为66.67%给1项、33.33%给3项。五项概率加成先改变末档权重，之后还要过组数门槛；若原10权重翻倍为20且门槛已通过，五项概率是20/(60+30+20)=18.18%。','内容池先从当前构筑筛二星及以上的已有路线升级，保留权重、前置与技能限制。内部按容量16模拟候选，逐项更新后续升级与进化依赖；不够则从补位池补足，整理依赖连续性后得到最终1／3／5项。16是内部容量，不是奖励数。部分结果会升级或覆盖现有技能，不能当作净新增词条数。宝箱后若存在待处理的武器特殊节点，会继续进入该节点的专属选择。'],refs=['topics/choices-box-evolution/treasure-schedule.json','topics/choices-box-evolution/treasure-chain.json','topics/choices-box-evolution/mainline-chest-pool.json','topics/choices-box-evolution/facts.json']))
 out.append(block('进化配方：解锁和取得是两件事',['基础分支的配方把武器节点和指定模块关联。例如速射机炮到10000103且已有暴击模块11000701，系统将10500101以配置权重5000加入候选池。玩家仍需在后续合法抽取中取得该节点；若该节点为特殊升级，才打开后续武器专属选择。B分支在同一配方函数提前返回，使用另一条配置连接，不按账号新老解读。'],['所需武器节点＋模块','进入候选的进化节点','配置权重','后续专属选项数'],[[' + '.join(n+' '+str(i) for n,i in zip(r['required_names'],r['required_skill_ids'])),r['result_name']+' '+str(r['result_skill_id']),r['candidate_weight'],len(r['subchoice_ids'])] for r in recipes],['topics/choices-box-evolution/evolution-recipes.json']))
 return ''.join(out)
def chapter():
 ch=[x for x in data('topics/chapter-planning/chapters.json') if not x['hidden']];w=data('topics/chapter-planning/waves.json');diff=data('topics/chapter-planning/branch-differences.json')
 rows=[]
 for c in ch:
  b=c['variants']['base'];rows.append([f"第{c['chapter']}章",c['waves'],c['weight_group'] or '默认','有' if 3 in c['protect'] else '无',b['mission_count'],'、'.join(map(str,b['kill_waves'])) or '无','、'.join(map(str,b['chest_waves'])),b['random_rows'],b['exp'],f"{b['final_hp']:g}"])
 out=['<h2 id="mechanism-detail">完整规则与数据：章节怎样组装</h2>']
 out.append(block('章节配置的层级：一章不是一张表',['章节先选择关卡地图、波数、技能权重组、推荐方向、评价与奖励。波表再定义每波经验、生命／攻击倍率、进入与结束的界面事件、击杀锁；任务表具体定义某个脚本时点刷什么、从什么模板位置出现、是否走随机路线或生成宝箱。','一段投放的怪量来自任务内位置组、组合编队、随机路线及重复执行。地图模板记录位置和延迟，怪物实体记录本体属性、行为类和武器子弹。想修改体验时，应从对应层调整，而不是在“章数值”里寻找一个万能难度参数。'],refs=['topics/chapter-planning/facts.json','topics/monsters/facts.json']))
 out.append(block('全部70章：模板、成长、随机与门槛的对照',['技能组列记录当前主线选择的组号；“默认”指未使用1—6的章节组。击杀锁表示脚本推进需要关键目标死亡。随机任务行数只表示启用随机路线的任务规模，不等于怪物数量。生命倍率是终波波次值，不是最终怪物血量。'],['章节','波数','技能组','保护','任务行','击杀锁波','宝箱波','随机任务','总经验','终波生命倍率'],rows,['topics/chapter-planning/chapters.json','topics/chapter-planning/waves.json']))
 out.append(block('成长与随机分别在哪里变',['63章使用15波模板，逐波经验合计14,800；7个第5、15、25、35、45、55、65章使用10波模板，经验合计7,300。两种模板的经验序列在基础/B之间共用，宝箱通常是三次，但第10、60章各两次。','第1、2、3、4、6、8章分别取技能权重组1—6；第11章起落到默认权重。第6／8章常规池入口权重与默认相同，其起步池分别突出灼热射线／磁暴枪。第2—10章在特定构筑条件下启用对三个入口的临时权重保护，不能等同“新账号固定保底”。','投放随机只在配置候选与位置模板内发生。任务可同时走多种投放路线；随机位置参数weight参与坐标乘加，不能读作抽怪概率。'],refs=['topics/chapter-planning/facts.json','topics/choices-box-evolution/pool-weights.json']))
 representative=[(1,100115,'hpUpgrade'),(2,100215,'hpUpgrade'),(3,100306,'attackUp'),(3,100311,'attackUp'),(55,105504,'StopByEliteOrBossKilled'),(55,105507,'StopByEliteOrBossKilled'),(55,105505,'attackUp')]
 exceptions={(r['chapter'],r.get('base_id'),r['field']):r for r in diff if r['table']=='wave'}
 def display(v):return v['decimal'] if isinstance(v,dict) and 'decimal' in v else v
 out.append(block('基础/B到底改动了哪些任务和波次',['两套分支的经验和大多数任务顺序共用。对比时先排除任务ID前缀，逐任务字段对齐，才有意义。第1章终波生命倍率基础11、B为9；第2章终波20.5、B约18.792；第3章从W6起出现攻击倍率差异。第55章B另外在W4和W7设置击杀锁，而基础只在W10设击杀锁。','下表选取足以改变玩家推进或战斗压力的代表差异，完整变更表仍保存在中间数据。倍率显示配置十进制值；运行定点数还原值可能有末位误差。'],['章节','波','字段','基础','B'],[[key[0],f"W{key[1]%100}",key[2],display(exceptions[key]['base']),display(exceptions[key]['B'])] for key in representative],['topics/chapter-planning/branch-differences.json']))
 return ''.join(out)
def monsters():
 catalog=[x for x in data('topics/monsters/catalog.json.gz') if x['mainline']];ai=collections.defaultdict(list)
 for x in catalog:ai[x['base']['WaveAIId']].append(x)
 ailabel={'AIMoveInTwoPointsAndAttack':'两点往返＋周期射击','AIMoveInTwoPointsAndAttackNew':'两点往返变体','AIMoveToBottomAndAttack':'下行＋周期射击','AIMoveToBottomAndAttackNew':'下行变体','AICommonBoss':'首领动作组合','AIFixedBezierPath':'固定曲线路径','AIMoveDynamicRotateCenter':'绕中心变半径','AIMoveOnPathAttackLoopBorn':'沿路径移动并攻击','AIMoveOnPathLoopBorn':'路径入场后再运动','AIMoveReboundWall':'边界反弹','AIMoveFollowTarget':'追随目标','AIMoveUpDown':'上下运动与冲刺','200007':'距离判定后攻击','320013':'多红线预警攻击','340001':'随机反向移动'}
 out=['<h2 id="mechanism-detail">完整规则与数据：投放、行为、数值和弹幕</h2>']
 out.append(block('怪物从章节任务到实际进场的完整链路',['章与波给出当前任务集合。任务决定在什么时点执行固定位置、编队和随机路线；位置模板确定坐标、成员和延迟；实体表给本体生命、攻击、碰撞、行为和武器。战斗创建时合并章节、波次和任务倍率；AI再根据主线行为参数组合移动、射击、等待与离场任务。','固定模板、组合编队、随机怪可以同时出现在一条任务中。随机怪先抽候选组合，再按numberRandom目标数量截断，不按候选表大小当生成数。interval控制再次执行；首领战斗内召唤另计。以此顺序才能解释同一波为什么有多路怪、不同位置与延时。'],refs=['topics/monsters/facts.json','topics/monsters/occurrences.json.gz']))
 out.append(block('15种主线行为：各由什么条件推动',['行为类说明“如何运动或出招”，任务位置与路径资源决定起点。110种主线怪中59种的主线参数与常规参数不同，因此要使用主线行为配置。下表列出每类被脚本直接使用的怪物数量及例子；同一行为类内参数仍可能不同。'],['主线行为类','脚本怪种数','代表怪','运动／攻击规则'],[[k,len(v),'、'.join(x['name']+' '+str(x['id']) for x in v[:2]),ailabel.get(k,'按该行为类参数执行')] for k,v in sorted(ai.items())],['topics/monsters/catalog.json.gz','topics/monsters/facts.json']))
 ids=[330017,340001,340009,330023,320018,320007,340014,340002]
 rows=[]
 for id in ids:
  c=next(x for x in catalog if x['id']==id);b=c['base'];rows.append([c['name']+' '+str(id),c['first_chapter'],b['HP'],b['Attack'],b['MoveSpeed'],str(b['Shape']),b['WaveAIId'],'、'.join(str(z) for z in c['linked_bullet_ids'][:3])])
 out.append(block('八个代表怪物：本体数值、行动与弹幕入口',['本体生命和攻击还要乘章节、波次与有效任务倍率，不能直接当该章实战数值。Shape为基础形状参数，不可直接换算像素范围。关联子弹中可能包含条件触发的后续武器。'],['怪物','首章','本体HP','本体攻击','移速','基础形状','主线行为','关联子弹ID'],rows,['topics/monsters/catalog.json.gz','topics/monsters/links.json']))
 out.append(block('代表怪实际怎样产生危险',['黄眼虫选最近目标跟随，跟随速度倍率为1；飞机位置变化时它持续修正追击。机械屏障按主线参数绕中心顺时针运动，初始半径15，目标半径11，并带变化速度和等待参数。尖刺护盾组合上下运动与冲刺，配置冲刺速度52；“成对出现、锁定玩家”的图鉴文案要结合当波投放核对。黑胡子船长有随机反向移动任务，不是固定折返。','僵尸探子使用两点往返与周期射击，主线间隔2.3秒；武器70007发出的7007子弹带FollowMod转向参数35、表内速度13、寿命10秒。它对冰冻系伤害有60%抗性，对火焰伤害的承受增加30%。爆爆河豚的常规延迟9999并不表示每1.5秒正常开火；死亡完成后通过死亡武器70010发出散射。首领340014还可选择召唤330008的动作分支，战斗内额外怪物不在静态任务数量内。'],refs=['topics/monsters/catalog.json.gz','topics/monsters/facts.json']))
 out.append(block('数值与命中范围怎样合成',['名义生命＝实体本体HP × 章节生命倍率 × 波次生命倍率 × 有效任务生命倍率；任务倍率为0时跳过该项。名义攻击与接触攻击也接受章节、波次、任务攻击倍率。运行属性、状态和热更不包含在这个名义值。','单元素基础Shape创建圆；两元素创建盒。实体模型缩放、子弹表Scale、弹道修饰器与运行碰撞缩放各在不同层。设计危险区域需要同时对上子弹Type、Shape、偏移、轨迹、速度、寿命、重复伤害间隔与后续生成；仅凭模型画面大小或速度×寿命不能得到实机命中框。','图鉴能力描述与实际effects字段分别保存。主线110种MonsterTraitID都为空；这不妨碍它们通过行为、武器或能力效果形成特性。'],refs=['topics/monsters/facts.json','topics/monsters/bullets.json']))
 out.append(block('分布为什么重要',['前30章首次引入100种脚本怪，此后大多通过重新组合、任务倍率和阵型继续使用。黄眼虫首见第4章、累计进入14章；爆爆河豚首见第6章；机械屏障在第29、30、37、57、58、59章复用；带召唤分支的340014在第19、35、51、66章出现。','“某怪在章中存在”表示有相关脚本候选，随机组合、提前结束和动态分支决定实战是否见到。逐章和逐波的怪物名单、数量范围在查询页可逐项查看。'],refs=['topics/monsters/catalog.json.gz','topics/monsters/chapters.json']))
 return ''.join(out)
def skills():
 pools=data('in-run/datasets/skill-build.json')['pools'];weights=data('topics/choices-box-evolution/pool-weights.json');recipes=data('topics/choices-box-evolution/evolution-recipes.json')
 names={x['skill_id']:x['name'] for x in weights};group=collections.defaultdict(lambda:collections.Counter())
 for p in pools:
  for id in p['skill_ids']:
   if 10000000<=id<11000000:
    family=(id//100)%1000;group[family][p['id']]+=1
 out=['<h2 id="mechanism-detail">完整规则与数据：武器构筑怎样持续生成选择</h2>']
 controls=data('topics/choices-box-evolution/chapter-weapon-control.json')['records']
 control_rows=[]
 for c in controls:
  if c['hidden']:continue
  v=c['variants']['base']
  control_rows.append([c['chapter'],c['weight_column'],'是' if c['new_player_protect_3'] else '否',v['waves'],v['exp_budget'],v['ordinary_end_ui_flags'],'、'.join(map(str,v['chest_waves'])) or '无','、'.join(map(str,c['suggested_skill_ids'])) or '无'])
 out.append(block('70章的武器控制与成长窗口',['权重列与保护直接参与普通武器候选；推荐技能ID是独立字段，不能据此判定抽中或解锁。波末成长界面标记只是脚本机会，实际选牌次数可能因累计升级改变；宝箱波是固定任务配置。基础/B的章节权重组相同，表中成长预算列用基础分支。'],['章节','权重列','保护代码3','波数','经验预算','波末标记','宝箱波','推荐技能ID'],control_rows,['topics/choices-box-evolution/chapter-weapon-control.json']).replace('<section class="section deep">','<section id="chapter-matrix" class="section deep">',1))
 entry_rows=[]
 for pool in ['InitSurvivorGroup','SurvivorGroup']:
  for w in weights:
   if w['pool']!=pool:continue
   entry_rows.append(['起步10' if pool=='InitSurvivorGroup' else '常规18',w['name']+' '+str(w['skill_id']),w['weight']]+[w['chapter_group_weights'][str(i)] for i in range(1,7)])
 out.append(block('10武器起步池与18入口常规池的原始权重',['Weight_1—6实际分别用于第1、2、3、4、6、8章；其他可见章节读默认Weight。初始池没有酸性黑洞；常规池的增幅模块所有列为0。这里只列原始权重，尚未应用第2—10章条件保护、槽位与前置过滤。'],['池','入口','默认','第1章','第2章','第3章','第4章','第6章','第8章'],entry_rows,['topics/choices-box-evolution/pool-weights.json','topics/choices-box-evolution/chapter-weapon-control.json']))
 out.append(block('四个词条池及11条武器线的内容规模',['基础池18入口中有11把武器、7个模块配置入口，其中增幅模块普通随机权重为0；专属分支57条、后续升级111条、高阶进化22条。下表按技能ID中间家族码汇总配置行数；它是内容树深度，不是玩家本局能同时取得的条目数。'],['武器家族码','名称','基础入口','分支节点','后续升级','高阶节点'],[[f'{code:03d}',names.get(10000000+code*100+1,'按武器ID查询'),group[code]['SurvivorGroup'],group[code]['BranchSurvivorGroup'],group[code]['UpgradeSurvivorGroup'],group[code]['UpgradeSkillGroup']] for code in sorted(group)],['in-run/datasets/skill-build.json','topics/choices-box-evolution/pool-weights.json']))
 out.append(block('玩家拿到一张武器之后，系统怎样更新可学内容',['首次取得武器入口后，NextSkill连接下一星；CoverSkill用于覆盖旧阶段。达到相应节点后，104系武器分支加入相应候选；被动模块占自己的槽位，并可能满足105系进化配方。候选生成时还要检查PreSkillIds、NeedSkills、RejectSkills、技能标记及已有技能。','以机炮为例：10000101→10000102→10000103推进主线。达到10000103并已有暴击模块11000701后，10500101按配置权重5000进入候选；未抽到则仍未进化。获得IsUpgrade=1的节点后，再处理9个专属深层选项。B配置采用另一条特殊升级路径，不能直接套这个基础分支配方。'],refs=['in-run/datasets/skill-build.json','topics/choices-box-evolution/evolution-recipes.json']))
 bymod=collections.defaultdict(list)
 for r in recipes:bymod[r['required_names'][-1]].append(r['required_names'][0])
 out.append(block('模块的双重价值：立即属性＋未来配方',['通用模块不仅有当下属性增益，还可能进入多把武器的配方。以下按已核对的22条配方归纳；同名武器可能存在两个不同进化节点。最终取得概率还取决于章节权重、候选池和玩家状态。'],['模块','关联的武器配方条目','条目数'],[[k,'、'.join(v),len(v)] for k,v in sorted(bymod.items())],['topics/choices-box-evolution/evolution-recipes.json']))
 skill_rows={x['id']:x for x in data('topics/choices-box-evolution/inputs/Skill_Main.json')}
 first={r['result_skill_id']//100:r for r in recipes if r['result_skill_id']%100==1}
 second={r['result_skill_id']//100:r for r in recipes if r['result_skill_id']%100==2}
 evolution_rows=[]
 for family,r1 in first.items():
  r2=second[family];n2=skill_rows[r2['result_skill_id']]
  assert n2['NeedSkills']==[r1['result_skill_id']]
  evolution_rows.append([r1['result_name'],r1['required_names'][1],f"{r1['required_skill_ids'][0]}＋{r1['required_skill_ids'][1]} → {r1['result_skill_id']}",f"{r2['required_skill_ids'][0]}＋{r2['required_skill_ids'][1]} → {r2['result_skill_id']}",len(r1['subchoice_ids']),len(r2['subchoice_ids'])])
 out.append(block('11把武器的两档进化配方',['左列是第一档：武器3星＋模块1星；右列是第二档：武器6星＋模块2星，且第二档105系节点均以第一档105系节点为NeedSkills。箭头只表示解锁进化候选，非自动获得。最后两列是两档节点配置的专属选项ID数量，并非一次展示数量。'],['武器','共用模块','第一档门槛 → 候选','第二档门槛 → 候选','第一档子项','第二档子项'],evolution_rows,['topics/choices-box-evolution/evolution-recipes.json','topics/choices-box-evolution/inputs/Skill_Main.json']))
 module_rows=[]
 first_by_module=collections.defaultdict(list)
 for r in first.values():first_by_module[r['required_names'][1]].append(r['result_name'])
 for x in weights:
  if x['pool']=='SurvivorGroup' and x['skill_type']==2:
   module_rows.append([x['name']+' '+str(x['skill_id']),len(first_by_module[x['name']]),'、'.join(first_by_module[x['name']]) or '无105系配方'])
 out.append(block('基础模块的配方覆盖面',['同名模块的1星和2星分别参与对应武器的两档进化。增幅模块有基础入口，但在当前22条105系配方中没有关联；这只说明该配方集合，不代表模块无其他战斗价值。'],['模块入口','关联武器数','关联武器'],module_rows,['topics/choices-box-evolution/pool-weights.json','topics/choices-box-evolution/evolution-recipes.json']))
 out.append(block('一张牌的价值为什么会随关卡进度改变',['开局武器入口扩大攻击方式，已有武器升级集中投入。中段拿到模块，除了即刻面板收益，还可能把下一次进化放进候选池。终局前尚未完成配方时，即时输出与等待后续进化的机会成本不同。','基础武器／被动槽位各4个；B分支有另一套槽位与开放规则。已经满槽时新增路线和已有路线升级的合法性不同。初始池、常规池与分支／深层池层层推进，不等于208条池记录可以同时抽到。'],refs=['topics/choices-box-evolution/facts.json','in-run/datasets/skill-build.json']))
 return ''.join(out)
def aircraft():
 skin=data('planner/inputs/Role_Skin.json');star=data('planner/inputs/Role_SkinStar.json');skill={x['id']:x for x in data('planner/inputs/Skill_Main.json')};lang={x['id']:x['chinesesimplified'] for x in data('planner/inputs/Language_languagetable.json')};goods=data('planner/inputs/Shop_ShopGoods.json')
 out=['<h2 id="mechanism-detail">完整规则与数据：8架机体、五星能力与资源周期</h2>']
 out.append(block('形态与能力如何对应',['Role_Role记录母体，Role_Skin的8个形态分别配置品质、解锁资源、实体模型与关闭开关；Role_SkinStar每个形态给五星成本、属性增量和能力节点。基础成长与形态机制通过不同数据层组织。','下表按形态列出配置状态、品质与是否有逐星能力；配置关闭只表示当前静态开关，不说明所有线上渠道。'],['形态','配置ID','品质','关闭标记','逐星能力节点数','解锁所需'],[[lang.get(x['NameId'],x['NameId']),x['Id'],x['Quality'],x['IfClose'],sum(bool(r['FeatureOnStarUp']) for r in star if r['skinId']==x['Id']),str(x['UnlockCost'])] for x in skin],['planner/inputs/Role_Skin.json','planner/inputs/Role_SkinStar.json']))
 rows=[]
 for x in skin:
  for r in [z for z in star if z['skinId']==x['Id']]:
   ids=[]
   for v in r['FeatureOnStarUp']:
    t=json.loads(v)
    if t['Type']=='Skill':ids.append(int(t['Args']))
   description='；'.join(lang.get(skill[i]['LanguageInfoId'],str(i)) for i in ids if i in skill)
   rows.append([str(x['Id']),r['star'],str(r['StarCost']),str(r['AttrOnStarUp']),description or '无额外能力节点'])
 out.append(block('40个星级节点：消耗、属性与实际能力文案',['每架形态各5星。技能文案说明具体触发条件，但最终执行仍要看运行逻辑；因此以下是配置所描述的能力，不把它冒充已经逐帧实测的效果。'],['形态ID','星级','本次成本','属性记录','能力文案'],rows,['planner/inputs/Role_SkinStar.json','planner/inputs/Skill_Main.json','planner/inputs/Language_languagetable.json']))
 rg=[]
 for x in goods:
  if any(z[0] in range(10101,10109) for z in x.get('reward',[])):
   rg.append([x['id'],x['note'],str(x['price']),str(x['reward']),x['limit'],x['refresh'],x['Unlock'] or '无'])
 out.append(block('形态资源来自哪里、能换几次',['第一周签到第2天给守卫资源1份。飞鹰号公会商品要求公会等级7、公会币15,000、每周限购1；毒蝎、黑武士、幻影有对应活动兑换项。高品质形态多个兑换项的永久限购8与总份数8吻合，但不说明这些活动同时开放。','解锁用同名资源1份，后续星级成本按可消费节点累加为1+1+2+3份，总共8份。满星行成本空数组，不应再加一次。以下列的是已核对的形态资源商品；refresh与limit仍需按各商品语义解释。'],['商品ID','配置说明','价格项','获得资源','限购','刷新字段','解锁条件'],rg,['planner/inputs/Shop_ShopGoods.json','planner/inputs/SignIn_SignIn.json','planner/inputs/Role_SkinStar.json']))
 return ''.join(out)
def systems():
 shop=data('planner/inputs/Shop_Shop.json');loot=data('planner/inputs/Shop_LootBox.json');arena=data('planner/inputs/CrossArena_CrossArenaSeason.json')[0];guild=data('planner/inputs/Guild_guildcontribute.json');cal=data('planner/inputs/Calendar_CalendarFig.json')
 out=['<h2 id="mechanism-detail">完整规则与数据：局外资源如何流转</h2>']
 out.append(block('从战斗到下一次战斗的可查连接',['结束奖励、首通、累计星级分别有配置入口。局外永久能力包含武器升星、收藏与形态成长；资源通过战斗、抽取、兑换、活动和长期玩法获取。这里先陈列实际配置能证明的流向，属性总合成与服务端发奖细节仍需专门闭合。'],refs=['in-run/facts.json','planner/inputs/AirplaneGun_Star.json','planner/inputs/Collection_TreasureStar.json']))
 out.append(block('兑换和抽取：具体商品怎样限制频率',['Shop_Shop定义商店用途、商品集合与刷新；Shop_ShopGoods定义实际价格、奖励、限购和解锁条件。金币兑换是钻石转金币，体力商店的note明确递增购买；具体阶梯应从关联商品逐项核对。局外LootBox则另有钥匙、免费冷却、单／十次成本和每日限制，不能与局内接触宝箱混作一个池。'],['商店ID','配置用途','商品ID','刷新字段','限购字段'],[[x['id'],x['note'],','.join(map(str,x['goods'][:8])),x['refresh'],x['limit']] for x in shop[:12]],['planner/inputs/Shop_Shop.json','planner/inputs/Shop_ShopGoods.json']))
 out.append(block('七种局外抽取箱的配置边界',['以下仅列入口参数；FreeCD的业务时间单位、线上免费资格和服务端掉落还要按对应实现核对。'],['箱ID','钥匙ID','免费间隔字段','单抽成本字段','十抽成本字段','日限制'],[[x['ID'],x['Key_ID'],x['FreeCD'],str(x['Single']),x['Ten'],x['DayLimit']] for x in loot],['planner/inputs/Shop_LootBox.json']))
 out.append(block('竞技、公会和活动：时间与参与条件',['一条跨区竞技赛季配置Days=7、开放时间00:00—23:50；独立票券ID '+str(arena['TicketId'])+'，每日恢复'+str(arena['TicketDailyRecover'])+'张，并关联任务和专属商店。公会贡献表按Times给成本与回报记录。活动日历描述中明确出现“开服+N天”的开启条件，但单凭客户端表不能确定当前赛季和活动是否上线。'],['系统','关键配置','具体用途'],[['跨区竞技',f"周期{arena['Days']}天；{arena['OpenTime']}—{arena['CloseTime']}；每日恢复{arena['TicketDailyRecover']}张票",'控制赛季与每日参与'],['公会贡献',f'{len(guild)}条次数配置；首条产出{guild[0]["guildItems"]}','把贡献行为连接公会资源'],['活动日历','；'.join(x['Desc'] for x in cal),'用开服进度和目标组织活动']],['planner/inputs/CrossArena_CrossArenaSeason.json','planner/inputs/Guild_guildcontribute.json','planner/inputs/Calendar_CalendarFig.json']))
 return ''.join(out)
RENDERERS={'core':core,'choices-box-evolution':choices,'chapter-planning':chapter,'monsters':monsters,'skills':skills,'aircraft':aircraft,'systems':systems}
def render(slug):return '<div class="mechanism-detail">'+RENDERERS[slug]()+'</div>'
