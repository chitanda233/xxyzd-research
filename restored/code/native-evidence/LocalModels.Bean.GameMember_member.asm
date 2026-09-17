; LocalModels.Bean.GameMember_member$$readImpl
; RVA 0x6A804E0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A804E0  str      d8, [sp, #-0x30]!
006A804E4  stp      x30, x21, [sp, #0x10]
006A804E8  stp      x20, x19, [sp, #0x20]
006A804EC  adrp     x20, #0x959d000
006A804F0  adrp     x21, #0x8f38000
006A804F4  ldrb     w8, [x20, #0xf4d]
006A804F8  ldr      x21, [x21, #0x260]
006A804FC  mov      x19, x0
006A80500  tbnz     w8, #0, #0x6a80518
006A80504  adrp     x0, #0x8f38000
006A80508  ldr      x0, [x0, #0x260]
006A8050C  bl       #0x382bd14 ; 
006A80510  mov      w8, #1
006A80514  strb     w8, [x20, #0xf4d]
006A80518  ldr      x1, [x21]
006A8051C  ldrb     w8, [x1, #0x53]
006A80520  tbnz     w8, #5, #0x6a80570
006A80524  mov      x0, x19
006A80528  mov      x1, xzr
006A8052C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80530  adrp     x21, #0x959e000
006A80534  ldrb     w8, [x21, #0x4f1]
006A80538  mov      w20, w0
006A8053C  cbnz     w8, #0x6a80554
006A80540  adrp     x0, #0x8f38000
006A80544  ldr      x0, [x0, #0xc8]
006A80548  bl       #0x382bd14 ; 
006A8054C  mov      w8, #1
006A80550  strb     w8, [x21, #0x4f1]
006A80554  adrp     x8, #0x8f38000
006A80558  ldr      x8, [x8, #0xc8]
006A8055C  ldr      x2, [x8]
006A80560  ldrb     w8, [x2, #0x53]
006A80564  tbnz     w8, #5, #0x6a80588
006A80568  str      w20, [x19, #0x20]
006A8056C  b        #0x6a80598 ; 
006A80570  ldr      x2, [x1, #0x60]
006A80574  mov      x0, x19
006A80578  ldp      x20, x19, [sp, #0x20]
006A8057C  ldp      x30, x21, [sp, #0x10]
006A80580  ldr      d8, [sp], #0x30
006A80584  br       x2
006A80588  ldr      x8, [x2, #0x60]
006A8058C  mov      x0, x19
006A80590  mov      w1, w20
006A80594  blr      x8
006A80598  mov      x0, x19
006A8059C  mov      x1, xzr
006A805A0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A805A4  adrp     x21, #0x959e000
006A805A8  ldrb     w8, [x21, #0x4f2]
006A805AC  mov      w20, w0
006A805B0  cbnz     w8, #0x6a805c8
006A805B4  adrp     x0, #0x8f38000
006A805B8  ldr      x0, [x0, #0xd8]
006A805BC  bl       #0x382bd14 ; 
006A805C0  mov      w8, #1
006A805C4  strb     w8, [x21, #0x4f2]
006A805C8  adrp     x8, #0x8f38000
006A805CC  ldr      x8, [x8, #0xd8]
006A805D0  ldr      x2, [x8]
006A805D4  ldrb     w8, [x2, #0x53]
006A805D8  tbnz     w8, #5, #0x6a805e4
006A805DC  str      w20, [x19, #0x24]
006A805E0  b        #0x6a805f4 ; 
006A805E4  ldr      x8, [x2, #0x60]
006A805E8  mov      x0, x19
006A805EC  mov      w1, w20
006A805F0  blr      x8
006A805F4  mov      x0, x19
006A805F8  mov      x1, xzr
006A805FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80600  adrp     x21, #0x959e000
006A80604  ldrb     w8, [x21, #0x4f3]
006A80608  mov      w20, w0
006A8060C  cbnz     w8, #0x6a80624
006A80610  adrp     x0, #0x8f38000
006A80614  ldr      x0, [x0, #0xe8]
006A80618  bl       #0x382bd14 ; 
006A8061C  mov      w8, #1
006A80620  strb     w8, [x21, #0x4f3]
006A80624  adrp     x8, #0x8f38000
006A80628  ldr      x8, [x8, #0xe8]
006A8062C  ldr      x2, [x8]
006A80630  ldrb     w8, [x2, #0x53]
006A80634  tbnz     w8, #5, #0x6a80640
006A80638  str      w20, [x19, #0x28]
006A8063C  b        #0x6a80650 ; 
006A80640  ldr      x8, [x2, #0x60]
006A80644  mov      x0, x19
006A80648  mov      w1, w20
006A8064C  blr      x8
006A80650  mov      x0, x19
006A80654  mov      x1, xzr
006A80658  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8065C  adrp     x21, #0x959e000
006A80660  ldrb     w8, [x21, #0x4f4]
006A80664  mov      w20, w0
006A80668  cbnz     w8, #0x6a80680
006A8066C  adrp     x0, #0x8f38000
006A80670  ldr      x0, [x0, #0xf8]
006A80674  bl       #0x382bd14 ; 
006A80678  mov      w8, #1
006A8067C  strb     w8, [x21, #0x4f4]
006A80680  adrp     x8, #0x8f38000
006A80684  ldr      x8, [x8, #0xf8]
006A80688  ldr      x2, [x8]
006A8068C  ldrb     w8, [x2, #0x53]
006A80690  tbnz     w8, #5, #0x6a8069c
006A80694  str      w20, [x19, #0x2c]
006A80698  b        #0x6a806ac ; 
006A8069C  ldr      x8, [x2, #0x60]
006A806A0  mov      x0, x19
006A806A4  mov      w1, w20
006A806A8  blr      x8
006A806AC  mov      x0, x19
006A806B0  mov      x1, xzr
006A806B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A806B8  adrp     x21, #0x959e000
006A806BC  ldrb     w8, [x21, #0x4f5]
006A806C0  mov      w20, w0
006A806C4  cbnz     w8, #0x6a806dc
006A806C8  adrp     x0, #0x8f38000
006A806CC  ldr      x0, [x0, #0x108]
006A806D0  bl       #0x382bd14 ; 
006A806D4  mov      w8, #1
006A806D8  strb     w8, [x21, #0x4f5]
006A806DC  adrp     x8, #0x8f38000
006A806E0  ldr      x8, [x8, #0x108]
006A806E4  ldr      x2, [x8]
006A806E8  ldrb     w8, [x2, #0x53]
006A806EC  tbnz     w8, #5, #0x6a806f8
006A806F0  str      w20, [x19, #0x30]
006A806F4  b        #0x6a80708 ; 
006A806F8  ldr      x8, [x2, #0x60]
006A806FC  mov      x0, x19
006A80700  mov      w1, w20
006A80704  blr      x8
006A80708  mov      x0, x19
006A8070C  mov      x1, xzr
006A80710  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A80714  adrp     x21, #0x959e000
006A80718  ldrb     w8, [x21, #0x4f6]
006A8071C  mov      x20, x0
006A80720  cbnz     w8, #0x6a80738
006A80724  adrp     x0, #0x8f38000
006A80728  ldr      x0, [x0, #0x118]
006A8072C  bl       #0x382bd14 ; 
006A80730  mov      w8, #1
006A80734  strb     w8, [x21, #0x4f6]
006A80738  adrp     x8, #0x8f38000
006A8073C  ldr      x8, [x8, #0x118]
006A80740  ldr      x2, [x8]
006A80744  ldrb     w8, [x2, #0x53]
006A80748  tbnz     w8, #5, #0x6a80760
006A8074C  mov      x0, x19
006A80750  str      x20, [x0, #0x38]!
006A80754  mov      x1, x20
006A80758  bl       #0x382bcb8 ; 
006A8075C  b        #0x6a80770 ; 
006A80760  ldr      x8, [x2, #0x60]
006A80764  mov      x0, x19
006A80768  mov      x1, x20
006A8076C  blr      x8
006A80770  mov      x0, x19
006A80774  mov      x1, xzr
006A80778  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8077C  adrp     x21, #0x959e000
006A80780  ldrb     w8, [x21, #0x4f7]
006A80784  mov      w20, w0
006A80788  cbnz     w8, #0x6a807a0
006A8078C  adrp     x0, #0x8f38000
006A80790  ldr      x0, [x0, #0x128]
006A80794  bl       #0x382bd14 ; 
006A80798  mov      w8, #1
006A8079C  strb     w8, [x21, #0x4f7]
006A807A0  adrp     x8, #0x8f38000
006A807A4  ldr      x8, [x8, #0x128]
006A807A8  ldr      x2, [x8]
006A807AC  ldrb     w8, [x2, #0x53]
006A807B0  tbnz     w8, #5, #0x6a807bc
006A807B4  str      w20, [x19, #0x40]
006A807B8  b        #0x6a807cc ; 
006A807BC  ldr      x8, [x2, #0x60]
006A807C0  mov      x0, x19
006A807C4  mov      w1, w20
006A807C8  blr      x8
006A807CC  mov      x0, x19
006A807D0  mov      x1, xzr
006A807D4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A807D8  adrp     x21, #0x959e000
006A807DC  ldrb     w8, [x21, #0x4f8]
006A807E0  mov      w20, w0
006A807E4  cbnz     w8, #0x6a807fc
006A807E8  adrp     x0, #0x8f38000
006A807EC  ldr      x0, [x0, #0x138]
006A807F0  bl       #0x382bd14 ; 
006A807F4  mov      w8, #1
006A807F8  strb     w8, [x21, #0x4f8]
006A807FC  adrp     x8, #0x8f38000
006A80800  ldr      x8, [x8, #0x138]
006A80804  ldr      x2, [x8]
006A80808  ldrb     w8, [x2, #0x53]
006A8080C  tbnz     w8, #5, #0x6a80818
006A80810  str      w20, [x19, #0x44]
006A80814  b        #0x6a80828 ; 
006A80818  ldr      x8, [x2, #0x60]
006A8081C  mov      x0, x19
006A80820  mov      w1, w20
006A80824  blr      x8
006A80828  mov      x0, x19
006A8082C  mov      x1, xzr
006A80830  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80834  adrp     x21, #0x959e000
006A80838  ldrb     w8, [x21, #0x4f9]
006A8083C  mov      w20, w0
006A80840  cbnz     w8, #0x6a80858
006A80844  adrp     x0, #0x8f38000
006A80848  ldr      x0, [x0, #0x148]
006A8084C  bl       #0x382bd14 ; 
006A80850  mov      w8, #1
006A80854  strb     w8, [x21, #0x4f9]
006A80858  adrp     x8, #0x8f38000
006A8085C  ldr      x8, [x8, #0x148]
006A80860  ldr      x2, [x8]
006A80864  ldrb     w8, [x2, #0x53]
006A80868  tbnz     w8, #5, #0x6a80874
006A8086C  str      w20, [x19, #0x48]
006A80870  b        #0x6a80884 ; 
006A80874  ldr      x8, [x2, #0x60]
006A80878  mov      x0, x19
006A8087C  mov      w1, w20
006A80880  blr      x8
006A80884  mov      x0, x19
006A80888  mov      x1, xzr
006A8088C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80890  adrp     x21, #0x959e000
006A80894  ldrb     w8, [x21, #0x4fa]
006A80898  mov      w20, w0
006A8089C  cbnz     w8, #0x6a808b4
006A808A0  adrp     x0, #0x8f38000
006A808A4  ldr      x0, [x0, #0x158]
006A808A8  bl       #0x382bd14 ; 
006A808AC  mov      w8, #1
006A808B0  strb     w8, [x21, #0x4fa]
006A808B4  adrp     x8, #0x8f38000
006A808B8  ldr      x8, [x8, #0x158]
006A808BC  ldr      x2, [x8]
006A808C0  ldrb     w8, [x2, #0x53]
006A808C4  tbnz     w8, #5, #0x6a808d0
006A808C8  str      w20, [x19, #0x4c]
006A808CC  b        #0x6a808e0 ; 
006A808D0  ldr      x8, [x2, #0x60]
006A808D4  mov      x0, x19
006A808D8  mov      w1, w20
006A808DC  blr      x8
006A808E0  mov      x0, x19
006A808E4  mov      x1, xzr
006A808E8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A808EC  adrp     x21, #0x959e000
006A808F0  ldrb     w8, [x21, #0x4fb]
006A808F4  mov      x20, x0
006A808F8  cbnz     w8, #0x6a80910
006A808FC  adrp     x0, #0x8f38000
006A80900  ldr      x0, [x0, #0x168]
006A80904  bl       #0x382bd14 ; 
006A80908  mov      w8, #1
006A8090C  strb     w8, [x21, #0x4fb]
006A80910  adrp     x8, #0x8f38000
006A80914  ldr      x8, [x8, #0x168]
006A80918  ldr      x2, [x8]
006A8091C  ldrb     w8, [x2, #0x53]
006A80920  tbnz     w8, #5, #0x6a80938
006A80924  mov      x0, x19
006A80928  str      x20, [x0, #0x50]!
006A8092C  mov      x1, x20
006A80930  bl       #0x382bcb8 ; 
006A80934  b        #0x6a80948 ; 
006A80938  ldr      x8, [x2, #0x60]
006A8093C  mov      x0, x19
006A80940  mov      x1, x20
006A80944  blr      x8
006A80948  mov      x0, x19
006A8094C  mov      x1, xzr
006A80950  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80954  adrp     x21, #0x959e000
006A80958  ldrb     w8, [x21, #0x4fc]
006A8095C  mov      w20, w0
006A80960  cbnz     w8, #0x6a80978
006A80964  adrp     x0, #0x8f38000
006A80968  ldr      x0, [x0, #0x178]
006A8096C  bl       #0x382bd14 ; 
006A80970  mov      w8, #1
006A80974  strb     w8, [x21, #0x4fc]
006A80978  adrp     x8, #0x8f38000
006A8097C  ldr      x8, [x8, #0x178]
006A80980  ldr      x2, [x8]
006A80984  ldrb     w8, [x2, #0x53]
006A80988  tbnz     w8, #5, #0x6a80994
006A8098C  str      w20, [x19, #0x58]
006A80990  b        #0x6a809a4 ; 
006A80994  ldr      x8, [x2, #0x60]
006A80998  mov      x0, x19
006A8099C  mov      w1, w20
006A809A0  blr      x8
006A809A4  mov      x0, x19
006A809A8  mov      x1, xzr
006A809AC  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A809B0  adrp     x21, #0x959e000
006A809B4  ldrb     w8, [x21, #0x4fd]
006A809B8  mov      x20, x0
006A809BC  cbnz     w8, #0x6a809d4
006A809C0  adrp     x0, #0x8f38000
006A809C4  ldr      x0, [x0, #0x188]
006A809C8  bl       #0x382bd14 ; 
006A809CC  mov      w8, #1
006A809D0  strb     w8, [x21, #0x4fd]
006A809D4  adrp     x8, #0x8f38000
006A809D8  ldr      x8, [x8, #0x188]
006A809DC  ldr      x2, [x8]
006A809E0  ldrb     w8, [x2, #0x53]
006A809E4  tbnz     w8, #5, #0x6a809fc
006A809E8  mov      x0, x19
006A809EC  str      x20, [x0, #0x60]!
006A809F0  mov      x1, x20
006A809F4  bl       #0x382bcb8 ; 
006A809F8  b        #0x6a80a0c ; 
006A809FC  ldr      x8, [x2, #0x60]
006A80A00  mov      x0, x19
006A80A04  mov      x1, x20
006A80A08  blr      x8
006A80A0C  mov      x0, x19
006A80A10  mov      x1, xzr
006A80A14  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A80A18  adrp     x21, #0x959e000
006A80A1C  ldrb     w8, [x21, #0x4fe]
006A80A20  mov      x20, x0
006A80A24  cbnz     w8, #0x6a80a3c
006A80A28  adrp     x0, #0x8f38000
006A80A2C  ldr      x0, [x0, #0x198]
006A80A30  bl       #0x382bd14 ; 
006A80A34  mov      w8, #1
006A80A38  strb     w8, [x21, #0x4fe]
006A80A3C  adrp     x8, #0x8f38000
006A80A40  ldr      x8, [x8, #0x198]
006A80A44  ldr      x2, [x8]
006A80A48  ldrb     w8, [x2, #0x53]
006A80A4C  tbnz     w8, #5, #0x6a80a64
006A80A50  mov      x0, x19
006A80A54  str      x20, [x0, #0x68]!
006A80A58  mov      x1, x20
006A80A5C  bl       #0x382bcb8 ; 
006A80A60  b        #0x6a80a74 ; 
006A80A64  ldr      x8, [x2, #0x60]
006A80A68  mov      x0, x19
006A80A6C  mov      x1, x20
006A80A70  blr      x8
006A80A74  mov      x0, x19
006A80A78  mov      x1, xzr
006A80A7C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80A80  adrp     x21, #0x959e000
006A80A84  ldrb     w8, [x21, #0x4ff]
006A80A88  mov      w20, w0
006A80A8C  cbnz     w8, #0x6a80aa4
006A80A90  adrp     x0, #0x8f38000
006A80A94  ldr      x0, [x0, #0x1a8]
006A80A98  bl       #0x382bd14 ; 
006A80A9C  mov      w8, #1
006A80AA0  strb     w8, [x21, #0x4ff]
006A80AA4  adrp     x8, #0x8f38000
006A80AA8  ldr      x8, [x8, #0x1a8]
006A80AAC  ldr      x2, [x8]
006A80AB0  ldrb     w8, [x2, #0x53]
006A80AB4  tbnz     w8, #5, #0x6a80ac0
006A80AB8  str      w20, [x19, #0x70]
006A80ABC  b        #0x6a80ad0 ; 
006A80AC0  ldr      x8, [x2, #0x60]
006A80AC4  mov      x0, x19
006A80AC8  mov      w1, w20
006A80ACC  blr      x8
006A80AD0  mov      x0, x19
006A80AD4  mov      x1, xzr
006A80AD8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80ADC  adrp     x21, #0x959e000
006A80AE0  ldrb     w8, [x21, #0x500]
006A80AE4  mov      w20, w0
006A80AE8  cbnz     w8, #0x6a80b00
006A80AEC  adrp     x0, #0x8f38000
006A80AF0  ldr      x0, [x0, #0x1b8]
006A80AF4  bl       #0x382bd14 ; 
006A80AF8  mov      w8, #1
006A80AFC  strb     w8, [x21, #0x500]
006A80B00  adrp     x8, #0x8f38000
006A80B04  ldr      x8, [x8, #0x1b8]
006A80B08  ldr      x2, [x8]
006A80B0C  ldrb     w8, [x2, #0x53]
006A80B10  tbnz     w8, #5, #0x6a80b1c
006A80B14  str      w20, [x19, #0x74]
006A80B18  b        #0x6a80b2c ; 
006A80B1C  ldr      x8, [x2, #0x60]
006A80B20  mov      x0, x19
006A80B24  mov      w1, w20
006A80B28  blr      x8
006A80B2C  mov      x0, x19
006A80B30  mov      x1, xzr
006A80B34  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006A80B38  adrp     x20, #0x959e000
006A80B3C  ldrb     w8, [x20, #0x501]
006A80B40  mov      v8.16b, v0.16b
006A80B44  cbnz     w8, #0x6a80b5c
006A80B48  adrp     x0, #0x8f38000
006A80B4C  ldr      x0, [x0, #0x1c8]
006A80B50  bl       #0x382bd14 ; 
006A80B54  mov      w8, #1
006A80B58  strb     w8, [x20, #0x501]
006A80B5C  adrp     x8, #0x8f38000
006A80B60  ldr      x8, [x8, #0x1c8]
006A80B64  ldr      x1, [x8]
006A80B68  ldrb     w8, [x1, #0x53]
006A80B6C  tbnz     w8, #5, #0x6a80b78
006A80B70  str      s8, [x19, #0x78]
006A80B74  b        #0x6a80b88 ; 
006A80B78  ldr      x8, [x1, #0x60]
006A80B7C  mov      x0, x19
006A80B80  mov      v0.16b, v8.16b
006A80B84  blr      x8
006A80B88  mov      x0, x19
006A80B8C  mov      x1, xzr
006A80B90  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006A80B94  adrp     x20, #0x959e000
006A80B98  ldrb     w8, [x20, #0x502]
006A80B9C  mov      v8.16b, v0.16b
006A80BA0  cbnz     w8, #0x6a80bb8
006A80BA4  adrp     x0, #0x8f38000
006A80BA8  ldr      x0, [x0, #0x1d8]
006A80BAC  bl       #0x382bd14 ; 
006A80BB0  mov      w8, #1
006A80BB4  strb     w8, [x20, #0x502]
006A80BB8  adrp     x8, #0x8f38000
006A80BBC  ldr      x8, [x8, #0x1d8]
006A80BC0  ldr      x1, [x8]
006A80BC4  ldrb     w8, [x1, #0x53]
006A80BC8  tbnz     w8, #5, #0x6a80bd4
006A80BCC  str      s8, [x19, #0x7c]
006A80BD0  b        #0x6a80be4 ; 
006A80BD4  ldr      x8, [x1, #0x60]
006A80BD8  mov      x0, x19
006A80BDC  mov      v0.16b, v8.16b
006A80BE0  blr      x8
006A80BE4  mov      x0, x19
006A80BE8  mov      x1, xzr
006A80BEC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80BF0  adrp     x21, #0x959e000
006A80BF4  ldrb     w8, [x21, #0x503]
006A80BF8  mov      w20, w0
006A80BFC  cbnz     w8, #0x6a80c14
006A80C00  adrp     x0, #0x8f38000
006A80C04  ldr      x0, [x0, #0x1e8]
006A80C08  bl       #0x382bd14 ; 
006A80C0C  mov      w8, #1
006A80C10  strb     w8, [x21, #0x503]
006A80C14  adrp     x8, #0x8f38000
006A80C18  ldr      x8, [x8, #0x1e8]
006A80C1C  ldr      x2, [x8]
006A80C20  ldrb     w8, [x2, #0x53]
006A80C24  tbnz     w8, #5, #0x6a80c30
006A80C28  str      w20, [x19, #0x80]
006A80C2C  b        #0x6a80c40 ; 
006A80C30  ldr      x8, [x2, #0x60]
006A80C34  mov      x0, x19
006A80C38  mov      w1, w20
006A80C3C  blr      x8
006A80C40  mov      x0, x19
006A80C44  mov      x1, xzr
006A80C48  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80C4C  adrp     x21, #0x959e000
006A80C50  ldrb     w8, [x21, #0x504]
006A80C54  mov      w20, w0
006A80C58  cbnz     w8, #0x6a80c70
006A80C5C  adrp     x0, #0x8f38000
006A80C60  ldr      x0, [x0, #0x1f8]
006A80C64  bl       #0x382bd14 ; 
006A80C68  mov      w8, #1
006A80C6C  strb     w8, [x21, #0x504]
006A80C70  adrp     x8, #0x8f38000
006A80C74  ldr      x8, [x8, #0x1f8]
006A80C78  ldr      x2, [x8]
006A80C7C  ldrb     w8, [x2, #0x53]
006A80C80  tbnz     w8, #5, #0x6a80c8c
006A80C84  str      w20, [x19, #0x84]
006A80C88  b        #0x6a80c9c ; 
006A80C8C  ldr      x8, [x2, #0x60]
006A80C90  mov      x0, x19
006A80C94  mov      w1, w20
006A80C98  blr      x8
006A80C9C  mov      x0, x19
006A80CA0  mov      x1, xzr
006A80CA4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80CA8  adrp     x21, #0x959e000
006A80CAC  ldrb     w8, [x21, #0x505]
006A80CB0  mov      w20, w0
006A80CB4  cbnz     w8, #0x6a80ccc
006A80CB8  adrp     x0, #0x8f38000
006A80CBC  ldr      x0, [x0, #0x208]
006A80CC0  bl       #0x382bd14 ; 
006A80CC4  mov      w8, #1
006A80CC8  strb     w8, [x21, #0x505]
006A80CCC  adrp     x8, #0x8f38000
006A80CD0  ldr      x8, [x8, #0x208]
006A80CD4  ldr      x2, [x8]
006A80CD8  ldrb     w8, [x2, #0x53]
006A80CDC  tbnz     w8, #5, #0x6a80ce8
006A80CE0  str      w20, [x19, #0x88]
006A80CE4  b        #0x6a80cf8 ; 
006A80CE8  ldr      x8, [x2, #0x60]
006A80CEC  mov      x0, x19
006A80CF0  mov      w1, w20
006A80CF4  blr      x8
006A80CF8  mov      x0, x19
006A80CFC  mov      x1, xzr
006A80D00  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80D04  adrp     x21, #0x959e000
006A80D08  ldrb     w8, [x21, #0x506]
006A80D0C  mov      w20, w0
006A80D10  cbnz     w8, #0x6a80d28
006A80D14  adrp     x0, #0x8f38000
006A80D18  ldr      x0, [x0, #0x218]
006A80D1C  bl       #0x382bd14 ; 
006A80D20  mov      w8, #1
006A80D24  strb     w8, [x21, #0x506]
006A80D28  adrp     x8, #0x8f38000
006A80D2C  ldr      x8, [x8, #0x218]
006A80D30  ldr      x2, [x8]
006A80D34  ldrb     w8, [x2, #0x53]
006A80D38  tbnz     w8, #5, #0x6a80d44
006A80D3C  str      w20, [x19, #0x8c]
006A80D40  b        #0x6a80d54 ; 
006A80D44  ldr      x8, [x2, #0x60]
006A80D48  mov      x0, x19
006A80D4C  mov      w1, w20
006A80D50  blr      x8
006A80D54  mov      x0, x19
006A80D58  mov      x1, xzr
006A80D5C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80D60  adrp     x21, #0x959e000
006A80D64  ldrb     w8, [x21, #0x507]
006A80D68  mov      w20, w0
006A80D6C  cbnz     w8, #0x6a80d84
006A80D70  adrp     x0, #0x8f38000
006A80D74  ldr      x0, [x0, #0x228]
006A80D78  bl       #0x382bd14 ; 
006A80D7C  mov      w8, #1
006A80D80  strb     w8, [x21, #0x507]
006A80D84  adrp     x8, #0x8f38000
006A80D88  ldr      x8, [x8, #0x228]
006A80D8C  ldr      x2, [x8]
006A80D90  ldrb     w8, [x2, #0x53]
006A80D94  tbnz     w8, #5, #0x6a80da0
006A80D98  str      w20, [x19, #0x90]
006A80D9C  b        #0x6a80db0 ; 
006A80DA0  ldr      x8, [x2, #0x60]
006A80DA4  mov      x0, x19
006A80DA8  mov      w1, w20
006A80DAC  blr      x8
006A80DB0  mov      x0, x19
006A80DB4  mov      x1, xzr
006A80DB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80DBC  adrp     x21, #0x959e000
006A80DC0  ldrb     w8, [x21, #0x508]
006A80DC4  mov      w20, w0
006A80DC8  cbnz     w8, #0x6a80de0
006A80DCC  adrp     x0, #0x8f38000
006A80DD0  ldr      x0, [x0, #0x238]
006A80DD4  bl       #0x382bd14 ; 
006A80DD8  mov      w8, #1
006A80DDC  strb     w8, [x21, #0x508]
006A80DE0  adrp     x8, #0x8f38000
006A80DE4  ldr      x8, [x8, #0x238]
006A80DE8  ldr      x2, [x8]
006A80DEC  ldrb     w8, [x2, #0x53]
006A80DF0  tbnz     w8, #5, #0x6a80dfc
006A80DF4  str      w20, [x19, #0x94]
006A80DF8  b        #0x6a80e0c ; 
006A80DFC  ldr      x8, [x2, #0x60]
006A80E00  mov      x0, x19
006A80E04  mov      w1, w20
006A80E08  blr      x8
006A80E0C  mov      x0, x19
006A80E10  mov      x1, xzr
006A80E14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A80E18  adrp     x21, #0x959e000
006A80E1C  ldrb     w8, [x21, #0x509]
006A80E20  mov      w20, w0
006A80E24  cbnz     w8, #0x6a80e3c
006A80E28  adrp     x0, #0x8f38000
006A80E2C  ldr      x0, [x0, #0x248]
006A80E30  bl       #0x382bd14 ; 
006A80E34  mov      w8, #1
006A80E38  strb     w8, [x21, #0x509]
006A80E3C  adrp     x8, #0x8f38000
006A80E40  ldr      x8, [x8, #0x248]
006A80E44  ldr      x2, [x8]
006A80E48  ldrb     w8, [x2, #0x53]
006A80E4C  tbnz     w8, #5, #0x6a80e58
006A80E50  str      w20, [x19, #0x98]
006A80E54  b        #0x6a80e68 ; 
006A80E58  ldr      x8, [x2, #0x60]
006A80E5C  mov      x0, x19
006A80E60  mov      w1, w20
006A80E64  blr      x8
006A80E68  mov      x0, x19
006A80E6C  mov      x1, xzr
006A80E70  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A80E74  adrp     x21, #0x959e000
006A80E78  ldrb     w8, [x21, #0x50a]
006A80E7C  mov      x20, x0
006A80E80  cbnz     w8, #0x6a80e98
006A80E84  adrp     x0, #0x8f38000
006A80E88  ldr      x0, [x0, #0x258]
006A80E8C  bl       #0x382bd14 ; 
006A80E90  mov      w8, #1
006A80E94  strb     w8, [x21, #0x50a]
006A80E98  adrp     x8, #0x8f38000
006A80E9C  ldr      x8, [x8, #0x258]
006A80EA0  ldr      x2, [x8]
006A80EA4  ldrb     w8, [x2, #0x53]
006A80EA8  tbnz     w8, #5, #0x6a80ec0
006A80EAC  str      x20, [x19, #0xa0]!
006A80EB0  mov      x0, x19
006A80EB4  mov      x1, x20
006A80EB8  bl       #0x382bcb8 ; 
006A80EBC  b        #0x6a80ed0 ; 
006A80EC0  ldr      x8, [x2, #0x60]
006A80EC4  mov      x0, x19
006A80EC8  mov      x1, x20
006A80ECC  blr      x8
006A80ED0  ldp      x20, x19, [sp, #0x20]
006A80ED4  ldp      x30, x21, [sp, #0x10]
006A80ED8  mov      w0, #1
006A80EDC  ldr      d8, [sp], #0x30
006A80EE0  ret      

