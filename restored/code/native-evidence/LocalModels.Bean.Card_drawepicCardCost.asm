; LocalModels.Bean.Card_drawepicCardCost$$readImpl
; RVA 0x6896674; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006896674  stp      x30, x21, [sp, #-0x20]!
006896678  stp      x20, x19, [sp, #0x10]
00689667C  adrp     x20, #0x959b000
006896680  adrp     x21, #0x8f25000
006896684  ldrb     w8, [x20, #0xdc2]
006896688  ldr      x21, [x21, #0xbb0]
00689668C  mov      x19, x0
006896690  tbnz     w8, #0, #0x68966a8
006896694  adrp     x0, #0x8f25000
006896698  ldr      x0, [x0, #0xbb0]
00689669C  bl       #0x382bd14 ; 
0068966A0  mov      w8, #1
0068966A4  strb     w8, [x20, #0xdc2]
0068966A8  ldr      x1, [x21]
0068966AC  ldrb     w8, [x1, #0x53]
0068966B0  tbnz     w8, #5, #0x6896700
0068966B4  mov      x0, x19
0068966B8  mov      x1, xzr
0068966BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068966C0  adrp     x21, #0x959c000
0068966C4  ldrb     w8, [x21, #0x4a4]
0068966C8  mov      w20, w0
0068966CC  cbnz     w8, #0x68966e4
0068966D0  adrp     x0, #0x8f25000
0068966D4  ldr      x0, [x0, #0xb68]
0068966D8  bl       #0x382bd14 ; 
0068966DC  mov      w8, #1
0068966E0  strb     w8, [x21, #0x4a4]
0068966E4  adrp     x8, #0x8f25000
0068966E8  ldr      x8, [x8, #0xb68]
0068966EC  ldr      x2, [x8]
0068966F0  ldrb     w8, [x2, #0x53]
0068966F4  tbnz     w8, #5, #0x6896714
0068966F8  str      w20, [x19, #0x20]
0068966FC  b        #0x6896724 ; 
006896700  ldr      x2, [x1, #0x60]
006896704  mov      x0, x19
006896708  ldp      x20, x19, [sp, #0x10]
00689670C  ldp      x30, x21, [sp], #0x20
006896710  br       x2
006896714  ldr      x8, [x2, #0x60]
006896718  mov      x0, x19
00689671C  mov      w1, w20
006896720  blr      x8
006896724  mov      x0, x19
006896728  mov      x1, xzr
00689672C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006896730  adrp     x21, #0x959c000
006896734  ldrb     w8, [x21, #0x4a5]
006896738  mov      x20, x0
00689673C  cbnz     w8, #0x6896754
006896740  adrp     x0, #0x8f25000
006896744  ldr      x0, [x0, #0xb78]
006896748  bl       #0x382bd14 ; 
00689674C  mov      w8, #1
006896750  strb     w8, [x21, #0x4a5]
006896754  adrp     x8, #0x8f25000
006896758  ldr      x8, [x8, #0xb78]
00689675C  ldr      x2, [x8]
006896760  ldrb     w8, [x2, #0x53]
006896764  tbnz     w8, #5, #0x689677c
006896768  mov      x0, x19
00689676C  str      x20, [x0, #0x28]!
006896770  mov      x1, x20
006896774  bl       #0x382bcb8 ; 
006896778  b        #0x689678c ; 
00689677C  ldr      x8, [x2, #0x60]
006896780  mov      x0, x19
006896784  mov      x1, x20
006896788  blr      x8
00689678C  mov      x0, x19
006896790  mov      x1, xzr
006896794  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006896798  adrp     x21, #0x959c000
00689679C  ldrb     w8, [x21, #0x4a6]
0068967A0  mov      w20, w0
0068967A4  cbnz     w8, #0x68967bc
0068967A8  adrp     x0, #0x8f25000
0068967AC  ldr      x0, [x0, #0xb88]
0068967B0  bl       #0x382bd14 ; 
0068967B4  mov      w8, #1
0068967B8  strb     w8, [x21, #0x4a6]
0068967BC  adrp     x8, #0x8f25000
0068967C0  ldr      x8, [x8, #0xb88]
0068967C4  ldr      x2, [x8]
0068967C8  ldrb     w8, [x2, #0x53]
0068967CC  tbnz     w8, #5, #0x68967d8
0068967D0  str      w20, [x19, #0x30]
0068967D4  b        #0x68967e8 ; 
0068967D8  ldr      x8, [x2, #0x60]
0068967DC  mov      x0, x19
0068967E0  mov      w1, w20
0068967E4  blr      x8
0068967E8  mov      x0, x19
0068967EC  mov      x1, xzr
0068967F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068967F4  adrp     x21, #0x959c000
0068967F8  ldrb     w8, [x21, #0x4a7]
0068967FC  mov      w20, w0
006896800  cbnz     w8, #0x6896818
006896804  adrp     x0, #0x8f25000
006896808  ldr      x0, [x0, #0xb98]
00689680C  bl       #0x382bd14 ; 
006896810  mov      w8, #1
006896814  strb     w8, [x21, #0x4a7]
006896818  adrp     x8, #0x8f25000
00689681C  ldr      x8, [x8, #0xb98]
006896820  ldr      x2, [x8]
006896824  ldrb     w8, [x2, #0x53]
006896828  tbnz     w8, #5, #0x6896834
00689682C  str      w20, [x19, #0x34]
006896830  b        #0x6896844 ; 
006896834  ldr      x8, [x2, #0x60]
006896838  mov      x0, x19
00689683C  mov      w1, w20
006896840  blr      x8
006896844  mov      x0, x19
006896848  mov      x1, xzr
00689684C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006896850  adrp     x21, #0x959c000
006896854  ldrb     w8, [x21, #0x4a8]
006896858  mov      w20, w0
00689685C  cbnz     w8, #0x6896874
006896860  adrp     x0, #0x8f25000
006896864  ldr      x0, [x0, #0xba8]
006896868  bl       #0x382bd14 ; 
00689686C  mov      w8, #1
006896870  strb     w8, [x21, #0x4a8]
006896874  adrp     x8, #0x8f25000
006896878  ldr      x8, [x8, #0xba8]
00689687C  ldr      x2, [x8]
006896880  ldrb     w8, [x2, #0x53]
006896884  tbnz     w8, #5, #0x6896890
006896888  str      w20, [x19, #0x38]
00689688C  b        #0x68968a0 ; 
006896890  ldr      x8, [x2, #0x60]
006896894  mov      x0, x19
006896898  mov      w1, w20
00689689C  blr      x8
0068968A0  ldp      x20, x19, [sp, #0x10]
0068968A4  mov      w0, #1
0068968A8  ldp      x30, x21, [sp], #0x20
0068968AC  ret      

