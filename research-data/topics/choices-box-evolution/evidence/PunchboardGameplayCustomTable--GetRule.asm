; HotFix.BattleLogic.PunchboardGameplayCustomTable$$GetRule
; RVA 0x65BCC58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BCC58  sub      sp, sp, #0x70
0065BCC5C  str      x30, [sp, #0x40]
0065BCC60  stp      x22, x21, [sp, #0x50]
0065BCC64  stp      x20, x19, [sp, #0x60]
0065BCC68  adrp     x21, #0x9599000
0065BCC6C  adrp     x22, #0x8f0a000
0065BCC70  mov      x19, x8
0065BCC74  ldrb     w8, [x21, #0x490]
0065BCC78  ldr      x22, [x22, #0xc0] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.GetRule() @ 0x929b948
0065BCC7C  mov      w20, w0
0065BCC80  tbnz     w8, #0, #0x65bccb0
0065BCC84  adrp     x0, #0x8f0a000
0065BCC88  ldr      x0, [x0, #0xc8] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>.TryGetValue() @ 0x920b410
0065BCC8C  bl       #0x382bd14 ; 
0065BCC90  adrp     x0, #0x8f0a000
0065BCC94  ldr      x0, [x0, #0xc0] ; GLOBAL Method$HotFix.BattleLogic.PunchboardGameplayCustomTable.GetRule() @ 0x929b948
0065BCC98  bl       #0x382bd14 ; 
0065BCC9C  adrp     x0, #0x8f0a000
0065BCCA0  ldr      x0, [x0, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BCCA4  bl       #0x382bd14 ; 
0065BCCA8  mov      w8, #1
0065BCCAC  strb     w8, [x21, #0x490]
0065BCCB0  ldr      x1, [x22]
0065BCCB4  ldrb     w8, [x1, #0x53]
0065BCCB8  tbnz     w8, #5, #0x65bcd58
0065BCCBC  str      xzr, [sp, #0x30]
0065BCCC0  adrp     x21, #0x8f0a000
0065BCCC4  ldr      x21, [x21, #0xd0] ; GLOBAL HotFix.BattleLogic.PunchboardGameplayCustomTable_TypeInfo @ 0x91ee708
0065BCCC8  movi     v0.2d, #0000000000000000
0065BCCCC  stp      q0, q0, [sp, #0x10]
0065BCCD0  str      q0, [sp]
0065BCCD4  ldr      x0, [x21]
0065BCCD8  ldr      w8, [x0, #0xe0]
0065BCCDC  cbnz     w8, #0x65bcce8
0065BCCE0  bl       #0x382be8c ; 
0065BCCE4  ldr      x0, [x21]
0065BCCE8  ldr      x8, [x0, #0xb8]
0065BCCEC  ldr      x0, [x8, #0x118]
0065BCCF0  cbz      x0, #0x65bcd78
0065BCCF4  adrp     x8, #0x8f0a000
0065BCCF8  ldr      x8, [x8, #0xc8] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>.TryGetValue() @ 0x920b410
0065BCCFC  mov      x2, sp
0065BCD00  mov      w1, w20
0065BCD04  mov      x22, sp
0065BCD08  ldr      x3, [x8]
0065BCD0C  bl       #0x5e651bc ; System.Collections.Generic.Dictionary<int, PunchboardGameplayRule>$$TryGetValue
0065BCD10  tbnz     w0, #0, #0x65bcd2c
0065BCD14  ldr      x0, [x21]
0065BCD18  ldr      w8, [x0, #0xe0]
0065BCD1C  cbnz     w8, #0x65bcd28
0065BCD20  bl       #0x382be8c ; 
0065BCD24  ldr      x0, [x21]
0065BCD28  ldr      x22, [x0, #0xb8]
0065BCD2C  ldr      x8, [x22, #0x30]
0065BCD30  ldp      q1, q0, [x22, #0x10]
0065BCD34  ldr      q2, [x22]
0065BCD38  ldp      x22, x21, [sp, #0x50]
0065BCD3C  str      x8, [x19, #0x30]
0065BCD40  stp      q1, q0, [x19, #0x10]
0065BCD44  str      q2, [x19]
0065BCD48  ldp      x20, x19, [sp, #0x60]
0065BCD4C  ldr      x30, [sp, #0x40]
0065BCD50  add      sp, sp, #0x70
0065BCD54  ret      
0065BCD58  ldr      x2, [x1, #0x60]
0065BCD5C  mov      x8, x19
0065BCD60  mov      w0, w20
0065BCD64  ldp      x20, x19, [sp, #0x60]
0065BCD68  ldp      x22, x21, [sp, #0x50]
0065BCD6C  ldr      x30, [sp, #0x40]
0065BCD70  add      sp, sp, #0x70
0065BCD74  br       x2
0065BCD78  bl       #0x382bfb8 ; 

