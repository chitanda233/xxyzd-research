; LocalModels.Bean.Mission_PositionGroupMonsterFlushConfig$$readImpl
; RVA 0x6AC2468; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC2468  stp      x30, x21, [sp, #-0x20]!
006AC246C  stp      x20, x19, [sp, #0x10]
006AC2470  adrp     x20, #0x959e000
006AC2474  adrp     x21, #0x8f3b000
006AC2478  ldrb     w8, [x20, #0x997]
006AC247C  ldr      x21, [x21, #0x388]
006AC2480  mov      x19, x0
006AC2484  tbnz     w8, #0, #0x6ac249c
006AC2488  adrp     x0, #0x8f3b000
006AC248C  ldr      x0, [x0, #0x388]
006AC2490  bl       #0x382bd14 ; 
006AC2494  mov      w8, #1
006AC2498  strb     w8, [x20, #0x997]
006AC249C  ldr      x1, [x21]
006AC24A0  ldrb     w8, [x1, #0x53]
006AC24A4  tbnz     w8, #5, #0x6ac24f4
006AC24A8  mov      x0, x19
006AC24AC  mov      x1, xzr
006AC24B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC24B4  adrp     x21, #0x959f000
006AC24B8  ldrb     w8, [x21, #0x46]
006AC24BC  mov      w20, w0
006AC24C0  cbnz     w8, #0x6ac24d8
006AC24C4  adrp     x0, #0x8f3b000
006AC24C8  ldr      x0, [x0, #0x378]
006AC24CC  bl       #0x382bd14 ; 
006AC24D0  mov      w8, #1
006AC24D4  strb     w8, [x21, #0x46]
006AC24D8  adrp     x8, #0x8f3b000
006AC24DC  ldr      x8, [x8, #0x378]
006AC24E0  ldr      x2, [x8]
006AC24E4  ldrb     w8, [x2, #0x53]
006AC24E8  tbnz     w8, #5, #0x6ac2508
006AC24EC  str      w20, [x19, #0x20]
006AC24F0  b        #0x6ac2518 ; 
006AC24F4  ldr      x2, [x1, #0x60]
006AC24F8  mov      x0, x19
006AC24FC  ldp      x20, x19, [sp, #0x10]
006AC2500  ldp      x30, x21, [sp], #0x20
006AC2504  br       x2
006AC2508  ldr      x8, [x2, #0x60]
006AC250C  mov      x0, x19
006AC2510  mov      w1, w20
006AC2514  blr      x8
006AC2518  mov      x0, x19
006AC251C  mov      x1, xzr
006AC2520  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AC2524  adrp     x21, #0x959f000
006AC2528  ldrb     w8, [x21, #0x47]
006AC252C  mov      x20, x0
006AC2530  cbnz     w8, #0x6ac2548
006AC2534  adrp     x0, #0x8f3b000
006AC2538  ldr      x0, [x0, #0x380]
006AC253C  bl       #0x382bd14 ; 
006AC2540  mov      w8, #1
006AC2544  strb     w8, [x21, #0x47]
006AC2548  adrp     x8, #0x8f3b000
006AC254C  ldr      x8, [x8, #0x380]
006AC2550  ldr      x2, [x8]
006AC2554  ldrb     w8, [x2, #0x53]
006AC2558  tbnz     w8, #5, #0x6ac2570
006AC255C  str      x20, [x19, #0x28]!
006AC2560  mov      x0, x19
006AC2564  mov      x1, x20
006AC2568  bl       #0x382bcb8 ; 
006AC256C  b        #0x6ac2580 ; 
006AC2570  ldr      x8, [x2, #0x60]
006AC2574  mov      x0, x19
006AC2578  mov      x1, x20
006AC257C  blr      x8
006AC2580  ldp      x20, x19, [sp, #0x10]
006AC2584  mov      w0, #1
006AC2588  ldp      x30, x21, [sp], #0x20
006AC258C  ret      

