; LocalModels.Bean.SkillGroup_AngelX$$readImpl
; RVA 0x6AF4980; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AF4980  stp      x30, x21, [sp, #-0x20]!
006AF4984  stp      x20, x19, [sp, #0x10]
006AF4988  adrp     x20, #0x959e000
006AF498C  adrp     x21, #0x8f3d000
006AF4990  ldrb     w8, [x20, #0xece]
006AF4994  ldr      x21, [x21, #0x948]
006AF4998  mov      x19, x0
006AF499C  tbnz     w8, #0, #0x6af49b4
006AF49A0  adrp     x0, #0x8f3d000
006AF49A4  ldr      x0, [x0, #0x948]
006AF49A8  bl       #0x382bd14 ; 
006AF49AC  mov      w8, #1
006AF49B0  strb     w8, [x20, #0xece]
006AF49B4  ldr      x1, [x21]
006AF49B8  ldrb     w8, [x1, #0x53]
006AF49BC  tbnz     w8, #5, #0x6af4a0c
006AF49C0  mov      x0, x19
006AF49C4  mov      x1, xzr
006AF49C8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF49CC  adrp     x21, #0x959f000
006AF49D0  ldrb     w8, [x21, #0x272]
006AF49D4  mov      w20, w0
006AF49D8  cbnz     w8, #0x6af49f0
006AF49DC  adrp     x0, #0x8f3d000
006AF49E0  ldr      x0, [x0, #0x920]
006AF49E4  bl       #0x382bd14 ; 
006AF49E8  mov      w8, #1
006AF49EC  strb     w8, [x21, #0x272]
006AF49F0  adrp     x8, #0x8f3d000
006AF49F4  ldr      x8, [x8, #0x920]
006AF49F8  ldr      x2, [x8]
006AF49FC  ldrb     w8, [x2, #0x53]
006AF4A00  tbnz     w8, #5, #0x6af4a20
006AF4A04  str      w20, [x19, #0x20]
006AF4A08  b        #0x6af4a30 ; 
006AF4A0C  ldr      x2, [x1, #0x60]
006AF4A10  mov      x0, x19
006AF4A14  ldp      x20, x19, [sp, #0x10]
006AF4A18  ldp      x30, x21, [sp], #0x20
006AF4A1C  br       x2
006AF4A20  ldr      x8, [x2, #0x60]
006AF4A24  mov      x0, x19
006AF4A28  mov      w1, w20
006AF4A2C  blr      x8
006AF4A30  mov      x0, x19
006AF4A34  mov      x1, xzr
006AF4A38  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF4A3C  adrp     x21, #0x959f000
006AF4A40  ldrb     w8, [x21, #0x273]
006AF4A44  mov      w20, w0
006AF4A48  cbnz     w8, #0x6af4a60
006AF4A4C  adrp     x0, #0x8f3d000
006AF4A50  ldr      x0, [x0, #0x930]
006AF4A54  bl       #0x382bd14 ; 
006AF4A58  mov      w8, #1
006AF4A5C  strb     w8, [x21, #0x273]
006AF4A60  adrp     x8, #0x8f3d000
006AF4A64  ldr      x8, [x8, #0x930]
006AF4A68  ldr      x2, [x8]
006AF4A6C  ldrb     w8, [x2, #0x53]
006AF4A70  tbnz     w8, #5, #0x6af4a7c
006AF4A74  str      w20, [x19, #0x24]
006AF4A78  b        #0x6af4a8c ; 
006AF4A7C  ldr      x8, [x2, #0x60]
006AF4A80  mov      x0, x19
006AF4A84  mov      w1, w20
006AF4A88  blr      x8
006AF4A8C  mov      x0, x19
006AF4A90  mov      x1, xzr
006AF4A94  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AF4A98  adrp     x21, #0x959f000
006AF4A9C  ldrb     w8, [x21, #0x274]
006AF4AA0  mov      w20, w0
006AF4AA4  cbnz     w8, #0x6af4abc
006AF4AA8  adrp     x0, #0x8f3d000
006AF4AAC  ldr      x0, [x0, #0x940]
006AF4AB0  bl       #0x382bd14 ; 
006AF4AB4  mov      w8, #1
006AF4AB8  strb     w8, [x21, #0x274]
006AF4ABC  adrp     x8, #0x8f3d000
006AF4AC0  ldr      x8, [x8, #0x940]
006AF4AC4  ldr      x2, [x8]
006AF4AC8  ldrb     w8, [x2, #0x53]
006AF4ACC  tbnz     w8, #5, #0x6af4ad8
006AF4AD0  str      w20, [x19, #0x28]
006AF4AD4  b        #0x6af4ae8 ; 
006AF4AD8  ldr      x8, [x2, #0x60]
006AF4ADC  mov      x0, x19
006AF4AE0  mov      w1, w20
006AF4AE4  blr      x8
006AF4AE8  ldp      x20, x19, [sp, #0x10]
006AF4AEC  mov      w0, #1
006AF4AF0  ldp      x30, x21, [sp], #0x20
006AF4AF4  ret      

