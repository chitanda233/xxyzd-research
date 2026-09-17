; LocalModels.Bean.Character_jelly$$readImpl
; RVA 0x68C88E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068C88E0  stp      x30, x21, [sp, #-0x20]!
0068C88E4  stp      x20, x19, [sp, #0x10]
0068C88E8  adrp     x20, #0x959c000
0068C88EC  adrp     x21, #0x8f28000
0068C88F0  ldrb     w8, [x20, #0x2db]
0068C88F4  ldr      x21, [x21, #0xc8]
0068C88F8  mov      x19, x0
0068C88FC  tbnz     w8, #0, #0x68c8914
0068C8900  adrp     x0, #0x8f28000
0068C8904  ldr      x0, [x0, #0xc8]
0068C8908  bl       #0x382bd14 ; 
0068C890C  mov      w8, #1
0068C8910  strb     w8, [x20, #0x2db]
0068C8914  ldr      x1, [x21]
0068C8918  ldrb     w8, [x1, #0x53]
0068C891C  tbnz     w8, #5, #0x68c896c
0068C8920  mov      x0, x19
0068C8924  mov      x1, xzr
0068C8928  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C892C  adrp     x21, #0x959c000
0068C8930  ldrb     w8, [x21, #0x703]
0068C8934  mov      w20, w0
0068C8938  cbnz     w8, #0x68c8950
0068C893C  adrp     x0, #0x8f28000
0068C8940  ldr      x0, [x0, #0xb0]
0068C8944  bl       #0x382bd14 ; 
0068C8948  mov      w8, #1
0068C894C  strb     w8, [x21, #0x703]
0068C8950  adrp     x8, #0x8f28000
0068C8954  ldr      x8, [x8, #0xb0]
0068C8958  ldr      x2, [x8]
0068C895C  ldrb     w8, [x2, #0x53]
0068C8960  tbnz     w8, #5, #0x68c8980
0068C8964  str      w20, [x19, #0x20]
0068C8968  b        #0x68c8990 ; 
0068C896C  ldr      x2, [x1, #0x60]
0068C8970  mov      x0, x19
0068C8974  ldp      x20, x19, [sp, #0x10]
0068C8978  ldp      x30, x21, [sp], #0x20
0068C897C  br       x2
0068C8980  ldr      x8, [x2, #0x60]
0068C8984  mov      x0, x19
0068C8988  mov      w1, w20
0068C898C  blr      x8
0068C8990  mov      x0, x19
0068C8994  mov      x1, xzr
0068C8998  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C899C  adrp     x21, #0x959c000
0068C89A0  ldrb     w8, [x21, #0x704]
0068C89A4  mov      x20, x0
0068C89A8  cbnz     w8, #0x68c89c0
0068C89AC  adrp     x0, #0x8f28000
0068C89B0  ldr      x0, [x0, #0xc0]
0068C89B4  bl       #0x382bd14 ; 
0068C89B8  mov      w8, #1
0068C89BC  strb     w8, [x21, #0x704]
0068C89C0  adrp     x8, #0x8f28000
0068C89C4  ldr      x8, [x8, #0xc0]
0068C89C8  ldr      x2, [x8]
0068C89CC  ldrb     w8, [x2, #0x53]
0068C89D0  tbnz     w8, #5, #0x68c89e8
0068C89D4  str      x20, [x19, #0x28]!
0068C89D8  mov      x0, x19
0068C89DC  mov      x1, x20
0068C89E0  bl       #0x382bcb8 ; 
0068C89E4  b        #0x68c89f8 ; 
0068C89E8  ldr      x8, [x2, #0x60]
0068C89EC  mov      x0, x19
0068C89F0  mov      x1, x20
0068C89F4  blr      x8
0068C89F8  ldp      x20, x19, [sp, #0x10]
0068C89FC  mov      w0, #1
0068C8A00  ldp      x30, x21, [sp], #0x20
0068C8A04  ret      

