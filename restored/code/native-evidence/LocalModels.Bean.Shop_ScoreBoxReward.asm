; LocalModels.Bean.Shop_ScoreBoxReward$$readImpl
; RVA 0x6AEDC60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AEDC60  stp      x30, x21, [sp, #-0x20]!
006AEDC64  stp      x20, x19, [sp, #0x10]
006AEDC68  adrp     x20, #0x959e000
006AEDC6C  adrp     x21, #0x8f3d000
006AEDC70  ldrb     w8, [x20, #0xe1a]
006AEDC74  ldr      x21, [x21, #0x408]
006AEDC78  mov      x19, x0
006AEDC7C  tbnz     w8, #0, #0x6aedc94
006AEDC80  adrp     x0, #0x8f3d000
006AEDC84  ldr      x0, [x0, #0x408]
006AEDC88  bl       #0x382bd14 ; 
006AEDC8C  mov      w8, #1
006AEDC90  strb     w8, [x20, #0xe1a]
006AEDC94  ldr      x1, [x21]
006AEDC98  ldrb     w8, [x1, #0x53]
006AEDC9C  tbnz     w8, #5, #0x6aedcec
006AEDCA0  mov      x0, x19
006AEDCA4  mov      x1, xzr
006AEDCA8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEDCAC  adrp     x21, #0x959f000
006AEDCB0  ldrb     w8, [x21, #0x226]
006AEDCB4  mov      w20, w0
006AEDCB8  cbnz     w8, #0x6aedcd0
006AEDCBC  adrp     x0, #0x8f3d000
006AEDCC0  ldr      x0, [x0, #0x3c0]
006AEDCC4  bl       #0x382bd14 ; 
006AEDCC8  mov      w8, #1
006AEDCCC  strb     w8, [x21, #0x226]
006AEDCD0  adrp     x8, #0x8f3d000
006AEDCD4  ldr      x8, [x8, #0x3c0]
006AEDCD8  ldr      x2, [x8]
006AEDCDC  ldrb     w8, [x2, #0x53]
006AEDCE0  tbnz     w8, #5, #0x6aedd00
006AEDCE4  str      w20, [x19, #0x20]
006AEDCE8  b        #0x6aedd10 ; 
006AEDCEC  ldr      x2, [x1, #0x60]
006AEDCF0  mov      x0, x19
006AEDCF4  ldp      x20, x19, [sp, #0x10]
006AEDCF8  ldp      x30, x21, [sp], #0x20
006AEDCFC  br       x2
006AEDD00  ldr      x8, [x2, #0x60]
006AEDD04  mov      x0, x19
006AEDD08  mov      w1, w20
006AEDD0C  blr      x8
006AEDD10  mov      x0, x19
006AEDD14  mov      x1, xzr
006AEDD18  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEDD1C  adrp     x21, #0x959f000
006AEDD20  ldrb     w8, [x21, #0x227]
006AEDD24  mov      w20, w0
006AEDD28  cbnz     w8, #0x6aedd40
006AEDD2C  adrp     x0, #0x8f3d000
006AEDD30  ldr      x0, [x0, #0x3d0]
006AEDD34  bl       #0x382bd14 ; 
006AEDD38  mov      w8, #1
006AEDD3C  strb     w8, [x21, #0x227]
006AEDD40  adrp     x8, #0x8f3d000
006AEDD44  ldr      x8, [x8, #0x3d0]
006AEDD48  ldr      x2, [x8]
006AEDD4C  ldrb     w8, [x2, #0x53]
006AEDD50  tbnz     w8, #5, #0x6aedd5c
006AEDD54  str      w20, [x19, #0x24]
006AEDD58  b        #0x6aedd6c ; 
006AEDD5C  ldr      x8, [x2, #0x60]
006AEDD60  mov      x0, x19
006AEDD64  mov      w1, w20
006AEDD68  blr      x8
006AEDD6C  mov      x0, x19
006AEDD70  mov      x1, xzr
006AEDD74  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEDD78  adrp     x21, #0x959f000
006AEDD7C  ldrb     w8, [x21, #0x228]
006AEDD80  mov      w20, w0
006AEDD84  cbnz     w8, #0x6aedd9c
006AEDD88  adrp     x0, #0x8f3d000
006AEDD8C  ldr      x0, [x0, #0x3e0]
006AEDD90  bl       #0x382bd14 ; 
006AEDD94  mov      w8, #1
006AEDD98  strb     w8, [x21, #0x228]
006AEDD9C  adrp     x8, #0x8f3d000
006AEDDA0  ldr      x8, [x8, #0x3e0]
006AEDDA4  ldr      x2, [x8]
006AEDDA8  ldrb     w8, [x2, #0x53]
006AEDDAC  tbnz     w8, #5, #0x6aeddb8
006AEDDB0  str      w20, [x19, #0x28]
006AEDDB4  b        #0x6aeddc8 ; 
006AEDDB8  ldr      x8, [x2, #0x60]
006AEDDBC  mov      x0, x19
006AEDDC0  mov      w1, w20
006AEDDC4  blr      x8
006AEDDC8  mov      x0, x19
006AEDDCC  mov      x1, xzr
006AEDDD0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEDDD4  adrp     x21, #0x959f000
006AEDDD8  ldrb     w8, [x21, #0x229]
006AEDDDC  mov      w20, w0
006AEDDE0  cbnz     w8, #0x6aeddf8
006AEDDE4  adrp     x0, #0x8f3d000
006AEDDE8  ldr      x0, [x0, #0x3f0]
006AEDDEC  bl       #0x382bd14 ; 
006AEDDF0  mov      w8, #1
006AEDDF4  strb     w8, [x21, #0x229]
006AEDDF8  adrp     x8, #0x8f3d000
006AEDDFC  ldr      x8, [x8, #0x3f0]
006AEDE00  ldr      x2, [x8]
006AEDE04  ldrb     w8, [x2, #0x53]
006AEDE08  tbnz     w8, #5, #0x6aede14
006AEDE0C  str      w20, [x19, #0x2c]
006AEDE10  b        #0x6aede24 ; 
006AEDE14  ldr      x8, [x2, #0x60]
006AEDE18  mov      x0, x19
006AEDE1C  mov      w1, w20
006AEDE20  blr      x8
006AEDE24  mov      x0, x19
006AEDE28  mov      x1, xzr
006AEDE2C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AEDE30  adrp     x21, #0x959f000
006AEDE34  ldrb     w8, [x21, #0x22a]
006AEDE38  mov      x20, x0
006AEDE3C  cbnz     w8, #0x6aede54
006AEDE40  adrp     x0, #0x8f3d000
006AEDE44  ldr      x0, [x0, #0x400]
006AEDE48  bl       #0x382bd14 ; 
006AEDE4C  mov      w8, #1
006AEDE50  strb     w8, [x21, #0x22a]
006AEDE54  adrp     x8, #0x8f3d000
006AEDE58  ldr      x8, [x8, #0x400]
006AEDE5C  ldr      x2, [x8]
006AEDE60  ldrb     w8, [x2, #0x53]
006AEDE64  tbnz     w8, #5, #0x6aede7c
006AEDE68  str      x20, [x19, #0x30]!
006AEDE6C  mov      x0, x19
006AEDE70  mov      x1, x20
006AEDE74  bl       #0x382bcb8 ; 
006AEDE78  b        #0x6aede8c ; 
006AEDE7C  ldr      x8, [x2, #0x60]
006AEDE80  mov      x0, x19
006AEDE84  mov      x1, x20
006AEDE88  blr      x8
006AEDE8C  ldp      x20, x19, [sp, #0x10]
006AEDE90  mov      w0, #1
006AEDE94  ldp      x30, x21, [sp], #0x20
006AEDE98  ret      

