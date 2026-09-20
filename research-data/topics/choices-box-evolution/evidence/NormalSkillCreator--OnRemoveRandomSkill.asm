; HotFix.BattleLogic.NormalSkillCreator$$OnRemoveRandomSkill
; RVA 0x68743A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068743A4  stp      x30, x23, [sp, #-0x30]!
0068743A8  stp      x22, x21, [sp, #0x10]
0068743AC  stp      x20, x19, [sp, #0x20]
0068743B0  adrp     x21, #0x959b000
0068743B4  adrp     x22, #0x8f24000
0068743B8  ldrb     w8, [x21, #0xa9e]
0068743BC  ldr      x22, [x22, #0x490] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnRemoveRandomSkill() @ 0x9295ed0
0068743C0  mov      w19, w1
0068743C4  mov      x20, x0
0068743C8  tbnz     w8, #0, #0x68743e0
0068743CC  adrp     x0, #0x8f24000
0068743D0  ldr      x0, [x0, #0x490] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnRemoveRandomSkill() @ 0x9295ed0
0068743D4  bl       #0x382bd14 ; 
0068743D8  mov      w8, #1
0068743DC  strb     w8, [x21, #0xa9e]
0068743E0  ldr      x2, [x22]
0068743E4  ldrb     w8, [x2, #0x53]
0068743E8  tbnz     w8, #5, #0x68744a0
0068743EC  mov      x0, x20
0068743F0  mov      w1, w19
0068743F4  bl       #0x68744c4 ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnRemoveRandomSkill
0068743F8  ldr      x21, [x20, #0x80]
0068743FC  cbz      x21, #0x6874444
006874400  ldr      w8, [x21, #0x18]
006874404  cmp      w8, #1
006874408  b.lt     #0x6874444
00687440C  mov      x22, xzr
006874410  add      x23, x21, #0x20
006874414  cmp      w22, w8
006874418  b.hs     #0x68744bc
00687441C  ldr      x0, [x23, x22, lsl #3]
006874420  cbz      x0, #0x68744c0
006874424  mov      w1, w19
006874428  mov      w2, wzr
00687442C  mov      x3, xzr
006874430  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
006874434  ldr      w8, [x21, #0x18]
006874438  add      x22, x22, #1
00687443C  cmp      w22, w8
006874440  b.lt     #0x6874414
006874444  ldr      x20, [x20, #0x88]
006874448  cbz      x20, #0x68744c0
00687444C  ldr      w8, [x20, #0x18]
006874450  cmp      w8, #1
006874454  b.lt     #0x6874490
006874458  mov      w21, wzr
00687445C  cmp      w21, w8
006874460  b.hs     #0x68744bc
006874464  add      x8, x20, w21, sxtw #3
006874468  ldr      x0, [x8, #0x20]
00687446C  cbz      x0, #0x68744c0
006874470  mov      w1, w19
006874474  mov      w2, wzr
006874478  mov      x3, xzr
00687447C  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
006874480  ldr      w8, [x20, #0x18]
006874484  add      w21, w21, #1
006874488  cmp      w21, w8
00687448C  b.lt     #0x687445c
006874490  ldp      x20, x19, [sp, #0x20]
006874494  ldp      x22, x21, [sp, #0x10]
006874498  ldp      x30, x23, [sp], #0x30
00687449C  ret      
0068744A0  ldr      x3, [x2, #0x60]
0068744A4  mov      x0, x20
0068744A8  mov      w1, w19
0068744AC  ldp      x20, x19, [sp, #0x20]
0068744B0  ldp      x22, x21, [sp, #0x10]
0068744B4  ldp      x30, x23, [sp], #0x30
0068744B8  br       x3
0068744BC  bl       #0x382bfc0 ; 
0068744C0  bl       #0x382bfb8 ; 

