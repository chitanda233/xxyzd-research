; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$.ctor
; RVA 0x5ABDB70; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABDB70  str      x30, [sp, #-0x30]!
005ABDB74  stp      x22, x21, [sp, #0x10]
005ABDB78  stp      x20, x19, [sp, #0x20]
005ABDB7C  ldr      x8, [x4, #0x20]
005ABDB80  mov      x21, x1
005ABDB84  mov      x19, x3
005ABDB88  mov      x20, x2
005ABDB8C  ldr      x8, [x8, #0xc0]
005ABDB90  mov      x22, x0
005ABDB94  ldr      x1, [x8]
005ABDB98  bl       #0x4a749e8 ; System.Linq.Enumerable.Iterator<object>$$.ctor
005ABDB9C  mov      x0, x22
005ABDBA0  str      x21, [x0, #0x20]!
005ABDBA4  mov      x1, x21
005ABDBA8  bl       #0x382bcb8 ; 
005ABDBAC  mov      x0, x22
005ABDBB0  str      x20, [x0, #0x28]!
005ABDBB4  mov      x1, x20
005ABDBB8  bl       #0x382bcb8 ; 
005ABDBBC  str      x19, [x22, #0x30]!
005ABDBC0  mov      x0, x22
005ABDBC4  mov      x1, x19
005ABDBC8  ldp      x20, x19, [sp, #0x20]
005ABDBCC  ldp      x22, x21, [sp, #0x10]
005ABDBD0  ldr      x30, [sp], #0x30
005ABDBD4  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Clone
; RVA 0x5ABDBD8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABDBD8  str      x30, [sp, #-0x30]!
005ABDBDC  stp      x22, x21, [sp, #0x10]
005ABDBE0  stp      x20, x19, [sp, #0x20]
005ABDBE4  ldr      x9, [x1, #0x20]
005ABDBE8  mov      x8, x0
005ABDBEC  ldp      x21, x20, [x8, #0x20]
005ABDBF0  ldr      x22, [x8, #0x30]
005ABDBF4  ldr      x9, [x9, #0xc0]
005ABDBF8  mov      x19, x1
005ABDBFC  ldr      x0, [x9, #0x18]
005ABDC00  ldrb     w9, [x0, #0x135]
005ABDC04  tbnz     w9, #0, #0x5abdc0c
005ABDC08  bl       #0x3a7e60c ; 
005ABDC0C  bl       #0x382bfa0 ; 
005ABDC10  ldr      x8, [x19, #0x20]
005ABDC14  mov      x1, x21
005ABDC18  mov      x2, x20
005ABDC1C  mov      x3, x22
005ABDC20  ldr      x8, [x8, #0xc0]
005ABDC24  mov      x19, x0
005ABDC28  ldr      x4, [x8, #0x30]
005ABDC2C  bl       #0x5abdb70 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$.ctor
005ABDC30  mov      x0, x19
005ABDC34  ldp      x20, x19, [sp, #0x20]
005ABDC38  ldp      x22, x21, [sp, #0x10]
005ABDC3C  ldr      x30, [sp], #0x30
005ABDC40  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Dispose
; RVA 0x5ABDC44; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABDC44  str      x30, [sp, #-0x30]!
005ABDC48  stp      x22, x21, [sp, #0x10]
005ABDC4C  stp      x20, x19, [sp, #0x20]
005ABDC50  adrp     x21, #0x9595000
005ABDC54  ldrb     w8, [x21, #0x45d]
005ABDC58  mov      x19, x1
005ABDC5C  mov      x20, x0
005ABDC60  tbnz     w8, #0, #0x5abdc78
005ABDC64  adrp     x0, #0x8ebf000
005ABDC68  ldr      x0, [x0, #0x4e8]
005ABDC6C  bl       #0x382bd14 ; 
005ABDC70  mov      w8, #1
005ABDC74  strb     w8, [x21, #0x45d]
005ABDC78  mov      x21, x20
005ABDC7C  ldr      x22, [x21, #0x38]!
005ABDC80  cbz      x22, #0x5abdce4
005ABDC84  adrp     x10, #0x8ebf000
005ABDC88  ldr      x8, [x22]
005ABDC8C  ldr      x10, [x10, #0x4e8]
005ABDC90  ldrh     w9, [x8, #0x12e]
005ABDC94  ldr      x1, [x10]
005ABDC98  cbz      x9, #0x5abdcbc
005ABDC9C  ldr      x10, [x8, #0xb0]
005ABDCA0  add      x10, x10, #8
005ABDCA4  ldur     x11, [x10, #-8]
005ABDCA8  cmp      x11, x1
005ABDCAC  b.eq     #0x5abdccc
005ABDCB0  subs     x9, x9, #1
005ABDCB4  add      x10, x10, #0x10
005ABDCB8  b.ne     #0x5abdca4
005ABDCBC  mov      x0, x22
005ABDCC0  mov      w2, wzr
005ABDCC4  bl       #0x3a7e710 ; 
005ABDCC8  b        #0x5abdcd8 ; 
005ABDCCC  ldrsw    x9, [x10]
005ABDCD0  add      x8, x8, x9, lsl #4
005ABDCD4  add      x0, x8, #0x138
005ABDCD8  ldp      x8, x1, [x0]
005ABDCDC  mov      x0, x22
005ABDCE0  blr      x8
005ABDCE4  mov      x0, x21
005ABDCE8  mov      x1, xzr
005ABDCEC  str      xzr, [x20, #0x38]
005ABDCF0  bl       #0x382bcb8 ; 
005ABDCF4  ldr      x8, [x19, #0x20]
005ABDCF8  mov      x0, x20
005ABDCFC  ldp      x20, x19, [sp, #0x20]
005ABDD00  ldp      x22, x21, [sp, #0x10]
005ABDD04  ldr      x8, [x8, #0xc0]
005ABDD08  ldr      x1, [x8, #0x48]
005ABDD0C  ldr      x30, [sp], #0x30
005ABDD10  b        #0x4a74a24 ; System.Linq.Enumerable.Iterator<object>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$MoveNext
; RVA 0x5ABDD14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABDD14  sub      sp, sp, #0xf0
005ABDD18  str      x30, [sp, #0xc0]
005ABDD1C  stp      x22, x21, [sp, #0xd0]
005ABDD20  stp      x20, x19, [sp, #0xe0]
005ABDD24  adrp     x21, #0x9595000
005ABDD28  ldrb     w8, [x21, #0x45e]
005ABDD2C  mov      x20, x1
005ABDD30  mov      x19, x0
005ABDD34  tbnz     w8, #0, #0x5abdd4c
005ABDD38  adrp     x0, #0x8ebf000
005ABDD3C  ldr      x0, [x0, #0x4f0]
005ABDD40  bl       #0x382bd14 ; 
005ABDD44  mov      w8, #1
005ABDD48  strb     w8, [x21, #0x45e]
005ABDD4C  ldr      w8, [x19, #0x14]
005ABDD50  adrp     x22, #0x8ebf000
005ABDD54  ldr      x22, [x22, #0x4f0]
005ABDD58  cmp      w8, #2
005ABDD5C  b.eq     #0x5abde00
005ABDD60  cmp      w8, #1
005ABDD64  b.ne     #0x5abdfac
005ABDD68  ldr      x21, [x19, #0x20]
005ABDD6C  cbz      x21, #0x5abdfc4
005ABDD70  ldr      x8, [x20, #0x20]
005ABDD74  ldr      x8, [x8, #0xc0]
005ABDD78  ldr      x1, [x8, #0x10]
005ABDD7C  ldrb     w8, [x1, #0x135]
005ABDD80  tbnz     w8, #0, #0x5abdd90
005ABDD84  mov      x0, x1
005ABDD88  bl       #0x3a7e60c ; 
005ABDD8C  mov      x1, x0
005ABDD90  ldr      x8, [x21]
005ABDD94  ldrh     w9, [x8, #0x12e]
005ABDD98  cbz      x9, #0x5abddbc
005ABDD9C  ldr      x10, [x8, #0xb0]
005ABDDA0  add      x10, x10, #8
005ABDDA4  ldur     x11, [x10, #-8]
005ABDDA8  cmp      x11, x1
005ABDDAC  b.eq     #0x5abddcc
005ABDDB0  subs     x9, x9, #1
005ABDDB4  add      x10, x10, #0x10
005ABDDB8  b.ne     #0x5abdda4
005ABDDBC  mov      x0, x21
005ABDDC0  mov      w2, wzr
005ABDDC4  bl       #0x3a7e710 ; 
005ABDDC8  b        #0x5abddd8 ; 
005ABDDCC  ldrsw    x9, [x10]
005ABDDD0  add      x8, x8, x9, lsl #4
005ABDDD4  add      x0, x8, #0x138
005ABDDD8  ldp      x8, x1, [x0]
005ABDDDC  mov      x0, x21
005ABDDE0  blr      x8
005ABDDE4  mov      x21, x19
005ABDDE8  str      x0, [x21, #0x38]!
005ABDDEC  mov      x1, x0
005ABDDF0  mov      x0, x21
005ABDDF4  bl       #0x382bcb8 ; 
005ABDDF8  mov      w8, #2
005ABDDFC  stur     w8, [x21, #-0x24]
005ABDE00  ldr      x21, [x19, #0x38]
005ABDE04  cbz      x21, #0x5abdfc4
005ABDE08  ldr      x8, [x21]
005ABDE0C  ldr      x1, [x22]
005ABDE10  ldrh     w9, [x8, #0x12e]
005ABDE14  cbz      x9, #0x5abde38
005ABDE18  ldr      x10, [x8, #0xb0]
005ABDE1C  add      x10, x10, #8
005ABDE20  ldur     x11, [x10, #-8]
005ABDE24  cmp      x11, x1
005ABDE28  b.eq     #0x5abde48
005ABDE2C  subs     x9, x9, #1
005ABDE30  add      x10, x10, #0x10
005ABDE34  b.ne     #0x5abde20
005ABDE38  mov      x0, x21
005ABDE3C  mov      w2, wzr
005ABDE40  bl       #0x3a7e710 ; 
005ABDE44  b        #0x5abde54 ; 
005ABDE48  ldrsw    x9, [x10]
005ABDE4C  add      x8, x8, x9, lsl #4
005ABDE50  add      x0, x8, #0x138
005ABDE54  ldp      x8, x1, [x0]
005ABDE58  mov      x0, x21
005ABDE5C  blr      x8
005ABDE60  tbz      w0, #0, #0x5abdf98
005ABDE64  ldr      x21, [x19, #0x38]
005ABDE68  cbz      x21, #0x5abdfc4
005ABDE6C  ldr      x8, [x20, #0x20]
005ABDE70  ldr      x8, [x8, #0xc0]
005ABDE74  ldr      x1, [x8, #0x40]
005ABDE78  ldrb     w8, [x1, #0x135]
005ABDE7C  tbnz     w8, #0, #0x5abde8c
005ABDE80  mov      x0, x1
005ABDE84  bl       #0x3a7e60c ; 
005ABDE88  mov      x1, x0
005ABDE8C  ldr      x8, [x21]
005ABDE90  ldrh     w9, [x8, #0x12e]
005ABDE94  cbz      x9, #0x5abdeb8
005ABDE98  ldr      x10, [x8, #0xb0]
005ABDE9C  add      x10, x10, #8
005ABDEA0  ldur     x11, [x10, #-8]
005ABDEA4  cmp      x11, x1
005ABDEA8  b.eq     #0x5abdec8
005ABDEAC  subs     x9, x9, #1
005ABDEB0  add      x10, x10, #0x10
005ABDEB4  b.ne     #0x5abdea0
005ABDEB8  mov      x0, x21
005ABDEBC  mov      w2, wzr
005ABDEC0  bl       #0x3a7e710 ; 
005ABDEC4  b        #0x5abded4 ; 
005ABDEC8  ldrsw    x9, [x10]
005ABDECC  add      x8, x8, x9, lsl #4
005ABDED0  add      x0, x8, #0x138
005ABDED4  ldp      x9, x1, [x0]
005ABDED8  add      x8, sp, #0x80
005ABDEDC  mov      x0, x21
005ABDEE0  blr      x9
005ABDEE4  ldp      q0, q1, [sp, #0x80]
005ABDEE8  ldr      q2, [sp, #0xa0]
005ABDEEC  ldr      x8, [sp, #0xb0]
005ABDEF0  stp      q0, q1, [sp, #0x40]
005ABDEF4  str      q2, [sp, #0x60]
005ABDEF8  str      x8, [sp, #0x70]
005ABDEFC  ldr      x8, [x19, #0x28]
005ABDF00  cbz      x8, #0x5abdf34
005ABDF04  ldp      q0, q1, [sp, #0x40]
005ABDF08  ldr      q2, [sp, #0x60]
005ABDF0C  ldr      x10, [sp, #0x70]
005ABDF10  ldr      x9, [x8, #0x18]
005ABDF14  ldr      x0, [x8, #0x40]
005ABDF18  stp      q0, q1, [sp, #0x80]
005ABDF1C  str      q2, [sp, #0xa0]
005ABDF20  str      x10, [sp, #0xb0]
005ABDF24  ldr      x2, [x8, #0x28]
005ABDF28  add      x1, sp, #0x80
005ABDF2C  blr      x9
005ABDF30  tbz      w0, #0, #0x5abde00
005ABDF34  ldr      x8, [x19, #0x30]
005ABDF38  ldp      q0, q1, [sp, #0x40]
005ABDF3C  ldr      q2, [sp, #0x60]
005ABDF40  ldr      x9, [sp, #0x70]
005ABDF44  stp      q0, q1, [sp]
005ABDF48  str      q2, [sp, #0x20]
005ABDF4C  str      x9, [sp, #0x30]
005ABDF50  cbz      x8, #0x5abdfc4
005ABDF54  ldp      q0, q1, [sp]
005ABDF58  ldr      q2, [sp, #0x20]
005ABDF5C  ldr      x10, [sp, #0x30]
005ABDF60  ldr      x9, [x8, #0x18]
005ABDF64  ldr      x0, [x8, #0x40]
005ABDF68  stp      q0, q1, [sp, #0x80]
005ABDF6C  str      q2, [sp, #0xa0]
005ABDF70  str      x10, [sp, #0xb0]
005ABDF74  ldr      x2, [x8, #0x28]
005ABDF78  add      x1, sp, #0x80
005ABDF7C  blr      x9
005ABDF80  str      x0, [x19, #0x18]!
005ABDF84  mov      x1, x0
005ABDF88  mov      x0, x19
005ABDF8C  bl       #0x382bcb8 ; 
005ABDF90  mov      w0, #1
005ABDF94  b        #0x5abdfb0 ; 
005ABDF98  cbz      x19, #0x5abdfc4
005ABDF9C  ldr      x8, [x19]
005ABDFA0  mov      x0, x19
005ABDFA4  ldp      x9, x1, [x8, #0x1f8]
005ABDFA8  blr      x9
005ABDFAC  mov      w0, wzr
005ABDFB0  ldp      x20, x19, [sp, #0xe0]
005ABDFB4  ldp      x22, x21, [sp, #0xd0]
005ABDFB8  ldr      x30, [sp, #0xc0]
005ABDFBC  add      sp, sp, #0xf0
005ABDFC0  ret      
005ABDFC4  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<ValueTuple<int, int>>
; RVA 0x44A28A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A28A0  stp      x30, x23, [sp, #-0x30]!
0044A28A4  stp      x22, x21, [sp, #0x10]
0044A28A8  stp      x20, x19, [sp, #0x20]
0044A28AC  ldr      x8, [x2, #0x38]
0044A28B0  mov      x19, x2
0044A28B4  mov      x22, x1
0044A28B8  mov      x23, x0
0044A28BC  cbnz     x8, #0x44a28cc
0044A28C0  mov      x0, x19
0044A28C4  bl       #0x3a7e668 ; 
0044A28C8  ldr      x8, [x19, #0x38]
0044A28CC  ldr      x0, [x23, #0x30]
0044A28D0  ldr      x2, [x8, #8]
0044A28D4  ldp      x20, x21, [x23, #0x20]
0044A28D8  mov      x1, x22
0044A28DC  bl       #0x45a0930 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, ValueTuple<int, int>>
0044A28E0  ldr      x8, [x19, #0x38]
0044A28E4  mov      x22, x0
0044A28E8  ldr      x8, [x8, #0x18]
0044A28EC  ldrb     w9, [x8, #0x135]
0044A28F0  tbnz     w9, #0, #0x44a2900
0044A28F4  mov      x0, x8
0044A28F8  bl       #0x3a7e60c ; 
0044A28FC  mov      x8, x0
0044A2900  mov      x0, x8
0044A2904  bl       #0x382bfa0 ; 
0044A2908  ldr      x8, [x19, #0x38]
0044A290C  mov      x1, x20
0044A2910  mov      x2, x21
0044A2914  mov      x3, x22
0044A2918  ldr      x4, [x8, #0x20]
0044A291C  mov      x19, x0
0044A2920  bl       #0x5ab9df0 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, ValueTuple<int, int>>$$.ctor
0044A2924  mov      x0, x19
0044A2928  ldp      x20, x19, [sp, #0x20]
0044A292C  ldp      x22, x21, [sp, #0x10]
0044A2930  ldp      x30, x23, [sp], #0x30
0044A2934  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<AttributeOneElement>
; RVA 0x44A2938; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2938  stp      x30, x23, [sp, #-0x30]!
0044A293C  stp      x22, x21, [sp, #0x10]
0044A2940  stp      x20, x19, [sp, #0x20]
0044A2944  ldr      x8, [x2, #0x38]
0044A2948  mov      x19, x2
0044A294C  mov      x22, x1
0044A2950  mov      x23, x0
0044A2954  cbnz     x8, #0x44a2964
0044A2958  mov      x0, x19
0044A295C  bl       #0x3a7e668 ; 
0044A2960  ldr      x8, [x19, #0x38]
0044A2964  ldr      x0, [x23, #0x30]
0044A2968  ldr      x2, [x8, #8]
0044A296C  ldp      x20, x21, [x23, #0x20]
0044A2970  mov      x1, x22
0044A2974  bl       #0x45a09ec ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, AttributeOneElement>
0044A2978  ldr      x8, [x19, #0x38]
0044A297C  mov      x22, x0
0044A2980  ldr      x8, [x8, #0x18]
0044A2984  ldrb     w9, [x8, #0x135]
0044A2988  tbnz     w9, #0, #0x44a2998
0044A298C  mov      x0, x8
0044A2990  bl       #0x3a7e60c ; 
0044A2994  mov      x8, x0
0044A2998  mov      x0, x8
0044A299C  bl       #0x382bfa0 ; 
0044A29A0  ldr      x8, [x19, #0x38]
0044A29A4  mov      x1, x20
0044A29A8  mov      x2, x21
0044A29AC  mov      x3, x22
0044A29B0  ldr      x4, [x8, #0x20]
0044A29B4  mov      x19, x0
0044A29B8  bl       #0x5aba2a4 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, AttributeOneElement>$$.ctor
0044A29BC  mov      x0, x19
0044A29C0  ldp      x20, x19, [sp, #0x20]
0044A29C4  ldp      x22, x21, [sp, #0x10]
0044A29C8  ldp      x30, x23, [sp], #0x30
0044A29CC  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<bool>
; RVA 0x44A29D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A29D0  stp      x30, x23, [sp, #-0x30]!
0044A29D4  stp      x22, x21, [sp, #0x10]
0044A29D8  stp      x20, x19, [sp, #0x20]
0044A29DC  ldr      x8, [x2, #0x38]
0044A29E0  mov      x19, x2
0044A29E4  mov      x22, x1
0044A29E8  mov      x23, x0
0044A29EC  cbnz     x8, #0x44a29fc
0044A29F0  mov      x0, x19
0044A29F4  bl       #0x3a7e668 ; 
0044A29F8  ldr      x8, [x19, #0x38]
0044A29FC  ldr      x0, [x23, #0x30]
0044A2A00  ldr      x2, [x8, #8]
0044A2A04  ldp      x20, x21, [x23, #0x20]
0044A2A08  mov      x1, x22
0044A2A0C  bl       #0x45a0aa8 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, bool>
0044A2A10  ldr      x8, [x19, #0x38]
0044A2A14  mov      x22, x0
0044A2A18  ldr      x8, [x8, #0x18]
0044A2A1C  ldrb     w9, [x8, #0x135]
0044A2A20  tbnz     w9, #0, #0x44a2a30
0044A2A24  mov      x0, x8
0044A2A28  bl       #0x3a7e60c ; 
0044A2A2C  mov      x8, x0
0044A2A30  mov      x0, x8
0044A2A34  bl       #0x382bfa0 ; 
0044A2A38  ldr      x8, [x19, #0x38]
0044A2A3C  mov      x1, x20
0044A2A40  mov      x2, x21
0044A2A44  mov      x3, x22
0044A2A48  ldr      x4, [x8, #0x20]
0044A2A4C  mov      x19, x0
0044A2A50  bl       #0x5aba788 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, bool>$$.ctor
0044A2A54  mov      x0, x19
0044A2A58  ldp      x20, x19, [sp, #0x20]
0044A2A5C  ldp      x22, x21, [sp, #0x10]
0044A2A60  ldp      x30, x23, [sp], #0x30
0044A2A64  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<CalAttrCardData>
; RVA 0x44A2A68; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2A68  stp      x30, x23, [sp, #-0x30]!
0044A2A6C  stp      x22, x21, [sp, #0x10]
0044A2A70  stp      x20, x19, [sp, #0x20]
0044A2A74  ldr      x8, [x2, #0x38]
0044A2A78  mov      x19, x2
0044A2A7C  mov      x22, x1
0044A2A80  mov      x23, x0
0044A2A84  cbnz     x8, #0x44a2a94
0044A2A88  mov      x0, x19
0044A2A8C  bl       #0x3a7e668 ; 
0044A2A90  ldr      x8, [x19, #0x38]
0044A2A94  ldr      x0, [x23, #0x30]
0044A2A98  ldr      x2, [x8, #8]
0044A2A9C  ldp      x20, x21, [x23, #0x20]
0044A2AA0  mov      x1, x22
0044A2AA4  bl       #0x45a0b64 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalAttrCardData>
0044A2AA8  ldr      x8, [x19, #0x38]
0044A2AAC  mov      x22, x0
0044A2AB0  ldr      x8, [x8, #0x18]
0044A2AB4  ldrb     w9, [x8, #0x135]
0044A2AB8  tbnz     w9, #0, #0x44a2ac8
0044A2ABC  mov      x0, x8
0044A2AC0  bl       #0x3a7e60c ; 
0044A2AC4  mov      x8, x0
0044A2AC8  mov      x0, x8
0044A2ACC  bl       #0x382bfa0 ; 
0044A2AD0  ldr      x8, [x19, #0x38]
0044A2AD4  mov      x1, x20
0044A2AD8  mov      x2, x21
0044A2ADC  mov      x3, x22
0044A2AE0  ldr      x4, [x8, #0x20]
0044A2AE4  mov      x19, x0
0044A2AE8  bl       #0x5abac40 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrCardData>$$.ctor
0044A2AEC  mov      x0, x19
0044A2AF0  ldp      x20, x19, [sp, #0x20]
0044A2AF4  ldp      x22, x21, [sp, #0x10]
0044A2AF8  ldp      x30, x23, [sp], #0x30
0044A2AFC  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<CalAttrRelicData>
; RVA 0x44A2B00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2B00  stp      x30, x23, [sp, #-0x30]!
0044A2B04  stp      x22, x21, [sp, #0x10]
0044A2B08  stp      x20, x19, [sp, #0x20]
0044A2B0C  ldr      x8, [x2, #0x38]
0044A2B10  mov      x19, x2
0044A2B14  mov      x22, x1
0044A2B18  mov      x23, x0
0044A2B1C  cbnz     x8, #0x44a2b2c
0044A2B20  mov      x0, x19
0044A2B24  bl       #0x3a7e668 ; 
0044A2B28  ldr      x8, [x19, #0x38]
0044A2B2C  ldr      x0, [x23, #0x30]
0044A2B30  ldr      x2, [x8, #8]
0044A2B34  ldp      x20, x21, [x23, #0x20]
0044A2B38  mov      x1, x22
0044A2B3C  bl       #0x45a0c20 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalAttrRelicData>
0044A2B40  ldr      x8, [x19, #0x38]
0044A2B44  mov      x22, x0
0044A2B48  ldr      x8, [x8, #0x18]
0044A2B4C  ldrb     w9, [x8, #0x135]
0044A2B50  tbnz     w9, #0, #0x44a2b60
0044A2B54  mov      x0, x8
0044A2B58  bl       #0x3a7e60c ; 
0044A2B5C  mov      x8, x0
0044A2B60  mov      x0, x8
0044A2B64  bl       #0x382bfa0 ; 
0044A2B68  ldr      x8, [x19, #0x38]
0044A2B6C  mov      x1, x20
0044A2B70  mov      x2, x21
0044A2B74  mov      x3, x22
0044A2B78  ldr      x4, [x8, #0x20]
0044A2B7C  mov      x19, x0
0044A2B80  bl       #0x5abb0f4 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrRelicData>$$.ctor
0044A2B84  mov      x0, x19
0044A2B88  ldp      x20, x19, [sp, #0x20]
0044A2B8C  ldp      x22, x21, [sp, #0x10]
0044A2B90  ldp      x30, x23, [sp], #0x30
0044A2B94  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<CalCollectionTreasureData>
; RVA 0x44A2B98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2B98  stp      x30, x23, [sp, #-0x30]!
0044A2B9C  stp      x22, x21, [sp, #0x10]
0044A2BA0  stp      x20, x19, [sp, #0x20]
0044A2BA4  ldr      x8, [x2, #0x38]
0044A2BA8  mov      x19, x2
0044A2BAC  mov      x22, x1
0044A2BB0  mov      x23, x0
0044A2BB4  cbnz     x8, #0x44a2bc4
0044A2BB8  mov      x0, x19
0044A2BBC  bl       #0x3a7e668 ; 
0044A2BC0  ldr      x8, [x19, #0x38]
0044A2BC4  ldr      x0, [x23, #0x30]
0044A2BC8  ldr      x2, [x8, #8]
0044A2BCC  ldp      x20, x21, [x23, #0x20]
0044A2BD0  mov      x1, x22
0044A2BD4  bl       #0x45a0cdc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalCollectionTreasureData>
0044A2BD8  ldr      x8, [x19, #0x38]
0044A2BDC  mov      x22, x0
0044A2BE0  ldr      x8, [x8, #0x18]
0044A2BE4  ldrb     w9, [x8, #0x135]
0044A2BE8  tbnz     w9, #0, #0x44a2bf8
0044A2BEC  mov      x0, x8
0044A2BF0  bl       #0x3a7e60c ; 
0044A2BF4  mov      x8, x0
0044A2BF8  mov      x0, x8
0044A2BFC  bl       #0x382bfa0 ; 
0044A2C00  ldr      x8, [x19, #0x38]
0044A2C04  mov      x1, x20
0044A2C08  mov      x2, x21
0044A2C0C  mov      x3, x22
0044A2C10  ldr      x4, [x8, #0x20]
0044A2C14  mov      x19, x0
0044A2C18  bl       #0x5abb5a8 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalCollectionTreasureData>$$.ctor
0044A2C1C  mov      x0, x19
0044A2C20  ldp      x20, x19, [sp, #0x20]
0044A2C24  ldp      x22, x21, [sp, #0x10]
0044A2C28  ldp      x30, x23, [sp], #0x30
0044A2C2C  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<CalEquipData>
; RVA 0x44A2C30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2C30  stp      x30, x23, [sp, #-0x30]!
0044A2C34  stp      x22, x21, [sp, #0x10]
0044A2C38  stp      x20, x19, [sp, #0x20]
0044A2C3C  ldr      x8, [x2, #0x38]
0044A2C40  mov      x19, x2
0044A2C44  mov      x22, x1
0044A2C48  mov      x23, x0
0044A2C4C  cbnz     x8, #0x44a2c5c
0044A2C50  mov      x0, x19
0044A2C54  bl       #0x3a7e668 ; 
0044A2C58  ldr      x8, [x19, #0x38]
0044A2C5C  ldr      x0, [x23, #0x30]
0044A2C60  ldr      x2, [x8, #8]
0044A2C64  ldp      x20, x21, [x23, #0x20]
0044A2C68  mov      x1, x22
0044A2C6C  bl       #0x45a0d98 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalEquipData>
0044A2C70  ldr      x8, [x19, #0x38]
0044A2C74  mov      x22, x0
0044A2C78  ldr      x8, [x8, #0x18]
0044A2C7C  ldrb     w9, [x8, #0x135]
0044A2C80  tbnz     w9, #0, #0x44a2c90
0044A2C84  mov      x0, x8
0044A2C88  bl       #0x3a7e60c ; 
0044A2C8C  mov      x8, x0
0044A2C90  mov      x0, x8
0044A2C94  bl       #0x382bfa0 ; 
0044A2C98  ldr      x8, [x19, #0x38]
0044A2C9C  mov      x1, x20
0044A2CA0  mov      x2, x21
0044A2CA4  mov      x3, x22
0044A2CA8  ldr      x4, [x8, #0x20]
0044A2CAC  mov      x19, x0
0044A2CB0  bl       #0x5abba5c ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalEquipData>$$.ctor
0044A2CB4  mov      x0, x19
0044A2CB8  ldp      x20, x19, [sp, #0x20]
0044A2CBC  ldp      x22, x21, [sp, #0x10]
0044A2CC0  ldp      x30, x23, [sp], #0x30
0044A2CC4  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<CalRoleData>
; RVA 0x44A2CC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2CC8  stp      x30, x23, [sp, #-0x30]!
0044A2CCC  stp      x22, x21, [sp, #0x10]
0044A2CD0  stp      x20, x19, [sp, #0x20]
0044A2CD4  ldr      x8, [x2, #0x38]
0044A2CD8  mov      x19, x2
0044A2CDC  mov      x22, x1
0044A2CE0  mov      x23, x0
0044A2CE4  cbnz     x8, #0x44a2cf4
0044A2CE8  mov      x0, x19
0044A2CEC  bl       #0x3a7e668 ; 
0044A2CF0  ldr      x8, [x19, #0x38]
0044A2CF4  ldr      x0, [x23, #0x30]
0044A2CF8  ldr      x2, [x8, #8]
0044A2CFC  ldp      x20, x21, [x23, #0x20]
0044A2D00  mov      x1, x22
0044A2D04  bl       #0x45a0e54 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalRoleData>
0044A2D08  ldr      x8, [x19, #0x38]
0044A2D0C  mov      x22, x0
0044A2D10  ldr      x8, [x8, #0x18]
0044A2D14  ldrb     w9, [x8, #0x135]
0044A2D18  tbnz     w9, #0, #0x44a2d28
0044A2D1C  mov      x0, x8
0044A2D20  bl       #0x3a7e60c ; 
0044A2D24  mov      x8, x0
0044A2D28  mov      x0, x8
0044A2D2C  bl       #0x382bfa0 ; 
0044A2D30  ldr      x8, [x19, #0x38]
0044A2D34  mov      x1, x20
0044A2D38  mov      x2, x21
0044A2D3C  mov      x3, x22
0044A2D40  ldr      x4, [x8, #0x20]
0044A2D44  mov      x19, x0
0044A2D48  bl       #0x5abbf10 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRoleData>$$.ctor
0044A2D4C  mov      x0, x19
0044A2D50  ldp      x20, x19, [sp, #0x20]
0044A2D54  ldp      x22, x21, [sp, #0x10]
0044A2D58  ldp      x30, x23, [sp], #0x30
0044A2D5C  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<CalRuneData>
; RVA 0x44A2D60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2D60  stp      x30, x23, [sp, #-0x30]!
0044A2D64  stp      x22, x21, [sp, #0x10]
0044A2D68  stp      x20, x19, [sp, #0x20]
0044A2D6C  ldr      x8, [x2, #0x38]
0044A2D70  mov      x19, x2
0044A2D74  mov      x22, x1
0044A2D78  mov      x23, x0
0044A2D7C  cbnz     x8, #0x44a2d8c
0044A2D80  mov      x0, x19
0044A2D84  bl       #0x3a7e668 ; 
0044A2D88  ldr      x8, [x19, #0x38]
0044A2D8C  ldr      x0, [x23, #0x30]
0044A2D90  ldr      x2, [x8, #8]
0044A2D94  ldp      x20, x21, [x23, #0x20]
0044A2D98  mov      x1, x22
0044A2D9C  bl       #0x45a0f10 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalRuneData>
0044A2DA0  ldr      x8, [x19, #0x38]
0044A2DA4  mov      x22, x0
0044A2DA8  ldr      x8, [x8, #0x18]
0044A2DAC  ldrb     w9, [x8, #0x135]
0044A2DB0  tbnz     w9, #0, #0x44a2dc0
0044A2DB4  mov      x0, x8
0044A2DB8  bl       #0x3a7e60c ; 
0044A2DBC  mov      x8, x0
0044A2DC0  mov      x0, x8
0044A2DC4  bl       #0x382bfa0 ; 
0044A2DC8  ldr      x8, [x19, #0x38]
0044A2DCC  mov      x1, x20
0044A2DD0  mov      x2, x21
0044A2DD4  mov      x3, x22
0044A2DD8  ldr      x4, [x8, #0x20]
0044A2DDC  mov      x19, x0
0044A2DE0  bl       #0x5abc3ec ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRuneData>$$.ctor
0044A2DE4  mov      x0, x19
0044A2DE8  ldp      x20, x19, [sp, #0x20]
0044A2DEC  ldp      x22, x21, [sp, #0x10]
0044A2DF0  ldp      x30, x23, [sp], #0x30
0044A2DF4  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<char>
; RVA 0x44A2DF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2DF8  stp      x30, x23, [sp, #-0x30]!
0044A2DFC  stp      x22, x21, [sp, #0x10]
0044A2E00  stp      x20, x19, [sp, #0x20]
0044A2E04  ldr      x8, [x2, #0x38]
0044A2E08  mov      x19, x2
0044A2E0C  mov      x22, x1
0044A2E10  mov      x23, x0
0044A2E14  cbnz     x8, #0x44a2e24
0044A2E18  mov      x0, x19
0044A2E1C  bl       #0x3a7e668 ; 
0044A2E20  ldr      x8, [x19, #0x38]
0044A2E24  ldr      x0, [x23, #0x30]
0044A2E28  ldr      x2, [x8, #8]
0044A2E2C  ldp      x20, x21, [x23, #0x20]
0044A2E30  mov      x1, x22
0044A2E34  bl       #0x45a0fcc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, char>
0044A2E38  ldr      x8, [x19, #0x38]
0044A2E3C  mov      x22, x0
0044A2E40  ldr      x8, [x8, #0x18]
0044A2E44  ldrb     w9, [x8, #0x135]
0044A2E48  tbnz     w9, #0, #0x44a2e58
0044A2E4C  mov      x0, x8
0044A2E50  bl       #0x3a7e60c ; 
0044A2E54  mov      x8, x0
0044A2E58  mov      x0, x8
0044A2E5C  bl       #0x382bfa0 ; 
0044A2E60  ldr      x8, [x19, #0x38]
0044A2E64  mov      x1, x20
0044A2E68  mov      x2, x21
0044A2E6C  mov      x3, x22
0044A2E70  ldr      x4, [x8, #0x20]
0044A2E74  mov      x19, x0
0044A2E78  bl       #0x5abc8a0 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, char>$$.ctor
0044A2E7C  mov      x0, x19
0044A2E80  ldp      x20, x19, [sp, #0x20]
0044A2E84  ldp      x22, x21, [sp, #0x10]
0044A2E88  ldp      x30, x23, [sp], #0x30
0044A2E8C  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<int>
; RVA 0x44A2E90; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2E90  stp      x30, x23, [sp, #-0x30]!
0044A2E94  stp      x22, x21, [sp, #0x10]
0044A2E98  stp      x20, x19, [sp, #0x20]
0044A2E9C  ldr      x8, [x2, #0x38]
0044A2EA0  mov      x19, x2
0044A2EA4  mov      x22, x1
0044A2EA8  mov      x23, x0
0044A2EAC  cbnz     x8, #0x44a2ebc
0044A2EB0  mov      x0, x19
0044A2EB4  bl       #0x3a7e668 ; 
0044A2EB8  ldr      x8, [x19, #0x38]
0044A2EBC  ldr      x0, [x23, #0x30]
0044A2EC0  ldr      x2, [x8, #8]
0044A2EC4  ldp      x20, x21, [x23, #0x20]
0044A2EC8  mov      x1, x22
0044A2ECC  bl       #0x45a1088 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, int>
0044A2ED0  ldr      x8, [x19, #0x38]
0044A2ED4  mov      x22, x0
0044A2ED8  ldr      x8, [x8, #0x18]
0044A2EDC  ldrb     w9, [x8, #0x135]
0044A2EE0  tbnz     w9, #0, #0x44a2ef0
0044A2EE4  mov      x0, x8
0044A2EE8  bl       #0x3a7e60c ; 
0044A2EEC  mov      x8, x0
0044A2EF0  mov      x0, x8
0044A2EF4  bl       #0x382bfa0 ; 
0044A2EF8  ldr      x8, [x19, #0x38]
0044A2EFC  mov      x1, x20
0044A2F00  mov      x2, x21
0044A2F04  mov      x3, x22
0044A2F08  ldr      x4, [x8, #0x20]
0044A2F0C  mov      x19, x0
0044A2F10  bl       #0x5abcd54 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, int>$$.ctor
0044A2F14  mov      x0, x19
0044A2F18  ldp      x20, x19, [sp, #0x20]
0044A2F1C  ldp      x22, x21, [sp, #0x10]
0044A2F20  ldp      x30, x23, [sp], #0x30
0044A2F24  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<Int32Enum>
; RVA 0x44A2F28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2F28  stp      x30, x23, [sp, #-0x30]!
0044A2F2C  stp      x22, x21, [sp, #0x10]
0044A2F30  stp      x20, x19, [sp, #0x20]
0044A2F34  ldr      x8, [x2, #0x38]
0044A2F38  mov      x19, x2
0044A2F3C  mov      x22, x1
0044A2F40  mov      x23, x0
0044A2F44  cbnz     x8, #0x44a2f54
0044A2F48  mov      x0, x19
0044A2F4C  bl       #0x3a7e668 ; 
0044A2F50  ldr      x8, [x19, #0x38]
0044A2F54  ldr      x0, [x23, #0x30]
0044A2F58  ldr      x2, [x8, #8]
0044A2F5C  ldp      x20, x21, [x23, #0x20]
0044A2F60  mov      x1, x22
0044A2F64  bl       #0x45a1144 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, Int32Enum>
0044A2F68  ldr      x8, [x19, #0x38]
0044A2F6C  mov      x22, x0
0044A2F70  ldr      x8, [x8, #0x18]
0044A2F74  ldrb     w9, [x8, #0x135]
0044A2F78  tbnz     w9, #0, #0x44a2f88
0044A2F7C  mov      x0, x8
0044A2F80  bl       #0x3a7e60c ; 
0044A2F84  mov      x8, x0
0044A2F88  mov      x0, x8
0044A2F8C  bl       #0x382bfa0 ; 
0044A2F90  ldr      x8, [x19, #0x38]
0044A2F94  mov      x1, x20
0044A2F98  mov      x2, x21
0044A2F9C  mov      x3, x22
0044A2FA0  ldr      x4, [x8, #0x20]
0044A2FA4  mov      x19, x0
0044A2FA8  bl       #0x5abd208 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Int32Enum>$$.ctor
0044A2FAC  mov      x0, x19
0044A2FB0  ldp      x20, x19, [sp, #0x20]
0044A2FB4  ldp      x22, x21, [sp, #0x10]
0044A2FB8  ldp      x30, x23, [sp], #0x30
0044A2FBC  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<long>
; RVA 0x44A2FC0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A2FC0  stp      x30, x23, [sp, #-0x30]!
0044A2FC4  stp      x22, x21, [sp, #0x10]
0044A2FC8  stp      x20, x19, [sp, #0x20]
0044A2FCC  ldr      x8, [x2, #0x38]
0044A2FD0  mov      x19, x2
0044A2FD4  mov      x22, x1
0044A2FD8  mov      x23, x0
0044A2FDC  cbnz     x8, #0x44a2fec
0044A2FE0  mov      x0, x19
0044A2FE4  bl       #0x3a7e668 ; 
0044A2FE8  ldr      x8, [x19, #0x38]
0044A2FEC  ldr      x0, [x23, #0x30]
0044A2FF0  ldr      x2, [x8, #8]
0044A2FF4  ldp      x20, x21, [x23, #0x20]
0044A2FF8  mov      x1, x22
0044A2FFC  bl       #0x45a1200 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, long>
0044A3000  ldr      x8, [x19, #0x38]
0044A3004  mov      x22, x0
0044A3008  ldr      x8, [x8, #0x18]
0044A300C  ldrb     w9, [x8, #0x135]
0044A3010  tbnz     w9, #0, #0x44a3020
0044A3014  mov      x0, x8
0044A3018  bl       #0x3a7e60c ; 
0044A301C  mov      x8, x0
0044A3020  mov      x0, x8
0044A3024  bl       #0x382bfa0 ; 
0044A3028  ldr      x8, [x19, #0x38]
0044A302C  mov      x1, x20
0044A3030  mov      x2, x21
0044A3034  mov      x3, x22
0044A3038  ldr      x4, [x8, #0x20]
0044A303C  mov      x19, x0
0044A3040  bl       #0x5abd6bc ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, long>$$.ctor
0044A3044  mov      x0, x19
0044A3048  ldp      x20, x19, [sp, #0x20]
0044A304C  ldp      x22, x21, [sp, #0x10]
0044A3050  ldp      x30, x23, [sp], #0x30
0044A3054  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<object>
; RVA 0x44A3058; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A3058  stp      x30, x23, [sp, #-0x30]!
0044A305C  stp      x22, x21, [sp, #0x10]
0044A3060  stp      x20, x19, [sp, #0x20]
0044A3064  ldr      x8, [x2, #0x38]
0044A3068  mov      x19, x2
0044A306C  mov      x22, x1
0044A3070  mov      x23, x0
0044A3074  cbnz     x8, #0x44a3084
0044A3078  mov      x0, x19
0044A307C  bl       #0x3a7e668 ; 
0044A3080  ldr      x8, [x19, #0x38]
0044A3084  ldr      x0, [x23, #0x30]
0044A3088  ldr      x2, [x8, #8]
0044A308C  ldp      x20, x21, [x23, #0x20]
0044A3090  mov      x1, x22
0044A3094  bl       #0x45a12bc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, object>
0044A3098  ldr      x8, [x19, #0x38]
0044A309C  mov      x22, x0
0044A30A0  ldr      x8, [x8, #0x18]
0044A30A4  ldrb     w9, [x8, #0x135]
0044A30A8  tbnz     w9, #0, #0x44a30b8
0044A30AC  mov      x0, x8
0044A30B0  bl       #0x3a7e60c ; 
0044A30B4  mov      x8, x0
0044A30B8  mov      x0, x8
0044A30BC  bl       #0x382bfa0 ; 
0044A30C0  ldr      x8, [x19, #0x38]
0044A30C4  mov      x1, x20
0044A30C8  mov      x2, x21
0044A30CC  mov      x3, x22
0044A30D0  ldr      x4, [x8, #0x20]
0044A30D4  mov      x19, x0
0044A30D8  bl       #0x5abdb70 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$.ctor
0044A30DC  mov      x0, x19
0044A30E0  ldp      x20, x19, [sp, #0x20]
0044A30E4  ldp      x22, x21, [sp, #0x10]
0044A30E8  ldp      x30, x23, [sp], #0x30
0044A30EC  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Select<Vector3>
; RVA 0x44A30F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0044A30F0  stp      x30, x23, [sp, #-0x30]!
0044A30F4  stp      x22, x21, [sp, #0x10]
0044A30F8  stp      x20, x19, [sp, #0x20]
0044A30FC  ldr      x8, [x2, #0x38]
0044A3100  mov      x19, x2
0044A3104  mov      x22, x1
0044A3108  mov      x23, x0
0044A310C  cbnz     x8, #0x44a311c
0044A3110  mov      x0, x19
0044A3114  bl       #0x3a7e668 ; 
0044A3118  ldr      x8, [x19, #0x38]
0044A311C  ldr      x0, [x23, #0x30]
0044A3120  ldr      x2, [x8, #8]
0044A3124  ldp      x20, x21, [x23, #0x20]
0044A3128  mov      x1, x22
0044A312C  bl       #0x45a1378 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, Vector3>
0044A3130  ldr      x8, [x19, #0x38]
0044A3134  mov      x22, x0
0044A3138  ldr      x8, [x8, #0x18]
0044A313C  ldrb     w9, [x8, #0x135]
0044A3140  tbnz     w9, #0, #0x44a3150
0044A3144  mov      x0, x8
0044A3148  bl       #0x3a7e60c ; 
0044A314C  mov      x8, x0
0044A3150  mov      x0, x8
0044A3154  bl       #0x382bfa0 ; 
0044A3158  ldr      x8, [x19, #0x38]
0044A315C  mov      x1, x20
0044A3160  mov      x2, x21
0044A3164  mov      x3, x22
0044A3168  ldr      x4, [x8, #0x20]
0044A316C  mov      x19, x0
0044A3170  bl       #0x5abe030 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Vector3>$$.ctor
0044A3174  mov      x0, x19
0044A3178  ldp      x20, x19, [sp, #0x20]
0044A317C  ldp      x22, x21, [sp, #0x10]
0044A3180  ldp      x30, x23, [sp], #0x30
0044A3184  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, object>$$Where
; RVA 0x5ABDFC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABDFC8  stp      x30, x21, [sp, #-0x20]!
005ABDFCC  stp      x20, x19, [sp, #0x10]
005ABDFD0  ldr      x8, [x2, #0x20]
005ABDFD4  mov      x20, x2
005ABDFD8  mov      x19, x1
005ABDFDC  mov      x21, x0
005ABDFE0  ldr      x8, [x8, #0xc0]
005ABDFE4  ldr      x8, [x8, #0x88]
005ABDFE8  ldrb     w9, [x8, #0x135]
005ABDFEC  tbnz     w9, #0, #0x5abdffc
005ABDFF0  mov      x0, x8
005ABDFF4  bl       #0x3a7e60c ; 
005ABDFF8  mov      x8, x0
005ABDFFC  mov      x0, x8
005ABE000  bl       #0x382bfa0 ; 
005ABE004  ldr      x8, [x20, #0x20]
005ABE008  mov      x1, x21
005ABE00C  mov      x2, x19
005ABE010  mov      x20, x0
005ABE014  ldr      x8, [x8, #0xc0]
005ABE018  ldr      x3, [x8, #0x90]
005ABE01C  bl       #0x59caabc ; System.Linq.Enumerable.WhereEnumerableIterator<object>$$.ctor
005ABE020  mov      x0, x20
005ABE024  ldp      x20, x19, [sp, #0x10]
005ABE028  ldp      x30, x21, [sp], #0x20
005ABE02C  ret      

