; LocalModels.Bean.GuildBOSS_guildBossMonster$$readImpl
; RVA 0x6A87BEC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A87BEC  stp      x30, x21, [sp, #-0x20]!
006A87BF0  stp      x20, x19, [sp, #0x10]
006A87BF4  adrp     x20, #0x959e000
006A87BF8  adrp     x21, #0x8f38000
006A87BFC  ldrb     w8, [x20, #0xa]
006A87C00  ldr      x21, [x21, #0x7b8]
006A87C04  mov      x19, x0
006A87C08  tbnz     w8, #0, #0x6a87c20
006A87C0C  adrp     x0, #0x8f38000
006A87C10  ldr      x0, [x0, #0x7b8]
006A87C14  bl       #0x382bd14 ; 
006A87C18  mov      w8, #1
006A87C1C  strb     w8, [x20, #0xa]
006A87C20  ldr      x1, [x21]
006A87C24  ldrb     w8, [x1, #0x53]
006A87C28  tbnz     w8, #5, #0x6a87c78
006A87C2C  mov      x0, x19
006A87C30  mov      x1, xzr
006A87C34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A87C38  adrp     x21, #0x959e000
006A87C3C  ldrb     w8, [x21, #0x54d]
006A87C40  mov      w20, w0
006A87C44  cbnz     w8, #0x6a87c5c
006A87C48  adrp     x0, #0x8f38000
006A87C4C  ldr      x0, [x0, #0x760]
006A87C50  bl       #0x382bd14 ; 
006A87C54  mov      w8, #1
006A87C58  strb     w8, [x21, #0x54d]
006A87C5C  adrp     x8, #0x8f38000
006A87C60  ldr      x8, [x8, #0x760]
006A87C64  ldr      x2, [x8]
006A87C68  ldrb     w8, [x2, #0x53]
006A87C6C  tbnz     w8, #5, #0x6a87c8c
006A87C70  str      w20, [x19, #0x20]
006A87C74  b        #0x6a87c9c ; 
006A87C78  ldr      x2, [x1, #0x60]
006A87C7C  mov      x0, x19
006A87C80  ldp      x20, x19, [sp, #0x10]
006A87C84  ldp      x30, x21, [sp], #0x20
006A87C88  br       x2
006A87C8C  ldr      x8, [x2, #0x60]
006A87C90  mov      x0, x19
006A87C94  mov      w1, w20
006A87C98  blr      x8
006A87C9C  mov      x0, x19
006A87CA0  mov      x1, xzr
006A87CA4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A87CA8  adrp     x21, #0x959e000
006A87CAC  ldrb     w8, [x21, #0x54e]
006A87CB0  mov      x20, x0
006A87CB4  cbnz     w8, #0x6a87ccc
006A87CB8  adrp     x0, #0x8f38000
006A87CBC  ldr      x0, [x0, #0x770]
006A87CC0  bl       #0x382bd14 ; 
006A87CC4  mov      w8, #1
006A87CC8  strb     w8, [x21, #0x54e]
006A87CCC  adrp     x8, #0x8f38000
006A87CD0  ldr      x8, [x8, #0x770]
006A87CD4  ldr      x2, [x8]
006A87CD8  ldrb     w8, [x2, #0x53]
006A87CDC  tbnz     w8, #5, #0x6a87cf4
006A87CE0  mov      x0, x19
006A87CE4  str      x20, [x0, #0x28]!
006A87CE8  mov      x1, x20
006A87CEC  bl       #0x382bcb8 ; 
006A87CF0  b        #0x6a87d04 ; 
006A87CF4  ldr      x8, [x2, #0x60]
006A87CF8  mov      x0, x19
006A87CFC  mov      x1, x20
006A87D00  blr      x8
006A87D04  mov      x0, x19
006A87D08  mov      x1, xzr
006A87D0C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A87D10  adrp     x21, #0x959e000
006A87D14  ldrb     w8, [x21, #0x54f]
006A87D18  mov      x20, x0
006A87D1C  cbnz     w8, #0x6a87d34
006A87D20  adrp     x0, #0x8f38000
006A87D24  ldr      x0, [x0, #0x780]
006A87D28  bl       #0x382bd14 ; 
006A87D2C  mov      w8, #1
006A87D30  strb     w8, [x21, #0x54f]
006A87D34  adrp     x8, #0x8f38000
006A87D38  ldr      x8, [x8, #0x780]
006A87D3C  ldr      x2, [x8]
006A87D40  ldrb     w8, [x2, #0x53]
006A87D44  tbnz     w8, #5, #0x6a87d5c
006A87D48  mov      x0, x19
006A87D4C  str      x20, [x0, #0x30]!
006A87D50  mov      x1, x20
006A87D54  bl       #0x382bcb8 ; 
006A87D58  b        #0x6a87d6c ; 
006A87D5C  ldr      x8, [x2, #0x60]
006A87D60  mov      x0, x19
006A87D64  mov      x1, x20
006A87D68  blr      x8
006A87D6C  mov      x0, x19
006A87D70  mov      x1, xzr
006A87D74  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A87D78  adrp     x21, #0x959e000
006A87D7C  ldrb     w8, [x21, #0x550]
006A87D80  mov      x20, x0
006A87D84  cbnz     w8, #0x6a87d9c
006A87D88  adrp     x0, #0x8f38000
006A87D8C  ldr      x0, [x0, #0x790]
006A87D90  bl       #0x382bd14 ; 
006A87D94  mov      w8, #1
006A87D98  strb     w8, [x21, #0x550]
006A87D9C  adrp     x8, #0x8f38000
006A87DA0  ldr      x8, [x8, #0x790]
006A87DA4  ldr      x2, [x8]
006A87DA8  ldrb     w8, [x2, #0x53]
006A87DAC  tbnz     w8, #5, #0x6a87dc4
006A87DB0  mov      x0, x19
006A87DB4  str      x20, [x0, #0x38]!
006A87DB8  mov      x1, x20
006A87DBC  bl       #0x382bcb8 ; 
006A87DC0  b        #0x6a87dd4 ; 
006A87DC4  ldr      x8, [x2, #0x60]
006A87DC8  mov      x0, x19
006A87DCC  mov      x1, x20
006A87DD0  blr      x8
006A87DD4  mov      x0, x19
006A87DD8  mov      x1, xzr
006A87DDC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A87DE0  adrp     x21, #0x959e000
006A87DE4  ldrb     w8, [x21, #0x551]
006A87DE8  mov      x20, x0
006A87DEC  cbnz     w8, #0x6a87e04
006A87DF0  adrp     x0, #0x8f38000
006A87DF4  ldr      x0, [x0, #0x7a0]
006A87DF8  bl       #0x382bd14 ; 
006A87DFC  mov      w8, #1
006A87E00  strb     w8, [x21, #0x551]
006A87E04  adrp     x8, #0x8f38000
006A87E08  ldr      x8, [x8, #0x7a0]
006A87E0C  ldr      x2, [x8]
006A87E10  ldrb     w8, [x2, #0x53]
006A87E14  tbnz     w8, #5, #0x6a87e2c
006A87E18  mov      x0, x19
006A87E1C  str      x20, [x0, #0x40]!
006A87E20  mov      x1, x20
006A87E24  bl       #0x382bcb8 ; 
006A87E28  b        #0x6a87e3c ; 
006A87E2C  ldr      x8, [x2, #0x60]
006A87E30  mov      x0, x19
006A87E34  mov      x1, x20
006A87E38  blr      x8
006A87E3C  mov      x0, x19
006A87E40  mov      x1, xzr
006A87E44  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A87E48  adrp     x21, #0x959e000
006A87E4C  ldrb     w8, [x21, #0x552]
006A87E50  mov      x20, x0
006A87E54  cbnz     w8, #0x6a87e6c
006A87E58  adrp     x0, #0x8f38000
006A87E5C  ldr      x0, [x0, #0x7b0]
006A87E60  bl       #0x382bd14 ; 
006A87E64  mov      w8, #1
006A87E68  strb     w8, [x21, #0x552]
006A87E6C  adrp     x8, #0x8f38000
006A87E70  ldr      x8, [x8, #0x7b0]
006A87E74  ldr      x2, [x8]
006A87E78  ldrb     w8, [x2, #0x53]
006A87E7C  tbnz     w8, #5, #0x6a87e94
006A87E80  str      x20, [x19, #0x48]!
006A87E84  mov      x0, x19
006A87E88  mov      x1, x20
006A87E8C  bl       #0x382bcb8 ; 
006A87E90  b        #0x6a87ea4 ; 
006A87E94  ldr      x8, [x2, #0x60]
006A87E98  mov      x0, x19
006A87E9C  mov      x1, x20
006A87EA0  blr      x8
006A87EA4  ldp      x20, x19, [sp, #0x10]
006A87EA8  mov      w0, #1
006A87EAC  ldp      x30, x21, [sp], #0x20
006A87EB0  ret      

