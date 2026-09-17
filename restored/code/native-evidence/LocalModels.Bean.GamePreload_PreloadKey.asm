; LocalModels.Bean.GamePreload_PreloadKey$$readImpl
; RVA 0x6A8167C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A8167C  stp      x30, x21, [sp, #-0x20]!
006A81680  stp      x20, x19, [sp, #0x10]
006A81684  adrp     x20, #0x959d000
006A81688  adrp     x21, #0x8f38000
006A8168C  ldrb     w8, [x20, #0xf5d]
006A81690  ldr      x21, [x21, #0x2d0]
006A81694  mov      x19, x0
006A81698  tbnz     w8, #0, #0x6a816b0
006A8169C  adrp     x0, #0x8f38000
006A816A0  ldr      x0, [x0, #0x2d0]
006A816A4  bl       #0x382bd14 ; 
006A816A8  mov      w8, #1
006A816AC  strb     w8, [x20, #0xf5d]
006A816B0  ldr      x1, [x21]
006A816B4  ldrb     w8, [x1, #0x53]
006A816B8  tbnz     w8, #5, #0x6a81708
006A816BC  mov      x0, x19
006A816C0  mov      x1, xzr
006A816C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A816C8  adrp     x21, #0x959e000
006A816CC  ldrb     w8, [x21, #0x50d]
006A816D0  mov      w20, w0
006A816D4  cbnz     w8, #0x6a816ec
006A816D8  adrp     x0, #0x8f38000
006A816DC  ldr      x0, [x0, #0x2a8]
006A816E0  bl       #0x382bd14 ; 
006A816E4  mov      w8, #1
006A816E8  strb     w8, [x21, #0x50d]
006A816EC  adrp     x8, #0x8f38000
006A816F0  ldr      x8, [x8, #0x2a8]
006A816F4  ldr      x2, [x8]
006A816F8  ldrb     w8, [x2, #0x53]
006A816FC  tbnz     w8, #5, #0x6a8171c
006A81700  str      w20, [x19, #0x20]
006A81704  b        #0x6a8172c ; 
006A81708  ldr      x2, [x1, #0x60]
006A8170C  mov      x0, x19
006A81710  ldp      x20, x19, [sp, #0x10]
006A81714  ldp      x30, x21, [sp], #0x20
006A81718  br       x2
006A8171C  ldr      x8, [x2, #0x60]
006A81720  mov      x0, x19
006A81724  mov      w1, w20
006A81728  blr      x8
006A8172C  mov      x0, x19
006A81730  mov      x1, xzr
006A81734  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A81738  adrp     x21, #0x959e000
006A8173C  ldrb     w8, [x21, #0x50e]
006A81740  mov      w20, w0
006A81744  cbnz     w8, #0x6a8175c
006A81748  adrp     x0, #0x8f38000
006A8174C  ldr      x0, [x0, #0x2b8]
006A81750  bl       #0x382bd14 ; 
006A81754  mov      w8, #1
006A81758  strb     w8, [x21, #0x50e]
006A8175C  adrp     x8, #0x8f38000
006A81760  ldr      x8, [x8, #0x2b8]
006A81764  ldr      x2, [x8]
006A81768  ldrb     w8, [x2, #0x53]
006A8176C  tbnz     w8, #5, #0x6a81778
006A81770  str      w20, [x19, #0x24]
006A81774  b        #0x6a81788 ; 
006A81778  ldr      x8, [x2, #0x60]
006A8177C  mov      x0, x19
006A81780  mov      w1, w20
006A81784  blr      x8
006A81788  mov      x0, x19
006A8178C  mov      x1, xzr
006A81790  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A81794  adrp     x21, #0x959e000
006A81798  ldrb     w8, [x21, #0x50f]
006A8179C  mov      x20, x0
006A817A0  cbnz     w8, #0x6a817b8
006A817A4  adrp     x0, #0x8f38000
006A817A8  ldr      x0, [x0, #0x2c8]
006A817AC  bl       #0x382bd14 ; 
006A817B0  mov      w8, #1
006A817B4  strb     w8, [x21, #0x50f]
006A817B8  adrp     x8, #0x8f38000
006A817BC  ldr      x8, [x8, #0x2c8]
006A817C0  ldr      x2, [x8]
006A817C4  ldrb     w8, [x2, #0x53]
006A817C8  tbnz     w8, #5, #0x6a817e0
006A817CC  str      x20, [x19, #0x28]!
006A817D0  mov      x0, x19
006A817D4  mov      x1, x20
006A817D8  bl       #0x382bcb8 ; 
006A817DC  b        #0x6a817f0 ; 
006A817E0  ldr      x8, [x2, #0x60]
006A817E4  mov      x0, x19
006A817E8  mov      x1, x20
006A817EC  blr      x8
006A817F0  ldp      x20, x19, [sp, #0x10]
006A817F4  mov      w0, #1
006A817F8  ldp      x30, x21, [sp], #0x20
006A817FC  ret      

