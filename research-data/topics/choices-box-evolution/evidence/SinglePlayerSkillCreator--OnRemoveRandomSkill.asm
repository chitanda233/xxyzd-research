; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnRemoveRandomSkill
; RVA 0x68744C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068744C4  str      x30, [sp, #-0x30]!
0068744C8  stp      x22, x21, [sp, #0x10]
0068744CC  stp      x20, x19, [sp, #0x20]
0068744D0  adrp     x21, #0x959b000
0068744D4  adrp     x22, #0x8f24000
0068744D8  ldrb     w8, [x21, #0xaad]
0068744DC  ldr      x22, [x22, #0x498] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnRemoveRandomSkill() @ 0x92aa9c0
0068744E0  mov      w19, w1
0068744E4  mov      x20, x0
0068744E8  tbnz     w8, #0, #0x6874500
0068744EC  adrp     x0, #0x8f24000
0068744F0  ldr      x0, [x0, #0x498] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnRemoveRandomSkill() @ 0x92aa9c0
0068744F4  bl       #0x382bd14 ; 
0068744F8  mov      w8, #1
0068744FC  strb     w8, [x21, #0xaad]
006874500  ldr      x2, [x22]
006874504  ldrb     w8, [x2, #0x53]
006874508  tbnz     w8, #5, #0x6874558
00687450C  mov      x0, x20
006874510  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006874514  cbz      x0, #0x6874634
006874518  adrp     x22, #0x959b000
00687451C  ldrb     w8, [x22, #0xb84]
006874520  mov      x21, x0
006874524  cbnz     w8, #0x687453c
006874528  adrp     x0, #0x8f23000
00687452C  ldr      x0, [x0, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
006874530  bl       #0x382bd14 ; 
006874534  mov      w8, #1
006874538  strb     w8, [x22, #0xb84]
00687453C  adrp     x8, #0x8f23000
006874540  ldr      x8, [x8, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
006874544  ldr      x1, [x8]
006874548  ldrb     w8, [x1, #0x53]
00687454C  tbnz     w8, #5, #0x6874574
006874550  ldr      w0, [x21, #0x2c4]
006874554  b        #0x6874580 ; 
006874558  ldr      x3, [x2, #0x60]
00687455C  mov      x0, x20
006874560  mov      w1, w19
006874564  ldp      x20, x19, [sp, #0x20]
006874568  ldp      x22, x21, [sp, #0x10]
00687456C  ldr      x30, [sp], #0x30
006874570  br       x3
006874574  ldr      x8, [x1, #0x60]
006874578  mov      x0, x21
00687457C  blr      x8
006874580  cmp      w0, #1
006874584  b.lt     #0x68745d4
006874588  ldr      x21, [x20, #0x18]
00687458C  cbz      x21, #0x6874634
006874590  ldr      w8, [x21, #0x18]
006874594  cmp      w8, #1
006874598  b.lt     #0x68745d4
00687459C  mov      w22, wzr
0068745A0  cmp      w22, w8
0068745A4  b.hs     #0x6874630
0068745A8  add      x8, x21, w22, sxtw #3
0068745AC  ldr      x0, [x8, #0x20]
0068745B0  cbz      x0, #0x6874634
0068745B4  mov      w1, w19
0068745B8  mov      w2, wzr
0068745BC  mov      x3, xzr
0068745C0  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
0068745C4  ldr      w8, [x21, #0x18]
0068745C8  add      w22, w22, #1
0068745CC  cmp      w22, w8
0068745D0  b.lt     #0x68745a0
0068745D4  ldr      x20, [x20, #0x20]
0068745D8  cbz      x20, #0x6874634
0068745DC  ldr      w8, [x20, #0x18]
0068745E0  cmp      w8, #1
0068745E4  b.lt     #0x6874620
0068745E8  mov      w21, wzr
0068745EC  cmp      w21, w8
0068745F0  b.hs     #0x6874630
0068745F4  add      x8, x20, w21, sxtw #3
0068745F8  ldr      x0, [x8, #0x20]
0068745FC  cbz      x0, #0x6874634
006874600  mov      w1, w19
006874604  mov      w2, wzr
006874608  mov      x3, xzr
00687460C  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
006874610  ldr      w8, [x20, #0x18]
006874614  add      w21, w21, #1
006874618  cmp      w21, w8
00687461C  b.lt     #0x68745ec
006874620  ldp      x20, x19, [sp, #0x20]
006874624  ldp      x22, x21, [sp, #0x10]
006874628  ldr      x30, [sp], #0x30
00687462C  ret      
006874630  bl       #0x382bfc0 ; 
006874634  bl       #0x382bfb8 ; 

