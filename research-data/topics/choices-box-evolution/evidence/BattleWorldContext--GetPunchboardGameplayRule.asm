; HotFix.BattleLogic.BattleWorldContext$$GetPunchboardGameplayRule
; RVA 0x69FFAC0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069FFAC0  sub      sp, sp, #0xb0
0069FFAC4  str      x30, [sp, #0x80]
0069FFAC8  stp      x22, x21, [sp, #0x90]
0069FFACC  stp      x20, x19, [sp, #0xa0]
0069FFAD0  adrp     x21, #0x959d000
0069FFAD4  adrp     x22, #0x8f32000
0069FFAD8  mov      x19, x8
0069FFADC  ldrb     w8, [x21, #0x52b]
0069FFAE0  ldr      x22, [x22, #0x550] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.GetPunchboardGameplayRule() @ 0x923f9d8
0069FFAE4  mov      x20, x0
0069FFAE8  tbnz     w8, #0, #0x69ffb0c
0069FFAEC  adrp     x0, #0x8f32000
0069FFAF0  ldr      x0, [x0, #0x550] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.GetPunchboardGameplayRule() @ 0x923f9d8
0069FFAF4  bl       #0x382bd14 ; 
0069FFAF8  adrp     x0, #0x8f0a000
0069FFAFC  ldr      x0, [x0, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0069FFB00  bl       #0x382bd14 ; 
0069FFB04  mov      w8, #1
0069FFB08  strb     w8, [x21, #0x52b]
0069FFB0C  ldr      x1, [x22]
0069FFB10  ldrb     w8, [x1, #0x53]
0069FFB14  tbnz     w8, #5, #0x69ffbb0
0069FFB18  ldrb     w8, [x20, #0x360]
0069FFB1C  cbnz     w8, #0x69ffb80
0069FFB20  adrp     x8, #0x8f0a000
0069FFB24  ldr      x8, [x8, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0069FFB28  ldr      w21, [x20, #0x1c8]
0069FFB2C  ldr      x0, [x8]
0069FFB30  ldr      w8, [x0, #0xe0]
0069FFB34  cbnz     w8, #0x69ffb3c
0069FFB38  bl       #0x382be8c ; 
0069FFB3C  add      x8, sp, #8
0069FFB40  mov      w0, w21
0069FFB44  mov      x1, xzr
0069FFB48  bl       #0x65bcc58 ; HotFix.BattleLogic.PunchboardGameplayCustomTable$$GetRule
0069FFB4C  ldr      x8, [sp, #0x38]
0069FFB50  ldur     q0, [sp, #0x28]
0069FFB54  ldur     q1, [sp, #0x18]
0069FFB58  ldur     q2, [sp, #8]
0069FFB5C  add      x9, x20, #0x368
0069FFB60  mov      w10, #1
0069FFB64  str      x8, [sp, #0x70]
0069FFB68  stp      q1, q0, [sp, #0x50]
0069FFB6C  str      q2, [sp, #0x40]
0069FFB70  str      x8, [x9, #0x30]
0069FFB74  stp      q1, q0, [x9, #0x10]
0069FFB78  str      q2, [x9]
0069FFB7C  strb     w10, [x20, #0x360]
0069FFB80  add      x8, x20, #0x368
0069FFB84  ldr      x9, [x8, #0x30]
0069FFB88  ldp      q1, q0, [x8, #0x10]
0069FFB8C  ldr      q2, [x8]
0069FFB90  ldp      x22, x21, [sp, #0x90]
0069FFB94  str      x9, [x19, #0x30]
0069FFB98  stp      q1, q0, [x19, #0x10]
0069FFB9C  str      q2, [x19]
0069FFBA0  ldp      x20, x19, [sp, #0xa0]
0069FFBA4  ldr      x30, [sp, #0x80]
0069FFBA8  add      sp, sp, #0xb0
0069FFBAC  ret      
0069FFBB0  ldr      x2, [x1, #0x60]
0069FFBB4  mov      x8, x19
0069FFBB8  mov      x0, x20
0069FFBBC  ldp      x20, x19, [sp, #0xa0]
0069FFBC0  ldp      x22, x21, [sp, #0x90]
0069FFBC4  ldr      x30, [sp, #0x80]
0069FFBC8  add      sp, sp, #0xb0
0069FFBCC  br       x2

