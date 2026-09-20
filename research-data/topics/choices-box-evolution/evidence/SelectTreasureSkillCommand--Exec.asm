; HotFix.BattleLogic.SelectTreasureSkillCommand$$Exec
; RVA 0x665BD18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00665BD18  str      x30, [sp, #-0x40]!
00665BD1C  stp      x24, x23, [sp, #0x10]
00665BD20  stp      x22, x21, [sp, #0x20]
00665BD24  stp      x20, x19, [sp, #0x30]
00665BD28  adrp     x20, #0x9599000
00665BD2C  adrp     x21, #0x8f0e000
00665BD30  ldrb     w8, [x20, #0xce3]
00665BD34  ldr      x21, [x21, #0xc28] ; GLOBAL Method$HotFix.BattleLogic.SelectTreasureSkillCommand.Exec() @ 0x92a67f0
00665BD38  mov      x19, x0
00665BD3C  tbnz     w8, #0, #0x665bd60
00665BD40  adrp     x0, #0x8f07000
00665BD44  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
00665BD48  bl       #0x382bd14 ; 
00665BD4C  adrp     x0, #0x8f0e000
00665BD50  ldr      x0, [x0, #0xc28] ; GLOBAL Method$HotFix.BattleLogic.SelectTreasureSkillCommand.Exec() @ 0x92a67f0
00665BD54  bl       #0x382bd14 ; 
00665BD58  mov      w8, #1
00665BD5C  strb     w8, [x20, #0xce3]
00665BD60  ldr      x1, [x21]
00665BD64  ldrb     w8, [x1, #0x53]
00665BD68  tbnz     w8, #5, #0x665bda8
00665BD6C  adrp     x22, #0x9599000
00665BD70  ldrb     w8, [x22, #0xeb0]
00665BD74  cbnz     w8, #0x665bd8c
00665BD78  adrp     x0, #0x8f0d000
00665BD7C  ldr      x0, [x0, #0xc48] ; GLOBAL Method$HotFix.BattleLogic.FrameCommand.get_WorldContext() @ 0x926ed38
00665BD80  bl       #0x382bd14 ; 
00665BD84  mov      w8, #1
00665BD88  strb     w8, [x22, #0xeb0]
00665BD8C  adrp     x23, #0x8f0d000
00665BD90  ldr      x23, [x23, #0xc48] ; GLOBAL Method$HotFix.BattleLogic.FrameCommand.get_WorldContext() @ 0x926ed38
00665BD94  ldr      x1, [x23]
00665BD98  ldrb     w8, [x1, #0x53]
00665BD9C  tbnz     w8, #5, #0x665bdc4
00665BDA0  ldr      x0, [x19, #0x10]
00665BDA4  b        #0x665bdd0 ; 
00665BDA8  ldr      x2, [x1, #0x60]
00665BDAC  mov      x0, x19
00665BDB0  ldp      x20, x19, [sp, #0x30]
00665BDB4  ldp      x22, x21, [sp, #0x20]
00665BDB8  ldp      x24, x23, [sp, #0x10]
00665BDBC  ldr      x30, [sp], #0x40
00665BDC0  br       x2
00665BDC4  ldr      x8, [x1, #0x60]
00665BDC8  mov      x0, x19
00665BDCC  blr      x8
00665BDD0  cbz      x0, #0x665bf94
00665BDD4  ldrb     w1, [x19, #0x20]
00665BDD8  mov      x2, xzr
00665BDDC  bl       #0x69ff9f4 ; HotFix.BattleLogic.BattleWorldContext$$GetPlayer
00665BDE0  cbz      x0, #0x665bf94
00665BDE4  adrp     x8, #0x8f07000
00665BDE8  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
00665BDEC  mov      x21, x0
00665BDF0  ldr      x1, [x8]
00665BDF4  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00665BDF8  cbz      x0, #0x665bf94
00665BDFC  ldrb     w1, [x19, #0x21]
00665BE00  mov      x2, xzr
00665BE04  bl       #0x6868148 ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetBoxSkillByIndex
00665BE08  ldrb     w8, [x22, #0xeb0]
00665BE0C  mov      w20, w0
00665BE10  cbnz     w8, #0x665be28
00665BE14  adrp     x0, #0x8f0d000
00665BE18  ldr      x0, [x0, #0xc48] ; GLOBAL Method$HotFix.BattleLogic.FrameCommand.get_WorldContext() @ 0x926ed38
00665BE1C  bl       #0x382bd14 ; 
00665BE20  mov      w8, #1
00665BE24  strb     w8, [x22, #0xeb0]
00665BE28  ldr      x1, [x23]
00665BE2C  ldrb     w8, [x1, #0x53]
00665BE30  tbnz     w8, #5, #0x665be3c
00665BE34  ldr      x0, [x19, #0x10]
00665BE38  b        #0x665be48 ; 
00665BE3C  ldr      x8, [x1, #0x60]
00665BE40  mov      x0, x19
00665BE44  blr      x8
00665BE48  cbz      x0, #0x665bf94
00665BE4C  cmp      w20, #0
00665BE50  b.le     #0x665be98
00665BE54  mov      w3, #1
00665BE58  mov      x1, x21
00665BE5C  mov      w2, w20
00665BE60  mov      x4, xzr
00665BE64  mov      w24, #1
00665BE68  bl       #0x6a0dd34 ; HotFix.BattleLogic.BattleWorldContext$$AddSkillToCharacter
00665BE6C  ldrb     w8, [x22, #0xeb0]
00665BE70  cbnz     w8, #0x665be84
00665BE74  adrp     x0, #0x8f0d000
00665BE78  ldr      x0, [x0, #0xc48] ; GLOBAL Method$HotFix.BattleLogic.FrameCommand.get_WorldContext() @ 0x926ed38
00665BE7C  bl       #0x382bd14 ; 
00665BE80  strb     w24, [x22, #0xeb0]
00665BE84  ldr      x1, [x23]
00665BE88  ldrb     w8, [x1, #0x53]
00665BE8C  tbnz     w8, #5, #0x665beb8
00665BE90  ldr      x0, [x19, #0x10]
00665BE94  b        #0x665bec4 ; 
00665BE98  ldr      w8, [x0, #0x284]
00665BE9C  ldp      x20, x19, [sp, #0x30]
00665BEA0  ldp      x22, x21, [sp, #0x20]
00665BEA4  ldp      x24, x23, [sp, #0x10]
00665BEA8  orr      w8, w8, #2
00665BEAC  str      w8, [x0, #0x284]
00665BEB0  ldr      x30, [sp], #0x40
00665BEB4  ret      
00665BEB8  ldr      x8, [x1, #0x60]
00665BEBC  mov      x0, x19
00665BEC0  blr      x8
00665BEC4  cbz      x0, #0x665bf94
00665BEC8  ldrb     w3, [x19, #0x20]
00665BECC  mov      w1, #4
00665BED0  mov      w2, w20
00665BED4  mov      x4, xzr
00665BED8  bl       #0x6a08344 ; HotFix.BattleLogic.BattleWorldContext$$DispatchCloseUIEvent
00665BEDC  ldrb     w8, [x22, #0xeb0]
00665BEE0  cbnz     w8, #0x665bef8
00665BEE4  adrp     x0, #0x8f0d000
00665BEE8  ldr      x0, [x0, #0xc48] ; GLOBAL Method$HotFix.BattleLogic.FrameCommand.get_WorldContext() @ 0x926ed38
00665BEEC  bl       #0x382bd14 ; 
00665BEF0  mov      w8, #1
00665BEF4  strb     w8, [x22, #0xeb0]
00665BEF8  ldr      x1, [x23]
00665BEFC  ldrb     w8, [x1, #0x53]
00665BF00  tbnz     w8, #5, #0x665bf0c
00665BF04  ldr      x20, [x19, #0x10]
00665BF08  b        #0x665bf1c ; 
00665BF0C  ldr      x8, [x1, #0x60]
00665BF10  mov      x0, x19
00665BF14  blr      x8
00665BF18  mov      x20, x0
00665BF1C  cbz      x20, #0x665bf94
00665BF20  adrp     x21, #0x9598000
00665BF24  ldrb     w8, [x21, #0xfc4]
00665BF28  cbnz     w8, #0x665bf40
00665BF2C  adrp     x0, #0x8f05000
00665BF30  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00665BF34  bl       #0x382bd14 ; 
00665BF38  mov      w8, #1
00665BF3C  strb     w8, [x21, #0xfc4]
00665BF40  adrp     x8, #0x8f05000
00665BF44  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00665BF48  ldr      x1, [x8]
00665BF4C  ldrb     w8, [x1, #0x53]
00665BF50  tbnz     w8, #5, #0x665bf5c
00665BF54  ldr      x0, [x20, #0x220]
00665BF58  b        #0x665bf68 ; 
00665BF5C  ldr      x8, [x1, #0x60]
00665BF60  mov      x0, x20
00665BF64  blr      x8
00665BF68  cbz      x0, #0x665bf94
00665BF6C  ldr      x8, [x0]
00665BF70  ldrb     w1, [x19, #0x20]
00665BF74  ldp      x20, x19, [sp, #0x30]
00665BF78  ldp      x22, x21, [sp, #0x20]
00665BF7C  ldr      x4, [x8, #0x3c8]
00665BF80  ldr      x3, [x8, #0x3d0]
00665BF84  ldp      x24, x23, [sp, #0x10]
00665BF88  mov      w2, #1
00665BF8C  ldr      x30, [sp], #0x40
00665BF90  br       x4
00665BF94  bl       #0x382bfb8 ; 

