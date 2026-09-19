# 三选一同 SkillType 动态权重证据

研究对象：客户端 1.0.16 / versionCode 40。这里专门记录“同类型技能越学越容易出现”这一假设的证据边界，正文见 `research/battle/skill-random-analysis.md`。

## 配置

`Skill_SkillTypeWeight` 中有效类型基本统一：

```text
AddWeightPerSkill = 50
AddWeightMax      = 500
```

## 已被 native 证明的计算框架

来源：`restored/code/native-evidence/HotFix.BattleLogic.HeroComponentRandomSkill.asm`

- `UpdateLearnedSkillCount(skillType)` — RVA `0x686AEF4`：维护 `_learnedSkillCountsByType`，同一 SkillType 每学习一次计数 +1。
- `GetDeltaWeightPercent(skillType)` — RVA `0x6869E9C`：
  1. 读取该 SkillType 的 `Skill_SkillTypeWeight`；
  2. 读取已学同类型数量；
  3. 计算 `learnedCount × AddWeightPerSkill`；
  4. 用 `AddWeightMax` 截顶。
- 新增/移除技能相关调用链确实会执行：
  `GetDeltaWeightPercent(skillType) → AdjustWeightsForSkillGroup(skillType, delta)`。

按当前配置，设计公式就是：

```text
delta(type) = min(learnedCount(type) × 50%, 500%)
```

如果最终应用，则 1 / 2 / 3 / 5 / 10 个同类型技能分别对应 +50% / +100% / +150% / +250% / +500%。

## 补充：delta 是当前状态的绝对目标值

新增与移除技能的 native 调用顺序进一步排除了“每次在旧权重上继续 +50%”的解释。

新增路径先调用：

`UpdateLearnedSkillCount(skillType) → GetDeltaWeightPercent(skillType) → AdjustWeightsForSkillGroup(skillType, delta)`

移除路径先调用：

`DecreaseLearnedSkillCount(skillType) → GetDeltaWeightPercent(skillType) → AdjustWeightsForSkillGroup(skillType, delta)`

也就是说，传给应用函数的 delta 每次都由**更新后的当前持有数量**重新计算。按当前配置，它表示：

`targetDelta = min(currentCount × 0.5, 5.0)`

所以如果线上 HotFix 启用了实际应用，3 个同类型技能对应的目标应是 +150%；移除 1 个后重新计算为 +100%，而不是保留 +150% 再做某种增量修正。这个调用顺序证明了“当前状态重算”的设计语义。

需要再次强调：这只能强化公式和重算语义，不能绕过 `AdjustWeightsForSkillGroup` 在 APK fallback 中为空实现这一反证。

## 关键反证：当前 APK fallback 没有真正应用

`AdjustWeightsForSkillGroup` — RVA `0x686A17C`。

当前 APK 的普通 native fallback 分支在完成类型/hotfix 元数据检查后直接返回；没有遍历 `_skillGroupsByType`，也没有把刚才算出的 `delta` 写给任何 `WeightRandom`。只有方法被运行时 hotfix 覆盖时，才会走间接跳转的实现。

同时：

- `HeroComponentRandomSkill.asm` 中没有找到对 `WeightRandom.UpdateWeightPercent` 的直接调用。
- `WeightRandom.UpdateWeightPercent` 本身确实存在（RVA `0x66327C4`），可以给指定 skillIds 写百分比权重修正。
- `WeightRandom.BoostWeightByPercent`（RVA `0x6633824`）和 `RevertWeightBoost`（RVA `0x6633908`）也都存在，说明底层随机器有成熟的临时增权能力。
- 但“底层能力存在”不能替代“主线动态 SkillType 机制实际调用它”的证据。

## 新证据：APK 确实存在 HotFixBattle 代码热更新通道

“可能由线上 HotFix 覆盖空 fallback”现在可以从泛化可能性提升为**客户端明确具备对应代码热更通道**，但仍不能直接提升为“该函数线上已经被覆盖”。

APK 内的 `assets/FullRes/catalog_hotfix.json` 经 Base64 键表解码后，能直接找到：

