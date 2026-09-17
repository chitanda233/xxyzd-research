; LocalModels.Bean.Mission_RandomMonsterFlushConfig$$readImpl
; RVA 0x6AC3360; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC3360  stp      x30, x21, [sp, #-0x20]!
006AC3364  stp      x20, x19, [sp, #0x10]
006AC3368  adrp     x20, #0x959e000
006AC336C  adrp     x21, #0x8f3b000
006AC3370  ldrb     w8, [x20, #0x9b2]
006AC3374  ldr      x21, [x21, #0x428]
006AC3378  mov      x19, x0
006AC337C  tbnz     w8, #0, #0x6ac3394
006AC3380  adrp     x0, #0x8f3b000
006AC3384  ldr      x0, [x0, #0x428]
006AC3388  bl       #0x382bd14 ; 
006AC338C  mov      w8, #1
006AC3390  strb     w8, [x20, #0x9b2]
006AC3394  ldr      x1, [x21]
006AC3398  ldrb     w8, [x1, #0x53]
006AC339C  tbnz     w8, #5, #0x6ac33ec
006AC33A0  mov      x0, x19
006AC33A4  mov      x1, xzr
006AC33A8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC33AC  adrp     x21, #0x959f000
006AC33B0  ldrb     w8, [x21, #0x4d]
006AC33B4  mov      w20, w0
006AC33B8  cbnz     w8, #0x6ac33d0
006AC33BC  adrp     x0, #0x8f3b000
006AC33C0  ldr      x0, [x0, #0x408]
006AC33C4  bl       #0x382bd14 ; 
006AC33C8  mov      w8, #1
006AC33CC  strb     w8, [x21, #0x4d]
006AC33D0  adrp     x8, #0x8f3b000
006AC33D4  ldr      x8, [x8, #0x408]
006AC33D8  ldr      x2, [x8]
006AC33DC  ldrb     w8, [x2, #0x53]
006AC33E0  tbnz     w8, #5, #0x6ac3400
006AC33E4  str      w20, [x19, #0x20]
006AC33E8  b        #0x6ac3410 ; 
006AC33EC  ldr      x2, [x1, #0x60]
006AC33F0  mov      x0, x19
006AC33F4  ldp      x20, x19, [sp, #0x10]
006AC33F8  ldp      x30, x21, [sp], #0x20
006AC33FC  br       x2
006AC3400  ldr      x8, [x2, #0x60]
006AC3404  mov      x0, x19
006AC3408  mov      w1, w20
006AC340C  blr      x8
006AC3410  mov      x0, x19
006AC3414  mov      x1, xzr
006AC3418  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AC341C  adrp     x21, #0x959f000
006AC3420  ldrb     w8, [x21, #0x4e]
006AC3424  mov      x20, x0
006AC3428  cbnz     w8, #0x6ac3440
006AC342C  adrp     x0, #0x8f3b000
006AC3430  ldr      x0, [x0, #0x410]
006AC3434  bl       #0x382bd14 ; 
006AC3438  mov      w8, #1
006AC343C  strb     w8, [x21, #0x4e]
006AC3440  adrp     x8, #0x8f3b000
006AC3444  ldr      x8, [x8, #0x410]
006AC3448  ldr      x2, [x8]
006AC344C  ldrb     w8, [x2, #0x53]
006AC3450  tbnz     w8, #5, #0x6ac3468
006AC3454  mov      x0, x19
006AC3458  str      x20, [x0, #0x28]!
006AC345C  mov      x1, x20
006AC3460  bl       #0x382bcb8 ; 
006AC3464  b        #0x6ac3478 ; 
006AC3468  ldr      x8, [x2, #0x60]
006AC346C  mov      x0, x19
006AC3470  mov      x1, x20
006AC3474  blr      x8
006AC3478  mov      x0, x19
006AC347C  mov      x1, xzr
006AC3480  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC3484  adrp     x21, #0x959f000
006AC3488  ldrb     w8, [x21, #0x4f]
006AC348C  mov      x20, x0
006AC3490  cbnz     w8, #0x6ac34a8
006AC3494  adrp     x0, #0x8f3b000
006AC3498  ldr      x0, [x0, #0x418]
006AC349C  bl       #0x382bd14 ; 
006AC34A0  mov      w8, #1
006AC34A4  strb     w8, [x21, #0x4f]
006AC34A8  adrp     x8, #0x8f3b000
006AC34AC  ldr      x8, [x8, #0x418]
006AC34B0  ldr      x2, [x8]
006AC34B4  ldrb     w8, [x2, #0x53]
006AC34B8  tbnz     w8, #5, #0x6ac34c4
006AC34BC  str      x20, [x19, #0x30]
006AC34C0  b        #0x6ac34d4 ; 
006AC34C4  ldr      x8, [x2, #0x60]
006AC34C8  mov      x0, x19
006AC34CC  mov      x1, x20
006AC34D0  blr      x8
006AC34D4  mov      x0, x19
006AC34D8  mov      x1, xzr
006AC34DC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC34E0  adrp     x21, #0x959f000
006AC34E4  ldrb     w8, [x21, #0x50]
006AC34E8  mov      x20, x0
006AC34EC  cbnz     w8, #0x6ac3504
006AC34F0  adrp     x0, #0x8f3b000
006AC34F4  ldr      x0, [x0, #0x420]
006AC34F8  bl       #0x382bd14 ; 
006AC34FC  mov      w8, #1
006AC3500  strb     w8, [x21, #0x50]
006AC3504  adrp     x8, #0x8f3b000
006AC3508  ldr      x8, [x8, #0x420]
006AC350C  ldr      x2, [x8]
006AC3510  ldrb     w8, [x2, #0x53]
006AC3514  tbnz     w8, #5, #0x6ac3520
006AC3518  str      x20, [x19, #0x38]
006AC351C  b        #0x6ac3530 ; 
006AC3520  ldr      x8, [x2, #0x60]
006AC3524  mov      x0, x19
006AC3528  mov      x1, x20
006AC352C  blr      x8
006AC3530  ldp      x20, x19, [sp, #0x10]
006AC3534  mov      w0, #1
006AC3538  ldp      x30, x21, [sp], #0x20
006AC353C  ret      

