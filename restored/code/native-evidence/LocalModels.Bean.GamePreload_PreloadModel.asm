; LocalModels.Bean.GamePreload_PreloadModel$$readImpl
; RVA 0x6A81ACC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A81ACC  stp      x30, x21, [sp, #-0x20]!
006A81AD0  stp      x20, x19, [sp, #0x10]
006A81AD4  adrp     x20, #0x959d000
006A81AD8  adrp     x21, #0x8f38000
006A81ADC  ldrb     w8, [x20, #0xf64]
006A81AE0  ldr      x21, [x21, #0x300]
006A81AE4  mov      x19, x0
006A81AE8  tbnz     w8, #0, #0x6a81b00
006A81AEC  adrp     x0, #0x8f38000
006A81AF0  ldr      x0, [x0, #0x300]
006A81AF4  bl       #0x382bd14 ; 
006A81AF8  mov      w8, #1
006A81AFC  strb     w8, [x20, #0xf64]
006A81B00  ldr      x1, [x21]
006A81B04  ldrb     w8, [x1, #0x53]
006A81B08  tbnz     w8, #5, #0x6a81b58
006A81B0C  mov      x0, x19
006A81B10  mov      x1, xzr
006A81B14  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A81B18  adrp     x21, #0x959e000
006A81B1C  ldrb     w8, [x21, #0x510]
006A81B20  mov      w20, w0
006A81B24  cbnz     w8, #0x6a81b3c
006A81B28  adrp     x0, #0x8f38000
006A81B2C  ldr      x0, [x0, #0x2e8]
006A81B30  bl       #0x382bd14 ; 
006A81B34  mov      w8, #1
006A81B38  strb     w8, [x21, #0x510]
006A81B3C  adrp     x8, #0x8f38000
006A81B40  ldr      x8, [x8, #0x2e8]
006A81B44  ldr      x2, [x8]
006A81B48  ldrb     w8, [x2, #0x53]
006A81B4C  tbnz     w8, #5, #0x6a81b6c
006A81B50  str      w20, [x19, #0x20]
006A81B54  b        #0x6a81b7c ; 
006A81B58  ldr      x2, [x1, #0x60]
006A81B5C  mov      x0, x19
006A81B60  ldp      x20, x19, [sp, #0x10]
006A81B64  ldp      x30, x21, [sp], #0x20
006A81B68  br       x2
006A81B6C  ldr      x8, [x2, #0x60]
006A81B70  mov      x0, x19
006A81B74  mov      w1, w20
006A81B78  blr      x8
006A81B7C  mov      x0, x19
006A81B80  mov      x1, xzr
006A81B84  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A81B88  adrp     x21, #0x959e000
006A81B8C  ldrb     w8, [x21, #0x511]
006A81B90  mov      w20, w0
006A81B94  cbnz     w8, #0x6a81bac
006A81B98  adrp     x0, #0x8f38000
006A81B9C  ldr      x0, [x0, #0x2f8]
006A81BA0  bl       #0x382bd14 ; 
006A81BA4  mov      w8, #1
006A81BA8  strb     w8, [x21, #0x511]
006A81BAC  adrp     x8, #0x8f38000
006A81BB0  ldr      x8, [x8, #0x2f8]
006A81BB4  ldr      x2, [x8]
006A81BB8  ldrb     w8, [x2, #0x53]
006A81BBC  tbnz     w8, #5, #0x6a81bc8
006A81BC0  str      w20, [x19, #0x24]
006A81BC4  b        #0x6a81bd8 ; 
006A81BC8  ldr      x8, [x2, #0x60]
006A81BCC  mov      x0, x19
006A81BD0  mov      w1, w20
006A81BD4  blr      x8
006A81BD8  ldp      x20, x19, [sp, #0x10]
006A81BDC  mov      w0, #1
006A81BE0  ldp      x30, x21, [sp], #0x20
006A81BE4  ret      

