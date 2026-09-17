; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRoleData>$$.ctor
; RVA 0x5ABBF10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABBF10  str      x30, [sp, #-0x30]!
005ABBF14  stp      x22, x21, [sp, #0x10]
005ABBF18  stp      x20, x19, [sp, #0x20]
005ABBF1C  ldr      x8, [x4, #0x20]
005ABBF20  mov      x21, x1
005ABBF24  mov      x19, x3
005ABBF28  mov      x20, x2
005ABBF2C  ldr      x8, [x8, #0xc0]
005ABBF30  mov      x22, x0
005ABBF34  ldr      x1, [x8]
005ABBF38  bl       #0x4a73980 ; System.Linq.Enumerable.Iterator<CalRoleData>$$.ctor
005ABBF3C  mov      x0, x22
005ABBF40  str      x21, [x0, #0x48]!
005ABBF44  mov      x1, x21
005ABBF48  bl       #0x382bcb8 ; 
005ABBF4C  mov      x0, x22
005ABBF50  str      x20, [x0, #0x50]!
005ABBF54  mov      x1, x20
005ABBF58  bl       #0x382bcb8 ; 
005ABBF5C  str      x19, [x22, #0x58]!
005ABBF60  mov      x0, x22
005ABBF64  mov      x1, x19
005ABBF68  ldp      x20, x19, [sp, #0x20]
005ABBF6C  ldp      x22, x21, [sp, #0x10]
005ABBF70  ldr      x30, [sp], #0x30
005ABBF74  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRoleData>$$Clone
; RVA 0x5ABBF78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABBF78  str      x30, [sp, #-0x30]!
005ABBF7C  stp      x22, x21, [sp, #0x10]
005ABBF80  stp      x20, x19, [sp, #0x20]
005ABBF84  ldr      x9, [x1, #0x20]
005ABBF88  mov      x8, x0
005ABBF8C  ldp      x21, x20, [x8, #0x48]
005ABBF90  ldr      x22, [x8, #0x58]
005ABBF94  ldr      x9, [x9, #0xc0]
005ABBF98  mov      x19, x1
005ABBF9C  ldr      x0, [x9, #0x18]
005ABBFA0  ldrb     w9, [x0, #0x135]
005ABBFA4  tbnz     w9, #0, #0x5abbfac
005ABBFA8  bl       #0x3a7e60c ; 
005ABBFAC  bl       #0x382bfa0 ; 
005ABBFB0  ldr      x8, [x19, #0x20]
005ABBFB4  mov      x1, x21
005ABBFB8  mov      x2, x20
005ABBFBC  mov      x3, x22
005ABBFC0  ldr      x8, [x8, #0xc0]
005ABBFC4  mov      x19, x0
005ABBFC8  ldr      x4, [x8, #0x30]
005ABBFCC  bl       #0x5abbf10 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRoleData>$$.ctor
005ABBFD0  mov      x0, x19
005ABBFD4  ldp      x20, x19, [sp, #0x20]
005ABBFD8  ldp      x22, x21, [sp, #0x10]
005ABBFDC  ldr      x30, [sp], #0x30
005ABBFE0  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRoleData>$$Dispose
; RVA 0x5ABBFE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABBFE4  str      x30, [sp, #-0x30]!
005ABBFE8  stp      x22, x21, [sp, #0x10]
005ABBFEC  stp      x20, x19, [sp, #0x20]
005ABBFF0  adrp     x21, #0x9595000
005ABBFF4  ldrb     w8, [x21, #0x451]
005ABBFF8  mov      x19, x1
005ABBFFC  mov      x20, x0
005ABC000  tbnz     w8, #0, #0x5abc018
005ABC004  adrp     x0, #0x8ebf000
005ABC008  ldr      x0, [x0, #0x4e8]
005ABC00C  bl       #0x382bd14 ; 
005ABC010  mov      w8, #1
005ABC014  strb     w8, [x21, #0x451]
005ABC018  mov      x21, x20
005ABC01C  ldr      x22, [x21, #0x60]!
005ABC020  cbz      x22, #0x5abc084
005ABC024  adrp     x10, #0x8ebf000
005ABC028  ldr      x8, [x22]
005ABC02C  ldr      x10, [x10, #0x4e8]
005ABC030  ldrh     w9, [x8, #0x12e]
005ABC034  ldr      x1, [x10]
005ABC038  cbz      x9, #0x5abc05c
005ABC03C  ldr      x10, [x8, #0xb0]
005ABC040  add      x10, x10, #8
005ABC044  ldur     x11, [x10, #-8]
005ABC048  cmp      x11, x1
005ABC04C  b.eq     #0x5abc06c
005ABC050  subs     x9, x9, #1
005ABC054  add      x10, x10, #0x10
005ABC058  b.ne     #0x5abc044
005ABC05C  mov      x0, x22
005ABC060  mov      w2, wzr
005ABC064  bl       #0x3a7e710 ; 
005ABC068  b        #0x5abc078 ; 
005ABC06C  ldrsw    x9, [x10]
005ABC070  add      x8, x8, x9, lsl #4
005ABC074  add      x0, x8, #0x138
005ABC078  ldp      x8, x1, [x0]
005ABC07C  mov      x0, x22
005ABC080  blr      x8
005ABC084  mov      x0, x21
005ABC088  mov      x1, xzr
005ABC08C  str      xzr, [x20, #0x60]
005ABC090  bl       #0x382bcb8 ; 
005ABC094  ldr      x8, [x19, #0x20]
005ABC098  mov      x0, x20
005ABC09C  ldp      x20, x19, [sp, #0x20]
005ABC0A0  ldp      x22, x21, [sp, #0x10]
005ABC0A4  ldr      x8, [x8, #0xc0]
005ABC0A8  ldr      x1, [x8, #0x48]
005ABC0AC  ldr      x30, [sp], #0x30
005ABC0B0  b        #0x4a739cc ; System.Linq.Enumerable.Iterator<CalRoleData>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRoleData>$$MoveNext
; RVA 0x5ABC0B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABC0B4  sub      sp, sp, #0x120
005ABC0B8  stp      x29, x30, [sp, #0xf0]
005ABC0BC  stp      x22, x21, [sp, #0x100]
005ABC0C0  stp      x20, x19, [sp, #0x110]
005ABC0C4  adrp     x21, #0x9595000
005ABC0C8  ldrb     w8, [x21, #0x452]
005ABC0CC  mov      x20, x1
005ABC0D0  mov      x19, x0
005ABC0D4  tbnz     w8, #0, #0x5abc0ec
005ABC0D8  adrp     x0, #0x8ebf000
005ABC0DC  ldr      x0, [x0, #0x4f0]
005ABC0E0  bl       #0x382bd14 ; 
005ABC0E4  mov      w8, #1
005ABC0E8  strb     w8, [x21, #0x452]
005ABC0EC  ldr      w8, [x19, #0x14]
005ABC0F0  adrp     x22, #0x8ebf000
005ABC0F4  ldr      x22, [x22, #0x4f0]
005ABC0F8  cmp      w8, #2
005ABC0FC  b.eq     #0x5abc1a0
005ABC100  cmp      w8, #1
005ABC104  b.ne     #0x5abc368
005ABC108  ldr      x21, [x19, #0x48]
005ABC10C  cbz      x21, #0x5abc380
005ABC110  ldr      x8, [x20, #0x20]
005ABC114  ldr      x8, [x8, #0xc0]
005ABC118  ldr      x1, [x8, #0x10]
005ABC11C  ldrb     w8, [x1, #0x135]
005ABC120  tbnz     w8, #0, #0x5abc130
005ABC124  mov      x0, x1
005ABC128  bl       #0x3a7e60c ; 
005ABC12C  mov      x1, x0
005ABC130  ldr      x8, [x21]
005ABC134  ldrh     w9, [x8, #0x12e]
005ABC138  cbz      x9, #0x5abc15c
005ABC13C  ldr      x10, [x8, #0xb0]
005ABC140  add      x10, x10, #8
005ABC144  ldur     x11, [x10, #-8]
005ABC148  cmp      x11, x1
005ABC14C  b.eq     #0x5abc16c
005ABC150  subs     x9, x9, #1
005ABC154  add      x10, x10, #0x10
005ABC158  b.ne     #0x5abc144
005ABC15C  mov      x0, x21
005ABC160  mov      w2, wzr
005ABC164  bl       #0x3a7e710 ; 
005ABC168  b        #0x5abc178 ; 
005ABC16C  ldrsw    x9, [x10]
005ABC170  add      x8, x8, x9, lsl #4
005ABC174  add      x0, x8, #0x138
005ABC178  ldp      x8, x1, [x0]
005ABC17C  mov      x0, x21
005ABC180  blr      x8
005ABC184  mov      x21, x19
005ABC188  str      x0, [x21, #0x60]!
005ABC18C  mov      x1, x0
005ABC190  mov      x0, x21
005ABC194  bl       #0x382bcb8 ; 
005ABC198  mov      w8, #2
005ABC19C  stur     w8, [x21, #-0x4c]
005ABC1A0  ldr      x21, [x19, #0x60]
005ABC1A4  cbz      x21, #0x5abc380
005ABC1A8  ldr      x8, [x21]
005ABC1AC  ldr      x1, [x22]
005ABC1B0  ldrh     w9, [x8, #0x12e]
005ABC1B4  cbz      x9, #0x5abc1d8
005ABC1B8  ldr      x10, [x8, #0xb0]
005ABC1BC  add      x10, x10, #8
005ABC1C0  ldur     x11, [x10, #-8]
005ABC1C4  cmp      x11, x1
005ABC1C8  b.eq     #0x5abc1e8
005ABC1CC  subs     x9, x9, #1
005ABC1D0  add      x10, x10, #0x10
005ABC1D4  b.ne     #0x5abc1c0
005ABC1D8  mov      x0, x21
005ABC1DC  mov      w2, wzr
005ABC1E0  bl       #0x3a7e710 ; 
005ABC1E4  b        #0x5abc1f4 ; 
005ABC1E8  ldrsw    x9, [x10]
005ABC1EC  add      x8, x8, x9, lsl #4
005ABC1F0  add      x0, x8, #0x138
005ABC1F4  ldp      x8, x1, [x0]
005ABC1F8  mov      x0, x21
005ABC1FC  blr      x8
005ABC200  tbz      w0, #0, #0x5abc354
005ABC204  ldr      x21, [x19, #0x60]
005ABC208  cbz      x21, #0x5abc380
005ABC20C  ldr      x8, [x20, #0x20]
005ABC210  ldr      x8, [x8, #0xc0]
005ABC214  ldr      x1, [x8, #0x40]
005ABC218  ldrb     w8, [x1, #0x135]
005ABC21C  tbnz     w8, #0, #0x5abc22c
005ABC220  mov      x0, x1
005ABC224  bl       #0x3a7e60c ; 
005ABC228  mov      x1, x0
005ABC22C  ldr      x8, [x21]
005ABC230  ldrh     w9, [x8, #0x12e]
005ABC234  cbz      x9, #0x5abc258
005ABC238  ldr      x10, [x8, #0xb0]
005ABC23C  add      x10, x10, #8
005ABC240  ldur     x11, [x10, #-8]
005ABC244  cmp      x11, x1
005ABC248  b.eq     #0x5abc268
005ABC24C  subs     x9, x9, #1
005ABC250  add      x10, x10, #0x10
005ABC254  b.ne     #0x5abc240
005ABC258  mov      x0, x21
005ABC25C  mov      w2, wzr
005ABC260  bl       #0x3a7e710 ; 
005ABC264  b        #0x5abc274 ; 
005ABC268  ldrsw    x9, [x10]
005ABC26C  add      x8, x8, x9, lsl #4
005ABC270  add      x0, x8, #0x138
005ABC274  ldp      x9, x1, [x0]
005ABC278  add      x8, sp, #0xb0
005ABC27C  mov      x0, x21
005ABC280  blr      x9
005ABC284  ldp      q0, q1, [sp, #0xb0]
005ABC288  ldr      q2, [sp, #0xd0]
005ABC28C  ldr      x8, [sp, #0xe0]
005ABC290  stp      q0, q1, [sp, #0x70]
005ABC294  str      q2, [sp, #0x90]
005ABC298  str      x8, [sp, #0xa0]
005ABC29C  ldr      x8, [x19, #0x50]
005ABC2A0  cbz      x8, #0x5abc2d4
005ABC2A4  ldp      q0, q1, [sp, #0x70]
005ABC2A8  ldr      q2, [sp, #0x90]
005ABC2AC  ldr      x10, [sp, #0xa0]
005ABC2B0  ldr      x9, [x8, #0x18]
005ABC2B4  ldr      x0, [x8, #0x40]
005ABC2B8  stp      q0, q1, [sp, #0xb0]
005ABC2BC  str      q2, [sp, #0xd0]
005ABC2C0  str      x10, [sp, #0xe0]
005ABC2C4  ldr      x2, [x8, #0x28]
005ABC2C8  add      x1, sp, #0xb0
005ABC2CC  blr      x9
005ABC2D0  tbz      w0, #0, #0x5abc1a0
005ABC2D4  ldr      x8, [x19, #0x58]
005ABC2D8  ldp      q0, q1, [sp, #0x70]
005ABC2DC  ldr      q2, [sp, #0x90]
005ABC2E0  ldr      x9, [sp, #0xa0]
005ABC2E4  stp      q0, q1, [sp, #0x30]
005ABC2E8  str      q2, [sp, #0x50]
005ABC2EC  str      x9, [sp, #0x60]
005ABC2F0  cbz      x8, #0x5abc380
005ABC2F4  ldp      q0, q1, [sp, #0x30]
005ABC2F8  ldr      q2, [sp, #0x50]
005ABC2FC  ldr      x10, [sp, #0x60]
005ABC300  ldr      x9, [x8, #0x18]
005ABC304  ldr      x0, [x8, #0x40]
005ABC308  stp      q0, q1, [sp, #0xb0]
005ABC30C  str      q2, [sp, #0xd0]
005ABC310  str      x10, [sp, #0xe0]
005ABC314  ldr      x2, [x8, #0x28]
005ABC318  mov      x8, sp
005ABC31C  add      x1, sp, #0xb0
005ABC320  blr      x9
005ABC324  ldp      q1, q0, [sp, #0x10]
005ABC328  ldr      q2, [sp]
005ABC32C  add      x0, x19, #0x28
005ABC330  mov      x1, xzr
005ABC334  stp      q1, q0, [sp, #0xc0]
005ABC338  str      q2, [sp, #0xb0]
005ABC33C  stur     q0, [x19, #0x38]
005ABC340  stur     q1, [x19, #0x28]
005ABC344  stur     q2, [x19, #0x18]
005ABC348  bl       #0x382bcb8 ; 
005ABC34C  mov      w0, #1
005ABC350  b        #0x5abc36c ; 
005ABC354  cbz      x19, #0x5abc380
005ABC358  ldr      x8, [x19]
005ABC35C  mov      x0, x19
005ABC360  ldp      x9, x1, [x8, #0x1f8]
005ABC364  blr      x9
005ABC368  mov      w0, wzr
005ABC36C  ldp      x20, x19, [sp, #0x110]
005ABC370  ldp      x22, x21, [sp, #0x100]
005ABC374  ldp      x29, x30, [sp, #0xf0]
005ABC378  add      sp, sp, #0x120
005ABC37C  ret      
005ABC380  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRoleData>$$Where
; RVA 0x5ABC384; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABC384  stp      x30, x21, [sp, #-0x20]!
005ABC388  stp      x20, x19, [sp, #0x10]
005ABC38C  ldr      x8, [x2, #0x20]
005ABC390  mov      x20, x2
005ABC394  mov      x19, x1
005ABC398  mov      x21, x0
005ABC39C  ldr      x8, [x8, #0xc0]
005ABC3A0  ldr      x8, [x8, #0x88]
005ABC3A4  ldrb     w9, [x8, #0x135]
005ABC3A8  tbnz     w9, #0, #0x5abc3b8
005ABC3AC  mov      x0, x8
005ABC3B0  bl       #0x3a7e60c ; 
005ABC3B4  mov      x8, x0
005ABC3B8  mov      x0, x8
005ABC3BC  bl       #0x382bfa0 ; 
005ABC3C0  ldr      x8, [x20, #0x20]
005ABC3C4  mov      x1, x21
005ABC3C8  mov      x2, x19
005ABC3CC  mov      x20, x0
005ABC3D0  ldr      x8, [x8, #0xc0]
005ABC3D4  ldr      x3, [x8, #0x90]
005ABC3D8  bl       #0x59c7908 ; System.Linq.Enumerable.WhereEnumerableIterator<CalRoleData>$$.ctor
005ABC3DC  mov      x0, x20
005ABC3E0  ldp      x20, x19, [sp, #0x10]
005ABC3E4  ldp      x30, x21, [sp], #0x20
005ABC3E8  ret      

