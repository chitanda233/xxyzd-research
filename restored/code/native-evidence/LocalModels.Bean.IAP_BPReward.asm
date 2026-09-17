; LocalModels.Bean.IAP_BPReward$$readImpl
; RVA 0x6AA039C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA039C  stp      x30, x21, [sp, #-0x20]!
006AA03A0  stp      x20, x19, [sp, #0x10]
006AA03A4  adrp     x20, #0x959e000
006AA03A8  adrp     x21, #0x8f39000
006AA03AC  ldrb     w8, [x20, #0x297]
006AA03B0  ldr      x21, [x21, #0xa40]
006AA03B4  mov      x19, x0
006AA03B8  tbnz     w8, #0, #0x6aa03d0
006AA03BC  adrp     x0, #0x8f39000
006AA03C0  ldr      x0, [x0, #0xa40]
006AA03C4  bl       #0x382bd14 ; 
006AA03C8  mov      w8, #1
006AA03CC  strb     w8, [x20, #0x297]
006AA03D0  ldr      x1, [x21]
006AA03D4  ldrb     w8, [x1, #0x53]
006AA03D8  tbnz     w8, #5, #0x6aa0428
006AA03DC  mov      x0, x19
006AA03E0  mov      x1, xzr
006AA03E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA03E8  adrp     x21, #0x959e000
006AA03EC  ldrb     w8, [x21, #0x657]
006AA03F0  mov      w20, w0
006AA03F4  cbnz     w8, #0x6aa040c
006AA03F8  adrp     x0, #0x8f39000
006AA03FC  ldr      x0, [x0, #0x9c8]
006AA0400  bl       #0x382bd14 ; 
006AA0404  mov      w8, #1
006AA0408  strb     w8, [x21, #0x657]
006AA040C  adrp     x8, #0x8f39000
006AA0410  ldr      x8, [x8, #0x9c8]
006AA0414  ldr      x2, [x8]
006AA0418  ldrb     w8, [x2, #0x53]
006AA041C  tbnz     w8, #5, #0x6aa043c
006AA0420  str      w20, [x19, #0x20]
006AA0424  b        #0x6aa044c ; 
006AA0428  ldr      x2, [x1, #0x60]
006AA042C  mov      x0, x19
006AA0430  ldp      x20, x19, [sp, #0x10]
006AA0434  ldp      x30, x21, [sp], #0x20
006AA0438  br       x2
006AA043C  ldr      x8, [x2, #0x60]
006AA0440  mov      x0, x19
006AA0444  mov      w1, w20
006AA0448  blr      x8
006AA044C  mov      x0, x19
006AA0450  mov      x1, xzr
006AA0454  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA0458  adrp     x21, #0x959e000
006AA045C  ldrb     w8, [x21, #0x658]
006AA0460  mov      w20, w0
006AA0464  cbnz     w8, #0x6aa047c
006AA0468  adrp     x0, #0x8f39000
006AA046C  ldr      x0, [x0, #0x9d8]
006AA0470  bl       #0x382bd14 ; 
006AA0474  mov      w8, #1
006AA0478  strb     w8, [x21, #0x658]
006AA047C  adrp     x8, #0x8f39000
006AA0480  ldr      x8, [x8, #0x9d8]
006AA0484  ldr      x2, [x8]
006AA0488  ldrb     w8, [x2, #0x53]
006AA048C  tbnz     w8, #5, #0x6aa0498
006AA0490  str      w20, [x19, #0x24]
006AA0494  b        #0x6aa04a8 ; 
006AA0498  ldr      x8, [x2, #0x60]
006AA049C  mov      x0, x19
006AA04A0  mov      w1, w20
006AA04A4  blr      x8
006AA04A8  mov      x0, x19
006AA04AC  mov      x1, xzr
006AA04B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA04B4  adrp     x21, #0x959e000
006AA04B8  ldrb     w8, [x21, #0x659]
006AA04BC  mov      w20, w0
006AA04C0  cbnz     w8, #0x6aa04d8
006AA04C4  adrp     x0, #0x8f39000
006AA04C8  ldr      x0, [x0, #0x9e8]
006AA04CC  bl       #0x382bd14 ; 
006AA04D0  mov      w8, #1
006AA04D4  strb     w8, [x21, #0x659]
006AA04D8  adrp     x8, #0x8f39000
006AA04DC  ldr      x8, [x8, #0x9e8]
006AA04E0  ldr      x2, [x8]
006AA04E4  ldrb     w8, [x2, #0x53]
006AA04E8  tbnz     w8, #5, #0x6aa04f4
006AA04EC  str      w20, [x19, #0x28]
006AA04F0  b        #0x6aa0504 ; 
006AA04F4  ldr      x8, [x2, #0x60]
006AA04F8  mov      x0, x19
006AA04FC  mov      w1, w20
006AA0500  blr      x8
006AA0504  mov      x0, x19
006AA0508  mov      x1, xzr
006AA050C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA0510  adrp     x21, #0x959e000
006AA0514  ldrb     w8, [x21, #0x65a]
006AA0518  mov      w20, w0
006AA051C  cbnz     w8, #0x6aa0534
006AA0520  adrp     x0, #0x8f39000
006AA0524  ldr      x0, [x0, #0x9f8]
006AA0528  bl       #0x382bd14 ; 
006AA052C  mov      w8, #1
006AA0530  strb     w8, [x21, #0x65a]
006AA0534  adrp     x8, #0x8f39000
006AA0538  ldr      x8, [x8, #0x9f8]
006AA053C  ldr      x2, [x8]
006AA0540  ldrb     w8, [x2, #0x53]
006AA0544  tbnz     w8, #5, #0x6aa0550
006AA0548  str      w20, [x19, #0x2c]
006AA054C  b        #0x6aa0560 ; 
006AA0550  ldr      x8, [x2, #0x60]
006AA0554  mov      x0, x19
006AA0558  mov      w1, w20
006AA055C  blr      x8
006AA0560  mov      x0, x19
006AA0564  mov      x1, xzr
006AA0568  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA056C  adrp     x21, #0x959e000
006AA0570  ldrb     w8, [x21, #0x65b]
006AA0574  mov      w20, w0
006AA0578  cbnz     w8, #0x6aa0590
006AA057C  adrp     x0, #0x8f39000
006AA0580  ldr      x0, [x0, #0xa08]
006AA0584  bl       #0x382bd14 ; 
006AA0588  mov      w8, #1
006AA058C  strb     w8, [x21, #0x65b]
006AA0590  adrp     x8, #0x8f39000
006AA0594  ldr      x8, [x8, #0xa08]
006AA0598  ldr      x2, [x8]
006AA059C  ldrb     w8, [x2, #0x53]
006AA05A0  tbnz     w8, #5, #0x6aa05ac
006AA05A4  str      w20, [x19, #0x30]
006AA05A8  b        #0x6aa05bc ; 
006AA05AC  ldr      x8, [x2, #0x60]
006AA05B0  mov      x0, x19
006AA05B4  mov      w1, w20
006AA05B8  blr      x8
006AA05BC  mov      x0, x19
006AA05C0  mov      x1, xzr
006AA05C4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AA05C8  adrp     x21, #0x959e000
006AA05CC  ldrb     w8, [x21, #0x65c]
006AA05D0  mov      x20, x0
006AA05D4  cbnz     w8, #0x6aa05ec
006AA05D8  adrp     x0, #0x8f39000
006AA05DC  ldr      x0, [x0, #0xa18]
006AA05E0  bl       #0x382bd14 ; 
006AA05E4  mov      w8, #1
006AA05E8  strb     w8, [x21, #0x65c]
006AA05EC  adrp     x8, #0x8f39000
006AA05F0  ldr      x8, [x8, #0xa18]
006AA05F4  ldr      x2, [x8]
006AA05F8  ldrb     w8, [x2, #0x53]
006AA05FC  tbnz     w8, #5, #0x6aa0614
006AA0600  mov      x0, x19
006AA0604  str      x20, [x0, #0x38]!
006AA0608  mov      x1, x20
006AA060C  bl       #0x382bcb8 ; 
006AA0610  b        #0x6aa0624 ; 
006AA0614  ldr      x8, [x2, #0x60]
006AA0618  mov      x0, x19
006AA061C  mov      x1, x20
006AA0620  blr      x8
006AA0624  mov      x0, x19
006AA0628  mov      x1, xzr
006AA062C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AA0630  adrp     x21, #0x959e000
006AA0634  ldrb     w8, [x21, #0x65d]
006AA0638  mov      x20, x0
006AA063C  cbnz     w8, #0x6aa0654
006AA0640  adrp     x0, #0x8f39000
006AA0644  ldr      x0, [x0, #0xa28]
006AA0648  bl       #0x382bd14 ; 
006AA064C  mov      w8, #1
006AA0650  strb     w8, [x21, #0x65d]
006AA0654  adrp     x8, #0x8f39000
006AA0658  ldr      x8, [x8, #0xa28]
006AA065C  ldr      x2, [x8]
006AA0660  ldrb     w8, [x2, #0x53]
006AA0664  tbnz     w8, #5, #0x6aa067c
006AA0668  mov      x0, x19
006AA066C  str      x20, [x0, #0x40]!
006AA0670  mov      x1, x20
006AA0674  bl       #0x382bcb8 ; 
006AA0678  b        #0x6aa068c ; 
006AA067C  ldr      x8, [x2, #0x60]
006AA0680  mov      x0, x19
006AA0684  mov      x1, x20
006AA0688  blr      x8
006AA068C  mov      x0, x19
006AA0690  mov      x1, xzr
006AA0694  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AA0698  adrp     x21, #0x959e000
006AA069C  ldrb     w8, [x21, #0x65e]
006AA06A0  mov      x20, x0
006AA06A4  cbnz     w8, #0x6aa06bc
006AA06A8  adrp     x0, #0x8f39000
006AA06AC  ldr      x0, [x0, #0xa38]
006AA06B0  bl       #0x382bd14 ; 
006AA06B4  mov      w8, #1
006AA06B8  strb     w8, [x21, #0x65e]
006AA06BC  adrp     x8, #0x8f39000
006AA06C0  ldr      x8, [x8, #0xa38]
006AA06C4  ldr      x2, [x8]
006AA06C8  ldrb     w8, [x2, #0x53]
006AA06CC  tbnz     w8, #5, #0x6aa06e4
006AA06D0  str      x20, [x19, #0x48]!
006AA06D4  mov      x0, x19
006AA06D8  mov      x1, x20
006AA06DC  bl       #0x382bcb8 ; 
006AA06E0  b        #0x6aa06f4 ; 
006AA06E4  ldr      x8, [x2, #0x60]
006AA06E8  mov      x0, x19
006AA06EC  mov      x1, x20
006AA06F0  blr      x8
006AA06F4  ldp      x20, x19, [sp, #0x10]
006AA06F8  mov      w0, #1
006AA06FC  ldp      x30, x21, [sp], #0x20
006AA0700  ret      

