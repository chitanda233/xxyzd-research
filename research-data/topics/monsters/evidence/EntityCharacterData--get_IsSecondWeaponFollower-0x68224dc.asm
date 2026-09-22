; HotFix.BattleLogic.EntityCharacterData$$get_IsSecondWeaponFollower
; RVA 0x68224DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068224DC  stp      x30, x21, [sp, #-0x20]!
0068224E0  stp      x20, x19, [sp, #0x10]
0068224E4  adrp     x20, #0x959b000
0068224E8  adrp     x21, #0x8f20000
0068224EC  ldrb     w8, [x20, #0x6b8]
0068224F0  ldr      x21, [x21, #0xc0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsSecondWeaponFollower()
0068224F4  mov      x19, x0
0068224F8  tbnz     w8, #0, #0x6822510
0068224FC  adrp     x0, #0x8f20000
006822500  ldr      x0, [x0, #0xc0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsSecondWeaponFollower()
006822504  bl       #0x382bd14 ; 
006822508  mov      w8, #1
00682250C  strb     w8, [x20, #0x6b8]
006822510  ldr      x1, [x21]
006822514  ldrb     w8, [x1, #0x53]
006822518  tbnz     w8, #5, #0x682258c
00682251C  adrp     x20, #0x9591000
006822520  ldrb     w8, [x20, #0xa73]
006822524  cbnz     w8, #0x682253c
006822528  adrp     x0, #0x8ee6000
00682252C  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822530  bl       #0x382bd14 ; 
006822534  mov      w8, #1
006822538  strb     w8, [x20, #0xa73]
00682253C  adrp     x8, #0x8ee6000
006822540  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822544  ldr      x1, [x8]
006822548  ldrb     w8, [x1, #0x53]
00682254C  tbnz     w8, #5, #0x68225f0
006822550  adrp     x20, #0x9591000
006822554  ldrb     w8, [x20, #0xa74]
006822558  cbnz     w8, #0x6822570
00682255C  adrp     x0, #0x8ee6000
006822560  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822564  bl       #0x382bd14 ; 
006822568  mov      w8, #1
00682256C  strb     w8, [x20, #0xa74]
006822570  adrp     x8, #0x8ee6000
006822574  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822578  ldr      x1, [x8]
00682257C  ldrb     w8, [x1, #0x53]
006822580  tbnz     w8, #5, #0x68225a0
006822584  ldr      x19, [x19, #0x170]
006822588  b        #0x68225b0 ; 
00682258C  ldr      x2, [x1, #0x60]
006822590  mov      x0, x19
006822594  ldp      x20, x19, [sp, #0x10]
006822598  ldp      x30, x21, [sp], #0x20
00682259C  br       x2
0068225A0  ldr      x8, [x1, #0x60]
0068225A4  mov      x0, x19
0068225A8  blr      x8
0068225AC  mov      x19, x0
0068225B0  cbz      x19, #0x682260c
0068225B4  adrp     x20, #0x9591000
0068225B8  ldrb     w8, [x20, #0xa75]
0068225BC  cbnz     w8, #0x68225d4
0068225C0  adrp     x0, #0x8ee6000
0068225C4  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0068225C8  bl       #0x382bd14 ; 
0068225CC  mov      w8, #1
0068225D0  strb     w8, [x20, #0xa75]
0068225D4  adrp     x8, #0x8ee6000
0068225D8  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0068225DC  ldr      x1, [x8]
0068225E0  ldrb     w8, [x1, #0x53]
0068225E4  tbnz     w8, #5, #0x68225f0
0068225E8  ldr      w0, [x19, #0x24]
0068225EC  b        #0x68225fc ; 
0068225F0  ldr      x8, [x1, #0x60]
0068225F4  mov      x0, x19
0068225F8  blr      x8
0068225FC  ldp      x20, x19, [sp, #0x10]
006822600  mov      x1, xzr
006822604  ldp      x30, x21, [sp], #0x20
006822608  b        #0x6a4cca8 ; HotFix.BattleLogic.EntityCharacterTypeUtils$$IsSecondWeaponFollower
00682260C  bl       #0x382bfb8 ; 

