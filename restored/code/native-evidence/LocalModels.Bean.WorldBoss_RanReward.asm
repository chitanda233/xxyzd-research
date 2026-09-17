; LocalModels.Bean.WorldBoss_RanReward$$readImpl
; RVA 0x6B2465C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B2465C  stp      x30, x21, [sp, #-0x20]!
006B24660  stp      x20, x19, [sp, #0x10]
006B24664  adrp     x20, #0x959f000
006B24668  adrp     x21, #0x8f3f000
006B2466C  ldrb     w8, [x20, #0x749]
006B24670  ldr      x21, [x21, #0xaa8]
006B24674  mov      x19, x0
006B24678  tbnz     w8, #0, #0x6b24690
006B2467C  adrp     x0, #0x8f3f000
006B24680  ldr      x0, [x0, #0xaa8]
006B24684  bl       #0x382bd14 ; 
006B24688  mov      w8, #1
006B2468C  strb     w8, [x20, #0x749]
006B24690  ldr      x1, [x21]
006B24694  ldrb     w8, [x1, #0x53]
006B24698  tbnz     w8, #5, #0x6b246e8
006B2469C  mov      x0, x19
006B246A0  mov      x1, xzr
006B246A4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B246A8  adrp     x21, #0x959f000
006B246AC  ldrb     w8, [x21, #0xa80]
006B246B0  mov      w20, w0
006B246B4  cbnz     w8, #0x6b246cc
006B246B8  adrp     x0, #0x8f3f000
006B246BC  ldr      x0, [x0, #0xa40]
006B246C0  bl       #0x382bd14 ; 
006B246C4  mov      w8, #1
006B246C8  strb     w8, [x21, #0xa80]
006B246CC  adrp     x8, #0x8f3f000
006B246D0  ldr      x8, [x8, #0xa40]
006B246D4  ldr      x2, [x8]
006B246D8  ldrb     w8, [x2, #0x53]
006B246DC  tbnz     w8, #5, #0x6b246fc
006B246E0  str      w20, [x19, #0x20]
006B246E4  b        #0x6b2470c ; 
006B246E8  ldr      x2, [x1, #0x60]
006B246EC  mov      x0, x19
006B246F0  ldp      x20, x19, [sp, #0x10]
006B246F4  ldp      x30, x21, [sp], #0x20
006B246F8  br       x2
006B246FC  ldr      x8, [x2, #0x60]
006B24700  mov      x0, x19
006B24704  mov      w1, w20
006B24708  blr      x8
006B2470C  mov      x0, x19
006B24710  mov      x1, xzr
006B24714  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B24718  adrp     x21, #0x959f000
006B2471C  ldrb     w8, [x21, #0xa81]
006B24720  mov      w20, w0
006B24724  cbnz     w8, #0x6b2473c
006B24728  adrp     x0, #0x8f3f000
006B2472C  ldr      x0, [x0, #0xa50]
006B24730  bl       #0x382bd14 ; 
006B24734  mov      w8, #1
006B24738  strb     w8, [x21, #0xa81]
006B2473C  adrp     x8, #0x8f3f000
006B24740  ldr      x8, [x8, #0xa50]
006B24744  ldr      x2, [x8]
006B24748  ldrb     w8, [x2, #0x53]
006B2474C  tbnz     w8, #5, #0x6b24758
006B24750  str      w20, [x19, #0x24]
006B24754  b        #0x6b24768 ; 
006B24758  ldr      x8, [x2, #0x60]
006B2475C  mov      x0, x19
006B24760  mov      w1, w20
006B24764  blr      x8
006B24768  mov      x0, x19
006B2476C  mov      x1, xzr
006B24770  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B24774  adrp     x21, #0x959f000
006B24778  ldrb     w8, [x21, #0xa82]
006B2477C  mov      w20, w0
006B24780  cbnz     w8, #0x6b24798
006B24784  adrp     x0, #0x8f3f000
006B24788  ldr      x0, [x0, #0xa60]
006B2478C  bl       #0x382bd14 ; 
006B24790  mov      w8, #1
006B24794  strb     w8, [x21, #0xa82]
006B24798  adrp     x8, #0x8f3f000
006B2479C  ldr      x8, [x8, #0xa60]
006B247A0  ldr      x2, [x8]
006B247A4  ldrb     w8, [x2, #0x53]
006B247A8  tbnz     w8, #5, #0x6b247b4
006B247AC  str      w20, [x19, #0x28]
006B247B0  b        #0x6b247c4 ; 
006B247B4  ldr      x8, [x2, #0x60]
006B247B8  mov      x0, x19
006B247BC  mov      w1, w20
006B247C0  blr      x8
006B247C4  mov      x0, x19
006B247C8  mov      x1, xzr
006B247CC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B247D0  adrp     x21, #0x959f000
006B247D4  ldrb     w8, [x21, #0xa83]
006B247D8  mov      x20, x0
006B247DC  cbnz     w8, #0x6b247f4
006B247E0  adrp     x0, #0x8f3f000
006B247E4  ldr      x0, [x0, #0xa70]
006B247E8  bl       #0x382bd14 ; 
006B247EC  mov      w8, #1
006B247F0  strb     w8, [x21, #0xa83]
006B247F4  adrp     x8, #0x8f3f000
006B247F8  ldr      x8, [x8, #0xa70]
006B247FC  ldr      x2, [x8]
006B24800  ldrb     w8, [x2, #0x53]
006B24804  tbnz     w8, #5, #0x6b2481c
006B24808  mov      x0, x19
006B2480C  str      x20, [x0, #0x30]!
006B24810  mov      x1, x20
006B24814  bl       #0x382bcb8 ; 
006B24818  b        #0x6b2482c ; 
006B2481C  ldr      x8, [x2, #0x60]
006B24820  mov      x0, x19
006B24824  mov      x1, x20
006B24828  blr      x8
006B2482C  mov      x0, x19
006B24830  mov      x1, xzr
006B24834  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B24838  adrp     x21, #0x959f000
006B2483C  ldrb     w8, [x21, #0xa84]
006B24840  mov      w20, w0
006B24844  cbnz     w8, #0x6b2485c
006B24848  adrp     x0, #0x8f3f000
006B2484C  ldr      x0, [x0, #0xa80]
006B24850  bl       #0x382bd14 ; 
006B24854  mov      w8, #1
006B24858  strb     w8, [x21, #0xa84]
006B2485C  adrp     x8, #0x8f3f000
006B24860  ldr      x8, [x8, #0xa80]
006B24864  ldr      x2, [x8]
006B24868  ldrb     w8, [x2, #0x53]
006B2486C  tbnz     w8, #5, #0x6b24878
006B24870  str      w20, [x19, #0x38]
006B24874  b        #0x6b24888 ; 
006B24878  ldr      x8, [x2, #0x60]
006B2487C  mov      x0, x19
006B24880  mov      w1, w20
006B24884  blr      x8
006B24888  mov      x0, x19
006B2488C  mov      x1, xzr
006B24890  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B24894  adrp     x21, #0x959f000
006B24898  ldrb     w8, [x21, #0xa85]
006B2489C  mov      w20, w0
006B248A0  cbnz     w8, #0x6b248b8
006B248A4  adrp     x0, #0x8f3f000
006B248A8  ldr      x0, [x0, #0xa90]
006B248AC  bl       #0x382bd14 ; 
006B248B0  mov      w8, #1
006B248B4  strb     w8, [x21, #0xa85]
006B248B8  adrp     x8, #0x8f3f000
006B248BC  ldr      x8, [x8, #0xa90]
006B248C0  ldr      x2, [x8]
006B248C4  ldrb     w8, [x2, #0x53]
006B248C8  tbnz     w8, #5, #0x6b248d4
006B248CC  str      w20, [x19, #0x3c]
006B248D0  b        #0x6b248e4 ; 
006B248D4  ldr      x8, [x2, #0x60]
006B248D8  mov      x0, x19
006B248DC  mov      w1, w20
006B248E0  blr      x8
006B248E4  mov      x0, x19
006B248E8  mov      x1, xzr
006B248EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B248F0  adrp     x21, #0x959f000
006B248F4  ldrb     w8, [x21, #0xa86]
006B248F8  mov      w20, w0
006B248FC  cbnz     w8, #0x6b24914
006B24900  adrp     x0, #0x8f3f000
006B24904  ldr      x0, [x0, #0xaa0]
006B24908  bl       #0x382bd14 ; 
006B2490C  mov      w8, #1
006B24910  strb     w8, [x21, #0xa86]
006B24914  adrp     x8, #0x8f3f000
006B24918  ldr      x8, [x8, #0xaa0]
006B2491C  ldr      x2, [x8]
006B24920  ldrb     w8, [x2, #0x53]
006B24924  tbnz     w8, #5, #0x6b24930
006B24928  str      w20, [x19, #0x40]
006B2492C  b        #0x6b24940 ; 
006B24930  ldr      x8, [x2, #0x60]
006B24934  mov      x0, x19
006B24938  mov      w1, w20
006B2493C  blr      x8
006B24940  ldp      x20, x19, [sp, #0x10]
006B24944  mov      w0, #1
006B24948  ldp      x30, x21, [sp], #0x20
006B2494C  ret      

