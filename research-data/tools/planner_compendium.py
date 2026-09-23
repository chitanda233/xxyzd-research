"""Long-form planner walkthroughs generated from the reusable L2 research records.

The prose explains decision order and worked examples; full catalogues remain in lookup tools.
"""
from pathlib import Path
from collections import Counter,defaultdict
import gzip,html,json

ROOT=Path(__file__).resolve().parents[2]
DATA=ROOT/'research-data'
BASE='https://github.com/chitanda233/xxyzd-research/blob/main/research-data/'

def read(path):
    with (gzip.open(DATA/path,'rt') if path.endswith('.gz') else (DATA/path).open()) as f:
        return json.load(f)
def e(value):return html.escape(str(value),quote=True)
def links(*paths):
    for p in paths:assert (DATA/p).is_file(),p
    return '<p class="evidence-line">可复核数据：'+' · '.join(f'<a href="{BASE}{e(p)}">{e(p)}</a>' for p in paths)+'</p>'
def table(head,rows):
    assert all(len(r)==len(head) for r in rows)
    def cell(value, first):
        tag='th' if first else 'td'
        scope=' scope="row"' if first else ''
        kind='cell-prose' if len(str(value))>24 else 'cell-compact'
        return f'<{tag}{scope} class="{kind}">{e(value)}</{tag}>'
    wrap='table-wrap report-data-wrap'+(' is-long' if len(rows)>12 else '')
    return f'<div class="{wrap}" tabindex="0"><table class="report-data-table"><thead><tr>'+''.join(f'<th scope="col">{e(x)}</th>' for x in head)+'</tr></thead><tbody>'+''.join('<tr>'+''.join(cell(v,j==0) for j,v in enumerate(row))+'</tr>' for row in rows)+'</tbody></table></div>'
def section(title,paragraphs=(),head=None,rows=(),refs=()):
    result=['<section class="section compendium"><h2>'+e(title)+'</h2>']
    result.extend('<p>'+e(p)+'</p>' for p in paragraphs)
    if head and rows:result.append(table(head,rows))
    if refs:result.append(links(*refs))
    return ''.join(result)+'</section>'
def note(title,body):return '<aside class="worked-example"><strong>'+e(title)+'</strong><p>'+e(body)+'</p></aside>'
def details(title,content):return '<details class="annex compendium-annex"><summary>'+e(title)+'</summary>'+content+'</details>'
def process(steps):return '<ol class="mechanism-map">'+''.join('<li><b>'+e(a)+'</b><span>'+e(b)+'</span></li>' for a,b in steps)+'</ol>'
def fact_index(slug):
    root={'core':'in-run','choices-box-evolution':'topics/choices-box-evolution','chapter-planning':'topics/chapter-planning','monsters':'topics/monsters'}.get(slug)
    if not root:return ''
    facts=read(root+'/facts.json');rows=[]
    for f in facts:
        claim=f.get('statement',f.get('claim',''))
        limit='；'.join(f.get('limitations',[]))
        evidence=f.get('source_ids',f.get('evidence',[]))
        evidence_text='；'.join(map(str,evidence[:3]))+(f'；另{len(evidence)-3}项' if len(evidence)>3 else '')
        rows.append([f['id'],f.get('title',f.get('area','')),claim,limit or f.get('derived','见所引证据'),evidence_text])
    return details('逐条规则索引：结论、适用边界与底层来源',table(['规则编号','主题','已确认的结论','边界／推导','主要来源'],rows)+links(root+'/facts.json',root+'/sources.json' if (DATA/root/'sources.json').exists() else root+'/README.md'))

def core():
    waves=read('in-run/datasets/chapter-1.json')['waves']
    plans={x['mission']:x for x in read('in-run/inputs/chapter-1-spawn-plans.json')}
    first=plans[1001001]
    routes=first['routes'];group=next(x for x in routes if x['route']=='group')
    template_rows=[]
    for item in group['options'][0]['items']:
        if item['total'][0]>1:
            template_rows.append([item['config'],item['options'][0]['template'],item['delay'],item['total'][0],', '.join(f'{k}×{v[0]}' for k,v in item['counts'].items())])
    out=['<div class="compendium-intro"><h2>从玩家的一局回推到配置执行</h2><p>本专题固定第一章、基础分支、客户端 1.0.16。先沿玩家会看到的成长与强敌节奏，再回到波、任务、投放模板和结算。计划刷新、实际出现、实际击杀分别计数。</p></div>',process([('章节','选15波与任务前缀'),('波内','按脚本时点投放'),('成长','经验与普通选牌'),('宝箱','接触后批量补强'),('目标锁','等待精英/首领死亡'),('结算','复活、星级与奖励')])]
    out.append(section('1 · 一局不是一根不断走的秒表',['进入关卡后，章节选择地图和15波波表；每波读取若干脚本任务。任务的时间是战斗脚本坐标，不是玩家手表时间。遇到选牌、接触宝箱、复活和“必须击杀目标”的波，实际推进会被状态与条件暂停。','对策划最重要的结构是：配置先固定节奏坐标，局内状态机再决定何时放行。把“W10脚本起点”直接画成玩家第几分钟，或把任务计划刷新数直接写成玩家击杀数，都会错。'],['环节','进入条件','系统动作','玩家可感知结果'],[
        ['进入章节','选择第一章基础分支','载入地图、章节、波表、任务前缀','看到初始场景和机体'],
        ['波内投放','脚本任务时间到、没有状态门控','按固定位置／编队／随机路线和重复设置刷新','战场密度与空间压力变化'],
        ['普通波末','W1—W14波配置结束UI','吸收遗漏经验，逐次清理待升级次数','可能连续出现多次三选一'],
        ['接触宝箱','W6／W11／W15任务生成宝箱且机体完成接触','进入宝箱奖励状态，生成1／3／5项并批量学习','一次性构筑补强'],
        ['强目标波','W10或W15有目标未死亡','等待目标计数归零，随后推进','关键怪成为阶段考核'],
        ['死亡处理','生命耗尽','按技能、属性概率、弹窗资格顺序尝试复活','可返回战斗或结束'],
        ['终局','终波条件满足或失败判定','收束掉落、星级、奖励入口','带着资源和评价离开局内']
    ],['in-run/flow.json','in-run/facts.json']))
    out.append(section('2 · 第一波怎样从一条任务变成28只怪',['W1只有任务1001001，任务从0秒开始；其中的位置组会依次执行多个模板成员。20个位置/成员记录不能当20只怪，因为两个编队模板分别包含5个实体。实际展开为26只绿影鸟和2只僵尸游兵，共28只。','任务内的delay仍要叠加到脚本时间；同一行配置中存在0、0.2、0.4秒等错峰以及4.8秒、7秒的五成员编队。这个设计让同一波在空间和时间上渐次加压，而不是一帧生成28只。'],['配置行','位置模板','任务内延迟（秒）','模板实际成员','展开后实体'],template_rows,['in-run/inputs/chapter-1-spawn-plans.json','topics/monsters/occurrences.json.gz']))
    out.append(note('W1名义生命算例','任务1001001的生命倍率为0.8，章节和波次生命倍率均为1。绿影鸟本体HP=150，名义值150×1×1×0.8=120；僵尸游兵本体HP=800，名义值800×1×1×0.8=640。运行态属性与临时状态仍可能改变最终实战值。'))
    out.append(section('3 · 成长预算与三次集中补强',['15波经验依次为'+ '、'.join(str(w['experience_budget']) for w in waves)+'，累计14,800；每一波的累计值对应前15级阈值。经验预算按波设置，不能把单只怪物的静态经验相加来替代。','W1—W14均配置普通波末成长UI，且一次波末可因待升级次数出现连续选择；W15没有普通波末选牌UI。W6在脚本105秒、W11在240秒、W15在345秒出现接触宝箱。W15另有347秒的首领任务；宝箱和首领同处终波，但先后次序由任务坐标决定。'],['观察点','脚本安排','对构筑节奏的作用'],[
        ['W1—W4',f"累计{waves[3]['cumulative_experience']}经验，4个普通成长节点",'建立第一把武器与早期升级方向'],
        ['W5',f"累计{waves[4]['cumulative_experience']}经验，非击杀锁",'软压力峰；通过后还能进入W6补强'],
        ['W6',f"脚本起点{waves[5]['script_start_seconds']:g}秒，宝箱事件105秒",'集中给词条，改变中段构筑'],
        ['W10',f"累计{waves[9]['cumulative_experience']}经验，击杀锁，计划上限{waves[9]['configured_monster_count']}只",'以关键目标死亡检验输出，早杀可截断计划'],
        ['W11',f"脚本240秒的宝箱，累计{waves[10]['cumulative_experience']}经验",'在终局前提供第二次集中补强'],
        ['W15','345秒宝箱，347秒首领任务；无普通波末选牌','终局检验与最后一次批量补强相邻']
    ],['in-run/datasets/chapter-1.json','in-run/facts.json']))
    out.append(section('4 · 强目标门槛改变的是“放行条件”',['W5是压力峰，但没有StopByEliteOrBossKilled击杀锁；W10和W15有。锁住时系统等待精英／首领目标死亡。目标计数清零后，尚未执行的刷新计划可能被取消。','因此W10的21只和W15的1只是静态完整计划上限，不是每局必出量。比较两次实战难度时，需要同时记录实际出现数、目标存活时长、玩家构筑和脚本推进，而不是只拿配置计划怪量做比率。'],['判定对象','配置计划数','完成条件','不能推导'],[['W5',waves[4]['configured_monster_count'],'普通波推进','“必须杀完W5所有怪”'],['W10',waves[9]['configured_monster_count'],'特殊目标死亡','一定出现并击杀21只'],['W15',waves[14]['configured_monster_count'],'首领目标死亡','终波耗时固定']],['in-run/datasets/chapter-1.json','in-run/inputs/ChapterWave_Waves.json']))
    out.append(section('5 · 死亡后系统逐项检查什么',['第一优先级是技能提供的剩余复活次数。没有时，对满血复活概率与普通复活概率使用同一个随机值作比较；这不是两次独立掷骰。前面都未命中，才检查弹窗复活资格。','弹窗购买入口指向商品601、内置50钻石；广告入口先记广告次数，再走类型3复活。只有这类复活会消耗弹窗资格并增加当前星级评价使用的复活计数。技能和属性概率复活不沿该计数分支。成功后回到战斗并尝试续接被打断的波末升级。'],['检查顺序','条件','结果','评价计数'],[
        ['1 技能','技能剩余次数>0','按技能路径复活','不经类型3加计数'],
        ['2 属性','同一随机值进入满血或普通复活条件','按属性路径复活','不经类型3加计数'],
        ['3 弹窗资格','仍有可用资格','购买／广告／关闭','购买或广告成功走类型3并计数'],
        ['4 无复活','以上均未成功','结束战斗','失败结算']
    ],['in-run/facts.json','in-run/flow.json']))
    out.append(section('6 · 通关评价看的是终局状态',['成功通关且星级收集启用时，第一章三个检查分别是通关、被计入的复活次数不超过0、结果收集时生命百分比达到100。最后一项是“结束时满血”，不能误写成“整局无伤”。','这种设置把同一关分成“过关”和“高质量过关”：可以借助复活先打通，再追求不使用类型3复活和满血结束。但如果另一路技能/概率复活没有进入评价计数，便不能把星级条件概括成“任何复活都丢星”。'],['评价条件','检查的状态','典型误读'],[['通关','结束路径成功','活到末波就算通关'],['复活','用于评价的已用复活计数≤0','任何类型的复活都一样'],['生命','结算收集时生命百分比=100','中途受伤即失败']],['in-run/facts.json','in-run/inputs/Chapter_MainChapter.json']))
    out.append(section('7 · 用这套链路写自己的关卡时，应该分别调什么',['波数与经验序列控制构筑成熟度；怪物与任务模板控制空间密度；关键目标锁控制停留时间；宝箱安排控制集中补强；评价条件负责重玩目标。这些旋钮在该项目里分处不同配置和运行分支。','例如想把W10改成“输出检验但不拖时”，先看目标血量与击杀锁，再看任务是否在目标死亡后截断；仅删掉几只计划杂兵，不一定缩短实际停留时间。想提高W6补强强度，应检查宝箱内容池和当前构筑，而不是只把宝箱生成时间提前。'],refs=['in-run/datasets/chapter-1.json','in-run/facts.json','in-run/flow.json']))
    return ''.join(out)+fact_index('core')

