; LocalModels.Bean.ServerList_serverGroup$$readImpl
; RVA 0x6AE73DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE73DC  stp      x30, x21, [sp, #-0x20]!
006AE73E0  stp      x20, x19, [sp, #0x10]
006AE73E4  adrp     x20, #0x959e000
006AE73E8  adrp     x21, #0x8f3c000
006AE73EC  ldrb     w8, [x20, #0xd69]
006AE73F0  ldr      x21, [x21, #0xed8]
006AE73F4  mov      x19, x0
006AE73F8  tbnz     w8, #0, #0x6ae7410
006AE73FC  adrp     x0, #0x8f3c000
006AE7400  ldr      x0, [x0, #0xed8]
006AE7404  bl       #0x382bd14 ; 
006AE7408  mov      w8, #1
006AE740C  strb     w8, [x20, #0xd69]
006AE7410  ldr      x1, [x21]
006AE7414  ldrb     w8, [x1, #0x53]
006AE7418  tbnz     w8, #5, #0x6ae7468
006AE741C  mov      x0, x19
006AE7420  mov      x1, xzr
006AE7424  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE7428  adrp     x21, #0x959f000
006AE742C  ldrb     w8, [x21, #0x1e0]
006AE7430  mov      w20, w0
006AE7434  cbnz     w8, #0x6ae744c
006AE7438  adrp     x0, #0x8f3c000
006AE743C  ldr      x0, [x0, #0xeb0]
006AE7440  bl       #0x382bd14 ; 
006AE7444  mov      w8, #1
006AE7448  strb     w8, [x21, #0x1e0]
006AE744C  adrp     x8, #0x8f3c000
006AE7450  ldr      x8, [x8, #0xeb0]
006AE7454  ldr      x2, [x8]
006AE7458  ldrb     w8, [x2, #0x53]
006AE745C  tbnz     w8, #5, #0x6ae747c
006AE7460  str      w20, [x19, #0x20]
006AE7464  b        #0x6ae748c ; 
006AE7468  ldr      x2, [x1, #0x60]
006AE746C  mov      x0, x19
006AE7470  ldp      x20, x19, [sp, #0x10]
006AE7474  ldp      x30, x21, [sp], #0x20
006AE7478  br       x2
006AE747C  ldr      x8, [x2, #0x60]
006AE7480  mov      x0, x19
006AE7484  mov      w1, w20
006AE7488  blr      x8
006AE748C  mov      x0, x19
006AE7490  mov      x1, xzr
006AE7494  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AE7498  adrp     x21, #0x959f000
006AE749C  ldrb     w8, [x21, #0x1e1]
006AE74A0  mov      x20, x0
006AE74A4  cbnz     w8, #0x6ae74bc
006AE74A8  adrp     x0, #0x8f3c000
006AE74AC  ldr      x0, [x0, #0xec0]
006AE74B0  bl       #0x382bd14 ; 
006AE74B4  mov      w8, #1
006AE74B8  strb     w8, [x21, #0x1e1]
006AE74BC  adrp     x8, #0x8f3c000
006AE74C0  ldr      x8, [x8, #0xec0]
006AE74C4  ldr      x2, [x8]
006AE74C8  ldrb     w8, [x2, #0x53]
006AE74CC  tbnz     w8, #5, #0x6ae74e4
006AE74D0  mov      x0, x19
006AE74D4  str      x20, [x0, #0x28]!
006AE74D8  mov      x1, x20
006AE74DC  bl       #0x382bcb8 ; 
006AE74E0  b        #0x6ae74f4 ; 
006AE74E4  ldr      x8, [x2, #0x60]
006AE74E8  mov      x0, x19
006AE74EC  mov      x1, x20
006AE74F0  blr      x8
006AE74F4  mov      x0, x19
006AE74F8  mov      x1, xzr
006AE74FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE7500  adrp     x21, #0x959f000
006AE7504  ldrb     w8, [x21, #0x1e2]
006AE7508  mov      w20, w0
006AE750C  cbnz     w8, #0x6ae7524
006AE7510  adrp     x0, #0x8f3c000
006AE7514  ldr      x0, [x0, #0xed0]
006AE7518  bl       #0x382bd14 ; 
006AE751C  mov      w8, #1
006AE7520  strb     w8, [x21, #0x1e2]
006AE7524  adrp     x8, #0x8f3c000
006AE7528  ldr      x8, [x8, #0xed0]
006AE752C  ldr      x2, [x8]
006AE7530  ldrb     w8, [x2, #0x53]
006AE7534  tbnz     w8, #5, #0x6ae7540
006AE7538  str      w20, [x19, #0x30]
006AE753C  b        #0x6ae7550 ; 
006AE7540  ldr      x8, [x2, #0x60]
006AE7544  mov      x0, x19
006AE7548  mov      w1, w20
006AE754C  blr      x8
006AE7550  ldp      x20, x19, [sp, #0x10]
006AE7554  mov      w0, #1
006AE7558  ldp      x30, x21, [sp], #0x20
006AE755C  ret      

