; HotFix.BattleLogic.NormalSkillCreator$$OnAddSkillFlag
; RVA 0x6874740; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874740  str      x30, [sp, #-0x30]!
006874744  stp      x22, x21, [sp, #0x10]
006874748  stp      x20, x19, [sp, #0x20]
00687474C  adrp     x21, #0x959b000
006874750  adrp     x22, #0x8f24000
006874754  ldrb     w8, [x21, #0xaa0]
006874758  ldr      x22, [x22, #0x4b0] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnAddSkillFlag() @ 0x9295ea8
00687475C  mov      w19, w1
006874760  mov      x20, x0
006874764  tbnz     w8, #0, #0x687477c
006874768  adrp     x0, #0x8f24000
00687476C  ldr      x0, [x0, #0x4b0] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnAddSkillFlag() @ 0x9295ea8
006874770  bl       #0x382bd14 ; 
006874774  mov      w8, #1
006874778  strb     w8, [x21, #0xaa0]
00687477C  ldr      x2, [x22]
006874780  ldrb     w8, [x2, #0x53]
006874784  tbnz     w8, #5, #0x6874854
006874788  mov      x0, x20
00687478C  mov      w1, w19
006874790  bl       #0x6874878 ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddSkillFlag
006874794  ldr      x8, [x20, #0x80]
006874798  cbz      x8, #0x68747fc
00687479C  ldr      x8, [x20]
0068747A0  mov      x0, x20
0068747A4  ldr      x9, [x8, #0x2e8]
0068747A8  ldr      x1, [x8, #0x2f0]
0068747AC  blr      x9
0068747B0  tbz      w0, #0, #0x68747fc
0068747B4  ldr      x21, [x20, #0x80]
0068747B8  cbz      x21, #0x6874870
0068747BC  ldr      w8, [x21, #0x18]
0068747C0  cmp      w8, #1
0068747C4  b.lt     #0x68747fc
0068747C8  mov      w22, wzr
0068747CC  cmp      w22, w8
0068747D0  b.hs     #0x6874874
0068747D4  add      x8, x21, w22, sxtw #3
0068747D8  ldr      x0, [x8, #0x20]
0068747DC  cbz      x0, #0x6874870
0068747E0  mov      w1, w19
0068747E4  mov      x2, xzr
0068747E8  bl       #0x66334d8 ; HotFix.BattleLogic.WeightRandom$$OnAddFlag
0068747EC  ldr      w8, [x21, #0x18]
0068747F0  add      w22, w22, #1
0068747F4  cmp      w22, w8
0068747F8  b.lt     #0x68747cc
0068747FC  ldr      x20, [x20, #0x88]
006874800  cbz      x20, #0x6874870
006874804  ldr      w8, [x20, #0x18]
006874808  cmp      w8, #1
00687480C  b.lt     #0x6874844
006874810  mov      w21, wzr
006874814  cmp      w21, w8
006874818  b.hs     #0x6874874
00687481C  add      x8, x20, w21, sxtw #3
006874820  ldr      x0, [x8, #0x20]
006874824  cbz      x0, #0x6874870
006874828  mov      w1, w19
00687482C  mov      x2, xzr
006874830  bl       #0x66334d8 ; HotFix.BattleLogic.WeightRandom$$OnAddFlag
006874834  ldr      w8, [x20, #0x18]
006874838  add      w21, w21, #1
00687483C  cmp      w21, w8
006874840  b.lt     #0x6874814
006874844  ldp      x20, x19, [sp, #0x20]
006874848  ldp      x22, x21, [sp, #0x10]
00687484C  ldr      x30, [sp], #0x30
006874850  ret      
006874854  ldr      x3, [x2, #0x60]
006874858  mov      x0, x20
00687485C  mov      w1, w19
006874860  ldp      x20, x19, [sp, #0x20]
006874864  ldp      x22, x21, [sp, #0x10]
006874868  ldr      x30, [sp], #0x30
00687486C  br       x3
006874870  bl       #0x382bfb8 ; 
006874874  bl       #0x382bfc0 ; 