def choices():
    chapters=read('topics/chapter-planning/chapters.json')
    chest=read('topics/choices-box-evolution/mainline-chest-pool.json')
    chain=read('topics/choices-box-evolution/treasure-chain.json')
    weights=read('topics/choices-box-evolution/pool-weights.json')
    recipes=read('topics/choices-box-evolution/evolution-recipes.json')
    schedule=[]
    for n in [1,5,10,35,55,60,70]:
        c=next(x for x in chapters if x['chapter']==n)
        schedule.append([f'第{n}章',c['waves'],'／'.join('W'+str(w) for w in c['variants']['base']['chest_waves']),', '.join(f'{k}: {v}行' for k,v in c['variants']['base']['random_npc_values'].items())])
    cweight=[x for x in weights if x['pool']=='InitSurvivorGroup']
    sample=[x for x in cweight if x['skill_id'] in [10000101,10000401,10000601,10001701]]
    sample_rows=[[x['name'],x['weight']]+[x['chapter_group_weights'][str(i)] for i in [1,2,3,4,5,6]] for x in sample]
    out=['<div class="compendium-intro"><h2>先把三种“选择”拆开</h2><p>普通波末的三选一、接触宝箱的1／3／5项批量奖励、突破后的武器专属选择，入口、候选池和结算方式不同。先分清是哪一种，再谈概率与词条来源。</p></div>',process([('普通升级','筛合法池'),('三选一','逐张抽、玩家选一'),('接触宝箱','定项数、逐项抽、批量学'),('进化','配方入池、抽到后专属选')])]
    out.append(section('1 · 三种入口如何接力',['普通升级来自经验与待升级次数：每次生成三张可选牌，玩家只取得一张。接触宝箱来自章节missinType=9任务：飞机拾取后，系统生成1、3或5项结果并批量学习。突破后的专属选择则由特殊升级节点排队，在前一状态退出后进入。','同一时段可能连续经过普通选牌、宝箱、专属选择，玩家会感到“接连选很多次”。但策划计算时必须逐个入口核对：普通三选一的展示率不能用宝箱的1／3／5项权重计算，宝箱也不是先展示三张再让玩家只拿一张。'],['入口','何时触发','玩家动作','结算数量'],[['普通波末','待升级次数>0','三张候选选一张','一次学习一张，可连续触发多次'],['接触宝箱','章节任务生成，接触进度完成','拾取并进入批量奖励状态','一次生成1／3／5项，逐项处理'],['武器专属','已获得IsUpgrade特殊节点并有待处理列表','在后续状态选择专属方向','按该武器的分支候选处理']],['topics/choices-box-evolution/facts.json','topics/choices-box-evolution/treasure-chain.json']))
    out.append(section('2 · 普通三选一的实际筛选顺序',['引导覆盖列表存在时直接使用并清空，不进入普通随机。否则先看Init计数：仍大于0时，从10个起步武器入口中工作并消费计数；不满足才进入常规池。','进入普通随机后，系统检查类别是否仍有合法候选，再按类别权重抽一张；在该类别内部按技能权重取具体节点。前置依赖、已持有技能、星级、武器／被动槽位、互斥技能及同屏去重都会缩小有效池。抽满三张后若整组没有武器且还存在合法武器，系统尝试替换一张；因此三张最终展示结果不是三个独立同分布的单张试验。','玩家选中后旧节点可被覆盖，新节点、后继升级与进化依赖随之更新。下一次随机面对的是一个已改变的构筑状态，不能拿本次的单张概率一直乘到整局。'],['步骤','先回答的问题','会怎样改变概率口径'],[['覆盖','引导是否指定结果','指定时没有随机三选一'],['起步池','Init计数是否还大于0','10个武器入口与常规池不是同一集合'],['合法性','槽位、前置、互斥与已学技能如何','类别和技能的有效权重总和变化'],['逐张抽取','抽到哪一类、该类哪一项','条件概率随前三张结果改变'],['整组纠偏','三张有没有武器','最终同屏组成不等于原始抽签'],['落地更新','玩家最终选了哪张','后继池与配方门槛改变']],['topics/choices-box-evolution/facts.json','in-run/datasets/skill-build.json']))
    out.append(section('3 · “权重”和“最后出现率”隔着两层',['基础类别权重为被动200、武器300、特殊升级300。若三类都合法，单张的第一层类别份额分别是25%、37.5%、37.5%；若只有被动和武器合法，份额是40%和60%。这是第一层条件概率，不是屏幕上三张牌的最终比例。','第二层还要看该类别里每个合法节点的权重。例如某次只有两件合法武器，权重分别为100和300，则“本张先抽中武器且再抽中前者”的条件概率是0.6×100/(100+300)=15%。只要槽位、已学节点、去重或后续覆盖改变候选集合，15%就不再适用。','第2—10章保护码3、WorldType=1且尚未持有机炮入口时，机炮、冰刃弹、灼热射线的入口权重临时乘1.1，抽后恢复。乘1.1是相对权重变化，不是出现率直接加10个百分点。第1章没有这个保护码；代码没有在这个分支按注册时长判断新老账号。'],['已合法类别','第一层总权重','被动','武器','特殊'],[['被动＋武器',500,'40%','60%','不可用'],['三类均可用',800,'25%','37.5%','37.5%']],['topics/choices-box-evolution/probability-examples.json','topics/choices-box-evolution/facts.json']))
    out.append(note('一把武器的真实屏幕概率为什么不能直接给','若只知道“机炮起步池权重”却不知道起步池剩余合法武器、当前章节权重列、是否引导覆盖和同屏去重，就只能算相对权重。给固定的“机炮有X%”会把多层条件概率压成一个错误数字。'))
    out.append(section('4 · 开局倾向按章节改哪一列',['第1、2、3、4、6、8章依次使用技能权重组1—6。其余章节若没有对应组，采用默认列。这里展示四把武器的默认与章节列，完整10个入口在后文数据表。','第6章与第8章常规池入口仍与默认一致，起步池却分别把灼热射线和磁暴枪抬高。由此可以判断：差异重点放在第一次给玩家定方向，而不是承诺整局都偏向那把武器。'],['武器','默认','第1章','第2章','第3章','第4章','第6章','第8章'],sample_rows,['topics/choices-box-evolution/pool-weights.json','topics/chapter-planning/chapters.json']))
    out.append(section('5 · 主线宝箱的出现是脚本表，不是怪物掉落率',['70个可见主线章节每分支合计208个missinType=9事件。15波章通常安排W6／W11／W15，10波章通常安排W4／W7／W10；第10章只在W11／W15，第60章只在W6／W15。出现点由章节任务固定，表中没有可写成“每次击杀X%掉箱”的投放概率。','源码还有RandomNpc=9时按35×计数比较的遗漏补偿分支，但本版20,912条任务的RandomNpc只有0和1，没有9。它是代码存在而当前配置未启用的分支，不能把35误写为当期主线宝箱概率。当前已闭合主线链路不以某只怪死亡为必要前置；普通死亡掉落另有链，仍不足以指定一只“宝箱怪”。'],['章节例子','波数','脚本宝箱波','该章RandomNpc配置值'],schedule,['topics/choices-box-evolution/treasure-schedule.json','topics/choices-box-evolution/mainline-chest-pool.json','topics/choices-box-evolution/treasure-chain.json']))
    out.append(section('6 · 从宝箱脚本到奖励到账，逐步经过哪些门',['missinType=9任务到时，刷新逻辑调入宝箱创建链；创建entity 8、npcType 8、模型Battle_Treasure_Chest_1。主线WorldType=1使用固定位置规则，不因配置中有PathId=7就宣称宝箱沿路径移动。','机体接触后，AIPunchboard按帧累积进度，配置倒计时0.2秒；完成判断为进度>1，并经过碰撞缓存与状态门控。触发后进入宝箱奖励状态，确定奖励数量，构建和展示结果；结果经命令批量应用，退出时若还有武器特殊选择便接续该状态。0.2秒是配置阈值，不是每台设备必定精确0.200秒。'],['链路节点','确认的动作','来源定位'],[[x['step'],x['label']+'：'+x['behavior'],'；'.join(x['evidence'][:2])] for x in chain['chain']],['topics/choices-box-evolution/treasure-chain.json']))
    out.append(section('7 · 宝箱为什么可能给1、3或5项',['基础档位权重为[60,0,30,0,10]，分别对应1到5项，因此满足五项门槛且无属性修正时，1项60%、3项30%、5项10%，基础期望数量1×0.6+3×0.3+5×0.1=2。','已持有的不同战斗技能组数≤4时，系统将五项权重清零，剩余60:30归一化为1项2/3、3项1/3，期望数约1.667。FiveSkillRate%只修改最后一档，之后仍受组数门槛限制。若它使10变20且组数已超过4，五项为20/(60+30+20)=18.18%；同一修正在组数≤4时仍不会开放五项。'],['构筑状态','有效权重（1／3／5项）','结果概率','期望项数'],[['不同组≤4，无修正','60／30／0','66.67%／33.33%／0','1.667'],['不同组>4，无修正','60／30／10','60%／30%／10%','2.000'],['不同组>4，五项权重翻倍','60／30／20','54.55%／27.27%／18.18%','2.273']],['topics/choices-box-evolution/mainline-chest-pool.json','topics/choices-box-evolution/facts.json']))
    out.append(section('8 · 内容池围绕“当前构筑可升级什么”建立',['宝箱不是从全技能表均匀抓1／3／5项。它先看当前已学路线：SkillStar<2的入口不进已学升级候选；符合条件的二星及以上路线携带原权重、前置和技能限制进入候选。内部容量16只控制建池，不等于发16个奖励。','随后逐项抽取。每抽到一个节点，都可能移除旧候选、加入后继升级或满足新的进化配方，因而第2项面对的池可能与第1项不同。池不足时走补位候选，最后整理连续升级关系并打乱展示。取得高星节点可能覆盖旧技能，所以“拿到5项”也不是净增加5个装备槽。','例如一个构筑刚拿到机炮一星，但仍缺少二星升级前置，宝箱已学路线池不能简单把它当成“已有可升路线”。当机炮升到满足节点，宝箱内才可能出现对应后续升级；如果同一批结果又满足配方，后续项合法池还会再变。'],['建池阶段','关键过滤或变动','设计后果'],[['已学路线','SkillStar≥2、合法权重和前置','早期新武器不自动填满宝箱升级池'],['内部构建','最多16候选容量','容量不是奖励数'],['逐项抽取','更新后继、依赖与进化配方','同箱多项存在顺序依赖'],['不足补位','从补位池找合法节点','奖项数与已学路线数不必相等'],['结果应用','连续性整理、批量学习或覆盖','净新增数不等于结果项数']],['topics/choices-box-evolution/mainline-chest-pool.json','topics/choices-box-evolution/facts.json']))
    out.append(section('9 · 进化先解锁候选，再等待玩家取得',['基础分支中，速射机炮达到10000103且已有暴击模块11000701，会把10500101以权重5000加入可抽候选。此时它只是合法候选，不表示本次三选一必中、不表示宝箱必给。取得该特殊节点后，才会继续处理机炮的9个专属选项。','22条配方是武器节点和模块的连接；B分支在基础配方函数提前返回，走另一路配置。这里的“基础/B”是章节和构筑配置分支，不等于账号新手/老手。','设计上这是一个延迟回报：先拿模块获得即时收益，未来满足武器节点后扩充高阶池，最后还需经历抽取与选择。想复刻这种结构，要分别配合法性、权重与玩家可见提示，避免把依赖门槛写成必得承诺。'],['状态','机炮案例','是否已获得进化'],[['缺10000103','只有机炮早期节点和模块','否'],['已有10000103和11000701','10500101进入候选，权重5000','否'],['后续抽中并选择10500101','进入特殊升级节点','是'],['特殊节点结算后','打开机炮专属分支','进化后的再选择']],['topics/choices-box-evolution/evolution-recipes.json','topics/choices-box-evolution/facts.json']))
    out.append(section('10 · 用于策划研究的概率记录格式',['每次讨论“某技能出现概率”至少同时记录章节与分支、WorldType、当前池是Init还是常规、已学技能与星级、武器／被动槽位、引导覆盖、属性修正、候选合法性和是否刷新。没有状态快照，就只报告配置相对权重。','研究主线宝箱则要分开记录：脚本是否生成、机体是否拾取、1／3／5项数量档、每项内容池、最终批量学习结果。这样能发现“没见到五项”究竟因为没过组数门槛，还是权重未命中，而不会误改章节出现率。'],refs=['topics/choices-box-evolution/facts.json','topics/choices-box-evolution/mainline-chest-pool.json']))
    return ''.join(out)+fact_index('choices-box-evolution')

