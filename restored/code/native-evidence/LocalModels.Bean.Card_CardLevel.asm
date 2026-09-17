; LocalModels.Bean.Card_CardLevel$$readImpl
; RVA 0x68956B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068956B8  stp      x30, x21, [sp, #-0x20]!
0068956BC  stp      x20, x19, [sp, #0x10]
0068956C0  adrp     x20, #0x959b000
0068956C4  adrp     x21, #0x8f25000
0068956C8  ldrb     w8, [x20, #0xda8]
0068956CC  ldr      x21, [x21, #0xaf0]
0068956D0  mov      x19, x0
0068956D4  tbnz     w8, #0, #0x68956ec
0068956D8  adrp     x0, #0x8f25000
0068956DC  ldr      x0, [x0, #0xaf0]
0068956E0  bl       #0x382bd14 ; 
0068956E4  mov      w8, #1
0068956E8  strb     w8, [x20, #0xda8]
0068956EC  ldr      x1, [x21]
0068956F0  ldrb     w8, [x1, #0x53]
0068956F4  tbnz     w8, #5, #0x6895744
0068956F8  mov      x0, x19
0068956FC  mov      x1, xzr
006895700  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006895704  adrp     x21, #0x959c000
006895708  ldrb     w8, [x21, #0x499]
00689570C  mov      w20, w0
006895710  cbnz     w8, #0x6895728
006895714  adrp     x0, #0x8f25000
006895718  ldr      x0, [x0, #0xa98]
00689571C  bl       #0x382bd14 ; 
006895720  mov      w8, #1
006895724  strb     w8, [x21, #0x499]
006895728  adrp     x8, #0x8f25000
00689572C  ldr      x8, [x8, #0xa98]
006895730  ldr      x2, [x8]
006895734  ldrb     w8, [x2, #0x53]
006895738  tbnz     w8, #5, #0x6895758
00689573C  str      w20, [x19, #0x20]
006895740  b        #0x6895768 ; 
006895744  ldr      x2, [x1, #0x60]
006895748  mov      x0, x19
00689574C  ldp      x20, x19, [sp, #0x10]
006895750  ldp      x30, x21, [sp], #0x20
006895754  br       x2
006895758  ldr      x8, [x2, #0x60]
00689575C  mov      x0, x19
006895760  mov      w1, w20
006895764  blr      x8
006895768  mov      x0, x19
00689576C  mov      x1, xzr
006895770  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006895774  adrp     x21, #0x959c000
006895778  ldrb     w8, [x21, #0x49a]
00689577C  mov      w20, w0
006895780  cbnz     w8, #0x6895798
006895784  adrp     x0, #0x8f25000
006895788  ldr      x0, [x0, #0xaa8]
00689578C  bl       #0x382bd14 ; 
006895790  mov      w8, #1
006895794  strb     w8, [x21, #0x49a]
006895798  adrp     x8, #0x8f25000
00689579C  ldr      x8, [x8, #0xaa8]
0068957A0  ldr      x2, [x8]
0068957A4  ldrb     w8, [x2, #0x53]
0068957A8  tbnz     w8, #5, #0x68957b4
0068957AC  str      w20, [x19, #0x24]
0068957B0  b        #0x68957c4 ; 
0068957B4  ldr      x8, [x2, #0x60]
0068957B8  mov      x0, x19
0068957BC  mov      w1, w20
0068957C0  blr      x8
0068957C4  mov      x0, x19
0068957C8  mov      x1, xzr
0068957CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068957D0  adrp     x21, #0x959c000
0068957D4  ldrb     w8, [x21, #0x49b]
0068957D8  mov      w20, w0
0068957DC  cbnz     w8, #0x68957f4
0068957E0  adrp     x0, #0x8f25000
0068957E4  ldr      x0, [x0, #0xab8]
0068957E8  bl       #0x382bd14 ; 
0068957EC  mov      w8, #1
0068957F0  strb     w8, [x21, #0x49b]
0068957F4  adrp     x8, #0x8f25000
0068957F8  ldr      x8, [x8, #0xab8]
0068957FC  ldr      x2, [x8]
006895800  ldrb     w8, [x2, #0x53]
006895804  tbnz     w8, #5, #0x6895810
006895808  str      w20, [x19, #0x28]
00689580C  b        #0x6895820 ; 
006895810  ldr      x8, [x2, #0x60]
006895814  mov      x0, x19
006895818  mov      w1, w20
00689581C  blr      x8
006895820  mov      x0, x19
006895824  mov      x1, xzr
006895828  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
00689582C  adrp     x21, #0x959c000
006895830  ldrb     w8, [x21, #0x49c]
006895834  mov      x20, x0
006895838  cbnz     w8, #0x6895850
00689583C  adrp     x0, #0x8f25000
006895840  ldr      x0, [x0, #0xac8]
006895844  bl       #0x382bd14 ; 
006895848  mov      w8, #1
00689584C  strb     w8, [x21, #0x49c]
006895850  adrp     x8, #0x8f25000
006895854  ldr      x8, [x8, #0xac8]
006895858  ldr      x2, [x8]
00689585C  ldrb     w8, [x2, #0x53]
006895860  tbnz     w8, #5, #0x6895878
006895864  mov      x0, x19
006895868  str      x20, [x0, #0x30]!
00689586C  mov      x1, x20
006895870  bl       #0x382bcb8 ; 
006895874  b        #0x6895888 ; 
006895878  ldr      x8, [x2, #0x60]
00689587C  mov      x0, x19
006895880  mov      x1, x20
006895884  blr      x8
006895888  mov      x0, x19
00689588C  mov      x1, xzr
006895890  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006895894  adrp     x21, #0x959c000
006895898  ldrb     w8, [x21, #0x49d]
00689589C  mov      x20, x0
0068958A0  cbnz     w8, #0x68958b8
0068958A4  adrp     x0, #0x8f25000
0068958A8  ldr      x0, [x0, #0xad8]
0068958AC  bl       #0x382bd14 ; 
0068958B0  mov      w8, #1
0068958B4  strb     w8, [x21, #0x49d]
0068958B8  adrp     x8, #0x8f25000
0068958BC  ldr      x8, [x8, #0xad8]
0068958C0  ldr      x2, [x8]
0068958C4  ldrb     w8, [x2, #0x53]
0068958C8  tbnz     w8, #5, #0x68958e0
0068958CC  mov      x0, x19
0068958D0  str      x20, [x0, #0x38]!
0068958D4  mov      x1, x20
0068958D8  bl       #0x382bcb8 ; 
0068958DC  b        #0x68958f0 ; 
0068958E0  ldr      x8, [x2, #0x60]
0068958E4  mov      x0, x19
0068958E8  mov      x1, x20
0068958EC  blr      x8
0068958F0  mov      x0, x19
0068958F4  mov      x1, xzr
0068958F8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068958FC  adrp     x21, #0x959c000
006895900  ldrb     w8, [x21, #0x49e]
006895904  mov      x20, x0
006895908  cbnz     w8, #0x6895920
00689590C  adrp     x0, #0x8f25000
006895910  ldr      x0, [x0, #0xae8]
006895914  bl       #0x382bd14 ; 
006895918  mov      w8, #1
00689591C  strb     w8, [x21, #0x49e]
006895920  adrp     x8, #0x8f25000
006895924  ldr      x8, [x8, #0xae8]
006895928  ldr      x2, [x8]
00689592C  ldrb     w8, [x2, #0x53]
006895930  tbnz     w8, #5, #0x6895948
006895934  str      x20, [x19, #0x40]!
006895938  mov      x0, x19
00689593C  mov      x1, x20
006895940  bl       #0x382bcb8 ; 
006895944  b        #0x6895958 ; 
006895948  ldr      x8, [x2, #0x60]
00689594C  mov      x0, x19
006895950  mov      x1, x20
006895954  blr      x8
006895958  ldp      x20, x19, [sp, #0x10]
00689595C  mov      w0, #1
006895960  ldp      x30, x21, [sp], #0x20
006895964  ret      

