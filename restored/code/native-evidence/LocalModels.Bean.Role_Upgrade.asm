; LocalModels.Bean.Role_Upgrade$$readImpl
; RVA 0x6AE302C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006AE302C  stp      x30, x21, [sp, #-0x20]!
006AE3030  stp      x20, x19, [sp, #0x10]
006AE3034  adrp     x20, #0x959e000
006AE3038  adrp     x21, #0x8f3c000
006AE303C  ldrb     w8, [x20, #0xcf8]
006AE3040  ldr      x21, [x21, #0xba8]
006AE3044  mov      x19, x0
006AE3048  tbnz     w8, #0, #0x6ae3060
006AE304C  adrp     x0, #0x8f3c000
006AE3050  ldr      x0, [x0, #0xba8]
006AE3054  bl       #0x382bd14 ; 
006AE3058  mov      w8, #1
006AE305C  strb     w8, [x20, #0xcf8]
006AE3060  ldr      x1, [x21]
006AE3064  ldrb     w8, [x1, #0x53]
006AE3068  tbnz     w8, #5, #0x6ae30b8
006AE306C  mov      x0, x19
006AE3070  mov      x1, xzr
006AE3074  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE3078  adrp     x21, #0x959f000
006AE307C  ldrb     w8, [x21, #0x1b2]
006AE3080  mov      w20, w0
006AE3084  cbnz     w8, #0x6ae309c
006AE3088  adrp     x0, #0x8f3c000
006AE308C  ldr      x0, [x0, #0xb80]
006AE3090  bl       #0x382bd14 ; 
006AE3094  mov      w8, #1
006AE3098  strb     w8, [x21, #0x1b2]
006AE309C  adrp     x8, #0x8f3c000
006AE30A0  ldr      x8, [x8, #0xb80]
006AE30A4  ldr      x2, [x8]
006AE30A8  ldrb     w8, [x2, #0x53]
006AE30AC  tbnz     w8, #5, #0x6ae30cc
006AE30B0  str      w20, [x19, #0x20]
006AE30B4  b        #0x6ae30dc ; 
006AE30B8  ldr      x2, [x1, #0x60]
006AE30BC  mov      x0, x19
006AE30C0  ldp      x20, x19, [sp, #0x10]
006AE30C4  ldp      x30, x21, [sp], #0x20
006AE30C8  br       x2
006AE30CC  ldr      x8, [x2, #0x60]
006AE30D0  mov      x0, x19
006AE30D4  mov      w1, w20
006AE30D8  blr      x8
006AE30DC  mov      x0, x19
006AE30E0  mov      x1, xzr
006AE30E4  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE30E8  adrp     x21, #0x959f000
006AE30EC  ldrb     w8, [x21, #0x1b3]
006AE30F0  mov      w20, w0
006AE30F4  cbnz     w8, #0x6ae310c
006AE30F8  adrp     x0, #0x8f3c000
006AE30FC  ldr      x0, [x0, #0xb90]
006AE3100  bl       #0x382bd14 ; 
006AE3104  mov      w8, #1
006AE3108  strb     w8, [x21, #0x1b3]
006AE310C  adrp     x8, #0x8f3c000
006AE3110  ldr      x8, [x8, #0xb90]
006AE3114  ldr      x2, [x8]
006AE3118  ldrb     w8, [x2, #0x53]
006AE311C  tbnz     w8, #5, #0x6ae3128
006AE3120  str      w20, [x19, #0x24]
006AE3124  b        #0x6ae3138 ; 
006AE3128  ldr      x8, [x2, #0x60]
006AE312C  mov      x0, x19
006AE3130  mov      w1, w20
006AE3134  blr      x8
006AE3138  mov      x0, x19
006AE313C  mov      x1, xzr
006AE3140  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006AE3144  adrp     x21, #0x959f000
006AE3148  ldrb     w8, [x21, #0x1b4]
006AE314C  mov      w20, w0
006AE3150  cbnz     w8, #0x6ae3168
006AE3154  adrp     x0, #0x8f3c000
006AE3158  ldr      x0, [x0, #0xba0]
006AE315C  bl       #0x382bd14 ; 
006AE3160  mov      w8, #1
006AE3164  strb     w8, [x21, #0x1b4]
006AE3168  adrp     x8, #0x8f3c000
006AE316C  ldr      x8, [x8, #0xba0]
006AE3170  ldr      x2, [x8]
006AE3174  ldrb     w8, [x2, #0x53]
006AE3178  tbnz     w8, #5, #0x6ae3184
006AE317C  str      w20, [x19, #0x28]
006AE3180  b        #0x6ae3194 ; 
006AE3184  ldr      x8, [x2, #0x60]
006AE3188  mov      x0, x19
006AE318C  mov      w1, w20
006AE3190  blr      x8
006AE3194  ldp      x20, x19, [sp, #0x10]
006AE3198  mov      w0, #1
006AE319C  ldp      x30, x21, [sp], #0x20
006AE31A0  ret      

