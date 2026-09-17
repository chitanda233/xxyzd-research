; LocalModels.Bean.Item_dropLv$$readImpl
; RVA 0x6AAD4E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AAD4E4  stp      x30, x21, [sp, #-0x20]!
006AAD4E8  stp      x20, x19, [sp, #0x10]
006AAD4EC  adrp     x20, #0x959e000
006AAD4F0  adrp     x21, #0x8f3a000
006AAD4F4  ldrb     w8, [x20, #0x779]
006AAD4F8  ldr      x21, [x21, #0x3f0]
006AAD4FC  mov      x19, x0
006AAD500  tbnz     w8, #0, #0x6aad518
006AAD504  adrp     x0, #0x8f3a000
006AAD508  ldr      x0, [x0, #0x3f0]
006AAD50C  bl       #0x382bd14 ; 
006AAD510  mov      w8, #1
006AAD514  strb     w8, [x20, #0x779]
006AAD518  ldr      x1, [x21]
006AAD51C  ldrb     w8, [x1, #0x53]
006AAD520  tbnz     w8, #5, #0x6aad570
006AAD524  mov      x0, x19
006AAD528  mov      x1, xzr
006AAD52C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAD530  adrp     x21, #0x959e000
006AAD534  ldrb     w8, [x21, #0xf4c]
006AAD538  mov      w20, w0
006AAD53C  cbnz     w8, #0x6aad554
006AAD540  adrp     x0, #0x8f3a000
006AAD544  ldr      x0, [x0, #0x3c8]
006AAD548  bl       #0x382bd14 ; 
006AAD54C  mov      w8, #1
006AAD550  strb     w8, [x21, #0xf4c]
006AAD554  adrp     x8, #0x8f3a000
006AAD558  ldr      x8, [x8, #0x3c8]
006AAD55C  ldr      x2, [x8]
006AAD560  ldrb     w8, [x2, #0x53]
006AAD564  tbnz     w8, #5, #0x6aad584
006AAD568  str      w20, [x19, #0x20]
006AAD56C  b        #0x6aad594 ; 
006AAD570  ldr      x2, [x1, #0x60]
006AAD574  mov      x0, x19
006AAD578  ldp      x20, x19, [sp, #0x10]
006AAD57C  ldp      x30, x21, [sp], #0x20
006AAD580  br       x2
006AAD584  ldr      x8, [x2, #0x60]
006AAD588  mov      x0, x19
006AAD58C  mov      w1, w20
006AAD590  blr      x8
006AAD594  mov      x0, x19
006AAD598  mov      x1, xzr
006AAD59C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AAD5A0  adrp     x21, #0x959e000
006AAD5A4  ldrb     w8, [x21, #0xf4d]
006AAD5A8  mov      x20, x0
006AAD5AC  cbnz     w8, #0x6aad5c4
006AAD5B0  adrp     x0, #0x8f3a000
006AAD5B4  ldr      x0, [x0, #0x3d8]
006AAD5B8  bl       #0x382bd14 ; 
006AAD5BC  mov      w8, #1
006AAD5C0  strb     w8, [x21, #0xf4d]
006AAD5C4  adrp     x8, #0x8f3a000
006AAD5C8  ldr      x8, [x8, #0x3d8]
006AAD5CC  ldr      x2, [x8]
006AAD5D0  ldrb     w8, [x2, #0x53]
006AAD5D4  tbnz     w8, #5, #0x6aad5ec
006AAD5D8  mov      x0, x19
006AAD5DC  str      x20, [x0, #0x28]!
006AAD5E0  mov      x1, x20
006AAD5E4  bl       #0x382bcb8 ; 
006AAD5E8  b        #0x6aad5fc ; 
006AAD5EC  ldr      x8, [x2, #0x60]
006AAD5F0  mov      x0, x19
006AAD5F4  mov      x1, x20
006AAD5F8  blr      x8
006AAD5FC  mov      x0, x19
006AAD600  mov      x1, xzr
006AAD604  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AAD608  adrp     x21, #0x959e000
006AAD60C  ldrb     w8, [x21, #0xf4e]
006AAD610  mov      x20, x0
006AAD614  cbnz     w8, #0x6aad62c
006AAD618  adrp     x0, #0x8f3a000
006AAD61C  ldr      x0, [x0, #0x3e8]
006AAD620  bl       #0x382bd14 ; 
006AAD624  mov      w8, #1
006AAD628  strb     w8, [x21, #0xf4e]
006AAD62C  adrp     x8, #0x8f3a000
006AAD630  ldr      x8, [x8, #0x3e8]
006AAD634  ldr      x2, [x8]
006AAD638  ldrb     w8, [x2, #0x53]
006AAD63C  tbnz     w8, #5, #0x6aad654
006AAD640  str      x20, [x19, #0x30]!
006AAD644  mov      x0, x19
006AAD648  mov      x1, x20
006AAD64C  bl       #0x382bcb8 ; 
006AAD650  b        #0x6aad664 ; 
006AAD654  ldr      x8, [x2, #0x60]
006AAD658  mov      x0, x19
006AAD65C  mov      x1, x20
006AAD660  blr      x8
006AAD664  ldp      x20, x19, [sp, #0x10]
006AAD668  mov      w0, #1
006AAD66C  ldp      x30, x21, [sp], #0x20
006AAD670  ret      

