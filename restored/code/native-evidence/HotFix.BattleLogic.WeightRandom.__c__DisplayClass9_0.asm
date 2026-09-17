; HotFix.BattleLogic.WeightRandom.<>c__DisplayClass9_0$$.ctor
; RVA 0x66329B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066329B0  stp      x30, x21, [sp, #-0x20]!
0066329B4  stp      x20, x19, [sp, #0x10]
0066329B8  adrp     x20, #0x9599000
0066329BC  adrp     x21, #0x8f0c000
0066329C0  ldrb     w8, [x20, #0x9f9]
0066329C4  ldr      x21, [x21, #0xf38]
0066329C8  mov      x19, x0
0066329CC  tbnz     w8, #0, #0x66329e4
0066329D0  adrp     x0, #0x8f0c000
0066329D4  ldr      x0, [x0, #0xf38]
0066329D8  bl       #0x382bd14 ; 
0066329DC  mov      w8, #1
0066329E0  strb     w8, [x20, #0x9f9]
0066329E4  ldr      x1, [x21]
0066329E8  ldrb     w8, [x1, #0x53]
0066329EC  tbnz     w8, #5, #0x6632a04
0066329F0  mov      x0, x19
0066329F4  ldp      x20, x19, [sp, #0x10]
0066329F8  mov      x1, xzr
0066329FC  ldp      x30, x21, [sp], #0x20
006632A00  b        #0x7c335dc ; System.Object$$.ctor
006632A04  ldr      x2, [x1, #0x60]
006632A08  mov      x0, x19
006632A0C  ldp      x20, x19, [sp, #0x10]
006632A10  ldp      x30, x21, [sp], #0x20
006632A14  br       x2

; HotFix.BattleLogic.WeightRandom.<>c__DisplayClass9_0$$<UpdateWeightPercent>b__0
; RVA 0x663688C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00663688C  str      x30, [sp, #-0x30]!
006636890  stp      x22, x21, [sp, #0x10]
006636894  stp      x20, x19, [sp, #0x20]
006636898  adrp     x21, #0x9599000
00663689C  adrp     x22, #0x8f0c000
0066368A0  ldrb     w8, [x21, #0x9fa]
0066368A4  ldr      x22, [x22, #0xf28]
0066368A8  mov      w19, w1
0066368AC  mov      x20, x0
0066368B0  tbnz     w8, #0, #0x66368c8
0066368B4  adrp     x0, #0x8f0c000
0066368B8  ldr      x0, [x0, #0xf28]
0066368BC  bl       #0x382bd14 ; 
0066368C0  mov      w8, #1
0066368C4  strb     w8, [x21, #0x9fa]
0066368C8  ldr      x2, [x22]
0066368CC  ldrb     w8, [x2, #0x53]
0066368D0  tbnz     w8, #5, #0x66368f0
0066368D4  ldr      w8, [x20, #0x10]
0066368D8  ldp      x22, x21, [sp, #0x10]
0066368DC  cmp      w8, w19
0066368E0  ldp      x20, x19, [sp, #0x20]
0066368E4  cset     w0, eq
0066368E8  ldr      x30, [sp], #0x30
0066368EC  ret      
0066368F0  ldr      x3, [x2, #0x60]
0066368F4  mov      x0, x20
0066368F8  mov      w1, w19
0066368FC  ldp      x20, x19, [sp, #0x20]
006636900  ldp      x22, x21, [sp, #0x10]
006636904  ldr      x30, [sp], #0x30
006636908  br       x3

