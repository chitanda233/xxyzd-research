; MissionData$$ReadPos
; RVA 0x64C7904; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0064C7904  stp      x30, x23, [sp, #-0x30]!
0064C7908  stp      x22, x21, [sp, #0x10]
0064C790C  stp      x20, x19, [sp, #0x20]
0064C7910  adrp     x22, #0x9597000
0064C7914  adrp     x23, #0x8ef9000
0064C7918  ldrb     w8, [x22, #0xfa4]
0064C791C  ldr      x23, [x23, #0xe58] ; GLOBAL Method$MissionData.ReadPos()
0064C7920  mov      x19, x2
0064C7924  mov      x20, x1
0064C7928  mov      x21, x0
0064C792C  tbnz     w8, #0, #0x64c7944
0064C7930  adrp     x0, #0x8ef9000
0064C7934  ldr      x0, [x0, #0xe58] ; GLOBAL Method$MissionData.ReadPos()
0064C7938  bl       #0x382bd14 ; 
0064C793C  mov      w8, #1
0064C7940  strb     w8, [x22, #0xfa4]
0064C7944  ldr      x3, [x23]
0064C7948  ldrb     w8, [x3, #0x53]
0064C794C  tbnz     w8, #5, #0x64c79ac
0064C7950  cbz      x20, #0x64c79cc
0064C7954  ldr      x8, [x20]
0064C7958  mov      x0, x20
0064C795C  ldr      x9, [x8, #0x258]
0064C7960  ldr      x1, [x8, #0x260]
0064C7964  blr      x9
0064C7968  str      x0, [x19]
0064C796C  ldr      x8, [x20]
0064C7970  mov      x0, x20
0064C7974  ldr      x9, [x8, #0x258]
0064C7978  ldr      x1, [x8, #0x260]
0064C797C  blr      x9
0064C7980  str      x0, [x19, #8]
0064C7984  ldr      x8, [x20]
0064C7988  mov      x0, x20
0064C798C  ldr      x9, [x8, #0x258]
0064C7990  ldr      x1, [x8, #0x260]
0064C7994  blr      x9
0064C7998  str      x0, [x19, #0x10]
0064C799C  ldp      x20, x19, [sp, #0x20]
0064C79A0  ldp      x22, x21, [sp, #0x10]
0064C79A4  ldp      x30, x23, [sp], #0x30
0064C79A8  ret      
0064C79AC  ldr      x4, [x3, #0x60]
0064C79B0  mov      x0, x21
0064C79B4  mov      x1, x20
0064C79B8  mov      x2, x19
0064C79BC  ldp      x20, x19, [sp, #0x20]
0064C79C0  ldp      x22, x21, [sp, #0x10]
0064C79C4  ldp      x30, x23, [sp], #0x30
0064C79C8  br       x4
0064C79CC  bl       #0x382bfb8 ; 

