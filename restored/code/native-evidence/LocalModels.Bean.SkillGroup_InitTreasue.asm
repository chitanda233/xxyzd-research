; LocalModels.Bean.SkillGroup_InitTreasue$$readImpl
; RVA 0x6AFA470; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AFA470  stp      x30, x21, [sp, #-0x20]!
006AFA474  stp      x20, x19, [sp, #0x10]
006AFA478  adrp     x20, #0x959f000
006AFA47C  adrp     x21, #0x8f3d000
006AFA480  ldrb     w8, [x20, #0x2f6]
006AFA484  ldr      x21, [x21, #0xd70]
006AFA488  mov      x19, x0
006AFA48C  tbnz     w8, #0, #0x6afa4a4
006AFA490  adrp     x0, #0x8f3d000
006AFA494  ldr      x0, [x0, #0xd70]
006AFA498  bl       #0x382bd14 ; 
006AFA49C  mov      w8, #1
006AFA4A0  strb     w8, [x20, #0x2f6]
006AFA4A4  ldr      x1, [x21]
006AFA4A8  ldrb     w8, [x1, #0x53]
006AFA4AC  tbnz     w8, #5, #0x6afa4fc
006AFA4B0  mov      x0, x19
006AFA4B4  mov      x1, xzr
006AFA4B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFA4BC  adrp     x21, #0x959f000
006AFA4C0  ldrb     w8, [x21, #0x89a]
006AFA4C4  mov      w20, w0
006AFA4C8  cbnz     w8, #0x6afa4e0
006AFA4CC  adrp     x0, #0x8f3d000
006AFA4D0  ldr      x0, [x0, #0xd48]
006AFA4D4  bl       #0x382bd14 ; 
006AFA4D8  mov      w8, #1
006AFA4DC  strb     w8, [x21, #0x89a]
006AFA4E0  adrp     x8, #0x8f3d000
006AFA4E4  ldr      x8, [x8, #0xd48]
006AFA4E8  ldr      x2, [x8]
006AFA4EC  ldrb     w8, [x2, #0x53]
006AFA4F0  tbnz     w8, #5, #0x6afa510
006AFA4F4  str      w20, [x19, #0x20]
006AFA4F8  b        #0x6afa520 ; 
006AFA4FC  ldr      x2, [x1, #0x60]
006AFA500  mov      x0, x19
006AFA504  ldp      x20, x19, [sp, #0x10]
006AFA508  ldp      x30, x21, [sp], #0x20
006AFA50C  br       x2
006AFA510  ldr      x8, [x2, #0x60]
006AFA514  mov      x0, x19
006AFA518  mov      w1, w20
006AFA51C  blr      x8
006AFA520  mov      x0, x19
006AFA524  mov      x1, xzr
006AFA528  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFA52C  adrp     x21, #0x959f000
006AFA530  ldrb     w8, [x21, #0x89b]
006AFA534  mov      w20, w0
006AFA538  cbnz     w8, #0x6afa550
006AFA53C  adrp     x0, #0x8f3d000
006AFA540  ldr      x0, [x0, #0xd58]
006AFA544  bl       #0x382bd14 ; 
006AFA548  mov      w8, #1
006AFA54C  strb     w8, [x21, #0x89b]
006AFA550  adrp     x8, #0x8f3d000
006AFA554  ldr      x8, [x8, #0xd58]
006AFA558  ldr      x2, [x8]
006AFA55C  ldrb     w8, [x2, #0x53]
006AFA560  tbnz     w8, #5, #0x6afa56c
006AFA564  str      w20, [x19, #0x24]
006AFA568  b        #0x6afa57c ; 
006AFA56C  ldr      x8, [x2, #0x60]
006AFA570  mov      x0, x19
006AFA574  mov      w1, w20
006AFA578  blr      x8
006AFA57C  mov      x0, x19
006AFA580  mov      x1, xzr
006AFA584  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AFA588  adrp     x21, #0x959f000
006AFA58C  ldrb     w8, [x21, #0x89c]
006AFA590  mov      w20, w0
006AFA594  cbnz     w8, #0x6afa5ac
006AFA598  adrp     x0, #0x8f3d000
006AFA59C  ldr      x0, [x0, #0xd68]
006AFA5A0  bl       #0x382bd14 ; 
006AFA5A4  mov      w8, #1
006AFA5A8  strb     w8, [x21, #0x89c]
006AFA5AC  adrp     x8, #0x8f3d000
006AFA5B0  ldr      x8, [x8, #0xd68]
006AFA5B4  ldr      x2, [x8]
006AFA5B8  ldrb     w8, [x2, #0x53]
006AFA5BC  tbnz     w8, #5, #0x6afa5c8
006AFA5C0  str      w20, [x19, #0x28]
006AFA5C4  b        #0x6afa5d8 ; 
006AFA5C8  ldr      x8, [x2, #0x60]
006AFA5CC  mov      x0, x19
006AFA5D0  mov      w1, w20
006AFA5D4  blr      x8
006AFA5D8  ldp      x20, x19, [sp, #0x10]
006AFA5DC  mov      w0, #1
006AFA5E0  ldp      x30, x21, [sp], #0x20
006AFA5E4  ret      

