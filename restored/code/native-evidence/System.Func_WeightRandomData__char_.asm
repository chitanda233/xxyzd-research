; System.Func<WeightRandomData, char>$$.ctor
; RVA 0x48DB23C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB23C  str      x30, [sp, #-0x30]!
0048DB240  stp      x22, x21, [sp, #0x10]
0048DB244  stp      x20, x19, [sp, #0x20]
0048DB248  ldr      x8, [x2, #8]
0048DB24C  mov      x19, x0
0048DB250  str      x2, [x0, #0x28]
0048DB254  mov      x21, x2
0048DB258  str      x8, [x0, #0x10]
0048DB25C  str      x1, [x0, #0x20]!
0048DB260  mov      x20, x1
0048DB264  bl       #0x382bcb8 ; 
0048DB268  ldrb     w22, [x21, #0x52]
0048DB26C  mov      x0, x21
0048DB270  str      x19, [x19, #0x40]
0048DB274  bl       #0x382be14 ; 
0048DB278  tbz      w0, #0, #0x48db294
0048DB27C  cmp      w22, #1
0048DB280  b.ne     #0x48db298
0048DB284  adrp     x8, #0x3475000
0048DB288  add      x8, x8, #0x20
0048DB28C  str      x8, [x19, #0x18]
0048DB290  b        #0x48db2a8 ; 
0048DB294  cbz      x20, #0x48db2c4
0048DB298  ldr      x8, [x19, #0x10]
0048DB29C  ldr      x9, [x19, #0x20]
0048DB2A0  str      x8, [x19, #0x18]
0048DB2A4  str      x9, [x19, #0x40]
0048DB2A8  adrp     x8, #0x3474000
0048DB2AC  add      x8, x8, #0xfb0
0048DB2B0  str      x8, [x19, #0x38]
0048DB2B4  ldp      x20, x19, [sp, #0x20]
0048DB2B8  ldp      x22, x21, [sp, #0x10]
0048DB2BC  ldr      x30, [sp], #0x30
0048DB2C0  ret      
0048DB2C4  adrp     x1, #0x1a2d000
0048DB2C8  add      x1, x1, #0x4e9
0048DB2CC  mov      x0, xzr
0048DB2D0  bl       #0x382bfd4 ; 
0048DB2D4  mov      x1, xzr
0048DB2D8  bl       #0x382be7c ; 

; System.Func<WeightRandomData, char>$$Invoke
; RVA 0x48DB2DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB2DC  sub      sp, sp, #0x50
0048DB2E0  str      x30, [sp, #0x40]
0048DB2E4  ldp      q2, q0, [x1, #0x10]
0048DB2E8  ldr      x10, [x1, #0x30]
0048DB2EC  ldr      q1, [x1]
0048DB2F0  ldr      x9, [x0, #0x18]
0048DB2F4  ldr      x8, [x0, #0x40]
0048DB2F8  str      x10, [sp, #0x30]
0048DB2FC  stp      q2, q0, [sp, #0x10]
0048DB300  str      q1, [sp]
0048DB304  ldr      x2, [x0, #0x28]
0048DB308  mov      x1, sp
0048DB30C  mov      x0, x8
0048DB310  blr      x9
0048DB314  ldr      x30, [sp, #0x40]
0048DB318  add      sp, sp, #0x50
0048DB31C  ret      

; System.Func<WeightRandomData, char>$$BeginInvoke
; RVA 0x48DB320; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB320  sub      sp, sp, #0x50
0048DB324  str      x30, [sp, #0x10]
0048DB328  stp      x24, x23, [sp, #0x20]
0048DB32C  stp      x22, x21, [sp, #0x30]
0048DB330  stp      x20, x19, [sp, #0x40]
0048DB334  adrp     x24, #0x9591000
0048DB338  adrp     x23, #0x8ee8000
0048DB33C  ldrb     w8, [x24, #0xfa5]
0048DB340  ldr      x23, [x23, #0x3d8]
0048DB344  mov      x19, x3
0048DB348  mov      x20, x2
0048DB34C  mov      x22, x1
0048DB350  mov      x21, x0
0048DB354  tbnz     w8, #0, #0x48db36c
0048DB358  adrp     x0, #0x8ee8000
0048DB35C  ldr      x0, [x0, #0x3d8]
0048DB360  bl       #0x382bd14 ; 
0048DB364  mov      w8, #1
0048DB368  strb     w8, [x24, #0xfa5]
0048DB36C  ldr      x0, [x23]
0048DB370  mov      x1, x22
0048DB374  str      xzr, [sp, #8]
0048DB378  bl       #0x382be94 ; 
0048DB37C  str      x0, [sp]
0048DB380  mov      x1, sp
0048DB384  mov      x0, x21
0048DB388  mov      x2, x20
0048DB38C  mov      x3, x19
0048DB390  bl       #0x382bcc8 ; 
0048DB394  ldp      x20, x19, [sp, #0x40]
0048DB398  ldp      x22, x21, [sp, #0x30]
0048DB39C  ldp      x24, x23, [sp, #0x20]
0048DB3A0  ldr      x30, [sp, #0x10]
0048DB3A4  add      sp, sp, #0x50
0048DB3A8  ret      

; System.Func<WeightRandomData, char>$$EndInvoke
; RVA 0x48DB3AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0048DB3AC  str      x30, [sp, #-0x10]!
0048DB3B0  mov      x0, x1
0048DB3B4  mov      x1, xzr
0048DB3B8  bl       #0x382bccc ; 
0048DB3BC  cbz      x0, #0x48db3d0
0048DB3C0  bl       #0x382be98 ; 
0048DB3C4  ldrh     w0, [x0]
0048DB3C8  ldr      x30, [sp], #0x10
0048DB3CC  ret      
0048DB3D0  bl       #0x382bfb8 ; 

