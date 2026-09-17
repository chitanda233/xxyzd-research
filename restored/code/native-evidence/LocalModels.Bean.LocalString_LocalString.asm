; LocalModels.Bean.LocalString_LocalString$$readImpl
; RVA 0x6AB399C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AB399C  stp      x30, x21, [sp, #-0x20]!
006AB39A0  stp      x20, x19, [sp, #0x10]
006AB39A4  adrp     x20, #0x959e000
006AB39A8  adrp     x21, #0x8f3a000
006AB39AC  ldrb     w8, [x20, #0x818]
006AB39B0  ldr      x21, [x21, #0x8b0]
006AB39B4  mov      x19, x0
006AB39B8  tbnz     w8, #0, #0x6ab39d0
006AB39BC  adrp     x0, #0x8f3a000
006AB39C0  ldr      x0, [x0, #0x8b0]
006AB39C4  bl       #0x382bd14 ; 
006AB39C8  mov      w8, #1
006AB39CC  strb     w8, [x20, #0x818]
006AB39D0  ldr      x1, [x21]
006AB39D4  ldrb     w8, [x1, #0x53]
006AB39D8  tbnz     w8, #5, #0x6ab3a34
006AB39DC  mov      x0, x19
006AB39E0  mov      x1, xzr
006AB39E4  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB39E8  adrp     x21, #0x959e000
006AB39EC  ldrb     w8, [x21, #0xf97]
006AB39F0  mov      x20, x0
006AB39F4  cbnz     w8, #0x6ab3a0c
006AB39F8  adrp     x0, #0x8f3a000
006AB39FC  ldr      x0, [x0, #0x898]
006AB3A00  bl       #0x382bd14 ; 
006AB3A04  mov      w8, #1
006AB3A08  strb     w8, [x21, #0xf97]
006AB3A0C  adrp     x8, #0x8f3a000
006AB3A10  ldr      x8, [x8, #0x898]
006AB3A14  ldr      x2, [x8]
006AB3A18  ldrb     w8, [x2, #0x53]
006AB3A1C  tbnz     w8, #5, #0x6ab3a48
006AB3A20  mov      x0, x19
006AB3A24  str      x20, [x0, #0x20]!
006AB3A28  mov      x1, x20
006AB3A2C  bl       #0x382bcb8 ; 
006AB3A30  b        #0x6ab3a58 ; 
006AB3A34  ldr      x2, [x1, #0x60]
006AB3A38  mov      x0, x19
006AB3A3C  ldp      x20, x19, [sp, #0x10]
006AB3A40  ldp      x30, x21, [sp], #0x20
006AB3A44  br       x2
006AB3A48  ldr      x8, [x2, #0x60]
006AB3A4C  mov      x0, x19
006AB3A50  mov      x1, x20
006AB3A54  blr      x8
006AB3A58  mov      x0, x19
006AB3A5C  mov      x1, xzr
006AB3A60  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006AB3A64  adrp     x21, #0x959e000
006AB3A68  ldrb     w8, [x21, #0xf98]
006AB3A6C  mov      x20, x0
006AB3A70  cbnz     w8, #0x6ab3a88
006AB3A74  adrp     x0, #0x8f3a000
006AB3A78  ldr      x0, [x0, #0x8a8]
006AB3A7C  bl       #0x382bd14 ; 
006AB3A80  mov      w8, #1
006AB3A84  strb     w8, [x21, #0xf98]
006AB3A88  adrp     x8, #0x8f3a000
006AB3A8C  ldr      x8, [x8, #0x8a8]
006AB3A90  ldr      x2, [x8]
006AB3A94  ldrb     w8, [x2, #0x53]
006AB3A98  tbnz     w8, #5, #0x6ab3ab0
006AB3A9C  str      x20, [x19, #0x28]!
006AB3AA0  mov      x0, x19
006AB3AA4  mov      x1, x20
006AB3AA8  bl       #0x382bcb8 ; 
006AB3AAC  b        #0x6ab3ac0 ; 
006AB3AB0  ldr      x8, [x2, #0x60]
006AB3AB4  mov      x0, x19
006AB3AB8  mov      x1, x20
006AB3ABC  blr      x8
006AB3AC0  ldp      x20, x19, [sp, #0x10]
006AB3AC4  mov      w0, #1
006AB3AC8  ldp      x30, x21, [sp], #0x20
006AB3ACC  ret      

