; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, Vector3>$$.ctor
; RVA 0x54693B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0054693B8  mov      x1, xzr
0054693BC  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, Vector3>$$<CombineSelectors>b__0
; RVA 0x54693C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0054693C0  sub      sp, sp, #0x90
0054693C4  stp      x30, x19, [sp, #0x80]
0054693C8  ldp      q0, q1, [x1]
0054693CC  ldr      x9, [x1, #0x30]
0054693D0  ldr      q2, [x1, #0x20]
0054693D4  ldp      x19, x8, [x0, #0x10]
0054693D8  str      q0, [sp]
0054693DC  str      x9, [sp, #0x30]
0054693E0  stp      q1, q2, [sp, #0x10]
0054693E4  cbz      x8, #0x5469438
0054693E8  ldp      q0, q1, [sp]
0054693EC  ldr      q2, [sp, #0x20]
0054693F0  ldr      x10, [sp, #0x30]
0054693F4  ldr      x9, [x8, #0x18]
0054693F8  ldr      x0, [x8, #0x40]
0054693FC  stp      q0, q1, [sp, #0x40]
005469400  str      q2, [sp, #0x60]
005469404  str      x10, [sp, #0x70]
005469408  ldr      x2, [x8, #0x28]
00546940C  add      x1, sp, #0x40
005469410  blr      x9
005469414  cbz      x19, #0x5469438
005469418  mov      x1, x0
00546941C  ldr      x8, [x19, #0x18]
005469420  ldr      x0, [x19, #0x40]
005469424  ldr      x2, [x19, #0x28]
005469428  blr      x8
00546942C  ldp      x30, x19, [sp, #0x80]
005469430  add      sp, sp, #0x90
005469434  ret      
005469438  bl       #0x382bfb8 ; 

