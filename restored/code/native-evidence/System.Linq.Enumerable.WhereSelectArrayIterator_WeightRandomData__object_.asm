; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$.ctor
; RVA 0x5A0D8B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D8B0  str      x30, [sp, #-0x30]!
005A0D8B4  stp      x22, x21, [sp, #0x10]
005A0D8B8  stp      x20, x19, [sp, #0x20]
005A0D8BC  ldr      x8, [x4, #0x20]
005A0D8C0  mov      x21, x1
005A0D8C4  mov      x19, x3
005A0D8C8  mov      x20, x2
005A0D8CC  ldr      x8, [x8, #0xc0]
005A0D8D0  mov      x22, x0
005A0D8D4  ldr      x1, [x8]
005A0D8D8  bl       #0x4a749e8 ; System.Linq.Enumerable.Iterator<object>$$.ctor
005A0D8DC  mov      x0, x22
005A0D8E0  str      x21, [x0, #0x20]!
005A0D8E4  mov      x1, x21
005A0D8E8  bl       #0x382bcb8 ; 
005A0D8EC  mov      x0, x22
005A0D8F0  str      x20, [x0, #0x28]!
005A0D8F4  mov      x1, x20
005A0D8F8  bl       #0x382bcb8 ; 
005A0D8FC  str      x19, [x22, #0x30]!
005A0D900  mov      x0, x22
005A0D904  mov      x1, x19
005A0D908  ldp      x20, x19, [sp, #0x20]
005A0D90C  ldp      x22, x21, [sp, #0x10]
005A0D910  ldr      x30, [sp], #0x30
005A0D914  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Clone
; RVA 0x5A0D918; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D918  str      x30, [sp, #-0x30]!
005A0D91C  stp      x22, x21, [sp, #0x10]
005A0D920  stp      x20, x19, [sp, #0x20]
005A0D924  ldr      x9, [x1, #0x20]
005A0D928  mov      x8, x0
005A0D92C  ldp      x21, x20, [x8, #0x20]
005A0D930  ldr      x22, [x8, #0x30]
005A0D934  ldr      x9, [x9, #0xc0]
005A0D938  mov      x19, x1
005A0D93C  ldr      x0, [x9, #0x18]
005A0D940  ldrb     w9, [x0, #0x135]
005A0D944  tbnz     w9, #0, #0x5a0d94c
005A0D948  bl       #0x3a7e60c ; 
005A0D94C  bl       #0x382bfa0 ; 
005A0D950  ldr      x8, [x19, #0x20]
005A0D954  mov      x1, x21
005A0D958  mov      x2, x20
005A0D95C  mov      x3, x22
005A0D960  ldr      x8, [x8, #0xc0]
005A0D964  mov      x19, x0
005A0D968  ldr      x4, [x8, #0x30]
005A0D96C  bl       #0x5a0d8b0 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$.ctor
005A0D970  mov      x0, x19
005A0D974  ldp      x20, x19, [sp, #0x20]
005A0D978  ldp      x22, x21, [sp, #0x10]
005A0D97C  ldr      x30, [sp], #0x30
005A0D980  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$MoveNext
; RVA 0x5A0D984; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D984  sub      sp, sp, #0xe0
005A0D988  str      x30, [sp, #0xc0]
005A0D98C  stp      x20, x19, [sp, #0xd0]
005A0D990  ldr      w8, [x0, #0x14]
005A0D994  cmp      w8, #1
005A0D998  b.ne     #0x5a0da94
005A0D99C  mov      x19, x0
005A0D9A0  mov      w20, #0x38
005A0D9A4  ldr      x9, [x19, #0x20]
005A0D9A8  cbz      x9, #0x5a0daac
005A0D9AC  ldrsw    x8, [x19, #0x38]
005A0D9B0  ldr      w10, [x9, #0x18]
005A0D9B4  cmp      w8, w10
005A0D9B8  b.ge     #0x5a0da84
005A0D9BC  cmp      w8, w10
005A0D9C0  b.hs     #0x5a0daa8
005A0D9C4  madd     x9, x8, x20, x9
005A0D9C8  ldr      x10, [x9, #0x50]
005A0D9CC  ldp      q1, q0, [x9, #0x30]
005A0D9D0  ldr      q2, [x9, #0x20]
005A0D9D4  add      w8, w8, #1
005A0D9D8  str      x10, [sp, #0x70]
005A0D9DC  stp      q1, q0, [sp, #0x50]
005A0D9E0  str      q2, [sp, #0x40]
005A0D9E4  ldr      x9, [x19, #0x28]
005A0D9E8  str      w8, [x19, #0x38]
005A0D9EC  cbz      x9, #0x5a0da20
005A0D9F0  ldp      q0, q1, [sp, #0x40]
005A0D9F4  ldr      q2, [sp, #0x60]
005A0D9F8  ldr      x10, [sp, #0x70]
005A0D9FC  ldr      x8, [x9, #0x18]
005A0DA00  ldr      x0, [x9, #0x40]
005A0DA04  stp      q0, q1, [sp, #0x80]
005A0DA08  str      q2, [sp, #0xa0]
005A0DA0C  str      x10, [sp, #0xb0]
005A0DA10  ldr      x2, [x9, #0x28]
005A0DA14  add      x1, sp, #0x80
005A0DA18  blr      x8
005A0DA1C  tbz      w0, #0, #0x5a0d9a4
005A0DA20  ldr      x8, [x19, #0x30]
005A0DA24  ldp      q0, q1, [sp, #0x40]
005A0DA28  ldr      q2, [sp, #0x60]
005A0DA2C  ldr      x9, [sp, #0x70]
005A0DA30  stp      q0, q1, [sp]
005A0DA34  str      q2, [sp, #0x20]
005A0DA38  str      x9, [sp, #0x30]
005A0DA3C  cbz      x8, #0x5a0daac
005A0DA40  ldp      q0, q1, [sp]
005A0DA44  ldr      q2, [sp, #0x20]
005A0DA48  ldr      x10, [sp, #0x30]
005A0DA4C  ldr      x9, [x8, #0x18]
005A0DA50  ldr      x0, [x8, #0x40]
005A0DA54  stp      q0, q1, [sp, #0x80]
005A0DA58  str      q2, [sp, #0xa0]
005A0DA5C  str      x10, [sp, #0xb0]
005A0DA60  ldr      x2, [x8, #0x28]
005A0DA64  add      x1, sp, #0x80
005A0DA68  blr      x9
005A0DA6C  str      x0, [x19, #0x18]!
005A0DA70  mov      x1, x0
005A0DA74  mov      x0, x19
005A0DA78  bl       #0x382bcb8 ; 
005A0DA7C  mov      w0, #1
005A0DA80  b        #0x5a0da98 ; 
005A0DA84  ldr      x8, [x19]
005A0DA88  mov      x0, x19
005A0DA8C  ldp      x9, x1, [x8, #0x1f8]
005A0DA90  blr      x9
005A0DA94  mov      w0, wzr
005A0DA98  ldp      x20, x19, [sp, #0xd0]
005A0DA9C  ldr      x30, [sp, #0xc0]
005A0DAA0  add      sp, sp, #0xe0
005A0DAA4  ret      
005A0DAA8  bl       #0x382bfc0 ; 
005A0DAAC  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<ValueTuple<int, int>>
; RVA 0x435FC30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00435FC30  stp      x30, x23, [sp, #-0x30]!
00435FC34  stp      x22, x21, [sp, #0x10]
00435FC38  stp      x20, x19, [sp, #0x20]
00435FC3C  ldr      x8, [x2, #0x38]
00435FC40  mov      x19, x2
00435FC44  mov      x22, x1
00435FC48  mov      x23, x0
00435FC4C  cbnz     x8, #0x435fc5c
00435FC50  mov      x0, x19
00435FC54  bl       #0x3a7e668 ; 
00435FC58  ldr      x8, [x19, #0x38]
00435FC5C  ldr      x0, [x23, #0x30]
00435FC60  ldr      x2, [x8, #8]
00435FC64  ldp      x20, x21, [x23, #0x20]
00435FC68  mov      x1, x22
00435FC6C  bl       #0x45a0930 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, ValueTuple<int, int>>
00435FC70  ldr      x8, [x19, #0x38]
00435FC74  mov      x22, x0
00435FC78  ldr      x8, [x8, #0x18]
00435FC7C  ldrb     w9, [x8, #0x135]
00435FC80  tbnz     w9, #0, #0x435fc90
00435FC84  mov      x0, x8
00435FC88  bl       #0x3a7e60c ; 
00435FC8C  mov      x8, x0
00435FC90  mov      x0, x8
00435FC94  bl       #0x382bfa0 ; 
00435FC98  ldr      x8, [x19, #0x38]
00435FC9C  mov      x1, x20
00435FCA0  mov      x2, x21
00435FCA4  mov      x3, x22
00435FCA8  ldr      x4, [x8, #0x20]
00435FCAC  mov      x19, x0
00435FCB0  bl       #0x5a0b9a8 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, ValueTuple<int, int>>$$.ctor
00435FCB4  mov      x0, x19
00435FCB8  ldp      x20, x19, [sp, #0x20]
00435FCBC  ldp      x22, x21, [sp, #0x10]
00435FCC0  ldp      x30, x23, [sp], #0x30
00435FCC4  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<AttributeOneElement>
; RVA 0x435FCC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00435FCC8  stp      x30, x23, [sp, #-0x30]!
00435FCCC  stp      x22, x21, [sp, #0x10]
00435FCD0  stp      x20, x19, [sp, #0x20]
00435FCD4  ldr      x8, [x2, #0x38]
00435FCD8  mov      x19, x2
00435FCDC  mov      x22, x1
00435FCE0  mov      x23, x0
00435FCE4  cbnz     x8, #0x435fcf4
00435FCE8  mov      x0, x19
00435FCEC  bl       #0x3a7e668 ; 
00435FCF0  ldr      x8, [x19, #0x38]
00435FCF4  ldr      x0, [x23, #0x30]
00435FCF8  ldr      x2, [x8, #8]
00435FCFC  ldp      x20, x21, [x23, #0x20]
00435FD00  mov      x1, x22
00435FD04  bl       #0x45a09ec ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, AttributeOneElement>
00435FD08  ldr      x8, [x19, #0x38]
00435FD0C  mov      x22, x0
00435FD10  ldr      x8, [x8, #0x18]
00435FD14  ldrb     w9, [x8, #0x135]
00435FD18  tbnz     w9, #0, #0x435fd28
00435FD1C  mov      x0, x8
00435FD20  bl       #0x3a7e60c ; 
00435FD24  mov      x8, x0
00435FD28  mov      x0, x8
00435FD2C  bl       #0x382bfa0 ; 
00435FD30  ldr      x8, [x19, #0x38]
00435FD34  mov      x1, x20
00435FD38  mov      x2, x21
00435FD3C  mov      x3, x22
00435FD40  ldr      x4, [x8, #0x20]
00435FD44  mov      x19, x0
00435FD48  bl       #0x5a0bc04 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, AttributeOneElement>$$.ctor
00435FD4C  mov      x0, x19
00435FD50  ldp      x20, x19, [sp, #0x20]
00435FD54  ldp      x22, x21, [sp, #0x10]
00435FD58  ldp      x30, x23, [sp], #0x30
00435FD5C  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<bool>
; RVA 0x435FD60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00435FD60  stp      x30, x23, [sp, #-0x30]!
00435FD64  stp      x22, x21, [sp, #0x10]
00435FD68  stp      x20, x19, [sp, #0x20]
00435FD6C  ldr      x8, [x2, #0x38]
00435FD70  mov      x19, x2
00435FD74  mov      x22, x1
00435FD78  mov      x23, x0
00435FD7C  cbnz     x8, #0x435fd8c
00435FD80  mov      x0, x19
00435FD84  bl       #0x3a7e668 ; 
00435FD88  ldr      x8, [x19, #0x38]
00435FD8C  ldr      x0, [x23, #0x30]
00435FD90  ldr      x2, [x8, #8]
00435FD94  ldp      x20, x21, [x23, #0x20]
00435FD98  mov      x1, x22
00435FD9C  bl       #0x45a0aa8 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, bool>
00435FDA0  ldr      x8, [x19, #0x38]
00435FDA4  mov      x22, x0
00435FDA8  ldr      x8, [x8, #0x18]
00435FDAC  ldrb     w9, [x8, #0x135]
00435FDB0  tbnz     w9, #0, #0x435fdc0
00435FDB4  mov      x0, x8
00435FDB8  bl       #0x3a7e60c ; 
00435FDBC  mov      x8, x0
00435FDC0  mov      x0, x8
00435FDC4  bl       #0x382bfa0 ; 
00435FDC8  ldr      x8, [x19, #0x38]
00435FDCC  mov      x1, x20
00435FDD0  mov      x2, x21
00435FDD4  mov      x3, x22
00435FDD8  ldr      x4, [x8, #0x20]
00435FDDC  mov      x19, x0
00435FDE0  bl       #0x5a0be90 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, bool>$$.ctor
00435FDE4  mov      x0, x19
00435FDE8  ldp      x20, x19, [sp, #0x20]
00435FDEC  ldp      x22, x21, [sp, #0x10]
00435FDF0  ldp      x30, x23, [sp], #0x30
00435FDF4  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<CalAttrCardData>
; RVA 0x435FDF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00435FDF8  stp      x30, x23, [sp, #-0x30]!
00435FDFC  stp      x22, x21, [sp, #0x10]
00435FE00  stp      x20, x19, [sp, #0x20]
00435FE04  ldr      x8, [x2, #0x38]
00435FE08  mov      x19, x2
00435FE0C  mov      x22, x1
00435FE10  mov      x23, x0
00435FE14  cbnz     x8, #0x435fe24
00435FE18  mov      x0, x19
00435FE1C  bl       #0x3a7e668 ; 
00435FE20  ldr      x8, [x19, #0x38]
00435FE24  ldr      x0, [x23, #0x30]
00435FE28  ldr      x2, [x8, #8]
00435FE2C  ldp      x20, x21, [x23, #0x20]
00435FE30  mov      x1, x22
00435FE34  bl       #0x45a0b64 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalAttrCardData>
00435FE38  ldr      x8, [x19, #0x38]
00435FE3C  mov      x22, x0
00435FE40  ldr      x8, [x8, #0x18]
00435FE44  ldrb     w9, [x8, #0x135]
00435FE48  tbnz     w9, #0, #0x435fe58
00435FE4C  mov      x0, x8
00435FE50  bl       #0x3a7e60c ; 
00435FE54  mov      x8, x0
00435FE58  mov      x0, x8
00435FE5C  bl       #0x382bfa0 ; 
00435FE60  ldr      x8, [x19, #0x38]
00435FE64  mov      x1, x20
00435FE68  mov      x2, x21
00435FE6C  mov      x3, x22
00435FE70  ldr      x4, [x8, #0x20]
00435FE74  mov      x19, x0
00435FE78  bl       #0x5a0c0f0 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrCardData>$$.ctor
00435FE7C  mov      x0, x19
00435FE80  ldp      x20, x19, [sp, #0x20]
00435FE84  ldp      x22, x21, [sp, #0x10]
00435FE88  ldp      x30, x23, [sp], #0x30
00435FE8C  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<CalAttrRelicData>
; RVA 0x435FE90; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00435FE90  stp      x30, x23, [sp, #-0x30]!
00435FE94  stp      x22, x21, [sp, #0x10]
00435FE98  stp      x20, x19, [sp, #0x20]
00435FE9C  ldr      x8, [x2, #0x38]
00435FEA0  mov      x19, x2
00435FEA4  mov      x22, x1
00435FEA8  mov      x23, x0
00435FEAC  cbnz     x8, #0x435febc
00435FEB0  mov      x0, x19
00435FEB4  bl       #0x3a7e668 ; 
00435FEB8  ldr      x8, [x19, #0x38]
00435FEBC  ldr      x0, [x23, #0x30]
00435FEC0  ldr      x2, [x8, #8]
00435FEC4  ldp      x20, x21, [x23, #0x20]
00435FEC8  mov      x1, x22
00435FECC  bl       #0x45a0c20 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalAttrRelicData>
00435FED0  ldr      x8, [x19, #0x38]
00435FED4  mov      x22, x0
00435FED8  ldr      x8, [x8, #0x18]
00435FEDC  ldrb     w9, [x8, #0x135]
00435FEE0  tbnz     w9, #0, #0x435fef0
00435FEE4  mov      x0, x8
00435FEE8  bl       #0x3a7e60c ; 
00435FEEC  mov      x8, x0
00435FEF0  mov      x0, x8
00435FEF4  bl       #0x382bfa0 ; 
00435FEF8  ldr      x8, [x19, #0x38]
00435FEFC  mov      x1, x20
00435FF00  mov      x2, x21
00435FF04  mov      x3, x22
00435FF08  ldr      x4, [x8, #0x20]
00435FF0C  mov      x19, x0
00435FF10  bl       #0x5a0c34c ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalAttrRelicData>$$.ctor
00435FF14  mov      x0, x19
00435FF18  ldp      x20, x19, [sp, #0x20]
00435FF1C  ldp      x22, x21, [sp, #0x10]
00435FF20  ldp      x30, x23, [sp], #0x30
00435FF24  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<CalCollectionTreasureData>
; RVA 0x435FF28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00435FF28  stp      x30, x23, [sp, #-0x30]!
00435FF2C  stp      x22, x21, [sp, #0x10]
00435FF30  stp      x20, x19, [sp, #0x20]
00435FF34  ldr      x8, [x2, #0x38]
00435FF38  mov      x19, x2
00435FF3C  mov      x22, x1
00435FF40  mov      x23, x0
00435FF44  cbnz     x8, #0x435ff54
00435FF48  mov      x0, x19
00435FF4C  bl       #0x3a7e668 ; 
00435FF50  ldr      x8, [x19, #0x38]
00435FF54  ldr      x0, [x23, #0x30]
00435FF58  ldr      x2, [x8, #8]
00435FF5C  ldp      x20, x21, [x23, #0x20]
00435FF60  mov      x1, x22
00435FF64  bl       #0x45a0cdc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalCollectionTreasureData>
00435FF68  ldr      x8, [x19, #0x38]
00435FF6C  mov      x22, x0
00435FF70  ldr      x8, [x8, #0x18]
00435FF74  ldrb     w9, [x8, #0x135]
00435FF78  tbnz     w9, #0, #0x435ff88
00435FF7C  mov      x0, x8
00435FF80  bl       #0x3a7e60c ; 
00435FF84  mov      x8, x0
00435FF88  mov      x0, x8
00435FF8C  bl       #0x382bfa0 ; 
00435FF90  ldr      x8, [x19, #0x38]
00435FF94  mov      x1, x20
00435FF98  mov      x2, x21
00435FF9C  mov      x3, x22
00435FFA0  ldr      x4, [x8, #0x20]
00435FFA4  mov      x19, x0
00435FFA8  bl       #0x5a0c5a8 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalCollectionTreasureData>$$.ctor
00435FFAC  mov      x0, x19
00435FFB0  ldp      x20, x19, [sp, #0x20]
00435FFB4  ldp      x22, x21, [sp, #0x10]
00435FFB8  ldp      x30, x23, [sp], #0x30
00435FFBC  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<CalEquipData>
; RVA 0x435FFC0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00435FFC0  stp      x30, x23, [sp, #-0x30]!
00435FFC4  stp      x22, x21, [sp, #0x10]
00435FFC8  stp      x20, x19, [sp, #0x20]
00435FFCC  ldr      x8, [x2, #0x38]
00435FFD0  mov      x19, x2
00435FFD4  mov      x22, x1
00435FFD8  mov      x23, x0
00435FFDC  cbnz     x8, #0x435ffec
00435FFE0  mov      x0, x19
00435FFE4  bl       #0x3a7e668 ; 
00435FFE8  ldr      x8, [x19, #0x38]
00435FFEC  ldr      x0, [x23, #0x30]
00435FFF0  ldr      x2, [x8, #8]
00435FFF4  ldp      x20, x21, [x23, #0x20]
00435FFF8  mov      x1, x22
00435FFFC  bl       #0x45a0d98 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalEquipData>
004360000  ldr      x8, [x19, #0x38]
004360004  mov      x22, x0
004360008  ldr      x8, [x8, #0x18]
00436000C  ldrb     w9, [x8, #0x135]
004360010  tbnz     w9, #0, #0x4360020
004360014  mov      x0, x8
004360018  bl       #0x3a7e60c ; 
00436001C  mov      x8, x0
004360020  mov      x0, x8
004360024  bl       #0x382bfa0 ; 
004360028  ldr      x8, [x19, #0x38]
00436002C  mov      x1, x20
004360030  mov      x2, x21
004360034  mov      x3, x22
004360038  ldr      x4, [x8, #0x20]
00436003C  mov      x19, x0
004360040  bl       #0x5a0c804 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalEquipData>$$.ctor
004360044  mov      x0, x19
004360048  ldp      x20, x19, [sp, #0x20]
00436004C  ldp      x22, x21, [sp, #0x10]
004360050  ldp      x30, x23, [sp], #0x30
004360054  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<CalRoleData>
; RVA 0x4360058; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004360058  stp      x30, x23, [sp, #-0x30]!
00436005C  stp      x22, x21, [sp, #0x10]
004360060  stp      x20, x19, [sp, #0x20]
004360064  ldr      x8, [x2, #0x38]
004360068  mov      x19, x2
00436006C  mov      x22, x1
004360070  mov      x23, x0
004360074  cbnz     x8, #0x4360084
004360078  mov      x0, x19
00436007C  bl       #0x3a7e668 ; 
004360080  ldr      x8, [x19, #0x38]
004360084  ldr      x0, [x23, #0x30]
004360088  ldr      x2, [x8, #8]
00436008C  ldp      x20, x21, [x23, #0x20]
004360090  mov      x1, x22
004360094  bl       #0x45a0e54 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalRoleData>
004360098  ldr      x8, [x19, #0x38]
00436009C  mov      x22, x0
0043600A0  ldr      x8, [x8, #0x18]
0043600A4  ldrb     w9, [x8, #0x135]
0043600A8  tbnz     w9, #0, #0x43600b8
0043600AC  mov      x0, x8
0043600B0  bl       #0x3a7e60c ; 
0043600B4  mov      x8, x0
0043600B8  mov      x0, x8
0043600BC  bl       #0x382bfa0 ; 
0043600C0  ldr      x8, [x19, #0x38]
0043600C4  mov      x1, x20
0043600C8  mov      x2, x21
0043600CC  mov      x3, x22
0043600D0  ldr      x4, [x8, #0x20]
0043600D4  mov      x19, x0
0043600D8  bl       #0x5a0ca60 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRoleData>$$.ctor
0043600DC  mov      x0, x19
0043600E0  ldp      x20, x19, [sp, #0x20]
0043600E4  ldp      x22, x21, [sp, #0x10]
0043600E8  ldp      x30, x23, [sp], #0x30
0043600EC  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<CalRuneData>
; RVA 0x43600F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0043600F0  stp      x30, x23, [sp, #-0x30]!
0043600F4  stp      x22, x21, [sp, #0x10]
0043600F8  stp      x20, x19, [sp, #0x20]
0043600FC  ldr      x8, [x2, #0x38]
004360100  mov      x19, x2
004360104  mov      x22, x1
004360108  mov      x23, x0
00436010C  cbnz     x8, #0x436011c
004360110  mov      x0, x19
004360114  bl       #0x3a7e668 ; 
004360118  ldr      x8, [x19, #0x38]
00436011C  ldr      x0, [x23, #0x30]
004360120  ldr      x2, [x8, #8]
004360124  ldp      x20, x21, [x23, #0x20]
004360128  mov      x1, x22
00436012C  bl       #0x45a0f10 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, CalRuneData>
004360130  ldr      x8, [x19, #0x38]
004360134  mov      x22, x0
004360138  ldr      x8, [x8, #0x18]
00436013C  ldrb     w9, [x8, #0x135]
004360140  tbnz     w9, #0, #0x4360150
004360144  mov      x0, x8
004360148  bl       #0x3a7e60c ; 
00436014C  mov      x8, x0
004360150  mov      x0, x8
004360154  bl       #0x382bfa0 ; 
004360158  ldr      x8, [x19, #0x38]
00436015C  mov      x1, x20
004360160  mov      x2, x21
004360164  mov      x3, x22
004360168  ldr      x4, [x8, #0x20]
00436016C  mov      x19, x0
004360170  bl       #0x5a0cce4 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, CalRuneData>$$.ctor
004360174  mov      x0, x19
004360178  ldp      x20, x19, [sp, #0x20]
00436017C  ldp      x22, x21, [sp, #0x10]
004360180  ldp      x30, x23, [sp], #0x30
004360184  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<char>
; RVA 0x4360188; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004360188  stp      x30, x23, [sp, #-0x30]!
00436018C  stp      x22, x21, [sp, #0x10]
004360190  stp      x20, x19, [sp, #0x20]
004360194  ldr      x8, [x2, #0x38]
004360198  mov      x19, x2
00436019C  mov      x22, x1
0043601A0  mov      x23, x0
0043601A4  cbnz     x8, #0x43601b4
0043601A8  mov      x0, x19
0043601AC  bl       #0x3a7e668 ; 
0043601B0  ldr      x8, [x19, #0x38]
0043601B4  ldr      x0, [x23, #0x30]
0043601B8  ldr      x2, [x8, #8]
0043601BC  ldp      x20, x21, [x23, #0x20]
0043601C0  mov      x1, x22
0043601C4  bl       #0x45a0fcc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, char>
0043601C8  ldr      x8, [x19, #0x38]
0043601CC  mov      x22, x0
0043601D0  ldr      x8, [x8, #0x18]
0043601D4  ldrb     w9, [x8, #0x135]
0043601D8  tbnz     w9, #0, #0x43601e8
0043601DC  mov      x0, x8
0043601E0  bl       #0x3a7e60c ; 
0043601E4  mov      x8, x0
0043601E8  mov      x0, x8
0043601EC  bl       #0x382bfa0 ; 
0043601F0  ldr      x8, [x19, #0x38]
0043601F4  mov      x1, x20
0043601F8  mov      x2, x21
0043601FC  mov      x3, x22
004360200  ldr      x4, [x8, #0x20]
004360204  mov      x19, x0
004360208  bl       #0x5a0cf40 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, char>$$.ctor
00436020C  mov      x0, x19
004360210  ldp      x20, x19, [sp, #0x20]
004360214  ldp      x22, x21, [sp, #0x10]
004360218  ldp      x30, x23, [sp], #0x30
00436021C  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<int>
; RVA 0x4360220; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004360220  stp      x30, x23, [sp, #-0x30]!
004360224  stp      x22, x21, [sp, #0x10]
004360228  stp      x20, x19, [sp, #0x20]
00436022C  ldr      x8, [x2, #0x38]
004360230  mov      x19, x2
004360234  mov      x22, x1
004360238  mov      x23, x0
00436023C  cbnz     x8, #0x436024c
004360240  mov      x0, x19
004360244  bl       #0x3a7e668 ; 
004360248  ldr      x8, [x19, #0x38]
00436024C  ldr      x0, [x23, #0x30]
004360250  ldr      x2, [x8, #8]
004360254  ldp      x20, x21, [x23, #0x20]
004360258  mov      x1, x22
00436025C  bl       #0x45a1088 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, int>
004360260  ldr      x8, [x19, #0x38]
004360264  mov      x22, x0
004360268  ldr      x8, [x8, #0x18]
00436026C  ldrb     w9, [x8, #0x135]
004360270  tbnz     w9, #0, #0x4360280
004360274  mov      x0, x8
004360278  bl       #0x3a7e60c ; 
00436027C  mov      x8, x0
004360280  mov      x0, x8
004360284  bl       #0x382bfa0 ; 
004360288  ldr      x8, [x19, #0x38]
00436028C  mov      x1, x20
004360290  mov      x2, x21
004360294  mov      x3, x22
004360298  ldr      x4, [x8, #0x20]
00436029C  mov      x19, x0
0043602A0  bl       #0x5a0d19c ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, int>$$.ctor
0043602A4  mov      x0, x19
0043602A8  ldp      x20, x19, [sp, #0x20]
0043602AC  ldp      x22, x21, [sp, #0x10]
0043602B0  ldp      x30, x23, [sp], #0x30
0043602B4  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<Int32Enum>
; RVA 0x43602B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0043602B8  stp      x30, x23, [sp, #-0x30]!
0043602BC  stp      x22, x21, [sp, #0x10]
0043602C0  stp      x20, x19, [sp, #0x20]
0043602C4  ldr      x8, [x2, #0x38]
0043602C8  mov      x19, x2
0043602CC  mov      x22, x1
0043602D0  mov      x23, x0
0043602D4  cbnz     x8, #0x43602e4
0043602D8  mov      x0, x19
0043602DC  bl       #0x3a7e668 ; 
0043602E0  ldr      x8, [x19, #0x38]
0043602E4  ldr      x0, [x23, #0x30]
0043602E8  ldr      x2, [x8, #8]
0043602EC  ldp      x20, x21, [x23, #0x20]
0043602F0  mov      x1, x22
0043602F4  bl       #0x45a1144 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, Int32Enum>
0043602F8  ldr      x8, [x19, #0x38]
0043602FC  mov      x22, x0
004360300  ldr      x8, [x8, #0x18]
004360304  ldrb     w9, [x8, #0x135]
004360308  tbnz     w9, #0, #0x4360318
00436030C  mov      x0, x8
004360310  bl       #0x3a7e60c ; 
004360314  mov      x8, x0
004360318  mov      x0, x8
00436031C  bl       #0x382bfa0 ; 
004360320  ldr      x8, [x19, #0x38]
004360324  mov      x1, x20
004360328  mov      x2, x21
00436032C  mov      x3, x22
004360330  ldr      x4, [x8, #0x20]
004360334  mov      x19, x0
004360338  bl       #0x5a0d3f8 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Int32Enum>$$.ctor
00436033C  mov      x0, x19
004360340  ldp      x20, x19, [sp, #0x20]
004360344  ldp      x22, x21, [sp, #0x10]
004360348  ldp      x30, x23, [sp], #0x30
00436034C  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<long>
; RVA 0x4360350; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004360350  stp      x30, x23, [sp, #-0x30]!
004360354  stp      x22, x21, [sp, #0x10]
004360358  stp      x20, x19, [sp, #0x20]
00436035C  ldr      x8, [x2, #0x38]
004360360  mov      x19, x2
004360364  mov      x22, x1
004360368  mov      x23, x0
00436036C  cbnz     x8, #0x436037c
004360370  mov      x0, x19
004360374  bl       #0x3a7e668 ; 
004360378  ldr      x8, [x19, #0x38]
00436037C  ldr      x0, [x23, #0x30]
004360380  ldr      x2, [x8, #8]
004360384  ldp      x20, x21, [x23, #0x20]
004360388  mov      x1, x22
00436038C  bl       #0x45a1200 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, long>
004360390  ldr      x8, [x19, #0x38]
004360394  mov      x22, x0
004360398  ldr      x8, [x8, #0x18]
00436039C  ldrb     w9, [x8, #0x135]
0043603A0  tbnz     w9, #0, #0x43603b0
0043603A4  mov      x0, x8
0043603A8  bl       #0x3a7e60c ; 
0043603AC  mov      x8, x0
0043603B0  mov      x0, x8
0043603B4  bl       #0x382bfa0 ; 
0043603B8  ldr      x8, [x19, #0x38]
0043603BC  mov      x1, x20
0043603C0  mov      x2, x21
0043603C4  mov      x3, x22
0043603C8  ldr      x4, [x8, #0x20]
0043603CC  mov      x19, x0
0043603D0  bl       #0x5a0d654 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, long>$$.ctor
0043603D4  mov      x0, x19
0043603D8  ldp      x20, x19, [sp, #0x20]
0043603DC  ldp      x22, x21, [sp, #0x10]
0043603E0  ldp      x30, x23, [sp], #0x30
0043603E4  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<object>
; RVA 0x43603E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0043603E8  stp      x30, x23, [sp, #-0x30]!
0043603EC  stp      x22, x21, [sp, #0x10]
0043603F0  stp      x20, x19, [sp, #0x20]
0043603F4  ldr      x8, [x2, #0x38]
0043603F8  mov      x19, x2
0043603FC  mov      x22, x1
004360400  mov      x23, x0
004360404  cbnz     x8, #0x4360414
004360408  mov      x0, x19
00436040C  bl       #0x3a7e668 ; 
004360410  ldr      x8, [x19, #0x38]
004360414  ldr      x0, [x23, #0x30]
004360418  ldr      x2, [x8, #8]
00436041C  ldp      x20, x21, [x23, #0x20]
004360420  mov      x1, x22
004360424  bl       #0x45a12bc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, object>
004360428  ldr      x8, [x19, #0x38]
00436042C  mov      x22, x0
004360430  ldr      x8, [x8, #0x18]
004360434  ldrb     w9, [x8, #0x135]
004360438  tbnz     w9, #0, #0x4360448
00436043C  mov      x0, x8
004360440  bl       #0x3a7e60c ; 
004360444  mov      x8, x0
004360448  mov      x0, x8
00436044C  bl       #0x382bfa0 ; 
004360450  ldr      x8, [x19, #0x38]
004360454  mov      x1, x20
004360458  mov      x2, x21
00436045C  mov      x3, x22
004360460  ldr      x4, [x8, #0x20]
004360464  mov      x19, x0
004360468  bl       #0x5a0d8b0 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$.ctor
00436046C  mov      x0, x19
004360470  ldp      x20, x19, [sp, #0x20]
004360474  ldp      x22, x21, [sp, #0x10]
004360478  ldp      x30, x23, [sp], #0x30
00436047C  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Select<Vector3>
; RVA 0x4360480; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
004360480  stp      x30, x23, [sp, #-0x30]!
004360484  stp      x22, x21, [sp, #0x10]
004360488  stp      x20, x19, [sp, #0x20]
00436048C  ldr      x8, [x2, #0x38]
004360490  mov      x19, x2
004360494  mov      x22, x1
004360498  mov      x23, x0
00436049C  cbnz     x8, #0x43604ac
0043604A0  mov      x0, x19
0043604A4  bl       #0x3a7e668 ; 
0043604A8  ldr      x8, [x19, #0x38]
0043604AC  ldr      x0, [x23, #0x30]
0043604B0  ldr      x2, [x8, #8]
0043604B4  ldp      x20, x21, [x23, #0x20]
0043604B8  mov      x1, x22
0043604BC  bl       #0x45a1378 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, object, Vector3>
0043604C0  ldr      x8, [x19, #0x38]
0043604C4  mov      x22, x0
0043604C8  ldr      x8, [x8, #0x18]
0043604CC  ldrb     w9, [x8, #0x135]
0043604D0  tbnz     w9, #0, #0x43604e0
0043604D4  mov      x0, x8
0043604D8  bl       #0x3a7e60c ; 
0043604DC  mov      x8, x0
0043604E0  mov      x0, x8
0043604E4  bl       #0x382bfa0 ; 
0043604E8  ldr      x8, [x19, #0x38]
0043604EC  mov      x1, x20
0043604F0  mov      x2, x21
0043604F4  mov      x3, x22
0043604F8  ldr      x4, [x8, #0x20]
0043604FC  mov      x19, x0
004360500  bl       #0x5a0db18 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Vector3>$$.ctor
004360504  mov      x0, x19
004360508  ldp      x20, x19, [sp, #0x20]
00436050C  ldp      x22, x21, [sp, #0x10]
004360510  ldp      x30, x23, [sp], #0x30
004360514  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$Where
; RVA 0x5A0DAB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0DAB0  stp      x30, x21, [sp, #-0x20]!
005A0DAB4  stp      x20, x19, [sp, #0x10]
005A0DAB8  ldr      x8, [x2, #0x20]
005A0DABC  mov      x20, x2
005A0DAC0  mov      x19, x1
005A0DAC4  mov      x21, x0
005A0DAC8  ldr      x8, [x8, #0xc0]
005A0DACC  ldr      x8, [x8, #0x70]
005A0DAD0  ldrb     w9, [x8, #0x135]
005A0DAD4  tbnz     w9, #0, #0x5a0dae4
005A0DAD8  mov      x0, x8
005A0DADC  bl       #0x3a7e60c ; 
005A0DAE0  mov      x8, x0
005A0DAE4  mov      x0, x8
005A0DAE8  bl       #0x382bfa0 ; 
005A0DAEC  ldr      x8, [x20, #0x20]
005A0DAF0  mov      x1, x21
005A0DAF4  mov      x2, x19
005A0DAF8  mov      x20, x0
005A0DAFC  ldr      x8, [x8, #0xc0]
005A0DB00  ldr      x3, [x8, #0x78]
005A0DB04  bl       #0x59caabc ; System.Linq.Enumerable.WhereEnumerableIterator<object>$$.ctor
005A0DB08  mov      x0, x20
005A0DB0C  ldp      x20, x19, [sp, #0x10]
005A0DB10  ldp      x30, x21, [sp], #0x20
005A0DB14  ret      

