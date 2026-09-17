; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, char>$$.ctor
; RVA 0x5A0CF40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0CF40  str      x30, [sp, #-0x30]!
005A0CF44  stp      x22, x21, [sp, #0x10]
005A0CF48  stp      x20, x19, [sp, #0x20]
005A0CF4C  ldr      x8, [x4, #0x20]
005A0CF50  mov      x21, x1
005A0CF54  mov      x19, x3
005A0CF58  mov      x20, x2
005A0CF5C  ldr      x8, [x8, #0xc0]
005A0CF60  mov      x22, x0
005A0CF64  ldr      x1, [x8]
005A0CF68  bl       #0x4a73bd4 ; System.Linq.Enumerable.Iterator<char>$$.ctor
005A0CF6C  mov      x0, x22
005A0CF70  str      x21, [x0, #0x20]!
005A0CF74  mov      x1, x21
005A0CF78  bl       #0x382bcb8 ; 
005A0CF7C  mov      x0, x22
005A0CF80  str      x20, [x0, #0x28]!
005A0CF84  mov      x1, x20
005A0CF88  bl       #0x382bcb8 ; 
005A0CF8C  str      x19, [x22, #0x30]!
005A0CF90  mov      x0, x22
005A0CF94  mov      x1, x19
005A0CF98  ldp      x20, x19, [sp, #0x20]
005A0CF9C  ldp      x22, x21, [sp, #0x10]
005A0CFA0  ldr      x30, [sp], #0x30
005A0CFA4  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, char>$$Clone
; RVA 0x5A0CFA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0CFA8  str      x30, [sp, #-0x30]!
005A0CFAC  stp      x22, x21, [sp, #0x10]
005A0CFB0  stp      x20, x19, [sp, #0x20]
005A0CFB4  ldr      x9, [x1, #0x20]
005A0CFB8  mov      x8, x0
005A0CFBC  ldp      x21, x20, [x8, #0x20]
005A0CFC0  ldr      x22, [x8, #0x30]
005A0CFC4  ldr      x9, [x9, #0xc0]
005A0CFC8  mov      x19, x1
005A0CFCC  ldr      x0, [x9, #0x18]
005A0CFD0  ldrb     w9, [x0, #0x135]
005A0CFD4  tbnz     w9, #0, #0x5a0cfdc
005A0CFD8  bl       #0x3a7e60c ; 
005A0CFDC  bl       #0x382bfa0 ; 
005A0CFE0  ldr      x8, [x19, #0x20]
005A0CFE4  mov      x1, x21
005A0CFE8  mov      x2, x20
005A0CFEC  mov      x3, x22
005A0CFF0  ldr      x8, [x8, #0xc0]
005A0CFF4  mov      x19, x0
005A0CFF8  ldr      x4, [x8, #0x30]
005A0CFFC  bl       #0x5a0cf40 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, char>$$.ctor
005A0D000  mov      x0, x19
005A0D004  ldp      x20, x19, [sp, #0x20]
005A0D008  ldp      x22, x21, [sp, #0x10]
005A0D00C  ldr      x30, [sp], #0x30
005A0D010  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, char>$$MoveNext
; RVA 0x5A0D014; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D014  sub      sp, sp, #0xe0
005A0D018  str      x30, [sp, #0xc0]
005A0D01C  stp      x20, x19, [sp, #0xd0]
005A0D020  ldr      w8, [x0, #0x14]
005A0D024  cmp      w8, #1
005A0D028  b.ne     #0x5a0d118
005A0D02C  mov      x19, x0
005A0D030  mov      w20, #0x38
005A0D034  ldr      x9, [x19, #0x20]
005A0D038  cbz      x9, #0x5a0d130
005A0D03C  ldrsw    x8, [x19, #0x38]
005A0D040  ldr      w10, [x9, #0x18]
005A0D044  cmp      w8, w10
005A0D048  b.ge     #0x5a0d108
005A0D04C  cmp      w8, w10
005A0D050  b.hs     #0x5a0d12c
005A0D054  madd     x9, x8, x20, x9
005A0D058  ldr      x10, [x9, #0x50]
005A0D05C  ldp      q1, q0, [x9, #0x30]
005A0D060  ldr      q2, [x9, #0x20]
005A0D064  add      w8, w8, #1
005A0D068  str      x10, [sp, #0x70]
005A0D06C  stp      q1, q0, [sp, #0x50]
005A0D070  str      q2, [sp, #0x40]
005A0D074  ldr      x9, [x19, #0x28]
005A0D078  str      w8, [x19, #0x38]
005A0D07C  cbz      x9, #0x5a0d0b0
005A0D080  ldp      q0, q1, [sp, #0x40]
005A0D084  ldr      q2, [sp, #0x60]
005A0D088  ldr      x10, [sp, #0x70]
005A0D08C  ldr      x8, [x9, #0x18]
005A0D090  ldr      x0, [x9, #0x40]
005A0D094  stp      q0, q1, [sp, #0x80]
005A0D098  str      q2, [sp, #0xa0]
005A0D09C  str      x10, [sp, #0xb0]
005A0D0A0  ldr      x2, [x9, #0x28]
005A0D0A4  add      x1, sp, #0x80
005A0D0A8  blr      x8
005A0D0AC  tbz      w0, #0, #0x5a0d034
005A0D0B0  ldr      x8, [x19, #0x30]
005A0D0B4  ldp      q0, q1, [sp, #0x40]
005A0D0B8  ldr      q2, [sp, #0x60]
005A0D0BC  ldr      x9, [sp, #0x70]
005A0D0C0  stp      q0, q1, [sp]
005A0D0C4  str      q2, [sp, #0x20]
005A0D0C8  str      x9, [sp, #0x30]
005A0D0CC  cbz      x8, #0x5a0d130
005A0D0D0  ldp      q0, q1, [sp]
005A0D0D4  ldr      q2, [sp, #0x20]
005A0D0D8  ldr      x10, [sp, #0x30]
005A0D0DC  ldr      x9, [x8, #0x18]
005A0D0E0  ldr      x0, [x8, #0x40]
005A0D0E4  stp      q0, q1, [sp, #0x80]
005A0D0E8  str      q2, [sp, #0xa0]
005A0D0EC  str      x10, [sp, #0xb0]
005A0D0F0  ldr      x2, [x8, #0x28]
005A0D0F4  add      x1, sp, #0x80
005A0D0F8  blr      x9
005A0D0FC  strh     w0, [x19, #0x18]
005A0D100  mov      w0, #1
005A0D104  b        #0x5a0d11c ; 
005A0D108  ldr      x8, [x19]
005A0D10C  mov      x0, x19
005A0D110  ldp      x9, x1, [x8, #0x1f8]
005A0D114  blr      x9
005A0D118  mov      w0, wzr
005A0D11C  ldp      x20, x19, [sp, #0xd0]
005A0D120  ldr      x30, [sp, #0xc0]
005A0D124  add      sp, sp, #0xe0
005A0D128  ret      
005A0D12C  bl       #0x382bfc0 ; 
005A0D130  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, char>$$Where
; RVA 0x5A0D134; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D134  stp      x30, x21, [sp, #-0x20]!
005A0D138  stp      x20, x19, [sp, #0x10]
005A0D13C  ldr      x8, [x2, #0x20]
005A0D140  mov      x20, x2
005A0D144  mov      x19, x1
005A0D148  mov      x21, x0
005A0D14C  ldr      x8, [x8, #0xc0]
005A0D150  ldr      x8, [x8, #0x70]
005A0D154  ldrb     w9, [x8, #0x135]
005A0D158  tbnz     w9, #0, #0x5a0d168
005A0D15C  mov      x0, x8
005A0D160  bl       #0x3a7e60c ; 
005A0D164  mov      x8, x0
005A0D168  mov      x0, x8
005A0D16C  bl       #0x382bfa0 ; 
005A0D170  ldr      x8, [x20, #0x20]
005A0D174  mov      x1, x21
005A0D178  mov      x2, x19
005A0D17C  mov      x20, x0
005A0D180  ldr      x8, [x8, #0xc0]
005A0D184  ldr      x3, [x8, #0x78]
005A0D188  bl       #0x59c8178 ; System.Linq.Enumerable.WhereEnumerableIterator<char>$$.ctor
005A0D18C  mov      x0, x20
005A0D190  ldp      x20, x19, [sp, #0x10]
005A0D194  ldp      x30, x21, [sp], #0x20
005A0D198  ret      

