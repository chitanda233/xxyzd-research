; LocalModels.Bean.IAP_SignInPass$$readImpl
; RVA 0x6AA98D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA98D4  stp      x30, x21, [sp, #-0x20]!
006AA98D8  stp      x20, x19, [sp, #0x10]
006AA98DC  adrp     x20, #0x959e000
006AA98E0  adrp     x21, #0x8f3a000
006AA98E4  ldrb     w8, [x20, #0x717]
006AA98E8  ldr      x21, [x21, #0x168]
006AA98EC  mov      x19, x0
006AA98F0  tbnz     w8, #0, #0x6aa9908
006AA98F4  adrp     x0, #0x8f3a000
006AA98F8  ldr      x0, [x0, #0x168]
006AA98FC  bl       #0x382bd14 ; 
006AA9900  mov      w8, #1
006AA9904  strb     w8, [x20, #0x717]
006AA9908  ldr      x1, [x21]
006AA990C  ldrb     w8, [x1, #0x53]
006AA9910  tbnz     w8, #5, #0x6aa9960
006AA9914  mov      x0, x19
006AA9918  mov      x1, xzr
006AA991C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA9920  adrp     x21, #0x959e000
006AA9924  ldrb     w8, [x21, #0xf20]
006AA9928  mov      w20, w0
006AA992C  cbnz     w8, #0x6aa9944
006AA9930  adrp     x0, #0x8f3a000
006AA9934  ldr      x0, [x0, #0x100]
006AA9938  bl       #0x382bd14 ; 
006AA993C  mov      w8, #1
006AA9940  strb     w8, [x21, #0xf20]
006AA9944  adrp     x8, #0x8f3a000
006AA9948  ldr      x8, [x8, #0x100]
006AA994C  ldr      x2, [x8]
006AA9950  ldrb     w8, [x2, #0x53]
006AA9954  tbnz     w8, #5, #0x6aa9974
006AA9958  str      w20, [x19, #0x20]
006AA995C  b        #0x6aa9984 ; 
006AA9960  ldr      x2, [x1, #0x60]
006AA9964  mov      x0, x19
006AA9968  ldp      x20, x19, [sp, #0x10]
006AA996C  ldp      x30, x21, [sp], #0x20
006AA9970  br       x2
006AA9974  ldr      x8, [x2, #0x60]
006AA9978  mov      x0, x19
006AA997C  mov      w1, w20
006AA9980  blr      x8
006AA9984  mov      x0, x19
006AA9988  mov      x1, xzr
006AA998C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA9990  adrp     x21, #0x959e000
006AA9994  ldrb     w8, [x21, #0xf21]
006AA9998  mov      w20, w0
006AA999C  cbnz     w8, #0x6aa99b4
006AA99A0  adrp     x0, #0x8f3a000
006AA99A4  ldr      x0, [x0, #0x110]
006AA99A8  bl       #0x382bd14 ; 
006AA99AC  mov      w8, #1
006AA99B0  strb     w8, [x21, #0xf21]
006AA99B4  adrp     x8, #0x8f3a000
006AA99B8  ldr      x8, [x8, #0x110]
006AA99BC  ldr      x2, [x8]
006AA99C0  ldrb     w8, [x2, #0x53]
006AA99C4  tbnz     w8, #5, #0x6aa99d0
006AA99C8  str      w20, [x19, #0x24]
006AA99CC  b        #0x6aa99e0 ; 
006AA99D0  ldr      x8, [x2, #0x60]
006AA99D4  mov      x0, x19
006AA99D8  mov      w1, w20
006AA99DC  blr      x8
006AA99E0  mov      x0, x19
006AA99E4  mov      x1, xzr
006AA99E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA99EC  adrp     x21, #0x959e000
006AA99F0  ldrb     w8, [x21, #0xf22]
006AA99F4  mov      w20, w0
006AA99F8  cbnz     w8, #0x6aa9a10
006AA99FC  adrp     x0, #0x8f3a000
006AA9A00  ldr      x0, [x0, #0x120]
006AA9A04  bl       #0x382bd14 ; 
006AA9A08  mov      w8, #1
006AA9A0C  strb     w8, [x21, #0xf22]
006AA9A10  adrp     x8, #0x8f3a000
006AA9A14  ldr      x8, [x8, #0x120]
006AA9A18  ldr      x2, [x8]
006AA9A1C  ldrb     w8, [x2, #0x53]
006AA9A20  tbnz     w8, #5, #0x6aa9a2c
006AA9A24  str      w20, [x19, #0x28]
006AA9A28  b        #0x6aa9a3c ; 
006AA9A2C  ldr      x8, [x2, #0x60]
006AA9A30  mov      x0, x19
006AA9A34  mov      w1, w20
006AA9A38  blr      x8
006AA9A3C  mov      x0, x19
006AA9A40  mov      x1, xzr
006AA9A44  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AA9A48  adrp     x21, #0x959e000
006AA9A4C  ldrb     w8, [x21, #0xf23]
006AA9A50  mov      x20, x0
006AA9A54  cbnz     w8, #0x6aa9a6c
006AA9A58  adrp     x0, #0x8f3a000
006AA9A5C  ldr      x0, [x0, #0x130]
006AA9A60  bl       #0x382bd14 ; 
006AA9A64  mov      w8, #1
006AA9A68  strb     w8, [x21, #0xf23]
006AA9A6C  adrp     x8, #0x8f3a000
006AA9A70  ldr      x8, [x8, #0x130]
006AA9A74  ldr      x2, [x8]
006AA9A78  ldrb     w8, [x2, #0x53]
006AA9A7C  tbnz     w8, #5, #0x6aa9a94
006AA9A80  mov      x0, x19
006AA9A84  str      x20, [x0, #0x30]!
006AA9A88  mov      x1, x20
006AA9A8C  bl       #0x382bcb8 ; 
006AA9A90  b        #0x6aa9aa4 ; 
006AA9A94  ldr      x8, [x2, #0x60]
006AA9A98  mov      x0, x19
006AA9A9C  mov      x1, x20
006AA9AA0  blr      x8
006AA9AA4  mov      x0, x19
006AA9AA8  mov      x1, xzr
006AA9AAC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AA9AB0  adrp     x21, #0x959e000
006AA9AB4  ldrb     w8, [x21, #0xf24]
006AA9AB8  mov      x20, x0
006AA9ABC  cbnz     w8, #0x6aa9ad4
006AA9AC0  adrp     x0, #0x8f3a000
006AA9AC4  ldr      x0, [x0, #0x140]
006AA9AC8  bl       #0x382bd14 ; 
006AA9ACC  mov      w8, #1
006AA9AD0  strb     w8, [x21, #0xf24]
006AA9AD4  adrp     x8, #0x8f3a000
006AA9AD8  ldr      x8, [x8, #0x140]
006AA9ADC  ldr      x2, [x8]
006AA9AE0  ldrb     w8, [x2, #0x53]
006AA9AE4  tbnz     w8, #5, #0x6aa9afc
006AA9AE8  mov      x0, x19
006AA9AEC  str      x20, [x0, #0x38]!
006AA9AF0  mov      x1, x20
006AA9AF4  bl       #0x382bcb8 ; 
006AA9AF8  b        #0x6aa9b0c ; 
006AA9AFC  ldr      x8, [x2, #0x60]
006AA9B00  mov      x0, x19
006AA9B04  mov      x1, x20
006AA9B08  blr      x8
006AA9B0C  mov      x0, x19
006AA9B10  mov      x1, xzr
006AA9B14  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AA9B18  adrp     x21, #0x959e000
006AA9B1C  ldrb     w8, [x21, #0xf25]
006AA9B20  mov      x20, x0
006AA9B24  cbnz     w8, #0x6aa9b3c
006AA9B28  adrp     x0, #0x8f3a000
006AA9B2C  ldr      x0, [x0, #0x150]
006AA9B30  bl       #0x382bd14 ; 
006AA9B34  mov      w8, #1
006AA9B38  strb     w8, [x21, #0xf25]
006AA9B3C  adrp     x8, #0x8f3a000
006AA9B40  ldr      x8, [x8, #0x150]
006AA9B44  ldr      x2, [x8]
006AA9B48  ldrb     w8, [x2, #0x53]
006AA9B4C  tbnz     w8, #5, #0x6aa9b64
006AA9B50  mov      x0, x19
006AA9B54  str      x20, [x0, #0x40]!
006AA9B58  mov      x1, x20
006AA9B5C  bl       #0x382bcb8 ; 
006AA9B60  b        #0x6aa9b74 ; 
006AA9B64  ldr      x8, [x2, #0x60]
006AA9B68  mov      x0, x19
006AA9B6C  mov      x1, x20
006AA9B70  blr      x8
006AA9B74  mov      x0, x19
006AA9B78  mov      x1, xzr
006AA9B7C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA9B80  adrp     x21, #0x959e000
006AA9B84  ldrb     w8, [x21, #0xf26]
006AA9B88  mov      w20, w0
006AA9B8C  cbnz     w8, #0x6aa9ba4
006AA9B90  adrp     x0, #0x8f3a000
006AA9B94  ldr      x0, [x0, #0x160]
006AA9B98  bl       #0x382bd14 ; 
006AA9B9C  mov      w8, #1
006AA9BA0  strb     w8, [x21, #0xf26]
006AA9BA4  adrp     x8, #0x8f3a000
006AA9BA8  ldr      x8, [x8, #0x160]
006AA9BAC  ldr      x2, [x8]
006AA9BB0  ldrb     w8, [x2, #0x53]
006AA9BB4  tbnz     w8, #5, #0x6aa9bc0
006AA9BB8  str      w20, [x19, #0x48]
006AA9BBC  b        #0x6aa9bd0 ; 
006AA9BC0  ldr      x8, [x2, #0x60]
006AA9BC4  mov      x0, x19
006AA9BC8  mov      w1, w20
006AA9BCC  blr      x8
006AA9BD0  ldp      x20, x19, [sp, #0x10]
006AA9BD4  mov      w0, #1
006AA9BD8  ldp      x30, x21, [sp], #0x20
006AA9BDC  ret      

