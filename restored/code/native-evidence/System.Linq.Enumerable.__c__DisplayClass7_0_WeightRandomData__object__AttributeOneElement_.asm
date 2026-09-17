; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, AttributeOneElement>$$.ctor
; RVA 0x5468CBC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468CBC  mov      x1, xzr
005468CC0  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, AttributeOneElement>$$<CombineSelectors>b__0
; RVA 0x5468CC4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468CC4  sub      sp, sp, #0xa0
005468CC8  str      x30, [sp, #0x80]
005468CCC  stp      x20, x19, [sp, #0x90]
005468CD0  mov      x19, x8
005468CD4  ldp      q0, q1, [x1]
005468CD8  ldr      x9, [x1, #0x30]
005468CDC  ldr      q2, [x1, #0x20]
005468CE0  ldp      x20, x8, [x0, #0x10]
005468CE4  str      q0, [sp]
005468CE8  str      x9, [sp, #0x30]
005468CEC  stp      q1, q2, [sp, #0x10]
005468CF0  cbz      x8, #0x5468d5c
005468CF4  ldp      q0, q1, [sp]
005468CF8  ldr      q2, [sp, #0x20]
005468CFC  ldr      x10, [sp, #0x30]
005468D00  ldr      x9, [x8, #0x18]
005468D04  ldr      x0, [x8, #0x40]
005468D08  stp      q0, q1, [sp, #0x40]
005468D0C  str      q2, [sp, #0x60]
005468D10  str      x10, [sp, #0x70]
005468D14  ldr      x2, [x8, #0x28]
005468D18  add      x1, sp, #0x40
005468D1C  blr      x9
005468D20  cbz      x20, #0x5468d5c
005468D24  mov      x1, x0
005468D28  ldr      x9, [x20, #0x18]
005468D2C  ldr      x0, [x20, #0x40]
005468D30  ldr      x2, [x20, #0x28]
005468D34  add      x8, sp, #0x40
005468D38  blr      x9
005468D3C  ldr      x8, [sp, #0x50]
005468D40  ldr      q0, [sp, #0x40]
005468D44  ldr      x30, [sp, #0x80]
005468D48  str      x8, [x19, #0x10]
005468D4C  str      q0, [x19]
005468D50  ldp      x20, x19, [sp, #0x90]
005468D54  add      sp, sp, #0xa0
005468D58  ret      
005468D5C  bl       #0x382bfb8 ; 

