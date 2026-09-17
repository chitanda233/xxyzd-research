; System.Func<WeightRandomData, CalRoleData>$$.ctor
; RVA 0x48DAEF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAEF8  str      x30, [sp, #-0x30]!
0048DAEFC  stp      x22, x21, [sp, #0x10]
0048DAF00  stp      x20, x19, [sp, #0x20]
0048DAF04  ldr      x8, [x2, #8]
0048DAF08  mov      x19, x0
0048DAF0C  str      x2, [x0, #0x28]
0048DAF10  mov      x21, x2
0048DAF14  str      x8, [x0, #0x10]
0048DAF18  str      x1, [x0, #0x20]!
0048DAF1C  mov      x20, x1
0048DAF20  bl       #0x382bcb8 ; 
0048DAF24  ldrb     w22, [x21, #0x52]
0048DAF28  mov      x0, x21
0048DAF2C  str      x19, [x19, #0x40]
0048DAF30  bl       #0x382be14 ; 
0048DAF34  tbz      w0, #0, #0x48daf50
0048DAF38  cmp      w22, #1
0048DAF3C  b.ne     #0x48daf54
0048DAF40  adrp     x8, #0x3474000
0048DAF44  add      x8, x8, #0xec0
0048DAF48  str      x8, [x19, #0x18]
0048DAF4C  b        #0x48daf64 ; 
0048DAF50  cbz      x20, #0x48daf80
0048DAF54  ldr      x8, [x19, #0x10]
0048DAF58  ldr      x9, [x19, #0x20]
0048DAF5C  str      x8, [x19, #0x18]
0048DAF60  str      x9, [x19, #0x40]
0048DAF64  adrp     x8, #0x3474000
0048DAF68  add      x8, x8, #0xe2c
0048DAF6C  str      x8, [x19, #0x38]
0048DAF70  ldp      x20, x19, [sp, #0x20]
0048DAF74  ldp      x22, x21, [sp, #0x10]
0048DAF78  ldr      x30, [sp], #0x30
0048DAF7C  ret      
0048DAF80  adrp     x1, #0x1a2d000
0048DAF84  add      x1, x1, #0x4e9
0048DAF88  mov      x0, xzr
0048DAF8C  bl       #0x382bfd4 ; 
0048DAF90  mov      x1, xzr
0048DAF94  bl       #0x382be7c ; 

; System.Func<WeightRandomData, CalRoleData>$$Invoke
; RVA 0x48DAF98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAF98  sub      sp, sp, #0x50
0048DAF9C  str      x30, [sp, #0x40]
0048DAFA0  ldp      q2, q0, [x1, #0x10]
0048DAFA4  ldr      x11, [x1, #0x30]
0048DAFA8  ldr      q1, [x1]
0048DAFAC  ldr      x10, [x0, #0x18]
0048DAFB0  ldr      x9, [x0, #0x40]
0048DAFB4  str      x11, [sp, #0x30]
0048DAFB8  stp      q2, q0, [sp, #0x10]
0048DAFBC  str      q1, [sp]
0048DAFC0  ldr      x2, [x0, #0x28]
0048DAFC4  mov      x1, sp
0048DAFC8  mov      x0, x9
0048DAFCC  blr      x10
0048DAFD0  ldr      x30, [sp, #0x40]
0048DAFD4  add      sp, sp, #0x50
0048DAFD8  ret      

; System.Func<WeightRandomData, CalRoleData>$$BeginInvoke
; RVA 0x48DAFDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAFDC  sub      sp, sp, #0x50
0048DAFE0  str      x30, [sp, #0x10]
0048DAFE4  stp      x24, x23, [sp, #0x20]
0048DAFE8  stp      x22, x21, [sp, #0x30]
0048DAFEC  stp      x20, x19, [sp, #0x40]
0048DAFF0  adrp     x24, #0x9591000
0048DAFF4  adrp     x23, #0x8ee8000
0048DAFF8  ldrb     w8, [x24, #0xfa3]
0048DAFFC  ldr      x23, [x23, #0x3d8]
0048DB000  mov      x19, x3
0048DB004  mov      x20, x2
0048DB008  mov      x22, x1
0048DB00C  mov      x21, x0
0048DB010  tbnz     w8, #0, #0x48db028
0048DB014  adrp     x0, #0x8ee8000
0048DB018  ldr      x0, [x0, #0x3d8]
0048DB01C  bl       #0x382bd14 ; 
0048DB020  mov      w8, #1
0048DB024  strb     w8, [x24, #0xfa3]
0048DB028  ldr      x0, [x23]
0048DB02C  mov      x1, x22
0048DB030  str      xzr, [sp, #8]
0048DB034  bl       #0x382be94 ; 
0048DB038  str      x0, [sp]
0048DB03C  mov      x1, sp
0048DB040  mov      x0, x21
0048DB044  mov      x2, x20
0048DB048  mov      x3, x19
0048DB04C  bl       #0x382bcc8 ; 
0048DB050  ldp      x20, x19, [sp, #0x40]
0048DB054  ldp      x22, x21, [sp, #0x30]
0048DB058  ldp      x24, x23, [sp, #0x20]
0048DB05C  ldr      x30, [sp, #0x10]
0048DB060  add      sp, sp, #0x50
0048DB064  ret      

; System.Func<WeightRandomData, CalRoleData>$$EndInvoke
; RVA 0x48DB068; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB068  stp      x30, x19, [sp, #-0x10]!
0048DB06C  mov      x0, x1
0048DB070  mov      x1, xzr
0048DB074  mov      x19, x8
0048DB078  bl       #0x382bccc ; 
0048DB07C  cbz      x0, #0x48db09c
0048DB080  bl       #0x382be98 ; 
0048DB084  ldp      q0, q1, [x0]
0048DB088  ldr      q2, [x0, #0x20]
0048DB08C  stp      q0, q1, [x19]
0048DB090  str      q2, [x19, #0x20]
0048DB094  ldp      x30, x19, [sp], #0x10
0048DB098  ret      
0048DB09C  bl       #0x382bfb8 ; 

