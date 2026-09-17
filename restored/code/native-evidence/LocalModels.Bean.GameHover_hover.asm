; LocalModels.Bean.GameHover_hover$$readImpl
; RVA 0x6A7EBD4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A7EBD4  stp      x30, x21, [sp, #-0x20]!
006A7EBD8  stp      x20, x19, [sp, #0x10]
006A7EBDC  adrp     x20, #0x959d000
006A7EBE0  adrp     x21, #0x8f38000
006A7EBE4  ldrb     w8, [x20, #0xf16]
006A7EBE8  ldr      x21, [x21, #0xb0]
006A7EBEC  mov      x19, x0
006A7EBF0  tbnz     w8, #0, #0x6a7ec08
006A7EBF4  adrp     x0, #0x8f38000
006A7EBF8  ldr      x0, [x0, #0xb0]
006A7EBFC  bl       #0x382bd14 ; 
006A7EC00  mov      w8, #1
006A7EC04  strb     w8, [x20, #0xf16]
006A7EC08  ldr      x1, [x21]
006A7EC0C  ldrb     w8, [x1, #0x53]
006A7EC10  tbnz     w8, #5, #0x6a7ec60
006A7EC14  mov      x0, x19
006A7EC18  mov      x1, xzr
006A7EC1C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7EC20  adrp     x21, #0x959e000
006A7EC24  ldrb     w8, [x21, #0x4ee]
006A7EC28  mov      w20, w0
006A7EC2C  cbnz     w8, #0x6a7ec44
006A7EC30  adrp     x0, #0x8f38000
006A7EC34  ldr      x0, [x0, #0x88]
006A7EC38  bl       #0x382bd14 ; 
006A7EC3C  mov      w8, #1
006A7EC40  strb     w8, [x21, #0x4ee]
006A7EC44  adrp     x8, #0x8f38000
006A7EC48  ldr      x8, [x8, #0x88]
006A7EC4C  ldr      x2, [x8]
006A7EC50  ldrb     w8, [x2, #0x53]
006A7EC54  tbnz     w8, #5, #0x6a7ec74
006A7EC58  str      w20, [x19, #0x20]
006A7EC5C  b        #0x6a7ec84 ; 
006A7EC60  ldr      x2, [x1, #0x60]
006A7EC64  mov      x0, x19
006A7EC68  ldp      x20, x19, [sp, #0x10]
006A7EC6C  ldp      x30, x21, [sp], #0x20
006A7EC70  br       x2
006A7EC74  ldr      x8, [x2, #0x60]
006A7EC78  mov      x0, x19
006A7EC7C  mov      w1, w20
006A7EC80  blr      x8
006A7EC84  mov      x0, x19
006A7EC88  mov      x1, xzr
006A7EC8C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7EC90  adrp     x21, #0x959e000
006A7EC94  ldrb     w8, [x21, #0x4ef]
006A7EC98  mov      w20, w0
006A7EC9C  cbnz     w8, #0x6a7ecb4
006A7ECA0  adrp     x0, #0x8f38000
006A7ECA4  ldr      x0, [x0, #0x98]
006A7ECA8  bl       #0x382bd14 ; 
006A7ECAC  mov      w8, #1
006A7ECB0  strb     w8, [x21, #0x4ef]
006A7ECB4  adrp     x8, #0x8f38000
006A7ECB8  ldr      x8, [x8, #0x98]
006A7ECBC  ldr      x2, [x8]
006A7ECC0  ldrb     w8, [x2, #0x53]
006A7ECC4  tbnz     w8, #5, #0x6a7ecd0
006A7ECC8  str      w20, [x19, #0x24]
006A7ECCC  b        #0x6a7ece0 ; 
006A7ECD0  ldr      x8, [x2, #0x60]
006A7ECD4  mov      x0, x19
006A7ECD8  mov      w1, w20
006A7ECDC  blr      x8
006A7ECE0  mov      x0, x19
006A7ECE4  mov      x1, xzr
006A7ECE8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7ECEC  adrp     x21, #0x959e000
006A7ECF0  ldrb     w8, [x21, #0x4f0]
006A7ECF4  mov      w20, w0
006A7ECF8  cbnz     w8, #0x6a7ed10
006A7ECFC  adrp     x0, #0x8f38000
006A7ED00  ldr      x0, [x0, #0xa8]
006A7ED04  bl       #0x382bd14 ; 
006A7ED08  mov      w8, #1
006A7ED0C  strb     w8, [x21, #0x4f0]
006A7ED10  adrp     x8, #0x8f38000
006A7ED14  ldr      x8, [x8, #0xa8]
006A7ED18  ldr      x2, [x8]
006A7ED1C  ldrb     w8, [x2, #0x53]
006A7ED20  tbnz     w8, #5, #0x6a7ed2c
006A7ED24  str      w20, [x19, #0x28]
006A7ED28  b        #0x6a7ed3c ; 
006A7ED2C  ldr      x8, [x2, #0x60]
006A7ED30  mov      x0, x19
006A7ED34  mov      w1, w20
006A7ED38  blr      x8
006A7ED3C  ldp      x20, x19, [sp, #0x10]
006A7ED40  mov      w0, #1
006A7ED44  ldp      x30, x21, [sp], #0x20
006A7ED48  ret      

