; HotFix.BattleLogic.DankeSkillCreator$$InitDankeAlreadyStudySkills
; RVA 0x685ECF8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685ECF8  str      x30, [sp, #-0x30]!
00685ECFC  stp      x22, x21, [sp, #0x10]
00685ED00  stp      x20, x19, [sp, #0x20]
00685ED04  adrp     x20, #0x959b000
00685ED08  adrp     x21, #0x8f23000
00685ED0C  ldrb     w8, [x20, #0x9fa]
00685ED10  ldr      x21, [x21, #0xbe8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.InitDankeAlreadyStudySkills() @ 0x9259d98
00685ED14  mov      x19, x0
00685ED18  tbnz     w8, #0, #0x685ed30
00685ED1C  adrp     x0, #0x8f23000
00685ED20  ldr      x0, [x0, #0xbe8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.InitDankeAlreadyStudySkills() @ 0x9259d98
00685ED24  bl       #0x382bd14 ; 
00685ED28  mov      w8, #1
00685ED2C  strb     w8, [x20, #0x9fa]
00685ED30  ldr      x1, [x21]
00685ED34  ldrb     w8, [x1, #0x53]
00685ED38  tbnz     w8, #5, #0x685ed70
00685ED3C  ldr      x20, [x19, #0x48]
00685ED40  mov      x0, x19
00685ED44  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685ED48  cbz      x0, #0x685ee50
00685ED4C  ldrb     w8, [x0, #0x25]
00685ED50  cbz      w8, #0x685ed88
00685ED54  ldr      x1, [x19, #0x30]
00685ED58  mov      x0, x19
00685ED5C  mov      x2, x20
00685ED60  ldp      x20, x19, [sp, #0x20]
00685ED64  ldp      x22, x21, [sp, #0x10]
00685ED68  ldr      x30, [sp], #0x30
00685ED6C  b        #0x6863850 ; HotFix.BattleLogic.DankeSkillCreator$$GetAlreadyStudyRandomPool
00685ED70  ldr      x2, [x1, #0x60]
00685ED74  mov      x0, x19
00685ED78  ldp      x20, x19, [sp, #0x20]
00685ED7C  ldp      x22, x21, [sp, #0x10]
00685ED80  ldr      x30, [sp], #0x30
00685ED84  br       x2
00685ED88  mov      x0, x19
00685ED8C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685ED90  cbz      x0, #0x685ee50
00685ED94  adrp     x22, #0x959b000
00685ED98  ldrb     w8, [x22, #0xb84]
00685ED9C  mov      x21, x0
00685EDA0  cbnz     w8, #0x685edb8
00685EDA4  adrp     x0, #0x8f23000
00685EDA8  ldr      x0, [x0, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
00685EDAC  bl       #0x382bd14 ; 
00685EDB0  mov      w8, #1
00685EDB4  strb     w8, [x22, #0xb84]
00685EDB8  adrp     x8, #0x8f23000
00685EDBC  ldr      x8, [x8, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
00685EDC0  ldr      x1, [x8]
00685EDC4  ldrb     w8, [x1, #0x53]
00685EDC8  tbnz     w8, #5, #0x685edd4
00685EDCC  ldr      w0, [x21, #0x2c4]
00685EDD0  b        #0x685ede0 ; 
00685EDD4  ldr      x8, [x1, #0x60]
00685EDD8  mov      x0, x21
00685EDDC  blr      x8
00685EDE0  cmp      w0, #1
00685EDE4  b.lt     #0x685ed54
00685EDE8  ldr      x20, [x19, #0x18]
00685EDEC  mov      x0, x19
00685EDF0  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685EDF4  cbz      x0, #0x685ee50
00685EDF8  adrp     x22, #0x959b000
00685EDFC  ldrb     w8, [x22, #0xb83]
00685EE00  mov      x21, x0
00685EE04  cbnz     w8, #0x685ee1c
00685EE08  adrp     x0, #0x8f23000
00685EE0C  ldr      x0, [x0, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroup() @ 0x923f8b8
00685EE10  bl       #0x382bd14 ; 
00685EE14  mov      w8, #1
00685EE18  strb     w8, [x22, #0xb83]
00685EE1C  adrp     x8, #0x8f23000
00685EE20  ldr      x8, [x8, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroup() @ 0x923f8b8
00685EE24  ldr      x1, [x8]
00685EE28  ldrb     w8, [x1, #0x53]
00685EE2C  tbnz     w8, #5, #0x685ee40
00685EE30  ldr      w8, [x21, #0x2c4]
00685EE34  sub      w8, w8, #1
00685EE38  str      w8, [x21, #0x2c4]
00685EE3C  b        #0x685ed54 ; 
00685EE40  ldr      x8, [x1, #0x60]
00685EE44  mov      x0, x21
00685EE48  blr      x8
00685EE4C  b        #0x685ed54 ; 
00685EE50  bl       #0x382bfb8 ; 

