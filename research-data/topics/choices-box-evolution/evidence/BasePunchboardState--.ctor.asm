; HotFix.BattleLogic.BasePunchboardState$$.ctor
; RVA 0x65A043C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065A043C  stp      x30, x21, [sp, #-0x20]!
0065A0440  stp      x20, x19, [sp, #0x10]
0065A0444  adrp     x20, #0x9599000
0065A0448  adrp     x21, #0x8f09000
0065A044C  ldrb     w8, [x20, #0x337]
0065A0450  ldr      x21, [x21, #0xf0] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState..ctor() @ 0x923b6a0
0065A0454  mov      x19, x0
0065A0458  tbnz     w8, #0, #0x65a0470
0065A045C  adrp     x0, #0x8f09000
0065A0460  ldr      x0, [x0, #0xf0] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState..ctor() @ 0x923b6a0
0065A0464  bl       #0x382bd14 ; 
0065A0468  mov      w8, #1
0065A046C  strb     w8, [x20, #0x337]
0065A0470  ldr      x1, [x21]
0065A0474  ldrb     w8, [x1, #0x53]
0065A0478  tbnz     w8, #5, #0x65a048c
0065A047C  mov      x0, x19
0065A0480  ldp      x20, x19, [sp, #0x10]
0065A0484  ldp      x30, x21, [sp], #0x20
0065A0488  b        #0x6597214 ; HotFix.BattleLogic.SingleState$$.ctor
0065A048C  ldr      x2, [x1, #0x60]
0065A0490  mov      x0, x19
0065A0494  ldp      x20, x19, [sp, #0x10]
0065A0498  ldp      x30, x21, [sp], #0x20
0065A049C  br       x2

