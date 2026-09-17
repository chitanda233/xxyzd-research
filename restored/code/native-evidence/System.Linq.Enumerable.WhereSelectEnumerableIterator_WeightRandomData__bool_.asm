; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, bool>$$.ctor
; RVA 0x5ABA788; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABA788  str      x30, [sp, #-0x30]!
005ABA78C  stp      x22, x21, [sp, #0x10]
005ABA790  stp      x20, x19, [sp, #0x20]
005ABA794  ldr      x8, [x4, #0x20]
005ABA798  mov      x21, x1
005ABA79C  mov      x19, x3
005ABA7A0  mov      x20, x2
005ABA7A4  ldr      x8, [x8, #0xc0]
005ABA7A8  mov      x22, x0
005ABA7AC  ldr      x1, [x8]
005ABA7B0  bl       #0x4a72f80 ; System.Linq.Enumerable.Iterator<bool>$$.ctor
005ABA7B4  mov      x0, x22
005ABA7B8  str      x21, [x0, #0x20]!
005ABA7BC  mov      x1, x21
005ABA7C0  bl       #0x382bcb8 ; 
005ABA7C4  mov      x0, x22
005ABA7C8  str      x20, [x0, #0x28]!
005ABA7CC  mov      x1, x20
005ABA7D0  bl       #0x382bcb8 ; 
005ABA7D4  str      x19, [x22, #0x30]!
005ABA7D8  mov      x0, x22
005ABA7DC  mov      x1, x19
005ABA7E0  ldp      x20, x19, [sp, #0x20]
005ABA7E4  ldp      x22, x21, [sp, #0x10]
005ABA7E8  ldr      x30, [sp], #0x30
005ABA7EC  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, bool>$$Clone
; RVA 0x5ABA7F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABA7F0  str      x30, [sp, #-0x30]!
005ABA7F4  stp      x22, x21, [sp, #0x10]
005ABA7F8  stp      x20, x19, [sp, #0x20]
005ABA7FC  ldr      x9, [x1, #0x20]
005ABA800  mov      x8, x0
005ABA804  ldp      x21, x20, [x8, #0x20]
005ABA808  ldr      x22, [x8, #0x30]
005ABA80C  ldr      x9, [x9, #0xc0]
005ABA810  mov      x19, x1
005ABA814  ldr      x0, [x9, #0x18]
005ABA818  ldrb     w9, [x0, #0x135]
005ABA81C  tbnz     w9, #0, #0x5aba824
005ABA820  bl       #0x3a7e60c ; 
005ABA824  bl       #0x382bfa0 ; 
005ABA828  ldr      x8, [x19, #0x20]
005ABA82C  mov      x1, x21
005ABA830  mov      x2, x20
005ABA834  mov      x3, x22
005ABA838  ldr      x8, [x8, #0xc0]
005ABA83C  mov      x19, x0
005ABA840  ldr      x4, [x8, #0x30]
005ABA844  bl       #0x5aba788 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, bool>$$.ctor
005ABA848  mov      x0, x19
005ABA84C  ldp      x20, x19, [sp, #0x20]
005ABA850  ldp      x22, x21, [sp, #0x10]
005ABA854  ldr      x30, [sp], #0x30
005ABA858  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, bool>$$Dispose
; RVA 0x5ABA85C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABA85C  str      x30, [sp, #-0x30]!
005ABA860  stp      x22, x21, [sp, #0x10]
005ABA864  stp      x20, x19, [sp, #0x20]
005ABA868  adrp     x21, #0x9595000
005ABA86C  ldrb     w8, [x21, #0x447]
005ABA870  mov      x19, x1
005ABA874  mov      x20, x0
005ABA878  tbnz     w8, #0, #0x5aba890
005ABA87C  adrp     x0, #0x8ebf000
005ABA880  ldr      x0, [x0, #0x4e8]
005ABA884  bl       #0x382bd14 ; 
005ABA888  mov      w8, #1
005ABA88C  strb     w8, [x21, #0x447]
005ABA890  mov      x21, x20
005ABA894  ldr      x22, [x21, #0x38]!
005ABA898  cbz      x22, #0x5aba8fc
005ABA89C  adrp     x10, #0x8ebf000
005ABA8A0  ldr      x8, [x22]
005ABA8A4  ldr      x10, [x10, #0x4e8]
005ABA8A8  ldrh     w9, [x8, #0x12e]
005ABA8AC  ldr      x1, [x10]
005ABA8B0  cbz      x9, #0x5aba8d4
005ABA8B4  ldr      x10, [x8, #0xb0]
005ABA8B8  add      x10, x10, #8
005ABA8BC  ldur     x11, [x10, #-8]
005ABA8C0  cmp      x11, x1
005ABA8C4  b.eq     #0x5aba8e4
005ABA8C8  subs     x9, x9, #1
005ABA8CC  add      x10, x10, #0x10
005ABA8D0  b.ne     #0x5aba8bc
005ABA8D4  mov      x0, x22
005ABA8D8  mov      w2, wzr
005ABA8DC  bl       #0x3a7e710 ; 
005ABA8E0  b        #0x5aba8f0 ; 
005ABA8E4  ldrsw    x9, [x10]
005ABA8E8  add      x8, x8, x9, lsl #4
005ABA8EC  add      x0, x8, #0x138
005ABA8F0  ldp      x8, x1, [x0]
005ABA8F4  mov      x0, x22
005ABA8F8  blr      x8
005ABA8FC  mov      x0, x21
005ABA900  mov      x1, xzr
005ABA904  str      xzr, [x20, #0x38]
005ABA908  bl       #0x382bcb8 ; 
005ABA90C  ldr      x8, [x19, #0x20]
005ABA910  mov      x0, x20
005ABA914  ldp      x20, x19, [sp, #0x20]
005ABA918  ldp      x22, x21, [sp, #0x10]
005ABA91C  ldr      x8, [x8, #0xc0]
005ABA920  ldr      x1, [x8, #0x48]
005ABA924  ldr      x30, [sp], #0x30
005ABA928  b        #0x4a72fbc ; System.Linq.Enumerable.Iterator<bool>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, bool>$$MoveNext
; RVA 0x5ABA92C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABA92C  sub      sp, sp, #0xf0
005ABA930  str      x30, [sp, #0xc0]
005ABA934  stp      x22, x21, [sp, #0xd0]
005ABA938  stp      x20, x19, [sp, #0xe0]
005ABA93C  adrp     x21, #0x9595000
005ABA940  ldrb     w8, [x21, #0x448]
005ABA944  mov      x20, x1
005ABA948  mov      x19, x0
005ABA94C  tbnz     w8, #0, #0x5aba964
005ABA950  adrp     x0, #0x8ebf000
005ABA954  ldr      x0, [x0, #0x4f0]
005ABA958  bl       #0x382bd14 ; 
005ABA95C  mov      w8, #1
005ABA960  strb     w8, [x21, #0x448]
005ABA964  ldr      w8, [x19, #0x14]
005ABA968  adrp     x22, #0x8ebf000
005ABA96C  ldr      x22, [x22, #0x4f0]
005ABA970  cmp      w8, #2
005ABA974  b.eq     #0x5abaa18
005ABA978  cmp      w8, #1
005ABA97C  b.ne     #0x5ababbc
005ABA980  ldr      x21, [x19, #0x20]
005ABA984  cbz      x21, #0x5ababd4
005ABA988  ldr      x8, [x20, #0x20]
005ABA98C  ldr      x8, [x8, #0xc0]
005ABA990  ldr      x1, [x8, #0x10]
005ABA994  ldrb     w8, [x1, #0x135]
005ABA998  tbnz     w8, #0, #0x5aba9a8
005ABA99C  mov      x0, x1
005ABA9A0  bl       #0x3a7e60c ; 
005ABA9A4  mov      x1, x0
005ABA9A8  ldr      x8, [x21]
005ABA9AC  ldrh     w9, [x8, #0x12e]
005ABA9B0  cbz      x9, #0x5aba9d4
005ABA9B4  ldr      x10, [x8, #0xb0]
005ABA9B8  add      x10, x10, #8
005ABA9BC  ldur     x11, [x10, #-8]
005ABA9C0  cmp      x11, x1
005ABA9C4  b.eq     #0x5aba9e4
005ABA9C8  subs     x9, x9, #1
005ABA9CC  add      x10, x10, #0x10
005ABA9D0  b.ne     #0x5aba9bc
005ABA9D4  mov      x0, x21
005ABA9D8  mov      w2, wzr
005ABA9DC  bl       #0x3a7e710 ; 
005ABA9E0  b        #0x5aba9f0 ; 
005ABA9E4  ldrsw    x9, [x10]
005ABA9E8  add      x8, x8, x9, lsl #4
005ABA9EC  add      x0, x8, #0x138
005ABA9F0  ldp      x8, x1, [x0]
005ABA9F4  mov      x0, x21
005ABA9F8  blr      x8
005ABA9FC  mov      x21, x19
005ABAA00  str      x0, [x21, #0x38]!
005ABAA04  mov      x1, x0
005ABAA08  mov      x0, x21
005ABAA0C  bl       #0x382bcb8 ; 
005ABAA10  mov      w8, #2
005ABAA14  stur     w8, [x21, #-0x24]
005ABAA18  ldr      x21, [x19, #0x38]
005ABAA1C  cbz      x21, #0x5ababd4
005ABAA20  ldr      x8, [x21]
005ABAA24  ldr      x1, [x22]
005ABAA28  ldrh     w9, [x8, #0x12e]
005ABAA2C  cbz      x9, #0x5abaa50
005ABAA30  ldr      x10, [x8, #0xb0]
005ABAA34  add      x10, x10, #8
005ABAA38  ldur     x11, [x10, #-8]
005ABAA3C  cmp      x11, x1
005ABAA40  b.eq     #0x5abaa60
005ABAA44  subs     x9, x9, #1
005ABAA48  add      x10, x10, #0x10
005ABAA4C  b.ne     #0x5abaa38
005ABAA50  mov      x0, x21
005ABAA54  mov      w2, wzr
005ABAA58  bl       #0x3a7e710 ; 
005ABAA5C  b        #0x5abaa6c ; 
005ABAA60  ldrsw    x9, [x10]
005ABAA64  add      x8, x8, x9, lsl #4
005ABAA68  add      x0, x8, #0x138
005ABAA6C  ldp      x8, x1, [x0]
005ABAA70  mov      x0, x21
005ABAA74  blr      x8
005ABAA78  tbz      w0, #0, #0x5ababa8
005ABAA7C  ldr      x21, [x19, #0x38]
005ABAA80  cbz      x21, #0x5ababd4
005ABAA84  ldr      x8, [x20, #0x20]
005ABAA88  ldr      x8, [x8, #0xc0]
005ABAA8C  ldr      x1, [x8, #0x40]
005ABAA90  ldrb     w8, [x1, #0x135]
005ABAA94  tbnz     w8, #0, #0x5abaaa4
005ABAA98  mov      x0, x1
005ABAA9C  bl       #0x3a7e60c ; 
005ABAAA0  mov      x1, x0
005ABAAA4  ldr      x8, [x21]
005ABAAA8  ldrh     w9, [x8, #0x12e]
005ABAAAC  cbz      x9, #0x5abaad0
005ABAAB0  ldr      x10, [x8, #0xb0]
005ABAAB4  add      x10, x10, #8
005ABAAB8  ldur     x11, [x10, #-8]
005ABAABC  cmp      x11, x1
005ABAAC0  b.eq     #0x5abaae0
005ABAAC4  subs     x9, x9, #1
005ABAAC8  add      x10, x10, #0x10
005ABAACC  b.ne     #0x5abaab8
005ABAAD0  mov      x0, x21
005ABAAD4  mov      w2, wzr
005ABAAD8  bl       #0x3a7e710 ; 
005ABAADC  b        #0x5abaaec ; 
005ABAAE0  ldrsw    x9, [x10]
005ABAAE4  add      x8, x8, x9, lsl #4
005ABAAE8  add      x0, x8, #0x138
005ABAAEC  ldp      x9, x1, [x0]
005ABAAF0  add      x8, sp, #0x80
005ABAAF4  mov      x0, x21
005ABAAF8  blr      x9
005ABAAFC  ldp      q0, q1, [sp, #0x80]
005ABAB00  ldr      q2, [sp, #0xa0]
005ABAB04  ldr      x8, [sp, #0xb0]
005ABAB08  stp      q0, q1, [sp, #0x40]
005ABAB0C  str      q2, [sp, #0x60]
005ABAB10  str      x8, [sp, #0x70]
005ABAB14  ldr      x8, [x19, #0x28]
005ABAB18  cbz      x8, #0x5abab4c
005ABAB1C  ldp      q0, q1, [sp, #0x40]
005ABAB20  ldr      q2, [sp, #0x60]
005ABAB24  ldr      x10, [sp, #0x70]
005ABAB28  ldr      x9, [x8, #0x18]
005ABAB2C  ldr      x0, [x8, #0x40]
005ABAB30  stp      q0, q1, [sp, #0x80]
005ABAB34  str      q2, [sp, #0xa0]
005ABAB38  str      x10, [sp, #0xb0]
005ABAB3C  ldr      x2, [x8, #0x28]
005ABAB40  add      x1, sp, #0x80
005ABAB44  blr      x9
005ABAB48  tbz      w0, #0, #0x5abaa18
005ABAB4C  ldr      x8, [x19, #0x30]
005ABAB50  ldp      q0, q1, [sp, #0x40]
005ABAB54  ldr      q2, [sp, #0x60]
005ABAB58  ldr      x9, [sp, #0x70]
005ABAB5C  stp      q0, q1, [sp]
005ABAB60  str      q2, [sp, #0x20]
005ABAB64  str      x9, [sp, #0x30]
005ABAB68  cbz      x8, #0x5ababd4
005ABAB6C  ldp      q0, q1, [sp]
005ABAB70  ldr      q2, [sp, #0x20]
005ABAB74  ldr      x10, [sp, #0x30]
005ABAB78  ldr      x9, [x8, #0x18]
005ABAB7C  ldr      x0, [x8, #0x40]
005ABAB80  stp      q0, q1, [sp, #0x80]
005ABAB84  str      q2, [sp, #0xa0]
005ABAB88  str      x10, [sp, #0xb0]
005ABAB8C  ldr      x2, [x8, #0x28]
005ABAB90  add      x1, sp, #0x80
005ABAB94  blr      x9
005ABAB98  and      w8, w0, #1
005ABAB9C  strb     w8, [x19, #0x18]
005ABABA0  mov      w0, #1
005ABABA4  b        #0x5ababc0 ; 
005ABABA8  cbz      x19, #0x5ababd4
005ABABAC  ldr      x8, [x19]
005ABABB0  mov      x0, x19
005ABABB4  ldp      x9, x1, [x8, #0x1f8]
005ABABB8  blr      x9
005ABABBC  mov      w0, wzr
005ABABC0  ldp      x20, x19, [sp, #0xe0]
005ABABC4  ldp      x22, x21, [sp, #0xd0]
005ABABC8  ldr      x30, [sp, #0xc0]
005ABABCC  add      sp, sp, #0xf0
005ABABD0  ret      
005ABABD4  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, bool>$$Where
; RVA 0x5ABABD8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABABD8  stp      x30, x21, [sp, #-0x20]!
005ABABDC  stp      x20, x19, [sp, #0x10]
005ABABE0  ldr      x8, [x2, #0x20]
005ABABE4  mov      x20, x2
005ABABE8  mov      x19, x1
005ABABEC  mov      x21, x0
005ABABF0  ldr      x8, [x8, #0xc0]
005ABABF4  ldr      x8, [x8, #0x88]
005ABABF8  ldrb     w9, [x8, #0x135]
005ABABFC  tbnz     w9, #0, #0x5abac0c
005ABAC00  mov      x0, x8
005ABAC04  bl       #0x3a7e60c ; 
005ABAC08  mov      x8, x0
005ABAC0C  mov      x0, x8
005ABAC10  bl       #0x382bfa0 ; 
005ABAC14  ldr      x8, [x20, #0x20]
005ABAC18  mov      x1, x21
005ABAC1C  mov      x2, x19
005ABAC20  mov      x20, x0
005ABAC24  ldr      x8, [x8, #0xc0]
005ABAC28  ldr      x3, [x8, #0x90]
005ABAC2C  bl       #0x59c53fc ; System.Linq.Enumerable.WhereEnumerableIterator<bool>$$.ctor
005ABAC30  mov      x0, x20
005ABAC34  ldp      x20, x19, [sp, #0x10]
005ABAC38  ldp      x30, x21, [sp], #0x20
005ABAC3C  ret      

