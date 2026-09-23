# 武器构筑专题证据审计（客户端 1.0.16）

本审计把“配置存在”“本地原生代码会执行”“线上玩家实际看到”分开。报告的章节权重、配方门槛和槽位为静态可复核结论；策划意图、胜率、实战伤害与真实出现率不能由这些配置直接推出。

| 结论 | 证据级别 | 核心证据 | 边界 |
| --- | --- | --- | --- |
| 第1、2、3、4、6、8章依次读取六组技能权重，其余可见主线读默认列；第2—10章另有条件保护 | 配置＋本地原生函数 | `chapter-weapon-control.json`、`evidence/LocalModels.Bean.Chapter_MainChapter--GetSkillGroupWeight.asm`、`facts.json` C05 | 只确定客户端1.0.16本地规则；条件保护还取决于WorldType和已持有武器 |
| 起步池10把、常规池11把武器和7个模块入口；增幅模块普通权重为0 | 配置＋本地原生函数 | `pool-weights.json`、`evidence/DankeSkillCreator--GetNormalSkill.asm`、`facts.json` C04 | 入口数不等于当局合法候选数 |
| 普通新局Init计数从配置值1写入；计数消费后转常规池 | 本地原生函数闭合 | `evidence/SinglePlayerBattleManager--CreatePlayer.asm` 0x65C6738—0x65C67C0、`evidence/DankeSkillCreator--GetNormalSkill.asm` | 引导指定结果可能先覆盖随机；热更分派的线上函数体未核验；继续战斗沿用保存计数 |
| 推荐技能`SuggestedSkills`与抽取权重不同 | 配置＋一个展示调用点 | 第5/7/9/10章默认权重却有推荐ID；`evidence/report-native/BattleResultViewMainModule-.asm` 0x7371B28读取推荐字段并逐项取技能信息 | 该调用点证明战后展示使用推荐字段，不能证明它在所有热更分支中绝不影响抽取 |
| 基础105进化两档各需要指定武器星级、模块星级和前档节点；满足后以权重5000入池 | 配置＋本地原生函数 | `evolution-recipes.json`、`evidence/DankeSkillCreator--TryUnlockUpgradeSkills.asm`、`facts.json` | 5000是相对权重，抽中、选择、专属子项展示是后续步骤 |
| B配置槽位5/5、上限9星，3/6/9星配置`IsUpgrade_B`和专属选项；本地函数按AB标志读取_B列，特殊技能检测和专属选择分别调用这两个取值函数 | 配置＋本地原生函数 | `constants.json`、`inputs/Skill_Main.json`、`evidence/Skill_Main--GetIsUpgrade.asm`、`evidence/Skill_Main--GetUpgradeSkillId.asm`、`evidence/DankeSkillCreator--CheckIsSpecialSkill.asm`、`evidence/DankeSkillCreator--OpenSelectSpecialSkill.asm` | `WorldInitInfo.ABTestMap`的线上赋值和特殊界面逐次展示数仍需复核 |
| 特定武器适合某章节、某进化变体实战更强 | 策划解释或待测假设 | 武器/模块权重并排、技能描述文本 | 需敌群、命中、伤害公式及实机表现；报告应明确这是设计解读，不是程序保证 |

## 曾停下、现在仍有价值的定向追查

1. **引导覆盖和线上AB分流。** 过去把Init计数写入也归入缺口；本次已通过`CreatePlayer`补上。`BattleLogicWorld.InitBaseBattleData`把`WorldInitInfo.ABTestMap`交给`SetSkillABTest`，后者读取键2001；`GetIsUpgrade/GetUpgradeSkillId`确实按标志读基础或_B列。剩下应追`GuideSelectSkillId`如何进入指定结果列表，以及ABTestMap在线上由谁赋值。需要同版本运行态作最终确认。
2. **B配置特殊界面。** 3/6/9星节点、_B列读取、`CheckIsSpecialSkill`和`OpenSelectSpecialSkill`的调用已证实，尚未逐步闭合专属选项一次展示几项、玩家选后如何写回的UI状态机。应继续追界面回调和实际屏幕，而不是重复提取两个字段取值函数。
3. **整屏出现率。** 缺少某一局抽取前的完整候选池、品质、属性、已有技能、引导、刷新和AB状态。下一步是保存一个具体状态并重放随机算法；单拿章节权重无法给真实概率。
4. **进化后战斗效果。** `101`选项描述和`105`节点字段可核对，但`BulletAttack%=50`进入最终伤害公式、互斥/叠加与不同敌群下的强度没有闭合。应先挑一条武器线做公式与实机对照，再考虑推广到全部11把。
5. **线上版本差异。** 当前来源是本地客户端1.0.16。热更与服务端配置若改变，必须取得同版本实际运行包/日志才可把本地规则升级为线上普遍事实。

第1项的计数写入和_B字段读取已经完成，继续重复搜索`DoInitSkillGroupCount`直接`BL/B`没有价值：该调用使用热更新函数指针，并在本地路径内联写字段。关于这个修正，见`evidence/battle/init-skill-group-open-question.md`。
