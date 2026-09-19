# 三选一动态随机机制反拆

## 1. 当前结论

动态随机不是“纯随机三张”，而是明显包含**按技能类型分组 + 记录已学习数量 + 按类型重新计算权重**的机制。最关键的 native 证据来自 `HeroComponentRandomSkill.GetDeltaWeightPercent`：函数会先按 skillType 查询 `Skill_SkillTypeWeight`，再调用 `GetSkillCountByType` 获取该类型当前已学习数量，随后用“每学一个技能增加的权重”乘以学习数量，并与一个上限值比较，最终取较小值。

从 ARM64 算术可以还原出核心公式的结构：

```text
deltaWeightPercent = min(
    learnedCountOfThisType × AddWeightPerSkill,
    AddWeightMax
)
```

配置中主流项正是 `AddWeightPerSkill = 50`、`AddWeightMax = 500`，因此策划上可理解为：**玩家越往某个技能类型投入，这个类型后续在随机池中的权重增幅越大，但最多加到 +500 的封顶。**

这已经把之前的“同类 Build 可能越抽越容易成型”从假设提升为可以写进报告的结论。

## 2. 它不是简单给单张卡加权，而是“类型组”层面的动态偏置

初始化阶段会先 `GroupSkillsByType`，然后 `RecalculateAllWeight`。玩家获得技能后，`UpdateLearnedSkillCount` 对对应 skillType 的计数 +1；移除技能时，`DecreaseLearnedSkillCount` 做 -1。随后系统可以根据新的类型计数重新算权重。

因此更准确的策划描述是：**系统先把可抽技能按类型组织成组，再根据玩家当前 Build 中各类型的投入程度，对相关技能组进行动态权重修正。** 这不是简单的“已经学过某一张技能，就只提高那一张的概率”，而是对“同类型后续发展”提供趋势性扶持。

## 3. 设计目的

这个机制解决的是随机 Build 游戏里最典型的问题：完全独立随机会造成大量“已经走火系却一直来冰系”的无效选择，Build 难以成型；如果直接锁池，又会让随机性过低。这里采用的是中间方案：**保留其它类型继续出现的可能，但让已经投入的类型逐步获得更高权重。**

如果按 50/500 理解，一个类型学习 1、2、3……个技能时，理论增量依次为 +50、+100、+150……，到 +500 封顶。也就是说它是一个线性增长、硬上限的“软引导”机制。

## 4. 与三选一其它规则的关系

`GetNormalSkill`、`FillNormalSkill`、`GetAlreadyStudySkill`、`GetReadyStudySkill`、`GetOneStarSkill`、`RandomOneSubSkillByParent` 等函数说明最终候选生成仍然有多层约束：是否已学习、是否满足前置、星级/子技能关系、父子技能关系等。动态权重只是其中一层，并不意味着所有同类型技能都无条件进入候选池。

所以最终策划规则应写成：**先做合法候选过滤，再在合法候选/技能组之间使用动态权重进行抽取，最后填满三选一。** 不能把机制简化成“同类技能必出”。

## 5. 当前证据强度

**已坐实：**存在按 skillType 分组；存在每类型已学习数量计数；获得/移除技能会增减该计数；`GetDeltaWeightPercent` 使用 Skill_SkillTypeWeight 配置与该类型学习数量计算增量，并做最大值封顶；初始化和后续都有重新计算权重的路径。

**高概率：**动态权重的直接效果就是提高已投入类型后续技能组的抽取概率，从而让 Build 更容易沿既有方向继续成型。

**待补证：**`AdjustWeightsForSkillGroup` 的具体落点是接口/虚调用，当前导出的 native 片段不能直接看到所有组内成员如何分摊这个增量；`BoostWeightByPercent` / `RevertWeightBoost` 还可能承担临时性增益。后续如果要写概率模拟器，需要继续还原 WeightRandom 内部最终权重归一化与无放回抽取细节。

## 6. 对《局内核心循环反拆》的意义

把它与“每波≈升一级”合在一起后，第一章的成长体验就非常清楚了：**每完成一波，玩家获得一次技能选择；每次选择又会改变后续技能类型的权重；因此 Build 不是 15 次彼此独立的随机，而是一个逐步自强化的随机过程。** 玩家越早确定方向，后续越容易继续成型，这正是第一章能在有限 15 次成长里快速让玩家感受到“Build 成形”的关键。
