; HotFix.BattleLogic.WeightRandomData$$RevertWeightBoost
; RVA 0x6632490; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632490  str      x30, [sp, #-0x30]!
006632494  stp      x22, x21, [sp, #0x10]
006632498  stp      x20, x19, [sp, #0x20]
00663249C  adrp     x21, #0x9599000
0066324A0  adrp     x22, #0x8f0c000
0066324A4  ldrb     w8, [x21, #0x9d1]
0066324A8  ldr      x22, [x22, #0xef8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.RevertWeightBoost() @ 0x92cbbc0
0066324AC  mov      w19, w1
0066324B0  mov      x20, x0
0066324B4  tbnz     w8, #0, #0x66324cc
0066324B8  adrp     x0, #0x8f0c000
0066324BC  ldr      x0, [x0, #0xef8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.RevertWeightBoost() @ 0x92cbbc0
0066324C0  bl       #0x382bd14 ; 
0066324C4  mov      w8, #1
0066324C8  strb     w8, [x21, #0x9d1]
0066324CC  ldr      x2, [x22]
0066324D0  ldrb     w8, [x2, #0x53]
0066324D4  tbnz     w8, #5, #0x66324f4
0066324D8  ldr      w8, [x20, #4]
0066324DC  ldp      x22, x21, [sp, #0x10]
0066324E0  sub      w8, w8, w19
0066324E4  str      w8, [x20, #4]
0066324E8  ldp      x20, x19, [sp, #0x20]
0066324EC  ldr      x30, [sp], #0x30
0066324F0  ret      
0066324F4  ldr      x3, [x2, #0x60]
0066324F8  mov      x0, x20
0066324FC  mov      w1, w19
006632500  ldp      x20, x19, [sp, #0x20]
006632504  ldp      x22, x21, [sp, #0x10]
006632508  ldr      x30, [sp], #0x30
00663250C  br       x3

