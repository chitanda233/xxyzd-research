; LocalModels.Bean.Quality_qualityUp$$readImpl
; RVA 0x6AD57C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD57C0  str      d8, [sp, #-0x30]!
006AD57C4  stp      x30, x21, [sp, #0x10]
006AD57C8  stp      x20, x19, [sp, #0x20]
006AD57CC  adrp     x20, #0x959e000
006AD57D0  adrp     x21, #0x8f3c000
006AD57D4  ldrb     w8, [x20, #0xb9d]
006AD57D8  ldr      x21, [x21, #0x200]
006AD57DC  mov      x19, x0
006AD57E0  tbnz     w8, #0, #0x6ad57f8
006AD57E4  adrp     x0, #0x8f3c000
006AD57E8  ldr      x0, [x0, #0x200]
006AD57EC  bl       #0x382bd14 ; 
006AD57F0  mov      w8, #1
006AD57F4  strb     w8, [x20, #0xb9d]
006AD57F8  ldr      x1, [x21]
006AD57FC  ldrb     w8, [x1, #0x53]
006AD5800  tbnz     w8, #5, #0x6ad5850
006AD5804  mov      x0, x19
006AD5808  mov      x1, xzr
006AD580C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD5810  adrp     x21, #0x959f000
006AD5814  ldrb     w8, [x21, #0x114]
006AD5818  mov      w20, w0
006AD581C  cbnz     w8, #0x6ad5834
006AD5820  adrp     x0, #0x8f3c000
006AD5824  ldr      x0, [x0, #0x138]
006AD5828  bl       #0x382bd14 ; 
006AD582C  mov      w8, #1
006AD5830  strb     w8, [x21, #0x114]
006AD5834  adrp     x8, #0x8f3c000
006AD5838  ldr      x8, [x8, #0x138]
006AD583C  ldr      x2, [x8]
006AD5840  ldrb     w8, [x2, #0x53]
006AD5844  tbnz     w8, #5, #0x6ad5868
006AD5848  str      w20, [x19, #0x20]
006AD584C  b        #0x6ad5878 ; 
006AD5850  ldr      x2, [x1, #0x60]
006AD5854  mov      x0, x19
006AD5858  ldp      x20, x19, [sp, #0x20]
006AD585C  ldp      x30, x21, [sp, #0x10]
006AD5860  ldr      d8, [sp], #0x30
006AD5864  br       x2
006AD5868  ldr      x8, [x2, #0x60]
006AD586C  mov      x0, x19
006AD5870  mov      w1, w20
006AD5874  blr      x8
006AD5878  mov      x0, x19
006AD587C  mov      x1, xzr
006AD5880  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD5884  adrp     x21, #0x959f000
006AD5888  ldrb     w8, [x21, #0x115]
006AD588C  mov      w20, w0
006AD5890  cbnz     w8, #0x6ad58a8
006AD5894  adrp     x0, #0x8f3c000
006AD5898  ldr      x0, [x0, #0x148]
006AD589C  bl       #0x382bd14 ; 
006AD58A0  mov      w8, #1
006AD58A4  strb     w8, [x21, #0x115]
006AD58A8  adrp     x8, #0x8f3c000
006AD58AC  ldr      x8, [x8, #0x148]
006AD58B0  ldr      x2, [x8]
006AD58B4  ldrb     w8, [x2, #0x53]
006AD58B8  tbnz     w8, #5, #0x6ad58c4
006AD58BC  str      w20, [x19, #0x24]
006AD58C0  b        #0x6ad58d4 ; 
006AD58C4  ldr      x8, [x2, #0x60]
006AD58C8  mov      x0, x19
006AD58CC  mov      w1, w20
006AD58D0  blr      x8
006AD58D4  mov      x0, x19
006AD58D8  mov      x1, xzr
006AD58DC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD58E0  adrp     x21, #0x959f000
006AD58E4  ldrb     w8, [x21, #0x116]
006AD58E8  mov      x20, x0
006AD58EC  cbnz     w8, #0x6ad5904
006AD58F0  adrp     x0, #0x8f3c000
006AD58F4  ldr      x0, [x0, #0x158]
006AD58F8  bl       #0x382bd14 ; 
006AD58FC  mov      w8, #1
006AD5900  strb     w8, [x21, #0x116]
006AD5904  adrp     x8, #0x8f3c000
006AD5908  ldr      x8, [x8, #0x158]
006AD590C  ldr      x2, [x8]
006AD5910  ldrb     w8, [x2, #0x53]
006AD5914  tbnz     w8, #5, #0x6ad592c
006AD5918  mov      x0, x19
006AD591C  str      x20, [x0, #0x28]!
006AD5920  mov      x1, x20
006AD5924  bl       #0x382bcb8 ; 
006AD5928  b        #0x6ad593c ; 
006AD592C  ldr      x8, [x2, #0x60]
006AD5930  mov      x0, x19
006AD5934  mov      x1, x20
006AD5938  blr      x8
006AD593C  mov      x0, x19
006AD5940  mov      x1, xzr
006AD5944  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006AD5948  adrp     x20, #0x959f000
006AD594C  ldrb     w8, [x20, #0x117]
006AD5950  mov      v8.16b, v0.16b
006AD5954  cbnz     w8, #0x6ad596c
006AD5958  adrp     x0, #0x8f3c000
006AD595C  ldr      x0, [x0, #0x168]
006AD5960  bl       #0x382bd14 ; 
006AD5964  mov      w8, #1
006AD5968  strb     w8, [x20, #0x117]
006AD596C  adrp     x8, #0x8f3c000
006AD5970  ldr      x8, [x8, #0x168]
006AD5974  ldr      x1, [x8]
006AD5978  ldrb     w8, [x1, #0x53]
006AD597C  tbnz     w8, #5, #0x6ad5988
006AD5980  str      s8, [x19, #0x30]
006AD5984  b        #0x6ad5998 ; 
006AD5988  ldr      x8, [x1, #0x60]
006AD598C  mov      x0, x19
006AD5990  mov      v0.16b, v8.16b
006AD5994  blr      x8
006AD5998  mov      x0, x19
006AD599C  mov      x1, xzr
006AD59A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD59A4  adrp     x21, #0x959f000
006AD59A8  ldrb     w8, [x21, #0x118]
006AD59AC  mov      w20, w0
006AD59B0  cbnz     w8, #0x6ad59c8
006AD59B4  adrp     x0, #0x8f3c000
006AD59B8  ldr      x0, [x0, #0x178]
006AD59BC  bl       #0x382bd14 ; 
006AD59C0  mov      w8, #1
006AD59C4  strb     w8, [x21, #0x118]
006AD59C8  adrp     x8, #0x8f3c000
006AD59CC  ldr      x8, [x8, #0x178]
006AD59D0  ldr      x2, [x8]
006AD59D4  ldrb     w8, [x2, #0x53]
006AD59D8  tbnz     w8, #5, #0x6ad59e4
006AD59DC  str      w20, [x19, #0x34]
006AD59E0  b        #0x6ad59f4 ; 
006AD59E4  ldr      x8, [x2, #0x60]
006AD59E8  mov      x0, x19
006AD59EC  mov      w1, w20
006AD59F0  blr      x8
006AD59F4  mov      x0, x19
006AD59F8  mov      x1, xzr
006AD59FC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD5A00  adrp     x21, #0x959f000
006AD5A04  ldrb     w8, [x21, #0x119]
006AD5A08  mov      x20, x0
006AD5A0C  cbnz     w8, #0x6ad5a24
006AD5A10  adrp     x0, #0x8f3c000
006AD5A14  ldr      x0, [x0, #0x188]
006AD5A18  bl       #0x382bd14 ; 
006AD5A1C  mov      w8, #1
006AD5A20  strb     w8, [x21, #0x119]
006AD5A24  adrp     x8, #0x8f3c000
006AD5A28  ldr      x8, [x8, #0x188]
006AD5A2C  ldr      x2, [x8]
006AD5A30  ldrb     w8, [x2, #0x53]
006AD5A34  tbnz     w8, #5, #0x6ad5a4c
006AD5A38  mov      x0, x19
006AD5A3C  str      x20, [x0, #0x38]!
006AD5A40  mov      x1, x20
006AD5A44  bl       #0x382bcb8 ; 
006AD5A48  b        #0x6ad5a5c ; 
006AD5A4C  ldr      x8, [x2, #0x60]
006AD5A50  mov      x0, x19
006AD5A54  mov      x1, x20
006AD5A58  blr      x8
006AD5A5C  mov      x0, x19
006AD5A60  mov      x1, xzr
006AD5A64  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD5A68  adrp     x21, #0x959f000
006AD5A6C  ldrb     w8, [x21, #0x11a]
006AD5A70  mov      x20, x0
006AD5A74  cbnz     w8, #0x6ad5a8c
006AD5A78  adrp     x0, #0x8f3c000
006AD5A7C  ldr      x0, [x0, #0x198]
006AD5A80  bl       #0x382bd14 ; 
006AD5A84  mov      w8, #1
006AD5A88  strb     w8, [x21, #0x11a]
006AD5A8C  adrp     x8, #0x8f3c000
006AD5A90  ldr      x8, [x8, #0x198]
006AD5A94  ldr      x2, [x8]
006AD5A98  ldrb     w8, [x2, #0x53]
006AD5A9C  tbnz     w8, #5, #0x6ad5ab4
006AD5AA0  mov      x0, x19
006AD5AA4  str      x20, [x0, #0x40]!
006AD5AA8  mov      x1, x20
006AD5AAC  bl       #0x382bcb8 ; 
006AD5AB0  b        #0x6ad5ac4 ; 
006AD5AB4  ldr      x8, [x2, #0x60]
006AD5AB8  mov      x0, x19
006AD5ABC  mov      x1, x20
006AD5AC0  blr      x8
006AD5AC4  mov      x0, x19
006AD5AC8  mov      x1, xzr
006AD5ACC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD5AD0  adrp     x21, #0x959f000
006AD5AD4  ldrb     w8, [x21, #0x11b]
006AD5AD8  mov      x20, x0
006AD5ADC  cbnz     w8, #0x6ad5af4
006AD5AE0  adrp     x0, #0x8f3c000
006AD5AE4  ldr      x0, [x0, #0x1a8]
006AD5AE8  bl       #0x382bd14 ; 
006AD5AEC  mov      w8, #1
006AD5AF0  strb     w8, [x21, #0x11b]
006AD5AF4  adrp     x8, #0x8f3c000
006AD5AF8  ldr      x8, [x8, #0x1a8]
006AD5AFC  ldr      x2, [x8]
006AD5B00  ldrb     w8, [x2, #0x53]
006AD5B04  tbnz     w8, #5, #0x6ad5b1c
006AD5B08  mov      x0, x19
006AD5B0C  str      x20, [x0, #0x48]!
006AD5B10  mov      x1, x20
006AD5B14  bl       #0x382bcb8 ; 
006AD5B18  b        #0x6ad5b2c ; 
006AD5B1C  ldr      x8, [x2, #0x60]
006AD5B20  mov      x0, x19
006AD5B24  mov      x1, x20
006AD5B28  blr      x8
006AD5B2C  mov      x0, x19
006AD5B30  mov      x1, xzr
006AD5B34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD5B38  adrp     x21, #0x959f000
006AD5B3C  ldrb     w8, [x21, #0x11c]
006AD5B40  mov      w20, w0
006AD5B44  cbnz     w8, #0x6ad5b5c
006AD5B48  adrp     x0, #0x8f3c000
006AD5B4C  ldr      x0, [x0, #0x1b8]
006AD5B50  bl       #0x382bd14 ; 
006AD5B54  mov      w8, #1
006AD5B58  strb     w8, [x21, #0x11c]
006AD5B5C  adrp     x8, #0x8f3c000
006AD5B60  ldr      x8, [x8, #0x1b8]
006AD5B64  ldr      x2, [x8]
006AD5B68  ldrb     w8, [x2, #0x53]
006AD5B6C  tbnz     w8, #5, #0x6ad5b78
006AD5B70  str      w20, [x19, #0x50]
006AD5B74  b        #0x6ad5b88 ; 
006AD5B78  ldr      x8, [x2, #0x60]
006AD5B7C  mov      x0, x19
006AD5B80  mov      w1, w20
006AD5B84  blr      x8
006AD5B88  mov      x0, x19
006AD5B8C  mov      x1, xzr
006AD5B90  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD5B94  adrp     x21, #0x959f000
006AD5B98  ldrb     w8, [x21, #0x11d]
006AD5B9C  mov      w20, w0
006AD5BA0  cbnz     w8, #0x6ad5bb8
006AD5BA4  adrp     x0, #0x8f3c000
006AD5BA8  ldr      x0, [x0, #0x1c8]
006AD5BAC  bl       #0x382bd14 ; 
006AD5BB0  mov      w8, #1
006AD5BB4  strb     w8, [x21, #0x11d]
006AD5BB8  adrp     x8, #0x8f3c000
006AD5BBC  ldr      x8, [x8, #0x1c8]
006AD5BC0  ldr      x2, [x8]
006AD5BC4  ldrb     w8, [x2, #0x53]
006AD5BC8  tbnz     w8, #5, #0x6ad5bd4
006AD5BCC  str      w20, [x19, #0x54]
006AD5BD0  b        #0x6ad5be4 ; 
006AD5BD4  ldr      x8, [x2, #0x60]
006AD5BD8  mov      x0, x19
006AD5BDC  mov      w1, w20
006AD5BE0  blr      x8
006AD5BE4  mov      x0, x19
006AD5BE8  mov      x1, xzr
006AD5BEC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AD5BF0  adrp     x21, #0x959f000
006AD5BF4  ldrb     w8, [x21, #0x11e]
006AD5BF8  mov      x20, x0
006AD5BFC  cbnz     w8, #0x6ad5c14
006AD5C00  adrp     x0, #0x8f3c000
006AD5C04  ldr      x0, [x0, #0x1d8]
006AD5C08  bl       #0x382bd14 ; 
006AD5C0C  mov      w8, #1
006AD5C10  strb     w8, [x21, #0x11e]
006AD5C14  adrp     x8, #0x8f3c000
006AD5C18  ldr      x8, [x8, #0x1d8]
006AD5C1C  ldr      x2, [x8]
006AD5C20  ldrb     w8, [x2, #0x53]
006AD5C24  tbnz     w8, #5, #0x6ad5c3c
006AD5C28  mov      x0, x19
006AD5C2C  str      x20, [x0, #0x58]!
006AD5C30  mov      x1, x20
006AD5C34  bl       #0x382bcb8 ; 
006AD5C38  b        #0x6ad5c4c ; 
006AD5C3C  ldr      x8, [x2, #0x60]
006AD5C40  mov      x0, x19
006AD5C44  mov      x1, x20
006AD5C48  blr      x8
006AD5C4C  mov      x0, x19
006AD5C50  mov      x1, xzr
006AD5C54  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD5C58  adrp     x21, #0x959f000
006AD5C5C  ldrb     w8, [x21, #0x11f]
006AD5C60  mov      x20, x0
006AD5C64  cbnz     w8, #0x6ad5c7c
006AD5C68  adrp     x0, #0x8f3c000
006AD5C6C  ldr      x0, [x0, #0x1e8]
006AD5C70  bl       #0x382bd14 ; 
006AD5C74  mov      w8, #1
006AD5C78  strb     w8, [x21, #0x11f]
006AD5C7C  adrp     x8, #0x8f3c000
006AD5C80  ldr      x8, [x8, #0x1e8]
006AD5C84  ldr      x2, [x8]
006AD5C88  ldrb     w8, [x2, #0x53]
006AD5C8C  tbnz     w8, #5, #0x6ad5ca4
006AD5C90  mov      x0, x19
006AD5C94  str      x20, [x0, #0x60]!
006AD5C98  mov      x1, x20
006AD5C9C  bl       #0x382bcb8 ; 
006AD5CA0  b        #0x6ad5cb4 ; 
006AD5CA4  ldr      x8, [x2, #0x60]
006AD5CA8  mov      x0, x19
006AD5CAC  mov      x1, x20
006AD5CB0  blr      x8
006AD5CB4  mov      x0, x19
006AD5CB8  mov      x1, xzr
006AD5CBC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AD5CC0  adrp     x21, #0x959f000
006AD5CC4  ldrb     w8, [x21, #0x120]
006AD5CC8  mov      x20, x0
006AD5CCC  cbnz     w8, #0x6ad5ce4
006AD5CD0  adrp     x0, #0x8f3c000
006AD5CD4  ldr      x0, [x0, #0x1f8]
006AD5CD8  bl       #0x382bd14 ; 
006AD5CDC  mov      w8, #1
006AD5CE0  strb     w8, [x21, #0x120]
006AD5CE4  adrp     x8, #0x8f3c000
006AD5CE8  ldr      x8, [x8, #0x1f8]
006AD5CEC  ldr      x2, [x8]
006AD5CF0  ldrb     w8, [x2, #0x53]
006AD5CF4  tbnz     w8, #5, #0x6ad5d0c
006AD5CF8  str      x20, [x19, #0x68]!
006AD5CFC  mov      x0, x19
006AD5D00  mov      x1, x20
006AD5D04  bl       #0x382bcb8 ; 
006AD5D08  b        #0x6ad5d1c ; 
006AD5D0C  ldr      x8, [x2, #0x60]
006AD5D10  mov      x0, x19
006AD5D14  mov      x1, x20
006AD5D18  blr      x8
006AD5D1C  ldp      x20, x19, [sp, #0x20]
006AD5D20  ldp      x30, x21, [sp, #0x10]
006AD5D24  mov      w0, #1
006AD5D28  ldr      d8, [sp], #0x30
006AD5D2C  ret      

