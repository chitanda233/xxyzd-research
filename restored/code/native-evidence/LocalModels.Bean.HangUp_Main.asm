; LocalModels.Bean.HangUp_Main$$readImpl
; RVA 0x6A97390; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A97390  stp      x30, x21, [sp, #-0x20]!
006A97394  stp      x20, x19, [sp, #0x10]
006A97398  adrp     x20, #0x959e000
006A9739C  adrp     x21, #0x8f39000
006A973A0  ldrb     w8, [x20, #0x1a8]
006A973A4  ldr      x21, [x21, #0x330]
006A973A8  mov      x19, x0
006A973AC  tbnz     w8, #0, #0x6a973c4
006A973B0  adrp     x0, #0x8f39000
006A973B4  ldr      x0, [x0, #0x330]
006A973B8  bl       #0x382bd14 ; 
006A973BC  mov      w8, #1
006A973C0  strb     w8, [x20, #0x1a8]
006A973C4  ldr      x1, [x21]
006A973C8  ldrb     w8, [x1, #0x53]
006A973CC  tbnz     w8, #5, #0x6a9741c
006A973D0  mov      x0, x19
006A973D4  mov      x1, xzr
006A973D8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A973DC  adrp     x21, #0x959e000
006A973E0  ldrb     w8, [x21, #0x5f3]
006A973E4  mov      w20, w0
006A973E8  cbnz     w8, #0x6a97400
006A973EC  adrp     x0, #0x8f39000
006A973F0  ldr      x0, [x0, #0x2e8]
006A973F4  bl       #0x382bd14 ; 
006A973F8  mov      w8, #1
006A973FC  strb     w8, [x21, #0x5f3]
006A97400  adrp     x8, #0x8f39000
006A97404  ldr      x8, [x8, #0x2e8]
006A97408  ldr      x2, [x8]
006A9740C  ldrb     w8, [x2, #0x53]
006A97410  tbnz     w8, #5, #0x6a97430
006A97414  str      w20, [x19, #0x20]
006A97418  b        #0x6a97440 ; 
006A9741C  ldr      x2, [x1, #0x60]
006A97420  mov      x0, x19
006A97424  ldp      x20, x19, [sp, #0x10]
006A97428  ldp      x30, x21, [sp], #0x20
006A9742C  br       x2
006A97430  ldr      x8, [x2, #0x60]
006A97434  mov      x0, x19
006A97438  mov      w1, w20
006A9743C  blr      x8
006A97440  mov      x0, x19
006A97444  mov      x1, xzr
006A97448  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A9744C  adrp     x21, #0x959e000
006A97450  ldrb     w8, [x21, #0x5f4]
006A97454  mov      x20, x0
006A97458  cbnz     w8, #0x6a97470
006A9745C  adrp     x0, #0x8f39000
006A97460  ldr      x0, [x0, #0x2f8]
006A97464  bl       #0x382bd14 ; 
006A97468  mov      w8, #1
006A9746C  strb     w8, [x21, #0x5f4]
006A97470  adrp     x8, #0x8f39000
006A97474  ldr      x8, [x8, #0x2f8]
006A97478  ldr      x2, [x8]
006A9747C  ldrb     w8, [x2, #0x53]
006A97480  tbnz     w8, #5, #0x6a97498
006A97484  mov      x0, x19
006A97488  str      x20, [x0, #0x28]!
006A9748C  mov      x1, x20
006A97490  bl       #0x382bcb8 ; 
006A97494  b        #0x6a974a8 ; 
006A97498  ldr      x8, [x2, #0x60]
006A9749C  mov      x0, x19
006A974A0  mov      x1, x20
006A974A4  blr      x8
006A974A8  mov      x0, x19
006A974AC  mov      x1, xzr
006A974B0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A974B4  adrp     x21, #0x959e000
006A974B8  ldrb     w8, [x21, #0x5f5]
006A974BC  mov      w20, w0
006A974C0  cbnz     w8, #0x6a974d8
006A974C4  adrp     x0, #0x8f39000
006A974C8  ldr      x0, [x0, #0x308]
006A974CC  bl       #0x382bd14 ; 
006A974D0  mov      w8, #1
006A974D4  strb     w8, [x21, #0x5f5]
006A974D8  adrp     x8, #0x8f39000
006A974DC  ldr      x8, [x8, #0x308]
006A974E0  ldr      x2, [x8]
006A974E4  ldrb     w8, [x2, #0x53]
006A974E8  tbnz     w8, #5, #0x6a974f4
006A974EC  str      w20, [x19, #0x30]
006A974F0  b        #0x6a97504 ; 
006A974F4  ldr      x8, [x2, #0x60]
006A974F8  mov      x0, x19
006A974FC  mov      w1, w20
006A97500  blr      x8
006A97504  mov      x0, x19
006A97508  mov      x1, xzr
006A9750C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A97510  adrp     x21, #0x959e000
006A97514  ldrb     w8, [x21, #0x5f6]
006A97518  mov      w20, w0
006A9751C  cbnz     w8, #0x6a97534
006A97520  adrp     x0, #0x8f39000
006A97524  ldr      x0, [x0, #0x318]
006A97528  bl       #0x382bd14 ; 
006A9752C  mov      w8, #1
006A97530  strb     w8, [x21, #0x5f6]
006A97534  adrp     x8, #0x8f39000
006A97538  ldr      x8, [x8, #0x318]
006A9753C  ldr      x2, [x8]
006A97540  ldrb     w8, [x2, #0x53]
006A97544  tbnz     w8, #5, #0x6a97550
006A97548  str      w20, [x19, #0x34]
006A9754C  b        #0x6a97560 ; 
006A97550  ldr      x8, [x2, #0x60]
006A97554  mov      x0, x19
006A97558  mov      w1, w20
006A9755C  blr      x8
006A97560  mov      x0, x19
006A97564  mov      x1, xzr
006A97568  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A9756C  adrp     x21, #0x959e000
006A97570  ldrb     w8, [x21, #0x5f7]
006A97574  mov      x20, x0
006A97578  cbnz     w8, #0x6a97590
006A9757C  adrp     x0, #0x8f39000
006A97580  ldr      x0, [x0, #0x328]
006A97584  bl       #0x382bd14 ; 
006A97588  mov      w8, #1
006A9758C  strb     w8, [x21, #0x5f7]
006A97590  adrp     x8, #0x8f39000
006A97594  ldr      x8, [x8, #0x328]
006A97598  ldr      x2, [x8]
006A9759C  ldrb     w8, [x2, #0x53]
006A975A0  tbnz     w8, #5, #0x6a975b8
006A975A4  str      x20, [x19, #0x38]!
006A975A8  mov      x0, x19
006A975AC  mov      x1, x20
006A975B0  bl       #0x382bcb8 ; 
006A975B4  b        #0x6a975c8 ; 
006A975B8  ldr      x8, [x2, #0x60]
006A975BC  mov      x0, x19
006A975C0  mov      x1, x20
006A975C4  blr      x8
006A975C8  ldp      x20, x19, [sp, #0x10]
006A975CC  mov      w0, #1
006A975D0  ldp      x30, x21, [sp], #0x20
006A975D4  ret      

