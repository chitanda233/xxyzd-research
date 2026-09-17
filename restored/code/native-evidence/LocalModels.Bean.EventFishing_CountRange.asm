; LocalModels.Bean.EventFishing_CountRange$$readImpl
; RVA 0x6A70DB8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A70DB8  stp      x30, x21, [sp, #-0x20]!
006A70DBC  stp      x20, x19, [sp, #0x10]
006A70DC0  adrp     x20, #0x959d000
006A70DC4  adrp     x21, #0x8f37000
006A70DC8  ldrb     w8, [x20, #0xda5]
006A70DCC  ldr      x21, [x21, #0x5e8]
006A70DD0  mov      x19, x0
006A70DD4  tbnz     w8, #0, #0x6a70dec
006A70DD8  adrp     x0, #0x8f37000
006A70DDC  ldr      x0, [x0, #0x5e8]
006A70DE0  bl       #0x382bd14 ; 
006A70DE4  mov      w8, #1
006A70DE8  strb     w8, [x20, #0xda5]
006A70DEC  ldr      x1, [x21]
006A70DF0  ldrb     w8, [x1, #0x53]
006A70DF4  tbnz     w8, #5, #0x6a70e44
006A70DF8  mov      x0, x19
006A70DFC  mov      x1, xzr
006A70E00  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A70E04  adrp     x21, #0x959e000
006A70E08  ldrb     w8, [x21, #0x455]
006A70E0C  mov      w20, w0
006A70E10  cbnz     w8, #0x6a70e28
006A70E14  adrp     x0, #0x8f37000
006A70E18  ldr      x0, [x0, #0x5c0]
006A70E1C  bl       #0x382bd14 ; 
006A70E20  mov      w8, #1
006A70E24  strb     w8, [x21, #0x455]
006A70E28  adrp     x8, #0x8f37000
006A70E2C  ldr      x8, [x8, #0x5c0]
006A70E30  ldr      x2, [x8]
006A70E34  ldrb     w8, [x2, #0x53]
006A70E38  tbnz     w8, #5, #0x6a70e58
006A70E3C  str      w20, [x19, #0x20]
006A70E40  b        #0x6a70e68 ; 
006A70E44  ldr      x2, [x1, #0x60]
006A70E48  mov      x0, x19
006A70E4C  ldp      x20, x19, [sp, #0x10]
006A70E50  ldp      x30, x21, [sp], #0x20
006A70E54  br       x2
006A70E58  ldr      x8, [x2, #0x60]
006A70E5C  mov      x0, x19
006A70E60  mov      w1, w20
006A70E64  blr      x8
006A70E68  mov      x0, x19
006A70E6C  mov      x1, xzr
006A70E70  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A70E74  adrp     x21, #0x959e000
006A70E78  ldrb     w8, [x21, #0x456]
006A70E7C  mov      x20, x0
006A70E80  cbnz     w8, #0x6a70e98
006A70E84  adrp     x0, #0x8f37000
006A70E88  ldr      x0, [x0, #0x5d0]
006A70E8C  bl       #0x382bd14 ; 
006A70E90  mov      w8, #1
006A70E94  strb     w8, [x21, #0x456]
006A70E98  adrp     x8, #0x8f37000
006A70E9C  ldr      x8, [x8, #0x5d0]
006A70EA0  ldr      x2, [x8]
006A70EA4  ldrb     w8, [x2, #0x53]
006A70EA8  tbnz     w8, #5, #0x6a70ec0
006A70EAC  mov      x0, x19
006A70EB0  str      x20, [x0, #0x28]!
006A70EB4  mov      x1, x20
006A70EB8  bl       #0x382bcb8 ; 
006A70EBC  b        #0x6a70ed0 ; 
006A70EC0  ldr      x8, [x2, #0x60]
006A70EC4  mov      x0, x19
006A70EC8  mov      x1, x20
006A70ECC  blr      x8
006A70ED0  mov      x0, x19
006A70ED4  mov      x1, xzr
006A70ED8  bl       #0x64ca820 ; LocalModels.BaseLocalBean$$readArrayint
006A70EDC  adrp     x21, #0x959e000
006A70EE0  ldrb     w8, [x21, #0x457]
006A70EE4  mov      x20, x0
006A70EE8  cbnz     w8, #0x6a70f00
006A70EEC  adrp     x0, #0x8f37000
006A70EF0  ldr      x0, [x0, #0x5e0]
006A70EF4  bl       #0x382bd14 ; 
006A70EF8  mov      w8, #1
006A70EFC  strb     w8, [x21, #0x457]
006A70F00  adrp     x8, #0x8f37000
006A70F04  ldr      x8, [x8, #0x5e0]
006A70F08  ldr      x2, [x8]
006A70F0C  ldrb     w8, [x2, #0x53]
006A70F10  tbnz     w8, #5, #0x6a70f28
006A70F14  str      x20, [x19, #0x30]!
006A70F18  mov      x0, x19
006A70F1C  mov      x1, x20
006A70F20  bl       #0x382bcb8 ; 
006A70F24  b        #0x6a70f38 ; 
006A70F28  ldr      x8, [x2, #0x60]
006A70F2C  mov      x0, x19
006A70F30  mov      x1, x20
006A70F34  blr      x8
006A70F38  ldp      x20, x19, [sp, #0x10]
006A70F3C  mov      w0, #1
006A70F40  ldp      x30, x21, [sp], #0x20
006A70F44  ret      

