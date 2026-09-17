; LocalModels.Bean.Pilot_Star$$readImpl
; RVA 0x6AD3644; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AD3644  stp      x30, x21, [sp, #-0x20]!
006AD3648  stp      x20, x19, [sp, #0x10]
006AD364C  adrp     x20, #0x959e000
006AD3650  adrp     x21, #0x8f3c000
006AD3654  ldrb     w8, [x20, #0xb61]
006AD3658  ldr      x21, [x21, #0x40]
006AD365C  mov      x19, x0
006AD3660  tbnz     w8, #0, #0x6ad3678
006AD3664  adrp     x0, #0x8f3c000
006AD3668  ldr      x0, [x0, #0x40]
006AD366C  bl       #0x382bd14 ; 
006AD3670  mov      w8, #1
006AD3674  strb     w8, [x20, #0xb61]
006AD3678  ldr      x1, [x21]
006AD367C  ldrb     w8, [x1, #0x53]
006AD3680  tbnz     w8, #5, #0x6ad36d0
006AD3684  mov      x0, x19
006AD3688  mov      x1, xzr
006AD368C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD3690  adrp     x21, #0x959f000
006AD3694  ldrb     w8, [x21, #0x102]
006AD3698  mov      w20, w0
006AD369C  cbnz     w8, #0x6ad36b4
006AD36A0  adrp     x0, #0x8f3b000
006AD36A4  ldr      x0, [x0, #0xfd8]
006AD36A8  bl       #0x382bd14 ; 
006AD36AC  mov      w8, #1
006AD36B0  strb     w8, [x21, #0x102]
006AD36B4  adrp     x8, #0x8f3b000
006AD36B8  ldr      x8, [x8, #0xfd8]
006AD36BC  ldr      x2, [x8]
006AD36C0  ldrb     w8, [x2, #0x53]
006AD36C4  tbnz     w8, #5, #0x6ad36e4
006AD36C8  str      w20, [x19, #0x20]
006AD36CC  b        #0x6ad36f4 ; 
006AD36D0  ldr      x2, [x1, #0x60]
006AD36D4  mov      x0, x19
006AD36D8  ldp      x20, x19, [sp, #0x10]
006AD36DC  ldp      x30, x21, [sp], #0x20
006AD36E0  br       x2
006AD36E4  ldr      x8, [x2, #0x60]
006AD36E8  mov      x0, x19
006AD36EC  mov      w1, w20
006AD36F0  blr      x8
006AD36F4  mov      x0, x19
006AD36F8  mov      x1, xzr
006AD36FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD3700  adrp     x21, #0x959f000
006AD3704  ldrb     w8, [x21, #0x103]
006AD3708  mov      w20, w0
006AD370C  cbnz     w8, #0x6ad3724
006AD3710  adrp     x0, #0x8f3b000
006AD3714  ldr      x0, [x0, #0xfe8]
006AD3718  bl       #0x382bd14 ; 
006AD371C  mov      w8, #1
006AD3720  strb     w8, [x21, #0x103]
006AD3724  adrp     x8, #0x8f3b000
006AD3728  ldr      x8, [x8, #0xfe8]
006AD372C  ldr      x2, [x8]
006AD3730  ldrb     w8, [x2, #0x53]
006AD3734  tbnz     w8, #5, #0x6ad3740
006AD3738  str      w20, [x19, #0x24]
006AD373C  b        #0x6ad3750 ; 
006AD3740  ldr      x8, [x2, #0x60]
006AD3744  mov      x0, x19
006AD3748  mov      w1, w20
006AD374C  blr      x8
006AD3750  mov      x0, x19
006AD3754  mov      x1, xzr
006AD3758  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD375C  adrp     x21, #0x959f000
006AD3760  ldrb     w8, [x21, #0x104]
006AD3764  mov      w20, w0
006AD3768  cbnz     w8, #0x6ad3780
006AD376C  adrp     x0, #0x8f3b000
006AD3770  ldr      x0, [x0, #0xff8]
006AD3774  bl       #0x382bd14 ; 
006AD3778  mov      w8, #1
006AD377C  strb     w8, [x21, #0x104]
006AD3780  adrp     x8, #0x8f3b000
006AD3784  ldr      x8, [x8, #0xff8]
006AD3788  ldr      x2, [x8]
006AD378C  ldrb     w8, [x2, #0x53]
006AD3790  tbnz     w8, #5, #0x6ad379c
006AD3794  str      w20, [x19, #0x28]
006AD3798  b        #0x6ad37ac ; 
006AD379C  ldr      x8, [x2, #0x60]
006AD37A0  mov      x0, x19
006AD37A4  mov      w1, w20
006AD37A8  blr      x8
006AD37AC  mov      x0, x19
006AD37B0  mov      x1, xzr
006AD37B4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006AD37B8  adrp     x21, #0x959f000
006AD37BC  ldrb     w8, [x21, #0x105]
006AD37C0  mov      x20, x0
006AD37C4  cbnz     w8, #0x6ad37dc
006AD37C8  adrp     x0, #0x8f3c000
006AD37CC  ldr      x0, [x0, #8]
006AD37D0  bl       #0x382bd14 ; 
006AD37D4  mov      w8, #1
006AD37D8  strb     w8, [x21, #0x105]
006AD37DC  adrp     x8, #0x8f3c000
006AD37E0  ldr      x8, [x8, #8]
006AD37E4  ldr      x2, [x8]
006AD37E8  ldrb     w8, [x2, #0x53]
006AD37EC  tbnz     w8, #5, #0x6ad3804
006AD37F0  mov      x0, x19
006AD37F4  str      x20, [x0, #0x30]!
006AD37F8  mov      x1, x20
006AD37FC  bl       #0x382bcb8 ; 
006AD3800  b        #0x6ad3814 ; 
006AD3804  ldr      x8, [x2, #0x60]
006AD3808  mov      x0, x19
006AD380C  mov      x1, x20
006AD3810  blr      x8
006AD3814  mov      x0, x19
006AD3818  mov      x1, xzr
006AD381C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AD3820  adrp     x21, #0x959f000
006AD3824  ldrb     w8, [x21, #0x106]
006AD3828  mov      x20, x0
006AD382C  cbnz     w8, #0x6ad3844
006AD3830  adrp     x0, #0x8f3c000
006AD3834  ldr      x0, [x0, #0x18]
006AD3838  bl       #0x382bd14 ; 
006AD383C  mov      w8, #1
006AD3840  strb     w8, [x21, #0x106]
006AD3844  adrp     x8, #0x8f3c000
006AD3848  ldr      x8, [x8, #0x18]
006AD384C  ldr      x2, [x8]
006AD3850  ldrb     w8, [x2, #0x53]
006AD3854  tbnz     w8, #5, #0x6ad386c
006AD3858  mov      x0, x19
006AD385C  str      x20, [x0, #0x38]!
006AD3860  mov      x1, x20
006AD3864  bl       #0x382bcb8 ; 
006AD3868  b        #0x6ad387c ; 
006AD386C  ldr      x8, [x2, #0x60]
006AD3870  mov      x0, x19
006AD3874  mov      x1, x20
006AD3878  blr      x8
006AD387C  mov      x0, x19
006AD3880  mov      x1, xzr
006AD3884  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AD3888  adrp     x21, #0x959f000
006AD388C  ldrb     w8, [x21, #0x107]
006AD3890  mov      w20, w0
006AD3894  cbnz     w8, #0x6ad38ac
006AD3898  adrp     x0, #0x8f3c000
006AD389C  ldr      x0, [x0, #0x28]
006AD38A0  bl       #0x382bd14 ; 
006AD38A4  mov      w8, #1
006AD38A8  strb     w8, [x21, #0x107]
006AD38AC  adrp     x8, #0x8f3c000
006AD38B0  ldr      x8, [x8, #0x28]
006AD38B4  ldr      x2, [x8]
006AD38B8  ldrb     w8, [x2, #0x53]
006AD38BC  tbnz     w8, #5, #0x6ad38c8
006AD38C0  str      w20, [x19, #0x40]
006AD38C4  b        #0x6ad38d8 ; 
006AD38C8  ldr      x8, [x2, #0x60]
006AD38CC  mov      x0, x19
006AD38D0  mov      w1, w20
006AD38D4  blr      x8
006AD38D8  mov      x0, x19
006AD38DC  mov      x1, xzr
006AD38E0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AD38E4  adrp     x21, #0x959f000
006AD38E8  ldrb     w8, [x21, #0x108]
006AD38EC  mov      x20, x0
006AD38F0  cbnz     w8, #0x6ad3908
006AD38F4  adrp     x0, #0x8f3c000
006AD38F8  ldr      x0, [x0, #0x38]
006AD38FC  bl       #0x382bd14 ; 
006AD3900  mov      w8, #1
006AD3904  strb     w8, [x21, #0x108]
006AD3908  adrp     x8, #0x8f3c000
006AD390C  ldr      x8, [x8, #0x38]
006AD3910  ldr      x2, [x8]
006AD3914  ldrb     w8, [x2, #0x53]
006AD3918  tbnz     w8, #5, #0x6ad3930
006AD391C  str      x20, [x19, #0x48]!
006AD3920  mov      x0, x19
006AD3924  mov      x1, x20
006AD3928  bl       #0x382bcb8 ; 
006AD392C  b        #0x6ad3940 ; 
006AD3930  ldr      x8, [x2, #0x60]
006AD3934  mov      x0, x19
006AD3938  mov      x1, x20
006AD393C  blr      x8
006AD3940  ldp      x20, x19, [sp, #0x10]
006AD3944  mov      w0, #1
006AD3948  ldp      x30, x21, [sp], #0x20
006AD394C  ret      

