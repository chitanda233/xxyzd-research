; LocalModels.Bean.EventTurntable_EventTurntableDrawReward$$readImpl
; RVA 0x6A79998; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A79998  stp      x30, x21, [sp, #-0x20]!
006A7999C  stp      x20, x19, [sp, #0x10]
006A799A0  adrp     x20, #0x959d000
006A799A4  adrp     x21, #0x8f37000
006A799A8  ldrb     w8, [x20, #0xe8c]
006A799AC  ldr      x21, [x21, #0xcc8]
006A799B0  mov      x19, x0
006A799B4  tbnz     w8, #0, #0x6a799cc
006A799B8  adrp     x0, #0x8f37000
006A799BC  ldr      x0, [x0, #0xcc8]
006A799C0  bl       #0x382bd14 ; 
006A799C4  mov      w8, #1
006A799C8  strb     w8, [x20, #0xe8c]
006A799CC  ldr      x1, [x21]
006A799D0  ldrb     w8, [x1, #0x53]
006A799D4  tbnz     w8, #5, #0x6a79a24
006A799D8  mov      x0, x19
006A799DC  mov      x1, xzr
006A799E0  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A799E4  adrp     x21, #0x959e000
006A799E8  ldrb     w8, [x21, #0x4b8]
006A799EC  mov      w20, w0
006A799F0  cbnz     w8, #0x6a79a08
006A799F4  adrp     x0, #0x8f37000
006A799F8  ldr      x0, [x0, #0xca0]
006A799FC  bl       #0x382bd14 ; 
006A79A00  mov      w8, #1
006A79A04  strb     w8, [x21, #0x4b8]
006A79A08  adrp     x8, #0x8f37000
006A79A0C  ldr      x8, [x8, #0xca0]
006A79A10  ldr      x2, [x8]
006A79A14  ldrb     w8, [x2, #0x53]
006A79A18  tbnz     w8, #5, #0x6a79a38
006A79A1C  str      w20, [x19, #0x20]
006A79A20  b        #0x6a79a48 ; 
006A79A24  ldr      x2, [x1, #0x60]
006A79A28  mov      x0, x19
006A79A2C  ldp      x20, x19, [sp, #0x10]
006A79A30  ldp      x30, x21, [sp], #0x20
006A79A34  br       x2
006A79A38  ldr      x8, [x2, #0x60]
006A79A3C  mov      x0, x19
006A79A40  mov      w1, w20
006A79A44  blr      x8
006A79A48  mov      x0, x19
006A79A4C  mov      x1, xzr
006A79A50  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A79A54  adrp     x21, #0x959e000
006A79A58  ldrb     w8, [x21, #0x4b9]
006A79A5C  mov      w20, w0
006A79A60  cbnz     w8, #0x6a79a78
006A79A64  adrp     x0, #0x8f37000
006A79A68  ldr      x0, [x0, #0xcb0]
006A79A6C  bl       #0x382bd14 ; 
006A79A70  mov      w8, #1
006A79A74  strb     w8, [x21, #0x4b9]
006A79A78  adrp     x8, #0x8f37000
006A79A7C  ldr      x8, [x8, #0xcb0]
006A79A80  ldr      x2, [x8]
006A79A84  ldrb     w8, [x2, #0x53]
006A79A88  tbnz     w8, #5, #0x6a79a94
006A79A8C  str      w20, [x19, #0x24]
006A79A90  b        #0x6a79aa4 ; 
006A79A94  ldr      x8, [x2, #0x60]
006A79A98  mov      x0, x19
006A79A9C  mov      w1, w20
006A79AA0  blr      x8
006A79AA4  mov      x0, x19
006A79AA8  mov      x1, xzr
006A79AAC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A79AB0  adrp     x21, #0x959e000
006A79AB4  ldrb     w8, [x21, #0x4ba]
006A79AB8  mov      x20, x0
006A79ABC  cbnz     w8, #0x6a79ad4
006A79AC0  adrp     x0, #0x8f37000
006A79AC4  ldr      x0, [x0, #0xcc0]
006A79AC8  bl       #0x382bd14 ; 
006A79ACC  mov      w8, #1
006A79AD0  strb     w8, [x21, #0x4ba]
006A79AD4  adrp     x8, #0x8f37000
006A79AD8  ldr      x8, [x8, #0xcc0]
006A79ADC  ldr      x2, [x8]
006A79AE0  ldrb     w8, [x2, #0x53]
006A79AE4  tbnz     w8, #5, #0x6a79afc
006A79AE8  str      x20, [x19, #0x28]!
006A79AEC  mov      x0, x19
006A79AF0  mov      x1, x20
006A79AF4  bl       #0x382bcb8 ; 
006A79AF8  b        #0x6a79b0c ; 
006A79AFC  ldr      x8, [x2, #0x60]
006A79B00  mov      x0, x19
006A79B04  mov      x1, x20
006A79B08  blr      x8
006A79B0C  ldp      x20, x19, [sp, #0x10]
006A79B10  mov      w0, #1
006A79B14  ldp      x30, x21, [sp], #0x20
006A79B18  ret      

