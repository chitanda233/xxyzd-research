; HotFix.BattleLogic.MainDropManager$$get_WaveExp
; RVA 0x6671868; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671868  stp      x30, x21, [sp, #-0x20]!
00667186C  stp      x20, x19, [sp, #0x10]
006671870  adrp     x20, #0x9599000
006671874  adrp     x21, #0x8f0f000
006671878  ldrb     w8, [x20, #0xde3]
00667187C  ldr      x21, [x21, #0x758] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.get_WaveExp() @ 0x928dc20
006671880  mov      x19, x0
006671884  tbnz     w8, #0, #0x66718a8
006671888  adrp     x0, #0x8f08000
00667188C  ldr      x0, [x0, #0xab0] ; GLOBAL LocalModels.Bean.IMainChapter_TypeInfo @ 0x91e9d80
006671890  bl       #0x382bd14 ; 
006671894  adrp     x0, #0x8f0f000
006671898  ldr      x0, [x0, #0x758] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager.get_WaveExp() @ 0x928dc20
00667189C  bl       #0x382bd14 ; 
0066718A0  mov      w8, #1
0066718A4  strb     w8, [x20, #0xde3]
0066718A8  ldr      x1, [x21]
0066718AC  ldrb     w8, [x1, #0x53]
0066718B0  tbnz     w8, #5, #0x6671904
0066718B4  ldr      x19, [x19, #0x50]
0066718B8  cbz      x19, #0x6671930
0066718BC  adrp     x10, #0x8f08000
0066718C0  ldr      x8, [x19]
0066718C4  ldr      x10, [x10, #0xab0] ; GLOBAL LocalModels.Bean.IMainChapter_TypeInfo @ 0x91e9d80
0066718C8  ldrh     w9, [x8, #0x12e]
0066718CC  ldr      x1, [x10]
0066718D0  cbz      x9, #0x66718f4
0066718D4  ldr      x10, [x8, #0xb0]
0066718D8  add      x10, x10, #8
0066718DC  ldur     x11, [x10, #-8]
0066718E0  cmp      x11, x1
0066718E4  b.eq     #0x667190c
0066718E8  subs     x9, x9, #1
0066718EC  add      x10, x10, #0x10
0066718F0  b.ne     #0x66718dc
0066718F4  mov      w2, #4
0066718F8  mov      x0, x19
0066718FC  bl       #0x3a7e710 ; 
006671900  b        #0x667191c ; 
006671904  ldr      x2, [x1, #0x60]
006671908  b        #0x6671920 ; 
00667190C  ldr      w9, [x10]
006671910  add      w9, w9, #4
006671914  add      x8, x8, w9, sxtw #4
006671918  add      x0, x8, #0x138
00667191C  ldp      x2, x1, [x0]
006671920  mov      x0, x19
006671924  ldp      x20, x19, [sp, #0x10]
006671928  ldp      x30, x21, [sp], #0x20
00667192C  br       x2
006671930  bl       #0x382bfb8 ; 

