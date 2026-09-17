; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, char>$$.ctor
; RVA 0x5B062B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B062B8  str      x30, [sp, #-0x30]!
005B062BC  stp      x22, x21, [sp, #0x10]
005B062C0  stp      x20, x19, [sp, #0x20]
005B062C4  ldr      x8, [x4, #0x20]
005B062C8  mov      x21, x1
005B062CC  mov      x19, x3
005B062D0  mov      x20, x2
005B062D4  ldr      x8, [x8, #0xc0]
005B062D8  mov      x22, x0
005B062DC  ldr      x1, [x8]
005B062E0  bl       #0x4a73bd4 ; System.Linq.Enumerable.Iterator<char>$$.ctor
005B062E4  mov      x0, x22
005B062E8  str      x21, [x0, #0x20]!
005B062EC  mov      x1, x21
005B062F0  bl       #0x382bcb8 ; 
005B062F4  mov      x0, x22
005B062F8  str      x20, [x0, #0x28]!
005B062FC  mov      x1, x20
005B06300  bl       #0x382bcb8 ; 
005B06304  str      x19, [x22, #0x30]!
005B06308  mov      x0, x22
005B0630C  mov      x1, x19
005B06310  ldp      x20, x19, [sp, #0x20]
005B06314  ldp      x22, x21, [sp, #0x10]
005B06318  ldr      x30, [sp], #0x30
005B0631C  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, char>$$Clone
; RVA 0x5B06320; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06320  str      x30, [sp, #-0x30]!
005B06324  stp      x22, x21, [sp, #0x10]
005B06328  stp      x20, x19, [sp, #0x20]
005B0632C  ldr      x9, [x1, #0x20]
005B06330  mov      x8, x0
005B06334  ldp      x21, x20, [x8, #0x20]
005B06338  ldr      x22, [x8, #0x30]
005B0633C  ldr      x9, [x9, #0xc0]
005B06340  mov      x19, x1
005B06344  ldr      x0, [x9, #0x18]
005B06348  ldrb     w9, [x0, #0x135]
005B0634C  tbnz     w9, #0, #0x5b06354
005B06350  bl       #0x3a7e60c ; 
005B06354  bl       #0x382bfa0 ; 
005B06358  ldr      x8, [x19, #0x20]
005B0635C  mov      x1, x21
005B06360  mov      x2, x20
005B06364  mov      x3, x22
005B06368  ldr      x8, [x8, #0xc0]
005B0636C  mov      x19, x0
005B06370  ldr      x4, [x8, #0x30]
005B06374  bl       #0x5b062b8 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, char>$$.ctor
005B06378  mov      x0, x19
005B0637C  ldp      x20, x19, [sp, #0x20]
005B06380  ldp      x22, x21, [sp, #0x10]
005B06384  ldr      x30, [sp], #0x30
005B06388  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, char>$$MoveNext
; RVA 0x5B0638C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B0638C  sub      sp, sp, #0x110
005B06390  stp      x29, x30, [sp, #0xe0]
005B06394  stp      x22, x21, [sp, #0xf0]
005B06398  stp      x20, x19, [sp, #0x100]
005B0639C  ldr      w8, [x0, #0x14]
005B063A0  mov      x19, x0
005B063A4  mov      x20, x1
005B063A8  cmp      w8, #2
005B063AC  b.eq     #0x5b0640c
005B063B0  cmp      w8, #1
005B063B4  b.ne     #0x5b064e4
005B063B8  ldr      x0, [x19, #0x20]
005B063BC  cbz      x0, #0x5b064fc
005B063C0  ldr      x8, [x20, #0x20]
005B063C4  ldr      x8, [x8, #0xc0]
005B063C8  ldr      x1, [x8, #0x40]
005B063CC  add      x8, sp, #0x40
005B063D0  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B063D4  add      x0, sp, #0x90
005B063D8  add      x1, sp, #0x40
005B063DC  mov      w2, #0x48
005B063E0  bl       #0x89edad0 ; 
005B063E4  add      x21, x19, #0x38
005B063E8  add      x1, sp, #0x90
005B063EC  mov      w2, #0x48
005B063F0  mov      x0, x21
005B063F4  bl       #0x89edad0 ; 
005B063F8  mov      x0, x21
005B063FC  mov      x1, xzr
005B06400  bl       #0x382bcb8 ; 
005B06404  mov      w8, #2
005B06408  str      w8, [x19, #0x14]
005B0640C  add      x21, x19, #0x38
005B06410  add      x22, x19, #0x48
005B06414  ldr      x8, [x20, #0x20]
005B06418  mov      x0, x21
005B0641C  ldr      x8, [x8, #0xc0]
005B06420  ldr      x1, [x8, #0x80]
005B06424  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B06428  tbz      w0, #0, #0x5b064d4
005B0642C  ldr      x8, [x22, #0x30]
005B06430  ldp      q1, q0, [x22, #0x10]
005B06434  ldr      q2, [x22]
005B06438  str      x8, [sp, #0x70]
005B0643C  stp      q1, q0, [sp, #0x50]
005B06440  str      q2, [sp, #0x40]
005B06444  ldr      x8, [x19, #0x28]
005B06448  cbz      x8, #0x5b0647c
005B0644C  ldp      q0, q1, [sp, #0x40]
005B06450  ldr      q2, [sp, #0x60]
005B06454  ldr      x10, [sp, #0x70]
005B06458  ldr      x9, [x8, #0x18]
005B0645C  ldr      x0, [x8, #0x40]
005B06460  stp      q0, q1, [sp, #0x90]
005B06464  str      q2, [sp, #0xb0]
005B06468  str      x10, [sp, #0xc0]
005B0646C  ldr      x2, [x8, #0x28]
005B06470  add      x1, sp, #0x90
005B06474  blr      x9
005B06478  tbz      w0, #0, #0x5b06414
005B0647C  ldr      x8, [x19, #0x30]
005B06480  ldp      q0, q1, [sp, #0x40]
005B06484  ldr      q2, [sp, #0x60]
005B06488  ldr      x9, [sp, #0x70]
005B0648C  stp      q0, q1, [sp]
005B06490  str      q2, [sp, #0x20]
005B06494  str      x9, [sp, #0x30]
005B06498  cbz      x8, #0x5b064fc
005B0649C  ldp      q0, q1, [sp]
005B064A0  ldr      q2, [sp, #0x20]
005B064A4  ldr      x10, [sp, #0x30]
005B064A8  ldr      x9, [x8, #0x18]
005B064AC  ldr      x0, [x8, #0x40]
005B064B0  stp      q0, q1, [sp, #0x90]
005B064B4  str      q2, [sp, #0xb0]
005B064B8  str      x10, [sp, #0xc0]
005B064BC  ldr      x2, [x8, #0x28]
005B064C0  add      x1, sp, #0x90
005B064C4  blr      x9
005B064C8  strh     w0, [x19, #0x18]
005B064CC  mov      w0, #1
005B064D0  b        #0x5b064e8 ; 
005B064D4  ldr      x8, [x19]
005B064D8  mov      x0, x19
005B064DC  ldp      x9, x1, [x8, #0x1f8]
005B064E0  blr      x9
005B064E4  mov      w0, wzr
005B064E8  ldp      x20, x19, [sp, #0x100]
005B064EC  ldp      x22, x21, [sp, #0xf0]
005B064F0  ldp      x29, x30, [sp, #0xe0]
005B064F4  add      sp, sp, #0x110
005B064F8  ret      
005B064FC  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, char>$$Where
; RVA 0x5B06500; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06500  stp      x30, x21, [sp, #-0x20]!
005B06504  stp      x20, x19, [sp, #0x10]
005B06508  ldr      x8, [x2, #0x20]
005B0650C  mov      x20, x2
005B06510  mov      x19, x1
005B06514  mov      x21, x0
005B06518  ldr      x8, [x8, #0xc0]
005B0651C  ldr      x8, [x8, #0x98]
005B06520  ldrb     w9, [x8, #0x135]
005B06524  tbnz     w9, #0, #0x5b06534
005B06528  mov      x0, x8
005B0652C  bl       #0x3a7e60c ; 
005B06530  mov      x8, x0
005B06534  mov      x0, x8
005B06538  bl       #0x382bfa0 ; 
005B0653C  ldr      x8, [x20, #0x20]
005B06540  mov      x1, x21
005B06544  mov      x2, x19
005B06548  mov      x20, x0
005B0654C  ldr      x8, [x8, #0xc0]
005B06550  ldr      x3, [x8, #0xa0]
005B06554  bl       #0x59c8178 ; System.Linq.Enumerable.WhereEnumerableIterator<char>$$.ctor
005B06558  mov      x0, x20
005B0655C  ldp      x20, x19, [sp, #0x10]
005B06560  ldp      x30, x21, [sp], #0x20
005B06564  ret      

