; HotFix.BattleLogic.WeightRandomData$$PracticalWeight
; RVA 0x6632120; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632120  stp      x30, x21, [sp, #-0x20]!
006632124  stp      x20, x19, [sp, #0x10]
006632128  adrp     x20, #0x9599000
00663212C  adrp     x21, #0x8f0c000
006632130  ldrb     w8, [x20, #0x9c5]
006632134  ldr      x21, [x21, #0xec8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.PracticalWeight() @ 0x92cbbb8
006632138  mov      x19, x0
00663213C  tbnz     w8, #0, #0x6632154
006632140  adrp     x0, #0x8f0c000
006632144  ldr      x0, [x0, #0xec8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.PracticalWeight() @ 0x92cbbb8
006632148  bl       #0x382bd14 ; 
00663214C  mov      w8, #1
006632150  strb     w8, [x20, #0x9c5]
006632154  ldr      x1, [x21]
006632158  ldrb     w8, [x1, #0x53]
00663215C  tbnz     w8, #5, #0x6632180
006632160  ldr      x8, [x19, #0x18]
006632164  ldrsw    x9, [x19, #4]
006632168  ldp      x20, x19, [sp, #0x10]
00663216C  add      x8, x8, #0x10, lsl #12
006632170  mul      x8, x8, x9
006632174  lsr      x0, x8, #0x10
006632178  ldp      x30, x21, [sp], #0x20
00663217C  ret      
006632180  ldr      x2, [x1, #0x60]
006632184  mov      x0, x19
006632188  ldp      x20, x19, [sp, #0x10]
00663218C  ldp      x30, x21, [sp], #0x20
006632190  br       x2

