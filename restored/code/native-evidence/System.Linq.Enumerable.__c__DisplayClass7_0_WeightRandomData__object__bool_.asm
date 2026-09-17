; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, bool>$$.ctor
; RVA 0x5468D60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468D60  mov      x1, xzr
005468D64  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, bool>$$<CombineSelectors>b__0
; RVA 0x5468D68; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468D68  sub      sp, sp, #0x90
005468D6C  stp      x30, x19, [sp, #0x80]
005468D70  ldp      q0, q1, [x1]
005468D74  ldr      x9, [x1, #0x30]
005468D78  ldr      q2, [x1, #0x20]
005468D7C  ldp      x19, x8, [x0, #0x10]
005468D80  str      q0, [sp]
005468D84  str      x9, [sp, #0x30]
005468D88  stp      q1, q2, [sp, #0x10]
005468D8C  cbz      x8, #0x5468de4
005468D90  ldp      q0, q1, [sp]
005468D94  ldr      q2, [sp, #0x20]
005468D98  ldr      x10, [sp, #0x30]
005468D9C  ldr      x9, [x8, #0x18]
005468DA0  ldr      x0, [x8, #0x40]
005468DA4  stp      q0, q1, [sp, #0x40]
005468DA8  str      q2, [sp, #0x60]
005468DAC  str      x10, [sp, #0x70]
005468DB0  ldr      x2, [x8, #0x28]
005468DB4  add      x1, sp, #0x40
005468DB8  blr      x9
005468DBC  cbz      x19, #0x5468de4
005468DC0  mov      x1, x0
005468DC4  ldr      x8, [x19, #0x18]
005468DC8  ldr      x0, [x19, #0x40]
005468DCC  ldr      x2, [x19, #0x28]
005468DD0  blr      x8
005468DD4  ldp      x30, x19, [sp, #0x80]
005468DD8  and      w0, w0, #1
005468DDC  add      sp, sp, #0x90
005468DE0  ret      
005468DE4  bl       #0x382bfb8 ; 

