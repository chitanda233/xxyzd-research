; LocalModels.Bean.DrawBox_DrawBoxConst$$readImpl
; RVA 0x6A59CDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A59CDC  str      d8, [sp, #-0x30]!
006A59CE0  stp      x30, x21, [sp, #0x10]
006A59CE4  stp      x20, x19, [sp, #0x20]
006A59CE8  adrp     x20, #0x959d000
006A59CEC  adrp     x21, #0x8f36000
006A59CF0  ldrb     w8, [x20, #0xb4a]
006A59CF4  ldr      x21, [x21, #0x510]
006A59CF8  mov      x19, x0
006A59CFC  tbnz     w8, #0, #0x6a59d14
006A59D00  adrp     x0, #0x8f36000
006A59D04  ldr      x0, [x0, #0x510]
006A59D08  bl       #0x382bd14 ; 
006A59D0C  mov      w8, #1
006A59D10  strb     w8, [x20, #0xb4a]
006A59D14  ldr      x1, [x21]
006A59D18  ldrb     w8, [x1, #0x53]
006A59D1C  tbnz     w8, #5, #0x6a59d78
006A59D20  mov      x0, x19
006A59D24  mov      x1, xzr
006A59D28  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A59D2C  adrp     x21, #0x959e000
006A59D30  ldrb     w8, [x21, #0x351]
006A59D34  mov      x20, x0
006A59D38  cbnz     w8, #0x6a59d50
006A59D3C  adrp     x0, #0x8f36000
006A59D40  ldr      x0, [x0, #0x498]
006A59D44  bl       #0x382bd14 ; 
006A59D48  mov      w8, #1
006A59D4C  strb     w8, [x21, #0x351]
006A59D50  adrp     x8, #0x8f36000
006A59D54  ldr      x8, [x8, #0x498]
006A59D58  ldr      x2, [x8]
006A59D5C  ldrb     w8, [x2, #0x53]
006A59D60  tbnz     w8, #5, #0x6a59d90
006A59D64  mov      x0, x19
006A59D68  str      x20, [x0, #0x20]!
006A59D6C  mov      x1, x20
006A59D70  bl       #0x382bcb8 ; 
006A59D74  b        #0x6a59da0 ; 
006A59D78  ldr      x2, [x1, #0x60]
006A59D7C  mov      x0, x19
006A59D80  ldp      x20, x19, [sp, #0x20]
006A59D84  ldp      x30, x21, [sp, #0x10]
006A59D88  ldr      d8, [sp], #0x30
006A59D8C  br       x2
006A59D90  ldr      x8, [x2, #0x60]
006A59D94  mov      x0, x19
006A59D98  mov      x1, x20
006A59D9C  blr      x8
006A59DA0  mov      x0, x19
006A59DA4  mov      x1, xzr
006A59DA8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A59DAC  adrp     x21, #0x959e000
006A59DB0  ldrb     w8, [x21, #0x352]
006A59DB4  mov      x20, x0
006A59DB8  cbnz     w8, #0x6a59dd0
006A59DBC  adrp     x0, #0x8f36000
006A59DC0  ldr      x0, [x0, #0x4a8]
006A59DC4  bl       #0x382bd14 ; 
006A59DC8  mov      w8, #1
006A59DCC  strb     w8, [x21, #0x352]
006A59DD0  adrp     x8, #0x8f36000
006A59DD4  ldr      x8, [x8, #0x4a8]
006A59DD8  ldr      x2, [x8]
006A59DDC  ldrb     w8, [x2, #0x53]
006A59DE0  tbnz     w8, #5, #0x6a59df8
006A59DE4  mov      x0, x19
006A59DE8  str      x20, [x0, #0x28]!
006A59DEC  mov      x1, x20
006A59DF0  bl       #0x382bcb8 ; 
006A59DF4  b        #0x6a59e08 ; 
006A59DF8  ldr      x8, [x2, #0x60]
006A59DFC  mov      x0, x19
006A59E00  mov      x1, x20
006A59E04  blr      x8
006A59E08  mov      x0, x19
006A59E0C  mov      x1, xzr
006A59E10  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A59E14  adrp     x21, #0x959e000
006A59E18  ldrb     w8, [x21, #0x353]
006A59E1C  mov      w20, w0
006A59E20  cbnz     w8, #0x6a59e38
006A59E24  adrp     x0, #0x8f36000
006A59E28  ldr      x0, [x0, #0x4b8]
006A59E2C  bl       #0x382bd14 ; 
006A59E30  mov      w8, #1
006A59E34  strb     w8, [x21, #0x353]
006A59E38  adrp     x8, #0x8f36000
006A59E3C  ldr      x8, [x8, #0x4b8]
006A59E40  ldr      x2, [x8]
006A59E44  ldrb     w8, [x2, #0x53]
006A59E48  tbnz     w8, #5, #0x6a59e54
006A59E4C  str      w20, [x19, #0x30]
006A59E50  b        #0x6a59e64 ; 
006A59E54  ldr      x8, [x2, #0x60]
006A59E58  mov      x0, x19
006A59E5C  mov      w1, w20
006A59E60  blr      x8
006A59E64  mov      x0, x19
006A59E68  mov      x1, xzr
006A59E6C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A59E70  adrp     x21, #0x959e000
006A59E74  ldrb     w8, [x21, #0x354]
006A59E78  mov      x20, x0
006A59E7C  cbnz     w8, #0x6a59e94
006A59E80  adrp     x0, #0x8f36000
006A59E84  ldr      x0, [x0, #0x4c8]
006A59E88  bl       #0x382bd14 ; 
006A59E8C  mov      w8, #1
006A59E90  strb     w8, [x21, #0x354]
006A59E94  adrp     x8, #0x8f36000
006A59E98  ldr      x8, [x8, #0x4c8]
006A59E9C  ldr      x2, [x8]
006A59EA0  ldrb     w8, [x2, #0x53]
006A59EA4  tbnz     w8, #5, #0x6a59ebc
006A59EA8  mov      x0, x19
006A59EAC  str      x20, [x0, #0x38]!
006A59EB0  mov      x1, x20
006A59EB4  bl       #0x382bcb8 ; 
006A59EB8  b        #0x6a59ecc ; 
006A59EBC  ldr      x8, [x2, #0x60]
006A59EC0  mov      x0, x19
006A59EC4  mov      x1, x20
006A59EC8  blr      x8
006A59ECC  mov      x0, x19
006A59ED0  mov      x1, xzr
006A59ED4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A59ED8  adrp     x21, #0x959e000
006A59EDC  ldrb     w8, [x21, #0x355]
006A59EE0  mov      x20, x0
006A59EE4  cbnz     w8, #0x6a59efc
006A59EE8  adrp     x0, #0x8f36000
006A59EEC  ldr      x0, [x0, #0x4d8]
006A59EF0  bl       #0x382bd14 ; 
006A59EF4  mov      w8, #1
006A59EF8  strb     w8, [x21, #0x355]
006A59EFC  adrp     x8, #0x8f36000
006A59F00  ldr      x8, [x8, #0x4d8]
006A59F04  ldr      x2, [x8]
006A59F08  ldrb     w8, [x2, #0x53]
006A59F0C  tbnz     w8, #5, #0x6a59f24
006A59F10  mov      x0, x19
006A59F14  str      x20, [x0, #0x40]!
006A59F18  mov      x1, x20
006A59F1C  bl       #0x382bcb8 ; 
006A59F20  b        #0x6a59f34 ; 
006A59F24  ldr      x8, [x2, #0x60]
006A59F28  mov      x0, x19
006A59F2C  mov      x1, x20
006A59F30  blr      x8
006A59F34  mov      x0, x19
006A59F38  mov      x1, xzr
006A59F3C  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006A59F40  adrp     x20, #0x959e000
006A59F44  ldrb     w8, [x20, #0x356]
006A59F48  mov      v8.16b, v0.16b
006A59F4C  cbnz     w8, #0x6a59f64
006A59F50  adrp     x0, #0x8f36000
006A59F54  ldr      x0, [x0, #0x4e8]
006A59F58  bl       #0x382bd14 ; 
006A59F5C  mov      w8, #1
006A59F60  strb     w8, [x20, #0x356]
006A59F64  adrp     x8, #0x8f36000
006A59F68  ldr      x8, [x8, #0x4e8]
006A59F6C  ldr      x1, [x8]
006A59F70  ldrb     w8, [x1, #0x53]
006A59F74  tbnz     w8, #5, #0x6a59f80
006A59F78  str      s8, [x19, #0x48]
006A59F7C  b        #0x6a59f90 ; 
006A59F80  ldr      x8, [x1, #0x60]
006A59F84  mov      x0, x19
006A59F88  mov      v0.16b, v8.16b
006A59F8C  blr      x8
006A59F90  mov      x0, x19
006A59F94  mov      x1, xzr
006A59F98  bl       #0x64caaf8 ; LocalModels.BaseLocalBean$$readArrayfloat
006A59F9C  adrp     x21, #0x959e000
006A59FA0  ldrb     w8, [x21, #0x357]
006A59FA4  mov      x20, x0
006A59FA8  cbnz     w8, #0x6a59fc0
006A59FAC  adrp     x0, #0x8f36000
006A59FB0  ldr      x0, [x0, #0x4f8]
006A59FB4  bl       #0x382bd14 ; 
006A59FB8  mov      w8, #1
006A59FBC  strb     w8, [x21, #0x357]
006A59FC0  adrp     x8, #0x8f36000
006A59FC4  ldr      x8, [x8, #0x4f8]
006A59FC8  ldr      x2, [x8]
006A59FCC  ldrb     w8, [x2, #0x53]
006A59FD0  tbnz     w8, #5, #0x6a59fe8
006A59FD4  mov      x0, x19
006A59FD8  str      x20, [x0, #0x50]!
006A59FDC  mov      x1, x20
006A59FE0  bl       #0x382bcb8 ; 
006A59FE4  b        #0x6a59ff8 ; 
006A59FE8  ldr      x8, [x2, #0x60]
006A59FEC  mov      x0, x19
006A59FF0  mov      x1, x20
006A59FF4  blr      x8
006A59FF8  mov      x0, x19
006A59FFC  mov      x1, xzr
006A5A000  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A5A004  adrp     x21, #0x959e000
006A5A008  ldrb     w8, [x21, #0x358]
006A5A00C  mov      x20, x0
006A5A010  cbnz     w8, #0x6a5a028
006A5A014  adrp     x0, #0x8f36000
006A5A018  ldr      x0, [x0, #0x508]
006A5A01C  bl       #0x382bd14 ; 
006A5A020  mov      w8, #1
006A5A024  strb     w8, [x21, #0x358]
006A5A028  adrp     x8, #0x8f36000
006A5A02C  ldr      x8, [x8, #0x508]
006A5A030  ldr      x2, [x8]
006A5A034  ldrb     w8, [x2, #0x53]
006A5A038  tbnz     w8, #5, #0x6a5a050
006A5A03C  str      x20, [x19, #0x58]!
006A5A040  mov      x0, x19
006A5A044  mov      x1, x20
006A5A048  bl       #0x382bcb8 ; 
006A5A04C  b        #0x6a5a060 ; 
006A5A050  ldr      x8, [x2, #0x60]
006A5A054  mov      x0, x19
006A5A058  mov      x1, x20
006A5A05C  blr      x8
006A5A060  ldp      x20, x19, [sp, #0x20]
006A5A064  ldp      x30, x21, [sp, #0x10]
006A5A068  mov      w0, #1
006A5A06C  ldr      d8, [sp], #0x30
006A5A070  ret      

