; HotFix.BattleLogic.BaseBoxState$$OnExit
; RVA 0x65978D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065978D0  str      x30, [sp, #-0x30]!
0065978D4  stp      x22, x21, [sp, #0x10]
0065978D8  stp      x20, x19, [sp, #0x20]
0065978DC  adrp     x21, #0x9599000
0065978E0  adrp     x22, #0x8f08000
0065978E4  ldrb     w8, [x21, #0x2e6]
0065978E8  ldr      x22, [x22, #0xc28] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState.OnExit() @ 0x923afa0
0065978EC  mov      x19, x1
0065978F0  mov      x20, x0
0065978F4  tbnz     w8, #0, #0x659790c
0065978F8  adrp     x0, #0x8f08000
0065978FC  ldr      x0, [x0, #0xc28] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState.OnExit() @ 0x923afa0
006597900  bl       #0x382bd14 ; 
006597904  mov      w8, #1
006597908  strb     w8, [x21, #0x2e6]
00659790C  ldr      x2, [x22]
006597910  ldrb     w8, [x2, #0x53]
006597914  tbnz     w8, #5, #0x6597968
006597918  ldr      x19, [x20, #0x18]
00659791C  cbz      x19, #0x65979a0
006597920  adrp     x20, #0x9599000
006597924  ldrb     w8, [x20, #0x4b0]
006597928  cbnz     w8, #0x6597940
00659792C  adrp     x0, #0x8f08000
006597930  ldr      x0, [x0, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
006597934  bl       #0x382bd14 ; 
006597938  mov      w8, #1
00659793C  strb     w8, [x20, #0x4b0]
006597940  adrp     x8, #0x8f08000
006597944  ldr      x8, [x8, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
006597948  ldr      x2, [x8]
00659794C  ldrb     w8, [x2, #0x53]
006597950  tbnz     w8, #5, #0x6597984
006597954  strb     wzr, [x19, #0x648]
006597958  ldp      x20, x19, [sp, #0x20]
00659795C  ldp      x22, x21, [sp, #0x10]
006597960  ldr      x30, [sp], #0x30
006597964  ret      
006597968  ldr      x3, [x2, #0x60]
00659796C  mov      x0, x20
006597970  mov      x1, x19
006597974  ldp      x20, x19, [sp, #0x20]
006597978  ldp      x22, x21, [sp, #0x10]
00659797C  ldr      x30, [sp], #0x30
006597980  br       x3
006597984  ldr      x3, [x2, #0x60]
006597988  mov      x0, x19
00659798C  ldp      x20, x19, [sp, #0x20]
006597990  ldp      x22, x21, [sp, #0x10]
006597994  mov      w1, wzr
006597998  ldr      x30, [sp], #0x30
00659799C  br       x3
0065979A0  bl       #0x382bfb8 ; 

