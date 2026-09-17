; LocalModels.Bean.Guild_guildBossTask$$readImpl
; RVA 0x6A8ECAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A8ECAC  stp      x30, x21, [sp, #-0x20]!
006A8ECB0  stp      x20, x19, [sp, #0x10]
006A8ECB4  adrp     x20, #0x959e000
006A8ECB8  adrp     x21, #0x8f38000
006A8ECBC  ldrb     w8, [x20, #0xc7]
006A8ECC0  ldr      x21, [x21, #0xca8]
006A8ECC4  mov      x19, x0
006A8ECC8  tbnz     w8, #0, #0x6a8ece0
006A8ECCC  adrp     x0, #0x8f38000
006A8ECD0  ldr      x0, [x0, #0xca8]
006A8ECD4  bl       #0x382bd14 ; 
006A8ECD8  mov      w8, #1
006A8ECDC  strb     w8, [x20, #0xc7]
006A8ECE0  ldr      x1, [x21]
006A8ECE4  ldrb     w8, [x1, #0x53]
006A8ECE8  tbnz     w8, #5, #0x6a8ed38
006A8ECEC  mov      x0, x19
006A8ECF0  mov      x1, xzr
006A8ECF4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8ECF8  adrp     x21, #0x959e000
006A8ECFC  ldrb     w8, [x21, #0x598]
006A8ED00  mov      w20, w0
006A8ED04  cbnz     w8, #0x6a8ed1c
006A8ED08  adrp     x0, #0x8f38000
006A8ED0C  ldr      x0, [x0, #0xc50]
006A8ED10  bl       #0x382bd14 ; 
006A8ED14  mov      w8, #1
006A8ED18  strb     w8, [x21, #0x598]
006A8ED1C  adrp     x8, #0x8f38000
006A8ED20  ldr      x8, [x8, #0xc50]
006A8ED24  ldr      x2, [x8]
006A8ED28  ldrb     w8, [x2, #0x53]
006A8ED2C  tbnz     w8, #5, #0x6a8ed4c
006A8ED30  str      w20, [x19, #0x20]
006A8ED34  b        #0x6a8ed5c ; 
006A8ED38  ldr      x2, [x1, #0x60]
006A8ED3C  mov      x0, x19
006A8ED40  ldp      x20, x19, [sp, #0x10]
006A8ED44  ldp      x30, x21, [sp], #0x20
006A8ED48  br       x2
006A8ED4C  ldr      x8, [x2, #0x60]
006A8ED50  mov      x0, x19
006A8ED54  mov      w1, w20
006A8ED58  blr      x8
006A8ED5C  mov      x0, x19
006A8ED60  mov      x1, xzr
006A8ED64  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8ED68  adrp     x21, #0x959e000
006A8ED6C  ldrb     w8, [x21, #0x599]
006A8ED70  mov      w20, w0
006A8ED74  cbnz     w8, #0x6a8ed8c
006A8ED78  adrp     x0, #0x8f38000
006A8ED7C  ldr      x0, [x0, #0xc60]
006A8ED80  bl       #0x382bd14 ; 
006A8ED84  mov      w8, #1
006A8ED88  strb     w8, [x21, #0x599]
006A8ED8C  adrp     x8, #0x8f38000
006A8ED90  ldr      x8, [x8, #0xc60]
006A8ED94  ldr      x2, [x8]
006A8ED98  ldrb     w8, [x2, #0x53]
006A8ED9C  tbnz     w8, #5, #0x6a8eda8
006A8EDA0  str      w20, [x19, #0x24]
006A8EDA4  b        #0x6a8edb8 ; 
006A8EDA8  ldr      x8, [x2, #0x60]
006A8EDAC  mov      x0, x19
006A8EDB0  mov      w1, w20
006A8EDB4  blr      x8
006A8EDB8  mov      x0, x19
006A8EDBC  mov      x1, xzr
006A8EDC0  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006A8EDC4  adrp     x21, #0x959e000
006A8EDC8  ldrb     w8, [x21, #0x59a]
006A8EDCC  mov      x20, x0
006A8EDD0  cbnz     w8, #0x6a8ede8
006A8EDD4  adrp     x0, #0x8f38000
006A8EDD8  ldr      x0, [x0, #0xc70]
006A8EDDC  bl       #0x382bd14 ; 
006A8EDE0  mov      w8, #1
006A8EDE4  strb     w8, [x21, #0x59a]
006A8EDE8  adrp     x8, #0x8f38000
006A8EDEC  ldr      x8, [x8, #0xc70]
006A8EDF0  ldr      x2, [x8]
006A8EDF4  ldrb     w8, [x2, #0x53]
006A8EDF8  tbnz     w8, #5, #0x6a8ee04
006A8EDFC  str      x20, [x19, #0x28]
006A8EE00  b        #0x6a8ee14 ; 
006A8EE04  ldr      x8, [x2, #0x60]
006A8EE08  mov      x0, x19
006A8EE0C  mov      x1, x20
006A8EE10  blr      x8
006A8EE14  mov      x0, x19
006A8EE18  mov      x1, xzr
006A8EE1C  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A8EE20  adrp     x21, #0x959e000
006A8EE24  ldrb     w8, [x21, #0x59b]
006A8EE28  mov      x20, x0
006A8EE2C  cbnz     w8, #0x6a8ee44
006A8EE30  adrp     x0, #0x8f38000
006A8EE34  ldr      x0, [x0, #0xc80]
006A8EE38  bl       #0x382bd14 ; 
006A8EE3C  mov      w8, #1
006A8EE40  strb     w8, [x21, #0x59b]
006A8EE44  adrp     x8, #0x8f38000
006A8EE48  ldr      x8, [x8, #0xc80]
006A8EE4C  ldr      x2, [x8]
006A8EE50  ldrb     w8, [x2, #0x53]
006A8EE54  tbnz     w8, #5, #0x6a8ee6c
006A8EE58  mov      x0, x19
006A8EE5C  str      x20, [x0, #0x30]!
006A8EE60  mov      x1, x20
006A8EE64  bl       #0x382bcb8 ; 
006A8EE68  b        #0x6a8ee7c ; 
006A8EE6C  ldr      x8, [x2, #0x60]
006A8EE70  mov      x0, x19
006A8EE74  mov      x1, x20
006A8EE78  blr      x8
006A8EE7C  mov      x0, x19
006A8EE80  mov      x1, xzr
006A8EE84  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006A8EE88  adrp     x21, #0x959e000
006A8EE8C  ldrb     w8, [x21, #0x59c]
006A8EE90  mov      x20, x0
006A8EE94  cbnz     w8, #0x6a8eeac
006A8EE98  adrp     x0, #0x8f38000
006A8EE9C  ldr      x0, [x0, #0xc90]
006A8EEA0  bl       #0x382bd14 ; 
006A8EEA4  mov      w8, #1
006A8EEA8  strb     w8, [x21, #0x59c]
006A8EEAC  adrp     x8, #0x8f38000
006A8EEB0  ldr      x8, [x8, #0xc90]
006A8EEB4  ldr      x2, [x8]
006A8EEB8  ldrb     w8, [x2, #0x53]
006A8EEBC  tbnz     w8, #5, #0x6a8eed4
006A8EEC0  mov      x0, x19
006A8EEC4  str      x20, [x0, #0x38]!
006A8EEC8  mov      x1, x20
006A8EECC  bl       #0x382bcb8 ; 
006A8EED0  b        #0x6a8eee4 ; 
006A8EED4  ldr      x8, [x2, #0x60]
006A8EED8  mov      x0, x19
006A8EEDC  mov      x1, x20
006A8EEE0  blr      x8
006A8EEE4  mov      x0, x19
006A8EEE8  mov      x1, xzr
006A8EEEC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A8EEF0  adrp     x21, #0x959e000
006A8EEF4  ldrb     w8, [x21, #0x59d]
006A8EEF8  mov      w20, w0
006A8EEFC  cbnz     w8, #0x6a8ef14
006A8EF00  adrp     x0, #0x8f38000
006A8EF04  ldr      x0, [x0, #0xca0]
006A8EF08  bl       #0x382bd14 ; 
006A8EF0C  mov      w8, #1
006A8EF10  strb     w8, [x21, #0x59d]
006A8EF14  adrp     x8, #0x8f38000
006A8EF18  ldr      x8, [x8, #0xca0]
006A8EF1C  ldr      x2, [x8]
006A8EF20  ldrb     w8, [x2, #0x53]
006A8EF24  tbnz     w8, #5, #0x6a8ef30
006A8EF28  str      w20, [x19, #0x40]
006A8EF2C  b        #0x6a8ef40 ; 
006A8EF30  ldr      x8, [x2, #0x60]
006A8EF34  mov      x0, x19
006A8EF38  mov      w1, w20
006A8EF3C  blr      x8
006A8EF40  ldp      x20, x19, [sp, #0x10]
006A8EF44  mov      w0, #1
006A8EF48  ldp      x30, x21, [sp], #0x20
006A8EF4C  ret      

