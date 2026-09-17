; LocalModels.Bean.Rune_Merge$$readImpl
; RVA 0x6AE37E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE37E8  stp      x30, x21, [sp, #-0x20]!
006AE37EC  stp      x20, x19, [sp, #0x10]
006AE37F0  adrp     x20, #0x959e000
006AE37F4  adrp     x21, #0x8f3c000
006AE37F8  ldrb     w8, [x20, #0xd07]
006AE37FC  ldr      x21, [x21, #0xc18]
006AE3800  mov      x19, x0
006AE3804  tbnz     w8, #0, #0x6ae381c
006AE3808  adrp     x0, #0x8f3c000
006AE380C  ldr      x0, [x0, #0xc18]
006AE3810  bl       #0x382bd14 ; 
006AE3814  mov      w8, #1
006AE3818  strb     w8, [x20, #0xd07]
006AE381C  ldr      x1, [x21]
006AE3820  ldrb     w8, [x1, #0x53]
006AE3824  tbnz     w8, #5, #0x6ae3874
006AE3828  mov      x0, x19
006AE382C  mov      x1, xzr
006AE3830  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE3834  adrp     x21, #0x959f000
006AE3838  ldrb     w8, [x21, #0x1b5]
006AE383C  mov      w20, w0
006AE3840  cbnz     w8, #0x6ae3858
006AE3844  adrp     x0, #0x8f3c000
006AE3848  ldr      x0, [x0, #0xbc0]
006AE384C  bl       #0x382bd14 ; 
006AE3850  mov      w8, #1
006AE3854  strb     w8, [x21, #0x1b5]
006AE3858  adrp     x8, #0x8f3c000
006AE385C  ldr      x8, [x8, #0xbc0]
006AE3860  ldr      x2, [x8]
006AE3864  ldrb     w8, [x2, #0x53]
006AE3868  tbnz     w8, #5, #0x6ae3888
006AE386C  str      w20, [x19, #0x20]
006AE3870  b        #0x6ae3898 ; 
006AE3874  ldr      x2, [x1, #0x60]
006AE3878  mov      x0, x19
006AE387C  ldp      x20, x19, [sp, #0x10]
006AE3880  ldp      x30, x21, [sp], #0x20
006AE3884  br       x2
006AE3888  ldr      x8, [x2, #0x60]
006AE388C  mov      x0, x19
006AE3890  mov      w1, w20
006AE3894  blr      x8
006AE3898  mov      x0, x19
006AE389C  mov      x1, xzr
006AE38A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE38A4  adrp     x21, #0x959f000
006AE38A8  ldrb     w8, [x21, #0x1b6]
006AE38AC  mov      w20, w0
006AE38B0  cbnz     w8, #0x6ae38c8
006AE38B4  adrp     x0, #0x8f3c000
006AE38B8  ldr      x0, [x0, #0xbd0]
006AE38BC  bl       #0x382bd14 ; 
006AE38C0  mov      w8, #1
006AE38C4  strb     w8, [x21, #0x1b6]
006AE38C8  adrp     x8, #0x8f3c000
006AE38CC  ldr      x8, [x8, #0xbd0]
006AE38D0  ldr      x2, [x8]
006AE38D4  ldrb     w8, [x2, #0x53]
006AE38D8  tbnz     w8, #5, #0x6ae38e4
006AE38DC  str      w20, [x19, #0x24]
006AE38E0  b        #0x6ae38f4 ; 
006AE38E4  ldr      x8, [x2, #0x60]
006AE38E8  mov      x0, x19
006AE38EC  mov      w1, w20
006AE38F0  blr      x8
006AE38F4  mov      x0, x19
006AE38F8  mov      x1, xzr
006AE38FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE3900  adrp     x21, #0x959f000
006AE3904  ldrb     w8, [x21, #0x1b7]
006AE3908  mov      w20, w0
006AE390C  cbnz     w8, #0x6ae3924
006AE3910  adrp     x0, #0x8f3c000
006AE3914  ldr      x0, [x0, #0xbe0]
006AE3918  bl       #0x382bd14 ; 
006AE391C  mov      w8, #1
006AE3920  strb     w8, [x21, #0x1b7]
006AE3924  adrp     x8, #0x8f3c000
006AE3928  ldr      x8, [x8, #0xbe0]
006AE392C  ldr      x2, [x8]
006AE3930  ldrb     w8, [x2, #0x53]
006AE3934  tbnz     w8, #5, #0x6ae3940
006AE3938  str      w20, [x19, #0x28]
006AE393C  b        #0x6ae3950 ; 
006AE3940  ldr      x8, [x2, #0x60]
006AE3944  mov      x0, x19
006AE3948  mov      w1, w20
006AE394C  blr      x8
006AE3950  mov      x0, x19
006AE3954  mov      x1, xzr
006AE3958  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE395C  adrp     x21, #0x959f000
006AE3960  ldrb     w8, [x21, #0x1b8]
006AE3964  mov      w20, w0
006AE3968  cbnz     w8, #0x6ae3980
006AE396C  adrp     x0, #0x8f3c000
006AE3970  ldr      x0, [x0, #0xbf0]
006AE3974  bl       #0x382bd14 ; 
006AE3978  mov      w8, #1
006AE397C  strb     w8, [x21, #0x1b8]
006AE3980  adrp     x8, #0x8f3c000
006AE3984  ldr      x8, [x8, #0xbf0]
006AE3988  ldr      x2, [x8]
006AE398C  ldrb     w8, [x2, #0x53]
006AE3990  tbnz     w8, #5, #0x6ae399c
006AE3994  str      w20, [x19, #0x2c]
006AE3998  b        #0x6ae39ac ; 
006AE399C  ldr      x8, [x2, #0x60]
006AE39A0  mov      x0, x19
006AE39A4  mov      w1, w20
006AE39A8  blr      x8
006AE39AC  mov      x0, x19
006AE39B0  mov      x1, xzr
006AE39B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE39B8  adrp     x21, #0x959f000
006AE39BC  ldrb     w8, [x21, #0x1b9]
006AE39C0  mov      w20, w0
006AE39C4  cbnz     w8, #0x6ae39dc
006AE39C8  adrp     x0, #0x8f3c000
006AE39CC  ldr      x0, [x0, #0xc00]
006AE39D0  bl       #0x382bd14 ; 
006AE39D4  mov      w8, #1
006AE39D8  strb     w8, [x21, #0x1b9]
006AE39DC  adrp     x8, #0x8f3c000
006AE39E0  ldr      x8, [x8, #0xc00]
006AE39E4  ldr      x2, [x8]
006AE39E8  ldrb     w8, [x2, #0x53]
006AE39EC  tbnz     w8, #5, #0x6ae39f8
006AE39F0  str      w20, [x19, #0x30]
006AE39F4  b        #0x6ae3a08 ; 
006AE39F8  ldr      x8, [x2, #0x60]
006AE39FC  mov      x0, x19
006AE3A00  mov      w1, w20
006AE3A04  blr      x8
006AE3A08  mov      x0, x19
006AE3A0C  mov      x1, xzr
006AE3A10  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AE3A14  adrp     x21, #0x959f000
006AE3A18  ldrb     w8, [x21, #0x1ba]
006AE3A1C  mov      x20, x0
006AE3A20  cbnz     w8, #0x6ae3a38
006AE3A24  adrp     x0, #0x8f3c000
006AE3A28  ldr      x0, [x0, #0xc10]
006AE3A2C  bl       #0x382bd14 ; 
006AE3A30  mov      w8, #1
006AE3A34  strb     w8, [x21, #0x1ba]
006AE3A38  adrp     x8, #0x8f3c000
006AE3A3C  ldr      x8, [x8, #0xc10]
006AE3A40  ldr      x2, [x8]
006AE3A44  ldrb     w8, [x2, #0x53]
006AE3A48  tbnz     w8, #5, #0x6ae3a60
006AE3A4C  str      x20, [x19, #0x38]!
006AE3A50  mov      x0, x19
006AE3A54  mov      x1, x20
006AE3A58  bl       #0x382bcb8 ; 
006AE3A5C  b        #0x6ae3a70 ; 
006AE3A60  ldr      x8, [x2, #0x60]
006AE3A64  mov      x0, x19
006AE3A68  mov      x1, x20
006AE3A6C  blr      x8
006AE3A70  ldp      x20, x19, [sp, #0x10]
006AE3A74  mov      w0, #1
006AE3A78  ldp      x30, x21, [sp], #0x20
006AE3A7C  ret      

