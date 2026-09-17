; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Vector3>$$.ctor
; RVA 0x5B07034; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B07034  str      x30, [sp, #-0x30]!
005B07038  stp      x22, x21, [sp, #0x10]
005B0703C  stp      x20, x19, [sp, #0x20]
005B07040  ldr      x8, [x4, #0x20]
005B07044  mov      x21, x1
005B07048  mov      x19, x3
005B0704C  mov      x20, x2
005B07050  ldr      x8, [x8, #0xc0]
005B07054  mov      x22, x0
005B07058  ldr      x1, [x8]
005B0705C  bl       #0x4a7519c ; System.Linq.Enumerable.Iterator<Vector3>$$.ctor
005B07060  mov      x0, x22
005B07064  str      x21, [x0, #0x28]!
005B07068  mov      x1, x21
005B0706C  bl       #0x382bcb8 ; 
005B07070  mov      x0, x22
005B07074  str      x20, [x0, #0x30]!
005B07078  mov      x1, x20
005B0707C  bl       #0x382bcb8 ; 
005B07080  str      x19, [x22, #0x38]!
005B07084  mov      x0, x22
005B07088  mov      x1, x19
005B0708C  ldp      x20, x19, [sp, #0x20]
005B07090  ldp      x22, x21, [sp, #0x10]
005B07094  ldr      x30, [sp], #0x30
005B07098  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Vector3>$$Clone
; RVA 0x5B0709C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B0709C  str      x30, [sp, #-0x30]!
005B070A0  stp      x22, x21, [sp, #0x10]
005B070A4  stp      x20, x19, [sp, #0x20]
005B070A8  ldr      x9, [x1, #0x20]
005B070AC  mov      x8, x0
005B070B0  ldp      x21, x20, [x8, #0x28]
005B070B4  ldr      x22, [x8, #0x38]
005B070B8  ldr      x9, [x9, #0xc0]
005B070BC  mov      x19, x1
005B070C0  ldr      x0, [x9, #0x18]
005B070C4  ldrb     w9, [x0, #0x135]
005B070C8  tbnz     w9, #0, #0x5b070d0
005B070CC  bl       #0x3a7e60c ; 
005B070D0  bl       #0x382bfa0 ; 
005B070D4  ldr      x8, [x19, #0x20]
005B070D8  mov      x1, x21
005B070DC  mov      x2, x20
005B070E0  mov      x3, x22
005B070E4  ldr      x8, [x8, #0xc0]
005B070E8  mov      x19, x0
005B070EC  ldr      x4, [x8, #0x30]
005B070F0  bl       #0x5b07034 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Vector3>$$.ctor
005B070F4  mov      x0, x19
005B070F8  ldp      x20, x19, [sp, #0x20]
005B070FC  ldp      x22, x21, [sp, #0x10]
005B07100  ldr      x30, [sp], #0x30
005B07104  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Vector3>$$MoveNext
; RVA 0x5B07108; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B07108  sub      sp, sp, #0x110
005B0710C  stp      x29, x30, [sp, #0xe0]
005B07110  stp      x22, x21, [sp, #0xf0]
005B07114  stp      x20, x19, [sp, #0x100]
005B07118  ldr      w8, [x0, #0x14]
005B0711C  mov      x19, x0
005B07120  mov      x20, x1
005B07124  cmp      w8, #2
005B07128  b.eq     #0x5b07188
005B0712C  cmp      w8, #1
005B07130  b.ne     #0x5b07264
005B07134  ldr      x0, [x19, #0x28]
005B07138  cbz      x0, #0x5b0727c
005B0713C  ldr      x8, [x20, #0x20]
005B07140  ldr      x8, [x8, #0xc0]
005B07144  ldr      x1, [x8, #0x40]
005B07148  add      x8, sp, #0x40
005B0714C  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B07150  add      x0, sp, #0x90
005B07154  add      x1, sp, #0x40
005B07158  mov      w2, #0x48
005B0715C  bl       #0x89edad0 ; 
005B07160  add      x21, x19, #0x40
005B07164  add      x1, sp, #0x90
005B07168  mov      w2, #0x48
005B0716C  mov      x0, x21
005B07170  bl       #0x89edad0 ; 
005B07174  mov      x0, x21
005B07178  mov      x1, xzr
005B0717C  bl       #0x382bcb8 ; 
005B07180  mov      w8, #2
005B07184  str      w8, [x19, #0x14]
005B07188  add      x21, x19, #0x40
005B0718C  add      x22, x19, #0x50
005B07190  ldr      x8, [x20, #0x20]
005B07194  mov      x0, x21
005B07198  ldr      x8, [x8, #0xc0]
005B0719C  ldr      x1, [x8, #0x80]
005B071A0  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B071A4  tbz      w0, #0, #0x5b07254
005B071A8  ldr      x8, [x22, #0x30]
005B071AC  ldp      q1, q0, [x22, #0x10]
005B071B0  ldr      q2, [x22]
005B071B4  str      x8, [sp, #0x70]
005B071B8  stp      q1, q0, [sp, #0x50]
005B071BC  str      q2, [sp, #0x40]
005B071C0  ldr      x8, [x19, #0x30]
005B071C4  cbz      x8, #0x5b071f8
005B071C8  ldp      q0, q1, [sp, #0x40]
005B071CC  ldr      q2, [sp, #0x60]
005B071D0  ldr      x10, [sp, #0x70]
005B071D4  ldr      x9, [x8, #0x18]
005B071D8  ldr      x0, [x8, #0x40]
005B071DC  stp      q0, q1, [sp, #0x90]
005B071E0  str      q2, [sp, #0xb0]
005B071E4  str      x10, [sp, #0xc0]
005B071E8  ldr      x2, [x8, #0x28]
005B071EC  add      x1, sp, #0x90
005B071F0  blr      x9
005B071F4  tbz      w0, #0, #0x5b07190
005B071F8  ldr      x8, [x19, #0x38]
005B071FC  ldp      q0, q1, [sp, #0x40]
005B07200  ldr      q2, [sp, #0x60]
005B07204  ldr      x9, [sp, #0x70]
005B07208  stp      q0, q1, [sp]
005B0720C  str      q2, [sp, #0x20]
005B07210  str      x9, [sp, #0x30]
005B07214  cbz      x8, #0x5b0727c
005B07218  ldp      q0, q1, [sp]
005B0721C  ldr      q2, [sp, #0x20]
005B07220  ldr      x10, [sp, #0x30]
005B07224  ldr      x9, [x8, #0x18]
005B07228  ldr      x0, [x8, #0x40]
005B0722C  stp      q0, q1, [sp, #0x90]
005B07230  str      q2, [sp, #0xb0]
005B07234  str      x10, [sp, #0xc0]
005B07238  ldr      x2, [x8, #0x28]
005B0723C  add      x1, sp, #0x90
005B07240  blr      x9
005B07244  stp      s0, s1, [x19, #0x18]
005B07248  str      s2, [x19, #0x20]
005B0724C  mov      w0, #1
005B07250  b        #0x5b07268 ; 
005B07254  ldr      x8, [x19]
005B07258  mov      x0, x19
005B0725C  ldp      x9, x1, [x8, #0x1f8]
005B07260  blr      x9
005B07264  mov      w0, wzr
005B07268  ldp      x20, x19, [sp, #0x100]
005B0726C  ldp      x22, x21, [sp, #0xf0]
005B07270  ldp      x29, x30, [sp, #0xe0]
005B07274  add      sp, sp, #0x110
005B07278  ret      
005B0727C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Vector3>$$Where
; RVA 0x5B07280; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B07280  stp      x30, x21, [sp, #-0x20]!
005B07284  stp      x20, x19, [sp, #0x10]
005B07288  ldr      x8, [x2, #0x20]
005B0728C  mov      x20, x2
005B07290  mov      x19, x1
005B07294  mov      x21, x0
005B07298  ldr      x8, [x8, #0xc0]
005B0729C  ldr      x8, [x8, #0x98]
005B072A0  ldrb     w9, [x8, #0x135]
005B072A4  tbnz     w9, #0, #0x5b072b4
005B072A8  mov      x0, x8
005B072AC  bl       #0x3a7e60c ; 
005B072B0  mov      x8, x0
005B072B4  mov      x0, x8
005B072B8  bl       #0x382bfa0 ; 
005B072BC  ldr      x8, [x20, #0x20]
005B072C0  mov      x1, x21
005B072C4  mov      x2, x19
005B072C8  mov      x20, x0
005B072CC  ldr      x8, [x8, #0xc0]
005B072D0  ldr      x3, [x8, #0xa0]
005B072D4  bl       #0x59cbf7c ; System.Linq.Enumerable.WhereEnumerableIterator<Vector3>$$.ctor
005B072D8  mov      x0, x20
005B072DC  ldp      x20, x19, [sp, #0x10]
005B072E0  ldp      x30, x21, [sp], #0x20
005B072E4  ret      

