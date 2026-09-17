; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, int>$$.ctor
; RVA 0x54691A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0054691A8  mov      x1, xzr
0054691AC  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, int>$$<CombineSelectors>b__0
; RVA 0x54691B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0054691B0  sub      sp, sp, #0x90
0054691B4  stp      x30, x19, [sp, #0x80]
0054691B8  ldp      q0, q1, [x1]
0054691BC  ldr      x9, [x1, #0x30]
0054691C0  ldr      q2, [x1, #0x20]
0054691C4  ldp      x19, x8, [x0, #0x10]
0054691C8  str      q0, [sp]
0054691CC  str      x9, [sp, #0x30]
0054691D0  stp      q1, q2, [sp, #0x10]
0054691D4  cbz      x8, #0x5469228
0054691D8  ldp      q0, q1, [sp]
0054691DC  ldr      q2, [sp, #0x20]
0054691E0  ldr      x10, [sp, #0x30]
0054691E4  ldr      x9, [x8, #0x18]
0054691E8  ldr      x0, [x8, #0x40]
0054691EC  stp      q0, q1, [sp, #0x40]
0054691F0  str      q2, [sp, #0x60]
0054691F4  str      x10, [sp, #0x70]
0054691F8  ldr      x2, [x8, #0x28]
0054691FC  add      x1, sp, #0x40
005469200  blr      x9
005469204  cbz      x19, #0x5469228
005469208  mov      x1, x0
00546920C  ldr      x8, [x19, #0x18]
005469210  ldr      x0, [x19, #0x40]
005469214  ldr      x2, [x19, #0x28]
005469218  blr      x8
00546921C  ldp      x30, x19, [sp, #0x80]
005469220  add      sp, sp, #0x90
005469224  ret      
005469228  bl       #0x382bfb8 ; 

