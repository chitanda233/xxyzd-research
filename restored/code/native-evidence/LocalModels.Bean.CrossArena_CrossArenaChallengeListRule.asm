; LocalModels.Bean.CrossArena_CrossArenaChallengeListRule$$readImpl
; RVA 0x6A52EEC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A52EEC  stp      x30, x21, [sp, #-0x20]!
006A52EF0  stp      x20, x19, [sp, #0x10]
006A52EF4  adrp     x20, #0x959d000
006A52EF8  adrp     x21, #0x8f35000
006A52EFC  ldrb     w8, [x20, #0xa92]
006A52F00  ldr      x21, [x21, #0xfa8]
006A52F04  mov      x19, x0
006A52F08  tbnz     w8, #0, #0x6a52f20
006A52F0C  adrp     x0, #0x8f35000
006A52F10  ldr      x0, [x0, #0xfa8]
006A52F14  bl       #0x382bd14 ; 
006A52F18  mov      w8, #1
006A52F1C  strb     w8, [x20, #0xa92]
006A52F20  ldr      x1, [x21]
006A52F24  ldrb     w8, [x1, #0x53]
006A52F28  tbnz     w8, #5, #0x6a52f78
006A52F2C  mov      x0, x19
006A52F30  mov      x1, xzr
006A52F34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A52F38  adrp     x21, #0x959e000
006A52F3C  ldrb     w8, [x21, #0x307]
006A52F40  mov      w20, w0
006A52F44  cbnz     w8, #0x6a52f5c
006A52F48  adrp     x0, #0x8f35000
006A52F4C  ldr      x0, [x0, #0xf60]
006A52F50  bl       #0x382bd14 ; 
006A52F54  mov      w8, #1
006A52F58  strb     w8, [x21, #0x307]
006A52F5C  adrp     x8, #0x8f35000
006A52F60  ldr      x8, [x8, #0xf60]
006A52F64  ldr      x2, [x8]
006A52F68  ldrb     w8, [x2, #0x53]
006A52F6C  tbnz     w8, #5, #0x6a52f8c
006A52F70  str      w20, [x19, #0x20]
006A52F74  b        #0x6a52f9c ; 
006A52F78  ldr      x2, [x1, #0x60]
006A52F7C  mov      x0, x19
006A52F80  ldp      x20, x19, [sp, #0x10]
006A52F84  ldp      x30, x21, [sp], #0x20
006A52F88  br       x2
006A52F8C  ldr      x8, [x2, #0x60]
006A52F90  mov      x0, x19
006A52F94  mov      w1, w20
006A52F98  blr      x8
006A52F9C  mov      x0, x19
006A52FA0  mov      x1, xzr
006A52FA4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A52FA8  adrp     x21, #0x959e000
006A52FAC  ldrb     w8, [x21, #0x308]
006A52FB0  mov      w20, w0
006A52FB4  cbnz     w8, #0x6a52fcc
006A52FB8  adrp     x0, #0x8f35000
006A52FBC  ldr      x0, [x0, #0xf70]
006A52FC0  bl       #0x382bd14 ; 
006A52FC4  mov      w8, #1
006A52FC8  strb     w8, [x21, #0x308]
006A52FCC  adrp     x8, #0x8f35000
006A52FD0  ldr      x8, [x8, #0xf70]
006A52FD4  ldr      x2, [x8]
006A52FD8  ldrb     w8, [x2, #0x53]
006A52FDC  tbnz     w8, #5, #0x6a52fe8
006A52FE0  str      w20, [x19, #0x24]
006A52FE4  b        #0x6a52ff8 ; 
006A52FE8  ldr      x8, [x2, #0x60]
006A52FEC  mov      x0, x19
006A52FF0  mov      w1, w20
006A52FF4  blr      x8
006A52FF8  mov      x0, x19
006A52FFC  mov      x1, xzr
006A53000  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A53004  adrp     x21, #0x959e000
006A53008  ldrb     w8, [x21, #0x309]
006A5300C  mov      w20, w0
006A53010  cbnz     w8, #0x6a53028
006A53014  adrp     x0, #0x8f35000
006A53018  ldr      x0, [x0, #0xf80]
006A5301C  bl       #0x382bd14 ; 
006A53020  mov      w8, #1
006A53024  strb     w8, [x21, #0x309]
006A53028  adrp     x8, #0x8f35000
006A5302C  ldr      x8, [x8, #0xf80]
006A53030  ldr      x2, [x8]
006A53034  ldrb     w8, [x2, #0x53]
006A53038  tbnz     w8, #5, #0x6a53044
006A5303C  str      w20, [x19, #0x28]
006A53040  b        #0x6a53054 ; 
006A53044  ldr      x8, [x2, #0x60]
006A53048  mov      x0, x19
006A5304C  mov      w1, w20
006A53050  blr      x8
006A53054  mov      x0, x19
006A53058  mov      x1, xzr
006A5305C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A53060  adrp     x21, #0x959e000
006A53064  ldrb     w8, [x21, #0x30a]
006A53068  mov      w20, w0
006A5306C  cbnz     w8, #0x6a53084
006A53070  adrp     x0, #0x8f35000
006A53074  ldr      x0, [x0, #0xf90]
006A53078  bl       #0x382bd14 ; 
006A5307C  mov      w8, #1
006A53080  strb     w8, [x21, #0x30a]
006A53084  adrp     x8, #0x8f35000
006A53088  ldr      x8, [x8, #0xf90]
006A5308C  ldr      x2, [x8]
006A53090  ldrb     w8, [x2, #0x53]
006A53094  tbnz     w8, #5, #0x6a530a0
006A53098  str      w20, [x19, #0x2c]
006A5309C  b        #0x6a530b0 ; 
006A530A0  ldr      x8, [x2, #0x60]
006A530A4  mov      x0, x19
006A530A8  mov      w1, w20
006A530AC  blr      x8
006A530B0  mov      x0, x19
006A530B4  mov      x1, xzr
006A530B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A530BC  adrp     x21, #0x959e000
006A530C0  ldrb     w8, [x21, #0x30b]
006A530C4  mov      w20, w0
006A530C8  cbnz     w8, #0x6a530e0
006A530CC  adrp     x0, #0x8f35000
006A530D0  ldr      x0, [x0, #0xfa0]
006A530D4  bl       #0x382bd14 ; 
006A530D8  mov      w8, #1
006A530DC  strb     w8, [x21, #0x30b]
006A530E0  adrp     x8, #0x8f35000
006A530E4  ldr      x8, [x8, #0xfa0]
006A530E8  ldr      x2, [x8]
006A530EC  ldrb     w8, [x2, #0x53]
006A530F0  tbnz     w8, #5, #0x6a530fc
006A530F4  str      w20, [x19, #0x30]
006A530F8  b        #0x6a5310c ; 
006A530FC  ldr      x8, [x2, #0x60]
006A53100  mov      x0, x19
006A53104  mov      w1, w20
006A53108  blr      x8
006A5310C  ldp      x20, x19, [sp, #0x10]
006A53110  mov      w0, #1
006A53114  ldp      x30, x21, [sp], #0x20
006A53118  ret      

