; HotFix.BattleLogic.PlayerSkillSelectState$$.ctor
; RVA 0x65B04AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B04AC  stp      x30, x21, [sp, #-0x20]!
0065B04B0  stp      x20, x19, [sp, #0x10]
0065B04B4  adrp     x20, #0x9599000
0065B04B8  adrp     x21, #0x8f09000
0065B04BC  ldrb     w8, [x20, #0x3fa]
0065B04C0  ldr      x21, [x21, #0x9d8] ; GLOBAL Method$HotFix.BattleLogic.PlayerSkillSelectState..ctor() @ 0x929a3a8
0065B04C4  mov      x19, x0
0065B04C8  tbnz     w8, #0, #0x65b04e0
0065B04CC  adrp     x0, #0x8f09000
0065B04D0  ldr      x0, [x0, #0x9d8] ; GLOBAL Method$HotFix.BattleLogic.PlayerSkillSelectState..ctor() @ 0x929a3a8
0065B04D4  bl       #0x382bd14 ; 
0065B04D8  mov      w8, #1
0065B04DC  strb     w8, [x20, #0x3fa]
0065B04E0  ldr      x1, [x21]
0065B04E4  ldrb     w8, [x1, #0x53]
0065B04E8  tbnz     w8, #5, #0x65b0500
0065B04EC  mov      x0, x19
0065B04F0  ldp      x20, x19, [sp, #0x10]
0065B04F4  mov      x1, xzr
0065B04F8  ldp      x30, x21, [sp], #0x20
0065B04FC  b        #0x7c335dc ; System.Object$$.ctor
0065B0500  ldr      x2, [x1, #0x60]
0065B0504  mov      x0, x19
0065B0508  ldp      x20, x19, [sp, #0x10]
0065B050C  ldp      x30, x21, [sp], #0x20
0065B0510  br       x2

