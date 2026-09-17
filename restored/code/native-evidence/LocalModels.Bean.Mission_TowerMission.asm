; LocalModels.Bean.Mission_TowerMission$$readImpl
; RVA 0x6AC6898; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC6898  stp      x30, x21, [sp, #-0x20]!
006AC689C  stp      x20, x19, [sp, #0x10]
006AC68A0  adrp     x20, #0x959e000
006AC68A4  adrp     x21, #0x8f3b000
006AC68A8  ldrb     w8, [x20, #0xa10]
006AC68AC  ldr      x21, [x21, #0x6f0]
006AC68B0  mov      x19, x0
006AC68B4  tbnz     w8, #0, #0x6ac68cc
006AC68B8  adrp     x0, #0x8f3b000
006AC68BC  ldr      x0, [x0, #0x6f0]
006AC68C0  bl       #0x382bd14 ; 
006AC68C4  mov      w8, #1
006AC68C8  strb     w8, [x20, #0xa10]
006AC68CC  ldr      x1, [x21]
006AC68D0  ldrb     w8, [x1, #0x53]
006AC68D4  tbnz     w8, #5, #0x6ac6924
006AC68D8  mov      x0, x19
006AC68DC  mov      x1, xzr
006AC68E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC68E4  adrp     x21, #0x959f000
006AC68E8  ldrb     w8, [x21, #0x6d]
006AC68EC  mov      w20, w0
006AC68F0  cbnz     w8, #0x6ac6908
006AC68F4  adrp     x0, #0x8f3b000
006AC68F8  ldr      x0, [x0, #0x628]
006AC68FC  bl       #0x382bd14 ; 
006AC6900  mov      w8, #1
006AC6904  strb     w8, [x21, #0x6d]
006AC6908  adrp     x8, #0x8f3b000
006AC690C  ldr      x8, [x8, #0x628]
006AC6910  ldr      x2, [x8]
006AC6914  ldrb     w8, [x2, #0x53]
006AC6918  tbnz     w8, #5, #0x6ac6938
006AC691C  str      w20, [x19, #0x20]
006AC6920  b        #0x6ac6948 ; 
006AC6924  ldr      x2, [x1, #0x60]
006AC6928  mov      x0, x19
006AC692C  ldp      x20, x19, [sp, #0x10]
006AC6930  ldp      x30, x21, [sp], #0x20
006AC6934  br       x2
006AC6938  ldr      x8, [x2, #0x60]
006AC693C  mov      x0, x19
006AC6940  mov      w1, w20
006AC6944  blr      x8
006AC6948  mov      x0, x19
006AC694C  mov      x1, xzr
006AC6950  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC6954  adrp     x21, #0x959f000
006AC6958  ldrb     w8, [x21, #0x6e]
006AC695C  mov      w20, w0
006AC6960  cbnz     w8, #0x6ac6978
006AC6964  adrp     x0, #0x8f3b000
006AC6968  ldr      x0, [x0, #0x638]
006AC696C  bl       #0x382bd14 ; 
006AC6970  mov      w8, #1
006AC6974  strb     w8, [x21, #0x6e]
006AC6978  adrp     x8, #0x8f3b000
006AC697C  ldr      x8, [x8, #0x638]
006AC6980  ldr      x2, [x8]
006AC6984  ldrb     w8, [x2, #0x53]
006AC6988  tbnz     w8, #5, #0x6ac6994
006AC698C  str      w20, [x19, #0x24]
006AC6990  b        #0x6ac69a4 ; 
006AC6994  ldr      x8, [x2, #0x60]
006AC6998  mov      x0, x19
006AC699C  mov      w1, w20
006AC69A0  blr      x8
006AC69A4  mov      x0, x19
006AC69A8  mov      x1, xzr
006AC69AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC69B0  adrp     x21, #0x959f000
006AC69B4  ldrb     w8, [x21, #0x6f]
006AC69B8  mov      w20, w0
006AC69BC  cbnz     w8, #0x6ac69d4
006AC69C0  adrp     x0, #0x8f3b000
006AC69C4  ldr      x0, [x0, #0x648]
006AC69C8  bl       #0x382bd14 ; 
006AC69CC  mov      w8, #1
006AC69D0  strb     w8, [x21, #0x6f]
006AC69D4  adrp     x8, #0x8f3b000
006AC69D8  ldr      x8, [x8, #0x648]
006AC69DC  ldr      x2, [x8]
006AC69E0  ldrb     w8, [x2, #0x53]
006AC69E4  tbnz     w8, #5, #0x6ac69f0
006AC69E8  str      w20, [x19, #0x28]
006AC69EC  b        #0x6ac6a00 ; 
006AC69F0  ldr      x8, [x2, #0x60]
006AC69F4  mov      x0, x19
006AC69F8  mov      w1, w20
006AC69FC  blr      x8
006AC6A00  mov      x0, x19
006AC6A04  mov      x1, xzr
006AC6A08  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AC6A0C  adrp     x21, #0x959f000
006AC6A10  ldrb     w8, [x21, #0x70]
006AC6A14  mov      x20, x0
006AC6A18  cbnz     w8, #0x6ac6a30
006AC6A1C  adrp     x0, #0x8f3b000
006AC6A20  ldr      x0, [x0, #0x658]
006AC6A24  bl       #0x382bd14 ; 
006AC6A28  mov      w8, #1
006AC6A2C  strb     w8, [x21, #0x70]
006AC6A30  adrp     x8, #0x8f3b000
006AC6A34  ldr      x8, [x8, #0x658]
006AC6A38  ldr      x2, [x8]
006AC6A3C  ldrb     w8, [x2, #0x53]
006AC6A40  tbnz     w8, #5, #0x6ac6a58
006AC6A44  mov      x0, x19
006AC6A48  str      x20, [x0, #0x30]!
006AC6A4C  mov      x1, x20
006AC6A50  bl       #0x382bcb8 ; 
006AC6A54  b        #0x6ac6a68 ; 
006AC6A58  ldr      x8, [x2, #0x60]
006AC6A5C  mov      x0, x19
006AC6A60  mov      x1, x20
006AC6A64  blr      x8
006AC6A68  mov      x0, x19
006AC6A6C  mov      x1, xzr
006AC6A70  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC6A74  adrp     x21, #0x959f000
006AC6A78  ldrb     w8, [x21, #0x71]
006AC6A7C  mov      x20, x0
006AC6A80  cbnz     w8, #0x6ac6a98
006AC6A84  adrp     x0, #0x8f3b000
006AC6A88  ldr      x0, [x0, #0x668]
006AC6A8C  bl       #0x382bd14 ; 
006AC6A90  mov      w8, #1
006AC6A94  strb     w8, [x21, #0x71]
006AC6A98  adrp     x8, #0x8f3b000
006AC6A9C  ldr      x8, [x8, #0x668]
006AC6AA0  ldr      x2, [x8]
006AC6AA4  ldrb     w8, [x2, #0x53]
006AC6AA8  tbnz     w8, #5, #0x6ac6ab4
006AC6AAC  str      x20, [x19, #0x38]
006AC6AB0  b        #0x6ac6ac4 ; 
006AC6AB4  ldr      x8, [x2, #0x60]
006AC6AB8  mov      x0, x19
006AC6ABC  mov      x1, x20
006AC6AC0  blr      x8
006AC6AC4  mov      x0, x19
006AC6AC8  mov      x1, xzr
006AC6ACC  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC6AD0  adrp     x21, #0x959f000
006AC6AD4  ldrb     w8, [x21, #0x72]
006AC6AD8  mov      x20, x0
006AC6ADC  cbnz     w8, #0x6ac6af4
006AC6AE0  adrp     x0, #0x8f3b000
006AC6AE4  ldr      x0, [x0, #0x678]
006AC6AE8  bl       #0x382bd14 ; 
006AC6AEC  mov      w8, #1
006AC6AF0  strb     w8, [x21, #0x72]
006AC6AF4  adrp     x8, #0x8f3b000
006AC6AF8  ldr      x8, [x8, #0x678]
006AC6AFC  ldr      x2, [x8]
006AC6B00  ldrb     w8, [x2, #0x53]
006AC6B04  tbnz     w8, #5, #0x6ac6b10
006AC6B08  str      x20, [x19, #0x40]
006AC6B0C  b        #0x6ac6b20 ; 
006AC6B10  ldr      x8, [x2, #0x60]
006AC6B14  mov      x0, x19
006AC6B18  mov      x1, x20
006AC6B1C  blr      x8
006AC6B20  mov      x0, x19
006AC6B24  mov      x1, xzr
006AC6B28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC6B2C  adrp     x21, #0x959f000
006AC6B30  ldrb     w8, [x21, #0x73]
006AC6B34  mov      w20, w0
006AC6B38  cbnz     w8, #0x6ac6b50
006AC6B3C  adrp     x0, #0x8f3b000
006AC6B40  ldr      x0, [x0, #0x688]
006AC6B44  bl       #0x382bd14 ; 
006AC6B48  mov      w8, #1
006AC6B4C  strb     w8, [x21, #0x73]
006AC6B50  adrp     x8, #0x8f3b000
006AC6B54  ldr      x8, [x8, #0x688]
006AC6B58  ldr      x2, [x8]
006AC6B5C  ldrb     w8, [x2, #0x53]
006AC6B60  tbnz     w8, #5, #0x6ac6b6c
006AC6B64  str      w20, [x19, #0x48]
006AC6B68  b        #0x6ac6b7c ; 
006AC6B6C  ldr      x8, [x2, #0x60]
006AC6B70  mov      x0, x19
006AC6B74  mov      w1, w20
006AC6B78  blr      x8
006AC6B7C  mov      x0, x19
006AC6B80  mov      x1, xzr
006AC6B84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC6B88  adrp     x21, #0x959f000
006AC6B8C  ldrb     w8, [x21, #0x74]
006AC6B90  mov      w20, w0
006AC6B94  cbnz     w8, #0x6ac6bac
006AC6B98  adrp     x0, #0x8f3b000
006AC6B9C  ldr      x0, [x0, #0x698]
006AC6BA0  bl       #0x382bd14 ; 
006AC6BA4  mov      w8, #1
006AC6BA8  strb     w8, [x21, #0x74]
006AC6BAC  adrp     x8, #0x8f3b000
006AC6BB0  ldr      x8, [x8, #0x698]
006AC6BB4  ldr      x2, [x8]
006AC6BB8  ldrb     w8, [x2, #0x53]
006AC6BBC  tbnz     w8, #5, #0x6ac6bc8
006AC6BC0  str      w20, [x19, #0x4c]
006AC6BC4  b        #0x6ac6bd8 ; 
006AC6BC8  ldr      x8, [x2, #0x60]
006AC6BCC  mov      x0, x19
006AC6BD0  mov      w1, w20
006AC6BD4  blr      x8
006AC6BD8  mov      x0, x19
006AC6BDC  mov      x1, xzr
006AC6BE0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC6BE4  adrp     x21, #0x959f000
006AC6BE8  ldrb     w8, [x21, #0x75]
006AC6BEC  mov      w20, w0
006AC6BF0  cbnz     w8, #0x6ac6c08
006AC6BF4  adrp     x0, #0x8f3b000
006AC6BF8  ldr      x0, [x0, #0x6a8]
006AC6BFC  bl       #0x382bd14 ; 
006AC6C00  mov      w8, #1
006AC6C04  strb     w8, [x21, #0x75]
006AC6C08  adrp     x8, #0x8f3b000
006AC6C0C  ldr      x8, [x8, #0x6a8]
006AC6C10  ldr      x2, [x8]
006AC6C14  ldrb     w8, [x2, #0x53]
006AC6C18  tbnz     w8, #5, #0x6ac6c24
006AC6C1C  str      w20, [x19, #0x50]
006AC6C20  b        #0x6ac6c34 ; 
006AC6C24  ldr      x8, [x2, #0x60]
006AC6C28  mov      x0, x19
006AC6C2C  mov      w1, w20
006AC6C30  blr      x8
006AC6C34  mov      x0, x19
006AC6C38  mov      x1, xzr
006AC6C3C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC6C40  adrp     x21, #0x959f000
006AC6C44  ldrb     w8, [x21, #0x76]
006AC6C48  mov      x20, x0
006AC6C4C  cbnz     w8, #0x6ac6c64
006AC6C50  adrp     x0, #0x8f3b000
006AC6C54  ldr      x0, [x0, #0x6b8]
006AC6C58  bl       #0x382bd14 ; 
006AC6C5C  mov      w8, #1
006AC6C60  strb     w8, [x21, #0x76]
006AC6C64  adrp     x8, #0x8f3b000
006AC6C68  ldr      x8, [x8, #0x6b8]
006AC6C6C  ldr      x2, [x8]
006AC6C70  ldrb     w8, [x2, #0x53]
006AC6C74  tbnz     w8, #5, #0x6ac6c80
006AC6C78  str      x20, [x19, #0x58]
006AC6C7C  b        #0x6ac6c90 ; 
006AC6C80  ldr      x8, [x2, #0x60]
006AC6C84  mov      x0, x19
006AC6C88  mov      x1, x20
006AC6C8C  blr      x8
006AC6C90  mov      x0, x19
006AC6C94  mov      x1, xzr
006AC6C98  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC6C9C  adrp     x21, #0x959f000
006AC6CA0  ldrb     w8, [x21, #0x77]
006AC6CA4  mov      x20, x0
006AC6CA8  cbnz     w8, #0x6ac6cc0
006AC6CAC  adrp     x0, #0x8f3b000
006AC6CB0  ldr      x0, [x0, #0x6c8]
006AC6CB4  bl       #0x382bd14 ; 
006AC6CB8  mov      w8, #1
006AC6CBC  strb     w8, [x21, #0x77]
006AC6CC0  adrp     x8, #0x8f3b000
006AC6CC4  ldr      x8, [x8, #0x6c8]
006AC6CC8  ldr      x2, [x8]
006AC6CCC  ldrb     w8, [x2, #0x53]
006AC6CD0  tbnz     w8, #5, #0x6ac6cdc
006AC6CD4  str      x20, [x19, #0x60]
006AC6CD8  b        #0x6ac6cec ; 
006AC6CDC  ldr      x8, [x2, #0x60]
006AC6CE0  mov      x0, x19
006AC6CE4  mov      x1, x20
006AC6CE8  blr      x8
006AC6CEC  mov      x0, x19
006AC6CF0  mov      x1, xzr
006AC6CF4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AC6CF8  adrp     x21, #0x959f000
006AC6CFC  ldrb     w8, [x21, #0x78]
006AC6D00  mov      x20, x0
006AC6D04  cbnz     w8, #0x6ac6d1c
006AC6D08  adrp     x0, #0x8f3b000
006AC6D0C  ldr      x0, [x0, #0x6d8]
006AC6D10  bl       #0x382bd14 ; 
006AC6D14  mov      w8, #1
006AC6D18  strb     w8, [x21, #0x78]
006AC6D1C  adrp     x8, #0x8f3b000
006AC6D20  ldr      x8, [x8, #0x6d8]
006AC6D24  ldr      x2, [x8]
006AC6D28  ldrb     w8, [x2, #0x53]
006AC6D2C  tbnz     w8, #5, #0x6ac6d44
006AC6D30  mov      x0, x19
006AC6D34  str      x20, [x0, #0x68]!
006AC6D38  mov      x1, x20
006AC6D3C  bl       #0x382bcb8 ; 
006AC6D40  b        #0x6ac6d54 ; 
006AC6D44  ldr      x8, [x2, #0x60]
006AC6D48  mov      x0, x19
006AC6D4C  mov      x1, x20
006AC6D50  blr      x8
006AC6D54  mov      x0, x19
006AC6D58  mov      x1, xzr
006AC6D5C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AC6D60  adrp     x21, #0x959f000
006AC6D64  ldrb     w8, [x21, #0x79]
006AC6D68  mov      x20, x0
006AC6D6C  cbnz     w8, #0x6ac6d84
006AC6D70  adrp     x0, #0x8f3b000
006AC6D74  ldr      x0, [x0, #0x6e8]
006AC6D78  bl       #0x382bd14 ; 
006AC6D7C  mov      w8, #1
006AC6D80  strb     w8, [x21, #0x79]
006AC6D84  adrp     x8, #0x8f3b000
006AC6D88  ldr      x8, [x8, #0x6e8]
006AC6D8C  ldr      x2, [x8]
006AC6D90  ldrb     w8, [x2, #0x53]
006AC6D94  tbnz     w8, #5, #0x6ac6dac
006AC6D98  str      x20, [x19, #0x70]!
006AC6D9C  mov      x0, x19
006AC6DA0  mov      x1, x20
006AC6DA4  bl       #0x382bcb8 ; 
006AC6DA8  b        #0x6ac6dbc ; 
006AC6DAC  ldr      x8, [x2, #0x60]
006AC6DB0  mov      x0, x19
006AC6DB4  mov      x1, x20
006AC6DB8  blr      x8
006AC6DBC  ldp      x20, x19, [sp, #0x10]
006AC6DC0  mov      w0, #1
006AC6DC4  ldp      x30, x21, [sp], #0x20
006AC6DC8  ret      

