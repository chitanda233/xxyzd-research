; LocalModels.Bean.AttributeAbility_string$$readImpl
; RVA 0x6701A30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006701A30  str      d8, [sp, #-0x30]!
006701A34  stp      x30, x21, [sp, #0x10]
006701A38  stp      x20, x19, [sp, #0x20]
006701A3C  adrp     x20, #0x959a000
006701A40  adrp     x21, #0x8f17000
006701A44  ldrb     w8, [x20, #0x8a9]
006701A48  ldr      x21, [x21, #0x760]
006701A4C  mov      x19, x0
006701A50  tbnz     w8, #0, #0x6701a68
006701A54  adrp     x0, #0x8f17000
006701A58  ldr      x0, [x0, #0x760]
006701A5C  bl       #0x382bd14 ; 
006701A60  mov      w8, #1
006701A64  strb     w8, [x20, #0x8a9]
006701A68  ldr      x1, [x21]
006701A6C  ldrb     w8, [x1, #0x53]
006701A70  tbnz     w8, #5, #0x6701ac0
006701A74  mov      x0, x19
006701A78  mov      x1, xzr
006701A7C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006701A80  adrp     x21, #0x959a000
006701A84  ldrb     w8, [x21, #0x960]
006701A88  mov      w20, w0
006701A8C  cbnz     w8, #0x6701aa4
006701A90  adrp     x0, #0x8f17000
006701A94  ldr      x0, [x0, #0x748]
006701A98  bl       #0x382bd14 ; 
006701A9C  mov      w8, #1
006701AA0  strb     w8, [x21, #0x960]
006701AA4  adrp     x8, #0x8f17000
006701AA8  ldr      x8, [x8, #0x748]
006701AAC  ldr      x2, [x8]
006701AB0  ldrb     w8, [x2, #0x53]
006701AB4  tbnz     w8, #5, #0x6701ad8
006701AB8  str      w20, [x19, #0x20]
006701ABC  b        #0x6701ae8 ; 
006701AC0  ldr      x2, [x1, #0x60]
006701AC4  mov      x0, x19
006701AC8  ldp      x20, x19, [sp, #0x20]
006701ACC  ldp      x30, x21, [sp, #0x10]
006701AD0  ldr      d8, [sp], #0x30
006701AD4  br       x2
006701AD8  ldr      x8, [x2, #0x60]
006701ADC  mov      x0, x19
006701AE0  mov      w1, w20
006701AE4  blr      x8
006701AE8  mov      x0, x19
006701AEC  mov      x1, xzr
006701AF0  bl       #0x64ca308 ; LocalModels.BaseLocalBean$$readFloat
006701AF4  adrp     x20, #0x959a000
006701AF8  ldrb     w8, [x20, #0x961]
006701AFC  mov      v8.16b, v0.16b
006701B00  cbnz     w8, #0x6701b18
006701B04  adrp     x0, #0x8f17000
006701B08  ldr      x0, [x0, #0x758]
006701B0C  bl       #0x382bd14 ; 
006701B10  mov      w8, #1
006701B14  strb     w8, [x20, #0x961]
006701B18  adrp     x8, #0x8f17000
006701B1C  ldr      x8, [x8, #0x758]
006701B20  ldr      x1, [x8]
006701B24  ldrb     w8, [x1, #0x53]
006701B28  tbnz     w8, #5, #0x6701b34
006701B2C  str      s8, [x19, #0x24]
006701B30  b        #0x6701b44 ; 
006701B34  ldr      x8, [x1, #0x60]
006701B38  mov      x0, x19
006701B3C  mov      v0.16b, v8.16b
006701B40  blr      x8
006701B44  ldp      x20, x19, [sp, #0x20]
006701B48  ldp      x30, x21, [sp, #0x10]
006701B4C  mov      w0, #1
006701B50  ldr      d8, [sp], #0x30
006701B54  ret      

