; LocalModels.Bean.ChapterReward_HardMissionReward$$readImpl
; RVA 0x689BDCC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00689BDCC  stp      x30, x21, [sp, #-0x20]!
00689BDD0  stp      x20, x19, [sp, #0x10]
00689BDD4  adrp     x20, #0x959b000
00689BDD8  adrp     x21, #0x8f26000
00689BDDC  ldrb     w8, [x20, #0xe51]
00689BDE0  ldr      x21, [x21]
00689BDE4  mov      x19, x0
00689BDE8  tbnz     w8, #0, #0x689be00
00689BDEC  adrp     x0, #0x8f26000
00689BDF0  ldr      x0, [x0]
00689BDF4  bl       #0x382bd14 ; 
00689BDF8  mov      w8, #1
00689BDFC  strb     w8, [x20, #0xe51]
00689BE00  ldr      x1, [x21]
00689BE04  ldrb     w8, [x1, #0x53]
00689BE08  tbnz     w8, #5, #0x689be58
00689BE0C  mov      x0, x19
00689BE10  mov      x1, xzr
00689BE14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689BE18  adrp     x21, #0x959c000
00689BE1C  ldrb     w8, [x21, #0x4e2]
00689BE20  mov      w20, w0
00689BE24  cbnz     w8, #0x689be3c
00689BE28  adrp     x0, #0x8f25000
00689BE2C  ldr      x0, [x0, #0xfa8]
00689BE30  bl       #0x382bd14 ; 
00689BE34  mov      w8, #1
00689BE38  strb     w8, [x21, #0x4e2]
00689BE3C  adrp     x8, #0x8f25000
00689BE40  ldr      x8, [x8, #0xfa8]
00689BE44  ldr      x2, [x8]
00689BE48  ldrb     w8, [x2, #0x53]
00689BE4C  tbnz     w8, #5, #0x689be6c
00689BE50  str      w20, [x19, #0x20]
00689BE54  b        #0x689be7c ; 
00689BE58  ldr      x2, [x1, #0x60]
00689BE5C  mov      x0, x19
00689BE60  ldp      x20, x19, [sp, #0x10]
00689BE64  ldp      x30, x21, [sp], #0x20
00689BE68  br       x2
00689BE6C  ldr      x8, [x2, #0x60]
00689BE70  mov      x0, x19
00689BE74  mov      w1, w20
00689BE78  blr      x8
00689BE7C  mov      x0, x19
00689BE80  mov      x1, xzr
00689BE84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689BE88  adrp     x21, #0x959c000
00689BE8C  ldrb     w8, [x21, #0x4e3]
00689BE90  mov      w20, w0
00689BE94  cbnz     w8, #0x689beac
00689BE98  adrp     x0, #0x8f25000
00689BE9C  ldr      x0, [x0, #0xfb8]
00689BEA0  bl       #0x382bd14 ; 
00689BEA4  mov      w8, #1
00689BEA8  strb     w8, [x21, #0x4e3]
00689BEAC  adrp     x8, #0x8f25000
00689BEB0  ldr      x8, [x8, #0xfb8]
00689BEB4  ldr      x2, [x8]
00689BEB8  ldrb     w8, [x2, #0x53]
00689BEBC  tbnz     w8, #5, #0x689bec8
00689BEC0  str      w20, [x19, #0x24]
00689BEC4  b        #0x689bed8 ; 
00689BEC8  ldr      x8, [x2, #0x60]
00689BECC  mov      x0, x19
00689BED0  mov      w1, w20
00689BED4  blr      x8
00689BED8  mov      x0, x19
00689BEDC  mov      x1, xzr
00689BEE0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689BEE4  adrp     x21, #0x959c000
00689BEE8  ldrb     w8, [x21, #0x4e4]
00689BEEC  mov      w20, w0
00689BEF0  cbnz     w8, #0x689bf08
00689BEF4  adrp     x0, #0x8f25000
00689BEF8  ldr      x0, [x0, #0xfc8]
00689BEFC  bl       #0x382bd14 ; 
00689BF00  mov      w8, #1
00689BF04  strb     w8, [x21, #0x4e4]
00689BF08  adrp     x8, #0x8f25000
00689BF0C  ldr      x8, [x8, #0xfc8]
00689BF10  ldr      x2, [x8]
00689BF14  ldrb     w8, [x2, #0x53]
00689BF18  tbnz     w8, #5, #0x689bf24
00689BF1C  str      w20, [x19, #0x28]
00689BF20  b        #0x689bf34 ; 
00689BF24  ldr      x8, [x2, #0x60]
00689BF28  mov      x0, x19
00689BF2C  mov      w1, w20
00689BF30  blr      x8
00689BF34  mov      x0, x19
00689BF38  mov      x1, xzr
00689BF3C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689BF40  adrp     x21, #0x959c000
00689BF44  ldrb     w8, [x21, #0x4e5]
00689BF48  mov      w20, w0
00689BF4C  cbnz     w8, #0x689bf64
00689BF50  adrp     x0, #0x8f25000
00689BF54  ldr      x0, [x0, #0xfd8]
00689BF58  bl       #0x382bd14 ; 
00689BF5C  mov      w8, #1
00689BF60  strb     w8, [x21, #0x4e5]
00689BF64  adrp     x8, #0x8f25000
00689BF68  ldr      x8, [x8, #0xfd8]
00689BF6C  ldr      x2, [x8]
00689BF70  ldrb     w8, [x2, #0x53]
00689BF74  tbnz     w8, #5, #0x689bf80
00689BF78  str      w20, [x19, #0x2c]
00689BF7C  b        #0x689bf90 ; 
00689BF80  ldr      x8, [x2, #0x60]
00689BF84  mov      x0, x19
00689BF88  mov      w1, w20
00689BF8C  blr      x8
00689BF90  mov      x0, x19
00689BF94  mov      x1, xzr
00689BF98  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00689BF9C  adrp     x21, #0x959c000
00689BFA0  ldrb     w8, [x21, #0x4e6]
00689BFA4  mov      w20, w0
00689BFA8  cbnz     w8, #0x689bfc0
00689BFAC  adrp     x0, #0x8f25000
00689BFB0  ldr      x0, [x0, #0xfe8]
00689BFB4  bl       #0x382bd14 ; 
00689BFB8  mov      w8, #1
00689BFBC  strb     w8, [x21, #0x4e6]
00689BFC0  adrp     x8, #0x8f25000
00689BFC4  ldr      x8, [x8, #0xfe8]
00689BFC8  ldr      x2, [x8]
00689BFCC  ldrb     w8, [x2, #0x53]
00689BFD0  tbnz     w8, #5, #0x689bfdc
00689BFD4  str      w20, [x19, #0x30]
00689BFD8  b        #0x689bfec ; 
00689BFDC  ldr      x8, [x2, #0x60]
00689BFE0  mov      x0, x19
00689BFE4  mov      w1, w20
00689BFE8  blr      x8
00689BFEC  mov      x0, x19
00689BFF0  mov      x1, xzr
00689BFF4  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
00689BFF8  adrp     x21, #0x959c000
00689BFFC  ldrb     w8, [x21, #0x4e7]
00689C000  mov      x20, x0
00689C004  cbnz     w8, #0x689c01c
00689C008  adrp     x0, #0x8f25000
00689C00C  ldr      x0, [x0, #0xff8]
00689C010  bl       #0x382bd14 ; 
00689C014  mov      w8, #1
00689C018  strb     w8, [x21, #0x4e7]
00689C01C  adrp     x8, #0x8f25000
00689C020  ldr      x8, [x8, #0xff8]
00689C024  ldr      x2, [x8]
00689C028  ldrb     w8, [x2, #0x53]
00689C02C  tbnz     w8, #5, #0x689c044
00689C030  str      x20, [x19, #0x38]!
00689C034  mov      x0, x19
00689C038  mov      x1, x20
00689C03C  bl       #0x382bcb8 ; 
00689C040  b        #0x689c054 ; 
00689C044  ldr      x8, [x2, #0x60]
00689C048  mov      x0, x19
00689C04C  mov      x1, x20
00689C050  blr      x8
00689C054  ldp      x20, x19, [sp, #0x10]
00689C058  mov      w0, #1
00689C05C  ldp      x30, x21, [sp], #0x20
00689C060  ret      

