; LocalModels.Bean.StateBar_bar$$readImpl
; RVA 0x6B0F5C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B0F5C4  stp      x30, x21, [sp, #-0x20]!
006B0F5C8  stp      x20, x19, [sp, #0x10]
006B0F5CC  adrp     x20, #0x959f000
006B0F5D0  adrp     x21, #0x8f3e000
006B0F5D4  ldrb     w8, [x20, #0x519]
006B0F5D8  ldr      x21, [x21, #0xb68]
006B0F5DC  mov      x19, x0
006B0F5E0  tbnz     w8, #0, #0x6b0f5f8
006B0F5E4  adrp     x0, #0x8f3e000
006B0F5E8  ldr      x0, [x0, #0xb68]
006B0F5EC  bl       #0x382bd14 ; 
006B0F5F0  mov      w8, #1
006B0F5F4  strb     w8, [x20, #0x519]
006B0F5F8  ldr      x1, [x21]
006B0F5FC  ldrb     w8, [x1, #0x53]
006B0F600  tbnz     w8, #5, #0x6b0f650
006B0F604  mov      x0, x19
006B0F608  mov      x1, xzr
006B0F60C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0F610  adrp     x21, #0x959f000
006B0F614  ldrb     w8, [x21, #0x99b]
006B0F618  mov      w20, w0
006B0F61C  cbnz     w8, #0x6b0f634
006B0F620  adrp     x0, #0x8f3e000
006B0F624  ldr      x0, [x0, #0xb40]
006B0F628  bl       #0x382bd14 ; 
006B0F62C  mov      w8, #1
006B0F630  strb     w8, [x21, #0x99b]
006B0F634  adrp     x8, #0x8f3e000
006B0F638  ldr      x8, [x8, #0xb40]
006B0F63C  ldr      x2, [x8]
006B0F640  ldrb     w8, [x2, #0x53]
006B0F644  tbnz     w8, #5, #0x6b0f664
006B0F648  str      w20, [x19, #0x20]
006B0F64C  b        #0x6b0f674 ; 
006B0F650  ldr      x2, [x1, #0x60]
006B0F654  mov      x0, x19
006B0F658  ldp      x20, x19, [sp, #0x10]
006B0F65C  ldp      x30, x21, [sp], #0x20
006B0F660  br       x2
006B0F664  ldr      x8, [x2, #0x60]
006B0F668  mov      x0, x19
006B0F66C  mov      w1, w20
006B0F670  blr      x8
006B0F674  mov      x0, x19
006B0F678  mov      x1, xzr
006B0F67C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0F680  adrp     x21, #0x959f000
006B0F684  ldrb     w8, [x21, #0x99c]
006B0F688  mov      w20, w0
006B0F68C  cbnz     w8, #0x6b0f6a4
006B0F690  adrp     x0, #0x8f3e000
006B0F694  ldr      x0, [x0, #0xb50]
006B0F698  bl       #0x382bd14 ; 
006B0F69C  mov      w8, #1
006B0F6A0  strb     w8, [x21, #0x99c]
006B0F6A4  adrp     x8, #0x8f3e000
006B0F6A8  ldr      x8, [x8, #0xb50]
006B0F6AC  ldr      x2, [x8]
006B0F6B0  ldrb     w8, [x2, #0x53]
006B0F6B4  tbnz     w8, #5, #0x6b0f6c0
006B0F6B8  str      w20, [x19, #0x24]
006B0F6BC  b        #0x6b0f6d0 ; 
006B0F6C0  ldr      x8, [x2, #0x60]
006B0F6C4  mov      x0, x19
006B0F6C8  mov      w1, w20
006B0F6CC  blr      x8
006B0F6D0  mov      x0, x19
006B0F6D4  mov      x1, xzr
006B0F6D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B0F6DC  adrp     x21, #0x959f000
006B0F6E0  ldrb     w8, [x21, #0x99d]
006B0F6E4  mov      w20, w0
006B0F6E8  cbnz     w8, #0x6b0f700
006B0F6EC  adrp     x0, #0x8f3e000
006B0F6F0  ldr      x0, [x0, #0xb60]
006B0F6F4  bl       #0x382bd14 ; 
006B0F6F8  mov      w8, #1
006B0F6FC  strb     w8, [x21, #0x99d]
006B0F700  adrp     x8, #0x8f3e000
006B0F704  ldr      x8, [x8, #0xb60]
006B0F708  ldr      x2, [x8]
006B0F70C  ldrb     w8, [x2, #0x53]
006B0F710  tbnz     w8, #5, #0x6b0f71c
006B0F714  str      w20, [x19, #0x28]
006B0F718  b        #0x6b0f72c ; 
006B0F71C  ldr      x8, [x2, #0x60]
006B0F720  mov      x0, x19
006B0F724  mov      w1, w20
006B0F728  blr      x8
006B0F72C  ldp      x20, x19, [sp, #0x10]
006B0F730  mov      w0, #1
006B0F734  ldp      x30, x21, [sp], #0x20
006B0F738  ret      

