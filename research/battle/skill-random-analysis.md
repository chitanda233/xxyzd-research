# 三选一动态随机机制分析

> 目标：确认《小小远征队》的三选一是否会根据当前 Build 动态修正后续抽取权重，而不是把配置字段名直接当成结论。

## 核心结论

“玩家学习某一类技能后，这一类技能后续更容易再次出现”已经有 native 代码支撑，可以从假设提升为机制结论。

系统并不是简单地给“刚选中的那一个技能”永久加权，而是：

**先把技能按类型分组 → 记录玩家当前每种类型学了多少个 → 根据同类已学习数量计算该类型的动态权重增量 → 将增量应用到对应技能组的随机权重。**

因此它是一套典型的 **软 Build 收敛机制**：早期保留随机探索，中期开始偏向已有方向，后期让协同技能更容易继续出现，但仍然保留随机性。

## 动态权重公式已经可以还原

`HeroComponentRandomSkill.GetDeltaWeightPercent` 的 native 实现做了三件关键事：

1. 读取当前技能类型对应的 `Skill_SkillTypeWeight` 配置。
2. 调用 `GetSkillCountByType`，取得玩家当前已经学习了多少个该类型技能。
3. 用“每个已学技能增加的权重”乘以数量，并与最大加权值取较小值。

因此在**配置数值单位**上可以写成：

```text
DeltaWeight(type)
= min(
    LearnedCount(type) × AddWeightPerSkill,
    AddWeightMax
  )
```

当前主要技能类型配置几乎统一为：

```text
AddWeightPerSkill = 50
AddWeightMax      = 500
```

也就是同类型技能每增加 1 个，加权档位增加 50；最多叠到 500，等价于 **10 个同类技能达到该类型的配置上限**。

需要注意，这里的 50/500 会在 native 中转换成内部百分比/定点数表示，所以策划报告不应直接写成“概率 +50% / +500%”。准确的说法是：**每个同类技能增加固定一档相对权重，最多叠 10 档。**

## 类型计数不是静态统计，而是随 Build 实时变化

`UpdateLearnedSkillCount` 维护一个“技能类型 → 已学习数量”的字典：

```text
如果该类型已经存在：
    count += 1
否则：
    count = 1
```

`DecreaseLearnedSkillCount` 做完全相反的事情：

```text
如果该类型存在：
    count -= 1
否则：
    count = 0
```

这意味着动态权重看的是**当前 Build 状态**，而不是玩家历史上曾经选过什么。技能被替换、移除或转化后，类型计数会跟着变化，后续权重也可以重新收敛。

## 初始化时就建立“按类型的随机组”

`InitRandomSkill` 的顺序是：

```text
HeroSkillCreator.InitRandomSkill
→ GroupSkillsByType
→ RecalculateAllWeight
```

因此“按技能类型分组”并不是调试日志或编辑器辅助数据，而是正式随机流程的一部分。系统先建立各类型的候选组，再统一重算权重。

`RecalculateAllWeight` 会遍历内部的多个 `WeightRandom` 组，逐个调用其 `RecalculateAllWeight`，说明最终随机概率是由组内基础权重和动态修正共同组成的，而不是每次临时拼一个完全独立的随机池。

## 权重修正最终落到候选项上

`GetDeltaWeightPercent` 算出某个类型当前应该增加多少权重后，调用链会进入 `AdjustWeightsForSkillGroup`。这个函数本身在当前 native 中表现为分发/虚调用，但底层 `WeightRandom.UpdateWeightPercent` 已经可以确认会：

- 遍历当前候选项；
- 判断候选 ID 是否属于需要调整的集合；
- 对命中的候选写入新的 weight percent。

因此从策划视角可以把它理解为：

**玩家的 Build 状态先转成“类型加权值”，再把这份类型加权分摊/应用到该组中符合条件的候选技能。**

## 这套机制为什么能让 Build 更容易成型

假设一个玩家前几次三选一已经拿了 3 个同类技能，在配置单位里，这一类型就会得到：

```text
3 × 50 = 150
```

的额外权重修正。

如果继续拿到第 4、第 5 个同类技能，加权继续上涨；直到第 10 个同类技能时到达 500 上限，之后不再继续放大。

因此随机体验会呈现这样的趋势：

**前期：方向不明显，允许探索**  
**中期：已有方向开始被系统轻推**  
**后期：Build 越完整，协同项越容易继续出现**  
**封顶后：仍保留其它类型出现的空间，避免完全锁死**

这是一种比“指定技能必出”更柔和的做法。玩家会觉得自己是在随机里逐步做成 Build，而不是系统直接替他决定路线。

## 当前已经坐实的规则

1. 技能会先按类型分组。
2. 系统维护每种技能类型当前已学习数量。
3. 类型计数支持增加和减少，不是只增不减。
4. 动态加权读取 `Skill_SkillTypeWeight`。
5. 在配置单位上，动态增量等于“同类数量 × 每技能增量”，并受最大值封顶。
6. 当前主流配置是 50/500，因此 10 个同类技能达到加权上限。
7. 初始化会统一重算各随机组权重。
8. 底层 `WeightRandom` 可以对指定候选项更新 weight percent。
9. 因此“已有 Build 方向会反过来影响后续三选一概率”不是纯配置推测，而是运行时逻辑。

## 还没有完全解开的部分

动态类型加权已经基本坐实，但“三张卡到底如何组成”仍需要继续追。下一阶段优先级应是：

`RandomSkill`  
→ `GetNormalSkill`  
→ `FillNormalSkill`  
→ `GetAlreadyStudySkill`  
→ `GetReadyStudySkill`  
→ `GetOneStarSkill`  
→ `RandomOneSubSkillByParent`

要回答的不是“它们分别做什么”，而是以下策划问题：

- 三张卡是否优先保证至少一张“已学技能升级”？
- 未学习的一星技能在什么情况下补位？
- 父技能、子技能、合成前置如何限制候选？
- 已满星技能怎样从池子里移除？
- 同一轮三张卡如何去重？
- 候选不足三张时按什么优先级补齐？
- 是否存在保底、重抽或临时 Boost？
- `BoostWeightByPercent / RevertWeightBoost` 是长期 Build 修正，还是某些一次性事件的临时加权？

这些规则决定玩家实际感知到的“随机质量”，也是三选一反拆的下一层重点。

## 证据索引

- `restored/configs/tables/Skill_SkillTypeWeight.json`
- `restored/code/native-evidence/HotFix.BattleLogic.HeroComponentRandomSkill.asm`
- `restored/code/native-evidence/HotFix.BattleLogic.WeightRandom.asm`
