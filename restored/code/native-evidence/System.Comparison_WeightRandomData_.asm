; System.Comparison<WeightRandomData>$$.ctor
; RVA 0x5C8EFAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005C8EFAC  str      x30, [sp, #-0x30]!
005C8EFB0  stp      x22, x21, [sp, #0x10]
005C8EFB4  stp      x20, x19, [sp, #0x20]
005C8EFB8  ldr      x8, [x2, #8]
005C8EFBC  mov      x19, x0
005C8EFC0  str      x2, [x0, #0x28]
005C8EFC4  mov      x21, x2
005C8EFC8  str      x8, [x0, #0x10]
005C8EFCC  str      x1, [x0, #0x20]!
005C8EFD0  mov      x20, x1
005C8EFD4  bl       #0x382bcb8 ; 
005C8EFD8  ldrb     w22, [x21, #0x52]
005C8EFDC  mov      x0, x21
005C8EFE0  str      x19, [x19, #0x40]
005C8EFE4  bl       #0x382be14 ; 
005C8EFE8  tbz      w0, #0, #0x5c8f004
005C8EFEC  cmp      w22, #2
005C8EFF0  b.ne     #0x5c8f008
005C8EFF4  adrp     x8, #0x34fc000
005C8EFF8  add      x8, x8, #0xa44
005C8EFFC  str      x8, [x19, #0x18]
005C8F000  b        #0x5c8f018 ; 
005C8F004  cbz      x20, #0x5c8f034
005C8F008  ldr      x8, [x19, #0x10]
005C8F00C  ldr      x9, [x19, #0x20]
005C8F010  str      x8, [x19, #0x18]
005C8F014  str      x9, [x19, #0x40]
005C8F018  adrp     x8, #0x34fc000
005C8F01C  add      x8, x8, #0x9ac
005C8F020  str      x8, [x19, #0x38]
005C8F024  ldp      x20, x19, [sp, #0x20]
005C8F028  ldp      x22, x21, [sp, #0x10]
005C8F02C  ldr      x30, [sp], #0x30
005C8F030  ret      
005C8F034  adrp     x1, #0x1a2d000
005C8F038  add      x1, x1, #0x4e9
005C8F03C  mov      x0, xzr
005C8F040  bl       #0x382bfd4 ; 
005C8F044  mov      x1, xzr
005C8F048  bl       #0x382be7c ; 

; System.Comparison<WeightRandomData>$$Invoke
; RVA 0x5C8F04C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005C8F04C  sub      sp, sp, #0x90
005C8F050  str      x30, [sp, #0x80]
005C8F054  ldp      q2, q0, [x1, #0x10]
005C8F058  ldr      x10, [x1, #0x30]
005C8F05C  ldr      q1, [x1]
005C8F060  ldr      x9, [x0, #0x18]
005C8F064  ldr      x8, [x0, #0x40]
005C8F068  str      x10, [sp, #0x70]
005C8F06C  stp      q2, q0, [sp, #0x50]
005C8F070  str      q1, [sp, #0x40]
005C8F074  ldr      x10, [x2, #0x30]
005C8F078  ldp      q1, q0, [x2, #0x10]
005C8F07C  ldr      q2, [x2]
005C8F080  add      x1, sp, #0x40
005C8F084  str      x10, [sp, #0x30]
005C8F088  stp      q1, q0, [sp, #0x10]
005C8F08C  str      q2, [sp]
005C8F090  ldr      x3, [x0, #0x28]
005C8F094  mov      x2, sp
005C8F098  mov      x0, x8
005C8F09C  blr      x9
005C8F0A0  ldr      x30, [sp, #0x80]
005C8F0A4  add      sp, sp, #0x90
005C8F0A8  ret      

; System.Comparison<WeightRandomData>$$BeginInvoke
; RVA 0x5C8F0AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005C8F0AC  sub      sp, sp, #0x60
005C8F0B0  stp      x30, x25, [sp, #0x20]
005C8F0B4  stp      x24, x23, [sp, #0x30]
005C8F0B8  stp      x22, x21, [sp, #0x40]
005C8F0BC  stp      x20, x19, [sp, #0x50]
005C8F0C0  adrp     x25, #0x9595000
005C8F0C4  adrp     x24, #0x8ee8000
005C8F0C8  ldrb     w8, [x25, #0xa58]
005C8F0CC  ldr      x24, [x24, #0x3d8]
005C8F0D0  mov      x19, x4
005C8F0D4  mov      x20, x3
005C8F0D8  mov      x22, x2
005C8F0DC  mov      x23, x1
005C8F0E0  mov      x21, x0
005C8F0E4  tbnz     w8, #0, #0x5c8f0fc
005C8F0E8  adrp     x0, #0x8ee8000
005C8F0EC  ldr      x0, [x0, #0x3d8]
005C8F0F0  bl       #0x382bd14 ; 
005C8F0F4  mov      w8, #1
005C8F0F8  strb     w8, [x25, #0xa58]
005C8F0FC  ldr      x0, [x24]
005C8F100  mov      x1, x23
005C8F104  str      xzr, [sp, #0x18]
005C8F108  bl       #0x382be94 ; 
005C8F10C  ldr      x8, [x24]
005C8F110  str      x0, [sp, #8]
005C8F114  mov      x1, x22
005C8F118  mov      x0, x8
005C8F11C  bl       #0x382be94 ; 
005C8F120  str      x0, [sp, #0x10]
005C8F124  add      x1, sp, #8
005C8F128  mov      x0, x21
005C8F12C  mov      x2, x20
005C8F130  mov      x3, x19
005C8F134  bl       #0x382bcc8 ; 
005C8F138  ldp      x20, x19, [sp, #0x50]
005C8F13C  ldp      x22, x21, [sp, #0x40]
005C8F140  ldp      x24, x23, [sp, #0x30]
005C8F144  ldp      x30, x25, [sp, #0x20]
005C8F148  add      sp, sp, #0x60
005C8F14C  ret      

; System.Comparison<WeightRandomData>$$EndInvoke
; RVA 0x5C8F150; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
005C8F150  str      x30, [sp, #-0x10]!
005C8F154  mov      x0, x1
005C8F158  mov      x1, xzr
005C8F15C  bl       #0x382bccc ; 
005C8F160  cbz      x0, #0x5c8f174
005C8F164  bl       #0x382be98 ; 
005C8F168  ldr      w0, [x0]
005C8F16C  ldr      x30, [sp], #0x10
005C8F170  ret      
005C8F174  bl       #0x382bfb8 ; 

