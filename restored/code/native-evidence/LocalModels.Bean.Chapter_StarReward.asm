; LocalModels.Bean.Chapter_StarReward$$readImpl
; RVA 0x68B6C74; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068B6C74  stp      x30, x21, [sp, #-0x20]!
0068B6C78  stp      x20, x19, [sp, #0x10]
0068B6C7C  adrp     x20, #0x959c000
0068B6C80  adrp     x21, #0x8f27000
0068B6C84  ldrb     w8, [x20, #0x10f]
0068B6C88  ldr      x21, [x21, #0x430]
0068B6C8C  mov      x19, x0
0068B6C90  tbnz     w8, #0, #0x68b6ca8
0068B6C94  adrp     x0, #0x8f27000
0068B6C98  ldr      x0, [x0, #0x430]
0068B6C9C  bl       #0x382bd14 ; 
0068B6CA0  mov      w8, #1
0068B6CA4  strb     w8, [x20, #0x10f]
0068B6CA8  ldr      x1, [x21]
0068B6CAC  ldrb     w8, [x1, #0x53]
0068B6CB0  tbnz     w8, #5, #0x68b6d00
0068B6CB4  mov      x0, x19
0068B6CB8  mov      x1, xzr
0068B6CBC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B6CC0  adrp     x21, #0x959c000
0068B6CC4  ldrb     w8, [x21, #0x62a]
0068B6CC8  mov      w20, w0
0068B6CCC  cbnz     w8, #0x68b6ce4
0068B6CD0  adrp     x0, #0x8f27000
0068B6CD4  ldr      x0, [x0, #0x3b8]
0068B6CD8  bl       #0x382bd14 ; 
0068B6CDC  mov      w8, #1
0068B6CE0  strb     w8, [x21, #0x62a]
0068B6CE4  adrp     x8, #0x8f27000
0068B6CE8  ldr      x8, [x8, #0x3b8]
0068B6CEC  ldr      x2, [x8]
0068B6CF0  ldrb     w8, [x2, #0x53]
0068B6CF4  tbnz     w8, #5, #0x68b6d14
0068B6CF8  str      w20, [x19, #0x20]
0068B6CFC  b        #0x68b6d24 ; 
0068B6D00  ldr      x2, [x1, #0x60]
0068B6D04  mov      x0, x19
0068B6D08  ldp      x20, x19, [sp, #0x10]
0068B6D0C  ldp      x30, x21, [sp], #0x20
0068B6D10  br       x2
0068B6D14  ldr      x8, [x2, #0x60]
0068B6D18  mov      x0, x19
0068B6D1C  mov      w1, w20
0068B6D20  blr      x8
0068B6D24  mov      x0, x19
0068B6D28  mov      x1, xzr
0068B6D2C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B6D30  adrp     x21, #0x959c000
0068B6D34  ldrb     w8, [x21, #0x62b]
0068B6D38  mov      w20, w0
0068B6D3C  cbnz     w8, #0x68b6d54
0068B6D40  adrp     x0, #0x8f27000
0068B6D44  ldr      x0, [x0, #0x3c8]
0068B6D48  bl       #0x382bd14 ; 
0068B6D4C  mov      w8, #1
0068B6D50  strb     w8, [x21, #0x62b]
0068B6D54  adrp     x8, #0x8f27000
0068B6D58  ldr      x8, [x8, #0x3c8]
0068B6D5C  ldr      x2, [x8]
0068B6D60  ldrb     w8, [x2, #0x53]
0068B6D64  tbnz     w8, #5, #0x68b6d70
0068B6D68  str      w20, [x19, #0x24]
0068B6D6C  b        #0x68b6d80 ; 
0068B6D70  ldr      x8, [x2, #0x60]
0068B6D74  mov      x0, x19
0068B6D78  mov      w1, w20
0068B6D7C  blr      x8
0068B6D80  mov      x0, x19
0068B6D84  mov      x1, xzr
0068B6D88  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B6D8C  adrp     x21, #0x959c000
0068B6D90  ldrb     w8, [x21, #0x62c]
0068B6D94  mov      w20, w0
0068B6D98  cbnz     w8, #0x68b6db0
0068B6D9C  adrp     x0, #0x8f27000
0068B6DA0  ldr      x0, [x0, #0x3d8]
0068B6DA4  bl       #0x382bd14 ; 
0068B6DA8  mov      w8, #1
0068B6DAC  strb     w8, [x21, #0x62c]
0068B6DB0  adrp     x8, #0x8f27000
0068B6DB4  ldr      x8, [x8, #0x3d8]
0068B6DB8  ldr      x2, [x8]
0068B6DBC  ldrb     w8, [x2, #0x53]
0068B6DC0  tbnz     w8, #5, #0x68b6dcc
0068B6DC4  str      w20, [x19, #0x28]
0068B6DC8  b        #0x68b6ddc ; 
0068B6DCC  ldr      x8, [x2, #0x60]
0068B6DD0  mov      x0, x19
0068B6DD4  mov      w1, w20
0068B6DD8  blr      x8
0068B6DDC  mov      x0, x19
0068B6DE0  mov      x1, xzr
0068B6DE4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068B6DE8  adrp     x21, #0x959c000
0068B6DEC  ldrb     w8, [x21, #0x62d]
0068B6DF0  mov      x20, x0
0068B6DF4  cbnz     w8, #0x68b6e0c
0068B6DF8  adrp     x0, #0x8f27000
0068B6DFC  ldr      x0, [x0, #0x3e8]
0068B6E00  bl       #0x382bd14 ; 
0068B6E04  mov      w8, #1
0068B6E08  strb     w8, [x21, #0x62d]
0068B6E0C  adrp     x8, #0x8f27000
0068B6E10  ldr      x8, [x8, #0x3e8]
0068B6E14  ldr      x2, [x8]
0068B6E18  ldrb     w8, [x2, #0x53]
0068B6E1C  tbnz     w8, #5, #0x68b6e34
0068B6E20  mov      x0, x19
0068B6E24  str      x20, [x0, #0x30]!
0068B6E28  mov      x1, x20
0068B6E2C  bl       #0x382bcb8 ; 
0068B6E30  b        #0x68b6e44 ; 
0068B6E34  ldr      x8, [x2, #0x60]
0068B6E38  mov      x0, x19
0068B6E3C  mov      x1, x20
0068B6E40  blr      x8
0068B6E44  mov      x0, x19
0068B6E48  mov      x1, xzr
0068B6E4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B6E50  adrp     x21, #0x959c000
0068B6E54  ldrb     w8, [x21, #0x62e]
0068B6E58  mov      w20, w0
0068B6E5C  cbnz     w8, #0x68b6e74
0068B6E60  adrp     x0, #0x8f27000
0068B6E64  ldr      x0, [x0, #0x3f8]
0068B6E68  bl       #0x382bd14 ; 
0068B6E6C  mov      w8, #1
0068B6E70  strb     w8, [x21, #0x62e]
0068B6E74  adrp     x8, #0x8f27000
0068B6E78  ldr      x8, [x8, #0x3f8]
0068B6E7C  ldr      x2, [x8]
0068B6E80  ldrb     w8, [x2, #0x53]
0068B6E84  tbnz     w8, #5, #0x68b6e90
0068B6E88  str      w20, [x19, #0x38]
0068B6E8C  b        #0x68b6ea0 ; 
0068B6E90  ldr      x8, [x2, #0x60]
0068B6E94  mov      x0, x19
0068B6E98  mov      w1, w20
0068B6E9C  blr      x8
0068B6EA0  mov      x0, x19
0068B6EA4  mov      x1, xzr
0068B6EA8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B6EAC  adrp     x21, #0x959c000
0068B6EB0  ldrb     w8, [x21, #0x62f]
0068B6EB4  mov      w20, w0
0068B6EB8  cbnz     w8, #0x68b6ed0
0068B6EBC  adrp     x0, #0x8f27000
0068B6EC0  ldr      x0, [x0, #0x408]
0068B6EC4  bl       #0x382bd14 ; 
0068B6EC8  mov      w8, #1
0068B6ECC  strb     w8, [x21, #0x62f]
0068B6ED0  adrp     x8, #0x8f27000
0068B6ED4  ldr      x8, [x8, #0x408]
0068B6ED8  ldr      x2, [x8]
0068B6EDC  ldrb     w8, [x2, #0x53]
0068B6EE0  tbnz     w8, #5, #0x68b6eec
0068B6EE4  str      w20, [x19, #0x3c]
0068B6EE8  b        #0x68b6efc ; 
0068B6EEC  ldr      x8, [x2, #0x60]
0068B6EF0  mov      x0, x19
0068B6EF4  mov      w1, w20
0068B6EF8  blr      x8
0068B6EFC  mov      x0, x19
0068B6F00  mov      x1, xzr
0068B6F04  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
0068B6F08  adrp     x21, #0x959c000
0068B6F0C  ldrb     w8, [x21, #0x630]
0068B6F10  mov      x20, x0
0068B6F14  cbnz     w8, #0x68b6f2c
0068B6F18  adrp     x0, #0x8f27000
0068B6F1C  ldr      x0, [x0, #0x418]
0068B6F20  bl       #0x382bd14 ; 
0068B6F24  mov      w8, #1
0068B6F28  strb     w8, [x21, #0x630]
0068B6F2C  adrp     x8, #0x8f27000
0068B6F30  ldr      x8, [x8, #0x418]
0068B6F34  ldr      x2, [x8]
0068B6F38  ldrb     w8, [x2, #0x53]
0068B6F3C  tbnz     w8, #5, #0x68b6f54
0068B6F40  mov      x0, x19
0068B6F44  str      x20, [x0, #0x40]!
0068B6F48  mov      x1, x20
0068B6F4C  bl       #0x382bcb8 ; 
0068B6F50  b        #0x68b6f64 ; 
0068B6F54  ldr      x8, [x2, #0x60]
0068B6F58  mov      x0, x19
0068B6F5C  mov      x1, x20
0068B6F60  blr      x8
0068B6F64  mov      x0, x19
0068B6F68  mov      x1, xzr
0068B6F6C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068B6F70  adrp     x21, #0x959c000
0068B6F74  ldrb     w8, [x21, #0x631]
0068B6F78  mov      w20, w0
0068B6F7C  cbnz     w8, #0x68b6f94
0068B6F80  adrp     x0, #0x8f27000
0068B6F84  ldr      x0, [x0, #0x428]
0068B6F88  bl       #0x382bd14 ; 
0068B6F8C  mov      w8, #1
0068B6F90  strb     w8, [x21, #0x631]
0068B6F94  adrp     x8, #0x8f27000
0068B6F98  ldr      x8, [x8, #0x428]
0068B6F9C  ldr      x2, [x8]
0068B6FA0  ldrb     w8, [x2, #0x53]
0068B6FA4  tbnz     w8, #5, #0x68b6fb0
0068B6FA8  str      w20, [x19, #0x48]
0068B6FAC  b        #0x68b6fc0 ; 
0068B6FB0  ldr      x8, [x2, #0x60]
0068B6FB4  mov      x0, x19
0068B6FB8  mov      w1, w20
0068B6FBC  blr      x8
0068B6FC0  ldp      x20, x19, [sp, #0x10]
0068B6FC4  mov      w0, #1
0068B6FC8  ldp      x30, x21, [sp], #0x20
0068B6FCC  ret      

