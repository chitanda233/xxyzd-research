; System.Func<WeightRandomData, bool>$$.ctor
; RVA 0x48DA6FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA6FC  str      x30, [sp, #-0x30]!
0048DA700  stp      x22, x21, [sp, #0x10]
0048DA704  stp      x20, x19, [sp, #0x20]
0048DA708  ldr      x8, [x2, #8]
0048DA70C  mov      x19, x0
0048DA710  str      x2, [x0, #0x28]
0048DA714  mov      x21, x2
0048DA718  str      x8, [x0, #0x10]
0048DA71C  str      x1, [x0, #0x20]!
0048DA720  mov      x20, x1
0048DA724  bl       #0x382bcb8 ; 
0048DA728  ldrb     w22, [x21, #0x52]
0048DA72C  mov      x0, x21
0048DA730  str      x19, [x19, #0x40]
0048DA734  bl       #0x382be14 ; 
0048DA738  tbz      w0, #0, #0x48da754
0048DA73C  cmp      w22, #1
0048DA740  b.ne     #0x48da758
0048DA744  adrp     x8, #0x3474000
0048DA748  add      x8, x8, #0xb3c
0048DA74C  str      x8, [x19, #0x18]
0048DA750  b        #0x48da768 ; 
0048DA754  cbz      x20, #0x48da784
0048DA758  ldr      x8, [x19, #0x10]
0048DA75C  ldr      x9, [x19, #0x20]
0048DA760  str      x8, [x19, #0x18]
0048DA764  str      x9, [x19, #0x40]
0048DA768  adrp     x8, #0x3474000
0048DA76C  add      x8, x8, #0xac8
0048DA770  str      x8, [x19, #0x38]
0048DA774  ldp      x20, x19, [sp, #0x20]
0048DA778  ldp      x22, x21, [sp, #0x10]
0048DA77C  ldr      x30, [sp], #0x30
0048DA780  ret      
0048DA784  adrp     x1, #0x1a2d000
0048DA788  add      x1, x1, #0x4e9
0048DA78C  mov      x0, xzr
0048DA790  bl       #0x382bfd4 ; 
0048DA794  mov      x1, xzr
0048DA798  bl       #0x382be7c ; 

; System.Func<WeightRandomData, bool>$$Invoke
; RVA 0x48DA79C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA79C  sub      sp, sp, #0x50
0048DA7A0  str      x30, [sp, #0x40]
0048DA7A4  ldp      q2, q0, [x1, #0x10]
0048DA7A8  ldr      x10, [x1, #0x30]
0048DA7AC  ldr      q1, [x1]
0048DA7B0  ldr      x9, [x0, #0x18]
0048DA7B4  ldr      x8, [x0, #0x40]
0048DA7B8  str      x10, [sp, #0x30]
0048DA7BC  stp      q2, q0, [sp, #0x10]
0048DA7C0  str      q1, [sp]
0048DA7C4  ldr      x2, [x0, #0x28]
0048DA7C8  mov      x1, sp
0048DA7CC  mov      x0, x8
0048DA7D0  blr      x9
0048DA7D4  ldr      x30, [sp, #0x40]
0048DA7D8  and      w0, w0, #1
0048DA7DC  add      sp, sp, #0x50
0048DA7E0  ret      

; System.Func<WeightRandomData, bool>$$BeginInvoke
; RVA 0x48DA7E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA7E4  sub      sp, sp, #0x50
0048DA7E8  str      x30, [sp, #0x10]
0048DA7EC  stp      x24, x23, [sp, #0x20]
0048DA7F0  stp      x22, x21, [sp, #0x30]
0048DA7F4  stp      x20, x19, [sp, #0x40]
0048DA7F8  adrp     x24, #0x9591000
0048DA7FC  adrp     x23, #0x8ee8000
0048DA800  ldrb     w8, [x24, #0xf9e]
0048DA804  ldr      x23, [x23, #0x3d8]
0048DA808  mov      x19, x3
0048DA80C  mov      x20, x2
0048DA810  mov      x22, x1
0048DA814  mov      x21, x0
0048DA818  tbnz     w8, #0, #0x48da830
0048DA81C  adrp     x0, #0x8ee8000
0048DA820  ldr      x0, [x0, #0x3d8]
0048DA824  bl       #0x382bd14 ; 
0048DA828  mov      w8, #1
0048DA82C  strb     w8, [x24, #0xf9e]
0048DA830  ldr      x0, [x23]
0048DA834  mov      x1, x22
0048DA838  str      xzr, [sp, #8]
0048DA83C  bl       #0x382be94 ; 
0048DA840  str      x0, [sp]
0048DA844  mov      x1, sp
0048DA848  mov      x0, x21
0048DA84C  mov      x2, x20
0048DA850  mov      x3, x19
0048DA854  bl       #0x382bcc8 ; 
0048DA858  ldp      x20, x19, [sp, #0x40]
0048DA85C  ldp      x22, x21, [sp, #0x30]
0048DA860  ldp      x24, x23, [sp, #0x20]
0048DA864  ldr      x30, [sp, #0x10]
0048DA868  add      sp, sp, #0x50
0048DA86C  ret      

; System.Func<WeightRandomData, bool>$$EndInvoke
; RVA 0x48DA870; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DA870  str      x30, [sp, #-0x10]!
0048DA874  mov      x0, x1
0048DA878  mov      x1, xzr
0048DA87C  bl       #0x382bccc ; 
0048DA880  cbz      x0, #0x48da894
0048DA884  bl       #0x382be98 ; 
0048DA888  ldrb     w0, [x0]
0048DA88C  ldr      x30, [sp], #0x10
0048DA890  ret      
0048DA894  bl       #0x382bfb8 ; 

