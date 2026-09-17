; LocalModels.Bean.Consts_Const$$readImpl
; RVA 0x68D09B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D09B0  stp      x30, x21, [sp, #-0x20]!
0068D09B4  stp      x20, x19, [sp, #0x10]
0068D09B8  adrp     x20, #0x959c000
0068D09BC  adrp     x21, #0x8f28000
0068D09C0  ldrb     w8, [x20, #0x3b6]
0068D09C4  ldr      x21, [x21, #0x6f8]
0068D09C8  mov      x19, x0
0068D09CC  tbnz     w8, #0, #0x68d09e4
0068D09D0  adrp     x0, #0x8f28000
0068D09D4  ldr      x0, [x0, #0x6f8]
0068D09D8  bl       #0x382bd14 ; 
0068D09DC  mov      w8, #1
0068D09E0  strb     w8, [x20, #0x3b6]
0068D09E4  ldr      x1, [x21]
0068D09E8  ldrb     w8, [x1, #0x53]
0068D09EC  tbnz     w8, #5, #0x68d0a48
0068D09F0  mov      x0, x19
0068D09F4  mov      x1, xzr
0068D09F8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068D09FC  adrp     x21, #0x959c000
0068D0A00  ldrb     w8, [x21, #0x754]
0068D0A04  mov      x20, x0
0068D0A08  cbnz     w8, #0x68d0a20
0068D0A0C  adrp     x0, #0x8f28000
0068D0A10  ldr      x0, [x0, #0x6b0]
0068D0A14  bl       #0x382bd14 ; 
0068D0A18  mov      w8, #1
0068D0A1C  strb     w8, [x21, #0x754]
0068D0A20  adrp     x8, #0x8f28000
0068D0A24  ldr      x8, [x8, #0x6b0]
0068D0A28  ldr      x2, [x8]
0068D0A2C  ldrb     w8, [x2, #0x53]
0068D0A30  tbnz     w8, #5, #0x68d0a5c
0068D0A34  mov      x0, x19
0068D0A38  str      x20, [x0, #0x20]!
0068D0A3C  mov      x1, x20
0068D0A40  bl       #0x382bcb8 ; 
0068D0A44  b        #0x68d0a6c ; 
0068D0A48  ldr      x2, [x1, #0x60]
0068D0A4C  mov      x0, x19
0068D0A50  ldp      x20, x19, [sp, #0x10]
0068D0A54  ldp      x30, x21, [sp], #0x20
0068D0A58  br       x2
0068D0A5C  ldr      x8, [x2, #0x60]
0068D0A60  mov      x0, x19
0068D0A64  mov      x1, x20
0068D0A68  blr      x8
0068D0A6C  mov      x0, x19
0068D0A70  mov      x1, xzr
0068D0A74  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068D0A78  adrp     x21, #0x959c000
0068D0A7C  ldrb     w8, [x21, #0x755]
0068D0A80  mov      x20, x0
0068D0A84  cbnz     w8, #0x68d0a9c
0068D0A88  adrp     x0, #0x8f28000
0068D0A8C  ldr      x0, [x0, #0x6c0]
0068D0A90  bl       #0x382bd14 ; 
0068D0A94  mov      w8, #1
0068D0A98  strb     w8, [x21, #0x755]
0068D0A9C  adrp     x8, #0x8f28000
0068D0AA0  ldr      x8, [x8, #0x6c0]
0068D0AA4  ldr      x2, [x8]
0068D0AA8  ldrb     w8, [x2, #0x53]
0068D0AAC  tbnz     w8, #5, #0x68d0ac4
0068D0AB0  mov      x0, x19
0068D0AB4  str      x20, [x0, #0x28]!
0068D0AB8  mov      x1, x20
0068D0ABC  bl       #0x382bcb8 ; 
0068D0AC0  b        #0x68d0ad4 ; 
0068D0AC4  ldr      x8, [x2, #0x60]
0068D0AC8  mov      x0, x19
0068D0ACC  mov      x1, x20
0068D0AD0  blr      x8
0068D0AD4  mov      x0, x19
0068D0AD8  mov      x1, xzr
0068D0ADC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068D0AE0  adrp     x21, #0x959c000
0068D0AE4  ldrb     w8, [x21, #0x756]
0068D0AE8  mov      x20, x0
0068D0AEC  cbnz     w8, #0x68d0b04
0068D0AF0  adrp     x0, #0x8f28000
0068D0AF4  ldr      x0, [x0, #0x6d0]
0068D0AF8  bl       #0x382bd14 ; 
0068D0AFC  mov      w8, #1
0068D0B00  strb     w8, [x21, #0x756]
0068D0B04  adrp     x8, #0x8f28000
0068D0B08  ldr      x8, [x8, #0x6d0]
0068D0B0C  ldr      x2, [x8]
0068D0B10  ldrb     w8, [x2, #0x53]
0068D0B14  tbnz     w8, #5, #0x68d0b2c
0068D0B18  mov      x0, x19
0068D0B1C  str      x20, [x0, #0x30]!
0068D0B20  mov      x1, x20
0068D0B24  bl       #0x382bcb8 ; 
0068D0B28  b        #0x68d0b3c ; 
0068D0B2C  ldr      x8, [x2, #0x60]
0068D0B30  mov      x0, x19
0068D0B34  mov      x1, x20
0068D0B38  blr      x8
0068D0B3C  mov      x0, x19
0068D0B40  mov      x1, xzr
0068D0B44  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068D0B48  adrp     x21, #0x959c000
0068D0B4C  ldrb     w8, [x21, #0x757]
0068D0B50  mov      x20, x0
0068D0B54  cbnz     w8, #0x68d0b6c
0068D0B58  adrp     x0, #0x8f28000
0068D0B5C  ldr      x0, [x0, #0x6e0]
0068D0B60  bl       #0x382bd14 ; 
0068D0B64  mov      w8, #1
0068D0B68  strb     w8, [x21, #0x757]
0068D0B6C  adrp     x8, #0x8f28000
0068D0B70  ldr      x8, [x8, #0x6e0]
0068D0B74  ldr      x2, [x8]
0068D0B78  ldrb     w8, [x2, #0x53]
0068D0B7C  tbnz     w8, #5, #0x68d0b94
0068D0B80  mov      x0, x19
0068D0B84  str      x20, [x0, #0x38]!
0068D0B88  mov      x1, x20
0068D0B8C  bl       #0x382bcb8 ; 
0068D0B90  b        #0x68d0ba4 ; 
0068D0B94  ldr      x8, [x2, #0x60]
0068D0B98  mov      x0, x19
0068D0B9C  mov      x1, x20
0068D0BA0  blr      x8
0068D0BA4  mov      x0, x19
0068D0BA8  mov      x1, xzr
0068D0BAC  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068D0BB0  adrp     x21, #0x959c000
0068D0BB4  ldrb     w8, [x21, #0x758]
0068D0BB8  mov      x20, x0
0068D0BBC  cbnz     w8, #0x68d0bd4
0068D0BC0  adrp     x0, #0x8f28000
0068D0BC4  ldr      x0, [x0, #0x6f0]
0068D0BC8  bl       #0x382bd14 ; 
0068D0BCC  mov      w8, #1
0068D0BD0  strb     w8, [x21, #0x758]
0068D0BD4  adrp     x8, #0x8f28000
0068D0BD8  ldr      x8, [x8, #0x6f0]
0068D0BDC  ldr      x2, [x8]
0068D0BE0  ldrb     w8, [x2, #0x53]
0068D0BE4  tbnz     w8, #5, #0x68d0bfc
0068D0BE8  str      x20, [x19, #0x40]!
0068D0BEC  mov      x0, x19
0068D0BF0  mov      x1, x20
0068D0BF4  bl       #0x382bcb8 ; 
0068D0BF8  b        #0x68d0c0c ; 
0068D0BFC  ldr      x8, [x2, #0x60]
0068D0C00  mov      x0, x19
0068D0C04  mov      x1, x20
0068D0C08  blr      x8
0068D0C0C  ldp      x20, x19, [sp, #0x10]
0068D0C10  mov      w0, #1
0068D0C14  ldp      x30, x21, [sp], #0x20
0068D0C18  ret      

