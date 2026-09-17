; LocalModels.Bean.Guild_guildGift$$readImpl
; RVA 0x6A91A58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A91A58  stp      x30, x21, [sp, #-0x20]!
006A91A5C  stp      x20, x19, [sp, #0x10]
006A91A60  adrp     x20, #0x959e000
006A91A64  adrp     x21, #0x8f38000
006A91A68  ldrb     w8, [x20, #0x115]
006A91A6C  ldr      x21, [x21, #0xee0]
006A91A70  mov      x19, x0
006A91A74  tbnz     w8, #0, #0x6a91a8c
006A91A78  adrp     x0, #0x8f38000
006A91A7C  ldr      x0, [x0, #0xee0]
006A91A80  bl       #0x382bd14 ; 
006A91A84  mov      w8, #1
006A91A88  strb     w8, [x20, #0x115]
006A91A8C  ldr      x1, [x21]
006A91A90  ldrb     w8, [x1, #0x53]
006A91A94  tbnz     w8, #5, #0x6a91ae4
006A91A98  mov      x0, x19
006A91A9C  mov      x1, xzr
006A91AA0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A91AA4  adrp     x21, #0x959e000
006A91AA8  ldrb     w8, [x21, #0x5b4]
006A91AAC  mov      w20, w0
006A91AB0  cbnz     w8, #0x6a91ac8
006A91AB4  adrp     x0, #0x8f38000
006A91AB8  ldr      x0, [x0, #0xe68]
006A91ABC  bl       #0x382bd14 ; 
006A91AC0  mov      w8, #1
006A91AC4  strb     w8, [x21, #0x5b4]
006A91AC8  adrp     x8, #0x8f38000
006A91ACC  ldr      x8, [x8, #0xe68]
006A91AD0  ldr      x2, [x8]
006A91AD4  ldrb     w8, [x2, #0x53]
006A91AD8  tbnz     w8, #5, #0x6a91af8
006A91ADC  str      w20, [x19, #0x20]
006A91AE0  b        #0x6a91b08 ; 
006A91AE4  ldr      x2, [x1, #0x60]
006A91AE8  mov      x0, x19
006A91AEC  ldp      x20, x19, [sp, #0x10]
006A91AF0  ldp      x30, x21, [sp], #0x20
006A91AF4  br       x2
006A91AF8  ldr      x8, [x2, #0x60]
006A91AFC  mov      x0, x19
006A91B00  mov      w1, w20
006A91B04  blr      x8
006A91B08  mov      x0, x19
006A91B0C  mov      x1, xzr
006A91B10  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A91B14  adrp     x21, #0x959e000
006A91B18  ldrb     w8, [x21, #0x5b5]
006A91B1C  mov      w20, w0
006A91B20  cbnz     w8, #0x6a91b38
006A91B24  adrp     x0, #0x8f38000
006A91B28  ldr      x0, [x0, #0xe78]
006A91B2C  bl       #0x382bd14 ; 
006A91B30  mov      w8, #1
006A91B34  strb     w8, [x21, #0x5b5]
006A91B38  adrp     x8, #0x8f38000
006A91B3C  ldr      x8, [x8, #0xe78]
006A91B40  ldr      x2, [x8]
006A91B44  ldrb     w8, [x2, #0x53]
006A91B48  tbnz     w8, #5, #0x6a91b54
006A91B4C  str      w20, [x19, #0x24]
006A91B50  b        #0x6a91b64 ; 
006A91B54  ldr      x8, [x2, #0x60]
006A91B58  mov      x0, x19
006A91B5C  mov      w1, w20
006A91B60  blr      x8
006A91B64  mov      x0, x19
006A91B68  mov      x1, xzr
006A91B6C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A91B70  adrp     x21, #0x959e000
006A91B74  ldrb     w8, [x21, #0x5b6]
006A91B78  mov      x20, x0
006A91B7C  cbnz     w8, #0x6a91b94
006A91B80  adrp     x0, #0x8f38000
006A91B84  ldr      x0, [x0, #0xe88]
006A91B88  bl       #0x382bd14 ; 
006A91B8C  mov      w8, #1
006A91B90  strb     w8, [x21, #0x5b6]
006A91B94  adrp     x8, #0x8f38000
006A91B98  ldr      x8, [x8, #0xe88]
006A91B9C  ldr      x2, [x8]
006A91BA0  ldrb     w8, [x2, #0x53]
006A91BA4  tbnz     w8, #5, #0x6a91bbc
006A91BA8  mov      x0, x19
006A91BAC  str      x20, [x0, #0x28]!
006A91BB0  mov      x1, x20
006A91BB4  bl       #0x382bcb8 ; 
006A91BB8  b        #0x6a91bcc ; 
006A91BBC  ldr      x8, [x2, #0x60]
006A91BC0  mov      x0, x19
006A91BC4  mov      x1, x20
006A91BC8  blr      x8
006A91BCC  mov      x0, x19
006A91BD0  mov      x1, xzr
006A91BD4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A91BD8  adrp     x21, #0x959e000
006A91BDC  ldrb     w8, [x21, #0x5b7]
006A91BE0  mov      x20, x0
006A91BE4  cbnz     w8, #0x6a91bfc
006A91BE8  adrp     x0, #0x8f38000
006A91BEC  ldr      x0, [x0, #0xe98]
006A91BF0  bl       #0x382bd14 ; 
006A91BF4  mov      w8, #1
006A91BF8  strb     w8, [x21, #0x5b7]
006A91BFC  adrp     x8, #0x8f38000
006A91C00  ldr      x8, [x8, #0xe98]
006A91C04  ldr      x2, [x8]
006A91C08  ldrb     w8, [x2, #0x53]
006A91C0C  tbnz     w8, #5, #0x6a91c24
006A91C10  mov      x0, x19
006A91C14  str      x20, [x0, #0x30]!
006A91C18  mov      x1, x20
006A91C1C  bl       #0x382bcb8 ; 
006A91C20  b        #0x6a91c34 ; 
006A91C24  ldr      x8, [x2, #0x60]
006A91C28  mov      x0, x19
006A91C2C  mov      x1, x20
006A91C30  blr      x8
006A91C34  mov      x0, x19
006A91C38  mov      x1, xzr
006A91C3C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A91C40  adrp     x21, #0x959e000
006A91C44  ldrb     w8, [x21, #0x5b8]
006A91C48  mov      w20, w0
006A91C4C  cbnz     w8, #0x6a91c64
006A91C50  adrp     x0, #0x8f38000
006A91C54  ldr      x0, [x0, #0xea8]
006A91C58  bl       #0x382bd14 ; 
006A91C5C  mov      w8, #1
006A91C60  strb     w8, [x21, #0x5b8]
006A91C64  adrp     x8, #0x8f38000
006A91C68  ldr      x8, [x8, #0xea8]
006A91C6C  ldr      x2, [x8]
006A91C70  ldrb     w8, [x2, #0x53]
006A91C74  tbnz     w8, #5, #0x6a91c80
006A91C78  str      w20, [x19, #0x38]
006A91C7C  b        #0x6a91c90 ; 
006A91C80  ldr      x8, [x2, #0x60]
006A91C84  mov      x0, x19
006A91C88  mov      w1, w20
006A91C8C  blr      x8
006A91C90  mov      x0, x19
006A91C94  mov      x1, xzr
006A91C98  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A91C9C  adrp     x21, #0x959e000
006A91CA0  ldrb     w8, [x21, #0x5b9]
006A91CA4  mov      w20, w0
006A91CA8  cbnz     w8, #0x6a91cc0
006A91CAC  adrp     x0, #0x8f38000
006A91CB0  ldr      x0, [x0, #0xeb8]
006A91CB4  bl       #0x382bd14 ; 
006A91CB8  mov      w8, #1
006A91CBC  strb     w8, [x21, #0x5b9]
006A91CC0  adrp     x8, #0x8f38000
006A91CC4  ldr      x8, [x8, #0xeb8]
006A91CC8  ldr      x2, [x8]
006A91CCC  ldrb     w8, [x2, #0x53]
006A91CD0  tbnz     w8, #5, #0x6a91cdc
006A91CD4  str      w20, [x19, #0x3c]
006A91CD8  b        #0x6a91cec ; 
006A91CDC  ldr      x8, [x2, #0x60]
006A91CE0  mov      x0, x19
006A91CE4  mov      w1, w20
006A91CE8  blr      x8
006A91CEC  mov      x0, x19
006A91CF0  mov      x1, xzr
006A91CF4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A91CF8  adrp     x21, #0x959e000
006A91CFC  ldrb     w8, [x21, #0x5ba]
006A91D00  mov      w20, w0
006A91D04  cbnz     w8, #0x6a91d1c
006A91D08  adrp     x0, #0x8f38000
006A91D0C  ldr      x0, [x0, #0xec8]
006A91D10  bl       #0x382bd14 ; 
006A91D14  mov      w8, #1
006A91D18  strb     w8, [x21, #0x5ba]
006A91D1C  adrp     x8, #0x8f38000
006A91D20  ldr      x8, [x8, #0xec8]
006A91D24  ldr      x2, [x8]
006A91D28  ldrb     w8, [x2, #0x53]
006A91D2C  tbnz     w8, #5, #0x6a91d38
006A91D30  str      w20, [x19, #0x40]
006A91D34  b        #0x6a91d48 ; 
006A91D38  ldr      x8, [x2, #0x60]
006A91D3C  mov      x0, x19
006A91D40  mov      w1, w20
006A91D44  blr      x8
006A91D48  mov      x0, x19
006A91D4C  mov      x1, xzr
006A91D50  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A91D54  adrp     x21, #0x959e000
006A91D58  ldrb     w8, [x21, #0x5bb]
006A91D5C  mov      w20, w0
006A91D60  cbnz     w8, #0x6a91d78
006A91D64  adrp     x0, #0x8f38000
006A91D68  ldr      x0, [x0, #0xed8]
006A91D6C  bl       #0x382bd14 ; 
006A91D70  mov      w8, #1
006A91D74  strb     w8, [x21, #0x5bb]
006A91D78  adrp     x8, #0x8f38000
006A91D7C  ldr      x8, [x8, #0xed8]
006A91D80  ldr      x2, [x8]
006A91D84  ldrb     w8, [x2, #0x53]
006A91D88  tbnz     w8, #5, #0x6a91d94
006A91D8C  str      w20, [x19, #0x44]
006A91D90  b        #0x6a91da4 ; 
006A91D94  ldr      x8, [x2, #0x60]
006A91D98  mov      x0, x19
006A91D9C  mov      w1, w20
006A91DA0  blr      x8
006A91DA4  ldp      x20, x19, [sp, #0x10]
006A91DA8  mov      w0, #1
006A91DAC  ldp      x30, x21, [sp], #0x20
006A91DB0  ret      

