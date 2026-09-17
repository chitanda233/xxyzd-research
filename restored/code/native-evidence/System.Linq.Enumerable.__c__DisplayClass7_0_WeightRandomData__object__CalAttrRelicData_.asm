; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalAttrRelicData>$$.ctor
; RVA 0x5468E6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468E6C  mov      x1, xzr
005468E70  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalAttrRelicData>$$<CombineSelectors>b__0
; RVA 0x5468E74; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468E74  sub      sp, sp, #0x90
005468E78  stp      x30, x19, [sp, #0x80]
005468E7C  ldp      q0, q1, [x1]
005468E80  ldr      x9, [x1, #0x30]
005468E84  ldr      q2, [x1, #0x20]
005468E88  ldp      x19, x8, [x0, #0x10]
005468E8C  str      q0, [sp]
005468E90  str      x9, [sp, #0x30]
005468E94  stp      q1, q2, [sp, #0x10]
005468E98  cbz      x8, #0x5468eec
005468E9C  ldp      q0, q1, [sp]
005468EA0  ldr      q2, [sp, #0x20]
005468EA4  ldr      x10, [sp, #0x30]
005468EA8  ldr      x9, [x8, #0x18]
005468EAC  ldr      x0, [x8, #0x40]
005468EB0  stp      q0, q1, [sp, #0x40]
005468EB4  str      q2, [sp, #0x60]
005468EB8  str      x10, [sp, #0x70]
005468EBC  ldr      x2, [x8, #0x28]
005468EC0  add      x1, sp, #0x40
005468EC4  blr      x9
005468EC8  cbz      x19, #0x5468eec
005468ECC  mov      x1, x0
005468ED0  ldr      x8, [x19, #0x18]
005468ED4  ldr      x0, [x19, #0x40]
005468ED8  ldr      x2, [x19, #0x28]
005468EDC  blr      x8
005468EE0  ldp      x30, x19, [sp, #0x80]
005468EE4  add      sp, sp, #0x90
005468EE8  ret      
005468EEC  bl       #0x382bfb8 ; 

