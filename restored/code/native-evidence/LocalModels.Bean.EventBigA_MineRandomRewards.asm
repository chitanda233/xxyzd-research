; LocalModels.Bean.EventBigA_MineRandomRewards$$readImpl
; RVA 0x6A6A144; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6A144  stp      x30, x21, [sp, #-0x20]!
006A6A148  stp      x20, x19, [sp, #0x10]
006A6A14C  adrp     x20, #0x959d000
006A6A150  adrp     x21, #0x8f37000
006A6A154  ldrb     w8, [x20, #0xcef]
006A6A158  ldr      x21, [x21, #0xa8]
006A6A15C  mov      x19, x0
006A6A160  tbnz     w8, #0, #0x6a6a178
006A6A164  adrp     x0, #0x8f37000
006A6A168  ldr      x0, [x0, #0xa8]
006A6A16C  bl       #0x382bd14 ; 
006A6A170  mov      w8, #1
006A6A174  strb     w8, [x20, #0xcef]
006A6A178  ldr      x1, [x21]
006A6A17C  ldrb     w8, [x1, #0x53]
006A6A180  tbnz     w8, #5, #0x6a6a1d0
006A6A184  mov      x0, x19
006A6A188  mov      x1, xzr
006A6A18C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6A190  adrp     x21, #0x959e000
006A6A194  ldrb     w8, [x21, #0x40f]
006A6A198  mov      w20, w0
006A6A19C  cbnz     w8, #0x6a6a1b4
006A6A1A0  adrp     x0, #0x8f37000
006A6A1A4  ldr      x0, [x0, #0x80]
006A6A1A8  bl       #0x382bd14 ; 
006A6A1AC  mov      w8, #1
006A6A1B0  strb     w8, [x21, #0x40f]
006A6A1B4  adrp     x8, #0x8f37000
006A6A1B8  ldr      x8, [x8, #0x80]
006A6A1BC  ldr      x2, [x8]
006A6A1C0  ldrb     w8, [x2, #0x53]
006A6A1C4  tbnz     w8, #5, #0x6a6a1e4
006A6A1C8  str      w20, [x19, #0x20]
006A6A1CC  b        #0x6a6a1f4 ; 
006A6A1D0  ldr      x2, [x1, #0x60]
006A6A1D4  mov      x0, x19
006A6A1D8  ldp      x20, x19, [sp, #0x10]
006A6A1DC  ldp      x30, x21, [sp], #0x20
006A6A1E0  br       x2
006A6A1E4  ldr      x8, [x2, #0x60]
006A6A1E8  mov      x0, x19
006A6A1EC  mov      w1, w20
006A6A1F0  blr      x8
006A6A1F4  mov      x0, x19
006A6A1F8  mov      x1, xzr
006A6A1FC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A6A200  adrp     x21, #0x959e000
006A6A204  ldrb     w8, [x21, #0x410]
006A6A208  mov      x20, x0
006A6A20C  cbnz     w8, #0x6a6a224
006A6A210  adrp     x0, #0x8f37000
006A6A214  ldr      x0, [x0, #0x90]
006A6A218  bl       #0x382bd14 ; 
006A6A21C  mov      w8, #1
006A6A220  strb     w8, [x21, #0x410]
006A6A224  adrp     x8, #0x8f37000
006A6A228  ldr      x8, [x8, #0x90]
006A6A22C  ldr      x2, [x8]
006A6A230  ldrb     w8, [x2, #0x53]
006A6A234  tbnz     w8, #5, #0x6a6a24c
006A6A238  mov      x0, x19
006A6A23C  str      x20, [x0, #0x28]!
006A6A240  mov      x1, x20
006A6A244  bl       #0x382bcb8 ; 
006A6A248  b        #0x6a6a25c ; 
006A6A24C  ldr      x8, [x2, #0x60]
006A6A250  mov      x0, x19
006A6A254  mov      x1, x20
006A6A258  blr      x8
006A6A25C  mov      x0, x19
006A6A260  mov      x1, xzr
006A6A264  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A6A268  adrp     x21, #0x959e000
006A6A26C  ldrb     w8, [x21, #0x411]
006A6A270  mov      x20, x0
006A6A274  cbnz     w8, #0x6a6a28c
006A6A278  adrp     x0, #0x8f37000
006A6A27C  ldr      x0, [x0, #0xa0]
006A6A280  bl       #0x382bd14 ; 
006A6A284  mov      w8, #1
006A6A288  strb     w8, [x21, #0x411]
006A6A28C  adrp     x8, #0x8f37000
006A6A290  ldr      x8, [x8, #0xa0]
006A6A294  ldr      x2, [x8]
006A6A298  ldrb     w8, [x2, #0x53]
006A6A29C  tbnz     w8, #5, #0x6a6a2b4
006A6A2A0  str      x20, [x19, #0x30]!
006A6A2A4  mov      x0, x19
006A6A2A8  mov      x1, x20
006A6A2AC  bl       #0x382bcb8 ; 
006A6A2B0  b        #0x6a6a2c4 ; 
006A6A2B4  ldr      x8, [x2, #0x60]
006A6A2B8  mov      x0, x19
006A6A2BC  mov      x1, x20
006A6A2C0  blr      x8
006A6A2C4  ldp      x20, x19, [sp, #0x10]
006A6A2C8  mov      w0, #1
006A6A2CC  ldp      x30, x21, [sp], #0x20
006A6A2D0  ret      

