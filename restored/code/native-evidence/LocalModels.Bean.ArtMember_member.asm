; LocalModels.Bean.ArtMember_member$$readImpl
; RVA 0x67010F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067010F4  stp      x30, x21, [sp, #-0x20]!
0067010F8  stp      x20, x19, [sp, #0x10]
0067010FC  adrp     x20, #0x959a000
006701100  adrp     x21, #0x8f17000
006701104  ldrb     w8, [x20, #0x899]
006701108  ldr      x21, [x21, #0x6f0]
00670110C  mov      x19, x0
006701110  tbnz     w8, #0, #0x6701128
006701114  adrp     x0, #0x8f17000
006701118  ldr      x0, [x0, #0x6f0]
00670111C  bl       #0x382bd14 ; 
006701120  mov      w8, #1
006701124  strb     w8, [x20, #0x899]
006701128  ldr      x1, [x21]
00670112C  ldrb     w8, [x1, #0x53]
006701130  tbnz     w8, #5, #0x6701180
006701134  mov      x0, x19
006701138  mov      x1, xzr
00670113C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006701140  adrp     x21, #0x959a000
006701144  ldrb     w8, [x21, #0x95b]
006701148  mov      w20, w0
00670114C  cbnz     w8, #0x6701164
006701150  adrp     x0, #0x8f17000
006701154  ldr      x0, [x0, #0x6d8]
006701158  bl       #0x382bd14 ; 
00670115C  mov      w8, #1
006701160  strb     w8, [x21, #0x95b]
006701164  adrp     x8, #0x8f17000
006701168  ldr      x8, [x8, #0x6d8]
00670116C  ldr      x2, [x8]
006701170  ldrb     w8, [x2, #0x53]
006701174  tbnz     w8, #5, #0x6701194
006701178  str      w20, [x19, #0x20]
00670117C  b        #0x67011a4 ; 
006701180  ldr      x2, [x1, #0x60]
006701184  mov      x0, x19
006701188  ldp      x20, x19, [sp, #0x10]
00670118C  ldp      x30, x21, [sp], #0x20
006701190  br       x2
006701194  ldr      x8, [x2, #0x60]
006701198  mov      x0, x19
00670119C  mov      w1, w20
0067011A0  blr      x8
0067011A4  mov      x0, x19
0067011A8  mov      x1, xzr
0067011AC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0067011B0  adrp     x21, #0x959a000
0067011B4  ldrb     w8, [x21, #0x95c]
0067011B8  mov      x20, x0
0067011BC  cbnz     w8, #0x67011d4
0067011C0  adrp     x0, #0x8f17000
0067011C4  ldr      x0, [x0, #0x6e8]
0067011C8  bl       #0x382bd14 ; 
0067011CC  mov      w8, #1
0067011D0  strb     w8, [x21, #0x95c]
0067011D4  adrp     x8, #0x8f17000
0067011D8  ldr      x8, [x8, #0x6e8]
0067011DC  ldr      x2, [x8]
0067011E0  ldrb     w8, [x2, #0x53]
0067011E4  tbnz     w8, #5, #0x67011fc
0067011E8  str      x20, [x19, #0x28]!
0067011EC  mov      x0, x19
0067011F0  mov      x1, x20
0067011F4  bl       #0x382bcb8 ; 
0067011F8  b        #0x670120c ; 
0067011FC  ldr      x8, [x2, #0x60]
006701200  mov      x0, x19
006701204  mov      x1, x20
006701208  blr      x8
00670120C  ldp      x20, x19, [sp, #0x10]
006701210  mov      w0, #1
006701214  ldp      x30, x21, [sp], #0x20
006701218  ret      

