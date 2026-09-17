; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, int, object>$$.ctor
; RVA 0x5468BB4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468BB4  mov      x1, xzr
005468BB8  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, int, object>$$<CombineSelectors>b__0
; RVA 0x5468BBC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468BBC  sub      sp, sp, #0x90
005468BC0  stp      x30, x19, [sp, #0x80]
005468BC4  ldp      q0, q1, [x1]
005468BC8  ldr      x9, [x1, #0x30]
005468BCC  ldr      q2, [x1, #0x20]
005468BD0  ldp      x19, x8, [x0, #0x10]
005468BD4  str      q0, [sp]
005468BD8  str      x9, [sp, #0x30]
005468BDC  stp      q1, q2, [sp, #0x10]
005468BE0  cbz      x8, #0x5468c34
005468BE4  ldp      q0, q1, [sp]
005468BE8  ldr      q2, [sp, #0x20]
005468BEC  ldr      x10, [sp, #0x30]
005468BF0  ldr      x9, [x8, #0x18]
005468BF4  ldr      x0, [x8, #0x40]
005468BF8  stp      q0, q1, [sp, #0x40]
005468BFC  str      q2, [sp, #0x60]
005468C00  str      x10, [sp, #0x70]
005468C04  ldr      x2, [x8, #0x28]
005468C08  add      x1, sp, #0x40
005468C0C  blr      x9
005468C10  cbz      x19, #0x5468c34
005468C14  mov      w1, w0
005468C18  ldr      x8, [x19, #0x18]
005468C1C  ldr      x0, [x19, #0x40]
005468C20  ldr      x2, [x19, #0x28]
005468C24  blr      x8
005468C28  ldp      x30, x19, [sp, #0x80]
005468C2C  add      sp, sp, #0x90
005468C30  ret      
005468C34  bl       #0x382bfb8 ; 

