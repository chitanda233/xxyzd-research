; LocalModels.Bean.Equipment_Quality$$readImpl
; RVA 0x6A67C18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A67C18  stp      x30, x21, [sp, #-0x20]!
006A67C1C  stp      x20, x19, [sp, #0x10]
006A67C20  adrp     x20, #0x959d000
006A67C24  adrp     x21, #0x8f36000
006A67C28  ldrb     w8, [x20, #0xcb4]
006A67C2C  ldr      x21, [x21, #0xef8]
006A67C30  mov      x19, x0
006A67C34  tbnz     w8, #0, #0x6a67c4c
006A67C38  adrp     x0, #0x8f36000
006A67C3C  ldr      x0, [x0, #0xef8]
006A67C40  bl       #0x382bd14 ; 
006A67C44  mov      w8, #1
006A67C48  strb     w8, [x20, #0xcb4]
006A67C4C  ldr      x1, [x21]
006A67C50  ldrb     w8, [x1, #0x53]
006A67C54  tbnz     w8, #5, #0x6a67ca4
006A67C58  mov      x0, x19
006A67C5C  mov      x1, xzr
006A67C60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A67C64  adrp     x21, #0x959e000
006A67C68  ldrb     w8, [x21, #0x3f3]
006A67C6C  mov      w20, w0
006A67C70  cbnz     w8, #0x6a67c88
006A67C74  adrp     x0, #0x8f36000
006A67C78  ldr      x0, [x0, #0xe70]
006A67C7C  bl       #0x382bd14 ; 
006A67C80  mov      w8, #1
006A67C84  strb     w8, [x21, #0x3f3]
006A67C88  adrp     x8, #0x8f36000
006A67C8C  ldr      x8, [x8, #0xe70]
006A67C90  ldr      x2, [x8]
006A67C94  ldrb     w8, [x2, #0x53]
006A67C98  tbnz     w8, #5, #0x6a67cb8
006A67C9C  str      w20, [x19, #0x20]
006A67CA0  b        #0x6a67cc8 ; 
006A67CA4  ldr      x2, [x1, #0x60]
006A67CA8  mov      x0, x19
006A67CAC  ldp      x20, x19, [sp, #0x10]
006A67CB0  ldp      x30, x21, [sp], #0x20
006A67CB4  br       x2
006A67CB8  ldr      x8, [x2, #0x60]
006A67CBC  mov      x0, x19
006A67CC0  mov      w1, w20
006A67CC4  blr      x8
006A67CC8  mov      x0, x19
006A67CCC  mov      x1, xzr
006A67CD0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A67CD4  adrp     x21, #0x959e000
006A67CD8  ldrb     w8, [x21, #0x3f4]
006A67CDC  mov      w20, w0
006A67CE0  cbnz     w8, #0x6a67cf8
006A67CE4  adrp     x0, #0x8f36000
006A67CE8  ldr      x0, [x0, #0xe80]
006A67CEC  bl       #0x382bd14 ; 
006A67CF0  mov      w8, #1
006A67CF4  strb     w8, [x21, #0x3f4]
006A67CF8  adrp     x8, #0x8f36000
006A67CFC  ldr      x8, [x8, #0xe80]
006A67D00  ldr      x2, [x8]
006A67D04  ldrb     w8, [x2, #0x53]
006A67D08  tbnz     w8, #5, #0x6a67d14
006A67D0C  str      w20, [x19, #0x24]
006A67D10  b        #0x6a67d24 ; 
006A67D14  ldr      x8, [x2, #0x60]
006A67D18  mov      x0, x19
006A67D1C  mov      w1, w20
006A67D20  blr      x8
006A67D24  mov      x0, x19
006A67D28  mov      x1, xzr
006A67D2C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A67D30  adrp     x21, #0x959e000
006A67D34  ldrb     w8, [x21, #0x3f5]
006A67D38  mov      w20, w0
006A67D3C  cbnz     w8, #0x6a67d54
006A67D40  adrp     x0, #0x8f36000
006A67D44  ldr      x0, [x0, #0xe90]
006A67D48  bl       #0x382bd14 ; 
006A67D4C  mov      w8, #1
006A67D50  strb     w8, [x21, #0x3f5]
006A67D54  adrp     x8, #0x8f36000
006A67D58  ldr      x8, [x8, #0xe90]
006A67D5C  ldr      x2, [x8]
006A67D60  ldrb     w8, [x2, #0x53]
006A67D64  tbnz     w8, #5, #0x6a67d70
006A67D68  str      w20, [x19, #0x28]
006A67D6C  b        #0x6a67d80 ; 
006A67D70  ldr      x8, [x2, #0x60]
006A67D74  mov      x0, x19
006A67D78  mov      w1, w20
006A67D7C  blr      x8
006A67D80  mov      x0, x19
006A67D84  mov      x1, xzr
006A67D88  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A67D8C  adrp     x21, #0x959e000
006A67D90  ldrb     w8, [x21, #0x3f6]
006A67D94  mov      w20, w0
006A67D98  cbnz     w8, #0x6a67db0
006A67D9C  adrp     x0, #0x8f36000
006A67DA0  ldr      x0, [x0, #0xea0]
006A67DA4  bl       #0x382bd14 ; 
006A67DA8  mov      w8, #1
006A67DAC  strb     w8, [x21, #0x3f6]
006A67DB0  adrp     x8, #0x8f36000
006A67DB4  ldr      x8, [x8, #0xea0]
006A67DB8  ldr      x2, [x8]
006A67DBC  ldrb     w8, [x2, #0x53]
006A67DC0  tbnz     w8, #5, #0x6a67dcc
006A67DC4  str      w20, [x19, #0x2c]
006A67DC8  b        #0x6a67ddc ; 
006A67DCC  ldr      x8, [x2, #0x60]
006A67DD0  mov      x0, x19
006A67DD4  mov      w1, w20
006A67DD8  blr      x8
006A67DDC  mov      x0, x19
006A67DE0  mov      x1, xzr
006A67DE4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A67DE8  adrp     x21, #0x959e000
006A67DEC  ldrb     w8, [x21, #0x3f7]
006A67DF0  mov      w20, w0
006A67DF4  cbnz     w8, #0x6a67e0c
006A67DF8  adrp     x0, #0x8f36000
006A67DFC  ldr      x0, [x0, #0xeb0]
006A67E00  bl       #0x382bd14 ; 
006A67E04  mov      w8, #1
006A67E08  strb     w8, [x21, #0x3f7]
006A67E0C  adrp     x8, #0x8f36000
006A67E10  ldr      x8, [x8, #0xeb0]
006A67E14  ldr      x2, [x8]
006A67E18  ldrb     w8, [x2, #0x53]
006A67E1C  tbnz     w8, #5, #0x6a67e28
006A67E20  str      w20, [x19, #0x30]
006A67E24  b        #0x6a67e38 ; 
006A67E28  ldr      x8, [x2, #0x60]
006A67E2C  mov      x0, x19
006A67E30  mov      w1, w20
006A67E34  blr      x8
006A67E38  mov      x0, x19
006A67E3C  mov      x1, xzr
006A67E40  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A67E44  adrp     x21, #0x959e000
006A67E48  ldrb     w8, [x21, #0x3f8]
006A67E4C  mov      w20, w0
006A67E50  cbnz     w8, #0x6a67e68
006A67E54  adrp     x0, #0x8f36000
006A67E58  ldr      x0, [x0, #0xec0]
006A67E5C  bl       #0x382bd14 ; 
006A67E60  mov      w8, #1
006A67E64  strb     w8, [x21, #0x3f8]
006A67E68  adrp     x8, #0x8f36000
006A67E6C  ldr      x8, [x8, #0xec0]
006A67E70  ldr      x2, [x8]
006A67E74  ldrb     w8, [x2, #0x53]
006A67E78  tbnz     w8, #5, #0x6a67e84
006A67E7C  str      w20, [x19, #0x34]
006A67E80  b        #0x6a67e94 ; 
006A67E84  ldr      x8, [x2, #0x60]
006A67E88  mov      x0, x19
006A67E8C  mov      w1, w20
006A67E90  blr      x8
006A67E94  mov      x0, x19
006A67E98  mov      x1, xzr
006A67E9C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A67EA0  adrp     x21, #0x959e000
006A67EA4  ldrb     w8, [x21, #0x3f9]
006A67EA8  mov      w20, w0
006A67EAC  cbnz     w8, #0x6a67ec4
006A67EB0  adrp     x0, #0x8f36000
006A67EB4  ldr      x0, [x0, #0xed0]
006A67EB8  bl       #0x382bd14 ; 
006A67EBC  mov      w8, #1
006A67EC0  strb     w8, [x21, #0x3f9]
006A67EC4  adrp     x8, #0x8f36000
006A67EC8  ldr      x8, [x8, #0xed0]
006A67ECC  ldr      x2, [x8]
006A67ED0  ldrb     w8, [x2, #0x53]
006A67ED4  tbnz     w8, #5, #0x6a67ee0
006A67ED8  str      w20, [x19, #0x38]
006A67EDC  b        #0x6a67ef0 ; 
006A67EE0  ldr      x8, [x2, #0x60]
006A67EE4  mov      x0, x19
006A67EE8  mov      w1, w20
006A67EEC  blr      x8
006A67EF0  mov      x0, x19
006A67EF4  mov      x1, xzr
006A67EF8  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A67EFC  adrp     x21, #0x959e000
006A67F00  ldrb     w8, [x21, #0x3fa]
006A67F04  mov      x20, x0
006A67F08  cbnz     w8, #0x6a67f20
006A67F0C  adrp     x0, #0x8f36000
006A67F10  ldr      x0, [x0, #0xee0]
006A67F14  bl       #0x382bd14 ; 
006A67F18  mov      w8, #1
006A67F1C  strb     w8, [x21, #0x3fa]
006A67F20  adrp     x8, #0x8f36000
006A67F24  ldr      x8, [x8, #0xee0]
006A67F28  ldr      x2, [x8]
006A67F2C  ldrb     w8, [x2, #0x53]
006A67F30  tbnz     w8, #5, #0x6a67f48
006A67F34  mov      x0, x19
006A67F38  str      x20, [x0, #0x40]!
006A67F3C  mov      x1, x20
006A67F40  bl       #0x382bcb8 ; 
006A67F44  b        #0x6a67f58 ; 
006A67F48  ldr      x8, [x2, #0x60]
006A67F4C  mov      x0, x19
006A67F50  mov      x1, x20
006A67F54  blr      x8
006A67F58  mov      x0, x19
006A67F5C  mov      x1, xzr
006A67F60  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A67F64  adrp     x21, #0x959e000
006A67F68  ldrb     w8, [x21, #0x3fb]
006A67F6C  mov      x20, x0
006A67F70  cbnz     w8, #0x6a67f88
006A67F74  adrp     x0, #0x8f36000
006A67F78  ldr      x0, [x0, #0xef0]
006A67F7C  bl       #0x382bd14 ; 
006A67F80  mov      w8, #1
006A67F84  strb     w8, [x21, #0x3fb]
006A67F88  adrp     x8, #0x8f36000
006A67F8C  ldr      x8, [x8, #0xef0]
006A67F90  ldr      x2, [x8]
006A67F94  ldrb     w8, [x2, #0x53]
006A67F98  tbnz     w8, #5, #0x6a67fb0
006A67F9C  str      x20, [x19, #0x48]!
006A67FA0  mov      x0, x19
006A67FA4  mov      x1, x20
006A67FA8  bl       #0x382bcb8 ; 
006A67FAC  b        #0x6a67fc0 ; 
006A67FB0  ldr      x8, [x2, #0x60]
006A67FB4  mov      x0, x19
006A67FB8  mov      x1, x20
006A67FBC  blr      x8
006A67FC0  ldp      x20, x19, [sp, #0x10]
006A67FC4  mov      w0, #1
006A67FC8  ldp      x30, x21, [sp], #0x20
006A67FCC  ret      

