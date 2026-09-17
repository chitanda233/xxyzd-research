; LocalModels.Bean.Chapter_BattleTerm$$readImpl
; RVA 0x68A321C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068A321C  stp      x30, x21, [sp, #-0x20]!
0068A3220  stp      x20, x19, [sp, #0x10]
0068A3224  adrp     x20, #0x959b000
0068A3228  adrp     x21, #0x8f26000
0068A322C  ldrb     w8, [x20, #0xf14]
0068A3230  ldr      x21, [x21, #0x550]
0068A3234  mov      x19, x0
0068A3238  tbnz     w8, #0, #0x68a3250
0068A323C  adrp     x0, #0x8f26000
0068A3240  ldr      x0, [x0, #0x550]
0068A3244  bl       #0x382bd14 ; 
0068A3248  mov      w8, #1
0068A324C  strb     w8, [x20, #0xf14]
0068A3250  ldr      x1, [x21]
0068A3254  ldrb     w8, [x1, #0x53]
0068A3258  tbnz     w8, #5, #0x68a32a8
0068A325C  mov      x0, x19
0068A3260  mov      x1, xzr
0068A3264  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A3268  adrp     x21, #0x959c000
0068A326C  ldrb     w8, [x21, #0x534]
0068A3270  mov      w20, w0
0068A3274  cbnz     w8, #0x68a328c
0068A3278  adrp     x0, #0x8f26000
0068A327C  ldr      x0, [x0, #0x4f8]
0068A3280  bl       #0x382bd14 ; 
0068A3284  mov      w8, #1
0068A3288  strb     w8, [x21, #0x534]
0068A328C  adrp     x8, #0x8f26000
0068A3290  ldr      x8, [x8, #0x4f8]
0068A3294  ldr      x2, [x8]
0068A3298  ldrb     w8, [x2, #0x53]
0068A329C  tbnz     w8, #5, #0x68a32bc
0068A32A0  str      w20, [x19, #0x20]
0068A32A4  b        #0x68a32cc ; 
0068A32A8  ldr      x2, [x1, #0x60]
0068A32AC  mov      x0, x19
0068A32B0  ldp      x20, x19, [sp, #0x10]
0068A32B4  ldp      x30, x21, [sp], #0x20
0068A32B8  br       x2
0068A32BC  ldr      x8, [x2, #0x60]
0068A32C0  mov      x0, x19
0068A32C4  mov      w1, w20
0068A32C8  blr      x8
0068A32CC  mov      x0, x19
0068A32D0  mov      x1, xzr
0068A32D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A32D8  adrp     x21, #0x959c000
0068A32DC  ldrb     w8, [x21, #0x535]
0068A32E0  mov      w20, w0
0068A32E4  cbnz     w8, #0x68a32fc
0068A32E8  adrp     x0, #0x8f26000
0068A32EC  ldr      x0, [x0, #0x500]
0068A32F0  bl       #0x382bd14 ; 
0068A32F4  mov      w8, #1
0068A32F8  strb     w8, [x21, #0x535]
0068A32FC  adrp     x8, #0x8f26000
0068A3300  ldr      x8, [x8, #0x500]
0068A3304  ldr      x2, [x8]
0068A3308  ldrb     w8, [x2, #0x53]
0068A330C  tbnz     w8, #5, #0x68a3318
0068A3310  str      w20, [x19, #0x24]
0068A3314  b        #0x68a3328 ; 
0068A3318  ldr      x8, [x2, #0x60]
0068A331C  mov      x0, x19
0068A3320  mov      w1, w20
0068A3324  blr      x8
0068A3328  mov      x0, x19
0068A332C  mov      x1, xzr
0068A3330  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068A3334  adrp     x21, #0x959c000
0068A3338  ldrb     w8, [x21, #0x536]
0068A333C  mov      x20, x0
0068A3340  cbnz     w8, #0x68a3358
0068A3344  adrp     x0, #0x8f26000
0068A3348  ldr      x0, [x0, #0x508]
0068A334C  bl       #0x382bd14 ; 
0068A3350  mov      w8, #1
0068A3354  strb     w8, [x21, #0x536]
0068A3358  adrp     x8, #0x8f26000
0068A335C  ldr      x8, [x8, #0x508]
0068A3360  ldr      x2, [x8]
0068A3364  ldrb     w8, [x2, #0x53]
0068A3368  tbnz     w8, #5, #0x68a3380
0068A336C  mov      x0, x19
0068A3370  str      x20, [x0, #0x28]!
0068A3374  mov      x1, x20
0068A3378  bl       #0x382bcb8 ; 
0068A337C  b        #0x68a3390 ; 
0068A3380  ldr      x8, [x2, #0x60]
0068A3384  mov      x0, x19
0068A3388  mov      x1, x20
0068A338C  blr      x8
0068A3390  mov      x0, x19
0068A3394  mov      x1, xzr
0068A3398  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A339C  adrp     x21, #0x959c000
0068A33A0  ldrb     w8, [x21, #0x537]
0068A33A4  mov      w20, w0
0068A33A8  cbnz     w8, #0x68a33c0
0068A33AC  adrp     x0, #0x8f26000
0068A33B0  ldr      x0, [x0, #0x518]
0068A33B4  bl       #0x382bd14 ; 
0068A33B8  mov      w8, #1
0068A33BC  strb     w8, [x21, #0x537]
0068A33C0  adrp     x8, #0x8f26000
0068A33C4  ldr      x8, [x8, #0x518]
0068A33C8  ldr      x2, [x8]
0068A33CC  ldrb     w8, [x2, #0x53]
0068A33D0  tbnz     w8, #5, #0x68a33dc
0068A33D4  str      w20, [x19, #0x30]
0068A33D8  b        #0x68a33ec ; 
0068A33DC  ldr      x8, [x2, #0x60]
0068A33E0  mov      x0, x19
0068A33E4  mov      w1, w20
0068A33E8  blr      x8
0068A33EC  mov      x0, x19
0068A33F0  mov      x1, xzr
0068A33F4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A33F8  adrp     x21, #0x959c000
0068A33FC  ldrb     w8, [x21, #0x538]
0068A3400  mov      w20, w0
0068A3404  cbnz     w8, #0x68a341c
0068A3408  adrp     x0, #0x8f26000
0068A340C  ldr      x0, [x0, #0x528]
0068A3410  bl       #0x382bd14 ; 
0068A3414  mov      w8, #1
0068A3418  strb     w8, [x21, #0x538]
0068A341C  adrp     x8, #0x8f26000
0068A3420  ldr      x8, [x8, #0x528]
0068A3424  ldr      x2, [x8]
0068A3428  ldrb     w8, [x2, #0x53]
0068A342C  tbnz     w8, #5, #0x68a3438
0068A3430  str      w20, [x19, #0x34]
0068A3434  b        #0x68a3448 ; 
0068A3438  ldr      x8, [x2, #0x60]
0068A343C  mov      x0, x19
0068A3440  mov      w1, w20
0068A3444  blr      x8
0068A3448  mov      x0, x19
0068A344C  mov      x1, xzr
0068A3450  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068A3454  adrp     x21, #0x959c000
0068A3458  ldrb     w8, [x21, #0x539]
0068A345C  mov      w20, w0
0068A3460  cbnz     w8, #0x68a3478
0068A3464  adrp     x0, #0x8f26000
0068A3468  ldr      x0, [x0, #0x538]
0068A346C  bl       #0x382bd14 ; 
0068A3470  mov      w8, #1
0068A3474  strb     w8, [x21, #0x539]
0068A3478  adrp     x8, #0x8f26000
0068A347C  ldr      x8, [x8, #0x538]
0068A3480  ldr      x2, [x8]
0068A3484  ldrb     w8, [x2, #0x53]
0068A3488  tbnz     w8, #5, #0x68a3494
0068A348C  str      w20, [x19, #0x38]
0068A3490  b        #0x68a34a4 ; 
0068A3494  ldr      x8, [x2, #0x60]
0068A3498  mov      x0, x19
0068A349C  mov      w1, w20
0068A34A0  blr      x8
0068A34A4  mov      x0, x19
0068A34A8  mov      x1, xzr
0068A34AC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068A34B0  adrp     x21, #0x959c000
0068A34B4  ldrb     w8, [x21, #0x53a]
0068A34B8  mov      x20, x0
0068A34BC  cbnz     w8, #0x68a34d4
0068A34C0  adrp     x0, #0x8f26000
0068A34C4  ldr      x0, [x0, #0x548]
0068A34C8  bl       #0x382bd14 ; 
0068A34CC  mov      w8, #1
0068A34D0  strb     w8, [x21, #0x53a]
0068A34D4  adrp     x8, #0x8f26000
0068A34D8  ldr      x8, [x8, #0x548]
0068A34DC  ldr      x2, [x8]
0068A34E0  ldrb     w8, [x2, #0x53]
0068A34E4  tbnz     w8, #5, #0x68a34fc
0068A34E8  str      x20, [x19, #0x40]!
0068A34EC  mov      x0, x19
0068A34F0  mov      x1, x20
0068A34F4  bl       #0x382bcb8 ; 
0068A34F8  b        #0x68a350c ; 
0068A34FC  ldr      x8, [x2, #0x60]
0068A3500  mov      x0, x19
0068A3504  mov      x1, x20
0068A3508  blr      x8
0068A350C  ldp      x20, x19, [sp, #0x10]
0068A3510  mov      w0, #1
0068A3514  ldp      x30, x21, [sp], #0x20
0068A3518  ret      

