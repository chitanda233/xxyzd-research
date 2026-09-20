; HotFix.BattleLogic.DankeSkillCreator$$InitRandomFactor
; RVA 0x685D220; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685D220  str      x30, [sp, #-0x60]!
00685D224  stp      x28, x27, [sp, #0x10]
00685D228  stp      x26, x25, [sp, #0x20]
00685D22C  stp      x24, x23, [sp, #0x30]
00685D230  stp      x22, x21, [sp, #0x40]
00685D234  stp      x20, x19, [sp, #0x50]
00685D238  adrp     x20, #0x959b000
00685D23C  adrp     x21, #0x8f23000
00685D240  ldrb     w8, [x20, #0x9eb]
00685D244  ldr      x21, [x21, #0xb40] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.InitRandomFactor() @ 0x9259da8
00685D248  mov      x19, x0
00685D24C  tbnz     w8, #0, #0x685d264
00685D250  adrp     x0, #0x8f23000
00685D254  ldr      x0, [x0, #0xb40] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.InitRandomFactor() @ 0x9259da8
00685D258  bl       #0x382bd14 ; 
00685D25C  mov      w8, #1
00685D260  strb     w8, [x20, #0x9eb]
00685D264  ldr      x1, [x21]
00685D268  ldrb     w8, [x1, #0x53]
00685D26C  tbnz     w8, #5, #0x685d2bc
00685D270  mov      x0, x19
00685D274  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685D278  cbz      x0, #0x685d6d0
00685D27C  adrp     x21, #0x9598000
00685D280  ldrb     w8, [x21, #0xfcc]
00685D284  mov      x20, x0
00685D288  cbnz     w8, #0x685d2a0
00685D28C  adrp     x0, #0x8f06000
00685D290  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00685D294  bl       #0x382bd14 ; 
00685D298  mov      w8, #1
00685D29C  strb     w8, [x21, #0xfcc]
00685D2A0  adrp     x8, #0x8f06000
00685D2A4  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00685D2A8  ldr      x1, [x8]
00685D2AC  ldrb     w8, [x1, #0x53]
00685D2B0  tbnz     w8, #5, #0x685d2e0
00685D2B4  ldr      x20, [x20, #0x200]
00685D2B8  b        #0x685d2f0 ; 
00685D2BC  ldr      x2, [x1, #0x60]
00685D2C0  mov      x0, x19
00685D2C4  ldp      x20, x19, [sp, #0x50]
00685D2C8  ldp      x22, x21, [sp, #0x40]
00685D2CC  ldp      x24, x23, [sp, #0x30]
00685D2D0  ldp      x26, x25, [sp, #0x20]
00685D2D4  ldp      x28, x27, [sp, #0x10]
00685D2D8  ldr      x30, [sp], #0x60
00685D2DC  br       x2
00685D2E0  ldr      x8, [x1, #0x60]
00685D2E4  mov      x0, x20
00685D2E8  blr      x8
00685D2EC  mov      x20, x0
00685D2F0  mov      x0, x19
00685D2F4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685D2F8  cbz      x0, #0x685d6d0
00685D2FC  adrp     x22, #0x9599000
00685D300  ldrb     w8, [x22, #0x4d6]
00685D304  mov      x21, x0
00685D308  cbnz     w8, #0x685d320
00685D30C  adrp     x0, #0x8f09000
00685D310  ldr      x0, [x0, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
00685D314  bl       #0x382bd14 ; 
00685D318  mov      w8, #1
00685D31C  strb     w8, [x22, #0x4d6]
00685D320  adrp     x8, #0x8f09000
00685D324  ldr      x8, [x8, #0x788] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurChapterId() @ 0x923fe88
00685D328  ldr      x1, [x8]
00685D32C  ldrb     w8, [x1, #0x53]
00685D330  tbnz     w8, #5, #0x685d33c
00685D334  ldr      w1, [x21, #0x290]
00685D338  b        #0x685d34c ; 
00685D33C  ldr      x8, [x1, #0x60]
00685D340  mov      x0, x21
00685D344  blr      x8
00685D348  mov      w1, w0
00685D34C  cbz      x20, #0x685d6d0
00685D350  mov      x0, x20
00685D354  mov      x2, xzr
00685D358  bl       #0x64e3b1c ; LocalModels.LocalModelManager$$GetChapter_MainChapter
00685D35C  cbz      x0, #0x685d6d0
00685D360  adrp     x25, #0x959b000
00685D364  ldrb     w8, [x25, #0xb80]
00685D368  mov      x20, x0
00685D36C  cbnz     w8, #0x685d384
00685D370  adrp     x0, #0x8f23000
00685D374  ldr      x0, [x0, #0xb48] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_skill3SelectCreditsRandom() @ 0x924af18
00685D378  bl       #0x382bd14 ; 
00685D37C  mov      w8, #1
00685D380  strb     w8, [x25, #0xb80]
00685D384  adrp     x23, #0x8f23000
00685D388  ldr      x23, [x23, #0xb48] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_skill3SelectCreditsRandom() @ 0x924af18
00685D38C  ldr      x1, [x23]
00685D390  ldrb     w8, [x1, #0x53]
00685D394  tbnz     w8, #5, #0x685d3a8
00685D398  mov      x27, x19
00685D39C  ldr      x21, [x20, #0x158]
00685D3A0  ldr      x22, [x27, #0xa0]!
00685D3A4  b        #0x685d3dc ; 
00685D3A8  ldr      x8, [x1, #0x60]
00685D3AC  mov      x0, x20
00685D3B0  blr      x8
00685D3B4  mov      x27, x19
00685D3B8  ldrb     w8, [x25, #0xb80]
00685D3BC  ldr      x22, [x27, #0xa0]!
00685D3C0  mov      x21, x0
00685D3C4  cbnz     w8, #0x685d3dc
00685D3C8  adrp     x0, #0x8f23000
00685D3CC  ldr      x0, [x0, #0xb48] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_skill3SelectCreditsRandom() @ 0x924af18
00685D3D0  bl       #0x382bd14 ; 
00685D3D4  mov      w8, #1
00685D3D8  strb     w8, [x25, #0xb80]
00685D3DC  ldr      x1, [x23]
00685D3E0  ldrb     w8, [x1, #0x53]
00685D3E4  tbnz     w8, #5, #0x685d3f0
00685D3E8  ldr      x0, [x20, #0x158]
00685D3EC  b        #0x685d3fc ; 
00685D3F0  ldr      x8, [x1, #0x60]
00685D3F4  mov      x0, x20
00685D3F8  blr      x8
00685D3FC  cbz      x0, #0x685d6d0
00685D400  ldr      w4, [x0, #0x18]
00685D404  mov      w3, #1
00685D408  mov      x0, x21
00685D40C  mov      w1, wzr
00685D410  mov      x2, x22
00685D414  mov      x5, xzr
00685D418  mov      w24, #1
00685D41C  bl       #0x7c00484 ; System.Array$$Copy
00685D420  adrp     x26, #0x959b000
00685D424  ldrb     w8, [x26, #0xb81]
00685D428  cbnz     w8, #0x685d43c
00685D42C  adrp     x0, #0x8f23000
00685D430  ldr      x0, [x0, #0xb50] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_skill2SelectCreditsRandom() @ 0x924af10
00685D434  bl       #0x382bd14 ; 
00685D438  strb     w24, [x26, #0xb81]
00685D43C  adrp     x24, #0x8f23000
00685D440  ldr      x24, [x24, #0xb50] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_skill2SelectCreditsRandom() @ 0x924af10
00685D444  ldr      x1, [x24]
00685D448  ldrb     w8, [x1, #0x53]
00685D44C  tbnz     w8, #5, #0x685d460
00685D450  mov      x28, x19
00685D454  ldr      x21, [x20, #0x160]
00685D458  ldr      x22, [x28, #0xa8]!
00685D45C  b        #0x685d494 ; 
00685D460  ldr      x8, [x1, #0x60]
00685D464  mov      x0, x20
00685D468  blr      x8
00685D46C  mov      x28, x19
00685D470  ldrb     w8, [x26, #0xb81]
00685D474  ldr      x22, [x28, #0xa8]!
00685D478  mov      x21, x0
00685D47C  cbnz     w8, #0x685d494
00685D480  adrp     x0, #0x8f23000
00685D484  ldr      x0, [x0, #0xb50] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_skill2SelectCreditsRandom() @ 0x924af10
00685D488  bl       #0x382bd14 ; 
00685D48C  mov      w8, #1
00685D490  strb     w8, [x26, #0xb81]
00685D494  ldr      x1, [x24]
00685D498  ldrb     w8, [x1, #0x53]
00685D49C  tbnz     w8, #5, #0x685d4a8
00685D4A0  ldr      x0, [x20, #0x160]
00685D4A4  b        #0x685d4b4 ; 
00685D4A8  ldr      x8, [x1, #0x60]
00685D4AC  mov      x0, x20
00685D4B0  blr      x8
00685D4B4  cbz      x0, #0x685d6d0
00685D4B8  ldr      w4, [x0, #0x18]
00685D4BC  mov      w3, #1
00685D4C0  mov      x0, x21
00685D4C4  mov      w1, wzr
00685D4C8  mov      x2, x22
00685D4CC  mov      x5, xzr
00685D4D0  bl       #0x7c00484 ; System.Array$$Copy
00685D4D4  ldr      x8, [x27]
00685D4D8  cbz      x8, #0x685d6d0
00685D4DC  ldr      w10, [x8, #0x18]
00685D4E0  cbz      w10, #0x685d6d4
00685D4E4  str      wzr, [x8, #0x20]
00685D4E8  ldr      x9, [x28]
00685D4EC  cbz      x9, #0x685d6d0
00685D4F0  ldr      w11, [x9, #0x18]
00685D4F4  cbz      w11, #0x685d6d4
00685D4F8  cmp      w10, #5
00685D4FC  str      wzr, [x9, #0x20]
00685D500  b.ls     #0x685d6d4
00685D504  ldr      w10, [x8, #0x34]
00685D508  ldr      w12, [x8, #0x2c]
00685D50C  cmp      w11, #5
00685D510  add      w10, w12, w10
00685D514  str      w10, [x8, #0x34]
00685D518  b.ls     #0x685d6d4
00685D51C  ldr      w8, [x9, #0x34]
00685D520  ldr      w10, [x9, #0x2c]
00685D524  add      w8, w10, w8
00685D528  str      w8, [x9, #0x34]
00685D52C  ldrb     w8, [x25, #0xb80]
00685D530  cbnz     w8, #0x685d548
00685D534  adrp     x0, #0x8f23000
00685D538  ldr      x0, [x0, #0xb48] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_skill3SelectCreditsRandom() @ 0x924af18
00685D53C  bl       #0x382bd14 ; 
00685D540  mov      w8, #1
00685D544  strb     w8, [x25, #0xb80]
00685D548  ldr      x1, [x23]
00685D54C  ldrb     w8, [x1, #0x53]
00685D550  tbnz     w8, #5, #0x685d564
00685D554  mov      x27, x19
00685D558  ldr      x21, [x20, #0x158]
00685D55C  ldr      x22, [x27, #0xb0]!
00685D560  b        #0x685d598 ; 
00685D564  ldr      x8, [x1, #0x60]
00685D568  mov      x0, x20
00685D56C  blr      x8
00685D570  mov      x27, x19
00685D574  ldrb     w8, [x25, #0xb80]
00685D578  ldr      x22, [x27, #0xb0]!
00685D57C  mov      x21, x0
00685D580  cbnz     w8, #0x685d598
00685D584  adrp     x0, #0x8f23000
00685D588  ldr      x0, [x0, #0xb48] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_skill3SelectCreditsRandom() @ 0x924af18
00685D58C  bl       #0x382bd14 ; 
00685D590  mov      w8, #1
00685D594  strb     w8, [x25, #0xb80]
00685D598  ldr      x1, [x23]
00685D59C  ldrb     w8, [x1, #0x53]
00685D5A0  tbnz     w8, #5, #0x685d5ac
00685D5A4  ldr      x0, [x20, #0x158]
00685D5A8  b        #0x685d5b8 ; 
00685D5AC  ldr      x8, [x1, #0x60]
00685D5B0  mov      x0, x20
00685D5B4  blr      x8
00685D5B8  cbz      x0, #0x685d6d0
00685D5BC  ldr      w4, [x0, #0x18]
00685D5C0  mov      w3, #1
00685D5C4  mov      x0, x21
00685D5C8  mov      w1, wzr
00685D5CC  mov      x2, x22
00685D5D0  mov      x5, xzr
00685D5D4  mov      w23, #1
00685D5D8  bl       #0x7c00484 ; System.Array$$Copy
00685D5DC  ldrb     w8, [x26, #0xb81]
00685D5E0  cbnz     w8, #0x685d5f4
00685D5E4  adrp     x0, #0x8f23000
00685D5E8  ldr      x0, [x0, #0xb50] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_skill2SelectCreditsRandom() @ 0x924af10
00685D5EC  bl       #0x382bd14 ; 
00685D5F0  strb     w23, [x26, #0xb81]
00685D5F4  ldr      x1, [x24]
00685D5F8  ldrb     w8, [x1, #0x53]
00685D5FC  tbnz     w8, #5, #0x685d60c
00685D600  ldr      x21, [x20, #0x160]
00685D604  ldr      x22, [x19, #0xb8]!
00685D608  b        #0x685d63c ; 
00685D60C  ldr      x8, [x1, #0x60]
00685D610  mov      x0, x20
00685D614  blr      x8
00685D618  ldrb     w8, [x26, #0xb81]
00685D61C  ldr      x22, [x19, #0xb8]!
00685D620  mov      x21, x0
00685D624  cbnz     w8, #0x685d63c
00685D628  adrp     x0, #0x8f23000
00685D62C  ldr      x0, [x0, #0xb50] ; GLOBAL Method$LocalModels.Bean.Chapter_MainChapter.get_skill2SelectCreditsRandom() @ 0x924af10
00685D630  bl       #0x382bd14 ; 
00685D634  mov      w8, #1
00685D638  strb     w8, [x26, #0xb81]
00685D63C  ldr      x1, [x24]
00685D640  ldrb     w8, [x1, #0x53]
00685D644  tbnz     w8, #5, #0x685d650
00685D648  ldr      x0, [x20, #0x160]
00685D64C  b        #0x685d65c ; 
00685D650  ldr      x8, [x1, #0x60]
00685D654  mov      x0, x20
00685D658  blr      x8
00685D65C  cbz      x0, #0x685d6d0
00685D660  ldr      w4, [x0, #0x18]
00685D664  mov      w3, #1
00685D668  mov      x0, x21
00685D66C  mov      w1, wzr
00685D670  mov      x2, x22
00685D674  mov      x5, xzr
00685D678  bl       #0x7c00484 ; System.Array$$Copy
00685D67C  ldr      x8, [x27]
00685D680  cbz      x8, #0x685d6d0
00685D684  ldr      w9, [x8, #0x18]
00685D688  cmp      w9, #1
00685D68C  b.ls     #0x685d6d4
00685D690  ldr      w9, [x8, #0x24]
00685D694  str      w9, [x8, #0x20]
00685D698  ldr      x8, [x19]
00685D69C  cbz      x8, #0x685d6d0
00685D6A0  ldr      w9, [x8, #0x18]
00685D6A4  cmp      w9, #1
00685D6A8  b.ls     #0x685d6d4
00685D6AC  ldr      w9, [x8, #0x24]
00685D6B0  ldp      x20, x19, [sp, #0x50]
00685D6B4  ldp      x22, x21, [sp, #0x40]
00685D6B8  ldp      x24, x23, [sp, #0x30]
00685D6BC  ldp      x26, x25, [sp, #0x20]
00685D6C0  ldp      x28, x27, [sp, #0x10]
00685D6C4  str      w9, [x8, #0x20]
00685D6C8  ldr      x30, [sp], #0x60
00685D6CC  ret      
00685D6D0  bl       #0x382bfb8 ; 
00685D6D4  bl       #0x382bfc0 ; 

