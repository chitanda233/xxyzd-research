; LocalModels.Bean.MissionWorldBoss_WorldBoss$$readImpl
; RVA 0x6AC0A70; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC0A70  stp      x30, x21, [sp, #-0x20]!
006AC0A74  stp      x20, x19, [sp, #0x10]
006AC0A78  adrp     x20, #0x959e000
006AC0A7C  adrp     x21, #0x8f3b000
006AC0A80  ldrb     w8, [x20, #0x978]
006AC0A84  ldr      x21, [x21, #0x2e0]
006AC0A88  mov      x19, x0
006AC0A8C  tbnz     w8, #0, #0x6ac0aa4
006AC0A90  adrp     x0, #0x8f3b000
006AC0A94  ldr      x0, [x0, #0x2e0]
006AC0A98  bl       #0x382bd14 ; 
006AC0A9C  mov      w8, #1
006AC0AA0  strb     w8, [x20, #0x978]
006AC0AA4  ldr      x1, [x21]
006AC0AA8  ldrb     w8, [x1, #0x53]
006AC0AAC  tbnz     w8, #5, #0x6ac0afc
006AC0AB0  mov      x0, x19
006AC0AB4  mov      x1, xzr
006AC0AB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC0ABC  adrp     x21, #0x959f000
006AC0AC0  ldrb     w8, [x21, #0x26]
006AC0AC4  mov      w20, w0
006AC0AC8  cbnz     w8, #0x6ac0ae0
006AC0ACC  adrp     x0, #0x8f3b000
006AC0AD0  ldr      x0, [x0, #0x178]
006AC0AD4  bl       #0x382bd14 ; 
006AC0AD8  mov      w8, #1
006AC0ADC  strb     w8, [x21, #0x26]
006AC0AE0  adrp     x8, #0x8f3b000
006AC0AE4  ldr      x8, [x8, #0x178]
006AC0AE8  ldr      x2, [x8]
006AC0AEC  ldrb     w8, [x2, #0x53]
006AC0AF0  tbnz     w8, #5, #0x6ac0b10
006AC0AF4  str      w20, [x19, #0x20]
006AC0AF8  b        #0x6ac0b20 ; 
006AC0AFC  ldr      x2, [x1, #0x60]
006AC0B00  mov      x0, x19
006AC0B04  ldp      x20, x19, [sp, #0x10]
006AC0B08  ldp      x30, x21, [sp], #0x20
006AC0B0C  br       x2
006AC0B10  ldr      x8, [x2, #0x60]
006AC0B14  mov      x0, x19
006AC0B18  mov      w1, w20
006AC0B1C  blr      x8
006AC0B20  mov      x0, x19
006AC0B24  mov      x1, xzr
006AC0B28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC0B2C  adrp     x21, #0x959f000
006AC0B30  ldrb     w8, [x21, #0x27]
006AC0B34  mov      w20, w0
006AC0B38  cbnz     w8, #0x6ac0b50
006AC0B3C  adrp     x0, #0x8f3b000
006AC0B40  ldr      x0, [x0, #0x188]
006AC0B44  bl       #0x382bd14 ; 
006AC0B48  mov      w8, #1
006AC0B4C  strb     w8, [x21, #0x27]
006AC0B50  adrp     x8, #0x8f3b000
006AC0B54  ldr      x8, [x8, #0x188]
006AC0B58  ldr      x2, [x8]
006AC0B5C  ldrb     w8, [x2, #0x53]
006AC0B60  tbnz     w8, #5, #0x6ac0b6c
006AC0B64  str      w20, [x19, #0x24]
006AC0B68  b        #0x6ac0b7c ; 
006AC0B6C  ldr      x8, [x2, #0x60]
006AC0B70  mov      x0, x19
006AC0B74  mov      w1, w20
006AC0B78  blr      x8
006AC0B7C  mov      x0, x19
006AC0B80  mov      x1, xzr
006AC0B84  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC0B88  adrp     x21, #0x959f000
006AC0B8C  ldrb     w8, [x21, #0x28]
006AC0B90  mov      x20, x0
006AC0B94  cbnz     w8, #0x6ac0bac
006AC0B98  adrp     x0, #0x8f3b000
006AC0B9C  ldr      x0, [x0, #0x198]
006AC0BA0  bl       #0x382bd14 ; 
006AC0BA4  mov      w8, #1
006AC0BA8  strb     w8, [x21, #0x28]
006AC0BAC  adrp     x8, #0x8f3b000
006AC0BB0  ldr      x8, [x8, #0x198]
006AC0BB4  ldr      x2, [x8]
006AC0BB8  ldrb     w8, [x2, #0x53]
006AC0BBC  tbnz     w8, #5, #0x6ac0bc8
006AC0BC0  str      x20, [x19, #0x28]
006AC0BC4  b        #0x6ac0bd8 ; 
006AC0BC8  ldr      x8, [x2, #0x60]
006AC0BCC  mov      x0, x19
006AC0BD0  mov      x1, x20
006AC0BD4  blr      x8
006AC0BD8  mov      x0, x19
006AC0BDC  mov      x1, xzr
006AC0BE0  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC0BE4  adrp     x21, #0x959f000
006AC0BE8  ldrb     w8, [x21, #0x29]
006AC0BEC  mov      x20, x0
006AC0BF0  cbnz     w8, #0x6ac0c08
006AC0BF4  adrp     x0, #0x8f3b000
006AC0BF8  ldr      x0, [x0, #0x1a8]
006AC0BFC  bl       #0x382bd14 ; 
006AC0C00  mov      w8, #1
006AC0C04  strb     w8, [x21, #0x29]
006AC0C08  adrp     x8, #0x8f3b000
006AC0C0C  ldr      x8, [x8, #0x1a8]
006AC0C10  ldr      x2, [x8]
006AC0C14  ldrb     w8, [x2, #0x53]
006AC0C18  tbnz     w8, #5, #0x6ac0c24
006AC0C1C  str      x20, [x19, #0x30]
006AC0C20  b        #0x6ac0c34 ; 
006AC0C24  ldr      x8, [x2, #0x60]
006AC0C28  mov      x0, x19
006AC0C2C  mov      x1, x20
006AC0C30  blr      x8
006AC0C34  mov      x0, x19
006AC0C38  mov      x1, xzr
006AC0C3C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC0C40  adrp     x21, #0x959f000
006AC0C44  ldrb     w8, [x21, #0x2a]
006AC0C48  mov      w20, w0
006AC0C4C  cbnz     w8, #0x6ac0c64
006AC0C50  adrp     x0, #0x8f3b000
006AC0C54  ldr      x0, [x0, #0x1b8]
006AC0C58  bl       #0x382bd14 ; 
006AC0C5C  mov      w8, #1
006AC0C60  strb     w8, [x21, #0x2a]
006AC0C64  adrp     x8, #0x8f3b000
006AC0C68  ldr      x8, [x8, #0x1b8]
006AC0C6C  ldr      x2, [x8]
006AC0C70  ldrb     w8, [x2, #0x53]
006AC0C74  tbnz     w8, #5, #0x6ac0c80
006AC0C78  str      w20, [x19, #0x38]
006AC0C7C  b        #0x6ac0c90 ; 
006AC0C80  ldr      x8, [x2, #0x60]
006AC0C84  mov      x0, x19
006AC0C88  mov      w1, w20
006AC0C8C  blr      x8
006AC0C90  mov      x0, x19
006AC0C94  mov      x1, xzr
006AC0C98  bl       #0x64cabe0 ; LocalModels.BaseLocalBean$$readArrayfp
006AC0C9C  adrp     x21, #0x959f000
006AC0CA0  ldrb     w8, [x21, #0x2b]
006AC0CA4  mov      x20, x0
006AC0CA8  cbnz     w8, #0x6ac0cc0
006AC0CAC  adrp     x0, #0x8f3b000
006AC0CB0  ldr      x0, [x0, #0x1c8]
006AC0CB4  bl       #0x382bd14 ; 
006AC0CB8  mov      w8, #1
006AC0CBC  strb     w8, [x21, #0x2b]
006AC0CC0  adrp     x8, #0x8f3b000
006AC0CC4  ldr      x8, [x8, #0x1c8]
006AC0CC8  ldr      x2, [x8]
006AC0CCC  ldrb     w8, [x2, #0x53]
006AC0CD0  tbnz     w8, #5, #0x6ac0ce8
006AC0CD4  mov      x0, x19
006AC0CD8  str      x20, [x0, #0x40]!
006AC0CDC  mov      x1, x20
006AC0CE0  bl       #0x382bcb8 ; 
006AC0CE4  b        #0x6ac0cf8 ; 
006AC0CE8  ldr      x8, [x2, #0x60]
006AC0CEC  mov      x0, x19
006AC0CF0  mov      x1, x20
006AC0CF4  blr      x8
006AC0CF8  mov      x0, x19
006AC0CFC  mov      x1, xzr
006AC0D00  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AC0D04  adrp     x21, #0x959f000
006AC0D08  ldrb     w8, [x21, #0x2c]
006AC0D0C  mov      x20, x0
006AC0D10  cbnz     w8, #0x6ac0d28
006AC0D14  adrp     x0, #0x8f3b000
006AC0D18  ldr      x0, [x0, #0x1d8]
006AC0D1C  bl       #0x382bd14 ; 
006AC0D20  mov      w8, #1
006AC0D24  strb     w8, [x21, #0x2c]
006AC0D28  adrp     x8, #0x8f3b000
006AC0D2C  ldr      x8, [x8, #0x1d8]
006AC0D30  ldr      x2, [x8]
006AC0D34  ldrb     w8, [x2, #0x53]
006AC0D38  tbnz     w8, #5, #0x6ac0d50
006AC0D3C  mov      x0, x19
006AC0D40  str      x20, [x0, #0x48]!
006AC0D44  mov      x1, x20
006AC0D48  bl       #0x382bcb8 ; 
006AC0D4C  b        #0x6ac0d60 ; 
006AC0D50  ldr      x8, [x2, #0x60]
006AC0D54  mov      x0, x19
006AC0D58  mov      x1, x20
006AC0D5C  blr      x8
006AC0D60  mov      x0, x19
006AC0D64  mov      x1, xzr
006AC0D68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC0D6C  adrp     x21, #0x959f000
006AC0D70  ldrb     w8, [x21, #0x2d]
006AC0D74  mov      w20, w0
006AC0D78  cbnz     w8, #0x6ac0d90
006AC0D7C  adrp     x0, #0x8f3b000
006AC0D80  ldr      x0, [x0, #0x1e8]
006AC0D84  bl       #0x382bd14 ; 
006AC0D88  mov      w8, #1
006AC0D8C  strb     w8, [x21, #0x2d]
006AC0D90  adrp     x8, #0x8f3b000
006AC0D94  ldr      x8, [x8, #0x1e8]
006AC0D98  ldr      x2, [x8]
006AC0D9C  ldrb     w8, [x2, #0x53]
006AC0DA0  tbnz     w8, #5, #0x6ac0dac
006AC0DA4  str      w20, [x19, #0x50]
006AC0DA8  b        #0x6ac0dbc ; 
006AC0DAC  ldr      x8, [x2, #0x60]
006AC0DB0  mov      x0, x19
006AC0DB4  mov      w1, w20
006AC0DB8  blr      x8
006AC0DBC  mov      x0, x19
006AC0DC0  mov      x1, xzr
006AC0DC4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AC0DC8  adrp     x21, #0x959f000
006AC0DCC  ldrb     w8, [x21, #0x2e]
006AC0DD0  mov      x20, x0
006AC0DD4  cbnz     w8, #0x6ac0dec
006AC0DD8  adrp     x0, #0x8f3b000
006AC0DDC  ldr      x0, [x0, #0x1f8]
006AC0DE0  bl       #0x382bd14 ; 
006AC0DE4  mov      w8, #1
006AC0DE8  strb     w8, [x21, #0x2e]
006AC0DEC  adrp     x8, #0x8f3b000
006AC0DF0  ldr      x8, [x8, #0x1f8]
006AC0DF4  ldr      x2, [x8]
006AC0DF8  ldrb     w8, [x2, #0x53]
006AC0DFC  tbnz     w8, #5, #0x6ac0e14
006AC0E00  mov      x0, x19
006AC0E04  str      x20, [x0, #0x58]!
006AC0E08  mov      x1, x20
006AC0E0C  bl       #0x382bcb8 ; 
006AC0E10  b        #0x6ac0e24 ; 
006AC0E14  ldr      x8, [x2, #0x60]
006AC0E18  mov      x0, x19
006AC0E1C  mov      x1, x20
006AC0E20  blr      x8
006AC0E24  mov      x0, x19
006AC0E28  mov      x1, xzr
006AC0E2C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AC0E30  adrp     x21, #0x959f000
006AC0E34  ldrb     w8, [x21, #0x2f]
006AC0E38  mov      x20, x0
006AC0E3C  cbnz     w8, #0x6ac0e54
006AC0E40  adrp     x0, #0x8f3b000
006AC0E44  ldr      x0, [x0, #0x208]
006AC0E48  bl       #0x382bd14 ; 
006AC0E4C  mov      w8, #1
006AC0E50  strb     w8, [x21, #0x2f]
006AC0E54  adrp     x8, #0x8f3b000
006AC0E58  ldr      x8, [x8, #0x208]
006AC0E5C  ldr      x2, [x8]
006AC0E60  ldrb     w8, [x2, #0x53]
006AC0E64  tbnz     w8, #5, #0x6ac0e7c
006AC0E68  mov      x0, x19
006AC0E6C  str      x20, [x0, #0x60]!
006AC0E70  mov      x1, x20
006AC0E74  bl       #0x382bcb8 ; 
006AC0E78  b        #0x6ac0e8c ; 
006AC0E7C  ldr      x8, [x2, #0x60]
006AC0E80  mov      x0, x19
006AC0E84  mov      x1, x20
006AC0E88  blr      x8
006AC0E8C  mov      x0, x19
006AC0E90  mov      x1, xzr
006AC0E94  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AC0E98  adrp     x21, #0x959f000
006AC0E9C  ldrb     w8, [x21, #0x30]
006AC0EA0  mov      x20, x0
006AC0EA4  cbnz     w8, #0x6ac0ebc
006AC0EA8  adrp     x0, #0x8f3b000
006AC0EAC  ldr      x0, [x0, #0x218]
006AC0EB0  bl       #0x382bd14 ; 
006AC0EB4  mov      w8, #1
006AC0EB8  strb     w8, [x21, #0x30]
006AC0EBC  adrp     x8, #0x8f3b000
006AC0EC0  ldr      x8, [x8, #0x218]
006AC0EC4  ldr      x2, [x8]
006AC0EC8  ldrb     w8, [x2, #0x53]
006AC0ECC  tbnz     w8, #5, #0x6ac0ee4
006AC0ED0  mov      x0, x19
006AC0ED4  str      x20, [x0, #0x68]!
006AC0ED8  mov      x1, x20
006AC0EDC  bl       #0x382bcb8 ; 
006AC0EE0  b        #0x6ac0ef4 ; 
006AC0EE4  ldr      x8, [x2, #0x60]
006AC0EE8  mov      x0, x19
006AC0EEC  mov      x1, x20
006AC0EF0  blr      x8
006AC0EF4  mov      x0, x19
006AC0EF8  mov      x1, xzr
006AC0EFC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AC0F00  adrp     x21, #0x959f000
006AC0F04  ldrb     w8, [x21, #0x31]
006AC0F08  mov      x20, x0
006AC0F0C  cbnz     w8, #0x6ac0f24
006AC0F10  adrp     x0, #0x8f3b000
006AC0F14  ldr      x0, [x0, #0x228]
006AC0F18  bl       #0x382bd14 ; 
006AC0F1C  mov      w8, #1
006AC0F20  strb     w8, [x21, #0x31]
006AC0F24  adrp     x8, #0x8f3b000
006AC0F28  ldr      x8, [x8, #0x228]
006AC0F2C  ldr      x2, [x8]
006AC0F30  ldrb     w8, [x2, #0x53]
006AC0F34  tbnz     w8, #5, #0x6ac0f4c
006AC0F38  mov      x0, x19
006AC0F3C  str      x20, [x0, #0x70]!
006AC0F40  mov      x1, x20
006AC0F44  bl       #0x382bcb8 ; 
006AC0F48  b        #0x6ac0f5c ; 
006AC0F4C  ldr      x8, [x2, #0x60]
006AC0F50  mov      x0, x19
006AC0F54  mov      x1, x20
006AC0F58  blr      x8
006AC0F5C  mov      x0, x19
006AC0F60  mov      x1, xzr
006AC0F64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC0F68  adrp     x21, #0x959f000
006AC0F6C  ldrb     w8, [x21, #0x32]
006AC0F70  mov      w20, w0
006AC0F74  cbnz     w8, #0x6ac0f8c
006AC0F78  adrp     x0, #0x8f3b000
006AC0F7C  ldr      x0, [x0, #0x238]
006AC0F80  bl       #0x382bd14 ; 
006AC0F84  mov      w8, #1
006AC0F88  strb     w8, [x21, #0x32]
006AC0F8C  adrp     x8, #0x8f3b000
006AC0F90  ldr      x8, [x8, #0x238]
006AC0F94  ldr      x2, [x8]
006AC0F98  ldrb     w8, [x2, #0x53]
006AC0F9C  tbnz     w8, #5, #0x6ac0fa8
006AC0FA0  str      w20, [x19, #0x78]
006AC0FA4  b        #0x6ac0fb8 ; 
006AC0FA8  ldr      x8, [x2, #0x60]
006AC0FAC  mov      x0, x19
006AC0FB0  mov      w1, w20
006AC0FB4  blr      x8
006AC0FB8  mov      x0, x19
006AC0FBC  mov      x1, xzr
006AC0FC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC0FC4  adrp     x21, #0x959f000
006AC0FC8  ldrb     w8, [x21, #0x33]
006AC0FCC  mov      w20, w0
006AC0FD0  cbnz     w8, #0x6ac0fe8
006AC0FD4  adrp     x0, #0x8f3b000
006AC0FD8  ldr      x0, [x0, #0x248]
006AC0FDC  bl       #0x382bd14 ; 
006AC0FE0  mov      w8, #1
006AC0FE4  strb     w8, [x21, #0x33]
006AC0FE8  adrp     x8, #0x8f3b000
006AC0FEC  ldr      x8, [x8, #0x248]
006AC0FF0  ldr      x2, [x8]
006AC0FF4  ldrb     w8, [x2, #0x53]
006AC0FF8  tbnz     w8, #5, #0x6ac1004
006AC0FFC  str      w20, [x19, #0x7c]
006AC1000  b        #0x6ac1014 ; 
006AC1004  ldr      x8, [x2, #0x60]
006AC1008  mov      x0, x19
006AC100C  mov      w1, w20
006AC1010  blr      x8
006AC1014  mov      x0, x19
006AC1018  mov      x1, xzr
006AC101C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC1020  adrp     x21, #0x959f000
006AC1024  ldrb     w8, [x21, #0x34]
006AC1028  mov      x20, x0
006AC102C  cbnz     w8, #0x6ac1044
006AC1030  adrp     x0, #0x8f3b000
006AC1034  ldr      x0, [x0, #0x258]
006AC1038  bl       #0x382bd14 ; 
006AC103C  mov      w8, #1
006AC1040  strb     w8, [x21, #0x34]
006AC1044  adrp     x8, #0x8f3b000
006AC1048  ldr      x8, [x8, #0x258]
006AC104C  ldr      x2, [x8]
006AC1050  ldrb     w8, [x2, #0x53]
006AC1054  tbnz     w8, #5, #0x6ac1060
006AC1058  str      x20, [x19, #0x80]
006AC105C  b        #0x6ac1070 ; 
006AC1060  ldr      x8, [x2, #0x60]
006AC1064  mov      x0, x19
006AC1068  mov      x1, x20
006AC106C  blr      x8
006AC1070  mov      x0, x19
006AC1074  mov      x1, xzr
006AC1078  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC107C  adrp     x21, #0x959f000
006AC1080  ldrb     w8, [x21, #0x35]
006AC1084  mov      x20, x0
006AC1088  cbnz     w8, #0x6ac10a0
006AC108C  adrp     x0, #0x8f3b000
006AC1090  ldr      x0, [x0, #0x268]
006AC1094  bl       #0x382bd14 ; 
006AC1098  mov      w8, #1
006AC109C  strb     w8, [x21, #0x35]
006AC10A0  adrp     x8, #0x8f3b000
006AC10A4  ldr      x8, [x8, #0x268]
006AC10A8  ldr      x2, [x8]
006AC10AC  ldrb     w8, [x2, #0x53]
006AC10B0  tbnz     w8, #5, #0x6ac10bc
006AC10B4  str      x20, [x19, #0x88]
006AC10B8  b        #0x6ac10cc ; 
006AC10BC  ldr      x8, [x2, #0x60]
006AC10C0  mov      x0, x19
006AC10C4  mov      x1, x20
006AC10C8  blr      x8
006AC10CC  mov      x0, x19
006AC10D0  mov      x1, xzr
006AC10D4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC10D8  adrp     x21, #0x959f000
006AC10DC  ldrb     w8, [x21, #0x36]
006AC10E0  mov      x20, x0
006AC10E4  cbnz     w8, #0x6ac10fc
006AC10E8  adrp     x0, #0x8f3b000
006AC10EC  ldr      x0, [x0, #0x278]
006AC10F0  bl       #0x382bd14 ; 
006AC10F4  mov      w8, #1
006AC10F8  strb     w8, [x21, #0x36]
006AC10FC  adrp     x8, #0x8f3b000
006AC1100  ldr      x8, [x8, #0x278]
006AC1104  ldr      x2, [x8]
006AC1108  ldrb     w8, [x2, #0x53]
006AC110C  tbnz     w8, #5, #0x6ac1118
006AC1110  str      x20, [x19, #0x90]
006AC1114  b        #0x6ac1128 ; 
006AC1118  ldr      x8, [x2, #0x60]
006AC111C  mov      x0, x19
006AC1120  mov      x1, x20
006AC1124  blr      x8
006AC1128  mov      x0, x19
006AC112C  mov      x1, xzr
006AC1130  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC1134  adrp     x21, #0x959f000
006AC1138  ldrb     w8, [x21, #0x37]
006AC113C  mov      x20, x0
006AC1140  cbnz     w8, #0x6ac1158
006AC1144  adrp     x0, #0x8f3b000
006AC1148  ldr      x0, [x0, #0x288]
006AC114C  bl       #0x382bd14 ; 
006AC1150  mov      w8, #1
006AC1154  strb     w8, [x21, #0x37]
006AC1158  adrp     x8, #0x8f3b000
006AC115C  ldr      x8, [x8, #0x288]
006AC1160  ldr      x2, [x8]
006AC1164  ldrb     w8, [x2, #0x53]
006AC1168  tbnz     w8, #5, #0x6ac1174
006AC116C  str      x20, [x19, #0x98]
006AC1170  b        #0x6ac1184 ; 
006AC1174  ldr      x8, [x2, #0x60]
006AC1178  mov      x0, x19
006AC117C  mov      x1, x20
006AC1180  blr      x8
006AC1184  mov      x0, x19
006AC1188  mov      x1, xzr
006AC118C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC1190  adrp     x21, #0x959f000
006AC1194  ldrb     w8, [x21, #0x38]
006AC1198  mov      w20, w0
006AC119C  cbnz     w8, #0x6ac11b4
006AC11A0  adrp     x0, #0x8f3b000
006AC11A4  ldr      x0, [x0, #0x298]
006AC11A8  bl       #0x382bd14 ; 
006AC11AC  mov      w8, #1
006AC11B0  strb     w8, [x21, #0x38]
006AC11B4  adrp     x8, #0x8f3b000
006AC11B8  ldr      x8, [x8, #0x298]
006AC11BC  ldr      x2, [x8]
006AC11C0  ldrb     w8, [x2, #0x53]
006AC11C4  tbnz     w8, #5, #0x6ac11d0
006AC11C8  str      w20, [x19, #0xa0]
006AC11CC  b        #0x6ac11e0 ; 
006AC11D0  ldr      x8, [x2, #0x60]
006AC11D4  mov      x0, x19
006AC11D8  mov      w1, w20
006AC11DC  blr      x8
006AC11E0  mov      x0, x19
006AC11E4  mov      x1, xzr
006AC11E8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AC11EC  adrp     x21, #0x959f000
006AC11F0  ldrb     w8, [x21, #0x39]
006AC11F4  mov      x20, x0
006AC11F8  cbnz     w8, #0x6ac1210
006AC11FC  adrp     x0, #0x8f3b000
006AC1200  ldr      x0, [x0, #0x2a8]
006AC1204  bl       #0x382bd14 ; 
006AC1208  mov      w8, #1
006AC120C  strb     w8, [x21, #0x39]
006AC1210  adrp     x8, #0x8f3b000
006AC1214  ldr      x8, [x8, #0x2a8]
006AC1218  ldr      x2, [x8]
006AC121C  ldrb     w8, [x2, #0x53]
006AC1220  tbnz     w8, #5, #0x6ac1238
006AC1224  mov      x0, x19
006AC1228  str      x20, [x0, #0xa8]!
006AC122C  mov      x1, x20
006AC1230  bl       #0x382bcb8 ; 
006AC1234  b        #0x6ac1248 ; 
006AC1238  ldr      x8, [x2, #0x60]
006AC123C  mov      x0, x19
006AC1240  mov      x1, x20
006AC1244  blr      x8
006AC1248  mov      x0, x19
006AC124C  mov      x1, xzr
006AC1250  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC1254  adrp     x21, #0x959f000
006AC1258  ldrb     w8, [x21, #0x3a]
006AC125C  mov      w20, w0
006AC1260  cbnz     w8, #0x6ac1278
006AC1264  adrp     x0, #0x8f3b000
006AC1268  ldr      x0, [x0, #0x2b8]
006AC126C  bl       #0x382bd14 ; 
006AC1270  mov      w8, #1
006AC1274  strb     w8, [x21, #0x3a]
006AC1278  adrp     x8, #0x8f3b000
006AC127C  ldr      x8, [x8, #0x2b8]
006AC1280  ldr      x2, [x8]
006AC1284  ldrb     w8, [x2, #0x53]
006AC1288  tbnz     w8, #5, #0x6ac1294
006AC128C  str      w20, [x19, #0xb0]
006AC1290  b        #0x6ac12a4 ; 
006AC1294  ldr      x8, [x2, #0x60]
006AC1298  mov      x0, x19
006AC129C  mov      w1, w20
006AC12A0  blr      x8
006AC12A4  mov      x0, x19
006AC12A8  mov      x1, xzr
006AC12AC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AC12B0  adrp     x21, #0x959f000
006AC12B4  ldrb     w8, [x21, #0x3b]
006AC12B8  mov      x20, x0
006AC12BC  cbnz     w8, #0x6ac12d4
006AC12C0  adrp     x0, #0x8f3b000
006AC12C4  ldr      x0, [x0, #0x2c8]
006AC12C8  bl       #0x382bd14 ; 
006AC12CC  mov      w8, #1
006AC12D0  strb     w8, [x21, #0x3b]
006AC12D4  adrp     x8, #0x8f3b000
006AC12D8  ldr      x8, [x8, #0x2c8]
006AC12DC  ldr      x2, [x8]
006AC12E0  ldrb     w8, [x2, #0x53]
006AC12E4  tbnz     w8, #5, #0x6ac12fc
006AC12E8  mov      x0, x19
006AC12EC  str      x20, [x0, #0xb8]!
006AC12F0  mov      x1, x20
006AC12F4  bl       #0x382bcb8 ; 
006AC12F8  b        #0x6ac130c ; 
006AC12FC  ldr      x8, [x2, #0x60]
006AC1300  mov      x0, x19
006AC1304  mov      x1, x20
006AC1308  blr      x8
006AC130C  mov      x0, x19
006AC1310  mov      x1, xzr
006AC1314  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AC1318  adrp     x21, #0x959f000
006AC131C  ldrb     w8, [x21, #0x3c]
006AC1320  mov      x20, x0
006AC1324  cbnz     w8, #0x6ac133c
006AC1328  adrp     x0, #0x8f3b000
006AC132C  ldr      x0, [x0, #0x2d8]
006AC1330  bl       #0x382bd14 ; 
006AC1334  mov      w8, #1
006AC1338  strb     w8, [x21, #0x3c]
006AC133C  adrp     x8, #0x8f3b000
006AC1340  ldr      x8, [x8, #0x2d8]
006AC1344  ldr      x2, [x8]
006AC1348  ldrb     w8, [x2, #0x53]
006AC134C  tbnz     w8, #5, #0x6ac1364
006AC1350  str      x20, [x19, #0xc0]!
006AC1354  mov      x0, x19
006AC1358  mov      x1, x20
006AC135C  bl       #0x382bcb8 ; 
006AC1360  b        #0x6ac1374 ; 
006AC1364  ldr      x8, [x2, #0x60]
006AC1368  mov      x0, x19
006AC136C  mov      x1, x20
006AC1370  blr      x8
006AC1374  ldp      x20, x19, [sp, #0x10]
006AC1378  mov      w0, #1
006AC137C  ldp      x30, x21, [sp], #0x20
006AC1380  ret      

