; HotFix.BattleLogic.HeroSkillCreator$$AddDankeSkillGroupToRandom
; RVA 0x687260C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00687260C  str      x30, [sp, #-0x40]!
006872610  stp      x24, x23, [sp, #0x10]
006872614  stp      x22, x21, [sp, #0x20]
006872618  stp      x20, x19, [sp, #0x30]
00687261C  adrp     x23, #0x959b000
006872620  adrp     x24, #0x8f24000
006872624  ldrb     w8, [x23, #0xa86]
006872628  ldr      x24, [x24, #0x3f8] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.AddDankeSkillGroupToRandom() @ 0x927fdc8
00687262C  mov      x22, x3
006872630  mov      x20, x2
006872634  mov      x21, x1
006872638  mov      x19, x0
00687263C  tbnz     w8, #0, #0x6872660
006872640  adrp     x0, #0x8f24000
006872644  ldr      x0, [x0, #0x3f8] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.AddDankeSkillGroupToRandom() @ 0x927fdc8
006872648  bl       #0x382bd14 ; 
00687264C  adrp     x0, #0x8f23000
006872650  ldr      x0, [x0, #0xa08] ; GLOBAL LocalModels.Bean.ISkillGroup_TypeInfo @ 0x91ea558
006872654  bl       #0x382bd14 ; 
006872658  mov      w8, #1
00687265C  strb     w8, [x23, #0xa86]
006872660  ldr      x4, [x24]
006872664  ldrb     w8, [x4, #0x53]
006872668  tbnz     w8, #5, #0x68726c8
00687266C  mov      x0, x19
006872670  mov      x1, x20
006872674  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
006872678  cbz      w0, #0x6872720
00687267C  cbz      x20, #0x6872800
006872680  adrp     x10, #0x8f23000
006872684  ldr      x8, [x20]
006872688  ldr      x10, [x10, #0xa08] ; GLOBAL LocalModels.Bean.ISkillGroup_TypeInfo @ 0x91ea558
00687268C  ldrh     w9, [x8, #0x12e]
006872690  ldr      x1, [x10]
006872694  cbz      x9, #0x68726b8
006872698  ldr      x10, [x8, #0xb0]
00687269C  add      x10, x10, #8
0068726A0  ldur     x11, [x10, #-8]
0068726A4  cmp      x11, x1
0068726A8  b.eq     #0x68726f0
0068726AC  subs     x9, x9, #1
0068726B0  add      x10, x10, #0x10
0068726B4  b.ne     #0x68726a0
0068726B8  mov      x0, x20
0068726BC  mov      w2, wzr
0068726C0  bl       #0x3a7e710 ; 
0068726C4  b        #0x68726fc ; 
0068726C8  ldr      x5, [x4, #0x60]
0068726CC  mov      x0, x19
0068726D0  mov      x1, x21
0068726D4  mov      x2, x20
0068726D8  mov      x3, x22
0068726DC  ldp      x20, x19, [sp, #0x30]
0068726E0  ldp      x22, x21, [sp, #0x20]
0068726E4  ldp      x24, x23, [sp, #0x10]
0068726E8  ldr      x30, [sp], #0x40
0068726EC  br       x5
0068726F0  ldrsw    x9, [x10]
0068726F4  add      x8, x8, x9, lsl #4
0068726F8  add      x0, x8, #0x138
0068726FC  ldp      x8, x1, [x0]
006872700  mov      x0, x20
006872704  blr      x8
006872708  mov      w23, w0
00687270C  cbz      x22, #0x6872734
006872710  mov      x0, x22
006872714  mov      w1, w23
006872718  bl       #0x685b6b8 ; HotFix.BattleLogic.HeroSkillCreator$$IsContain
00687271C  tbz      w0, #0, #0x6872734
006872720  ldp      x20, x19, [sp, #0x30]
006872724  ldp      x22, x21, [sp, #0x20]
006872728  ldp      x24, x23, [sp, #0x10]
00687272C  ldr      x30, [sp], #0x40
006872730  ret      
006872734  mov      x0, x19
006872738  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00687273C  cbz      x0, #0x6872800
006872740  adrp     x24, #0x9598000
006872744  ldrb     w8, [x24, #0xfcc]
006872748  mov      x22, x0
00687274C  cbnz     w8, #0x6872764
006872750  adrp     x0, #0x8f06000
006872754  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006872758  bl       #0x382bd14 ; 
00687275C  mov      w8, #1
006872760  strb     w8, [x24, #0xfcc]
006872764  adrp     x8, #0x8f06000
006872768  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00687276C  ldr      x1, [x8]
006872770  ldrb     w8, [x1, #0x53]
006872774  tbnz     w8, #5, #0x6872780
006872778  ldr      x0, [x22, #0x200]
00687277C  b        #0x687278c ; 
006872780  ldr      x8, [x1, #0x60]
006872784  mov      x0, x22
006872788  blr      x8
00687278C  cbz      x0, #0x6872800
006872790  mov      w1, w23
006872794  mov      x2, xzr
006872798  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
00687279C  mov      w1, wzr
0068727A0  mov      x2, xzr
0068727A4  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
0068727A8  cbz      x21, #0x6872800
0068727AC  ldr      w8, [x21, #0x18]
0068727B0  cmp      w0, w8
0068727B4  b.hs     #0x6872804
0068727B8  add      x8, x21, w0, sxtw #3
0068727BC  ldr      x21, [x8, #0x20]
0068727C0  mov      x0, x19
0068727C4  mov      x1, x20
0068727C8  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
0068727CC  ldr      x8, [x19]
0068727D0  mov      w3, w0
0068727D4  mov      x0, x19
0068727D8  mov      x1, x21
0068727DC  ldr      x6, [x8, #0x228]
0068727E0  ldr      x5, [x8, #0x230]
0068727E4  mov      w2, w23
0068727E8  ldp      x20, x19, [sp, #0x30]
0068727EC  ldp      x22, x21, [sp, #0x20]
0068727F0  ldp      x24, x23, [sp, #0x10]
0068727F4  mov      x4, xzr
0068727F8  ldr      x30, [sp], #0x40
0068727FC  br       x6
006872800  bl       #0x382bfb8 ; 
006872804  bl       #0x382bfc0 ; 

