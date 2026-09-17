; LocalModels.Bean.TalentSystem_TalentSkill$$readImpl
; RVA 0x6B10A94; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B10A94  stp      x30, x21, [sp, #-0x20]!
006B10A98  stp      x20, x19, [sp, #0x10]
006B10A9C  adrp     x20, #0x959f000
006B10AA0  adrp     x21, #0x8f3e000
006B10AA4  ldrb     w8, [x20, #0x53f]
006B10AA8  ldr      x21, [x21, #0xc88]
006B10AAC  mov      x19, x0
006B10AB0  tbnz     w8, #0, #0x6b10ac8
006B10AB4  adrp     x0, #0x8f3e000
006B10AB8  ldr      x0, [x0, #0xc88]
006B10ABC  bl       #0x382bd14 ; 
006B10AC0  mov      w8, #1
006B10AC4  strb     w8, [x20, #0x53f]
006B10AC8  ldr      x1, [x21]
006B10ACC  ldrb     w8, [x1, #0x53]
006B10AD0  tbnz     w8, #5, #0x6b10b20
006B10AD4  mov      x0, x19
006B10AD8  mov      x1, xzr
006B10ADC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B10AE0  adrp     x21, #0x959f000
006B10AE4  ldrb     w8, [x21, #0x9a6]
006B10AE8  mov      w20, w0
006B10AEC  cbnz     w8, #0x6b10b04
006B10AF0  adrp     x0, #0x8f3e000
006B10AF4  ldr      x0, [x0, #0xc10]
006B10AF8  bl       #0x382bd14 ; 
006B10AFC  mov      w8, #1
006B10B00  strb     w8, [x21, #0x9a6]
006B10B04  adrp     x8, #0x8f3e000
006B10B08  ldr      x8, [x8, #0xc10]
006B10B0C  ldr      x2, [x8]
006B10B10  ldrb     w8, [x2, #0x53]
006B10B14  tbnz     w8, #5, #0x6b10b34
006B10B18  str      w20, [x19, #0x20]
006B10B1C  b        #0x6b10b44 ; 
006B10B20  ldr      x2, [x1, #0x60]
006B10B24  mov      x0, x19
006B10B28  ldp      x20, x19, [sp, #0x10]
006B10B2C  ldp      x30, x21, [sp], #0x20
006B10B30  br       x2
006B10B34  ldr      x8, [x2, #0x60]
006B10B38  mov      x0, x19
006B10B3C  mov      w1, w20
006B10B40  blr      x8
006B10B44  mov      x0, x19
006B10B48  mov      x1, xzr
006B10B4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B10B50  adrp     x21, #0x959f000
006B10B54  ldrb     w8, [x21, #0x9a7]
006B10B58  mov      w20, w0
006B10B5C  cbnz     w8, #0x6b10b74
006B10B60  adrp     x0, #0x8f3e000
006B10B64  ldr      x0, [x0, #0xc20]
006B10B68  bl       #0x382bd14 ; 
006B10B6C  mov      w8, #1
006B10B70  strb     w8, [x21, #0x9a7]
006B10B74  adrp     x8, #0x8f3e000
006B10B78  ldr      x8, [x8, #0xc20]
006B10B7C  ldr      x2, [x8]
006B10B80  ldrb     w8, [x2, #0x53]
006B10B84  tbnz     w8, #5, #0x6b10b90
006B10B88  str      w20, [x19, #0x24]
006B10B8C  b        #0x6b10ba0 ; 
006B10B90  ldr      x8, [x2, #0x60]
006B10B94  mov      x0, x19
006B10B98  mov      w1, w20
006B10B9C  blr      x8
006B10BA0  mov      x0, x19
006B10BA4  mov      x1, xzr
006B10BA8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B10BAC  adrp     x21, #0x959f000
006B10BB0  ldrb     w8, [x21, #0x9a8]
006B10BB4  mov      w20, w0
006B10BB8  cbnz     w8, #0x6b10bd0
006B10BBC  adrp     x0, #0x8f3e000
006B10BC0  ldr      x0, [x0, #0xc30]
006B10BC4  bl       #0x382bd14 ; 
006B10BC8  mov      w8, #1
006B10BCC  strb     w8, [x21, #0x9a8]
006B10BD0  adrp     x8, #0x8f3e000
006B10BD4  ldr      x8, [x8, #0xc30]
006B10BD8  ldr      x2, [x8]
006B10BDC  ldrb     w8, [x2, #0x53]
006B10BE0  tbnz     w8, #5, #0x6b10bec
006B10BE4  str      w20, [x19, #0x28]
006B10BE8  b        #0x6b10bfc ; 
006B10BEC  ldr      x8, [x2, #0x60]
006B10BF0  mov      x0, x19
006B10BF4  mov      w1, w20
006B10BF8  blr      x8
006B10BFC  mov      x0, x19
006B10C00  mov      x1, xzr
006B10C04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B10C08  adrp     x21, #0x959f000
006B10C0C  ldrb     w8, [x21, #0x9a9]
006B10C10  mov      w20, w0
006B10C14  cbnz     w8, #0x6b10c2c
006B10C18  adrp     x0, #0x8f3e000
006B10C1C  ldr      x0, [x0, #0xc40]
006B10C20  bl       #0x382bd14 ; 
006B10C24  mov      w8, #1
006B10C28  strb     w8, [x21, #0x9a9]
006B10C2C  adrp     x8, #0x8f3e000
006B10C30  ldr      x8, [x8, #0xc40]
006B10C34  ldr      x2, [x8]
006B10C38  ldrb     w8, [x2, #0x53]
006B10C3C  tbnz     w8, #5, #0x6b10c48
006B10C40  str      w20, [x19, #0x2c]
006B10C44  b        #0x6b10c58 ; 
006B10C48  ldr      x8, [x2, #0x60]
006B10C4C  mov      x0, x19
006B10C50  mov      w1, w20
006B10C54  blr      x8
006B10C58  mov      x0, x19
006B10C5C  mov      x1, xzr
006B10C60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B10C64  adrp     x21, #0x959f000
006B10C68  ldrb     w8, [x21, #0x9aa]
006B10C6C  mov      w20, w0
006B10C70  cbnz     w8, #0x6b10c88
006B10C74  adrp     x0, #0x8f3e000
006B10C78  ldr      x0, [x0, #0xc50]
006B10C7C  bl       #0x382bd14 ; 
006B10C80  mov      w8, #1
006B10C84  strb     w8, [x21, #0x9aa]
006B10C88  adrp     x8, #0x8f3e000
006B10C8C  ldr      x8, [x8, #0xc50]
006B10C90  ldr      x2, [x8]
006B10C94  ldrb     w8, [x2, #0x53]
006B10C98  tbnz     w8, #5, #0x6b10ca4
006B10C9C  str      w20, [x19, #0x30]
006B10CA0  b        #0x6b10cb4 ; 
006B10CA4  ldr      x8, [x2, #0x60]
006B10CA8  mov      x0, x19
006B10CAC  mov      w1, w20
006B10CB0  blr      x8
006B10CB4  mov      x0, x19
006B10CB8  mov      x1, xzr
006B10CBC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B10CC0  adrp     x21, #0x959f000
006B10CC4  ldrb     w8, [x21, #0x9ab]
006B10CC8  mov      x20, x0
006B10CCC  cbnz     w8, #0x6b10ce4
006B10CD0  adrp     x0, #0x8f3e000
006B10CD4  ldr      x0, [x0, #0xc60]
006B10CD8  bl       #0x382bd14 ; 
006B10CDC  mov      w8, #1
006B10CE0  strb     w8, [x21, #0x9ab]
006B10CE4  adrp     x8, #0x8f3e000
006B10CE8  ldr      x8, [x8, #0xc60]
006B10CEC  ldr      x2, [x8]
006B10CF0  ldrb     w8, [x2, #0x53]
006B10CF4  tbnz     w8, #5, #0x6b10d0c
006B10CF8  mov      x0, x19
006B10CFC  str      x20, [x0, #0x38]!
006B10D00  mov      x1, x20
006B10D04  bl       #0x382bcb8 ; 
006B10D08  b        #0x6b10d1c ; 
006B10D0C  ldr      x8, [x2, #0x60]
006B10D10  mov      x0, x19
006B10D14  mov      x1, x20
006B10D18  blr      x8
006B10D1C  mov      x0, x19
006B10D20  mov      x1, xzr
006B10D24  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B10D28  adrp     x21, #0x959f000
006B10D2C  ldrb     w8, [x21, #0x9ac]
006B10D30  mov      x20, x0
006B10D34  cbnz     w8, #0x6b10d4c
006B10D38  adrp     x0, #0x8f3e000
006B10D3C  ldr      x0, [x0, #0xc70]
006B10D40  bl       #0x382bd14 ; 
006B10D44  mov      w8, #1
006B10D48  strb     w8, [x21, #0x9ac]
006B10D4C  adrp     x8, #0x8f3e000
006B10D50  ldr      x8, [x8, #0xc70]
006B10D54  ldr      x2, [x8]
006B10D58  ldrb     w8, [x2, #0x53]
006B10D5C  tbnz     w8, #5, #0x6b10d74
006B10D60  mov      x0, x19
006B10D64  str      x20, [x0, #0x40]!
006B10D68  mov      x1, x20
006B10D6C  bl       #0x382bcb8 ; 
006B10D70  b        #0x6b10d84 ; 
006B10D74  ldr      x8, [x2, #0x60]
006B10D78  mov      x0, x19
006B10D7C  mov      x1, x20
006B10D80  blr      x8
006B10D84  mov      x0, x19
006B10D88  mov      x1, xzr
006B10D8C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B10D90  adrp     x21, #0x959f000
006B10D94  ldrb     w8, [x21, #0x9ad]
006B10D98  mov      x20, x0
006B10D9C  cbnz     w8, #0x6b10db4
006B10DA0  adrp     x0, #0x8f3e000
006B10DA4  ldr      x0, [x0, #0xc80]
006B10DA8  bl       #0x382bd14 ; 
006B10DAC  mov      w8, #1
006B10DB0  strb     w8, [x21, #0x9ad]
006B10DB4  adrp     x8, #0x8f3e000
006B10DB8  ldr      x8, [x8, #0xc80]
006B10DBC  ldr      x2, [x8]
006B10DC0  ldrb     w8, [x2, #0x53]
006B10DC4  tbnz     w8, #5, #0x6b10ddc
006B10DC8  str      x20, [x19, #0x48]!
006B10DCC  mov      x0, x19
006B10DD0  mov      x1, x20
006B10DD4  bl       #0x382bcb8 ; 
006B10DD8  b        #0x6b10dec ; 
006B10DDC  ldr      x8, [x2, #0x60]
006B10DE0  mov      x0, x19
006B10DE4  mov      x1, x20
006B10DE8  blr      x8
006B10DEC  ldp      x20, x19, [sp, #0x10]
006B10DF0  mov      w0, #1
006B10DF4  ldp      x30, x21, [sp], #0x20
006B10DF8  ret      

