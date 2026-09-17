; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalAttrCardData>$$.ctor
; RVA 0x5468DE8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468DE8  mov      x1, xzr
005468DEC  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalAttrCardData>$$<CombineSelectors>b__0
; RVA 0x5468DF0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468DF0  sub      sp, sp, #0x90
005468DF4  stp      x30, x19, [sp, #0x80]
005468DF8  ldp      q0, q1, [x1]
005468DFC  ldr      x9, [x1, #0x30]
005468E00  ldr      q2, [x1, #0x20]
005468E04  ldp      x19, x8, [x0, #0x10]
005468E08  str      q0, [sp]
005468E0C  str      x9, [sp, #0x30]
005468E10  stp      q1, q2, [sp, #0x10]
005468E14  cbz      x8, #0x5468e68
005468E18  ldp      q0, q1, [sp]
005468E1C  ldr      q2, [sp, #0x20]
005468E20  ldr      x10, [sp, #0x30]
005468E24  ldr      x9, [x8, #0x18]
005468E28  ldr      x0, [x8, #0x40]
005468E2C  stp      q0, q1, [sp, #0x40]
005468E30  str      q2, [sp, #0x60]
005468E34  str      x10, [sp, #0x70]
005468E38  ldr      x2, [x8, #0x28]
005468E3C  add      x1, sp, #0x40
005468E40  blr      x9
005468E44  cbz      x19, #0x5468e68
005468E48  mov      x1, x0
005468E4C  ldr      x8, [x19, #0x18]
005468E50  ldr      x0, [x19, #0x40]
005468E54  ldr      x2, [x19, #0x28]
005468E58  blr      x8
005468E5C  ldp      x30, x19, [sp, #0x80]
005468E60  add      sp, sp, #0x90
005468E64  ret      
005468E68  bl       #0x382bfb8 ; 

