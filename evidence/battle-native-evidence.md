# Battle native evidence

本文件保存当前《局内核心循环反拆》直接依赖的 native 证据索引。完整 ARM64 汇编仍保存在 `restored/code/native-evidence/`，这里只摘录与策划结论相关的关键地址和行为。

## 1. WaterfallBattleManager：波末升级队列

### AddUpLevel

`RVA 0x65C8890`

关键行为：

```asm
0065C88D0  ldr      w8, [x19, #0x1cc]
0065C88D4  add      w8, w8, #1
0065C88D8  str      w8, [x19, #0x1cc]
```

说明：偏移 `0x1cc` 是待处理升级次数计数器。

### DelUpLevel

`RVA 0x65C88FC`

```asm
0065C893C  ldr      w8, [x19, #0x1cc]
0065C8940  subs     w8, w8, #1
0065C8948  ldr      w9, [x19, #0x1c8]
0065C894C  str      w8, [x19, #0x1cc]
0065C8950  add      w8, w9, #1
0065C8954  str      w8, [x19, #0x1c8]
```

说明：每消费一次升级，待处理次数 -1，同时本波已处理升级次数 +1。

### MarkWaveEndSelectSkillFinished

`RVA 0x65C8A00`

```asm
0065C8A40  ldr      w8, [x19, #0x1d0]
0065C8A44  cmp      w8, #2
0065C8A4C  mov      w8, #3
0065C8A54  str      w8, [x19, #0x1d0]
0065C8A58  bl       #0x65c88fc ; WaterfallBattleManager$$DelUpLevel
```

说明：波末三选一完成后，状态从 2 切到 3，并消费一个待处理升级。

### TryContinueWaveEndUpLevelAfterSelection

`RVA 0x65C8B28`

```asm
0065C8B74  ldr      w8, [x19, #0x1d0]
0065C8B78  cmp      w8, #3
0065C8B84  str      wzr, [x19, #0x1d0]
0065C8BA4  bl       #0x6870404 ; HeroComponentRandomSkill$$CheckNeedOpenSpecialSkill
0065C8BC4  bl       #0x6580ee4 ; BattleManager$$ActiveState
```

说明：选择完成后仍有专门的继续流程，而不是直接无条件进入下一波。

### TryResumeWaveEndUpLevelProgress

`RVA 0x65C8C14`

```asm
0065C8C5C  bl       #0x6587334 ; BaseSurvivalBattleManager$$get_IsStateWaveShowEnd
0065C8C68  bl       #0x65c8cd0 ; WaterfallBattleManager$$IsCurrentUpLevelUI
0065C8C70  ldrb     w8, [x19, #0x1d4]
0065C8C7C  bl       #0x65c8d70 ; WaterfallBattleManager$$CanRunUpLevelProgress
0065C8C84  ldr      w8, [x19, #0x1d0]
0065C8C88  cmp      w8, #3
0065C8C9C  b        #0x65c8b28 ; TryContinueWaveEndUpLevelAfterSelection
```

说明：波末升级是明确状态机，受当前波末状态、升级 UI、经验吸收状态和升级流程可运行条件共同控制。

### OnProgressFinish

`RVA 0x65CC838`

关键调用：

```asm
0065CC9E8  bl       #0x65c8d70 ; CanRunUpLevelProgress
0065CCD20  bl       #0x666fea8 ; DropMgr$$HasEquip
0065CCDB0  bl       #0x666fd64 ; DropMgr$$HaveDropExp
0065CCDC4  bl       #0x6851208 ; ExpAnimProcessor$$IsAdding
0065CCE54  bl       #0x666ff78 ; DropMgr$$AbsorbAll
0065CCE70  bl       #0x68510f8 ; ExpAnimProcessor$$IsIdle
0065CCE90  bl       #0x6850f28 ; ExpAnimProcessor$$CanLevelUp
0065CCEB0  b        #0x65c8e98 ; WaterfallBattleManager$$QueueSelectSkill
```

说明：波末会先处理掉落与经验吸收，随后检查能否升级，最终才进入技能选择队列。这个调用链直接支撑“经验来源仍在怪物，但三选一被延迟到波末统一处理”。

## 2. WaterfallBattleManager：精英 / Boss 门槛

`CheckStopByEliteOrBossKilled`：`RVA 0x65D2464`

该函数会读取刷新配置与 `Character_entity`，其中可以看到对特殊类型和掉落类型的判断：

```asm
0065D2BA0  bl       #0x64d8650 ; LocalModelManager$$GetCharacter_entity
0065D2BE0  cmp      w0, #0xc9
0065D2C1C  cmp      w0, #3
0065D2C68  cmp      w0, #1
```

第一章实体数据中：

- 310008：`Type=201 (0xC9)`、`ShowHpType=2`、`MonsterDropType=3`
- 340002：`Type=3`、`MonsterDropType=4`

结合 `ChapterWave_Waves.StopByEliteOrBossKilled`，第 10 波与第 15 波的死亡锁可以明确对应到精英 / Boss 节点。

## 3. HeroComponentRandomSkill：类型学习计数驱动动态权重

新增技能时：

```asm
00686A6E0  bl       #0x686aef4 ; UpdateLearnedSkillCount
...
00686A944  bl       #0x6869e9c ; GetDeltaWeightPercent
00686A954  bl       #0x686a17c ; AdjustWeightsForSkillGroup
```

移除技能时：

```asm
0068696EC  bl       #0x6869d14 ; DecreaseLearnedSkillCount
...
006869794  bl       #0x6869e9c ; GetDeltaWeightPercent
0068697A4  bl       #0x686a17c ; AdjustWeightsForSkillGroup
```

说明：学习/移除某类型技能会改变该类型计数，并立刻重新计算该类型的权重修正。

`GetDeltaWeightPercent` 中会：

1. 通过 skillType 获取 `Skill_SkillTypeWeight`
2. 调用 `GetSkillCountByType`
3. 用“单技能增量参数 × 已学习数量”
4. 与“最大增量参数”比较并取封顶值

因此策划层公式可以写为：

```text
delta = min(learnedCountByType × AddWeightPerSkill, AddWeightMax)
```

当前表中大部分类型配置为 `50 / 500`，另有少量 `0 / 0`。

## 4. WeightRandom：动态权重确实进入最终随机

### UpdateWeightPercent

`RVA 0x66327C4`

函数遍历权重条目，通过 `Array.Exists<int>` 判断目标 ID 是否在传入集合中，对命中条目写入新的权重百分比字段：

```asm
0066328E0  bl       #0x47b1aa8 ; System.Array$$Exists<int>
...
006632928  str      x9, [x8, #0x38]
```

### RecalculateAllWeight

`RVA 0x6633750`

函数先清零总权重，再逐项重新累加：

```asm
006633798  str      wzr, [x19, #0x2c]
...
0066337E0  add      w9, w0, w23
0066337EC  str      w9, [x19, #0x2c]
```

说明：动态权重不是展示值，而会进入真正的总权重计算。

### BoostWeightByPercent / RevertWeightBoost

`RVA 0x6633824 / 0x6633908`

两者分别对命中项对应的总权重做加 / 减：

```asm
; Boost
0066338E4  ldr      w8, [x19, #0x2c]
0066338E8  add      w8, w8, w0
0066338EC  str      w8, [x19, #0x2c]

; Revert
0066339C4  ldr      w8, [x20, #0x2c]
0066339C8  sub      w8, w8, w19
0066339CC  str      w8, [x20, #0x2c]
```

这证明 WeightRandom 还支持临时 Boost / 回滚。其具体调用场景仍需继续追调用方。
