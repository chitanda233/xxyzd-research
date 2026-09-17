; LocalModels.Bean.Bullet_OutsideBulletHurtGrowth$$readImpl
; RVA 0x688CAFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00688CAFC  stp      x30, x21, [sp, #-0x20]!
00688CB00  stp      x20, x19, [sp, #0x10]
00688CB04  adrp     x20, #0x959b000
00688CB08  adrp     x21, #0x8f25000
00688CB0C  ldrb     w8, [x20, #0xcc0]
00688CB10  ldr      x21, [x21, #0x410]
00688CB14  mov      x19, x0
00688CB18  tbnz     w8, #0, #0x688cb30
00688CB1C  adrp     x0, #0x8f25000
00688CB20  ldr      x0, [x0, #0x410]
00688CB24  bl       #0x382bd14 ; 
00688CB28  mov      w8, #1
00688CB2C  strb     w8, [x20, #0xcc0]
00688CB30  ldr      x1, [x21]
00688CB34  ldrb     w8, [x1, #0x53]
00688CB38  tbnz     w8, #5, #0x688cb88
00688CB3C  mov      x0, x19
00688CB40  mov      x1, xzr
00688CB44  bl       #0x64c9dfc ; LocalModels.BaseLocalBean$$readInt
00688CB48  adrp     x21, #0x959c000
00688CB4C  ldrb     w8, [x21, #0x43a]
00688CB50  mov      w20, w0
00688CB54  cbnz     w8, #0x688cb6c
00688CB58  adrp     x0, #0x8f25000
00688CB5C  ldr      x0, [x0, #0x3f8]
00688CB60  bl       #0x382bd14 ; 
00688CB64  mov      w8, #1
00688CB68  strb     w8, [x21, #0x43a]
00688CB6C  adrp     x8, #0x8f25000
00688CB70  ldr      x8, [x8, #0x3f8]
00688CB74  ldr      x2, [x8]
00688CB78  ldrb     w8, [x2, #0x53]
00688CB7C  tbnz     w8, #5, #0x688cb9c
00688CB80  str      w20, [x19, #0x20]
00688CB84  b        #0x688cbac ; 
00688CB88  ldr      x2, [x1, #0x60]
00688CB8C  mov      x0, x19
00688CB90  ldp      x20, x19, [sp, #0x10]
00688CB94  ldp      x30, x21, [sp], #0x20
00688CB98  br       x2
00688CB9C  ldr      x8, [x2, #0x60]
00688CBA0  mov      x0, x19
00688CBA4  mov      w1, w20
00688CBA8  blr      x8
00688CBAC  mov      x0, x19
00688CBB0  mov      x1, xzr
00688CBB4  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688CBB8  adrp     x21, #0x959c000
00688CBBC  ldrb     w8, [x21, #0x43b]
00688CBC0  mov      x20, x0
00688CBC4  cbnz     w8, #0x688cbdc
00688CBC8  adrp     x0, #0x8f25000
00688CBCC  ldr      x0, [x0, #0x400]
00688CBD0  bl       #0x382bd14 ; 
00688CBD4  mov      w8, #1
00688CBD8  strb     w8, [x21, #0x43b]
00688CBDC  adrp     x8, #0x8f25000
00688CBE0  ldr      x8, [x8, #0x400]
00688CBE4  ldr      x2, [x8]
00688CBE8  ldrb     w8, [x2, #0x53]
00688CBEC  tbnz     w8, #5, #0x688cbf8
00688CBF0  str      x20, [x19, #0x28]
00688CBF4  b        #0x688cc08 ; 
00688CBF8  ldr      x8, [x2, #0x60]
00688CBFC  mov      x0, x19
00688CC00  mov      x1, x20
00688CC04  blr      x8
00688CC08  mov      x0, x19
00688CC0C  mov      x1, xzr
00688CC10  bl       #0x64ca3f4 ; LocalModels.BaseLocalBean$$readFp
00688CC14  adrp     x21, #0x959c000
00688CC18  ldrb     w8, [x21, #0x43c]
00688CC1C  mov      x20, x0
00688CC20  cbnz     w8, #0x688cc38
00688CC24  adrp     x0, #0x8f25000
00688CC28  ldr      x0, [x0, #0x408]
00688CC2C  bl       #0x382bd14 ; 
00688CC30  mov      w8, #1
00688CC34  strb     w8, [x21, #0x43c]
00688CC38  adrp     x8, #0x8f25000
00688CC3C  ldr      x8, [x8, #0x408]
00688CC40  ldr      x2, [x8]
00688CC44  ldrb     w8, [x2, #0x53]
00688CC48  tbnz     w8, #5, #0x688cc54
00688CC4C  str      x20, [x19, #0x30]
00688CC50  b        #0x688cc64 ; 
00688CC54  ldr      x8, [x2, #0x60]
00688CC58  mov      x0, x19
00688CC5C  mov      x1, x20
00688CC60  blr      x8
00688CC64  ldp      x20, x19, [sp, #0x10]
00688CC68  mov      w0, #1
00688CC6C  ldp      x30, x21, [sp], #0x20
00688CC70  ret      

