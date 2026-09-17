; LocalModels.Bean.Character_hurtAttributeName$$readImpl
; RVA 0x68C8030; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068C8030  stp      x30, x21, [sp, #-0x20]!
0068C8034  stp      x20, x19, [sp, #0x10]
0068C8038  adrp     x20, #0x959c000
0068C803C  adrp     x21, #0x8f28000
0068C8040  ldrb     w8, [x20, #0x2cd]
0068C8044  ldr      x21, [x21, #0x70]
0068C8048  mov      x19, x0
0068C804C  tbnz     w8, #0, #0x68c8064
0068C8050  adrp     x0, #0x8f28000
0068C8054  ldr      x0, [x0, #0x70]
0068C8058  bl       #0x382bd14 ; 
0068C805C  mov      w8, #1
0068C8060  strb     w8, [x20, #0x2cd]
0068C8064  ldr      x1, [x21]
0068C8068  ldrb     w8, [x1, #0x53]
0068C806C  tbnz     w8, #5, #0x68c80bc
0068C8070  mov      x0, x19
0068C8074  mov      x1, xzr
0068C8078  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C807C  adrp     x21, #0x959c000
0068C8080  ldrb     w8, [x21, #0x6fd]
0068C8084  mov      w20, w0
0068C8088  cbnz     w8, #0x68c80a0
0068C808C  adrp     x0, #0x8f28000
0068C8090  ldr      x0, [x0, #0x50]
0068C8094  bl       #0x382bd14 ; 
0068C8098  mov      w8, #1
0068C809C  strb     w8, [x21, #0x6fd]
0068C80A0  adrp     x8, #0x8f28000
0068C80A4  ldr      x8, [x8, #0x50]
0068C80A8  ldr      x2, [x8]
0068C80AC  ldrb     w8, [x2, #0x53]
0068C80B0  tbnz     w8, #5, #0x68c80d0
0068C80B4  str      w20, [x19, #0x20]
0068C80B8  b        #0x68c80e0 ; 
0068C80BC  ldr      x2, [x1, #0x60]
0068C80C0  mov      x0, x19
0068C80C4  ldp      x20, x19, [sp, #0x10]
0068C80C8  ldp      x30, x21, [sp], #0x20
0068C80CC  br       x2
0068C80D0  ldr      x8, [x2, #0x60]
0068C80D4  mov      x0, x19
0068C80D8  mov      w1, w20
0068C80DC  blr      x8
0068C80E0  mov      x0, x19
0068C80E4  mov      x1, xzr
0068C80E8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C80EC  adrp     x21, #0x959c000
0068C80F0  ldrb     w8, [x21, #0x6fe]
0068C80F4  mov      x20, x0
0068C80F8  cbnz     w8, #0x68c8110
0068C80FC  adrp     x0, #0x8f28000
0068C8100  ldr      x0, [x0, #0x58]
0068C8104  bl       #0x382bd14 ; 
0068C8108  mov      w8, #1
0068C810C  strb     w8, [x21, #0x6fe]
0068C8110  adrp     x8, #0x8f28000
0068C8114  ldr      x8, [x8, #0x58]
0068C8118  ldr      x2, [x8]
0068C811C  ldrb     w8, [x2, #0x53]
0068C8120  tbnz     w8, #5, #0x68c8138
0068C8124  mov      x0, x19
0068C8128  str      x20, [x0, #0x28]!
0068C812C  mov      x1, x20
0068C8130  bl       #0x382bcb8 ; 
0068C8134  b        #0x68c8148 ; 
0068C8138  ldr      x8, [x2, #0x60]
0068C813C  mov      x0, x19
0068C8140  mov      x1, x20
0068C8144  blr      x8
0068C8148  mov      x0, x19
0068C814C  mov      x1, xzr
0068C8150  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C8154  adrp     x21, #0x959c000
0068C8158  ldrb     w8, [x21, #0x6ff]
0068C815C  mov      w20, w0
0068C8160  cbnz     w8, #0x68c8178
0068C8164  adrp     x0, #0x8f28000
0068C8168  ldr      x0, [x0, #0x60]
0068C816C  bl       #0x382bd14 ; 
0068C8170  mov      w8, #1
0068C8174  strb     w8, [x21, #0x6ff]
0068C8178  adrp     x8, #0x8f28000
0068C817C  ldr      x8, [x8, #0x60]
0068C8180  ldr      x2, [x8]
0068C8184  ldrb     w8, [x2, #0x53]
0068C8188  tbnz     w8, #5, #0x68c8194
0068C818C  str      w20, [x19, #0x30]
0068C8190  b        #0x68c81a4 ; 
0068C8194  ldr      x8, [x2, #0x60]
0068C8198  mov      x0, x19
0068C819C  mov      w1, w20
0068C81A0  blr      x8
0068C81A4  mov      x0, x19
0068C81A8  mov      x1, xzr
0068C81AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C81B0  adrp     x21, #0x959c000
0068C81B4  ldrb     w8, [x21, #0x700]
0068C81B8  mov      w20, w0
0068C81BC  cbnz     w8, #0x68c81d4
0068C81C0  adrp     x0, #0x8f28000
0068C81C4  ldr      x0, [x0, #0x68]
0068C81C8  bl       #0x382bd14 ; 
0068C81CC  mov      w8, #1
0068C81D0  strb     w8, [x21, #0x700]
0068C81D4  adrp     x8, #0x8f28000
0068C81D8  ldr      x8, [x8, #0x68]
0068C81DC  ldr      x2, [x8]
0068C81E0  ldrb     w8, [x2, #0x53]
0068C81E4  tbnz     w8, #5, #0x68c81f0
0068C81E8  str      w20, [x19, #0x34]
0068C81EC  b        #0x68c8200 ; 
0068C81F0  ldr      x8, [x2, #0x60]
0068C81F4  mov      x0, x19
0068C81F8  mov      w1, w20
0068C81FC  blr      x8
0068C8200  ldp      x20, x19, [sp, #0x10]
0068C8204  mov      w0, #1
0068C8208  ldp      x30, x21, [sp], #0x20
0068C820C  ret      