def chapter():
    chapters=[x for x in read('topics/chapter-planning/chapters.json') if not x['hidden']]
    waves=read('topics/chapter-planning/waves.json')
    monsterwaves=read('topics/monsters/waves.json')
    picks=[1,5,10,19,35,55,70]
    bychapter={x['chapter']:x for x in chapters}
    profile=[]
    for n in picks:
        c=bychapter[n];b=c['variants']['base'];mw=[x for x in monsterwaves if x['chapter']==n and x['branch']=='base']
        profile.append([f'第{n}章',c['waves'],b['mission_count'],sum(x['total'][0] for x in mw),len(set(k for x in mw for k in x['counts'])),b['random_rows'],'／'.join(map(str,b['chest_waves'])),'／'.join(map(str,b['kill_waves'])) or '无',f"{b['final_hp']:g}×",f"{b['final_attack']:g}×"])
    w1=[x for x in waves if x['chapter']==1 and x['branch']=='base']
    w55=[x for x in waves if x['chapter']==55 and x['branch']=='base']
    curve=[[f'W{x["wave"]}',x['start_seconds'],x['exp'],x['hp'],x['attack'],x['kill_gate'],'是' if x['chest_events'] else '否'] for x in w1]
    out=['<div class="compendium-intro"><h2>把70章看成一套生产方法，而不只是70行数值</h2><p>先确定章节模板和固定成长节点，再排波、投放任务、怪物/编队、数值倍率与分支差异。下面的案例让“章节规划”落到可编辑的对象与实际玩家压力。</p></div>',process([('章节模板','地图、波数、成长'),('波','倍率、门槛、宝箱'),('任务','时点与刷新路线'),('阵型','位置、成员、延迟'),('敌人','本体、AI、武器')])]
    out.append(section('1 · 从章节表到玩家看到的一波，经过五层',['章节层选地图、波数、技能权重组、推荐技能、回血和奖励。波层配置经验、生命与攻击倍率、开始/结束界面事件和击杀锁。任务层给脚本时点、固定怪、位置组、随机怪、重复与宝箱事件。地图模板把一条任务展开为空间位置和延迟，怪物层才确定本体属性、AI与武器子弹。','于是“第19章难”没有单一旋钮：可以是更密的任务、不同编队、目标锁延长停留、终波倍率提高，或成长时机不匹配。拆案时把这些层分别列出来，才能知道原游戏究竟改了哪里。'],['配置层','直接决定','不能代替的下一层'],[['章节','地图、波数、权重组、奖励和全章入口','不能单独告诉每一秒刷几只'],['波','经验、倍率、UI事件和击杀锁','不能单独告诉怪从哪里来'],['任务','时点、刷新路线、重复和宝箱','可能仍需展开编队成员'],['位置模板','坐标、成员、延迟','不能单独决定怪的AI和血量'],['怪物／武器','本体、行为、弹幕和碰撞','还需叠加章节与波任务倍率']],['topics/chapter-planning/chapters.json','topics/chapter-planning/waves.json','topics/monsters/occurrences.json.gz']))
    out.append(section('2 · 两种波次骨架怎样安排成长',['63章采用15波、经验总预算14,800；第5、15、25、35、45、55、65章采用10波、经验总预算7,300。基础与B分支共用相同经验序列，因此分支差异主要落在战斗压力和推进门槛，而不是这一条经验预算。','15波模板常规在W6／W11／W15安排三次接触宝箱；10波模板常规在W4／W7／W10。第10章跳过原本W6宝箱，仅W11／W15；第60章仅W6／W15。每分支总共208次宝箱脚本事件。','成长骨架先固定，策划再改变压力，这使玩家跨关仍能理解“何时补强”，同时给特殊章节留局部例外。'],['模板','章节数量','经验序列','常规宝箱波','明确例外'],[['15波','63','200→550→…→2000，总14,800','6／11／15','第10、60章仅两次'],['10波','7','200→550→…→1100，总7,300','4／7／10','短章编号5+10k']],['topics/chapter-planning/facts.json','topics/chapter-planning/chapters.json']))
    out.append(section('3 · 第一章完整波次：成长和强度怎样错开',['第一章的波次表并非只写“W15为首领”。它让W1—W14有普通波末成长，W6／W11／W15给集中宝箱，W10／W15用目标死亡门槛停住推进。表中的生命和攻击是波次倍率；怪物实战名义生命还要乘本体与任务倍率。','把这张表作为基准，再对照第5章和第55章的短章设计，可以区分“相同波数模板”和“同样的战斗节奏”两回事。'],['波','脚本起点（秒）','经验预算','波生命倍率','波攻击倍率','击杀锁','宝箱'],curve,['topics/chapter-planning/waves.json','in-run/datasets/chapter-1.json']))
    out.append(section('4 · 七个横截面：章节变化实际落在哪里',['表中“计划怪量”是把固定位置、编队和随机任务展开后的配置范围取固定值；实际战斗仍可能因随机组合、提前结束和召唤不同。怪种数是脚本候选种类数，不是同屏数量。','从第1章到第70章，经验模板仍是上述两类，但任务行数、怪物组合、随机任务行和终波倍率变化显著。第55章只有10波，基础分支只在W10锁目标；B分支还在W4和W7加锁。'],['章节','波数','任务行','计划怪量','候选怪种','随机任务行','宝箱波','击杀锁波','终波HP倍率','终波攻击倍率'],profile,['topics/chapter-planning/chapters.json','topics/monsters/waves.json']))
    out.append(note('第1章与第19章不能只比较终波倍率','第1章W15生命倍率11，第19章终波约2039.694；但两章的怪种、任务密度、地图和目标行为都不同。倍率只说明波层放大，不能单独证明玩家体验难了多少倍。'))
    out.append(section('5 · 随机只在指定位置发生，并不重写整章',['一条任务可同时包含固定怪、编队和随机怪三条路线。随机怪先从配置候选中选，再按numberRandom目标数量截断；位置模板可能带多个成员和延迟。一个字段叫weight，但它在位置成员的坐标乘加中使用，不能看到“weight”就解释成抽怪概率。','例如第一章W1任务1001001只有位置组路线，却已经能把多个模板按0～9.9秒错峰展开成28只怪。后续任务若加随机路线，是在已安排的脚本时间框架里改变局部组合。由此形成“主节奏可控、局部空间不完全背板”的结构。','估算某章计划怪量应先选branch，逐波取任务，再展开所有路线和重复；对不确定候选保存范围，不把候选表行数当生成数。'],['字段／机制','正确读法','常见错误'],[['mission.time','任务脚本时点','玩家实际第几秒'],['positionGroupMonster','编队/位置模板入口，成员需展开','一条模板=一只怪'],['randomMonster','有限候选中的随机路线','整章完全随机'],['numberRandom','该任务目标总量','每组都生成该数量'],['interval / repeat','同任务重复与间隔','多个配置行互不相关'],['位置weight','坐标计算参数','怪物抽选概率']],['topics/monsters/occurrences.json.gz','topics/chapter-planning/facts.json']))
    out.append(section('6 · 基础/B分支影响哪些玩家时刻',['两套配置不是简单“B所有数值下降”。前1章终波生命倍率11对9；第2章20.5对18.792；第3章从W6起有攻击倍率变化。第55章B在W4／W7／W10都设置击杀锁，而基础只有W10。','当玩家构筑预算保持不变时，提高或降低血量/攻击会改变单位耐久和容错；增删击杀锁会改变哪一波需要留场处理关键目标。它们改变的是不同体验维度，不应被合并成一个模糊“难度系数”。','章节层HP/攻击倍率均为1，前4章关联的保护模板40个倍率也为1。主要静态数值差异要继续追到波和任务；不要在章节表找不到倍率就推断不存在数值成长。'],['案例','基础','B','玩家侧影响'],[['第1章W15 HP倍率','11','9','终局目标名义生命变化'],['第2章W15 HP倍率','20.5','18.792','终局耐久变化'],['第3章W6攻击倍率','2.695','2.964','中段碰撞/攻击压力变化'],['第55章W4/W7击杀锁','无','有','中段推进需等待关键目标']],['topics/chapter-planning/branch-differences.json','topics/chapter-planning/facts.json']))
    out.append(section('7 · 怪物投放怎样服务章节进程',['主线脚本候选有110种怪，其中100种在前30章已首次投放。后面章节更多通过复用怪种、阵型、任务倍率和波数组织持续内容；这是从配置得出的产品结构，不是开发者公开设计意图。','想研究一个怪的“首次引入”与“后续复用”，应把首次章节、具体波、当时组合、敌方倍率一起看。仅凭该怪出现在第70章列表，不能判断它是主角，可能只是随机候选里的一种。','为章节写设计单时可把每波任务按职责标注：铺垫、行为教学、空间压迫、构筑检验、关键目标、补强。职责是研究者的策划归纳；脚本任务、AI和倍率是原游戏证据。'],refs=['topics/monsters/catalog.json.gz','topics/monsters/chapters.json','topics/chapter-planning/facts.json']))
    out.append(section('8 · 复刻章节规划时，需要提交哪些可执行字段',['该项目提供一个可迁移的章节设计框架：先写玩家本章要学会或验证的行为，再给波数、经验序列、普通成长点与宝箱点；为压力峰选怪种和阵型；设脚本时点、重复、位置和目标锁；最后配生命/攻击倍率与奖励。','验收时按三张表检查：一张逐波体验表、一张计划刷新与条件截断表、一张构筑可达性表。三张表分别回答“玩家何时有选择”“何时受到何种压力”“此时是否有足够构筑能力处理”。静态计划之外仍需实机记录实际秒数和实际出现怪数。'],refs=['topics/chapter-planning/chapters.json','topics/chapter-planning/waves.json','topics/monsters/waves.json']))
    out.append(details('第55章逐波：短章基础分支的经验、倍率与门槛',table(['波','脚本起点','经验','生命倍率','攻击倍率','击杀锁','宝箱'],[[f'W{x["wave"]}',x['start_seconds'],x['exp'],x['hp'],x['attack'],x['kill_gate'],'是' if x['chest_events'] else '否'] for x in w55])+links('topics/chapter-planning/waves.json')))
    return ''.join(out)+fact_index('chapter-planning')

