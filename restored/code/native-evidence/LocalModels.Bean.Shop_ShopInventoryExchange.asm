; LocalModels.Bean.Shop_ShopInventoryExchange$$readImpl
; RVA 0x6AF296C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF296C  stp      x30, x21, [sp, #-0x20]!
006AF2970  stp      x20, x19, [sp, #0x10]
006AF2974  adrp     x20, #0x959e000
006AF2978  adrp     x21, #0x8f3d000
006AF297C  ldrb     w8, [x20, #0xe99]
006AF2980  ldr      x21, [x21, #0x7c8]
006AF2984  mov      x19, x0
006AF2988  tbnz     w8, #0, #0x6af29a0
006AF298C  adrp     x0, #0x8f3d000
006AF2990  ldr      x0, [x0, #0x7c8]
006AF2994  bl       #0x382bd14 ; 
006AF2998  mov      w8, #1
006AF299C  strb     w8, [x20, #0xe99]
006AF29A0  ldr      x1, [x21]
006AF29A4  ldrb     w8, [x1, #0x53]
006AF29A8  tbnz     w8, #5, #0x6af29f8
006AF29AC  mov      x0, x19
006AF29B0  mov      x1, xzr
006AF29B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF29B8  adrp     x21, #0x959f000
006AF29BC  ldrb     w8, [x21, #0x25c]
006AF29C0  mov      w20, w0
006AF29C4  cbnz     w8, #0x6af29dc
006AF29C8  adrp     x0, #0x8f3d000
006AF29CC  ldr      x0, [x0, #0x790]
006AF29D0  bl       #0x382bd14 ; 
006AF29D4  mov      w8, #1
006AF29D8  strb     w8, [x21, #0x25c]
006AF29DC  adrp     x8, #0x8f3d000
006AF29E0  ldr      x8, [x8, #0x790]
006AF29E4  ldr      x2, [x8]
006AF29E8  ldrb     w8, [x2, #0x53]
006AF29EC  tbnz     w8, #5, #0x6af2a0c
006AF29F0  str      w20, [x19, #0x20]
006AF29F4  b        #0x6af2a1c ; 
006AF29F8  ldr      x2, [x1, #0x60]
006AF29FC  mov      x0, x19
006AF2A00  ldp      x20, x19, [sp, #0x10]
006AF2A04  ldp      x30, x21, [sp], #0x20
006AF2A08  br       x2
006AF2A0C  ldr      x8, [x2, #0x60]
006AF2A10  mov      x0, x19
006AF2A14  mov      w1, w20
006AF2A18  blr      x8
006AF2A1C  mov      x0, x19
006AF2A20  mov      x1, xzr
006AF2A24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF2A28  adrp     x21, #0x959f000
006AF2A2C  ldrb     w8, [x21, #0x25d]
006AF2A30  mov      w20, w0
006AF2A34  cbnz     w8, #0x6af2a4c
006AF2A38  adrp     x0, #0x8f3d000
006AF2A3C  ldr      x0, [x0, #0x7a0]
006AF2A40  bl       #0x382bd14 ; 
006AF2A44  mov      w8, #1
006AF2A48  strb     w8, [x21, #0x25d]
006AF2A4C  adrp     x8, #0x8f3d000
006AF2A50  ldr      x8, [x8, #0x7a0]
006AF2A54  ldr      x2, [x8]
006AF2A58  ldrb     w8, [x2, #0x53]
006AF2A5C  tbnz     w8, #5, #0x6af2a68
006AF2A60  str      w20, [x19, #0x24]
006AF2A64  b        #0x6af2a78 ; 
006AF2A68  ldr      x8, [x2, #0x60]
006AF2A6C  mov      x0, x19
006AF2A70  mov      w1, w20
006AF2A74  blr      x8
006AF2A78  mov      x0, x19
006AF2A7C  mov      x1, xzr
006AF2A80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF2A84  adrp     x21, #0x959f000
006AF2A88  ldrb     w8, [x21, #0x25e]
006AF2A8C  mov      w20, w0
006AF2A90  cbnz     w8, #0x6af2aa8
006AF2A94  adrp     x0, #0x8f3d000
006AF2A98  ldr      x0, [x0, #0x7b0]
006AF2A9C  bl       #0x382bd14 ; 
006AF2AA0  mov      w8, #1
006AF2AA4  strb     w8, [x21, #0x25e]
006AF2AA8  adrp     x8, #0x8f3d000
006AF2AAC  ldr      x8, [x8, #0x7b0]
006AF2AB0  ldr      x2, [x8]
006AF2AB4  ldrb     w8, [x2, #0x53]
006AF2AB8  tbnz     w8, #5, #0x6af2ac4
006AF2ABC  str      w20, [x19, #0x28]
006AF2AC0  b        #0x6af2ad4 ; 
006AF2AC4  ldr      x8, [x2, #0x60]
006AF2AC8  mov      x0, x19
006AF2ACC  mov      w1, w20
006AF2AD0  blr      x8
006AF2AD4  mov      x0, x19
006AF2AD8  mov      x1, xzr
006AF2ADC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF2AE0  adrp     x21, #0x959f000
006AF2AE4  ldrb     w8, [x21, #0x25f]
006AF2AE8  mov      w20, w0
006AF2AEC  cbnz     w8, #0x6af2b04
006AF2AF0  adrp     x0, #0x8f3d000
006AF2AF4  ldr      x0, [x0, #0x7c0]
006AF2AF8  bl       #0x382bd14 ; 
006AF2AFC  mov      w8, #1
006AF2B00  strb     w8, [x21, #0x25f]
006AF2B04  adrp     x8, #0x8f3d000
006AF2B08  ldr      x8, [x8, #0x7c0]
006AF2B0C  ldr      x2, [x8]
006AF2B10  ldrb     w8, [x2, #0x53]
006AF2B14  tbnz     w8, #5, #0x6af2b20
006AF2B18  str      w20, [x19, #0x2c]
006AF2B1C  b        #0x6af2b30 ; 
006AF2B20  ldr      x8, [x2, #0x60]
006AF2B24  mov      x0, x19
006AF2B28  mov      w1, w20
006AF2B2C  blr      x8
006AF2B30  ldp      x20, x19, [sp, #0x10]
006AF2B34  mov      w0, #1
006AF2B38  ldp      x30, x21, [sp], #0x20
006AF2B3C  ret      

