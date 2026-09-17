; LocalModels.Bean.IAP_Fund$$readImpl
; RVA 0x6AA4698; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA4698  stp      x30, x21, [sp, #-0x20]!
006AA469C  stp      x20, x19, [sp, #0x10]
006AA46A0  adrp     x20, #0x959e000
006AA46A4  adrp     x21, #0x8f39000
006AA46A8  ldrb     w8, [x20, #0x304]
006AA46AC  ldr      x21, [x21, #0xd88]
006AA46B0  mov      x19, x0
006AA46B4  tbnz     w8, #0, #0x6aa46cc
006AA46B8  adrp     x0, #0x8f39000
006AA46BC  ldr      x0, [x0, #0xd88]
006AA46C0  bl       #0x382bd14 ; 
006AA46C4  mov      w8, #1
006AA46C8  strb     w8, [x20, #0x304]
006AA46CC  ldr      x1, [x21]
006AA46D0  ldrb     w8, [x1, #0x53]
006AA46D4  tbnz     w8, #5, #0x6aa4724
006AA46D8  mov      x0, x19
006AA46DC  mov      x1, xzr
006AA46E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA46E4  adrp     x21, #0x959e000
006AA46E8  ldrb     w8, [x21, #0x688]
006AA46EC  mov      w20, w0
006AA46F0  cbnz     w8, #0x6aa4708
006AA46F4  adrp     x0, #0x8f39000
006AA46F8  ldr      x0, [x0, #0xca0]
006AA46FC  bl       #0x382bd14 ; 
006AA4700  mov      w8, #1
006AA4704  strb     w8, [x21, #0x688]
006AA4708  adrp     x8, #0x8f39000
006AA470C  ldr      x8, [x8, #0xca0]
006AA4710  ldr      x2, [x8]
006AA4714  ldrb     w8, [x2, #0x53]
006AA4718  tbnz     w8, #5, #0x6aa4738
006AA471C  str      w20, [x19, #0x20]
006AA4720  b        #0x6aa4748 ; 
006AA4724  ldr      x2, [x1, #0x60]
006AA4728  mov      x0, x19
006AA472C  ldp      x20, x19, [sp, #0x10]
006AA4730  ldp      x30, x21, [sp], #0x20
006AA4734  br       x2
006AA4738  ldr      x8, [x2, #0x60]
006AA473C  mov      x0, x19
006AA4740  mov      w1, w20
006AA4744  blr      x8
006AA4748  mov      x0, x19
006AA474C  mov      x1, xzr
006AA4750  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA4754  adrp     x21, #0x959e000
006AA4758  ldrb     w8, [x21, #0x689]
006AA475C  mov      x20, x0
006AA4760  cbnz     w8, #0x6aa4778
006AA4764  adrp     x0, #0x8f39000
006AA4768  ldr      x0, [x0, #0xcb0]
006AA476C  bl       #0x382bd14 ; 
006AA4770  mov      w8, #1
006AA4774  strb     w8, [x21, #0x689]
006AA4778  adrp     x8, #0x8f39000
006AA477C  ldr      x8, [x8, #0xcb0]
006AA4780  ldr      x2, [x8]
006AA4784  ldrb     w8, [x2, #0x53]
006AA4788  tbnz     w8, #5, #0x6aa47a0
006AA478C  mov      x0, x19
006AA4790  str      x20, [x0, #0x28]!
006AA4794  mov      x1, x20
006AA4798  bl       #0x382bcb8 ; 
006AA479C  b        #0x6aa47b0 ; 
006AA47A0  ldr      x8, [x2, #0x60]
006AA47A4  mov      x0, x19
006AA47A8  mov      x1, x20
006AA47AC  blr      x8
006AA47B0  mov      x0, x19
006AA47B4  mov      x1, xzr
006AA47B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA47BC  adrp     x21, #0x959e000
006AA47C0  ldrb     w8, [x21, #0x68a]
006AA47C4  mov      w20, w0
006AA47C8  cbnz     w8, #0x6aa47e0
006AA47CC  adrp     x0, #0x8f39000
006AA47D0  ldr      x0, [x0, #0xcc0]
006AA47D4  bl       #0x382bd14 ; 
006AA47D8  mov      w8, #1
006AA47DC  strb     w8, [x21, #0x68a]
006AA47E0  adrp     x8, #0x8f39000
006AA47E4  ldr      x8, [x8, #0xcc0]
006AA47E8  ldr      x2, [x8]
006AA47EC  ldrb     w8, [x2, #0x53]
006AA47F0  tbnz     w8, #5, #0x6aa47fc
006AA47F4  str      w20, [x19, #0x30]
006AA47F8  b        #0x6aa480c ; 
006AA47FC  ldr      x8, [x2, #0x60]
006AA4800  mov      x0, x19
006AA4804  mov      w1, w20
006AA4808  blr      x8
006AA480C  mov      x0, x19
006AA4810  mov      x1, xzr
006AA4814  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA4818  adrp     x21, #0x959e000
006AA481C  ldrb     w8, [x21, #0x68b]
006AA4820  mov      x20, x0
006AA4824  cbnz     w8, #0x6aa483c
006AA4828  adrp     x0, #0x8f39000
006AA482C  ldr      x0, [x0, #0xcd0]
006AA4830  bl       #0x382bd14 ; 
006AA4834  mov      w8, #1
006AA4838  strb     w8, [x21, #0x68b]
006AA483C  adrp     x8, #0x8f39000
006AA4840  ldr      x8, [x8, #0xcd0]
006AA4844  ldr      x2, [x8]
006AA4848  ldrb     w8, [x2, #0x53]
006AA484C  tbnz     w8, #5, #0x6aa4864
006AA4850  mov      x0, x19
006AA4854  str      x20, [x0, #0x38]!
006AA4858  mov      x1, x20
006AA485C  bl       #0x382bcb8 ; 
006AA4860  b        #0x6aa4874 ; 
006AA4864  ldr      x8, [x2, #0x60]
006AA4868  mov      x0, x19
006AA486C  mov      x1, x20
006AA4870  blr      x8
006AA4874  mov      x0, x19
006AA4878  mov      x1, xzr
006AA487C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA4880  adrp     x21, #0x959e000
006AA4884  ldrb     w8, [x21, #0x68c]
006AA4888  mov      w20, w0
006AA488C  cbnz     w8, #0x6aa48a4
006AA4890  adrp     x0, #0x8f39000
006AA4894  ldr      x0, [x0, #0xce0]
006AA4898  bl       #0x382bd14 ; 
006AA489C  mov      w8, #1
006AA48A0  strb     w8, [x21, #0x68c]
006AA48A4  adrp     x8, #0x8f39000
006AA48A8  ldr      x8, [x8, #0xce0]
006AA48AC  ldr      x2, [x8]
006AA48B0  ldrb     w8, [x2, #0x53]
006AA48B4  tbnz     w8, #5, #0x6aa48c0
006AA48B8  str      w20, [x19, #0x40]
006AA48BC  b        #0x6aa48d0 ; 
006AA48C0  ldr      x8, [x2, #0x60]
006AA48C4  mov      x0, x19
006AA48C8  mov      w1, w20
006AA48CC  blr      x8
006AA48D0  mov      x0, x19
006AA48D4  mov      x1, xzr
006AA48D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA48DC  adrp     x21, #0x959e000
006AA48E0  ldrb     w8, [x21, #0x68d]
006AA48E4  mov      w20, w0
006AA48E8  cbnz     w8, #0x6aa4900
006AA48EC  adrp     x0, #0x8f39000
006AA48F0  ldr      x0, [x0, #0xcf0]
006AA48F4  bl       #0x382bd14 ; 
006AA48F8  mov      w8, #1
006AA48FC  strb     w8, [x21, #0x68d]
006AA4900  adrp     x8, #0x8f39000
006AA4904  ldr      x8, [x8, #0xcf0]
006AA4908  ldr      x2, [x8]
006AA490C  ldrb     w8, [x2, #0x53]
006AA4910  tbnz     w8, #5, #0x6aa491c
006AA4914  str      w20, [x19, #0x44]
006AA4918  b        #0x6aa492c ; 
006AA491C  ldr      x8, [x2, #0x60]
006AA4920  mov      x0, x19
006AA4924  mov      w1, w20
006AA4928  blr      x8
006AA492C  mov      x0, x19
006AA4930  mov      x1, xzr
006AA4934  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA4938  adrp     x21, #0x959e000
006AA493C  ldrb     w8, [x21, #0x68e]
006AA4940  mov      w20, w0
006AA4944  cbnz     w8, #0x6aa495c
006AA4948  adrp     x0, #0x8f39000
006AA494C  ldr      x0, [x0, #0xd00]
006AA4950  bl       #0x382bd14 ; 
006AA4954  mov      w8, #1
006AA4958  strb     w8, [x21, #0x68e]
006AA495C  adrp     x8, #0x8f39000
006AA4960  ldr      x8, [x8, #0xd00]
006AA4964  ldr      x2, [x8]
006AA4968  ldrb     w8, [x2, #0x53]
006AA496C  tbnz     w8, #5, #0x6aa4978
006AA4970  str      w20, [x19, #0x48]
006AA4974  b        #0x6aa4988 ; 
006AA4978  ldr      x8, [x2, #0x60]
006AA497C  mov      x0, x19
006AA4980  mov      w1, w20
006AA4984  blr      x8
006AA4988  mov      x0, x19
006AA498C  mov      x1, xzr
006AA4990  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AA4994  adrp     x21, #0x959e000
006AA4998  ldrb     w8, [x21, #0x68f]
006AA499C  mov      x20, x0
006AA49A0  cbnz     w8, #0x6aa49b8
006AA49A4  adrp     x0, #0x8f39000
006AA49A8  ldr      x0, [x0, #0xd10]
006AA49AC  bl       #0x382bd14 ; 
006AA49B0  mov      w8, #1
006AA49B4  strb     w8, [x21, #0x68f]
006AA49B8  adrp     x8, #0x8f39000
006AA49BC  ldr      x8, [x8, #0xd10]
006AA49C0  ldr      x2, [x8]
006AA49C4  ldrb     w8, [x2, #0x53]
006AA49C8  tbnz     w8, #5, #0x6aa49e0
006AA49CC  mov      x0, x19
006AA49D0  str      x20, [x0, #0x50]!
006AA49D4  mov      x1, x20
006AA49D8  bl       #0x382bcb8 ; 
006AA49DC  b        #0x6aa49f0 ; 
006AA49E0  ldr      x8, [x2, #0x60]
006AA49E4  mov      x0, x19
006AA49E8  mov      x1, x20
006AA49EC  blr      x8
006AA49F0  mov      x0, x19
006AA49F4  mov      x1, xzr
006AA49F8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA49FC  adrp     x21, #0x959e000
006AA4A00  ldrb     w8, [x21, #0x690]
006AA4A04  mov      x20, x0
006AA4A08  cbnz     w8, #0x6aa4a20
006AA4A0C  adrp     x0, #0x8f39000
006AA4A10  ldr      x0, [x0, #0xd20]
006AA4A14  bl       #0x382bd14 ; 
006AA4A18  mov      w8, #1
006AA4A1C  strb     w8, [x21, #0x690]
006AA4A20  adrp     x8, #0x8f39000
006AA4A24  ldr      x8, [x8, #0xd20]
006AA4A28  ldr      x2, [x8]
006AA4A2C  ldrb     w8, [x2, #0x53]
006AA4A30  tbnz     w8, #5, #0x6aa4a48
006AA4A34  mov      x0, x19
006AA4A38  str      x20, [x0, #0x58]!
006AA4A3C  mov      x1, x20
006AA4A40  bl       #0x382bcb8 ; 
006AA4A44  b        #0x6aa4a58 ; 
006AA4A48  ldr      x8, [x2, #0x60]
006AA4A4C  mov      x0, x19
006AA4A50  mov      x1, x20
006AA4A54  blr      x8
006AA4A58  mov      x0, x19
006AA4A5C  mov      x1, xzr
006AA4A60  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA4A64  adrp     x21, #0x959e000
006AA4A68  ldrb     w8, [x21, #0x691]
006AA4A6C  mov      x20, x0
006AA4A70  cbnz     w8, #0x6aa4a88
006AA4A74  adrp     x0, #0x8f39000
006AA4A78  ldr      x0, [x0, #0xd30]
006AA4A7C  bl       #0x382bd14 ; 
006AA4A80  mov      w8, #1
006AA4A84  strb     w8, [x21, #0x691]
006AA4A88  adrp     x8, #0x8f39000
006AA4A8C  ldr      x8, [x8, #0xd30]
006AA4A90  ldr      x2, [x8]
006AA4A94  ldrb     w8, [x2, #0x53]
006AA4A98  tbnz     w8, #5, #0x6aa4ab0
006AA4A9C  mov      x0, x19
006AA4AA0  str      x20, [x0, #0x60]!
006AA4AA4  mov      x1, x20
006AA4AA8  bl       #0x382bcb8 ; 
006AA4AAC  b        #0x6aa4ac0 ; 
006AA4AB0  ldr      x8, [x2, #0x60]
006AA4AB4  mov      x0, x19
006AA4AB8  mov      x1, x20
006AA4ABC  blr      x8
006AA4AC0  mov      x0, x19
006AA4AC4  mov      x1, xzr
006AA4AC8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA4ACC  adrp     x21, #0x959e000
006AA4AD0  ldrb     w8, [x21, #0x692]
006AA4AD4  mov      x20, x0
006AA4AD8  cbnz     w8, #0x6aa4af0
006AA4ADC  adrp     x0, #0x8f39000
006AA4AE0  ldr      x0, [x0, #0xd40]
006AA4AE4  bl       #0x382bd14 ; 
006AA4AE8  mov      w8, #1
006AA4AEC  strb     w8, [x21, #0x692]
006AA4AF0  adrp     x8, #0x8f39000
006AA4AF4  ldr      x8, [x8, #0xd40]
006AA4AF8  ldr      x2, [x8]
006AA4AFC  ldrb     w8, [x2, #0x53]
006AA4B00  tbnz     w8, #5, #0x6aa4b18
006AA4B04  mov      x0, x19
006AA4B08  str      x20, [x0, #0x68]!
006AA4B0C  mov      x1, x20
006AA4B10  bl       #0x382bcb8 ; 
006AA4B14  b        #0x6aa4b28 ; 
006AA4B18  ldr      x8, [x2, #0x60]
006AA4B1C  mov      x0, x19
006AA4B20  mov      x1, x20
006AA4B24  blr      x8
006AA4B28  mov      x0, x19
006AA4B2C  mov      x1, xzr
006AA4B30  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA4B34  adrp     x21, #0x959e000
006AA4B38  ldrb     w8, [x21, #0x693]
006AA4B3C  mov      x20, x0
006AA4B40  cbnz     w8, #0x6aa4b58
006AA4B44  adrp     x0, #0x8f39000
006AA4B48  ldr      x0, [x0, #0xd50]
006AA4B4C  bl       #0x382bd14 ; 
006AA4B50  mov      w8, #1
006AA4B54  strb     w8, [x21, #0x693]
006AA4B58  adrp     x8, #0x8f39000
006AA4B5C  ldr      x8, [x8, #0xd50]
006AA4B60  ldr      x2, [x8]
006AA4B64  ldrb     w8, [x2, #0x53]
006AA4B68  tbnz     w8, #5, #0x6aa4b80
006AA4B6C  mov      x0, x19
006AA4B70  str      x20, [x0, #0x70]!
006AA4B74  mov      x1, x20
006AA4B78  bl       #0x382bcb8 ; 
006AA4B7C  b        #0x6aa4b90 ; 
006AA4B80  ldr      x8, [x2, #0x60]
006AA4B84  mov      x0, x19
006AA4B88  mov      x1, x20
006AA4B8C  blr      x8
006AA4B90  mov      x0, x19
006AA4B94  mov      x1, xzr
006AA4B98  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA4B9C  adrp     x21, #0x959e000
006AA4BA0  ldrb     w8, [x21, #0x694]
006AA4BA4  mov      x20, x0
006AA4BA8  cbnz     w8, #0x6aa4bc0
006AA4BAC  adrp     x0, #0x8f39000
006AA4BB0  ldr      x0, [x0, #0xd60]
006AA4BB4  bl       #0x382bd14 ; 
006AA4BB8  mov      w8, #1
006AA4BBC  strb     w8, [x21, #0x694]
006AA4BC0  adrp     x8, #0x8f39000
006AA4BC4  ldr      x8, [x8, #0xd60]
006AA4BC8  ldr      x2, [x8]
006AA4BCC  ldrb     w8, [x2, #0x53]
006AA4BD0  tbnz     w8, #5, #0x6aa4be8
006AA4BD4  mov      x0, x19
006AA4BD8  str      x20, [x0, #0x78]!
006AA4BDC  mov      x1, x20
006AA4BE0  bl       #0x382bcb8 ; 
006AA4BE4  b        #0x6aa4bf8 ; 
006AA4BE8  ldr      x8, [x2, #0x60]
006AA4BEC  mov      x0, x19
006AA4BF0  mov      x1, x20
006AA4BF4  blr      x8
006AA4BF8  mov      x0, x19
006AA4BFC  mov      x1, xzr
006AA4C00  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA4C04  adrp     x21, #0x959e000
006AA4C08  ldrb     w8, [x21, #0x695]
006AA4C0C  mov      x20, x0
006AA4C10  cbnz     w8, #0x6aa4c28
006AA4C14  adrp     x0, #0x8f39000
006AA4C18  ldr      x0, [x0, #0xd70]
006AA4C1C  bl       #0x382bd14 ; 
006AA4C20  mov      w8, #1
006AA4C24  strb     w8, [x21, #0x695]
006AA4C28  adrp     x8, #0x8f39000
006AA4C2C  ldr      x8, [x8, #0xd70]
006AA4C30  ldr      x2, [x8]
006AA4C34  ldrb     w8, [x2, #0x53]
006AA4C38  tbnz     w8, #5, #0x6aa4c50
006AA4C3C  mov      x0, x19
006AA4C40  str      x20, [x0, #0x80]!
006AA4C44  mov      x1, x20
006AA4C48  bl       #0x382bcb8 ; 
006AA4C4C  b        #0x6aa4c60 ; 
006AA4C50  ldr      x8, [x2, #0x60]
006AA4C54  mov      x0, x19
006AA4C58  mov      x1, x20
006AA4C5C  blr      x8
006AA4C60  mov      x0, x19
006AA4C64  mov      x1, xzr
006AA4C68  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA4C6C  adrp     x21, #0x959e000
006AA4C70  ldrb     w8, [x21, #0x696]
006AA4C74  mov      x20, x0
006AA4C78  cbnz     w8, #0x6aa4c90
006AA4C7C  adrp     x0, #0x8f39000
006AA4C80  ldr      x0, [x0, #0xd80]
006AA4C84  bl       #0x382bd14 ; 
006AA4C88  mov      w8, #1
006AA4C8C  strb     w8, [x21, #0x696]
006AA4C90  adrp     x8, #0x8f39000
006AA4C94  ldr      x8, [x8, #0xd80]
006AA4C98  ldr      x2, [x8]
006AA4C9C  ldrb     w8, [x2, #0x53]
006AA4CA0  tbnz     w8, #5, #0x6aa4cb8
006AA4CA4  str      x20, [x19, #0x88]!
006AA4CA8  mov      x0, x19
006AA4CAC  mov      x1, x20
006AA4CB0  bl       #0x382bcb8 ; 
006AA4CB4  b        #0x6aa4cc8 ; 
006AA4CB8  ldr      x8, [x2, #0x60]
006AA4CBC  mov      x0, x19
006AA4CC0  mov      x1, x20
006AA4CC4  blr      x8
006AA4CC8  ldp      x20, x19, [sp, #0x10]
006AA4CCC  mov      w0, #1
006AA4CD0  ldp      x30, x21, [sp], #0x20
006AA4CD4  ret      

