; HotFix.BattleLogic.DankeSkillCreator$$GetRandomSkills
; RVA 0x685F434; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685F434  sub      sp, sp, #0xf0
00685F438  stp      x29, x30, [sp, #0x90]
00685F43C  stp      x28, x27, [sp, #0xa0]
00685F440  stp      x26, x25, [sp, #0xb0]
00685F444  stp      x24, x23, [sp, #0xc0]
00685F448  stp      x22, x21, [sp, #0xd0]
00685F44C  stp      x20, x19, [sp, #0xe0]
00685F450  ldrb     w8, [sp, #0x108]
00685F454  str      w4, [sp, #0x5c]
00685F458  adrp     x23, #0x959b000
00685F45C  adrp     x20, #0x8f23000
00685F460  str      w8, [sp, #0x28]
00685F464  ldr      w8, [sp, #0x100]
00685F468  ldrb     w29, [sp, #0xf0]
00685F46C  mov      w27, w7
00685F470  mov      x25, x6
00685F474  str      w8, [sp, #0x6c]
00685F478  ldr      w8, [sp, #0xf8]
00685F47C  mov      x28, x5
00685F480  mov      x22, x3
00685F484  mov      x24, x2
00685F488  str      w8, [sp, #0x40]
00685F48C  ldrb     w8, [x23, #0xa05]
00685F490  ldr      x20, [x20, #0xc08] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetRandomSkills() @ 0x9259d78
00685F494  mov      x21, x1
00685F498  mov      x19, x0
00685F49C  tbnz     w8, #0, #0x685f5c8
00685F4A0  adrp     x0, #0x8ee8000
00685F4A4  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00685F4A8  bl       #0x382bd14 ; 
00685F4AC  adrp     x0, #0x8f23000
00685F4B0  ldr      x0, [x0, #0xc08] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetRandomSkills() @ 0x9259d78
00685F4B4  bl       #0x382bd14 ; 
00685F4B8  adrp     x0, #0x8ee2000
00685F4BC  ldr      x0, [x0, #0x970] ; GLOBAL Photon.Deterministic.FP_TypeInfo @ 0x91e6728
00685F4C0  bl       #0x382bd14 ; 
00685F4C4  adrp     x0, #0x8ec1000
00685F4C8  ldr      x0, [x0, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
00685F4CC  bl       #0x382bd14 ; 
00685F4D0  adrp     x0, #0x8ebf000
00685F4D4  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685F4D8  bl       #0x382bd14 ; 
00685F4DC  adrp     x0, #0x8eea000
00685F4E0  ldr      x0, [x0, #0xf18] ; GLOBAL Method$System.Collections.Generic.List<int>.ToArray() @ 0x921dec0
00685F4E4  bl       #0x382bd14 ; 
00685F4E8  adrp     x0, #0x8ec2000
00685F4EC  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
00685F4F0  bl       #0x382bd14 ; 
00685F4F4  adrp     x0, #0x8ebf000
00685F4F8  ldr      x0, [x0, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
00685F4FC  bl       #0x382bd14 ; 
00685F500  adrp     x0, #0x8ec2000
00685F504  ldr      x0, [x0, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
00685F508  bl       #0x382bd14 ; 
00685F50C  adrp     x0, #0x8f09000
00685F510  ldr      x0, [x0, #0xa98] ; GLOBAL Method$System.String.Join<int>() @ 0x92b0100
00685F514  bl       #0x382bd14 ; 
00685F518  adrp     x0, #0x8f08000
00685F51C  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
00685F520  bl       #0x382bd14 ; 
00685F524  adrp     x0, #0x8f08000
00685F528  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
00685F52C  bl       #0x382bd14 ; 
00685F530  adrp     x0, #0x8f23000
00685F534  ldr      x0, [x0, #0xc10] ; GLOBAL -[RandomSkill] 随机技能结束 @ 0x92eabc8
00685F538  bl       #0x382bd14 ; 
00685F53C  adrp     x0, #0x8f23000
00685F540  ldr      x0, [x0, #0xc18] ; GLOBAL -[RandomSkill]-[Danke] realIndex = {0} newSkillCount = {1} count = {2} @ 0x92eabe0
00685F544  bl       #0x382bd14 ; 
00685F548  adrp     x0, #0x8f23000
00685F54C  ldr      x0, [x0, #0xc20] ; GLOBAL -[RandomSkill] 已学技能权重 = {0} 随机值 = {1}  allWeight = {2} @ 0x92eab90
00685F550  bl       #0x382bd14 ; 
00685F554  adrp     x0, #0x8f23000
00685F558  ldr      x0, [x0, #0xc28] ; GLOBAL -[RandomSkill] 技能品质 = {0} 技能数量 = {1}  已学被动池数量 = {2}  技能池剩余数量 = {3} @ 0x92eaba0
00685F55C  bl       #0x382bd14 ; 
00685F560  adrp     x0, #0x8f23000
00685F564  ldr      x0, [x0, #0xc30] ; GLOBAL -[RandomSkill] 品质 = {0} 随机出的技能 = {1} @ 0x92eab88
00685F568  bl       #0x382bd14 ; 
00685F56C  adrp     x0, #0x8f23000
00685F570  ldr      x0, [x0, #0xc38] ; GLOBAL -[RandomSkill] 技能品质 = {0} 技能数量 = {1}  已学技能池数量 = {2}  技能池剩余数量 = {3} @ 0x92eab98
00685F574  bl       #0x382bd14 ; 
00685F578  adrp     x0, #0x8f23000
00685F57C  ldr      x0, [x0, #0xc40] ; GLOBAL -[RandomSkill] 随机出的curWeight = {0}   maxWeight = {1} @ 0x92eabb0
00685F580  bl       #0x382bd14 ; 
00685F584  adrp     x0, #0x8f23000
00685F588  ldr      x0, [x0, #0xc48] ; GLOBAL -[RandomSkill] 随机技能开始 @ 0x92eabc0
00685F58C  bl       #0x382bd14 ; 
00685F590  adrp     x0, #0x8ec2000
00685F594  ldr      x0, [x0, #0x4e0] ; GLOBAL , @ 0x92ea038
00685F598  bl       #0x382bd14 ; 
00685F59C  adrp     x0, #0x8f23000
00685F5A0  ldr      x0, [x0, #0xc50] ; GLOBAL -[RandomSkill] 随机出的品质 = {0} @ 0x92eabb8
00685F5A4  bl       #0x382bd14 ; 
00685F5A8  adrp     x0, #0x8f23000
00685F5AC  ldr      x0, [x0, #0xc58] ; GLOBAL -[RandomSkill]-[Danke] 剩余技能数量不足 无法随机出需要的技能  passiveSkillCount = {0}  weaponSkillCount = {1} @ 0x92eabe8
00685F5B0  bl       #0x382bd14 ; 
00685F5B4  adrp     x0, #0x8f23000
00685F5B8  ldr      x0, [x0, #0xc60] ; GLOBAL -[RandomSkill] realIndex = {0} 技能数量 = {1}  superCount = {2}  @ 0x92eab80
00685F5BC  bl       #0x382bd14 ; 
00685F5C0  mov      w8, #1
00685F5C4  strb     w8, [x23, #0xa05]
00685F5C8  ldr      x8, [x20]
00685F5CC  ldrb     w9, [x8, #0x53]
00685F5D0  tbnz     w9, #5, #0x685f6e0
00685F5D4  adrp     x26, #0x8ee8000
00685F5D8  ldr      x26, [x26, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00685F5DC  mov      w20, wzr
00685F5E0  ldr      x0, [x26]
00685F5E4  ldr      w8, [x0, #0xe0]
00685F5E8  cbnz     w8, #0x685f5f4
00685F5EC  bl       #0x382be8c ; 
00685F5F0  ldr      x0, [x26]
00685F5F4  ldr      x8, [x0, #0xb8]
00685F5F8  ldr      w8, [x8, #0x2f0]
00685F5FC  cmp      w20, w8
00685F600  b.ge     #0x685f74c
00685F604  cbz      x22, #0x68606d8
00685F608  ldr      w8, [x22, #0x18]
00685F60C  cmp      w20, w8
00685F610  b.hs     #0x68606dc
00685F614  ldr      x8, [x19, #0x50]
00685F618  cbz      x8, #0x68606d8
00685F61C  ldr      w9, [x8, #0x18]
00685F620  cmp      w20, w9
00685F624  b.hs     #0x68606dc
00685F628  sxtw     x23, w20
00685F62C  add      x9, x22, x23, lsl #3
00685F630  ldr      x0, [x9, #0x20]
00685F634  cbz      x0, #0x68606d8
00685F638  add      x8, x8, x23, lsl #3
00685F63C  ldr      x1, [x8, #0x20]
00685F640  mov      x2, xzr
00685F644  bl       #0x6635c50 ; HotFix.BattleLogic.WeightRandom$$CopyWeightRandomFull
00685F648  ldr      x8, [x19, #0x50]
00685F64C  cbz      x8, #0x68606d8
00685F650  ldr      w9, [x8, #0x18]
00685F654  cmp      w20, w9
00685F658  b.hs     #0x68606dc
00685F65C  add      x8, x8, x23, lsl #3
00685F660  ldr      x0, [x8, #0x20]
00685F664  cbz      x0, #0x68606d8
00685F668  mov      x1, x21
00685F66C  mov      x2, x24
00685F670  mov      x3, xzr
00685F674  bl       #0x66362b8 ; HotFix.BattleLogic.WeightRandom$$InitAllSkillWeight
00685F678  ldr      x8, [x19, #0x30]
00685F67C  cbz      x8, #0x68606d8
00685F680  ldr      w9, [x8, #0x18]
00685F684  cmp      w20, w9
00685F688  b.hs     #0x68606dc
00685F68C  add      x8, x8, x23, lsl #3
00685F690  ldr      x0, [x8, #0x20]
00685F694  cbz      x0, #0x68606d8
00685F698  mov      x1, x21
00685F69C  mov      x2, x24
00685F6A0  mov      x3, xzr
00685F6A4  bl       #0x66362b8 ; HotFix.BattleLogic.WeightRandom$$InitAllSkillWeight
00685F6A8  ldr      x8, [x19, #0x38]
00685F6AC  cbz      x8, #0x68606d8
00685F6B0  ldr      w9, [x8, #0x18]
00685F6B4  cmp      w20, w9
00685F6B8  b.hs     #0x68606dc
00685F6BC  add      x8, x8, x23, lsl #3
00685F6C0  ldr      x0, [x8, #0x20]
00685F6C4  cbz      x0, #0x68606d8
00685F6C8  mov      x1, x21
00685F6CC  mov      x2, x24
00685F6D0  mov      x3, xzr
00685F6D4  bl       #0x66362b8 ; HotFix.BattleLogic.WeightRandom$$InitAllSkillWeight
00685F6D8  add      w20, w20, #1
00685F6DC  b        #0x685f5e0 ; 
00685F6E0  ldr      x9, [x8, #0x60]
00685F6E4  str      x8, [sp, #0x110]
00685F6E8  ldr      w8, [sp, #0x28]
00685F6EC  and      w7, w27, #1
00685F6F0  mov      x0, x19
00685F6F4  mov      x1, x21
00685F6F8  and      w8, w8, #1
00685F6FC  strb     w8, [sp, #0x108]
00685F700  ldr      w8, [sp, #0x6c]
00685F704  mov      x2, x24
00685F708  mov      x3, x22
00685F70C  ldr      w4, [sp, #0x5c]
00685F710  str      w8, [sp, #0x100]
00685F714  ldr      w8, [sp, #0x40]
00685F718  mov      x5, x28
00685F71C  mov      x6, x25
00685F720  ldp      x20, x19, [sp, #0xe0]
00685F724  str      w8, [sp, #0xf8]
00685F728  and      w8, w29, #1
00685F72C  ldp      x22, x21, [sp, #0xd0]
00685F730  ldp      x24, x23, [sp, #0xc0]
00685F734  ldp      x26, x25, [sp, #0xb0]
00685F738  ldp      x28, x27, [sp, #0xa0]
00685F73C  ldp      x29, x30, [sp, #0x90]
00685F740  strb     w8, [sp, #0xf0]
00685F744  add      sp, sp, #0xf0
00685F748  br       x9
00685F74C  mov      x0, x19
00685F750  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685F754  cbz      x0, #0x68606d8
00685F758  adrp     x8, #0x9591000
00685F75C  ldrb     w8, [x8, #0xa90]
00685F760  mov      x20, x0
00685F764  cbnz     w8, #0x685f780
00685F768  adrp     x0, #0x8ee6000
00685F76C  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00685F770  bl       #0x382bd14 ; 
00685F774  mov      w8, #1
00685F778  adrp     x9, #0x9591000
00685F77C  strb     w8, [x9, #0xa90]
00685F780  adrp     x8, #0x8ee6000
00685F784  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00685F788  ldr      x1, [x8]
00685F78C  ldrb     w8, [x1, #0x53]
00685F790  tbnz     w8, #5, #0x685f79c
00685F794  ldr      x0, [x20, #0x230]
00685F798  b        #0x685f7a8 ; 
00685F79C  ldr      x8, [x1, #0x60]
00685F7A0  mov      x0, x20
00685F7A4  blr      x8
00685F7A8  cbz      x0, #0x68606d8
00685F7AC  str      w29, [sp, #0x44]
00685F7B0  str      w27, [sp, #0x20]
00685F7B4  adrp     x8, #0x8f08000
00685F7B8  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
00685F7BC  ldr      x1, [x8]
00685F7C0  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
00685F7C4  mov      x1, x0
00685F7C8  mov      x0, x19
00685F7CC  mov      x2, x24
00685F7D0  str      x1, [sp, #0x38]
00685F7D4  bl       #0x68633d4 ; HotFix.BattleLogic.HeroSkillCreator$$GetBanSkill
00685F7D8  cbz      x25, #0x68606d8
00685F7DC  adrp     x8, #0x8ec1000
00685F7E0  ldr      x8, [x8, #0x240] ; GLOBAL int[]_TypeInfo @ 0x91df220
00685F7E4  ldr      w1, [x25, #0x18]
00685F7E8  ldr      x0, [x8]
00685F7EC  bl       #0x382bdfc ; 
00685F7F0  ldr      w8, [x25, #0x18]
00685F7F4  mov      x29, x0
00685F7F8  str      x25, [sp, #0x60]
00685F7FC  cmp      w8, #1
00685F800  b.lt     #0x685fcb0
00685F804  str      x28, [sp, #0x48]
00685F808  mov      x23, xzr
00685F80C  add      x28, x29, #0x20
00685F810  add      x25, x25, #0x20
00685F814  str      wzr, [sp, #0x2c]
00685F818  str      x25, [sp, #0x50]
00685F81C  cmp      w23, w8
00685F820  b.hs     #0x68606dc
00685F824  cbz      x29, #0x68606d8
00685F828  ldr      w8, [x29, #0x18]
00685F82C  cmp      w23, w8
00685F830  b.hs     #0x68606dc
00685F834  ldr      w8, [x25, x23, lsl #2]
00685F838  str      w8, [x28, x23, lsl #2]
00685F83C  ldr      x8, [x19, #0x50]
00685F840  cbz      x8, #0x68606d8
00685F844  ldr      w9, [x8, #0x18]
00685F848  cmp      w23, w9
00685F84C  b.hs     #0x68606dc
00685F850  add      x8, x8, x23, lsl #3
00685F854  ldr      x0, [x8, #0x20]
00685F858  cbz      x0, #0x68606d8
00685F85C  mov      x1, x21
00685F860  mov      x2, xzr
00685F864  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
00685F868  cmp      w23, #1
00685F86C  mov      w20, w0
00685F870  b.eq     #0x685f8cc
00685F874  cmp      w23, #2
00685F878  b.eq     #0x685faa4
00685F87C  cmp      w23, #3
00685F880  b.ne     #0x685fc80
00685F884  cbnz     w20, #0x685f898
00685F888  ldr      w8, [x29, #0x18]
00685F88C  cmp      w8, #3
00685F890  b.ls     #0x68606dc
00685F894  str      wzr, [x28, x23, lsl #2]
00685F898  ldr      x8, [x19, #0x50]
00685F89C  cbz      x8, #0x68606d8
00685F8A0  ldr      w9, [x8, #0x18]
00685F8A4  cmp      w9, #3
00685F8A8  b.ls     #0x68606dc
00685F8AC  add      x8, x8, x23, lsl #3
00685F8B0  ldr      x0, [x8, #0x20]
00685F8B4  cbz      x0, #0x68606d8
00685F8B8  mov      x1, xzr
00685F8BC  mov      x2, xzr
00685F8C0  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
00685F8C4  str      w0, [sp, #0x2c]
00685F8C8  b        #0x685fc80 ; 
00685F8CC  ldr      x8, [x19, #0x38]
00685F8D0  cbz      x8, #0x68606d8
00685F8D4  ldr      w9, [x8, #0x18]
00685F8D8  cmp      w9, #1
00685F8DC  b.ls     #0x68606dc
00685F8E0  add      x8, x8, x23, lsl #3
00685F8E4  ldr      x0, [x8, #0x20]
00685F8E8  cbz      x0, #0x68606d8
00685F8EC  mov      x1, x21
00685F8F0  mov      x2, xzr
00685F8F4  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
00685F8F8  adrp     x8, #0x8ec2000
00685F8FC  ldr      x8, [x8, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
00685F900  mov      w27, w0
00685F904  mov      w1, #4
00685F908  ldr      x8, [x8]
00685F90C  mov      x0, x8
00685F910  bl       #0x382bdfc ; 
00685F914  adrp     x8, #0x8ebf000
00685F918  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685F91C  mov      x26, x0
00685F920  add      x1, sp, #0x78
00685F924  ldr      x0, [x8]
00685F928  mov      w8, #1
00685F92C  str      w8, [sp, #0x78]
00685F930  bl       #0x382be94 ; 
00685F934  cbz      x26, #0x68606d8
00685F938  mov      x25, x0
00685F93C  cbz      x0, #0x685f954
00685F940  ldr      x8, [x26]
00685F944  mov      x0, x25
00685F948  ldr      x1, [x8, #0x40]
00685F94C  bl       #0x382be90 ; 
00685F950  cbz      x0, #0x68606e0
00685F954  ldr      w8, [x26, #0x18]
00685F958  cbz      w8, #0x68606dc
00685F95C  mov      x0, x26
00685F960  str      x25, [x0, #0x20]!
00685F964  mov      x1, x25
00685F968  bl       #0x382bcb8 ; 
00685F96C  adrp     x8, #0x8ebf000
00685F970  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685F974  add      x1, sp, #0x8c
00685F978  ldr      x0, [x8]
00685F97C  ldr      w8, [sp, #0x6c]
00685F980  str      w8, [sp, #0x8c]
00685F984  bl       #0x382be94 ; 
00685F988  mov      x25, x0
00685F98C  cbz      x0, #0x685f9a4
00685F990  ldr      x8, [x26]
00685F994  mov      x0, x25
00685F998  ldr      x1, [x8, #0x40]
00685F99C  bl       #0x382be90 ; 
00685F9A0  cbz      x0, #0x68606e0
00685F9A4  ldr      w8, [x26, #0x18]
00685F9A8  cmp      w8, #1
00685F9AC  b.ls     #0x68606dc
00685F9B0  mov      x0, x26
00685F9B4  str      x25, [x0, #0x28]!
00685F9B8  mov      x1, x25
00685F9BC  bl       #0x382bcb8 ; 
00685F9C0  adrp     x8, #0x8ebf000
00685F9C4  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685F9C8  add      x1, sp, #0x88
00685F9CC  str      w27, [sp, #0x88]
00685F9D0  ldr      x0, [x8]
00685F9D4  bl       #0x382be94 ; 
00685F9D8  mov      x25, x0
00685F9DC  cbz      x0, #0x685f9f4
00685F9E0  ldr      x8, [x26]
00685F9E4  mov      x0, x25
00685F9E8  ldr      x1, [x8, #0x40]
00685F9EC  bl       #0x382be90 ; 
00685F9F0  cbz      x0, #0x68606e0
00685F9F4  ldr      w8, [x26, #0x18]
00685F9F8  cmp      w8, #2
00685F9FC  b.ls     #0x68606dc
00685FA00  mov      x0, x26
00685FA04  str      x25, [x0, #0x30]!
00685FA08  mov      x1, x25
00685FA0C  bl       #0x382bcb8 ; 
00685FA10  adrp     x8, #0x8ebf000
00685FA14  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685FA18  add      x1, sp, #0x84
00685FA1C  str      w20, [sp, #0x84]
00685FA20  ldr      x0, [x8]
00685FA24  bl       #0x382be94 ; 
00685FA28  mov      x25, x0
00685FA2C  cbz      x0, #0x685fa44
00685FA30  ldr      x8, [x26]
00685FA34  mov      x0, x25
00685FA38  ldr      x1, [x8, #0x40]
00685FA3C  bl       #0x382be90 ; 
00685FA40  cbz      x0, #0x68606e0
00685FA44  ldr      w8, [x26, #0x18]
00685FA48  cmp      w8, #3
00685FA4C  b.ls     #0x68606dc
00685FA50  mov      x0, x26
00685FA54  str      x25, [x0, #0x38]!
00685FA58  mov      x1, x25
00685FA5C  bl       #0x382bcb8 ; 
00685FA60  adrp     x8, #0x8f23000
00685FA64  ldr      x8, [x8, #0xc28] ; GLOBAL -[RandomSkill] 技能品质 = {0} 技能数量 = {1}  已学被动池数量 = {2}  技能池剩余数量 = {3} @ 0x92eaba0
00685FA68  mov      x1, x26
00685FA6C  mov      x2, xzr
00685FA70  ldr      x0, [x8]
00685FA74  bl       #0x79e281c ; System.String$$Format
00685FA78  mov      x1, x0
00685FA7C  mov      x0, x19
00685FA80  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
00685FA84  cbz      w20, #0x685fa94
00685FA88  ldr      w8, [sp, #0x40]
00685FA8C  orr      w8, w27, w8
00685FA90  cbnz     w8, #0x685fc7c
00685FA94  ldr      w8, [x29, #0x18]
00685FA98  cmp      w8, #1
00685FA9C  b.hi     #0x685fc78
00685FAA0  b        #0x68606dc ; 
00685FAA4  ldr      x8, [x19, #0x30]
00685FAA8  cbz      x8, #0x68606d8
00685FAAC  ldr      w9, [x8, #0x18]
00685FAB0  cmp      w9, #2
00685FAB4  b.ls     #0x68606dc
00685FAB8  add      x8, x8, x23, lsl #3
00685FABC  ldr      x0, [x8, #0x20]
00685FAC0  cbz      x0, #0x68606d8
00685FAC4  mov      x1, x21
00685FAC8  mov      x2, xzr
00685FACC  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
00685FAD0  adrp     x8, #0x8ec2000
00685FAD4  ldr      x8, [x8, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
00685FAD8  mov      w27, w0
00685FADC  mov      w1, #4
00685FAE0  ldr      x8, [x8]
00685FAE4  mov      x0, x8
00685FAE8  bl       #0x382bdfc ; 
00685FAEC  adrp     x8, #0x8ebf000
00685FAF0  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685FAF4  mov      x26, x0
00685FAF8  add      x1, sp, #0x78
00685FAFC  ldr      x0, [x8]
00685FB00  mov      w8, #2
00685FB04  str      w8, [sp, #0x78]
00685FB08  bl       #0x382be94 ; 
00685FB0C  cbz      x26, #0x68606d8
00685FB10  mov      x25, x0
00685FB14  cbz      x0, #0x685fb2c
00685FB18  ldr      x8, [x26]
00685FB1C  mov      x0, x25
00685FB20  ldr      x1, [x8, #0x40]
00685FB24  bl       #0x382be90 ; 
00685FB28  cbz      x0, #0x68606e0
00685FB2C  ldr      w8, [x26, #0x18]
00685FB30  cbz      w8, #0x68606dc
00685FB34  mov      x0, x26
00685FB38  str      x25, [x0, #0x20]!
00685FB3C  mov      x1, x25
00685FB40  bl       #0x382bcb8 ; 
00685FB44  adrp     x8, #0x8ebf000
00685FB48  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685FB4C  add      x1, sp, #0x8c
00685FB50  ldr      x0, [x8]
00685FB54  ldr      w8, [sp, #0x6c]
00685FB58  str      w8, [sp, #0x8c]
00685FB5C  bl       #0x382be94 ; 
00685FB60  mov      x25, x0
00685FB64  cbz      x0, #0x685fb7c
00685FB68  ldr      x8, [x26]
00685FB6C  mov      x0, x25
00685FB70  ldr      x1, [x8, #0x40]
00685FB74  bl       #0x382be90 ; 
00685FB78  cbz      x0, #0x68606e0
00685FB7C  ldr      w8, [x26, #0x18]
00685FB80  cmp      w8, #1
00685FB84  b.ls     #0x68606dc
00685FB88  mov      x0, x26
00685FB8C  str      x25, [x0, #0x28]!
00685FB90  mov      x1, x25
00685FB94  bl       #0x382bcb8 ; 
00685FB98  adrp     x8, #0x8ebf000
00685FB9C  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685FBA0  add      x1, sp, #0x88
00685FBA4  str      w27, [sp, #0x88]
00685FBA8  ldr      x0, [x8]
00685FBAC  bl       #0x382be94 ; 
00685FBB0  mov      x25, x0
00685FBB4  cbz      x0, #0x685fbcc
00685FBB8  ldr      x8, [x26]
00685FBBC  mov      x0, x25
00685FBC0  ldr      x1, [x8, #0x40]
00685FBC4  bl       #0x382be90 ; 
00685FBC8  cbz      x0, #0x68606e0
00685FBCC  ldr      w8, [x26, #0x18]
00685FBD0  cmp      w8, #2
00685FBD4  b.ls     #0x68606dc
00685FBD8  mov      x0, x26
00685FBDC  str      x25, [x0, #0x30]!
00685FBE0  mov      x1, x25
00685FBE4  bl       #0x382bcb8 ; 
00685FBE8  adrp     x8, #0x8ebf000
00685FBEC  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685FBF0  add      x1, sp, #0x84
00685FBF4  str      w20, [sp, #0x84]
00685FBF8  ldr      x0, [x8]
00685FBFC  bl       #0x382be94 ; 
00685FC00  mov      x25, x0
00685FC04  cbz      x0, #0x685fc1c
00685FC08  ldr      x8, [x26]
00685FC0C  mov      x0, x25
00685FC10  ldr      x1, [x8, #0x40]
00685FC14  bl       #0x382be90 ; 
00685FC18  cbz      x0, #0x68606e0
00685FC1C  ldr      w8, [x26, #0x18]
00685FC20  cmp      w8, #3
00685FC24  b.ls     #0x68606dc
00685FC28  mov      x0, x26
00685FC2C  str      x25, [x0, #0x38]!
00685FC30  mov      x1, x25
00685FC34  bl       #0x382bcb8 ; 
00685FC38  adrp     x8, #0x8f23000
00685FC3C  ldr      x8, [x8, #0xc38] ; GLOBAL -[RandomSkill] 技能品质 = {0} 技能数量 = {1}  已学技能池数量 = {2}  技能池剩余数量 = {3} @ 0x92eab98
00685FC40  mov      x1, x26
00685FC44  mov      x2, xzr
00685FC48  ldr      x0, [x8]
00685FC4C  bl       #0x79e281c ; System.String$$Format
00685FC50  mov      x1, x0
00685FC54  mov      x0, x19
00685FC58  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
00685FC5C  cbz      w20, #0x685fc6c
00685FC60  ldr      w8, [sp, #0x6c]
00685FC64  orr      w8, w27, w8
00685FC68  cbnz     w8, #0x685fc7c
00685FC6C  ldr      w8, [x29, #0x18]
00685FC70  cmp      w8, #2
00685FC74  b.ls     #0x68606dc
00685FC78  str      wzr, [x28, x23, lsl #2]
00685FC7C  ldr      x25, [sp, #0x50]
00685FC80  ldr      x8, [sp, #0x60]
00685FC84  add      x23, x23, #1
00685FC88  ldr      w8, [x8, #0x18]
00685FC8C  cmp      w23, w8
00685FC90  b.lt     #0x685f81c
00685FC94  adrp     x8, #0x8f23000
00685FC98  ldr      x8, [x8, #0xc48] ; GLOBAL -[RandomSkill] 随机技能开始 @ 0x92eabc0
00685FC9C  mov      x0, x19
00685FCA0  ldr      x1, [x8]
00685FCA4  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
00685FCA8  ldr      x28, [sp, #0x48]
00685FCAC  b        #0x685fccc ; 
00685FCB0  adrp     x8, #0x8f23000
00685FCB4  ldr      x8, [x8, #0xc48] ; GLOBAL -[RandomSkill] 随机技能开始 @ 0x92eabc0
00685FCB8  mov      x0, x19
00685FCBC  ldr      x1, [x8]
00685FCC0  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
00685FCC4  cbz      x29, #0x68606d8
00685FCC8  str      wzr, [sp, #0x2c]
00685FCCC  ldr      w23, [x29, #0x18]
00685FCD0  ldr      w8, [sp, #0x44]
00685FCD4  str      x23, [sp, #0x48]
00685FCD8  tbz      w8, #0, #0x685fce8
00685FCDC  ldr      w8, [x28]
00685FCE0  str      w8, [sp, #0x50]
00685FCE4  b        #0x685fe98 ; 
00685FCE8  cmp      w23, #1
00685FCEC  b.lt     #0x685fd10
00685FCF0  mov      w20, wzr
00685FCF4  add      x8, x29, #0x20
00685FCF8  sxtw     x9, w23
00685FCFC  ldr      w10, [x8], #4
00685FD00  subs     x9, x9, #1
00685FD04  add      w20, w10, w20
00685FD08  b.ne     #0x685fcfc
00685FD0C  b        #0x685fd14 ; 
00685FD10  mov      w20, wzr
00685FD14  mov      x0, x19
00685FD18  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685FD1C  cbz      x0, #0x68606d8
00685FD20  adrp     x23, #0x9599000
00685FD24  ldrb     w8, [x23, #0xac6]
00685FD28  mov      x26, x0
00685FD2C  cbnz     w8, #0x685fd44
00685FD30  adrp     x0, #0x8f0d000
00685FD34  ldr      x0, [x0, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
00685FD38  bl       #0x382bd14 ; 
00685FD3C  mov      w8, #1
00685FD40  strb     w8, [x23, #0xac6]
00685FD44  adrp     x8, #0x8f0d000
00685FD48  ldr      x8, [x8, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
00685FD4C  ldr      x3, [x8]
00685FD50  ldrb     w8, [x3, #0x53]
00685FD54  tbnz     w8, #5, #0x685fd94
00685FD58  adrp     x23, #0x9599000
00685FD5C  ldrb     w8, [x23, #0xac7]
00685FD60  cbnz     w8, #0x685fd78
00685FD64  adrp     x0, #0x8f0d000
00685FD68  ldr      x0, [x0, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
00685FD6C  bl       #0x382bd14 ; 
00685FD70  mov      w8, #1
00685FD74  strb     w8, [x23, #0xac7]
00685FD78  adrp     x8, #0x8f0d000
00685FD7C  ldr      x8, [x8, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
00685FD80  ldr      x1, [x8]
00685FD84  ldrb     w8, [x1, #0x53]
00685FD88  tbnz     w8, #5, #0x685fdb0
00685FD8C  ldr      x0, [x26, #0x260]
00685FD90  b        #0x685fdbc ; 
00685FD94  ldr      x8, [x3, #0x60]
00685FD98  mov      x0, x26
00685FD9C  mov      w1, wzr
00685FDA0  mov      w2, w20
00685FDA4  blr      x8
00685FDA8  mov      w27, w0
00685FDAC  b        #0x685fde0 ; 
00685FDB0  ldr      x8, [x1, #0x60]
00685FDB4  mov      x0, x26
00685FDB8  blr      x8
00685FDBC  cbz      x0, #0x68606d8
00685FDC0  mov      w1, wzr
00685FDC4  mov      w2, w20
00685FDC8  mov      x3, xzr
00685FDCC  bl       #0x416d068 ; XXRandom$$Next
00685FDD0  ldr      w8, [x26, #0x32c]
00685FDD4  mov      w27, w0
00685FDD8  add      w8, w8, #1
00685FDDC  str      w8, [x26, #0x32c]
00685FDE0  adrp     x23, #0x8ebf000
00685FDE4  ldr      x23, [x23, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685FDE8  add      x1, sp, #0x78
00685FDEC  str      w27, [sp, #0x78]
00685FDF0  ldr      x0, [x23]
00685FDF4  bl       #0x382be94 ; 
00685FDF8  mov      x25, x0
00685FDFC  ldr      x0, [x23]
00685FE00  add      x1, sp, #0x8c
00685FE04  str      w20, [sp, #0x8c]
00685FE08  bl       #0x382be94 ; 
00685FE0C  adrp     x8, #0x8f23000
00685FE10  ldr      x8, [x8, #0xc40] ; GLOBAL -[RandomSkill] 随机出的curWeight = {0}   maxWeight = {1} @ 0x92eabb0
00685FE14  mov      x2, x0
00685FE18  mov      x1, x25
00685FE1C  mov      x3, xzr
00685FE20  ldr      x8, [x8]
00685FE24  mov      x0, x8
00685FE28  bl       #0x79e2794 ; System.String$$Format
00685FE2C  mov      x1, x0
00685FE30  mov      x0, x19
00685FE34  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
00685FE38  ldr      x23, [sp, #0x48]
00685FE3C  subs     w8, w23, #1
00685FE40  b.lt     #0x685fe78
00685FE44  ldr      w11, [x29, #0x18]
00685FE48  mov      w10, wzr
00685FE4C  mov      w9, wzr
00685FE50  cmp      w11, w9
00685FE54  b.eq     #0x68606dc
00685FE58  add      x12, x29, w9, sxtw #2
00685FE5C  ldr      w12, [x12, #0x20]
00685FE60  add      w10, w12, w10
00685FE64  cmp      w27, w10
00685FE68  b.lt     #0x685fe7c
00685FE6C  add      w9, w9, #1
00685FE70  cmp      w23, w9
00685FE74  b.ne     #0x685fe50
00685FE78  mov      w9, wzr
00685FE7C  ldr      w10, [sp, #0x20]
00685FE80  cmp      w9, w8
00685FE84  cset     w8, lt
00685FE88  and      w8, w8, w10
00685FE8C  add      w8, w9, w8
00685FE90  str      w8, [sp, #0x50]
00685FE94  str      w8, [x28]
00685FE98  mov      x0, x19
00685FE9C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685FEA0  cbz      x0, #0x68606d8
00685FEA4  ldrb     w8, [x0, #0x25]
00685FEA8  str      x24, [sp, #0x30]
00685FEAC  cbz      w8, #0x685fed0
00685FEB0  mov      x0, x19
00685FEB4  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685FEB8  cbz      x0, #0x68606d8
00685FEBC  ldr      w8, [x0, #0x28]
00685FEC0  sub      w8, w8, #1
00685FEC4  str      w8, [x28]
00685FEC8  str      w8, [sp, #0x50]
00685FECC  b        #0x685fed4 ; 
00685FED0  ldr      w8, [x28]
00685FED4  adrp     x24, #0x8ebf000
00685FED8  ldr      x24, [x24, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685FEDC  add      w8, w8, #1
00685FEE0  add      x1, sp, #0x78
00685FEE4  str      w8, [sp, #0x78]
00685FEE8  ldr      x0, [x24]
00685FEEC  bl       #0x382be94 ; 
00685FEF0  adrp     x8, #0x8f23000
00685FEF4  ldr      x8, [x8, #0xc50] ; GLOBAL -[RandomSkill] 随机出的品质 = {0} @ 0x92eabb8
00685FEF8  mov      x1, x0
00685FEFC  mov      x2, xzr
00685FF00  ldr      x8, [x8]
00685FF04  mov      x0, x8
00685FF08  bl       #0x79d140c ; System.String$$Format
00685FF0C  mov      x1, x0
00685FF10  mov      x0, x19
00685FF14  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
00685FF18  subs     w8, w23, #1
00685FF1C  str      w8, [sp, #0x44]
00685FF20  b.mi     #0x686054c
00685FF24  ldr      w8, [sp, #0x5c]
00685FF28  cmp      w8, #1
00685FF2C  b.lt     #0x686054c
00685FF30  ldr      w8, [sp, #0x6c]
00685FF34  ldr      w9, [sp, #0x2c]
00685FF38  ldr      w20, [sp, #0x5c]
00685FF3C  mov      w28, wzr
00685FF40  add      w8, w9, w8
00685FF44  str      w8, [sp, #4]
00685FF48  ldr      x8, [x19, #0x50]
00685FF4C  cbz      x8, #0x68606d8
00685FF50  ldr      w10, [sp, #0x50]
00685FF54  ldr      w9, [x8, #0x18]
00685FF58  add      w10, w10, w28
00685FF5C  sdiv     w11, w10, w23
00685FF60  msub     w23, w11, w23, w10
00685FF64  cmp      w23, w9
00685FF68  b.hs     #0x68606dc
00685FF6C  sxtw     x27, w23
00685FF70  add      x8, x8, x27, lsl #3
00685FF74  ldr      x29, [x8, #0x20]
00685FF78  cbz      w23, #0x685ffb0
00685FF7C  cmp      w23, #2
00685FF80  b.eq     #0x685ffb8
00685FF84  cmp      w23, #1
00685FF88  b.ne     #0x6860190
00685FF8C  ldr      w8, [sp, #0x40]
00685FF90  mov      w25, w8
00685FF94  cbnz     w8, #0x68601c4
00685FF98  ldr      x8, [x19, #0x30]
00685FF9C  cbz      x8, #0x68606d8
00685FFA0  ldr      w9, [x8, #0x18]
00685FFA4  cmp      w9, #1
00685FFA8  b.hi     #0x68601b8
00685FFAC  b        #0x68606dc ; 
00685FFB0  mov      w25, #0x3e8
00685FFB4  b        #0x68601c4 ; 
00685FFB8  adrp     x25, #0x8ee8000
00685FFBC  ldr      x25, [x25, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00685FFC0  ldr      x0, [x25]
00685FFC4  ldr      w8, [x0, #0xe0]
00685FFC8  cbnz     w8, #0x685ffd4
00685FFCC  bl       #0x382be8c ; 
00685FFD0  ldr      x0, [x25]
00685FFD4  ldr      x8, [x0, #0xb8]
00685FFD8  ldr      w8, [x8, #0x43c]
00685FFDC  cbz      w8, #0x6860198
00685FFE0  ldr      w8, [sp, #0x28]
00685FFE4  tbnz     w8, #0, #0x6860198
00685FFE8  ldr      w8, [sp, #0x6c]
00685FFEC  cbz      w8, #0x68601a4
00685FFF0  ldr      x9, [sp, #0x60]
00685FFF4  ldr      w8, [x9, #0x18]
00685FFF8  cmp      w8, #2
00685FFFC  b.ls     #0x68606dc
006860000  ldr      w8, [x9, #0x28]
006860004  ldr      x0, [x24]
006860008  add      x1, sp, #0x8c
00686000C  mov      x29, x24
006860010  str      x8, [sp, #0x20]
006860014  mov      w8, #2
006860018  str      w8, [sp, #0x8c]
00686001C  bl       #0x382be94 ; 
006860020  mov      x25, x0
006860024  ldr      x0, [x24]
006860028  ldr      w8, [sp, #0x6c]
00686002C  add      x1, sp, #0x88
006860030  str      w8, [sp, #0x88]
006860034  bl       #0x382be94 ; 
006860038  mov      x26, x0
00686003C  ldr      x0, [x24]
006860040  ldr      w8, [sp, #0x2c]
006860044  add      x1, sp, #0x84
006860048  str      w8, [sp, #0x84]
00686004C  bl       #0x382be94 ; 
006860050  adrp     x8, #0x8f23000
006860054  ldr      x8, [x8, #0xc60] ; GLOBAL -[RandomSkill] realIndex = {0} 技能数量 = {1}  superCount = {2}  @ 0x92eab80
006860058  mov      x3, x0
00686005C  mov      x1, x25
006860060  mov      x2, x26
006860064  ldr      x8, [x8]
006860068  mov      x4, xzr
00686006C  mov      x0, x8
006860070  bl       #0x79e27d8 ; System.String$$Format
006860074  mov      x1, x0
006860078  mov      x0, x19
00686007C  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
006860080  adrp     x25, #0x8ee8000
006860084  ldr      x25, [x25, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006860088  ldr      x0, [x25]
00686008C  ldr      w8, [x0, #0xe0]
006860090  cbnz     w8, #0x686009c
006860094  bl       #0x382be8c ; 
006860098  ldr      x0, [x25]
00686009C  ldr      x8, [x0, #0xb8]
0068600A0  ldr      x25, [x8, #0x430]
0068600A4  cbz      x25, #0x68606d8
0068600A8  adrp     x8, #0x8ebf000
0068600AC  ldr      x8, [x8, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
0068600B0  ldr      x0, [x8]
0068600B4  ldr      w8, [x0, #0xe0]
0068600B8  cbnz     w8, #0x68600c0
0068600BC  bl       #0x382be8c ; 
0068600C0  ldr      w8, [x25, #0x18]
0068600C4  ldr      w0, [sp, #4]
0068600C8  mov      x2, xzr
0068600CC  sub      w1, w8, #1
0068600D0  bl       #0x7bd69a0 ; System.Math$$Min
0068600D4  adrp     x8, #0x8ee8000
0068600D8  ldr      x8, [x8, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0068600DC  ldr      x8, [x8]
0068600E0  ldr      x8, [x8, #0xb8]
0068600E4  ldr      x8, [x8, #0x430]
0068600E8  cbz      x8, #0x68606d8
0068600EC  ldr      w9, [x8, #0x18]
0068600F0  cmp      w0, w9
0068600F4  b.hs     #0x68606dc
0068600F8  add      x8, x8, w0, sxtw #2
0068600FC  ldrsw    x25, [x8, #0x20]
006860100  mov      x0, x19
006860104  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006860108  cbz      x0, #0x68606d8
00686010C  adrp     x8, #0x9599000
006860110  ldrb     w8, [x8, #0xac6]
006860114  mov      x26, x0
006860118  cbnz     w8, #0x6860134
00686011C  adrp     x0, #0x8f0d000
006860120  ldr      x0, [x0, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
006860124  bl       #0x382bd14 ; 
006860128  adrp     x8, #0x9599000
00686012C  mov      w9, #1
006860130  strb     w9, [x8, #0xac6]
006860134  adrp     x8, #0x8f0d000
006860138  ldr      x8, [x8, #0x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.SkillRandomNext() @ 0x923fd60
00686013C  ldr      x9, [sp, #0x20]
006860140  ldr      x3, [x8]
006860144  add      w29, w9, #1
006860148  ldrb     w8, [x3, #0x53]
00686014C  tbnz     w8, #5, #0x68603a4
006860150  adrp     x8, #0x9599000
006860154  ldrb     w8, [x8, #0xac7]
006860158  cbnz     w8, #0x6860174
00686015C  adrp     x0, #0x8f0d000
006860160  ldr      x0, [x0, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
006860164  bl       #0x382bd14 ; 
006860168  mov      w8, #1
00686016C  adrp     x9, #0x9599000
006860170  strb     w8, [x9, #0xac7]
006860174  adrp     x8, #0x8f0d000
006860178  ldr      x8, [x8, #0x30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_SkillRandom() @ 0x923ffb0
00686017C  ldr      x1, [x8]
006860180  ldrb     w8, [x1, #0x53]
006860184  tbnz     w8, #5, #0x68603c0
006860188  ldr      x0, [x26, #0x260]
00686018C  b        #0x68603cc ; 
006860190  ldr      w25, [sp, #0x40]
006860194  b        #0x68601c4 ; 
006860198  ldr      w8, [sp, #0x6c]
00686019C  mov      w25, w8
0068601A0  cbnz     w8, #0x68601c4
0068601A4  ldr      x8, [x19, #0x30]
0068601A8  cbz      x8, #0x68606d8
0068601AC  ldr      w9, [x8, #0x18]
0068601B0  cmp      w9, #2
0068601B4  b.ls     #0x68606dc
0068601B8  add      x8, x8, x27, lsl #3
0068601BC  ldr      x29, [x8, #0x20]
0068601C0  mov      w25, wzr
0068601C4  ldr      x0, [x24]
0068601C8  add      x1, sp, #0x78
0068601CC  str      w23, [sp, #0x78]
0068601D0  bl       #0x382be94 ; 
0068601D4  mov      x26, x0
0068601D8  ldr      x0, [x24]
0068601DC  add      x1, sp, #0x8c
0068601E0  str      w25, [sp, #0x8c]
0068601E4  bl       #0x382be94 ; 
0068601E8  cbz      x29, #0x68606d8
0068601EC  mov      x25, x0
0068601F0  mov      x0, x29
0068601F4  mov      x1, x21
0068601F8  mov      x2, xzr
0068601FC  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
006860200  ldr      x8, [x24]
006860204  str      w0, [sp, #0x88]
006860208  add      x1, sp, #0x88
00686020C  mov      x0, x8
006860210  bl       #0x382be94 ; 
006860214  adrp     x8, #0x8f23000
006860218  ldr      x8, [x8, #0xc18] ; GLOBAL -[RandomSkill]-[Danke] realIndex = {0} newSkillCount = {1} count = {2} @ 0x92eabe0
00686021C  mov      x3, x0
006860220  mov      x1, x26
006860224  mov      x2, x25
006860228  ldr      x8, [x8]
00686022C  mov      x4, xzr
006860230  mov      x0, x8
006860234  bl       #0x79e27d8 ; System.String$$Format
006860238  mov      x1, x0
00686023C  mov      x0, x19
006860240  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
006860244  mov      x0, x29
006860248  mov      x1, x21
00686024C  mov      x2, xzr
006860250  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
006860254  cmp      w0, #1
006860258  b.lt     #0x68602cc
00686025C  adrp     x8, #0x8ebf000
006860260  ldr      x8, [x8, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
006860264  mov      w25, w0
006860268  ldr      x0, [x8]
00686026C  ldr      w8, [x0, #0xe0]
006860270  cbnz     w8, #0x6860278
006860274  bl       #0x382be8c ; 
006860278  mov      w0, w25
00686027C  mov      w1, w20
006860280  mov      x2, xzr
006860284  bl       #0x7bd69a0 ; System.Math$$Min
006860288  mov      w25, w0
00686028C  mov      x0, x29
006860290  mov      x1, x21
006860294  mov      x2, xzr
006860298  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
00686029C  mov      w1, w0
0068602A0  mov      w0, w25
0068602A4  mov      x2, xzr
0068602A8  bl       #0x7bd69a0 ; System.Math$$Min
0068602AC  ldp      x3, x4, [sp, #0x30]
0068602B0  mov      w25, w0
0068602B4  mov      x0, x29
0068602B8  mov      w1, w25
0068602BC  mov      x2, x21
0068602C0  mov      x5, xzr
0068602C4  bl       #0x6633c0c ; HotFix.BattleLogic.WeightRandom$$GetRandomCount
0068602C8  sub      w20, w20, w25
0068602CC  mov      x0, x29
0068602D0  mov      x1, x21
0068602D4  mov      x2, xzr
0068602D8  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
0068602DC  cmp      w20, #1
0068602E0  b.ne     #0x68602f8
0068602E4  cmp      w0, #1
0068602E8  b.lt     #0x68602f8
0068602EC  mov      x0, x29
0068602F0  mov      x1, xzr
0068602F4  bl       #0x6636154 ; HotFix.BattleLogic.WeightRandom$$LogAllId
0068602F8  ldr      x0, [x24]
0068602FC  add      x1, sp, #0x78
006860300  str      w23, [sp, #0x78]
006860304  bl       #0x382be94 ; 
006860308  cbz      x21, #0x68606d8
00686030C  adrp     x8, #0x8eea000
006860310  ldr      x8, [x8, #0xf18] ; GLOBAL Method$System.Collections.Generic.List<int>.ToArray() @ 0x921dec0
006860314  mov      x25, x0
006860318  mov      x0, x21
00686031C  ldr      x1, [x8]
006860320  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
006860324  adrp     x8, #0x8ec2000
006860328  ldr      x8, [x8, #0x4e0] ; GLOBAL , @ 0x92ea038
00686032C  adrp     x9, #0x8f09000
006860330  mov      x1, x0
006860334  ldr      x8, [x8]
006860338  ldr      x9, [x9, #0xa98] ; GLOBAL Method$System.String.Join<int>() @ 0x92b0100
00686033C  mov      x0, x8
006860340  ldr      x2, [x9]
006860344  bl       #0x4702f28 ; System.String$$Join<int>
006860348  adrp     x8, #0x8f23000
00686034C  ldr      x8, [x8, #0xc30] ; GLOBAL -[RandomSkill] 品质 = {0} 随机出的技能 = {1} @ 0x92eab88
006860350  mov      x2, x0
006860354  mov      x1, x25
006860358  mov      x3, xzr
00686035C  ldr      x8, [x8]
006860360  mov      x0, x8
006860364  bl       #0x79e2794 ; System.String$$Format
006860368  mov      x1, x0
00686036C  mov      x0, x19
006860370  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
006860374  ldr      w8, [sp, #0x5c]
006860378  cmp      w8, #1
00686037C  b.ne     #0x6860384
006860380  str      w23, [x19, #0x60]
006860384  ldr      w8, [sp, #0x44]
006860388  ldr      x23, [sp, #0x48]
00686038C  add      w28, w28, #1
006860390  cmp      w28, w8
006860394  b.gt     #0x686054c
006860398  cmp      w20, #0
00686039C  b.gt     #0x685ff48
0068603A0  b        #0x686054c ; 
0068603A4  ldr      x8, [x3, #0x60]
0068603A8  mov      x0, x26
0068603AC  mov      w1, wzr
0068603B0  mov      w2, w29
0068603B4  blr      x8
0068603B8  mov      w26, w0
0068603BC  b        #0x68603f0 ; 
0068603C0  ldr      x8, [x1, #0x60]
0068603C4  mov      x0, x26
0068603C8  blr      x8
0068603CC  cbz      x0, #0x68606d8
0068603D0  mov      w1, wzr
0068603D4  mov      w2, w29
0068603D8  mov      x3, xzr
0068603DC  bl       #0x416d068 ; XXRandom$$Next
0068603E0  ldr      w8, [x26, #0x32c]
0068603E4  add      w8, w8, #1
0068603E8  str      w8, [x26, #0x32c]
0068603EC  mov      x26, x0
0068603F0  ldr      x29, [sp, #0x20]
0068603F4  mov      x9, #0xd70b
0068603F8  movk     x9, #0x70a3, lsl #16
0068603FC  movk     x9, #0xa3d, lsl #32
006860400  sxtw     x8, w29
006860404  lsl      x8, x8, #0x10
006860408  mul      x8, x8, x25
00686040C  movk     x9, #0xa3d7, lsl #48
006860410  smulh    x9, x8, x9
006860414  str      x26, [sp, #0x10]
006860418  add      x8, x9, x8
00686041C  adrp     x9, #0x8ee2000
006860420  ldr      x9, [x9, #0x970] ; GLOBAL Photon.Deterministic.FP_TypeInfo @ 0x91e6728
006860424  add      x1, sp, #0x78
006860428  ldr      x0, [x9]
00686042C  asr      x9, x8, #6
006860430  add      x8, x9, x8, lsr #63
006860434  str      x8, [sp, #0x18]
006860438  str      x8, [sp, #0x78]
00686043C  bl       #0x382be94 ; 
006860440  str      x0, [sp, #8]
006860444  ldr      x0, [x24]
006860448  add      x1, sp, #0x74
00686044C  mov      x25, x24
006860450  str      w26, [sp, #0x74]
006860454  bl       #0x382be94 ; 
006860458  mov      x26, x0
00686045C  ldr      x0, [x24]
006860460  add      x1, sp, #0x70
006860464  str      w29, [sp, #0x70]
006860468  bl       #0x382be94 ; 
00686046C  adrp     x8, #0x8f23000
006860470  ldr      x8, [x8, #0xc20] ; GLOBAL -[RandomSkill] 已学技能权重 = {0} 随机值 = {1}  allWeight = {2} @ 0x92eab90
006860474  ldr      x1, [sp, #8]
006860478  mov      x3, x0
00686047C  mov      x2, x26
006860480  ldr      x8, [x8]
006860484  mov      x4, xzr
006860488  mov      x0, x8
00686048C  bl       #0x79e27d8 ; System.String$$Format
006860490  mov      x1, x0
006860494  mov      x0, x19
006860498  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
00686049C  ldp      x8, x9, [sp, #0x10]
0068604A0  sxtw     x8, w8
0068604A4  cmp      x9, x8, lsl #16
0068604A8  b.le     #0x68604f0
0068604AC  ldr      x8, [x19, #0x30]
0068604B0  cbz      x8, #0x68606d8
0068604B4  ldr      w9, [x8, #0x18]
0068604B8  cmp      w9, #2
0068604BC  b.ls     #0x68606dc
0068604C0  add      x8, x8, x27, lsl #3
0068604C4  ldr      x29, [x8, #0x20]
0068604C8  cbz      x29, #0x68606d8
0068604CC  mov      x0, x29
0068604D0  mov      x1, x21
0068604D4  mov      x2, xzr
0068604D8  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
0068604DC  ldr      w25, [sp, #0x6c]
0068604E0  cbnz     w0, #0x68601c4
0068604E4  ldr      x8, [x19, #0x38]
0068604E8  cbnz     x8, #0x6860530
0068604EC  b        #0x68606d8 ; 
0068604F0  ldr      x8, [x19, #0x38]
0068604F4  cbz      x8, #0x68606d8
0068604F8  ldr      w9, [x8, #0x18]
0068604FC  cmp      w9, #2
006860500  b.ls     #0x68606dc
006860504  add      x8, x8, x27, lsl #3
006860508  ldr      x29, [x8, #0x20]
00686050C  cbz      x29, #0x68606d8
006860510  mov      x0, x29
006860514  mov      x1, x21
006860518  mov      x2, xzr
00686051C  bl       #0x6632bd0 ; HotFix.BattleLogic.WeightRandom$$GetCount
006860520  ldr      w25, [sp, #0x6c]
006860524  cbnz     w0, #0x68601c4
006860528  ldr      x8, [x19, #0x30]
00686052C  cbz      x8, #0x68606d8
006860530  ldr      w9, [x8, #0x18]
006860534  cmp      w9, #2
006860538  b.ls     #0x68606dc
00686053C  add      x8, x8, x27, lsl #3
006860540  ldr      x29, [x8, #0x20]
006860544  ldr      w25, [sp, #0x6c]
006860548  b        #0x68601c4 ; 
00686054C  adrp     x23, #0x8ee8000
006860550  ldr      x23, [x23, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006860554  mov      w20, wzr
006860558  ldr      x0, [x23]
00686055C  ldr      w8, [x0, #0xe0]
006860560  cbnz     w8, #0x686056c
006860564  bl       #0x382be8c ; 
006860568  ldr      x0, [x23]
00686056C  ldr      x8, [x0, #0xb8]
006860570  ldr      w8, [x8, #0x2f0]
006860574  cmp      w20, w8
006860578  b.ge     #0x68605c8
00686057C  ldr      x8, [x19, #0x50]
006860580  cbz      x8, #0x68606d8
006860584  ldr      w9, [x8, #0x18]
006860588  cmp      w20, w9
00686058C  b.hs     #0x68606dc
006860590  cbz      x22, #0x68606d8
006860594  ldr      w9, [x22, #0x18]
006860598  cmp      w20, w9
00686059C  b.hs     #0x68606dc
0068605A0  sxtw     x9, w20
0068605A4  add      x8, x8, x9, lsl #3
0068605A8  ldr      x0, [x8, #0x20]
0068605AC  cbz      x0, #0x68606d8
0068605B0  add      x8, x22, x9, lsl #3
0068605B4  ldr      x1, [x8, #0x20]
0068605B8  mov      x2, xzr
0068605BC  bl       #0x6635c50 ; HotFix.BattleLogic.WeightRandom$$CopyWeightRandomFull
0068605C0  add      w20, w20, #1
0068605C4  b        #0x6860558 ; 
0068605C8  cbz      x21, #0x68606d8
0068605CC  ldr      w8, [x21, #0x18]
0068605D0  ldr      w9, [sp, #0x5c]
0068605D4  cmp      w8, w9
0068605D8  b.ge     #0x6860634
0068605DC  ldr      x0, [x24]
0068605E0  ldr      w8, [sp, #0x40]
0068605E4  add      x1, sp, #0x78
0068605E8  str      w8, [sp, #0x78]
0068605EC  bl       #0x382be94 ; 
0068605F0  mov      x20, x0
0068605F4  ldr      x0, [x24]
0068605F8  ldr      w8, [sp, #0x6c]
0068605FC  add      x1, sp, #0x8c
006860600  str      w8, [sp, #0x8c]
006860604  bl       #0x382be94 ; 
006860608  adrp     x8, #0x8f23000
00686060C  ldr      x8, [x8, #0xc58] ; GLOBAL -[RandomSkill]-[Danke] 剩余技能数量不足 无法随机出需要的技能  passiveSkillCount = {0}  weaponSkillCount = {1} @ 0x92eabe8
006860610  mov      x2, x0
006860614  mov      x1, x20
006860618  mov      x3, xzr
00686061C  ldr      x8, [x8]
006860620  mov      x0, x8
006860624  bl       #0x79e2794 ; System.String$$Format
006860628  mov      x1, x0
00686062C  mov      x0, x19
006860630  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
006860634  mov      x0, x19
006860638  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00686063C  adrp     x21, #0x9591000
006860640  cbz      x0, #0x68606d8
006860644  ldrb     w8, [x21, #0xa90]
006860648  mov      x20, x0
00686064C  cbnz     w8, #0x6860664
006860650  adrp     x0, #0x8ee6000
006860654  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006860658  bl       #0x382bd14 ; 
00686065C  mov      w8, #1
006860660  strb     w8, [x21, #0xa90]
006860664  adrp     x8, #0x8ee6000
006860668  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00686066C  ldr      x1, [x8]
006860670  ldrb     w8, [x1, #0x53]
006860674  tbnz     w8, #5, #0x6860680
006860678  ldr      x0, [x20, #0x230]
00686067C  b        #0x686068c ; 
006860680  ldr      x8, [x1, #0x60]
006860684  mov      x0, x20
006860688  blr      x8
00686068C  cbz      x0, #0x68606d8
006860690  adrp     x8, #0x8f08000
006860694  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
006860698  ldr      x1, [sp, #0x38]
00686069C  ldr      x2, [x8]
0068606A0  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
0068606A4  adrp     x8, #0x8f23000
0068606A8  ldr      x8, [x8, #0xc10] ; GLOBAL -[RandomSkill] 随机技能结束 @ 0x92eabc8
0068606AC  mov      x0, x19
0068606B0  ldr      x1, [x8]
0068606B4  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
0068606B8  ldp      x20, x19, [sp, #0xe0]
0068606BC  ldp      x22, x21, [sp, #0xd0]
0068606C0  ldp      x24, x23, [sp, #0xc0]
0068606C4  ldp      x26, x25, [sp, #0xb0]
0068606C8  ldp      x28, x27, [sp, #0xa0]
0068606CC  ldp      x29, x30, [sp, #0x90]
0068606D0  add      sp, sp, #0xf0
0068606D4  ret      
0068606D8  bl       #0x382bfb8 ; 
0068606DC  bl       #0x382bfc0 ; 
0068606E0  bl       #0x382bfdc ; 
0068606E4  mov      x1, xzr
0068606E8  bl       #0x382be7c ; 

