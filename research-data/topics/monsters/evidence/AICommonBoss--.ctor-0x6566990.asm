; HotFix.BattleLogic.AICommonBoss$$.ctor
; RVA 0x6566990; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006566990  stp      x30, x21, [sp, #-0x20]!
006566994  stp      x20, x19, [sp, #0x10]
006566998  adrp     x20, #0x9598000
00656699C  adrp     x21, #0x8f06000
0065669A0  ldrb     w8, [x20, #0xf97]
0065669A4  ldr      x21, [x21, #0x8e8] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss..ctor()
0065669A8  mov      x19, x0
0065669AC  tbnz     w8, #0, #0x65669d0
0065669B0  adrp     x0, #0x8f06000
0065669B4  ldr      x0, [x0, #0x8e8] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss..ctor()
0065669B8  bl       #0x382bd14 ; 
0065669BC  adrp     x0, #0x8f05000
0065669C0  ldr      x0, [x0, #0x650] ; GLOBAL HotFix.BattleLogic.AIStateController_TypeInfo
0065669C4  bl       #0x382bd14 ; 
0065669C8  mov      w8, #1
0065669CC  strb     w8, [x20, #0xf97]
0065669D0  ldr      x1, [x21]
0065669D4  ldrb     w8, [x1, #0x53]
0065669D8  tbnz     w8, #5, #0x6566a4c
0065669DC  adrp     x10, #0x1982000
0065669E0  ldr      q0, [x10, #0x150]
0065669E4  adrp     x10, #0x1981000
0065669E8  adrp     x8, #0x8f05000
0065669EC  ldr      q1, [x10, #0xd70]
0065669F0  adrp     x10, #0x1981000
0065669F4  ldr      x8, [x8, #0x650] ; GLOBAL HotFix.BattleLogic.AIStateController_TypeInfo
0065669F8  str      q0, [x19, #0x130]
0065669FC  ldr      q0, [x10, #0x170]
006566A00  mov      w9, #0xa0000
006566A04  str      x9, [x19, #0x120]
006566A08  mov      w9, #0x10000
006566A0C  str      x9, [x19, #0x140]
006566A10  mov      w9, #0x20000
006566A14  add      x10, x19, #0x1a8
006566A18  stp      q1, q0, [x19, #0x150]
006566A1C  dup      v0.2d, x9
006566A20  str      q0, [x10]
006566A24  str      x9, [x19, #0x1b8]
006566A28  ldr      x0, [x8]
006566A2C  ldr      w8, [x0, #0xe0]
006566A30  cbnz     w8, #0x6566a38
006566A34  bl       #0x382be8c ; 
006566A38  mov      x0, x19
006566A3C  ldp      x20, x19, [sp, #0x10]
006566A40  mov      x1, xzr
006566A44  ldp      x30, x21, [sp], #0x20
006566A48  b        #0x6b7febc ; HotFix.BattleLogic.AIStateController$$.ctor
006566A4C  ldr      x2, [x1, #0x60]
006566A50  mov      x0, x19
006566A54  ldp      x20, x19, [sp, #0x10]
006566A58  ldp      x30, x21, [sp], #0x20
006566A5C  br       x2

