; LocalModels.Bean.ChapterWave_Waves$$readImpl
; RVA 0x68A0114; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068A0114  stp      x30, x21, [sp, #-0x20]!
0068A0118  stp      x20, x19, [sp, #0x10]
0068A011C  adrp     x20, #0x959b000
0068A0120  adrp     x21, #0x8f26000
0068A0124  ldrb     w8, [x20, #0xec6]
0068A0128  ldr      x21, [x21, #0x300]
0068A012C  mov      x19, x0
0068A0130  tbnz     w8, #0, #0x68a0148
0068A0134  adrp     x0, #0x8f26000
0068A0138  ldr      x0, [x0, #0x300]
0068A013C  bl       #0x382bd14 ; 
0068A0140  mov      w8, #1
0068A0144  strb     w8, [x20, #0xec6]
0068A0148  ldr      x1, [x21]
0068A014C  ldrb     w8, [x1, #0x53]
0068A0150  tbnz     w8, #5, #0x68a01a0
0068A0154  mov      x0, x19
0068A0158  mov      x1, xzr
0068A015C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A0160  adrp     x21, #0x959c000
0068A0164  ldrb     w8, [x21, #0x50c]
0068A0168  mov      w20, w0
0068A016C  cbnz     w8, #0x68a0184
0068A0170  adrp     x0, #0x8f26000
0068A0174  ldr      x0, [x0, #0x2a0]
0068A0178  bl       #0x382bd14 ; 
0068A017C  mov      w8, #1
0068A0180  strb     w8, [x21, #0x50c]
0068A0184  adrp     x8, #0x8f26000
0068A0188  ldr      x8, [x8, #0x2a0]
0068A018C  ldr      x2, [x8]
0068A0190  ldrb     w8, [x2, #0x53]
0068A0194  tbnz     w8, #5, #0x68a01b4
0068A0198  str      w20, [x19, #0x20]
0068A019C  b        #0x68a01c4 ; 
0068A01A0  ldr      x2, [x1, #0x60]
0068A01A4  mov      x0, x19
0068A01A8  ldp      x20, x19, [sp, #0x10]
0068A01AC  ldp      x30, x21, [sp], #0x20
0068A01B0  br       x2
0068A01B4  ldr      x8, [x2, #0x60]
0068A01B8  mov      x0, x19
0068A01BC  mov      w1, w20
0068A01C0  blr      x8
0068A01C4  mov      x0, x19
0068A01C8  mov      x1, xzr
0068A01CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A01D0  adrp     x21, #0x959c000
0068A01D4  ldrb     w8, [x21, #0x50d]
0068A01D8  mov      w20, w0
0068A01DC  cbnz     w8, #0x68a01f4
0068A01E0  adrp     x0, #0x8f26000
0068A01E4  ldr      x0, [x0, #0x2a8]
0068A01E8  bl       #0x382bd14 ; 
0068A01EC  mov      w8, #1
0068A01F0  strb     w8, [x21, #0x50d]
0068A01F4  adrp     x8, #0x8f26000
0068A01F8  ldr      x8, [x8, #0x2a8]
0068A01FC  ldr      x2, [x8]
0068A0200  ldrb     w8, [x2, #0x53]
0068A0204  tbnz     w8, #5, #0x68a0210
0068A0208  str      w20, [x19, #0x24]
0068A020C  b        #0x68a0220 ; 
0068A0210  ldr      x8, [x2, #0x60]
0068A0214  mov      x0, x19
0068A0218  mov      w1, w20
0068A021C  blr      x8
0068A0220  mov      x0, x19
0068A0224  mov      x1, xzr
0068A0228  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A022C  adrp     x21, #0x959c000
0068A0230  ldrb     w8, [x21, #0x50e]
0068A0234  mov      w20, w0
0068A0238  cbnz     w8, #0x68a0250
0068A023C  adrp     x0, #0x8f26000
0068A0240  ldr      x0, [x0, #0x2b0]
0068A0244  bl       #0x382bd14 ; 
0068A0248  mov      w8, #1
0068A024C  strb     w8, [x21, #0x50e]
0068A0250  adrp     x8, #0x8f26000
0068A0254  ldr      x8, [x8, #0x2b0]
0068A0258  ldr      x2, [x8]
0068A025C  ldrb     w8, [x2, #0x53]
0068A0260  tbnz     w8, #5, #0x68a026c
0068A0264  str      w20, [x19, #0x28]
0068A0268  b        #0x68a027c ; 
0068A026C  ldr      x8, [x2, #0x60]
0068A0270  mov      x0, x19
0068A0274  mov      w1, w20
0068A0278  blr      x8
0068A027C  mov      x0, x19
0068A0280  mov      x1, xzr
0068A0284  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A0288  adrp     x21, #0x959c000
0068A028C  ldrb     w8, [x21, #0x50f]
0068A0290  mov      x20, x0
0068A0294  cbnz     w8, #0x68a02ac
0068A0298  adrp     x0, #0x8f26000
0068A029C  ldr      x0, [x0, #0x2b8]
0068A02A0  bl       #0x382bd14 ; 
0068A02A4  mov      w8, #1
0068A02A8  strb     w8, [x21, #0x50f]
0068A02AC  adrp     x8, #0x8f26000
0068A02B0  ldr      x8, [x8, #0x2b8]
0068A02B4  ldr      x2, [x8]
0068A02B8  ldrb     w8, [x2, #0x53]
0068A02BC  tbnz     w8, #5, #0x68a02d4
0068A02C0  mov      x0, x19
0068A02C4  str      x20, [x0, #0x30]!
0068A02C8  mov      x1, x20
0068A02CC  bl       #0x382bcb8 ; 
0068A02D0  b        #0x68a02e4 ; 
0068A02D4  ldr      x8, [x2, #0x60]
0068A02D8  mov      x0, x19
0068A02DC  mov      x1, x20
0068A02E0  blr      x8
0068A02E4  mov      x0, x19
0068A02E8  mov      x1, xzr
0068A02EC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A02F0  adrp     x21, #0x959c000
0068A02F4  ldrb     w8, [x21, #0x510]
0068A02F8  mov      x20, x0
0068A02FC  cbnz     w8, #0x68a0314
0068A0300  adrp     x0, #0x8f26000
0068A0304  ldr      x0, [x0, #0x2c0]
0068A0308  bl       #0x382bd14 ; 
0068A030C  mov      w8, #1
0068A0310  strb     w8, [x21, #0x510]
0068A0314  adrp     x8, #0x8f26000
0068A0318  ldr      x8, [x8, #0x2c0]
0068A031C  ldr      x2, [x8]
0068A0320  ldrb     w8, [x2, #0x53]
0068A0324  tbnz     w8, #5, #0x68a033c
0068A0328  mov      x0, x19
0068A032C  str      x20, [x0, #0x38]!
0068A0330  mov      x1, x20
0068A0334  bl       #0x382bcb8 ; 
0068A0338  b        #0x68a034c ; 
0068A033C  ldr      x8, [x2, #0x60]
0068A0340  mov      x0, x19
0068A0344  mov      x1, x20
0068A0348  blr      x8
0068A034C  mov      x0, x19
0068A0350  mov      x1, xzr
0068A0354  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A0358  adrp     x21, #0x959c000
0068A035C  ldrb     w8, [x21, #0x511]
0068A0360  mov      x20, x0
0068A0364  cbnz     w8, #0x68a037c
0068A0368  adrp     x0, #0x8f26000
0068A036C  ldr      x0, [x0, #0x2c8]
0068A0370  bl       #0x382bd14 ; 
0068A0374  mov      w8, #1
0068A0378  strb     w8, [x21, #0x511]
0068A037C  adrp     x8, #0x8f26000
0068A0380  ldr      x8, [x8, #0x2c8]
0068A0384  ldr      x2, [x8]
0068A0388  ldrb     w8, [x2, #0x53]
0068A038C  tbnz     w8, #5, #0x68a0398
0068A0390  str      x20, [x19, #0x40]
0068A0394  b        #0x68a03a8 ; 
0068A0398  ldr      x8, [x2, #0x60]
0068A039C  mov      x0, x19
0068A03A0  mov      x1, x20
0068A03A4  blr      x8
0068A03A8  mov      x0, x19
0068A03AC  mov      x1, xzr
0068A03B0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A03B4  adrp     x21, #0x959c000
0068A03B8  ldrb     w8, [x21, #0x512]
0068A03BC  mov      x20, x0
0068A03C0  cbnz     w8, #0x68a03d8
0068A03C4  adrp     x0, #0x8f26000
0068A03C8  ldr      x0, [x0, #0x2d0]
0068A03CC  bl       #0x382bd14 ; 
0068A03D0  mov      w8, #1
0068A03D4  strb     w8, [x21, #0x512]
0068A03D8  adrp     x8, #0x8f26000
0068A03DC  ldr      x8, [x8, #0x2d0]
0068A03E0  ldr      x2, [x8]
0068A03E4  ldrb     w8, [x2, #0x53]
0068A03E8  tbnz     w8, #5, #0x68a03f4
0068A03EC  str      x20, [x19, #0x48]
0068A03F0  b        #0x68a0404 ; 
0068A03F4  ldr      x8, [x2, #0x60]
0068A03F8  mov      x0, x19
0068A03FC  mov      x1, x20
0068A0400  blr      x8
0068A0404  mov      x0, x19
0068A0408  mov      x1, xzr
0068A040C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A0410  adrp     x21, #0x959c000
0068A0414  ldrb     w8, [x21, #0x513]
0068A0418  mov      x20, x0
0068A041C  cbnz     w8, #0x68a0434
0068A0420  adrp     x0, #0x8f26000
0068A0424  ldr      x0, [x0, #0x2d8]
0068A0428  bl       #0x382bd14 ; 
0068A042C  mov      w8, #1
0068A0430  strb     w8, [x21, #0x513]
0068A0434  adrp     x8, #0x8f26000
0068A0438  ldr      x8, [x8, #0x2d8]
0068A043C  ldr      x2, [x8]
0068A0440  ldrb     w8, [x2, #0x53]
0068A0444  tbnz     w8, #5, #0x68a0450
0068A0448  str      x20, [x19, #0x50]
0068A044C  b        #0x68a0460 ; 
0068A0450  ldr      x8, [x2, #0x60]
0068A0454  mov      x0, x19
0068A0458  mov      x1, x20
0068A045C  blr      x8
0068A0460  mov      x0, x19
0068A0464  mov      x1, xzr
0068A0468  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A046C  adrp     x21, #0x959c000
0068A0470  ldrb     w8, [x21, #0x514]
0068A0474  mov      x20, x0
0068A0478  cbnz     w8, #0x68a0490
0068A047C  adrp     x0, #0x8f26000
0068A0480  ldr      x0, [x0, #0x2e0]
0068A0484  bl       #0x382bd14 ; 
0068A0488  mov      w8, #1
0068A048C  strb     w8, [x21, #0x514]
0068A0490  adrp     x8, #0x8f26000
0068A0494  ldr      x8, [x8, #0x2e0]
0068A0498  ldr      x2, [x8]
0068A049C  ldrb     w8, [x2, #0x53]
0068A04A0  tbnz     w8, #5, #0x68a04ac
0068A04A4  str      x20, [x19, #0x58]
0068A04A8  b        #0x68a04bc ; 
0068A04AC  ldr      x8, [x2, #0x60]
0068A04B0  mov      x0, x19
0068A04B4  mov      x1, x20
0068A04B8  blr      x8
0068A04BC  mov      x0, x19
0068A04C0  mov      x1, xzr
0068A04C4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A04C8  adrp     x21, #0x959c000
0068A04CC  ldrb     w8, [x21, #0x515]
0068A04D0  mov      x20, x0
0068A04D4  cbnz     w8, #0x68a04ec
0068A04D8  adrp     x0, #0x8f26000
0068A04DC  ldr      x0, [x0, #0x2e8]
0068A04E0  bl       #0x382bd14 ; 
0068A04E4  mov      w8, #1
0068A04E8  strb     w8, [x21, #0x515]
0068A04EC  adrp     x8, #0x8f26000
0068A04F0  ldr      x8, [x8, #0x2e8]
0068A04F4  ldr      x2, [x8]
0068A04F8  ldrb     w8, [x2, #0x53]
0068A04FC  tbnz     w8, #5, #0x68a0508
0068A0500  str      x20, [x19, #0x60]
0068A0504  b        #0x68a0518 ; 
0068A0508  ldr      x8, [x2, #0x60]
0068A050C  mov      x0, x19
0068A0510  mov      x1, x20
0068A0514  blr      x8
0068A0518  mov      x0, x19
0068A051C  mov      x1, xzr
0068A0520  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A0524  adrp     x21, #0x959c000
0068A0528  ldrb     w8, [x21, #0x516]
0068A052C  mov      w20, w0
0068A0530  cbnz     w8, #0x68a0548
0068A0534  adrp     x0, #0x8f26000
0068A0538  ldr      x0, [x0, #0x2f0]
0068A053C  bl       #0x382bd14 ; 
0068A0540  mov      w8, #1
0068A0544  strb     w8, [x21, #0x516]
0068A0548  adrp     x8, #0x8f26000
0068A054C  ldr      x8, [x8, #0x2f0]
0068A0550  ldr      x2, [x8]
0068A0554  ldrb     w8, [x2, #0x53]
0068A0558  tbnz     w8, #5, #0x68a0564
0068A055C  str      w20, [x19, #0x68]
0068A0560  b        #0x68a0574 ; 
0068A0564  ldr      x8, [x2, #0x60]
0068A0568  mov      x0, x19
0068A056C  mov      w1, w20
0068A0570  blr      x8
0068A0574  mov      x0, x19
0068A0578  mov      x1, xzr
0068A057C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A0580  adrp     x21, #0x959c000
0068A0584  ldrb     w8, [x21, #0x517]
0068A0588  mov      w20, w0
0068A058C  cbnz     w8, #0x68a05a4
0068A0590  adrp     x0, #0x8f26000
0068A0594  ldr      x0, [x0, #0x2f8]
0068A0598  bl       #0x382bd14 ; 
0068A059C  mov      w8, #1
0068A05A0  strb     w8, [x21, #0x517]
0068A05A4  adrp     x8, #0x8f26000
0068A05A8  ldr      x8, [x8, #0x2f8]
0068A05AC  ldr      x2, [x8]
0068A05B0  ldrb     w8, [x2, #0x53]
0068A05B4  tbnz     w8, #5, #0x68a05c0
0068A05B8  str      w20, [x19, #0x6c]
0068A05BC  b        #0x68a05d0 ; 
0068A05C0  ldr      x8, [x2, #0x60]
0068A05C4  mov      x0, x19
0068A05C8  mov      w1, w20
0068A05CC  blr      x8
0068A05D0  ldp      x20, x19, [sp, #0x10]
0068A05D4  mov      w0, #1
0068A05D8  ldp      x30, x21, [sp], #0x20
0068A05DC  ret      

