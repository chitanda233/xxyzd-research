# 三选一随机机制：品质池、候选合法性与 Build 收敛

## 当前结论

普通主线升级的三选一已经可以还原到比“加权随机”更具体的一层。

主线每次升级明确需要给出 3 个候选，配置 `MainChapterRandomSkillCount = 3`。普通技能品质权重是 `RandomSkillWeight = {40,40,20,0}`，但这四个权重**不是三张牌分别独立掷一次品质**。客户端会先为本次整组三选一只做一次品质抽取，得到一个起始品质档，然后优先从这个品质档对应的 `WeightRandom` 池中一次抽满 3 张；只有该品质池当前合法候选不足 3 张时，才按后续品质池轮转补齐。

因此一次三选一通常会呈现明显的“整组同品质”倾向，而不是三张牌的品质完全独立。如果抽中的品质档候选不足，才会混入其他品质。

刷新也不是重新完整抽一次：`GetRandomSkills` 在 `isRefresh=true` 时会复用上一次保存的品质索引，因此**刷新保留品质档，只重抽该档及其补位结果**。若 `qualityUp=true`，则会把本次选中的品质索引向上提升一档后再抽。

普通主线的 `40/40/20/0` 也不是永远原样使用。`HeroComponentRandomSkill.GetNormalSkill` 会先复制这组基础权重，然后读取玩家 `AttributeData` 中的一个“高品质技能”修正值；只要该 FP 值为正，就令 `factor = 1 + attr`，并把第 2、3 个品质档的权重分别乘以这个 factor 后四舍五入，第 1、4 档保持不变。属性表里与这一行为直接对应的是 `ExHighSkillRate%`（“获得更高品质技能几率”，id=110）。另外，`CheckQualityUp` 还有一条独立的概率判定，会在成功时直接把本轮整组三选一的起始品质上移一档；属性表中对应语义的是 `LevelUpSkillUpRate%`（“升级提升品质概率”，id=126）。由于当前 native 导出对这两个静态字符串引用没有符号名，属性名映射属于“native 行为 + 属性表语义”的高置信对应，而不是字符串地址级硬符号证明。
普通主线还存在一个独立的“初始技能池”机制。运行时检查 `BattleData.InitSkillGroupCount`；计数大于 0 时使用 `_initRandoms`，完成抽取后计数减 1，否则使用普通 `DefaultRandoms`。配置 `UseInitSkillGroupCout = 1`，从策划意图上对应“首轮使用一次定制初始池，之后转普通池”。当前静态证据已经证明计数消费逻辑和配置值，但尚未补齐“战斗初始化时把这个 Const 写入 BattleData”的直接 native 调用，因此这里仍保留一层证据边界。

另一个重要修正是：`Exp_exp.randomSkillFactor = [1/2,40,40,20]` **不是普通主线三选一的品质权重**。普通分支在 `HeroComponentRandomSkill.GetNormalSkill` 中使用的是 `Const.RandomSkillWeight`，并把 `randomSkillFactor` 以 null 传入；`Exp_exp.randomSkillFactor` 只在 Danke/特殊技能路径中被读取。不能再用这四个数解释普通三选一的槽位构成。

最后，客户端确实设计了“同 SkillType 越学越增权”的动态 Build 收敛模型：每学一个同类型技能计划 +50%，最高 +500%。但当前 1.0.16 APK fallback 中，负责把这个增量真正写回组内候选的 `AdjustWeightsForSkillGroup` 是空实现。因此这套机制的**公式与设计意图已证实，APK 基线实际生效未证实**；线上热修若覆盖该函数，则可能启用。

## 一、普通三选一不是三张牌各自独立抽品质

关键常量来自 `Consts_Const`：

| 配置 | 值 | 含义 |
|---|---:|---|
| MainChapterRandomSkillCount | 3 | 主线升级一次给 3 个技能 |
| SkillQualityCount | 4 | 4 个品质档 |
| RandomSkillWeight | 40 / 40 / 20 / 0 | 普通技能品质权重 |
| UseInitSkillGroupCout | 1 | 初始技能库使用次数 |

`HeroComponentRandomSkill.GetNormalSkill` 在普通模式下会先把 `Const.RandomSkillWeight` 复制到自己的 `_skillWeights`，然后把这组权重交给 `SinglePlayerSkillCreator.GetNormalSkill`，最终进入 `HeroSkillCreator.GetRandomSkills`。

