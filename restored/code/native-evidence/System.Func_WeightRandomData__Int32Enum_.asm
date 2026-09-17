; System.Func<WeightRandomData, Int32Enum>$$.ctor
; RVA 0x48DB56C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB56C  str      x30, [sp, #-0x30]!
0048DB570  stp      x22, x21, [sp, #0x10]
0048DB574  stp      x20, x19, [sp, #0x20]
0048DB578  ldr      x8, [x2, #8]
0048DB57C  mov      x19, x0
0048DB580  str      x2, [x0, #0x28]
0048DB584  mov      x21, x2
0048DB588  str      x8, [x0, #0x10]
0048DB58C  str      x1, [x0, #0x20]!
0048DB590  mov      x20, x1
0048DB594  bl       #0x382bcb8 ; 
0048DB598  ldrb     w22, [x21, #0x52]
0048DB59C  mov      x0, x21
0048DB5A0  str      x19, [x19, #0x40]
0048DB5A4  bl       #0x382be14 ; 
0048DB5A8  tbz      w0, #0, #0x48db5c4
0048DB5AC  cmp      w22, #1
0048DB5B0  b.ne     #0x48db5c8
0048DB5B4  adrp     x8, #0x3475000
0048DB5B8  add      x8, x8, #0x178
0048DB5BC  str      x8, [x19, #0x18]
0048DB5C0  b        #0x48db5d8 ; 
0048DB5C4  cbz      x20, #0x48db5f4
0048DB5C8  ldr      x8, [x19, #0x10]
0048DB5CC  ldr      x9, [x19, #0x20]
0048DB5D0  str      x8, [x19, #0x18]
0048DB5D4  str      x9, [x19, #0x40]
0048DB5D8  adrp     x8, #0x3475000
0048DB5DC  add      x8, x8, #0x108
0048DB5E0  str      x8, [x19, #0x38]
0048DB5E4  ldp      x20, x19, [sp, #0x20]
0048DB5E8  ldp      x22, x21, [sp, #0x10]
0048DB5EC  ldr      x30, [sp], #0x30
0048DB5F0  ret      
0048DB5F4  adrp     x1, #0x1a2d000
0048DB5F8  add      x1, x1, #0x4e9
0048DB5FC  mov      x0, xzr
0048DB600  bl       #0x382bfd4 ; 
0048DB604  mov      x1, xzr
0048DB608  bl       #0x382be7c ; 

; System.Func<WeightRandomData, Int32Enum>$$Invoke
; RVA 0x48DB60C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB60C  sub      sp, sp, #0x50
0048DB610  str      x30, [sp, #0x40]
0048DB614  ldp      q2, q0, [x1, #0x10]
0048DB618  ldr      x10, [x1, #0x30]
0048DB61C  ldr      q1, [x1]
0048DB620  ldr      x9, [x0, #0x18]
0048DB624  ldr      x8, [x0, #0x40]
0048DB628  str      x10, [sp, #0x30]
0048DB62C  stp      q2, q0, [sp, #0x10]
0048DB630  str      q1, [sp]
0048DB634  ldr      x2, [x0, #0x28]
0048DB638  mov      x1, sp
0048DB63C  mov      x0, x8
0048DB640  blr      x9
0048DB644  ldr      x30, [sp, #0x40]
0048DB648  add      sp, sp, #0x50
0048DB64C  ret      

; System.Func<WeightRandomData, Int32Enum>$$BeginInvoke
; RVA 0x48DB650; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB650  sub      sp, sp, #0x50
0048DB654  str      x30, [sp, #0x10]
0048DB658  stp      x24, x23, [sp, #0x20]
0048DB65C  stp      x22, x21, [sp, #0x30]
0048DB660  stp      x20, x19, [sp, #0x40]
0048DB664  adrp     x24, #0x9591000
0048DB668  adrp     x23, #0x8ee8000
0048DB66C  ldrb     w8, [x24, #0xfa7]
0048DB670  ldr      x23, [x23, #0x3d8]
0048DB674  mov      x19, x3
0048DB678  mov      x20, x2
0048DB67C  mov      x22, x1
0048DB680  mov      x21, x0
0048DB684  tbnz     w8, #0, #0x48db69c
0048DB688  adrp     x0, #0x8ee8000
0048DB68C  ldr      x0, [x0, #0x3d8]
0048DB690  bl       #0x382bd14 ; 
0048DB694  mov      w8, #1
0048DB698  strb     w8, [x24, #0xfa7]
0048DB69C  ldr      x0, [x23]
0048DB6A0  mov      x1, x22
0048DB6A4  str      xzr, [sp, #8]
0048DB6A8  bl       #0x382be94 ; 
0048DB6AC  str      x0, [sp]
0048DB6B0  mov      x1, sp
0048DB6B4  mov      x0, x21
0048DB6B8  mov      x2, x20
0048DB6BC  mov      x3, x19
0048DB6C0  bl       #0x382bcc8 ; 
0048DB6C4  ldp      x20, x19, [sp, #0x40]
0048DB6C8  ldp      x22, x21, [sp, #0x30]
0048DB6CC  ldp      x24, x23, [sp, #0x20]
0048DB6D0  ldr      x30, [sp, #0x10]
0048DB6D4  add      sp, sp, #0x50
0048DB6D8  ret      

; System.Func<WeightRandomData, Int32Enum>$$EndInvoke
; RVA 0x48DB6DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB6DC  str      x30, [sp, #-0x10]!
0048DB6E0  mov      x0, x1
0048DB6E4  mov      x1, xzr
0048DB6E8  bl       #0x382bccc ; 
0048DB6EC  cbz      x0, #0x48db700
0048DB6F0  bl       #0x382be98 ; 
0048DB6F4  ldr      w0, [x0]
0048DB6F8  ldr      x30, [sp], #0x10
0048DB6FC  ret      
0048DB700  bl       #0x382bfb8 ; 

