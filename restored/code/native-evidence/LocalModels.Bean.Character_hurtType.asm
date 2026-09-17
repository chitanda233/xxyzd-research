; LocalModels.Bean.Character_hurtType$$readImpl
; RVA 0x68C84E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068C84E4  stp      x30, x21, [sp, #-0x20]!
0068C84E8  stp      x20, x19, [sp, #0x10]
0068C84EC  adrp     x20, #0x959c000
0068C84F0  adrp     x21, #0x8f28000
0068C84F4  ldrb     w8, [x20, #0x2d4]
0068C84F8  ldr      x21, [x21, #0x98]
0068C84FC  mov      x19, x0
0068C8500  tbnz     w8, #0, #0x68c8518
0068C8504  adrp     x0, #0x8f28000
0068C8508  ldr      x0, [x0, #0x98]
0068C850C  bl       #0x382bd14 ; 
0068C8510  mov      w8, #1
0068C8514  strb     w8, [x20, #0x2d4]
0068C8518  ldr      x1, [x21]
0068C851C  ldrb     w8, [x1, #0x53]
0068C8520  tbnz     w8, #5, #0x68c8570
0068C8524  mov      x0, x19
0068C8528  mov      x1, xzr
0068C852C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C8530  adrp     x21, #0x959c000
0068C8534  ldrb     w8, [x21, #0x701]
0068C8538  mov      w20, w0
0068C853C  cbnz     w8, #0x68c8554
0068C8540  adrp     x0, #0x8f28000
0068C8544  ldr      x0, [x0, #0x88]
0068C8548  bl       #0x382bd14 ; 
0068C854C  mov      w8, #1
0068C8550  strb     w8, [x21, #0x701]
0068C8554  adrp     x8, #0x8f28000
0068C8558  ldr      x8, [x8, #0x88]
0068C855C  ldr      x2, [x8]
0068C8560  ldrb     w8, [x2, #0x53]
0068C8564  tbnz     w8, #5, #0x68c8584
0068C8568  str      w20, [x19, #0x20]
0068C856C  b        #0x68c8594 ; 
0068C8570  ldr      x2, [x1, #0x60]
0068C8574  mov      x0, x19
0068C8578  ldp      x20, x19, [sp, #0x10]
0068C857C  ldp      x30, x21, [sp], #0x20
0068C8580  br       x2
0068C8584  ldr      x8, [x2, #0x60]
0068C8588  mov      x0, x19
0068C858C  mov      w1, w20
0068C8590  blr      x8
0068C8594  mov      x0, x19
0068C8598  mov      x1, xzr
0068C859C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C85A0  adrp     x21, #0x959c000
0068C85A4  ldrb     w8, [x21, #0x702]
0068C85A8  mov      x20, x0
0068C85AC  cbnz     w8, #0x68c85c4
0068C85B0  adrp     x0, #0x8f28000
0068C85B4  ldr      x0, [x0, #0x90]
0068C85B8  bl       #0x382bd14 ; 
0068C85BC  mov      w8, #1
0068C85C0  strb     w8, [x21, #0x702]
0068C85C4  adrp     x8, #0x8f28000
0068C85C8  ldr      x8, [x8, #0x90]
0068C85CC  ldr      x2, [x8]
0068C85D0  ldrb     w8, [x2, #0x53]
0068C85D4  tbnz     w8, #5, #0x68c85ec
0068C85D8  str      x20, [x19, #0x28]!
0068C85DC  mov      x0, x19
0068C85E0  mov      x1, x20
0068C85E4  bl       #0x382bcb8 ; 
0068C85E8  b        #0x68c85fc ; 
0068C85EC  ldr      x8, [x2, #0x60]
0068C85F0  mov      x0, x19
0068C85F4  mov      x1, x20
0068C85F8  blr      x8
0068C85FC  ldp      x20, x19, [sp, #0x10]
0068C8600  mov      w0, #1
0068C8604  ldp      x30, x21, [sp], #0x20
0068C8608  ret      

