; HotFix.BattleLogic.EntityTreasure$$GetMonsterId
; RVA 0x68D318C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D318C  stp      x30, x21, [sp, #-0x20]!
0068D3190  stp      x20, x19, [sp, #0x10]
0068D3194  adrp     x20, #0x959c000
0068D3198  adrp     x21, #0x8f28000
0068D319C  ldrb     w8, [x20, #0x773]
0068D31A0  ldr      x21, [x21, #0x868] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.GetMonsterId() @ 0x9264418
0068D31A4  mov      x19, x0
0068D31A8  tbnz     w8, #0, #0x68d31c0
0068D31AC  adrp     x0, #0x8f28000
0068D31B0  ldr      x0, [x0, #0x868] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.GetMonsterId() @ 0x9264418
0068D31B4  bl       #0x382bd14 ; 
0068D31B8  mov      w8, #1
0068D31BC  strb     w8, [x20, #0x773]
0068D31C0  ldr      x1, [x21]
0068D31C4  ldrb     w8, [x1, #0x53]
0068D31C8  tbnz     w8, #5, #0x68d31dc
0068D31CC  ldr      w0, [x19, #0x63c]
0068D31D0  ldp      x20, x19, [sp, #0x10]
0068D31D4  ldp      x30, x21, [sp], #0x20
0068D31D8  ret      
0068D31DC  ldr      x2, [x1, #0x60]
0068D31E0  mov      x0, x19
0068D31E4  ldp      x20, x19, [sp, #0x10]
0068D31E8  ldp      x30, x21, [sp], #0x20
0068D31EC  br       x2

