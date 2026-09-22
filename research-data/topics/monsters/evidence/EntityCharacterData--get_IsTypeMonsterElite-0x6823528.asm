; HotFix.BattleLogic.EntityCharacterData$$get_IsTypeMonsterElite
; RVA 0x6823528; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006823528  stp      x30, x21, [sp, #-0x20]!
00682352C  stp      x20, x19, [sp, #0x10]
006823530  adrp     x20, #0x959b000
006823534  adrp     x21, #0x8f22000
006823538  ldrb     w8, [x20, #0x6c7]
00682353C  ldr      x21, [x21, #0x90] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsTypeMonsterElite()
006823540  mov      x19, x0
006823544  tbnz     w8, #0, #0x682355c
006823548  adrp     x0, #0x8f22000
00682354C  ldr      x0, [x0, #0x90] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsTypeMonsterElite()
006823550  bl       #0x382bd14 ; 
006823554  mov      w8, #1
006823558  strb     w8, [x20, #0x6c7]
00682355C  ldr      x1, [x21]
006823560  ldrb     w8, [x1, #0x53]
006823564  tbnz     w8, #5, #0x6823584
006823568  mov      x0, x19
00682356C  bl       #0x6823340 ; HotFix.BattleLogic.EntityCharacterData$$get_CharacterType
006823570  ldp      x20, x19, [sp, #0x10]
006823574  cmp      w0, #0xc9
006823578  cset     w0, eq
00682357C  ldp      x30, x21, [sp], #0x20
006823580  ret      
006823584  ldr      x2, [x1, #0x60]
006823588  mov      x0, x19
00682358C  ldp      x20, x19, [sp, #0x10]
006823590  ldp      x30, x21, [sp], #0x20
006823594  br       x2

