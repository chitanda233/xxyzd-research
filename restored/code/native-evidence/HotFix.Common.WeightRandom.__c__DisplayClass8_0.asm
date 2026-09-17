; HotFix.Common.WeightRandom.<>c__DisplayClass8_0$$.ctor
; RVA 0x6B52A28; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B52A28  stp      x30, x21, [sp, #-0x20]!
006B52A2C  stp      x20, x19, [sp, #0x10]
006B52A30  adrp     x20, #0x959f000
006B52A34  adrp     x21, #0x8f41000
006B52A38  ldrb     w8, [x20, #0xc31]
006B52A3C  ldr      x21, [x21, #0x530]
006B52A40  mov      x19, x0
006B52A44  tbnz     w8, #0, #0x6b52a5c
006B52A48  adrp     x0, #0x8f41000
006B52A4C  ldr      x0, [x0, #0x530]
006B52A50  bl       #0x382bd14 ; 
006B52A54  mov      w8, #1
006B52A58  strb     w8, [x20, #0xc31]
006B52A5C  ldr      x1, [x21]
006B52A60  ldrb     w8, [x1, #0x53]
006B52A64  tbnz     w8, #5, #0x6b52a7c
006B52A68  mov      x0, x19
006B52A6C  ldp      x20, x19, [sp, #0x10]
006B52A70  mov      x1, xzr
006B52A74  ldp      x30, x21, [sp], #0x20
006B52A78  b        #0x7c335dc ; System.Object$$.ctor
006B52A7C  ldr      x2, [x1, #0x60]
006B52A80  mov      x0, x19
006B52A84  ldp      x20, x19, [sp, #0x10]
006B52A88  ldp      x30, x21, [sp], #0x20
006B52A8C  br       x2

; HotFix.Common.WeightRandom.<>c__DisplayClass8_0$$<AddWeight>b__0
; RVA 0x6B53458; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B53458  str      x30, [sp, #-0x30]!
006B5345C  stp      x22, x21, [sp, #0x10]
006B53460  stp      x20, x19, [sp, #0x20]
006B53464  adrp     x21, #0x959f000
006B53468  adrp     x22, #0x8f41000
006B5346C  ldrb     w8, [x21, #0xc32]
006B53470  ldr      x22, [x22, #0x520]
006B53474  mov      x19, x1
006B53478  mov      x20, x0
006B5347C  tbnz     w8, #0, #0x6b53494
006B53480  adrp     x0, #0x8f41000
006B53484  ldr      x0, [x0, #0x520]
006B53488  bl       #0x382bd14 ; 
006B5348C  mov      w8, #1
006B53490  strb     w8, [x21, #0xc32]
006B53494  ldr      x2, [x22]
006B53498  ldrb     w8, [x2, #0x53]
006B5349C  tbnz     w8, #5, #0x6b534c4
006B534A0  cbz      x19, #0x6b534e0
006B534A4  ldr      w8, [x19, #0x10]
006B534A8  ldr      w9, [x20, #0x10]
006B534AC  ldp      x20, x19, [sp, #0x20]
006B534B0  ldp      x22, x21, [sp, #0x10]
006B534B4  cmp      w8, w9
006B534B8  cset     w0, eq
006B534BC  ldr      x30, [sp], #0x30
006B534C0  ret      
006B534C4  ldr      x3, [x2, #0x60]
006B534C8  mov      x0, x20
006B534CC  mov      x1, x19
006B534D0  ldp      x20, x19, [sp, #0x20]
006B534D4  ldp      x22, x21, [sp, #0x10]
006B534D8  ldr      x30, [sp], #0x30
006B534DC  br       x3
006B534E0  bl       #0x382bfb8 ; 

