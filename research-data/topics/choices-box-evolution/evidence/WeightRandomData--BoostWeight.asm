; HotFix.BattleLogic.WeightRandomData$$BoostWeight
; RVA 0x66323E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066323E4  str      x30, [sp, #-0x30]!
0066323E8  stp      x22, x21, [sp, #0x10]
0066323EC  stp      x20, x19, [sp, #0x20]
0066323F0  adrp     x21, #0x9599000
0066323F4  adrp     x22, #0x8f0c000
0066323F8  ldrb     w8, [x21, #0x9cf]
0066323FC  ldr      x22, [x22, #0xef0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.BoostWeight() @ 0x92cbb80
006632400  mov      w20, w1
006632404  mov      x19, x0
006632408  tbnz     w8, #0, #0x6632420
00663240C  adrp     x0, #0x8f0c000
006632410  ldr      x0, [x0, #0xef0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.BoostWeight() @ 0x92cbb80
006632414  bl       #0x382bd14 ; 
006632418  mov      w8, #1
00663241C  strb     w8, [x21, #0x9cf]
006632420  ldr      x2, [x22]
006632424  ldrb     w8, [x2, #0x53]
006632428  tbnz     w8, #5, #0x6632460
00663242C  ldr      w8, [x19, #4]
006632430  mul      w9, w8, w20
006632434  cmp      w9, #0x64
006632438  b.lt     #0x663247c
00663243C  mov      w10, #0x851f
006632440  movk     w10, #0x51eb, lsl #16
006632444  smull    x9, w9, w10
006632448  lsr      x10, x9, #0x3f
00663244C  asr      x9, x9, #0x25
006632450  add      w0, w9, w10
006632454  add      w8, w0, w8
006632458  str      w8, [x19, #4]
00663245C  b        #0x6632480 ; 
006632460  ldr      x3, [x2, #0x60]
006632464  mov      x0, x19
006632468  mov      w1, w20
00663246C  ldp      x20, x19, [sp, #0x20]
006632470  ldp      x22, x21, [sp, #0x10]
006632474  ldr      x30, [sp], #0x30
006632478  br       x3
00663247C  mov      w0, wzr
006632480  ldp      x20, x19, [sp, #0x20]
006632484  ldp      x22, x21, [sp, #0x10]
006632488  ldr      x30, [sp], #0x30
00663248C  ret      

