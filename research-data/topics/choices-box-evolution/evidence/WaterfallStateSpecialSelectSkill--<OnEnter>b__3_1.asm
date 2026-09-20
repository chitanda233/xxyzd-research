; HotFix.BattleLogic.WaterfallStateSpecialSelectSkill$$<OnEnter>b__3_1
; RVA 0x65B7E68; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B7E68  stp      x30, x21, [sp, #-0x20]!
0065B7E6C  stp      x20, x19, [sp, #0x10]
0065B7E70  adrp     x20, #0x9599000
0065B7E74  adrp     x21, #0x8f09000
0065B7E78  ldrb     w8, [x20, #0x44e]
0065B7E7C  ldr      x21, [x21, #0xcc0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_1() @ 0x92c88d0
0065B7E80  mov      x19, x0
0065B7E84  tbnz     w8, #0, #0x65b7e9c
0065B7E88  adrp     x0, #0x8f09000
0065B7E8C  ldr      x0, [x0, #0xcc0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_1() @ 0x92c88d0
0065B7E90  bl       #0x382bd14 ; 
0065B7E94  mov      w8, #1
0065B7E98  strb     w8, [x20, #0x44e]
0065B7E9C  ldr      x1, [x21]
0065B7EA0  ldrb     w8, [x1, #0x53]
0065B7EA4  tbnz     w8, #5, #0x65b7ec0
0065B7EA8  ldr      w8, [x19, #0x20]
0065B7EAC  ldp      x20, x19, [sp, #0x10]
0065B7EB0  cmp      w8, #0
0065B7EB4  cset     w0, gt
0065B7EB8  ldp      x30, x21, [sp], #0x20
0065B7EBC  ret      
0065B7EC0  ldr      x2, [x1, #0x60]
0065B7EC4  mov      x0, x19
0065B7EC8  ldp      x20, x19, [sp, #0x10]
0065B7ECC  ldp      x30, x21, [sp], #0x20
0065B7ED0  br       x2

