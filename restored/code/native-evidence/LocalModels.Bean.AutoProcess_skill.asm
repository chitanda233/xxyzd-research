; LocalModels.Bean.AutoProcess_skill$$readImpl
; RVA 0x68835F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068835F4  stp      x30, x21, [sp, #-0x20]!
0068835F8  stp      x20, x19, [sp, #0x10]
0068835FC  adrp     x20, #0x959b000
006883600  adrp     x21, #0x8f24000
006883604  ldrb     w8, [x20, #0xbcf]
006883608  ldr      x21, [x21, #0xe18]
00688360C  mov      x19, x0
006883610  tbnz     w8, #0, #0x6883628
006883614  adrp     x0, #0x8f24000
006883618  ldr      x0, [x0, #0xe18]
00688361C  bl       #0x382bd14 ; 
006883620  mov      w8, #1
006883624  strb     w8, [x20, #0xbcf]
006883628  ldr      x1, [x21]
00688362C  ldrb     w8, [x1, #0x53]
006883630  tbnz     w8, #5, #0x6883680
006883634  mov      x0, x19
006883638  mov      x1, xzr
00688363C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006883640  adrp     x21, #0x959c000
006883644  ldrb     w8, [x21, #0x3d0]
006883648  mov      w20, w0
00688364C  cbnz     w8, #0x6883664
006883650  adrp     x0, #0x8f24000
006883654  ldr      x0, [x0, #0xdd0]
006883658  bl       #0x382bd14 ; 
00688365C  mov      w8, #1
006883660  strb     w8, [x21, #0x3d0]
006883664  adrp     x8, #0x8f24000
006883668  ldr      x8, [x8, #0xdd0]
00688366C  ldr      x2, [x8]
006883670  ldrb     w8, [x2, #0x53]
006883674  tbnz     w8, #5, #0x6883694
006883678  str      w20, [x19, #0x20]
00688367C  b        #0x68836a4 ; 
006883680  ldr      x2, [x1, #0x60]
006883684  mov      x0, x19
006883688  ldp      x20, x19, [sp, #0x10]
00688368C  ldp      x30, x21, [sp], #0x20
006883690  br       x2
006883694  ldr      x8, [x2, #0x60]
006883698  mov      x0, x19
00688369C  mov      w1, w20
0068836A0  blr      x8
0068836A4  mov      x0, x19
0068836A8  mov      x1, xzr
0068836AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068836B0  adrp     x21, #0x959c000
0068836B4  ldrb     w8, [x21, #0x3d1]
0068836B8  mov      w20, w0
0068836BC  cbnz     w8, #0x68836d4
0068836C0  adrp     x0, #0x8f24000
0068836C4  ldr      x0, [x0, #0xde0]
0068836C8  bl       #0x382bd14 ; 
0068836CC  mov      w8, #1
0068836D0  strb     w8, [x21, #0x3d1]
0068836D4  adrp     x8, #0x8f24000
0068836D8  ldr      x8, [x8, #0xde0]
0068836DC  ldr      x2, [x8]
0068836E0  ldrb     w8, [x2, #0x53]
0068836E4  tbnz     w8, #5, #0x68836f0
0068836E8  str      w20, [x19, #0x24]
0068836EC  b        #0x6883700 ; 
0068836F0  ldr      x8, [x2, #0x60]
0068836F4  mov      x0, x19
0068836F8  mov      w1, w20
0068836FC  blr      x8
006883700  mov      x0, x19
006883704  mov      x1, xzr
006883708  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688370C  adrp     x21, #0x959c000
006883710  ldrb     w8, [x21, #0x3d2]
006883714  mov      w20, w0
006883718  cbnz     w8, #0x6883730
00688371C  adrp     x0, #0x8f24000
006883720  ldr      x0, [x0, #0xdf0]
006883724  bl       #0x382bd14 ; 
006883728  mov      w8, #1
00688372C  strb     w8, [x21, #0x3d2]
006883730  adrp     x8, #0x8f24000
006883734  ldr      x8, [x8, #0xdf0]
006883738  ldr      x2, [x8]
00688373C  ldrb     w8, [x2, #0x53]
006883740  tbnz     w8, #5, #0x688374c
006883744  str      w20, [x19, #0x28]
006883748  b        #0x688375c ; 
00688374C  ldr      x8, [x2, #0x60]
006883750  mov      x0, x19
006883754  mov      w1, w20
006883758  blr      x8
00688375C  mov      x0, x19
006883760  mov      x1, xzr
006883764  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006883768  adrp     x21, #0x959c000
00688376C  ldrb     w8, [x21, #0x3d3]
006883770  mov      w20, w0
006883774  cbnz     w8, #0x688378c
006883778  adrp     x0, #0x8f24000
00688377C  ldr      x0, [x0, #0xe00]
006883780  bl       #0x382bd14 ; 
006883784  mov      w8, #1
006883788  strb     w8, [x21, #0x3d3]
00688378C  adrp     x8, #0x8f24000
006883790  ldr      x8, [x8, #0xe00]
006883794  ldr      x2, [x8]
006883798  ldrb     w8, [x2, #0x53]
00688379C  tbnz     w8, #5, #0x68837a8
0068837A0  str      w20, [x19, #0x2c]
0068837A4  b        #0x68837b8 ; 
0068837A8  ldr      x8, [x2, #0x60]
0068837AC  mov      x0, x19
0068837B0  mov      w1, w20
0068837B4  blr      x8
0068837B8  mov      x0, x19
0068837BC  mov      x1, xzr
0068837C0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068837C4  adrp     x21, #0x959c000
0068837C8  ldrb     w8, [x21, #0x3d4]
0068837CC  mov      x20, x0
0068837D0  cbnz     w8, #0x68837e8
0068837D4  adrp     x0, #0x8f24000
0068837D8  ldr      x0, [x0, #0xe10]
0068837DC  bl       #0x382bd14 ; 
0068837E0  mov      w8, #1
0068837E4  strb     w8, [x21, #0x3d4]
0068837E8  adrp     x8, #0x8f24000
0068837EC  ldr      x8, [x8, #0xe10]
0068837F0  ldr      x2, [x8]
0068837F4  ldrb     w8, [x2, #0x53]
0068837F8  tbnz     w8, #5, #0x6883810
0068837FC  str      x20, [x19, #0x30]!
006883800  mov      x0, x19
006883804  mov      x1, x20
006883808  bl       #0x382bcb8 ; 
00688380C  b        #0x6883820 ; 
006883810  ldr      x8, [x2, #0x60]
006883814  mov      x0, x19
006883818  mov      x1, x20
00688381C  blr      x8
006883820  ldp      x20, x19, [sp, #0x10]
006883824  mov      w0, #1
006883828  ldp      x30, x21, [sp], #0x20
00688382C  ret      

