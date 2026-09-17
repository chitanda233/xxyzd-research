; LocalModels.Bean.Card_card$$readImpl
; RVA 0x6894B98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006894B98  stp      x30, x21, [sp, #-0x20]!
006894B9C  stp      x20, x19, [sp, #0x10]
006894BA0  adrp     x20, #0x959b000
006894BA4  adrp     x21, #0x8f25000
006894BA8  ldrb     w8, [x20, #0xd99]
006894BAC  ldr      x21, [x21, #0xa80]
006894BB0  mov      x19, x0
006894BB4  tbnz     w8, #0, #0x6894bcc
006894BB8  adrp     x0, #0x8f25000
006894BBC  ldr      x0, [x0, #0xa80]
006894BC0  bl       #0x382bd14 ; 
006894BC4  mov      w8, #1
006894BC8  strb     w8, [x20, #0xd99]
006894BCC  ldr      x1, [x21]
006894BD0  ldrb     w8, [x1, #0x53]
006894BD4  tbnz     w8, #5, #0x6894c24
006894BD8  mov      x0, x19
006894BDC  mov      x1, xzr
006894BE0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006894BE4  adrp     x21, #0x959c000
006894BE8  ldrb     w8, [x21, #0x48d]
006894BEC  mov      w20, w0
006894BF0  cbnz     w8, #0x6894c08
006894BF4  adrp     x0, #0x8f25000
006894BF8  ldr      x0, [x0, #0x9c8]
006894BFC  bl       #0x382bd14 ; 
006894C00  mov      w8, #1
006894C04  strb     w8, [x21, #0x48d]
006894C08  adrp     x8, #0x8f25000
006894C0C  ldr      x8, [x8, #0x9c8]
006894C10  ldr      x2, [x8]
006894C14  ldrb     w8, [x2, #0x53]
006894C18  tbnz     w8, #5, #0x6894c38
006894C1C  str      w20, [x19, #0x20]
006894C20  b        #0x6894c48 ; 
006894C24  ldr      x2, [x1, #0x60]
006894C28  mov      x0, x19
006894C2C  ldp      x20, x19, [sp, #0x10]
006894C30  ldp      x30, x21, [sp], #0x20
006894C34  br       x2
006894C38  ldr      x8, [x2, #0x60]
006894C3C  mov      x0, x19
006894C40  mov      w1, w20
006894C44  blr      x8
006894C48  mov      x0, x19
006894C4C  mov      x1, xzr
006894C50  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006894C54  adrp     x21, #0x959c000
006894C58  ldrb     w8, [x21, #0x48e]
006894C5C  mov      x20, x0
006894C60  cbnz     w8, #0x6894c78
006894C64  adrp     x0, #0x8f25000
006894C68  ldr      x0, [x0, #0x9d8]
006894C6C  bl       #0x382bd14 ; 
006894C70  mov      w8, #1
006894C74  strb     w8, [x21, #0x48e]
006894C78  adrp     x8, #0x8f25000
006894C7C  ldr      x8, [x8, #0x9d8]
006894C80  ldr      x2, [x8]
006894C84  ldrb     w8, [x2, #0x53]
006894C88  tbnz     w8, #5, #0x6894ca0
006894C8C  mov      x0, x19
006894C90  str      x20, [x0, #0x28]!
006894C94  mov      x1, x20
006894C98  bl       #0x382bcb8 ; 
006894C9C  b        #0x6894cb0 ; 
006894CA0  ldr      x8, [x2, #0x60]
006894CA4  mov      x0, x19
006894CA8  mov      x1, x20
006894CAC  blr      x8
006894CB0  mov      x0, x19
006894CB4  mov      x1, xzr
006894CB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006894CBC  adrp     x21, #0x959c000
006894CC0  ldrb     w8, [x21, #0x48f]
006894CC4  mov      w20, w0
006894CC8  cbnz     w8, #0x6894ce0
006894CCC  adrp     x0, #0x8f25000
006894CD0  ldr      x0, [x0, #0x9e8]
006894CD4  bl       #0x382bd14 ; 
006894CD8  mov      w8, #1
006894CDC  strb     w8, [x21, #0x48f]
006894CE0  adrp     x8, #0x8f25000
006894CE4  ldr      x8, [x8, #0x9e8]
006894CE8  ldr      x2, [x8]
006894CEC  ldrb     w8, [x2, #0x53]
006894CF0  tbnz     w8, #5, #0x6894cfc
006894CF4  str      w20, [x19, #0x30]
006894CF8  b        #0x6894d0c ; 
006894CFC  ldr      x8, [x2, #0x60]
006894D00  mov      x0, x19
006894D04  mov      w1, w20
006894D08  blr      x8
006894D0C  mov      x0, x19
006894D10  mov      x1, xzr
006894D14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006894D18  adrp     x21, #0x959c000
006894D1C  ldrb     w8, [x21, #0x490]
006894D20  mov      w20, w0
006894D24  cbnz     w8, #0x6894d3c
006894D28  adrp     x0, #0x8f25000
006894D2C  ldr      x0, [x0, #0x9f8]
006894D30  bl       #0x382bd14 ; 
006894D34  mov      w8, #1
006894D38  strb     w8, [x21, #0x490]
006894D3C  adrp     x8, #0x8f25000
006894D40  ldr      x8, [x8, #0x9f8]
006894D44  ldr      x2, [x8]
006894D48  ldrb     w8, [x2, #0x53]
006894D4C  tbnz     w8, #5, #0x6894d58
006894D50  str      w20, [x19, #0x34]
006894D54  b        #0x6894d68 ; 
006894D58  ldr      x8, [x2, #0x60]
006894D5C  mov      x0, x19
006894D60  mov      w1, w20
006894D64  blr      x8
006894D68  mov      x0, x19
006894D6C  mov      x1, xzr
006894D70  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006894D74  adrp     x21, #0x959c000
006894D78  ldrb     w8, [x21, #0x491]
006894D7C  mov      w20, w0
006894D80  cbnz     w8, #0x6894d98
006894D84  adrp     x0, #0x8f25000
006894D88  ldr      x0, [x0, #0xa08]
006894D8C  bl       #0x382bd14 ; 
006894D90  mov      w8, #1
006894D94  strb     w8, [x21, #0x491]
006894D98  adrp     x8, #0x8f25000
006894D9C  ldr      x8, [x8, #0xa08]
006894DA0  ldr      x2, [x8]
006894DA4  ldrb     w8, [x2, #0x53]
006894DA8  tbnz     w8, #5, #0x6894db4
006894DAC  str      w20, [x19, #0x38]
006894DB0  b        #0x6894dc4 ; 
006894DB4  ldr      x8, [x2, #0x60]
006894DB8  mov      x0, x19
006894DBC  mov      w1, w20
006894DC0  blr      x8
006894DC4  mov      x0, x19
006894DC8  mov      x1, xzr
006894DCC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006894DD0  adrp     x21, #0x959c000
006894DD4  ldrb     w8, [x21, #0x492]
006894DD8  mov      w20, w0
006894DDC  cbnz     w8, #0x6894df4
006894DE0  adrp     x0, #0x8f25000
006894DE4  ldr      x0, [x0, #0xa18]
006894DE8  bl       #0x382bd14 ; 
006894DEC  mov      w8, #1
006894DF0  strb     w8, [x21, #0x492]
006894DF4  adrp     x8, #0x8f25000
006894DF8  ldr      x8, [x8, #0xa18]
006894DFC  ldr      x2, [x8]
006894E00  ldrb     w8, [x2, #0x53]
006894E04  tbnz     w8, #5, #0x6894e10
006894E08  str      w20, [x19, #0x3c]
006894E0C  b        #0x6894e20 ; 
006894E10  ldr      x8, [x2, #0x60]
006894E14  mov      x0, x19
006894E18  mov      w1, w20
006894E1C  blr      x8
006894E20  mov      x0, x19
006894E24  mov      x1, xzr
006894E28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006894E2C  adrp     x21, #0x959c000
006894E30  ldrb     w8, [x21, #0x493]
006894E34  mov      w20, w0
006894E38  cbnz     w8, #0x6894e50
006894E3C  adrp     x0, #0x8f25000
006894E40  ldr      x0, [x0, #0xa28]
006894E44  bl       #0x382bd14 ; 
006894E48  mov      w8, #1
006894E4C  strb     w8, [x21, #0x493]
006894E50  adrp     x8, #0x8f25000
006894E54  ldr      x8, [x8, #0xa28]
006894E58  ldr      x2, [x8]
006894E5C  ldrb     w8, [x2, #0x53]
006894E60  tbnz     w8, #5, #0x6894e6c
006894E64  str      w20, [x19, #0x40]
006894E68  b        #0x6894e7c ; 
006894E6C  ldr      x8, [x2, #0x60]
006894E70  mov      x0, x19
006894E74  mov      w1, w20
006894E78  blr      x8
006894E7C  mov      x0, x19
006894E80  mov      x1, xzr
006894E84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006894E88  adrp     x21, #0x959c000
006894E8C  ldrb     w8, [x21, #0x494]
006894E90  mov      w20, w0
006894E94  cbnz     w8, #0x6894eac
006894E98  adrp     x0, #0x8f25000
006894E9C  ldr      x0, [x0, #0xa38]
006894EA0  bl       #0x382bd14 ; 
006894EA4  mov      w8, #1
006894EA8  strb     w8, [x21, #0x494]
006894EAC  adrp     x8, #0x8f25000
006894EB0  ldr      x8, [x8, #0xa38]
006894EB4  ldr      x2, [x8]
006894EB8  ldrb     w8, [x2, #0x53]
006894EBC  tbnz     w8, #5, #0x6894ec8
006894EC0  str      w20, [x19, #0x44]
006894EC4  b        #0x6894ed8 ; 
006894EC8  ldr      x8, [x2, #0x60]
006894ECC  mov      x0, x19
006894ED0  mov      w1, w20
006894ED4  blr      x8
006894ED8  mov      x0, x19
006894EDC  mov      x1, xzr
006894EE0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006894EE4  adrp     x21, #0x959c000
006894EE8  ldrb     w8, [x21, #0x495]
006894EEC  mov      x20, x0
006894EF0  cbnz     w8, #0x6894f08
006894EF4  adrp     x0, #0x8f25000
006894EF8  ldr      x0, [x0, #0xa48]
006894EFC  bl       #0x382bd14 ; 
006894F00  mov      w8, #1
006894F04  strb     w8, [x21, #0x495]
006894F08  adrp     x8, #0x8f25000
006894F0C  ldr      x8, [x8, #0xa48]
006894F10  ldr      x2, [x8]
006894F14  ldrb     w8, [x2, #0x53]
006894F18  tbnz     w8, #5, #0x6894f30
006894F1C  mov      x0, x19
006894F20  str      x20, [x0, #0x48]!
006894F24  mov      x1, x20
006894F28  bl       #0x382bcb8 ; 
006894F2C  b        #0x6894f40 ; 
006894F30  ldr      x8, [x2, #0x60]
006894F34  mov      x0, x19
006894F38  mov      x1, x20
006894F3C  blr      x8
006894F40  mov      x0, x19
006894F44  mov      x1, xzr
006894F48  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006894F4C  adrp     x21, #0x959c000
006894F50  ldrb     w8, [x21, #0x496]
006894F54  mov      w20, w0
006894F58  cbnz     w8, #0x6894f70
006894F5C  adrp     x0, #0x8f25000
006894F60  ldr      x0, [x0, #0xa58]
006894F64  bl       #0x382bd14 ; 
006894F68  mov      w8, #1
006894F6C  strb     w8, [x21, #0x496]
006894F70  adrp     x8, #0x8f25000
006894F74  ldr      x8, [x8, #0xa58]
006894F78  ldr      x2, [x8]
006894F7C  ldrb     w8, [x2, #0x53]
006894F80  tbnz     w8, #5, #0x6894f8c
006894F84  str      w20, [x19, #0x50]
006894F88  b        #0x6894f9c ; 
006894F8C  ldr      x8, [x2, #0x60]
006894F90  mov      x0, x19
006894F94  mov      w1, w20
006894F98  blr      x8
006894F9C  mov      x0, x19
006894FA0  mov      x1, xzr
006894FA4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006894FA8  adrp     x21, #0x959c000
006894FAC  ldrb     w8, [x21, #0x497]
006894FB0  mov      w20, w0
006894FB4  cbnz     w8, #0x6894fcc
006894FB8  adrp     x0, #0x8f25000
006894FBC  ldr      x0, [x0, #0xa68]
006894FC0  bl       #0x382bd14 ; 
006894FC4  mov      w8, #1
006894FC8  strb     w8, [x21, #0x497]
006894FCC  adrp     x8, #0x8f25000
006894FD0  ldr      x8, [x8, #0xa68]
006894FD4  ldr      x2, [x8]
006894FD8  ldrb     w8, [x2, #0x53]
006894FDC  tbnz     w8, #5, #0x6894fe8
006894FE0  str      w20, [x19, #0x54]
006894FE4  b        #0x6894ff8 ; 
006894FE8  ldr      x8, [x2, #0x60]
006894FEC  mov      x0, x19
006894FF0  mov      w1, w20
006894FF4  blr      x8
006894FF8  mov      x0, x19
006894FFC  mov      x1, xzr
006895000  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006895004  adrp     x21, #0x959c000
006895008  ldrb     w8, [x21, #0x498]
00689500C  mov      w20, w0
006895010  cbnz     w8, #0x6895028
006895014  adrp     x0, #0x8f25000
006895018  ldr      x0, [x0, #0xa78]
00689501C  bl       #0x382bd14 ; 
006895020  mov      w8, #1
006895024  strb     w8, [x21, #0x498]
006895028  adrp     x8, #0x8f25000
00689502C  ldr      x8, [x8, #0xa78]
006895030  ldr      x2, [x8]
006895034  ldrb     w8, [x2, #0x53]
006895038  tbnz     w8, #5, #0x6895044
00689503C  str      w20, [x19, #0x58]
006895040  b        #0x6895054 ; 
006895044  ldr      x8, [x2, #0x60]
006895048  mov      x0, x19
00689504C  mov      w1, w20
006895050  blr      x8
006895054  ldp      x20, x19, [sp, #0x10]
006895058  mov      w0, #1
00689505C  ldp      x30, x21, [sp], #0x20
006895060  ret      

