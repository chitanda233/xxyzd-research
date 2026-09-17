; LocalModels.Bean.Shop_ScoreBox$$readImpl
; RVA 0x6AED580; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AED580  stp      x30, x21, [sp, #-0x20]!
006AED584  stp      x20, x19, [sp, #0x10]
006AED588  adrp     x20, #0x959e000
006AED58C  adrp     x21, #0x8f3d000
006AED590  ldrb     w8, [x20, #0xe0d]
006AED594  ldr      x21, [x21, #0x3a8]
006AED598  mov      x19, x0
006AED59C  tbnz     w8, #0, #0x6aed5b4
006AED5A0  adrp     x0, #0x8f3d000
006AED5A4  ldr      x0, [x0, #0x3a8]
006AED5A8  bl       #0x382bd14 ; 
006AED5AC  mov      w8, #1
006AED5B0  strb     w8, [x20, #0xe0d]
006AED5B4  ldr      x1, [x21]
006AED5B8  ldrb     w8, [x1, #0x53]
006AED5BC  tbnz     w8, #5, #0x6aed60c
006AED5C0  mov      x0, x19
006AED5C4  mov      x1, xzr
006AED5C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AED5CC  adrp     x21, #0x959f000
006AED5D0  ldrb     w8, [x21, #0x223]
006AED5D4  mov      w20, w0
006AED5D8  cbnz     w8, #0x6aed5f0
006AED5DC  adrp     x0, #0x8f3d000
006AED5E0  ldr      x0, [x0, #0x380]
006AED5E4  bl       #0x382bd14 ; 
006AED5E8  mov      w8, #1
006AED5EC  strb     w8, [x21, #0x223]
006AED5F0  adrp     x8, #0x8f3d000
006AED5F4  ldr      x8, [x8, #0x380]
006AED5F8  ldr      x2, [x8]
006AED5FC  ldrb     w8, [x2, #0x53]
006AED600  tbnz     w8, #5, #0x6aed620
006AED604  str      w20, [x19, #0x20]
006AED608  b        #0x6aed630 ; 
006AED60C  ldr      x2, [x1, #0x60]
006AED610  mov      x0, x19
006AED614  ldp      x20, x19, [sp, #0x10]
006AED618  ldp      x30, x21, [sp], #0x20
006AED61C  br       x2
006AED620  ldr      x8, [x2, #0x60]
006AED624  mov      x0, x19
006AED628  mov      w1, w20
006AED62C  blr      x8
006AED630  mov      x0, x19
006AED634  mov      x1, xzr
006AED638  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AED63C  adrp     x21, #0x959f000
006AED640  ldrb     w8, [x21, #0x224]
006AED644  mov      w20, w0
006AED648  cbnz     w8, #0x6aed660
006AED64C  adrp     x0, #0x8f3d000
006AED650  ldr      x0, [x0, #0x390]
006AED654  bl       #0x382bd14 ; 
006AED658  mov      w8, #1
006AED65C  strb     w8, [x21, #0x224]
006AED660  adrp     x8, #0x8f3d000
006AED664  ldr      x8, [x8, #0x390]
006AED668  ldr      x2, [x8]
006AED66C  ldrb     w8, [x2, #0x53]
006AED670  tbnz     w8, #5, #0x6aed67c
006AED674  str      w20, [x19, #0x24]
006AED678  b        #0x6aed68c ; 
006AED67C  ldr      x8, [x2, #0x60]
006AED680  mov      x0, x19
006AED684  mov      w1, w20
006AED688  blr      x8
006AED68C  mov      x0, x19
006AED690  mov      x1, xzr
006AED694  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AED698  adrp     x21, #0x959f000
006AED69C  ldrb     w8, [x21, #0x225]
006AED6A0  mov      w20, w0
006AED6A4  cbnz     w8, #0x6aed6bc
006AED6A8  adrp     x0, #0x8f3d000
006AED6AC  ldr      x0, [x0, #0x3a0]
006AED6B0  bl       #0x382bd14 ; 
006AED6B4  mov      w8, #1
006AED6B8  strb     w8, [x21, #0x225]
006AED6BC  adrp     x8, #0x8f3d000
006AED6C0  ldr      x8, [x8, #0x3a0]
006AED6C4  ldr      x2, [x8]
006AED6C8  ldrb     w8, [x2, #0x53]
006AED6CC  tbnz     w8, #5, #0x6aed6d8
006AED6D0  str      w20, [x19, #0x28]
006AED6D4  b        #0x6aed6e8 ; 
006AED6D8  ldr      x8, [x2, #0x60]
006AED6DC  mov      x0, x19
006AED6E0  mov      w1, w20
006AED6E4  blr      x8
006AED6E8  ldp      x20, x19, [sp, #0x10]
006AED6EC  mov      w0, #1
006AED6F0  ldp      x30, x21, [sp], #0x20
006AED6F4  ret      

