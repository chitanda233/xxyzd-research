; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalEquipData>$$.ctor
; RVA 0x5A0C804; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C804  str      x30, [sp, #-0x30]!
005A0C808  stp      x22, x21, [sp, #0x10]
005A0C80C  stp      x20, x19, [sp, #0x20]
005A0C810  ldr      x8, [x4, #0x20]
005A0C814  mov      x21, x1
005A0C818  mov      x19, x3
005A0C81C  mov      x20, x2
005A0C820  ldr      x8, [x8, #0xc0]
005A0C824  mov      x22, x0
005A0C828  ldr      x1, [x8]
005A0C82C  bl       #0x4a7386c ; System.Linq.Enumerable.Iterator<CalEquipData>$$.ctor
005A0C830  mov      x0, x22
005A0C834  str      x21, [x0, #0x20]!
005A0C838  mov      x1, x21
005A0C83C  bl       #0x382bcb8 ; 
005A0C840  mov      x0, x22
005A0C844  str      x20, [x0, #0x28]!
005A0C848  mov      x1, x20
005A0C84C  bl       #0x382bcb8 ; 
005A0C850  str      x19, [x22, #0x30]!
005A0C854  mov      x0, x22
005A0C858  mov      x1, x19
005A0C85C  ldp      x20, x19, [sp, #0x20]
005A0C860  ldp      x22, x21, [sp, #0x10]
005A0C864  ldr      x30, [sp], #0x30
005A0C868  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalEquipData>$$Clone
; RVA 0x5A0C86C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C86C  str      x30, [sp, #-0x30]!
005A0C870  stp      x22, x21, [sp, #0x10]
005A0C874  stp      x20, x19, [sp, #0x20]
005A0C878  ldr      x9, [x1, #0x20]
005A0C87C  mov      x8, x0
005A0C880  ldp      x21, x20, [x8, #0x20]
005A0C884  ldr      x22, [x8, #0x30]
005A0C888  ldr      x9, [x9, #0xc0]
005A0C88C  mov      x19, x1
005A0C890  ldr      x0, [x9, #0x18]
005A0C894  ldrb     w9, [x0, #0x135]
005A0C898  tbnz     w9, #0, #0x5a0c8a0
005A0C89C  bl       #0x3a7e60c ; 
005A0C8A0  bl       #0x382bfa0 ; 
005A0C8A4  ldr      x8, [x19, #0x20]
005A0C8A8  mov      x1, x21
005A0C8AC  mov      x2, x20
005A0C8B0  mov      x3, x22
005A0C8B4  ldr      x8, [x8, #0xc0]
005A0C8B8  mov      x19, x0
005A0C8BC  ldr      x4, [x8, #0x30]
005A0C8C0  bl       #0x5a0c804 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalEquipData>$$.ctor
005A0C8C4  mov      x0, x19
005A0C8C8  ldp      x20, x19, [sp, #0x20]
005A0C8CC  ldp      x22, x21, [sp, #0x10]
005A0C8D0  ldr      x30, [sp], #0x30
005A0C8D4  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalEquipData>$$MoveNext
; RVA 0x5A0C8D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C8D8  sub      sp, sp, #0xe0
005A0C8DC  str      x30, [sp, #0xc0]
005A0C8E0  stp      x20, x19, [sp, #0xd0]
005A0C8E4  ldr      w8, [x0, #0x14]
005A0C8E8  cmp      w8, #1
005A0C8EC  b.ne     #0x5a0c9dc
005A0C8F0  mov      x19, x0
005A0C8F4  mov      w20, #0x38
005A0C8F8  ldr      x9, [x19, #0x20]
005A0C8FC  cbz      x9, #0x5a0c9f4
005A0C900  ldrsw    x8, [x19, #0x38]
005A0C904  ldr      w10, [x9, #0x18]
005A0C908  cmp      w8, w10
005A0C90C  b.ge     #0x5a0c9cc
005A0C910  cmp      w8, w10
005A0C914  b.hs     #0x5a0c9f0
005A0C918  madd     x9, x8, x20, x9
005A0C91C  ldr      x10, [x9, #0x50]
005A0C920  ldp      q1, q0, [x9, #0x30]
005A0C924  ldr      q2, [x9, #0x20]
005A0C928  add      w8, w8, #1
005A0C92C  str      x10, [sp, #0x70]
005A0C930  stp      q1, q0, [sp, #0x50]
005A0C934  str      q2, [sp, #0x40]
005A0C938  ldr      x9, [x19, #0x28]
005A0C93C  str      w8, [x19, #0x38]
005A0C940  cbz      x9, #0x5a0c974
005A0C944  ldp      q0, q1, [sp, #0x40]
005A0C948  ldr      q2, [sp, #0x60]
005A0C94C  ldr      x10, [sp, #0x70]
005A0C950  ldr      x8, [x9, #0x18]
005A0C954  ldr      x0, [x9, #0x40]
005A0C958  stp      q0, q1, [sp, #0x80]
005A0C95C  str      q2, [sp, #0xa0]
005A0C960  str      x10, [sp, #0xb0]
005A0C964  ldr      x2, [x9, #0x28]
005A0C968  add      x1, sp, #0x80
005A0C96C  blr      x8
005A0C970  tbz      w0, #0, #0x5a0c8f8
005A0C974  ldr      x8, [x19, #0x30]
005A0C978  ldp      q0, q1, [sp, #0x40]
005A0C97C  ldr      q2, [sp, #0x60]
005A0C980  ldr      x9, [sp, #0x70]
005A0C984  stp      q0, q1, [sp]
005A0C988  str      q2, [sp, #0x20]
005A0C98C  str      x9, [sp, #0x30]
005A0C990  cbz      x8, #0x5a0c9f4
005A0C994  ldp      q0, q1, [sp]
005A0C998  ldr      q2, [sp, #0x20]
005A0C99C  ldr      x10, [sp, #0x30]
005A0C9A0  ldr      x9, [x8, #0x18]
005A0C9A4  ldr      x0, [x8, #0x40]
005A0C9A8  stp      q0, q1, [sp, #0x80]
005A0C9AC  str      q2, [sp, #0xa0]
005A0C9B0  str      x10, [sp, #0xb0]
005A0C9B4  ldr      x2, [x8, #0x28]
005A0C9B8  add      x1, sp, #0x80
005A0C9BC  blr      x9
005A0C9C0  str      x0, [x19, #0x18]
005A0C9C4  mov      w0, #1
005A0C9C8  b        #0x5a0c9e0 ; 
005A0C9CC  ldr      x8, [x19]
005A0C9D0  mov      x0, x19
005A0C9D4  ldp      x9, x1, [x8, #0x1f8]
005A0C9D8  blr      x9
005A0C9DC  mov      w0, wzr
005A0C9E0  ldp      x20, x19, [sp, #0xd0]
005A0C9E4  ldr      x30, [sp, #0xc0]
005A0C9E8  add      sp, sp, #0xe0
005A0C9EC  ret      
005A0C9F0  bl       #0x382bfc0 ; 
005A0C9F4  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalEquipData>$$Where
; RVA 0x5A0C9F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C9F8  stp      x30, x21, [sp, #-0x20]!
005A0C9FC  stp      x20, x19, [sp, #0x10]
005A0CA00  ldr      x8, [x2, #0x20]
005A0CA04  mov      x20, x2
005A0CA08  mov      x19, x1
005A0CA0C  mov      x21, x0
005A0CA10  ldr      x8, [x8, #0xc0]
005A0CA14  ldr      x8, [x8, #0x70]
005A0CA18  ldrb     w9, [x8, #0x135]
005A0CA1C  tbnz     w9, #0, #0x5a0ca2c
005A0CA20  mov      x0, x8
005A0CA24  bl       #0x3a7e60c ; 
005A0CA28  mov      x8, x0
005A0CA2C  mov      x0, x8
005A0CA30  bl       #0x382bfa0 ; 
005A0CA34  ldr      x8, [x20, #0x20]
005A0CA38  mov      x1, x21
005A0CA3C  mov      x2, x19
005A0CA40  mov      x20, x0
005A0CA44  ldr      x8, [x8, #0xc0]
005A0CA48  ldr      x3, [x8, #0x78]
005A0CA4C  bl       #0x59c74f4 ; System.Linq.Enumerable.WhereEnumerableIterator<CalEquipData>$$.ctor
005A0CA50  mov      x0, x20
005A0CA54  ldp      x20, x19, [sp, #0x10]
005A0CA58  ldp      x30, x21, [sp], #0x20
005A0CA5C  ret      

