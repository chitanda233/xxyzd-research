; LocalModels.Bean.Calendar_CalendarFig$$readImpl
; RVA 0x68902F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068902F4  str      d8, [sp, #-0x30]!
0068902F8  stp      x30, x21, [sp, #0x10]
0068902FC  stp      x20, x19, [sp, #0x20]
006890300  adrp     x20, #0x959b000
006890304  adrp     x21, #0x8f25000
006890308  ldrb     w8, [x20, #0xd1e]
00689030C  ldr      x21, [x21, #0x6e0]
006890310  mov      x19, x0
006890314  tbnz     w8, #0, #0x689032c
006890318  adrp     x0, #0x8f25000
00689031C  ldr      x0, [x0, #0x6e0]
006890320  bl       #0x382bd14 ; 
006890324  mov      w8, #1
006890328  strb     w8, [x20, #0xd1e]
00689032C  ldr      x1, [x21]
006890330  ldrb     w8, [x1, #0x53]
006890334  tbnz     w8, #5, #0x6890390
006890338  mov      x0, x19
00689033C  mov      x1, xzr
006890340  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006890344  adrp     x21, #0x959c000
006890348  ldrb     w8, [x21, #0x45e]
00689034C  mov      x20, x0
006890350  cbnz     w8, #0x6890368
006890354  adrp     x0, #0x8f25000
006890358  ldr      x0, [x0, #0x668]
00689035C  bl       #0x382bd14 ; 
006890360  mov      w8, #1
006890364  strb     w8, [x21, #0x45e]
006890368  adrp     x8, #0x8f25000
00689036C  ldr      x8, [x8, #0x668]
006890370  ldr      x2, [x8]
006890374  ldrb     w8, [x2, #0x53]
006890378  tbnz     w8, #5, #0x68903a8
00689037C  mov      x0, x19
006890380  str      x20, [x0, #0x20]!
006890384  mov      x1, x20
006890388  bl       #0x382bcb8 ; 
00689038C  b        #0x68903b8 ; 
006890390  ldr      x2, [x1, #0x60]
006890394  mov      x0, x19
006890398  ldp      x20, x19, [sp, #0x20]
00689039C  ldp      x30, x21, [sp, #0x10]
0068903A0  ldr      d8, [sp], #0x30
0068903A4  br       x2
0068903A8  ldr      x8, [x2, #0x60]
0068903AC  mov      x0, x19
0068903B0  mov      x1, x20
0068903B4  blr      x8
0068903B8  mov      x0, x19
0068903BC  mov      x1, xzr
0068903C0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068903C4  adrp     x21, #0x959c000
0068903C8  ldrb     w8, [x21, #0x45f]
0068903CC  mov      x20, x0
0068903D0  cbnz     w8, #0x68903e8
0068903D4  adrp     x0, #0x8f25000
0068903D8  ldr      x0, [x0, #0x678]
0068903DC  bl       #0x382bd14 ; 
0068903E0  mov      w8, #1
0068903E4  strb     w8, [x21, #0x45f]
0068903E8  adrp     x8, #0x8f25000
0068903EC  ldr      x8, [x8, #0x678]
0068903F0  ldr      x2, [x8]
0068903F4  ldrb     w8, [x2, #0x53]
0068903F8  tbnz     w8, #5, #0x6890410
0068903FC  mov      x0, x19
006890400  str      x20, [x0, #0x28]!
006890404  mov      x1, x20
006890408  bl       #0x382bcb8 ; 
00689040C  b        #0x6890420 ; 
006890410  ldr      x8, [x2, #0x60]
006890414  mov      x0, x19
006890418  mov      x1, x20
00689041C  blr      x8
006890420  mov      x0, x19
006890424  mov      x1, xzr
006890428  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689042C  adrp     x21, #0x959c000
006890430  ldrb     w8, [x21, #0x460]
006890434  mov      w20, w0
006890438  cbnz     w8, #0x6890450
00689043C  adrp     x0, #0x8f25000
006890440  ldr      x0, [x0, #0x688]
006890444  bl       #0x382bd14 ; 
006890448  mov      w8, #1
00689044C  strb     w8, [x21, #0x460]
006890450  adrp     x8, #0x8f25000
006890454  ldr      x8, [x8, #0x688]
006890458  ldr      x2, [x8]
00689045C  ldrb     w8, [x2, #0x53]
006890460  tbnz     w8, #5, #0x689046c
006890464  str      w20, [x19, #0x30]
006890468  b        #0x689047c ; 
00689046C  ldr      x8, [x2, #0x60]
006890470  mov      x0, x19
006890474  mov      w1, w20
006890478  blr      x8
00689047C  mov      x0, x19
006890480  mov      x1, xzr
006890484  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006890488  adrp     x21, #0x959c000
00689048C  ldrb     w8, [x21, #0x461]
006890490  mov      x20, x0
006890494  cbnz     w8, #0x68904ac
006890498  adrp     x0, #0x8f25000
00689049C  ldr      x0, [x0, #0x698]
0068904A0  bl       #0x382bd14 ; 
0068904A4  mov      w8, #1
0068904A8  strb     w8, [x21, #0x461]
0068904AC  adrp     x8, #0x8f25000
0068904B0  ldr      x8, [x8, #0x698]
0068904B4  ldr      x2, [x8]
0068904B8  ldrb     w8, [x2, #0x53]
0068904BC  tbnz     w8, #5, #0x68904d4
0068904C0  mov      x0, x19
0068904C4  str      x20, [x0, #0x38]!
0068904C8  mov      x1, x20
0068904CC  bl       #0x382bcb8 ; 
0068904D0  b        #0x68904e4 ; 
0068904D4  ldr      x8, [x2, #0x60]
0068904D8  mov      x0, x19
0068904DC  mov      x1, x20
0068904E0  blr      x8
0068904E4  mov      x0, x19
0068904E8  mov      x1, xzr
0068904EC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068904F0  adrp     x21, #0x959c000
0068904F4  ldrb     w8, [x21, #0x462]
0068904F8  mov      x20, x0
0068904FC  cbnz     w8, #0x6890514
006890500  adrp     x0, #0x8f25000
006890504  ldr      x0, [x0, #0x6a8]
006890508  bl       #0x382bd14 ; 
00689050C  mov      w8, #1
006890510  strb     w8, [x21, #0x462]
006890514  adrp     x8, #0x8f25000
006890518  ldr      x8, [x8, #0x6a8]
00689051C  ldr      x2, [x8]
006890520  ldrb     w8, [x2, #0x53]
006890524  tbnz     w8, #5, #0x689053c
006890528  mov      x0, x19
00689052C  str      x20, [x0, #0x40]!
006890530  mov      x1, x20
006890534  bl       #0x382bcb8 ; 
006890538  b        #0x689054c ; 
00689053C  ldr      x8, [x2, #0x60]
006890540  mov      x0, x19
006890544  mov      x1, x20
006890548  blr      x8
00689054C  mov      x0, x19
006890550  mov      x1, xzr
006890554  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006890558  adrp     x20, #0x959c000
00689055C  ldrb     w8, [x20, #0x463]
006890560  mov      v8.16b, v0.16b
006890564  cbnz     w8, #0x689057c
006890568  adrp     x0, #0x8f25000
00689056C  ldr      x0, [x0, #0x6b8]
006890570  bl       #0x382bd14 ; 
006890574  mov      w8, #1
006890578  strb     w8, [x20, #0x463]
00689057C  adrp     x8, #0x8f25000
006890580  ldr      x8, [x8, #0x6b8]
006890584  ldr      x1, [x8]
006890588  ldrb     w8, [x1, #0x53]
00689058C  tbnz     w8, #5, #0x6890598
006890590  str      s8, [x19, #0x48]
006890594  b        #0x68905a8 ; 
006890598  ldr      x8, [x1, #0x60]
00689059C  mov      x0, x19
0068905A0  mov      v0.16b, v8.16b
0068905A4  blr      x8
0068905A8  mov      x0, x19
0068905AC  mov      x1, xzr
0068905B0  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
0068905B4  adrp     x21, #0x959c000
0068905B8  ldrb     w8, [x21, #0x464]
0068905BC  mov      x20, x0
0068905C0  cbnz     w8, #0x68905d8
0068905C4  adrp     x0, #0x8f25000
0068905C8  ldr      x0, [x0, #0x6c8]
0068905CC  bl       #0x382bd14 ; 
0068905D0  mov      w8, #1
0068905D4  strb     w8, [x21, #0x464]
0068905D8  adrp     x8, #0x8f25000
0068905DC  ldr      x8, [x8, #0x6c8]
0068905E0  ldr      x2, [x8]
0068905E4  ldrb     w8, [x2, #0x53]
0068905E8  tbnz     w8, #5, #0x6890600
0068905EC  mov      x0, x19
0068905F0  str      x20, [x0, #0x50]!
0068905F4  mov      x1, x20
0068905F8  bl       #0x382bcb8 ; 
0068905FC  b        #0x6890610 ; 
006890600  ldr      x8, [x2, #0x60]
006890604  mov      x0, x19
006890608  mov      x1, x20
00689060C  blr      x8
006890610  mov      x0, x19
006890614  mov      x1, xzr
006890618  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
00689061C  adrp     x21, #0x959c000
006890620  ldrb     w8, [x21, #0x465]
006890624  mov      x20, x0
006890628  cbnz     w8, #0x6890640
00689062C  adrp     x0, #0x8f25000
006890630  ldr      x0, [x0, #0x6d8]
006890634  bl       #0x382bd14 ; 
006890638  mov      w8, #1
00689063C  strb     w8, [x21, #0x465]
006890640  adrp     x8, #0x8f25000
006890644  ldr      x8, [x8, #0x6d8]
006890648  ldr      x2, [x8]
00689064C  ldrb     w8, [x2, #0x53]
006890650  tbnz     w8, #5, #0x6890668
006890654  str      x20, [x19, #0x58]!
006890658  mov      x0, x19
00689065C  mov      x1, x20
006890660  bl       #0x382bcb8 ; 
006890664  b        #0x6890678 ; 
006890668  ldr      x8, [x2, #0x60]
00689066C  mov      x0, x19
006890670  mov      x1, x20
006890674  blr      x8
006890678  ldp      x20, x19, [sp, #0x20]
00689067C  ldp      x30, x21, [sp, #0x10]
006890680  mov      w0, #1
006890684  ldr      d8, [sp], #0x30
006890688  ret      

