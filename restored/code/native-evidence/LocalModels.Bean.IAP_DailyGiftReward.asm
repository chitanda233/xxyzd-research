; LocalModels.Bean.IAP_DailyGiftReward$$readImpl
; RVA 0x6AA3670; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA3670  stp      x30, x21, [sp, #-0x20]!
006AA3674  stp      x20, x19, [sp, #0x10]
006AA3678  adrp     x20, #0x959e000
006AA367C  adrp     x21, #0x8f39000
006AA3680  ldrb     w8, [x20, #0x2e3]
006AA3684  ldr      x21, [x21, #0xc88]
006AA3688  mov      x19, x0
006AA368C  tbnz     w8, #0, #0x6aa36a4
006AA3690  adrp     x0, #0x8f39000
006AA3694  ldr      x0, [x0, #0xc88]
006AA3698  bl       #0x382bd14 ; 
006AA369C  mov      w8, #1
006AA36A0  strb     w8, [x20, #0x2e3]
006AA36A4  ldr      x1, [x21]
006AA36A8  ldrb     w8, [x1, #0x53]
006AA36AC  tbnz     w8, #5, #0x6aa36fc
006AA36B0  mov      x0, x19
006AA36B4  mov      x1, xzr
006AA36B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA36BC  adrp     x21, #0x959e000
006AA36C0  ldrb     w8, [x21, #0x684]
006AA36C4  mov      w20, w0
006AA36C8  cbnz     w8, #0x6aa36e0
006AA36CC  adrp     x0, #0x8f39000
006AA36D0  ldr      x0, [x0, #0xc50]
006AA36D4  bl       #0x382bd14 ; 
006AA36D8  mov      w8, #1
006AA36DC  strb     w8, [x21, #0x684]
006AA36E0  adrp     x8, #0x8f39000
006AA36E4  ldr      x8, [x8, #0xc50]
006AA36E8  ldr      x2, [x8]
006AA36EC  ldrb     w8, [x2, #0x53]
006AA36F0  tbnz     w8, #5, #0x6aa3710
006AA36F4  str      w20, [x19, #0x20]
006AA36F8  b        #0x6aa3720 ; 
006AA36FC  ldr      x2, [x1, #0x60]
006AA3700  mov      x0, x19
006AA3704  ldp      x20, x19, [sp, #0x10]
006AA3708  ldp      x30, x21, [sp], #0x20
006AA370C  br       x2
006AA3710  ldr      x8, [x2, #0x60]
006AA3714  mov      x0, x19
006AA3718  mov      w1, w20
006AA371C  blr      x8
006AA3720  mov      x0, x19
006AA3724  mov      x1, xzr
006AA3728  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA372C  adrp     x21, #0x959e000
006AA3730  ldrb     w8, [x21, #0x685]
006AA3734  mov      w20, w0
006AA3738  cbnz     w8, #0x6aa3750
006AA373C  adrp     x0, #0x8f39000
006AA3740  ldr      x0, [x0, #0xc60]
006AA3744  bl       #0x382bd14 ; 
006AA3748  mov      w8, #1
006AA374C  strb     w8, [x21, #0x685]
006AA3750  adrp     x8, #0x8f39000
006AA3754  ldr      x8, [x8, #0xc60]
006AA3758  ldr      x2, [x8]
006AA375C  ldrb     w8, [x2, #0x53]
006AA3760  tbnz     w8, #5, #0x6aa376c
006AA3764  str      w20, [x19, #0x24]
006AA3768  b        #0x6aa377c ; 
006AA376C  ldr      x8, [x2, #0x60]
006AA3770  mov      x0, x19
006AA3774  mov      w1, w20
006AA3778  blr      x8
006AA377C  mov      x0, x19
006AA3780  mov      x1, xzr
006AA3784  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA3788  adrp     x21, #0x959e000
006AA378C  ldrb     w8, [x21, #0x686]
006AA3790  mov      w20, w0
006AA3794  cbnz     w8, #0x6aa37ac
006AA3798  adrp     x0, #0x8f39000
006AA379C  ldr      x0, [x0, #0xc70]
006AA37A0  bl       #0x382bd14 ; 
006AA37A4  mov      w8, #1
006AA37A8  strb     w8, [x21, #0x686]
006AA37AC  adrp     x8, #0x8f39000
006AA37B0  ldr      x8, [x8, #0xc70]
006AA37B4  ldr      x2, [x8]
006AA37B8  ldrb     w8, [x2, #0x53]
006AA37BC  tbnz     w8, #5, #0x6aa37c8
006AA37C0  str      w20, [x19, #0x28]
006AA37C4  b        #0x6aa37d8 ; 
006AA37C8  ldr      x8, [x2, #0x60]
006AA37CC  mov      x0, x19
006AA37D0  mov      w1, w20
006AA37D4  blr      x8
006AA37D8  mov      x0, x19
006AA37DC  mov      x1, xzr
006AA37E0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AA37E4  adrp     x21, #0x959e000
006AA37E8  ldrb     w8, [x21, #0x687]
006AA37EC  mov      x20, x0
006AA37F0  cbnz     w8, #0x6aa3808
006AA37F4  adrp     x0, #0x8f39000
006AA37F8  ldr      x0, [x0, #0xc80]
006AA37FC  bl       #0x382bd14 ; 
006AA3800  mov      w8, #1
006AA3804  strb     w8, [x21, #0x687]
006AA3808  adrp     x8, #0x8f39000
006AA380C  ldr      x8, [x8, #0xc80]
006AA3810  ldr      x2, [x8]
006AA3814  ldrb     w8, [x2, #0x53]
006AA3818  tbnz     w8, #5, #0x6aa3830
006AA381C  str      x20, [x19, #0x30]!
006AA3820  mov      x0, x19
006AA3824  mov      x1, x20
006AA3828  bl       #0x382bcb8 ; 
006AA382C  b        #0x6aa3840 ; 
006AA3830  ldr      x8, [x2, #0x60]
006AA3834  mov      x0, x19
006AA3838  mov      x1, x20
006AA383C  blr      x8
006AA3840  ldp      x20, x19, [sp, #0x10]
006AA3844  mov      w0, #1
006AA3848  ldp      x30, x21, [sp], #0x20
006AA384C  ret      

