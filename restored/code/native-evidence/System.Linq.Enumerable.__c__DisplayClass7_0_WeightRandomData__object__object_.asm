; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, object>$$.ctor
; RVA 0x5469334; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005469334  mov      x1, xzr
005469338  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, object>$$<CombineSelectors>b__0
; RVA 0x546933C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00546933C  sub      sp, sp, #0x90
005469340  stp      x30, x19, [sp, #0x80]
005469344  ldp      q0, q1, [x1]
005469348  ldr      x9, [x1, #0x30]
00546934C  ldr      q2, [x1, #0x20]
005469350  ldp      x19, x8, [x0, #0x10]
005469354  str      q0, [sp]
005469358  str      x9, [sp, #0x30]
00546935C  stp      q1, q2, [sp, #0x10]
005469360  cbz      x8, #0x54693b4
005469364  ldp      q0, q1, [sp]
005469368  ldr      q2, [sp, #0x20]
00546936C  ldr      x10, [sp, #0x30]
005469370  ldr      x9, [x8, #0x18]
005469374  ldr      x0, [x8, #0x40]
005469378  stp      q0, q1, [sp, #0x40]
00546937C  str      q2, [sp, #0x60]
005469380  str      x10, [sp, #0x70]
005469384  ldr      x2, [x8, #0x28]
005469388  add      x1, sp, #0x40
00546938C  blr      x9
005469390  cbz      x19, #0x54693b4
005469394  mov      x1, x0
005469398  ldr      x8, [x19, #0x18]
00546939C  ldr      x0, [x19, #0x40]
0054693A0  ldr      x2, [x19, #0x28]
0054693A4  blr      x8
0054693A8  ldp      x30, x19, [sp, #0x80]
0054693AC  add      sp, sp, #0x90
0054693B0  ret      
0054693B4  bl       #0x382bfb8 ; 

