; LocalModels.Bean.SignIn_SignIn$$readImpl
; RVA 0x6AF3B3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF3B3C  stp      x30, x21, [sp, #-0x20]!
006AF3B40  stp      x20, x19, [sp, #0x10]
006AF3B44  adrp     x20, #0x959e000
006AF3B48  adrp     x21, #0x8f3d000
006AF3B4C  ldrb     w8, [x20, #0xebb]
006AF3B50  ldr      x21, [x21, #0x8c8]
006AF3B54  mov      x19, x0
006AF3B58  tbnz     w8, #0, #0x6af3b70
006AF3B5C  adrp     x0, #0x8f3d000
006AF3B60  ldr      x0, [x0, #0x8c8]
006AF3B64  bl       #0x382bd14 ; 
006AF3B68  mov      w8, #1
006AF3B6C  strb     w8, [x20, #0xebb]
006AF3B70  ldr      x1, [x21]
006AF3B74  ldrb     w8, [x1, #0x53]
006AF3B78  tbnz     w8, #5, #0x6af3bc8
006AF3B7C  mov      x0, x19
006AF3B80  mov      x1, xzr
006AF3B84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF3B88  adrp     x21, #0x959f000
006AF3B8C  ldrb     w8, [x21, #0x263]
006AF3B90  mov      w20, w0
006AF3B94  cbnz     w8, #0x6af3bac
006AF3B98  adrp     x0, #0x8f3d000
006AF3B9C  ldr      x0, [x0, #0x820]
006AF3BA0  bl       #0x382bd14 ; 
006AF3BA4  mov      w8, #1
006AF3BA8  strb     w8, [x21, #0x263]
006AF3BAC  adrp     x8, #0x8f3d000
006AF3BB0  ldr      x8, [x8, #0x820]
006AF3BB4  ldr      x2, [x8]
006AF3BB8  ldrb     w8, [x2, #0x53]
006AF3BBC  tbnz     w8, #5, #0x6af3bdc
006AF3BC0  str      w20, [x19, #0x20]
006AF3BC4  b        #0x6af3bec ; 
006AF3BC8  ldr      x2, [x1, #0x60]
006AF3BCC  mov      x0, x19
006AF3BD0  ldp      x20, x19, [sp, #0x10]
006AF3BD4  ldp      x30, x21, [sp], #0x20
006AF3BD8  br       x2
006AF3BDC  ldr      x8, [x2, #0x60]
006AF3BE0  mov      x0, x19
006AF3BE4  mov      w1, w20
006AF3BE8  blr      x8
006AF3BEC  mov      x0, x19
006AF3BF0  mov      x1, xzr
006AF3BF4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF3BF8  adrp     x21, #0x959f000
006AF3BFC  ldrb     w8, [x21, #0x264]
006AF3C00  mov      w20, w0
006AF3C04  cbnz     w8, #0x6af3c1c
006AF3C08  adrp     x0, #0x8f3d000
006AF3C0C  ldr      x0, [x0, #0x830]
006AF3C10  bl       #0x382bd14 ; 
006AF3C14  mov      w8, #1
006AF3C18  strb     w8, [x21, #0x264]
006AF3C1C  adrp     x8, #0x8f3d000
006AF3C20  ldr      x8, [x8, #0x830]
006AF3C24  ldr      x2, [x8]
006AF3C28  ldrb     w8, [x2, #0x53]
006AF3C2C  tbnz     w8, #5, #0x6af3c38
006AF3C30  str      w20, [x19, #0x24]
006AF3C34  b        #0x6af3c48 ; 
006AF3C38  ldr      x8, [x2, #0x60]
006AF3C3C  mov      x0, x19
006AF3C40  mov      w1, w20
006AF3C44  blr      x8
006AF3C48  mov      x0, x19
006AF3C4C  mov      x1, xzr
006AF3C50  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF3C54  adrp     x21, #0x959f000
006AF3C58  ldrb     w8, [x21, #0x265]
006AF3C5C  mov      w20, w0
006AF3C60  cbnz     w8, #0x6af3c78
006AF3C64  adrp     x0, #0x8f3d000
006AF3C68  ldr      x0, [x0, #0x840]
006AF3C6C  bl       #0x382bd14 ; 
006AF3C70  mov      w8, #1
006AF3C74  strb     w8, [x21, #0x265]
006AF3C78  adrp     x8, #0x8f3d000
006AF3C7C  ldr      x8, [x8, #0x840]
006AF3C80  ldr      x2, [x8]
006AF3C84  ldrb     w8, [x2, #0x53]
006AF3C88  tbnz     w8, #5, #0x6af3c94
006AF3C8C  str      w20, [x19, #0x28]
006AF3C90  b        #0x6af3ca4 ; 
006AF3C94  ldr      x8, [x2, #0x60]
006AF3C98  mov      x0, x19
006AF3C9C  mov      w1, w20
006AF3CA0  blr      x8
006AF3CA4  mov      x0, x19
006AF3CA8  mov      x1, xzr
006AF3CAC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AF3CB0  adrp     x21, #0x959f000
006AF3CB4  ldrb     w8, [x21, #0x266]
006AF3CB8  mov      x20, x0
006AF3CBC  cbnz     w8, #0x6af3cd4
006AF3CC0  adrp     x0, #0x8f3d000
006AF3CC4  ldr      x0, [x0, #0x850]
006AF3CC8  bl       #0x382bd14 ; 
006AF3CCC  mov      w8, #1
006AF3CD0  strb     w8, [x21, #0x266]
006AF3CD4  adrp     x8, #0x8f3d000
006AF3CD8  ldr      x8, [x8, #0x850]
006AF3CDC  ldr      x2, [x8]
006AF3CE0  ldrb     w8, [x2, #0x53]
006AF3CE4  tbnz     w8, #5, #0x6af3cfc
006AF3CE8  mov      x0, x19
006AF3CEC  str      x20, [x0, #0x30]!
006AF3CF0  mov      x1, x20
006AF3CF4  bl       #0x382bcb8 ; 
006AF3CF8  b        #0x6af3d0c ; 
006AF3CFC  ldr      x8, [x2, #0x60]
006AF3D00  mov      x0, x19
006AF3D04  mov      x1, x20
006AF3D08  blr      x8
006AF3D0C  mov      x0, x19
006AF3D10  mov      x1, xzr
006AF3D14  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AF3D18  adrp     x21, #0x959f000
006AF3D1C  ldrb     w8, [x21, #0x267]
006AF3D20  mov      x20, x0
006AF3D24  cbnz     w8, #0x6af3d3c
006AF3D28  adrp     x0, #0x8f3d000
006AF3D2C  ldr      x0, [x0, #0x860]
006AF3D30  bl       #0x382bd14 ; 
006AF3D34  mov      w8, #1
006AF3D38  strb     w8, [x21, #0x267]
006AF3D3C  adrp     x8, #0x8f3d000
006AF3D40  ldr      x8, [x8, #0x860]
006AF3D44  ldr      x2, [x8]
006AF3D48  ldrb     w8, [x2, #0x53]
006AF3D4C  tbnz     w8, #5, #0x6af3d64
006AF3D50  mov      x0, x19
006AF3D54  str      x20, [x0, #0x38]!
006AF3D58  mov      x1, x20
006AF3D5C  bl       #0x382bcb8 ; 
006AF3D60  b        #0x6af3d74 ; 
006AF3D64  ldr      x8, [x2, #0x60]
006AF3D68  mov      x0, x19
006AF3D6C  mov      x1, x20
006AF3D70  blr      x8
006AF3D74  mov      x0, x19
006AF3D78  mov      x1, xzr
006AF3D7C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AF3D80  adrp     x21, #0x959f000
006AF3D84  ldrb     w8, [x21, #0x268]
006AF3D88  mov      x20, x0
006AF3D8C  cbnz     w8, #0x6af3da4
006AF3D90  adrp     x0, #0x8f3d000
006AF3D94  ldr      x0, [x0, #0x870]
006AF3D98  bl       #0x382bd14 ; 
006AF3D9C  mov      w8, #1
006AF3DA0  strb     w8, [x21, #0x268]
006AF3DA4  adrp     x8, #0x8f3d000
006AF3DA8  ldr      x8, [x8, #0x870]
006AF3DAC  ldr      x2, [x8]
006AF3DB0  ldrb     w8, [x2, #0x53]
006AF3DB4  tbnz     w8, #5, #0x6af3dcc
006AF3DB8  mov      x0, x19
006AF3DBC  str      x20, [x0, #0x40]!
006AF3DC0  mov      x1, x20
006AF3DC4  bl       #0x382bcb8 ; 
006AF3DC8  b        #0x6af3ddc ; 
006AF3DCC  ldr      x8, [x2, #0x60]
006AF3DD0  mov      x0, x19
006AF3DD4  mov      x1, x20
006AF3DD8  blr      x8
006AF3DDC  mov      x0, x19
006AF3DE0  mov      x1, xzr
006AF3DE4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AF3DE8  adrp     x21, #0x959f000
006AF3DEC  ldrb     w8, [x21, #0x269]
006AF3DF0  mov      x20, x0
006AF3DF4  cbnz     w8, #0x6af3e0c
006AF3DF8  adrp     x0, #0x8f3d000
006AF3DFC  ldr      x0, [x0, #0x880]
006AF3E00  bl       #0x382bd14 ; 
006AF3E04  mov      w8, #1
006AF3E08  strb     w8, [x21, #0x269]
006AF3E0C  adrp     x8, #0x8f3d000
006AF3E10  ldr      x8, [x8, #0x880]
006AF3E14  ldr      x2, [x8]
006AF3E18  ldrb     w8, [x2, #0x53]
006AF3E1C  tbnz     w8, #5, #0x6af3e34
006AF3E20  mov      x0, x19
006AF3E24  str      x20, [x0, #0x48]!
006AF3E28  mov      x1, x20
006AF3E2C  bl       #0x382bcb8 ; 
006AF3E30  b        #0x6af3e44 ; 
006AF3E34  ldr      x8, [x2, #0x60]
006AF3E38  mov      x0, x19
006AF3E3C  mov      x1, x20
006AF3E40  blr      x8
006AF3E44  mov      x0, x19
006AF3E48  mov      x1, xzr
006AF3E4C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AF3E50  adrp     x21, #0x959f000
006AF3E54  ldrb     w8, [x21, #0x26a]
006AF3E58  mov      x20, x0
006AF3E5C  cbnz     w8, #0x6af3e74
006AF3E60  adrp     x0, #0x8f3d000
006AF3E64  ldr      x0, [x0, #0x890]
006AF3E68  bl       #0x382bd14 ; 
006AF3E6C  mov      w8, #1
006AF3E70  strb     w8, [x21, #0x26a]
006AF3E74  adrp     x8, #0x8f3d000
006AF3E78  ldr      x8, [x8, #0x890]
006AF3E7C  ldr      x2, [x8]
006AF3E80  ldrb     w8, [x2, #0x53]
006AF3E84  tbnz     w8, #5, #0x6af3e9c
006AF3E88  mov      x0, x19
006AF3E8C  str      x20, [x0, #0x50]!
006AF3E90  mov      x1, x20
006AF3E94  bl       #0x382bcb8 ; 
006AF3E98  b        #0x6af3eac ; 
006AF3E9C  ldr      x8, [x2, #0x60]
006AF3EA0  mov      x0, x19
006AF3EA4  mov      x1, x20
006AF3EA8  blr      x8
006AF3EAC  mov      x0, x19
006AF3EB0  mov      x1, xzr
006AF3EB4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AF3EB8  adrp     x21, #0x959f000
006AF3EBC  ldrb     w8, [x21, #0x26b]
006AF3EC0  mov      x20, x0
006AF3EC4  cbnz     w8, #0x6af3edc
006AF3EC8  adrp     x0, #0x8f3d000
006AF3ECC  ldr      x0, [x0, #0x8a0]
006AF3ED0  bl       #0x382bd14 ; 
006AF3ED4  mov      w8, #1
006AF3ED8  strb     w8, [x21, #0x26b]
006AF3EDC  adrp     x8, #0x8f3d000
006AF3EE0  ldr      x8, [x8, #0x8a0]
006AF3EE4  ldr      x2, [x8]
006AF3EE8  ldrb     w8, [x2, #0x53]
006AF3EEC  tbnz     w8, #5, #0x6af3f04
006AF3EF0  mov      x0, x19
006AF3EF4  str      x20, [x0, #0x58]!
006AF3EF8  mov      x1, x20
006AF3EFC  bl       #0x382bcb8 ; 
006AF3F00  b        #0x6af3f14 ; 
006AF3F04  ldr      x8, [x2, #0x60]
006AF3F08  mov      x0, x19
006AF3F0C  mov      x1, x20
006AF3F10  blr      x8
006AF3F14  mov      x0, x19
006AF3F18  mov      x1, xzr
006AF3F1C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AF3F20  adrp     x21, #0x959f000
006AF3F24  ldrb     w8, [x21, #0x26c]
006AF3F28  mov      x20, x0
006AF3F2C  cbnz     w8, #0x6af3f44
006AF3F30  adrp     x0, #0x8f3d000
006AF3F34  ldr      x0, [x0, #0x8b0]
006AF3F38  bl       #0x382bd14 ; 
006AF3F3C  mov      w8, #1
006AF3F40  strb     w8, [x21, #0x26c]
006AF3F44  adrp     x8, #0x8f3d000
006AF3F48  ldr      x8, [x8, #0x8b0]
006AF3F4C  ldr      x2, [x8]
006AF3F50  ldrb     w8, [x2, #0x53]
006AF3F54  tbnz     w8, #5, #0x6af3f6c
006AF3F58  mov      x0, x19
006AF3F5C  str      x20, [x0, #0x60]!
006AF3F60  mov      x1, x20
006AF3F64  bl       #0x382bcb8 ; 
006AF3F68  b        #0x6af3f7c ; 
006AF3F6C  ldr      x8, [x2, #0x60]
006AF3F70  mov      x0, x19
006AF3F74  mov      x1, x20
006AF3F78  blr      x8
006AF3F7C  mov      x0, x19
006AF3F80  mov      x1, xzr
006AF3F84  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AF3F88  adrp     x21, #0x959f000
006AF3F8C  ldrb     w8, [x21, #0x26d]
006AF3F90  mov      x20, x0
006AF3F94  cbnz     w8, #0x6af3fac
006AF3F98  adrp     x0, #0x8f3d000
006AF3F9C  ldr      x0, [x0, #0x8c0]
006AF3FA0  bl       #0x382bd14 ; 
006AF3FA4  mov      w8, #1
006AF3FA8  strb     w8, [x21, #0x26d]
006AF3FAC  adrp     x8, #0x8f3d000
006AF3FB0  ldr      x8, [x8, #0x8c0]
006AF3FB4  ldr      x2, [x8]
006AF3FB8  ldrb     w8, [x2, #0x53]
006AF3FBC  tbnz     w8, #5, #0x6af3fd4
006AF3FC0  str      x20, [x19, #0x68]!
006AF3FC4  mov      x0, x19
006AF3FC8  mov      x1, x20
006AF3FCC  bl       #0x382bcb8 ; 
006AF3FD0  b        #0x6af3fe4 ; 
006AF3FD4  ldr      x8, [x2, #0x60]
006AF3FD8  mov      x0, x19
006AF3FDC  mov      x1, x20
006AF3FE0  blr      x8
006AF3FE4  ldp      x20, x19, [sp, #0x10]
006AF3FE8  mov      w0, #1
006AF3FEC  ldp      x30, x21, [sp], #0x20
006AF3FF0  ret      

