; LocalModels.Bean.Event_Activity$$readImpl
; RVA 0x6A7A168; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A7A168  stp      x30, x21, [sp, #-0x20]!
006A7A16C  stp      x20, x19, [sp, #0x10]
006A7A170  adrp     x20, #0x959d000
006A7A174  adrp     x21, #0x8f37000
006A7A178  ldrb     w8, [x20, #0xe9b]
006A7A17C  ldr      x21, [x21, #0xd38]
006A7A180  mov      x19, x0
006A7A184  tbnz     w8, #0, #0x6a7a19c
006A7A188  adrp     x0, #0x8f37000
006A7A18C  ldr      x0, [x0, #0xd38]
006A7A190  bl       #0x382bd14 ; 
006A7A194  mov      w8, #1
006A7A198  strb     w8, [x20, #0xe9b]
006A7A19C  ldr      x1, [x21]
006A7A1A0  ldrb     w8, [x1, #0x53]
006A7A1A4  tbnz     w8, #5, #0x6a7a1f4
006A7A1A8  mov      x0, x19
006A7A1AC  mov      x1, xzr
006A7A1B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7A1B4  adrp     x21, #0x959e000
006A7A1B8  ldrb     w8, [x21, #0x4bb]
006A7A1BC  mov      w20, w0
006A7A1C0  cbnz     w8, #0x6a7a1d8
006A7A1C4  adrp     x0, #0x8f37000
006A7A1C8  ldr      x0, [x0, #0xce0]
006A7A1CC  bl       #0x382bd14 ; 
006A7A1D0  mov      w8, #1
006A7A1D4  strb     w8, [x21, #0x4bb]
006A7A1D8  adrp     x8, #0x8f37000
006A7A1DC  ldr      x8, [x8, #0xce0]
006A7A1E0  ldr      x2, [x8]
006A7A1E4  ldrb     w8, [x2, #0x53]
006A7A1E8  tbnz     w8, #5, #0x6a7a208
006A7A1EC  str      w20, [x19, #0x20]
006A7A1F0  b        #0x6a7a218 ; 
006A7A1F4  ldr      x2, [x1, #0x60]
006A7A1F8  mov      x0, x19
006A7A1FC  ldp      x20, x19, [sp, #0x10]
006A7A200  ldp      x30, x21, [sp], #0x20
006A7A204  br       x2
006A7A208  ldr      x8, [x2, #0x60]
006A7A20C  mov      x0, x19
006A7A210  mov      w1, w20
006A7A214  blr      x8
006A7A218  mov      x0, x19
006A7A21C  mov      x1, xzr
006A7A220  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7A224  adrp     x21, #0x959e000
006A7A228  ldrb     w8, [x21, #0x4bc]
006A7A22C  mov      x20, x0
006A7A230  cbnz     w8, #0x6a7a248
006A7A234  adrp     x0, #0x8f37000
006A7A238  ldr      x0, [x0, #0xcf0]
006A7A23C  bl       #0x382bd14 ; 
006A7A240  mov      w8, #1
006A7A244  strb     w8, [x21, #0x4bc]
006A7A248  adrp     x8, #0x8f37000
006A7A24C  ldr      x8, [x8, #0xcf0]
006A7A250  ldr      x2, [x8]
006A7A254  ldrb     w8, [x2, #0x53]
006A7A258  tbnz     w8, #5, #0x6a7a270
006A7A25C  mov      x0, x19
006A7A260  str      x20, [x0, #0x28]!
006A7A264  mov      x1, x20
006A7A268  bl       #0x382bcb8 ; 
006A7A26C  b        #0x6a7a280 ; 
006A7A270  ldr      x8, [x2, #0x60]
006A7A274  mov      x0, x19
006A7A278  mov      x1, x20
006A7A27C  blr      x8
006A7A280  mov      x0, x19
006A7A284  mov      x1, xzr
006A7A288  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7A28C  adrp     x21, #0x959e000
006A7A290  ldrb     w8, [x21, #0x4bd]
006A7A294  mov      w20, w0
006A7A298  cbnz     w8, #0x6a7a2b0
006A7A29C  adrp     x0, #0x8f37000
006A7A2A0  ldr      x0, [x0, #0xd00]
006A7A2A4  bl       #0x382bd14 ; 
006A7A2A8  mov      w8, #1
006A7A2AC  strb     w8, [x21, #0x4bd]
006A7A2B0  adrp     x8, #0x8f37000
006A7A2B4  ldr      x8, [x8, #0xd00]
006A7A2B8  ldr      x2, [x8]
006A7A2BC  ldrb     w8, [x2, #0x53]
006A7A2C0  tbnz     w8, #5, #0x6a7a2cc
006A7A2C4  str      w20, [x19, #0x30]
006A7A2C8  b        #0x6a7a2dc ; 
006A7A2CC  ldr      x8, [x2, #0x60]
006A7A2D0  mov      x0, x19
006A7A2D4  mov      w1, w20
006A7A2D8  blr      x8
006A7A2DC  mov      x0, x19
006A7A2E0  mov      x1, xzr
006A7A2E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7A2E8  adrp     x21, #0x959e000
006A7A2EC  ldrb     w8, [x21, #0x4be]
006A7A2F0  mov      w20, w0
006A7A2F4  cbnz     w8, #0x6a7a30c
006A7A2F8  adrp     x0, #0x8f37000
006A7A2FC  ldr      x0, [x0, #0xd10]
006A7A300  bl       #0x382bd14 ; 
006A7A304  mov      w8, #1
006A7A308  strb     w8, [x21, #0x4be]
006A7A30C  adrp     x8, #0x8f37000
006A7A310  ldr      x8, [x8, #0xd10]
006A7A314  ldr      x2, [x8]
006A7A318  ldrb     w8, [x2, #0x53]
006A7A31C  tbnz     w8, #5, #0x6a7a328
006A7A320  str      w20, [x19, #0x34]
006A7A324  b        #0x6a7a338 ; 
006A7A328  ldr      x8, [x2, #0x60]
006A7A32C  mov      x0, x19
006A7A330  mov      w1, w20
006A7A334  blr      x8
006A7A338  mov      x0, x19
006A7A33C  mov      x1, xzr
006A7A340  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7A344  adrp     x21, #0x959e000
006A7A348  ldrb     w8, [x21, #0x4bf]
006A7A34C  mov      x20, x0
006A7A350  cbnz     w8, #0x6a7a368
006A7A354  adrp     x0, #0x8f37000
006A7A358  ldr      x0, [x0, #0xd20]
006A7A35C  bl       #0x382bd14 ; 
006A7A360  mov      w8, #1
006A7A364  strb     w8, [x21, #0x4bf]
006A7A368  adrp     x8, #0x8f37000
006A7A36C  ldr      x8, [x8, #0xd20]
006A7A370  ldr      x2, [x8]
006A7A374  ldrb     w8, [x2, #0x53]
006A7A378  tbnz     w8, #5, #0x6a7a390
006A7A37C  mov      x0, x19
006A7A380  str      x20, [x0, #0x38]!
006A7A384  mov      x1, x20
006A7A388  bl       #0x382bcb8 ; 
006A7A38C  b        #0x6a7a3a0 ; 
006A7A390  ldr      x8, [x2, #0x60]
006A7A394  mov      x0, x19
006A7A398  mov      x1, x20
006A7A39C  blr      x8
006A7A3A0  mov      x0, x19
006A7A3A4  mov      x1, xzr
006A7A3A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7A3AC  adrp     x21, #0x959e000
006A7A3B0  ldrb     w8, [x21, #0x4c0]
006A7A3B4  mov      w20, w0
006A7A3B8  cbnz     w8, #0x6a7a3d0
006A7A3BC  adrp     x0, #0x8f37000
006A7A3C0  ldr      x0, [x0, #0xd30]
006A7A3C4  bl       #0x382bd14 ; 
006A7A3C8  mov      w8, #1
006A7A3CC  strb     w8, [x21, #0x4c0]
006A7A3D0  adrp     x8, #0x8f37000
006A7A3D4  ldr      x8, [x8, #0xd30]
006A7A3D8  ldr      x2, [x8]
006A7A3DC  ldrb     w8, [x2, #0x53]
006A7A3E0  tbnz     w8, #5, #0x6a7a3ec
006A7A3E4  str      w20, [x19, #0x40]
006A7A3E8  b        #0x6a7a3fc ; 
006A7A3EC  ldr      x8, [x2, #0x60]
006A7A3F0  mov      x0, x19
006A7A3F4  mov      w1, w20
006A7A3F8  blr      x8
006A7A3FC  ldp      x20, x19, [sp, #0x10]
006A7A400  mov      w0, #1
006A7A404  ldp      x30, x21, [sp], #0x20
006A7A408  ret      

