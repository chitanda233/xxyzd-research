; LocalModels.Bean.WorldBoss_ChallengeLevelRunePool$$readImpl
; RVA 0x6B23510; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B23510  stp      x30, x21, [sp, #-0x20]!
006B23514  stp      x20, x19, [sp, #0x10]
006B23518  adrp     x20, #0x959f000
006B2351C  adrp     x21, #0x8f3f000
006B23520  ldrb     w8, [x20, #0x729]
006B23524  ldr      x21, [x21, #0x9b8]
006B23528  mov      x19, x0
006B2352C  tbnz     w8, #0, #0x6b23544
006B23530  adrp     x0, #0x8f3f000
006B23534  ldr      x0, [x0, #0x9b8]
006B23538  bl       #0x382bd14 ; 
006B2353C  mov      w8, #1
006B23540  strb     w8, [x20, #0x729]
006B23544  ldr      x1, [x21]
006B23548  ldrb     w8, [x1, #0x53]
006B2354C  tbnz     w8, #5, #0x6b2359c
006B23550  mov      x0, x19
006B23554  mov      x1, xzr
006B23558  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B2355C  adrp     x21, #0x959f000
006B23560  ldrb     w8, [x21, #0xa78]
006B23564  mov      w20, w0
006B23568  cbnz     w8, #0x6b23580
006B2356C  adrp     x0, #0x8f3f000
006B23570  ldr      x0, [x0, #0x9a0]
006B23574  bl       #0x382bd14 ; 
006B23578  mov      w8, #1
006B2357C  strb     w8, [x21, #0xa78]
006B23580  adrp     x8, #0x8f3f000
006B23584  ldr      x8, [x8, #0x9a0]
006B23588  ldr      x2, [x8]
006B2358C  ldrb     w8, [x2, #0x53]
006B23590  tbnz     w8, #5, #0x6b235b0
006B23594  str      w20, [x19, #0x20]
006B23598  b        #0x6b235c0 ; 
006B2359C  ldr      x2, [x1, #0x60]
006B235A0  mov      x0, x19
006B235A4  ldp      x20, x19, [sp, #0x10]
006B235A8  ldp      x30, x21, [sp], #0x20
006B235AC  br       x2
006B235B0  ldr      x8, [x2, #0x60]
006B235B4  mov      x0, x19
006B235B8  mov      w1, w20
006B235BC  blr      x8
006B235C0  mov      x0, x19
006B235C4  mov      x1, xzr
006B235C8  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B235CC  adrp     x21, #0x959f000
006B235D0  ldrb     w8, [x21, #0xa79]
006B235D4  mov      x20, x0
006B235D8  cbnz     w8, #0x6b235f0
006B235DC  adrp     x0, #0x8f3f000
006B235E0  ldr      x0, [x0, #0x9b0]
006B235E4  bl       #0x382bd14 ; 
006B235E8  mov      w8, #1
006B235EC  strb     w8, [x21, #0xa79]
006B235F0  adrp     x8, #0x8f3f000
006B235F4  ldr      x8, [x8, #0x9b0]
006B235F8  ldr      x2, [x8]
006B235FC  ldrb     w8, [x2, #0x53]
006B23600  tbnz     w8, #5, #0x6b23618
006B23604  str      x20, [x19, #0x28]!
006B23608  mov      x0, x19
006B2360C  mov      x1, x20
006B23610  bl       #0x382bcb8 ; 
006B23614  b        #0x6b23628 ; 
006B23618  ldr      x8, [x2, #0x60]
006B2361C  mov      x0, x19
006B23620  mov      x1, x20
006B23624  blr      x8
006B23628  ldp      x20, x19, [sp, #0x10]
006B2362C  mov      w0, #1
006B23630  ldp      x30, x21, [sp], #0x20
006B23634  ret      

