; LocalModels.Bean.Mission_RoomMission$$readImpl
; RVA 0x6AC4858; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC4858  stp      x30, x21, [sp, #-0x20]!
006AC485C  stp      x20, x19, [sp, #0x10]
006AC4860  adrp     x20, #0x959e000
006AC4864  adrp     x21, #0x8f3b000
006AC4868  ldrb     w8, [x20, #0x9da]
006AC486C  ldr      x21, [x21, #0x558]
006AC4870  mov      x19, x0
006AC4874  tbnz     w8, #0, #0x6ac488c
006AC4878  adrp     x0, #0x8f3b000
006AC487C  ldr      x0, [x0, #0x558]
006AC4880  bl       #0x382bd14 ; 
006AC4884  mov      w8, #1
006AC4888  strb     w8, [x20, #0x9da]
006AC488C  ldr      x1, [x21]
006AC4890  ldrb     w8, [x1, #0x53]
006AC4894  tbnz     w8, #5, #0x6ac48e4
006AC4898  mov      x0, x19
006AC489C  mov      x1, xzr
006AC48A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC48A4  adrp     x21, #0x959f000
006AC48A8  ldrb     w8, [x21, #0x56]
006AC48AC  mov      w20, w0
006AC48B0  cbnz     w8, #0x6ac48c8
006AC48B4  adrp     x0, #0x8f3b000
006AC48B8  ldr      x0, [x0, #0x4a0]
006AC48BC  bl       #0x382bd14 ; 
006AC48C0  mov      w8, #1
006AC48C4  strb     w8, [x21, #0x56]
006AC48C8  adrp     x8, #0x8f3b000
006AC48CC  ldr      x8, [x8, #0x4a0]
006AC48D0  ldr      x2, [x8]
006AC48D4  ldrb     w8, [x2, #0x53]
006AC48D8  tbnz     w8, #5, #0x6ac48f8
006AC48DC  str      w20, [x19, #0x20]
006AC48E0  b        #0x6ac4908 ; 
006AC48E4  ldr      x2, [x1, #0x60]
006AC48E8  mov      x0, x19
006AC48EC  ldp      x20, x19, [sp, #0x10]
006AC48F0  ldp      x30, x21, [sp], #0x20
006AC48F4  br       x2
006AC48F8  ldr      x8, [x2, #0x60]
006AC48FC  mov      x0, x19
006AC4900  mov      w1, w20
006AC4904  blr      x8
006AC4908  mov      x0, x19
006AC490C  mov      x1, xzr
006AC4910  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC4914  adrp     x21, #0x959f000
006AC4918  ldrb     w8, [x21, #0x57]
006AC491C  mov      w20, w0
006AC4920  cbnz     w8, #0x6ac4938
006AC4924  adrp     x0, #0x8f3b000
006AC4928  ldr      x0, [x0, #0x4b0]
006AC492C  bl       #0x382bd14 ; 
006AC4930  mov      w8, #1
006AC4934  strb     w8, [x21, #0x57]
006AC4938  adrp     x8, #0x8f3b000
006AC493C  ldr      x8, [x8, #0x4b0]
006AC4940  ldr      x2, [x8]
006AC4944  ldrb     w8, [x2, #0x53]
006AC4948  tbnz     w8, #5, #0x6ac4954
006AC494C  str      w20, [x19, #0x24]
006AC4950  b        #0x6ac4964 ; 
006AC4954  ldr      x8, [x2, #0x60]
006AC4958  mov      x0, x19
006AC495C  mov      w1, w20
006AC4960  blr      x8
006AC4964  mov      x0, x19
006AC4968  mov      x1, xzr
006AC496C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC4970  adrp     x21, #0x959f000
006AC4974  ldrb     w8, [x21, #0x58]
006AC4978  mov      w20, w0
006AC497C  cbnz     w8, #0x6ac4994
006AC4980  adrp     x0, #0x8f3b000
006AC4984  ldr      x0, [x0, #0x4c0]
006AC4988  bl       #0x382bd14 ; 
006AC498C  mov      w8, #1
006AC4990  strb     w8, [x21, #0x58]
006AC4994  adrp     x8, #0x8f3b000
006AC4998  ldr      x8, [x8, #0x4c0]
006AC499C  ldr      x2, [x8]
006AC49A0  ldrb     w8, [x2, #0x53]
006AC49A4  tbnz     w8, #5, #0x6ac49b0
006AC49A8  str      w20, [x19, #0x28]
006AC49AC  b        #0x6ac49c0 ; 
006AC49B0  ldr      x8, [x2, #0x60]
006AC49B4  mov      x0, x19
006AC49B8  mov      w1, w20
006AC49BC  blr      x8
006AC49C0  mov      x0, x19
006AC49C4  mov      x1, xzr
006AC49C8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AC49CC  adrp     x21, #0x959f000
006AC49D0  ldrb     w8, [x21, #0x59]
006AC49D4  mov      x20, x0
006AC49D8  cbnz     w8, #0x6ac49f0
006AC49DC  adrp     x0, #0x8f3b000
006AC49E0  ldr      x0, [x0, #0x4d0]
006AC49E4  bl       #0x382bd14 ; 
006AC49E8  mov      w8, #1
006AC49EC  strb     w8, [x21, #0x59]
006AC49F0  adrp     x8, #0x8f3b000
006AC49F4  ldr      x8, [x8, #0x4d0]
006AC49F8  ldr      x2, [x8]
006AC49FC  ldrb     w8, [x2, #0x53]
006AC4A00  tbnz     w8, #5, #0x6ac4a18
006AC4A04  mov      x0, x19
006AC4A08  str      x20, [x0, #0x30]!
006AC4A0C  mov      x1, x20
006AC4A10  bl       #0x382bcb8 ; 
006AC4A14  b        #0x6ac4a28 ; 
006AC4A18  ldr      x8, [x2, #0x60]
006AC4A1C  mov      x0, x19
006AC4A20  mov      x1, x20
006AC4A24  blr      x8
006AC4A28  mov      x0, x19
006AC4A2C  mov      x1, xzr
006AC4A30  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AC4A34  adrp     x21, #0x959f000
006AC4A38  ldrb     w8, [x21, #0x5a]
006AC4A3C  mov      x20, x0
006AC4A40  cbnz     w8, #0x6ac4a58
006AC4A44  adrp     x0, #0x8f3b000
006AC4A48  ldr      x0, [x0, #0x4e0]
006AC4A4C  bl       #0x382bd14 ; 
006AC4A50  mov      w8, #1
006AC4A54  strb     w8, [x21, #0x5a]
006AC4A58  adrp     x8, #0x8f3b000
006AC4A5C  ldr      x8, [x8, #0x4e0]
006AC4A60  ldr      x2, [x8]
006AC4A64  ldrb     w8, [x2, #0x53]
006AC4A68  tbnz     w8, #5, #0x6ac4a80
006AC4A6C  mov      x0, x19
006AC4A70  str      x20, [x0, #0x38]!
006AC4A74  mov      x1, x20
006AC4A78  bl       #0x382bcb8 ; 
006AC4A7C  b        #0x6ac4a90 ; 
006AC4A80  ldr      x8, [x2, #0x60]
006AC4A84  mov      x0, x19
006AC4A88  mov      x1, x20
006AC4A8C  blr      x8
006AC4A90  mov      x0, x19
006AC4A94  mov      x1, xzr
006AC4A98  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC4A9C  adrp     x21, #0x959f000
006AC4AA0  ldrb     w8, [x21, #0x5b]
006AC4AA4  mov      w20, w0
006AC4AA8  cbnz     w8, #0x6ac4ac0
006AC4AAC  adrp     x0, #0x8f3b000
006AC4AB0  ldr      x0, [x0, #0x4f0]
006AC4AB4  bl       #0x382bd14 ; 
006AC4AB8  mov      w8, #1
006AC4ABC  strb     w8, [x21, #0x5b]
006AC4AC0  adrp     x8, #0x8f3b000
006AC4AC4  ldr      x8, [x8, #0x4f0]
006AC4AC8  ldr      x2, [x8]
006AC4ACC  ldrb     w8, [x2, #0x53]
006AC4AD0  tbnz     w8, #5, #0x6ac4adc
006AC4AD4  str      w20, [x19, #0x40]
006AC4AD8  b        #0x6ac4aec ; 
006AC4ADC  ldr      x8, [x2, #0x60]
006AC4AE0  mov      x0, x19
006AC4AE4  mov      w1, w20
006AC4AE8  blr      x8
006AC4AEC  mov      x0, x19
006AC4AF0  mov      x1, xzr
006AC4AF4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC4AF8  adrp     x21, #0x959f000
006AC4AFC  ldrb     w8, [x21, #0x5c]
006AC4B00  mov      w20, w0
006AC4B04  cbnz     w8, #0x6ac4b1c
006AC4B08  adrp     x0, #0x8f3b000
006AC4B0C  ldr      x0, [x0, #0x500]
006AC4B10  bl       #0x382bd14 ; 
006AC4B14  mov      w8, #1
006AC4B18  strb     w8, [x21, #0x5c]
006AC4B1C  adrp     x8, #0x8f3b000
006AC4B20  ldr      x8, [x8, #0x500]
006AC4B24  ldr      x2, [x8]
006AC4B28  ldrb     w8, [x2, #0x53]
006AC4B2C  tbnz     w8, #5, #0x6ac4b38
006AC4B30  str      w20, [x19, #0x44]
006AC4B34  b        #0x6ac4b48 ; 
006AC4B38  ldr      x8, [x2, #0x60]
006AC4B3C  mov      x0, x19
006AC4B40  mov      w1, w20
006AC4B44  blr      x8
006AC4B48  mov      x0, x19
006AC4B4C  mov      x1, xzr
006AC4B50  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC4B54  adrp     x21, #0x959f000
006AC4B58  ldrb     w8, [x21, #0x5d]
006AC4B5C  mov      w20, w0
006AC4B60  cbnz     w8, #0x6ac4b78
006AC4B64  adrp     x0, #0x8f3b000
006AC4B68  ldr      x0, [x0, #0x510]
006AC4B6C  bl       #0x382bd14 ; 
006AC4B70  mov      w8, #1
006AC4B74  strb     w8, [x21, #0x5d]
006AC4B78  adrp     x8, #0x8f3b000
006AC4B7C  ldr      x8, [x8, #0x510]
006AC4B80  ldr      x2, [x8]
006AC4B84  ldrb     w8, [x2, #0x53]
006AC4B88  tbnz     w8, #5, #0x6ac4b94
006AC4B8C  str      w20, [x19, #0x48]
006AC4B90  b        #0x6ac4ba4 ; 
006AC4B94  ldr      x8, [x2, #0x60]
006AC4B98  mov      x0, x19
006AC4B9C  mov      w1, w20
006AC4BA0  blr      x8
006AC4BA4  mov      x0, x19
006AC4BA8  mov      x1, xzr
006AC4BAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC4BB0  adrp     x21, #0x959f000
006AC4BB4  ldrb     w8, [x21, #0x5e]
006AC4BB8  mov      w20, w0
006AC4BBC  cbnz     w8, #0x6ac4bd4
006AC4BC0  adrp     x0, #0x8f3b000
006AC4BC4  ldr      x0, [x0, #0x520]
006AC4BC8  bl       #0x382bd14 ; 
006AC4BCC  mov      w8, #1
006AC4BD0  strb     w8, [x21, #0x5e]
006AC4BD4  adrp     x8, #0x8f3b000
006AC4BD8  ldr      x8, [x8, #0x520]
006AC4BDC  ldr      x2, [x8]
006AC4BE0  ldrb     w8, [x2, #0x53]
006AC4BE4  tbnz     w8, #5, #0x6ac4bf0
006AC4BE8  str      w20, [x19, #0x4c]
006AC4BEC  b        #0x6ac4c00 ; 
006AC4BF0  ldr      x8, [x2, #0x60]
006AC4BF4  mov      x0, x19
006AC4BF8  mov      w1, w20
006AC4BFC  blr      x8
006AC4C00  mov      x0, x19
006AC4C04  mov      x1, xzr
006AC4C08  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC4C0C  adrp     x21, #0x959f000
006AC4C10  ldrb     w8, [x21, #0x5f]
006AC4C14  mov      w20, w0
006AC4C18  cbnz     w8, #0x6ac4c30
006AC4C1C  adrp     x0, #0x8f3b000
006AC4C20  ldr      x0, [x0, #0x530]
006AC4C24  bl       #0x382bd14 ; 
006AC4C28  mov      w8, #1
006AC4C2C  strb     w8, [x21, #0x5f]
006AC4C30  adrp     x8, #0x8f3b000
006AC4C34  ldr      x8, [x8, #0x530]
006AC4C38  ldr      x2, [x8]
006AC4C3C  ldrb     w8, [x2, #0x53]
006AC4C40  tbnz     w8, #5, #0x6ac4c4c
006AC4C44  str      w20, [x19, #0x50]
006AC4C48  b        #0x6ac4c5c ; 
006AC4C4C  ldr      x8, [x2, #0x60]
006AC4C50  mov      x0, x19
006AC4C54  mov      w1, w20
006AC4C58  blr      x8
006AC4C5C  mov      x0, x19
006AC4C60  mov      x1, xzr
006AC4C64  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC4C68  adrp     x21, #0x959f000
006AC4C6C  ldrb     w8, [x21, #0x60]
006AC4C70  mov      x20, x0
006AC4C74  cbnz     w8, #0x6ac4c8c
006AC4C78  adrp     x0, #0x8f3b000
006AC4C7C  ldr      x0, [x0, #0x540]
006AC4C80  bl       #0x382bd14 ; 
006AC4C84  mov      w8, #1
006AC4C88  strb     w8, [x21, #0x60]
006AC4C8C  adrp     x8, #0x8f3b000
006AC4C90  ldr      x8, [x8, #0x540]
006AC4C94  ldr      x2, [x8]
006AC4C98  ldrb     w8, [x2, #0x53]
006AC4C9C  tbnz     w8, #5, #0x6ac4ca8
006AC4CA0  str      x20, [x19, #0x58]
006AC4CA4  b        #0x6ac4cb8 ; 
006AC4CA8  ldr      x8, [x2, #0x60]
006AC4CAC  mov      x0, x19
006AC4CB0  mov      x1, x20
006AC4CB4  blr      x8
006AC4CB8  mov      x0, x19
006AC4CBC  mov      x1, xzr
006AC4CC0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC4CC4  adrp     x21, #0x959f000
006AC4CC8  ldrb     w8, [x21, #0x61]
006AC4CCC  mov      x20, x0
006AC4CD0  cbnz     w8, #0x6ac4ce8
006AC4CD4  adrp     x0, #0x8f3b000
006AC4CD8  ldr      x0, [x0, #0x550]
006AC4CDC  bl       #0x382bd14 ; 
006AC4CE0  mov      w8, #1
006AC4CE4  strb     w8, [x21, #0x61]
006AC4CE8  adrp     x8, #0x8f3b000
006AC4CEC  ldr      x8, [x8, #0x550]
006AC4CF0  ldr      x2, [x8]
006AC4CF4  ldrb     w8, [x2, #0x53]
006AC4CF8  tbnz     w8, #5, #0x6ac4d04
006AC4CFC  str      x20, [x19, #0x60]
006AC4D00  b        #0x6ac4d14 ; 
006AC4D04  ldr      x8, [x2, #0x60]
006AC4D08  mov      x0, x19
006AC4D0C  mov      x1, x20
006AC4D10  blr      x8
006AC4D14  ldp      x20, x19, [sp, #0x10]
006AC4D18  mov      w0, #1
006AC4D1C  ldp      x30, x21, [sp], #0x20
006AC4D20  ret      

