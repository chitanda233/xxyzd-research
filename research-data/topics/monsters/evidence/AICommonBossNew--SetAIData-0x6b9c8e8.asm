; HotFix.BattleLogic.AICommonBossNew$$SetAIData
; RVA 0x6B9C8E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B9C8E8  str      x30, [sp, #-0x30]!
006B9C8EC  stp      x22, x21, [sp, #0x10]
006B9C8F0  stp      x20, x19, [sp, #0x20]
006B9C8F4  adrp     x21, #0x95a0000
006B9C8F8  adrp     x22, #0x8f44000
006B9C8FC  ldrb     w8, [x21, #0x8b]
006B9C900  ldr      x22, [x22, #0x208] ; GLOBAL Method$HotFix.BattleLogic.AICommonBossNew.SetAIData()
006B9C904  mov      x19, x1
006B9C908  mov      x20, x0
006B9C90C  tbnz     w8, #0, #0x6b9c930
006B9C910  adrp     x0, #0x8f44000
006B9C914  ldr      x0, [x0, #0x208] ; GLOBAL Method$HotFix.BattleLogic.AICommonBossNew.SetAIData()
006B9C918  bl       #0x382bd14 ; 
006B9C91C  adrp     x0, #0x8f06000
006B9C920  ldr      x0, [x0, #0x770] ; GLOBAL HotFix.BattleLogic.AICommonBoss.Data_TypeInfo
006B9C924  bl       #0x382bd14 ; 
006B9C928  mov      w8, #1
006B9C92C  strb     w8, [x21, #0x8b]
006B9C930  ldr      x2, [x22]
006B9C934  ldrb     w8, [x2, #0x53]
006B9C938  tbnz     w8, #5, #0x6b9c9a0
006B9C93C  cbz      x19, #0x6b9c9bc
006B9C940  adrp     x8, #0x8f06000
006B9C944  ldr      x8, [x8, #0x770] ; GLOBAL HotFix.BattleLogic.AICommonBoss.Data_TypeInfo
006B9C948  ldr      x9, [x19]
006B9C94C  ldr      x1, [x8]
006B9C950  ldrb     w10, [x9, #0x130]
006B9C954  ldrb     w8, [x1, #0x130]
006B9C958  cmp      w10, w8
006B9C95C  b.lo     #0x6b9c9e0
006B9C960  ldr      x10, [x9, #0xc8]
006B9C964  sub      x9, x8, #1
006B9C968  ldr      x10, [x10, x9, lsl #3]
006B9C96C  cmp      x10, x1
006B9C970  b.ne     #0x6b9c9e0
006B9C974  str      x19, [x20, #0x118]
006B9C978  ldr      x10, [x19]
006B9C97C  ldrb     w11, [x10, #0x130]
006B9C980  cmp      w11, w8
006B9C984  b.lo     #0x6b9c9e0
006B9C988  ldr      x8, [x10, #0xc8]
006B9C98C  ldr      x8, [x8, x9, lsl #3]
006B9C990  cmp      x8, x1
006B9C994  b.ne     #0x6b9c9e0
006B9C998  add      x0, x20, #0x118
006B9C99C  b        #0x6b9c9c4 ; 
006B9C9A0  ldr      x3, [x2, #0x60]
006B9C9A4  mov      x0, x20
006B9C9A8  mov      x1, x19
006B9C9AC  ldp      x20, x19, [sp, #0x20]
006B9C9B0  ldp      x22, x21, [sp, #0x10]
006B9C9B4  ldr      x30, [sp], #0x30
006B9C9B8  br       x3
006B9C9BC  add      x0, x20, #0x118
006B9C9C0  str      xzr, [x20, #0x118]
006B9C9C4  mov      x1, x19
006B9C9C8  bl       #0x382bcb8 ; 
006B9C9CC  mov      x0, x20
006B9C9D0  ldp      x20, x19, [sp, #0x20]
006B9C9D4  ldp      x22, x21, [sp, #0x10]
006B9C9D8  ldr      x30, [sp], #0x30
006B9C9DC  b        #0x6b9bce0 ; HotFix.BattleLogic.AICommonBossNew$$onGetDataParams
006B9C9E0  mov      x0, x19
006B9C9E4  bl       #0x382c354 ; 

