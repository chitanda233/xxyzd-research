; LocalModels.Bean.Character_HandBook$$readImpl
; RVA 0x68C689C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068C689C  stp      x30, x21, [sp, #-0x20]!
0068C68A0  stp      x20, x19, [sp, #0x10]
0068C68A4  adrp     x20, #0x959c000
0068C68A8  adrp     x21, #0x8f27000
0068C68AC  ldrb     w8, [x20, #0x2ac]
0068C68B0  ldr      x21, [x21, #0xf98]
0068C68B4  mov      x19, x0
0068C68B8  tbnz     w8, #0, #0x68c68d0
0068C68BC  adrp     x0, #0x8f27000
0068C68C0  ldr      x0, [x0, #0xf98]
0068C68C4  bl       #0x382bd14 ; 
0068C68C8  mov      w8, #1
0068C68CC  strb     w8, [x20, #0x2ac]
0068C68D0  ldr      x1, [x21]
0068C68D4  ldrb     w8, [x1, #0x53]
0068C68D8  tbnz     w8, #5, #0x68c6928
0068C68DC  mov      x0, x19
0068C68E0  mov      x1, xzr
0068C68E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C68E8  adrp     x21, #0x959c000
0068C68EC  ldrb     w8, [x21, #0x6e6]
0068C68F0  mov      w20, w0
0068C68F4  cbnz     w8, #0x68c690c
0068C68F8  adrp     x0, #0x8f27000
0068C68FC  ldr      x0, [x0, #0xeb0]
0068C6900  bl       #0x382bd14 ; 
0068C6904  mov      w8, #1
0068C6908  strb     w8, [x21, #0x6e6]
0068C690C  adrp     x8, #0x8f27000
0068C6910  ldr      x8, [x8, #0xeb0]
0068C6914  ldr      x2, [x8]
0068C6918  ldrb     w8, [x2, #0x53]
0068C691C  tbnz     w8, #5, #0x68c693c
0068C6920  str      w20, [x19, #0x20]
0068C6924  b        #0x68c694c ; 
0068C6928  ldr      x2, [x1, #0x60]
0068C692C  mov      x0, x19
0068C6930  ldp      x20, x19, [sp, #0x10]
0068C6934  ldp      x30, x21, [sp], #0x20
0068C6938  br       x2
0068C693C  ldr      x8, [x2, #0x60]
0068C6940  mov      x0, x19
0068C6944  mov      w1, w20
0068C6948  blr      x8
0068C694C  mov      x0, x19
0068C6950  mov      x1, xzr
0068C6954  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C6958  adrp     x21, #0x959c000
0068C695C  ldrb     w8, [x21, #0x6e7]
0068C6960  mov      w20, w0
0068C6964  cbnz     w8, #0x68c697c
0068C6968  adrp     x0, #0x8f27000
0068C696C  ldr      x0, [x0, #0xec0]
0068C6970  bl       #0x382bd14 ; 
0068C6974  mov      w8, #1
0068C6978  strb     w8, [x21, #0x6e7]
0068C697C  adrp     x8, #0x8f27000
0068C6980  ldr      x8, [x8, #0xec0]
0068C6984  ldr      x2, [x8]
0068C6988  ldrb     w8, [x2, #0x53]
0068C698C  tbnz     w8, #5, #0x68c6998
0068C6990  str      w20, [x19, #0x24]
0068C6994  b        #0x68c69a8 ; 
0068C6998  ldr      x8, [x2, #0x60]
0068C699C  mov      x0, x19
0068C69A0  mov      w1, w20
0068C69A4  blr      x8
0068C69A8  mov      x0, x19
0068C69AC  mov      x1, xzr
0068C69B0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C69B4  adrp     x21, #0x959c000
0068C69B8  ldrb     w8, [x21, #0x6e8]
0068C69BC  mov      x20, x0
0068C69C0  cbnz     w8, #0x68c69d8
0068C69C4  adrp     x0, #0x8f27000
0068C69C8  ldr      x0, [x0, #0xed0]
0068C69CC  bl       #0x382bd14 ; 
0068C69D0  mov      w8, #1
0068C69D4  strb     w8, [x21, #0x6e8]
0068C69D8  adrp     x8, #0x8f27000
0068C69DC  ldr      x8, [x8, #0xed0]
0068C69E0  ldr      x2, [x8]
0068C69E4  ldrb     w8, [x2, #0x53]
0068C69E8  tbnz     w8, #5, #0x68c6a00
0068C69EC  mov      x0, x19
0068C69F0  str      x20, [x0, #0x28]!
0068C69F4  mov      x1, x20
0068C69F8  bl       #0x382bcb8 ; 
0068C69FC  b        #0x68c6a10 ; 
0068C6A00  ldr      x8, [x2, #0x60]
0068C6A04  mov      x0, x19
0068C6A08  mov      x1, x20
0068C6A0C  blr      x8
0068C6A10  mov      x0, x19
0068C6A14  mov      x1, xzr
0068C6A18  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C6A1C  adrp     x21, #0x959c000
0068C6A20  ldrb     w8, [x21, #0x6e9]
0068C6A24  mov      x20, x0
0068C6A28  cbnz     w8, #0x68c6a40
0068C6A2C  adrp     x0, #0x8f27000
0068C6A30  ldr      x0, [x0, #0xee0]
0068C6A34  bl       #0x382bd14 ; 
0068C6A38  mov      w8, #1
0068C6A3C  strb     w8, [x21, #0x6e9]
0068C6A40  adrp     x8, #0x8f27000
0068C6A44  ldr      x8, [x8, #0xee0]
0068C6A48  ldr      x2, [x8]
0068C6A4C  ldrb     w8, [x2, #0x53]
0068C6A50  tbnz     w8, #5, #0x68c6a68
0068C6A54  mov      x0, x19
0068C6A58  str      x20, [x0, #0x30]!
0068C6A5C  mov      x1, x20
0068C6A60  bl       #0x382bcb8 ; 
0068C6A64  b        #0x68c6a78 ; 
0068C6A68  ldr      x8, [x2, #0x60]
0068C6A6C  mov      x0, x19
0068C6A70  mov      x1, x20
0068C6A74  blr      x8
0068C6A78  mov      x0, x19
0068C6A7C  mov      x1, xzr
0068C6A80  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C6A84  adrp     x21, #0x959c000
0068C6A88  ldrb     w8, [x21, #0x6ea]
0068C6A8C  mov      w20, w0
0068C6A90  cbnz     w8, #0x68c6aa8
0068C6A94  adrp     x0, #0x8f27000
0068C6A98  ldr      x0, [x0, #0xef0]
0068C6A9C  bl       #0x382bd14 ; 
0068C6AA0  mov      w8, #1
0068C6AA4  strb     w8, [x21, #0x6ea]
0068C6AA8  adrp     x8, #0x8f27000
0068C6AAC  ldr      x8, [x8, #0xef0]
0068C6AB0  ldr      x2, [x8]
0068C6AB4  ldrb     w8, [x2, #0x53]
0068C6AB8  tbnz     w8, #5, #0x68c6ac4
0068C6ABC  str      w20, [x19, #0x38]
0068C6AC0  b        #0x68c6ad4 ; 
0068C6AC4  ldr      x8, [x2, #0x60]
0068C6AC8  mov      x0, x19
0068C6ACC  mov      w1, w20
0068C6AD0  blr      x8
0068C6AD4  mov      x0, x19
0068C6AD8  mov      x1, xzr
0068C6ADC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C6AE0  adrp     x21, #0x959c000
0068C6AE4  ldrb     w8, [x21, #0x6eb]
0068C6AE8  mov      x20, x0
0068C6AEC  cbnz     w8, #0x68c6b04
0068C6AF0  adrp     x0, #0x8f27000
0068C6AF4  ldr      x0, [x0, #0xf00]
0068C6AF8  bl       #0x382bd14 ; 
0068C6AFC  mov      w8, #1
0068C6B00  strb     w8, [x21, #0x6eb]
0068C6B04  adrp     x8, #0x8f27000
0068C6B08  ldr      x8, [x8, #0xf00]
0068C6B0C  ldr      x2, [x8]
0068C6B10  ldrb     w8, [x2, #0x53]
0068C6B14  tbnz     w8, #5, #0x68c6b2c
0068C6B18  mov      x0, x19
0068C6B1C  str      x20, [x0, #0x40]!
0068C6B20  mov      x1, x20
0068C6B24  bl       #0x382bcb8 ; 
0068C6B28  b        #0x68c6b3c ; 
0068C6B2C  ldr      x8, [x2, #0x60]
0068C6B30  mov      x0, x19
0068C6B34  mov      x1, x20
0068C6B38  blr      x8
0068C6B3C  mov      x0, x19
0068C6B40  mov      x1, xzr
0068C6B44  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C6B48  adrp     x21, #0x959c000
0068C6B4C  ldrb     w8, [x21, #0x6ec]
0068C6B50  mov      w20, w0
0068C6B54  cbnz     w8, #0x68c6b6c
0068C6B58  adrp     x0, #0x8f27000
0068C6B5C  ldr      x0, [x0, #0xf10]
0068C6B60  bl       #0x382bd14 ; 
0068C6B64  mov      w8, #1
0068C6B68  strb     w8, [x21, #0x6ec]
0068C6B6C  adrp     x8, #0x8f27000
0068C6B70  ldr      x8, [x8, #0xf10]
0068C6B74  ldr      x2, [x8]
0068C6B78  ldrb     w8, [x2, #0x53]
0068C6B7C  tbnz     w8, #5, #0x68c6b88
0068C6B80  str      w20, [x19, #0x48]
0068C6B84  b        #0x68c6b98 ; 
0068C6B88  ldr      x8, [x2, #0x60]
0068C6B8C  mov      x0, x19
0068C6B90  mov      w1, w20
0068C6B94  blr      x8
0068C6B98  mov      x0, x19
0068C6B9C  mov      x1, xzr
0068C6BA0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C6BA4  adrp     x21, #0x959c000
0068C6BA8  ldrb     w8, [x21, #0x6ed]
0068C6BAC  mov      w20, w0
0068C6BB0  cbnz     w8, #0x68c6bc8
0068C6BB4  adrp     x0, #0x8f27000
0068C6BB8  ldr      x0, [x0, #0xf20]
0068C6BBC  bl       #0x382bd14 ; 
0068C6BC0  mov      w8, #1
0068C6BC4  strb     w8, [x21, #0x6ed]
0068C6BC8  adrp     x8, #0x8f27000
0068C6BCC  ldr      x8, [x8, #0xf20]
0068C6BD0  ldr      x2, [x8]
0068C6BD4  ldrb     w8, [x2, #0x53]
0068C6BD8  tbnz     w8, #5, #0x68c6be4
0068C6BDC  str      w20, [x19, #0x4c]
0068C6BE0  b        #0x68c6bf4 ; 
0068C6BE4  ldr      x8, [x2, #0x60]
0068C6BE8  mov      x0, x19
0068C6BEC  mov      w1, w20
0068C6BF0  blr      x8
0068C6BF4  mov      x0, x19
0068C6BF8  mov      x1, xzr
0068C6BFC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C6C00  adrp     x21, #0x959c000
0068C6C04  ldrb     w8, [x21, #0x6ee]
0068C6C08  mov      x20, x0
0068C6C0C  cbnz     w8, #0x68c6c24
0068C6C10  adrp     x0, #0x8f27000
0068C6C14  ldr      x0, [x0, #0xf30]
0068C6C18  bl       #0x382bd14 ; 
0068C6C1C  mov      w8, #1
0068C6C20  strb     w8, [x21, #0x6ee]
0068C6C24  adrp     x8, #0x8f27000
0068C6C28  ldr      x8, [x8, #0xf30]
0068C6C2C  ldr      x2, [x8]
0068C6C30  ldrb     w8, [x2, #0x53]
0068C6C34  tbnz     w8, #5, #0x68c6c4c
0068C6C38  mov      x0, x19
0068C6C3C  str      x20, [x0, #0x50]!
0068C6C40  mov      x1, x20
0068C6C44  bl       #0x382bcb8 ; 
0068C6C48  b        #0x68c6c5c ; 
0068C6C4C  ldr      x8, [x2, #0x60]
0068C6C50  mov      x0, x19
0068C6C54  mov      x1, x20
0068C6C58  blr      x8
0068C6C5C  mov      x0, x19
0068C6C60  mov      x1, xzr
0068C6C64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C6C68  adrp     x21, #0x959c000
0068C6C6C  ldrb     w8, [x21, #0x6ef]
0068C6C70  mov      w20, w0
0068C6C74  cbnz     w8, #0x68c6c8c
0068C6C78  adrp     x0, #0x8f27000
0068C6C7C  ldr      x0, [x0, #0xf40]
0068C6C80  bl       #0x382bd14 ; 
0068C6C84  mov      w8, #1
0068C6C88  strb     w8, [x21, #0x6ef]
0068C6C8C  adrp     x8, #0x8f27000
0068C6C90  ldr      x8, [x8, #0xf40]
0068C6C94  ldr      x2, [x8]
0068C6C98  ldrb     w8, [x2, #0x53]
0068C6C9C  tbnz     w8, #5, #0x68c6ca8
0068C6CA0  str      w20, [x19, #0x58]
0068C6CA4  b        #0x68c6cb8 ; 
0068C6CA8  ldr      x8, [x2, #0x60]
0068C6CAC  mov      x0, x19
0068C6CB0  mov      w1, w20
0068C6CB4  blr      x8
0068C6CB8  mov      x0, x19
0068C6CBC  mov      x1, xzr
0068C6CC0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
0068C6CC4  adrp     x21, #0x959c000
0068C6CC8  ldrb     w8, [x21, #0x6f0]
0068C6CCC  mov      x20, x0
0068C6CD0  cbnz     w8, #0x68c6ce8
0068C6CD4  adrp     x0, #0x8f27000
0068C6CD8  ldr      x0, [x0, #0xf50]
0068C6CDC  bl       #0x382bd14 ; 
0068C6CE0  mov      w8, #1
0068C6CE4  strb     w8, [x21, #0x6f0]
0068C6CE8  adrp     x8, #0x8f27000
0068C6CEC  ldr      x8, [x8, #0xf50]
0068C6CF0  ldr      x2, [x8]
0068C6CF4  ldrb     w8, [x2, #0x53]
0068C6CF8  tbnz     w8, #5, #0x68c6d10
0068C6CFC  mov      x0, x19
0068C6D00  str      x20, [x0, #0x60]!
0068C6D04  mov      x1, x20
0068C6D08  bl       #0x382bcb8 ; 
0068C6D0C  b        #0x68c6d20 ; 
0068C6D10  ldr      x8, [x2, #0x60]
0068C6D14  mov      x0, x19
0068C6D18  mov      x1, x20
0068C6D1C  blr      x8
0068C6D20  mov      x0, x19
0068C6D24  mov      x1, xzr
0068C6D28  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C6D2C  adrp     x21, #0x959c000
0068C6D30  ldrb     w8, [x21, #0x6f1]
0068C6D34  mov      x20, x0
0068C6D38  cbnz     w8, #0x68c6d50
0068C6D3C  adrp     x0, #0x8f27000
0068C6D40  ldr      x0, [x0, #0xf60]
0068C6D44  bl       #0x382bd14 ; 
0068C6D48  mov      w8, #1
0068C6D4C  strb     w8, [x21, #0x6f1]
0068C6D50  adrp     x8, #0x8f27000
0068C6D54  ldr      x8, [x8, #0xf60]
0068C6D58  ldr      x2, [x8]
0068C6D5C  ldrb     w8, [x2, #0x53]
0068C6D60  tbnz     w8, #5, #0x68c6d78
0068C6D64  mov      x0, x19
0068C6D68  str      x20, [x0, #0x68]!
0068C6D6C  mov      x1, x20
0068C6D70  bl       #0x382bcb8 ; 
0068C6D74  b        #0x68c6d88 ; 
0068C6D78  ldr      x8, [x2, #0x60]
0068C6D7C  mov      x0, x19
0068C6D80  mov      x1, x20
0068C6D84  blr      x8
0068C6D88  mov      x0, x19
0068C6D8C  mov      x1, xzr
0068C6D90  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C6D94  adrp     x21, #0x959c000
0068C6D98  ldrb     w8, [x21, #0x6f2]
0068C6D9C  mov      x20, x0
0068C6DA0  cbnz     w8, #0x68c6db8
0068C6DA4  adrp     x0, #0x8f27000
0068C6DA8  ldr      x0, [x0, #0xf70]
0068C6DAC  bl       #0x382bd14 ; 
0068C6DB0  mov      w8, #1
0068C6DB4  strb     w8, [x21, #0x6f2]
0068C6DB8  adrp     x8, #0x8f27000
0068C6DBC  ldr      x8, [x8, #0xf70]
0068C6DC0  ldr      x2, [x8]
0068C6DC4  ldrb     w8, [x2, #0x53]
0068C6DC8  tbnz     w8, #5, #0x68c6de0
0068C6DCC  mov      x0, x19
0068C6DD0  str      x20, [x0, #0x70]!
0068C6DD4  mov      x1, x20
0068C6DD8  bl       #0x382bcb8 ; 
0068C6DDC  b        #0x68c6df0 ; 
0068C6DE0  ldr      x8, [x2, #0x60]
0068C6DE4  mov      x0, x19
0068C6DE8  mov      x1, x20
0068C6DEC  blr      x8
0068C6DF0  mov      x0, x19
0068C6DF4  mov      x1, xzr
0068C6DF8  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
0068C6DFC  adrp     x21, #0x959c000
0068C6E00  ldrb     w8, [x21, #0x6f3]
0068C6E04  mov      x20, x0
0068C6E08  cbnz     w8, #0x68c6e20
0068C6E0C  adrp     x0, #0x8f27000
0068C6E10  ldr      x0, [x0, #0xf80]
0068C6E14  bl       #0x382bd14 ; 
0068C6E18  mov      w8, #1
0068C6E1C  strb     w8, [x21, #0x6f3]
0068C6E20  adrp     x8, #0x8f27000
0068C6E24  ldr      x8, [x8, #0xf80]
0068C6E28  ldr      x2, [x8]
0068C6E2C  ldrb     w8, [x2, #0x53]
0068C6E30  tbnz     w8, #5, #0x68c6e3c
0068C6E34  str      x20, [x19, #0x78]
0068C6E38  b        #0x68c6e4c ; 
0068C6E3C  ldr      x8, [x2, #0x60]
0068C6E40  mov      x0, x19
0068C6E44  mov      x1, x20
0068C6E48  blr      x8
0068C6E4C  mov      x0, x19
0068C6E50  mov      x1, xzr
0068C6E54  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C6E58  adrp     x21, #0x959c000
0068C6E5C  ldrb     w8, [x21, #0x6f4]
0068C6E60  mov      w20, w0
0068C6E64  cbnz     w8, #0x68c6e7c
0068C6E68  adrp     x0, #0x8f27000
0068C6E6C  ldr      x0, [x0, #0xf90]
0068C6E70  bl       #0x382bd14 ; 
0068C6E74  mov      w8, #1
0068C6E78  strb     w8, [x21, #0x6f4]
0068C6E7C  adrp     x8, #0x8f27000
0068C6E80  ldr      x8, [x8, #0xf90]
0068C6E84  ldr      x2, [x8]
0068C6E88  ldrb     w8, [x2, #0x53]
0068C6E8C  tbnz     w8, #5, #0x68c6e98
0068C6E90  str      w20, [x19, #0x80]
0068C6E94  b        #0x68c6ea8 ; 
0068C6E98  ldr      x8, [x2, #0x60]
0068C6E9C  mov      x0, x19
0068C6EA0  mov      w1, w20
0068C6EA4  blr      x8
0068C6EA8  ldp      x20, x19, [sp, #0x10]
0068C6EAC  mov      w0, #1
0068C6EB0  ldp      x30, x21, [sp], #0x20
0068C6EB4  ret      

