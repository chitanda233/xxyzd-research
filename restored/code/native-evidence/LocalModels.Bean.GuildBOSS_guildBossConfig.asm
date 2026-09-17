; LocalModels.Bean.GuildBOSS_guildBossConfig$$readImpl
; RVA 0x6A85D18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A85D18  stp      x30, x21, [sp, #-0x20]!
006A85D1C  stp      x20, x19, [sp, #0x10]
006A85D20  adrp     x20, #0x959d000
006A85D24  adrp     x21, #0x8f38000
006A85D28  ldrb     w8, [x20, #0xfd6]
006A85D2C  ldr      x21, [x21, #0x650]
006A85D30  mov      x19, x0
006A85D34  tbnz     w8, #0, #0x6a85d4c
006A85D38  adrp     x0, #0x8f38000
006A85D3C  ldr      x0, [x0, #0x650]
006A85D40  bl       #0x382bd14 ; 
006A85D44  mov      w8, #1
006A85D48  strb     w8, [x20, #0xfd6]
006A85D4C  ldr      x1, [x21]
006A85D50  ldrb     w8, [x1, #0x53]
006A85D54  tbnz     w8, #5, #0x6a85da4
006A85D58  mov      x0, x19
006A85D5C  mov      x1, xzr
006A85D60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A85D64  adrp     x21, #0x959e000
006A85D68  ldrb     w8, [x21, #0x539]
006A85D6C  mov      w20, w0
006A85D70  cbnz     w8, #0x6a85d88
006A85D74  adrp     x0, #0x8f38000
006A85D78  ldr      x0, [x0, #0x5f8]
006A85D7C  bl       #0x382bd14 ; 
006A85D80  mov      w8, #1
006A85D84  strb     w8, [x21, #0x539]
006A85D88  adrp     x8, #0x8f38000
006A85D8C  ldr      x8, [x8, #0x5f8]
006A85D90  ldr      x2, [x8]
006A85D94  ldrb     w8, [x2, #0x53]
006A85D98  tbnz     w8, #5, #0x6a85db8
006A85D9C  str      w20, [x19, #0x20]
006A85DA0  b        #0x6a85dc8 ; 
006A85DA4  ldr      x2, [x1, #0x60]
006A85DA8  mov      x0, x19
006A85DAC  ldp      x20, x19, [sp, #0x10]
006A85DB0  ldp      x30, x21, [sp], #0x20
006A85DB4  br       x2
006A85DB8  ldr      x8, [x2, #0x60]
006A85DBC  mov      x0, x19
006A85DC0  mov      w1, w20
006A85DC4  blr      x8
006A85DC8  mov      x0, x19
006A85DCC  mov      x1, xzr
006A85DD0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A85DD4  adrp     x21, #0x959e000
006A85DD8  ldrb     w8, [x21, #0x53a]
006A85DDC  mov      x20, x0
006A85DE0  cbnz     w8, #0x6a85df8
006A85DE4  adrp     x0, #0x8f38000
006A85DE8  ldr      x0, [x0, #0x608]
006A85DEC  bl       #0x382bd14 ; 
006A85DF0  mov      w8, #1
006A85DF4  strb     w8, [x21, #0x53a]
006A85DF8  adrp     x8, #0x8f38000
006A85DFC  ldr      x8, [x8, #0x608]
006A85E00  ldr      x2, [x8]
006A85E04  ldrb     w8, [x2, #0x53]
006A85E08  tbnz     w8, #5, #0x6a85e20
006A85E0C  mov      x0, x19
006A85E10  str      x20, [x0, #0x28]!
006A85E14  mov      x1, x20
006A85E18  bl       #0x382bcb8 ; 
006A85E1C  b        #0x6a85e30 ; 
006A85E20  ldr      x8, [x2, #0x60]
006A85E24  mov      x0, x19
006A85E28  mov      x1, x20
006A85E2C  blr      x8
006A85E30  mov      x0, x19
006A85E34  mov      x1, xzr
006A85E38  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A85E3C  adrp     x21, #0x959e000
006A85E40  ldrb     w8, [x21, #0x53b]
006A85E44  mov      x20, x0
006A85E48  cbnz     w8, #0x6a85e60
006A85E4C  adrp     x0, #0x8f38000
006A85E50  ldr      x0, [x0, #0x618]
006A85E54  bl       #0x382bd14 ; 
006A85E58  mov      w8, #1
006A85E5C  strb     w8, [x21, #0x53b]
006A85E60  adrp     x8, #0x8f38000
006A85E64  ldr      x8, [x8, #0x618]
006A85E68  ldr      x2, [x8]
006A85E6C  ldrb     w8, [x2, #0x53]
006A85E70  tbnz     w8, #5, #0x6a85e88
006A85E74  mov      x0, x19
006A85E78  str      x20, [x0, #0x30]!
006A85E7C  mov      x1, x20
006A85E80  bl       #0x382bcb8 ; 
006A85E84  b        #0x6a85e98 ; 
006A85E88  ldr      x8, [x2, #0x60]
006A85E8C  mov      x0, x19
006A85E90  mov      x1, x20
006A85E94  blr      x8
006A85E98  mov      x0, x19
006A85E9C  mov      x1, xzr
006A85EA0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A85EA4  adrp     x21, #0x959e000
006A85EA8  ldrb     w8, [x21, #0x53c]
006A85EAC  mov      w20, w0
006A85EB0  cbnz     w8, #0x6a85ec8
006A85EB4  adrp     x0, #0x8f38000
006A85EB8  ldr      x0, [x0, #0x628]
006A85EBC  bl       #0x382bd14 ; 
006A85EC0  mov      w8, #1
006A85EC4  strb     w8, [x21, #0x53c]
006A85EC8  adrp     x8, #0x8f38000
006A85ECC  ldr      x8, [x8, #0x628]
006A85ED0  ldr      x2, [x8]
006A85ED4  ldrb     w8, [x2, #0x53]
006A85ED8  tbnz     w8, #5, #0x6a85ee4
006A85EDC  str      w20, [x19, #0x38]
006A85EE0  b        #0x6a85ef4 ; 
006A85EE4  ldr      x8, [x2, #0x60]
006A85EE8  mov      x0, x19
006A85EEC  mov      w1, w20
006A85EF0  blr      x8
006A85EF4  mov      x0, x19
006A85EF8  mov      x1, xzr
006A85EFC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A85F00  adrp     x21, #0x959e000
006A85F04  ldrb     w8, [x21, #0x53d]
006A85F08  mov      x20, x0
006A85F0C  cbnz     w8, #0x6a85f24
006A85F10  adrp     x0, #0x8f38000
006A85F14  ldr      x0, [x0, #0x638]
006A85F18  bl       #0x382bd14 ; 
006A85F1C  mov      w8, #1
006A85F20  strb     w8, [x21, #0x53d]
006A85F24  adrp     x8, #0x8f38000
006A85F28  ldr      x8, [x8, #0x638]
006A85F2C  ldr      x2, [x8]
006A85F30  ldrb     w8, [x2, #0x53]
006A85F34  tbnz     w8, #5, #0x6a85f4c
006A85F38  mov      x0, x19
006A85F3C  str      x20, [x0, #0x40]!
006A85F40  mov      x1, x20
006A85F44  bl       #0x382bcb8 ; 
006A85F48  b        #0x6a85f5c ; 
006A85F4C  ldr      x8, [x2, #0x60]
006A85F50  mov      x0, x19
006A85F54  mov      x1, x20
006A85F58  blr      x8
006A85F5C  mov      x0, x19
006A85F60  mov      x1, xzr
006A85F64  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A85F68  adrp     x21, #0x959e000
006A85F6C  ldrb     w8, [x21, #0x53e]
006A85F70  mov      x20, x0
006A85F74  cbnz     w8, #0x6a85f8c
006A85F78  adrp     x0, #0x8f38000
006A85F7C  ldr      x0, [x0, #0x648]
006A85F80  bl       #0x382bd14 ; 
006A85F84  mov      w8, #1
006A85F88  strb     w8, [x21, #0x53e]
006A85F8C  adrp     x8, #0x8f38000
006A85F90  ldr      x8, [x8, #0x648]
006A85F94  ldr      x2, [x8]
006A85F98  ldrb     w8, [x2, #0x53]
006A85F9C  tbnz     w8, #5, #0x6a85fb4
006A85FA0  str      x20, [x19, #0x48]!
006A85FA4  mov      x0, x19
006A85FA8  mov      x1, x20
006A85FAC  bl       #0x382bcb8 ; 
006A85FB0  b        #0x6a85fc4 ; 
006A85FB4  ldr      x8, [x2, #0x60]
006A85FB8  mov      x0, x19
006A85FBC  mov      x1, x20
006A85FC0  blr      x8
006A85FC4  ldp      x20, x19, [sp, #0x10]
006A85FC8  mov      w0, #1
006A85FCC  ldp      x30, x21, [sp], #0x20
006A85FD0  ret      