`GetRandomSkills` 的 fallback 逻辑非常明确：

1. 先把当前 4 个品质权重求和；
2. 只进行一次随机数抽取，决定一个起始品质索引；
3. 若 `qualityUp=true` 且还未到最高档，则把该索引 +1；
4. 从这个品质对应的 `WeightRandom` 中尽量抽够本次所需数量；
5. 如果候选不足，则按 `(起始品质 + i) % 品质数量` 轮转到后续品质池继续补；
6. 已经进入结果列表的技能会参与排重，不能在同一次三选一中重复出现。

所以普通三选一的真实模型更接近：

`抽一次整组品质 → 该品质池内按技能权重抽 3 张 → 不足再跨品质池补位`

而不是：

`第1张抽品质 → 第2张抽品质 → 第3张抽品质`

这是一个很重要的策划差异。前者会让一次三选一的品质表现更“成组”，同时还能通过品质池容量自然产生混合结果。

## 二、刷新保留品质，品质提升直接推高整组三选一档位

`HeroSkillCreator.GetRandomSkills` 接收一个 `ref randomIndex`。

正常首次抽取时，它会按照 `skillWeights` 重新随机品质，并把结果写回 `randomIndex`。但 `isRefresh=true` 时，不重新做这次品质骰，而是直接复用此前保存的 `randomIndex`。

因此刷新本质上是“在相同品质框架下重抽候选”，而不是重新购买一次完整的品质概率。

`qualityUp` 也不是把单张牌变高品质，而是在初始品质抽出后，如果还有上升空间，直接把整组起始品质提高一档。随后同样从这个提高后的品质池中尽量抽满 3 张。

这意味着游戏可以把“刷新”和“品质提升”设计成两种非常不同的玩家预期：

- 刷新：换牌，但大体保持这轮品质；
- 品质提升：直接抬高整组三选一的品质起点。

## 三、40 / 40 / 20 还会被“高品质出现率”二次修正

普通主线进入技能创建器之前，`HeroComponentRandomSkill.GetNormalSkill` 会先把 `Const.RandomSkillWeight` 复制到自己的临时权重数组。基础值是 `40 / 40 / 20 / 0`。

随后它从当前角色的 `AttributeData` 读取一个 FP 属性。如果该值大于 0，则计算 `factor = 1 + attr`，然后只修改第 2、3 个品质档：`weight[1] = round(weight[1] × factor)`，`weight[2] = round(weight[2] × factor)`。第 1 档和第 4 档不变。也就是说，这个属性不是“额外再掷一次高品质”，而是直接改变整组品质骰的权重分布。

属性表中最直接对应这一行为的是 `ExHighSkillRate%`（id=110，中文备注“获得更高品质技能几率”）。例如该属性若为 +25%，临时品质权重会从 `40/40/20/0` 变成约 `40/50/25/0`，之后再按新的总权重做一次整组品质抽取。

这与 `CheckQualityUp` 是两个不同层级。后者读取另一条概率属性，成功后直接把已经抽到的整组起始品质向上推一档，更接近“升级时触发品质提升”。属性表里 `LevelUpSkillUpRate%`（id=126，中文备注“升级提升品质概率”）与其语义吻合。

因此普通三选一的品质控制至少有三层：`基础品质权重 40/40/20/0 → 高品质出现率属性重分配第 2、3 档权重 → 只抽一次整组起始品质 → 若 QualityUp 成功，再整体上移一档`。

需要保留一个很小的证据边界：native 里传给 `AttributeData.GetAttributeValueOrDefault(string)` 的静态字符串对象没有被当前反汇编器恢复成符号名，所以“id=110 / id=126”的名称对应来自行为语义与属性配置表的强匹配；计算行为本身则由 native 完整坐实。

## 四、每个品质档本身都是独立的加权候选池

`HeroSkillCreator.AddSkillGroupToNormalRandom` 会读取 `Skill_Main.Quality`，把 `Quality - 1` 转成对应的品质索引，并将技能加入该索引下的 `WeightRandom`。

所以 `DefaultRandoms` 和 `_initRandoms` 都不是“已学技能池 / 新技能池”这样的三槽结构，而是**按品质切分的 WeightRandom 数组**。

进入某个品质池之后，底层 `WeightRandom.GetRandom` 才根据每个候选自己的权重做加权随机。也就是说抽取至少分两级：

`品质权重`
→ 选定起始品质池
→ `技能自身权重`
→ 从该品质池中选具体技能

