; LocalModels.Bean.Chapter_MapStyle$$readImpl
; RVA 0x68B39D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068B39D4  stp      x30, x21, [sp, #-0x20]!
0068B39D8  stp      x20, x19, [sp, #0x10]
0068B39DC  adrp     x20, #0x959c000
0068B39E0  adrp     x21, #0x8f27000
0068B39E4  ldrb     w8, [x20, #0xbd]
0068B39E8  ldr      x21, [x21, #0x1c8]
0068B39EC  mov      x19, x0
0068B39F0  tbnz     w8, #0, #0x68b3a08
0068B39F4  adrp     x0, #0x8f27000
0068B39F8  ldr      x0, [x0, #0x1c8]
0068B39FC  bl       #0x382bd14 ; 
0068B3A00  mov      w8, #1
0068B3A04  strb     w8, [x20, #0xbd]
0068B3A08  ldr      x1, [x21]
0068B3A0C  ldrb     w8, [x1, #0x53]
0068B3A10  tbnz     w8, #5, #0x68b3a60
0068B3A14  mov      x0, x19
0068B3A18  mov      x1, xzr
0068B3A1C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B3A20  adrp     x21, #0x959c000
0068B3A24  ldrb     w8, [x21, #0x601]
0068B3A28  mov      w20, w0
0068B3A2C  cbnz     w8, #0x68b3a44
0068B3A30  adrp     x0, #0x8f27000
0068B3A34  ldr      x0, [x0, #0x170]
0068B3A38  bl       #0x382bd14 ; 
0068B3A3C  mov      w8, #1
0068B3A40  strb     w8, [x21, #0x601]
0068B3A44  adrp     x8, #0x8f27000
0068B3A48  ldr      x8, [x8, #0x170]
0068B3A4C  ldr      x2, [x8]
0068B3A50  ldrb     w8, [x2, #0x53]
0068B3A54  tbnz     w8, #5, #0x68b3a74
0068B3A58  str      w20, [x19, #0x20]
0068B3A5C  b        #0x68b3a84 ; 
0068B3A60  ldr      x2, [x1, #0x60]
0068B3A64  mov      x0, x19
0068B3A68  ldp      x20, x19, [sp, #0x10]
0068B3A6C  ldp      x30, x21, [sp], #0x20
0068B3A70  br       x2
0068B3A74  ldr      x8, [x2, #0x60]
0068B3A78  mov      x0, x19
0068B3A7C  mov      w1, w20
0068B3A80  blr      x8
0068B3A84  mov      x0, x19
0068B3A88  mov      x1, xzr
0068B3A8C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B3A90  adrp     x21, #0x959c000
0068B3A94  ldrb     w8, [x21, #0x602]
0068B3A98  mov      w20, w0
0068B3A9C  cbnz     w8, #0x68b3ab4
0068B3AA0  adrp     x0, #0x8f27000
0068B3AA4  ldr      x0, [x0, #0x180]
0068B3AA8  bl       #0x382bd14 ; 
0068B3AAC  mov      w8, #1
0068B3AB0  strb     w8, [x21, #0x602]
0068B3AB4  adrp     x8, #0x8f27000
0068B3AB8  ldr      x8, [x8, #0x180]
0068B3ABC  ldr      x2, [x8]
0068B3AC0  ldrb     w8, [x2, #0x53]
0068B3AC4  tbnz     w8, #5, #0x68b3ad0
0068B3AC8  str      w20, [x19, #0x24]
0068B3ACC  b        #0x68b3ae0 ; 
0068B3AD0  ldr      x8, [x2, #0x60]
0068B3AD4  mov      x0, x19
0068B3AD8  mov      w1, w20
0068B3ADC  blr      x8
0068B3AE0  mov      x0, x19
0068B3AE4  mov      x1, xzr
0068B3AE8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B3AEC  adrp     x21, #0x959c000
0068B3AF0  ldrb     w8, [x21, #0x603]
0068B3AF4  mov      w20, w0
0068B3AF8  cbnz     w8, #0x68b3b10
0068B3AFC  adrp     x0, #0x8f27000
0068B3B00  ldr      x0, [x0, #0x190]
0068B3B04  bl       #0x382bd14 ; 
0068B3B08  mov      w8, #1
0068B3B0C  strb     w8, [x21, #0x603]
0068B3B10  adrp     x8, #0x8f27000
0068B3B14  ldr      x8, [x8, #0x190]
0068B3B18  ldr      x2, [x8]
0068B3B1C  ldrb     w8, [x2, #0x53]
0068B3B20  tbnz     w8, #5, #0x68b3b2c
0068B3B24  str      w20, [x19, #0x28]
0068B3B28  b        #0x68b3b3c ; 
0068B3B2C  ldr      x8, [x2, #0x60]
0068B3B30  mov      x0, x19
0068B3B34  mov      w1, w20
0068B3B38  blr      x8
0068B3B3C  mov      x0, x19
0068B3B40  mov      x1, xzr
0068B3B44  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068B3B48  adrp     x21, #0x959c000
0068B3B4C  ldrb     w8, [x21, #0x604]
0068B3B50  mov      x20, x0
0068B3B54  cbnz     w8, #0x68b3b6c
0068B3B58  adrp     x0, #0x8f27000
0068B3B5C  ldr      x0, [x0, #0x1a0]
0068B3B60  bl       #0x382bd14 ; 
0068B3B64  mov      w8, #1
0068B3B68  strb     w8, [x21, #0x604]
0068B3B6C  adrp     x8, #0x8f27000
0068B3B70  ldr      x8, [x8, #0x1a0]
0068B3B74  ldr      x2, [x8]
0068B3B78  ldrb     w8, [x2, #0x53]
0068B3B7C  tbnz     w8, #5, #0x68b3b94
0068B3B80  mov      x0, x19
0068B3B84  str      x20, [x0, #0x30]!
0068B3B88  mov      x1, x20
0068B3B8C  bl       #0x382bcb8 ; 
0068B3B90  b        #0x68b3ba4 ; 
0068B3B94  ldr      x8, [x2, #0x60]
0068B3B98  mov      x0, x19
0068B3B9C  mov      x1, x20
0068B3BA0  blr      x8
0068B3BA4  mov      x0, x19
0068B3BA8  mov      x1, xzr
0068B3BAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B3BB0  adrp     x21, #0x959c000
0068B3BB4  ldrb     w8, [x21, #0x605]
0068B3BB8  mov      w20, w0
0068B3BBC  cbnz     w8, #0x68b3bd4
0068B3BC0  adrp     x0, #0x8f27000
0068B3BC4  ldr      x0, [x0, #0x1b0]
0068B3BC8  bl       #0x382bd14 ; 
0068B3BCC  mov      w8, #1
0068B3BD0  strb     w8, [x21, #0x605]
0068B3BD4  adrp     x8, #0x8f27000
0068B3BD8  ldr      x8, [x8, #0x1b0]
0068B3BDC  ldr      x2, [x8]
0068B3BE0  ldrb     w8, [x2, #0x53]
0068B3BE4  tbnz     w8, #5, #0x68b3bf0
0068B3BE8  str      w20, [x19, #0x38]
0068B3BEC  b        #0x68b3c00 ; 
0068B3BF0  ldr      x8, [x2, #0x60]
0068B3BF4  mov      x0, x19
0068B3BF8  mov      w1, w20
0068B3BFC  blr      x8
0068B3C00  mov      x0, x19
0068B3C04  mov      x1, xzr
0068B3C08  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
0068B3C0C  adrp     x21, #0x959c000
0068B3C10  ldrb     w8, [x21, #0x606]
0068B3C14  mov      x20, x0
0068B3C18  cbnz     w8, #0x68b3c30
0068B3C1C  adrp     x0, #0x8f27000
0068B3C20  ldr      x0, [x0, #0x1c0]
0068B3C24  bl       #0x382bd14 ; 
0068B3C28  mov      w8, #1
0068B3C2C  strb     w8, [x21, #0x606]
0068B3C30  adrp     x8, #0x8f27000
0068B3C34  ldr      x8, [x8, #0x1c0]
0068B3C38  ldr      x2, [x8]
0068B3C3C  ldrb     w8, [x2, #0x53]
0068B3C40  tbnz     w8, #5, #0x68b3c58
0068B3C44  str      x20, [x19, #0x40]!
0068B3C48  mov      x0, x19
0068B3C4C  mov      x1, x20
0068B3C50  bl       #0x382bcb8 ; 
0068B3C54  b        #0x68b3c68 ; 
0068B3C58  ldr      x8, [x2, #0x60]
0068B3C5C  mov      x0, x19
0068B3C60  mov      x1, x20
0068B3C64  blr      x8
0068B3C68  ldp      x20, x19, [sp, #0x10]
0068B3C6C  mov      w0, #1
0068B3C70  ldp      x30, x21, [sp], #0x20
0068B3C74  ret      

