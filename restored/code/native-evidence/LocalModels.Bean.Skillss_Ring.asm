; LocalModels.Bean.Skillss_Ring$$readImpl
; RVA 0x6B02D58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B02D58  stp      x30, x21, [sp, #-0x20]!
006B02D5C  stp      x20, x19, [sp, #0x10]
006B02D60  adrp     x20, #0x959f000
006B02D64  adrp     x21, #0x8f3e000
006B02D68  ldrb     w8, [x20, #0x3d5]
006B02D6C  ldr      x21, [x21, #0x3c0]
006B02D70  mov      x19, x0
006B02D74  tbnz     w8, #0, #0x6b02d8c
006B02D78  adrp     x0, #0x8f3e000
006B02D7C  ldr      x0, [x0, #0x3c0]
006B02D80  bl       #0x382bd14 ; 
006B02D84  mov      w8, #1
006B02D88  strb     w8, [x20, #0x3d5]
006B02D8C  ldr      x1, [x21]
006B02D90  ldrb     w8, [x1, #0x53]
006B02D94  tbnz     w8, #5, #0x6b02de4
006B02D98  mov      x0, x19
006B02D9C  mov      x1, xzr
006B02DA0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B02DA4  adrp     x21, #0x959f000
006B02DA8  ldrb     w8, [x21, #0x908]
006B02DAC  mov      w20, w0
006B02DB0  cbnz     w8, #0x6b02dc8
006B02DB4  adrp     x0, #0x8f3e000
006B02DB8  ldr      x0, [x0, #0x358]
006B02DBC  bl       #0x382bd14 ; 
006B02DC0  mov      w8, #1
006B02DC4  strb     w8, [x21, #0x908]
006B02DC8  adrp     x8, #0x8f3e000
006B02DCC  ldr      x8, [x8, #0x358]
006B02DD0  ldr      x2, [x8]
006B02DD4  ldrb     w8, [x2, #0x53]
006B02DD8  tbnz     w8, #5, #0x6b02df8
006B02DDC  str      w20, [x19, #0x20]
006B02DE0  b        #0x6b02e08 ; 
006B02DE4  ldr      x2, [x1, #0x60]
006B02DE8  mov      x0, x19
006B02DEC  ldp      x20, x19, [sp, #0x10]
006B02DF0  ldp      x30, x21, [sp], #0x20
006B02DF4  br       x2
006B02DF8  ldr      x8, [x2, #0x60]
006B02DFC  mov      x0, x19
006B02E00  mov      w1, w20
006B02E04  blr      x8
006B02E08  mov      x0, x19
006B02E0C  mov      x1, xzr
006B02E10  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B02E14  adrp     x21, #0x959f000
006B02E18  ldrb     w8, [x21, #0x909]
006B02E1C  mov      x20, x0
006B02E20  cbnz     w8, #0x6b02e38
006B02E24  adrp     x0, #0x8f3e000
006B02E28  ldr      x0, [x0, #0x368]
006B02E2C  bl       #0x382bd14 ; 
006B02E30  mov      w8, #1
006B02E34  strb     w8, [x21, #0x909]
006B02E38  adrp     x8, #0x8f3e000
006B02E3C  ldr      x8, [x8, #0x368]
006B02E40  ldr      x2, [x8]
006B02E44  ldrb     w8, [x2, #0x53]
006B02E48  tbnz     w8, #5, #0x6b02e60
006B02E4C  mov      x0, x19
006B02E50  str      x20, [x0, #0x28]!
006B02E54  mov      x1, x20
006B02E58  bl       #0x382bcb8 ; 
006B02E5C  b        #0x6b02e70 ; 
006B02E60  ldr      x8, [x2, #0x60]
006B02E64  mov      x0, x19
006B02E68  mov      x1, x20
006B02E6C  blr      x8
006B02E70  mov      x0, x19
006B02E74  mov      x1, xzr
006B02E78  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B02E7C  adrp     x21, #0x959f000
006B02E80  ldrb     w8, [x21, #0x90a]
006B02E84  mov      w20, w0
006B02E88  cbnz     w8, #0x6b02ea0
006B02E8C  adrp     x0, #0x8f3e000
006B02E90  ldr      x0, [x0, #0x378]
006B02E94  bl       #0x382bd14 ; 
006B02E98  mov      w8, #1
006B02E9C  strb     w8, [x21, #0x90a]
006B02EA0  adrp     x8, #0x8f3e000
006B02EA4  ldr      x8, [x8, #0x378]
006B02EA8  ldr      x2, [x8]
006B02EAC  ldrb     w8, [x2, #0x53]
006B02EB0  tbnz     w8, #5, #0x6b02ebc
006B02EB4  str      w20, [x19, #0x30]
006B02EB8  b        #0x6b02ecc ; 
006B02EBC  ldr      x8, [x2, #0x60]
006B02EC0  mov      x0, x19
006B02EC4  mov      w1, w20
006B02EC8  blr      x8
006B02ECC  mov      x0, x19
006B02ED0  mov      x1, xzr
006B02ED4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006B02ED8  adrp     x21, #0x959f000
006B02EDC  ldrb     w8, [x21, #0x90b]
006B02EE0  mov      x20, x0
006B02EE4  cbnz     w8, #0x6b02efc
006B02EE8  adrp     x0, #0x8f3e000
006B02EEC  ldr      x0, [x0, #0x388]
006B02EF0  bl       #0x382bd14 ; 
006B02EF4  mov      w8, #1
006B02EF8  strb     w8, [x21, #0x90b]
006B02EFC  adrp     x8, #0x8f3e000
006B02F00  ldr      x8, [x8, #0x388]
006B02F04  ldr      x2, [x8]
006B02F08  ldrb     w8, [x2, #0x53]
006B02F0C  tbnz     w8, #5, #0x6b02f18
006B02F10  str      x20, [x19, #0x38]
006B02F14  b        #0x6b02f28 ; 
006B02F18  ldr      x8, [x2, #0x60]
006B02F1C  mov      x0, x19
006B02F20  mov      x1, x20
006B02F24  blr      x8
006B02F28  mov      x0, x19
006B02F2C  mov      x1, xzr
006B02F30  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B02F34  adrp     x21, #0x959f000
006B02F38  ldrb     w8, [x21, #0x90c]
006B02F3C  mov      x20, x0
006B02F40  cbnz     w8, #0x6b02f58
006B02F44  adrp     x0, #0x8f3e000
006B02F48  ldr      x0, [x0, #0x398]
006B02F4C  bl       #0x382bd14 ; 
006B02F50  mov      w8, #1
006B02F54  strb     w8, [x21, #0x90c]
006B02F58  adrp     x8, #0x8f3e000
006B02F5C  ldr      x8, [x8, #0x398]
006B02F60  ldr      x2, [x8]
006B02F64  ldrb     w8, [x2, #0x53]
006B02F68  tbnz     w8, #5, #0x6b02f80
006B02F6C  mov      x0, x19
006B02F70  str      x20, [x0, #0x40]!
006B02F74  mov      x1, x20
006B02F78  bl       #0x382bcb8 ; 
006B02F7C  b        #0x6b02f90 ; 
006B02F80  ldr      x8, [x2, #0x60]
006B02F84  mov      x0, x19
006B02F88  mov      x1, x20
006B02F8C  blr      x8
006B02F90  mov      x0, x19
006B02F94  mov      x1, xzr
006B02F98  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B02F9C  adrp     x21, #0x959f000
006B02FA0  ldrb     w8, [x21, #0x90d]
006B02FA4  mov      x20, x0
006B02FA8  cbnz     w8, #0x6b02fc0
006B02FAC  adrp     x0, #0x8f3e000
006B02FB0  ldr      x0, [x0, #0x3a8]
006B02FB4  bl       #0x382bd14 ; 
006B02FB8  mov      w8, #1
006B02FBC  strb     w8, [x21, #0x90d]
006B02FC0  adrp     x8, #0x8f3e000
006B02FC4  ldr      x8, [x8, #0x3a8]
006B02FC8  ldr      x2, [x8]
006B02FCC  ldrb     w8, [x2, #0x53]
006B02FD0  tbnz     w8, #5, #0x6b02fe8
006B02FD4  mov      x0, x19
006B02FD8  str      x20, [x0, #0x48]!
006B02FDC  mov      x1, x20
006B02FE0  bl       #0x382bcb8 ; 
006B02FE4  b        #0x6b02ff8 ; 
006B02FE8  ldr      x8, [x2, #0x60]
006B02FEC  mov      x0, x19
006B02FF0  mov      x1, x20
006B02FF4  blr      x8
006B02FF8  mov      x0, x19
006B02FFC  mov      x1, xzr
006B03000  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B03004  adrp     x21, #0x959f000
006B03008  ldrb     w8, [x21, #0x90e]
006B0300C  mov      w20, w0
006B03010  cbnz     w8, #0x6b03028
006B03014  adrp     x0, #0x8f3e000
006B03018  ldr      x0, [x0, #0x3b8]
006B0301C  bl       #0x382bd14 ; 
006B03020  mov      w8, #1
006B03024  strb     w8, [x21, #0x90e]
006B03028  adrp     x8, #0x8f3e000
006B0302C  ldr      x8, [x8, #0x3b8]
006B03030  ldr      x2, [x8]
006B03034  ldrb     w8, [x2, #0x53]
006B03038  tbnz     w8, #5, #0x6b03044
006B0303C  str      w20, [x19, #0x50]
006B03040  b        #0x6b03054 ; 
006B03044  ldr      x8, [x2, #0x60]
006B03048  mov      x0, x19
006B0304C  mov      w1, w20
006B03050  blr      x8
006B03054  ldp      x20, x19, [sp, #0x10]
006B03058  mov      w0, #1
006B0305C  ldp      x30, x21, [sp], #0x20
006B03060  ret      

