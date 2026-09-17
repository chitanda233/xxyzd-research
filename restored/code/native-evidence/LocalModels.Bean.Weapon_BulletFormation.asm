; LocalModels.Bean.Weapon_BulletFormation$$readImpl
; RVA 0x6B1F250; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B1F250  stp      x30, x21, [sp, #-0x20]!
006B1F254  stp      x20, x19, [sp, #0x10]
006B1F258  adrp     x20, #0x959f000
006B1F25C  adrp     x21, #0x8f3f000
006B1F260  ldrb     w8, [x20, #0x6c1]
006B1F264  ldr      x21, [x21, #0x778]
006B1F268  mov      x19, x0
006B1F26C  tbnz     w8, #0, #0x6b1f284
006B1F270  adrp     x0, #0x8f3f000
006B1F274  ldr      x0, [x0, #0x778]
006B1F278  bl       #0x382bd14 ; 
006B1F27C  mov      w8, #1
006B1F280  strb     w8, [x20, #0x6c1]
006B1F284  ldr      x1, [x21]
006B1F288  ldrb     w8, [x1, #0x53]
006B1F28C  tbnz     w8, #5, #0x6b1f2dc
006B1F290  mov      x0, x19
006B1F294  mov      x1, xzr
006B1F298  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1F29C  adrp     x21, #0x959f000
006B1F2A0  ldrb     w8, [x21, #0xa44]
006B1F2A4  mov      w20, w0
006B1F2A8  cbnz     w8, #0x6b1f2c0
006B1F2AC  adrp     x0, #0x8f3f000
006B1F2B0  ldr      x0, [x0, #0x6e0]
006B1F2B4  bl       #0x382bd14 ; 
006B1F2B8  mov      w8, #1
006B1F2BC  strb     w8, [x21, #0xa44]
006B1F2C0  adrp     x8, #0x8f3f000
006B1F2C4  ldr      x8, [x8, #0x6e0]
006B1F2C8  ldr      x2, [x8]
006B1F2CC  ldrb     w8, [x2, #0x53]
006B1F2D0  tbnz     w8, #5, #0x6b1f2f0
006B1F2D4  str      w20, [x19, #0x20]
006B1F2D8  b        #0x6b1f300 ; 
006B1F2DC  ldr      x2, [x1, #0x60]
006B1F2E0  mov      x0, x19
006B1F2E4  ldp      x20, x19, [sp, #0x10]
006B1F2E8  ldp      x30, x21, [sp], #0x20
006B1F2EC  br       x2
006B1F2F0  ldr      x8, [x2, #0x60]
006B1F2F4  mov      x0, x19
006B1F2F8  mov      w1, w20
006B1F2FC  blr      x8
006B1F300  mov      x0, x19
006B1F304  mov      x1, xzr
006B1F308  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1F30C  adrp     x21, #0x959f000
006B1F310  ldrb     w8, [x21, #0xa45]
006B1F314  mov      w20, w0
006B1F318  cbnz     w8, #0x6b1f330
006B1F31C  adrp     x0, #0x8f3f000
006B1F320  ldr      x0, [x0, #0x6f0]
006B1F324  bl       #0x382bd14 ; 
006B1F328  mov      w8, #1
006B1F32C  strb     w8, [x21, #0xa45]
006B1F330  adrp     x8, #0x8f3f000
006B1F334  ldr      x8, [x8, #0x6f0]
006B1F338  ldr      x2, [x8]
006B1F33C  ldrb     w8, [x2, #0x53]
006B1F340  tbnz     w8, #5, #0x6b1f34c
006B1F344  str      w20, [x19, #0x24]
006B1F348  b        #0x6b1f35c ; 
006B1F34C  ldr      x8, [x2, #0x60]
006B1F350  mov      x0, x19
006B1F354  mov      w1, w20
006B1F358  blr      x8
006B1F35C  mov      x0, x19
006B1F360  mov      x1, xzr
006B1F364  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1F368  adrp     x21, #0x959f000
006B1F36C  ldrb     w8, [x21, #0xa46]
006B1F370  mov      w20, w0
006B1F374  cbnz     w8, #0x6b1f38c
006B1F378  adrp     x0, #0x8f3f000
006B1F37C  ldr      x0, [x0, #0x700]
006B1F380  bl       #0x382bd14 ; 
006B1F384  mov      w8, #1
006B1F388  strb     w8, [x21, #0xa46]
006B1F38C  adrp     x8, #0x8f3f000
006B1F390  ldr      x8, [x8, #0x700]
006B1F394  ldr      x2, [x8]
006B1F398  ldrb     w8, [x2, #0x53]
006B1F39C  tbnz     w8, #5, #0x6b1f3a8
006B1F3A0  str      w20, [x19, #0x28]
006B1F3A4  b        #0x6b1f3b8 ; 
006B1F3A8  ldr      x8, [x2, #0x60]
006B1F3AC  mov      x0, x19
006B1F3B0  mov      w1, w20
006B1F3B4  blr      x8
006B1F3B8  mov      x0, x19
006B1F3BC  mov      x1, xzr
006B1F3C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1F3C4  adrp     x21, #0x959f000
006B1F3C8  ldrb     w8, [x21, #0xa47]
006B1F3CC  mov      w20, w0
006B1F3D0  cbnz     w8, #0x6b1f3e8
006B1F3D4  adrp     x0, #0x8f3f000
006B1F3D8  ldr      x0, [x0, #0x710]
006B1F3DC  bl       #0x382bd14 ; 
006B1F3E0  mov      w8, #1
006B1F3E4  strb     w8, [x21, #0xa47]
006B1F3E8  adrp     x8, #0x8f3f000
006B1F3EC  ldr      x8, [x8, #0x710]
006B1F3F0  ldr      x2, [x8]
006B1F3F4  ldrb     w8, [x2, #0x53]
006B1F3F8  tbnz     w8, #5, #0x6b1f404
006B1F3FC  str      w20, [x19, #0x2c]
006B1F400  b        #0x6b1f414 ; 
006B1F404  ldr      x8, [x2, #0x60]
006B1F408  mov      x0, x19
006B1F40C  mov      w1, w20
006B1F410  blr      x8
006B1F414  mov      x0, x19
006B1F418  mov      x1, xzr
006B1F41C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1F420  adrp     x21, #0x959f000
006B1F424  ldrb     w8, [x21, #0xa48]
006B1F428  mov      w20, w0
006B1F42C  cbnz     w8, #0x6b1f444
006B1F430  adrp     x0, #0x8f3f000
006B1F434  ldr      x0, [x0, #0x720]
006B1F438  bl       #0x382bd14 ; 
006B1F43C  mov      w8, #1
006B1F440  strb     w8, [x21, #0xa48]
006B1F444  adrp     x8, #0x8f3f000
006B1F448  ldr      x8, [x8, #0x720]
006B1F44C  ldr      x2, [x8]
006B1F450  ldrb     w8, [x2, #0x53]
006B1F454  tbnz     w8, #5, #0x6b1f460
006B1F458  str      w20, [x19, #0x30]
006B1F45C  b        #0x6b1f470 ; 
006B1F460  ldr      x8, [x2, #0x60]
006B1F464  mov      x0, x19
006B1F468  mov      w1, w20
006B1F46C  blr      x8
006B1F470  mov      x0, x19
006B1F474  mov      x1, xzr
006B1F478  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1F47C  adrp     x21, #0x959f000
006B1F480  ldrb     w8, [x21, #0xa49]
006B1F484  mov      w20, w0
006B1F488  cbnz     w8, #0x6b1f4a0
006B1F48C  adrp     x0, #0x8f3f000
006B1F490  ldr      x0, [x0, #0x730]
006B1F494  bl       #0x382bd14 ; 
006B1F498  mov      w8, #1
006B1F49C  strb     w8, [x21, #0xa49]
006B1F4A0  adrp     x8, #0x8f3f000
006B1F4A4  ldr      x8, [x8, #0x730]
006B1F4A8  ldr      x2, [x8]
006B1F4AC  ldrb     w8, [x2, #0x53]
006B1F4B0  tbnz     w8, #5, #0x6b1f4bc
006B1F4B4  str      w20, [x19, #0x34]
006B1F4B8  b        #0x6b1f4cc ; 
006B1F4BC  ldr      x8, [x2, #0x60]
006B1F4C0  mov      x0, x19
006B1F4C4  mov      w1, w20
006B1F4C8  blr      x8
006B1F4CC  mov      x0, x19
006B1F4D0  mov      x1, xzr
006B1F4D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1F4D8  adrp     x21, #0x959f000
006B1F4DC  ldrb     w8, [x21, #0xa4a]
006B1F4E0  mov      w20, w0
006B1F4E4  cbnz     w8, #0x6b1f4fc
006B1F4E8  adrp     x0, #0x8f3f000
006B1F4EC  ldr      x0, [x0, #0x740]
006B1F4F0  bl       #0x382bd14 ; 
006B1F4F4  mov      w8, #1
006B1F4F8  strb     w8, [x21, #0xa4a]
006B1F4FC  adrp     x8, #0x8f3f000
006B1F500  ldr      x8, [x8, #0x740]
006B1F504  ldr      x2, [x8]
006B1F508  ldrb     w8, [x2, #0x53]
006B1F50C  tbnz     w8, #5, #0x6b1f518
006B1F510  str      w20, [x19, #0x38]
006B1F514  b        #0x6b1f528 ; 
006B1F518  ldr      x8, [x2, #0x60]
006B1F51C  mov      x0, x19
006B1F520  mov      w1, w20
006B1F524  blr      x8
006B1F528  mov      x0, x19
006B1F52C  mov      x1, xzr
006B1F530  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1F534  adrp     x21, #0x959f000
006B1F538  ldrb     w8, [x21, #0xa4b]
006B1F53C  mov      w20, w0
006B1F540  cbnz     w8, #0x6b1f558
006B1F544  adrp     x0, #0x8f3f000
006B1F548  ldr      x0, [x0, #0x750]
006B1F54C  bl       #0x382bd14 ; 
006B1F550  mov      w8, #1
006B1F554  strb     w8, [x21, #0xa4b]
006B1F558  adrp     x8, #0x8f3f000
006B1F55C  ldr      x8, [x8, #0x750]
006B1F560  ldr      x2, [x8]
006B1F564  ldrb     w8, [x2, #0x53]
006B1F568  tbnz     w8, #5, #0x6b1f574
006B1F56C  str      w20, [x19, #0x3c]
006B1F570  b        #0x6b1f584 ; 
006B1F574  ldr      x8, [x2, #0x60]
006B1F578  mov      x0, x19
006B1F57C  mov      w1, w20
006B1F580  blr      x8
006B1F584  mov      x0, x19
006B1F588  mov      x1, xzr
006B1F58C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1F590  adrp     x21, #0x959f000
006B1F594  ldrb     w8, [x21, #0xa4c]
006B1F598  mov      w20, w0
006B1F59C  cbnz     w8, #0x6b1f5b4
006B1F5A0  adrp     x0, #0x8f3f000
006B1F5A4  ldr      x0, [x0, #0x760]
006B1F5A8  bl       #0x382bd14 ; 
006B1F5AC  mov      w8, #1
006B1F5B0  strb     w8, [x21, #0xa4c]
006B1F5B4  adrp     x8, #0x8f3f000
006B1F5B8  ldr      x8, [x8, #0x760]
006B1F5BC  ldr      x2, [x8]
006B1F5C0  ldrb     w8, [x2, #0x53]
006B1F5C4  tbnz     w8, #5, #0x6b1f5d0
006B1F5C8  str      w20, [x19, #0x40]
006B1F5CC  b        #0x6b1f5e0 ; 
006B1F5D0  ldr      x8, [x2, #0x60]
006B1F5D4  mov      x0, x19
006B1F5D8  mov      w1, w20
006B1F5DC  blr      x8
006B1F5E0  mov      x0, x19
006B1F5E4  mov      x1, xzr
006B1F5E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1F5EC  adrp     x21, #0x959f000
006B1F5F0  ldrb     w8, [x21, #0xa4d]
006B1F5F4  mov      w20, w0
006B1F5F8  cbnz     w8, #0x6b1f610
006B1F5FC  adrp     x0, #0x8f3f000
006B1F600  ldr      x0, [x0, #0x770]
006B1F604  bl       #0x382bd14 ; 
006B1F608  mov      w8, #1
006B1F60C  strb     w8, [x21, #0xa4d]
006B1F610  adrp     x8, #0x8f3f000
006B1F614  ldr      x8, [x8, #0x770]
006B1F618  ldr      x2, [x8]
006B1F61C  ldrb     w8, [x2, #0x53]
006B1F620  tbnz     w8, #5, #0x6b1f62c
006B1F624  str      w20, [x19, #0x44]
006B1F628  b        #0x6b1f63c ; 
006B1F62C  ldr      x8, [x2, #0x60]
006B1F630  mov      x0, x19
006B1F634  mov      w1, w20
006B1F638  blr      x8
006B1F63C  ldp      x20, x19, [sp, #0x10]
006B1F640  mov      w0, #1
006B1F644  ldp      x30, x21, [sp], #0x20
006B1F648  ret      

