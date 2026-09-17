; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, AttributeOneElement>$$.ctor
; RVA 0x5ABA2A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABA2A4  str      x30, [sp, #-0x30]!
005ABA2A8  stp      x22, x21, [sp, #0x10]
005ABA2AC  stp      x20, x19, [sp, #0x20]
005ABA2B0  ldr      x8, [x4, #0x20]
005ABA2B4  mov      x21, x1
005ABA2B8  mov      x19, x3
005ABA2BC  mov      x20, x2
005ABA2C0  ldr      x8, [x8, #0xc0]
005ABA2C4  mov      x22, x0
005ABA2C8  ldr      x1, [x8]
005ABA2CC  bl       #0x4a72e4c ; System.Linq.Enumerable.Iterator<AttributeOneElement>$$.ctor
005ABA2D0  mov      x0, x22
005ABA2D4  str      x21, [x0, #0x30]!
005ABA2D8  mov      x1, x21
005ABA2DC  bl       #0x382bcb8 ; 
005ABA2E0  mov      x0, x22
005ABA2E4  str      x20, [x0, #0x38]!
005ABA2E8  mov      x1, x20
005ABA2EC  bl       #0x382bcb8 ; 
005ABA2F0  str      x19, [x22, #0x40]!
005ABA2F4  mov      x0, x22
005ABA2F8  mov      x1, x19
005ABA2FC  ldp      x20, x19, [sp, #0x20]
005ABA300  ldp      x22, x21, [sp, #0x10]
005ABA304  ldr      x30, [sp], #0x30
005ABA308  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, AttributeOneElement>$$Clone
; RVA 0x5ABA30C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABA30C  str      x30, [sp, #-0x30]!
005ABA310  stp      x22, x21, [sp, #0x10]
005ABA314  stp      x20, x19, [sp, #0x20]
005ABA318  ldr      x9, [x1, #0x20]
005ABA31C  mov      x8, x0
005ABA320  ldp      x21, x20, [x8, #0x30]
005ABA324  ldr      x22, [x8, #0x40]
005ABA328  ldr      x9, [x9, #0xc0]
005ABA32C  mov      x19, x1
005ABA330  ldr      x0, [x9, #0x18]
005ABA334  ldrb     w9, [x0, #0x135]
005ABA338  tbnz     w9, #0, #0x5aba340
005ABA33C  bl       #0x3a7e60c ; 
005ABA340  bl       #0x382bfa0 ; 
005ABA344  ldr      x8, [x19, #0x20]
005ABA348  mov      x1, x21
005ABA34C  mov      x2, x20
005ABA350  mov      x3, x22
005ABA354  ldr      x8, [x8, #0xc0]
005ABA358  mov      x19, x0
005ABA35C  ldr      x4, [x8, #0x30]
005ABA360  bl       #0x5aba2a4 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, AttributeOneElement>$$.ctor
005ABA364  mov      x0, x19
005ABA368  ldp      x20, x19, [sp, #0x20]
005ABA36C  ldp      x22, x21, [sp, #0x10]
005ABA370  ldr      x30, [sp], #0x30
005ABA374  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, AttributeOneElement>$$Dispose
; RVA 0x5ABA378; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABA378  str      x30, [sp, #-0x30]!
005ABA37C  stp      x22, x21, [sp, #0x10]
005ABA380  stp      x20, x19, [sp, #0x20]
005ABA384  adrp     x21, #0x9595000
005ABA388  ldrb     w8, [x21, #0x445]
005ABA38C  mov      x19, x1
005ABA390  mov      x20, x0
005ABA394  tbnz     w8, #0, #0x5aba3ac
005ABA398  adrp     x0, #0x8ebf000
005ABA39C  ldr      x0, [x0, #0x4e8]
005ABA3A0  bl       #0x382bd14 ; 
005ABA3A4  mov      w8, #1
005ABA3A8  strb     w8, [x21, #0x445]
005ABA3AC  mov      x21, x20
005ABA3B0  ldr      x22, [x21, #0x48]!
005ABA3B4  cbz      x22, #0x5aba418
005ABA3B8  adrp     x10, #0x8ebf000
005ABA3BC  ldr      x8, [x22]
005ABA3C0  ldr      x10, [x10, #0x4e8]
005ABA3C4  ldrh     w9, [x8, #0x12e]
005ABA3C8  ldr      x1, [x10]
005ABA3CC  cbz      x9, #0x5aba3f0
005ABA3D0  ldr      x10, [x8, #0xb0]
005ABA3D4  add      x10, x10, #8
005ABA3D8  ldur     x11, [x10, #-8]
005ABA3DC  cmp      x11, x1
005ABA3E0  b.eq     #0x5aba400
005ABA3E4  subs     x9, x9, #1
005ABA3E8  add      x10, x10, #0x10
005ABA3EC  b.ne     #0x5aba3d8
005ABA3F0  mov      x0, x22
005ABA3F4  mov      w2, wzr
005ABA3F8  bl       #0x3a7e710 ; 
005ABA3FC  b        #0x5aba40c ; 
005ABA400  ldrsw    x9, [x10]
005ABA404  add      x8, x8, x9, lsl #4
005ABA408  add      x0, x8, #0x138
005ABA40C  ldp      x8, x1, [x0]
005ABA410  mov      x0, x22
005ABA414  blr      x8
005ABA418  mov      x0, x21
005ABA41C  mov      x1, xzr
005ABA420  str      xzr, [x20, #0x48]
005ABA424  bl       #0x382bcb8 ; 
005ABA428  ldr      x8, [x19, #0x20]
005ABA42C  mov      x0, x20
005ABA430  ldp      x20, x19, [sp, #0x20]
005ABA434  ldp      x22, x21, [sp, #0x10]
005ABA438  ldr      x8, [x8, #0xc0]
005ABA43C  ldr      x1, [x8, #0x48]
005ABA440  ldr      x30, [sp], #0x30
005ABA444  b        #0x4a72e94 ; System.Linq.Enumerable.Iterator<AttributeOneElement>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, AttributeOneElement>$$MoveNext
; RVA 0x5ABA448; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABA448  sub      sp, sp, #0x120
005ABA44C  str      x29, [sp, #0xe0]
005ABA450  stp      x30, x23, [sp, #0xf0]
005ABA454  stp      x22, x21, [sp, #0x100]
005ABA458  stp      x20, x19, [sp, #0x110]
005ABA45C  adrp     x21, #0x9595000
005ABA460  ldrb     w8, [x21, #0x446]
005ABA464  mov      x20, x1
005ABA468  mov      x19, x0
005ABA46C  tbnz     w8, #0, #0x5aba484
005ABA470  adrp     x0, #0x8ebf000
005ABA474  ldr      x0, [x0, #0x4f0]
005ABA478  bl       #0x382bd14 ; 
005ABA47C  mov      w8, #1
005ABA480  strb     w8, [x21, #0x446]
005ABA484  ldr      w8, [x19, #0x14]
005ABA488  adrp     x23, #0x8ebf000
005ABA48C  ldr      x23, [x23, #0x4f0]
005ABA490  add      x22, sp, #0xa0
005ABA494  cmp      w8, #2
005ABA498  b.eq     #0x5aba53c
005ABA49C  cmp      w8, #1
005ABA4A0  b.ne     #0x5aba700
005ABA4A4  ldr      x21, [x19, #0x30]
005ABA4A8  cbz      x21, #0x5aba71c
005ABA4AC  ldr      x8, [x20, #0x20]
005ABA4B0  ldr      x8, [x8, #0xc0]
005ABA4B4  ldr      x1, [x8, #0x10]
005ABA4B8  ldrb     w8, [x1, #0x135]
005ABA4BC  tbnz     w8, #0, #0x5aba4cc
005ABA4C0  mov      x0, x1
005ABA4C4  bl       #0x3a7e60c ; 
005ABA4C8  mov      x1, x0
005ABA4CC  ldr      x8, [x21]
005ABA4D0  ldrh     w9, [x8, #0x12e]
005ABA4D4  cbz      x9, #0x5aba4f8
005ABA4D8  ldr      x10, [x8, #0xb0]
005ABA4DC  add      x10, x10, #8
005ABA4E0  ldur     x11, [x10, #-8]
005ABA4E4  cmp      x11, x1
005ABA4E8  b.eq     #0x5aba508
005ABA4EC  subs     x9, x9, #1
005ABA4F0  add      x10, x10, #0x10
005ABA4F4  b.ne     #0x5aba4e0
005ABA4F8  mov      x0, x21
005ABA4FC  mov      w2, wzr
005ABA500  bl       #0x3a7e710 ; 
005ABA504  b        #0x5aba514 ; 
005ABA508  ldrsw    x9, [x10]
005ABA50C  add      x8, x8, x9, lsl #4
005ABA510  add      x0, x8, #0x138
005ABA514  ldp      x8, x1, [x0]
005ABA518  mov      x0, x21
005ABA51C  blr      x8
005ABA520  mov      x21, x19
005ABA524  str      x0, [x21, #0x48]!
005ABA528  mov      x1, x0
005ABA52C  mov      x0, x21
005ABA530  bl       #0x382bcb8 ; 
005ABA534  mov      w8, #2
005ABA538  stur     w8, [x21, #-0x34]
005ABA53C  ldr      x21, [x19, #0x48]
005ABA540  cbz      x21, #0x5aba71c
005ABA544  ldr      x8, [x21]
005ABA548  ldr      x1, [x23]
005ABA54C  ldrh     w9, [x8, #0x12e]
005ABA550  cbz      x9, #0x5aba574
005ABA554  ldr      x10, [x8, #0xb0]
005ABA558  add      x10, x10, #8
005ABA55C  ldur     x11, [x10, #-8]
005ABA560  cmp      x11, x1
005ABA564  b.eq     #0x5aba584
005ABA568  subs     x9, x9, #1
005ABA56C  add      x10, x10, #0x10
005ABA570  b.ne     #0x5aba55c
005ABA574  mov      x0, x21
005ABA578  mov      w2, wzr
005ABA57C  bl       #0x3a7e710 ; 
005ABA580  b        #0x5aba590 ; 
005ABA584  ldrsw    x9, [x10]
005ABA588  add      x8, x8, x9, lsl #4
005ABA58C  add      x0, x8, #0x138
005ABA590  ldp      x8, x1, [x0]
005ABA594  mov      x0, x21
005ABA598  blr      x8
005ABA59C  tbz      w0, #0, #0x5aba6ec
005ABA5A0  ldr      x21, [x19, #0x48]
005ABA5A4  cbz      x21, #0x5aba71c
005ABA5A8  ldr      x8, [x20, #0x20]
005ABA5AC  ldr      x8, [x8, #0xc0]
005ABA5B0  ldr      x1, [x8, #0x40]
005ABA5B4  ldrb     w8, [x1, #0x135]
005ABA5B8  tbnz     w8, #0, #0x5aba5c8
005ABA5BC  mov      x0, x1
005ABA5C0  bl       #0x3a7e60c ; 
005ABA5C4  mov      x1, x0
005ABA5C8  ldr      x8, [x21]
005ABA5CC  ldrh     w9, [x8, #0x12e]
005ABA5D0  cbz      x9, #0x5aba5f4
005ABA5D4  ldr      x10, [x8, #0xb0]
005ABA5D8  add      x10, x10, #8
005ABA5DC  ldur     x11, [x10, #-8]
005ABA5E0  cmp      x11, x1
005ABA5E4  b.eq     #0x5aba604
005ABA5E8  subs     x9, x9, #1
005ABA5EC  add      x10, x10, #0x10
005ABA5F0  b.ne     #0x5aba5dc
005ABA5F4  mov      x0, x21
005ABA5F8  mov      w2, wzr
005ABA5FC  bl       #0x3a7e710 ; 
005ABA600  b        #0x5aba610 ; 
005ABA604  ldrsw    x9, [x10]
005ABA608  add      x8, x8, x9, lsl #4
005ABA60C  add      x0, x8, #0x138
005ABA610  ldp      x9, x1, [x0]
005ABA614  add      x8, sp, #0xa0
005ABA618  mov      x0, x21
005ABA61C  blr      x9
005ABA620  ldp      q0, q1, [x22]
005ABA624  ldr      q2, [x22, #0x20]
005ABA628  ldr      x8, [sp, #0xd0]
005ABA62C  stp      q0, q1, [sp, #0x60]
005ABA630  str      q2, [sp, #0x80]
005ABA634  str      x8, [sp, #0x90]
005ABA638  ldr      x8, [x19, #0x38]
005ABA63C  cbz      x8, #0x5aba670
005ABA640  ldp      q0, q1, [sp, #0x60]
005ABA644  ldr      q2, [sp, #0x80]
005ABA648  ldr      x10, [sp, #0x90]
005ABA64C  ldr      x9, [x8, #0x18]
005ABA650  ldr      x0, [x8, #0x40]
005ABA654  stp      q0, q1, [x22]
005ABA658  str      q2, [x22, #0x20]
005ABA65C  str      x10, [sp, #0xd0]
005ABA660  ldr      x2, [x8, #0x28]
005ABA664  add      x1, sp, #0xa0
005ABA668  blr      x9
005ABA66C  tbz      w0, #0, #0x5aba53c
005ABA670  ldr      x8, [x19, #0x40]
005ABA674  ldp      q0, q1, [sp, #0x60]
005ABA678  ldr      q2, [sp, #0x80]
005ABA67C  ldr      x9, [sp, #0x90]
005ABA680  stp      q0, q1, [sp, #0x20]
005ABA684  str      q2, [sp, #0x40]
005ABA688  str      x9, [sp, #0x50]
005ABA68C  cbz      x8, #0x5aba71c
005ABA690  ldp      q0, q1, [sp, #0x20]
005ABA694  ldr      q2, [sp, #0x40]
005ABA698  ldr      x10, [sp, #0x50]
005ABA69C  ldr      x9, [x8, #0x18]
005ABA6A0  ldr      x0, [x8, #0x40]
005ABA6A4  stp      q0, q1, [x22]
005ABA6A8  str      q2, [x22, #0x20]
005ABA6AC  str      x10, [sp, #0xd0]
005ABA6B0  ldr      x2, [x8, #0x28]
005ABA6B4  add      x8, sp, #8
005ABA6B8  add      x1, sp, #0xa0
005ABA6BC  blr      x9
005ABA6C0  ldr      x8, [sp, #0x18]
005ABA6C4  ldur     q0, [sp, #8]
005ABA6C8  add      x0, x19, #0x18
005ABA6CC  mov      x1, xzr
005ABA6D0  str      x8, [sp, #0xb0]
005ABA6D4  str      q0, [x22]
005ABA6D8  str      x8, [x19, #0x28]
005ABA6DC  stur     q0, [x19, #0x18]
005ABA6E0  bl       #0x382bcb8 ; 
005ABA6E4  mov      w0, #1
005ABA6E8  b        #0x5aba704 ; 
005ABA6EC  cbz      x19, #0x5aba71c
005ABA6F0  ldr      x8, [x19]
005ABA6F4  mov      x0, x19
005ABA6F8  ldp      x9, x1, [x8, #0x1f8]
005ABA6FC  blr      x9
005ABA700  mov      w0, wzr
005ABA704  ldp      x20, x19, [sp, #0x110]
005ABA708  ldp      x22, x21, [sp, #0x100]
005ABA70C  ldp      x30, x23, [sp, #0xf0]
005ABA710  ldr      x29, [sp, #0xe0]
005ABA714  add      sp, sp, #0x120
005ABA718  ret      
005ABA71C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, AttributeOneElement>$$Where
; RVA 0x5ABA720; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABA720  stp      x30, x21, [sp, #-0x20]!
005ABA724  stp      x20, x19, [sp, #0x10]
005ABA728  ldr      x8, [x2, #0x20]
005ABA72C  mov      x20, x2
005ABA730  mov      x19, x1
005ABA734  mov      x21, x0
005ABA738  ldr      x8, [x8, #0xc0]
005ABA73C  ldr      x8, [x8, #0x88]
005ABA740  ldrb     w9, [x8, #0x135]
005ABA744  tbnz     w9, #0, #0x5aba754
005ABA748  mov      x0, x8
005ABA74C  bl       #0x3a7e60c ; 
005ABA750  mov      x8, x0
005ABA754  mov      x0, x8
005ABA758  bl       #0x382bfa0 ; 
005ABA75C  ldr      x8, [x20, #0x20]
005ABA760  mov      x1, x21
005ABA764  mov      x2, x19
005ABA768  mov      x20, x0
005ABA76C  ldr      x8, [x8, #0xc0]
005ABA770  ldr      x3, [x8, #0x90]
005ABA774  bl       #0x59c4fa0 ; System.Linq.Enumerable.WhereEnumerableIterator<AttributeOneElement>$$.ctor
005ABA778  mov      x0, x20
005ABA77C  ldp      x20, x19, [sp, #0x10]
005ABA780  ldp      x30, x21, [sp], #0x20
005ABA784  ret      

