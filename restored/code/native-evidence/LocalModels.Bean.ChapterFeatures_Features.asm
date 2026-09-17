; LocalModels.Bean.ChapterFeatures_Features$$readImpl
; RVA 0x68978E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068978E4  stp      x30, x21, [sp, #-0x20]!
0068978E8  stp      x20, x19, [sp, #0x10]
0068978EC  adrp     x20, #0x959b000
0068978F0  adrp     x21, #0x8f25000
0068978F4  ldrb     w8, [x20, #0xde1]
0068978F8  ldr      x21, [x21, #0xc90]
0068978FC  mov      x19, x0
006897900  tbnz     w8, #0, #0x6897918
006897904  adrp     x0, #0x8f25000
006897908  ldr      x0, [x0, #0xc90]
00689790C  bl       #0x382bd14 ; 
006897910  mov      w8, #1
006897914  strb     w8, [x20, #0xde1]
006897918  ldr      x1, [x21]
00689791C  ldrb     w8, [x1, #0x53]
006897920  tbnz     w8, #5, #0x6897970
006897924  mov      x0, x19
006897928  mov      x1, xzr
00689792C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006897930  adrp     x21, #0x959c000
006897934  ldrb     w8, [x21, #0x4b0]
006897938  mov      w20, w0
00689793C  cbnz     w8, #0x6897954
006897940  adrp     x0, #0x8f25000
006897944  ldr      x0, [x0, #0xc58]
006897948  bl       #0x382bd14 ; 
00689794C  mov      w8, #1
006897950  strb     w8, [x21, #0x4b0]
006897954  adrp     x8, #0x8f25000
006897958  ldr      x8, [x8, #0xc58]
00689795C  ldr      x2, [x8]
006897960  ldrb     w8, [x2, #0x53]
006897964  tbnz     w8, #5, #0x6897984
006897968  str      w20, [x19, #0x20]
00689796C  b        #0x6897994 ; 
006897970  ldr      x2, [x1, #0x60]
006897974  mov      x0, x19
006897978  ldp      x20, x19, [sp, #0x10]
00689797C  ldp      x30, x21, [sp], #0x20
006897980  br       x2
006897984  ldr      x8, [x2, #0x60]
006897988  mov      x0, x19
00689798C  mov      w1, w20
006897990  blr      x8
006897994  mov      x0, x19
006897998  mov      x1, xzr
00689799C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068979A0  adrp     x21, #0x959c000
0068979A4  ldrb     w8, [x21, #0x4b1]
0068979A8  mov      x20, x0
0068979AC  cbnz     w8, #0x68979c4
0068979B0  adrp     x0, #0x8f25000
0068979B4  ldr      x0, [x0, #0xc68]
0068979B8  bl       #0x382bd14 ; 
0068979BC  mov      w8, #1
0068979C0  strb     w8, [x21, #0x4b1]
0068979C4  adrp     x8, #0x8f25000
0068979C8  ldr      x8, [x8, #0xc68]
0068979CC  ldr      x2, [x8]
0068979D0  ldrb     w8, [x2, #0x53]
0068979D4  tbnz     w8, #5, #0x68979ec
0068979D8  mov      x0, x19
0068979DC  str      x20, [x0, #0x28]!
0068979E0  mov      x1, x20
0068979E4  bl       #0x382bcb8 ; 
0068979E8  b        #0x68979fc ; 
0068979EC  ldr      x8, [x2, #0x60]
0068979F0  mov      x0, x19
0068979F4  mov      x1, x20
0068979F8  blr      x8
0068979FC  mov      x0, x19
006897A00  mov      x1, xzr
006897A04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006897A08  adrp     x21, #0x959c000
006897A0C  ldrb     w8, [x21, #0x4b2]
006897A10  mov      w20, w0
006897A14  cbnz     w8, #0x6897a2c
006897A18  adrp     x0, #0x8f25000
006897A1C  ldr      x0, [x0, #0xc78]
006897A20  bl       #0x382bd14 ; 
006897A24  mov      w8, #1
006897A28  strb     w8, [x21, #0x4b2]
006897A2C  adrp     x8, #0x8f25000
006897A30  ldr      x8, [x8, #0xc78]
006897A34  ldr      x2, [x8]
006897A38  ldrb     w8, [x2, #0x53]
006897A3C  tbnz     w8, #5, #0x6897a48
006897A40  str      w20, [x19, #0x30]
006897A44  b        #0x6897a58 ; 
006897A48  ldr      x8, [x2, #0x60]
006897A4C  mov      x0, x19
006897A50  mov      w1, w20
006897A54  blr      x8
006897A58  mov      x0, x19
006897A5C  mov      x1, xzr
006897A60  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006897A64  adrp     x21, #0x959c000
006897A68  ldrb     w8, [x21, #0x4b3]
006897A6C  mov      x20, x0
006897A70  cbnz     w8, #0x6897a88
006897A74  adrp     x0, #0x8f25000
006897A78  ldr      x0, [x0, #0xc88]
006897A7C  bl       #0x382bd14 ; 
006897A80  mov      w8, #1
006897A84  strb     w8, [x21, #0x4b3]
006897A88  adrp     x8, #0x8f25000
006897A8C  ldr      x8, [x8, #0xc88]
006897A90  ldr      x2, [x8]
006897A94  ldrb     w8, [x2, #0x53]
006897A98  tbnz     w8, #5, #0x6897ab0
006897A9C  str      x20, [x19, #0x38]!
006897AA0  mov      x0, x19
006897AA4  mov      x1, x20
006897AA8  bl       #0x382bcb8 ; 
006897AAC  b        #0x6897ac0 ; 
006897AB0  ldr      x8, [x2, #0x60]
006897AB4  mov      x0, x19
006897AB8  mov      x1, x20
006897ABC  blr      x8
006897AC0  ldp      x20, x19, [sp, #0x10]
006897AC4  mov      w0, #1
006897AC8  ldp      x30, x21, [sp], #0x20
006897ACC  ret      

