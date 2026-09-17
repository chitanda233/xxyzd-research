; LocalModels.Bean.MapItemPool_model$$readImpl
; RVA 0x6AB3E88; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AB3E88  stp      x30, x21, [sp, #-0x20]!
006AB3E8C  stp      x20, x19, [sp, #0x10]
006AB3E90  adrp     x20, #0x959e000
006AB3E94  adrp     x21, #0x8f3a000
006AB3E98  ldrb     w8, [x20, #0x821]
006AB3E9C  ldr      x21, [x21, #0x8f0]
006AB3EA0  mov      x19, x0
006AB3EA4  tbnz     w8, #0, #0x6ab3ebc
006AB3EA8  adrp     x0, #0x8f3a000
006AB3EAC  ldr      x0, [x0, #0x8f0]
006AB3EB0  bl       #0x382bd14 ; 
006AB3EB4  mov      w8, #1
006AB3EB8  strb     w8, [x20, #0x821]
006AB3EBC  ldr      x1, [x21]
006AB3EC0  ldrb     w8, [x1, #0x53]
006AB3EC4  tbnz     w8, #5, #0x6ab3f14
006AB3EC8  mov      x0, x19
006AB3ECC  mov      x1, xzr
006AB3ED0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB3ED4  adrp     x21, #0x959e000
006AB3ED8  ldrb     w8, [x21, #0xf99]
006AB3EDC  mov      w20, w0
006AB3EE0  cbnz     w8, #0x6ab3ef8
006AB3EE4  adrp     x0, #0x8f3a000
006AB3EE8  ldr      x0, [x0, #0x8c8]
006AB3EEC  bl       #0x382bd14 ; 
006AB3EF0  mov      w8, #1
006AB3EF4  strb     w8, [x21, #0xf99]
006AB3EF8  adrp     x8, #0x8f3a000
006AB3EFC  ldr      x8, [x8, #0x8c8]
006AB3F00  ldr      x2, [x8]
006AB3F04  ldrb     w8, [x2, #0x53]
006AB3F08  tbnz     w8, #5, #0x6ab3f28
006AB3F0C  str      w20, [x19, #0x20]
006AB3F10  b        #0x6ab3f38 ; 
006AB3F14  ldr      x2, [x1, #0x60]
006AB3F18  mov      x0, x19
006AB3F1C  ldp      x20, x19, [sp, #0x10]
006AB3F20  ldp      x30, x21, [sp], #0x20
006AB3F24  br       x2
006AB3F28  ldr      x8, [x2, #0x60]
006AB3F2C  mov      x0, x19
006AB3F30  mov      w1, w20
006AB3F34  blr      x8
006AB3F38  mov      x0, x19
006AB3F3C  mov      x1, xzr
006AB3F40  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB3F44  adrp     x21, #0x959e000
006AB3F48  ldrb     w8, [x21, #0xf9a]
006AB3F4C  mov      x20, x0
006AB3F50  cbnz     w8, #0x6ab3f68
006AB3F54  adrp     x0, #0x8f3a000
006AB3F58  ldr      x0, [x0, #0x8d8]
006AB3F5C  bl       #0x382bd14 ; 
006AB3F60  mov      w8, #1
006AB3F64  strb     w8, [x21, #0xf9a]
006AB3F68  adrp     x8, #0x8f3a000
006AB3F6C  ldr      x8, [x8, #0x8d8]
006AB3F70  ldr      x2, [x8]
006AB3F74  ldrb     w8, [x2, #0x53]
006AB3F78  tbnz     w8, #5, #0x6ab3f90
006AB3F7C  mov      x0, x19
006AB3F80  str      x20, [x0, #0x28]!
006AB3F84  mov      x1, x20
006AB3F88  bl       #0x382bcb8 ; 
006AB3F8C  b        #0x6ab3fa0 ; 
006AB3F90  ldr      x8, [x2, #0x60]
006AB3F94  mov      x0, x19
006AB3F98  mov      x1, x20
006AB3F9C  blr      x8
006AB3FA0  mov      x0, x19
006AB3FA4  mov      x1, xzr
006AB3FA8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AB3FAC  adrp     x21, #0x959e000
006AB3FB0  ldrb     w8, [x21, #0xf9b]
006AB3FB4  mov      x20, x0
006AB3FB8  cbnz     w8, #0x6ab3fd0
006AB3FBC  adrp     x0, #0x8f3a000
006AB3FC0  ldr      x0, [x0, #0x8e8]
006AB3FC4  bl       #0x382bd14 ; 
006AB3FC8  mov      w8, #1
006AB3FCC  strb     w8, [x21, #0xf9b]
006AB3FD0  adrp     x8, #0x8f3a000
006AB3FD4  ldr      x8, [x8, #0x8e8]
006AB3FD8  ldr      x2, [x8]
006AB3FDC  ldrb     w8, [x2, #0x53]
006AB3FE0  tbnz     w8, #5, #0x6ab3ff8
006AB3FE4  str      x20, [x19, #0x30]!
006AB3FE8  mov      x0, x19
006AB3FEC  mov      x1, x20
006AB3FF0  bl       #0x382bcb8 ; 
006AB3FF4  b        #0x6ab4008 ; 
006AB3FF8  ldr      x8, [x2, #0x60]
006AB3FFC  mov      x0, x19
006AB4000  mov      x1, x20
006AB4004  blr      x8
006AB4008  ldp      x20, x19, [sp, #0x10]
006AB400C  mov      w0, #1
006AB4010  ldp      x30, x21, [sp], #0x20
006AB4014  ret      

