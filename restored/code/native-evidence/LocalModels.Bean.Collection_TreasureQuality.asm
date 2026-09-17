; LocalModels.Bean.Collection_TreasureQuality$$readImpl
; RVA 0x68CD280; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068CD280  stp      x30, x21, [sp, #-0x20]!
0068CD284  stp      x20, x19, [sp, #0x10]
0068CD288  adrp     x20, #0x959c000
0068CD28C  adrp     x21, #0x8f28000
0068CD290  ldrb     w8, [x20, #0x35a]
0068CD294  ldr      x21, [x21, #0x458]
0068CD298  mov      x19, x0
0068CD29C  tbnz     w8, #0, #0x68cd2b4
0068CD2A0  adrp     x0, #0x8f28000
0068CD2A4  ldr      x0, [x0, #0x458]
0068CD2A8  bl       #0x382bd14 ; 
0068CD2AC  mov      w8, #1
0068CD2B0  strb     w8, [x20, #0x35a]
0068CD2B4  ldr      x1, [x21]
0068CD2B8  ldrb     w8, [x1, #0x53]
0068CD2BC  tbnz     w8, #5, #0x68cd30c
0068CD2C0  mov      x0, x19
0068CD2C4  mov      x1, xzr
0068CD2C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CD2CC  adrp     x21, #0x959c000
0068CD2D0  ldrb     w8, [x21, #0x730]
0068CD2D4  mov      w20, w0
0068CD2D8  cbnz     w8, #0x68cd2f0
0068CD2DC  adrp     x0, #0x8f28000
0068CD2E0  ldr      x0, [x0, #0x3f0]
0068CD2E4  bl       #0x382bd14 ; 
0068CD2E8  mov      w8, #1
0068CD2EC  strb     w8, [x21, #0x730]
0068CD2F0  adrp     x8, #0x8f28000
0068CD2F4  ldr      x8, [x8, #0x3f0]
0068CD2F8  ldr      x2, [x8]
0068CD2FC  ldrb     w8, [x2, #0x53]
0068CD300  tbnz     w8, #5, #0x68cd320
0068CD304  str      w20, [x19, #0x20]
0068CD308  b        #0x68cd330 ; 
0068CD30C  ldr      x2, [x1, #0x60]
0068CD310  mov      x0, x19
0068CD314  ldp      x20, x19, [sp, #0x10]
0068CD318  ldp      x30, x21, [sp], #0x20
0068CD31C  br       x2
0068CD320  ldr      x8, [x2, #0x60]
0068CD324  mov      x0, x19
0068CD328  mov      w1, w20
0068CD32C  blr      x8
0068CD330  mov      x0, x19
0068CD334  mov      x1, xzr
0068CD338  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CD33C  adrp     x21, #0x959c000
0068CD340  ldrb     w8, [x21, #0x731]
0068CD344  mov      w20, w0
0068CD348  cbnz     w8, #0x68cd360
0068CD34C  adrp     x0, #0x8f28000
0068CD350  ldr      x0, [x0, #0x400]
0068CD354  bl       #0x382bd14 ; 
0068CD358  mov      w8, #1
0068CD35C  strb     w8, [x21, #0x731]
0068CD360  adrp     x8, #0x8f28000
0068CD364  ldr      x8, [x8, #0x400]
0068CD368  ldr      x2, [x8]
0068CD36C  ldrb     w8, [x2, #0x53]
0068CD370  tbnz     w8, #5, #0x68cd37c
0068CD374  str      w20, [x19, #0x24]
0068CD378  b        #0x68cd38c ; 
0068CD37C  ldr      x8, [x2, #0x60]
0068CD380  mov      x0, x19
0068CD384  mov      w1, w20
0068CD388  blr      x8
0068CD38C  mov      x0, x19
0068CD390  mov      x1, xzr
0068CD394  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CD398  adrp     x21, #0x959c000
0068CD39C  ldrb     w8, [x21, #0x732]
0068CD3A0  mov      x20, x0
0068CD3A4  cbnz     w8, #0x68cd3bc
0068CD3A8  adrp     x0, #0x8f28000
0068CD3AC  ldr      x0, [x0, #0x410]
0068CD3B0  bl       #0x382bd14 ; 
0068CD3B4  mov      w8, #1
0068CD3B8  strb     w8, [x21, #0x732]
0068CD3BC  adrp     x8, #0x8f28000
0068CD3C0  ldr      x8, [x8, #0x410]
0068CD3C4  ldr      x2, [x8]
0068CD3C8  ldrb     w8, [x2, #0x53]
0068CD3CC  tbnz     w8, #5, #0x68cd3e4
0068CD3D0  mov      x0, x19
0068CD3D4  str      x20, [x0, #0x28]!
0068CD3D8  mov      x1, x20
0068CD3DC  bl       #0x382bcb8 ; 
0068CD3E0  b        #0x68cd3f4 ; 
0068CD3E4  ldr      x8, [x2, #0x60]
0068CD3E8  mov      x0, x19
0068CD3EC  mov      x1, x20
0068CD3F0  blr      x8
0068CD3F4  mov      x0, x19
0068CD3F8  mov      x1, xzr
0068CD3FC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CD400  adrp     x21, #0x959c000
0068CD404  ldrb     w8, [x21, #0x733]
0068CD408  mov      x20, x0
0068CD40C  cbnz     w8, #0x68cd424
0068CD410  adrp     x0, #0x8f28000
0068CD414  ldr      x0, [x0, #0x420]
0068CD418  bl       #0x382bd14 ; 
0068CD41C  mov      w8, #1
0068CD420  strb     w8, [x21, #0x733]
0068CD424  adrp     x8, #0x8f28000
0068CD428  ldr      x8, [x8, #0x420]
0068CD42C  ldr      x2, [x8]
0068CD430  ldrb     w8, [x2, #0x53]
0068CD434  tbnz     w8, #5, #0x68cd44c
0068CD438  mov      x0, x19
0068CD43C  str      x20, [x0, #0x30]!
0068CD440  mov      x1, x20
0068CD444  bl       #0x382bcb8 ; 
0068CD448  b        #0x68cd45c ; 
0068CD44C  ldr      x8, [x2, #0x60]
0068CD450  mov      x0, x19
0068CD454  mov      x1, x20
0068CD458  blr      x8
0068CD45C  mov      x0, x19
0068CD460  mov      x1, xzr
0068CD464  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068CD468  adrp     x21, #0x959c000
0068CD46C  ldrb     w8, [x21, #0x734]
0068CD470  mov      w20, w0
0068CD474  cbnz     w8, #0x68cd48c
0068CD478  adrp     x0, #0x8f28000
0068CD47C  ldr      x0, [x0, #0x430]
0068CD480  bl       #0x382bd14 ; 
0068CD484  mov      w8, #1
0068CD488  strb     w8, [x21, #0x734]
0068CD48C  adrp     x8, #0x8f28000
0068CD490  ldr      x8, [x8, #0x430]
0068CD494  ldr      x2, [x8]
0068CD498  ldrb     w8, [x2, #0x53]
0068CD49C  tbnz     w8, #5, #0x68cd4a8
0068CD4A0  str      w20, [x19, #0x38]
0068CD4A4  b        #0x68cd4b8 ; 
0068CD4A8  ldr      x8, [x2, #0x60]
0068CD4AC  mov      x0, x19
0068CD4B0  mov      w1, w20
0068CD4B4  blr      x8
0068CD4B8  mov      x0, x19
0068CD4BC  mov      x1, xzr
0068CD4C0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CD4C4  adrp     x21, #0x959c000
0068CD4C8  ldrb     w8, [x21, #0x735]
0068CD4CC  mov      x20, x0
0068CD4D0  cbnz     w8, #0x68cd4e8
0068CD4D4  adrp     x0, #0x8f28000
0068CD4D8  ldr      x0, [x0, #0x440]
0068CD4DC  bl       #0x382bd14 ; 
0068CD4E0  mov      w8, #1
0068CD4E4  strb     w8, [x21, #0x735]
0068CD4E8  adrp     x8, #0x8f28000
0068CD4EC  ldr      x8, [x8, #0x440]
0068CD4F0  ldr      x2, [x8]
0068CD4F4  ldrb     w8, [x2, #0x53]
0068CD4F8  tbnz     w8, #5, #0x68cd510
0068CD4FC  mov      x0, x19
0068CD500  str      x20, [x0, #0x40]!
0068CD504  mov      x1, x20
0068CD508  bl       #0x382bcb8 ; 
0068CD50C  b        #0x68cd520 ; 
0068CD510  ldr      x8, [x2, #0x60]
0068CD514  mov      x0, x19
0068CD518  mov      x1, x20
0068CD51C  blr      x8
0068CD520  mov      x0, x19
0068CD524  mov      x1, xzr
0068CD528  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068CD52C  adrp     x21, #0x959c000
0068CD530  ldrb     w8, [x21, #0x736]
0068CD534  mov      x20, x0
0068CD538  cbnz     w8, #0x68cd550
0068CD53C  adrp     x0, #0x8f28000
0068CD540  ldr      x0, [x0, #0x450]
0068CD544  bl       #0x382bd14 ; 
0068CD548  mov      w8, #1
0068CD54C  strb     w8, [x21, #0x736]
0068CD550  adrp     x8, #0x8f28000
0068CD554  ldr      x8, [x8, #0x450]
0068CD558  ldr      x2, [x8]
0068CD55C  ldrb     w8, [x2, #0x53]
0068CD560  tbnz     w8, #5, #0x68cd578
0068CD564  str      x20, [x19, #0x48]!
0068CD568  mov      x0, x19
0068CD56C  mov      x1, x20
0068CD570  bl       #0x382bcb8 ; 
0068CD574  b        #0x68cd588 ; 
0068CD578  ldr      x8, [x2, #0x60]
0068CD57C  mov      x0, x19
0068CD580  mov      x1, x20
0068CD584  blr      x8
0068CD588  ldp      x20, x19, [sp, #0x10]
0068CD58C  mov      w0, #1
0068CD590  ldp      x30, x21, [sp], #0x20
0068CD594  ret      

