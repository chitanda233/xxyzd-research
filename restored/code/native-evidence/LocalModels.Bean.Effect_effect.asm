; LocalModels.Bean.Effect_effect$$readImpl
; RVA 0x6A62CAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A62CAC  stp      x30, x21, [sp, #-0x20]!
006A62CB0  stp      x20, x19, [sp, #0x10]
006A62CB4  adrp     x20, #0x959d000
006A62CB8  adrp     x21, #0x8f36000
006A62CBC  ldrb     w8, [x20, #0xc33]
006A62CC0  ldr      x21, [x21, #0xb68]
006A62CC4  mov      x19, x0
006A62CC8  tbnz     w8, #0, #0x6a62ce0
006A62CCC  adrp     x0, #0x8f36000
006A62CD0  ldr      x0, [x0, #0xb68]
006A62CD4  bl       #0x382bd14 ; 
006A62CD8  mov      w8, #1
006A62CDC  strb     w8, [x20, #0xc33]
006A62CE0  ldr      x1, [x21]
006A62CE4  ldrb     w8, [x1, #0x53]
006A62CE8  tbnz     w8, #5, #0x6a62d38
006A62CEC  mov      x0, x19
006A62CF0  mov      x1, xzr
006A62CF4  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006A62CF8  adrp     x21, #0x959e000
006A62CFC  ldrb     w8, [x21, #0x3b9]
006A62D00  mov      x20, x0
006A62D04  cbnz     w8, #0x6a62d1c
006A62D08  adrp     x0, #0x8f36000
006A62D0C  ldr      x0, [x0, #0xb30]
006A62D10  bl       #0x382bd14 ; 
006A62D14  mov      w8, #1
006A62D18  strb     w8, [x21, #0x3b9]
006A62D1C  adrp     x8, #0x8f36000
006A62D20  ldr      x8, [x8, #0xb30]
006A62D24  ldr      x2, [x8]
006A62D28  ldrb     w8, [x2, #0x53]
006A62D2C  tbnz     w8, #5, #0x6a62d4c
006A62D30  str      x20, [x19, #0x20]
006A62D34  b        #0x6a62d5c ; 
006A62D38  ldr      x2, [x1, #0x60]
006A62D3C  mov      x0, x19
006A62D40  ldp      x20, x19, [sp, #0x10]
006A62D44  ldp      x30, x21, [sp], #0x20
006A62D48  br       x2
006A62D4C  ldr      x8, [x2, #0x60]
006A62D50  mov      x0, x19
006A62D54  mov      x1, x20
006A62D58  blr      x8
006A62D5C  mov      x0, x19
006A62D60  mov      x1, xzr
006A62D64  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A62D68  adrp     x21, #0x959e000
006A62D6C  ldrb     w8, [x21, #0x3ba]
006A62D70  mov      x20, x0
006A62D74  cbnz     w8, #0x6a62d8c
006A62D78  adrp     x0, #0x8f36000
006A62D7C  ldr      x0, [x0, #0xb40]
006A62D80  bl       #0x382bd14 ; 
006A62D84  mov      w8, #1
006A62D88  strb     w8, [x21, #0x3ba]
006A62D8C  adrp     x8, #0x8f36000
006A62D90  ldr      x8, [x8, #0xb40]
006A62D94  ldr      x2, [x8]
006A62D98  ldrb     w8, [x2, #0x53]
006A62D9C  tbnz     w8, #5, #0x6a62db4
006A62DA0  mov      x0, x19
006A62DA4  str      x20, [x0, #0x28]!
006A62DA8  mov      x1, x20
006A62DAC  bl       #0x382bcb8 ; 
006A62DB0  b        #0x6a62dc4 ; 
006A62DB4  ldr      x8, [x2, #0x60]
006A62DB8  mov      x0, x19
006A62DBC  mov      x1, x20
006A62DC0  blr      x8
006A62DC4  mov      x0, x19
006A62DC8  mov      x1, xzr
006A62DCC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A62DD0  adrp     x21, #0x959e000
006A62DD4  ldrb     w8, [x21, #0x3bb]
006A62DD8  mov      x20, x0
006A62DDC  cbnz     w8, #0x6a62df4
006A62DE0  adrp     x0, #0x8f36000
006A62DE4  ldr      x0, [x0, #0xb50]
006A62DE8  bl       #0x382bd14 ; 
006A62DEC  mov      w8, #1
006A62DF0  strb     w8, [x21, #0x3bb]
006A62DF4  adrp     x8, #0x8f36000
006A62DF8  ldr      x8, [x8, #0xb50]
006A62DFC  ldr      x2, [x8]
006A62E00  ldrb     w8, [x2, #0x53]
006A62E04  tbnz     w8, #5, #0x6a62e1c
006A62E08  mov      x0, x19
006A62E0C  str      x20, [x0, #0x30]!
006A62E10  mov      x1, x20
006A62E14  bl       #0x382bcb8 ; 
006A62E18  b        #0x6a62e2c ; 
006A62E1C  ldr      x8, [x2, #0x60]
006A62E20  mov      x0, x19
006A62E24  mov      x1, x20
006A62E28  blr      x8
006A62E2C  mov      x0, x19
006A62E30  mov      x1, xzr
006A62E34  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A62E38  adrp     x21, #0x959e000
006A62E3C  ldrb     w8, [x21, #0x3bc]
006A62E40  mov      x20, x0
006A62E44  cbnz     w8, #0x6a62e5c
006A62E48  adrp     x0, #0x8f36000
006A62E4C  ldr      x0, [x0, #0xb60]
006A62E50  bl       #0x382bd14 ; 
006A62E54  mov      w8, #1
006A62E58  strb     w8, [x21, #0x3bc]
006A62E5C  adrp     x8, #0x8f36000
006A62E60  ldr      x8, [x8, #0xb60]
006A62E64  ldr      x2, [x8]
006A62E68  ldrb     w8, [x2, #0x53]
006A62E6C  tbnz     w8, #5, #0x6a62e84
006A62E70  str      x20, [x19, #0x38]!
006A62E74  mov      x0, x19
006A62E78  mov      x1, x20
006A62E7C  bl       #0x382bcb8 ; 
006A62E80  b        #0x6a62e94 ; 
006A62E84  ldr      x8, [x2, #0x60]
006A62E88  mov      x0, x19
006A62E8C  mov      x1, x20
006A62E90  blr      x8
006A62E94  ldp      x20, x19, [sp, #0x10]
006A62E98  mov      w0, #1
006A62E9C  ldp      x30, x21, [sp], #0x20
006A62EA0  ret      

