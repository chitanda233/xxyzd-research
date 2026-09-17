; LocalModels.Bean.ColorRelace_ColorType$$readImpl
; RVA 0x68CF420; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CF420  stp      x30, x21, [sp, #-0x20]!
0068CF424  stp      x20, x19, [sp, #0x10]
0068CF428  adrp     x20, #0x959c000
0068CF42C  adrp     x21, #0x8f28000
0068CF430  ldrb     w8, [x20, #0x390]
0068CF434  ldr      x21, [x21, #0x5e8]
0068CF438  mov      x19, x0
0068CF43C  tbnz     w8, #0, #0x68cf454
0068CF440  adrp     x0, #0x8f28000
0068CF444  ldr      x0, [x0, #0x5e8]
0068CF448  bl       #0x382bd14 ; 
0068CF44C  mov      w8, #1
0068CF450  strb     w8, [x20, #0x390]
0068CF454  ldr      x1, [x21]
0068CF458  ldrb     w8, [x1, #0x53]
0068CF45C  tbnz     w8, #5, #0x68cf4ac
0068CF460  mov      x0, x19
0068CF464  mov      x1, xzr
0068CF468  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CF46C  adrp     x21, #0x959c000
0068CF470  ldrb     w8, [x21, #0x749]
0068CF474  mov      w20, w0
0068CF478  cbnz     w8, #0x68cf490
0068CF47C  adrp     x0, #0x8f28000
0068CF480  ldr      x0, [x0, #0x5c0]
0068CF484  bl       #0x382bd14 ; 
0068CF488  mov      w8, #1
0068CF48C  strb     w8, [x21, #0x749]
0068CF490  adrp     x8, #0x8f28000
0068CF494  ldr      x8, [x8, #0x5c0]
0068CF498  ldr      x2, [x8]
0068CF49C  ldrb     w8, [x2, #0x53]
0068CF4A0  tbnz     w8, #5, #0x68cf4c0
0068CF4A4  str      w20, [x19, #0x20]
0068CF4A8  b        #0x68cf4d0 ; 
0068CF4AC  ldr      x2, [x1, #0x60]
0068CF4B0  mov      x0, x19
0068CF4B4  ldp      x20, x19, [sp, #0x10]
0068CF4B8  ldp      x30, x21, [sp], #0x20
0068CF4BC  br       x2
0068CF4C0  ldr      x8, [x2, #0x60]
0068CF4C4  mov      x0, x19
0068CF4C8  mov      w1, w20
0068CF4CC  blr      x8
0068CF4D0  mov      x0, x19
0068CF4D4  mov      x1, xzr
0068CF4D8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CF4DC  adrp     x21, #0x959c000
0068CF4E0  ldrb     w8, [x21, #0x74a]
0068CF4E4  mov      x20, x0
0068CF4E8  cbnz     w8, #0x68cf500
0068CF4EC  adrp     x0, #0x8f28000
0068CF4F0  ldr      x0, [x0, #0x5d0]
0068CF4F4  bl       #0x382bd14 ; 
0068CF4F8  mov      w8, #1
0068CF4FC  strb     w8, [x21, #0x74a]
0068CF500  adrp     x8, #0x8f28000
0068CF504  ldr      x8, [x8, #0x5d0]
0068CF508  ldr      x2, [x8]
0068CF50C  ldrb     w8, [x2, #0x53]
0068CF510  tbnz     w8, #5, #0x68cf528
0068CF514  mov      x0, x19
0068CF518  str      x20, [x0, #0x28]!
0068CF51C  mov      x1, x20
0068CF520  bl       #0x382bcb8 ; 
0068CF524  b        #0x68cf538 ; 
0068CF528  ldr      x8, [x2, #0x60]
0068CF52C  mov      x0, x19
0068CF530  mov      x1, x20
0068CF534  blr      x8
0068CF538  mov      x0, x19
0068CF53C  mov      x1, xzr
0068CF540  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CF544  adrp     x21, #0x959c000
0068CF548  ldrb     w8, [x21, #0x74b]
0068CF54C  mov      x20, x0
0068CF550  cbnz     w8, #0x68cf568
0068CF554  adrp     x0, #0x8f28000
0068CF558  ldr      x0, [x0, #0x5e0]
0068CF55C  bl       #0x382bd14 ; 
0068CF560  mov      w8, #1
0068CF564  strb     w8, [x21, #0x74b]
0068CF568  adrp     x8, #0x8f28000
0068CF56C  ldr      x8, [x8, #0x5e0]
0068CF570  ldr      x2, [x8]
0068CF574  ldrb     w8, [x2, #0x53]
0068CF578  tbnz     w8, #5, #0x68cf590
0068CF57C  str      x20, [x19, #0x30]!
0068CF580  mov      x0, x19
0068CF584  mov      x1, x20
0068CF588  bl       #0x382bcb8 ; 
0068CF58C  b        #0x68cf5a0 ; 
0068CF590  ldr      x8, [x2, #0x60]
0068CF594  mov      x0, x19
0068CF598  mov      x1, x20
0068CF59C  blr      x8
0068CF5A0  ldp      x20, x19, [sp, #0x10]
0068CF5A4  mov      w0, #1
0068CF5A8  ldp      x30, x21, [sp], #0x20
0068CF5AC  ret      

