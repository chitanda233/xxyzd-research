; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, ValueTuple<int, int>>$$.ctor
; RVA 0x5A0B9A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0B9A8  str      x30, [sp, #-0x30]!
005A0B9AC  stp      x22, x21, [sp, #0x10]
005A0B9B0  stp      x20, x19, [sp, #0x20]
005A0B9B4  ldr      x8, [x4, #0x20]
005A0B9B8  mov      x21, x1
005A0B9BC  mov      x19, x3
005A0B9C0  mov      x20, x2
005A0B9C4  ldr      x8, [x8, #0xc0]
005A0B9C8  mov      x22, x0
005A0B9CC  ldr      x1, [x8]
005A0B9D0  bl       #0x4a72aec ; System.Linq.Enumerable.Iterator<ValueTuple<int, int>>$$.ctor
005A0B9D4  mov      x0, x22
005A0B9D8  str      x21, [x0, #0x20]!
005A0B9DC  mov      x1, x21
005A0B9E0  bl       #0x382bcb8 ; 
005A0B9E4  mov      x0, x22
005A0B9E8  str      x20, [x0, #0x28]!
005A0B9EC  mov      x1, x20
005A0B9F0  bl       #0x382bcb8 ; 
005A0B9F4  str      x19, [x22, #0x30]!
005A0B9F8  mov      x0, x22
005A0B9FC  mov      x1, x19
005A0BA00  ldp      x20, x19, [sp, #0x20]
005A0BA04  ldp      x22, x21, [sp, #0x10]
005A0BA08  ldr      x30, [sp], #0x30
005A0BA0C  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, ValueTuple<int, int>>$$Clone
; RVA 0x5A0BA10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0BA10  str      x30, [sp, #-0x30]!
005A0BA14  stp      x22, x21, [sp, #0x10]
005A0BA18  stp      x20, x19, [sp, #0x20]
005A0BA1C  ldr      x9, [x1, #0x20]
005A0BA20  mov      x8, x0
005A0BA24  ldp      x21, x20, [x8, #0x20]
005A0BA28  ldr      x22, [x8, #0x30]
005A0BA2C  ldr      x9, [x9, #0xc0]
005A0BA30  mov      x19, x1
005A0BA34  ldr      x0, [x9, #0x18]
005A0BA38  ldrb     w9, [x0, #0x135]
005A0BA3C  tbnz     w9, #0, #0x5a0ba44
005A0BA40  bl       #0x3a7e60c ; 
005A0BA44  bl       #0x382bfa0 ; 
005A0BA48  ldr      x8, [x19, #0x20]
005A0BA4C  mov      x1, x21
005A0BA50  mov      x2, x20
005A0BA54  mov      x3, x22
005A0BA58  ldr      x8, [x8, #0xc0]
005A0BA5C  mov      x19, x0
005A0BA60  ldr      x4, [x8, #0x30]
005A0BA64  bl       #0x5a0b9a8 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, ValueTuple<int, int>>$$.ctor
005A0BA68  mov      x0, x19
005A0BA6C  ldp      x20, x19, [sp, #0x20]
005A0BA70  ldp      x22, x21, [sp, #0x10]
005A0BA74  ldr      x30, [sp], #0x30
005A0BA78  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, ValueTuple<int, int>>$$MoveNext
; RVA 0x5A0BA7C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0BA7C  sub      sp, sp, #0xe0
005A0BA80  str      x30, [sp, #0xc0]
005A0BA84  stp      x20, x19, [sp, #0xd0]
005A0BA88  ldr      w8, [x0, #0x14]
005A0BA8C  cmp      w8, #1
005A0BA90  b.ne     #0x5a0bb80
005A0BA94  mov      x19, x0
005A0BA98  mov      w20, #0x38
005A0BA9C  ldr      x9, [x19, #0x20]
005A0BAA0  cbz      x9, #0x5a0bb98
005A0BAA4  ldrsw    x8, [x19, #0x38]
005A0BAA8  ldr      w10, [x9, #0x18]
005A0BAAC  cmp      w8, w10
005A0BAB0  b.ge     #0x5a0bb70
005A0BAB4  cmp      w8, w10
005A0BAB8  b.hs     #0x5a0bb94
005A0BABC  madd     x9, x8, x20, x9
005A0BAC0  ldr      x10, [x9, #0x50]
005A0BAC4  ldp      q1, q0, [x9, #0x30]
005A0BAC8  ldr      q2, [x9, #0x20]
005A0BACC  add      w8, w8, #1
005A0BAD0  str      x10, [sp, #0x70]
005A0BAD4  stp      q1, q0, [sp, #0x50]
005A0BAD8  str      q2, [sp, #0x40]
005A0BADC  ldr      x9, [x19, #0x28]
005A0BAE0  str      w8, [x19, #0x38]
005A0BAE4  cbz      x9, #0x5a0bb18
005A0BAE8  ldp      q0, q1, [sp, #0x40]
005A0BAEC  ldr      q2, [sp, #0x60]
005A0BAF0  ldr      x10, [sp, #0x70]
005A0BAF4  ldr      x8, [x9, #0x18]
005A0BAF8  ldr      x0, [x9, #0x40]
005A0BAFC  stp      q0, q1, [sp, #0x80]
005A0BB00  str      q2, [sp, #0xa0]
005A0BB04  str      x10, [sp, #0xb0]
005A0BB08  ldr      x2, [x9, #0x28]
005A0BB0C  add      x1, sp, #0x80
005A0BB10  blr      x8
005A0BB14  tbz      w0, #0, #0x5a0ba9c
005A0BB18  ldr      x8, [x19, #0x30]
005A0BB1C  ldp      q0, q1, [sp, #0x40]
005A0BB20  ldr      q2, [sp, #0x60]
005A0BB24  ldr      x9, [sp, #0x70]
005A0BB28  stp      q0, q1, [sp]
005A0BB2C  str      q2, [sp, #0x20]
005A0BB30  str      x9, [sp, #0x30]
005A0BB34  cbz      x8, #0x5a0bb98
005A0BB38  ldp      q0, q1, [sp]
005A0BB3C  ldr      q2, [sp, #0x20]
005A0BB40  ldr      x10, [sp, #0x30]
005A0BB44  ldr      x9, [x8, #0x18]
005A0BB48  ldr      x0, [x8, #0x40]
005A0BB4C  stp      q0, q1, [sp, #0x80]
005A0BB50  str      q2, [sp, #0xa0]
005A0BB54  str      x10, [sp, #0xb0]
005A0BB58  ldr      x2, [x8, #0x28]
005A0BB5C  add      x1, sp, #0x80
005A0BB60  blr      x9
005A0BB64  str      x0, [x19, #0x18]
005A0BB68  mov      w0, #1
005A0BB6C  b        #0x5a0bb84 ; 
005A0BB70  ldr      x8, [x19]
005A0BB74  mov      x0, x19
005A0BB78  ldp      x9, x1, [x8, #0x1f8]
005A0BB7C  blr      x9
005A0BB80  mov      w0, wzr
005A0BB84  ldp      x20, x19, [sp, #0xd0]
005A0BB88  ldr      x30, [sp, #0xc0]
005A0BB8C  add      sp, sp, #0xe0
005A0BB90  ret      
005A0BB94  bl       #0x382bfc0 ; 
005A0BB98  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, ValueTuple<int, int>>$$Where
; RVA 0x5A0BB9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0BB9C  stp      x30, x21, [sp, #-0x20]!
005A0BBA0  stp      x20, x19, [sp, #0x10]
005A0BBA4  ldr      x8, [x2, #0x20]
005A0BBA8  mov      x20, x2
005A0BBAC  mov      x19, x1
005A0BBB0  mov      x21, x0
005A0BBB4  ldr      x8, [x8, #0xc0]
005A0BBB8  ldr      x8, [x8, #0x70]
005A0BBBC  ldrb     w9, [x8, #0x135]
005A0BBC0  tbnz     w9, #0, #0x5a0bbd0
005A0BBC4  mov      x0, x8
005A0BBC8  bl       #0x3a7e60c ; 
005A0BBCC  mov      x8, x0
005A0BBD0  mov      x0, x8
005A0BBD4  bl       #0x382bfa0 ; 
005A0BBD8  ldr      x8, [x20, #0x20]
005A0BBDC  mov      x1, x21
005A0BBE0  mov      x2, x19
005A0BBE4  mov      x20, x0
005A0BBE8  ldr      x8, [x8, #0xc0]
005A0BBEC  ldr      x3, [x8, #0x78]
005A0BBF0  bl       #0x59c431c ; System.Linq.Enumerable.WhereEnumerableIterator<ValueTuple<int, int>>$$.ctor
005A0BBF4  mov      x0, x20
005A0BBF8  ldp      x20, x19, [sp, #0x10]
005A0BBFC  ldp      x30, x21, [sp], #0x20
005A0BC00  ret      

