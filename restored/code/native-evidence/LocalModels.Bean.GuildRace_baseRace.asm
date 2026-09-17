; LocalModels.Bean.GuildRace_baseRace$$readImpl
; RVA 0x6A8A540; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A8A540  stp      x30, x21, [sp, #-0x20]!
006A8A544  stp      x20, x19, [sp, #0x10]
006A8A548  adrp     x20, #0x959e000
006A8A54C  adrp     x21, #0x8f38000
006A8A550  ldrb     w8, [x20, #0x4f]
006A8A554  ldr      x21, [x21, #0x9a0]
006A8A558  mov      x19, x0
006A8A55C  tbnz     w8, #0, #0x6a8a574
006A8A560  adrp     x0, #0x8f38000
006A8A564  ldr      x0, [x0, #0x9a0]
006A8A568  bl       #0x382bd14 ; 
006A8A56C  mov      w8, #1
006A8A570  strb     w8, [x20, #0x4f]
006A8A574  ldr      x1, [x21]
006A8A578  ldrb     w8, [x1, #0x53]
006A8A57C  tbnz     w8, #5, #0x6a8a5cc
006A8A580  mov      x0, x19
006A8A584  mov      x1, xzr
006A8A588  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8A58C  adrp     x21, #0x959e000
006A8A590  ldrb     w8, [x21, #0x567]
006A8A594  mov      w20, w0
006A8A598  cbnz     w8, #0x6a8a5b0
006A8A59C  adrp     x0, #0x8f38000
006A8A5A0  ldr      x0, [x0, #0x968]
006A8A5A4  bl       #0x382bd14 ; 
006A8A5A8  mov      w8, #1
006A8A5AC  strb     w8, [x21, #0x567]
006A8A5B0  adrp     x8, #0x8f38000
006A8A5B4  ldr      x8, [x8, #0x968]
006A8A5B8  ldr      x2, [x8]
006A8A5BC  ldrb     w8, [x2, #0x53]
006A8A5C0  tbnz     w8, #5, #0x6a8a5e0
006A8A5C4  str      w20, [x19, #0x20]
006A8A5C8  b        #0x6a8a5f0 ; 
006A8A5CC  ldr      x2, [x1, #0x60]
006A8A5D0  mov      x0, x19
006A8A5D4  ldp      x20, x19, [sp, #0x10]
006A8A5D8  ldp      x30, x21, [sp], #0x20
006A8A5DC  br       x2
006A8A5E0  ldr      x8, [x2, #0x60]
006A8A5E4  mov      x0, x19
006A8A5E8  mov      w1, w20
006A8A5EC  blr      x8
006A8A5F0  mov      x0, x19
006A8A5F4  mov      x1, xzr
006A8A5F8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A8A5FC  adrp     x21, #0x959e000
006A8A600  ldrb     w8, [x21, #0x568]
006A8A604  mov      x20, x0
006A8A608  cbnz     w8, #0x6a8a620
006A8A60C  adrp     x0, #0x8f38000
006A8A610  ldr      x0, [x0, #0x978]
006A8A614  bl       #0x382bd14 ; 
006A8A618  mov      w8, #1
006A8A61C  strb     w8, [x21, #0x568]
006A8A620  adrp     x8, #0x8f38000
006A8A624  ldr      x8, [x8, #0x978]
006A8A628  ldr      x2, [x8]
006A8A62C  ldrb     w8, [x2, #0x53]
006A8A630  tbnz     w8, #5, #0x6a8a648
006A8A634  mov      x0, x19
006A8A638  str      x20, [x0, #0x28]!
006A8A63C  mov      x1, x20
006A8A640  bl       #0x382bcb8 ; 
006A8A644  b        #0x6a8a658 ; 
006A8A648  ldr      x8, [x2, #0x60]
006A8A64C  mov      x0, x19
006A8A650  mov      x1, x20
006A8A654  blr      x8
006A8A658  mov      x0, x19
006A8A65C  mov      x1, xzr
006A8A660  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8A664  adrp     x21, #0x959e000
006A8A668  ldrb     w8, [x21, #0x569]
006A8A66C  mov      w20, w0
006A8A670  cbnz     w8, #0x6a8a688
006A8A674  adrp     x0, #0x8f38000
006A8A678  ldr      x0, [x0, #0x988]
006A8A67C  bl       #0x382bd14 ; 
006A8A680  mov      w8, #1
006A8A684  strb     w8, [x21, #0x569]
006A8A688  adrp     x8, #0x8f38000
006A8A68C  ldr      x8, [x8, #0x988]
006A8A690  ldr      x2, [x8]
006A8A694  ldrb     w8, [x2, #0x53]
006A8A698  tbnz     w8, #5, #0x6a8a6a4
006A8A69C  str      w20, [x19, #0x30]
006A8A6A0  b        #0x6a8a6b4 ; 
006A8A6A4  ldr      x8, [x2, #0x60]
006A8A6A8  mov      x0, x19
006A8A6AC  mov      w1, w20
006A8A6B0  blr      x8
006A8A6B4  mov      x0, x19
006A8A6B8  mov      x1, xzr
006A8A6BC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A8A6C0  adrp     x21, #0x959e000
006A8A6C4  ldrb     w8, [x21, #0x56a]
006A8A6C8  mov      x20, x0
006A8A6CC  cbnz     w8, #0x6a8a6e4
006A8A6D0  adrp     x0, #0x8f38000
006A8A6D4  ldr      x0, [x0, #0x998]
006A8A6D8  bl       #0x382bd14 ; 
006A8A6DC  mov      w8, #1
006A8A6E0  strb     w8, [x21, #0x56a]
006A8A6E4  adrp     x8, #0x8f38000
006A8A6E8  ldr      x8, [x8, #0x998]
006A8A6EC  ldr      x2, [x8]
006A8A6F0  ldrb     w8, [x2, #0x53]
006A8A6F4  tbnz     w8, #5, #0x6a8a70c
006A8A6F8  str      x20, [x19, #0x38]!
006A8A6FC  mov      x0, x19
006A8A700  mov      x1, x20
006A8A704  bl       #0x382bcb8 ; 
006A8A708  b        #0x6a8a71c ; 
006A8A70C  ldr      x8, [x2, #0x60]
006A8A710  mov      x0, x19
006A8A714  mov      x1, x20
006A8A718  blr      x8
006A8A71C  ldp      x20, x19, [sp, #0x10]
006A8A720  mov      w0, #1
006A8A724  ldp      x30, x21, [sp], #0x20
006A8A728  ret      

