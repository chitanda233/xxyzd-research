; LocalModels.Bean.BattleMain_chapter$$readImpl
; RVA 0x6883FD4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006883FD4  stp      x30, x21, [sp, #-0x20]!
006883FD8  stp      x20, x19, [sp, #0x10]
006883FDC  adrp     x20, #0x959b000
006883FE0  adrp     x21, #0x8f24000
006883FE4  ldrb     w8, [x20, #0xbdf]
006883FE8  ldr      x21, [x21, #0xe88]
006883FEC  mov      x19, x0
006883FF0  tbnz     w8, #0, #0x6884008
006883FF4  adrp     x0, #0x8f24000
006883FF8  ldr      x0, [x0, #0xe88]
006883FFC  bl       #0x382bd14 ; 
006884000  mov      w8, #1
006884004  strb     w8, [x20, #0xbdf]
006884008  ldr      x1, [x21]
00688400C  ldrb     w8, [x1, #0x53]
006884010  tbnz     w8, #5, #0x6884060
006884014  mov      x0, x19
006884018  mov      x1, xzr
00688401C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006884020  adrp     x21, #0x959c000
006884024  ldrb     w8, [x21, #0x3d7]
006884028  mov      w20, w0
00688402C  cbnz     w8, #0x6884044
006884030  adrp     x0, #0x8f24000
006884034  ldr      x0, [x0, #0xe60]
006884038  bl       #0x382bd14 ; 
00688403C  mov      w8, #1
006884040  strb     w8, [x21, #0x3d7]
006884044  adrp     x8, #0x8f24000
006884048  ldr      x8, [x8, #0xe60]
00688404C  ldr      x2, [x8]
006884050  ldrb     w8, [x2, #0x53]
006884054  tbnz     w8, #5, #0x6884074
006884058  str      w20, [x19, #0x20]
00688405C  b        #0x6884084 ; 
006884060  ldr      x2, [x1, #0x60]
006884064  mov      x0, x19
006884068  ldp      x20, x19, [sp, #0x10]
00688406C  ldp      x30, x21, [sp], #0x20
006884070  br       x2
006884074  ldr      x8, [x2, #0x60]
006884078  mov      x0, x19
00688407C  mov      w1, w20
006884080  blr      x8
006884084  mov      x0, x19
006884088  mov      x1, xzr
00688408C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006884090  adrp     x21, #0x959c000
006884094  ldrb     w8, [x21, #0x3d8]
006884098  mov      w20, w0
00688409C  cbnz     w8, #0x68840b4
0068840A0  adrp     x0, #0x8f24000
0068840A4  ldr      x0, [x0, #0xe70]
0068840A8  bl       #0x382bd14 ; 
0068840AC  mov      w8, #1
0068840B0  strb     w8, [x21, #0x3d8]
0068840B4  adrp     x8, #0x8f24000
0068840B8  ldr      x8, [x8, #0xe70]
0068840BC  ldr      x2, [x8]
0068840C0  ldrb     w8, [x2, #0x53]
0068840C4  tbnz     w8, #5, #0x68840d0
0068840C8  str      w20, [x19, #0x24]
0068840CC  b        #0x68840e0 ; 
0068840D0  ldr      x8, [x2, #0x60]
0068840D4  mov      x0, x19
0068840D8  mov      w1, w20
0068840DC  blr      x8
0068840E0  mov      x0, x19
0068840E4  mov      x1, xzr
0068840E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068840EC  adrp     x21, #0x959c000
0068840F0  ldrb     w8, [x21, #0x3d9]
0068840F4  mov      w20, w0
0068840F8  cbnz     w8, #0x6884110
0068840FC  adrp     x0, #0x8f24000
006884100  ldr      x0, [x0, #0xe80]
006884104  bl       #0x382bd14 ; 
006884108  mov      w8, #1
00688410C  strb     w8, [x21, #0x3d9]
006884110  adrp     x8, #0x8f24000
006884114  ldr      x8, [x8, #0xe80]
006884118  ldr      x2, [x8]
00688411C  ldrb     w8, [x2, #0x53]
006884120  tbnz     w8, #5, #0x688412c
006884124  str      w20, [x19, #0x28]
006884128  b        #0x688413c ; 
00688412C  ldr      x8, [x2, #0x60]
006884130  mov      x0, x19
006884134  mov      w1, w20
006884138  blr      x8
00688413C  ldp      x20, x19, [sp, #0x10]
006884140  mov      w0, #1
006884144  ldp      x30, x21, [sp], #0x20
006884148  ret      

