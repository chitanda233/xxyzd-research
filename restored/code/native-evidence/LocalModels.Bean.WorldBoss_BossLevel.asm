; LocalModels.Bean.WorldBoss_BossLevel$$readImpl
; RVA 0x6B229B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B229B0  stp      x30, x21, [sp, #-0x20]!
006B229B4  stp      x20, x19, [sp, #0x10]
006B229B8  adrp     x20, #0x959f000
006B229BC  adrp     x21, #0x8f3f000
006B229C0  ldrb     w8, [x20, #0x717]
006B229C4  ldr      x21, [x21, #0x938]
006B229C8  mov      x19, x0
006B229CC  tbnz     w8, #0, #0x6b229e4
006B229D0  adrp     x0, #0x8f3f000
006B229D4  ldr      x0, [x0, #0x938]
006B229D8  bl       #0x382bd14 ; 
006B229DC  mov      w8, #1
006B229E0  strb     w8, [x20, #0x717]
006B229E4  ldr      x1, [x21]
006B229E8  ldrb     w8, [x1, #0x53]
006B229EC  tbnz     w8, #5, #0x6b22a3c
006B229F0  mov      x0, x19
006B229F4  mov      x1, xzr
006B229F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B229FC  adrp     x21, #0x959f000
006B22A00  ldrb     w8, [x21, #0xa70]
006B22A04  mov      w20, w0
006B22A08  cbnz     w8, #0x6b22a20
006B22A0C  adrp     x0, #0x8f3f000
006B22A10  ldr      x0, [x0, #0x900]
006B22A14  bl       #0x382bd14 ; 
006B22A18  mov      w8, #1
006B22A1C  strb     w8, [x21, #0xa70]
006B22A20  adrp     x8, #0x8f3f000
006B22A24  ldr      x8, [x8, #0x900]
006B22A28  ldr      x2, [x8]
006B22A2C  ldrb     w8, [x2, #0x53]
006B22A30  tbnz     w8, #5, #0x6b22a50
006B22A34  str      w20, [x19, #0x20]
006B22A38  b        #0x6b22a60 ; 
006B22A3C  ldr      x2, [x1, #0x60]
006B22A40  mov      x0, x19
006B22A44  ldp      x20, x19, [sp, #0x10]
006B22A48  ldp      x30, x21, [sp], #0x20
006B22A4C  br       x2
006B22A50  ldr      x8, [x2, #0x60]
006B22A54  mov      x0, x19
006B22A58  mov      w1, w20
006B22A5C  blr      x8
006B22A60  mov      x0, x19
006B22A64  mov      x1, xzr
006B22A68  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B22A6C  adrp     x21, #0x959f000
006B22A70  ldrb     w8, [x21, #0xa71]
006B22A74  mov      x20, x0
006B22A78  cbnz     w8, #0x6b22a90
006B22A7C  adrp     x0, #0x8f3f000
006B22A80  ldr      x0, [x0, #0x910]
006B22A84  bl       #0x382bd14 ; 
006B22A88  mov      w8, #1
006B22A8C  strb     w8, [x21, #0xa71]
006B22A90  adrp     x8, #0x8f3f000
006B22A94  ldr      x8, [x8, #0x910]
006B22A98  ldr      x2, [x8]
006B22A9C  ldrb     w8, [x2, #0x53]
006B22AA0  tbnz     w8, #5, #0x6b22ab8
006B22AA4  mov      x0, x19
006B22AA8  str      x20, [x0, #0x28]!
006B22AAC  mov      x1, x20
006B22AB0  bl       #0x382bcb8 ; 
006B22AB4  b        #0x6b22ac8 ; 
006B22AB8  ldr      x8, [x2, #0x60]
006B22ABC  mov      x0, x19
006B22AC0  mov      x1, x20
006B22AC4  blr      x8
006B22AC8  mov      x0, x19
006B22ACC  mov      x1, xzr
006B22AD0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B22AD4  adrp     x21, #0x959f000
006B22AD8  ldrb     w8, [x21, #0xa72]
006B22ADC  mov      x20, x0
006B22AE0  cbnz     w8, #0x6b22af8
006B22AE4  adrp     x0, #0x8f3f000
006B22AE8  ldr      x0, [x0, #0x920]
006B22AEC  bl       #0x382bd14 ; 
006B22AF0  mov      w8, #1
006B22AF4  strb     w8, [x21, #0xa72]
006B22AF8  adrp     x8, #0x8f3f000
006B22AFC  ldr      x8, [x8, #0x920]
006B22B00  ldr      x2, [x8]
006B22B04  ldrb     w8, [x2, #0x53]
006B22B08  tbnz     w8, #5, #0x6b22b20
006B22B0C  mov      x0, x19
006B22B10  str      x20, [x0, #0x30]!
006B22B14  mov      x1, x20
006B22B18  bl       #0x382bcb8 ; 
006B22B1C  b        #0x6b22b30 ; 
006B22B20  ldr      x8, [x2, #0x60]
006B22B24  mov      x0, x19
006B22B28  mov      x1, x20
006B22B2C  blr      x8
006B22B30  mov      x0, x19
006B22B34  mov      x1, xzr
006B22B38  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B22B3C  adrp     x21, #0x959f000
006B22B40  ldrb     w8, [x21, #0xa73]
006B22B44  mov      x20, x0
006B22B48  cbnz     w8, #0x6b22b60
006B22B4C  adrp     x0, #0x8f3f000
006B22B50  ldr      x0, [x0, #0x930]
006B22B54  bl       #0x382bd14 ; 
006B22B58  mov      w8, #1
006B22B5C  strb     w8, [x21, #0xa73]
006B22B60  adrp     x8, #0x8f3f000
006B22B64  ldr      x8, [x8, #0x930]
006B22B68  ldr      x2, [x8]
006B22B6C  ldrb     w8, [x2, #0x53]
006B22B70  tbnz     w8, #5, #0x6b22b88
006B22B74  str      x20, [x19, #0x38]!
006B22B78  mov      x0, x19
006B22B7C  mov      x1, x20
006B22B80  bl       #0x382bcb8 ; 
006B22B84  b        #0x6b22b98 ; 
006B22B88  ldr      x8, [x2, #0x60]
006B22B8C  mov      x0, x19
006B22B90  mov      x1, x20
006B22B94  blr      x8
006B22B98  ldp      x20, x19, [sp, #0x10]
006B22B9C  mov      w0, #1
006B22BA0  ldp      x30, x21, [sp], #0x20
006B22BA4  ret      

