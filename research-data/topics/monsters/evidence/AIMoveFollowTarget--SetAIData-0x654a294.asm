; HotFix.BattleLogic.AIMoveFollowTarget$$SetAIData
; RVA 0x654A294; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654A294  str      x30, [sp, #-0x30]!
00654A298  stp      x22, x21, [sp, #0x10]
00654A29C  stp      x20, x19, [sp, #0x20]
00654A2A0  adrp     x21, #0x9598000
00654A2A4  adrp     x22, #0x8f05000
00654A2A8  ldrb     w8, [x21, #0xe28]
00654A2AC  ldr      x22, [x22, #0x760] ; GLOBAL Method$HotFix.BattleLogic.AIMoveFollowTarget.SetAIData()
00654A2B0  mov      x19, x1
00654A2B4  mov      x20, x0
00654A2B8  tbnz     w8, #0, #0x654a2dc
00654A2BC  adrp     x0, #0x8f05000
00654A2C0  ldr      x0, [x0, #0x760] ; GLOBAL Method$HotFix.BattleLogic.AIMoveFollowTarget.SetAIData()
00654A2C4  bl       #0x382bd14 ; 
00654A2C8  adrp     x0, #0x8f05000
00654A2CC  ldr      x0, [x0, #0x748] ; GLOBAL HotFix.BattleLogic.AIMoveFollowTarget.Data_TypeInfo
00654A2D0  bl       #0x382bd14 ; 
00654A2D4  mov      w8, #1
00654A2D8  strb     w8, [x21, #0xe28]
00654A2DC  ldr      x2, [x22]
00654A2E0  ldrb     w8, [x2, #0x53]
00654A2E4  tbnz     w8, #5, #0x654a34c
00654A2E8  cbz      x19, #0x654a368
00654A2EC  adrp     x8, #0x8f05000
00654A2F0  ldr      x8, [x8, #0x748] ; GLOBAL HotFix.BattleLogic.AIMoveFollowTarget.Data_TypeInfo
00654A2F4  ldr      x9, [x19]
00654A2F8  ldr      x1, [x8]
00654A2FC  ldrb     w10, [x9, #0x130]
00654A300  ldrb     w8, [x1, #0x130]
00654A304  cmp      w10, w8
00654A308  b.lo     #0x654a384
00654A30C  ldr      x10, [x9, #0xc8]
00654A310  sub      x9, x8, #1
00654A314  ldr      x10, [x10, x9, lsl #3]
00654A318  cmp      x10, x1
00654A31C  b.ne     #0x654a384
00654A320  str      x19, [x20, #0x118]
00654A324  ldr      x10, [x19]
00654A328  ldrb     w11, [x10, #0x130]
00654A32C  cmp      w11, w8
00654A330  b.lo     #0x654a384
00654A334  ldr      x8, [x10, #0xc8]
00654A338  ldr      x8, [x8, x9, lsl #3]
00654A33C  cmp      x8, x1
00654A340  b.ne     #0x654a384
00654A344  add      x0, x20, #0x118
00654A348  b        #0x654a370 ; 
00654A34C  ldr      x3, [x2, #0x60]
00654A350  mov      x0, x20
00654A354  mov      x1, x19
00654A358  ldp      x20, x19, [sp, #0x20]
00654A35C  ldp      x22, x21, [sp, #0x10]
00654A360  ldr      x30, [sp], #0x30
00654A364  br       x3
00654A368  add      x0, x20, #0x118
00654A36C  str      xzr, [x20, #0x118]
00654A370  mov      x1, x19
00654A374  ldp      x20, x19, [sp, #0x20]
00654A378  ldp      x22, x21, [sp, #0x10]
00654A37C  ldr      x30, [sp], #0x30
00654A380  b        #0x382bcb8 ; 
00654A384  mov      x0, x19
00654A388  bl       #0x382c354 ; 

