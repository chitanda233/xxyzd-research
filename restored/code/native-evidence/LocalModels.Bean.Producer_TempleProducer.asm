; LocalModels.Bean.Producer_TempleProducer$$readImpl
; RVA 0x6AD4900; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD4900  stp      x30, x21, [sp, #-0x20]!
006AD4904  stp      x20, x19, [sp, #0x10]
006AD4908  adrp     x20, #0x959e000
006AD490C  adrp     x21, #0x8f3c000
006AD4910  ldrb     w8, [x20, #0xb80]
006AD4914  ldr      x21, [x21, #0x120]
006AD4918  mov      x19, x0
006AD491C  tbnz     w8, #0, #0x6ad4934
006AD4920  adrp     x0, #0x8f3c000
006AD4924  ldr      x0, [x0, #0x120]
006AD4928  bl       #0x382bd14 ; 
006AD492C  mov      w8, #1
006AD4930  strb     w8, [x20, #0xb80]
006AD4934  ldr      x1, [x21]
006AD4938  ldrb     w8, [x1, #0x53]
006AD493C  tbnz     w8, #5, #0x6ad498c
006AD4940  mov      x0, x19
006AD4944  mov      x1, xzr
006AD4948  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD494C  adrp     x21, #0x959f000
006AD4950  ldrb     w8, [x21, #0x10f]
006AD4954  mov      w20, w0
006AD4958  cbnz     w8, #0x6ad4970
006AD495C  adrp     x0, #0x8f3c000
006AD4960  ldr      x0, [x0, #0xd8]
006AD4964  bl       #0x382bd14 ; 
006AD4968  mov      w8, #1
006AD496C  strb     w8, [x21, #0x10f]
006AD4970  adrp     x8, #0x8f3c000
006AD4974  ldr      x8, [x8, #0xd8]
006AD4978  ldr      x2, [x8]
006AD497C  ldrb     w8, [x2, #0x53]
006AD4980  tbnz     w8, #5, #0x6ad49a0
006AD4984  str      w20, [x19, #0x20]
006AD4988  b        #0x6ad49b0 ; 
006AD498C  ldr      x2, [x1, #0x60]
006AD4990  mov      x0, x19
006AD4994  ldp      x20, x19, [sp, #0x10]
006AD4998  ldp      x30, x21, [sp], #0x20
006AD499C  br       x2
006AD49A0  ldr      x8, [x2, #0x60]
006AD49A4  mov      x0, x19
006AD49A8  mov      w1, w20
006AD49AC  blr      x8
006AD49B0  mov      x0, x19
006AD49B4  mov      x1, xzr
006AD49B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD49BC  adrp     x21, #0x959f000
006AD49C0  ldrb     w8, [x21, #0x110]
006AD49C4  mov      w20, w0
006AD49C8  cbnz     w8, #0x6ad49e0
006AD49CC  adrp     x0, #0x8f3c000
006AD49D0  ldr      x0, [x0, #0xe8]
006AD49D4  bl       #0x382bd14 ; 
006AD49D8  mov      w8, #1
006AD49DC  strb     w8, [x21, #0x110]
006AD49E0  adrp     x8, #0x8f3c000
006AD49E4  ldr      x8, [x8, #0xe8]
006AD49E8  ldr      x2, [x8]
006AD49EC  ldrb     w8, [x2, #0x53]
006AD49F0  tbnz     w8, #5, #0x6ad49fc
006AD49F4  str      w20, [x19, #0x24]
006AD49F8  b        #0x6ad4a0c ; 
006AD49FC  ldr      x8, [x2, #0x60]
006AD4A00  mov      x0, x19
006AD4A04  mov      w1, w20
006AD4A08  blr      x8
006AD4A0C  mov      x0, x19
006AD4A10  mov      x1, xzr
006AD4A14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD4A18  adrp     x21, #0x959f000
006AD4A1C  ldrb     w8, [x21, #0x111]
006AD4A20  mov      w20, w0
006AD4A24  cbnz     w8, #0x6ad4a3c
006AD4A28  adrp     x0, #0x8f3c000
006AD4A2C  ldr      x0, [x0, #0xf8]
006AD4A30  bl       #0x382bd14 ; 
006AD4A34  mov      w8, #1
006AD4A38  strb     w8, [x21, #0x111]
006AD4A3C  adrp     x8, #0x8f3c000
006AD4A40  ldr      x8, [x8, #0xf8]
006AD4A44  ldr      x2, [x8]
006AD4A48  ldrb     w8, [x2, #0x53]
006AD4A4C  tbnz     w8, #5, #0x6ad4a58
006AD4A50  str      w20, [x19, #0x28]
006AD4A54  b        #0x6ad4a68 ; 
006AD4A58  ldr      x8, [x2, #0x60]
006AD4A5C  mov      x0, x19
006AD4A60  mov      w1, w20
006AD4A64  blr      x8
006AD4A68  mov      x0, x19
006AD4A6C  mov      x1, xzr
006AD4A70  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AD4A74  adrp     x21, #0x959f000
006AD4A78  ldrb     w8, [x21, #0x112]
006AD4A7C  mov      x20, x0
006AD4A80  cbnz     w8, #0x6ad4a98
006AD4A84  adrp     x0, #0x8f3c000
006AD4A88  ldr      x0, [x0, #0x108]
006AD4A8C  bl       #0x382bd14 ; 
006AD4A90  mov      w8, #1
006AD4A94  strb     w8, [x21, #0x112]
006AD4A98  adrp     x8, #0x8f3c000
006AD4A9C  ldr      x8, [x8, #0x108]
006AD4AA0  ldr      x2, [x8]
006AD4AA4  ldrb     w8, [x2, #0x53]
006AD4AA8  tbnz     w8, #5, #0x6ad4ac0
006AD4AAC  mov      x0, x19
006AD4AB0  str      x20, [x0, #0x30]!
006AD4AB4  mov      x1, x20
006AD4AB8  bl       #0x382bcb8 ; 
006AD4ABC  b        #0x6ad4ad0 ; 
006AD4AC0  ldr      x8, [x2, #0x60]
006AD4AC4  mov      x0, x19
006AD4AC8  mov      x1, x20
006AD4ACC  blr      x8
006AD4AD0  mov      x0, x19
006AD4AD4  mov      x1, xzr
006AD4AD8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AD4ADC  adrp     x21, #0x959f000
006AD4AE0  ldrb     w8, [x21, #0x113]
006AD4AE4  mov      x20, x0
006AD4AE8  cbnz     w8, #0x6ad4b00
006AD4AEC  adrp     x0, #0x8f3c000
006AD4AF0  ldr      x0, [x0, #0x118]
006AD4AF4  bl       #0x382bd14 ; 
006AD4AF8  mov      w8, #1
006AD4AFC  strb     w8, [x21, #0x113]
006AD4B00  adrp     x8, #0x8f3c000
006AD4B04  ldr      x8, [x8, #0x118]
006AD4B08  ldr      x2, [x8]
006AD4B0C  ldrb     w8, [x2, #0x53]
006AD4B10  tbnz     w8, #5, #0x6ad4b28
006AD4B14  str      x20, [x19, #0x38]!
006AD4B18  mov      x0, x19
006AD4B1C  mov      x1, x20
006AD4B20  bl       #0x382bcb8 ; 
006AD4B24  b        #0x6ad4b38 ; 
006AD4B28  ldr      x8, [x2, #0x60]
006AD4B2C  mov      x0, x19
006AD4B30  mov      x1, x20
006AD4B34  blr      x8
006AD4B38  ldp      x20, x19, [sp, #0x10]
006AD4B3C  mov      w0, #1
006AD4B40  ldp      x30, x21, [sp], #0x20
006AD4B44  ret      

