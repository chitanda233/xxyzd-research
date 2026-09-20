; HotFix.BattleLogic.DankeSkillCreator$$GetReadyStudyRandomPool
; RVA 0x6863944; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006863944  stp      x30, x23, [sp, #-0x30]!
006863948  stp      x22, x21, [sp, #0x10]
00686394C  stp      x20, x19, [sp, #0x20]
006863950  adrp     x22, #0x959b000
006863954  adrp     x23, #0x8f23000
006863958  ldrb     w8, [x22, #0xa01]
00686395C  ldr      x23, [x23, #0xd60] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetReadyStudyRandomPool() @ 0x9259d80
006863960  mov      x19, x2
006863964  mov      x20, x1
006863968  mov      x21, x0
00686396C  tbnz     w8, #0, #0x6863984
006863970  adrp     x0, #0x8f23000
006863974  ldr      x0, [x0, #0xd60] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetReadyStudyRandomPool() @ 0x9259d80
006863978  bl       #0x382bd14 ; 
00686397C  mov      w8, #1
006863980  strb     w8, [x22, #0xa01]
006863984  ldr      x3, [x23]
006863988  ldrb     w8, [x3, #0x53]
00686398C  tbnz     w8, #5, #0x68639f8
006863990  cbz      x19, #0x6863a34
006863994  ldr      w9, [x19, #0x18]
006863998  cmp      w9, #1
00686399C  b.lt     #0x6863a18
0068639A0  mov      w8, wzr
0068639A4  mov      w21, wzr
0068639A8  cmp      w8, w9
0068639AC  b.hs     #0x6863a30
0068639B0  cbz      x20, #0x6863a34
0068639B4  ldr      w9, [x20, #0x18]
0068639B8  sxtw     x22, w8
0068639BC  cmp      w22, w9
0068639C0  b.hs     #0x6863a30
0068639C4  add      x8, x19, x22, lsl #3
0068639C8  ldr      x0, [x8, #0x20]
0068639CC  cbz      x0, #0x6863a34
0068639D0  add      x8, x20, x22, lsl #3
0068639D4  ldr      x1, [x8, #0x20]
0068639D8  mov      x2, xzr
0068639DC  bl       #0x6635318 ; HotFix.BattleLogic.WeightRandom$$GetReadyStudySkill
0068639E0  ldr      w9, [x19, #0x18]
0068639E4  add      w8, w22, #1
0068639E8  add      w21, w0, w21
0068639EC  cmp      w8, w9
0068639F0  b.lt     #0x68639a8
0068639F4  b        #0x6863a1c ; 
0068639F8  ldr      x4, [x3, #0x60]
0068639FC  mov      x0, x21
006863A00  mov      x1, x20
006863A04  mov      x2, x19
006863A08  ldp      x20, x19, [sp, #0x20]
006863A0C  ldp      x22, x21, [sp, #0x10]
006863A10  ldp      x30, x23, [sp], #0x30
006863A14  br       x4
006863A18  mov      w21, wzr
006863A1C  mov      w0, w21
006863A20  ldp      x20, x19, [sp, #0x20]
006863A24  ldp      x22, x21, [sp, #0x10]
006863A28  ldp      x30, x23, [sp], #0x30
006863A2C  ret      
006863A30  bl       #0x382bfc0 ; 
006863A34  bl       #0x382bfb8 ; 

