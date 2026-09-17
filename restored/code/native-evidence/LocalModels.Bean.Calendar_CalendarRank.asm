; LocalModels.Bean.Calendar_CalendarRank$$readImpl
; RVA 0x6892B94; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006892B94  stp      x30, x21, [sp, #-0x20]!
006892B98  stp      x20, x19, [sp, #0x10]
006892B9C  adrp     x20, #0x959b000
006892BA0  adrp     x21, #0x8f25000
006892BA4  ldrb     w8, [x20, #0xd60]
006892BA8  ldr      x21, [x21, #0x8d0]
006892BAC  mov      x19, x0
006892BB0  tbnz     w8, #0, #0x6892bc8
006892BB4  adrp     x0, #0x8f25000
006892BB8  ldr      x0, [x0, #0x8d0]
006892BBC  bl       #0x382bd14 ; 
006892BC0  mov      w8, #1
006892BC4  strb     w8, [x20, #0xd60]
006892BC8  ldr      x1, [x21]
006892BCC  ldrb     w8, [x1, #0x53]
006892BD0  tbnz     w8, #5, #0x6892c20
006892BD4  mov      x0, x19
006892BD8  mov      x1, xzr
006892BDC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006892BE0  adrp     x21, #0x959c000
006892BE4  ldrb     w8, [x21, #0x47b]
006892BE8  mov      w20, w0
006892BEC  cbnz     w8, #0x6892c04
006892BF0  adrp     x0, #0x8f25000
006892BF4  ldr      x0, [x0, #0x878]
006892BF8  bl       #0x382bd14 ; 
006892BFC  mov      w8, #1
006892C00  strb     w8, [x21, #0x47b]
006892C04  adrp     x8, #0x8f25000
006892C08  ldr      x8, [x8, #0x878]
006892C0C  ldr      x2, [x8]
006892C10  ldrb     w8, [x2, #0x53]
006892C14  tbnz     w8, #5, #0x6892c34
006892C18  str      w20, [x19, #0x20]
006892C1C  b        #0x6892c44 ; 
006892C20  ldr      x2, [x1, #0x60]
006892C24  mov      x0, x19
006892C28  ldp      x20, x19, [sp, #0x10]
006892C2C  ldp      x30, x21, [sp], #0x20
006892C30  br       x2
006892C34  ldr      x8, [x2, #0x60]
006892C38  mov      x0, x19
006892C3C  mov      w1, w20
006892C40  blr      x8
006892C44  mov      x0, x19
006892C48  mov      x1, xzr
006892C4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006892C50  adrp     x21, #0x959c000
006892C54  ldrb     w8, [x21, #0x47c]
006892C58  mov      w20, w0
006892C5C  cbnz     w8, #0x6892c74
006892C60  adrp     x0, #0x8f25000
006892C64  ldr      x0, [x0, #0x888]
006892C68  bl       #0x382bd14 ; 
006892C6C  mov      w8, #1
006892C70  strb     w8, [x21, #0x47c]
006892C74  adrp     x8, #0x8f25000
006892C78  ldr      x8, [x8, #0x888]
006892C7C  ldr      x2, [x8]
006892C80  ldrb     w8, [x2, #0x53]
006892C84  tbnz     w8, #5, #0x6892c90
006892C88  str      w20, [x19, #0x24]
006892C8C  b        #0x6892ca0 ; 
006892C90  ldr      x8, [x2, #0x60]
006892C94  mov      x0, x19
006892C98  mov      w1, w20
006892C9C  blr      x8
006892CA0  mov      x0, x19
006892CA4  mov      x1, xzr
006892CA8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006892CAC  adrp     x21, #0x959c000
006892CB0  ldrb     w8, [x21, #0x47d]
006892CB4  mov      w20, w0
006892CB8  cbnz     w8, #0x6892cd0
006892CBC  adrp     x0, #0x8f25000
006892CC0  ldr      x0, [x0, #0x898]
006892CC4  bl       #0x382bd14 ; 
006892CC8  mov      w8, #1
006892CCC  strb     w8, [x21, #0x47d]
006892CD0  adrp     x8, #0x8f25000
006892CD4  ldr      x8, [x8, #0x898]
006892CD8  ldr      x2, [x8]
006892CDC  ldrb     w8, [x2, #0x53]
006892CE0  tbnz     w8, #5, #0x6892cec
006892CE4  str      w20, [x19, #0x28]
006892CE8  b        #0x6892cfc ; 
006892CEC  ldr      x8, [x2, #0x60]
006892CF0  mov      x0, x19
006892CF4  mov      w1, w20
006892CF8  blr      x8
006892CFC  mov      x0, x19
006892D00  mov      x1, xzr
006892D04  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006892D08  adrp     x21, #0x959c000
006892D0C  ldrb     w8, [x21, #0x47e]
006892D10  mov      x20, x0
006892D14  cbnz     w8, #0x6892d2c
006892D18  adrp     x0, #0x8f25000
006892D1C  ldr      x0, [x0, #0x8a8]
006892D20  bl       #0x382bd14 ; 
006892D24  mov      w8, #1
006892D28  strb     w8, [x21, #0x47e]
006892D2C  adrp     x8, #0x8f25000
006892D30  ldr      x8, [x8, #0x8a8]
006892D34  ldr      x2, [x8]
006892D38  ldrb     w8, [x2, #0x53]
006892D3C  tbnz     w8, #5, #0x6892d54
006892D40  mov      x0, x19
006892D44  str      x20, [x0, #0x30]!
006892D48  mov      x1, x20
006892D4C  bl       #0x382bcb8 ; 
006892D50  b        #0x6892d64 ; 
006892D54  ldr      x8, [x2, #0x60]
006892D58  mov      x0, x19
006892D5C  mov      x1, x20
006892D60  blr      x8
006892D64  mov      x0, x19
006892D68  mov      x1, xzr
006892D6C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006892D70  adrp     x21, #0x959c000
006892D74  ldrb     w8, [x21, #0x47f]
006892D78  mov      x20, x0
006892D7C  cbnz     w8, #0x6892d94
006892D80  adrp     x0, #0x8f25000
006892D84  ldr      x0, [x0, #0x8b8]
006892D88  bl       #0x382bd14 ; 
006892D8C  mov      w8, #1
006892D90  strb     w8, [x21, #0x47f]
006892D94  adrp     x8, #0x8f25000
006892D98  ldr      x8, [x8, #0x8b8]
006892D9C  ldr      x2, [x8]
006892DA0  ldrb     w8, [x2, #0x53]
006892DA4  tbnz     w8, #5, #0x6892dbc
006892DA8  mov      x0, x19
006892DAC  str      x20, [x0, #0x38]!
006892DB0  mov      x1, x20
006892DB4  bl       #0x382bcb8 ; 
006892DB8  b        #0x6892dcc ; 
006892DBC  ldr      x8, [x2, #0x60]
006892DC0  mov      x0, x19
006892DC4  mov      x1, x20
006892DC8  blr      x8
006892DCC  mov      x0, x19
006892DD0  mov      x1, xzr
006892DD4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006892DD8  adrp     x21, #0x959c000
006892DDC  ldrb     w8, [x21, #0x480]
006892DE0  mov      x20, x0
006892DE4  cbnz     w8, #0x6892dfc
006892DE8  adrp     x0, #0x8f25000
006892DEC  ldr      x0, [x0, #0x8c8]
006892DF0  bl       #0x382bd14 ; 
006892DF4  mov      w8, #1
006892DF8  strb     w8, [x21, #0x480]
006892DFC  adrp     x8, #0x8f25000
006892E00  ldr      x8, [x8, #0x8c8]
006892E04  ldr      x2, [x8]
006892E08  ldrb     w8, [x2, #0x53]
006892E0C  tbnz     w8, #5, #0x6892e24
006892E10  str      x20, [x19, #0x40]!
006892E14  mov      x0, x19
006892E18  mov      x1, x20
006892E1C  bl       #0x382bcb8 ; 
006892E20  b        #0x6892e34 ; 
006892E24  ldr      x8, [x2, #0x60]
006892E28  mov      x0, x19
006892E2C  mov      x1, x20
006892E30  blr      x8
006892E34  ldp      x20, x19, [sp, #0x10]
006892E38  mov      w0, #1
006892E3C  ldp      x30, x21, [sp], #0x20
006892E40  ret      

