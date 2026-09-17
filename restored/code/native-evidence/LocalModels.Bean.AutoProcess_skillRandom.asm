; LocalModels.Bean.AutoProcess_skillRandom$$readImpl
; RVA 0x6883B04; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006883B04  stp      x30, x21, [sp, #-0x20]!
006883B08  stp      x20, x19, [sp, #0x10]
006883B0C  adrp     x20, #0x959b000
006883B10  adrp     x21, #0x8f24000
006883B14  ldrb     w8, [x20, #0xbd6]
006883B18  ldr      x21, [x21, #0xe48]
006883B1C  mov      x19, x0
006883B20  tbnz     w8, #0, #0x6883b38
006883B24  adrp     x0, #0x8f24000
006883B28  ldr      x0, [x0, #0xe48]
006883B2C  bl       #0x382bd14 ; 
006883B30  mov      w8, #1
006883B34  strb     w8, [x20, #0xbd6]
006883B38  ldr      x1, [x21]
006883B3C  ldrb     w8, [x1, #0x53]
006883B40  tbnz     w8, #5, #0x6883b90
006883B44  mov      x0, x19
006883B48  mov      x1, xzr
006883B4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006883B50  adrp     x21, #0x959c000
006883B54  ldrb     w8, [x21, #0x3d5]
006883B58  mov      w20, w0
006883B5C  cbnz     w8, #0x6883b74
006883B60  adrp     x0, #0x8f24000
006883B64  ldr      x0, [x0, #0xe30]
006883B68  bl       #0x382bd14 ; 
006883B6C  mov      w8, #1
006883B70  strb     w8, [x21, #0x3d5]
006883B74  adrp     x8, #0x8f24000
006883B78  ldr      x8, [x8, #0xe30]
006883B7C  ldr      x2, [x8]
006883B80  ldrb     w8, [x2, #0x53]
006883B84  tbnz     w8, #5, #0x6883ba4
006883B88  str      w20, [x19, #0x20]
006883B8C  b        #0x6883bb4 ; 
006883B90  ldr      x2, [x1, #0x60]
006883B94  mov      x0, x19
006883B98  ldp      x20, x19, [sp, #0x10]
006883B9C  ldp      x30, x21, [sp], #0x20
006883BA0  br       x2
006883BA4  ldr      x8, [x2, #0x60]
006883BA8  mov      x0, x19
006883BAC  mov      w1, w20
006883BB0  blr      x8
006883BB4  mov      x0, x19
006883BB8  mov      x1, xzr
006883BBC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006883BC0  adrp     x21, #0x959c000
006883BC4  ldrb     w8, [x21, #0x3d6]
006883BC8  mov      x20, x0
006883BCC  cbnz     w8, #0x6883be4
006883BD0  adrp     x0, #0x8f24000
006883BD4  ldr      x0, [x0, #0xe40]
006883BD8  bl       #0x382bd14 ; 
006883BDC  mov      w8, #1
006883BE0  strb     w8, [x21, #0x3d6]
006883BE4  adrp     x8, #0x8f24000
006883BE8  ldr      x8, [x8, #0xe40]
006883BEC  ldr      x2, [x8]
006883BF0  ldrb     w8, [x2, #0x53]
006883BF4  tbnz     w8, #5, #0x6883c0c
006883BF8  str      x20, [x19, #0x28]!
006883BFC  mov      x0, x19
006883C00  mov      x1, x20
006883C04  bl       #0x382bcb8 ; 
006883C08  b        #0x6883c1c ; 
006883C0C  ldr      x8, [x2, #0x60]
006883C10  mov      x0, x19
006883C14  mov      x1, x20
006883C18  blr      x8
006883C1C  ldp      x20, x19, [sp, #0x10]
006883C20  mov      w0, #1
006883C24  ldp      x30, x21, [sp], #0x20
006883C28  ret      

