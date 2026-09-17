; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrRelicData>$$.ctor
; RVA 0x5A0C34C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C34C  str      x30, [sp, #-0x30]!
005A0C350  stp      x22, x21, [sp, #0x10]
005A0C354  stp      x20, x19, [sp, #0x20]
005A0C358  ldr      x8, [x4, #0x20]
005A0C35C  mov      x21, x1
005A0C360  mov      x19, x3
005A0C364  mov      x20, x2
005A0C368  ldr      x8, [x8, #0xc0]
005A0C36C  mov      x22, x0
005A0C370  ldr      x1, [x8]
005A0C374  bl       #0x4a73644 ; System.Linq.Enumerable.Iterator<CalAttrRelicData>$$.ctor
005A0C378  mov      x0, x22
005A0C37C  str      x21, [x0, #0x20]!
005A0C380  mov      x1, x21
005A0C384  bl       #0x382bcb8 ; 
005A0C388  mov      x0, x22
005A0C38C  str      x20, [x0, #0x28]!
005A0C390  mov      x1, x20
005A0C394  bl       #0x382bcb8 ; 
005A0C398  str      x19, [x22, #0x30]!
005A0C39C  mov      x0, x22
005A0C3A0  mov      x1, x19
005A0C3A4  ldp      x20, x19, [sp, #0x20]
005A0C3A8  ldp      x22, x21, [sp, #0x10]
005A0C3AC  ldr      x30, [sp], #0x30
005A0C3B0  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrRelicData>$$Clone
; RVA 0x5A0C3B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C3B4  str      x30, [sp, #-0x30]!
005A0C3B8  stp      x22, x21, [sp, #0x10]
005A0C3BC  stp      x20, x19, [sp, #0x20]
005A0C3C0  ldr      x9, [x1, #0x20]
005A0C3C4  mov      x8, x0
005A0C3C8  ldp      x21, x20, [x8, #0x20]
005A0C3CC  ldr      x22, [x8, #0x30]
005A0C3D0  ldr      x9, [x9, #0xc0]
005A0C3D4  mov      x19, x1
005A0C3D8  ldr      x0, [x9, #0x18]
005A0C3DC  ldrb     w9, [x0, #0x135]
005A0C3E0  tbnz     w9, #0, #0x5a0c3e8
005A0C3E4  bl       #0x3a7e60c ; 
005A0C3E8  bl       #0x382bfa0 ; 
005A0C3EC  ldr      x8, [x19, #0x20]
005A0C3F0  mov      x1, x21
005A0C3F4  mov      x2, x20
005A0C3F8  mov      x3, x22
005A0C3FC  ldr      x8, [x8, #0xc0]
005A0C400  mov      x19, x0
005A0C404  ldr      x4, [x8, #0x30]
005A0C408  bl       #0x5a0c34c ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrRelicData>$$.ctor
005A0C40C  mov      x0, x19
005A0C410  ldp      x20, x19, [sp, #0x20]
005A0C414  ldp      x22, x21, [sp, #0x10]
005A0C418  ldr      x30, [sp], #0x30
005A0C41C  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrRelicData>$$MoveNext
; RVA 0x5A0C420; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C420  sub      sp, sp, #0xe0
005A0C424  str      x30, [sp, #0xc0]
005A0C428  stp      x20, x19, [sp, #0xd0]
005A0C42C  ldr      w8, [x0, #0x14]
005A0C430  cmp      w8, #1
005A0C434  b.ne     #0x5a0c524
005A0C438  mov      x19, x0
005A0C43C  mov      w20, #0x38
005A0C440  ldr      x9, [x19, #0x20]
005A0C444  cbz      x9, #0x5a0c53c
005A0C448  ldrsw    x8, [x19, #0x38]
005A0C44C  ldr      w10, [x9, #0x18]
005A0C450  cmp      w8, w10
005A0C454  b.ge     #0x5a0c514
005A0C458  cmp      w8, w10
005A0C45C  b.hs     #0x5a0c538
005A0C460  madd     x9, x8, x20, x9
005A0C464  ldr      x10, [x9, #0x50]
005A0C468  ldp      q1, q0, [x9, #0x30]
005A0C46C  ldr      q2, [x9, #0x20]
005A0C470  add      w8, w8, #1
005A0C474  str      x10, [sp, #0x70]
005A0C478  stp      q1, q0, [sp, #0x50]
005A0C47C  str      q2, [sp, #0x40]
005A0C480  ldr      x9, [x19, #0x28]
005A0C484  str      w8, [x19, #0x38]
005A0C488  cbz      x9, #0x5a0c4bc
005A0C48C  ldp      q0, q1, [sp, #0x40]
005A0C490  ldr      q2, [sp, #0x60]
005A0C494  ldr      x10, [sp, #0x70]
005A0C498  ldr      x8, [x9, #0x18]
005A0C49C  ldr      x0, [x9, #0x40]
005A0C4A0  stp      q0, q1, [sp, #0x80]
005A0C4A4  str      q2, [sp, #0xa0]
005A0C4A8  str      x10, [sp, #0xb0]
005A0C4AC  ldr      x2, [x9, #0x28]
005A0C4B0  add      x1, sp, #0x80
005A0C4B4  blr      x8
005A0C4B8  tbz      w0, #0, #0x5a0c440
005A0C4BC  ldr      x8, [x19, #0x30]
005A0C4C0  ldp      q0, q1, [sp, #0x40]
005A0C4C4  ldr      q2, [sp, #0x60]
005A0C4C8  ldr      x9, [sp, #0x70]
005A0C4CC  stp      q0, q1, [sp]
005A0C4D0  str      q2, [sp, #0x20]
005A0C4D4  str      x9, [sp, #0x30]
005A0C4D8  cbz      x8, #0x5a0c53c
005A0C4DC  ldp      q0, q1, [sp]
005A0C4E0  ldr      q2, [sp, #0x20]
005A0C4E4  ldr      x10, [sp, #0x30]
005A0C4E8  ldr      x9, [x8, #0x18]
005A0C4EC  ldr      x0, [x8, #0x40]
005A0C4F0  stp      q0, q1, [sp, #0x80]
005A0C4F4  str      q2, [sp, #0xa0]
005A0C4F8  str      x10, [sp, #0xb0]
005A0C4FC  ldr      x2, [x8, #0x28]
005A0C500  add      x1, sp, #0x80
005A0C504  blr      x9
005A0C508  str      x0, [x19, #0x18]
005A0C50C  mov      w0, #1
005A0C510  b        #0x5a0c528 ; 
005A0C514  ldr      x8, [x19]
005A0C518  mov      x0, x19
005A0C51C  ldp      x9, x1, [x8, #0x1f8]
005A0C520  blr      x9
005A0C524  mov      w0, wzr
005A0C528  ldp      x20, x19, [sp, #0xd0]
005A0C52C  ldr      x30, [sp, #0xc0]
005A0C530  add      sp, sp, #0xe0
005A0C534  ret      
005A0C538  bl       #0x382bfc0 ; 
005A0C53C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrRelicData>$$Where
; RVA 0x5A0C540; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C540  stp      x30, x21, [sp, #-0x20]!
005A0C544  stp      x20, x19, [sp, #0x10]
005A0C548  ldr      x8, [x2, #0x20]
005A0C54C  mov      x20, x2
005A0C550  mov      x19, x1
005A0C554  mov      x21, x0
005A0C558  ldr      x8, [x8, #0xc0]
005A0C55C  ldr      x8, [x8, #0x70]
005A0C560  ldrb     w9, [x8, #0x135]
005A0C564  tbnz     w9, #0, #0x5a0c574
005A0C568  mov      x0, x8
005A0C56C  bl       #0x3a7e60c ; 
005A0C570  mov      x8, x0
005A0C574  mov      x0, x8
005A0C578  bl       #0x382bfa0 ; 
005A0C57C  ldr      x8, [x20, #0x20]
005A0C580  mov      x1, x21
005A0C584  mov      x2, x19
005A0C588  mov      x20, x0
005A0C58C  ldr      x8, [x8, #0xc0]
005A0C590  ldr      x3, [x8, #0x78]
005A0C594  bl       #0x59c6ccc ; System.Linq.Enumerable.WhereEnumerableIterator<CalAttrRelicData>$$.ctor
005A0C598  mov      x0, x20
005A0C59C  ldp      x20, x19, [sp, #0x10]
005A0C5A0  ldp      x30, x21, [sp], #0x20
005A0C5A4  ret      

