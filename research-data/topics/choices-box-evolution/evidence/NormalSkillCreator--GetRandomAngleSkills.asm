; HotFix.BattleLogic.NormalSkillCreator$$GetRandomAngleSkills
; RVA 0x6873358; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006873358  stp      x30, x27, [sp, #-0x50]!
00687335C  stp      x26, x25, [sp, #0x10]
006873360  stp      x24, x23, [sp, #0x20]
006873364  stp      x22, x21, [sp, #0x30]
006873368  stp      x20, x19, [sp, #0x40]
00687336C  adrp     x23, #0x959b000
006873370  adrp     x24, #0x8f24000
006873374  ldrb     w8, [x23, #0xa96]
006873378  ldr      x24, [x24, #0x438] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.GetRandomAngleSkills() @ 0x9295e88
00687337C  mov      w21, w3
006873380  mov      x20, x2
006873384  mov      x22, x1
006873388  mov      x19, x0
00687338C  tbnz     w8, #0, #0x68733ec
006873390  adrp     x0, #0x8ee1000
006873394  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006873398  bl       #0x382bd14 ; 
00687339C  adrp     x0, #0x8f24000
0068733A0  ldr      x0, [x0, #0x438] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.GetRandomAngleSkills() @ 0x9295e88
0068733A4  bl       #0x382bd14 ; 
0068733A8  adrp     x0, #0x8f08000
0068733AC  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
0068733B0  bl       #0x382bd14 ; 
0068733B4  adrp     x0, #0x8f08000
0068733B8  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
0068733BC  bl       #0x382bd14 ; 
0068733C0  adrp     x0, #0x8f24000
0068733C4  ldr      x0, [x0, #0x440] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\NormalSkillCreator.cs @ 0x92f8048
0068733C8  bl       #0x382bd14 ; 
0068733CC  adrp     x0, #0x8f24000
0068733D0  ldr      x0, [x0, #0x448] ; GLOBAL GetRandomAngleSkills @ 0x92fed38
0068733D4  bl       #0x382bd14 ; 
0068733D8  adrp     x0, #0x8f24000
0068733DC  ldr      x0, [x0, #0x450] ; GLOBAL 天使技能池数量不足 @ 0x932d038
0068733E0  bl       #0x382bd14 ; 
0068733E4  mov      w8, #1
0068733E8  strb     w8, [x23, #0xa96]
0068733EC  ldr      x4, [x24]
0068733F0  ldrb     w8, [x4, #0x53]
0068733F4  tbnz     w8, #5, #0x6873498
0068733F8  mov      x0, x19
0068733FC  bl       #0x68730f0 ; HotFix.BattleLogic.NormalSkillCreator$$AngelRandomSkillQuality
006873400  ldr      x8, [x19, #0x78]
006873404  cbz      x8, #0x68735f4
006873408  ldr      w9, [x8, #0x18]
00687340C  mov      w23, w0
006873410  cmp      w0, w9
006873414  b.hs     #0x68735f8
006873418  sxtw     x26, w23
00687341C  add      x8, x8, x26, lsl #3
006873420  ldr      x0, [x8, #0x20]
006873424  cbz      x0, #0x68735f4
006873428  mov      x1, x22
00687342C  mov      x2, xzr
006873430  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
006873434  cmp      w0, w21
006873438  b.ge     #0x68734c4
00687343C  adrp     x8, #0x8ee1000
006873440  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006873444  ldr      x0, [x8]
006873448  ldr      w8, [x0, #0xe0]
00687344C  cbnz     w8, #0x6873454
006873450  bl       #0x382be8c ; 
006873454  adrp     x8, #0x8f24000
006873458  adrp     x9, #0x8f24000
00687345C  adrp     x10, #0x8f24000
006873460  ldr      x8, [x8, #0x450] ; GLOBAL 天使技能池数量不足 @ 0x932d038
006873464  ldr      x9, [x9, #0x448] ; GLOBAL GetRandomAngleSkills @ 0x92fed38
006873468  ldr      x10, [x10, #0x440] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\NormalSkillCreator.cs @ 0x92f8048
00687346C  ldp      x20, x19, [sp, #0x40]
006873470  ldr      x0, [x8]
006873474  ldr      x1, [x9]
006873478  ldr      x2, [x10]
00687347C  ldp      x22, x21, [sp, #0x30]
006873480  ldp      x24, x23, [sp, #0x20]
006873484  ldp      x26, x25, [sp, #0x10]
006873488  mov      w3, #0x3c
00687348C  mov      x4, xzr
006873490  ldp      x30, x27, [sp], #0x50
006873494  b        #0x7997754 ; Logger$$LogError
006873498  ldr      x5, [x4, #0x60]
00687349C  mov      x0, x19
0068734A0  mov      x1, x22
0068734A4  mov      x2, x20
0068734A8  mov      w3, w21
0068734AC  ldp      x20, x19, [sp, #0x40]
0068734B0  ldp      x22, x21, [sp, #0x30]
0068734B4  ldp      x24, x23, [sp, #0x20]
0068734B8  ldp      x26, x25, [sp, #0x10]
0068734BC  ldp      x30, x27, [sp], #0x50
0068734C0  br       x5
0068734C4  mov      x0, x19
0068734C8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068734CC  cbz      x0, #0x68735f4
0068734D0  adrp     x25, #0x9591000
0068734D4  ldrb     w8, [x25, #0xa90]
0068734D8  mov      x24, x0
0068734DC  cbnz     w8, #0x68734f4
0068734E0  adrp     x0, #0x8ee6000
0068734E4  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
0068734E8  bl       #0x382bd14 ; 
0068734EC  mov      w8, #1
0068734F0  strb     w8, [x25, #0xa90]
0068734F4  adrp     x27, #0x8ee6000
0068734F8  ldr      x27, [x27, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
0068734FC  ldr      x1, [x27]
006873500  ldrb     w8, [x1, #0x53]
006873504  tbnz     w8, #5, #0x6873510
006873508  ldr      x0, [x24, #0x230]
00687350C  b        #0x687351c ; 
006873510  ldr      x8, [x1, #0x60]
006873514  mov      x0, x24
006873518  blr      x8
00687351C  cbz      x0, #0x68735f4
006873520  adrp     x8, #0x8f08000
006873524  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006873528  ldr      x1, [x8]
00687352C  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006873530  mov      x24, x0
006873534  mov      x0, x19
006873538  mov      x1, x24
00687353C  mov      x2, x20
006873540  bl       #0x68633d4 ; HotFix.BattleLogic.HeroSkillCreator$$GetBanSkill
006873544  ldr      x8, [x19, #0x78]
006873548  cbz      x8, #0x68735f4
00687354C  ldr      w9, [x8, #0x18]
006873550  cmp      w23, w9
006873554  b.hs     #0x68735f8
006873558  add      x8, x8, x26, lsl #3
00687355C  ldr      x0, [x8, #0x20]
006873560  cbz      x0, #0x68735f4
006873564  mov      w1, w21
006873568  mov      x2, x22
00687356C  mov      x3, x20
006873570  mov      x4, x24
006873574  mov      x5, xzr
006873578  bl       #0x6633c0c ; HotFix.BattleLogic.WeightRandom$$GetRandomCount
00687357C  mov      x0, x19
006873580  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006873584  cbz      x0, #0x68735f4
006873588  ldrb     w8, [x25, #0xa90]
00687358C  mov      x19, x0
006873590  cbnz     w8, #0x68735a8
006873594  adrp     x0, #0x8ee6000
006873598  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00687359C  bl       #0x382bd14 ; 
0068735A0  mov      w8, #1
0068735A4  strb     w8, [x25, #0xa90]
0068735A8  ldr      x1, [x27]
0068735AC  ldrb     w8, [x1, #0x53]
0068735B0  tbnz     w8, #5, #0x68735bc
0068735B4  ldr      x0, [x19, #0x230]
0068735B8  b        #0x68735c8 ; 
0068735BC  ldr      x8, [x1, #0x60]
0068735C0  mov      x0, x19
0068735C4  blr      x8
0068735C8  cbz      x0, #0x68735f4
0068735CC  adrp     x8, #0x8f08000
0068735D0  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
0068735D4  mov      x1, x24
0068735D8  ldp      x20, x19, [sp, #0x40]
0068735DC  ldp      x22, x21, [sp, #0x30]
0068735E0  ldr      x2, [x8]
0068735E4  ldp      x24, x23, [sp, #0x20]
0068735E8  ldp      x26, x25, [sp, #0x10]
0068735EC  ldp      x30, x27, [sp], #0x50
0068735F0  b        #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
0068735F4  bl       #0x382bfb8 ; 
0068735F8  bl       #0x382bfc0 ; 

