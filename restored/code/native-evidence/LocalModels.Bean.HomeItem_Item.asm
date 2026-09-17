; LocalModels.Bean.HomeItem_Item$$readImpl
; RVA 0x6A98CA4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A98CA4  stp      x30, x21, [sp, #-0x20]!
006A98CA8  stp      x20, x19, [sp, #0x10]
006A98CAC  adrp     x20, #0x959e000
006A98CB0  adrp     x21, #0x8f39000
006A98CB4  ldrb     w8, [x20, #0x1d2]
006A98CB8  ldr      x21, [x21, #0x450]
006A98CBC  mov      x19, x0
006A98CC0  tbnz     w8, #0, #0x6a98cd8
006A98CC4  adrp     x0, #0x8f39000
006A98CC8  ldr      x0, [x0, #0x450]
006A98CCC  bl       #0x382bd14 ; 
006A98CD0  mov      w8, #1
006A98CD4  strb     w8, [x20, #0x1d2]
006A98CD8  ldr      x1, [x21]
006A98CDC  ldrb     w8, [x1, #0x53]
006A98CE0  tbnz     w8, #5, #0x6a98d30
006A98CE4  mov      x0, x19
006A98CE8  mov      x1, xzr
006A98CEC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A98CF0  adrp     x21, #0x959e000
006A98CF4  ldrb     w8, [x21, #0x603]
006A98CF8  mov      w20, w0
006A98CFC  cbnz     w8, #0x6a98d14
006A98D00  adrp     x0, #0x8f39000
006A98D04  ldr      x0, [x0, #0x418]
006A98D08  bl       #0x382bd14 ; 
006A98D0C  mov      w8, #1
006A98D10  strb     w8, [x21, #0x603]
006A98D14  adrp     x8, #0x8f39000
006A98D18  ldr      x8, [x8, #0x418]
006A98D1C  ldr      x2, [x8]
006A98D20  ldrb     w8, [x2, #0x53]
006A98D24  tbnz     w8, #5, #0x6a98d44
006A98D28  str      w20, [x19, #0x20]
006A98D2C  b        #0x6a98d54 ; 
006A98D30  ldr      x2, [x1, #0x60]
006A98D34  mov      x0, x19
006A98D38  ldp      x20, x19, [sp, #0x10]
006A98D3C  ldp      x30, x21, [sp], #0x20
006A98D40  br       x2
006A98D44  ldr      x8, [x2, #0x60]
006A98D48  mov      x0, x19
006A98D4C  mov      w1, w20
006A98D50  blr      x8
006A98D54  mov      x0, x19
006A98D58  mov      x1, xzr
006A98D5C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A98D60  adrp     x21, #0x959e000
006A98D64  ldrb     w8, [x21, #0x604]
006A98D68  mov      w20, w0
006A98D6C  cbnz     w8, #0x6a98d84
006A98D70  adrp     x0, #0x8f39000
006A98D74  ldr      x0, [x0, #0x428]
006A98D78  bl       #0x382bd14 ; 
006A98D7C  mov      w8, #1
006A98D80  strb     w8, [x21, #0x604]
006A98D84  adrp     x8, #0x8f39000
006A98D88  ldr      x8, [x8, #0x428]
006A98D8C  ldr      x2, [x8]
006A98D90  ldrb     w8, [x2, #0x53]
006A98D94  tbnz     w8, #5, #0x6a98da0
006A98D98  str      w20, [x19, #0x24]
006A98D9C  b        #0x6a98db0 ; 
006A98DA0  ldr      x8, [x2, #0x60]
006A98DA4  mov      x0, x19
006A98DA8  mov      w1, w20
006A98DAC  blr      x8
006A98DB0  mov      x0, x19
006A98DB4  mov      x1, xzr
006A98DB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A98DBC  adrp     x21, #0x959e000
006A98DC0  ldrb     w8, [x21, #0x605]
006A98DC4  mov      w20, w0
006A98DC8  cbnz     w8, #0x6a98de0
006A98DCC  adrp     x0, #0x8f39000
006A98DD0  ldr      x0, [x0, #0x438]
006A98DD4  bl       #0x382bd14 ; 
006A98DD8  mov      w8, #1
006A98DDC  strb     w8, [x21, #0x605]
006A98DE0  adrp     x8, #0x8f39000
006A98DE4  ldr      x8, [x8, #0x438]
006A98DE8  ldr      x2, [x8]
006A98DEC  ldrb     w8, [x2, #0x53]
006A98DF0  tbnz     w8, #5, #0x6a98dfc
006A98DF4  str      w20, [x19, #0x28]
006A98DF8  b        #0x6a98e0c ; 
006A98DFC  ldr      x8, [x2, #0x60]
006A98E00  mov      x0, x19
006A98E04  mov      w1, w20
006A98E08  blr      x8
006A98E0C  mov      x0, x19
006A98E10  mov      x1, xzr
006A98E14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A98E18  adrp     x21, #0x959e000
006A98E1C  ldrb     w8, [x21, #0x606]
006A98E20  mov      w20, w0
006A98E24  cbnz     w8, #0x6a98e3c
006A98E28  adrp     x0, #0x8f39000
006A98E2C  ldr      x0, [x0, #0x448]
006A98E30  bl       #0x382bd14 ; 
006A98E34  mov      w8, #1
006A98E38  strb     w8, [x21, #0x606]
006A98E3C  adrp     x8, #0x8f39000
006A98E40  ldr      x8, [x8, #0x448]
006A98E44  ldr      x2, [x8]
006A98E48  ldrb     w8, [x2, #0x53]
006A98E4C  tbnz     w8, #5, #0x6a98e58
006A98E50  str      w20, [x19, #0x2c]
006A98E54  b        #0x6a98e68 ; 
006A98E58  ldr      x8, [x2, #0x60]
006A98E5C  mov      x0, x19
006A98E60  mov      w1, w20
006A98E64  blr      x8
006A98E68  ldp      x20, x19, [sp, #0x10]
006A98E6C  mov      w0, #1
006A98E70  ldp      x30, x21, [sp], #0x20
006A98E74  ret      

