; LocalModels.Bean.Drone_TalentNode$$readImpl
; RVA 0x6A61410; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A61410  stp      x30, x21, [sp, #-0x20]!
006A61414  stp      x20, x19, [sp, #0x10]
006A61418  adrp     x20, #0x959d000
006A6141C  adrp     x21, #0x8f36000
006A61420  ldrb     w8, [x20, #0xc0e]
006A61424  ldr      x21, [x21, #0xa50]
006A61428  mov      x19, x0
006A6142C  tbnz     w8, #0, #0x6a61444
006A61430  adrp     x0, #0x8f36000
006A61434  ldr      x0, [x0, #0xa50]
006A61438  bl       #0x382bd14 ; 
006A6143C  mov      w8, #1
006A61440  strb     w8, [x20, #0xc0e]
006A61444  ldr      x1, [x21]
006A61448  ldrb     w8, [x1, #0x53]
006A6144C  tbnz     w8, #5, #0x6a6149c
006A61450  mov      x0, x19
006A61454  mov      x1, xzr
006A61458  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6145C  adrp     x21, #0x959e000
006A61460  ldrb     w8, [x21, #0x3a4]
006A61464  mov      w20, w0
006A61468  cbnz     w8, #0x6a61480
006A6146C  adrp     x0, #0x8f36000
006A61470  ldr      x0, [x0, #0xa18]
006A61474  bl       #0x382bd14 ; 
006A61478  mov      w8, #1
006A6147C  strb     w8, [x21, #0x3a4]
006A61480  adrp     x8, #0x8f36000
006A61484  ldr      x8, [x8, #0xa18]
006A61488  ldr      x2, [x8]
006A6148C  ldrb     w8, [x2, #0x53]
006A61490  tbnz     w8, #5, #0x6a614b0
006A61494  str      w20, [x19, #0x20]
006A61498  b        #0x6a614c0 ; 
006A6149C  ldr      x2, [x1, #0x60]
006A614A0  mov      x0, x19
006A614A4  ldp      x20, x19, [sp, #0x10]
006A614A8  ldp      x30, x21, [sp], #0x20
006A614AC  br       x2
006A614B0  ldr      x8, [x2, #0x60]
006A614B4  mov      x0, x19
006A614B8  mov      w1, w20
006A614BC  blr      x8
006A614C0  mov      x0, x19
006A614C4  mov      x1, xzr
006A614C8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A614CC  adrp     x21, #0x959e000
006A614D0  ldrb     w8, [x21, #0x3a5]
006A614D4  mov      x20, x0
006A614D8  cbnz     w8, #0x6a614f0
006A614DC  adrp     x0, #0x8f36000
006A614E0  ldr      x0, [x0, #0xa20]
006A614E4  bl       #0x382bd14 ; 
006A614E8  mov      w8, #1
006A614EC  strb     w8, [x21, #0x3a5]
006A614F0  adrp     x8, #0x8f36000
006A614F4  ldr      x8, [x8, #0xa20]
006A614F8  ldr      x2, [x8]
006A614FC  ldrb     w8, [x2, #0x53]
006A61500  tbnz     w8, #5, #0x6a61518
006A61504  mov      x0, x19
006A61508  str      x20, [x0, #0x28]!
006A6150C  mov      x1, x20
006A61510  bl       #0x382bcb8 ; 
006A61514  b        #0x6a61528 ; 
006A61518  ldr      x8, [x2, #0x60]
006A6151C  mov      x0, x19
006A61520  mov      x1, x20
006A61524  blr      x8
006A61528  mov      x0, x19
006A6152C  mov      x1, xzr
006A61530  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A61534  adrp     x21, #0x959e000
006A61538  ldrb     w8, [x21, #0x3a6]
006A6153C  mov      x20, x0
006A61540  cbnz     w8, #0x6a61558
006A61544  adrp     x0, #0x8f36000
006A61548  ldr      x0, [x0, #0xa28]
006A6154C  bl       #0x382bd14 ; 
006A61550  mov      w8, #1
006A61554  strb     w8, [x21, #0x3a6]
006A61558  adrp     x8, #0x8f36000
006A6155C  ldr      x8, [x8, #0xa28]
006A61560  ldr      x2, [x8]
006A61564  ldrb     w8, [x2, #0x53]
006A61568  tbnz     w8, #5, #0x6a61580
006A6156C  mov      x0, x19
006A61570  str      x20, [x0, #0x30]!
006A61574  mov      x1, x20
006A61578  bl       #0x382bcb8 ; 
006A6157C  b        #0x6a61590 ; 
006A61580  ldr      x8, [x2, #0x60]
006A61584  mov      x0, x19
006A61588  mov      x1, x20
006A6158C  blr      x8
006A61590  mov      x0, x19
006A61594  mov      x1, xzr
006A61598  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6159C  adrp     x21, #0x959e000
006A615A0  ldrb     w8, [x21, #0x3a7]
006A615A4  mov      w20, w0
006A615A8  cbnz     w8, #0x6a615c0
006A615AC  adrp     x0, #0x8f36000
006A615B0  ldr      x0, [x0, #0xa38]
006A615B4  bl       #0x382bd14 ; 
006A615B8  mov      w8, #1
006A615BC  strb     w8, [x21, #0x3a7]
006A615C0  adrp     x8, #0x8f36000
006A615C4  ldr      x8, [x8, #0xa38]
006A615C8  ldr      x2, [x8]
006A615CC  ldrb     w8, [x2, #0x53]
006A615D0  tbnz     w8, #5, #0x6a615dc
006A615D4  str      w20, [x19, #0x38]
006A615D8  b        #0x6a615ec ; 
006A615DC  ldr      x8, [x2, #0x60]
006A615E0  mov      x0, x19
006A615E4  mov      w1, w20
006A615E8  blr      x8
006A615EC  mov      x0, x19
006A615F0  mov      x1, xzr
006A615F4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A615F8  adrp     x21, #0x959e000
006A615FC  ldrb     w8, [x21, #0x3a8]
006A61600  mov      x20, x0
006A61604  cbnz     w8, #0x6a6161c
006A61608  adrp     x0, #0x8f36000
006A6160C  ldr      x0, [x0, #0xa48]
006A61610  bl       #0x382bd14 ; 
006A61614  mov      w8, #1
006A61618  strb     w8, [x21, #0x3a8]
006A6161C  adrp     x8, #0x8f36000
006A61620  ldr      x8, [x8, #0xa48]
006A61624  ldr      x2, [x8]
006A61628  ldrb     w8, [x2, #0x53]
006A6162C  tbnz     w8, #5, #0x6a61644
006A61630  str      x20, [x19, #0x40]!
006A61634  mov      x0, x19
006A61638  mov      x1, x20
006A6163C  bl       #0x382bcb8 ; 
006A61640  b        #0x6a61654 ; 
006A61644  ldr      x8, [x2, #0x60]
006A61648  mov      x0, x19
006A6164C  mov      x1, x20
006A61650  blr      x8
006A61654  ldp      x20, x19, [sp, #0x10]
006A61658  mov      w0, #1
006A6165C  ldp      x30, x21, [sp], #0x20
006A61660  ret      

