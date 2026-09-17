; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, bool>$$.ctor
; RVA 0x5A0BE90; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0BE90  str      x30, [sp, #-0x30]!
005A0BE94  stp      x22, x21, [sp, #0x10]
005A0BE98  stp      x20, x19, [sp, #0x20]
005A0BE9C  ldr      x8, [x4, #0x20]
005A0BEA0  mov      x21, x1
005A0BEA4  mov      x19, x3
005A0BEA8  mov      x20, x2
005A0BEAC  ldr      x8, [x8, #0xc0]
005A0BEB0  mov      x22, x0
005A0BEB4  ldr      x1, [x8]
005A0BEB8  bl       #0x4a72f80 ; System.Linq.Enumerable.Iterator<bool>$$.ctor
005A0BEBC  mov      x0, x22
005A0BEC0  str      x21, [x0, #0x20]!
005A0BEC4  mov      x1, x21
005A0BEC8  bl       #0x382bcb8 ; 
005A0BECC  mov      x0, x22
005A0BED0  str      x20, [x0, #0x28]!
005A0BED4  mov      x1, x20
005A0BED8  bl       #0x382bcb8 ; 
005A0BEDC  str      x19, [x22, #0x30]!
005A0BEE0  mov      x0, x22
005A0BEE4  mov      x1, x19
005A0BEE8  ldp      x20, x19, [sp, #0x20]
005A0BEEC  ldp      x22, x21, [sp, #0x10]
005A0BEF0  ldr      x30, [sp], #0x30
005A0BEF4  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, bool>$$Clone
; RVA 0x5A0BEF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0BEF8  str      x30, [sp, #-0x30]!
005A0BEFC  stp      x22, x21, [sp, #0x10]
005A0BF00  stp      x20, x19, [sp, #0x20]
005A0BF04  ldr      x9, [x1, #0x20]
005A0BF08  mov      x8, x0
005A0BF0C  ldp      x21, x20, [x8, #0x20]
005A0BF10  ldr      x22, [x8, #0x30]
005A0BF14  ldr      x9, [x9, #0xc0]
005A0BF18  mov      x19, x1
005A0BF1C  ldr      x0, [x9, #0x18]
005A0BF20  ldrb     w9, [x0, #0x135]
005A0BF24  tbnz     w9, #0, #0x5a0bf2c
005A0BF28  bl       #0x3a7e60c ; 
005A0BF2C  bl       #0x382bfa0 ; 
005A0BF30  ldr      x8, [x19, #0x20]
005A0BF34  mov      x1, x21
005A0BF38  mov      x2, x20
005A0BF3C  mov      x3, x22
005A0BF40  ldr      x8, [x8, #0xc0]
005A0BF44  mov      x19, x0
005A0BF48  ldr      x4, [x8, #0x30]
005A0BF4C  bl       #0x5a0be90 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, bool>$$.ctor
005A0BF50  mov      x0, x19
005A0BF54  ldp      x20, x19, [sp, #0x20]
005A0BF58  ldp      x22, x21, [sp, #0x10]
005A0BF5C  ldr      x30, [sp], #0x30
005A0BF60  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, bool>$$MoveNext
; RVA 0x5A0BF64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0BF64  sub      sp, sp, #0xe0
005A0BF68  str      x30, [sp, #0xc0]
005A0BF6C  stp      x20, x19, [sp, #0xd0]
005A0BF70  ldr      w8, [x0, #0x14]
005A0BF74  cmp      w8, #1
005A0BF78  b.ne     #0x5a0c06c
005A0BF7C  mov      x19, x0
005A0BF80  mov      w20, #0x38
005A0BF84  ldr      x9, [x19, #0x20]
005A0BF88  cbz      x9, #0x5a0c084
005A0BF8C  ldrsw    x8, [x19, #0x38]
005A0BF90  ldr      w10, [x9, #0x18]
005A0BF94  cmp      w8, w10
005A0BF98  b.ge     #0x5a0c05c
005A0BF9C  cmp      w8, w10
005A0BFA0  b.hs     #0x5a0c080
005A0BFA4  madd     x9, x8, x20, x9
005A0BFA8  ldr      x10, [x9, #0x50]
005A0BFAC  ldp      q1, q0, [x9, #0x30]
005A0BFB0  ldr      q2, [x9, #0x20]
005A0BFB4  add      w8, w8, #1
005A0BFB8  str      x10, [sp, #0x70]
005A0BFBC  stp      q1, q0, [sp, #0x50]
005A0BFC0  str      q2, [sp, #0x40]
005A0BFC4  ldr      x9, [x19, #0x28]
005A0BFC8  str      w8, [x19, #0x38]
005A0BFCC  cbz      x9, #0x5a0c000
005A0BFD0  ldp      q0, q1, [sp, #0x40]
005A0BFD4  ldr      q2, [sp, #0x60]
005A0BFD8  ldr      x10, [sp, #0x70]
005A0BFDC  ldr      x8, [x9, #0x18]
005A0BFE0  ldr      x0, [x9, #0x40]
005A0BFE4  stp      q0, q1, [sp, #0x80]
005A0BFE8  str      q2, [sp, #0xa0]
005A0BFEC  str      x10, [sp, #0xb0]
005A0BFF0  ldr      x2, [x9, #0x28]
005A0BFF4  add      x1, sp, #0x80
005A0BFF8  blr      x8
005A0BFFC  tbz      w0, #0, #0x5a0bf84
005A0C000  ldr      x8, [x19, #0x30]
005A0C004  ldp      q0, q1, [sp, #0x40]
005A0C008  ldr      q2, [sp, #0x60]
005A0C00C  ldr      x9, [sp, #0x70]
005A0C010  stp      q0, q1, [sp]
005A0C014  str      q2, [sp, #0x20]
005A0C018  str      x9, [sp, #0x30]
005A0C01C  cbz      x8, #0x5a0c084
005A0C020  ldp      q0, q1, [sp]
005A0C024  ldr      q2, [sp, #0x20]
005A0C028  ldr      x10, [sp, #0x30]
005A0C02C  ldr      x9, [x8, #0x18]
005A0C030  ldr      x0, [x8, #0x40]
005A0C034  stp      q0, q1, [sp, #0x80]
005A0C038  str      q2, [sp, #0xa0]
005A0C03C  str      x10, [sp, #0xb0]
005A0C040  ldr      x2, [x8, #0x28]
005A0C044  add      x1, sp, #0x80
005A0C048  blr      x9
005A0C04C  and      w8, w0, #1
005A0C050  strb     w8, [x19, #0x18]
005A0C054  mov      w0, #1
005A0C058  b        #0x5a0c070 ; 
005A0C05C  ldr      x8, [x19]
005A0C060  mov      x0, x19
005A0C064  ldp      x9, x1, [x8, #0x1f8]
005A0C068  blr      x9
005A0C06C  mov      w0, wzr
005A0C070  ldp      x20, x19, [sp, #0xd0]
005A0C074  ldr      x30, [sp, #0xc0]
005A0C078  add      sp, sp, #0xe0
005A0C07C  ret      
005A0C080  bl       #0x382bfc0 ; 
005A0C084  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, bool>$$Where
; RVA 0x5A0C088; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0C088  stp      x30, x21, [sp, #-0x20]!
005A0C08C  stp      x20, x19, [sp, #0x10]
005A0C090  ldr      x8, [x2, #0x20]
005A0C094  mov      x20, x2
005A0C098  mov      x19, x1
005A0C09C  mov      x21, x0
005A0C0A0  ldr      x8, [x8, #0xc0]
005A0C0A4  ldr      x8, [x8, #0x70]
005A0C0A8  ldrb     w9, [x8, #0x135]
005A0C0AC  tbnz     w9, #0, #0x5a0c0bc
005A0C0B0  mov      x0, x8
005A0C0B4  bl       #0x3a7e60c ; 
005A0C0B8  mov      x8, x0
005A0C0BC  mov      x0, x8
005A0C0C0  bl       #0x382bfa0 ; 
005A0C0C4  ldr      x8, [x20, #0x20]
005A0C0C8  mov      x1, x21
005A0C0CC  mov      x2, x19
005A0C0D0  mov      x20, x0
005A0C0D4  ldr      x8, [x8, #0xc0]
005A0C0D8  ldr      x3, [x8, #0x78]
005A0C0DC  bl       #0x59c53fc ; System.Linq.Enumerable.WhereEnumerableIterator<bool>$$.ctor
005A0C0E0  mov      x0, x20
005A0C0E4  ldp      x20, x19, [sp, #0x10]
005A0C0E8  ldp      x30, x21, [sp], #0x20
005A0C0EC  ret      

