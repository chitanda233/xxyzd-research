; LocalModels.Bean.Guild_guildGiftLevel$$readImpl
; RVA 0x6A92240; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A92240  stp      x30, x21, [sp, #-0x20]!
006A92244  stp      x20, x19, [sp, #0x10]
006A92248  adrp     x20, #0x959e000
006A9224C  adrp     x21, #0x8f38000
006A92250  ldrb     w8, [x20, #0x120]
006A92254  ldr      x21, [x21, #0xf30]
006A92258  mov      x19, x0
006A9225C  tbnz     w8, #0, #0x6a92274
006A92260  adrp     x0, #0x8f38000
006A92264  ldr      x0, [x0, #0xf30]
006A92268  bl       #0x382bd14 ; 
006A9226C  mov      w8, #1
006A92270  strb     w8, [x20, #0x120]
006A92274  ldr      x1, [x21]
006A92278  ldrb     w8, [x1, #0x53]
006A9227C  tbnz     w8, #5, #0x6a922cc
006A92280  mov      x0, x19
006A92284  mov      x1, xzr
006A92288  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A9228C  adrp     x21, #0x959e000
006A92290  ldrb     w8, [x21, #0x5bc]
006A92294  mov      w20, w0
006A92298  cbnz     w8, #0x6a922b0
006A9229C  adrp     x0, #0x8f38000
006A922A0  ldr      x0, [x0, #0xef8]
006A922A4  bl       #0x382bd14 ; 
006A922A8  mov      w8, #1
006A922AC  strb     w8, [x21, #0x5bc]
006A922B0  adrp     x8, #0x8f38000
006A922B4  ldr      x8, [x8, #0xef8]
006A922B8  ldr      x2, [x8]
006A922BC  ldrb     w8, [x2, #0x53]
006A922C0  tbnz     w8, #5, #0x6a922e0
006A922C4  str      w20, [x19, #0x20]
006A922C8  b        #0x6a922f0 ; 
006A922CC  ldr      x2, [x1, #0x60]
006A922D0  mov      x0, x19
006A922D4  ldp      x20, x19, [sp, #0x10]
006A922D8  ldp      x30, x21, [sp], #0x20
006A922DC  br       x2
006A922E0  ldr      x8, [x2, #0x60]
006A922E4  mov      x0, x19
006A922E8  mov      w1, w20
006A922EC  blr      x8
006A922F0  mov      x0, x19
006A922F4  mov      x1, xzr
006A922F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A922FC  adrp     x21, #0x959e000
006A92300  ldrb     w8, [x21, #0x5bd]
006A92304  mov      w20, w0
006A92308  cbnz     w8, #0x6a92320
006A9230C  adrp     x0, #0x8f38000
006A92310  ldr      x0, [x0, #0xf08]
006A92314  bl       #0x382bd14 ; 
006A92318  mov      w8, #1
006A9231C  strb     w8, [x21, #0x5bd]
006A92320  adrp     x8, #0x8f38000
006A92324  ldr      x8, [x8, #0xf08]
006A92328  ldr      x2, [x8]
006A9232C  ldrb     w8, [x2, #0x53]
006A92330  tbnz     w8, #5, #0x6a9233c
006A92334  str      w20, [x19, #0x24]
006A92338  b        #0x6a9234c ; 
006A9233C  ldr      x8, [x2, #0x60]
006A92340  mov      x0, x19
006A92344  mov      w1, w20
006A92348  blr      x8
006A9234C  mov      x0, x19
006A92350  mov      x1, xzr
006A92354  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A92358  adrp     x21, #0x959e000
006A9235C  ldrb     w8, [x21, #0x5be]
006A92360  mov      w20, w0
006A92364  cbnz     w8, #0x6a9237c
006A92368  adrp     x0, #0x8f38000
006A9236C  ldr      x0, [x0, #0xf18]
006A92370  bl       #0x382bd14 ; 
006A92374  mov      w8, #1
006A92378  strb     w8, [x21, #0x5be]
006A9237C  adrp     x8, #0x8f38000
006A92380  ldr      x8, [x8, #0xf18]
006A92384  ldr      x2, [x8]
006A92388  ldrb     w8, [x2, #0x53]
006A9238C  tbnz     w8, #5, #0x6a92398
006A92390  str      w20, [x19, #0x28]
006A92394  b        #0x6a923a8 ; 
006A92398  ldr      x8, [x2, #0x60]
006A9239C  mov      x0, x19
006A923A0  mov      w1, w20
006A923A4  blr      x8
006A923A8  mov      x0, x19
006A923AC  mov      x1, xzr
006A923B0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A923B4  adrp     x21, #0x959e000
006A923B8  ldrb     w8, [x21, #0x5bf]
006A923BC  mov      x20, x0
006A923C0  cbnz     w8, #0x6a923d8
006A923C4  adrp     x0, #0x8f38000
006A923C8  ldr      x0, [x0, #0xf28]
006A923CC  bl       #0x382bd14 ; 
006A923D0  mov      w8, #1
006A923D4  strb     w8, [x21, #0x5bf]
006A923D8  adrp     x8, #0x8f38000
006A923DC  ldr      x8, [x8, #0xf28]
006A923E0  ldr      x2, [x8]
006A923E4  ldrb     w8, [x2, #0x53]
006A923E8  tbnz     w8, #5, #0x6a92400
006A923EC  str      x20, [x19, #0x30]!
006A923F0  mov      x0, x19
006A923F4  mov      x1, x20
006A923F8  bl       #0x382bcb8 ; 
006A923FC  b        #0x6a92410 ; 
006A92400  ldr      x8, [x2, #0x60]
006A92404  mov      x0, x19
006A92408  mov      x1, x20
006A9240C  blr      x8
006A92410  ldp      x20, x19, [sp, #0x10]
006A92414  mov      w0, #1
006A92418  ldp      x30, x21, [sp], #0x20
006A9241C  ret      

