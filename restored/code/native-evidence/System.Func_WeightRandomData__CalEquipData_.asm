; System.Func<WeightRandomData, CalEquipData>$$.ctor
; RVA 0x48DAD60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAD60  str      x30, [sp, #-0x30]!
0048DAD64  stp      x22, x21, [sp, #0x10]
0048DAD68  stp      x20, x19, [sp, #0x20]
0048DAD6C  ldr      x8, [x2, #8]
0048DAD70  mov      x19, x0
0048DAD74  str      x2, [x0, #0x28]
0048DAD78  mov      x21, x2
0048DAD7C  str      x8, [x0, #0x10]
0048DAD80  str      x1, [x0, #0x20]!
0048DAD84  mov      x20, x1
0048DAD88  bl       #0x382bcb8 ; 
0048DAD8C  ldrb     w22, [x21, #0x52]
0048DAD90  mov      x0, x21
0048DAD94  str      x19, [x19, #0x40]
0048DAD98  bl       #0x382be14 ; 
0048DAD9C  tbz      w0, #0, #0x48dadb8
0048DADA0  cmp      w22, #1
0048DADA4  b.ne     #0x48dadbc
0048DADA8  adrp     x8, #0x3474000
0048DADAC  add      x8, x8, #0xdf0
0048DADB0  str      x8, [x19, #0x18]
0048DADB4  b        #0x48dadcc ; 
0048DADB8  cbz      x20, #0x48dade8
0048DADBC  ldr      x8, [x19, #0x10]
0048DADC0  ldr      x9, [x19, #0x20]
0048DADC4  str      x8, [x19, #0x18]
0048DADC8  str      x9, [x19, #0x40]
0048DADCC  adrp     x8, #0x3474000
0048DADD0  add      x8, x8, #0xd80
0048DADD4  str      x8, [x19, #0x38]
0048DADD8  ldp      x20, x19, [sp, #0x20]
0048DADDC  ldp      x22, x21, [sp, #0x10]
0048DADE0  ldr      x30, [sp], #0x30
0048DADE4  ret      
0048DADE8  adrp     x1, #0x1a2d000
0048DADEC  add      x1, x1, #0x4e9
0048DADF0  mov      x0, xzr
0048DADF4  bl       #0x382bfd4 ; 
0048DADF8  mov      x1, xzr
0048DADFC  bl       #0x382be7c ; 

; System.Func<WeightRandomData, CalEquipData>$$Invoke
; RVA 0x48DAE00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAE00  sub      sp, sp, #0x50
0048DAE04  str      x30, [sp, #0x40]
0048DAE08  ldp      q2, q0, [x1, #0x10]
0048DAE0C  ldr      x10, [x1, #0x30]
0048DAE10  ldr      q1, [x1]
0048DAE14  ldr      x9, [x0, #0x18]
0048DAE18  ldr      x8, [x0, #0x40]
0048DAE1C  str      x10, [sp, #0x30]
0048DAE20  stp      q2, q0, [sp, #0x10]
0048DAE24  str      q1, [sp]
0048DAE28  ldr      x2, [x0, #0x28]
0048DAE2C  mov      x1, sp
0048DAE30  mov      x0, x8
0048DAE34  blr      x9
0048DAE38  ldr      x30, [sp, #0x40]
0048DAE3C  add      sp, sp, #0x50
0048DAE40  ret      

; System.Func<WeightRandomData, CalEquipData>$$BeginInvoke
; RVA 0x48DAE44; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAE44  sub      sp, sp, #0x50
0048DAE48  str      x30, [sp, #0x10]
0048DAE4C  stp      x24, x23, [sp, #0x20]
0048DAE50  stp      x22, x21, [sp, #0x30]
0048DAE54  stp      x20, x19, [sp, #0x40]
0048DAE58  adrp     x24, #0x9591000
0048DAE5C  adrp     x23, #0x8ee8000
0048DAE60  ldrb     w8, [x24, #0xfa2]
0048DAE64  ldr      x23, [x23, #0x3d8]
0048DAE68  mov      x19, x3
0048DAE6C  mov      x20, x2
0048DAE70  mov      x22, x1
0048DAE74  mov      x21, x0
0048DAE78  tbnz     w8, #0, #0x48dae90
0048DAE7C  adrp     x0, #0x8ee8000
0048DAE80  ldr      x0, [x0, #0x3d8]
0048DAE84  bl       #0x382bd14 ; 
0048DAE88  mov      w8, #1
0048DAE8C  strb     w8, [x24, #0xfa2]
0048DAE90  ldr      x0, [x23]
0048DAE94  mov      x1, x22
0048DAE98  str      xzr, [sp, #8]
0048DAE9C  bl       #0x382be94 ; 
0048DAEA0  str      x0, [sp]
0048DAEA4  mov      x1, sp
0048DAEA8  mov      x0, x21
0048DAEAC  mov      x2, x20
0048DAEB0  mov      x3, x19
0048DAEB4  bl       #0x382bcc8 ; 
0048DAEB8  ldp      x20, x19, [sp, #0x40]
0048DAEBC  ldp      x22, x21, [sp, #0x30]
0048DAEC0  ldp      x24, x23, [sp, #0x20]
0048DAEC4  ldr      x30, [sp, #0x10]
0048DAEC8  add      sp, sp, #0x50
0048DAECC  ret      

; System.Func<WeightRandomData, CalEquipData>$$EndInvoke
; RVA 0x48DAED0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DAED0  str      x30, [sp, #-0x10]!
0048DAED4  mov      x0, x1
0048DAED8  mov      x1, xzr
0048DAEDC  bl       #0x382bccc ; 
0048DAEE0  cbz      x0, #0x48daef4
0048DAEE4  bl       #0x382be98 ; 
0048DAEE8  ldr      x0, [x0]
0048DAEEC  ldr      x30, [sp], #0x10
0048DAEF0  ret      
0048DAEF4  bl       #0x382bfb8 ; 

