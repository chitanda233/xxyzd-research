; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, int>$$.ctor
; RVA 0x5A0D19C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D19C  str      x30, [sp, #-0x30]!
005A0D1A0  stp      x22, x21, [sp, #0x10]
005A0D1A4  stp      x20, x19, [sp, #0x20]
005A0D1A8  ldr      x8, [x4, #0x20]
005A0D1AC  mov      x21, x1
005A0D1B0  mov      x19, x3
005A0D1B4  mov      x20, x2
005A0D1B8  ldr      x8, [x8, #0xc0]
005A0D1BC  mov      x22, x0
005A0D1C0  ldr      x1, [x8]
005A0D1C4  bl       #0x4a743d4 ; System.Linq.Enumerable.Iterator<int>$$.ctor
005A0D1C8  mov      x0, x22
005A0D1CC  str      x21, [x0, #0x20]!
005A0D1D0  mov      x1, x21
005A0D1D4  bl       #0x382bcb8 ; 
005A0D1D8  mov      x0, x22
005A0D1DC  str      x20, [x0, #0x28]!
005A0D1E0  mov      x1, x20
005A0D1E4  bl       #0x382bcb8 ; 
005A0D1E8  str      x19, [x22, #0x30]!
005A0D1EC  mov      x0, x22
005A0D1F0  mov      x1, x19
005A0D1F4  ldp      x20, x19, [sp, #0x20]
005A0D1F8  ldp      x22, x21, [sp, #0x10]
005A0D1FC  ldr      x30, [sp], #0x30
005A0D200  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, int>$$Clone
; RVA 0x5A0D204; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D204  str      x30, [sp, #-0x30]!
005A0D208  stp      x22, x21, [sp, #0x10]
005A0D20C  stp      x20, x19, [sp, #0x20]
005A0D210  ldr      x9, [x1, #0x20]
005A0D214  mov      x8, x0
005A0D218  ldp      x21, x20, [x8, #0x20]
005A0D21C  ldr      x22, [x8, #0x30]
005A0D220  ldr      x9, [x9, #0xc0]
005A0D224  mov      x19, x1
005A0D228  ldr      x0, [x9, #0x18]
005A0D22C  ldrb     w9, [x0, #0x135]
005A0D230  tbnz     w9, #0, #0x5a0d238
005A0D234  bl       #0x3a7e60c ; 
005A0D238  bl       #0x382bfa0 ; 
005A0D23C  ldr      x8, [x19, #0x20]
005A0D240  mov      x1, x21
005A0D244  mov      x2, x20
005A0D248  mov      x3, x22
005A0D24C  ldr      x8, [x8, #0xc0]
005A0D250  mov      x19, x0
005A0D254  ldr      x4, [x8, #0x30]
005A0D258  bl       #0x5a0d19c ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, int>$$.ctor
005A0D25C  mov      x0, x19
005A0D260  ldp      x20, x19, [sp, #0x20]
005A0D264  ldp      x22, x21, [sp, #0x10]
005A0D268  ldr      x30, [sp], #0x30
005A0D26C  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, int>$$MoveNext
; RVA 0x5A0D270; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D270  sub      sp, sp, #0xe0
005A0D274  str      x30, [sp, #0xc0]
005A0D278  stp      x20, x19, [sp, #0xd0]
005A0D27C  ldr      w8, [x0, #0x14]
005A0D280  cmp      w8, #1
005A0D284  b.ne     #0x5a0d374
005A0D288  mov      x19, x0
005A0D28C  mov      w20, #0x38
005A0D290  ldr      x9, [x19, #0x20]
005A0D294  cbz      x9, #0x5a0d38c
005A0D298  ldrsw    x8, [x19, #0x38]
005A0D29C  ldr      w10, [x9, #0x18]
005A0D2A0  cmp      w8, w10
005A0D2A4  b.ge     #0x5a0d364
005A0D2A8  cmp      w8, w10
005A0D2AC  b.hs     #0x5a0d388
005A0D2B0  madd     x9, x8, x20, x9
005A0D2B4  ldr      x10, [x9, #0x50]
005A0D2B8  ldp      q1, q0, [x9, #0x30]
005A0D2BC  ldr      q2, [x9, #0x20]
005A0D2C0  add      w8, w8, #1
005A0D2C4  str      x10, [sp, #0x70]
005A0D2C8  stp      q1, q0, [sp, #0x50]
005A0D2CC  str      q2, [sp, #0x40]
005A0D2D0  ldr      x9, [x19, #0x28]
005A0D2D4  str      w8, [x19, #0x38]
005A0D2D8  cbz      x9, #0x5a0d30c
005A0D2DC  ldp      q0, q1, [sp, #0x40]
005A0D2E0  ldr      q2, [sp, #0x60]
005A0D2E4  ldr      x10, [sp, #0x70]
005A0D2E8  ldr      x8, [x9, #0x18]
005A0D2EC  ldr      x0, [x9, #0x40]
005A0D2F0  stp      q0, q1, [sp, #0x80]
005A0D2F4  str      q2, [sp, #0xa0]
005A0D2F8  str      x10, [sp, #0xb0]
005A0D2FC  ldr      x2, [x9, #0x28]
005A0D300  add      x1, sp, #0x80
005A0D304  blr      x8
005A0D308  tbz      w0, #0, #0x5a0d290
005A0D30C  ldr      x8, [x19, #0x30]
005A0D310  ldp      q0, q1, [sp, #0x40]
005A0D314  ldr      q2, [sp, #0x60]
005A0D318  ldr      x9, [sp, #0x70]
005A0D31C  stp      q0, q1, [sp]
005A0D320  str      q2, [sp, #0x20]
005A0D324  str      x9, [sp, #0x30]
005A0D328  cbz      x8, #0x5a0d38c
005A0D32C  ldp      q0, q1, [sp]
005A0D330  ldr      q2, [sp, #0x20]
005A0D334  ldr      x10, [sp, #0x30]
005A0D338  ldr      x9, [x8, #0x18]
005A0D33C  ldr      x0, [x8, #0x40]
005A0D340  stp      q0, q1, [sp, #0x80]
005A0D344  str      q2, [sp, #0xa0]
005A0D348  str      x10, [sp, #0xb0]
005A0D34C  ldr      x2, [x8, #0x28]
005A0D350  add      x1, sp, #0x80
005A0D354  blr      x9
005A0D358  str      w0, [x19, #0x18]
005A0D35C  mov      w0, #1
005A0D360  b        #0x5a0d378 ; 
005A0D364  ldr      x8, [x19]
005A0D368  mov      x0, x19
005A0D36C  ldp      x9, x1, [x8, #0x1f8]
005A0D370  blr      x9
005A0D374  mov      w0, wzr
005A0D378  ldp      x20, x19, [sp, #0xd0]
005A0D37C  ldr      x30, [sp, #0xc0]
005A0D380  add      sp, sp, #0xe0
005A0D384  ret      
005A0D388  bl       #0x382bfc0 ; 
005A0D38C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, int>$$Select<int>
; RVA 0x435FA68; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00435FA68  stp      x30, x23, [sp, #-0x30]!
00435FA6C  stp      x22, x21, [sp, #0x10]
00435FA70  stp      x20, x19, [sp, #0x20]
00435FA74  ldr      x8, [x2, #0x38]
00435FA78  mov      x19, x2
00435FA7C  mov      x22, x1
00435FA80  mov      x23, x0
00435FA84  cbnz     x8, #0x435fa94
00435FA88  mov      x0, x19
00435FA8C  bl       #0x3a7e668 ; 
00435FA90  ldr      x8, [x19, #0x38]
00435FA94  ldr      x0, [x23, #0x30]
00435FA98  ldr      x2, [x8, #8]
00435FA9C  ldp      x20, x21, [x23, #0x20]
00435FAA0  mov      x1, x22
00435FAA4  bl       #0x45a06fc ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, int, int>
00435FAA8  ldr      x8, [x19, #0x38]
00435FAAC  mov      x22, x0
00435FAB0  ldr      x8, [x8, #0x18]
00435FAB4  ldrb     w9, [x8, #0x135]
00435FAB8  tbnz     w9, #0, #0x435fac8
00435FABC  mov      x0, x8
00435FAC0  bl       #0x3a7e60c ; 
00435FAC4  mov      x8, x0
00435FAC8  mov      x0, x8
00435FACC  bl       #0x382bfa0 ; 
00435FAD0  ldr      x8, [x19, #0x38]
00435FAD4  mov      x1, x20
00435FAD8  mov      x2, x21
00435FADC  mov      x3, x22
00435FAE0  ldr      x4, [x8, #0x20]
00435FAE4  mov      x19, x0
00435FAE8  bl       #0x5a0d19c ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, int>$$.ctor
00435FAEC  mov      x0, x19
00435FAF0  ldp      x20, x19, [sp, #0x20]
00435FAF4  ldp      x22, x21, [sp, #0x10]
00435FAF8  ldp      x30, x23, [sp], #0x30
00435FAFC  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, int>$$Select<Int32Enum>
; RVA 0x435FB00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00435FB00  stp      x30, x23, [sp, #-0x30]!
00435FB04  stp      x22, x21, [sp, #0x10]
00435FB08  stp      x20, x19, [sp, #0x20]
00435FB0C  ldr      x8, [x2, #0x38]
00435FB10  mov      x19, x2
00435FB14  mov      x22, x1
00435FB18  mov      x23, x0
00435FB1C  cbnz     x8, #0x435fb2c
00435FB20  mov      x0, x19
00435FB24  bl       #0x3a7e668 ; 
00435FB28  ldr      x8, [x19, #0x38]
00435FB2C  ldr      x0, [x23, #0x30]
00435FB30  ldr      x2, [x8, #8]
00435FB34  ldp      x20, x21, [x23, #0x20]
00435FB38  mov      x1, x22
00435FB3C  bl       #0x45a07b8 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, int, Int32Enum>
00435FB40  ldr      x8, [x19, #0x38]
00435FB44  mov      x22, x0
00435FB48  ldr      x8, [x8, #0x18]
00435FB4C  ldrb     w9, [x8, #0x135]
00435FB50  tbnz     w9, #0, #0x435fb60
00435FB54  mov      x0, x8
00435FB58  bl       #0x3a7e60c ; 
00435FB5C  mov      x8, x0
00435FB60  mov      x0, x8
00435FB64  bl       #0x382bfa0 ; 
00435FB68  ldr      x8, [x19, #0x38]
00435FB6C  mov      x1, x20
00435FB70  mov      x2, x21
00435FB74  mov      x3, x22
00435FB78  ldr      x4, [x8, #0x20]
00435FB7C  mov      x19, x0
00435FB80  bl       #0x5a0d3f8 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, Int32Enum>$$.ctor
00435FB84  mov      x0, x19
00435FB88  ldp      x20, x19, [sp, #0x20]
00435FB8C  ldp      x22, x21, [sp, #0x10]
00435FB90  ldp      x30, x23, [sp], #0x30
00435FB94  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, int>$$Select<object>
; RVA 0x435FB98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00435FB98  stp      x30, x23, [sp, #-0x30]!
00435FB9C  stp      x22, x21, [sp, #0x10]
00435FBA0  stp      x20, x19, [sp, #0x20]
00435FBA4  ldr      x8, [x2, #0x38]
00435FBA8  mov      x19, x2
00435FBAC  mov      x22, x1
00435FBB0  mov      x23, x0
00435FBB4  cbnz     x8, #0x435fbc4
00435FBB8  mov      x0, x19
00435FBBC  bl       #0x3a7e668 ; 
00435FBC0  ldr      x8, [x19, #0x38]
00435FBC4  ldr      x0, [x23, #0x30]
00435FBC8  ldr      x2, [x8, #8]
00435FBCC  ldp      x20, x21, [x23, #0x20]
00435FBD0  mov      x1, x22
00435FBD4  bl       #0x45a0874 ; System.Linq.Enumerable$$CombineSelectors<WeightRandomData, int, object>
00435FBD8  ldr      x8, [x19, #0x38]
00435FBDC  mov      x22, x0
00435FBE0  ldr      x8, [x8, #0x18]
00435FBE4  ldrb     w9, [x8, #0x135]
00435FBE8  tbnz     w9, #0, #0x435fbf8
00435FBEC  mov      x0, x8
00435FBF0  bl       #0x3a7e60c ; 
00435FBF4  mov      x8, x0
00435FBF8  mov      x0, x8
00435FBFC  bl       #0x382bfa0 ; 
00435FC00  ldr      x8, [x19, #0x38]
00435FC04  mov      x1, x20
00435FC08  mov      x2, x21
00435FC0C  mov      x3, x22
00435FC10  ldr      x4, [x8, #0x20]
00435FC14  mov      x19, x0
00435FC18  bl       #0x5a0d8b0 ; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, object>$$.ctor
00435FC1C  mov      x0, x19
00435FC20  ldp      x20, x19, [sp, #0x20]
00435FC24  ldp      x22, x21, [sp, #0x10]
00435FC28  ldp      x30, x23, [sp], #0x30
00435FC2C  ret      

; System.Linq.Enumerable.WhereSelectArrayIterator<WeightRandomData, int>$$Where
; RVA 0x5A0D390; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005A0D390  stp      x30, x21, [sp, #-0x20]!
005A0D394  stp      x20, x19, [sp, #0x10]
005A0D398  ldr      x8, [x2, #0x20]
005A0D39C  mov      x20, x2
005A0D3A0  mov      x19, x1
005A0D3A4  mov      x21, x0
005A0D3A8  ldr      x8, [x8, #0xc0]
005A0D3AC  ldr      x8, [x8, #0x70]
005A0D3B0  ldrb     w9, [x8, #0x135]
005A0D3B4  tbnz     w9, #0, #0x5a0d3c4
005A0D3B8  mov      x0, x8
005A0D3BC  bl       #0x3a7e60c ; 
005A0D3C0  mov      x8, x0
005A0D3C4  mov      x0, x8
005A0D3C8  bl       #0x382bfa0 ; 
005A0D3CC  ldr      x8, [x20, #0x20]
005A0D3D0  mov      x1, x21
005A0D3D4  mov      x2, x19
005A0D3D8  mov      x20, x0
005A0D3DC  ldr      x8, [x8, #0xc0]
005A0D3E0  ldr      x3, [x8, #0x78]
005A0D3E4  bl       #0x59c9e80 ; System.Linq.Enumerable.WhereEnumerableIterator<int>$$.ctor
005A0D3E8  mov      x0, x20
005A0D3EC  ldp      x20, x19, [sp, #0x10]
005A0D3F0  ldp      x30, x21, [sp], #0x20
005A0D3F4  ret      

