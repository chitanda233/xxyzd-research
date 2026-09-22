; HotFix.BattleLogic.AIMoveOnPathAttackLoopBorn$$SetAIData
; RVA 0x654C3B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654C3B4  str      x30, [sp, #-0x30]!
00654C3B8  stp      x22, x21, [sp, #0x10]
00654C3BC  stp      x20, x19, [sp, #0x20]
00654C3C0  adrp     x21, #0x9598000
00654C3C4  adrp     x22, #0x8f05000
00654C3C8  ldrb     w8, [x21, #0xe45]
00654C3CC  ldr      x22, [x22, #0x8f8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBorn.SetAIData()
00654C3D0  mov      x19, x1
00654C3D4  mov      x20, x0
00654C3D8  tbnz     w8, #0, #0x654c3fc
00654C3DC  adrp     x0, #0x8f05000
00654C3E0  ldr      x0, [x0, #0x8f8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBorn.SetAIData()
00654C3E4  bl       #0x382bd14 ; 
00654C3E8  adrp     x0, #0x8f05000
00654C3EC  ldr      x0, [x0, #0x8e0] ; GLOBAL HotFix.BattleLogic.AIMoveOnPathAttackLoopBorn.Data_TypeInfo
00654C3F0  bl       #0x382bd14 ; 
00654C3F4  mov      w8, #1
00654C3F8  strb     w8, [x21, #0xe45]
00654C3FC  ldr      x2, [x22]
00654C400  ldrb     w8, [x2, #0x53]
00654C404  tbnz     w8, #5, #0x654c46c
00654C408  cbz      x19, #0x654c488
00654C40C  adrp     x8, #0x8f05000
00654C410  ldr      x8, [x8, #0x8e0] ; GLOBAL HotFix.BattleLogic.AIMoveOnPathAttackLoopBorn.Data_TypeInfo
00654C414  ldr      x9, [x19]
00654C418  ldr      x1, [x8]
00654C41C  ldrb     w10, [x9, #0x130]
00654C420  ldrb     w8, [x1, #0x130]
00654C424  cmp      w10, w8
00654C428  b.lo     #0x654c4a4
00654C42C  ldr      x10, [x9, #0xc8]
00654C430  sub      x9, x8, #1
00654C434  ldr      x10, [x10, x9, lsl #3]
00654C438  cmp      x10, x1
00654C43C  b.ne     #0x654c4a4
00654C440  str      x19, [x20, #0x118]
00654C444  ldr      x10, [x19]
00654C448  ldrb     w11, [x10, #0x130]
00654C44C  cmp      w11, w8
00654C450  b.lo     #0x654c4a4
00654C454  ldr      x8, [x10, #0xc8]
00654C458  ldr      x8, [x8, x9, lsl #3]
00654C45C  cmp      x8, x1
00654C460  b.ne     #0x654c4a4
00654C464  add      x0, x20, #0x118
00654C468  b        #0x654c490 ; 
00654C46C  ldr      x3, [x2, #0x60]
00654C470  mov      x0, x20
00654C474  mov      x1, x19
00654C478  ldp      x20, x19, [sp, #0x20]
00654C47C  ldp      x22, x21, [sp, #0x10]
00654C480  ldr      x30, [sp], #0x30
00654C484  br       x3
00654C488  add      x0, x20, #0x118
00654C48C  str      xzr, [x20, #0x118]
00654C490  mov      x1, x19
00654C494  ldp      x20, x19, [sp, #0x20]
00654C498  ldp      x22, x21, [sp, #0x10]
00654C49C  ldr      x30, [sp], #0x30
00654C4A0  b        #0x382bcb8 ; 
00654C4A4  mov      x0, x19
00654C4A8  bl       #0x382c354 ; 

