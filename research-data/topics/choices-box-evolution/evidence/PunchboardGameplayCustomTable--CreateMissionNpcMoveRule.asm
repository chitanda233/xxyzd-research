; HotFix.BattleLogic.PunchboardGameplayCustomTable$$CreateMissionNpcMoveRule
; RVA 0x65BD11C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BD11C  sub      sp, sp, #0x60
0065BD120  stp      x30, x21, [sp, #0x40]
0065BD124  stp      x20, x19, [sp, #0x50]
0065BD128  adrp     x20, #0x9599000
0065BD12C  adrp     x21, #0x8f0a000
0065BD130  mov      x19, x8
0065BD134  ldrb     w8, [x20, #0x494]
0065BD138  ldr      x21, [x21, #0xf8] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.CreateMissionNpcMoveRule() @ 0x929b938
0065BD13C  tbnz     w8, #0, #0x65bd160
0065BD140  adrp     x0, #0x8f0a000
0065BD144  ldr      x0, [x0, #0xf8] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.CreateMissionNpcMoveRule() @ 0x929b938
0065BD148  bl       #0x382bd14 ; 
0065BD14C  adrp     x0, #0x8f0a000
0065BD150  ldr      x0, [x0, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BD154  bl       #0x382bd14 ; 
0065BD158  mov      w8, #1
0065BD15C  strb     w8, [x20, #0x494]
0065BD160  ldr      x0, [x21]
0065BD164  ldrb     w8, [x0, #0x53]
0065BD168  tbnz     w8, #5, #0x65bd1dc
0065BD16C  adrp     x8, #0x8f0a000
0065BD170  ldr      x8, [x8, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BD174  ldr      x0, [x8]
0065BD178  ldr      w8, [x0, #0xe0]
0065BD17C  cbnz     w8, #0x65bd184
0065BD180  bl       #0x382be8c ; 
0065BD184  mov      x4, #-0x10000
0065BD188  add      x8, sp, #8
0065BD18C  mov      w0, #2
0065BD190  mov      w1, #1
0065BD194  mov      w2, #0x40000
0065BD198  mov      w3, #0x60000
0065BD19C  movk     x4, #0xfffd, lsl #16
0065BD1A0  mov      w5, #0x30000
0065BD1A4  mov      w6, #0x30000
0065BD1A8  mov      w7, #0x50000
0065BD1AC  bl       #0x65bce54 ; HotFix.BattleLogic.PunchboardGameplayCustomTable$$BuildRule
0065BD1B0  ldr      x8, [sp, #0x38]
0065BD1B4  ldur     q0, [sp, #0x28]
0065BD1B8  ldur     q1, [sp, #0x18]
0065BD1BC  ldur     q2, [sp, #8]
0065BD1C0  str      x8, [x19, #0x30]
0065BD1C4  ldp      x30, x21, [sp, #0x40]
0065BD1C8  stp      q1, q0, [x19, #0x10]
0065BD1CC  str      q2, [x19]
0065BD1D0  ldp      x20, x19, [sp, #0x50]
0065BD1D4  add      sp, sp, #0x60
0065BD1D8  ret      
0065BD1DC  ldr      x1, [x0, #0x60]
0065BD1E0  mov      x8, x19
0065BD1E4  ldp      x20, x19, [sp, #0x50]
0065BD1E8  ldp      x30, x21, [sp, #0x40]
0065BD1EC  add      sp, sp, #0x60
0065BD1F0  br       x1

