; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, char>$$.ctor
; RVA 0x5ABC8A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABC8A0  str      x30, [sp, #-0x30]!
005ABC8A4  stp      x22, x21, [sp, #0x10]
005ABC8A8  stp      x20, x19, [sp, #0x20]
005ABC8AC  ldr      x8, [x4, #0x20]
005ABC8B0  mov      x21, x1
005ABC8B4  mov      x19, x3
005ABC8B8  mov      x20, x2
005ABC8BC  ldr      x8, [x8, #0xc0]
005ABC8C0  mov      x22, x0
005ABC8C4  ldr      x1, [x8]
005ABC8C8  bl       #0x4a73bd4 ; System.Linq.Enumerable.Iterator<char>$$.ctor
005ABC8CC  mov      x0, x22
005ABC8D0  str      x21, [x0, #0x20]!
005ABC8D4  mov      x1, x21
005ABC8D8  bl       #0x382bcb8 ; 
005ABC8DC  mov      x0, x22
005ABC8E0  str      x20, [x0, #0x28]!
005ABC8E4  mov      x1, x20
005ABC8E8  bl       #0x382bcb8 ; 
005ABC8EC  str      x19, [x22, #0x30]!
005ABC8F0  mov      x0, x22
005ABC8F4  mov      x1, x19
005ABC8F8  ldp      x20, x19, [sp, #0x20]
005ABC8FC  ldp      x22, x21, [sp, #0x10]
005ABC900  ldr      x30, [sp], #0x30
005ABC904  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, char>$$Clone
; RVA 0x5ABC908; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABC908  str      x30, [sp, #-0x30]!
005ABC90C  stp      x22, x21, [sp, #0x10]
005ABC910  stp      x20, x19, [sp, #0x20]
005ABC914  ldr      x9, [x1, #0x20]
005ABC918  mov      x8, x0
005ABC91C  ldp      x21, x20, [x8, #0x20]
005ABC920  ldr      x22, [x8, #0x30]
005ABC924  ldr      x9, [x9, #0xc0]
005ABC928  mov      x19, x1
005ABC92C  ldr      x0, [x9, #0x18]
005ABC930  ldrb     w9, [x0, #0x135]
005ABC934  tbnz     w9, #0, #0x5abc93c
005ABC938  bl       #0x3a7e60c ; 
005ABC93C  bl       #0x382bfa0 ; 
005ABC940  ldr      x8, [x19, #0x20]
005ABC944  mov      x1, x21
005ABC948  mov      x2, x20
005ABC94C  mov      x3, x22
005ABC950  ldr      x8, [x8, #0xc0]
005ABC954  mov      x19, x0
005ABC958  ldr      x4, [x8, #0x30]
005ABC95C  bl       #0x5abc8a0 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, char>$$.ctor
005ABC960  mov      x0, x19
005ABC964  ldp      x20, x19, [sp, #0x20]
005ABC968  ldp      x22, x21, [sp, #0x10]
005ABC96C  ldr      x30, [sp], #0x30
005ABC970  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, char>$$Dispose
; RVA 0x5ABC974; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABC974  str      x30, [sp, #-0x30]!
005ABC978  stp      x22, x21, [sp, #0x10]
005ABC97C  stp      x20, x19, [sp, #0x20]
005ABC980  adrp     x21, #0x9595000
005ABC984  ldrb     w8, [x21, #0x455]
005ABC988  mov      x19, x1
005ABC98C  mov      x20, x0
005ABC990  tbnz     w8, #0, #0x5abc9a8
005ABC994  adrp     x0, #0x8ebf000
005ABC998  ldr      x0, [x0, #0x4e8]
005ABC99C  bl       #0x382bd14 ; 
005ABC9A0  mov      w8, #1
005ABC9A4  strb     w8, [x21, #0x455]
005ABC9A8  mov      x21, x20
005ABC9AC  ldr      x22, [x21, #0x38]!
005ABC9B0  cbz      x22, #0x5abca14
005ABC9B4  adrp     x10, #0x8ebf000
005ABC9B8  ldr      x8, [x22]
005ABC9BC  ldr      x10, [x10, #0x4e8]
005ABC9C0  ldrh     w9, [x8, #0x12e]
005ABC9C4  ldr      x1, [x10]
005ABC9C8  cbz      x9, #0x5abc9ec
005ABC9CC  ldr      x10, [x8, #0xb0]
005ABC9D0  add      x10, x10, #8
005ABC9D4  ldur     x11, [x10, #-8]
005ABC9D8  cmp      x11, x1
005ABC9DC  b.eq     #0x5abc9fc
005ABC9E0  subs     x9, x9, #1
005ABC9E4  add      x10, x10, #0x10
005ABC9E8  b.ne     #0x5abc9d4
005ABC9EC  mov      x0, x22
005ABC9F0  mov      w2, wzr
005ABC9F4  bl       #0x3a7e710 ; 
005ABC9F8  b        #0x5abca08 ; 
005ABC9FC  ldrsw    x9, [x10]
005ABCA00  add      x8, x8, x9, lsl #4
005ABCA04  add      x0, x8, #0x138
005ABCA08  ldp      x8, x1, [x0]
005ABCA0C  mov      x0, x22
005ABCA10  blr      x8
005ABCA14  mov      x0, x21
005ABCA18  mov      x1, xzr
005ABCA1C  str      xzr, [x20, #0x38]
005ABCA20  bl       #0x382bcb8 ; 
005ABCA24  ldr      x8, [x19, #0x20]
005ABCA28  mov      x0, x20
005ABCA2C  ldp      x20, x19, [sp, #0x20]
005ABCA30  ldp      x22, x21, [sp, #0x10]
005ABCA34  ldr      x8, [x8, #0xc0]
005ABCA38  ldr      x1, [x8, #0x48]
005ABCA3C  ldr      x30, [sp], #0x30
005ABCA40  b        #0x4a73c10 ; System.Linq.Enumerable.Iterator<char>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, char>$$MoveNext
; RVA 0x5ABCA44; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABCA44  sub      sp, sp, #0xf0
005ABCA48  str      x30, [sp, #0xc0]
005ABCA4C  stp      x22, x21, [sp, #0xd0]
005ABCA50  stp      x20, x19, [sp, #0xe0]
005ABCA54  adrp     x21, #0x9595000
005ABCA58  ldrb     w8, [x21, #0x456]
005ABCA5C  mov      x20, x1
005ABCA60  mov      x19, x0
005ABCA64  tbnz     w8, #0, #0x5abca7c
005ABCA68  adrp     x0, #0x8ebf000
005ABCA6C  ldr      x0, [x0, #0x4f0]
005ABCA70  bl       #0x382bd14 ; 
005ABCA74  mov      w8, #1
005ABCA78  strb     w8, [x21, #0x456]
005ABCA7C  ldr      w8, [x19, #0x14]
005ABCA80  adrp     x22, #0x8ebf000
005ABCA84  ldr      x22, [x22, #0x4f0]
005ABCA88  cmp      w8, #2
005ABCA8C  b.eq     #0x5abcb30
005ABCA90  cmp      w8, #1
005ABCA94  b.ne     #0x5abccd0
005ABCA98  ldr      x21, [x19, #0x20]
005ABCA9C  cbz      x21, #0x5abcce8
005ABCAA0  ldr      x8, [x20, #0x20]
005ABCAA4  ldr      x8, [x8, #0xc0]
005ABCAA8  ldr      x1, [x8, #0x10]
005ABCAAC  ldrb     w8, [x1, #0x135]
005ABCAB0  tbnz     w8, #0, #0x5abcac0
005ABCAB4  mov      x0, x1
005ABCAB8  bl       #0x3a7e60c ; 
005ABCABC  mov      x1, x0
005ABCAC0  ldr      x8, [x21]
005ABCAC4  ldrh     w9, [x8, #0x12e]
005ABCAC8  cbz      x9, #0x5abcaec
005ABCACC  ldr      x10, [x8, #0xb0]
005ABCAD0  add      x10, x10, #8
005ABCAD4  ldur     x11, [x10, #-8]
005ABCAD8  cmp      x11, x1
005ABCADC  b.eq     #0x5abcafc
005ABCAE0  subs     x9, x9, #1
005ABCAE4  add      x10, x10, #0x10
005ABCAE8  b.ne     #0x5abcad4
005ABCAEC  mov      x0, x21
005ABCAF0  mov      w2, wzr
005ABCAF4  bl       #0x3a7e710 ; 
005ABCAF8  b        #0x5abcb08 ; 
005ABCAFC  ldrsw    x9, [x10]
005ABCB00  add      x8, x8, x9, lsl #4
005ABCB04  add      x0, x8, #0x138
005ABCB08  ldp      x8, x1, [x0]
005ABCB0C  mov      x0, x21
005ABCB10  blr      x8
005ABCB14  mov      x21, x19
005ABCB18  str      x0, [x21, #0x38]!
005ABCB1C  mov      x1, x0
005ABCB20  mov      x0, x21
005ABCB24  bl       #0x382bcb8 ; 
005ABCB28  mov      w8, #2
005ABCB2C  stur     w8, [x21, #-0x24]
005ABCB30  ldr      x21, [x19, #0x38]
005ABCB34  cbz      x21, #0x5abcce8
005ABCB38  ldr      x8, [x21]
005ABCB3C  ldr      x1, [x22]
005ABCB40  ldrh     w9, [x8, #0x12e]
005ABCB44  cbz      x9, #0x5abcb68
005ABCB48  ldr      x10, [x8, #0xb0]
005ABCB4C  add      x10, x10, #8
005ABCB50  ldur     x11, [x10, #-8]
005ABCB54  cmp      x11, x1
005ABCB58  b.eq     #0x5abcb78
005ABCB5C  subs     x9, x9, #1
005ABCB60  add      x10, x10, #0x10
005ABCB64  b.ne     #0x5abcb50
005ABCB68  mov      x0, x21
005ABCB6C  mov      w2, wzr
005ABCB70  bl       #0x3a7e710 ; 
005ABCB74  b        #0x5abcb84 ; 
005ABCB78  ldrsw    x9, [x10]
005ABCB7C  add      x8, x8, x9, lsl #4
005ABCB80  add      x0, x8, #0x138
005ABCB84  ldp      x8, x1, [x0]
005ABCB88  mov      x0, x21
005ABCB8C  blr      x8
005ABCB90  tbz      w0, #0, #0x5abccbc
005ABCB94  ldr      x21, [x19, #0x38]
005ABCB98  cbz      x21, #0x5abcce8
005ABCB9C  ldr      x8, [x20, #0x20]
005ABCBA0  ldr      x8, [x8, #0xc0]
005ABCBA4  ldr      x1, [x8, #0x40]
005ABCBA8  ldrb     w8, [x1, #0x135]
005ABCBAC  tbnz     w8, #0, #0x5abcbbc
005ABCBB0  mov      x0, x1
005ABCBB4  bl       #0x3a7e60c ; 
005ABCBB8  mov      x1, x0
005ABCBBC  ldr      x8, [x21]
005ABCBC0  ldrh     w9, [x8, #0x12e]
005ABCBC4  cbz      x9, #0x5abcbe8
005ABCBC8  ldr      x10, [x8, #0xb0]
005ABCBCC  add      x10, x10, #8
005ABCBD0  ldur     x11, [x10, #-8]
005ABCBD4  cmp      x11, x1
005ABCBD8  b.eq     #0x5abcbf8
005ABCBDC  subs     x9, x9, #1
005ABCBE0  add      x10, x10, #0x10
005ABCBE4  b.ne     #0x5abcbd0
005ABCBE8  mov      x0, x21
005ABCBEC  mov      w2, wzr
005ABCBF0  bl       #0x3a7e710 ; 
005ABCBF4  b        #0x5abcc04 ; 
005ABCBF8  ldrsw    x9, [x10]
005ABCBFC  add      x8, x8, x9, lsl #4
005ABCC00  add      x0, x8, #0x138
005ABCC04  ldp      x9, x1, [x0]
005ABCC08  add      x8, sp, #0x80
005ABCC0C  mov      x0, x21
005ABCC10  blr      x9
005ABCC14  ldp      q0, q1, [sp, #0x80]
005ABCC18  ldr      q2, [sp, #0xa0]
005ABCC1C  ldr      x8, [sp, #0xb0]
005ABCC20  stp      q0, q1, [sp, #0x40]
005ABCC24  str      q2, [sp, #0x60]
005ABCC28  str      x8, [sp, #0x70]
005ABCC2C  ldr      x8, [x19, #0x28]
005ABCC30  cbz      x8, #0x5abcc64
005ABCC34  ldp      q0, q1, [sp, #0x40]
005ABCC38  ldr      q2, [sp, #0x60]
005ABCC3C  ldr      x10, [sp, #0x70]
005ABCC40  ldr      x9, [x8, #0x18]
005ABCC44  ldr      x0, [x8, #0x40]
005ABCC48  stp      q0, q1, [sp, #0x80]
005ABCC4C  str      q2, [sp, #0xa0]
005ABCC50  str      x10, [sp, #0xb0]
005ABCC54  ldr      x2, [x8, #0x28]
005ABCC58  add      x1, sp, #0x80
005ABCC5C  blr      x9
005ABCC60  tbz      w0, #0, #0x5abcb30
005ABCC64  ldr      x8, [x19, #0x30]
005ABCC68  ldp      q0, q1, [sp, #0x40]
005ABCC6C  ldr      q2, [sp, #0x60]
005ABCC70  ldr      x9, [sp, #0x70]
005ABCC74  stp      q0, q1, [sp]
005ABCC78  str      q2, [sp, #0x20]
005ABCC7C  str      x9, [sp, #0x30]
005ABCC80  cbz      x8, #0x5abcce8
005ABCC84  ldp      q0, q1, [sp]
005ABCC88  ldr      q2, [sp, #0x20]
005ABCC8C  ldr      x10, [sp, #0x30]
005ABCC90  ldr      x9, [x8, #0x18]
005ABCC94  ldr      x0, [x8, #0x40]
005ABCC98  stp      q0, q1, [sp, #0x80]
005ABCC9C  str      q2, [sp, #0xa0]
005ABCCA0  str      x10, [sp, #0xb0]
005ABCCA4  ldr      x2, [x8, #0x28]
005ABCCA8  add      x1, sp, #0x80
005ABCCAC  blr      x9
005ABCCB0  strh     w0, [x19, #0x18]
005ABCCB4  mov      w0, #1
005ABCCB8  b        #0x5abccd4 ; 
005ABCCBC  cbz      x19, #0x5abcce8
005ABCCC0  ldr      x8, [x19]
005ABCCC4  mov      x0, x19
005ABCCC8  ldp      x9, x1, [x8, #0x1f8]
005ABCCCC  blr      x9
005ABCCD0  mov      w0, wzr
005ABCCD4  ldp      x20, x19, [sp, #0xe0]
005ABCCD8  ldp      x22, x21, [sp, #0xd0]
005ABCCDC  ldr      x30, [sp, #0xc0]
005ABCCE0  add      sp, sp, #0xf0
005ABCCE4  ret      
005ABCCE8  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, char>$$Where
; RVA 0x5ABCCEC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABCCEC  stp      x30, x21, [sp, #-0x20]!
005ABCCF0  stp      x20, x19, [sp, #0x10]
005ABCCF4  ldr      x8, [x2, #0x20]
005ABCCF8  mov      x20, x2
005ABCCFC  mov      x19, x1
005ABCD00  mov      x21, x0
005ABCD04  ldr      x8, [x8, #0xc0]
005ABCD08  ldr      x8, [x8, #0x88]
005ABCD0C  ldrb     w9, [x8, #0x135]
005ABCD10  tbnz     w9, #0, #0x5abcd20
005ABCD14  mov      x0, x8
005ABCD18  bl       #0x3a7e60c ; 
005ABCD1C  mov      x8, x0
005ABCD20  mov      x0, x8
005ABCD24  bl       #0x382bfa0 ; 
005ABCD28  ldr      x8, [x20, #0x20]
005ABCD2C  mov      x1, x21
005ABCD30  mov      x2, x19
005ABCD34  mov      x20, x0
005ABCD38  ldr      x8, [x8, #0xc0]
005ABCD3C  ldr      x3, [x8, #0x90]
005ABCD40  bl       #0x59c8178 ; System.Linq.Enumerable.WhereEnumerableIterator<char>$$.ctor
005ABCD44  mov      x0, x20
005ABCD48  ldp      x20, x19, [sp, #0x10]
005ABCD4C  ldp      x30, x21, [sp], #0x20
005ABCD50  ret      

