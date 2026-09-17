; LocalModels.Bean.Shop_ShopGoodsCountPrice$$readImpl
; RVA 0x6AF2308; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF2308  stp      x30, x21, [sp, #-0x20]!
006AF230C  stp      x20, x19, [sp, #0x10]
006AF2310  adrp     x20, #0x959e000
006AF2314  adrp     x21, #0x8f3d000
006AF2318  ldrb     w8, [x20, #0xe8e]
006AF231C  ldr      x21, [x21, #0x778]
006AF2320  mov      x19, x0
006AF2324  tbnz     w8, #0, #0x6af233c
006AF2328  adrp     x0, #0x8f3d000
006AF232C  ldr      x0, [x0, #0x778]
006AF2330  bl       #0x382bd14 ; 
006AF2334  mov      w8, #1
006AF2338  strb     w8, [x20, #0xe8e]
006AF233C  ldr      x1, [x21]
006AF2340  ldrb     w8, [x1, #0x53]
006AF2344  tbnz     w8, #5, #0x6af2394
006AF2348  mov      x0, x19
006AF234C  mov      x1, xzr
006AF2350  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF2354  adrp     x21, #0x959f000
006AF2358  ldrb     w8, [x21, #0x258]
006AF235C  mov      w20, w0
006AF2360  cbnz     w8, #0x6af2378
006AF2364  adrp     x0, #0x8f3d000
006AF2368  ldr      x0, [x0, #0x740]
006AF236C  bl       #0x382bd14 ; 
006AF2370  mov      w8, #1
006AF2374  strb     w8, [x21, #0x258]
006AF2378  adrp     x8, #0x8f3d000
006AF237C  ldr      x8, [x8, #0x740]
006AF2380  ldr      x2, [x8]
006AF2384  ldrb     w8, [x2, #0x53]
006AF2388  tbnz     w8, #5, #0x6af23a8
006AF238C  str      w20, [x19, #0x20]
006AF2390  b        #0x6af23b8 ; 
006AF2394  ldr      x2, [x1, #0x60]
006AF2398  mov      x0, x19
006AF239C  ldp      x20, x19, [sp, #0x10]
006AF23A0  ldp      x30, x21, [sp], #0x20
006AF23A4  br       x2
006AF23A8  ldr      x8, [x2, #0x60]
006AF23AC  mov      x0, x19
006AF23B0  mov      w1, w20
006AF23B4  blr      x8
006AF23B8  mov      x0, x19
006AF23BC  mov      x1, xzr
006AF23C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF23C4  adrp     x21, #0x959f000
006AF23C8  ldrb     w8, [x21, #0x259]
006AF23CC  mov      w20, w0
006AF23D0  cbnz     w8, #0x6af23e8
006AF23D4  adrp     x0, #0x8f3d000
006AF23D8  ldr      x0, [x0, #0x750]
006AF23DC  bl       #0x382bd14 ; 
006AF23E0  mov      w8, #1
006AF23E4  strb     w8, [x21, #0x259]
006AF23E8  adrp     x8, #0x8f3d000
006AF23EC  ldr      x8, [x8, #0x750]
006AF23F0  ldr      x2, [x8]
006AF23F4  ldrb     w8, [x2, #0x53]
006AF23F8  tbnz     w8, #5, #0x6af2404
006AF23FC  str      w20, [x19, #0x24]
006AF2400  b        #0x6af2414 ; 
006AF2404  ldr      x8, [x2, #0x60]
006AF2408  mov      x0, x19
006AF240C  mov      w1, w20
006AF2410  blr      x8
006AF2414  mov      x0, x19
006AF2418  mov      x1, xzr
006AF241C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF2420  adrp     x21, #0x959f000
006AF2424  ldrb     w8, [x21, #0x25a]
006AF2428  mov      w20, w0
006AF242C  cbnz     w8, #0x6af2444
006AF2430  adrp     x0, #0x8f3d000
006AF2434  ldr      x0, [x0, #0x760]
006AF2438  bl       #0x382bd14 ; 
006AF243C  mov      w8, #1
006AF2440  strb     w8, [x21, #0x25a]
006AF2444  adrp     x8, #0x8f3d000
006AF2448  ldr      x8, [x8, #0x760]
006AF244C  ldr      x2, [x8]
006AF2450  ldrb     w8, [x2, #0x53]
006AF2454  tbnz     w8, #5, #0x6af2460
006AF2458  str      w20, [x19, #0x28]
006AF245C  b        #0x6af2470 ; 
006AF2460  ldr      x8, [x2, #0x60]
006AF2464  mov      x0, x19
006AF2468  mov      w1, w20
006AF246C  blr      x8
006AF2470  mov      x0, x19
006AF2474  mov      x1, xzr
006AF2478  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AF247C  adrp     x21, #0x959f000
006AF2480  ldrb     w8, [x21, #0x25b]
006AF2484  mov      x20, x0
006AF2488  cbnz     w8, #0x6af24a0
006AF248C  adrp     x0, #0x8f3d000
006AF2490  ldr      x0, [x0, #0x770]
006AF2494  bl       #0x382bd14 ; 
006AF2498  mov      w8, #1
006AF249C  strb     w8, [x21, #0x25b]
006AF24A0  adrp     x8, #0x8f3d000
006AF24A4  ldr      x8, [x8, #0x770]
006AF24A8  ldr      x2, [x8]
006AF24AC  ldrb     w8, [x2, #0x53]
006AF24B0  tbnz     w8, #5, #0x6af24c8
006AF24B4  str      x20, [x19, #0x30]!
006AF24B8  mov      x0, x19
006AF24BC  mov      x1, x20
006AF24C0  bl       #0x382bcb8 ; 
006AF24C4  b        #0x6af24d8 ; 
006AF24C8  ldr      x8, [x2, #0x60]
006AF24CC  mov      x0, x19
006AF24D0  mov      x1, x20
006AF24D4  blr      x8
006AF24D8  ldp      x20, x19, [sp, #0x10]
006AF24DC  mov      w0, #1
006AF24E0  ldp      x30, x21, [sp], #0x20
006AF24E4  ret      

