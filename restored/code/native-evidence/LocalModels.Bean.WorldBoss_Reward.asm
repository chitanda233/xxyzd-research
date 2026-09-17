; LocalModels.Bean.WorldBoss_Reward$$readImpl
; RVA 0x6B24DDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B24DDC  stp      x30, x21, [sp, #-0x20]!
006B24DE0  stp      x20, x19, [sp, #0x10]
006B24DE4  adrp     x20, #0x959f000
006B24DE8  adrp     x21, #0x8f3f000
006B24DEC  ldrb     w8, [x20, #0x754]
006B24DF0  ldr      x21, [x21, #0xaf8]
006B24DF4  mov      x19, x0
006B24DF8  tbnz     w8, #0, #0x6b24e10
006B24DFC  adrp     x0, #0x8f3f000
006B24E00  ldr      x0, [x0, #0xaf8]
006B24E04  bl       #0x382bd14 ; 
006B24E08  mov      w8, #1
006B24E0C  strb     w8, [x20, #0x754]
006B24E10  ldr      x1, [x21]
006B24E14  ldrb     w8, [x1, #0x53]
006B24E18  tbnz     w8, #5, #0x6b24e68
006B24E1C  mov      x0, x19
006B24E20  mov      x1, xzr
006B24E24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B24E28  adrp     x21, #0x959f000
006B24E2C  ldrb     w8, [x21, #0xa87]
006B24E30  mov      w20, w0
006B24E34  cbnz     w8, #0x6b24e4c
006B24E38  adrp     x0, #0x8f3f000
006B24E3C  ldr      x0, [x0, #0xac0]
006B24E40  bl       #0x382bd14 ; 
006B24E44  mov      w8, #1
006B24E48  strb     w8, [x21, #0xa87]
006B24E4C  adrp     x8, #0x8f3f000
006B24E50  ldr      x8, [x8, #0xac0]
006B24E54  ldr      x2, [x8]
006B24E58  ldrb     w8, [x2, #0x53]
006B24E5C  tbnz     w8, #5, #0x6b24e7c
006B24E60  str      w20, [x19, #0x20]
006B24E64  b        #0x6b24e8c ; 
006B24E68  ldr      x2, [x1, #0x60]
006B24E6C  mov      x0, x19
006B24E70  ldp      x20, x19, [sp, #0x10]
006B24E74  ldp      x30, x21, [sp], #0x20
006B24E78  br       x2
006B24E7C  ldr      x8, [x2, #0x60]
006B24E80  mov      x0, x19
006B24E84  mov      w1, w20
006B24E88  blr      x8
006B24E8C  mov      x0, x19
006B24E90  mov      x1, xzr
006B24E94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B24E98  adrp     x21, #0x959f000
006B24E9C  ldrb     w8, [x21, #0xa88]
006B24EA0  mov      w20, w0
006B24EA4  cbnz     w8, #0x6b24ebc
006B24EA8  adrp     x0, #0x8f3f000
006B24EAC  ldr      x0, [x0, #0xad0]
006B24EB0  bl       #0x382bd14 ; 
006B24EB4  mov      w8, #1
006B24EB8  strb     w8, [x21, #0xa88]
006B24EBC  adrp     x8, #0x8f3f000
006B24EC0  ldr      x8, [x8, #0xad0]
006B24EC4  ldr      x2, [x8]
006B24EC8  ldrb     w8, [x2, #0x53]
006B24ECC  tbnz     w8, #5, #0x6b24ed8
006B24ED0  str      w20, [x19, #0x24]
006B24ED4  b        #0x6b24ee8 ; 
006B24ED8  ldr      x8, [x2, #0x60]
006B24EDC  mov      x0, x19
006B24EE0  mov      w1, w20
006B24EE4  blr      x8
006B24EE8  mov      x0, x19
006B24EEC  mov      x1, xzr
006B24EF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B24EF4  adrp     x21, #0x959f000
006B24EF8  ldrb     w8, [x21, #0xa89]
006B24EFC  mov      w20, w0
006B24F00  cbnz     w8, #0x6b24f18
006B24F04  adrp     x0, #0x8f3f000
006B24F08  ldr      x0, [x0, #0xae0]
006B24F0C  bl       #0x382bd14 ; 
006B24F10  mov      w8, #1
006B24F14  strb     w8, [x21, #0xa89]
006B24F18  adrp     x8, #0x8f3f000
006B24F1C  ldr      x8, [x8, #0xae0]
006B24F20  ldr      x2, [x8]
006B24F24  ldrb     w8, [x2, #0x53]
006B24F28  tbnz     w8, #5, #0x6b24f34
006B24F2C  str      w20, [x19, #0x28]
006B24F30  b        #0x6b24f44 ; 
006B24F34  ldr      x8, [x2, #0x60]
006B24F38  mov      x0, x19
006B24F3C  mov      w1, w20
006B24F40  blr      x8
006B24F44  mov      x0, x19
006B24F48  mov      x1, xzr
006B24F4C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B24F50  adrp     x21, #0x959f000
006B24F54  ldrb     w8, [x21, #0xa8a]
006B24F58  mov      x20, x0
006B24F5C  cbnz     w8, #0x6b24f74
006B24F60  adrp     x0, #0x8f3f000
006B24F64  ldr      x0, [x0, #0xaf0]
006B24F68  bl       #0x382bd14 ; 
006B24F6C  mov      w8, #1
006B24F70  strb     w8, [x21, #0xa8a]
006B24F74  adrp     x8, #0x8f3f000
006B24F78  ldr      x8, [x8, #0xaf0]
006B24F7C  ldr      x2, [x8]
006B24F80  ldrb     w8, [x2, #0x53]
006B24F84  tbnz     w8, #5, #0x6b24f9c
006B24F88  str      x20, [x19, #0x30]!
006B24F8C  mov      x0, x19
006B24F90  mov      x1, x20
006B24F94  bl       #0x382bcb8 ; 
006B24F98  b        #0x6b24fac ; 
006B24F9C  ldr      x8, [x2, #0x60]
006B24FA0  mov      x0, x19
006B24FA4  mov      x1, x20
006B24FA8  blr      x8
006B24FAC  ldp      x20, x19, [sp, #0x10]
006B24FB0  mov      w0, #1
006B24FB4  ldp      x30, x21, [sp], #0x20
006B24FB8  ret      

