; System.Action<WeightRandomData>$$.ctor
; RVA 0x6034E9C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006034E9C  str      x30, [sp, #-0x30]!
006034EA0  stp      x22, x21, [sp, #0x10]
006034EA4  stp      x20, x19, [sp, #0x20]
006034EA8  ldr      x8, [x2, #8]
006034EAC  mov      x19, x0
006034EB0  str      x2, [x0, #0x28]
006034EB4  mov      x21, x2
006034EB8  str      x8, [x0, #0x10]
006034EBC  str      x1, [x0, #0x20]!
006034EC0  mov      x20, x1
006034EC4  bl       #0x382bcb8 ; 
006034EC8  ldrb     w22, [x21, #0x52]
006034ECC  mov      x0, x21
006034ED0  str      x19, [x19, #0x40]
006034ED4  bl       #0x382be14 ; 
006034ED8  tbz      w0, #0, #0x6034ef4
006034EDC  cmp      w22, #1
006034EE0  b.ne     #0x6034ef8
006034EE4  adrp     x8, #0x3512000
006034EE8  add      x8, x8, #0x8a0
006034EEC  str      x8, [x19, #0x18]
006034EF0  b        #0x6034f08 ; 
006034EF4  cbz      x20, #0x6034f24
006034EF8  ldr      x8, [x19, #0x10]
006034EFC  ldr      x9, [x19, #0x20]
006034F00  str      x8, [x19, #0x18]
006034F04  str      x9, [x19, #0x40]
006034F08  adrp     x8, #0x3512000
006034F0C  add      x8, x8, #0x838
006034F10  str      x8, [x19, #0x38]
006034F14  ldp      x20, x19, [sp, #0x20]
006034F18  ldp      x22, x21, [sp, #0x10]
006034F1C  ldr      x30, [sp], #0x30
006034F20  ret      
006034F24  adrp     x1, #0x1a2d000
006034F28  add      x1, x1, #0x4e9
006034F2C  mov      x0, xzr
006034F30  bl       #0x382bfd4 ; 
006034F34  mov      x1, xzr
006034F38  bl       #0x382be7c ; 

; System.Action<WeightRandomData>$$Invoke
; RVA 0x6034F3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006034F3C  sub      sp, sp, #0x50
006034F40  str      x30, [sp, #0x40]
006034F44  ldp      q2, q0, [x1, #0x10]
006034F48  ldr      x10, [x1, #0x30]
006034F4C  ldr      q1, [x1]
006034F50  ldr      x9, [x0, #0x18]
006034F54  ldr      x8, [x0, #0x40]
006034F58  str      x10, [sp, #0x30]
006034F5C  stp      q2, q0, [sp, #0x10]
006034F60  str      q1, [sp]
006034F64  ldr      x2, [x0, #0x28]
006034F68  mov      x1, sp
006034F6C  mov      x0, x8
006034F70  blr      x9
006034F74  ldr      x30, [sp, #0x40]
006034F78  add      sp, sp, #0x50
006034F7C  ret      

; System.Action<WeightRandomData>$$BeginInvoke
; RVA 0x6034F80; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006034F80  sub      sp, sp, #0x50
006034F84  str      x30, [sp, #0x10]
006034F88  stp      x24, x23, [sp, #0x20]
006034F8C  stp      x22, x21, [sp, #0x30]
006034F90  stp      x20, x19, [sp, #0x40]
006034F94  adrp     x24, #0x9596000
006034F98  adrp     x23, #0x8ee8000
006034F9C  ldrb     w8, [x24, #0x797]
006034FA0  ldr      x23, [x23, #0x3d8]
006034FA4  mov      x19, x3
006034FA8  mov      x20, x2
006034FAC  mov      x22, x1
006034FB0  mov      x21, x0
006034FB4  tbnz     w8, #0, #0x6034fcc
006034FB8  adrp     x0, #0x8ee8000
006034FBC  ldr      x0, [x0, #0x3d8]
006034FC0  bl       #0x382bd14 ; 
006034FC4  mov      w8, #1
006034FC8  strb     w8, [x24, #0x797]
006034FCC  ldr      x0, [x23]
006034FD0  mov      x1, x22
006034FD4  str      xzr, [sp, #8]
006034FD8  bl       #0x382be94 ; 
006034FDC  str      x0, [sp]
006034FE0  mov      x1, sp
006034FE4  mov      x0, x21
006034FE8  mov      x2, x20
006034FEC  mov      x3, x19
006034FF0  bl       #0x382bcc8 ; 
006034FF4  ldp      x20, x19, [sp, #0x40]
006034FF8  ldp      x22, x21, [sp, #0x30]
006034FFC  ldp      x24, x23, [sp, #0x20]
006035000  ldr      x30, [sp, #0x10]
006035004  add      sp, sp, #0x50
006035008  ret      

; System.Action<WeightRandomData>$$EndInvoke
; RVA 0x603500C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00603500C  mov      x0, x1
006035010  mov      x1, xzr
006035014  b        #0x382bccc ; 

