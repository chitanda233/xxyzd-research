; HotFix.BattleLogic.DankeSkillCreator$$TryUnlockUpgradeSkills
; RVA 0x686145C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00686145C  sub      sp, sp, #0x80
006861460  stp      x29, x30, [sp, #0x20]
006861464  stp      x28, x27, [sp, #0x30]
006861468  stp      x26, x25, [sp, #0x40]
00686146C  stp      x24, x23, [sp, #0x50]
006861470  stp      x22, x21, [sp, #0x60]
006861474  stp      x20, x19, [sp, #0x70]
006861478  adrp     x22, #0x959b000
00686147C  adrp     x23, #0x8f23000
006861480  ldrb     w8, [x22, #0x9f5]
006861484  ldr      x23, [x23, #0xcb8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.TryUnlockUpgradeSkills() @ 0x9259df0
006861488  mov      x19, x2
00686148C  mov      x20, x1
006861490  mov      x21, x0
006861494  tbnz     w8, #0, #0x68614f4
006861498  adrp     x0, #0x8ee8000
00686149C  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0068614A0  bl       #0x382bd14 ; 
0068614A4  adrp     x0, #0x8f23000
0068614A8  ldr      x0, [x0, #0xcb8] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.TryUnlockUpgradeSkills() @ 0x9259df0
0068614AC  bl       #0x382bd14 ; 
0068614B0  adrp     x0, #0x8ebf000
0068614B4  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
0068614B8  bl       #0x382bd14 ; 
0068614BC  adrp     x0, #0x8f08000
0068614C0  ldr      x0, [x0, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
0068614C4  bl       #0x382bd14 ; 
0068614C8  adrp     x0, #0x8ebf000
0068614CC  ldr      x0, [x0, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
0068614D0  bl       #0x382bd14 ; 
0068614D4  adrp     x0, #0x8ec2000
0068614D8  ldr      x0, [x0, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
0068614DC  bl       #0x382bd14 ; 
0068614E0  adrp     x0, #0x8f23000
0068614E4  ldr      x0, [x0, #0xcc0] ; GLOBAL -[TryUnlockUpgradeSkills] 解锁质变技能 chainIndex={0} upgradeSkillId={1} weight={2}  skillId = {3} @ 0x92eac08
0068614E8  bl       #0x382bd14 ; 
0068614EC  mov      w8, #1
0068614F0  strb     w8, [x22, #0x9f5]
0068614F4  ldr      x3, [x23]
0068614F8  ldrb     w8, [x3, #0x53]
0068614FC  tbnz     w8, #5, #0x6861580
006861500  adrp     x22, #0x8ee8000
006861504  ldr      x22, [x22, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006861508  ldr      x0, [x22]
00686150C  ldr      w8, [x0, #0xe0]
006861510  cbnz     w8, #0x6861518
006861514  bl       #0x382be8c ; 
006861518  adrp     x23, #0x959b000
00686151C  ldrb     w8, [x23, #0xb85]
006861520  cbnz     w8, #0x6861544
006861524  adrp     x0, #0x8efa000
006861528  ldr      x0, [x0, #0x120] ; GLOBAL Method$LocalModels.Const.IsSkillABTestB() @ 0x9255f38
00686152C  bl       #0x382bd14 ; 
006861530  adrp     x0, #0x8ee8000
006861534  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006861538  bl       #0x382bd14 ; 
00686153C  mov      w8, #1
006861540  strb     w8, [x23, #0xb85]
006861544  adrp     x8, #0x8efa000
006861548  ldr      x8, [x8, #0x120] ; GLOBAL Method$LocalModels.Const.IsSkillABTestB() @ 0x9255f38
00686154C  str      x20, [sp]
006861550  ldr      x0, [x8]
006861554  ldrb     w8, [x0, #0x53]
006861558  tbnz     w8, #5, #0x68615b0
00686155C  ldr      x0, [x22]
006861560  ldr      w8, [x0, #0xe0]
006861564  cbnz     w8, #0x6861570
006861568  bl       #0x382be8c ; 
00686156C  ldr      x0, [x22]
006861570  ldr      x8, [x0, #0xb8]
006861574  ldrb     w8, [x8, #0x530]
006861578  cbnz     w8, #0x6861b44
00686157C  b        #0x68615bc ; 
006861580  ldr      x4, [x3, #0x60]
006861584  mov      x0, x21
006861588  mov      x1, x20
00686158C  mov      x2, x19
006861590  ldp      x20, x19, [sp, #0x70]
006861594  ldp      x22, x21, [sp, #0x60]
006861598  ldp      x24, x23, [sp, #0x50]
00686159C  ldp      x26, x25, [sp, #0x40]
0068615A0  ldp      x28, x27, [sp, #0x30]
0068615A4  ldp      x29, x30, [sp, #0x20]
0068615A8  add      sp, sp, #0x80
0068615AC  br       x4
0068615B0  ldr      x8, [x0, #0x60]
0068615B4  blr      x8
0068615B8  tbnz     w0, #0, #0x6861b44
0068615BC  ldr      x20, [sp]
0068615C0  cbz      x20, #0x6861b68
0068615C4  adrp     x22, #0x959b000
0068615C8  ldrb     w8, [x22, #0xb86]
0068615CC  cbnz     w8, #0x68615e4
0068615D0  adrp     x0, #0x8f23000
0068615D4  ldr      x0, [x0, #0xcc8] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_UnlockUpgradeNeddSkill() @ 0x92ac580
0068615D8  bl       #0x382bd14 ; 
0068615DC  mov      w8, #1
0068615E0  strb     w8, [x22, #0xb86]
0068615E4  adrp     x8, #0x8f23000
0068615E8  ldr      x8, [x8, #0xcc8] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_UnlockUpgradeNeddSkill() @ 0x92ac580
0068615EC  ldr      x1, [x8]
0068615F0  ldrb     w8, [x1, #0x53]
0068615F4  tbnz     w8, #5, #0x6861600
0068615F8  ldr      x22, [x20, #0x48]
0068615FC  b        #0x6861610 ; 
006861600  ldr      x8, [x1, #0x60]
006861604  mov      x0, x20
006861608  blr      x8
00686160C  mov      x22, x0
006861610  adrp     x23, #0x959b000
006861614  ldrb     w8, [x23, #0xb87]
006861618  cbnz     w8, #0x6861630
00686161C  adrp     x0, #0x8f23000
006861620  ldr      x0, [x0, #0xcd0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_UnlockUpgradeId() @ 0x92ac578
006861624  bl       #0x382bd14 ; 
006861628  mov      w8, #1
00686162C  strb     w8, [x23, #0xb87]
006861630  adrp     x8, #0x8f23000
006861634  ldr      x8, [x8, #0xcd0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_UnlockUpgradeId() @ 0x92ac578
006861638  ldr      x1, [x8]
00686163C  ldrb     w8, [x1, #0x53]
006861640  tbnz     w8, #5, #0x6861650
006861644  ldr      x25, [x20, #0x50]
006861648  cbnz     x22, #0x6861664
00686164C  b        #0x6861b44 ; 
006861650  ldr      x8, [x1, #0x60]
006861654  mov      x0, x20
006861658  blr      x8
00686165C  mov      x25, x0
006861660  cbz      x22, #0x6861b44
006861664  cbz      x25, #0x6861b44
006861668  adrp     x8, #0x8ebf000
00686166C  ldr      x8, [x8, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
006861670  ldr      x0, [x8]
006861674  ldr      w8, [x0, #0xe0]
006861678  cbnz     w8, #0x6861680
00686167C  bl       #0x382be8c ; 
006861680  ldr      w0, [x22, #0x18]
006861684  ldr      w1, [x25, #0x18]
006861688  mov      x2, xzr
00686168C  bl       #0x7bd69a0 ; System.Math$$Min
006861690  cmp      w0, #1
006861694  b.lt     #0x6861b44
006861698  mov      x26, xzr
00686169C  mov      w24, w0
0068616A0  add      x23, x22, #0x20
0068616A4  add      x8, x25, #0x20
0068616A8  str      x8, [sp, #8]
0068616AC  ldr      w8, [x22, #0x18]
0068616B0  cmp      x26, x8
0068616B4  b.hs     #0x6861b64
0068616B8  ldr      w1, [x23, x26, lsl #2]
0068616BC  cbz      w1, #0x6861b38
0068616C0  cbz      x19, #0x6861b68
0068616C4  adrp     x8, #0x8f08000
0068616C8  ldr      x8, [x8, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
0068616CC  mov      x0, x19
0068616D0  ldr      x2, [x8]
0068616D4  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
0068616D8  tbz      w0, #0, #0x6861b38
0068616DC  ldr      w8, [x25, #0x18]
0068616E0  cmp      x26, x8
0068616E4  b.hs     #0x6861b64
0068616E8  ldr      x8, [sp, #8]
0068616EC  ldr      w8, [x8, x26, lsl #2]
0068616F0  cbz      w8, #0x6861b38
0068616F4  mov      x0, x21
0068616F8  mov      x20, x25
0068616FC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006861700  cbz      x0, #0x6861b68
006861704  adrp     x8, #0x9598000
006861708  ldrb     w8, [x8, #0xfcc]
00686170C  mov      x25, x0
006861710  cbnz     w8, #0x686172c
006861714  adrp     x0, #0x8f06000
006861718  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00686171C  bl       #0x382bd14 ; 
006861720  adrp     x8, #0x9598000
006861724  mov      w9, #1
006861728  strb     w9, [x8, #0xfcc]
00686172C  adrp     x8, #0x8f06000
006861730  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006861734  ldr      x1, [x8]
006861738  ldrb     w8, [x1, #0x53]
00686173C  tbnz     w8, #5, #0x6861748
006861740  ldr      x0, [x25, #0x200]
006861744  b        #0x6861754 ; 
006861748  ldr      x8, [x1, #0x60]
00686174C  mov      x0, x25
006861750  blr      x8
006861754  ldr      w8, [x20, #0x18]
006861758  cmp      x26, x8
00686175C  b.hs     #0x6861b64
006861760  cbz      x0, #0x6861b68
006861764  ldr      x8, [sp, #8]
006861768  mov      x2, xzr
00686176C  mov      x25, x20
006861770  ldr      w1, [x8, x26, lsl #2]
006861774  bl       #0x64deae8 ; LocalModels.LocalModelManager$$GetSkillGroup_UpgradeSkillGroup
006861778  cbz      x0, #0x6861b38
00686177C  adrp     x8, #0x959b000
006861780  ldrb     w8, [x8, #0xb88]
006861784  mov      x27, x0
006861788  cbnz     w8, #0x68617a4
00686178C  adrp     x0, #0x8f23000
006861790  ldr      x0, [x0, #0xcd8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_UpgradeSkillGroup.get_GetID() @ 0x92ab910
006861794  bl       #0x382bd14 ; 
006861798  mov      w8, #1
00686179C  adrp     x9, #0x959b000
0068617A0  strb     w8, [x9, #0xb88]
0068617A4  adrp     x8, #0x8f23000
0068617A8  ldr      x8, [x8, #0xcd8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_UpgradeSkillGroup.get_GetID() @ 0x92ab910
0068617AC  ldr      x1, [x8]
0068617B0  ldrb     w8, [x1, #0x53]
0068617B4  tbnz     w8, #5, #0x68617c0
0068617B8  ldr      w29, [x27, #0x24]
0068617BC  b        #0x68617d0 ; 
0068617C0  ldr      x8, [x1, #0x60]
0068617C4  mov      x0, x27
0068617C8  blr      x8
0068617CC  mov      w29, w0
0068617D0  adrp     x8, #0x959b000
0068617D4  ldrb     w8, [x8, #0xb89]
0068617D8  cbnz     w8, #0x68617f4
0068617DC  adrp     x0, #0x8f23000
0068617E0  ldr      x0, [x0, #0xce0] ; GLOBAL Method$LocalModels.Bean.SkillGroup_UpgradeSkillGroup.get_Weight() @ 0x92ab918
0068617E4  bl       #0x382bd14 ; 
0068617E8  mov      w8, #1
0068617EC  adrp     x9, #0x959b000
0068617F0  strb     w8, [x9, #0xb89]
0068617F4  adrp     x8, #0x8f23000
0068617F8  ldr      x8, [x8, #0xce0] ; GLOBAL Method$LocalModels.Bean.SkillGroup_UpgradeSkillGroup.get_Weight() @ 0x92ab918
0068617FC  ldr      x1, [x8]
006861800  ldrb     w8, [x1, #0x53]
006861804  tbnz     w8, #5, #0x6861810
006861808  ldr      w28, [x27, #0x28]
00686180C  b        #0x6861820 ; 
006861810  ldr      x8, [x1, #0x60]
006861814  mov      x0, x27
006861818  blr      x8
00686181C  mov      w28, w0
006861820  cmp      w28, #1
006861824  b.lt     #0x6861b38
006861828  mov      x0, x21
00686182C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006861830  cbz      x0, #0x6861b68
006861834  adrp     x8, #0x9598000
006861838  ldrb     w8, [x8, #0xfcc]
00686183C  mov      x25, x0
006861840  cbnz     w8, #0x686185c
006861844  adrp     x0, #0x8f06000
006861848  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00686184C  bl       #0x382bd14 ; 
006861850  adrp     x8, #0x9598000
006861854  mov      w9, #1
006861858  strb     w9, [x8, #0xfcc]
00686185C  adrp     x8, #0x8f06000
006861860  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006861864  ldr      x1, [x8]
006861868  ldrb     w8, [x1, #0x53]
00686186C  tbnz     w8, #5, #0x6861878
006861870  ldr      x0, [x25, #0x200]
006861874  b        #0x6861884 ; 
006861878  ldr      x8, [x1, #0x60]
00686187C  mov      x0, x25
006861880  blr      x8
006861884  cbz      x0, #0x6861b68
006861888  mov      w1, w29
00686188C  mov      x2, xzr
006861890  mov      x25, x20
006861894  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006861898  cbz      x0, #0x6861b38
00686189C  mov      w1, #1
0068618A0  mov      x2, xzr
0068618A4  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
0068618A8  ldr      x8, [x21, #0x48]
0068618AC  cbz      x8, #0x6861b68
0068618B0  ldr      w9, [x8, #0x18]
0068618B4  mov      w27, w0
0068618B8  cmp      w0, w9
0068618BC  b.hs     #0x6861b64
0068618C0  ldr      x9, [x21]
0068618C4  sxtw     x25, w27
0068618C8  add      x8, x8, x25, lsl #3
0068618CC  ldr      x1, [x8, #0x20]
0068618D0  ldr      x8, [x9, #0x228]
0068618D4  ldr      x5, [x9, #0x230]
0068618D8  mov      x0, x21
0068618DC  mov      w2, w29
0068618E0  mov      w3, w28
0068618E4  mov      x4, x19
0068618E8  blr      x8
0068618EC  ldr      x8, [x21, #0x18]
0068618F0  cbz      x8, #0x6861b68
0068618F4  ldr      w9, [x8, #0x18]
0068618F8  cmp      w27, w9
0068618FC  b.hs     #0x6861b64
006861900  ldr      x9, [x21]
006861904  add      x8, x8, x25, lsl #3
006861908  ldr      x1, [x8, #0x20]
00686190C  mov      x0, x21
006861910  ldr      x8, [x9, #0x228]
006861914  ldr      x5, [x9, #0x230]
006861918  mov      w2, w29
00686191C  mov      w3, w28
006861920  mov      x4, x19
006861924  blr      x8
006861928  ldr      x8, [x21, #0x30]
00686192C  cbz      x8, #0x6861b68
006861930  ldr      w9, [x8, #0x18]
006861934  cmp      w27, w9
006861938  b.hs     #0x6861b64
00686193C  ldr      x9, [x21]
006861940  add      x8, x8, x25, lsl #3
006861944  ldr      x1, [x8, #0x20]
006861948  mov      x0, x21
00686194C  ldr      x8, [x9, #0x228]
006861950  ldr      x5, [x9, #0x230]
006861954  mov      w2, w29
006861958  mov      w3, w28
00686195C  mov      x4, x19
006861960  blr      x8
006861964  adrp     x8, #0x8ec2000
006861968  ldr      x8, [x8, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
00686196C  mov      w1, #4
006861970  ldr      x0, [x8]
006861974  bl       #0x382bdfc ; 
006861978  adrp     x8, #0x8ebf000
00686197C  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006861980  mov      x27, x0
006861984  add      x1, sp, #0x1c
006861988  str      w26, [sp, #0x1c]
00686198C  ldr      x0, [x8]
006861990  bl       #0x382be94 ; 
006861994  cbz      x27, #0x6861b68
006861998  mov      x25, x0
00686199C  cbz      x0, #0x68619b4
0068619A0  ldr      x8, [x27]
0068619A4  mov      x0, x25
0068619A8  ldr      x1, [x8, #0x40]
0068619AC  bl       #0x382be90 ; 
0068619B0  cbz      x0, #0x6861b6c
0068619B4  ldr      w8, [x27, #0x18]
0068619B8  cbz      w8, #0x6861b64
0068619BC  mov      x0, x27
0068619C0  str      x25, [x0, #0x20]!
0068619C4  mov      x1, x25
0068619C8  bl       #0x382bcb8 ; 
0068619CC  adrp     x8, #0x8ebf000
0068619D0  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
0068619D4  add      x1, sp, #0x18
0068619D8  str      w29, [sp, #0x18]
0068619DC  ldr      x0, [x8]
0068619E0  bl       #0x382be94 ; 
0068619E4  mov      x25, x0
0068619E8  cbz      x0, #0x6861a00
0068619EC  ldr      x8, [x27]
0068619F0  mov      x0, x25
0068619F4  ldr      x1, [x8, #0x40]
0068619F8  bl       #0x382be90 ; 
0068619FC  cbz      x0, #0x6861b6c
006861A00  ldr      w8, [x27, #0x18]
006861A04  cmp      w8, #1
006861A08  b.ls     #0x6861b64
006861A0C  mov      x0, x27
006861A10  str      x25, [x0, #0x28]!
006861A14  mov      x1, x25
006861A18  bl       #0x382bcb8 ; 
006861A1C  adrp     x8, #0x8ebf000
006861A20  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006861A24  add      x1, sp, #0x14
006861A28  str      w28, [sp, #0x14]
006861A2C  ldr      x0, [x8]
006861A30  bl       #0x382be94 ; 
006861A34  mov      x25, x0
006861A38  cbz      x0, #0x6861a50
006861A3C  ldr      x8, [x27]
006861A40  mov      x0, x25
006861A44  ldr      x1, [x8, #0x40]
006861A48  bl       #0x382be90 ; 
006861A4C  cbz      x0, #0x6861b6c
006861A50  ldr      w8, [x27, #0x18]
006861A54  cmp      w8, #2
006861A58  b.ls     #0x6861b64
006861A5C  mov      x0, x27
006861A60  str      x25, [x0, #0x30]!
006861A64  mov      x1, x25
006861A68  bl       #0x382bcb8 ; 
006861A6C  adrp     x8, #0x9598000
006861A70  ldrb     w8, [x8, #0xde3]
006861A74  cbnz     w8, #0x6861a90
006861A78  adrp     x0, #0x8f00000
006861A7C  ldr      x0, [x0, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
006861A80  bl       #0x382bd14 ; 
006861A84  mov      w8, #1
006861A88  adrp     x9, #0x9598000
006861A8C  strb     w8, [x9, #0xde3]
006861A90  adrp     x8, #0x8f00000
006861A94  ldr      x8, [x8, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
006861A98  ldr      x1, [x8]
006861A9C  ldrb     w8, [x1, #0x53]
006861AA0  tbnz     w8, #5, #0x6861ab0
006861AA4  ldr      x8, [sp]
006861AA8  ldr      w0, [x8, #0x20]
006861AAC  b        #0x6861abc ; 
006861AB0  ldr      x8, [x1, #0x60]
006861AB4  ldr      x0, [sp]
006861AB8  blr      x8
006861ABC  adrp     x8, #0x8ebf000
006861AC0  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006861AC4  str      w0, [sp, #0x10]
006861AC8  add      x1, sp, #0x10
006861ACC  ldr      x8, [x8]
006861AD0  mov      x0, x8
006861AD4  bl       #0x382be94 ; 
006861AD8  mov      x25, x0
006861ADC  cbz      x0, #0x6861af4
006861AE0  ldr      x8, [x27]
006861AE4  mov      x0, x25
006861AE8  ldr      x1, [x8, #0x40]
006861AEC  bl       #0x382be90 ; 
006861AF0  cbz      x0, #0x6861b6c
006861AF4  ldr      w8, [x27, #0x18]
006861AF8  cmp      w8, #3
006861AFC  b.ls     #0x6861b64
006861B00  mov      x0, x27
006861B04  str      x25, [x0, #0x38]!
006861B08  mov      x1, x25
006861B0C  bl       #0x382bcb8 ; 
006861B10  adrp     x8, #0x8f23000
006861B14  ldr      x8, [x8, #0xcc0] ; GLOBAL -[TryUnlockUpgradeSkills] 解锁质变技能 chainIndex={0} upgradeSkillId={1} weight={2}  skillId = {3} @ 0x92eac08
006861B18  mov      x1, x27
006861B1C  mov      x2, xzr
006861B20  ldr      x0, [x8]
006861B24  bl       #0x79e281c ; System.String$$Format
006861B28  mov      x1, x0
006861B2C  mov      x0, x21
006861B30  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
006861B34  mov      x25, x20
006861B38  add      x26, x26, #1
006861B3C  cmp      x24, x26
006861B40  b.ne     #0x68616ac
006861B44  ldp      x20, x19, [sp, #0x70]
006861B48  ldp      x22, x21, [sp, #0x60]
006861B4C  ldp      x24, x23, [sp, #0x50]
006861B50  ldp      x26, x25, [sp, #0x40]
006861B54  ldp      x28, x27, [sp, #0x30]
006861B58  ldp      x29, x30, [sp, #0x20]
006861B5C  add      sp, sp, #0x80
006861B60  ret      
006861B64  bl       #0x382bfc0 ; 
006861B68  bl       #0x382bfb8 ; 
006861B6C  bl       #0x382bfdc ; 
006861B70  mov      x1, xzr
006861B74  bl       #0x382be7c ; 

