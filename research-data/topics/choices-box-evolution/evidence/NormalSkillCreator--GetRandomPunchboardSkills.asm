; HotFix.BattleLogic.NormalSkillCreator$$GetRandomPunchboardSkills
; RVA 0x687378C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00687378C  sub      sp, sp, #0xa0
006873790  stp      x29, x30, [sp, #0x40]
006873794  stp      x28, x27, [sp, #0x50]
006873798  stp      x26, x25, [sp, #0x60]
00687379C  stp      x24, x23, [sp, #0x70]
0068737A0  stp      x22, x21, [sp, #0x80]
0068737A4  stp      x20, x19, [sp, #0x90]
0068737A8  ldr      x9, [sp, #0xa0]
0068737AC  stp      w6, w7, [sp, #0x30]
0068737B0  str      x5, [sp, #0x38]
0068737B4  str      w4, [sp, #0x18]
0068737B8  adrp     x19, #0x959b000
0068737BC  stp      x1, x9, [sp, #0x20]
0068737C0  adrp     x22, #0x8f24000
0068737C4  ldrb     w8, [x19, #0xa9b]
0068737C8  ldr      x22, [x22, #0x470] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.GetRandomPunchboardSkills() @ 0x9295e90
0068737CC  mov      x21, x3
0068737D0  mov      x26, x2
0068737D4  mov      x20, x0
0068737D8  tbnz     w8, #0, #0x6873844
0068737DC  adrp     x0, #0x8f07000
0068737E0  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0068737E4  bl       #0x382bd14 ; 
0068737E8  adrp     x0, #0x8ec2000
0068737EC  ldr      x0, [x0, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
0068737F0  bl       #0x382bd14 ; 
0068737F4  adrp     x0, #0x8ec2000
0068737F8  ldr      x0, [x0, #0x240] ; GLOBAL Method$System.Collections.Generic.List<int>.Clear() @ 0x921de58
0068737FC  bl       #0x382bd14 ; 
006873800  adrp     x0, #0x8ed2000
006873804  ldr      x0, [x0, #0xdd8] ; GLOBAL Method$System.Collections.Generic.List<int>.RemoveAt() @ 0x921de98
006873808  bl       #0x382bd14 ; 
00687380C  adrp     x0, #0x8ec2000
006873810  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
006873814  bl       #0x382bd14 ; 
006873818  adrp     x0, #0x8ec2000
00687381C  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006873820  bl       #0x382bd14 ; 
006873824  adrp     x0, #0x8f24000
006873828  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.GetRandomPunchboardSkills() @ 0x9295e90
00687382C  bl       #0x382bd14 ; 
006873830  adrp     x0, #0x8f08000
006873834  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006873838  bl       #0x382bd14 ; 
00687383C  mov      w8, #1
006873840  strb     w8, [x19, #0xa9b]
006873844  ldr      x8, [x22]
006873848  ldrb     w9, [x8, #0x53]
00687384C  tbnz     w9, #5, #0x68738e8
006873850  ldr      x9, [sp, #0x20]
006873854  cbz      x9, #0x6873e3c
006873858  ldr      w8, [x9, #0x1c]
00687385C  add      w8, w8, #1
006873860  stp      wzr, w8, [x9, #0x18]
006873864  cbz      x26, #0x6873e3c
006873868  ldr      w8, [x26, #0x1c]
00687386C  add      w8, w8, #1
006873870  stp      wzr, w8, [x26, #0x18]
006873874  cbz      x21, #0x6873e3c
006873878  ldr      w8, [x21, #0x1c]
00687387C  ldr      x22, [sp, #0x20]
006873880  add      w8, w8, #1
006873884  stp      wzr, w8, [x21, #0x18]
006873888  ldr      x3, [x20, #0x28]
00687388C  ldr      w21, [sp, #0x18]
006873890  cbz      x3, #0x6873e3c
006873894  mov      w19, #4
006873898  ldr      w8, [x3, #0x18]
00687389C  sub      x9, x19, #4
0068738A0  cmp      w9, w8
0068738A4  b.ge     #0x687393c
0068738A8  ldr      x10, [x20, #0x48]
0068738AC  cbz      x10, #0x6873e3c
0068738B0  ldr      w11, [x10, #0x18]
0068738B4  cmp      w9, w11
0068738B8  b.hs     #0x6873e40
0068738BC  cmp      w9, w8
0068738C0  b.hs     #0x6873e40
0068738C4  ldr      x0, [x10, x19, lsl #3]
0068738C8  cbz      x0, #0x6873e3c
0068738CC  ldr      x1, [x3, x19, lsl #3]
0068738D0  mov      x2, xzr
0068738D4  bl       #0x6635a1c ; HotFix.BattleLogic.WeightRandom$$CopyWeightRandom
0068738D8  ldr      x3, [x20, #0x28]
0068738DC  add      x19, x19, #1
0068738E0  cbnz     x3, #0x6873898
0068738E4  b        #0x6873e3c ; 
0068738E8  ldr      x9, [x8, #0x60]
0068738EC  str      x8, [sp, #0xa8]
0068738F0  ldr      w8, [sp, #0x30]
0068738F4  mov      x0, x20
0068738F8  mov      x2, x26
0068738FC  mov      x3, x21
006873900  and      w6, w8, #1
006873904  ldr      w8, [sp, #0x34]
006873908  ldr      w4, [sp, #0x18]
00687390C  ldr      x5, [sp, #0x38]
006873910  ldp      x20, x19, [sp, #0x90]
006873914  and      w7, w8, #1
006873918  ldp      x1, x8, [sp, #0x20]
00687391C  ldp      x22, x21, [sp, #0x80]
006873920  ldp      x24, x23, [sp, #0x70]
006873924  ldp      x26, x25, [sp, #0x60]
006873928  ldp      x28, x27, [sp, #0x50]
00687392C  ldp      x29, x30, [sp, #0x40]
006873930  str      x8, [sp, #0xa0]
006873934  add      sp, sp, #0xa0
006873938  br       x9
00687393C  cmp      w21, #1
006873940  b.lt     #0x6873b30
006873944  adrp     x29, #0x8f23000
006873948  adrp     x28, #0x8f24000
00687394C  ldr      x29, [x29, #0x90] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillFlag() @ 0x92ac538
006873950  ldr      x28, [x28, #0x68] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_RejectFlag() @ 0x92ac520
006873954  mov      w19, wzr
006873958  mov      w23, wzr
00687395C  add      x26, x20, #0x60
006873960  mov      w24, #1
006873964  adrp     x25, #0x959b000
006873968  adrp     x27, #0x959b000
00687396C  str      x26, [sp, #0x10]
006873970  ldp      w9, w8, [sp, #0x30]
006873974  ldr      x2, [sp, #0x28]
006873978  ldr      x6, [sp, #0x38]
00687397C  mov      w4, #1
006873980  and      w8, w8, #1
006873984  and      w7, w9, #1
006873988  mov      x0, x20
00687398C  mov      x1, x22
006873990  mov      x5, x26
006873994  strb     w8, [sp]
006873998  bl       #0x685b9c4 ; HotFix.BattleLogic.HeroSkillCreator$$GetRandomSkills
00687399C  ldr      w8, [x22, #0x18]
0068739A0  cmp      w8, w19
0068739A4  b.le     #0x6873b1c
0068739A8  mov      x0, x20
0068739AC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068739B0  cbz      x0, #0x6873e3c
0068739B4  adrp     x8, #0x9598000
0068739B8  ldrb     w8, [x8, #0xfcc]
0068739BC  mov      x21, x0
0068739C0  cbnz     w8, #0x68739d8
0068739C4  adrp     x0, #0x8f06000
0068739C8  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068739CC  bl       #0x382bd14 ; 
0068739D0  adrp     x8, #0x9598000
0068739D4  strb     w24, [x8, #0xfcc]
0068739D8  adrp     x8, #0x8f06000
0068739DC  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068739E0  ldr      x1, [x8]
0068739E4  ldrb     w8, [x1, #0x53]
0068739E8  tbnz     w8, #5, #0x68739f4
0068739EC  ldr      x21, [x21, #0x200]
0068739F0  b        #0x6873a04 ; 
0068739F4  ldr      x8, [x1, #0x60]
0068739F8  mov      x0, x21
0068739FC  blr      x8
006873A00  mov      x21, x0
006873A04  adrp     x8, #0x8ec2000
006873A08  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006873A0C  mov      x0, x22
006873A10  mov      w1, w19
006873A14  ldr      x2, [x8]
006873A18  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006873A1C  cbz      x21, #0x6873e3c
006873A20  mov      w1, w0
006873A24  mov      x0, x21
006873A28  mov      x2, xzr
006873A2C  str      w19, [sp, #0x1c]
006873A30  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006873A34  cbz      x0, #0x6873e3c
006873A38  mov      x21, x0
006873A3C  mov      w26, wzr
006873A40  ldrb     w8, [x25, #0x9b4]
006873A44  cbnz     w8, #0x6873a54
006873A48  mov      x0, x29
006873A4C  bl       #0x382bd14 ; 
006873A50  strb     w24, [x25, #0x9b4]
006873A54  ldr      x1, [x29]
006873A58  ldrb     w8, [x1, #0x53]
006873A5C  tbnz     w8, #5, #0x6873a68
006873A60  ldr      x0, [x21, #0x170]
006873A64  b        #0x6873a74 ; 
006873A68  ldr      x8, [x1, #0x60]
006873A6C  mov      x0, x21
006873A70  blr      x8
006873A74  cbz      x0, #0x6873e3c
006873A78  ldr      w8, [x0, #0x18]
006873A7C  cmp      w26, w8
006873A80  b.ge     #0x6873b0c
006873A84  ldr      x8, [x20, #0x28]
006873A88  cbz      x8, #0x6873e3c
006873A8C  mov      x19, xzr
006873A90  ldr      w9, [x8, #0x18]
006873A94  cmp      w19, w9
006873A98  b.ge     #0x6873b04
006873A9C  cmp      w19, w9
006873AA0  b.hs     #0x6873e40
006873AA4  add      x8, x8, x19, lsl #3
006873AA8  ldrb     w9, [x27, #0xbad]
006873AAC  ldr      x22, [x8, #0x20]
006873AB0  cbnz     w9, #0x6873ac0
006873AB4  mov      x0, x28
006873AB8  bl       #0x382bd14 ; 
006873ABC  strb     w24, [x27, #0xbad]
006873AC0  ldr      x1, [x28]
006873AC4  ldrb     w8, [x1, #0x53]
006873AC8  tbnz     w8, #5, #0x6873ad4
006873ACC  ldr      w1, [x21, #0x17c]
006873AD0  b        #0x6873ae4 ; 
006873AD4  ldr      x8, [x1, #0x60]
006873AD8  mov      x0, x21
006873ADC  blr      x8
006873AE0  mov      w1, w0
006873AE4  cbz      x22, #0x6873e3c
006873AE8  mov      x0, x22
006873AEC  mov      x2, xzr
006873AF0  bl       #0x66332b0 ; HotFix.BattleLogic.WeightRandom$$OnAddRejectFlag
006873AF4  ldr      x8, [x20, #0x28]
006873AF8  add      x19, x19, #1
006873AFC  cbnz     x8, #0x6873a90
006873B00  b        #0x6873e3c ; 
006873B04  add      w26, w26, #1
006873B08  b        #0x6873a40 ; 
006873B0C  ldp      w21, w19, [sp, #0x18]
006873B10  ldr      x22, [sp, #0x20]
006873B14  ldr      x26, [sp, #0x10]
006873B18  add      w19, w19, #1
006873B1C  add      w23, w23, #1
006873B20  cmp      w23, w21
006873B24  b.eq     #0x6873b30
006873B28  ldr      x3, [x20, #0x28]
006873B2C  b        #0x6873970 ; 
006873B30  ldr      w8, [x22, #0x18]
006873B34  cmp      w8, w21
006873B38  b.ge     #0x6873e18
006873B3C  mov      x0, x20
006873B40  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006873B44  cbz      x0, #0x6873e3c
006873B48  adrp     x19, #0x9591000
006873B4C  ldrb     w8, [x19, #0xa90]
006873B50  mov      x21, x0
006873B54  cbnz     w8, #0x6873b6c
006873B58  adrp     x0, #0x8ee6000
006873B5C  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006873B60  bl       #0x382bd14 ; 
006873B64  mov      w8, #1
006873B68  strb     w8, [x19, #0xa90]
006873B6C  adrp     x8, #0x8ee6000
006873B70  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006873B74  ldr      x1, [x8]
006873B78  ldrb     w8, [x1, #0x53]
006873B7C  tbnz     w8, #5, #0x6873b88
006873B80  ldr      x0, [x21, #0x230]
006873B84  b        #0x6873b94 ; 
006873B88  ldr      x8, [x1, #0x60]
006873B8C  mov      x0, x21
006873B90  blr      x8
006873B94  ldr      x26, [sp, #0x20]
006873B98  cbz      x0, #0x6873e3c
006873B9C  adrp     x8, #0x8f08000
006873BA0  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006873BA4  ldr      x1, [x8]
006873BA8  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006873BAC  ldr      x8, [x20, #0x58]
006873BB0  cbz      x8, #0x6873e3c
006873BB4  adrp     x9, #0x8f07000
006873BB8  ldr      x9, [x9, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
006873BBC  mov      x22, x0
006873BC0  mov      x0, x8
006873BC4  ldr      x1, [x9]
006873BC8  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
006873BCC  ldr      w8, [x26, #0x18]
006873BD0  cmp      w8, #1
006873BD4  b.lt     #0x6873c9c
006873BD8  adrp     x24, #0x8ec2000
006873BDC  adrp     x25, #0x8ec2000
006873BE0  ldr      x24, [x24, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006873BE4  ldr      x25, [x25, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
006873BE8  mov      x21, x0
006873BEC  mov      w23, wzr
006873BF0  ldr      x2, [x24]
006873BF4  mov      x0, x26
006873BF8  mov      w1, w23
006873BFC  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006873C00  cbz      x21, #0x6873e3c
006873C04  mov      w1, w0
006873C08  mov      x0, x21
006873C0C  bl       #0x686ed1c ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetSkillRemainCount
006873C10  sub      w19, w0, #1
006873C14  cmp      w19, #1
006873C18  b.lt     #0x6873c8c
006873C1C  ldr      x2, [x24]
006873C20  mov      x0, x26
006873C24  mov      w1, w23
006873C28  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006873C2C  cbz      x22, #0x6873e3c
006873C30  ldr      w10, [x22, #0x1c]
006873C34  ldr      x8, [x22, #0x10]
006873C38  ldr      x9, [x25]
006873C3C  add      w10, w10, #1
006873C40  str      w10, [x22, #0x1c]
006873C44  cbz      x8, #0x6873e3c
006873C48  ldrsw    x10, [x22, #0x18]
006873C4C  ldr      w11, [x8, #0x18]
006873C50  mov      w1, w0
006873C54  cmp      w10, w11
006873C58  b.hs     #0x6873c70
006873C5C  add      w9, w10, #1
006873C60  add      x8, x8, x10, lsl #2
006873C64  str      w9, [x22, #0x18]
006873C68  str      w1, [x8, #0x20]
006873C6C  b        #0x6873c84 ; 
006873C70  ldr      x8, [x9, #0x20]
006873C74  mov      x0, x22
006873C78  ldr      x8, [x8, #0xc0]
006873C7C  ldr      x2, [x8, #0x70]
006873C80  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006873C84  subs     w19, w19, #1
006873C88  b.ne     #0x6873c1c
006873C8C  ldr      w8, [x26, #0x18]
006873C90  add      w23, w23, #1
006873C94  cmp      w23, w8
006873C98  b.lt     #0x6873bf0
006873C9C  ldr      w9, [sp, #0x18]
006873CA0  sub      w26, w9, w8
006873CA4  cmp      w26, #1
006873CA8  b.lt     #0x6873e18
006873CAC  cbz      x22, #0x6873e3c
006873CB0  adrp     x21, #0x8f0d000
006873CB4  adrp     x28, #0x8ec2000
006873CB8  adrp     x29, #0x8ec2000
006873CBC  adrp     x23, #0x8ed2000
006873CC0  ldr      x21, [x21, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
006873CC4  ldr      x28, [x28, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006873CC8  ldr      x29, [x29, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
006873CCC  ldr      x23, [x23, #0xdd8] ; GLOBAL Method$System.Collections.Generic.List<int>.RemoveAt() @ 0x921de98
006873CD0  adrp     x27, #0x9599000
006873CD4  mov      w19, #1
006873CD8  ldr      w24, [x22, #0x18]
006873CDC  cmp      w24, #1
006873CE0  b.lt     #0x6873e10
006873CE4  mov      x0, x20
006873CE8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006873CEC  cbz      x0, #0x6873e3c
006873CF0  ldrb     w8, [x27, #0xac6]
006873CF4  mov      x25, x0
006873CF8  cbnz     w8, #0x6873d08
006873CFC  mov      x0, x21
006873D00  bl       #0x382bd14 ; 
006873D04  strb     w19, [x27, #0xac6]
006873D08  ldr      x3, [x21]
006873D0C  ldrb     w8, [x3, #0x53]
006873D10  tbnz     w8, #5, #0x6873d50
006873D14  adrp     x8, #0x9599000
006873D18  ldrb     w8, [x8, #0xac7]
006873D1C  cbnz     w8, #0x6873d34
006873D20  adrp     x0, #0x8f0d000
006873D24  ldr      x0, [x0, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
006873D28  bl       #0x382bd14 ; 
006873D2C  adrp     x8, #0x9599000
006873D30  strb     w19, [x8, #0xac7]
006873D34  adrp     x8, #0x8f0d000
006873D38  ldr      x8, [x8, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
006873D3C  ldr      x1, [x8]
006873D40  ldrb     w8, [x1, #0x53]
006873D44  tbnz     w8, #5, #0x6873d6c
006873D48  ldr      x0, [x25, #0x260]
006873D4C  b        #0x6873d78 ; 
006873D50  ldr      x8, [x3, #0x60]
006873D54  mov      x0, x25
006873D58  mov      w1, wzr
006873D5C  mov      w2, w24
006873D60  blr      x8
006873D64  mov      w24, w0
006873D68  b        #0x6873d9c ; 
006873D6C  ldr      x8, [x1, #0x60]
006873D70  mov      x0, x25
006873D74  blr      x8
006873D78  cbz      x0, #0x6873e3c
006873D7C  mov      w1, wzr
006873D80  mov      w2, w24
006873D84  mov      x3, xzr
006873D88  bl       #0x416d068 ; XXRandom$$Next
006873D8C  ldr      w8, [x25, #0x32c]
006873D90  mov      w24, w0
006873D94  add      w8, w8, #1
006873D98  str      w8, [x25, #0x32c]
006873D9C  ldr      x2, [x28]
006873DA0  mov      x0, x22
006873DA4  mov      w1, w24
006873DA8  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006873DAC  mov      w1, w0
006873DB0  ldr      x0, [sp, #0x20]
006873DB4  ldr      x9, [x29]
006873DB8  ldr      w10, [x0, #0x1c]
006873DBC  ldr      x8, [x0, #0x10]
006873DC0  add      w10, w10, #1
006873DC4  str      w10, [x0, #0x1c]
006873DC8  cbz      x8, #0x6873e3c
006873DCC  ldrsw    x10, [x0, #0x18]
006873DD0  ldr      w11, [x8, #0x18]
006873DD4  cmp      w10, w11
006873DD8  b.hs     #0x6873df0
006873DDC  add      w9, w10, #1
006873DE0  add      x8, x8, x10, lsl #2
006873DE4  str      w9, [x0, #0x18]
006873DE8  str      w1, [x8, #0x20]
006873DEC  b        #0x6873e00 ; 
006873DF0  ldr      x8, [x9, #0x20]
006873DF4  ldr      x8, [x8, #0xc0]
006873DF8  ldr      x2, [x8, #0x70]
006873DFC  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006873E00  ldr      x2, [x23]
006873E04  mov      x0, x22
006873E08  mov      w1, w24
006873E0C  bl       #0x4d6603c ; System.Collections.Generic.List<int>$$RemoveAt
006873E10  subs     w26, w26, #1
006873E14  b.ne     #0x6873cd8
006873E18  ldp      x20, x19, [sp, #0x90]
006873E1C  ldp      x22, x21, [sp, #0x80]
006873E20  ldp      x24, x23, [sp, #0x70]
006873E24  ldp      x26, x25, [sp, #0x60]
006873E28  ldp      x28, x27, [sp, #0x50]
006873E2C  ldp      x29, x30, [sp, #0x40]
006873E30  mov      x0, xzr
006873E34  add      sp, sp, #0xa0
006873E38  ret      
006873E3C  bl       #0x382bfb8 ; 
006873E40  bl       #0x382bfc0 ; 

