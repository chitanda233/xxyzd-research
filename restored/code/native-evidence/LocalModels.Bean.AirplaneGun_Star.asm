; LocalModels.Bean.AirplaneGun_Star$$readImpl
; RVA 0x6700A38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006700A38  stp      x30, x21, [sp, #-0x20]!
006700A3C  stp      x20, x19, [sp, #0x10]
006700A40  adrp     x20, #0x959a000
006700A44  adrp     x21, #0x8f17000
006700A48  ldrb     w8, [x20, #0x892]
006700A4C  ldr      x21, [x21, #0x6c0]
006700A50  mov      x19, x0
006700A54  tbnz     w8, #0, #0x6700a6c
006700A58  adrp     x0, #0x8f17000
006700A5C  ldr      x0, [x0, #0x6c0]
006700A60  bl       #0x382bd14 ; 
006700A64  mov      w8, #1
006700A68  strb     w8, [x20, #0x892]
006700A6C  ldr      x1, [x21]
006700A70  ldrb     w8, [x1, #0x53]
006700A74  tbnz     w8, #5, #0x6700ac4
006700A78  mov      x0, x19
006700A7C  mov      x1, xzr
006700A80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006700A84  adrp     x21, #0x959a000
006700A88  ldrb     w8, [x21, #0x952]
006700A8C  mov      w20, w0
006700A90  cbnz     w8, #0x6700aa8
006700A94  adrp     x0, #0x8f17000
006700A98  ldr      x0, [x0, #0x638]
006700A9C  bl       #0x382bd14 ; 
006700AA0  mov      w8, #1
006700AA4  strb     w8, [x21, #0x952]
006700AA8  adrp     x8, #0x8f17000
006700AAC  ldr      x8, [x8, #0x638]
006700AB0  ldr      x2, [x8]
006700AB4  ldrb     w8, [x2, #0x53]
006700AB8  tbnz     w8, #5, #0x6700ad8
006700ABC  str      w20, [x19, #0x20]
006700AC0  b        #0x6700ae8 ; 
006700AC4  ldr      x2, [x1, #0x60]
006700AC8  mov      x0, x19
006700ACC  ldp      x20, x19, [sp, #0x10]
006700AD0  ldp      x30, x21, [sp], #0x20
006700AD4  br       x2
006700AD8  ldr      x8, [x2, #0x60]
006700ADC  mov      x0, x19
006700AE0  mov      w1, w20
006700AE4  blr      x8
006700AE8  mov      x0, x19
006700AEC  mov      x1, xzr
006700AF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006700AF4  adrp     x21, #0x959a000
006700AF8  ldrb     w8, [x21, #0x953]
006700AFC  mov      w20, w0
006700B00  cbnz     w8, #0x6700b18
006700B04  adrp     x0, #0x8f17000
006700B08  ldr      x0, [x0, #0x648]
006700B0C  bl       #0x382bd14 ; 
006700B10  mov      w8, #1
006700B14  strb     w8, [x21, #0x953]
006700B18  adrp     x8, #0x8f17000
006700B1C  ldr      x8, [x8, #0x648]
006700B20  ldr      x2, [x8]
006700B24  ldrb     w8, [x2, #0x53]
006700B28  tbnz     w8, #5, #0x6700b34
006700B2C  str      w20, [x19, #0x24]
006700B30  b        #0x6700b44 ; 
006700B34  ldr      x8, [x2, #0x60]
006700B38  mov      x0, x19
006700B3C  mov      w1, w20
006700B40  blr      x8
006700B44  mov      x0, x19
006700B48  mov      x1, xzr
006700B4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006700B50  adrp     x21, #0x959a000
006700B54  ldrb     w8, [x21, #0x954]
006700B58  mov      w20, w0
006700B5C  cbnz     w8, #0x6700b74
006700B60  adrp     x0, #0x8f17000
006700B64  ldr      x0, [x0, #0x658]
006700B68  bl       #0x382bd14 ; 
006700B6C  mov      w8, #1
006700B70  strb     w8, [x21, #0x954]
006700B74  adrp     x8, #0x8f17000
006700B78  ldr      x8, [x8, #0x658]
006700B7C  ldr      x2, [x8]
006700B80  ldrb     w8, [x2, #0x53]
006700B84  tbnz     w8, #5, #0x6700b90
006700B88  str      w20, [x19, #0x28]
006700B8C  b        #0x6700ba0 ; 
006700B90  ldr      x8, [x2, #0x60]
006700B94  mov      x0, x19
006700B98  mov      w1, w20
006700B9C  blr      x8
006700BA0  mov      x0, x19
006700BA4  mov      x1, xzr
006700BA8  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006700BAC  adrp     x21, #0x959a000
006700BB0  ldrb     w8, [x21, #0x955]
006700BB4  mov      x20, x0
006700BB8  cbnz     w8, #0x6700bd0
006700BBC  adrp     x0, #0x8f17000
006700BC0  ldr      x0, [x0, #0x668]
006700BC4  bl       #0x382bd14 ; 
006700BC8  mov      w8, #1
006700BCC  strb     w8, [x21, #0x955]
006700BD0  adrp     x8, #0x8f17000
006700BD4  ldr      x8, [x8, #0x668]
006700BD8  ldr      x2, [x8]
006700BDC  ldrb     w8, [x2, #0x53]
006700BE0  tbnz     w8, #5, #0x6700bf8
006700BE4  mov      x0, x19
006700BE8  str      x20, [x0, #0x30]!
006700BEC  mov      x1, x20
006700BF0  bl       #0x382bcb8 ; 
006700BF4  b        #0x6700c08 ; 
006700BF8  ldr      x8, [x2, #0x60]
006700BFC  mov      x0, x19
006700C00  mov      x1, x20
006700C04  blr      x8
006700C08  mov      x0, x19
006700C0C  mov      x1, xzr
006700C10  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006700C14  adrp     x21, #0x959a000
006700C18  ldrb     w8, [x21, #0x956]
006700C1C  mov      x20, x0
006700C20  cbnz     w8, #0x6700c38
006700C24  adrp     x0, #0x8f17000
006700C28  ldr      x0, [x0, #0x678]
006700C2C  bl       #0x382bd14 ; 
006700C30  mov      w8, #1
006700C34  strb     w8, [x21, #0x956]
006700C38  adrp     x8, #0x8f17000
006700C3C  ldr      x8, [x8, #0x678]
006700C40  ldr      x2, [x8]
006700C44  ldrb     w8, [x2, #0x53]
006700C48  tbnz     w8, #5, #0x6700c60
006700C4C  mov      x0, x19
006700C50  str      x20, [x0, #0x38]!
006700C54  mov      x1, x20
006700C58  bl       #0x382bcb8 ; 
006700C5C  b        #0x6700c70 ; 
006700C60  ldr      x8, [x2, #0x60]
006700C64  mov      x0, x19
006700C68  mov      x1, x20
006700C6C  blr      x8
006700C70  mov      x0, x19
006700C74  mov      x1, xzr
006700C78  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006700C7C  adrp     x21, #0x959a000
006700C80  ldrb     w8, [x21, #0x957]
006700C84  mov      x20, x0
006700C88  cbnz     w8, #0x6700ca0
006700C8C  adrp     x0, #0x8f17000
006700C90  ldr      x0, [x0, #0x688]
006700C94  bl       #0x382bd14 ; 
006700C98  mov      w8, #1
006700C9C  strb     w8, [x21, #0x957]
006700CA0  adrp     x8, #0x8f17000
006700CA4  ldr      x8, [x8, #0x688]
006700CA8  ldr      x2, [x8]
006700CAC  ldrb     w8, [x2, #0x53]
006700CB0  tbnz     w8, #5, #0x6700cc8
006700CB4  mov      x0, x19
006700CB8  str      x20, [x0, #0x40]!
006700CBC  mov      x1, x20
006700CC0  bl       #0x382bcb8 ; 
006700CC4  b        #0x6700cd8 ; 
006700CC8  ldr      x8, [x2, #0x60]
006700CCC  mov      x0, x19
006700CD0  mov      x1, x20
006700CD4  blr      x8
006700CD8  mov      x0, x19
006700CDC  mov      x1, xzr
006700CE0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006700CE4  adrp     x21, #0x959a000
006700CE8  ldrb     w8, [x21, #0x958]
006700CEC  mov      x20, x0
006700CF0  cbnz     w8, #0x6700d08
006700CF4  adrp     x0, #0x8f17000
006700CF8  ldr      x0, [x0, #0x698]
006700CFC  bl       #0x382bd14 ; 
006700D00  mov      w8, #1
006700D04  strb     w8, [x21, #0x958]
006700D08  adrp     x8, #0x8f17000
006700D0C  ldr      x8, [x8, #0x698]
006700D10  ldr      x2, [x8]
006700D14  ldrb     w8, [x2, #0x53]
006700D18  tbnz     w8, #5, #0x6700d30
006700D1C  mov      x0, x19
006700D20  str      x20, [x0, #0x48]!
006700D24  mov      x1, x20
006700D28  bl       #0x382bcb8 ; 
006700D2C  b        #0x6700d40 ; 
006700D30  ldr      x8, [x2, #0x60]
006700D34  mov      x0, x19
006700D38  mov      x1, x20
006700D3C  blr      x8
006700D40  mov      x0, x19
006700D44  mov      x1, xzr
006700D48  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006700D4C  adrp     x21, #0x959a000
006700D50  ldrb     w8, [x21, #0x959]
006700D54  mov      x20, x0
006700D58  cbnz     w8, #0x6700d70
006700D5C  adrp     x0, #0x8f17000
006700D60  ldr      x0, [x0, #0x6a8]
006700D64  bl       #0x382bd14 ; 
006700D68  mov      w8, #1
006700D6C  strb     w8, [x21, #0x959]
006700D70  adrp     x8, #0x8f17000
006700D74  ldr      x8, [x8, #0x6a8]
006700D78  ldr      x2, [x8]
006700D7C  ldrb     w8, [x2, #0x53]
006700D80  tbnz     w8, #5, #0x6700d98
006700D84  mov      x0, x19
006700D88  str      x20, [x0, #0x50]!
006700D8C  mov      x1, x20
006700D90  bl       #0x382bcb8 ; 
006700D94  b        #0x6700da8 ; 
006700D98  ldr      x8, [x2, #0x60]
006700D9C  mov      x0, x19
006700DA0  mov      x1, x20
006700DA4  blr      x8
006700DA8  mov      x0, x19
006700DAC  mov      x1, xzr
006700DB0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006700DB4  adrp     x21, #0x959a000
006700DB8  ldrb     w8, [x21, #0x95a]
006700DBC  mov      x20, x0
006700DC0  cbnz     w8, #0x6700dd8
006700DC4  adrp     x0, #0x8f17000
006700DC8  ldr      x0, [x0, #0x6b8]
006700DCC  bl       #0x382bd14 ; 
006700DD0  mov      w8, #1
006700DD4  strb     w8, [x21, #0x95a]
006700DD8  adrp     x8, #0x8f17000
006700DDC  ldr      x8, [x8, #0x6b8]
006700DE0  ldr      x2, [x8]
006700DE4  ldrb     w8, [x2, #0x53]
006700DE8  tbnz     w8, #5, #0x6700e00
006700DEC  str      x20, [x19, #0x58]!
006700DF0  mov      x0, x19
006700DF4  mov      x1, x20
006700DF8  bl       #0x382bcb8 ; 
006700DFC  b        #0x6700e10 ; 
006700E00  ldr      x8, [x2, #0x60]
006700E04  mov      x0, x19
006700E08  mov      x1, x20
006700E0C  blr      x8
006700E10  ldp      x20, x19, [sp, #0x10]
006700E14  mov      w0, #1
006700E18  ldp      x30, x21, [sp], #0x20
006700E1C  ret      

