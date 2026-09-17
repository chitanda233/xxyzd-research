; LocalModels.Bean.Guild_guildTask$$readImpl
; RVA 0x6A96998; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A96998  stp      x30, x21, [sp, #-0x20]!
006A9699C  stp      x20, x19, [sp, #0x10]
006A969A0  adrp     x20, #0x959e000
006A969A4  adrp     x21, #0x8f39000
006A969A8  ldrb     w8, [x20, #0x19b]
006A969AC  ldr      x21, [x21, #0x2d0]
006A969B0  mov      x19, x0
006A969B4  tbnz     w8, #0, #0x6a969cc
006A969B8  adrp     x0, #0x8f39000
006A969BC  ldr      x0, [x0, #0x2d0]
006A969C0  bl       #0x382bd14 ; 
006A969C4  mov      w8, #1
006A969C8  strb     w8, [x20, #0x19b]
006A969CC  ldr      x1, [x21]
006A969D0  ldrb     w8, [x1, #0x53]
006A969D4  tbnz     w8, #5, #0x6a96a24
006A969D8  mov      x0, x19
006A969DC  mov      x1, xzr
006A969E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A969E4  adrp     x21, #0x959e000
006A969E8  ldrb     w8, [x21, #0x5e8]
006A969EC  mov      w20, w0
006A969F0  cbnz     w8, #0x6a96a08
006A969F4  adrp     x0, #0x8f39000
006A969F8  ldr      x0, [x0, #0x228]
006A969FC  bl       #0x382bd14 ; 
006A96A00  mov      w8, #1
006A96A04  strb     w8, [x21, #0x5e8]
006A96A08  adrp     x8, #0x8f39000
006A96A0C  ldr      x8, [x8, #0x228]
006A96A10  ldr      x2, [x8]
006A96A14  ldrb     w8, [x2, #0x53]
006A96A18  tbnz     w8, #5, #0x6a96a38
006A96A1C  str      w20, [x19, #0x20]
006A96A20  b        #0x6a96a48 ; 
006A96A24  ldr      x2, [x1, #0x60]
006A96A28  mov      x0, x19
006A96A2C  ldp      x20, x19, [sp, #0x10]
006A96A30  ldp      x30, x21, [sp], #0x20
006A96A34  br       x2
006A96A38  ldr      x8, [x2, #0x60]
006A96A3C  mov      x0, x19
006A96A40  mov      w1, w20
006A96A44  blr      x8
006A96A48  mov      x0, x19
006A96A4C  mov      x1, xzr
006A96A50  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A96A54  adrp     x21, #0x959e000
006A96A58  ldrb     w8, [x21, #0x5e9]
006A96A5C  mov      w20, w0
006A96A60  cbnz     w8, #0x6a96a78
006A96A64  adrp     x0, #0x8f39000
006A96A68  ldr      x0, [x0, #0x238]
006A96A6C  bl       #0x382bd14 ; 
006A96A70  mov      w8, #1
006A96A74  strb     w8, [x21, #0x5e9]
006A96A78  adrp     x8, #0x8f39000
006A96A7C  ldr      x8, [x8, #0x238]
006A96A80  ldr      x2, [x8]
006A96A84  ldrb     w8, [x2, #0x53]
006A96A88  tbnz     w8, #5, #0x6a96a94
006A96A8C  str      w20, [x19, #0x24]
006A96A90  b        #0x6a96aa4 ; 
006A96A94  ldr      x8, [x2, #0x60]
006A96A98  mov      x0, x19
006A96A9C  mov      w1, w20
006A96AA0  blr      x8
006A96AA4  mov      x0, x19
006A96AA8  mov      x1, xzr
006A96AAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A96AB0  adrp     x21, #0x959e000
006A96AB4  ldrb     w8, [x21, #0x5ea]
006A96AB8  mov      w20, w0
006A96ABC  cbnz     w8, #0x6a96ad4
006A96AC0  adrp     x0, #0x8f39000
006A96AC4  ldr      x0, [x0, #0x248]
006A96AC8  bl       #0x382bd14 ; 
006A96ACC  mov      w8, #1
006A96AD0  strb     w8, [x21, #0x5ea]
006A96AD4  adrp     x8, #0x8f39000
006A96AD8  ldr      x8, [x8, #0x248]
006A96ADC  ldr      x2, [x8]
006A96AE0  ldrb     w8, [x2, #0x53]
006A96AE4  tbnz     w8, #5, #0x6a96af0
006A96AE8  str      w20, [x19, #0x28]
006A96AEC  b        #0x6a96b00 ; 
006A96AF0  ldr      x8, [x2, #0x60]
006A96AF4  mov      x0, x19
006A96AF8  mov      w1, w20
006A96AFC  blr      x8
006A96B00  mov      x0, x19
006A96B04  mov      x1, xzr
006A96B08  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A96B0C  adrp     x21, #0x959e000
006A96B10  ldrb     w8, [x21, #0x5eb]
006A96B14  mov      w20, w0
006A96B18  cbnz     w8, #0x6a96b30
006A96B1C  adrp     x0, #0x8f39000
006A96B20  ldr      x0, [x0, #0x258]
006A96B24  bl       #0x382bd14 ; 
006A96B28  mov      w8, #1
006A96B2C  strb     w8, [x21, #0x5eb]
006A96B30  adrp     x8, #0x8f39000
006A96B34  ldr      x8, [x8, #0x258]
006A96B38  ldr      x2, [x8]
006A96B3C  ldrb     w8, [x2, #0x53]
006A96B40  tbnz     w8, #5, #0x6a96b4c
006A96B44  str      w20, [x19, #0x2c]
006A96B48  b        #0x6a96b5c ; 
006A96B4C  ldr      x8, [x2, #0x60]
006A96B50  mov      x0, x19
006A96B54  mov      w1, w20
006A96B58  blr      x8
006A96B5C  mov      x0, x19
006A96B60  mov      x1, xzr
006A96B64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A96B68  adrp     x21, #0x959e000
006A96B6C  ldrb     w8, [x21, #0x5ec]
006A96B70  mov      w20, w0
006A96B74  cbnz     w8, #0x6a96b8c
006A96B78  adrp     x0, #0x8f39000
006A96B7C  ldr      x0, [x0, #0x268]
006A96B80  bl       #0x382bd14 ; 
006A96B84  mov      w8, #1
006A96B88  strb     w8, [x21, #0x5ec]
006A96B8C  adrp     x8, #0x8f39000
006A96B90  ldr      x8, [x8, #0x268]
006A96B94  ldr      x2, [x8]
006A96B98  ldrb     w8, [x2, #0x53]
006A96B9C  tbnz     w8, #5, #0x6a96ba8
006A96BA0  str      w20, [x19, #0x30]
006A96BA4  b        #0x6a96bb8 ; 
006A96BA8  ldr      x8, [x2, #0x60]
006A96BAC  mov      x0, x19
006A96BB0  mov      w1, w20
006A96BB4  blr      x8
006A96BB8  mov      x0, x19
006A96BBC  mov      x1, xzr
006A96BC0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A96BC4  adrp     x21, #0x959e000
006A96BC8  ldrb     w8, [x21, #0x5ed]
006A96BCC  mov      w20, w0
006A96BD0  cbnz     w8, #0x6a96be8
006A96BD4  adrp     x0, #0x8f39000
006A96BD8  ldr      x0, [x0, #0x278]
006A96BDC  bl       #0x382bd14 ; 
006A96BE0  mov      w8, #1
006A96BE4  strb     w8, [x21, #0x5ed]
006A96BE8  adrp     x8, #0x8f39000
006A96BEC  ldr      x8, [x8, #0x278]
006A96BF0  ldr      x2, [x8]
006A96BF4  ldrb     w8, [x2, #0x53]
006A96BF8  tbnz     w8, #5, #0x6a96c04
006A96BFC  str      w20, [x19, #0x34]
006A96C00  b        #0x6a96c14 ; 
006A96C04  ldr      x8, [x2, #0x60]
006A96C08  mov      x0, x19
006A96C0C  mov      w1, w20
006A96C10  blr      x8
006A96C14  mov      x0, x19
006A96C18  mov      x1, xzr
006A96C1C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A96C20  adrp     x21, #0x959e000
006A96C24  ldrb     w8, [x21, #0x5ee]
006A96C28  mov      w20, w0
006A96C2C  cbnz     w8, #0x6a96c44
006A96C30  adrp     x0, #0x8f39000
006A96C34  ldr      x0, [x0, #0x288]
006A96C38  bl       #0x382bd14 ; 
006A96C3C  mov      w8, #1
006A96C40  strb     w8, [x21, #0x5ee]
006A96C44  adrp     x8, #0x8f39000
006A96C48  ldr      x8, [x8, #0x288]
006A96C4C  ldr      x2, [x8]
006A96C50  ldrb     w8, [x2, #0x53]
006A96C54  tbnz     w8, #5, #0x6a96c60
006A96C58  str      w20, [x19, #0x38]
006A96C5C  b        #0x6a96c70 ; 
006A96C60  ldr      x8, [x2, #0x60]
006A96C64  mov      x0, x19
006A96C68  mov      w1, w20
006A96C6C  blr      x8
006A96C70  mov      x0, x19
006A96C74  mov      x1, xzr
006A96C78  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A96C7C  adrp     x21, #0x959e000
006A96C80  ldrb     w8, [x21, #0x5ef]
006A96C84  mov      x20, x0
006A96C88  cbnz     w8, #0x6a96ca0
006A96C8C  adrp     x0, #0x8f39000
006A96C90  ldr      x0, [x0, #0x298]
006A96C94  bl       #0x382bd14 ; 
006A96C98  mov      w8, #1
006A96C9C  strb     w8, [x21, #0x5ef]
006A96CA0  adrp     x8, #0x8f39000
006A96CA4  ldr      x8, [x8, #0x298]
006A96CA8  ldr      x2, [x8]
006A96CAC  ldrb     w8, [x2, #0x53]
006A96CB0  tbnz     w8, #5, #0x6a96cc8
006A96CB4  mov      x0, x19
006A96CB8  str      x20, [x0, #0x40]!
006A96CBC  mov      x1, x20
006A96CC0  bl       #0x382bcb8 ; 
006A96CC4  b        #0x6a96cd8 ; 
006A96CC8  ldr      x8, [x2, #0x60]
006A96CCC  mov      x0, x19
006A96CD0  mov      x1, x20
006A96CD4  blr      x8
006A96CD8  mov      x0, x19
006A96CDC  mov      x1, xzr
006A96CE0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A96CE4  adrp     x21, #0x959e000
006A96CE8  ldrb     w8, [x21, #0x5f0]
006A96CEC  mov      x20, x0
006A96CF0  cbnz     w8, #0x6a96d08
006A96CF4  adrp     x0, #0x8f39000
006A96CF8  ldr      x0, [x0, #0x2a8]
006A96CFC  bl       #0x382bd14 ; 
006A96D00  mov      w8, #1
006A96D04  strb     w8, [x21, #0x5f0]
006A96D08  adrp     x8, #0x8f39000
006A96D0C  ldr      x8, [x8, #0x2a8]
006A96D10  ldr      x2, [x8]
006A96D14  ldrb     w8, [x2, #0x53]
006A96D18  tbnz     w8, #5, #0x6a96d30
006A96D1C  mov      x0, x19
006A96D20  str      x20, [x0, #0x48]!
006A96D24  mov      x1, x20
006A96D28  bl       #0x382bcb8 ; 
006A96D2C  b        #0x6a96d40 ; 
006A96D30  ldr      x8, [x2, #0x60]
006A96D34  mov      x0, x19
006A96D38  mov      x1, x20
006A96D3C  blr      x8
006A96D40  mov      x0, x19
006A96D44  mov      x1, xzr
006A96D48  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A96D4C  adrp     x21, #0x959e000
006A96D50  ldrb     w8, [x21, #0x5f1]
006A96D54  mov      x20, x0
006A96D58  cbnz     w8, #0x6a96d70
006A96D5C  adrp     x0, #0x8f39000
006A96D60  ldr      x0, [x0, #0x2b8]
006A96D64  bl       #0x382bd14 ; 
006A96D68  mov      w8, #1
006A96D6C  strb     w8, [x21, #0x5f1]
006A96D70  adrp     x8, #0x8f39000
006A96D74  ldr      x8, [x8, #0x2b8]
006A96D78  ldr      x2, [x8]
006A96D7C  ldrb     w8, [x2, #0x53]
006A96D80  tbnz     w8, #5, #0x6a96d98
006A96D84  mov      x0, x19
006A96D88  str      x20, [x0, #0x50]!
006A96D8C  mov      x1, x20
006A96D90  bl       #0x382bcb8 ; 
006A96D94  b        #0x6a96da8 ; 
006A96D98  ldr      x8, [x2, #0x60]
006A96D9C  mov      x0, x19
006A96DA0  mov      x1, x20
006A96DA4  blr      x8
006A96DA8  mov      x0, x19
006A96DAC  mov      x1, xzr
006A96DB0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A96DB4  adrp     x21, #0x959e000
006A96DB8  ldrb     w8, [x21, #0x5f2]
006A96DBC  mov      x20, x0
006A96DC0  cbnz     w8, #0x6a96dd8
006A96DC4  adrp     x0, #0x8f39000
006A96DC8  ldr      x0, [x0, #0x2c8]
006A96DCC  bl       #0x382bd14 ; 
006A96DD0  mov      w8, #1
006A96DD4  strb     w8, [x21, #0x5f2]
006A96DD8  adrp     x8, #0x8f39000
006A96DDC  ldr      x8, [x8, #0x2c8]
006A96DE0  ldr      x2, [x8]
006A96DE4  ldrb     w8, [x2, #0x53]
006A96DE8  tbnz     w8, #5, #0x6a96e00
006A96DEC  str      x20, [x19, #0x58]!
006A96DF0  mov      x0, x19
006A96DF4  mov      x1, x20
006A96DF8  bl       #0x382bcb8 ; 
006A96DFC  b        #0x6a96e10 ; 
006A96E00  ldr      x8, [x2, #0x60]
006A96E04  mov      x0, x19
006A96E08  mov      x1, x20
006A96E0C  blr      x8
006A96E10  ldp      x20, x19, [sp, #0x10]
006A96E14  mov      w0, #1
006A96E18  ldp      x30, x21, [sp], #0x20
006A96E1C  ret      

