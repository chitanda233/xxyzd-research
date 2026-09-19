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

继续下钻 `WeightRandomData.asm` 后，最后一层也已经闭环。`WeightRandomData.PracticalWeight`（RVA 0x6632120）直接把动态修正值加上 FP 1.0，再与基础权重相乘，因此最终有效权重公式可以明确写死为：

```text
delta = min(同类型已学习数量 × 0.5, 5.0)
effectiveWeight = baseWeight × (1 + delta)
```

因此，在其它条件相同的情况下，学习第 1 个同类型技能后，该类型命中项的有效权重变为基础值的 1.5 倍；第 2 个为 2.0 倍；第 3 个为 2.5 倍；此后每多学一个继续 +0.5 倍，直到学满 10 个同类型技能后封顶在 6.0 倍。这里的“倍数”是权重倍数，不等于最终展示概率倍数，因为实际概率还取决于当次合法候选池内其它条目的总权重。

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

## 6.1 候选池已经确认是“分池后抽”，不是一锅随机

继续下钻 `WeightRandom` 后，可以确认 `GetAlreadyStudySkill`、`GetReadyStudySkill`、`GetOneStarSkill` 的职责不是直接返回最终三选一，而是**构造新的 WeightRandom 子池**：它们先 Clear 目标池，逐条读取 `Skill_Main` 和当前条目的有效 Weight，再把符合“已学 / 可学 / 一星”等条件的技能 Add 进去。

`RandomOneSubSkillByParent` 也显示了同样的结构：先沿父技能升级链与分支组筛选，经过 `GameUtils.CheckCanStudySkill` 和 ban list，再调用 `GetRandomCount`；这一条路径一次最多拿 1 个子技能。于是三选一的真实结构应改写为：**合法性与语义分池 → 各子池保留动态权重 → 按需要从子池抽取 → 汇总/补齐最终候选。**

另外需要修正之前对 `BoostWeightByPercent / RevertWeightBoost` 的解读：当前 `HeroComponentRandomSkill.asm` 中没有发现这两个函数的直接调用。它们只能证明通用 `WeightRandom` 支持临时 Boost，**不能**作为“已有 Build 会自强化”的证据。Build 收敛的直接证据链是 `UpdateLearnedSkillCount → GetDeltaWeightPercent → AdjustWeightsForSkillGroup → UpdateWeightPercent`。


## 6.2 单次候选抽取是按实时有效权重做“去重抽样”

继续下钻 `WeightRandom.GetRandomCount(count, resultList, allSkills, banSkills)`（RVA 0x6633C0C）后，候选抽取方式也可以进一步坐实。函数在每次抽取前会遍历当前随机项，调用 `WeightRandomData.Weight` 取得已经包含动态 delta 的有效权重，并跳过已经进入 `resultList` 的技能；随后在剩余总权重区间内取随机数，再按累计权重命中具体条目。

命中后，普通技能 ID 会立刻加入 `resultList`。下一轮重新计算时，已经在结果列表里的 ID 会被排除，因此**同一次 `GetRandomCount` 不会重复抽出同一个技能 ID**。实现里还会对命中的 `WeightRandomData` 与活动区尾部条目做交换，进一步表现出典型的无放回抽样结构。

如果命中的条目是“升级/父技能型”候选，代码不会直接把父 ID 塞进结果，而是转入 `RandomOneSubSkillByParent`：沿升级链和分支组检查可学习条件、已拥有技能和 ban list，再从合法子技能里最多补 1 个。于是最终候选并不是“随机出父技能后再由 UI 决定升级方向”，而是在生成候选阶段就已经把可用的具体升级分支解析出来。

因此三选一可以进一步概括为：

**先构造合法候选池 → 按动态有效权重抽一个 → 立即加入结果/排除重复 → 如为父技能则解析成一个合法子分支 → 重算剩余池后继续抽，直到补足目标数量。**

这里仍需保留一层边界：`HeroSkillCreator.GetRandomSkills` 会在多个 `WeightRandom` 子池之间分配抽取名额，因此“最终三个位置分别优先属于哪类池”还需要继续还原；但单个子池内部的权重抽样与去重规则已经明确。

## 7. 当前已经坐实与仍待补证的部分

### 已坐实

1. 技能会按类型分组。
2. 系统维护“每个 skillType 已学习数量”。
3. 新增/移除技能会增减这个计数。
4. 计数变化后会调用 `GetDeltaWeightPercent`。
5. `GetDeltaWeightPercent` 的结果由“学习数量 × 每技能增量”与“最大增量上限”共同决定，最终取封顶值。
6. 结果会继续传给 `AdjustWeightsForSkillGroup`。
7. `WeightRandomData.PracticalWeight` 已确认最终有效权重为 `baseWeight × (1 + delta)`，动态修正不是日志字段，而是直接进入抽取权重计算。

因此，“已有 Build 会提高同类型后续技能的抽取倾向”已经可以从假设升级为报告中的正式结论，而且增权幅度已经能精确量化。

### 高概率，但仍需继续深挖

1. `AdjustWeightsForSkillGroup` 在当前保存的 ARM64 文件中表现为 HotFix 分发壳，真实热更方法体没有被静态还原；因此“同类型组内每个成员如何接收 delta”的逐条实现仍需动态/热更层证据。这里不应把 `WeightRandom.UpdateWeightPercent` 与它强行写成直接 native 调用链。
2. 最终三个候选位如何在多个 `WeightRandom` 子池之间分配名额，以及子池优先级是否会随局内状态改变。
3. `BoostWeightByPercent / RevertWeightBoost` 的仓库级调用方仍未定位；当前不能把它们解释成三选一保底或 Build 收敛机制。
4. `GetAlreadyStudySkill / GetReadyStudySkill / GetOneStarSkill` 在三个候选位中的优先级与占位顺序。

## 8. 下一步建议

下一步最值得继续追的有两条。第一条仍是 `GetNormalSkill → HeroSkillCreator.GetRandomSkills → 多个 WeightRandom 子池`，但目标已经缩小为“最终三个候选位怎样在不同子池之间分配名额”。单个子池内部已经确认按实时有效权重抽取，并通过结果列表排除实现同批去重。第二条已经完成：`WeightRandomData.PracticalWeight` 已把最终公式坐实为 `baseWeight × (1 + delta)`。下一步更值得追的是 `AdjustWeightsForSkillGroup` 的 HotFix 实际方法体或运行时行为，确认一个 skillType 的 delta 究竟覆盖组内哪些随机条目。

`BoostWeightByPercent / RevertWeightBoost` 目前降为次要支线：先做仓库级调用方定位，只有确认它真的参与 `HeroComponentRandomSkill` 的三选一流程后，才讨论保底或临时增权。


implementation 级证据摘记见 `evidence/skill-random-weight-native.md`。
