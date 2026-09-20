; HotFix.BattleLogic.WaterfallStatePunchboard$$.ctor
; RVA 0x65A8F18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065A8F18  stp      x30, x21, [sp, #-0x20]!
0065A8F1C  stp      x20, x19, [sp, #0x10]
0065A8F20  adrp     x20, #0x9599000
0065A8F24  adrp     x21, #0x8f09000
0065A8F28  ldrb     w8, [x20, #0x434]
0065A8F2C  ldr      x21, [x21, #0x638] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStatePunchboard..ctor() @ 0x92c8848
0065A8F30  mov      x19, x0
0065A8F34  tbnz     w8, #0, #0x65a8f4c
0065A8F38  adrp     x0, #0x8f09000
0065A8F3C  ldr      x0, [x0, #0x638] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStatePunchboard..ctor() @ 0x92c8848
0065A8F40  bl       #0x382bd14 ; 
0065A8F44  mov      w8, #1
0065A8F48  strb     w8, [x20, #0x434]
0065A8F4C  ldr      x1, [x21]
0065A8F50  ldrb     w8, [x1, #0x53]
0065A8F54  tbnz     w8, #5, #0x65a8f68
0065A8F58  mov      x0, x19
0065A8F5C  ldp      x20, x19, [sp, #0x10]
0065A8F60  ldp      x30, x21, [sp], #0x20
0065A8F64  b        #0x65a043c ; HotFix.BattleLogic.BasePunchboardState$$.ctor
0065A8F68  ldr      x2, [x1, #0x60]
0065A8F6C  mov      x0, x19
0065A8F70  ldp      x20, x19, [sp, #0x10]
0065A8F74  ldp      x30, x21, [sp], #0x20
0065A8F78  br       x2

