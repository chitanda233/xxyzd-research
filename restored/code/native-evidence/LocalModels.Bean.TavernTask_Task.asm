; LocalModels.Bean.TavernTask_Task$$readImpl
; RVA 0x6B15400; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B15400  stp      x30, x21, [sp, #-0x20]!
006B15404  stp      x20, x19, [sp, #0x10]
006B15408  adrp     x20, #0x959f000
006B1540C  adrp     x21, #0x8f3f000
006B15410  ldrb     w8, [x20, #0x5ba]
006B15414  ldr      x21, [x21, #0x18]
006B15418  mov      x19, x0
006B1541C  tbnz     w8, #0, #0x6b15434
006B15420  adrp     x0, #0x8f3f000
006B15424  ldr      x0, [x0, #0x18]
006B15428  bl       #0x382bd14 ; 
006B1542C  mov      w8, #1
006B15430  strb     w8, [x20, #0x5ba]
006B15434  ldr      x1, [x21]
006B15438  ldrb     w8, [x1, #0x53]
006B1543C  tbnz     w8, #5, #0x6b1548c
006B15440  mov      x0, x19
006B15444  mov      x1, xzr
006B15448  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1544C  adrp     x21, #0x959f000
006B15450  ldrb     w8, [x21, #0x9d7]
006B15454  mov      w20, w0
006B15458  cbnz     w8, #0x6b15470
006B1545C  adrp     x0, #0x8f3e000
006B15460  ldr      x0, [x0, #0xfb0]
006B15464  bl       #0x382bd14 ; 
006B15468  mov      w8, #1
006B1546C  strb     w8, [x21, #0x9d7]
006B15470  adrp     x8, #0x8f3e000
006B15474  ldr      x8, [x8, #0xfb0]
006B15478  ldr      x2, [x8]
006B1547C  ldrb     w8, [x2, #0x53]
006B15480  tbnz     w8, #5, #0x6b154a0
006B15484  str      w20, [x19, #0x20]
006B15488  b        #0x6b154b0 ; 
006B1548C  ldr      x2, [x1, #0x60]
006B15490  mov      x0, x19
006B15494  ldp      x20, x19, [sp, #0x10]
006B15498  ldp      x30, x21, [sp], #0x20
006B1549C  br       x2
006B154A0  ldr      x8, [x2, #0x60]
006B154A4  mov      x0, x19
006B154A8  mov      w1, w20
006B154AC  blr      x8
006B154B0  mov      x0, x19
006B154B4  mov      x1, xzr
006B154B8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B154BC  adrp     x21, #0x959f000
006B154C0  ldrb     w8, [x21, #0x9d8]
006B154C4  mov      w20, w0
006B154C8  cbnz     w8, #0x6b154e0
006B154CC  adrp     x0, #0x8f3e000
006B154D0  ldr      x0, [x0, #0xfc0]
006B154D4  bl       #0x382bd14 ; 
006B154D8  mov      w8, #1
006B154DC  strb     w8, [x21, #0x9d8]
006B154E0  adrp     x8, #0x8f3e000
006B154E4  ldr      x8, [x8, #0xfc0]
006B154E8  ldr      x2, [x8]
006B154EC  ldrb     w8, [x2, #0x53]
006B154F0  tbnz     w8, #5, #0x6b154fc
006B154F4  str      w20, [x19, #0x24]
006B154F8  b        #0x6b1550c ; 
006B154FC  ldr      x8, [x2, #0x60]
006B15500  mov      x0, x19
006B15504  mov      w1, w20
006B15508  blr      x8
006B1550C  mov      x0, x19
006B15510  mov      x1, xzr
006B15514  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B15518  adrp     x21, #0x959f000
006B1551C  ldrb     w8, [x21, #0x9d9]
006B15520  mov      w20, w0
006B15524  cbnz     w8, #0x6b1553c
006B15528  adrp     x0, #0x8f3e000
006B1552C  ldr      x0, [x0, #0xfd0]
006B15530  bl       #0x382bd14 ; 
006B15534  mov      w8, #1
006B15538  strb     w8, [x21, #0x9d9]
006B1553C  adrp     x8, #0x8f3e000
006B15540  ldr      x8, [x8, #0xfd0]
006B15544  ldr      x2, [x8]
006B15548  ldrb     w8, [x2, #0x53]
006B1554C  tbnz     w8, #5, #0x6b15558
006B15550  str      w20, [x19, #0x28]
006B15554  b        #0x6b15568 ; 
006B15558  ldr      x8, [x2, #0x60]
006B1555C  mov      x0, x19
006B15560  mov      w1, w20
006B15564  blr      x8
006B15568  mov      x0, x19
006B1556C  mov      x1, xzr
006B15570  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B15574  adrp     x21, #0x959f000
006B15578  ldrb     w8, [x21, #0x9da]
006B1557C  mov      w20, w0
006B15580  cbnz     w8, #0x6b15598
006B15584  adrp     x0, #0x8f3e000
006B15588  ldr      x0, [x0, #0xfe0]
006B1558C  bl       #0x382bd14 ; 
006B15590  mov      w8, #1
006B15594  strb     w8, [x21, #0x9da]
006B15598  adrp     x8, #0x8f3e000
006B1559C  ldr      x8, [x8, #0xfe0]
006B155A0  ldr      x2, [x8]
006B155A4  ldrb     w8, [x2, #0x53]
006B155A8  tbnz     w8, #5, #0x6b155b4
006B155AC  str      w20, [x19, #0x2c]
006B155B0  b        #0x6b155c4 ; 
006B155B4  ldr      x8, [x2, #0x60]
006B155B8  mov      x0, x19
006B155BC  mov      w1, w20
006B155C0  blr      x8
006B155C4  mov      x0, x19
006B155C8  mov      x1, xzr
006B155CC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B155D0  adrp     x21, #0x959f000
006B155D4  ldrb     w8, [x21, #0x9db]
006B155D8  mov      w20, w0
006B155DC  cbnz     w8, #0x6b155f4
006B155E0  adrp     x0, #0x8f3e000
006B155E4  ldr      x0, [x0, #0xff0]
006B155E8  bl       #0x382bd14 ; 
006B155EC  mov      w8, #1
006B155F0  strb     w8, [x21, #0x9db]
006B155F4  adrp     x8, #0x8f3e000
006B155F8  ldr      x8, [x8, #0xff0]
006B155FC  ldr      x2, [x8]
006B15600  ldrb     w8, [x2, #0x53]
006B15604  tbnz     w8, #5, #0x6b15610
006B15608  str      w20, [x19, #0x30]
006B1560C  b        #0x6b15620 ; 
006B15610  ldr      x8, [x2, #0x60]
006B15614  mov      x0, x19
006B15618  mov      w1, w20
006B1561C  blr      x8
006B15620  mov      x0, x19
006B15624  mov      x1, xzr
006B15628  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1562C  adrp     x21, #0x959f000
006B15630  ldrb     w8, [x21, #0x9dc]
006B15634  mov      w20, w0
006B15638  cbnz     w8, #0x6b15650
006B1563C  adrp     x0, #0x8f3f000
006B15640  ldr      x0, [x0]
006B15644  bl       #0x382bd14 ; 
006B15648  mov      w8, #1
006B1564C  strb     w8, [x21, #0x9dc]
006B15650  adrp     x8, #0x8f3f000
006B15654  ldr      x8, [x8]
006B15658  ldr      x2, [x8]
006B1565C  ldrb     w8, [x2, #0x53]
006B15660  tbnz     w8, #5, #0x6b1566c
006B15664  str      w20, [x19, #0x34]
006B15668  b        #0x6b1567c ; 
006B1566C  ldr      x8, [x2, #0x60]
006B15670  mov      x0, x19
006B15674  mov      w1, w20
006B15678  blr      x8
006B1567C  mov      x0, x19
006B15680  mov      x1, xzr
006B15684  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B15688  adrp     x21, #0x959f000
006B1568C  ldrb     w8, [x21, #0x9dd]
006B15690  mov      x20, x0
006B15694  cbnz     w8, #0x6b156ac
006B15698  adrp     x0, #0x8f3f000
006B1569C  ldr      x0, [x0, #0x10]
006B156A0  bl       #0x382bd14 ; 
006B156A4  mov      w8, #1
006B156A8  strb     w8, [x21, #0x9dd]
006B156AC  adrp     x8, #0x8f3f000
006B156B0  ldr      x8, [x8, #0x10]
006B156B4  ldr      x2, [x8]
006B156B8  ldrb     w8, [x2, #0x53]
006B156BC  tbnz     w8, #5, #0x6b156d4
006B156C0  str      x20, [x19, #0x38]!
006B156C4  mov      x0, x19
006B156C8  mov      x1, x20
006B156CC  bl       #0x382bcb8 ; 
006B156D0  b        #0x6b156e4 ; 
006B156D4  ldr      x8, [x2, #0x60]
006B156D8  mov      x0, x19
006B156DC  mov      x1, x20
006B156E0  blr      x8
006B156E4  ldp      x20, x19, [sp, #0x10]
006B156E8  mov      w0, #1
006B156EC  ldp      x30, x21, [sp], #0x20
006B156F0  ret      

