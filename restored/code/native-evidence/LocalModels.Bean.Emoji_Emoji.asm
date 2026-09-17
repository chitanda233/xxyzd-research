; LocalModels.Bean.Emoji_Emoji$$readImpl
; RVA 0x6A63B08; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A63B08  stp      x30, x21, [sp, #-0x20]!
006A63B0C  stp      x20, x19, [sp, #0x10]
006A63B10  adrp     x20, #0x959d000
006A63B14  adrp     x21, #0x8f36000
006A63B18  ldrb     w8, [x20, #0xc4d]
006A63B1C  ldr      x21, [x21, #0xc28]
006A63B20  mov      x19, x0
006A63B24  tbnz     w8, #0, #0x6a63b3c
006A63B28  adrp     x0, #0x8f36000
006A63B2C  ldr      x0, [x0, #0xc28]
006A63B30  bl       #0x382bd14 ; 
006A63B34  mov      w8, #1
006A63B38  strb     w8, [x20, #0xc4d]
006A63B3C  ldr      x1, [x21]
006A63B40  ldrb     w8, [x1, #0x53]
006A63B44  tbnz     w8, #5, #0x6a63b94
006A63B48  mov      x0, x19
006A63B4C  mov      x1, xzr
006A63B50  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A63B54  adrp     x21, #0x959e000
006A63B58  ldrb     w8, [x21, #0x3c0]
006A63B5C  mov      w20, w0
006A63B60  cbnz     w8, #0x6a63b78
006A63B64  adrp     x0, #0x8f36000
006A63B68  ldr      x0, [x0, #0xbc0]
006A63B6C  bl       #0x382bd14 ; 
006A63B70  mov      w8, #1
006A63B74  strb     w8, [x21, #0x3c0]
006A63B78  adrp     x8, #0x8f36000
006A63B7C  ldr      x8, [x8, #0xbc0]
006A63B80  ldr      x2, [x8]
006A63B84  ldrb     w8, [x2, #0x53]
006A63B88  tbnz     w8, #5, #0x6a63ba8
006A63B8C  str      w20, [x19, #0x20]
006A63B90  b        #0x6a63bb8 ; 
006A63B94  ldr      x2, [x1, #0x60]
006A63B98  mov      x0, x19
006A63B9C  ldp      x20, x19, [sp, #0x10]
006A63BA0  ldp      x30, x21, [sp], #0x20
006A63BA4  br       x2
006A63BA8  ldr      x8, [x2, #0x60]
006A63BAC  mov      x0, x19
006A63BB0  mov      w1, w20
006A63BB4  blr      x8
006A63BB8  mov      x0, x19
006A63BBC  mov      x1, xzr
006A63BC0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A63BC4  adrp     x21, #0x959e000
006A63BC8  ldrb     w8, [x21, #0x3c1]
006A63BCC  mov      x20, x0
006A63BD0  cbnz     w8, #0x6a63be8
006A63BD4  adrp     x0, #0x8f36000
006A63BD8  ldr      x0, [x0, #0xbd0]
006A63BDC  bl       #0x382bd14 ; 
006A63BE0  mov      w8, #1
006A63BE4  strb     w8, [x21, #0x3c1]
006A63BE8  adrp     x8, #0x8f36000
006A63BEC  ldr      x8, [x8, #0xbd0]
006A63BF0  ldr      x2, [x8]
006A63BF4  ldrb     w8, [x2, #0x53]
006A63BF8  tbnz     w8, #5, #0x6a63c10
006A63BFC  mov      x0, x19
006A63C00  str      x20, [x0, #0x28]!
006A63C04  mov      x1, x20
006A63C08  bl       #0x382bcb8 ; 
006A63C0C  b        #0x6a63c20 ; 
006A63C10  ldr      x8, [x2, #0x60]
006A63C14  mov      x0, x19
006A63C18  mov      x1, x20
006A63C1C  blr      x8
006A63C20  mov      x0, x19
006A63C24  mov      x1, xzr
006A63C28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A63C2C  adrp     x21, #0x959e000
006A63C30  ldrb     w8, [x21, #0x3c2]
006A63C34  mov      w20, w0
006A63C38  cbnz     w8, #0x6a63c50
006A63C3C  adrp     x0, #0x8f36000
006A63C40  ldr      x0, [x0, #0xbe0]
006A63C44  bl       #0x382bd14 ; 
006A63C48  mov      w8, #1
006A63C4C  strb     w8, [x21, #0x3c2]
006A63C50  adrp     x8, #0x8f36000
006A63C54  ldr      x8, [x8, #0xbe0]
006A63C58  ldr      x2, [x8]
006A63C5C  ldrb     w8, [x2, #0x53]
006A63C60  tbnz     w8, #5, #0x6a63c6c
006A63C64  str      w20, [x19, #0x30]
006A63C68  b        #0x6a63c7c ; 
006A63C6C  ldr      x8, [x2, #0x60]
006A63C70  mov      x0, x19
006A63C74  mov      w1, w20
006A63C78  blr      x8
006A63C7C  mov      x0, x19
006A63C80  mov      x1, xzr
006A63C84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A63C88  adrp     x21, #0x959e000
006A63C8C  ldrb     w8, [x21, #0x3c3]
006A63C90  mov      w20, w0
006A63C94  cbnz     w8, #0x6a63cac
006A63C98  adrp     x0, #0x8f36000
006A63C9C  ldr      x0, [x0, #0xbf0]
006A63CA0  bl       #0x382bd14 ; 
006A63CA4  mov      w8, #1
006A63CA8  strb     w8, [x21, #0x3c3]
006A63CAC  adrp     x8, #0x8f36000
006A63CB0  ldr      x8, [x8, #0xbf0]
006A63CB4  ldr      x2, [x8]
006A63CB8  ldrb     w8, [x2, #0x53]
006A63CBC  tbnz     w8, #5, #0x6a63cc8
006A63CC0  str      w20, [x19, #0x34]
006A63CC4  b        #0x6a63cd8 ; 
006A63CC8  ldr      x8, [x2, #0x60]
006A63CCC  mov      x0, x19
006A63CD0  mov      w1, w20
006A63CD4  blr      x8
006A63CD8  mov      x0, x19
006A63CDC  mov      x1, xzr
006A63CE0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A63CE4  adrp     x21, #0x959e000
006A63CE8  ldrb     w8, [x21, #0x3c4]
006A63CEC  mov      x20, x0
006A63CF0  cbnz     w8, #0x6a63d08
006A63CF4  adrp     x0, #0x8f36000
006A63CF8  ldr      x0, [x0, #0xc00]
006A63CFC  bl       #0x382bd14 ; 
006A63D00  mov      w8, #1
006A63D04  strb     w8, [x21, #0x3c4]
006A63D08  adrp     x8, #0x8f36000
006A63D0C  ldr      x8, [x8, #0xc00]
006A63D10  ldr      x2, [x8]
006A63D14  ldrb     w8, [x2, #0x53]
006A63D18  tbnz     w8, #5, #0x6a63d30
006A63D1C  mov      x0, x19
006A63D20  str      x20, [x0, #0x38]!
006A63D24  mov      x1, x20
006A63D28  bl       #0x382bcb8 ; 
006A63D2C  b        #0x6a63d40 ; 
006A63D30  ldr      x8, [x2, #0x60]
006A63D34  mov      x0, x19
006A63D38  mov      x1, x20
006A63D3C  blr      x8
006A63D40  mov      x0, x19
006A63D44  mov      x1, xzr
006A63D48  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A63D4C  adrp     x21, #0x959e000
006A63D50  ldrb     w8, [x21, #0x3c5]
006A63D54  mov      w20, w0
006A63D58  cbnz     w8, #0x6a63d70
006A63D5C  adrp     x0, #0x8f36000
006A63D60  ldr      x0, [x0, #0xc10]
006A63D64  bl       #0x382bd14 ; 
006A63D68  mov      w8, #1
006A63D6C  strb     w8, [x21, #0x3c5]
006A63D70  adrp     x8, #0x8f36000
006A63D74  ldr      x8, [x8, #0xc10]
006A63D78  ldr      x2, [x8]
006A63D7C  ldrb     w8, [x2, #0x53]
006A63D80  tbnz     w8, #5, #0x6a63d8c
006A63D84  str      w20, [x19, #0x40]
006A63D88  b        #0x6a63d9c ; 
006A63D8C  ldr      x8, [x2, #0x60]
006A63D90  mov      x0, x19
006A63D94  mov      w1, w20
006A63D98  blr      x8
006A63D9C  mov      x0, x19
006A63DA0  mov      x1, xzr
006A63DA4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A63DA8  adrp     x21, #0x959e000
006A63DAC  ldrb     w8, [x21, #0x3c6]
006A63DB0  mov      x20, x0
006A63DB4  cbnz     w8, #0x6a63dcc
006A63DB8  adrp     x0, #0x8f36000
006A63DBC  ldr      x0, [x0, #0xc20]
006A63DC0  bl       #0x382bd14 ; 
006A63DC4  mov      w8, #1
006A63DC8  strb     w8, [x21, #0x3c6]
006A63DCC  adrp     x8, #0x8f36000
006A63DD0  ldr      x8, [x8, #0xc20]
006A63DD4  ldr      x2, [x8]
006A63DD8  ldrb     w8, [x2, #0x53]
006A63DDC  tbnz     w8, #5, #0x6a63df4
006A63DE0  str      x20, [x19, #0x48]!
006A63DE4  mov      x0, x19
006A63DE8  mov      x1, x20
006A63DEC  bl       #0x382bcb8 ; 
006A63DF0  b        #0x6a63e04 ; 
006A63DF4  ldr      x8, [x2, #0x60]
006A63DF8  mov      x0, x19
006A63DFC  mov      x1, x20
006A63E00  blr      x8
006A63E04  ldp      x20, x19, [sp, #0x10]
006A63E08  mov      w0, #1
006A63E0C  ldp      x30, x21, [sp], #0x20
006A63E10  ret      

