; LocalModels.Bean.BattleMain_wave$$readImpl
; RVA 0x6884FB4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006884FB4  stp      x30, x21, [sp, #-0x20]!
006884FB8  stp      x20, x19, [sp, #0x10]
006884FBC  adrp     x20, #0x959b000
006884FC0  adrp     x21, #0x8f24000
006884FC4  ldrb     w8, [x20, #0xbfd]
006884FC8  ldr      x21, [x21, #0xf68]
006884FCC  mov      x19, x0
006884FD0  tbnz     w8, #0, #0x6884fe8
006884FD4  adrp     x0, #0x8f24000
006884FD8  ldr      x0, [x0, #0xf68]
006884FDC  bl       #0x382bd14 ; 
006884FE0  mov      w8, #1
006884FE4  strb     w8, [x20, #0xbfd]
006884FE8  ldr      x1, [x21]
006884FEC  ldrb     w8, [x1, #0x53]
006884FF0  tbnz     w8, #5, #0x6885040
006884FF4  mov      x0, x19
006884FF8  mov      x1, xzr
006884FFC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006885000  adrp     x21, #0x959c000
006885004  ldrb     w8, [x21, #0x3de]
006885008  mov      w20, w0
00688500C  cbnz     w8, #0x6885024
006885010  adrp     x0, #0x8f24000
006885014  ldr      x0, [x0, #0xef0]
006885018  bl       #0x382bd14 ; 
00688501C  mov      w8, #1
006885020  strb     w8, [x21, #0x3de]
006885024  adrp     x8, #0x8f24000
006885028  ldr      x8, [x8, #0xef0]
00688502C  ldr      x2, [x8]
006885030  ldrb     w8, [x2, #0x53]
006885034  tbnz     w8, #5, #0x6885054
006885038  str      w20, [x19, #0x20]
00688503C  b        #0x6885064 ; 
006885040  ldr      x2, [x1, #0x60]
006885044  mov      x0, x19
006885048  ldp      x20, x19, [sp, #0x10]
00688504C  ldp      x30, x21, [sp], #0x20
006885050  br       x2
006885054  ldr      x8, [x2, #0x60]
006885058  mov      x0, x19
00688505C  mov      w1, w20
006885060  blr      x8
006885064  mov      x0, x19
006885068  mov      x1, xzr
00688506C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006885070  adrp     x21, #0x959c000
006885074  ldrb     w8, [x21, #0x3df]
006885078  mov      w20, w0
00688507C  cbnz     w8, #0x6885094
006885080  adrp     x0, #0x8f24000
006885084  ldr      x0, [x0, #0xf00]
006885088  bl       #0x382bd14 ; 
00688508C  mov      w8, #1
006885090  strb     w8, [x21, #0x3df]
006885094  adrp     x8, #0x8f24000
006885098  ldr      x8, [x8, #0xf00]
00688509C  ldr      x2, [x8]
0068850A0  ldrb     w8, [x2, #0x53]
0068850A4  tbnz     w8, #5, #0x68850b0
0068850A8  str      w20, [x19, #0x24]
0068850AC  b        #0x68850c0 ; 
0068850B0  ldr      x8, [x2, #0x60]
0068850B4  mov      x0, x19
0068850B8  mov      w1, w20
0068850BC  blr      x8
0068850C0  mov      x0, x19
0068850C4  mov      x1, xzr
0068850C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068850CC  adrp     x21, #0x959c000
0068850D0  ldrb     w8, [x21, #0x3e0]
0068850D4  mov      w20, w0
0068850D8  cbnz     w8, #0x68850f0
0068850DC  adrp     x0, #0x8f24000
0068850E0  ldr      x0, [x0, #0xf10]
0068850E4  bl       #0x382bd14 ; 
0068850E8  mov      w8, #1
0068850EC  strb     w8, [x21, #0x3e0]
0068850F0  adrp     x8, #0x8f24000
0068850F4  ldr      x8, [x8, #0xf10]
0068850F8  ldr      x2, [x8]
0068850FC  ldrb     w8, [x2, #0x53]
006885100  tbnz     w8, #5, #0x688510c
006885104  str      w20, [x19, #0x28]
006885108  b        #0x688511c ; 
00688510C  ldr      x8, [x2, #0x60]
006885110  mov      x0, x19
006885114  mov      w1, w20
006885118  blr      x8
00688511C  mov      x0, x19
006885120  mov      x1, xzr
006885124  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006885128  adrp     x21, #0x959c000
00688512C  ldrb     w8, [x21, #0x3e1]
006885130  mov      w20, w0
006885134  cbnz     w8, #0x688514c
006885138  adrp     x0, #0x8f24000
00688513C  ldr      x0, [x0, #0xf20]
006885140  bl       #0x382bd14 ; 
006885144  mov      w8, #1
006885148  strb     w8, [x21, #0x3e1]
00688514C  adrp     x8, #0x8f24000
006885150  ldr      x8, [x8, #0xf20]
006885154  ldr      x2, [x8]
006885158  ldrb     w8, [x2, #0x53]
00688515C  tbnz     w8, #5, #0x6885168
006885160  str      w20, [x19, #0x2c]
006885164  b        #0x6885178 ; 
006885168  ldr      x8, [x2, #0x60]
00688516C  mov      x0, x19
006885170  mov      w1, w20
006885174  blr      x8
006885178  mov      x0, x19
00688517C  mov      x1, xzr
006885180  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006885184  adrp     x21, #0x959c000
006885188  ldrb     w8, [x21, #0x3e2]
00688518C  mov      w20, w0
006885190  cbnz     w8, #0x68851a8
006885194  adrp     x0, #0x8f24000
006885198  ldr      x0, [x0, #0xf30]
00688519C  bl       #0x382bd14 ; 
0068851A0  mov      w8, #1
0068851A4  strb     w8, [x21, #0x3e2]
0068851A8  adrp     x8, #0x8f24000
0068851AC  ldr      x8, [x8, #0xf30]
0068851B0  ldr      x2, [x8]
0068851B4  ldrb     w8, [x2, #0x53]
0068851B8  tbnz     w8, #5, #0x68851c4
0068851BC  str      w20, [x19, #0x30]
0068851C0  b        #0x68851d4 ; 
0068851C4  ldr      x8, [x2, #0x60]
0068851C8  mov      x0, x19
0068851CC  mov      w1, w20
0068851D0  blr      x8
0068851D4  mov      x0, x19
0068851D8  mov      x1, xzr
0068851DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068851E0  adrp     x21, #0x959c000
0068851E4  ldrb     w8, [x21, #0x3e3]
0068851E8  mov      w20, w0
0068851EC  cbnz     w8, #0x6885204
0068851F0  adrp     x0, #0x8f24000
0068851F4  ldr      x0, [x0, #0xf40]
0068851F8  bl       #0x382bd14 ; 
0068851FC  mov      w8, #1
006885200  strb     w8, [x21, #0x3e3]
006885204  adrp     x8, #0x8f24000
006885208  ldr      x8, [x8, #0xf40]
00688520C  ldr      x2, [x8]
006885210  ldrb     w8, [x2, #0x53]
006885214  tbnz     w8, #5, #0x6885220
006885218  str      w20, [x19, #0x34]
00688521C  b        #0x6885230 ; 
006885220  ldr      x8, [x2, #0x60]
006885224  mov      x0, x19
006885228  mov      w1, w20
00688522C  blr      x8
006885230  mov      x0, x19
006885234  mov      x1, xzr
006885238  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688523C  adrp     x21, #0x959c000
006885240  ldrb     w8, [x21, #0x3e4]
006885244  mov      w20, w0
006885248  cbnz     w8, #0x6885260
00688524C  adrp     x0, #0x8f24000
006885250  ldr      x0, [x0, #0xf50]
006885254  bl       #0x382bd14 ; 
006885258  mov      w8, #1
00688525C  strb     w8, [x21, #0x3e4]
006885260  adrp     x8, #0x8f24000
006885264  ldr      x8, [x8, #0xf50]
006885268  ldr      x2, [x8]
00688526C  ldrb     w8, [x2, #0x53]
006885270  tbnz     w8, #5, #0x688527c
006885274  str      w20, [x19, #0x38]
006885278  b        #0x688528c ; 
00688527C  ldr      x8, [x2, #0x60]
006885280  mov      x0, x19
006885284  mov      w1, w20
006885288  blr      x8
00688528C  mov      x0, x19
006885290  mov      x1, xzr
006885294  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006885298  adrp     x21, #0x959c000
00688529C  ldrb     w8, [x21, #0x3e5]
0068852A0  mov      x20, x0
0068852A4  cbnz     w8, #0x68852bc
0068852A8  adrp     x0, #0x8f24000
0068852AC  ldr      x0, [x0, #0xf60]
0068852B0  bl       #0x382bd14 ; 
0068852B4  mov      w8, #1
0068852B8  strb     w8, [x21, #0x3e5]
0068852BC  adrp     x8, #0x8f24000
0068852C0  ldr      x8, [x8, #0xf60]
0068852C4  ldr      x2, [x8]
0068852C8  ldrb     w8, [x2, #0x53]
0068852CC  tbnz     w8, #5, #0x68852e4
0068852D0  str      x20, [x19, #0x40]!
0068852D4  mov      x0, x19
0068852D8  mov      x1, x20
0068852DC  bl       #0x382bcb8 ; 
0068852E0  b        #0x68852f4 ; 
0068852E4  ldr      x8, [x2, #0x60]
0068852E8  mov      x0, x19
0068852EC  mov      x1, x20
0068852F0  blr      x8
0068852F4  ldp      x20, x19, [sp, #0x10]
0068852F8  mov      w0, #1
0068852FC  ldp      x30, x21, [sp], #0x20
006885300  ret      

