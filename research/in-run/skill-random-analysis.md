# 局内三选一与 Build：动态随机机制还原

> 研究对象：APK 客户端约 1.0.16 / versionCode 40。这里讨论的是玩家局内升级时看到的候选，不把 1,184 条 `Skill_Main` 全部等同于“玩家技能”。

## 结论先行

《小小远征队》的三选一不是“从一个大池随机 3 条”。更接近一个多层候选生成器：

**当前可学状态过滤 → 按候选池/类型组织 → 动态修正权重 → 区分新技能、已学技能、可升级技能 → 对武器升级再随机一个归属分支 → 去重/排斥 → 生成本次候选。**

因此它同时在解决两个相反的问题：一方面需要随机性保证重复游玩；另一方面又不能让玩家已经投入的 Build 因为连续抽不到后续组件而报废。

当前最重要的新结论是：此前“选了某一武器后，该武器家族整体被 +50%”的说法过度了。native 证据显示这一套 +50% 动态权重是按 `SkillType` 大类计算，不是按具体 `BattleSkillGroup` 计算。当前标准局内池里可明确对应的是 Type 1 武器主线，因此它更像 **提高武器类后续候选整体权重**，而不是专门给“冰刃弹家族”或“速射机炮家族”加权。

## 先把局内 Build 的四层结构讲清楚

当前可确认的主要局内池可以理解成四层：

| 层 | 数据角色 | 数量 | 策划意义 |
|---|---|---:|---|
| 武器主线 | SurvivorGroup 中 Type 1 | 11 个首层武器入口 | 决定主要输出方式，如速射机炮、冰刃弹、灼热射线 |
| 通用模块 | SurvivorGroup 中 Type 2 | 7 个首层入口 | 攻击、生命、冷却、暴击、维修等；同时承担突破配方组件 |
| 武器分支 | BranchSurvivorGroup / Type 4 | 57 条 | 主武器升级时出现的局部改造，如加攻击、加弹道并带副作用 |
| 深层强化/突破 | UpgradeSurvivorGroup + UpgradeSkillGroup / Type 3 | 111 + 22 条 | 武器深层强化，以及满足“武器节点 + 指定模块”后的突破入口 |

这意味着 Build 不是简单的“武器升 5 星”。一把武器从首次获得到成型，至少同时经过 **主线等级、分支词条、配套模块、突破/深层强化** 四种选择关系。

## 一把武器的真实成长链：以速射机炮为例

速射机炮首层 `10000101` 是真正的“获得武器”。之后 `10000102`、`10000103`……仍然属于同一武器主线，并通过 `NextSkill` 连成连续等级。

从第二层开始，这些主线节点的 `IsUpgrade=2`，同时挂有 `UpgradeSkillId`。例如：

- 2 星节点可挂接 10400101 / 10400102 / 10400105；
- 3 星节点可挂接 10400111 / 10400112；
- 10400101 是“攻击力提高”；
- 10400111 是“正向子弹 +1，但攻击力下降”的取舍型分支。

native 的 `WeightRandom.RandomOneSubSkillByParent` 会读取父节点的 `UpgradeSkillId`，再通过 `GameUtils.CheckCanStudySkill` 过滤，最后从符合条件的分支中继续随机。因此“武器升级”并不是每次只有固定的线性数值，而是主线推进时还会嵌入一次归属武器的分支选择/随机。

这类设计比单纯“武器 +1 星”多了一层局内差异：即使两局都拿到速射机炮，实际弹道、攻击和副作用组合也可能不同。

## 突破不是凭空随机，而是武器节点 + 模块配方

突破关系可以从配置直接看到。例如速射机炮的 3 星节点 `10000103` 指向暴击模块 `11000701`，满足后可以解锁 `10500101` 的“武器突破”。

反过来看暴击模块，它同时写着：

- 灼热射线达到 10001703 → 解锁 10501701；
- 速射机炮达到 10000103 → 解锁 10500101。

类似关系还有：

- 生命模块：服务 10000303、10001603 对应武器突破；
- 攻击模块：服务 10000403、10001103；
- 冷却模块：服务 10001503；
- “缩小！”模块：服务冰刃弹 10000603 和另一武器 10000203；
- 维修强化：服务 10000903、10000703。

