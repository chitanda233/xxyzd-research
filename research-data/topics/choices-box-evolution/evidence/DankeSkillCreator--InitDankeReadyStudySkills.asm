; HotFix.BattleLogic.DankeSkillCreator$$InitDankeReadyStudySkills
; RVA 0x685EE54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685EE54  str      x30, [sp, #-0x30]!
00685EE58  stp      x22, x21, [sp, #0x10]
00685EE5C  stp      x20, x19, [sp, #0x20]
00685EE60  adrp     x20, #0x959b000
00685EE64  adrp     x21, #0x8f23000
00685EE68  ldrb     w8, [x20, #0x9fb]
00685EE6C  ldr      x21, [x21, #0xbf0] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.InitDankeReadyStudySkills() @ 0x9259da0
00685EE70  mov      x19, x0
00685EE74  tbnz     w8, #0, #0x685ee8c
00685EE78  adrp     x0, #0x8f23000
00685EE7C  ldr      x0, [x0, #0xbf0] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.InitDankeReadyStudySkills() @ 0x9259da0
00685EE80  bl       #0x382bd14 ; 
00685EE84  mov      w8, #1
00685EE88  strb     w8, [x20, #0x9fb]
00685EE8C  ldr      x1, [x21]
00685EE90  ldrb     w8, [x1, #0x53]
00685EE94  tbnz     w8, #5, #0x685eecc
00685EE98  ldr      x20, [x19, #0x48]
00685EE9C  mov      x0, x19
00685EEA0  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685EEA4  cbz      x0, #0x685efac
00685EEA8  ldrb     w8, [x0, #0x25]
00685EEAC  cbz      w8, #0x685eee4
00685EEB0  ldr      x1, [x19, #0x38]
00685EEB4  mov      x0, x19
00685EEB8  mov      x2, x20
00685EEBC  ldp      x20, x19, [sp, #0x20]
00685EEC0  ldp      x22, x21, [sp, #0x10]
00685EEC4  ldr      x30, [sp], #0x30
00685EEC8  b        #0x6863944 ; HotFix.BattleLogic.DankeSkillCreator$$GetReadyStudyRandomPool
00685EECC  ldr      x2, [x1, #0x60]
00685EED0  mov      x0, x19
00685EED4  ldp      x20, x19, [sp, #0x20]
00685EED8  ldp      x22, x21, [sp, #0x10]
00685EEDC  ldr      x30, [sp], #0x30
00685EEE0  br       x2
00685EEE4  mov      x0, x19
00685EEE8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685EEEC  cbz      x0, #0x685efac
00685EEF0  adrp     x22, #0x959b000
00685EEF4  ldrb     w8, [x22, #0xb84]
00685EEF8  mov      x21, x0
00685EEFC  cbnz     w8, #0x685ef14
00685EF00  adrp     x0, #0x8f23000
00685EF04  ldr      x0, [x0, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
00685EF08  bl       #0x382bd14 ; 
00685EF0C  mov      w8, #1
00685EF10  strb     w8, [x22, #0xb84]
00685EF14  adrp     x8, #0x8f23000
00685EF18  ldr      x8, [x8, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
00685EF1C  ldr      x1, [x8]
00685EF20  ldrb     w8, [x1, #0x53]
00685EF24  tbnz     w8, #5, #0x685ef30
00685EF28  ldr      w0, [x21, #0x2c4]
00685EF2C  b        #0x685ef3c ; 
00685EF30  ldr      x8, [x1, #0x60]
00685EF34  mov      x0, x21
00685EF38  blr      x8
00685EF3C  cmp      w0, #1
00685EF40  b.lt     #0x685eeb0
00685EF44  ldr      x20, [x19, #0x18]
00685EF48  mov      x0, x19
00685EF4C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685EF50  cbz      x0, #0x685efac
00685EF54  adrp     x22, #0x959b000
00685EF58  ldrb     w8, [x22, #0xb83]
00685EF5C  mov      x21, x0
00685EF60  cbnz     w8, #0x685ef78
00685EF64  adrp     x0, #0x8f23000
00685EF68  ldr      x0, [x0, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroup() @ 0x923f8b8
00685EF6C  bl       #0x382bd14 ; 
00685EF70  mov      w8, #1
00685EF74  strb     w8, [x22, #0xb83]
00685EF78  adrp     x8, #0x8f23000
00685EF7C  ldr      x8, [x8, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroup() @ 0x923f8b8
00685EF80  ldr      x1, [x8]
00685EF84  ldrb     w8, [x1, #0x53]
00685EF88  tbnz     w8, #5, #0x685ef9c
00685EF8C  ldr      w8, [x21, #0x2c4]
00685EF90  sub      w8, w8, #1
00685EF94  str      w8, [x21, #0x2c4]
00685EF98  b        #0x685eeb0 ; 
00685EF9C  ldr      x8, [x1, #0x60]
00685EFA0  mov      x0, x21
00685EFA4  blr      x8
00685EFA8  b        #0x685eeb0 ; 
00685EFAC  bl       #0x382bfb8 ; 

