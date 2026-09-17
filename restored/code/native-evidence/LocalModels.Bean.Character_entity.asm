; LocalModels.Bean.Character_entity$$readImpl
; RVA 0x68C3718; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068C3718  str      d8, [sp, #-0x30]!
0068C371C  stp      x30, x21, [sp, #0x10]
0068C3720  stp      x20, x19, [sp, #0x20]
0068C3724  adrp     x20, #0x959c000
0068C3728  adrp     x21, #0x8f27000
0068C372C  ldrb     w8, [x20, #0x28a]
0068C3730  ldr      x21, [x21, #0xe90]
0068C3734  mov      x19, x0
0068C3738  tbnz     w8, #0, #0x68c3750
0068C373C  adrp     x0, #0x8f27000
0068C3740  ldr      x0, [x0, #0xe90]
0068C3744  bl       #0x382bd14 ; 
0068C3748  mov      w8, #1
0068C374C  strb     w8, [x20, #0x28a]
0068C3750  ldr      x1, [x21]
0068C3754  ldrb     w8, [x1, #0x53]
0068C3758  tbnz     w8, #5, #0x68c37a8
0068C375C  mov      x0, x19
0068C3760  mov      x1, xzr
0068C3764  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C3768  adrp     x21, #0x959c000
0068C376C  ldrb     w8, [x21, #0x68c]
0068C3770  mov      w20, w0
0068C3774  cbnz     w8, #0x68c378c
0068C3778  adrp     x0, #0x8f27000
0068C377C  ldr      x0, [x0, #0xa30]
0068C3780  bl       #0x382bd14 ; 
0068C3784  mov      w8, #1
0068C3788  strb     w8, [x21, #0x68c]
0068C378C  adrp     x8, #0x8f27000
0068C3790  ldr      x8, [x8, #0xa30]
0068C3794  ldr      x2, [x8]
0068C3798  ldrb     w8, [x2, #0x53]
0068C379C  tbnz     w8, #5, #0x68c37c0
0068C37A0  str      w20, [x19, #0x20]
0068C37A4  b        #0x68c37d0 ; 
0068C37A8  ldr      x2, [x1, #0x60]
0068C37AC  mov      x0, x19
0068C37B0  ldp      x20, x19, [sp, #0x20]
0068C37B4  ldp      x30, x21, [sp, #0x10]
0068C37B8  ldr      d8, [sp], #0x30
0068C37BC  br       x2
0068C37C0  ldr      x8, [x2, #0x60]
0068C37C4  mov      x0, x19
0068C37C8  mov      w1, w20
0068C37CC  blr      x8
0068C37D0  mov      x0, x19
0068C37D4  mov      x1, xzr
0068C37D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C37DC  adrp     x21, #0x959c000
0068C37E0  ldrb     w8, [x21, #0x68d]
0068C37E4  mov      w20, w0
0068C37E8  cbnz     w8, #0x68c3800
0068C37EC  adrp     x0, #0x8f27000
0068C37F0  ldr      x0, [x0, #0xa38]
0068C37F4  bl       #0x382bd14 ; 
0068C37F8  mov      w8, #1
0068C37FC  strb     w8, [x21, #0x68d]
0068C3800  adrp     x8, #0x8f27000
0068C3804  ldr      x8, [x8, #0xa38]
0068C3808  ldr      x2, [x8]
0068C380C  ldrb     w8, [x2, #0x53]
0068C3810  tbnz     w8, #5, #0x68c381c
0068C3814  str      w20, [x19, #0x24]
0068C3818  b        #0x68c382c ; 
0068C381C  ldr      x8, [x2, #0x60]
0068C3820  mov      x0, x19
0068C3824  mov      w1, w20
0068C3828  blr      x8
0068C382C  mov      x0, x19
0068C3830  mov      x1, xzr
0068C3834  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C3838  adrp     x21, #0x959c000
0068C383C  ldrb     w8, [x21, #0x68e]
0068C3840  mov      x20, x0
0068C3844  cbnz     w8, #0x68c385c
0068C3848  adrp     x0, #0x8f27000
0068C384C  ldr      x0, [x0, #0xa48]
0068C3850  bl       #0x382bd14 ; 
0068C3854  mov      w8, #1
0068C3858  strb     w8, [x21, #0x68e]
0068C385C  adrp     x8, #0x8f27000
0068C3860  ldr      x8, [x8, #0xa48]
0068C3864  ldr      x2, [x8]
0068C3868  ldrb     w8, [x2, #0x53]
0068C386C  tbnz     w8, #5, #0x68c3884
0068C3870  mov      x0, x19
0068C3874  str      x20, [x0, #0x28]!
0068C3878  mov      x1, x20
0068C387C  bl       #0x382bcb8 ; 
0068C3880  b        #0x68c3894 ; 
0068C3884  ldr      x8, [x2, #0x60]
0068C3888  mov      x0, x19
0068C388C  mov      x1, x20
0068C3890  blr      x8
0068C3894  mov      x0, x19
0068C3898  mov      x1, xzr
0068C389C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C38A0  adrp     x21, #0x959c000
0068C38A4  ldrb     w8, [x21, #0x68f]
0068C38A8  mov      w20, w0
0068C38AC  cbnz     w8, #0x68c38c4
0068C38B0  adrp     x0, #0x8f27000
0068C38B4  ldr      x0, [x0, #0xa50]
0068C38B8  bl       #0x382bd14 ; 
0068C38BC  mov      w8, #1
0068C38C0  strb     w8, [x21, #0x68f]
0068C38C4  adrp     x8, #0x8f27000
0068C38C8  ldr      x8, [x8, #0xa50]
0068C38CC  ldr      x2, [x8]
0068C38D0  ldrb     w8, [x2, #0x53]
0068C38D4  tbnz     w8, #5, #0x68c38e0
0068C38D8  str      w20, [x19, #0x30]
0068C38DC  b        #0x68c38f0 ; 
0068C38E0  ldr      x8, [x2, #0x60]
0068C38E4  mov      x0, x19
0068C38E8  mov      w1, w20
0068C38EC  blr      x8
0068C38F0  mov      x0, x19
0068C38F4  mov      x1, xzr
0068C38F8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C38FC  adrp     x21, #0x959c000
0068C3900  ldrb     w8, [x21, #0x690]
0068C3904  mov      x20, x0
0068C3908  cbnz     w8, #0x68c3920
0068C390C  adrp     x0, #0x8f27000
0068C3910  ldr      x0, [x0, #0xa58]
0068C3914  bl       #0x382bd14 ; 
0068C3918  mov      w8, #1
0068C391C  strb     w8, [x21, #0x690]
0068C3920  adrp     x8, #0x8f27000
0068C3924  ldr      x8, [x8, #0xa58]
0068C3928  ldr      x2, [x8]
0068C392C  ldrb     w8, [x2, #0x53]
0068C3930  tbnz     w8, #5, #0x68c3948
0068C3934  mov      x0, x19
0068C3938  str      x20, [x0, #0x38]!
0068C393C  mov      x1, x20
0068C3940  bl       #0x382bcb8 ; 
0068C3944  b        #0x68c3958 ; 
0068C3948  ldr      x8, [x2, #0x60]
0068C394C  mov      x0, x19
0068C3950  mov      x1, x20
0068C3954  blr      x8
0068C3958  mov      x0, x19
0068C395C  mov      x1, xzr
0068C3960  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C3964  adrp     x21, #0x959c000
0068C3968  ldrb     w8, [x21, #0x691]
0068C396C  mov      w20, w0
0068C3970  cbnz     w8, #0x68c3988
0068C3974  adrp     x0, #0x8f27000
0068C3978  ldr      x0, [x0, #0xa68]
0068C397C  bl       #0x382bd14 ; 
0068C3980  mov      w8, #1
0068C3984  strb     w8, [x21, #0x691]
0068C3988  adrp     x8, #0x8f27000
0068C398C  ldr      x8, [x8, #0xa68]
0068C3990  ldr      x2, [x8]
0068C3994  ldrb     w8, [x2, #0x53]
0068C3998  tbnz     w8, #5, #0x68c39a4
0068C399C  str      w20, [x19, #0x40]
0068C39A0  b        #0x68c39b4 ; 
0068C39A4  ldr      x8, [x2, #0x60]
0068C39A8  mov      x0, x19
0068C39AC  mov      w1, w20
0068C39B0  blr      x8
0068C39B4  mov      x0, x19
0068C39B8  mov      x1, xzr
0068C39BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C39C0  adrp     x21, #0x959c000
0068C39C4  ldrb     w8, [x21, #0x692]
0068C39C8  mov      w20, w0
0068C39CC  cbnz     w8, #0x68c39e4
0068C39D0  adrp     x0, #0x8f27000
0068C39D4  ldr      x0, [x0, #0xa78]
0068C39D8  bl       #0x382bd14 ; 
0068C39DC  mov      w8, #1
0068C39E0  strb     w8, [x21, #0x692]
0068C39E4  adrp     x8, #0x8f27000
0068C39E8  ldr      x8, [x8, #0xa78]
0068C39EC  ldr      x2, [x8]
0068C39F0  ldrb     w8, [x2, #0x53]
0068C39F4  tbnz     w8, #5, #0x68c3a00
0068C39F8  str      w20, [x19, #0x44]
0068C39FC  b        #0x68c3a10 ; 
0068C3A00  ldr      x8, [x2, #0x60]
0068C3A04  mov      x0, x19
0068C3A08  mov      w1, w20
0068C3A0C  blr      x8
0068C3A10  mov      x0, x19
0068C3A14  mov      x1, xzr
0068C3A18  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
0068C3A1C  adrp     x21, #0x959c000
0068C3A20  ldrb     w8, [x21, #0x693]
0068C3A24  mov      x20, x0
0068C3A28  cbnz     w8, #0x68c3a40
0068C3A2C  adrp     x0, #0x8f27000
0068C3A30  ldr      x0, [x0, #0xa80]
0068C3A34  bl       #0x382bd14 ; 
0068C3A38  mov      w8, #1
0068C3A3C  strb     w8, [x21, #0x693]
0068C3A40  adrp     x8, #0x8f27000
0068C3A44  ldr      x8, [x8, #0xa80]
0068C3A48  ldr      x2, [x8]
0068C3A4C  ldrb     w8, [x2, #0x53]
0068C3A50  tbnz     w8, #5, #0x68c3a68
0068C3A54  mov      x0, x19
0068C3A58  str      x20, [x0, #0x48]!
0068C3A5C  mov      x1, x20
0068C3A60  bl       #0x382bcb8 ; 
0068C3A64  b        #0x68c3a78 ; 
0068C3A68  ldr      x8, [x2, #0x60]
0068C3A6C  mov      x0, x19
0068C3A70  mov      x1, x20
0068C3A74  blr      x8
0068C3A78  mov      x0, x19
0068C3A7C  mov      x1, xzr
0068C3A80  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C3A84  adrp     x21, #0x959c000
0068C3A88  ldrb     w8, [x21, #0x694]
0068C3A8C  mov      x20, x0
0068C3A90  cbnz     w8, #0x68c3aa8
0068C3A94  adrp     x0, #0x8f27000
0068C3A98  ldr      x0, [x0, #0xa88]
0068C3A9C  bl       #0x382bd14 ; 
0068C3AA0  mov      w8, #1
0068C3AA4  strb     w8, [x21, #0x694]
0068C3AA8  adrp     x8, #0x8f27000
0068C3AAC  ldr      x8, [x8, #0xa88]
0068C3AB0  ldr      x2, [x8]
0068C3AB4  ldrb     w8, [x2, #0x53]
0068C3AB8  tbnz     w8, #5, #0x68c3ac4
0068C3ABC  str      x20, [x19, #0x50]
0068C3AC0  b        #0x68c3ad4 ; 
0068C3AC4  ldr      x8, [x2, #0x60]
0068C3AC8  mov      x0, x19
0068C3ACC  mov      x1, x20
0068C3AD0  blr      x8
0068C3AD4  mov      x0, x19
0068C3AD8  mov      x1, xzr
0068C3ADC  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068C3AE0  adrp     x20, #0x959c000
0068C3AE4  ldrb     w8, [x20, #0x695]
0068C3AE8  mov      v8.16b, v0.16b
0068C3AEC  cbnz     w8, #0x68c3b04
0068C3AF0  adrp     x0, #0x8f27000
0068C3AF4  ldr      x0, [x0, #0xa98]
0068C3AF8  bl       #0x382bd14 ; 
0068C3AFC  mov      w8, #1
0068C3B00  strb     w8, [x20, #0x695]
0068C3B04  adrp     x8, #0x8f27000
0068C3B08  ldr      x8, [x8, #0xa98]
0068C3B0C  ldr      x1, [x8]
0068C3B10  ldrb     w8, [x1, #0x53]
0068C3B14  tbnz     w8, #5, #0x68c3b20
0068C3B18  str      s8, [x19, #0x58]
0068C3B1C  b        #0x68c3b30 ; 
0068C3B20  ldr      x8, [x1, #0x60]
0068C3B24  mov      x0, x19
0068C3B28  mov      v0.16b, v8.16b
0068C3B2C  blr      x8
0068C3B30  mov      x0, x19
0068C3B34  mov      x1, xzr
0068C3B38  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C3B3C  adrp     x21, #0x959c000
0068C3B40  ldrb     w8, [x21, #0x696]
0068C3B44  mov      w20, w0
0068C3B48  cbnz     w8, #0x68c3b60
0068C3B4C  adrp     x0, #0x8f27000
0068C3B50  ldr      x0, [x0, #0xaa0]
0068C3B54  bl       #0x382bd14 ; 
0068C3B58  mov      w8, #1
0068C3B5C  strb     w8, [x21, #0x696]
0068C3B60  adrp     x8, #0x8f27000
0068C3B64  ldr      x8, [x8, #0xaa0]
0068C3B68  ldr      x2, [x8]
0068C3B6C  ldrb     w8, [x2, #0x53]
0068C3B70  tbnz     w8, #5, #0x68c3b7c
0068C3B74  str      w20, [x19, #0x5c]
0068C3B78  b        #0x68c3b8c ; 
0068C3B7C  ldr      x8, [x2, #0x60]
0068C3B80  mov      x0, x19
0068C3B84  mov      w1, w20
0068C3B88  blr      x8
0068C3B8C  mov      x0, x19
0068C3B90  mov      x1, xzr
0068C3B94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C3B98  adrp     x21, #0x959c000
0068C3B9C  ldrb     w8, [x21, #0x697]
0068C3BA0  mov      w20, w0
0068C3BA4  cbnz     w8, #0x68c3bbc
0068C3BA8  adrp     x0, #0x8f27000
0068C3BAC  ldr      x0, [x0, #0xab0]
0068C3BB0  bl       #0x382bd14 ; 
0068C3BB4  mov      w8, #1
0068C3BB8  strb     w8, [x21, #0x697]
0068C3BBC  adrp     x8, #0x8f27000
0068C3BC0  ldr      x8, [x8, #0xab0]
0068C3BC4  ldr      x2, [x8]
0068C3BC8  ldrb     w8, [x2, #0x53]
0068C3BCC  tbnz     w8, #5, #0x68c3bd8
0068C3BD0  str      w20, [x19, #0x60]
0068C3BD4  b        #0x68c3be8 ; 
0068C3BD8  ldr      x8, [x2, #0x60]
0068C3BDC  mov      x0, x19
0068C3BE0  mov      w1, w20
0068C3BE4  blr      x8
0068C3BE8  mov      x0, x19
0068C3BEC  mov      x1, xzr
0068C3BF0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C3BF4  adrp     x21, #0x959c000
0068C3BF8  ldrb     w8, [x21, #0x698]
0068C3BFC  mov      x20, x0
0068C3C00  cbnz     w8, #0x68c3c18
0068C3C04  adrp     x0, #0x8f27000
0068C3C08  ldr      x0, [x0, #0xac0]
0068C3C0C  bl       #0x382bd14 ; 
0068C3C10  mov      w8, #1
0068C3C14  strb     w8, [x21, #0x698]
0068C3C18  adrp     x8, #0x8f27000
0068C3C1C  ldr      x8, [x8, #0xac0]
0068C3C20  ldr      x2, [x8]
0068C3C24  ldrb     w8, [x2, #0x53]
0068C3C28  tbnz     w8, #5, #0x68c3c34
0068C3C2C  str      x20, [x19, #0x68]
0068C3C30  b        #0x68c3c44 ; 
0068C3C34  ldr      x8, [x2, #0x60]
0068C3C38  mov      x0, x19
0068C3C3C  mov      x1, x20
0068C3C40  blr      x8
0068C3C44  mov      x0, x19
0068C3C48  mov      x1, xzr
0068C3C4C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C3C50  adrp     x21, #0x959c000
0068C3C54  ldrb     w8, [x21, #0x699]
0068C3C58  mov      x20, x0
0068C3C5C  cbnz     w8, #0x68c3c74
0068C3C60  adrp     x0, #0x8f27000
0068C3C64  ldr      x0, [x0, #0xad0]
0068C3C68  bl       #0x382bd14 ; 
0068C3C6C  mov      w8, #1
0068C3C70  strb     w8, [x21, #0x699]
0068C3C74  adrp     x8, #0x8f27000
0068C3C78  ldr      x8, [x8, #0xad0]
0068C3C7C  ldr      x2, [x8]
0068C3C80  ldrb     w8, [x2, #0x53]
0068C3C84  tbnz     w8, #5, #0x68c3c90
0068C3C88  str      x20, [x19, #0x70]
0068C3C8C  b        #0x68c3ca0 ; 
0068C3C90  ldr      x8, [x2, #0x60]
0068C3C94  mov      x0, x19
0068C3C98  mov      x1, x20
0068C3C9C  blr      x8
0068C3CA0  mov      x0, x19
0068C3CA4  mov      x1, xzr
0068C3CA8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C3CAC  adrp     x21, #0x959c000
0068C3CB0  ldrb     w8, [x21, #0x69a]
0068C3CB4  mov      x20, x0
0068C3CB8  cbnz     w8, #0x68c3cd0
0068C3CBC  adrp     x0, #0x8f27000
0068C3CC0  ldr      x0, [x0, #0xad8]
0068C3CC4  bl       #0x382bd14 ; 
0068C3CC8  mov      w8, #1
0068C3CCC  strb     w8, [x21, #0x69a]
0068C3CD0  adrp     x8, #0x8f27000
0068C3CD4  ldr      x8, [x8, #0xad8]
0068C3CD8  ldr      x2, [x8]
0068C3CDC  ldrb     w8, [x2, #0x53]
0068C3CE0  tbnz     w8, #5, #0x68c3cec
0068C3CE4  str      x20, [x19, #0x78]
0068C3CE8  b        #0x68c3cfc ; 
0068C3CEC  ldr      x8, [x2, #0x60]
0068C3CF0  mov      x0, x19
0068C3CF4  mov      x1, x20
0068C3CF8  blr      x8
0068C3CFC  mov      x0, x19
0068C3D00  mov      x1, xzr
0068C3D04  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C3D08  adrp     x21, #0x959c000
0068C3D0C  ldrb     w8, [x21, #0x69b]
0068C3D10  mov      x20, x0
0068C3D14  cbnz     w8, #0x68c3d2c
0068C3D18  adrp     x0, #0x8f27000
0068C3D1C  ldr      x0, [x0, #0xae0]
0068C3D20  bl       #0x382bd14 ; 
0068C3D24  mov      w8, #1
0068C3D28  strb     w8, [x21, #0x69b]
0068C3D2C  adrp     x8, #0x8f27000
0068C3D30  ldr      x8, [x8, #0xae0]
0068C3D34  ldr      x2, [x8]
0068C3D38  ldrb     w8, [x2, #0x53]
0068C3D3C  tbnz     w8, #5, #0x68c3d48
0068C3D40  str      x20, [x19, #0x80]
0068C3D44  b        #0x68c3d58 ; 
0068C3D48  ldr      x8, [x2, #0x60]
0068C3D4C  mov      x0, x19
0068C3D50  mov      x1, x20
0068C3D54  blr      x8
0068C3D58  mov      x0, x19
0068C3D5C  mov      x1, xzr
0068C3D60  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068C3D64  adrp     x21, #0x959c000
0068C3D68  ldrb     w8, [x21, #0x69c]
0068C3D6C  mov      x20, x0
0068C3D70  cbnz     w8, #0x68c3d88
0068C3D74  adrp     x0, #0x8f27000
0068C3D78  ldr      x0, [x0, #0xaf0]
0068C3D7C  bl       #0x382bd14 ; 
0068C3D80  mov      w8, #1
0068C3D84  strb     w8, [x21, #0x69c]
0068C3D88  adrp     x8, #0x8f27000
0068C3D8C  ldr      x8, [x8, #0xaf0]
0068C3D90  ldr      x2, [x8]
0068C3D94  ldrb     w8, [x2, #0x53]
0068C3D98  tbnz     w8, #5, #0x68c3db0
0068C3D9C  mov      x0, x19
0068C3DA0  str      x20, [x0, #0x88]!
0068C3DA4  mov      x1, x20
0068C3DA8  bl       #0x382bcb8 ; 
0068C3DAC  b        #0x68c3dc0 ; 
0068C3DB0  ldr      x8, [x2, #0x60]
0068C3DB4  mov      x0, x19
0068C3DB8  mov      x1, x20
0068C3DBC  blr      x8
0068C3DC0  mov      x0, x19
0068C3DC4  mov      x1, xzr
0068C3DC8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C3DCC  adrp     x21, #0x959c000
0068C3DD0  ldrb     w8, [x21, #0x69d]
0068C3DD4  mov      x20, x0
0068C3DD8  cbnz     w8, #0x68c3df0
0068C3DDC  adrp     x0, #0x8f27000
0068C3DE0  ldr      x0, [x0, #0xaf8]
0068C3DE4  bl       #0x382bd14 ; 
0068C3DE8  mov      w8, #1
0068C3DEC  strb     w8, [x21, #0x69d]
0068C3DF0  adrp     x8, #0x8f27000
0068C3DF4  ldr      x8, [x8, #0xaf8]
0068C3DF8  ldr      x2, [x8]
0068C3DFC  ldrb     w8, [x2, #0x53]
0068C3E00  tbnz     w8, #5, #0x68c3e18
0068C3E04  mov      x0, x19
0068C3E08  str      x20, [x0, #0x90]!
0068C3E0C  mov      x1, x20
0068C3E10  bl       #0x382bcb8 ; 
0068C3E14  b        #0x68c3e28 ; 
0068C3E18  ldr      x8, [x2, #0x60]
0068C3E1C  mov      x0, x19
0068C3E20  mov      x1, x20
0068C3E24  blr      x8
0068C3E28  mov      x0, x19
0068C3E2C  mov      x1, xzr
0068C3E30  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C3E34  adrp     x21, #0x959c000
0068C3E38  ldrb     w8, [x21, #0x69e]
0068C3E3C  mov      x20, x0
0068C3E40  cbnz     w8, #0x68c3e58
0068C3E44  adrp     x0, #0x8f27000
0068C3E48  ldr      x0, [x0, #0xb08]
0068C3E4C  bl       #0x382bd14 ; 
0068C3E50  mov      w8, #1
0068C3E54  strb     w8, [x21, #0x69e]
0068C3E58  adrp     x8, #0x8f27000
0068C3E5C  ldr      x8, [x8, #0xb08]
0068C3E60  ldr      x2, [x8]
0068C3E64  ldrb     w8, [x2, #0x53]
0068C3E68  tbnz     w8, #5, #0x68c3e80
0068C3E6C  mov      x0, x19
0068C3E70  str      x20, [x0, #0x98]!
0068C3E74  mov      x1, x20
0068C3E78  bl       #0x382bcb8 ; 
0068C3E7C  b        #0x68c3e90 ; 
0068C3E80  ldr      x8, [x2, #0x60]
0068C3E84  mov      x0, x19
0068C3E88  mov      x1, x20
0068C3E8C  blr      x8
0068C3E90  mov      x0, x19
0068C3E94  mov      x1, xzr
0068C3E98  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C3E9C  adrp     x21, #0x959c000
0068C3EA0  ldrb     w8, [x21, #0x69f]
0068C3EA4  mov      x20, x0
0068C3EA8  cbnz     w8, #0x68c3ec0
0068C3EAC  adrp     x0, #0x8f27000
0068C3EB0  ldr      x0, [x0, #0xb18]
0068C3EB4  bl       #0x382bd14 ; 
0068C3EB8  mov      w8, #1
0068C3EBC  strb     w8, [x21, #0x69f]
0068C3EC0  adrp     x8, #0x8f27000
0068C3EC4  ldr      x8, [x8, #0xb18]
0068C3EC8  ldr      x2, [x8]
0068C3ECC  ldrb     w8, [x2, #0x53]
0068C3ED0  tbnz     w8, #5, #0x68c3ee8
0068C3ED4  mov      x0, x19
0068C3ED8  str      x20, [x0, #0xa0]!
0068C3EDC  mov      x1, x20
0068C3EE0  bl       #0x382bcb8 ; 
0068C3EE4  b        #0x68c3ef8 ; 
0068C3EE8  ldr      x8, [x2, #0x60]
0068C3EEC  mov      x0, x19
0068C3EF0  mov      x1, x20
0068C3EF4  blr      x8
0068C3EF8  mov      x0, x19
0068C3EFC  mov      x1, xzr
0068C3F00  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C3F04  adrp     x21, #0x959c000
0068C3F08  ldrb     w8, [x21, #0x6a0]
0068C3F0C  mov      x20, x0
0068C3F10  cbnz     w8, #0x68c3f28
0068C3F14  adrp     x0, #0x8f27000
0068C3F18  ldr      x0, [x0, #0xb20]
0068C3F1C  bl       #0x382bd14 ; 
0068C3F20  mov      w8, #1
0068C3F24  strb     w8, [x21, #0x6a0]
0068C3F28  adrp     x8, #0x8f27000
0068C3F2C  ldr      x8, [x8, #0xb20]
0068C3F30  ldr      x2, [x8]
0068C3F34  ldrb     w8, [x2, #0x53]
0068C3F38  tbnz     w8, #5, #0x68c3f44
0068C3F3C  str      x20, [x19, #0xa8]
0068C3F40  b        #0x68c3f54 ; 
0068C3F44  ldr      x8, [x2, #0x60]
0068C3F48  mov      x0, x19
0068C3F4C  mov      x1, x20
0068C3F50  blr      x8
0068C3F54  mov      x0, x19
0068C3F58  mov      x1, xzr
0068C3F5C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C3F60  adrp     x21, #0x959c000
0068C3F64  ldrb     w8, [x21, #0x6a1]
0068C3F68  mov      x20, x0
0068C3F6C  cbnz     w8, #0x68c3f84
0068C3F70  adrp     x0, #0x8f27000
0068C3F74  ldr      x0, [x0, #0xb28]
0068C3F78  bl       #0x382bd14 ; 
0068C3F7C  mov      w8, #1
0068C3F80  strb     w8, [x21, #0x6a1]
0068C3F84  adrp     x8, #0x8f27000
0068C3F88  ldr      x8, [x8, #0xb28]
0068C3F8C  ldr      x2, [x8]
0068C3F90  ldrb     w8, [x2, #0x53]
0068C3F94  tbnz     w8, #5, #0x68c3fa0
0068C3F98  str      x20, [x19, #0xb0]
0068C3F9C  b        #0x68c3fb0 ; 
0068C3FA0  ldr      x8, [x2, #0x60]
0068C3FA4  mov      x0, x19
0068C3FA8  mov      x1, x20
0068C3FAC  blr      x8
0068C3FB0  mov      x0, x19
0068C3FB4  mov      x1, xzr
0068C3FB8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C3FBC  adrp     x21, #0x959c000
0068C3FC0  ldrb     w8, [x21, #0x6a2]
0068C3FC4  mov      x20, x0
0068C3FC8  cbnz     w8, #0x68c3fe0
0068C3FCC  adrp     x0, #0x8f27000
0068C3FD0  ldr      x0, [x0, #0xb38]
0068C3FD4  bl       #0x382bd14 ; 
0068C3FD8  mov      w8, #1
0068C3FDC  strb     w8, [x21, #0x6a2]
0068C3FE0  adrp     x8, #0x8f27000
0068C3FE4  ldr      x8, [x8, #0xb38]
0068C3FE8  ldr      x2, [x8]
0068C3FEC  ldrb     w8, [x2, #0x53]
0068C3FF0  tbnz     w8, #5, #0x68c3ffc
0068C3FF4  str      x20, [x19, #0xb8]
0068C3FF8  b        #0x68c400c ; 
0068C3FFC  ldr      x8, [x2, #0x60]
0068C4000  mov      x0, x19
0068C4004  mov      x1, x20
0068C4008  blr      x8
0068C400C  mov      x0, x19
0068C4010  mov      x1, xzr
0068C4014  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C4018  adrp     x21, #0x959c000
0068C401C  ldrb     w8, [x21, #0x6a3]
0068C4020  mov      x20, x0
0068C4024  cbnz     w8, #0x68c403c
0068C4028  adrp     x0, #0x8f27000
0068C402C  ldr      x0, [x0, #0xb48]
0068C4030  bl       #0x382bd14 ; 
0068C4034  mov      w8, #1
0068C4038  strb     w8, [x21, #0x6a3]
0068C403C  adrp     x8, #0x8f27000
0068C4040  ldr      x8, [x8, #0xb48]
0068C4044  ldr      x2, [x8]
0068C4048  ldrb     w8, [x2, #0x53]
0068C404C  tbnz     w8, #5, #0x68c4058
0068C4050  str      x20, [x19, #0xc0]
0068C4054  b        #0x68c4068 ; 
0068C4058  ldr      x8, [x2, #0x60]
0068C405C  mov      x0, x19
0068C4060  mov      x1, x20
0068C4064  blr      x8
0068C4068  mov      x0, x19
0068C406C  mov      x1, xzr
0068C4070  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C4074  adrp     x21, #0x959c000
0068C4078  ldrb     w8, [x21, #0x6a4]
0068C407C  mov      x20, x0
0068C4080  cbnz     w8, #0x68c4098
0068C4084  adrp     x0, #0x8f27000
0068C4088  ldr      x0, [x0, #0xb50]
0068C408C  bl       #0x382bd14 ; 
0068C4090  mov      w8, #1
0068C4094  strb     w8, [x21, #0x6a4]
0068C4098  adrp     x8, #0x8f27000
0068C409C  ldr      x8, [x8, #0xb50]
0068C40A0  ldr      x2, [x8]
0068C40A4  ldrb     w8, [x2, #0x53]
0068C40A8  tbnz     w8, #5, #0x68c40c0
0068C40AC  mov      x0, x19
0068C40B0  str      x20, [x0, #0xc8]!
0068C40B4  mov      x1, x20
0068C40B8  bl       #0x382bcb8 ; 
0068C40BC  b        #0x68c40d0 ; 
0068C40C0  ldr      x8, [x2, #0x60]
0068C40C4  mov      x0, x19
0068C40C8  mov      x1, x20
0068C40CC  blr      x8
0068C40D0  mov      x0, x19
0068C40D4  mov      x1, xzr
0068C40D8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C40DC  adrp     x21, #0x959c000
0068C40E0  ldrb     w8, [x21, #0x6a5]
0068C40E4  mov      x20, x0
0068C40E8  cbnz     w8, #0x68c4100
0068C40EC  adrp     x0, #0x8f27000
0068C40F0  ldr      x0, [x0, #0xb60]
0068C40F4  bl       #0x382bd14 ; 
0068C40F8  mov      w8, #1
0068C40FC  strb     w8, [x21, #0x6a5]
0068C4100  adrp     x8, #0x8f27000
0068C4104  ldr      x8, [x8, #0xb60]
0068C4108  ldr      x2, [x8]
0068C410C  ldrb     w8, [x2, #0x53]
0068C4110  tbnz     w8, #5, #0x68c411c
0068C4114  str      x20, [x19, #0xd0]
0068C4118  b        #0x68c412c ; 
0068C411C  ldr      x8, [x2, #0x60]
0068C4120  mov      x0, x19
0068C4124  mov      x1, x20
0068C4128  blr      x8
0068C412C  mov      x0, x19
0068C4130  mov      x1, xzr
0068C4134  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C4138  adrp     x21, #0x959c000
0068C413C  ldrb     w8, [x21, #0x6a6]
0068C4140  mov      x20, x0
0068C4144  cbnz     w8, #0x68c415c
0068C4148  adrp     x0, #0x8f27000
0068C414C  ldr      x0, [x0, #0xb70]
0068C4150  bl       #0x382bd14 ; 
0068C4154  mov      w8, #1
0068C4158  strb     w8, [x21, #0x6a6]
0068C415C  adrp     x8, #0x8f27000
0068C4160  ldr      x8, [x8, #0xb70]
0068C4164  ldr      x2, [x8]
0068C4168  ldrb     w8, [x2, #0x53]
0068C416C  tbnz     w8, #5, #0x68c4178
0068C4170  str      x20, [x19, #0xd8]
0068C4174  b        #0x68c4188 ; 
0068C4178  ldr      x8, [x2, #0x60]
0068C417C  mov      x0, x19
0068C4180  mov      x1, x20
0068C4184  blr      x8
0068C4188  mov      x0, x19
0068C418C  mov      x1, xzr
0068C4190  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C4194  adrp     x21, #0x959c000
0068C4198  ldrb     w8, [x21, #0x6a7]
0068C419C  mov      w20, w0
0068C41A0  cbnz     w8, #0x68c41b8
0068C41A4  adrp     x0, #0x8f27000
0068C41A8  ldr      x0, [x0, #0xb80]
0068C41AC  bl       #0x382bd14 ; 
0068C41B0  mov      w8, #1
0068C41B4  strb     w8, [x21, #0x6a7]
0068C41B8  adrp     x8, #0x8f27000
0068C41BC  ldr      x8, [x8, #0xb80]
0068C41C0  ldr      x2, [x8]
0068C41C4  ldrb     w8, [x2, #0x53]
0068C41C8  tbnz     w8, #5, #0x68c41d4
0068C41CC  str      w20, [x19, #0xe0]
0068C41D0  b        #0x68c41e4 ; 
0068C41D4  ldr      x8, [x2, #0x60]
0068C41D8  mov      x0, x19
0068C41DC  mov      w1, w20
0068C41E0  blr      x8
0068C41E4  mov      x0, x19
0068C41E8  mov      x1, xzr
0068C41EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C41F0  adrp     x21, #0x959c000
0068C41F4  ldrb     w8, [x21, #0x6a8]
0068C41F8  mov      w20, w0
0068C41FC  cbnz     w8, #0x68c4214
0068C4200  adrp     x0, #0x8f27000
0068C4204  ldr      x0, [x0, #0xb90]
0068C4208  bl       #0x382bd14 ; 
0068C420C  mov      w8, #1
0068C4210  strb     w8, [x21, #0x6a8]
0068C4214  adrp     x8, #0x8f27000
0068C4218  ldr      x8, [x8, #0xb90]
0068C421C  ldr      x2, [x8]
0068C4220  ldrb     w8, [x2, #0x53]
0068C4224  tbnz     w8, #5, #0x68c4230
0068C4228  str      w20, [x19, #0xe4]
0068C422C  b        #0x68c4240 ; 
0068C4230  ldr      x8, [x2, #0x60]
0068C4234  mov      x0, x19
0068C4238  mov      w1, w20
0068C423C  blr      x8
0068C4240  mov      x0, x19
0068C4244  mov      x1, xzr
0068C4248  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068C424C  adrp     x21, #0x959c000
0068C4250  ldrb     w8, [x21, #0x6a9]
0068C4254  mov      x20, x0
0068C4258  cbnz     w8, #0x68c4270
0068C425C  adrp     x0, #0x8f27000
0068C4260  ldr      x0, [x0, #0xba0]
0068C4264  bl       #0x382bd14 ; 
0068C4268  mov      w8, #1
0068C426C  strb     w8, [x21, #0x6a9]
0068C4270  adrp     x8, #0x8f27000
0068C4274  ldr      x8, [x8, #0xba0]
0068C4278  ldr      x2, [x8]
0068C427C  ldrb     w8, [x2, #0x53]
0068C4280  tbnz     w8, #5, #0x68c4298
0068C4284  mov      x0, x19
0068C4288  str      x20, [x0, #0xe8]!
0068C428C  mov      x1, x20
0068C4290  bl       #0x382bcb8 ; 
0068C4294  b        #0x68c42a8 ; 
0068C4298  ldr      x8, [x2, #0x60]
0068C429C  mov      x0, x19
0068C42A0  mov      x1, x20
0068C42A4  blr      x8
0068C42A8  mov      x0, x19
0068C42AC  mov      x1, xzr
0068C42B0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C42B4  adrp     x21, #0x959c000
0068C42B8  ldrb     w8, [x21, #0x6aa]
0068C42BC  mov      x20, x0
0068C42C0  cbnz     w8, #0x68c42d8
0068C42C4  adrp     x0, #0x8f27000
0068C42C8  ldr      x0, [x0, #0xbb0]
0068C42CC  bl       #0x382bd14 ; 
0068C42D0  mov      w8, #1
0068C42D4  strb     w8, [x21, #0x6aa]
0068C42D8  adrp     x8, #0x8f27000
0068C42DC  ldr      x8, [x8, #0xbb0]
0068C42E0  ldr      x2, [x8]
0068C42E4  ldrb     w8, [x2, #0x53]
0068C42E8  tbnz     w8, #5, #0x68c4300
0068C42EC  mov      x0, x19
0068C42F0  str      x20, [x0, #0xf0]!
0068C42F4  mov      x1, x20
0068C42F8  bl       #0x382bcb8 ; 
0068C42FC  b        #0x68c4310 ; 
0068C4300  ldr      x8, [x2, #0x60]
0068C4304  mov      x0, x19
0068C4308  mov      x1, x20
0068C430C  blr      x8
0068C4310  mov      x0, x19
0068C4314  mov      x1, xzr
0068C4318  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C431C  adrp     x21, #0x959c000
0068C4320  ldrb     w8, [x21, #0x6ab]
0068C4324  mov      x20, x0
0068C4328  cbnz     w8, #0x68c4340
0068C432C  adrp     x0, #0x8f27000
0068C4330  ldr      x0, [x0, #0xbc0]
0068C4334  bl       #0x382bd14 ; 
0068C4338  mov      w8, #1
0068C433C  strb     w8, [x21, #0x6ab]
0068C4340  adrp     x8, #0x8f27000
0068C4344  ldr      x8, [x8, #0xbc0]
0068C4348  ldr      x2, [x8]
0068C434C  ldrb     w8, [x2, #0x53]
0068C4350  tbnz     w8, #5, #0x68c4368
0068C4354  mov      x0, x19
0068C4358  str      x20, [x0, #0xf8]!
0068C435C  mov      x1, x20
0068C4360  bl       #0x382bcb8 ; 
0068C4364  b        #0x68c4378 ; 
0068C4368  ldr      x8, [x2, #0x60]
0068C436C  mov      x0, x19
0068C4370  mov      x1, x20
0068C4374  blr      x8
0068C4378  mov      x0, x19
0068C437C  mov      x1, xzr
0068C4380  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C4384  adrp     x21, #0x959c000
0068C4388  ldrb     w8, [x21, #0x6ac]
0068C438C  mov      x20, x0
0068C4390  cbnz     w8, #0x68c43a8
0068C4394  adrp     x0, #0x8f27000
0068C4398  ldr      x0, [x0, #0xbd0]
0068C439C  bl       #0x382bd14 ; 
0068C43A0  mov      w8, #1
0068C43A4  strb     w8, [x21, #0x6ac]
0068C43A8  adrp     x8, #0x8f27000
0068C43AC  ldr      x8, [x8, #0xbd0]
0068C43B0  ldr      x2, [x8]
0068C43B4  ldrb     w8, [x2, #0x53]
0068C43B8  tbnz     w8, #5, #0x68c43d0
0068C43BC  add      x0, x19, #0x100
0068C43C0  mov      x1, x20
0068C43C4  str      x20, [x19, #0x100]
0068C43C8  bl       #0x382bcb8 ; 
0068C43CC  b        #0x68c43e0 ; 
0068C43D0  ldr      x8, [x2, #0x60]
0068C43D4  mov      x0, x19
0068C43D8  mov      x1, x20
0068C43DC  blr      x8
0068C43E0  mov      x0, x19
0068C43E4  mov      x1, xzr
0068C43E8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C43EC  adrp     x21, #0x959c000
0068C43F0  ldrb     w8, [x21, #0x6ad]
0068C43F4  mov      x20, x0
0068C43F8  cbnz     w8, #0x68c4410
0068C43FC  adrp     x0, #0x8f27000
0068C4400  ldr      x0, [x0, #0xbe0]
0068C4404  bl       #0x382bd14 ; 
0068C4408  mov      w8, #1
0068C440C  strb     w8, [x21, #0x6ad]
0068C4410  adrp     x8, #0x8f27000
0068C4414  ldr      x8, [x8, #0xbe0]
0068C4418  ldr      x2, [x8]
0068C441C  ldrb     w8, [x2, #0x53]
0068C4420  tbnz     w8, #5, #0x68c4438
0068C4424  add      x0, x19, #0x108
0068C4428  mov      x1, x20
0068C442C  str      x20, [x19, #0x108]
0068C4430  bl       #0x382bcb8 ; 
0068C4434  b        #0x68c4448 ; 
0068C4438  ldr      x8, [x2, #0x60]
0068C443C  mov      x0, x19
0068C4440  mov      x1, x20
0068C4444  blr      x8
0068C4448  mov      x0, x19
0068C444C  mov      x1, xzr
0068C4450  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
0068C4454  adrp     x21, #0x959c000
0068C4458  ldrb     w8, [x21, #0x6ae]
0068C445C  mov      x20, x0
0068C4460  cbnz     w8, #0x68c4478
0068C4464  adrp     x0, #0x8f27000
0068C4468  ldr      x0, [x0, #0xbe8]
0068C446C  bl       #0x382bd14 ; 
0068C4470  mov      w8, #1
0068C4474  strb     w8, [x21, #0x6ae]
0068C4478  adrp     x8, #0x8f27000
0068C447C  ldr      x8, [x8, #0xbe8]
0068C4480  ldr      x2, [x8]
0068C4484  ldrb     w8, [x2, #0x53]
0068C4488  tbnz     w8, #5, #0x68c44a0
0068C448C  add      x0, x19, #0x110
0068C4490  mov      x1, x20
0068C4494  str      x20, [x19, #0x110]
0068C4498  bl       #0x382bcb8 ; 
0068C449C  b        #0x68c44b0 ; 
0068C44A0  ldr      x8, [x2, #0x60]
0068C44A4  mov      x0, x19
0068C44A8  mov      x1, x20
0068C44AC  blr      x8
0068C44B0  mov      x0, x19
0068C44B4  mov      x1, xzr
0068C44B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C44BC  adrp     x21, #0x959c000
0068C44C0  ldrb     w8, [x21, #0x6af]
0068C44C4  mov      w20, w0
0068C44C8  cbnz     w8, #0x68c44e0
0068C44CC  adrp     x0, #0x8f27000
0068C44D0  ldr      x0, [x0, #0xbf0]
0068C44D4  bl       #0x382bd14 ; 
0068C44D8  mov      w8, #1
0068C44DC  strb     w8, [x21, #0x6af]
0068C44E0  adrp     x8, #0x8f27000
0068C44E4  ldr      x8, [x8, #0xbf0]
0068C44E8  ldr      x2, [x8]
0068C44EC  ldrb     w8, [x2, #0x53]
0068C44F0  tbnz     w8, #5, #0x68c44fc
0068C44F4  str      w20, [x19, #0x118]
0068C44F8  b        #0x68c450c ; 
0068C44FC  ldr      x8, [x2, #0x60]
0068C4500  mov      x0, x19
0068C4504  mov      w1, w20
0068C4508  blr      x8
0068C450C  mov      x0, x19
0068C4510  mov      x1, xzr
0068C4514  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C4518  adrp     x21, #0x959c000
0068C451C  ldrb     w8, [x21, #0x6b0]
0068C4520  mov      w20, w0
0068C4524  cbnz     w8, #0x68c453c
0068C4528  adrp     x0, #0x8f27000
0068C452C  ldr      x0, [x0, #0xbf8]
0068C4530  bl       #0x382bd14 ; 
0068C4534  mov      w8, #1
0068C4538  strb     w8, [x21, #0x6b0]
0068C453C  adrp     x8, #0x8f27000
0068C4540  ldr      x8, [x8, #0xbf8]
0068C4544  ldr      x2, [x8]
0068C4548  ldrb     w8, [x2, #0x53]
0068C454C  tbnz     w8, #5, #0x68c4558
0068C4550  str      w20, [x19, #0x11c]
0068C4554  b        #0x68c4568 ; 
0068C4558  ldr      x8, [x2, #0x60]
0068C455C  mov      x0, x19
0068C4560  mov      w1, w20
0068C4564  blr      x8
0068C4568  mov      x0, x19
0068C456C  mov      x1, xzr
0068C4570  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C4574  adrp     x21, #0x959c000
0068C4578  ldrb     w8, [x21, #0x6b1]
0068C457C  mov      w20, w0
0068C4580  cbnz     w8, #0x68c4598
0068C4584  adrp     x0, #0x8f27000
0068C4588  ldr      x0, [x0, #0xc00]
0068C458C  bl       #0x382bd14 ; 
0068C4590  mov      w8, #1
0068C4594  strb     w8, [x21, #0x6b1]
0068C4598  adrp     x8, #0x8f27000
0068C459C  ldr      x8, [x8, #0xc00]
0068C45A0  ldr      x2, [x8]
0068C45A4  ldrb     w8, [x2, #0x53]
0068C45A8  tbnz     w8, #5, #0x68c45b4
0068C45AC  str      w20, [x19, #0x120]
0068C45B0  b        #0x68c45c4 ; 
0068C45B4  ldr      x8, [x2, #0x60]
0068C45B8  mov      x0, x19
0068C45BC  mov      w1, w20
0068C45C0  blr      x8
0068C45C4  mov      x0, x19
0068C45C8  mov      x1, xzr
0068C45CC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C45D0  adrp     x21, #0x959c000
0068C45D4  ldrb     w8, [x21, #0x6b2]
0068C45D8  mov      x20, x0
0068C45DC  cbnz     w8, #0x68c45f4
0068C45E0  adrp     x0, #0x8f27000
0068C45E4  ldr      x0, [x0, #0xc10]
0068C45E8  bl       #0x382bd14 ; 
0068C45EC  mov      w8, #1
0068C45F0  strb     w8, [x21, #0x6b2]
0068C45F4  adrp     x8, #0x8f27000
0068C45F8  ldr      x8, [x8, #0xc10]
0068C45FC  ldr      x2, [x8]
0068C4600  ldrb     w8, [x2, #0x53]
0068C4604  tbnz     w8, #5, #0x68c461c
0068C4608  add      x0, x19, #0x128
0068C460C  mov      x1, x20
0068C4610  str      x20, [x19, #0x128]
0068C4614  bl       #0x382bcb8 ; 
0068C4618  b        #0x68c462c ; 
0068C461C  ldr      x8, [x2, #0x60]
0068C4620  mov      x0, x19
0068C4624  mov      x1, x20
0068C4628  blr      x8
0068C462C  mov      x0, x19
0068C4630  mov      x1, xzr
0068C4634  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068C4638  adrp     x21, #0x959c000
0068C463C  ldrb     w8, [x21, #0x6b3]
0068C4640  mov      x20, x0
0068C4644  cbnz     w8, #0x68c465c
0068C4648  adrp     x0, #0x8f27000
0068C464C  ldr      x0, [x0, #0xc20]
0068C4650  bl       #0x382bd14 ; 
0068C4654  mov      w8, #1
0068C4658  strb     w8, [x21, #0x6b3]
0068C465C  adrp     x8, #0x8f27000
0068C4660  ldr      x8, [x8, #0xc20]
0068C4664  ldr      x2, [x8]
0068C4668  ldrb     w8, [x2, #0x53]
0068C466C  tbnz     w8, #5, #0x68c4684
0068C4670  add      x0, x19, #0x130
0068C4674  mov      x1, x20
0068C4678  str      x20, [x19, #0x130]
0068C467C  bl       #0x382bcb8 ; 
0068C4680  b        #0x68c4694 ; 
0068C4684  ldr      x8, [x2, #0x60]
0068C4688  mov      x0, x19
0068C468C  mov      x1, x20
0068C4690  blr      x8
0068C4694  mov      x0, x19
0068C4698  mov      x1, xzr
0068C469C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068C46A0  adrp     x21, #0x959c000
0068C46A4  ldrb     w8, [x21, #0x6b4]
0068C46A8  mov      x20, x0
0068C46AC  cbnz     w8, #0x68c46c4
0068C46B0  adrp     x0, #0x8f27000
0068C46B4  ldr      x0, [x0, #0xc30]
0068C46B8  bl       #0x382bd14 ; 
0068C46BC  mov      w8, #1
0068C46C0  strb     w8, [x21, #0x6b4]
0068C46C4  adrp     x8, #0x8f27000
0068C46C8  ldr      x8, [x8, #0xc30]
0068C46CC  ldr      x2, [x8]
0068C46D0  ldrb     w8, [x2, #0x53]
0068C46D4  tbnz     w8, #5, #0x68c46ec
0068C46D8  add      x0, x19, #0x138
0068C46DC  mov      x1, x20
0068C46E0  str      x20, [x19, #0x138]
0068C46E4  bl       #0x382bcb8 ; 
0068C46E8  b        #0x68c46fc ; 
0068C46EC  ldr      x8, [x2, #0x60]
0068C46F0  mov      x0, x19
0068C46F4  mov      x1, x20
0068C46F8  blr      x8
0068C46FC  mov      x0, x19
0068C4700  mov      x1, xzr
0068C4704  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068C4708  adrp     x21, #0x959c000
0068C470C  ldrb     w8, [x21, #0x6b5]
0068C4710  mov      x20, x0
0068C4714  cbnz     w8, #0x68c472c
0068C4718  adrp     x0, #0x8f27000
0068C471C  ldr      x0, [x0, #0xc40]
0068C4720  bl       #0x382bd14 ; 
0068C4724  mov      w8, #1
0068C4728  strb     w8, [x21, #0x6b5]
0068C472C  adrp     x8, #0x8f27000
0068C4730  ldr      x8, [x8, #0xc40]
0068C4734  ldr      x2, [x8]
0068C4738  ldrb     w8, [x2, #0x53]
0068C473C  tbnz     w8, #5, #0x68c4754
0068C4740  add      x0, x19, #0x140
0068C4744  mov      x1, x20
0068C4748  str      x20, [x19, #0x140]
0068C474C  bl       #0x382bcb8 ; 
0068C4750  b        #0x68c4764 ; 
0068C4754  ldr      x8, [x2, #0x60]
0068C4758  mov      x0, x19
0068C475C  mov      x1, x20
0068C4760  blr      x8
0068C4764  mov      x0, x19
0068C4768  mov      x1, xzr
0068C476C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068C4770  adrp     x21, #0x959c000
0068C4774  ldrb     w8, [x21, #0x6b6]
0068C4778  mov      x20, x0
0068C477C  cbnz     w8, #0x68c4794
0068C4780  adrp     x0, #0x8f27000
0068C4784  ldr      x0, [x0, #0xc50]
0068C4788  bl       #0x382bd14 ; 
0068C478C  mov      w8, #1
0068C4790  strb     w8, [x21, #0x6b6]
0068C4794  adrp     x8, #0x8f27000
0068C4798  ldr      x8, [x8, #0xc50]
0068C479C  ldr      x2, [x8]
0068C47A0  ldrb     w8, [x2, #0x53]
0068C47A4  tbnz     w8, #5, #0x68c47bc
0068C47A8  add      x0, x19, #0x148
0068C47AC  mov      x1, x20
0068C47B0  str      x20, [x19, #0x148]
0068C47B4  bl       #0x382bcb8 ; 
0068C47B8  b        #0x68c47cc ; 
0068C47BC  ldr      x8, [x2, #0x60]
0068C47C0  mov      x0, x19
0068C47C4  mov      x1, x20
0068C47C8  blr      x8
0068C47CC  mov      x0, x19
0068C47D0  mov      x1, xzr
0068C47D4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068C47D8  adrp     x21, #0x959c000
0068C47DC  ldrb     w8, [x21, #0x6b7]
0068C47E0  mov      x20, x0
0068C47E4  cbnz     w8, #0x68c47fc
0068C47E8  adrp     x0, #0x8f27000
0068C47EC  ldr      x0, [x0, #0xc60]
0068C47F0  bl       #0x382bd14 ; 
0068C47F4  mov      w8, #1
0068C47F8  strb     w8, [x21, #0x6b7]
0068C47FC  adrp     x8, #0x8f27000
0068C4800  ldr      x8, [x8, #0xc60]
0068C4804  ldr      x2, [x8]
0068C4808  ldrb     w8, [x2, #0x53]
0068C480C  tbnz     w8, #5, #0x68c4824
0068C4810  add      x0, x19, #0x150
0068C4814  mov      x1, x20
0068C4818  str      x20, [x19, #0x150]
0068C481C  bl       #0x382bcb8 ; 
0068C4820  b        #0x68c4834 ; 
0068C4824  ldr      x8, [x2, #0x60]
0068C4828  mov      x0, x19
0068C482C  mov      x1, x20
0068C4830  blr      x8
0068C4834  mov      x0, x19
0068C4838  mov      x1, xzr
0068C483C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
0068C4840  adrp     x21, #0x959c000
0068C4844  ldrb     w8, [x21, #0x6b8]
0068C4848  mov      x20, x0
0068C484C  cbnz     w8, #0x68c4864
0068C4850  adrp     x0, #0x8f27000
0068C4854  ldr      x0, [x0, #0xc70]
0068C4858  bl       #0x382bd14 ; 
0068C485C  mov      w8, #1
0068C4860  strb     w8, [x21, #0x6b8]
0068C4864  adrp     x8, #0x8f27000
0068C4868  ldr      x8, [x8, #0xc70]
0068C486C  ldr      x2, [x8]
0068C4870  ldrb     w8, [x2, #0x53]
0068C4874  tbnz     w8, #5, #0x68c488c
0068C4878  add      x0, x19, #0x158
0068C487C  mov      x1, x20
0068C4880  str      x20, [x19, #0x158]
0068C4884  bl       #0x382bcb8 ; 
0068C4888  b        #0x68c489c ; 
0068C488C  ldr      x8, [x2, #0x60]
0068C4890  mov      x0, x19
0068C4894  mov      x1, x20
0068C4898  blr      x8
0068C489C  mov      x0, x19
0068C48A0  mov      x1, xzr
0068C48A4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C48A8  adrp     x21, #0x959c000
0068C48AC  ldrb     w8, [x21, #0x6b9]
0068C48B0  mov      w20, w0
0068C48B4  cbnz     w8, #0x68c48cc
0068C48B8  adrp     x0, #0x8f27000
0068C48BC  ldr      x0, [x0, #0xc80]
0068C48C0  bl       #0x382bd14 ; 
0068C48C4  mov      w8, #1
0068C48C8  strb     w8, [x21, #0x6b9]
0068C48CC  adrp     x8, #0x8f27000
0068C48D0  ldr      x8, [x8, #0xc80]
0068C48D4  ldr      x2, [x8]
0068C48D8  ldrb     w8, [x2, #0x53]
0068C48DC  tbnz     w8, #5, #0x68c48e8
0068C48E0  str      w20, [x19, #0x160]
0068C48E4  b        #0x68c48f8 ; 
0068C48E8  ldr      x8, [x2, #0x60]
0068C48EC  mov      x0, x19
0068C48F0  mov      w1, w20
0068C48F4  blr      x8
0068C48F8  mov      x0, x19
0068C48FC  mov      x1, xzr
0068C4900  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C4904  adrp     x21, #0x959c000
0068C4908  ldrb     w8, [x21, #0x6ba]
0068C490C  mov      w20, w0
0068C4910  cbnz     w8, #0x68c4928
0068C4914  adrp     x0, #0x8f27000
0068C4918  ldr      x0, [x0, #0xc90]
0068C491C  bl       #0x382bd14 ; 
0068C4920  mov      w8, #1
0068C4924  strb     w8, [x21, #0x6ba]
0068C4928  adrp     x8, #0x8f27000
0068C492C  ldr      x8, [x8, #0xc90]
0068C4930  ldr      x2, [x8]
0068C4934  ldrb     w8, [x2, #0x53]
0068C4938  tbnz     w8, #5, #0x68c4944
0068C493C  str      w20, [x19, #0x164]
0068C4940  b        #0x68c4954 ; 
0068C4944  ldr      x8, [x2, #0x60]
0068C4948  mov      x0, x19
0068C494C  mov      w1, w20
0068C4950  blr      x8
0068C4954  mov      x0, x19
0068C4958  mov      x1, xzr
0068C495C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C4960  adrp     x21, #0x959c000
0068C4964  ldrb     w8, [x21, #0x6bb]
0068C4968  mov      x20, x0
0068C496C  cbnz     w8, #0x68c4984
0068C4970  adrp     x0, #0x8f27000
0068C4974  ldr      x0, [x0, #0xca0]
0068C4978  bl       #0x382bd14 ; 
0068C497C  mov      w8, #1
0068C4980  strb     w8, [x21, #0x6bb]
0068C4984  adrp     x8, #0x8f27000
0068C4988  ldr      x8, [x8, #0xca0]
0068C498C  ldr      x2, [x8]
0068C4990  ldrb     w8, [x2, #0x53]
0068C4994  tbnz     w8, #5, #0x68c49ac
0068C4998  add      x0, x19, #0x168
0068C499C  mov      x1, x20
0068C49A0  str      x20, [x19, #0x168]
0068C49A4  bl       #0x382bcb8 ; 
0068C49A8  b        #0x68c49bc ; 
0068C49AC  ldr      x8, [x2, #0x60]
0068C49B0  mov      x0, x19
0068C49B4  mov      x1, x20
0068C49B8  blr      x8
0068C49BC  mov      x0, x19
0068C49C0  mov      x1, xzr
0068C49C4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C49C8  adrp     x21, #0x959c000
0068C49CC  ldrb     w8, [x21, #0x6bc]
0068C49D0  mov      x20, x0
0068C49D4  cbnz     w8, #0x68c49ec
0068C49D8  adrp     x0, #0x8f27000
0068C49DC  ldr      x0, [x0, #0xcb0]
0068C49E0  bl       #0x382bd14 ; 
0068C49E4  mov      w8, #1
0068C49E8  strb     w8, [x21, #0x6bc]
0068C49EC  adrp     x8, #0x8f27000
0068C49F0  ldr      x8, [x8, #0xcb0]
0068C49F4  ldr      x2, [x8]
0068C49F8  ldrb     w8, [x2, #0x53]
0068C49FC  tbnz     w8, #5, #0x68c4a14
0068C4A00  add      x0, x19, #0x170
0068C4A04  mov      x1, x20
0068C4A08  str      x20, [x19, #0x170]
0068C4A0C  bl       #0x382bcb8 ; 
0068C4A10  b        #0x68c4a24 ; 
0068C4A14  ldr      x8, [x2, #0x60]
0068C4A18  mov      x0, x19
0068C4A1C  mov      x1, x20
0068C4A20  blr      x8
0068C4A24  mov      x0, x19
0068C4A28  mov      x1, xzr
0068C4A2C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C4A30  adrp     x21, #0x959c000
0068C4A34  ldrb     w8, [x21, #0x6bd]
0068C4A38  mov      x20, x0
0068C4A3C  cbnz     w8, #0x68c4a54
0068C4A40  adrp     x0, #0x8f27000
0068C4A44  ldr      x0, [x0, #0xcc0]
0068C4A48  bl       #0x382bd14 ; 
0068C4A4C  mov      w8, #1
0068C4A50  strb     w8, [x21, #0x6bd]
0068C4A54  adrp     x8, #0x8f27000
0068C4A58  ldr      x8, [x8, #0xcc0]
0068C4A5C  ldr      x2, [x8]
0068C4A60  ldrb     w8, [x2, #0x53]
0068C4A64  tbnz     w8, #5, #0x68c4a7c
0068C4A68  add      x0, x19, #0x178
0068C4A6C  mov      x1, x20
0068C4A70  str      x20, [x19, #0x178]
0068C4A74  bl       #0x382bcb8 ; 
0068C4A78  b        #0x68c4a8c ; 
0068C4A7C  ldr      x8, [x2, #0x60]
0068C4A80  mov      x0, x19
0068C4A84  mov      x1, x20
0068C4A88  blr      x8
0068C4A8C  mov      x0, x19
0068C4A90  mov      x1, xzr
0068C4A94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C4A98  adrp     x21, #0x959c000
0068C4A9C  ldrb     w8, [x21, #0x6be]
0068C4AA0  mov      w20, w0
0068C4AA4  cbnz     w8, #0x68c4abc
0068C4AA8  adrp     x0, #0x8f27000
0068C4AAC  ldr      x0, [x0, #0xcc8]
0068C4AB0  bl       #0x382bd14 ; 
0068C4AB4  mov      w8, #1
0068C4AB8  strb     w8, [x21, #0x6be]
0068C4ABC  adrp     x8, #0x8f27000
0068C4AC0  ldr      x8, [x8, #0xcc8]
0068C4AC4  ldr      x2, [x8]
0068C4AC8  ldrb     w8, [x2, #0x53]
0068C4ACC  tbnz     w8, #5, #0x68c4ad8
0068C4AD0  str      w20, [x19, #0x180]
0068C4AD4  b        #0x68c4ae8 ; 
0068C4AD8  ldr      x8, [x2, #0x60]
0068C4ADC  mov      x0, x19
0068C4AE0  mov      w1, w20
0068C4AE4  blr      x8
0068C4AE8  mov      x0, x19
0068C4AEC  mov      x1, xzr
0068C4AF0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C4AF4  adrp     x21, #0x959c000
0068C4AF8  ldrb     w8, [x21, #0x6bf]
0068C4AFC  mov      x20, x0
0068C4B00  cbnz     w8, #0x68c4b18
0068C4B04  adrp     x0, #0x8f27000
0068C4B08  ldr      x0, [x0, #0xcd8]
0068C4B0C  bl       #0x382bd14 ; 
0068C4B10  mov      w8, #1
0068C4B14  strb     w8, [x21, #0x6bf]
0068C4B18  adrp     x8, #0x8f27000
0068C4B1C  ldr      x8, [x8, #0xcd8]
0068C4B20  ldr      x2, [x8]
0068C4B24  ldrb     w8, [x2, #0x53]
0068C4B28  tbnz     w8, #5, #0x68c4b40
0068C4B2C  add      x0, x19, #0x188
0068C4B30  mov      x1, x20
0068C4B34  str      x20, [x19, #0x188]
0068C4B38  bl       #0x382bcb8 ; 
0068C4B3C  b        #0x68c4b50 ; 
0068C4B40  ldr      x8, [x2, #0x60]
0068C4B44  mov      x0, x19
0068C4B48  mov      x1, x20
0068C4B4C  blr      x8
0068C4B50  mov      x0, x19
0068C4B54  mov      x1, xzr
0068C4B58  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C4B5C  adrp     x21, #0x959c000
0068C4B60  ldrb     w8, [x21, #0x6c0]
0068C4B64  mov      x20, x0
0068C4B68  cbnz     w8, #0x68c4b80
0068C4B6C  adrp     x0, #0x8f27000
0068C4B70  ldr      x0, [x0, #0xce8]
0068C4B74  bl       #0x382bd14 ; 
0068C4B78  mov      w8, #1
0068C4B7C  strb     w8, [x21, #0x6c0]
0068C4B80  adrp     x8, #0x8f27000
0068C4B84  ldr      x8, [x8, #0xce8]
0068C4B88  ldr      x2, [x8]
0068C4B8C  ldrb     w8, [x2, #0x53]
0068C4B90  tbnz     w8, #5, #0x68c4b9c
0068C4B94  str      x20, [x19, #0x190]
0068C4B98  b        #0x68c4bac ; 
0068C4B9C  ldr      x8, [x2, #0x60]
0068C4BA0  mov      x0, x19
0068C4BA4  mov      x1, x20
0068C4BA8  blr      x8
0068C4BAC  mov      x0, x19
0068C4BB0  mov      x1, xzr
0068C4BB4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C4BB8  adrp     x21, #0x959c000
0068C4BBC  ldrb     w8, [x21, #0x6c1]
0068C4BC0  mov      x20, x0
0068C4BC4  cbnz     w8, #0x68c4bdc
0068C4BC8  adrp     x0, #0x8f27000
0068C4BCC  ldr      x0, [x0, #0xcf8]
0068C4BD0  bl       #0x382bd14 ; 
0068C4BD4  mov      w8, #1
0068C4BD8  strb     w8, [x21, #0x6c1]
0068C4BDC  adrp     x8, #0x8f27000
0068C4BE0  ldr      x8, [x8, #0xcf8]
0068C4BE4  ldr      x2, [x8]
0068C4BE8  ldrb     w8, [x2, #0x53]
0068C4BEC  tbnz     w8, #5, #0x68c4bf8
0068C4BF0  str      x20, [x19, #0x198]
0068C4BF4  b        #0x68c4c08 ; 
0068C4BF8  ldr      x8, [x2, #0x60]
0068C4BFC  mov      x0, x19
0068C4C00  mov      x1, x20
0068C4C04  blr      x8
0068C4C08  mov      x0, x19
0068C4C0C  mov      x1, xzr
0068C4C10  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068C4C14  adrp     x20, #0x959c000
0068C4C18  ldrb     w8, [x20, #0x6c2]
0068C4C1C  mov      v8.16b, v0.16b
0068C4C20  cbnz     w8, #0x68c4c38
0068C4C24  adrp     x0, #0x8f27000
0068C4C28  ldr      x0, [x0, #0xd08]
0068C4C2C  bl       #0x382bd14 ; 
0068C4C30  mov      w8, #1
0068C4C34  strb     w8, [x20, #0x6c2]
0068C4C38  adrp     x8, #0x8f27000
0068C4C3C  ldr      x8, [x8, #0xd08]
0068C4C40  ldr      x1, [x8]
0068C4C44  ldrb     w8, [x1, #0x53]
0068C4C48  tbnz     w8, #5, #0x68c4c54
0068C4C4C  str      s8, [x19, #0x1a0]
0068C4C50  b        #0x68c4c64 ; 
0068C4C54  ldr      x8, [x1, #0x60]
0068C4C58  mov      x0, x19
0068C4C5C  mov      v0.16b, v8.16b
0068C4C60  blr      x8
0068C4C64  mov      x0, x19
0068C4C68  mov      x1, xzr
0068C4C6C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C4C70  adrp     x21, #0x959c000
0068C4C74  ldrb     w8, [x21, #0x6c3]
0068C4C78  mov      w20, w0
0068C4C7C  cbnz     w8, #0x68c4c94
0068C4C80  adrp     x0, #0x8f27000
0068C4C84  ldr      x0, [x0, #0xd18]
0068C4C88  bl       #0x382bd14 ; 
0068C4C8C  mov      w8, #1
0068C4C90  strb     w8, [x21, #0x6c3]
0068C4C94  adrp     x8, #0x8f27000
0068C4C98  ldr      x8, [x8, #0xd18]
0068C4C9C  ldr      x2, [x8]
0068C4CA0  ldrb     w8, [x2, #0x53]
0068C4CA4  tbnz     w8, #5, #0x68c4cb0
0068C4CA8  str      w20, [x19, #0x1a4]
0068C4CAC  b        #0x68c4cc0 ; 
0068C4CB0  ldr      x8, [x2, #0x60]
0068C4CB4  mov      x0, x19
0068C4CB8  mov      w1, w20
0068C4CBC  blr      x8
0068C4CC0  mov      x0, x19
0068C4CC4  mov      x1, xzr
0068C4CC8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C4CCC  adrp     x21, #0x959c000
0068C4CD0  ldrb     w8, [x21, #0x6c4]
0068C4CD4  mov      w20, w0
0068C4CD8  cbnz     w8, #0x68c4cf0
0068C4CDC  adrp     x0, #0x8f27000
0068C4CE0  ldr      x0, [x0, #0xd28]
0068C4CE4  bl       #0x382bd14 ; 
0068C4CE8  mov      w8, #1
0068C4CEC  strb     w8, [x21, #0x6c4]
0068C4CF0  adrp     x8, #0x8f27000
0068C4CF4  ldr      x8, [x8, #0xd28]
0068C4CF8  ldr      x2, [x8]
0068C4CFC  ldrb     w8, [x2, #0x53]
0068C4D00  tbnz     w8, #5, #0x68c4d0c
0068C4D04  str      w20, [x19, #0x1a8]
0068C4D08  b        #0x68c4d1c ; 
0068C4D0C  ldr      x8, [x2, #0x60]
0068C4D10  mov      x0, x19
0068C4D14  mov      w1, w20
0068C4D18  blr      x8
0068C4D1C  mov      x0, x19
0068C4D20  mov      x1, xzr
0068C4D24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C4D28  adrp     x21, #0x959c000
0068C4D2C  ldrb     w8, [x21, #0x6c5]
0068C4D30  mov      w20, w0
0068C4D34  cbnz     w8, #0x68c4d4c
0068C4D38  adrp     x0, #0x8f27000
0068C4D3C  ldr      x0, [x0, #0xd30]
0068C4D40  bl       #0x382bd14 ; 
0068C4D44  mov      w8, #1
0068C4D48  strb     w8, [x21, #0x6c5]
0068C4D4C  adrp     x8, #0x8f27000
0068C4D50  ldr      x8, [x8, #0xd30]
0068C4D54  ldr      x2, [x8]
0068C4D58  ldrb     w8, [x2, #0x53]
0068C4D5C  tbnz     w8, #5, #0x68c4d68
0068C4D60  str      w20, [x19, #0x1ac]
0068C4D64  b        #0x68c4d78 ; 
0068C4D68  ldr      x8, [x2, #0x60]
0068C4D6C  mov      x0, x19
0068C4D70  mov      w1, w20
0068C4D74  blr      x8
0068C4D78  mov      x0, x19
0068C4D7C  mov      x1, xzr
0068C4D80  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C4D84  adrp     x21, #0x959c000
0068C4D88  ldrb     w8, [x21, #0x6c6]
0068C4D8C  mov      x20, x0
0068C4D90  cbnz     w8, #0x68c4da8
0068C4D94  adrp     x0, #0x8f27000
0068C4D98  ldr      x0, [x0, #0xd40]
0068C4D9C  bl       #0x382bd14 ; 
0068C4DA0  mov      w8, #1
0068C4DA4  strb     w8, [x21, #0x6c6]
0068C4DA8  adrp     x8, #0x8f27000
0068C4DAC  ldr      x8, [x8, #0xd40]
0068C4DB0  ldr      x2, [x8]
0068C4DB4  ldrb     w8, [x2, #0x53]
0068C4DB8  tbnz     w8, #5, #0x68c4dc4
0068C4DBC  str      x20, [x19, #0x1b0]
0068C4DC0  b        #0x68c4dd4 ; 
0068C4DC4  ldr      x8, [x2, #0x60]
0068C4DC8  mov      x0, x19
0068C4DCC  mov      x1, x20
0068C4DD0  blr      x8
0068C4DD4  mov      x0, x19
0068C4DD8  mov      x1, xzr
0068C4DDC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C4DE0  adrp     x21, #0x959c000
0068C4DE4  ldrb     w8, [x21, #0x6c7]
0068C4DE8  mov      x20, x0
0068C4DEC  cbnz     w8, #0x68c4e04
0068C4DF0  adrp     x0, #0x8f27000
0068C4DF4  ldr      x0, [x0, #0xd50]
0068C4DF8  bl       #0x382bd14 ; 
0068C4DFC  mov      w8, #1
0068C4E00  strb     w8, [x21, #0x6c7]
0068C4E04  adrp     x8, #0x8f27000
0068C4E08  ldr      x8, [x8, #0xd50]
0068C4E0C  ldr      x2, [x8]
0068C4E10  ldrb     w8, [x2, #0x53]
0068C4E14  tbnz     w8, #5, #0x68c4e20
0068C4E18  str      x20, [x19, #0x1b8]
0068C4E1C  b        #0x68c4e30 ; 
0068C4E20  ldr      x8, [x2, #0x60]
0068C4E24  mov      x0, x19
0068C4E28  mov      x1, x20
0068C4E2C  blr      x8
0068C4E30  mov      x0, x19
0068C4E34  mov      x1, xzr
0068C4E38  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C4E3C  adrp     x21, #0x959c000
0068C4E40  ldrb     w8, [x21, #0x6c8]
0068C4E44  mov      w20, w0
0068C4E48  cbnz     w8, #0x68c4e60
0068C4E4C  adrp     x0, #0x8f27000
0068C4E50  ldr      x0, [x0, #0xd58]
0068C4E54  bl       #0x382bd14 ; 
0068C4E58  mov      w8, #1
0068C4E5C  strb     w8, [x21, #0x6c8]
0068C4E60  adrp     x8, #0x8f27000
0068C4E64  ldr      x8, [x8, #0xd58]
0068C4E68  ldr      x2, [x8]
0068C4E6C  ldrb     w8, [x2, #0x53]
0068C4E70  tbnz     w8, #5, #0x68c4e7c
0068C4E74  str      w20, [x19, #0x1c0]
0068C4E78  b        #0x68c4e8c ; 
0068C4E7C  ldr      x8, [x2, #0x60]
0068C4E80  mov      x0, x19
0068C4E84  mov      w1, w20
0068C4E88  blr      x8
0068C4E8C  mov      x0, x19
0068C4E90  mov      x1, xzr
0068C4E94  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C4E98  adrp     x21, #0x959c000
0068C4E9C  ldrb     w8, [x21, #0x6c9]
0068C4EA0  mov      x20, x0
0068C4EA4  cbnz     w8, #0x68c4ebc
0068C4EA8  adrp     x0, #0x8f27000
0068C4EAC  ldr      x0, [x0, #0xd68]
0068C4EB0  bl       #0x382bd14 ; 
0068C4EB4  mov      w8, #1
0068C4EB8  strb     w8, [x21, #0x6c9]
0068C4EBC  adrp     x8, #0x8f27000
0068C4EC0  ldr      x8, [x8, #0xd68]
0068C4EC4  ldr      x2, [x8]
0068C4EC8  ldrb     w8, [x2, #0x53]
0068C4ECC  tbnz     w8, #5, #0x68c4ee4
0068C4ED0  add      x0, x19, #0x1c8
0068C4ED4  mov      x1, x20
0068C4ED8  str      x20, [x19, #0x1c8]
0068C4EDC  bl       #0x382bcb8 ; 
0068C4EE0  b        #0x68c4ef4 ; 
0068C4EE4  ldr      x8, [x2, #0x60]
0068C4EE8  mov      x0, x19
0068C4EEC  mov      x1, x20
0068C4EF0  blr      x8
0068C4EF4  mov      x0, x19
0068C4EF8  mov      x1, xzr
0068C4EFC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C4F00  adrp     x21, #0x959c000
0068C4F04  ldrb     w8, [x21, #0x6ca]
0068C4F08  mov      x20, x0
0068C4F0C  cbnz     w8, #0x68c4f24
0068C4F10  adrp     x0, #0x8f27000
0068C4F14  ldr      x0, [x0, #0xd78]
0068C4F18  bl       #0x382bd14 ; 
0068C4F1C  mov      w8, #1
0068C4F20  strb     w8, [x21, #0x6ca]
0068C4F24  adrp     x8, #0x8f27000
0068C4F28  ldr      x8, [x8, #0xd78]
0068C4F2C  ldr      x2, [x8]
0068C4F30  ldrb     w8, [x2, #0x53]
0068C4F34  tbnz     w8, #5, #0x68c4f4c
0068C4F38  add      x0, x19, #0x1d0
0068C4F3C  mov      x1, x20
0068C4F40  str      x20, [x19, #0x1d0]
0068C4F44  bl       #0x382bcb8 ; 
0068C4F48  b        #0x68c4f5c ; 
0068C4F4C  ldr      x8, [x2, #0x60]
0068C4F50  mov      x0, x19
0068C4F54  mov      x1, x20
0068C4F58  blr      x8
0068C4F5C  mov      x0, x19
0068C4F60  mov      x1, xzr
0068C4F64  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C4F68  adrp     x21, #0x959c000
0068C4F6C  ldrb     w8, [x21, #0x6cb]
0068C4F70  mov      x20, x0
0068C4F74  cbnz     w8, #0x68c4f8c
0068C4F78  adrp     x0, #0x8f27000
0068C4F7C  ldr      x0, [x0, #0xd80]
0068C4F80  bl       #0x382bd14 ; 
0068C4F84  mov      w8, #1
0068C4F88  strb     w8, [x21, #0x6cb]
0068C4F8C  adrp     x8, #0x8f27000
0068C4F90  ldr      x8, [x8, #0xd80]
0068C4F94  ldr      x2, [x8]
0068C4F98  ldrb     w8, [x2, #0x53]
0068C4F9C  tbnz     w8, #5, #0x68c4fb4
0068C4FA0  add      x0, x19, #0x1d8
0068C4FA4  mov      x1, x20
0068C4FA8  str      x20, [x19, #0x1d8]
0068C4FAC  bl       #0x382bcb8 ; 
0068C4FB0  b        #0x68c4fc4 ; 
0068C4FB4  ldr      x8, [x2, #0x60]
0068C4FB8  mov      x0, x19
0068C4FBC  mov      x1, x20
0068C4FC0  blr      x8
0068C4FC4  mov      x0, x19
0068C4FC8  mov      x1, xzr
0068C4FCC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C4FD0  adrp     x21, #0x959c000
0068C4FD4  ldrb     w8, [x21, #0x6cc]
0068C4FD8  mov      x20, x0
0068C4FDC  cbnz     w8, #0x68c4ff4
0068C4FE0  adrp     x0, #0x8f27000
0068C4FE4  ldr      x0, [x0, #0xd90]
0068C4FE8  bl       #0x382bd14 ; 
0068C4FEC  mov      w8, #1
0068C4FF0  strb     w8, [x21, #0x6cc]
0068C4FF4  adrp     x8, #0x8f27000
0068C4FF8  ldr      x8, [x8, #0xd90]
0068C4FFC  ldr      x2, [x8]
0068C5000  ldrb     w8, [x2, #0x53]
0068C5004  tbnz     w8, #5, #0x68c501c
0068C5008  add      x0, x19, #0x1e0
0068C500C  mov      x1, x20
0068C5010  str      x20, [x19, #0x1e0]
0068C5014  bl       #0x382bcb8 ; 
0068C5018  b        #0x68c502c ; 
0068C501C  ldr      x8, [x2, #0x60]
0068C5020  mov      x0, x19
0068C5024  mov      x1, x20
0068C5028  blr      x8
0068C502C  mov      x0, x19
0068C5030  mov      x1, xzr
0068C5034  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C5038  adrp     x21, #0x959c000
0068C503C  ldrb     w8, [x21, #0x6cd]
0068C5040  mov      w20, w0
0068C5044  cbnz     w8, #0x68c505c
0068C5048  adrp     x0, #0x8f27000
0068C504C  ldr      x0, [x0, #0xd98]
0068C5050  bl       #0x382bd14 ; 
0068C5054  mov      w8, #1
0068C5058  strb     w8, [x21, #0x6cd]
0068C505C  adrp     x8, #0x8f27000
0068C5060  ldr      x8, [x8, #0xd98]
0068C5064  ldr      x2, [x8]
0068C5068  ldrb     w8, [x2, #0x53]
0068C506C  tbnz     w8, #5, #0x68c5078
0068C5070  str      w20, [x19, #0x1e8]
0068C5074  b        #0x68c5088 ; 
0068C5078  ldr      x8, [x2, #0x60]
0068C507C  mov      x0, x19
0068C5080  mov      w1, w20
0068C5084  blr      x8
0068C5088  mov      x0, x19
0068C508C  mov      x1, xzr
0068C5090  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C5094  adrp     x21, #0x959c000
0068C5098  ldrb     w8, [x21, #0x6ce]
0068C509C  mov      w20, w0
0068C50A0  cbnz     w8, #0x68c50b8
0068C50A4  adrp     x0, #0x8f27000
0068C50A8  ldr      x0, [x0, #0xda0]
0068C50AC  bl       #0x382bd14 ; 
0068C50B0  mov      w8, #1
0068C50B4  strb     w8, [x21, #0x6ce]
0068C50B8  adrp     x8, #0x8f27000
0068C50BC  ldr      x8, [x8, #0xda0]
0068C50C0  ldr      x2, [x8]
0068C50C4  ldrb     w8, [x2, #0x53]
0068C50C8  tbnz     w8, #5, #0x68c50d4
0068C50CC  str      w20, [x19, #0x1ec]
0068C50D0  b        #0x68c50e4 ; 
0068C50D4  ldr      x8, [x2, #0x60]
0068C50D8  mov      x0, x19
0068C50DC  mov      w1, w20
0068C50E0  blr      x8
0068C50E4  mov      x0, x19
0068C50E8  mov      x1, xzr
0068C50EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C50F0  adrp     x21, #0x959c000
0068C50F4  ldrb     w8, [x21, #0x6cf]
0068C50F8  mov      w20, w0
0068C50FC  cbnz     w8, #0x68c5114
0068C5100  adrp     x0, #0x8f27000
0068C5104  ldr      x0, [x0, #0xda8]
0068C5108  bl       #0x382bd14 ; 
0068C510C  mov      w8, #1
0068C5110  strb     w8, [x21, #0x6cf]
0068C5114  adrp     x8, #0x8f27000
0068C5118  ldr      x8, [x8, #0xda8]
0068C511C  ldr      x2, [x8]
0068C5120  ldrb     w8, [x2, #0x53]
0068C5124  tbnz     w8, #5, #0x68c5130
0068C5128  str      w20, [x19, #0x1f0]
0068C512C  b        #0x68c5140 ; 
0068C5130  ldr      x8, [x2, #0x60]
0068C5134  mov      x0, x19
0068C5138  mov      w1, w20
0068C513C  blr      x8
0068C5140  mov      x0, x19
0068C5144  mov      x1, xzr
0068C5148  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C514C  adrp     x21, #0x959c000
0068C5150  ldrb     w8, [x21, #0x6d0]
0068C5154  mov      x20, x0
0068C5158  cbnz     w8, #0x68c5170
0068C515C  adrp     x0, #0x8f27000
0068C5160  ldr      x0, [x0, #0xdb0]
0068C5164  bl       #0x382bd14 ; 
0068C5168  mov      w8, #1
0068C516C  strb     w8, [x21, #0x6d0]
0068C5170  adrp     x8, #0x8f27000
0068C5174  ldr      x8, [x8, #0xdb0]
0068C5178  ldr      x2, [x8]
0068C517C  ldrb     w8, [x2, #0x53]
0068C5180  tbnz     w8, #5, #0x68c5198
0068C5184  add      x0, x19, #0x1f8
0068C5188  mov      x1, x20
0068C518C  str      x20, [x19, #0x1f8]
0068C5190  bl       #0x382bcb8 ; 
0068C5194  b        #0x68c51a8 ; 
0068C5198  ldr      x8, [x2, #0x60]
0068C519C  mov      x0, x19
0068C51A0  mov      x1, x20
0068C51A4  blr      x8
0068C51A8  mov      x0, x19
0068C51AC  mov      x1, xzr
0068C51B0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C51B4  adrp     x21, #0x959c000
0068C51B8  ldrb     w8, [x21, #0x6d1]
0068C51BC  mov      x20, x0
0068C51C0  cbnz     w8, #0x68c51d8
0068C51C4  adrp     x0, #0x8f27000
0068C51C8  ldr      x0, [x0, #0xdc0]
0068C51CC  bl       #0x382bd14 ; 
0068C51D0  mov      w8, #1
0068C51D4  strb     w8, [x21, #0x6d1]
0068C51D8  adrp     x8, #0x8f27000
0068C51DC  ldr      x8, [x8, #0xdc0]
0068C51E0  ldr      x2, [x8]
0068C51E4  ldrb     w8, [x2, #0x53]
0068C51E8  tbnz     w8, #5, #0x68c5200
0068C51EC  add      x0, x19, #0x200
0068C51F0  mov      x1, x20
0068C51F4  str      x20, [x19, #0x200]
0068C51F8  bl       #0x382bcb8 ; 
0068C51FC  b        #0x68c5210 ; 
0068C5200  ldr      x8, [x2, #0x60]
0068C5204  mov      x0, x19
0068C5208  mov      x1, x20
0068C520C  blr      x8
0068C5210  mov      x0, x19
0068C5214  mov      x1, xzr
0068C5218  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C521C  adrp     x21, #0x959c000
0068C5220  ldrb     w8, [x21, #0x6d2]
0068C5224  mov      x20, x0
0068C5228  cbnz     w8, #0x68c5240
0068C522C  adrp     x0, #0x8f27000
0068C5230  ldr      x0, [x0, #0xdd0]
0068C5234  bl       #0x382bd14 ; 
0068C5238  mov      w8, #1
0068C523C  strb     w8, [x21, #0x6d2]
0068C5240  adrp     x8, #0x8f27000
0068C5244  ldr      x8, [x8, #0xdd0]
0068C5248  ldr      x2, [x8]
0068C524C  ldrb     w8, [x2, #0x53]
0068C5250  tbnz     w8, #5, #0x68c5268
0068C5254  add      x0, x19, #0x208
0068C5258  mov      x1, x20
0068C525C  str      x20, [x19, #0x208]
0068C5260  bl       #0x382bcb8 ; 
0068C5264  b        #0x68c5278 ; 
0068C5268  ldr      x8, [x2, #0x60]
0068C526C  mov      x0, x19
0068C5270  mov      x1, x20
0068C5274  blr      x8
0068C5278  mov      x0, x19
0068C527C  mov      x1, xzr
0068C5280  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C5284  adrp     x21, #0x959c000
0068C5288  ldrb     w8, [x21, #0x6d3]
0068C528C  mov      x20, x0
0068C5290  cbnz     w8, #0x68c52a8
0068C5294  adrp     x0, #0x8f27000
0068C5298  ldr      x0, [x0, #0xde0]
0068C529C  bl       #0x382bd14 ; 
0068C52A0  mov      w8, #1
0068C52A4  strb     w8, [x21, #0x6d3]
0068C52A8  adrp     x8, #0x8f27000
0068C52AC  ldr      x8, [x8, #0xde0]
0068C52B0  ldr      x2, [x8]
0068C52B4  ldrb     w8, [x2, #0x53]
0068C52B8  tbnz     w8, #5, #0x68c52d0
0068C52BC  add      x0, x19, #0x210
0068C52C0  mov      x1, x20
0068C52C4  str      x20, [x19, #0x210]
0068C52C8  bl       #0x382bcb8 ; 
0068C52CC  b        #0x68c52e0 ; 
0068C52D0  ldr      x8, [x2, #0x60]
0068C52D4  mov      x0, x19
0068C52D8  mov      x1, x20
0068C52DC  blr      x8
0068C52E0  mov      x0, x19
0068C52E4  mov      x1, xzr
0068C52E8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C52EC  adrp     x21, #0x959c000
0068C52F0  ldrb     w8, [x21, #0x6d4]
0068C52F4  mov      x20, x0
0068C52F8  cbnz     w8, #0x68c5310
0068C52FC  adrp     x0, #0x8f27000
0068C5300  ldr      x0, [x0, #0xdf0]
0068C5304  bl       #0x382bd14 ; 
0068C5308  mov      w8, #1
0068C530C  strb     w8, [x21, #0x6d4]
0068C5310  adrp     x8, #0x8f27000
0068C5314  ldr      x8, [x8, #0xdf0]
0068C5318  ldr      x2, [x8]
0068C531C  ldrb     w8, [x2, #0x53]
0068C5320  tbnz     w8, #5, #0x68c5338
0068C5324  add      x0, x19, #0x218
0068C5328  mov      x1, x20
0068C532C  str      x20, [x19, #0x218]
0068C5330  bl       #0x382bcb8 ; 
0068C5334  b        #0x68c5348 ; 
0068C5338  ldr      x8, [x2, #0x60]
0068C533C  mov      x0, x19
0068C5340  mov      x1, x20
0068C5344  blr      x8
0068C5348  mov      x0, x19
0068C534C  mov      x1, xzr
0068C5350  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C5354  adrp     x21, #0x959c000
0068C5358  ldrb     w8, [x21, #0x6d5]
0068C535C  mov      x20, x0
0068C5360  cbnz     w8, #0x68c5378
0068C5364  adrp     x0, #0x8f27000
0068C5368  ldr      x0, [x0, #0xdf8]
0068C536C  bl       #0x382bd14 ; 
0068C5370  mov      w8, #1
0068C5374  strb     w8, [x21, #0x6d5]
0068C5378  adrp     x8, #0x8f27000
0068C537C  ldr      x8, [x8, #0xdf8]
0068C5380  ldr      x2, [x8]
0068C5384  ldrb     w8, [x2, #0x53]
0068C5388  tbnz     w8, #5, #0x68c5394
0068C538C  str      x20, [x19, #0x220]
0068C5390  b        #0x68c53a4 ; 
0068C5394  ldr      x8, [x2, #0x60]
0068C5398  mov      x0, x19
0068C539C  mov      x1, x20
0068C53A0  blr      x8
0068C53A4  mov      x0, x19
0068C53A8  mov      x1, xzr
0068C53AC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C53B0  adrp     x21, #0x959c000
0068C53B4  ldrb     w8, [x21, #0x6d6]
0068C53B8  mov      x20, x0
0068C53BC  cbnz     w8, #0x68c53d4
0068C53C0  adrp     x0, #0x8f27000
0068C53C4  ldr      x0, [x0, #0xe00]
0068C53C8  bl       #0x382bd14 ; 
0068C53CC  mov      w8, #1
0068C53D0  strb     w8, [x21, #0x6d6]
0068C53D4  adrp     x8, #0x8f27000
0068C53D8  ldr      x8, [x8, #0xe00]
0068C53DC  ldr      x2, [x8]
0068C53E0  ldrb     w8, [x2, #0x53]
0068C53E4  tbnz     w8, #5, #0x68c53f0
0068C53E8  str      x20, [x19, #0x228]
0068C53EC  b        #0x68c5400 ; 
0068C53F0  ldr      x8, [x2, #0x60]
0068C53F4  mov      x0, x19
0068C53F8  mov      x1, x20
0068C53FC  blr      x8
0068C5400  mov      x0, x19
0068C5404  mov      x1, xzr
0068C5408  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C540C  adrp     x21, #0x959c000
0068C5410  ldrb     w8, [x21, #0x6d7]
0068C5414  mov      x20, x0
0068C5418  cbnz     w8, #0x68c5430
0068C541C  adrp     x0, #0x8f27000
0068C5420  ldr      x0, [x0, #0xe08]
0068C5424  bl       #0x382bd14 ; 
0068C5428  mov      w8, #1
0068C542C  strb     w8, [x21, #0x6d7]
0068C5430  adrp     x8, #0x8f27000
0068C5434  ldr      x8, [x8, #0xe08]
0068C5438  ldr      x2, [x8]
0068C543C  ldrb     w8, [x2, #0x53]
0068C5440  tbnz     w8, #5, #0x68c544c
0068C5444  str      x20, [x19, #0x230]
0068C5448  b        #0x68c545c ; 
0068C544C  ldr      x8, [x2, #0x60]
0068C5450  mov      x0, x19
0068C5454  mov      x1, x20
0068C5458  blr      x8
0068C545C  mov      x0, x19
0068C5460  mov      x1, xzr
0068C5464  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C5468  adrp     x21, #0x959c000
0068C546C  ldrb     w8, [x21, #0x6d8]
0068C5470  mov      x20, x0
0068C5474  cbnz     w8, #0x68c548c
0068C5478  adrp     x0, #0x8f27000
0068C547C  ldr      x0, [x0, #0xe10]
0068C5480  bl       #0x382bd14 ; 
0068C5484  mov      w8, #1
0068C5488  strb     w8, [x21, #0x6d8]
0068C548C  adrp     x8, #0x8f27000
0068C5490  ldr      x8, [x8, #0xe10]
0068C5494  ldr      x2, [x8]
0068C5498  ldrb     w8, [x2, #0x53]
0068C549C  tbnz     w8, #5, #0x68c54a8
0068C54A0  str      x20, [x19, #0x238]
0068C54A4  b        #0x68c54b8 ; 
0068C54A8  ldr      x8, [x2, #0x60]
0068C54AC  mov      x0, x19
0068C54B0  mov      x1, x20
0068C54B4  blr      x8
0068C54B8  mov      x0, x19
0068C54BC  mov      x1, xzr
0068C54C0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C54C4  adrp     x21, #0x959c000
0068C54C8  ldrb     w8, [x21, #0x6d9]
0068C54CC  mov      w20, w0
0068C54D0  cbnz     w8, #0x68c54e8
0068C54D4  adrp     x0, #0x8f27000
0068C54D8  ldr      x0, [x0, #0xe18]
0068C54DC  bl       #0x382bd14 ; 
0068C54E0  mov      w8, #1
0068C54E4  strb     w8, [x21, #0x6d9]
0068C54E8  adrp     x8, #0x8f27000
0068C54EC  ldr      x8, [x8, #0xe18]
0068C54F0  ldr      x2, [x8]
0068C54F4  ldrb     w8, [x2, #0x53]
0068C54F8  tbnz     w8, #5, #0x68c5504
0068C54FC  str      w20, [x19, #0x240]
0068C5500  b        #0x68c5514 ; 
0068C5504  ldr      x8, [x2, #0x60]
0068C5508  mov      x0, x19
0068C550C  mov      w1, w20
0068C5510  blr      x8
0068C5514  mov      x0, x19
0068C5518  mov      x1, xzr
0068C551C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C5520  adrp     x21, #0x959c000
0068C5524  ldrb     w8, [x21, #0x6da]
0068C5528  mov      w20, w0
0068C552C  cbnz     w8, #0x68c5544
0068C5530  adrp     x0, #0x8f27000
0068C5534  ldr      x0, [x0, #0xe20]
0068C5538  bl       #0x382bd14 ; 
0068C553C  mov      w8, #1
0068C5540  strb     w8, [x21, #0x6da]
0068C5544  adrp     x8, #0x8f27000
0068C5548  ldr      x8, [x8, #0xe20]
0068C554C  ldr      x2, [x8]
0068C5550  ldrb     w8, [x2, #0x53]
0068C5554  tbnz     w8, #5, #0x68c5560
0068C5558  str      w20, [x19, #0x244]
0068C555C  b        #0x68c5570 ; 
0068C5560  ldr      x8, [x2, #0x60]
0068C5564  mov      x0, x19
0068C5568  mov      w1, w20
0068C556C  blr      x8
0068C5570  mov      x0, x19
0068C5574  mov      x1, xzr
0068C5578  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C557C  adrp     x21, #0x959c000
0068C5580  ldrb     w8, [x21, #0x6db]
0068C5584  mov      w20, w0
0068C5588  cbnz     w8, #0x68c55a0
0068C558C  adrp     x0, #0x8f27000
0068C5590  ldr      x0, [x0, #0xe28]
0068C5594  bl       #0x382bd14 ; 
0068C5598  mov      w8, #1
0068C559C  strb     w8, [x21, #0x6db]
0068C55A0  adrp     x8, #0x8f27000
0068C55A4  ldr      x8, [x8, #0xe28]
0068C55A8  ldr      x2, [x8]
0068C55AC  ldrb     w8, [x2, #0x53]
0068C55B0  tbnz     w8, #5, #0x68c55bc
0068C55B4  str      w20, [x19, #0x248]
0068C55B8  b        #0x68c55cc ; 
0068C55BC  ldr      x8, [x2, #0x60]
0068C55C0  mov      x0, x19
0068C55C4  mov      w1, w20
0068C55C8  blr      x8
0068C55CC  mov      x0, x19
0068C55D0  mov      x1, xzr
0068C55D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C55D8  adrp     x21, #0x959c000
0068C55DC  ldrb     w8, [x21, #0x6dc]
0068C55E0  mov      w20, w0
0068C55E4  cbnz     w8, #0x68c55fc
0068C55E8  adrp     x0, #0x8f27000
0068C55EC  ldr      x0, [x0, #0xe30]
0068C55F0  bl       #0x382bd14 ; 
0068C55F4  mov      w8, #1
0068C55F8  strb     w8, [x21, #0x6dc]
0068C55FC  adrp     x8, #0x8f27000
0068C5600  ldr      x8, [x8, #0xe30]
0068C5604  ldr      x2, [x8]
0068C5608  ldrb     w8, [x2, #0x53]
0068C560C  tbnz     w8, #5, #0x68c5618
0068C5610  str      w20, [x19, #0x24c]
0068C5614  b        #0x68c5628 ; 
0068C5618  ldr      x8, [x2, #0x60]
0068C561C  mov      x0, x19
0068C5620  mov      w1, w20
0068C5624  blr      x8
0068C5628  mov      x0, x19
0068C562C  mov      x1, xzr
0068C5630  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C5634  adrp     x21, #0x959c000
0068C5638  ldrb     w8, [x21, #0x6dd]
0068C563C  mov      w20, w0
0068C5640  cbnz     w8, #0x68c5658
0068C5644  adrp     x0, #0x8f27000
0068C5648  ldr      x0, [x0, #0xe40]
0068C564C  bl       #0x382bd14 ; 
0068C5650  mov      w8, #1
0068C5654  strb     w8, [x21, #0x6dd]
0068C5658  adrp     x8, #0x8f27000
0068C565C  ldr      x8, [x8, #0xe40]
0068C5660  ldr      x2, [x8]
0068C5664  ldrb     w8, [x2, #0x53]
0068C5668  tbnz     w8, #5, #0x68c5674
0068C566C  str      w20, [x19, #0x250]
0068C5670  b        #0x68c5684 ; 
0068C5674  ldr      x8, [x2, #0x60]
0068C5678  mov      x0, x19
0068C567C  mov      w1, w20
0068C5680  blr      x8
0068C5684  mov      x0, x19
0068C5688  mov      x1, xzr
0068C568C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C5690  adrp     x21, #0x959c000
0068C5694  ldrb     w8, [x21, #0x6de]
0068C5698  mov      w20, w0
0068C569C  cbnz     w8, #0x68c56b4
0068C56A0  adrp     x0, #0x8f27000
0068C56A4  ldr      x0, [x0, #0xe50]
0068C56A8  bl       #0x382bd14 ; 
0068C56AC  mov      w8, #1
0068C56B0  strb     w8, [x21, #0x6de]
0068C56B4  adrp     x8, #0x8f27000
0068C56B8  ldr      x8, [x8, #0xe50]
0068C56BC  ldr      x2, [x8]
0068C56C0  ldrb     w8, [x2, #0x53]
0068C56C4  tbnz     w8, #5, #0x68c56d0
0068C56C8  str      w20, [x19, #0x254]
0068C56CC  b        #0x68c56e0 ; 
0068C56D0  ldr      x8, [x2, #0x60]
0068C56D4  mov      x0, x19
0068C56D8  mov      w1, w20
0068C56DC  blr      x8
0068C56E0  mov      x0, x19
0068C56E4  mov      x1, xzr
0068C56E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C56EC  adrp     x21, #0x959c000
0068C56F0  ldrb     w8, [x21, #0x6df]
0068C56F4  mov      w20, w0
0068C56F8  cbnz     w8, #0x68c5710
0068C56FC  adrp     x0, #0x8f27000
0068C5700  ldr      x0, [x0, #0xe60]
0068C5704  bl       #0x382bd14 ; 
0068C5708  mov      w8, #1
0068C570C  strb     w8, [x21, #0x6df]
0068C5710  adrp     x8, #0x8f27000
0068C5714  ldr      x8, [x8, #0xe60]
0068C5718  ldr      x2, [x8]
0068C571C  ldrb     w8, [x2, #0x53]
0068C5720  tbnz     w8, #5, #0x68c572c
0068C5724  str      w20, [x19, #0x258]
0068C5728  b        #0x68c573c ; 
0068C572C  ldr      x8, [x2, #0x60]
0068C5730  mov      x0, x19
0068C5734  mov      w1, w20
0068C5738  blr      x8
0068C573C  mov      x0, x19
0068C5740  mov      x1, xzr
0068C5744  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
0068C5748  adrp     x20, #0x959c000
0068C574C  ldrb     w8, [x20, #0x6e0]
0068C5750  mov      v8.16b, v0.16b
0068C5754  cbnz     w8, #0x68c576c
0068C5758  adrp     x0, #0x8f27000
0068C575C  ldr      x0, [x0, #0xe70]
0068C5760  bl       #0x382bd14 ; 
0068C5764  mov      w8, #1
0068C5768  strb     w8, [x20, #0x6e0]
0068C576C  adrp     x8, #0x8f27000
0068C5770  ldr      x8, [x8, #0xe70]
0068C5774  ldr      x1, [x8]
0068C5778  ldrb     w8, [x1, #0x53]
0068C577C  tbnz     w8, #5, #0x68c5788
0068C5780  str      s8, [x19, #0x25c]
0068C5784  b        #0x68c5798 ; 
0068C5788  ldr      x8, [x1, #0x60]
0068C578C  mov      x0, x19
0068C5790  mov      v0.16b, v8.16b
0068C5794  blr      x8
0068C5798  mov      x0, x19
0068C579C  mov      x1, xzr
0068C57A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C57A4  adrp     x21, #0x959c000
0068C57A8  ldrb     w8, [x21, #0x6e1]
0068C57AC  mov      w20, w0
0068C57B0  cbnz     w8, #0x68c57c8
0068C57B4  adrp     x0, #0x8f27000
0068C57B8  ldr      x0, [x0, #0xe78]
0068C57BC  bl       #0x382bd14 ; 
0068C57C0  mov      w8, #1
0068C57C4  strb     w8, [x21, #0x6e1]
0068C57C8  adrp     x8, #0x8f27000
0068C57CC  ldr      x8, [x8, #0xe78]
0068C57D0  ldr      x2, [x8]
0068C57D4  ldrb     w8, [x2, #0x53]
0068C57D8  tbnz     w8, #5, #0x68c57e4
0068C57DC  str      w20, [x19, #0x260]
0068C57E0  b        #0x68c57f4 ; 
0068C57E4  ldr      x8, [x2, #0x60]
0068C57E8  mov      x0, x19
0068C57EC  mov      w1, w20
0068C57F0  blr      x8
0068C57F4  mov      x0, x19
0068C57F8  mov      x1, xzr
0068C57FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C5800  adrp     x21, #0x959c000
0068C5804  ldrb     w8, [x21, #0x6e2]
0068C5808  mov      w20, w0
0068C580C  cbnz     w8, #0x68c5824
0068C5810  adrp     x0, #0x8f27000
0068C5814  ldr      x0, [x0, #0xe80]
0068C5818  bl       #0x382bd14 ; 
0068C581C  mov      w8, #1
0068C5820  strb     w8, [x21, #0x6e2]
0068C5824  adrp     x8, #0x8f27000
0068C5828  ldr      x8, [x8, #0xe80]
0068C582C  ldr      x2, [x8]
0068C5830  ldrb     w8, [x2, #0x53]
0068C5834  tbnz     w8, #5, #0x68c5840
0068C5838  str      w20, [x19, #0x264]
0068C583C  b        #0x68c5850 ; 
0068C5840  ldr      x8, [x2, #0x60]
0068C5844  mov      x0, x19
0068C5848  mov      w1, w20
0068C584C  blr      x8
0068C5850  mov      x0, x19
0068C5854  mov      x1, xzr
0068C5858  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C585C  adrp     x21, #0x959c000
0068C5860  ldrb     w8, [x21, #0x6e3]
0068C5864  mov      w20, w0
0068C5868  cbnz     w8, #0x68c5880
0068C586C  adrp     x0, #0x8f27000
0068C5870  ldr      x0, [x0, #0xe88]
0068C5874  bl       #0x382bd14 ; 
0068C5878  mov      w8, #1
0068C587C  strb     w8, [x21, #0x6e3]
0068C5880  adrp     x8, #0x8f27000
0068C5884  ldr      x8, [x8, #0xe88]
0068C5888  ldr      x2, [x8]
0068C588C  ldrb     w8, [x2, #0x53]
0068C5890  tbnz     w8, #5, #0x68c589c
0068C5894  str      w20, [x19, #0x268]
0068C5898  b        #0x68c58ac ; 
0068C589C  ldr      x8, [x2, #0x60]
0068C58A0  mov      x0, x19
0068C58A4  mov      w1, w20
0068C58A8  blr      x8
0068C58AC  ldp      x20, x19, [sp, #0x20]
0068C58B0  ldp      x30, x21, [sp, #0x10]
0068C58B4  mov      w0, #1
0068C58B8  ldr      d8, [sp], #0x30
0068C58BC  ret      

