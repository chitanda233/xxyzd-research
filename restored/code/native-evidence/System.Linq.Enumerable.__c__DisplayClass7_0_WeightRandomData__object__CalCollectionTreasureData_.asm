; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalCollectionTreasureData>$$.ctor
; RVA 0x5468EF0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468EF0  mov      x1, xzr
005468EF4  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalCollectionTreasureData>$$<CombineSelectors>b__0
; RVA 0x5468EF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468EF8  sub      sp, sp, #0x90
005468EFC  stp      x30, x19, [sp, #0x80]
005468F00  ldp      q0, q1, [x1]
005468F04  ldr      x9, [x1, #0x30]
005468F08  ldr      q2, [x1, #0x20]
005468F0C  ldp      x19, x8, [x0, #0x10]
005468F10  str      q0, [sp]
005468F14  str      x9, [sp, #0x30]
005468F18  stp      q1, q2, [sp, #0x10]
005468F1C  cbz      x8, #0x5468f70
005468F20  ldp      q0, q1, [sp]
005468F24  ldr      q2, [sp, #0x20]
005468F28  ldr      x10, [sp, #0x30]
005468F2C  ldr      x9, [x8, #0x18]
005468F30  ldr      x0, [x8, #0x40]
005468F34  stp      q0, q1, [sp, #0x40]
005468F38  str      q2, [sp, #0x60]
005468F3C  str      x10, [sp, #0x70]
005468F40  ldr      x2, [x8, #0x28]
005468F44  add      x1, sp, #0x40
005468F48  blr      x9
005468F4C  cbz      x19, #0x5468f70
005468F50  mov      x1, x0
005468F54  ldr      x8, [x19, #0x18]
005468F58  ldr      x0, [x19, #0x40]
005468F5C  ldr      x2, [x19, #0x28]
005468F60  blr      x8
005468F64  ldp      x30, x19, [sp, #0x80]
005468F68  add      sp, sp, #0x90
005468F6C  ret      
005468F70  bl       #0x382bfb8 ; 

