; LocalModels.Bean.Role_SkinStar$$readImpl
; RVA 0x6AE1A7C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE1A7C  stp      x30, x21, [sp, #-0x20]!
006AE1A80  stp      x20, x19, [sp, #0x10]
006AE1A84  adrp     x20, #0x959e000
006AE1A88  adrp     x21, #0x8f3c000
006AE1A8C  ldrb     w8, [x20, #0xcd6]
006AE1A90  ldr      x21, [x21, #0xad0]
006AE1A94  mov      x19, x0
006AE1A98  tbnz     w8, #0, #0x6ae1ab0
006AE1A9C  adrp     x0, #0x8f3c000
006AE1AA0  ldr      x0, [x0, #0xad0]
006AE1AA4  bl       #0x382bd14 ; 
006AE1AA8  mov      w8, #1
006AE1AAC  strb     w8, [x20, #0xcd6]
006AE1AB0  ldr      x1, [x21]
006AE1AB4  ldrb     w8, [x1, #0x53]
006AE1AB8  tbnz     w8, #5, #0x6ae1b08
006AE1ABC  mov      x0, x19
006AE1AC0  mov      x1, xzr
006AE1AC4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE1AC8  adrp     x21, #0x959f000
006AE1ACC  ldrb     w8, [x21, #0x1a1]
006AE1AD0  mov      w20, w0
006AE1AD4  cbnz     w8, #0x6ae1aec
006AE1AD8  adrp     x0, #0x8f3c000
006AE1ADC  ldr      x0, [x0, #0xa88]
006AE1AE0  bl       #0x382bd14 ; 
006AE1AE4  mov      w8, #1
006AE1AE8  strb     w8, [x21, #0x1a1]
006AE1AEC  adrp     x8, #0x8f3c000
006AE1AF0  ldr      x8, [x8, #0xa88]
006AE1AF4  ldr      x2, [x8]
006AE1AF8  ldrb     w8, [x2, #0x53]
006AE1AFC  tbnz     w8, #5, #0x6ae1b1c
006AE1B00  str      w20, [x19, #0x20]
006AE1B04  b        #0x6ae1b2c ; 
006AE1B08  ldr      x2, [x1, #0x60]
006AE1B0C  mov      x0, x19
006AE1B10  ldp      x20, x19, [sp, #0x10]
006AE1B14  ldp      x30, x21, [sp], #0x20
006AE1B18  br       x2
006AE1B1C  ldr      x8, [x2, #0x60]
006AE1B20  mov      x0, x19
006AE1B24  mov      w1, w20
006AE1B28  blr      x8
006AE1B2C  mov      x0, x19
006AE1B30  mov      x1, xzr
006AE1B34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE1B38  adrp     x21, #0x959f000
006AE1B3C  ldrb     w8, [x21, #0x1a2]
006AE1B40  mov      w20, w0
006AE1B44  cbnz     w8, #0x6ae1b5c
006AE1B48  adrp     x0, #0x8f3c000
006AE1B4C  ldr      x0, [x0, #0xa98]
006AE1B50  bl       #0x382bd14 ; 
006AE1B54  mov      w8, #1
006AE1B58  strb     w8, [x21, #0x1a2]
006AE1B5C  adrp     x8, #0x8f3c000
006AE1B60  ldr      x8, [x8, #0xa98]
006AE1B64  ldr      x2, [x8]
006AE1B68  ldrb     w8, [x2, #0x53]
006AE1B6C  tbnz     w8, #5, #0x6ae1b78
006AE1B70  str      w20, [x19, #0x24]
006AE1B74  b        #0x6ae1b88 ; 
006AE1B78  ldr      x8, [x2, #0x60]
006AE1B7C  mov      x0, x19
006AE1B80  mov      w1, w20
006AE1B84  blr      x8
006AE1B88  mov      x0, x19
006AE1B8C  mov      x1, xzr
006AE1B90  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE1B94  adrp     x21, #0x959f000
006AE1B98  ldrb     w8, [x21, #0x1a3]
006AE1B9C  mov      w20, w0
006AE1BA0  cbnz     w8, #0x6ae1bb8
006AE1BA4  adrp     x0, #0x8f3c000
006AE1BA8  ldr      x0, [x0, #0xaa8]
006AE1BAC  bl       #0x382bd14 ; 
006AE1BB0  mov      w8, #1
006AE1BB4  strb     w8, [x21, #0x1a3]
006AE1BB8  adrp     x8, #0x8f3c000
006AE1BBC  ldr      x8, [x8, #0xaa8]
006AE1BC0  ldr      x2, [x8]
006AE1BC4  ldrb     w8, [x2, #0x53]
006AE1BC8  tbnz     w8, #5, #0x6ae1bd4
006AE1BCC  str      w20, [x19, #0x28]
006AE1BD0  b        #0x6ae1be4 ; 
006AE1BD4  ldr      x8, [x2, #0x60]
006AE1BD8  mov      x0, x19
006AE1BDC  mov      w1, w20
006AE1BE0  blr      x8
006AE1BE4  mov      x0, x19
006AE1BE8  mov      x1, xzr
006AE1BEC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AE1BF0  adrp     x21, #0x959f000
006AE1BF4  ldrb     w8, [x21, #0x1a4]
006AE1BF8  mov      x20, x0
006AE1BFC  cbnz     w8, #0x6ae1c14
006AE1C00  adrp     x0, #0x8f3c000
006AE1C04  ldr      x0, [x0, #0xab8]
006AE1C08  bl       #0x382bd14 ; 
006AE1C0C  mov      w8, #1
006AE1C10  strb     w8, [x21, #0x1a4]
006AE1C14  adrp     x8, #0x8f3c000
006AE1C18  ldr      x8, [x8, #0xab8]
006AE1C1C  ldr      x2, [x8]
006AE1C20  ldrb     w8, [x2, #0x53]
006AE1C24  tbnz     w8, #5, #0x6ae1c3c
006AE1C28  mov      x0, x19
006AE1C2C  str      x20, [x0, #0x30]!
006AE1C30  mov      x1, x20
006AE1C34  bl       #0x382bcb8 ; 
006AE1C38  b        #0x6ae1c4c ; 
006AE1C3C  ldr      x8, [x2, #0x60]
006AE1C40  mov      x0, x19
006AE1C44  mov      x1, x20
006AE1C48  blr      x8
006AE1C4C  mov      x0, x19
006AE1C50  mov      x1, xzr
006AE1C54  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AE1C58  adrp     x21, #0x959f000
006AE1C5C  ldrb     w8, [x21, #0x1a5]
006AE1C60  mov      x20, x0
006AE1C64  cbnz     w8, #0x6ae1c7c
006AE1C68  adrp     x0, #0x8f3c000
006AE1C6C  ldr      x0, [x0, #0xac0]
006AE1C70  bl       #0x382bd14 ; 
006AE1C74  mov      w8, #1
006AE1C78  strb     w8, [x21, #0x1a5]
006AE1C7C  adrp     x8, #0x8f3c000
006AE1C80  ldr      x8, [x8, #0xac0]
006AE1C84  ldr      x2, [x8]
006AE1C88  ldrb     w8, [x2, #0x53]
006AE1C8C  tbnz     w8, #5, #0x6ae1ca4
006AE1C90  mov      x0, x19
006AE1C94  str      x20, [x0, #0x38]!
006AE1C98  mov      x1, x20
006AE1C9C  bl       #0x382bcb8 ; 
006AE1CA0  b        #0x6ae1cb4 ; 
006AE1CA4  ldr      x8, [x2, #0x60]
006AE1CA8  mov      x0, x19
006AE1CAC  mov      x1, x20
006AE1CB0  blr      x8
006AE1CB4  mov      x0, x19
006AE1CB8  mov      x1, xzr
006AE1CBC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AE1CC0  adrp     x21, #0x959f000
006AE1CC4  ldrb     w8, [x21, #0x1a6]
006AE1CC8  mov      x20, x0
006AE1CCC  cbnz     w8, #0x6ae1ce4
006AE1CD0  adrp     x0, #0x8f3c000
006AE1CD4  ldr      x0, [x0, #0xac8]
006AE1CD8  bl       #0x382bd14 ; 
006AE1CDC  mov      w8, #1
006AE1CE0  strb     w8, [x21, #0x1a6]
006AE1CE4  adrp     x8, #0x8f3c000
006AE1CE8  ldr      x8, [x8, #0xac8]
006AE1CEC  ldr      x2, [x8]
006AE1CF0  ldrb     w8, [x2, #0x53]
006AE1CF4  tbnz     w8, #5, #0x6ae1d0c
006AE1CF8  str      x20, [x19, #0x40]!
006AE1CFC  mov      x0, x19
006AE1D00  mov      x1, x20
006AE1D04  bl       #0x382bcb8 ; 
006AE1D08  b        #0x6ae1d1c ; 
006AE1D0C  ldr      x8, [x2, #0x60]
006AE1D10  mov      x0, x19
006AE1D14  mov      x1, x20
006AE1D18  blr      x8
006AE1D1C  ldp      x20, x19, [sp, #0x10]
006AE1D20  mov      w0, #1
006AE1D24  ldp      x30, x21, [sp], #0x20
006AE1D28  ret      

