; LocalModels.Bean.GuildBOSS_guildBossBox$$readImpl
; RVA 0x6A854DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A854DC  stp      x30, x21, [sp, #-0x20]!
006A854E0  stp      x20, x19, [sp, #0x10]
006A854E4  adrp     x20, #0x959d000
006A854E8  adrp     x21, #0x8f38000
006A854EC  ldrb     w8, [x20, #0xfc7]
006A854F0  ldr      x21, [x21, #0x5e0]
006A854F4  mov      x19, x0
006A854F8  tbnz     w8, #0, #0x6a85510
006A854FC  adrp     x0, #0x8f38000
006A85500  ldr      x0, [x0, #0x5e0]
006A85504  bl       #0x382bd14 ; 
006A85508  mov      w8, #1
006A8550C  strb     w8, [x20, #0xfc7]
006A85510  ldr      x1, [x21]
006A85514  ldrb     w8, [x1, #0x53]
006A85518  tbnz     w8, #5, #0x6a85568
006A8551C  mov      x0, x19
006A85520  mov      x1, xzr
006A85524  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A85528  adrp     x21, #0x959e000
006A8552C  ldrb     w8, [x21, #0x535]
006A85530  mov      w20, w0
006A85534  cbnz     w8, #0x6a8554c
006A85538  adrp     x0, #0x8f38000
006A8553C  ldr      x0, [x0, #0x5a8]
006A85540  bl       #0x382bd14 ; 
006A85544  mov      w8, #1
006A85548  strb     w8, [x21, #0x535]
006A8554C  adrp     x8, #0x8f38000
006A85550  ldr      x8, [x8, #0x5a8]
006A85554  ldr      x2, [x8]
006A85558  ldrb     w8, [x2, #0x53]
006A8555C  tbnz     w8, #5, #0x6a8557c
006A85560  str      w20, [x19, #0x20]
006A85564  b        #0x6a8558c ; 
006A85568  ldr      x2, [x1, #0x60]
006A8556C  mov      x0, x19
006A85570  ldp      x20, x19, [sp, #0x10]
006A85574  ldp      x30, x21, [sp], #0x20
006A85578  br       x2
006A8557C  ldr      x8, [x2, #0x60]
006A85580  mov      x0, x19
006A85584  mov      w1, w20
006A85588  blr      x8
006A8558C  mov      x0, x19
006A85590  mov      x1, xzr
006A85594  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006A85598  adrp     x21, #0x959e000
006A8559C  ldrb     w8, [x21, #0x536]
006A855A0  mov      x20, x0
006A855A4  cbnz     w8, #0x6a855bc
006A855A8  adrp     x0, #0x8f38000
006A855AC  ldr      x0, [x0, #0x5b8]
006A855B0  bl       #0x382bd14 ; 
006A855B4  mov      w8, #1
006A855B8  strb     w8, [x21, #0x536]
006A855BC  adrp     x8, #0x8f38000
006A855C0  ldr      x8, [x8, #0x5b8]
006A855C4  ldr      x2, [x8]
006A855C8  ldrb     w8, [x2, #0x53]
006A855CC  tbnz     w8, #5, #0x6a855d8
006A855D0  str      x20, [x19, #0x28]
006A855D4  b        #0x6a855e8 ; 
006A855D8  ldr      x8, [x2, #0x60]
006A855DC  mov      x0, x19
006A855E0  mov      x1, x20
006A855E4  blr      x8
006A855E8  mov      x0, x19
006A855EC  mov      x1, xzr
006A855F0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A855F4  adrp     x21, #0x959e000
006A855F8  ldrb     w8, [x21, #0x537]
006A855FC  mov      w20, w0
006A85600  cbnz     w8, #0x6a85618
006A85604  adrp     x0, #0x8f38000
006A85608  ldr      x0, [x0, #0x5c8]
006A8560C  bl       #0x382bd14 ; 
006A85610  mov      w8, #1
006A85614  strb     w8, [x21, #0x537]
006A85618  adrp     x8, #0x8f38000
006A8561C  ldr      x8, [x8, #0x5c8]
006A85620  ldr      x2, [x8]
006A85624  ldrb     w8, [x2, #0x53]
006A85628  tbnz     w8, #5, #0x6a85634
006A8562C  str      w20, [x19, #0x30]
006A85630  b        #0x6a85644 ; 
006A85634  ldr      x8, [x2, #0x60]
006A85638  mov      x0, x19
006A8563C  mov      w1, w20
006A85640  blr      x8
006A85644  mov      x0, x19
006A85648  mov      x1, xzr
006A8564C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A85650  adrp     x21, #0x959e000
006A85654  ldrb     w8, [x21, #0x538]
006A85658  mov      x20, x0
006A8565C  cbnz     w8, #0x6a85674
006A85660  adrp     x0, #0x8f38000
006A85664  ldr      x0, [x0, #0x5d8]
006A85668  bl       #0x382bd14 ; 
006A8566C  mov      w8, #1
006A85670  strb     w8, [x21, #0x538]
006A85674  adrp     x8, #0x8f38000
006A85678  ldr      x8, [x8, #0x5d8]
006A8567C  ldr      x2, [x8]
006A85680  ldrb     w8, [x2, #0x53]
006A85684  tbnz     w8, #5, #0x6a8569c
006A85688  str      x20, [x19, #0x38]!
006A8568C  mov      x0, x19
006A85690  mov      x1, x20
006A85694  bl       #0x382bcb8 ; 
006A85698  b        #0x6a856ac ; 
006A8569C  ldr      x8, [x2, #0x60]
006A856A0  mov      x0, x19
006A856A4  mov      x1, x20
006A856A8  blr      x8
006A856AC  ldp      x20, x19, [sp, #0x10]
006A856B0  mov      w0, #1
006A856B4  ldp      x30, x21, [sp], #0x20
006A856B8  ret      

