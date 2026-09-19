# 三选一动态随机机制分析

> 目标：判断《小小远征队》的三选一是否会根据玩家已经学习的技能类型动态改变后续抽取权重，以及具体如何改变。本文只写 native 与配置能够支撑的结论。

## 一、结论

当前已经可以把“完全均匀随机”排除掉。三选一系统维护了按技能类型分组的随机池，并且会记录玩家已经学习的各类型技能数量；这个数量会参与计算一个动态的权重增量，然后应用到对应技能组，最后重算随机池总权重。

核心链路为：

`GroupSkillsByType → UpdateLearnedSkillCount / DecreaseLearnedSkillCount → GetDeltaWeightPercent → AdjustWeightsForSkillGroup → WeightRandom.UpdateWeightPercent → RecalculateAllWeight`

这意味着玩家的既有选择会反过来影响未来抽取分布，系统明确存在 **Build 自强化/收敛机制**。

## 二、权重增量的精确形式

`GetDeltaWeightPercent(type)` 会读取 `Skill_SkillTypeWeight` 对应类型配置，并读取该类型当前已学习技能数量 `count`。从 ARM64 运算可以确认，它计算的是：

**delta = min(count × AddWeightPerSkill, AddWeightMax)**

配置中目前绝大多数技能类型为：

- `AddWeightPerSkill = 50`
- `AddWeightMax = 500`

因此在这些类型上，动态加权是线性的：

- 已学 0 个：+0
- 已学 1 个：+50
- 已学 2 个：+100
- …
- 已学 10 个及以上：封顶 +500

这里的“+50/+500”应理解为该系统内部的权重百分比/权重修正单位，而不是直接写成“抽中概率 +50%”。实际概率还取决于同池其他候选的当前权重和总权重。

## 三、这不是只在初始化时算一次

`UpdateLearnedSkillCount` 对相应类型计数执行 +1，`DecreaseLearnedSkillCount` 执行 -1；移除技能的路径随后又会调用：

`GetDeltaWeightPercent → AdjustWeightsForSkillGroup`

说明这个系统会随玩家实际持有技能变化实时调整，而不是开局根据角色预设一次性决定。初始化阶段则执行：

`InitRandomSkill → GroupSkillsByType → RecalculateAllWeight`

先把候选技能按类型建立分组与权重随机器，再进入运行时增减。

## 四、WeightRandom 的作用

`WeightRandom.UpdateWeightPercent` 会遍历随机项，并对传入的一组目标 ID 更新其当前权重修正；`RecalculateAllWeight` 则重新计算该随机器的总权重。与此同时还存在：

- `BoostWeightByPercent`
- `RevertWeightBoost`

这说明底层随机器本身支持临时权重增益与回滚，不只是静态权重表。

因此从策划角度更合适的描述是：

**游戏先构造若干技能类型池；玩家学到某一类型后，该类型相关候选的权重会随已学数量逐步增加，最高增加到配置上限；系统随后重算权重，使后续三选一更容易继续给出与当前 Build 同类型的成长。**

## 五、它解决的设计问题

如果每次三选一都独立均匀随机，15 波左右的短局内成长很容易出现“什么都来一点，最后没有一个 Build 成型”。本作通过类型权重自强化，把随机从“纯随机”改造成 **带记忆的随机**：

第一次选某个方向只是轻微倾向；连续选择后倾向逐步增强；但由于有上限，它不会无限滚雪球到完全锁池。这种结构在短局里能明显提高“我主动选了一个方向，然后游戏开始配合我把它做出来”的体验。

因此，第一章“一波约一级”和三选一“同类权重递增”其实是一套联动设计：**波次提供固定成长次数，动态权重保证这些有限次数更可能形成可感知 Build。**

## 六、仍需继续补证的细节

当前不建议直接写死的点有三个：

1. **类型的具体语义。** 要把 `SkillType` 映射到策划命名，例如武器系、召唤系、元素系、被动系等，需要继续联表。
2. **AdjustWeightsForSkillGroup 的精确目标集合。** 现在能确认它作用于“某技能类型相关分组”，但还需要把最终传给 `WeightRandom.UpdateWeightPercent` 的 ID 数组完整还原，确认是否包含父技能、子技能、合成链技能。
3. **一次三选一中的去重/保底规则。** `GetAlreadyStudySkill`、`GetReadyStudySkill`、`GetOneStarSkill`、`RandomOneSubSkillByParent` 表明抽卡前还有资格筛选和优先级层，但这些规则应单独拆解，不能简单归为动态权重。

## 七、下一步建议

下一轮可以直接沿两条调用链继续：

`RandomSkill → GetNormalSkill → FillNormalSkill → GetAlreadyStudySkill / GetReadyStudySkill / GetOneStarSkill`

用于还原“三个格子到底按什么优先级填满”。

以及：

`GroupSkillsByType → AdjustWeightsForSkillGroup → WeightRandom.UpdateWeightPercent`

用于把“类型加权”精确到候选技能 ID 列表。这样就可以把三选一写成真正可复用的策划规则，而不只是“有动态权重”这一层。