def monsters():
    catalog=[x for x in read('topics/monsters/catalog.json.gz') if x['mainline']]
    byid={x['id']:x for x in catalog}
    bullets={x['ID']:x for x in read('topics/monsters/bullets.json')}
    chapter_rows=read('topics/monsters/chapters.json')
    first=next(x for x in read('topics/monsters/occurrences.json.gz') if x['mission']==1001001)
    bfirst=byid[330006]['base'];bsecond=byid[320021]['base']
    ids=[330017,330023,340009,340001,320007,320018,340014]
    airows=[]
    for i in ids:
        x=byid[i];b=x['base']
        airows.append([x['name']+' '+str(i),x['first_chapter'],b['WaveAIId'],b['WaveAIParameters'][:210],b['MoveSpeed'],'／'.join(map(str,x['linked_bullet_ids'][:4])) or '无'])
    bulletsample=[]
    for i in [7001,7006,7007,7010,50001,50014,50058]:
        if i not in bullets:continue
        x=bullets[i];bulletsample.append([i,x['Type'],x['Shape'],x['ShapeOffset'],x['MoveSpeed'],x['LifeTime'],x['RandomDeflectionAngle'],x['MinBulletHurtTime']])
    dist=[]
    for n in [1,4,6,18,19,29,30,35,55,70]:
        x=next(z for z in chapter_rows if z['chapter']==n and z['branch']=='base')
        dist.append([f'第{n}章',x['waves'],len(x['monster_ids']),x['total'][0],', '.join(byid[i]['name']+' '+str(i) for i in x['monster_ids'][:5])])
    out=['<div class="compendium-intro"><h2>怪物的危险来自五条相互独立的链</h2><p>章节投放决定它何时和谁一起出现；实体本体决定基础数值和碰撞；主线AI决定运动和攻击；武器与子弹决定弹幕；运行状态与伤害属性决定最后的受击结果。只看一条“怪物配置”无法回答实际轨迹或打击范围。</p></div>',process([('波与任务','何时投放'),('模板','从哪里出现'),('实体','本体数值与碰撞'),('主线AI','轨迹和攻击时机'),('武器/子弹','弹幕与命中范围')])]
    out.append(section('1 · 从章节波次到一个怪站上屏幕',['任务可以平行执行固定位置、编队与随机路线。位置模板会展开成员和各自延迟，interval和repeat可能反复执行；随机路线要按numberRandom目标数量截断。实体创建后再取主线行为配置，接上武器和子弹。','第一章W1的任务1001001是一个很具体的例子：一个任务里只走位置组，却合计26只绿影鸟与2只僵尸游兵。若只数位置组里的配置行，会漏掉两个5成员编队，误报怪量。'],['链路','原数据回答的问题','输出到下一步'],[['章节／波','本章哪一波、波倍率与目标锁','任务集合'],['任务','脚本时点、路线、重复、刷新上限','具体投放计划'],['位置模板','哪个坐标、延迟、一个模板含几名成员','实际创建请求'],['敌方实体','本体HP、攻击、形状、行为ID、武器ID','运动/伤害对象'],['AI和武器','何时移动、转向、开火、死亡触发','实际弹幕和接触威胁']],['topics/monsters/occurrences.json.gz','topics/monsters/catalog.json.gz','topics/monsters/waves.json']))
    out.append(section('2 · W1投放与名义数值能逐项算出来',['任务1001001展开的总量为28，其中绿影鸟26、僵尸游兵2。该任务生命倍率0.8，章和波生命倍率各为1；本体绿影鸟HP150，僵尸游兵HP800。名义结果分别为120与640。','这不是“第一章所有绿影鸟都是120血”：同一实体换了任务、波次或章节时倍率会变。任务生命倍率为0则跳过该项，不是乘0直接把怪清除。静态名义值还不包括运行时Buff、护盾和热更。'],['怪物','本体HP','章×波×任务生命倍率','本任务名义HP','计划只数'],[[byid[330006]['name'],bfirst['HP'],'1×1×0.8',round(bfirst['HP']*.8,3),first['counts']['330006'][0]],[byid[320021]['name'],bsecond['HP'],'1×1×0.8',round(bsecond['HP']*.8,3),first['counts']['320021'][0]]],['topics/monsters/occurrences.json.gz','topics/monsters/catalog.json.gz','topics/monsters/facts.json']))
    out.append(section('3 · “自己决定轨迹”具体分成哪几种',['有些怪完全依赖任务给的入场路径，有些怪只用模板决定出生点，之后自行按AI追玩家、围绕中心、两点往返、上下冲刺或反弹。主线使用WaveAIId/WaveAIParameters；110种主线怪中59种的主线行为参数与常规参数不同，分析主线必须读这套参数。','黄眼虫用AIMoveFollowTarget、FollowSpeedScale=1，持续跟随最近目标；机械屏障按中心绕圈，初始半径15、目标半径11、顺时针旋转且有变半径与等待参数；尖刺护盾上下运动并配置RushSpeed=52。黑胡子船长使用随机反向移动任务，不是固定画一个往返线。下表把主线配置参数保留，便于查后续轨迹。'],['怪物','首见章','主线AI','关键参数片段','本体移速','关联子弹'],airows,['topics/monsters/catalog.json.gz','topics/monsters/facts.json']))
    out.append(section('4 · 子弹从怪物身上出来之前还有武器层',['怪物实体的WeaponID先连接武器，武器再连接子弹。子弹表给Type、Shape、偏移、速度、寿命、最短重复伤害时间、偏转等；部分武器还使用追踪、散射、死亡触发或后续生成。仅拿武器ID或怪物本体攻击范围，无法得到完整弹幕。','僵尸探子主线AI为两点往返并按2.3秒间隔尝试射击，武器70007发出7007子弹。表内该子弹速度13、寿命10秒、单元素Shape 0.27，还有偏转角15；其FollowMod转向属于武器/运行修饰链，不能仅用速度×寿命画一条“必然130距离直线命中”。'],['子弹ID','Type','基础Shape','偏移','速度','寿命','随机偏转角','最短重复伤害间隔'],bulletsample,['topics/monsters/bullets.json','topics/monsters/links.json','topics/monsters/catalog.json.gz']))
    out.append(section('5 · 死亡攻击和召唤会让静态波次表失真',['爆爆河豚的常规fireDelay=9999，使其不能按“每1.5秒正常射击”解释；死亡完成回调通过死亡武器70010触发散射。看见配置里fireInterval=1.5也不能跳过9999延迟、死亡触发与武器层。','首领340014的AICommonBoss动作池包含召唤330008，召唤分支持续4秒、间隔0.4—0.85秒。这些战斗内动态召唤不在章任务的静态计划怪量里。用第19章的脚本计划数推断实际屏幕怪总数，需另加运行时召唤日志。'],['机制','静态表看得到什么','运行时还会发生什么'],[['爆爆河豚死亡散射','实体行为、死亡武器ID、子弹/武器关联','死亡完成后FireNow触发散射'],['首领340014召唤','AI动作权重与CallMonsters配置','战斗中生成330008；不计入任务计划'],['击杀锁截断','某波计划任务和目标类型','目标早死会截断尚未执行任务']],['topics/monsters/catalog.json.gz','topics/monsters/facts.json','topics/monsters/waves.json']))
    out.append(section('6 · 打击范围要从形状、偏移和时间一起确认',['角色Shape只有一个元素时创建圆，两个元素时创建盒；实体模型缩放不直接等于碰撞形状。子弹有自己独立的Type、Shape和ShapeOffset，运动轨迹和动态缩放还可能改变有效威胁。','因此一条子弹的“打击范围”不是单一半径：先确定出生点/方向，逐帧算轨迹，再把碰撞形状与偏移放到每个时刻；重复伤害还受MinBulletHurtTime约束。表中基础Shape可以确认配置口径，但没有实机帧数据就不能假装已经量到屏幕像素宽度。','例如僵尸探子的7007子弹基础Shape为[0.27]，最短重复伤害间隔0.1秒；怪物本体Shape为[0.85,0.7]的盒。两者是不同碰撞对象，也不能拿怪物显示模型来替代。'],['要核对的层','相关字段／证据','给策划回答的问题'],[['角色碰撞','Character_entity.Shape、模型缩放','接触伤害或被击中的本体范围'],['子弹初始命中框','Bullet.Shape、ShapeOffset、Type','这一帧哪些位置会碰撞'],['弹幕路径','武器修饰、速度、转向、寿命','危险随时间扫过哪里'],['持续伤害','MinBulletHurtTime、后续触发','同一次接触能重复伤害几次']],['topics/monsters/catalog.json.gz','topics/monsters/bullets.json','topics/monsters/facts.json']))
    out.append(section('7 · 属性抗性与怪物“特性”不要混读',['主线110种怪的MonsterTraitID均为空，但行为、武器、能力效果仍能形成强烈差异。图鉴能力文案与真正的effects字段是两层：文案可以提示方向，却不能单独证明执行。','僵尸探子对冰冻系有60%抗性，同时对火焰伤害的承受增加30%；FireDamageAddToSelf说的是它受火伤更多，而不是它输出的火伤增加。设计玩家克制关系时要核对方向、作用对象和触发条件。'],refs=['topics/monsters/catalog.json.gz','topics/monsters/facts.json']))
    out.append(section('8 · 章节分布：先引入，后复用和重组',['110种主线脚本怪里100种在前30章首次引入。第4章出现黄眼虫，其脚本候选累计进入14章；爆爆河豚首见第6章；机械屏障在29、30、37、57、58、59章复用；340014含召唤分支的首领出现在19、35、51、66章。','“某章有某怪”只证明任务候选可能包含它；随机组、目标早死和动态召唤会改变实战见到的名单。分析复用价值时，应同时记录行为是否改变、与谁组队、波次位置、倍率和地图空间，而不是只数出现章数。'],['章节','波数','脚本候选怪种','计划怪量','部分代表怪'],dist,['topics/monsters/chapters.json','topics/monsters/catalog.json.gz']))
    out.append(section('9 · 怎样把怪物做成可复用的策划单位',['一张怪物设计卡至少应包含：职责（追击/封路/远程/死亡惩罚/召唤）、首次教学波、AI状态与转移条件、本体名义数值公式、碰撞形状、武器/子弹链、属性克制、与其他怪的编队方式、后续章节复用位置。','复核一条危险时按“任务→模板→实体→WaveAI→武器→子弹→命中”顺序查；要回答实机轨迹，再补帧采样。这样既不会把任务路径误当怪物AI，也不会把静态子弹速度误当最终射程。'],refs=['topics/monsters/facts.json','topics/monsters/catalog.json.gz','topics/monsters/bullets.json']))
    return ''.join(out)+fact_index('monsters')

