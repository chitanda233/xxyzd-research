; LocalModels.Bean.SkillGroup_InitBaseGroup$$readImpl
; RVA 0x6AF82E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF82E0  stp      x30, x21, [sp, #-0x20]!
006AF82E4  stp      x20, x19, [sp, #0x10]
006AF82E8  adrp     x20, #0x959f000
006AF82EC  adrp     x21, #0x8f3d000
006AF82F0  ldrb     w8, [x20, #0x2c2]
006AF82F4  ldr      x21, [x21, #0xbe8]
006AF82F8  mov      x19, x0
006AF82FC  tbnz     w8, #0, #0x6af8314
006AF8300  adrp     x0, #0x8f3d000
006AF8304  ldr      x0, [x0, #0xbe8]
006AF8308  bl       #0x382bd14 ; 
006AF830C  mov      w8, #1
006AF8310  strb     w8, [x20, #0x2c2]
006AF8314  ldr      x1, [x21]
006AF8318  ldrb     w8, [x1, #0x53]
006AF831C  tbnz     w8, #5, #0x6af836c
006AF8320  mov      x0, x19
006AF8324  mov      x1, xzr
006AF8328  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF832C  adrp     x21, #0x959f000
006AF8330  ldrb     w8, [x21, #0x879]
006AF8334  mov      w20, w0
006AF8338  cbnz     w8, #0x6af8350
006AF833C  adrp     x0, #0x8f3d000
006AF8340  ldr      x0, [x0, #0xbc0]
006AF8344  bl       #0x382bd14 ; 
006AF8348  mov      w8, #1
006AF834C  strb     w8, [x21, #0x879]
006AF8350  adrp     x8, #0x8f3d000
006AF8354  ldr      x8, [x8, #0xbc0]
006AF8358  ldr      x2, [x8]
006AF835C  ldrb     w8, [x2, #0x53]
006AF8360  tbnz     w8, #5, #0x6af8380
006AF8364  str      w20, [x19, #0x20]
006AF8368  b        #0x6af8390 ; 
006AF836C  ldr      x2, [x1, #0x60]
006AF8370  mov      x0, x19
006AF8374  ldp      x20, x19, [sp, #0x10]
006AF8378  ldp      x30, x21, [sp], #0x20
006AF837C  br       x2
006AF8380  ldr      x8, [x2, #0x60]
006AF8384  mov      x0, x19
006AF8388  mov      w1, w20
006AF838C  blr      x8
006AF8390  mov      x0, x19
006AF8394  mov      x1, xzr
006AF8398  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF839C  adrp     x21, #0x959f000
006AF83A0  ldrb     w8, [x21, #0x87a]
006AF83A4  mov      w20, w0
006AF83A8  cbnz     w8, #0x6af83c0
006AF83AC  adrp     x0, #0x8f3d000
006AF83B0  ldr      x0, [x0, #0xbd0]
006AF83B4  bl       #0x382bd14 ; 
006AF83B8  mov      w8, #1
006AF83BC  strb     w8, [x21, #0x87a]
006AF83C0  adrp     x8, #0x8f3d000
006AF83C4  ldr      x8, [x8, #0xbd0]
006AF83C8  ldr      x2, [x8]
006AF83CC  ldrb     w8, [x2, #0x53]
006AF83D0  tbnz     w8, #5, #0x6af83dc
006AF83D4  str      w20, [x19, #0x24]
006AF83D8  b        #0x6af83ec ; 
006AF83DC  ldr      x8, [x2, #0x60]
006AF83E0  mov      x0, x19
006AF83E4  mov      w1, w20
006AF83E8  blr      x8
006AF83EC  mov      x0, x19
006AF83F0  mov      x1, xzr
006AF83F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF83F8  adrp     x21, #0x959f000
006AF83FC  ldrb     w8, [x21, #0x87b]
006AF8400  mov      w20, w0
006AF8404  cbnz     w8, #0x6af841c
006AF8408  adrp     x0, #0x8f3d000
006AF840C  ldr      x0, [x0, #0xbe0]
006AF8410  bl       #0x382bd14 ; 
006AF8414  mov      w8, #1
006AF8418  strb     w8, [x21, #0x87b]
006AF841C  adrp     x8, #0x8f3d000
006AF8420  ldr      x8, [x8, #0xbe0]
006AF8424  ldr      x2, [x8]
006AF8428  ldrb     w8, [x2, #0x53]
006AF842C  tbnz     w8, #5, #0x6af8438
006AF8430  str      w20, [x19, #0x28]
006AF8434  b        #0x6af8448 ; 
006AF8438  ldr      x8, [x2, #0x60]
006AF843C  mov      x0, x19
006AF8440  mov      w1, w20
006AF8444  blr      x8
006AF8448  ldp      x20, x19, [sp, #0x10]
006AF844C  mov      w0, #1
006AF8450  ldp      x30, x21, [sp], #0x20
006AF8454  ret      

