; LocalModels.Bean.EventTurntable_EventTurntableDraw$$readImpl
; RVA 0x6A79218; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A79218  stp      x30, x21, [sp, #-0x20]!
006A7921C  stp      x20, x19, [sp, #0x10]
006A79220  adrp     x20, #0x959d000
006A79224  adrp     x21, #0x8f37000
006A79228  ldrb     w8, [x20, #0xe83]
006A7922C  ldr      x21, [x21, #0xc88]
006A79230  mov      x19, x0
006A79234  tbnz     w8, #0, #0x6a7924c
006A79238  adrp     x0, #0x8f37000
006A7923C  ldr      x0, [x0, #0xc88]
006A79240  bl       #0x382bd14 ; 
006A79244  mov      w8, #1
006A79248  strb     w8, [x20, #0xe83]
006A7924C  ldr      x1, [x21]
006A79250  ldrb     w8, [x1, #0x53]
006A79254  tbnz     w8, #5, #0x6a792a4
006A79258  mov      x0, x19
006A7925C  mov      x1, xzr
006A79260  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A79264  adrp     x21, #0x959e000
006A79268  ldrb     w8, [x21, #0x4af]
006A7926C  mov      w20, w0
006A79270  cbnz     w8, #0x6a79288
006A79274  adrp     x0, #0x8f37000
006A79278  ldr      x0, [x0, #0xc00]
006A7927C  bl       #0x382bd14 ; 
006A79280  mov      w8, #1
006A79284  strb     w8, [x21, #0x4af]
006A79288  adrp     x8, #0x8f37000
006A7928C  ldr      x8, [x8, #0xc00]
006A79290  ldr      x2, [x8]
006A79294  ldrb     w8, [x2, #0x53]
006A79298  tbnz     w8, #5, #0x6a792b8
006A7929C  str      w20, [x19, #0x20]
006A792A0  b        #0x6a792c8 ; 
006A792A4  ldr      x2, [x1, #0x60]
006A792A8  mov      x0, x19
006A792AC  ldp      x20, x19, [sp, #0x10]
006A792B0  ldp      x30, x21, [sp], #0x20
006A792B4  br       x2
006A792B8  ldr      x8, [x2, #0x60]
006A792BC  mov      x0, x19
006A792C0  mov      w1, w20
006A792C4  blr      x8
006A792C8  mov      x0, x19
006A792CC  mov      x1, xzr
006A792D0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A792D4  adrp     x21, #0x959e000
006A792D8  ldrb     w8, [x21, #0x4b0]
006A792DC  mov      w20, w0
006A792E0  cbnz     w8, #0x6a792f8
006A792E4  adrp     x0, #0x8f37000
006A792E8  ldr      x0, [x0, #0xc10]
006A792EC  bl       #0x382bd14 ; 
006A792F0  mov      w8, #1
006A792F4  strb     w8, [x21, #0x4b0]
006A792F8  adrp     x8, #0x8f37000
006A792FC  ldr      x8, [x8, #0xc10]
006A79300  ldr      x2, [x8]
006A79304  ldrb     w8, [x2, #0x53]
006A79308  tbnz     w8, #5, #0x6a79314
006A7930C  str      w20, [x19, #0x24]
006A79310  b        #0x6a79324 ; 
006A79314  ldr      x8, [x2, #0x60]
006A79318  mov      x0, x19
006A7931C  mov      w1, w20
006A79320  blr      x8
006A79324  mov      x0, x19
006A79328  mov      x1, xzr
006A7932C  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A79330  adrp     x21, #0x959e000
006A79334  ldrb     w8, [x21, #0x4b1]
006A79338  mov      x20, x0
006A7933C  cbnz     w8, #0x6a79354
006A79340  adrp     x0, #0x8f37000
006A79344  ldr      x0, [x0, #0xc20]
006A79348  bl       #0x382bd14 ; 
006A7934C  mov      w8, #1
006A79350  strb     w8, [x21, #0x4b1]
006A79354  adrp     x8, #0x8f37000
006A79358  ldr      x8, [x8, #0xc20]
006A7935C  ldr      x2, [x8]
006A79360  ldrb     w8, [x2, #0x53]
006A79364  tbnz     w8, #5, #0x6a7937c
006A79368  mov      x0, x19
006A7936C  str      x20, [x0, #0x28]!
006A79370  mov      x1, x20
006A79374  bl       #0x382bcb8 ; 
006A79378  b        #0x6a7938c ; 
006A7937C  ldr      x8, [x2, #0x60]
006A79380  mov      x0, x19
006A79384  mov      x1, x20
006A79388  blr      x8
006A7938C  mov      x0, x19
006A79390  mov      x1, xzr
006A79394  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A79398  adrp     x21, #0x959e000
006A7939C  ldrb     w8, [x21, #0x4b2]
006A793A0  mov      x20, x0
006A793A4  cbnz     w8, #0x6a793bc
006A793A8  adrp     x0, #0x8f37000
006A793AC  ldr      x0, [x0, #0xc30]
006A793B0  bl       #0x382bd14 ; 
006A793B4  mov      w8, #1
006A793B8  strb     w8, [x21, #0x4b2]
006A793BC  adrp     x8, #0x8f37000
006A793C0  ldr      x8, [x8, #0xc30]
006A793C4  ldr      x2, [x8]
006A793C8  ldrb     w8, [x2, #0x53]
006A793CC  tbnz     w8, #5, #0x6a793e4
006A793D0  mov      x0, x19
006A793D4  str      x20, [x0, #0x30]!
006A793D8  mov      x1, x20
006A793DC  bl       #0x382bcb8 ; 
006A793E0  b        #0x6a793f4 ; 
006A793E4  ldr      x8, [x2, #0x60]
006A793E8  mov      x0, x19
006A793EC  mov      x1, x20
006A793F0  blr      x8
006A793F4  mov      x0, x19
006A793F8  mov      x1, xzr
006A793FC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A79400  adrp     x21, #0x959e000
006A79404  ldrb     w8, [x21, #0x4b3]
006A79408  mov      w20, w0
006A7940C  cbnz     w8, #0x6a79424
006A79410  adrp     x0, #0x8f37000
006A79414  ldr      x0, [x0, #0xc40]
006A79418  bl       #0x382bd14 ; 
006A7941C  mov      w8, #1
006A79420  strb     w8, [x21, #0x4b3]
006A79424  adrp     x8, #0x8f37000
006A79428  ldr      x8, [x8, #0xc40]
006A7942C  ldr      x2, [x8]
006A79430  ldrb     w8, [x2, #0x53]
006A79434  tbnz     w8, #5, #0x6a79440
006A79438  str      w20, [x19, #0x38]
006A7943C  b        #0x6a79450 ; 
006A79440  ldr      x8, [x2, #0x60]
006A79444  mov      x0, x19
006A79448  mov      w1, w20
006A7944C  blr      x8
006A79450  mov      x0, x19
006A79454  mov      x1, xzr
006A79458  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7945C  adrp     x21, #0x959e000
006A79460  ldrb     w8, [x21, #0x4b4]
006A79464  mov      w20, w0
006A79468  cbnz     w8, #0x6a79480
006A7946C  adrp     x0, #0x8f37000
006A79470  ldr      x0, [x0, #0xc50]
006A79474  bl       #0x382bd14 ; 
006A79478  mov      w8, #1
006A7947C  strb     w8, [x21, #0x4b4]
006A79480  adrp     x8, #0x8f37000
006A79484  ldr      x8, [x8, #0xc50]
006A79488  ldr      x2, [x8]
006A7948C  ldrb     w8, [x2, #0x53]
006A79490  tbnz     w8, #5, #0x6a7949c
006A79494  str      w20, [x19, #0x3c]
006A79498  b        #0x6a794ac ; 
006A7949C  ldr      x8, [x2, #0x60]
006A794A0  mov      x0, x19
006A794A4  mov      w1, w20
006A794A8  blr      x8
006A794AC  mov      x0, x19
006A794B0  mov      x1, xzr
006A794B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A794B8  adrp     x21, #0x959e000
006A794BC  ldrb     w8, [x21, #0x4b5]
006A794C0  mov      w20, w0
006A794C4  cbnz     w8, #0x6a794dc
006A794C8  adrp     x0, #0x8f37000
006A794CC  ldr      x0, [x0, #0xc60]
006A794D0  bl       #0x382bd14 ; 
006A794D4  mov      w8, #1
006A794D8  strb     w8, [x21, #0x4b5]
006A794DC  adrp     x8, #0x8f37000
006A794E0  ldr      x8, [x8, #0xc60]
006A794E4  ldr      x2, [x8]
006A794E8  ldrb     w8, [x2, #0x53]
006A794EC  tbnz     w8, #5, #0x6a794f8
006A794F0  str      w20, [x19, #0x40]
006A794F4  b        #0x6a79508 ; 
006A794F8  ldr      x8, [x2, #0x60]
006A794FC  mov      x0, x19
006A79500  mov      w1, w20
006A79504  blr      x8
006A79508  mov      x0, x19
006A7950C  mov      x1, xzr
006A79510  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A79514  adrp     x21, #0x959e000
006A79518  ldrb     w8, [x21, #0x4b6]
006A7951C  mov      x20, x0
006A79520  cbnz     w8, #0x6a79538
006A79524  adrp     x0, #0x8f37000
006A79528  ldr      x0, [x0, #0xc70]
006A7952C  bl       #0x382bd14 ; 
006A79530  mov      w8, #1
006A79534  strb     w8, [x21, #0x4b6]
006A79538  adrp     x8, #0x8f37000
006A7953C  ldr      x8, [x8, #0xc70]
006A79540  ldr      x2, [x8]
006A79544  ldrb     w8, [x2, #0x53]
006A79548  tbnz     w8, #5, #0x6a79560
006A7954C  mov      x0, x19
006A79550  str      x20, [x0, #0x48]!
006A79554  mov      x1, x20
006A79558  bl       #0x382bcb8 ; 
006A7955C  b        #0x6a79570 ; 
006A79560  ldr      x8, [x2, #0x60]
006A79564  mov      x0, x19
006A79568  mov      x1, x20
006A7956C  blr      x8
006A79570  mov      x0, x19
006A79574  mov      x1, xzr
006A79578  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7957C  adrp     x21, #0x959e000
006A79580  ldrb     w8, [x21, #0x4b7]
006A79584  mov      x20, x0
006A79588  cbnz     w8, #0x6a795a0
006A7958C  adrp     x0, #0x8f37000
006A79590  ldr      x0, [x0, #0xc80]
006A79594  bl       #0x382bd14 ; 
006A79598  mov      w8, #1
006A7959C  strb     w8, [x21, #0x4b7]
006A795A0  adrp     x8, #0x8f37000
006A795A4  ldr      x8, [x8, #0xc80]
006A795A8  ldr      x2, [x8]
006A795AC  ldrb     w8, [x2, #0x53]
006A795B0  tbnz     w8, #5, #0x6a795c8
006A795B4  str      x20, [x19, #0x50]!
006A795B8  mov      x0, x19
006A795BC  mov      x1, x20
006A795C0  bl       #0x382bcb8 ; 
006A795C4  b        #0x6a795d8 ; 
006A795C8  ldr      x8, [x2, #0x60]
006A795CC  mov      x0, x19
006A795D0  mov      x1, x20
006A795D4  blr      x8
006A795D8  ldp      x20, x19, [sp, #0x10]
006A795DC  mov      w0, #1
006A795E0  ldp      x30, x21, [sp], #0x20
006A795E4  ret      

