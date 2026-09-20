; HotFix.BattleLogic.NormalSkillCreator$$RandomAngelSkill
; RVA 0x68735FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068735FC  stp      x30, x21, [sp, #-0x20]!
006873600  stp      x20, x19, [sp, #0x10]
006873604  adrp     x20, #0x959b000
006873608  adrp     x21, #0x8f24000
00687360C  ldrb     w8, [x20, #0xa97]
006873610  ldr      x21, [x21, #0x458] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.RandomAngelSkill() @ 0x9295ee0
006873614  mov      x19, x0
006873618  tbnz     w8, #0, #0x6873630
00687361C  adrp     x0, #0x8f24000
006873620  ldr      x0, [x0, #0x458] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.RandomAngelSkill() @ 0x9295ee0
006873624  bl       #0x382bd14 ; 
006873628  mov      w8, #1
00687362C  strb     w8, [x20, #0xa97]
006873630  ldr      x1, [x21]
006873634  ldrb     w8, [x1, #0x53]
006873638  tbnz     w8, #5, #0x6873674
00687363C  mov      x0, x19
006873640  bl       #0x68730f0 ; HotFix.BattleLogic.NormalSkillCreator$$AngelRandomSkillQuality
006873644  ldr      x8, [x19, #0x78]
006873648  cbz      x8, #0x6873688
00687364C  ldr      w9, [x8, #0x18]
006873650  cmp      w0, w9
006873654  b.hs     #0x687368c
006873658  add      x8, x8, w0, sxtw #3
00687365C  ldr      x0, [x8, #0x20]
006873660  cbz      x0, #0x6873688
006873664  ldp      x20, x19, [sp, #0x10]
006873668  mov      x1, xzr
00687366C  ldp      x30, x21, [sp], #0x20
006873670  b        #0x66339e8 ; HotFix.BattleLogic.WeightRandom$$GetRandom
006873674  ldr      x2, [x1, #0x60]
006873678  mov      x0, x19
00687367C  ldp      x20, x19, [sp, #0x10]
006873680  ldp      x30, x21, [sp], #0x20
006873684  br       x2
006873688  bl       #0x382bfb8 ; 
00687368C  bl       #0x382bfc0 ; 

