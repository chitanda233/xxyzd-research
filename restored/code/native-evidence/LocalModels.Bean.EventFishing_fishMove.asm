; LocalModels.Bean.EventFishing_fishMove$$readImpl
; RVA 0x6A7522C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A7522C  stp      x30, x21, [sp, #-0x20]!
006A75230  stp      x20, x19, [sp, #0x10]
006A75234  adrp     x20, #0x959d000
006A75238  adrp     x21, #0x8f37000
006A7523C  ldrb     w8, [x20, #0xe17]
006A75240  ldr      x21, [x21, #0x958]
006A75244  mov      x19, x0
006A75248  tbnz     w8, #0, #0x6a75260
006A7524C  adrp     x0, #0x8f37000
006A75250  ldr      x0, [x0, #0x958]
006A75254  bl       #0x382bd14 ; 
006A75258  mov      w8, #1
006A7525C  strb     w8, [x20, #0xe17]
006A75260  ldr      x1, [x21]
006A75264  ldrb     w8, [x1, #0x53]
006A75268  tbnz     w8, #5, #0x6a752b8
006A7526C  mov      x0, x19
006A75270  mov      x1, xzr
006A75274  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A75278  adrp     x21, #0x959e000
006A7527C  ldrb     w8, [x21, #0x485]
006A75280  mov      w20, w0
006A75284  cbnz     w8, #0x6a7529c
006A75288  adrp     x0, #0x8f37000
006A7528C  ldr      x0, [x0, #0x900]
006A75290  bl       #0x382bd14 ; 
006A75294  mov      w8, #1
006A75298  strb     w8, [x21, #0x485]
006A7529C  adrp     x8, #0x8f37000
006A752A0  ldr      x8, [x8, #0x900]
006A752A4  ldr      x2, [x8]
006A752A8  ldrb     w8, [x2, #0x53]
006A752AC  tbnz     w8, #5, #0x6a752cc
006A752B0  str      w20, [x19, #0x20]
006A752B4  b        #0x6a752dc ; 
006A752B8  ldr      x2, [x1, #0x60]
006A752BC  mov      x0, x19
006A752C0  ldp      x20, x19, [sp, #0x10]
006A752C4  ldp      x30, x21, [sp], #0x20
006A752C8  br       x2
006A752CC  ldr      x8, [x2, #0x60]
006A752D0  mov      x0, x19
006A752D4  mov      w1, w20
006A752D8  blr      x8
006A752DC  mov      x0, x19
006A752E0  mov      x1, xzr
006A752E4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A752E8  adrp     x21, #0x959e000
006A752EC  ldrb     w8, [x21, #0x486]
006A752F0  mov      x20, x0
006A752F4  cbnz     w8, #0x6a7530c
006A752F8  adrp     x0, #0x8f37000
006A752FC  ldr      x0, [x0, #0x910]
006A75300  bl       #0x382bd14 ; 
006A75304  mov      w8, #1
006A75308  strb     w8, [x21, #0x486]
006A7530C  adrp     x8, #0x8f37000
006A75310  ldr      x8, [x8, #0x910]
006A75314  ldr      x2, [x8]
006A75318  ldrb     w8, [x2, #0x53]
006A7531C  tbnz     w8, #5, #0x6a75334
006A75320  mov      x0, x19
006A75324  str      x20, [x0, #0x28]!
006A75328  mov      x1, x20
006A7532C  bl       #0x382bcb8 ; 
006A75330  b        #0x6a75344 ; 
006A75334  ldr      x8, [x2, #0x60]
006A75338  mov      x0, x19
006A7533C  mov      x1, x20
006A75340  blr      x8
006A75344  mov      x0, x19
006A75348  mov      x1, xzr
006A7534C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A75350  adrp     x21, #0x959e000
006A75354  ldrb     w8, [x21, #0x487]
006A75358  mov      x20, x0
006A7535C  cbnz     w8, #0x6a75374
006A75360  adrp     x0, #0x8f37000
006A75364  ldr      x0, [x0, #0x920]
006A75368  bl       #0x382bd14 ; 
006A7536C  mov      w8, #1
006A75370  strb     w8, [x21, #0x487]
006A75374  adrp     x8, #0x8f37000
006A75378  ldr      x8, [x8, #0x920]
006A7537C  ldr      x2, [x8]
006A75380  ldrb     w8, [x2, #0x53]
006A75384  tbnz     w8, #5, #0x6a7539c
006A75388  mov      x0, x19
006A7538C  str      x20, [x0, #0x30]!
006A75390  mov      x1, x20
006A75394  bl       #0x382bcb8 ; 
006A75398  b        #0x6a753ac ; 
006A7539C  ldr      x8, [x2, #0x60]
006A753A0  mov      x0, x19
006A753A4  mov      x1, x20
006A753A8  blr      x8
006A753AC  mov      x0, x19
006A753B0  mov      x1, xzr
006A753B4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A753B8  adrp     x21, #0x959e000
006A753BC  ldrb     w8, [x21, #0x488]
006A753C0  mov      x20, x0
006A753C4  cbnz     w8, #0x6a753dc
006A753C8  adrp     x0, #0x8f37000
006A753CC  ldr      x0, [x0, #0x930]
006A753D0  bl       #0x382bd14 ; 
006A753D4  mov      w8, #1
006A753D8  strb     w8, [x21, #0x488]
006A753DC  adrp     x8, #0x8f37000
006A753E0  ldr      x8, [x8, #0x930]
006A753E4  ldr      x2, [x8]
006A753E8  ldrb     w8, [x2, #0x53]
006A753EC  tbnz     w8, #5, #0x6a75404
006A753F0  mov      x0, x19
006A753F4  str      x20, [x0, #0x38]!
006A753F8  mov      x1, x20
006A753FC  bl       #0x382bcb8 ; 
006A75400  b        #0x6a75414 ; 
006A75404  ldr      x8, [x2, #0x60]
006A75408  mov      x0, x19
006A7540C  mov      x1, x20
006A75410  blr      x8
006A75414  mov      x0, x19
006A75418  mov      x1, xzr
006A7541C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A75420  adrp     x21, #0x959e000
006A75424  ldrb     w8, [x21, #0x489]
006A75428  mov      x20, x0
006A7542C  cbnz     w8, #0x6a75444
006A75430  adrp     x0, #0x8f37000
006A75434  ldr      x0, [x0, #0x940]
006A75438  bl       #0x382bd14 ; 
006A7543C  mov      w8, #1
006A75440  strb     w8, [x21, #0x489]
006A75444  adrp     x8, #0x8f37000
006A75448  ldr      x8, [x8, #0x940]
006A7544C  ldr      x2, [x8]
006A75450  ldrb     w8, [x2, #0x53]
006A75454  tbnz     w8, #5, #0x6a7546c
006A75458  mov      x0, x19
006A7545C  str      x20, [x0, #0x40]!
006A75460  mov      x1, x20
006A75464  bl       #0x382bcb8 ; 
006A75468  b        #0x6a7547c ; 
006A7546C  ldr      x8, [x2, #0x60]
006A75470  mov      x0, x19
006A75474  mov      x1, x20
006A75478  blr      x8
006A7547C  mov      x0, x19
006A75480  mov      x1, xzr
006A75484  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A75488  adrp     x21, #0x959e000
006A7548C  ldrb     w8, [x21, #0x48a]
006A75490  mov      x20, x0
006A75494  cbnz     w8, #0x6a754ac
006A75498  adrp     x0, #0x8f37000
006A7549C  ldr      x0, [x0, #0x950]
006A754A0  bl       #0x382bd14 ; 
006A754A4  mov      w8, #1
006A754A8  strb     w8, [x21, #0x48a]
006A754AC  adrp     x8, #0x8f37000
006A754B0  ldr      x8, [x8, #0x950]
006A754B4  ldr      x2, [x8]
006A754B8  ldrb     w8, [x2, #0x53]
006A754BC  tbnz     w8, #5, #0x6a754d4
006A754C0  str      x20, [x19, #0x48]!
006A754C4  mov      x0, x19
006A754C8  mov      x1, x20
006A754CC  bl       #0x382bcb8 ; 
006A754D0  b        #0x6a754e4 ; 
006A754D4  ldr      x8, [x2, #0x60]
006A754D8  mov      x0, x19
006A754DC  mov      x1, x20
006A754E0  blr      x8
006A754E4  ldp      x20, x19, [sp, #0x10]
006A754E8  mov      w0, #1
006A754EC  ldp      x30, x21, [sp], #0x20
006A754F0  ret      

