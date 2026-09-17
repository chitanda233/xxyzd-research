; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRoleData>$$.ctor
; RVA 0x5A0CA60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0CA60  str      x30, [sp, #-0x30]!
005A0CA64  stp      x22, x21, [sp, #0x10]
005A0CA68  stp      x20, x19, [sp, #0x20]
005A0CA6C  ldr      x8, [x4, #0x20]
005A0CA70  mov      x21, x1
005A0CA74  mov      x19, x3
005A0CA78  mov      x20, x2
005A0CA7C  ldr      x8, [x8, #0xc0]
005A0CA80  mov      x22, x0
005A0CA84  ldr      x1, [x8]
005A0CA88  bl       #0x4a73980 ; System.Linq.Enumerable.Iterator<CalRoleData>$$.ctor
005A0CA8C  mov      x0, x22
005A0CA90  str      x21, [x0, #0x48]!
005A0CA94  mov      x1, x21
005A0CA98  bl       #0x382bcb8 ; 
005A0CA9C  mov      x0, x22
005A0CAA0  str      x20, [x0, #0x50]!
005A0CAA4  mov      x1, x20
005A0CAA8  bl       #0x382bcb8 ; 
005A0CAAC  str      x19, [x22, #0x58]!
005A0CAB0  mov      x0, x22
005A0CAB4  mov      x1, x19
005A0CAB8  ldp      x20, x19, [sp, #0x20]
005A0CABC  ldp      x22, x21, [sp, #0x10]
005A0CAC0  ldr      x30, [sp], #0x30
005A0CAC4  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRoleData>$$Clone
; RVA 0x5A0CAC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0CAC8  str      x30, [sp, #-0x30]!
005A0CACC  stp      x22, x21, [sp, #0x10]
005A0CAD0  stp      x20, x19, [sp, #0x20]
005A0CAD4  ldr      x9, [x1, #0x20]
005A0CAD8  mov      x8, x0
005A0CADC  ldp      x21, x20, [x8, #0x48]
005A0CAE0  ldr      x22, [x8, #0x58]
005A0CAE4  ldr      x9, [x9, #0xc0]
005A0CAE8  mov      x19, x1
005A0CAEC  ldr      x0, [x9, #0x18]
005A0CAF0  ldrb     w9, [x0, #0x135]
005A0CAF4  tbnz     w9, #0, #0x5a0cafc
005A0CAF8  bl       #0x3a7e60c ; 
005A0CAFC  bl       #0x382bfa0 ; 
005A0CB00  ldr      x8, [x19, #0x20]
005A0CB04  mov      x1, x21
005A0CB08  mov      x2, x20
005A0CB0C  mov      x3, x22
005A0CB10  ldr      x8, [x8, #0xc0]
005A0CB14  mov      x19, x0
005A0CB18  ldr      x4, [x8, #0x30]
005A0CB1C  bl       #0x5a0ca60 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRoleData>$$.ctor
005A0CB20  mov      x0, x19
005A0CB24  ldp      x20, x19, [sp, #0x20]
005A0CB28  ldp      x22, x21, [sp, #0x10]
005A0CB2C  ldr      x30, [sp], #0x30
005A0CB30  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRoleData>$$MoveNext
; RVA 0x5A0CB34; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0CB34  sub      sp, sp, #0x110
005A0CB38  stp      x29, x30, [sp, #0xf0]
005A0CB3C  stp      x20, x19, [sp, #0x100]
005A0CB40  ldr      w8, [x0, #0x14]
005A0CB44  cmp      w8, #1
005A0CB48  b.ne     #0x5a0cc60
005A0CB4C  mov      x19, x0
005A0CB50  mov      w20, #0x38
005A0CB54  ldr      x9, [x19, #0x48]
005A0CB58  cbz      x9, #0x5a0cc78
005A0CB5C  ldrsw    x8, [x19, #0x60]
005A0CB60  ldr      w10, [x9, #0x18]
005A0CB64  cmp      w8, w10
005A0CB68  b.ge     #0x5a0cc50
005A0CB6C  cmp      w8, w10
005A0CB70  b.hs     #0x5a0cc74
005A0CB74  madd     x9, x8, x20, x9
005A0CB78  ldr      x10, [x9, #0x50]
005A0CB7C  ldp      q1, q0, [x9, #0x30]
005A0CB80  ldr      q2, [x9, #0x20]
005A0CB84  add      w8, w8, #1
005A0CB88  str      x10, [sp, #0xa0]
005A0CB8C  stp      q1, q0, [sp, #0x80]
005A0CB90  str      q2, [sp, #0x70]
005A0CB94  ldr      x9, [x19, #0x50]
005A0CB98  str      w8, [x19, #0x60]
005A0CB9C  cbz      x9, #0x5a0cbd0
005A0CBA0  ldp      q0, q1, [sp, #0x70]
005A0CBA4  ldr      q2, [sp, #0x90]
005A0CBA8  ldr      x10, [sp, #0xa0]
005A0CBAC  ldr      x8, [x9, #0x18]
005A0CBB0  ldr      x0, [x9, #0x40]
005A0CBB4  stp      q0, q1, [sp, #0xb0]
005A0CBB8  str      q2, [sp, #0xd0]
005A0CBBC  str      x10, [sp, #0xe0]
005A0CBC0  ldr      x2, [x9, #0x28]
005A0CBC4  add      x1, sp, #0xb0
005A0CBC8  blr      x8
005A0CBCC  tbz      w0, #0, #0x5a0cb54
005A0CBD0  ldr      x8, [x19, #0x58]
005A0CBD4  ldp      q0, q1, [sp, #0x70]
005A0CBD8  ldr      q2, [sp, #0x90]
005A0CBDC  ldr      x9, [sp, #0xa0]
005A0CBE0  stp      q0, q1, [sp, #0x30]
005A0CBE4  str      q2, [sp, #0x50]
005A0CBE8  str      x9, [sp, #0x60]
005A0CBEC  cbz      x8, #0x5a0cc78
005A0CBF0  ldp      q0, q1, [sp, #0x30]
005A0CBF4  ldr      q2, [sp, #0x50]
005A0CBF8  ldr      x10, [sp, #0x60]
005A0CBFC  ldr      x9, [x8, #0x18]
005A0CC00  ldr      x0, [x8, #0x40]
005A0CC04  stp      q0, q1, [sp, #0xb0]
005A0CC08  str      q2, [sp, #0xd0]
005A0CC0C  str      x10, [sp, #0xe0]
005A0CC10  ldr      x2, [x8, #0x28]
005A0CC14  mov      x8, sp
005A0CC18  add      x1, sp, #0xb0
005A0CC1C  blr      x9
005A0CC20  ldp      q1, q0, [sp, #0x10]
005A0CC24  ldr      q2, [sp]
005A0CC28  add      x0, x19, #0x28
005A0CC2C  mov      x1, xzr
005A0CC30  stp      q1, q0, [sp, #0xc0]
005A0CC34  str      q2, [sp, #0xb0]
005A0CC38  stur     q0, [x19, #0x38]
005A0CC3C  stur     q1, [x19, #0x28]
005A0CC40  stur     q2, [x19, #0x18]
005A0CC44  bl       #0x382bcb8 ; 
005A0CC48  mov      w0, #1
005A0CC4C  b        #0x5a0cc64 ; 
005A0CC50  ldr      x8, [x19]
005A0CC54  mov      x0, x19
005A0CC58  ldp      x9, x1, [x8, #0x1f8]
005A0CC5C  blr      x9
005A0CC60  mov      w0, wzr
005A0CC64  ldp      x20, x19, [sp, #0x100]
005A0CC68  ldp      x29, x30, [sp, #0xf0]
005A0CC6C  add      sp, sp, #0x110
005A0CC70  ret      
005A0CC74  bl       #0x382bfc0 ; 
005A0CC78  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRoleData>$$Where
; RVA 0x5A0CC7C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0CC7C  stp      x30, x21, [sp, #-0x20]!
005A0CC80  stp      x20, x19, [sp, #0x10]
005A0CC84  ldr      x8, [x2, #0x20]
005A0CC88  mov      x20, x2
005A0CC8C  mov      x19, x1
005A0CC90  mov      x21, x0
005A0CC94  ldr      x8, [x8, #0xc0]
005A0CC98  ldr      x8, [x8, #0x70]
005A0CC9C  ldrb     w9, [x8, #0x135]
005A0CCA0  tbnz     w9, #0, #0x5a0ccb0
005A0CCA4  mov      x0, x8
005A0CCA8  bl       #0x3a7e60c ; 
005A0CCAC  mov      x8, x0
005A0CCB0  mov      x0, x8
005A0CCB4  bl       #0x382bfa0 ; 
005A0CCB8  ldr      x8, [x20, #0x20]
005A0CCBC  mov      x1, x21
005A0CCC0  mov      x2, x19
005A0CCC4  mov      x20, x0
005A0CCC8  ldr      x8, [x8, #0xc0]
005A0CCCC  ldr      x3, [x8, #0x78]
005A0CCD0  bl       #0x59c7908 ; System.Linq.Enumerable.WhereEnumerableIterator<CalRoleData>$$.ctor
005A0CCD4  mov      x0, x20
005A0CCD8  ldp      x20, x19, [sp, #0x10]
005A0CCDC  ldp      x30, x21, [sp], #0x20
005A0CCE0  ret      

