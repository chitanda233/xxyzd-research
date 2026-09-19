# 三选一动态随机机制反拆

本文聚焦局内三选一的“动态随机”部分，主要证据来自 `HeroComponentRandomSkill`、`WeightRandom` 与 `Skill_SkillTypeWeight`。目标不是描述所有候选过滤规则，而是回答一个核心问题：**玩家已经在某一类技能上投入之后，系统是否会主动提高这一类后续技能的抽取倾向。**

## 结论先行

现在可以确认：**会。**

这个机制不是纯随机，也不是简单“已经学过某一张技能，就提高这张技能自己的概率”。它更像是：

**先按 skillType 分组 → 记录每个类型当前已经学习了多少 → 根据这个数量计算该类型的额外权重 → 把权重修正应用到对应技能组 → 重新参与后续三选一。**

这意味着局内 Build 是一个“带历史记忆的随机过程”。越早在某一类型投入，后续继续看到同类型发展选项的概率倾向越高，因此 Build 更容易沿已有方向成型。

## 1. 已学习数量是按技能类型记录的

`UpdateLearnedSkillCount` 会维护一个按类型索引的计数字典：

- 如果该类型已经存在，计数 +1；
- 如果不存在，则创建并置为 1。

`DecreaseLearnedSkillCount` 做完全相反的事情：

- 已存在则 -1；
- 不存在则按 0 处理。

native 中可以直接看到 `ContainsKey → get_Item → +1/-1 → set_Item` 的完整路径。因此，“学过多少个某类型技能”不是临时推断，而是系统明确长期维护的状态。

更关键的是，新增技能之后，代码会继续调用：

`GetDeltaWeightPercent(skillType) → AdjustWeightsForSkillGroup(skillType, delta)`

移除技能时也会重新：

`GetDeltaWeightPercent(skillType) → AdjustWeightsForSkillGroup(skillType, delta)`

所以已学习数量变化会直接触发该类型权重重新调整。

## 2. GetDeltaWeightPercent 的核心逻辑

`GetDeltaWeightPercent` 会先通过 skillType 读取 `Skill_SkillTypeWeight`，然后调用 `GetSkillCountByType` 获取该类型当前学习数量。

之后 native 中可以看到：

- 读取配置对象的两个连续权重参数；
- 对其中一个参数与“已学习数量”做乘法；
- 再与另一个参数比较；
- 最后通过 `csel` 取较小值。

结合表结构和配置值，可以把策划层公式写成：

```text
该类型动态权重增量
    = min(
        已学习该类型技能数量 × AddWeightPerSkill,
        AddWeightMax
      )
```

当前 `Skill_SkillTypeWeight` 一共 24 行，主流配置都是：

`AddWeightPerSkill = 50`
`AddWeightMax = 500`

另有少量 `0 / 0` 项，表示该类型不启用这套动态增权。

这里暂时不要把 50 和 500 直接写成“50% / 500%”。native 中还存在固定点/单位转换，当前能完全确认的是**线性累加 + 上限封顶**的关系，显示单位是否等同百分比还需要把字段类型和最终 WeightRandom 的归一化单位继续对齐。

## 3. 这不是单张技能加权，而是技能组加权

`InitRandomSkill` 初始化后会先调用：

`GroupSkillsByType`

然后：

`RecalculateAllWeight`

这说明随机系统不是把所有技能当成一张扁平列表直接抽，而是至少存在“按类型组织技能”的中间层。

当学习数量发生变化时，系统调用的是：

`AdjustWeightsForSkillGroup(skillType, delta)`

而不是某个明确的单技能 ID。

因此策划层更准确的描述应该是：

**玩家对某一类型投入越多，该类型对应技能组的权重越高。**

这比“学过火球以后火球本身更容易再出”更强，它意味着整个火系/某个类型分支都可能一起获得概率倾斜，从而帮助 Build 沿一个方向继续长。

## 4. WeightRandom 已经确认的职责

`WeightRandom.UpdateWeightPercent` 会遍历自己的权重条目，用一个 ID 数组筛选目标条目，并把新的权重百分比写入对应项。也就是说，`HeroComponentRandomSkill` 算出的类型增量最终确实有落到具体随机条目的机制。

