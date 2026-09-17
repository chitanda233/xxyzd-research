; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, long>$$.ctor
; RVA 0x54692B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0054692B0  mov      x1, xzr
0054692B4  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, long>$$<CombineSelectors>b__0
; RVA 0x54692B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0054692B8  sub      sp, sp, #0x90
0054692BC  stp      x30, x19, [sp, #0x80]
0054692C0  ldp      q0, q1, [x1]
0054692C4  ldr      x9, [x1, #0x30]
0054692C8  ldr      q2, [x1, #0x20]
0054692CC  ldp      x19, x8, [x0, #0x10]
0054692D0  str      q0, [sp]
0054692D4  str      x9, [sp, #0x30]
0054692D8  stp      q1, q2, [sp, #0x10]
0054692DC  cbz      x8, #0x5469330
0054692E0  ldp      q0, q1, [sp]
0054692E4  ldr      q2, [sp, #0x20]
0054692E8  ldr      x10, [sp, #0x30]
0054692EC  ldr      x9, [x8, #0x18]
0054692F0  ldr      x0, [x8, #0x40]
0054692F4  stp      q0, q1, [sp, #0x40]
0054692F8  str      q2, [sp, #0x60]
0054692FC  str      x10, [sp, #0x70]
005469300  ldr      x2, [x8, #0x28]
005469304  add      x1, sp, #0x40
005469308  blr      x9
00546930C  cbz      x19, #0x5469330
005469310  mov      x1, x0
005469314  ldr      x8, [x19, #0x18]
005469318  ldr      x0, [x19, #0x40]
00546931C  ldr      x2, [x19, #0x28]
005469320  blr      x8
005469324  ldp      x30, x19, [sp, #0x80]
005469328  add      sp, sp, #0x90
00546932C  ret      
005469330  bl       #0x382bfb8 ; 