这也解释了为什么同一品质内仍然可以有明显不同的出现频率。

## 五、候选池会根据已学技能、前置和升级分支动态变化

品质只决定“去哪个池抽”，但池里当前有哪些合法技能，会随 Build 状态变化。

客户端存在并实际使用的候选处理能力包括：

- 已学习技能继续升级；
- 尚未学习但已经满足前置条件的技能进入候选；
- 一星/起始技能作为新成长线；
- 达到最大星级后不再继续作为普通升级项；
- 排斥技能、NeedSkill、SkillFlag 等条件过滤；
- 一个父技能存在多个子升级分支时，通过 `RandomOneSubSkillByParent` 在当前合法分支中只随机一个，而不是把所有分支同时塞进三选一。

`WeightRandom.GetRandomCount` 还会把本次已经抽到的结果作为排重条件继续抽取，所以同一张卡不会在同一组三选一里重复占位。

因此 Build 收敛首先来自**候选合法性变化**，并不依赖“同类型增权”才能成立。玩家学到一个技能后，升级链、前置解锁和分支结构都会改变后续池子的组成。

## 六、首轮存在独立 Init 池

`HeroSkillCreator` 同时维护：

- `_initRandoms`
- `DefaultRandoms`

`SinglePlayerSkillCreator.GetNormalSkill` 默认先取 `DefaultRandoms`。但如果 `BattleData.InitSkillGroupCount >= 1`，就切换到 `_initRandoms`，并在本次抽取前把该计数减 1。

配置里恰好有：

`UseInitSkillGroupCout = 1`

因此从设计结构看，游戏明确准备了一次“初始技能组专用抽取”，之后才进入长期普通池。这种机制非常适合控制第一轮三选一：既可以让玩家较快拿到可用主技能，也能减少开局抽到意义不大的进阶项。

这条链现在又多补了一层结构证据：`BattleData` 明确把 `InitSkillGroupCount` 作为独立字段保存，`BattleSaveData` 也有 `initSkillGroupCount`，说明它会跟随局内存档持久化；`BattleWorldContext` 还专门暴露了 `get_InitSkillGroupCount()`、`DoInitSkillGroup()` 和 `DoInitSkillGroupCount(int count)`。因此它不是偶然复用的内存槽，而是一个有完整生命周期的首轮技能池计数。需要保留的最后证据边界仍然是：当前已保存的 native 函数集中，还没有抓到初始化阶段调用 `DoInitSkillGroup*` 并把 `Const.UseInitSkillGroupCout=1` 写进去的调用者。因此最终正文可以写“首轮定制池机制存在、配置目标为一次，并有专门运行时计数与存档字段”，但不要写成“初始化赋值调用已完整证明”。

## 七、新手保护是真正生效的临时概率修正

相比同 SkillType 动态增权，新手保护的 native fallback 是完整的。

配置：

- `NewPlayerProtect_SkillDefault = 10000101`
- `NewPlayerProtect_SkillDefault_SkillUp = {"10000101|10","10000601|10","10001701|10"}`

当满足前期保护条件、且玩家还没有目标默认技能时，`SinglePlayerSkillCreator.GetNormalSkill` 会解析这组 `技能ID|百分比`，遍历当前品质随机池，对对应技能调用：

`WeightRandom.BoostWeightByPercent(skillId, percent)`

这里 10 就是临时 +10% 基础权重。抽取完成后，客户端记录每次真实增加的整数权重，并逐条调用：

`RevertWeightBoost(skillId, increment)`

把权重恢复。

所以这是非常明确的“只影响这一轮抽取”的保护机制，不会永久污染后续权重。

从策划角度看，这说明游戏的随机并非追求纯随机，而是允许为了前期体验对特定核心技能做轻量保底倾斜。

## 八、Exp_exp.randomSkillFactor 不属于普通主线三选一

`Exp_exp.randomSkillFactor` 的前几级形如：

- Lv1：[2,40,40,20]
- Lv2：[1,40,40,20]
- Lv3：[2,40,40,20]
- Lv4：[1,40,40,20]

它很容易被误解成“普通三选一的四类槽位权重”，但 native 调用链否定了这个解释。

普通主线 `HeroComponentRandomSkill.GetNormalSkill`：

- 使用 `Const.RandomSkillWeight`；
- 将 `randomSkillFactor` 参数置为 null；
- 再进入普通 `SinglePlayerSkillCreator.GetNormalSkill`。

