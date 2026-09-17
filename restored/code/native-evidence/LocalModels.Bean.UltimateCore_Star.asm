; LocalModels.Bean.UltimateCore_Star$$readImpl
; RVA 0x6B1CA00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B1CA00  stp      x30, x21, [sp, #-0x20]!
006B1CA04  stp      x20, x19, [sp, #0x10]
006B1CA08  adrp     x20, #0x959f000
006B1CA0C  adrp     x21, #0x8f3f000
006B1CA10  ldrb     w8, [x20, #0x67e]
006B1CA14  ldr      x21, [x21, #0x578]
006B1CA18  mov      x19, x0
006B1CA1C  tbnz     w8, #0, #0x6b1ca34
006B1CA20  adrp     x0, #0x8f3f000
006B1CA24  ldr      x0, [x0, #0x578]
006B1CA28  bl       #0x382bd14 ; 
006B1CA2C  mov      w8, #1
006B1CA30  strb     w8, [x20, #0x67e]
006B1CA34  ldr      x1, [x21]
006B1CA38  ldrb     w8, [x1, #0x53]
006B1CA3C  tbnz     w8, #5, #0x6b1ca8c
006B1CA40  mov      x0, x19
006B1CA44  mov      x1, xzr
006B1CA48  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1CA4C  adrp     x21, #0x959f000
006B1CA50  ldrb     w8, [x21, #0xa29]
006B1CA54  mov      w20, w0
006B1CA58  cbnz     w8, #0x6b1ca70
006B1CA5C  adrp     x0, #0x8f3f000
006B1CA60  ldr      x0, [x0, #0x518]
006B1CA64  bl       #0x382bd14 ; 
006B1CA68  mov      w8, #1
006B1CA6C  strb     w8, [x21, #0xa29]
006B1CA70  adrp     x8, #0x8f3f000
006B1CA74  ldr      x8, [x8, #0x518]
006B1CA78  ldr      x2, [x8]
006B1CA7C  ldrb     w8, [x2, #0x53]
006B1CA80  tbnz     w8, #5, #0x6b1caa0
006B1CA84  str      w20, [x19, #0x20]
006B1CA88  b        #0x6b1cab0 ; 
006B1CA8C  ldr      x2, [x1, #0x60]
006B1CA90  mov      x0, x19
006B1CA94  ldp      x20, x19, [sp, #0x10]
006B1CA98  ldp      x30, x21, [sp], #0x20
006B1CA9C  br       x2
006B1CAA0  ldr      x8, [x2, #0x60]
006B1CAA4  mov      x0, x19
006B1CAA8  mov      w1, w20
006B1CAAC  blr      x8
006B1CAB0  mov      x0, x19
006B1CAB4  mov      x1, xzr
006B1CAB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1CABC  adrp     x21, #0x959f000
006B1CAC0  ldrb     w8, [x21, #0xa2a]
006B1CAC4  mov      w20, w0
006B1CAC8  cbnz     w8, #0x6b1cae0
006B1CACC  adrp     x0, #0x8f3f000
006B1CAD0  ldr      x0, [x0, #0x528]
006B1CAD4  bl       #0x382bd14 ; 
006B1CAD8  mov      w8, #1
006B1CADC  strb     w8, [x21, #0xa2a]
006B1CAE0  adrp     x8, #0x8f3f000
006B1CAE4  ldr      x8, [x8, #0x528]
006B1CAE8  ldr      x2, [x8]
006B1CAEC  ldrb     w8, [x2, #0x53]
006B1CAF0  tbnz     w8, #5, #0x6b1cafc
006B1CAF4  str      w20, [x19, #0x24]
006B1CAF8  b        #0x6b1cb0c ; 
006B1CAFC  ldr      x8, [x2, #0x60]
006B1CB00  mov      x0, x19
006B1CB04  mov      w1, w20
006B1CB08  blr      x8
006B1CB0C  mov      x0, x19
006B1CB10  mov      x1, xzr
006B1CB14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1CB18  adrp     x21, #0x959f000
006B1CB1C  ldrb     w8, [x21, #0xa2b]
006B1CB20  mov      w20, w0
006B1CB24  cbnz     w8, #0x6b1cb3c
006B1CB28  adrp     x0, #0x8f3f000
006B1CB2C  ldr      x0, [x0, #0x538]
006B1CB30  bl       #0x382bd14 ; 
006B1CB34  mov      w8, #1
006B1CB38  strb     w8, [x21, #0xa2b]
006B1CB3C  adrp     x8, #0x8f3f000
006B1CB40  ldr      x8, [x8, #0x538]
006B1CB44  ldr      x2, [x8]
006B1CB48  ldrb     w8, [x2, #0x53]
006B1CB4C  tbnz     w8, #5, #0x6b1cb58
006B1CB50  str      w20, [x19, #0x28]
006B1CB54  b        #0x6b1cb68 ; 
006B1CB58  ldr      x8, [x2, #0x60]
006B1CB5C  mov      x0, x19
006B1CB60  mov      w1, w20
006B1CB64  blr      x8
006B1CB68  mov      x0, x19
006B1CB6C  mov      x1, xzr
006B1CB70  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006B1CB74  adrp     x21, #0x959f000
006B1CB78  ldrb     w8, [x21, #0xa2c]
006B1CB7C  mov      x20, x0
006B1CB80  cbnz     w8, #0x6b1cb98
006B1CB84  adrp     x0, #0x8f3f000
006B1CB88  ldr      x0, [x0, #0x548]
006B1CB8C  bl       #0x382bd14 ; 
006B1CB90  mov      w8, #1
006B1CB94  strb     w8, [x21, #0xa2c]
006B1CB98  adrp     x8, #0x8f3f000
006B1CB9C  ldr      x8, [x8, #0x548]
006B1CBA0  ldr      x2, [x8]
006B1CBA4  ldrb     w8, [x2, #0x53]
006B1CBA8  tbnz     w8, #5, #0x6b1cbc0
006B1CBAC  mov      x0, x19
006B1CBB0  str      x20, [x0, #0x30]!
006B1CBB4  mov      x1, x20
006B1CBB8  bl       #0x382bcb8 ; 
006B1CBBC  b        #0x6b1cbd0 ; 
006B1CBC0  ldr      x8, [x2, #0x60]
006B1CBC4  mov      x0, x19
006B1CBC8  mov      x1, x20
006B1CBCC  blr      x8
006B1CBD0  mov      x0, x19
006B1CBD4  mov      x1, xzr
006B1CBD8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006B1CBDC  adrp     x21, #0x959f000
006B1CBE0  ldrb     w8, [x21, #0xa2d]
006B1CBE4  mov      w20, w0
006B1CBE8  cbnz     w8, #0x6b1cc00
006B1CBEC  adrp     x0, #0x8f3f000
006B1CBF0  ldr      x0, [x0, #0x558]
006B1CBF4  bl       #0x382bd14 ; 
006B1CBF8  mov      w8, #1
006B1CBFC  strb     w8, [x21, #0xa2d]
006B1CC00  adrp     x8, #0x8f3f000
006B1CC04  ldr      x8, [x8, #0x558]
006B1CC08  ldr      x2, [x8]
006B1CC0C  ldrb     w8, [x2, #0x53]
006B1CC10  tbnz     w8, #5, #0x6b1cc1c
006B1CC14  str      w20, [x19, #0x38]
006B1CC18  b        #0x6b1cc2c ; 
006B1CC1C  ldr      x8, [x2, #0x60]
006B1CC20  mov      x0, x19
006B1CC24  mov      w1, w20
006B1CC28  blr      x8
006B1CC2C  mov      x0, x19
006B1CC30  mov      x1, xzr
006B1CC34  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B1CC38  adrp     x21, #0x959f000
006B1CC3C  ldrb     w8, [x21, #0xa2e]
006B1CC40  mov      x20, x0
006B1CC44  cbnz     w8, #0x6b1cc5c
006B1CC48  adrp     x0, #0x8f3f000
006B1CC4C  ldr      x0, [x0, #0x560]
006B1CC50  bl       #0x382bd14 ; 
006B1CC54  mov      w8, #1
006B1CC58  strb     w8, [x21, #0xa2e]
006B1CC5C  adrp     x8, #0x8f3f000
006B1CC60  ldr      x8, [x8, #0x560]
006B1CC64  ldr      x2, [x8]
006B1CC68  ldrb     w8, [x2, #0x53]
006B1CC6C  tbnz     w8, #5, #0x6b1cc84
006B1CC70  mov      x0, x19
006B1CC74  str      x20, [x0, #0x40]!
006B1CC78  mov      x1, x20
006B1CC7C  bl       #0x382bcb8 ; 
006B1CC80  b        #0x6b1cc94 ; 
006B1CC84  ldr      x8, [x2, #0x60]
006B1CC88  mov      x0, x19
006B1CC8C  mov      x1, x20
006B1CC90  blr      x8
006B1CC94  mov      x0, x19
006B1CC98  mov      x1, xzr
006B1CC9C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B1CCA0  adrp     x21, #0x959f000
006B1CCA4  ldrb     w8, [x21, #0xa2f]
006B1CCA8  mov      x20, x0
006B1CCAC  cbnz     w8, #0x6b1ccc4
006B1CCB0  adrp     x0, #0x8f3f000
006B1CCB4  ldr      x0, [x0, #0x568]
006B1CCB8  bl       #0x382bd14 ; 
006B1CCBC  mov      w8, #1
006B1CCC0  strb     w8, [x21, #0xa2f]
006B1CCC4  adrp     x8, #0x8f3f000
006B1CCC8  ldr      x8, [x8, #0x568]
006B1CCCC  ldr      x2, [x8]
006B1CCD0  ldrb     w8, [x2, #0x53]
006B1CCD4  tbnz     w8, #5, #0x6b1ccec
006B1CCD8  mov      x0, x19
006B1CCDC  str      x20, [x0, #0x48]!
006B1CCE0  mov      x1, x20
006B1CCE4  bl       #0x382bcb8 ; 
006B1CCE8  b        #0x6b1ccfc ; 
006B1CCEC  ldr      x8, [x2, #0x60]
006B1CCF0  mov      x0, x19
006B1CCF4  mov      x1, x20
006B1CCF8  blr      x8
006B1CCFC  mov      x0, x19
006B1CD00  mov      x1, xzr
006B1CD04  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006B1CD08  adrp     x21, #0x959f000
006B1CD0C  ldrb     w8, [x21, #0xa30]
006B1CD10  mov      x20, x0
006B1CD14  cbnz     w8, #0x6b1cd2c
006B1CD18  adrp     x0, #0x8f3f000
006B1CD1C  ldr      x0, [x0, #0x570]
006B1CD20  bl       #0x382bd14 ; 
006B1CD24  mov      w8, #1
006B1CD28  strb     w8, [x21, #0xa30]
006B1CD2C  adrp     x8, #0x8f3f000
006B1CD30  ldr      x8, [x8, #0x570]
006B1CD34  ldr      x2, [x8]
006B1CD38  ldrb     w8, [x2, #0x53]
006B1CD3C  tbnz     w8, #5, #0x6b1cd54
006B1CD40  str      x20, [x19, #0x50]!
006B1CD44  mov      x0, x19
006B1CD48  mov      x1, x20
006B1CD4C  bl       #0x382bcb8 ; 
006B1CD50  b        #0x6b1cd64 ; 
006B1CD54  ldr      x8, [x2, #0x60]
006B1CD58  mov      x0, x19
006B1CD5C  mov      x1, x20
006B1CD60  blr      x8
006B1CD64  ldp      x20, x19, [sp, #0x10]
006B1CD68  mov      w0, #1
006B1CD6C  ldp      x30, x21, [sp], #0x20
006B1CD70  ret      

