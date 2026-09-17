; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRuneData>$$.ctor
; RVA 0x5B06008; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06008  str      x30, [sp, #-0x30]!
005B0600C  stp      x22, x21, [sp, #0x10]
005B06010  stp      x20, x19, [sp, #0x20]
005B06014  ldr      x8, [x4, #0x20]
005B06018  mov      x21, x1
005B0601C  mov      x19, x3
005B06020  mov      x20, x2
005B06024  ldr      x8, [x8, #0xc0]
005B06028  mov      x22, x0
005B0602C  ldr      x1, [x8]
005B06030  bl       #0x4a73ac4 ; System.Linq.Enumerable.Iterator<CalRuneData>$$.ctor
005B06034  mov      x0, x22
005B06038  str      x21, [x0, #0x20]!
005B0603C  mov      x1, x21
005B06040  bl       #0x382bcb8 ; 
005B06044  mov      x0, x22
005B06048  str      x20, [x0, #0x28]!
005B0604C  mov      x1, x20
005B06050  bl       #0x382bcb8 ; 
005B06054  str      x19, [x22, #0x30]!
005B06058  mov      x0, x22
005B0605C  mov      x1, x19
005B06060  ldp      x20, x19, [sp, #0x20]
005B06064  ldp      x22, x21, [sp, #0x10]
005B06068  ldr      x30, [sp], #0x30
005B0606C  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRuneData>$$Clone
; RVA 0x5B06070; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06070  str      x30, [sp, #-0x30]!
005B06074  stp      x22, x21, [sp, #0x10]
005B06078  stp      x20, x19, [sp, #0x20]
005B0607C  ldr      x9, [x1, #0x20]
005B06080  mov      x8, x0
005B06084  ldp      x21, x20, [x8, #0x20]
005B06088  ldr      x22, [x8, #0x30]
005B0608C  ldr      x9, [x9, #0xc0]
005B06090  mov      x19, x1
005B06094  ldr      x0, [x9, #0x18]
005B06098  ldrb     w9, [x0, #0x135]
005B0609C  tbnz     w9, #0, #0x5b060a4
005B060A0  bl       #0x3a7e60c ; 
005B060A4  bl       #0x382bfa0 ; 
005B060A8  ldr      x8, [x19, #0x20]
005B060AC  mov      x1, x21
005B060B0  mov      x2, x20
005B060B4  mov      x3, x22
005B060B8  ldr      x8, [x8, #0xc0]
005B060BC  mov      x19, x0
005B060C0  ldr      x4, [x8, #0x30]
005B060C4  bl       #0x5b06008 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRuneData>$$.ctor
005B060C8  mov      x0, x19
005B060CC  ldp      x20, x19, [sp, #0x20]
005B060D0  ldp      x22, x21, [sp, #0x10]
005B060D4  ldr      x30, [sp], #0x30
005B060D8  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRuneData>$$MoveNext
; RVA 0x5B060DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B060DC  sub      sp, sp, #0x110
005B060E0  stp      x29, x30, [sp, #0xe0]
005B060E4  stp      x22, x21, [sp, #0xf0]
005B060E8  stp      x20, x19, [sp, #0x100]
005B060EC  ldr      w8, [x0, #0x14]
005B060F0  mov      x19, x0
005B060F4  mov      x20, x1
005B060F8  cmp      w8, #2
005B060FC  b.eq     #0x5b0615c
005B06100  cmp      w8, #1
005B06104  b.ne     #0x5b06234
005B06108  ldr      x0, [x19, #0x20]
005B0610C  cbz      x0, #0x5b0624c
005B06110  ldr      x8, [x20, #0x20]
005B06114  ldr      x8, [x8, #0xc0]
005B06118  ldr      x1, [x8, #0x40]
005B0611C  add      x8, sp, #0x40
005B06120  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B06124  add      x0, sp, #0x90
005B06128  add      x1, sp, #0x40
005B0612C  mov      w2, #0x48
005B06130  bl       #0x89edad0 ; 
005B06134  add      x21, x19, #0x38
005B06138  add      x1, sp, #0x90
005B0613C  mov      w2, #0x48
005B06140  mov      x0, x21
005B06144  bl       #0x89edad0 ; 
005B06148  mov      x0, x21
005B0614C  mov      x1, xzr
005B06150  bl       #0x382bcb8 ; 
005B06154  mov      w8, #2
005B06158  str      w8, [x19, #0x14]
005B0615C  add      x21, x19, #0x38
005B06160  add      x22, x19, #0x48
005B06164  ldr      x8, [x20, #0x20]
005B06168  mov      x0, x21
005B0616C  ldr      x8, [x8, #0xc0]
005B06170  ldr      x1, [x8, #0x80]
005B06174  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B06178  tbz      w0, #0, #0x5b06224
005B0617C  ldr      x8, [x22, #0x30]
005B06180  ldp      q1, q0, [x22, #0x10]
005B06184  ldr      q2, [x22]
005B06188  str      x8, [sp, #0x70]
005B0618C  stp      q1, q0, [sp, #0x50]
005B06190  str      q2, [sp, #0x40]
005B06194  ldr      x8, [x19, #0x28]
005B06198  cbz      x8, #0x5b061cc
005B0619C  ldp      q0, q1, [sp, #0x40]
005B061A0  ldr      q2, [sp, #0x60]
005B061A4  ldr      x10, [sp, #0x70]
005B061A8  ldr      x9, [x8, #0x18]
005B061AC  ldr      x0, [x8, #0x40]
005B061B0  stp      q0, q1, [sp, #0x90]
005B061B4  str      q2, [sp, #0xb0]
005B061B8  str      x10, [sp, #0xc0]
005B061BC  ldr      x2, [x8, #0x28]
005B061C0  add      x1, sp, #0x90
005B061C4  blr      x9
005B061C8  tbz      w0, #0, #0x5b06164
005B061CC  ldr      x8, [x19, #0x30]
005B061D0  ldp      q0, q1, [sp, #0x40]
005B061D4  ldr      q2, [sp, #0x60]
005B061D8  ldr      x9, [sp, #0x70]
005B061DC  stp      q0, q1, [sp]
005B061E0  str      q2, [sp, #0x20]
005B061E4  str      x9, [sp, #0x30]
005B061E8  cbz      x8, #0x5b0624c
005B061EC  ldp      q0, q1, [sp]
005B061F0  ldr      q2, [sp, #0x20]
005B061F4  ldr      x10, [sp, #0x30]
005B061F8  ldr      x9, [x8, #0x18]
005B061FC  ldr      x0, [x8, #0x40]
005B06200  stp      q0, q1, [sp, #0x90]
005B06204  str      q2, [sp, #0xb0]
005B06208  str      x10, [sp, #0xc0]
005B0620C  ldr      x2, [x8, #0x28]
005B06210  add      x1, sp, #0x90
005B06214  blr      x9
005B06218  str      w0, [x19, #0x18]
005B0621C  mov      w0, #1
005B06220  b        #0x5b06238 ; 
005B06224  ldr      x8, [x19]
005B06228  mov      x0, x19
005B0622C  ldp      x9, x1, [x8, #0x1f8]
005B06230  blr      x9
005B06234  mov      w0, wzr
005B06238  ldp      x20, x19, [sp, #0x100]
005B0623C  ldp      x22, x21, [sp, #0xf0]
005B06240  ldp      x29, x30, [sp, #0xe0]
005B06244  add      sp, sp, #0x110
005B06248  ret      
005B0624C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, CalRuneData>$$Where
; RVA 0x5B06250; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06250  stp      x30, x21, [sp, #-0x20]!
005B06254  stp      x20, x19, [sp, #0x10]
005B06258  ldr      x8, [x2, #0x20]
005B0625C  mov      x20, x2
005B06260  mov      x19, x1
005B06264  mov      x21, x0
005B06268  ldr      x8, [x8, #0xc0]
005B0626C  ldr      x8, [x8, #0x98]
005B06270  ldrb     w9, [x8, #0x135]
005B06274  tbnz     w9, #0, #0x5b06284
005B06278  mov      x0, x8
005B0627C  bl       #0x3a7e60c ; 
005B06280  mov      x8, x0
005B06284  mov      x0, x8
005B06288  bl       #0x382bfa0 ; 
005B0628C  ldr      x8, [x20, #0x20]
005B06290  mov      x1, x21
005B06294  mov      x2, x19
005B06298  mov      x20, x0
005B0629C  ldr      x8, [x8, #0xc0]
005B062A0  ldr      x3, [x8, #0xa0]
005B062A4  bl       #0x59c7d64 ; System.Linq.Enumerable.WhereEnumerableIterator<CalRuneData>$$.ctor
005B062A8  mov      x0, x20
005B062AC  ldp      x20, x19, [sp, #0x10]
005B062B0  ldp      x30, x21, [sp], #0x20
005B062B4  ret      

