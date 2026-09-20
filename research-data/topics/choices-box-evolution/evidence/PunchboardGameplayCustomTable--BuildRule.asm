; HotFix.BattleLogic.PunchboardGameplayCustomTable$$BuildRule
; RVA 0x65BCE54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BCE54  sub      sp, sp, #0x70
0065BCE58  stp      x29, x30, [sp, #0x10]
0065BCE5C  stp      x28, x27, [sp, #0x20]
0065BCE60  stp      x26, x25, [sp, #0x30]
0065BCE64  stp      x24, x23, [sp, #0x40]
0065BCE68  stp      x22, x21, [sp, #0x50]
0065BCE6C  stp      x20, x19, [sp, #0x60]
0065BCE70  adrp     x28, #0x9599000
0065BCE74  adrp     x29, #0x8f0a000
0065BCE78  mov      x27, x8
0065BCE7C  ldrb     w8, [x28, #0x496]
0065BCE80  ldr      x29, [x29, #0xe0] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.BuildRule() @ 0x929b918
0065BCE84  mov      x22, x7
0065BCE88  mov      x19, x6
0065BCE8C  mov      x20, x5
0065BCE90  mov      x21, x4
0065BCE94  mov      x23, x3
0065BCE98  mov      x24, x2
0065BCE9C  mov      w25, w1
0065BCEA0  mov      w26, w0
0065BCEA4  tbnz     w8, #0, #0x65bcebc
0065BCEA8  adrp     x0, #0x8f0a000
0065BCEAC  ldr      x0, [x0, #0xe0] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.BuildRule() @ 0x929b918
0065BCEB0  bl       #0x382bd14 ; 
0065BCEB4  mov      w8, #1
0065BCEB8  strb     w8, [x28, #0x496]
0065BCEBC  ldr      x8, [x29]
0065BCEC0  ldrb     w9, [x8, #0x53]
0065BCEC4  tbnz     w9, #5, #0x65bcf20
0065BCEC8  movi     v0.2d, #0000000000000000
0065BCECC  mov      x0, x27
0065BCED0  mov      w1, w26
0065BCED4  mov      w2, w25
0065BCED8  mov      x3, x24
0065BCEDC  mov      x4, x23
0065BCEE0  mov      x5, x21
0065BCEE4  mov      x6, x20
0065BCEE8  mov      x7, x19
0065BCEEC  str      xzr, [x27, #0x30]
0065BCEF0  stp      q0, q0, [x27, #0x10]
0065BCEF4  str      q0, [x27]
0065BCEF8  str      x22, [sp]
0065BCEFC  bl       #0x65bcb78 ; HotFix.BattleLogic.PunchboardGameplayRule$$.ctor
0065BCF00  ldp      x20, x19, [sp, #0x60]
0065BCF04  ldp      x22, x21, [sp, #0x50]
0065BCF08  ldp      x24, x23, [sp, #0x40]
0065BCF0C  ldp      x26, x25, [sp, #0x30]
0065BCF10  ldp      x28, x27, [sp, #0x20]
0065BCF14  ldp      x29, x30, [sp, #0x10]
0065BCF18  add      sp, sp, #0x70
0065BCF1C  ret      
0065BCF20  ldr      x9, [x8, #0x60]
0065BCF24  str      x8, [sp, #0x70]
0065BCF28  mov      x8, x27
0065BCF2C  mov      w0, w26
0065BCF30  mov      w1, w25
0065BCF34  mov      x2, x24
0065BCF38  mov      x3, x23
0065BCF3C  mov      x4, x21
0065BCF40  mov      x5, x20
0065BCF44  mov      x6, x19
0065BCF48  mov      x7, x22
0065BCF4C  ldp      x20, x19, [sp, #0x60]
0065BCF50  ldp      x22, x21, [sp, #0x50]
0065BCF54  ldp      x24, x23, [sp, #0x40]
0065BCF58  ldp      x26, x25, [sp, #0x30]
0065BCF5C  ldp      x28, x27, [sp, #0x20]
0065BCF60  ldp      x29, x30, [sp, #0x10]
0065BCF64  add      sp, sp, #0x70
0065BCF68  br       x9

