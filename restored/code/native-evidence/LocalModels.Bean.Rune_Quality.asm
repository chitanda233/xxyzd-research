; LocalModels.Bean.Rune_Quality$$readImpl
; RVA 0x6AE3F04; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE3F04  stp      x30, x21, [sp, #-0x20]!
006AE3F08  stp      x20, x19, [sp, #0x10]
006AE3F0C  adrp     x20, #0x959e000
006AE3F10  adrp     x21, #0x8f3c000
006AE3F14  ldrb     w8, [x20, #0xd12]
006AE3F18  ldr      x21, [x21, #0xc68]
006AE3F1C  mov      x19, x0
006AE3F20  tbnz     w8, #0, #0x6ae3f38
006AE3F24  adrp     x0, #0x8f3c000
006AE3F28  ldr      x0, [x0, #0xc68]
006AE3F2C  bl       #0x382bd14 ; 
006AE3F30  mov      w8, #1
006AE3F34  strb     w8, [x20, #0xd12]
006AE3F38  ldr      x1, [x21]
006AE3F3C  ldrb     w8, [x1, #0x53]
006AE3F40  tbnz     w8, #5, #0x6ae3f90
006AE3F44  mov      x0, x19
006AE3F48  mov      x1, xzr
006AE3F4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE3F50  adrp     x21, #0x959f000
006AE3F54  ldrb     w8, [x21, #0x1bb]
006AE3F58  mov      w20, w0
006AE3F5C  cbnz     w8, #0x6ae3f74
006AE3F60  adrp     x0, #0x8f3c000
006AE3F64  ldr      x0, [x0, #0xc30]
006AE3F68  bl       #0x382bd14 ; 
006AE3F6C  mov      w8, #1
006AE3F70  strb     w8, [x21, #0x1bb]
006AE3F74  adrp     x8, #0x8f3c000
006AE3F78  ldr      x8, [x8, #0xc30]
006AE3F7C  ldr      x2, [x8]
006AE3F80  ldrb     w8, [x2, #0x53]
006AE3F84  tbnz     w8, #5, #0x6ae3fa4
006AE3F88  str      w20, [x19, #0x20]
006AE3F8C  b        #0x6ae3fb4 ; 
006AE3F90  ldr      x2, [x1, #0x60]
006AE3F94  mov      x0, x19
006AE3F98  ldp      x20, x19, [sp, #0x10]
006AE3F9C  ldp      x30, x21, [sp], #0x20
006AE3FA0  br       x2
006AE3FA4  ldr      x8, [x2, #0x60]
006AE3FA8  mov      x0, x19
006AE3FAC  mov      w1, w20
006AE3FB0  blr      x8
006AE3FB4  mov      x0, x19
006AE3FB8  mov      x1, xzr
006AE3FBC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE3FC0  adrp     x21, #0x959f000
006AE3FC4  ldrb     w8, [x21, #0x1bc]
006AE3FC8  mov      w20, w0
006AE3FCC  cbnz     w8, #0x6ae3fe4
006AE3FD0  adrp     x0, #0x8f3c000
006AE3FD4  ldr      x0, [x0, #0xc40]
006AE3FD8  bl       #0x382bd14 ; 
006AE3FDC  mov      w8, #1
006AE3FE0  strb     w8, [x21, #0x1bc]
006AE3FE4  adrp     x8, #0x8f3c000
006AE3FE8  ldr      x8, [x8, #0xc40]
006AE3FEC  ldr      x2, [x8]
006AE3FF0  ldrb     w8, [x2, #0x53]
006AE3FF4  tbnz     w8, #5, #0x6ae4000
006AE3FF8  str      w20, [x19, #0x24]
006AE3FFC  b        #0x6ae4010 ; 
006AE4000  ldr      x8, [x2, #0x60]
006AE4004  mov      x0, x19
006AE4008  mov      w1, w20
006AE400C  blr      x8
006AE4010  mov      x0, x19
006AE4014  mov      x1, xzr
006AE4018  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE401C  adrp     x21, #0x959f000
006AE4020  ldrb     w8, [x21, #0x1bd]
006AE4024  mov      w20, w0
006AE4028  cbnz     w8, #0x6ae4040
006AE402C  adrp     x0, #0x8f3c000
006AE4030  ldr      x0, [x0, #0xc50]
006AE4034  bl       #0x382bd14 ; 
006AE4038  mov      w8, #1
006AE403C  strb     w8, [x21, #0x1bd]
006AE4040  adrp     x8, #0x8f3c000
006AE4044  ldr      x8, [x8, #0xc50]
006AE4048  ldr      x2, [x8]
006AE404C  ldrb     w8, [x2, #0x53]
006AE4050  tbnz     w8, #5, #0x6ae405c
006AE4054  str      w20, [x19, #0x28]
006AE4058  b        #0x6ae406c ; 
006AE405C  ldr      x8, [x2, #0x60]
006AE4060  mov      x0, x19
006AE4064  mov      w1, w20
006AE4068  blr      x8
006AE406C  mov      x0, x19
006AE4070  mov      x1, xzr
006AE4074  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE4078  adrp     x21, #0x959f000
006AE407C  ldrb     w8, [x21, #0x1be]
006AE4080  mov      w20, w0
006AE4084  cbnz     w8, #0x6ae409c
006AE4088  adrp     x0, #0x8f3c000
006AE408C  ldr      x0, [x0, #0xc60]
006AE4090  bl       #0x382bd14 ; 
006AE4094  mov      w8, #1
006AE4098  strb     w8, [x21, #0x1be]
006AE409C  adrp     x8, #0x8f3c000
006AE40A0  ldr      x8, [x8, #0xc60]
006AE40A4  ldr      x2, [x8]
006AE40A8  ldrb     w8, [x2, #0x53]
006AE40AC  tbnz     w8, #5, #0x6ae40b8
006AE40B0  str      w20, [x19, #0x2c]
006AE40B4  b        #0x6ae40c8 ; 
006AE40B8  ldr      x8, [x2, #0x60]
006AE40BC  mov      x0, x19
006AE40C0  mov      w1, w20
006AE40C4  blr      x8
006AE40C8  ldp      x20, x19, [sp, #0x10]
006AE40CC  mov      w0, #1
006AE40D0  ldp      x30, x21, [sp], #0x20
006AE40D4  ret      

