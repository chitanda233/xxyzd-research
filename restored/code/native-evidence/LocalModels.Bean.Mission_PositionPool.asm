; LocalModels.Bean.Mission_PositionPool$$readImpl
; RVA 0x6AC2DAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC2DAC  stp      x30, x21, [sp, #-0x20]!
006AC2DB0  stp      x20, x19, [sp, #0x10]
006AC2DB4  adrp     x20, #0x959e000
006AC2DB8  adrp     x21, #0x8f3b000
006AC2DBC  ldrb     w8, [x20, #0x9a7]
006AC2DC0  ldr      x21, [x21, #0x3f0]
006AC2DC4  mov      x19, x0
006AC2DC8  tbnz     w8, #0, #0x6ac2de0
006AC2DCC  adrp     x0, #0x8f3b000
006AC2DD0  ldr      x0, [x0, #0x3f0]
006AC2DD4  bl       #0x382bd14 ; 
006AC2DD8  mov      w8, #1
006AC2DDC  strb     w8, [x20, #0x9a7]
006AC2DE0  ldr      x1, [x21]
006AC2DE4  ldrb     w8, [x1, #0x53]
006AC2DE8  tbnz     w8, #5, #0x6ac2e38
006AC2DEC  mov      x0, x19
006AC2DF0  mov      x1, xzr
006AC2DF4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC2DF8  adrp     x21, #0x959f000
006AC2DFC  ldrb     w8, [x21, #0x4b]
006AC2E00  mov      w20, w0
006AC2E04  cbnz     w8, #0x6ac2e1c
006AC2E08  adrp     x0, #0x8f3b000
006AC2E0C  ldr      x0, [x0, #0x3d8]
006AC2E10  bl       #0x382bd14 ; 
006AC2E14  mov      w8, #1
006AC2E18  strb     w8, [x21, #0x4b]
006AC2E1C  adrp     x8, #0x8f3b000
006AC2E20  ldr      x8, [x8, #0x3d8]
006AC2E24  ldr      x2, [x8]
006AC2E28  ldrb     w8, [x2, #0x53]
006AC2E2C  tbnz     w8, #5, #0x6ac2e4c
006AC2E30  str      w20, [x19, #0x20]
006AC2E34  b        #0x6ac2e5c ; 
006AC2E38  ldr      x2, [x1, #0x60]
006AC2E3C  mov      x0, x19
006AC2E40  ldp      x20, x19, [sp, #0x10]
006AC2E44  ldp      x30, x21, [sp], #0x20
006AC2E48  br       x2
006AC2E4C  ldr      x8, [x2, #0x60]
006AC2E50  mov      x0, x19
006AC2E54  mov      w1, w20
006AC2E58  blr      x8
006AC2E5C  mov      x0, x19
006AC2E60  mov      x1, xzr
006AC2E64  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
006AC2E68  adrp     x21, #0x959f000
006AC2E6C  ldrb     w8, [x21, #0x4c]
006AC2E70  mov      x20, x0
006AC2E74  cbnz     w8, #0x6ac2e8c
006AC2E78  adrp     x0, #0x8f3b000
006AC2E7C  ldr      x0, [x0, #0x3e8]
006AC2E80  bl       #0x382bd14 ; 
006AC2E84  mov      w8, #1
006AC2E88  strb     w8, [x21, #0x4c]
006AC2E8C  adrp     x8, #0x8f3b000
006AC2E90  ldr      x8, [x8, #0x3e8]
006AC2E94  ldr      x2, [x8]
006AC2E98  ldrb     w8, [x2, #0x53]
006AC2E9C  tbnz     w8, #5, #0x6ac2eb4
006AC2EA0  str      x20, [x19, #0x28]!
006AC2EA4  mov      x0, x19
006AC2EA8  mov      x1, x20
006AC2EAC  bl       #0x382bcb8 ; 
006AC2EB0  b        #0x6ac2ec4 ; 
006AC2EB4  ldr      x8, [x2, #0x60]
006AC2EB8  mov      x0, x19
006AC2EBC  mov      x1, x20
006AC2EC0  blr      x8
006AC2EC4  ldp      x20, x19, [sp, #0x10]
006AC2EC8  mov      w0, #1
006AC2ECC  ldp      x30, x21, [sp], #0x20
006AC2ED0  ret      

