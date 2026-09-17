; LocalModels.Bean.HeroAI_HeroAI$$readImpl
; RVA 0x6A97E5C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A97E5C  stp      x30, x21, [sp, #-0x20]!
006A97E60  stp      x20, x19, [sp, #0x10]
006A97E64  adrp     x20, #0x959e000
006A97E68  adrp     x21, #0x8f39000
006A97E6C  ldrb     w8, [x20, #0x1ba]
006A97E70  ldr      x21, [x21, #0x3a0]
006A97E74  mov      x19, x0
006A97E78  tbnz     w8, #0, #0x6a97e90
006A97E7C  adrp     x0, #0x8f39000
006A97E80  ldr      x0, [x0, #0x3a0]
006A97E84  bl       #0x382bd14 ; 
006A97E88  mov      w8, #1
006A97E8C  strb     w8, [x20, #0x1ba]
006A97E90  ldr      x1, [x21]
006A97E94  ldrb     w8, [x1, #0x53]
006A97E98  tbnz     w8, #5, #0x6a97ee8
006A97E9C  mov      x0, x19
006A97EA0  mov      x1, xzr
006A97EA4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A97EA8  adrp     x21, #0x959e000
006A97EAC  ldrb     w8, [x21, #0x5fa]
006A97EB0  mov      w20, w0
006A97EB4  cbnz     w8, #0x6a97ecc
006A97EB8  adrp     x0, #0x8f39000
006A97EBC  ldr      x0, [x0, #0x378]
006A97EC0  bl       #0x382bd14 ; 
006A97EC4  mov      w8, #1
006A97EC8  strb     w8, [x21, #0x5fa]
006A97ECC  adrp     x8, #0x8f39000
006A97ED0  ldr      x8, [x8, #0x378]
006A97ED4  ldr      x2, [x8]
006A97ED8  ldrb     w8, [x2, #0x53]
006A97EDC  tbnz     w8, #5, #0x6a97efc
006A97EE0  str      w20, [x19, #0x20]
006A97EE4  b        #0x6a97f0c ; 
006A97EE8  ldr      x2, [x1, #0x60]
006A97EEC  mov      x0, x19
006A97EF0  ldp      x20, x19, [sp, #0x10]
006A97EF4  ldp      x30, x21, [sp], #0x20
006A97EF8  br       x2
006A97EFC  ldr      x8, [x2, #0x60]
006A97F00  mov      x0, x19
006A97F04  mov      w1, w20
006A97F08  blr      x8
006A97F0C  mov      x0, x19
006A97F10  mov      x1, xzr
006A97F14  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A97F18  adrp     x21, #0x959e000
006A97F1C  ldrb     w8, [x21, #0x5fb]
006A97F20  mov      x20, x0
006A97F24  cbnz     w8, #0x6a97f3c
006A97F28  adrp     x0, #0x8f39000
006A97F2C  ldr      x0, [x0, #0x388]
006A97F30  bl       #0x382bd14 ; 
006A97F34  mov      w8, #1
006A97F38  strb     w8, [x21, #0x5fb]
006A97F3C  adrp     x8, #0x8f39000
006A97F40  ldr      x8, [x8, #0x388]
006A97F44  ldr      x2, [x8]
006A97F48  ldrb     w8, [x2, #0x53]
006A97F4C  tbnz     w8, #5, #0x6a97f64
006A97F50  mov      x0, x19
006A97F54  str      x20, [x0, #0x28]!
006A97F58  mov      x1, x20
006A97F5C  bl       #0x382bcb8 ; 
006A97F60  b        #0x6a97f74 ; 
006A97F64  ldr      x8, [x2, #0x60]
006A97F68  mov      x0, x19
006A97F6C  mov      x1, x20
006A97F70  blr      x8
006A97F74  mov      x0, x19
006A97F78  mov      x1, xzr
006A97F7C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A97F80  adrp     x21, #0x959e000
006A97F84  ldrb     w8, [x21, #0x5fc]
006A97F88  mov      x20, x0
006A97F8C  cbnz     w8, #0x6a97fa4
006A97F90  adrp     x0, #0x8f39000
006A97F94  ldr      x0, [x0, #0x390]
006A97F98  bl       #0x382bd14 ; 
006A97F9C  mov      w8, #1
006A97FA0  strb     w8, [x21, #0x5fc]
006A97FA4  adrp     x8, #0x8f39000
006A97FA8  ldr      x8, [x8, #0x390]
006A97FAC  ldr      x2, [x8]
006A97FB0  ldrb     w8, [x2, #0x53]
006A97FB4  tbnz     w8, #5, #0x6a97fcc
006A97FB8  mov      x0, x19
006A97FBC  str      x20, [x0, #0x30]!
006A97FC0  mov      x1, x20
006A97FC4  bl       #0x382bcb8 ; 
006A97FC8  b        #0x6a97fdc ; 
006A97FCC  ldr      x8, [x2, #0x60]
006A97FD0  mov      x0, x19
006A97FD4  mov      x1, x20
006A97FD8  blr      x8
006A97FDC  mov      x0, x19
006A97FE0  mov      x1, xzr
006A97FE4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A97FE8  adrp     x21, #0x959e000
006A97FEC  ldrb     w8, [x21, #0x5fd]
006A97FF0  mov      x20, x0
006A97FF4  cbnz     w8, #0x6a9800c
006A97FF8  adrp     x0, #0x8f39000
006A97FFC  ldr      x0, [x0, #0x398]
006A98000  bl       #0x382bd14 ; 
006A98004  mov      w8, #1
006A98008  strb     w8, [x21, #0x5fd]
006A9800C  adrp     x8, #0x8f39000
006A98010  ldr      x8, [x8, #0x398]
006A98014  ldr      x2, [x8]
006A98018  ldrb     w8, [x2, #0x53]
006A9801C  tbnz     w8, #5, #0x6a98034
006A98020  str      x20, [x19, #0x38]!
006A98024  mov      x0, x19
006A98028  mov      x1, x20
006A9802C  bl       #0x382bcb8 ; 
006A98030  b        #0x6a98044 ; 
006A98034  ldr      x8, [x2, #0x60]
006A98038  mov      x0, x19
006A9803C  mov      x1, x20
006A98040  blr      x8
006A98044  ldp      x20, x19, [sp, #0x10]
006A98048  mov      w0, #1
006A9804C  ldp      x30, x21, [sp], #0x20
006A98050  ret      

