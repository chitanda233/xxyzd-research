; LocalModels.Bean.EventBigA_MineTreasure$$readImpl
; RVA 0x6A6B1BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6B1BC  stp      x30, x21, [sp, #-0x20]!
006A6B1C0  stp      x20, x19, [sp, #0x10]
006A6B1C4  adrp     x20, #0x959d000
006A6B1C8  adrp     x21, #0x8f37000
006A6B1CC  ldrb     w8, [x20, #0xd0c]
006A6B1D0  ldr      x21, [x21, #0x178]
006A6B1D4  mov      x19, x0
006A6B1D8  tbnz     w8, #0, #0x6a6b1f0
006A6B1DC  adrp     x0, #0x8f37000
006A6B1E0  ldr      x0, [x0, #0x178]
006A6B1E4  bl       #0x382bd14 ; 
006A6B1E8  mov      w8, #1
006A6B1EC  strb     w8, [x20, #0xd0c]
006A6B1F0  ldr      x1, [x21]
006A6B1F4  ldrb     w8, [x1, #0x53]
006A6B1F8  tbnz     w8, #5, #0x6a6b248
006A6B1FC  mov      x0, x19
006A6B200  mov      x1, xzr
006A6B204  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6B208  adrp     x21, #0x959e000
006A6B20C  ldrb     w8, [x21, #0x418]
006A6B210  mov      w20, w0
006A6B214  cbnz     w8, #0x6a6b22c
006A6B218  adrp     x0, #0x8f37000
006A6B21C  ldr      x0, [x0, #0x140]
006A6B220  bl       #0x382bd14 ; 
006A6B224  mov      w8, #1
006A6B228  strb     w8, [x21, #0x418]
006A6B22C  adrp     x8, #0x8f37000
006A6B230  ldr      x8, [x8, #0x140]
006A6B234  ldr      x2, [x8]
006A6B238  ldrb     w8, [x2, #0x53]
006A6B23C  tbnz     w8, #5, #0x6a6b25c
006A6B240  str      w20, [x19, #0x20]
006A6B244  b        #0x6a6b26c ; 
006A6B248  ldr      x2, [x1, #0x60]
006A6B24C  mov      x0, x19
006A6B250  ldp      x20, x19, [sp, #0x10]
006A6B254  ldp      x30, x21, [sp], #0x20
006A6B258  br       x2
006A6B25C  ldr      x8, [x2, #0x60]
006A6B260  mov      x0, x19
006A6B264  mov      w1, w20
006A6B268  blr      x8
006A6B26C  mov      x0, x19
006A6B270  mov      x1, xzr
006A6B274  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6B278  adrp     x21, #0x959e000
006A6B27C  ldrb     w8, [x21, #0x419]
006A6B280  mov      x20, x0
006A6B284  cbnz     w8, #0x6a6b29c
006A6B288  adrp     x0, #0x8f37000
006A6B28C  ldr      x0, [x0, #0x150]
006A6B290  bl       #0x382bd14 ; 
006A6B294  mov      w8, #1
006A6B298  strb     w8, [x21, #0x419]
006A6B29C  adrp     x8, #0x8f37000
006A6B2A0  ldr      x8, [x8, #0x150]
006A6B2A4  ldr      x2, [x8]
006A6B2A8  ldrb     w8, [x2, #0x53]
006A6B2AC  tbnz     w8, #5, #0x6a6b2c4
006A6B2B0  mov      x0, x19
006A6B2B4  str      x20, [x0, #0x28]!
006A6B2B8  mov      x1, x20
006A6B2BC  bl       #0x382bcb8 ; 
006A6B2C0  b        #0x6a6b2d4 ; 
006A6B2C4  ldr      x8, [x2, #0x60]
006A6B2C8  mov      x0, x19
006A6B2CC  mov      x1, x20
006A6B2D0  blr      x8
006A6B2D4  mov      x0, x19
006A6B2D8  mov      x1, xzr
006A6B2DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6B2E0  adrp     x21, #0x959e000
006A6B2E4  ldrb     w8, [x21, #0x41a]
006A6B2E8  mov      w20, w0
006A6B2EC  cbnz     w8, #0x6a6b304
006A6B2F0  adrp     x0, #0x8f37000
006A6B2F4  ldr      x0, [x0, #0x160]
006A6B2F8  bl       #0x382bd14 ; 
006A6B2FC  mov      w8, #1
006A6B300  strb     w8, [x21, #0x41a]
006A6B304  adrp     x8, #0x8f37000
006A6B308  ldr      x8, [x8, #0x160]
006A6B30C  ldr      x2, [x8]
006A6B310  ldrb     w8, [x2, #0x53]
006A6B314  tbnz     w8, #5, #0x6a6b320
006A6B318  str      w20, [x19, #0x30]
006A6B31C  b        #0x6a6b330 ; 
006A6B320  ldr      x8, [x2, #0x60]
006A6B324  mov      x0, x19
006A6B328  mov      w1, w20
006A6B32C  blr      x8
006A6B330  mov      x0, x19
006A6B334  mov      x1, xzr
006A6B338  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A6B33C  adrp     x21, #0x959e000
006A6B340  ldrb     w8, [x21, #0x41b]
006A6B344  mov      x20, x0
006A6B348  cbnz     w8, #0x6a6b360
006A6B34C  adrp     x0, #0x8f37000
006A6B350  ldr      x0, [x0, #0x170]
006A6B354  bl       #0x382bd14 ; 
006A6B358  mov      w8, #1
006A6B35C  strb     w8, [x21, #0x41b]
006A6B360  adrp     x8, #0x8f37000
006A6B364  ldr      x8, [x8, #0x170]
006A6B368  ldr      x2, [x8]
006A6B36C  ldrb     w8, [x2, #0x53]
006A6B370  tbnz     w8, #5, #0x6a6b388
006A6B374  str      x20, [x19, #0x38]!
006A6B378  mov      x0, x19
006A6B37C  mov      x1, x20
006A6B380  bl       #0x382bcb8 ; 
006A6B384  b        #0x6a6b398 ; 
006A6B388  ldr      x8, [x2, #0x60]
006A6B38C  mov      x0, x19
006A6B390  mov      x1, x20
006A6B394  blr      x8
006A6B398  ldp      x20, x19, [sp, #0x10]
006A6B39C  mov      w0, #1
006A6B3A0  ldp      x30, x21, [sp], #0x20
006A6B3A4  ret      

