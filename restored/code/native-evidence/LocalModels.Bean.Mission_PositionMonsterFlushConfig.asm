; LocalModels.Bean.Mission_PositionMonsterFlushConfig$$readImpl
; RVA 0x6AC2948; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AC2948  stp      x30, x21, [sp, #-0x20]!
006AC294C  stp      x20, x19, [sp, #0x10]
006AC2950  adrp     x20, #0x959e000
006AC2954  adrp     x21, #0x8f3b000
006AC2958  ldrb     w8, [x20, #0x9a0]
006AC295C  ldr      x21, [x21, #0x3c0]
006AC2960  mov      x19, x0
006AC2964  tbnz     w8, #0, #0x6ac297c
006AC2968  adrp     x0, #0x8f3b000
006AC296C  ldr      x0, [x0, #0x3c0]
006AC2970  bl       #0x382bd14 ; 
006AC2974  mov      w8, #1
006AC2978  strb     w8, [x20, #0x9a0]
006AC297C  ldr      x1, [x21]
006AC2980  ldrb     w8, [x1, #0x53]
006AC2984  tbnz     w8, #5, #0x6ac29d4
006AC2988  mov      x0, x19
006AC298C  mov      x1, xzr
006AC2990  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AC2994  adrp     x21, #0x959f000
006AC2998  ldrb     w8, [x21, #0x48]
006AC299C  mov      w20, w0
006AC29A0  cbnz     w8, #0x6ac29b8
006AC29A4  adrp     x0, #0x8f3b000
006AC29A8  ldr      x0, [x0, #0x3a0]
006AC29AC  bl       #0x382bd14 ; 
006AC29B0  mov      w8, #1
006AC29B4  strb     w8, [x21, #0x48]
006AC29B8  adrp     x8, #0x8f3b000
006AC29BC  ldr      x8, [x8, #0x3a0]
006AC29C0  ldr      x2, [x8]
006AC29C4  ldrb     w8, [x2, #0x53]
006AC29C8  tbnz     w8, #5, #0x6ac29e8
006AC29CC  str      w20, [x19, #0x20]
006AC29D0  b        #0x6ac29f8 ; 
006AC29D4  ldr      x2, [x1, #0x60]
006AC29D8  mov      x0, x19
006AC29DC  ldp      x20, x19, [sp, #0x10]
006AC29E0  ldp      x30, x21, [sp], #0x20
006AC29E4  br       x2
006AC29E8  ldr      x8, [x2, #0x60]
006AC29EC  mov      x0, x19
006AC29F0  mov      w1, w20
006AC29F4  blr      x8
006AC29F8  mov      x0, x19
006AC29FC  mov      x1, xzr
006AC2A00  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AC2A04  adrp     x21, #0x959f000
006AC2A08  ldrb     w8, [x21, #0x49]
006AC2A0C  mov      x20, x0
006AC2A10  cbnz     w8, #0x6ac2a28
006AC2A14  adrp     x0, #0x8f3b000
006AC2A18  ldr      x0, [x0, #0x3a8]
006AC2A1C  bl       #0x382bd14 ; 
006AC2A20  mov      w8, #1
006AC2A24  strb     w8, [x21, #0x49]
006AC2A28  adrp     x8, #0x8f3b000
006AC2A2C  ldr      x8, [x8, #0x3a8]
006AC2A30  ldr      x2, [x8]
006AC2A34  ldrb     w8, [x2, #0x53]
006AC2A38  tbnz     w8, #5, #0x6ac2a50
006AC2A3C  mov      x0, x19
006AC2A40  str      x20, [x0, #0x28]!
006AC2A44  mov      x1, x20
006AC2A48  bl       #0x382bcb8 ; 
006AC2A4C  b        #0x6ac2a60 ; 
006AC2A50  ldr      x8, [x2, #0x60]
006AC2A54  mov      x0, x19
006AC2A58  mov      x1, x20
006AC2A5C  blr      x8
006AC2A60  mov      x0, x19
006AC2A64  mov      x1, xzr
006AC2A68  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006AC2A6C  adrp     x21, #0x959f000
006AC2A70  ldrb     w8, [x21, #0x4a]
006AC2A74  mov      x20, x0
006AC2A78  cbnz     w8, #0x6ac2a90
006AC2A7C  adrp     x0, #0x8f3b000
006AC2A80  ldr      x0, [x0, #0x3b8]
006AC2A84  bl       #0x382bd14 ; 
006AC2A88  mov      w8, #1
006AC2A8C  strb     w8, [x21, #0x4a]
006AC2A90  adrp     x8, #0x8f3b000
006AC2A94  ldr      x8, [x8, #0x3b8]
006AC2A98  ldr      x2, [x8]
006AC2A9C  ldrb     w8, [x2, #0x53]
006AC2AA0  tbnz     w8, #5, #0x6ac2ab8
006AC2AA4  str      x20, [x19, #0x30]!
006AC2AA8  mov      x0, x19
006AC2AAC  mov      x1, x20
006AC2AB0  bl       #0x382bcb8 ; 
006AC2AB4  b        #0x6ac2ac8 ; 
006AC2AB8  ldr      x8, [x2, #0x60]
006AC2ABC  mov      x0, x19
006AC2AC0  mov      x1, x20
006AC2AC4  blr      x8
006AC2AC8  ldp      x20, x19, [sp, #0x10]
006AC2ACC  mov      w0, #1
006AC2AD0  ldp      x30, x21, [sp], #0x20
006AC2AD4  ret      

