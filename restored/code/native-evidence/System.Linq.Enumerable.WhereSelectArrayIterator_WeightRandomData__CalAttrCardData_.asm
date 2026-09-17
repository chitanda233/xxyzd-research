; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrCardData>$$.ctor
; RVA 0x5A0C0F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C0F0  str      x30, [sp, #-0x30]!
005A0C0F4  stp      x22, x21, [sp, #0x10]
005A0C0F8  stp      x20, x19, [sp, #0x20]
005A0C0FC  ldr      x8, [x4, #0x20]
005A0C100  mov      x21, x1
005A0C104  mov      x19, x3
005A0C108  mov      x20, x2
005A0C10C  ldr      x8, [x8, #0xc0]
005A0C110  mov      x22, x0
005A0C114  ldr      x1, [x8]
005A0C118  bl       #0x4a732ec ; System.Linq.Enumerable.Iterator<CalAttrCardData>$$.ctor
005A0C11C  mov      x0, x22
005A0C120  str      x21, [x0, #0x20]!
005A0C124  mov      x1, x21
005A0C128  bl       #0x382bcb8 ; 
005A0C12C  mov      x0, x22
005A0C130  str      x20, [x0, #0x28]!
005A0C134  mov      x1, x20
005A0C138  bl       #0x382bcb8 ; 
005A0C13C  str      x19, [x22, #0x30]!
005A0C140  mov      x0, x22
005A0C144  mov      x1, x19
005A0C148  ldp      x20, x19, [sp, #0x20]
005A0C14C  ldp      x22, x21, [sp, #0x10]
005A0C150  ldr      x30, [sp], #0x30
005A0C154  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrCardData>$$Clone
; RVA 0x5A0C158; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C158  str      x30, [sp, #-0x30]!
005A0C15C  stp      x22, x21, [sp, #0x10]
005A0C160  stp      x20, x19, [sp, #0x20]
005A0C164  ldr      x9, [x1, #0x20]
005A0C168  mov      x8, x0
005A0C16C  ldp      x21, x20, [x8, #0x20]
005A0C170  ldr      x22, [x8, #0x30]
005A0C174  ldr      x9, [x9, #0xc0]
005A0C178  mov      x19, x1
005A0C17C  ldr      x0, [x9, #0x18]
005A0C180  ldrb     w9, [x0, #0x135]
005A0C184  tbnz     w9, #0, #0x5a0c18c
005A0C188  bl       #0x3a7e60c ; 
005A0C18C  bl       #0x382bfa0 ; 
005A0C190  ldr      x8, [x19, #0x20]
005A0C194  mov      x1, x21
005A0C198  mov      x2, x20
005A0C19C  mov      x3, x22
005A0C1A0  ldr      x8, [x8, #0xc0]
005A0C1A4  mov      x19, x0
005A0C1A8  ldr      x4, [x8, #0x30]
005A0C1AC  bl       #0x5a0c0f0 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrCardData>$$.ctor
005A0C1B0  mov      x0, x19
005A0C1B4  ldp      x20, x19, [sp, #0x20]
005A0C1B8  ldp      x22, x21, [sp, #0x10]
005A0C1BC  ldr      x30, [sp], #0x30
005A0C1C0  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrCardData>$$MoveNext
; RVA 0x5A0C1C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C1C4  sub      sp, sp, #0xe0
005A0C1C8  str      x30, [sp, #0xc0]
005A0C1CC  stp      x20, x19, [sp, #0xd0]
005A0C1D0  ldr      w8, [x0, #0x14]
005A0C1D4  cmp      w8, #1
005A0C1D8  b.ne     #0x5a0c2c8
005A0C1DC  mov      x19, x0
005A0C1E0  mov      w20, #0x38
005A0C1E4  ldr      x9, [x19, #0x20]
005A0C1E8  cbz      x9, #0x5a0c2e0
005A0C1EC  ldrsw    x8, [x19, #0x38]
005A0C1F0  ldr      w10, [x9, #0x18]
005A0C1F4  cmp      w8, w10
005A0C1F8  b.ge     #0x5a0c2b8
005A0C1FC  cmp      w8, w10
005A0C200  b.hs     #0x5a0c2dc
005A0C204  madd     x9, x8, x20, x9
005A0C208  ldr      x10, [x9, #0x50]
005A0C20C  ldp      q1, q0, [x9, #0x30]
005A0C210  ldr      q2, [x9, #0x20]
005A0C214  add      w8, w8, #1
005A0C218  str      x10, [sp, #0x70]
005A0C21C  stp      q1, q0, [sp, #0x50]
005A0C220  str      q2, [sp, #0x40]
005A0C224  ldr      x9, [x19, #0x28]
005A0C228  str      w8, [x19, #0x38]
005A0C22C  cbz      x9, #0x5a0c260
005A0C230  ldp      q0, q1, [sp, #0x40]
005A0C234  ldr      q2, [sp, #0x60]
005A0C238  ldr      x10, [sp, #0x70]
005A0C23C  ldr      x8, [x9, #0x18]
005A0C240  ldr      x0, [x9, #0x40]
005A0C244  stp      q0, q1, [sp, #0x80]
005A0C248  str      q2, [sp, #0xa0]
005A0C24C  str      x10, [sp, #0xb0]
005A0C250  ldr      x2, [x9, #0x28]
005A0C254  add      x1, sp, #0x80
005A0C258  blr      x8
005A0C25C  tbz      w0, #0, #0x5a0c1e4
005A0C260  ldr      x8, [x19, #0x30]
005A0C264  ldp      q0, q1, [sp, #0x40]
005A0C268  ldr      q2, [sp, #0x60]
005A0C26C  ldr      x9, [sp, #0x70]
005A0C270  stp      q0, q1, [sp]
005A0C274  str      q2, [sp, #0x20]
005A0C278  str      x9, [sp, #0x30]
005A0C27C  cbz      x8, #0x5a0c2e0
005A0C280  ldp      q0, q1, [sp]
005A0C284  ldr      q2, [sp, #0x20]
005A0C288  ldr      x10, [sp, #0x30]
005A0C28C  ldr      x9, [x8, #0x18]
005A0C290  ldr      x0, [x8, #0x40]
005A0C294  stp      q0, q1, [sp, #0x80]
005A0C298  str      q2, [sp, #0xa0]
005A0C29C  str      x10, [sp, #0xb0]
005A0C2A0  ldr      x2, [x8, #0x28]
005A0C2A4  add      x1, sp, #0x80
005A0C2A8  blr      x9
005A0C2AC  str      x0, [x19, #0x18]
005A0C2B0  mov      w0, #1
005A0C2B4  b        #0x5a0c2cc ; 
005A0C2B8  ldr      x8, [x19]
005A0C2BC  mov      x0, x19
005A0C2C0  ldp      x9, x1, [x8, #0x1f8]
005A0C2C4  blr      x9
005A0C2C8  mov      w0, wzr
005A0C2CC  ldp      x20, x19, [sp, #0xd0]
005A0C2D0  ldr      x30, [sp, #0xc0]
005A0C2D4  add      sp, sp, #0xe0
005A0C2D8  ret      
005A0C2DC  bl       #0x382bfc0 ; 
005A0C2E0  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrCardData>$$Where
; RVA 0x5A0C2E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C2E4  stp      x30, x21, [sp, #-0x20]!
005A0C2E8  stp      x20, x19, [sp, #0x10]
005A0C2EC  ldr      x8, [x2, #0x20]
005A0C2F0  mov      x20, x2
005A0C2F4  mov      x19, x1
005A0C2F8  mov      x21, x0
005A0C2FC  ldr      x8, [x8, #0xc0]
005A0C300  ldr      x8, [x8, #0x70]
005A0C304  ldrb     w9, [x8, #0x135]
005A0C308  tbnz     w9, #0, #0x5a0c318
005A0C30C  mov      x0, x8
005A0C310  bl       #0x3a7e60c ; 
005A0C314  mov      x8, x0
005A0C318  mov      x0, x8
005A0C31C  bl       #0x382bfa0 ; 
005A0C320  ldr      x8, [x20, #0x20]
005A0C324  mov      x1, x21
005A0C328  mov      x2, x19
005A0C32C  mov      x20, x0
005A0C330  ldr      x8, [x8, #0xc0]
005A0C334  ldr      x3, [x8, #0x78]
005A0C338  bl       #0x59c6084 ; System.Linq.Enumerable.WhereEnumerableIterator<CalAttrCardData>$$.ctor
005A0C33C  mov      x0, x20
005A0C340  ldp      x20, x19, [sp, #0x10]
005A0C344  ldp      x30, x21, [sp], #0x20
005A0C348  ret      

