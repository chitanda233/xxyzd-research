; LocalModels.Bean.Reward_reward$$readImpl
; RVA 0x6ADC428; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006ADC428  stp      x30, x21, [sp, #-0x20]!
006ADC42C  stp      x20, x19, [sp, #0x10]
006ADC430  adrp     x20, #0x959e000
006ADC434  adrp     x21, #0x8f3c000
006ADC438  ldrb     w8, [x20, #0xc4c]
006ADC43C  ldr      x21, [x21, #0x6f8]
006ADC440  mov      x19, x0
006ADC444  tbnz     w8, #0, #0x6adc45c
006ADC448  adrp     x0, #0x8f3c000
006ADC44C  ldr      x0, [x0, #0x6f8]
006ADC450  bl       #0x382bd14 ; 
006ADC454  mov      w8, #1
006ADC458  strb     w8, [x20, #0xc4c]
006ADC45C  ldr      x1, [x21]
006ADC460  ldrb     w8, [x1, #0x53]
006ADC464  tbnz     w8, #5, #0x6adc4b4
006ADC468  mov      x0, x19
006ADC46C  mov      x1, xzr
006ADC470  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006ADC474  adrp     x21, #0x959f000
006ADC478  ldrb     w8, [x21, #0x163]
006ADC47C  mov      w20, w0
006ADC480  cbnz     w8, #0x6adc498
006ADC484  adrp     x0, #0x8f3c000
006ADC488  ldr      x0, [x0, #0x6e0]
006ADC48C  bl       #0x382bd14 ; 
006ADC490  mov      w8, #1
006ADC494  strb     w8, [x21, #0x163]
006ADC498  adrp     x8, #0x8f3c000
006ADC49C  ldr      x8, [x8, #0x6e0]
006ADC4A0  ldr      x2, [x8]
006ADC4A4  ldrb     w8, [x2, #0x53]
006ADC4A8  tbnz     w8, #5, #0x6adc4c8
006ADC4AC  str      w20, [x19, #0x20]
006ADC4B0  b        #0x6adc4d8 ; 
006ADC4B4  ldr      x2, [x1, #0x60]
006ADC4B8  mov      x0, x19
006ADC4BC  ldp      x20, x19, [sp, #0x10]
006ADC4C0  ldp      x30, x21, [sp], #0x20
006ADC4C4  br       x2
006ADC4C8  ldr      x8, [x2, #0x60]
006ADC4CC  mov      x0, x19
006ADC4D0  mov      w1, w20
006ADC4D4  blr      x8
006ADC4D8  mov      x0, x19
006ADC4DC  mov      x1, xzr
006ADC4E0  bl       #0x64cacc8 ; LocalModels.BaseLocalBean$$readArraystring
006ADC4E4  adrp     x21, #0x959f000
006ADC4E8  ldrb     w8, [x21, #0x164]
006ADC4EC  mov      x20, x0
006ADC4F0  cbnz     w8, #0x6adc508
006ADC4F4  adrp     x0, #0x8f3c000
006ADC4F8  ldr      x0, [x0, #0x6f0]
006ADC4FC  bl       #0x382bd14 ; 
006ADC500  mov      w8, #1
006ADC504  strb     w8, [x21, #0x164]
006ADC508  adrp     x8, #0x8f3c000
006ADC50C  ldr      x8, [x8, #0x6f0]
006ADC510  ldr      x2, [x8]
006ADC514  ldrb     w8, [x2, #0x53]
006ADC518  tbnz     w8, #5, #0x6adc530
006ADC51C  str      x20, [x19, #0x28]!
006ADC520  mov      x0, x19
006ADC524  mov      x1, x20
006ADC528  bl       #0x382bcb8 ; 
006ADC52C  b        #0x6adc540 ; 
006ADC530  ldr      x8, [x2, #0x60]
006ADC534  mov      x0, x19
006ADC538  mov      x1, x20
006ADC53C  blr      x8
006ADC540  ldp      x20, x19, [sp, #0x10]
006ADC544  mov      w0, #1
006ADC548  ldp      x30, x21, [sp], #0x20
006ADC54C  ret      

