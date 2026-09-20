; HotFix.BattleLogic.PlayerSkillSelectState$$.cctor
; RVA 0x65B0514; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B0514  str      x30, [sp, #-0x20]!
0065B0518  stp      x20, x19, [sp, #0x10]
0065B051C  adrp     x19, #0x9599000
0065B0520  adrp     x20, #0x8f09000
0065B0524  ldrb     w8, [x19, #0x3fb]
0065B0528  ldr      x20, [x20, #0x9e0] ; GLOBAL HotFix.BattleLogic.PlayerSkillSelectState_TypeInfo @ 0x91ee048
0065B052C  tbnz     w8, #0, #0x65b0544
0065B0530  adrp     x0, #0x8f09000
0065B0534  ldr      x0, [x0, #0x9e0] ; GLOBAL HotFix.BattleLogic.PlayerSkillSelectState_TypeInfo @ 0x91ee048
0065B0538  bl       #0x382bd14 ; 
0065B053C  mov      w8, #1
0065B0540  strb     w8, [x19, #0x3fb]
0065B0544  ldr      x8, [x20]
0065B0548  adrp     x9, #0x197f000
0065B054C  ldr      d0, [x9, #0x450]
0065B0550  ldp      x20, x19, [sp, #0x10]
0065B0554  ldr      x8, [x8, #0xb8]
0065B0558  mov      w9, #2
0065B055C  str      d0, [x8]
0065B0560  str      w9, [x8, #8]
0065B0564  ldr      x30, [sp], #0x20
0065B0568  ret      

