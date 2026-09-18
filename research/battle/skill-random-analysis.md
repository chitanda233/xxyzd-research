# 三选一随机机制：技能类型权重与 Build 收敛性

> 研究对象：客户端 1.0.16 / versionCode 40。结论基于静态配置、C# 结构和 IL2CPP ARM64 native。当前没有运行线上热更新，因此“APK fallback 实现”与“线上实际热修实现”必须分开描述。

## 当前结论

三选一并不是一个简单的“从所有技能里等概率抽 3 个”。客户端存在完整的加权随机容器 `WeightRandom`，每个候选项有权重，抽取时按总权重做随机区间命中；技能还带前置、排斥、升级分支等规则，候选池会随玩家已经学会的技能发生变化。

但此前最值得怀疑的那条机制——**“学了某一 SkillType 后，该类型后续出现率每次 +50%，最多 +500%”**——目前必须做一个重要修正：

> **配置和计算骨架已经被完整写进客户端，但 APK 自带的 native fallback 并没有真正执行这一步权重调整。**

也就是说，现阶段可以证明“设计上准备了同类型 Build 收敛权重”，却不能证明“1.0.16 APK 的基线逻辑里它实际生效”。它可能是未启用/遗留机制，也可能依赖运行时热修覆盖；在拿到线上热更实现或做实机统计前，不能把它写成已生效规则。

## 一、基础抽取确实是加权随机，不是等概率

`WeightRandom` 保存：

- 当前候选数量；
- 所有候选的 `WeightRandomData`；
- 所有候选当前权重之和 `_allWeight`。

`WeightRandom.GetRandom` 会先在总权重范围内取随机数，再逐项减去候选的实际权重，落在哪个区间就返回哪个技能 ID。这个结构本身已经足够证明三选一底层是**权重随机**。

`RecalculateAllWeight` 会重新遍历所有候选，把每个 `WeightRandomData.Weight()` 累加回 `_allWeight`。因此候选权重一旦发生变化，后续随机概率会真实改变。

客户端还实现了 `BoostWeightByPercent(id, percent)` 和 `RevertWeightBoost(id, increment)`：前者按 `BaseWeight × percent / 100` 算出整数增量，临时加到候选基础权重并同步更新总权重；后者再把同一增量撤销。这说明“临时提高某个候选的命中概率”是底层抽取器确实支持并执行的能力。它和上面的 SkillType 动态百分比是两套不同层次的机制：前者在 APK fallback 中有真实实现，后者的组级写回则停在空函数。

## 二、候选池会随已学技能变化，因此 Build 本身并非完全无记忆

`HeroComponentRandomSkill` 会维护两份关键状态：

- 每个 SkillType 包含哪些技能；
- 每个 SkillType 当前已经学习了多少个技能。

`GroupSkillsByType` 会遍历可用技能，并按照技能类型建立分组；`UpdateLearnedSkillCount` 在学到技能时对对应类型计数 +1，移除技能时也有对应的递减逻辑。

与此同时，`WeightRandom` 本身存在独立的候选重建函数：

- `GetAlreadyStudySkill`
- `GetReadyStudySkill`
- `GetOneStarSkill`
- `RandomOneSubSkillByParent`

这些函数会读取技能配置、当前权重、最大星级、升级分支、前置技能与排斥关系，再重新构造可抽候选。虽然当前静态调用链里部分调用经过间接分发，尚未把“三张牌分别优先占几个槽”的完整顺序还原出来，但至少可以确定：**抽取池不是每次从固定全集重新等概率抽取，而是会根据已学状态和技能进阶关系变化。**

因此，即便下面讨论的“同类型额外增权”在 APK fallback 中没有落地，Build 仍可能因为“已有技能升级、前置解锁、分支技能、排斥关系”自然出现一定程度的连续性。

进一步读 `GetAlreadyStudySkill / GetReadyStudySkill / GetOneStarSkill / RandomOneSubSkillByParent` 可以确认，候选池至少存在几类明确的结构化子池，而不是把所有合法技能混成一桶：

- `GetAlreadyStudySkill` 从当前抽取器中重新筛出已经进入玩家 Build、仍可继续成长的技能，并重新按原权重加入临时池；达到最大星级的项目不会继续作为普通升级项无限出现。
- `GetReadyStudySkill` 筛出尚未正式进入 Build、但前置/可学习条件已经满足的技能。
- `GetOneStarSkill` 单独构造一星/起始层候选，用于给玩家开启新的成长线。
- `RandomOneSubSkillByParent` 在父技能存在多个可升级分支时，不是把所有子技能同时塞进最终结果，而是先检查分支是否可学、是否被禁用/重复，再从合法子分支中抽一个。

因此三选一的“续已有 Build”和“开新 Build”并不是只靠动态权重完成的；**候选池结构本身就在主动区分已有成长线、可开启新线和分支升级。** 目前还没有把三张牌各自固定占几个槽完全还原，所以不能写成“必定一张旧技能 + 两张新技能”这类过度结论。

## 三、配置明确准备了“同类型越学越容易出”的参数

`Skill_SkillTypeWeight` 一共 24 行，其中有效 SkillType（1、100～120）全部使用同一组参数：

| 参数 | 配置值 | native 运行值 |
|---|---:|---:|
| AddWeightPerSkill | 50 | 0.5 |
| AddWeightMax | 500 | 5.0 |

两个 `id=0` 的占位行是 0/0。

`HeroComponentRandomSkill.GetDeltaWeightPercent(skillType)` 的 native 实现会：

1. 根据 SkillType 取得 `Skill_SkillTypeWeight`；
2. 读取该类型当前已学习数量；
3. 把 `AddWeightPerSkill` 从整数百分制转成 FP；
4. 计算“已学数量 × 单个增量”；
5. 再和 `AddWeightMax` 比较取较小值。

