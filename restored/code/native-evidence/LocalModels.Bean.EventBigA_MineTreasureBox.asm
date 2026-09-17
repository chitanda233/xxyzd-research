; LocalModels.Bean.EventBigA_MineTreasureBox$$readImpl
; RVA 0x6A6BCA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A6BCA0  stp      x30, x21, [sp, #-0x20]!
006A6BCA4  stp      x20, x19, [sp, #0x10]
006A6BCA8  adrp     x20, #0x959d000
006A6BCAC  adrp     x21, #0x8f37000
006A6BCB0  ldrb     w8, [x20, #0xd21]
006A6BCB4  ldr      x21, [x21, #0x218]
006A6BCB8  mov      x19, x0
006A6BCBC  tbnz     w8, #0, #0x6a6bcd4
006A6BCC0  adrp     x0, #0x8f37000
006A6BCC4  ldr      x0, [x0, #0x218]
006A6BCC8  bl       #0x382bd14 ; 
006A6BCCC  mov      w8, #1
006A6BCD0  strb     w8, [x20, #0xd21]
006A6BCD4  ldr      x1, [x21]
006A6BCD8  ldrb     w8, [x1, #0x53]
006A6BCDC  tbnz     w8, #5, #0x6a6bd2c
006A6BCE0  mov      x0, x19
006A6BCE4  mov      x1, xzr
006A6BCE8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6BCEC  adrp     x21, #0x959e000
006A6BCF0  ldrb     w8, [x21, #0x41c]
006A6BCF4  mov      w20, w0
006A6BCF8  cbnz     w8, #0x6a6bd10
006A6BCFC  adrp     x0, #0x8f37000
006A6BD00  ldr      x0, [x0, #0x190]
006A6BD04  bl       #0x382bd14 ; 
006A6BD08  mov      w8, #1
006A6BD0C  strb     w8, [x21, #0x41c]
006A6BD10  adrp     x8, #0x8f37000
006A6BD14  ldr      x8, [x8, #0x190]
006A6BD18  ldr      x2, [x8]
006A6BD1C  ldrb     w8, [x2, #0x53]
006A6BD20  tbnz     w8, #5, #0x6a6bd40
006A6BD24  str      w20, [x19, #0x20]
006A6BD28  b        #0x6a6bd50 ; 
006A6BD2C  ldr      x2, [x1, #0x60]
006A6BD30  mov      x0, x19
006A6BD34  ldp      x20, x19, [sp, #0x10]
006A6BD38  ldp      x30, x21, [sp], #0x20
006A6BD3C  br       x2
006A6BD40  ldr      x8, [x2, #0x60]
006A6BD44  mov      x0, x19
006A6BD48  mov      w1, w20
006A6BD4C  blr      x8
006A6BD50  mov      x0, x19
006A6BD54  mov      x1, xzr
006A6BD58  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6BD5C  adrp     x21, #0x959e000
006A6BD60  ldrb     w8, [x21, #0x41d]
006A6BD64  mov      w20, w0
006A6BD68  cbnz     w8, #0x6a6bd80
006A6BD6C  adrp     x0, #0x8f37000
006A6BD70  ldr      x0, [x0, #0x1a0]
006A6BD74  bl       #0x382bd14 ; 
006A6BD78  mov      w8, #1
006A6BD7C  strb     w8, [x21, #0x41d]
006A6BD80  adrp     x8, #0x8f37000
006A6BD84  ldr      x8, [x8, #0x1a0]
006A6BD88  ldr      x2, [x8]
006A6BD8C  ldrb     w8, [x2, #0x53]
006A6BD90  tbnz     w8, #5, #0x6a6bd9c
006A6BD94  str      w20, [x19, #0x24]
006A6BD98  b        #0x6a6bdac ; 
006A6BD9C  ldr      x8, [x2, #0x60]
006A6BDA0  mov      x0, x19
006A6BDA4  mov      w1, w20
006A6BDA8  blr      x8
006A6BDAC  mov      x0, x19
006A6BDB0  mov      x1, xzr
006A6BDB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6BDB8  adrp     x21, #0x959e000
006A6BDBC  ldrb     w8, [x21, #0x41e]
006A6BDC0  mov      w20, w0
006A6BDC4  cbnz     w8, #0x6a6bddc
006A6BDC8  adrp     x0, #0x8f37000
006A6BDCC  ldr      x0, [x0, #0x1b0]
006A6BDD0  bl       #0x382bd14 ; 
006A6BDD4  mov      w8, #1
006A6BDD8  strb     w8, [x21, #0x41e]
006A6BDDC  adrp     x8, #0x8f37000
006A6BDE0  ldr      x8, [x8, #0x1b0]
006A6BDE4  ldr      x2, [x8]
006A6BDE8  ldrb     w8, [x2, #0x53]
006A6BDEC  tbnz     w8, #5, #0x6a6bdf8
006A6BDF0  str      w20, [x19, #0x28]
006A6BDF4  b        #0x6a6be08 ; 
006A6BDF8  ldr      x8, [x2, #0x60]
006A6BDFC  mov      x0, x19
006A6BE00  mov      w1, w20
006A6BE04  blr      x8
006A6BE08  mov      x0, x19
006A6BE0C  mov      x1, xzr
006A6BE10  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A6BE14  adrp     x21, #0x959e000
006A6BE18  ldrb     w8, [x21, #0x41f]
006A6BE1C  mov      x20, x0
006A6BE20  cbnz     w8, #0x6a6be38
006A6BE24  adrp     x0, #0x8f37000
006A6BE28  ldr      x0, [x0, #0x1c0]
006A6BE2C  bl       #0x382bd14 ; 
006A6BE30  mov      w8, #1
006A6BE34  strb     w8, [x21, #0x41f]
006A6BE38  adrp     x8, #0x8f37000
006A6BE3C  ldr      x8, [x8, #0x1c0]
006A6BE40  ldr      x2, [x8]
006A6BE44  ldrb     w8, [x2, #0x53]
006A6BE48  tbnz     w8, #5, #0x6a6be60
006A6BE4C  mov      x0, x19
006A6BE50  str      x20, [x0, #0x30]!
006A6BE54  mov      x1, x20
006A6BE58  bl       #0x382bcb8 ; 
006A6BE5C  b        #0x6a6be70 ; 
006A6BE60  ldr      x8, [x2, #0x60]
006A6BE64  mov      x0, x19
006A6BE68  mov      x1, x20
006A6BE6C  blr      x8
006A6BE70  mov      x0, x19
006A6BE74  mov      x1, xzr
006A6BE78  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A6BE7C  adrp     x21, #0x959e000
006A6BE80  ldrb     w8, [x21, #0x420]
006A6BE84  mov      x20, x0
006A6BE88  cbnz     w8, #0x6a6bea0
006A6BE8C  adrp     x0, #0x8f37000
006A6BE90  ldr      x0, [x0, #0x1d0]
006A6BE94  bl       #0x382bd14 ; 
006A6BE98  mov      w8, #1
006A6BE9C  strb     w8, [x21, #0x420]
006A6BEA0  adrp     x8, #0x8f37000
006A6BEA4  ldr      x8, [x8, #0x1d0]
006A6BEA8  ldr      x2, [x8]
006A6BEAC  ldrb     w8, [x2, #0x53]
006A6BEB0  tbnz     w8, #5, #0x6a6bec8
006A6BEB4  mov      x0, x19
006A6BEB8  str      x20, [x0, #0x38]!
006A6BEBC  mov      x1, x20
006A6BEC0  bl       #0x382bcb8 ; 
006A6BEC4  b        #0x6a6bed8 ; 
006A6BEC8  ldr      x8, [x2, #0x60]
006A6BECC  mov      x0, x19
006A6BED0  mov      x1, x20
006A6BED4  blr      x8
006A6BED8  mov      x0, x19
006A6BEDC  mov      x1, xzr
006A6BEE0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A6BEE4  adrp     x21, #0x959e000
006A6BEE8  ldrb     w8, [x21, #0x421]
006A6BEEC  mov      w20, w0
006A6BEF0  cbnz     w8, #0x6a6bf08
006A6BEF4  adrp     x0, #0x8f37000
006A6BEF8  ldr      x0, [x0, #0x1e0]
006A6BEFC  bl       #0x382bd14 ; 
006A6BF00  mov      w8, #1
006A6BF04  strb     w8, [x21, #0x421]
006A6BF08  adrp     x8, #0x8f37000
006A6BF0C  ldr      x8, [x8, #0x1e0]
006A6BF10  ldr      x2, [x8]
006A6BF14  ldrb     w8, [x2, #0x53]
006A6BF18  tbnz     w8, #5, #0x6a6bf24
006A6BF1C  str      w20, [x19, #0x40]
006A6BF20  b        #0x6a6bf34 ; 
006A6BF24  ldr      x8, [x2, #0x60]
006A6BF28  mov      x0, x19
006A6BF2C  mov      w1, w20
006A6BF30  blr      x8
006A6BF34  mov      x0, x19
006A6BF38  mov      x1, xzr
006A6BF3C  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A6BF40  adrp     x21, #0x959e000
006A6BF44  ldrb     w8, [x21, #0x422]
006A6BF48  mov      x20, x0
006A6BF4C  cbnz     w8, #0x6a6bf64
006A6BF50  adrp     x0, #0x8f37000
006A6BF54  ldr      x0, [x0, #0x1f0]
006A6BF58  bl       #0x382bd14 ; 
006A6BF5C  mov      w8, #1
006A6BF60  strb     w8, [x21, #0x422]
006A6BF64  adrp     x8, #0x8f37000
006A6BF68  ldr      x8, [x8, #0x1f0]
006A6BF6C  ldr      x2, [x8]
006A6BF70  ldrb     w8, [x2, #0x53]
006A6BF74  tbnz     w8, #5, #0x6a6bf8c
006A6BF78  mov      x0, x19
006A6BF7C  str      x20, [x0, #0x48]!
006A6BF80  mov      x1, x20
006A6BF84  bl       #0x382bcb8 ; 
006A6BF88  b        #0x6a6bf9c ; 
006A6BF8C  ldr      x8, [x2, #0x60]
006A6BF90  mov      x0, x19
006A6BF94  mov      x1, x20
006A6BF98  blr      x8
006A6BF9C  mov      x0, x19
006A6BFA0  mov      x1, xzr
006A6BFA4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A6BFA8  adrp     x21, #0x959e000
006A6BFAC  ldrb     w8, [x21, #0x423]
006A6BFB0  mov      x20, x0
006A6BFB4  cbnz     w8, #0x6a6bfcc
006A6BFB8  adrp     x0, #0x8f37000
006A6BFBC  ldr      x0, [x0, #0x200]
006A6BFC0  bl       #0x382bd14 ; 
006A6BFC4  mov      w8, #1
006A6BFC8  strb     w8, [x21, #0x423]
006A6BFCC  adrp     x8, #0x8f37000
006A6BFD0  ldr      x8, [x8, #0x200]
006A6BFD4  ldr      x2, [x8]
006A6BFD8  ldrb     w8, [x2, #0x53]
006A6BFDC  tbnz     w8, #5, #0x6a6bff4
006A6BFE0  mov      x0, x19
006A6BFE4  str      x20, [x0, #0x50]!
006A6BFE8  mov      x1, x20
006A6BFEC  bl       #0x382bcb8 ; 
006A6BFF0  b        #0x6a6c004 ; 
006A6BFF4  ldr      x8, [x2, #0x60]
006A6BFF8  mov      x0, x19
006A6BFFC  mov      x1, x20
006A6C000  blr      x8
006A6C004  mov      x0, x19
006A6C008  mov      x1, xzr
006A6C00C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A6C010  adrp     x21, #0x959e000
006A6C014  ldrb     w8, [x21, #0x424]
006A6C018  mov      x20, x0
006A6C01C  cbnz     w8, #0x6a6c034
006A6C020  adrp     x0, #0x8f37000
006A6C024  ldr      x0, [x0, #0x210]
006A6C028  bl       #0x382bd14 ; 
006A6C02C  mov      w8, #1
006A6C030  strb     w8, [x21, #0x424]
006A6C034  adrp     x8, #0x8f37000
006A6C038  ldr      x8, [x8, #0x210]
006A6C03C  ldr      x2, [x8]
006A6C040  ldrb     w8, [x2, #0x53]
006A6C044  tbnz     w8, #5, #0x6a6c05c
006A6C048  str      x20, [x19, #0x58]!
006A6C04C  mov      x0, x19
006A6C050  mov      x1, x20
006A6C054  bl       #0x382bcb8 ; 
006A6C058  b        #0x6a6c06c ; 
006A6C05C  ldr      x8, [x2, #0x60]
006A6C060  mov      x0, x19
006A6C064  mov      x1, x20
006A6C068  blr      x8
006A6C06C  ldp      x20, x19, [sp, #0x10]
006A6C070  mov      w0, #1
006A6C074  ldp      x30, x21, [sp], #0x20
006A6C078  ret      

