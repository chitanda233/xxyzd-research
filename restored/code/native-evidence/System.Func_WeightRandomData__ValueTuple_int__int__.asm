; System.Func<WeightRandomData, ValueTuple<int, int>>$$.ctor
; RVA 0x48DA3BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA3BC  str      x30, [sp, #-0x30]!
0048DA3C0  stp      x22, x21, [sp, #0x10]
0048DA3C4  stp      x20, x19, [sp, #0x20]
0048DA3C8  ldr      x8, [x2, #8]
0048DA3CC  mov      x19, x0
0048DA3D0  str      x2, [x0, #0x28]
0048DA3D4  mov      x21, x2
0048DA3D8  str      x8, [x0, #0x10]
0048DA3DC  str      x1, [x0, #0x20]!
0048DA3E0  mov      x20, x1
0048DA3E4  bl       #0x382bcb8 ; 
0048DA3E8  ldrb     w22, [x21, #0x52]
0048DA3EC  mov      x0, x21
0048DA3F0  str      x19, [x19, #0x40]
0048DA3F4  bl       #0x382be14 ; 
0048DA3F8  tbz      w0, #0, #0x48da414
0048DA3FC  cmp      w22, #1
0048DA400  b.ne     #0x48da418
0048DA404  adrp     x8, #0x3474000
0048DA408  add      x8, x8, #0x9c0
0048DA40C  str      x8, [x19, #0x18]
0048DA410  b        #0x48da428 ; 
0048DA414  cbz      x20, #0x48da444
0048DA418  ldr      x8, [x19, #0x10]
0048DA41C  ldr      x9, [x19, #0x20]
0048DA420  str      x8, [x19, #0x18]
0048DA424  str      x9, [x19, #0x40]
0048DA428  adrp     x8, #0x3474000
0048DA42C  add      x8, x8, #0x950
0048DA430  str      x8, [x19, #0x38]
0048DA434  ldp      x20, x19, [sp, #0x20]
0048DA438  ldp      x22, x21, [sp, #0x10]
0048DA43C  ldr      x30, [sp], #0x30
0048DA440  ret      
0048DA444  adrp     x1, #0x1a2d000
0048DA448  add      x1, x1, #0x4e9
0048DA44C  mov      x0, xzr
0048DA450  bl       #0x382bfd4 ; 
0048DA454  mov      x1, xzr
0048DA458  bl       #0x382be7c ; 

; System.Func<WeightRandomData, ValueTuple<int, int>>$$Invoke
; RVA 0x48DA45C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA45C  sub      sp, sp, #0x50
0048DA460  str      x30, [sp, #0x40]
0048DA464  ldp      q2, q0, [x1, #0x10]
0048DA468  ldr      x10, [x1, #0x30]
0048DA46C  ldr      q1, [x1]
0048DA470  ldr      x9, [x0, #0x18]
0048DA474  ldr      x8, [x0, #0x40]
0048DA478  str      x10, [sp, #0x30]
0048DA47C  stp      q2, q0, [sp, #0x10]
0048DA480  str      q1, [sp]
0048DA484  ldr      x2, [x0, #0x28]
0048DA488  mov      x1, sp
0048DA48C  mov      x0, x8
0048DA490  blr      x9
0048DA494  ldr      x30, [sp, #0x40]
0048DA498  add      sp, sp, #0x50
0048DA49C  ret      

; System.Func<WeightRandomData, ValueTuple<int, int>>$$BeginInvoke
; RVA 0x48DA4A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA4A0  sub      sp, sp, #0x50
0048DA4A4  str      x30, [sp, #0x10]
0048DA4A8  stp      x24, x23, [sp, #0x20]
0048DA4AC  stp      x22, x21, [sp, #0x30]
0048DA4B0  stp      x20, x19, [sp, #0x40]
0048DA4B4  adrp     x24, #0x9591000
0048DA4B8  adrp     x23, #0x8ee8000
0048DA4BC  ldrb     w8, [x24, #0xf9c]
0048DA4C0  ldr      x23, [x23, #0x3d8]
0048DA4C4  mov      x19, x3
0048DA4C8  mov      x20, x2
0048DA4CC  mov      x22, x1
0048DA4D0  mov      x21, x0
0048DA4D4  tbnz     w8, #0, #0x48da4ec
0048DA4D8  adrp     x0, #0x8ee8000
0048DA4DC  ldr      x0, [x0, #0x3d8]
0048DA4E0  bl       #0x382bd14 ; 
0048DA4E4  mov      w8, #1
0048DA4E8  strb     w8, [x24, #0xf9c]
0048DA4EC  ldr      x0, [x23]
0048DA4F0  mov      x1, x22
0048DA4F4  str      xzr, [sp, #8]
0048DA4F8  bl       #0x382be94 ; 
0048DA4FC  str      x0, [sp]
0048DA500  mov      x1, sp
0048DA504  mov      x0, x21
0048DA508  mov      x2, x20
0048DA50C  mov      x3, x19
0048DA510  bl       #0x382bcc8 ; 
0048DA514  ldp      x20, x19, [sp, #0x40]
0048DA518  ldp      x22, x21, [sp, #0x30]
0048DA51C  ldp      x24, x23, [sp, #0x20]
0048DA520  ldr      x30, [sp, #0x10]
0048DA524  add      sp, sp, #0x50
0048DA528  ret      

; System.Func<WeightRandomData, ValueTuple<int, int>>$$EndInvoke
; RVA 0x48DA52C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA52C  str      x30, [sp, #-0x10]!
0048DA530  mov      x0, x1
0048DA534  mov      x1, xzr
0048DA538  bl       #0x382bccc ; 
0048DA53C  cbz      x0, #0x48da550
0048DA540  bl       #0x382be98 ; 
0048DA544  ldr      x0, [x0]
0048DA548  ldr      x30, [sp], #0x10
0048DA54C  ret      
0048DA550  bl       #0x382bfb8 ; 