def skills():
    build=read('in-run/datasets/skill-build.json');nodes={x['id']:x for x in build['nodes']}
    pools={x['id']:x for x in build['pools']}
    weapons=[nodes[i] for i in pools['SurvivorGroup']['skill_ids'] if nodes[i]['type']==1]
    families=defaultdict(lambda:Counter())
    for name,pool in pools.items():
        for i in pool['skill_ids']:
            if 10000000<=i<11000000:families[(i//100)%1000][name]+=1
    rows=[]
    for x in weapons:
        code=(x['id']//100)%1000;desc=x['description_template'].replace('<color=yellow>','').replace('</color>','')
        rows.append([x['name']+' '+str(x['id']),desc,families[code]['BranchSurvivorGroup'],families[code]['UpgradeSurvivorGroup'],families[code]['UpgradeSkillGroup']])
    edges=[x for x in build['edges'] if x['source'] in [10000101,10000102,10000103,10500101] and x['relation'] in ['NextSkill','CoverSkill','UpgradeSkillId']]
    out=['<div class="compendium-intro"><h2>武器不是单张牌，而是随局内状态展开的内容树</h2><p>先得到基础攻击方式，再通过星级、分支和模块依赖进入更深层。玩家每次看到的候选只是当前合法树枝，配置总行数不能当成整局可见内容。</p></div>',process([('入口','选攻击方式'),('主线','升级星级'),('分支','改变覆盖/取舍'),('模块','满足进化配方'),('突破','抽中后开专属选择')])]
    out.append(section('1 · 11把基础武器各负责什么攻击方式',['基础池18个入口由11把武器与7个通用模块组成。起步池另有10个武器入口，章节可以改其相对权重。下面用配置入口文案描述最初攻击方式；后续星级、分支和高阶节点会改变行为。','例如机炮打正前方，酸液枪弹跳，电弧枪在敌人间弹射，冰刃弹自动追踪，能量光剑覆盖近身180度。玩家选一把武器，本质是在选择下一段升级池和战斗覆盖形态。'],['武器入口','取得时的攻击方式','分支节点','深层节点','进化节点'],rows,['in-run/datasets/skill-build.json','topics/choices-box-evolution/pool-weights.json']))
    out.append(section('2 · 四类池如何逐层开放',['SurvivorGroup是常规基础入口，BranchSurvivorGroup是武器分支，UpgradeSurvivorGroup是后续深化，UpgradeSkillGroup存放22个高阶节点。它们分别有18、57、111、22条配置，合计208条池记录，但不是一次三选一有208个候选。','每次抽牌先判槽位和当前可学关系，再找具体合法节点。NextSkill连接下一星，CoverSkill说明取得新节点后覆盖什么，PreSkillIds/NeedSkills/RejectSkills/技能标记决定合法性；UpgradeSkillId是进一步候选连接。不同字段不能统一画成一条“直线升级”。'],['池','静态配置行','何时有意义','容易误读的地方'],[['基础入口',18,'建立新的武器或被动模块','不等于开局18个都能抽'],['分支强化',57,'已有相应武器和开放条件','不等于每条分支都可同时叠加'],['后续深化',111,'达到前置节点后继续加深','不是新增111个装备槽'],['高阶节点',22,'模块配方满足后进入候选','不是满足门槛立即取得']],['in-run/datasets/skill-build.json','topics/choices-box-evolution/facts.json']))
    out.append(section('3 · 机炮路线逐步追到突破',['机炮10000101首先给正前方持续攻击。沿NextSkill进入10000102，再到10000103。此时若同时持有暴击模块11000701，基础分支的配方将10500101按权重5000加入合法候选。玩家仍要等到后续抽取并选中它，才真正取得突破；随后还有9个专属选项。','配置还允许在主线星级阶段挂接104系分支，例如增加正向子弹但付出攻击力代价。这个取舍需要用弹数、命中率、攻击倍率和目标类型一起估价，不应只比较单发伤害数字。'],['关系','源节点','目标节点','策划含义'],[[x['relation'],x['source'],x['target'],'继续成长／覆盖／开放候选' if x['relation']!='CoverSkill' else '新阶段替换旧阶段'] for x in edges]+[['配方', '10000103 + 11000701',10500101,'满足依赖后加入高阶候选，仍需抽到']],['in-run/datasets/skill-build.json','topics/choices-box-evolution/evolution-recipes.json']))
    out.append(section('4 · 同一张模块有即时价值与未来价值',['7个通用模块占用被动槽，能给当前属性或机制收益；其中若干还作为22条配方的依赖。同一个模块可关联多把武器，所以即使玩家尚未确定主武器，也可能保留未来转向空间。','但“能组成配方”与“最后会进化”隔着武器节点、合法池、权重、同屏抽取和玩家选择。制定模块权重时应分别看它的即期面板价值、对多少条路线开放高阶候选，以及关卡剩余成长次数是否足够把配方兑现。'],refs=['topics/choices-box-evolution/evolution-recipes.json','in-run/datasets/skill-build.json']))
    out.append(section('5 · 三个实际构筑时刻的选择逻辑',['开局缺覆盖时，一把新武器可能比给单一武器升星更能处理不同方向的敌人；已有稳定主武器时，继续升星可能更快达到分支或配方前置；槽位接近满额时，新路线合法性下降，成长更偏向已有路线。','这是基于机制的策划研究框架，不是固定攻略：局内怪物密度、弹幕、章节权重和当前词条决定哪个选择更好。若要计算某张牌实际出现率，应回到三选一专题记录完整状态，而不能只看这里的路线树。'],['当前状态','系统层的约束','玩家面前的真实取舍'],[['早期，武器槽有空位','新武器入口与已有升级竞争','扩大覆盖还是集中主输出'],['中段，模块槽有空位','模块既增益又可能解锁配方','即时收益还是未来进化机会'],['后段，接近满槽','新增路线减少、后继节点仍可学','深化一条路线还是补关键短板']],['in-run/datasets/skill-build.json','topics/choices-box-evolution/facts.json']))
    out.append(section('6 · 研究一条武器线时应该交付什么',['给每把武器保留“入口攻击方式—主线星级—分支取舍—模块配方—高阶节点—特殊选择”六段关系，并写明每段的前置、权重、互斥与覆盖。完整节点、技能ID和描述已放在武器与词条查询页。','横向比较11把武器时，再按单体/清杂/近身/追踪/持续伤害等战斗职责对照章节怪物需求。不能用静态208行池记录推导所有武器都具有同等实战可达性。'],refs=['in-run/datasets/skill-build.json','topics/choices-box-evolution/evolution-recipes.json']))
    return ''.join(out)

def aircraft():
    skins=read('planner/inputs/Role_Skin.json');stars=read('planner/inputs/Role_SkinStar.json')
    lang={x['id']:x['chinesesimplified'] for x in read('planner/inputs/Language_languagetable.json')}
    goods=read('planner/inputs/Shop_ShopGoods.json')
    out=['<div class="compendium-intro"><h2>机体养成把“新的打法”和“长期收集”绑在一起</h2><p>角色母体、形态、星级、技能节点和获取商品属于不同层。报告把能力触发、完整成本和渠道限购连起来，不把文案直接当作已实机证实的触发频率。</p></div>',process([('母体','共享身份'),('形态','决定机制与品质'),('星级','成本、属性、能力'),('商品','资源渠道与限购'),('实战','验证真实触发收益')])]
    out.append(section('1 · 从母体到五星能力经过什么配置',['Role_Role保存母体身份；Role_Skin给8种形态的品质、解锁资源、模型与静态关闭标记；Role_SkinStar再按每一星配置成本、属性和FeatureOnStarUp技能。技能描述需要回连Skill_Main与语言表。','这种拆分允许共享角色基础成长，同时让形态承担不同玩法机制。静态存在的形态不等于线上当期可获得：是否关闭、商店/活动是否开放与运行渠道需要分别确认。'],['层','数据表','回答的问题'],[['角色母体','Role_Role','共同基础值与身份'],['形态','Role_Skin','是哪架机体、品质、模型、解锁资源和关闭标记'],['五星节点','Role_SkinStar','每次升星消耗、属性与能力节点'],['技能文案','Skill_Main + Language','玩家可读的条件与效果'],['获取渠道','Shop_ShopGoods / SignIn','资源从哪里来、受什么限购']],['planner/inputs/Role_Skin.json','planner/inputs/Role_SkinStar.json','planner/inputs/Skill_Main.json']))
    out.append(section('2 · 读机体要先读触发，而不是只看品质',['暗夜刀锋以“受伤”触发辐射脉冲，并把后续星级连接到维修箱和低血腐蚀；天使号每15秒发射前方光芒弹，之后把暴击与回复、穿透接进来；飞鹰号每12秒轰炸，中段增加轮次但降单轮伤害，高星缩短冷却。','三者展示不同机制身份：受击反打、周期输出与爆发循环。其具体叠加、触发上限和实战期望收益不能仅凭文案精确计算；这些需要对应运行逻辑或实机帧记录。后文列出全部40个星级节点原始能力文案，便于继续逐条深查。'],['形态','基础触发','中段改变','高星完成方向'],[['暗夜刀锋','受伤释放辐射脉冲','脉冲拾取维修箱','低于50%生命附加腐蚀'],['天使号','每15秒前方光芒弹','暴击回血、每秒最多一次','增加穿透次数'],['飞鹰号','每12秒一轮轰炸','多一轮但伤害降低25%','冷却缩短3秒']],['planner/inputs/Role_SkinStar.json','planner/inputs/Skill_Main.json','planner/inputs/Language_languagetable.json']))
    out.append(section('3 · 8份同名资源怎样分配到成长周期',['解锁形态消耗1份同名资源；后续可消耗星级成本为1、1、2、3份，满星行成本为空。因此从未解锁到完整五星共需8份，不应再把满星空成本加一次。','这8份可以与获取渠道的限购形成时间目标。飞鹰号资源在公会商品里要求公会等级7，价格15,000公会币、每周限购1次；理论上只从该渠道拿齐8份至少涉及8个可购买周，但未核对公会币产出和其他并行来源，不能据此写成真实毕业时长。'],['阶段','本次成本（份）','累计成本（份）','玩家感知'],[['解锁',1,1,'先获得机体与机制身份'],['后续第1次',1,2,'体验早期成长'],['后续第2次',1,3,'继续补能力/属性'],['后续第3次',2,5,'投入开始加重'],['后续第4次',3,8,'完成高星目标']],['planner/inputs/Role_Skin.json','planner/inputs/Role_SkinStar.json','planner/inputs/Shop_ShopGoods.json']))
    out.append(section('4 · 不同渠道是怎样把机体接到外围玩法',['签到第2天有守卫资源1份，使早期玩家接触形态养成。飞鹰号放在公会等级与公会币门槛之后，绑定长期社交贡献。毒蝎、黑武士和幻影对应活动兑换项；部分高品质形态的永久限购8与完整成长资源数相合。','渠道设计可以分为“教学接触、周期积累、活动追求”。但配置的兑换项不保证活动同时上线，也不保证玩家只通过一个渠道取得全部份数；真实完成周期要叠加活动档期、货币产出和服务器开关。'],['渠道','已核对门槛或频率','连接的设计目标'],[['签到','第2天守卫资源1份','让玩家早期接触形态解锁'],['公会兑换','等级7、15,000公会币、周限1','长期参与与周节奏'],['活动兑换','毒蝎/黑武士/幻影对应商品，部分永久限8','限定主题与完整成长目标']],['planner/inputs/SignIn_SignIn.json','planner/inputs/Shop_ShopGoods.json','planner/inputs/Role_SkinStar.json']))
    out.append(section('5 · 机体专题接下来怎样评估平衡',['对每架形态分别记录：基础攻击形态、1—5星能力节点、触发频率、条件占比、属性加成、与局内武器词条的叠加关系、所需资源与最短/典型获取周期。现在已闭合能力配置和资源结构，但运行期触发次数与线上渠道仍需专门证据。','例如“每15秒触发”如果战斗包含选牌和宝箱状态暂停，实际发射次数不能用脚本波次总秒数直接除以15。评估天使号的治疗收益，还要知道暴击率和每秒上限是否经常命中；这一层应在具体平衡研究时再沿链路深查。'],refs=['planner/inputs/Role_SkinStar.json','planner/inputs/Skill_Main.json','in-run/facts.json']))
    return ''.join(out)

def systems():
    shops=read('planner/inputs/Shop_Shop.json');loot=read('planner/inputs/Shop_LootBox.json')
    season=read('planner/inputs/CrossArena_CrossArenaSeason.json')[0]
    out=['<div class="compendium-intro"><h2>局外系统要看资源如何从一局进入下一局</h2><p>本专题先把配置能核对的获取、消耗、周期和长期目标连成图，再明确哪些环节仍依赖服务端或运行状态。不会把“有配置行”当作“当期线上开放”。</p></div>',process([('对局','完成与评价'),('结算','直接/待领取奖励'),('资源','抽取与兑换'),('养成','武器、收藏、机体'),('再挑战','章节/竞技/公会')])]
    out.append(section('1 · 战斗结束不是“所有奖励直接到账”',['章节完成、首通和累计星级有不同奖励入口。战斗结束还先处理场上装备与经验掉落，然后进入对应结算；有的资源作为直接结算，有的奖励需要满足首次通关或累计评价门槛后单独领取。','研究外围经济时至少分四个时间点：局内拾取、战斗结束计算、领取确认、永久养成消耗。把四者混成“每局收入”会高估当前可支配资源，也无法解释为何同一关后续重复打不再给首通奖励。'],['时间点','需要记录','不能混淆'],[['局内','经验、回血与宝箱词条','并非全部带出局外'],['结束计算','通关/失败、评级、掉落收束','不等于所有奖励已领取'],['奖励领取','首通、累计星级、系统任务','需要单独看资格与领取状态'],['永久消耗','武器、收藏、机体等升级','可能有等级或材料前置']],['in-run/facts.json','planner/inputs/AirplaneGun_Star.json','planner/inputs/Collection_TreasureStar.json']))
    out.append(section('2 · 三条永久能力线各消耗什么',['武器升星配置把材料、属性和能力连接起来；收藏成长提供生命、攻击等长期属性，并有等级/星级限制；机体形态升星则把属性和机制技能节点放在同一条收集线上。','它们都可能增强下一局，但最终战力不能简单把每张表的数值相加：还需要确认属性作用对象、同类加成相加或相乘顺序、上限和当前装备状态。当前报告先闭合资源去向与规则入口，不伪造全量战力公式。'],['系统','主要配置','对下一局的作用'],[['武器升星','AirplaneGun_Star','基础属性及关联技能／特性'],['收藏','Collection_TreasureStar','独立的生命与攻击成长'],['机体形态','Role_SkinStar','属性与条件触发能力']],['planner/inputs/AirplaneGun_Star.json','planner/inputs/Collection_TreasureStar.json','planner/inputs/Role_SkinStar.json']))
    out.append(section('3 · 商店要把“店”和“商品”两张表接起来',['Shop_Shop说明店铺用途、商品ID集合、刷新和店级限制；Shop_ShopGoods才给每件商品价格、奖励、限购与解锁条件。只读Shop_Shop的note无法得到准确成本。','金币兑换以钻石换基础养成资源，体力兑换说明重复购买存在递增成本；各档价格应查商品行。机体专属资源则被公会或活动商品挂接。不同商店的刷新与limit语义不能互相套用。'],['样例店铺','配置说明','商品数','刷新字段','限购字段'],[[x['id'],x['note'],len(x['goods']),x['refresh'],x['limit']] for x in shops[:10]],['planner/inputs/Shop_Shop.json','planner/inputs/Shop_ShopGoods.json']))
    out.append(section('4 · 局外抽取和局内接触宝箱是两种经济',['局外Shop_LootBox有钥匙、免费冷却、单抽/十抽成本、日限制等字段，承担材料或收集资源的供应与频次控制。局内接触宝箱则来自章节脚本，在战斗中生成1／3／5项词条并批量学习；两者没有同一个内容池或次数口径。','研究抽取经济时应先列玩家能否免费进入、需要哪种钥匙或货币、冷却、每日次数、奖励池，再追到服务端实际结算。只凭FreeCD字段名不能确定业务时间单位或线上资格。'],['局外抽取箱','钥匙ID','免费冷却字段','单抽成本字段','十抽字段','日限制'],[[x['ID'],x['Key_ID'],x['FreeCD'],str(x['Single']),x['Ten'],x['DayLimit']] for x in loot],['planner/inputs/Shop_LootBox.json','topics/choices-box-evolution/mainline-chest-pool.json']))
    out.append(section('5 · 周期玩法把资源需求变成日常行为',['跨区竞技一条赛季配置为7天、每天00:00—23:50开放，票券每日恢复5张，并关联专用任务和商店。公会贡献按次数给成本和产出记录；机体资源中的飞鹰号又进入公会商店，让贡献有长期兑换目标。活动日历则采用“开服+N天”类条件组织阶段活动。','这些结构可以解释玩家为什么回访，但静态客户端不能证明当前赛季、活动是否真的开放，也不能代替服务器侧的匹配、发奖和货币供给。要估算真实日/周毕业周期，必须接入当期发奖与参与次数数据。'],['系统','配置中的时间/门槛','玩家下一步'],[['跨区竞技',f"{season['Days']}天赛季；{season['OpenTime']}—{season['CloseTime']}；每日票券恢复{season['TicketDailyRecover']}",'参与比赛、完成任务、进入专属商店'],['公会贡献','按Times配置消耗与回报','累积公会币并兑换指定资源'],['活动日历','部分活动按开服进度安排','用活动目标取得专属货币或资源']],['planner/inputs/CrossArena_CrossArenaSeason.json','planner/inputs/Guild_guildcontribute.json','planner/inputs/Calendar_CalendarFig.json']))
    out.append(section('6 · 下一轮外围研究怎样从这里接手',['先挑一种永久能力资源，从“需求数量→可见获取商品→店铺/玩法门槛→每日或每周频率→服务端实际发奖”串成一条闭合链。机体专题的8份资源就是可直接继续的例子。','如果要做经济平衡报告，还需为每种资源补一张产销表和不同玩家行为情景。当前静态配置可确认结构、商品和部分限购，不能给真实平均付费或线上毕业天数。原表和来源索引已在交接目录保留，后续同事无需重扫APK。'],refs=['planner/inputs/Shop_Shop.json','planner/inputs/Shop_ShopGoods.json','planner/inputs/Role_SkinStar.json']))
    return ''.join(out)

RENDERERS={'core':core,'choices-box-evolution':choices,'chapter-planning':chapter,'monsters':monsters,'skills':skills,'aircraft':aircraft,'systems':systems}
def render(slug):return '<div class="compendium" id="full-walkthrough">'+RENDERERS[slug]()+'</div>'
