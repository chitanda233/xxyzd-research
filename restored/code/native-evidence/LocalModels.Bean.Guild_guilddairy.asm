; LocalModels.Bean.Guild_guilddairy$$readImpl
; RVA 0x6A9007C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A9007C  stp      x30, x21, [sp, #-0x20]!
006A90080  stp      x20, x19, [sp, #0x10]
006A90084  adrp     x20, #0x959e000
006A90088  adrp     x21, #0x8f38000
006A9008C  ldrb     w8, [x20, #0xe6]
006A90090  ldr      x21, [x21, #0xd80]
006A90094  mov      x19, x0
006A90098  tbnz     w8, #0, #0x6a900b0
006A9009C  adrp     x0, #0x8f38000
006A900A0  ldr      x0, [x0, #0xd80]
006A900A4  bl       #0x382bd14 ; 
006A900A8  mov      w8, #1
006A900AC  strb     w8, [x20, #0xe6]
006A900B0  ldr      x1, [x21]
006A900B4  ldrb     w8, [x1, #0x53]
006A900B8  tbnz     w8, #5, #0x6a90108
006A900BC  mov      x0, x19
006A900C0  mov      x1, xzr
006A900C4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A900C8  adrp     x21, #0x959e000
006A900CC  ldrb     w8, [x21, #0x5a7]
006A900D0  mov      w20, w0
006A900D4  cbnz     w8, #0x6a900ec
006A900D8  adrp     x0, #0x8f38000
006A900DC  ldr      x0, [x0, #0xd68]
006A900E0  bl       #0x382bd14 ; 
006A900E4  mov      w8, #1
006A900E8  strb     w8, [x21, #0x5a7]
006A900EC  adrp     x8, #0x8f38000
006A900F0  ldr      x8, [x8, #0xd68]
006A900F4  ldr      x2, [x8]
006A900F8  ldrb     w8, [x2, #0x53]
006A900FC  tbnz     w8, #5, #0x6a9011c
006A90100  str      w20, [x19, #0x20]
006A90104  b        #0x6a9012c ; 
006A90108  ldr      x2, [x1, #0x60]
006A9010C  mov      x0, x19
006A90110  ldp      x20, x19, [sp, #0x10]
006A90114  ldp      x30, x21, [sp], #0x20
006A90118  br       x2
006A9011C  ldr      x8, [x2, #0x60]
006A90120  mov      x0, x19
006A90124  mov      w1, w20
006A90128  blr      x8
006A9012C  mov      x0, x19
006A90130  mov      x1, xzr
006A90134  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A90138  adrp     x21, #0x959e000
006A9013C  ldrb     w8, [x21, #0x5a8]
006A90140  mov      w20, w0
006A90144  cbnz     w8, #0x6a9015c
006A90148  adrp     x0, #0x8f38000
006A9014C  ldr      x0, [x0, #0xd78]
006A90150  bl       #0x382bd14 ; 
006A90154  mov      w8, #1
006A90158  strb     w8, [x21, #0x5a8]
006A9015C  adrp     x8, #0x8f38000
006A90160  ldr      x8, [x8, #0xd78]
006A90164  ldr      x2, [x8]
006A90168  ldrb     w8, [x2, #0x53]
006A9016C  tbnz     w8, #5, #0x6a90178
006A90170  str      w20, [x19, #0x24]
006A90174  b        #0x6a90188 ; 
006A90178  ldr      x8, [x2, #0x60]
006A9017C  mov      x0, x19
006A90180  mov      w1, w20
006A90184  blr      x8
006A90188  ldp      x20, x19, [sp, #0x10]
006A9018C  mov      w0, #1
006A90190  ldp      x30, x21, [sp], #0x20
006A90194  ret      

