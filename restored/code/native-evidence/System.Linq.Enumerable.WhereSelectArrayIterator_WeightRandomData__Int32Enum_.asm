; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Int32Enum>$$.ctor
; RVA 0x5A0D3F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D3F8  str      x30, [sp, #-0x30]!
005A0D3FC  stp      x22, x21, [sp, #0x10]
005A0D400  stp      x20, x19, [sp, #0x20]
005A0D404  ldr      x8, [x4, #0x20]
005A0D408  mov      x21, x1
005A0D40C  mov      x19, x3
005A0D410  mov      x20, x2
005A0D414  ldr      x8, [x8, #0xc0]
005A0D418  mov      x22, x0
005A0D41C  ldr      x1, [x8]
005A0D420  bl       #0x4a744e4 ; System.Linq.Enumerable.Iterator<Int32Enum>$$.ctor
005A0D424  mov      x0, x22
005A0D428  str      x21, [x0, #0x20]!
005A0D42C  mov      x1, x21
005A0D430  bl       #0x382bcb8 ; 
005A0D434  mov      x0, x22
005A0D438  str      x20, [x0, #0x28]!
005A0D43C  mov      x1, x20
005A0D440  bl       #0x382bcb8 ; 
005A0D444  str      x19, [x22, #0x30]!
005A0D448  mov      x0, x22
005A0D44C  mov      x1, x19
005A0D450  ldp      x20, x19, [sp, #0x20]
005A0D454  ldp      x22, x21, [sp, #0x10]
005A0D458  ldr      x30, [sp], #0x30
005A0D45C  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Int32Enum>$$Clone
; RVA 0x5A0D460; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D460  str      x30, [sp, #-0x30]!
005A0D464  stp      x22, x21, [sp, #0x10]
005A0D468  stp      x20, x19, [sp, #0x20]
005A0D46C  ldr      x9, [x1, #0x20]
005A0D470  mov      x8, x0
005A0D474  ldp      x21, x20, [x8, #0x20]
005A0D478  ldr      x22, [x8, #0x30]
005A0D47C  ldr      x9, [x9, #0xc0]
005A0D480  mov      x19, x1
005A0D484  ldr      x0, [x9, #0x18]
005A0D488  ldrb     w9, [x0, #0x135]
005A0D48C  tbnz     w9, #0, #0x5a0d494
005A0D490  bl       #0x3a7e60c ; 
005A0D494  bl       #0x382bfa0 ; 
005A0D498  ldr      x8, [x19, #0x20]
005A0D49C  mov      x1, x21
005A0D4A0  mov      x2, x20
005A0D4A4  mov      x3, x22
005A0D4A8  ldr      x8, [x8, #0xc0]
005A0D4AC  mov      x19, x0
005A0D4B0  ldr      x4, [x8, #0x30]
005A0D4B4  bl       #0x5a0d3f8 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Int32Enum>$$.ctor
005A0D4B8  mov      x0, x19
005A0D4BC  ldp      x20, x19, [sp, #0x20]
005A0D4C0  ldp      x22, x21, [sp, #0x10]
005A0D4C4  ldr      x30, [sp], #0x30
005A0D4C8  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Int32Enum>$$MoveNext
; RVA 0x5A0D4CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D4CC  sub      sp, sp, #0xe0
005A0D4D0  str      x30, [sp, #0xc0]
005A0D4D4  stp      x20, x19, [sp, #0xd0]
005A0D4D8  ldr      w8, [x0, #0x14]
005A0D4DC  cmp      w8, #1
005A0D4E0  b.ne     #0x5a0d5d0
005A0D4E4  mov      x19, x0
005A0D4E8  mov      w20, #0x38
005A0D4EC  ldr      x9, [x19, #0x20]
005A0D4F0  cbz      x9, #0x5a0d5e8
005A0D4F4  ldrsw    x8, [x19, #0x38]
005A0D4F8  ldr      w10, [x9, #0x18]
005A0D4FC  cmp      w8, w10
005A0D500  b.ge     #0x5a0d5c0
005A0D504  cmp      w8, w10
005A0D508  b.hs     #0x5a0d5e4
005A0D50C  madd     x9, x8, x20, x9
005A0D510  ldr      x10, [x9, #0x50]
005A0D514  ldp      q1, q0, [x9, #0x30]
005A0D518  ldr      q2, [x9, #0x20]
005A0D51C  add      w8, w8, #1
005A0D520  str      x10, [sp, #0x70]
005A0D524  stp      q1, q0, [sp, #0x50]
005A0D528  str      q2, [sp, #0x40]
005A0D52C  ldr      x9, [x19, #0x28]
005A0D530  str      w8, [x19, #0x38]
005A0D534  cbz      x9, #0x5a0d568
005A0D538  ldp      q0, q1, [sp, #0x40]
005A0D53C  ldr      q2, [sp, #0x60]
005A0D540  ldr      x10, [sp, #0x70]
005A0D544  ldr      x8, [x9, #0x18]
005A0D548  ldr      x0, [x9, #0x40]
005A0D54C  stp      q0, q1, [sp, #0x80]
005A0D550  str      q2, [sp, #0xa0]
005A0D554  str      x10, [sp, #0xb0]
005A0D558  ldr      x2, [x9, #0x28]
005A0D55C  add      x1, sp, #0x80
005A0D560  blr      x8
005A0D564  tbz      w0, #0, #0x5a0d4ec
005A0D568  ldr      x8, [x19, #0x30]
005A0D56C  ldp      q0, q1, [sp, #0x40]
005A0D570  ldr      q2, [sp, #0x60]
005A0D574  ldr      x9, [sp, #0x70]
005A0D578  stp      q0, q1, [sp]
005A0D57C  str      q2, [sp, #0x20]
005A0D580  str      x9, [sp, #0x30]
005A0D584  cbz      x8, #0x5a0d5e8
005A0D588  ldp      q0, q1, [sp]
005A0D58C  ldr      q2, [sp, #0x20]
005A0D590  ldr      x10, [sp, #0x30]
005A0D594  ldr      x9, [x8, #0x18]
005A0D598  ldr      x0, [x8, #0x40]
005A0D59C  stp      q0, q1, [sp, #0x80]
005A0D5A0  str      q2, [sp, #0xa0]
005A0D5A4  str      x10, [sp, #0xb0]
005A0D5A8  ldr      x2, [x8, #0x28]
005A0D5AC  add      x1, sp, #0x80
005A0D5B0  blr      x9
005A0D5B4  str      w0, [x19, #0x18]
005A0D5B8  mov      w0, #1
005A0D5BC  b        #0x5a0d5d4 ; 
005A0D5C0  ldr      x8, [x19]
005A0D5C4  mov      x0, x19
005A0D5C8  ldp      x9, x1, [x8, #0x1f8]
005A0D5CC  blr      x9
005A0D5D0  mov      w0, wzr
005A0D5D4  ldp      x20, x19, [sp, #0xd0]
005A0D5D8  ldr      x30, [sp, #0xc0]
005A0D5DC  add      sp, sp, #0xe0
005A0D5E0  ret      
005A0D5E4  bl       #0x382bfc0 ; 
005A0D5E8  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Int32Enum>$$Where
; RVA 0x5A0D5EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D5EC  stp      x30, x21, [sp, #-0x20]!
005A0D5F0  stp      x20, x19, [sp, #0x10]
005A0D5F4  ldr      x8, [x2, #0x20]
005A0D5F8  mov      x20, x2
005A0D5FC  mov      x19, x1
005A0D600  mov      x21, x0
005A0D604  ldr      x8, [x8, #0xc0]
005A0D608  ldr      x8, [x8, #0x70]
005A0D60C  ldrb     w9, [x8, #0x135]
005A0D610  tbnz     w9, #0, #0x5a0d620
005A0D614  mov      x0, x8
005A0D618  bl       #0x3a7e60c ; 
005A0D61C  mov      x8, x0
005A0D620  mov      x0, x8
005A0D624  bl       #0x382bfa0 ; 
005A0D628  ldr      x8, [x20, #0x20]
005A0D62C  mov      x1, x21
005A0D630  mov      x2, x19
005A0D634  mov      x20, x0
005A0D638  ldr      x8, [x8, #0xc0]
005A0D63C  ldr      x3, [x8, #0x78]
005A0D640  bl       #0x59ca294 ; System.Linq.Enumerable.WhereEnumerableIterator<Int32Enum>$$.ctor
005A0D644  mov      x0, x20
005A0D648  ldp      x20, x19, [sp, #0x10]
005A0D64C  ldp      x30, x21, [sp], #0x20
005A0D650  ret      

