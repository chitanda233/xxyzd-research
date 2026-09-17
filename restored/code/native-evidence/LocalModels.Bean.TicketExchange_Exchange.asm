; LocalModels.Bean.TicketExchange_Exchange$$readImpl
; RVA 0x6B15C54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B15C54  stp      x30, x21, [sp, #-0x20]!
006B15C58  stp      x20, x19, [sp, #0x10]
006B15C5C  adrp     x20, #0x959f000
006B15C60  adrp     x21, #0x8f3f000
006B15C64  ldrb     w8, [x20, #0x5c7]
006B15C68  ldr      x21, [x21, #0x78]
006B15C6C  mov      x19, x0
006B15C70  tbnz     w8, #0, #0x6b15c88
006B15C74  adrp     x0, #0x8f3f000
006B15C78  ldr      x0, [x0, #0x78]
006B15C7C  bl       #0x382bd14 ; 
006B15C80  mov      w8, #1
006B15C84  strb     w8, [x20, #0x5c7]
006B15C88  ldr      x1, [x21]
006B15C8C  ldrb     w8, [x1, #0x53]
006B15C90  tbnz     w8, #5, #0x6b15ce0
006B15C94  mov      x0, x19
006B15C98  mov      x1, xzr
006B15C9C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B15CA0  adrp     x21, #0x959f000
006B15CA4  ldrb     w8, [x21, #0x9de]
006B15CA8  mov      w20, w0
006B15CAC  cbnz     w8, #0x6b15cc4
006B15CB0  adrp     x0, #0x8f3f000
006B15CB4  ldr      x0, [x0, #0x30]
006B15CB8  bl       #0x382bd14 ; 
006B15CBC  mov      w8, #1
006B15CC0  strb     w8, [x21, #0x9de]
006B15CC4  adrp     x8, #0x8f3f000
006B15CC8  ldr      x8, [x8, #0x30]
006B15CCC  ldr      x2, [x8]
006B15CD0  ldrb     w8, [x2, #0x53]
006B15CD4  tbnz     w8, #5, #0x6b15cf4
006B15CD8  str      w20, [x19, #0x20]
006B15CDC  b        #0x6b15d04 ; 
006B15CE0  ldr      x2, [x1, #0x60]
006B15CE4  mov      x0, x19
006B15CE8  ldp      x20, x19, [sp, #0x10]
006B15CEC  ldp      x30, x21, [sp], #0x20
006B15CF0  br       x2
006B15CF4  ldr      x8, [x2, #0x60]
006B15CF8  mov      x0, x19
006B15CFC  mov      w1, w20
006B15D00  blr      x8
006B15D04  mov      x0, x19
006B15D08  mov      x1, xzr
006B15D0C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B15D10  adrp     x21, #0x959f000
006B15D14  ldrb     w8, [x21, #0x9df]
006B15D18  mov      w20, w0
006B15D1C  cbnz     w8, #0x6b15d34
006B15D20  adrp     x0, #0x8f3f000
006B15D24  ldr      x0, [x0, #0x40]
006B15D28  bl       #0x382bd14 ; 
006B15D2C  mov      w8, #1
006B15D30  strb     w8, [x21, #0x9df]
006B15D34  adrp     x8, #0x8f3f000
006B15D38  ldr      x8, [x8, #0x40]
006B15D3C  ldr      x2, [x8]
006B15D40  ldrb     w8, [x2, #0x53]
006B15D44  tbnz     w8, #5, #0x6b15d50
006B15D48  str      w20, [x19, #0x24]
006B15D4C  b        #0x6b15d60 ; 
006B15D50  ldr      x8, [x2, #0x60]
006B15D54  mov      x0, x19
006B15D58  mov      w1, w20
006B15D5C  blr      x8
006B15D60  mov      x0, x19
006B15D64  mov      x1, xzr
006B15D68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B15D6C  adrp     x21, #0x959f000
006B15D70  ldrb     w8, [x21, #0x9e0]
006B15D74  mov      w20, w0
006B15D78  cbnz     w8, #0x6b15d90
006B15D7C  adrp     x0, #0x8f3f000
006B15D80  ldr      x0, [x0, #0x50]
006B15D84  bl       #0x382bd14 ; 
006B15D88  mov      w8, #1
006B15D8C  strb     w8, [x21, #0x9e0]
006B15D90  adrp     x8, #0x8f3f000
006B15D94  ldr      x8, [x8, #0x50]
006B15D98  ldr      x2, [x8]
006B15D9C  ldrb     w8, [x2, #0x53]
006B15DA0  tbnz     w8, #5, #0x6b15dac
006B15DA4  str      w20, [x19, #0x28]
006B15DA8  b        #0x6b15dbc ; 
006B15DAC  ldr      x8, [x2, #0x60]
006B15DB0  mov      x0, x19
006B15DB4  mov      w1, w20
006B15DB8  blr      x8
006B15DBC  mov      x0, x19
006B15DC0  mov      x1, xzr
006B15DC4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B15DC8  adrp     x21, #0x959f000
006B15DCC  ldrb     w8, [x21, #0x9e1]
006B15DD0  mov      w20, w0
006B15DD4  cbnz     w8, #0x6b15dec
006B15DD8  adrp     x0, #0x8f3f000
006B15DDC  ldr      x0, [x0, #0x60]
006B15DE0  bl       #0x382bd14 ; 
006B15DE4  mov      w8, #1
006B15DE8  strb     w8, [x21, #0x9e1]
006B15DEC  adrp     x8, #0x8f3f000
006B15DF0  ldr      x8, [x8, #0x60]
006B15DF4  ldr      x2, [x8]
006B15DF8  ldrb     w8, [x2, #0x53]
006B15DFC  tbnz     w8, #5, #0x6b15e08
006B15E00  str      w20, [x19, #0x2c]
006B15E04  b        #0x6b15e18 ; 
006B15E08  ldr      x8, [x2, #0x60]
006B15E0C  mov      x0, x19
006B15E10  mov      w1, w20
006B15E14  blr      x8
006B15E18  mov      x0, x19
006B15E1C  mov      x1, xzr
006B15E20  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B15E24  adrp     x21, #0x959f000
006B15E28  ldrb     w8, [x21, #0x9e2]
006B15E2C  mov      w20, w0
006B15E30  cbnz     w8, #0x6b15e48
006B15E34  adrp     x0, #0x8f3f000
006B15E38  ldr      x0, [x0, #0x70]
006B15E3C  bl       #0x382bd14 ; 
006B15E40  mov      w8, #1
006B15E44  strb     w8, [x21, #0x9e2]
006B15E48  adrp     x8, #0x8f3f000
006B15E4C  ldr      x8, [x8, #0x70]
006B15E50  ldr      x2, [x8]
006B15E54  ldrb     w8, [x2, #0x53]
006B15E58  tbnz     w8, #5, #0x6b15e64
006B15E5C  str      w20, [x19, #0x30]
006B15E60  b        #0x6b15e74 ; 
006B15E64  ldr      x8, [x2, #0x60]
006B15E68  mov      x0, x19
006B15E6C  mov      w1, w20
006B15E70  blr      x8
006B15E74  ldp      x20, x19, [sp, #0x10]
006B15E78  mov      w0, #1
006B15E7C  ldp      x30, x21, [sp], #0x20
006B15E80  ret      

