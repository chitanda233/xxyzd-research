; HotFix.BattleLogic.HeroComponentRandomSkill$$AdjustWeightsForSkillGroup
; RVA 0x686A17C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686A17C  stp      x30, x23, [sp, #-0x30]!
00686A180  stp      x22, x21, [sp, #0x10]
00686A184  stp      x20, x19, [sp, #0x20]
00686A188  adrp     x22, #0x959b000
00686A18C  adrp     x23, #0x8f24000
00686A190  ldrb     w8, [x22, #0xa68]
00686A194  ldr      x23, [x23, #0x38]
00686A198  mov      x19, x2
00686A19C  mov      w20, w1
00686A1A0  mov      x21, x0
00686A1A4  tbnz     w8, #0, #0x686a1bc
00686A1A8  adrp     x0, #0x8f24000
00686A1AC  ldr      x0, [x0, #0x38]
00686A1B0  bl       #0x382bd14 ; 
00686A1B4  mov      w8, #1
00686A1B8  strb     w8, [x22, #0xa68]
00686A1BC  ldr      x3, [x23]
00686A1C0  ldrb     w8, [x3, #0x53]
00686A1C4  tbnz     w8, #5, #0x686a1d8
00686A1C8  ldp      x20, x19, [sp, #0x20]
00686A1CC  ldp      x22, x21, [sp, #0x10]
00686A1D0  ldp      x30, x23, [sp], #0x30
00686A1D4  ret      
00686A1D8  ldr      x4, [x3, #0x60]
00686A1DC  mov      x0, x21
00686A1E0  mov      w1, w20
00686A1E4  mov      x2, x19
00686A1E8  ldp      x20, x19, [sp, #0x20]
00686A1EC  ldp      x22, x21, [sp, #0x10]
00686A1F0  ldp      x30, x23, [sp], #0x30
00686A1F4  br       x4

