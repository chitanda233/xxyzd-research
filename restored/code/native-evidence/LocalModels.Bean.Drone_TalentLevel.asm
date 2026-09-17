; LocalModels.Bean.Drone_TalentLevel$$readImpl
; RVA 0x6A60BF4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A60BF4  stp      x30, x21, [sp, #-0x20]!
006A60BF8  stp      x20, x19, [sp, #0x10]
006A60BFC  adrp     x20, #0x959d000
006A60C00  adrp     x21, #0x8f36000
006A60C04  ldrb     w8, [x20, #0xc01]
006A60C08  ldr      x21, [x21, #0xa00]
006A60C0C  mov      x19, x0
006A60C10  tbnz     w8, #0, #0x6a60c28
006A60C14  adrp     x0, #0x8f36000
006A60C18  ldr      x0, [x0, #0xa00]
006A60C1C  bl       #0x382bd14 ; 
006A60C20  mov      w8, #1
006A60C24  strb     w8, [x20, #0xc01]
006A60C28  ldr      x1, [x21]
006A60C2C  ldrb     w8, [x1, #0x53]
006A60C30  tbnz     w8, #5, #0x6a60c80
006A60C34  mov      x0, x19
006A60C38  mov      x1, xzr
006A60C3C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A60C40  adrp     x21, #0x959e000
006A60C44  ldrb     w8, [x21, #0x39e]
006A60C48  mov      w20, w0
006A60C4C  cbnz     w8, #0x6a60c64
006A60C50  adrp     x0, #0x8f36000
006A60C54  ldr      x0, [x0, #0x9b8]
006A60C58  bl       #0x382bd14 ; 
006A60C5C  mov      w8, #1
006A60C60  strb     w8, [x21, #0x39e]
006A60C64  adrp     x8, #0x8f36000
006A60C68  ldr      x8, [x8, #0x9b8]
006A60C6C  ldr      x2, [x8]
006A60C70  ldrb     w8, [x2, #0x53]
006A60C74  tbnz     w8, #5, #0x6a60c94
006A60C78  str      w20, [x19, #0x20]
006A60C7C  b        #0x6a60ca4 ; 
006A60C80  ldr      x2, [x1, #0x60]
006A60C84  mov      x0, x19
006A60C88  ldp      x20, x19, [sp, #0x10]
006A60C8C  ldp      x30, x21, [sp], #0x20
006A60C90  br       x2
006A60C94  ldr      x8, [x2, #0x60]
006A60C98  mov      x0, x19
006A60C9C  mov      w1, w20
006A60CA0  blr      x8
006A60CA4  mov      x0, x19
006A60CA8  mov      x1, xzr
006A60CAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A60CB0  adrp     x21, #0x959e000
006A60CB4  ldrb     w8, [x21, #0x39f]
006A60CB8  mov      w20, w0
006A60CBC  cbnz     w8, #0x6a60cd4
006A60CC0  adrp     x0, #0x8f36000
006A60CC4  ldr      x0, [x0, #0x9c8]
006A60CC8  bl       #0x382bd14 ; 
006A60CCC  mov      w8, #1
006A60CD0  strb     w8, [x21, #0x39f]
006A60CD4  adrp     x8, #0x8f36000
006A60CD8  ldr      x8, [x8, #0x9c8]
006A60CDC  ldr      x2, [x8]
006A60CE0  ldrb     w8, [x2, #0x53]
006A60CE4  tbnz     w8, #5, #0x6a60cf0
006A60CE8  str      w20, [x19, #0x24]
006A60CEC  b        #0x6a60d00 ; 
006A60CF0  ldr      x8, [x2, #0x60]
006A60CF4  mov      x0, x19
006A60CF8  mov      w1, w20
006A60CFC  blr      x8
006A60D00  mov      x0, x19
006A60D04  mov      x1, xzr
006A60D08  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A60D0C  adrp     x21, #0x959e000
006A60D10  ldrb     w8, [x21, #0x3a0]
006A60D14  mov      w20, w0
006A60D18  cbnz     w8, #0x6a60d30
006A60D1C  adrp     x0, #0x8f36000
006A60D20  ldr      x0, [x0, #0x9d0]
006A60D24  bl       #0x382bd14 ; 
006A60D28  mov      w8, #1
006A60D2C  strb     w8, [x21, #0x3a0]
006A60D30  adrp     x8, #0x8f36000
006A60D34  ldr      x8, [x8, #0x9d0]
006A60D38  ldr      x2, [x8]
006A60D3C  ldrb     w8, [x2, #0x53]
006A60D40  tbnz     w8, #5, #0x6a60d4c
006A60D44  str      w20, [x19, #0x28]
006A60D48  b        #0x6a60d5c ; 
006A60D4C  ldr      x8, [x2, #0x60]
006A60D50  mov      x0, x19
006A60D54  mov      w1, w20
006A60D58  blr      x8
006A60D5C  mov      x0, x19
006A60D60  mov      x1, xzr
006A60D64  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A60D68  adrp     x21, #0x959e000
006A60D6C  ldrb     w8, [x21, #0x3a1]
006A60D70  mov      x20, x0
006A60D74  cbnz     w8, #0x6a60d8c
006A60D78  adrp     x0, #0x8f36000
006A60D7C  ldr      x0, [x0, #0x9e0]
006A60D80  bl       #0x382bd14 ; 
006A60D84  mov      w8, #1
006A60D88  strb     w8, [x21, #0x3a1]
006A60D8C  adrp     x8, #0x8f36000
006A60D90  ldr      x8, [x8, #0x9e0]
006A60D94  ldr      x2, [x8]
006A60D98  ldrb     w8, [x2, #0x53]
006A60D9C  tbnz     w8, #5, #0x6a60db4
006A60DA0  mov      x0, x19
006A60DA4  str      x20, [x0, #0x30]!
006A60DA8  mov      x1, x20
006A60DAC  bl       #0x382bcb8 ; 
006A60DB0  b        #0x6a60dc4 ; 
006A60DB4  ldr      x8, [x2, #0x60]
006A60DB8  mov      x0, x19
006A60DBC  mov      x1, x20
006A60DC0  blr      x8
006A60DC4  mov      x0, x19
006A60DC8  mov      x1, xzr
006A60DCC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A60DD0  adrp     x21, #0x959e000
006A60DD4  ldrb     w8, [x21, #0x3a2]
006A60DD8  mov      w20, w0
006A60DDC  cbnz     w8, #0x6a60df4
006A60DE0  adrp     x0, #0x8f36000
006A60DE4  ldr      x0, [x0, #0x9e8]
006A60DE8  bl       #0x382bd14 ; 
006A60DEC  mov      w8, #1
006A60DF0  strb     w8, [x21, #0x3a2]
006A60DF4  adrp     x8, #0x8f36000
006A60DF8  ldr      x8, [x8, #0x9e8]
006A60DFC  ldr      x2, [x8]
006A60E00  ldrb     w8, [x2, #0x53]
006A60E04  tbnz     w8, #5, #0x6a60e10
006A60E08  str      w20, [x19, #0x38]
006A60E0C  b        #0x6a60e20 ; 
006A60E10  ldr      x8, [x2, #0x60]
006A60E14  mov      x0, x19
006A60E18  mov      w1, w20
006A60E1C  blr      x8
006A60E20  mov      x0, x19
006A60E24  mov      x1, xzr
006A60E28  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A60E2C  adrp     x21, #0x959e000
006A60E30  ldrb     w8, [x21, #0x3a3]
006A60E34  mov      x20, x0
006A60E38  cbnz     w8, #0x6a60e50
006A60E3C  adrp     x0, #0x8f36000
006A60E40  ldr      x0, [x0, #0x9f8]
006A60E44  bl       #0x382bd14 ; 
006A60E48  mov      w8, #1
006A60E4C  strb     w8, [x21, #0x3a3]
006A60E50  adrp     x8, #0x8f36000
006A60E54  ldr      x8, [x8, #0x9f8]
006A60E58  ldr      x2, [x8]
006A60E5C  ldrb     w8, [x2, #0x53]
006A60E60  tbnz     w8, #5, #0x6a60e78
006A60E64  str      x20, [x19, #0x40]!
006A60E68  mov      x0, x19
006A60E6C  mov      x1, x20
006A60E70  bl       #0x382bcb8 ; 
006A60E74  b        #0x6a60e88 ; 
006A60E78  ldr      x8, [x2, #0x60]
006A60E7C  mov      x0, x19
006A60E80  mov      x1, x20
006A60E84  blr      x8
006A60E88  ldp      x20, x19, [sp, #0x10]
006A60E8C  mov      w0, #1
006A60E90  ldp      x30, x21, [sp], #0x20
006A60E94  ret      

