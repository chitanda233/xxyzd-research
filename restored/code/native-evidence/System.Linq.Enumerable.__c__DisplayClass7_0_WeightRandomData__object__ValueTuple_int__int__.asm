; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, ValueTuple<int, int>>$$.ctor
; RVA 0x5468C38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468C38  mov      x1, xzr
005468C3C  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, ValueTuple<int, int>>$$<CombineSelectors>b__0
; RVA 0x5468C40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468C40  sub      sp, sp, #0x90
005468C44  stp      x30, x19, [sp, #0x80]
005468C48  ldp      q0, q1, [x1]
005468C4C  ldr      x9, [x1, #0x30]
005468C50  ldr      q2, [x1, #0x20]
005468C54  ldp      x19, x8, [x0, #0x10]
005468C58  str      q0, [sp]
005468C5C  str      x9, [sp, #0x30]
005468C60  stp      q1, q2, [sp, #0x10]
005468C64  cbz      x8, #0x5468cb8
005468C68  ldp      q0, q1, [sp]
005468C6C  ldr      q2, [sp, #0x20]
005468C70  ldr      x10, [sp, #0x30]
005468C74  ldr      x9, [x8, #0x18]
005468C78  ldr      x0, [x8, #0x40]
005468C7C  stp      q0, q1, [sp, #0x40]
005468C80  str      q2, [sp, #0x60]
005468C84  str      x10, [sp, #0x70]
005468C88  ldr      x2, [x8, #0x28]
005468C8C  add      x1, sp, #0x40
005468C90  blr      x9
005468C94  cbz      x19, #0x5468cb8
005468C98  mov      x1, x0
005468C9C  ldr      x8, [x19, #0x18]
005468CA0  ldr      x0, [x19, #0x40]
005468CA4  ldr      x2, [x19, #0x28]
005468CA8  blr      x8
005468CAC  ldp      x30, x19, [sp, #0x80]
005468CB0  add      sp, sp, #0x90
005468CB4  ret      
005468CB8  bl       #0x382bfb8 ; 

