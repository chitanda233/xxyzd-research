; LocalModels.Bean.DrawBox_LootBox$$readImpl
; RVA 0x6A5C2D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A5C2D4  stp      x30, x21, [sp, #-0x20]!
006A5C2D8  stp      x20, x19, [sp, #0x10]
006A5C2DC  adrp     x20, #0x959d000
006A5C2E0  adrp     x21, #0x8f36000
006A5C2E4  ldrb     w8, [x20, #0xb8a]
006A5C2E8  ldr      x21, [x21, #0x6f0]
006A5C2EC  mov      x19, x0
006A5C2F0  tbnz     w8, #0, #0x6a5c308
006A5C2F4  adrp     x0, #0x8f36000
006A5C2F8  ldr      x0, [x0, #0x6f0]
006A5C2FC  bl       #0x382bd14 ; 
006A5C300  mov      w8, #1
006A5C304  strb     w8, [x20, #0xb8a]
006A5C308  ldr      x1, [x21]
006A5C30C  ldrb     w8, [x1, #0x53]
006A5C310  tbnz     w8, #5, #0x6a5c360
006A5C314  mov      x0, x19
006A5C318  mov      x1, xzr
006A5C31C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5C320  adrp     x21, #0x959e000
006A5C324  ldrb     w8, [x21, #0x369]
006A5C328  mov      w20, w0
006A5C32C  cbnz     w8, #0x6a5c344
006A5C330  adrp     x0, #0x8f36000
006A5C334  ldr      x0, [x0, #0x658]
006A5C338  bl       #0x382bd14 ; 
006A5C33C  mov      w8, #1
006A5C340  strb     w8, [x21, #0x369]
006A5C344  adrp     x8, #0x8f36000
006A5C348  ldr      x8, [x8, #0x658]
006A5C34C  ldr      x2, [x8]
006A5C350  ldrb     w8, [x2, #0x53]
006A5C354  tbnz     w8, #5, #0x6a5c374
006A5C358  str      w20, [x19, #0x20]
006A5C35C  b        #0x6a5c384 ; 
006A5C360  ldr      x2, [x1, #0x60]
006A5C364  mov      x0, x19
006A5C368  ldp      x20, x19, [sp, #0x10]
006A5C36C  ldp      x30, x21, [sp], #0x20
006A5C370  br       x2
006A5C374  ldr      x8, [x2, #0x60]
006A5C378  mov      x0, x19
006A5C37C  mov      w1, w20
006A5C380  blr      x8
006A5C384  mov      x0, x19
006A5C388  mov      x1, xzr
006A5C38C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5C390  adrp     x21, #0x959e000
006A5C394  ldrb     w8, [x21, #0x36a]
006A5C398  mov      w20, w0
006A5C39C  cbnz     w8, #0x6a5c3b4
006A5C3A0  adrp     x0, #0x8f36000
006A5C3A4  ldr      x0, [x0, #0x668]
006A5C3A8  bl       #0x382bd14 ; 
006A5C3AC  mov      w8, #1
006A5C3B0  strb     w8, [x21, #0x36a]
006A5C3B4  adrp     x8, #0x8f36000
006A5C3B8  ldr      x8, [x8, #0x668]
006A5C3BC  ldr      x2, [x8]
006A5C3C0  ldrb     w8, [x2, #0x53]
006A5C3C4  tbnz     w8, #5, #0x6a5c3d0
006A5C3C8  str      w20, [x19, #0x24]
006A5C3CC  b        #0x6a5c3e0 ; 
006A5C3D0  ldr      x8, [x2, #0x60]
006A5C3D4  mov      x0, x19
006A5C3D8  mov      w1, w20
006A5C3DC  blr      x8
006A5C3E0  mov      x0, x19
006A5C3E4  mov      x1, xzr
006A5C3E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5C3EC  adrp     x21, #0x959e000
006A5C3F0  ldrb     w8, [x21, #0x36b]
006A5C3F4  mov      w20, w0
006A5C3F8  cbnz     w8, #0x6a5c410
006A5C3FC  adrp     x0, #0x8f36000
006A5C400  ldr      x0, [x0, #0x678]
006A5C404  bl       #0x382bd14 ; 
006A5C408  mov      w8, #1
006A5C40C  strb     w8, [x21, #0x36b]
006A5C410  adrp     x8, #0x8f36000
006A5C414  ldr      x8, [x8, #0x678]
006A5C418  ldr      x2, [x8]
006A5C41C  ldrb     w8, [x2, #0x53]
006A5C420  tbnz     w8, #5, #0x6a5c42c
006A5C424  str      w20, [x19, #0x28]
006A5C428  b        #0x6a5c43c ; 
006A5C42C  ldr      x8, [x2, #0x60]
006A5C430  mov      x0, x19
006A5C434  mov      w1, w20
006A5C438  blr      x8
006A5C43C  mov      x0, x19
006A5C440  mov      x1, xzr
006A5C444  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5C448  adrp     x21, #0x959e000
006A5C44C  ldrb     w8, [x21, #0x36c]
006A5C450  mov      w20, w0
006A5C454  cbnz     w8, #0x6a5c46c
006A5C458  adrp     x0, #0x8f36000
006A5C45C  ldr      x0, [x0, #0x688]
006A5C460  bl       #0x382bd14 ; 
006A5C464  mov      w8, #1
006A5C468  strb     w8, [x21, #0x36c]
006A5C46C  adrp     x8, #0x8f36000
006A5C470  ldr      x8, [x8, #0x688]
006A5C474  ldr      x2, [x8]
006A5C478  ldrb     w8, [x2, #0x53]
006A5C47C  tbnz     w8, #5, #0x6a5c488
006A5C480  str      w20, [x19, #0x2c]
006A5C484  b        #0x6a5c498 ; 
006A5C488  ldr      x8, [x2, #0x60]
006A5C48C  mov      x0, x19
006A5C490  mov      w1, w20
006A5C494  blr      x8
006A5C498  mov      x0, x19
006A5C49C  mov      x1, xzr
006A5C4A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5C4A4  adrp     x21, #0x959e000
006A5C4A8  ldrb     w8, [x21, #0x36d]
006A5C4AC  mov      w20, w0
006A5C4B0  cbnz     w8, #0x6a5c4c8
006A5C4B4  adrp     x0, #0x8f36000
006A5C4B8  ldr      x0, [x0, #0x698]
006A5C4BC  bl       #0x382bd14 ; 
006A5C4C0  mov      w8, #1
006A5C4C4  strb     w8, [x21, #0x36d]
006A5C4C8  adrp     x8, #0x8f36000
006A5C4CC  ldr      x8, [x8, #0x698]
006A5C4D0  ldr      x2, [x8]
006A5C4D4  ldrb     w8, [x2, #0x53]
006A5C4D8  tbnz     w8, #5, #0x6a5c4e4
006A5C4DC  str      w20, [x19, #0x30]
006A5C4E0  b        #0x6a5c4f4 ; 
006A5C4E4  ldr      x8, [x2, #0x60]
006A5C4E8  mov      x0, x19
006A5C4EC  mov      w1, w20
006A5C4F0  blr      x8
006A5C4F4  mov      x0, x19
006A5C4F8  mov      x1, xzr
006A5C4FC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A5C500  adrp     x21, #0x959e000
006A5C504  ldrb     w8, [x21, #0x36e]
006A5C508  mov      x20, x0
006A5C50C  cbnz     w8, #0x6a5c524
006A5C510  adrp     x0, #0x8f36000
006A5C514  ldr      x0, [x0, #0x6a8]
006A5C518  bl       #0x382bd14 ; 
006A5C51C  mov      w8, #1
006A5C520  strb     w8, [x21, #0x36e]
006A5C524  adrp     x8, #0x8f36000
006A5C528  ldr      x8, [x8, #0x6a8]
006A5C52C  ldr      x2, [x8]
006A5C530  ldrb     w8, [x2, #0x53]
006A5C534  tbnz     w8, #5, #0x6a5c54c
006A5C538  mov      x0, x19
006A5C53C  str      x20, [x0, #0x38]!
006A5C540  mov      x1, x20
006A5C544  bl       #0x382bcb8 ; 
006A5C548  b        #0x6a5c55c ; 
006A5C54C  ldr      x8, [x2, #0x60]
006A5C550  mov      x0, x19
006A5C554  mov      x1, x20
006A5C558  blr      x8
006A5C55C  mov      x0, x19
006A5C560  mov      x1, xzr
006A5C564  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5C568  adrp     x21, #0x959e000
006A5C56C  ldrb     w8, [x21, #0x36f]
006A5C570  mov      w20, w0
006A5C574  cbnz     w8, #0x6a5c58c
006A5C578  adrp     x0, #0x8f36000
006A5C57C  ldr      x0, [x0, #0x6b8]
006A5C580  bl       #0x382bd14 ; 
006A5C584  mov      w8, #1
006A5C588  strb     w8, [x21, #0x36f]
006A5C58C  adrp     x8, #0x8f36000
006A5C590  ldr      x8, [x8, #0x6b8]
006A5C594  ldr      x2, [x8]
006A5C598  ldrb     w8, [x2, #0x53]
006A5C59C  tbnz     w8, #5, #0x6a5c5a8
006A5C5A0  str      w20, [x19, #0x40]
006A5C5A4  b        #0x6a5c5b8 ; 
006A5C5A8  ldr      x8, [x2, #0x60]
006A5C5AC  mov      x0, x19
006A5C5B0  mov      w1, w20
006A5C5B4  blr      x8
006A5C5B8  mov      x0, x19
006A5C5BC  mov      x1, xzr
006A5C5C0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A5C5C4  adrp     x21, #0x959e000
006A5C5C8  ldrb     w8, [x21, #0x370]
006A5C5CC  mov      x20, x0
006A5C5D0  cbnz     w8, #0x6a5c5e8
006A5C5D4  adrp     x0, #0x8f36000
006A5C5D8  ldr      x0, [x0, #0x6c8]
006A5C5DC  bl       #0x382bd14 ; 
006A5C5E0  mov      w8, #1
006A5C5E4  strb     w8, [x21, #0x370]
006A5C5E8  adrp     x8, #0x8f36000
006A5C5EC  ldr      x8, [x8, #0x6c8]
006A5C5F0  ldr      x2, [x8]
006A5C5F4  ldrb     w8, [x2, #0x53]
006A5C5F8  tbnz     w8, #5, #0x6a5c610
006A5C5FC  mov      x0, x19
006A5C600  str      x20, [x0, #0x48]!
006A5C604  mov      x1, x20
006A5C608  bl       #0x382bcb8 ; 
006A5C60C  b        #0x6a5c620 ; 
006A5C610  ldr      x8, [x2, #0x60]
006A5C614  mov      x0, x19
006A5C618  mov      x1, x20
006A5C61C  blr      x8
006A5C620  mov      x0, x19
006A5C624  mov      x1, xzr
006A5C628  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5C62C  adrp     x21, #0x959e000
006A5C630  ldrb     w8, [x21, #0x371]
006A5C634  mov      w20, w0
006A5C638  cbnz     w8, #0x6a5c650
006A5C63C  adrp     x0, #0x8f36000
006A5C640  ldr      x0, [x0, #0x6d8]
006A5C644  bl       #0x382bd14 ; 
006A5C648  mov      w8, #1
006A5C64C  strb     w8, [x21, #0x371]
006A5C650  adrp     x8, #0x8f36000
006A5C654  ldr      x8, [x8, #0x6d8]
006A5C658  ldr      x2, [x8]
006A5C65C  ldrb     w8, [x2, #0x53]
006A5C660  tbnz     w8, #5, #0x6a5c66c
006A5C664  str      w20, [x19, #0x50]
006A5C668  b        #0x6a5c67c ; 
006A5C66C  ldr      x8, [x2, #0x60]
006A5C670  mov      x0, x19
006A5C674  mov      w1, w20
006A5C678  blr      x8
006A5C67C  mov      x0, x19
006A5C680  mov      x1, xzr
006A5C684  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A5C688  adrp     x21, #0x959e000
006A5C68C  ldrb     w8, [x21, #0x372]
006A5C690  mov      x20, x0
006A5C694  cbnz     w8, #0x6a5c6ac
006A5C698  adrp     x0, #0x8f36000
006A5C69C  ldr      x0, [x0, #0x6e8]
006A5C6A0  bl       #0x382bd14 ; 
006A5C6A4  mov      w8, #1
006A5C6A8  strb     w8, [x21, #0x372]
006A5C6AC  adrp     x8, #0x8f36000
006A5C6B0  ldr      x8, [x8, #0x6e8]
006A5C6B4  ldr      x2, [x8]
006A5C6B8  ldrb     w8, [x2, #0x53]
006A5C6BC  tbnz     w8, #5, #0x6a5c6d4
006A5C6C0  str      x20, [x19, #0x58]!
006A5C6C4  mov      x0, x19
006A5C6C8  mov      x1, x20
006A5C6CC  bl       #0x382bcb8 ; 
006A5C6D0  b        #0x6a5c6e4 ; 
006A5C6D4  ldr      x8, [x2, #0x60]
006A5C6D8  mov      x0, x19
006A5C6DC  mov      x1, x20
006A5C6E0  blr      x8
006A5C6E4  ldp      x20, x19, [sp, #0x10]
006A5C6E8  mov      w0, #1
006A5C6EC  ldp      x30, x21, [sp], #0x20
006A5C6F0  ret      

