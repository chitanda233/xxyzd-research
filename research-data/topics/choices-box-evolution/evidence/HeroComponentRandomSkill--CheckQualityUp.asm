; HotFix.BattleLogic.HeroComponentRandomSkill$$CheckQualityUp
; RVA 0x686DE10; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686DE10  sub      sp, sp, #0x40
00686DE14  stp      x30, x23, [sp, #0x10]
00686DE18  stp      x22, x21, [sp, #0x20]
00686DE1C  stp      x20, x19, [sp, #0x30]
00686DE20  adrp     x20, #0x959b000
00686DE24  adrp     x21, #0x8f24000
00686DE28  ldrb     w8, [x20, #0xa51]
00686DE2C  ldr      x21, [x21, #0x208] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.CheckQualityUp() @ 0x927f988
00686DE30  mov      x19, x0
00686DE34  tbnz     w8, #0, #0x686de7c
00686DE38  adrp     x0, #0x8ee6000
00686DE3C  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00686DE40  bl       #0x382bd14 ; 
00686DE44  adrp     x0, #0x8ee6000
00686DE48  ldr      x0, [x0, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_InstanceId() @ 0x9210188
00686DE4C  bl       #0x382bd14 ; 
00686DE50  adrp     x0, #0x8f23000
00686DE54  ldr      x0, [x0, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00686DE58  bl       #0x382bd14 ; 
00686DE5C  adrp     x0, #0x8f24000
00686DE60  ldr      x0, [x0, #0x208] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.CheckQualityUp() @ 0x927f988
00686DE64  bl       #0x382bd14 ; 
00686DE68  adrp     x0, #0x8f24000
00686DE6C  ldr      x0, [x0, #0x210] ; GLOBAL ExHighSkillRate% @ 0x92fc1d0
00686DE70  bl       #0x382bd14 ; 
00686DE74  mov      w8, #1
00686DE78  strb     w8, [x20, #0xa51]
00686DE7C  ldr      x1, [x21]
00686DE80  ldrb     w8, [x1, #0x53]
00686DE84  tbnz     w8, #5, #0x686dea4
00686DE88  adrp     x21, #0x8f23000
00686DE8C  ldr      x21, [x21, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00686DE90  ldr      x1, [x21]
00686DE94  ldrb     w8, [x1, #0x53]
00686DE98  tbnz     w8, #5, #0x686dec0
00686DE9C  ldr      x0, [x19, #0x30]
00686DEA0  b        #0x686decc ; 
00686DEA4  ldr      x2, [x1, #0x60]
00686DEA8  mov      x0, x19
00686DEAC  ldp      x20, x19, [sp, #0x30]
00686DEB0  ldp      x22, x21, [sp, #0x20]
00686DEB4  ldp      x30, x23, [sp, #0x10]
00686DEB8  add      sp, sp, #0x40
00686DEBC  br       x2
00686DEC0  ldr      x8, [x1, #0x60]
00686DEC4  mov      x0, x19
00686DEC8  blr      x8
00686DECC  cbz      x0, #0x686e09c
00686DED0  adrp     x8, #0x8ee6000
00686DED4  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00686DED8  ldr      x1, [x8]
00686DEDC  ldrb     w8, [x1, #0x53]
00686DEE0  tbnz     w8, #5, #0x686deec
00686DEE4  ldr      x20, [x0, #0x38]
00686DEE8  b        #0x686def8 ; 
00686DEEC  ldr      x8, [x1, #0x60]
00686DEF0  blr      x8
00686DEF4  mov      x20, x0
00686DEF8  cbz      x20, #0x686e09c
00686DEFC  adrp     x22, #0x9591000
00686DF00  ldrb     w8, [x22, #0xa7f]
00686DF04  cbnz     w8, #0x686df1c
00686DF08  adrp     x0, #0x8ee6000
00686DF0C  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686DF10  bl       #0x382bd14 ; 
00686DF14  mov      w8, #1
00686DF18  strb     w8, [x22, #0xa7f]
00686DF1C  adrp     x8, #0x8ee6000
00686DF20  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00686DF24  ldr      x1, [x8]
00686DF28  ldrb     w8, [x1, #0x53]
00686DF2C  tbnz     w8, #5, #0x686df38
00686DF30  ldr      x0, [x20, #0x178]
00686DF34  b        #0x686df44 ; 
00686DF38  ldr      x8, [x1, #0x60]
00686DF3C  mov      x0, x20
00686DF40  blr      x8
00686DF44  cbz      x0, #0x686e09c
00686DF48  adrp     x8, #0x8f24000
00686DF4C  ldr      x8, [x8, #0x210] ; GLOBAL ExHighSkillRate% @ 0x92fc1d0
00686DF50  mov      x2, xzr
00686DF54  ldr      x1, [x8]
00686DF58  bl       #0x6b3b9c0 ; HotFix.Common.AttributeData$$GetAttributeValueOrDefault
00686DF5C  cmp      x0, #1
00686DF60  b.lt     #0x686dff4
00686DF64  adrp     x22, #0x9591000
00686DF68  ldrb     w8, [x22, #0xa4b]
00686DF6C  mov      x20, x0
00686DF70  cbnz     w8, #0x686df88
00686DF74  adrp     x0, #0x8ee5000
00686DF78  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686DF7C  bl       #0x382bd14 ; 
00686DF80  mov      w8, #1
00686DF84  strb     w8, [x22, #0xa4b]
00686DF88  adrp     x23, #0x8ee5000
00686DF8C  ldr      x23, [x23, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686DF90  ldr      x1, [x23]
00686DF94  ldrb     w8, [x1, #0x53]
00686DF98  tbnz     w8, #5, #0x686dfa4
00686DF9C  ldr      x0, [x19, #0x20]
00686DFA0  b        #0x686dfb0 ; 
00686DFA4  ldr      x8, [x1, #0x60]
00686DFA8  mov      x0, x19
00686DFAC  blr      x8
00686DFB0  cbz      x0, #0x686e09c
00686DFB4  mov      x1, x20
00686DFB8  mov      x2, xzr
00686DFBC  bl       #0x6a015a4 ; HotFix.BattleLogic.BattleWorldContext$$SkillRandomNextBool
00686DFC0  tbz      w0, #0, #0x686dff4
00686DFC4  ldrb     w8, [x22, #0xa4b]
00686DFC8  cbnz     w8, #0x686dfe0
00686DFCC  adrp     x0, #0x8ee5000
00686DFD0  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00686DFD4  bl       #0x382bd14 ; 
00686DFD8  mov      w8, #1
00686DFDC  strb     w8, [x22, #0xa4b]
00686DFE0  ldr      x1, [x23]
00686DFE4  ldrb     w8, [x1, #0x53]
00686DFE8  tbnz     w8, #5, #0x686dffc
00686DFEC  ldr      x20, [x19, #0x20]
00686DFF0  b        #0x686e00c ; 
00686DFF4  mov      w0, wzr
00686DFF8  b        #0x686e088 ; 
00686DFFC  ldr      x8, [x1, #0x60]
00686E000  mov      x0, x19
00686E004  blr      x8
00686E008  mov      x20, x0
00686E00C  ldr      x1, [x21]
00686E010  ldrb     w8, [x1, #0x53]
00686E014  tbnz     w8, #5, #0x686e020
00686E018  ldr      x0, [x19, #0x30]
00686E01C  b        #0x686e02c ; 
00686E020  ldr      x8, [x1, #0x60]
00686E024  mov      x0, x19
00686E028  blr      x8
00686E02C  cbz      x0, #0x686e09c
00686E030  adrp     x8, #0x8ee6000
00686E034  ldr      x8, [x8, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_InstanceId() @ 0x9210188
00686E038  ldr      x1, [x8]
00686E03C  ldrb     w8, [x1, #0x53]
00686E040  tbnz     w8, #5, #0x686e04c
00686E044  ldr      x3, [x0, #0x28]
00686E048  b        #0x686e058 ; 
00686E04C  ldr      x8, [x1, #0x60]
00686E050  blr      x8
00686E054  mov      x3, x0
00686E058  cbz      x20, #0x686e09c
00686E05C  mov      w1, #0x11
00686E060  mov      w4, #0x10000
00686E064  mov      x0, x20
00686E068  mov      w2, wzr
00686E06C  mov      w5, wzr
00686E070  mov      w6, wzr
00686E074  mov      x7, xzr
00686E078  str      xzr, [sp, #8]
00686E07C  str      wzr, [sp]
00686E080  bl       #0x6a0ed24 ; HotFix.BattleLogic.BattleWorldContext$$ShowHoverEvent
00686E084  mov      w0, #1
00686E088  ldp      x20, x19, [sp, #0x30]
00686E08C  ldp      x22, x21, [sp, #0x20]
00686E090  ldp      x30, x23, [sp, #0x10]
00686E094  add      sp, sp, #0x40
00686E098  ret      
00686E09C  bl       #0x382bfb8 ; 

