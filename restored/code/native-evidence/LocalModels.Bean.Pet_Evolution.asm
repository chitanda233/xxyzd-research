; LocalModels.Bean.Pet_Evolution$$readImpl
; RVA 0x6ACE20C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ACE20C  stp      x30, x21, [sp, #-0x20]!
006ACE210  stp      x20, x19, [sp, #0x10]
006ACE214  adrp     x20, #0x959e000
006ACE218  adrp     x21, #0x8f3b000
006ACE21C  ldrb     w8, [x20, #0xad4]
006ACE220  ldr      x21, [x21, #0xc10]
006ACE224  mov      x19, x0
006ACE228  tbnz     w8, #0, #0x6ace240
006ACE22C  adrp     x0, #0x8f3b000
006ACE230  ldr      x0, [x0, #0xc10]
006ACE234  bl       #0x382bd14 ; 
006ACE238  mov      w8, #1
006ACE23C  strb     w8, [x20, #0xad4]
006ACE240  ldr      x1, [x21]
006ACE244  ldrb     w8, [x1, #0x53]
006ACE248  tbnz     w8, #5, #0x6ace298
006ACE24C  mov      x0, x19
006ACE250  mov      x1, xzr
006ACE254  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACE258  adrp     x21, #0x959f000
006ACE25C  ldrb     w8, [x21, #0xcb]
006ACE260  mov      w20, w0
006ACE264  cbnz     w8, #0x6ace27c
006ACE268  adrp     x0, #0x8f3b000
006ACE26C  ldr      x0, [x0, #0xbf8]
006ACE270  bl       #0x382bd14 ; 
006ACE274  mov      w8, #1
006ACE278  strb     w8, [x21, #0xcb]
006ACE27C  adrp     x8, #0x8f3b000
006ACE280  ldr      x8, [x8, #0xbf8]
006ACE284  ldr      x2, [x8]
006ACE288  ldrb     w8, [x2, #0x53]
006ACE28C  tbnz     w8, #5, #0x6ace2ac
006ACE290  str      w20, [x19, #0x20]
006ACE294  b        #0x6ace2bc ; 
006ACE298  ldr      x2, [x1, #0x60]
006ACE29C  mov      x0, x19
006ACE2A0  ldp      x20, x19, [sp, #0x10]
006ACE2A4  ldp      x30, x21, [sp], #0x20
006ACE2A8  br       x2
006ACE2AC  ldr      x8, [x2, #0x60]
006ACE2B0  mov      x0, x19
006ACE2B4  mov      w1, w20
006ACE2B8  blr      x8
006ACE2BC  mov      x0, x19
006ACE2C0  mov      x1, xzr
006ACE2C4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ACE2C8  adrp     x21, #0x959f000
006ACE2CC  ldrb     w8, [x21, #0xcc]
006ACE2D0  mov      x20, x0
006ACE2D4  cbnz     w8, #0x6ace2ec
006ACE2D8  adrp     x0, #0x8f3b000
006ACE2DC  ldr      x0, [x0, #0xc08]
006ACE2E0  bl       #0x382bd14 ; 
006ACE2E4  mov      w8, #1
006ACE2E8  strb     w8, [x21, #0xcc]
006ACE2EC  adrp     x8, #0x8f3b000
006ACE2F0  ldr      x8, [x8, #0xc08]
006ACE2F4  ldr      x2, [x8]
006ACE2F8  ldrb     w8, [x2, #0x53]
006ACE2FC  tbnz     w8, #5, #0x6ace314
006ACE300  str      x20, [x19, #0x28]!
006ACE304  mov      x0, x19
006ACE308  mov      x1, x20
006ACE30C  bl       #0x382bcb8 ; 
006ACE310  b        #0x6ace324 ; 
006ACE314  ldr      x8, [x2, #0x60]
006ACE318  mov      x0, x19
006ACE31C  mov      x1, x20
006ACE320  blr      x8
006ACE324  ldp      x20, x19, [sp, #0x10]
006ACE328  mov      w0, #1
006ACE32C  ldp      x30, x21, [sp], #0x20
006ACE330  ret      

