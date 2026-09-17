; LocalModels.Bean.SevenDay_SevenDayTask$$readImpl
; RVA 0x6AE9824; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE9824  stp      x30, x21, [sp, #-0x20]!
006AE9828  stp      x20, x19, [sp, #0x10]
006AE982C  adrp     x20, #0x959e000
006AE9830  adrp     x21, #0x8f3d000
006AE9834  ldrb     w8, [x20, #0xdaa]
006AE9838  ldr      x21, [x21, #0xc8]
006AE983C  mov      x19, x0
006AE9840  tbnz     w8, #0, #0x6ae9858
006AE9844  adrp     x0, #0x8f3d000
006AE9848  ldr      x0, [x0, #0xc8]
006AE984C  bl       #0x382bd14 ; 
006AE9850  mov      w8, #1
006AE9854  strb     w8, [x20, #0xdaa]
006AE9858  ldr      x1, [x21]
006AE985C  ldrb     w8, [x1, #0x53]
006AE9860  tbnz     w8, #5, #0x6ae98b0
006AE9864  mov      x0, x19
006AE9868  mov      x1, xzr
006AE986C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE9870  adrp     x21, #0x959f000
006AE9874  ldrb     w8, [x21, #0x1f4]
006AE9878  mov      w20, w0
006AE987C  cbnz     w8, #0x6ae9894
006AE9880  adrp     x0, #0x8f3d000
006AE9884  ldr      x0, [x0, #0x20]
006AE9888  bl       #0x382bd14 ; 
006AE988C  mov      w8, #1
006AE9890  strb     w8, [x21, #0x1f4]
006AE9894  adrp     x8, #0x8f3d000
006AE9898  ldr      x8, [x8, #0x20]
006AE989C  ldr      x2, [x8]
006AE98A0  ldrb     w8, [x2, #0x53]
006AE98A4  tbnz     w8, #5, #0x6ae98c4
006AE98A8  str      w20, [x19, #0x20]
006AE98AC  b        #0x6ae98d4 ; 
006AE98B0  ldr      x2, [x1, #0x60]
006AE98B4  mov      x0, x19
006AE98B8  ldp      x20, x19, [sp, #0x10]
006AE98BC  ldp      x30, x21, [sp], #0x20
006AE98C0  br       x2
006AE98C4  ldr      x8, [x2, #0x60]
006AE98C8  mov      x0, x19
006AE98CC  mov      w1, w20
006AE98D0  blr      x8
006AE98D4  mov      x0, x19
006AE98D8  mov      x1, xzr
006AE98DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE98E0  adrp     x21, #0x959f000
006AE98E4  ldrb     w8, [x21, #0x1f5]
006AE98E8  mov      w20, w0
006AE98EC  cbnz     w8, #0x6ae9904
006AE98F0  adrp     x0, #0x8f3d000
006AE98F4  ldr      x0, [x0, #0x30]
006AE98F8  bl       #0x382bd14 ; 
006AE98FC  mov      w8, #1
006AE9900  strb     w8, [x21, #0x1f5]
006AE9904  adrp     x8, #0x8f3d000
006AE9908  ldr      x8, [x8, #0x30]
006AE990C  ldr      x2, [x8]
006AE9910  ldrb     w8, [x2, #0x53]
006AE9914  tbnz     w8, #5, #0x6ae9920
006AE9918  str      w20, [x19, #0x24]
006AE991C  b        #0x6ae9930 ; 
006AE9920  ldr      x8, [x2, #0x60]
006AE9924  mov      x0, x19
006AE9928  mov      w1, w20
006AE992C  blr      x8
006AE9930  mov      x0, x19
006AE9934  mov      x1, xzr
006AE9938  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE993C  adrp     x21, #0x959f000
006AE9940  ldrb     w8, [x21, #0x1f6]
006AE9944  mov      w20, w0
006AE9948  cbnz     w8, #0x6ae9960
006AE994C  adrp     x0, #0x8f3d000
006AE9950  ldr      x0, [x0, #0x40]
006AE9954  bl       #0x382bd14 ; 
006AE9958  mov      w8, #1
006AE995C  strb     w8, [x21, #0x1f6]
006AE9960  adrp     x8, #0x8f3d000
006AE9964  ldr      x8, [x8, #0x40]
006AE9968  ldr      x2, [x8]
006AE996C  ldrb     w8, [x2, #0x53]
006AE9970  tbnz     w8, #5, #0x6ae997c
006AE9974  str      w20, [x19, #0x28]
006AE9978  b        #0x6ae998c ; 
006AE997C  ldr      x8, [x2, #0x60]
006AE9980  mov      x0, x19
006AE9984  mov      w1, w20
006AE9988  blr      x8
006AE998C  mov      x0, x19
006AE9990  mov      x1, xzr
006AE9994  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE9998  adrp     x21, #0x959f000
006AE999C  ldrb     w8, [x21, #0x1f7]
006AE99A0  mov      w20, w0
006AE99A4  cbnz     w8, #0x6ae99bc
006AE99A8  adrp     x0, #0x8f3d000
006AE99AC  ldr      x0, [x0, #0x50]
006AE99B0  bl       #0x382bd14 ; 
006AE99B4  mov      w8, #1
006AE99B8  strb     w8, [x21, #0x1f7]
006AE99BC  adrp     x8, #0x8f3d000
006AE99C0  ldr      x8, [x8, #0x50]
006AE99C4  ldr      x2, [x8]
006AE99C8  ldrb     w8, [x2, #0x53]
006AE99CC  tbnz     w8, #5, #0x6ae99d8
006AE99D0  str      w20, [x19, #0x2c]
006AE99D4  b        #0x6ae99e8 ; 
006AE99D8  ldr      x8, [x2, #0x60]
006AE99DC  mov      x0, x19
006AE99E0  mov      w1, w20
006AE99E4  blr      x8
006AE99E8  mov      x0, x19
006AE99EC  mov      x1, xzr
006AE99F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE99F4  adrp     x21, #0x959f000
006AE99F8  ldrb     w8, [x21, #0x1f8]
006AE99FC  mov      w20, w0
006AE9A00  cbnz     w8, #0x6ae9a18
006AE9A04  adrp     x0, #0x8f3d000
006AE9A08  ldr      x0, [x0, #0x60]
006AE9A0C  bl       #0x382bd14 ; 
006AE9A10  mov      w8, #1
006AE9A14  strb     w8, [x21, #0x1f8]
006AE9A18  adrp     x8, #0x8f3d000
006AE9A1C  ldr      x8, [x8, #0x60]
006AE9A20  ldr      x2, [x8]
006AE9A24  ldrb     w8, [x2, #0x53]
006AE9A28  tbnz     w8, #5, #0x6ae9a34
006AE9A2C  str      w20, [x19, #0x30]
006AE9A30  b        #0x6ae9a44 ; 
006AE9A34  ldr      x8, [x2, #0x60]
006AE9A38  mov      x0, x19
006AE9A3C  mov      w1, w20
006AE9A40  blr      x8
006AE9A44  mov      x0, x19
006AE9A48  mov      x1, xzr
006AE9A4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE9A50  adrp     x21, #0x959f000
006AE9A54  ldrb     w8, [x21, #0x1f9]
006AE9A58  mov      w20, w0
006AE9A5C  cbnz     w8, #0x6ae9a74
006AE9A60  adrp     x0, #0x8f3d000
006AE9A64  ldr      x0, [x0, #0x70]
006AE9A68  bl       #0x382bd14 ; 
006AE9A6C  mov      w8, #1
006AE9A70  strb     w8, [x21, #0x1f9]
006AE9A74  adrp     x8, #0x8f3d000
006AE9A78  ldr      x8, [x8, #0x70]
006AE9A7C  ldr      x2, [x8]
006AE9A80  ldrb     w8, [x2, #0x53]
006AE9A84  tbnz     w8, #5, #0x6ae9a90
006AE9A88  str      w20, [x19, #0x34]
006AE9A8C  b        #0x6ae9aa0 ; 
006AE9A90  ldr      x8, [x2, #0x60]
006AE9A94  mov      x0, x19
006AE9A98  mov      w1, w20
006AE9A9C  blr      x8
006AE9AA0  mov      x0, x19
006AE9AA4  mov      x1, xzr
006AE9AA8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE9AAC  adrp     x21, #0x959f000
006AE9AB0  ldrb     w8, [x21, #0x1fa]
006AE9AB4  mov      w20, w0
006AE9AB8  cbnz     w8, #0x6ae9ad0
006AE9ABC  adrp     x0, #0x8f3d000
006AE9AC0  ldr      x0, [x0, #0x80]
006AE9AC4  bl       #0x382bd14 ; 
006AE9AC8  mov      w8, #1
006AE9ACC  strb     w8, [x21, #0x1fa]
006AE9AD0  adrp     x8, #0x8f3d000
006AE9AD4  ldr      x8, [x8, #0x80]
006AE9AD8  ldr      x2, [x8]
006AE9ADC  ldrb     w8, [x2, #0x53]
006AE9AE0  tbnz     w8, #5, #0x6ae9aec
006AE9AE4  str      w20, [x19, #0x38]
006AE9AE8  b        #0x6ae9afc ; 
006AE9AEC  ldr      x8, [x2, #0x60]
006AE9AF0  mov      x0, x19
006AE9AF4  mov      w1, w20
006AE9AF8  blr      x8
006AE9AFC  mov      x0, x19
006AE9B00  mov      x1, xzr
006AE9B04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE9B08  adrp     x21, #0x959f000
006AE9B0C  ldrb     w8, [x21, #0x1fb]
006AE9B10  mov      w20, w0
006AE9B14  cbnz     w8, #0x6ae9b2c
006AE9B18  adrp     x0, #0x8f3d000
006AE9B1C  ldr      x0, [x0, #0x90]
006AE9B20  bl       #0x382bd14 ; 
006AE9B24  mov      w8, #1
006AE9B28  strb     w8, [x21, #0x1fb]
006AE9B2C  adrp     x8, #0x8f3d000
006AE9B30  ldr      x8, [x8, #0x90]
006AE9B34  ldr      x2, [x8]
006AE9B38  ldrb     w8, [x2, #0x53]
006AE9B3C  tbnz     w8, #5, #0x6ae9b48
006AE9B40  str      w20, [x19, #0x3c]
006AE9B44  b        #0x6ae9b58 ; 
006AE9B48  ldr      x8, [x2, #0x60]
006AE9B4C  mov      x0, x19
006AE9B50  mov      w1, w20
006AE9B54  blr      x8
006AE9B58  mov      x0, x19
006AE9B5C  mov      x1, xzr
006AE9B60  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AE9B64  adrp     x21, #0x959f000
006AE9B68  ldrb     w8, [x21, #0x1fc]
006AE9B6C  mov      x20, x0
006AE9B70  cbnz     w8, #0x6ae9b88
006AE9B74  adrp     x0, #0x8f3d000
006AE9B78  ldr      x0, [x0, #0xa0]
006AE9B7C  bl       #0x382bd14 ; 
006AE9B80  mov      w8, #1
006AE9B84  strb     w8, [x21, #0x1fc]
006AE9B88  adrp     x8, #0x8f3d000
006AE9B8C  ldr      x8, [x8, #0xa0]
006AE9B90  ldr      x2, [x8]
006AE9B94  ldrb     w8, [x2, #0x53]
006AE9B98  tbnz     w8, #5, #0x6ae9bb0
006AE9B9C  mov      x0, x19
006AE9BA0  str      x20, [x0, #0x40]!
006AE9BA4  mov      x1, x20
006AE9BA8  bl       #0x382bcb8 ; 
006AE9BAC  b        #0x6ae9bc0 ; 
006AE9BB0  ldr      x8, [x2, #0x60]
006AE9BB4  mov      x0, x19
006AE9BB8  mov      x1, x20
006AE9BBC  blr      x8
006AE9BC0  mov      x0, x19
006AE9BC4  mov      x1, xzr
006AE9BC8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE9BCC  adrp     x21, #0x959f000
006AE9BD0  ldrb     w8, [x21, #0x1fd]
006AE9BD4  mov      w20, w0
006AE9BD8  cbnz     w8, #0x6ae9bf0
006AE9BDC  adrp     x0, #0x8f3d000
006AE9BE0  ldr      x0, [x0, #0xb0]
006AE9BE4  bl       #0x382bd14 ; 
006AE9BE8  mov      w8, #1
006AE9BEC  strb     w8, [x21, #0x1fd]
006AE9BF0  adrp     x8, #0x8f3d000
006AE9BF4  ldr      x8, [x8, #0xb0]
006AE9BF8  ldr      x2, [x8]
006AE9BFC  ldrb     w8, [x2, #0x53]
006AE9C00  tbnz     w8, #5, #0x6ae9c0c
006AE9C04  str      w20, [x19, #0x48]
006AE9C08  b        #0x6ae9c1c ; 
006AE9C0C  ldr      x8, [x2, #0x60]
006AE9C10  mov      x0, x19
006AE9C14  mov      w1, w20
006AE9C18  blr      x8
006AE9C1C  mov      x0, x19
006AE9C20  mov      x1, xzr
006AE9C24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE9C28  adrp     x21, #0x959f000
006AE9C2C  ldrb     w8, [x21, #0x1fe]
006AE9C30  mov      w20, w0
006AE9C34  cbnz     w8, #0x6ae9c4c
006AE9C38  adrp     x0, #0x8f3d000
006AE9C3C  ldr      x0, [x0, #0xc0]
006AE9C40  bl       #0x382bd14 ; 
006AE9C44  mov      w8, #1
006AE9C48  strb     w8, [x21, #0x1fe]
006AE9C4C  adrp     x8, #0x8f3d000
006AE9C50  ldr      x8, [x8, #0xc0]
006AE9C54  ldr      x2, [x8]
006AE9C58  ldrb     w8, [x2, #0x53]
006AE9C5C  tbnz     w8, #5, #0x6ae9c68
006AE9C60  str      w20, [x19, #0x4c]
006AE9C64  b        #0x6ae9c78 ; 
006AE9C68  ldr      x8, [x2, #0x60]
006AE9C6C  mov      x0, x19
006AE9C70  mov      w1, w20
006AE9C74  blr      x8
006AE9C78  ldp      x20, x19, [sp, #0x10]
006AE9C7C  mov      w0, #1
006AE9C80  ldp      x30, x21, [sp], #0x20
006AE9C84  ret      

