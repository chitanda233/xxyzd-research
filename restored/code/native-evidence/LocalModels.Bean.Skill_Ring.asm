; LocalModels.Bean.Skill_Ring$$readImpl
; RVA 0x6B0B3B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0B3B0  stp      x30, x21, [sp, #-0x20]!
006B0B3B4  stp      x20, x19, [sp, #0x10]
006B0B3B8  adrp     x20, #0x959f000
006B0B3BC  adrp     x21, #0x8f3e000
006B0B3C0  ldrb     w8, [x20, #0x4ac]
006B0B3C4  ldr      x21, [x21, #0x8e8]
006B0B3C8  mov      x19, x0
006B0B3CC  tbnz     w8, #0, #0x6b0b3e4
006B0B3D0  adrp     x0, #0x8f3e000
006B0B3D4  ldr      x0, [x0, #0x8e8]
006B0B3D8  bl       #0x382bd14 ; 
006B0B3DC  mov      w8, #1
006B0B3E0  strb     w8, [x20, #0x4ac]
006B0B3E4  ldr      x1, [x21]
006B0B3E8  ldrb     w8, [x1, #0x53]
006B0B3EC  tbnz     w8, #5, #0x6b0b43c
006B0B3F0  mov      x0, x19
006B0B3F4  mov      x1, xzr
006B0B3F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0B3FC  adrp     x21, #0x959f000
006B0B400  ldrb     w8, [x21, #0x96b]
006B0B404  mov      w20, w0
006B0B408  cbnz     w8, #0x6b0b420
006B0B40C  adrp     x0, #0x8f3e000
006B0B410  ldr      x0, [x0, #0x8b0]
006B0B414  bl       #0x382bd14 ; 
006B0B418  mov      w8, #1
006B0B41C  strb     w8, [x21, #0x96b]
006B0B420  adrp     x8, #0x8f3e000
006B0B424  ldr      x8, [x8, #0x8b0]
006B0B428  ldr      x2, [x8]
006B0B42C  ldrb     w8, [x2, #0x53]
006B0B430  tbnz     w8, #5, #0x6b0b450
006B0B434  str      w20, [x19, #0x20]
006B0B438  b        #0x6b0b460 ; 
006B0B43C  ldr      x2, [x1, #0x60]
006B0B440  mov      x0, x19
006B0B444  ldp      x20, x19, [sp, #0x10]
006B0B448  ldp      x30, x21, [sp], #0x20
006B0B44C  br       x2
006B0B450  ldr      x8, [x2, #0x60]
006B0B454  mov      x0, x19
006B0B458  mov      w1, w20
006B0B45C  blr      x8
006B0B460  mov      x0, x19
006B0B464  mov      x1, xzr
006B0B468  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0B46C  adrp     x21, #0x959f000
006B0B470  ldrb     w8, [x21, #0x96c]
006B0B474  mov      x20, x0
006B0B478  cbnz     w8, #0x6b0b490
006B0B47C  adrp     x0, #0x8f3e000
006B0B480  ldr      x0, [x0, #0x8b8]
006B0B484  bl       #0x382bd14 ; 
006B0B488  mov      w8, #1
006B0B48C  strb     w8, [x21, #0x96c]
006B0B490  adrp     x8, #0x8f3e000
006B0B494  ldr      x8, [x8, #0x8b8]
006B0B498  ldr      x2, [x8]
006B0B49C  ldrb     w8, [x2, #0x53]
006B0B4A0  tbnz     w8, #5, #0x6b0b4b8
006B0B4A4  mov      x0, x19
006B0B4A8  str      x20, [x0, #0x28]!
006B0B4AC  mov      x1, x20
006B0B4B0  bl       #0x382bcb8 ; 
006B0B4B4  b        #0x6b0b4c8 ; 
006B0B4B8  ldr      x8, [x2, #0x60]
006B0B4BC  mov      x0, x19
006B0B4C0  mov      x1, x20
006B0B4C4  blr      x8
006B0B4C8  mov      x0, x19
006B0B4CC  mov      x1, xzr
006B0B4D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0B4D4  adrp     x21, #0x959f000
006B0B4D8  ldrb     w8, [x21, #0x96d]
006B0B4DC  mov      w20, w0
006B0B4E0  cbnz     w8, #0x6b0b4f8
006B0B4E4  adrp     x0, #0x8f3e000
006B0B4E8  ldr      x0, [x0, #0x8c0]
006B0B4EC  bl       #0x382bd14 ; 
006B0B4F0  mov      w8, #1
006B0B4F4  strb     w8, [x21, #0x96d]
006B0B4F8  adrp     x8, #0x8f3e000
006B0B4FC  ldr      x8, [x8, #0x8c0]
006B0B500  ldr      x2, [x8]
006B0B504  ldrb     w8, [x2, #0x53]
006B0B508  tbnz     w8, #5, #0x6b0b514
006B0B50C  str      w20, [x19, #0x30]
006B0B510  b        #0x6b0b524 ; 
006B0B514  ldr      x8, [x2, #0x60]
006B0B518  mov      x0, x19
006B0B51C  mov      w1, w20
006B0B520  blr      x8
006B0B524  mov      x0, x19
006B0B528  mov      x1, xzr
006B0B52C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B0B530  adrp     x21, #0x959f000
006B0B534  ldrb     w8, [x21, #0x96e]
006B0B538  mov      x20, x0
006B0B53C  cbnz     w8, #0x6b0b554
006B0B540  adrp     x0, #0x8f3e000
006B0B544  ldr      x0, [x0, #0x8c8]
006B0B548  bl       #0x382bd14 ; 
006B0B54C  mov      w8, #1
006B0B550  strb     w8, [x21, #0x96e]
006B0B554  adrp     x8, #0x8f3e000
006B0B558  ldr      x8, [x8, #0x8c8]
006B0B55C  ldr      x2, [x8]
006B0B560  ldrb     w8, [x2, #0x53]
006B0B564  tbnz     w8, #5, #0x6b0b570
006B0B568  str      x20, [x19, #0x38]
006B0B56C  b        #0x6b0b580 ; 
006B0B570  ldr      x8, [x2, #0x60]
006B0B574  mov      x0, x19
006B0B578  mov      x1, x20
006B0B57C  blr      x8
006B0B580  mov      x0, x19
006B0B584  mov      x1, xzr
006B0B588  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B0B58C  adrp     x21, #0x959f000
006B0B590  ldrb     w8, [x21, #0x96f]
006B0B594  mov      x20, x0
006B0B598  cbnz     w8, #0x6b0b5b0
006B0B59C  adrp     x0, #0x8f3e000
006B0B5A0  ldr      x0, [x0, #0x8d0]
006B0B5A4  bl       #0x382bd14 ; 
006B0B5A8  mov      w8, #1
006B0B5AC  strb     w8, [x21, #0x96f]
006B0B5B0  adrp     x8, #0x8f3e000
006B0B5B4  ldr      x8, [x8, #0x8d0]
006B0B5B8  ldr      x2, [x8]
006B0B5BC  ldrb     w8, [x2, #0x53]
006B0B5C0  tbnz     w8, #5, #0x6b0b5d8
006B0B5C4  mov      x0, x19
006B0B5C8  str      x20, [x0, #0x40]!
006B0B5CC  mov      x1, x20
006B0B5D0  bl       #0x382bcb8 ; 
006B0B5D4  b        #0x6b0b5e8 ; 
006B0B5D8  ldr      x8, [x2, #0x60]
006B0B5DC  mov      x0, x19
006B0B5E0  mov      x1, x20
006B0B5E4  blr      x8
006B0B5E8  mov      x0, x19
006B0B5EC  mov      x1, xzr
006B0B5F0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B0B5F4  adrp     x21, #0x959f000
006B0B5F8  ldrb     w8, [x21, #0x970]
006B0B5FC  mov      x20, x0
006B0B600  cbnz     w8, #0x6b0b618
006B0B604  adrp     x0, #0x8f3e000
006B0B608  ldr      x0, [x0, #0x8d8]
006B0B60C  bl       #0x382bd14 ; 
006B0B610  mov      w8, #1
006B0B614  strb     w8, [x21, #0x970]
006B0B618  adrp     x8, #0x8f3e000
006B0B61C  ldr      x8, [x8, #0x8d8]
006B0B620  ldr      x2, [x8]
006B0B624  ldrb     w8, [x2, #0x53]
006B0B628  tbnz     w8, #5, #0x6b0b640
006B0B62C  mov      x0, x19
006B0B630  str      x20, [x0, #0x48]!
006B0B634  mov      x1, x20
006B0B638  bl       #0x382bcb8 ; 
006B0B63C  b        #0x6b0b650 ; 
006B0B640  ldr      x8, [x2, #0x60]
006B0B644  mov      x0, x19
006B0B648  mov      x1, x20
006B0B64C  blr      x8
006B0B650  mov      x0, x19
006B0B654  mov      x1, xzr
006B0B658  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0B65C  adrp     x21, #0x959f000
006B0B660  ldrb     w8, [x21, #0x971]
006B0B664  mov      w20, w0
006B0B668  cbnz     w8, #0x6b0b680
006B0B66C  adrp     x0, #0x8f3e000
006B0B670  ldr      x0, [x0, #0x8e0]
006B0B674  bl       #0x382bd14 ; 
006B0B678  mov      w8, #1
006B0B67C  strb     w8, [x21, #0x971]
006B0B680  adrp     x8, #0x8f3e000
006B0B684  ldr      x8, [x8, #0x8e0]
006B0B688  ldr      x2, [x8]
006B0B68C  ldrb     w8, [x2, #0x53]
006B0B690  tbnz     w8, #5, #0x6b0b69c
006B0B694  str      w20, [x19, #0x50]
006B0B698  b        #0x6b0b6ac ; 
006B0B69C  ldr      x8, [x2, #0x60]
006B0B6A0  mov      x0, x19
006B0B6A4  mov      w1, w20
006B0B6A8  blr      x8
006B0B6AC  ldp      x20, x19, [sp, #0x10]
006B0B6B0  mov      w0, #1
006B0B6B4  ldp      x30, x21, [sp], #0x20
006B0B6B8  ret      

