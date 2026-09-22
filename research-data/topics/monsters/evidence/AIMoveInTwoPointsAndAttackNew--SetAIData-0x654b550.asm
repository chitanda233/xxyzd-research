; HotFix.BattleLogic.AIMoveInTwoPointsAndAttackNew$$SetAIData
; RVA 0x654B550; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654B550  str      x30, [sp, #-0x30]!
00654B554  stp      x22, x21, [sp, #0x10]
00654B558  stp      x20, x19, [sp, #0x20]
00654B55C  adrp     x21, #0x9598000
00654B560  adrp     x22, #0x8f05000
00654B564  ldrb     w8, [x21, #0xe39]
00654B568  ldr      x22, [x22, #0x860] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttackNew.SetAIData()
00654B56C  mov      x19, x1
00654B570  mov      x20, x0
00654B574  tbnz     w8, #0, #0x654b598
00654B578  adrp     x0, #0x8f05000
00654B57C  ldr      x0, [x0, #0x860] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttackNew.SetAIData()
00654B580  bl       #0x382bd14 ; 
00654B584  adrp     x0, #0x8f05000
00654B588  ldr      x0, [x0, #0x848] ; GLOBAL HotFix.BattleLogic.AIMoveInTwoPointsAndAttackNew.Data_TypeInfo
00654B58C  bl       #0x382bd14 ; 
00654B590  mov      w8, #1
00654B594  strb     w8, [x21, #0xe39]
00654B598  ldr      x2, [x22]
00654B59C  ldrb     w8, [x2, #0x53]
00654B5A0  tbnz     w8, #5, #0x654b608
00654B5A4  cbz      x19, #0x654b624
00654B5A8  adrp     x8, #0x8f05000
00654B5AC  ldr      x8, [x8, #0x848] ; GLOBAL HotFix.BattleLogic.AIMoveInTwoPointsAndAttackNew.Data_TypeInfo
00654B5B0  ldr      x9, [x19]
00654B5B4  ldr      x1, [x8]
00654B5B8  ldrb     w10, [x9, #0x130]
00654B5BC  ldrb     w8, [x1, #0x130]
00654B5C0  cmp      w10, w8
00654B5C4  b.lo     #0x654b640
00654B5C8  ldr      x10, [x9, #0xc8]
00654B5CC  sub      x9, x8, #1
00654B5D0  ldr      x10, [x10, x9, lsl #3]
00654B5D4  cmp      x10, x1
00654B5D8  b.ne     #0x654b640
00654B5DC  str      x19, [x20, #0x118]
00654B5E0  ldr      x10, [x19]
00654B5E4  ldrb     w11, [x10, #0x130]
00654B5E8  cmp      w11, w8
00654B5EC  b.lo     #0x654b640
00654B5F0  ldr      x8, [x10, #0xc8]
00654B5F4  ldr      x8, [x8, x9, lsl #3]
00654B5F8  cmp      x8, x1
00654B5FC  b.ne     #0x654b640
00654B600  add      x0, x20, #0x118
00654B604  b        #0x654b62c ; 
00654B608  ldr      x3, [x2, #0x60]
00654B60C  mov      x0, x20
00654B610  mov      x1, x19
00654B614  ldp      x20, x19, [sp, #0x20]
00654B618  ldp      x22, x21, [sp, #0x10]
00654B61C  ldr      x30, [sp], #0x30
00654B620  br       x3
00654B624  add      x0, x20, #0x118
00654B628  str      xzr, [x20, #0x118]
00654B62C  mov      x1, x19
00654B630  ldp      x20, x19, [sp, #0x20]
00654B634  ldp      x22, x21, [sp, #0x10]
00654B638  ldr      x30, [sp], #0x30
00654B63C  b        #0x382bcb8 ; 
00654B640  mov      x0, x19
00654B644  bl       #0x382c354 ; 

