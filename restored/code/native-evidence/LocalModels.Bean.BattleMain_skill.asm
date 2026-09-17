; LocalModels.Bean.BattleMain_skill$$readImpl
; RVA 0x68845D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068845D8  stp      x30, x21, [sp, #-0x20]!
0068845DC  stp      x20, x19, [sp, #0x10]
0068845E0  adrp     x20, #0x959b000
0068845E4  adrp     x21, #0x8f24000
0068845E8  ldrb     w8, [x20, #0xbea]
0068845EC  ldr      x21, [x21, #0xed8]
0068845F0  mov      x19, x0
0068845F4  tbnz     w8, #0, #0x688460c
0068845F8  adrp     x0, #0x8f24000
0068845FC  ldr      x0, [x0, #0xed8]
006884600  bl       #0x382bd14 ; 
006884604  mov      w8, #1
006884608  strb     w8, [x20, #0xbea]
00688460C  ldr      x1, [x21]
006884610  ldrb     w8, [x1, #0x53]
006884614  tbnz     w8, #5, #0x6884664
006884618  mov      x0, x19
00688461C  mov      x1, xzr
006884620  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006884624  adrp     x21, #0x959c000
006884628  ldrb     w8, [x21, #0x3da]
00688462C  mov      w20, w0
006884630  cbnz     w8, #0x6884648
006884634  adrp     x0, #0x8f24000
006884638  ldr      x0, [x0, #0xea0]
00688463C  bl       #0x382bd14 ; 
006884640  mov      w8, #1
006884644  strb     w8, [x21, #0x3da]
006884648  adrp     x8, #0x8f24000
00688464C  ldr      x8, [x8, #0xea0]
006884650  ldr      x2, [x8]
006884654  ldrb     w8, [x2, #0x53]
006884658  tbnz     w8, #5, #0x6884678
00688465C  str      w20, [x19, #0x20]
006884660  b        #0x6884688 ; 
006884664  ldr      x2, [x1, #0x60]
006884668  mov      x0, x19
00688466C  ldp      x20, x19, [sp, #0x10]
006884670  ldp      x30, x21, [sp], #0x20
006884674  br       x2
006884678  ldr      x8, [x2, #0x60]
00688467C  mov      x0, x19
006884680  mov      w1, w20
006884684  blr      x8
006884688  mov      x0, x19
00688468C  mov      x1, xzr
006884690  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006884694  adrp     x21, #0x959c000
006884698  ldrb     w8, [x21, #0x3db]
00688469C  mov      w20, w0
0068846A0  cbnz     w8, #0x68846b8
0068846A4  adrp     x0, #0x8f24000
0068846A8  ldr      x0, [x0, #0xeb0]
0068846AC  bl       #0x382bd14 ; 
0068846B0  mov      w8, #1
0068846B4  strb     w8, [x21, #0x3db]
0068846B8  adrp     x8, #0x8f24000
0068846BC  ldr      x8, [x8, #0xeb0]
0068846C0  ldr      x2, [x8]
0068846C4  ldrb     w8, [x2, #0x53]
0068846C8  tbnz     w8, #5, #0x68846d4
0068846CC  str      w20, [x19, #0x24]
0068846D0  b        #0x68846e4 ; 
0068846D4  ldr      x8, [x2, #0x60]
0068846D8  mov      x0, x19
0068846DC  mov      w1, w20
0068846E0  blr      x8
0068846E4  mov      x0, x19
0068846E8  mov      x1, xzr
0068846EC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068846F0  adrp     x21, #0x959c000
0068846F4  ldrb     w8, [x21, #0x3dc]
0068846F8  mov      x20, x0
0068846FC  cbnz     w8, #0x6884714
006884700  adrp     x0, #0x8f24000
006884704  ldr      x0, [x0, #0xec0]
006884708  bl       #0x382bd14 ; 
00688470C  mov      w8, #1
006884710  strb     w8, [x21, #0x3dc]
006884714  adrp     x8, #0x8f24000
006884718  ldr      x8, [x8, #0xec0]
00688471C  ldr      x2, [x8]
006884720  ldrb     w8, [x2, #0x53]
006884724  tbnz     w8, #5, #0x688473c
006884728  mov      x0, x19
00688472C  str      x20, [x0, #0x28]!
006884730  mov      x1, x20
006884734  bl       #0x382bcb8 ; 
006884738  b        #0x688474c ; 
00688473C  ldr      x8, [x2, #0x60]
006884740  mov      x0, x19
006884744  mov      x1, x20
006884748  blr      x8
00688474C  mov      x0, x19
006884750  mov      x1, xzr
006884754  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006884758  adrp     x21, #0x959c000
00688475C  ldrb     w8, [x21, #0x3dd]
006884760  mov      w20, w0
006884764  cbnz     w8, #0x688477c
006884768  adrp     x0, #0x8f24000
00688476C  ldr      x0, [x0, #0xed0]
006884770  bl       #0x382bd14 ; 
006884774  mov      w8, #1
006884778  strb     w8, [x21, #0x3dd]
00688477C  adrp     x8, #0x8f24000
006884780  ldr      x8, [x8, #0xed0]
006884784  ldr      x2, [x8]
006884788  ldrb     w8, [x2, #0x53]
00688478C  tbnz     w8, #5, #0x6884798
006884790  str      w20, [x19, #0x30]
006884794  b        #0x68847a8 ; 
006884798  ldr      x8, [x2, #0x60]
00688479C  mov      x0, x19
0068847A0  mov      w1, w20
0068847A4  blr      x8
0068847A8  ldp      x20, x19, [sp, #0x10]
0068847AC  mov      w0, #1
0068847B0  ldp      x30, x21, [sp], #0x20
0068847B4  ret      

