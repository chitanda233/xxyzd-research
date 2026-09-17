; LocalModels.Bean.Levels_table$$readImpl
; RVA 0x6AB3478; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AB3478  stp      x30, x21, [sp, #-0x20]!
006AB347C  stp      x20, x19, [sp, #0x10]
006AB3480  adrp     x20, #0x959e000
006AB3484  adrp     x21, #0x8f3a000
006AB3488  ldrb     w8, [x20, #0x811]
006AB348C  ldr      x21, [x21, #0x880]
006AB3490  mov      x19, x0
006AB3494  tbnz     w8, #0, #0x6ab34ac
006AB3498  adrp     x0, #0x8f3a000
006AB349C  ldr      x0, [x0, #0x880]
006AB34A0  bl       #0x382bd14 ; 
006AB34A4  mov      w8, #1
006AB34A8  strb     w8, [x20, #0x811]
006AB34AC  ldr      x1, [x21]
006AB34B0  ldrb     w8, [x1, #0x53]
006AB34B4  tbnz     w8, #5, #0x6ab3504
006AB34B8  mov      x0, x19
006AB34BC  mov      x1, xzr
006AB34C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB34C4  adrp     x21, #0x959e000
006AB34C8  ldrb     w8, [x21, #0xf92]
006AB34CC  mov      w20, w0
006AB34D0  cbnz     w8, #0x6ab34e8
006AB34D4  adrp     x0, #0x8f3a000
006AB34D8  ldr      x0, [x0, #0x838]
006AB34DC  bl       #0x382bd14 ; 
006AB34E0  mov      w8, #1
006AB34E4  strb     w8, [x21, #0xf92]
006AB34E8  adrp     x8, #0x8f3a000
006AB34EC  ldr      x8, [x8, #0x838]
006AB34F0  ldr      x2, [x8]
006AB34F4  ldrb     w8, [x2, #0x53]
006AB34F8  tbnz     w8, #5, #0x6ab3518
006AB34FC  str      w20, [x19, #0x20]
006AB3500  b        #0x6ab3528 ; 
006AB3504  ldr      x2, [x1, #0x60]
006AB3508  mov      x0, x19
006AB350C  ldp      x20, x19, [sp, #0x10]
006AB3510  ldp      x30, x21, [sp], #0x20
006AB3514  br       x2
006AB3518  ldr      x8, [x2, #0x60]
006AB351C  mov      x0, x19
006AB3520  mov      w1, w20
006AB3524  blr      x8
006AB3528  mov      x0, x19
006AB352C  mov      x1, xzr
006AB3530  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB3534  adrp     x21, #0x959e000
006AB3538  ldrb     w8, [x21, #0xf93]
006AB353C  mov      x20, x0
006AB3540  cbnz     w8, #0x6ab3558
006AB3544  adrp     x0, #0x8f3a000
006AB3548  ldr      x0, [x0, #0x848]
006AB354C  bl       #0x382bd14 ; 
006AB3550  mov      w8, #1
006AB3554  strb     w8, [x21, #0xf93]
006AB3558  adrp     x8, #0x8f3a000
006AB355C  ldr      x8, [x8, #0x848]
006AB3560  ldr      x2, [x8]
006AB3564  ldrb     w8, [x2, #0x53]
006AB3568  tbnz     w8, #5, #0x6ab3580
006AB356C  mov      x0, x19
006AB3570  str      x20, [x0, #0x28]!
006AB3574  mov      x1, x20
006AB3578  bl       #0x382bcb8 ; 
006AB357C  b        #0x6ab3590 ; 
006AB3580  ldr      x8, [x2, #0x60]
006AB3584  mov      x0, x19
006AB3588  mov      x1, x20
006AB358C  blr      x8
006AB3590  mov      x0, x19
006AB3594  mov      x1, xzr
006AB3598  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB359C  adrp     x21, #0x959e000
006AB35A0  ldrb     w8, [x21, #0xf94]
006AB35A4  mov      x20, x0
006AB35A8  cbnz     w8, #0x6ab35c0
006AB35AC  adrp     x0, #0x8f3a000
006AB35B0  ldr      x0, [x0, #0x858]
006AB35B4  bl       #0x382bd14 ; 
006AB35B8  mov      w8, #1
006AB35BC  strb     w8, [x21, #0xf94]
006AB35C0  adrp     x8, #0x8f3a000
006AB35C4  ldr      x8, [x8, #0x858]
006AB35C8  ldr      x2, [x8]
006AB35CC  ldrb     w8, [x2, #0x53]
006AB35D0  tbnz     w8, #5, #0x6ab35e8
006AB35D4  mov      x0, x19
006AB35D8  str      x20, [x0, #0x30]!
006AB35DC  mov      x1, x20
006AB35E0  bl       #0x382bcb8 ; 
006AB35E4  b        #0x6ab35f8 ; 
006AB35E8  ldr      x8, [x2, #0x60]
006AB35EC  mov      x0, x19
006AB35F0  mov      x1, x20
006AB35F4  blr      x8
006AB35F8  mov      x0, x19
006AB35FC  mov      x1, xzr
006AB3600  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB3604  adrp     x21, #0x959e000
006AB3608  ldrb     w8, [x21, #0xf95]
006AB360C  mov      w20, w0
006AB3610  cbnz     w8, #0x6ab3628
006AB3614  adrp     x0, #0x8f3a000
006AB3618  ldr      x0, [x0, #0x868]
006AB361C  bl       #0x382bd14 ; 
006AB3620  mov      w8, #1
006AB3624  strb     w8, [x21, #0xf95]
006AB3628  adrp     x8, #0x8f3a000
006AB362C  ldr      x8, [x8, #0x868]
006AB3630  ldr      x2, [x8]
006AB3634  ldrb     w8, [x2, #0x53]
006AB3638  tbnz     w8, #5, #0x6ab3644
006AB363C  str      w20, [x19, #0x38]
006AB3640  b        #0x6ab3654 ; 
006AB3644  ldr      x8, [x2, #0x60]
006AB3648  mov      x0, x19
006AB364C  mov      w1, w20
006AB3650  blr      x8
006AB3654  mov      x0, x19
006AB3658  mov      x1, xzr
006AB365C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AB3660  adrp     x21, #0x959e000
006AB3664  ldrb     w8, [x21, #0xf96]
006AB3668  mov      w20, w0
006AB366C  cbnz     w8, #0x6ab3684
006AB3670  adrp     x0, #0x8f3a000
006AB3674  ldr      x0, [x0, #0x878]
006AB3678  bl       #0x382bd14 ; 
006AB367C  mov      w8, #1
006AB3680  strb     w8, [x21, #0xf96]
006AB3684  adrp     x8, #0x8f3a000
006AB3688  ldr      x8, [x8, #0x878]
006AB368C  ldr      x2, [x8]
006AB3690  ldrb     w8, [x2, #0x53]
006AB3694  tbnz     w8, #5, #0x6ab36a0
006AB3698  str      w20, [x19, #0x3c]
006AB369C  b        #0x6ab36b0 ; 
006AB36A0  ldr      x8, [x2, #0x60]
006AB36A4  mov      x0, x19
006AB36A8  mov      w1, w20
006AB36AC  blr      x8
006AB36B0  ldp      x20, x19, [sp, #0x10]
006AB36B4  mov      w0, #1
006AB36B8  ldp      x30, x21, [sp], #0x20
006AB36BC  ret      

