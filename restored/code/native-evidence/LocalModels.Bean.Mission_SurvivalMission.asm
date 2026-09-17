; LocalModels.Bean.Mission_SurvivalMission$$readImpl
; RVA 0x6AC57C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC57C4  stp      x30, x21, [sp, #-0x20]!
006AC57C8  stp      x20, x19, [sp, #0x10]
006AC57CC  adrp     x20, #0x959e000
006AC57D0  adrp     x21, #0x8f3b000
006AC57D4  ldrb     w8, [x20, #0x9f3]
006AC57D8  ldr      x21, [x21, #0x610]
006AC57DC  mov      x19, x0
006AC57E0  tbnz     w8, #0, #0x6ac57f8
006AC57E4  adrp     x0, #0x8f3b000
006AC57E8  ldr      x0, [x0, #0x610]
006AC57EC  bl       #0x382bd14 ; 
006AC57F0  mov      w8, #1
006AC57F4  strb     w8, [x20, #0x9f3]
006AC57F8  ldr      x1, [x21]
006AC57FC  ldrb     w8, [x1, #0x53]
006AC5800  tbnz     w8, #5, #0x6ac5850
006AC5804  mov      x0, x19
006AC5808  mov      x1, xzr
006AC580C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC5810  adrp     x21, #0x959f000
006AC5814  ldrb     w8, [x21, #0x62]
006AC5818  mov      w20, w0
006AC581C  cbnz     w8, #0x6ac5834
006AC5820  adrp     x0, #0x8f3b000
006AC5824  ldr      x0, [x0, #0x570]
006AC5828  bl       #0x382bd14 ; 
006AC582C  mov      w8, #1
006AC5830  strb     w8, [x21, #0x62]
006AC5834  adrp     x8, #0x8f3b000
006AC5838  ldr      x8, [x8, #0x570]
006AC583C  ldr      x2, [x8]
006AC5840  ldrb     w8, [x2, #0x53]
006AC5844  tbnz     w8, #5, #0x6ac5864
006AC5848  str      w20, [x19, #0x20]
006AC584C  b        #0x6ac5874 ; 
006AC5850  ldr      x2, [x1, #0x60]
006AC5854  mov      x0, x19
006AC5858  ldp      x20, x19, [sp, #0x10]
006AC585C  ldp      x30, x21, [sp], #0x20
006AC5860  br       x2
006AC5864  ldr      x8, [x2, #0x60]
006AC5868  mov      x0, x19
006AC586C  mov      w1, w20
006AC5870  blr      x8
006AC5874  mov      x0, x19
006AC5878  mov      x1, xzr
006AC587C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AC5880  adrp     x21, #0x959f000
006AC5884  ldrb     w8, [x21, #0x63]
006AC5888  mov      x20, x0
006AC588C  cbnz     w8, #0x6ac58a4
006AC5890  adrp     x0, #0x8f3b000
006AC5894  ldr      x0, [x0, #0x580]
006AC5898  bl       #0x382bd14 ; 
006AC589C  mov      w8, #1
006AC58A0  strb     w8, [x21, #0x63]
006AC58A4  adrp     x8, #0x8f3b000
006AC58A8  ldr      x8, [x8, #0x580]
006AC58AC  ldr      x2, [x8]
006AC58B0  ldrb     w8, [x2, #0x53]
006AC58B4  tbnz     w8, #5, #0x6ac58cc
006AC58B8  mov      x0, x19
006AC58BC  str      x20, [x0, #0x28]!
006AC58C0  mov      x1, x20
006AC58C4  bl       #0x382bcb8 ; 
006AC58C8  b        #0x6ac58dc ; 
006AC58CC  ldr      x8, [x2, #0x60]
006AC58D0  mov      x0, x19
006AC58D4  mov      x1, x20
006AC58D8  blr      x8
006AC58DC  mov      x0, x19
006AC58E0  mov      x1, xzr
006AC58E4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AC58E8  adrp     x21, #0x959f000
006AC58EC  ldrb     w8, [x21, #0x64]
006AC58F0  mov      x20, x0
006AC58F4  cbnz     w8, #0x6ac590c
006AC58F8  adrp     x0, #0x8f3b000
006AC58FC  ldr      x0, [x0, #0x588]
006AC5900  bl       #0x382bd14 ; 
006AC5904  mov      w8, #1
006AC5908  strb     w8, [x21, #0x64]
006AC590C  adrp     x8, #0x8f3b000
006AC5910  ldr      x8, [x8, #0x588]
006AC5914  ldr      x2, [x8]
006AC5918  ldrb     w8, [x2, #0x53]
006AC591C  tbnz     w8, #5, #0x6ac5934
006AC5920  mov      x0, x19
006AC5924  str      x20, [x0, #0x30]!
006AC5928  mov      x1, x20
006AC592C  bl       #0x382bcb8 ; 
006AC5930  b        #0x6ac5944 ; 
006AC5934  ldr      x8, [x2, #0x60]
006AC5938  mov      x0, x19
006AC593C  mov      x1, x20
006AC5940  blr      x8
006AC5944  mov      x0, x19
006AC5948  mov      x1, xzr
006AC594C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC5950  adrp     x21, #0x959f000
006AC5954  ldrb     w8, [x21, #0x65]
006AC5958  mov      x20, x0
006AC595C  cbnz     w8, #0x6ac5974
006AC5960  adrp     x0, #0x8f3b000
006AC5964  ldr      x0, [x0, #0x598]
006AC5968  bl       #0x382bd14 ; 
006AC596C  mov      w8, #1
006AC5970  strb     w8, [x21, #0x65]
006AC5974  adrp     x8, #0x8f3b000
006AC5978  ldr      x8, [x8, #0x598]
006AC597C  ldr      x2, [x8]
006AC5980  ldrb     w8, [x2, #0x53]
006AC5984  tbnz     w8, #5, #0x6ac5990
006AC5988  str      x20, [x19, #0x38]
006AC598C  b        #0x6ac59a0 ; 
006AC5990  ldr      x8, [x2, #0x60]
006AC5994  mov      x0, x19
006AC5998  mov      x1, x20
006AC599C  blr      x8
006AC59A0  mov      x0, x19
006AC59A4  mov      x1, xzr
006AC59A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC59AC  adrp     x21, #0x959f000
006AC59B0  ldrb     w8, [x21, #0x66]
006AC59B4  mov      w20, w0
006AC59B8  cbnz     w8, #0x6ac59d0
006AC59BC  adrp     x0, #0x8f3b000
006AC59C0  ldr      x0, [x0, #0x5a8]
006AC59C4  bl       #0x382bd14 ; 
006AC59C8  mov      w8, #1
006AC59CC  strb     w8, [x21, #0x66]
006AC59D0  adrp     x8, #0x8f3b000
006AC59D4  ldr      x8, [x8, #0x5a8]
006AC59D8  ldr      x2, [x8]
006AC59DC  ldrb     w8, [x2, #0x53]
006AC59E0  tbnz     w8, #5, #0x6ac59ec
006AC59E4  str      w20, [x19, #0x40]
006AC59E8  b        #0x6ac59fc ; 
006AC59EC  ldr      x8, [x2, #0x60]
006AC59F0  mov      x0, x19
006AC59F4  mov      w1, w20
006AC59F8  blr      x8
006AC59FC  mov      x0, x19
006AC5A00  mov      x1, xzr
006AC5A04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC5A08  adrp     x21, #0x959f000
006AC5A0C  ldrb     w8, [x21, #0x67]
006AC5A10  mov      w20, w0
006AC5A14  cbnz     w8, #0x6ac5a2c
006AC5A18  adrp     x0, #0x8f3b000
006AC5A1C  ldr      x0, [x0, #0x5b8]
006AC5A20  bl       #0x382bd14 ; 
006AC5A24  mov      w8, #1
006AC5A28  strb     w8, [x21, #0x67]
006AC5A2C  adrp     x8, #0x8f3b000
006AC5A30  ldr      x8, [x8, #0x5b8]
006AC5A34  ldr      x2, [x8]
006AC5A38  ldrb     w8, [x2, #0x53]
006AC5A3C  tbnz     w8, #5, #0x6ac5a48
006AC5A40  str      w20, [x19, #0x44]
006AC5A44  b        #0x6ac5a58 ; 
006AC5A48  ldr      x8, [x2, #0x60]
006AC5A4C  mov      x0, x19
006AC5A50  mov      w1, w20
006AC5A54  blr      x8
006AC5A58  mov      x0, x19
006AC5A5C  mov      x1, xzr
006AC5A60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC5A64  adrp     x21, #0x959f000
006AC5A68  ldrb     w8, [x21, #0x68]
006AC5A6C  mov      w20, w0
006AC5A70  cbnz     w8, #0x6ac5a88
006AC5A74  adrp     x0, #0x8f3b000
006AC5A78  ldr      x0, [x0, #0x5c8]
006AC5A7C  bl       #0x382bd14 ; 
006AC5A80  mov      w8, #1
006AC5A84  strb     w8, [x21, #0x68]
006AC5A88  adrp     x8, #0x8f3b000
006AC5A8C  ldr      x8, [x8, #0x5c8]
006AC5A90  ldr      x2, [x8]
006AC5A94  ldrb     w8, [x2, #0x53]
006AC5A98  tbnz     w8, #5, #0x6ac5aa4
006AC5A9C  str      w20, [x19, #0x48]
006AC5AA0  b        #0x6ac5ab4 ; 
006AC5AA4  ldr      x8, [x2, #0x60]
006AC5AA8  mov      x0, x19
006AC5AAC  mov      w1, w20
006AC5AB0  blr      x8
006AC5AB4  mov      x0, x19
006AC5AB8  mov      x1, xzr
006AC5ABC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC5AC0  adrp     x21, #0x959f000
006AC5AC4  ldrb     w8, [x21, #0x69]
006AC5AC8  mov      w20, w0
006AC5ACC  cbnz     w8, #0x6ac5ae4
006AC5AD0  adrp     x0, #0x8f3b000
006AC5AD4  ldr      x0, [x0, #0x5d8]
006AC5AD8  bl       #0x382bd14 ; 
006AC5ADC  mov      w8, #1
006AC5AE0  strb     w8, [x21, #0x69]
006AC5AE4  adrp     x8, #0x8f3b000
006AC5AE8  ldr      x8, [x8, #0x5d8]
006AC5AEC  ldr      x2, [x8]
006AC5AF0  ldrb     w8, [x2, #0x53]
006AC5AF4  tbnz     w8, #5, #0x6ac5b00
006AC5AF8  str      w20, [x19, #0x4c]
006AC5AFC  b        #0x6ac5b10 ; 
006AC5B00  ldr      x8, [x2, #0x60]
006AC5B04  mov      x0, x19
006AC5B08  mov      w1, w20
006AC5B0C  blr      x8
006AC5B10  mov      x0, x19
006AC5B14  mov      x1, xzr
006AC5B18  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC5B1C  adrp     x21, #0x959f000
006AC5B20  ldrb     w8, [x21, #0x6a]
006AC5B24  mov      x20, x0
006AC5B28  cbnz     w8, #0x6ac5b40
006AC5B2C  adrp     x0, #0x8f3b000
006AC5B30  ldr      x0, [x0, #0x5e8]
006AC5B34  bl       #0x382bd14 ; 
006AC5B38  mov      w8, #1
006AC5B3C  strb     w8, [x21, #0x6a]
006AC5B40  adrp     x8, #0x8f3b000
006AC5B44  ldr      x8, [x8, #0x5e8]
006AC5B48  ldr      x2, [x8]
006AC5B4C  ldrb     w8, [x2, #0x53]
006AC5B50  tbnz     w8, #5, #0x6ac5b5c
006AC5B54  str      x20, [x19, #0x50]
006AC5B58  b        #0x6ac5b6c ; 
006AC5B5C  ldr      x8, [x2, #0x60]
006AC5B60  mov      x0, x19
006AC5B64  mov      x1, x20
006AC5B68  blr      x8
006AC5B6C  mov      x0, x19
006AC5B70  mov      x1, xzr
006AC5B74  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC5B78  adrp     x21, #0x959f000
006AC5B7C  ldrb     w8, [x21, #0x6b]
006AC5B80  mov      x20, x0
006AC5B84  cbnz     w8, #0x6ac5b9c
006AC5B88  adrp     x0, #0x8f3b000
006AC5B8C  ldr      x0, [x0, #0x5f8]
006AC5B90  bl       #0x382bd14 ; 
006AC5B94  mov      w8, #1
006AC5B98  strb     w8, [x21, #0x6b]
006AC5B9C  adrp     x8, #0x8f3b000
006AC5BA0  ldr      x8, [x8, #0x5f8]
006AC5BA4  ldr      x2, [x8]
006AC5BA8  ldrb     w8, [x2, #0x53]
006AC5BAC  tbnz     w8, #5, #0x6ac5bb8
006AC5BB0  str      x20, [x19, #0x58]
006AC5BB4  b        #0x6ac5bc8 ; 
006AC5BB8  ldr      x8, [x2, #0x60]
006AC5BBC  mov      x0, x19
006AC5BC0  mov      x1, x20
006AC5BC4  blr      x8
006AC5BC8  mov      x0, x19
006AC5BCC  mov      x1, xzr
006AC5BD0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AC5BD4  adrp     x21, #0x959f000
006AC5BD8  ldrb     w8, [x21, #0x6c]
006AC5BDC  mov      x20, x0
006AC5BE0  cbnz     w8, #0x6ac5bf8
006AC5BE4  adrp     x0, #0x8f3b000
006AC5BE8  ldr      x0, [x0, #0x608]
006AC5BEC  bl       #0x382bd14 ; 
006AC5BF0  mov      w8, #1
006AC5BF4  strb     w8, [x21, #0x6c]
006AC5BF8  adrp     x8, #0x8f3b000
006AC5BFC  ldr      x8, [x8, #0x608]
006AC5C00  ldr      x2, [x8]
006AC5C04  ldrb     w8, [x2, #0x53]
006AC5C08  tbnz     w8, #5, #0x6ac5c20
006AC5C0C  str      x20, [x19, #0x60]!
006AC5C10  mov      x0, x19
006AC5C14  mov      x1, x20
006AC5C18  bl       #0x382bcb8 ; 
006AC5C1C  b        #0x6ac5c30 ; 
006AC5C20  ldr      x8, [x2, #0x60]
006AC5C24  mov      x0, x19
006AC5C28  mov      x1, x20
006AC5C2C  blr      x8
006AC5C30  ldp      x20, x19, [sp, #0x10]
006AC5C34  mov      w0, #1
006AC5C38  ldp      x30, x21, [sp], #0x20
006AC5C3C  ret      

