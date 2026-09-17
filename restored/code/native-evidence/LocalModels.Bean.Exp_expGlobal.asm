; LocalModels.Bean.Exp_expGlobal$$readImpl
; RVA 0x6A7C3DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A7C3DC  stp      x30, x21, [sp, #-0x20]!
006A7C3E0  stp      x20, x19, [sp, #0x10]
006A7C3E4  adrp     x20, #0x959d000
006A7C3E8  adrp     x21, #0x8f37000
006A7C3EC  ldrb     w8, [x20, #0xed4]
006A7C3F0  ldr      x21, [x21, #0xec0]
006A7C3F4  mov      x19, x0
006A7C3F8  tbnz     w8, #0, #0x6a7c410
006A7C3FC  adrp     x0, #0x8f37000
006A7C400  ldr      x0, [x0, #0xec0]
006A7C404  bl       #0x382bd14 ; 
006A7C408  mov      w8, #1
006A7C40C  strb     w8, [x20, #0xed4]
006A7C410  ldr      x1, [x21]
006A7C414  ldrb     w8, [x1, #0x53]
006A7C418  tbnz     w8, #5, #0x6a7c468
006A7C41C  mov      x0, x19
006A7C420  mov      x1, xzr
006A7C424  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7C428  adrp     x21, #0x959e000
006A7C42C  ldrb     w8, [x21, #0x4d3]
006A7C430  mov      w20, w0
006A7C434  cbnz     w8, #0x6a7c44c
006A7C438  adrp     x0, #0x8f37000
006A7C43C  ldr      x0, [x0, #0xe98]
006A7C440  bl       #0x382bd14 ; 
006A7C444  mov      w8, #1
006A7C448  strb     w8, [x21, #0x4d3]
006A7C44C  adrp     x8, #0x8f37000
006A7C450  ldr      x8, [x8, #0xe98]
006A7C454  ldr      x2, [x8]
006A7C458  ldrb     w8, [x2, #0x53]
006A7C45C  tbnz     w8, #5, #0x6a7c47c
006A7C460  str      w20, [x19, #0x20]
006A7C464  b        #0x6a7c48c ; 
006A7C468  ldr      x2, [x1, #0x60]
006A7C46C  mov      x0, x19
006A7C470  ldp      x20, x19, [sp, #0x10]
006A7C474  ldp      x30, x21, [sp], #0x20
006A7C478  br       x2
006A7C47C  ldr      x8, [x2, #0x60]
006A7C480  mov      x0, x19
006A7C484  mov      w1, w20
006A7C488  blr      x8
006A7C48C  mov      x0, x19
006A7C490  mov      x1, xzr
006A7C494  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7C498  adrp     x21, #0x959e000
006A7C49C  ldrb     w8, [x21, #0x4d4]
006A7C4A0  mov      w20, w0
006A7C4A4  cbnz     w8, #0x6a7c4bc
006A7C4A8  adrp     x0, #0x8f37000
006A7C4AC  ldr      x0, [x0, #0xea8]
006A7C4B0  bl       #0x382bd14 ; 
006A7C4B4  mov      w8, #1
006A7C4B8  strb     w8, [x21, #0x4d4]
006A7C4BC  adrp     x8, #0x8f37000
006A7C4C0  ldr      x8, [x8, #0xea8]
006A7C4C4  ldr      x2, [x8]
006A7C4C8  ldrb     w8, [x2, #0x53]
006A7C4CC  tbnz     w8, #5, #0x6a7c4d8
006A7C4D0  str      w20, [x19, #0x24]
006A7C4D4  b        #0x6a7c4e8 ; 
006A7C4D8  ldr      x8, [x2, #0x60]
006A7C4DC  mov      x0, x19
006A7C4E0  mov      w1, w20
006A7C4E4  blr      x8
006A7C4E8  mov      x0, x19
006A7C4EC  mov      x1, xzr
006A7C4F0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A7C4F4  adrp     x21, #0x959e000
006A7C4F8  ldrb     w8, [x21, #0x4d5]
006A7C4FC  mov      x20, x0
006A7C500  cbnz     w8, #0x6a7c518
006A7C504  adrp     x0, #0x8f37000
006A7C508  ldr      x0, [x0, #0xeb8]
006A7C50C  bl       #0x382bd14 ; 
006A7C510  mov      w8, #1
006A7C514  strb     w8, [x21, #0x4d5]
006A7C518  adrp     x8, #0x8f37000
006A7C51C  ldr      x8, [x8, #0xeb8]
006A7C520  ldr      x2, [x8]
006A7C524  ldrb     w8, [x2, #0x53]
006A7C528  tbnz     w8, #5, #0x6a7c540
006A7C52C  str      x20, [x19, #0x28]!
006A7C530  mov      x0, x19
006A7C534  mov      x1, x20
006A7C538  bl       #0x382bcb8 ; 
006A7C53C  b        #0x6a7c550 ; 
006A7C540  ldr      x8, [x2, #0x60]
006A7C544  mov      x0, x19
006A7C548  mov      x1, x20
006A7C54C  blr      x8
006A7C550  ldp      x20, x19, [sp, #0x10]
006A7C554  mov      w0, #1
006A7C558  ldp      x30, x21, [sp], #0x20
006A7C55C  ret      

