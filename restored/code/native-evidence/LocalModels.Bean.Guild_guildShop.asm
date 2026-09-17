; LocalModels.Bean.Guild_guildShop$$readImpl
; RVA 0x6A94D20; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A94D20  stp      x30, x21, [sp, #-0x20]!
006A94D24  stp      x20, x19, [sp, #0x10]
006A94D28  adrp     x20, #0x959e000
006A94D2C  adrp     x21, #0x8f39000
006A94D30  ldrb     w8, [x20, #0x16c]
006A94D34  ldr      x21, [x21, #0x170]
006A94D38  mov      x19, x0
006A94D3C  tbnz     w8, #0, #0x6a94d54
006A94D40  adrp     x0, #0x8f39000
006A94D44  ldr      x0, [x0, #0x170]
006A94D48  bl       #0x382bd14 ; 
006A94D4C  mov      w8, #1
006A94D50  strb     w8, [x20, #0x16c]
006A94D54  ldr      x1, [x21]
006A94D58  ldrb     w8, [x1, #0x53]
006A94D5C  tbnz     w8, #5, #0x6a94dac
006A94D60  mov      x0, x19
006A94D64  mov      x1, xzr
006A94D68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A94D6C  adrp     x21, #0x959e000
006A94D70  ldrb     w8, [x21, #0x5d4]
006A94D74  mov      w20, w0
006A94D78  cbnz     w8, #0x6a94d90
006A94D7C  adrp     x0, #0x8f39000
006A94D80  ldr      x0, [x0, #0xb8]
006A94D84  bl       #0x382bd14 ; 
006A94D88  mov      w8, #1
006A94D8C  strb     w8, [x21, #0x5d4]
006A94D90  adrp     x8, #0x8f39000
006A94D94  ldr      x8, [x8, #0xb8]
006A94D98  ldr      x2, [x8]
006A94D9C  ldrb     w8, [x2, #0x53]
006A94DA0  tbnz     w8, #5, #0x6a94dc0
006A94DA4  str      w20, [x19, #0x20]
006A94DA8  b        #0x6a94dd0 ; 
006A94DAC  ldr      x2, [x1, #0x60]
006A94DB0  mov      x0, x19
006A94DB4  ldp      x20, x19, [sp, #0x10]
006A94DB8  ldp      x30, x21, [sp], #0x20
006A94DBC  br       x2
006A94DC0  ldr      x8, [x2, #0x60]
006A94DC4  mov      x0, x19
006A94DC8  mov      w1, w20
006A94DCC  blr      x8
006A94DD0  mov      x0, x19
006A94DD4  mov      x1, xzr
006A94DD8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A94DDC  adrp     x21, #0x959e000
006A94DE0  ldrb     w8, [x21, #0x5d5]
006A94DE4  mov      w20, w0
006A94DE8  cbnz     w8, #0x6a94e00
006A94DEC  adrp     x0, #0x8f39000
006A94DF0  ldr      x0, [x0, #0xc8]
006A94DF4  bl       #0x382bd14 ; 
006A94DF8  mov      w8, #1
006A94DFC  strb     w8, [x21, #0x5d5]
006A94E00  adrp     x8, #0x8f39000
006A94E04  ldr      x8, [x8, #0xc8]
006A94E08  ldr      x2, [x8]
006A94E0C  ldrb     w8, [x2, #0x53]
006A94E10  tbnz     w8, #5, #0x6a94e1c
006A94E14  str      w20, [x19, #0x24]
006A94E18  b        #0x6a94e2c ; 
006A94E1C  ldr      x8, [x2, #0x60]
006A94E20  mov      x0, x19
006A94E24  mov      w1, w20
006A94E28  blr      x8
006A94E2C  mov      x0, x19
006A94E30  mov      x1, xzr
006A94E34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A94E38  adrp     x21, #0x959e000
006A94E3C  ldrb     w8, [x21, #0x5d6]
006A94E40  mov      w20, w0
006A94E44  cbnz     w8, #0x6a94e5c
006A94E48  adrp     x0, #0x8f39000
006A94E4C  ldr      x0, [x0, #0xd8]
006A94E50  bl       #0x382bd14 ; 
006A94E54  mov      w8, #1
006A94E58  strb     w8, [x21, #0x5d6]
006A94E5C  adrp     x8, #0x8f39000
006A94E60  ldr      x8, [x8, #0xd8]
006A94E64  ldr      x2, [x8]
006A94E68  ldrb     w8, [x2, #0x53]
006A94E6C  tbnz     w8, #5, #0x6a94e78
006A94E70  str      w20, [x19, #0x28]
006A94E74  b        #0x6a94e88 ; 
006A94E78  ldr      x8, [x2, #0x60]
006A94E7C  mov      x0, x19
006A94E80  mov      w1, w20
006A94E84  blr      x8
006A94E88  mov      x0, x19
006A94E8C  mov      x1, xzr
006A94E90  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A94E94  adrp     x21, #0x959e000
006A94E98  ldrb     w8, [x21, #0x5d7]
006A94E9C  mov      x20, x0
006A94EA0  cbnz     w8, #0x6a94eb8
006A94EA4  adrp     x0, #0x8f39000
006A94EA8  ldr      x0, [x0, #0xe8]
006A94EAC  bl       #0x382bd14 ; 
006A94EB0  mov      w8, #1
006A94EB4  strb     w8, [x21, #0x5d7]
006A94EB8  adrp     x8, #0x8f39000
006A94EBC  ldr      x8, [x8, #0xe8]
006A94EC0  ldr      x2, [x8]
006A94EC4  ldrb     w8, [x2, #0x53]
006A94EC8  tbnz     w8, #5, #0x6a94ee0
006A94ECC  mov      x0, x19
006A94ED0  str      x20, [x0, #0x30]!
006A94ED4  mov      x1, x20
006A94ED8  bl       #0x382bcb8 ; 
006A94EDC  b        #0x6a94ef0 ; 
006A94EE0  ldr      x8, [x2, #0x60]
006A94EE4  mov      x0, x19
006A94EE8  mov      x1, x20
006A94EEC  blr      x8
006A94EF0  mov      x0, x19
006A94EF4  mov      x1, xzr
006A94EF8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A94EFC  adrp     x21, #0x959e000
006A94F00  ldrb     w8, [x21, #0x5d8]
006A94F04  mov      x20, x0
006A94F08  cbnz     w8, #0x6a94f20
006A94F0C  adrp     x0, #0x8f39000
006A94F10  ldr      x0, [x0, #0xf8]
006A94F14  bl       #0x382bd14 ; 
006A94F18  mov      w8, #1
006A94F1C  strb     w8, [x21, #0x5d8]
006A94F20  adrp     x8, #0x8f39000
006A94F24  ldr      x8, [x8, #0xf8]
006A94F28  ldr      x2, [x8]
006A94F2C  ldrb     w8, [x2, #0x53]
006A94F30  tbnz     w8, #5, #0x6a94f48
006A94F34  mov      x0, x19
006A94F38  str      x20, [x0, #0x38]!
006A94F3C  mov      x1, x20
006A94F40  bl       #0x382bcb8 ; 
006A94F44  b        #0x6a94f58 ; 
006A94F48  ldr      x8, [x2, #0x60]
006A94F4C  mov      x0, x19
006A94F50  mov      x1, x20
006A94F54  blr      x8
006A94F58  mov      x0, x19
006A94F5C  mov      x1, xzr
006A94F60  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A94F64  adrp     x21, #0x959e000
006A94F68  ldrb     w8, [x21, #0x5d9]
006A94F6C  mov      x20, x0
006A94F70  cbnz     w8, #0x6a94f88
006A94F74  adrp     x0, #0x8f39000
006A94F78  ldr      x0, [x0, #0x108]
006A94F7C  bl       #0x382bd14 ; 
006A94F80  mov      w8, #1
006A94F84  strb     w8, [x21, #0x5d9]
006A94F88  adrp     x8, #0x8f39000
006A94F8C  ldr      x8, [x8, #0x108]
006A94F90  ldr      x2, [x8]
006A94F94  ldrb     w8, [x2, #0x53]
006A94F98  tbnz     w8, #5, #0x6a94fb0
006A94F9C  mov      x0, x19
006A94FA0  str      x20, [x0, #0x40]!
006A94FA4  mov      x1, x20
006A94FA8  bl       #0x382bcb8 ; 
006A94FAC  b        #0x6a94fc0 ; 
006A94FB0  ldr      x8, [x2, #0x60]
006A94FB4  mov      x0, x19
006A94FB8  mov      x1, x20
006A94FBC  blr      x8
006A94FC0  mov      x0, x19
006A94FC4  mov      x1, xzr
006A94FC8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A94FCC  adrp     x21, #0x959e000
006A94FD0  ldrb     w8, [x21, #0x5da]
006A94FD4  mov      w20, w0
006A94FD8  cbnz     w8, #0x6a94ff0
006A94FDC  adrp     x0, #0x8f39000
006A94FE0  ldr      x0, [x0, #0x118]
006A94FE4  bl       #0x382bd14 ; 
006A94FE8  mov      w8, #1
006A94FEC  strb     w8, [x21, #0x5da]
006A94FF0  adrp     x8, #0x8f39000
006A94FF4  ldr      x8, [x8, #0x118]
006A94FF8  ldr      x2, [x8]
006A94FFC  ldrb     w8, [x2, #0x53]
006A95000  tbnz     w8, #5, #0x6a9500c
006A95004  str      w20, [x19, #0x48]
006A95008  b        #0x6a9501c ; 
006A9500C  ldr      x8, [x2, #0x60]
006A95010  mov      x0, x19
006A95014  mov      w1, w20
006A95018  blr      x8
006A9501C  mov      x0, x19
006A95020  mov      x1, xzr
006A95024  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A95028  adrp     x21, #0x959e000
006A9502C  ldrb     w8, [x21, #0x5db]
006A95030  mov      w20, w0
006A95034  cbnz     w8, #0x6a9504c
006A95038  adrp     x0, #0x8f39000
006A9503C  ldr      x0, [x0, #0x128]
006A95040  bl       #0x382bd14 ; 
006A95044  mov      w8, #1
006A95048  strb     w8, [x21, #0x5db]
006A9504C  adrp     x8, #0x8f39000
006A95050  ldr      x8, [x8, #0x128]
006A95054  ldr      x2, [x8]
006A95058  ldrb     w8, [x2, #0x53]
006A9505C  tbnz     w8, #5, #0x6a95068
006A95060  str      w20, [x19, #0x4c]
006A95064  b        #0x6a95078 ; 
006A95068  ldr      x8, [x2, #0x60]
006A9506C  mov      x0, x19
006A95070  mov      w1, w20
006A95074  blr      x8
006A95078  mov      x0, x19
006A9507C  mov      x1, xzr
006A95080  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A95084  adrp     x21, #0x959e000
006A95088  ldrb     w8, [x21, #0x5dc]
006A9508C  mov      w20, w0
006A95090  cbnz     w8, #0x6a950a8
006A95094  adrp     x0, #0x8f39000
006A95098  ldr      x0, [x0, #0x138]
006A9509C  bl       #0x382bd14 ; 
006A950A0  mov      w8, #1
006A950A4  strb     w8, [x21, #0x5dc]
006A950A8  adrp     x8, #0x8f39000
006A950AC  ldr      x8, [x8, #0x138]
006A950B0  ldr      x2, [x8]
006A950B4  ldrb     w8, [x2, #0x53]
006A950B8  tbnz     w8, #5, #0x6a950c4
006A950BC  str      w20, [x19, #0x50]
006A950C0  b        #0x6a950d4 ; 
006A950C4  ldr      x8, [x2, #0x60]
006A950C8  mov      x0, x19
006A950CC  mov      w1, w20
006A950D0  blr      x8
006A950D4  mov      x0, x19
006A950D8  mov      x1, xzr
006A950DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A950E0  adrp     x21, #0x959e000
006A950E4  ldrb     w8, [x21, #0x5dd]
006A950E8  mov      w20, w0
006A950EC  cbnz     w8, #0x6a95104
006A950F0  adrp     x0, #0x8f39000
006A950F4  ldr      x0, [x0, #0x148]
006A950F8  bl       #0x382bd14 ; 
006A950FC  mov      w8, #1
006A95100  strb     w8, [x21, #0x5dd]
006A95104  adrp     x8, #0x8f39000
006A95108  ldr      x8, [x8, #0x148]
006A9510C  ldr      x2, [x8]
006A95110  ldrb     w8, [x2, #0x53]
006A95114  tbnz     w8, #5, #0x6a95120
006A95118  str      w20, [x19, #0x54]
006A9511C  b        #0x6a95130 ; 
006A95120  ldr      x8, [x2, #0x60]
006A95124  mov      x0, x19
006A95128  mov      w1, w20
006A9512C  blr      x8
006A95130  mov      x0, x19
006A95134  mov      x1, xzr
006A95138  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A9513C  adrp     x21, #0x959e000
006A95140  ldrb     w8, [x21, #0x5de]
006A95144  mov      x20, x0
006A95148  cbnz     w8, #0x6a95160
006A9514C  adrp     x0, #0x8f39000
006A95150  ldr      x0, [x0, #0x158]
006A95154  bl       #0x382bd14 ; 
006A95158  mov      w8, #1
006A9515C  strb     w8, [x21, #0x5de]
006A95160  adrp     x8, #0x8f39000
006A95164  ldr      x8, [x8, #0x158]
006A95168  ldr      x2, [x8]
006A9516C  ldrb     w8, [x2, #0x53]
006A95170  tbnz     w8, #5, #0x6a95188
006A95174  mov      x0, x19
006A95178  str      x20, [x0, #0x58]!
006A9517C  mov      x1, x20
006A95180  bl       #0x382bcb8 ; 
006A95184  b        #0x6a95198 ; 
006A95188  ldr      x8, [x2, #0x60]
006A9518C  mov      x0, x19
006A95190  mov      x1, x20
006A95194  blr      x8
006A95198  mov      x0, x19
006A9519C  mov      x1, xzr
006A951A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A951A4  adrp     x21, #0x959e000
006A951A8  ldrb     w8, [x21, #0x5df]
006A951AC  mov      w20, w0
006A951B0  cbnz     w8, #0x6a951c8
006A951B4  adrp     x0, #0x8f39000
006A951B8  ldr      x0, [x0, #0x168]
006A951BC  bl       #0x382bd14 ; 
006A951C0  mov      w8, #1
006A951C4  strb     w8, [x21, #0x5df]
006A951C8  adrp     x8, #0x8f39000
006A951CC  ldr      x8, [x8, #0x168]
006A951D0  ldr      x2, [x8]
006A951D4  ldrb     w8, [x2, #0x53]
006A951D8  tbnz     w8, #5, #0x6a951e4
006A951DC  str      w20, [x19, #0x60]
006A951E0  b        #0x6a951f4 ; 
006A951E4  ldr      x8, [x2, #0x60]
006A951E8  mov      x0, x19
006A951EC  mov      w1, w20
006A951F0  blr      x8
006A951F4  ldp      x20, x19, [sp, #0x10]
006A951F8  mov      w0, #1
006A951FC  ldp      x30, x21, [sp], #0x20
006A95200  ret      

