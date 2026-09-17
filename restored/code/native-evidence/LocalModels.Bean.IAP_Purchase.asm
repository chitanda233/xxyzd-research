; LocalModels.Bean.IAP_Purchase$$readImpl
; RVA 0x6AA6948; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA6948  stp      x30, x21, [sp, #-0x20]!
006AA694C  stp      x20, x19, [sp, #0x10]
006AA6950  adrp     x20, #0x959e000
006AA6954  adrp     x21, #0x8f39000
006AA6958  ldrb     w8, [x20, #0x6c9]
006AA695C  ldr      x21, [x21, #0xf18]
006AA6960  mov      x19, x0
006AA6964  tbnz     w8, #0, #0x6aa697c
006AA6968  adrp     x0, #0x8f39000
006AA696C  ldr      x0, [x0, #0xf18]
006AA6970  bl       #0x382bd14 ; 
006AA6974  mov      w8, #1
006AA6978  strb     w8, [x20, #0x6c9]
006AA697C  ldr      x1, [x21]
006AA6980  ldrb     w8, [x1, #0x53]
006AA6984  tbnz     w8, #5, #0x6aa69d4
006AA6988  mov      x0, x19
006AA698C  mov      x1, xzr
006AA6990  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA6994  adrp     x21, #0x959e000
006AA6998  ldrb     w8, [x21, #0xefe]
006AA699C  mov      w20, w0
006AA69A0  cbnz     w8, #0x6aa69b8
006AA69A4  adrp     x0, #0x8f39000
006AA69A8  ldr      x0, [x0, #0xea0]
006AA69AC  bl       #0x382bd14 ; 
006AA69B0  mov      w8, #1
006AA69B4  strb     w8, [x21, #0xefe]
006AA69B8  adrp     x8, #0x8f39000
006AA69BC  ldr      x8, [x8, #0xea0]
006AA69C0  ldr      x2, [x8]
006AA69C4  ldrb     w8, [x2, #0x53]
006AA69C8  tbnz     w8, #5, #0x6aa69e8
006AA69CC  str      w20, [x19, #0x20]
006AA69D0  b        #0x6aa69f8 ; 
006AA69D4  ldr      x2, [x1, #0x60]
006AA69D8  mov      x0, x19
006AA69DC  ldp      x20, x19, [sp, #0x10]
006AA69E0  ldp      x30, x21, [sp], #0x20
006AA69E4  br       x2
006AA69E8  ldr      x8, [x2, #0x60]
006AA69EC  mov      x0, x19
006AA69F0  mov      w1, w20
006AA69F4  blr      x8
006AA69F8  mov      x0, x19
006AA69FC  mov      x1, xzr
006AA6A00  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA6A04  adrp     x21, #0x959e000
006AA6A08  ldrb     w8, [x21, #0xeff]
006AA6A0C  mov      x20, x0
006AA6A10  cbnz     w8, #0x6aa6a28
006AA6A14  adrp     x0, #0x8f39000
006AA6A18  ldr      x0, [x0, #0xeb0]
006AA6A1C  bl       #0x382bd14 ; 
006AA6A20  mov      w8, #1
006AA6A24  strb     w8, [x21, #0xeff]
006AA6A28  adrp     x8, #0x8f39000
006AA6A2C  ldr      x8, [x8, #0xeb0]
006AA6A30  ldr      x2, [x8]
006AA6A34  ldrb     w8, [x2, #0x53]
006AA6A38  tbnz     w8, #5, #0x6aa6a50
006AA6A3C  mov      x0, x19
006AA6A40  str      x20, [x0, #0x28]!
006AA6A44  mov      x1, x20
006AA6A48  bl       #0x382bcb8 ; 
006AA6A4C  b        #0x6aa6a60 ; 
006AA6A50  ldr      x8, [x2, #0x60]
006AA6A54  mov      x0, x19
006AA6A58  mov      x1, x20
006AA6A5C  blr      x8
006AA6A60  mov      x0, x19
006AA6A64  mov      x1, xzr
006AA6A68  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA6A6C  adrp     x21, #0x959e000
006AA6A70  ldrb     w8, [x21, #0xf00]
006AA6A74  mov      x20, x0
006AA6A78  cbnz     w8, #0x6aa6a90
006AA6A7C  adrp     x0, #0x8f39000
006AA6A80  ldr      x0, [x0, #0xec0]
006AA6A84  bl       #0x382bd14 ; 
006AA6A88  mov      w8, #1
006AA6A8C  strb     w8, [x21, #0xf00]
006AA6A90  adrp     x8, #0x8f39000
006AA6A94  ldr      x8, [x8, #0xec0]
006AA6A98  ldr      x2, [x8]
006AA6A9C  ldrb     w8, [x2, #0x53]
006AA6AA0  tbnz     w8, #5, #0x6aa6ab8
006AA6AA4  mov      x0, x19
006AA6AA8  str      x20, [x0, #0x30]!
006AA6AAC  mov      x1, x20
006AA6AB0  bl       #0x382bcb8 ; 
006AA6AB4  b        #0x6aa6ac8 ; 
006AA6AB8  ldr      x8, [x2, #0x60]
006AA6ABC  mov      x0, x19
006AA6AC0  mov      x1, x20
006AA6AC4  blr      x8
006AA6AC8  mov      x0, x19
006AA6ACC  mov      x1, xzr
006AA6AD0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA6AD4  adrp     x21, #0x959e000
006AA6AD8  ldrb     w8, [x21, #0xf01]
006AA6ADC  mov      x20, x0
006AA6AE0  cbnz     w8, #0x6aa6af8
006AA6AE4  adrp     x0, #0x8f39000
006AA6AE8  ldr      x0, [x0, #0xed0]
006AA6AEC  bl       #0x382bd14 ; 
006AA6AF0  mov      w8, #1
006AA6AF4  strb     w8, [x21, #0xf01]
006AA6AF8  adrp     x8, #0x8f39000
006AA6AFC  ldr      x8, [x8, #0xed0]
006AA6B00  ldr      x2, [x8]
006AA6B04  ldrb     w8, [x2, #0x53]
006AA6B08  tbnz     w8, #5, #0x6aa6b20
006AA6B0C  mov      x0, x19
006AA6B10  str      x20, [x0, #0x38]!
006AA6B14  mov      x1, x20
006AA6B18  bl       #0x382bcb8 ; 
006AA6B1C  b        #0x6aa6b30 ; 
006AA6B20  ldr      x8, [x2, #0x60]
006AA6B24  mov      x0, x19
006AA6B28  mov      x1, x20
006AA6B2C  blr      x8
006AA6B30  mov      x0, x19
006AA6B34  mov      x1, xzr
006AA6B38  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA6B3C  adrp     x21, #0x959e000
006AA6B40  ldrb     w8, [x21, #0xf02]
006AA6B44  mov      w20, w0
006AA6B48  cbnz     w8, #0x6aa6b60
006AA6B4C  adrp     x0, #0x8f39000
006AA6B50  ldr      x0, [x0, #0xee0]
006AA6B54  bl       #0x382bd14 ; 
006AA6B58  mov      w8, #1
006AA6B5C  strb     w8, [x21, #0xf02]
006AA6B60  adrp     x8, #0x8f39000
006AA6B64  ldr      x8, [x8, #0xee0]
006AA6B68  ldr      x2, [x8]
006AA6B6C  ldrb     w8, [x2, #0x53]
006AA6B70  tbnz     w8, #5, #0x6aa6b7c
006AA6B74  str      w20, [x19, #0x40]
006AA6B78  b        #0x6aa6b8c ; 
006AA6B7C  ldr      x8, [x2, #0x60]
006AA6B80  mov      x0, x19
006AA6B84  mov      w1, w20
006AA6B88  blr      x8
006AA6B8C  mov      x0, x19
006AA6B90  mov      x1, xzr
006AA6B94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA6B98  adrp     x21, #0x959e000
006AA6B9C  ldrb     w8, [x21, #0xf03]
006AA6BA0  mov      w20, w0
006AA6BA4  cbnz     w8, #0x6aa6bbc
006AA6BA8  adrp     x0, #0x8f39000
006AA6BAC  ldr      x0, [x0, #0xef0]
006AA6BB0  bl       #0x382bd14 ; 
006AA6BB4  mov      w8, #1
006AA6BB8  strb     w8, [x21, #0xf03]
006AA6BBC  adrp     x8, #0x8f39000
006AA6BC0  ldr      x8, [x8, #0xef0]
006AA6BC4  ldr      x2, [x8]
006AA6BC8  ldrb     w8, [x2, #0x53]
006AA6BCC  tbnz     w8, #5, #0x6aa6bd8
006AA6BD0  str      w20, [x19, #0x44]
006AA6BD4  b        #0x6aa6be8 ; 
006AA6BD8  ldr      x8, [x2, #0x60]
006AA6BDC  mov      x0, x19
006AA6BE0  mov      w1, w20
006AA6BE4  blr      x8
006AA6BE8  mov      x0, x19
006AA6BEC  mov      x1, xzr
006AA6BF0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA6BF4  adrp     x21, #0x959e000
006AA6BF8  ldrb     w8, [x21, #0xf04]
006AA6BFC  mov      w20, w0
006AA6C00  cbnz     w8, #0x6aa6c18
006AA6C04  adrp     x0, #0x8f39000
006AA6C08  ldr      x0, [x0, #0xf00]
006AA6C0C  bl       #0x382bd14 ; 
006AA6C10  mov      w8, #1
006AA6C14  strb     w8, [x21, #0xf04]
006AA6C18  adrp     x8, #0x8f39000
006AA6C1C  ldr      x8, [x8, #0xf00]
006AA6C20  ldr      x2, [x8]
006AA6C24  ldrb     w8, [x2, #0x53]
006AA6C28  tbnz     w8, #5, #0x6aa6c34
006AA6C2C  str      w20, [x19, #0x48]
006AA6C30  b        #0x6aa6c44 ; 
006AA6C34  ldr      x8, [x2, #0x60]
006AA6C38  mov      x0, x19
006AA6C3C  mov      w1, w20
006AA6C40  blr      x8
006AA6C44  mov      x0, x19
006AA6C48  mov      x1, xzr
006AA6C4C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA6C50  adrp     x21, #0x959e000
006AA6C54  ldrb     w8, [x21, #0xf05]
006AA6C58  mov      w20, w0
006AA6C5C  cbnz     w8, #0x6aa6c74
006AA6C60  adrp     x0, #0x8f39000
006AA6C64  ldr      x0, [x0, #0xf10]
006AA6C68  bl       #0x382bd14 ; 
006AA6C6C  mov      w8, #1
006AA6C70  strb     w8, [x21, #0xf05]
006AA6C74  adrp     x8, #0x8f39000
006AA6C78  ldr      x8, [x8, #0xf10]
006AA6C7C  ldr      x2, [x8]
006AA6C80  ldrb     w8, [x2, #0x53]
006AA6C84  tbnz     w8, #5, #0x6aa6c90
006AA6C88  str      w20, [x19, #0x4c]
006AA6C8C  b        #0x6aa6ca0 ; 
006AA6C90  ldr      x8, [x2, #0x60]
006AA6C94  mov      x0, x19
006AA6C98  mov      w1, w20
006AA6C9C  blr      x8
006AA6CA0  ldp      x20, x19, [sp, #0x10]
006AA6CA4  mov      w0, #1
006AA6CA8  ldp      x30, x21, [sp], #0x20
006AA6CAC  ret      

