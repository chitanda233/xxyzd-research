; LocalModels.Bean.WorldBoss_BattleBoss$$readImpl
; RVA 0x6B22334; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B22334  stp      x30, x21, [sp, #-0x20]!
006B22338  stp      x20, x19, [sp, #0x10]
006B2233C  adrp     x20, #0x959f000
006B22340  adrp     x21, #0x8f3f000
006B22344  ldrb     w8, [x20, #0x70c]
006B22348  ldr      x21, [x21, #0x8e8]
006B2234C  mov      x19, x0
006B22350  tbnz     w8, #0, #0x6b22368
006B22354  adrp     x0, #0x8f3f000
006B22358  ldr      x0, [x0, #0x8e8]
006B2235C  bl       #0x382bd14 ; 
006B22360  mov      w8, #1
006B22364  strb     w8, [x20, #0x70c]
006B22368  ldr      x1, [x21]
006B2236C  ldrb     w8, [x1, #0x53]
006B22370  tbnz     w8, #5, #0x6b223c0
006B22374  mov      x0, x19
006B22378  mov      x1, xzr
006B2237C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B22380  adrp     x21, #0x959f000
006B22384  ldrb     w8, [x21, #0xa6c]
006B22388  mov      w20, w0
006B2238C  cbnz     w8, #0x6b223a4
006B22390  adrp     x0, #0x8f3f000
006B22394  ldr      x0, [x0, #0x8b0]
006B22398  bl       #0x382bd14 ; 
006B2239C  mov      w8, #1
006B223A0  strb     w8, [x21, #0xa6c]
006B223A4  adrp     x8, #0x8f3f000
006B223A8  ldr      x8, [x8, #0x8b0]
006B223AC  ldr      x2, [x8]
006B223B0  ldrb     w8, [x2, #0x53]
006B223B4  tbnz     w8, #5, #0x6b223d4
006B223B8  str      w20, [x19, #0x20]
006B223BC  b        #0x6b223e4 ; 
006B223C0  ldr      x2, [x1, #0x60]
006B223C4  mov      x0, x19
006B223C8  ldp      x20, x19, [sp, #0x10]
006B223CC  ldp      x30, x21, [sp], #0x20
006B223D0  br       x2
006B223D4  ldr      x8, [x2, #0x60]
006B223D8  mov      x0, x19
006B223DC  mov      w1, w20
006B223E0  blr      x8
006B223E4  mov      x0, x19
006B223E8  mov      x1, xzr
006B223EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B223F0  adrp     x21, #0x959f000
006B223F4  ldrb     w8, [x21, #0xa6d]
006B223F8  mov      w20, w0
006B223FC  cbnz     w8, #0x6b22414
006B22400  adrp     x0, #0x8f3f000
006B22404  ldr      x0, [x0, #0x8c0]
006B22408  bl       #0x382bd14 ; 
006B2240C  mov      w8, #1
006B22410  strb     w8, [x21, #0xa6d]
006B22414  adrp     x8, #0x8f3f000
006B22418  ldr      x8, [x8, #0x8c0]
006B2241C  ldr      x2, [x8]
006B22420  ldrb     w8, [x2, #0x53]
006B22424  tbnz     w8, #5, #0x6b22430
006B22428  str      w20, [x19, #0x24]
006B2242C  b        #0x6b22440 ; 
006B22430  ldr      x8, [x2, #0x60]
006B22434  mov      x0, x19
006B22438  mov      w1, w20
006B2243C  blr      x8
006B22440  mov      x0, x19
006B22444  mov      x1, xzr
006B22448  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B2244C  adrp     x21, #0x959f000
006B22450  ldrb     w8, [x21, #0xa6e]
006B22454  mov      w20, w0
006B22458  cbnz     w8, #0x6b22470
006B2245C  adrp     x0, #0x8f3f000
006B22460  ldr      x0, [x0, #0x8d0]
006B22464  bl       #0x382bd14 ; 
006B22468  mov      w8, #1
006B2246C  strb     w8, [x21, #0xa6e]
006B22470  adrp     x8, #0x8f3f000
006B22474  ldr      x8, [x8, #0x8d0]
006B22478  ldr      x2, [x8]
006B2247C  ldrb     w8, [x2, #0x53]
006B22480  tbnz     w8, #5, #0x6b2248c
006B22484  str      w20, [x19, #0x28]
006B22488  b        #0x6b2249c ; 
006B2248C  ldr      x8, [x2, #0x60]
006B22490  mov      x0, x19
006B22494  mov      w1, w20
006B22498  blr      x8
006B2249C  mov      x0, x19
006B224A0  mov      x1, xzr
006B224A4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B224A8  adrp     x21, #0x959f000
006B224AC  ldrb     w8, [x21, #0xa6f]
006B224B0  mov      x20, x0
006B224B4  cbnz     w8, #0x6b224cc
006B224B8  adrp     x0, #0x8f3f000
006B224BC  ldr      x0, [x0, #0x8e0]
006B224C0  bl       #0x382bd14 ; 
006B224C4  mov      w8, #1
006B224C8  strb     w8, [x21, #0xa6f]
006B224CC  adrp     x8, #0x8f3f000
006B224D0  ldr      x8, [x8, #0x8e0]
006B224D4  ldr      x2, [x8]
006B224D8  ldrb     w8, [x2, #0x53]
006B224DC  tbnz     w8, #5, #0x6b224f4
006B224E0  str      x20, [x19, #0x30]!
006B224E4  mov      x0, x19
006B224E8  mov      x1, x20
006B224EC  bl       #0x382bcb8 ; 
006B224F0  b        #0x6b22504 ; 
006B224F4  ldr      x8, [x2, #0x60]
006B224F8  mov      x0, x19
006B224FC  mov      x1, x20
006B22500  blr      x8
006B22504  ldp      x20, x19, [sp, #0x10]
006B22508  mov      w0, #1
006B2250C  ldp      x30, x21, [sp], #0x20
006B22510  ret      

