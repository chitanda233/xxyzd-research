; LocalModels.Bean.Guild_guildBossOpen$$readImpl
; RVA 0x6A8E468; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A8E468  stp      x30, x21, [sp, #-0x20]!
006A8E46C  stp      x20, x19, [sp, #0x10]
006A8E470  adrp     x20, #0x959e000
006A8E474  adrp     x21, #0x8f38000
006A8E478  ldrb     w8, [x20, #0xb8]
006A8E47C  ldr      x21, [x21, #0xc38]
006A8E480  mov      x19, x0
006A8E484  tbnz     w8, #0, #0x6a8e49c
006A8E488  adrp     x0, #0x8f38000
006A8E48C  ldr      x0, [x0, #0xc38]
006A8E490  bl       #0x382bd14 ; 
006A8E494  mov      w8, #1
006A8E498  strb     w8, [x20, #0xb8]
006A8E49C  ldr      x1, [x21]
006A8E4A0  ldrb     w8, [x1, #0x53]
006A8E4A4  tbnz     w8, #5, #0x6a8e4f4
006A8E4A8  mov      x0, x19
006A8E4AC  mov      x1, xzr
006A8E4B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8E4B4  adrp     x21, #0x959e000
006A8E4B8  ldrb     w8, [x21, #0x594]
006A8E4BC  mov      w20, w0
006A8E4C0  cbnz     w8, #0x6a8e4d8
006A8E4C4  adrp     x0, #0x8f38000
006A8E4C8  ldr      x0, [x0, #0xc00]
006A8E4CC  bl       #0x382bd14 ; 
006A8E4D0  mov      w8, #1
006A8E4D4  strb     w8, [x21, #0x594]
006A8E4D8  adrp     x8, #0x8f38000
006A8E4DC  ldr      x8, [x8, #0xc00]
006A8E4E0  ldr      x2, [x8]
006A8E4E4  ldrb     w8, [x2, #0x53]
006A8E4E8  tbnz     w8, #5, #0x6a8e508
006A8E4EC  str      w20, [x19, #0x20]
006A8E4F0  b        #0x6a8e518 ; 
006A8E4F4  ldr      x2, [x1, #0x60]
006A8E4F8  mov      x0, x19
006A8E4FC  ldp      x20, x19, [sp, #0x10]
006A8E500  ldp      x30, x21, [sp], #0x20
006A8E504  br       x2
006A8E508  ldr      x8, [x2, #0x60]
006A8E50C  mov      x0, x19
006A8E510  mov      w1, w20
006A8E514  blr      x8
006A8E518  mov      x0, x19
006A8E51C  mov      x1, xzr
006A8E520  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A8E524  adrp     x21, #0x959e000
006A8E528  ldrb     w8, [x21, #0x595]
006A8E52C  mov      x20, x0
006A8E530  cbnz     w8, #0x6a8e548
006A8E534  adrp     x0, #0x8f38000
006A8E538  ldr      x0, [x0, #0xc10]
006A8E53C  bl       #0x382bd14 ; 
006A8E540  mov      w8, #1
006A8E544  strb     w8, [x21, #0x595]
006A8E548  adrp     x8, #0x8f38000
006A8E54C  ldr      x8, [x8, #0xc10]
006A8E550  ldr      x2, [x8]
006A8E554  ldrb     w8, [x2, #0x53]
006A8E558  tbnz     w8, #5, #0x6a8e570
006A8E55C  mov      x0, x19
006A8E560  str      x20, [x0, #0x28]!
006A8E564  mov      x1, x20
006A8E568  bl       #0x382bcb8 ; 
006A8E56C  b        #0x6a8e580 ; 
006A8E570  ldr      x8, [x2, #0x60]
006A8E574  mov      x0, x19
006A8E578  mov      x1, x20
006A8E57C  blr      x8
006A8E580  mov      x0, x19
006A8E584  mov      x1, xzr
006A8E588  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A8E58C  adrp     x21, #0x959e000
006A8E590  ldrb     w8, [x21, #0x596]
006A8E594  mov      x20, x0
006A8E598  cbnz     w8, #0x6a8e5b0
006A8E59C  adrp     x0, #0x8f38000
006A8E5A0  ldr      x0, [x0, #0xc20]
006A8E5A4  bl       #0x382bd14 ; 
006A8E5A8  mov      w8, #1
006A8E5AC  strb     w8, [x21, #0x596]
006A8E5B0  adrp     x8, #0x8f38000
006A8E5B4  ldr      x8, [x8, #0xc20]
006A8E5B8  ldr      x2, [x8]
006A8E5BC  ldrb     w8, [x2, #0x53]
006A8E5C0  tbnz     w8, #5, #0x6a8e5d8
006A8E5C4  mov      x0, x19
006A8E5C8  str      x20, [x0, #0x30]!
006A8E5CC  mov      x1, x20
006A8E5D0  bl       #0x382bcb8 ; 
006A8E5D4  b        #0x6a8e5e8 ; 
006A8E5D8  ldr      x8, [x2, #0x60]
006A8E5DC  mov      x0, x19
006A8E5E0  mov      x1, x20
006A8E5E4  blr      x8
006A8E5E8  mov      x0, x19
006A8E5EC  mov      x1, xzr
006A8E5F0  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A8E5F4  adrp     x21, #0x959e000
006A8E5F8  ldrb     w8, [x21, #0x597]
006A8E5FC  mov      x20, x0
006A8E600  cbnz     w8, #0x6a8e618
006A8E604  adrp     x0, #0x8f38000
006A8E608  ldr      x0, [x0, #0xc30]
006A8E60C  bl       #0x382bd14 ; 
006A8E610  mov      w8, #1
006A8E614  strb     w8, [x21, #0x597]
006A8E618  adrp     x8, #0x8f38000
006A8E61C  ldr      x8, [x8, #0xc30]
006A8E620  ldr      x2, [x8]
006A8E624  ldrb     w8, [x2, #0x53]
006A8E628  tbnz     w8, #5, #0x6a8e640
006A8E62C  str      x20, [x19, #0x38]!
006A8E630  mov      x0, x19
006A8E634  mov      x1, x20
006A8E638  bl       #0x382bcb8 ; 
006A8E63C  b        #0x6a8e650 ; 
006A8E640  ldr      x8, [x2, #0x60]
006A8E644  mov      x0, x19
006A8E648  mov      x1, x20
006A8E64C  blr      x8
006A8E650  ldp      x20, x19, [sp, #0x10]
006A8E654  mov      w0, #1
006A8E658  ldp      x30, x21, [sp], #0x20
006A8E65C  ret      

