; System.Func<WeightRandomData, CalAttrCardData>$$.ctor
; RVA 0x48DA898; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA898  str      x30, [sp, #-0x30]!
0048DA89C  stp      x22, x21, [sp, #0x10]
0048DA8A0  stp      x20, x19, [sp, #0x20]
0048DA8A4  ldr      x8, [x2, #8]
0048DA8A8  mov      x19, x0
0048DA8AC  str      x2, [x0, #0x28]
0048DA8B0  mov      x21, x2
0048DA8B4  str      x8, [x0, #0x10]
0048DA8B8  str      x1, [x0, #0x20]!
0048DA8BC  mov      x20, x1
0048DA8C0  bl       #0x382bcb8 ; 
0048DA8C4  ldrb     w22, [x21, #0x52]
0048DA8C8  mov      x0, x21
0048DA8CC  str      x19, [x19, #0x40]
0048DA8D0  bl       #0x382be14 ; 
0048DA8D4  tbz      w0, #0, #0x48da8f0
0048DA8D8  cmp      w22, #1
0048DA8DC  b.ne     #0x48da8f4
0048DA8E0  adrp     x8, #0x3474000
0048DA8E4  add      x8, x8, #0xbec
0048DA8E8  str      x8, [x19, #0x18]
0048DA8EC  b        #0x48da904 ; 
0048DA8F0  cbz      x20, #0x48da920
0048DA8F4  ldr      x8, [x19, #0x10]
0048DA8F8  ldr      x9, [x19, #0x20]
0048DA8FC  str      x8, [x19, #0x18]
0048DA900  str      x9, [x19, #0x40]
0048DA904  adrp     x8, #0x3474000
0048DA908  add      x8, x8, #0xb7c
0048DA90C  str      x8, [x19, #0x38]
0048DA910  ldp      x20, x19, [sp, #0x20]
0048DA914  ldp      x22, x21, [sp, #0x10]
0048DA918  ldr      x30, [sp], #0x30
0048DA91C  ret      
0048DA920  adrp     x1, #0x1a2d000
0048DA924  add      x1, x1, #0x4e9
0048DA928  mov      x0, xzr
0048DA92C  bl       #0x382bfd4 ; 
0048DA930  mov      x1, xzr
0048DA934  bl       #0x382be7c ; 

; System.Func<WeightRandomData, CalAttrCardData>$$Invoke
; RVA 0x48DA938; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA938  sub      sp, sp, #0x50
0048DA93C  str      x30, [sp, #0x40]
0048DA940  ldp      q2, q0, [x1, #0x10]
0048DA944  ldr      x10, [x1, #0x30]
0048DA948  ldr      q1, [x1]
0048DA94C  ldr      x9, [x0, #0x18]
0048DA950  ldr      x8, [x0, #0x40]
0048DA954  str      x10, [sp, #0x30]
0048DA958  stp      q2, q0, [sp, #0x10]
0048DA95C  str      q1, [sp]
0048DA960  ldr      x2, [x0, #0x28]
0048DA964  mov      x1, sp
0048DA968  mov      x0, x8
0048DA96C  blr      x9
0048DA970  ldr      x30, [sp, #0x40]
0048DA974  add      sp, sp, #0x50
0048DA978  ret      

; System.Func<WeightRandomData, CalAttrCardData>$$BeginInvoke
; RVA 0x48DA97C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA97C  sub      sp, sp, #0x50
0048DA980  str      x30, [sp, #0x10]
0048DA984  stp      x24, x23, [sp, #0x20]
0048DA988  stp      x22, x21, [sp, #0x30]
0048DA98C  stp      x20, x19, [sp, #0x40]
0048DA990  adrp     x24, #0x9591000
0048DA994  adrp     x23, #0x8ee8000
0048DA998  ldrb     w8, [x24, #0xf9f]
0048DA99C  ldr      x23, [x23, #0x3d8]
0048DA9A0  mov      x19, x3
0048DA9A4  mov      x20, x2
0048DA9A8  mov      x22, x1
0048DA9AC  mov      x21, x0
0048DA9B0  tbnz     w8, #0, #0x48da9c8
0048DA9B4  adrp     x0, #0x8ee8000
0048DA9B8  ldr      x0, [x0, #0x3d8]
0048DA9BC  bl       #0x382bd14 ; 
0048DA9C0  mov      w8, #1
0048DA9C4  strb     w8, [x24, #0xf9f]
0048DA9C8  ldr      x0, [x23]
0048DA9CC  mov      x1, x22
0048DA9D0  str      xzr, [sp, #8]
0048DA9D4  bl       #0x382be94 ; 
0048DA9D8  str      x0, [sp]
0048DA9DC  mov      x1, sp
0048DA9E0  mov      x0, x21
0048DA9E4  mov      x2, x20
0048DA9E8  mov      x3, x19
0048DA9EC  bl       #0x382bcc8 ; 
0048DA9F0  ldp      x20, x19, [sp, #0x40]
0048DA9F4  ldp      x22, x21, [sp, #0x30]
0048DA9F8  ldp      x24, x23, [sp, #0x20]
0048DA9FC  ldr      x30, [sp, #0x10]
0048DAA00  add      sp, sp, #0x50
0048DAA04  ret      

; System.Func<WeightRandomData, CalAttrCardData>$$EndInvoke
; RVA 0x48DAA08; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAA08  str      x30, [sp, #-0x10]!
0048DAA0C  mov      x0, x1
0048DAA10  mov      x1, xzr
0048DAA14  bl       #0x382bccc ; 
0048DAA18  cbz      x0, #0x48daa2c
0048DAA1C  bl       #0x382be98 ; 
0048DAA20  ldr      x0, [x0]
0048DAA24  ldr      x30, [sp], #0x10
0048DAA28  ret      
0048DAA2C  bl       #0x382bfb8 ; 

