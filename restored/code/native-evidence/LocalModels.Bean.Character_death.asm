; LocalModels.Bean.Character_death$$readImpl
; RVA 0x68BE82C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068BE82C  stp      x30, x21, [sp, #-0x20]!
0068BE830  stp      x20, x19, [sp, #0x10]
0068BE834  adrp     x20, #0x959c000
0068BE838  adrp     x21, #0x8f27000
0068BE83C  ldrb     w8, [x20, #0x1d7]
0068BE840  ldr      x21, [x21, #0xa18]
0068BE844  mov      x19, x0
0068BE848  tbnz     w8, #0, #0x68be860
0068BE84C  adrp     x0, #0x8f27000
0068BE850  ldr      x0, [x0, #0xa18]
0068BE854  bl       #0x382bd14 ; 
0068BE858  mov      w8, #1
0068BE85C  strb     w8, [x20, #0x1d7]
0068BE860  ldr      x1, [x21]
0068BE864  ldrb     w8, [x1, #0x53]
0068BE868  tbnz     w8, #5, #0x68be8b8
0068BE86C  mov      x0, x19
0068BE870  mov      x1, xzr
0068BE874  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BE878  adrp     x21, #0x959c000
0068BE87C  ldrb     w8, [x21, #0x68a]
0068BE880  mov      w20, w0
0068BE884  cbnz     w8, #0x68be89c
0068BE888  adrp     x0, #0x8f27000
0068BE88C  ldr      x0, [x0, #0xa08]
0068BE890  bl       #0x382bd14 ; 
0068BE894  mov      w8, #1
0068BE898  strb     w8, [x21, #0x68a]
0068BE89C  adrp     x8, #0x8f27000
0068BE8A0  ldr      x8, [x8, #0xa08]
0068BE8A4  ldr      x2, [x8]
0068BE8A8  ldrb     w8, [x2, #0x53]
0068BE8AC  tbnz     w8, #5, #0x68be8cc
0068BE8B0  str      w20, [x19, #0x20]
0068BE8B4  b        #0x68be8dc ; 
0068BE8B8  ldr      x2, [x1, #0x60]
0068BE8BC  mov      x0, x19
0068BE8C0  ldp      x20, x19, [sp, #0x10]
0068BE8C4  ldp      x30, x21, [sp], #0x20
0068BE8C8  br       x2
0068BE8CC  ldr      x8, [x2, #0x60]
0068BE8D0  mov      x0, x19
0068BE8D4  mov      w1, w20
0068BE8D8  blr      x8
0068BE8DC  mov      x0, x19
0068BE8E0  mov      x1, xzr
0068BE8E4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068BE8E8  adrp     x21, #0x959c000
0068BE8EC  ldrb     w8, [x21, #0x68b]
0068BE8F0  mov      x20, x0
0068BE8F4  cbnz     w8, #0x68be90c
0068BE8F8  adrp     x0, #0x8f27000
0068BE8FC  ldr      x0, [x0, #0xa10]
0068BE900  bl       #0x382bd14 ; 
0068BE904  mov      w8, #1
0068BE908  strb     w8, [x21, #0x68b]
0068BE90C  adrp     x8, #0x8f27000
0068BE910  ldr      x8, [x8, #0xa10]
0068BE914  ldr      x2, [x8]
0068BE918  ldrb     w8, [x2, #0x53]
0068BE91C  tbnz     w8, #5, #0x68be934
0068BE920  str      x20, [x19, #0x28]!
0068BE924  mov      x0, x19
0068BE928  mov      x1, x20
0068BE92C  bl       #0x382bcb8 ; 
0068BE930  b        #0x68be944 ; 
0068BE934  ldr      x8, [x2, #0x60]
0068BE938  mov      x0, x19
0068BE93C  mov      x1, x20
0068BE940  blr      x8
0068BE944  ldp      x20, x19, [sp, #0x10]
0068BE948  mov      w0, #1
0068BE94C  ldp      x30, x21, [sp], #0x20
0068BE950  ret      

