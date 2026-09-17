; LocalModels.Bean.Card_ScoreForTest$$readImpl
; RVA 0x6897334; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006897334  stp      x30, x21, [sp, #-0x20]!
006897338  stp      x20, x19, [sp, #0x10]
00689733C  adrp     x20, #0x959b000
006897340  adrp     x21, #0x8f25000
006897344  ldrb     w8, [x20, #0xdd6]
006897348  ldr      x21, [x21, #0xc40]
00689734C  mov      x19, x0
006897350  tbnz     w8, #0, #0x6897368
006897354  adrp     x0, #0x8f25000
006897358  ldr      x0, [x0, #0xc40]
00689735C  bl       #0x382bd14 ; 
006897360  mov      w8, #1
006897364  strb     w8, [x20, #0xdd6]
006897368  ldr      x1, [x21]
00689736C  ldrb     w8, [x1, #0x53]
006897370  tbnz     w8, #5, #0x68973c0
006897374  mov      x0, x19
006897378  mov      x1, xzr
00689737C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006897380  adrp     x21, #0x959c000
006897384  ldrb     w8, [x21, #0x4ae]
006897388  mov      w20, w0
00689738C  cbnz     w8, #0x68973a4
006897390  adrp     x0, #0x8f25000
006897394  ldr      x0, [x0, #0xc28]
006897398  bl       #0x382bd14 ; 
00689739C  mov      w8, #1
0068973A0  strb     w8, [x21, #0x4ae]
0068973A4  adrp     x8, #0x8f25000
0068973A8  ldr      x8, [x8, #0xc28]
0068973AC  ldr      x2, [x8]
0068973B0  ldrb     w8, [x2, #0x53]
0068973B4  tbnz     w8, #5, #0x68973d4
0068973B8  str      w20, [x19, #0x20]
0068973BC  b        #0x68973e4 ; 
0068973C0  ldr      x2, [x1, #0x60]
0068973C4  mov      x0, x19
0068973C8  ldp      x20, x19, [sp, #0x10]
0068973CC  ldp      x30, x21, [sp], #0x20
0068973D0  br       x2
0068973D4  ldr      x8, [x2, #0x60]
0068973D8  mov      x0, x19
0068973DC  mov      w1, w20
0068973E0  blr      x8
0068973E4  mov      x0, x19
0068973E8  mov      x1, xzr
0068973EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068973F0  adrp     x21, #0x959c000
0068973F4  ldrb     w8, [x21, #0x4af]
0068973F8  mov      w20, w0
0068973FC  cbnz     w8, #0x6897414
006897400  adrp     x0, #0x8f25000
006897404  ldr      x0, [x0, #0xc38]
006897408  bl       #0x382bd14 ; 
00689740C  mov      w8, #1
006897410  strb     w8, [x21, #0x4af]
006897414  adrp     x8, #0x8f25000
006897418  ldr      x8, [x8, #0xc38]
00689741C  ldr      x2, [x8]
006897420  ldrb     w8, [x2, #0x53]
006897424  tbnz     w8, #5, #0x6897430
006897428  str      w20, [x19, #0x24]
00689742C  b        #0x6897440 ; 
006897430  ldr      x8, [x2, #0x60]
006897434  mov      x0, x19
006897438  mov      w1, w20
00689743C  blr      x8
006897440  ldp      x20, x19, [sp, #0x10]
006897444  mov      w0, #1
006897448  ldp      x30, x21, [sp], #0x20
00689744C  ret      

