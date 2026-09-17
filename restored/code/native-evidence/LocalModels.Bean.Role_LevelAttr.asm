; LocalModels.Bean.Role_LevelAttr$$readImpl
; RVA 0x6ADCECC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ADCECC  stp      x30, x21, [sp, #-0x20]!
006ADCED0  stp      x20, x19, [sp, #0x10]
006ADCED4  adrp     x20, #0x959e000
006ADCED8  adrp     x21, #0x8f3c000
006ADCEDC  ldrb     w8, [x20, #0xc60]
006ADCEE0  ldr      x21, [x21, #0x768]
006ADCEE4  mov      x19, x0
006ADCEE8  tbnz     w8, #0, #0x6adcf00
006ADCEEC  adrp     x0, #0x8f3c000
006ADCEF0  ldr      x0, [x0, #0x768]
006ADCEF4  bl       #0x382bd14 ; 
006ADCEF8  mov      w8, #1
006ADCEFC  strb     w8, [x20, #0xc60]
006ADCF00  ldr      x1, [x21]
006ADCF04  ldrb     w8, [x1, #0x53]
006ADCF08  tbnz     w8, #5, #0x6adcf58
006ADCF0C  mov      x0, x19
006ADCF10  mov      x1, xzr
006ADCF14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADCF18  adrp     x21, #0x959f000
006ADCF1C  ldrb     w8, [x21, #0x167]
006ADCF20  mov      w20, w0
006ADCF24  cbnz     w8, #0x6adcf3c
006ADCF28  adrp     x0, #0x8f3c000
006ADCF2C  ldr      x0, [x0, #0x740]
006ADCF30  bl       #0x382bd14 ; 
006ADCF34  mov      w8, #1
006ADCF38  strb     w8, [x21, #0x167]
006ADCF3C  adrp     x8, #0x8f3c000
006ADCF40  ldr      x8, [x8, #0x740]
006ADCF44  ldr      x2, [x8]
006ADCF48  ldrb     w8, [x2, #0x53]
006ADCF4C  tbnz     w8, #5, #0x6adcf6c
006ADCF50  str      w20, [x19, #0x20]
006ADCF54  b        #0x6adcf7c ; 
006ADCF58  ldr      x2, [x1, #0x60]
006ADCF5C  mov      x0, x19
006ADCF60  ldp      x20, x19, [sp, #0x10]
006ADCF64  ldp      x30, x21, [sp], #0x20
006ADCF68  br       x2
006ADCF6C  ldr      x8, [x2, #0x60]
006ADCF70  mov      x0, x19
006ADCF74  mov      w1, w20
006ADCF78  blr      x8
006ADCF7C  mov      x0, x19
006ADCF80  mov      x1, xzr
006ADCF84  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADCF88  adrp     x21, #0x959f000
006ADCF8C  ldrb     w8, [x21, #0x168]
006ADCF90  mov      x20, x0
006ADCF94  cbnz     w8, #0x6adcfac
006ADCF98  adrp     x0, #0x8f3c000
006ADCF9C  ldr      x0, [x0, #0x748]
006ADCFA0  bl       #0x382bd14 ; 
006ADCFA4  mov      w8, #1
006ADCFA8  strb     w8, [x21, #0x168]
006ADCFAC  adrp     x8, #0x8f3c000
006ADCFB0  ldr      x8, [x8, #0x748]
006ADCFB4  ldr      x2, [x8]
006ADCFB8  ldrb     w8, [x2, #0x53]
006ADCFBC  tbnz     w8, #5, #0x6adcfd4
006ADCFC0  mov      x0, x19
006ADCFC4  str      x20, [x0, #0x28]!
006ADCFC8  mov      x1, x20
006ADCFCC  bl       #0x382bcb8 ; 
006ADCFD0  b        #0x6adcfe4 ; 
006ADCFD4  ldr      x8, [x2, #0x60]
006ADCFD8  mov      x0, x19
006ADCFDC  mov      x1, x20
006ADCFE0  blr      x8
006ADCFE4  mov      x0, x19
006ADCFE8  mov      x1, xzr
006ADCFEC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADCFF0  adrp     x21, #0x959f000
006ADCFF4  ldrb     w8, [x21, #0x169]
006ADCFF8  mov      x20, x0
006ADCFFC  cbnz     w8, #0x6add014
006ADD000  adrp     x0, #0x8f3c000
006ADD004  ldr      x0, [x0, #0x750]
006ADD008  bl       #0x382bd14 ; 
006ADD00C  mov      w8, #1
006ADD010  strb     w8, [x21, #0x169]
006ADD014  adrp     x8, #0x8f3c000
006ADD018  ldr      x8, [x8, #0x750]
006ADD01C  ldr      x2, [x8]
006ADD020  ldrb     w8, [x2, #0x53]
006ADD024  tbnz     w8, #5, #0x6add03c
006ADD028  mov      x0, x19
006ADD02C  str      x20, [x0, #0x30]!
006ADD030  mov      x1, x20
006ADD034  bl       #0x382bcb8 ; 
006ADD038  b        #0x6add04c ; 
006ADD03C  ldr      x8, [x2, #0x60]
006ADD040  mov      x0, x19
006ADD044  mov      x1, x20
006ADD048  blr      x8
006ADD04C  mov      x0, x19
006ADD050  mov      x1, xzr
006ADD054  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADD058  adrp     x21, #0x959f000
006ADD05C  ldrb     w8, [x21, #0x16a]
006ADD060  mov      x20, x0
006ADD064  cbnz     w8, #0x6add07c
006ADD068  adrp     x0, #0x8f3c000
006ADD06C  ldr      x0, [x0, #0x758]
006ADD070  bl       #0x382bd14 ; 
006ADD074  mov      w8, #1
006ADD078  strb     w8, [x21, #0x16a]
006ADD07C  adrp     x8, #0x8f3c000
006ADD080  ldr      x8, [x8, #0x758]
006ADD084  ldr      x2, [x8]
006ADD088  ldrb     w8, [x2, #0x53]
006ADD08C  tbnz     w8, #5, #0x6add0a4
006ADD090  mov      x0, x19
006ADD094  str      x20, [x0, #0x38]!
006ADD098  mov      x1, x20
006ADD09C  bl       #0x382bcb8 ; 
006ADD0A0  b        #0x6add0b4 ; 
006ADD0A4  ldr      x8, [x2, #0x60]
006ADD0A8  mov      x0, x19
006ADD0AC  mov      x1, x20
006ADD0B0  blr      x8
006ADD0B4  mov      x0, x19
006ADD0B8  mov      x1, xzr
006ADD0BC  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADD0C0  adrp     x21, #0x959f000
006ADD0C4  ldrb     w8, [x21, #0x16b]
006ADD0C8  mov      x20, x0
006ADD0CC  cbnz     w8, #0x6add0e4
006ADD0D0  adrp     x0, #0x8f3c000
006ADD0D4  ldr      x0, [x0, #0x760]
006ADD0D8  bl       #0x382bd14 ; 
006ADD0DC  mov      w8, #1
006ADD0E0  strb     w8, [x21, #0x16b]
006ADD0E4  adrp     x8, #0x8f3c000
006ADD0E8  ldr      x8, [x8, #0x760]
006ADD0EC  ldr      x2, [x8]
006ADD0F0  ldrb     w8, [x2, #0x53]
006ADD0F4  tbnz     w8, #5, #0x6add10c
006ADD0F8  str      x20, [x19, #0x40]!
006ADD0FC  mov      x0, x19
006ADD100  mov      x1, x20
006ADD104  bl       #0x382bcb8 ; 
006ADD108  b        #0x6add11c ; 
006ADD10C  ldr      x8, [x2, #0x60]
006ADD110  mov      x0, x19
006ADD114  mov      x1, x20
006ADD118  blr      x8
006ADD11C  ldp      x20, x19, [sp, #0x10]
006ADD120  mov      w0, #1
006ADD124  ldp      x30, x21, [sp], #0x20
006ADD128  ret      

