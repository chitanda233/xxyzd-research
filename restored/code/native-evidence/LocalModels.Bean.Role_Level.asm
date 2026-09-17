; LocalModels.Bean.Role_Level$$readImpl
; RVA 0x6ADC824; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ADC824  stp      x30, x21, [sp, #-0x20]!
006ADC828  stp      x20, x19, [sp, #0x10]
006ADC82C  adrp     x20, #0x959e000
006ADC830  adrp     x21, #0x8f3c000
006ADC834  ldrb     w8, [x20, #0xc53]
006ADC838  ldr      x21, [x21, #0x728]
006ADC83C  mov      x19, x0
006ADC840  tbnz     w8, #0, #0x6adc858
006ADC844  adrp     x0, #0x8f3c000
006ADC848  ldr      x0, [x0, #0x728]
006ADC84C  bl       #0x382bd14 ; 
006ADC850  mov      w8, #1
006ADC854  strb     w8, [x20, #0xc53]
006ADC858  ldr      x1, [x21]
006ADC85C  ldrb     w8, [x1, #0x53]
006ADC860  tbnz     w8, #5, #0x6adc8b0
006ADC864  mov      x0, x19
006ADC868  mov      x1, xzr
006ADC86C  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADC870  adrp     x21, #0x959f000
006ADC874  ldrb     w8, [x21, #0x165]
006ADC878  mov      w20, w0
006ADC87C  cbnz     w8, #0x6adc894
006ADC880  adrp     x0, #0x8f3c000
006ADC884  ldr      x0, [x0, #0x710]
006ADC888  bl       #0x382bd14 ; 
006ADC88C  mov      w8, #1
006ADC890  strb     w8, [x21, #0x165]
006ADC894  adrp     x8, #0x8f3c000
006ADC898  ldr      x8, [x8, #0x710]
006ADC89C  ldr      x2, [x8]
006ADC8A0  ldrb     w8, [x2, #0x53]
006ADC8A4  tbnz     w8, #5, #0x6adc8c4
006ADC8A8  str      w20, [x19, #0x20]
006ADC8AC  b        #0x6adc8d4 ; 
006ADC8B0  ldr      x2, [x1, #0x60]
006ADC8B4  mov      x0, x19
006ADC8B8  ldp      x20, x19, [sp, #0x10]
006ADC8BC  ldp      x30, x21, [sp], #0x20
006ADC8C0  br       x2
006ADC8C4  ldr      x8, [x2, #0x60]
006ADC8C8  mov      x0, x19
006ADC8CC  mov      w1, w20
006ADC8D0  blr      x8
006ADC8D4  mov      x0, x19
006ADC8D8  mov      x1, xzr
006ADC8DC  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006ADC8E0  adrp     x21, #0x959f000
006ADC8E4  ldrb     w8, [x21, #0x166]
006ADC8E8  mov      x20, x0
006ADC8EC  cbnz     w8, #0x6adc904
006ADC8F0  adrp     x0, #0x8f3c000
006ADC8F4  ldr      x0, [x0, #0x720]
006ADC8F8  bl       #0x382bd14 ; 
006ADC8FC  mov      w8, #1
006ADC900  strb     w8, [x21, #0x166]
006ADC904  adrp     x8, #0x8f3c000
006ADC908  ldr      x8, [x8, #0x720]
006ADC90C  ldr      x2, [x8]
006ADC910  ldrb     w8, [x2, #0x53]
006ADC914  tbnz     w8, #5, #0x6adc92c
006ADC918  str      x20, [x19, #0x28]!
006ADC91C  mov      x0, x19
006ADC920  mov      x1, x20
006ADC924  bl       #0x382bcb8 ; 
006ADC928  b        #0x6adc93c ; 
006ADC92C  ldr      x8, [x2, #0x60]
006ADC930  mov      x0, x19
006ADC934  mov      x1, x20
006ADC938  blr      x8
006ADC93C  ldp      x20, x19, [sp, #0x10]
006ADC940  mov      w0, #1
006ADC944  ldp      x30, x21, [sp], #0x20
006ADC948  ret      

