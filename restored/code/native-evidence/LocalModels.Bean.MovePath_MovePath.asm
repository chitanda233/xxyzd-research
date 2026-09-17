; LocalModels.Bean.MovePath_MovePath$$readImpl
; RVA 0x6ACCE8C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ACCE8C  stp      x30, x21, [sp, #-0x20]!
006ACCE90  stp      x20, x19, [sp, #0x10]
006ACCE94  adrp     x20, #0x959e000
006ACCE98  adrp     x21, #0x8f3b000
006ACCE9C  ldrb     w8, [x20, #0xab3]
006ACCEA0  ldr      x21, [x21, #0xb20]
006ACCEA4  mov      x19, x0
006ACCEA8  tbnz     w8, #0, #0x6accec0
006ACCEAC  adrp     x0, #0x8f3b000
006ACCEB0  ldr      x0, [x0, #0xb20]
006ACCEB4  bl       #0x382bd14 ; 
006ACCEB8  mov      w8, #1
006ACCEBC  strb     w8, [x20, #0xab3]
006ACCEC0  ldr      x1, [x21]
006ACCEC4  ldrb     w8, [x1, #0x53]
006ACCEC8  tbnz     w8, #5, #0x6accf18
006ACCECC  mov      x0, x19
006ACCED0  mov      x1, xzr
006ACCED4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACCED8  adrp     x21, #0x959f000
006ACCEDC  ldrb     w8, [x21, #0xbf]
006ACCEE0  mov      w20, w0
006ACCEE4  cbnz     w8, #0x6accefc
006ACCEE8  adrp     x0, #0x8f3b000
006ACCEEC  ldr      x0, [x0, #0xb10]
006ACCEF0  bl       #0x382bd14 ; 
006ACCEF4  mov      w8, #1
006ACCEF8  strb     w8, [x21, #0xbf]
006ACCEFC  adrp     x8, #0x8f3b000
006ACCF00  ldr      x8, [x8, #0xb10]
006ACCF04  ldr      x2, [x8]
006ACCF08  ldrb     w8, [x2, #0x53]
006ACCF0C  tbnz     w8, #5, #0x6accf2c
006ACCF10  str      w20, [x19, #0x20]
006ACCF14  b        #0x6accf3c ; 
006ACCF18  ldr      x2, [x1, #0x60]
006ACCF1C  mov      x0, x19
006ACCF20  ldp      x20, x19, [sp, #0x10]
006ACCF24  ldp      x30, x21, [sp], #0x20
006ACCF28  br       x2
006ACCF2C  ldr      x8, [x2, #0x60]
006ACCF30  mov      x0, x19
006ACCF34  mov      w1, w20
006ACCF38  blr      x8
006ACCF3C  mov      x0, x19
006ACCF40  mov      x1, xzr
006ACCF44  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ACCF48  adrp     x21, #0x959f000
006ACCF4C  ldrb     w8, [x21, #0xc0]
006ACCF50  mov      x20, x0
006ACCF54  cbnz     w8, #0x6accf6c
006ACCF58  adrp     x0, #0x8f3b000
006ACCF5C  ldr      x0, [x0, #0xb18]
006ACCF60  bl       #0x382bd14 ; 
006ACCF64  mov      w8, #1
006ACCF68  strb     w8, [x21, #0xc0]
006ACCF6C  adrp     x8, #0x8f3b000
006ACCF70  ldr      x8, [x8, #0xb18]
006ACCF74  ldr      x2, [x8]
006ACCF78  ldrb     w8, [x2, #0x53]
006ACCF7C  tbnz     w8, #5, #0x6accf94
006ACCF80  str      x20, [x19, #0x28]!
006ACCF84  mov      x0, x19
006ACCF88  mov      x1, x20
006ACCF8C  bl       #0x382bcb8 ; 
006ACCF90  b        #0x6accfa4 ; 
006ACCF94  ldr      x8, [x2, #0x60]
006ACCF98  mov      x0, x19
006ACCF9C  mov      x1, x20
006ACCFA0  blr      x8
006ACCFA4  ldp      x20, x19, [sp, #0x10]
006ACCFA8  mov      w0, #1
006ACCFAC  ldp      x30, x21, [sp], #0x20
006ACCFB0  ret      

