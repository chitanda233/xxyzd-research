# 反编译代码阅读入口

本目录保存《小小远征队》客户端反拆过程中产生的中间代码证据，目的是让后续研究者能够复核策划结论，而不是只看到最终网页。

## 先看哪一层

- `gameplay-structures/`：从 IL2CPP 元数据恢复出的 C# 结构。它适合看类名、字段、方法名、调用入口和 RVA，但方法体为空，**不能把这里当成真实实现**。
- `native-evidence/`：按关键类筛出的 ARM64 native 反汇编。这里才是确认分支、权重、调用关系和真实运行逻辑的主要证据。
- `android/`：APK Java/Android 层代码，主要用于平台、SDK、Manifest 和外围能力，不是局内战斗逻辑的主入口。

## 局内玩法建议阅读顺序

### 1. 单局与波次
- `gameplay-structures/WaterfallBattleManager.cs`
- `native-evidence/HotFix.BattleLogic.WaterfallBattleManager.asm`
- `gameplay-structures/BeeMonsterCreator.cs`
- `gameplay-structures/BeeMonsterRefresher.cs`

### 2. 升级与三选一
- `gameplay-structures/HeroComponentRandomSkill.cs`
- `gameplay-structures/SinglePlayerSkillCreator.cs`
- `gameplay-structures/NormalSkillCreator.cs`
- `gameplay-structures/WeightRandom.cs`
- 对应 `native-evidence/HotFix.BattleLogic.*.asm`

重点关注的方法包括：
- `RandomSkill`
- `GetNormalSkill`
- `FillNormalSkill`
- `OpenSelectSpecialSkill`
- `CheckNeedOpenSpecialSkill`
- `AdjustWeightsForSkillGroup`
- `RecalculateAllWeight`
- `WeightRandom.GetRandomCount`
- `RandomOneSubSkillByParent`

### 3. 伤害与 Buff
- `gameplay-structures/CharacterComponentOnHit.cs`
- `gameplay-structures/CharacterComponentBuff.cs`
- 对应 native evidence

### 4. 掉落
- `gameplay-structures/MainDropManager.cs`
- `gameplay-structures/DropMgr.cs`
- 对应 native evidence

## 证据等级

1. **配置证据**：说明内容被配置过，但不保证当前线上启用。
2. **结构证据**：说明类/字段/方法存在，但方法体需要 native 复核。
3. **native 证据**：可用于确认真实分支与计算逻辑。
4. **运行态证据**：实际客户端录屏、抓包或调试结果；当前仓库仍以静态反拆为主。

策划报告中的结论应尽量能回溯到第 2～3 层；无法闭合的地方明确写“推断/待运行态验证”。
