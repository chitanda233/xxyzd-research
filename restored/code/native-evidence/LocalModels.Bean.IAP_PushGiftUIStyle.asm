; LocalModels.Bean.IAP_PushGiftUIStyle$$readImpl
; RVA 0x6AA836C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AA836C  stp      x30, x21, [sp, #-0x20]!
006AA8370  stp      x20, x19, [sp, #0x10]
006AA8374  adrp     x20, #0x959e000
006AA8378  adrp     x21, #0x8f3a000
006AA837C  ldrb     w8, [x20, #0x6f3]
006AA8380  ldr      x21, [x21, #0x58]
006AA8384  mov      x19, x0
006AA8388  tbnz     w8, #0, #0x6aa83a0
006AA838C  adrp     x0, #0x8f3a000
006AA8390  ldr      x0, [x0, #0x58]
006AA8394  bl       #0x382bd14 ; 
006AA8398  mov      w8, #1
006AA839C  strb     w8, [x20, #0x6f3]
006AA83A0  ldr      x1, [x21]
006AA83A4  ldrb     w8, [x1, #0x53]
006AA83A8  tbnz     w8, #5, #0x6aa83f8
006AA83AC  mov      x0, x19
006AA83B0  mov      x1, xzr
006AA83B4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA83B8  adrp     x21, #0x959e000
006AA83BC  ldrb     w8, [x21, #0xf12]
006AA83C0  mov      w20, w0
006AA83C4  cbnz     w8, #0x6aa83dc
006AA83C8  adrp     x0, #0x8f3a000
006AA83CC  ldr      x0, [x0]
006AA83D0  bl       #0x382bd14 ; 
006AA83D4  mov      w8, #1
006AA83D8  strb     w8, [x21, #0xf12]
006AA83DC  adrp     x8, #0x8f3a000
006AA83E0  ldr      x8, [x8]
006AA83E4  ldr      x2, [x8]
006AA83E8  ldrb     w8, [x2, #0x53]
006AA83EC  tbnz     w8, #5, #0x6aa840c
006AA83F0  str      w20, [x19, #0x20]
006AA83F4  b        #0x6aa841c ; 
006AA83F8  ldr      x2, [x1, #0x60]
006AA83FC  mov      x0, x19
006AA8400  ldp      x20, x19, [sp, #0x10]
006AA8404  ldp      x30, x21, [sp], #0x20
006AA8408  br       x2
006AA840C  ldr      x8, [x2, #0x60]
006AA8410  mov      x0, x19
006AA8414  mov      w1, w20
006AA8418  blr      x8
006AA841C  mov      x0, x19
006AA8420  mov      x1, xzr
006AA8424  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA8428  adrp     x21, #0x959e000
006AA842C  ldrb     w8, [x21, #0xf13]
006AA8430  mov      w20, w0
006AA8434  cbnz     w8, #0x6aa844c
006AA8438  adrp     x0, #0x8f3a000
006AA843C  ldr      x0, [x0, #0x10]
006AA8440  bl       #0x382bd14 ; 
006AA8444  mov      w8, #1
006AA8448  strb     w8, [x21, #0xf13]
006AA844C  adrp     x8, #0x8f3a000
006AA8450  ldr      x8, [x8, #0x10]
006AA8454  ldr      x2, [x8]
006AA8458  ldrb     w8, [x2, #0x53]
006AA845C  tbnz     w8, #5, #0x6aa8468
006AA8460  str      w20, [x19, #0x24]
006AA8464  b        #0x6aa8478 ; 
006AA8468  ldr      x8, [x2, #0x60]
006AA846C  mov      x0, x19
006AA8470  mov      w1, w20
006AA8474  blr      x8
006AA8478  mov      x0, x19
006AA847C  mov      x1, xzr
006AA8480  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA8484  adrp     x21, #0x959e000
006AA8488  ldrb     w8, [x21, #0xf14]
006AA848C  mov      x20, x0
006AA8490  cbnz     w8, #0x6aa84a8
006AA8494  adrp     x0, #0x8f3a000
006AA8498  ldr      x0, [x0, #0x20]
006AA849C  bl       #0x382bd14 ; 
006AA84A0  mov      w8, #1
006AA84A4  strb     w8, [x21, #0xf14]
006AA84A8  adrp     x8, #0x8f3a000
006AA84AC  ldr      x8, [x8, #0x20]
006AA84B0  ldr      x2, [x8]
006AA84B4  ldrb     w8, [x2, #0x53]
006AA84B8  tbnz     w8, #5, #0x6aa84d0
006AA84BC  mov      x0, x19
006AA84C0  str      x20, [x0, #0x28]!
006AA84C4  mov      x1, x20
006AA84C8  bl       #0x382bcb8 ; 
006AA84CC  b        #0x6aa84e0 ; 
006AA84D0  ldr      x8, [x2, #0x60]
006AA84D4  mov      x0, x19
006AA84D8  mov      x1, x20
006AA84DC  blr      x8
006AA84E0  mov      x0, x19
006AA84E4  mov      x1, xzr
006AA84E8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AA84EC  adrp     x21, #0x959e000
006AA84F0  ldrb     w8, [x21, #0xf15]
006AA84F4  mov      w20, w0
006AA84F8  cbnz     w8, #0x6aa8510
006AA84FC  adrp     x0, #0x8f3a000
006AA8500  ldr      x0, [x0, #0x30]
006AA8504  bl       #0x382bd14 ; 
006AA8508  mov      w8, #1
006AA850C  strb     w8, [x21, #0xf15]
006AA8510  adrp     x8, #0x8f3a000
006AA8514  ldr      x8, [x8, #0x30]
006AA8518  ldr      x2, [x8]
006AA851C  ldrb     w8, [x2, #0x53]
006AA8520  tbnz     w8, #5, #0x6aa852c
006AA8524  str      w20, [x19, #0x30]
006AA8528  b        #0x6aa853c ; 
006AA852C  ldr      x8, [x2, #0x60]
006AA8530  mov      x0, x19
006AA8534  mov      w1, w20
006AA8538  blr      x8
006AA853C  mov      x0, x19
006AA8540  mov      x1, xzr
006AA8544  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA8548  adrp     x21, #0x959e000
006AA854C  ldrb     w8, [x21, #0xf16]
006AA8550  mov      x20, x0
006AA8554  cbnz     w8, #0x6aa856c
006AA8558  adrp     x0, #0x8f3a000
006AA855C  ldr      x0, [x0, #0x40]
006AA8560  bl       #0x382bd14 ; 
006AA8564  mov      w8, #1
006AA8568  strb     w8, [x21, #0xf16]
006AA856C  adrp     x8, #0x8f3a000
006AA8570  ldr      x8, [x8, #0x40]
006AA8574  ldr      x2, [x8]
006AA8578  ldrb     w8, [x2, #0x53]
006AA857C  tbnz     w8, #5, #0x6aa8594
006AA8580  mov      x0, x19
006AA8584  str      x20, [x0, #0x38]!
006AA8588  mov      x1, x20
006AA858C  bl       #0x382bcb8 ; 
006AA8590  b        #0x6aa85a4 ; 
006AA8594  ldr      x8, [x2, #0x60]
006AA8598  mov      x0, x19
006AA859C  mov      x1, x20
006AA85A0  blr      x8
006AA85A4  mov      x0, x19
006AA85A8  mov      x1, xzr
006AA85AC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AA85B0  adrp     x21, #0x959e000
006AA85B4  ldrb     w8, [x21, #0xf17]
006AA85B8  mov      x20, x0
006AA85BC  cbnz     w8, #0x6aa85d4
006AA85C0  adrp     x0, #0x8f3a000
006AA85C4  ldr      x0, [x0, #0x50]
006AA85C8  bl       #0x382bd14 ; 
006AA85CC  mov      w8, #1
006AA85D0  strb     w8, [x21, #0xf17]
006AA85D4  adrp     x8, #0x8f3a000
006AA85D8  ldr      x8, [x8, #0x50]
006AA85DC  ldr      x2, [x8]
006AA85E0  ldrb     w8, [x2, #0x53]
006AA85E4  tbnz     w8, #5, #0x6aa85fc
006AA85E8  str      x20, [x19, #0x40]!
006AA85EC  mov      x0, x19
006AA85F0  mov      x1, x20
006AA85F4  bl       #0x382bcb8 ; 
006AA85F8  b        #0x6aa860c ; 
006AA85FC  ldr      x8, [x2, #0x60]
006AA8600  mov      x0, x19
006AA8604  mov      x1, x20
006AA8608  blr      x8
006AA860C  ldp      x20, x19, [sp, #0x10]
006AA8610  mov      w0, #1
006AA8614  ldp      x30, x21, [sp], #0x20
006AA8618  ret      

