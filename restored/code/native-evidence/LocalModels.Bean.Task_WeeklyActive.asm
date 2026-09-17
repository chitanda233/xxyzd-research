; LocalModels.Bean.Task_WeeklyActive$$readImpl
; RVA 0x6B14774; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B14774  stp      x30, x21, [sp, #-0x20]!
006B14778  stp      x20, x19, [sp, #0x10]
006B1477C  adrp     x20, #0x959f000
006B14780  adrp     x21, #0x8f3e000
006B14784  ldrb     w8, [x20, #0x5a2]
006B14788  ldr      x21, [x21, #0xf68]
006B1478C  mov      x19, x0
006B14790  tbnz     w8, #0, #0x6b147a8
006B14794  adrp     x0, #0x8f3e000
006B14798  ldr      x0, [x0, #0xf68]
006B1479C  bl       #0x382bd14 ; 
006B147A0  mov      w8, #1
006B147A4  strb     w8, [x20, #0x5a2]
006B147A8  ldr      x1, [x21]
006B147AC  ldrb     w8, [x1, #0x53]
006B147B0  tbnz     w8, #5, #0x6b14800
006B147B4  mov      x0, x19
006B147B8  mov      x1, xzr
006B147BC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B147C0  adrp     x21, #0x959f000
006B147C4  ldrb     w8, [x21, #0x9d2]
006B147C8  mov      w20, w0
006B147CC  cbnz     w8, #0x6b147e4
006B147D0  adrp     x0, #0x8f3e000
006B147D4  ldr      x0, [x0, #0xf40]
006B147D8  bl       #0x382bd14 ; 
006B147DC  mov      w8, #1
006B147E0  strb     w8, [x21, #0x9d2]
006B147E4  adrp     x8, #0x8f3e000
006B147E8  ldr      x8, [x8, #0xf40]
006B147EC  ldr      x2, [x8]
006B147F0  ldrb     w8, [x2, #0x53]
006B147F4  tbnz     w8, #5, #0x6b14814
006B147F8  str      w20, [x19, #0x20]
006B147FC  b        #0x6b14824 ; 
006B14800  ldr      x2, [x1, #0x60]
006B14804  mov      x0, x19
006B14808  ldp      x20, x19, [sp, #0x10]
006B1480C  ldp      x30, x21, [sp], #0x20
006B14810  br       x2
006B14814  ldr      x8, [x2, #0x60]
006B14818  mov      x0, x19
006B1481C  mov      w1, w20
006B14820  blr      x8
006B14824  mov      x0, x19
006B14828  mov      x1, xzr
006B1482C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B14830  adrp     x21, #0x959f000
006B14834  ldrb     w8, [x21, #0x9d3]
006B14838  mov      w20, w0
006B1483C  cbnz     w8, #0x6b14854
006B14840  adrp     x0, #0x8f3e000
006B14844  ldr      x0, [x0, #0xf50]
006B14848  bl       #0x382bd14 ; 
006B1484C  mov      w8, #1
006B14850  strb     w8, [x21, #0x9d3]
006B14854  adrp     x8, #0x8f3e000
006B14858  ldr      x8, [x8, #0xf50]
006B1485C  ldr      x2, [x8]
006B14860  ldrb     w8, [x2, #0x53]
006B14864  tbnz     w8, #5, #0x6b14870
006B14868  str      w20, [x19, #0x24]
006B1486C  b        #0x6b14880 ; 
006B14870  ldr      x8, [x2, #0x60]
006B14874  mov      x0, x19
006B14878  mov      w1, w20
006B1487C  blr      x8
006B14880  mov      x0, x19
006B14884  mov      x1, xzr
006B14888  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B1488C  adrp     x21, #0x959f000
006B14890  ldrb     w8, [x21, #0x9d4]
006B14894  mov      x20, x0
006B14898  cbnz     w8, #0x6b148b0
006B1489C  adrp     x0, #0x8f3e000
006B148A0  ldr      x0, [x0, #0xf60]
006B148A4  bl       #0x382bd14 ; 
006B148A8  mov      w8, #1
006B148AC  strb     w8, [x21, #0x9d4]
006B148B0  adrp     x8, #0x8f3e000
006B148B4  ldr      x8, [x8, #0xf60]
006B148B8  ldr      x2, [x8]
006B148BC  ldrb     w8, [x2, #0x53]
006B148C0  tbnz     w8, #5, #0x6b148d8
006B148C4  str      x20, [x19, #0x28]!
006B148C8  mov      x0, x19
006B148CC  mov      x1, x20
006B148D0  bl       #0x382bcb8 ; 
006B148D4  b        #0x6b148e8 ; 
006B148D8  ldr      x8, [x2, #0x60]
006B148DC  mov      x0, x19
006B148E0  mov      x1, x20
006B148E4  blr      x8
006B148E8  ldp      x20, x19, [sp, #0x10]
006B148EC  mov      w0, #1
006B148F0  ldp      x30, x21, [sp], #0x20
006B148F4  ret      

