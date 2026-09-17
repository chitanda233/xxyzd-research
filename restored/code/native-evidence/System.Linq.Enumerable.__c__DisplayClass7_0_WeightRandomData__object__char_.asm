; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, char>$$.ctor
; RVA 0x5469124; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005469124  mov      x1, xzr
005469128  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, char>$$<CombineSelectors>b__0
; RVA 0x546912C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00546912C  sub      sp, sp, #0x90
005469130  stp      x30, x19, [sp, #0x80]
005469134  ldp      q0, q1, [x1]
005469138  ldr      x9, [x1, #0x30]
00546913C  ldr      q2, [x1, #0x20]
005469140  ldp      x19, x8, [x0, #0x10]
005469144  str      q0, [sp]
005469148  str      x9, [sp, #0x30]
00546914C  stp      q1, q2, [sp, #0x10]
005469150  cbz      x8, #0x54691a4
005469154  ldp      q0, q1, [sp]
005469158  ldr      q2, [sp, #0x20]
00546915C  ldr      x10, [sp, #0x30]
005469160  ldr      x9, [x8, #0x18]
005469164  ldr      x0, [x8, #0x40]
005469168  stp      q0, q1, [sp, #0x40]
00546916C  str      q2, [sp, #0x60]
005469170  str      x10, [sp, #0x70]
005469174  ldr      x2, [x8, #0x28]
005469178  add      x1, sp, #0x40
00546917C  blr      x9
005469180  cbz      x19, #0x54691a4
005469184  mov      x1, x0
005469188  ldr      x8, [x19, #0x18]
00546918C  ldr      x0, [x19, #0x40]
005469190  ldr      x2, [x19, #0x28]
005469194  blr      x8
005469198  ldp      x30, x19, [sp, #0x80]
00546919C  add      sp, sp, #0x90
0054691A0  ret      
0054691A4  bl       #0x382bfb8 ; 

