; HotFix.BattleLogic.PunchboardGameplayCustomTable$$CreateAroundPlayerMoveRule
; RVA 0x65BD1F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BD1F4  sub      sp, sp, #0x60
0065BD1F8  stp      x30, x21, [sp, #0x40]
0065BD1FC  stp      x20, x19, [sp, #0x50]
0065BD200  adrp     x20, #0x9599000
0065BD204  adrp     x21, #0x8f0a000
0065BD208  mov      x19, x8
0065BD20C  ldrb     w8, [x20, #0x495]
0065BD210  ldr      x21, [x21, #0x100] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.CreateAroundPlayerMoveRule() @ 0x929b920
0065BD214  tbnz     w8, #0, #0x65bd238
0065BD218  adrp     x0, #0x8f0a000
0065BD21C  ldr      x0, [x0, #0x100] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.CreateAroundPlayerMoveRule() @ 0x929b920
0065BD220  bl       #0x382bd14 ; 
0065BD224  adrp     x0, #0x8f0a000
0065BD228  ldr      x0, [x0, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BD22C  bl       #0x382bd14 ; 
0065BD230  mov      w8, #1
0065BD234  strb     w8, [x20, #0x495]
0065BD238  ldr      x0, [x21]
0065BD23C  ldrb     w8, [x0, #0x53]
0065BD240  tbnz     w8, #5, #0x65bd2b4
0065BD244  adrp     x8, #0x8f0a000
0065BD248  ldr      x8, [x8, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BD24C  ldr      x0, [x8]
0065BD250  ldr      w8, [x0, #0xe0]
0065BD254  cbnz     w8, #0x65bd25c
0065BD258  bl       #0x382be8c ; 
0065BD25C  mov      x4, #-0x10000
0065BD260  add      x8, sp, #8
0065BD264  mov      w0, #3
0065BD268  mov      w1, #1
0065BD26C  mov      w2, #0x40000
0065BD270  mov      w3, #0x60000
0065BD274  movk     x4, #0xfffd, lsl #16
0065BD278  mov      w5, #0x30000
0065BD27C  mov      w6, #0x30000
0065BD280  mov      w7, #0x50000
0065BD284  bl       #0x65bce54 ; HotFix.BattleLogic.PunchboardGameplayCustomTable$$BuildRule
0065BD288  ldr      x8, [sp, #0x38]
0065BD28C  ldur     q0, [sp, #0x28]
0065BD290  ldur     q1, [sp, #0x18]
0065BD294  ldur     q2, [sp, #8]
0065BD298  str      x8, [x19, #0x30]
0065BD29C  ldp      x30, x21, [sp, #0x40]
0065BD2A0  stp      q1, q0, [x19, #0x10]
0065BD2A4  str      q2, [x19]
0065BD2A8  ldp      x20, x19, [sp, #0x50]
0065BD2AC  add      sp, sp, #0x60
0065BD2B0  ret      
0065BD2B4  ldr      x1, [x0, #0x60]
0065BD2B8  mov      x8, x19
0065BD2BC  ldp      x20, x19, [sp, #0x50]
0065BD2C0  ldp      x30, x21, [sp, #0x40]
0065BD2C4  add      sp, sp, #0x60
0065BD2C8  br       x1

