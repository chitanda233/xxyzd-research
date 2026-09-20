; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddSkillFlag
; RVA 0x6874878; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874878  str      x30, [sp, #-0x30]!
00687487C  stp      x22, x21, [sp, #0x10]
006874880  stp      x20, x19, [sp, #0x20]
006874884  adrp     x21, #0x959b000
006874888  adrp     x22, #0x8f24000
00687488C  ldrb     w8, [x21, #0xaaf]
006874890  ldr      x22, [x22, #0x4b8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnAddSkillFlag() @ 0x92aa990
006874894  mov      w19, w1
006874898  mov      x20, x0
00687489C  tbnz     w8, #0, #0x68748b4
0068748A0  adrp     x0, #0x8f24000
0068748A4  ldr      x0, [x0, #0x4b8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnAddSkillFlag() @ 0x92aa990
0068748A8  bl       #0x382bd14 ; 
0068748AC  mov      w8, #1
0068748B0  strb     w8, [x21, #0xaaf]
0068748B4  ldr      x2, [x22]
0068748B8  ldrb     w8, [x2, #0x53]
0068748BC  tbnz     w8, #5, #0x6874960
0068748C0  ldr      x21, [x20, #0x18]
0068748C4  cbz      x21, #0x6874980
0068748C8  ldr      w8, [x21, #0x18]
0068748CC  cmp      w8, #1
0068748D0  b.lt     #0x6874908
0068748D4  mov      w22, wzr
0068748D8  cmp      w22, w8
0068748DC  b.hs     #0x687497c
0068748E0  add      x8, x21, w22, sxtw #3
0068748E4  ldr      x0, [x8, #0x20]
0068748E8  cbz      x0, #0x6874980
0068748EC  mov      w1, w19
0068748F0  mov      x2, xzr
0068748F4  bl       #0x66334d8 ; HotFix.BattleLogic.WeightRandom$$OnAddFlag
0068748F8  ldr      w8, [x21, #0x18]
0068748FC  add      w22, w22, #1
006874900  cmp      w22, w8
006874904  b.lt     #0x68748d8
006874908  ldr      x20, [x20, #0x20]
00687490C  cbz      x20, #0x6874980
006874910  ldr      w8, [x20, #0x18]
006874914  cmp      w8, #1
006874918  b.lt     #0x6874950
00687491C  mov      w21, wzr
006874920  cmp      w21, w8
006874924  b.hs     #0x687497c
006874928  add      x8, x20, w21, sxtw #3
00687492C  ldr      x0, [x8, #0x20]
006874930  cbz      x0, #0x6874980
006874934  mov      w1, w19
006874938  mov      x2, xzr
00687493C  bl       #0x66334d8 ; HotFix.BattleLogic.WeightRandom$$OnAddFlag
006874940  ldr      w8, [x20, #0x18]
006874944  add      w21, w21, #1
006874948  cmp      w21, w8
00687494C  b.lt     #0x6874920
006874950  ldp      x20, x19, [sp, #0x20]
006874954  ldp      x22, x21, [sp, #0x10]
006874958  ldr      x30, [sp], #0x30
00687495C  ret      
006874960  ldr      x3, [x2, #0x60]
006874964  mov      x0, x20
006874968  mov      w1, w19
00687496C  ldp      x20, x19, [sp, #0x20]
006874970  ldp      x22, x21, [sp, #0x10]
006874974  ldr      x30, [sp], #0x30
006874978  br       x3
00687497C  bl       #0x382bfc0 ; 
006874980  bl       #0x382bfb8 ; 

