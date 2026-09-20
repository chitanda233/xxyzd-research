; HotFix.BattleLogic.PlayerPunchboard$$Show
; RVA 0x659F4C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659F4C8  sub      sp, sp, #0x90
00659F4CC  stp      x29, x30, [sp, #0x30]
00659F4D0  stp      x28, x27, [sp, #0x40]
00659F4D4  stp      x26, x25, [sp, #0x50]
00659F4D8  stp      x24, x23, [sp, #0x60]
00659F4DC  stp      x22, x21, [sp, #0x70]
00659F4E0  stp      x20, x19, [sp, #0x80]
00659F4E4  adrp     x20, #0x9599000
00659F4E8  adrp     x21, #0x8f09000
00659F4EC  ldrb     w8, [x20, #0x360]
00659F4F0  ldr      x21, [x21, #0x80] ; GLOBAL Method$HotFix.BattleLogic.PlayerPunchboard.Show() @ 0x929a350
00659F4F4  mov      w23, w2
00659F4F8  mov      w22, w1
00659F4FC  mov      x19, x0
00659F500  tbnz     w8, #0, #0x659f608
00659F504  adrp     x0, #0x8f09000
00659F508  ldr      x0, [x0, #0x88] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<ShowPunchboadEvent>() @ 0x923f480
00659F50C  bl       #0x382bd14 ; 
00659F510  adrp     x0, #0x8ee8000
00659F514  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00659F518  bl       #0x382bd14 ; 
00659F51C  adrp     x0, #0x8f07000
00659F520  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
00659F524  bl       #0x382bd14 ; 
00659F528  adrp     x0, #0x8ee6000
00659F52C  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00659F530  bl       #0x382bd14 ; 
00659F534  adrp     x0, #0x8f09000
00659F538  ldr      x0, [x0, #0x90] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<ShowPunchboadEvent>() @ 0x9284938
00659F53C  bl       #0x382bd14 ; 
00659F540  adrp     x0, #0x8ec1000
00659F544  ldr      x0, [x0, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
00659F548  bl       #0x382bd14 ; 
00659F54C  adrp     x0, #0x8f08000
00659F550  ldr      x0, [x0, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
00659F554  bl       #0x382bd14 ; 
00659F558  adrp     x0, #0x8f09000
00659F55C  ldr      x0, [x0, #0x98] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Add() @ 0x921f528
00659F560  bl       #0x382bd14 ; 
00659F564  adrp     x0, #0x8f09000
00659F568  ldr      x0, [x0, #0x68] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Clear() @ 0x921f538
00659F56C  bl       #0x382bd14 ; 
00659F570  adrp     x0, #0x8ed2000
00659F574  ldr      x0, [x0, #0xdd8] ; GLOBAL Method$System.Collections.Generic.List<int>.RemoveAt() @ 0x921de98
00659F578  bl       #0x382bd14 ; 
00659F57C  adrp     x0, #0x8f09000
00659F580  ldr      x0, [x0, #0x70] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>..ctor() @ 0x921f520
00659F584  bl       #0x382bd14 ; 
00659F588  adrp     x0, #0x8f09000
00659F58C  ldr      x0, [x0, #0xa0] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Count() @ 0x921f560
00659F590  bl       #0x382bd14 ; 
00659F594  adrp     x0, #0x8ec2000
00659F598  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
00659F59C  bl       #0x382bd14 ; 
00659F5A0  adrp     x0, #0x8f09000
00659F5A4  ldr      x0, [x0, #0xa8] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Item() @ 0x921f568
00659F5A8  bl       #0x382bd14 ; 
00659F5AC  adrp     x0, #0x8ec2000
00659F5B0  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00659F5B4  bl       #0x382bd14 ; 
00659F5B8  adrp     x0, #0x8f09000
00659F5BC  ldr      x0, [x0, #0x78] ; GLOBAL System.Collections.Generic.List<PunchboardSkillRandomData>_TypeInfo @ 0x91da4e8
00659F5C0  bl       #0x382bd14 ; 
00659F5C4  adrp     x0, #0x8f09000
00659F5C8  ldr      x0, [x0, #0xb0] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, List<int>>.get_Item() @ 0x92286b0
00659F5CC  bl       #0x382bd14 ; 
00659F5D0  adrp     x0, #0x8f09000
00659F5D4  ldr      x0, [x0, #0x80] ; GLOBAL Method$HotFix.BattleLogic.PlayerPunchboard.Show() @ 0x929a350
00659F5D8  bl       #0x382bd14 ; 
00659F5DC  adrp     x0, #0x8f09000
00659F5E0  ldr      x0, [x0, #0xb8] ; GLOBAL Method$HotFix.BattleLogic.PlayerPunchboard.ShuffleList<PunchboardSkillRandomData>() @ 0x929a2e8
00659F5E4  bl       #0x382bd14 ; 
00659F5E8  adrp     x0, #0x8f08000
00659F5EC  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
00659F5F0  bl       #0x382bd14 ; 
00659F5F4  adrp     x0, #0x8f08000
00659F5F8  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
00659F5FC  bl       #0x382bd14 ; 
00659F600  mov      w8, #1
00659F604  strb     w8, [x20, #0x360]
00659F608  ldr      x3, [x21]
00659F60C  ldrb     w8, [x3, #0x53]
00659F610  tbnz     w8, #5, #0x659f674
00659F614  ldr      x0, [x19, #0x10]
00659F618  cbz      x0, #0x659fa30
00659F61C  adrp     x8, #0x8f07000
00659F620  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
00659F624  ldr      x1, [x8]
00659F628  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00659F62C  cbz      x0, #0x659fa30
00659F630  adrp     x20, #0x9599000
00659F634  ldrb     w8, [x20, #0x4c6]
00659F638  mov      x27, x0
00659F63C  cbnz     w8, #0x659f654
00659F640  adrp     x0, #0x8f09000
00659F644  ldr      x0, [x0, #0xc0] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_SkillCreator() @ 0x927fb18
00659F648  bl       #0x382bd14 ; 
00659F64C  mov      w8, #1
00659F650  strb     w8, [x20, #0x4c6]
00659F654  adrp     x8, #0x8f09000
00659F658  ldr      x8, [x8, #0xc0] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_SkillCreator() @ 0x927fb18
00659F65C  str      w22, [sp, #0x2c]
00659F660  ldr      x1, [x8]
00659F664  ldrb     w8, [x1, #0x53]
00659F668  tbnz     w8, #5, #0x659f6a4
00659F66C  ldr      x20, [x27, #0x88]
00659F670  b        #0x659f6b4 ; 
00659F674  ldr      x4, [x3, #0x60]
00659F678  and      w2, w23, #1
00659F67C  mov      x0, x19
00659F680  mov      w1, w22
00659F684  ldp      x20, x19, [sp, #0x80]
00659F688  ldp      x22, x21, [sp, #0x70]
00659F68C  ldp      x24, x23, [sp, #0x60]
00659F690  ldp      x26, x25, [sp, #0x50]
00659F694  ldp      x28, x27, [sp, #0x40]
00659F698  ldp      x29, x30, [sp, #0x30]
00659F69C  add      sp, sp, #0x90
00659F6A0  br       x4
00659F6A4  ldr      x8, [x1, #0x60]
00659F6A8  mov      x0, x27
00659F6AC  blr      x8
00659F6B0  mov      x20, x0
00659F6B4  adrp     x8, #0x8ee8000
00659F6B8  ldr      x8, [x8, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00659F6BC  ldp      x24, x22, [x19, #0x20]
00659F6C0  ldr      x25, [x19, #0x30]
00659F6C4  ldr      x0, [x8]
00659F6C8  ldr      w8, [x0, #0xe0]
00659F6CC  cbnz     w8, #0x659f6d4
00659F6D0  bl       #0x382be8c ; 
00659F6D4  mov      x0, xzr
00659F6D8  bl       #0x64cb688 ; LocalModels.Const$$GetDankeSkillWeight
00659F6DC  adrp     x8, #0x9599000
00659F6E0  ldrb     w8, [x8, #0x4c7]
00659F6E4  mov      x26, x0
00659F6E8  cbnz     w8, #0x659f704
00659F6EC  adrp     x0, #0x8f09000
00659F6F0  ldr      x0, [x0, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
00659F6F4  bl       #0x382bd14 ; 
00659F6F8  mov      w8, #1
00659F6FC  adrp     x9, #0x9599000
00659F700  strb     w8, [x9, #0x4c7]
00659F704  adrp     x8, #0x8f09000
00659F708  ldr      x8, [x8, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
00659F70C  ldr      x1, [x8]
00659F710  ldrb     w8, [x1, #0x53]
00659F714  tbnz     w8, #5, #0x659f720
00659F718  ldr      x0, [x27, #0x58]
00659F71C  b        #0x659f72c ; 
00659F720  ldr      x8, [x1, #0x60]
00659F724  mov      x0, x27
00659F728  blr      x8
00659F72C  cbz      x20, #0x659fa30
00659F730  ldr      x8, [x20]
00659F734  mov      w4, #0x10
00659F738  mov      x1, x24
00659F73C  mov      x2, x22
00659F740  ldr      x9, [x8, #0x2c8]
00659F744  ldr      x8, [x8, #0x2d0]
00659F748  mov      x3, x25
00659F74C  mov      x5, x26
00659F750  mov      w6, wzr
00659F754  stp      x0, x8, [sp]
00659F758  mov      x0, x20
00659F75C  mov      w7, wzr
00659F760  blr      x9
00659F764  ldr      x20, [x19, #0x10]
00659F768  cbz      x20, #0x659fa30
00659F76C  adrp     x21, #0x9599000
00659F770  ldrb     w8, [x21, #0x4b0]
00659F774  mov      x22, x0
00659F778  cbnz     w8, #0x659f790
00659F77C  adrp     x0, #0x8f08000
00659F780  ldr      x0, [x0, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
00659F784  bl       #0x382bd14 ; 
00659F788  mov      w8, #1
00659F78C  strb     w8, [x21, #0x4b0]
00659F790  adrp     x8, #0x8f08000
00659F794  ldr      x8, [x8, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
00659F798  ldr      x2, [x8]
00659F79C  ldrb     w8, [x2, #0x53]
00659F7A0  tbnz     w8, #5, #0x659f7b0
00659F7A4  mov      w8, #1
00659F7A8  strb     w8, [x20, #0x648]
00659F7AC  b        #0x659f7c0 ; 
00659F7B0  ldr      x8, [x2, #0x60]
00659F7B4  mov      w1, #1
00659F7B8  mov      x0, x20
00659F7BC  blr      x8
00659F7C0  ldr      x0, [x19, #0x38]
00659F7C4  str      x27, [sp, #0x10]
00659F7C8  cbz      x0, #0x659fa30
00659F7CC  adrp     x8, #0x8f08000
00659F7D0  ldr      x1, [x19, #0x20]
00659F7D4  ldr      x8, [x8, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
00659F7D8  ldr      x2, [x8]
00659F7DC  bl       #0x4d64760 ; System.Collections.Generic.List<int>$$AddRange
00659F7E0  mov      x0, x19
00659F7E4  mov      x1, x22
00659F7E8  mov      w2, wzr
00659F7EC  mov      x3, xzr
00659F7F0  str      x22, [sp, #0x20]
00659F7F4  bl       #0x65a3264 ; HotFix.BattleLogic.PlayerPunchboard$$GetSkillGroup2Skills
00659F7F8  ldr      x8, [x19, #0x20]
00659F7FC  cbz      x8, #0x659fa30
00659F800  and      w9, w23, #1
00659F804  str      w9, [sp, #0x1c]
00659F808  adrp     x23, #0x8f06000
00659F80C  adrp     x26, #0x8ef9000
00659F810  ldr      x23, [x23, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00659F814  ldr      x26, [x26, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
00659F818  mov      x24, x0
00659F81C  mov      w25, wzr
00659F820  adrp     x21, #0x9598000
00659F824  mov      w27, #1
00659F828  adrp     x22, #0x9598000
00659F82C  ldr      w9, [x8, #0x18]
00659F830  cmp      w25, w9
00659F834  b.ge     #0x659fa34
00659F838  adrp     x9, #0x8ec2000
00659F83C  ldr      x9, [x9, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00659F840  mov      x0, x8
00659F844  mov      w1, w25
00659F848  ldr      x2, [x9]
00659F84C  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00659F850  ldr      x20, [x19, #0x18]
00659F854  cbz      x20, #0x659fa30
00659F858  ldrb     w8, [x21, #0xfcc]
00659F85C  mov      w28, w0
00659F860  cbnz     w8, #0x659f870
00659F864  mov      x0, x23
00659F868  bl       #0x382bd14 ; 
00659F86C  strb     w27, [x21, #0xfcc]
00659F870  ldr      x1, [x23]
00659F874  ldrb     w8, [x1, #0x53]
00659F878  tbnz     w8, #5, #0x659f884
00659F87C  ldr      x0, [x20, #0x200]
00659F880  b        #0x659f890 ; 
00659F884  ldr      x8, [x1, #0x60]
00659F888  mov      x0, x20
00659F88C  blr      x8
00659F890  cbz      x0, #0x659fa30
00659F894  mov      w1, w28
00659F898  mov      x2, xzr
00659F89C  mov      w29, w28
00659F8A0  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
00659F8A4  cbz      x0, #0x659fa30
00659F8A8  ldrb     w8, [x22, #0x35e]
00659F8AC  mov      x20, x0
00659F8B0  cbnz     w8, #0x659f8c0
00659F8B4  mov      x0, x26
00659F8B8  bl       #0x382bd14 ; 
00659F8BC  strb     w27, [x22, #0x35e]
00659F8C0  ldr      x1, [x26]
00659F8C4  ldrb     w8, [x1, #0x53]
00659F8C8  tbnz     w8, #5, #0x659f8d4
00659F8CC  ldr      w0, [x20, #0x68]
00659F8D0  b        #0x659f8e0 ; 
00659F8D4  ldr      x8, [x1, #0x60]
00659F8D8  mov      x0, x20
00659F8DC  blr      x8
00659F8E0  cmp      w0, #4
00659F8E4  b.eq     #0x659f924
00659F8E8  ldrb     w8, [x22, #0x35e]
00659F8EC  cbnz     w8, #0x659f8fc
00659F8F0  mov      x0, x26
00659F8F4  bl       #0x382bd14 ; 
00659F8F8  strb     w27, [x22, #0x35e]
00659F8FC  ldr      x1, [x26]
00659F900  ldrb     w8, [x1, #0x53]
00659F904  tbnz     w8, #5, #0x659f910
00659F908  ldr      w0, [x20, #0x68]
00659F90C  b        #0x659f91c ; 
00659F910  ldr      x8, [x1, #0x60]
00659F914  mov      x0, x20
00659F918  blr      x8
00659F91C  cmp      w0, #5
00659F920  b.ne     #0x659f9c0
00659F924  adrp     x8, #0x9599000
00659F928  ldrb     w8, [x8, #0x4c8]
00659F92C  cbnz     w8, #0x659f944
00659F930  adrp     x0, #0x8f09000
00659F934  ldr      x0, [x0, #0xd0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_BattleSkillGroup() @ 0x92ac408
00659F938  bl       #0x382bd14 ; 
00659F93C  adrp     x8, #0x9599000
00659F940  strb     w27, [x8, #0x4c8]
00659F944  adrp     x8, #0x8f09000
00659F948  ldr      x8, [x8, #0xd0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_BattleSkillGroup() @ 0x92ac408
00659F94C  ldr      x1, [x8]
00659F950  ldrb     w8, [x1, #0x53]
00659F954  tbnz     w8, #5, #0x659f960
00659F958  ldr      w1, [x20, #0x120]
00659F95C  b        #0x659f970 ; 
00659F960  ldr      x8, [x1, #0x60]
00659F964  mov      x0, x20
00659F968  blr      x8
00659F96C  mov      w1, w0
00659F970  cbz      x24, #0x659fa30
00659F974  adrp     x8, #0x8f09000
00659F978  ldr      x8, [x8, #0xb0] ; GLOBAL Method$Rock.Collections.OrderedDictionary<int, List<int>>.get_Item() @ 0x92286b0
00659F97C  mov      x0, x24
00659F980  ldr      x2, [x8]
00659F984  bl       #0x5225a74 ; Rock.Collections.OrderedDictionary<int, object>$$get_Item
00659F988  cbz      x0, #0x659fa30
00659F98C  adrp     x8, #0x8ec2000
00659F990  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00659F994  mov      w1, wzr
00659F998  mov      x20, x0
00659F99C  ldr      x2, [x8]
00659F9A0  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00659F9A4  adrp     x8, #0x8ed2000
00659F9A8  ldr      x8, [x8, #0xdd8] ; GLOBAL Method$System.Collections.Generic.List<int>.RemoveAt() @ 0x921de98
00659F9AC  mov      w29, w0
00659F9B0  mov      x0, x20
00659F9B4  mov      w1, wzr
00659F9B8  ldr      x2, [x8]
00659F9BC  bl       #0x4d6603c ; System.Collections.Generic.List<int>$$RemoveAt
00659F9C0  ldr      x0, [x19, #0x40]
00659F9C4  cbz      x0, #0x659fa30
00659F9C8  adrp     x9, #0x8f09000
00659F9CC  ldr      w10, [x0, #0x1c]
00659F9D0  ldr      x8, [x0, #0x10]
00659F9D4  ldr      x9, [x9, #0x98] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Add() @ 0x921f528
00659F9D8  add      w10, w10, #1
00659F9DC  ldr      x9, [x9]
00659F9E0  str      w10, [x0, #0x1c]
00659F9E4  cbz      x8, #0x659fa30
00659F9E8  ldrsw    x10, [x0, #0x18]
00659F9EC  ldr      w11, [x8, #0x18]
00659F9F0  mov      w1, w28
00659F9F4  bfi      x1, x29, #0x20, #0x20
00659F9F8  cmp      w10, w11
00659F9FC  b.hs     #0x659fa14
00659FA00  add      w9, w10, #1
00659FA04  add      x8, x8, x10, lsl #3
00659FA08  str      w9, [x0, #0x18]
00659FA0C  str      x1, [x8, #0x20]
00659FA10  b        #0x659fa24 ; 
00659FA14  ldr      x8, [x9, #0x20]
00659FA18  ldr      x8, [x8, #0xc0]
00659FA1C  ldr      x2, [x8, #0x70]
00659FA20  bl       #0x4dd582c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$AddWithResize
00659FA24  ldr      x8, [x19, #0x20]
00659FA28  add      w25, w25, #1
00659FA2C  cbnz     x8, #0x659f82c
00659FA30  bl       #0x382bfb8 ; 
00659FA34  adrp     x21, #0x8f09000
00659FA38  ldr      x21, [x21, #0x78] ; GLOBAL System.Collections.Generic.List<PunchboardSkillRandomData>_TypeInfo @ 0x91da4e8
00659FA3C  ldr      x0, [x21]
00659FA40  bl       #0x382bfa0 ; 
00659FA44  adrp     x22, #0x8f09000
00659FA48  ldr      x22, [x22, #0x70] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>..ctor() @ 0x921f520
00659FA4C  mov      x20, x0
00659FA50  ldr      x1, [x22]
00659FA54  bl       #0x4dd4fd8 ; System.Collections.Generic.List<PunchboardSkillRandomData>$$.ctor
00659FA58  ldr      w1, [sp, #0x2c]
00659FA5C  mov      x0, x19
00659FA60  mov      x2, x20
00659FA64  bl       #0x65a3cec ; HotFix.BattleLogic.PlayerPunchboard$$FillRandomSkillList
00659FA68  ldr      x8, [x21]
00659FA6C  mov      w23, w0
00659FA70  mov      x0, x8
00659FA74  bl       #0x382bfa0 ; 
00659FA78  ldr      x1, [x22]
00659FA7C  mov      x24, x0
00659FA80  bl       #0x4dd4fd8 ; System.Collections.Generic.List<PunchboardSkillRandomData>$$.ctor
00659FA84  ldr      x3, [sp, #0x20]
00659FA88  mov      x0, x19
00659FA8C  mov      x1, x20
00659FA90  mov      x2, x24
00659FA94  bl       #0x65a3ff4 ; HotFix.BattleLogic.PlayerPunchboard$$GetResultSkillList
00659FA98  ldr      x8, [x19, #0x48]
00659FA9C  cbz      x8, #0x659fa30
00659FAA0  ldr      w9, [x8, #0x1c]
00659FAA4  add      w9, w9, #1
00659FAA8  stp      wzr, w9, [x8, #0x18]
00659FAAC  cbz      x24, #0x659fa30
00659FAB0  ldr      w8, [x24, #0x18]
00659FAB4  cmp      w8, #1
00659FAB8  b.lt     #0x659fb4c
00659FABC  adrp     x22, #0x8f09000
00659FAC0  ldr      x22, [x22, #0xa8] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.get_Item() @ 0x921f568
00659FAC4  mov      w20, wzr
00659FAC8  ldr      x2, [x22]
00659FACC  ldr      x21, [x19, #0x48]
00659FAD0  mov      x0, x24
00659FAD4  mov      w1, w20
00659FAD8  bl       #0x4dd553c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$get_Item
00659FADC  cbz      x21, #0x659fa30
00659FAE0  adrp     x9, #0x8f09000
00659FAE4  ldr      w10, [x21, #0x1c]
00659FAE8  ldr      x8, [x21, #0x10]
00659FAEC  ldr      x9, [x9, #0x98] ; GLOBAL Method$System.Collections.Generic.List<PunchboardSkillRandomData>.Add() @ 0x921f528
00659FAF0  add      w10, w10, #1
00659FAF4  ldr      x9, [x9]
00659FAF8  str      w10, [x21, #0x1c]
00659FAFC  cbz      x8, #0x659fa30
00659FB00  ldrsw    x10, [x21, #0x18]
00659FB04  ldr      w11, [x8, #0x18]
00659FB08  mov      x1, x0
00659FB0C  cmp      w10, w11
00659FB10  b.hs     #0x659fb28
00659FB14  add      w9, w10, #1
00659FB18  add      x8, x8, x10, lsl #3
00659FB1C  str      w9, [x21, #0x18]
00659FB20  str      x1, [x8, #0x20]
00659FB24  b        #0x659fb3c ; 
00659FB28  ldr      x8, [x9, #0x20]
00659FB2C  mov      x0, x21
00659FB30  ldr      x8, [x8, #0xc0]
00659FB34  ldr      x2, [x8, #0x70]
00659FB38  bl       #0x4dd582c ; System.Collections.Generic.List<PunchboardSkillRandomData>$$AddWithResize
00659FB3C  ldr      w8, [x24, #0x18]
00659FB40  add      w20, w20, #1
00659FB44  cmp      w20, w8
00659FB48  b.lt     #0x659fac8
00659FB4C  cmp      w23, #5
00659FB50  b.ne     #0x659fb6c
00659FB54  ldr      x2, [x19, #0x40]
00659FB58  mov      x0, x19
00659FB5C  mov      x1, x24
00659FB60  bl       #0x65a43f0 ; HotFix.BattleLogic.PlayerPunchboard$$MakeResultSkillListContinuous
00659FB64  mov      w22, w0
00659FB68  b        #0x659fb88 ; 
00659FB6C  adrp     x8, #0x8f09000
00659FB70  ldr      x0, [x19, #0x18]
00659FB74  ldr      x1, [x19, #0x40]
00659FB78  ldr      x8, [x8, #0xb8] ; GLOBAL Method$HotFix.BattleLogic.PlayerPunchboard.ShuffleList<PunchboardSkillRandomData>() @ 0x929a2e8
00659FB7C  ldr      x2, [x8]
00659FB80  bl       #0x4695c34 ; HotFix.BattleLogic.PlayerPunchboard$$ShuffleList<PunchboardSkillRandomData>
00659FB84  mov      w22, wzr
00659FB88  ldr      x21, [x19, #0x18]
00659FB8C  cbz      x21, #0x659fa30
00659FB90  adrp     x8, #0x8f09000
00659FB94  ldr      x8, [x8, #0x88] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<ShowPunchboadEvent>() @ 0x923f480
00659FB98  ldr      x20, [x8]
00659FB9C  ldr      x8, [x20, #0x38]
00659FBA0  cbnz     x8, #0x659fbac
00659FBA4  mov      x0, x20
00659FBA8  bl       #0x3a7e668 ; 
00659FBAC  ldrb     w8, [x20, #0x53]
00659FBB0  tbnz     w8, #5, #0x659fbf0
00659FBB4  adrp     x25, #0x9591000
00659FBB8  ldrb     w8, [x25, #0xa61]
00659FBBC  cbnz     w8, #0x659fbd4
00659FBC0  adrp     x0, #0x8ee6000
00659FBC4  ldr      x0, [x0, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
00659FBC8  bl       #0x382bd14 ; 
00659FBCC  mov      w8, #1
00659FBD0  strb     w8, [x25, #0xa61]
00659FBD4  adrp     x8, #0x8ee6000
00659FBD8  ldr      x8, [x8, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
00659FBDC  ldr      x1, [x8]
00659FBE0  ldrb     w8, [x1, #0x53]
00659FBE4  tbnz     w8, #5, #0x659fc04
00659FBE8  ldr      x0, [x21, #0x1e8]
00659FBEC  b        #0x659fc10 ; 
00659FBF0  ldr      x8, [x20, #0x60]
00659FBF4  mov      x0, x21
00659FBF8  mov      x1, x20
00659FBFC  blr      x8
00659FC00  b        #0x659fc20 ; 
00659FC04  ldr      x8, [x1, #0x60]
00659FC08  mov      x0, x21
00659FC0C  blr      x8
00659FC10  cbz      x0, #0x659fa30
00659FC14  ldr      x8, [x20, #0x38]
00659FC18  ldr      x1, [x8]
00659FC1C  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
00659FC20  mov      x21, x0
00659FC24  ldr      x0, [x19, #0x10]
00659FC28  cbz      x0, #0x659fa30
00659FC2C  mov      x1, xzr
00659FC30  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
00659FC34  cbz      x21, #0x659fa30
00659FC38  str      w0, [x21, #0x20]
00659FC3C  mov      x0, x21
00659FC40  str      w23, [x21, #0x3c]
00659FC44  str      x24, [x0, #0x28]!
00659FC48  mov      x1, x24
00659FC4C  bl       #0x382bcb8 ; 
00659FC50  ldr      x1, [x19, #0x40]
00659FC54  mov      x20, x21
00659FC58  str      x1, [x20, #0x30]!
00659FC5C  mov      x0, x20
00659FC60  bl       #0x382bcb8 ; 
00659FC64  ldr      w8, [sp, #0x1c]
00659FC68  str      w22, [x20, #8]
00659FC6C  strb     wzr, [x20, #0x12]
00659FC70  strb     w8, [x20, #0x10]
00659FC74  ldr      x20, [x19, #0x18]
00659FC78  cbz      x20, #0x659fa30
00659FC7C  adrp     x24, #0x9598000
00659FC80  ldrb     w8, [x24, #0xfc4]
00659FC84  cbnz     w8, #0x659fc9c
00659FC88  adrp     x0, #0x8f05000
00659FC8C  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00659FC90  bl       #0x382bd14 ; 
00659FC94  mov      w8, #1
00659FC98  strb     w8, [x24, #0xfc4]
00659FC9C  adrp     x25, #0x8f05000
00659FCA0  ldr      x25, [x25, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00659FCA4  ldr      x1, [x25]
00659FCA8  ldrb     w8, [x1, #0x53]
00659FCAC  tbnz     w8, #5, #0x659fcb8
00659FCB0  ldr      x0, [x20, #0x220]
00659FCB4  b        #0x659fcc4 ; 
00659FCB8  ldr      x8, [x1, #0x60]
00659FCBC  mov      x0, x20
00659FCC0  blr      x8
00659FCC4  cbz      x0, #0x659fa30
00659FCC8  mov      x1, xzr
00659FCCC  bl       #0x6585324 ; HotFix.BattleLogic.BattleManager$$IsBossWave
00659FCD0  and      w8, w0, #1
00659FCD4  strb     w8, [x21, #0x41]
00659FCD8  ldr      x20, [x19, #0x18]
00659FCDC  cbz      x20, #0x659fa30
00659FCE0  adrp     x26, #0x9591000
00659FCE4  ldrb     w8, [x26, #0xa90]
00659FCE8  cbnz     w8, #0x659fd00
00659FCEC  adrp     x0, #0x8ee6000
00659FCF0  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00659FCF4  bl       #0x382bd14 ; 
00659FCF8  mov      w8, #1
00659FCFC  strb     w8, [x26, #0xa90]
00659FD00  adrp     x27, #0x8ee6000
00659FD04  ldr      x27, [x27, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00659FD08  ldr      x1, [x27]
00659FD0C  ldrb     w8, [x1, #0x53]
00659FD10  tbnz     w8, #5, #0x659fd1c
00659FD14  ldr      x0, [x20, #0x230]
00659FD18  b        #0x659fd28 ; 
00659FD1C  ldr      x8, [x1, #0x60]
00659FD20  mov      x0, x20
00659FD24  blr      x8
00659FD28  adrp     x20, #0x9599000
00659FD2C  cbz      x0, #0x659fa30
00659FD30  adrp     x8, #0x8f08000
00659FD34  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
00659FD38  ldr      x1, [x8]
00659FD3C  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
00659FD40  ldrb     w8, [x20, #0x4c7]
00659FD44  mov      x22, x0
00659FD48  cbnz     w8, #0x659fd60
00659FD4C  adrp     x0, #0x8f09000
00659FD50  ldr      x0, [x0, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
00659FD54  bl       #0x382bd14 ; 
00659FD58  mov      w8, #1
00659FD5C  strb     w8, [x20, #0x4c7]
00659FD60  adrp     x8, #0x8f09000
00659FD64  ldr      x8, [x8, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
00659FD68  ldr      x1, [x8]
00659FD6C  ldrb     w8, [x1, #0x53]
00659FD70  tbnz     w8, #5, #0x659fd80
00659FD74  ldr      x8, [sp, #0x10]
00659FD78  ldr      x1, [x8, #0x58]
00659FD7C  b        #0x659fd90 ; 
00659FD80  ldr      x8, [x1, #0x60]
00659FD84  ldr      x0, [sp, #0x10]
00659FD88  blr      x8
00659FD8C  mov      x1, x0
00659FD90  cbz      x22, #0x659fa30
00659FD94  adrp     x8, #0x8f08000
00659FD98  ldr      x8, [x8, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
00659FD9C  mov      x0, x22
00659FDA0  ldr      x2, [x8]
00659FDA4  bl       #0x4d64760 ; System.Collections.Generic.List<int>$$AddRange
00659FDA8  adrp     x8, #0x8ec1000
00659FDAC  ldr      w1, [x22, #0x18]
00659FDB0  ldr      x8, [x8, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
00659FDB4  ldr      x0, [x8]
00659FDB8  bl       #0x382bdfc ; 
00659FDBC  mov      x20, x21
00659FDC0  str      x0, [x20, #0x48]!
00659FDC4  mov      x1, x0
00659FDC8  mov      x0, x20
00659FDCC  bl       #0x382bcb8 ; 
00659FDD0  ldr      w8, [x22, #0x18]
00659FDD4  cmp      w8, #1
00659FDD8  b.lt     #0x659fe24
00659FDDC  mov      x23, xzr
00659FDE0  adrp     x8, #0x8ec2000
00659FDE4  ldr      x28, [x20]
00659FDE8  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00659FDEC  mov      x0, x22
00659FDF0  mov      w1, w23
00659FDF4  ldr      x2, [x8]
00659FDF8  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00659FDFC  cbz      x28, #0x659fa30
00659FE00  ldr      w8, [x28, #0x18]
00659FE04  cmp      x23, x8
00659FE08  b.hs     #0x65a009c
00659FE0C  add      x8, x28, x23, lsl #2
00659FE10  str      w0, [x8, #0x20]
00659FE14  ldrsw    x8, [x22, #0x18]
00659FE18  add      x23, x23, #1
00659FE1C  cmp      x23, x8
00659FE20  b.lt     #0x659fde0
00659FE24  ldr      x20, [x19, #0x18]
00659FE28  cbz      x20, #0x659fa30
00659FE2C  ldrb     w8, [x26, #0xa90]
00659FE30  cbnz     w8, #0x659fe48
00659FE34  adrp     x0, #0x8ee6000
00659FE38  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00659FE3C  bl       #0x382bd14 ; 
00659FE40  mov      w8, #1
00659FE44  strb     w8, [x26, #0xa90]
00659FE48  ldr      x1, [x27]
00659FE4C  ldrb     w8, [x1, #0x53]
00659FE50  tbnz     w8, #5, #0x659fe5c
00659FE54  ldr      x0, [x20, #0x230]
00659FE58  b        #0x659fe68 ; 
00659FE5C  ldr      x8, [x1, #0x60]
00659FE60  mov      x0, x20
00659FE64  blr      x8
00659FE68  cbz      x0, #0x659fa30
00659FE6C  adrp     x8, #0x8f08000
00659FE70  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
00659FE74  mov      x1, x22
00659FE78  ldr      x2, [x8]
00659FE7C  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
00659FE80  ldr      x20, [x19, #0x18]
00659FE84  cbz      x20, #0x659fa30
00659FE88  ldrb     w8, [x24, #0xfc4]
00659FE8C  cbnz     w8, #0x659fea4
00659FE90  adrp     x0, #0x8f05000
00659FE94  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00659FE98  bl       #0x382bd14 ; 
00659FE9C  mov      w8, #1
00659FEA0  strb     w8, [x24, #0xfc4]
00659FEA4  ldr      x1, [x25]
00659FEA8  ldrb     w8, [x1, #0x53]
00659FEAC  tbnz     w8, #5, #0x659feb8
00659FEB0  ldr      x0, [x20, #0x220]
00659FEB4  b        #0x659fec4 ; 
00659FEB8  ldr      x8, [x1, #0x60]
00659FEBC  mov      x0, x20
00659FEC0  blr      x8
00659FEC4  cbz      x0, #0x659fa30
00659FEC8  ldr      x8, [x0]
00659FECC  ldr      x9, [x8, #0x518]
00659FED0  ldr      x1, [x8, #0x520]
00659FED4  blr      x9
00659FED8  str      w0, [x21, #0x50]
00659FEDC  ldr      x20, [x19, #0x18]
00659FEE0  cbz      x20, #0x659fa30
00659FEE4  ldrb     w8, [x24, #0xfc4]
00659FEE8  cbnz     w8, #0x659ff00
00659FEEC  adrp     x0, #0x8f05000
00659FEF0  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00659FEF4  bl       #0x382bd14 ; 
00659FEF8  mov      w8, #1
00659FEFC  strb     w8, [x24, #0xfc4]
00659FF00  ldr      x1, [x25]
00659FF04  ldrb     w8, [x1, #0x53]
00659FF08  tbnz     w8, #5, #0x659ff14
00659FF0C  ldr      x0, [x20, #0x220]
00659FF10  b        #0x659ff20 ; 
00659FF14  ldr      x8, [x1, #0x60]
00659FF18  mov      x0, x20
00659FF1C  blr      x8
00659FF20  cbz      x0, #0x659fa30
00659FF24  ldr      x8, [x0]
00659FF28  ldr      x9, [x8, #0x528]
00659FF2C  ldr      x1, [x8, #0x530]
00659FF30  blr      x9
00659FF34  str      w0, [x21, #0x54]
00659FF38  ldr      x0, [x19, #0x10]
00659FF3C  cbz      x0, #0x659fa30
00659FF40  adrp     x8, #0x8ee6000
00659FF44  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00659FF48  ldr      x1, [x8]
00659FF4C  ldrb     w8, [x1, #0x53]
00659FF50  tbnz     w8, #5, #0x659ff5c
00659FF54  ldr      x20, [x0, #0x38]
00659FF58  b        #0x659ff68 ; 
00659FF5C  ldr      x8, [x1, #0x60]
00659FF60  blr      x8
00659FF64  mov      x20, x0
00659FF68  cbz      x20, #0x659fa30
00659FF6C  adrp     x22, #0x9591000
00659FF70  ldrb     w8, [x22, #0xa7f]
00659FF74  cbnz     w8, #0x659ff8c
00659FF78  adrp     x0, #0x8ee6000
00659FF7C  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00659FF80  bl       #0x382bd14 ; 
00659FF84  mov      w8, #1
00659FF88  strb     w8, [x22, #0xa7f]
00659FF8C  adrp     x8, #0x8ee6000
00659FF90  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
00659FF94  ldr      x1, [x8]
00659FF98  ldrb     w8, [x1, #0x53]
00659FF9C  tbnz     w8, #5, #0x659ffa8
00659FFA0  ldr      x0, [x20, #0x178]
00659FFA4  b        #0x659ffb4 ; 
00659FFA8  ldr      x8, [x1, #0x60]
00659FFAC  mov      x0, x20
00659FFB0  blr      x8
00659FFB4  cbz      x0, #0x659fa30
00659FFB8  mov      x1, xzr
00659FFBC  bl       #0x6b3cf00 ; HotFix.Common.AttributeData$$GetAttack
00659FFC0  lsr      x8, x0, #0x10
00659FFC4  str      w8, [x21, #0x58]
00659FFC8  ldr      x0, [x19, #0x10]
00659FFCC  cbz      x0, #0x659fa30
00659FFD0  ldr      x8, [x0]
00659FFD4  ldr      x9, [x8, #0x498]
00659FFD8  ldr      x1, [x8, #0x4a0]
00659FFDC  blr      x9
00659FFE0  str      w0, [x21, #0x5c]
00659FFE4  ldr      x0, [x19, #0x18]
00659FFE8  cbz      x0, #0x659fa30
00659FFEC  mov      x1, xzr
00659FFF0  bl       #0x6a009e8 ; HotFix.BattleLogic.BattleWorldContext$$ResetGameSpeed
00659FFF4  ldr      x8, [x19, #0x18]
00659FFF8  cbz      x8, #0x659fa30
00659FFFC  ldr      x19, [x8, #0x1e0]
0065A0000  cbz      x19, #0x659fa30
0065A0004  adrp     x9, #0x8f09000
0065A0008  ldr      x9, [x9, #0x90] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<ShowPunchboadEvent>() @ 0x9284938
0065A000C  ldr      x8, [x19]
0065A0010  ldr      x20, [x9]
0065A0014  ldrh     w9, [x8, #0x12e]
0065A0018  ldr      x1, [x20, #0x20]
0065A001C  ldrh     w2, [x20, #0x50]
0065A0020  cbz      x9, #0x65a0044
0065A0024  ldr      x10, [x8, #0xb0]
0065A0028  add      x10, x10, #8
0065A002C  ldur     x11, [x10, #-8]
0065A0030  cmp      x11, x1
0065A0034  b.eq     #0x65a0050
0065A0038  subs     x9, x9, #1
0065A003C  add      x10, x10, #0x10
0065A0040  b.ne     #0x65a002c
0065A0044  mov      x0, x19
0065A0048  bl       #0x3a7e710 ; 
0065A004C  b        #0x65a0060 ; 
0065A0050  ldr      w9, [x10]
0065A0054  add      w9, w9, w2
0065A0058  add      x8, x8, w9, sxtw #4
0065A005C  add      x0, x8, #0x138
0065A0060  ldr      x0, [x0, #8]
0065A0064  mov      x1, x20
0065A0068  bl       #0x382be88 ; 
0065A006C  mov      x2, x0
0065A0070  ldr      x3, [x0, #8]
0065A0074  mov      x0, x19
0065A0078  mov      x1, x21
0065A007C  ldp      x20, x19, [sp, #0x80]
0065A0080  ldp      x22, x21, [sp, #0x70]
0065A0084  ldp      x24, x23, [sp, #0x60]
0065A0088  ldp      x26, x25, [sp, #0x50]
0065A008C  ldp      x28, x27, [sp, #0x40]
0065A0090  ldp      x29, x30, [sp, #0x30]
0065A0094  add      sp, sp, #0x90
0065A0098  br       x3
0065A009C  bl       #0x382bfc0 ; 

