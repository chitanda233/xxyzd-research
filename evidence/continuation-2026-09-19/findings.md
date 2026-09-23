# 局内报告接手复核：2026-09-19

正式正文为 [docs/core.html](../../docs/core.html)。本次接手保留现有网页视觉与较新证据，仅补整体链路缺段。旧报告、交接结论若与本记录及网页冲突，应回到原生实现复核。

## 基线冲突已处理

- 旧 `reports/小小远征队-局内整体链路策划拆解.md` 的 W8/W11/W12 数量26/24/33错误；网页与 `evidence/battle/chapter1-native-findings.md` 正确数为18/8/21。numberRandom为目标数量，不是随机组抽取次数。
- 同类型增权公式不等于已启用；AdjustWeightsForSkillGroup fallback为空，沿用网页证据边界。
- W5、W10入波前普通成长分别约4、9次，不能把当波末奖励提前算入。
- 补入 W6/W11/W15 独立 Punchboard；W15起点345s，Boss任务347s。

## 新核对的死亡—复活—返回战斗

下列摘取为本目录对应 asm，均来自已有真实二进制的原生导出，不是空C#方法体。

1. `AttributeData.GetRebornType` RVA **0x6B3DD14**：GetSkill1RebornCount>0返回4；否则依次比较 ResurrectionFullRate% 和 ResurrectionRate% 与传入同一随机值，返回2或1；否则剩余ReliveCount>0返回3，否则0。字符串由ELF重定位与metadata地址映射确认。
2. `BaseHeroDieState.OnEnter` RVA **0x659BD28**：0x659BF74调用GetRebornType，0x659BF78保存类型。`OnUpdate` RVA **0x659C644** 在0x659C6D0起分类型，1/2/4进入PlayerRelive，3转等待复活交互。
3. `BaseHeroDieState.OnPush` RVA **0x659CC38**：接收事件7的byte结果；1在0x659CD24调用PlayerRelive(3)，2在0x659CD3C调用PlayerReliveByAd，0安排无复活后续状态。UI的flag发送定义来自已有RelivePopupViewModule导出。
4. `PlayerReliveByAd` RVA **0x659C428**：0x659C4CC AddAdReliveCount，然后0x659C4D8设type=3转PlayerRelive。
5. `PlayerRelive` RVA **0x659C4E8**：0x659C5AC调用AddReliveCount(type)，随后调用HeroComponentDie.ReBorn。注意后者使用状态保存的复活类型，不能把两种type参数混为所有效果都相同。
6. `BattleWorldContext.AddReliveCount` RVA **0x6A226D0**：0x6A22718比较type与3，非3在0x6A228B8直接返回；类型3减ReliveCount、增ReliveUsedCount，并在星级功能标记开启时调用OnPlayerRelive。
7. `WaterfallStateHeroDie.OnPlayerRelive` RVA **0x65B5238**：0x65B5358 ActiveState(1)，0x65B54B8调用TryResumeWaveEndUpLevelProgress。状态1可由BattleDef结构定义复核，属于战斗态。

结论：弹窗购买和广告共用被计数的复活分支；本路径技能/概率复活不增加该已用次数。不能说任何复活都会破坏“未使用复活”评价，也不能从第一章ResurrectionTimes=0推断禁止技能/属性复活。线上资格初始化、广告次数限制、清弹、无敌时长及敌人血量保留仍未全部还原。

## 新核对的客户端评价链

- `SinglePlayerBattleManager.CreateBattleEndEvent`：0x65C285C起检查结果=1和星级功能flag，0x65C2904调用CollectStar，0x65C2930写入MainBattleEndEvent的StarMask。相应完整函数由既有导出单独提取在本目录。
- `BattleStarManager.CollectStar` RVA **0x6595408**：先CheckTime、CheckAliveCount(false)、CheckHpPercent(playerID)，再将三个条件状态组合为bit mask。
- `CheckAliveCount` RVA **0x6595624**：condition=3，ReliveUsedCount大于param则清状态。第一章条件102的param=0。
- `CheckHpPercent` RVA **0x659586C**：condition=5；比较玩家当前HP百分比与param，低于门槛则清状态。第一章101门槛0、103门槛100。不能仅凭101的中文文案假定它对应独立“胜利”condition枚举；成功结果由调用方约束。
- 针对CheckHpPercent的原生直接BL/B扫描仅找到CollectStar调用，见 `targeted-xrefs.json`。这支持终局采样模型，但不排除间接调用/热更。没有发现足以支持“全程无伤”的证据。
- `BaseEndState.OnEnter` RVA **0x6598EB4**组织结束表现；OnUpdate RVA **0x659A1CC**含HasEquip、EquipIsClear、HaveDropExp、AbsorbAll、ExpIsClear。W15没有常规波末UI，所以吸收末波经验不能自动等同于第15次普通选牌。

## 对缺口主动追查的结果

- 已检查PrepareBattle、BattleData.Init、InitFromSaveData，以及DoInitSkillGroup/DoInitSkillGroupCount。新局BattleData.Init仅写markKey和回调；读档InitFromSaveData在0x658E510读取存档offset0x20的向量并在0x658E520写到BattleData offset0x34，覆盖Init计数及后续复活计数。结构声明提供字段对应。
- 对DoInitSkillGroup和DoInitSkillGroupCount的直接BL/B扫描均无引用。说明继续只找这两个函数的直接调用不会闭环；下一步应查内联写入、虚调用或热更新，不将“无直接引用”误写成机制不存在。

**2026-09-23补证：**后续在`SinglePlayerBattleManager.CreatePlayer`的`0x65C6738—0x65C67C0`找到配置值经热更新分派或本地内联写入Init计数的路径。上段是当日搜索结论，不再表示此缺口未闭合。详见[`init-skill-group-open-question.md`](../battle/init-skill-group-open-question.md)。
- 数量权重缺失仍限制Punchboard定量结论。已有Const构造函数导出不等于数组已解码。本次正文只采用确认的三次事件、独立池和重构结构，没有补猜概率与净收益。
- 动态增权fallback为空的证据已经明确，继续翻同一个fallback无法证明线上启用；需要实际hotfix方法体或运行时采样。
- 服务端到账、失败保留规则不在当前原生证据覆盖范围，正文不写固定收益。

## 复核方法与接手边界

`targeted-xrefs.json` 为Native.find_direct_branch_xrefs定向扫描结果，目标地址为0x6A0362C、0x6A035C0、0x659586C。扫描基于PT_LOAD的32位指令筛选；数据段理论上也可能出现伪命中，返回点已按具体函数复核。缺少命中不排除内联和间接调用。

本目录asm从既有导出抽取，保留地址与热更分支。全局字符串注释是地址映射，不替代数据流证明。客户端静态结论不等同线上全版本规则。不要重新全包扫描；下一次从具体缺口继续。
