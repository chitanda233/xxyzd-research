; LocalModels.Bean.Exp_exp$$readImpl
; RVA 0x6A7BD94; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A7BD94  stp      x30, x21, [sp, #-0x20]!
006A7BD98  stp      x20, x19, [sp, #0x10]
006A7BD9C  adrp     x20, #0x959d000
006A7BDA0  adrp     x21, #0x8f37000
006A7BDA4  ldrb     w8, [x20, #0xecb]
006A7BDA8  ldr      x21, [x21, #0xe80]
006A7BDAC  mov      x19, x0
006A7BDB0  tbnz     w8, #0, #0x6a7bdc8
006A7BDB4  adrp     x0, #0x8f37000
006A7BDB8  ldr      x0, [x0, #0xe80]
006A7BDBC  bl       #0x382bd14 ; 
006A7BDC0  mov      w8, #1
006A7BDC4  strb     w8, [x20, #0xecb]
006A7BDC8  ldr      x1, [x21]
006A7BDCC  ldrb     w8, [x1, #0x53]
006A7BDD0  tbnz     w8, #5, #0x6a7be20
006A7BDD4  mov      x0, x19
006A7BDD8  mov      x1, xzr
006A7BDDC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7BDE0  adrp     x21, #0x959e000
006A7BDE4  ldrb     w8, [x21, #0x4cd]
006A7BDE8  mov      w20, w0
006A7BDEC  cbnz     w8, #0x6a7be04
006A7BDF0  adrp     x0, #0x8f37000
006A7BDF4  ldr      x0, [x0, #0xe40]
006A7BDF8  bl       #0x382bd14 ; 
006A7BDFC  mov      w8, #1
006A7BE00  strb     w8, [x21, #0x4cd]
006A7BE04  adrp     x8, #0x8f37000
006A7BE08  ldr      x8, [x8, #0xe40]
006A7BE0C  ldr      x2, [x8]
006A7BE10  ldrb     w8, [x2, #0x53]
006A7BE14  tbnz     w8, #5, #0x6a7be34
006A7BE18  str      w20, [x19, #0x20]
006A7BE1C  b        #0x6a7be44 ; 
006A7BE20  ldr      x2, [x1, #0x60]
006A7BE24  mov      x0, x19
006A7BE28  ldp      x20, x19, [sp, #0x10]
006A7BE2C  ldp      x30, x21, [sp], #0x20
006A7BE30  br       x2
006A7BE34  ldr      x8, [x2, #0x60]
006A7BE38  mov      x0, x19
006A7BE3C  mov      w1, w20
006A7BE40  blr      x8
006A7BE44  mov      x0, x19
006A7BE48  mov      x1, xzr
006A7BE4C  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A7BE50  adrp     x21, #0x959e000
006A7BE54  ldrb     w8, [x21, #0x4ce]
006A7BE58  mov      x20, x0
006A7BE5C  cbnz     w8, #0x6a7be74
006A7BE60  adrp     x0, #0x8f37000
006A7BE64  ldr      x0, [x0, #0xe48]
006A7BE68  bl       #0x382bd14 ; 
006A7BE6C  mov      w8, #1
006A7BE70  strb     w8, [x21, #0x4ce]
006A7BE74  adrp     x8, #0x8f37000
006A7BE78  ldr      x8, [x8, #0xe48]
006A7BE7C  ldr      x2, [x8]
006A7BE80  ldrb     w8, [x2, #0x53]
006A7BE84  tbnz     w8, #5, #0x6a7be9c
006A7BE88  mov      x0, x19
006A7BE8C  str      x20, [x0, #0x28]!
006A7BE90  mov      x1, x20
006A7BE94  bl       #0x382bcb8 ; 
006A7BE98  b        #0x6a7beac ; 
006A7BE9C  ldr      x8, [x2, #0x60]
006A7BEA0  mov      x0, x19
006A7BEA4  mov      x1, x20
006A7BEA8  blr      x8
006A7BEAC  mov      x0, x19
006A7BEB0  mov      x1, xzr
006A7BEB4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7BEB8  adrp     x21, #0x959e000
006A7BEBC  ldrb     w8, [x21, #0x4cf]
006A7BEC0  mov      w20, w0
006A7BEC4  cbnz     w8, #0x6a7bedc
006A7BEC8  adrp     x0, #0x8f37000
006A7BECC  ldr      x0, [x0, #0xe50]
006A7BED0  bl       #0x382bd14 ; 
006A7BED4  mov      w8, #1
006A7BED8  strb     w8, [x21, #0x4cf]
006A7BEDC  adrp     x8, #0x8f37000
006A7BEE0  ldr      x8, [x8, #0xe50]
006A7BEE4  ldr      x2, [x8]
006A7BEE8  ldrb     w8, [x2, #0x53]
006A7BEEC  tbnz     w8, #5, #0x6a7bef8
006A7BEF0  str      w20, [x19, #0x30]
006A7BEF4  b        #0x6a7bf08 ; 
006A7BEF8  ldr      x8, [x2, #0x60]
006A7BEFC  mov      x0, x19
006A7BF00  mov      w1, w20
006A7BF04  blr      x8
006A7BF08  mov      x0, x19
006A7BF0C  mov      x1, xzr
006A7BF10  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7BF14  adrp     x21, #0x959e000
006A7BF18  ldrb     w8, [x21, #0x4d0]
006A7BF1C  mov      w20, w0
006A7BF20  cbnz     w8, #0x6a7bf38
006A7BF24  adrp     x0, #0x8f37000
006A7BF28  ldr      x0, [x0, #0xe60]
006A7BF2C  bl       #0x382bd14 ; 
006A7BF30  mov      w8, #1
006A7BF34  strb     w8, [x21, #0x4d0]
006A7BF38  adrp     x8, #0x8f37000
006A7BF3C  ldr      x8, [x8, #0xe60]
006A7BF40  ldr      x2, [x8]
006A7BF44  ldrb     w8, [x2, #0x53]
006A7BF48  tbnz     w8, #5, #0x6a7bf54
006A7BF4C  str      w20, [x19, #0x34]
006A7BF50  b        #0x6a7bf64 ; 
006A7BF54  ldr      x8, [x2, #0x60]
006A7BF58  mov      x0, x19
006A7BF5C  mov      w1, w20
006A7BF60  blr      x8
006A7BF64  mov      x0, x19
006A7BF68  mov      x1, xzr
006A7BF6C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7BF70  adrp     x21, #0x959e000
006A7BF74  ldrb     w8, [x21, #0x4d1]
006A7BF78  mov      w20, w0
006A7BF7C  cbnz     w8, #0x6a7bf94
006A7BF80  adrp     x0, #0x8f37000
006A7BF84  ldr      x0, [x0, #0xe68]
006A7BF88  bl       #0x382bd14 ; 
006A7BF8C  mov      w8, #1
006A7BF90  strb     w8, [x21, #0x4d1]
006A7BF94  adrp     x8, #0x8f37000
006A7BF98  ldr      x8, [x8, #0xe68]
006A7BF9C  ldr      x2, [x8]
006A7BFA0  ldrb     w8, [x2, #0x53]
006A7BFA4  tbnz     w8, #5, #0x6a7bfb0
006A7BFA8  str      w20, [x19, #0x38]
006A7BFAC  b        #0x6a7bfc0 ; 
006A7BFB0  ldr      x8, [x2, #0x60]
006A7BFB4  mov      x0, x19
006A7BFB8  mov      w1, w20
006A7BFBC  blr      x8
006A7BFC0  mov      x0, x19
006A7BFC4  mov      x1, xzr
006A7BFC8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7BFCC  adrp     x21, #0x959e000
006A7BFD0  ldrb     w8, [x21, #0x4d2]
006A7BFD4  mov      w20, w0
006A7BFD8  cbnz     w8, #0x6a7bff0
006A7BFDC  adrp     x0, #0x8f37000
006A7BFE0  ldr      x0, [x0, #0xe78]
006A7BFE4  bl       #0x382bd14 ; 
006A7BFE8  mov      w8, #1
006A7BFEC  strb     w8, [x21, #0x4d2]
006A7BFF0  adrp     x8, #0x8f37000
006A7BFF4  ldr      x8, [x8, #0xe78]
006A7BFF8  ldr      x2, [x8]
006A7BFFC  ldrb     w8, [x2, #0x53]
006A7C000  tbnz     w8, #5, #0x6a7c00c
006A7C004  str      w20, [x19, #0x3c]
006A7C008  b        #0x6a7c01c ; 
006A7C00C  ldr      x8, [x2, #0x60]
006A7C010  mov      x0, x19
006A7C014  mov      w1, w20
006A7C018  blr      x8
006A7C01C  ldp      x20, x19, [sp, #0x10]
006A7C020  mov      w0, #1
006A7C024  ldp      x30, x21, [sp], #0x20
006A7C028  ret      

