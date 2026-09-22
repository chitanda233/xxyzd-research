; HotFix.BattleLogic.EntityCharacterData$$get_IsHeroOwnedSubCharacterFollower
; RVA 0x6822610; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006822610  stp      x30, x21, [sp, #-0x20]!
006822614  stp      x20, x19, [sp, #0x10]
006822618  adrp     x20, #0x959b000
00682261C  adrp     x21, #0x8f20000
006822620  ldrb     w8, [x20, #0x6b9]
006822624  ldr      x21, [x21, #0xb8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsHeroOwnedSubCharacterFollower()
006822628  mov      x19, x0
00682262C  tbnz     w8, #0, #0x6822644
006822630  adrp     x0, #0x8f20000
006822634  ldr      x0, [x0, #0xb8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsHeroOwnedSubCharacterFollower()
006822638  bl       #0x382bd14 ; 
00682263C  mov      w8, #1
006822640  strb     w8, [x20, #0x6b9]
006822644  ldr      x1, [x21]
006822648  ldrb     w8, [x1, #0x53]
00682264C  tbnz     w8, #5, #0x68226c0
006822650  adrp     x20, #0x9591000
006822654  ldrb     w8, [x20, #0xa73]
006822658  cbnz     w8, #0x6822670
00682265C  adrp     x0, #0x8ee6000
006822660  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822664  bl       #0x382bd14 ; 
006822668  mov      w8, #1
00682266C  strb     w8, [x20, #0xa73]
006822670  adrp     x8, #0x8ee6000
006822674  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822678  ldr      x1, [x8]
00682267C  ldrb     w8, [x1, #0x53]
006822680  tbnz     w8, #5, #0x6822724
006822684  adrp     x20, #0x9591000
006822688  ldrb     w8, [x20, #0xa74]
00682268C  cbnz     w8, #0x68226a4
006822690  adrp     x0, #0x8ee6000
006822694  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822698  bl       #0x382bd14 ; 
00682269C  mov      w8, #1
0068226A0  strb     w8, [x20, #0xa74]
0068226A4  adrp     x8, #0x8ee6000
0068226A8  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068226AC  ldr      x1, [x8]
0068226B0  ldrb     w8, [x1, #0x53]
0068226B4  tbnz     w8, #5, #0x68226d4
0068226B8  ldr      x19, [x19, #0x170]
0068226BC  b        #0x68226e4 ; 
0068226C0  ldr      x2, [x1, #0x60]
0068226C4  mov      x0, x19
0068226C8  ldp      x20, x19, [sp, #0x10]
0068226CC  ldp      x30, x21, [sp], #0x20
0068226D0  br       x2
0068226D4  ldr      x8, [x1, #0x60]
0068226D8  mov      x0, x19
0068226DC  blr      x8
0068226E0  mov      x19, x0
0068226E4  cbz      x19, #0x6822740
0068226E8  adrp     x20, #0x9591000
0068226EC  ldrb     w8, [x20, #0xa75]
0068226F0  cbnz     w8, #0x6822708
0068226F4  adrp     x0, #0x8ee6000
0068226F8  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0068226FC  bl       #0x382bd14 ; 
006822700  mov      w8, #1
006822704  strb     w8, [x20, #0xa75]
006822708  adrp     x8, #0x8ee6000
00682270C  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006822710  ldr      x1, [x8]
006822714  ldrb     w8, [x1, #0x53]
006822718  tbnz     w8, #5, #0x6822724
00682271C  ldr      w0, [x19, #0x24]
006822720  b        #0x6822730 ; 
006822724  ldr      x8, [x1, #0x60]
006822728  mov      x0, x19
00682272C  blr      x8
006822730  ldp      x20, x19, [sp, #0x10]
006822734  mov      x1, xzr
006822738  ldp      x30, x21, [sp], #0x20
00682273C  b        #0x6a4cc3c ; HotFix.BattleLogic.EntityCharacterTypeUtils$$IsHeroOwnedSubCharacterFollower
006822740  bl       #0x382bfb8 ; 

