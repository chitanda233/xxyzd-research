; LocalModels.Bean.Event_EventBig$$readImpl
; RVA 0x6A7B118; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A7B118  stp      x30, x21, [sp, #-0x20]!
006A7B11C  stp      x20, x19, [sp, #0x10]
006A7B120  adrp     x20, #0x959d000
006A7B124  adrp     x21, #0x8f37000
006A7B128  ldrb     w8, [x20, #0xeb5]
006A7B12C  ldr      x21, [x21, #0xdf8]
006A7B130  mov      x19, x0
006A7B134  tbnz     w8, #0, #0x6a7b14c
006A7B138  adrp     x0, #0x8f37000
006A7B13C  ldr      x0, [x0, #0xdf8]
006A7B140  bl       #0x382bd14 ; 
006A7B144  mov      w8, #1
006A7B148  strb     w8, [x20, #0xeb5]
006A7B14C  ldr      x1, [x21]
006A7B150  ldrb     w8, [x1, #0x53]
006A7B154  tbnz     w8, #5, #0x6a7b1a4
006A7B158  mov      x0, x19
006A7B15C  mov      x1, xzr
006A7B160  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7B164  adrp     x21, #0x959e000
006A7B168  ldrb     w8, [x21, #0x4c6]
006A7B16C  mov      w20, w0
006A7B170  cbnz     w8, #0x6a7b188
006A7B174  adrp     x0, #0x8f37000
006A7B178  ldr      x0, [x0, #0xdb0]
006A7B17C  bl       #0x382bd14 ; 
006A7B180  mov      w8, #1
006A7B184  strb     w8, [x21, #0x4c6]
006A7B188  adrp     x8, #0x8f37000
006A7B18C  ldr      x8, [x8, #0xdb0]
006A7B190  ldr      x2, [x8]
006A7B194  ldrb     w8, [x2, #0x53]
006A7B198  tbnz     w8, #5, #0x6a7b1b8
006A7B19C  str      w20, [x19, #0x20]
006A7B1A0  b        #0x6a7b1c8 ; 
006A7B1A4  ldr      x2, [x1, #0x60]
006A7B1A8  mov      x0, x19
006A7B1AC  ldp      x20, x19, [sp, #0x10]
006A7B1B0  ldp      x30, x21, [sp], #0x20
006A7B1B4  br       x2
006A7B1B8  ldr      x8, [x2, #0x60]
006A7B1BC  mov      x0, x19
006A7B1C0  mov      w1, w20
006A7B1C4  blr      x8
006A7B1C8  mov      x0, x19
006A7B1CC  mov      x1, xzr
006A7B1D0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7B1D4  adrp     x21, #0x959e000
006A7B1D8  ldrb     w8, [x21, #0x4c7]
006A7B1DC  mov      x20, x0
006A7B1E0  cbnz     w8, #0x6a7b1f8
006A7B1E4  adrp     x0, #0x8f37000
006A7B1E8  ldr      x0, [x0, #0xdc0]
006A7B1EC  bl       #0x382bd14 ; 
006A7B1F0  mov      w8, #1
006A7B1F4  strb     w8, [x21, #0x4c7]
006A7B1F8  adrp     x8, #0x8f37000
006A7B1FC  ldr      x8, [x8, #0xdc0]
006A7B200  ldr      x2, [x8]
006A7B204  ldrb     w8, [x2, #0x53]
006A7B208  tbnz     w8, #5, #0x6a7b220
006A7B20C  mov      x0, x19
006A7B210  str      x20, [x0, #0x28]!
006A7B214  mov      x1, x20
006A7B218  bl       #0x382bcb8 ; 
006A7B21C  b        #0x6a7b230 ; 
006A7B220  ldr      x8, [x2, #0x60]
006A7B224  mov      x0, x19
006A7B228  mov      x1, x20
006A7B22C  blr      x8
006A7B230  mov      x0, x19
006A7B234  mov      x1, xzr
006A7B238  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7B23C  adrp     x21, #0x959e000
006A7B240  ldrb     w8, [x21, #0x4c8]
006A7B244  mov      w20, w0
006A7B248  cbnz     w8, #0x6a7b260
006A7B24C  adrp     x0, #0x8f37000
006A7B250  ldr      x0, [x0, #0xdd0]
006A7B254  bl       #0x382bd14 ; 
006A7B258  mov      w8, #1
006A7B25C  strb     w8, [x21, #0x4c8]
006A7B260  adrp     x8, #0x8f37000
006A7B264  ldr      x8, [x8, #0xdd0]
006A7B268  ldr      x2, [x8]
006A7B26C  ldrb     w8, [x2, #0x53]
006A7B270  tbnz     w8, #5, #0x6a7b27c
006A7B274  str      w20, [x19, #0x30]
006A7B278  b        #0x6a7b28c ; 
006A7B27C  ldr      x8, [x2, #0x60]
006A7B280  mov      x0, x19
006A7B284  mov      w1, w20
006A7B288  blr      x8
006A7B28C  mov      x0, x19
006A7B290  mov      x1, xzr
006A7B294  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7B298  adrp     x21, #0x959e000
006A7B29C  ldrb     w8, [x21, #0x4c9]
006A7B2A0  mov      w20, w0
006A7B2A4  cbnz     w8, #0x6a7b2bc
006A7B2A8  adrp     x0, #0x8f37000
006A7B2AC  ldr      x0, [x0, #0xde0]
006A7B2B0  bl       #0x382bd14 ; 
006A7B2B4  mov      w8, #1
006A7B2B8  strb     w8, [x21, #0x4c9]
006A7B2BC  adrp     x8, #0x8f37000
006A7B2C0  ldr      x8, [x8, #0xde0]
006A7B2C4  ldr      x2, [x8]
006A7B2C8  ldrb     w8, [x2, #0x53]
006A7B2CC  tbnz     w8, #5, #0x6a7b2d8
006A7B2D0  str      w20, [x19, #0x34]
006A7B2D4  b        #0x6a7b2e8 ; 
006A7B2D8  ldr      x8, [x2, #0x60]
006A7B2DC  mov      x0, x19
006A7B2E0  mov      w1, w20
006A7B2E4  blr      x8
006A7B2E8  mov      x0, x19
006A7B2EC  mov      x1, xzr
006A7B2F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7B2F4  adrp     x21, #0x959e000
006A7B2F8  ldrb     w8, [x21, #0x4ca]
006A7B2FC  mov      w20, w0
006A7B300  cbnz     w8, #0x6a7b318
006A7B304  adrp     x0, #0x8f37000
006A7B308  ldr      x0, [x0, #0xdf0]
006A7B30C  bl       #0x382bd14 ; 
006A7B310  mov      w8, #1
006A7B314  strb     w8, [x21, #0x4ca]
006A7B318  adrp     x8, #0x8f37000
006A7B31C  ldr      x8, [x8, #0xdf0]
006A7B320  ldr      x2, [x8]
006A7B324  ldrb     w8, [x2, #0x53]
006A7B328  tbnz     w8, #5, #0x6a7b334
006A7B32C  str      w20, [x19, #0x38]
006A7B330  b        #0x6a7b344 ; 
006A7B334  ldr      x8, [x2, #0x60]
006A7B338  mov      x0, x19
006A7B33C  mov      w1, w20
006A7B340  blr      x8
006A7B344  ldp      x20, x19, [sp, #0x10]
006A7B348  mov      w0, #1
006A7B34C  ldp      x30, x21, [sp], #0x20
006A7B350  ret      

