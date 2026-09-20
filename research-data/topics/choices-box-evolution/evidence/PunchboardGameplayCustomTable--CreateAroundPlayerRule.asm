; HotFix.BattleLogic.PunchboardGameplayCustomTable$$CreateAroundPlayerRule
; RVA 0x65BCF6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BCF6C  sub      sp, sp, #0x60
0065BCF70  stp      x30, x21, [sp, #0x40]
0065BCF74  stp      x20, x19, [sp, #0x50]
0065BCF78  adrp     x20, #0x9599000
0065BCF7C  adrp     x21, #0x8f0a000
0065BCF80  mov      x19, x8
0065BCF84  ldrb     w8, [x20, #0x492]
0065BCF88  ldr      x21, [x21, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.CreateAroundPlayerRule() @ 0x929b928
0065BCF8C  tbnz     w8, #0, #0x65bcfb0
0065BCF90  adrp     x0, #0x8f0a000
0065BCF94  ldr      x0, [x0, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.CreateAroundPlayerRule() @ 0x929b928
0065BCF98  bl       #0x382bd14 ; 
0065BCF9C  adrp     x0, #0x8f0a000
0065BCFA0  ldr      x0, [x0, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BCFA4  bl       #0x382bd14 ; 
0065BCFA8  mov      w8, #1
0065BCFAC  strb     w8, [x20, #0x492]
0065BCFB0  ldr      x0, [x21]
0065BCFB4  ldrb     w8, [x0, #0x53]
0065BCFB8  tbnz     w8, #5, #0x65bd02c
0065BCFBC  adrp     x8, #0x8f0a000
0065BCFC0  ldr      x8, [x8, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BCFC4  ldr      x0, [x8]
0065BCFC8  ldr      w8, [x0, #0xe0]
0065BCFCC  cbnz     w8, #0x65bcfd4
0065BCFD0  bl       #0x382be8c ; 
0065BCFD4  mov      x4, #-0x10000
0065BCFD8  add      x8, sp, #8
0065BCFDC  mov      w0, #3
0065BCFE0  mov      w1, #2
0065BCFE4  mov      w2, #0x40000
0065BCFE8  mov      w3, #0x60000
0065BCFEC  movk     x4, #0xfffd, lsl #16
0065BCFF0  mov      w5, #0x30000
0065BCFF4  mov      w6, #0x30000
0065BCFF8  mov      w7, #0x50000
0065BCFFC  bl       #0x65bce54 ; HotFix.BattleLogic.PunchboardGameplayCustomTable$$BuildRule
0065BD000  ldr      x8, [sp, #0x38]
0065BD004  ldur     q0, [sp, #0x28]
0065BD008  ldur     q1, [sp, #0x18]
0065BD00C  ldur     q2, [sp, #8]
0065BD010  str      x8, [x19, #0x30]
0065BD014  ldp      x30, x21, [sp, #0x40]
0065BD018  stp      q1, q0, [x19, #0x10]
0065BD01C  str      q2, [x19]
0065BD020  ldp      x20, x19, [sp, #0x50]
0065BD024  add      sp, sp, #0x60
0065BD028  ret      
0065BD02C  ldr      x1, [x0, #0x60]
0065BD030  mov      x8, x19
0065BD034  ldp      x20, x19, [sp, #0x50]
0065BD038  ldp      x30, x21, [sp, #0x40]
0065BD03C  add      sp, sp, #0x60
0065BD040  br       x1

