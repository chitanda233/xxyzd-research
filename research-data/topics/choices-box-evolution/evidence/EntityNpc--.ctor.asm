; HotFix.BattleLogic.EntityNpc$$.ctor
; RVA 0x68D3100; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D3100  stp      x30, x21, [sp, #-0x20]!
0068D3104  stp      x20, x19, [sp, #0x10]
0068D3108  adrp     x20, #0x959c000
0068D310C  adrp     x21, #0x8f28000
0068D3110  ldrb     w8, [x20, #0x772]
0068D3114  ldr      x21, [x21, #0x860] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc..ctor() @ 0x9263da0
0068D3118  mov      x19, x0
0068D311C  tbnz     w8, #0, #0x68d3140
0068D3120  adrp     x0, #0x8ee6000
0068D3124  ldr      x0, [x0, #0xf8] ; GLOBAL HotFix.BattleLogic.EntityCharacter_TypeInfo @ 0x91e5a90
0068D3128  bl       #0x382bd14 ; 
0068D312C  adrp     x0, #0x8f28000
0068D3130  ldr      x0, [x0, #0x860] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc..ctor() @ 0x9263da0
0068D3134  bl       #0x382bd14 ; 
0068D3138  mov      w8, #1
0068D313C  strb     w8, [x20, #0x772]
0068D3140  ldr      x1, [x21]
0068D3144  ldrb     w8, [x1, #0x53]
0068D3148  tbnz     w8, #5, #0x68d3178
0068D314C  adrp     x8, #0x8ee6000
0068D3150  ldr      x8, [x8, #0xf8] ; GLOBAL HotFix.BattleLogic.EntityCharacter_TypeInfo @ 0x91e5a90
0068D3154  ldr      x0, [x8]
0068D3158  ldr      w8, [x0, #0xe0]
0068D315C  cbnz     w8, #0x68d3164
0068D3160  bl       #0x382be8c ; 
0068D3164  mov      x0, x19
0068D3168  ldp      x20, x19, [sp, #0x10]
0068D316C  mov      x1, xzr
0068D3170  ldp      x30, x21, [sp], #0x20
0068D3174  b        #0x6804954 ; HotFix.BattleLogic.EntityCharacter$$.ctor
0068D3178  ldr      x2, [x1, #0x60]
0068D317C  mov      x0, x19
0068D3180  ldp      x20, x19, [sp, #0x10]
0068D3184  ldp      x30, x21, [sp], #0x20
0068D3188  br       x2