`WeightRandom.RecalculateAllWeight` 会先把总权重清零，然后重新遍历所有条目，计算并累加每个条目的当前有效权重。换句话说，动态权重不是只影响日志或显示，它会改变后续随机时使用的总权重基数。

此外还有：

- `BoostWeightByPercent`
- `RevertWeightBoost`

这两个函数会对单个命中的随机项临时增加 / 减少总权重，说明随机器还支持“临时权重 Boost”。它与按 skillType 的长期动态偏置不是同一层机制。当前更合理的拆法是：

**类型学习历史 → 长期动态偏置**
**Boost / Revert → 某次或某阶段的临时权重修正**

后者后续还值得继续追具体调用方。

## 5. 这套机制对 Build 成型的实际意义

完全独立随机的问题很明显：玩家前几次已经拿了 A 类型技能，后面仍可能连续刷出互不相关的 B/C/D 类型，导致 Build 在只有十几次成长机会的单局里很难成型。

《小小远征队》这里采用的不是“锁池”，而是**软收敛**：

- 其它类型仍然能出现；
- 已投入类型逐步获得更高权重；
- 加权不是无限增长，有 `AddWeightMax` 封顶；
- 因此既保留随机性，又提高已有 Build 继续成型的概率。

这和第一章“完整一波≈升一级”结合起来以后，局内成长逻辑就非常清晰：

**每打一波 → 获得一次三选一 → 这次选择改变类型学习计数 → 后续权重重新计算 → 下一次三选一更偏向已有 Build → 15 波内逐步形成稳定流派。**

所以第一章不是 15 次彼此独立的随机选择，而是一个逐步自强化的随机过程。

## 6. 三选一并不只由动态权重决定

`HeroComponentRandomSkill` 里还有一整套候选合法性与候选补全逻辑，包括：

- `GetNormalSkill`
- `FillNormalSkill`
- `GetAlreadyStudySkill`
- `GetReadyStudySkill`
- `GetOneStarSkill`
- `RandomOneSubSkillByParent`
- `RemoveRandomSkill`
- `CheckNeedOpenSpecialSkill`

这说明真正流程不是“按权重直接从所有技能里抽三个”，而更可能是：

**先根据已学习状态、前置、星级、父子技能等规则筛合法候选 → 再按分组后的动态权重抽取 → 最后补齐三选一。**

因此报告正文不能把动态增权写成“同类技能必出”。它只是提高概率，不是硬保证。

## 7. 当前已经坐实与仍待补证的部分

### 已坐实

1. 技能会按类型分组。
2. 系统维护“每个 skillType 已学习数量”。
3. 新增/移除技能会增减这个计数。
4. 计数变化后会调用 `GetDeltaWeightPercent`。
5. `GetDeltaWeightPercent` 的结果由“学习数量 × 每技能增量”与“最大增量上限”共同决定，最终取封顶值。
6. 结果会继续传给 `AdjustWeightsForSkillGroup`。
7. `WeightRandom` 支持对指定条目修改动态权重，并重新计算总权重。

因此，“已有 Build 会提高同类型后续技能的抽取倾向”已经可以从假设升级为报告中的正式结论。

### 高概率，但仍需继续深挖

1. `AdjustWeightsForSkillGroup` 到底是把同一增量完整加给组内每个成员，还是按组内规则分摊。
2. 三选一是否采用无放回抽取，以及每抽一张后总权重如何重算。
3. `BoostWeightByPercent / RevertWeightBoost` 的调用方，是否用于“保底”“首个同类型”“特殊技能临时增权”等机制。
4. `GetAlreadyStudySkill / GetReadyStudySkill / GetOneStarSkill` 在三个候选位中的优先级与占位顺序。

## 8. 下一步建议

下一步最值得继续追的不是继续浏览配置，而是沿两条调用链往下：

`GetNormalSkill → FillNormalSkill → WeightRandom最终抽取`

以及：

`BoostWeightByPercent → 调用方 → RevertWeightBoost`

只要把这两段还原出来，就能进一步写出“一个具体三选一是怎样从候选池一步步生成的”，并做概率模拟，而不只是证明存在动态权重。
