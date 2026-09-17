; LocalModels.Bean.ElementShowConfig_ElementShowConfig$$readImpl
; RVA 0x6A63254; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A63254  stp      x30, x21, [sp, #-0x20]!
006A63258  stp      x20, x19, [sp, #0x10]
006A6325C  adrp     x20, #0x959d000
006A63260  adrp     x21, #0x8f36000
006A63264  ldrb     w8, [x20, #0xc3c]
006A63268  ldr      x21, [x21, #0xba8]
006A6326C  mov      x19, x0
006A63270  tbnz     w8, #0, #0x6a63288
006A63274  adrp     x0, #0x8f36000
006A63278  ldr      x0, [x0, #0xba8]
006A6327C  bl       #0x382bd14 ; 
006A63280  mov      w8, #1
006A63284  strb     w8, [x20, #0xc3c]
006A63288  ldr      x1, [x21]
006A6328C  ldrb     w8, [x1, #0x53]
006A63290  tbnz     w8, #5, #0x6a632e0
006A63294  mov      x0, x19
006A63298  mov      x1, xzr
006A6329C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A632A0  adrp     x21, #0x959e000
006A632A4  ldrb     w8, [x21, #0x3bd]
006A632A8  mov      w20, w0
006A632AC  cbnz     w8, #0x6a632c4
006A632B0  adrp     x0, #0x8f36000
006A632B4  ldr      x0, [x0, #0xb80]
006A632B8  bl       #0x382bd14 ; 
006A632BC  mov      w8, #1
006A632C0  strb     w8, [x21, #0x3bd]
006A632C4  adrp     x8, #0x8f36000
006A632C8  ldr      x8, [x8, #0xb80]
006A632CC  ldr      x2, [x8]
006A632D0  ldrb     w8, [x2, #0x53]
006A632D4  tbnz     w8, #5, #0x6a632f4
006A632D8  str      w20, [x19, #0x20]
006A632DC  b        #0x6a63304 ; 
006A632E0  ldr      x2, [x1, #0x60]
006A632E4  mov      x0, x19
006A632E8  ldp      x20, x19, [sp, #0x10]
006A632EC  ldp      x30, x21, [sp], #0x20
006A632F0  br       x2
006A632F4  ldr      x8, [x2, #0x60]
006A632F8  mov      x0, x19
006A632FC  mov      w1, w20
006A63300  blr      x8
006A63304  mov      x0, x19
006A63308  mov      x1, xzr
006A6330C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A63310  adrp     x21, #0x959e000
006A63314  ldrb     w8, [x21, #0x3be]
006A63318  mov      w20, w0
006A6331C  cbnz     w8, #0x6a63334
006A63320  adrp     x0, #0x8f36000
006A63324  ldr      x0, [x0, #0xb90]
006A63328  bl       #0x382bd14 ; 
006A6332C  mov      w8, #1
006A63330  strb     w8, [x21, #0x3be]
006A63334  adrp     x8, #0x8f36000
006A63338  ldr      x8, [x8, #0xb90]
006A6333C  ldr      x2, [x8]
006A63340  ldrb     w8, [x2, #0x53]
006A63344  tbnz     w8, #5, #0x6a63350
006A63348  str      w20, [x19, #0x24]
006A6334C  b        #0x6a63360 ; 
006A63350  ldr      x8, [x2, #0x60]
006A63354  mov      x0, x19
006A63358  mov      w1, w20
006A6335C  blr      x8
006A63360  mov      x0, x19
006A63364  mov      x1, xzr
006A63368  bl       #0x64ca55c ; LocalModels.BaseLocalBean$$readLocalString
006A6336C  adrp     x21, #0x959e000
006A63370  ldrb     w8, [x21, #0x3bf]
006A63374  mov      x20, x0
006A63378  cbnz     w8, #0x6a63390
006A6337C  adrp     x0, #0x8f36000
006A63380  ldr      x0, [x0, #0xba0]
006A63384  bl       #0x382bd14 ; 
006A63388  mov      w8, #1
006A6338C  strb     w8, [x21, #0x3bf]
006A63390  adrp     x8, #0x8f36000
006A63394  ldr      x8, [x8, #0xba0]
006A63398  ldr      x2, [x8]
006A6339C  ldrb     w8, [x2, #0x53]
006A633A0  tbnz     w8, #5, #0x6a633b8
006A633A4  str      x20, [x19, #0x28]!
006A633A8  mov      x0, x19
006A633AC  mov      x1, x20
006A633B0  bl       #0x382bcb8 ; 
006A633B4  b        #0x6a633c8 ; 
006A633B8  ldr      x8, [x2, #0x60]
006A633BC  mov      x0, x19
006A633C0  mov      x1, x20
006A633C4  blr      x8
006A633C8  ldp      x20, x19, [sp, #0x10]
006A633CC  mov      w0, #1
006A633D0  ldp      x30, x21, [sp], #0x20
006A633D4  ret      

