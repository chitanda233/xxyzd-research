; HotFix.BattleLogic.HeroComponentRandomSkill$$GetBoxRandomSkills
; RVA 0x686F134; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686F134  stp      x30, x21, [sp, #-0x20]!
00686F138  stp      x20, x19, [sp, #0x10]
00686F13C  adrp     x20, #0x959b000
00686F140  adrp     x21, #0x8f24000
00686F144  ldrb     w8, [x20, #0xa59]
00686F148  ldr      x21, [x21, #0x290] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.GetBoxRandomSkills() @ 0x927f9c0
00686F14C  mov      x19, x0
00686F150  tbnz     w8, #0, #0x686f1a4
00686F154  adrp     x0, #0x8ee8000
00686F158  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00686F15C  bl       #0x382bd14 ; 
00686F160  adrp     x0, #0x8ee6000
00686F164  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00686F168  bl       #0x382bd14 ; 
00686F16C  adrp     x0, #0x8f23000
00686F170  ldr      x0, [x0, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00686F174  bl       #0x382bd14 ; 
00686F178  adrp     x0, #0x8ee3000
00686F17C  ldr      x0, [x0, #0xf48] ; GLOBAL Method$System.Linq.Enumerable.ToArray<int>() @ 0x92658e8
00686F180  bl       #0x382bd14 ; 
00686F184  adrp     x0, #0x8f24000
00686F188  ldr      x0, [x0, #0x290] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.GetBoxRandomSkills() @ 0x927f9c0
00686F18C  bl       #0x382bd14 ; 
00686F190  adrp     x0, #0x8f24000
00686F194  ldr      x0, [x0, #0x298] ; GLOBAL BoxSkillUpRate% @ 0x92f3280
00686F198  bl       #0x382bd14 ; 
00686F19C  mov      w8, #1
00686F1A0  strb     w8, [x20, #0xa59]
00686F1A4  ldr      x1, [x21]
00686F1A8  ldrb     w8, [x1, #0x53]
00686F1AC  tbnz     w8, #5, #0x686f200
00686F1B0  adrp     x21, #0x8ee8000
00686F1B4  ldr      x21, [x21, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00686F1B8  adrp     x20, #0x8f23000
00686F1BC  ldr      x0, [x21]
00686F1C0  ldr      w8, [x0, #0xe0]
00686F1C4  ldr      x20, [x20, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00686F1C8  cbnz     w8, #0x686f1d4
00686F1CC  bl       #0x382be8c ; 
00686F1D0  ldr      x0, [x21]
00686F1D4  ldr      x8, [x0, #0xb8]
00686F1D8  ldr      x1, [x19, #0xa8]
00686F1DC  mov      w2, #3
00686F1E0  mov      x3, xzr
00686F1E4  ldr      x0, [x8, #0x1f8]
00686F1E8  bl       #0x7c01418 ; System.Array$$Copy
00686F1EC  ldr      x1, [x20]
00686F1F0  ldrb     w8, [x1, #0x53]
00686F1F4  tbnz     w8, #5, #0x686f214
00686F1F8  ldr      x0, [x19, #0x30]
00686F1FC  b        #0x686f220 ; 
00686F200  ldr      x2, [x1, #0x60]
00686F204  mov      x0, x19
00686F208  ldp      x20, x19, [sp, #0x10]
00686F20C  ldp      x30, x21, [sp], #0x20
00686F210  br       x2
00686F214  ldr      x8, [x1, #0x60]
00686F218  mov      x0, x19
00686F21C  blr      x8
00686F220  cbz      x0, #0x686f38c
00686F224  adrp     x8, #0x8ee6000
00686F228  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00686F22C  ldr      x1, [x8]
00686F230  ldrb     w8, [x1, #0x53]
00686F234  tbnz     w8, #5, #0x686f240
00686F238  ldr      x20, [x0, #0x38]
00686F23C  b        #0x686f24c ; 
00686F240  ldr      x8, [x1, #0x60]
00686F244  blr      x8
00686F248  mov      x20, x0
00686F24C  cbz      x20, #0x686f38c
00686F250  adrp     x21, #0x9591000
00686F254  ldrb     w8, [x21, #0xa7f]
00686F258  cbnz     w8, #0x686f270
00686F25C  adrp     x0, #0x8ee6000
00686F260  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686F264  bl       #0x382bd14 ; 
00686F268  mov      w8, #1
00686F26C  strb     w8, [x21, #0xa7f]
00686F270  adrp     x8, #0x8ee6000
00686F274  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686F278  ldr      x1, [x8]
00686F27C  ldrb     w8, [x1, #0x53]
00686F280  tbnz     w8, #5, #0x686f28c
00686F284  ldr      x0, [x20, #0x178]
00686F288  b        #0x686f298 ; 
00686F28C  ldr      x8, [x1, #0x60]
00686F290  mov      x0, x20
00686F294  blr      x8
00686F298  cbz      x0, #0x686f38c
00686F29C  adrp     x8, #0x8f24000
00686F2A0  ldr      x8, [x8, #0x298] ; GLOBAL BoxSkillUpRate% @ 0x92f3280
00686F2A4  mov      x2, xzr
00686F2A8  ldr      x1, [x8]
00686F2AC  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
00686F2B0  cmp      x0, #1
00686F2B4  b.lt     #0x686f324
00686F2B8  ldr      x21, [x19, #0xa8]
00686F2BC  cbz      x21, #0x686f38c
00686F2C0  ldr      w8, [x21, #0x18]
00686F2C4  cmp      w8, #1
00686F2C8  b.ls     #0x686f390
00686F2CC  ldrsw    x8, [x21, #0x24]
00686F2D0  add      x20, x0, #0x10, lsl #12
00686F2D4  mov      x1, xzr
00686F2D8  mul      x0, x20, x8
00686F2DC  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
00686F2E0  ldr      w8, [x21, #0x18]
00686F2E4  cmp      w8, #1
00686F2E8  b.ls     #0x686f390
00686F2EC  str      w0, [x21, #0x24]
00686F2F0  ldr      x21, [x19, #0xa8]
00686F2F4  cbz      x21, #0x686f38c
00686F2F8  ldr      w8, [x21, #0x18]
00686F2FC  cmp      w8, #2
00686F300  b.ls     #0x686f390
00686F304  ldrsw    x8, [x21, #0x28]
00686F308  mov      x1, xzr
00686F30C  mul      x0, x20, x8
00686F310  bl       #0x7d46e9c ; Photon.Deterministic.FPMath$$RoundToInt
00686F314  ldr      w8, [x21, #0x18]
00686F318  cmp      w8, #2
00686F31C  b.ls     #0x686f390
00686F320  str      w0, [x21, #0x28]
00686F324  mov      x0, x19
00686F328  bl       #0x686de10 ; HotFix.BattleLogic.HeroComponentRandomSkill$$CheckQualityUp
00686F32C  add      x20, x19, #0x60
00686F330  mov      w21, w0
00686F334  mov      x0, x20
00686F338  bl       #0x68666e4 ; HotFix.BattleLogic.BoxSkillResult$$Clear
00686F33C  ldr      x0, [x19, #0x88]
00686F340  cbz      x0, #0x686f38c
00686F344  ldr      x8, [x0]
00686F348  ldr      x2, [x19, #0xa8]
00686F34C  and      w3, w21, #1
00686F350  mov      x1, x20
00686F354  ldr      x9, [x8, #0x268]
00686F358  ldr      x4, [x8, #0x270]
00686F35C  blr      x9
00686F360  adrp     x8, #0x8ee3000
00686F364  ldr      x0, [x19, #0x50]
00686F368  ldr      x8, [x8, #0xf48] ; GLOBAL Method$System.Linq.Enumerable.ToArray<int>() @ 0x92658e8
00686F36C  ldr      x1, [x8]
00686F370  bl       #0x45d921c ; System.Linq.Enumerable$$ToArray<int>
00686F374  str      x0, [x19, #0x70]!
00686F378  mov      x1, x0
00686F37C  mov      x0, x19
00686F380  ldp      x20, x19, [sp, #0x10]
00686F384  ldp      x30, x21, [sp], #0x20
00686F388  b        #0x382bcb8 ; 
00686F38C  bl       #0x382bfb8 ; 
00686F390  bl       #0x382bfc0 ; 

