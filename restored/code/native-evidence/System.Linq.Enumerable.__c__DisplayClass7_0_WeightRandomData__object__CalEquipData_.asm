; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalEquipData>$$.ctor
; RVA 0x5468F74; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468F74  mov      x1, xzr
005468F78  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalEquipData>$$<CombineSelectors>b__0
; RVA 0x5468F7C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468F7C  sub      sp, sp, #0x90
005468F80  stp      x30, x19, [sp, #0x80]
005468F84  ldp      q0, q1, [x1]
005468F88  ldr      x9, [x1, #0x30]
005468F8C  ldr      q2, [x1, #0x20]
005468F90  ldp      x19, x8, [x0, #0x10]
005468F94  str      q0, [sp]
005468F98  str      x9, [sp, #0x30]
005468F9C  stp      q1, q2, [sp, #0x10]
005468FA0  cbz      x8, #0x5468ff4
005468FA4  ldp      q0, q1, [sp]
005468FA8  ldr      q2, [sp, #0x20]
005468FAC  ldr      x10, [sp, #0x30]
005468FB0  ldr      x9, [x8, #0x18]
005468FB4  ldr      x0, [x8, #0x40]
005468FB8  stp      q0, q1, [sp, #0x40]
005468FBC  str      q2, [sp, #0x60]
005468FC0  str      x10, [sp, #0x70]
005468FC4  ldr      x2, [x8, #0x28]
005468FC8  add      x1, sp, #0x40
005468FCC  blr      x9
005468FD0  cbz      x19, #0x5468ff4
005468FD4  mov      x1, x0
005468FD8  ldr      x8, [x19, #0x18]
005468FDC  ldr      x0, [x19, #0x40]
005468FE0  ldr      x2, [x19, #0x28]
005468FE4  blr      x8
005468FE8  ldp      x30, x19, [sp, #0x80]
005468FEC  add      sp, sp, #0x90
005468FF0  ret      
005468FF4  bl       #0x382bfb8 ; 

