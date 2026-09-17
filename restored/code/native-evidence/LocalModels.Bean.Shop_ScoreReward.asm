; LocalModels.Bean.Shop_ScoreReward$$readImpl
; RVA 0x6AEE24C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AEE24C  stp      x30, x21, [sp, #-0x20]!
006AEE250  stp      x20, x19, [sp, #0x10]
006AEE254  adrp     x20, #0x959e000
006AEE258  adrp     x21, #0x8f3d000
006AEE25C  ldrb     w8, [x20, #0xe23]
006AEE260  ldr      x21, [x21, #0x448]
006AEE264  mov      x19, x0
006AEE268  tbnz     w8, #0, #0x6aee280
006AEE26C  adrp     x0, #0x8f3d000
006AEE270  ldr      x0, [x0, #0x448]
006AEE274  bl       #0x382bd14 ; 
006AEE278  mov      w8, #1
006AEE27C  strb     w8, [x20, #0xe23]
006AEE280  ldr      x1, [x21]
006AEE284  ldrb     w8, [x1, #0x53]
006AEE288  tbnz     w8, #5, #0x6aee2d8
006AEE28C  mov      x0, x19
006AEE290  mov      x1, xzr
006AEE294  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEE298  adrp     x21, #0x959f000
006AEE29C  ldrb     w8, [x21, #0x22b]
006AEE2A0  mov      w20, w0
006AEE2A4  cbnz     w8, #0x6aee2bc
006AEE2A8  adrp     x0, #0x8f3d000
006AEE2AC  ldr      x0, [x0, #0x420]
006AEE2B0  bl       #0x382bd14 ; 
006AEE2B4  mov      w8, #1
006AEE2B8  strb     w8, [x21, #0x22b]
006AEE2BC  adrp     x8, #0x8f3d000
006AEE2C0  ldr      x8, [x8, #0x420]
006AEE2C4  ldr      x2, [x8]
006AEE2C8  ldrb     w8, [x2, #0x53]
006AEE2CC  tbnz     w8, #5, #0x6aee2ec
006AEE2D0  str      w20, [x19, #0x20]
006AEE2D4  b        #0x6aee2fc ; 
006AEE2D8  ldr      x2, [x1, #0x60]
006AEE2DC  mov      x0, x19
006AEE2E0  ldp      x20, x19, [sp, #0x10]
006AEE2E4  ldp      x30, x21, [sp], #0x20
006AEE2E8  br       x2
006AEE2EC  ldr      x8, [x2, #0x60]
006AEE2F0  mov      x0, x19
006AEE2F4  mov      w1, w20
006AEE2F8  blr      x8
006AEE2FC  mov      x0, x19
006AEE300  mov      x1, xzr
006AEE304  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEE308  adrp     x21, #0x959f000
006AEE30C  ldrb     w8, [x21, #0x22c]
006AEE310  mov      w20, w0
006AEE314  cbnz     w8, #0x6aee32c
006AEE318  adrp     x0, #0x8f3d000
006AEE31C  ldr      x0, [x0, #0x430]
006AEE320  bl       #0x382bd14 ; 
006AEE324  mov      w8, #1
006AEE328  strb     w8, [x21, #0x22c]
006AEE32C  adrp     x8, #0x8f3d000
006AEE330  ldr      x8, [x8, #0x430]
006AEE334  ldr      x2, [x8]
006AEE338  ldrb     w8, [x2, #0x53]
006AEE33C  tbnz     w8, #5, #0x6aee348
006AEE340  str      w20, [x19, #0x24]
006AEE344  b        #0x6aee358 ; 
006AEE348  ldr      x8, [x2, #0x60]
006AEE34C  mov      x0, x19
006AEE350  mov      w1, w20
006AEE354  blr      x8
006AEE358  mov      x0, x19
006AEE35C  mov      x1, xzr
006AEE360  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AEE364  adrp     x21, #0x959f000
006AEE368  ldrb     w8, [x21, #0x22d]
006AEE36C  mov      x20, x0
006AEE370  cbnz     w8, #0x6aee388
006AEE374  adrp     x0, #0x8f3d000
006AEE378  ldr      x0, [x0, #0x440]
006AEE37C  bl       #0x382bd14 ; 
006AEE380  mov      w8, #1
006AEE384  strb     w8, [x21, #0x22d]
006AEE388  adrp     x8, #0x8f3d000
006AEE38C  ldr      x8, [x8, #0x440]
006AEE390  ldr      x2, [x8]
006AEE394  ldrb     w8, [x2, #0x53]
006AEE398  tbnz     w8, #5, #0x6aee3b0
006AEE39C  str      x20, [x19, #0x28]!
006AEE3A0  mov      x0, x19
006AEE3A4  mov      x1, x20
006AEE3A8  bl       #0x382bcb8 ; 
006AEE3AC  b        #0x6aee3c0 ; 
006AEE3B0  ldr      x8, [x2, #0x60]
006AEE3B4  mov      x0, x19
006AEE3B8  mov      x1, x20
006AEE3BC  blr      x8
006AEE3C0  ldp      x20, x19, [sp, #0x10]
006AEE3C4  mov      w0, #1
006AEE3C8  ldp      x30, x21, [sp], #0x20
006AEE3CC  ret      

