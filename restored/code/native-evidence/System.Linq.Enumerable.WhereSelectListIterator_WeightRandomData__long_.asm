; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, long>$$.ctor
; RVA 0x5B06AC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06AC8  str      x30, [sp, #-0x30]!
005B06ACC  stp      x22, x21, [sp, #0x10]
005B06AD0  stp      x20, x19, [sp, #0x20]
005B06AD4  ldr      x8, [x4, #0x20]
005B06AD8  mov      x21, x1
005B06ADC  mov      x19, x3
005B06AE0  mov      x20, x2
005B06AE4  ldr      x8, [x8, #0xc0]
005B06AE8  mov      x22, x0
005B06AEC  ldr      x1, [x8]
005B06AF0  bl       #0x4a745f4 ; System.Linq.Enumerable.Iterator<long>$$.ctor
005B06AF4  mov      x0, x22
005B06AF8  str      x21, [x0, #0x20]!
005B06AFC  mov      x1, x21
005B06B00  bl       #0x382bcb8 ; 
005B06B04  mov      x0, x22
005B06B08  str      x20, [x0, #0x28]!
005B06B0C  mov      x1, x20
005B06B10  bl       #0x382bcb8 ; 
005B06B14  str      x19, [x22, #0x30]!
005B06B18  mov      x0, x22
005B06B1C  mov      x1, x19
005B06B20  ldp      x20, x19, [sp, #0x20]
005B06B24  ldp      x22, x21, [sp, #0x10]
005B06B28  ldr      x30, [sp], #0x30
005B06B2C  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, long>$$Clone
; RVA 0x5B06B30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06B30  str      x30, [sp, #-0x30]!
005B06B34  stp      x22, x21, [sp, #0x10]
005B06B38  stp      x20, x19, [sp, #0x20]
005B06B3C  ldr      x9, [x1, #0x20]
005B06B40  mov      x8, x0
005B06B44  ldp      x21, x20, [x8, #0x20]
005B06B48  ldr      x22, [x8, #0x30]
005B06B4C  ldr      x9, [x9, #0xc0]
005B06B50  mov      x19, x1
005B06B54  ldr      x0, [x9, #0x18]
005B06B58  ldrb     w9, [x0, #0x135]
005B06B5C  tbnz     w9, #0, #0x5b06b64
005B06B60  bl       #0x3a7e60c ; 
005B06B64  bl       #0x382bfa0 ; 
005B06B68  ldr      x8, [x19, #0x20]
005B06B6C  mov      x1, x21
005B06B70  mov      x2, x20
005B06B74  mov      x3, x22
005B06B78  ldr      x8, [x8, #0xc0]
005B06B7C  mov      x19, x0
005B06B80  ldr      x4, [x8, #0x30]
005B06B84  bl       #0x5b06ac8 ; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, long>$$.ctor
005B06B88  mov      x0, x19
005B06B8C  ldp      x20, x19, [sp, #0x20]
005B06B90  ldp      x22, x21, [sp, #0x10]
005B06B94  ldr      x30, [sp], #0x30
005B06B98  ret      

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, long>$$MoveNext
; RVA 0x5B06B9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06B9C  sub      sp, sp, #0x110
005B06BA0  stp      x29, x30, [sp, #0xe0]
005B06BA4  stp      x22, x21, [sp, #0xf0]
005B06BA8  stp      x20, x19, [sp, #0x100]
005B06BAC  ldr      w8, [x0, #0x14]
005B06BB0  mov      x19, x0
005B06BB4  mov      x20, x1
005B06BB8  cmp      w8, #2
005B06BBC  b.eq     #0x5b06c1c
005B06BC0  cmp      w8, #1
005B06BC4  b.ne     #0x5b06cf4
005B06BC8  ldr      x0, [x19, #0x20]
005B06BCC  cbz      x0, #0x5b06d0c
005B06BD0  ldr      x8, [x20, #0x20]
005B06BD4  ldr      x8, [x8, #0xc0]
005B06BD8  ldr      x1, [x8, #0x40]
005B06BDC  add      x8, sp, #0x40
005B06BE0  bl       #0x4ea0bc0 ; System.Collections.Generic.List<WeightRandomData>$$GetEnumerator
005B06BE4  add      x0, sp, #0x90
005B06BE8  add      x1, sp, #0x40
005B06BEC  mov      w2, #0x48
005B06BF0  bl       #0x89edad0 ; 
005B06BF4  add      x21, x19, #0x38
005B06BF8  add      x1, sp, #0x90
005B06BFC  mov      w2, #0x48
005B06C00  mov      x0, x21
005B06C04  bl       #0x89edad0 ; 
005B06C08  mov      x0, x21
005B06C0C  mov      x1, xzr
005B06C10  bl       #0x382bcb8 ; 
005B06C14  mov      w8, #2
005B06C18  str      w8, [x19, #0x14]
005B06C1C  add      x21, x19, #0x38
005B06C20  add      x22, x19, #0x48
005B06C24  ldr      x8, [x20, #0x20]
005B06C28  mov      x0, x21
005B06C2C  ldr      x8, [x8, #0xc0]
005B06C30  ldr      x1, [x8, #0x80]
005B06C34  bl       #0x60f84e0 ; System.Collections.Generic.List.Enumerator<WeightRandomData>$$MoveNext
005B06C38  tbz      w0, #0, #0x5b06ce4
005B06C3C  ldr      x8, [x22, #0x30]
005B06C40  ldp      q1, q0, [x22, #0x10]
005B06C44  ldr      q2, [x22]
005B06C48  str      x8, [sp, #0x70]
005B06C4C  stp      q1, q0, [sp, #0x50]
005B06C50  str      q2, [sp, #0x40]
005B06C54  ldr      x8, [x19, #0x28]
005B06C58  cbz      x8, #0x5b06c8c
005B06C5C  ldp      q0, q1, [sp, #0x40]
005B06C60  ldr      q2, [sp, #0x60]
005B06C64  ldr      x10, [sp, #0x70]
005B06C68  ldr      x9, [x8, #0x18]
005B06C6C  ldr      x0, [x8, #0x40]
005B06C70  stp      q0, q1, [sp, #0x90]
005B06C74  str      q2, [sp, #0xb0]
005B06C78  str      x10, [sp, #0xc0]
005B06C7C  ldr      x2, [x8, #0x28]
005B06C80  add      x1, sp, #0x90
005B06C84  blr      x9
005B06C88  tbz      w0, #0, #0x5b06c24
005B06C8C  ldr      x8, [x19, #0x30]
005B06C90  ldp      q0, q1, [sp, #0x40]
005B06C94  ldr      q2, [sp, #0x60]
005B06C98  ldr      x9, [sp, #0x70]
005B06C9C  stp      q0, q1, [sp]
005B06CA0  str      q2, [sp, #0x20]
005B06CA4  str      x9, [sp, #0x30]
005B06CA8  cbz      x8, #0x5b06d0c
005B06CAC  ldp      q0, q1, [sp]
005B06CB0  ldr      q2, [sp, #0x20]
005B06CB4  ldr      x10, [sp, #0x30]
005B06CB8  ldr      x9, [x8, #0x18]
005B06CBC  ldr      x0, [x8, #0x40]
005B06CC0  stp      q0, q1, [sp, #0x90]
005B06CC4  str      q2, [sp, #0xb0]
005B06CC8  str      x10, [sp, #0xc0]
005B06CCC  ldr      x2, [x8, #0x28]
005B06CD0  add      x1, sp, #0x90
005B06CD4  blr      x9
005B06CD8  str      x0, [x19, #0x18]
005B06CDC  mov      w0, #1
005B06CE0  b        #0x5b06cf8 ; 
005B06CE4  ldr      x8, [x19]
005B06CE8  mov      x0, x19
005B06CEC  ldp      x9, x1, [x8, #0x1f8]
005B06CF0  blr      x9
005B06CF4  mov      w0, wzr
005B06CF8  ldp      x20, x19, [sp, #0x100]
005B06CFC  ldp      x22, x21, [sp, #0xf0]
005B06D00  ldp      x29, x30, [sp, #0xe0]
005B06D04  add      sp, sp, #0x110
005B06D08  ret      
005B06D0C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectListIterator<WeightRandomData, long>$$Where
; RVA 0x5B06D10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005B06D10  stp      x30, x21, [sp, #-0x20]!
005B06D14  stp      x20, x19, [sp, #0x10]
005B06D18  ldr      x8, [x2, #0x20]
005B06D1C  mov      x20, x2
005B06D20  mov      x19, x1
005B06D24  mov      x21, x0
005B06D28  ldr      x8, [x8, #0xc0]
005B06D2C  ldr      x8, [x8, #0x98]
005B06D30  ldrb     w9, [x8, #0x135]
005B06D34  tbnz     w9, #0, #0x5b06d44
005B06D38  mov      x0, x8
005B06D3C  bl       #0x3a7e60c ; 
005B06D40  mov      x8, x0
005B06D44  mov      x0, x8
005B06D48  bl       #0x382bfa0 ; 
005B06D4C  ldr      x8, [x20, #0x20]
005B06D50  mov      x1, x21
005B06D54  mov      x2, x19
005B06D58  mov      x20, x0
005B06D5C  ldr      x8, [x8, #0xc0]
005B06D60  ldr      x3, [x8, #0xa0]
005B06D64  bl       #0x59ca6a8 ; System.Linq.Enumerable.WhereEnumerableIterator<long>$$.ctor
005B06D68  mov      x0, x20
005B06D6C  ldp      x20, x19, [sp, #0x10]
005B06D70  ldp      x30, x21, [sp], #0x20
005B06D74  ret      

