; LocalModels.Bean.SkillGroup_InitBaseGroupX$$readImpl
; RVA 0x6AF88C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF88C4  stp      x30, x21, [sp, #-0x20]!
006AF88C8  stp      x20, x19, [sp, #0x10]
006AF88CC  adrp     x20, #0x959f000
006AF88D0  adrp     x21, #0x8f3d000
006AF88D4  ldrb     w8, [x20, #0x2cc]
006AF88D8  ldr      x21, [x21, #0xc30]
006AF88DC  mov      x19, x0
006AF88E0  tbnz     w8, #0, #0x6af88f8
006AF88E4  adrp     x0, #0x8f3d000
006AF88E8  ldr      x0, [x0, #0xc30]
006AF88EC  bl       #0x382bd14 ; 
006AF88F0  mov      w8, #1
006AF88F4  strb     w8, [x20, #0x2cc]
006AF88F8  ldr      x1, [x21]
006AF88FC  ldrb     w8, [x1, #0x53]
006AF8900  tbnz     w8, #5, #0x6af8950
006AF8904  mov      x0, x19
006AF8908  mov      x1, xzr
006AF890C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF8910  adrp     x21, #0x959f000
006AF8914  ldrb     w8, [x21, #0x87d]
006AF8918  mov      w20, w0
006AF891C  cbnz     w8, #0x6af8934
006AF8920  adrp     x0, #0x8f3d000
006AF8924  ldr      x0, [x0, #0xc08]
006AF8928  bl       #0x382bd14 ; 
006AF892C  mov      w8, #1
006AF8930  strb     w8, [x21, #0x87d]
006AF8934  adrp     x8, #0x8f3d000
006AF8938  ldr      x8, [x8, #0xc08]
006AF893C  ldr      x2, [x8]
006AF8940  ldrb     w8, [x2, #0x53]
006AF8944  tbnz     w8, #5, #0x6af8964
006AF8948  str      w20, [x19, #0x20]
006AF894C  b        #0x6af8974 ; 
006AF8950  ldr      x2, [x1, #0x60]
006AF8954  mov      x0, x19
006AF8958  ldp      x20, x19, [sp, #0x10]
006AF895C  ldp      x30, x21, [sp], #0x20
006AF8960  br       x2
006AF8964  ldr      x8, [x2, #0x60]
006AF8968  mov      x0, x19
006AF896C  mov      w1, w20
006AF8970  blr      x8
006AF8974  mov      x0, x19
006AF8978  mov      x1, xzr
006AF897C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF8980  adrp     x21, #0x959f000
006AF8984  ldrb     w8, [x21, #0x87e]
006AF8988  mov      w20, w0
006AF898C  cbnz     w8, #0x6af89a4
006AF8990  adrp     x0, #0x8f3d000
006AF8994  ldr      x0, [x0, #0xc18]
006AF8998  bl       #0x382bd14 ; 
006AF899C  mov      w8, #1
006AF89A0  strb     w8, [x21, #0x87e]
006AF89A4  adrp     x8, #0x8f3d000
006AF89A8  ldr      x8, [x8, #0xc18]
006AF89AC  ldr      x2, [x8]
006AF89B0  ldrb     w8, [x2, #0x53]
006AF89B4  tbnz     w8, #5, #0x6af89c0
006AF89B8  str      w20, [x19, #0x24]
006AF89BC  b        #0x6af89d0 ; 
006AF89C0  ldr      x8, [x2, #0x60]
006AF89C4  mov      x0, x19
006AF89C8  mov      w1, w20
006AF89CC  blr      x8
006AF89D0  mov      x0, x19
006AF89D4  mov      x1, xzr
006AF89D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF89DC  adrp     x21, #0x959f000
006AF89E0  ldrb     w8, [x21, #0x87f]
006AF89E4  mov      w20, w0
006AF89E8  cbnz     w8, #0x6af8a00
006AF89EC  adrp     x0, #0x8f3d000
006AF89F0  ldr      x0, [x0, #0xc28]
006AF89F4  bl       #0x382bd14 ; 
006AF89F8  mov      w8, #1
006AF89FC  strb     w8, [x21, #0x87f]
006AF8A00  adrp     x8, #0x8f3d000
006AF8A04  ldr      x8, [x8, #0xc28]
006AF8A08  ldr      x2, [x8]
006AF8A0C  ldrb     w8, [x2, #0x53]
006AF8A10  tbnz     w8, #5, #0x6af8a1c
006AF8A14  str      w20, [x19, #0x28]
006AF8A18  b        #0x6af8a2c ; 
006AF8A1C  ldr      x8, [x2, #0x60]
006AF8A20  mov      x0, x19
006AF8A24  mov      w1, w20
006AF8A28  blr      x8
006AF8A2C  ldp      x20, x19, [sp, #0x10]
006AF8A30  mov      w0, #1
006AF8A34  ldp      x30, x21, [sp], #0x20
006AF8A38  ret      

