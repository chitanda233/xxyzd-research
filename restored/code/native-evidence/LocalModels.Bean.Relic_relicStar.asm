; LocalModels.Bean.Relic_relicStar$$readImpl
; RVA 0x6ADA29C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ADA29C  stp      x30, x21, [sp, #-0x20]!
006ADA2A0  stp      x20, x19, [sp, #0x10]
006ADA2A4  adrp     x20, #0x959e000
006ADA2A8  adrp     x21, #0x8f3c000
006ADA2AC  ldrb     w8, [x20, #0xc16]
006ADA2B0  ldr      x21, [x21, #0x578]
006ADA2B4  mov      x19, x0
006ADA2B8  tbnz     w8, #0, #0x6ada2d0
006ADA2BC  adrp     x0, #0x8f3c000
006ADA2C0  ldr      x0, [x0, #0x578]
006ADA2C4  bl       #0x382bd14 ; 
006ADA2C8  mov      w8, #1
006ADA2CC  strb     w8, [x20, #0xc16]
006ADA2D0  ldr      x1, [x21]
006ADA2D4  ldrb     w8, [x1, #0x53]
006ADA2D8  tbnz     w8, #5, #0x6ada328
006ADA2DC  mov      x0, x19
006ADA2E0  mov      x1, xzr
006ADA2E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADA2E8  adrp     x21, #0x959f000
006ADA2EC  ldrb     w8, [x21, #0x14a]
006ADA2F0  mov      w20, w0
006ADA2F4  cbnz     w8, #0x6ada30c
006ADA2F8  adrp     x0, #0x8f3c000
006ADA2FC  ldr      x0, [x0, #0x520]
006ADA300  bl       #0x382bd14 ; 
006ADA304  mov      w8, #1
006ADA308  strb     w8, [x21, #0x14a]
006ADA30C  adrp     x8, #0x8f3c000
006ADA310  ldr      x8, [x8, #0x520]
006ADA314  ldr      x2, [x8]
006ADA318  ldrb     w8, [x2, #0x53]
006ADA31C  tbnz     w8, #5, #0x6ada33c
006ADA320  str      w20, [x19, #0x20]
006ADA324  b        #0x6ada34c ; 
006ADA328  ldr      x2, [x1, #0x60]
006ADA32C  mov      x0, x19
006ADA330  ldp      x20, x19, [sp, #0x10]
006ADA334  ldp      x30, x21, [sp], #0x20
006ADA338  br       x2
006ADA33C  ldr      x8, [x2, #0x60]
006ADA340  mov      x0, x19
006ADA344  mov      w1, w20
006ADA348  blr      x8
006ADA34C  mov      x0, x19
006ADA350  mov      x1, xzr
006ADA354  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADA358  adrp     x21, #0x959f000
006ADA35C  ldrb     w8, [x21, #0x14b]
006ADA360  mov      w20, w0
006ADA364  cbnz     w8, #0x6ada37c
006ADA368  adrp     x0, #0x8f3c000
006ADA36C  ldr      x0, [x0, #0x530]
006ADA370  bl       #0x382bd14 ; 
006ADA374  mov      w8, #1
006ADA378  strb     w8, [x21, #0x14b]
006ADA37C  adrp     x8, #0x8f3c000
006ADA380  ldr      x8, [x8, #0x530]
006ADA384  ldr      x2, [x8]
006ADA388  ldrb     w8, [x2, #0x53]
006ADA38C  tbnz     w8, #5, #0x6ada398
006ADA390  str      w20, [x19, #0x24]
006ADA394  b        #0x6ada3a8 ; 
006ADA398  ldr      x8, [x2, #0x60]
006ADA39C  mov      x0, x19
006ADA3A0  mov      w1, w20
006ADA3A4  blr      x8
006ADA3A8  mov      x0, x19
006ADA3AC  mov      x1, xzr
006ADA3B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADA3B4  adrp     x21, #0x959f000
006ADA3B8  ldrb     w8, [x21, #0x14c]
006ADA3BC  mov      w20, w0
006ADA3C0  cbnz     w8, #0x6ada3d8
006ADA3C4  adrp     x0, #0x8f3c000
006ADA3C8  ldr      x0, [x0, #0x540]
006ADA3CC  bl       #0x382bd14 ; 
006ADA3D0  mov      w8, #1
006ADA3D4  strb     w8, [x21, #0x14c]
006ADA3D8  adrp     x8, #0x8f3c000
006ADA3DC  ldr      x8, [x8, #0x540]
006ADA3E0  ldr      x2, [x8]
006ADA3E4  ldrb     w8, [x2, #0x53]
006ADA3E8  tbnz     w8, #5, #0x6ada3f4
006ADA3EC  str      w20, [x19, #0x28]
006ADA3F0  b        #0x6ada404 ; 
006ADA3F4  ldr      x8, [x2, #0x60]
006ADA3F8  mov      x0, x19
006ADA3FC  mov      w1, w20
006ADA400  blr      x8
006ADA404  mov      x0, x19
006ADA408  mov      x1, xzr
006ADA40C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006ADA410  adrp     x21, #0x959f000
006ADA414  ldrb     w8, [x21, #0x14d]
006ADA418  mov      x20, x0
006ADA41C  cbnz     w8, #0x6ada434
006ADA420  adrp     x0, #0x8f3c000
006ADA424  ldr      x0, [x0, #0x550]
006ADA428  bl       #0x382bd14 ; 
006ADA42C  mov      w8, #1
006ADA430  strb     w8, [x21, #0x14d]
006ADA434  adrp     x8, #0x8f3c000
006ADA438  ldr      x8, [x8, #0x550]
006ADA43C  ldr      x2, [x8]
006ADA440  ldrb     w8, [x2, #0x53]
006ADA444  tbnz     w8, #5, #0x6ada45c
006ADA448  mov      x0, x19
006ADA44C  str      x20, [x0, #0x30]!
006ADA450  mov      x1, x20
006ADA454  bl       #0x382bcb8 ; 
006ADA458  b        #0x6ada46c ; 
006ADA45C  ldr      x8, [x2, #0x60]
006ADA460  mov      x0, x19
006ADA464  mov      x1, x20
006ADA468  blr      x8
006ADA46C  mov      x0, x19
006ADA470  mov      x1, xzr
006ADA474  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADA478  adrp     x21, #0x959f000
006ADA47C  ldrb     w8, [x21, #0x14e]
006ADA480  mov      x20, x0
006ADA484  cbnz     w8, #0x6ada49c
006ADA488  adrp     x0, #0x8f3c000
006ADA48C  ldr      x0, [x0, #0x560]
006ADA490  bl       #0x382bd14 ; 
006ADA494  mov      w8, #1
006ADA498  strb     w8, [x21, #0x14e]
006ADA49C  adrp     x8, #0x8f3c000
006ADA4A0  ldr      x8, [x8, #0x560]
006ADA4A4  ldr      x2, [x8]
006ADA4A8  ldrb     w8, [x2, #0x53]
006ADA4AC  tbnz     w8, #5, #0x6ada4c4
006ADA4B0  mov      x0, x19
006ADA4B4  str      x20, [x0, #0x38]!
006ADA4B8  mov      x1, x20
006ADA4BC  bl       #0x382bcb8 ; 
006ADA4C0  b        #0x6ada4d4 ; 
006ADA4C4  ldr      x8, [x2, #0x60]
006ADA4C8  mov      x0, x19
006ADA4CC  mov      x1, x20
006ADA4D0  blr      x8
006ADA4D4  mov      x0, x19
006ADA4D8  mov      x1, xzr
006ADA4DC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADA4E0  adrp     x21, #0x959f000
006ADA4E4  ldrb     w8, [x21, #0x14f]
006ADA4E8  mov      x20, x0
006ADA4EC  cbnz     w8, #0x6ada504
006ADA4F0  adrp     x0, #0x8f3c000
006ADA4F4  ldr      x0, [x0, #0x570]
006ADA4F8  bl       #0x382bd14 ; 
006ADA4FC  mov      w8, #1
006ADA500  strb     w8, [x21, #0x14f]
006ADA504  adrp     x8, #0x8f3c000
006ADA508  ldr      x8, [x8, #0x570]
006ADA50C  ldr      x2, [x8]
006ADA510  ldrb     w8, [x2, #0x53]
006ADA514  tbnz     w8, #5, #0x6ada52c
006ADA518  str      x20, [x19, #0x40]!
006ADA51C  mov      x0, x19
006ADA520  mov      x1, x20
006ADA524  bl       #0x382bcb8 ; 
006ADA528  b        #0x6ada53c ; 
006ADA52C  ldr      x8, [x2, #0x60]
006ADA530  mov      x0, x19
006ADA534  mov      x1, x20
006ADA538  blr      x8
006ADA53C  ldp      x20, x19, [sp, #0x10]
006ADA540  mov      w0, #1
006ADA544  ldp      x30, x21, [sp], #0x20
006ADA548  ret      

