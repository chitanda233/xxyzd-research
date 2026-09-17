; LocalModels.Bean.Character_MonsterTagName$$readImpl
; RVA 0x68C9B00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068C9B00  stp      x30, x21, [sp, #-0x20]!
0068C9B04  stp      x20, x19, [sp, #0x10]
0068C9B08  adrp     x20, #0x959c000
0068C9B0C  adrp     x21, #0x8f28000
0068C9B10  ldrb     w8, [x20, #0x2fa]
0068C9B14  ldr      x21, [x21, #0x188]
0068C9B18  mov      x19, x0
0068C9B1C  tbnz     w8, #0, #0x68c9b34
0068C9B20  adrp     x0, #0x8f28000
0068C9B24  ldr      x0, [x0, #0x188]
0068C9B28  bl       #0x382bd14 ; 
0068C9B2C  mov      w8, #1
0068C9B30  strb     w8, [x20, #0x2fa]
0068C9B34  ldr      x1, [x21]
0068C9B38  ldrb     w8, [x1, #0x53]
0068C9B3C  tbnz     w8, #5, #0x68c9b8c
0068C9B40  mov      x0, x19
0068C9B44  mov      x1, xzr
0068C9B48  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
0068C9B4C  adrp     x21, #0x959c000
0068C9B50  ldrb     w8, [x21, #0x70e]
0068C9B54  mov      w20, w0
0068C9B58  cbnz     w8, #0x68c9b70
0068C9B5C  adrp     x0, #0x8f28000
0068C9B60  ldr      x0, [x0, #0x170]
0068C9B64  bl       #0x382bd14 ; 
0068C9B68  mov      w8, #1
0068C9B6C  strb     w8, [x21, #0x70e]
0068C9B70  adrp     x8, #0x8f28000
0068C9B74  ldr      x8, [x8, #0x170]
0068C9B78  ldr      x2, [x8]
0068C9B7C  ldrb     w8, [x2, #0x53]
0068C9B80  tbnz     w8, #5, #0x68c9ba0
0068C9B84  str      w20, [x19, #0x20]
0068C9B88  b        #0x68c9bb0 ; 
0068C9B8C  ldr      x2, [x1, #0x60]
0068C9B90  mov      x0, x19
0068C9B94  ldp      x20, x19, [sp, #0x10]
0068C9B98  ldp      x30, x21, [sp], #0x20
0068C9B9C  br       x2
0068C9BA0  ldr      x8, [x2, #0x60]
0068C9BA4  mov      x0, x19
0068C9BA8  mov      w1, w20
0068C9BAC  blr      x8
0068C9BB0  mov      x0, x19
0068C9BB4  mov      x1, xzr
0068C9BB8  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
0068C9BBC  adrp     x21, #0x959c000
0068C9BC0  ldrb     w8, [x21, #0x70f]
0068C9BC4  mov      x20, x0
0068C9BC8  cbnz     w8, #0x68c9be0
0068C9BCC  adrp     x0, #0x8f28000
0068C9BD0  ldr      x0, [x0, #0x180]
0068C9BD4  bl       #0x382bd14 ; 
0068C9BD8  mov      w8, #1
0068C9BDC  strb     w8, [x21, #0x70f]
0068C9BE0  adrp     x8, #0x8f28000
0068C9BE4  ldr      x8, [x8, #0x180]
0068C9BE8  ldr      x2, [x8]
0068C9BEC  ldrb     w8, [x2, #0x53]
0068C9BF0  tbnz     w8, #5, #0x68c9c08
0068C9BF4  str      x20, [x19, #0x28]!
0068C9BF8  mov      x0, x19
0068C9BFC  mov      x1, x20
0068C9C00  bl       #0x382bcb8 ; 
0068C9C04  b        #0x68c9c18 ; 
0068C9C08  ldr      x8, [x2, #0x60]
0068C9C0C  mov      x0, x19
0068C9C10  mov      x1, x20
0068C9C14  blr      x8
0068C9C18  ldp      x20, x19, [sp, #0x10]
0068C9C1C  mov      w0, #1
0068C9C20  ldp      x30, x21, [sp], #0x20
0068C9C24  ret      

