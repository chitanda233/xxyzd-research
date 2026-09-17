; LocalModels.Bean.Relic_Star$$readImpl
; RVA 0x6ADABA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ADABA0  stp      x30, x21, [sp, #-0x20]!
006ADABA4  stp      x20, x19, [sp, #0x10]
006ADABA8  adrp     x20, #0x959e000
006ADABAC  adrp     x21, #0x8f3c000
006ADABB0  ldrb     w8, [x20, #0xc25]
006ADABB4  ldr      x21, [x21, #0x5d8]
006ADABB8  mov      x19, x0
006ADABBC  tbnz     w8, #0, #0x6adabd4
006ADABC0  adrp     x0, #0x8f3c000
006ADABC4  ldr      x0, [x0, #0x5d8]
006ADABC8  bl       #0x382bd14 ; 
006ADABCC  mov      w8, #1
006ADABD0  strb     w8, [x20, #0xc25]
006ADABD4  ldr      x1, [x21]
006ADABD8  ldrb     w8, [x1, #0x53]
006ADABDC  tbnz     w8, #5, #0x6adac2c
006ADABE0  mov      x0, x19
006ADABE4  mov      x1, xzr
006ADABE8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADABEC  adrp     x21, #0x959f000
006ADABF0  ldrb     w8, [x21, #0x150]
006ADABF4  mov      w20, w0
006ADABF8  cbnz     w8, #0x6adac10
006ADABFC  adrp     x0, #0x8f3c000
006ADAC00  ldr      x0, [x0, #0x590]
006ADAC04  bl       #0x382bd14 ; 
006ADAC08  mov      w8, #1
006ADAC0C  strb     w8, [x21, #0x150]
006ADAC10  adrp     x8, #0x8f3c000
006ADAC14  ldr      x8, [x8, #0x590]
006ADAC18  ldr      x2, [x8]
006ADAC1C  ldrb     w8, [x2, #0x53]
006ADAC20  tbnz     w8, #5, #0x6adac40
006ADAC24  str      w20, [x19, #0x20]
006ADAC28  b        #0x6adac50 ; 
006ADAC2C  ldr      x2, [x1, #0x60]
006ADAC30  mov      x0, x19
006ADAC34  ldp      x20, x19, [sp, #0x10]
006ADAC38  ldp      x30, x21, [sp], #0x20
006ADAC3C  br       x2
006ADAC40  ldr      x8, [x2, #0x60]
006ADAC44  mov      x0, x19
006ADAC48  mov      w1, w20
006ADAC4C  blr      x8
006ADAC50  mov      x0, x19
006ADAC54  mov      x1, xzr
006ADAC58  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADAC5C  adrp     x21, #0x959f000
006ADAC60  ldrb     w8, [x21, #0x151]
006ADAC64  mov      w20, w0
006ADAC68  cbnz     w8, #0x6adac80
006ADAC6C  adrp     x0, #0x8f3c000
006ADAC70  ldr      x0, [x0, #0x5a0]
006ADAC74  bl       #0x382bd14 ; 
006ADAC78  mov      w8, #1
006ADAC7C  strb     w8, [x21, #0x151]
006ADAC80  adrp     x8, #0x8f3c000
006ADAC84  ldr      x8, [x8, #0x5a0]
006ADAC88  ldr      x2, [x8]
006ADAC8C  ldrb     w8, [x2, #0x53]
006ADAC90  tbnz     w8, #5, #0x6adac9c
006ADAC94  str      w20, [x19, #0x24]
006ADAC98  b        #0x6adacac ; 
006ADAC9C  ldr      x8, [x2, #0x60]
006ADACA0  mov      x0, x19
006ADACA4  mov      w1, w20
006ADACA8  blr      x8
006ADACAC  mov      x0, x19
006ADACB0  mov      x1, xzr
006ADACB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADACB8  adrp     x21, #0x959f000
006ADACBC  ldrb     w8, [x21, #0x152]
006ADACC0  mov      w20, w0
006ADACC4  cbnz     w8, #0x6adacdc
006ADACC8  adrp     x0, #0x8f3c000
006ADACCC  ldr      x0, [x0, #0x5b0]
006ADACD0  bl       #0x382bd14 ; 
006ADACD4  mov      w8, #1
006ADACD8  strb     w8, [x21, #0x152]
006ADACDC  adrp     x8, #0x8f3c000
006ADACE0  ldr      x8, [x8, #0x5b0]
006ADACE4  ldr      x2, [x8]
006ADACE8  ldrb     w8, [x2, #0x53]
006ADACEC  tbnz     w8, #5, #0x6adacf8
006ADACF0  str      w20, [x19, #0x28]
006ADACF4  b        #0x6adad08 ; 
006ADACF8  ldr      x8, [x2, #0x60]
006ADACFC  mov      x0, x19
006ADAD00  mov      w1, w20
006ADAD04  blr      x8
006ADAD08  mov      x0, x19
006ADAD0C  mov      x1, xzr
006ADAD10  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006ADAD14  adrp     x21, #0x959f000
006ADAD18  ldrb     w8, [x21, #0x153]
006ADAD1C  mov      x20, x0
006ADAD20  cbnz     w8, #0x6adad38
006ADAD24  adrp     x0, #0x8f3c000
006ADAD28  ldr      x0, [x0, #0x5c0]
006ADAD2C  bl       #0x382bd14 ; 
006ADAD30  mov      w8, #1
006ADAD34  strb     w8, [x21, #0x153]
006ADAD38  adrp     x8, #0x8f3c000
006ADAD3C  ldr      x8, [x8, #0x5c0]
006ADAD40  ldr      x2, [x8]
006ADAD44  ldrb     w8, [x2, #0x53]
006ADAD48  tbnz     w8, #5, #0x6adad60
006ADAD4C  mov      x0, x19
006ADAD50  str      x20, [x0, #0x30]!
006ADAD54  mov      x1, x20
006ADAD58  bl       #0x382bcb8 ; 
006ADAD5C  b        #0x6adad70 ; 
006ADAD60  ldr      x8, [x2, #0x60]
006ADAD64  mov      x0, x19
006ADAD68  mov      x1, x20
006ADAD6C  blr      x8
006ADAD70  mov      x0, x19
006ADAD74  mov      x1, xzr
006ADAD78  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADAD7C  adrp     x21, #0x959f000
006ADAD80  ldrb     w8, [x21, #0x154]
006ADAD84  mov      x20, x0
006ADAD88  cbnz     w8, #0x6adada0
006ADAD8C  adrp     x0, #0x8f3c000
006ADAD90  ldr      x0, [x0, #0x5c8]
006ADAD94  bl       #0x382bd14 ; 
006ADAD98  mov      w8, #1
006ADAD9C  strb     w8, [x21, #0x154]
006ADADA0  adrp     x8, #0x8f3c000
006ADADA4  ldr      x8, [x8, #0x5c8]
006ADADA8  ldr      x2, [x8]
006ADADAC  ldrb     w8, [x2, #0x53]
006ADADB0  tbnz     w8, #5, #0x6adadc8
006ADADB4  mov      x0, x19
006ADADB8  str      x20, [x0, #0x38]!
006ADADBC  mov      x1, x20
006ADADC0  bl       #0x382bcb8 ; 
006ADADC4  b        #0x6adadd8 ; 
006ADADC8  ldr      x8, [x2, #0x60]
006ADADCC  mov      x0, x19
006ADADD0  mov      x1, x20
006ADADD4  blr      x8
006ADADD8  mov      x0, x19
006ADADDC  mov      x1, xzr
006ADADE0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADADE4  adrp     x21, #0x959f000
006ADADE8  ldrb     w8, [x21, #0x155]
006ADADEC  mov      x20, x0
006ADADF0  cbnz     w8, #0x6adae08
006ADADF4  adrp     x0, #0x8f3c000
006ADADF8  ldr      x0, [x0, #0x5d0]
006ADADFC  bl       #0x382bd14 ; 
006ADAE00  mov      w8, #1
006ADAE04  strb     w8, [x21, #0x155]
006ADAE08  adrp     x8, #0x8f3c000
006ADAE0C  ldr      x8, [x8, #0x5d0]
006ADAE10  ldr      x2, [x8]
006ADAE14  ldrb     w8, [x2, #0x53]
006ADAE18  tbnz     w8, #5, #0x6adae30
006ADAE1C  str      x20, [x19, #0x40]!
006ADAE20  mov      x0, x19
006ADAE24  mov      x1, x20
006ADAE28  bl       #0x382bcb8 ; 
006ADAE2C  b        #0x6adae40 ; 
006ADAE30  ldr      x8, [x2, #0x60]
006ADAE34  mov      x0, x19
006ADAE38  mov      x1, x20
006ADAE3C  blr      x8
006ADAE40  ldp      x20, x19, [sp, #0x10]
006ADAE44  mov      w0, #1
006ADAE48  ldp      x30, x21, [sp], #0x20
006ADAE4C  ret      

