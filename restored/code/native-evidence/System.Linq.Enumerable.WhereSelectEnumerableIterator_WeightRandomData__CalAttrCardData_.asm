; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrCardData>$$.ctor
; RVA 0x5ABAC40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABAC40  str      x30, [sp, #-0x30]!
005ABAC44  stp      x22, x21, [sp, #0x10]
005ABAC48  stp      x20, x19, [sp, #0x20]
005ABAC4C  ldr      x8, [x4, #0x20]
005ABAC50  mov      x21, x1
005ABAC54  mov      x19, x3
005ABAC58  mov      x20, x2
005ABAC5C  ldr      x8, [x8, #0xc0]
005ABAC60  mov      x22, x0
005ABAC64  ldr      x1, [x8]
005ABAC68  bl       #0x4a732ec ; System.Linq.Enumerable.Iterator<CalAttrCardData>$$.ctor
005ABAC6C  mov      x0, x22
005ABAC70  str      x21, [x0, #0x20]!
005ABAC74  mov      x1, x21
005ABAC78  bl       #0x382bcb8 ; 
005ABAC7C  mov      x0, x22
005ABAC80  str      x20, [x0, #0x28]!
005ABAC84  mov      x1, x20
005ABAC88  bl       #0x382bcb8 ; 
005ABAC8C  str      x19, [x22, #0x30]!
005ABAC90  mov      x0, x22
005ABAC94  mov      x1, x19
005ABAC98  ldp      x20, x19, [sp, #0x20]
005ABAC9C  ldp      x22, x21, [sp, #0x10]
005ABACA0  ldr      x30, [sp], #0x30
005ABACA4  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrCardData>$$Clone
; RVA 0x5ABACA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABACA8  str      x30, [sp, #-0x30]!
005ABACAC  stp      x22, x21, [sp, #0x10]
005ABACB0  stp      x20, x19, [sp, #0x20]
005ABACB4  ldr      x9, [x1, #0x20]
005ABACB8  mov      x8, x0
005ABACBC  ldp      x21, x20, [x8, #0x20]
005ABACC0  ldr      x22, [x8, #0x30]
005ABACC4  ldr      x9, [x9, #0xc0]
005ABACC8  mov      x19, x1
005ABACCC  ldr      x0, [x9, #0x18]
005ABACD0  ldrb     w9, [x0, #0x135]
005ABACD4  tbnz     w9, #0, #0x5abacdc
005ABACD8  bl       #0x3a7e60c ; 
005ABACDC  bl       #0x382bfa0 ; 
005ABACE0  ldr      x8, [x19, #0x20]
005ABACE4  mov      x1, x21
005ABACE8  mov      x2, x20
005ABACEC  mov      x3, x22
005ABACF0  ldr      x8, [x8, #0xc0]
005ABACF4  mov      x19, x0
005ABACF8  ldr      x4, [x8, #0x30]
005ABACFC  bl       #0x5abac40 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrCardData>$$.ctor
005ABAD00  mov      x0, x19
005ABAD04  ldp      x20, x19, [sp, #0x20]
005ABAD08  ldp      x22, x21, [sp, #0x10]
005ABAD0C  ldr      x30, [sp], #0x30
005ABAD10  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrCardData>$$Dispose
; RVA 0x5ABAD14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABAD14  str      x30, [sp, #-0x30]!
005ABAD18  stp      x22, x21, [sp, #0x10]
005ABAD1C  stp      x20, x19, [sp, #0x20]
005ABAD20  adrp     x21, #0x9595000
005ABAD24  ldrb     w8, [x21, #0x449]
005ABAD28  mov      x19, x1
005ABAD2C  mov      x20, x0
005ABAD30  tbnz     w8, #0, #0x5abad48
005ABAD34  adrp     x0, #0x8ebf000
005ABAD38  ldr      x0, [x0, #0x4e8]
005ABAD3C  bl       #0x382bd14 ; 
005ABAD40  mov      w8, #1
005ABAD44  strb     w8, [x21, #0x449]
005ABAD48  mov      x21, x20
005ABAD4C  ldr      x22, [x21, #0x38]!
005ABAD50  cbz      x22, #0x5abadb4
005ABAD54  adrp     x10, #0x8ebf000
005ABAD58  ldr      x8, [x22]
005ABAD5C  ldr      x10, [x10, #0x4e8]
005ABAD60  ldrh     w9, [x8, #0x12e]
005ABAD64  ldr      x1, [x10]
005ABAD68  cbz      x9, #0x5abad8c
005ABAD6C  ldr      x10, [x8, #0xb0]
005ABAD70  add      x10, x10, #8
005ABAD74  ldur     x11, [x10, #-8]
005ABAD78  cmp      x11, x1
005ABAD7C  b.eq     #0x5abad9c
005ABAD80  subs     x9, x9, #1
005ABAD84  add      x10, x10, #0x10
005ABAD88  b.ne     #0x5abad74
005ABAD8C  mov      x0, x22
005ABAD90  mov      w2, wzr
005ABAD94  bl       #0x3a7e710 ; 
005ABAD98  b        #0x5abada8 ; 
005ABAD9C  ldrsw    x9, [x10]
005ABADA0  add      x8, x8, x9, lsl #4
005ABADA4  add      x0, x8, #0x138
005ABADA8  ldp      x8, x1, [x0]
005ABADAC  mov      x0, x22
005ABADB0  blr      x8
005ABADB4  mov      x0, x21
005ABADB8  mov      x1, xzr
005ABADBC  str      xzr, [x20, #0x38]
005ABADC0  bl       #0x382bcb8 ; 
005ABADC4  ldr      x8, [x19, #0x20]
005ABADC8  mov      x0, x20
005ABADCC  ldp      x20, x19, [sp, #0x20]
005ABADD0  ldp      x22, x21, [sp, #0x10]
005ABADD4  ldr      x8, [x8, #0xc0]
005ABADD8  ldr      x1, [x8, #0x48]
005ABADDC  ldr      x30, [sp], #0x30
005ABADE0  b        #0x4a73328 ; System.Linq.Enumerable.Iterator<CalAttrCardData>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrCardData>$$MoveNext
; RVA 0x5ABADE4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABADE4  sub      sp, sp, #0xf0
005ABADE8  str      x30, [sp, #0xc0]
005ABADEC  stp      x22, x21, [sp, #0xd0]
005ABADF0  stp      x20, x19, [sp, #0xe0]
005ABADF4  adrp     x21, #0x9595000
005ABADF8  ldrb     w8, [x21, #0x44a]
005ABADFC  mov      x20, x1
005ABAE00  mov      x19, x0
005ABAE04  tbnz     w8, #0, #0x5abae1c
005ABAE08  adrp     x0, #0x8ebf000
005ABAE0C  ldr      x0, [x0, #0x4f0]
005ABAE10  bl       #0x382bd14 ; 
005ABAE14  mov      w8, #1
005ABAE18  strb     w8, [x21, #0x44a]
005ABAE1C  ldr      w8, [x19, #0x14]
005ABAE20  adrp     x22, #0x8ebf000
005ABAE24  ldr      x22, [x22, #0x4f0]
005ABAE28  cmp      w8, #2
005ABAE2C  b.eq     #0x5abaed0
005ABAE30  cmp      w8, #1
005ABAE34  b.ne     #0x5abb070
005ABAE38  ldr      x21, [x19, #0x20]
005ABAE3C  cbz      x21, #0x5abb088
005ABAE40  ldr      x8, [x20, #0x20]
005ABAE44  ldr      x8, [x8, #0xc0]
005ABAE48  ldr      x1, [x8, #0x10]
005ABAE4C  ldrb     w8, [x1, #0x135]
005ABAE50  tbnz     w8, #0, #0x5abae60
005ABAE54  mov      x0, x1
005ABAE58  bl       #0x3a7e60c ; 
005ABAE5C  mov      x1, x0
005ABAE60  ldr      x8, [x21]
005ABAE64  ldrh     w9, [x8, #0x12e]
005ABAE68  cbz      x9, #0x5abae8c
005ABAE6C  ldr      x10, [x8, #0xb0]
005ABAE70  add      x10, x10, #8
005ABAE74  ldur     x11, [x10, #-8]
005ABAE78  cmp      x11, x1
005ABAE7C  b.eq     #0x5abae9c
005ABAE80  subs     x9, x9, #1
005ABAE84  add      x10, x10, #0x10
005ABAE88  b.ne     #0x5abae74
005ABAE8C  mov      x0, x21
005ABAE90  mov      w2, wzr
005ABAE94  bl       #0x3a7e710 ; 
005ABAE98  b        #0x5abaea8 ; 
005ABAE9C  ldrsw    x9, [x10]
005ABAEA0  add      x8, x8, x9, lsl #4
005ABAEA4  add      x0, x8, #0x138
005ABAEA8  ldp      x8, x1, [x0]
005ABAEAC  mov      x0, x21
005ABAEB0  blr      x8
005ABAEB4  mov      x21, x19
005ABAEB8  str      x0, [x21, #0x38]!
005ABAEBC  mov      x1, x0
005ABAEC0  mov      x0, x21
005ABAEC4  bl       #0x382bcb8 ; 
005ABAEC8  mov      w8, #2
005ABAECC  stur     w8, [x21, #-0x24]
005ABAED0  ldr      x21, [x19, #0x38]
005ABAED4  cbz      x21, #0x5abb088
005ABAED8  ldr      x8, [x21]
005ABAEDC  ldr      x1, [x22]
005ABAEE0  ldrh     w9, [x8, #0x12e]
005ABAEE4  cbz      x9, #0x5abaf08
005ABAEE8  ldr      x10, [x8, #0xb0]
005ABAEEC  add      x10, x10, #8
005ABAEF0  ldur     x11, [x10, #-8]
005ABAEF4  cmp      x11, x1
005ABAEF8  b.eq     #0x5abaf18
005ABAEFC  subs     x9, x9, #1
005ABAF00  add      x10, x10, #0x10
005ABAF04  b.ne     #0x5abaef0
005ABAF08  mov      x0, x21
005ABAF0C  mov      w2, wzr
005ABAF10  bl       #0x3a7e710 ; 
005ABAF14  b        #0x5abaf24 ; 
005ABAF18  ldrsw    x9, [x10]
005ABAF1C  add      x8, x8, x9, lsl #4
005ABAF20  add      x0, x8, #0x138
005ABAF24  ldp      x8, x1, [x0]
005ABAF28  mov      x0, x21
005ABAF2C  blr      x8
005ABAF30  tbz      w0, #0, #0x5abb05c
005ABAF34  ldr      x21, [x19, #0x38]
005ABAF38  cbz      x21, #0x5abb088
005ABAF3C  ldr      x8, [x20, #0x20]
005ABAF40  ldr      x8, [x8, #0xc0]
005ABAF44  ldr      x1, [x8, #0x40]
005ABAF48  ldrb     w8, [x1, #0x135]
005ABAF4C  tbnz     w8, #0, #0x5abaf5c
005ABAF50  mov      x0, x1
005ABAF54  bl       #0x3a7e60c ; 
005ABAF58  mov      x1, x0
005ABAF5C  ldr      x8, [x21]
005ABAF60  ldrh     w9, [x8, #0x12e]
005ABAF64  cbz      x9, #0x5abaf88
005ABAF68  ldr      x10, [x8, #0xb0]
005ABAF6C  add      x10, x10, #8
005ABAF70  ldur     x11, [x10, #-8]
005ABAF74  cmp      x11, x1
005ABAF78  b.eq     #0x5abaf98
005ABAF7C  subs     x9, x9, #1
005ABAF80  add      x10, x10, #0x10
005ABAF84  b.ne     #0x5abaf70
005ABAF88  mov      x0, x21
005ABAF8C  mov      w2, wzr
005ABAF90  bl       #0x3a7e710 ; 
005ABAF94  b        #0x5abafa4 ; 
005ABAF98  ldrsw    x9, [x10]
005ABAF9C  add      x8, x8, x9, lsl #4
005ABAFA0  add      x0, x8, #0x138
005ABAFA4  ldp      x9, x1, [x0]
005ABAFA8  add      x8, sp, #0x80
005ABAFAC  mov      x0, x21
005ABAFB0  blr      x9
005ABAFB4  ldp      q0, q1, [sp, #0x80]
005ABAFB8  ldr      q2, [sp, #0xa0]
005ABAFBC  ldr      x8, [sp, #0xb0]
005ABAFC0  stp      q0, q1, [sp, #0x40]
005ABAFC4  str      q2, [sp, #0x60]
005ABAFC8  str      x8, [sp, #0x70]
005ABAFCC  ldr      x8, [x19, #0x28]
005ABAFD0  cbz      x8, #0x5abb004
005ABAFD4  ldp      q0, q1, [sp, #0x40]
005ABAFD8  ldr      q2, [sp, #0x60]
005ABAFDC  ldr      x10, [sp, #0x70]
005ABAFE0  ldr      x9, [x8, #0x18]
005ABAFE4  ldr      x0, [x8, #0x40]
005ABAFE8  stp      q0, q1, [sp, #0x80]
005ABAFEC  str      q2, [sp, #0xa0]
005ABAFF0  str      x10, [sp, #0xb0]
005ABAFF4  ldr      x2, [x8, #0x28]
005ABAFF8  add      x1, sp, #0x80
005ABAFFC  blr      x9
005ABB000  tbz      w0, #0, #0x5abaed0
005ABB004  ldr      x8, [x19, #0x30]
005ABB008  ldp      q0, q1, [sp, #0x40]
005ABB00C  ldr      q2, [sp, #0x60]
005ABB010  ldr      x9, [sp, #0x70]
005ABB014  stp      q0, q1, [sp]
005ABB018  str      q2, [sp, #0x20]
005ABB01C  str      x9, [sp, #0x30]
005ABB020  cbz      x8, #0x5abb088
005ABB024  ldp      q0, q1, [sp]
005ABB028  ldr      q2, [sp, #0x20]
005ABB02C  ldr      x10, [sp, #0x30]
005ABB030  ldr      x9, [x8, #0x18]
005ABB034  ldr      x0, [x8, #0x40]
005ABB038  stp      q0, q1, [sp, #0x80]
005ABB03C  str      q2, [sp, #0xa0]
005ABB040  str      x10, [sp, #0xb0]
005ABB044  ldr      x2, [x8, #0x28]
005ABB048  add      x1, sp, #0x80
005ABB04C  blr      x9
005ABB050  str      x0, [x19, #0x18]
005ABB054  mov      w0, #1
005ABB058  b        #0x5abb074 ; 
005ABB05C  cbz      x19, #0x5abb088
005ABB060  ldr      x8, [x19]
005ABB064  mov      x0, x19
005ABB068  ldp      x9, x1, [x8, #0x1f8]
005ABB06C  blr      x9
005ABB070  mov      w0, wzr
005ABB074  ldp      x20, x19, [sp, #0xe0]
005ABB078  ldp      x22, x21, [sp, #0xd0]
005ABB07C  ldr      x30, [sp, #0xc0]
005ABB080  add      sp, sp, #0xf0
005ABB084  ret      
005ABB088  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrCardData>$$Where
; RVA 0x5ABB08C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABB08C  stp      x30, x21, [sp, #-0x20]!
005ABB090  stp      x20, x19, [sp, #0x10]
005ABB094  ldr      x8, [x2, #0x20]
005ABB098  mov      x20, x2
005ABB09C  mov      x19, x1
005ABB0A0  mov      x21, x0
005ABB0A4  ldr      x8, [x8, #0xc0]
005ABB0A8  ldr      x8, [x8, #0x88]
005ABB0AC  ldrb     w9, [x8, #0x135]
005ABB0B0  tbnz     w9, #0, #0x5abb0c0
005ABB0B4  mov      x0, x8
005ABB0B8  bl       #0x3a7e60c ; 
005ABB0BC  mov      x8, x0
005ABB0C0  mov      x0, x8
005ABB0C4  bl       #0x382bfa0 ; 
005ABB0C8  ldr      x8, [x20, #0x20]
005ABB0CC  mov      x1, x21
005ABB0D0  mov      x2, x19
005ABB0D4  mov      x20, x0
005ABB0D8  ldr      x8, [x8, #0xc0]
005ABB0DC  ldr      x3, [x8, #0x90]
005ABB0E0  bl       #0x59c6084 ; System.Linq.Enumerable.WhereEnumerableIterator<CalAttrCardData>$$.ctor
005ABB0E4  mov      x0, x20
005ABB0E8  ldp      x20, x19, [sp, #0x10]
005ABB0EC  ldp      x30, x21, [sp], #0x20
005ABB0F0  ret      

