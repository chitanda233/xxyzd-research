; LocalModels.Bean.Character_MonsterTrait$$readImpl
; RVA 0x68CA0BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CA0BC  stp      x30, x21, [sp, #-0x20]!
0068CA0C0  stp      x20, x19, [sp, #0x10]
0068CA0C4  adrp     x20, #0x959c000
0068CA0C8  adrp     x21, #0x8f28000
0068CA0CC  ldrb     w8, [x20, #0x305]
0068CA0D0  ldr      x21, [x21, #0x1d8]
0068CA0D4  mov      x19, x0
0068CA0D8  tbnz     w8, #0, #0x68ca0f0
0068CA0DC  adrp     x0, #0x8f28000
0068CA0E0  ldr      x0, [x0, #0x1d8]
0068CA0E4  bl       #0x382bd14 ; 
0068CA0E8  mov      w8, #1
0068CA0EC  strb     w8, [x20, #0x305]
0068CA0F0  ldr      x1, [x21]
0068CA0F4  ldrb     w8, [x1, #0x53]
0068CA0F8  tbnz     w8, #5, #0x68ca148
0068CA0FC  mov      x0, x19
0068CA100  mov      x1, xzr
0068CA104  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CA108  adrp     x21, #0x959c000
0068CA10C  ldrb     w8, [x21, #0x710]
0068CA110  mov      w20, w0
0068CA114  cbnz     w8, #0x68ca12c
0068CA118  adrp     x0, #0x8f28000
0068CA11C  ldr      x0, [x0, #0x1a0]
0068CA120  bl       #0x382bd14 ; 
0068CA124  mov      w8, #1
0068CA128  strb     w8, [x21, #0x710]
0068CA12C  adrp     x8, #0x8f28000
0068CA130  ldr      x8, [x8, #0x1a0]
0068CA134  ldr      x2, [x8]
0068CA138  ldrb     w8, [x2, #0x53]
0068CA13C  tbnz     w8, #5, #0x68ca15c
0068CA140  str      w20, [x19, #0x20]
0068CA144  b        #0x68ca16c ; 
0068CA148  ldr      x2, [x1, #0x60]
0068CA14C  mov      x0, x19
0068CA150  ldp      x20, x19, [sp, #0x10]
0068CA154  ldp      x30, x21, [sp], #0x20
0068CA158  br       x2
0068CA15C  ldr      x8, [x2, #0x60]
0068CA160  mov      x0, x19
0068CA164  mov      w1, w20
0068CA168  blr      x8
0068CA16C  mov      x0, x19
0068CA170  mov      x1, xzr
0068CA174  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CA178  adrp     x21, #0x959c000
0068CA17C  ldrb     w8, [x21, #0x711]
0068CA180  mov      w20, w0
0068CA184  cbnz     w8, #0x68ca19c
0068CA188  adrp     x0, #0x8f28000
0068CA18C  ldr      x0, [x0, #0x1b0]
0068CA190  bl       #0x382bd14 ; 
0068CA194  mov      w8, #1
0068CA198  strb     w8, [x21, #0x711]
0068CA19C  adrp     x8, #0x8f28000
0068CA1A0  ldr      x8, [x8, #0x1b0]
0068CA1A4  ldr      x2, [x8]
0068CA1A8  ldrb     w8, [x2, #0x53]
0068CA1AC  tbnz     w8, #5, #0x68ca1b8
0068CA1B0  str      w20, [x19, #0x24]
0068CA1B4  b        #0x68ca1c8 ; 
0068CA1B8  ldr      x8, [x2, #0x60]
0068CA1BC  mov      x0, x19
0068CA1C0  mov      w1, w20
0068CA1C4  blr      x8
0068CA1C8  mov      x0, x19
0068CA1CC  mov      x1, xzr
0068CA1D0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CA1D4  adrp     x21, #0x959c000
0068CA1D8  ldrb     w8, [x21, #0x712]
0068CA1DC  mov      x20, x0
0068CA1E0  cbnz     w8, #0x68ca1f8
0068CA1E4  adrp     x0, #0x8f28000
0068CA1E8  ldr      x0, [x0, #0x1c0]
0068CA1EC  bl       #0x382bd14 ; 
0068CA1F0  mov      w8, #1
0068CA1F4  strb     w8, [x21, #0x712]
0068CA1F8  adrp     x8, #0x8f28000
0068CA1FC  ldr      x8, [x8, #0x1c0]
0068CA200  ldr      x2, [x8]
0068CA204  ldrb     w8, [x2, #0x53]
0068CA208  tbnz     w8, #5, #0x68ca220
0068CA20C  mov      x0, x19
0068CA210  str      x20, [x0, #0x28]!
0068CA214  mov      x1, x20
0068CA218  bl       #0x382bcb8 ; 
0068CA21C  b        #0x68ca230 ; 
0068CA220  ldr      x8, [x2, #0x60]
0068CA224  mov      x0, x19
0068CA228  mov      x1, x20
0068CA22C  blr      x8
0068CA230  mov      x0, x19
0068CA234  mov      x1, xzr
0068CA238  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CA23C  adrp     x21, #0x959c000
0068CA240  ldrb     w8, [x21, #0x713]
0068CA244  mov      x20, x0
0068CA248  cbnz     w8, #0x68ca260
0068CA24C  adrp     x0, #0x8f28000
0068CA250  ldr      x0, [x0, #0x1d0]
0068CA254  bl       #0x382bd14 ; 
0068CA258  mov      w8, #1
0068CA25C  strb     w8, [x21, #0x713]
0068CA260  adrp     x8, #0x8f28000
0068CA264  ldr      x8, [x8, #0x1d0]
0068CA268  ldr      x2, [x8]
0068CA26C  ldrb     w8, [x2, #0x53]
0068CA270  tbnz     w8, #5, #0x68ca288
0068CA274  str      x20, [x19, #0x30]!
0068CA278  mov      x0, x19
0068CA27C  mov      x1, x20
0068CA280  bl       #0x382bcb8 ; 
0068CA284  b        #0x68ca298 ; 
0068CA288  ldr      x8, [x2, #0x60]
0068CA28C  mov      x0, x19
0068CA290  mov      x1, x20
0068CA294  blr      x8
0068CA298  ldp      x20, x19, [sp, #0x10]
0068CA29C  mov      w0, #1
0068CA2A0  ldp      x30, x21, [sp], #0x20
0068CA2A4  ret      

