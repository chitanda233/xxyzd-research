; LocalModels.Bean.Mission_BeeMonsterFlushConfig$$readImpl
; RVA 0x6AC1AA4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC1AA4  stp      x30, x21, [sp, #-0x20]!
006AC1AA8  stp      x20, x19, [sp, #0x10]
006AC1AAC  adrp     x20, #0x959e000
006AC1AB0  adrp     x21, #0x8f3b000
006AC1AB4  ldrb     w8, [x20, #0x989]
006AC1AB8  ldr      x21, [x21, #0x330]
006AC1ABC  mov      x19, x0
006AC1AC0  tbnz     w8, #0, #0x6ac1ad8
006AC1AC4  adrp     x0, #0x8f3b000
006AC1AC8  ldr      x0, [x0, #0x330]
006AC1ACC  bl       #0x382bd14 ; 
006AC1AD0  mov      w8, #1
006AC1AD4  strb     w8, [x20, #0x989]
006AC1AD8  ldr      x1, [x21]
006AC1ADC  ldrb     w8, [x1, #0x53]
006AC1AE0  tbnz     w8, #5, #0x6ac1b30
006AC1AE4  mov      x0, x19
006AC1AE8  mov      x1, xzr
006AC1AEC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC1AF0  adrp     x21, #0x959f000
006AC1AF4  ldrb     w8, [x21, #0x3d]
006AC1AF8  mov      w20, w0
006AC1AFC  cbnz     w8, #0x6ac1b14
006AC1B00  adrp     x0, #0x8f3b000
006AC1B04  ldr      x0, [x0, #0x2f8]
006AC1B08  bl       #0x382bd14 ; 
006AC1B0C  mov      w8, #1
006AC1B10  strb     w8, [x21, #0x3d]
006AC1B14  adrp     x8, #0x8f3b000
006AC1B18  ldr      x8, [x8, #0x2f8]
006AC1B1C  ldr      x2, [x8]
006AC1B20  ldrb     w8, [x2, #0x53]
006AC1B24  tbnz     w8, #5, #0x6ac1b44
006AC1B28  str      w20, [x19, #0x20]
006AC1B2C  b        #0x6ac1b54 ; 
006AC1B30  ldr      x2, [x1, #0x60]
006AC1B34  mov      x0, x19
006AC1B38  ldp      x20, x19, [sp, #0x10]
006AC1B3C  ldp      x30, x21, [sp], #0x20
006AC1B40  br       x2
006AC1B44  ldr      x8, [x2, #0x60]
006AC1B48  mov      x0, x19
006AC1B4C  mov      w1, w20
006AC1B50  blr      x8
006AC1B54  mov      x0, x19
006AC1B58  mov      x1, xzr
006AC1B5C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC1B60  adrp     x21, #0x959f000
006AC1B64  ldrb     w8, [x21, #0x3e]
006AC1B68  mov      x20, x0
006AC1B6C  cbnz     w8, #0x6ac1b84
006AC1B70  adrp     x0, #0x8f3b000
006AC1B74  ldr      x0, [x0, #0x300]
006AC1B78  bl       #0x382bd14 ; 
006AC1B7C  mov      w8, #1
006AC1B80  strb     w8, [x21, #0x3e]
006AC1B84  adrp     x8, #0x8f3b000
006AC1B88  ldr      x8, [x8, #0x300]
006AC1B8C  ldr      x2, [x8]
006AC1B90  ldrb     w8, [x2, #0x53]
006AC1B94  tbnz     w8, #5, #0x6ac1ba0
006AC1B98  str      x20, [x19, #0x28]
006AC1B9C  b        #0x6ac1bb0 ; 
006AC1BA0  ldr      x8, [x2, #0x60]
006AC1BA4  mov      x0, x19
006AC1BA8  mov      x1, x20
006AC1BAC  blr      x8
006AC1BB0  mov      x0, x19
006AC1BB4  mov      x1, xzr
006AC1BB8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC1BBC  adrp     x21, #0x959f000
006AC1BC0  ldrb     w8, [x21, #0x3f]
006AC1BC4  mov      x20, x0
006AC1BC8  cbnz     w8, #0x6ac1be0
006AC1BCC  adrp     x0, #0x8f3b000
006AC1BD0  ldr      x0, [x0, #0x308]
006AC1BD4  bl       #0x382bd14 ; 
006AC1BD8  mov      w8, #1
006AC1BDC  strb     w8, [x21, #0x3f]
006AC1BE0  adrp     x8, #0x8f3b000
006AC1BE4  ldr      x8, [x8, #0x308]
006AC1BE8  ldr      x2, [x8]
006AC1BEC  ldrb     w8, [x2, #0x53]
006AC1BF0  tbnz     w8, #5, #0x6ac1bfc
006AC1BF4  str      x20, [x19, #0x30]
006AC1BF8  b        #0x6ac1c0c ; 
006AC1BFC  ldr      x8, [x2, #0x60]
006AC1C00  mov      x0, x19
006AC1C04  mov      x1, x20
006AC1C08  blr      x8
006AC1C0C  mov      x0, x19
006AC1C10  mov      x1, xzr
006AC1C14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC1C18  adrp     x21, #0x959f000
006AC1C1C  ldrb     w8, [x21, #0x40]
006AC1C20  mov      w20, w0
006AC1C24  cbnz     w8, #0x6ac1c3c
006AC1C28  adrp     x0, #0x8f3b000
006AC1C2C  ldr      x0, [x0, #0x310]
006AC1C30  bl       #0x382bd14 ; 
006AC1C34  mov      w8, #1
006AC1C38  strb     w8, [x21, #0x40]
006AC1C3C  adrp     x8, #0x8f3b000
006AC1C40  ldr      x8, [x8, #0x310]
006AC1C44  ldr      x2, [x8]
006AC1C48  ldrb     w8, [x2, #0x53]
006AC1C4C  tbnz     w8, #5, #0x6ac1c58
006AC1C50  str      w20, [x19, #0x38]
006AC1C54  b        #0x6ac1c68 ; 
006AC1C58  ldr      x8, [x2, #0x60]
006AC1C5C  mov      x0, x19
006AC1C60  mov      w1, w20
006AC1C64  blr      x8
006AC1C68  mov      x0, x19
006AC1C6C  mov      x1, xzr
006AC1C70  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
006AC1C74  adrp     x21, #0x959f000
006AC1C78  ldrb     w8, [x21, #0x41]
006AC1C7C  mov      x20, x0
006AC1C80  cbnz     w8, #0x6ac1c98
006AC1C84  adrp     x0, #0x8f3b000
006AC1C88  ldr      x0, [x0, #0x318]
006AC1C8C  bl       #0x382bd14 ; 
006AC1C90  mov      w8, #1
006AC1C94  strb     w8, [x21, #0x41]
006AC1C98  adrp     x8, #0x8f3b000
006AC1C9C  ldr      x8, [x8, #0x318]
006AC1CA0  ldr      x2, [x8]
006AC1CA4  ldrb     w8, [x2, #0x53]
006AC1CA8  tbnz     w8, #5, #0x6ac1cc0
006AC1CAC  mov      x0, x19
006AC1CB0  str      x20, [x0, #0x40]!
006AC1CB4  mov      x1, x20
006AC1CB8  bl       #0x382bcb8 ; 
006AC1CBC  b        #0x6ac1cd0 ; 
006AC1CC0  ldr      x8, [x2, #0x60]
006AC1CC4  mov      x0, x19
006AC1CC8  mov      x1, x20
006AC1CCC  blr      x8
006AC1CD0  mov      x0, x19
006AC1CD4  mov      x1, xzr
006AC1CD8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC1CDC  adrp     x21, #0x959f000
006AC1CE0  ldrb     w8, [x21, #0x42]
006AC1CE4  mov      x20, x0
006AC1CE8  cbnz     w8, #0x6ac1d00
006AC1CEC  adrp     x0, #0x8f3b000
006AC1CF0  ldr      x0, [x0, #0x320]
006AC1CF4  bl       #0x382bd14 ; 
006AC1CF8  mov      w8, #1
006AC1CFC  strb     w8, [x21, #0x42]
006AC1D00  adrp     x8, #0x8f3b000
006AC1D04  ldr      x8, [x8, #0x320]
006AC1D08  ldr      x2, [x8]
006AC1D0C  ldrb     w8, [x2, #0x53]
006AC1D10  tbnz     w8, #5, #0x6ac1d1c
006AC1D14  str      x20, [x19, #0x48]
006AC1D18  b        #0x6ac1d2c ; 
006AC1D1C  ldr      x8, [x2, #0x60]
006AC1D20  mov      x0, x19
006AC1D24  mov      x1, x20
006AC1D28  blr      x8
006AC1D2C  mov      x0, x19
006AC1D30  mov      x1, xzr
006AC1D34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC1D38  adrp     x21, #0x959f000
006AC1D3C  ldrb     w8, [x21, #0x43]
006AC1D40  mov      w20, w0
006AC1D44  cbnz     w8, #0x6ac1d5c
006AC1D48  adrp     x0, #0x8f3b000
006AC1D4C  ldr      x0, [x0, #0x328]
006AC1D50  bl       #0x382bd14 ; 
006AC1D54  mov      w8, #1
006AC1D58  strb     w8, [x21, #0x43]
006AC1D5C  adrp     x8, #0x8f3b000
006AC1D60  ldr      x8, [x8, #0x328]
006AC1D64  ldr      x2, [x8]
006AC1D68  ldrb     w8, [x2, #0x53]
006AC1D6C  tbnz     w8, #5, #0x6ac1d78
006AC1D70  str      w20, [x19, #0x50]
006AC1D74  b        #0x6ac1d88 ; 
006AC1D78  ldr      x8, [x2, #0x60]
006AC1D7C  mov      x0, x19
006AC1D80  mov      w1, w20
006AC1D84  blr      x8
006AC1D88  ldp      x20, x19, [sp, #0x10]
006AC1D8C  mov      w0, #1
006AC1D90  ldp      x30, x21, [sp], #0x20
006AC1D94  ret      

