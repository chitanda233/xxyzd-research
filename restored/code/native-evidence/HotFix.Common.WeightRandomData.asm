; HotFix.Common.WeightRandomData$$.ctor
; RVA 0x6B52308; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B52308  stp      x30, x23, [sp, #-0x30]!
006B5230C  stp      x22, x21, [sp, #0x10]
006B52310  stp      x20, x19, [sp, #0x20]
006B52314  adrp     x22, #0x959f000
006B52318  adrp     x23, #0x8f41000
006B5231C  ldrb     w8, [x22, #0xc24]
006B52320  ldr      x23, [x23, #0x4a0]
006B52324  mov      w19, w2
006B52328  mov      w20, w1
006B5232C  mov      x21, x0
006B52330  tbnz     w8, #0, #0x6b52348
006B52334  adrp     x0, #0x8f41000
006B52338  ldr      x0, [x0, #0x4a0]
006B5233C  bl       #0x382bd14 ; 
006B52340  mov      w8, #1
006B52344  strb     w8, [x22, #0xc24]
006B52348  ldr      x3, [x23]
006B5234C  ldrb     w8, [x3, #0x53]
006B52350  tbnz     w8, #5, #0x6b52374
006B52354  mov      x0, x21
006B52358  mov      x1, xzr
006B5235C  bl       #0x7c335dc ; System.Object$$.ctor
006B52360  stp      w20, w19, [x21, #0x10]
006B52364  ldp      x20, x19, [sp, #0x20]
006B52368  ldp      x22, x21, [sp, #0x10]
006B5236C  ldp      x30, x23, [sp], #0x30
006B52370  ret      
006B52374  ldr      x4, [x3, #0x60]
006B52378  mov      x0, x21
006B5237C  mov      w1, w20
006B52380  mov      w2, w19
006B52384  ldp      x20, x19, [sp, #0x20]
006B52388  ldp      x22, x21, [sp, #0x10]
006B5238C  ldp      x30, x23, [sp], #0x30
006B52390  br       x4

