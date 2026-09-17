; LocalModels.Bean.GuildChest_guildChestConfig$$readImpl
; RVA 0x6A89924; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A89924  stp      x30, x21, [sp, #-0x20]!
006A89928  stp      x20, x19, [sp, #0x10]
006A8992C  adrp     x20, #0x959e000
006A89930  adrp     x21, #0x8f38000
006A89934  ldrb     w8, [x20, #0x3b]
006A89938  ldr      x21, [x21, #0x910]
006A8993C  mov      x19, x0
006A89940  tbnz     w8, #0, #0x6a89958
006A89944  adrp     x0, #0x8f38000
006A89948  ldr      x0, [x0, #0x910]
006A8994C  bl       #0x382bd14 ; 
006A89950  mov      w8, #1
006A89954  strb     w8, [x20, #0x3b]
006A89958  ldr      x1, [x21]
006A8995C  ldrb     w8, [x1, #0x53]
006A89960  tbnz     w8, #5, #0x6a899b0
006A89964  mov      x0, x19
006A89968  mov      x1, xzr
006A8996C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A89970  adrp     x21, #0x959e000
006A89974  ldrb     w8, [x21, #0x55f]
006A89978  mov      w20, w0
006A8997C  cbnz     w8, #0x6a89994
006A89980  adrp     x0, #0x8f38000
006A89984  ldr      x0, [x0, #0x8c8]
006A89988  bl       #0x382bd14 ; 
006A8998C  mov      w8, #1
006A89990  strb     w8, [x21, #0x55f]
006A89994  adrp     x8, #0x8f38000
006A89998  ldr      x8, [x8, #0x8c8]
006A8999C  ldr      x2, [x8]
006A899A0  ldrb     w8, [x2, #0x53]
006A899A4  tbnz     w8, #5, #0x6a899c4
006A899A8  str      w20, [x19, #0x20]
006A899AC  b        #0x6a899d4 ; 
006A899B0  ldr      x2, [x1, #0x60]
006A899B4  mov      x0, x19
006A899B8  ldp      x20, x19, [sp, #0x10]
006A899BC  ldp      x30, x21, [sp], #0x20
006A899C0  br       x2
006A899C4  ldr      x8, [x2, #0x60]
006A899C8  mov      x0, x19
006A899CC  mov      w1, w20
006A899D0  blr      x8
006A899D4  mov      x0, x19
006A899D8  mov      x1, xzr
006A899DC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A899E0  adrp     x21, #0x959e000
006A899E4  ldrb     w8, [x21, #0x560]
006A899E8  mov      x20, x0
006A899EC  cbnz     w8, #0x6a89a04
006A899F0  adrp     x0, #0x8f38000
006A899F4  ldr      x0, [x0, #0x8d8]
006A899F8  bl       #0x382bd14 ; 
006A899FC  mov      w8, #1
006A89A00  strb     w8, [x21, #0x560]
006A89A04  adrp     x8, #0x8f38000
006A89A08  ldr      x8, [x8, #0x8d8]
006A89A0C  ldr      x2, [x8]
006A89A10  ldrb     w8, [x2, #0x53]
006A89A14  tbnz     w8, #5, #0x6a89a2c
006A89A18  mov      x0, x19
006A89A1C  str      x20, [x0, #0x28]!
006A89A20  mov      x1, x20
006A89A24  bl       #0x382bcb8 ; 
006A89A28  b        #0x6a89a3c ; 
006A89A2C  ldr      x8, [x2, #0x60]
006A89A30  mov      x0, x19
006A89A34  mov      x1, x20
006A89A38  blr      x8
006A89A3C  mov      x0, x19
006A89A40  mov      x1, xzr
006A89A44  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A89A48  adrp     x21, #0x959e000
006A89A4C  ldrb     w8, [x21, #0x561]
006A89A50  mov      w20, w0
006A89A54  cbnz     w8, #0x6a89a6c
006A89A58  adrp     x0, #0x8f38000
006A89A5C  ldr      x0, [x0, #0x8e8]
006A89A60  bl       #0x382bd14 ; 
006A89A64  mov      w8, #1
006A89A68  strb     w8, [x21, #0x561]
006A89A6C  adrp     x8, #0x8f38000
006A89A70  ldr      x8, [x8, #0x8e8]
006A89A74  ldr      x2, [x8]
006A89A78  ldrb     w8, [x2, #0x53]
006A89A7C  tbnz     w8, #5, #0x6a89a88
006A89A80  str      w20, [x19, #0x30]
006A89A84  b        #0x6a89a98 ; 
006A89A88  ldr      x8, [x2, #0x60]
006A89A8C  mov      x0, x19
006A89A90  mov      w1, w20
006A89A94  blr      x8
006A89A98  mov      x0, x19
006A89A9C  mov      x1, xzr
006A89AA0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A89AA4  adrp     x21, #0x959e000
006A89AA8  ldrb     w8, [x21, #0x562]
006A89AAC  mov      x20, x0
006A89AB0  cbnz     w8, #0x6a89ac8
006A89AB4  adrp     x0, #0x8f38000
006A89AB8  ldr      x0, [x0, #0x8f8]
006A89ABC  bl       #0x382bd14 ; 
006A89AC0  mov      w8, #1
006A89AC4  strb     w8, [x21, #0x562]
006A89AC8  adrp     x8, #0x8f38000
006A89ACC  ldr      x8, [x8, #0x8f8]
006A89AD0  ldr      x2, [x8]
006A89AD4  ldrb     w8, [x2, #0x53]
006A89AD8  tbnz     w8, #5, #0x6a89af0
006A89ADC  mov      x0, x19
006A89AE0  str      x20, [x0, #0x38]!
006A89AE4  mov      x1, x20
006A89AE8  bl       #0x382bcb8 ; 
006A89AEC  b        #0x6a89b00 ; 
006A89AF0  ldr      x8, [x2, #0x60]
006A89AF4  mov      x0, x19
006A89AF8  mov      x1, x20
006A89AFC  blr      x8
006A89B00  mov      x0, x19
006A89B04  mov      x1, xzr
006A89B08  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A89B0C  adrp     x21, #0x959e000
006A89B10  ldrb     w8, [x21, #0x563]
006A89B14  mov      x20, x0
006A89B18  cbnz     w8, #0x6a89b30
006A89B1C  adrp     x0, #0x8f38000
006A89B20  ldr      x0, [x0, #0x908]
006A89B24  bl       #0x382bd14 ; 
006A89B28  mov      w8, #1
006A89B2C  strb     w8, [x21, #0x563]
006A89B30  adrp     x8, #0x8f38000
006A89B34  ldr      x8, [x8, #0x908]
006A89B38  ldr      x2, [x8]
006A89B3C  ldrb     w8, [x2, #0x53]
006A89B40  tbnz     w8, #5, #0x6a89b58
006A89B44  str      x20, [x19, #0x40]!
006A89B48  mov      x0, x19
006A89B4C  mov      x1, x20
006A89B50  bl       #0x382bcb8 ; 
006A89B54  b        #0x6a89b68 ; 
006A89B58  ldr      x8, [x2, #0x60]
006A89B5C  mov      x0, x19
006A89B60  mov      x1, x20
006A89B64  blr      x8
006A89B68  ldp      x20, x19, [sp, #0x10]
006A89B6C  mov      w0, #1
006A89B70  ldp      x30, x21, [sp], #0x20
006A89B74  ret      

