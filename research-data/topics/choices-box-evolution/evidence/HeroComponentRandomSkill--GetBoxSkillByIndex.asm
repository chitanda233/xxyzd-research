; HotFix.BattleLogic.HeroComponentRandomSkill$$GetBoxSkillByIndex
; RVA 0x6868148; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006868148  str      x30, [sp, #-0x30]!
00686814C  stp      x22, x21, [sp, #0x10]
006868150  stp      x20, x19, [sp, #0x20]
006868154  adrp     x21, #0x959b000
006868158  adrp     x22, #0x8f23000
00686815C  ldrb     w8, [x21, #0xa35]
006868160  ldr      x22, [x22, #0xf40] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.GetBoxSkillByIndex() @ 0x927f9c8
006868164  mov      w20, w1
006868168  mov      x19, x0
00686816C  tbnz     w8, #0, #0x6868184
006868170  adrp     x0, #0x8f23000
006868174  ldr      x0, [x0, #0xf40] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.GetBoxSkillByIndex() @ 0x927f9c8
006868178  bl       #0x382bd14 ; 
00686817C  mov      w8, #1
006868180  strb     w8, [x21, #0xa35]
006868184  ldr      x2, [x22]
006868188  ldrb     w8, [x2, #0x53]
00686818C  tbnz     w8, #5, #0x686819c
006868190  cbz      w20, #0x68681b8
006868194  ldr      w0, [x19, #0x68]
006868198  b        #0x68681bc ; 
00686819C  ldr      x3, [x2, #0x60]
0068681A0  mov      x0, x19
0068681A4  mov      w1, w20
0068681A8  ldp      x20, x19, [sp, #0x20]
0068681AC  ldp      x22, x21, [sp, #0x10]
0068681B0  ldr      x30, [sp], #0x30
0068681B4  br       x3
0068681B8  ldr      w0, [x19, #0x64]
0068681BC  ldp      x20, x19, [sp, #0x20]
0068681C0  ldp      x22, x21, [sp, #0x10]
0068681C4  ldr      x30, [sp], #0x30
0068681C8  ret      

