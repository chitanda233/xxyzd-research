; LocalModels.Bean.Relic_group$$readImpl
; RVA 0x6AD893C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD893C  stp      x30, x21, [sp, #-0x20]!
006AD8940  stp      x20, x19, [sp, #0x10]
006AD8944  adrp     x20, #0x959e000
006AD8948  adrp     x21, #0x8f3c000
006AD894C  ldrb     w8, [x20, #0xbec]
006AD8950  ldr      x21, [x21, #0x440]
006AD8954  mov      x19, x0
006AD8958  tbnz     w8, #0, #0x6ad8970
006AD895C  adrp     x0, #0x8f3c000
006AD8960  ldr      x0, [x0, #0x440]
006AD8964  bl       #0x382bd14 ; 
006AD8968  mov      w8, #1
006AD896C  strb     w8, [x20, #0xbec]
006AD8970  ldr      x1, [x21]
006AD8974  ldrb     w8, [x1, #0x53]
006AD8978  tbnz     w8, #5, #0x6ad89c8
006AD897C  mov      x0, x19
006AD8980  mov      x1, xzr
006AD8984  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD8988  adrp     x21, #0x959f000
006AD898C  ldrb     w8, [x21, #0x138]
006AD8990  mov      w20, w0
006AD8994  cbnz     w8, #0x6ad89ac
006AD8998  adrp     x0, #0x8f3c000
006AD899C  ldr      x0, [x0, #0x3e8]
006AD89A0  bl       #0x382bd14 ; 
006AD89A4  mov      w8, #1
006AD89A8  strb     w8, [x21, #0x138]
006AD89AC  adrp     x8, #0x8f3c000
006AD89B0  ldr      x8, [x8, #0x3e8]
006AD89B4  ldr      x2, [x8]
006AD89B8  ldrb     w8, [x2, #0x53]
006AD89BC  tbnz     w8, #5, #0x6ad89dc
006AD89C0  str      w20, [x19, #0x20]
006AD89C4  b        #0x6ad89ec ; 
006AD89C8  ldr      x2, [x1, #0x60]
006AD89CC  mov      x0, x19
006AD89D0  ldp      x20, x19, [sp, #0x10]
006AD89D4  ldp      x30, x21, [sp], #0x20
006AD89D8  br       x2
006AD89DC  ldr      x8, [x2, #0x60]
006AD89E0  mov      x0, x19
006AD89E4  mov      w1, w20
006AD89E8  blr      x8
006AD89EC  mov      x0, x19
006AD89F0  mov      x1, xzr
006AD89F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD89F8  adrp     x21, #0x959f000
006AD89FC  ldrb     w8, [x21, #0x139]
006AD8A00  mov      w20, w0
006AD8A04  cbnz     w8, #0x6ad8a1c
006AD8A08  adrp     x0, #0x8f3c000
006AD8A0C  ldr      x0, [x0, #0x3f8]
006AD8A10  bl       #0x382bd14 ; 
006AD8A14  mov      w8, #1
006AD8A18  strb     w8, [x21, #0x139]
006AD8A1C  adrp     x8, #0x8f3c000
006AD8A20  ldr      x8, [x8, #0x3f8]
006AD8A24  ldr      x2, [x8]
006AD8A28  ldrb     w8, [x2, #0x53]
006AD8A2C  tbnz     w8, #5, #0x6ad8a38
006AD8A30  str      w20, [x19, #0x24]
006AD8A34  b        #0x6ad8a48 ; 
006AD8A38  ldr      x8, [x2, #0x60]
006AD8A3C  mov      x0, x19
006AD8A40  mov      w1, w20
006AD8A44  blr      x8
006AD8A48  mov      x0, x19
006AD8A4C  mov      x1, xzr
006AD8A50  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD8A54  adrp     x21, #0x959f000
006AD8A58  ldrb     w8, [x21, #0x13a]
006AD8A5C  mov      w20, w0
006AD8A60  cbnz     w8, #0x6ad8a78
006AD8A64  adrp     x0, #0x8f3c000
006AD8A68  ldr      x0, [x0, #0x408]
006AD8A6C  bl       #0x382bd14 ; 
006AD8A70  mov      w8, #1
006AD8A74  strb     w8, [x21, #0x13a]
006AD8A78  adrp     x8, #0x8f3c000
006AD8A7C  ldr      x8, [x8, #0x408]
006AD8A80  ldr      x2, [x8]
006AD8A84  ldrb     w8, [x2, #0x53]
006AD8A88  tbnz     w8, #5, #0x6ad8a94
006AD8A8C  str      w20, [x19, #0x28]
006AD8A90  b        #0x6ad8aa4 ; 
006AD8A94  ldr      x8, [x2, #0x60]
006AD8A98  mov      x0, x19
006AD8A9C  mov      w1, w20
006AD8AA0  blr      x8
006AD8AA4  mov      x0, x19
006AD8AA8  mov      x1, xzr
006AD8AAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD8AB0  adrp     x21, #0x959f000
006AD8AB4  ldrb     w8, [x21, #0x13b]
006AD8AB8  mov      w20, w0
006AD8ABC  cbnz     w8, #0x6ad8ad4
006AD8AC0  adrp     x0, #0x8f3c000
006AD8AC4  ldr      x0, [x0, #0x418]
006AD8AC8  bl       #0x382bd14 ; 
006AD8ACC  mov      w8, #1
006AD8AD0  strb     w8, [x21, #0x13b]
006AD8AD4  adrp     x8, #0x8f3c000
006AD8AD8  ldr      x8, [x8, #0x418]
006AD8ADC  ldr      x2, [x8]
006AD8AE0  ldrb     w8, [x2, #0x53]
006AD8AE4  tbnz     w8, #5, #0x6ad8af0
006AD8AE8  str      w20, [x19, #0x2c]
006AD8AEC  b        #0x6ad8b00 ; 
006AD8AF0  ldr      x8, [x2, #0x60]
006AD8AF4  mov      x0, x19
006AD8AF8  mov      w1, w20
006AD8AFC  blr      x8
006AD8B00  mov      x0, x19
006AD8B04  mov      x1, xzr
006AD8B08  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AD8B0C  adrp     x21, #0x959f000
006AD8B10  ldrb     w8, [x21, #0x13c]
006AD8B14  mov      x20, x0
006AD8B18  cbnz     w8, #0x6ad8b30
006AD8B1C  adrp     x0, #0x8f3c000
006AD8B20  ldr      x0, [x0, #0x428]
006AD8B24  bl       #0x382bd14 ; 
006AD8B28  mov      w8, #1
006AD8B2C  strb     w8, [x21, #0x13c]
006AD8B30  adrp     x8, #0x8f3c000
006AD8B34  ldr      x8, [x8, #0x428]
006AD8B38  ldr      x2, [x8]
006AD8B3C  ldrb     w8, [x2, #0x53]
006AD8B40  tbnz     w8, #5, #0x6ad8b58
006AD8B44  mov      x0, x19
006AD8B48  str      x20, [x0, #0x30]!
006AD8B4C  mov      x1, x20
006AD8B50  bl       #0x382bcb8 ; 
006AD8B54  b        #0x6ad8b68 ; 
006AD8B58  ldr      x8, [x2, #0x60]
006AD8B5C  mov      x0, x19
006AD8B60  mov      x1, x20
006AD8B64  blr      x8
006AD8B68  mov      x0, x19
006AD8B6C  mov      x1, xzr
006AD8B70  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AD8B74  adrp     x21, #0x959f000
006AD8B78  ldrb     w8, [x21, #0x13d]
006AD8B7C  mov      x20, x0
006AD8B80  cbnz     w8, #0x6ad8b98
006AD8B84  adrp     x0, #0x8f3c000
006AD8B88  ldr      x0, [x0, #0x438]
006AD8B8C  bl       #0x382bd14 ; 
006AD8B90  mov      w8, #1
006AD8B94  strb     w8, [x21, #0x13d]
006AD8B98  adrp     x8, #0x8f3c000
006AD8B9C  ldr      x8, [x8, #0x438]
006AD8BA0  ldr      x2, [x8]
006AD8BA4  ldrb     w8, [x2, #0x53]
006AD8BA8  tbnz     w8, #5, #0x6ad8bc0
006AD8BAC  str      x20, [x19, #0x38]!
006AD8BB0  mov      x0, x19
006AD8BB4  mov      x1, x20
006AD8BB8  bl       #0x382bcb8 ; 
006AD8BBC  b        #0x6ad8bd0 ; 
006AD8BC0  ldr      x8, [x2, #0x60]
006AD8BC4  mov      x0, x19
006AD8BC8  mov      x1, x20
006AD8BCC  blr      x8
006AD8BD0  ldp      x20, x19, [sp, #0x10]
006AD8BD4  mov      w0, #1
006AD8BD8  ldp      x30, x21, [sp], #0x20
006AD8BDC  ret      

