; LocalModels.Bean.Rune_RuneBox$$readImpl
; RVA 0x6AE60EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE60EC  stp      x30, x21, [sp, #-0x20]!
006AE60F0  stp      x20, x19, [sp, #0x10]
006AE60F4  adrp     x20, #0x959e000
006AE60F8  adrp     x21, #0x8f3c000
006AE60FC  ldrb     w8, [x20, #0xd49]
006AE6100  ldr      x21, [x21, #0xdf8]
006AE6104  mov      x19, x0
006AE6108  tbnz     w8, #0, #0x6ae6120
006AE610C  adrp     x0, #0x8f3c000
006AE6110  ldr      x0, [x0, #0xdf8]
006AE6114  bl       #0x382bd14 ; 
006AE6118  mov      w8, #1
006AE611C  strb     w8, [x20, #0xd49]
006AE6120  ldr      x1, [x21]
006AE6124  ldrb     w8, [x1, #0x53]
006AE6128  tbnz     w8, #5, #0x6ae6178
006AE612C  mov      x0, x19
006AE6130  mov      x1, xzr
006AE6134  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE6138  adrp     x21, #0x959f000
006AE613C  ldrb     w8, [x21, #0x1d4]
006AE6140  mov      w20, w0
006AE6144  cbnz     w8, #0x6ae615c
006AE6148  adrp     x0, #0x8f3c000
006AE614C  ldr      x0, [x0, #0xdb0]
006AE6150  bl       #0x382bd14 ; 
006AE6154  mov      w8, #1
006AE6158  strb     w8, [x21, #0x1d4]
006AE615C  adrp     x8, #0x8f3c000
006AE6160  ldr      x8, [x8, #0xdb0]
006AE6164  ldr      x2, [x8]
006AE6168  ldrb     w8, [x2, #0x53]
006AE616C  tbnz     w8, #5, #0x6ae618c
006AE6170  str      w20, [x19, #0x20]
006AE6174  b        #0x6ae619c ; 
006AE6178  ldr      x2, [x1, #0x60]
006AE617C  mov      x0, x19
006AE6180  ldp      x20, x19, [sp, #0x10]
006AE6184  ldp      x30, x21, [sp], #0x20
006AE6188  br       x2
006AE618C  ldr      x8, [x2, #0x60]
006AE6190  mov      x0, x19
006AE6194  mov      w1, w20
006AE6198  blr      x8
006AE619C  mov      x0, x19
006AE61A0  mov      x1, xzr
006AE61A4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE61A8  adrp     x21, #0x959f000
006AE61AC  ldrb     w8, [x21, #0x1d5]
006AE61B0  mov      w20, w0
006AE61B4  cbnz     w8, #0x6ae61cc
006AE61B8  adrp     x0, #0x8f3c000
006AE61BC  ldr      x0, [x0, #0xdc0]
006AE61C0  bl       #0x382bd14 ; 
006AE61C4  mov      w8, #1
006AE61C8  strb     w8, [x21, #0x1d5]
006AE61CC  adrp     x8, #0x8f3c000
006AE61D0  ldr      x8, [x8, #0xdc0]
006AE61D4  ldr      x2, [x8]
006AE61D8  ldrb     w8, [x2, #0x53]
006AE61DC  tbnz     w8, #5, #0x6ae61e8
006AE61E0  str      w20, [x19, #0x24]
006AE61E4  b        #0x6ae61f8 ; 
006AE61E8  ldr      x8, [x2, #0x60]
006AE61EC  mov      x0, x19
006AE61F0  mov      w1, w20
006AE61F4  blr      x8
006AE61F8  mov      x0, x19
006AE61FC  mov      x1, xzr
006AE6200  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE6204  adrp     x21, #0x959f000
006AE6208  ldrb     w8, [x21, #0x1d6]
006AE620C  mov      w20, w0
006AE6210  cbnz     w8, #0x6ae6228
006AE6214  adrp     x0, #0x8f3c000
006AE6218  ldr      x0, [x0, #0xdd0]
006AE621C  bl       #0x382bd14 ; 
006AE6220  mov      w8, #1
006AE6224  strb     w8, [x21, #0x1d6]
006AE6228  adrp     x8, #0x8f3c000
006AE622C  ldr      x8, [x8, #0xdd0]
006AE6230  ldr      x2, [x8]
006AE6234  ldrb     w8, [x2, #0x53]
006AE6238  tbnz     w8, #5, #0x6ae6244
006AE623C  str      w20, [x19, #0x28]
006AE6240  b        #0x6ae6254 ; 
006AE6244  ldr      x8, [x2, #0x60]
006AE6248  mov      x0, x19
006AE624C  mov      w1, w20
006AE6250  blr      x8
006AE6254  mov      x0, x19
006AE6258  mov      x1, xzr
006AE625C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE6260  adrp     x21, #0x959f000
006AE6264  ldrb     w8, [x21, #0x1d7]
006AE6268  mov      x20, x0
006AE626C  cbnz     w8, #0x6ae6284
006AE6270  adrp     x0, #0x8f3c000
006AE6274  ldr      x0, [x0, #0xde0]
006AE6278  bl       #0x382bd14 ; 
006AE627C  mov      w8, #1
006AE6280  strb     w8, [x21, #0x1d7]
006AE6284  adrp     x8, #0x8f3c000
006AE6288  ldr      x8, [x8, #0xde0]
006AE628C  ldr      x2, [x8]
006AE6290  ldrb     w8, [x2, #0x53]
006AE6294  tbnz     w8, #5, #0x6ae62ac
006AE6298  mov      x0, x19
006AE629C  str      x20, [x0, #0x30]!
006AE62A0  mov      x1, x20
006AE62A4  bl       #0x382bcb8 ; 
006AE62A8  b        #0x6ae62bc ; 
006AE62AC  ldr      x8, [x2, #0x60]
006AE62B0  mov      x0, x19
006AE62B4  mov      x1, x20
006AE62B8  blr      x8
006AE62BC  mov      x0, x19
006AE62C0  mov      x1, xzr
006AE62C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE62C8  adrp     x21, #0x959f000
006AE62CC  ldrb     w8, [x21, #0x1d8]
006AE62D0  mov      w20, w0
006AE62D4  cbnz     w8, #0x6ae62ec
006AE62D8  adrp     x0, #0x8f3c000
006AE62DC  ldr      x0, [x0, #0xdf0]
006AE62E0  bl       #0x382bd14 ; 
006AE62E4  mov      w8, #1
006AE62E8  strb     w8, [x21, #0x1d8]
006AE62EC  adrp     x8, #0x8f3c000
006AE62F0  ldr      x8, [x8, #0xdf0]
006AE62F4  ldr      x2, [x8]
006AE62F8  ldrb     w8, [x2, #0x53]
006AE62FC  tbnz     w8, #5, #0x6ae6308
006AE6300  str      w20, [x19, #0x38]
006AE6304  b        #0x6ae6318 ; 
006AE6308  ldr      x8, [x2, #0x60]
006AE630C  mov      x0, x19
006AE6310  mov      w1, w20
006AE6314  blr      x8
006AE6318  ldp      x20, x19, [sp, #0x10]
006AE631C  mov      w0, #1
006AE6320  ldp      x30, x21, [sp], #0x20
006AE6324  ret      

