; LocalModels.Bean.DrawBox_LootBoxRule$$readImpl
; RVA 0x6A5D470; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A5D470  stp      x30, x21, [sp, #-0x20]!
006A5D474  stp      x20, x19, [sp, #0x10]
006A5D478  adrp     x20, #0x959d000
006A5D47C  adrp     x21, #0x8f36000
006A5D480  ldrb     w8, [x20, #0xba4]
006A5D484  ldr      x21, [x21, #0x7b0]
006A5D488  mov      x19, x0
006A5D48C  tbnz     w8, #0, #0x6a5d4a4
006A5D490  adrp     x0, #0x8f36000
006A5D494  ldr      x0, [x0, #0x7b0]
006A5D498  bl       #0x382bd14 ; 
006A5D49C  mov      w8, #1
006A5D4A0  strb     w8, [x20, #0xba4]
006A5D4A4  ldr      x1, [x21]
006A5D4A8  ldrb     w8, [x1, #0x53]
006A5D4AC  tbnz     w8, #5, #0x6a5d4fc
006A5D4B0  mov      x0, x19
006A5D4B4  mov      x1, xzr
006A5D4B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5D4BC  adrp     x21, #0x959e000
006A5D4C0  ldrb     w8, [x21, #0x379]
006A5D4C4  mov      w20, w0
006A5D4C8  cbnz     w8, #0x6a5d4e0
006A5D4CC  adrp     x0, #0x8f36000
006A5D4D0  ldr      x0, [x0, #0x778]
006A5D4D4  bl       #0x382bd14 ; 
006A5D4D8  mov      w8, #1
006A5D4DC  strb     w8, [x21, #0x379]
006A5D4E0  adrp     x8, #0x8f36000
006A5D4E4  ldr      x8, [x8, #0x778]
006A5D4E8  ldr      x2, [x8]
006A5D4EC  ldrb     w8, [x2, #0x53]
006A5D4F0  tbnz     w8, #5, #0x6a5d510
006A5D4F4  str      w20, [x19, #0x20]
006A5D4F8  b        #0x6a5d520 ; 
006A5D4FC  ldr      x2, [x1, #0x60]
006A5D500  mov      x0, x19
006A5D504  ldp      x20, x19, [sp, #0x10]
006A5D508  ldp      x30, x21, [sp], #0x20
006A5D50C  br       x2
006A5D510  ldr      x8, [x2, #0x60]
006A5D514  mov      x0, x19
006A5D518  mov      w1, w20
006A5D51C  blr      x8
006A5D520  mov      x0, x19
006A5D524  mov      x1, xzr
006A5D528  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A5D52C  adrp     x21, #0x959e000
006A5D530  ldrb     w8, [x21, #0x37a]
006A5D534  mov      x20, x0
006A5D538  cbnz     w8, #0x6a5d550
006A5D53C  adrp     x0, #0x8f36000
006A5D540  ldr      x0, [x0, #0x788]
006A5D544  bl       #0x382bd14 ; 
006A5D548  mov      w8, #1
006A5D54C  strb     w8, [x21, #0x37a]
006A5D550  adrp     x8, #0x8f36000
006A5D554  ldr      x8, [x8, #0x788]
006A5D558  ldr      x2, [x8]
006A5D55C  ldrb     w8, [x2, #0x53]
006A5D560  tbnz     w8, #5, #0x6a5d578
006A5D564  mov      x0, x19
006A5D568  str      x20, [x0, #0x28]!
006A5D56C  mov      x1, x20
006A5D570  bl       #0x382bcb8 ; 
006A5D574  b        #0x6a5d588 ; 
006A5D578  ldr      x8, [x2, #0x60]
006A5D57C  mov      x0, x19
006A5D580  mov      x1, x20
006A5D584  blr      x8
006A5D588  mov      x0, x19
006A5D58C  mov      x1, xzr
006A5D590  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5D594  adrp     x21, #0x959e000
006A5D598  ldrb     w8, [x21, #0x37b]
006A5D59C  mov      w20, w0
006A5D5A0  cbnz     w8, #0x6a5d5b8
006A5D5A4  adrp     x0, #0x8f36000
006A5D5A8  ldr      x0, [x0, #0x798]
006A5D5AC  bl       #0x382bd14 ; 
006A5D5B0  mov      w8, #1
006A5D5B4  strb     w8, [x21, #0x37b]
006A5D5B8  adrp     x8, #0x8f36000
006A5D5BC  ldr      x8, [x8, #0x798]
006A5D5C0  ldr      x2, [x8]
006A5D5C4  ldrb     w8, [x2, #0x53]
006A5D5C8  tbnz     w8, #5, #0x6a5d5d4
006A5D5CC  str      w20, [x19, #0x30]
006A5D5D0  b        #0x6a5d5e4 ; 
006A5D5D4  ldr      x8, [x2, #0x60]
006A5D5D8  mov      x0, x19
006A5D5DC  mov      w1, w20
006A5D5E0  blr      x8
006A5D5E4  mov      x0, x19
006A5D5E8  mov      x1, xzr
006A5D5EC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A5D5F0  adrp     x21, #0x959e000
006A5D5F4  ldrb     w8, [x21, #0x37c]
006A5D5F8  mov      w20, w0
006A5D5FC  cbnz     w8, #0x6a5d614
006A5D600  adrp     x0, #0x8f36000
006A5D604  ldr      x0, [x0, #0x7a8]
006A5D608  bl       #0x382bd14 ; 
006A5D60C  mov      w8, #1
006A5D610  strb     w8, [x21, #0x37c]
006A5D614  adrp     x8, #0x8f36000
006A5D618  ldr      x8, [x8, #0x7a8]
006A5D61C  ldr      x2, [x8]
006A5D620  ldrb     w8, [x2, #0x53]
006A5D624  tbnz     w8, #5, #0x6a5d630
006A5D628  str      w20, [x19, #0x34]
006A5D62C  b        #0x6a5d640 ; 
006A5D630  ldr      x8, [x2, #0x60]
006A5D634  mov      x0, x19
006A5D638  mov      w1, w20
006A5D63C  blr      x8
006A5D640  ldp      x20, x19, [sp, #0x10]
006A5D644  mov      w0, #1
006A5D648  ldp      x30, x21, [sp], #0x20
006A5D64C  ret      

