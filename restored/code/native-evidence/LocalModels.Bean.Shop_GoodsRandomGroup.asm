; LocalModels.Bean.Shop_GoodsRandomGroup$$readImpl
; RVA 0x6AEAA0C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AEAA0C  stp      x30, x21, [sp, #-0x20]!
006AEAA10  stp      x20, x19, [sp, #0x10]
006AEAA14  adrp     x20, #0x959e000
006AEAA18  adrp     x21, #0x8f3d000
006AEAA1C  ldrb     w8, [x20, #0xdc6]
006AEAA20  ldr      x21, [x21, #0x198]
006AEAA24  mov      x19, x0
006AEAA28  tbnz     w8, #0, #0x6aeaa40
006AEAA2C  adrp     x0, #0x8f3d000
006AEAA30  ldr      x0, [x0, #0x198]
006AEAA34  bl       #0x382bd14 ; 
006AEAA38  mov      w8, #1
006AEAA3C  strb     w8, [x20, #0xdc6]
006AEAA40  ldr      x1, [x21]
006AEAA44  ldrb     w8, [x1, #0x53]
006AEAA48  tbnz     w8, #5, #0x6aeaa98
006AEAA4C  mov      x0, x19
006AEAA50  mov      x1, xzr
006AEAA54  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEAA58  adrp     x21, #0x959f000
006AEAA5C  ldrb     w8, [x21, #0x203]
006AEAA60  mov      w20, w0
006AEAA64  cbnz     w8, #0x6aeaa7c
006AEAA68  adrp     x0, #0x8f3d000
006AEAA6C  ldr      x0, [x0, #0x130]
006AEAA70  bl       #0x382bd14 ; 
006AEAA74  mov      w8, #1
006AEAA78  strb     w8, [x21, #0x203]
006AEAA7C  adrp     x8, #0x8f3d000
006AEAA80  ldr      x8, [x8, #0x130]
006AEAA84  ldr      x2, [x8]
006AEAA88  ldrb     w8, [x2, #0x53]
006AEAA8C  tbnz     w8, #5, #0x6aeaaac
006AEAA90  str      w20, [x19, #0x20]
006AEAA94  b        #0x6aeaabc ; 
006AEAA98  ldr      x2, [x1, #0x60]
006AEAA9C  mov      x0, x19
006AEAAA0  ldp      x20, x19, [sp, #0x10]
006AEAAA4  ldp      x30, x21, [sp], #0x20
006AEAAA8  br       x2
006AEAAAC  ldr      x8, [x2, #0x60]
006AEAAB0  mov      x0, x19
006AEAAB4  mov      w1, w20
006AEAAB8  blr      x8
006AEAABC  mov      x0, x19
006AEAAC0  mov      x1, xzr
006AEAAC4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEAAC8  adrp     x21, #0x959f000
006AEAACC  ldrb     w8, [x21, #0x204]
006AEAAD0  mov      w20, w0
006AEAAD4  cbnz     w8, #0x6aeaaec
006AEAAD8  adrp     x0, #0x8f3d000
006AEAADC  ldr      x0, [x0, #0x140]
006AEAAE0  bl       #0x382bd14 ; 
006AEAAE4  mov      w8, #1
006AEAAE8  strb     w8, [x21, #0x204]
006AEAAEC  adrp     x8, #0x8f3d000
006AEAAF0  ldr      x8, [x8, #0x140]
006AEAAF4  ldr      x2, [x8]
006AEAAF8  ldrb     w8, [x2, #0x53]
006AEAAFC  tbnz     w8, #5, #0x6aeab08
006AEAB00  str      w20, [x19, #0x24]
006AEAB04  b        #0x6aeab18 ; 
006AEAB08  ldr      x8, [x2, #0x60]
006AEAB0C  mov      x0, x19
006AEAB10  mov      w1, w20
006AEAB14  blr      x8
006AEAB18  mov      x0, x19
006AEAB1C  mov      x1, xzr
006AEAB20  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEAB24  adrp     x21, #0x959f000
006AEAB28  ldrb     w8, [x21, #0x205]
006AEAB2C  mov      w20, w0
006AEAB30  cbnz     w8, #0x6aeab48
006AEAB34  adrp     x0, #0x8f3d000
006AEAB38  ldr      x0, [x0, #0x150]
006AEAB3C  bl       #0x382bd14 ; 
006AEAB40  mov      w8, #1
006AEAB44  strb     w8, [x21, #0x205]
006AEAB48  adrp     x8, #0x8f3d000
006AEAB4C  ldr      x8, [x8, #0x150]
006AEAB50  ldr      x2, [x8]
006AEAB54  ldrb     w8, [x2, #0x53]
006AEAB58  tbnz     w8, #5, #0x6aeab64
006AEAB5C  str      w20, [x19, #0x28]
006AEAB60  b        #0x6aeab74 ; 
006AEAB64  ldr      x8, [x2, #0x60]
006AEAB68  mov      x0, x19
006AEAB6C  mov      w1, w20
006AEAB70  blr      x8
006AEAB74  mov      x0, x19
006AEAB78  mov      x1, xzr
006AEAB7C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEAB80  adrp     x21, #0x959f000
006AEAB84  ldrb     w8, [x21, #0x206]
006AEAB88  mov      w20, w0
006AEAB8C  cbnz     w8, #0x6aeaba4
006AEAB90  adrp     x0, #0x8f3d000
006AEAB94  ldr      x0, [x0, #0x160]
006AEAB98  bl       #0x382bd14 ; 
006AEAB9C  mov      w8, #1
006AEABA0  strb     w8, [x21, #0x206]
006AEABA4  adrp     x8, #0x8f3d000
006AEABA8  ldr      x8, [x8, #0x160]
006AEABAC  ldr      x2, [x8]
006AEABB0  ldrb     w8, [x2, #0x53]
006AEABB4  tbnz     w8, #5, #0x6aeabc0
006AEABB8  str      w20, [x19, #0x2c]
006AEABBC  b        #0x6aeabd0 ; 
006AEABC0  ldr      x8, [x2, #0x60]
006AEABC4  mov      x0, x19
006AEABC8  mov      w1, w20
006AEABCC  blr      x8
006AEABD0  mov      x0, x19
006AEABD4  mov      x1, xzr
006AEABD8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEABDC  adrp     x21, #0x959f000
006AEABE0  ldrb     w8, [x21, #0x207]
006AEABE4  mov      w20, w0
006AEABE8  cbnz     w8, #0x6aeac00
006AEABEC  adrp     x0, #0x8f3d000
006AEABF0  ldr      x0, [x0, #0x170]
006AEABF4  bl       #0x382bd14 ; 
006AEABF8  mov      w8, #1
006AEABFC  strb     w8, [x21, #0x207]
006AEAC00  adrp     x8, #0x8f3d000
006AEAC04  ldr      x8, [x8, #0x170]
006AEAC08  ldr      x2, [x8]
006AEAC0C  ldrb     w8, [x2, #0x53]
006AEAC10  tbnz     w8, #5, #0x6aeac1c
006AEAC14  str      w20, [x19, #0x30]
006AEAC18  b        #0x6aeac2c ; 
006AEAC1C  ldr      x8, [x2, #0x60]
006AEAC20  mov      x0, x19
006AEAC24  mov      w1, w20
006AEAC28  blr      x8
006AEAC2C  mov      x0, x19
006AEAC30  mov      x1, xzr
006AEAC34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEAC38  adrp     x21, #0x959f000
006AEAC3C  ldrb     w8, [x21, #0x208]
006AEAC40  mov      w20, w0
006AEAC44  cbnz     w8, #0x6aeac5c
006AEAC48  adrp     x0, #0x8f3d000
006AEAC4C  ldr      x0, [x0, #0x180]
006AEAC50  bl       #0x382bd14 ; 
006AEAC54  mov      w8, #1
006AEAC58  strb     w8, [x21, #0x208]
006AEAC5C  adrp     x8, #0x8f3d000
006AEAC60  ldr      x8, [x8, #0x180]
006AEAC64  ldr      x2, [x8]
006AEAC68  ldrb     w8, [x2, #0x53]
006AEAC6C  tbnz     w8, #5, #0x6aeac78
006AEAC70  str      w20, [x19, #0x34]
006AEAC74  b        #0x6aeac88 ; 
006AEAC78  ldr      x8, [x2, #0x60]
006AEAC7C  mov      x0, x19
006AEAC80  mov      w1, w20
006AEAC84  blr      x8
006AEAC88  mov      x0, x19
006AEAC8C  mov      x1, xzr
006AEAC90  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEAC94  adrp     x21, #0x959f000
006AEAC98  ldrb     w8, [x21, #0x209]
006AEAC9C  mov      w20, w0
006AEACA0  cbnz     w8, #0x6aeacb8
006AEACA4  adrp     x0, #0x8f3d000
006AEACA8  ldr      x0, [x0, #0x190]
006AEACAC  bl       #0x382bd14 ; 
006AEACB0  mov      w8, #1
006AEACB4  strb     w8, [x21, #0x209]
006AEACB8  adrp     x8, #0x8f3d000
006AEACBC  ldr      x8, [x8, #0x190]
006AEACC0  ldr      x2, [x8]
006AEACC4  ldrb     w8, [x2, #0x53]
006AEACC8  tbnz     w8, #5, #0x6aeacd4
006AEACCC  str      w20, [x19, #0x38]
006AEACD0  b        #0x6aeace4 ; 
006AEACD4  ldr      x8, [x2, #0x60]
006AEACD8  mov      x0, x19
006AEACDC  mov      w1, w20
006AEACE0  blr      x8
006AEACE4  ldp      x20, x19, [sp, #0x10]
006AEACE8  mov      w0, #1
006AEACEC  ldp      x30, x21, [sp], #0x20
006AEACF0  ret      

