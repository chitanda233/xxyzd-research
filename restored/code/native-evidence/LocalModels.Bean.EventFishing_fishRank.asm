; LocalModels.Bean.EventFishing_fishRank$$readImpl
; RVA 0x6A75B48; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A75B48  stp      x30, x21, [sp, #-0x20]!
006A75B4C  stp      x20, x19, [sp, #0x10]
006A75B50  adrp     x20, #0x959d000
006A75B54  adrp     x21, #0x8f37000
006A75B58  ldrb     w8, [x20, #0xe26]
006A75B5C  ldr      x21, [x21, #0x9c8]
006A75B60  mov      x19, x0
006A75B64  tbnz     w8, #0, #0x6a75b7c
006A75B68  adrp     x0, #0x8f37000
006A75B6C  ldr      x0, [x0, #0x9c8]
006A75B70  bl       #0x382bd14 ; 
006A75B74  mov      w8, #1
006A75B78  strb     w8, [x20, #0xe26]
006A75B7C  ldr      x1, [x21]
006A75B80  ldrb     w8, [x1, #0x53]
006A75B84  tbnz     w8, #5, #0x6a75bd4
006A75B88  mov      x0, x19
006A75B8C  mov      x1, xzr
006A75B90  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A75B94  adrp     x21, #0x959e000
006A75B98  ldrb     w8, [x21, #0x48b]
006A75B9C  mov      w20, w0
006A75BA0  cbnz     w8, #0x6a75bb8
006A75BA4  adrp     x0, #0x8f37000
006A75BA8  ldr      x0, [x0, #0x970]
006A75BAC  bl       #0x382bd14 ; 
006A75BB0  mov      w8, #1
006A75BB4  strb     w8, [x21, #0x48b]
006A75BB8  adrp     x8, #0x8f37000
006A75BBC  ldr      x8, [x8, #0x970]
006A75BC0  ldr      x2, [x8]
006A75BC4  ldrb     w8, [x2, #0x53]
006A75BC8  tbnz     w8, #5, #0x6a75be8
006A75BCC  str      w20, [x19, #0x20]
006A75BD0  b        #0x6a75bf8 ; 
006A75BD4  ldr      x2, [x1, #0x60]
006A75BD8  mov      x0, x19
006A75BDC  ldp      x20, x19, [sp, #0x10]
006A75BE0  ldp      x30, x21, [sp], #0x20
006A75BE4  br       x2
006A75BE8  ldr      x8, [x2, #0x60]
006A75BEC  mov      x0, x19
006A75BF0  mov      w1, w20
006A75BF4  blr      x8
006A75BF8  mov      x0, x19
006A75BFC  mov      x1, xzr
006A75C00  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A75C04  adrp     x21, #0x959e000
006A75C08  ldrb     w8, [x21, #0x48c]
006A75C0C  mov      w20, w0
006A75C10  cbnz     w8, #0x6a75c28
006A75C14  adrp     x0, #0x8f37000
006A75C18  ldr      x0, [x0, #0x980]
006A75C1C  bl       #0x382bd14 ; 
006A75C20  mov      w8, #1
006A75C24  strb     w8, [x21, #0x48c]
006A75C28  adrp     x8, #0x8f37000
006A75C2C  ldr      x8, [x8, #0x980]
006A75C30  ldr      x2, [x8]
006A75C34  ldrb     w8, [x2, #0x53]
006A75C38  tbnz     w8, #5, #0x6a75c44
006A75C3C  str      w20, [x19, #0x24]
006A75C40  b        #0x6a75c54 ; 
006A75C44  ldr      x8, [x2, #0x60]
006A75C48  mov      x0, x19
006A75C4C  mov      w1, w20
006A75C50  blr      x8
006A75C54  mov      x0, x19
006A75C58  mov      x1, xzr
006A75C5C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A75C60  adrp     x21, #0x959e000
006A75C64  ldrb     w8, [x21, #0x48d]
006A75C68  mov      w20, w0
006A75C6C  cbnz     w8, #0x6a75c84
006A75C70  adrp     x0, #0x8f37000
006A75C74  ldr      x0, [x0, #0x990]
006A75C78  bl       #0x382bd14 ; 
006A75C7C  mov      w8, #1
006A75C80  strb     w8, [x21, #0x48d]
006A75C84  adrp     x8, #0x8f37000
006A75C88  ldr      x8, [x8, #0x990]
006A75C8C  ldr      x2, [x8]
006A75C90  ldrb     w8, [x2, #0x53]
006A75C94  tbnz     w8, #5, #0x6a75ca0
006A75C98  str      w20, [x19, #0x28]
006A75C9C  b        #0x6a75cb0 ; 
006A75CA0  ldr      x8, [x2, #0x60]
006A75CA4  mov      x0, x19
006A75CA8  mov      w1, w20
006A75CAC  blr      x8
006A75CB0  mov      x0, x19
006A75CB4  mov      x1, xzr
006A75CB8  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A75CBC  adrp     x21, #0x959e000
006A75CC0  ldrb     w8, [x21, #0x48e]
006A75CC4  mov      x20, x0
006A75CC8  cbnz     w8, #0x6a75ce0
006A75CCC  adrp     x0, #0x8f37000
006A75CD0  ldr      x0, [x0, #0x9a0]
006A75CD4  bl       #0x382bd14 ; 
006A75CD8  mov      w8, #1
006A75CDC  strb     w8, [x21, #0x48e]
006A75CE0  adrp     x8, #0x8f37000
006A75CE4  ldr      x8, [x8, #0x9a0]
006A75CE8  ldr      x2, [x8]
006A75CEC  ldrb     w8, [x2, #0x53]
006A75CF0  tbnz     w8, #5, #0x6a75d08
006A75CF4  mov      x0, x19
006A75CF8  str      x20, [x0, #0x30]!
006A75CFC  mov      x1, x20
006A75D00  bl       #0x382bcb8 ; 
006A75D04  b        #0x6a75d18 ; 
006A75D08  ldr      x8, [x2, #0x60]
006A75D0C  mov      x0, x19
006A75D10  mov      x1, x20
006A75D14  blr      x8
006A75D18  mov      x0, x19
006A75D1C  mov      x1, xzr
006A75D20  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A75D24  adrp     x21, #0x959e000
006A75D28  ldrb     w8, [x21, #0x48f]
006A75D2C  mov      x20, x0
006A75D30  cbnz     w8, #0x6a75d48
006A75D34  adrp     x0, #0x8f37000
006A75D38  ldr      x0, [x0, #0x9b0]
006A75D3C  bl       #0x382bd14 ; 
006A75D40  mov      w8, #1
006A75D44  strb     w8, [x21, #0x48f]
006A75D48  adrp     x8, #0x8f37000
006A75D4C  ldr      x8, [x8, #0x9b0]
006A75D50  ldr      x2, [x8]
006A75D54  ldrb     w8, [x2, #0x53]
006A75D58  tbnz     w8, #5, #0x6a75d70
006A75D5C  mov      x0, x19
006A75D60  str      x20, [x0, #0x38]!
006A75D64  mov      x1, x20
006A75D68  bl       #0x382bcb8 ; 
006A75D6C  b        #0x6a75d80 ; 
006A75D70  ldr      x8, [x2, #0x60]
006A75D74  mov      x0, x19
006A75D78  mov      x1, x20
006A75D7C  blr      x8
006A75D80  mov      x0, x19
006A75D84  mov      x1, xzr
006A75D88  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A75D8C  adrp     x21, #0x959e000
006A75D90  ldrb     w8, [x21, #0x490]
006A75D94  mov      x20, x0
006A75D98  cbnz     w8, #0x6a75db0
006A75D9C  adrp     x0, #0x8f37000
006A75DA0  ldr      x0, [x0, #0x9c0]
006A75DA4  bl       #0x382bd14 ; 
006A75DA8  mov      w8, #1
006A75DAC  strb     w8, [x21, #0x490]
006A75DB0  adrp     x8, #0x8f37000
006A75DB4  ldr      x8, [x8, #0x9c0]
006A75DB8  ldr      x2, [x8]
006A75DBC  ldrb     w8, [x2, #0x53]
006A75DC0  tbnz     w8, #5, #0x6a75dd8
006A75DC4  str      x20, [x19, #0x40]!
006A75DC8  mov      x0, x19
006A75DCC  mov      x1, x20
006A75DD0  bl       #0x382bcb8 ; 
006A75DD4  b        #0x6a75de8 ; 
006A75DD8  ldr      x8, [x2, #0x60]
006A75DDC  mov      x0, x19
006A75DE0  mov      x1, x20
006A75DE4  blr      x8
006A75DE8  ldp      x20, x19, [sp, #0x10]
006A75DEC  mov      w0, #1
006A75DF0  ldp      x30, x21, [sp], #0x20
006A75DF4  ret      

