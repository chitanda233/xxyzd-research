; HotFix.BattleLogic.DankeSkillCreator$$OpenSelectSpecialSkill
; RVA 0x6862C6C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006862C6C  sub      sp, sp, #0x80
006862C70  stp      x29, x30, [sp, #0x20]
006862C74  stp      x28, x27, [sp, #0x30]
006862C78  stp      x26, x25, [sp, #0x40]
006862C7C  stp      x24, x23, [sp, #0x50]
006862C80  stp      x22, x21, [sp, #0x60]
006862C84  stp      x20, x19, [sp, #0x70]
006862C88  adrp     x20, #0x959b000
006862C8C  adrp     x22, #0x8f23000
006862C90  ldrb     w8, [x20, #0x9f9]
006862C94  ldr      x22, [x22, #0xd20] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.OpenSelectSpecialSkill() @ 0x9259dd8
006862C98  mov      x23, x3
006862C9C  mov      x19, x2
006862CA0  mov      x21, x0
006862CA4  str      x1, [sp, #8]
006862CA8  tbnz     w8, #0, #0x6862d54
006862CAC  adrp     x0, #0x8f23000
006862CB0  ldr      x0, [x0, #0xd20] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.OpenSelectSpecialSkill() @ 0x9259dd8
006862CB4  bl       #0x382bd14 ; 
006862CB8  adrp     x0, #0x8ebf000
006862CBC  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006862CC0  bl       #0x382bd14 ; 
006862CC4  adrp     x0, #0x8f08000
006862CC8  ldr      x0, [x0, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
006862CCC  bl       #0x382bd14 ; 
006862CD0  adrp     x0, #0x8ed2000
006862CD4  ldr      x0, [x0, #0xdd8] ; GLOBAL Method$System.Collections.Generic.List<int>.RemoveAt() @ 0x921de98
006862CD8  bl       #0x382bd14 ; 
006862CDC  adrp     x0, #0x8ec2000
006862CE0  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
006862CE4  bl       #0x382bd14 ; 
006862CE8  adrp     x0, #0x8ec2000
006862CEC  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006862CF0  bl       #0x382bd14 ; 
006862CF4  adrp     x0, #0x8ee1000
006862CF8  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006862CFC  bl       #0x382bd14 ; 
006862D00  adrp     x0, #0x8ebf000
006862D04  ldr      x0, [x0, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
006862D08  bl       #0x382bd14 ; 
006862D0C  adrp     x0, #0x8f08000
006862D10  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006862D14  bl       #0x382bd14 ; 
006862D18  adrp     x0, #0x8f23000
006862D1C  ldr      x0, [x0, #0xd28] ; GLOBAL OpenSelectSpecialSkill @ 0x93082a0
006862D20  bl       #0x382bd14 ; 
006862D24  adrp     x0, #0x8f23000
006862D28  ldr      x0, [x0, #0xc80] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\DankeSkillCreator.cs @ 0x92f8028
006862D2C  bl       #0x382bd14 ; 
006862D30  adrp     x0, #0x8f23000
006862D34  ldr      x0, [x0, #0xd30] ; GLOBAL -[OpenSelectSpecialSkill] UpgradeSurvivor表技能id不存在! UpgradeSurvivorId={0} @ 0x92eab78
006862D38  bl       #0x382bd14 ; 
006862D3C  adrp     x0, #0x8f0d000
006862D40  ldr      x0, [x0, #0x50] ; GLOBAL have is ban Skill   ID = {0} @ 0x9321788
006862D44  bl       #0x382bd14 ; 
006862D48  ldr      x1, [sp, #8]
006862D4C  mov      w8, #1
006862D50  strb     w8, [x20, #0x9f9]
006862D54  ldr      x4, [x22]
006862D58  ldrb     w8, [x4, #0x53]
006862D5C  tbnz     w8, #5, #0x6862db0
006862D60  mov      x0, x21
006862D64  str      wzr, [x23]
006862D68  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006862D6C  cbz      x0, #0x686333c
006862D70  adrp     x20, #0x9591000
006862D74  ldrb     w8, [x20, #0xa90]
006862D78  mov      x22, x0
006862D7C  cbnz     w8, #0x6862d94
006862D80  adrp     x0, #0x8ee6000
006862D84  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006862D88  bl       #0x382bd14 ; 
006862D8C  mov      w8, #1
006862D90  strb     w8, [x20, #0xa90]
006862D94  adrp     x8, #0x8ee6000
006862D98  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006862D9C  ldr      x1, [x8]
006862DA0  ldrb     w8, [x1, #0x53]
006862DA4  tbnz     w8, #5, #0x6862de0
006862DA8  ldr      x0, [x22, #0x230]
006862DAC  b        #0x6862dec ; 
006862DB0  ldr      x5, [x4, #0x60]
006862DB4  mov      x0, x21
006862DB8  mov      x2, x19
006862DBC  mov      x3, x23
006862DC0  ldp      x20, x19, [sp, #0x70]
006862DC4  ldp      x22, x21, [sp, #0x60]
006862DC8  ldp      x24, x23, [sp, #0x50]
006862DCC  ldp      x26, x25, [sp, #0x40]
006862DD0  ldp      x28, x27, [sp, #0x30]
006862DD4  ldp      x29, x30, [sp, #0x20]
006862DD8  add      sp, sp, #0x80
006862DDC  br       x5
006862DE0  ldr      x8, [x1, #0x60]
006862DE4  mov      x0, x22
006862DE8  blr      x8
006862DEC  cbz      x0, #0x686333c
006862DF0  adrp     x8, #0x8f08000
006862DF4  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006862DF8  ldr      x1, [x8]
006862DFC  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006862E00  mov      x1, x0
006862E04  mov      x0, x21
006862E08  mov      x2, x19
006862E0C  str      x1, [sp, #0x10]
006862E10  bl       #0x68633d4 ; HotFix.BattleLogic.HeroSkillCreator$$GetBanSkill
006862E14  ldr      x8, [x21, #0xc0]
006862E18  cbz      x8, #0x686333c
006862E1C  ldr      w8, [x8, #0x18]
006862E20  cmp      w8, #1
006862E24  b.lt     #0x6862ec8
006862E28  ldr      x0, [x21, #0x98]
006862E2C  cbz      x0, #0x686333c
006862E30  mov      x1, xzr
006862E34  bl       #0x66352b0 ; HotFix.BattleLogic.WeightRandom$$Clear
006862E38  ldr      x0, [x21, #0xc0]
006862E3C  cbz      x0, #0x686333c
006862E40  adrp     x8, #0x8ec2000
006862E44  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006862E48  mov      w1, wzr
006862E4C  ldr      x2, [x8]
006862E50  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006862E54  str      w0, [x23]
006862E58  mov      w24, w0
006862E5C  ldr      x0, [x21, #0xc0]
006862E60  cbz      x0, #0x686333c
006862E64  adrp     x8, #0x8ed2000
006862E68  ldr      x8, [x8, #0xdd8] ; GLOBAL Method$System.Collections.Generic.List<int>.RemoveAt() @ 0x921de98
006862E6C  mov      w1, wzr
006862E70  ldr      x2, [x8]
006862E74  bl       #0x4d6603c ; System.Collections.Generic.List<int>$$RemoveAt
006862E78  mov      x0, x21
006862E7C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006862E80  cbz      x0, #0x686333c
006862E84  adrp     x8, #0x9598000
006862E88  ldrb     w8, [x8, #0xfcc]
006862E8C  mov      x25, x0
006862E90  cbnz     w8, #0x6862eac
006862E94  adrp     x0, #0x8f06000
006862E98  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006862E9C  bl       #0x382bd14 ; 
006862EA0  mov      w8, #1
006862EA4  adrp     x9, #0x9598000
006862EA8  strb     w8, [x9, #0xfcc]
006862EAC  adrp     x23, #0x8f06000
006862EB0  ldr      x23, [x23, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006862EB4  ldr      x1, [x23]
006862EB8  ldrb     w8, [x1, #0x53]
006862EBC  tbnz     w8, #5, #0x6862ed0
006862EC0  ldr      x0, [x25, #0x200]
006862EC4  b        #0x6862edc ; 
006862EC8  mov      w0, wzr
006862ECC  b        #0x686331c ; 
006862ED0  ldr      x8, [x1, #0x60]
006862ED4  mov      x0, x25
006862ED8  blr      x8
006862EDC  cbz      x0, #0x686333c
006862EE0  mov      w1, w24
006862EE4  mov      x2, xzr
006862EE8  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006862EEC  cbz      x0, #0x686333c
006862EF0  mov      x1, xzr
006862EF4  bl       #0x6b0a438 ; LocalModels.Bean.Skill_Main$$GetUpgradeSkillId
006862EF8  cbz      x0, #0x686333c
006862EFC  ldr      w8, [x0, #0x18]
006862F00  mov      x24, x0
006862F04  cmp      w8, #1
006862F08  b.lt     #0x686327c
006862F0C  adrp     x26, #0x8f09000
006862F10  ldr      x26, [x26, #0x300] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_NeedSkills() @ 0x92ac4e0
006862F14  mov      x25, xzr
006862F18  adrp     x22, #0x9599000
006862F1C  mov      x0, x21
006862F20  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006862F24  cbz      x0, #0x686333c
006862F28  adrp     x8, #0x9598000
006862F2C  ldrb     w8, [x8, #0xfcc]
006862F30  mov      x27, x0
006862F34  cbnz     w8, #0x6862f4c
006862F38  mov      x0, x23
006862F3C  bl       #0x382bd14 ; 
006862F40  adrp     x8, #0x9598000
006862F44  mov      w9, #1
006862F48  strb     w9, [x8, #0xfcc]
006862F4C  ldr      x1, [x23]
006862F50  ldrb     w8, [x1, #0x53]
006862F54  tbnz     w8, #5, #0x6862f60
006862F58  ldr      x0, [x27, #0x200]
006862F5C  b        #0x6862f6c ; 
006862F60  ldr      x8, [x1, #0x60]
006862F64  mov      x0, x27
006862F68  blr      x8
006862F6C  ldr      w8, [x24, #0x18]
006862F70  cmp      x25, x8
006862F74  b.hs     #0x68633d0
006862F78  cbz      x0, #0x686333c
006862F7C  add      x8, x24, x25, lsl #2
006862F80  add      x20, x8, #0x20
006862F84  ldr      w1, [x20]
006862F88  mov      x2, xzr
006862F8C  bl       #0x64d5d88 ; LocalModels.LocalModelManager$$GetSkillGroup_UpgradeSurvivorGroup
006862F90  cbz      x0, #0x6863340
006862F94  adrp     x8, #0x959b000
006862F98  ldrb     w8, [x8, #0xb8a]
006862F9C  mov      x27, x0
006862FA0  cbnz     w8, #0x6862fbc
006862FA4  adrp     x0, #0x8f23000
006862FA8  ldr      x0, [x0, #0xd38] ; GLOBAL Method$LocalModels.Bean.SkillGroup_UpgradeSurvivorGroup.get_GetID() @ 0x92ab9a0
006862FAC  bl       #0x382bd14 ; 
006862FB0  mov      w8, #1
006862FB4  adrp     x9, #0x959b000
006862FB8  strb     w8, [x9, #0xb8a]
006862FBC  adrp     x8, #0x8f23000
006862FC0  ldr      x8, [x8, #0xd38] ; GLOBAL Method$LocalModels.Bean.SkillGroup_UpgradeSurvivorGroup.get_GetID() @ 0x92ab9a0
006862FC4  ldr      x1, [x8]
006862FC8  ldrb     w8, [x1, #0x53]
006862FCC  tbnz     w8, #5, #0x6862fd8
006862FD0  ldr      w28, [x27, #0x24]
006862FD4  b        #0x6862fe8 ; 
006862FD8  ldr      x8, [x1, #0x60]
006862FDC  mov      x0, x27
006862FE0  blr      x8
006862FE4  mov      w28, w0
006862FE8  mov      x0, x21
006862FEC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006862FF0  cbz      x0, #0x686333c
006862FF4  adrp     x8, #0x9598000
006862FF8  ldrb     w8, [x8, #0xfcc]
006862FFC  mov      x29, x0
006863000  cbnz     w8, #0x6863018
006863004  mov      x0, x23
006863008  bl       #0x382bd14 ; 
00686300C  adrp     x8, #0x9598000
006863010  mov      w9, #1
006863014  strb     w9, [x8, #0xfcc]
006863018  ldr      x1, [x23]
00686301C  ldrb     w8, [x1, #0x53]
006863020  tbnz     w8, #5, #0x686302c
006863024  ldr      x0, [x29, #0x200]
006863028  b        #0x6863038 ; 
00686302C  ldr      x8, [x1, #0x60]
006863030  mov      x0, x29
006863034  blr      x8
006863038  mov      x1, x19
00686303C  mov      w2, w28
006863040  mov      x3, xzr
006863044  bl       #0x691f410 ; HotFix.BattleLogic.GameUtils$$CheckCanStudySkill
006863048  tbz      w0, #0, #0x686308c
00686304C  ldr      x0, [sp, #0x10]
006863050  cbz      x0, #0x686333c
006863054  adrp     x8, #0x8f08000
006863058  ldr      x8, [x8, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
00686305C  mov      w1, w28
006863060  ldr      x2, [x8]
006863064  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006863068  tbnz     w0, #0, #0x686308c
00686306C  ldr      x0, [sp, #8]
006863070  cbz      x0, #0x686333c
006863074  adrp     x8, #0x8f08000
006863078  ldr      x8, [x8, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
00686307C  mov      w1, w28
006863080  ldr      x2, [x8]
006863084  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006863088  tbz      w0, #0, #0x68630e0
00686308C  adrp     x8, #0x8ebf000
006863090  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006863094  add      x1, sp, #0x18
006863098  str      w28, [sp, #0x18]
00686309C  ldr      x0, [x8]
0068630A0  bl       #0x382be94 ; 
0068630A4  adrp     x8, #0x8f0d000
0068630A8  ldr      x8, [x8, #0x50] ; GLOBAL have is ban Skill   ID = {0} @ 0x9321788
0068630AC  mov      x1, x0
0068630B0  mov      x2, xzr
0068630B4  ldr      x8, [x8]
0068630B8  mov      x0, x8
0068630BC  bl       #0x79d140c ; System.String$$Format
0068630C0  mov      x1, x0
0068630C4  mov      x0, x21
0068630C8  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
0068630CC  ldrsw    x8, [x24, #0x18]
0068630D0  add      x25, x25, #1
0068630D4  cmp      x25, x8
0068630D8  b.lt     #0x6862f1c
0068630DC  b        #0x686327c ; 
0068630E0  mov      x0, x21
0068630E4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068630E8  cbz      x0, #0x686333c
0068630EC  adrp     x8, #0x9598000
0068630F0  ldrb     w8, [x8, #0xfcc]
0068630F4  mov      x29, x0
0068630F8  cbnz     w8, #0x6863110
0068630FC  mov      x0, x23
006863100  bl       #0x382bd14 ; 
006863104  adrp     x8, #0x9598000
006863108  mov      w9, #1
00686310C  strb     w9, [x8, #0xfcc]
006863110  ldr      x1, [x23]
006863114  ldrb     w8, [x1, #0x53]
006863118  tbnz     w8, #5, #0x6863124
00686311C  ldr      x0, [x29, #0x200]
006863120  b        #0x6863130 ; 
006863124  ldr      x8, [x1, #0x60]
006863128  mov      x0, x29
00686312C  blr      x8
006863130  cbz      x0, #0x686333c
006863134  mov      w1, w28
006863138  mov      x2, xzr
00686313C  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006863140  cbz      x0, #0x686333c
006863144  ldrb     w8, [x22, #0x4c9]
006863148  mov      x29, x0
00686314C  cbnz     w8, #0x6863160
006863150  mov      x0, x26
006863154  bl       #0x382bd14 ; 
006863158  mov      w8, #1
00686315C  strb     w8, [x22, #0x4c9]
006863160  ldr      x1, [x26]
006863164  ldrb     w8, [x1, #0x53]
006863168  tbnz     w8, #5, #0x6863178
00686316C  ldr      x0, [x29, #0x98]
006863170  cbnz     x0, #0x6863188
006863174  b        #0x6863248 ; 
006863178  ldr      x8, [x1, #0x60]
00686317C  mov      x0, x29
006863180  blr      x8
006863184  cbz      x0, #0x6863248
006863188  mov      x20, xzr
00686318C  ldrb     w8, [x22, #0x4c9]
006863190  cbnz     w8, #0x68631a4
006863194  mov      x0, x26
006863198  bl       #0x382bd14 ; 
00686319C  mov      w8, #1
0068631A0  strb     w8, [x22, #0x4c9]
0068631A4  ldr      x1, [x26]
0068631A8  ldrb     w8, [x1, #0x53]
0068631AC  tbnz     w8, #5, #0x68631b8
0068631B0  ldr      x0, [x29, #0x98]
0068631B4  b        #0x68631c4 ; 
0068631B8  ldr      x8, [x1, #0x60]
0068631BC  mov      x0, x29
0068631C0  blr      x8
0068631C4  cbz      x0, #0x686333c
0068631C8  ldrsw    x8, [x0, #0x18]
0068631CC  cmp      x20, x8
0068631D0  b.ge     #0x6863248
0068631D4  ldrb     w8, [x22, #0x4c9]
0068631D8  cbnz     w8, #0x68631ec
0068631DC  mov      x0, x26
0068631E0  bl       #0x382bd14 ; 
0068631E4  mov      w8, #1
0068631E8  strb     w8, [x22, #0x4c9]
0068631EC  ldr      x1, [x26]
0068631F0  ldrb     w8, [x1, #0x53]
0068631F4  tbnz     w8, #5, #0x6863200
0068631F8  ldr      x0, [x29, #0x98]
0068631FC  b        #0x686320c ; 
006863200  ldr      x8, [x1, #0x60]
006863204  mov      x0, x29
006863208  blr      x8
00686320C  cbz      x0, #0x686333c
006863210  ldr      w8, [x0, #0x18]
006863214  cmp      x20, x8
006863218  b.hs     #0x68633d0
00686321C  cbz      x19, #0x686333c
006863220  add      x8, x0, x20, lsl #2
006863224  ldr      w1, [x8, #0x20]
006863228  adrp     x8, #0x8f08000
00686322C  ldr      x8, [x8, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
006863230  mov      x0, x19
006863234  ldr      x2, [x8]
006863238  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
00686323C  add      x20, x20, #1
006863240  tbnz     w0, #0, #0x686318c
006863244  b        #0x68630cc ; 
006863248  mov      x0, x21
00686324C  mov      x1, x27
006863250  bl       #0x6863690 ; HotFix.BattleLogic.HeroSkillCreator$$GetEffectiveWeight
006863254  ldr      x8, [x21]
006863258  ldr      x1, [x21, #0x98]
00686325C  mov      w3, w0
006863260  mov      x0, x21
006863264  ldr      x9, [x8, #0x228]
006863268  ldr      x5, [x8, #0x230]
00686326C  mov      w2, w28
006863270  mov      x4, x19
006863274  blr      x9
006863278  b        #0x68630cc ; 
00686327C  ldr      x0, [x21, #0x98]
006863280  cbz      x0, #0x686333c
006863284  ldr      x1, [sp, #8]
006863288  mov      x2, xzr
00686328C  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
006863290  cmp      w0, #1
006863294  b.lt     #0x6863318
006863298  adrp     x8, #0x8ebf000
00686329C  ldr      x8, [x8, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
0068632A0  mov      w23, w0
0068632A4  ldr      x0, [x8]
0068632A8  ldr      w8, [x0, #0xe0]
0068632AC  cbnz     w8, #0x68632b4
0068632B0  bl       #0x382be8c ; 
0068632B4  mov      w1, #2
0068632B8  mov      w0, w23
0068632BC  mov      x2, xzr
0068632C0  bl       #0x7bd69a0 ; System.Math$$Min
0068632C4  ldr      x8, [x21, #0x98]
0068632C8  cbz      x8, #0x686333c
0068632CC  ldr      x20, [sp, #8]
0068632D0  mov      w23, w0
0068632D4  mov      x0, x8
0068632D8  mov      x2, xzr
0068632DC  mov      x1, x20
0068632E0  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
0068632E4  mov      w1, w0
0068632E8  mov      w0, w23
0068632EC  mov      x2, xzr
0068632F0  bl       #0x7bd69a0 ; System.Math$$Min
0068632F4  ldr      x8, [x21, #0x98]
0068632F8  cbz      x8, #0x686333c
0068632FC  ldr      x4, [sp, #0x10]
006863300  mov      w1, w0
006863304  mov      x0, x8
006863308  mov      x2, x20
00686330C  mov      x3, x19
006863310  mov      x5, xzr
006863314  bl       #0x6633c0c ; HotFix.BattleLogic.WeightRandom$$GetRandomCount
006863318  mov      w0, #1
00686331C  ldp      x20, x19, [sp, #0x70]
006863320  ldp      x22, x21, [sp, #0x60]
006863324  ldp      x24, x23, [sp, #0x50]
006863328  ldp      x26, x25, [sp, #0x40]
00686332C  ldp      x28, x27, [sp, #0x30]
006863330  ldp      x29, x30, [sp, #0x20]
006863334  add      sp, sp, #0x80
006863338  ret      
00686333C  bl       #0x382bfb8 ; 
006863340  ldr      w8, [x24, #0x18]
006863344  cmp      x25, x8
006863348  b.hs     #0x68633d0
00686334C  adrp     x9, #0x8ebf000
006863350  ldr      w8, [x20]
006863354  ldr      x9, [x9, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006863358  add      x1, sp, #0x1c
00686335C  str      w8, [sp, #0x1c]
006863360  ldr      x0, [x9]
006863364  bl       #0x382be94 ; 
006863368  adrp     x8, #0x8f23000
00686336C  ldr      x8, [x8, #0xd30] ; GLOBAL -[OpenSelectSpecialSkill] UpgradeSurvivor表技能id不存在! UpgradeSurvivorId={0} @ 0x92eab78
006863370  mov      x1, x0
006863374  mov      x2, xzr
006863378  ldr      x8, [x8]
00686337C  mov      x0, x8
006863380  bl       #0x79d140c ; System.String$$Format
006863384  adrp     x8, #0x8ee1000
006863388  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
00686338C  mov      x19, x0
006863390  ldr      x8, [x8]
006863394  ldr      w9, [x8, #0xe0]
006863398  cbnz     w9, #0x68633a4
00686339C  mov      x0, x8
0068633A0  bl       #0x382be8c ; 
0068633A4  adrp     x8, #0x8f23000
0068633A8  adrp     x9, #0x8f23000
0068633AC  ldr      x8, [x8, #0xd28] ; GLOBAL OpenSelectSpecialSkill @ 0x93082a0
0068633B0  ldr      x9, [x9, #0xc80] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\DankeSkillCreator.cs @ 0x92f8028
0068633B4  mov      w3, #0x24b
0068633B8  mov      x0, x19
0068633BC  ldr      x1, [x8]
0068633C0  ldr      x2, [x9]
0068633C4  mov      x4, xzr
0068633C8  bl       #0x7997754 ; Logger$$LogError
0068633CC  bl       #0x382bfb8 ; 
0068633D0  bl       #0x382bfc0 ; 

