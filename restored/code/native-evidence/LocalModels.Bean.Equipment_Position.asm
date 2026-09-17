; LocalModels.Bean.Equipment_Position$$readImpl
; RVA 0x6A6721C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6721C  stp      x30, x21, [sp, #-0x20]!
006A67220  stp      x20, x19, [sp, #0x10]
006A67224  adrp     x20, #0x959d000
006A67228  adrp     x21, #0x8f36000
006A6722C  ldrb     w8, [x20, #0xc9f]
006A67230  ldr      x21, [x21, #0xe58]
006A67234  mov      x19, x0
006A67238  tbnz     w8, #0, #0x6a67250
006A6723C  adrp     x0, #0x8f36000
006A67240  ldr      x0, [x0, #0xe58]
006A67244  bl       #0x382bd14 ; 
006A67248  mov      w8, #1
006A6724C  strb     w8, [x20, #0xc9f]
006A67250  ldr      x1, [x21]
006A67254  ldrb     w8, [x1, #0x53]
006A67258  tbnz     w8, #5, #0x6a672a8
006A6725C  mov      x0, x19
006A67260  mov      x1, xzr
006A67264  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A67268  adrp     x21, #0x959e000
006A6726C  ldrb     w8, [x21, #0x3f1]
006A67270  mov      w20, w0
006A67274  cbnz     w8, #0x6a6728c
006A67278  adrp     x0, #0x8f36000
006A6727C  ldr      x0, [x0, #0xe40]
006A67280  bl       #0x382bd14 ; 
006A67284  mov      w8, #1
006A67288  strb     w8, [x21, #0x3f1]
006A6728C  adrp     x8, #0x8f36000
006A67290  ldr      x8, [x8, #0xe40]
006A67294  ldr      x2, [x8]
006A67298  ldrb     w8, [x2, #0x53]
006A6729C  tbnz     w8, #5, #0x6a672bc
006A672A0  str      w20, [x19, #0x20]
006A672A4  b        #0x6a672cc ; 
006A672A8  ldr      x2, [x1, #0x60]
006A672AC  mov      x0, x19
006A672B0  ldp      x20, x19, [sp, #0x10]
006A672B4  ldp      x30, x21, [sp], #0x20
006A672B8  br       x2
006A672BC  ldr      x8, [x2, #0x60]
006A672C0  mov      x0, x19
006A672C4  mov      w1, w20
006A672C8  blr      x8
006A672CC  mov      x0, x19
006A672D0  mov      x1, xzr
006A672D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A672D8  adrp     x21, #0x959e000
006A672DC  ldrb     w8, [x21, #0x3f2]
006A672E0  mov      w20, w0
006A672E4  cbnz     w8, #0x6a672fc
006A672E8  adrp     x0, #0x8f36000
006A672EC  ldr      x0, [x0, #0xe50]
006A672F0  bl       #0x382bd14 ; 
006A672F4  mov      w8, #1
006A672F8  strb     w8, [x21, #0x3f2]
006A672FC  adrp     x8, #0x8f36000
006A67300  ldr      x8, [x8, #0xe50]
006A67304  ldr      x2, [x8]
006A67308  ldrb     w8, [x2, #0x53]
006A6730C  tbnz     w8, #5, #0x6a67318
006A67310  str      w20, [x19, #0x24]
006A67314  b        #0x6a67328 ; 
006A67318  ldr      x8, [x2, #0x60]
006A6731C  mov      x0, x19
006A67320  mov      w1, w20
006A67324  blr      x8
006A67328  ldp      x20, x19, [sp, #0x10]
006A6732C  mov      w0, #1
006A67330  ldp      x30, x21, [sp], #0x20
006A67334  ret      

