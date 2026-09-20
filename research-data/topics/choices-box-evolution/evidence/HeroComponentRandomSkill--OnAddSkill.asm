; HotFix.BattleLogic.HeroComponentRandomSkill$$OnAddSkill
; RVA 0x6868274; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006868274  stp      x30, x27, [sp, #-0x50]!
006868278  stp      x26, x25, [sp, #0x10]
00686827C  stp      x24, x23, [sp, #0x20]
006868280  stp      x22, x21, [sp, #0x30]
006868284  stp      x20, x19, [sp, #0x40]
006868288  adrp     x21, #0x959b000
00686828C  adrp     x22, #0x8f23000
006868290  ldrb     w8, [x21, #0xa37]
006868294  ldr      x22, [x22, #0xf50] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.OnAddSkill() @ 0x927fa40
006868298  mov      w20, w1
00686829C  mov      x19, x0
0068682A0  tbnz     w8, #0, #0x68682d0
0068682A4  adrp     x0, #0x8f23000
0068682A8  ldr      x0, [x0, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
0068682AC  bl       #0x382bd14 ; 
0068682B0  adrp     x0, #0x8f23000
0068682B4  ldr      x0, [x0, #0xf50] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.OnAddSkill() @ 0x927fa40
0068682B8  bl       #0x382bd14 ; 
0068682BC  adrp     x0, #0x8f23000
0068682C0  ldr      x0, [x0, #0xf58] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreatePooledElement<MaxStarSkillChangeTriggerEvent>() @ 0x92cd920
0068682C4  bl       #0x382bd14 ; 
0068682C8  mov      w8, #1
0068682CC  strb     w8, [x21, #0xa37]
0068682D0  ldr      x2, [x22]
0068682D4  ldrb     w8, [x2, #0x53]
0068682D8  tbnz     w8, #5, #0x6868318
0068682DC  adrp     x23, #0x9591000
0068682E0  ldrb     w8, [x23, #0xa4b]
0068682E4  cbnz     w8, #0x68682fc
0068682E8  adrp     x0, #0x8ee5000
0068682EC  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068682F0  bl       #0x382bd14 ; 
0068682F4  mov      w8, #1
0068682F8  strb     w8, [x23, #0xa4b]
0068682FC  adrp     x24, #0x8ee5000
006868300  ldr      x24, [x24, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006868304  ldr      x1, [x24]
006868308  ldrb     w8, [x1, #0x53]
00686830C  tbnz     w8, #5, #0x686833c
006868310  ldr      x21, [x19, #0x20]
006868314  b        #0x686834c ; 
006868318  ldr      x3, [x2, #0x60]
00686831C  mov      x0, x19
006868320  mov      w1, w20
006868324  ldp      x20, x19, [sp, #0x40]
006868328  ldp      x22, x21, [sp, #0x30]
00686832C  ldp      x24, x23, [sp, #0x20]
006868330  ldp      x26, x25, [sp, #0x10]
006868334  ldp      x30, x27, [sp], #0x50
006868338  br       x3
00686833C  ldr      x8, [x1, #0x60]
006868340  mov      x0, x19
006868344  blr      x8
006868348  mov      x21, x0
00686834C  cbz      x21, #0x6868728
006868350  adrp     x22, #0x9598000
006868354  ldrb     w8, [x22, #0xfcc]
006868358  cbnz     w8, #0x6868370
00686835C  adrp     x0, #0x8f06000
006868360  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006868364  bl       #0x382bd14 ; 
006868368  mov      w8, #1
00686836C  strb     w8, [x22, #0xfcc]
006868370  adrp     x8, #0x8f06000
006868374  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006868378  ldr      x1, [x8]
00686837C  ldrb     w8, [x1, #0x53]
006868380  tbnz     w8, #5, #0x686838c
006868384  ldr      x0, [x21, #0x200]
006868388  b        #0x6868398 ; 
00686838C  ldr      x8, [x1, #0x60]
006868390  mov      x0, x21
006868394  blr      x8
006868398  cbz      x0, #0x6868728
00686839C  mov      w1, w20
0068683A0  mov      x2, xzr
0068683A4  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0068683A8  cbz      x0, #0x6868728
0068683AC  adrp     x21, #0x9599000
0068683B0  ldrb     w8, [x21, #0x4dc]
0068683B4  mov      x20, x0
0068683B8  cbnz     w8, #0x68683d0
0068683BC  adrp     x0, #0x8f09000
0068683C0  ldr      x0, [x0, #0x8c0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_IsBattleSkill() @ 0x92ac440
0068683C4  bl       #0x382bd14 ; 
0068683C8  mov      w8, #1
0068683CC  strb     w8, [x21, #0x4dc]
0068683D0  adrp     x8, #0x8f09000
0068683D4  ldr      x8, [x8, #0x8c0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_IsBattleSkill() @ 0x92ac440
0068683D8  ldr      x1, [x8]
0068683DC  ldrb     w8, [x1, #0x53]
0068683E0  tbnz     w8, #5, #0x68683ec
0068683E4  ldr      w0, [x20, #0x24]
0068683E8  b        #0x68683f8 ; 
0068683EC  ldr      x8, [x1, #0x60]
0068683F0  mov      x0, x20
0068683F4  blr      x8
0068683F8  cmp      w0, #1
0068683FC  b.ne     #0x686860c
006868400  adrp     x22, #0x959b000
006868404  ldrb     w8, [x22, #0xba6]
006868408  cbnz     w8, #0x6868420
00686840C  adrp     x0, #0x8f23000
006868410  ldr      x0, [x0, #0xf30] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_MaxStarSkill() @ 0x927fb00
006868414  bl       #0x382bd14 ; 
006868418  mov      w8, #1
00686841C  strb     w8, [x22, #0xba6]
006868420  adrp     x26, #0x8f23000
006868424  ldr      x26, [x26, #0xf30] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_MaxStarSkill() @ 0x927fb00
006868428  ldr      x1, [x26]
00686842C  ldrb     w8, [x1, #0x53]
006868430  tbnz     w8, #5, #0x6868440
006868434  ldr      x0, [x19, #0x98]
006868438  cbnz     x0, #0x6868450
00686843C  b        #0x6868524 ; 
006868440  ldr      x8, [x1, #0x60]
006868444  mov      x0, x19
006868448  blr      x8
00686844C  cbz      x0, #0x6868524
006868450  adrp     x25, #0x9599000
006868454  ldrb     w8, [x25, #0xac8]
006868458  cbnz     w8, #0x6868470
00686845C  adrp     x0, #0x8f0d000
006868460  ldr      x0, [x0, #0x78] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillStar() @ 0x92ac540
006868464  bl       #0x382bd14 ; 
006868468  mov      w8, #1
00686846C  strb     w8, [x25, #0xac8]
006868470  adrp     x27, #0x8f0d000
006868474  ldr      x27, [x27, #0x78] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillStar() @ 0x92ac540
006868478  ldr      x1, [x27]
00686847C  ldrb     w8, [x1, #0x53]
006868480  tbnz     w8, #5, #0x686848c
006868484  ldr      w21, [x20, #0x58]
006868488  b        #0x686849c ; 
00686848C  ldr      x8, [x1, #0x60]
006868490  mov      x0, x20
006868494  blr      x8
006868498  mov      w21, w0
00686849C  ldrb     w8, [x22, #0xba6]
0068684A0  cbnz     w8, #0x68684b8
0068684A4  adrp     x0, #0x8f23000
0068684A8  ldr      x0, [x0, #0xf30] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_MaxStarSkill() @ 0x927fb00
0068684AC  bl       #0x382bd14 ; 
0068684B0  mov      w8, #1
0068684B4  strb     w8, [x22, #0xba6]
0068684B8  ldr      x1, [x26]
0068684BC  ldrb     w8, [x1, #0x53]
0068684C0  tbnz     w8, #5, #0x68684cc
0068684C4  ldr      x22, [x19, #0x98]
0068684C8  b        #0x68684dc ; 
0068684CC  ldr      x8, [x1, #0x60]
0068684D0  mov      x0, x19
0068684D4  blr      x8
0068684D8  mov      x22, x0
0068684DC  cbz      x22, #0x6868728
0068684E0  ldrb     w8, [x25, #0xac8]
0068684E4  cbnz     w8, #0x68684fc
0068684E8  adrp     x0, #0x8f0d000
0068684EC  ldr      x0, [x0, #0x78] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillStar() @ 0x92ac540
0068684F0  bl       #0x382bd14 ; 
0068684F4  mov      w8, #1
0068684F8  strb     w8, [x25, #0xac8]
0068684FC  ldr      x1, [x27]
006868500  ldrb     w8, [x1, #0x53]
006868504  tbnz     w8, #5, #0x6868510
006868508  ldr      w0, [x22, #0x58]
00686850C  b        #0x686851c ; 
006868510  ldr      x8, [x1, #0x60]
006868514  mov      x0, x22
006868518  blr      x8
00686851C  cmp      w21, w0
006868520  b.le     #0x686860c
006868524  adrp     x21, #0x959b000
006868528  ldrb     w8, [x21, #0xba7]
00686852C  cbnz     w8, #0x6868544
006868530  adrp     x0, #0x8f23000
006868534  ldr      x0, [x0, #0xf38] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.set_MaxStarSkill() @ 0x927fb20
006868538  bl       #0x382bd14 ; 
00686853C  mov      w8, #1
006868540  strb     w8, [x21, #0xba7]
006868544  adrp     x8, #0x8f23000
006868548  ldr      x8, [x8, #0xf38] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.set_MaxStarSkill() @ 0x927fb20
00686854C  ldr      x2, [x8]
006868550  ldrb     w8, [x2, #0x53]
006868554  tbnz     w8, #5, #0x686856c
006868558  mov      x0, x19
00686855C  str      x20, [x0, #0x98]!
006868560  mov      x1, x20
006868564  bl       #0x382bcb8 ; 
006868568  b        #0x686857c ; 
00686856C  ldr      x8, [x2, #0x60]
006868570  mov      x0, x19
006868574  mov      x1, x20
006868578  blr      x8
00686857C  adrp     x21, #0x8f23000
006868580  ldr      x21, [x21, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
006868584  ldr      x1, [x21]
006868588  ldrb     w8, [x1, #0x53]
00686858C  tbnz     w8, #5, #0x6868598
006868590  ldr      x20, [x19, #0x30]
006868594  b        #0x68685a8 ; 
006868598  ldr      x8, [x1, #0x60]
00686859C  mov      x0, x19
0068685A0  blr      x8
0068685A4  mov      x20, x0
0068685A8  cbz      x20, #0x6868728
0068685AC  adrp     x22, #0x9591000
0068685B0  ldrb     w8, [x22, #0xa86]
0068685B4  cbnz     w8, #0x68685d8
0068685B8  adrp     x0, #0x8ee6000
0068685BC  ldr      x0, [x0, #0x318] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.CheckTriggerFlag() @ 0x92623e8
0068685C0  bl       #0x382bd14 ; 
0068685C4  adrp     x0, #0x8ee3000
0068685C8  ldr      x0, [x0, #0xf18] ; GLOBAL Method$System.Collections.Generic.HashSet<int>.Contains() @ 0x9216b48
0068685CC  bl       #0x382bd14 ; 
0068685D0  mov      w8, #1
0068685D4  strb     w8, [x22, #0xa86]
0068685D8  adrp     x8, #0x8ee6000
0068685DC  ldr      x8, [x8, #0x318] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.CheckTriggerFlag() @ 0x92623e8
0068685E0  ldr      x2, [x8]
0068685E4  ldrb     w8, [x2, #0x53]
0068685E8  tbnz     w8, #5, #0x6868624
0068685EC  ldr      x0, [x20, #0x190]
0068685F0  cbz      x0, #0x686860c
0068685F4  adrp     x8, #0x8ee3000
0068685F8  ldr      x8, [x8, #0xf18] ; GLOBAL Method$System.Collections.Generic.HashSet<int>.Contains() @ 0x9216b48
0068685FC  mov      w1, #0x3f
006868600  ldr      x2, [x8]
006868604  bl       #0x4937430 ; System.Collections.Generic.HashSet<int>$$Contains
006868608  tbnz     w0, #0, #0x6868638
00686860C  ldp      x20, x19, [sp, #0x40]
006868610  ldp      x22, x21, [sp, #0x30]
006868614  ldp      x24, x23, [sp, #0x20]
006868618  ldp      x26, x25, [sp, #0x10]
00686861C  ldp      x30, x27, [sp], #0x50
006868620  ret      
006868624  ldr      x8, [x2, #0x60]
006868628  mov      w1, #0x3f
00686862C  mov      x0, x20
006868630  blr      x8
006868634  tbz      w0, #0, #0x686860c
006868638  ldrb     w8, [x23, #0xa4b]
00686863C  cbnz     w8, #0x6868654
006868640  adrp     x0, #0x8ee5000
006868644  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006868648  bl       #0x382bd14 ; 
00686864C  mov      w8, #1
006868650  strb     w8, [x23, #0xa4b]
006868654  ldr      x1, [x24]
006868658  ldrb     w8, [x1, #0x53]
00686865C  tbnz     w8, #5, #0x6868668
006868660  ldr      x20, [x19, #0x20]
006868664  b        #0x6868678 ; 
006868668  ldr      x8, [x1, #0x60]
00686866C  mov      x0, x19
006868670  blr      x8
006868674  mov      x20, x0
006868678  cbz      x20, #0x6868728
00686867C  adrp     x22, #0x9591000
006868680  ldrb     w8, [x22, #0xa4c]
006868684  cbnz     w8, #0x686869c
006868688  adrp     x0, #0x8ee5000
00686868C  ldr      x0, [x0, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator() @ 0x923fe80
006868690  bl       #0x382bd14 ; 
006868694  mov      w8, #1
006868698  strb     w8, [x22, #0xa4c]
00686869C  adrp     x8, #0x8ee5000
0068686A0  ldr      x8, [x8, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator() @ 0x923fe80
0068686A4  ldr      x1, [x8]
0068686A8  ldrb     w8, [x1, #0x53]
0068686AC  tbnz     w8, #5, #0x68686b8
0068686B0  ldr      x0, [x20, #0x210]
0068686B4  b        #0x68686c4 ; 
0068686B8  ldr      x8, [x1, #0x60]
0068686BC  mov      x0, x20
0068686C0  blr      x8
0068686C4  cbz      x0, #0x6868728
0068686C8  adrp     x8, #0x8f23000
0068686CC  ldr      x8, [x8, #0xf58] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreatePooledElement<MaxStarSkillChangeTriggerEvent>() @ 0x92cd920
0068686D0  ldr      x1, [x8]
0068686D4  bl       #0x4782e04 ; HotFix.BattleLogic.WorldElementCreator$$CreatePooledElement<object>
0068686D8  ldr      x1, [x21]
0068686DC  mov      x20, x0
0068686E0  ldrb     w8, [x1, #0x53]
0068686E4  tbnz     w8, #5, #0x68686f0
0068686E8  ldr      x0, [x19, #0x30]
0068686EC  b        #0x68686fc ; 
0068686F0  ldr      x8, [x1, #0x60]
0068686F4  mov      x0, x19
0068686F8  blr      x8
0068686FC  cbz      x0, #0x6868728
006868700  ldr      x0, [x0, #0x150]
006868704  cbz      x0, #0x6868728
006868708  mov      x1, x20
00686870C  ldp      x20, x19, [sp, #0x40]
006868710  ldp      x22, x21, [sp, #0x30]
006868714  ldp      x24, x23, [sp, #0x20]
006868718  ldp      x26, x25, [sp, #0x10]
00686871C  mov      x2, xzr
006868720  ldp      x30, x27, [sp], #0x50
006868724  b        #0x672d4e0 ; HotFix.BattleLogic.CharacterComponentTrigger$$OnTriggerEvent
006868728  bl       #0x382bfb8 ; 

