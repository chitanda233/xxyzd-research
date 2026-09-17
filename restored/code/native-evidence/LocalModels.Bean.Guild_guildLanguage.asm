; LocalModels.Bean.Guild_guildLanguage$$readImpl
; RVA 0x6A928BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A928BC  stp      x30, x21, [sp, #-0x20]!
006A928C0  stp      x20, x19, [sp, #0x10]
006A928C4  adrp     x20, #0x959e000
006A928C8  adrp     x21, #0x8f38000
006A928CC  ldrb     w8, [x20, #0x12b]
006A928D0  ldr      x21, [x21, #0xf80]
006A928D4  mov      x19, x0
006A928D8  tbnz     w8, #0, #0x6a928f0
006A928DC  adrp     x0, #0x8f38000
006A928E0  ldr      x0, [x0, #0xf80]
006A928E4  bl       #0x382bd14 ; 
006A928E8  mov      w8, #1
006A928EC  strb     w8, [x20, #0x12b]
006A928F0  ldr      x1, [x21]
006A928F4  ldrb     w8, [x1, #0x53]
006A928F8  tbnz     w8, #5, #0x6a92948
006A928FC  mov      x0, x19
006A92900  mov      x1, xzr
006A92904  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A92908  adrp     x21, #0x959e000
006A9290C  ldrb     w8, [x21, #0x5c0]
006A92910  mov      w20, w0
006A92914  cbnz     w8, #0x6a9292c
006A92918  adrp     x0, #0x8f38000
006A9291C  ldr      x0, [x0, #0xf48]
006A92920  bl       #0x382bd14 ; 
006A92924  mov      w8, #1
006A92928  strb     w8, [x21, #0x5c0]
006A9292C  adrp     x8, #0x8f38000
006A92930  ldr      x8, [x8, #0xf48]
006A92934  ldr      x2, [x8]
006A92938  ldrb     w8, [x2, #0x53]
006A9293C  tbnz     w8, #5, #0x6a9295c
006A92940  str      w20, [x19, #0x20]
006A92944  b        #0x6a9296c ; 
006A92948  ldr      x2, [x1, #0x60]
006A9294C  mov      x0, x19
006A92950  ldp      x20, x19, [sp, #0x10]
006A92954  ldp      x30, x21, [sp], #0x20
006A92958  br       x2
006A9295C  ldr      x8, [x2, #0x60]
006A92960  mov      x0, x19
006A92964  mov      w1, w20
006A92968  blr      x8
006A9296C  mov      x0, x19
006A92970  mov      x1, xzr
006A92974  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A92978  adrp     x21, #0x959e000
006A9297C  ldrb     w8, [x21, #0x5c1]
006A92980  mov      x20, x0
006A92984  cbnz     w8, #0x6a9299c
006A92988  adrp     x0, #0x8f38000
006A9298C  ldr      x0, [x0, #0xf58]
006A92990  bl       #0x382bd14 ; 
006A92994  mov      w8, #1
006A92998  strb     w8, [x21, #0x5c1]
006A9299C  adrp     x8, #0x8f38000
006A929A0  ldr      x8, [x8, #0xf58]
006A929A4  ldr      x2, [x8]
006A929A8  ldrb     w8, [x2, #0x53]
006A929AC  tbnz     w8, #5, #0x6a929c4
006A929B0  mov      x0, x19
006A929B4  str      x20, [x0, #0x28]!
006A929B8  mov      x1, x20
006A929BC  bl       #0x382bcb8 ; 
006A929C0  b        #0x6a929d4 ; 
006A929C4  ldr      x8, [x2, #0x60]
006A929C8  mov      x0, x19
006A929CC  mov      x1, x20
006A929D0  blr      x8
006A929D4  mov      x0, x19
006A929D8  mov      x1, xzr
006A929DC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A929E0  adrp     x21, #0x959e000
006A929E4  ldrb     w8, [x21, #0x5c2]
006A929E8  mov      x20, x0
006A929EC  cbnz     w8, #0x6a92a04
006A929F0  adrp     x0, #0x8f38000
006A929F4  ldr      x0, [x0, #0xf68]
006A929F8  bl       #0x382bd14 ; 
006A929FC  mov      w8, #1
006A92A00  strb     w8, [x21, #0x5c2]
006A92A04  adrp     x8, #0x8f38000
006A92A08  ldr      x8, [x8, #0xf68]
006A92A0C  ldr      x2, [x8]
006A92A10  ldrb     w8, [x2, #0x53]
006A92A14  tbnz     w8, #5, #0x6a92a2c
006A92A18  mov      x0, x19
006A92A1C  str      x20, [x0, #0x30]!
006A92A20  mov      x1, x20
006A92A24  bl       #0x382bcb8 ; 
006A92A28  b        #0x6a92a3c ; 
006A92A2C  ldr      x8, [x2, #0x60]
006A92A30  mov      x0, x19
006A92A34  mov      x1, x20
006A92A38  blr      x8
006A92A3C  mov      x0, x19
006A92A40  mov      x1, xzr
006A92A44  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A92A48  adrp     x21, #0x959e000
006A92A4C  ldrb     w8, [x21, #0x5c3]
006A92A50  mov      x20, x0
006A92A54  cbnz     w8, #0x6a92a6c
006A92A58  adrp     x0, #0x8f38000
006A92A5C  ldr      x0, [x0, #0xf78]
006A92A60  bl       #0x382bd14 ; 
006A92A64  mov      w8, #1
006A92A68  strb     w8, [x21, #0x5c3]
006A92A6C  adrp     x8, #0x8f38000
006A92A70  ldr      x8, [x8, #0xf78]
006A92A74  ldr      x2, [x8]
006A92A78  ldrb     w8, [x2, #0x53]
006A92A7C  tbnz     w8, #5, #0x6a92a94
006A92A80  str      x20, [x19, #0x38]!
006A92A84  mov      x0, x19
006A92A88  mov      x1, x20
006A92A8C  bl       #0x382bcb8 ; 
006A92A90  b        #0x6a92aa4 ; 
006A92A94  ldr      x8, [x2, #0x60]
006A92A98  mov      x0, x19
006A92A9C  mov      x1, x20
006A92AA0  blr      x8
006A92AA4  ldp      x20, x19, [sp, #0x10]
006A92AA8  mov      w0, #1
006A92AAC  ldp      x30, x21, [sp], #0x20
006A92AB0  ret      

