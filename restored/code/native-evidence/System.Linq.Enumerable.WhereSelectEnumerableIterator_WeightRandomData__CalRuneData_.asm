; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRuneData>$$.ctor
; RVA 0x5ABC3EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABC3EC  str      x30, [sp, #-0x30]!
005ABC3F0  stp      x22, x21, [sp, #0x10]
005ABC3F4  stp      x20, x19, [sp, #0x20]
005ABC3F8  ldr      x8, [x4, #0x20]
005ABC3FC  mov      x21, x1
005ABC400  mov      x19, x3
005ABC404  mov      x20, x2
005ABC408  ldr      x8, [x8, #0xc0]
005ABC40C  mov      x22, x0
005ABC410  ldr      x1, [x8]
005ABC414  bl       #0x4a73ac4 ; System.Linq.Enumerable.Iterator<CalRuneData>$$.ctor
005ABC418  mov      x0, x22
005ABC41C  str      x21, [x0, #0x20]!
005ABC420  mov      x1, x21
005ABC424  bl       #0x382bcb8 ; 
005ABC428  mov      x0, x22
005ABC42C  str      x20, [x0, #0x28]!
005ABC430  mov      x1, x20
005ABC434  bl       #0x382bcb8 ; 
005ABC438  str      x19, [x22, #0x30]!
005ABC43C  mov      x0, x22
005ABC440  mov      x1, x19
005ABC444  ldp      x20, x19, [sp, #0x20]
005ABC448  ldp      x22, x21, [sp, #0x10]
005ABC44C  ldr      x30, [sp], #0x30
005ABC450  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRuneData>$$Clone
; RVA 0x5ABC454; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABC454  str      x30, [sp, #-0x30]!
005ABC458  stp      x22, x21, [sp, #0x10]
005ABC45C  stp      x20, x19, [sp, #0x20]
005ABC460  ldr      x9, [x1, #0x20]
005ABC464  mov      x8, x0
005ABC468  ldp      x21, x20, [x8, #0x20]
005ABC46C  ldr      x22, [x8, #0x30]
005ABC470  ldr      x9, [x9, #0xc0]
005ABC474  mov      x19, x1
005ABC478  ldr      x0, [x9, #0x18]
005ABC47C  ldrb     w9, [x0, #0x135]
005ABC480  tbnz     w9, #0, #0x5abc488
005ABC484  bl       #0x3a7e60c ; 
005ABC488  bl       #0x382bfa0 ; 
005ABC48C  ldr      x8, [x19, #0x20]
005ABC490  mov      x1, x21
005ABC494  mov      x2, x20
005ABC498  mov      x3, x22
005ABC49C  ldr      x8, [x8, #0xc0]
005ABC4A0  mov      x19, x0
005ABC4A4  ldr      x4, [x8, #0x30]
005ABC4A8  bl       #0x5abc3ec ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRuneData>$$.ctor
005ABC4AC  mov      x0, x19
005ABC4B0  ldp      x20, x19, [sp, #0x20]
005ABC4B4  ldp      x22, x21, [sp, #0x10]
005ABC4B8  ldr      x30, [sp], #0x30
005ABC4BC  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRuneData>$$Dispose
; RVA 0x5ABC4C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABC4C0  str      x30, [sp, #-0x30]!
005ABC4C4  stp      x22, x21, [sp, #0x10]
005ABC4C8  stp      x20, x19, [sp, #0x20]
005ABC4CC  adrp     x21, #0x9595000
005ABC4D0  ldrb     w8, [x21, #0x453]
005ABC4D4  mov      x19, x1
005ABC4D8  mov      x20, x0
005ABC4DC  tbnz     w8, #0, #0x5abc4f4
005ABC4E0  adrp     x0, #0x8ebf000
005ABC4E4  ldr      x0, [x0, #0x4e8]
005ABC4E8  bl       #0x382bd14 ; 
005ABC4EC  mov      w8, #1
005ABC4F0  strb     w8, [x21, #0x453]
005ABC4F4  mov      x21, x20
005ABC4F8  ldr      x22, [x21, #0x38]!
005ABC4FC  cbz      x22, #0x5abc560
005ABC500  adrp     x10, #0x8ebf000
005ABC504  ldr      x8, [x22]
005ABC508  ldr      x10, [x10, #0x4e8]
005ABC50C  ldrh     w9, [x8, #0x12e]
005ABC510  ldr      x1, [x10]
005ABC514  cbz      x9, #0x5abc538
005ABC518  ldr      x10, [x8, #0xb0]
005ABC51C  add      x10, x10, #8
005ABC520  ldur     x11, [x10, #-8]
005ABC524  cmp      x11, x1
005ABC528  b.eq     #0x5abc548
005ABC52C  subs     x9, x9, #1
005ABC530  add      x10, x10, #0x10
005ABC534  b.ne     #0x5abc520
005ABC538  mov      x0, x22
005ABC53C  mov      w2, wzr
005ABC540  bl       #0x3a7e710 ; 
005ABC544  b        #0x5abc554 ; 
005ABC548  ldrsw    x9, [x10]
005ABC54C  add      x8, x8, x9, lsl #4
005ABC550  add      x0, x8, #0x138
005ABC554  ldp      x8, x1, [x0]
005ABC558  mov      x0, x22
005ABC55C  blr      x8
005ABC560  mov      x0, x21
005ABC564  mov      x1, xzr
005ABC568  str      xzr, [x20, #0x38]
005ABC56C  bl       #0x382bcb8 ; 
005ABC570  ldr      x8, [x19, #0x20]
005ABC574  mov      x0, x20
005ABC578  ldp      x20, x19, [sp, #0x20]
005ABC57C  ldp      x22, x21, [sp, #0x10]
005ABC580  ldr      x8, [x8, #0xc0]
005ABC584  ldr      x1, [x8, #0x48]
005ABC588  ldr      x30, [sp], #0x30
005ABC58C  b        #0x4a73b00 ; System.Linq.Enumerable.Iterator<CalRuneData>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRuneData>$$MoveNext
; RVA 0x5ABC590; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABC590  sub      sp, sp, #0xf0
005ABC594  str      x30, [sp, #0xc0]
005ABC598  stp      x22, x21, [sp, #0xd0]
005ABC59C  stp      x20, x19, [sp, #0xe0]
005ABC5A0  adrp     x21, #0x9595000
005ABC5A4  ldrb     w8, [x21, #0x454]
005ABC5A8  mov      x20, x1
005ABC5AC  mov      x19, x0
005ABC5B0  tbnz     w8, #0, #0x5abc5c8
005ABC5B4  adrp     x0, #0x8ebf000
005ABC5B8  ldr      x0, [x0, #0x4f0]
005ABC5BC  bl       #0x382bd14 ; 
005ABC5C0  mov      w8, #1
005ABC5C4  strb     w8, [x21, #0x454]
005ABC5C8  ldr      w8, [x19, #0x14]
005ABC5CC  adrp     x22, #0x8ebf000
005ABC5D0  ldr      x22, [x22, #0x4f0]
005ABC5D4  cmp      w8, #2
005ABC5D8  b.eq     #0x5abc67c
005ABC5DC  cmp      w8, #1
005ABC5E0  b.ne     #0x5abc81c
005ABC5E4  ldr      x21, [x19, #0x20]
005ABC5E8  cbz      x21, #0x5abc834
005ABC5EC  ldr      x8, [x20, #0x20]
005ABC5F0  ldr      x8, [x8, #0xc0]
005ABC5F4  ldr      x1, [x8, #0x10]
005ABC5F8  ldrb     w8, [x1, #0x135]
005ABC5FC  tbnz     w8, #0, #0x5abc60c
005ABC600  mov      x0, x1
005ABC604  bl       #0x3a7e60c ; 
005ABC608  mov      x1, x0
005ABC60C  ldr      x8, [x21]
005ABC610  ldrh     w9, [x8, #0x12e]
005ABC614  cbz      x9, #0x5abc638
005ABC618  ldr      x10, [x8, #0xb0]
005ABC61C  add      x10, x10, #8
005ABC620  ldur     x11, [x10, #-8]
005ABC624  cmp      x11, x1
005ABC628  b.eq     #0x5abc648
005ABC62C  subs     x9, x9, #1
005ABC630  add      x10, x10, #0x10
005ABC634  b.ne     #0x5abc620
005ABC638  mov      x0, x21
005ABC63C  mov      w2, wzr
005ABC640  bl       #0x3a7e710 ; 
005ABC644  b        #0x5abc654 ; 
005ABC648  ldrsw    x9, [x10]
005ABC64C  add      x8, x8, x9, lsl #4
005ABC650  add      x0, x8, #0x138
005ABC654  ldp      x8, x1, [x0]
005ABC658  mov      x0, x21
005ABC65C  blr      x8
005ABC660  mov      x21, x19
005ABC664  str      x0, [x21, #0x38]!
005ABC668  mov      x1, x0
005ABC66C  mov      x0, x21
005ABC670  bl       #0x382bcb8 ; 
005ABC674  mov      w8, #2
005ABC678  stur     w8, [x21, #-0x24]
005ABC67C  ldr      x21, [x19, #0x38]
005ABC680  cbz      x21, #0x5abc834
005ABC684  ldr      x8, [x21]
005ABC688  ldr      x1, [x22]
005ABC68C  ldrh     w9, [x8, #0x12e]
005ABC690  cbz      x9, #0x5abc6b4
005ABC694  ldr      x10, [x8, #0xb0]
005ABC698  add      x10, x10, #8
005ABC69C  ldur     x11, [x10, #-8]
005ABC6A0  cmp      x11, x1
005ABC6A4  b.eq     #0x5abc6c4
005ABC6A8  subs     x9, x9, #1
005ABC6AC  add      x10, x10, #0x10
005ABC6B0  b.ne     #0x5abc69c
005ABC6B4  mov      x0, x21
005ABC6B8  mov      w2, wzr
005ABC6BC  bl       #0x3a7e710 ; 
005ABC6C0  b        #0x5abc6d0 ; 
005ABC6C4  ldrsw    x9, [x10]
005ABC6C8  add      x8, x8, x9, lsl #4
005ABC6CC  add      x0, x8, #0x138
005ABC6D0  ldp      x8, x1, [x0]
005ABC6D4  mov      x0, x21
005ABC6D8  blr      x8
005ABC6DC  tbz      w0, #0, #0x5abc808
005ABC6E0  ldr      x21, [x19, #0x38]
005ABC6E4  cbz      x21, #0x5abc834
005ABC6E8  ldr      x8, [x20, #0x20]
005ABC6EC  ldr      x8, [x8, #0xc0]
005ABC6F0  ldr      x1, [x8, #0x40]
005ABC6F4  ldrb     w8, [x1, #0x135]
005ABC6F8  tbnz     w8, #0, #0x5abc708
005ABC6FC  mov      x0, x1
005ABC700  bl       #0x3a7e60c ; 
005ABC704  mov      x1, x0
005ABC708  ldr      x8, [x21]
005ABC70C  ldrh     w9, [x8, #0x12e]
005ABC710  cbz      x9, #0x5abc734
005ABC714  ldr      x10, [x8, #0xb0]
005ABC718  add      x10, x10, #8
005ABC71C  ldur     x11, [x10, #-8]
005ABC720  cmp      x11, x1
005ABC724  b.eq     #0x5abc744
005ABC728  subs     x9, x9, #1
005ABC72C  add      x10, x10, #0x10
005ABC730  b.ne     #0x5abc71c
005ABC734  mov      x0, x21
005ABC738  mov      w2, wzr
005ABC73C  bl       #0x3a7e710 ; 
005ABC740  b        #0x5abc750 ; 
005ABC744  ldrsw    x9, [x10]
005ABC748  add      x8, x8, x9, lsl #4
005ABC74C  add      x0, x8, #0x138
005ABC750  ldp      x9, x1, [x0]
005ABC754  add      x8, sp, #0x80
005ABC758  mov      x0, x21
005ABC75C  blr      x9
005ABC760  ldp      q0, q1, [sp, #0x80]
005ABC764  ldr      q2, [sp, #0xa0]
005ABC768  ldr      x8, [sp, #0xb0]
005ABC76C  stp      q0, q1, [sp, #0x40]
005ABC770  str      q2, [sp, #0x60]
005ABC774  str      x8, [sp, #0x70]
005ABC778  ldr      x8, [x19, #0x28]
005ABC77C  cbz      x8, #0x5abc7b0
005ABC780  ldp      q0, q1, [sp, #0x40]
005ABC784  ldr      q2, [sp, #0x60]
005ABC788  ldr      x10, [sp, #0x70]
005ABC78C  ldr      x9, [x8, #0x18]
005ABC790  ldr      x0, [x8, #0x40]
005ABC794  stp      q0, q1, [sp, #0x80]
005ABC798  str      q2, [sp, #0xa0]
005ABC79C  str      x10, [sp, #0xb0]
005ABC7A0  ldr      x2, [x8, #0x28]
005ABC7A4  add      x1, sp, #0x80
005ABC7A8  blr      x9
005ABC7AC  tbz      w0, #0, #0x5abc67c
005ABC7B0  ldr      x8, [x19, #0x30]
005ABC7B4  ldp      q0, q1, [sp, #0x40]
005ABC7B8  ldr      q2, [sp, #0x60]
005ABC7BC  ldr      x9, [sp, #0x70]
005ABC7C0  stp      q0, q1, [sp]
005ABC7C4  str      q2, [sp, #0x20]
005ABC7C8  str      x9, [sp, #0x30]
005ABC7CC  cbz      x8, #0x5abc834
005ABC7D0  ldp      q0, q1, [sp]
005ABC7D4  ldr      q2, [sp, #0x20]
005ABC7D8  ldr      x10, [sp, #0x30]
005ABC7DC  ldr      x9, [x8, #0x18]
005ABC7E0  ldr      x0, [x8, #0x40]
005ABC7E4  stp      q0, q1, [sp, #0x80]
005ABC7E8  str      q2, [sp, #0xa0]
005ABC7EC  str      x10, [sp, #0xb0]
005ABC7F0  ldr      x2, [x8, #0x28]
005ABC7F4  add      x1, sp, #0x80
005ABC7F8  blr      x9
005ABC7FC  str      w0, [x19, #0x18]
005ABC800  mov      w0, #1
005ABC804  b        #0x5abc820 ; 
005ABC808  cbz      x19, #0x5abc834
005ABC80C  ldr      x8, [x19]
005ABC810  mov      x0, x19
005ABC814  ldp      x9, x1, [x8, #0x1f8]
005ABC818  blr      x9
005ABC81C  mov      w0, wzr
005ABC820  ldp      x20, x19, [sp, #0xe0]
005ABC824  ldp      x22, x21, [sp, #0xd0]
005ABC828  ldr      x30, [sp, #0xc0]
005ABC82C  add      sp, sp, #0xf0
005ABC830  ret      
005ABC834  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, CalRuneData>$$Where
; RVA 0x5ABC838; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABC838  stp      x30, x21, [sp, #-0x20]!
005ABC83C  stp      x20, x19, [sp, #0x10]
005ABC840  ldr      x8, [x2, #0x20]
005ABC844  mov      x20, x2
005ABC848  mov      x19, x1
005ABC84C  mov      x21, x0
005ABC850  ldr      x8, [x8, #0xc0]
005ABC854  ldr      x8, [x8, #0x88]
005ABC858  ldrb     w9, [x8, #0x135]
005ABC85C  tbnz     w9, #0, #0x5abc86c
005ABC860  mov      x0, x8
005ABC864  bl       #0x3a7e60c ; 
005ABC868  mov      x8, x0
005ABC86C  mov      x0, x8
005ABC870  bl       #0x382bfa0 ; 
005ABC874  ldr      x8, [x20, #0x20]
005ABC878  mov      x1, x21
005ABC87C  mov      x2, x19
005ABC880  mov      x20, x0
005ABC884  ldr      x8, [x8, #0xc0]
005ABC888  ldr      x3, [x8, #0x90]
005ABC88C  bl       #0x59c7d64 ; System.Linq.Enumerable.WhereEnumerableIterator<CalRuneData>$$.ctor
005ABC890  mov      x0, x20
005ABC894  ldp      x20, x19, [sp, #0x10]
005ABC898  ldp      x30, x21, [sp], #0x20
005ABC89C  ret      

