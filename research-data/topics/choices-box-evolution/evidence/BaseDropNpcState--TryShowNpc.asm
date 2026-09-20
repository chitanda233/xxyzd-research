; HotFix.BattleLogic.BaseDropNpcState$$TryShowNpc
; RVA 0x65989A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065989A4  stp      x30, x21, [sp, #-0x20]!
0065989A8  stp      x20, x19, [sp, #0x10]
0065989AC  adrp     x20, #0x9599000
0065989B0  adrp     x21, #0x8f08000
0065989B4  ldrb     w8, [x20, #0x2f1]
0065989B8  ldr      x21, [x21, #0xca8] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.TryShowNpc() @ 0x923b0a8
0065989BC  mov      x19, x0
0065989C0  tbnz     w8, #0, #0x65989d8
0065989C4  adrp     x0, #0x8f08000
0065989C8  ldr      x0, [x0, #0xca8] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.TryShowNpc() @ 0x923b0a8
0065989CC  bl       #0x382bd14 ; 
0065989D0  mov      w8, #1
0065989D4  strb     w8, [x20, #0x2f1]
0065989D8  ldr      x1, [x21]
0065989DC  ldrb     w8, [x1, #0x53]
0065989E0  tbnz     w8, #5, #0x6598a0c
0065989E4  ldrb     w8, [x19, #0x22]
0065989E8  cbz      w8, #0x6598a00
0065989EC  ldrb     w8, [x19, #0x23]
0065989F0  cbz      w8, #0x6598a00
0065989F4  mov      x0, x19
0065989F8  bl       #0x6598a20 ; HotFix.BattleLogic.BaseDropNpcState$$TryShowBox
0065989FC  strb     wzr, [x19, #0x22]
006598A00  ldp      x20, x19, [sp, #0x10]
006598A04  ldp      x30, x21, [sp], #0x20
006598A08  ret      
006598A0C  ldr      x2, [x1, #0x60]
006598A10  mov      x0, x19
006598A14  ldp      x20, x19, [sp, #0x10]
006598A18  ldp      x30, x21, [sp], #0x20
006598A1C  br       x2

