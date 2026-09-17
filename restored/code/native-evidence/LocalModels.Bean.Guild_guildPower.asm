; LocalModels.Bean.Guild_guildPower$$readImpl
; RVA 0x6A9400C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A9400C  stp      x30, x21, [sp, #-0x20]!
006A94010  stp      x20, x19, [sp, #0x10]
006A94014  adrp     x20, #0x959e000
006A94018  adrp     x21, #0x8f39000
006A9401C  ldrb     w8, [x20, #0x151]
006A94020  ldr      x21, [x21, #0xa0]
006A94024  mov      x19, x0
006A94028  tbnz     w8, #0, #0x6a94040
006A9402C  adrp     x0, #0x8f39000
006A94030  ldr      x0, [x0, #0xa0]
006A94034  bl       #0x382bd14 ; 
006A94038  mov      w8, #1
006A9403C  strb     w8, [x20, #0x151]
006A94040  ldr      x1, [x21]
006A94044  ldrb     w8, [x1, #0x53]
006A94048  tbnz     w8, #5, #0x6a94098
006A9404C  mov      x0, x19
006A94050  mov      x1, xzr
006A94054  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A94058  adrp     x21, #0x959e000
006A9405C  ldrb     w8, [x21, #0x5d1]
006A94060  mov      w20, w0
006A94064  cbnz     w8, #0x6a9407c
006A94068  adrp     x0, #0x8f39000
006A9406C  ldr      x0, [x0, #0x78]
006A94070  bl       #0x382bd14 ; 
006A94074  mov      w8, #1
006A94078  strb     w8, [x21, #0x5d1]
006A9407C  adrp     x8, #0x8f39000
006A94080  ldr      x8, [x8, #0x78]
006A94084  ldr      x2, [x8]
006A94088  ldrb     w8, [x2, #0x53]
006A9408C  tbnz     w8, #5, #0x6a940ac
006A94090  str      w20, [x19, #0x20]
006A94094  b        #0x6a940bc ; 
006A94098  ldr      x2, [x1, #0x60]
006A9409C  mov      x0, x19
006A940A0  ldp      x20, x19, [sp, #0x10]
006A940A4  ldp      x30, x21, [sp], #0x20
006A940A8  br       x2
006A940AC  ldr      x8, [x2, #0x60]
006A940B0  mov      x0, x19
006A940B4  mov      w1, w20
006A940B8  blr      x8
006A940BC  mov      x0, x19
006A940C0  mov      x1, xzr
006A940C4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A940C8  adrp     x21, #0x959e000
006A940CC  ldrb     w8, [x21, #0x5d2]
006A940D0  mov      x20, x0
006A940D4  cbnz     w8, #0x6a940ec
006A940D8  adrp     x0, #0x8f39000
006A940DC  ldr      x0, [x0, #0x88]
006A940E0  bl       #0x382bd14 ; 
006A940E4  mov      w8, #1
006A940E8  strb     w8, [x21, #0x5d2]
006A940EC  adrp     x8, #0x8f39000
006A940F0  ldr      x8, [x8, #0x88]
006A940F4  ldr      x2, [x8]
006A940F8  ldrb     w8, [x2, #0x53]
006A940FC  tbnz     w8, #5, #0x6a94114
006A94100  mov      x0, x19
006A94104  str      x20, [x0, #0x28]!
006A94108  mov      x1, x20
006A9410C  bl       #0x382bcb8 ; 
006A94110  b        #0x6a94124 ; 
006A94114  ldr      x8, [x2, #0x60]
006A94118  mov      x0, x19
006A9411C  mov      x1, x20
006A94120  blr      x8
006A94124  mov      x0, x19
006A94128  mov      x1, xzr
006A9412C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A94130  adrp     x21, #0x959e000
006A94134  ldrb     w8, [x21, #0x5d3]
006A94138  mov      x20, x0
006A9413C  cbnz     w8, #0x6a94154
006A94140  adrp     x0, #0x8f39000
006A94144  ldr      x0, [x0, #0x98]
006A94148  bl       #0x382bd14 ; 
006A9414C  mov      w8, #1
006A94150  strb     w8, [x21, #0x5d3]
006A94154  adrp     x8, #0x8f39000
006A94158  ldr      x8, [x8, #0x98]
006A9415C  ldr      x2, [x8]
006A94160  ldrb     w8, [x2, #0x53]
006A94164  tbnz     w8, #5, #0x6a9417c
006A94168  str      x20, [x19, #0x30]!
006A9416C  mov      x0, x19
006A94170  mov      x1, x20
006A94174  bl       #0x382bcb8 ; 
006A94178  b        #0x6a9418c ; 
006A9417C  ldr      x8, [x2, #0x60]
006A94180  mov      x0, x19
006A94184  mov      x1, x20
006A94188  blr      x8
006A9418C  ldp      x20, x19, [sp, #0x10]
006A94190  mov      w0, #1
006A94194  ldp      x30, x21, [sp], #0x20
006A94198  ret      

