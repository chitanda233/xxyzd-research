; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, bool>$$.ctor
; RVA 0x5B04FBC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B04FBC  str      x30, [sp, #-0x30]!
005B04FC0  stp      x22, x21, [sp, #0x10]
005B04FC4  stp      x20, x19, [sp, #0x20]
005B04FC8  ldr      x8, [x4, #0x20]
005B04FCC  mov      x21, x1
005B04FD0  mov      x19, x3
005B04FD4  mov      x20, x2
005B04FD8  ldr      x8, [x8, #0xc0]
005B04FDC  mov      x22, x0
005B04FE0  ldr      x1, [x8]
005B04FE4  bl       #0x4a72f80 ; System.Linq.Enumerable.Iterator<bool>$$.ctor
005B04FE8  mov      x0, x22
005B04FEC  str      x21, [x0, #0x20]!
005B04FF0  mov      x1, x21
005B04FF4  bl       #0x382bcb8 ; 
005B04FF8  mov      x0, x22
005B04FFC  str      x20, [x0, #0x28]!
005B05000  mov      x1, x20
005B05004  bl       #0x382bcb8 ; 
005B05008  str      x19, [x22, #0x30]!
005B0500C  mov      x0, x22
005B05010  mov      x1, x19
005B05014  ldp      x20, x19, [sp, #0x20]
005B05018  ldp      x22, x21, [sp, #0x10]
005B0501C  ldr      x30, [sp], #0x30
005B05020  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, bool>$$Clone
; RVA 0x5B05024; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05024  str      x30, [sp, #-0x30]!
005B05028  stp      x22, x21, [sp, #0x10]
005B0502C  stp      x20, x19, [sp, #0x20]
005B05030  ldr      x9, [x1, #0x20]
005B05034  mov      x8, x0
005B05038  ldp      x21, x20, [x8, #0x20]
005B0503C  ldr      x22, [x8, #0x30]
005B05040  ldr      x9, [x9, #0xc0]
005B05044  mov      x19, x1
005B05048  ldr      x0, [x9, #0x18]
005B0504C  ldrb     w9, [x0, #0x135]
005B05050  tbnz     w9, #0, #0x5b05058
005B05054  bl       #0x3a7e60c ; 
005B05058  bl       #0x382bfa0 ; 
005B0505C  ldr      x8, [x19, #0x20]
005B05060  mov      x1, x21
005B05064  mov      x2, x20
005B05068  mov      x3, x22
005B0506C  ldr      x8, [x8, #0xc0]
005B05070  mov      x19, x0
005B05074  ldr      x4, [x8, #0x30]
005B05078  bl       #0x5b04fbc ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, bool>$$.ctor
005B0507C  mov      x0, x19
005B05080  ldp      x20, x19, [sp, #0x20]
005B05084  ldp      x22, x21, [sp, #0x10]
005B05088  ldr      x30, [sp], #0x30
005B0508C  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, bool>$$MoveNext
; RVA 0x5B05090; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05090  sub      sp, sp, #0x110
005B05094  stp      x29, x30, [sp, #0xe0]
005B05098  stp      x22, x21, [sp, #0xf0]
005B0509C  stp      x20, x19, [sp, #0x100]
005B050A0  ldr      w8, [x0, #0x14]
005B050A4  mov      x19, x0
005B050A8  mov      x20, x1
005B050AC  cmp      w8, #2
005B050B0  b.eq     #0x5b05110
005B050B4  cmp      w8, #1
005B050B8  b.ne     #0x5b051ec
005B050BC  ldr      x0, [x19, #0x20]
005B050C0  cbz      x0, #0x5b05204
005B050C4  ldr      x8, [x20, #0x20]
005B050C8  ldr      x8, [x8, #0xc0]
005B050CC  ldr      x1, [x8, #0x40]
005B050D0  add      x8, sp, #0x40
005B050D4  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B050D8  add      x0, sp, #0x90
005B050DC  add      x1, sp, #0x40
005B050E0  mov      w2, #0x48
005B050E4  bl       #0x89edad0 ; 
005B050E8  add      x21, x19, #0x38
005B050EC  add      x1, sp, #0x90
005B050F0  mov      w2, #0x48
005B050F4  mov      x0, x21
005B050F8  bl       #0x89edad0 ; 
005B050FC  mov      x0, x21
005B05100  mov      x1, xzr
005B05104  bl       #0x382bcb8 ; 
005B05108  mov      w8, #2
005B0510C  str      w8, [x19, #0x14]
005B05110  add      x21, x19, #0x38
005B05114  add      x22, x19, #0x48
005B05118  ldr      x8, [x20, #0x20]
005B0511C  mov      x0, x21
005B05120  ldr      x8, [x8, #0xc0]
005B05124  ldr      x1, [x8, #0x80]
005B05128  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B0512C  tbz      w0, #0, #0x5b051dc
005B05130  ldr      x8, [x22, #0x30]
005B05134  ldp      q1, q0, [x22, #0x10]
005B05138  ldr      q2, [x22]
005B0513C  str      x8, [sp, #0x70]
005B05140  stp      q1, q0, [sp, #0x50]
005B05144  str      q2, [sp, #0x40]
005B05148  ldr      x8, [x19, #0x28]
005B0514C  cbz      x8, #0x5b05180
005B05150  ldp      q0, q1, [sp, #0x40]
005B05154  ldr      q2, [sp, #0x60]
005B05158  ldr      x10, [sp, #0x70]
005B0515C  ldr      x9, [x8, #0x18]
005B05160  ldr      x0, [x8, #0x40]
005B05164  stp      q0, q1, [sp, #0x90]
005B05168  str      q2, [sp, #0xb0]
005B0516C  str      x10, [sp, #0xc0]
005B05170  ldr      x2, [x8, #0x28]
005B05174  add      x1, sp, #0x90
005B05178  blr      x9
005B0517C  tbz      w0, #0, #0x5b05118
005B05180  ldr      x8, [x19, #0x30]
005B05184  ldp      q0, q1, [sp, #0x40]
005B05188  ldr      q2, [sp, #0x60]
005B0518C  ldr      x9, [sp, #0x70]
005B05190  stp      q0, q1, [sp]
005B05194  str      q2, [sp, #0x20]
005B05198  str      x9, [sp, #0x30]
005B0519C  cbz      x8, #0x5b05204
005B051A0  ldp      q0, q1, [sp]
005B051A4  ldr      q2, [sp, #0x20]
005B051A8  ldr      x10, [sp, #0x30]
005B051AC  ldr      x9, [x8, #0x18]
005B051B0  ldr      x0, [x8, #0x40]
005B051B4  stp      q0, q1, [sp, #0x90]
005B051B8  str      q2, [sp, #0xb0]
005B051BC  str      x10, [sp, #0xc0]
005B051C0  ldr      x2, [x8, #0x28]
005B051C4  add      x1, sp, #0x90
005B051C8  blr      x9
005B051CC  and      w8, w0, #1
005B051D0  strb     w8, [x19, #0x18]
005B051D4  mov      w0, #1
005B051D8  b        #0x5b051f0 ; 
005B051DC  ldr      x8, [x19]
005B051E0  mov      x0, x19
005B051E4  ldp      x9, x1, [x8, #0x1f8]
005B051E8  blr      x9
005B051EC  mov      w0, wzr
005B051F0  ldp      x20, x19, [sp, #0x100]
005B051F4  ldp      x22, x21, [sp, #0xf0]
005B051F8  ldp      x29, x30, [sp, #0xe0]
005B051FC  add      sp, sp, #0x110
005B05200  ret      
005B05204  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, bool>$$Where
; RVA 0x5B05208; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B05208  stp      x30, x21, [sp, #-0x20]!
005B0520C  stp      x20, x19, [sp, #0x10]
005B05210  ldr      x8, [x2, #0x20]
005B05214  mov      x20, x2
005B05218  mov      x19, x1
005B0521C  mov      x21, x0
005B05220  ldr      x8, [x8, #0xc0]
005B05224  ldr      x8, [x8, #0x98]
005B05228  ldrb     w9, [x8, #0x135]
005B0522C  tbnz     w9, #0, #0x5b0523c
005B05230  mov      x0, x8
005B05234  bl       #0x3a7e60c ; 
005B05238  mov      x8, x0
005B0523C  mov      x0, x8
005B05240  bl       #0x382bfa0 ; 
005B05244  ldr      x8, [x20, #0x20]
005B05248  mov      x1, x21
005B0524C  mov      x2, x19
005B05250  mov      x20, x0
005B05254  ldr      x8, [x8, #0xc0]
005B05258  ldr      x3, [x8, #0xa0]
005B0525C  bl       #0x59c53fc ; System.Linq.Enumerable.WhereEnumerableIterator<bool>$$.ctor
005B05260  mov      x0, x20
005B05264  ldp      x20, x19, [sp, #0x10]
005B05268  ldp      x30, x21, [sp], #0x20
005B0526C  ret      

