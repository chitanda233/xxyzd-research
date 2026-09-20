; HotFix.BattleLogic.PunchboardGameplayCustomTable$$CreateDefaultRule
; RVA 0x65BCD7C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BCD7C  sub      sp, sp, #0x60
0065BCD80  stp      x30, x21, [sp, #0x40]
0065BCD84  stp      x20, x19, [sp, #0x50]
0065BCD88  adrp     x20, #0x9599000
0065BCD8C  adrp     x21, #0x8f0a000
0065BCD90  mov      x19, x8
0065BCD94  ldrb     w8, [x20, #0x491]
0065BCD98  ldr      x21, [x21, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.CreateDefaultRule() @ 0x929b930
0065BCD9C  tbnz     w8, #0, #0x65bcdc0
0065BCDA0  adrp     x0, #0x8f0a000
0065BCDA4  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.CreateDefaultRule() @ 0x929b930
0065BCDA8  bl       #0x382bd14 ; 
0065BCDAC  adrp     x0, #0x8f0a000
0065BCDB0  ldr      x0, [x0, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BCDB4  bl       #0x382bd14 ; 
0065BCDB8  mov      w8, #1
0065BCDBC  strb     w8, [x20, #0x491]
0065BCDC0  ldr      x0, [x21]
0065BCDC4  ldrb     w8, [x0, #0x53]
0065BCDC8  tbnz     w8, #5, #0x65bce3c
0065BCDCC  adrp     x8, #0x8f0a000
0065BCDD0  ldr      x8, [x8, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BCDD4  ldr      x0, [x8]
0065BCDD8  ldr      w8, [x0, #0xe0]
0065BCDDC  cbnz     w8, #0x65bcde4
0065BCDE0  bl       #0x382be8c ; 
0065BCDE4  mov      x4, #-0x10000
0065BCDE8  add      x8, sp, #8
0065BCDEC  mov      w0, #2
0065BCDF0  mov      w1, #2
0065BCDF4  mov      w2, #0x40000
0065BCDF8  mov      w3, #0x60000
0065BCDFC  movk     x4, #0xfffd, lsl #16
0065BCE00  mov      w5, #0x30000
0065BCE04  mov      w6, #0x30000
0065BCE08  mov      w7, #0x50000
0065BCE0C  bl       #0x65bce54 ; HotFix.BattleLogic.PunchboardGameplayCustomTable$$BuildRule
0065BCE10  ldr      x8, [sp, #0x38]
0065BCE14  ldur     q0, [sp, #0x28]
0065BCE18  ldur     q1, [sp, #0x18]
0065BCE1C  ldur     q2, [sp, #8]
0065BCE20  str      x8, [x19, #0x30]
0065BCE24  ldp      x30, x21, [sp, #0x40]
0065BCE28  stp      q1, q0, [x19, #0x10]
0065BCE2C  str      q2, [x19]
0065BCE30  ldp      x20, x19, [sp, #0x50]
0065BCE34  add      sp, sp, #0x60
0065BCE38  ret      
0065BCE3C  ldr      x1, [x0, #0x60]
0065BCE40  mov      x8, x19
0065BCE44  ldp      x20, x19, [sp, #0x50]
0065BCE48  ldp      x30, x21, [sp, #0x40]
0065BCE4C  add      sp, sp, #0x60
0065BCE50  br       x1

