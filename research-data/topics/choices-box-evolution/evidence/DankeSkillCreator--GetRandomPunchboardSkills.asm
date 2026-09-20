; HotFix.BattleLogic.DankeSkillCreator$$GetRandomPunchboardSkills
; RVA 0x6863A38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006863A38  sub      sp, sp, #0x80
006863A3C  stp      x29, x30, [sp, #0x20]
006863A40  stp      x28, x27, [sp, #0x30]
006863A44  stp      x26, x25, [sp, #0x40]
006863A48  stp      x24, x23, [sp, #0x50]
006863A4C  stp      x22, x21, [sp, #0x60]
006863A50  stp      x20, x19, [sp, #0x70]
006863A54  adrp     x28, #0x959b000
006863A58  adrp     x29, #0x8f23000
006863A5C  ldrb     w8, [x28, #0x9fc]
006863A60  ldr      x23, [sp, #0x80]
006863A64  ldr      x29, [x29, #0xd68] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetRandomPunchboardSkills() @ 0x9259d60
006863A68  mov      w26, w7
006863A6C  mov      w27, w6
006863A70  mov      x25, x5
006863A74  mov      w20, w4
006863A78  mov      x21, x3
006863A7C  mov      x24, x2
006863A80  mov      x22, x1
006863A84  mov      x19, x0
006863A88  tbnz     w8, #0, #0x6863ac4
006863A8C  adrp     x0, #0x8f23000
006863A90  ldr      x0, [x0, #0xd68] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetRandomPunchboardSkills() @ 0x9259d60
006863A94  bl       #0x382bd14 ; 
006863A98  adrp     x0, #0x8ec2000
006863A9C  ldr      x0, [x0, #0x240] ; GLOBAL Method$System.Collections.Generic.List<int>.Clear() @ 0x921de58
006863AA0  bl       #0x382bd14 ; 
006863AA4  adrp     x0, #0x8ec2000
006863AA8  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
006863AAC  bl       #0x382bd14 ; 
006863AB0  adrp     x0, #0x8f23000
006863AB4  ldr      x0, [x0, #0xd70] ; GLOBAL 数量不足,逻辑有问题 @ 0x932d4a0
006863AB8  bl       #0x382bd14 ; 
006863ABC  mov      w8, #1
006863AC0  strb     w8, [x28, #0x9fc]
006863AC4  ldr      x8, [x29]
006863AC8  ldrb     w9, [x8, #0x53]
006863ACC  tbnz     w9, #5, #0x6863bf8
006863AD0  str      xzr, [sp, #0x18]
006863AD4  cbz      x22, #0x6863d10
006863AD8  ldr      w8, [x22, #0x1c]
006863ADC  add      w8, w8, #1
006863AE0  stp      wzr, w8, [x22, #0x18]
006863AE4  cbz      x24, #0x6863d10
006863AE8  ldr      w8, [x24, #0x1c]
006863AEC  add      w8, w8, #1
006863AF0  stp      wzr, w8, [x24, #0x18]
006863AF4  cbz      x21, #0x6863d10
006863AF8  ldr      w8, [x21, #0x1c]
006863AFC  mov      x0, x19
006863B00  add      w8, w8, #1
006863B04  stp      wzr, w8, [x21, #0x18]
006863B08  ldr      x28, [x19, #0x48]
006863B0C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006863B10  cbz      x0, #0x6863d10
006863B14  ldrb     w8, [x0, #0x25]
006863B18  cbz      w8, #0x6863c40
006863B1C  mov      x0, x19
006863B20  bl       #0x685ee54 ; HotFix.BattleLogic.DankeSkillCreator$$InitDankeReadyStudySkills
006863B24  mov      x0, x19
006863B28  bl       #0x685ecf8 ; HotFix.BattleLogic.DankeSkillCreator$$InitDankeAlreadyStudySkills
006863B2C  add      x2, sp, #0x1c
006863B30  add      x3, sp, #0x18
006863B34  mov      x0, x19
006863B38  mov      x1, x23
006863B3C  bl       #0x685efb0 ; HotFix.BattleLogic.DankeSkillCreator$$GetSkillCountOnType
006863B40  ldr      x1, [x19, #0x28]
006863B44  mov      x0, x19
006863B48  mov      x2, x28
006863B4C  bl       #0x6863850 ; HotFix.BattleLogic.DankeSkillCreator$$GetAlreadyStudyRandomPool
006863B50  and      w4, w27, #1
006863B54  and      w5, w26, #1
006863B58  mov      x0, x19
006863B5C  mov      x1, x22
006863B60  mov      w2, w20
006863B64  mov      x3, x25
006863B68  mov      x6, x23
006863B6C  mov      w7, wzr
006863B70  str      xzr, [sp, #0x18]
006863B74  str      wzr, [sp]
006863B78  bl       #0x6863d14 ; HotFix.BattleLogic.DankeSkillCreator$$RandomPunchboardSkill
006863B7C  ldr      w9, [x24, #0x18]
006863B80  ldr      w8, [x22, #0x18]
006863B84  mov      x24, x0
006863B88  sub      w9, w20, w9
006863B8C  sub      w3, w9, w8
006863B90  cmp      w3, #1
006863B94  b.lt     #0x6863bac
006863B98  mov      x0, x19
006863B9C  mov      x1, x21
006863BA0  mov      x2, x23
006863BA4  bl       #0x68606ec ; HotFix.BattleLogic.SinglePlayerSkillCreator$$GetInginiteSkill
006863BA8  ldr      w8, [x22, #0x18]
006863BAC  ldr      w9, [x21, #0x18]
006863BB0  sub      w8, w20, w8
006863BB4  sub      w8, w8, w9
006863BB8  cmp      w8, #1
006863BBC  b.lt     #0x6863bd4
006863BC0  adrp     x8, #0x8f23000
006863BC4  ldr      x8, [x8, #0xd70] ; GLOBAL 数量不足,逻辑有问题 @ 0x932d4a0
006863BC8  mov      x0, x19
006863BCC  ldr      x1, [x8]
006863BD0  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
006863BD4  mov      x0, x24
006863BD8  ldp      x20, x19, [sp, #0x70]
006863BDC  ldp      x22, x21, [sp, #0x60]
006863BE0  ldp      x24, x23, [sp, #0x50]
006863BE4  ldp      x26, x25, [sp, #0x40]
006863BE8  ldp      x28, x27, [sp, #0x30]
006863BEC  ldp      x29, x30, [sp, #0x20]
006863BF0  add      sp, sp, #0x80
006863BF4  ret      
006863BF8  ldr      x9, [x8, #0x60]
006863BFC  stp      x23, x8, [sp, #0x80]
006863C00  and      w6, w27, #1
006863C04  and      w7, w26, #1
006863C08  mov      x0, x19
006863C0C  mov      x1, x22
006863C10  mov      x2, x24
006863C14  mov      x3, x21
006863C18  mov      w4, w20
006863C1C  mov      x5, x25
006863C20  ldp      x20, x19, [sp, #0x70]
006863C24  ldp      x22, x21, [sp, #0x60]
006863C28  ldp      x24, x23, [sp, #0x50]
006863C2C  ldp      x26, x25, [sp, #0x40]
006863C30  ldp      x28, x27, [sp, #0x30]
006863C34  ldp      x29, x30, [sp, #0x20]
006863C38  add      sp, sp, #0x80
006863C3C  br       x9
006863C40  mov      x0, x19
006863C44  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006863C48  cbz      x0, #0x6863d10
006863C4C  adrp     x8, #0x959b000
006863C50  ldrb     w8, [x8, #0xb84]
006863C54  mov      x29, x0
006863C58  cbnz     w8, #0x6863c74
006863C5C  adrp     x0, #0x8f23000
006863C60  ldr      x0, [x0, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
006863C64  bl       #0x382bd14 ; 
006863C68  mov      w8, #1
006863C6C  adrp     x9, #0x959b000
006863C70  strb     w8, [x9, #0xb84]
006863C74  adrp     x8, #0x8f23000
006863C78  ldr      x8, [x8, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
006863C7C  ldr      x1, [x8]
006863C80  ldrb     w8, [x1, #0x53]
006863C84  tbnz     w8, #5, #0x6863c90
006863C88  ldr      w0, [x29, #0x2c4]
006863C8C  b        #0x6863c9c ; 
006863C90  ldr      x8, [x1, #0x60]
006863C94  mov      x0, x29
006863C98  blr      x8
006863C9C  cmp      w0, #1
006863CA0  b.lt     #0x6863b1c
006863CA4  ldr      x28, [x19, #0x18]
006863CA8  mov      x0, x19
006863CAC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006863CB0  cbz      x0, #0x6863d10
006863CB4  adrp     x8, #0x959b000
006863CB8  ldrb     w8, [x8, #0xb83]
006863CBC  mov      x29, x0
006863CC0  cbnz     w8, #0x6863cdc
006863CC4  adrp     x0, #0x8f23000
006863CC8  ldr      x0, [x0, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroup() @ 0x923f8b8
006863CCC  bl       #0x382bd14 ; 
006863CD0  mov      w8, #1
006863CD4  adrp     x9, #0x959b000
006863CD8  strb     w8, [x9, #0xb83]
006863CDC  adrp     x8, #0x8f23000
006863CE0  ldr      x8, [x8, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroup() @ 0x923f8b8
006863CE4  ldr      x1, [x8]
006863CE8  ldrb     w8, [x1, #0x53]
006863CEC  tbnz     w8, #5, #0x6863d00
006863CF0  ldr      w8, [x29, #0x2c4]
006863CF4  sub      w8, w8, #1
006863CF8  str      w8, [x29, #0x2c4]
006863CFC  b        #0x6863b1c ; 
006863D00  ldr      x8, [x1, #0x60]
006863D04  mov      x0, x29
006863D08  blr      x8
006863D0C  b        #0x6863b1c ; 
006863D10  bl       #0x382bfb8 ; 

