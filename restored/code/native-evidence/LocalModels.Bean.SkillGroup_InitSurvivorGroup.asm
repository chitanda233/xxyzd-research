; LocalModels.Bean.SkillGroup_InitSurvivorGroup$$readImpl
; RVA 0x6AF981C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF981C  stp      x30, x21, [sp, #-0x20]!
006AF9820  stp      x20, x19, [sp, #0x10]
006AF9824  adrp     x20, #0x959f000
006AF9828  adrp     x21, #0x8f3d000
006AF982C  ldrb     w8, [x20, #0x2ec]
006AF9830  ldr      x21, [x21, #0xd28]
006AF9834  mov      x19, x0
006AF9838  tbnz     w8, #0, #0x6af9850
006AF983C  adrp     x0, #0x8f3d000
006AF9840  ldr      x0, [x0, #0xd28]
006AF9844  bl       #0x382bd14 ; 
006AF9848  mov      w8, #1
006AF984C  strb     w8, [x20, #0x2ec]
006AF9850  ldr      x1, [x21]
006AF9854  ldrb     w8, [x1, #0x53]
006AF9858  tbnz     w8, #5, #0x6af98a8
006AF985C  mov      x0, x19
006AF9860  mov      x1, xzr
006AF9864  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9868  adrp     x21, #0x959f000
006AF986C  ldrb     w8, [x21, #0x881]
006AF9870  mov      w20, w0
006AF9874  cbnz     w8, #0x6af988c
006AF9878  adrp     x0, #0x8f3d000
006AF987C  ldr      x0, [x0, #0xc50]
006AF9880  bl       #0x382bd14 ; 
006AF9884  mov      w8, #1
006AF9888  strb     w8, [x21, #0x881]
006AF988C  adrp     x8, #0x8f3d000
006AF9890  ldr      x8, [x8, #0xc50]
006AF9894  ldr      x2, [x8]
006AF9898  ldrb     w8, [x2, #0x53]
006AF989C  tbnz     w8, #5, #0x6af98bc
006AF98A0  str      w20, [x19, #0x20]
006AF98A4  b        #0x6af98cc ; 
006AF98A8  ldr      x2, [x1, #0x60]
006AF98AC  mov      x0, x19
006AF98B0  ldp      x20, x19, [sp, #0x10]
006AF98B4  ldp      x30, x21, [sp], #0x20
006AF98B8  br       x2
006AF98BC  ldr      x8, [x2, #0x60]
006AF98C0  mov      x0, x19
006AF98C4  mov      w1, w20
006AF98C8  blr      x8
006AF98CC  mov      x0, x19
006AF98D0  mov      x1, xzr
006AF98D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF98D8  adrp     x21, #0x959f000
006AF98DC  ldrb     w8, [x21, #0x882]
006AF98E0  mov      w20, w0
006AF98E4  cbnz     w8, #0x6af98fc
006AF98E8  adrp     x0, #0x8f3d000
006AF98EC  ldr      x0, [x0, #0xc60]
006AF98F0  bl       #0x382bd14 ; 
006AF98F4  mov      w8, #1
006AF98F8  strb     w8, [x21, #0x882]
006AF98FC  adrp     x8, #0x8f3d000
006AF9900  ldr      x8, [x8, #0xc60]
006AF9904  ldr      x2, [x8]
006AF9908  ldrb     w8, [x2, #0x53]
006AF990C  tbnz     w8, #5, #0x6af9918
006AF9910  str      w20, [x19, #0x24]
006AF9914  b        #0x6af9928 ; 
006AF9918  ldr      x8, [x2, #0x60]
006AF991C  mov      x0, x19
006AF9920  mov      w1, w20
006AF9924  blr      x8
006AF9928  mov      x0, x19
006AF992C  mov      x1, xzr
006AF9930  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9934  adrp     x21, #0x959f000
006AF9938  ldrb     w8, [x21, #0x883]
006AF993C  mov      w20, w0
006AF9940  cbnz     w8, #0x6af9958
006AF9944  adrp     x0, #0x8f3d000
006AF9948  ldr      x0, [x0, #0xc70]
006AF994C  bl       #0x382bd14 ; 
006AF9950  mov      w8, #1
006AF9954  strb     w8, [x21, #0x883]
006AF9958  adrp     x8, #0x8f3d000
006AF995C  ldr      x8, [x8, #0xc70]
006AF9960  ldr      x2, [x8]
006AF9964  ldrb     w8, [x2, #0x53]
006AF9968  tbnz     w8, #5, #0x6af9974
006AF996C  str      w20, [x19, #0x28]
006AF9970  b        #0x6af9984 ; 
006AF9974  ldr      x8, [x2, #0x60]
006AF9978  mov      x0, x19
006AF997C  mov      w1, w20
006AF9980  blr      x8
006AF9984  mov      x0, x19
006AF9988  mov      x1, xzr
006AF998C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9990  adrp     x21, #0x959f000
006AF9994  ldrb     w8, [x21, #0x884]
006AF9998  mov      w20, w0
006AF999C  cbnz     w8, #0x6af99b4
006AF99A0  adrp     x0, #0x8f3d000
006AF99A4  ldr      x0, [x0, #0xc80]
006AF99A8  bl       #0x382bd14 ; 
006AF99AC  mov      w8, #1
006AF99B0  strb     w8, [x21, #0x884]
006AF99B4  adrp     x8, #0x8f3d000
006AF99B8  ldr      x8, [x8, #0xc80]
006AF99BC  ldr      x2, [x8]
006AF99C0  ldrb     w8, [x2, #0x53]
006AF99C4  tbnz     w8, #5, #0x6af99d0
006AF99C8  str      w20, [x19, #0x2c]
006AF99CC  b        #0x6af99e0 ; 
006AF99D0  ldr      x8, [x2, #0x60]
006AF99D4  mov      x0, x19
006AF99D8  mov      w1, w20
006AF99DC  blr      x8
006AF99E0  mov      x0, x19
006AF99E4  mov      x1, xzr
006AF99E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF99EC  adrp     x21, #0x959f000
006AF99F0  ldrb     w8, [x21, #0x885]
006AF99F4  mov      w20, w0
006AF99F8  cbnz     w8, #0x6af9a10
006AF99FC  adrp     x0, #0x8f3d000
006AF9A00  ldr      x0, [x0, #0xc90]
006AF9A04  bl       #0x382bd14 ; 
006AF9A08  mov      w8, #1
006AF9A0C  strb     w8, [x21, #0x885]
006AF9A10  adrp     x8, #0x8f3d000
006AF9A14  ldr      x8, [x8, #0xc90]
006AF9A18  ldr      x2, [x8]
006AF9A1C  ldrb     w8, [x2, #0x53]
006AF9A20  tbnz     w8, #5, #0x6af9a2c
006AF9A24  str      w20, [x19, #0x30]
006AF9A28  b        #0x6af9a3c ; 
006AF9A2C  ldr      x8, [x2, #0x60]
006AF9A30  mov      x0, x19
006AF9A34  mov      w1, w20
006AF9A38  blr      x8
006AF9A3C  mov      x0, x19
006AF9A40  mov      x1, xzr
006AF9A44  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9A48  adrp     x21, #0x959f000
006AF9A4C  ldrb     w8, [x21, #0x886]
006AF9A50  mov      w20, w0
006AF9A54  cbnz     w8, #0x6af9a6c
006AF9A58  adrp     x0, #0x8f3d000
006AF9A5C  ldr      x0, [x0, #0xca0]
006AF9A60  bl       #0x382bd14 ; 
006AF9A64  mov      w8, #1
006AF9A68  strb     w8, [x21, #0x886]
006AF9A6C  adrp     x8, #0x8f3d000
006AF9A70  ldr      x8, [x8, #0xca0]
006AF9A74  ldr      x2, [x8]
006AF9A78  ldrb     w8, [x2, #0x53]
006AF9A7C  tbnz     w8, #5, #0x6af9a88
006AF9A80  str      w20, [x19, #0x34]
006AF9A84  b        #0x6af9a98 ; 
006AF9A88  ldr      x8, [x2, #0x60]
006AF9A8C  mov      x0, x19
006AF9A90  mov      w1, w20
006AF9A94  blr      x8
006AF9A98  mov      x0, x19
006AF9A9C  mov      x1, xzr
006AF9AA0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9AA4  adrp     x21, #0x959f000
006AF9AA8  ldrb     w8, [x21, #0x887]
006AF9AAC  mov      w20, w0
006AF9AB0  cbnz     w8, #0x6af9ac8
006AF9AB4  adrp     x0, #0x8f3d000
006AF9AB8  ldr      x0, [x0, #0xcb0]
006AF9ABC  bl       #0x382bd14 ; 
006AF9AC0  mov      w8, #1
006AF9AC4  strb     w8, [x21, #0x887]
006AF9AC8  adrp     x8, #0x8f3d000
006AF9ACC  ldr      x8, [x8, #0xcb0]
006AF9AD0  ldr      x2, [x8]
006AF9AD4  ldrb     w8, [x2, #0x53]
006AF9AD8  tbnz     w8, #5, #0x6af9ae4
006AF9ADC  str      w20, [x19, #0x38]
006AF9AE0  b        #0x6af9af4 ; 
006AF9AE4  ldr      x8, [x2, #0x60]
006AF9AE8  mov      x0, x19
006AF9AEC  mov      w1, w20
006AF9AF0  blr      x8
006AF9AF4  mov      x0, x19
006AF9AF8  mov      x1, xzr
006AF9AFC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9B00  adrp     x21, #0x959f000
006AF9B04  ldrb     w8, [x21, #0x888]
006AF9B08  mov      w20, w0
006AF9B0C  cbnz     w8, #0x6af9b24
006AF9B10  adrp     x0, #0x8f3d000
006AF9B14  ldr      x0, [x0, #0xcc0]
006AF9B18  bl       #0x382bd14 ; 
006AF9B1C  mov      w8, #1
006AF9B20  strb     w8, [x21, #0x888]
006AF9B24  adrp     x8, #0x8f3d000
006AF9B28  ldr      x8, [x8, #0xcc0]
006AF9B2C  ldr      x2, [x8]
006AF9B30  ldrb     w8, [x2, #0x53]
006AF9B34  tbnz     w8, #5, #0x6af9b40
006AF9B38  str      w20, [x19, #0x3c]
006AF9B3C  b        #0x6af9b50 ; 
006AF9B40  ldr      x8, [x2, #0x60]
006AF9B44  mov      x0, x19
006AF9B48  mov      w1, w20
006AF9B4C  blr      x8
006AF9B50  mov      x0, x19
006AF9B54  mov      x1, xzr
006AF9B58  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9B5C  adrp     x21, #0x959f000
006AF9B60  ldrb     w8, [x21, #0x889]
006AF9B64  mov      w20, w0
006AF9B68  cbnz     w8, #0x6af9b80
006AF9B6C  adrp     x0, #0x8f3d000
006AF9B70  ldr      x0, [x0, #0xcd0]
006AF9B74  bl       #0x382bd14 ; 
006AF9B78  mov      w8, #1
006AF9B7C  strb     w8, [x21, #0x889]
006AF9B80  adrp     x8, #0x8f3d000
006AF9B84  ldr      x8, [x8, #0xcd0]
006AF9B88  ldr      x2, [x8]
006AF9B8C  ldrb     w8, [x2, #0x53]
006AF9B90  tbnz     w8, #5, #0x6af9b9c
006AF9B94  str      w20, [x19, #0x40]
006AF9B98  b        #0x6af9bac ; 
006AF9B9C  ldr      x8, [x2, #0x60]
006AF9BA0  mov      x0, x19
006AF9BA4  mov      w1, w20
006AF9BA8  blr      x8
006AF9BAC  mov      x0, x19
006AF9BB0  mov      x1, xzr
006AF9BB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9BB8  adrp     x21, #0x959f000
006AF9BBC  ldrb     w8, [x21, #0x88a]
006AF9BC0  mov      w20, w0
006AF9BC4  cbnz     w8, #0x6af9bdc
006AF9BC8  adrp     x0, #0x8f3d000
006AF9BCC  ldr      x0, [x0, #0xce0]
006AF9BD0  bl       #0x382bd14 ; 
006AF9BD4  mov      w8, #1
006AF9BD8  strb     w8, [x21, #0x88a]
006AF9BDC  adrp     x8, #0x8f3d000
006AF9BE0  ldr      x8, [x8, #0xce0]
006AF9BE4  ldr      x2, [x8]
006AF9BE8  ldrb     w8, [x2, #0x53]
006AF9BEC  tbnz     w8, #5, #0x6af9bf8
006AF9BF0  str      w20, [x19, #0x44]
006AF9BF4  b        #0x6af9c08 ; 
006AF9BF8  ldr      x8, [x2, #0x60]
006AF9BFC  mov      x0, x19
006AF9C00  mov      w1, w20
006AF9C04  blr      x8
006AF9C08  mov      x0, x19
006AF9C0C  mov      x1, xzr
006AF9C10  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9C14  adrp     x21, #0x959f000
006AF9C18  ldrb     w8, [x21, #0x88b]
006AF9C1C  mov      w20, w0
006AF9C20  cbnz     w8, #0x6af9c38
006AF9C24  adrp     x0, #0x8f3d000
006AF9C28  ldr      x0, [x0, #0xcf0]
006AF9C2C  bl       #0x382bd14 ; 
006AF9C30  mov      w8, #1
006AF9C34  strb     w8, [x21, #0x88b]
006AF9C38  adrp     x8, #0x8f3d000
006AF9C3C  ldr      x8, [x8, #0xcf0]
006AF9C40  ldr      x2, [x8]
006AF9C44  ldrb     w8, [x2, #0x53]
006AF9C48  tbnz     w8, #5, #0x6af9c54
006AF9C4C  str      w20, [x19, #0x48]
006AF9C50  b        #0x6af9c64 ; 
006AF9C54  ldr      x8, [x2, #0x60]
006AF9C58  mov      x0, x19
006AF9C5C  mov      w1, w20
006AF9C60  blr      x8
006AF9C64  mov      x0, x19
006AF9C68  mov      x1, xzr
006AF9C6C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9C70  adrp     x21, #0x959f000
006AF9C74  ldrb     w8, [x21, #0x88c]
006AF9C78  mov      w20, w0
006AF9C7C  cbnz     w8, #0x6af9c94
006AF9C80  adrp     x0, #0x8f3d000
006AF9C84  ldr      x0, [x0, #0xd00]
006AF9C88  bl       #0x382bd14 ; 
006AF9C8C  mov      w8, #1
006AF9C90  strb     w8, [x21, #0x88c]
006AF9C94  adrp     x8, #0x8f3d000
006AF9C98  ldr      x8, [x8, #0xd00]
006AF9C9C  ldr      x2, [x8]
006AF9CA0  ldrb     w8, [x2, #0x53]
006AF9CA4  tbnz     w8, #5, #0x6af9cb0
006AF9CA8  str      w20, [x19, #0x4c]
006AF9CAC  b        #0x6af9cc0 ; 
006AF9CB0  ldr      x8, [x2, #0x60]
006AF9CB4  mov      x0, x19
006AF9CB8  mov      w1, w20
006AF9CBC  blr      x8
006AF9CC0  mov      x0, x19
006AF9CC4  mov      x1, xzr
006AF9CC8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9CCC  adrp     x21, #0x959f000
006AF9CD0  ldrb     w8, [x21, #0x88d]
006AF9CD4  mov      w20, w0
006AF9CD8  cbnz     w8, #0x6af9cf0
006AF9CDC  adrp     x0, #0x8f3d000
006AF9CE0  ldr      x0, [x0, #0xd10]
006AF9CE4  bl       #0x382bd14 ; 
006AF9CE8  mov      w8, #1
006AF9CEC  strb     w8, [x21, #0x88d]
006AF9CF0  adrp     x8, #0x8f3d000
006AF9CF4  ldr      x8, [x8, #0xd10]
006AF9CF8  ldr      x2, [x8]
006AF9CFC  ldrb     w8, [x2, #0x53]
006AF9D00  tbnz     w8, #5, #0x6af9d0c
006AF9D04  str      w20, [x19, #0x50]
006AF9D08  b        #0x6af9d1c ; 
006AF9D0C  ldr      x8, [x2, #0x60]
006AF9D10  mov      x0, x19
006AF9D14  mov      w1, w20
006AF9D18  blr      x8
006AF9D1C  mov      x0, x19
006AF9D20  mov      x1, xzr
006AF9D24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF9D28  adrp     x21, #0x959f000
006AF9D2C  ldrb     w8, [x21, #0x88e]
006AF9D30  mov      w20, w0
006AF9D34  cbnz     w8, #0x6af9d4c
006AF9D38  adrp     x0, #0x8f3d000
006AF9D3C  ldr      x0, [x0, #0xd20]
006AF9D40  bl       #0x382bd14 ; 
006AF9D44  mov      w8, #1
006AF9D48  strb     w8, [x21, #0x88e]
006AF9D4C  adrp     x8, #0x8f3d000
006AF9D50  ldr      x8, [x8, #0xd20]
006AF9D54  ldr      x2, [x8]
006AF9D58  ldrb     w8, [x2, #0x53]
006AF9D5C  tbnz     w8, #5, #0x6af9d68
006AF9D60  str      w20, [x19, #0x54]
006AF9D64  b        #0x6af9d78 ; 
006AF9D68  ldr      x8, [x2, #0x60]
006AF9D6C  mov      x0, x19
006AF9D70  mov      w1, w20
006AF9D74  blr      x8
006AF9D78  ldp      x20, x19, [sp, #0x10]
006AF9D7C  mov      w0, #1
006AF9D80  ldp      x30, x21, [sp], #0x20
006AF9D84  ret      

