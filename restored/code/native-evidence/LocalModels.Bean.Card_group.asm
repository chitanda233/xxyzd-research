; LocalModels.Bean.Card_group$$readImpl
; RVA 0x6896E20; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006896E20  stp      x30, x21, [sp, #-0x20]!
006896E24  stp      x20, x19, [sp, #0x10]
006896E28  adrp     x20, #0x959b000
006896E2C  adrp     x21, #0x8f25000
006896E30  ldrb     w8, [x20, #0xdcf]
006896E34  ldr      x21, [x21, #0xc10]
006896E38  mov      x19, x0
006896E3C  tbnz     w8, #0, #0x6896e54
006896E40  adrp     x0, #0x8f25000
006896E44  ldr      x0, [x0, #0xc10]
006896E48  bl       #0x382bd14 ; 
006896E4C  mov      w8, #1
006896E50  strb     w8, [x20, #0xdcf]
006896E54  ldr      x1, [x21]
006896E58  ldrb     w8, [x1, #0x53]
006896E5C  tbnz     w8, #5, #0x6896eac
006896E60  mov      x0, x19
006896E64  mov      x1, xzr
006896E68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006896E6C  adrp     x21, #0x959c000
006896E70  ldrb     w8, [x21, #0x4a9]
006896E74  mov      w20, w0
006896E78  cbnz     w8, #0x6896e90
006896E7C  adrp     x0, #0x8f25000
006896E80  ldr      x0, [x0, #0xbc8]
006896E84  bl       #0x382bd14 ; 
006896E88  mov      w8, #1
006896E8C  strb     w8, [x21, #0x4a9]
006896E90  adrp     x8, #0x8f25000
006896E94  ldr      x8, [x8, #0xbc8]
006896E98  ldr      x2, [x8]
006896E9C  ldrb     w8, [x2, #0x53]
006896EA0  tbnz     w8, #5, #0x6896ec0
006896EA4  str      w20, [x19, #0x20]
006896EA8  b        #0x6896ed0 ; 
006896EAC  ldr      x2, [x1, #0x60]
006896EB0  mov      x0, x19
006896EB4  ldp      x20, x19, [sp, #0x10]
006896EB8  ldp      x30, x21, [sp], #0x20
006896EBC  br       x2
006896EC0  ldr      x8, [x2, #0x60]
006896EC4  mov      x0, x19
006896EC8  mov      w1, w20
006896ECC  blr      x8
006896ED0  mov      x0, x19
006896ED4  mov      x1, xzr
006896ED8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006896EDC  adrp     x21, #0x959c000
006896EE0  ldrb     w8, [x21, #0x4aa]
006896EE4  mov      w20, w0
006896EE8  cbnz     w8, #0x6896f00
006896EEC  adrp     x0, #0x8f25000
006896EF0  ldr      x0, [x0, #0xbd8]
006896EF4  bl       #0x382bd14 ; 
006896EF8  mov      w8, #1
006896EFC  strb     w8, [x21, #0x4aa]
006896F00  adrp     x8, #0x8f25000
006896F04  ldr      x8, [x8, #0xbd8]
006896F08  ldr      x2, [x8]
006896F0C  ldrb     w8, [x2, #0x53]
006896F10  tbnz     w8, #5, #0x6896f1c
006896F14  str      w20, [x19, #0x24]
006896F18  b        #0x6896f2c ; 
006896F1C  ldr      x8, [x2, #0x60]
006896F20  mov      x0, x19
006896F24  mov      w1, w20
006896F28  blr      x8
006896F2C  mov      x0, x19
006896F30  mov      x1, xzr
006896F34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006896F38  adrp     x21, #0x959c000
006896F3C  ldrb     w8, [x21, #0x4ab]
006896F40  mov      w20, w0
006896F44  cbnz     w8, #0x6896f5c
006896F48  adrp     x0, #0x8f25000
006896F4C  ldr      x0, [x0, #0xbe8]
006896F50  bl       #0x382bd14 ; 
006896F54  mov      w8, #1
006896F58  strb     w8, [x21, #0x4ab]
006896F5C  adrp     x8, #0x8f25000
006896F60  ldr      x8, [x8, #0xbe8]
006896F64  ldr      x2, [x8]
006896F68  ldrb     w8, [x2, #0x53]
006896F6C  tbnz     w8, #5, #0x6896f78
006896F70  str      w20, [x19, #0x28]
006896F74  b        #0x6896f88 ; 
006896F78  ldr      x8, [x2, #0x60]
006896F7C  mov      x0, x19
006896F80  mov      w1, w20
006896F84  blr      x8
006896F88  mov      x0, x19
006896F8C  mov      x1, xzr
006896F90  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006896F94  adrp     x21, #0x959c000
006896F98  ldrb     w8, [x21, #0x4ac]
006896F9C  mov      x20, x0
006896FA0  cbnz     w8, #0x6896fb8
006896FA4  adrp     x0, #0x8f25000
006896FA8  ldr      x0, [x0, #0xbf8]
006896FAC  bl       #0x382bd14 ; 
006896FB0  mov      w8, #1
006896FB4  strb     w8, [x21, #0x4ac]
006896FB8  adrp     x8, #0x8f25000
006896FBC  ldr      x8, [x8, #0xbf8]
006896FC0  ldr      x2, [x8]
006896FC4  ldrb     w8, [x2, #0x53]
006896FC8  tbnz     w8, #5, #0x6896fe0
006896FCC  mov      x0, x19
006896FD0  str      x20, [x0, #0x30]!
006896FD4  mov      x1, x20
006896FD8  bl       #0x382bcb8 ; 
006896FDC  b        #0x6896ff0 ; 
006896FE0  ldr      x8, [x2, #0x60]
006896FE4  mov      x0, x19
006896FE8  mov      x1, x20
006896FEC  blr      x8
006896FF0  mov      x0, x19
006896FF4  mov      x1, xzr
006896FF8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006896FFC  adrp     x21, #0x959c000
006897000  ldrb     w8, [x21, #0x4ad]
006897004  mov      x20, x0
006897008  cbnz     w8, #0x6897020
00689700C  adrp     x0, #0x8f25000
006897010  ldr      x0, [x0, #0xc08]
006897014  bl       #0x382bd14 ; 
006897018  mov      w8, #1
00689701C  strb     w8, [x21, #0x4ad]
006897020  adrp     x8, #0x8f25000
006897024  ldr      x8, [x8, #0xc08]
006897028  ldr      x2, [x8]
00689702C  ldrb     w8, [x2, #0x53]
006897030  tbnz     w8, #5, #0x6897048
006897034  str      x20, [x19, #0x38]!
006897038  mov      x0, x19
00689703C  mov      x1, x20
006897040  bl       #0x382bcb8 ; 
006897044  b        #0x6897058 ; 
006897048  ldr      x8, [x2, #0x60]
00689704C  mov      x0, x19
006897050  mov      x1, x20
006897054  blr      x8
006897058  ldp      x20, x19, [sp, #0x10]
00689705C  mov      w0, #1
006897060  ldp      x30, x21, [sp], #0x20
006897064  ret      