因此这里确实存在类似幸存者类常见的 **“主武器 + 配套被动 → 进化/突破”** 结构，但不是一条被动只绑定一把武器。模块被设计成可以服务 1～2 条武器路线，这会让一次模块选择同时保留多个潜在 Build 出路，降低早期选错导致死局的概率。

## 动态权重的公式已经可以坐实

`HeroComponentRandomSkill` 在初始化时会执行 `GroupSkillsByType`，按 `Skill_Main.SkillType` 建立分组，并维护 `_learnedSkillCountsByType`。每次技能加入或移除都会更新对应类型的已学数量，然后重新计算这一类型的权重修正。

`GetDeltaWeightPercent(skillType)` 的 native 逻辑等价于：

```
count = GetSkillCountByType(skillType)
delta = min(AddWeightPerSkill * count, AddWeightMax)
return delta / 100
```

标准 Type 1 的配置为：

```
AddWeightPerSkill = 50
AddWeightMax      = 500
```

底层 `WeightRandomData.PracticalWeight` 又明确做了：

```
practicalWeight = baseWeight * (1 + deltaWeightPercent)
```

因此基准倍率是：

| 已计入的 Type 1 学习数 | delta | 实际基础权重倍率 |
|---:|---:|---:|
| 0 | 0% | 1.0x |
| 1 | +50% | 1.5x |
| 2 | +100% | 2.0x |
| 3 | +150% | 2.5x |
| 5 | +250% | 3.5x |
| 10+ | +500% | 6.0x |

这是很强的随机修正，不是轻微“保底”。随着玩家不断选择 Type 1 武器主线/后续节点，符合 Type 1 的可用候选相对基础权重会被显著放大。

但必须强调：**这是类型级，不是具体武器家族级。** 当前证据不支持“拿冰刃弹后，冰刃弹自己就 +50%”；更准确的说法是“随着武器类投入增加，武器类可用候选的整体相对权重提高”。具体某把武器能否出现，仍然受当前已学状态、NextSkill、NeedSkill、Reject、Flag、最大次数等条件过滤。

## 为什么要做这么强的类型加权

如果完全均匀随机，局内 18 个首层入口、后续主线、57 个武器分支和大量深层强化混在一起，玩家很容易连续数波拿不到可以让输出质变的东西。第一章只有约 15 次基准升级机会，随机浪费两三次已经会显著影响 W10 精英和 W15 Boss。

类型级加权提供的是“方向惯性”：玩家一旦把越来越多选择投入武器成长，后续候选不会持续被通用模块稀释。它不会替玩家锁死某一把武器，因此仍保留转向和混搭；但它会提高“继续获得可产生战斗变化的武器成长项”的概率。

从策划目的看，这是一种介于完全随机与定向卡池之间的方案：玩家仍然觉得自己在 Roguelike 三选一，但系统背后主动压低“十几次选择后 Build 还没长出来”的尾部坏体验。

## 三选一为什么不是一次随机

`WeightRandom` 的方法集合已经把候选构造拆得很明确：

- `GetAlreadyStudySkill`：处理已经学过、仍可继续成长的候选；
- `GetReadyStudySkill`：处理当前满足条件、可以首次/继续学习的候选；
- `GetOneStarSkill`：单独处理一星入口；
- `RandomOneSubSkillByParent`：当父节点需要分支升级时，从其归属子技能中再筛选一次；
- `GetRandomCount`：按权重抽多个候选，并维护去重/排除；
- `UpdateWeightPercent`：批量更新指定技能集合的动态倍率；
- `BoostWeightByPercent / RevertWeightBoost`：存在“临时提高权重 → 抽取 → 恢复”的一次性修正机制。

`HeroSkillCreator.GetRandomSkills` 还会先在多个 WeightRandom 池之间按池权重做一次选择，再到选中的池中抽取实际技能。这进一步说明 UI 上看到的 3 张牌，背后不是一个扁平列表。

因此更合适的策划模型是：

**先决定“本次候选应该从哪类东西里出” → 再决定“这一类里具体出哪条” → 再根据当前 Build 做可学性和互斥校验。**

## 前置、互斥与 Flag 是硬约束，不只是降权

