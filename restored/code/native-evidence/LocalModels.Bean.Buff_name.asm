; LocalModels.Bean.Buff_name$$readImpl
; RVA 0x6888384; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006888384  stp      x30, x21, [sp, #-0x20]!
006888388  stp      x20, x19, [sp, #0x10]
00688838C  adrp     x20, #0x959b000
006888390  adrp     x21, #0x8f25000
006888394  ldrb     w8, [x20, #0xc4c]
006888398  ldr      x21, [x21, #0x130]
00688839C  mov      x19, x0
0068883A0  tbnz     w8, #0, #0x68883b8
0068883A4  adrp     x0, #0x8f25000
0068883A8  ldr      x0, [x0, #0x130]
0068883AC  bl       #0x382bd14 ; 
0068883B0  mov      w8, #1
0068883B4  strb     w8, [x20, #0xc4c]
0068883B8  ldr      x1, [x21]
0068883BC  ldrb     w8, [x1, #0x53]
0068883C0  tbnz     w8, #5, #0x6888410
0068883C4  mov      x0, x19
0068883C8  mov      x1, xzr
0068883CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068883D0  adrp     x21, #0x959c000
0068883D4  ldrb     w8, [x21, #0x403]
0068883D8  mov      w20, w0
0068883DC  cbnz     w8, #0x68883f4
0068883E0  adrp     x0, #0x8f25000
0068883E4  ldr      x0, [x0, #0x110]
0068883E8  bl       #0x382bd14 ; 
0068883EC  mov      w8, #1
0068883F0  strb     w8, [x21, #0x403]
0068883F4  adrp     x8, #0x8f25000
0068883F8  ldr      x8, [x8, #0x110]
0068883FC  ldr      x2, [x8]
006888400  ldrb     w8, [x2, #0x53]
006888404  tbnz     w8, #5, #0x6888424
006888408  str      w20, [x19, #0x20]
00688840C  b        #0x6888434 ; 
006888410  ldr      x2, [x1, #0x60]
006888414  mov      x0, x19
006888418  ldp      x20, x19, [sp, #0x10]
00688841C  ldp      x30, x21, [sp], #0x20
006888420  br       x2
006888424  ldr      x8, [x2, #0x60]
006888428  mov      x0, x19
00688842C  mov      w1, w20
006888430  blr      x8
006888434  mov      x0, x19
006888438  mov      x1, xzr
00688843C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006888440  adrp     x21, #0x959c000
006888444  ldrb     w8, [x21, #0x404]
006888448  mov      x20, x0
00688844C  cbnz     w8, #0x6888464
006888450  adrp     x0, #0x8f25000
006888454  ldr      x0, [x0, #0x120]
006888458  bl       #0x382bd14 ; 
00688845C  mov      w8, #1
006888460  strb     w8, [x21, #0x404]
006888464  adrp     x8, #0x8f25000
006888468  ldr      x8, [x8, #0x120]
00688846C  ldr      x2, [x8]
006888470  ldrb     w8, [x2, #0x53]
006888474  tbnz     w8, #5, #0x688848c
006888478  mov      x0, x19
00688847C  str      x20, [x0, #0x28]!
006888480  mov      x1, x20
006888484  bl       #0x382bcb8 ; 
006888488  b        #0x688849c ; 
00688848C  ldr      x8, [x2, #0x60]
006888490  mov      x0, x19
006888494  mov      x1, x20
006888498  blr      x8
00688849C  mov      x0, x19
0068884A0  mov      x1, xzr
0068884A4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068884A8  adrp     x21, #0x959c000
0068884AC  ldrb     w8, [x21, #0x405]
0068884B0  mov      x20, x0
0068884B4  cbnz     w8, #0x68884cc
0068884B8  adrp     x0, #0x8f25000
0068884BC  ldr      x0, [x0, #0x128]
0068884C0  bl       #0x382bd14 ; 
0068884C4  mov      w8, #1
0068884C8  strb     w8, [x21, #0x405]
0068884CC  adrp     x8, #0x8f25000
0068884D0  ldr      x8, [x8, #0x128]
0068884D4  ldr      x2, [x8]
0068884D8  ldrb     w8, [x2, #0x53]
0068884DC  tbnz     w8, #5, #0x68884f4
0068884E0  str      x20, [x19, #0x30]!
0068884E4  mov      x0, x19
0068884E8  mov      x1, x20
0068884EC  bl       #0x382bcb8 ; 
0068884F0  b        #0x6888504 ; 
0068884F4  ldr      x8, [x2, #0x60]
0068884F8  mov      x0, x19
0068884FC  mov      x1, x20
006888500  blr      x8
006888504  ldp      x20, x19, [sp, #0x10]
006888508  mov      w0, #1
00688850C  ldp      x30, x21, [sp], #0x20
006888510  ret      

