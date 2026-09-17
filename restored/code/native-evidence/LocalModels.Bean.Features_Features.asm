; LocalModels.Bean.Features_Features$$readImpl
; RVA 0x6A7C9F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A7C9F4  stp      x30, x21, [sp, #-0x20]!
006A7C9F8  stp      x20, x19, [sp, #0x10]
006A7C9FC  adrp     x20, #0x959d000
006A7CA00  adrp     x21, #0x8f37000
006A7CA04  ldrb     w8, [x20, #0xedf]
006A7CA08  ldr      x21, [x21, #0xf10]
006A7CA0C  mov      x19, x0
006A7CA10  tbnz     w8, #0, #0x6a7ca28
006A7CA14  adrp     x0, #0x8f37000
006A7CA18  ldr      x0, [x0, #0xf10]
006A7CA1C  bl       #0x382bd14 ; 
006A7CA20  mov      w8, #1
006A7CA24  strb     w8, [x20, #0xedf]
006A7CA28  ldr      x1, [x21]
006A7CA2C  ldrb     w8, [x1, #0x53]
006A7CA30  tbnz     w8, #5, #0x6a7ca80
006A7CA34  mov      x0, x19
006A7CA38  mov      x1, xzr
006A7CA3C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7CA40  adrp     x21, #0x959e000
006A7CA44  ldrb     w8, [x21, #0x4d6]
006A7CA48  mov      w20, w0
006A7CA4C  cbnz     w8, #0x6a7ca64
006A7CA50  adrp     x0, #0x8f37000
006A7CA54  ldr      x0, [x0, #0xed8]
006A7CA58  bl       #0x382bd14 ; 
006A7CA5C  mov      w8, #1
006A7CA60  strb     w8, [x21, #0x4d6]
006A7CA64  adrp     x8, #0x8f37000
006A7CA68  ldr      x8, [x8, #0xed8]
006A7CA6C  ldr      x2, [x8]
006A7CA70  ldrb     w8, [x2, #0x53]
006A7CA74  tbnz     w8, #5, #0x6a7ca94
006A7CA78  str      w20, [x19, #0x20]
006A7CA7C  b        #0x6a7caa4 ; 
006A7CA80  ldr      x2, [x1, #0x60]
006A7CA84  mov      x0, x19
006A7CA88  ldp      x20, x19, [sp, #0x10]
006A7CA8C  ldp      x30, x21, [sp], #0x20
006A7CA90  br       x2
006A7CA94  ldr      x8, [x2, #0x60]
006A7CA98  mov      x0, x19
006A7CA9C  mov      w1, w20
006A7CAA0  blr      x8
006A7CAA4  mov      x0, x19
006A7CAA8  mov      x1, xzr
006A7CAAC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7CAB0  adrp     x21, #0x959e000
006A7CAB4  ldrb     w8, [x21, #0x4d7]
006A7CAB8  mov      x20, x0
006A7CABC  cbnz     w8, #0x6a7cad4
006A7CAC0  adrp     x0, #0x8f37000
006A7CAC4  ldr      x0, [x0, #0xee8]
006A7CAC8  bl       #0x382bd14 ; 
006A7CACC  mov      w8, #1
006A7CAD0  strb     w8, [x21, #0x4d7]
006A7CAD4  adrp     x8, #0x8f37000
006A7CAD8  ldr      x8, [x8, #0xee8]
006A7CADC  ldr      x2, [x8]
006A7CAE0  ldrb     w8, [x2, #0x53]
006A7CAE4  tbnz     w8, #5, #0x6a7cafc
006A7CAE8  mov      x0, x19
006A7CAEC  str      x20, [x0, #0x28]!
006A7CAF0  mov      x1, x20
006A7CAF4  bl       #0x382bcb8 ; 
006A7CAF8  b        #0x6a7cb0c ; 
006A7CAFC  ldr      x8, [x2, #0x60]
006A7CB00  mov      x0, x19
006A7CB04  mov      x1, x20
006A7CB08  blr      x8
006A7CB0C  mov      x0, x19
006A7CB10  mov      x1, xzr
006A7CB14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A7CB18  adrp     x21, #0x959e000
006A7CB1C  ldrb     w8, [x21, #0x4d8]
006A7CB20  mov      w20, w0
006A7CB24  cbnz     w8, #0x6a7cb3c
006A7CB28  adrp     x0, #0x8f37000
006A7CB2C  ldr      x0, [x0, #0xef8]
006A7CB30  bl       #0x382bd14 ; 
006A7CB34  mov      w8, #1
006A7CB38  strb     w8, [x21, #0x4d8]
006A7CB3C  adrp     x8, #0x8f37000
006A7CB40  ldr      x8, [x8, #0xef8]
006A7CB44  ldr      x2, [x8]
006A7CB48  ldrb     w8, [x2, #0x53]
006A7CB4C  tbnz     w8, #5, #0x6a7cb58
006A7CB50  str      w20, [x19, #0x30]
006A7CB54  b        #0x6a7cb68 ; 
006A7CB58  ldr      x8, [x2, #0x60]
006A7CB5C  mov      x0, x19
006A7CB60  mov      w1, w20
006A7CB64  blr      x8
006A7CB68  mov      x0, x19
006A7CB6C  mov      x1, xzr
006A7CB70  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A7CB74  adrp     x21, #0x959e000
006A7CB78  ldrb     w8, [x21, #0x4d9]
006A7CB7C  mov      x20, x0
006A7CB80  cbnz     w8, #0x6a7cb98
006A7CB84  adrp     x0, #0x8f37000
006A7CB88  ldr      x0, [x0, #0xf08]
006A7CB8C  bl       #0x382bd14 ; 
006A7CB90  mov      w8, #1
006A7CB94  strb     w8, [x21, #0x4d9]
006A7CB98  adrp     x8, #0x8f37000
006A7CB9C  ldr      x8, [x8, #0xf08]
006A7CBA0  ldr      x2, [x8]
006A7CBA4  ldrb     w8, [x2, #0x53]
006A7CBA8  tbnz     w8, #5, #0x6a7cbc0
006A7CBAC  str      x20, [x19, #0x38]!
006A7CBB0  mov      x0, x19
006A7CBB4  mov      x1, x20
006A7CBB8  bl       #0x382bcb8 ; 
006A7CBBC  b        #0x6a7cbd0 ; 
006A7CBC0  ldr      x8, [x2, #0x60]
006A7CBC4  mov      x0, x19
006A7CBC8  mov      x1, x20
006A7CBCC  blr      x8
006A7CBD0  ldp      x20, x19, [sp, #0x10]
006A7CBD4  mov      w0, #1
006A7CBD8  ldp      x30, x21, [sp], #0x20
006A7CBDC  ret      

