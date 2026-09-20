; HotFix.BattleLogic.DankeSkillCreator$$AddSkillToRandom
; RVA 0x6865E7C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006865E7C  stp      x30, x25, [sp, #-0x40]!
006865E80  stp      x24, x23, [sp, #0x10]
006865E84  stp      x22, x21, [sp, #0x20]
006865E88  stp      x20, x19, [sp, #0x30]
006865E8C  adrp     x24, #0x959b000
006865E90  adrp     x25, #0x8f23000
006865E94  ldrb     w8, [x24, #0xa07]
006865E98  ldr      x25, [x25, #0xdf8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.AddSkillToRandom() @ 0x9259cf8
006865E9C  mov      x19, x4
006865EA0  mov      w20, w3
006865EA4  mov      w21, w2
006865EA8  mov      x22, x1
006865EAC  mov      x23, x0
006865EB0  tbnz     w8, #0, #0x6865ed4
006865EB4  adrp     x0, #0x8ee8000
006865EB8  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006865EBC  bl       #0x382bd14 ; 
006865EC0  adrp     x0, #0x8f23000
006865EC4  ldr      x0, [x0, #0xdf8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.AddSkillToRandom() @ 0x9259cf8
006865EC8  bl       #0x382bd14 ; 
006865ECC  mov      w8, #1
006865ED0  strb     w8, [x24, #0xa07]
006865ED4  ldr      x5, [x25]
006865ED8  ldrb     w8, [x5, #0x53]
006865EDC  tbnz     w8, #5, #0x6865f2c
006865EE0  mov      x0, x23
006865EE4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006865EE8  cbz      x0, #0x6866064
006865EEC  adrp     x25, #0x9598000
006865EF0  ldrb     w8, [x25, #0xfcc]
006865EF4  mov      x24, x0
006865EF8  cbnz     w8, #0x6865f10
006865EFC  adrp     x0, #0x8f06000
006865F00  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006865F04  bl       #0x382bd14 ; 
006865F08  mov      w8, #1
006865F0C  strb     w8, [x25, #0xfcc]
006865F10  adrp     x8, #0x8f06000
006865F14  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006865F18  ldr      x1, [x8]
006865F1C  ldrb     w8, [x1, #0x53]
006865F20  tbnz     w8, #5, #0x6865f58
006865F24  ldr      x0, [x24, #0x200]
006865F28  b        #0x6865f64 ; 
006865F2C  ldr      x6, [x5, #0x60]
006865F30  mov      x0, x23
006865F34  mov      x1, x22
006865F38  mov      w2, w21
006865F3C  mov      w3, w20
006865F40  mov      x4, x19
006865F44  ldp      x20, x19, [sp, #0x30]
006865F48  ldp      x22, x21, [sp, #0x20]
006865F4C  ldp      x24, x23, [sp, #0x10]
006865F50  ldp      x30, x25, [sp], #0x40
006865F54  br       x6
006865F58  ldr      x8, [x1, #0x60]
006865F5C  mov      x0, x24
006865F60  blr      x8
006865F64  cbz      x0, #0x6866064
006865F68  mov      w1, w21
006865F6C  mov      x2, xzr
006865F70  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006865F74  cbz      x0, #0x686603c
006865F78  adrp     x25, #0x9599000
006865F7C  ldrb     w8, [x25, #0xac8]
006865F80  mov      x24, x0
006865F84  cbnz     w8, #0x6865f9c
006865F88  adrp     x0, #0x8f0d000
006865F8C  ldr      x0, [x0, #0x78] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillStar() @ 0x92ac540
006865F90  bl       #0x382bd14 ; 
006865F94  mov      w8, #1
006865F98  strb     w8, [x25, #0xac8]
006865F9C  adrp     x8, #0x8f0d000
006865FA0  ldr      x8, [x8, #0x78] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillStar() @ 0x92ac540
006865FA4  ldr      x1, [x8]
006865FA8  ldrb     w8, [x1, #0x53]
006865FAC  tbnz     w8, #5, #0x6865fb8
006865FB0  ldr      w0, [x24, #0x58]
006865FB4  b        #0x6865fc4 ; 
006865FB8  ldr      x8, [x1, #0x60]
006865FBC  mov      x0, x24
006865FC0  blr      x8
006865FC4  subs     w24, w0, #1
006865FC8  b.mi     #0x686603c
006865FCC  adrp     x25, #0x8ee8000
006865FD0  ldr      x25, [x25, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006865FD4  ldr      x0, [x25]
006865FD8  ldr      w8, [x0, #0xe0]
006865FDC  cbnz     w8, #0x6865fe8
006865FE0  bl       #0x382be8c ; 
006865FE4  ldr      x0, [x25]
006865FE8  ldr      x8, [x0, #0xb8]
006865FEC  ldr      x8, [x8, #0x538]
006865FF0  cbz      x8, #0x6866064
006865FF4  ldr      w9, [x8, #0x18]
006865FF8  cmp      w24, w9
006865FFC  b.ge     #0x686603c
006866000  ldr      w9, [x0, #0xe0]
006866004  cbnz     w9, #0x686601c
006866008  bl       #0x382be8c ; 
00686600C  ldr      x8, [x25]
006866010  ldr      x8, [x8, #0xb8]
006866014  ldr      x8, [x8, #0x538]
006866018  cbz      x8, #0x6866064
00686601C  ldr      w9, [x8, #0x18]
006866020  cmp      w24, w9
006866024  b.hs     #0x6866068
006866028  add      x8, x8, w24, uxtw #2
00686602C  ldr      w8, [x8, #0x20]
006866030  mul      w8, w8, w20
006866034  cmp      w8, #1
006866038  csinc    w20, w8, wzr, gt
00686603C  mov      x0, x23
006866040  mov      x1, x22
006866044  mov      w2, w21
006866048  mov      w3, w20
00686604C  mov      x4, x19
006866050  ldp      x20, x19, [sp, #0x30]
006866054  ldp      x22, x21, [sp, #0x20]
006866058  ldp      x24, x23, [sp, #0x10]
00686605C  ldp      x30, x25, [sp], #0x40
006866060  b        #0x686606c ; HotFix.BattleLogic.HeroSkillCreator$$AddSkillToRandom
006866064  bl       #0x382bfb8 ; 
006866068  bl       #0x382bfc0 ; 

