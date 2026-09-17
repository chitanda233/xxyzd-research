; LocalModels.Bean.AutoProcess_chapter$$readImpl
; RVA 0x67048CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067048CC  stp      x30, x21, [sp, #-0x20]!
0067048D0  stp      x20, x19, [sp, #0x10]
0067048D4  adrp     x20, #0x959a000
0067048D8  adrp     x21, #0x8f17000
0067048DC  ldrb     w8, [x20, #0x8fa]
0067048E0  ldr      x21, [x21, #0x9c0]
0067048E4  mov      x19, x0
0067048E8  tbnz     w8, #0, #0x6704900
0067048EC  adrp     x0, #0x8f17000
0067048F0  ldr      x0, [x0, #0x9c0]
0067048F4  bl       #0x382bd14 ; 
0067048F8  mov      w8, #1
0067048FC  strb     w8, [x20, #0x8fa]
006704900  ldr      x1, [x21]
006704904  ldrb     w8, [x1, #0x53]
006704908  tbnz     w8, #5, #0x6704958
00670490C  mov      x0, x19
006704910  mov      x1, xzr
006704914  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006704918  adrp     x21, #0x959a000
00670491C  ldrb     w8, [x21, #0x97c]
006704920  mov      w20, w0
006704924  cbnz     w8, #0x670493c
006704928  adrp     x0, #0x8f17000
00670492C  ldr      x0, [x0, #0x958]
006704930  bl       #0x382bd14 ; 
006704934  mov      w8, #1
006704938  strb     w8, [x21, #0x97c]
00670493C  adrp     x8, #0x8f17000
006704940  ldr      x8, [x8, #0x958]
006704944  ldr      x2, [x8]
006704948  ldrb     w8, [x2, #0x53]
00670494C  tbnz     w8, #5, #0x670496c
006704950  str      w20, [x19, #0x20]
006704954  b        #0x670497c ; 
006704958  ldr      x2, [x1, #0x60]
00670495C  mov      x0, x19
006704960  ldp      x20, x19, [sp, #0x10]
006704964  ldp      x30, x21, [sp], #0x20
006704968  br       x2
00670496C  ldr      x8, [x2, #0x60]
006704970  mov      x0, x19
006704974  mov      w1, w20
006704978  blr      x8
00670497C  mov      x0, x19
006704980  mov      x1, xzr
006704984  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006704988  adrp     x21, #0x959a000
00670498C  ldrb     w8, [x21, #0x97d]
006704990  mov      w20, w0
006704994  cbnz     w8, #0x67049ac
006704998  adrp     x0, #0x8f17000
00670499C  ldr      x0, [x0, #0x968]
0067049A0  bl       #0x382bd14 ; 
0067049A4  mov      w8, #1
0067049A8  strb     w8, [x21, #0x97d]
0067049AC  adrp     x8, #0x8f17000
0067049B0  ldr      x8, [x8, #0x968]
0067049B4  ldr      x2, [x8]
0067049B8  ldrb     w8, [x2, #0x53]
0067049BC  tbnz     w8, #5, #0x67049c8
0067049C0  str      w20, [x19, #0x24]
0067049C4  b        #0x67049d8 ; 
0067049C8  ldr      x8, [x2, #0x60]
0067049CC  mov      x0, x19
0067049D0  mov      w1, w20
0067049D4  blr      x8
0067049D8  mov      x0, x19
0067049DC  mov      x1, xzr
0067049E0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0067049E4  adrp     x21, #0x959a000
0067049E8  ldrb     w8, [x21, #0x97e]
0067049EC  mov      x20, x0
0067049F0  cbnz     w8, #0x6704a08
0067049F4  adrp     x0, #0x8f17000
0067049F8  ldr      x0, [x0, #0x978]
0067049FC  bl       #0x382bd14 ; 
006704A00  mov      w8, #1
006704A04  strb     w8, [x21, #0x97e]
006704A08  adrp     x8, #0x8f17000
006704A0C  ldr      x8, [x8, #0x978]
006704A10  ldr      x2, [x8]
006704A14  ldrb     w8, [x2, #0x53]
006704A18  tbnz     w8, #5, #0x6704a30
006704A1C  mov      x0, x19
006704A20  str      x20, [x0, #0x28]!
006704A24  mov      x1, x20
006704A28  bl       #0x382bcb8 ; 
006704A2C  b        #0x6704a40 ; 
006704A30  ldr      x8, [x2, #0x60]
006704A34  mov      x0, x19
006704A38  mov      x1, x20
006704A3C  blr      x8
006704A40  mov      x0, x19
006704A44  mov      x1, xzr
006704A48  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006704A4C  adrp     x21, #0x959a000
006704A50  ldrb     w8, [x21, #0x97f]
006704A54  mov      x20, x0
006704A58  cbnz     w8, #0x6704a70
006704A5C  adrp     x0, #0x8f17000
006704A60  ldr      x0, [x0, #0x988]
006704A64  bl       #0x382bd14 ; 
006704A68  mov      w8, #1
006704A6C  strb     w8, [x21, #0x97f]
006704A70  adrp     x8, #0x8f17000
006704A74  ldr      x8, [x8, #0x988]
006704A78  ldr      x2, [x8]
006704A7C  ldrb     w8, [x2, #0x53]
006704A80  tbnz     w8, #5, #0x6704a98
006704A84  mov      x0, x19
006704A88  str      x20, [x0, #0x30]!
006704A8C  mov      x1, x20
006704A90  bl       #0x382bcb8 ; 
006704A94  b        #0x6704aa8 ; 
006704A98  ldr      x8, [x2, #0x60]
006704A9C  mov      x0, x19
006704AA0  mov      x1, x20
006704AA4  blr      x8
006704AA8  mov      x0, x19
006704AAC  mov      x1, xzr
006704AB0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006704AB4  adrp     x21, #0x959a000
006704AB8  ldrb     w8, [x21, #0x980]
006704ABC  mov      x20, x0
006704AC0  cbnz     w8, #0x6704ad8
006704AC4  adrp     x0, #0x8f17000
006704AC8  ldr      x0, [x0, #0x998]
006704ACC  bl       #0x382bd14 ; 
006704AD0  mov      w8, #1
006704AD4  strb     w8, [x21, #0x980]
006704AD8  adrp     x8, #0x8f17000
006704ADC  ldr      x8, [x8, #0x998]
006704AE0  ldr      x2, [x8]
006704AE4  ldrb     w8, [x2, #0x53]
006704AE8  tbnz     w8, #5, #0x6704b00
006704AEC  mov      x0, x19
006704AF0  str      x20, [x0, #0x38]!
006704AF4  mov      x1, x20
006704AF8  bl       #0x382bcb8 ; 
006704AFC  b        #0x6704b10 ; 
006704B00  ldr      x8, [x2, #0x60]
006704B04  mov      x0, x19
006704B08  mov      x1, x20
006704B0C  blr      x8
006704B10  mov      x0, x19
006704B14  mov      x1, xzr
006704B18  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006704B1C  adrp     x21, #0x959a000
006704B20  ldrb     w8, [x21, #0x981]
006704B24  mov      w20, w0
006704B28  cbnz     w8, #0x6704b40
006704B2C  adrp     x0, #0x8f17000
006704B30  ldr      x0, [x0, #0x9a8]
006704B34  bl       #0x382bd14 ; 
006704B38  mov      w8, #1
006704B3C  strb     w8, [x21, #0x981]
006704B40  adrp     x8, #0x8f17000
006704B44  ldr      x8, [x8, #0x9a8]
006704B48  ldr      x2, [x8]
006704B4C  ldrb     w8, [x2, #0x53]
006704B50  tbnz     w8, #5, #0x6704b5c
006704B54  str      w20, [x19, #0x40]
006704B58  b        #0x6704b6c ; 
006704B5C  ldr      x8, [x2, #0x60]
006704B60  mov      x0, x19
006704B64  mov      w1, w20
006704B68  blr      x8
006704B6C  mov      x0, x19
006704B70  mov      x1, xzr
006704B74  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006704B78  adrp     x21, #0x959a000
006704B7C  ldrb     w8, [x21, #0x982]
006704B80  mov      x20, x0
006704B84  cbnz     w8, #0x6704b9c
006704B88  adrp     x0, #0x8f17000
006704B8C  ldr      x0, [x0, #0x9b8]
006704B90  bl       #0x382bd14 ; 
006704B94  mov      w8, #1
006704B98  strb     w8, [x21, #0x982]
006704B9C  adrp     x8, #0x8f17000
006704BA0  ldr      x8, [x8, #0x9b8]
006704BA4  ldr      x2, [x8]
006704BA8  ldrb     w8, [x2, #0x53]
006704BAC  tbnz     w8, #5, #0x6704bc4
006704BB0  str      x20, [x19, #0x48]!
006704BB4  mov      x0, x19
006704BB8  mov      x1, x20
006704BBC  bl       #0x382bcb8 ; 
006704BC0  b        #0x6704bd4 ; 
006704BC4  ldr      x8, [x2, #0x60]
006704BC8  mov      x0, x19
006704BCC  mov      x1, x20
006704BD0  blr      x8
006704BD4  ldp      x20, x19, [sp, #0x10]
006704BD8  mov      w0, #1
006704BDC  ldp      x30, x21, [sp], #0x20
006704BE0  ret      

