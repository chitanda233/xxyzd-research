# Battle native evidence excerpts

此文件只保存本轮策划结论直接依赖的精简 native 证据，完整汇编仍保存在 `restored/code/native-evidence/`。

## WaterfallBattleManager

### OnProgressFinish

```asm
0065CC900  cmp      w8, #4
0065CCDC4  bl       #0x6851208 ; HotFix.BattleLogic.ExpAnimProcessor$$IsAdding
0065CCE54  bl       #0x666ff78 ; HotFix.BattleLogic.DropMgr$$AbsorbAll
0065CCE5C  strb     w8, [x19, #0x1d4]
0065CCE70  bl       #0x68510f8 ; HotFix.BattleLogic.ExpAnimProcessor$$IsIdle
0065CCE78  ldr      w8, [x19, #0x1cc]
0065CCE90  bl       #0x6850f28 ; HotFix.BattleLogic.ExpAnimProcessor$$CanLevelUp
0065CCE94  ldr      w8, [x19, #0x1cc]
```

### QueueSelectSkill

```asm
0065CC900  cmp      w8, #4
0065CCDC4  bl       #0x6851208 ; HotFix.BattleLogic.ExpAnimProcessor$$IsAdding
0065CCE54  bl       #0x666ff78 ; HotFix.BattleLogic.DropMgr$$AbsorbAll
0065CCE5C  strb     w8, [x19, #0x1d4]
0065CCE70  bl       #0x68510f8 ; HotFix.BattleLogic.ExpAnimProcessor$$IsIdle
0065CCE78  ldr      w8, [x19, #0x1cc]
0065CCE90  bl       #0x6850f28 ; HotFix.BattleLogic.ExpAnimProcessor$$CanLevelUp
0065CCE94  ldr      w8, [x19, #0x1cc]
```

### MarkWaveEndSelectSkillFinished

```asm
0065C8A44  cmp      w8, #2
```

### TryContinueWaveEndUpLevelAfterSelection

```asm
0065C8C88  cmp      w8, #3
```

### WaveModelLevelUp

```asm

```

### CheckStopByEliteOrBossKilled

```asm
0065D66C4  cmp      w0, #0xc9
0065D6708  cmp      w0, #3
0065D6828  cmp      w23, #1
0065D6884  mul      x8, x0, x21
0065D6888  asr      x0, x8, #0x10
0065D6940  csel     x29, x8, x24, eq
```

### CheckGoNextMission

```asm
0065D4CD0  cmp      w8, #3
0065D4D28  cmp      w20, #1
0065D4D30  cmp      w8, #9
0065D4D8C  bl       #0x65d4824 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckNeedPause
```

## HeroComponentRandomSkill

### GetDeltaWeightPercent

```asm
006869FE0  bl       #0x64db89c ; LocalModels.LocalModelManager$$GetSkill_SkillTypeWeight
006869FF4  bl       #0x6871660 ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetSkillCountByType
00686A0E0  smulh    x8, x8, x9
00686A0EC  asr      x10, x8, #0x16
00686A118  mul      x19, x20, x19
00686A150  smulh    x8, x8, x9
00686A158  asr      x9, x8, #0x16
00686A164  csel     x0, x19, x8, lt
```

### UpdateLearnedSkillCount

```asm
00686AF78  bl       #0x5221efc ; Rock.Collections.OrderedDictionary<int, int>$$ContainsKey
00686AFDC  bl       #0x5221cd0 ; Rock.Collections.OrderedDictionary<int, int>$$set_Item
```

### DecreaseLearnedSkillCount

```asm
006869D98  bl       #0x5221efc ; Rock.Collections.OrderedDictionary<int, int>$$ContainsKey
006869DFC  bl       #0x5221cd0 ; Rock.Collections.OrderedDictionary<int, int>$$set_Item
```

### RecalculateAllWeight

```asm
00686C684  bl       #0x6633750 ; HotFix.BattleLogic.WeightRandom$$RecalculateAllWeight
```

### GroupSkillsByType

```asm
00686C23C  bl       #0x5225d20 ; Rock.Collections.OrderedDictionary<int, object>$$ContainsKey
00686C288  bl       #0x5225af4 ; Rock.Collections.OrderedDictionary<int, object>$$set_Item
00686C374  cmp      w21, #5
00686C3E4  bl       #0x5221cd0 ; Rock.Collections.OrderedDictionary<int, int>$$set_Item
00686C474  cmp      w1, #1
00686C508  cmp      w1, #1
```

## WeightRandom

### UpdateWeightPercent

```asm
006632854  cmp      w8, #1
```

### BoostWeightByPercent

```asm
006633874  cmp      w8, #1
```

### RevertWeightBoost

```asm
006633958  cmp      w8, #1
```

### RecalculateAllWeight

```asm
00663379C  cmp      w8, #1
```