只有 Danke/特殊技能分支会读取当前等级对应的 `Exp_exp.randomSkillFactor` 并传给技能创建器。

因此当前可以确定：

**普通主线品质权重 = 40 / 40 / 20 / 0。**

而 `Exp_exp.randomSkillFactor` 属于特殊技能路径，具体四个数在 Danke 机制里各自代表什么，还需要单独继续拆，不能混入普通三选一结论。

## 九、同 SkillType 动态增权：公式成立，但 APK fallback 未落地

`Skill_SkillTypeWeight` 中有效 SkillType 基本统一为：

- `AddWeightPerSkill = 50`
- `AddWeightMax = 500`

`HeroComponentRandomSkill.GetDeltaWeightPercent(skillType)` 会按照当前已学习的同类型技能数计算：

`delta = min(learnedCount × 0.5, 5.0)`

底层 `WeightRandomData` 的实际权重结构也支持：

`PracticalWeight = BaseWeight × (1 + delta)`

如果机制启用，则理论效果为：

| 同类型已学数量 | 计划动态增权 | 实际权重倍率 |
|---:|---:|---:|
| 0 | 0% | ×1.0 |
| 1 | +50% | ×1.5 |
| 2 | +100% | ×2.0 |
| 3 | +150% | ×2.5 |
| 5 | +250% | ×3.5 |
| 10+ | +500% | ×6.0 |

问题仍然出在最后一步。

调用链已经存在：

`AddSkill`
→ `UpdateLearnedSkillCount`
→ `GetDeltaWeightPercent`
→ `AdjustWeightsForSkillGroup`

但 `AdjustWeightsForSkillGroup` 的 RVA `0x686A17C` 在当前 APK fallback 中直接返回，没有遍历技能组，也没有调用已经存在的 `WeightRandom.UpdateWeightPercent`。

因此最准确的结论仍然是：

> 客户端已经设计并计算了“同类型越学越容易出”的 +50%/次、+500% 封顶模型，但 1.0.16 APK 基线中负责应用它的 fallback 是空实现。它可能是 dormant/遗留逻辑，也可能依赖运行时热修覆盖；在拿到线上热修或实机统计前，不能作为已生效规则写死。

## 十、策划视角下，当前三选一可以还原成什么

普通主线的一次成长选择，可以暂时还原为：

`波末达到升级条件`
→ 使用普通池或一次性的 Init 池
→ 根据 40 / 40 / 20 / 0 **只抽一次整组品质**
→ 若有 QualityUp，则品质上移一档
→ 进入该品质的加权技能池
→ 按当前已学状态 / 前置 / 排斥 / 升级分支过滤合法候选
→ 从池内按技能自身权重无重复抽取
→ 尽量拿满 3 张
→ 当前品质不足 3 张时轮转其他品质补齐
→ 展示三选一
→ 玩家选择并改变后续候选池结构

其中还叠加两种概率修正：

第一种是**已经确认实际工作的短期修正**：前期新手保护会临时给特定核心技能 +10%，抽完立即撤销。

第二种是**已经确认设计但 APK fallback 未落地的长期修正**：按已学习 SkillType 数量给同类技能 +50%/个、最高 +500%。

这比最初“已有 Build 会不会因为同类型权重越来越高而自然成型”的假设更完整。当前版本即使不依赖那条 dormant 动态增权，也已经通过“初始池 + 品质整组抽取 + 合法候选重构 + 前置/升级链 + 新手保护”对随机结果进行了相当多的结构化控制。

## 十一、还需要继续验证什么

普通主线三选一的核心框架已经基本够写入《局内核心循环反拆》。剩下优先级最高的未决点只有三类：

1. 找到 `BattleData.InitSkillGroupCount` 初始化赋值链，彻底坐实 `UseInitSkillGroupCout=1` 与首轮 Init 池的直接连接。
2. 继续追 `ExHighSkillRate%` / `LevelUpSkillUpRate%` 的具体来源技能、Buff、角色或局外养成入口；品质权重的 native 计算公式已经坐实，剩下是“谁能提供这些属性”。
3. 如果要研究特殊技能系统，再单独拆 Danke 路径中的 `Exp_exp.randomSkillFactor`；它不应继续阻塞普通主线核心循环报告。

对于最终策划报告而言，现在已经可以把普通主线三选一写成确定规则；只有“同 SkillType 动态增权是否线上启用”需要继续标成待验证。
