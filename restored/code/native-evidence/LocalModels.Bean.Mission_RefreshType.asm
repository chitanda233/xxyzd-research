; LocalModels.Bean.Mission_RefreshType$$readImpl
; RVA 0x6AC3AA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC3AA8  stp      x30, x21, [sp, #-0x20]!
006AC3AAC  stp      x20, x19, [sp, #0x10]
006AC3AB0  adrp     x20, #0x959e000
006AC3AB4  adrp     x21, #0x8f3b000
006AC3AB8  ldrb     w8, [x20, #0x9bf]
006AC3ABC  ldr      x21, [x21, #0x488]
006AC3AC0  mov      x19, x0
006AC3AC4  tbnz     w8, #0, #0x6ac3adc
006AC3AC8  adrp     x0, #0x8f3b000
006AC3ACC  ldr      x0, [x0, #0x488]
006AC3AD0  bl       #0x382bd14 ; 
006AC3AD4  mov      w8, #1
006AC3AD8  strb     w8, [x20, #0x9bf]
006AC3ADC  ldr      x1, [x21]
006AC3AE0  ldrb     w8, [x1, #0x53]
006AC3AE4  tbnz     w8, #5, #0x6ac3b34
006AC3AE8  mov      x0, x19
006AC3AEC  mov      x1, xzr
006AC3AF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC3AF4  adrp     x21, #0x959f000
006AC3AF8  ldrb     w8, [x21, #0x51]
006AC3AFC  mov      w20, w0
006AC3B00  cbnz     w8, #0x6ac3b18
006AC3B04  adrp     x0, #0x8f3b000
006AC3B08  ldr      x0, [x0, #0x440]
006AC3B0C  bl       #0x382bd14 ; 
006AC3B10  mov      w8, #1
006AC3B14  strb     w8, [x21, #0x51]
006AC3B18  adrp     x8, #0x8f3b000
006AC3B1C  ldr      x8, [x8, #0x440]
006AC3B20  ldr      x2, [x8]
006AC3B24  ldrb     w8, [x2, #0x53]
006AC3B28  tbnz     w8, #5, #0x6ac3b48
006AC3B2C  str      w20, [x19, #0x20]
006AC3B30  b        #0x6ac3b58 ; 
006AC3B34  ldr      x2, [x1, #0x60]
006AC3B38  mov      x0, x19
006AC3B3C  ldp      x20, x19, [sp, #0x10]
006AC3B40  ldp      x30, x21, [sp], #0x20
006AC3B44  br       x2
006AC3B48  ldr      x8, [x2, #0x60]
006AC3B4C  mov      x0, x19
006AC3B50  mov      w1, w20
006AC3B54  blr      x8
006AC3B58  mov      x0, x19
006AC3B5C  mov      x1, xzr
006AC3B60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC3B64  adrp     x21, #0x959f000
006AC3B68  ldrb     w8, [x21, #0x52]
006AC3B6C  mov      w20, w0
006AC3B70  cbnz     w8, #0x6ac3b88
006AC3B74  adrp     x0, #0x8f3b000
006AC3B78  ldr      x0, [x0, #0x450]
006AC3B7C  bl       #0x382bd14 ; 
006AC3B80  mov      w8, #1
006AC3B84  strb     w8, [x21, #0x52]
006AC3B88  adrp     x8, #0x8f3b000
006AC3B8C  ldr      x8, [x8, #0x450]
006AC3B90  ldr      x2, [x8]
006AC3B94  ldrb     w8, [x2, #0x53]
006AC3B98  tbnz     w8, #5, #0x6ac3ba4
006AC3B9C  str      w20, [x19, #0x24]
006AC3BA0  b        #0x6ac3bb4 ; 
006AC3BA4  ldr      x8, [x2, #0x60]
006AC3BA8  mov      x0, x19
006AC3BAC  mov      w1, w20
006AC3BB0  blr      x8
006AC3BB4  mov      x0, x19
006AC3BB8  mov      x1, xzr
006AC3BBC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC3BC0  adrp     x21, #0x959f000
006AC3BC4  ldrb     w8, [x21, #0x53]
006AC3BC8  mov      x20, x0
006AC3BCC  cbnz     w8, #0x6ac3be4
006AC3BD0  adrp     x0, #0x8f3b000
006AC3BD4  ldr      x0, [x0, #0x460]
006AC3BD8  bl       #0x382bd14 ; 
006AC3BDC  mov      w8, #1
006AC3BE0  strb     w8, [x21, #0x53]
006AC3BE4  adrp     x8, #0x8f3b000
006AC3BE8  ldr      x8, [x8, #0x460]
006AC3BEC  ldr      x2, [x8]
006AC3BF0  ldrb     w8, [x2, #0x53]
006AC3BF4  tbnz     w8, #5, #0x6ac3c00
006AC3BF8  str      x20, [x19, #0x28]
006AC3BFC  b        #0x6ac3c10 ; 
006AC3C00  ldr      x8, [x2, #0x60]
006AC3C04  mov      x0, x19
006AC3C08  mov      x1, x20
006AC3C0C  blr      x8
006AC3C10  mov      x0, x19
006AC3C14  mov      x1, xzr
006AC3C18  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC3C1C  adrp     x21, #0x959f000
006AC3C20  ldrb     w8, [x21, #0x54]
006AC3C24  mov      x20, x0
006AC3C28  cbnz     w8, #0x6ac3c40
006AC3C2C  adrp     x0, #0x8f3b000
006AC3C30  ldr      x0, [x0, #0x470]
006AC3C34  bl       #0x382bd14 ; 
006AC3C38  mov      w8, #1
006AC3C3C  strb     w8, [x21, #0x54]
006AC3C40  adrp     x8, #0x8f3b000
006AC3C44  ldr      x8, [x8, #0x470]
006AC3C48  ldr      x2, [x8]
006AC3C4C  ldrb     w8, [x2, #0x53]
006AC3C50  tbnz     w8, #5, #0x6ac3c5c
006AC3C54  str      x20, [x19, #0x30]
006AC3C58  b        #0x6ac3c6c ; 
006AC3C5C  ldr      x8, [x2, #0x60]
006AC3C60  mov      x0, x19
006AC3C64  mov      x1, x20
006AC3C68  blr      x8
006AC3C6C  mov      x0, x19
006AC3C70  mov      x1, xzr
006AC3C74  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AC3C78  adrp     x21, #0x959f000
006AC3C7C  ldrb     w8, [x21, #0x55]
006AC3C80  mov      x20, x0
006AC3C84  cbnz     w8, #0x6ac3c9c
006AC3C88  adrp     x0, #0x8f3b000
006AC3C8C  ldr      x0, [x0, #0x480]
006AC3C90  bl       #0x382bd14 ; 
006AC3C94  mov      w8, #1
006AC3C98  strb     w8, [x21, #0x55]
006AC3C9C  adrp     x8, #0x8f3b000
006AC3CA0  ldr      x8, [x8, #0x480]
006AC3CA4  ldr      x2, [x8]
006AC3CA8  ldrb     w8, [x2, #0x53]
006AC3CAC  tbnz     w8, #5, #0x6ac3cc4
006AC3CB0  str      x20, [x19, #0x38]!
006AC3CB4  mov      x0, x19
006AC3CB8  mov      x1, x20
006AC3CBC  bl       #0x382bcb8 ; 
006AC3CC0  b        #0x6ac3cd4 ; 
006AC3CC4  ldr      x8, [x2, #0x60]
006AC3CC8  mov      x0, x19
006AC3CCC  mov      x1, x20
006AC3CD0  blr      x8
006AC3CD4  ldp      x20, x19, [sp, #0x10]
006AC3CD8  mov      w0, #1
006AC3CDC  ldp      x30, x21, [sp], #0x20
006AC3CE0  ret      

