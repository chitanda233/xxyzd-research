; System.Func<WeightRandomData, CalCollectionTreasureData>$$.ctor
; RVA 0x48DABC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DABC8  str      x30, [sp, #-0x30]!
0048DABCC  stp      x22, x21, [sp, #0x10]
0048DABD0  stp      x20, x19, [sp, #0x20]
0048DABD4  ldr      x8, [x2, #8]
0048DABD8  mov      x19, x0
0048DABDC  str      x2, [x0, #0x28]
0048DABE0  mov      x21, x2
0048DABE4  str      x8, [x0, #0x10]
0048DABE8  str      x1, [x0, #0x20]!
0048DABEC  mov      x20, x1
0048DABF0  bl       #0x382bcb8 ; 
0048DABF4  ldrb     w22, [x21, #0x52]
0048DABF8  mov      x0, x21
0048DABFC  str      x19, [x19, #0x40]
0048DAC00  bl       #0x382be14 ; 
0048DAC04  tbz      w0, #0, #0x48dac20
0048DAC08  cmp      w22, #1
0048DAC0C  b.ne     #0x48dac24
0048DAC10  adrp     x8, #0x3474000
0048DAC14  add      x8, x8, #0xd44
0048DAC18  str      x8, [x19, #0x18]
0048DAC1C  b        #0x48dac34 ; 
0048DAC20  cbz      x20, #0x48dac50
0048DAC24  ldr      x8, [x19, #0x10]
0048DAC28  ldr      x9, [x19, #0x20]
0048DAC2C  str      x8, [x19, #0x18]
0048DAC30  str      x9, [x19, #0x40]
0048DAC34  adrp     x8, #0x3474000
0048DAC38  add      x8, x8, #0xcd4
0048DAC3C  str      x8, [x19, #0x38]
0048DAC40  ldp      x20, x19, [sp, #0x20]
0048DAC44  ldp      x22, x21, [sp, #0x10]
0048DAC48  ldr      x30, [sp], #0x30
0048DAC4C  ret      
0048DAC50  adrp     x1, #0x1a2d000
0048DAC54  add      x1, x1, #0x4e9
0048DAC58  mov      x0, xzr
0048DAC5C  bl       #0x382bfd4 ; 
0048DAC60  mov      x1, xzr
0048DAC64  bl       #0x382be7c ; 

; System.Func<WeightRandomData, CalCollectionTreasureData>$$Invoke
; RVA 0x48DAC68; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAC68  sub      sp, sp, #0x50
0048DAC6C  str      x30, [sp, #0x40]
0048DAC70  ldp      q2, q0, [x1, #0x10]
0048DAC74  ldr      x10, [x1, #0x30]
0048DAC78  ldr      q1, [x1]
0048DAC7C  ldr      x9, [x0, #0x18]
0048DAC80  ldr      x8, [x0, #0x40]
0048DAC84  str      x10, [sp, #0x30]
0048DAC88  stp      q2, q0, [sp, #0x10]
0048DAC8C  str      q1, [sp]
0048DAC90  ldr      x2, [x0, #0x28]
0048DAC94  mov      x1, sp
0048DAC98  mov      x0, x8
0048DAC9C  blr      x9
0048DACA0  ldr      x30, [sp, #0x40]
0048DACA4  add      sp, sp, #0x50
0048DACA8  ret      

; System.Func<WeightRandomData, CalCollectionTreasureData>$$BeginInvoke
; RVA 0x48DACAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DACAC  sub      sp, sp, #0x50
0048DACB0  str      x30, [sp, #0x10]
0048DACB4  stp      x24, x23, [sp, #0x20]
0048DACB8  stp      x22, x21, [sp, #0x30]
0048DACBC  stp      x20, x19, [sp, #0x40]
0048DACC0  adrp     x24, #0x9591000
0048DACC4  adrp     x23, #0x8ee8000
0048DACC8  ldrb     w8, [x24, #0xfa1]
0048DACCC  ldr      x23, [x23, #0x3d8]
0048DACD0  mov      x19, x3
0048DACD4  mov      x20, x2
0048DACD8  mov      x22, x1
0048DACDC  mov      x21, x0
0048DACE0  tbnz     w8, #0, #0x48dacf8
0048DACE4  adrp     x0, #0x8ee8000
0048DACE8  ldr      x0, [x0, #0x3d8]
0048DACEC  bl       #0x382bd14 ; 
0048DACF0  mov      w8, #1
0048DACF4  strb     w8, [x24, #0xfa1]
0048DACF8  ldr      x0, [x23]
0048DACFC  mov      x1, x22
0048DAD00  str      xzr, [sp, #8]
0048DAD04  bl       #0x382be94 ; 
0048DAD08  str      x0, [sp]
0048DAD0C  mov      x1, sp
0048DAD10  mov      x0, x21
0048DAD14  mov      x2, x20
0048DAD18  mov      x3, x19
0048DAD1C  bl       #0x382bcc8 ; 
0048DAD20  ldp      x20, x19, [sp, #0x40]
0048DAD24  ldp      x22, x21, [sp, #0x30]
0048DAD28  ldp      x24, x23, [sp, #0x20]
0048DAD2C  ldr      x30, [sp, #0x10]
0048DAD30  add      sp, sp, #0x50
0048DAD34  ret      

; System.Func<WeightRandomData, CalCollectionTreasureData>$$EndInvoke
; RVA 0x48DAD38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAD38  str      x30, [sp, #-0x10]!
0048DAD3C  mov      x0, x1
0048DAD40  mov      x1, xzr
0048DAD44  bl       #0x382bccc ; 
0048DAD48  cbz      x0, #0x48dad5c
0048DAD4C  bl       #0x382be98 ; 
0048DAD50  ldr      x0, [x0]
0048DAD54  ldr      x30, [sp], #0x10
0048DAD58  ret      
0048DAD5C  bl       #0x382bfb8 ; 

