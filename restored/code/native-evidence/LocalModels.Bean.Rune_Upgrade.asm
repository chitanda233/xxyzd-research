; LocalModels.Bean.Rune_Upgrade$$readImpl
; RVA 0x6AE6B14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE6B14  stp      x30, x21, [sp, #-0x20]!
006AE6B18  stp      x20, x19, [sp, #0x10]
006AE6B1C  adrp     x20, #0x959e000
006AE6B20  adrp     x21, #0x8f3c000
006AE6B24  ldrb     w8, [x20, #0xd59]
006AE6B28  ldr      x21, [x21, #0xe68]
006AE6B2C  mov      x19, x0
006AE6B30  tbnz     w8, #0, #0x6ae6b48
006AE6B34  adrp     x0, #0x8f3c000
006AE6B38  ldr      x0, [x0, #0xe68]
006AE6B3C  bl       #0x382bd14 ; 
006AE6B40  mov      w8, #1
006AE6B44  strb     w8, [x20, #0xd59]
006AE6B48  ldr      x1, [x21]
006AE6B4C  ldrb     w8, [x1, #0x53]
006AE6B50  tbnz     w8, #5, #0x6ae6ba0
006AE6B54  mov      x0, x19
006AE6B58  mov      x1, xzr
006AE6B5C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE6B60  adrp     x21, #0x959f000
006AE6B64  ldrb     w8, [x21, #0x1dc]
006AE6B68  mov      w20, w0
006AE6B6C  cbnz     w8, #0x6ae6b84
006AE6B70  adrp     x0, #0x8f3c000
006AE6B74  ldr      x0, [x0, #0xe50]
006AE6B78  bl       #0x382bd14 ; 
006AE6B7C  mov      w8, #1
006AE6B80  strb     w8, [x21, #0x1dc]
006AE6B84  adrp     x8, #0x8f3c000
006AE6B88  ldr      x8, [x8, #0xe50]
006AE6B8C  ldr      x2, [x8]
006AE6B90  ldrb     w8, [x2, #0x53]
006AE6B94  tbnz     w8, #5, #0x6ae6bb4
006AE6B98  str      w20, [x19, #0x20]
006AE6B9C  b        #0x6ae6bc4 ; 
006AE6BA0  ldr      x2, [x1, #0x60]
006AE6BA4  mov      x0, x19
006AE6BA8  ldp      x20, x19, [sp, #0x10]
006AE6BAC  ldp      x30, x21, [sp], #0x20
006AE6BB0  br       x2
006AE6BB4  ldr      x8, [x2, #0x60]
006AE6BB8  mov      x0, x19
006AE6BBC  mov      w1, w20
006AE6BC0  blr      x8
006AE6BC4  mov      x0, x19
006AE6BC8  mov      x1, xzr
006AE6BCC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE6BD0  adrp     x21, #0x959f000
006AE6BD4  ldrb     w8, [x21, #0x1dd]
006AE6BD8  mov      w20, w0
006AE6BDC  cbnz     w8, #0x6ae6bf4
006AE6BE0  adrp     x0, #0x8f3c000
006AE6BE4  ldr      x0, [x0, #0xe60]
006AE6BE8  bl       #0x382bd14 ; 
006AE6BEC  mov      w8, #1
006AE6BF0  strb     w8, [x21, #0x1dd]
006AE6BF4  adrp     x8, #0x8f3c000
006AE6BF8  ldr      x8, [x8, #0xe60]
006AE6BFC  ldr      x2, [x8]
006AE6C00  ldrb     w8, [x2, #0x53]
006AE6C04  tbnz     w8, #5, #0x6ae6c10
006AE6C08  str      w20, [x19, #0x24]
006AE6C0C  b        #0x6ae6c20 ; 
006AE6C10  ldr      x8, [x2, #0x60]
006AE6C14  mov      x0, x19
006AE6C18  mov      w1, w20
006AE6C1C  blr      x8
006AE6C20  ldp      x20, x19, [sp, #0x10]
006AE6C24  mov      w0, #1
006AE6C28  ldp      x30, x21, [sp], #0x20
006AE6C2C  ret      

