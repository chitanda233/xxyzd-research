; LocalModels.Bean.MonsterAIPool_Rush$$readImpl
; RVA 0x6ACC754; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ACC754  stp      x30, x21, [sp, #-0x20]!
006ACC758  stp      x20, x19, [sp, #0x10]
006ACC75C  adrp     x20, #0x959e000
006ACC760  adrp     x21, #0x8f3b000
006ACC764  ldrb     w8, [x20, #0xaac]
006ACC768  ldr      x21, [x21, #0xaf8]
006ACC76C  mov      x19, x0
006ACC770  tbnz     w8, #0, #0x6acc788
006ACC774  adrp     x0, #0x8f3b000
006ACC778  ldr      x0, [x0, #0xaf8]
006ACC77C  bl       #0x382bd14 ; 
006ACC780  mov      w8, #1
006ACC784  strb     w8, [x20, #0xaac]
006ACC788  ldr      x1, [x21]
006ACC78C  ldrb     w8, [x1, #0x53]
006ACC790  tbnz     w8, #5, #0x6acc7e0
006ACC794  mov      x0, x19
006ACC798  mov      x1, xzr
006ACC79C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACC7A0  adrp     x21, #0x959f000
006ACC7A4  ldrb     w8, [x21, #0xb4]
006ACC7A8  mov      w20, w0
006ACC7AC  cbnz     w8, #0x6acc7c4
006ACC7B0  adrp     x0, #0x8f3b000
006ACC7B4  ldr      x0, [x0, #0xaa0]
006ACC7B8  bl       #0x382bd14 ; 
006ACC7BC  mov      w8, #1
006ACC7C0  strb     w8, [x21, #0xb4]
006ACC7C4  adrp     x8, #0x8f3b000
006ACC7C8  ldr      x8, [x8, #0xaa0]
006ACC7CC  ldr      x2, [x8]
006ACC7D0  ldrb     w8, [x2, #0x53]
006ACC7D4  tbnz     w8, #5, #0x6acc7f4
006ACC7D8  str      w20, [x19, #0x20]
006ACC7DC  b        #0x6acc804 ; 
006ACC7E0  ldr      x2, [x1, #0x60]
006ACC7E4  mov      x0, x19
006ACC7E8  ldp      x20, x19, [sp, #0x10]
006ACC7EC  ldp      x30, x21, [sp], #0x20
006ACC7F0  br       x2
006ACC7F4  ldr      x8, [x2, #0x60]
006ACC7F8  mov      x0, x19
006ACC7FC  mov      w1, w20
006ACC800  blr      x8
006ACC804  mov      x0, x19
006ACC808  mov      x1, xzr
006ACC80C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACC810  adrp     x21, #0x959f000
006ACC814  ldrb     w8, [x21, #0xb5]
006ACC818  mov      w20, w0
006ACC81C  cbnz     w8, #0x6acc834
006ACC820  adrp     x0, #0x8f3b000
006ACC824  ldr      x0, [x0, #0xaa8]
006ACC828  bl       #0x382bd14 ; 
006ACC82C  mov      w8, #1
006ACC830  strb     w8, [x21, #0xb5]
006ACC834  adrp     x8, #0x8f3b000
006ACC838  ldr      x8, [x8, #0xaa8]
006ACC83C  ldr      x2, [x8]
006ACC840  ldrb     w8, [x2, #0x53]
006ACC844  tbnz     w8, #5, #0x6acc850
006ACC848  str      w20, [x19, #0x24]
006ACC84C  b        #0x6acc860 ; 
006ACC850  ldr      x8, [x2, #0x60]
006ACC854  mov      x0, x19
006ACC858  mov      w1, w20
006ACC85C  blr      x8
006ACC860  mov      x0, x19
006ACC864  mov      x1, xzr
006ACC868  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACC86C  adrp     x21, #0x959f000
006ACC870  ldrb     w8, [x21, #0xb6]
006ACC874  mov      w20, w0
006ACC878  cbnz     w8, #0x6acc890
006ACC87C  adrp     x0, #0x8f3b000
006ACC880  ldr      x0, [x0, #0xab0]
006ACC884  bl       #0x382bd14 ; 
006ACC888  mov      w8, #1
006ACC88C  strb     w8, [x21, #0xb6]
006ACC890  adrp     x8, #0x8f3b000
006ACC894  ldr      x8, [x8, #0xab0]
006ACC898  ldr      x2, [x8]
006ACC89C  ldrb     w8, [x2, #0x53]
006ACC8A0  tbnz     w8, #5, #0x6acc8ac
006ACC8A4  str      w20, [x19, #0x28]
006ACC8A8  b        #0x6acc8bc ; 
006ACC8AC  ldr      x8, [x2, #0x60]
006ACC8B0  mov      x0, x19
006ACC8B4  mov      w1, w20
006ACC8B8  blr      x8
006ACC8BC  mov      x0, x19
006ACC8C0  mov      x1, xzr
006ACC8C4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006ACC8C8  adrp     x21, #0x959f000
006ACC8CC  ldrb     w8, [x21, #0xb7]
006ACC8D0  mov      x20, x0
006ACC8D4  cbnz     w8, #0x6acc8ec
006ACC8D8  adrp     x0, #0x8f3b000
006ACC8DC  ldr      x0, [x0, #0xab8]
006ACC8E0  bl       #0x382bd14 ; 
006ACC8E4  mov      w8, #1
006ACC8E8  strb     w8, [x21, #0xb7]
006ACC8EC  adrp     x8, #0x8f3b000
006ACC8F0  ldr      x8, [x8, #0xab8]
006ACC8F4  ldr      x2, [x8]
006ACC8F8  ldrb     w8, [x2, #0x53]
006ACC8FC  tbnz     w8, #5, #0x6acc914
006ACC900  mov      x0, x19
006ACC904  str      x20, [x0, #0x30]!
006ACC908  mov      x1, x20
006ACC90C  bl       #0x382bcb8 ; 
006ACC910  b        #0x6acc924 ; 
006ACC914  ldr      x8, [x2, #0x60]
006ACC918  mov      x0, x19
006ACC91C  mov      x1, x20
006ACC920  blr      x8
006ACC924  mov      x0, x19
006ACC928  mov      x1, xzr
006ACC92C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ACC930  adrp     x21, #0x959f000
006ACC934  ldrb     w8, [x21, #0xb8]
006ACC938  mov      x20, x0
006ACC93C  cbnz     w8, #0x6acc954
006ACC940  adrp     x0, #0x8f3b000
006ACC944  ldr      x0, [x0, #0xac0]
006ACC948  bl       #0x382bd14 ; 
006ACC94C  mov      w8, #1
006ACC950  strb     w8, [x21, #0xb8]
006ACC954  adrp     x8, #0x8f3b000
006ACC958  ldr      x8, [x8, #0xac0]
006ACC95C  ldr      x2, [x8]
006ACC960  ldrb     w8, [x2, #0x53]
006ACC964  tbnz     w8, #5, #0x6acc970
006ACC968  str      x20, [x19, #0x38]
006ACC96C  b        #0x6acc980 ; 
006ACC970  ldr      x8, [x2, #0x60]
006ACC974  mov      x0, x19
006ACC978  mov      x1, x20
006ACC97C  blr      x8
006ACC980  mov      x0, x19
006ACC984  mov      x1, xzr
006ACC988  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACC98C  adrp     x21, #0x959f000
006ACC990  ldrb     w8, [x21, #0xb9]
006ACC994  mov      w20, w0
006ACC998  cbnz     w8, #0x6acc9b0
006ACC99C  adrp     x0, #0x8f3b000
006ACC9A0  ldr      x0, [x0, #0xac8]
006ACC9A4  bl       #0x382bd14 ; 
006ACC9A8  mov      w8, #1
006ACC9AC  strb     w8, [x21, #0xb9]
006ACC9B0  adrp     x8, #0x8f3b000
006ACC9B4  ldr      x8, [x8, #0xac8]
006ACC9B8  ldr      x2, [x8]
006ACC9BC  ldrb     w8, [x2, #0x53]
006ACC9C0  tbnz     w8, #5, #0x6acc9cc
006ACC9C4  str      w20, [x19, #0x40]
006ACC9C8  b        #0x6acc9dc ; 
006ACC9CC  ldr      x8, [x2, #0x60]
006ACC9D0  mov      x0, x19
006ACC9D4  mov      w1, w20
006ACC9D8  blr      x8
006ACC9DC  mov      x0, x19
006ACC9E0  mov      x1, xzr
006ACC9E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACC9E8  adrp     x21, #0x959f000
006ACC9EC  ldrb     w8, [x21, #0xba]
006ACC9F0  mov      w20, w0
006ACC9F4  cbnz     w8, #0x6acca0c
006ACC9F8  adrp     x0, #0x8f3b000
006ACC9FC  ldr      x0, [x0, #0xad0]
006ACCA00  bl       #0x382bd14 ; 
006ACCA04  mov      w8, #1
006ACCA08  strb     w8, [x21, #0xba]
006ACCA0C  adrp     x8, #0x8f3b000
006ACCA10  ldr      x8, [x8, #0xad0]
006ACCA14  ldr      x2, [x8]
006ACCA18  ldrb     w8, [x2, #0x53]
006ACCA1C  tbnz     w8, #5, #0x6acca28
006ACCA20  str      w20, [x19, #0x44]
006ACCA24  b        #0x6acca38 ; 
006ACCA28  ldr      x8, [x2, #0x60]
006ACCA2C  mov      x0, x19
006ACCA30  mov      w1, w20
006ACCA34  blr      x8
006ACCA38  mov      x0, x19
006ACCA3C  mov      x1, xzr
006ACCA40  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACCA44  adrp     x21, #0x959f000
006ACCA48  ldrb     w8, [x21, #0xbb]
006ACCA4C  mov      w20, w0
006ACCA50  cbnz     w8, #0x6acca68
006ACCA54  adrp     x0, #0x8f3b000
006ACCA58  ldr      x0, [x0, #0xad8]
006ACCA5C  bl       #0x382bd14 ; 
006ACCA60  mov      w8, #1
006ACCA64  strb     w8, [x21, #0xbb]
006ACCA68  adrp     x8, #0x8f3b000
006ACCA6C  ldr      x8, [x8, #0xad8]
006ACCA70  ldr      x2, [x8]
006ACCA74  ldrb     w8, [x2, #0x53]
006ACCA78  tbnz     w8, #5, #0x6acca84
006ACCA7C  str      w20, [x19, #0x48]
006ACCA80  b        #0x6acca94 ; 
006ACCA84  ldr      x8, [x2, #0x60]
006ACCA88  mov      x0, x19
006ACCA8C  mov      w1, w20
006ACCA90  blr      x8
006ACCA94  mov      x0, x19
006ACCA98  mov      x1, xzr
006ACCA9C  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ACCAA0  adrp     x21, #0x959f000
006ACCAA4  ldrb     w8, [x21, #0xbc]
006ACCAA8  mov      x20, x0
006ACCAAC  cbnz     w8, #0x6accac4
006ACCAB0  adrp     x0, #0x8f3b000
006ACCAB4  ldr      x0, [x0, #0xae0]
006ACCAB8  bl       #0x382bd14 ; 
006ACCABC  mov      w8, #1
006ACCAC0  strb     w8, [x21, #0xbc]
006ACCAC4  adrp     x8, #0x8f3b000
006ACCAC8  ldr      x8, [x8, #0xae0]
006ACCACC  ldr      x2, [x8]
006ACCAD0  ldrb     w8, [x2, #0x53]
006ACCAD4  tbnz     w8, #5, #0x6accae0
006ACCAD8  str      x20, [x19, #0x50]
006ACCADC  b        #0x6accaf0 ; 
006ACCAE0  ldr      x8, [x2, #0x60]
006ACCAE4  mov      x0, x19
006ACCAE8  mov      x1, x20
006ACCAEC  blr      x8
006ACCAF0  mov      x0, x19
006ACCAF4  mov      x1, xzr
006ACCAF8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACCAFC  adrp     x21, #0x959f000
006ACCB00  ldrb     w8, [x21, #0xbd]
006ACCB04  mov      w20, w0
006ACCB08  cbnz     w8, #0x6accb20
006ACCB0C  adrp     x0, #0x8f3b000
006ACCB10  ldr      x0, [x0, #0xae8]
006ACCB14  bl       #0x382bd14 ; 
006ACCB18  mov      w8, #1
006ACCB1C  strb     w8, [x21, #0xbd]
006ACCB20  adrp     x8, #0x8f3b000
006ACCB24  ldr      x8, [x8, #0xae8]
006ACCB28  ldr      x2, [x8]
006ACCB2C  ldrb     w8, [x2, #0x53]
006ACCB30  tbnz     w8, #5, #0x6accb3c
006ACCB34  str      w20, [x19, #0x58]
006ACCB38  b        #0x6accb4c ; 
006ACCB3C  ldr      x8, [x2, #0x60]
006ACCB40  mov      x0, x19
006ACCB44  mov      w1, w20
006ACCB48  blr      x8
006ACCB4C  mov      x0, x19
006ACCB50  mov      x1, xzr
006ACCB54  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
006ACCB58  adrp     x21, #0x959f000
006ACCB5C  ldrb     w8, [x21, #0xbe]
006ACCB60  mov      x20, x0
006ACCB64  cbnz     w8, #0x6accb7c
006ACCB68  adrp     x0, #0x8f3b000
006ACCB6C  ldr      x0, [x0, #0xaf0]
006ACCB70  bl       #0x382bd14 ; 
006ACCB74  mov      w8, #1
006ACCB78  strb     w8, [x21, #0xbe]
006ACCB7C  adrp     x8, #0x8f3b000
006ACCB80  ldr      x8, [x8, #0xaf0]
006ACCB84  ldr      x2, [x8]
006ACCB88  ldrb     w8, [x2, #0x53]
006ACCB8C  tbnz     w8, #5, #0x6accb98
006ACCB90  str      x20, [x19, #0x60]
006ACCB94  b        #0x6accba8 ; 
006ACCB98  ldr      x8, [x2, #0x60]
006ACCB9C  mov      x0, x19
006ACCBA0  mov      x1, x20
006ACCBA4  blr      x8
006ACCBA8  ldp      x20, x19, [sp, #0x10]
006ACCBAC  mov      w0, #1
006ACCBB0  ldp      x30, x21, [sp], #0x20
006ACCBB4  ret      

