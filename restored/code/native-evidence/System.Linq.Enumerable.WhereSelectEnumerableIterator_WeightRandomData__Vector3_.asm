; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Vector3>$$.ctor
; RVA 0x5ABE030; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABE030  str      x30, [sp, #-0x30]!
005ABE034  stp      x22, x21, [sp, #0x10]
005ABE038  stp      x20, x19, [sp, #0x20]
005ABE03C  ldr      x8, [x4, #0x20]
005ABE040  mov      x21, x1
005ABE044  mov      x19, x3
005ABE048  mov      x20, x2
005ABE04C  ldr      x8, [x8, #0xc0]
005ABE050  mov      x22, x0
005ABE054  ldr      x1, [x8]
005ABE058  bl       #0x4a7519c ; System.Linq.Enumerable.Iterator<Vector3>$$.ctor
005ABE05C  mov      x0, x22
005ABE060  str      x21, [x0, #0x28]!
005ABE064  mov      x1, x21
005ABE068  bl       #0x382bcb8 ; 
005ABE06C  mov      x0, x22
005ABE070  str      x20, [x0, #0x30]!
005ABE074  mov      x1, x20
005ABE078  bl       #0x382bcb8 ; 
005ABE07C  str      x19, [x22, #0x38]!
005ABE080  mov      x0, x22
005ABE084  mov      x1, x19
005ABE088  ldp      x20, x19, [sp, #0x20]
005ABE08C  ldp      x22, x21, [sp, #0x10]
005ABE090  ldr      x30, [sp], #0x30
005ABE094  b        #0x382bcb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Vector3>$$Clone
; RVA 0x5ABE098; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABE098  str      x30, [sp, #-0x30]!
005ABE09C  stp      x22, x21, [sp, #0x10]
005ABE0A0  stp      x20, x19, [sp, #0x20]
005ABE0A4  ldr      x9, [x1, #0x20]
005ABE0A8  mov      x8, x0
005ABE0AC  ldp      x21, x20, [x8, #0x28]
005ABE0B0  ldr      x22, [x8, #0x38]
005ABE0B4  ldr      x9, [x9, #0xc0]
005ABE0B8  mov      x19, x1
005ABE0BC  ldr      x0, [x9, #0x18]
005ABE0C0  ldrb     w9, [x0, #0x135]
005ABE0C4  tbnz     w9, #0, #0x5abe0cc
005ABE0C8  bl       #0x3a7e60c ; 
005ABE0CC  bl       #0x382bfa0 ; 
005ABE0D0  ldr      x8, [x19, #0x20]
005ABE0D4  mov      x1, x21
005ABE0D8  mov      x2, x20
005ABE0DC  mov      x3, x22
005ABE0E0  ldr      x8, [x8, #0xc0]
005ABE0E4  mov      x19, x0
005ABE0E8  ldr      x4, [x8, #0x30]
005ABE0EC  bl       #0x5abe030 ; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Vector3>$$.ctor
005ABE0F0  mov      x0, x19
005ABE0F4  ldp      x20, x19, [sp, #0x20]
005ABE0F8  ldp      x22, x21, [sp, #0x10]
005ABE0FC  ldr      x30, [sp], #0x30
005ABE100  ret      

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Vector3>$$Dispose
; RVA 0x5ABE104; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABE104  str      x30, [sp, #-0x30]!
005ABE108  stp      x22, x21, [sp, #0x10]
005ABE10C  stp      x20, x19, [sp, #0x20]
005ABE110  adrp     x21, #0x9595000
005ABE114  ldrb     w8, [x21, #0x45f]
005ABE118  mov      x19, x1
005ABE11C  mov      x20, x0
005ABE120  tbnz     w8, #0, #0x5abe138
005ABE124  adrp     x0, #0x8ebf000
005ABE128  ldr      x0, [x0, #0x4e8]
005ABE12C  bl       #0x382bd14 ; 
005ABE130  mov      w8, #1
005ABE134  strb     w8, [x21, #0x45f]
005ABE138  mov      x21, x20
005ABE13C  ldr      x22, [x21, #0x40]!
005ABE140  cbz      x22, #0x5abe1a4
005ABE144  adrp     x10, #0x8ebf000
005ABE148  ldr      x8, [x22]
005ABE14C  ldr      x10, [x10, #0x4e8]
005ABE150  ldrh     w9, [x8, #0x12e]
005ABE154  ldr      x1, [x10]
005ABE158  cbz      x9, #0x5abe17c
005ABE15C  ldr      x10, [x8, #0xb0]
005ABE160  add      x10, x10, #8
005ABE164  ldur     x11, [x10, #-8]
005ABE168  cmp      x11, x1
005ABE16C  b.eq     #0x5abe18c
005ABE170  subs     x9, x9, #1
005ABE174  add      x10, x10, #0x10
005ABE178  b.ne     #0x5abe164
005ABE17C  mov      x0, x22
005ABE180  mov      w2, wzr
005ABE184  bl       #0x3a7e710 ; 
005ABE188  b        #0x5abe198 ; 
005ABE18C  ldrsw    x9, [x10]
005ABE190  add      x8, x8, x9, lsl #4
005ABE194  add      x0, x8, #0x138
005ABE198  ldp      x8, x1, [x0]
005ABE19C  mov      x0, x22
005ABE1A0  blr      x8
005ABE1A4  mov      x0, x21
005ABE1A8  mov      x1, xzr
005ABE1AC  str      xzr, [x20, #0x40]
005ABE1B0  bl       #0x382bcb8 ; 
005ABE1B4  ldr      x8, [x19, #0x20]
005ABE1B8  mov      x0, x20
005ABE1BC  ldp      x20, x19, [sp, #0x20]
005ABE1C0  ldp      x22, x21, [sp, #0x10]
005ABE1C4  ldr      x8, [x8, #0xc0]
005ABE1C8  ldr      x1, [x8, #0x48]
005ABE1CC  ldr      x30, [sp], #0x30
005ABE1D0  b        #0x4a751dc ; System.Linq.Enumerable.Iterator<Vector3>$$Dispose

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Vector3>$$MoveNext
; RVA 0x5ABE1D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABE1D4  sub      sp, sp, #0xf0
005ABE1D8  str      x30, [sp, #0xc0]
005ABE1DC  stp      x22, x21, [sp, #0xd0]
005ABE1E0  stp      x20, x19, [sp, #0xe0]
005ABE1E4  adrp     x21, #0x9595000
005ABE1E8  ldrb     w8, [x21, #0x460]
005ABE1EC  mov      x20, x1
005ABE1F0  mov      x19, x0
005ABE1F4  tbnz     w8, #0, #0x5abe20c
005ABE1F8  adrp     x0, #0x8ebf000
005ABE1FC  ldr      x0, [x0, #0x4f0]
005ABE200  bl       #0x382bd14 ; 
005ABE204  mov      w8, #1
005ABE208  strb     w8, [x21, #0x460]
005ABE20C  ldr      w8, [x19, #0x14]
005ABE210  adrp     x22, #0x8ebf000
005ABE214  ldr      x22, [x22, #0x4f0]
005ABE218  cmp      w8, #2
005ABE21C  b.eq     #0x5abe2c0
005ABE220  cmp      w8, #1
005ABE224  b.ne     #0x5abe464
005ABE228  ldr      x21, [x19, #0x28]
005ABE22C  cbz      x21, #0x5abe47c
005ABE230  ldr      x8, [x20, #0x20]
005ABE234  ldr      x8, [x8, #0xc0]
005ABE238  ldr      x1, [x8, #0x10]
005ABE23C  ldrb     w8, [x1, #0x135]
005ABE240  tbnz     w8, #0, #0x5abe250
005ABE244  mov      x0, x1
005ABE248  bl       #0x3a7e60c ; 
005ABE24C  mov      x1, x0
005ABE250  ldr      x8, [x21]
005ABE254  ldrh     w9, [x8, #0x12e]
005ABE258  cbz      x9, #0x5abe27c
005ABE25C  ldr      x10, [x8, #0xb0]
005ABE260  add      x10, x10, #8
005ABE264  ldur     x11, [x10, #-8]
005ABE268  cmp      x11, x1
005ABE26C  b.eq     #0x5abe28c
005ABE270  subs     x9, x9, #1
005ABE274  add      x10, x10, #0x10
005ABE278  b.ne     #0x5abe264
005ABE27C  mov      x0, x21
005ABE280  mov      w2, wzr
005ABE284  bl       #0x3a7e710 ; 
005ABE288  b        #0x5abe298 ; 
005ABE28C  ldrsw    x9, [x10]
005ABE290  add      x8, x8, x9, lsl #4
005ABE294  add      x0, x8, #0x138
005ABE298  ldp      x8, x1, [x0]
005ABE29C  mov      x0, x21
005ABE2A0  blr      x8
005ABE2A4  mov      x21, x19
005ABE2A8  str      x0, [x21, #0x40]!
005ABE2AC  mov      x1, x0
005ABE2B0  mov      x0, x21
005ABE2B4  bl       #0x382bcb8 ; 
005ABE2B8  mov      w8, #2
005ABE2BC  stur     w8, [x21, #-0x2c]
005ABE2C0  ldr      x21, [x19, #0x40]
005ABE2C4  cbz      x21, #0x5abe47c
005ABE2C8  ldr      x8, [x21]
005ABE2CC  ldr      x1, [x22]
005ABE2D0  ldrh     w9, [x8, #0x12e]
005ABE2D4  cbz      x9, #0x5abe2f8
005ABE2D8  ldr      x10, [x8, #0xb0]
005ABE2DC  add      x10, x10, #8
005ABE2E0  ldur     x11, [x10, #-8]
005ABE2E4  cmp      x11, x1
005ABE2E8  b.eq     #0x5abe308
005ABE2EC  subs     x9, x9, #1
005ABE2F0  add      x10, x10, #0x10
005ABE2F4  b.ne     #0x5abe2e0
005ABE2F8  mov      x0, x21
005ABE2FC  mov      w2, wzr
005ABE300  bl       #0x3a7e710 ; 
005ABE304  b        #0x5abe314 ; 
005ABE308  ldrsw    x9, [x10]
005ABE30C  add      x8, x8, x9, lsl #4
005ABE310  add      x0, x8, #0x138
005ABE314  ldp      x8, x1, [x0]
005ABE318  mov      x0, x21
005ABE31C  blr      x8
005ABE320  tbz      w0, #0, #0x5abe450
005ABE324  ldr      x21, [x19, #0x40]
005ABE328  cbz      x21, #0x5abe47c
005ABE32C  ldr      x8, [x20, #0x20]
005ABE330  ldr      x8, [x8, #0xc0]
005ABE334  ldr      x1, [x8, #0x40]
005ABE338  ldrb     w8, [x1, #0x135]
005ABE33C  tbnz     w8, #0, #0x5abe34c
005ABE340  mov      x0, x1
005ABE344  bl       #0x3a7e60c ; 
005ABE348  mov      x1, x0
005ABE34C  ldr      x8, [x21]
005ABE350  ldrh     w9, [x8, #0x12e]
005ABE354  cbz      x9, #0x5abe378
005ABE358  ldr      x10, [x8, #0xb0]
005ABE35C  add      x10, x10, #8
005ABE360  ldur     x11, [x10, #-8]
005ABE364  cmp      x11, x1
005ABE368  b.eq     #0x5abe388
005ABE36C  subs     x9, x9, #1
005ABE370  add      x10, x10, #0x10
005ABE374  b.ne     #0x5abe360
005ABE378  mov      x0, x21
005ABE37C  mov      w2, wzr
005ABE380  bl       #0x3a7e710 ; 
005ABE384  b        #0x5abe394 ; 
005ABE388  ldrsw    x9, [x10]
005ABE38C  add      x8, x8, x9, lsl #4
005ABE390  add      x0, x8, #0x138
005ABE394  ldp      x9, x1, [x0]
005ABE398  add      x8, sp, #0x80
005ABE39C  mov      x0, x21
005ABE3A0  blr      x9
005ABE3A4  ldp      q0, q1, [sp, #0x80]
005ABE3A8  ldr      q2, [sp, #0xa0]
005ABE3AC  ldr      x8, [sp, #0xb0]
005ABE3B0  stp      q0, q1, [sp, #0x40]
005ABE3B4  str      q2, [sp, #0x60]
005ABE3B8  str      x8, [sp, #0x70]
005ABE3BC  ldr      x8, [x19, #0x30]
005ABE3C0  cbz      x8, #0x5abe3f4
005ABE3C4  ldp      q0, q1, [sp, #0x40]
005ABE3C8  ldr      q2, [sp, #0x60]
005ABE3CC  ldr      x10, [sp, #0x70]
005ABE3D0  ldr      x9, [x8, #0x18]
005ABE3D4  ldr      x0, [x8, #0x40]
005ABE3D8  stp      q0, q1, [sp, #0x80]
005ABE3DC  str      q2, [sp, #0xa0]
005ABE3E0  str      x10, [sp, #0xb0]
005ABE3E4  ldr      x2, [x8, #0x28]
005ABE3E8  add      x1, sp, #0x80
005ABE3EC  blr      x9
005ABE3F0  tbz      w0, #0, #0x5abe2c0
005ABE3F4  ldr      x8, [x19, #0x38]
005ABE3F8  ldp      q0, q1, [sp, #0x40]
005ABE3FC  ldr      q2, [sp, #0x60]
005ABE400  ldr      x9, [sp, #0x70]
005ABE404  stp      q0, q1, [sp]
005ABE408  str      q2, [sp, #0x20]
005ABE40C  str      x9, [sp, #0x30]
005ABE410  cbz      x8, #0x5abe47c
005ABE414  ldp      q0, q1, [sp]
005ABE418  ldr      q2, [sp, #0x20]
005ABE41C  ldr      x10, [sp, #0x30]
005ABE420  ldr      x9, [x8, #0x18]
005ABE424  ldr      x0, [x8, #0x40]
005ABE428  stp      q0, q1, [sp, #0x80]
005ABE42C  str      q2, [sp, #0xa0]
005ABE430  str      x10, [sp, #0xb0]
005ABE434  ldr      x2, [x8, #0x28]
005ABE438  add      x1, sp, #0x80
005ABE43C  blr      x9
005ABE440  stp      s0, s1, [x19, #0x18]
005ABE444  str      s2, [x19, #0x20]
005ABE448  mov      w0, #1
005ABE44C  b        #0x5abe468 ; 
005ABE450  cbz      x19, #0x5abe47c
005ABE454  ldr      x8, [x19]
005ABE458  mov      x0, x19
005ABE45C  ldp      x9, x1, [x8, #0x1f8]
005ABE460  blr      x9
005ABE464  mov      w0, wzr
005ABE468  ldp      x20, x19, [sp, #0xe0]
005ABE46C  ldp      x22, x21, [sp, #0xd0]
005ABE470  ldr      x30, [sp, #0xc0]
005ABE474  add      sp, sp, #0xf0
005ABE478  ret      
005ABE47C  bl       #0x382bfb8 ; 

; System.Linq.Enumerable.WhereSelectEnumerableIterator<WeightRandomData, Vector3>$$Where
; RVA 0x5ABE480; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005ABE480  stp      x30, x21, [sp, #-0x20]!
005ABE484  stp      x20, x19, [sp, #0x10]
005ABE488  ldr      x8, [x2, #0x20]
005ABE48C  mov      x20, x2
005ABE490  mov      x19, x1
005ABE494  mov      x21, x0
005ABE498  ldr      x8, [x8, #0xc0]
005ABE49C  ldr      x8, [x8, #0x88]
005ABE4A0  ldrb     w9, [x8, #0x135]
005ABE4A4  tbnz     w9, #0, #0x5abe4b4
005ABE4A8  mov      x0, x8
005ABE4AC  bl       #0x3a7e60c ; 
005ABE4B0  mov      x8, x0
005ABE4B4  mov      x0, x8
005ABE4B8  bl       #0x382bfa0 ; 
005ABE4BC  ldr      x8, [x20, #0x20]
005ABE4C0  mov      x1, x21
005ABE4C4  mov      x2, x19
005ABE4C8  mov      x20, x0
005ABE4CC  ldr      x8, [x8, #0xc0]
005ABE4D0  ldr      x3, [x8, #0x90]
005ABE4D4  bl       #0x59cbf7c ; System.Linq.Enumerable.WhereEnumerableIterator<Vector3>$$.ctor
005ABE4D8  mov      x0, x20
005ABE4DC  ldp      x20, x19, [sp, #0x10]
005ABE4E0  ldp      x30, x21, [sp], #0x20
005ABE4E4  ret      

