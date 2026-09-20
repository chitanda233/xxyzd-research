; HotFix.BattleLogic.AIPunchboard$$.ctor
; RVA 0x6B8AD64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B8AD64  stp      x30, x21, [sp, #-0x20]!
006B8AD68  stp      x20, x19, [sp, #0x10]
006B8AD6C  adrp     x20, #0x959f000
006B8AD70  adrp     x21, #0x8f43000
006B8AD74  ldrb     w8, [x20, #0xf7f]
006B8AD78  ldr      x21, [x21, #0x890] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard..ctor() @ 0x92323d8
006B8AD7C  mov      x19, x0
006B8AD80  tbnz     w8, #0, #0x6b8ada4
006B8AD84  adrp     x0, #0x8f43000
006B8AD88  ldr      x0, [x0, #0x890] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard..ctor() @ 0x92323d8
006B8AD8C  bl       #0x382bd14 ; 
006B8AD90  adrp     x0, #0x8f05000
006B8AD94  ldr      x0, [x0, #0x650] ; GLOBAL HotFix.BattleLogic.AIStateController_TypeInfo @ 0x91dff80
006B8AD98  bl       #0x382bd14 ; 
006B8AD9C  mov      w8, #1
006B8ADA0  strb     w8, [x20, #0xf7f]
006B8ADA4  ldr      x1, [x21]
006B8ADA8  ldrb     w8, [x1, #0x53]
006B8ADAC  tbnz     w8, #5, #0x6b8ade0
006B8ADB0  adrp     x8, #0x8f05000
006B8ADB4  ldr      x8, [x8, #0x650] ; GLOBAL HotFix.BattleLogic.AIStateController_TypeInfo @ 0x91dff80
006B8ADB8  mov      w9, #1
006B8ADBC  strb     w9, [x19, #0x149]
006B8ADC0  ldr      x0, [x8]
006B8ADC4  ldr      w8, [x0, #0xe0]
006B8ADC8  cbnz     w8, #0x6b8add0
006B8ADCC  bl       #0x382be8c ; 
006B8ADD0  mov      x0, x19
006B8ADD4  ldp      x20, x19, [sp, #0x10]
006B8ADD8  ldp      x30, x21, [sp], #0x20
006B8ADDC  b        #0x6b7febc ; HotFix.BattleLogic.AIStateController$$.ctor
006B8ADE0  ldr      x2, [x1, #0x60]
006B8ADE4  mov      x0, x19
006B8ADE8  ldp      x20, x19, [sp, #0x10]
006B8ADEC  ldp      x30, x21, [sp], #0x20
006B8ADF0  br       x2

