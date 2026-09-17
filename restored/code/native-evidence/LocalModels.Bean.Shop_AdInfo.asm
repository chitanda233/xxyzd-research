; LocalModels.Bean.Shop_AdInfo$$readImpl
; RVA 0x6AEA114; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AEA114  stp      x30, x21, [sp, #-0x20]!
006AEA118  stp      x20, x19, [sp, #0x10]
006AEA11C  adrp     x20, #0x959e000
006AEA120  adrp     x21, #0x8f3d000
006AEA124  ldrb     w8, [x20, #0xdb5]
006AEA128  ldr      x21, [x21, #0x118]
006AEA12C  mov      x19, x0
006AEA130  tbnz     w8, #0, #0x6aea148
006AEA134  adrp     x0, #0x8f3d000
006AEA138  ldr      x0, [x0, #0x118]
006AEA13C  bl       #0x382bd14 ; 
006AEA140  mov      w8, #1
006AEA144  strb     w8, [x20, #0xdb5]
006AEA148  ldr      x1, [x21]
006AEA14C  ldrb     w8, [x1, #0x53]
006AEA150  tbnz     w8, #5, #0x6aea1a0
006AEA154  mov      x0, x19
006AEA158  mov      x1, xzr
006AEA15C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEA160  adrp     x21, #0x959f000
006AEA164  ldrb     w8, [x21, #0x1ff]
006AEA168  mov      w20, w0
006AEA16C  cbnz     w8, #0x6aea184
006AEA170  adrp     x0, #0x8f3d000
006AEA174  ldr      x0, [x0, #0xe0]
006AEA178  bl       #0x382bd14 ; 
006AEA17C  mov      w8, #1
006AEA180  strb     w8, [x21, #0x1ff]
006AEA184  adrp     x8, #0x8f3d000
006AEA188  ldr      x8, [x8, #0xe0]
006AEA18C  ldr      x2, [x8]
006AEA190  ldrb     w8, [x2, #0x53]
006AEA194  tbnz     w8, #5, #0x6aea1b4
006AEA198  str      w20, [x19, #0x20]
006AEA19C  b        #0x6aea1c4 ; 
006AEA1A0  ldr      x2, [x1, #0x60]
006AEA1A4  mov      x0, x19
006AEA1A8  ldp      x20, x19, [sp, #0x10]
006AEA1AC  ldp      x30, x21, [sp], #0x20
006AEA1B0  br       x2
006AEA1B4  ldr      x8, [x2, #0x60]
006AEA1B8  mov      x0, x19
006AEA1BC  mov      w1, w20
006AEA1C0  blr      x8
006AEA1C4  mov      x0, x19
006AEA1C8  mov      x1, xzr
006AEA1CC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AEA1D0  adrp     x21, #0x959f000
006AEA1D4  ldrb     w8, [x21, #0x200]
006AEA1D8  mov      x20, x0
006AEA1DC  cbnz     w8, #0x6aea1f4
006AEA1E0  adrp     x0, #0x8f3d000
006AEA1E4  ldr      x0, [x0, #0xf0]
006AEA1E8  bl       #0x382bd14 ; 
006AEA1EC  mov      w8, #1
006AEA1F0  strb     w8, [x21, #0x200]
006AEA1F4  adrp     x8, #0x8f3d000
006AEA1F8  ldr      x8, [x8, #0xf0]
006AEA1FC  ldr      x2, [x8]
006AEA200  ldrb     w8, [x2, #0x53]
006AEA204  tbnz     w8, #5, #0x6aea21c
006AEA208  mov      x0, x19
006AEA20C  str      x20, [x0, #0x28]!
006AEA210  mov      x1, x20
006AEA214  bl       #0x382bcb8 ; 
006AEA218  b        #0x6aea22c ; 
006AEA21C  ldr      x8, [x2, #0x60]
006AEA220  mov      x0, x19
006AEA224  mov      x1, x20
006AEA228  blr      x8
006AEA22C  mov      x0, x19
006AEA230  mov      x1, xzr
006AEA234  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEA238  adrp     x21, #0x959f000
006AEA23C  ldrb     w8, [x21, #0x201]
006AEA240  mov      w20, w0
006AEA244  cbnz     w8, #0x6aea25c
006AEA248  adrp     x0, #0x8f3d000
006AEA24C  ldr      x0, [x0, #0x100]
006AEA250  bl       #0x382bd14 ; 
006AEA254  mov      w8, #1
006AEA258  strb     w8, [x21, #0x201]
006AEA25C  adrp     x8, #0x8f3d000
006AEA260  ldr      x8, [x8, #0x100]
006AEA264  ldr      x2, [x8]
006AEA268  ldrb     w8, [x2, #0x53]
006AEA26C  tbnz     w8, #5, #0x6aea278
006AEA270  str      w20, [x19, #0x30]
006AEA274  b        #0x6aea288 ; 
006AEA278  ldr      x8, [x2, #0x60]
006AEA27C  mov      x0, x19
006AEA280  mov      w1, w20
006AEA284  blr      x8
006AEA288  mov      x0, x19
006AEA28C  mov      x1, xzr
006AEA290  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEA294  adrp     x21, #0x959f000
006AEA298  ldrb     w8, [x21, #0x202]
006AEA29C  mov      w20, w0
006AEA2A0  cbnz     w8, #0x6aea2b8
006AEA2A4  adrp     x0, #0x8f3d000
006AEA2A8  ldr      x0, [x0, #0x110]
006AEA2AC  bl       #0x382bd14 ; 
006AEA2B0  mov      w8, #1
006AEA2B4  strb     w8, [x21, #0x202]
006AEA2B8  adrp     x8, #0x8f3d000
006AEA2BC  ldr      x8, [x8, #0x110]
006AEA2C0  ldr      x2, [x8]
006AEA2C4  ldrb     w8, [x2, #0x53]
006AEA2C8  tbnz     w8, #5, #0x6aea2d4
006AEA2CC  str      w20, [x19, #0x34]
006AEA2D0  b        #0x6aea2e4 ; 
006AEA2D4  ldr      x8, [x2, #0x60]
006AEA2D8  mov      x0, x19
006AEA2DC  mov      w1, w20
006AEA2E0  blr      x8
006AEA2E4  ldp      x20, x19, [sp, #0x10]
006AEA2E8  mov      w0, #1
006AEA2EC  ldp      x30, x21, [sp], #0x20
006AEA2F0  ret      

