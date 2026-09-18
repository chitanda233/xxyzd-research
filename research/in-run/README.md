# 局内核心玩法反拆

> 目标：输出策划可读的“单局运行模型”，配置和反编译代码只作为证据，不把表字段本身当报告主体。

## 当前已经确认的骨架

### 一局不是连续 Survival，而是分段式 15 波结构

主线第 1 章配置为 `waveNum = 15`。对应 Section 1001～1015 中，第 5、10、15 段的 `StopByEliteOrBossKilled = 1`，其他段为 0。

从策划节奏看，第一章可以先按以下结构理解：

- 1～4 波：普通压力与 Build 成形
- 5 波：第一个强制清场节点
- 6～9 波：第二轮压力
- 10 波：第二个强制清场节点
- 11～14 波：最终成形段
- 15 波：终局 Boss/精英门槛

这更接近“4+1 / 4+1 / 4+1”的三幕节奏，而不是完全连续的时间生存。

### 经验不是均匀发放，而是主动抬高后段升级密度

第 1 章 15 段的 `WaveAllExp` 为：

`200, 550, 600, 600, 700, 800, 800, 950, 1000, 1100, 1200, 1200, 1400, 1700, 2000`

从配置层至少能确认：后段单波经验显著高于前段。策划目的更可能是让 Build 在后半局继续快速成形，而不是前期升级频繁、后期逐渐停止成长。

是否“每波结算直接发这些经验”仍要继续结合刷怪和掉落实现核对；当前只能确认它是每段的总经验预算/目标值。

## 升级抽取不是一个静态等概率池

`HeroComponentRandomSkill` 内部维护：

- 当前已学技能
- 全部战斗技能
- 按 SkillType 分组的技能集合
- 每类已学习数量
- 每个技能的权重数组

并存在明确的方法：

- `GroupSkillsByType`
- `UpdateLearnedSkillCount`
- `GetDeltaWeightPercent`
- `AdjustWeightsForSkillGroup`
- `RecalculateAllWeight`

同时 `Skill_SkillTypeWeight` 对多数类型配置：

- `AddWeightPerSkill = 50`
- `AddWeightMax = 500`

因此当前可以确认：**局内选项权重会根据玩家已经形成的 SkillType 结构动态调整**，并不是每次单纯从固定列表里等概率抽 3 个。

但“学得越多越容易继续抽到同类”还是“未成形类型获得补偿”必须从 `GetDeltaWeightPercent` / `AdjustWeightsForSkillGroup` 的 native 实现继续确认，不能只凭字段名下结论。

## 抽取器本身还会实时修改池

`WeightRandom` 提供了：

- `Add`
- `RemoveRandom`
- `OnAddRejectFlag`
- `OnAddRejectSkills`
- `OnAddFlag`
- `OnCheckNeedSkills`
- `BoostWeightByPercent`
- `GetRandomCount`
- `RandomOneSubSkillByParent`

这说明玩家学到一个词条后，系统会同步改变后续候选集合：前置条件、互斥、Flag、父子升级关系都可能让候选进入或离开抽取池。

从策划角度，这套 Build 系统至少不是“18 个基础技能无限随机升级”，而是一个会随已学内容不断重构候选池的有向成长图。

## 第一章本身还带有推荐 Build

第 1 章配置 `SuggestedSkills = [10000101, 10000601]`，第 2、3、4 章推荐集合发生变化。

这说明关卡设计和 Build 不是完全解耦的：不同章节至少在表现/引导层存在针对怪物组成或关卡压力的推荐解法。后续需要把推荐技能与章节怪物/Boss能力对应起来，才能判断它是否参与新手引导、失败提示或实际抽取保底。

## 当前最值得继续闭合的 4 个问题

1. 第 1 章每波具体刷怪编排：数量、刷新间隔、普通/精英/Boss的出现点。
2. `GetDeltaWeightPercent` 的方向：它到底是在强化已选流派，还是补偿没选到的流派。
3. 特殊/高阶升级的开启条件：`CheckNeedOpenSpecialSkill`、`OpenSelectSpecialSkill`、父子升级关系如何共同决定“质变词条”出现。
4. 经验如何从怪物/波次转为升级次数：确认升级频率是不是策划按波精确控制。

这些问题闭合后，才能把“局内核心循环”写成真正可复用的策划反拆，而不是配置摘要。
