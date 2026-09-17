; LocalModels.Bean.UltimateCore_Skin$$readImpl
; RVA 0x6B1B1E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B1B1E8  stp      x30, x21, [sp, #-0x20]!
006B1B1EC  stp      x20, x19, [sp, #0x10]
006B1B1F0  adrp     x20, #0x959f000
006B1B1F4  adrp     x21, #0x8f3f000
006B1B1F8  ldrb     w8, [x20, #0x658]
006B1B1FC  ldr      x21, [x21, #0x480]
006B1B200  mov      x19, x0
006B1B204  tbnz     w8, #0, #0x6b1b21c
006B1B208  adrp     x0, #0x8f3f000
006B1B20C  ldr      x0, [x0, #0x480]
006B1B210  bl       #0x382bd14 ; 
006B1B214  mov      w8, #1
006B1B218  strb     w8, [x20, #0x658]
006B1B21C  ldr      x1, [x21]
006B1B220  ldrb     w8, [x1, #0x53]
006B1B224  tbnz     w8, #5, #0x6b1b274
006B1B228  mov      x0, x19
006B1B22C  mov      x1, xzr
006B1B230  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1B234  adrp     x21, #0x959f000
006B1B238  ldrb     w8, [x21, #0xa16]
006B1B23C  mov      w20, w0
006B1B240  cbnz     w8, #0x6b1b258
006B1B244  adrp     x0, #0x8f3f000
006B1B248  ldr      x0, [x0, #0x3d8]
006B1B24C  bl       #0x382bd14 ; 
006B1B250  mov      w8, #1
006B1B254  strb     w8, [x21, #0xa16]
006B1B258  adrp     x8, #0x8f3f000
006B1B25C  ldr      x8, [x8, #0x3d8]
006B1B260  ldr      x2, [x8]
006B1B264  ldrb     w8, [x2, #0x53]
006B1B268  tbnz     w8, #5, #0x6b1b288
006B1B26C  str      w20, [x19, #0x20]
006B1B270  b        #0x6b1b298 ; 
006B1B274  ldr      x2, [x1, #0x60]
006B1B278  mov      x0, x19
006B1B27C  ldp      x20, x19, [sp, #0x10]
006B1B280  ldp      x30, x21, [sp], #0x20
006B1B284  br       x2
006B1B288  ldr      x8, [x2, #0x60]
006B1B28C  mov      x0, x19
006B1B290  mov      w1, w20
006B1B294  blr      x8
006B1B298  mov      x0, x19
006B1B29C  mov      x1, xzr
006B1B2A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1B2A4  adrp     x21, #0x959f000
006B1B2A8  ldrb     w8, [x21, #0xa17]
006B1B2AC  mov      w20, w0
006B1B2B0  cbnz     w8, #0x6b1b2c8
006B1B2B4  adrp     x0, #0x8f3f000
006B1B2B8  ldr      x0, [x0, #0x3e8]
006B1B2BC  bl       #0x382bd14 ; 
006B1B2C0  mov      w8, #1
006B1B2C4  strb     w8, [x21, #0xa17]
006B1B2C8  adrp     x8, #0x8f3f000
006B1B2CC  ldr      x8, [x8, #0x3e8]
006B1B2D0  ldr      x2, [x8]
006B1B2D4  ldrb     w8, [x2, #0x53]
006B1B2D8  tbnz     w8, #5, #0x6b1b2e4
006B1B2DC  str      w20, [x19, #0x24]
006B1B2E0  b        #0x6b1b2f4 ; 
006B1B2E4  ldr      x8, [x2, #0x60]
006B1B2E8  mov      x0, x19
006B1B2EC  mov      w1, w20
006B1B2F0  blr      x8
006B1B2F4  mov      x0, x19
006B1B2F8  mov      x1, xzr
006B1B2FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1B300  adrp     x21, #0x959f000
006B1B304  ldrb     w8, [x21, #0xa18]
006B1B308  mov      w20, w0
006B1B30C  cbnz     w8, #0x6b1b324
006B1B310  adrp     x0, #0x8f3f000
006B1B314  ldr      x0, [x0, #0x3f8]
006B1B318  bl       #0x382bd14 ; 
006B1B31C  mov      w8, #1
006B1B320  strb     w8, [x21, #0xa18]
006B1B324  adrp     x8, #0x8f3f000
006B1B328  ldr      x8, [x8, #0x3f8]
006B1B32C  ldr      x2, [x8]
006B1B330  ldrb     w8, [x2, #0x53]
006B1B334  tbnz     w8, #5, #0x6b1b340
006B1B338  str      w20, [x19, #0x28]
006B1B33C  b        #0x6b1b350 ; 
006B1B340  ldr      x8, [x2, #0x60]
006B1B344  mov      x0, x19
006B1B348  mov      w1, w20
006B1B34C  blr      x8
006B1B350  mov      x0, x19
006B1B354  mov      x1, xzr
006B1B358  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1B35C  adrp     x21, #0x959f000
006B1B360  ldrb     w8, [x21, #0xa19]
006B1B364  mov      w20, w0
006B1B368  cbnz     w8, #0x6b1b380
006B1B36C  adrp     x0, #0x8f3f000
006B1B370  ldr      x0, [x0, #0x408]
006B1B374  bl       #0x382bd14 ; 
006B1B378  mov      w8, #1
006B1B37C  strb     w8, [x21, #0xa19]
006B1B380  adrp     x8, #0x8f3f000
006B1B384  ldr      x8, [x8, #0x408]
006B1B388  ldr      x2, [x8]
006B1B38C  ldrb     w8, [x2, #0x53]
006B1B390  tbnz     w8, #5, #0x6b1b39c
006B1B394  str      w20, [x19, #0x2c]
006B1B398  b        #0x6b1b3ac ; 
006B1B39C  ldr      x8, [x2, #0x60]
006B1B3A0  mov      x0, x19
006B1B3A4  mov      w1, w20
006B1B3A8  blr      x8
006B1B3AC  mov      x0, x19
006B1B3B0  mov      x1, xzr
006B1B3B4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B1B3B8  adrp     x21, #0x959f000
006B1B3BC  ldrb     w8, [x21, #0xa1a]
006B1B3C0  mov      x20, x0
006B1B3C4  cbnz     w8, #0x6b1b3dc
006B1B3C8  adrp     x0, #0x8f3f000
006B1B3CC  ldr      x0, [x0, #0x418]
006B1B3D0  bl       #0x382bd14 ; 
006B1B3D4  mov      w8, #1
006B1B3D8  strb     w8, [x21, #0xa1a]
006B1B3DC  adrp     x8, #0x8f3f000
006B1B3E0  ldr      x8, [x8, #0x418]
006B1B3E4  ldr      x2, [x8]
006B1B3E8  ldrb     w8, [x2, #0x53]
006B1B3EC  tbnz     w8, #5, #0x6b1b404
006B1B3F0  mov      x0, x19
006B1B3F4  str      x20, [x0, #0x30]!
006B1B3F8  mov      x1, x20
006B1B3FC  bl       #0x382bcb8 ; 
006B1B400  b        #0x6b1b414 ; 
006B1B404  ldr      x8, [x2, #0x60]
006B1B408  mov      x0, x19
006B1B40C  mov      x1, x20
006B1B410  blr      x8
006B1B414  mov      x0, x19
006B1B418  mov      x1, xzr
006B1B41C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1B420  adrp     x21, #0x959f000
006B1B424  ldrb     w8, [x21, #0xa1b]
006B1B428  mov      w20, w0
006B1B42C  cbnz     w8, #0x6b1b444
006B1B430  adrp     x0, #0x8f3f000
006B1B434  ldr      x0, [x0, #0x428]
006B1B438  bl       #0x382bd14 ; 
006B1B43C  mov      w8, #1
006B1B440  strb     w8, [x21, #0xa1b]
006B1B444  adrp     x8, #0x8f3f000
006B1B448  ldr      x8, [x8, #0x428]
006B1B44C  ldr      x2, [x8]
006B1B450  ldrb     w8, [x2, #0x53]
006B1B454  tbnz     w8, #5, #0x6b1b460
006B1B458  str      w20, [x19, #0x38]
006B1B45C  b        #0x6b1b470 ; 
006B1B460  ldr      x8, [x2, #0x60]
006B1B464  mov      x0, x19
006B1B468  mov      w1, w20
006B1B46C  blr      x8
006B1B470  mov      x0, x19
006B1B474  mov      x1, xzr
006B1B478  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1B47C  adrp     x21, #0x959f000
006B1B480  ldrb     w8, [x21, #0xa1c]
006B1B484  mov      x20, x0
006B1B488  cbnz     w8, #0x6b1b4a0
006B1B48C  adrp     x0, #0x8f3f000
006B1B490  ldr      x0, [x0, #0x438]
006B1B494  bl       #0x382bd14 ; 
006B1B498  mov      w8, #1
006B1B49C  strb     w8, [x21, #0xa1c]
006B1B4A0  adrp     x8, #0x8f3f000
006B1B4A4  ldr      x8, [x8, #0x438]
006B1B4A8  ldr      x2, [x8]
006B1B4AC  ldrb     w8, [x2, #0x53]
006B1B4B0  tbnz     w8, #5, #0x6b1b4c8
006B1B4B4  mov      x0, x19
006B1B4B8  str      x20, [x0, #0x40]!
006B1B4BC  mov      x1, x20
006B1B4C0  bl       #0x382bcb8 ; 
006B1B4C4  b        #0x6b1b4d8 ; 
006B1B4C8  ldr      x8, [x2, #0x60]
006B1B4CC  mov      x0, x19
006B1B4D0  mov      x1, x20
006B1B4D4  blr      x8
006B1B4D8  mov      x0, x19
006B1B4DC  mov      x1, xzr
006B1B4E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1B4E4  adrp     x21, #0x959f000
006B1B4E8  ldrb     w8, [x21, #0xa1d]
006B1B4EC  mov      w20, w0
006B1B4F0  cbnz     w8, #0x6b1b508
006B1B4F4  adrp     x0, #0x8f3f000
006B1B4F8  ldr      x0, [x0, #0x448]
006B1B4FC  bl       #0x382bd14 ; 
006B1B500  mov      w8, #1
006B1B504  strb     w8, [x21, #0xa1d]
006B1B508  adrp     x8, #0x8f3f000
006B1B50C  ldr      x8, [x8, #0x448]
006B1B510  ldr      x2, [x8]
006B1B514  ldrb     w8, [x2, #0x53]
006B1B518  tbnz     w8, #5, #0x6b1b524
006B1B51C  str      w20, [x19, #0x48]
006B1B520  b        #0x6b1b534 ; 
006B1B524  ldr      x8, [x2, #0x60]
006B1B528  mov      x0, x19
006B1B52C  mov      w1, w20
006B1B530  blr      x8
006B1B534  mov      x0, x19
006B1B538  mov      x1, xzr
006B1B53C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B1B540  adrp     x21, #0x959f000
006B1B544  ldrb     w8, [x21, #0xa1e]
006B1B548  mov      x20, x0
006B1B54C  cbnz     w8, #0x6b1b564
006B1B550  adrp     x0, #0x8f3f000
006B1B554  ldr      x0, [x0, #0x458]
006B1B558  bl       #0x382bd14 ; 
006B1B55C  mov      w8, #1
006B1B560  strb     w8, [x21, #0xa1e]
006B1B564  adrp     x8, #0x8f3f000
006B1B568  ldr      x8, [x8, #0x458]
006B1B56C  ldr      x2, [x8]
006B1B570  ldrb     w8, [x2, #0x53]
006B1B574  tbnz     w8, #5, #0x6b1b58c
006B1B578  mov      x0, x19
006B1B57C  str      x20, [x0, #0x50]!
006B1B580  mov      x1, x20
006B1B584  bl       #0x382bcb8 ; 
006B1B588  b        #0x6b1b59c ; 
006B1B58C  ldr      x8, [x2, #0x60]
006B1B590  mov      x0, x19
006B1B594  mov      x1, x20
006B1B598  blr      x8
006B1B59C  mov      x0, x19
006B1B5A0  mov      x1, xzr
006B1B5A4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1B5A8  adrp     x21, #0x959f000
006B1B5AC  ldrb     w8, [x21, #0xa1f]
006B1B5B0  mov      w20, w0
006B1B5B4  cbnz     w8, #0x6b1b5cc
006B1B5B8  adrp     x0, #0x8f3f000
006B1B5BC  ldr      x0, [x0, #0x468]
006B1B5C0  bl       #0x382bd14 ; 
006B1B5C4  mov      w8, #1
006B1B5C8  strb     w8, [x21, #0xa1f]
006B1B5CC  adrp     x8, #0x8f3f000
006B1B5D0  ldr      x8, [x8, #0x468]
006B1B5D4  ldr      x2, [x8]
006B1B5D8  ldrb     w8, [x2, #0x53]
006B1B5DC  tbnz     w8, #5, #0x6b1b5e8
006B1B5E0  str      w20, [x19, #0x58]
006B1B5E4  b        #0x6b1b5f8 ; 
006B1B5E8  ldr      x8, [x2, #0x60]
006B1B5EC  mov      x0, x19
006B1B5F0  mov      w1, w20
006B1B5F4  blr      x8
006B1B5F8  mov      x0, x19
006B1B5FC  mov      x1, xzr
006B1B600  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1B604  adrp     x21, #0x959f000
006B1B608  ldrb     w8, [x21, #0xa20]
006B1B60C  mov      w20, w0
006B1B610  cbnz     w8, #0x6b1b628
006B1B614  adrp     x0, #0x8f3f000
006B1B618  ldr      x0, [x0, #0x478]
006B1B61C  bl       #0x382bd14 ; 
006B1B620  mov      w8, #1
006B1B624  strb     w8, [x21, #0xa20]
006B1B628  adrp     x8, #0x8f3f000
006B1B62C  ldr      x8, [x8, #0x478]
006B1B630  ldr      x2, [x8]
006B1B634  ldrb     w8, [x2, #0x53]
006B1B638  tbnz     w8, #5, #0x6b1b644
006B1B63C  str      w20, [x19, #0x5c]
006B1B640  b        #0x6b1b654 ; 
006B1B644  ldr      x8, [x2, #0x60]
006B1B648  mov      x0, x19
006B1B64C  mov      w1, w20
006B1B650  blr      x8
006B1B654  ldp      x20, x19, [sp, #0x10]
006B1B658  mov      w0, #1
006B1B65C  ldp      x30, x21, [sp], #0x20
006B1B660  ret      

