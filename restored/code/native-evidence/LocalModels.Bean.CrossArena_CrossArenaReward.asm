; LocalModels.Bean.CrossArena_CrossArenaReward$$readImpl
; RVA 0x6A54ABC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A54ABC  stp      x30, x21, [sp, #-0x20]!
006A54AC0  stp      x20, x19, [sp, #0x10]
006A54AC4  adrp     x20, #0x959d000
006A54AC8  adrp     x21, #0x8f36000
006A54ACC  ldrb     w8, [x20, #0xac1]
006A54AD0  ldr      x21, [x21, #0x108]
006A54AD4  mov      x19, x0
006A54AD8  tbnz     w8, #0, #0x6a54af0
006A54ADC  adrp     x0, #0x8f36000
006A54AE0  ldr      x0, [x0, #0x108]
006A54AE4  bl       #0x382bd14 ; 
006A54AE8  mov      w8, #1
006A54AEC  strb     w8, [x20, #0xac1]
006A54AF0  ldr      x1, [x21]
006A54AF4  ldrb     w8, [x1, #0x53]
006A54AF8  tbnz     w8, #5, #0x6a54b48
006A54AFC  mov      x0, x19
006A54B00  mov      x1, xzr
006A54B04  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A54B08  adrp     x21, #0x959e000
006A54B0C  ldrb     w8, [x21, #0x31a]
006A54B10  mov      w20, w0
006A54B14  cbnz     w8, #0x6a54b2c
006A54B18  adrp     x0, #0x8f36000
006A54B1C  ldr      x0, [x0, #0xc0]
006A54B20  bl       #0x382bd14 ; 
006A54B24  mov      w8, #1
006A54B28  strb     w8, [x21, #0x31a]
006A54B2C  adrp     x8, #0x8f36000
006A54B30  ldr      x8, [x8, #0xc0]
006A54B34  ldr      x2, [x8]
006A54B38  ldrb     w8, [x2, #0x53]
006A54B3C  tbnz     w8, #5, #0x6a54b5c
006A54B40  str      w20, [x19, #0x20]
006A54B44  b        #0x6a54b6c ; 
006A54B48  ldr      x2, [x1, #0x60]
006A54B4C  mov      x0, x19
006A54B50  ldp      x20, x19, [sp, #0x10]
006A54B54  ldp      x30, x21, [sp], #0x20
006A54B58  br       x2
006A54B5C  ldr      x8, [x2, #0x60]
006A54B60  mov      x0, x19
006A54B64  mov      w1, w20
006A54B68  blr      x8
006A54B6C  mov      x0, x19
006A54B70  mov      x1, xzr
006A54B74  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A54B78  adrp     x21, #0x959e000
006A54B7C  ldrb     w8, [x21, #0x31b]
006A54B80  mov      w20, w0
006A54B84  cbnz     w8, #0x6a54b9c
006A54B88  adrp     x0, #0x8f36000
006A54B8C  ldr      x0, [x0, #0xd0]
006A54B90  bl       #0x382bd14 ; 
006A54B94  mov      w8, #1
006A54B98  strb     w8, [x21, #0x31b]
006A54B9C  adrp     x8, #0x8f36000
006A54BA0  ldr      x8, [x8, #0xd0]
006A54BA4  ldr      x2, [x8]
006A54BA8  ldrb     w8, [x2, #0x53]
006A54BAC  tbnz     w8, #5, #0x6a54bb8
006A54BB0  str      w20, [x19, #0x24]
006A54BB4  b        #0x6a54bc8 ; 
006A54BB8  ldr      x8, [x2, #0x60]
006A54BBC  mov      x0, x19
006A54BC0  mov      w1, w20
006A54BC4  blr      x8
006A54BC8  mov      x0, x19
006A54BCC  mov      x1, xzr
006A54BD0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A54BD4  adrp     x21, #0x959e000
006A54BD8  ldrb     w8, [x21, #0x31c]
006A54BDC  mov      x20, x0
006A54BE0  cbnz     w8, #0x6a54bf8
006A54BE4  adrp     x0, #0x8f36000
006A54BE8  ldr      x0, [x0, #0xe0]
006A54BEC  bl       #0x382bd14 ; 
006A54BF0  mov      w8, #1
006A54BF4  strb     w8, [x21, #0x31c]
006A54BF8  adrp     x8, #0x8f36000
006A54BFC  ldr      x8, [x8, #0xe0]
006A54C00  ldr      x2, [x8]
006A54C04  ldrb     w8, [x2, #0x53]
006A54C08  tbnz     w8, #5, #0x6a54c20
006A54C0C  mov      x0, x19
006A54C10  str      x20, [x0, #0x28]!
006A54C14  mov      x1, x20
006A54C18  bl       #0x382bcb8 ; 
006A54C1C  b        #0x6a54c30 ; 
006A54C20  ldr      x8, [x2, #0x60]
006A54C24  mov      x0, x19
006A54C28  mov      x1, x20
006A54C2C  blr      x8
006A54C30  mov      x0, x19
006A54C34  mov      x1, xzr
006A54C38  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A54C3C  adrp     x21, #0x959e000
006A54C40  ldrb     w8, [x21, #0x31d]
006A54C44  mov      x20, x0
006A54C48  cbnz     w8, #0x6a54c60
006A54C4C  adrp     x0, #0x8f36000
006A54C50  ldr      x0, [x0, #0xf0]
006A54C54  bl       #0x382bd14 ; 
006A54C58  mov      w8, #1
006A54C5C  strb     w8, [x21, #0x31d]
006A54C60  adrp     x8, #0x8f36000
006A54C64  ldr      x8, [x8, #0xf0]
006A54C68  ldr      x2, [x8]
006A54C6C  ldrb     w8, [x2, #0x53]
006A54C70  tbnz     w8, #5, #0x6a54c88
006A54C74  mov      x0, x19
006A54C78  str      x20, [x0, #0x30]!
006A54C7C  mov      x1, x20
006A54C80  bl       #0x382bcb8 ; 
006A54C84  b        #0x6a54c98 ; 
006A54C88  ldr      x8, [x2, #0x60]
006A54C8C  mov      x0, x19
006A54C90  mov      x1, x20
006A54C94  blr      x8
006A54C98  mov      x0, x19
006A54C9C  mov      x1, xzr
006A54CA0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A54CA4  adrp     x21, #0x959e000
006A54CA8  ldrb     w8, [x21, #0x31e]
006A54CAC  mov      x20, x0
006A54CB0  cbnz     w8, #0x6a54cc8
006A54CB4  adrp     x0, #0x8f36000
006A54CB8  ldr      x0, [x0, #0x100]
006A54CBC  bl       #0x382bd14 ; 
006A54CC0  mov      w8, #1
006A54CC4  strb     w8, [x21, #0x31e]
006A54CC8  adrp     x8, #0x8f36000
006A54CCC  ldr      x8, [x8, #0x100]
006A54CD0  ldr      x2, [x8]
006A54CD4  ldrb     w8, [x2, #0x53]
006A54CD8  tbnz     w8, #5, #0x6a54cf0
006A54CDC  str      x20, [x19, #0x38]!
006A54CE0  mov      x0, x19
006A54CE4  mov      x1, x20
006A54CE8  bl       #0x382bcb8 ; 
006A54CEC  b        #0x6a54d00 ; 
006A54CF0  ldr      x8, [x2, #0x60]
006A54CF4  mov      x0, x19
006A54CF8  mov      x1, x20
006A54CFC  blr      x8
006A54D00  ldp      x20, x19, [sp, #0x10]
006A54D04  mov      w0, #1
006A54D08  ldp      x30, x21, [sp], #0x20
006A54D0C  ret      

