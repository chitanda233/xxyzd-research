; LocalModels.Bean.Character_AttackPos$$readImpl
; RVA 0x68BE150; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068BE150  stp      x30, x21, [sp, #-0x20]!
0068BE154  stp      x20, x19, [sp, #0x10]
0068BE158  adrp     x20, #0x959c000
0068BE15C  adrp     x21, #0x8f27000
0068BE160  ldrb     w8, [x20, #0x1d0]
0068BE164  ldr      x21, [x21, #0x9f0]
0068BE168  mov      x19, x0
0068BE16C  tbnz     w8, #0, #0x68be184
0068BE170  adrp     x0, #0x8f27000
0068BE174  ldr      x0, [x0, #0x9f0]
0068BE178  bl       #0x382bd14 ; 
0068BE17C  mov      w8, #1
0068BE180  strb     w8, [x20, #0x1d0]
0068BE184  ldr      x1, [x21]
0068BE188  ldrb     w8, [x1, #0x53]
0068BE18C  tbnz     w8, #5, #0x68be1dc
0068BE190  mov      x0, x19
0068BE194  mov      x1, xzr
0068BE198  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BE19C  adrp     x21, #0x959c000
0068BE1A0  ldrb     w8, [x21, #0x680]
0068BE1A4  mov      w20, w0
0068BE1A8  cbnz     w8, #0x68be1c0
0068BE1AC  adrp     x0, #0x8f27000
0068BE1B0  ldr      x0, [x0, #0x958]
0068BE1B4  bl       #0x382bd14 ; 
0068BE1B8  mov      w8, #1
0068BE1BC  strb     w8, [x21, #0x680]
0068BE1C0  adrp     x8, #0x8f27000
0068BE1C4  ldr      x8, [x8, #0x958]
0068BE1C8  ldr      x2, [x8]
0068BE1CC  ldrb     w8, [x2, #0x53]
0068BE1D0  tbnz     w8, #5, #0x68be1f0
0068BE1D4  str      w20, [x19, #0x20]
0068BE1D8  b        #0x68be200 ; 
0068BE1DC  ldr      x2, [x1, #0x60]
0068BE1E0  mov      x0, x19
0068BE1E4  ldp      x20, x19, [sp, #0x10]
0068BE1E8  ldp      x30, x21, [sp], #0x20
0068BE1EC  br       x2
0068BE1F0  ldr      x8, [x2, #0x60]
0068BE1F4  mov      x0, x19
0068BE1F8  mov      w1, w20
0068BE1FC  blr      x8
0068BE200  mov      x0, x19
0068BE204  mov      x1, xzr
0068BE208  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068BE20C  adrp     x21, #0x959c000
0068BE210  ldrb     w8, [x21, #0x681]
0068BE214  mov      x20, x0
0068BE218  cbnz     w8, #0x68be230
0068BE21C  adrp     x0, #0x8f27000
0068BE220  ldr      x0, [x0, #0x968]
0068BE224  bl       #0x382bd14 ; 
0068BE228  mov      w8, #1
0068BE22C  strb     w8, [x21, #0x681]
0068BE230  adrp     x8, #0x8f27000
0068BE234  ldr      x8, [x8, #0x968]
0068BE238  ldr      x2, [x8]
0068BE23C  ldrb     w8, [x2, #0x53]
0068BE240  tbnz     w8, #5, #0x68be258
0068BE244  mov      x0, x19
0068BE248  str      x20, [x0, #0x28]!
0068BE24C  mov      x1, x20
0068BE250  bl       #0x382bcb8 ; 
0068BE254  b        #0x68be268 ; 
0068BE258  ldr      x8, [x2, #0x60]
0068BE25C  mov      x0, x19
0068BE260  mov      x1, x20
0068BE264  blr      x8
0068BE268  mov      x0, x19
0068BE26C  mov      x1, xzr
0068BE270  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BE274  adrp     x21, #0x959c000
0068BE278  ldrb     w8, [x21, #0x682]
0068BE27C  mov      w20, w0
0068BE280  cbnz     w8, #0x68be298
0068BE284  adrp     x0, #0x8f27000
0068BE288  ldr      x0, [x0, #0x978]
0068BE28C  bl       #0x382bd14 ; 
0068BE290  mov      w8, #1
0068BE294  strb     w8, [x21, #0x682]
0068BE298  adrp     x8, #0x8f27000
0068BE29C  ldr      x8, [x8, #0x978]
0068BE2A0  ldr      x2, [x8]
0068BE2A4  ldrb     w8, [x2, #0x53]
0068BE2A8  tbnz     w8, #5, #0x68be2b4
0068BE2AC  str      w20, [x19, #0x30]
0068BE2B0  b        #0x68be2c4 ; 
0068BE2B4  ldr      x8, [x2, #0x60]
0068BE2B8  mov      x0, x19
0068BE2BC  mov      w1, w20
0068BE2C0  blr      x8
0068BE2C4  mov      x0, x19
0068BE2C8  mov      x1, xzr
0068BE2CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BE2D0  adrp     x21, #0x959c000
0068BE2D4  ldrb     w8, [x21, #0x683]
0068BE2D8  mov      w20, w0
0068BE2DC  cbnz     w8, #0x68be2f4
0068BE2E0  adrp     x0, #0x8f27000
0068BE2E4  ldr      x0, [x0, #0x988]
0068BE2E8  bl       #0x382bd14 ; 
0068BE2EC  mov      w8, #1
0068BE2F0  strb     w8, [x21, #0x683]
0068BE2F4  adrp     x8, #0x8f27000
0068BE2F8  ldr      x8, [x8, #0x988]
0068BE2FC  ldr      x2, [x8]
0068BE300  ldrb     w8, [x2, #0x53]
0068BE304  tbnz     w8, #5, #0x68be310
0068BE308  str      w20, [x19, #0x34]
0068BE30C  b        #0x68be320 ; 
0068BE310  ldr      x8, [x2, #0x60]
0068BE314  mov      x0, x19
0068BE318  mov      w1, w20
0068BE31C  blr      x8
0068BE320  mov      x0, x19
0068BE324  mov      x1, xzr
0068BE328  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BE32C  adrp     x21, #0x959c000
0068BE330  ldrb     w8, [x21, #0x684]
0068BE334  mov      w20, w0
0068BE338  cbnz     w8, #0x68be350
0068BE33C  adrp     x0, #0x8f27000
0068BE340  ldr      x0, [x0, #0x998]
0068BE344  bl       #0x382bd14 ; 
0068BE348  mov      w8, #1
0068BE34C  strb     w8, [x21, #0x684]
0068BE350  adrp     x8, #0x8f27000
0068BE354  ldr      x8, [x8, #0x998]
0068BE358  ldr      x2, [x8]
0068BE35C  ldrb     w8, [x2, #0x53]
0068BE360  tbnz     w8, #5, #0x68be36c
0068BE364  str      w20, [x19, #0x38]
0068BE368  b        #0x68be37c ; 
0068BE36C  ldr      x8, [x2, #0x60]
0068BE370  mov      x0, x19
0068BE374  mov      w1, w20
0068BE378  blr      x8
0068BE37C  mov      x0, x19
0068BE380  mov      x1, xzr
0068BE384  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BE388  adrp     x21, #0x959c000
0068BE38C  ldrb     w8, [x21, #0x685]
0068BE390  mov      w20, w0
0068BE394  cbnz     w8, #0x68be3ac
0068BE398  adrp     x0, #0x8f27000
0068BE39C  ldr      x0, [x0, #0x9a8]
0068BE3A0  bl       #0x382bd14 ; 
0068BE3A4  mov      w8, #1
0068BE3A8  strb     w8, [x21, #0x685]
0068BE3AC  adrp     x8, #0x8f27000
0068BE3B0  ldr      x8, [x8, #0x9a8]
0068BE3B4  ldr      x2, [x8]
0068BE3B8  ldrb     w8, [x2, #0x53]
0068BE3BC  tbnz     w8, #5, #0x68be3c8
0068BE3C0  str      w20, [x19, #0x3c]
0068BE3C4  b        #0x68be3d8 ; 
0068BE3C8  ldr      x8, [x2, #0x60]
0068BE3CC  mov      x0, x19
0068BE3D0  mov      w1, w20
0068BE3D4  blr      x8
0068BE3D8  mov      x0, x19
0068BE3DC  mov      x1, xzr
0068BE3E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BE3E4  adrp     x21, #0x959c000
0068BE3E8  ldrb     w8, [x21, #0x686]
0068BE3EC  mov      w20, w0
0068BE3F0  cbnz     w8, #0x68be408
0068BE3F4  adrp     x0, #0x8f27000
0068BE3F8  ldr      x0, [x0, #0x9b8]
0068BE3FC  bl       #0x382bd14 ; 
0068BE400  mov      w8, #1
0068BE404  strb     w8, [x21, #0x686]
0068BE408  adrp     x8, #0x8f27000
0068BE40C  ldr      x8, [x8, #0x9b8]
0068BE410  ldr      x2, [x8]
0068BE414  ldrb     w8, [x2, #0x53]
0068BE418  tbnz     w8, #5, #0x68be424
0068BE41C  str      w20, [x19, #0x40]
0068BE420  b        #0x68be434 ; 
0068BE424  ldr      x8, [x2, #0x60]
0068BE428  mov      x0, x19
0068BE42C  mov      w1, w20
0068BE430  blr      x8
0068BE434  mov      x0, x19
0068BE438  mov      x1, xzr
0068BE43C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BE440  adrp     x21, #0x959c000
0068BE444  ldrb     w8, [x21, #0x687]
0068BE448  mov      w20, w0
0068BE44C  cbnz     w8, #0x68be464
0068BE450  adrp     x0, #0x8f27000
0068BE454  ldr      x0, [x0, #0x9c8]
0068BE458  bl       #0x382bd14 ; 
0068BE45C  mov      w8, #1
0068BE460  strb     w8, [x21, #0x687]
0068BE464  adrp     x8, #0x8f27000
0068BE468  ldr      x8, [x8, #0x9c8]
0068BE46C  ldr      x2, [x8]
0068BE470  ldrb     w8, [x2, #0x53]
0068BE474  tbnz     w8, #5, #0x68be480
0068BE478  str      w20, [x19, #0x44]
0068BE47C  b        #0x68be490 ; 
0068BE480  ldr      x8, [x2, #0x60]
0068BE484  mov      x0, x19
0068BE488  mov      w1, w20
0068BE48C  blr      x8
0068BE490  mov      x0, x19
0068BE494  mov      x1, xzr
0068BE498  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BE49C  adrp     x21, #0x959c000
0068BE4A0  ldrb     w8, [x21, #0x688]
0068BE4A4  mov      w20, w0
0068BE4A8  cbnz     w8, #0x68be4c0
0068BE4AC  adrp     x0, #0x8f27000
0068BE4B0  ldr      x0, [x0, #0x9d8]
0068BE4B4  bl       #0x382bd14 ; 
0068BE4B8  mov      w8, #1
0068BE4BC  strb     w8, [x21, #0x688]
0068BE4C0  adrp     x8, #0x8f27000
0068BE4C4  ldr      x8, [x8, #0x9d8]
0068BE4C8  ldr      x2, [x8]
0068BE4CC  ldrb     w8, [x2, #0x53]
0068BE4D0  tbnz     w8, #5, #0x68be4dc
0068BE4D4  str      w20, [x19, #0x48]
0068BE4D8  b        #0x68be4ec ; 
0068BE4DC  ldr      x8, [x2, #0x60]
0068BE4E0  mov      x0, x19
0068BE4E4  mov      w1, w20
0068BE4E8  blr      x8
0068BE4EC  mov      x0, x19
0068BE4F0  mov      x1, xzr
0068BE4F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068BE4F8  adrp     x21, #0x959c000
0068BE4FC  ldrb     w8, [x21, #0x689]
0068BE500  mov      w20, w0
0068BE504  cbnz     w8, #0x68be51c
0068BE508  adrp     x0, #0x8f27000
0068BE50C  ldr      x0, [x0, #0x9e8]
0068BE510  bl       #0x382bd14 ; 
0068BE514  mov      w8, #1
0068BE518  strb     w8, [x21, #0x689]
0068BE51C  adrp     x8, #0x8f27000
0068BE520  ldr      x8, [x8, #0x9e8]
0068BE524  ldr      x2, [x8]
0068BE528  ldrb     w8, [x2, #0x53]
0068BE52C  tbnz     w8, #5, #0x68be538
0068BE530  str      w20, [x19, #0x4c]
0068BE534  b        #0x68be548 ; 
0068BE538  ldr      x8, [x2, #0x60]
0068BE53C  mov      x0, x19
0068BE540  mov      w1, w20
0068BE544  blr      x8
0068BE548  ldp      x20, x19, [sp, #0x10]
0068BE54C  mov      w0, #1
0068BE550  ldp      x30, x21, [sp], #0x20
0068BE554  ret      

