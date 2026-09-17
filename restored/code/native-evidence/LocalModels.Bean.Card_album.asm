; LocalModels.Bean.Card_album$$readImpl
; RVA 0x6893D80; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006893D80  stp      x30, x21, [sp, #-0x20]!
006893D84  stp      x20, x19, [sp, #0x10]
006893D88  adrp     x20, #0x959b000
006893D8C  adrp     x21, #0x8f25000
006893D90  ldrb     w8, [x20, #0xd7e]
006893D94  ldr      x21, [x21, #0x9b0]
006893D98  mov      x19, x0
006893D9C  tbnz     w8, #0, #0x6893db4
006893DA0  adrp     x0, #0x8f25000
006893DA4  ldr      x0, [x0, #0x9b0]
006893DA8  bl       #0x382bd14 ; 
006893DAC  mov      w8, #1
006893DB0  strb     w8, [x20, #0xd7e]
006893DB4  ldr      x1, [x21]
006893DB8  ldrb     w8, [x1, #0x53]
006893DBC  tbnz     w8, #5, #0x6893e0c
006893DC0  mov      x0, x19
006893DC4  mov      x1, xzr
006893DC8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006893DCC  adrp     x21, #0x959c000
006893DD0  ldrb     w8, [x21, #0x487]
006893DD4  mov      w20, w0
006893DD8  cbnz     w8, #0x6893df0
006893DDC  adrp     x0, #0x8f25000
006893DE0  ldr      x0, [x0, #0x958]
006893DE4  bl       #0x382bd14 ; 
006893DE8  mov      w8, #1
006893DEC  strb     w8, [x21, #0x487]
006893DF0  adrp     x8, #0x8f25000
006893DF4  ldr      x8, [x8, #0x958]
006893DF8  ldr      x2, [x8]
006893DFC  ldrb     w8, [x2, #0x53]
006893E00  tbnz     w8, #5, #0x6893e20
006893E04  str      w20, [x19, #0x20]
006893E08  b        #0x6893e30 ; 
006893E0C  ldr      x2, [x1, #0x60]
006893E10  mov      x0, x19
006893E14  ldp      x20, x19, [sp, #0x10]
006893E18  ldp      x30, x21, [sp], #0x20
006893E1C  br       x2
006893E20  ldr      x8, [x2, #0x60]
006893E24  mov      x0, x19
006893E28  mov      w1, w20
006893E2C  blr      x8
006893E30  mov      x0, x19
006893E34  mov      x1, xzr
006893E38  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006893E3C  adrp     x21, #0x959c000
006893E40  ldrb     w8, [x21, #0x488]
006893E44  mov      w20, w0
006893E48  cbnz     w8, #0x6893e60
006893E4C  adrp     x0, #0x8f25000
006893E50  ldr      x0, [x0, #0x968]
006893E54  bl       #0x382bd14 ; 
006893E58  mov      w8, #1
006893E5C  strb     w8, [x21, #0x488]
006893E60  adrp     x8, #0x8f25000
006893E64  ldr      x8, [x8, #0x968]
006893E68  ldr      x2, [x8]
006893E6C  ldrb     w8, [x2, #0x53]
006893E70  tbnz     w8, #5, #0x6893e7c
006893E74  str      w20, [x19, #0x24]
006893E78  b        #0x6893e8c ; 
006893E7C  ldr      x8, [x2, #0x60]
006893E80  mov      x0, x19
006893E84  mov      w1, w20
006893E88  blr      x8
006893E8C  mov      x0, x19
006893E90  mov      x1, xzr
006893E94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006893E98  adrp     x21, #0x959c000
006893E9C  ldrb     w8, [x21, #0x489]
006893EA0  mov      w20, w0
006893EA4  cbnz     w8, #0x6893ebc
006893EA8  adrp     x0, #0x8f25000
006893EAC  ldr      x0, [x0, #0x978]
006893EB0  bl       #0x382bd14 ; 
006893EB4  mov      w8, #1
006893EB8  strb     w8, [x21, #0x489]
006893EBC  adrp     x8, #0x8f25000
006893EC0  ldr      x8, [x8, #0x978]
006893EC4  ldr      x2, [x8]
006893EC8  ldrb     w8, [x2, #0x53]
006893ECC  tbnz     w8, #5, #0x6893ed8
006893ED0  str      w20, [x19, #0x28]
006893ED4  b        #0x6893ee8 ; 
006893ED8  ldr      x8, [x2, #0x60]
006893EDC  mov      x0, x19
006893EE0  mov      w1, w20
006893EE4  blr      x8
006893EE8  mov      x0, x19
006893EEC  mov      x1, xzr
006893EF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006893EF4  adrp     x21, #0x959c000
006893EF8  ldrb     w8, [x21, #0x48a]
006893EFC  mov      w20, w0
006893F00  cbnz     w8, #0x6893f18
006893F04  adrp     x0, #0x8f25000
006893F08  ldr      x0, [x0, #0x988]
006893F0C  bl       #0x382bd14 ; 
006893F10  mov      w8, #1
006893F14  strb     w8, [x21, #0x48a]
006893F18  adrp     x8, #0x8f25000
006893F1C  ldr      x8, [x8, #0x988]
006893F20  ldr      x2, [x8]
006893F24  ldrb     w8, [x2, #0x53]
006893F28  tbnz     w8, #5, #0x6893f34
006893F2C  str      w20, [x19, #0x2c]
006893F30  b        #0x6893f44 ; 
006893F34  ldr      x8, [x2, #0x60]
006893F38  mov      x0, x19
006893F3C  mov      w1, w20
006893F40  blr      x8
006893F44  mov      x0, x19
006893F48  mov      x1, xzr
006893F4C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006893F50  adrp     x21, #0x959c000
006893F54  ldrb     w8, [x21, #0x48b]
006893F58  mov      x20, x0
006893F5C  cbnz     w8, #0x6893f74
006893F60  adrp     x0, #0x8f25000
006893F64  ldr      x0, [x0, #0x998]
006893F68  bl       #0x382bd14 ; 
006893F6C  mov      w8, #1
006893F70  strb     w8, [x21, #0x48b]
006893F74  adrp     x8, #0x8f25000
006893F78  ldr      x8, [x8, #0x998]
006893F7C  ldr      x2, [x8]
006893F80  ldrb     w8, [x2, #0x53]
006893F84  tbnz     w8, #5, #0x6893f9c
006893F88  mov      x0, x19
006893F8C  str      x20, [x0, #0x30]!
006893F90  mov      x1, x20
006893F94  bl       #0x382bcb8 ; 
006893F98  b        #0x6893fac ; 
006893F9C  ldr      x8, [x2, #0x60]
006893FA0  mov      x0, x19
006893FA4  mov      x1, x20
006893FA8  blr      x8
006893FAC  mov      x0, x19
006893FB0  mov      x1, xzr
006893FB4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006893FB8  adrp     x21, #0x959c000
006893FBC  ldrb     w8, [x21, #0x48c]
006893FC0  mov      x20, x0
006893FC4  cbnz     w8, #0x6893fdc
006893FC8  adrp     x0, #0x8f25000
006893FCC  ldr      x0, [x0, #0x9a8]
006893FD0  bl       #0x382bd14 ; 
006893FD4  mov      w8, #1
006893FD8  strb     w8, [x21, #0x48c]
006893FDC  adrp     x8, #0x8f25000
006893FE0  ldr      x8, [x8, #0x9a8]
006893FE4  ldr      x2, [x8]
006893FE8  ldrb     w8, [x2, #0x53]
006893FEC  tbnz     w8, #5, #0x6894004
006893FF0  str      x20, [x19, #0x38]!
006893FF4  mov      x0, x19
006893FF8  mov      x1, x20
006893FFC  bl       #0x382bcb8 ; 
006894000  b        #0x6894014 ; 
006894004  ldr      x8, [x2, #0x60]
006894008  mov      x0, x19
00689400C  mov      x1, x20
006894010  blr      x8
006894014  ldp      x20, x19, [sp, #0x10]
006894018  mov      w0, #1
00689401C  ldp      x30, x21, [sp], #0x20
006894020  ret      

