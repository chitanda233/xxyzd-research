; System.Predicate<WeightRandomData>$$.ctor
; RVA 0x5283480; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005283480  str      x30, [sp, #-0x30]!
005283484  stp      x22, x21, [sp, #0x10]
005283488  stp      x20, x19, [sp, #0x20]
00528348C  ldr      x8, [x2, #8]
005283490  mov      x19, x0
005283494  str      x2, [x0, #0x28]
005283498  mov      x21, x2
00528349C  str      x8, [x0, #0x10]
0052834A0  str      x1, [x0, #0x20]!
0052834A4  mov      x20, x1
0052834A8  bl       #0x382bcb8 ; 
0052834AC  ldrb     w22, [x21, #0x52]
0052834B0  mov      x0, x21
0052834B4  str      x19, [x19, #0x40]
0052834B8  bl       #0x382be14 ; 
0052834BC  tbz      w0, #0, #0x52834d8
0052834C0  cmp      w22, #1
0052834C4  b.ne     #0x52834dc
0052834C8  adrp     x8, #0x34b7000
0052834CC  add      x8, x8, #0x88
0052834D0  str      x8, [x19, #0x18]
0052834D4  b        #0x52834ec ; 
0052834D8  cbz      x20, #0x5283508
0052834DC  ldr      x8, [x19, #0x10]
0052834E0  ldr      x9, [x19, #0x20]
0052834E4  str      x8, [x19, #0x18]
0052834E8  str      x9, [x19, #0x40]
0052834EC  adrp     x8, #0x34b7000
0052834F0  add      x8, x8, #0x14
0052834F4  str      x8, [x19, #0x38]
0052834F8  ldp      x20, x19, [sp, #0x20]
0052834FC  ldp      x22, x21, [sp, #0x10]
005283500  ldr      x30, [sp], #0x30
005283504  ret      
005283508  adrp     x1, #0x1a2d000
00528350C  add      x1, x1, #0x4e9
005283510  mov      x0, xzr
005283514  bl       #0x382bfd4 ; 
005283518  mov      x1, xzr
00528351C  bl       #0x382be7c ; 

; System.Predicate<WeightRandomData>$$Invoke
; RVA 0x5283520; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005283520  sub      sp, sp, #0x50
005283524  str      x30, [sp, #0x40]
005283528  ldp      q2, q0, [x1, #0x10]
00528352C  ldr      x10, [x1, #0x30]
005283530  ldr      q1, [x1]
005283534  ldr      x9, [x0, #0x18]
005283538  ldr      x8, [x0, #0x40]
00528353C  str      x10, [sp, #0x30]
005283540  stp      q2, q0, [sp, #0x10]
005283544  str      q1, [sp]
005283548  ldr      x2, [x0, #0x28]
00528354C  mov      x1, sp
005283550  mov      x0, x8
005283554  blr      x9
005283558  ldr      x30, [sp, #0x40]
00528355C  and      w0, w0, #1
005283560  add      sp, sp, #0x50
005283564  ret      

; System.Predicate<WeightRandomData>$$BeginInvoke
; RVA 0x5283568; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005283568  sub      sp, sp, #0x50
00528356C  str      x30, [sp, #0x10]
005283570  stp      x24, x23, [sp, #0x20]
005283574  stp      x22, x21, [sp, #0x30]
005283578  stp      x20, x19, [sp, #0x40]
00528357C  adrp     x24, #0x9593000
005283580  adrp     x23, #0x8ee8000
005283584  ldrb     w8, [x24, #0x1f0]
005283588  ldr      x23, [x23, #0x3d8]
00528358C  mov      x19, x3
005283590  mov      x20, x2
005283594  mov      x22, x1
005283598  mov      x21, x0
00528359C  tbnz     w8, #0, #0x52835b4
0052835A0  adrp     x0, #0x8ee8000
0052835A4  ldr      x0, [x0, #0x3d8]
0052835A8  bl       #0x382bd14 ; 
0052835AC  mov      w8, #1
0052835B0  strb     w8, [x24, #0x1f0]
0052835B4  ldr      x0, [x23]
0052835B8  mov      x1, x22
0052835BC  str      xzr, [sp, #8]
0052835C0  bl       #0x382be94 ; 
0052835C4  str      x0, [sp]
0052835C8  mov      x1, sp
0052835CC  mov      x0, x21
0052835D0  mov      x2, x20
0052835D4  mov      x3, x19
0052835D8  bl       #0x382bcc8 ; 
0052835DC  ldp      x20, x19, [sp, #0x40]
0052835E0  ldp      x22, x21, [sp, #0x30]
0052835E4  ldp      x24, x23, [sp, #0x20]
0052835E8  ldr      x30, [sp, #0x10]
0052835EC  add      sp, sp, #0x50
0052835F0  ret      

; System.Predicate<WeightRandomData>$$EndInvoke
; RVA 0x52835F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0052835F4  str      x30, [sp, #-0x10]!
0052835F8  mov      x0, x1
0052835FC  mov      x1, xzr
005283600  bl       #0x382bccc ; 
005283604  cbz      x0, #0x5283618
005283608  bl       #0x382be98 ; 
00528360C  ldrb     w0, [x0]
005283610  ldr      x30, [sp], #0x10
005283614  ret      
005283618  bl       #0x382bfb8 ; 

