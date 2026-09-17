; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, int, int>$$.ctor
; RVA 0x5468AAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468AAC  mov      x1, xzr
005468AB0  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, int, int>$$<CombineSelectors>b__0
; RVA 0x5468AB4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468AB4  sub      sp, sp, #0x90
005468AB8  stp      x30, x19, [sp, #0x80]
005468ABC  ldp      q0, q1, [x1]
005468AC0  ldr      x9, [x1, #0x30]
005468AC4  ldr      q2, [x1, #0x20]
005468AC8  ldp      x19, x8, [x0, #0x10]
005468ACC  str      q0, [sp]
005468AD0  str      x9, [sp, #0x30]
005468AD4  stp      q1, q2, [sp, #0x10]
005468AD8  cbz      x8, #0x5468b2c
005468ADC  ldp      q0, q1, [sp]
005468AE0  ldr      q2, [sp, #0x20]
005468AE4  ldr      x10, [sp, #0x30]
005468AE8  ldr      x9, [x8, #0x18]
005468AEC  ldr      x0, [x8, #0x40]
005468AF0  stp      q0, q1, [sp, #0x40]
005468AF4  str      q2, [sp, #0x60]
005468AF8  str      x10, [sp, #0x70]
005468AFC  ldr      x2, [x8, #0x28]
005468B00  add      x1, sp, #0x40
005468B04  blr      x9
005468B08  cbz      x19, #0x5468b2c
005468B0C  mov      w1, w0
005468B10  ldr      x8, [x19, #0x18]
005468B14  ldr      x0, [x19, #0x40]
005468B18  ldr      x2, [x19, #0x28]
005468B1C  blr      x8
005468B20  ldp      x30, x19, [sp, #0x80]
005468B24  add      sp, sp, #0x90
005468B28  ret      
005468B2C  bl       #0x382bfb8 ; 

