; HotFix.BattleLogic.DankeSkillCreator$$GetAlreadyStudyRandomPool
; RVA 0x6863850; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006863850  stp      x30, x23, [sp, #-0x30]!
006863854  stp      x22, x21, [sp, #0x10]
006863858  stp      x20, x19, [sp, #0x20]
00686385C  adrp     x22, #0x959b000
006863860  adrp     x23, #0x8f23000
006863864  ldrb     w8, [x22, #0xa00]
006863868  ldr      x23, [x23, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetAlreadyStudyRandomPool() @ 0x9259d30
00686386C  mov      x19, x2
006863870  mov      x20, x1
006863874  mov      x21, x0
006863878  tbnz     w8, #0, #0x6863890
00686387C  adrp     x0, #0x8f23000
006863880  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetAlreadyStudyRandomPool() @ 0x9259d30
006863884  bl       #0x382bd14 ; 
006863888  mov      w8, #1
00686388C  strb     w8, [x22, #0xa00]
006863890  ldr      x3, [x23]
006863894  ldrb     w8, [x3, #0x53]
006863898  tbnz     w8, #5, #0x6863904
00686389C  cbz      x19, #0x6863940
0068638A0  ldr      w9, [x19, #0x18]
0068638A4  cmp      w9, #1
0068638A8  b.lt     #0x6863924
0068638AC  mov      w8, wzr
0068638B0  mov      w21, wzr
0068638B4  cmp      w8, w9
0068638B8  b.hs     #0x686393c
0068638BC  cbz      x20, #0x6863940
0068638C0  ldr      w9, [x20, #0x18]
0068638C4  sxtw     x22, w8
0068638C8  cmp      w22, w9
0068638CC  b.hs     #0x686393c
0068638D0  add      x8, x19, x22, lsl #3
0068638D4  ldr      x0, [x8, #0x20]
0068638D8  cbz      x0, #0x6863940
0068638DC  add      x8, x20, x22, lsl #3
0068638E0  ldr      x1, [x8, #0x20]
0068638E4  mov      x2, xzr
0068638E8  bl       #0x6634f18 ; HotFix.BattleLogic.WeightRandom$$GetAlreadyStudySkill
0068638EC  ldr      w9, [x19, #0x18]
0068638F0  add      w8, w22, #1
0068638F4  add      w21, w0, w21
0068638F8  cmp      w8, w9
0068638FC  b.lt     #0x68638b4
006863900  b        #0x6863928 ; 
006863904  ldr      x4, [x3, #0x60]
006863908  mov      x0, x21
00686390C  mov      x1, x20
006863910  mov      x2, x19
006863914  ldp      x20, x19, [sp, #0x20]
006863918  ldp      x22, x21, [sp, #0x10]
00686391C  ldp      x30, x23, [sp], #0x30
006863920  br       x4
006863924  mov      w21, wzr
006863928  mov      w0, w21
00686392C  ldp      x20, x19, [sp, #0x20]
006863930  ldp      x22, x21, [sp, #0x10]
006863934  ldp      x30, x23, [sp], #0x30
006863938  ret      
00686393C  bl       #0x382bfc0 ; 
006863940  bl       #0x382bfb8 ; 

