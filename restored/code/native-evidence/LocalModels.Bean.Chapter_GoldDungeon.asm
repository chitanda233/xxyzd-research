; LocalModels.Bean.Chapter_GoldDungeon$$readImpl
; RVA 0x68A5EFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068A5EFC  stp      x30, x21, [sp, #-0x20]!
0068A5F00  stp      x20, x19, [sp, #0x10]
0068A5F04  adrp     x20, #0x959b000
0068A5F08  adrp     x21, #0x8f26000
0068A5F0C  ldrb     w8, [x20, #0xf75]
0068A5F10  ldr      x21, [x21, #0x7f0]
0068A5F14  mov      x19, x0
0068A5F18  tbnz     w8, #0, #0x68a5f30
0068A5F1C  adrp     x0, #0x8f26000
0068A5F20  ldr      x0, [x0, #0x7f0]
0068A5F24  bl       #0x382bd14 ; 
0068A5F28  mov      w8, #1
0068A5F2C  strb     w8, [x20, #0xf75]
0068A5F30  ldr      x1, [x21]
0068A5F34  ldrb     w8, [x1, #0x53]
0068A5F38  tbnz     w8, #5, #0x68a5f88
0068A5F3C  mov      x0, x19
0068A5F40  mov      x1, xzr
0068A5F44  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A5F48  adrp     x21, #0x959c000
0068A5F4C  ldrb     w8, [x21, #0x53b]
0068A5F50  mov      w20, w0
0068A5F54  cbnz     w8, #0x68a5f6c
0068A5F58  adrp     x0, #0x8f26000
0068A5F5C  ldr      x0, [x0, #0x568]
0068A5F60  bl       #0x382bd14 ; 
0068A5F64  mov      w8, #1
0068A5F68  strb     w8, [x21, #0x53b]
0068A5F6C  adrp     x8, #0x8f26000
0068A5F70  ldr      x8, [x8, #0x568]
0068A5F74  ldr      x2, [x8]
0068A5F78  ldrb     w8, [x2, #0x53]
0068A5F7C  tbnz     w8, #5, #0x68a5f9c
0068A5F80  str      w20, [x19, #0x20]
0068A5F84  b        #0x68a5fac ; 
0068A5F88  ldr      x2, [x1, #0x60]
0068A5F8C  mov      x0, x19
0068A5F90  ldp      x20, x19, [sp, #0x10]
0068A5F94  ldp      x30, x21, [sp], #0x20
0068A5F98  br       x2
0068A5F9C  ldr      x8, [x2, #0x60]
0068A5FA0  mov      x0, x19
0068A5FA4  mov      w1, w20
0068A5FA8  blr      x8
0068A5FAC  mov      x0, x19
0068A5FB0  mov      x1, xzr
0068A5FB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A5FB8  adrp     x21, #0x959c000
0068A5FBC  ldrb     w8, [x21, #0x53c]
0068A5FC0  mov      w20, w0
0068A5FC4  cbnz     w8, #0x68a5fdc
0068A5FC8  adrp     x0, #0x8f26000
0068A5FCC  ldr      x0, [x0, #0x578]
0068A5FD0  bl       #0x382bd14 ; 
0068A5FD4  mov      w8, #1
0068A5FD8  strb     w8, [x21, #0x53c]
0068A5FDC  adrp     x8, #0x8f26000
0068A5FE0  ldr      x8, [x8, #0x578]
0068A5FE4  ldr      x2, [x8]
0068A5FE8  ldrb     w8, [x2, #0x53]
0068A5FEC  tbnz     w8, #5, #0x68a5ff8
0068A5FF0  str      w20, [x19, #0x24]
0068A5FF4  b        #0x68a6008 ; 
0068A5FF8  ldr      x8, [x2, #0x60]
0068A5FFC  mov      x0, x19
0068A6000  mov      w1, w20
0068A6004  blr      x8
0068A6008  mov      x0, x19
0068A600C  mov      x1, xzr
0068A6010  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6014  adrp     x21, #0x959c000
0068A6018  ldrb     w8, [x21, #0x53d]
0068A601C  mov      w20, w0
0068A6020  cbnz     w8, #0x68a6038
0068A6024  adrp     x0, #0x8f26000
0068A6028  ldr      x0, [x0, #0x588]
0068A602C  bl       #0x382bd14 ; 
0068A6030  mov      w8, #1
0068A6034  strb     w8, [x21, #0x53d]
0068A6038  adrp     x8, #0x8f26000
0068A603C  ldr      x8, [x8, #0x588]
0068A6040  ldr      x2, [x8]
0068A6044  ldrb     w8, [x2, #0x53]
0068A6048  tbnz     w8, #5, #0x68a6054
0068A604C  str      w20, [x19, #0x28]
0068A6050  b        #0x68a6064 ; 
0068A6054  ldr      x8, [x2, #0x60]
0068A6058  mov      x0, x19
0068A605C  mov      w1, w20
0068A6060  blr      x8
0068A6064  mov      x0, x19
0068A6068  mov      x1, xzr
0068A606C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A6070  adrp     x21, #0x959c000
0068A6074  ldrb     w8, [x21, #0x53e]
0068A6078  mov      x20, x0
0068A607C  cbnz     w8, #0x68a6094
0068A6080  adrp     x0, #0x8f26000
0068A6084  ldr      x0, [x0, #0x598]
0068A6088  bl       #0x382bd14 ; 
0068A608C  mov      w8, #1
0068A6090  strb     w8, [x21, #0x53e]
0068A6094  adrp     x8, #0x8f26000
0068A6098  ldr      x8, [x8, #0x598]
0068A609C  ldr      x2, [x8]
0068A60A0  ldrb     w8, [x2, #0x53]
0068A60A4  tbnz     w8, #5, #0x68a60bc
0068A60A8  mov      x0, x19
0068A60AC  str      x20, [x0, #0x30]!
0068A60B0  mov      x1, x20
0068A60B4  bl       #0x382bcb8 ; 
0068A60B8  b        #0x68a60cc ; 
0068A60BC  ldr      x8, [x2, #0x60]
0068A60C0  mov      x0, x19
0068A60C4  mov      x1, x20
0068A60C8  blr      x8
0068A60CC  mov      x0, x19
0068A60D0  mov      x1, xzr
0068A60D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A60D8  adrp     x21, #0x959c000
0068A60DC  ldrb     w8, [x21, #0x53f]
0068A60E0  mov      w20, w0
0068A60E4  cbnz     w8, #0x68a60fc
0068A60E8  adrp     x0, #0x8f26000
0068A60EC  ldr      x0, [x0, #0x5a8]
0068A60F0  bl       #0x382bd14 ; 
0068A60F4  mov      w8, #1
0068A60F8  strb     w8, [x21, #0x53f]
0068A60FC  adrp     x8, #0x8f26000
0068A6100  ldr      x8, [x8, #0x5a8]
0068A6104  ldr      x2, [x8]
0068A6108  ldrb     w8, [x2, #0x53]
0068A610C  tbnz     w8, #5, #0x68a6118
0068A6110  str      w20, [x19, #0x38]
0068A6114  b        #0x68a6128 ; 
0068A6118  ldr      x8, [x2, #0x60]
0068A611C  mov      x0, x19
0068A6120  mov      w1, w20
0068A6124  blr      x8
0068A6128  mov      x0, x19
0068A612C  mov      x1, xzr
0068A6130  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6134  adrp     x21, #0x959c000
0068A6138  ldrb     w8, [x21, #0x540]
0068A613C  mov      w20, w0
0068A6140  cbnz     w8, #0x68a6158
0068A6144  adrp     x0, #0x8f26000
0068A6148  ldr      x0, [x0, #0x5b8]
0068A614C  bl       #0x382bd14 ; 
0068A6150  mov      w8, #1
0068A6154  strb     w8, [x21, #0x540]
0068A6158  adrp     x8, #0x8f26000
0068A615C  ldr      x8, [x8, #0x5b8]
0068A6160  ldr      x2, [x8]
0068A6164  ldrb     w8, [x2, #0x53]
0068A6168  tbnz     w8, #5, #0x68a6174
0068A616C  str      w20, [x19, #0x3c]
0068A6170  b        #0x68a6184 ; 
0068A6174  ldr      x8, [x2, #0x60]
0068A6178  mov      x0, x19
0068A617C  mov      w1, w20
0068A6180  blr      x8
0068A6184  mov      x0, x19
0068A6188  mov      x1, xzr
0068A618C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A6190  adrp     x21, #0x959c000
0068A6194  ldrb     w8, [x21, #0x541]
0068A6198  mov      x20, x0
0068A619C  cbnz     w8, #0x68a61b4
0068A61A0  adrp     x0, #0x8f26000
0068A61A4  ldr      x0, [x0, #0x5c8]
0068A61A8  bl       #0x382bd14 ; 
0068A61AC  mov      w8, #1
0068A61B0  strb     w8, [x21, #0x541]
0068A61B4  adrp     x8, #0x8f26000
0068A61B8  ldr      x8, [x8, #0x5c8]
0068A61BC  ldr      x2, [x8]
0068A61C0  ldrb     w8, [x2, #0x53]
0068A61C4  tbnz     w8, #5, #0x68a61d0
0068A61C8  str      x20, [x19, #0x40]
0068A61CC  b        #0x68a61e0 ; 
0068A61D0  ldr      x8, [x2, #0x60]
0068A61D4  mov      x0, x19
0068A61D8  mov      x1, x20
0068A61DC  blr      x8
0068A61E0  mov      x0, x19
0068A61E4  mov      x1, xzr
0068A61E8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A61EC  adrp     x21, #0x959c000
0068A61F0  ldrb     w8, [x21, #0x542]
0068A61F4  mov      x20, x0
0068A61F8  cbnz     w8, #0x68a6210
0068A61FC  adrp     x0, #0x8f26000
0068A6200  ldr      x0, [x0, #0x5d8]
0068A6204  bl       #0x382bd14 ; 
0068A6208  mov      w8, #1
0068A620C  strb     w8, [x21, #0x542]
0068A6210  adrp     x8, #0x8f26000
0068A6214  ldr      x8, [x8, #0x5d8]
0068A6218  ldr      x2, [x8]
0068A621C  ldrb     w8, [x2, #0x53]
0068A6220  tbnz     w8, #5, #0x68a622c
0068A6224  str      x20, [x19, #0x48]
0068A6228  b        #0x68a623c ; 
0068A622C  ldr      x8, [x2, #0x60]
0068A6230  mov      x0, x19
0068A6234  mov      x1, x20
0068A6238  blr      x8
0068A623C  mov      x0, x19
0068A6240  mov      x1, xzr
0068A6244  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A6248  adrp     x21, #0x959c000
0068A624C  ldrb     w8, [x21, #0x543]
0068A6250  mov      x20, x0
0068A6254  cbnz     w8, #0x68a626c
0068A6258  adrp     x0, #0x8f26000
0068A625C  ldr      x0, [x0, #0x5e8]
0068A6260  bl       #0x382bd14 ; 
0068A6264  mov      w8, #1
0068A6268  strb     w8, [x21, #0x543]
0068A626C  adrp     x8, #0x8f26000
0068A6270  ldr      x8, [x8, #0x5e8]
0068A6274  ldr      x2, [x8]
0068A6278  ldrb     w8, [x2, #0x53]
0068A627C  tbnz     w8, #5, #0x68a6288
0068A6280  str      x20, [x19, #0x50]
0068A6284  b        #0x68a6298 ; 
0068A6288  ldr      x8, [x2, #0x60]
0068A628C  mov      x0, x19
0068A6290  mov      x1, x20
0068A6294  blr      x8
0068A6298  mov      x0, x19
0068A629C  mov      x1, xzr
0068A62A0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A62A4  adrp     x21, #0x959c000
0068A62A8  ldrb     w8, [x21, #0x544]
0068A62AC  mov      x20, x0
0068A62B0  cbnz     w8, #0x68a62c8
0068A62B4  adrp     x0, #0x8f26000
0068A62B8  ldr      x0, [x0, #0x5f8]
0068A62BC  bl       #0x382bd14 ; 
0068A62C0  mov      w8, #1
0068A62C4  strb     w8, [x21, #0x544]
0068A62C8  adrp     x8, #0x8f26000
0068A62CC  ldr      x8, [x8, #0x5f8]
0068A62D0  ldr      x2, [x8]
0068A62D4  ldrb     w8, [x2, #0x53]
0068A62D8  tbnz     w8, #5, #0x68a62e4
0068A62DC  str      x20, [x19, #0x58]
0068A62E0  b        #0x68a62f4 ; 
0068A62E4  ldr      x8, [x2, #0x60]
0068A62E8  mov      x0, x19
0068A62EC  mov      x1, x20
0068A62F0  blr      x8
0068A62F4  mov      x0, x19
0068A62F8  mov      x1, xzr
0068A62FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6300  adrp     x21, #0x959c000
0068A6304  ldrb     w8, [x21, #0x545]
0068A6308  mov      w20, w0
0068A630C  cbnz     w8, #0x68a6324
0068A6310  adrp     x0, #0x8f26000
0068A6314  ldr      x0, [x0, #0x608]
0068A6318  bl       #0x382bd14 ; 
0068A631C  mov      w8, #1
0068A6320  strb     w8, [x21, #0x545]
0068A6324  adrp     x8, #0x8f26000
0068A6328  ldr      x8, [x8, #0x608]
0068A632C  ldr      x2, [x8]
0068A6330  ldrb     w8, [x2, #0x53]
0068A6334  tbnz     w8, #5, #0x68a6340
0068A6338  str      w20, [x19, #0x60]
0068A633C  b        #0x68a6350 ; 
0068A6340  ldr      x8, [x2, #0x60]
0068A6344  mov      x0, x19
0068A6348  mov      w1, w20
0068A634C  blr      x8
0068A6350  mov      x0, x19
0068A6354  mov      x1, xzr
0068A6358  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A635C  adrp     x21, #0x959c000
0068A6360  ldrb     w8, [x21, #0x546]
0068A6364  mov      w20, w0
0068A6368  cbnz     w8, #0x68a6380
0068A636C  adrp     x0, #0x8f26000
0068A6370  ldr      x0, [x0, #0x618]
0068A6374  bl       #0x382bd14 ; 
0068A6378  mov      w8, #1
0068A637C  strb     w8, [x21, #0x546]
0068A6380  adrp     x8, #0x8f26000
0068A6384  ldr      x8, [x8, #0x618]
0068A6388  ldr      x2, [x8]
0068A638C  ldrb     w8, [x2, #0x53]
0068A6390  tbnz     w8, #5, #0x68a639c
0068A6394  str      w20, [x19, #0x64]
0068A6398  b        #0x68a63ac ; 
0068A639C  ldr      x8, [x2, #0x60]
0068A63A0  mov      x0, x19
0068A63A4  mov      w1, w20
0068A63A8  blr      x8
0068A63AC  mov      x0, x19
0068A63B0  mov      x1, xzr
0068A63B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A63B8  adrp     x21, #0x959c000
0068A63BC  ldrb     w8, [x21, #0x547]
0068A63C0  mov      w20, w0
0068A63C4  cbnz     w8, #0x68a63dc
0068A63C8  adrp     x0, #0x8f26000
0068A63CC  ldr      x0, [x0, #0x628]
0068A63D0  bl       #0x382bd14 ; 
0068A63D4  mov      w8, #1
0068A63D8  strb     w8, [x21, #0x547]
0068A63DC  adrp     x8, #0x8f26000
0068A63E0  ldr      x8, [x8, #0x628]
0068A63E4  ldr      x2, [x8]
0068A63E8  ldrb     w8, [x2, #0x53]
0068A63EC  tbnz     w8, #5, #0x68a63f8
0068A63F0  str      w20, [x19, #0x68]
0068A63F4  b        #0x68a6408 ; 
0068A63F8  ldr      x8, [x2, #0x60]
0068A63FC  mov      x0, x19
0068A6400  mov      w1, w20
0068A6404  blr      x8
0068A6408  mov      x0, x19
0068A640C  mov      x1, xzr
0068A6410  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A6414  adrp     x21, #0x959c000
0068A6418  ldrb     w8, [x21, #0x548]
0068A641C  mov      x20, x0
0068A6420  cbnz     w8, #0x68a6438
0068A6424  adrp     x0, #0x8f26000
0068A6428  ldr      x0, [x0, #0x638]
0068A642C  bl       #0x382bd14 ; 
0068A6430  mov      w8, #1
0068A6434  strb     w8, [x21, #0x548]
0068A6438  adrp     x8, #0x8f26000
0068A643C  ldr      x8, [x8, #0x638]
0068A6440  ldr      x2, [x8]
0068A6444  ldrb     w8, [x2, #0x53]
0068A6448  tbnz     w8, #5, #0x68a6454
0068A644C  str      x20, [x19, #0x70]
0068A6450  b        #0x68a6464 ; 
0068A6454  ldr      x8, [x2, #0x60]
0068A6458  mov      x0, x19
0068A645C  mov      x1, x20
0068A6460  blr      x8
0068A6464  mov      x0, x19
0068A6468  mov      x1, xzr
0068A646C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A6470  adrp     x21, #0x959c000
0068A6474  ldrb     w8, [x21, #0x549]
0068A6478  mov      x20, x0
0068A647C  cbnz     w8, #0x68a6494
0068A6480  adrp     x0, #0x8f26000
0068A6484  ldr      x0, [x0, #0x648]
0068A6488  bl       #0x382bd14 ; 
0068A648C  mov      w8, #1
0068A6490  strb     w8, [x21, #0x549]
0068A6494  adrp     x8, #0x8f26000
0068A6498  ldr      x8, [x8, #0x648]
0068A649C  ldr      x2, [x8]
0068A64A0  ldrb     w8, [x2, #0x53]
0068A64A4  tbnz     w8, #5, #0x68a64b0
0068A64A8  str      x20, [x19, #0x78]
0068A64AC  b        #0x68a64c0 ; 
0068A64B0  ldr      x8, [x2, #0x60]
0068A64B4  mov      x0, x19
0068A64B8  mov      x1, x20
0068A64BC  blr      x8
0068A64C0  mov      x0, x19
0068A64C4  mov      x1, xzr
0068A64C8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A64CC  adrp     x21, #0x959c000
0068A64D0  ldrb     w8, [x21, #0x54a]
0068A64D4  mov      x20, x0
0068A64D8  cbnz     w8, #0x68a64f0
0068A64DC  adrp     x0, #0x8f26000
0068A64E0  ldr      x0, [x0, #0x658]
0068A64E4  bl       #0x382bd14 ; 
0068A64E8  mov      w8, #1
0068A64EC  strb     w8, [x21, #0x54a]
0068A64F0  adrp     x8, #0x8f26000
0068A64F4  ldr      x8, [x8, #0x658]
0068A64F8  ldr      x2, [x8]
0068A64FC  ldrb     w8, [x2, #0x53]
0068A6500  tbnz     w8, #5, #0x68a650c
0068A6504  str      x20, [x19, #0x80]
0068A6508  b        #0x68a651c ; 
0068A650C  ldr      x8, [x2, #0x60]
0068A6510  mov      x0, x19
0068A6514  mov      x1, x20
0068A6518  blr      x8
0068A651C  mov      x0, x19
0068A6520  mov      x1, xzr
0068A6524  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068A6528  adrp     x21, #0x959c000
0068A652C  ldrb     w8, [x21, #0x54b]
0068A6530  mov      x20, x0
0068A6534  cbnz     w8, #0x68a654c
0068A6538  adrp     x0, #0x8f26000
0068A653C  ldr      x0, [x0, #0x668]
0068A6540  bl       #0x382bd14 ; 
0068A6544  mov      w8, #1
0068A6548  strb     w8, [x21, #0x54b]
0068A654C  adrp     x8, #0x8f26000
0068A6550  ldr      x8, [x8, #0x668]
0068A6554  ldr      x2, [x8]
0068A6558  ldrb     w8, [x2, #0x53]
0068A655C  tbnz     w8, #5, #0x68a6568
0068A6560  str      x20, [x19, #0x88]
0068A6564  b        #0x68a6578 ; 
0068A6568  ldr      x8, [x2, #0x60]
0068A656C  mov      x0, x19
0068A6570  mov      x1, x20
0068A6574  blr      x8
0068A6578  mov      x0, x19
0068A657C  mov      x1, xzr
0068A6580  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6584  adrp     x21, #0x959c000
0068A6588  ldrb     w8, [x21, #0x54c]
0068A658C  mov      w20, w0
0068A6590  cbnz     w8, #0x68a65a8
0068A6594  adrp     x0, #0x8f26000
0068A6598  ldr      x0, [x0, #0x678]
0068A659C  bl       #0x382bd14 ; 
0068A65A0  mov      w8, #1
0068A65A4  strb     w8, [x21, #0x54c]
0068A65A8  adrp     x8, #0x8f26000
0068A65AC  ldr      x8, [x8, #0x678]
0068A65B0  ldr      x2, [x8]
0068A65B4  ldrb     w8, [x2, #0x53]
0068A65B8  tbnz     w8, #5, #0x68a65c4
0068A65BC  str      w20, [x19, #0x90]
0068A65C0  b        #0x68a65d4 ; 
0068A65C4  ldr      x8, [x2, #0x60]
0068A65C8  mov      x0, x19
0068A65CC  mov      w1, w20
0068A65D0  blr      x8
0068A65D4  mov      x0, x19
0068A65D8  mov      x1, xzr
0068A65DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A65E0  adrp     x21, #0x959c000
0068A65E4  ldrb     w8, [x21, #0x54d]
0068A65E8  mov      w20, w0
0068A65EC  cbnz     w8, #0x68a6604
0068A65F0  adrp     x0, #0x8f26000
0068A65F4  ldr      x0, [x0, #0x688]
0068A65F8  bl       #0x382bd14 ; 
0068A65FC  mov      w8, #1
0068A6600  strb     w8, [x21, #0x54d]
0068A6604  adrp     x8, #0x8f26000
0068A6608  ldr      x8, [x8, #0x688]
0068A660C  ldr      x2, [x8]
0068A6610  ldrb     w8, [x2, #0x53]
0068A6614  tbnz     w8, #5, #0x68a6620
0068A6618  str      w20, [x19, #0x94]
0068A661C  b        #0x68a6630 ; 
0068A6620  ldr      x8, [x2, #0x60]
0068A6624  mov      x0, x19
0068A6628  mov      w1, w20
0068A662C  blr      x8
0068A6630  mov      x0, x19
0068A6634  mov      x1, xzr
0068A6638  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068A663C  adrp     x21, #0x959c000
0068A6640  ldrb     w8, [x21, #0x54e]
0068A6644  mov      x20, x0
0068A6648  cbnz     w8, #0x68a6660
0068A664C  adrp     x0, #0x8f26000
0068A6650  ldr      x0, [x0, #0x698]
0068A6654  bl       #0x382bd14 ; 
0068A6658  mov      w8, #1
0068A665C  strb     w8, [x21, #0x54e]
0068A6660  adrp     x8, #0x8f26000
0068A6664  ldr      x8, [x8, #0x698]
0068A6668  ldr      x2, [x8]
0068A666C  ldrb     w8, [x2, #0x53]
0068A6670  tbnz     w8, #5, #0x68a6688
0068A6674  mov      x0, x19
0068A6678  str      x20, [x0, #0x98]!
0068A667C  mov      x1, x20
0068A6680  bl       #0x382bcb8 ; 
0068A6684  b        #0x68a6698 ; 
0068A6688  ldr      x8, [x2, #0x60]
0068A668C  mov      x0, x19
0068A6690  mov      x1, x20
0068A6694  blr      x8
0068A6698  mov      x0, x19
0068A669C  mov      x1, xzr
0068A66A0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068A66A4  adrp     x21, #0x959c000
0068A66A8  ldrb     w8, [x21, #0x54f]
0068A66AC  mov      x20, x0
0068A66B0  cbnz     w8, #0x68a66c8
0068A66B4  adrp     x0, #0x8f26000
0068A66B8  ldr      x0, [x0, #0x6a8]
0068A66BC  bl       #0x382bd14 ; 
0068A66C0  mov      w8, #1
0068A66C4  strb     w8, [x21, #0x54f]
0068A66C8  adrp     x8, #0x8f26000
0068A66CC  ldr      x8, [x8, #0x6a8]
0068A66D0  ldr      x2, [x8]
0068A66D4  ldrb     w8, [x2, #0x53]
0068A66D8  tbnz     w8, #5, #0x68a66f0
0068A66DC  mov      x0, x19
0068A66E0  str      x20, [x0, #0xa0]!
0068A66E4  mov      x1, x20
0068A66E8  bl       #0x382bcb8 ; 
0068A66EC  b        #0x68a6700 ; 
0068A66F0  ldr      x8, [x2, #0x60]
0068A66F4  mov      x0, x19
0068A66F8  mov      x1, x20
0068A66FC  blr      x8
0068A6700  mov      x0, x19
0068A6704  mov      x1, xzr
0068A6708  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A670C  adrp     x21, #0x959c000
0068A6710  ldrb     w8, [x21, #0x550]
0068A6714  mov      w20, w0
0068A6718  cbnz     w8, #0x68a6730
0068A671C  adrp     x0, #0x8f26000
0068A6720  ldr      x0, [x0, #0x6b8]
0068A6724  bl       #0x382bd14 ; 
0068A6728  mov      w8, #1
0068A672C  strb     w8, [x21, #0x550]
0068A6730  adrp     x8, #0x8f26000
0068A6734  ldr      x8, [x8, #0x6b8]
0068A6738  ldr      x2, [x8]
0068A673C  ldrb     w8, [x2, #0x53]
0068A6740  tbnz     w8, #5, #0x68a674c
0068A6744  str      w20, [x19, #0xa8]
0068A6748  b        #0x68a675c ; 
0068A674C  ldr      x8, [x2, #0x60]
0068A6750  mov      x0, x19
0068A6754  mov      w1, w20
0068A6758  blr      x8
0068A675C  mov      x0, x19
0068A6760  mov      x1, xzr
0068A6764  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6768  adrp     x21, #0x959c000
0068A676C  ldrb     w8, [x21, #0x551]
0068A6770  mov      w20, w0
0068A6774  cbnz     w8, #0x68a678c
0068A6778  adrp     x0, #0x8f26000
0068A677C  ldr      x0, [x0, #0x6c8]
0068A6780  bl       #0x382bd14 ; 
0068A6784  mov      w8, #1
0068A6788  strb     w8, [x21, #0x551]
0068A678C  adrp     x8, #0x8f26000
0068A6790  ldr      x8, [x8, #0x6c8]
0068A6794  ldr      x2, [x8]
0068A6798  ldrb     w8, [x2, #0x53]
0068A679C  tbnz     w8, #5, #0x68a67a8
0068A67A0  str      w20, [x19, #0xac]
0068A67A4  b        #0x68a67b8 ; 
0068A67A8  ldr      x8, [x2, #0x60]
0068A67AC  mov      x0, x19
0068A67B0  mov      w1, w20
0068A67B4  blr      x8
0068A67B8  mov      x0, x19
0068A67BC  mov      x1, xzr
0068A67C0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068A67C4  adrp     x21, #0x959c000
0068A67C8  ldrb     w8, [x21, #0x552]
0068A67CC  mov      x20, x0
0068A67D0  cbnz     w8, #0x68a67e8
0068A67D4  adrp     x0, #0x8f26000
0068A67D8  ldr      x0, [x0, #0x6d8]
0068A67DC  bl       #0x382bd14 ; 
0068A67E0  mov      w8, #1
0068A67E4  strb     w8, [x21, #0x552]
0068A67E8  adrp     x8, #0x8f26000
0068A67EC  ldr      x8, [x8, #0x6d8]
0068A67F0  ldr      x2, [x8]
0068A67F4  ldrb     w8, [x2, #0x53]
0068A67F8  tbnz     w8, #5, #0x68a6810
0068A67FC  mov      x0, x19
0068A6800  str      x20, [x0, #0xb0]!
0068A6804  mov      x1, x20
0068A6808  bl       #0x382bcb8 ; 
0068A680C  b        #0x68a6820 ; 
0068A6810  ldr      x8, [x2, #0x60]
0068A6814  mov      x0, x19
0068A6818  mov      x1, x20
0068A681C  blr      x8
0068A6820  mov      x0, x19
0068A6824  mov      x1, xzr
0068A6828  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A682C  adrp     x21, #0x959c000
0068A6830  ldrb     w8, [x21, #0x553]
0068A6834  mov      x20, x0
0068A6838  cbnz     w8, #0x68a6850
0068A683C  adrp     x0, #0x8f26000
0068A6840  ldr      x0, [x0, #0x6e8]
0068A6844  bl       #0x382bd14 ; 
0068A6848  mov      w8, #1
0068A684C  strb     w8, [x21, #0x553]
0068A6850  adrp     x8, #0x8f26000
0068A6854  ldr      x8, [x8, #0x6e8]
0068A6858  ldr      x2, [x8]
0068A685C  ldrb     w8, [x2, #0x53]
0068A6860  tbnz     w8, #5, #0x68a6878
0068A6864  mov      x0, x19
0068A6868  str      x20, [x0, #0xb8]!
0068A686C  mov      x1, x20
0068A6870  bl       #0x382bcb8 ; 
0068A6874  b        #0x68a6888 ; 
0068A6878  ldr      x8, [x2, #0x60]
0068A687C  mov      x0, x19
0068A6880  mov      x1, x20
0068A6884  blr      x8
0068A6888  mov      x0, x19
0068A688C  mov      x1, xzr
0068A6890  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A6894  adrp     x21, #0x959c000
0068A6898  ldrb     w8, [x21, #0x554]
0068A689C  mov      x20, x0
0068A68A0  cbnz     w8, #0x68a68b8
0068A68A4  adrp     x0, #0x8f26000
0068A68A8  ldr      x0, [x0, #0x6f0]
0068A68AC  bl       #0x382bd14 ; 
0068A68B0  mov      w8, #1
0068A68B4  strb     w8, [x21, #0x554]
0068A68B8  adrp     x8, #0x8f26000
0068A68BC  ldr      x8, [x8, #0x6f0]
0068A68C0  ldr      x2, [x8]
0068A68C4  ldrb     w8, [x2, #0x53]
0068A68C8  tbnz     w8, #5, #0x68a68e0
0068A68CC  mov      x0, x19
0068A68D0  str      x20, [x0, #0xc0]!
0068A68D4  mov      x1, x20
0068A68D8  bl       #0x382bcb8 ; 
0068A68DC  b        #0x68a68f0 ; 
0068A68E0  ldr      x8, [x2, #0x60]
0068A68E4  mov      x0, x19
0068A68E8  mov      x1, x20
0068A68EC  blr      x8
0068A68F0  mov      x0, x19
0068A68F4  mov      x1, xzr
0068A68F8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A68FC  adrp     x21, #0x959c000
0068A6900  ldrb     w8, [x21, #0x555]
0068A6904  mov      x20, x0
0068A6908  cbnz     w8, #0x68a6920
0068A690C  adrp     x0, #0x8f26000
0068A6910  ldr      x0, [x0, #0x6f8]
0068A6914  bl       #0x382bd14 ; 
0068A6918  mov      w8, #1
0068A691C  strb     w8, [x21, #0x555]
0068A6920  adrp     x8, #0x8f26000
0068A6924  ldr      x8, [x8, #0x6f8]
0068A6928  ldr      x2, [x8]
0068A692C  ldrb     w8, [x2, #0x53]
0068A6930  tbnz     w8, #5, #0x68a6948
0068A6934  mov      x0, x19
0068A6938  str      x20, [x0, #0xc8]!
0068A693C  mov      x1, x20
0068A6940  bl       #0x382bcb8 ; 
0068A6944  b        #0x68a6958 ; 
0068A6948  ldr      x8, [x2, #0x60]
0068A694C  mov      x0, x19
0068A6950  mov      x1, x20
0068A6954  blr      x8
0068A6958  mov      x0, x19
0068A695C  mov      x1, xzr
0068A6960  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6964  adrp     x21, #0x959c000
0068A6968  ldrb     w8, [x21, #0x556]
0068A696C  mov      w20, w0
0068A6970  cbnz     w8, #0x68a6988
0068A6974  adrp     x0, #0x8f26000
0068A6978  ldr      x0, [x0, #0x700]
0068A697C  bl       #0x382bd14 ; 
0068A6980  mov      w8, #1
0068A6984  strb     w8, [x21, #0x556]
0068A6988  adrp     x8, #0x8f26000
0068A698C  ldr      x8, [x8, #0x700]
0068A6990  ldr      x2, [x8]
0068A6994  ldrb     w8, [x2, #0x53]
0068A6998  tbnz     w8, #5, #0x68a69a4
0068A699C  str      w20, [x19, #0xd0]
0068A69A0  b        #0x68a69b4 ; 
0068A69A4  ldr      x8, [x2, #0x60]
0068A69A8  mov      x0, x19
0068A69AC  mov      w1, w20
0068A69B0  blr      x8
0068A69B4  mov      x0, x19
0068A69B8  mov      x1, xzr
0068A69BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A69C0  adrp     x21, #0x959c000
0068A69C4  ldrb     w8, [x21, #0x557]
0068A69C8  mov      w20, w0
0068A69CC  cbnz     w8, #0x68a69e4
0068A69D0  adrp     x0, #0x8f26000
0068A69D4  ldr      x0, [x0, #0x708]
0068A69D8  bl       #0x382bd14 ; 
0068A69DC  mov      w8, #1
0068A69E0  strb     w8, [x21, #0x557]
0068A69E4  adrp     x8, #0x8f26000
0068A69E8  ldr      x8, [x8, #0x708]
0068A69EC  ldr      x2, [x8]
0068A69F0  ldrb     w8, [x2, #0x53]
0068A69F4  tbnz     w8, #5, #0x68a6a00
0068A69F8  str      w20, [x19, #0xd4]
0068A69FC  b        #0x68a6a10 ; 
0068A6A00  ldr      x8, [x2, #0x60]
0068A6A04  mov      x0, x19
0068A6A08  mov      w1, w20
0068A6A0C  blr      x8
0068A6A10  mov      x0, x19
0068A6A14  mov      x1, xzr
0068A6A18  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A6A1C  adrp     x21, #0x959c000
0068A6A20  ldrb     w8, [x21, #0x558]
0068A6A24  mov      x20, x0
0068A6A28  cbnz     w8, #0x68a6a40
0068A6A2C  adrp     x0, #0x8f26000
0068A6A30  ldr      x0, [x0, #0x710]
0068A6A34  bl       #0x382bd14 ; 
0068A6A38  mov      w8, #1
0068A6A3C  strb     w8, [x21, #0x558]
0068A6A40  adrp     x8, #0x8f26000
0068A6A44  ldr      x8, [x8, #0x710]
0068A6A48  ldr      x2, [x8]
0068A6A4C  ldrb     w8, [x2, #0x53]
0068A6A50  tbnz     w8, #5, #0x68a6a68
0068A6A54  mov      x0, x19
0068A6A58  str      x20, [x0, #0xd8]!
0068A6A5C  mov      x1, x20
0068A6A60  bl       #0x382bcb8 ; 
0068A6A64  b        #0x68a6a78 ; 
0068A6A68  ldr      x8, [x2, #0x60]
0068A6A6C  mov      x0, x19
0068A6A70  mov      x1, x20
0068A6A74  blr      x8
0068A6A78  mov      x0, x19
0068A6A7C  mov      x1, xzr
0068A6A80  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A6A84  adrp     x21, #0x959c000
0068A6A88  ldrb     w8, [x21, #0x559]
0068A6A8C  mov      x20, x0
0068A6A90  cbnz     w8, #0x68a6aa8
0068A6A94  adrp     x0, #0x8f26000
0068A6A98  ldr      x0, [x0, #0x718]
0068A6A9C  bl       #0x382bd14 ; 
0068A6AA0  mov      w8, #1
0068A6AA4  strb     w8, [x21, #0x559]
0068A6AA8  adrp     x8, #0x8f26000
0068A6AAC  ldr      x8, [x8, #0x718]
0068A6AB0  ldr      x2, [x8]
0068A6AB4  ldrb     w8, [x2, #0x53]
0068A6AB8  tbnz     w8, #5, #0x68a6ad0
0068A6ABC  mov      x0, x19
0068A6AC0  str      x20, [x0, #0xe0]!
0068A6AC4  mov      x1, x20
0068A6AC8  bl       #0x382bcb8 ; 
0068A6ACC  b        #0x68a6ae0 ; 
0068A6AD0  ldr      x8, [x2, #0x60]
0068A6AD4  mov      x0, x19
0068A6AD8  mov      x1, x20
0068A6ADC  blr      x8
0068A6AE0  mov      x0, x19
0068A6AE4  mov      x1, xzr
0068A6AE8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6AEC  adrp     x21, #0x959c000
0068A6AF0  ldrb     w8, [x21, #0x55a]
0068A6AF4  mov      w20, w0
0068A6AF8  cbnz     w8, #0x68a6b10
0068A6AFC  adrp     x0, #0x8f26000
0068A6B00  ldr      x0, [x0, #0x728]
0068A6B04  bl       #0x382bd14 ; 
0068A6B08  mov      w8, #1
0068A6B0C  strb     w8, [x21, #0x55a]
0068A6B10  adrp     x8, #0x8f26000
0068A6B14  ldr      x8, [x8, #0x728]
0068A6B18  ldr      x2, [x8]
0068A6B1C  ldrb     w8, [x2, #0x53]
0068A6B20  tbnz     w8, #5, #0x68a6b2c
0068A6B24  str      w20, [x19, #0xe8]
0068A6B28  b        #0x68a6b3c ; 
0068A6B2C  ldr      x8, [x2, #0x60]
0068A6B30  mov      x0, x19
0068A6B34  mov      w1, w20
0068A6B38  blr      x8
0068A6B3C  mov      x0, x19
0068A6B40  mov      x1, xzr
0068A6B44  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A6B48  adrp     x21, #0x959c000
0068A6B4C  ldrb     w8, [x21, #0x55b]
0068A6B50  mov      x20, x0
0068A6B54  cbnz     w8, #0x68a6b6c
0068A6B58  adrp     x0, #0x8f26000
0068A6B5C  ldr      x0, [x0, #0x730]
0068A6B60  bl       #0x382bd14 ; 
0068A6B64  mov      w8, #1
0068A6B68  strb     w8, [x21, #0x55b]
0068A6B6C  adrp     x8, #0x8f26000
0068A6B70  ldr      x8, [x8, #0x730]
0068A6B74  ldr      x2, [x8]
0068A6B78  ldrb     w8, [x2, #0x53]
0068A6B7C  tbnz     w8, #5, #0x68a6b94
0068A6B80  mov      x0, x19
0068A6B84  str      x20, [x0, #0xf0]!
0068A6B88  mov      x1, x20
0068A6B8C  bl       #0x382bcb8 ; 
0068A6B90  b        #0x68a6ba4 ; 
0068A6B94  ldr      x8, [x2, #0x60]
0068A6B98  mov      x0, x19
0068A6B9C  mov      x1, x20
0068A6BA0  blr      x8
0068A6BA4  mov      x0, x19
0068A6BA8  mov      x1, xzr
0068A6BAC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A6BB0  adrp     x21, #0x959c000
0068A6BB4  ldrb     w8, [x21, #0x55c]
0068A6BB8  mov      x20, x0
0068A6BBC  cbnz     w8, #0x68a6bd4
0068A6BC0  adrp     x0, #0x8f26000
0068A6BC4  ldr      x0, [x0, #0x740]
0068A6BC8  bl       #0x382bd14 ; 
0068A6BCC  mov      w8, #1
0068A6BD0  strb     w8, [x21, #0x55c]
0068A6BD4  adrp     x8, #0x8f26000
0068A6BD8  ldr      x8, [x8, #0x740]
0068A6BDC  ldr      x2, [x8]
0068A6BE0  ldrb     w8, [x2, #0x53]
0068A6BE4  tbnz     w8, #5, #0x68a6bfc
0068A6BE8  mov      x0, x19
0068A6BEC  str      x20, [x0, #0xf8]!
0068A6BF0  mov      x1, x20
0068A6BF4  bl       #0x382bcb8 ; 
0068A6BF8  b        #0x68a6c0c ; 
0068A6BFC  ldr      x8, [x2, #0x60]
0068A6C00  mov      x0, x19
0068A6C04  mov      x1, x20
0068A6C08  blr      x8
0068A6C0C  mov      x0, x19
0068A6C10  mov      x1, xzr
0068A6C14  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A6C18  adrp     x21, #0x959c000
0068A6C1C  ldrb     w8, [x21, #0x55d]
0068A6C20  mov      x20, x0
0068A6C24  cbnz     w8, #0x68a6c3c
0068A6C28  adrp     x0, #0x8f26000
0068A6C2C  ldr      x0, [x0, #0x750]
0068A6C30  bl       #0x382bd14 ; 
0068A6C34  mov      w8, #1
0068A6C38  strb     w8, [x21, #0x55d]
0068A6C3C  adrp     x8, #0x8f26000
0068A6C40  ldr      x8, [x8, #0x750]
0068A6C44  ldr      x2, [x8]
0068A6C48  ldrb     w8, [x2, #0x53]
0068A6C4C  tbnz     w8, #5, #0x68a6c64
0068A6C50  add      x0, x19, #0x100
0068A6C54  mov      x1, x20
0068A6C58  str      x20, [x19, #0x100]
0068A6C5C  bl       #0x382bcb8 ; 
0068A6C60  b        #0x68a6c74 ; 
0068A6C64  ldr      x8, [x2, #0x60]
0068A6C68  mov      x0, x19
0068A6C6C  mov      x1, x20
0068A6C70  blr      x8
0068A6C74  mov      x0, x19
0068A6C78  mov      x1, xzr
0068A6C7C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068A6C80  adrp     x21, #0x959c000
0068A6C84  ldrb     w8, [x21, #0x55e]
0068A6C88  mov      x20, x0
0068A6C8C  cbnz     w8, #0x68a6ca4
0068A6C90  adrp     x0, #0x8f26000
0068A6C94  ldr      x0, [x0, #0x760]
0068A6C98  bl       #0x382bd14 ; 
0068A6C9C  mov      w8, #1
0068A6CA0  strb     w8, [x21, #0x55e]
0068A6CA4  adrp     x8, #0x8f26000
0068A6CA8  ldr      x8, [x8, #0x760]
0068A6CAC  ldr      x2, [x8]
0068A6CB0  ldrb     w8, [x2, #0x53]
0068A6CB4  tbnz     w8, #5, #0x68a6ccc
0068A6CB8  add      x0, x19, #0x108
0068A6CBC  mov      x1, x20
0068A6CC0  str      x20, [x19, #0x108]
0068A6CC4  bl       #0x382bcb8 ; 
0068A6CC8  b        #0x68a6cdc ; 
0068A6CCC  ldr      x8, [x2, #0x60]
0068A6CD0  mov      x0, x19
0068A6CD4  mov      x1, x20
0068A6CD8  blr      x8
0068A6CDC  mov      x0, x19
0068A6CE0  mov      x1, xzr
0068A6CE4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6CE8  adrp     x21, #0x959c000
0068A6CEC  ldrb     w8, [x21, #0x55f]
0068A6CF0  mov      w20, w0
0068A6CF4  cbnz     w8, #0x68a6d0c
0068A6CF8  adrp     x0, #0x8f26000
0068A6CFC  ldr      x0, [x0, #0x770]
0068A6D00  bl       #0x382bd14 ; 
0068A6D04  mov      w8, #1
0068A6D08  strb     w8, [x21, #0x55f]
0068A6D0C  adrp     x8, #0x8f26000
0068A6D10  ldr      x8, [x8, #0x770]
0068A6D14  ldr      x2, [x8]
0068A6D18  ldrb     w8, [x2, #0x53]
0068A6D1C  tbnz     w8, #5, #0x68a6d28
0068A6D20  str      w20, [x19, #0x110]
0068A6D24  b        #0x68a6d38 ; 
0068A6D28  ldr      x8, [x2, #0x60]
0068A6D2C  mov      x0, x19
0068A6D30  mov      w1, w20
0068A6D34  blr      x8
0068A6D38  mov      x0, x19
0068A6D3C  mov      x1, xzr
0068A6D40  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6D44  adrp     x21, #0x959c000
0068A6D48  ldrb     w8, [x21, #0x560]
0068A6D4C  mov      w20, w0
0068A6D50  cbnz     w8, #0x68a6d68
0068A6D54  adrp     x0, #0x8f26000
0068A6D58  ldr      x0, [x0, #0x780]
0068A6D5C  bl       #0x382bd14 ; 
0068A6D60  mov      w8, #1
0068A6D64  strb     w8, [x21, #0x560]
0068A6D68  adrp     x8, #0x8f26000
0068A6D6C  ldr      x8, [x8, #0x780]
0068A6D70  ldr      x2, [x8]
0068A6D74  ldrb     w8, [x2, #0x53]
0068A6D78  tbnz     w8, #5, #0x68a6d84
0068A6D7C  str      w20, [x19, #0x114]
0068A6D80  b        #0x68a6d94 ; 
0068A6D84  ldr      x8, [x2, #0x60]
0068A6D88  mov      x0, x19
0068A6D8C  mov      w1, w20
0068A6D90  blr      x8
0068A6D94  mov      x0, x19
0068A6D98  mov      x1, xzr
0068A6D9C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6DA0  adrp     x21, #0x959c000
0068A6DA4  ldrb     w8, [x21, #0x561]
0068A6DA8  mov      w20, w0
0068A6DAC  cbnz     w8, #0x68a6dc4
0068A6DB0  adrp     x0, #0x8f26000
0068A6DB4  ldr      x0, [x0, #0x788]
0068A6DB8  bl       #0x382bd14 ; 
0068A6DBC  mov      w8, #1
0068A6DC0  strb     w8, [x21, #0x561]
0068A6DC4  adrp     x8, #0x8f26000
0068A6DC8  ldr      x8, [x8, #0x788]
0068A6DCC  ldr      x2, [x8]
0068A6DD0  ldrb     w8, [x2, #0x53]
0068A6DD4  tbnz     w8, #5, #0x68a6de0
0068A6DD8  str      w20, [x19, #0x118]
0068A6DDC  b        #0x68a6df0 ; 
0068A6DE0  ldr      x8, [x2, #0x60]
0068A6DE4  mov      x0, x19
0068A6DE8  mov      w1, w20
0068A6DEC  blr      x8
0068A6DF0  mov      x0, x19
0068A6DF4  mov      x1, xzr
0068A6DF8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6DFC  adrp     x21, #0x959c000
0068A6E00  ldrb     w8, [x21, #0x562]
0068A6E04  mov      w20, w0
0068A6E08  cbnz     w8, #0x68a6e20
0068A6E0C  adrp     x0, #0x8f26000
0068A6E10  ldr      x0, [x0, #0x790]
0068A6E14  bl       #0x382bd14 ; 
0068A6E18  mov      w8, #1
0068A6E1C  strb     w8, [x21, #0x562]
0068A6E20  adrp     x8, #0x8f26000
0068A6E24  ldr      x8, [x8, #0x790]
0068A6E28  ldr      x2, [x8]
0068A6E2C  ldrb     w8, [x2, #0x53]
0068A6E30  tbnz     w8, #5, #0x68a6e3c
0068A6E34  str      w20, [x19, #0x11c]
0068A6E38  b        #0x68a6e4c ; 
0068A6E3C  ldr      x8, [x2, #0x60]
0068A6E40  mov      x0, x19
0068A6E44  mov      w1, w20
0068A6E48  blr      x8
0068A6E4C  mov      x0, x19
0068A6E50  mov      x1, xzr
0068A6E54  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6E58  adrp     x21, #0x959c000
0068A6E5C  ldrb     w8, [x21, #0x563]
0068A6E60  mov      w20, w0
0068A6E64  cbnz     w8, #0x68a6e7c
0068A6E68  adrp     x0, #0x8f26000
0068A6E6C  ldr      x0, [x0, #0x798]
0068A6E70  bl       #0x382bd14 ; 
0068A6E74  mov      w8, #1
0068A6E78  strb     w8, [x21, #0x563]
0068A6E7C  adrp     x8, #0x8f26000
0068A6E80  ldr      x8, [x8, #0x798]
0068A6E84  ldr      x2, [x8]
0068A6E88  ldrb     w8, [x2, #0x53]
0068A6E8C  tbnz     w8, #5, #0x68a6e98
0068A6E90  str      w20, [x19, #0x120]
0068A6E94  b        #0x68a6ea8 ; 
0068A6E98  ldr      x8, [x2, #0x60]
0068A6E9C  mov      x0, x19
0068A6EA0  mov      w1, w20
0068A6EA4  blr      x8
0068A6EA8  mov      x0, x19
0068A6EAC  mov      x1, xzr
0068A6EB0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6EB4  adrp     x21, #0x959c000
0068A6EB8  ldrb     w8, [x21, #0x564]
0068A6EBC  mov      w20, w0
0068A6EC0  cbnz     w8, #0x68a6ed8
0068A6EC4  adrp     x0, #0x8f26000
0068A6EC8  ldr      x0, [x0, #0x7a0]
0068A6ECC  bl       #0x382bd14 ; 
0068A6ED0  mov      w8, #1
0068A6ED4  strb     w8, [x21, #0x564]
0068A6ED8  adrp     x8, #0x8f26000
0068A6EDC  ldr      x8, [x8, #0x7a0]
0068A6EE0  ldr      x2, [x8]
0068A6EE4  ldrb     w8, [x2, #0x53]
0068A6EE8  tbnz     w8, #5, #0x68a6ef4
0068A6EEC  str      w20, [x19, #0x124]
0068A6EF0  b        #0x68a6f04 ; 
0068A6EF4  ldr      x8, [x2, #0x60]
0068A6EF8  mov      x0, x19
0068A6EFC  mov      w1, w20
0068A6F00  blr      x8
0068A6F04  mov      x0, x19
0068A6F08  mov      x1, xzr
0068A6F0C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6F10  adrp     x21, #0x959c000
0068A6F14  ldrb     w8, [x21, #0x565]
0068A6F18  mov      w20, w0
0068A6F1C  cbnz     w8, #0x68a6f34
0068A6F20  adrp     x0, #0x8f26000
0068A6F24  ldr      x0, [x0, #0x7a8]
0068A6F28  bl       #0x382bd14 ; 
0068A6F2C  mov      w8, #1
0068A6F30  strb     w8, [x21, #0x565]
0068A6F34  adrp     x8, #0x8f26000
0068A6F38  ldr      x8, [x8, #0x7a8]
0068A6F3C  ldr      x2, [x8]
0068A6F40  ldrb     w8, [x2, #0x53]
0068A6F44  tbnz     w8, #5, #0x68a6f50
0068A6F48  str      w20, [x19, #0x128]
0068A6F4C  b        #0x68a6f60 ; 
0068A6F50  ldr      x8, [x2, #0x60]
0068A6F54  mov      x0, x19
0068A6F58  mov      w1, w20
0068A6F5C  blr      x8
0068A6F60  mov      x0, x19
0068A6F64  mov      x1, xzr
0068A6F68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6F6C  adrp     x21, #0x959c000
0068A6F70  ldrb     w8, [x21, #0x566]
0068A6F74  mov      w20, w0
0068A6F78  cbnz     w8, #0x68a6f90
0068A6F7C  adrp     x0, #0x8f26000
0068A6F80  ldr      x0, [x0, #0x7b8]
0068A6F84  bl       #0x382bd14 ; 
0068A6F88  mov      w8, #1
0068A6F8C  strb     w8, [x21, #0x566]
0068A6F90  adrp     x8, #0x8f26000
0068A6F94  ldr      x8, [x8, #0x7b8]
0068A6F98  ldr      x2, [x8]
0068A6F9C  ldrb     w8, [x2, #0x53]
0068A6FA0  tbnz     w8, #5, #0x68a6fac
0068A6FA4  str      w20, [x19, #0x12c]
0068A6FA8  b        #0x68a6fbc ; 
0068A6FAC  ldr      x8, [x2, #0x60]
0068A6FB0  mov      x0, x19
0068A6FB4  mov      w1, w20
0068A6FB8  blr      x8
0068A6FBC  mov      x0, x19
0068A6FC0  mov      x1, xzr
0068A6FC4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A6FC8  adrp     x21, #0x959c000
0068A6FCC  ldrb     w8, [x21, #0x567]
0068A6FD0  mov      w20, w0
0068A6FD4  cbnz     w8, #0x68a6fec
0068A6FD8  adrp     x0, #0x8f26000
0068A6FDC  ldr      x0, [x0, #0x7c8]
0068A6FE0  bl       #0x382bd14 ; 
0068A6FE4  mov      w8, #1
0068A6FE8  strb     w8, [x21, #0x567]
0068A6FEC  adrp     x8, #0x8f26000
0068A6FF0  ldr      x8, [x8, #0x7c8]
0068A6FF4  ldr      x2, [x8]
0068A6FF8  ldrb     w8, [x2, #0x53]
0068A6FFC  tbnz     w8, #5, #0x68a7008
0068A7000  str      w20, [x19, #0x130]
0068A7004  b        #0x68a7018 ; 
0068A7008  ldr      x8, [x2, #0x60]
0068A700C  mov      x0, x19
0068A7010  mov      w1, w20
0068A7014  blr      x8
0068A7018  mov      x0, x19
0068A701C  mov      x1, xzr
0068A7020  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A7024  adrp     x21, #0x959c000
0068A7028  ldrb     w8, [x21, #0x568]
0068A702C  mov      w20, w0
0068A7030  cbnz     w8, #0x68a7048
0068A7034  adrp     x0, #0x8f26000
0068A7038  ldr      x0, [x0, #0x7d8]
0068A703C  bl       #0x382bd14 ; 
0068A7040  mov      w8, #1
0068A7044  strb     w8, [x21, #0x568]
0068A7048  adrp     x8, #0x8f26000
0068A704C  ldr      x8, [x8, #0x7d8]
0068A7050  ldr      x2, [x8]
0068A7054  ldrb     w8, [x2, #0x53]
0068A7058  tbnz     w8, #5, #0x68a7064
0068A705C  str      w20, [x19, #0x134]
0068A7060  b        #0x68a7074 ; 
0068A7064  ldr      x8, [x2, #0x60]
0068A7068  mov      x0, x19
0068A706C  mov      w1, w20
0068A7070  blr      x8
0068A7074  mov      x0, x19
0068A7078  mov      x1, xzr
0068A707C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A7080  adrp     x21, #0x959c000
0068A7084  ldrb     w8, [x21, #0x569]
0068A7088  mov      w20, w0
0068A708C  cbnz     w8, #0x68a70a4
0068A7090  adrp     x0, #0x8f26000
0068A7094  ldr      x0, [x0, #0x7e8]
0068A7098  bl       #0x382bd14 ; 
0068A709C  mov      w8, #1
0068A70A0  strb     w8, [x21, #0x569]
0068A70A4  adrp     x8, #0x8f26000
0068A70A8  ldr      x8, [x8, #0x7e8]
0068A70AC  ldr      x2, [x8]
0068A70B0  ldrb     w8, [x2, #0x53]
0068A70B4  tbnz     w8, #5, #0x68a70c0
0068A70B8  str      w20, [x19, #0x138]
0068A70BC  b        #0x68a70d0 ; 
0068A70C0  ldr      x8, [x2, #0x60]
0068A70C4  mov      x0, x19
0068A70C8  mov      w1, w20
0068A70CC  blr      x8
0068A70D0  ldp      x20, x19, [sp, #0x10]
0068A70D4  mov      w0, #1
0068A70D8  ldp      x30, x21, [sp], #0x20
0068A70DC  ret      

