; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrRelicData>$$.ctor
; RVA 0x5ABB0F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABB0F4  str      x30, [sp, #-0x30]!
005ABB0F8  stp      x22, x21, [sp, #0x10]
005ABB0FC  stp      x20, x19, [sp, #0x20]
005ABB100  ldr      x8, [x4, #0x20]
005ABB104  mov      x21, x1
005ABB108  mov      x19, x3
005ABB10C  mov      x20, x2
005ABB110  ldr      x8, [x8, #0xc0]
005ABB114  mov      x22, x0
005ABB118  ldr      x1, [x8]
005ABB11C  bl       #0x4a73644 ; System.Linq.Enumerable.Iterator<CalAttrRelicData>$$.ctor
005ABB120  mov      x0, x22
005ABB124  str      x21, [x0, #0x20]!
005ABB128  mov      x1, x21
005ABB12C  bl       #0x382bcb8 ; 
005ABB130  mov      x0, x22
005ABB134  str      x20, [x0, #0x28]!
005ABB138  mov      x1, x20
005ABB13C  bl       #0x382bcb8 ; 
005ABB140  str      x19, [x22, #0x30]!
005ABB144  mov      x0, x22
005ABB148  mov      x1, x19
005ABB14C  ldp      x20, x19, [sp, #0x20]
005ABB150  ldp      x22, x21, [sp, #0x10]
005ABB154  ldr      x30, [sp], #0x30
005ABB158  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrRelicData>$$Clone
; RVA 0x5ABB15C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABB15C  str      x30, [sp, #-0x30]!
005ABB160  stp      x22, x21, [sp, #0x10]
005ABB164  stp      x20, x19, [sp, #0x20]
005ABB168  ldr      x9, [x1, #0x20]
005ABB16C  mov      x8, x0
005ABB170  ldp      x21, x20, [x8, #0x20]
005ABB174  ldr      x22, [x8, #0x30]
005ABB178  ldr      x9, [x9, #0xc0]
005ABB17C  mov      x19, x1
005ABB180  ldr      x0, [x9, #0x18]
005ABB184  ldrb     w9, [x0, #0x135]
005ABB188  tbnz     w9, #0, #0x5abb190
005ABB18C  bl       #0x3a7e60c ; 
005ABB190  bl       #0x382bfa0 ; 
005ABB194  ldr      x8, [x19, #0x20]
005ABB198  mov      x1, x21
005ABB19C  mov      x2, x20
005ABB1A0  mov      x3, x22
005ABB1A4  ldr      x8, [x8, #0xc0]
005ABB1A8  mov      x19, x0
005ABB1AC  ldr      x4, [x8, #0x30]
005ABB1B0  bl       #0x5abb0f4 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrRelicData>$$.ctor
005ABB1B4  mov      x0, x19
005ABB1B8  ldp      x20, x19, [sp, #0x20]
005ABB1BC  ldp      x22, x21, [sp, #0x10]
005ABB1C0  ldr      x30, [sp], #0x30
005ABB1C4  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrRelicData>$$Dispose
; RVA 0x5ABB1C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABB1C8  str      x30, [sp, #-0x30]!
005ABB1CC  stp      x22, x21, [sp, #0x10]
005ABB1D0  stp      x20, x19, [sp, #0x20]
005ABB1D4  adrp     x21, #0x9595000
005ABB1D8  ldrb     w8, [x21, #0x44b]
005ABB1DC  mov      x19, x1
005ABB1E0  mov      x20, x0
005ABB1E4  tbnz     w8, #0, #0x5abb1fc
005ABB1E8  adrp     x0, #0x8ebf000
005ABB1EC  ldr      x0, [x0, #0x4e8]
005ABB1F0  bl       #0x382bd14 ; 
005ABB1F4  mov      w8, #1
005ABB1F8  strb     w8, [x21, #0x44b]
005ABB1FC  mov      x21, x20
005ABB200  ldr      x22, [x21, #0x38]!
005ABB204  cbz      x22, #0x5abb268
005ABB208  adrp     x10, #0x8ebf000
005ABB20C  ldr      x8, [x22]
005ABB210  ldr      x10, [x10, #0x4e8]
005ABB214  ldrh     w9, [x8, #0x12e]
005ABB218  ldr      x1, [x10]
005ABB21C  cbz      x9, #0x5abb240
005ABB220  ldr      x10, [x8, #0xb0]
005ABB224  add      x10, x10, #8
005ABB228  ldur     x11, [x10, #-8]
005ABB22C  cmp      x11, x1
005ABB230  b.eq     #0x5abb250
005ABB234  subs     x9, x9, #1
005ABB238  add      x10, x10, #0x10
005ABB23C  b.ne     #0x5abb228
005ABB240  mov      x0, x22
005ABB244  mov      w2, wzr
005ABB248  bl       #0x3a7e710 ; 
005ABB24C  b        #0x5abb25c ; 
005ABB250  ldrsw    x9, [x10]
005ABB254  add      x8, x8, x9, lsl #4
005ABB258  add      x0, x8, #0x138
005ABB25C  ldp      x8, x1, [x0]
005ABB260  mov      x0, x22
005ABB264  blr      x8
005ABB268  mov      x0, x21
005ABB26C  mov      x1, xzr
005ABB270  str      xzr, [x20, #0x38]
005ABB274  bl       #0x382bcb8 ; 
005ABB278  ldr      x8, [x19, #0x20]
005ABB27C  mov      x0, x20
005ABB280  ldp      x20, x19, [sp, #0x20]
005ABB284  ldp      x22, x21, [sp, #0x10]
005ABB288  ldr      x8, [x8, #0xc0]
005ABB28C  ldr      x1, [x8, #0x48]
005ABB290  ldr      x30, [sp], #0x30
005ABB294  b        #0x4a73680 ; System.Linq.Enumerable.Iterator<CalAttrRelicData>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrRelicData>$$MoveNext
; RVA 0x5ABB298; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABB298  sub      sp, sp, #0xf0
005ABB29C  str      x30, [sp, #0xc0]
005ABB2A0  stp      x22, x21, [sp, #0xd0]
005ABB2A4  stp      x20, x19, [sp, #0xe0]
005ABB2A8  adrp     x21, #0x9595000
005ABB2AC  ldrb     w8, [x21, #0x44c]
005ABB2B0  mov      x20, x1
005ABB2B4  mov      x19, x0
005ABB2B8  tbnz     w8, #0, #0x5abb2d0
005ABB2BC  adrp     x0, #0x8ebf000
005ABB2C0  ldr      x0, [x0, #0x4f0]
005ABB2C4  bl       #0x382bd14 ; 
005ABB2C8  mov      w8, #1
005ABB2CC  strb     w8, [x21, #0x44c]
005ABB2D0  ldr      w8, [x19, #0x14]
005ABB2D4  adrp     x22, #0x8ebf000
005ABB2D8  ldr      x22, [x22, #0x4f0]
005ABB2DC  cmp      w8, #2
005ABB2E0  b.eq     #0x5abb384
005ABB2E4  cmp      w8, #1
005ABB2E8  b.ne     #0x5abb524
005ABB2EC  ldr      x21, [x19, #0x20]
005ABB2F0  cbz      x21, #0x5abb53c
005ABB2F4  ldr      x8, [x20, #0x20]
005ABB2F8  ldr      x8, [x8, #0xc0]
005ABB2FC  ldr      x1, [x8, #0x10]
005ABB300  ldrb     w8, [x1, #0x135]
005ABB304  tbnz     w8, #0, #0x5abb314
005ABB308  mov      x0, x1
005ABB30C  bl       #0x3a7e60c ; 
005ABB310  mov      x1, x0
005ABB314  ldr      x8, [x21]
005ABB318  ldrh     w9, [x8, #0x12e]
005ABB31C  cbz      x9, #0x5abb340
005ABB320  ldr      x10, [x8, #0xb0]
005ABB324  add      x10, x10, #8
005ABB328  ldur     x11, [x10, #-8]
005ABB32C  cmp      x11, x1
005ABB330  b.eq     #0x5abb350
005ABB334  subs     x9, x9, #1
005ABB338  add      x10, x10, #0x10
005ABB33C  b.ne     #0x5abb328
005ABB340  mov      x0, x21
005ABB344  mov      w2, wzr
005ABB348  bl       #0x3a7e710 ; 
005ABB34C  b        #0x5abb35c ; 
005ABB350  ldrsw    x9, [x10]
005ABB354  add      x8, x8, x9, lsl #4
005ABB358  add      x0, x8, #0x138
005ABB35C  ldp      x8, x1, [x0]
005ABB360  mov      x0, x21
005ABB364  blr      x8
005ABB368  mov      x21, x19
005ABB36C  str      x0, [x21, #0x38]!
005ABB370  mov      x1, x0
005ABB374  mov      x0, x21
005ABB378  bl       #0x382bcb8 ; 
005ABB37C  mov      w8, #2
005ABB380  stur     w8, [x21, #-0x24]
005ABB384  ldr      x21, [x19, #0x38]
005ABB388  cbz      x21, #0x5abb53c
005ABB38C  ldr      x8, [x21]
005ABB390  ldr      x1, [x22]
005ABB394  ldrh     w9, [x8, #0x12e]
005ABB398  cbz      x9, #0x5abb3bc
005ABB39C  ldr      x10, [x8, #0xb0]
005ABB3A0  add      x10, x10, #8
005ABB3A4  ldur     x11, [x10, #-8]
005ABB3A8  cmp      x11, x1
005ABB3AC  b.eq     #0x5abb3cc
005ABB3B0  subs     x9, x9, #1
005ABB3B4  add      x10, x10, #0x10
005ABB3B8  b.ne     #0x5abb3a4
005ABB3BC  mov      x0, x21
005ABB3C0  mov      w2, wzr
005ABB3C4  bl       #0x3a7e710 ; 
005ABB3C8  b        #0x5abb3d8 ; 
005ABB3CC  ldrsw    x9, [x10]
005ABB3D0  add      x8, x8, x9, lsl #4
005ABB3D4  add      x0, x8, #0x138
005ABB3D8  ldp      x8, x1, [x0]
005ABB3DC  mov      x0, x21
005ABB3E0  blr      x8
005ABB3E4  tbz      w0, #0, #0x5abb510
005ABB3E8  ldr      x21, [x19, #0x38]
005ABB3EC  cbz      x21, #0x5abb53c
005ABB3F0  ldr      x8, [x20, #0x20]
005ABB3F4  ldr      x8, [x8, #0xc0]
005ABB3F8  ldr      x1, [x8, #0x40]
005ABB3FC  ldrb     w8, [x1, #0x135]
005ABB400  tbnz     w8, #0, #0x5abb410
005ABB404  mov      x0, x1
005ABB408  bl       #0x3a7e60c ; 
005ABB40C  mov      x1, x0
005ABB410  ldr      x8, [x21]
005ABB414  ldrh     w9, [x8, #0x12e]
005ABB418  cbz      x9, #0x5abb43c
005ABB41C  ldr      x10, [x8, #0xb0]
005ABB420  add      x10, x10, #8
005ABB424  ldur     x11, [x10, #-8]
005ABB428  cmp      x11, x1
005ABB42C  b.eq     #0x5abb44c
005ABB430  subs     x9, x9, #1
005ABB434  add      x10, x10, #0x10
005ABB438  b.ne     #0x5abb424
005ABB43C  mov      x0, x21
005ABB440  mov      w2, wzr
005ABB444  bl       #0x3a7e710 ; 
005ABB448  b        #0x5abb458 ; 
005ABB44C  ldrsw    x9, [x10]
005ABB450  add      x8, x8, x9, lsl #4
005ABB454  add      x0, x8, #0x138
005ABB458  ldp      x9, x1, [x0]
005ABB45C  add      x8, sp, #0x80
005ABB460  mov      x0, x21
005ABB464  blr      x9
005ABB468  ldp      q0, q1, [sp, #0x80]
005ABB46C  ldr      q2, [sp, #0xa0]
005ABB470  ldr      x8, [sp, #0xb0]
005ABB474  stp      q0, q1, [sp, #0x40]
005ABB478  str      q2, [sp, #0x60]
005ABB47C  str      x8, [sp, #0x70]
005ABB480  ldr      x8, [x19, #0x28]
005ABB484  cbz      x8, #0x5abb4b8
005ABB488  ldp      q0, q1, [sp, #0x40]
005ABB48C  ldr      q2, [sp, #0x60]
005ABB490  ldr      x10, [sp, #0x70]
005ABB494  ldr      x9, [x8, #0x18]
005ABB498  ldr      x0, [x8, #0x40]
005ABB49C  stp      q0, q1, [sp, #0x80]
005ABB4A0  str      q2, [sp, #0xa0]
005ABB4A4  str      x10, [sp, #0xb0]
005ABB4A8  ldr      x2, [x8, #0x28]
005ABB4AC  add      x1, sp, #0x80
005ABB4B0  blr      x9
005ABB4B4  tbz      w0, #0, #0x5abb384
005ABB4B8  ldr      x8, [x19, #0x30]
005ABB4BC  ldp      q0, q1, [sp, #0x40]
005ABB4C0  ldr      q2, [sp, #0x60]
005ABB4C4  ldr      x9, [sp, #0x70]
005ABB4C8  stp      q0, q1, [sp]
005ABB4CC  str      q2, [sp, #0x20]
005ABB4D0  str      x9, [sp, #0x30]
005ABB4D4  cbz      x8, #0x5abb53c
005ABB4D8  ldp      q0, q1, [sp]
005ABB4DC  ldr      q2, [sp, #0x20]
005ABB4E0  ldr      x10, [sp, #0x30]
005ABB4E4  ldr      x9, [x8, #0x18]
005ABB4E8  ldr      x0, [x8, #0x40]
005ABB4EC  stp      q0, q1, [sp, #0x80]
005ABB4F0  str      q2, [sp, #0xa0]
005ABB4F4  str      x10, [sp, #0xb0]
005ABB4F8  ldr      x2, [x8, #0x28]
005ABB4FC  add      x1, sp, #0x80
005ABB500  blr      x9
005ABB504  str      x0, [x19, #0x18]
005ABB508  mov      w0, #1
005ABB50C  b        #0x5abb528 ; 
005ABB510  cbz      x19, #0x5abb53c
005ABB514  ldr      x8, [x19]
005ABB518  mov      x0, x19
005ABB51C  ldp      x9, x1, [x8, #0x1f8]
005ABB520  blr      x9
005ABB524  mov      w0, wzr
005ABB528  ldp      x20, x19, [sp, #0xe0]
005ABB52C  ldp      x22, x21, [sp, #0xd0]
005ABB530  ldr      x30, [sp, #0xc0]
005ABB534  add      sp, sp, #0xf0
005ABB538  ret      
005ABB53C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalAttrRelicData>$$Where
; RVA 0x5ABB540; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABB540  stp      x30, x21, [sp, #-0x20]!
005ABB544  stp      x20, x19, [sp, #0x10]
005ABB548  ldr      x8, [x2, #0x20]
005ABB54C  mov      x20, x2
005ABB550  mov      x19, x1
005ABB554  mov      x21, x0
005ABB558  ldr      x8, [x8, #0xc0]
005ABB55C  ldr      x8, [x8, #0x88]
005ABB560  ldrb     w9, [x8, #0x135]
005ABB564  tbnz     w9, #0, #0x5abb574
005ABB568  mov      x0, x8
005ABB56C  bl       #0x3a7e60c ; 
005ABB570  mov      x8, x0
005ABB574  mov      x0, x8
005ABB578  bl       #0x382bfa0 ; 
005ABB57C  ldr      x8, [x20, #0x20]
005ABB580  mov      x1, x21
005ABB584  mov      x2, x19
005ABB588  mov      x20, x0
005ABB58C  ldr      x8, [x8, #0xc0]
005ABB590  ldr      x3, [x8, #0x90]
005ABB594  bl       #0x59c6ccc ; System.Linq.Enumerable.WhereEnumerableIterator<CalAttrRelicData>$$.ctor
005ABB598  mov      x0, x20
005ABB59C  ldp      x20, x19, [sp, #0x10]
005ABB5A0  ldp      x30, x21, [sp], #0x20
005ABB5A4  ret      

