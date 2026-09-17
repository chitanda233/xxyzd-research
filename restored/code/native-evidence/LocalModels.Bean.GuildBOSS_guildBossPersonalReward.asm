; LocalModels.Bean.GuildBOSS_guildBossPersonalReward$$readImpl
; RVA 0x6A88264; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A88264  stp      x30, x21, [sp, #-0x20]!
006A88268  stp      x20, x19, [sp, #0x10]
006A8826C  adrp     x20, #0x959e000
006A88270  adrp     x21, #0x8f38000
006A88274  ldrb     w8, [x20, #0x13]
006A88278  ldr      x21, [x21, #0x7f0]
006A8827C  mov      x19, x0
006A88280  tbnz     w8, #0, #0x6a88298
006A88284  adrp     x0, #0x8f38000
006A88288  ldr      x0, [x0, #0x7f0]
006A8828C  bl       #0x382bd14 ; 
006A88290  mov      w8, #1
006A88294  strb     w8, [x20, #0x13]
006A88298  ldr      x1, [x21]
006A8829C  ldrb     w8, [x1, #0x53]
006A882A0  tbnz     w8, #5, #0x6a882f0
006A882A4  mov      x0, x19
006A882A8  mov      x1, xzr
006A882AC  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
006A882B0  adrp     x21, #0x959e000
006A882B4  ldrb     w8, [x21, #0x553]
006A882B8  mov      w20, w0
006A882BC  cbnz     w8, #0x6a882d4
006A882C0  adrp     x0, #0x8f38000
006A882C4  ldr      x0, [x0, #0x7d0]
006A882C8  bl       #0x382bd14 ; 
006A882CC  mov      w8, #1
006A882D0  strb     w8, [x21, #0x553]
006A882D4  adrp     x8, #0x8f38000
006A882D8  ldr      x8, [x8, #0x7d0]
006A882DC  ldr      x2, [x8]
006A882E0  ldrb     w8, [x2, #0x53]
006A882E4  tbnz     w8, #5, #0x6a88304
006A882E8  str      w20, [x19, #0x20]
006A882EC  b        #0x6a88314 ; 
006A882F0  ldr      x2, [x1, #0x60]
006A882F4  mov      x0, x19
006A882F8  ldp      x20, x19, [sp, #0x10]
006A882FC  ldp      x30, x21, [sp], #0x20
006A88300  br       x2
006A88304  ldr      x8, [x2, #0x60]
006A88308  mov      x0, x19
006A8830C  mov      w1, w20
006A88310  blr      x8
006A88314  mov      x0, x19
006A88318  mov      x1, xzr
006A8831C  bl       #0x64ca168 ; LocalModels.BaseLocalBean$$readLong
006A88320  adrp     x21, #0x959e000
006A88324  ldrb     w8, [x21, #0x554]
006A88328  mov      x20, x0
006A8832C  cbnz     w8, #0x6a88344
006A88330  adrp     x0, #0x8f38000
006A88334  ldr      x0, [x0, #0x7d8]
006A88338  bl       #0x382bd14 ; 
006A8833C  mov      w8, #1
006A88340  strb     w8, [x21, #0x554]
006A88344  adrp     x8, #0x8f38000
006A88348  ldr      x8, [x8, #0x7d8]
006A8834C  ldr      x2, [x8]
006A88350  ldrb     w8, [x2, #0x53]
006A88354  tbnz     w8, #5, #0x6a88360
006A88358  str      x20, [x19, #0x28]
006A8835C  b        #0x6a88370 ; 
006A88360  ldr      x8, [x2, #0x60]
006A88364  mov      x0, x19
006A88368  mov      x1, x20
006A8836C  blr      x8
006A88370  mov      x0, x19
006A88374  mov      x1, xzr
006A88378  bl       #0x64ca908 ; LocalModels.BaseLocalBean$$readArrayArrayint
006A8837C  adrp     x21, #0x959e000
006A88380  ldrb     w8, [x21, #0x555]
006A88384  mov      x20, x0
006A88388  cbnz     w8, #0x6a883a0
006A8838C  adrp     x0, #0x8f38000
006A88390  ldr      x0, [x0, #0x7e8]
006A88394  bl       #0x382bd14 ; 
006A88398  mov      w8, #1
006A8839C  strb     w8, [x21, #0x555]
006A883A0  adrp     x8, #0x8f38000
006A883A4  ldr      x8, [x8, #0x7e8]
006A883A8  ldr      x2, [x8]
006A883AC  ldrb     w8, [x2, #0x53]
006A883B0  tbnz     w8, #5, #0x6a883c8
006A883B4  str      x20, [x19, #0x30]!
006A883B8  mov      x0, x19
006A883BC  mov      x1, x20
006A883C0  bl       #0x382bcb8 ; 
006A883C4  b        #0x6a883d8 ; 
006A883C8  ldr      x8, [x2, #0x60]
006A883CC  mov      x0, x19
006A883D0  mov      x1, x20
006A883D4  blr      x8
006A883D8  ldp      x20, x19, [sp, #0x10]
006A883DC  mov      w0, #1
006A883E0  ldp      x30, x21, [sp], #0x20
006A883E4  ret      

