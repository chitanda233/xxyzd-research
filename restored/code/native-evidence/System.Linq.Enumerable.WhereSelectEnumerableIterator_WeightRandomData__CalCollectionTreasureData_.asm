; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalCollectionTreasureData>$$.ctor
; RVA 0x5ABB5A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABB5A8  str      x30, [sp, #-0x30]!
005ABB5AC  stp      x22, x21, [sp, #0x10]
005ABB5B0  stp      x20, x19, [sp, #0x20]
005ABB5B4  ldr      x8, [x4, #0x20]
005ABB5B8  mov      x21, x1
005ABB5BC  mov      x19, x3
005ABB5C0  mov      x20, x2
005ABB5C4  ldr      x8, [x8, #0xc0]
005ABB5C8  mov      x22, x0
005ABB5CC  ldr      x1, [x8]
005ABB5D0  bl       #0x4a73758 ; System.Linq.Enumerable.Iterator<CalCollectionTreasureData>$$.ctor
005ABB5D4  mov      x0, x22
005ABB5D8  str      x21, [x0, #0x20]!
005ABB5DC  mov      x1, x21
005ABB5E0  bl       #0x382bcb8 ; 
005ABB5E4  mov      x0, x22
005ABB5E8  str      x20, [x0, #0x28]!
005ABB5EC  mov      x1, x20
005ABB5F0  bl       #0x382bcb8 ; 
005ABB5F4  str      x19, [x22, #0x30]!
005ABB5F8  mov      x0, x22
005ABB5FC  mov      x1, x19
005ABB600  ldp      x20, x19, [sp, #0x20]
005ABB604  ldp      x22, x21, [sp, #0x10]
005ABB608  ldr      x30, [sp], #0x30
005ABB60C  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalCollectionTreasureData>$$Clone
; RVA 0x5ABB610; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABB610  str      x30, [sp, #-0x30]!
005ABB614  stp      x22, x21, [sp, #0x10]
005ABB618  stp      x20, x19, [sp, #0x20]
005ABB61C  ldr      x9, [x1, #0x20]
005ABB620  mov      x8, x0
005ABB624  ldp      x21, x20, [x8, #0x20]
005ABB628  ldr      x22, [x8, #0x30]
005ABB62C  ldr      x9, [x9, #0xc0]
005ABB630  mov      x19, x1
005ABB634  ldr      x0, [x9, #0x18]
005ABB638  ldrb     w9, [x0, #0x135]
005ABB63C  tbnz     w9, #0, #0x5abb644
005ABB640  bl       #0x3a7e60c ; 
005ABB644  bl       #0x382bfa0 ; 
005ABB648  ldr      x8, [x19, #0x20]
005ABB64C  mov      x1, x21
005ABB650  mov      x2, x20
005ABB654  mov      x3, x22
005ABB658  ldr      x8, [x8, #0xc0]
005ABB65C  mov      x19, x0
005ABB660  ldr      x4, [x8, #0x30]
005ABB664  bl       #0x5abb5a8 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalCollectionTreasureData>$$.ctor
005ABB668  mov      x0, x19
005ABB66C  ldp      x20, x19, [sp, #0x20]
005ABB670  ldp      x22, x21, [sp, #0x10]
005ABB674  ldr      x30, [sp], #0x30
005ABB678  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalCollectionTreasureData>$$Dispose
; RVA 0x5ABB67C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABB67C  str      x30, [sp, #-0x30]!
005ABB680  stp      x22, x21, [sp, #0x10]
005ABB684  stp      x20, x19, [sp, #0x20]
005ABB688  adrp     x21, #0x9595000
005ABB68C  ldrb     w8, [x21, #0x44d]
005ABB690  mov      x19, x1
005ABB694  mov      x20, x0
005ABB698  tbnz     w8, #0, #0x5abb6b0
005ABB69C  adrp     x0, #0x8ebf000
005ABB6A0  ldr      x0, [x0, #0x4e8]
005ABB6A4  bl       #0x382bd14 ; 
005ABB6A8  mov      w8, #1
005ABB6AC  strb     w8, [x21, #0x44d]
005ABB6B0  mov      x21, x20
005ABB6B4  ldr      x22, [x21, #0x38]!
005ABB6B8  cbz      x22, #0x5abb71c
005ABB6BC  adrp     x10, #0x8ebf000
005ABB6C0  ldr      x8, [x22]
005ABB6C4  ldr      x10, [x10, #0x4e8]
005ABB6C8  ldrh     w9, [x8, #0x12e]
005ABB6CC  ldr      x1, [x10]
005ABB6D0  cbz      x9, #0x5abb6f4
005ABB6D4  ldr      x10, [x8, #0xb0]
005ABB6D8  add      x10, x10, #8
005ABB6DC  ldur     x11, [x10, #-8]
005ABB6E0  cmp      x11, x1
005ABB6E4  b.eq     #0x5abb704
005ABB6E8  subs     x9, x9, #1
005ABB6EC  add      x10, x10, #0x10
005ABB6F0  b.ne     #0x5abb6dc
005ABB6F4  mov      x0, x22
005ABB6F8  mov      w2, wzr
005ABB6FC  bl       #0x3a7e710 ; 
005ABB700  b        #0x5abb710 ; 
005ABB704  ldrsw    x9, [x10]
005ABB708  add      x8, x8, x9, lsl #4
005ABB70C  add      x0, x8, #0x138
005ABB710  ldp      x8, x1, [x0]
005ABB714  mov      x0, x22
005ABB718  blr      x8
005ABB71C  mov      x0, x21
005ABB720  mov      x1, xzr
005ABB724  str      xzr, [x20, #0x38]
005ABB728  bl       #0x382bcb8 ; 
005ABB72C  ldr      x8, [x19, #0x20]
005ABB730  mov      x0, x20
005ABB734  ldp      x20, x19, [sp, #0x20]
005ABB738  ldp      x22, x21, [sp, #0x10]
005ABB73C  ldr      x8, [x8, #0xc0]
005ABB740  ldr      x1, [x8, #0x48]
005ABB744  ldr      x30, [sp], #0x30
005ABB748  b        #0x4a73794 ; System.Linq.Enumerable.Iterator<CalCollectionTreasureData>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalCollectionTreasureData>$$MoveNext
; RVA 0x5ABB74C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABB74C  sub      sp, sp, #0xf0
005ABB750  str      x30, [sp, #0xc0]
005ABB754  stp      x22, x21, [sp, #0xd0]
005ABB758  stp      x20, x19, [sp, #0xe0]
005ABB75C  adrp     x21, #0x9595000
005ABB760  ldrb     w8, [x21, #0x44e]
005ABB764  mov      x20, x1
005ABB768  mov      x19, x0
005ABB76C  tbnz     w8, #0, #0x5abb784
005ABB770  adrp     x0, #0x8ebf000
005ABB774  ldr      x0, [x0, #0x4f0]
005ABB778  bl       #0x382bd14 ; 
005ABB77C  mov      w8, #1
005ABB780  strb     w8, [x21, #0x44e]
005ABB784  ldr      w8, [x19, #0x14]
005ABB788  adrp     x22, #0x8ebf000
005ABB78C  ldr      x22, [x22, #0x4f0]
005ABB790  cmp      w8, #2
005ABB794  b.eq     #0x5abb838
005ABB798  cmp      w8, #1
005ABB79C  b.ne     #0x5abb9d8
005ABB7A0  ldr      x21, [x19, #0x20]
005ABB7A4  cbz      x21, #0x5abb9f0
005ABB7A8  ldr      x8, [x20, #0x20]
005ABB7AC  ldr      x8, [x8, #0xc0]
005ABB7B0  ldr      x1, [x8, #0x10]
005ABB7B4  ldrb     w8, [x1, #0x135]
005ABB7B8  tbnz     w8, #0, #0x5abb7c8
005ABB7BC  mov      x0, x1
005ABB7C0  bl       #0x3a7e60c ; 
005ABB7C4  mov      x1, x0
005ABB7C8  ldr      x8, [x21]
005ABB7CC  ldrh     w9, [x8, #0x12e]
005ABB7D0  cbz      x9, #0x5abb7f4
005ABB7D4  ldr      x10, [x8, #0xb0]
005ABB7D8  add      x10, x10, #8
005ABB7DC  ldur     x11, [x10, #-8]
005ABB7E0  cmp      x11, x1
005ABB7E4  b.eq     #0x5abb804
005ABB7E8  subs     x9, x9, #1
005ABB7EC  add      x10, x10, #0x10
005ABB7F0  b.ne     #0x5abb7dc
005ABB7F4  mov      x0, x21
005ABB7F8  mov      w2, wzr
005ABB7FC  bl       #0x3a7e710 ; 
005ABB800  b        #0x5abb810 ; 
005ABB804  ldrsw    x9, [x10]
005ABB808  add      x8, x8, x9, lsl #4
005ABB80C  add      x0, x8, #0x138
005ABB810  ldp      x8, x1, [x0]
005ABB814  mov      x0, x21
005ABB818  blr      x8
005ABB81C  mov      x21, x19
005ABB820  str      x0, [x21, #0x38]!
005ABB824  mov      x1, x0
005ABB828  mov      x0, x21
005ABB82C  bl       #0x382bcb8 ; 
005ABB830  mov      w8, #2
005ABB834  stur     w8, [x21, #-0x24]
005ABB838  ldr      x21, [x19, #0x38]
005ABB83C  cbz      x21, #0x5abb9f0
005ABB840  ldr      x8, [x21]
005ABB844  ldr      x1, [x22]
005ABB848  ldrh     w9, [x8, #0x12e]
005ABB84C  cbz      x9, #0x5abb870
005ABB850  ldr      x10, [x8, #0xb0]
005ABB854  add      x10, x10, #8
005ABB858  ldur     x11, [x10, #-8]
005ABB85C  cmp      x11, x1
005ABB860  b.eq     #0x5abb880
005ABB864  subs     x9, x9, #1
005ABB868  add      x10, x10, #0x10
005ABB86C  b.ne     #0x5abb858
005ABB870  mov      x0, x21
005ABB874  mov      w2, wzr
005ABB878  bl       #0x3a7e710 ; 
005ABB87C  b        #0x5abb88c ; 
005ABB880  ldrsw    x9, [x10]
005ABB884  add      x8, x8, x9, lsl #4
005ABB888  add      x0, x8, #0x138
005ABB88C  ldp      x8, x1, [x0]
005ABB890  mov      x0, x21
005ABB894  blr      x8
005ABB898  tbz      w0, #0, #0x5abb9c4
005ABB89C  ldr      x21, [x19, #0x38]
005ABB8A0  cbz      x21, #0x5abb9f0
005ABB8A4  ldr      x8, [x20, #0x20]
005ABB8A8  ldr      x8, [x8, #0xc0]
005ABB8AC  ldr      x1, [x8, #0x40]
005ABB8B0  ldrb     w8, [x1, #0x135]
005ABB8B4  tbnz     w8, #0, #0x5abb8c4
005ABB8B8  mov      x0, x1
005ABB8BC  bl       #0x3a7e60c ; 
005ABB8C0  mov      x1, x0
005ABB8C4  ldr      x8, [x21]
005ABB8C8  ldrh     w9, [x8, #0x12e]
005ABB8CC  cbz      x9, #0x5abb8f0
005ABB8D0  ldr      x10, [x8, #0xb0]
005ABB8D4  add      x10, x10, #8
005ABB8D8  ldur     x11, [x10, #-8]
005ABB8DC  cmp      x11, x1
005ABB8E0  b.eq     #0x5abb900
005ABB8E4  subs     x9, x9, #1
005ABB8E8  add      x10, x10, #0x10
005ABB8EC  b.ne     #0x5abb8d8
005ABB8F0  mov      x0, x21
005ABB8F4  mov      w2, wzr
005ABB8F8  bl       #0x3a7e710 ; 
005ABB8FC  b        #0x5abb90c ; 
005ABB900  ldrsw    x9, [x10]
005ABB904  add      x8, x8, x9, lsl #4
005ABB908  add      x0, x8, #0x138
005ABB90C  ldp      x9, x1, [x0]
005ABB910  add      x8, sp, #0x80
005ABB914  mov      x0, x21
005ABB918  blr      x9
005ABB91C  ldp      q0, q1, [sp, #0x80]
005ABB920  ldr      q2, [sp, #0xa0]
005ABB924  ldr      x8, [sp, #0xb0]
005ABB928  stp      q0, q1, [sp, #0x40]
005ABB92C  str      q2, [sp, #0x60]
005ABB930  str      x8, [sp, #0x70]
005ABB934  ldr      x8, [x19, #0x28]
005ABB938  cbz      x8, #0x5abb96c
005ABB93C  ldp      q0, q1, [sp, #0x40]
005ABB940  ldr      q2, [sp, #0x60]
005ABB944  ldr      x10, [sp, #0x70]
005ABB948  ldr      x9, [x8, #0x18]
005ABB94C  ldr      x0, [x8, #0x40]
005ABB950  stp      q0, q1, [sp, #0x80]
005ABB954  str      q2, [sp, #0xa0]
005ABB958  str      x10, [sp, #0xb0]
005ABB95C  ldr      x2, [x8, #0x28]
005ABB960  add      x1, sp, #0x80
005ABB964  blr      x9
005ABB968  tbz      w0, #0, #0x5abb838
005ABB96C  ldr      x8, [x19, #0x30]
005ABB970  ldp      q0, q1, [sp, #0x40]
005ABB974  ldr      q2, [sp, #0x60]
005ABB978  ldr      x9, [sp, #0x70]
005ABB97C  stp      q0, q1, [sp]
005ABB980  str      q2, [sp, #0x20]
005ABB984  str      x9, [sp, #0x30]
005ABB988  cbz      x8, #0x5abb9f0
005ABB98C  ldp      q0, q1, [sp]
005ABB990  ldr      q2, [sp, #0x20]
005ABB994  ldr      x10, [sp, #0x30]
005ABB998  ldr      x9, [x8, #0x18]
005ABB99C  ldr      x0, [x8, #0x40]
005ABB9A0  stp      q0, q1, [sp, #0x80]
005ABB9A4  str      q2, [sp, #0xa0]
005ABB9A8  str      x10, [sp, #0xb0]
005ABB9AC  ldr      x2, [x8, #0x28]
005ABB9B0  add      x1, sp, #0x80
005ABB9B4  blr      x9
005ABB9B8  str      x0, [x19, #0x18]
005ABB9BC  mov      w0, #1
005ABB9C0  b        #0x5abb9dc ; 
005ABB9C4  cbz      x19, #0x5abb9f0
005ABB9C8  ldr      x8, [x19]
005ABB9CC  mov      x0, x19
005ABB9D0  ldp      x9, x1, [x8, #0x1f8]
005ABB9D4  blr      x9
005ABB9D8  mov      w0, wzr
005ABB9DC  ldp      x20, x19, [sp, #0xe0]
005ABB9E0  ldp      x22, x21, [sp, #0xd0]
005ABB9E4  ldr      x30, [sp, #0xc0]
005ABB9E8  add      sp, sp, #0xf0
005ABB9EC  ret      
005ABB9F0  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalCollectionTreasureData>$$Where
; RVA 0x5ABB9F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABB9F4  stp      x30, x21, [sp, #-0x20]!
005ABB9F8  stp      x20, x19, [sp, #0x10]
005ABB9FC  ldr      x8, [x2, #0x20]
005ABBA00  mov      x20, x2
005ABBA04  mov      x19, x1
005ABBA08  mov      x21, x0
005ABBA0C  ldr      x8, [x8, #0xc0]
005ABBA10  ldr      x8, [x8, #0x88]
005ABBA14  ldrb     w9, [x8, #0x135]
005ABBA18  tbnz     w9, #0, #0x5abba28
005ABBA1C  mov      x0, x8
005ABBA20  bl       #0x3a7e60c ; 
005ABBA24  mov      x8, x0
005ABBA28  mov      x0, x8
005ABBA2C  bl       #0x382bfa0 ; 
005ABBA30  ldr      x8, [x20, #0x20]
005ABBA34  mov      x1, x21
005ABBA38  mov      x2, x19
005ABBA3C  mov      x20, x0
005ABBA40  ldr      x8, [x8, #0xc0]
005ABBA44  ldr      x3, [x8, #0x90]
005ABBA48  bl       #0x59c70e0 ; System.Linq.Enumerable.WhereEnumerableIterator<CalCollectionTreasureData>$$.ctor
005ABBA4C  mov      x0, x20
005ABBA50  ldp      x20, x19, [sp, #0x10]
005ABBA54  ldp      x30, x21, [sp], #0x20
005ABBA58  ret      

