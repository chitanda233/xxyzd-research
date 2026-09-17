; LocalModels.Bean.EventFishing_SpecialArea$$readImpl
; RVA 0x6A779B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A779B4  stp      x30, x21, [sp, #-0x20]!
006A779B8  stp      x20, x19, [sp, #0x10]
006A779BC  adrp     x20, #0x959d000
006A779C0  adrp     x21, #0x8f37000
006A779C4  ldrb     w8, [x20, #0xe5b]
006A779C8  ldr      x21, [x21, #0xb58]
006A779CC  mov      x19, x0
006A779D0  tbnz     w8, #0, #0x6a779e8
006A779D4  adrp     x0, #0x8f37000
006A779D8  ldr      x0, [x0, #0xb58]
006A779DC  bl       #0x382bd14 ; 
006A779E0  mov      w8, #1
006A779E4  strb     w8, [x20, #0xe5b]
006A779E8  ldr      x1, [x21]
006A779EC  ldrb     w8, [x1, #0x53]
006A779F0  tbnz     w8, #5, #0x6a77a40
006A779F4  mov      x0, x19
006A779F8  mov      x1, xzr
006A779FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A77A00  adrp     x21, #0x959e000
006A77A04  ldrb     w8, [x21, #0x49e]
006A77A08  mov      w20, w0
006A77A0C  cbnz     w8, #0x6a77a24
006A77A10  adrp     x0, #0x8f37000
006A77A14  ldr      x0, [x0, #0xad0]
006A77A18  bl       #0x382bd14 ; 
006A77A1C  mov      w8, #1
006A77A20  strb     w8, [x21, #0x49e]
006A77A24  adrp     x8, #0x8f37000
006A77A28  ldr      x8, [x8, #0xad0]
006A77A2C  ldr      x2, [x8]
006A77A30  ldrb     w8, [x2, #0x53]
006A77A34  tbnz     w8, #5, #0x6a77a54
006A77A38  str      w20, [x19, #0x20]
006A77A3C  b        #0x6a77a64 ; 
006A77A40  ldr      x2, [x1, #0x60]
006A77A44  mov      x0, x19
006A77A48  ldp      x20, x19, [sp, #0x10]
006A77A4C  ldp      x30, x21, [sp], #0x20
006A77A50  br       x2
006A77A54  ldr      x8, [x2, #0x60]
006A77A58  mov      x0, x19
006A77A5C  mov      w1, w20
006A77A60  blr      x8
006A77A64  mov      x0, x19
006A77A68  mov      x1, xzr
006A77A6C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A77A70  adrp     x21, #0x959e000
006A77A74  ldrb     w8, [x21, #0x49f]
006A77A78  mov      w20, w0
006A77A7C  cbnz     w8, #0x6a77a94
006A77A80  adrp     x0, #0x8f37000
006A77A84  ldr      x0, [x0, #0xae0]
006A77A88  bl       #0x382bd14 ; 
006A77A8C  mov      w8, #1
006A77A90  strb     w8, [x21, #0x49f]
006A77A94  adrp     x8, #0x8f37000
006A77A98  ldr      x8, [x8, #0xae0]
006A77A9C  ldr      x2, [x8]
006A77AA0  ldrb     w8, [x2, #0x53]
006A77AA4  tbnz     w8, #5, #0x6a77ab0
006A77AA8  str      w20, [x19, #0x24]
006A77AAC  b        #0x6a77ac0 ; 
006A77AB0  ldr      x8, [x2, #0x60]
006A77AB4  mov      x0, x19
006A77AB8  mov      w1, w20
006A77ABC  blr      x8
006A77AC0  mov      x0, x19
006A77AC4  mov      x1, xzr
006A77AC8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A77ACC  adrp     x21, #0x959e000
006A77AD0  ldrb     w8, [x21, #0x4a0]
006A77AD4  mov      x20, x0
006A77AD8  cbnz     w8, #0x6a77af0
006A77ADC  adrp     x0, #0x8f37000
006A77AE0  ldr      x0, [x0, #0xaf0]
006A77AE4  bl       #0x382bd14 ; 
006A77AE8  mov      w8, #1
006A77AEC  strb     w8, [x21, #0x4a0]
006A77AF0  adrp     x8, #0x8f37000
006A77AF4  ldr      x8, [x8, #0xaf0]
006A77AF8  ldr      x2, [x8]
006A77AFC  ldrb     w8, [x2, #0x53]
006A77B00  tbnz     w8, #5, #0x6a77b18
006A77B04  mov      x0, x19
006A77B08  str      x20, [x0, #0x28]!
006A77B0C  mov      x1, x20
006A77B10  bl       #0x382bcb8 ; 
006A77B14  b        #0x6a77b28 ; 
006A77B18  ldr      x8, [x2, #0x60]
006A77B1C  mov      x0, x19
006A77B20  mov      x1, x20
006A77B24  blr      x8
006A77B28  mov      x0, x19
006A77B2C  mov      x1, xzr
006A77B30  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A77B34  adrp     x21, #0x959e000
006A77B38  ldrb     w8, [x21, #0x4a1]
006A77B3C  mov      w20, w0
006A77B40  cbnz     w8, #0x6a77b58
006A77B44  adrp     x0, #0x8f37000
006A77B48  ldr      x0, [x0, #0xb00]
006A77B4C  bl       #0x382bd14 ; 
006A77B50  mov      w8, #1
006A77B54  strb     w8, [x21, #0x4a1]
006A77B58  adrp     x8, #0x8f37000
006A77B5C  ldr      x8, [x8, #0xb00]
006A77B60  ldr      x2, [x8]
006A77B64  ldrb     w8, [x2, #0x53]
006A77B68  tbnz     w8, #5, #0x6a77b74
006A77B6C  str      w20, [x19, #0x30]
006A77B70  b        #0x6a77b84 ; 
006A77B74  ldr      x8, [x2, #0x60]
006A77B78  mov      x0, x19
006A77B7C  mov      w1, w20
006A77B80  blr      x8
006A77B84  mov      x0, x19
006A77B88  mov      x1, xzr
006A77B8C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A77B90  adrp     x21, #0x959e000
006A77B94  ldrb     w8, [x21, #0x4a2]
006A77B98  mov      w20, w0
006A77B9C  cbnz     w8, #0x6a77bb4
006A77BA0  adrp     x0, #0x8f37000
006A77BA4  ldr      x0, [x0, #0xb10]
006A77BA8  bl       #0x382bd14 ; 
006A77BAC  mov      w8, #1
006A77BB0  strb     w8, [x21, #0x4a2]
006A77BB4  adrp     x8, #0x8f37000
006A77BB8  ldr      x8, [x8, #0xb10]
006A77BBC  ldr      x2, [x8]
006A77BC0  ldrb     w8, [x2, #0x53]
006A77BC4  tbnz     w8, #5, #0x6a77bd0
006A77BC8  str      w20, [x19, #0x34]
006A77BCC  b        #0x6a77be0 ; 
006A77BD0  ldr      x8, [x2, #0x60]
006A77BD4  mov      x0, x19
006A77BD8  mov      w1, w20
006A77BDC  blr      x8
006A77BE0  mov      x0, x19
006A77BE4  mov      x1, xzr
006A77BE8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A77BEC  adrp     x21, #0x959e000
006A77BF0  ldrb     w8, [x21, #0x4a3]
006A77BF4  mov      w20, w0
006A77BF8  cbnz     w8, #0x6a77c10
006A77BFC  adrp     x0, #0x8f37000
006A77C00  ldr      x0, [x0, #0xb20]
006A77C04  bl       #0x382bd14 ; 
006A77C08  mov      w8, #1
006A77C0C  strb     w8, [x21, #0x4a3]
006A77C10  adrp     x8, #0x8f37000
006A77C14  ldr      x8, [x8, #0xb20]
006A77C18  ldr      x2, [x8]
006A77C1C  ldrb     w8, [x2, #0x53]
006A77C20  tbnz     w8, #5, #0x6a77c2c
006A77C24  str      w20, [x19, #0x38]
006A77C28  b        #0x6a77c3c ; 
006A77C2C  ldr      x8, [x2, #0x60]
006A77C30  mov      x0, x19
006A77C34  mov      w1, w20
006A77C38  blr      x8
006A77C3C  mov      x0, x19
006A77C40  mov      x1, xzr
006A77C44  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A77C48  adrp     x21, #0x959e000
006A77C4C  ldrb     w8, [x21, #0x4a4]
006A77C50  mov      w20, w0
006A77C54  cbnz     w8, #0x6a77c6c
006A77C58  adrp     x0, #0x8f37000
006A77C5C  ldr      x0, [x0, #0xb30]
006A77C60  bl       #0x382bd14 ; 
006A77C64  mov      w8, #1
006A77C68  strb     w8, [x21, #0x4a4]
006A77C6C  adrp     x8, #0x8f37000
006A77C70  ldr      x8, [x8, #0xb30]
006A77C74  ldr      x2, [x8]
006A77C78  ldrb     w8, [x2, #0x53]
006A77C7C  tbnz     w8, #5, #0x6a77c88
006A77C80  str      w20, [x19, #0x3c]
006A77C84  b        #0x6a77c98 ; 
006A77C88  ldr      x8, [x2, #0x60]
006A77C8C  mov      x0, x19
006A77C90  mov      w1, w20
006A77C94  blr      x8
006A77C98  mov      x0, x19
006A77C9C  mov      x1, xzr
006A77CA0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A77CA4  adrp     x21, #0x959e000
006A77CA8  ldrb     w8, [x21, #0x4a5]
006A77CAC  mov      w20, w0
006A77CB0  cbnz     w8, #0x6a77cc8
006A77CB4  adrp     x0, #0x8f37000
006A77CB8  ldr      x0, [x0, #0xb40]
006A77CBC  bl       #0x382bd14 ; 
006A77CC0  mov      w8, #1
006A77CC4  strb     w8, [x21, #0x4a5]
006A77CC8  adrp     x8, #0x8f37000
006A77CCC  ldr      x8, [x8, #0xb40]
006A77CD0  ldr      x2, [x8]
006A77CD4  ldrb     w8, [x2, #0x53]
006A77CD8  tbnz     w8, #5, #0x6a77ce4
006A77CDC  str      w20, [x19, #0x40]
006A77CE0  b        #0x6a77cf4 ; 
006A77CE4  ldr      x8, [x2, #0x60]
006A77CE8  mov      x0, x19
006A77CEC  mov      w1, w20
006A77CF0  blr      x8
006A77CF4  mov      x0, x19
006A77CF8  mov      x1, xzr
006A77CFC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A77D00  adrp     x21, #0x959e000
006A77D04  ldrb     w8, [x21, #0x4a6]
006A77D08  mov      x20, x0
006A77D0C  cbnz     w8, #0x6a77d24
006A77D10  adrp     x0, #0x8f37000
006A77D14  ldr      x0, [x0, #0xb50]
006A77D18  bl       #0x382bd14 ; 
006A77D1C  mov      w8, #1
006A77D20  strb     w8, [x21, #0x4a6]
006A77D24  adrp     x8, #0x8f37000
006A77D28  ldr      x8, [x8, #0xb50]
006A77D2C  ldr      x2, [x8]
006A77D30  ldrb     w8, [x2, #0x53]
006A77D34  tbnz     w8, #5, #0x6a77d4c
006A77D38  str      x20, [x19, #0x48]!
006A77D3C  mov      x0, x19
006A77D40  mov      x1, x20
006A77D44  bl       #0x382bcb8 ; 
006A77D48  b        #0x6a77d5c ; 
006A77D4C  ldr      x8, [x2, #0x60]
006A77D50  mov      x0, x19
006A77D54  mov      x1, x20
006A77D58  blr      x8
006A77D5C  ldp      x20, x19, [sp, #0x10]
006A77D60  mov      w0, #1
006A77D64  ldp      x30, x21, [sp], #0x20
006A77D68  ret      

