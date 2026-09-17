; System.Func<WeightRandomData, object>$$.ctor
; RVA 0x48DB89C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB89C  str      x30, [sp, #-0x30]!
0048DB8A0  stp      x22, x21, [sp, #0x10]
0048DB8A4  stp      x20, x19, [sp, #0x20]
0048DB8A8  ldr      x8, [x2, #8]
0048DB8AC  mov      x19, x0
0048DB8B0  str      x2, [x0, #0x28]
0048DB8B4  mov      x21, x2
0048DB8B8  str      x8, [x0, #0x10]
0048DB8BC  str      x1, [x0, #0x20]!
0048DB8C0  mov      x20, x1
0048DB8C4  bl       #0x382bcb8 ; 
0048DB8C8  ldrb     w22, [x21, #0x52]
0048DB8CC  mov      x0, x21
0048DB8D0  str      x19, [x19, #0x40]
0048DB8D4  bl       #0x382be14 ; 
0048DB8D8  tbz      w0, #0, #0x48db8f4
0048DB8DC  cmp      w22, #1
0048DB8E0  b.ne     #0x48db8f8
0048DB8E4  adrp     x8, #0x3475000
0048DB8E8  add      x8, x8, #0x2d0
0048DB8EC  str      x8, [x19, #0x18]
0048DB8F0  b        #0x48db908 ; 
0048DB8F4  cbz      x20, #0x48db924
0048DB8F8  ldr      x8, [x19, #0x10]
0048DB8FC  ldr      x9, [x19, #0x20]
0048DB900  str      x8, [x19, #0x18]
0048DB904  str      x9, [x19, #0x40]
0048DB908  adrp     x8, #0x3475000
0048DB90C  add      x8, x8, #0x260
0048DB910  str      x8, [x19, #0x38]
0048DB914  ldp      x20, x19, [sp, #0x20]
0048DB918  ldp      x22, x21, [sp, #0x10]
0048DB91C  ldr      x30, [sp], #0x30
0048DB920  ret      
0048DB924  adrp     x1, #0x1a2d000
0048DB928  add      x1, x1, #0x4e9
0048DB92C  mov      x0, xzr
0048DB930  bl       #0x382bfd4 ; 
0048DB934  mov      x1, xzr
0048DB938  bl       #0x382be7c ; 

; System.Func<WeightRandomData, object>$$Invoke
; RVA 0x48DB93C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB93C  sub      sp, sp, #0x50
0048DB940  str      x30, [sp, #0x40]
0048DB944  ldp      q2, q0, [x1, #0x10]
0048DB948  ldr      x10, [x1, #0x30]
0048DB94C  ldr      q1, [x1]
0048DB950  ldr      x9, [x0, #0x18]
0048DB954  ldr      x8, [x0, #0x40]
0048DB958  str      x10, [sp, #0x30]
0048DB95C  stp      q2, q0, [sp, #0x10]
0048DB960  str      q1, [sp]
0048DB964  ldr      x2, [x0, #0x28]
0048DB968  mov      x1, sp
0048DB96C  mov      x0, x8
0048DB970  blr      x9
0048DB974  ldr      x30, [sp, #0x40]
0048DB978  add      sp, sp, #0x50
0048DB97C  ret      

; System.Func<WeightRandomData, object>$$BeginInvoke
; RVA 0x48DB980; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB980  sub      sp, sp, #0x50
0048DB984  str      x30, [sp, #0x10]
0048DB988  stp      x24, x23, [sp, #0x20]
0048DB98C  stp      x22, x21, [sp, #0x30]
0048DB990  stp      x20, x19, [sp, #0x40]
0048DB994  adrp     x24, #0x9591000
0048DB998  adrp     x23, #0x8ee8000
0048DB99C  ldrb     w8, [x24, #0xfa9]
0048DB9A0  ldr      x23, [x23, #0x3d8]
0048DB9A4  mov      x19, x3
0048DB9A8  mov      x20, x2
0048DB9AC  mov      x22, x1
0048DB9B0  mov      x21, x0
0048DB9B4  tbnz     w8, #0, #0x48db9cc
0048DB9B8  adrp     x0, #0x8ee8000
0048DB9BC  ldr      x0, [x0, #0x3d8]
0048DB9C0  bl       #0x382bd14 ; 
0048DB9C4  mov      w8, #1
0048DB9C8  strb     w8, [x24, #0xfa9]
0048DB9CC  ldr      x0, [x23]
0048DB9D0  mov      x1, x22
0048DB9D4  str      xzr, [sp, #8]
0048DB9D8  bl       #0x382be94 ; 
0048DB9DC  str      x0, [sp]
0048DB9E0  mov      x1, sp
0048DB9E4  mov      x0, x21
0048DB9E8  mov      x2, x20
0048DB9EC  mov      x3, x19
0048DB9F0  bl       #0x382bcc8 ; 
0048DB9F4  ldp      x20, x19, [sp, #0x40]
0048DB9F8  ldp      x22, x21, [sp, #0x30]
0048DB9FC  ldp      x24, x23, [sp, #0x20]
0048DBA00  ldr      x30, [sp, #0x10]
0048DBA04  add      sp, sp, #0x50
0048DBA08  ret      

; System.Func<WeightRandomData, object>$$EndInvoke
; RVA 0x48DBA0C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DBA0C  mov      x0, x1
0048DBA10  mov      x1, xzr
0048DBA14  b        #0x382bccc ; 

