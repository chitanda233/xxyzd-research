; LocalModels.Bean.Shop_LootBoxRule$$readImpl
; RVA 0x6AEC84C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AEC84C  stp      x30, x21, [sp, #-0x20]!
006AEC850  stp      x20, x19, [sp, #0x10]
006AEC854  adrp     x20, #0x959e000
006AEC858  adrp     x21, #0x8f3d000
006AEC85C  ldrb     w8, [x20, #0xdf7]
006AEC860  ldr      x21, [x21, #0x308]
006AEC864  mov      x19, x0
006AEC868  tbnz     w8, #0, #0x6aec880
006AEC86C  adrp     x0, #0x8f3d000
006AEC870  ldr      x0, [x0, #0x308]
006AEC874  bl       #0x382bd14 ; 
006AEC878  mov      w8, #1
006AEC87C  strb     w8, [x20, #0xdf7]
006AEC880  ldr      x1, [x21]
006AEC884  ldrb     w8, [x1, #0x53]
006AEC888  tbnz     w8, #5, #0x6aec8d8
006AEC88C  mov      x0, x19
006AEC890  mov      x1, xzr
006AEC894  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEC898  adrp     x21, #0x959f000
006AEC89C  ldrb     w8, [x21, #0x21a]
006AEC8A0  mov      w20, w0
006AEC8A4  cbnz     w8, #0x6aec8bc
006AEC8A8  adrp     x0, #0x8f3d000
006AEC8AC  ldr      x0, [x0, #0x2d0]
006AEC8B0  bl       #0x382bd14 ; 
006AEC8B4  mov      w8, #1
006AEC8B8  strb     w8, [x21, #0x21a]
006AEC8BC  adrp     x8, #0x8f3d000
006AEC8C0  ldr      x8, [x8, #0x2d0]
006AEC8C4  ldr      x2, [x8]
006AEC8C8  ldrb     w8, [x2, #0x53]
006AEC8CC  tbnz     w8, #5, #0x6aec8ec
006AEC8D0  str      w20, [x19, #0x20]
006AEC8D4  b        #0x6aec8fc ; 
006AEC8D8  ldr      x2, [x1, #0x60]
006AEC8DC  mov      x0, x19
006AEC8E0  ldp      x20, x19, [sp, #0x10]
006AEC8E4  ldp      x30, x21, [sp], #0x20
006AEC8E8  br       x2
006AEC8EC  ldr      x8, [x2, #0x60]
006AEC8F0  mov      x0, x19
006AEC8F4  mov      w1, w20
006AEC8F8  blr      x8
006AEC8FC  mov      x0, x19
006AEC900  mov      x1, xzr
006AEC904  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEC908  adrp     x21, #0x959f000
006AEC90C  ldrb     w8, [x21, #0x21b]
006AEC910  mov      w20, w0
006AEC914  cbnz     w8, #0x6aec92c
006AEC918  adrp     x0, #0x8f3d000
006AEC91C  ldr      x0, [x0, #0x2e0]
006AEC920  bl       #0x382bd14 ; 
006AEC924  mov      w8, #1
006AEC928  strb     w8, [x21, #0x21b]
006AEC92C  adrp     x8, #0x8f3d000
006AEC930  ldr      x8, [x8, #0x2e0]
006AEC934  ldr      x2, [x8]
006AEC938  ldrb     w8, [x2, #0x53]
006AEC93C  tbnz     w8, #5, #0x6aec948
006AEC940  str      w20, [x19, #0x24]
006AEC944  b        #0x6aec958 ; 
006AEC948  ldr      x8, [x2, #0x60]
006AEC94C  mov      x0, x19
006AEC950  mov      w1, w20
006AEC954  blr      x8
006AEC958  mov      x0, x19
006AEC95C  mov      x1, xzr
006AEC960  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEC964  adrp     x21, #0x959f000
006AEC968  ldrb     w8, [x21, #0x21c]
006AEC96C  mov      w20, w0
006AEC970  cbnz     w8, #0x6aec988
006AEC974  adrp     x0, #0x8f3d000
006AEC978  ldr      x0, [x0, #0x2f0]
006AEC97C  bl       #0x382bd14 ; 
006AEC980  mov      w8, #1
006AEC984  strb     w8, [x21, #0x21c]
006AEC988  adrp     x8, #0x8f3d000
006AEC98C  ldr      x8, [x8, #0x2f0]
006AEC990  ldr      x2, [x8]
006AEC994  ldrb     w8, [x2, #0x53]
006AEC998  tbnz     w8, #5, #0x6aec9a4
006AEC99C  str      w20, [x19, #0x28]
006AEC9A0  b        #0x6aec9b4 ; 
006AEC9A4  ldr      x8, [x2, #0x60]
006AEC9A8  mov      x0, x19
006AEC9AC  mov      w1, w20
006AEC9B0  blr      x8
006AEC9B4  mov      x0, x19
006AEC9B8  mov      x1, xzr
006AEC9BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AEC9C0  adrp     x21, #0x959f000
006AEC9C4  ldrb     w8, [x21, #0x21d]
006AEC9C8  mov      w20, w0
006AEC9CC  cbnz     w8, #0x6aec9e4
006AEC9D0  adrp     x0, #0x8f3d000
006AEC9D4  ldr      x0, [x0, #0x300]
006AEC9D8  bl       #0x382bd14 ; 
006AEC9DC  mov      w8, #1
006AEC9E0  strb     w8, [x21, #0x21d]
006AEC9E4  adrp     x8, #0x8f3d000
006AEC9E8  ldr      x8, [x8, #0x300]
006AEC9EC  ldr      x2, [x8]
006AEC9F0  ldrb     w8, [x2, #0x53]
006AEC9F4  tbnz     w8, #5, #0x6aeca00
006AEC9F8  str      w20, [x19, #0x2c]
006AEC9FC  b        #0x6aeca10 ; 
006AECA00  ldr      x8, [x2, #0x60]
006AECA04  mov      x0, x19
006AECA08  mov      w1, w20
006AECA0C  blr      x8
006AECA10  ldp      x20, x19, [sp, #0x10]
006AECA14  mov      w0, #1
006AECA18  ldp      x30, x21, [sp], #0x20
006AECA1C  ret      

