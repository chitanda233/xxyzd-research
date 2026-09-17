; LocalModels.Bean.GuildBOSS_guildBossRankReward$$readImpl
; RVA 0x6A887A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A887A0  stp      x30, x21, [sp, #-0x20]!
006A887A4  stp      x20, x19, [sp, #0x10]
006A887A8  adrp     x20, #0x959e000
006A887AC  adrp     x21, #0x8f38000
006A887B0  ldrb     w8, [x20, #0x1c]
006A887B4  ldr      x21, [x21, #0x830]
006A887B8  mov      x19, x0
006A887BC  tbnz     w8, #0, #0x6a887d4
006A887C0  adrp     x0, #0x8f38000
006A887C4  ldr      x0, [x0, #0x830]
006A887C8  bl       #0x382bd14 ; 
006A887CC  mov      w8, #1
006A887D0  strb     w8, [x20, #0x1c]
006A887D4  ldr      x1, [x21]
006A887D8  ldrb     w8, [x1, #0x53]
006A887DC  tbnz     w8, #5, #0x6a8882c
006A887E0  mov      x0, x19
006A887E4  mov      x1, xzr
006A887E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A887EC  adrp     x21, #0x959e000
006A887F0  ldrb     w8, [x21, #0x556]
006A887F4  mov      w20, w0
006A887F8  cbnz     w8, #0x6a88810
006A887FC  adrp     x0, #0x8f38000
006A88800  ldr      x0, [x0, #0x808]
006A88804  bl       #0x382bd14 ; 
006A88808  mov      w8, #1
006A8880C  strb     w8, [x21, #0x556]
006A88810  adrp     x8, #0x8f38000
006A88814  ldr      x8, [x8, #0x808]
006A88818  ldr      x2, [x8]
006A8881C  ldrb     w8, [x2, #0x53]
006A88820  tbnz     w8, #5, #0x6a88840
006A88824  str      w20, [x19, #0x20]
006A88828  b        #0x6a88850 ; 
006A8882C  ldr      x2, [x1, #0x60]
006A88830  mov      x0, x19
006A88834  ldp      x20, x19, [sp, #0x10]
006A88838  ldp      x30, x21, [sp], #0x20
006A8883C  br       x2
006A88840  ldr      x8, [x2, #0x60]
006A88844  mov      x0, x19
006A88848  mov      w1, w20
006A8884C  blr      x8
006A88850  mov      x0, x19
006A88854  mov      x1, xzr
006A88858  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A8885C  adrp     x21, #0x959e000
006A88860  ldrb     w8, [x21, #0x557]
006A88864  mov      x20, x0
006A88868  cbnz     w8, #0x6a88880
006A8886C  adrp     x0, #0x8f38000
006A88870  ldr      x0, [x0, #0x818]
006A88874  bl       #0x382bd14 ; 
006A88878  mov      w8, #1
006A8887C  strb     w8, [x21, #0x557]
006A88880  adrp     x8, #0x8f38000
006A88884  ldr      x8, [x8, #0x818]
006A88888  ldr      x2, [x8]
006A8888C  ldrb     w8, [x2, #0x53]
006A88890  tbnz     w8, #5, #0x6a888a8
006A88894  mov      x0, x19
006A88898  str      x20, [x0, #0x28]!
006A8889C  mov      x1, x20
006A888A0  bl       #0x382bcb8 ; 
006A888A4  b        #0x6a888b8 ; 
006A888A8  ldr      x8, [x2, #0x60]
006A888AC  mov      x0, x19
006A888B0  mov      x1, x20
006A888B4  blr      x8
006A888B8  mov      x0, x19
006A888BC  mov      x1, xzr
006A888C0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A888C4  adrp     x21, #0x959e000
006A888C8  ldrb     w8, [x21, #0x558]
006A888CC  mov      x20, x0
006A888D0  cbnz     w8, #0x6a888e8
006A888D4  adrp     x0, #0x8f38000
006A888D8  ldr      x0, [x0, #0x828]
006A888DC  bl       #0x382bd14 ; 
006A888E0  mov      w8, #1
006A888E4  strb     w8, [x21, #0x558]
006A888E8  adrp     x8, #0x8f38000
006A888EC  ldr      x8, [x8, #0x828]
006A888F0  ldr      x2, [x8]
006A888F4  ldrb     w8, [x2, #0x53]
006A888F8  tbnz     w8, #5, #0x6a88910
006A888FC  str      x20, [x19, #0x30]!
006A88900  mov      x0, x19
006A88904  mov      x1, x20
006A88908  bl       #0x382bcb8 ; 
006A8890C  b        #0x6a88920 ; 
006A88910  ldr      x8, [x2, #0x60]
006A88914  mov      x0, x19
006A88918  mov      x1, x20
006A8891C  blr      x8
006A88920  ldp      x20, x19, [sp, #0x10]
006A88924  mov      w0, #1
006A88928  ldp      x30, x21, [sp], #0x20
006A8892C  ret      

