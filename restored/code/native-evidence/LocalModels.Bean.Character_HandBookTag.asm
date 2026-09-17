; LocalModels.Bean.Character_HandBookTag$$readImpl
; RVA 0x68C7A20; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068C7A20  stp      x30, x21, [sp, #-0x20]!
0068C7A24  stp      x20, x19, [sp, #0x10]
0068C7A28  adrp     x20, #0x959c000
0068C7A2C  adrp     x21, #0x8f28000
0068C7A30  ldrb     w8, [x20, #0x2c2]
0068C7A34  ldr      x21, [x21, #0x38]
0068C7A38  mov      x19, x0
0068C7A3C  tbnz     w8, #0, #0x68c7a54
0068C7A40  adrp     x0, #0x8f28000
0068C7A44  ldr      x0, [x0, #0x38]
0068C7A48  bl       #0x382bd14 ; 
0068C7A4C  mov      w8, #1
0068C7A50  strb     w8, [x20, #0x2c2]
0068C7A54  ldr      x1, [x21]
0068C7A58  ldrb     w8, [x1, #0x53]
0068C7A5C  tbnz     w8, #5, #0x68c7aac
0068C7A60  mov      x0, x19
0068C7A64  mov      x1, xzr
0068C7A68  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C7A6C  adrp     x21, #0x959c000
0068C7A70  ldrb     w8, [x21, #0x6fa]
0068C7A74  mov      w20, w0
0068C7A78  cbnz     w8, #0x68c7a90
0068C7A7C  adrp     x0, #0x8f28000
0068C7A80  ldr      x0, [x0, #0x10]
0068C7A84  bl       #0x382bd14 ; 
0068C7A88  mov      w8, #1
0068C7A8C  strb     w8, [x21, #0x6fa]
0068C7A90  adrp     x8, #0x8f28000
0068C7A94  ldr      x8, [x8, #0x10]
0068C7A98  ldr      x2, [x8]
0068C7A9C  ldrb     w8, [x2, #0x53]
0068C7AA0  tbnz     w8, #5, #0x68c7ac0
0068C7AA4  str      w20, [x19, #0x20]
0068C7AA8  b        #0x68c7ad0 ; 
0068C7AAC  ldr      x2, [x1, #0x60]
0068C7AB0  mov      x0, x19
0068C7AB4  ldp      x20, x19, [sp, #0x10]
0068C7AB8  ldp      x30, x21, [sp], #0x20
0068C7ABC  br       x2
0068C7AC0  ldr      x8, [x2, #0x60]
0068C7AC4  mov      x0, x19
0068C7AC8  mov      w1, w20
0068C7ACC  blr      x8
0068C7AD0  mov      x0, x19
0068C7AD4  mov      x1, xzr
0068C7AD8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C7ADC  adrp     x21, #0x959c000
0068C7AE0  ldrb     w8, [x21, #0x6fb]
0068C7AE4  mov      w20, w0
0068C7AE8  cbnz     w8, #0x68c7b00
0068C7AEC  adrp     x0, #0x8f28000
0068C7AF0  ldr      x0, [x0, #0x20]
0068C7AF4  bl       #0x382bd14 ; 
0068C7AF8  mov      w8, #1
0068C7AFC  strb     w8, [x21, #0x6fb]
0068C7B00  adrp     x8, #0x8f28000
0068C7B04  ldr      x8, [x8, #0x20]
0068C7B08  ldr      x2, [x8]
0068C7B0C  ldrb     w8, [x2, #0x53]
0068C7B10  tbnz     w8, #5, #0x68c7b1c
0068C7B14  str      w20, [x19, #0x24]
0068C7B18  b        #0x68c7b2c ; 
0068C7B1C  ldr      x8, [x2, #0x60]
0068C7B20  mov      x0, x19
0068C7B24  mov      w1, w20
0068C7B28  blr      x8
0068C7B2C  mov      x0, x19
0068C7B30  mov      x1, xzr
0068C7B34  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C7B38  adrp     x21, #0x959c000
0068C7B3C  ldrb     w8, [x21, #0x6fc]
0068C7B40  mov      x20, x0
0068C7B44  cbnz     w8, #0x68c7b5c
0068C7B48  adrp     x0, #0x8f28000
0068C7B4C  ldr      x0, [x0, #0x30]
0068C7B50  bl       #0x382bd14 ; 
0068C7B54  mov      w8, #1
0068C7B58  strb     w8, [x21, #0x6fc]
0068C7B5C  adrp     x8, #0x8f28000
0068C7B60  ldr      x8, [x8, #0x30]
0068C7B64  ldr      x2, [x8]
0068C7B68  ldrb     w8, [x2, #0x53]
0068C7B6C  tbnz     w8, #5, #0x68c7b84
0068C7B70  str      x20, [x19, #0x28]!
0068C7B74  mov      x0, x19
0068C7B78  mov      x1, x20
0068C7B7C  bl       #0x382bcb8 ; 
0068C7B80  b        #0x68c7b94 ; 
0068C7B84  ldr      x8, [x2, #0x60]
0068C7B88  mov      x0, x19
0068C7B8C  mov      x1, x20
0068C7B90  blr      x8
0068C7B94  ldp      x20, x19, [sp, #0x10]
0068C7B98  mov      w0, #1
0068C7B9C  ldp      x30, x21, [sp], #0x20
0068C7BA0  ret      