`Skill_Main` 和 `WeightRandomData` 同时存在 `NeedSkills`、`RejectSkills`、`SkillFlag`、`NeedFlag`、`RejectFlag`，而 `WeightRandom` 初始化与筛选路径会把这些条件加入候选数据。它们与动态权重不是一回事：

- 动态权重解决“符合条件的东西之间谁更容易出现”；
- Need/Reject/Flag 解决“这个东西此刻有没有资格进入随机池”。

所以某个高级强化不出现，可能不是“脸黑”，而是尚未满足结构性前置；某两个机制也可以通过 Reject/Flag 被彻底隔离，避免生成不兼容 Build。

## 新玩家保护与刷新也是额外一层

`SinglePlayerSkillCreator.GetNormalSkill` 能看到 `NewPlayerBoostRecord` 路径：抽取前对目标权重调用 `BoostWeightByPercent`，抽完后再 `RevertWeightBoost`。这意味着系统支持只影响一次候选生成的临时扶正，而不会永久污染基础池。

`HeroComponentRandomSkill.RandomSkill` 还显式区分 `isRefresh`，并把刷新状态传入正常技能生成链。当前证据足以确认“刷新不是简单重新调用同一个无状态 random()”；它可以在同一套候选构造器里识别刷新场景。刷新是否对同一批候选有额外排除、两选一/三选一保护的精确概率，仍需要继续追对应概率配置和 hotfix 分支，现阶段不把具体数字写死。

## 和第一章节奏合起来看，Build 什么时候成型

第一章基准设计是每波经验预算对应一个等级阈值，W10 前理论上已经经历约 9～10 次成长决策，W15 前约 14～15 次。再结合武器突破要求“武器达到特定节点 + 对应模块”，可以看出两个硬节点承担了很明显的 Build 检查职责：

- W5：玩家只有约 4～5 次选择，系统用密度峰检查“有没有形成最初战斗方向”，但不锁死进度；
- W10：约 9～10 次选择后第一次精英硬门槛，检查主输出链有没有推进；
- W15：约 14～15 次选择后 Boss 硬门槛，检查主武器、分支、模块和突破的组合是否真正成型。

这比简单“每 5 波提高一次怪物数值”更重要：**敌人节奏节点与 Build 决策次数是一起编排的。**

## 当前已确认、仍待继续确认的边界

已确认：候选按类型分组；已学数量按类型统计；Type 1 每次 +50%、最多 +500%；实际权重公式为 base × (1+delta)；武器主线从 2 星起可挂分支；突破存在武器节点 + 模块前置；候选生成有已学/待学/一星/父子技能、Need/Reject/Flag、临时 Boost 和刷新上下文。

尚未写死：UI 最终显示 2 个还是 3 个候选时，各场景的精确概率；`randomSkillFactor` 在所有 hotfix 分支中的最终解释；刷新是否明确禁止上一屏全部重复；质量/星级提升在每个关卡等级的精确概率。这些应作为下一轮 native 深挖点，而不是用字段名猜结论。

## 证据位置

- `restored/configs/tables/SkillGroup_SurvivorGroup.json`
- `restored/configs/tables/SkillGroup_BranchSurvivorGroup.json`
- `restored/configs/tables/SkillGroup_UpgradeSurvivorGroup.json`
- `restored/configs/tables/SkillGroup_UpgradeSkillGroup.json`
- `restored/configs/tables/Skill_SkillTypeWeight.json`
- `restored/configs/tables/Skill_Main.json`
- `gameplay/skills-readable.json`
- `restored/code/gameplay-structures/HeroComponentRandomSkill.cs`
- `restored/code/gameplay-structures/WeightRandom.cs`
- `restored/code/native-evidence/HotFix.BattleLogic.HeroComponentRandomSkill.asm`
- `restored/code/native-evidence/HotFix.BattleLogic.WeightRandom.asm`
- `restored/code/native-evidence/HotFix.BattleLogic.WeightRandomData.asm`
- `restored/code/native-evidence/HotFix.BattleLogic.HeroSkillCreator.asm`
- `restored/code/native-evidence/HotFix.BattleLogic.SinglePlayerSkillCreator.asm`

关键 RVA 与伪代码索引见 `research/in-run/evidence/native-key-paths.md`。
