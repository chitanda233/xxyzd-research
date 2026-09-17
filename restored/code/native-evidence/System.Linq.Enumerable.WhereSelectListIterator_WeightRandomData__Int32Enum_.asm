; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Int32Enum>$$.ctor
; RVA 0x5B06818; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06818  str      x30, [sp, #-0x30]!
005B0681C  stp      x22, x21, [sp, #0x10]
005B06820  stp      x20, x19, [sp, #0x20]
005B06824  ldr      x8, [x4, #0x20]
005B06828  mov      x21, x1
005B0682C  mov      x19, x3
005B06830  mov      x20, x2
005B06834  ldr      x8, [x8, #0xc0]
005B06838  mov      x22, x0
005B0683C  ldr      x1, [x8]
005B06840  bl       #0x4a744e4 ; System.Linq.Enumerable.Iterator<Int32Enum>$$.ctor
005B06844  mov      x0, x22
005B06848  str      x21, [x0, #0x20]!
005B0684C  mov      x1, x21
005B06850  bl       #0x382bcb8 ; 
005B06854  mov      x0, x22
005B06858  str      x20, [x0, #0x28]!
005B0685C  mov      x1, x20
005B06860  bl       #0x382bcb8 ; 
005B06864  str      x19, [x22, #0x30]!
005B06868  mov      x0, x22
005B0686C  mov      x1, x19
005B06870  ldp      x20, x19, [sp, #0x20]
005B06874  ldp      x22, x21, [sp, #0x10]
005B06878  ldr      x30, [sp], #0x30
005B0687C  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Int32Enum>$$Clone
; RVA 0x5B06880; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06880  str      x30, [sp, #-0x30]!
005B06884  stp      x22, x21, [sp, #0x10]
005B06888  stp      x20, x19, [sp, #0x20]
005B0688C  ldr      x9, [x1, #0x20]
005B06890  mov      x8, x0
005B06894  ldp      x21, x20, [x8, #0x20]
005B06898  ldr      x22, [x8, #0x30]
005B0689C  ldr      x9, [x9, #0xc0]
005B068A0  mov      x19, x1
005B068A4  ldr      x0, [x9, #0x18]
005B068A8  ldrb     w9, [x0, #0x135]
005B068AC  tbnz     w9, #0, #0x5b068b4
005B068B0  bl       #0x3a7e60c ; 
005B068B4  bl       #0x382bfa0 ; 
005B068B8  ldr      x8, [x19, #0x20]
005B068BC  mov      x1, x21
005B068C0  mov      x2, x20
005B068C4  mov      x3, x22
005B068C8  ldr      x8, [x8, #0xc0]
005B068CC  mov      x19, x0
005B068D0  ldr      x4, [x8, #0x30]
005B068D4  bl       #0x5b06818 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Int32Enum>$$.ctor
005B068D8  mov      x0, x19
005B068DC  ldp      x20, x19, [sp, #0x20]
005B068E0  ldp      x22, x21, [sp, #0x10]
005B068E4  ldr      x30, [sp], #0x30
005B068E8  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Int32Enum>$$MoveNext
; RVA 0x5B068EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B068EC  sub      sp, sp, #0x110
005B068F0  stp      x29, x30, [sp, #0xe0]
005B068F4  stp      x22, x21, [sp, #0xf0]
005B068F8  stp      x20, x19, [sp, #0x100]
005B068FC  ldr      w8, [x0, #0x14]
005B06900  mov      x19, x0
005B06904  mov      x20, x1
005B06908  cmp      w8, #2
005B0690C  b.eq     #0x5b0696c
005B06910  cmp      w8, #1
005B06914  b.ne     #0x5b06a44
005B06918  ldr      x0, [x19, #0x20]
005B0691C  cbz      x0, #0x5b06a5c
005B06920  ldr      x8, [x20, #0x20]
005B06924  ldr      x8, [x8, #0xc0]
005B06928  ldr      x1, [x8, #0x40]
005B0692C  add      x8, sp, #0x40
005B06930  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B06934  add      x0, sp, #0x90
005B06938  add      x1, sp, #0x40
005B0693C  mov      w2, #0x48
005B06940  bl       #0x89edad0 ; 
005B06944  add      x21, x19, #0x38
005B06948  add      x1, sp, #0x90
005B0694C  mov      w2, #0x48
005B06950  mov      x0, x21
005B06954  bl       #0x89edad0 ; 
005B06958  mov      x0, x21
005B0695C  mov      x1, xzr
005B06960  bl       #0x382bcb8 ; 
005B06964  mov      w8, #2
005B06968  str      w8, [x19, #0x14]
005B0696C  add      x21, x19, #0x38
005B06970  add      x22, x19, #0x48
005B06974  ldr      x8, [x20, #0x20]
005B06978  mov      x0, x21
005B0697C  ldr      x8, [x8, #0xc0]
005B06980  ldr      x1, [x8, #0x80]
005B06984  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B06988  tbz      w0, #0, #0x5b06a34
005B0698C  ldr      x8, [x22, #0x30]
005B06990  ldp      q1, q0, [x22, #0x10]
005B06994  ldr      q2, [x22]
005B06998  str      x8, [sp, #0x70]
005B0699C  stp      q1, q0, [sp, #0x50]
005B069A0  str      q2, [sp, #0x40]
005B069A4  ldr      x8, [x19, #0x28]
005B069A8  cbz      x8, #0x5b069dc
005B069AC  ldp      q0, q1, [sp, #0x40]
005B069B0  ldr      q2, [sp, #0x60]
005B069B4  ldr      x10, [sp, #0x70]
005B069B8  ldr      x9, [x8, #0x18]
005B069BC  ldr      x0, [x8, #0x40]
005B069C0  stp      q0, q1, [sp, #0x90]
005B069C4  str      q2, [sp, #0xb0]
005B069C8  str      x10, [sp, #0xc0]
005B069CC  ldr      x2, [x8, #0x28]
005B069D0  add      x1, sp, #0x90
005B069D4  blr      x9
005B069D8  tbz      w0, #0, #0x5b06974
005B069DC  ldr      x8, [x19, #0x30]
005B069E0  ldp      q0, q1, [sp, #0x40]
005B069E4  ldr      q2, [sp, #0x60]
005B069E8  ldr      x9, [sp, #0x70]
005B069EC  stp      q0, q1, [sp]
005B069F0  str      q2, [sp, #0x20]
005B069F4  str      x9, [sp, #0x30]
005B069F8  cbz      x8, #0x5b06a5c
005B069FC  ldp      q0, q1, [sp]
005B06A00  ldr      q2, [sp, #0x20]
005B06A04  ldr      x10, [sp, #0x30]
005B06A08  ldr      x9, [x8, #0x18]
005B06A0C  ldr      x0, [x8, #0x40]
005B06A10  stp      q0, q1, [sp, #0x90]
005B06A14  str      q2, [sp, #0xb0]
005B06A18  str      x10, [sp, #0xc0]
005B06A1C  ldr      x2, [x8, #0x28]
005B06A20  add      x1, sp, #0x90
005B06A24  blr      x9
005B06A28  str      w0, [x19, #0x18]
005B06A2C  mov      w0, #1
005B06A30  b        #0x5b06a48 ; 
005B06A34  ldr      x8, [x19]
005B06A38  mov      x0, x19
005B06A3C  ldp      x9, x1, [x8, #0x1f8]
005B06A40  blr      x9
005B06A44  mov      w0, wzr
005B06A48  ldp      x20, x19, [sp, #0x100]
005B06A4C  ldp      x22, x21, [sp, #0xf0]
005B06A50  ldp      x29, x30, [sp, #0xe0]
005B06A54  add      sp, sp, #0x110
005B06A58  ret      
005B06A5C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, Int32Enum>$$Where
; RVA 0x5B06A60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06A60  stp      x30, x21, [sp, #-0x20]!
005B06A64  stp      x20, x19, [sp, #0x10]
005B06A68  ldr      x8, [x2, #0x20]
005B06A6C  mov      x20, x2
005B06A70  mov      x19, x1
005B06A74  mov      x21, x0
005B06A78  ldr      x8, [x8, #0xc0]
005B06A7C  ldr      x8, [x8, #0x98]
005B06A80  ldrb     w9, [x8, #0x135]
005B06A84  tbnz     w9, #0, #0x5b06a94
005B06A88  mov      x0, x8
005B06A8C  bl       #0x3a7e60c ; 
005B06A90  mov      x8, x0
005B06A94  mov      x0, x8
005B06A98  bl       #0x382bfa0 ; 
005B06A9C  ldr      x8, [x20, #0x20]
005B06AA0  mov      x1, x21
005B06AA4  mov      x2, x19
005B06AA8  mov      x20, x0
005B06AAC  ldr      x8, [x8, #0xc0]
005B06AB0  ldr      x3, [x8, #0xa0]
005B06AB4  bl       #0x59ca294 ; System.Linq.Enumerable.WhereEnumerableIterator<Int32Enum>$$.ctor
005B06AB8  mov      x0, x20
005B06ABC  ldp      x20, x19, [sp, #0x10]
005B06AC0  ldp      x30, x21, [sp], #0x20
005B06AC4  ret      

