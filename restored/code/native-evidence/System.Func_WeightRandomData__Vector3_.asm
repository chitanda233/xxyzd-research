; System.Func<WeightRandomData, Vector3>$$.ctor
; RVA 0x48DBA18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DBA18  str      x30, [sp, #-0x30]!
0048DBA1C  stp      x22, x21, [sp, #0x10]
0048DBA20  stp      x20, x19, [sp, #0x20]
0048DBA24  ldr      x8, [x2, #8]
0048DBA28  mov      x19, x0
0048DBA2C  str      x2, [x0, #0x28]
0048DBA30  mov      x21, x2
0048DBA34  str      x8, [x0, #0x10]
0048DBA38  str      x1, [x0, #0x20]!
0048DBA3C  mov      x20, x1
0048DBA40  bl       #0x382bcb8 ; 
0048DBA44  ldrb     w22, [x21, #0x52]
0048DBA48  mov      x0, x21
0048DBA4C  str      x19, [x19, #0x40]
0048DBA50  bl       #0x382be14 ; 
0048DBA54  tbz      w0, #0, #0x48dba70
0048DBA58  cmp      w22, #1
0048DBA5C  b.ne     #0x48dba74
0048DBA60  adrp     x8, #0x3475000
0048DBA64  add      x8, x8, #0x384
0048DBA68  str      x8, [x19, #0x18]
0048DBA6C  b        #0x48dba84 ; 
0048DBA70  cbz      x20, #0x48dbaa0
0048DBA74  ldr      x8, [x19, #0x10]
0048DBA78  ldr      x9, [x19, #0x20]
0048DBA7C  str      x8, [x19, #0x18]
0048DBA80  str      x9, [x19, #0x40]
0048DBA84  adrp     x8, #0x3475000
0048DBA88  add      x8, x8, #0x30c
0048DBA8C  str      x8, [x19, #0x38]
0048DBA90  ldp      x20, x19, [sp, #0x20]
0048DBA94  ldp      x22, x21, [sp, #0x10]
0048DBA98  ldr      x30, [sp], #0x30
0048DBA9C  ret      
0048DBAA0  adrp     x1, #0x1a2d000
0048DBAA4  add      x1, x1, #0x4e9
0048DBAA8  mov      x0, xzr
0048DBAAC  bl       #0x382bfd4 ; 
0048DBAB0  mov      x1, xzr
0048DBAB4  bl       #0x382be7c ; 

; System.Func<WeightRandomData, Vector3>$$Invoke
; RVA 0x48DBAB8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DBAB8  sub      sp, sp, #0x50
0048DBABC  str      x30, [sp, #0x40]
0048DBAC0  ldp      q2, q0, [x1, #0x10]
0048DBAC4  ldr      x10, [x1, #0x30]
0048DBAC8  ldr      q1, [x1]
0048DBACC  ldr      x9, [x0, #0x18]
0048DBAD0  ldr      x8, [x0, #0x40]
0048DBAD4  str      x10, [sp, #0x30]
0048DBAD8  stp      q2, q0, [sp, #0x10]
0048DBADC  str      q1, [sp]
0048DBAE0  ldr      x2, [x0, #0x28]
0048DBAE4  mov      x1, sp
0048DBAE8  mov      x0, x8
0048DBAEC  blr      x9
0048DBAF0  ldr      x30, [sp, #0x40]
0048DBAF4  add      sp, sp, #0x50
0048DBAF8  ret      

; System.Func<WeightRandomData, Vector3>$$BeginInvoke
; RVA 0x48DBAFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DBAFC  sub      sp, sp, #0x50
0048DBB00  str      x30, [sp, #0x10]
0048DBB04  stp      x24, x23, [sp, #0x20]
0048DBB08  stp      x22, x21, [sp, #0x30]
0048DBB0C  stp      x20, x19, [sp, #0x40]
0048DBB10  adrp     x24, #0x9591000
0048DBB14  adrp     x23, #0x8ee8000
0048DBB18  ldrb     w8, [x24, #0xfaa]
0048DBB1C  ldr      x23, [x23, #0x3d8]
0048DBB20  mov      x19, x3
0048DBB24  mov      x20, x2
0048DBB28  mov      x22, x1
0048DBB2C  mov      x21, x0
0048DBB30  tbnz     w8, #0, #0x48dbb48
0048DBB34  adrp     x0, #0x8ee8000
0048DBB38  ldr      x0, [x0, #0x3d8]
0048DBB3C  bl       #0x382bd14 ; 
0048DBB40  mov      w8, #1
0048DBB44  strb     w8, [x24, #0xfaa]
0048DBB48  ldr      x0, [x23]
0048DBB4C  mov      x1, x22
0048DBB50  str      xzr, [sp, #8]
0048DBB54  bl       #0x382be94 ; 
0048DBB58  str      x0, [sp]
0048DBB5C  mov      x1, sp
0048DBB60  mov      x0, x21
0048DBB64  mov      x2, x20
0048DBB68  mov      x3, x19
0048DBB6C  bl       #0x382bcc8 ; 
0048DBB70  ldp      x20, x19, [sp, #0x40]
0048DBB74  ldp      x22, x21, [sp, #0x30]
0048DBB78  ldp      x24, x23, [sp, #0x20]
0048DBB7C  ldr      x30, [sp, #0x10]
0048DBB80  add      sp, sp, #0x50
0048DBB84  ret      

; System.Func<WeightRandomData, Vector3>$$EndInvoke
; RVA 0x48DBB88; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DBB88  str      x30, [sp, #-0x10]!
0048DBB8C  mov      x0, x1
0048DBB90  mov      x1, xzr
0048DBB94  bl       #0x382bccc ; 
0048DBB98  cbz      x0, #0x48dbbb0
0048DBB9C  bl       #0x382be98 ; 
0048DBBA0  ldp      s0, s1, [x0]
0048DBBA4  ldr      s2, [x0, #8]
0048DBBA8  ldr      x30, [sp], #0x10
0048DBBAC  ret      
0048DBBB0  bl       #0x382bfb8 ; 

