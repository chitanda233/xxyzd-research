; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, int, Int32Enum>$$.ctor
; RVA 0x5468B30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468B30  mov      x1, xzr
005468B34  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, int, Int32Enum>$$<CombineSelectors>b__0
; RVA 0x5468B38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468B38  sub      sp, sp, #0x90
005468B3C  stp      x30, x19, [sp, #0x80]
005468B40  ldp      q0, q1, [x1]
005468B44  ldr      x9, [x1, #0x30]
005468B48  ldr      q2, [x1, #0x20]
005468B4C  ldp      x19, x8, [x0, #0x10]
005468B50  str      q0, [sp]
005468B54  str      x9, [sp, #0x30]
005468B58  stp      q1, q2, [sp, #0x10]
005468B5C  cbz      x8, #0x5468bb0
005468B60  ldp      q0, q1, [sp]
005468B64  ldr      q2, [sp, #0x20]
005468B68  ldr      x10, [sp, #0x30]
005468B6C  ldr      x9, [x8, #0x18]
005468B70  ldr      x0, [x8, #0x40]
005468B74  stp      q0, q1, [sp, #0x40]
005468B78  str      q2, [sp, #0x60]
005468B7C  str      x10, [sp, #0x70]
005468B80  ldr      x2, [x8, #0x28]
005468B84  add      x1, sp, #0x40
005468B88  blr      x9
005468B8C  cbz      x19, #0x5468bb0
005468B90  mov      w1, w0
005468B94  ldr      x8, [x19, #0x18]
005468B98  ldr      x0, [x19, #0x40]
005468B9C  ldr      x2, [x19, #0x28]
005468BA0  blr      x8
005468BA4  ldp      x30, x19, [sp, #0x80]
005468BA8  add      sp, sp, #0x90
005468BAC  ret      
005468BB0  bl       #0x382bfb8 ; 

