; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalRuneData>$$.ctor
; RVA 0x546909C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00546909C  mov      x1, xzr
0054690A0  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalRuneData>$$<CombineSelectors>b__0
; RVA 0x54690A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0054690A4  sub      sp, sp, #0x90
0054690A8  stp      x30, x19, [sp, #0x80]
0054690AC  ldp      q0, q1, [x1]
0054690B0  ldr      x9, [x1, #0x30]
0054690B4  ldr      q2, [x1, #0x20]
0054690B8  ldp      x19, x8, [x0, #0x10]
0054690BC  str      q0, [sp]
0054690C0  str      x9, [sp, #0x30]
0054690C4  stp      q1, q2, [sp, #0x10]
0054690C8  cbz      x8, #0x5469120
0054690CC  ldp      q0, q1, [sp]
0054690D0  ldr      q2, [sp, #0x20]
0054690D4  ldr      x10, [sp, #0x30]
0054690D8  ldr      x9, [x8, #0x18]
0054690DC  ldr      x0, [x8, #0x40]
0054690E0  stp      q0, q1, [sp, #0x40]
0054690E4  str      q2, [sp, #0x60]
0054690E8  str      x10, [sp, #0x70]
0054690EC  ldr      x2, [x8, #0x28]
0054690F0  add      x1, sp, #0x40
0054690F4  blr      x9
0054690F8  cbz      x19, #0x5469120
0054690FC  mov      x1, x0
005469100  ldr      x8, [x19, #0x18]
005469104  ldr      x0, [x19, #0x40]
005469108  ldr      x2, [x19, #0x28]
00546910C  blr      x8
005469110  ldp      x30, x19, [sp, #0x80]
005469114  and      x0, x0, #0xffffffff
005469118  add      sp, sp, #0x90
00546911C  ret      
005469120  bl       #0x382bfb8 ; 

