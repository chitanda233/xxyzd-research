; HotFix.BattleLogic.AIMoveInTwoPointsAndAttack$$SetAIData
; RVA 0x654ADC0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654ADC0  str      x30, [sp, #-0x30]!
00654ADC4  stp      x22, x21, [sp, #0x10]
00654ADC8  stp      x20, x19, [sp, #0x20]
00654ADCC  adrp     x21, #0x9598000
00654ADD0  adrp     x22, #0x8f05000
00654ADD4  ldrb     w8, [x21, #0xe33]
00654ADD8  ldr      x22, [x22, #0x7e8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttack.SetAIData()
00654ADDC  mov      x19, x1
00654ADE0  mov      x20, x0
00654ADE4  tbnz     w8, #0, #0x654ae08
00654ADE8  adrp     x0, #0x8f05000
00654ADEC  ldr      x0, [x0, #0x7e8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveInTwoPointsAndAttack.SetAIData()
00654ADF0  bl       #0x382bd14 ; 
00654ADF4  adrp     x0, #0x8f05000
00654ADF8  ldr      x0, [x0, #0x7d0] ; GLOBAL HotFix.BattleLogic.AIMoveInTwoPointsAndAttack.Data_TypeInfo
00654ADFC  bl       #0x382bd14 ; 
00654AE00  mov      w8, #1
00654AE04  strb     w8, [x21, #0xe33]
00654AE08  ldr      x2, [x22]
00654AE0C  ldrb     w8, [x2, #0x53]
00654AE10  tbnz     w8, #5, #0x654ae78
00654AE14  cbz      x19, #0x654ae94
00654AE18  adrp     x8, #0x8f05000
00654AE1C  ldr      x8, [x8, #0x7d0] ; GLOBAL HotFix.BattleLogic.AIMoveInTwoPointsAndAttack.Data_TypeInfo
00654AE20  ldr      x9, [x19]
00654AE24  ldr      x1, [x8]
00654AE28  ldrb     w10, [x9, #0x130]
00654AE2C  ldrb     w8, [x1, #0x130]
00654AE30  cmp      w10, w8
00654AE34  b.lo     #0x654aeb0
00654AE38  ldr      x10, [x9, #0xc8]
00654AE3C  sub      x9, x8, #1
00654AE40  ldr      x10, [x10, x9, lsl #3]
00654AE44  cmp      x10, x1
00654AE48  b.ne     #0x654aeb0
00654AE4C  str      x19, [x20, #0x118]
00654AE50  ldr      x10, [x19]
00654AE54  ldrb     w11, [x10, #0x130]
00654AE58  cmp      w11, w8
00654AE5C  b.lo     #0x654aeb0
00654AE60  ldr      x8, [x10, #0xc8]
00654AE64  ldr      x8, [x8, x9, lsl #3]
00654AE68  cmp      x8, x1
00654AE6C  b.ne     #0x654aeb0
00654AE70  add      x0, x20, #0x118
00654AE74  b        #0x654ae9c ; 
00654AE78  ldr      x3, [x2, #0x60]
00654AE7C  mov      x0, x20
00654AE80  mov      x1, x19
00654AE84  ldp      x20, x19, [sp, #0x20]
00654AE88  ldp      x22, x21, [sp, #0x10]
00654AE8C  ldr      x30, [sp], #0x30
00654AE90  br       x3
00654AE94  add      x0, x20, #0x118
00654AE98  str      xzr, [x20, #0x118]
00654AE9C  mov      x1, x19
00654AEA0  ldp      x20, x19, [sp, #0x20]
00654AEA4  ldp      x22, x21, [sp, #0x10]
00654AEA8  ldr      x30, [sp], #0x30
00654AEAC  b        #0x382bcb8 ; 
00654AEB0  mov      x0, x19
00654AEB4  bl       #0x382c354 ; 

