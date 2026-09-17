; System.Func<WeightRandomData, CalAttrRelicData>$$.ctor
; RVA 0x48DAA30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAA30  str      x30, [sp, #-0x30]!
0048DAA34  stp      x22, x21, [sp, #0x10]
0048DAA38  stp      x20, x19, [sp, #0x20]
0048DAA3C  ldr      x8, [x2, #8]
0048DAA40  mov      x19, x0
0048DAA44  str      x2, [x0, #0x28]
0048DAA48  mov      x21, x2
0048DAA4C  str      x8, [x0, #0x10]
0048DAA50  str      x1, [x0, #0x20]!
0048DAA54  mov      x20, x1
0048DAA58  bl       #0x382bcb8 ; 
0048DAA5C  ldrb     w22, [x21, #0x52]
0048DAA60  mov      x0, x21
0048DAA64  str      x19, [x19, #0x40]
0048DAA68  bl       #0x382be14 ; 
0048DAA6C  tbz      w0, #0, #0x48daa88
0048DAA70  cmp      w22, #1
0048DAA74  b.ne     #0x48daa8c
0048DAA78  adrp     x8, #0x3474000
0048DAA7C  add      x8, x8, #0xc98
0048DAA80  str      x8, [x19, #0x18]
0048DAA84  b        #0x48daa9c ; 
0048DAA88  cbz      x20, #0x48daab8
0048DAA8C  ldr      x8, [x19, #0x10]
0048DAA90  ldr      x9, [x19, #0x20]
0048DAA94  str      x8, [x19, #0x18]
0048DAA98  str      x9, [x19, #0x40]
0048DAA9C  adrp     x8, #0x3474000
0048DAAA0  add      x8, x8, #0xc28
0048DAAA4  str      x8, [x19, #0x38]
0048DAAA8  ldp      x20, x19, [sp, #0x20]
0048DAAAC  ldp      x22, x21, [sp, #0x10]
0048DAAB0  ldr      x30, [sp], #0x30
0048DAAB4  ret      
0048DAAB8  adrp     x1, #0x1a2d000
0048DAABC  add      x1, x1, #0x4e9
0048DAAC0  mov      x0, xzr
0048DAAC4  bl       #0x382bfd4 ; 
0048DAAC8  mov      x1, xzr
0048DAACC  bl       #0x382be7c ; 

; System.Func<WeightRandomData, CalAttrRelicData>$$Invoke
; RVA 0x48DAAD0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAAD0  sub      sp, sp, #0x50
0048DAAD4  str      x30, [sp, #0x40]
0048DAAD8  ldp      q2, q0, [x1, #0x10]
0048DAADC  ldr      x10, [x1, #0x30]
0048DAAE0  ldr      q1, [x1]
0048DAAE4  ldr      x9, [x0, #0x18]
0048DAAE8  ldr      x8, [x0, #0x40]
0048DAAEC  str      x10, [sp, #0x30]
0048DAAF0  stp      q2, q0, [sp, #0x10]
0048DAAF4  str      q1, [sp]
0048DAAF8  ldr      x2, [x0, #0x28]
0048DAAFC  mov      x1, sp
0048DAB00  mov      x0, x8
0048DAB04  blr      x9
0048DAB08  ldr      x30, [sp, #0x40]
0048DAB0C  add      sp, sp, #0x50
0048DAB10  ret      

; System.Func<WeightRandomData, CalAttrRelicData>$$BeginInvoke
; RVA 0x48DAB14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAB14  sub      sp, sp, #0x50
0048DAB18  str      x30, [sp, #0x10]
0048DAB1C  stp      x24, x23, [sp, #0x20]
0048DAB20  stp      x22, x21, [sp, #0x30]
0048DAB24  stp      x20, x19, [sp, #0x40]
0048DAB28  adrp     x24, #0x9591000
0048DAB2C  adrp     x23, #0x8ee8000
0048DAB30  ldrb     w8, [x24, #0xfa0]
0048DAB34  ldr      x23, [x23, #0x3d8]
0048DAB38  mov      x19, x3
0048DAB3C  mov      x20, x2
0048DAB40  mov      x22, x1
0048DAB44  mov      x21, x0
0048DAB48  tbnz     w8, #0, #0x48dab60
0048DAB4C  adrp     x0, #0x8ee8000
0048DAB50  ldr      x0, [x0, #0x3d8]
0048DAB54  bl       #0x382bd14 ; 
0048DAB58  mov      w8, #1
0048DAB5C  strb     w8, [x24, #0xfa0]
0048DAB60  ldr      x0, [x23]
0048DAB64  mov      x1, x22
0048DAB68  str      xzr, [sp, #8]
0048DAB6C  bl       #0x382be94 ; 
0048DAB70  str      x0, [sp]
0048DAB74  mov      x1, sp
0048DAB78  mov      x0, x21
0048DAB7C  mov      x2, x20
0048DAB80  mov      x3, x19
0048DAB84  bl       #0x382bcc8 ; 
0048DAB88  ldp      x20, x19, [sp, #0x40]
0048DAB8C  ldp      x22, x21, [sp, #0x30]
0048DAB90  ldp      x24, x23, [sp, #0x20]
0048DAB94  ldr      x30, [sp, #0x10]
0048DAB98  add      sp, sp, #0x50
0048DAB9C  ret      

; System.Func<WeightRandomData, CalAttrRelicData>$$EndInvoke
; RVA 0x48DABA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DABA0  str      x30, [sp, #-0x10]!
0048DABA4  mov      x0, x1
0048DABA8  mov      x1, xzr
0048DABAC  bl       #0x382bccc ; 
0048DABB0  cbz      x0, #0x48dabc4
0048DABB4  bl       #0x382be98 ; 
0048DABB8  ldr      x0, [x0]
0048DABBC  ldr      x30, [sp], #0x10
0048DABC0  ret      
0048DABC4  bl       #0x382bfb8 ; 