因此公式可以直接还原为：

`delta = min(learnedCount × 0.5, 5.0)`

底层 `WeightRandomData` 还保存了这个动态百分比字段，实际权重计算逻辑是：

`PracticalWeight = BaseWeight × (1 + delta)`

所以如果这条动态写回链在热修层被启用，那么同类型已学 1 / 2 / 3 个时，组内每个候选会分别以自身基础权重的 1.5 / 2.0 / 2.5 倍参与抽取；达到 10 个同类型技能后封顶为 6.0 倍。它是对每张卡自身基础权重的乘法，不会抹平组内原本的稀有度差异。

如果按策划百分比理解，就是：

| 同类型已学数量 | 计划增权 |
|---:|---:|
| 0 | 0% |
| 1 | +50% |
| 2 | +100% |
| 3 | +150% |
| 5 | +250% |
| 10 及以上 | +500% 封顶 |

这不是“看到两个字段名以后猜的”，而是 native 已经实际把两个参数做了乘法和封顶运算。

## 四、但真正写回组权重的函数，在 APK fallback 中是空实现

关键函数是：

`HeroComponentRandomSkill.AdjustWeightsForSkillGroup(int skillType, FP delta)`

它的结构正是理论上应该把上一步算出的 `delta` 应用到该 SkillType 组内候选的位置。

调用链也已经坐实：

`AddSkill`
→ `UpdateLearnedSkillCount(skillType)`
→ `GetDeltaWeightPercent(skillType)`
→ `AdjustWeightsForSkillGroup(skillType, delta)`

移除技能时也存在对应路径：

`RemoveSkillInSTG`
→ 更新已学状态
→ `GetDeltaWeightPercent(skillType)`
→ `AdjustWeightsForSkillGroup(skillType, delta)`

问题在于，`AdjustWeightsForSkillGroup` 的 APK native fallback 在进入实际方法体后**直接恢复寄存器并返回**，没有读取技能分组，没有遍历候选，也没有调用 `WeightRandom.UpdateWeightPercent`。

它只保留了 IL2CPP/热修分发入口：RVA `0x686A17C` 在未命中热修分发时直接恢复寄存器并 `ret`；如果运行时方法被热修替换，才跳到外部实现。也就是说，如果没有热修，这一步确实什么也不做。

这点非常关键，因为客户端其实已经存在一个真正能完成这件事的底层函数：

`WeightRandom.UpdateWeightPercent(int[] skillIds, FP value)`

这个函数会遍历当前候选，在技能 ID 命中传入数组时，把对应 `WeightRandomData` 的权重百分比字段更新成传入值。也就是说，“按技能组批量改权重”的底层基础设施已经写好了。

但在当前保存的 `HeroComponentRandomSkill.asm` 中，没有发现由该类型调整路径直接调用 `WeightRandom.UpdateWeightPercent`；负责把“技能类型 → 一组技能 ID → delta”连起来的正好就是那个空的 `AdjustWeightsForSkillGroup`。

所以证据链停在了最后一步。换句话说，`UpdateLearnedSkillCount` 确实执行了“计数 +1 → `GetDeltaWeightPercent` → 调用 `AdjustWeightsForSkillGroup`”，但 APK fallback 到这里就断了，不能把“函数被调用”误写成“权重已实际修改”。

## 五、这意味着什么

目前最准确的策划表述不是：

> 学某一类技能后，该类技能会越来越容易抽到。

而应该改成：

> 客户端设计了一套“按已学习 SkillType 数量提高同类技能权重”的 Build 收敛机制：每学一个同类技能计划增加 50% 权重，最高 +500%。但 1.0.16 APK 中负责把该增量应用到实际抽取池的 native fallback 是空实现，因此静态客户端只能证明机制意图和参数，不能证明该增权在线上实际生效。

这是一个很有价值的反拆结果，因为它能避免把“配置里存在一套漂亮参数”误写成“玩家实际一定受到这套参数影响”。

## 六、目前可以确定的三选一结构

把“已证实”和“待验证”分开后，三选一可以暂时画成：

`当前已学技能状态`
→ 根据前置 / 排斥 / 升级分支等规则整理候选
→ 候选保留各自基础权重
→ `WeightRandom` 按权重抽取
→ 处理重复、分支子技能和三张牌填充
→ 玩家选择
→ 更新已学技能与类型计数
→ **计算同类型增权 delta**
→ **[APK fallback：未实际应用；运行时热修待验证]**

因此目前已经能确定两层“让 Build 更容易成型”的来源：

第一层是**规则型收敛**：学过的技能会进入升级/分支体系，前置技能解锁后续，互斥技能被排除，候选池不是固定全集。

第二层是**概率型收敛的设计骨架**：客户端准备了同类型 +50%/次、+500% 封顶的增权模型，但是否在线上真正启用仍待验证。

## 七、下一步需要继续验证的点

接下来最值得追的不是继续读配置，而是两件事。

第一，继续把 `RandomSkill → GetNormalSkill` 之后的间接调用还原，确定三张牌在“已学可升级 / 已满足前置 / 一星新技能 / 父技能分支”之间有没有固定槽位、优先级或比例。这样才能真正解释玩家为什么经常看到“续已有 Build”和“开新 Build”同时出现。

第二，如果能取得实际运行时热修或做足够大的实机抽样，再验证 `AdjustWeightsForSkillGroup` 是否被线上实现覆盖。若线上没有覆盖，那么 +50%/+500% 这组配置就是当前版本里的 dormant/遗留机制；若线上覆盖，则可以进一步还原真实的组内增权算法。

在此之前，最终《局内核心循环反拆》里应该把“同类技能动态增权”标成**机制意图已证实、实际生效待验证**，而不能作为确定规则写进正文。
