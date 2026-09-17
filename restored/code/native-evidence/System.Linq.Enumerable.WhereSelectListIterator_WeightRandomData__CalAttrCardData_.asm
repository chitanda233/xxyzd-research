; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrCardData>$$.ctor
; RVA 0x5B05270; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05270  str      x30, [sp, #-0x30]!
005B05274  stp      x22, x21, [sp, #0x10]
005B05278  stp      x20, x19, [sp, #0x20]
005B0527C  ldr      x8, [x4, #0x20]
005B05280  mov      x21, x1
005B05284  mov      x19, x3
005B05288  mov      x20, x2
005B0528C  ldr      x8, [x8, #0xc0]
005B05290  mov      x22, x0
005B05294  ldr      x1, [x8]
005B05298  bl       #0x4a732ec ; System.Linq.Enumerable.Iterator<CalAttrCardData>$$.ctor
005B0529C  mov      x0, x22
005B052A0  str      x21, [x0, #0x20]!
005B052A4  mov      x1, x21
005B052A8  bl       #0x382bcb8 ; 
005B052AC  mov      x0, x22
005B052B0  str      x20, [x0, #0x28]!
005B052B4  mov      x1, x20
005B052B8  bl       #0x382bcb8 ; 
005B052BC  str      x19, [x22, #0x30]!
005B052C0  mov      x0, x22
005B052C4  mov      x1, x19
005B052C8  ldp      x20, x19, [sp, #0x20]
005B052CC  ldp      x22, x21, [sp, #0x10]
005B052D0  ldr      x30, [sp], #0x30
005B052D4  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrCardData>$$Clone
; RVA 0x5B052D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B052D8  str      x30, [sp, #-0x30]!
005B052DC  stp      x22, x21, [sp, #0x10]
005B052E0  stp      x20, x19, [sp, #0x20]
005B052E4  ldr      x9, [x1, #0x20]
005B052E8  mov      x8, x0
005B052EC  ldp      x21, x20, [x8, #0x20]
005B052F0  ldr      x22, [x8, #0x30]
005B052F4  ldr      x9, [x9, #0xc0]
005B052F8  mov      x19, x1
005B052FC  ldr      x0, [x9, #0x18]
005B05300  ldrb     w9, [x0, #0x135]
005B05304  tbnz     w9, #0, #0x5b0530c
005B05308  bl       #0x3a7e60c ; 
005B0530C  bl       #0x382bfa0 ; 
005B05310  ldr      x8, [x19, #0x20]
005B05314  mov      x1, x21
005B05318  mov      x2, x20
005B0531C  mov      x3, x22
005B05320  ldr      x8, [x8, #0xc0]
005B05324  mov      x19, x0
005B05328  ldr      x4, [x8, #0x30]
005B0532C  bl       #0x5b05270 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrCardData>$$.ctor
005B05330  mov      x0, x19
005B05334  ldp      x20, x19, [sp, #0x20]
005B05338  ldp      x22, x21, [sp, #0x10]
005B0533C  ldr      x30, [sp], #0x30
005B05340  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrCardData>$$MoveNext
; RVA 0x5B05344; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05344  sub      sp, sp, #0x110
005B05348  stp      x29, x30, [sp, #0xe0]
005B0534C  stp      x22, x21, [sp, #0xf0]
005B05350  stp      x20, x19, [sp, #0x100]
005B05354  ldr      w8, [x0, #0x14]
005B05358  mov      x19, x0
005B0535C  mov      x20, x1
005B05360  cmp      w8, #2
005B05364  b.eq     #0x5b053c4
005B05368  cmp      w8, #1
005B0536C  b.ne     #0x5b0549c
005B05370  ldr      x0, [x19, #0x20]
005B05374  cbz      x0, #0x5b054b4
005B05378  ldr      x8, [x20, #0x20]
005B0537C  ldr      x8, [x8, #0xc0]
005B05380  ldr      x1, [x8, #0x40]
005B05384  add      x8, sp, #0x40
005B05388  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B0538C  add      x0, sp, #0x90
005B05390  add      x1, sp, #0x40
005B05394  mov      w2, #0x48
005B05398  bl       #0x89edad0 ; 
005B0539C  add      x21, x19, #0x38
005B053A0  add      x1, sp, #0x90
005B053A4  mov      w2, #0x48
005B053A8  mov      x0, x21
005B053AC  bl       #0x89edad0 ; 
005B053B0  mov      x0, x21
005B053B4  mov      x1, xzr
005B053B8  bl       #0x382bcb8 ; 
005B053BC  mov      w8, #2
005B053C0  str      w8, [x19, #0x14]
005B053C4  add      x21, x19, #0x38
005B053C8  add      x22, x19, #0x48
005B053CC  ldr      x8, [x20, #0x20]
005B053D0  mov      x0, x21
005B053D4  ldr      x8, [x8, #0xc0]
005B053D8  ldr      x1, [x8, #0x80]
005B053DC  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B053E0  tbz      w0, #0, #0x5b0548c
005B053E4  ldr      x8, [x22, #0x30]
005B053E8  ldp      q1, q0, [x22, #0x10]
005B053EC  ldr      q2, [x22]
005B053F0  str      x8, [sp, #0x70]
005B053F4  stp      q1, q0, [sp, #0x50]
005B053F8  str      q2, [sp, #0x40]
005B053FC  ldr      x8, [x19, #0x28]
005B05400  cbz      x8, #0x5b05434
005B05404  ldp      q0, q1, [sp, #0x40]
005B05408  ldr      q2, [sp, #0x60]
005B0540C  ldr      x10, [sp, #0x70]
005B05410  ldr      x9, [x8, #0x18]
005B05414  ldr      x0, [x8, #0x40]
005B05418  stp      q0, q1, [sp, #0x90]
005B0541C  str      q2, [sp, #0xb0]
005B05420  str      x10, [sp, #0xc0]
005B05424  ldr      x2, [x8, #0x28]
005B05428  add      x1, sp, #0x90
005B0542C  blr      x9
005B05430  tbz      w0, #0, #0x5b053cc
005B05434  ldr      x8, [x19, #0x30]
005B05438  ldp      q0, q1, [sp, #0x40]
005B0543C  ldr      q2, [sp, #0x60]
005B05440  ldr      x9, [sp, #0x70]
005B05444  stp      q0, q1, [sp]
005B05448  str      q2, [sp, #0x20]
005B0544C  str      x9, [sp, #0x30]
005B05450  cbz      x8, #0x5b054b4
005B05454  ldp      q0, q1, [sp]
005B05458  ldr      q2, [sp, #0x20]
005B0545C  ldr      x10, [sp, #0x30]
005B05460  ldr      x9, [x8, #0x18]
005B05464  ldr      x0, [x8, #0x40]
005B05468  stp      q0, q1, [sp, #0x90]
005B0546C  str      q2, [sp, #0xb0]
005B05470  str      x10, [sp, #0xc0]
005B05474  ldr      x2, [x8, #0x28]
005B05478  add      x1, sp, #0x90
005B0547C  blr      x9
005B05480  str      x0, [x19, #0x18]
005B05484  mov      w0, #1
005B05488  b        #0x5b054a0 ; 
005B0548C  ldr      x8, [x19]
005B05490  mov      x0, x19
005B05494  ldp      x9, x1, [x8, #0x1f8]
005B05498  blr      x9
005B0549C  mov      w0, wzr
005B054A0  ldp      x20, x19, [sp, #0x100]
005B054A4  ldp      x22, x21, [sp, #0xf0]
005B054A8  ldp      x29, x30, [sp, #0xe0]
005B054AC  add      sp, sp, #0x110
005B054B0  ret      
005B054B4  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalAttrCardData>$$Where
; RVA 0x5B054B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B054B8  stp      x30, x21, [sp, #-0x20]!
005B054BC  stp      x20, x19, [sp, #0x10]
005B054C0  ldr      x8, [x2, #0x20]
005B054C4  mov      x20, x2
005B054C8  mov      x19, x1
005B054CC  mov      x21, x0
005B054D0  ldr      x8, [x8, #0xc0]
005B054D4  ldr      x8, [x8, #0x98]
005B054D8  ldrb     w9, [x8, #0x135]
005B054DC  tbnz     w9, #0, #0x5b054ec
005B054E0  mov      x0, x8
005B054E4  bl       #0x3a7e60c ; 
005B054E8  mov      x8, x0
005B054EC  mov      x0, x8
005B054F0  bl       #0x382bfa0 ; 
005B054F4  ldr      x8, [x20, #0x20]
005B054F8  mov      x1, x21
005B054FC  mov      x2, x19
005B05500  mov      x20, x0
005B05504  ldr      x8, [x8, #0xc0]
005B05508  ldr      x3, [x8, #0xa0]
005B0550C  bl       #0x59c6084 ; System.Linq.Enumerable.WhereEnumerableIterator<CalAttrCardData>$$.ctor
005B05510  mov      x0, x20
005B05514  ldp      x20, x19, [sp, #0x10]
005B05518  ldp      x30, x21, [sp], #0x20
005B0551C  ret      

