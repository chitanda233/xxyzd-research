; HotFix.BattleLogic.NormalSkillCreator$$.ctor
; RVA 0x6866460; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006866460  stp      x30, x21, [sp, #-0x20]!
006866464  stp      x20, x19, [sp, #0x10]
006866468  adrp     x20, #0x959b000
00686646C  adrp     x21, #0x8f23000
006866470  ldrb     w8, [x20, #0xaa6]
006866474  ldr      x21, [x21, #0xe28] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator..ctor() @ 0x9295e58
006866478  mov      x19, x0
00686647C  tbnz     w8, #0, #0x68664ac
006866480  adrp     x0, #0x8ee8000
006866484  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006866488  bl       #0x382bd14 ; 
00686648C  adrp     x0, #0x8f23000
006866490  ldr      x0, [x0, #0xe28] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator..ctor() @ 0x9295e58
006866494  bl       #0x382bd14 ; 
006866498  adrp     x0, #0x8f23000
00686649C  ldr      x0, [x0, #0xb08] ; GLOBAL HotFix.BattleLogic.WeightRandom[]_TypeInfo @ 0x91df948
0068664A0  bl       #0x382bd14 ; 
0068664A4  mov      w8, #1
0068664A8  strb     w8, [x20, #0xaa6]
0068664AC  ldr      x1, [x21]
0068664B0  ldrb     w8, [x1, #0x53]
0068664B4  tbnz     w8, #5, #0x6866528
0068664B8  adrp     x21, #0x8ee8000
0068664BC  ldr      x21, [x21, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0068664C0  adrp     x20, #0x8f23000
0068664C4  ldr      x0, [x21]
0068664C8  ldr      w8, [x0, #0xe0]
0068664CC  ldr      x20, [x20, #0xb08] ; GLOBAL HotFix.BattleLogic.WeightRandom[]_TypeInfo @ 0x91df948
0068664D0  cbnz     w8, #0x68664dc
0068664D4  bl       #0x382be8c ; 
0068664D8  ldr      x0, [x21]
0068664DC  ldr      x8, [x0, #0xb8]
0068664E0  ldr      x0, [x20]
0068664E4  ldr      w1, [x8, #0x2f0]
0068664E8  bl       #0x382bdfc ; 
0068664EC  mov      x1, x0
0068664F0  mov      x0, x19
0068664F4  str      x1, [x0, #0x78]!
0068664F8  bl       #0x382bcb8 ; 
0068664FC  ldr      x0, [x20]
006866500  mov      w1, #3
006866504  bl       #0x382bdfc ; 
006866508  mov      x1, x0
00686650C  mov      x0, x19
006866510  str      x1, [x0, #0x88]!
006866514  bl       #0x382bcb8 ; 
006866518  mov      x0, x19
00686651C  ldp      x20, x19, [sp, #0x10]
006866520  ldp      x30, x21, [sp], #0x20
006866524  b        #0x685cb68 ; HotFix.BattleLogic.SinglePlayerSkillCreator$$.ctor
006866528  ldr      x2, [x1, #0x60]
00686652C  mov      x0, x19
006866530  ldp      x20, x19, [sp, #0x10]
006866534  ldp      x30, x21, [sp], #0x20
006866538  br       x2

