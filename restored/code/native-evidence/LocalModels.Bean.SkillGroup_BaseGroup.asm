; LocalModels.Bean.SkillGroup_BaseGroup$$readImpl
; RVA 0x6AF4F64; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF4F64  stp      x30, x21, [sp, #-0x20]!
006AF4F68  stp      x20, x19, [sp, #0x10]
006AF4F6C  adrp     x20, #0x959e000
006AF4F70  adrp     x21, #0x8f3d000
006AF4F74  ldrb     w8, [x20, #0xed8]
006AF4F78  ldr      x21, [x21, #0x990]
006AF4F7C  mov      x19, x0
006AF4F80  tbnz     w8, #0, #0x6af4f98
006AF4F84  adrp     x0, #0x8f3d000
006AF4F88  ldr      x0, [x0, #0x990]
006AF4F8C  bl       #0x382bd14 ; 
006AF4F90  mov      w8, #1
006AF4F94  strb     w8, [x20, #0xed8]
006AF4F98  ldr      x1, [x21]
006AF4F9C  ldrb     w8, [x1, #0x53]
006AF4FA0  tbnz     w8, #5, #0x6af4ff0
006AF4FA4  mov      x0, x19
006AF4FA8  mov      x1, xzr
006AF4FAC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF4FB0  adrp     x21, #0x959f000
006AF4FB4  ldrb     w8, [x21, #0x276]
006AF4FB8  mov      w20, w0
006AF4FBC  cbnz     w8, #0x6af4fd4
006AF4FC0  adrp     x0, #0x8f3d000
006AF4FC4  ldr      x0, [x0, #0x968]
006AF4FC8  bl       #0x382bd14 ; 
006AF4FCC  mov      w8, #1
006AF4FD0  strb     w8, [x21, #0x276]
006AF4FD4  adrp     x8, #0x8f3d000
006AF4FD8  ldr      x8, [x8, #0x968]
006AF4FDC  ldr      x2, [x8]
006AF4FE0  ldrb     w8, [x2, #0x53]
006AF4FE4  tbnz     w8, #5, #0x6af5004
006AF4FE8  str      w20, [x19, #0x20]
006AF4FEC  b        #0x6af5014 ; 
006AF4FF0  ldr      x2, [x1, #0x60]
006AF4FF4  mov      x0, x19
006AF4FF8  ldp      x20, x19, [sp, #0x10]
006AF4FFC  ldp      x30, x21, [sp], #0x20
006AF5000  br       x2
006AF5004  ldr      x8, [x2, #0x60]
006AF5008  mov      x0, x19
006AF500C  mov      w1, w20
006AF5010  blr      x8
006AF5014  mov      x0, x19
006AF5018  mov      x1, xzr
006AF501C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF5020  adrp     x21, #0x959f000
006AF5024  ldrb     w8, [x21, #0x277]
006AF5028  mov      w20, w0
006AF502C  cbnz     w8, #0x6af5044
006AF5030  adrp     x0, #0x8f3d000
006AF5034  ldr      x0, [x0, #0x978]
006AF5038  bl       #0x382bd14 ; 
006AF503C  mov      w8, #1
006AF5040  strb     w8, [x21, #0x277]
006AF5044  adrp     x8, #0x8f3d000
006AF5048  ldr      x8, [x8, #0x978]
006AF504C  ldr      x2, [x8]
006AF5050  ldrb     w8, [x2, #0x53]
006AF5054  tbnz     w8, #5, #0x6af5060
006AF5058  str      w20, [x19, #0x24]
006AF505C  b        #0x6af5070 ; 
006AF5060  ldr      x8, [x2, #0x60]
006AF5064  mov      x0, x19
006AF5068  mov      w1, w20
006AF506C  blr      x8
006AF5070  mov      x0, x19
006AF5074  mov      x1, xzr
006AF5078  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF507C  adrp     x21, #0x959f000
006AF5080  ldrb     w8, [x21, #0x278]
006AF5084  mov      w20, w0
006AF5088  cbnz     w8, #0x6af50a0
006AF508C  adrp     x0, #0x8f3d000
006AF5090  ldr      x0, [x0, #0x988]
006AF5094  bl       #0x382bd14 ; 
006AF5098  mov      w8, #1
006AF509C  strb     w8, [x21, #0x278]
006AF50A0  adrp     x8, #0x8f3d000
006AF50A4  ldr      x8, [x8, #0x988]
006AF50A8  ldr      x2, [x8]
006AF50AC  ldrb     w8, [x2, #0x53]
006AF50B0  tbnz     w8, #5, #0x6af50bc
006AF50B4  str      w20, [x19, #0x28]
006AF50B8  b        #0x6af50cc ; 
006AF50BC  ldr      x8, [x2, #0x60]
006AF50C0  mov      x0, x19
006AF50C4  mov      w1, w20
006AF50C8  blr      x8
006AF50CC  ldp      x20, x19, [sp, #0x10]
006AF50D0  mov      w0, #1
006AF50D4  ldp      x30, x21, [sp], #0x20
006AF50D8  ret      

