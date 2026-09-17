; LocalModels.Bean.WorldBoss_WorldRune$$readImpl
; RVA 0x6B25CA4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B25CA4  stp      x30, x21, [sp, #-0x20]!
006B25CA8  stp      x20, x19, [sp, #0x10]
006B25CAC  adrp     x20, #0x959f000
006B25CB0  adrp     x21, #0x8f3f000
006B25CB4  ldrb     w8, [x20, #0x76c]
006B25CB8  ldr      x21, [x21, #0xba8]
006B25CBC  mov      x19, x0
006B25CC0  tbnz     w8, #0, #0x6b25cd8
006B25CC4  adrp     x0, #0x8f3f000
006B25CC8  ldr      x0, [x0, #0xba8]
006B25CCC  bl       #0x382bd14 ; 
006B25CD0  mov      w8, #1
006B25CD4  strb     w8, [x20, #0x76c]
006B25CD8  ldr      x1, [x21]
006B25CDC  ldrb     w8, [x1, #0x53]
006B25CE0  tbnz     w8, #5, #0x6b25d30
006B25CE4  mov      x0, x19
006B25CE8  mov      x1, xzr
006B25CEC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B25CF0  adrp     x21, #0x959f000
006B25CF4  ldrb     w8, [x21, #0xa92]
006B25CF8  mov      w20, w0
006B25CFC  cbnz     w8, #0x6b25d14
006B25D00  adrp     x0, #0x8f3f000
006B25D04  ldr      x0, [x0, #0xb90]
006B25D08  bl       #0x382bd14 ; 
006B25D0C  mov      w8, #1
006B25D10  strb     w8, [x21, #0xa92]
006B25D14  adrp     x8, #0x8f3f000
006B25D18  ldr      x8, [x8, #0xb90]
006B25D1C  ldr      x2, [x8]
006B25D20  ldrb     w8, [x2, #0x53]
006B25D24  tbnz     w8, #5, #0x6b25d44
006B25D28  str      w20, [x19, #0x20]
006B25D2C  b        #0x6b25d54 ; 
006B25D30  ldr      x2, [x1, #0x60]
006B25D34  mov      x0, x19
006B25D38  ldp      x20, x19, [sp, #0x10]
006B25D3C  ldp      x30, x21, [sp], #0x20
006B25D40  br       x2
006B25D44  ldr      x8, [x2, #0x60]
006B25D48  mov      x0, x19
006B25D4C  mov      w1, w20
006B25D50  blr      x8
006B25D54  mov      x0, x19
006B25D58  mov      x1, xzr
006B25D5C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B25D60  adrp     x21, #0x959f000
006B25D64  ldrb     w8, [x21, #0xa93]
006B25D68  mov      x20, x0
006B25D6C  cbnz     w8, #0x6b25d84
006B25D70  adrp     x0, #0x8f3f000
006B25D74  ldr      x0, [x0, #0xba0]
006B25D78  bl       #0x382bd14 ; 
006B25D7C  mov      w8, #1
006B25D80  strb     w8, [x21, #0xa93]
006B25D84  adrp     x8, #0x8f3f000
006B25D88  ldr      x8, [x8, #0xba0]
006B25D8C  ldr      x2, [x8]
006B25D90  ldrb     w8, [x2, #0x53]
006B25D94  tbnz     w8, #5, #0x6b25dac
006B25D98  str      x20, [x19, #0x28]!
006B25D9C  mov      x0, x19
006B25DA0  mov      x1, x20
006B25DA4  bl       #0x382bcb8 ; 
006B25DA8  b        #0x6b25dbc ; 
006B25DAC  ldr      x8, [x2, #0x60]
006B25DB0  mov      x0, x19
006B25DB4  mov      x1, x20
006B25DB8  blr      x8
006B25DBC  ldp      x20, x19, [sp, #0x10]
006B25DC0  mov      w0, #1
006B25DC4  ldp      x30, x21, [sp], #0x20
006B25DC8  ret      

