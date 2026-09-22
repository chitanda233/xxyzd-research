; HotFix.BattleLogic.EntityCharacterData$$get_IsTypeMonsterBoss
; RVA 0x6823598; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006823598  stp      x30, x21, [sp, #-0x20]!
00682359C  stp      x20, x19, [sp, #0x10]
0068235A0  adrp     x20, #0x959b000
0068235A4  adrp     x21, #0x8f22000
0068235A8  ldrb     w8, [x20, #0x6c8]
0068235AC  ldr      x21, [x21, #0x98] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsTypeMonsterBoss()
0068235B0  mov      x19, x0
0068235B4  tbnz     w8, #0, #0x68235cc
0068235B8  adrp     x0, #0x8f22000
0068235BC  ldr      x0, [x0, #0x98] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsTypeMonsterBoss()
0068235C0  bl       #0x382bd14 ; 
0068235C4  mov      w8, #1
0068235C8  strb     w8, [x20, #0x6c8]
0068235CC  ldr      x1, [x21]
0068235D0  ldrb     w8, [x1, #0x53]
0068235D4  tbnz     w8, #5, #0x68235f4
0068235D8  mov      x0, x19
0068235DC  bl       #0x6823340 ; HotFix.BattleLogic.EntityCharacterData$$get_CharacterType
0068235E0  ldp      x20, x19, [sp, #0x10]
0068235E4  cmp      w0, #3
0068235E8  cset     w0, eq
0068235EC  ldp      x30, x21, [sp], #0x20
0068235F0  ret      
0068235F4  ldr      x2, [x1, #0x60]
0068235F8  mov      x0, x19
0068235FC  ldp      x20, x19, [sp, #0x10]
006823600  ldp      x30, x21, [sp], #0x20
006823604  br       x2

