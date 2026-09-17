; LocalModels.Bean.GuildBOSS_guildBoss$$readImpl
; RVA 0x6A831CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A831CC  stp      x30, x21, [sp, #-0x20]!
006A831D0  stp      x20, x19, [sp, #0x10]
006A831D4  adrp     x20, #0x959d000
006A831D8  adrp     x21, #0x8f38000
006A831DC  ldrb     w8, [x20, #0xf8c]
006A831E0  ldr      x21, [x21, #0x430]
006A831E4  mov      x19, x0
006A831E8  tbnz     w8, #0, #0x6a83200
006A831EC  adrp     x0, #0x8f38000
006A831F0  ldr      x0, [x0, #0x430]
006A831F4  bl       #0x382bd14 ; 
006A831F8  mov      w8, #1
006A831FC  strb     w8, [x20, #0xf8c]
006A83200  ldr      x1, [x21]
006A83204  ldrb     w8, [x1, #0x53]
006A83208  tbnz     w8, #5, #0x6a83258
006A8320C  mov      x0, x19
006A83210  mov      x1, xzr
006A83214  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A83218  adrp     x21, #0x959e000
006A8321C  ldrb     w8, [x21, #0x51e]
006A83220  mov      w20, w0
006A83224  cbnz     w8, #0x6a8323c
006A83228  adrp     x0, #0x8f38000
006A8322C  ldr      x0, [x0, #0x3e8]
006A83230  bl       #0x382bd14 ; 
006A83234  mov      w8, #1
006A83238  strb     w8, [x21, #0x51e]
006A8323C  adrp     x8, #0x8f38000
006A83240  ldr      x8, [x8, #0x3e8]
006A83244  ldr      x2, [x8]
006A83248  ldrb     w8, [x2, #0x53]
006A8324C  tbnz     w8, #5, #0x6a8326c
006A83250  str      w20, [x19, #0x20]
006A83254  b        #0x6a8327c ; 
006A83258  ldr      x2, [x1, #0x60]
006A8325C  mov      x0, x19
006A83260  ldp      x20, x19, [sp, #0x10]
006A83264  ldp      x30, x21, [sp], #0x20
006A83268  br       x2
006A8326C  ldr      x8, [x2, #0x60]
006A83270  mov      x0, x19
006A83274  mov      w1, w20
006A83278  blr      x8
006A8327C  mov      x0, x19
006A83280  mov      x1, xzr
006A83284  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A83288  adrp     x21, #0x959e000
006A8328C  ldrb     w8, [x21, #0x51f]
006A83290  mov      w20, w0
006A83294  cbnz     w8, #0x6a832ac
006A83298  adrp     x0, #0x8f38000
006A8329C  ldr      x0, [x0, #0x3f8]
006A832A0  bl       #0x382bd14 ; 
006A832A4  mov      w8, #1
006A832A8  strb     w8, [x21, #0x51f]
006A832AC  adrp     x8, #0x8f38000
006A832B0  ldr      x8, [x8, #0x3f8]
006A832B4  ldr      x2, [x8]
006A832B8  ldrb     w8, [x2, #0x53]
006A832BC  tbnz     w8, #5, #0x6a832c8
006A832C0  str      w20, [x19, #0x24]
006A832C4  b        #0x6a832d8 ; 
006A832C8  ldr      x8, [x2, #0x60]
006A832CC  mov      x0, x19
006A832D0  mov      w1, w20
006A832D4  blr      x8
006A832D8  mov      x0, x19
006A832DC  mov      x1, xzr
006A832E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A832E4  adrp     x21, #0x959e000
006A832E8  ldrb     w8, [x21, #0x520]
006A832EC  mov      w20, w0
006A832F0  cbnz     w8, #0x6a83308
006A832F4  adrp     x0, #0x8f38000
006A832F8  ldr      x0, [x0, #0x408]
006A832FC  bl       #0x382bd14 ; 
006A83300  mov      w8, #1
006A83304  strb     w8, [x21, #0x520]
006A83308  adrp     x8, #0x8f38000
006A8330C  ldr      x8, [x8, #0x408]
006A83310  ldr      x2, [x8]
006A83314  ldrb     w8, [x2, #0x53]
006A83318  tbnz     w8, #5, #0x6a83324
006A8331C  str      w20, [x19, #0x28]
006A83320  b        #0x6a83334 ; 
006A83324  ldr      x8, [x2, #0x60]
006A83328  mov      x0, x19
006A8332C  mov      w1, w20
006A83330  blr      x8
006A83334  mov      x0, x19
006A83338  mov      x1, xzr
006A8333C  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006A83340  adrp     x21, #0x959e000
006A83344  ldrb     w8, [x21, #0x521]
006A83348  mov      x20, x0
006A8334C  cbnz     w8, #0x6a83364
006A83350  adrp     x0, #0x8f38000
006A83354  ldr      x0, [x0, #0x418]
006A83358  bl       #0x382bd14 ; 
006A8335C  mov      w8, #1
006A83360  strb     w8, [x21, #0x521]
006A83364  adrp     x8, #0x8f38000
006A83368  ldr      x8, [x8, #0x418]
006A8336C  ldr      x2, [x8]
006A83370  ldrb     w8, [x2, #0x53]
006A83374  tbnz     w8, #5, #0x6a83380
006A83378  str      x20, [x19, #0x30]
006A8337C  b        #0x6a83390 ; 
006A83380  ldr      x8, [x2, #0x60]
006A83384  mov      x0, x19
006A83388  mov      x1, x20
006A8338C  blr      x8
006A83390  mov      x0, x19
006A83394  mov      x1, xzr
006A83398  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A8339C  adrp     x21, #0x959e000
006A833A0  ldrb     w8, [x21, #0x522]
006A833A4  mov      x20, x0
006A833A8  cbnz     w8, #0x6a833c0
006A833AC  adrp     x0, #0x8f38000
006A833B0  ldr      x0, [x0, #0x428]
006A833B4  bl       #0x382bd14 ; 
006A833B8  mov      w8, #1
006A833BC  strb     w8, [x21, #0x522]
006A833C0  adrp     x8, #0x8f38000
006A833C4  ldr      x8, [x8, #0x428]
006A833C8  ldr      x2, [x8]
006A833CC  ldrb     w8, [x2, #0x53]
006A833D0  tbnz     w8, #5, #0x6a833e8
006A833D4  str      x20, [x19, #0x38]!
006A833D8  mov      x0, x19
006A833DC  mov      x1, x20
006A833E0  bl       #0x382bcb8 ; 
006A833E4  b        #0x6a833f8 ; 
006A833E8  ldr      x8, [x2, #0x60]
006A833EC  mov      x0, x19
006A833F0  mov      x1, x20
006A833F4  blr      x8
006A833F8  ldp      x20, x19, [sp, #0x10]
006A833FC  mov      w0, #1
006A83400  ldp      x30, x21, [sp], #0x20
006A83404  ret      

