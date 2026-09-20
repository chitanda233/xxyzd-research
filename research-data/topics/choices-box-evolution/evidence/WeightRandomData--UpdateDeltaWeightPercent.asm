; HotFix.BattleLogic.WeightRandomData$$UpdateDeltaWeightPercent
; RVA 0x6632194; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006632194  str      x30, [sp, #-0x30]!
006632198  stp      x22, x21, [sp, #0x10]
00663219C  stp      x20, x19, [sp, #0x20]
0066321A0  adrp     x21, #0x9599000
0066321A4  adrp     x22, #0x8f0c000
0066321A8  ldrb     w8, [x21, #0x9c7]
0066321AC  ldr      x22, [x22, #0xed0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.UpdateDeltaWeightPercent() @ 0x92cbbd0
0066321B0  mov      x19, x1
0066321B4  mov      x20, x0
0066321B8  tbnz     w8, #0, #0x66321d0
0066321BC  adrp     x0, #0x8f0c000
0066321C0  ldr      x0, [x0, #0xed0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.UpdateDeltaWeightPercent() @ 0x92cbbd0
0066321C4  bl       #0x382bd14 ; 
0066321C8  mov      w8, #1
0066321CC  strb     w8, [x21, #0x9c7]
0066321D0  ldr      x2, [x22]
0066321D4  ldrb     w8, [x2, #0x53]
0066321D8  tbnz     w8, #5, #0x66321f0
0066321DC  str      x19, [x20, #0x18]
0066321E0  ldp      x20, x19, [sp, #0x20]
0066321E4  ldp      x22, x21, [sp, #0x10]
0066321E8  ldr      x30, [sp], #0x30
0066321EC  ret      
0066321F0  ldr      x3, [x2, #0x60]
0066321F4  mov      x0, x20
0066321F8  mov      x1, x19
0066321FC  ldp      x20, x19, [sp, #0x20]
006632200  ldp      x22, x21, [sp, #0x10]
006632204  ldr      x30, [sp], #0x30
006632208  br       x3

