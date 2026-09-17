; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRuneData>$$.ctor
; RVA 0x5A0CCE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0CCE4  str      x30, [sp, #-0x30]!
005A0CCE8  stp      x22, x21, [sp, #0x10]
005A0CCEC  stp      x20, x19, [sp, #0x20]
005A0CCF0  ldr      x8, [x4, #0x20]
005A0CCF4  mov      x21, x1
005A0CCF8  mov      x19, x3
005A0CCFC  mov      x20, x2
005A0CD00  ldr      x8, [x8, #0xc0]
005A0CD04  mov      x22, x0
005A0CD08  ldr      x1, [x8]
005A0CD0C  bl       #0x4a73ac4 ; System.Linq.Enumerable.Iterator<CalRuneData>$$.ctor
005A0CD10  mov      x0, x22
005A0CD14  str      x21, [x0, #0x20]!
005A0CD18  mov      x1, x21
005A0CD1C  bl       #0x382bcb8 ; 
005A0CD20  mov      x0, x22
005A0CD24  str      x20, [x0, #0x28]!
005A0CD28  mov      x1, x20
005A0CD2C  bl       #0x382bcb8 ; 
005A0CD30  str      x19, [x22, #0x30]!
005A0CD34  mov      x0, x22
005A0CD38  mov      x1, x19
005A0CD3C  ldp      x20, x19, [sp, #0x20]
005A0CD40  ldp      x22, x21, [sp, #0x10]
005A0CD44  ldr      x30, [sp], #0x30
005A0CD48  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRuneData>$$Clone
; RVA 0x5A0CD4C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0CD4C  str      x30, [sp, #-0x30]!
005A0CD50  stp      x22, x21, [sp, #0x10]
005A0CD54  stp      x20, x19, [sp, #0x20]
005A0CD58  ldr      x9, [x1, #0x20]
005A0CD5C  mov      x8, x0
005A0CD60  ldp      x21, x20, [x8, #0x20]
005A0CD64  ldr      x22, [x8, #0x30]
005A0CD68  ldr      x9, [x9, #0xc0]
005A0CD6C  mov      x19, x1
005A0CD70  ldr      x0, [x9, #0x18]
005A0CD74  ldrb     w9, [x0, #0x135]
005A0CD78  tbnz     w9, #0, #0x5a0cd80
005A0CD7C  bl       #0x3a7e60c ; 
005A0CD80  bl       #0x382bfa0 ; 
005A0CD84  ldr      x8, [x19, #0x20]
005A0CD88  mov      x1, x21
005A0CD8C  mov      x2, x20
005A0CD90  mov      x3, x22
005A0CD94  ldr      x8, [x8, #0xc0]
005A0CD98  mov      x19, x0
005A0CD9C  ldr      x4, [x8, #0x30]
005A0CDA0  bl       #0x5a0cce4 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRuneData>$$.ctor
005A0CDA4  mov      x0, x19
005A0CDA8  ldp      x20, x19, [sp, #0x20]
005A0CDAC  ldp      x22, x21, [sp, #0x10]
005A0CDB0  ldr      x30, [sp], #0x30
005A0CDB4  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRuneData>$$MoveNext
; RVA 0x5A0CDB8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0CDB8  sub      sp, sp, #0xe0
005A0CDBC  str      x30, [sp, #0xc0]
005A0CDC0  stp      x20, x19, [sp, #0xd0]
005A0CDC4  ldr      w8, [x0, #0x14]
005A0CDC8  cmp      w8, #1
005A0CDCC  b.ne     #0x5a0cebc
005A0CDD0  mov      x19, x0
005A0CDD4  mov      w20, #0x38
005A0CDD8  ldr      x9, [x19, #0x20]
005A0CDDC  cbz      x9, #0x5a0ced4
005A0CDE0  ldrsw    x8, [x19, #0x38]
005A0CDE4  ldr      w10, [x9, #0x18]
005A0CDE8  cmp      w8, w10
005A0CDEC  b.ge     #0x5a0ceac
005A0CDF0  cmp      w8, w10
005A0CDF4  b.hs     #0x5a0ced0
005A0CDF8  madd     x9, x8, x20, x9
005A0CDFC  ldr      x10, [x9, #0x50]
005A0CE00  ldp      q1, q0, [x9, #0x30]
005A0CE04  ldr      q2, [x9, #0x20]
005A0CE08  add      w8, w8, #1
005A0CE0C  str      x10, [sp, #0x70]
005A0CE10  stp      q1, q0, [sp, #0x50]
005A0CE14  str      q2, [sp, #0x40]
005A0CE18  ldr      x9, [x19, #0x28]
005A0CE1C  str      w8, [x19, #0x38]
005A0CE20  cbz      x9, #0x5a0ce54
005A0CE24  ldp      q0, q1, [sp, #0x40]
005A0CE28  ldr      q2, [sp, #0x60]
005A0CE2C  ldr      x10, [sp, #0x70]
005A0CE30  ldr      x8, [x9, #0x18]
005A0CE34  ldr      x0, [x9, #0x40]
005A0CE38  stp      q0, q1, [sp, #0x80]
005A0CE3C  str      q2, [sp, #0xa0]
005A0CE40  str      x10, [sp, #0xb0]
005A0CE44  ldr      x2, [x9, #0x28]
005A0CE48  add      x1, sp, #0x80
005A0CE4C  blr      x8
005A0CE50  tbz      w0, #0, #0x5a0cdd8
005A0CE54  ldr      x8, [x19, #0x30]
005A0CE58  ldp      q0, q1, [sp, #0x40]
005A0CE5C  ldr      q2, [sp, #0x60]
005A0CE60  ldr      x9, [sp, #0x70]
005A0CE64  stp      q0, q1, [sp]
005A0CE68  str      q2, [sp, #0x20]
005A0CE6C  str      x9, [sp, #0x30]
005A0CE70  cbz      x8, #0x5a0ced4
005A0CE74  ldp      q0, q1, [sp]
005A0CE78  ldr      q2, [sp, #0x20]
005A0CE7C  ldr      x10, [sp, #0x30]
005A0CE80  ldr      x9, [x8, #0x18]
005A0CE84  ldr      x0, [x8, #0x40]
005A0CE88  stp      q0, q1, [sp, #0x80]
005A0CE8C  str      q2, [sp, #0xa0]
005A0CE90  str      x10, [sp, #0xb0]
005A0CE94  ldr      x2, [x8, #0x28]
005A0CE98  add      x1, sp, #0x80
005A0CE9C  blr      x9
005A0CEA0  str      w0, [x19, #0x18]
005A0CEA4  mov      w0, #1
005A0CEA8  b        #0x5a0cec0 ; 
005A0CEAC  ldr      x8, [x19]
005A0CEB0  mov      x0, x19
005A0CEB4  ldp      x9, x1, [x8, #0x1f8]
005A0CEB8  blr      x9
005A0CEBC  mov      w0, wzr
005A0CEC0  ldp      x20, x19, [sp, #0xd0]
005A0CEC4  ldr      x30, [sp, #0xc0]
005A0CEC8  add      sp, sp, #0xe0
005A0CECC  ret      
005A0CED0  bl       #0x382bfc0 ; 
005A0CED4  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRuneData>$$Where
; RVA 0x5A0CED8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0CED8  stp      x30, x21, [sp, #-0x20]!
005A0CEDC  stp      x20, x19, [sp, #0x10]
005A0CEE0  ldr      x8, [x2, #0x20]
005A0CEE4  mov      x20, x2
005A0CEE8  mov      x19, x1
005A0CEEC  mov      x21, x0
005A0CEF0  ldr      x8, [x8, #0xc0]
005A0CEF4  ldr      x8, [x8, #0x70]
005A0CEF8  ldrb     w9, [x8, #0x135]
005A0CEFC  tbnz     w9, #0, #0x5a0cf0c
005A0CF00  mov      x0, x8
005A0CF04  bl       #0x3a7e60c ; 
005A0CF08  mov      x8, x0
005A0CF0C  mov      x0, x8
005A0CF10  bl       #0x382bfa0 ; 
005A0CF14  ldr      x8, [x20, #0x20]
005A0CF18  mov      x1, x21
005A0CF1C  mov      x2, x19
005A0CF20  mov      x20, x0
005A0CF24  ldr      x8, [x8, #0xc0]
005A0CF28  ldr      x3, [x8, #0x78]
005A0CF2C  bl       #0x59c7d64 ; System.Linq.Enumerable.WhereEnumerableIterator<CalRuneData>$$.ctor
005A0CF30  mov      x0, x20
005A0CF34  ldp      x20, x19, [sp, #0x10]
005A0CF38  ldp      x30, x21, [sp], #0x20
005A0CF3C  ret      

