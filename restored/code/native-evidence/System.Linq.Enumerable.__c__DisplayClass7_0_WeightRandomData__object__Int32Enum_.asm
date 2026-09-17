; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, Int32Enum>$$.ctor
; RVA 0x546922C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00546922C  mov      x1, xzr
005469230  b        #0x7c335dc ; System.Object$$.ctor

; System.Linq.Enumerable.<>c__DisplayClass7_0<WeightRandomData, object, Int32Enum>$$<CombineSelectors>b__0
; RVA 0x5469234; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005469234  sub      sp, sp, #0x90
005469238  stp      x30, x19, [sp, #0x80]
00546923C  ldp      q0, q1, [x1]
005469240  ldr      x9, [x1, #0x30]
005469244  ldr      q2, [x1, #0x20]
005469248  ldp      x19, x8, [x0, #0x10]
00546924C  str      q0, [sp]
005469250  str      x9, [sp, #0x30]
005469254  stp      q1, q2, [sp, #0x10]
005469258  cbz      x8, #0x54692ac
00546925C  ldp      q0, q1, [sp]
005469260  ldr      q2, [sp, #0x20]
005469264  ldr      x10, [sp, #0x30]
005469268  ldr      x9, [x8, #0x18]
00546926C  ldr      x0, [x8, #0x40]
005469270  stp      q0, q1, [sp, #0x40]
005469274  str      q2, [sp, #0x60]
005469278  str      x10, [sp, #0x70]
00546927C  ldr      x2, [x8, #0x28]
005469280  add      x1, sp, #0x40
005469284  blr      x9
005469288  cbz      x19, #0x54692ac
00546928C  mov      x1, x0
005469290  ldr      x8, [x19, #0x18]
005469294  ldr      x0, [x19, #0x40]
005469298  ldr      x2, [x19, #0x28]
00546929C  blr      x8
0054692A0  ldp      x30, x19, [sp, #0x80]
0054692A4  add      sp, sp, #0x90
0054692A8  ret      
0054692AC  bl       #0x382bfb8 ; 

