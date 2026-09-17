; LocalModels.Bean.Tips_Tips$$readImpl
; RVA 0x6B16DF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B16DF8  stp      x30, x21, [sp, #-0x20]!
006B16DFC  stp      x20, x19, [sp, #0x10]
006B16E00  adrp     x20, #0x959f000
006B16E04  adrp     x21, #0x8f3f000
006B16E08  ldrb     w8, [x20, #0x5e5]
006B16E0C  ldr      x21, [x21, #0x158]
006B16E10  mov      x19, x0
006B16E14  tbnz     w8, #0, #0x6b16e2c
006B16E18  adrp     x0, #0x8f3f000
006B16E1C  ldr      x0, [x0, #0x158]
006B16E20  bl       #0x382bd14 ; 
006B16E24  mov      w8, #1
006B16E28  strb     w8, [x20, #0x5e5]
006B16E2C  ldr      x1, [x21]
006B16E30  ldrb     w8, [x1, #0x53]
006B16E34  tbnz     w8, #5, #0x6b16e84
006B16E38  mov      x0, x19
006B16E3C  mov      x1, xzr
006B16E40  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B16E44  adrp     x21, #0x959f000
006B16E48  ldrb     w8, [x21, #0x9e9]
006B16E4C  mov      w20, w0
006B16E50  cbnz     w8, #0x6b16e68
006B16E54  adrp     x0, #0x8f3f000
006B16E58  ldr      x0, [x0, #0x100]
006B16E5C  bl       #0x382bd14 ; 
006B16E60  mov      w8, #1
006B16E64  strb     w8, [x21, #0x9e9]
006B16E68  adrp     x8, #0x8f3f000
006B16E6C  ldr      x8, [x8, #0x100]
006B16E70  ldr      x2, [x8]
006B16E74  ldrb     w8, [x2, #0x53]
006B16E78  tbnz     w8, #5, #0x6b16e98
006B16E7C  str      w20, [x19, #0x20]
006B16E80  b        #0x6b16ea8 ; 
006B16E84  ldr      x2, [x1, #0x60]
006B16E88  mov      x0, x19
006B16E8C  ldp      x20, x19, [sp, #0x10]
006B16E90  ldp      x30, x21, [sp], #0x20
006B16E94  br       x2
006B16E98  ldr      x8, [x2, #0x60]
006B16E9C  mov      x0, x19
006B16EA0  mov      w1, w20
006B16EA4  blr      x8
006B16EA8  mov      x0, x19
006B16EAC  mov      x1, xzr
006B16EB0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B16EB4  adrp     x21, #0x959f000
006B16EB8  ldrb     w8, [x21, #0x9ea]
006B16EBC  mov      x20, x0
006B16EC0  cbnz     w8, #0x6b16ed8
006B16EC4  adrp     x0, #0x8f3f000
006B16EC8  ldr      x0, [x0, #0x110]
006B16ECC  bl       #0x382bd14 ; 
006B16ED0  mov      w8, #1
006B16ED4  strb     w8, [x21, #0x9ea]
006B16ED8  adrp     x8, #0x8f3f000
006B16EDC  ldr      x8, [x8, #0x110]
006B16EE0  ldr      x2, [x8]
006B16EE4  ldrb     w8, [x2, #0x53]
006B16EE8  tbnz     w8, #5, #0x6b16f00
006B16EEC  mov      x0, x19
006B16EF0  str      x20, [x0, #0x28]!
006B16EF4  mov      x1, x20
006B16EF8  bl       #0x382bcb8 ; 
006B16EFC  b        #0x6b16f10 ; 
006B16F00  ldr      x8, [x2, #0x60]
006B16F04  mov      x0, x19
006B16F08  mov      x1, x20
006B16F0C  blr      x8
006B16F10  mov      x0, x19
006B16F14  mov      x1, xzr
006B16F18  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B16F1C  adrp     x21, #0x959f000
006B16F20  ldrb     w8, [x21, #0x9eb]
006B16F24  mov      x20, x0
006B16F28  cbnz     w8, #0x6b16f40
006B16F2C  adrp     x0, #0x8f3f000
006B16F30  ldr      x0, [x0, #0x120]
006B16F34  bl       #0x382bd14 ; 
006B16F38  mov      w8, #1
006B16F3C  strb     w8, [x21, #0x9eb]
006B16F40  adrp     x8, #0x8f3f000
006B16F44  ldr      x8, [x8, #0x120]
006B16F48  ldr      x2, [x8]
006B16F4C  ldrb     w8, [x2, #0x53]
006B16F50  tbnz     w8, #5, #0x6b16f68
006B16F54  mov      x0, x19
006B16F58  str      x20, [x0, #0x30]!
006B16F5C  mov      x1, x20
006B16F60  bl       #0x382bcb8 ; 
006B16F64  b        #0x6b16f78 ; 
006B16F68  ldr      x8, [x2, #0x60]
006B16F6C  mov      x0, x19
006B16F70  mov      x1, x20
006B16F74  blr      x8
006B16F78  mov      x0, x19
006B16F7C  mov      x1, xzr
006B16F80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B16F84  adrp     x21, #0x959f000
006B16F88  ldrb     w8, [x21, #0x9ec]
006B16F8C  mov      w20, w0
006B16F90  cbnz     w8, #0x6b16fa8
006B16F94  adrp     x0, #0x8f3f000
006B16F98  ldr      x0, [x0, #0x130]
006B16F9C  bl       #0x382bd14 ; 
006B16FA0  mov      w8, #1
006B16FA4  strb     w8, [x21, #0x9ec]
006B16FA8  adrp     x8, #0x8f3f000
006B16FAC  ldr      x8, [x8, #0x130]
006B16FB0  ldr      x2, [x8]
006B16FB4  ldrb     w8, [x2, #0x53]
006B16FB8  tbnz     w8, #5, #0x6b16fc4
006B16FBC  str      w20, [x19, #0x38]
006B16FC0  b        #0x6b16fd4 ; 
006B16FC4  ldr      x8, [x2, #0x60]
006B16FC8  mov      x0, x19
006B16FCC  mov      w1, w20
006B16FD0  blr      x8
006B16FD4  mov      x0, x19
006B16FD8  mov      x1, xzr
006B16FDC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B16FE0  adrp     x21, #0x959f000
006B16FE4  ldrb     w8, [x21, #0x9ed]
006B16FE8  mov      x20, x0
006B16FEC  cbnz     w8, #0x6b17004
006B16FF0  adrp     x0, #0x8f3f000
006B16FF4  ldr      x0, [x0, #0x140]
006B16FF8  bl       #0x382bd14 ; 
006B16FFC  mov      w8, #1
006B17000  strb     w8, [x21, #0x9ed]
006B17004  adrp     x8, #0x8f3f000
006B17008  ldr      x8, [x8, #0x140]
006B1700C  ldr      x2, [x8]
006B17010  ldrb     w8, [x2, #0x53]
006B17014  tbnz     w8, #5, #0x6b1702c
006B17018  mov      x0, x19
006B1701C  str      x20, [x0, #0x40]!
006B17020  mov      x1, x20
006B17024  bl       #0x382bcb8 ; 
006B17028  b        #0x6b1703c ; 
006B1702C  ldr      x8, [x2, #0x60]
006B17030  mov      x0, x19
006B17034  mov      x1, x20
006B17038  blr      x8
006B1703C  mov      x0, x19
006B17040  mov      x1, xzr
006B17044  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B17048  adrp     x21, #0x959f000
006B1704C  ldrb     w8, [x21, #0x9ee]
006B17050  mov      x20, x0
006B17054  cbnz     w8, #0x6b1706c
006B17058  adrp     x0, #0x8f3f000
006B1705C  ldr      x0, [x0, #0x150]
006B17060  bl       #0x382bd14 ; 
006B17064  mov      w8, #1
006B17068  strb     w8, [x21, #0x9ee]
006B1706C  adrp     x8, #0x8f3f000
006B17070  ldr      x8, [x8, #0x150]
006B17074  ldr      x2, [x8]
006B17078  ldrb     w8, [x2, #0x53]
006B1707C  tbnz     w8, #5, #0x6b17094
006B17080  str      x20, [x19, #0x48]!
006B17084  mov      x0, x19
006B17088  mov      x1, x20
006B1708C  bl       #0x382bcb8 ; 
006B17090  b        #0x6b170a4 ; 
006B17094  ldr      x8, [x2, #0x60]
006B17098  mov      x0, x19
006B1709C  mov      x1, x20
006B170A0  blr      x8
006B170A4  ldp      x20, x19, [sp, #0x10]
006B170A8  mov      w0, #1
006B170AC  ldp      x30, x21, [sp], #0x20
006B170B0  ret      

