; LocalModels.Bean.Chapter_Star$$readImpl
; RVA 0x68B6240; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068B6240  stp      x30, x21, [sp, #-0x20]!
0068B6244  stp      x20, x19, [sp, #0x10]
0068B6248  adrp     x20, #0x959c000
0068B624C  adrp     x21, #0x8f27000
0068B6250  ldrb     w8, [x20, #0xfc]
0068B6254  ldr      x21, [x21, #0x3a0]
0068B6258  mov      x19, x0
0068B625C  tbnz     w8, #0, #0x68b6274
0068B6260  adrp     x0, #0x8f27000
0068B6264  ldr      x0, [x0, #0x3a0]
0068B6268  bl       #0x382bd14 ; 
0068B626C  mov      w8, #1
0068B6270  strb     w8, [x20, #0xfc]
0068B6274  ldr      x1, [x21]
0068B6278  ldrb     w8, [x1, #0x53]
0068B627C  tbnz     w8, #5, #0x68b62cc
0068B6280  mov      x0, x19
0068B6284  mov      x1, xzr
0068B6288  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B628C  adrp     x21, #0x959c000
0068B6290  ldrb     w8, [x21, #0x625]
0068B6294  mov      w20, w0
0068B6298  cbnz     w8, #0x68b62b0
0068B629C  adrp     x0, #0x8f27000
0068B62A0  ldr      x0, [x0, #0x358]
0068B62A4  bl       #0x382bd14 ; 
0068B62A8  mov      w8, #1
0068B62AC  strb     w8, [x21, #0x625]
0068B62B0  adrp     x8, #0x8f27000
0068B62B4  ldr      x8, [x8, #0x358]
0068B62B8  ldr      x2, [x8]
0068B62BC  ldrb     w8, [x2, #0x53]
0068B62C0  tbnz     w8, #5, #0x68b62e0
0068B62C4  str      w20, [x19, #0x20]
0068B62C8  b        #0x68b62f0 ; 
0068B62CC  ldr      x2, [x1, #0x60]
0068B62D0  mov      x0, x19
0068B62D4  ldp      x20, x19, [sp, #0x10]
0068B62D8  ldp      x30, x21, [sp], #0x20
0068B62DC  br       x2
0068B62E0  ldr      x8, [x2, #0x60]
0068B62E4  mov      x0, x19
0068B62E8  mov      w1, w20
0068B62EC  blr      x8
0068B62F0  mov      x0, x19
0068B62F4  mov      x1, xzr
0068B62F8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B62FC  adrp     x21, #0x959c000
0068B6300  ldrb     w8, [x21, #0x626]
0068B6304  mov      w20, w0
0068B6308  cbnz     w8, #0x68b6320
0068B630C  adrp     x0, #0x8f27000
0068B6310  ldr      x0, [x0, #0x368]
0068B6314  bl       #0x382bd14 ; 
0068B6318  mov      w8, #1
0068B631C  strb     w8, [x21, #0x626]
0068B6320  adrp     x8, #0x8f27000
0068B6324  ldr      x8, [x8, #0x368]
0068B6328  ldr      x2, [x8]
0068B632C  ldrb     w8, [x2, #0x53]
0068B6330  tbnz     w8, #5, #0x68b633c
0068B6334  str      w20, [x19, #0x24]
0068B6338  b        #0x68b634c ; 
0068B633C  ldr      x8, [x2, #0x60]
0068B6340  mov      x0, x19
0068B6344  mov      w1, w20
0068B6348  blr      x8
0068B634C  mov      x0, x19
0068B6350  mov      x1, xzr
0068B6354  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B6358  adrp     x21, #0x959c000
0068B635C  ldrb     w8, [x21, #0x627]
0068B6360  mov      w20, w0
0068B6364  cbnz     w8, #0x68b637c
0068B6368  adrp     x0, #0x8f27000
0068B636C  ldr      x0, [x0, #0x378]
0068B6370  bl       #0x382bd14 ; 
0068B6374  mov      w8, #1
0068B6378  strb     w8, [x21, #0x627]
0068B637C  adrp     x8, #0x8f27000
0068B6380  ldr      x8, [x8, #0x378]
0068B6384  ldr      x2, [x8]
0068B6388  ldrb     w8, [x2, #0x53]
0068B638C  tbnz     w8, #5, #0x68b6398
0068B6390  str      w20, [x19, #0x28]
0068B6394  b        #0x68b63a8 ; 
0068B6398  ldr      x8, [x2, #0x60]
0068B639C  mov      x0, x19
0068B63A0  mov      w1, w20
0068B63A4  blr      x8
0068B63A8  mov      x0, x19
0068B63AC  mov      x1, xzr
0068B63B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B63B4  adrp     x21, #0x959c000
0068B63B8  ldrb     w8, [x21, #0x628]
0068B63BC  mov      w20, w0
0068B63C0  cbnz     w8, #0x68b63d8
0068B63C4  adrp     x0, #0x8f27000
0068B63C8  ldr      x0, [x0, #0x388]
0068B63CC  bl       #0x382bd14 ; 
0068B63D0  mov      w8, #1
0068B63D4  strb     w8, [x21, #0x628]
0068B63D8  adrp     x8, #0x8f27000
0068B63DC  ldr      x8, [x8, #0x388]
0068B63E0  ldr      x2, [x8]
0068B63E4  ldrb     w8, [x2, #0x53]
0068B63E8  tbnz     w8, #5, #0x68b63f4
0068B63EC  str      w20, [x19, #0x2c]
0068B63F0  b        #0x68b6404 ; 
0068B63F4  ldr      x8, [x2, #0x60]
0068B63F8  mov      x0, x19
0068B63FC  mov      w1, w20
0068B6400  blr      x8
0068B6404  mov      x0, x19
0068B6408  mov      x1, xzr
0068B640C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B6410  adrp     x21, #0x959c000
0068B6414  ldrb     w8, [x21, #0x629]
0068B6418  mov      w20, w0
0068B641C  cbnz     w8, #0x68b6434
0068B6420  adrp     x0, #0x8f27000
0068B6424  ldr      x0, [x0, #0x398]
0068B6428  bl       #0x382bd14 ; 
0068B642C  mov      w8, #1
0068B6430  strb     w8, [x21, #0x629]
0068B6434  adrp     x8, #0x8f27000
0068B6438  ldr      x8, [x8, #0x398]
0068B643C  ldr      x2, [x8]
0068B6440  ldrb     w8, [x2, #0x53]
0068B6444  tbnz     w8, #5, #0x68b6450
0068B6448  str      w20, [x19, #0x30]
0068B644C  b        #0x68b6460 ; 
0068B6450  ldr      x8, [x2, #0x60]
0068B6454  mov      x0, x19
0068B6458  mov      w1, w20
0068B645C  blr      x8
0068B6460  ldp      x20, x19, [sp, #0x10]
0068B6464  mov      w0, #1
0068B6468  ldp      x30, x21, [sp], #0x20
0068B646C  ret      

