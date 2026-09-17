; LocalModels.Bean.GuildBOSS_guildBossAffixPool$$readImpl
; RVA 0x6A849BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A849BC  stp      x30, x21, [sp, #-0x20]!
006A849C0  stp      x20, x19, [sp, #0x10]
006A849C4  adrp     x20, #0x959d000
006A849C8  adrp     x21, #0x8f38000
006A849CC  ldrb     w8, [x20, #0xfb5]
006A849D0  ldr      x21, [x21, #0x560]
006A849D4  mov      x19, x0
006A849D8  tbnz     w8, #0, #0x6a849f0
006A849DC  adrp     x0, #0x8f38000
006A849E0  ldr      x0, [x0, #0x560]
006A849E4  bl       #0x382bd14 ; 
006A849E8  mov      w8, #1
006A849EC  strb     w8, [x20, #0xfb5]
006A849F0  ldr      x1, [x21]
006A849F4  ldrb     w8, [x1, #0x53]
006A849F8  tbnz     w8, #5, #0x6a84a48
006A849FC  mov      x0, x19
006A84A00  mov      x1, xzr
006A84A04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A84A08  adrp     x21, #0x959e000
006A84A0C  ldrb     w8, [x21, #0x52d]
006A84A10  mov      w20, w0
006A84A14  cbnz     w8, #0x6a84a2c
006A84A18  adrp     x0, #0x8f38000
006A84A1C  ldr      x0, [x0, #0x508]
006A84A20  bl       #0x382bd14 ; 
006A84A24  mov      w8, #1
006A84A28  strb     w8, [x21, #0x52d]
006A84A2C  adrp     x8, #0x8f38000
006A84A30  ldr      x8, [x8, #0x508]
006A84A34  ldr      x2, [x8]
006A84A38  ldrb     w8, [x2, #0x53]
006A84A3C  tbnz     w8, #5, #0x6a84a5c
006A84A40  str      w20, [x19, #0x20]
006A84A44  b        #0x6a84a6c ; 
006A84A48  ldr      x2, [x1, #0x60]
006A84A4C  mov      x0, x19
006A84A50  ldp      x20, x19, [sp, #0x10]
006A84A54  ldp      x30, x21, [sp], #0x20
006A84A58  br       x2
006A84A5C  ldr      x8, [x2, #0x60]
006A84A60  mov      x0, x19
006A84A64  mov      w1, w20
006A84A68  blr      x8
006A84A6C  mov      x0, x19
006A84A70  mov      x1, xzr
006A84A74  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A84A78  adrp     x21, #0x959e000
006A84A7C  ldrb     w8, [x21, #0x52e]
006A84A80  mov      w20, w0
006A84A84  cbnz     w8, #0x6a84a9c
006A84A88  adrp     x0, #0x8f38000
006A84A8C  ldr      x0, [x0, #0x518]
006A84A90  bl       #0x382bd14 ; 
006A84A94  mov      w8, #1
006A84A98  strb     w8, [x21, #0x52e]
006A84A9C  adrp     x8, #0x8f38000
006A84AA0  ldr      x8, [x8, #0x518]
006A84AA4  ldr      x2, [x8]
006A84AA8  ldrb     w8, [x2, #0x53]
006A84AAC  tbnz     w8, #5, #0x6a84ab8
006A84AB0  str      w20, [x19, #0x24]
006A84AB4  b        #0x6a84ac8 ; 
006A84AB8  ldr      x8, [x2, #0x60]
006A84ABC  mov      x0, x19
006A84AC0  mov      w1, w20
006A84AC4  blr      x8
006A84AC8  mov      x0, x19
006A84ACC  mov      x1, xzr
006A84AD0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A84AD4  adrp     x21, #0x959e000
006A84AD8  ldrb     w8, [x21, #0x52f]
006A84ADC  mov      w20, w0
006A84AE0  cbnz     w8, #0x6a84af8
006A84AE4  adrp     x0, #0x8f38000
006A84AE8  ldr      x0, [x0, #0x528]
006A84AEC  bl       #0x382bd14 ; 
006A84AF0  mov      w8, #1
006A84AF4  strb     w8, [x21, #0x52f]
006A84AF8  adrp     x8, #0x8f38000
006A84AFC  ldr      x8, [x8, #0x528]
006A84B00  ldr      x2, [x8]
006A84B04  ldrb     w8, [x2, #0x53]
006A84B08  tbnz     w8, #5, #0x6a84b14
006A84B0C  str      w20, [x19, #0x28]
006A84B10  b        #0x6a84b24 ; 
006A84B14  ldr      x8, [x2, #0x60]
006A84B18  mov      x0, x19
006A84B1C  mov      w1, w20
006A84B20  blr      x8
006A84B24  mov      x0, x19
006A84B28  mov      x1, xzr
006A84B2C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A84B30  adrp     x21, #0x959e000
006A84B34  ldrb     w8, [x21, #0x530]
006A84B38  mov      w20, w0
006A84B3C  cbnz     w8, #0x6a84b54
006A84B40  adrp     x0, #0x8f38000
006A84B44  ldr      x0, [x0, #0x538]
006A84B48  bl       #0x382bd14 ; 
006A84B4C  mov      w8, #1
006A84B50  strb     w8, [x21, #0x530]
006A84B54  adrp     x8, #0x8f38000
006A84B58  ldr      x8, [x8, #0x538]
006A84B5C  ldr      x2, [x8]
006A84B60  ldrb     w8, [x2, #0x53]
006A84B64  tbnz     w8, #5, #0x6a84b70
006A84B68  str      w20, [x19, #0x2c]
006A84B6C  b        #0x6a84b80 ; 
006A84B70  ldr      x8, [x2, #0x60]
006A84B74  mov      x0, x19
006A84B78  mov      w1, w20
006A84B7C  blr      x8
006A84B80  mov      x0, x19
006A84B84  mov      x1, xzr
006A84B88  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A84B8C  adrp     x21, #0x959e000
006A84B90  ldrb     w8, [x21, #0x531]
006A84B94  mov      x20, x0
006A84B98  cbnz     w8, #0x6a84bb0
006A84B9C  adrp     x0, #0x8f38000
006A84BA0  ldr      x0, [x0, #0x548]
006A84BA4  bl       #0x382bd14 ; 
006A84BA8  mov      w8, #1
006A84BAC  strb     w8, [x21, #0x531]
006A84BB0  adrp     x8, #0x8f38000
006A84BB4  ldr      x8, [x8, #0x548]
006A84BB8  ldr      x2, [x8]
006A84BBC  ldrb     w8, [x2, #0x53]
006A84BC0  tbnz     w8, #5, #0x6a84bd8
006A84BC4  mov      x0, x19
006A84BC8  str      x20, [x0, #0x30]!
006A84BCC  mov      x1, x20
006A84BD0  bl       #0x382bcb8 ; 
006A84BD4  b        #0x6a84be8 ; 
006A84BD8  ldr      x8, [x2, #0x60]
006A84BDC  mov      x0, x19
006A84BE0  mov      x1, x20
006A84BE4  blr      x8
006A84BE8  mov      x0, x19
006A84BEC  mov      x1, xzr
006A84BF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A84BF4  adrp     x21, #0x959e000
006A84BF8  ldrb     w8, [x21, #0x532]
006A84BFC  mov      w20, w0
006A84C00  cbnz     w8, #0x6a84c18
006A84C04  adrp     x0, #0x8f38000
006A84C08  ldr      x0, [x0, #0x558]
006A84C0C  bl       #0x382bd14 ; 
006A84C10  mov      w8, #1
006A84C14  strb     w8, [x21, #0x532]
006A84C18  adrp     x8, #0x8f38000
006A84C1C  ldr      x8, [x8, #0x558]
006A84C20  ldr      x2, [x8]
006A84C24  ldrb     w8, [x2, #0x53]
006A84C28  tbnz     w8, #5, #0x6a84c34
006A84C2C  str      w20, [x19, #0x38]
006A84C30  b        #0x6a84c44 ; 
006A84C34  ldr      x8, [x2, #0x60]
006A84C38  mov      x0, x19
006A84C3C  mov      w1, w20
006A84C40  blr      x8
006A84C44  ldp      x20, x19, [sp, #0x10]
006A84C48  mov      w0, #1
006A84C4C  ldp      x30, x21, [sp], #0x20
006A84C50  ret      

