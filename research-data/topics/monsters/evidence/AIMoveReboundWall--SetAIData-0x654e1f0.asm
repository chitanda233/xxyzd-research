; HotFix.BattleLogic.AIMoveReboundWall$$SetAIData
; RVA 0x654E1F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654E1F0  str      x30, [sp, #-0x30]!
00654E1F4  stp      x22, x21, [sp, #0x10]
00654E1F8  stp      x20, x19, [sp, #0x20]
00654E1FC  adrp     x21, #0x9598000
00654E200  adrp     x22, #0x8f05000
00654E204  ldrb     w8, [x21, #0xe62]
00654E208  ldr      x22, [x22, #0xa48] ; GLOBAL Method$HotFix.BattleLogic.AIMoveReboundWall.SetAIData()
00654E20C  mov      x19, x1
00654E210  mov      x20, x0
00654E214  tbnz     w8, #0, #0x654e238
00654E218  adrp     x0, #0x8f05000
00654E21C  ldr      x0, [x0, #0xa48] ; GLOBAL Method$HotFix.BattleLogic.AIMoveReboundWall.SetAIData()
00654E220  bl       #0x382bd14 ; 
00654E224  adrp     x0, #0x8f05000
00654E228  ldr      x0, [x0, #0xa30] ; GLOBAL HotFix.BattleLogic.AIMoveReboundWall.Data_TypeInfo
00654E22C  bl       #0x382bd14 ; 
00654E230  mov      w8, #1
00654E234  strb     w8, [x21, #0xe62]
00654E238  ldr      x2, [x22]
00654E23C  ldrb     w8, [x2, #0x53]
00654E240  tbnz     w8, #5, #0x654e2a8
00654E244  cbz      x19, #0x654e2c4
00654E248  adrp     x8, #0x8f05000
00654E24C  ldr      x8, [x8, #0xa30] ; GLOBAL HotFix.BattleLogic.AIMoveReboundWall.Data_TypeInfo
00654E250  ldr      x9, [x19]
00654E254  ldr      x1, [x8]
00654E258  ldrb     w10, [x9, #0x130]
00654E25C  ldrb     w8, [x1, #0x130]
00654E260  cmp      w10, w8
00654E264  b.lo     #0x654e2e0
00654E268  ldr      x10, [x9, #0xc8]
00654E26C  sub      x9, x8, #1
00654E270  ldr      x10, [x10, x9, lsl #3]
00654E274  cmp      x10, x1
00654E278  b.ne     #0x654e2e0
00654E27C  str      x19, [x20, #0x118]
00654E280  ldr      x10, [x19]
00654E284  ldrb     w11, [x10, #0x130]
00654E288  cmp      w11, w8
00654E28C  b.lo     #0x654e2e0
00654E290  ldr      x8, [x10, #0xc8]
00654E294  ldr      x8, [x8, x9, lsl #3]
00654E298  cmp      x8, x1
00654E29C  b.ne     #0x654e2e0
00654E2A0  add      x0, x20, #0x118
00654E2A4  b        #0x654e2cc ; 
00654E2A8  ldr      x3, [x2, #0x60]
00654E2AC  mov      x0, x20
00654E2B0  mov      x1, x19
00654E2B4  ldp      x20, x19, [sp, #0x20]
00654E2B8  ldp      x22, x21, [sp, #0x10]
00654E2BC  ldr      x30, [sp], #0x30
00654E2C0  br       x3
00654E2C4  add      x0, x20, #0x118
00654E2C8  str      xzr, [x20, #0x118]
00654E2CC  mov      x1, x19
00654E2D0  ldp      x20, x19, [sp, #0x20]
00654E2D4  ldp      x22, x21, [sp, #0x10]
00654E2D8  ldr      x30, [sp], #0x30
00654E2DC  b        #0x382bcb8 ; 
00654E2E0  mov      x0, x19
00654E2E4  bl       #0x382c354 ; 

