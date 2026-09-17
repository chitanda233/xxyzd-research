; LocalModels.Bean.Equipment_Level$$readImpl
; RVA 0x6A66D70; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A66D70  stp      x30, x21, [sp, #-0x20]!
006A66D74  stp      x20, x19, [sp, #0x10]
006A66D78  adrp     x20, #0x959d000
006A66D7C  adrp     x21, #0x8f36000
006A66D80  ldrb     w8, [x20, #0xc98]
006A66D84  ldr      x21, [x21, #0xe28]
006A66D88  mov      x19, x0
006A66D8C  tbnz     w8, #0, #0x6a66da4
006A66D90  adrp     x0, #0x8f36000
006A66D94  ldr      x0, [x0, #0xe28]
006A66D98  bl       #0x382bd14 ; 
006A66D9C  mov      w8, #1
006A66DA0  strb     w8, [x20, #0xc98]
006A66DA4  ldr      x1, [x21]
006A66DA8  ldrb     w8, [x1, #0x53]
006A66DAC  tbnz     w8, #5, #0x6a66dfc
006A66DB0  mov      x0, x19
006A66DB4  mov      x1, xzr
006A66DB8  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A66DBC  adrp     x21, #0x959e000
006A66DC0  ldrb     w8, [x21, #0x3ed]
006A66DC4  mov      w20, w0
006A66DC8  cbnz     w8, #0x6a66de0
006A66DCC  adrp     x0, #0x8f36000
006A66DD0  ldr      x0, [x0, #0xdf0]
006A66DD4  bl       #0x382bd14 ; 
006A66DD8  mov      w8, #1
006A66DDC  strb     w8, [x21, #0x3ed]
006A66DE0  adrp     x8, #0x8f36000
006A66DE4  ldr      x8, [x8, #0xdf0]
006A66DE8  ldr      x2, [x8]
006A66DEC  ldrb     w8, [x2, #0x53]
006A66DF0  tbnz     w8, #5, #0x6a66e10
006A66DF4  str      w20, [x19, #0x20]
006A66DF8  b        #0x6a66e20 ; 
006A66DFC  ldr      x2, [x1, #0x60]
006A66E00  mov      x0, x19
006A66E04  ldp      x20, x19, [sp, #0x10]
006A66E08  ldp      x30, x21, [sp], #0x20
006A66E0C  br       x2
006A66E10  ldr      x8, [x2, #0x60]
006A66E14  mov      x0, x19
006A66E18  mov      w1, w20
006A66E1C  blr      x8
006A66E20  mov      x0, x19
006A66E24  mov      x1, xzr
006A66E28  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A66E2C  adrp     x21, #0x959e000
006A66E30  ldrb     w8, [x21, #0x3ee]
006A66E34  mov      w20, w0
006A66E38  cbnz     w8, #0x6a66e50
006A66E3C  adrp     x0, #0x8f36000
006A66E40  ldr      x0, [x0, #0xe00]
006A66E44  bl       #0x382bd14 ; 
006A66E48  mov      w8, #1
006A66E4C  strb     w8, [x21, #0x3ee]
006A66E50  adrp     x8, #0x8f36000
006A66E54  ldr      x8, [x8, #0xe00]
006A66E58  ldr      x2, [x8]
006A66E5C  ldrb     w8, [x2, #0x53]
006A66E60  tbnz     w8, #5, #0x6a66e6c
006A66E64  str      w20, [x19, #0x24]
006A66E68  b        #0x6a66e7c ; 
006A66E6C  ldr      x8, [x2, #0x60]
006A66E70  mov      x0, x19
006A66E74  mov      w1, w20
006A66E78  blr      x8
006A66E7C  mov      x0, x19
006A66E80  mov      x1, xzr
006A66E84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A66E88  adrp     x21, #0x959e000
006A66E8C  ldrb     w8, [x21, #0x3ef]
006A66E90  mov      w20, w0
006A66E94  cbnz     w8, #0x6a66eac
006A66E98  adrp     x0, #0x8f36000
006A66E9C  ldr      x0, [x0, #0xe10]
006A66EA0  bl       #0x382bd14 ; 
006A66EA4  mov      w8, #1
006A66EA8  strb     w8, [x21, #0x3ef]
006A66EAC  adrp     x8, #0x8f36000
006A66EB0  ldr      x8, [x8, #0xe10]
006A66EB4  ldr      x2, [x8]
006A66EB8  ldrb     w8, [x2, #0x53]
006A66EBC  tbnz     w8, #5, #0x6a66ec8
006A66EC0  str      w20, [x19, #0x28]
006A66EC4  b        #0x6a66ed8 ; 
006A66EC8  ldr      x8, [x2, #0x60]
006A66ECC  mov      x0, x19
006A66ED0  mov      w1, w20
006A66ED4  blr      x8
006A66ED8  mov      x0, x19
006A66EDC  mov      x1, xzr
006A66EE0  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A66EE4  adrp     x21, #0x959e000
006A66EE8  ldrb     w8, [x21, #0x3f0]
006A66EEC  mov      x20, x0
006A66EF0  cbnz     w8, #0x6a66f08
006A66EF4  adrp     x0, #0x8f36000
006A66EF8  ldr      x0, [x0, #0xe20]
006A66EFC  bl       #0x382bd14 ; 
006A66F00  mov      w8, #1
006A66F04  strb     w8, [x21, #0x3f0]
006A66F08  adrp     x8, #0x8f36000
006A66F0C  ldr      x8, [x8, #0xe20]
006A66F10  ldr      x2, [x8]
006A66F14  ldrb     w8, [x2, #0x53]
006A66F18  tbnz     w8, #5, #0x6a66f30
006A66F1C  str      x20, [x19, #0x30]!
006A66F20  mov      x0, x19
006A66F24  mov      x1, x20
006A66F28  bl       #0x382bcb8 ; 
006A66F2C  b        #0x6a66f40 ; 
006A66F30  ldr      x8, [x2, #0x60]
006A66F34  mov      x0, x19
006A66F38  mov      x1, x20
006A66F3C  blr      x8
006A66F40  ldp      x20, x19, [sp, #0x10]
006A66F44  mov      w0, #1
006A66F48  ldp      x30, x21, [sp], #0x20
006A66F4C  ret      

