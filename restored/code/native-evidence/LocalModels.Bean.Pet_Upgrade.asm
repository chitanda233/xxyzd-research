; LocalModels.Bean.Pet_Upgrade$$readImpl
; RVA 0x6AD0314; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD0314  stp      x30, x21, [sp, #-0x20]!
006AD0318  stp      x20, x19, [sp, #0x10]
006AD031C  adrp     x20, #0x959e000
006AD0320  adrp     x21, #0x8f3b000
006AD0324  ldrb     w8, [x20, #0xb0a]
006AD0328  ldr      x21, [x21, #0xdb0]
006AD032C  mov      x19, x0
006AD0330  tbnz     w8, #0, #0x6ad0348
006AD0334  adrp     x0, #0x8f3b000
006AD0338  ldr      x0, [x0, #0xdb0]
006AD033C  bl       #0x382bd14 ; 
006AD0340  mov      w8, #1
006AD0344  strb     w8, [x20, #0xb0a]
006AD0348  ldr      x1, [x21]
006AD034C  ldrb     w8, [x1, #0x53]
006AD0350  tbnz     w8, #5, #0x6ad03a0
006AD0354  mov      x0, x19
006AD0358  mov      x1, xzr
006AD035C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD0360  adrp     x21, #0x959f000
006AD0364  ldrb     w8, [x21, #0xe2]
006AD0368  mov      w20, w0
006AD036C  cbnz     w8, #0x6ad0384
006AD0370  adrp     x0, #0x8f3b000
006AD0374  ldr      x0, [x0, #0xd88]
006AD0378  bl       #0x382bd14 ; 
006AD037C  mov      w8, #1
006AD0380  strb     w8, [x21, #0xe2]
006AD0384  adrp     x8, #0x8f3b000
006AD0388  ldr      x8, [x8, #0xd88]
006AD038C  ldr      x2, [x8]
006AD0390  ldrb     w8, [x2, #0x53]
006AD0394  tbnz     w8, #5, #0x6ad03b4
006AD0398  str      w20, [x19, #0x20]
006AD039C  b        #0x6ad03c4 ; 
006AD03A0  ldr      x2, [x1, #0x60]
006AD03A4  mov      x0, x19
006AD03A8  ldp      x20, x19, [sp, #0x10]
006AD03AC  ldp      x30, x21, [sp], #0x20
006AD03B0  br       x2
006AD03B4  ldr      x8, [x2, #0x60]
006AD03B8  mov      x0, x19
006AD03BC  mov      w1, w20
006AD03C0  blr      x8
006AD03C4  mov      x0, x19
006AD03C8  mov      x1, xzr
006AD03CC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AD03D0  adrp     x21, #0x959f000
006AD03D4  ldrb     w8, [x21, #0xe3]
006AD03D8  mov      x20, x0
006AD03DC  cbnz     w8, #0x6ad03f4
006AD03E0  adrp     x0, #0x8f3b000
006AD03E4  ldr      x0, [x0, #0xd98]
006AD03E8  bl       #0x382bd14 ; 
006AD03EC  mov      w8, #1
006AD03F0  strb     w8, [x21, #0xe3]
006AD03F4  adrp     x8, #0x8f3b000
006AD03F8  ldr      x8, [x8, #0xd98]
006AD03FC  ldr      x2, [x8]
006AD0400  ldrb     w8, [x2, #0x53]
006AD0404  tbnz     w8, #5, #0x6ad041c
006AD0408  mov      x0, x19
006AD040C  str      x20, [x0, #0x28]!
006AD0410  mov      x1, x20
006AD0414  bl       #0x382bcb8 ; 
006AD0418  b        #0x6ad042c ; 
006AD041C  ldr      x8, [x2, #0x60]
006AD0420  mov      x0, x19
006AD0424  mov      x1, x20
006AD0428  blr      x8
006AD042C  mov      x0, x19
006AD0430  mov      x1, xzr
006AD0434  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AD0438  adrp     x21, #0x959f000
006AD043C  ldrb     w8, [x21, #0xe4]
006AD0440  mov      x20, x0
006AD0444  cbnz     w8, #0x6ad045c
006AD0448  adrp     x0, #0x8f3b000
006AD044C  ldr      x0, [x0, #0xda8]
006AD0450  bl       #0x382bd14 ; 
006AD0454  mov      w8, #1
006AD0458  strb     w8, [x21, #0xe4]
006AD045C  adrp     x8, #0x8f3b000
006AD0460  ldr      x8, [x8, #0xda8]
006AD0464  ldr      x2, [x8]
006AD0468  ldrb     w8, [x2, #0x53]
006AD046C  tbnz     w8, #5, #0x6ad0484
006AD0470  str      x20, [x19, #0x30]!
006AD0474  mov      x0, x19
006AD0478  mov      x1, x20
006AD047C  bl       #0x382bcb8 ; 
006AD0480  b        #0x6ad0494 ; 
006AD0484  ldr      x8, [x2, #0x60]
006AD0488  mov      x0, x19
006AD048C  mov      x1, x20
006AD0490  blr      x8
006AD0494  ldp      x20, x19, [sp, #0x10]
006AD0498  mov      w0, #1
006AD049C  ldp      x30, x21, [sp], #0x20
006AD04A0  ret      

