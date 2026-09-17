; LocalModels.Bean.GuildBOSS_guildBossDamageStage$$readImpl
; RVA 0x6A86468; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A86468  stp      x30, x21, [sp, #-0x20]!
006A8646C  stp      x20, x19, [sp, #0x10]
006A86470  adrp     x20, #0x959d000
006A86474  adrp     x21, #0x8f38000
006A86478  ldrb     w8, [x20, #0xfe1]
006A8647C  ldr      x21, [x21, #0x688]
006A86480  mov      x19, x0
006A86484  tbnz     w8, #0, #0x6a8649c
006A86488  adrp     x0, #0x8f38000
006A8648C  ldr      x0, [x0, #0x688]
006A86490  bl       #0x382bd14 ; 
006A86494  mov      w8, #1
006A86498  strb     w8, [x20, #0xfe1]
006A8649C  ldr      x1, [x21]
006A864A0  ldrb     w8, [x1, #0x53]
006A864A4  tbnz     w8, #5, #0x6a864f4
006A864A8  mov      x0, x19
006A864AC  mov      x1, xzr
006A864B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A864B4  adrp     x21, #0x959e000
006A864B8  ldrb     w8, [x21, #0x53f]
006A864BC  mov      w20, w0
006A864C0  cbnz     w8, #0x6a864d8
006A864C4  adrp     x0, #0x8f38000
006A864C8  ldr      x0, [x0, #0x668]
006A864CC  bl       #0x382bd14 ; 
006A864D0  mov      w8, #1
006A864D4  strb     w8, [x21, #0x53f]
006A864D8  adrp     x8, #0x8f38000
006A864DC  ldr      x8, [x8, #0x668]
006A864E0  ldr      x2, [x8]
006A864E4  ldrb     w8, [x2, #0x53]
006A864E8  tbnz     w8, #5, #0x6a86508
006A864EC  str      w20, [x19, #0x20]
006A864F0  b        #0x6a86518 ; 
006A864F4  ldr      x2, [x1, #0x60]
006A864F8  mov      x0, x19
006A864FC  ldp      x20, x19, [sp, #0x10]
006A86500  ldp      x30, x21, [sp], #0x20
006A86504  br       x2
006A86508  ldr      x8, [x2, #0x60]
006A8650C  mov      x0, x19
006A86510  mov      w1, w20
006A86514  blr      x8
006A86518  mov      x0, x19
006A8651C  mov      x1, xzr
006A86520  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006A86524  adrp     x21, #0x959e000
006A86528  ldrb     w8, [x21, #0x540]
006A8652C  mov      x20, x0
006A86530  cbnz     w8, #0x6a86548
006A86534  adrp     x0, #0x8f38000
006A86538  ldr      x0, [x0, #0x670]
006A8653C  bl       #0x382bd14 ; 
006A86540  mov      w8, #1
006A86544  strb     w8, [x21, #0x540]
006A86548  adrp     x8, #0x8f38000
006A8654C  ldr      x8, [x8, #0x670]
006A86550  ldr      x2, [x8]
006A86554  ldrb     w8, [x2, #0x53]
006A86558  tbnz     w8, #5, #0x6a86564
006A8655C  str      x20, [x19, #0x28]
006A86560  b        #0x6a86574 ; 
006A86564  ldr      x8, [x2, #0x60]
006A86568  mov      x0, x19
006A8656C  mov      x1, x20
006A86570  blr      x8
006A86574  mov      x0, x19
006A86578  mov      x1, xzr
006A8657C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A86580  adrp     x21, #0x959e000
006A86584  ldrb     w8, [x21, #0x541]
006A86588  mov      x20, x0
006A8658C  cbnz     w8, #0x6a865a4
006A86590  adrp     x0, #0x8f38000
006A86594  ldr      x0, [x0, #0x678]
006A86598  bl       #0x382bd14 ; 
006A8659C  mov      w8, #1
006A865A0  strb     w8, [x21, #0x541]
006A865A4  adrp     x8, #0x8f38000
006A865A8  ldr      x8, [x8, #0x678]
006A865AC  ldr      x2, [x8]
006A865B0  ldrb     w8, [x2, #0x53]
006A865B4  tbnz     w8, #5, #0x6a865cc
006A865B8  mov      x0, x19
006A865BC  str      x20, [x0, #0x30]!
006A865C0  mov      x1, x20
006A865C4  bl       #0x382bcb8 ; 
006A865C8  b        #0x6a865dc ; 
006A865CC  ldr      x8, [x2, #0x60]
006A865D0  mov      x0, x19
006A865D4  mov      x1, x20
006A865D8  blr      x8
006A865DC  mov      x0, x19
006A865E0  mov      x1, xzr
006A865E4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A865E8  adrp     x21, #0x959e000
006A865EC  ldrb     w8, [x21, #0x542]
006A865F0  mov      x20, x0
006A865F4  cbnz     w8, #0x6a8660c
006A865F8  adrp     x0, #0x8f38000
006A865FC  ldr      x0, [x0, #0x680]
006A86600  bl       #0x382bd14 ; 
006A86604  mov      w8, #1
006A86608  strb     w8, [x21, #0x542]
006A8660C  adrp     x8, #0x8f38000
006A86610  ldr      x8, [x8, #0x680]
006A86614  ldr      x2, [x8]
006A86618  ldrb     w8, [x2, #0x53]
006A8661C  tbnz     w8, #5, #0x6a86634
006A86620  str      x20, [x19, #0x38]!
006A86624  mov      x0, x19
006A86628  mov      x1, x20
006A8662C  bl       #0x382bcb8 ; 
006A86630  b        #0x6a86644 ; 
006A86634  ldr      x8, [x2, #0x60]
006A86638  mov      x0, x19
006A8663C  mov      x1, x20
006A86640  blr      x8
006A86644  ldp      x20, x19, [sp, #0x10]
006A86648  mov      w0, #1
006A8664C  ldp      x30, x21, [sp], #0x20
006A86650  ret      

