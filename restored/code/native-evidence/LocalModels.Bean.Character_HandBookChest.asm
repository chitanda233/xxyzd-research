; LocalModels.Bean.Character_HandBookChest$$readImpl
; RVA 0x68C7428; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068C7428  stp      x30, x21, [sp, #-0x20]!
0068C742C  stp      x20, x19, [sp, #0x10]
0068C7430  adrp     x20, #0x959c000
0068C7434  adrp     x21, #0x8f27000
0068C7438  ldrb     w8, [x20, #0x2b9]
0068C743C  ldr      x21, [x21, #0xff8]
0068C7440  mov      x19, x0
0068C7444  tbnz     w8, #0, #0x68c745c
0068C7448  adrp     x0, #0x8f27000
0068C744C  ldr      x0, [x0, #0xff8]
0068C7450  bl       #0x382bd14 ; 
0068C7454  mov      w8, #1
0068C7458  strb     w8, [x20, #0x2b9]
0068C745C  ldr      x1, [x21]
0068C7460  ldrb     w8, [x1, #0x53]
0068C7464  tbnz     w8, #5, #0x68c74b4
0068C7468  mov      x0, x19
0068C746C  mov      x1, xzr
0068C7470  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C7474  adrp     x21, #0x959c000
0068C7478  ldrb     w8, [x21, #0x6f5]
0068C747C  mov      w20, w0
0068C7480  cbnz     w8, #0x68c7498
0068C7484  adrp     x0, #0x8f27000
0068C7488  ldr      x0, [x0, #0xfb0]
0068C748C  bl       #0x382bd14 ; 
0068C7490  mov      w8, #1
0068C7494  strb     w8, [x21, #0x6f5]
0068C7498  adrp     x8, #0x8f27000
0068C749C  ldr      x8, [x8, #0xfb0]
0068C74A0  ldr      x2, [x8]
0068C74A4  ldrb     w8, [x2, #0x53]
0068C74A8  tbnz     w8, #5, #0x68c74c8
0068C74AC  str      w20, [x19, #0x20]
0068C74B0  b        #0x68c74d8 ; 
0068C74B4  ldr      x2, [x1, #0x60]
0068C74B8  mov      x0, x19
0068C74BC  ldp      x20, x19, [sp, #0x10]
0068C74C0  ldp      x30, x21, [sp], #0x20
0068C74C4  br       x2
0068C74C8  ldr      x8, [x2, #0x60]
0068C74CC  mov      x0, x19
0068C74D0  mov      w1, w20
0068C74D4  blr      x8
0068C74D8  mov      x0, x19
0068C74DC  mov      x1, xzr
0068C74E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C74E4  adrp     x21, #0x959c000
0068C74E8  ldrb     w8, [x21, #0x6f6]
0068C74EC  mov      w20, w0
0068C74F0  cbnz     w8, #0x68c7508
0068C74F4  adrp     x0, #0x8f27000
0068C74F8  ldr      x0, [x0, #0xfc0]
0068C74FC  bl       #0x382bd14 ; 
0068C7500  mov      w8, #1
0068C7504  strb     w8, [x21, #0x6f6]
0068C7508  adrp     x8, #0x8f27000
0068C750C  ldr      x8, [x8, #0xfc0]
0068C7510  ldr      x2, [x8]
0068C7514  ldrb     w8, [x2, #0x53]
0068C7518  tbnz     w8, #5, #0x68c7524
0068C751C  str      w20, [x19, #0x24]
0068C7520  b        #0x68c7534 ; 
0068C7524  ldr      x8, [x2, #0x60]
0068C7528  mov      x0, x19
0068C752C  mov      w1, w20
0068C7530  blr      x8
0068C7534  mov      x0, x19
0068C7538  mov      x1, xzr
0068C753C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C7540  adrp     x21, #0x959c000
0068C7544  ldrb     w8, [x21, #0x6f7]
0068C7548  mov      x20, x0
0068C754C  cbnz     w8, #0x68c7564
0068C7550  adrp     x0, #0x8f27000
0068C7554  ldr      x0, [x0, #0xfd0]
0068C7558  bl       #0x382bd14 ; 
0068C755C  mov      w8, #1
0068C7560  strb     w8, [x21, #0x6f7]
0068C7564  adrp     x8, #0x8f27000
0068C7568  ldr      x8, [x8, #0xfd0]
0068C756C  ldr      x2, [x8]
0068C7570  ldrb     w8, [x2, #0x53]
0068C7574  tbnz     w8, #5, #0x68c758c
0068C7578  mov      x0, x19
0068C757C  str      x20, [x0, #0x28]!
0068C7580  mov      x1, x20
0068C7584  bl       #0x382bcb8 ; 
0068C7588  b        #0x68c759c ; 
0068C758C  ldr      x8, [x2, #0x60]
0068C7590  mov      x0, x19
0068C7594  mov      x1, x20
0068C7598  blr      x8
0068C759C  mov      x0, x19
0068C75A0  mov      x1, xzr
0068C75A4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068C75A8  adrp     x21, #0x959c000
0068C75AC  ldrb     w8, [x21, #0x6f8]
0068C75B0  mov      x20, x0
0068C75B4  cbnz     w8, #0x68c75cc
0068C75B8  adrp     x0, #0x8f27000
0068C75BC  ldr      x0, [x0, #0xfe0]
0068C75C0  bl       #0x382bd14 ; 
0068C75C4  mov      w8, #1
0068C75C8  strb     w8, [x21, #0x6f8]
0068C75CC  adrp     x8, #0x8f27000
0068C75D0  ldr      x8, [x8, #0xfe0]
0068C75D4  ldr      x2, [x8]
0068C75D8  ldrb     w8, [x2, #0x53]
0068C75DC  tbnz     w8, #5, #0x68c75f4
0068C75E0  mov      x0, x19
0068C75E4  str      x20, [x0, #0x30]!
0068C75E8  mov      x1, x20
0068C75EC  bl       #0x382bcb8 ; 
0068C75F0  b        #0x68c7604 ; 
0068C75F4  ldr      x8, [x2, #0x60]
0068C75F8  mov      x0, x19
0068C75FC  mov      x1, x20
0068C7600  blr      x8
0068C7604  mov      x0, x19
0068C7608  mov      x1, xzr
0068C760C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C7610  adrp     x21, #0x959c000
0068C7614  ldrb     w8, [x21, #0x6f9]
0068C7618  mov      w20, w0
0068C761C  cbnz     w8, #0x68c7634
0068C7620  adrp     x0, #0x8f27000
0068C7624  ldr      x0, [x0, #0xff0]
0068C7628  bl       #0x382bd14 ; 
0068C762C  mov      w8, #1
0068C7630  strb     w8, [x21, #0x6f9]
0068C7634  adrp     x8, #0x8f27000
0068C7638  ldr      x8, [x8, #0xff0]
0068C763C  ldr      x2, [x8]
0068C7640  ldrb     w8, [x2, #0x53]
0068C7644  tbnz     w8, #5, #0x68c7650
0068C7648  str      w20, [x19, #0x38]
0068C764C  b        #0x68c7660 ; 
0068C7650  ldr      x8, [x2, #0x60]
0068C7654  mov      x0, x19
0068C7658  mov      w1, w20
0068C765C  blr      x8
0068C7660  ldp      x20, x19, [sp, #0x10]
0068C7664  mov      w0, #1
0068C7668  ldp      x30, x21, [sp], #0x20
0068C766C  ret      

