; LocalModels.Bean.Skillss_SkillTypeWeight$$readImpl
; RVA 0x6B0340C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0340C  stp      x30, x21, [sp, #-0x20]!
006B03410  stp      x20, x19, [sp, #0x10]
006B03414  adrp     x20, #0x959f000
006B03418  adrp     x21, #0x8f3e000
006B0341C  ldrb     w8, [x20, #0x3de]
006B03420  ldr      x21, [x21, #0x400]
006B03424  mov      x19, x0
006B03428  tbnz     w8, #0, #0x6b03440
006B0342C  adrp     x0, #0x8f3e000
006B03430  ldr      x0, [x0, #0x400]
006B03434  bl       #0x382bd14 ; 
006B03438  mov      w8, #1
006B0343C  strb     w8, [x20, #0x3de]
006B03440  ldr      x1, [x21]
006B03444  ldrb     w8, [x1, #0x53]
006B03448  tbnz     w8, #5, #0x6b03498
006B0344C  mov      x0, x19
006B03450  mov      x1, xzr
006B03454  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B03458  adrp     x21, #0x959f000
006B0345C  ldrb     w8, [x21, #0x90f]
006B03460  mov      w20, w0
006B03464  cbnz     w8, #0x6b0347c
006B03468  adrp     x0, #0x8f3e000
006B0346C  ldr      x0, [x0, #0x3d8]
006B03470  bl       #0x382bd14 ; 
006B03474  mov      w8, #1
006B03478  strb     w8, [x21, #0x90f]
006B0347C  adrp     x8, #0x8f3e000
006B03480  ldr      x8, [x8, #0x3d8]
006B03484  ldr      x2, [x8]
006B03488  ldrb     w8, [x2, #0x53]
006B0348C  tbnz     w8, #5, #0x6b034ac
006B03490  str      w20, [x19, #0x20]
006B03494  b        #0x6b034bc ; 
006B03498  ldr      x2, [x1, #0x60]
006B0349C  mov      x0, x19
006B034A0  ldp      x20, x19, [sp, #0x10]
006B034A4  ldp      x30, x21, [sp], #0x20
006B034A8  br       x2
006B034AC  ldr      x8, [x2, #0x60]
006B034B0  mov      x0, x19
006B034B4  mov      w1, w20
006B034B8  blr      x8
006B034BC  mov      x0, x19
006B034C0  mov      x1, xzr
006B034C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B034C8  adrp     x21, #0x959f000
006B034CC  ldrb     w8, [x21, #0x910]
006B034D0  mov      w20, w0
006B034D4  cbnz     w8, #0x6b034ec
006B034D8  adrp     x0, #0x8f3e000
006B034DC  ldr      x0, [x0, #0x3e8]
006B034E0  bl       #0x382bd14 ; 
006B034E4  mov      w8, #1
006B034E8  strb     w8, [x21, #0x910]
006B034EC  adrp     x8, #0x8f3e000
006B034F0  ldr      x8, [x8, #0x3e8]
006B034F4  ldr      x2, [x8]
006B034F8  ldrb     w8, [x2, #0x53]
006B034FC  tbnz     w8, #5, #0x6b03508
006B03500  str      w20, [x19, #0x24]
006B03504  b        #0x6b03518 ; 
006B03508  ldr      x8, [x2, #0x60]
006B0350C  mov      x0, x19
006B03510  mov      w1, w20
006B03514  blr      x8
006B03518  mov      x0, x19
006B0351C  mov      x1, xzr
006B03520  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B03524  adrp     x21, #0x959f000
006B03528  ldrb     w8, [x21, #0x911]
006B0352C  mov      w20, w0
006B03530  cbnz     w8, #0x6b03548
006B03534  adrp     x0, #0x8f3e000
006B03538  ldr      x0, [x0, #0x3f8]
006B0353C  bl       #0x382bd14 ; 
006B03540  mov      w8, #1
006B03544  strb     w8, [x21, #0x911]
006B03548  adrp     x8, #0x8f3e000
006B0354C  ldr      x8, [x8, #0x3f8]
006B03550  ldr      x2, [x8]
006B03554  ldrb     w8, [x2, #0x53]
006B03558  tbnz     w8, #5, #0x6b03564
006B0355C  str      w20, [x19, #0x28]
006B03560  b        #0x6b03574 ; 
006B03564  ldr      x8, [x2, #0x60]
006B03568  mov      x0, x19
006B0356C  mov      w1, w20
006B03570  blr      x8
006B03574  ldp      x20, x19, [sp, #0x10]
006B03578  mov      w0, #1
006B0357C  ldp      x30, x21, [sp], #0x20
006B03580  ret      

