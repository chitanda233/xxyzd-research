; LocalModels.Bean.AutoProcess_monster$$readImpl
; RVA 0x6705304; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006705304  stp      x30, x21, [sp, #-0x20]!
006705308  stp      x20, x19, [sp, #0x10]
00670530C  adrp     x20, #0x959a000
006705310  adrp     x21, #0x8f17000
006705314  ldrb     w8, [x20, #0x90b]
006705318  ldr      x21, [x21, #0xa40]
00670531C  mov      x19, x0
006705320  tbnz     w8, #0, #0x6705338
006705324  adrp     x0, #0x8f17000
006705328  ldr      x0, [x0, #0xa40]
00670532C  bl       #0x382bd14 ; 
006705330  mov      w8, #1
006705334  strb     w8, [x20, #0x90b]
006705338  ldr      x1, [x21]
00670533C  ldrb     w8, [x1, #0x53]
006705340  tbnz     w8, #5, #0x6705390
006705344  mov      x0, x19
006705348  mov      x1, xzr
00670534C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006705350  adrp     x21, #0x959a000
006705354  ldrb     w8, [x21, #0x983]
006705358  mov      w20, w0
00670535C  cbnz     w8, #0x6705374
006705360  adrp     x0, #0x8f17000
006705364  ldr      x0, [x0, #0x9d8]
006705368  bl       #0x382bd14 ; 
00670536C  mov      w8, #1
006705370  strb     w8, [x21, #0x983]
006705374  adrp     x8, #0x8f17000
006705378  ldr      x8, [x8, #0x9d8]
00670537C  ldr      x2, [x8]
006705380  ldrb     w8, [x2, #0x53]
006705384  tbnz     w8, #5, #0x67053a4
006705388  str      w20, [x19, #0x20]
00670538C  b        #0x67053b4 ; 
006705390  ldr      x2, [x1, #0x60]
006705394  mov      x0, x19
006705398  ldp      x20, x19, [sp, #0x10]
00670539C  ldp      x30, x21, [sp], #0x20
0067053A0  br       x2
0067053A4  ldr      x8, [x2, #0x60]
0067053A8  mov      x0, x19
0067053AC  mov      w1, w20
0067053B0  blr      x8
0067053B4  mov      x0, x19
0067053B8  mov      x1, xzr
0067053BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0067053C0  adrp     x21, #0x959a000
0067053C4  ldrb     w8, [x21, #0x984]
0067053C8  mov      w20, w0
0067053CC  cbnz     w8, #0x67053e4
0067053D0  adrp     x0, #0x8f17000
0067053D4  ldr      x0, [x0, #0x9e8]
0067053D8  bl       #0x382bd14 ; 
0067053DC  mov      w8, #1
0067053E0  strb     w8, [x21, #0x984]
0067053E4  adrp     x8, #0x8f17000
0067053E8  ldr      x8, [x8, #0x9e8]
0067053EC  ldr      x2, [x8]
0067053F0  ldrb     w8, [x2, #0x53]
0067053F4  tbnz     w8, #5, #0x6705400
0067053F8  str      w20, [x19, #0x24]
0067053FC  b        #0x6705410 ; 
006705400  ldr      x8, [x2, #0x60]
006705404  mov      x0, x19
006705408  mov      w1, w20
00670540C  blr      x8
006705410  mov      x0, x19
006705414  mov      x1, xzr
006705418  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00670541C  adrp     x21, #0x959a000
006705420  ldrb     w8, [x21, #0x985]
006705424  mov      w20, w0
006705428  cbnz     w8, #0x6705440
00670542C  adrp     x0, #0x8f17000
006705430  ldr      x0, [x0, #0x9f8]
006705434  bl       #0x382bd14 ; 
006705438  mov      w8, #1
00670543C  strb     w8, [x21, #0x985]
006705440  adrp     x8, #0x8f17000
006705444  ldr      x8, [x8, #0x9f8]
006705448  ldr      x2, [x8]
00670544C  ldrb     w8, [x2, #0x53]
006705450  tbnz     w8, #5, #0x670545c
006705454  str      w20, [x19, #0x28]
006705458  b        #0x670546c ; 
00670545C  ldr      x8, [x2, #0x60]
006705460  mov      x0, x19
006705464  mov      w1, w20
006705468  blr      x8
00670546C  mov      x0, x19
006705470  mov      x1, xzr
006705474  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006705478  adrp     x21, #0x959a000
00670547C  ldrb     w8, [x21, #0x986]
006705480  mov      w20, w0
006705484  cbnz     w8, #0x670549c
006705488  adrp     x0, #0x8f17000
00670548C  ldr      x0, [x0, #0xa08]
006705490  bl       #0x382bd14 ; 
006705494  mov      w8, #1
006705498  strb     w8, [x21, #0x986]
00670549C  adrp     x8, #0x8f17000
0067054A0  ldr      x8, [x8, #0xa08]
0067054A4  ldr      x2, [x8]
0067054A8  ldrb     w8, [x2, #0x53]
0067054AC  tbnz     w8, #5, #0x67054b8
0067054B0  str      w20, [x19, #0x2c]
0067054B4  b        #0x67054c8 ; 
0067054B8  ldr      x8, [x2, #0x60]
0067054BC  mov      x0, x19
0067054C0  mov      w1, w20
0067054C4  blr      x8
0067054C8  mov      x0, x19
0067054CC  mov      x1, xzr
0067054D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0067054D4  adrp     x21, #0x959a000
0067054D8  ldrb     w8, [x21, #0x987]
0067054DC  mov      w20, w0
0067054E0  cbnz     w8, #0x67054f8
0067054E4  adrp     x0, #0x8f17000
0067054E8  ldr      x0, [x0, #0xa18]
0067054EC  bl       #0x382bd14 ; 
0067054F0  mov      w8, #1
0067054F4  strb     w8, [x21, #0x987]
0067054F8  adrp     x8, #0x8f17000
0067054FC  ldr      x8, [x8, #0xa18]
006705500  ldr      x2, [x8]
006705504  ldrb     w8, [x2, #0x53]
006705508  tbnz     w8, #5, #0x6705514
00670550C  str      w20, [x19, #0x30]
006705510  b        #0x6705524 ; 
006705514  ldr      x8, [x2, #0x60]
006705518  mov      x0, x19
00670551C  mov      w1, w20
006705520  blr      x8
006705524  mov      x0, x19
006705528  mov      x1, xzr
00670552C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006705530  adrp     x21, #0x959a000
006705534  ldrb     w8, [x21, #0x988]
006705538  mov      x20, x0
00670553C  cbnz     w8, #0x6705554
006705540  adrp     x0, #0x8f17000
006705544  ldr      x0, [x0, #0xa28]
006705548  bl       #0x382bd14 ; 
00670554C  mov      w8, #1
006705550  strb     w8, [x21, #0x988]
006705554  adrp     x8, #0x8f17000
006705558  ldr      x8, [x8, #0xa28]
00670555C  ldr      x2, [x8]
006705560  ldrb     w8, [x2, #0x53]
006705564  tbnz     w8, #5, #0x670557c
006705568  mov      x0, x19
00670556C  str      x20, [x0, #0x38]!
006705570  mov      x1, x20
006705574  bl       #0x382bcb8 ; 
006705578  b        #0x670558c ; 
00670557C  ldr      x8, [x2, #0x60]
006705580  mov      x0, x19
006705584  mov      x1, x20
006705588  blr      x8
00670558C  mov      x0, x19
006705590  mov      x1, xzr
006705594  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006705598  adrp     x21, #0x959a000
00670559C  ldrb     w8, [x21, #0x989]
0067055A0  mov      w20, w0
0067055A4  cbnz     w8, #0x67055bc
0067055A8  adrp     x0, #0x8f17000
0067055AC  ldr      x0, [x0, #0xa38]
0067055B0  bl       #0x382bd14 ; 
0067055B4  mov      w8, #1
0067055B8  strb     w8, [x21, #0x989]
0067055BC  adrp     x8, #0x8f17000
0067055C0  ldr      x8, [x8, #0xa38]
0067055C4  ldr      x2, [x8]
0067055C8  ldrb     w8, [x2, #0x53]
0067055CC  tbnz     w8, #5, #0x67055d8
0067055D0  str      w20, [x19, #0x40]
0067055D4  b        #0x67055e8 ; 
0067055D8  ldr      x8, [x2, #0x60]
0067055DC  mov      x0, x19
0067055E0  mov      w1, w20
0067055E4  blr      x8
0067055E8  ldp      x20, x19, [sp, #0x10]
0067055EC  mov      w0, #1
0067055F0  ldp      x30, x21, [sp], #0x20
0067055F4  ret      

