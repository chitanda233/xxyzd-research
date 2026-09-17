; LocalModels.Bean.WorldBoss_RankReward$$readImpl
; RVA 0x6B23C8C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B23C8C  stp      x30, x21, [sp, #-0x20]!
006B23C90  stp      x20, x19, [sp, #0x10]
006B23C94  adrp     x20, #0x959f000
006B23C98  adrp     x21, #0x8f3f000
006B23C9C  ldrb     w8, [x20, #0x738]
006B23CA0  ldr      x21, [x21, #0xa28]
006B23CA4  mov      x19, x0
006B23CA8  tbnz     w8, #0, #0x6b23cc0
006B23CAC  adrp     x0, #0x8f3f000
006B23CB0  ldr      x0, [x0, #0xa28]
006B23CB4  bl       #0x382bd14 ; 
006B23CB8  mov      w8, #1
006B23CBC  strb     w8, [x20, #0x738]
006B23CC0  ldr      x1, [x21]
006B23CC4  ldrb     w8, [x1, #0x53]
006B23CC8  tbnz     w8, #5, #0x6b23d18
006B23CCC  mov      x0, x19
006B23CD0  mov      x1, xzr
006B23CD4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B23CD8  adrp     x21, #0x959f000
006B23CDC  ldrb     w8, [x21, #0xa7a]
006B23CE0  mov      w20, w0
006B23CE4  cbnz     w8, #0x6b23cfc
006B23CE8  adrp     x0, #0x8f3f000
006B23CEC  ldr      x0, [x0, #0x9d0]
006B23CF0  bl       #0x382bd14 ; 
006B23CF4  mov      w8, #1
006B23CF8  strb     w8, [x21, #0xa7a]
006B23CFC  adrp     x8, #0x8f3f000
006B23D00  ldr      x8, [x8, #0x9d0]
006B23D04  ldr      x2, [x8]
006B23D08  ldrb     w8, [x2, #0x53]
006B23D0C  tbnz     w8, #5, #0x6b23d2c
006B23D10  str      w20, [x19, #0x20]
006B23D14  b        #0x6b23d3c ; 
006B23D18  ldr      x2, [x1, #0x60]
006B23D1C  mov      x0, x19
006B23D20  ldp      x20, x19, [sp, #0x10]
006B23D24  ldp      x30, x21, [sp], #0x20
006B23D28  br       x2
006B23D2C  ldr      x8, [x2, #0x60]
006B23D30  mov      x0, x19
006B23D34  mov      w1, w20
006B23D38  blr      x8
006B23D3C  mov      x0, x19
006B23D40  mov      x1, xzr
006B23D44  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B23D48  adrp     x21, #0x959f000
006B23D4C  ldrb     w8, [x21, #0xa7b]
006B23D50  mov      w20, w0
006B23D54  cbnz     w8, #0x6b23d6c
006B23D58  adrp     x0, #0x8f3f000
006B23D5C  ldr      x0, [x0, #0x9e0]
006B23D60  bl       #0x382bd14 ; 
006B23D64  mov      w8, #1
006B23D68  strb     w8, [x21, #0xa7b]
006B23D6C  adrp     x8, #0x8f3f000
006B23D70  ldr      x8, [x8, #0x9e0]
006B23D74  ldr      x2, [x8]
006B23D78  ldrb     w8, [x2, #0x53]
006B23D7C  tbnz     w8, #5, #0x6b23d88
006B23D80  str      w20, [x19, #0x24]
006B23D84  b        #0x6b23d98 ; 
006B23D88  ldr      x8, [x2, #0x60]
006B23D8C  mov      x0, x19
006B23D90  mov      w1, w20
006B23D94  blr      x8
006B23D98  mov      x0, x19
006B23D9C  mov      x1, xzr
006B23DA0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B23DA4  adrp     x21, #0x959f000
006B23DA8  ldrb     w8, [x21, #0xa7c]
006B23DAC  mov      w20, w0
006B23DB0  cbnz     w8, #0x6b23dc8
006B23DB4  adrp     x0, #0x8f3f000
006B23DB8  ldr      x0, [x0, #0x9f0]
006B23DBC  bl       #0x382bd14 ; 
006B23DC0  mov      w8, #1
006B23DC4  strb     w8, [x21, #0xa7c]
006B23DC8  adrp     x8, #0x8f3f000
006B23DCC  ldr      x8, [x8, #0x9f0]
006B23DD0  ldr      x2, [x8]
006B23DD4  ldrb     w8, [x2, #0x53]
006B23DD8  tbnz     w8, #5, #0x6b23de4
006B23DDC  str      w20, [x19, #0x28]
006B23DE0  b        #0x6b23df4 ; 
006B23DE4  ldr      x8, [x2, #0x60]
006B23DE8  mov      x0, x19
006B23DEC  mov      w1, w20
006B23DF0  blr      x8
006B23DF4  mov      x0, x19
006B23DF8  mov      x1, xzr
006B23DFC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B23E00  adrp     x21, #0x959f000
006B23E04  ldrb     w8, [x21, #0xa7d]
006B23E08  mov      x20, x0
006B23E0C  cbnz     w8, #0x6b23e24
006B23E10  adrp     x0, #0x8f3f000
006B23E14  ldr      x0, [x0, #0xa00]
006B23E18  bl       #0x382bd14 ; 
006B23E1C  mov      w8, #1
006B23E20  strb     w8, [x21, #0xa7d]
006B23E24  adrp     x8, #0x8f3f000
006B23E28  ldr      x8, [x8, #0xa00]
006B23E2C  ldr      x2, [x8]
006B23E30  ldrb     w8, [x2, #0x53]
006B23E34  tbnz     w8, #5, #0x6b23e4c
006B23E38  mov      x0, x19
006B23E3C  str      x20, [x0, #0x30]!
006B23E40  mov      x1, x20
006B23E44  bl       #0x382bcb8 ; 
006B23E48  b        #0x6b23e5c ; 
006B23E4C  ldr      x8, [x2, #0x60]
006B23E50  mov      x0, x19
006B23E54  mov      x1, x20
006B23E58  blr      x8
006B23E5C  mov      x0, x19
006B23E60  mov      x1, xzr
006B23E64  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B23E68  adrp     x21, #0x959f000
006B23E6C  ldrb     w8, [x21, #0xa7e]
006B23E70  mov      x20, x0
006B23E74  cbnz     w8, #0x6b23e8c
006B23E78  adrp     x0, #0x8f3f000
006B23E7C  ldr      x0, [x0, #0xa10]
006B23E80  bl       #0x382bd14 ; 
006B23E84  mov      w8, #1
006B23E88  strb     w8, [x21, #0xa7e]
006B23E8C  adrp     x8, #0x8f3f000
006B23E90  ldr      x8, [x8, #0xa10]
006B23E94  ldr      x2, [x8]
006B23E98  ldrb     w8, [x2, #0x53]
006B23E9C  tbnz     w8, #5, #0x6b23eb4
006B23EA0  mov      x0, x19
006B23EA4  str      x20, [x0, #0x38]!
006B23EA8  mov      x1, x20
006B23EAC  bl       #0x382bcb8 ; 
006B23EB0  b        #0x6b23ec4 ; 
006B23EB4  ldr      x8, [x2, #0x60]
006B23EB8  mov      x0, x19
006B23EBC  mov      x1, x20
006B23EC0  blr      x8
006B23EC4  mov      x0, x19
006B23EC8  mov      x1, xzr
006B23ECC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B23ED0  adrp     x21, #0x959f000
006B23ED4  ldrb     w8, [x21, #0xa7f]
006B23ED8  mov      x20, x0
006B23EDC  cbnz     w8, #0x6b23ef4
006B23EE0  adrp     x0, #0x8f3f000
006B23EE4  ldr      x0, [x0, #0xa20]
006B23EE8  bl       #0x382bd14 ; 
006B23EEC  mov      w8, #1
006B23EF0  strb     w8, [x21, #0xa7f]
006B23EF4  adrp     x8, #0x8f3f000
006B23EF8  ldr      x8, [x8, #0xa20]
006B23EFC  ldr      x2, [x8]
006B23F00  ldrb     w8, [x2, #0x53]
006B23F04  tbnz     w8, #5, #0x6b23f1c
006B23F08  str      x20, [x19, #0x40]!
006B23F0C  mov      x0, x19
006B23F10  mov      x1, x20
006B23F14  bl       #0x382bcb8 ; 
006B23F18  b        #0x6b23f2c ; 
006B23F1C  ldr      x8, [x2, #0x60]
006B23F20  mov      x0, x19
006B23F24  mov      x1, x20
006B23F28  blr      x8
006B23F2C  ldp      x20, x19, [sp, #0x10]
006B23F30  mov      w0, #1
006B23F34  ldp      x30, x21, [sp], #0x20
006B23F38  ret      

