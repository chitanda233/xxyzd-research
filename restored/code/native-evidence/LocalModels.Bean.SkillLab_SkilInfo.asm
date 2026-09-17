; LocalModels.Bean.SkillLab_SkilInfo$$readImpl
; RVA 0x6B01BDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B01BDC  stp      x30, x21, [sp, #-0x20]!
006B01BE0  stp      x20, x19, [sp, #0x10]
006B01BE4  adrp     x20, #0x959f000
006B01BE8  adrp     x21, #0x8f3e000
006B01BEC  ldrb     w8, [x20, #0x3b6]
006B01BF0  ldr      x21, [x21, #0x2e0]
006B01BF4  mov      x19, x0
006B01BF8  tbnz     w8, #0, #0x6b01c10
006B01BFC  adrp     x0, #0x8f3e000
006B01C00  ldr      x0, [x0, #0x2e0]
006B01C04  bl       #0x382bd14 ; 
006B01C08  mov      w8, #1
006B01C0C  strb     w8, [x20, #0x3b6]
006B01C10  ldr      x1, [x21]
006B01C14  ldrb     w8, [x1, #0x53]
006B01C18  tbnz     w8, #5, #0x6b01c68
006B01C1C  mov      x0, x19
006B01C20  mov      x1, xzr
006B01C24  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B01C28  adrp     x21, #0x959f000
006B01C2C  ldrb     w8, [x21, #0x8ff]
006B01C30  mov      w20, w0
006B01C34  cbnz     w8, #0x6b01c4c
006B01C38  adrp     x0, #0x8f3e000
006B01C3C  ldr      x0, [x0, #0x298]
006B01C40  bl       #0x382bd14 ; 
006B01C44  mov      w8, #1
006B01C48  strb     w8, [x21, #0x8ff]
006B01C4C  adrp     x8, #0x8f3e000
006B01C50  ldr      x8, [x8, #0x298]
006B01C54  ldr      x2, [x8]
006B01C58  ldrb     w8, [x2, #0x53]
006B01C5C  tbnz     w8, #5, #0x6b01c7c
006B01C60  str      w20, [x19, #0x20]
006B01C64  b        #0x6b01c8c ; 
006B01C68  ldr      x2, [x1, #0x60]
006B01C6C  mov      x0, x19
006B01C70  ldp      x20, x19, [sp, #0x10]
006B01C74  ldp      x30, x21, [sp], #0x20
006B01C78  br       x2
006B01C7C  ldr      x8, [x2, #0x60]
006B01C80  mov      x0, x19
006B01C84  mov      w1, w20
006B01C88  blr      x8
006B01C8C  mov      x0, x19
006B01C90  mov      x1, xzr
006B01C94  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B01C98  adrp     x21, #0x959f000
006B01C9C  ldrb     w8, [x21, #0x900]
006B01CA0  mov      x20, x0
006B01CA4  cbnz     w8, #0x6b01cbc
006B01CA8  adrp     x0, #0x8f3e000
006B01CAC  ldr      x0, [x0, #0x2a8]
006B01CB0  bl       #0x382bd14 ; 
006B01CB4  mov      w8, #1
006B01CB8  strb     w8, [x21, #0x900]
006B01CBC  adrp     x8, #0x8f3e000
006B01CC0  ldr      x8, [x8, #0x2a8]
006B01CC4  ldr      x2, [x8]
006B01CC8  ldrb     w8, [x2, #0x53]
006B01CCC  tbnz     w8, #5, #0x6b01ce4
006B01CD0  mov      x0, x19
006B01CD4  str      x20, [x0, #0x28]!
006B01CD8  mov      x1, x20
006B01CDC  bl       #0x382bcb8 ; 
006B01CE0  b        #0x6b01cf4 ; 
006B01CE4  ldr      x8, [x2, #0x60]
006B01CE8  mov      x0, x19
006B01CEC  mov      x1, x20
006B01CF0  blr      x8
006B01CF4  mov      x0, x19
006B01CF8  mov      x1, xzr
006B01CFC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B01D00  adrp     x21, #0x959f000
006B01D04  ldrb     w8, [x21, #0x901]
006B01D08  mov      x20, x0
006B01D0C  cbnz     w8, #0x6b01d24
006B01D10  adrp     x0, #0x8f3e000
006B01D14  ldr      x0, [x0, #0x2b8]
006B01D18  bl       #0x382bd14 ; 
006B01D1C  mov      w8, #1
006B01D20  strb     w8, [x21, #0x901]
006B01D24  adrp     x8, #0x8f3e000
006B01D28  ldr      x8, [x8, #0x2b8]
006B01D2C  ldr      x2, [x8]
006B01D30  ldrb     w8, [x2, #0x53]
006B01D34  tbnz     w8, #5, #0x6b01d4c
006B01D38  mov      x0, x19
006B01D3C  str      x20, [x0, #0x30]!
006B01D40  mov      x1, x20
006B01D44  bl       #0x382bcb8 ; 
006B01D48  b        #0x6b01d5c ; 
006B01D4C  ldr      x8, [x2, #0x60]
006B01D50  mov      x0, x19
006B01D54  mov      x1, x20
006B01D58  blr      x8
006B01D5C  mov      x0, x19
006B01D60  mov      x1, xzr
006B01D64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B01D68  adrp     x21, #0x959f000
006B01D6C  ldrb     w8, [x21, #0x902]
006B01D70  mov      w20, w0
006B01D74  cbnz     w8, #0x6b01d8c
006B01D78  adrp     x0, #0x8f3e000
006B01D7C  ldr      x0, [x0, #0x2c8]
006B01D80  bl       #0x382bd14 ; 
006B01D84  mov      w8, #1
006B01D88  strb     w8, [x21, #0x902]
006B01D8C  adrp     x8, #0x8f3e000
006B01D90  ldr      x8, [x8, #0x2c8]
006B01D94  ldr      x2, [x8]
006B01D98  ldrb     w8, [x2, #0x53]
006B01D9C  tbnz     w8, #5, #0x6b01da8
006B01DA0  str      w20, [x19, #0x38]
006B01DA4  b        #0x6b01db8 ; 
006B01DA8  ldr      x8, [x2, #0x60]
006B01DAC  mov      x0, x19
006B01DB0  mov      w1, w20
006B01DB4  blr      x8
006B01DB8  mov      x0, x19
006B01DBC  mov      x1, xzr
006B01DC0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B01DC4  adrp     x21, #0x959f000
006B01DC8  ldrb     w8, [x21, #0x903]
006B01DCC  mov      x20, x0
006B01DD0  cbnz     w8, #0x6b01de8
006B01DD4  adrp     x0, #0x8f3e000
006B01DD8  ldr      x0, [x0, #0x2d8]
006B01DDC  bl       #0x382bd14 ; 
006B01DE0  mov      w8, #1
006B01DE4  strb     w8, [x21, #0x903]
006B01DE8  adrp     x8, #0x8f3e000
006B01DEC  ldr      x8, [x8, #0x2d8]
006B01DF0  ldr      x2, [x8]
006B01DF4  ldrb     w8, [x2, #0x53]
006B01DF8  tbnz     w8, #5, #0x6b01e10
006B01DFC  str      x20, [x19, #0x40]!
006B01E00  mov      x0, x19
006B01E04  mov      x1, x20
006B01E08  bl       #0x382bcb8 ; 
006B01E0C  b        #0x6b01e20 ; 
006B01E10  ldr      x8, [x2, #0x60]
006B01E14  mov      x0, x19
006B01E18  mov      x1, x20
006B01E1C  blr      x8
006B01E20  ldp      x20, x19, [sp, #0x10]
006B01E24  mov      w0, #1
006B01E28  ldp      x30, x21, [sp], #0x20
006B01E2C  ret      

