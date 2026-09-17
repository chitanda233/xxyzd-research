; LocalModels.Bean.EventDiving_DiveSmallGrid$$readImpl
; RVA 0x6A6FBC4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6FBC4  stp      x30, x21, [sp, #-0x20]!
006A6FBC8  stp      x20, x19, [sp, #0x10]
006A6FBCC  adrp     x20, #0x959d000
006A6FBD0  adrp     x21, #0x8f37000
006A6FBD4  ldrb     w8, [x20, #0xd86]
006A6FBD8  ldr      x21, [x21, #0x508]
006A6FBDC  mov      x19, x0
006A6FBE0  tbnz     w8, #0, #0x6a6fbf8
006A6FBE4  adrp     x0, #0x8f37000
006A6FBE8  ldr      x0, [x0, #0x508]
006A6FBEC  bl       #0x382bd14 ; 
006A6FBF0  mov      w8, #1
006A6FBF4  strb     w8, [x20, #0xd86]
006A6FBF8  ldr      x1, [x21]
006A6FBFC  ldrb     w8, [x1, #0x53]
006A6FC00  tbnz     w8, #5, #0x6a6fc50
006A6FC04  mov      x0, x19
006A6FC08  mov      x1, xzr
006A6FC0C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6FC10  adrp     x21, #0x959e000
006A6FC14  ldrb     w8, [x21, #0x44b]
006A6FC18  mov      w20, w0
006A6FC1C  cbnz     w8, #0x6a6fc34
006A6FC20  adrp     x0, #0x8f37000
006A6FC24  ldr      x0, [x0, #0x4f0]
006A6FC28  bl       #0x382bd14 ; 
006A6FC2C  mov      w8, #1
006A6FC30  strb     w8, [x21, #0x44b]
006A6FC34  adrp     x8, #0x8f37000
006A6FC38  ldr      x8, [x8, #0x4f0]
006A6FC3C  ldr      x2, [x8]
006A6FC40  ldrb     w8, [x2, #0x53]
006A6FC44  tbnz     w8, #5, #0x6a6fc64
006A6FC48  str      w20, [x19, #0x20]
006A6FC4C  b        #0x6a6fc74 ; 
006A6FC50  ldr      x2, [x1, #0x60]
006A6FC54  mov      x0, x19
006A6FC58  ldp      x20, x19, [sp, #0x10]
006A6FC5C  ldp      x30, x21, [sp], #0x20
006A6FC60  br       x2
006A6FC64  ldr      x8, [x2, #0x60]
006A6FC68  mov      x0, x19
006A6FC6C  mov      w1, w20
006A6FC70  blr      x8
006A6FC74  mov      x0, x19
006A6FC78  mov      x1, xzr
006A6FC7C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6FC80  adrp     x21, #0x959e000
006A6FC84  ldrb     w8, [x21, #0x44c]
006A6FC88  mov      x20, x0
006A6FC8C  cbnz     w8, #0x6a6fca4
006A6FC90  adrp     x0, #0x8f37000
006A6FC94  ldr      x0, [x0, #0x500]
006A6FC98  bl       #0x382bd14 ; 
006A6FC9C  mov      w8, #1
006A6FCA0  strb     w8, [x21, #0x44c]
006A6FCA4  adrp     x8, #0x8f37000
006A6FCA8  ldr      x8, [x8, #0x500]
006A6FCAC  ldr      x2, [x8]
006A6FCB0  ldrb     w8, [x2, #0x53]
006A6FCB4  tbnz     w8, #5, #0x6a6fccc
006A6FCB8  str      x20, [x19, #0x28]!
006A6FCBC  mov      x0, x19
006A6FCC0  mov      x1, x20
006A6FCC4  bl       #0x382bcb8 ; 
006A6FCC8  b        #0x6a6fcdc ; 
006A6FCCC  ldr      x8, [x2, #0x60]
006A6FCD0  mov      x0, x19
006A6FCD4  mov      x1, x20
006A6FCD8  blr      x8
006A6FCDC  ldp      x20, x19, [sp, #0x10]
006A6FCE0  mov      w0, #1
006A6FCE4  ldp      x30, x21, [sp], #0x20
006A6FCE8  ret      

