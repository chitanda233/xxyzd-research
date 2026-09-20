; HotFix.BattleLogic.MainDropManager$$get_WaveGold
; RVA 0x667179C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00667179C  stp      x30, x21, [sp, #-0x20]!
0066717A0  stp      x20, x19, [sp, #0x10]
0066717A4  adrp     x20, #0x9599000
0066717A8  adrp     x21, #0x8f0f000
0066717AC  ldrb     w8, [x20, #0xde2]
0066717B0  ldr      x21, [x21, #0x750] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.get_WaveGold() @ 0x928dc28
0066717B4  mov      x19, x0
0066717B8  tbnz     w8, #0, #0x66717dc
0066717BC  adrp     x0, #0x8f08000
0066717C0  ldr      x0, [x0, #0xab0] ; GLOBAL LocalModels.Bean.IMainChapter_TypeInfo @ 0x91e9d80
0066717C4  bl       #0x382bd14 ; 
0066717C8  adrp     x0, #0x8f0f000
0066717CC  ldr      x0, [x0, #0x750] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.get_WaveGold() @ 0x928dc28
0066717D0  bl       #0x382bd14 ; 
0066717D4  mov      w8, #1
0066717D8  strb     w8, [x20, #0xde2]
0066717DC  ldr      x1, [x21]
0066717E0  ldrb     w8, [x1, #0x53]
0066717E4  tbnz     w8, #5, #0x6671838
0066717E8  ldr      x19, [x19, #0x50]
0066717EC  cbz      x19, #0x6671864
0066717F0  adrp     x10, #0x8f08000
0066717F4  ldr      x8, [x19]
0066717F8  ldr      x10, [x10, #0xab0] ; GLOBAL LocalModels.Bean.IMainChapter_TypeInfo @ 0x91e9d80
0066717FC  ldrh     w9, [x8, #0x12e]
006671800  ldr      x1, [x10]
006671804  cbz      x9, #0x6671828
006671808  ldr      x10, [x8, #0xb0]
00667180C  add      x10, x10, #8
006671810  ldur     x11, [x10, #-8]
006671814  cmp      x11, x1
006671818  b.eq     #0x6671840
00667181C  subs     x9, x9, #1
006671820  add      x10, x10, #0x10
006671824  b.ne     #0x6671810
006671828  mov      w2, #2
00667182C  mov      x0, x19
006671830  bl       #0x3a7e710 ; 
006671834  b        #0x6671850 ; 
006671838  ldr      x2, [x1, #0x60]
00667183C  b        #0x6671854 ; 
006671840  ldr      w9, [x10]
006671844  add      w9, w9, #2
006671848  add      x8, x8, w9, sxtw #4
00667184C  add      x0, x8, #0x138
006671850  ldp      x2, x1, [x0]
006671854  mov      x0, x19
006671858  ldp      x20, x19, [sp, #0x10]
00667185C  ldp      x30, x21, [sp], #0x20
006671860  br       x2
006671864  bl       #0x382bfb8 ; 

