; HotFix.BattleLogic.AIRandomMoveAndAttack$$SetAIData
; RVA 0x6555A60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006555A60  str      x30, [sp, #-0x30]!
006555A64  stp      x22, x21, [sp, #0x10]
006555A68  stp      x20, x19, [sp, #0x20]
006555A6C  adrp     x21, #0x9598000
006555A70  adrp     x22, #0x8f05000
006555A74  ldrb     w8, [x21, #0xeaf]
006555A78  ldr      x22, [x22, #0xe28] ; GLOBAL Method$HotFix.BattleLogic.AIRandomMoveAndAttack.SetAIData()
006555A7C  mov      x19, x1
006555A80  mov      x20, x0
006555A84  tbnz     w8, #0, #0x6555aa8
006555A88  adrp     x0, #0x8f05000
006555A8C  ldr      x0, [x0, #0xe28] ; GLOBAL Method$HotFix.BattleLogic.AIRandomMoveAndAttack.SetAIData()
006555A90  bl       #0x382bd14 ; 
006555A94  adrp     x0, #0x8f05000
006555A98  ldr      x0, [x0, #0xe10] ; GLOBAL HotFix.BattleLogic.AIRandomMoveAndAttack.Data_TypeInfo
006555A9C  bl       #0x382bd14 ; 
006555AA0  mov      w8, #1
006555AA4  strb     w8, [x21, #0xeaf]
006555AA8  ldr      x2, [x22]
006555AAC  ldrb     w8, [x2, #0x53]
006555AB0  tbnz     w8, #5, #0x6555b18
006555AB4  cbz      x19, #0x6555b34
006555AB8  adrp     x8, #0x8f05000
006555ABC  ldr      x8, [x8, #0xe10] ; GLOBAL HotFix.BattleLogic.AIRandomMoveAndAttack.Data_TypeInfo
006555AC0  ldr      x9, [x19]
006555AC4  ldr      x1, [x8]
006555AC8  ldrb     w10, [x9, #0x130]
006555ACC  ldrb     w8, [x1, #0x130]
006555AD0  cmp      w10, w8
006555AD4  b.lo     #0x6555b50
006555AD8  ldr      x10, [x9, #0xc8]
006555ADC  sub      x9, x8, #1
006555AE0  ldr      x10, [x10, x9, lsl #3]
006555AE4  cmp      x10, x1
006555AE8  b.ne     #0x6555b50
006555AEC  str      x19, [x20, #0x118]
006555AF0  ldr      x10, [x19]
006555AF4  ldrb     w11, [x10, #0x130]
006555AF8  cmp      w11, w8
006555AFC  b.lo     #0x6555b50
006555B00  ldr      x8, [x10, #0xc8]
006555B04  ldr      x8, [x8, x9, lsl #3]
006555B08  cmp      x8, x1
006555B0C  b.ne     #0x6555b50
006555B10  add      x0, x20, #0x118
006555B14  b        #0x6555b3c ; 
006555B18  ldr      x3, [x2, #0x60]
006555B1C  mov      x0, x20
006555B20  mov      x1, x19
006555B24  ldp      x20, x19, [sp, #0x20]
006555B28  ldp      x22, x21, [sp, #0x10]
006555B2C  ldr      x30, [sp], #0x30
006555B30  br       x3
006555B34  add      x0, x20, #0x118
006555B38  str      xzr, [x20, #0x118]
006555B3C  mov      x1, x19
006555B40  ldp      x20, x19, [sp, #0x20]
006555B44  ldp      x22, x21, [sp, #0x10]
006555B48  ldr      x30, [sp], #0x30
006555B4C  b        #0x382bcb8 ; 
006555B50  mov      x0, x19
006555B54  bl       #0x382c354 ; 

