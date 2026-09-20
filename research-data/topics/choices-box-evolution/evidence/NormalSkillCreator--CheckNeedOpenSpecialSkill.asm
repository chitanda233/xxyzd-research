; HotFix.BattleLogic.NormalSkillCreator$$CheckNeedOpenSpecialSkill
; RVA 0x6873728; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006873728  stp      x30, x21, [sp, #-0x20]!
00687372C  stp      x20, x19, [sp, #0x10]
006873730  adrp     x20, #0x959b000
006873734  adrp     x21, #0x8f24000
006873738  ldrb     w8, [x20, #0xa9a]
00687373C  ldr      x21, [x21, #0x468] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.CheckNeedOpenSpecialSkill() @ 0x9295e70
006873740  mov      x19, x0
006873744  tbnz     w8, #0, #0x687375c
006873748  adrp     x0, #0x8f24000
00687374C  ldr      x0, [x0, #0x468] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.CheckNeedOpenSpecialSkill() @ 0x9295e70
006873750  bl       #0x382bd14 ; 
006873754  mov      w8, #1
006873758  strb     w8, [x20, #0xa9a]
00687375C  ldr      x1, [x21]
006873760  ldrb     w8, [x1, #0x53]
006873764  tbnz     w8, #5, #0x6873778
006873768  ldp      x20, x19, [sp, #0x10]
00687376C  mov      w0, wzr
006873770  ldp      x30, x21, [sp], #0x20
006873774  ret      
006873778  ldr      x2, [x1, #0x60]
00687377C  mov      x0, x19
006873780  ldp      x20, x19, [sp, #0x10]
006873784  ldp      x30, x21, [sp], #0x20
006873788  br       x2

