; LocalModels.Bean.Home_Main$$readImpl
; RVA 0x6A99930; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A99930  stp      x30, x21, [sp, #-0x20]!
006A99934  stp      x20, x19, [sp, #0x10]
006A99938  adrp     x20, #0x959e000
006A9993C  adrp     x21, #0x8f39000
006A99940  ldrb     w8, [x20, #0x1e8]
006A99944  ldr      x21, [x21, #0x4f0]
006A99948  mov      x19, x0
006A9994C  tbnz     w8, #0, #0x6a99964
006A99950  adrp     x0, #0x8f39000
006A99954  ldr      x0, [x0, #0x4f0]
006A99958  bl       #0x382bd14 ; 
006A9995C  mov      w8, #1
006A99960  strb     w8, [x20, #0x1e8]
006A99964  ldr      x1, [x21]
006A99968  ldrb     w8, [x1, #0x53]
006A9996C  tbnz     w8, #5, #0x6a999bc
006A99970  mov      x0, x19
006A99974  mov      x1, xzr
006A99978  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9997C  adrp     x21, #0x959e000
006A99980  ldrb     w8, [x21, #0x60a]
006A99984  mov      w20, w0
006A99988  cbnz     w8, #0x6a999a0
006A9998C  adrp     x0, #0x8f39000
006A99990  ldr      x0, [x0, #0x4a8]
006A99994  bl       #0x382bd14 ; 
006A99998  mov      w8, #1
006A9999C  strb     w8, [x21, #0x60a]
006A999A0  adrp     x8, #0x8f39000
006A999A4  ldr      x8, [x8, #0x4a8]
006A999A8  ldr      x2, [x8]
006A999AC  ldrb     w8, [x2, #0x53]
006A999B0  tbnz     w8, #5, #0x6a999d0
006A999B4  str      w20, [x19, #0x20]
006A999B8  b        #0x6a999e0 ; 
006A999BC  ldr      x2, [x1, #0x60]
006A999C0  mov      x0, x19
006A999C4  ldp      x20, x19, [sp, #0x10]
006A999C8  ldp      x30, x21, [sp], #0x20
006A999CC  br       x2
006A999D0  ldr      x8, [x2, #0x60]
006A999D4  mov      x0, x19
006A999D8  mov      w1, w20
006A999DC  blr      x8
006A999E0  mov      x0, x19
006A999E4  mov      x1, xzr
006A999E8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A999EC  adrp     x21, #0x959e000
006A999F0  ldrb     w8, [x21, #0x60b]
006A999F4  mov      x20, x0
006A999F8  cbnz     w8, #0x6a99a10
006A999FC  adrp     x0, #0x8f39000
006A99A00  ldr      x0, [x0, #0x4b8]
006A99A04  bl       #0x382bd14 ; 
006A99A08  mov      w8, #1
006A99A0C  strb     w8, [x21, #0x60b]
006A99A10  adrp     x8, #0x8f39000
006A99A14  ldr      x8, [x8, #0x4b8]
006A99A18  ldr      x2, [x8]
006A99A1C  ldrb     w8, [x2, #0x53]
006A99A20  tbnz     w8, #5, #0x6a99a38
006A99A24  mov      x0, x19
006A99A28  str      x20, [x0, #0x28]!
006A99A2C  mov      x1, x20
006A99A30  bl       #0x382bcb8 ; 
006A99A34  b        #0x6a99a48 ; 
006A99A38  ldr      x8, [x2, #0x60]
006A99A3C  mov      x0, x19
006A99A40  mov      x1, x20
006A99A44  blr      x8
006A99A48  mov      x0, x19
006A99A4C  mov      x1, xzr
006A99A50  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A99A54  adrp     x21, #0x959e000
006A99A58  ldrb     w8, [x21, #0x60c]
006A99A5C  mov      x20, x0
006A99A60  cbnz     w8, #0x6a99a78
006A99A64  adrp     x0, #0x8f39000
006A99A68  ldr      x0, [x0, #0x4c8]
006A99A6C  bl       #0x382bd14 ; 
006A99A70  mov      w8, #1
006A99A74  strb     w8, [x21, #0x60c]
006A99A78  adrp     x8, #0x8f39000
006A99A7C  ldr      x8, [x8, #0x4c8]
006A99A80  ldr      x2, [x8]
006A99A84  ldrb     w8, [x2, #0x53]
006A99A88  tbnz     w8, #5, #0x6a99aa0
006A99A8C  mov      x0, x19
006A99A90  str      x20, [x0, #0x30]!
006A99A94  mov      x1, x20
006A99A98  bl       #0x382bcb8 ; 
006A99A9C  b        #0x6a99ab0 ; 
006A99AA0  ldr      x8, [x2, #0x60]
006A99AA4  mov      x0, x19
006A99AA8  mov      x1, x20
006A99AAC  blr      x8
006A99AB0  mov      x0, x19
006A99AB4  mov      x1, xzr
006A99AB8  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A99ABC  adrp     x21, #0x959e000
006A99AC0  ldrb     w8, [x21, #0x60d]
006A99AC4  mov      x20, x0
006A99AC8  cbnz     w8, #0x6a99ae0
006A99ACC  adrp     x0, #0x8f39000
006A99AD0  ldr      x0, [x0, #0x4d8]
006A99AD4  bl       #0x382bd14 ; 
006A99AD8  mov      w8, #1
006A99ADC  strb     w8, [x21, #0x60d]
006A99AE0  adrp     x8, #0x8f39000
006A99AE4  ldr      x8, [x8, #0x4d8]
006A99AE8  ldr      x2, [x8]
006A99AEC  ldrb     w8, [x2, #0x53]
006A99AF0  tbnz     w8, #5, #0x6a99b08
006A99AF4  mov      x0, x19
006A99AF8  str      x20, [x0, #0x38]!
006A99AFC  mov      x1, x20
006A99B00  bl       #0x382bcb8 ; 
006A99B04  b        #0x6a99b18 ; 
006A99B08  ldr      x8, [x2, #0x60]
006A99B0C  mov      x0, x19
006A99B10  mov      x1, x20
006A99B14  blr      x8
006A99B18  mov      x0, x19
006A99B1C  mov      x1, xzr
006A99B20  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A99B24  adrp     x21, #0x959e000
006A99B28  ldrb     w8, [x21, #0x60e]
006A99B2C  mov      w20, w0
006A99B30  cbnz     w8, #0x6a99b48
006A99B34  adrp     x0, #0x8f39000
006A99B38  ldr      x0, [x0, #0x4e8]
006A99B3C  bl       #0x382bd14 ; 
006A99B40  mov      w8, #1
006A99B44  strb     w8, [x21, #0x60e]
006A99B48  adrp     x8, #0x8f39000
006A99B4C  ldr      x8, [x8, #0x4e8]
006A99B50  ldr      x2, [x8]
006A99B54  ldrb     w8, [x2, #0x53]
006A99B58  tbnz     w8, #5, #0x6a99b64
006A99B5C  str      w20, [x19, #0x40]
006A99B60  b        #0x6a99b74 ; 
006A99B64  ldr      x8, [x2, #0x60]
006A99B68  mov      x0, x19
006A99B6C  mov      w1, w20
006A99B70  blr      x8
006A99B74  ldp      x20, x19, [sp, #0x10]
006A99B78  mov      w0, #1
006A99B7C  ldp      x30, x21, [sp], #0x20
006A99B80  ret      

