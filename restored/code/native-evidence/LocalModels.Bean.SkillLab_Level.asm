; LocalModels.Bean.SkillLab_Level$$readImpl
; RVA 0x6B01294; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B01294  stp      x30, x21, [sp, #-0x20]!
006B01298  stp      x20, x19, [sp, #0x10]
006B0129C  adrp     x20, #0x959f000
006B012A0  adrp     x21, #0x8f3e000
006B012A4  ldrb     w8, [x20, #0x3a9]
006B012A8  ldr      x21, [x21, #0x280]
006B012AC  mov      x19, x0
006B012B0  tbnz     w8, #0, #0x6b012c8
006B012B4  adrp     x0, #0x8f3e000
006B012B8  ldr      x0, [x0, #0x280]
006B012BC  bl       #0x382bd14 ; 
006B012C0  mov      w8, #1
006B012C4  strb     w8, [x20, #0x3a9]
006B012C8  ldr      x1, [x21]
006B012CC  ldrb     w8, [x1, #0x53]
006B012D0  tbnz     w8, #5, #0x6b01320
006B012D4  mov      x0, x19
006B012D8  mov      x1, xzr
006B012DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B012E0  adrp     x21, #0x959f000
006B012E4  ldrb     w8, [x21, #0x8f6]
006B012E8  mov      w20, w0
006B012EC  cbnz     w8, #0x6b01304
006B012F0  adrp     x0, #0x8f3e000
006B012F4  ldr      x0, [x0, #0x208]
006B012F8  bl       #0x382bd14 ; 
006B012FC  mov      w8, #1
006B01300  strb     w8, [x21, #0x8f6]
006B01304  adrp     x8, #0x8f3e000
006B01308  ldr      x8, [x8, #0x208]
006B0130C  ldr      x2, [x8]
006B01310  ldrb     w8, [x2, #0x53]
006B01314  tbnz     w8, #5, #0x6b01334
006B01318  str      w20, [x19, #0x20]
006B0131C  b        #0x6b01344 ; 
006B01320  ldr      x2, [x1, #0x60]
006B01324  mov      x0, x19
006B01328  ldp      x20, x19, [sp, #0x10]
006B0132C  ldp      x30, x21, [sp], #0x20
006B01330  br       x2
006B01334  ldr      x8, [x2, #0x60]
006B01338  mov      x0, x19
006B0133C  mov      w1, w20
006B01340  blr      x8
006B01344  mov      x0, x19
006B01348  mov      x1, xzr
006B0134C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B01350  adrp     x21, #0x959f000
006B01354  ldrb     w8, [x21, #0x8f7]
006B01358  mov      w20, w0
006B0135C  cbnz     w8, #0x6b01374
006B01360  adrp     x0, #0x8f3e000
006B01364  ldr      x0, [x0, #0x218]
006B01368  bl       #0x382bd14 ; 
006B0136C  mov      w8, #1
006B01370  strb     w8, [x21, #0x8f7]
006B01374  adrp     x8, #0x8f3e000
006B01378  ldr      x8, [x8, #0x218]
006B0137C  ldr      x2, [x8]
006B01380  ldrb     w8, [x2, #0x53]
006B01384  tbnz     w8, #5, #0x6b01390
006B01388  str      w20, [x19, #0x24]
006B0138C  b        #0x6b013a0 ; 
006B01390  ldr      x8, [x2, #0x60]
006B01394  mov      x0, x19
006B01398  mov      w1, w20
006B0139C  blr      x8
006B013A0  mov      x0, x19
006B013A4  mov      x1, xzr
006B013A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B013AC  adrp     x21, #0x959f000
006B013B0  ldrb     w8, [x21, #0x8f8]
006B013B4  mov      w20, w0
006B013B8  cbnz     w8, #0x6b013d0
006B013BC  adrp     x0, #0x8f3e000
006B013C0  ldr      x0, [x0, #0x228]
006B013C4  bl       #0x382bd14 ; 
006B013C8  mov      w8, #1
006B013CC  strb     w8, [x21, #0x8f8]
006B013D0  adrp     x8, #0x8f3e000
006B013D4  ldr      x8, [x8, #0x228]
006B013D8  ldr      x2, [x8]
006B013DC  ldrb     w8, [x2, #0x53]
006B013E0  tbnz     w8, #5, #0x6b013ec
006B013E4  str      w20, [x19, #0x28]
006B013E8  b        #0x6b013fc ; 
006B013EC  ldr      x8, [x2, #0x60]
006B013F0  mov      x0, x19
006B013F4  mov      w1, w20
006B013F8  blr      x8
006B013FC  mov      x0, x19
006B01400  mov      x1, xzr
006B01404  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B01408  adrp     x21, #0x959f000
006B0140C  ldrb     w8, [x21, #0x8f9]
006B01410  mov      w20, w0
006B01414  cbnz     w8, #0x6b0142c
006B01418  adrp     x0, #0x8f3e000
006B0141C  ldr      x0, [x0, #0x238]
006B01420  bl       #0x382bd14 ; 
006B01424  mov      w8, #1
006B01428  strb     w8, [x21, #0x8f9]
006B0142C  adrp     x8, #0x8f3e000
006B01430  ldr      x8, [x8, #0x238]
006B01434  ldr      x2, [x8]
006B01438  ldrb     w8, [x2, #0x53]
006B0143C  tbnz     w8, #5, #0x6b01448
006B01440  str      w20, [x19, #0x2c]
006B01444  b        #0x6b01458 ; 
006B01448  ldr      x8, [x2, #0x60]
006B0144C  mov      x0, x19
006B01450  mov      w1, w20
006B01454  blr      x8
006B01458  mov      x0, x19
006B0145C  mov      x1, xzr
006B01460  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B01464  adrp     x21, #0x959f000
006B01468  ldrb     w8, [x21, #0x8fa]
006B0146C  mov      x20, x0
006B01470  cbnz     w8, #0x6b01488
006B01474  adrp     x0, #0x8f3e000
006B01478  ldr      x0, [x0, #0x248]
006B0147C  bl       #0x382bd14 ; 
006B01480  mov      w8, #1
006B01484  strb     w8, [x21, #0x8fa]
006B01488  adrp     x8, #0x8f3e000
006B0148C  ldr      x8, [x8, #0x248]
006B01490  ldr      x2, [x8]
006B01494  ldrb     w8, [x2, #0x53]
006B01498  tbnz     w8, #5, #0x6b014b0
006B0149C  mov      x0, x19
006B014A0  str      x20, [x0, #0x30]!
006B014A4  mov      x1, x20
006B014A8  bl       #0x382bcb8 ; 
006B014AC  b        #0x6b014c0 ; 
006B014B0  ldr      x8, [x2, #0x60]
006B014B4  mov      x0, x19
006B014B8  mov      x1, x20
006B014BC  blr      x8
006B014C0  mov      x0, x19
006B014C4  mov      x1, xzr
006B014C8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B014CC  adrp     x21, #0x959f000
006B014D0  ldrb     w8, [x21, #0x8fb]
006B014D4  mov      x20, x0
006B014D8  cbnz     w8, #0x6b014f0
006B014DC  adrp     x0, #0x8f3e000
006B014E0  ldr      x0, [x0, #0x250]
006B014E4  bl       #0x382bd14 ; 
006B014E8  mov      w8, #1
006B014EC  strb     w8, [x21, #0x8fb]
006B014F0  adrp     x8, #0x8f3e000
006B014F4  ldr      x8, [x8, #0x250]
006B014F8  ldr      x2, [x8]
006B014FC  ldrb     w8, [x2, #0x53]
006B01500  tbnz     w8, #5, #0x6b01518
006B01504  mov      x0, x19
006B01508  str      x20, [x0, #0x38]!
006B0150C  mov      x1, x20
006B01510  bl       #0x382bcb8 ; 
006B01514  b        #0x6b01528 ; 
006B01518  ldr      x8, [x2, #0x60]
006B0151C  mov      x0, x19
006B01520  mov      x1, x20
006B01524  blr      x8
006B01528  mov      x0, x19
006B0152C  mov      x1, xzr
006B01530  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B01534  adrp     x21, #0x959f000
006B01538  ldrb     w8, [x21, #0x8fc]
006B0153C  mov      w20, w0
006B01540  cbnz     w8, #0x6b01558
006B01544  adrp     x0, #0x8f3e000
006B01548  ldr      x0, [x0, #0x260]
006B0154C  bl       #0x382bd14 ; 
006B01550  mov      w8, #1
006B01554  strb     w8, [x21, #0x8fc]
006B01558  adrp     x8, #0x8f3e000
006B0155C  ldr      x8, [x8, #0x260]
006B01560  ldr      x2, [x8]
006B01564  ldrb     w8, [x2, #0x53]
006B01568  tbnz     w8, #5, #0x6b01574
006B0156C  str      w20, [x19, #0x40]
006B01570  b        #0x6b01584 ; 
006B01574  ldr      x8, [x2, #0x60]
006B01578  mov      x0, x19
006B0157C  mov      w1, w20
006B01580  blr      x8
006B01584  mov      x0, x19
006B01588  mov      x1, xzr
006B0158C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B01590  adrp     x21, #0x959f000
006B01594  ldrb     w8, [x21, #0x8fd]
006B01598  mov      x20, x0
006B0159C  cbnz     w8, #0x6b015b4
006B015A0  adrp     x0, #0x8f3e000
006B015A4  ldr      x0, [x0, #0x268]
006B015A8  bl       #0x382bd14 ; 
006B015AC  mov      w8, #1
006B015B0  strb     w8, [x21, #0x8fd]
006B015B4  adrp     x8, #0x8f3e000
006B015B8  ldr      x8, [x8, #0x268]
006B015BC  ldr      x2, [x8]
006B015C0  ldrb     w8, [x2, #0x53]
006B015C4  tbnz     w8, #5, #0x6b015dc
006B015C8  mov      x0, x19
006B015CC  str      x20, [x0, #0x48]!
006B015D0  mov      x1, x20
006B015D4  bl       #0x382bcb8 ; 
006B015D8  b        #0x6b015ec ; 
006B015DC  ldr      x8, [x2, #0x60]
006B015E0  mov      x0, x19
006B015E4  mov      x1, x20
006B015E8  blr      x8
006B015EC  mov      x0, x19
006B015F0  mov      x1, xzr
006B015F4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B015F8  adrp     x21, #0x959f000
006B015FC  ldrb     w8, [x21, #0x8fe]
006B01600  mov      x20, x0
006B01604  cbnz     w8, #0x6b0161c
006B01608  adrp     x0, #0x8f3e000
006B0160C  ldr      x0, [x0, #0x278]
006B01610  bl       #0x382bd14 ; 
006B01614  mov      w8, #1
006B01618  strb     w8, [x21, #0x8fe]
006B0161C  adrp     x8, #0x8f3e000
006B01620  ldr      x8, [x8, #0x278]
006B01624  ldr      x2, [x8]
006B01628  ldrb     w8, [x2, #0x53]
006B0162C  tbnz     w8, #5, #0x6b01644
006B01630  str      x20, [x19, #0x50]!
006B01634  mov      x0, x19
006B01638  mov      x1, x20
006B0163C  bl       #0x382bcb8 ; 
006B01640  b        #0x6b01654 ; 
006B01644  ldr      x8, [x2, #0x60]
006B01648  mov      x0, x19
006B0164C  mov      x1, x20
006B01650  blr      x8
006B01654  ldp      x20, x19, [sp, #0x10]
006B01658  mov      w0, #1
006B0165C  ldp      x30, x21, [sp], #0x20
006B01660  ret      

