; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, ValueTuple<int, int>>$$.ctor
; RVA 0x5B04A2C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B04A2C  str      x30, [sp, #-0x30]!
005B04A30  stp      x22, x21, [sp, #0x10]
005B04A34  stp      x20, x19, [sp, #0x20]
005B04A38  ldr      x8, [x4, #0x20]
005B04A3C  mov      x21, x1
005B04A40  mov      x19, x3
005B04A44  mov      x20, x2
005B04A48  ldr      x8, [x8, #0xc0]
005B04A4C  mov      x22, x0
005B04A50  ldr      x1, [x8]
005B04A54  bl       #0x4a72aec ; System.Linq.Enumerable.Iterator<ValueTuple<int, int>>$$.ctor
005B04A58  mov      x0, x22
005B04A5C  str      x21, [x0, #0x20]!
005B04A60  mov      x1, x21
005B04A64  bl       #0x382bcb8 ; 
005B04A68  mov      x0, x22
005B04A6C  str      x20, [x0, #0x28]!
005B04A70  mov      x1, x20
005B04A74  bl       #0x382bcb8 ; 
005B04A78  str      x19, [x22, #0x30]!
005B04A7C  mov      x0, x22
005B04A80  mov      x1, x19
005B04A84  ldp      x20, x19, [sp, #0x20]
005B04A88  ldp      x22, x21, [sp, #0x10]
005B04A8C  ldr      x30, [sp], #0x30
005B04A90  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, ValueTuple<int, int>>$$Clone
; RVA 0x5B04A94; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B04A94  str      x30, [sp, #-0x30]!
005B04A98  stp      x22, x21, [sp, #0x10]
005B04A9C  stp      x20, x19, [sp, #0x20]
005B04AA0  ldr      x9, [x1, #0x20]
005B04AA4  mov      x8, x0
005B04AA8  ldp      x21, x20, [x8, #0x20]
005B04AAC  ldr      x22, [x8, #0x30]
005B04AB0  ldr      x9, [x9, #0xc0]
005B04AB4  mov      x19, x1
005B04AB8  ldr      x0, [x9, #0x18]
005B04ABC  ldrb     w9, [x0, #0x135]
005B04AC0  tbnz     w9, #0, #0x5b04ac8
005B04AC4  bl       #0x3a7e60c ; 
005B04AC8  bl       #0x382bfa0 ; 
005B04ACC  ldr      x8, [x19, #0x20]
005B04AD0  mov      x1, x21
005B04AD4  mov      x2, x20
005B04AD8  mov      x3, x22
005B04ADC  ldr      x8, [x8, #0xc0]
005B04AE0  mov      x19, x0
005B04AE4  ldr      x4, [x8, #0x30]
005B04AE8  bl       #0x5b04a2c ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, ValueTuple<int, int>>$$.ctor
005B04AEC  mov      x0, x19
005B04AF0  ldp      x20, x19, [sp, #0x20]
005B04AF4  ldp      x22, x21, [sp, #0x10]
005B04AF8  ldr      x30, [sp], #0x30
005B04AFC  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, ValueTuple<int, int>>$$MoveNext
; RVA 0x5B04B00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B04B00  sub      sp, sp, #0x110
005B04B04  stp      x29, x30, [sp, #0xe0]
005B04B08  stp      x22, x21, [sp, #0xf0]
005B04B0C  stp      x20, x19, [sp, #0x100]
005B04B10  ldr      w8, [x0, #0x14]
005B04B14  mov      x19, x0
005B04B18  mov      x20, x1
005B04B1C  cmp      w8, #2
005B04B20  b.eq     #0x5b04b80
005B04B24  cmp      w8, #1
005B04B28  b.ne     #0x5b04c58
005B04B2C  ldr      x0, [x19, #0x20]
005B04B30  cbz      x0, #0x5b04c70
005B04B34  ldr      x8, [x20, #0x20]
005B04B38  ldr      x8, [x8, #0xc0]
005B04B3C  ldr      x1, [x8, #0x40]
005B04B40  add      x8, sp, #0x40
005B04B44  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B04B48  add      x0, sp, #0x90
005B04B4C  add      x1, sp, #0x40
005B04B50  mov      w2, #0x48
005B04B54  bl       #0x89edad0 ; 
005B04B58  add      x21, x19, #0x38
005B04B5C  add      x1, sp, #0x90
005B04B60  mov      w2, #0x48
005B04B64  mov      x0, x21
005B04B68  bl       #0x89edad0 ; 
005B04B6C  mov      x0, x21
005B04B70  mov      x1, xzr
005B04B74  bl       #0x382bcb8 ; 
005B04B78  mov      w8, #2
005B04B7C  str      w8, [x19, #0x14]
005B04B80  add      x21, x19, #0x38
005B04B84  add      x22, x19, #0x48
005B04B88  ldr      x8, [x20, #0x20]
005B04B8C  mov      x0, x21
005B04B90  ldr      x8, [x8, #0xc0]
005B04B94  ldr      x1, [x8, #0x80]
005B04B98  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B04B9C  tbz      w0, #0, #0x5b04c48
005B04BA0  ldr      x8, [x22, #0x30]
005B04BA4  ldp      q1, q0, [x22, #0x10]
005B04BA8  ldr      q2, [x22]
005B04BAC  str      x8, [sp, #0x70]
005B04BB0  stp      q1, q0, [sp, #0x50]
005B04BB4  str      q2, [sp, #0x40]
005B04BB8  ldr      x8, [x19, #0x28]
005B04BBC  cbz      x8, #0x5b04bf0
005B04BC0  ldp      q0, q1, [sp, #0x40]
005B04BC4  ldr      q2, [sp, #0x60]
005B04BC8  ldr      x10, [sp, #0x70]
005B04BCC  ldr      x9, [x8, #0x18]
005B04BD0  ldr      x0, [x8, #0x40]
005B04BD4  stp      q0, q1, [sp, #0x90]
005B04BD8  str      q2, [sp, #0xb0]
005B04BDC  str      x10, [sp, #0xc0]
005B04BE0  ldr      x2, [x8, #0x28]
005B04BE4  add      x1, sp, #0x90
005B04BE8  blr      x9
005B04BEC  tbz      w0, #0, #0x5b04b88
005B04BF0  ldr      x8, [x19, #0x30]
005B04BF4  ldp      q0, q1, [sp, #0x40]
005B04BF8  ldr      q2, [sp, #0x60]
005B04BFC  ldr      x9, [sp, #0x70]
005B04C00  stp      q0, q1, [sp]
005B04C04  str      q2, [sp, #0x20]
005B04C08  str      x9, [sp, #0x30]
005B04C0C  cbz      x8, #0x5b04c70
005B04C10  ldp      q0, q1, [sp]
005B04C14  ldr      q2, [sp, #0x20]
005B04C18  ldr      x10, [sp, #0x30]
005B04C1C  ldr      x9, [x8, #0x18]
005B04C20  ldr      x0, [x8, #0x40]
005B04C24  stp      q0, q1, [sp, #0x90]
005B04C28  str      q2, [sp, #0xb0]
005B04C2C  str      x10, [sp, #0xc0]
005B04C30  ldr      x2, [x8, #0x28]
005B04C34  add      x1, sp, #0x90
005B04C38  blr      x9
005B04C3C  str      x0, [x19, #0x18]
005B04C40  mov      w0, #1
005B04C44  b        #0x5b04c5c ; 
005B04C48  ldr      x8, [x19]
005B04C4C  mov      x0, x19
005B04C50  ldp      x9, x1, [x8, #0x1f8]
005B04C54  blr      x9
005B04C58  mov      w0, wzr
005B04C5C  ldp      x20, x19, [sp, #0x100]
005B04C60  ldp      x22, x21, [sp, #0xf0]
005B04C64  ldp      x29, x30, [sp, #0xe0]
005B04C68  add      sp, sp, #0x110
005B04C6C  ret      
005B04C70  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, ValueTuple<int, int>>$$Where
; RVA 0x5B04C74; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B04C74  stp      x30, x21, [sp, #-0x20]!
005B04C78  stp      x20, x19, [sp, #0x10]
005B04C7C  ldr      x8, [x2, #0x20]
005B04C80  mov      x20, x2
005B04C84  mov      x19, x1
005B04C88  mov      x21, x0
005B04C8C  ldr      x8, [x8, #0xc0]
005B04C90  ldr      x8, [x8, #0x98]
005B04C94  ldrb     w9, [x8, #0x135]
005B04C98  tbnz     w9, #0, #0x5b04ca8
005B04C9C  mov      x0, x8
005B04CA0  bl       #0x3a7e60c ; 
005B04CA4  mov      x8, x0
005B04CA8  mov      x0, x8
005B04CAC  bl       #0x382bfa0 ; 
005B04CB0  ldr      x8, [x20, #0x20]
005B04CB4  mov      x1, x21
005B04CB8  mov      x2, x19
005B04CBC  mov      x20, x0
005B04CC0  ldr      x8, [x8, #0xc0]
005B04CC4  ldr      x3, [x8, #0xa0]
005B04CC8  bl       #0x59c431c ; System.Linq.Enumerable.WhereEnumerableIterator<ValueTuple<int, int>>$$.ctor
005B04CCC  mov      x0, x20
005B04CD0  ldp      x20, x19, [sp, #0x10]
005B04CD4  ldp      x30, x21, [sp], #0x20
005B04CD8  ret      

