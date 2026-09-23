"""Chapter-to-weapon walkthrough for the planner report."""
from collections import defaultdict

from planner_compendium import read, section, process, note


def render():
    control = read('topics/choices-box-evolution/chapter-weapon-control.json')
    records = {row['chapter']: row for row in control['records'] if not row['hidden']}
    weights = read('topics/choices-box-evolution/pool-weights.json')
    recipes = read('topics/choices-box-evolution/evolution-recipes.json')
    regular_weapons = [row for row in weights if row['pool'] == 'SurvivorGroup' and row['skill_type'] == 1]
    regular_passives = [row for row in weights if row['pool'] == 'SurvivorGroup' and row['skill_type'] == 2]
    init_weapons = [row for row in weights if row['pool'] == 'InitSurvivorGroup']

    def tilts(row, pool, candidates):
        if row['weight_group'] == 0:
            return '全部同权：' + ('200' if pool == 'init_pool_weights' else '100')
        values = [(x['name'], row[pool][str(x['skill_id'])]) for x in candidates]
        high = [f'{name} {value}' for name, value in values if value > 100]
        low = [f'{name} {value}' for name, value in values if 0 < value < 100]
        return '；'.join([('↑' + '、'.join(high)) if high else '无抬权重',
                         ('↓' + '、'.join(low)) if low else '其余100'])

    profile_rows = []
    for cid in range(1, 11):
        row = records[cid]
        profile_rows.append([
            f'第{cid}章', row['weight_column'],
            tilts(row, 'init_pool_weights', init_weapons),
            tilts(row, 'regular_pool_weights', regular_weapons),
            tilts(row, 'regular_pool_weights', [x for x in regular_passives if x['skill_id'] != 11000301]),
            '有条件＋10%' if row['new_player_protect_3'] else '无',
        ])
    profile_rows.append(['第11—70章', 'Weight', '10把各200', '11把各100', '6种各100；增幅0', '无'])

    out = [
        '<div class="compendium-intro"><h2>章节先定可抽的路线，再由本局构筑决定候选</h2>'
        '<p>先看章节选择哪列权重和几次成长机会，再看起步池、槽位、已有武器、模块与进化前置。相同一把武器在不同章节的“出现机会”会变，但章节权重本身不等于玩家屏幕上的最终概率。</p></div>',
        process([('选章节', '权重列与波次预算'), ('起步', '10武器池或引导覆盖'),
                 ('普通选择', '类别→合法技能→同屏修正'), ('学习', '升星、覆盖与分支'),
                 ('进化', '基础配方或B特殊路径'), ('宝箱', '阶段性批量推进')]),
    ]
    out.append(section('1 · 第1—10章分别怎样调武器', [
        '全部70个可见主线章节的SkillType均为2；基础和B列的章节权重组相同。第1、2、3、4、6、8章分别读取Weight_1至Weight_6；第5、7、9、10章以及第11—70章读取默认Weight。WeightForNewplayer虽然有配置列，这条主线权重路由不读取它。',
        '表中↑和↓均以同一池其他正权重入口的100为参照。起步池与常规池是两张不同表；例如第6、8章只在起步池明显抬高灼热射线或磁暴枪，转入常规池后11把武器各100。第2—10章还可能另行对机炮、冰刃弹、灼热射线施加临时保护。',
    ], ['章节', '实际读列', '10武器起步池', '11武器常规池', '常规模块', '临时保护'], profile_rows,
    ['topics/choices-box-evolution/chapter-weapon-control.json', 'topics/choices-box-evolution/facts.json']).replace(
        '<section class="section compendium">', '<section id="chapter-differences" class="section compendium">', 1))

    out.append(section('2 · 章节的策划意图要用“武器＋模块”一起看', [
        '第1章同时抬高机炮、冰刃弹与暴击、缩小模块；这两组分别能走机炮＋暴击、冰刃＋缩小的第一档进化。第2—3章逐渐降低这两个核心入口的偏斜，并把灼热射线抬进来。第4章转向近身的冰冻锯盘与能量光剑，模块侧抬生命与攻击，分别与锯盘和光剑的配方相接。',
        '第5章虽然推荐机炮和高能激光，实际仍用默认权重；第6章只在起步池突出灼热射线，第8章只在起步池突出磁暴枪。第7、9、10章同样回到默认权重。因此“章节推荐”是单独字段，不能当作抽卡保底或开放条件。',
    ], ['章节例子', '配置的武器倾向', '配套模块／推荐字段', '实际控制方式'], [
        ['1', '机炮、冰刃各300；锯盘50', '暴击、缩小各300；推荐机炮/冰刃', '起步和常规池均偏向两条配方线'],
        ['4', '锯盘200、光剑180', '生命170、攻击160；推荐锯盘/光剑', '武器与对应配方模块一起倾斜'],
        ['5', '起步各200、常规各100', '推荐机炮/高能激光', '推荐字段没有改变池权重'],
        ['6', '起步灼热射线300；常规各100', '推荐灼热射线/导弹；模块仍各100', '主要控制开局定向'],
        ['8', '起步磁暴枪300；常规各100', '推荐磁暴枪；模块仍各100', '主要控制开局定向'],
        ['11—70', '起步各200、常规各100', '前10章的具体推荐ID改为功能推荐字段', '不再使用专门武器权重列'],
    ], ['topics/choices-box-evolution/chapter-weapon-control.json', 'topics/choices-box-evolution/evolution-recipes.json']))

    def share(cid, pool, sid, candidate_ids):
        values = records[cid][pool]
        total = sum(values[str(i)] for i in candidate_ids)
        part = values[str(sid)]
        return f'{part}/{total}＝{part/total:.2%}'

    init_ids = [x['skill_id'] for x in init_weapons]
    regular_ids = [x['skill_id'] for x in regular_weapons]
    out.append(section('3 · 权重到底能算出什么', [
        '只在“已确定抽武器类别、对应池全部入口合法、没有保护/品质修正/同屏去重”的条件下，单张候选的池内份额才能用该技能权重÷有效武器权重和。下表用未加保护的静态池说明章节倾向；它不是本局三选一整屏出现率。',
        '条件保护的影响也可以算清：第6章若WorldType=1、尚未持有机炮、起步池10把全合法，机炮和冰刃各100→110、灼热射线300→330，灼热的池内份额从300/1200＝25%变为330/1250＝26.4%。第8章同条件下磁暴枪仍为300，但三个受保护入口各100→110，磁暴份额由25%变为300/1230≈24.39%。这是保护影响相对权重的例子，实际抽取仍要经过类别与状态筛选。',
    ], ['条件示例', '池', '目标', '未修正池内份额'], [
        ['第1章', '起步10武器', '机炮', share(1, 'init_pool_weights', 10000101, init_ids)],
        ['第1章', '常规11武器', '机炮', share(1, 'regular_pool_weights', 10000101, regular_ids)],
        ['第4章', '起步10武器', '冰冻锯盘', share(4, 'init_pool_weights', 10001601, init_ids)],
        ['第6章', '起步10武器', '灼热射线', share(6, 'init_pool_weights', 10001701, init_ids)],
        ['第8章', '起步10武器', '磁暴枪', share(8, 'init_pool_weights', 10000401, init_ids)],
        ['第11章', '起步10武器', '任意一把', share(11, 'init_pool_weights', 10000101, init_ids)],
        ['第11章', '常规11武器', '任意一把', share(11, 'regular_pool_weights', 10000101, regular_ids)],
    ], ['topics/choices-box-evolution/chapter-weapon-control.json', 'topics/choices-box-evolution/facts.json']))

    out.append(section('4 · 武器什么时候开放', [
        '11把常规武器的一星入口UnlockStage均为0，也都在SurvivorGroup中且主线默认权重大于0；没有看到“通关第N章才把某把武器加入基础池”的静态门槛。起步池只有10把，酸性黑洞10000901不在其中，因此即使处于默认权重章节，起步池阶段也抽不到它。',
        '常规池名义上还有7种被动模块，但增幅模块11000301在默认及全部章节权重列均为0，不能按正权重进入这条普通随机路径。章节推荐技能字段与合法性、权重是三件事；例如第5章推荐高能激光，并没有给它专门加权。普通CreatePlayer路径已查到从Const读取起步池计数1并写入战斗上下文；读档沿用存档值。是否展示初始池还受引导指定结果影响，不能直接把计数1解释为每局首屏必出现10武器池。',
    ], ['门槛', '已核对规则', '玩家结果'], [
        ['基础入口', '11把常规武器UnlockStage=0且正权重', '没有逐章新增武器名单'],
        ['起步池', '普通新局写入计数1；消费时选10把，不含酸性黑洞', '引导可先覆盖首屏；读档沿用存档计数'],
        ['槽位', '基础武器/模块各4槽；B各5槽，后两槽有6级阈值', '满槽时新入口会失去合法性'],
        ['模块例外', '增幅模块在普通池所有列权重0', '有配置行不等于能从普通随机抽到'],
        ['推荐字段', 'SuggestedSkills独立于权重列', '不能推成保底或章节锁'],
    ], ['topics/choices-box-evolution/inputs/Skill_Main.json', 'topics/choices-box-evolution/pool-weights.json', 'topics/choices-box-evolution/constants.json', 'topics/choices-box-evolution/chapter-weapon-control.json', 'topics/choices-box-evolution/evidence/SinglePlayerBattleManager--CreatePlayer.asm']))

    out.append(section('5 · 一次三选一怎样真正决定武器', [
        '若存在引导覆盖列表，系统直接用指定结果；否则先看Init计数，未耗尽时进入10武器起步池，之后再从常规池和已学路线更新候选。随机先剔除不满足槽位、已有技能、前置、互斥与当前权重的项；再检查可用类别，按类别权重抽类别，按该类池内有效权重抽具体技能。',
        '主线类别权重基础值为被动200、武器300、特殊升级300，但类别3只有有合法候选才参与；配方105系在当前开关0的入池路径会归到武器类别。每屏逐张抽且去重，若整组没有武器而仍有合法武器，尝试把一张替换成武器。刷新和品质修正还会改变过程。因此章节表的300只能比较池内倾向，不能直接宣称“某把武器每屏出现30%”。',
    ], ['顺序', '判定', '失败或变化时'], [
        ['1 引导', '有没有指定列表', '有则不走普通随机'],
        ['2 池', 'Init计数是否仍大于0', '10把起步武器或动态常规池'],
        ['3 合法性', '权重、前置、槽位、互斥、已学', '0权重或不合条件的项退出'],
        ['4 两层抽取', '类别权重→类别内技能权重', '可用类别和分母随状态改变'],
        ['5 整屏处理', '同屏去重、必要时补武器', '展示结果不同于独立三次抽签'],
        ['6 学习', '覆盖旧星、加入下一星/分支/配方', '下一次选牌的池已改变'],
    ], ['topics/choices-box-evolution/facts.json', 'topics/choices-box-evolution/constants.json']))

    out.append(section('6 · 星级、槽位和分支怎样限制成长', [
        '取得一星武器后，NextSkill把下一星放进可继续学习的关系；新星通过CoverSkill替换旧星，不是把一至六星叠成六个武器槽。二星和后续节点的UpgradeSkillId会挂出104系专属分支；这些分支还须过自身的合法性、权重与当次选择。',
        '基础配置武器/模块分别最多4槽，B配置分别最多5槽。常量表里基础4槽阈值均为0，B的后两槽阈值为6；运行时用GetLevel()+1去检查槽位是否开放。这个门槛约束“新开一条路线”，不等于现有武器不能继续升星。',
    ], ['动作', '配置关系', '可能的误读'], [
        ['拿一星武器', '建立BattleSkillGroup并暴露NextSkill', '把全部后续节点视为立即可选'],
        ['武器升星', 'CoverSkill替换旧星；按当前星级再挂分支', '一到六星分别占武器槽'],
        ['选104分支', '需达到相应主线节点并通过合法性过滤', '把57条分支看作全局开放池'],
        ['开新武器', '受当时已开放槽位与已持有组数约束', '以总槽数代替当时可用槽数'],
    ], ['in-run/datasets/skill-build.json', 'topics/choices-box-evolution/inputs/Skill_Main.json', 'topics/choices-box-evolution/constants.json', 'topics/choices-box-evolution/evidence/DankeSkillCreator--GetCanStudyCount.asm', 'topics/choices-box-evolution/evidence/LocalModelEx--CheckSkillIndexIsOpen.asm']))

    first = {r['result_skill_id']//100: r for r in recipes if r['result_skill_id']%100 == 1}
    second = {r['result_skill_id']//100: r for r in recipes if r['result_skill_id']%100 == 2}
    assert len(first) == len(second) == 11
    assert first[105001]['required_skill_ids'] == [10000103, 11000701]
    out.append(section('7 · 基础配置的进化需要几次独立成功', [
        '每把武器的第一档105系节点要求该武器3星和指定模块1星；第二档要求武器6星、同名模块2星，并且该105系节点自身还以第一档105系节点为NeedSkills。11条武器线共22个节点。达成依赖后，TryUnlockUpgradeSkills才把目标以权重5000加入候选；没有抽中并取得之前，配方只是“解锁可抽”。',
        '以机炮为例：先拿10000101并升至10000103，再持有暴击模块11000701，第一档10500101才入池；抽中并选取后会处理其专属选项。第二档需要机炮10000106、暴击模块11000702和已有10500101，才能争取10500102。后者配置BulletAttack%=50，但最终伤害还要看运行时叠加公式。',
    ], ['机炮阶段', '武器条件', '模块条件', '其他条件与结果'], [
        ['第一档入池', '10000103（3星）', '11000701（1星）', '10500101权重5000进入候选'],
        ['第一档兑现', '抽中并取得10500101', '已满足第一档', '才处理专属选择'],
        ['第二档入池', '10000106（6星）', '11000702（2星）', '还需10500101；10500102进入候选'],
        ['第二档兑现', '抽中并取得10500102', '模块条件持续满足', '节点带BulletAttack%=50，继续处理专属选择'],
    ], ['topics/choices-box-evolution/evolution-recipes.json', 'topics/choices-box-evolution/inputs/Skill_Main.json', 'topics/choices-box-evolution/facts.json']))

    node_by_id = {node['id']: node for node in read('in-run/datasets/skill-build.json')['nodes']}
    representative = {
        105001: (10100101, 10100104), 105002: (10100220, 10100201),
        105003: (10100302, 10100305), 105004: (10100408, 10100411),
        105006: (10100605, 10100625), 105007: (10100706, 10100708),
        105009: (10100905, 10100910), 105011: (10101101, 10101105),
        105015: (10101503, 10101511), 105016: (10101607, 10101614),
        105017: (10101706, 10101709),
    }
    effects_rows = []
    for family, pair in representative.items():
        recipe = first[family]
        assert all(sid in recipe['subchoice_ids'] for sid in pair)
        effects_rows.append([recipe['result_name'],
                             f"{node_by_id[pair[0]]['name']} {pair[0]}", node_by_id[pair[0]]['description_template'],
                             f"{node_by_id[pair[1]]['name']} {pair[1]}", node_by_id[pair[1]]['description_template']])
    out.append(section('进化后的选择会怎样改写武器形态', [
        '105系进化节点取得后，还会面对该武器的专属选项。下表从每把武器第一档配置的选项集合中各取两个具体例子；它们是可研究的分叉，不表示两项会同时出现或可以同时拥有。',
        '这些选项改变的是命中空间、连锁方式、持续时间与生存能力，部分有明显代价：酸液枪可变成高速炮台但不再反弹；黑洞可失去引力换取输出；机翼激光改为两翼发射但伤害减少20%；灼热射线可降低初始伤害换取对同一目标的递增伤害。评估进化强度必须把怪物队形与命中条件纳入，单看105节点权重没有意义。',
    ], ['武器', '选项A', '效果A', '选项B', '效果B'], effects_rows,
    ['topics/choices-box-evolution/evolution-recipes.json', 'in-run/datasets/skill-build.json']))

    out.append(section('8 · B配置为什么不能照基础配方走', [
        '所有11把武器的主线节点在基础配置的MaxStar为6、B配置的MaxStar_B为9。基础3星、6星的IsUpgrade=2，进化经模块配方进入105候选；B配置在3、6、9星节点的IsUpgrade_B=1，主线节点直接配置UpgradeSkillId_B专属选项，同时基础配方函数在B分支提前返回。本地GetIsUpgrade/GetUpgradeSkillId会按技能AB标志实际读取基础或_B列；特殊技能检测和专属选择也分别调用这两个函数。',
        '章节表的基础/B技能权重组相同，所以第6章开局偏灼热射线这件事在两列相同；真正分开的，是槽位、星级上限和突破入口。战斗初始化将WorldInitInfo.ABTestMap交给SetSkillABTest，技能标志读取键2001。线上是谁给映射赋值、每次特殊界面的展示节奏仍需实机核对；B不能按玩家账号年龄解释。',
    ], ['机制', '基础配置', 'B配置'], [
        ['章节入口权重', '按相同SkillGroupWeight列', '与基础列相同'],
        ['武器/模块槽位', '各4槽', '各5槽，后两槽有等级阈值'],
        ['武器主线', '最高6星', '最高9星'],
        ['突破节点', '3/6星配方解锁105候选', '3/6/9星主线IsUpgrade_B=1并配专属列表'],
        ['模块配方函数', '检查依赖并加权入池', 'TryUnlockUpgradeSkills提前返回'],
    ], ['topics/choices-box-evolution/chapter-weapon-control.json', 'topics/choices-box-evolution/inputs/Skill_Main.json', 'topics/choices-box-evolution/facts.json', 'topics/choices-box-evolution/evidence/Skill_Main--GetIsUpgrade.asm', 'topics/choices-box-evolution/evidence/Skill_Main--GetUpgradeSkillId.asm']))

    opportunity_rows = []
    for cid in (1, 4, 5, 6, 8, 10, 11, 15, 60):
        row = records[cid]
        v = row['variants']['base']
        opportunity_rows.append([f'第{cid}章', v['waves'], v['exp_budget'], v['ordinary_end_ui_flags'],
                                 '、'.join(map(str, v['chest_waves'])) or '无'])
    out.append(section('9 · 章节还通过成长次数控制进化能否来得及', [
        '权重以外，关卡长度决定玩家有多少次推进武器、模块和进化的机会。多数15波章配置14次波末成长界面标记，第4章例外，终波也配置标记、合计15次；15波经验预算均为14,800。每逢第5、15、25、35、45、55、65章的10波模板为9次标记、经验7,300。标记数不是实际选牌数，波末可能累计多次升级。',
        '宝箱也是阶段性补强：通常每章3次；第10和60章仅2次。宝箱先筛已学且至少二星的路线升级，逐项更新后继和进化候选，奖项数另按1/3/5档处理。因此第5章虽有3次宝箱，常规波末窗口和经验仍少于15波章；第10章则在15波下少一次中段宝箱。后期是否值得追第二档进化，必须把这些窗口和当前进度一起看。',
    ], ['章节', '波数', '经验预算', '波末成长界面标记', '宝箱波'], opportunity_rows,
    ['topics/choices-box-evolution/chapter-weapon-control.json', 'topics/choices-box-evolution/mainline-chest-pool.json']))

    module_lines = defaultdict(set)
    for r in first.values():
        module_lines[r['required_names'][1]].add(r['result_name'])
    out.append(section('10 · 完成一条构筑要同时算眼前收益和配方覆盖', [
        '7个常规模块入口里，6个有正权重且进入105配方：暴击、缩小、生命、攻击、维修强化各连接两把武器，冷却连接一把。增幅模块虽然存在一行基础配置，但所有章节池内权重均为0，也不在这22条进化配方中。',
        '这意味着章节推一把武器时，最好核对它的配套模块是否也被推。第1、4章做到了武器和模块同时倾斜；第6、8章则主要倾斜起步武器，没有同步提高配套模块。后者更像“帮玩家先定武器方向”，并未同时提高最终进化的全部前置机会。',
    ], ['模块', '关联武器数', '可接的武器'], [
        [name, len(lines), '、'.join(sorted(lines))] for name, lines in sorted(module_lines.items())
    ] + [['增幅模块', 0, '常规池权重0；无105配方']],
    ['topics/choices-box-evolution/pool-weights.json', 'topics/choices-box-evolution/evolution-recipes.json']))

    out.append(note('一条判断链：第6章想玩灼热射线',
                    '先确认当局是否启用10武器起步池；启用时灼热射线权重300，对照同池其他入口多数100。第2—10章保护若满足条件会临时改权重。拿到一星后要保住武器槽、推进到3星；它的第一档配方还需要暴击模块1星，而第6章模块池没有额外偏向暴击。凑齐后10501701只是进入候选，仍要抽取与选择；第二档再要求6星、暴击模块2星和第一档10501701。若这局进入B配置，则按3/6/9星特殊路径重新分析。'))
    out.append(section('11 · 哪些结论已有证据，哪些还需要深挖', [
        '章节路由、原始权重、条件保护、起步池名单、普通新局Init计数写入、基础进化配方与槽位，均有配置和本地原生函数可回查。原先将“计数写入未找到”列为缺口是遗漏了CreatePlayer中的热更新间接调用；本次已补证并修正。SuggestedSkills至少用于战后推荐展示，不能把它直接当作抽取保底。',
        '“第1/4章有意把武器与配方模块成对引导”“某条进化路线在特定敌群更强”属于策划解读或待测假设。B读_B字段的本地函数已核实，线上B配置究竟分配给谁、引导是否先盖住起步池、某次三选一整屏概率、101子项真实展示数及最终伤害，仍需定向反编译和运行态验证。',
    ], ['待追问题', '目前已到哪里', '下一步最有价值的证据'], [
        ['引导与B分流', '计数写入已闭合；引导列表来源和线上AB未闭合', '追赋值调用方＋同版本实机状态'],
        ['B进化落地', '3/6/9星配置、读_B字段及基础配方提前返回已证实', '追AB映射来源和专属界面展示节奏'],
        ['整屏概率', '仅能在指定合法池前提下算池内份额', '保存抽取前完整状态并重放'],
        ['进化实战效果', '101描述与105字段可查', '一条武器线的伤害公式与实机对照'],
    ], ['topics/choices-box-evolution/weapon-evidence-audit.md', 'topics/choices-box-evolution/evidence/SinglePlayerBattleManager--CreatePlayer.asm']))
    return ''.join(out)
