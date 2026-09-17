; LocalModels.Bean.Atlas_atlas$$readImpl
; RVA 0x67015D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067015D4  stp      x30, x21, [sp, #-0x20]!
0067015D8  stp      x20, x19, [sp, #0x10]
0067015DC  adrp     x20, #0x959a000
0067015E0  adrp     x21, #0x8f17000
0067015E4  ldrb     w8, [x20, #0x8a2]
0067015E8  ldr      x21, [x21, #0x730]
0067015EC  mov      x19, x0
0067015F0  tbnz     w8, #0, #0x6701608
0067015F4  adrp     x0, #0x8f17000
0067015F8  ldr      x0, [x0, #0x730]
0067015FC  bl       #0x382bd14 ; 
006701600  mov      w8, #1
006701604  strb     w8, [x20, #0x8a2]
006701608  ldr      x1, [x21]
00670160C  ldrb     w8, [x1, #0x53]
006701610  tbnz     w8, #5, #0x6701660
006701614  mov      x0, x19
006701618  mov      x1, xzr
00670161C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006701620  adrp     x21, #0x959a000
006701624  ldrb     w8, [x21, #0x95d]
006701628  mov      w20, w0
00670162C  cbnz     w8, #0x6701644
006701630  adrp     x0, #0x8f17000
006701634  ldr      x0, [x0, #0x708]
006701638  bl       #0x382bd14 ; 
00670163C  mov      w8, #1
006701640  strb     w8, [x21, #0x95d]
006701644  adrp     x8, #0x8f17000
006701648  ldr      x8, [x8, #0x708]
00670164C  ldr      x2, [x8]
006701650  ldrb     w8, [x2, #0x53]
006701654  tbnz     w8, #5, #0x6701674
006701658  str      w20, [x19, #0x20]
00670165C  b        #0x6701684 ; 
006701660  ldr      x2, [x1, #0x60]
006701664  mov      x0, x19
006701668  ldp      x20, x19, [sp, #0x10]
00670166C  ldp      x30, x21, [sp], #0x20
006701670  br       x2
006701674  ldr      x8, [x2, #0x60]
006701678  mov      x0, x19
00670167C  mov      w1, w20
006701680  blr      x8
006701684  mov      x0, x19
006701688  mov      x1, xzr
00670168C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006701690  adrp     x21, #0x959a000
006701694  ldrb     w8, [x21, #0x95e]
006701698  mov      x20, x0
00670169C  cbnz     w8, #0x67016b4
0067016A0  adrp     x0, #0x8f17000
0067016A4  ldr      x0, [x0, #0x718]
0067016A8  bl       #0x382bd14 ; 
0067016AC  mov      w8, #1
0067016B0  strb     w8, [x21, #0x95e]
0067016B4  adrp     x8, #0x8f17000
0067016B8  ldr      x8, [x8, #0x718]
0067016BC  ldr      x2, [x8]
0067016C0  ldrb     w8, [x2, #0x53]
0067016C4  tbnz     w8, #5, #0x67016dc
0067016C8  mov      x0, x19
0067016CC  str      x20, [x0, #0x28]!
0067016D0  mov      x1, x20
0067016D4  bl       #0x382bcb8 ; 
0067016D8  b        #0x67016ec ; 
0067016DC  ldr      x8, [x2, #0x60]
0067016E0  mov      x0, x19
0067016E4  mov      x1, x20
0067016E8  blr      x8
0067016EC  mov      x0, x19
0067016F0  mov      x1, xzr
0067016F4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0067016F8  adrp     x21, #0x959a000
0067016FC  ldrb     w8, [x21, #0x95f]
006701700  mov      x20, x0
006701704  cbnz     w8, #0x670171c
006701708  adrp     x0, #0x8f17000
00670170C  ldr      x0, [x0, #0x728]
006701710  bl       #0x382bd14 ; 
006701714  mov      w8, #1
006701718  strb     w8, [x21, #0x95f]
00670171C  adrp     x8, #0x8f17000
006701720  ldr      x8, [x8, #0x728]
006701724  ldr      x2, [x8]
006701728  ldrb     w8, [x2, #0x53]
00670172C  tbnz     w8, #5, #0x6701744
006701730  str      x20, [x19, #0x30]!
006701734  mov      x0, x19
006701738  mov      x1, x20
00670173C  bl       #0x382bcb8 ; 
006701740  b        #0x6701754 ; 
006701744  ldr      x8, [x2, #0x60]
006701748  mov      x0, x19
00670174C  mov      x1, x20
006701750  blr      x8
006701754  ldp      x20, x19, [sp, #0x10]
006701758  mov      w0, #1
00670175C  ldp      x30, x21, [sp], #0x20
006701760  ret      

