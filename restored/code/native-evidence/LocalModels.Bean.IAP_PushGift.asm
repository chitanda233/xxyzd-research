; LocalModels.Bean.IAP_PushGift$$readImpl
; RVA 0x6AA7834; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA7834  stp      x30, x21, [sp, #-0x20]!
006AA7838  stp      x20, x19, [sp, #0x10]
006AA783C  adrp     x20, #0x959e000
006AA7840  adrp     x21, #0x8f39000
006AA7844  ldrb     w8, [x20, #0x6e4]
006AA7848  ldr      x21, [x21, #0xfe8]
006AA784C  mov      x19, x0
006AA7850  tbnz     w8, #0, #0x6aa7868
006AA7854  adrp     x0, #0x8f39000
006AA7858  ldr      x0, [x0, #0xfe8]
006AA785C  bl       #0x382bd14 ; 
006AA7860  mov      w8, #1
006AA7864  strb     w8, [x20, #0x6e4]
006AA7868  ldr      x1, [x21]
006AA786C  ldrb     w8, [x1, #0x53]
006AA7870  tbnz     w8, #5, #0x6aa78c0
006AA7874  mov      x0, x19
006AA7878  mov      x1, xzr
006AA787C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA7880  adrp     x21, #0x959e000
006AA7884  ldrb     w8, [x21, #0xf06]
006AA7888  mov      w20, w0
006AA788C  cbnz     w8, #0x6aa78a4
006AA7890  adrp     x0, #0x8f39000
006AA7894  ldr      x0, [x0, #0xf30]
006AA7898  bl       #0x382bd14 ; 
006AA789C  mov      w8, #1
006AA78A0  strb     w8, [x21, #0xf06]
006AA78A4  adrp     x8, #0x8f39000
006AA78A8  ldr      x8, [x8, #0xf30]
006AA78AC  ldr      x2, [x8]
006AA78B0  ldrb     w8, [x2, #0x53]
006AA78B4  tbnz     w8, #5, #0x6aa78d4
006AA78B8  str      w20, [x19, #0x20]
006AA78BC  b        #0x6aa78e4 ; 
006AA78C0  ldr      x2, [x1, #0x60]
006AA78C4  mov      x0, x19
006AA78C8  ldp      x20, x19, [sp, #0x10]
006AA78CC  ldp      x30, x21, [sp], #0x20
006AA78D0  br       x2
006AA78D4  ldr      x8, [x2, #0x60]
006AA78D8  mov      x0, x19
006AA78DC  mov      w1, w20
006AA78E0  blr      x8
006AA78E4  mov      x0, x19
006AA78E8  mov      x1, xzr
006AA78EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA78F0  adrp     x21, #0x959e000
006AA78F4  ldrb     w8, [x21, #0xf07]
006AA78F8  mov      w20, w0
006AA78FC  cbnz     w8, #0x6aa7914
006AA7900  adrp     x0, #0x8f39000
006AA7904  ldr      x0, [x0, #0xf40]
006AA7908  bl       #0x382bd14 ; 
006AA790C  mov      w8, #1
006AA7910  strb     w8, [x21, #0xf07]
006AA7914  adrp     x8, #0x8f39000
006AA7918  ldr      x8, [x8, #0xf40]
006AA791C  ldr      x2, [x8]
006AA7920  ldrb     w8, [x2, #0x53]
006AA7924  tbnz     w8, #5, #0x6aa7930
006AA7928  str      w20, [x19, #0x24]
006AA792C  b        #0x6aa7940 ; 
006AA7930  ldr      x8, [x2, #0x60]
006AA7934  mov      x0, x19
006AA7938  mov      w1, w20
006AA793C  blr      x8
006AA7940  mov      x0, x19
006AA7944  mov      x1, xzr
006AA7948  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA794C  adrp     x21, #0x959e000
006AA7950  ldrb     w8, [x21, #0xf08]
006AA7954  mov      w20, w0
006AA7958  cbnz     w8, #0x6aa7970
006AA795C  adrp     x0, #0x8f39000
006AA7960  ldr      x0, [x0, #0xf50]
006AA7964  bl       #0x382bd14 ; 
006AA7968  mov      w8, #1
006AA796C  strb     w8, [x21, #0xf08]
006AA7970  adrp     x8, #0x8f39000
006AA7974  ldr      x8, [x8, #0xf50]
006AA7978  ldr      x2, [x8]
006AA797C  ldrb     w8, [x2, #0x53]
006AA7980  tbnz     w8, #5, #0x6aa798c
006AA7984  str      w20, [x19, #0x28]
006AA7988  b        #0x6aa799c ; 
006AA798C  ldr      x8, [x2, #0x60]
006AA7990  mov      x0, x19
006AA7994  mov      w1, w20
006AA7998  blr      x8
006AA799C  mov      x0, x19
006AA79A0  mov      x1, xzr
006AA79A4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA79A8  adrp     x21, #0x959e000
006AA79AC  ldrb     w8, [x21, #0xf09]
006AA79B0  mov      w20, w0
006AA79B4  cbnz     w8, #0x6aa79cc
006AA79B8  adrp     x0, #0x8f39000
006AA79BC  ldr      x0, [x0, #0xf60]
006AA79C0  bl       #0x382bd14 ; 
006AA79C4  mov      w8, #1
006AA79C8  strb     w8, [x21, #0xf09]
006AA79CC  adrp     x8, #0x8f39000
006AA79D0  ldr      x8, [x8, #0xf60]
006AA79D4  ldr      x2, [x8]
006AA79D8  ldrb     w8, [x2, #0x53]
006AA79DC  tbnz     w8, #5, #0x6aa79e8
006AA79E0  str      w20, [x19, #0x2c]
006AA79E4  b        #0x6aa79f8 ; 
006AA79E8  ldr      x8, [x2, #0x60]
006AA79EC  mov      x0, x19
006AA79F0  mov      w1, w20
006AA79F4  blr      x8
006AA79F8  mov      x0, x19
006AA79FC  mov      x1, xzr
006AA7A00  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA7A04  adrp     x21, #0x959e000
006AA7A08  ldrb     w8, [x21, #0xf0a]
006AA7A0C  mov      x20, x0
006AA7A10  cbnz     w8, #0x6aa7a28
006AA7A14  adrp     x0, #0x8f39000
006AA7A18  ldr      x0, [x0, #0xf70]
006AA7A1C  bl       #0x382bd14 ; 
006AA7A20  mov      w8, #1
006AA7A24  strb     w8, [x21, #0xf0a]
006AA7A28  adrp     x8, #0x8f39000
006AA7A2C  ldr      x8, [x8, #0xf70]
006AA7A30  ldr      x2, [x8]
006AA7A34  ldrb     w8, [x2, #0x53]
006AA7A38  tbnz     w8, #5, #0x6aa7a50
006AA7A3C  mov      x0, x19
006AA7A40  str      x20, [x0, #0x30]!
006AA7A44  mov      x1, x20
006AA7A48  bl       #0x382bcb8 ; 
006AA7A4C  b        #0x6aa7a60 ; 
006AA7A50  ldr      x8, [x2, #0x60]
006AA7A54  mov      x0, x19
006AA7A58  mov      x1, x20
006AA7A5C  blr      x8
006AA7A60  mov      x0, x19
006AA7A64  mov      x1, xzr
006AA7A68  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA7A6C  adrp     x21, #0x959e000
006AA7A70  ldrb     w8, [x21, #0xf0b]
006AA7A74  mov      x20, x0
006AA7A78  cbnz     w8, #0x6aa7a90
006AA7A7C  adrp     x0, #0x8f39000
006AA7A80  ldr      x0, [x0, #0xf80]
006AA7A84  bl       #0x382bd14 ; 
006AA7A88  mov      w8, #1
006AA7A8C  strb     w8, [x21, #0xf0b]
006AA7A90  adrp     x8, #0x8f39000
006AA7A94  ldr      x8, [x8, #0xf80]
006AA7A98  ldr      x2, [x8]
006AA7A9C  ldrb     w8, [x2, #0x53]
006AA7AA0  tbnz     w8, #5, #0x6aa7ab8
006AA7AA4  mov      x0, x19
006AA7AA8  str      x20, [x0, #0x38]!
006AA7AAC  mov      x1, x20
006AA7AB0  bl       #0x382bcb8 ; 
006AA7AB4  b        #0x6aa7ac8 ; 
006AA7AB8  ldr      x8, [x2, #0x60]
006AA7ABC  mov      x0, x19
006AA7AC0  mov      x1, x20
006AA7AC4  blr      x8
006AA7AC8  mov      x0, x19
006AA7ACC  mov      x1, xzr
006AA7AD0  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006AA7AD4  adrp     x21, #0x959e000
006AA7AD8  ldrb     w8, [x21, #0xf0c]
006AA7ADC  mov      x20, x0
006AA7AE0  cbnz     w8, #0x6aa7af8
006AA7AE4  adrp     x0, #0x8f39000
006AA7AE8  ldr      x0, [x0, #0xf90]
006AA7AEC  bl       #0x382bd14 ; 
006AA7AF0  mov      w8, #1
006AA7AF4  strb     w8, [x21, #0xf0c]
006AA7AF8  adrp     x8, #0x8f39000
006AA7AFC  ldr      x8, [x8, #0xf90]
006AA7B00  ldr      x2, [x8]
006AA7B04  ldrb     w8, [x2, #0x53]
006AA7B08  tbnz     w8, #5, #0x6aa7b14
006AA7B0C  str      x20, [x19, #0x40]
006AA7B10  b        #0x6aa7b24 ; 
006AA7B14  ldr      x8, [x2, #0x60]
006AA7B18  mov      x0, x19
006AA7B1C  mov      x1, x20
006AA7B20  blr      x8
006AA7B24  mov      x0, x19
006AA7B28  mov      x1, xzr
006AA7B2C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA7B30  adrp     x21, #0x959e000
006AA7B34  ldrb     w8, [x21, #0xf0d]
006AA7B38  mov      w20, w0
006AA7B3C  cbnz     w8, #0x6aa7b54
006AA7B40  adrp     x0, #0x8f39000
006AA7B44  ldr      x0, [x0, #0xfa0]
006AA7B48  bl       #0x382bd14 ; 
006AA7B4C  mov      w8, #1
006AA7B50  strb     w8, [x21, #0xf0d]
006AA7B54  adrp     x8, #0x8f39000
006AA7B58  ldr      x8, [x8, #0xfa0]
006AA7B5C  ldr      x2, [x8]
006AA7B60  ldrb     w8, [x2, #0x53]
006AA7B64  tbnz     w8, #5, #0x6aa7b70
006AA7B68  str      w20, [x19, #0x48]
006AA7B6C  b        #0x6aa7b80 ; 
006AA7B70  ldr      x8, [x2, #0x60]
006AA7B74  mov      x0, x19
006AA7B78  mov      w1, w20
006AA7B7C  blr      x8
006AA7B80  mov      x0, x19
006AA7B84  mov      x1, xzr
006AA7B88  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AA7B8C  adrp     x21, #0x959e000
006AA7B90  ldrb     w8, [x21, #0xf0e]
006AA7B94  mov      x20, x0
006AA7B98  cbnz     w8, #0x6aa7bb0
006AA7B9C  adrp     x0, #0x8f39000
006AA7BA0  ldr      x0, [x0, #0xfb0]
006AA7BA4  bl       #0x382bd14 ; 
006AA7BA8  mov      w8, #1
006AA7BAC  strb     w8, [x21, #0xf0e]
006AA7BB0  adrp     x8, #0x8f39000
006AA7BB4  ldr      x8, [x8, #0xfb0]
006AA7BB8  ldr      x2, [x8]
006AA7BBC  ldrb     w8, [x2, #0x53]
006AA7BC0  tbnz     w8, #5, #0x6aa7bd8
006AA7BC4  mov      x0, x19
006AA7BC8  str      x20, [x0, #0x50]!
006AA7BCC  mov      x1, x20
006AA7BD0  bl       #0x382bcb8 ; 
006AA7BD4  b        #0x6aa7be8 ; 
006AA7BD8  ldr      x8, [x2, #0x60]
006AA7BDC  mov      x0, x19
006AA7BE0  mov      x1, x20
006AA7BE4  blr      x8
006AA7BE8  mov      x0, x19
006AA7BEC  mov      x1, xzr
006AA7BF0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA7BF4  adrp     x21, #0x959e000
006AA7BF8  ldrb     w8, [x21, #0xf0f]
006AA7BFC  mov      x20, x0
006AA7C00  cbnz     w8, #0x6aa7c18
006AA7C04  adrp     x0, #0x8f39000
006AA7C08  ldr      x0, [x0, #0xfc0]
006AA7C0C  bl       #0x382bd14 ; 
006AA7C10  mov      w8, #1
006AA7C14  strb     w8, [x21, #0xf0f]
006AA7C18  adrp     x8, #0x8f39000
006AA7C1C  ldr      x8, [x8, #0xfc0]
006AA7C20  ldr      x2, [x8]
006AA7C24  ldrb     w8, [x2, #0x53]
006AA7C28  tbnz     w8, #5, #0x6aa7c40
006AA7C2C  mov      x0, x19
006AA7C30  str      x20, [x0, #0x58]!
006AA7C34  mov      x1, x20
006AA7C38  bl       #0x382bcb8 ; 
006AA7C3C  b        #0x6aa7c50 ; 
006AA7C40  ldr      x8, [x2, #0x60]
006AA7C44  mov      x0, x19
006AA7C48  mov      x1, x20
006AA7C4C  blr      x8
006AA7C50  mov      x0, x19
006AA7C54  mov      x1, xzr
006AA7C58  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA7C5C  adrp     x21, #0x959e000
006AA7C60  ldrb     w8, [x21, #0xf10]
006AA7C64  mov      w20, w0
006AA7C68  cbnz     w8, #0x6aa7c80
006AA7C6C  adrp     x0, #0x8f39000
006AA7C70  ldr      x0, [x0, #0xfd0]
006AA7C74  bl       #0x382bd14 ; 
006AA7C78  mov      w8, #1
006AA7C7C  strb     w8, [x21, #0xf10]
006AA7C80  adrp     x8, #0x8f39000
006AA7C84  ldr      x8, [x8, #0xfd0]
006AA7C88  ldr      x2, [x8]
006AA7C8C  ldrb     w8, [x2, #0x53]
006AA7C90  tbnz     w8, #5, #0x6aa7c9c
006AA7C94  str      w20, [x19, #0x60]
006AA7C98  b        #0x6aa7cac ; 
006AA7C9C  ldr      x8, [x2, #0x60]
006AA7CA0  mov      x0, x19
006AA7CA4  mov      w1, w20
006AA7CA8  blr      x8
006AA7CAC  mov      x0, x19
006AA7CB0  mov      x1, xzr
006AA7CB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA7CB8  adrp     x21, #0x959e000
006AA7CBC  ldrb     w8, [x21, #0xf11]
006AA7CC0  mov      w20, w0
006AA7CC4  cbnz     w8, #0x6aa7cdc
006AA7CC8  adrp     x0, #0x8f39000
006AA7CCC  ldr      x0, [x0, #0xfe0]
006AA7CD0  bl       #0x382bd14 ; 
006AA7CD4  mov      w8, #1
006AA7CD8  strb     w8, [x21, #0xf11]
006AA7CDC  adrp     x8, #0x8f39000
006AA7CE0  ldr      x8, [x8, #0xfe0]
006AA7CE4  ldr      x2, [x8]
006AA7CE8  ldrb     w8, [x2, #0x53]
006AA7CEC  tbnz     w8, #5, #0x6aa7cf8
006AA7CF0  str      w20, [x19, #0x64]
006AA7CF4  b        #0x6aa7d08 ; 
006AA7CF8  ldr      x8, [x2, #0x60]
006AA7CFC  mov      x0, x19
006AA7D00  mov      w1, w20
006AA7D04  blr      x8
006AA7D08  ldp      x20, x19, [sp, #0x10]
006AA7D0C  mov      w0, #1
006AA7D10  ldp      x30, x21, [sp], #0x20
006AA7D14  ret      

