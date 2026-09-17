; LocalModels.Bean.AttributeString_property$$readImpl
; RVA 0x6701FE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006701FE4  stp      x30, x21, [sp, #-0x20]!
006701FE8  stp      x20, x19, [sp, #0x10]
006701FEC  adrp     x20, #0x959a000
006701FF0  adrp     x21, #0x8f17000
006701FF4  ldrb     w8, [x20, #0x8b4]
006701FF8  ldr      x21, [x21, #0x7b0]
006701FFC  mov      x19, x0
006702000  tbnz     w8, #0, #0x6702018
006702004  adrp     x0, #0x8f17000
006702008  ldr      x0, [x0, #0x7b0]
00670200C  bl       #0x382bd14 ; 
006702010  mov      w8, #1
006702014  strb     w8, [x20, #0x8b4]
006702018  ldr      x1, [x21]
00670201C  ldrb     w8, [x1, #0x53]
006702020  tbnz     w8, #5, #0x6702070
006702024  mov      x0, x19
006702028  mov      x1, xzr
00670202C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006702030  adrp     x21, #0x959a000
006702034  ldrb     w8, [x21, #0x962]
006702038  mov      w20, w0
00670203C  cbnz     w8, #0x6702054
006702040  adrp     x0, #0x8f17000
006702044  ldr      x0, [x0, #0x778]
006702048  bl       #0x382bd14 ; 
00670204C  mov      w8, #1
006702050  strb     w8, [x21, #0x962]
006702054  adrp     x8, #0x8f17000
006702058  ldr      x8, [x8, #0x778]
00670205C  ldr      x2, [x8]
006702060  ldrb     w8, [x2, #0x53]
006702064  tbnz     w8, #5, #0x6702084
006702068  str      w20, [x19, #0x20]
00670206C  b        #0x6702094 ; 
006702070  ldr      x2, [x1, #0x60]
006702074  mov      x0, x19
006702078  ldp      x20, x19, [sp, #0x10]
00670207C  ldp      x30, x21, [sp], #0x20
006702080  br       x2
006702084  ldr      x8, [x2, #0x60]
006702088  mov      x0, x19
00670208C  mov      w1, w20
006702090  blr      x8
006702094  mov      x0, x19
006702098  mov      x1, xzr
00670209C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0067020A0  adrp     x21, #0x959a000
0067020A4  ldrb     w8, [x21, #0x963]
0067020A8  mov      x20, x0
0067020AC  cbnz     w8, #0x67020c4
0067020B0  adrp     x0, #0x8f17000
0067020B4  ldr      x0, [x0, #0x788]
0067020B8  bl       #0x382bd14 ; 
0067020BC  mov      w8, #1
0067020C0  strb     w8, [x21, #0x963]
0067020C4  adrp     x8, #0x8f17000
0067020C8  ldr      x8, [x8, #0x788]
0067020CC  ldr      x2, [x8]
0067020D0  ldrb     w8, [x2, #0x53]
0067020D4  tbnz     w8, #5, #0x67020ec
0067020D8  mov      x0, x19
0067020DC  str      x20, [x0, #0x28]!
0067020E0  mov      x1, x20
0067020E4  bl       #0x382bcb8 ; 
0067020E8  b        #0x67020fc ; 
0067020EC  ldr      x8, [x2, #0x60]
0067020F0  mov      x0, x19
0067020F4  mov      x1, x20
0067020F8  blr      x8
0067020FC  mov      x0, x19
006702100  mov      x1, xzr
006702104  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006702108  adrp     x21, #0x959a000
00670210C  ldrb     w8, [x21, #0x964]
006702110  mov      w20, w0
006702114  cbnz     w8, #0x670212c
006702118  adrp     x0, #0x8f17000
00670211C  ldr      x0, [x0, #0x798]
006702120  bl       #0x382bd14 ; 
006702124  mov      w8, #1
006702128  strb     w8, [x21, #0x964]
00670212C  adrp     x8, #0x8f17000
006702130  ldr      x8, [x8, #0x798]
006702134  ldr      x2, [x8]
006702138  ldrb     w8, [x2, #0x53]
00670213C  tbnz     w8, #5, #0x6702148
006702140  str      w20, [x19, #0x30]
006702144  b        #0x6702158 ; 
006702148  ldr      x8, [x2, #0x60]
00670214C  mov      x0, x19
006702150  mov      w1, w20
006702154  blr      x8
006702158  mov      x0, x19
00670215C  mov      x1, xzr
006702160  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006702164  adrp     x21, #0x959a000
006702168  ldrb     w8, [x21, #0x965]
00670216C  mov      w20, w0
006702170  cbnz     w8, #0x6702188
006702174  adrp     x0, #0x8f17000
006702178  ldr      x0, [x0, #0x7a8]
00670217C  bl       #0x382bd14 ; 
006702180  mov      w8, #1
006702184  strb     w8, [x21, #0x965]
006702188  adrp     x8, #0x8f17000
00670218C  ldr      x8, [x8, #0x7a8]
006702190  ldr      x2, [x8]
006702194  ldrb     w8, [x2, #0x53]
006702198  tbnz     w8, #5, #0x67021a4
00670219C  str      w20, [x19, #0x34]
0067021A0  b        #0x67021b4 ; 
0067021A4  ldr      x8, [x2, #0x60]
0067021A8  mov      x0, x19
0067021AC  mov      w1, w20
0067021B0  blr      x8
0067021B4  ldp      x20, x19, [sp, #0x10]
0067021B8  mov      w0, #1
0067021BC  ldp      x30, x21, [sp], #0x20
0067021C0  ret      

