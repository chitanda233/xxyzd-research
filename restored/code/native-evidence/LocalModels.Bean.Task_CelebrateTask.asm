; LocalModels.Bean.Task_CelebrateTask$$readImpl
; RVA 0x6B117C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B117C8  stp      x30, x21, [sp, #-0x20]!
006B117CC  stp      x20, x19, [sp, #0x10]
006B117D0  adrp     x20, #0x959f000
006B117D4  adrp     x21, #0x8f3e000
006B117D8  ldrb     w8, [x20, #0x556]
006B117DC  ldr      x21, [x21, #0xd38]
006B117E0  mov      x19, x0
006B117E4  tbnz     w8, #0, #0x6b117fc
006B117E8  adrp     x0, #0x8f3e000
006B117EC  ldr      x0, [x0, #0xd38]
006B117F0  bl       #0x382bd14 ; 
006B117F4  mov      w8, #1
006B117F8  strb     w8, [x20, #0x556]
006B117FC  ldr      x1, [x21]
006B11800  ldrb     w8, [x1, #0x53]
006B11804  tbnz     w8, #5, #0x6b11854
006B11808  mov      x0, x19
006B1180C  mov      x1, xzr
006B11810  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B11814  adrp     x21, #0x959f000
006B11818  ldrb     w8, [x21, #0x9ae]
006B1181C  mov      w20, w0
006B11820  cbnz     w8, #0x6b11838
006B11824  adrp     x0, #0x8f3e000
006B11828  ldr      x0, [x0, #0xca0]
006B1182C  bl       #0x382bd14 ; 
006B11830  mov      w8, #1
006B11834  strb     w8, [x21, #0x9ae]
006B11838  adrp     x8, #0x8f3e000
006B1183C  ldr      x8, [x8, #0xca0]
006B11840  ldr      x2, [x8]
006B11844  ldrb     w8, [x2, #0x53]
006B11848  tbnz     w8, #5, #0x6b11868
006B1184C  str      w20, [x19, #0x20]
006B11850  b        #0x6b11878 ; 
006B11854  ldr      x2, [x1, #0x60]
006B11858  mov      x0, x19
006B1185C  ldp      x20, x19, [sp, #0x10]
006B11860  ldp      x30, x21, [sp], #0x20
006B11864  br       x2
006B11868  ldr      x8, [x2, #0x60]
006B1186C  mov      x0, x19
006B11870  mov      w1, w20
006B11874  blr      x8
006B11878  mov      x0, x19
006B1187C  mov      x1, xzr
006B11880  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B11884  adrp     x21, #0x959f000
006B11888  ldrb     w8, [x21, #0x9af]
006B1188C  mov      w20, w0
006B11890  cbnz     w8, #0x6b118a8
006B11894  adrp     x0, #0x8f3e000
006B11898  ldr      x0, [x0, #0xcb0]
006B1189C  bl       #0x382bd14 ; 
006B118A0  mov      w8, #1
006B118A4  strb     w8, [x21, #0x9af]
006B118A8  adrp     x8, #0x8f3e000
006B118AC  ldr      x8, [x8, #0xcb0]
006B118B0  ldr      x2, [x8]
006B118B4  ldrb     w8, [x2, #0x53]
006B118B8  tbnz     w8, #5, #0x6b118c4
006B118BC  str      w20, [x19, #0x24]
006B118C0  b        #0x6b118d4 ; 
006B118C4  ldr      x8, [x2, #0x60]
006B118C8  mov      x0, x19
006B118CC  mov      w1, w20
006B118D0  blr      x8
006B118D4  mov      x0, x19
006B118D8  mov      x1, xzr
006B118DC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B118E0  adrp     x21, #0x959f000
006B118E4  ldrb     w8, [x21, #0x9b0]
006B118E8  mov      w20, w0
006B118EC  cbnz     w8, #0x6b11904
006B118F0  adrp     x0, #0x8f3e000
006B118F4  ldr      x0, [x0, #0xcc0]
006B118F8  bl       #0x382bd14 ; 
006B118FC  mov      w8, #1
006B11900  strb     w8, [x21, #0x9b0]
006B11904  adrp     x8, #0x8f3e000
006B11908  ldr      x8, [x8, #0xcc0]
006B1190C  ldr      x2, [x8]
006B11910  ldrb     w8, [x2, #0x53]
006B11914  tbnz     w8, #5, #0x6b11920
006B11918  str      w20, [x19, #0x28]
006B1191C  b        #0x6b11930 ; 
006B11920  ldr      x8, [x2, #0x60]
006B11924  mov      x0, x19
006B11928  mov      w1, w20
006B1192C  blr      x8
006B11930  mov      x0, x19
006B11934  mov      x1, xzr
006B11938  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1193C  adrp     x21, #0x959f000
006B11940  ldrb     w8, [x21, #0x9b1]
006B11944  mov      w20, w0
006B11948  cbnz     w8, #0x6b11960
006B1194C  adrp     x0, #0x8f3e000
006B11950  ldr      x0, [x0, #0xcd0]
006B11954  bl       #0x382bd14 ; 
006B11958  mov      w8, #1
006B1195C  strb     w8, [x21, #0x9b1]
006B11960  adrp     x8, #0x8f3e000
006B11964  ldr      x8, [x8, #0xcd0]
006B11968  ldr      x2, [x8]
006B1196C  ldrb     w8, [x2, #0x53]
006B11970  tbnz     w8, #5, #0x6b1197c
006B11974  str      w20, [x19, #0x2c]
006B11978  b        #0x6b1198c ; 
006B1197C  ldr      x8, [x2, #0x60]
006B11980  mov      x0, x19
006B11984  mov      w1, w20
006B11988  blr      x8
006B1198C  mov      x0, x19
006B11990  mov      x1, xzr
006B11994  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B11998  adrp     x21, #0x959f000
006B1199C  ldrb     w8, [x21, #0x9b2]
006B119A0  mov      w20, w0
006B119A4  cbnz     w8, #0x6b119bc
006B119A8  adrp     x0, #0x8f3e000
006B119AC  ldr      x0, [x0, #0xce0]
006B119B0  bl       #0x382bd14 ; 
006B119B4  mov      w8, #1
006B119B8  strb     w8, [x21, #0x9b2]
006B119BC  adrp     x8, #0x8f3e000
006B119C0  ldr      x8, [x8, #0xce0]
006B119C4  ldr      x2, [x8]
006B119C8  ldrb     w8, [x2, #0x53]
006B119CC  tbnz     w8, #5, #0x6b119d8
006B119D0  str      w20, [x19, #0x30]
006B119D4  b        #0x6b119e8 ; 
006B119D8  ldr      x8, [x2, #0x60]
006B119DC  mov      x0, x19
006B119E0  mov      w1, w20
006B119E4  blr      x8
006B119E8  mov      x0, x19
006B119EC  mov      x1, xzr
006B119F0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006B119F4  adrp     x21, #0x959f000
006B119F8  ldrb     w8, [x21, #0x9b3]
006B119FC  mov      x20, x0
006B11A00  cbnz     w8, #0x6b11a18
006B11A04  adrp     x0, #0x8f3e000
006B11A08  ldr      x0, [x0, #0xcf0]
006B11A0C  bl       #0x382bd14 ; 
006B11A10  mov      w8, #1
006B11A14  strb     w8, [x21, #0x9b3]
006B11A18  adrp     x8, #0x8f3e000
006B11A1C  ldr      x8, [x8, #0xcf0]
006B11A20  ldr      x2, [x8]
006B11A24  ldrb     w8, [x2, #0x53]
006B11A28  tbnz     w8, #5, #0x6b11a40
006B11A2C  mov      x0, x19
006B11A30  str      x20, [x0, #0x38]!
006B11A34  mov      x1, x20
006B11A38  bl       #0x382bcb8 ; 
006B11A3C  b        #0x6b11a50 ; 
006B11A40  ldr      x8, [x2, #0x60]
006B11A44  mov      x0, x19
006B11A48  mov      x1, x20
006B11A4C  blr      x8
006B11A50  mov      x0, x19
006B11A54  mov      x1, xzr
006B11A58  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B11A5C  adrp     x21, #0x959f000
006B11A60  ldrb     w8, [x21, #0x9b4]
006B11A64  mov      x20, x0
006B11A68  cbnz     w8, #0x6b11a80
006B11A6C  adrp     x0, #0x8f3e000
006B11A70  ldr      x0, [x0, #0xd00]
006B11A74  bl       #0x382bd14 ; 
006B11A78  mov      w8, #1
006B11A7C  strb     w8, [x21, #0x9b4]
006B11A80  adrp     x8, #0x8f3e000
006B11A84  ldr      x8, [x8, #0xd00]
006B11A88  ldr      x2, [x8]
006B11A8C  ldrb     w8, [x2, #0x53]
006B11A90  tbnz     w8, #5, #0x6b11aa8
006B11A94  mov      x0, x19
006B11A98  str      x20, [x0, #0x40]!
006B11A9C  mov      x1, x20
006B11AA0  bl       #0x382bcb8 ; 
006B11AA4  b        #0x6b11ab8 ; 
006B11AA8  ldr      x8, [x2, #0x60]
006B11AAC  mov      x0, x19
006B11AB0  mov      x1, x20
006B11AB4  blr      x8
006B11AB8  mov      x0, x19
006B11ABC  mov      x1, xzr
006B11AC0  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B11AC4  adrp     x21, #0x959f000
006B11AC8  ldrb     w8, [x21, #0x9b5]
006B11ACC  mov      x20, x0
006B11AD0  cbnz     w8, #0x6b11ae8
006B11AD4  adrp     x0, #0x8f3e000
006B11AD8  ldr      x0, [x0, #0xd10]
006B11ADC  bl       #0x382bd14 ; 
006B11AE0  mov      w8, #1
006B11AE4  strb     w8, [x21, #0x9b5]
006B11AE8  adrp     x8, #0x8f3e000
006B11AEC  ldr      x8, [x8, #0xd10]
006B11AF0  ldr      x2, [x8]
006B11AF4  ldrb     w8, [x2, #0x53]
006B11AF8  tbnz     w8, #5, #0x6b11b10
006B11AFC  mov      x0, x19
006B11B00  str      x20, [x0, #0x48]!
006B11B04  mov      x1, x20
006B11B08  bl       #0x382bcb8 ; 
006B11B0C  b        #0x6b11b20 ; 
006B11B10  ldr      x8, [x2, #0x60]
006B11B14  mov      x0, x19
006B11B18  mov      x1, x20
006B11B1C  blr      x8
006B11B20  mov      x0, x19
006B11B24  mov      x1, xzr
006B11B28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B11B2C  adrp     x21, #0x959f000
006B11B30  ldrb     w8, [x21, #0x9b6]
006B11B34  mov      w20, w0
006B11B38  cbnz     w8, #0x6b11b50
006B11B3C  adrp     x0, #0x8f3e000
006B11B40  ldr      x0, [x0, #0xd20]
006B11B44  bl       #0x382bd14 ; 
006B11B48  mov      w8, #1
006B11B4C  strb     w8, [x21, #0x9b6]
006B11B50  adrp     x8, #0x8f3e000
006B11B54  ldr      x8, [x8, #0xd20]
006B11B58  ldr      x2, [x8]
006B11B5C  ldrb     w8, [x2, #0x53]
006B11B60  tbnz     w8, #5, #0x6b11b6c
006B11B64  str      w20, [x19, #0x50]
006B11B68  b        #0x6b11b7c ; 
006B11B6C  ldr      x8, [x2, #0x60]
006B11B70  mov      x0, x19
006B11B74  mov      w1, w20
006B11B78  blr      x8
006B11B7C  mov      x0, x19
006B11B80  mov      x1, xzr
006B11B84  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006B11B88  adrp     x21, #0x959f000
006B11B8C  ldrb     w8, [x21, #0x9b7]
006B11B90  mov      x20, x0
006B11B94  cbnz     w8, #0x6b11bac
006B11B98  adrp     x0, #0x8f3e000
006B11B9C  ldr      x0, [x0, #0xd30]
006B11BA0  bl       #0x382bd14 ; 
006B11BA4  mov      w8, #1
006B11BA8  strb     w8, [x21, #0x9b7]
006B11BAC  adrp     x8, #0x8f3e000
006B11BB0  ldr      x8, [x8, #0xd30]
006B11BB4  ldr      x2, [x8]
006B11BB8  ldrb     w8, [x2, #0x53]
006B11BBC  tbnz     w8, #5, #0x6b11bd4
006B11BC0  str      x20, [x19, #0x58]!
006B11BC4  mov      x0, x19
006B11BC8  mov      x1, x20
006B11BCC  bl       #0x382bcb8 ; 
006B11BD0  b        #0x6b11be4 ; 
006B11BD4  ldr      x8, [x2, #0x60]
006B11BD8  mov      x0, x19
006B11BDC  mov      x1, x20
006B11BE0  blr      x8
006B11BE4  ldp      x20, x19, [sp, #0x10]
006B11BE8  mov      w0, #1
006B11BEC  ldp      x30, x21, [sp], #0x20
006B11BF0  ret      

