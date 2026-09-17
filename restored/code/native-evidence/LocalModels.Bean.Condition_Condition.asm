; LocalModels.Bean.Condition_Condition$$readImpl
; RVA 0x68D02A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D02A4  stp      x30, x21, [sp, #-0x20]!
0068D02A8  stp      x20, x19, [sp, #0x10]
0068D02AC  adrp     x20, #0x959c000
0068D02B0  adrp     x21, #0x8f28000
0068D02B4  ldrb     w8, [x20, #0x3a9]
0068D02B8  ldr      x21, [x21, #0x698]
0068D02BC  mov      x19, x0
0068D02C0  tbnz     w8, #0, #0x68d02d8
0068D02C4  adrp     x0, #0x8f28000
0068D02C8  ldr      x0, [x0, #0x698]
0068D02CC  bl       #0x382bd14 ; 
0068D02D0  mov      w8, #1
0068D02D4  strb     w8, [x20, #0x3a9]
0068D02D8  ldr      x1, [x21]
0068D02DC  ldrb     w8, [x1, #0x53]
0068D02E0  tbnz     w8, #5, #0x68d0330
0068D02E4  mov      x0, x19
0068D02E8  mov      x1, xzr
0068D02EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068D02F0  adrp     x21, #0x959c000
0068D02F4  ldrb     w8, [x21, #0x751]
0068D02F8  mov      w20, w0
0068D02FC  cbnz     w8, #0x68d0314
0068D0300  adrp     x0, #0x8f28000
0068D0304  ldr      x0, [x0, #0x670]
0068D0308  bl       #0x382bd14 ; 
0068D030C  mov      w8, #1
0068D0310  strb     w8, [x21, #0x751]
0068D0314  adrp     x8, #0x8f28000
0068D0318  ldr      x8, [x8, #0x670]
0068D031C  ldr      x2, [x8]
0068D0320  ldrb     w8, [x2, #0x53]
0068D0324  tbnz     w8, #5, #0x68d0344
0068D0328  str      w20, [x19, #0x20]
0068D032C  b        #0x68d0354 ; 
0068D0330  ldr      x2, [x1, #0x60]
0068D0334  mov      x0, x19
0068D0338  ldp      x20, x19, [sp, #0x10]
0068D033C  ldp      x30, x21, [sp], #0x20
0068D0340  br       x2
0068D0344  ldr      x8, [x2, #0x60]
0068D0348  mov      x0, x19
0068D034C  mov      w1, w20
0068D0350  blr      x8
0068D0354  mov      x0, x19
0068D0358  mov      x1, xzr
0068D035C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068D0360  adrp     x21, #0x959c000
0068D0364  ldrb     w8, [x21, #0x752]
0068D0368  mov      w20, w0
0068D036C  cbnz     w8, #0x68d0384
0068D0370  adrp     x0, #0x8f28000
0068D0374  ldr      x0, [x0, #0x680]
0068D0378  bl       #0x382bd14 ; 
0068D037C  mov      w8, #1
0068D0380  strb     w8, [x21, #0x752]
0068D0384  adrp     x8, #0x8f28000
0068D0388  ldr      x8, [x8, #0x680]
0068D038C  ldr      x2, [x8]
0068D0390  ldrb     w8, [x2, #0x53]
0068D0394  tbnz     w8, #5, #0x68d03a0
0068D0398  str      w20, [x19, #0x24]
0068D039C  b        #0x68d03b0 ; 
0068D03A0  ldr      x8, [x2, #0x60]
0068D03A4  mov      x0, x19
0068D03A8  mov      w1, w20
0068D03AC  blr      x8
0068D03B0  mov      x0, x19
0068D03B4  mov      x1, xzr
0068D03B8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068D03BC  adrp     x21, #0x959c000
0068D03C0  ldrb     w8, [x21, #0x753]
0068D03C4  mov      x20, x0
0068D03C8  cbnz     w8, #0x68d03e0
0068D03CC  adrp     x0, #0x8f28000
0068D03D0  ldr      x0, [x0, #0x690]
0068D03D4  bl       #0x382bd14 ; 
0068D03D8  mov      w8, #1
0068D03DC  strb     w8, [x21, #0x753]
0068D03E0  adrp     x8, #0x8f28000
0068D03E4  ldr      x8, [x8, #0x690]
0068D03E8  ldr      x2, [x8]
0068D03EC  ldrb     w8, [x2, #0x53]
0068D03F0  tbnz     w8, #5, #0x68d0408
0068D03F4  str      x20, [x19, #0x28]!
0068D03F8  mov      x0, x19
0068D03FC  mov      x1, x20
0068D0400  bl       #0x382bcb8 ; 
0068D0404  b        #0x68d0418 ; 
0068D0408  ldr      x8, [x2, #0x60]
0068D040C  mov      x0, x19
0068D0410  mov      x1, x20
0068D0414  blr      x8
0068D0418  ldp      x20, x19, [sp, #0x10]
0068D041C  mov      w0, #1
0068D0420  ldp      x30, x21, [sp], #0x20
0068D0424  ret      

