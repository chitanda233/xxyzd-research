; System.Func<WeightRandomData, AttributeOneElement>$$.ctor
; RVA 0x48DA554; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA554  str      x30, [sp, #-0x30]!
0048DA558  stp      x22, x21, [sp, #0x10]
0048DA55C  stp      x20, x19, [sp, #0x20]
0048DA560  ldr      x8, [x2, #8]
0048DA564  mov      x19, x0
0048DA568  str      x2, [x0, #0x28]
0048DA56C  mov      x21, x2
0048DA570  str      x8, [x0, #0x10]
0048DA574  str      x1, [x0, #0x20]!
0048DA578  mov      x20, x1
0048DA57C  bl       #0x382bcb8 ; 
0048DA580  ldrb     w22, [x21, #0x52]
0048DA584  mov      x0, x21
0048DA588  str      x19, [x19, #0x40]
0048DA58C  bl       #0x382be14 ; 
0048DA590  tbz      w0, #0, #0x48da5ac
0048DA594  cmp      w22, #1
0048DA598  b.ne     #0x48da5b0
0048DA59C  adrp     x8, #0x3474000
0048DA5A0  add      x8, x8, #0xa8c
0048DA5A4  str      x8, [x19, #0x18]
0048DA5A8  b        #0x48da5c0 ; 
0048DA5AC  cbz      x20, #0x48da5dc
0048DA5B0  ldr      x8, [x19, #0x10]
0048DA5B4  ldr      x9, [x19, #0x20]
0048DA5B8  str      x8, [x19, #0x18]
0048DA5BC  str      x9, [x19, #0x40]
0048DA5C0  adrp     x8, #0x3474000
0048DA5C4  add      x8, x8, #0x9fc
0048DA5C8  str      x8, [x19, #0x38]
0048DA5CC  ldp      x20, x19, [sp, #0x20]
0048DA5D0  ldp      x22, x21, [sp, #0x10]
0048DA5D4  ldr      x30, [sp], #0x30
0048DA5D8  ret      
0048DA5DC  adrp     x1, #0x1a2d000
0048DA5E0  add      x1, x1, #0x4e9
0048DA5E4  mov      x0, xzr
0048DA5E8  bl       #0x382bfd4 ; 
0048DA5EC  mov      x1, xzr
0048DA5F0  bl       #0x382be7c ; 

; System.Func<WeightRandomData, AttributeOneElement>$$Invoke
; RVA 0x48DA5F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA5F4  sub      sp, sp, #0x50
0048DA5F8  str      x30, [sp, #0x40]
0048DA5FC  ldp      q2, q0, [x1, #0x10]
0048DA600  ldr      x11, [x1, #0x30]
0048DA604  ldr      q1, [x1]
0048DA608  ldr      x10, [x0, #0x18]
0048DA60C  ldr      x9, [x0, #0x40]
0048DA610  str      x11, [sp, #0x30]
0048DA614  stp      q2, q0, [sp, #0x10]
0048DA618  str      q1, [sp]
0048DA61C  ldr      x2, [x0, #0x28]
0048DA620  mov      x1, sp
0048DA624  mov      x0, x9
0048DA628  blr      x10
0048DA62C  ldr      x30, [sp, #0x40]
0048DA630  add      sp, sp, #0x50
0048DA634  ret      

; System.Func<WeightRandomData, AttributeOneElement>$$BeginInvoke
; RVA 0x48DA638; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA638  sub      sp, sp, #0x50
0048DA63C  str      x30, [sp, #0x10]
0048DA640  stp      x24, x23, [sp, #0x20]
0048DA644  stp      x22, x21, [sp, #0x30]
0048DA648  stp      x20, x19, [sp, #0x40]
0048DA64C  adrp     x24, #0x9591000
0048DA650  adrp     x23, #0x8ee8000
0048DA654  ldrb     w8, [x24, #0xf9d]
0048DA658  ldr      x23, [x23, #0x3d8]
0048DA65C  mov      x19, x3
0048DA660  mov      x20, x2
0048DA664  mov      x22, x1
0048DA668  mov      x21, x0
0048DA66C  tbnz     w8, #0, #0x48da684
0048DA670  adrp     x0, #0x8ee8000
0048DA674  ldr      x0, [x0, #0x3d8]
0048DA678  bl       #0x382bd14 ; 
0048DA67C  mov      w8, #1
0048DA680  strb     w8, [x24, #0xf9d]
0048DA684  ldr      x0, [x23]
0048DA688  mov      x1, x22
0048DA68C  str      xzr, [sp, #8]
0048DA690  bl       #0x382be94 ; 
0048DA694  str      x0, [sp]
0048DA698  mov      x1, sp
0048DA69C  mov      x0, x21
0048DA6A0  mov      x2, x20
0048DA6A4  mov      x3, x19
0048DA6A8  bl       #0x382bcc8 ; 
0048DA6AC  ldp      x20, x19, [sp, #0x40]
0048DA6B0  ldp      x22, x21, [sp, #0x30]
0048DA6B4  ldp      x24, x23, [sp, #0x20]
0048DA6B8  ldr      x30, [sp, #0x10]
0048DA6BC  add      sp, sp, #0x50
0048DA6C0  ret      

; System.Func<WeightRandomData, AttributeOneElement>$$EndInvoke
; RVA 0x48DA6C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA6C4  stp      x30, x19, [sp, #-0x10]!
0048DA6C8  mov      x0, x1
0048DA6CC  mov      x1, xzr
0048DA6D0  mov      x19, x8
0048DA6D4  bl       #0x382bccc ; 
0048DA6D8  cbz      x0, #0x48da6f8
0048DA6DC  bl       #0x382be98 ; 
0048DA6E0  ldr      q0, [x0]
0048DA6E4  ldr      x8, [x0, #0x10]
0048DA6E8  str      q0, [x19]
0048DA6EC  str      x8, [x19, #0x10]
0048DA6F0  ldp      x30, x19, [sp], #0x10
0048DA6F4  ret      
0048DA6F8  bl       #0x382bfb8 ; 

