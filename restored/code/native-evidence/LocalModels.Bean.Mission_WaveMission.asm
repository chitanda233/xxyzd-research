; LocalModels.Bean.Mission_WaveMission$$readImpl
; RVA 0x6AC7864; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC7864  stp      x30, x21, [sp, #-0x20]!
006AC7868  stp      x20, x19, [sp, #0x10]
006AC786C  adrp     x20, #0x959e000
006AC7870  adrp     x21, #0x8f3b000
006AC7874  ldrb     w8, [x20, #0xa29]
006AC7878  ldr      x21, [x21, #0x7b0]
006AC787C  mov      x19, x0
006AC7880  tbnz     w8, #0, #0x6ac7898
006AC7884  adrp     x0, #0x8f3b000
006AC7888  ldr      x0, [x0, #0x7b0]
006AC788C  bl       #0x382bd14 ; 
006AC7890  mov      w8, #1
006AC7894  strb     w8, [x20, #0xa29]
006AC7898  ldr      x1, [x21]
006AC789C  ldrb     w8, [x1, #0x53]
006AC78A0  tbnz     w8, #5, #0x6ac78f0
006AC78A4  mov      x0, x19
006AC78A8  mov      x1, xzr
006AC78AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC78B0  adrp     x21, #0x959f000
006AC78B4  ldrb     w8, [x21, #0x7a]
006AC78B8  mov      w20, w0
006AC78BC  cbnz     w8, #0x6ac78d4
006AC78C0  adrp     x0, #0x8f3b000
006AC78C4  ldr      x0, [x0, #0x708]
006AC78C8  bl       #0x382bd14 ; 
006AC78CC  mov      w8, #1
006AC78D0  strb     w8, [x21, #0x7a]
006AC78D4  adrp     x8, #0x8f3b000
006AC78D8  ldr      x8, [x8, #0x708]
006AC78DC  ldr      x2, [x8]
006AC78E0  ldrb     w8, [x2, #0x53]
006AC78E4  tbnz     w8, #5, #0x6ac7904
006AC78E8  str      w20, [x19, #0x20]
006AC78EC  b        #0x6ac7914 ; 
006AC78F0  ldr      x2, [x1, #0x60]
006AC78F4  mov      x0, x19
006AC78F8  ldp      x20, x19, [sp, #0x10]
006AC78FC  ldp      x30, x21, [sp], #0x20
006AC7900  br       x2
006AC7904  ldr      x8, [x2, #0x60]
006AC7908  mov      x0, x19
006AC790C  mov      w1, w20
006AC7910  blr      x8
006AC7914  mov      x0, x19
006AC7918  mov      x1, xzr
006AC791C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC7920  adrp     x21, #0x959f000
006AC7924  ldrb     w8, [x21, #0x7b]
006AC7928  mov      w20, w0
006AC792C  cbnz     w8, #0x6ac7944
006AC7930  adrp     x0, #0x8f3b000
006AC7934  ldr      x0, [x0, #0x718]
006AC7938  bl       #0x382bd14 ; 
006AC793C  mov      w8, #1
006AC7940  strb     w8, [x21, #0x7b]
006AC7944  adrp     x8, #0x8f3b000
006AC7948  ldr      x8, [x8, #0x718]
006AC794C  ldr      x2, [x8]
006AC7950  ldrb     w8, [x2, #0x53]
006AC7954  tbnz     w8, #5, #0x6ac7960
006AC7958  str      w20, [x19, #0x24]
006AC795C  b        #0x6ac7970 ; 
006AC7960  ldr      x8, [x2, #0x60]
006AC7964  mov      x0, x19
006AC7968  mov      w1, w20
006AC796C  blr      x8
006AC7970  mov      x0, x19
006AC7974  mov      x1, xzr
006AC7978  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC797C  adrp     x21, #0x959f000
006AC7980  ldrb     w8, [x21, #0x7c]
006AC7984  mov      w20, w0
006AC7988  cbnz     w8, #0x6ac79a0
006AC798C  adrp     x0, #0x8f3b000
006AC7990  ldr      x0, [x0, #0x728]
006AC7994  bl       #0x382bd14 ; 
006AC7998  mov      w8, #1
006AC799C  strb     w8, [x21, #0x7c]
006AC79A0  adrp     x8, #0x8f3b000
006AC79A4  ldr      x8, [x8, #0x728]
006AC79A8  ldr      x2, [x8]
006AC79AC  ldrb     w8, [x2, #0x53]
006AC79B0  tbnz     w8, #5, #0x6ac79bc
006AC79B4  str      w20, [x19, #0x28]
006AC79B8  b        #0x6ac79cc ; 
006AC79BC  ldr      x8, [x2, #0x60]
006AC79C0  mov      x0, x19
006AC79C4  mov      w1, w20
006AC79C8  blr      x8
006AC79CC  mov      x0, x19
006AC79D0  mov      x1, xzr
006AC79D4  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AC79D8  adrp     x21, #0x959f000
006AC79DC  ldrb     w8, [x21, #0x7d]
006AC79E0  mov      x20, x0
006AC79E4  cbnz     w8, #0x6ac79fc
006AC79E8  adrp     x0, #0x8f3b000
006AC79EC  ldr      x0, [x0, #0x738]
006AC79F0  bl       #0x382bd14 ; 
006AC79F4  mov      w8, #1
006AC79F8  strb     w8, [x21, #0x7d]
006AC79FC  adrp     x8, #0x8f3b000
006AC7A00  ldr      x8, [x8, #0x738]
006AC7A04  ldr      x2, [x8]
006AC7A08  ldrb     w8, [x2, #0x53]
006AC7A0C  tbnz     w8, #5, #0x6ac7a24
006AC7A10  mov      x0, x19
006AC7A14  str      x20, [x0, #0x30]!
006AC7A18  mov      x1, x20
006AC7A1C  bl       #0x382bcb8 ; 
006AC7A20  b        #0x6ac7a34 ; 
006AC7A24  ldr      x8, [x2, #0x60]
006AC7A28  mov      x0, x19
006AC7A2C  mov      x1, x20
006AC7A30  blr      x8
006AC7A34  mov      x0, x19
006AC7A38  mov      x1, xzr
006AC7A3C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AC7A40  adrp     x21, #0x959f000
006AC7A44  ldrb     w8, [x21, #0x7e]
006AC7A48  mov      x20, x0
006AC7A4C  cbnz     w8, #0x6ac7a64
006AC7A50  adrp     x0, #0x8f3b000
006AC7A54  ldr      x0, [x0, #0x748]
006AC7A58  bl       #0x382bd14 ; 
006AC7A5C  mov      w8, #1
006AC7A60  strb     w8, [x21, #0x7e]
006AC7A64  adrp     x8, #0x8f3b000
006AC7A68  ldr      x8, [x8, #0x748]
006AC7A6C  ldr      x2, [x8]
006AC7A70  ldrb     w8, [x2, #0x53]
006AC7A74  tbnz     w8, #5, #0x6ac7a8c
006AC7A78  mov      x0, x19
006AC7A7C  str      x20, [x0, #0x38]!
006AC7A80  mov      x1, x20
006AC7A84  bl       #0x382bcb8 ; 
006AC7A88  b        #0x6ac7a9c ; 
006AC7A8C  ldr      x8, [x2, #0x60]
006AC7A90  mov      x0, x19
006AC7A94  mov      x1, x20
006AC7A98  blr      x8
006AC7A9C  mov      x0, x19
006AC7AA0  mov      x1, xzr
006AC7AA4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC7AA8  adrp     x21, #0x959f000
006AC7AAC  ldrb     w8, [x21, #0x7f]
006AC7AB0  mov      x20, x0
006AC7AB4  cbnz     w8, #0x6ac7acc
006AC7AB8  adrp     x0, #0x8f3b000
006AC7ABC  ldr      x0, [x0, #0x758]
006AC7AC0  bl       #0x382bd14 ; 
006AC7AC4  mov      w8, #1
006AC7AC8  strb     w8, [x21, #0x7f]
006AC7ACC  adrp     x8, #0x8f3b000
006AC7AD0  ldr      x8, [x8, #0x758]
006AC7AD4  ldr      x2, [x8]
006AC7AD8  ldrb     w8, [x2, #0x53]
006AC7ADC  tbnz     w8, #5, #0x6ac7ae8
006AC7AE0  str      x20, [x19, #0x40]
006AC7AE4  b        #0x6ac7af8 ; 
006AC7AE8  ldr      x8, [x2, #0x60]
006AC7AEC  mov      x0, x19
006AC7AF0  mov      x1, x20
006AC7AF4  blr      x8
006AC7AF8  mov      x0, x19
006AC7AFC  mov      x1, xzr
006AC7B00  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC7B04  adrp     x21, #0x959f000
006AC7B08  ldrb     w8, [x21, #0x80]
006AC7B0C  mov      w20, w0
006AC7B10  cbnz     w8, #0x6ac7b28
006AC7B14  adrp     x0, #0x8f3b000
006AC7B18  ldr      x0, [x0, #0x768]
006AC7B1C  bl       #0x382bd14 ; 
006AC7B20  mov      w8, #1
006AC7B24  strb     w8, [x21, #0x80]
006AC7B28  adrp     x8, #0x8f3b000
006AC7B2C  ldr      x8, [x8, #0x768]
006AC7B30  ldr      x2, [x8]
006AC7B34  ldrb     w8, [x2, #0x53]
006AC7B38  tbnz     w8, #5, #0x6ac7b44
006AC7B3C  str      w20, [x19, #0x48]
006AC7B40  b        #0x6ac7b54 ; 
006AC7B44  ldr      x8, [x2, #0x60]
006AC7B48  mov      x0, x19
006AC7B4C  mov      w1, w20
006AC7B50  blr      x8
006AC7B54  mov      x0, x19
006AC7B58  mov      x1, xzr
006AC7B5C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC7B60  adrp     x21, #0x959f000
006AC7B64  ldrb     w8, [x21, #0x81]
006AC7B68  mov      w20, w0
006AC7B6C  cbnz     w8, #0x6ac7b84
006AC7B70  adrp     x0, #0x8f3b000
006AC7B74  ldr      x0, [x0, #0x778]
006AC7B78  bl       #0x382bd14 ; 
006AC7B7C  mov      w8, #1
006AC7B80  strb     w8, [x21, #0x81]
006AC7B84  adrp     x8, #0x8f3b000
006AC7B88  ldr      x8, [x8, #0x778]
006AC7B8C  ldr      x2, [x8]
006AC7B90  ldrb     w8, [x2, #0x53]
006AC7B94  tbnz     w8, #5, #0x6ac7ba0
006AC7B98  str      w20, [x19, #0x4c]
006AC7B9C  b        #0x6ac7bb0 ; 
006AC7BA0  ldr      x8, [x2, #0x60]
006AC7BA4  mov      x0, x19
006AC7BA8  mov      w1, w20
006AC7BAC  blr      x8
006AC7BB0  mov      x0, x19
006AC7BB4  mov      x1, xzr
006AC7BB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC7BBC  adrp     x21, #0x959f000
006AC7BC0  ldrb     w8, [x21, #0x82]
006AC7BC4  mov      w20, w0
006AC7BC8  cbnz     w8, #0x6ac7be0
006AC7BCC  adrp     x0, #0x8f3b000
006AC7BD0  ldr      x0, [x0, #0x788]
006AC7BD4  bl       #0x382bd14 ; 
006AC7BD8  mov      w8, #1
006AC7BDC  strb     w8, [x21, #0x82]
006AC7BE0  adrp     x8, #0x8f3b000
006AC7BE4  ldr      x8, [x8, #0x788]
006AC7BE8  ldr      x2, [x8]
006AC7BEC  ldrb     w8, [x2, #0x53]
006AC7BF0  tbnz     w8, #5, #0x6ac7bfc
006AC7BF4  str      w20, [x19, #0x50]
006AC7BF8  b        #0x6ac7c0c ; 
006AC7BFC  ldr      x8, [x2, #0x60]
006AC7C00  mov      x0, x19
006AC7C04  mov      w1, w20
006AC7C08  blr      x8
006AC7C0C  mov      x0, x19
006AC7C10  mov      x1, xzr
006AC7C14  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC7C18  adrp     x21, #0x959f000
006AC7C1C  ldrb     w8, [x21, #0x83]
006AC7C20  mov      x20, x0
006AC7C24  cbnz     w8, #0x6ac7c3c
006AC7C28  adrp     x0, #0x8f3b000
006AC7C2C  ldr      x0, [x0, #0x798]
006AC7C30  bl       #0x382bd14 ; 
006AC7C34  mov      w8, #1
006AC7C38  strb     w8, [x21, #0x83]
006AC7C3C  adrp     x8, #0x8f3b000
006AC7C40  ldr      x8, [x8, #0x798]
006AC7C44  ldr      x2, [x8]
006AC7C48  ldrb     w8, [x2, #0x53]
006AC7C4C  tbnz     w8, #5, #0x6ac7c58
006AC7C50  str      x20, [x19, #0x58]
006AC7C54  b        #0x6ac7c68 ; 
006AC7C58  ldr      x8, [x2, #0x60]
006AC7C5C  mov      x0, x19
006AC7C60  mov      x1, x20
006AC7C64  blr      x8
006AC7C68  mov      x0, x19
006AC7C6C  mov      x1, xzr
006AC7C70  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006AC7C74  adrp     x21, #0x959f000
006AC7C78  ldrb     w8, [x21, #0x84]
006AC7C7C  mov      x20, x0
006AC7C80  cbnz     w8, #0x6ac7c98
006AC7C84  adrp     x0, #0x8f3b000
006AC7C88  ldr      x0, [x0, #0x7a8]
006AC7C8C  bl       #0x382bd14 ; 
006AC7C90  mov      w8, #1
006AC7C94  strb     w8, [x21, #0x84]
006AC7C98  adrp     x8, #0x8f3b000
006AC7C9C  ldr      x8, [x8, #0x7a8]
006AC7CA0  ldr      x2, [x8]
006AC7CA4  ldrb     w8, [x2, #0x53]
006AC7CA8  tbnz     w8, #5, #0x6ac7cb4
006AC7CAC  str      x20, [x19, #0x60]
006AC7CB0  b        #0x6ac7cc4 ; 
006AC7CB4  ldr      x8, [x2, #0x60]
006AC7CB8  mov      x0, x19
006AC7CBC  mov      x1, x20
006AC7CC0  blr      x8
006AC7CC4  ldp      x20, x19, [sp, #0x10]
006AC7CC8  mov      w0, #1
006AC7CCC  ldp      x30, x21, [sp], #0x20
006AC7CD0  ret      

