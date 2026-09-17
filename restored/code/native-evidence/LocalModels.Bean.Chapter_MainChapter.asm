; LocalModels.Bean.Chapter_MainChapter$$readImpl
; RVA 0x68AE14C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068AE14C  stp      x30, x21, [sp, #-0x20]!
0068AE150  stp      x20, x19, [sp, #0x10]
0068AE154  adrp     x20, #0x959c000
0068AE158  adrp     x21, #0x8f26000
0068AE15C  ldrb     w8, [x20, #0x52]
0068AE160  ldr      x21, [x21, #0xe80]
0068AE164  mov      x19, x0
0068AE168  tbnz     w8, #0, #0x68ae180
0068AE16C  adrp     x0, #0x8f26000
0068AE170  ldr      x0, [x0, #0xe80]
0068AE174  bl       #0x382bd14 ; 
0068AE178  mov      w8, #1
0068AE17C  strb     w8, [x20, #0x52]
0068AE180  ldr      x1, [x21]
0068AE184  ldrb     w8, [x1, #0x53]
0068AE188  tbnz     w8, #5, #0x68ae1d8
0068AE18C  mov      x0, x19
0068AE190  mov      x1, xzr
0068AE194  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AE198  adrp     x21, #0x959c000
0068AE19C  ldrb     w8, [x21, #0x595]
0068AE1A0  mov      w20, w0
0068AE1A4  cbnz     w8, #0x68ae1bc
0068AE1A8  adrp     x0, #0x8f26000
0068AE1AC  ldr      x0, [x0, #0xad0]
0068AE1B0  bl       #0x382bd14 ; 
0068AE1B4  mov      w8, #1
0068AE1B8  strb     w8, [x21, #0x595]
0068AE1BC  adrp     x8, #0x8f26000
0068AE1C0  ldr      x8, [x8, #0xad0]
0068AE1C4  ldr      x2, [x8]
0068AE1C8  ldrb     w8, [x2, #0x53]
0068AE1CC  tbnz     w8, #5, #0x68ae1ec
0068AE1D0  str      w20, [x19, #0x20]
0068AE1D4  b        #0x68ae1fc ; 
0068AE1D8  ldr      x2, [x1, #0x60]
0068AE1DC  mov      x0, x19
0068AE1E0  ldp      x20, x19, [sp, #0x10]
0068AE1E4  ldp      x30, x21, [sp], #0x20
0068AE1E8  br       x2
0068AE1EC  ldr      x8, [x2, #0x60]
0068AE1F0  mov      x0, x19
0068AE1F4  mov      w1, w20
0068AE1F8  blr      x8
0068AE1FC  mov      x0, x19
0068AE200  mov      x1, xzr
0068AE204  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068AE208  adrp     x21, #0x959c000
0068AE20C  ldrb     w8, [x21, #0x596]
0068AE210  mov      x20, x0
0068AE214  cbnz     w8, #0x68ae22c
0068AE218  adrp     x0, #0x8f26000
0068AE21C  ldr      x0, [x0, #0xae0]
0068AE220  bl       #0x382bd14 ; 
0068AE224  mov      w8, #1
0068AE228  strb     w8, [x21, #0x596]
0068AE22C  adrp     x8, #0x8f26000
0068AE230  ldr      x8, [x8, #0xae0]
0068AE234  ldr      x2, [x8]
0068AE238  ldrb     w8, [x2, #0x53]
0068AE23C  tbnz     w8, #5, #0x68ae254
0068AE240  mov      x0, x19
0068AE244  str      x20, [x0, #0x28]!
0068AE248  mov      x1, x20
0068AE24C  bl       #0x382bcb8 ; 
0068AE250  b        #0x68ae264 ; 
0068AE254  ldr      x8, [x2, #0x60]
0068AE258  mov      x0, x19
0068AE25C  mov      x1, x20
0068AE260  blr      x8
0068AE264  mov      x0, x19
0068AE268  mov      x1, xzr
0068AE26C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AE270  adrp     x21, #0x959c000
0068AE274  ldrb     w8, [x21, #0x597]
0068AE278  mov      w20, w0
0068AE27C  cbnz     w8, #0x68ae294
0068AE280  adrp     x0, #0x8f26000
0068AE284  ldr      x0, [x0, #0xaf0]
0068AE288  bl       #0x382bd14 ; 
0068AE28C  mov      w8, #1
0068AE290  strb     w8, [x21, #0x597]
0068AE294  adrp     x8, #0x8f26000
0068AE298  ldr      x8, [x8, #0xaf0]
0068AE29C  ldr      x2, [x8]
0068AE2A0  ldrb     w8, [x2, #0x53]
0068AE2A4  tbnz     w8, #5, #0x68ae2b0
0068AE2A8  str      w20, [x19, #0x30]
0068AE2AC  b        #0x68ae2c0 ; 
0068AE2B0  ldr      x8, [x2, #0x60]
0068AE2B4  mov      x0, x19
0068AE2B8  mov      w1, w20
0068AE2BC  blr      x8
0068AE2C0  mov      x0, x19
0068AE2C4  mov      x1, xzr
0068AE2C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AE2CC  adrp     x21, #0x959c000
0068AE2D0  ldrb     w8, [x21, #0x598]
0068AE2D4  mov      w20, w0
0068AE2D8  cbnz     w8, #0x68ae2f0
0068AE2DC  adrp     x0, #0x8f26000
0068AE2E0  ldr      x0, [x0, #0xb00]
0068AE2E4  bl       #0x382bd14 ; 
0068AE2E8  mov      w8, #1
0068AE2EC  strb     w8, [x21, #0x598]
0068AE2F0  adrp     x8, #0x8f26000
0068AE2F4  ldr      x8, [x8, #0xb00]
0068AE2F8  ldr      x2, [x8]
0068AE2FC  ldrb     w8, [x2, #0x53]
0068AE300  tbnz     w8, #5, #0x68ae30c
0068AE304  str      w20, [x19, #0x34]
0068AE308  b        #0x68ae31c ; 
0068AE30C  ldr      x8, [x2, #0x60]
0068AE310  mov      x0, x19
0068AE314  mov      w1, w20
0068AE318  blr      x8
0068AE31C  mov      x0, x19
0068AE320  mov      x1, xzr
0068AE324  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AE328  adrp     x21, #0x959c000
0068AE32C  ldrb     w8, [x21, #0x599]
0068AE330  mov      w20, w0
0068AE334  cbnz     w8, #0x68ae34c
0068AE338  adrp     x0, #0x8f26000
0068AE33C  ldr      x0, [x0, #0xb10]
0068AE340  bl       #0x382bd14 ; 
0068AE344  mov      w8, #1
0068AE348  strb     w8, [x21, #0x599]
0068AE34C  adrp     x8, #0x8f26000
0068AE350  ldr      x8, [x8, #0xb10]
0068AE354  ldr      x2, [x8]
0068AE358  ldrb     w8, [x2, #0x53]
0068AE35C  tbnz     w8, #5, #0x68ae368
0068AE360  str      w20, [x19, #0x38]
0068AE364  b        #0x68ae378 ; 
0068AE368  ldr      x8, [x2, #0x60]
0068AE36C  mov      x0, x19
0068AE370  mov      w1, w20
0068AE374  blr      x8
0068AE378  mov      x0, x19
0068AE37C  mov      x1, xzr
0068AE380  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AE384  adrp     x21, #0x959c000
0068AE388  ldrb     w8, [x21, #0x59a]
0068AE38C  mov      x20, x0
0068AE390  cbnz     w8, #0x68ae3a8
0068AE394  adrp     x0, #0x8f26000
0068AE398  ldr      x0, [x0, #0xb20]
0068AE39C  bl       #0x382bd14 ; 
0068AE3A0  mov      w8, #1
0068AE3A4  strb     w8, [x21, #0x59a]
0068AE3A8  adrp     x8, #0x8f26000
0068AE3AC  ldr      x8, [x8, #0xb20]
0068AE3B0  ldr      x2, [x8]
0068AE3B4  ldrb     w8, [x2, #0x53]
0068AE3B8  tbnz     w8, #5, #0x68ae3d0
0068AE3BC  mov      x0, x19
0068AE3C0  str      x20, [x0, #0x40]!
0068AE3C4  mov      x1, x20
0068AE3C8  bl       #0x382bcb8 ; 
0068AE3CC  b        #0x68ae3e0 ; 
0068AE3D0  ldr      x8, [x2, #0x60]
0068AE3D4  mov      x0, x19
0068AE3D8  mov      x1, x20
0068AE3DC  blr      x8
0068AE3E0  mov      x0, x19
0068AE3E4  mov      x1, xzr
0068AE3E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AE3EC  adrp     x21, #0x959c000
0068AE3F0  ldrb     w8, [x21, #0x59b]
0068AE3F4  mov      w20, w0
0068AE3F8  cbnz     w8, #0x68ae410
0068AE3FC  adrp     x0, #0x8f26000
0068AE400  ldr      x0, [x0, #0xb30]
0068AE404  bl       #0x382bd14 ; 
0068AE408  mov      w8, #1
0068AE40C  strb     w8, [x21, #0x59b]
0068AE410  adrp     x8, #0x8f26000
0068AE414  ldr      x8, [x8, #0xb30]
0068AE418  ldr      x2, [x8]
0068AE41C  ldrb     w8, [x2, #0x53]
0068AE420  tbnz     w8, #5, #0x68ae42c
0068AE424  str      w20, [x19, #0x48]
0068AE428  b        #0x68ae43c ; 
0068AE42C  ldr      x8, [x2, #0x60]
0068AE430  mov      x0, x19
0068AE434  mov      w1, w20
0068AE438  blr      x8
0068AE43C  mov      x0, x19
0068AE440  mov      x1, xzr
0068AE444  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AE448  adrp     x21, #0x959c000
0068AE44C  ldrb     w8, [x21, #0x59c]
0068AE450  mov      w20, w0
0068AE454  cbnz     w8, #0x68ae46c
0068AE458  adrp     x0, #0x8f26000
0068AE45C  ldr      x0, [x0, #0xb40]
0068AE460  bl       #0x382bd14 ; 
0068AE464  mov      w8, #1
0068AE468  strb     w8, [x21, #0x59c]
0068AE46C  adrp     x8, #0x8f26000
0068AE470  ldr      x8, [x8, #0xb40]
0068AE474  ldr      x2, [x8]
0068AE478  ldrb     w8, [x2, #0x53]
0068AE47C  tbnz     w8, #5, #0x68ae488
0068AE480  str      w20, [x19, #0x4c]
0068AE484  b        #0x68ae498 ; 
0068AE488  ldr      x8, [x2, #0x60]
0068AE48C  mov      x0, x19
0068AE490  mov      w1, w20
0068AE494  blr      x8
0068AE498  mov      x0, x19
0068AE49C  mov      x1, xzr
0068AE4A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AE4A4  adrp     x21, #0x959c000
0068AE4A8  ldrb     w8, [x21, #0x59d]
0068AE4AC  mov      w20, w0
0068AE4B0  cbnz     w8, #0x68ae4c8
0068AE4B4  adrp     x0, #0x8f26000
0068AE4B8  ldr      x0, [x0, #0xb50]
0068AE4BC  bl       #0x382bd14 ; 
0068AE4C0  mov      w8, #1
0068AE4C4  strb     w8, [x21, #0x59d]
0068AE4C8  adrp     x8, #0x8f26000
0068AE4CC  ldr      x8, [x8, #0xb50]
0068AE4D0  ldr      x2, [x8]
0068AE4D4  ldrb     w8, [x2, #0x53]
0068AE4D8  tbnz     w8, #5, #0x68ae4e4
0068AE4DC  str      w20, [x19, #0x50]
0068AE4E0  b        #0x68ae4f4 ; 
0068AE4E4  ldr      x8, [x2, #0x60]
0068AE4E8  mov      x0, x19
0068AE4EC  mov      w1, w20
0068AE4F0  blr      x8
0068AE4F4  mov      x0, x19
0068AE4F8  mov      x1, xzr
0068AE4FC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068AE500  adrp     x21, #0x959c000
0068AE504  ldrb     w8, [x21, #0x59e]
0068AE508  mov      x20, x0
0068AE50C  cbnz     w8, #0x68ae524
0068AE510  adrp     x0, #0x8f26000
0068AE514  ldr      x0, [x0, #0xb60]
0068AE518  bl       #0x382bd14 ; 
0068AE51C  mov      w8, #1
0068AE520  strb     w8, [x21, #0x59e]
0068AE524  adrp     x8, #0x8f26000
0068AE528  ldr      x8, [x8, #0xb60]
0068AE52C  ldr      x2, [x8]
0068AE530  ldrb     w8, [x2, #0x53]
0068AE534  tbnz     w8, #5, #0x68ae540
0068AE538  str      x20, [x19, #0x58]
0068AE53C  b        #0x68ae550 ; 
0068AE540  ldr      x8, [x2, #0x60]
0068AE544  mov      x0, x19
0068AE548  mov      x1, x20
0068AE54C  blr      x8
0068AE550  mov      x0, x19
0068AE554  mov      x1, xzr
0068AE558  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068AE55C  adrp     x21, #0x959c000
0068AE560  ldrb     w8, [x21, #0x59f]
0068AE564  mov      x20, x0
0068AE568  cbnz     w8, #0x68ae580
0068AE56C  adrp     x0, #0x8f26000
0068AE570  ldr      x0, [x0, #0xb70]
0068AE574  bl       #0x382bd14 ; 
0068AE578  mov      w8, #1
0068AE57C  strb     w8, [x21, #0x59f]
0068AE580  adrp     x8, #0x8f26000
0068AE584  ldr      x8, [x8, #0xb70]
0068AE588  ldr      x2, [x8]
0068AE58C  ldrb     w8, [x2, #0x53]
0068AE590  tbnz     w8, #5, #0x68ae59c
0068AE594  str      x20, [x19, #0x60]
0068AE598  b        #0x68ae5ac ; 
0068AE59C  ldr      x8, [x2, #0x60]
0068AE5A0  mov      x0, x19
0068AE5A4  mov      x1, x20
0068AE5A8  blr      x8
0068AE5AC  mov      x0, x19
0068AE5B0  mov      x1, xzr
0068AE5B4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068AE5B8  adrp     x21, #0x959c000
0068AE5BC  ldrb     w8, [x21, #0x5a0]
0068AE5C0  mov      x20, x0
0068AE5C4  cbnz     w8, #0x68ae5dc
0068AE5C8  adrp     x0, #0x8f26000
0068AE5CC  ldr      x0, [x0, #0xb80]
0068AE5D0  bl       #0x382bd14 ; 
0068AE5D4  mov      w8, #1
0068AE5D8  strb     w8, [x21, #0x5a0]
0068AE5DC  adrp     x8, #0x8f26000
0068AE5E0  ldr      x8, [x8, #0xb80]
0068AE5E4  ldr      x2, [x8]
0068AE5E8  ldrb     w8, [x2, #0x53]
0068AE5EC  tbnz     w8, #5, #0x68ae5f8
0068AE5F0  str      x20, [x19, #0x68]
0068AE5F4  b        #0x68ae608 ; 
0068AE5F8  ldr      x8, [x2, #0x60]
0068AE5FC  mov      x0, x19
0068AE600  mov      x1, x20
0068AE604  blr      x8
0068AE608  mov      x0, x19
0068AE60C  mov      x1, xzr
0068AE610  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068AE614  adrp     x21, #0x959c000
0068AE618  ldrb     w8, [x21, #0x5a1]
0068AE61C  mov      x20, x0
0068AE620  cbnz     w8, #0x68ae638
0068AE624  adrp     x0, #0x8f26000
0068AE628  ldr      x0, [x0, #0xb90]
0068AE62C  bl       #0x382bd14 ; 
0068AE630  mov      w8, #1
0068AE634  strb     w8, [x21, #0x5a1]
0068AE638  adrp     x8, #0x8f26000
0068AE63C  ldr      x8, [x8, #0xb90]
0068AE640  ldr      x2, [x8]
0068AE644  ldrb     w8, [x2, #0x53]
0068AE648  tbnz     w8, #5, #0x68ae654
0068AE64C  str      x20, [x19, #0x70]
0068AE650  b        #0x68ae664 ; 
0068AE654  ldr      x8, [x2, #0x60]
0068AE658  mov      x0, x19
0068AE65C  mov      x1, x20
0068AE660  blr      x8
0068AE664  mov      x0, x19
0068AE668  mov      x1, xzr
0068AE66C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068AE670  adrp     x21, #0x959c000
0068AE674  ldrb     w8, [x21, #0x5a2]
0068AE678  mov      x20, x0
0068AE67C  cbnz     w8, #0x68ae694
0068AE680  adrp     x0, #0x8f26000
0068AE684  ldr      x0, [x0, #0xba0]
0068AE688  bl       #0x382bd14 ; 
0068AE68C  mov      w8, #1
0068AE690  strb     w8, [x21, #0x5a2]
0068AE694  adrp     x8, #0x8f26000
0068AE698  ldr      x8, [x8, #0xba0]
0068AE69C  ldr      x2, [x8]
0068AE6A0  ldrb     w8, [x2, #0x53]
0068AE6A4  tbnz     w8, #5, #0x68ae6b0
0068AE6A8  str      x20, [x19, #0x78]
0068AE6AC  b        #0x68ae6c0 ; 
0068AE6B0  ldr      x8, [x2, #0x60]
0068AE6B4  mov      x0, x19
0068AE6B8  mov      x1, x20
0068AE6BC  blr      x8
0068AE6C0  mov      x0, x19
0068AE6C4  mov      x1, xzr
0068AE6C8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068AE6CC  adrp     x21, #0x959c000
0068AE6D0  ldrb     w8, [x21, #0x5a3]
0068AE6D4  mov      x20, x0
0068AE6D8  cbnz     w8, #0x68ae6f0
0068AE6DC  adrp     x0, #0x8f26000
0068AE6E0  ldr      x0, [x0, #0xbb0]
0068AE6E4  bl       #0x382bd14 ; 
0068AE6E8  mov      w8, #1
0068AE6EC  strb     w8, [x21, #0x5a3]
0068AE6F0  adrp     x8, #0x8f26000
0068AE6F4  ldr      x8, [x8, #0xbb0]
0068AE6F8  ldr      x2, [x8]
0068AE6FC  ldrb     w8, [x2, #0x53]
0068AE700  tbnz     w8, #5, #0x68ae70c
0068AE704  str      x20, [x19, #0x80]
0068AE708  b        #0x68ae71c ; 
0068AE70C  ldr      x8, [x2, #0x60]
0068AE710  mov      x0, x19
0068AE714  mov      x1, x20
0068AE718  blr      x8
0068AE71C  mov      x0, x19
0068AE720  mov      x1, xzr
0068AE724  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AE728  adrp     x21, #0x959c000
0068AE72C  ldrb     w8, [x21, #0x5a4]
0068AE730  mov      w20, w0
0068AE734  cbnz     w8, #0x68ae74c
0068AE738  adrp     x0, #0x8f26000
0068AE73C  ldr      x0, [x0, #0xbc0]
0068AE740  bl       #0x382bd14 ; 
0068AE744  mov      w8, #1
0068AE748  strb     w8, [x21, #0x5a4]
0068AE74C  adrp     x8, #0x8f26000
0068AE750  ldr      x8, [x8, #0xbc0]
0068AE754  ldr      x2, [x8]
0068AE758  ldrb     w8, [x2, #0x53]
0068AE75C  tbnz     w8, #5, #0x68ae768
0068AE760  str      w20, [x19, #0x88]
0068AE764  b        #0x68ae778 ; 
0068AE768  ldr      x8, [x2, #0x60]
0068AE76C  mov      x0, x19
0068AE770  mov      w1, w20
0068AE774  blr      x8
0068AE778  mov      x0, x19
0068AE77C  mov      x1, xzr
0068AE780  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AE784  adrp     x21, #0x959c000
0068AE788  ldrb     w8, [x21, #0x5a5]
0068AE78C  mov      w20, w0
0068AE790  cbnz     w8, #0x68ae7a8
0068AE794  adrp     x0, #0x8f26000
0068AE798  ldr      x0, [x0, #0xbd0]
0068AE79C  bl       #0x382bd14 ; 
0068AE7A0  mov      w8, #1
0068AE7A4  strb     w8, [x21, #0x5a5]
0068AE7A8  adrp     x8, #0x8f26000
0068AE7AC  ldr      x8, [x8, #0xbd0]
0068AE7B0  ldr      x2, [x8]
0068AE7B4  ldrb     w8, [x2, #0x53]
0068AE7B8  tbnz     w8, #5, #0x68ae7c4
0068AE7BC  str      w20, [x19, #0x8c]
0068AE7C0  b        #0x68ae7d4 ; 
0068AE7C4  ldr      x8, [x2, #0x60]
0068AE7C8  mov      x0, x19
0068AE7CC  mov      w1, w20
0068AE7D0  blr      x8
0068AE7D4  mov      x0, x19
0068AE7D8  mov      x1, xzr
0068AE7DC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AE7E0  adrp     x21, #0x959c000
0068AE7E4  ldrb     w8, [x21, #0x5a6]
0068AE7E8  mov      x20, x0
0068AE7EC  cbnz     w8, #0x68ae804
0068AE7F0  adrp     x0, #0x8f26000
0068AE7F4  ldr      x0, [x0, #0xbe0]
0068AE7F8  bl       #0x382bd14 ; 
0068AE7FC  mov      w8, #1
0068AE800  strb     w8, [x21, #0x5a6]
0068AE804  adrp     x8, #0x8f26000
0068AE808  ldr      x8, [x8, #0xbe0]
0068AE80C  ldr      x2, [x8]
0068AE810  ldrb     w8, [x2, #0x53]
0068AE814  tbnz     w8, #5, #0x68ae82c
0068AE818  mov      x0, x19
0068AE81C  str      x20, [x0, #0x90]!
0068AE820  mov      x1, x20
0068AE824  bl       #0x382bcb8 ; 
0068AE828  b        #0x68ae83c ; 
0068AE82C  ldr      x8, [x2, #0x60]
0068AE830  mov      x0, x19
0068AE834  mov      x1, x20
0068AE838  blr      x8
0068AE83C  mov      x0, x19
0068AE840  mov      x1, xzr
0068AE844  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AE848  adrp     x21, #0x959c000
0068AE84C  ldrb     w8, [x21, #0x5a7]
0068AE850  mov      x20, x0
0068AE854  cbnz     w8, #0x68ae86c
0068AE858  adrp     x0, #0x8f26000
0068AE85C  ldr      x0, [x0, #0xbf0]
0068AE860  bl       #0x382bd14 ; 
0068AE864  mov      w8, #1
0068AE868  strb     w8, [x21, #0x5a7]
0068AE86C  adrp     x8, #0x8f26000
0068AE870  ldr      x8, [x8, #0xbf0]
0068AE874  ldr      x2, [x8]
0068AE878  ldrb     w8, [x2, #0x53]
0068AE87C  tbnz     w8, #5, #0x68ae894
0068AE880  mov      x0, x19
0068AE884  str      x20, [x0, #0x98]!
0068AE888  mov      x1, x20
0068AE88C  bl       #0x382bcb8 ; 
0068AE890  b        #0x68ae8a4 ; 
0068AE894  ldr      x8, [x2, #0x60]
0068AE898  mov      x0, x19
0068AE89C  mov      x1, x20
0068AE8A0  blr      x8
0068AE8A4  mov      x0, x19
0068AE8A8  mov      x1, xzr
0068AE8AC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AE8B0  adrp     x21, #0x959c000
0068AE8B4  ldrb     w8, [x21, #0x5a8]
0068AE8B8  mov      x20, x0
0068AE8BC  cbnz     w8, #0x68ae8d4
0068AE8C0  adrp     x0, #0x8f26000
0068AE8C4  ldr      x0, [x0, #0xc00]
0068AE8C8  bl       #0x382bd14 ; 
0068AE8CC  mov      w8, #1
0068AE8D0  strb     w8, [x21, #0x5a8]
0068AE8D4  adrp     x8, #0x8f26000
0068AE8D8  ldr      x8, [x8, #0xc00]
0068AE8DC  ldr      x2, [x8]
0068AE8E0  ldrb     w8, [x2, #0x53]
0068AE8E4  tbnz     w8, #5, #0x68ae8fc
0068AE8E8  mov      x0, x19
0068AE8EC  str      x20, [x0, #0xa0]!
0068AE8F0  mov      x1, x20
0068AE8F4  bl       #0x382bcb8 ; 
0068AE8F8  b        #0x68ae90c ; 
0068AE8FC  ldr      x8, [x2, #0x60]
0068AE900  mov      x0, x19
0068AE904  mov      x1, x20
0068AE908  blr      x8
0068AE90C  mov      x0, x19
0068AE910  mov      x1, xzr
0068AE914  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AE918  adrp     x21, #0x959c000
0068AE91C  ldrb     w8, [x21, #0x5a9]
0068AE920  mov      w20, w0
0068AE924  cbnz     w8, #0x68ae93c
0068AE928  adrp     x0, #0x8f26000
0068AE92C  ldr      x0, [x0, #0xc10]
0068AE930  bl       #0x382bd14 ; 
0068AE934  mov      w8, #1
0068AE938  strb     w8, [x21, #0x5a9]
0068AE93C  adrp     x8, #0x8f26000
0068AE940  ldr      x8, [x8, #0xc10]
0068AE944  ldr      x2, [x8]
0068AE948  ldrb     w8, [x2, #0x53]
0068AE94C  tbnz     w8, #5, #0x68ae958
0068AE950  str      w20, [x19, #0xa8]
0068AE954  b        #0x68ae968 ; 
0068AE958  ldr      x8, [x2, #0x60]
0068AE95C  mov      x0, x19
0068AE960  mov      w1, w20
0068AE964  blr      x8
0068AE968  mov      x0, x19
0068AE96C  mov      x1, xzr
0068AE970  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068AE974  adrp     x21, #0x959c000
0068AE978  ldrb     w8, [x21, #0x5aa]
0068AE97C  mov      x20, x0
0068AE980  cbnz     w8, #0x68ae998
0068AE984  adrp     x0, #0x8f26000
0068AE988  ldr      x0, [x0, #0xc20]
0068AE98C  bl       #0x382bd14 ; 
0068AE990  mov      w8, #1
0068AE994  strb     w8, [x21, #0x5aa]
0068AE998  adrp     x8, #0x8f26000
0068AE99C  ldr      x8, [x8, #0xc20]
0068AE9A0  ldr      x2, [x8]
0068AE9A4  ldrb     w8, [x2, #0x53]
0068AE9A8  tbnz     w8, #5, #0x68ae9b4
0068AE9AC  str      x20, [x19, #0xb0]
0068AE9B0  b        #0x68ae9c4 ; 
0068AE9B4  ldr      x8, [x2, #0x60]
0068AE9B8  mov      x0, x19
0068AE9BC  mov      x1, x20
0068AE9C0  blr      x8
0068AE9C4  mov      x0, x19
0068AE9C8  mov      x1, xzr
0068AE9CC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068AE9D0  adrp     x21, #0x959c000
0068AE9D4  ldrb     w8, [x21, #0x5ab]
0068AE9D8  mov      x20, x0
0068AE9DC  cbnz     w8, #0x68ae9f4
0068AE9E0  adrp     x0, #0x8f26000
0068AE9E4  ldr      x0, [x0, #0xc30]
0068AE9E8  bl       #0x382bd14 ; 
0068AE9EC  mov      w8, #1
0068AE9F0  strb     w8, [x21, #0x5ab]
0068AE9F4  adrp     x8, #0x8f26000
0068AE9F8  ldr      x8, [x8, #0xc30]
0068AE9FC  ldr      x2, [x8]
0068AEA00  ldrb     w8, [x2, #0x53]
0068AEA04  tbnz     w8, #5, #0x68aea10
0068AEA08  str      x20, [x19, #0xb8]
0068AEA0C  b        #0x68aea20 ; 
0068AEA10  ldr      x8, [x2, #0x60]
0068AEA14  mov      x0, x19
0068AEA18  mov      x1, x20
0068AEA1C  blr      x8
0068AEA20  mov      x0, x19
0068AEA24  mov      x1, xzr
0068AEA28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AEA2C  adrp     x21, #0x959c000
0068AEA30  ldrb     w8, [x21, #0x5ac]
0068AEA34  mov      w20, w0
0068AEA38  cbnz     w8, #0x68aea50
0068AEA3C  adrp     x0, #0x8f26000
0068AEA40  ldr      x0, [x0, #0xc40]
0068AEA44  bl       #0x382bd14 ; 
0068AEA48  mov      w8, #1
0068AEA4C  strb     w8, [x21, #0x5ac]
0068AEA50  adrp     x8, #0x8f26000
0068AEA54  ldr      x8, [x8, #0xc40]
0068AEA58  ldr      x2, [x8]
0068AEA5C  ldrb     w8, [x2, #0x53]
0068AEA60  tbnz     w8, #5, #0x68aea6c
0068AEA64  str      w20, [x19, #0xc0]
0068AEA68  b        #0x68aea7c ; 
0068AEA6C  ldr      x8, [x2, #0x60]
0068AEA70  mov      x0, x19
0068AEA74  mov      w1, w20
0068AEA78  blr      x8
0068AEA7C  mov      x0, x19
0068AEA80  mov      x1, xzr
0068AEA84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AEA88  adrp     x21, #0x959c000
0068AEA8C  ldrb     w8, [x21, #0x5ad]
0068AEA90  mov      w20, w0
0068AEA94  cbnz     w8, #0x68aeaac
0068AEA98  adrp     x0, #0x8f26000
0068AEA9C  ldr      x0, [x0, #0xc50]
0068AEAA0  bl       #0x382bd14 ; 
0068AEAA4  mov      w8, #1
0068AEAA8  strb     w8, [x21, #0x5ad]
0068AEAAC  adrp     x8, #0x8f26000
0068AEAB0  ldr      x8, [x8, #0xc50]
0068AEAB4  ldr      x2, [x8]
0068AEAB8  ldrb     w8, [x2, #0x53]
0068AEABC  tbnz     w8, #5, #0x68aeac8
0068AEAC0  str      w20, [x19, #0xc4]
0068AEAC4  b        #0x68aead8 ; 
0068AEAC8  ldr      x8, [x2, #0x60]
0068AEACC  mov      x0, x19
0068AEAD0  mov      w1, w20
0068AEAD4  blr      x8
0068AEAD8  mov      x0, x19
0068AEADC  mov      x1, xzr
0068AEAE0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AEAE4  adrp     x21, #0x959c000
0068AEAE8  ldrb     w8, [x21, #0x5ae]
0068AEAEC  mov      x20, x0
0068AEAF0  cbnz     w8, #0x68aeb08
0068AEAF4  adrp     x0, #0x8f26000
0068AEAF8  ldr      x0, [x0, #0xc60]
0068AEAFC  bl       #0x382bd14 ; 
0068AEB00  mov      w8, #1
0068AEB04  strb     w8, [x21, #0x5ae]
0068AEB08  adrp     x8, #0x8f26000
0068AEB0C  ldr      x8, [x8, #0xc60]
0068AEB10  ldr      x2, [x8]
0068AEB14  ldrb     w8, [x2, #0x53]
0068AEB18  tbnz     w8, #5, #0x68aeb30
0068AEB1C  mov      x0, x19
0068AEB20  str      x20, [x0, #0xc8]!
0068AEB24  mov      x1, x20
0068AEB28  bl       #0x382bcb8 ; 
0068AEB2C  b        #0x68aeb40 ; 
0068AEB30  ldr      x8, [x2, #0x60]
0068AEB34  mov      x0, x19
0068AEB38  mov      x1, x20
0068AEB3C  blr      x8
0068AEB40  mov      x0, x19
0068AEB44  mov      x1, xzr
0068AEB48  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AEB4C  adrp     x21, #0x959c000
0068AEB50  ldrb     w8, [x21, #0x5af]
0068AEB54  mov      x20, x0
0068AEB58  cbnz     w8, #0x68aeb70
0068AEB5C  adrp     x0, #0x8f26000
0068AEB60  ldr      x0, [x0, #0xc70]
0068AEB64  bl       #0x382bd14 ; 
0068AEB68  mov      w8, #1
0068AEB6C  strb     w8, [x21, #0x5af]
0068AEB70  adrp     x8, #0x8f26000
0068AEB74  ldr      x8, [x8, #0xc70]
0068AEB78  ldr      x2, [x8]
0068AEB7C  ldrb     w8, [x2, #0x53]
0068AEB80  tbnz     w8, #5, #0x68aeb98
0068AEB84  mov      x0, x19
0068AEB88  str      x20, [x0, #0xd0]!
0068AEB8C  mov      x1, x20
0068AEB90  bl       #0x382bcb8 ; 
0068AEB94  b        #0x68aeba8 ; 
0068AEB98  ldr      x8, [x2, #0x60]
0068AEB9C  mov      x0, x19
0068AEBA0  mov      x1, x20
0068AEBA4  blr      x8
0068AEBA8  mov      x0, x19
0068AEBAC  mov      x1, xzr
0068AEBB0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AEBB4  adrp     x21, #0x959c000
0068AEBB8  ldrb     w8, [x21, #0x5b0]
0068AEBBC  mov      x20, x0
0068AEBC0  cbnz     w8, #0x68aebd8
0068AEBC4  adrp     x0, #0x8f26000
0068AEBC8  ldr      x0, [x0, #0xc80]
0068AEBCC  bl       #0x382bd14 ; 
0068AEBD0  mov      w8, #1
0068AEBD4  strb     w8, [x21, #0x5b0]
0068AEBD8  adrp     x8, #0x8f26000
0068AEBDC  ldr      x8, [x8, #0xc80]
0068AEBE0  ldr      x2, [x8]
0068AEBE4  ldrb     w8, [x2, #0x53]
0068AEBE8  tbnz     w8, #5, #0x68aec00
0068AEBEC  mov      x0, x19
0068AEBF0  str      x20, [x0, #0xd8]!
0068AEBF4  mov      x1, x20
0068AEBF8  bl       #0x382bcb8 ; 
0068AEBFC  b        #0x68aec10 ; 
0068AEC00  ldr      x8, [x2, #0x60]
0068AEC04  mov      x0, x19
0068AEC08  mov      x1, x20
0068AEC0C  blr      x8
0068AEC10  mov      x0, x19
0068AEC14  mov      x1, xzr
0068AEC18  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AEC1C  adrp     x21, #0x959c000
0068AEC20  ldrb     w8, [x21, #0x5b1]
0068AEC24  mov      x20, x0
0068AEC28  cbnz     w8, #0x68aec40
0068AEC2C  adrp     x0, #0x8f26000
0068AEC30  ldr      x0, [x0, #0xc90]
0068AEC34  bl       #0x382bd14 ; 
0068AEC38  mov      w8, #1
0068AEC3C  strb     w8, [x21, #0x5b1]
0068AEC40  adrp     x8, #0x8f26000
0068AEC44  ldr      x8, [x8, #0xc90]
0068AEC48  ldr      x2, [x8]
0068AEC4C  ldrb     w8, [x2, #0x53]
0068AEC50  tbnz     w8, #5, #0x68aec68
0068AEC54  mov      x0, x19
0068AEC58  str      x20, [x0, #0xe0]!
0068AEC5C  mov      x1, x20
0068AEC60  bl       #0x382bcb8 ; 
0068AEC64  b        #0x68aec78 ; 
0068AEC68  ldr      x8, [x2, #0x60]
0068AEC6C  mov      x0, x19
0068AEC70  mov      x1, x20
0068AEC74  blr      x8
0068AEC78  mov      x0, x19
0068AEC7C  mov      x1, xzr
0068AEC80  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AEC84  adrp     x21, #0x959c000
0068AEC88  ldrb     w8, [x21, #0x5b2]
0068AEC8C  mov      x20, x0
0068AEC90  cbnz     w8, #0x68aeca8
0068AEC94  adrp     x0, #0x8f26000
0068AEC98  ldr      x0, [x0, #0xca0]
0068AEC9C  bl       #0x382bd14 ; 
0068AECA0  mov      w8, #1
0068AECA4  strb     w8, [x21, #0x5b2]
0068AECA8  adrp     x8, #0x8f26000
0068AECAC  ldr      x8, [x8, #0xca0]
0068AECB0  ldr      x2, [x8]
0068AECB4  ldrb     w8, [x2, #0x53]
0068AECB8  tbnz     w8, #5, #0x68aecd0
0068AECBC  mov      x0, x19
0068AECC0  str      x20, [x0, #0xe8]!
0068AECC4  mov      x1, x20
0068AECC8  bl       #0x382bcb8 ; 
0068AECCC  b        #0x68aece0 ; 
0068AECD0  ldr      x8, [x2, #0x60]
0068AECD4  mov      x0, x19
0068AECD8  mov      x1, x20
0068AECDC  blr      x8
0068AECE0  mov      x0, x19
0068AECE4  mov      x1, xzr
0068AECE8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068AECEC  adrp     x21, #0x959c000
0068AECF0  ldrb     w8, [x21, #0x5b3]
0068AECF4  mov      x20, x0
0068AECF8  cbnz     w8, #0x68aed10
0068AECFC  adrp     x0, #0x8f26000
0068AED00  ldr      x0, [x0, #0xcb0]
0068AED04  bl       #0x382bd14 ; 
0068AED08  mov      w8, #1
0068AED0C  strb     w8, [x21, #0x5b3]
0068AED10  adrp     x8, #0x8f26000
0068AED14  ldr      x8, [x8, #0xcb0]
0068AED18  ldr      x2, [x8]
0068AED1C  ldrb     w8, [x2, #0x53]
0068AED20  tbnz     w8, #5, #0x68aed38
0068AED24  mov      x0, x19
0068AED28  str      x20, [x0, #0xf0]!
0068AED2C  mov      x1, x20
0068AED30  bl       #0x382bcb8 ; 
0068AED34  b        #0x68aed48 ; 
0068AED38  ldr      x8, [x2, #0x60]
0068AED3C  mov      x0, x19
0068AED40  mov      x1, x20
0068AED44  blr      x8
0068AED48  mov      x0, x19
0068AED4C  mov      x1, xzr
0068AED50  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068AED54  adrp     x21, #0x959c000
0068AED58  ldrb     w8, [x21, #0x5b4]
0068AED5C  mov      x20, x0
0068AED60  cbnz     w8, #0x68aed78
0068AED64  adrp     x0, #0x8f26000
0068AED68  ldr      x0, [x0, #0xcc0]
0068AED6C  bl       #0x382bd14 ; 
0068AED70  mov      w8, #1
0068AED74  strb     w8, [x21, #0x5b4]
0068AED78  adrp     x8, #0x8f26000
0068AED7C  ldr      x8, [x8, #0xcc0]
0068AED80  ldr      x2, [x8]
0068AED84  ldrb     w8, [x2, #0x53]
0068AED88  tbnz     w8, #5, #0x68aeda0
0068AED8C  mov      x0, x19
0068AED90  str      x20, [x0, #0xf8]!
0068AED94  mov      x1, x20
0068AED98  bl       #0x382bcb8 ; 
0068AED9C  b        #0x68aedb0 ; 
0068AEDA0  ldr      x8, [x2, #0x60]
0068AEDA4  mov      x0, x19
0068AEDA8  mov      x1, x20
0068AEDAC  blr      x8
0068AEDB0  mov      x0, x19
0068AEDB4  mov      x1, xzr
0068AEDB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AEDBC  adrp     x21, #0x959c000
0068AEDC0  ldrb     w8, [x21, #0x5b5]
0068AEDC4  mov      w20, w0
0068AEDC8  cbnz     w8, #0x68aede0
0068AEDCC  adrp     x0, #0x8f26000
0068AEDD0  ldr      x0, [x0, #0xcd0]
0068AEDD4  bl       #0x382bd14 ; 
0068AEDD8  mov      w8, #1
0068AEDDC  strb     w8, [x21, #0x5b5]
0068AEDE0  adrp     x8, #0x8f26000
0068AEDE4  ldr      x8, [x8, #0xcd0]
0068AEDE8  ldr      x2, [x8]
0068AEDEC  ldrb     w8, [x2, #0x53]
0068AEDF0  tbnz     w8, #5, #0x68aedfc
0068AEDF4  str      w20, [x19, #0x100]
0068AEDF8  b        #0x68aee0c ; 
0068AEDFC  ldr      x8, [x2, #0x60]
0068AEE00  mov      x0, x19
0068AEE04  mov      w1, w20
0068AEE08  blr      x8
0068AEE0C  mov      x0, x19
0068AEE10  mov      x1, xzr
0068AEE14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AEE18  adrp     x21, #0x959c000
0068AEE1C  ldrb     w8, [x21, #0x5b6]
0068AEE20  mov      w20, w0
0068AEE24  cbnz     w8, #0x68aee3c
0068AEE28  adrp     x0, #0x8f26000
0068AEE2C  ldr      x0, [x0, #0xce0]
0068AEE30  bl       #0x382bd14 ; 
0068AEE34  mov      w8, #1
0068AEE38  strb     w8, [x21, #0x5b6]
0068AEE3C  adrp     x8, #0x8f26000
0068AEE40  ldr      x8, [x8, #0xce0]
0068AEE44  ldr      x2, [x8]
0068AEE48  ldrb     w8, [x2, #0x53]
0068AEE4C  tbnz     w8, #5, #0x68aee58
0068AEE50  str      w20, [x19, #0x104]
0068AEE54  b        #0x68aee68 ; 
0068AEE58  ldr      x8, [x2, #0x60]
0068AEE5C  mov      x0, x19
0068AEE60  mov      w1, w20
0068AEE64  blr      x8
0068AEE68  mov      x0, x19
0068AEE6C  mov      x1, xzr
0068AEE70  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AEE74  adrp     x21, #0x959c000
0068AEE78  ldrb     w8, [x21, #0x5b7]
0068AEE7C  mov      w20, w0
0068AEE80  cbnz     w8, #0x68aee98
0068AEE84  adrp     x0, #0x8f26000
0068AEE88  ldr      x0, [x0, #0xcf0]
0068AEE8C  bl       #0x382bd14 ; 
0068AEE90  mov      w8, #1
0068AEE94  strb     w8, [x21, #0x5b7]
0068AEE98  adrp     x8, #0x8f26000
0068AEE9C  ldr      x8, [x8, #0xcf0]
0068AEEA0  ldr      x2, [x8]
0068AEEA4  ldrb     w8, [x2, #0x53]
0068AEEA8  tbnz     w8, #5, #0x68aeeb4
0068AEEAC  str      w20, [x19, #0x108]
0068AEEB0  b        #0x68aeec4 ; 
0068AEEB4  ldr      x8, [x2, #0x60]
0068AEEB8  mov      x0, x19
0068AEEBC  mov      w1, w20
0068AEEC0  blr      x8
0068AEEC4  mov      x0, x19
0068AEEC8  mov      x1, xzr
0068AEECC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AEED0  adrp     x21, #0x959c000
0068AEED4  ldrb     w8, [x21, #0x5b8]
0068AEED8  mov      w20, w0
0068AEEDC  cbnz     w8, #0x68aeef4
0068AEEE0  adrp     x0, #0x8f26000
0068AEEE4  ldr      x0, [x0, #0xd00]
0068AEEE8  bl       #0x382bd14 ; 
0068AEEEC  mov      w8, #1
0068AEEF0  strb     w8, [x21, #0x5b8]
0068AEEF4  adrp     x8, #0x8f26000
0068AEEF8  ldr      x8, [x8, #0xd00]
0068AEEFC  ldr      x2, [x8]
0068AEF00  ldrb     w8, [x2, #0x53]
0068AEF04  tbnz     w8, #5, #0x68aef10
0068AEF08  str      w20, [x19, #0x10c]
0068AEF0C  b        #0x68aef20 ; 
0068AEF10  ldr      x8, [x2, #0x60]
0068AEF14  mov      x0, x19
0068AEF18  mov      w1, w20
0068AEF1C  blr      x8
0068AEF20  mov      x0, x19
0068AEF24  mov      x1, xzr
0068AEF28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AEF2C  adrp     x21, #0x959c000
0068AEF30  ldrb     w8, [x21, #0x5b9]
0068AEF34  mov      w20, w0
0068AEF38  cbnz     w8, #0x68aef50
0068AEF3C  adrp     x0, #0x8f26000
0068AEF40  ldr      x0, [x0, #0xd10]
0068AEF44  bl       #0x382bd14 ; 
0068AEF48  mov      w8, #1
0068AEF4C  strb     w8, [x21, #0x5b9]
0068AEF50  adrp     x8, #0x8f26000
0068AEF54  ldr      x8, [x8, #0xd10]
0068AEF58  ldr      x2, [x8]
0068AEF5C  ldrb     w8, [x2, #0x53]
0068AEF60  tbnz     w8, #5, #0x68aef6c
0068AEF64  str      w20, [x19, #0x110]
0068AEF68  b        #0x68aef7c ; 
0068AEF6C  ldr      x8, [x2, #0x60]
0068AEF70  mov      x0, x19
0068AEF74  mov      w1, w20
0068AEF78  blr      x8
0068AEF7C  mov      x0, x19
0068AEF80  mov      x1, xzr
0068AEF84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AEF88  adrp     x21, #0x959c000
0068AEF8C  ldrb     w8, [x21, #0x5ba]
0068AEF90  mov      w20, w0
0068AEF94  cbnz     w8, #0x68aefac
0068AEF98  adrp     x0, #0x8f26000
0068AEF9C  ldr      x0, [x0, #0xd20]
0068AEFA0  bl       #0x382bd14 ; 
0068AEFA4  mov      w8, #1
0068AEFA8  strb     w8, [x21, #0x5ba]
0068AEFAC  adrp     x8, #0x8f26000
0068AEFB0  ldr      x8, [x8, #0xd20]
0068AEFB4  ldr      x2, [x8]
0068AEFB8  ldrb     w8, [x2, #0x53]
0068AEFBC  tbnz     w8, #5, #0x68aefc8
0068AEFC0  str      w20, [x19, #0x114]
0068AEFC4  b        #0x68aefd8 ; 
0068AEFC8  ldr      x8, [x2, #0x60]
0068AEFCC  mov      x0, x19
0068AEFD0  mov      w1, w20
0068AEFD4  blr      x8
0068AEFD8  mov      x0, x19
0068AEFDC  mov      x1, xzr
0068AEFE0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068AEFE4  adrp     x21, #0x959c000
0068AEFE8  ldrb     w8, [x21, #0x5bb]
0068AEFEC  mov      x20, x0
0068AEFF0  cbnz     w8, #0x68af008
0068AEFF4  adrp     x0, #0x8f26000
0068AEFF8  ldr      x0, [x0, #0xd30]
0068AEFFC  bl       #0x382bd14 ; 
0068AF000  mov      w8, #1
0068AF004  strb     w8, [x21, #0x5bb]
0068AF008  adrp     x8, #0x8f26000
0068AF00C  ldr      x8, [x8, #0xd30]
0068AF010  ldr      x2, [x8]
0068AF014  ldrb     w8, [x2, #0x53]
0068AF018  tbnz     w8, #5, #0x68af030
0068AF01C  add      x0, x19, #0x118
0068AF020  mov      x1, x20
0068AF024  str      x20, [x19, #0x118]
0068AF028  bl       #0x382bcb8 ; 
0068AF02C  b        #0x68af040 ; 
0068AF030  ldr      x8, [x2, #0x60]
0068AF034  mov      x0, x19
0068AF038  mov      x1, x20
0068AF03C  blr      x8
0068AF040  mov      x0, x19
0068AF044  mov      x1, xzr
0068AF048  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF04C  adrp     x21, #0x959c000
0068AF050  ldrb     w8, [x21, #0x5bc]
0068AF054  mov      x20, x0
0068AF058  cbnz     w8, #0x68af070
0068AF05C  adrp     x0, #0x8f26000
0068AF060  ldr      x0, [x0, #0xd40]
0068AF064  bl       #0x382bd14 ; 
0068AF068  mov      w8, #1
0068AF06C  strb     w8, [x21, #0x5bc]
0068AF070  adrp     x8, #0x8f26000
0068AF074  ldr      x8, [x8, #0xd40]
0068AF078  ldr      x2, [x8]
0068AF07C  ldrb     w8, [x2, #0x53]
0068AF080  tbnz     w8, #5, #0x68af098
0068AF084  add      x0, x19, #0x120
0068AF088  mov      x1, x20
0068AF08C  str      x20, [x19, #0x120]
0068AF090  bl       #0x382bcb8 ; 
0068AF094  b        #0x68af0a8 ; 
0068AF098  ldr      x8, [x2, #0x60]
0068AF09C  mov      x0, x19
0068AF0A0  mov      x1, x20
0068AF0A4  blr      x8
0068AF0A8  mov      x0, x19
0068AF0AC  mov      x1, xzr
0068AF0B0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF0B4  adrp     x21, #0x959c000
0068AF0B8  ldrb     w8, [x21, #0x5bd]
0068AF0BC  mov      x20, x0
0068AF0C0  cbnz     w8, #0x68af0d8
0068AF0C4  adrp     x0, #0x8f26000
0068AF0C8  ldr      x0, [x0, #0xd50]
0068AF0CC  bl       #0x382bd14 ; 
0068AF0D0  mov      w8, #1
0068AF0D4  strb     w8, [x21, #0x5bd]
0068AF0D8  adrp     x8, #0x8f26000
0068AF0DC  ldr      x8, [x8, #0xd50]
0068AF0E0  ldr      x2, [x8]
0068AF0E4  ldrb     w8, [x2, #0x53]
0068AF0E8  tbnz     w8, #5, #0x68af100
0068AF0EC  add      x0, x19, #0x128
0068AF0F0  mov      x1, x20
0068AF0F4  str      x20, [x19, #0x128]
0068AF0F8  bl       #0x382bcb8 ; 
0068AF0FC  b        #0x68af110 ; 
0068AF100  ldr      x8, [x2, #0x60]
0068AF104  mov      x0, x19
0068AF108  mov      x1, x20
0068AF10C  blr      x8
0068AF110  mov      x0, x19
0068AF114  mov      x1, xzr
0068AF118  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AF11C  adrp     x21, #0x959c000
0068AF120  ldrb     w8, [x21, #0x5be]
0068AF124  mov      w20, w0
0068AF128  cbnz     w8, #0x68af140
0068AF12C  adrp     x0, #0x8f26000
0068AF130  ldr      x0, [x0, #0xd60]
0068AF134  bl       #0x382bd14 ; 
0068AF138  mov      w8, #1
0068AF13C  strb     w8, [x21, #0x5be]
0068AF140  adrp     x8, #0x8f26000
0068AF144  ldr      x8, [x8, #0xd60]
0068AF148  ldr      x2, [x8]
0068AF14C  ldrb     w8, [x2, #0x53]
0068AF150  tbnz     w8, #5, #0x68af15c
0068AF154  str      w20, [x19, #0x130]
0068AF158  b        #0x68af16c ; 
0068AF15C  ldr      x8, [x2, #0x60]
0068AF160  mov      x0, x19
0068AF164  mov      w1, w20
0068AF168  blr      x8
0068AF16C  mov      x0, x19
0068AF170  mov      x1, xzr
0068AF174  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF178  adrp     x21, #0x959c000
0068AF17C  ldrb     w8, [x21, #0x5bf]
0068AF180  mov      x20, x0
0068AF184  cbnz     w8, #0x68af19c
0068AF188  adrp     x0, #0x8f26000
0068AF18C  ldr      x0, [x0, #0xd70]
0068AF190  bl       #0x382bd14 ; 
0068AF194  mov      w8, #1
0068AF198  strb     w8, [x21, #0x5bf]
0068AF19C  adrp     x8, #0x8f26000
0068AF1A0  ldr      x8, [x8, #0xd70]
0068AF1A4  ldr      x2, [x8]
0068AF1A8  ldrb     w8, [x2, #0x53]
0068AF1AC  tbnz     w8, #5, #0x68af1c4
0068AF1B0  add      x0, x19, #0x138
0068AF1B4  mov      x1, x20
0068AF1B8  str      x20, [x19, #0x138]
0068AF1BC  bl       #0x382bcb8 ; 
0068AF1C0  b        #0x68af1d4 ; 
0068AF1C4  ldr      x8, [x2, #0x60]
0068AF1C8  mov      x0, x19
0068AF1CC  mov      x1, x20
0068AF1D0  blr      x8
0068AF1D4  mov      x0, x19
0068AF1D8  mov      x1, xzr
0068AF1DC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068AF1E0  adrp     x21, #0x959c000
0068AF1E4  ldrb     w8, [x21, #0x5c0]
0068AF1E8  mov      x20, x0
0068AF1EC  cbnz     w8, #0x68af204
0068AF1F0  adrp     x0, #0x8f26000
0068AF1F4  ldr      x0, [x0, #0xd80]
0068AF1F8  bl       #0x382bd14 ; 
0068AF1FC  mov      w8, #1
0068AF200  strb     w8, [x21, #0x5c0]
0068AF204  adrp     x8, #0x8f26000
0068AF208  ldr      x8, [x8, #0xd80]
0068AF20C  ldr      x2, [x8]
0068AF210  ldrb     w8, [x2, #0x53]
0068AF214  tbnz     w8, #5, #0x68af22c
0068AF218  add      x0, x19, #0x140
0068AF21C  mov      x1, x20
0068AF220  str      x20, [x19, #0x140]
0068AF224  bl       #0x382bcb8 ; 
0068AF228  b        #0x68af23c ; 
0068AF22C  ldr      x8, [x2, #0x60]
0068AF230  mov      x0, x19
0068AF234  mov      x1, x20
0068AF238  blr      x8
0068AF23C  mov      x0, x19
0068AF240  mov      x1, xzr
0068AF244  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AF248  adrp     x21, #0x959c000
0068AF24C  ldrb     w8, [x21, #0x5c1]
0068AF250  mov      w20, w0
0068AF254  cbnz     w8, #0x68af26c
0068AF258  adrp     x0, #0x8f26000
0068AF25C  ldr      x0, [x0, #0xd90]
0068AF260  bl       #0x382bd14 ; 
0068AF264  mov      w8, #1
0068AF268  strb     w8, [x21, #0x5c1]
0068AF26C  adrp     x8, #0x8f26000
0068AF270  ldr      x8, [x8, #0xd90]
0068AF274  ldr      x2, [x8]
0068AF278  ldrb     w8, [x2, #0x53]
0068AF27C  tbnz     w8, #5, #0x68af288
0068AF280  str      w20, [x19, #0x148]
0068AF284  b        #0x68af298 ; 
0068AF288  ldr      x8, [x2, #0x60]
0068AF28C  mov      x0, x19
0068AF290  mov      w1, w20
0068AF294  blr      x8
0068AF298  mov      x0, x19
0068AF29C  mov      x1, xzr
0068AF2A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AF2A4  adrp     x21, #0x959c000
0068AF2A8  ldrb     w8, [x21, #0x5c2]
0068AF2AC  mov      w20, w0
0068AF2B0  cbnz     w8, #0x68af2c8
0068AF2B4  adrp     x0, #0x8f26000
0068AF2B8  ldr      x0, [x0, #0xda0]
0068AF2BC  bl       #0x382bd14 ; 
0068AF2C0  mov      w8, #1
0068AF2C4  strb     w8, [x21, #0x5c2]
0068AF2C8  adrp     x8, #0x8f26000
0068AF2CC  ldr      x8, [x8, #0xda0]
0068AF2D0  ldr      x2, [x8]
0068AF2D4  ldrb     w8, [x2, #0x53]
0068AF2D8  tbnz     w8, #5, #0x68af2e4
0068AF2DC  str      w20, [x19, #0x14c]
0068AF2E0  b        #0x68af2f4 ; 
0068AF2E4  ldr      x8, [x2, #0x60]
0068AF2E8  mov      x0, x19
0068AF2EC  mov      w1, w20
0068AF2F0  blr      x8
0068AF2F4  mov      x0, x19
0068AF2F8  mov      x1, xzr
0068AF2FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AF300  adrp     x21, #0x959c000
0068AF304  ldrb     w8, [x21, #0x5c3]
0068AF308  mov      w20, w0
0068AF30C  cbnz     w8, #0x68af324
0068AF310  adrp     x0, #0x8f26000
0068AF314  ldr      x0, [x0, #0xdb0]
0068AF318  bl       #0x382bd14 ; 
0068AF31C  mov      w8, #1
0068AF320  strb     w8, [x21, #0x5c3]
0068AF324  adrp     x8, #0x8f26000
0068AF328  ldr      x8, [x8, #0xdb0]
0068AF32C  ldr      x2, [x8]
0068AF330  ldrb     w8, [x2, #0x53]
0068AF334  tbnz     w8, #5, #0x68af340
0068AF338  str      w20, [x19, #0x150]
0068AF33C  b        #0x68af350 ; 
0068AF340  ldr      x8, [x2, #0x60]
0068AF344  mov      x0, x19
0068AF348  mov      w1, w20
0068AF34C  blr      x8
0068AF350  mov      x0, x19
0068AF354  mov      x1, xzr
0068AF358  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF35C  adrp     x21, #0x959c000
0068AF360  ldrb     w8, [x21, #0x5c4]
0068AF364  mov      x20, x0
0068AF368  cbnz     w8, #0x68af380
0068AF36C  adrp     x0, #0x8f26000
0068AF370  ldr      x0, [x0, #0xdb8]
0068AF374  bl       #0x382bd14 ; 
0068AF378  mov      w8, #1
0068AF37C  strb     w8, [x21, #0x5c4]
0068AF380  adrp     x8, #0x8f26000
0068AF384  ldr      x8, [x8, #0xdb8]
0068AF388  ldr      x2, [x8]
0068AF38C  ldrb     w8, [x2, #0x53]
0068AF390  tbnz     w8, #5, #0x68af3a8
0068AF394  add      x0, x19, #0x158
0068AF398  mov      x1, x20
0068AF39C  str      x20, [x19, #0x158]
0068AF3A0  bl       #0x382bcb8 ; 
0068AF3A4  b        #0x68af3b8 ; 
0068AF3A8  ldr      x8, [x2, #0x60]
0068AF3AC  mov      x0, x19
0068AF3B0  mov      x1, x20
0068AF3B4  blr      x8
0068AF3B8  mov      x0, x19
0068AF3BC  mov      x1, xzr
0068AF3C0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF3C4  adrp     x21, #0x959c000
0068AF3C8  ldrb     w8, [x21, #0x5c5]
0068AF3CC  mov      x20, x0
0068AF3D0  cbnz     w8, #0x68af3e8
0068AF3D4  adrp     x0, #0x8f26000
0068AF3D8  ldr      x0, [x0, #0xdc0]
0068AF3DC  bl       #0x382bd14 ; 
0068AF3E0  mov      w8, #1
0068AF3E4  strb     w8, [x21, #0x5c5]
0068AF3E8  adrp     x8, #0x8f26000
0068AF3EC  ldr      x8, [x8, #0xdc0]
0068AF3F0  ldr      x2, [x8]
0068AF3F4  ldrb     w8, [x2, #0x53]
0068AF3F8  tbnz     w8, #5, #0x68af410
0068AF3FC  add      x0, x19, #0x160
0068AF400  mov      x1, x20
0068AF404  str      x20, [x19, #0x160]
0068AF408  bl       #0x382bcb8 ; 
0068AF40C  b        #0x68af420 ; 
0068AF410  ldr      x8, [x2, #0x60]
0068AF414  mov      x0, x19
0068AF418  mov      x1, x20
0068AF41C  blr      x8
0068AF420  mov      x0, x19
0068AF424  mov      x1, xzr
0068AF428  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AF42C  adrp     x21, #0x959c000
0068AF430  ldrb     w8, [x21, #0x5c6]
0068AF434  mov      w20, w0
0068AF438  cbnz     w8, #0x68af450
0068AF43C  adrp     x0, #0x8f26000
0068AF440  ldr      x0, [x0, #0xdc8]
0068AF444  bl       #0x382bd14 ; 
0068AF448  mov      w8, #1
0068AF44C  strb     w8, [x21, #0x5c6]
0068AF450  adrp     x8, #0x8f26000
0068AF454  ldr      x8, [x8, #0xdc8]
0068AF458  ldr      x2, [x8]
0068AF45C  ldrb     w8, [x2, #0x53]
0068AF460  tbnz     w8, #5, #0x68af46c
0068AF464  str      w20, [x19, #0x168]
0068AF468  b        #0x68af47c ; 
0068AF46C  ldr      x8, [x2, #0x60]
0068AF470  mov      x0, x19
0068AF474  mov      w1, w20
0068AF478  blr      x8
0068AF47C  mov      x0, x19
0068AF480  mov      x1, xzr
0068AF484  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AF488  adrp     x21, #0x959c000
0068AF48C  ldrb     w8, [x21, #0x5c7]
0068AF490  mov      w20, w0
0068AF494  cbnz     w8, #0x68af4ac
0068AF498  adrp     x0, #0x8f26000
0068AF49C  ldr      x0, [x0, #0xdd8]
0068AF4A0  bl       #0x382bd14 ; 
0068AF4A4  mov      w8, #1
0068AF4A8  strb     w8, [x21, #0x5c7]
0068AF4AC  adrp     x8, #0x8f26000
0068AF4B0  ldr      x8, [x8, #0xdd8]
0068AF4B4  ldr      x2, [x8]
0068AF4B8  ldrb     w8, [x2, #0x53]
0068AF4BC  tbnz     w8, #5, #0x68af4c8
0068AF4C0  str      w20, [x19, #0x16c]
0068AF4C4  b        #0x68af4d8 ; 
0068AF4C8  ldr      x8, [x2, #0x60]
0068AF4CC  mov      x0, x19
0068AF4D0  mov      w1, w20
0068AF4D4  blr      x8
0068AF4D8  mov      x0, x19
0068AF4DC  mov      x1, xzr
0068AF4E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AF4E4  adrp     x21, #0x959c000
0068AF4E8  ldrb     w8, [x21, #0x5c8]
0068AF4EC  mov      w20, w0
0068AF4F0  cbnz     w8, #0x68af508
0068AF4F4  adrp     x0, #0x8f26000
0068AF4F8  ldr      x0, [x0, #0xde8]
0068AF4FC  bl       #0x382bd14 ; 
0068AF500  mov      w8, #1
0068AF504  strb     w8, [x21, #0x5c8]
0068AF508  adrp     x8, #0x8f26000
0068AF50C  ldr      x8, [x8, #0xde8]
0068AF510  ldr      x2, [x8]
0068AF514  ldrb     w8, [x2, #0x53]
0068AF518  tbnz     w8, #5, #0x68af524
0068AF51C  str      w20, [x19, #0x170]
0068AF520  b        #0x68af534 ; 
0068AF524  ldr      x8, [x2, #0x60]
0068AF528  mov      x0, x19
0068AF52C  mov      w1, w20
0068AF530  blr      x8
0068AF534  mov      x0, x19
0068AF538  mov      x1, xzr
0068AF53C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068AF540  adrp     x21, #0x959c000
0068AF544  ldrb     w8, [x21, #0x5c9]
0068AF548  mov      w20, w0
0068AF54C  cbnz     w8, #0x68af564
0068AF550  adrp     x0, #0x8f26000
0068AF554  ldr      x0, [x0, #0xdf8]
0068AF558  bl       #0x382bd14 ; 
0068AF55C  mov      w8, #1
0068AF560  strb     w8, [x21, #0x5c9]
0068AF564  adrp     x8, #0x8f26000
0068AF568  ldr      x8, [x8, #0xdf8]
0068AF56C  ldr      x2, [x8]
0068AF570  ldrb     w8, [x2, #0x53]
0068AF574  tbnz     w8, #5, #0x68af580
0068AF578  str      w20, [x19, #0x174]
0068AF57C  b        #0x68af590 ; 
0068AF580  ldr      x8, [x2, #0x60]
0068AF584  mov      x0, x19
0068AF588  mov      w1, w20
0068AF58C  blr      x8
0068AF590  mov      x0, x19
0068AF594  mov      x1, xzr
0068AF598  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF59C  adrp     x21, #0x959c000
0068AF5A0  ldrb     w8, [x21, #0x5ca]
0068AF5A4  mov      x20, x0
0068AF5A8  cbnz     w8, #0x68af5c0
0068AF5AC  adrp     x0, #0x8f26000
0068AF5B0  ldr      x0, [x0, #0xe08]
0068AF5B4  bl       #0x382bd14 ; 
0068AF5B8  mov      w8, #1
0068AF5BC  strb     w8, [x21, #0x5ca]
0068AF5C0  adrp     x8, #0x8f26000
0068AF5C4  ldr      x8, [x8, #0xe08]
0068AF5C8  ldr      x2, [x8]
0068AF5CC  ldrb     w8, [x2, #0x53]
0068AF5D0  tbnz     w8, #5, #0x68af5e8
0068AF5D4  add      x0, x19, #0x178
0068AF5D8  mov      x1, x20
0068AF5DC  str      x20, [x19, #0x178]
0068AF5E0  bl       #0x382bcb8 ; 
0068AF5E4  b        #0x68af5f8 ; 
0068AF5E8  ldr      x8, [x2, #0x60]
0068AF5EC  mov      x0, x19
0068AF5F0  mov      x1, x20
0068AF5F4  blr      x8
0068AF5F8  mov      x0, x19
0068AF5FC  mov      x1, xzr
0068AF600  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF604  adrp     x21, #0x959c000
0068AF608  ldrb     w8, [x21, #0x5cb]
0068AF60C  mov      x20, x0
0068AF610  cbnz     w8, #0x68af628
0068AF614  adrp     x0, #0x8f26000
0068AF618  ldr      x0, [x0, #0xe18]
0068AF61C  bl       #0x382bd14 ; 
0068AF620  mov      w8, #1
0068AF624  strb     w8, [x21, #0x5cb]
0068AF628  adrp     x8, #0x8f26000
0068AF62C  ldr      x8, [x8, #0xe18]
0068AF630  ldr      x2, [x8]
0068AF634  ldrb     w8, [x2, #0x53]
0068AF638  tbnz     w8, #5, #0x68af650
0068AF63C  add      x0, x19, #0x180
0068AF640  mov      x1, x20
0068AF644  str      x20, [x19, #0x180]
0068AF648  bl       #0x382bcb8 ; 
0068AF64C  b        #0x68af660 ; 
0068AF650  ldr      x8, [x2, #0x60]
0068AF654  mov      x0, x19
0068AF658  mov      x1, x20
0068AF65C  blr      x8
0068AF660  mov      x0, x19
0068AF664  mov      x1, xzr
0068AF668  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF66C  adrp     x21, #0x959c000
0068AF670  ldrb     w8, [x21, #0x5cc]
0068AF674  mov      x20, x0
0068AF678  cbnz     w8, #0x68af690
0068AF67C  adrp     x0, #0x8f26000
0068AF680  ldr      x0, [x0, #0xe28]
0068AF684  bl       #0x382bd14 ; 
0068AF688  mov      w8, #1
0068AF68C  strb     w8, [x21, #0x5cc]
0068AF690  adrp     x8, #0x8f26000
0068AF694  ldr      x8, [x8, #0xe28]
0068AF698  ldr      x2, [x8]
0068AF69C  ldrb     w8, [x2, #0x53]
0068AF6A0  tbnz     w8, #5, #0x68af6b8
0068AF6A4  add      x0, x19, #0x188
0068AF6A8  mov      x1, x20
0068AF6AC  str      x20, [x19, #0x188]
0068AF6B0  bl       #0x382bcb8 ; 
0068AF6B4  b        #0x68af6c8 ; 
0068AF6B8  ldr      x8, [x2, #0x60]
0068AF6BC  mov      x0, x19
0068AF6C0  mov      x1, x20
0068AF6C4  blr      x8
0068AF6C8  mov      x0, x19
0068AF6CC  mov      x1, xzr
0068AF6D0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF6D4  adrp     x21, #0x959c000
0068AF6D8  ldrb     w8, [x21, #0x5cd]
0068AF6DC  mov      x20, x0
0068AF6E0  cbnz     w8, #0x68af6f8
0068AF6E4  adrp     x0, #0x8f26000
0068AF6E8  ldr      x0, [x0, #0xe38]
0068AF6EC  bl       #0x382bd14 ; 
0068AF6F0  mov      w8, #1
0068AF6F4  strb     w8, [x21, #0x5cd]
0068AF6F8  adrp     x8, #0x8f26000
0068AF6FC  ldr      x8, [x8, #0xe38]
0068AF700  ldr      x2, [x8]
0068AF704  ldrb     w8, [x2, #0x53]
0068AF708  tbnz     w8, #5, #0x68af720
0068AF70C  add      x0, x19, #0x190
0068AF710  mov      x1, x20
0068AF714  str      x20, [x19, #0x190]
0068AF718  bl       #0x382bcb8 ; 
0068AF71C  b        #0x68af730 ; 
0068AF720  ldr      x8, [x2, #0x60]
0068AF724  mov      x0, x19
0068AF728  mov      x1, x20
0068AF72C  blr      x8
0068AF730  mov      x0, x19
0068AF734  mov      x1, xzr
0068AF738  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF73C  adrp     x21, #0x959c000
0068AF740  ldrb     w8, [x21, #0x5ce]
0068AF744  mov      x20, x0
0068AF748  cbnz     w8, #0x68af760
0068AF74C  adrp     x0, #0x8f26000
0068AF750  ldr      x0, [x0, #0xe48]
0068AF754  bl       #0x382bd14 ; 
0068AF758  mov      w8, #1
0068AF75C  strb     w8, [x21, #0x5ce]
0068AF760  adrp     x8, #0x8f26000
0068AF764  ldr      x8, [x8, #0xe48]
0068AF768  ldr      x2, [x8]
0068AF76C  ldrb     w8, [x2, #0x53]
0068AF770  tbnz     w8, #5, #0x68af788
0068AF774  add      x0, x19, #0x198
0068AF778  mov      x1, x20
0068AF77C  str      x20, [x19, #0x198]
0068AF780  bl       #0x382bcb8 ; 
0068AF784  b        #0x68af798 ; 
0068AF788  ldr      x8, [x2, #0x60]
0068AF78C  mov      x0, x19
0068AF790  mov      x1, x20
0068AF794  blr      x8
0068AF798  mov      x0, x19
0068AF79C  mov      x1, xzr
0068AF7A0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF7A4  adrp     x21, #0x959c000
0068AF7A8  ldrb     w8, [x21, #0x5cf]
0068AF7AC  mov      x20, x0
0068AF7B0  cbnz     w8, #0x68af7c8
0068AF7B4  adrp     x0, #0x8f26000
0068AF7B8  ldr      x0, [x0, #0xe58]
0068AF7BC  bl       #0x382bd14 ; 
0068AF7C0  mov      w8, #1
0068AF7C4  strb     w8, [x21, #0x5cf]
0068AF7C8  adrp     x8, #0x8f26000
0068AF7CC  ldr      x8, [x8, #0xe58]
0068AF7D0  ldr      x2, [x8]
0068AF7D4  ldrb     w8, [x2, #0x53]
0068AF7D8  tbnz     w8, #5, #0x68af7f0
0068AF7DC  add      x0, x19, #0x1a0
0068AF7E0  mov      x1, x20
0068AF7E4  str      x20, [x19, #0x1a0]
0068AF7E8  bl       #0x382bcb8 ; 
0068AF7EC  b        #0x68af800 ; 
0068AF7F0  ldr      x8, [x2, #0x60]
0068AF7F4  mov      x0, x19
0068AF7F8  mov      x1, x20
0068AF7FC  blr      x8
0068AF800  mov      x0, x19
0068AF804  mov      x1, xzr
0068AF808  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF80C  adrp     x21, #0x959c000
0068AF810  ldrb     w8, [x21, #0x5d0]
0068AF814  mov      x20, x0
0068AF818  cbnz     w8, #0x68af830
0068AF81C  adrp     x0, #0x8f26000
0068AF820  ldr      x0, [x0, #0xe68]
0068AF824  bl       #0x382bd14 ; 
0068AF828  mov      w8, #1
0068AF82C  strb     w8, [x21, #0x5d0]
0068AF830  adrp     x8, #0x8f26000
0068AF834  ldr      x8, [x8, #0xe68]
0068AF838  ldr      x2, [x8]
0068AF83C  ldrb     w8, [x2, #0x53]
0068AF840  tbnz     w8, #5, #0x68af858
0068AF844  add      x0, x19, #0x1a8
0068AF848  mov      x1, x20
0068AF84C  str      x20, [x19, #0x1a8]
0068AF850  bl       #0x382bcb8 ; 
0068AF854  b        #0x68af868 ; 
0068AF858  ldr      x8, [x2, #0x60]
0068AF85C  mov      x0, x19
0068AF860  mov      x1, x20
0068AF864  blr      x8
0068AF868  mov      x0, x19
0068AF86C  mov      x1, xzr
0068AF870  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF874  adrp     x21, #0x959c000
0068AF878  ldrb     w8, [x21, #0x5d1]
0068AF87C  mov      x20, x0
0068AF880  cbnz     w8, #0x68af898
0068AF884  adrp     x0, #0x8f26000
0068AF888  ldr      x0, [x0, #0xe70]
0068AF88C  bl       #0x382bd14 ; 
0068AF890  mov      w8, #1
0068AF894  strb     w8, [x21, #0x5d1]
0068AF898  adrp     x8, #0x8f26000
0068AF89C  ldr      x8, [x8, #0xe70]
0068AF8A0  ldr      x2, [x8]
0068AF8A4  ldrb     w8, [x2, #0x53]
0068AF8A8  tbnz     w8, #5, #0x68af8c0
0068AF8AC  add      x0, x19, #0x1b0
0068AF8B0  mov      x1, x20
0068AF8B4  str      x20, [x19, #0x1b0]
0068AF8B8  bl       #0x382bcb8 ; 
0068AF8BC  b        #0x68af8d0 ; 
0068AF8C0  ldr      x8, [x2, #0x60]
0068AF8C4  mov      x0, x19
0068AF8C8  mov      x1, x20
0068AF8CC  blr      x8
0068AF8D0  mov      x0, x19
0068AF8D4  mov      x1, xzr
0068AF8D8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068AF8DC  adrp     x21, #0x959c000
0068AF8E0  ldrb     w8, [x21, #0x5d2]
0068AF8E4  mov      x20, x0
0068AF8E8  cbnz     w8, #0x68af900
0068AF8EC  adrp     x0, #0x8f26000
0068AF8F0  ldr      x0, [x0, #0xe78]
0068AF8F4  bl       #0x382bd14 ; 
0068AF8F8  mov      w8, #1
0068AF8FC  strb     w8, [x21, #0x5d2]
0068AF900  adrp     x8, #0x8f26000
0068AF904  ldr      x8, [x8, #0xe78]
0068AF908  ldr      x2, [x8]
0068AF90C  ldrb     w8, [x2, #0x53]
0068AF910  tbnz     w8, #5, #0x68af928
0068AF914  add      x0, x19, #0x1b8
0068AF918  mov      x1, x20
0068AF91C  str      x20, [x19, #0x1b8]
0068AF920  bl       #0x382bcb8 ; 
0068AF924  b        #0x68af938 ; 
0068AF928  ldr      x8, [x2, #0x60]
0068AF92C  mov      x0, x19
0068AF930  mov      x1, x20
0068AF934  blr      x8
0068AF938  ldp      x20, x19, [sp, #0x10]
0068AF93C  mov      w0, #1
0068AF940  ldp      x30, x21, [sp], #0x20
0068AF944  ret      

