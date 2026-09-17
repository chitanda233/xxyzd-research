; LocalModels.Bean.MonsterAIPool_Call$$readImpl
; RVA 0x6ACB7F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ACB7F8  stp      x30, x21, [sp, #-0x20]!
006ACB7FC  stp      x20, x19, [sp, #0x10]
006ACB800  adrp     x20, #0x959e000
006ACB804  adrp     x21, #0x8f3b000
006ACB808  ldrb     w8, [x20, #0xa93]
006ACB80C  ldr      x21, [x21, #0xa88]
006ACB810  mov      x19, x0
006ACB814  tbnz     w8, #0, #0x6acb82c
006ACB818  adrp     x0, #0x8f3b000
006ACB81C  ldr      x0, [x0, #0xa88]
006ACB820  bl       #0x382bd14 ; 
006ACB824  mov      w8, #1
006ACB828  strb     w8, [x20, #0xa93]
006ACB82C  ldr      x1, [x21]
006ACB830  ldrb     w8, [x1, #0x53]
006ACB834  tbnz     w8, #5, #0x6acb884
006ACB838  mov      x0, x19
006ACB83C  mov      x1, xzr
006ACB840  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACB844  adrp     x21, #0x959f000
006ACB848  ldrb     w8, [x21, #0xa8]
006ACB84C  mov      w20, w0
006ACB850  cbnz     w8, #0x6acb868
006ACB854  adrp     x0, #0x8f3b000
006ACB858  ldr      x0, [x0, #0xa20]
006ACB85C  bl       #0x382bd14 ; 
006ACB860  mov      w8, #1
006ACB864  strb     w8, [x21, #0xa8]
006ACB868  adrp     x8, #0x8f3b000
006ACB86C  ldr      x8, [x8, #0xa20]
006ACB870  ldr      x2, [x8]
006ACB874  ldrb     w8, [x2, #0x53]
006ACB878  tbnz     w8, #5, #0x6acb898
006ACB87C  str      w20, [x19, #0x20]
006ACB880  b        #0x6acb8a8 ; 
006ACB884  ldr      x2, [x1, #0x60]
006ACB888  mov      x0, x19
006ACB88C  ldp      x20, x19, [sp, #0x10]
006ACB890  ldp      x30, x21, [sp], #0x20
006ACB894  br       x2
006ACB898  ldr      x8, [x2, #0x60]
006ACB89C  mov      x0, x19
006ACB8A0  mov      w1, w20
006ACB8A4  blr      x8
006ACB8A8  mov      x0, x19
006ACB8AC  mov      x1, xzr
006ACB8B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACB8B4  adrp     x21, #0x959f000
006ACB8B8  ldrb     w8, [x21, #0xa9]
006ACB8BC  mov      w20, w0
006ACB8C0  cbnz     w8, #0x6acb8d8
006ACB8C4  adrp     x0, #0x8f3b000
006ACB8C8  ldr      x0, [x0, #0xa30]
006ACB8CC  bl       #0x382bd14 ; 
006ACB8D0  mov      w8, #1
006ACB8D4  strb     w8, [x21, #0xa9]
006ACB8D8  adrp     x8, #0x8f3b000
006ACB8DC  ldr      x8, [x8, #0xa30]
006ACB8E0  ldr      x2, [x8]
006ACB8E4  ldrb     w8, [x2, #0x53]
006ACB8E8  tbnz     w8, #5, #0x6acb8f4
006ACB8EC  str      w20, [x19, #0x24]
006ACB8F0  b        #0x6acb904 ; 
006ACB8F4  ldr      x8, [x2, #0x60]
006ACB8F8  mov      x0, x19
006ACB8FC  mov      w1, w20
006ACB900  blr      x8
006ACB904  mov      x0, x19
006ACB908  mov      x1, xzr
006ACB90C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ACB910  adrp     x21, #0x959f000
006ACB914  ldrb     w8, [x21, #0xaa]
006ACB918  mov      x20, x0
006ACB91C  cbnz     w8, #0x6acb934
006ACB920  adrp     x0, #0x8f3b000
006ACB924  ldr      x0, [x0, #0xa38]
006ACB928  bl       #0x382bd14 ; 
006ACB92C  mov      w8, #1
006ACB930  strb     w8, [x21, #0xaa]
006ACB934  adrp     x8, #0x8f3b000
006ACB938  ldr      x8, [x8, #0xa38]
006ACB93C  ldr      x2, [x8]
006ACB940  ldrb     w8, [x2, #0x53]
006ACB944  tbnz     w8, #5, #0x6acb950
006ACB948  str      x20, [x19, #0x28]
006ACB94C  b        #0x6acb960 ; 
006ACB950  ldr      x8, [x2, #0x60]
006ACB954  mov      x0, x19
006ACB958  mov      x1, x20
006ACB95C  blr      x8
006ACB960  mov      x0, x19
006ACB964  mov      x1, xzr
006ACB968  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACB96C  adrp     x21, #0x959f000
006ACB970  ldrb     w8, [x21, #0xab]
006ACB974  mov      w20, w0
006ACB978  cbnz     w8, #0x6acb990
006ACB97C  adrp     x0, #0x8f3b000
006ACB980  ldr      x0, [x0, #0xa40]
006ACB984  bl       #0x382bd14 ; 
006ACB988  mov      w8, #1
006ACB98C  strb     w8, [x21, #0xab]
006ACB990  adrp     x8, #0x8f3b000
006ACB994  ldr      x8, [x8, #0xa40]
006ACB998  ldr      x2, [x8]
006ACB99C  ldrb     w8, [x2, #0x53]
006ACB9A0  tbnz     w8, #5, #0x6acb9ac
006ACB9A4  str      w20, [x19, #0x30]
006ACB9A8  b        #0x6acb9bc ; 
006ACB9AC  ldr      x8, [x2, #0x60]
006ACB9B0  mov      x0, x19
006ACB9B4  mov      w1, w20
006ACB9B8  blr      x8
006ACB9BC  mov      x0, x19
006ACB9C0  mov      x1, xzr
006ACB9C4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ACB9C8  adrp     x21, #0x959f000
006ACB9CC  ldrb     w8, [x21, #0xac]
006ACB9D0  mov      x20, x0
006ACB9D4  cbnz     w8, #0x6acb9ec
006ACB9D8  adrp     x0, #0x8f3b000
006ACB9DC  ldr      x0, [x0, #0xa48]
006ACB9E0  bl       #0x382bd14 ; 
006ACB9E4  mov      w8, #1
006ACB9E8  strb     w8, [x21, #0xac]
006ACB9EC  adrp     x8, #0x8f3b000
006ACB9F0  ldr      x8, [x8, #0xa48]
006ACB9F4  ldr      x2, [x8]
006ACB9F8  ldrb     w8, [x2, #0x53]
006ACB9FC  tbnz     w8, #5, #0x6acba08
006ACBA00  str      x20, [x19, #0x38]
006ACBA04  b        #0x6acba18 ; 
006ACBA08  ldr      x8, [x2, #0x60]
006ACBA0C  mov      x0, x19
006ACBA10  mov      x1, x20
006ACBA14  blr      x8
006ACBA18  mov      x0, x19
006ACBA1C  mov      x1, xzr
006ACBA20  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ACBA24  adrp     x21, #0x959f000
006ACBA28  ldrb     w8, [x21, #0xad]
006ACBA2C  mov      x20, x0
006ACBA30  cbnz     w8, #0x6acba48
006ACBA34  adrp     x0, #0x8f3b000
006ACBA38  ldr      x0, [x0, #0xa50]
006ACBA3C  bl       #0x382bd14 ; 
006ACBA40  mov      w8, #1
006ACBA44  strb     w8, [x21, #0xad]
006ACBA48  adrp     x8, #0x8f3b000
006ACBA4C  ldr      x8, [x8, #0xa50]
006ACBA50  ldr      x2, [x8]
006ACBA54  ldrb     w8, [x2, #0x53]
006ACBA58  tbnz     w8, #5, #0x6acba64
006ACBA5C  str      x20, [x19, #0x40]
006ACBA60  b        #0x6acba74 ; 
006ACBA64  ldr      x8, [x2, #0x60]
006ACBA68  mov      x0, x19
006ACBA6C  mov      x1, x20
006ACBA70  blr      x8
006ACBA74  mov      x0, x19
006ACBA78  mov      x1, xzr
006ACBA7C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ACBA80  adrp     x21, #0x959f000
006ACBA84  ldrb     w8, [x21, #0xae]
006ACBA88  mov      x20, x0
006ACBA8C  cbnz     w8, #0x6acbaa4
006ACBA90  adrp     x0, #0x8f3b000
006ACBA94  ldr      x0, [x0, #0xa58]
006ACBA98  bl       #0x382bd14 ; 
006ACBA9C  mov      w8, #1
006ACBAA0  strb     w8, [x21, #0xae]
006ACBAA4  adrp     x8, #0x8f3b000
006ACBAA8  ldr      x8, [x8, #0xa58]
006ACBAAC  ldr      x2, [x8]
006ACBAB0  ldrb     w8, [x2, #0x53]
006ACBAB4  tbnz     w8, #5, #0x6acbac0
006ACBAB8  str      x20, [x19, #0x48]
006ACBABC  b        #0x6acbad0 ; 
006ACBAC0  ldr      x8, [x2, #0x60]
006ACBAC4  mov      x0, x19
006ACBAC8  mov      x1, x20
006ACBACC  blr      x8
006ACBAD0  mov      x0, x19
006ACBAD4  mov      x1, xzr
006ACBAD8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACBADC  adrp     x21, #0x959f000
006ACBAE0  ldrb     w8, [x21, #0xaf]
006ACBAE4  mov      w20, w0
006ACBAE8  cbnz     w8, #0x6acbb00
006ACBAEC  adrp     x0, #0x8f3b000
006ACBAF0  ldr      x0, [x0, #0xa60]
006ACBAF4  bl       #0x382bd14 ; 
006ACBAF8  mov      w8, #1
006ACBAFC  strb     w8, [x21, #0xaf]
006ACBB00  adrp     x8, #0x8f3b000
006ACBB04  ldr      x8, [x8, #0xa60]
006ACBB08  ldr      x2, [x8]
006ACBB0C  ldrb     w8, [x2, #0x53]
006ACBB10  tbnz     w8, #5, #0x6acbb1c
006ACBB14  str      w20, [x19, #0x50]
006ACBB18  b        #0x6acbb2c ; 
006ACBB1C  ldr      x8, [x2, #0x60]
006ACBB20  mov      x0, x19
006ACBB24  mov      w1, w20
006ACBB28  blr      x8
006ACBB2C  mov      x0, x19
006ACBB30  mov      x1, xzr
006ACBB34  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ACBB38  adrp     x21, #0x959f000
006ACBB3C  ldrb     w8, [x21, #0xb0]
006ACBB40  mov      x20, x0
006ACBB44  cbnz     w8, #0x6acbb5c
006ACBB48  adrp     x0, #0x8f3b000
006ACBB4C  ldr      x0, [x0, #0xa68]
006ACBB50  bl       #0x382bd14 ; 
006ACBB54  mov      w8, #1
006ACBB58  strb     w8, [x21, #0xb0]
006ACBB5C  adrp     x8, #0x8f3b000
006ACBB60  ldr      x8, [x8, #0xa68]
006ACBB64  ldr      x2, [x8]
006ACBB68  ldrb     w8, [x2, #0x53]
006ACBB6C  tbnz     w8, #5, #0x6acbb84
006ACBB70  mov      x0, x19
006ACBB74  str      x20, [x0, #0x58]!
006ACBB78  mov      x1, x20
006ACBB7C  bl       #0x382bcb8 ; 
006ACBB80  b        #0x6acbb94 ; 
006ACBB84  ldr      x8, [x2, #0x60]
006ACBB88  mov      x0, x19
006ACBB8C  mov      x1, x20
006ACBB90  blr      x8
006ACBB94  mov      x0, x19
006ACBB98  mov      x1, xzr
006ACBB9C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006ACBBA0  adrp     x21, #0x959f000
006ACBBA4  ldrb     w8, [x21, #0xb1]
006ACBBA8  mov      x20, x0
006ACBBAC  cbnz     w8, #0x6acbbc4
006ACBBB0  adrp     x0, #0x8f3b000
006ACBBB4  ldr      x0, [x0, #0xa70]
006ACBBB8  bl       #0x382bd14 ; 
006ACBBBC  mov      w8, #1
006ACBBC0  strb     w8, [x21, #0xb1]
006ACBBC4  adrp     x8, #0x8f3b000
006ACBBC8  ldr      x8, [x8, #0xa70]
006ACBBCC  ldr      x2, [x8]
006ACBBD0  ldrb     w8, [x2, #0x53]
006ACBBD4  tbnz     w8, #5, #0x6acbbec
006ACBBD8  mov      x0, x19
006ACBBDC  str      x20, [x0, #0x60]!
006ACBBE0  mov      x1, x20
006ACBBE4  bl       #0x382bcb8 ; 
006ACBBE8  b        #0x6acbbfc ; 
006ACBBEC  ldr      x8, [x2, #0x60]
006ACBBF0  mov      x0, x19
006ACBBF4  mov      x1, x20
006ACBBF8  blr      x8
006ACBBFC  mov      x0, x19
006ACBC00  mov      x1, xzr
006ACBC04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACBC08  adrp     x21, #0x959f000
006ACBC0C  ldrb     w8, [x21, #0xb2]
006ACBC10  mov      w20, w0
006ACBC14  cbnz     w8, #0x6acbc2c
006ACBC18  adrp     x0, #0x8f3b000
006ACBC1C  ldr      x0, [x0, #0xa78]
006ACBC20  bl       #0x382bd14 ; 
006ACBC24  mov      w8, #1
006ACBC28  strb     w8, [x21, #0xb2]
006ACBC2C  adrp     x8, #0x8f3b000
006ACBC30  ldr      x8, [x8, #0xa78]
006ACBC34  ldr      x2, [x8]
006ACBC38  ldrb     w8, [x2, #0x53]
006ACBC3C  tbnz     w8, #5, #0x6acbc48
006ACBC40  str      w20, [x19, #0x68]
006ACBC44  b        #0x6acbc58 ; 
006ACBC48  ldr      x8, [x2, #0x60]
006ACBC4C  mov      x0, x19
006ACBC50  mov      w1, w20
006ACBC54  blr      x8
006ACBC58  mov      x0, x19
006ACBC5C  mov      x1, xzr
006ACBC60  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACBC64  adrp     x21, #0x959f000
006ACBC68  ldrb     w8, [x21, #0xb3]
006ACBC6C  mov      w20, w0
006ACBC70  cbnz     w8, #0x6acbc88
006ACBC74  adrp     x0, #0x8f3b000
006ACBC78  ldr      x0, [x0, #0xa80]
006ACBC7C  bl       #0x382bd14 ; 
006ACBC80  mov      w8, #1
006ACBC84  strb     w8, [x21, #0xb3]
006ACBC88  adrp     x8, #0x8f3b000
006ACBC8C  ldr      x8, [x8, #0xa80]
006ACBC90  ldr      x2, [x8]
006ACBC94  ldrb     w8, [x2, #0x53]
006ACBC98  tbnz     w8, #5, #0x6acbca4
006ACBC9C  str      w20, [x19, #0x6c]
006ACBCA0  b        #0x6acbcb4 ; 
006ACBCA4  ldr      x8, [x2, #0x60]
006ACBCA8  mov      x0, x19
006ACBCAC  mov      w1, w20
006ACBCB0  blr      x8
006ACBCB4  ldp      x20, x19, [sp, #0x10]
006ACBCB8  mov      w0, #1
006ACBCBC  ldp      x30, x21, [sp], #0x20
006ACBCC0  ret      

