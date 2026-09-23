# Init 技能池初始化链：静态证据闭合

> 2026-09-23 复核：此前仅搜索对 `DoInitSkillGroupCount` 的直接 `BL/B`，漏掉了 `SinglePlayerBattleManager.CreatePlayer` 中的热更新分派和内联写入。以下结论取代本文件旧的“写入未闭合”表述。

## 已经确认

配置中：

- `UseInitSkillGroupCout = 1`
- 中文备注：“使用初始技能库的次数”。

运行时数据结构中：

- `BattleData.InitSkillGroupCount` 位于 `BattleData` offset `0x34`；
- `BattleSaveData.initSkillGroupCount` 持久化这一计数；
- `BattleWorldContext.get_InitSkillGroupCount()` RVA `0x6A033B4`；
- `BattleWorldContext.DoInitSkillGroup()` RVA `0x6A035C0`；
- `BattleWorldContext.DoInitSkillGroupCount(int)` RVA `0x6A0362C`；
- `BattleWorldContext.PrepareBattle(MainWorldInitInfo)` RVA `0x6A0499C`。

技能随机端已经证明：

`SinglePlayerSkillCreator.GetNormalSkill`
→ 检查运行时 Init 计数
→ 计数大于 0 时使用 `_initRandoms`
→ 本轮消费一次计数
→ 后续转 `DefaultRandoms`。

因此“存在首轮专用技能池、且运行时有独立消费计数”已经是确定事实。

## 新找到的写入链

证据见 [`SinglePlayerBattleManager--CreatePlayer.asm`](../../research-data/topics/choices-box-evolution/evidence/SinglePlayerBattleManager--CreatePlayer.asm) 的 `0x65C6738—0x65C67C0`。创建玩家时：

- 从 `LocalModels.Const` 静态对象偏移 `0x208` 读取 `UseInitSkillGroupCout`，本版本配置值为 `1`；
- 取得 `WorldInitInfo` 后通过虚方法判定是否为继续战斗；若不是继续战斗，则在无热更替换的本地路径将值写入 `BattleWorldContext` 偏移 `0x2c4`；
- 若热更替换了 `DoInitSkillGroupCount`，则通过方法元数据偏移 `0x60` 的函数指针调用，并传入同一个值。该热更函数体需运行态确认；
- `BattleWorldContext.DoInitSkillGroupCount` 的本地实现对该字段也是覆盖赋值，不是递增，见 [`BattleWorldContext-DoInitSkillGroup.asm`](../report-native/BattleWorldContext-DoInitSkillGroup.asm) `0x6A0362C—0x6A03690`。

`BattleData.InitSkillGroupCount` 保存同一计数；继续战斗的反序列化路径从 `BattleSaveData.initSkillGroupCount` 恢复，见 [`findings.md`](../continuation-2026-09-19/findings.md)。因此普通新局的本地写入链已闭合，但“每局首屏必展示初始池”仍不成立：引导指定结果可覆盖普通随机，线上热更也可能替换函数。

## 复现入口与剩余范围

`scripts/04_native_evidence.py` 已加入：

- `BattleWorldContext`
- `BasePunchboardState`
- `WaterfallStatePunchboard`
- `PlayerPunchboard`

并把以下方法加入 direct BL/B xref 扫描：

- `BattleWorldContext.get_InitSkillGroupCount = 0x6A033B4`
- `BattleWorldContext.DoInitSkillGroup = 0x6A035C0`
- `BattleWorldContext.DoInitSkillGroupCount = 0x6A0362C`
- `HeroComponentRandomSkill.GetPunchboardRandomCount = 0x686F88C`
- `WaterfallStatePunchboard.GetPunchboardRandomCount = 0x65B597C`

在拥有真实 Git LFS 文件 `libil2cpp.so` 的本地 checkout 运行：

`python scripts/04_native_evidence.py`

会生成 `HotFix.BattleLogic.BattleWorldContext.asm`；直接 `BL/B` 扫描不覆盖 `CreatePlayer` 的热更新间接调用，必须同时检查 `SinglePlayerBattleManager.CreatePlayer` 的 `0x65C6738—0x65C67C0`。

优先检查：

1. 验证线上热更是否替换该方法；
2. 查引导指定列表的赋值来源，确认何时覆盖第一次普通随机；
3. 用同版本实机记录新局与读档的首屏候选，校验静态路径。

## 当前策划结论的安全写法

现在可以写：

> 本版本普通新局的本地 `CreatePlayer` 路径把配置值 1 写入 Init 计数；普通抽取在计数大于 0 时走10武器初始池并消费，随后转入常规池。继续战斗沿用存档计数。

暂时不要写：

> 每局玩家首屏一定从10武器初始池随机展示。

后一句还需要排除引导覆盖和线上热更，不能只靠本地计数写入推出。
