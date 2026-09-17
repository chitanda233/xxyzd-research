; LocalModels.Bean.Module_moduleInfo$$readImpl
; RVA 0x6ACAB0C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ACAB0C  stp      x30, x21, [sp, #-0x20]!
006ACAB10  stp      x20, x19, [sp, #0x10]
006ACAB14  adrp     x20, #0x959e000
006ACAB18  adrp     x21, #0x8f3b000
006ACAB1C  ldrb     w8, [x20, #0xa78]
006ACAB20  ldr      x21, [x21, #0xa08]
006ACAB24  mov      x19, x0
006ACAB28  tbnz     w8, #0, #0x6acab40
006ACAB2C  adrp     x0, #0x8f3b000
006ACAB30  ldr      x0, [x0, #0xa08]
006ACAB34  bl       #0x382bd14 ; 
006ACAB38  mov      w8, #1
006ACAB3C  strb     w8, [x20, #0xa78]
006ACAB40  ldr      x1, [x21]
006ACAB44  ldrb     w8, [x1, #0x53]
006ACAB48  tbnz     w8, #5, #0x6acab98
006ACAB4C  mov      x0, x19
006ACAB50  mov      x1, xzr
006ACAB54  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACAB58  adrp     x21, #0x959f000
006ACAB5C  ldrb     w8, [x21, #0xa5]
006ACAB60  mov      w20, w0
006ACAB64  cbnz     w8, #0x6acab7c
006ACAB68  adrp     x0, #0x8f3b000
006ACAB6C  ldr      x0, [x0, #0x9e0]
006ACAB70  bl       #0x382bd14 ; 
006ACAB74  mov      w8, #1
006ACAB78  strb     w8, [x21, #0xa5]
006ACAB7C  adrp     x8, #0x8f3b000
006ACAB80  ldr      x8, [x8, #0x9e0]
006ACAB84  ldr      x2, [x8]
006ACAB88  ldrb     w8, [x2, #0x53]
006ACAB8C  tbnz     w8, #5, #0x6acabac
006ACAB90  str      w20, [x19, #0x20]
006ACAB94  b        #0x6acabbc ; 
006ACAB98  ldr      x2, [x1, #0x60]
006ACAB9C  mov      x0, x19
006ACABA0  ldp      x20, x19, [sp, #0x10]
006ACABA4  ldp      x30, x21, [sp], #0x20
006ACABA8  br       x2
006ACABAC  ldr      x8, [x2, #0x60]
006ACABB0  mov      x0, x19
006ACABB4  mov      w1, w20
006ACABB8  blr      x8
006ACABBC  mov      x0, x19
006ACABC0  mov      x1, xzr
006ACABC4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACABC8  adrp     x21, #0x959f000
006ACABCC  ldrb     w8, [x21, #0xa6]
006ACABD0  mov      w20, w0
006ACABD4  cbnz     w8, #0x6acabec
006ACABD8  adrp     x0, #0x8f3b000
006ACABDC  ldr      x0, [x0, #0x9f0]
006ACABE0  bl       #0x382bd14 ; 
006ACABE4  mov      w8, #1
006ACABE8  strb     w8, [x21, #0xa6]
006ACABEC  adrp     x8, #0x8f3b000
006ACABF0  ldr      x8, [x8, #0x9f0]
006ACABF4  ldr      x2, [x8]
006ACABF8  ldrb     w8, [x2, #0x53]
006ACABFC  tbnz     w8, #5, #0x6acac08
006ACAC00  str      w20, [x19, #0x24]
006ACAC04  b        #0x6acac18 ; 
006ACAC08  ldr      x8, [x2, #0x60]
006ACAC0C  mov      x0, x19
006ACAC10  mov      w1, w20
006ACAC14  blr      x8
006ACAC18  mov      x0, x19
006ACAC1C  mov      x1, xzr
006ACAC20  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ACAC24  adrp     x21, #0x959f000
006ACAC28  ldrb     w8, [x21, #0xa7]
006ACAC2C  mov      w20, w0
006ACAC30  cbnz     w8, #0x6acac48
006ACAC34  adrp     x0, #0x8f3b000
006ACAC38  ldr      x0, [x0, #0xa00]
006ACAC3C  bl       #0x382bd14 ; 
006ACAC40  mov      w8, #1
006ACAC44  strb     w8, [x21, #0xa7]
006ACAC48  adrp     x8, #0x8f3b000
006ACAC4C  ldr      x8, [x8, #0xa00]
006ACAC50  ldr      x2, [x8]
006ACAC54  ldrb     w8, [x2, #0x53]
006ACAC58  tbnz     w8, #5, #0x6acac64
006ACAC5C  str      w20, [x19, #0x28]
006ACAC60  b        #0x6acac74 ; 
006ACAC64  ldr      x8, [x2, #0x60]
006ACAC68  mov      x0, x19
006ACAC6C  mov      w1, w20
006ACAC70  blr      x8
006ACAC74  ldp      x20, x19, [sp, #0x10]
006ACAC78  mov      w0, #1
006ACAC7C  ldp      x30, x21, [sp], #0x20
006ACAC80  ret      

