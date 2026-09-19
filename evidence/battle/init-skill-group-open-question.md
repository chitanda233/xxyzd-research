# Init 技能池初始化链：当前证据与最后缺口

> 目标：证明 `Consts_Const.UseInitSkillGroupCout = 1` 在开局初始化时如何进入 `BattleData.InitSkillGroupCount`，从而把“首轮使用一次 Init 技能池”从高置信结构推到完整 native 调用链。

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

## 仍缺的唯一关键调用

目前仓库保存的 native evidence 集没有包含 `BattleWorldContext`，所以还没有抓到：

`Const.UseInitSkillGroupCout`
→ 战斗初始化调用者
→ `BattleWorldContext.DoInitSkillGroupCount(1)` 或等价写入
→ `BattleData.InitSkillGroupCount = 1`

现有 `WaterfallBattleManager`、`BaseSurvivalBattleManager`、`SinglePlayerSkillCreator`、`HeroComponentRandomSkill` asm 中也没有对 `DoInitSkillGroup*` 的直接符号/RVA 引用。因此不能把“配置值 1 已经由这条具体调用写入 BattleData”写成完成证明。

## 已补的复现入口

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

应生成 `HotFix.BattleLogic.BattleWorldContext.asm` 并在 `indexes/native-direct-xrefs.json` 中给出所有直接调用者。

优先检查：

1. `PrepareBattle` 是否直接/间接调用 `DoInitSkillGroup*`；
2. 调用前是否读取 `LocalModels.Const.UseInitSkillGroupCout`；
3. 新开局与读档分支是否不同；
4. `DoInitSkillGroupCount` 是覆盖赋值还是递增/递减；
5. 恢复存档时是否跳过配置初始化，直接沿用 `BattleSaveData.initSkillGroupCount`。

## 当前策划结论的安全写法

现在可以写：

> 主线存在首轮专用 Init 技能池；运行时用独立计数决定它还能使用几次，配置目标值为 1，且该计数会进入战斗存档。普通抽取在计数耗尽后转入 Default 池。

暂时不要写：

> 开局一定执行了 `DoInitSkillGroupCount(1)`。

后一句需要等新增的 `BattleWorldContext.asm` 跑出来后再完成最后闭环。
