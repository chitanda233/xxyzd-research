; LocalModels.Bean.IAP_Privilege$$readImpl
; RVA 0x6AA5E98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA5E98  stp      x30, x21, [sp, #-0x20]!
006AA5E9C  stp      x20, x19, [sp, #0x10]
006AA5EA0  adrp     x20, #0x959e000
006AA5EA4  adrp     x21, #0x8f39000
006AA5EA8  ldrb     w8, [x20, #0x6b6]
006AA5EAC  ldr      x21, [x21, #0xe88]
006AA5EB0  mov      x19, x0
006AA5EB4  tbnz     w8, #0, #0x6aa5ecc
006AA5EB8  adrp     x0, #0x8f39000
006AA5EBC  ldr      x0, [x0, #0xe88]
006AA5EC0  bl       #0x382bd14 ; 
006AA5EC4  mov      w8, #1
006AA5EC8  strb     w8, [x20, #0x6b6]
006AA5ECC  ldr      x1, [x21]
006AA5ED0  ldrb     w8, [x1, #0x53]
006AA5ED4  tbnz     w8, #5, #0x6aa5f24
006AA5ED8  mov      x0, x19
006AA5EDC  mov      x1, xzr
006AA5EE0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA5EE4  adrp     x21, #0x959e000
006AA5EE8  ldrb     w8, [x21, #0xef8]
006AA5EEC  mov      w20, w0
006AA5EF0  cbnz     w8, #0x6aa5f08
006AA5EF4  adrp     x0, #0x8f39000
006AA5EF8  ldr      x0, [x0, #0xe30]
006AA5EFC  bl       #0x382bd14 ; 
006AA5F00  mov      w8, #1
006AA5F04  strb     w8, [x21, #0xef8]
006AA5F08  adrp     x8, #0x8f39000
006AA5F0C  ldr      x8, [x8, #0xe30]
006AA5F10  ldr      x2, [x8]
006AA5F14  ldrb     w8, [x2, #0x53]
006AA5F18  tbnz     w8, #5, #0x6aa5f38
006AA5F1C  str      w20, [x19, #0x20]
006AA5F20  b        #0x6aa5f48 ; 
006AA5F24  ldr      x2, [x1, #0x60]
006AA5F28  mov      x0, x19
006AA5F2C  ldp      x20, x19, [sp, #0x10]
006AA5F30  ldp      x30, x21, [sp], #0x20
006AA5F34  br       x2
006AA5F38  ldr      x8, [x2, #0x60]
006AA5F3C  mov      x0, x19
006AA5F40  mov      w1, w20
006AA5F44  blr      x8
006AA5F48  mov      x0, x19
006AA5F4C  mov      x1, xzr
006AA5F50  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA5F54  adrp     x21, #0x959e000
006AA5F58  ldrb     w8, [x21, #0xef9]
006AA5F5C  mov      x20, x0
006AA5F60  cbnz     w8, #0x6aa5f78
006AA5F64  adrp     x0, #0x8f39000
006AA5F68  ldr      x0, [x0, #0xe40]
006AA5F6C  bl       #0x382bd14 ; 
006AA5F70  mov      w8, #1
006AA5F74  strb     w8, [x21, #0xef9]
006AA5F78  adrp     x8, #0x8f39000
006AA5F7C  ldr      x8, [x8, #0xe40]
006AA5F80  ldr      x2, [x8]
006AA5F84  ldrb     w8, [x2, #0x53]
006AA5F88  tbnz     w8, #5, #0x6aa5fa0
006AA5F8C  mov      x0, x19
006AA5F90  str      x20, [x0, #0x28]!
006AA5F94  mov      x1, x20
006AA5F98  bl       #0x382bcb8 ; 
006AA5F9C  b        #0x6aa5fb0 ; 
006AA5FA0  ldr      x8, [x2, #0x60]
006AA5FA4  mov      x0, x19
006AA5FA8  mov      x1, x20
006AA5FAC  blr      x8
006AA5FB0  mov      x0, x19
006AA5FB4  mov      x1, xzr
006AA5FB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA5FBC  adrp     x21, #0x959e000
006AA5FC0  ldrb     w8, [x21, #0xefa]
006AA5FC4  mov      w20, w0
006AA5FC8  cbnz     w8, #0x6aa5fe0
006AA5FCC  adrp     x0, #0x8f39000
006AA5FD0  ldr      x0, [x0, #0xe50]
006AA5FD4  bl       #0x382bd14 ; 
006AA5FD8  mov      w8, #1
006AA5FDC  strb     w8, [x21, #0xefa]
006AA5FE0  adrp     x8, #0x8f39000
006AA5FE4  ldr      x8, [x8, #0xe50]
006AA5FE8  ldr      x2, [x8]
006AA5FEC  ldrb     w8, [x2, #0x53]
006AA5FF0  tbnz     w8, #5, #0x6aa5ffc
006AA5FF4  str      w20, [x19, #0x30]
006AA5FF8  b        #0x6aa600c ; 
006AA5FFC  ldr      x8, [x2, #0x60]
006AA6000  mov      x0, x19
006AA6004  mov      w1, w20
006AA6008  blr      x8
006AA600C  mov      x0, x19
006AA6010  mov      x1, xzr
006AA6014  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA6018  adrp     x21, #0x959e000
006AA601C  ldrb     w8, [x21, #0xefb]
006AA6020  mov      w20, w0
006AA6024  cbnz     w8, #0x6aa603c
006AA6028  adrp     x0, #0x8f39000
006AA602C  ldr      x0, [x0, #0xe60]
006AA6030  bl       #0x382bd14 ; 
006AA6034  mov      w8, #1
006AA6038  strb     w8, [x21, #0xefb]
006AA603C  adrp     x8, #0x8f39000
006AA6040  ldr      x8, [x8, #0xe60]
006AA6044  ldr      x2, [x8]
006AA6048  ldrb     w8, [x2, #0x53]
006AA604C  tbnz     w8, #5, #0x6aa6058
006AA6050  str      w20, [x19, #0x34]
006AA6054  b        #0x6aa6068 ; 
006AA6058  ldr      x8, [x2, #0x60]
006AA605C  mov      x0, x19
006AA6060  mov      w1, w20
006AA6064  blr      x8
006AA6068  mov      x0, x19
006AA606C  mov      x1, xzr
006AA6070  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA6074  adrp     x21, #0x959e000
006AA6078  ldrb     w8, [x21, #0xefc]
006AA607C  mov      w20, w0
006AA6080  cbnz     w8, #0x6aa6098
006AA6084  adrp     x0, #0x8f39000
006AA6088  ldr      x0, [x0, #0xe70]
006AA608C  bl       #0x382bd14 ; 
006AA6090  mov      w8, #1
006AA6094  strb     w8, [x21, #0xefc]
006AA6098  adrp     x8, #0x8f39000
006AA609C  ldr      x8, [x8, #0xe70]
006AA60A0  ldr      x2, [x8]
006AA60A4  ldrb     w8, [x2, #0x53]
006AA60A8  tbnz     w8, #5, #0x6aa60b4
006AA60AC  str      w20, [x19, #0x38]
006AA60B0  b        #0x6aa60c4 ; 
006AA60B4  ldr      x8, [x2, #0x60]
006AA60B8  mov      x0, x19
006AA60BC  mov      w1, w20
006AA60C0  blr      x8
006AA60C4  mov      x0, x19
006AA60C8  mov      x1, xzr
006AA60CC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA60D0  adrp     x21, #0x959e000
006AA60D4  ldrb     w8, [x21, #0xefd]
006AA60D8  mov      x20, x0
006AA60DC  cbnz     w8, #0x6aa60f4
006AA60E0  adrp     x0, #0x8f39000
006AA60E4  ldr      x0, [x0, #0xe80]
006AA60E8  bl       #0x382bd14 ; 
006AA60EC  mov      w8, #1
006AA60F0  strb     w8, [x21, #0xefd]
006AA60F4  adrp     x8, #0x8f39000
006AA60F8  ldr      x8, [x8, #0xe80]
006AA60FC  ldr      x2, [x8]
006AA6100  ldrb     w8, [x2, #0x53]
006AA6104  tbnz     w8, #5, #0x6aa611c
006AA6108  str      x20, [x19, #0x40]!
006AA610C  mov      x0, x19
006AA6110  mov      x1, x20
006AA6114  bl       #0x382bcb8 ; 
006AA6118  b        #0x6aa612c ; 
006AA611C  ldr      x8, [x2, #0x60]
006AA6120  mov      x0, x19
006AA6124  mov      x1, x20
006AA6128  blr      x8
006AA612C  ldp      x20, x19, [sp, #0x10]
006AA6130  mov      w0, #1
006AA6134  ldp      x30, x21, [sp], #0x20
006AA6138  ret      

