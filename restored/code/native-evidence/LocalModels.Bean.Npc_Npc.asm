; LocalModels.Bean.Npc_Npc$$readImpl
; RVA 0x6ACD52C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ACD52C  stp      x30, x21, [sp, #-0x20]!
006ACD530  stp      x20, x19, [sp, #0x10]
006ACD534  adrp     x20, #0x959e000
006ACD538  adrp     x21, #0x8f3b000
006ACD53C  ldrb     w8, [x20, #0xac0]
006ACD540  ldr      x21, [x21, #0xb80]
006ACD544  mov      x19, x0
006ACD548  tbnz     w8, #0, #0x6acd560
006ACD54C  adrp     x0, #0x8f3b000
006ACD550  ldr      x0, [x0, #0xb80]
006ACD554  bl       #0x382bd14 ; 
006ACD558  mov      w8, #1
006ACD55C  strb     w8, [x20, #0xac0]
006ACD560  ldr      x1, [x21]
006ACD564  ldrb     w8, [x1, #0x53]
006ACD568  tbnz     w8, #5, #0x6acd5b8
006ACD56C  mov      x0, x19
006ACD570  mov      x1, xzr
006ACD574  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACD578  adrp     x21, #0x959f000
006ACD57C  ldrb     w8, [x21, #0xc1]
006ACD580  mov      w20, w0
006ACD584  cbnz     w8, #0x6acd59c
006ACD588  adrp     x0, #0x8f3b000
006ACD58C  ldr      x0, [x0, #0xb38]
006ACD590  bl       #0x382bd14 ; 
006ACD594  mov      w8, #1
006ACD598  strb     w8, [x21, #0xc1]
006ACD59C  adrp     x8, #0x8f3b000
006ACD5A0  ldr      x8, [x8, #0xb38]
006ACD5A4  ldr      x2, [x8]
006ACD5A8  ldrb     w8, [x2, #0x53]
006ACD5AC  tbnz     w8, #5, #0x6acd5cc
006ACD5B0  str      w20, [x19, #0x20]
006ACD5B4  b        #0x6acd5dc ; 
006ACD5B8  ldr      x2, [x1, #0x60]
006ACD5BC  mov      x0, x19
006ACD5C0  ldp      x20, x19, [sp, #0x10]
006ACD5C4  ldp      x30, x21, [sp], #0x20
006ACD5C8  br       x2
006ACD5CC  ldr      x8, [x2, #0x60]
006ACD5D0  mov      x0, x19
006ACD5D4  mov      w1, w20
006ACD5D8  blr      x8
006ACD5DC  mov      x0, x19
006ACD5E0  mov      x1, xzr
006ACD5E4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ACD5E8  adrp     x21, #0x959f000
006ACD5EC  ldrb     w8, [x21, #0xc2]
006ACD5F0  mov      x20, x0
006ACD5F4  cbnz     w8, #0x6acd60c
006ACD5F8  adrp     x0, #0x8f3b000
006ACD5FC  ldr      x0, [x0, #0xb48]
006ACD600  bl       #0x382bd14 ; 
006ACD604  mov      w8, #1
006ACD608  strb     w8, [x21, #0xc2]
006ACD60C  adrp     x8, #0x8f3b000
006ACD610  ldr      x8, [x8, #0xb48]
006ACD614  ldr      x2, [x8]
006ACD618  ldrb     w8, [x2, #0x53]
006ACD61C  tbnz     w8, #5, #0x6acd634
006ACD620  mov      x0, x19
006ACD624  str      x20, [x0, #0x28]!
006ACD628  mov      x1, x20
006ACD62C  bl       #0x382bcb8 ; 
006ACD630  b        #0x6acd644 ; 
006ACD634  ldr      x8, [x2, #0x60]
006ACD638  mov      x0, x19
006ACD63C  mov      x1, x20
006ACD640  blr      x8
006ACD644  mov      x0, x19
006ACD648  mov      x1, xzr
006ACD64C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ACD650  adrp     x21, #0x959f000
006ACD654  ldrb     w8, [x21, #0xc3]
006ACD658  mov      x20, x0
006ACD65C  cbnz     w8, #0x6acd674
006ACD660  adrp     x0, #0x8f3b000
006ACD664  ldr      x0, [x0, #0xb58]
006ACD668  bl       #0x382bd14 ; 
006ACD66C  mov      w8, #1
006ACD670  strb     w8, [x21, #0xc3]
006ACD674  adrp     x8, #0x8f3b000
006ACD678  ldr      x8, [x8, #0xb58]
006ACD67C  ldr      x2, [x8]
006ACD680  ldrb     w8, [x2, #0x53]
006ACD684  tbnz     w8, #5, #0x6acd69c
006ACD688  mov      x0, x19
006ACD68C  str      x20, [x0, #0x30]!
006ACD690  mov      x1, x20
006ACD694  bl       #0x382bcb8 ; 
006ACD698  b        #0x6acd6ac ; 
006ACD69C  ldr      x8, [x2, #0x60]
006ACD6A0  mov      x0, x19
006ACD6A4  mov      x1, x20
006ACD6A8  blr      x8
006ACD6AC  mov      x0, x19
006ACD6B0  mov      x1, xzr
006ACD6B4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ACD6B8  adrp     x21, #0x959f000
006ACD6BC  ldrb     w8, [x21, #0xc4]
006ACD6C0  mov      x20, x0
006ACD6C4  cbnz     w8, #0x6acd6dc
006ACD6C8  adrp     x0, #0x8f3b000
006ACD6CC  ldr      x0, [x0, #0xb68]
006ACD6D0  bl       #0x382bd14 ; 
006ACD6D4  mov      w8, #1
006ACD6D8  strb     w8, [x21, #0xc4]
006ACD6DC  adrp     x8, #0x8f3b000
006ACD6E0  ldr      x8, [x8, #0xb68]
006ACD6E4  ldr      x2, [x8]
006ACD6E8  ldrb     w8, [x2, #0x53]
006ACD6EC  tbnz     w8, #5, #0x6acd704
006ACD6F0  mov      x0, x19
006ACD6F4  str      x20, [x0, #0x38]!
006ACD6F8  mov      x1, x20
006ACD6FC  bl       #0x382bcb8 ; 
006ACD700  b        #0x6acd714 ; 
006ACD704  ldr      x8, [x2, #0x60]
006ACD708  mov      x0, x19
006ACD70C  mov      x1, x20
006ACD710  blr      x8
006ACD714  mov      x0, x19
006ACD718  mov      x1, xzr
006ACD71C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACD720  adrp     x21, #0x959f000
006ACD724  ldrb     w8, [x21, #0xc5]
006ACD728  mov      w20, w0
006ACD72C  cbnz     w8, #0x6acd744
006ACD730  adrp     x0, #0x8f3b000
006ACD734  ldr      x0, [x0, #0xb78]
006ACD738  bl       #0x382bd14 ; 
006ACD73C  mov      w8, #1
006ACD740  strb     w8, [x21, #0xc5]
006ACD744  adrp     x8, #0x8f3b000
006ACD748  ldr      x8, [x8, #0xb78]
006ACD74C  ldr      x2, [x8]
006ACD750  ldrb     w8, [x2, #0x53]
006ACD754  tbnz     w8, #5, #0x6acd760
006ACD758  str      w20, [x19, #0x40]
006ACD75C  b        #0x6acd770 ; 
006ACD760  ldr      x8, [x2, #0x60]
006ACD764  mov      x0, x19
006ACD768  mov      w1, w20
006ACD76C  blr      x8
006ACD770  ldp      x20, x19, [sp, #0x10]
006ACD774  mov      w0, #1
006ACD778  ldp      x30, x21, [sp], #0x20
006ACD77C  ret      

