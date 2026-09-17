; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalRoleData>$$.ctor
; RVA 0x5468FF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005468FF8  mov      x1, xzr
005468FFC  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, CalRoleData>$$<CombineSelectors>b__0
; RVA 0x5469000; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005469000  sub      sp, sp, #0xa0
005469004  str      x30, [sp, #0x80]
005469008  stp      x20, x19, [sp, #0x90]
00546900C  mov      x19, x8
005469010  ldp      q0, q1, [x1]
005469014  ldr      x9, [x1, #0x30]
005469018  ldr      q2, [x1, #0x20]
00546901C  ldp      x20, x8, [x0, #0x10]
005469020  str      q0, [sp]
005469024  str      x9, [sp, #0x30]
005469028  stp      q1, q2, [sp, #0x10]
00546902C  cbz      x8, #0x5469098
005469030  ldp      q0, q1, [sp]
005469034  ldr      q2, [sp, #0x20]
005469038  ldr      x10, [sp, #0x30]
00546903C  ldr      x9, [x8, #0x18]
005469040  ldr      x0, [x8, #0x40]
005469044  stp      q0, q1, [sp, #0x40]
005469048  str      q2, [sp, #0x60]
00546904C  str      x10, [sp, #0x70]
005469050  ldr      x2, [x8, #0x28]
005469054  add      x1, sp, #0x40
005469058  blr      x9
00546905C  cbz      x20, #0x5469098
005469060  mov      x1, x0
005469064  ldr      x9, [x20, #0x18]
005469068  ldr      x0, [x20, #0x40]
00546906C  ldr      x2, [x20, #0x28]
005469070  add      x8, sp, #0x40
005469074  blr      x9
005469078  ldp      q1, q0, [sp, #0x50]
00546907C  ldr      q2, [sp, #0x40]
005469080  ldr      x30, [sp, #0x80]
005469084  stp      q1, q0, [x19, #0x10]
005469088  str      q2, [x19]
00546908C  ldp      x20, x19, [sp, #0x90]
005469090  add      sp, sp, #0xa0
005469094  ret      
005469098  bl       #0x382bfb8 ; 