- `Assets/_Resources/HotUpdateSnapshot/HotFix.dll.bytes`
- `Assets/_Resources/HotUpdateSnapshot/HotFixBattle.dll.bytes`
- `Assets/_Resources/HotUpdateSnapshot/HotFix.mv.bytes`
- `Assets/_Resources/HotUpdateSnapshot/HotFixBattle.mv.bytes`

catalog 同时指向官方远端 bundle：

`hotupdatesnapshot_assets_all_2b09cb64858ac1748bf35100e3663898.bundle`

仓库里已经保存了这份 snapshot bundle。把 UnityFS 解开后可见四个 TextAsset 当前内容都是版本标记 `"1"`，同时 AssetBundle 数据给出了真正代码包名：

`0dc4ad20592f3aedee4d422f396422c9.bundle`

因此客户端的代码更新链可以高置信理解为：

`HotUpdateSnapshot 版本标记 → 对应 HotFix/HotFixBattle 代码 bundle → 运行时覆盖/加载热更实现`。

这对动态 SkillType 权重的证据边界很重要：

- **比之前更确定的部分：** `AdjustWeightsForSkillGroup` 的 APK fallback 为空，并不等于线上绝无实现；本客户端确实为 `HotFixBattle` 准备了独立代码快照与代码 bundle 更新链。
- **仍然不能跨越的边界：** 当前仓库没有保存真正的 `0dc4ad20592f3aedee4d422f396422c9.bundle`，本研究环境也无法直接访问该 CDN bundle，所以还没有拿到线上 `AdjustWeightsForSkillGroup` 的真实 IL/C# 实现。不能因此把动态增权写成“已在线启用”。

后续如果拿到该代码 bundle，应优先提取 `HotFixBattle.dll`，直接反编译 `HeroComponentRandomSkill.AdjustWeightsForSkillGroup`。这比继续从 APK fallback 猜测更有决定性。

## 当前应采用的策划表述

**已证实：** 客户端设计了同 SkillType 的 Build 收敛框架，理论参数为“每学一个同类型技能，计划增权 +50%，最多 +500%”。

**未证实：** 1.0.16 APK 基线运行时真的把这项增权应用到主线三选一候选。当前 fallback 应用函数为空实现。

可能性包括：该功能被废弃/暂时关闭，或者线上运行时 HotFixBattle 覆盖了 `AdjustWeightsForSkillGroup`。现在已经确认客户端存在 HotFixBattle 代码更新链，但尚未取得真正代码 bundle，因此仍不应把“已有 Build 会实际提高同类出现率”写成确定规则。

这条反证非常重要：它把“设计意图”和“当前静态 APK 能证明的运行行为”分开，避免策划报告把未生效逻辑写死。

## 补充：底层动态百分比的实际数学含义

`WeightRandom.UpdateWeightPercent(skillIds, value)`（RVA `0x66327C4`）会遍历池内候选，只对ID命中 `skillIds` 的 `WeightRandomData` 写入动态百分比字段。

`WeightRandomData.PracticalWeight`（RVA `0x6632120`）随后按Q16定点数直接计算：

```text
PracticalWeight = BaseWeight × (1 + DeltaWeightPercent)
```

因此如果运行时HotFix真的实现了 `AdjustWeightsForSkillGroup` 并把 `GetDeltaWeightPercent` 的结果写入同类型候选，那么默认配置并非“最多变成5倍”，而是：

- 学1个同类型：delta=0.5 → 实际1.5倍；
- 学2个同类型：delta=1.0 → 实际2.0倍；
- 学5个同类型：delta=2.5 → 实际3.5倍；
- 学10个及以上：delta=5.0封顶 → 实际6.0倍。

这进一步说明该系统若在线上被启用，会是很强的Build收敛器，而不是轻微的概率修饰。

但证据边界不变：当前1.0.16 APK静态fallback中的 `AdjustWeightsForSkillGroup` 仍为空，因此这里证明的是“底层能力 + 精确数学结果”，不是“主线当前一定已调用”。
