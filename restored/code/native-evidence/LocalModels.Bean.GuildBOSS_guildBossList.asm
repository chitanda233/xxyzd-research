; LocalModels.Bean.GuildBOSS_guildBossList$$readImpl
; RVA 0x6A8746C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A8746C  stp      x30, x21, [sp, #-0x20]!
006A87470  stp      x20, x19, [sp, #0x10]
006A87474  adrp     x20, #0x959d000
006A87478  adrp     x21, #0x8f38000
006A8747C  ldrb     w8, [x20, #0xffb]
006A87480  ldr      x21, [x21, #0x748]
006A87484  mov      x19, x0
006A87488  tbnz     w8, #0, #0x6a874a0
006A8748C  adrp     x0, #0x8f38000
006A87490  ldr      x0, [x0, #0x748]
006A87494  bl       #0x382bd14 ; 
006A87498  mov      w8, #1
006A8749C  strb     w8, [x20, #0xffb]
006A874A0  ldr      x1, [x21]
006A874A4  ldrb     w8, [x1, #0x53]
006A874A8  tbnz     w8, #5, #0x6a874f8
006A874AC  mov      x0, x19
006A874B0  mov      x1, xzr
006A874B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A874B8  adrp     x21, #0x959e000
006A874BC  ldrb     w8, [x21, #0x54b]
006A874C0  mov      w20, w0
006A874C4  cbnz     w8, #0x6a874dc
006A874C8  adrp     x0, #0x8f38000
006A874CC  ldr      x0, [x0, #0x730]
006A874D0  bl       #0x382bd14 ; 
006A874D4  mov      w8, #1
006A874D8  strb     w8, [x21, #0x54b]
006A874DC  adrp     x8, #0x8f38000
006A874E0  ldr      x8, [x8, #0x730]
006A874E4  ldr      x2, [x8]
006A874E8  ldrb     w8, [x2, #0x53]
006A874EC  tbnz     w8, #5, #0x6a8750c
006A874F0  str      w20, [x19, #0x20]
006A874F4  b        #0x6a8751c ; 
006A874F8  ldr      x2, [x1, #0x60]
006A874FC  mov      x0, x19
006A87500  ldp      x20, x19, [sp, #0x10]
006A87504  ldp      x30, x21, [sp], #0x20
006A87508  br       x2
006A8750C  ldr      x8, [x2, #0x60]
006A87510  mov      x0, x19
006A87514  mov      w1, w20
006A87518  blr      x8
006A8751C  mov      x0, x19
006A87520  mov      x1, xzr
006A87524  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A87528  adrp     x21, #0x959e000
006A8752C  ldrb     w8, [x21, #0x54c]
006A87530  mov      w20, w0
006A87534  cbnz     w8, #0x6a8754c
006A87538  adrp     x0, #0x8f38000
006A8753C  ldr      x0, [x0, #0x740]
006A87540  bl       #0x382bd14 ; 
006A87544  mov      w8, #1
006A87548  strb     w8, [x21, #0x54c]
006A8754C  adrp     x8, #0x8f38000
006A87550  ldr      x8, [x8, #0x740]
006A87554  ldr      x2, [x8]
006A87558  ldrb     w8, [x2, #0x53]
006A8755C  tbnz     w8, #5, #0x6a87568
006A87560  str      w20, [x19, #0x24]
006A87564  b        #0x6a87578 ; 
006A87568  ldr      x8, [x2, #0x60]
006A8756C  mov      x0, x19
006A87570  mov      w1, w20
006A87574  blr      x8
006A87578  ldp      x20, x19, [sp, #0x10]
006A8757C  mov      w0, #1
006A87580  ldp      x30, x21, [sp], #0x20
006A87584  ret      

