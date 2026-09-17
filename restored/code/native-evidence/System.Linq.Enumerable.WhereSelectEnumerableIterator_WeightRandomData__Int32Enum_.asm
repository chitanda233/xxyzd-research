; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Int32Enum>$$.ctor
; RVA 0x5ABD208; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABD208  str      x30, [sp, #-0x30]!
005ABD20C  stp      x22, x21, [sp, #0x10]
005ABD210  stp      x20, x19, [sp, #0x20]
005ABD214  ldr      x8, [x4, #0x20]
005ABD218  mov      x21, x1
005ABD21C  mov      x19, x3
005ABD220  mov      x20, x2
005ABD224  ldr      x8, [x8, #0xc0]
005ABD228  mov      x22, x0
005ABD22C  ldr      x1, [x8]
005ABD230  bl       #0x4a744e4 ; System.Linq.Enumerable.Iterator<Int32Enum>$$.ctor
005ABD234  mov      x0, x22
005ABD238  str      x21, [x0, #0x20]!
005ABD23C  mov      x1, x21
005ABD240  bl       #0x382bcb8 ; 
005ABD244  mov      x0, x22
005ABD248  str      x20, [x0, #0x28]!
005ABD24C  mov      x1, x20
005ABD250  bl       #0x382bcb8 ; 
005ABD254  str      x19, [x22, #0x30]!
005ABD258  mov      x0, x22
005ABD25C  mov      x1, x19
005ABD260  ldp      x20, x19, [sp, #0x20]
005ABD264  ldp      x22, x21, [sp, #0x10]
005ABD268  ldr      x30, [sp], #0x30
005ABD26C  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Int32Enum>$$Clone
; RVA 0x5ABD270; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABD270  str      x30, [sp, #-0x30]!
005ABD274  stp      x22, x21, [sp, #0x10]
005ABD278  stp      x20, x19, [sp, #0x20]
005ABD27C  ldr      x9, [x1, #0x20]
005ABD280  mov      x8, x0
005ABD284  ldp      x21, x20, [x8, #0x20]
005ABD288  ldr      x22, [x8, #0x30]
005ABD28C  ldr      x9, [x9, #0xc0]
005ABD290  mov      x19, x1
005ABD294  ldr      x0, [x9, #0x18]
005ABD298  ldrb     w9, [x0, #0x135]
005ABD29C  tbnz     w9, #0, #0x5abd2a4
005ABD2A0  bl       #0x3a7e60c ; 
005ABD2A4  bl       #0x382bfa0 ; 
005ABD2A8  ldr      x8, [x19, #0x20]
005ABD2AC  mov      x1, x21
005ABD2B0  mov      x2, x20
005ABD2B4  mov      x3, x22
005ABD2B8  ldr      x8, [x8, #0xc0]
005ABD2BC  mov      x19, x0
005ABD2C0  ldr      x4, [x8, #0x30]
005ABD2C4  bl       #0x5abd208 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Int32Enum>$$.ctor
005ABD2C8  mov      x0, x19
005ABD2CC  ldp      x20, x19, [sp, #0x20]
005ABD2D0  ldp      x22, x21, [sp, #0x10]
005ABD2D4  ldr      x30, [sp], #0x30
005ABD2D8  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Int32Enum>$$Dispose
; RVA 0x5ABD2DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABD2DC  str      x30, [sp, #-0x30]!
005ABD2E0  stp      x22, x21, [sp, #0x10]
005ABD2E4  stp      x20, x19, [sp, #0x20]
005ABD2E8  adrp     x21, #0x9595000
005ABD2EC  ldrb     w8, [x21, #0x459]
005ABD2F0  mov      x19, x1
005ABD2F4  mov      x20, x0
005ABD2F8  tbnz     w8, #0, #0x5abd310
005ABD2FC  adrp     x0, #0x8ebf000
005ABD300  ldr      x0, [x0, #0x4e8]
005ABD304  bl       #0x382bd14 ; 
005ABD308  mov      w8, #1
005ABD30C  strb     w8, [x21, #0x459]
005ABD310  mov      x21, x20
005ABD314  ldr      x22, [x21, #0x38]!
005ABD318  cbz      x22, #0x5abd37c
005ABD31C  adrp     x10, #0x8ebf000
005ABD320  ldr      x8, [x22]
005ABD324  ldr      x10, [x10, #0x4e8]
005ABD328  ldrh     w9, [x8, #0x12e]
005ABD32C  ldr      x1, [x10]
005ABD330  cbz      x9, #0x5abd354
005ABD334  ldr      x10, [x8, #0xb0]
005ABD338  add      x10, x10, #8
005ABD33C  ldur     x11, [x10, #-8]
005ABD340  cmp      x11, x1
005ABD344  b.eq     #0x5abd364
005ABD348  subs     x9, x9, #1
005ABD34C  add      x10, x10, #0x10
005ABD350  b.ne     #0x5abd33c
005ABD354  mov      x0, x22
005ABD358  mov      w2, wzr
005ABD35C  bl       #0x3a7e710 ; 
005ABD360  b        #0x5abd370 ; 
005ABD364  ldrsw    x9, [x10]
005ABD368  add      x8, x8, x9, lsl #4
005ABD36C  add      x0, x8, #0x138
005ABD370  ldp      x8, x1, [x0]
005ABD374  mov      x0, x22
005ABD378  blr      x8
005ABD37C  mov      x0, x21
005ABD380  mov      x1, xzr
005ABD384  str      xzr, [x20, #0x38]
005ABD388  bl       #0x382bcb8 ; 
005ABD38C  ldr      x8, [x19, #0x20]
005ABD390  mov      x0, x20
005ABD394  ldp      x20, x19, [sp, #0x20]
005ABD398  ldp      x22, x21, [sp, #0x10]
005ABD39C  ldr      x8, [x8, #0xc0]
005ABD3A0  ldr      x1, [x8, #0x48]
005ABD3A4  ldr      x30, [sp], #0x30
005ABD3A8  b        #0x4a74520 ; System.Linq.Enumerable.Iterator<Int32Enum>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Int32Enum>$$MoveNext
; RVA 0x5ABD3AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABD3AC  sub      sp, sp, #0xf0
005ABD3B0  str      x30, [sp, #0xc0]
005ABD3B4  stp      x22, x21, [sp, #0xd0]
005ABD3B8  stp      x20, x19, [sp, #0xe0]
005ABD3BC  adrp     x21, #0x9595000
005ABD3C0  ldrb     w8, [x21, #0x45a]
005ABD3C4  mov      x20, x1
005ABD3C8  mov      x19, x0
005ABD3CC  tbnz     w8, #0, #0x5abd3e4
005ABD3D0  adrp     x0, #0x8ebf000
005ABD3D4  ldr      x0, [x0, #0x4f0]
005ABD3D8  bl       #0x382bd14 ; 
005ABD3DC  mov      w8, #1
005ABD3E0  strb     w8, [x21, #0x45a]
005ABD3E4  ldr      w8, [x19, #0x14]
005ABD3E8  adrp     x22, #0x8ebf000
005ABD3EC  ldr      x22, [x22, #0x4f0]
005ABD3F0  cmp      w8, #2
005ABD3F4  b.eq     #0x5abd498
005ABD3F8  cmp      w8, #1
005ABD3FC  b.ne     #0x5abd638
005ABD400  ldr      x21, [x19, #0x20]
005ABD404  cbz      x21, #0x5abd650
005ABD408  ldr      x8, [x20, #0x20]
005ABD40C  ldr      x8, [x8, #0xc0]
005ABD410  ldr      x1, [x8, #0x10]
005ABD414  ldrb     w8, [x1, #0x135]
005ABD418  tbnz     w8, #0, #0x5abd428
005ABD41C  mov      x0, x1
005ABD420  bl       #0x3a7e60c ; 
005ABD424  mov      x1, x0
005ABD428  ldr      x8, [x21]
005ABD42C  ldrh     w9, [x8, #0x12e]
005ABD430  cbz      x9, #0x5abd454
005ABD434  ldr      x10, [x8, #0xb0]
005ABD438  add      x10, x10, #8
005ABD43C  ldur     x11, [x10, #-8]
005ABD440  cmp      x11, x1
005ABD444  b.eq     #0x5abd464
005ABD448  subs     x9, x9, #1
005ABD44C  add      x10, x10, #0x10
005ABD450  b.ne     #0x5abd43c
005ABD454  mov      x0, x21
005ABD458  mov      w2, wzr
005ABD45C  bl       #0x3a7e710 ; 
005ABD460  b        #0x5abd470 ; 
005ABD464  ldrsw    x9, [x10]
005ABD468  add      x8, x8, x9, lsl #4
005ABD46C  add      x0, x8, #0x138
005ABD470  ldp      x8, x1, [x0]
005ABD474  mov      x0, x21
005ABD478  blr      x8
005ABD47C  mov      x21, x19
005ABD480  str      x0, [x21, #0x38]!
005ABD484  mov      x1, x0
005ABD488  mov      x0, x21
005ABD48C  bl       #0x382bcb8 ; 
005ABD490  mov      w8, #2
005ABD494  stur     w8, [x21, #-0x24]
005ABD498  ldr      x21, [x19, #0x38]
005ABD49C  cbz      x21, #0x5abd650
005ABD4A0  ldr      x8, [x21]
005ABD4A4  ldr      x1, [x22]
005ABD4A8  ldrh     w9, [x8, #0x12e]
005ABD4AC  cbz      x9, #0x5abd4d0
005ABD4B0  ldr      x10, [x8, #0xb0]
005ABD4B4  add      x10, x10, #8
005ABD4B8  ldur     x11, [x10, #-8]
005ABD4BC  cmp      x11, x1
005ABD4C0  b.eq     #0x5abd4e0
005ABD4C4  subs     x9, x9, #1
005ABD4C8  add      x10, x10, #0x10
005ABD4CC  b.ne     #0x5abd4b8
005ABD4D0  mov      x0, x21
005ABD4D4  mov      w2, wzr
005ABD4D8  bl       #0x3a7e710 ; 
005ABD4DC  b        #0x5abd4ec ; 
005ABD4E0  ldrsw    x9, [x10]
005ABD4E4  add      x8, x8, x9, lsl #4
005ABD4E8  add      x0, x8, #0x138
005ABD4EC  ldp      x8, x1, [x0]
005ABD4F0  mov      x0, x21
005ABD4F4  blr      x8
005ABD4F8  tbz      w0, #0, #0x5abd624
005ABD4FC  ldr      x21, [x19, #0x38]
005ABD500  cbz      x21, #0x5abd650
005ABD504  ldr      x8, [x20, #0x20]
005ABD508  ldr      x8, [x8, #0xc0]
005ABD50C  ldr      x1, [x8, #0x40]
005ABD510  ldrb     w8, [x1, #0x135]
005ABD514  tbnz     w8, #0, #0x5abd524
005ABD518  mov      x0, x1
005ABD51C  bl       #0x3a7e60c ; 
005ABD520  mov      x1, x0
005ABD524  ldr      x8, [x21]
005ABD528  ldrh     w9, [x8, #0x12e]
005ABD52C  cbz      x9, #0x5abd550
005ABD530  ldr      x10, [x8, #0xb0]
005ABD534  add      x10, x10, #8
005ABD538  ldur     x11, [x10, #-8]
005ABD53C  cmp      x11, x1
005ABD540  b.eq     #0x5abd560
005ABD544  subs     x9, x9, #1
005ABD548  add      x10, x10, #0x10
005ABD54C  b.ne     #0x5abd538
005ABD550  mov      x0, x21
005ABD554  mov      w2, wzr
005ABD558  bl       #0x3a7e710 ; 
005ABD55C  b        #0x5abd56c ; 
005ABD560  ldrsw    x9, [x10]
005ABD564  add      x8, x8, x9, lsl #4
005ABD568  add      x0, x8, #0x138
005ABD56C  ldp      x9, x1, [x0]
005ABD570  add      x8, sp, #0x80
005ABD574  mov      x0, x21
005ABD578  blr      x9
005ABD57C  ldp      q0, q1, [sp, #0x80]
005ABD580  ldr      q2, [sp, #0xa0]
005ABD584  ldr      x8, [sp, #0xb0]
005ABD588  stp      q0, q1, [sp, #0x40]
005ABD58C  str      q2, [sp, #0x60]
005ABD590  str      x8, [sp, #0x70]
005ABD594  ldr      x8, [x19, #0x28]
005ABD598  cbz      x8, #0x5abd5cc
005ABD59C  ldp      q0, q1, [sp, #0x40]
005ABD5A0  ldr      q2, [sp, #0x60]
005ABD5A4  ldr      x10, [sp, #0x70]
005ABD5A8  ldr      x9, [x8, #0x18]
005ABD5AC  ldr      x0, [x8, #0x40]
005ABD5B0  stp      q0, q1, [sp, #0x80]
005ABD5B4  str      q2, [sp, #0xa0]
005ABD5B8  str      x10, [sp, #0xb0]
005ABD5BC  ldr      x2, [x8, #0x28]
005ABD5C0  add      x1, sp, #0x80
005ABD5C4  blr      x9
005ABD5C8  tbz      w0, #0, #0x5abd498
005ABD5CC  ldr      x8, [x19, #0x30]
005ABD5D0  ldp      q0, q1, [sp, #0x40]
005ABD5D4  ldr      q2, [sp, #0x60]
005ABD5D8  ldr      x9, [sp, #0x70]
005ABD5DC  stp      q0, q1, [sp]
005ABD5E0  str      q2, [sp, #0x20]
005ABD5E4  str      x9, [sp, #0x30]
005ABD5E8  cbz      x8, #0x5abd650
005ABD5EC  ldp      q0, q1, [sp]
005ABD5F0  ldr      q2, [sp, #0x20]
005ABD5F4  ldr      x10, [sp, #0x30]
005ABD5F8  ldr      x9, [x8, #0x18]
005ABD5FC  ldr      x0, [x8, #0x40]
005ABD600  stp      q0, q1, [sp, #0x80]
005ABD604  str      q2, [sp, #0xa0]
005ABD608  str      x10, [sp, #0xb0]
005ABD60C  ldr      x2, [x8, #0x28]
005ABD610  add      x1, sp, #0x80
005ABD614  blr      x9
005ABD618  str      w0, [x19, #0x18]
005ABD61C  mov      w0, #1
005ABD620  b        #0x5abd63c ; 
005ABD624  cbz      x19, #0x5abd650
005ABD628  ldr      x8, [x19]
005ABD62C  mov      x0, x19
005ABD630  ldp      x9, x1, [x8, #0x1f8]
005ABD634  blr      x9
005ABD638  mov      w0, wzr
005ABD63C  ldp      x20, x19, [sp, #0xe0]
005ABD640  ldp      x22, x21, [sp, #0xd0]
005ABD644  ldr      x30, [sp, #0xc0]
005ABD648  add      sp, sp, #0xf0
005ABD64C  ret      
005ABD650  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Int32Enum>$$Where
; RVA 0x5ABD654; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABD654  stp      x30, x21, [sp, #-0x20]!
005ABD658  stp      x20, x19, [sp, #0x10]
005ABD65C  ldr      x8, [x2, #0x20]
005ABD660  mov      x20, x2
005ABD664  mov      x19, x1
005ABD668  mov      x21, x0
005ABD66C  ldr      x8, [x8, #0xc0]
005ABD670  ldr      x8, [x8, #0x88]
005ABD674  ldrb     w9, [x8, #0x135]
005ABD678  tbnz     w9, #0, #0x5abd688
005ABD67C  mov      x0, x8
005ABD680  bl       #0x3a7e60c ; 
005ABD684  mov      x8, x0
005ABD688  mov      x0, x8
005ABD68C  bl       #0x382bfa0 ; 
005ABD690  ldr      x8, [x20, #0x20]
005ABD694  mov      x1, x21
005ABD698  mov      x2, x19
005ABD69C  mov      x20, x0
005ABD6A0  ldr      x8, [x8, #0xc0]
005ABD6A4  ldr      x3, [x8, #0x90]
005ABD6A8  bl       #0x59ca294 ; System.Linq.Enumerable.WhereEnumerableIterator<Int32Enum>$$.ctor
005ABD6AC  mov      x0, x20
005ABD6B0  ldp      x20, x19, [sp, #0x10]
005ABD6B4  ldp      x30, x21, [sp], #0x20
005ABD6B8  ret      

