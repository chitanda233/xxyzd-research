; LocalModels.Bean.Item_NonItemUse$$readImpl
; RVA 0x6AAFEEC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AAFEEC  stp      x30, x21, [sp, #-0x20]!
006AAFEF0  stp      x20, x19, [sp, #0x10]
006AAFEF4  adrp     x20, #0x959e000
006AAFEF8  adrp     x21, #0x8f3a000
006AAFEFC  ldrb     w8, [x20, #0x7ba]
006AAFF00  ldr      x21, [x21, #0x5e0]
006AAFF04  mov      x19, x0
006AAFF08  tbnz     w8, #0, #0x6aaff20
006AAFF0C  adrp     x0, #0x8f3a000
006AAFF10  ldr      x0, [x0, #0x5e0]
006AAFF14  bl       #0x382bd14 ; 
006AAFF18  mov      w8, #1
006AAFF1C  strb     w8, [x20, #0x7ba]
006AAFF20  ldr      x1, [x21]
006AAFF24  ldrb     w8, [x1, #0x53]
006AAFF28  tbnz     w8, #5, #0x6aaff78
006AAFF2C  mov      x0, x19
006AAFF30  mov      x1, xzr
006AAFF34  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AAFF38  adrp     x21, #0x959e000
006AAFF3C  ldrb     w8, [x21, #0xf6e]
006AAFF40  mov      w20, w0
006AAFF44  cbnz     w8, #0x6aaff5c
006AAFF48  adrp     x0, #0x8f3a000
006AAFF4C  ldr      x0, [x0, #0x5c8]
006AAFF50  bl       #0x382bd14 ; 
006AAFF54  mov      w8, #1
006AAFF58  strb     w8, [x21, #0xf6e]
006AAFF5C  adrp     x8, #0x8f3a000
006AAFF60  ldr      x8, [x8, #0x5c8]
006AAFF64  ldr      x2, [x8]
006AAFF68  ldrb     w8, [x2, #0x53]
006AAFF6C  tbnz     w8, #5, #0x6aaff8c
006AAFF70  str      w20, [x19, #0x20]
006AAFF74  b        #0x6aaff9c ; 
006AAFF78  ldr      x2, [x1, #0x60]
006AAFF7C  mov      x0, x19
006AAFF80  ldp      x20, x19, [sp, #0x10]
006AAFF84  ldp      x30, x21, [sp], #0x20
006AAFF88  br       x2
006AAFF8C  ldr      x8, [x2, #0x60]
006AAFF90  mov      x0, x19
006AAFF94  mov      w1, w20
006AAFF98  blr      x8
006AAFF9C  mov      x0, x19
006AAFFA0  mov      x1, xzr
006AAFFA4  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006AAFFA8  adrp     x21, #0x959e000
006AAFFAC  ldrb     w8, [x21, #0xf6f]
006AAFFB0  mov      x20, x0
006AAFFB4  cbnz     w8, #0x6aaffcc
006AAFFB8  adrp     x0, #0x8f3a000
006AAFFBC  ldr      x0, [x0, #0x5d8]
006AAFFC0  bl       #0x382bd14 ; 
006AAFFC4  mov      w8, #1
006AAFFC8  strb     w8, [x21, #0xf6f]
006AAFFCC  adrp     x8, #0x8f3a000
006AAFFD0  ldr      x8, [x8, #0x5d8]
006AAFFD4  ldr      x2, [x8]
006AAFFD8  ldrb     w8, [x2, #0x53]
006AAFFDC  tbnz     w8, #5, #0x6aafff4
006AAFFE0  str      x20, [x19, #0x28]!
006AAFFE4  mov      x0, x19
006AAFFE8  mov      x1, x20
006AAFFEC  bl       #0x382bcb8 ; 
006AAFFF0  b        #0x6ab0004 ; 
006AAFFF4  ldr      x8, [x2, #0x60]
006AAFFF8  mov      x0, x19
006AAFFFC  mov      x1, x20
006AB0000  blr      x8
006AB0004  ldp      x20, x19, [sp, #0x10]
006AB0008  mov      w0, #1
006AB000C  ldp      x30, x21, [sp], #0x20
006AB0010  ret      

