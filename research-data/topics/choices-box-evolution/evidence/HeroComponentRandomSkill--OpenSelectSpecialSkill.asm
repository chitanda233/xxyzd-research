; HotFix.BattleLogic.HeroComponentRandomSkill$$OpenSelectSpecialSkill
; RVA 0x6870474; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006870474  sub      sp, sp, #0x70
006870478  stp      x29, x30, [sp, #0x10]
00687047C  stp      x28, x27, [sp, #0x20]
006870480  stp      x26, x25, [sp, #0x30]
006870484  stp      x24, x23, [sp, #0x40]
006870488  stp      x22, x21, [sp, #0x50]
00687048C  stp      x20, x19, [sp, #0x60]
006870490  adrp     x20, #0x959b000
006870494  adrp     x22, #0x8f24000
006870498  ldrb     w8, [x20, #0xa62]
00687049C  ldr      x22, [x22, #0x328] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.OpenSelectSpecialSkill() @ 0x927fa68
0068704A0  mov      w21, w1
0068704A4  mov      x19, x0
0068704A8  tbnz     w8, #0, #0x6870514
0068704AC  adrp     x0, #0x8f09000
0068704B0  ldr      x0, [x0, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
0068704B4  bl       #0x382bd14 ; 
0068704B8  adrp     x0, #0x8ee6000
0068704BC  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0068704C0  bl       #0x382bd14 ; 
0068704C4  adrp     x0, #0x8f23000
0068704C8  ldr      x0, [x0, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
0068704CC  bl       #0x382bd14 ; 
0068704D0  adrp     x0, #0x8ee3000
0068704D4  ldr      x0, [x0, #0xf48] ; GLOBAL Method$System.Linq.Enumerable.ToArray<int>() @ 0x92658e8
0068704D8  bl       #0x382bd14 ; 
0068704DC  adrp     x0, #0x8f24000
0068704E0  ldr      x0, [x0, #0x328] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.OpenSelectSpecialSkill() @ 0x927fa68
0068704E4  bl       #0x382bd14 ; 
0068704E8  adrp     x0, #0x8ec2000
0068704EC  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
0068704F0  bl       #0x382bd14 ; 
0068704F4  adrp     x0, #0x8f08000
0068704F8  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
0068704FC  bl       #0x382bd14 ; 
006870500  adrp     x0, #0x8f08000
006870504  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
006870508  bl       #0x382bd14 ; 
00687050C  mov      w8, #1
006870510  strb     w8, [x20, #0xa62]
006870514  ldr      x2, [x22]
006870518  ldrb     w8, [x2, #0x53]
00687051C  tbnz     w8, #5, #0x6870564
006870520  ldrb     w8, [x19, #0x90]
006870524  cbnz     w8, #0x6870748
006870528  adrp     x26, #0x9591000
00687052C  ldrb     w8, [x26, #0xa4b]
006870530  cbnz     w8, #0x6870548
006870534  adrp     x0, #0x8ee5000
006870538  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00687053C  bl       #0x382bd14 ; 
006870540  mov      w8, #1
006870544  strb     w8, [x26, #0xa4b]
006870548  adrp     x27, #0x8ee5000
00687054C  ldr      x27, [x27, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006870550  ldr      x1, [x27]
006870554  ldrb     w8, [x1, #0x53]
006870558  tbnz     w8, #5, #0x6870590
00687055C  ldr      x20, [x19, #0x20]
006870560  b        #0x68705a0 ; 
006870564  ldr      x3, [x2, #0x60]
006870568  and      w1, w21, #1
00687056C  mov      x0, x19
006870570  ldp      x20, x19, [sp, #0x60]
006870574  ldp      x22, x21, [sp, #0x50]
006870578  ldp      x24, x23, [sp, #0x40]
00687057C  ldp      x26, x25, [sp, #0x30]
006870580  ldp      x28, x27, [sp, #0x20]
006870584  ldp      x29, x30, [sp, #0x10]
006870588  add      sp, sp, #0x70
00687058C  br       x3
006870590  ldr      x8, [x1, #0x60]
006870594  mov      x0, x19
006870598  blr      x8
00687059C  mov      x20, x0
0068705A0  cbz      x20, #0x6871260
0068705A4  adrp     x24, #0x9591000
0068705A8  ldrb     w8, [x24, #0xa90]
0068705AC  cbnz     w8, #0x68705c4
0068705B0  adrp     x0, #0x8ee6000
0068705B4  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
0068705B8  bl       #0x382bd14 ; 
0068705BC  mov      w8, #1
0068705C0  strb     w8, [x24, #0xa90]
0068705C4  adrp     x23, #0x8ee6000
0068705C8  ldr      x23, [x23, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
0068705CC  ldr      x1, [x23]
0068705D0  ldrb     w8, [x1, #0x53]
0068705D4  tbnz     w8, #5, #0x68705e0
0068705D8  ldr      x0, [x20, #0x230]
0068705DC  b        #0x68705ec ; 
0068705E0  ldr      x8, [x1, #0x60]
0068705E4  mov      x0, x20
0068705E8  blr      x8
0068705EC  cbz      x0, #0x6871260
0068705F0  adrp     x8, #0x8f08000
0068705F4  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
0068705F8  ldr      x1, [x8]
0068705FC  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006870600  str      wzr, [sp, #0xc]
006870604  adrp     x28, #0x9599000
006870608  ldrb     w8, [x28, #0x4c7]
00687060C  ldr      x22, [x19, #0x88]
006870610  mov      x20, x0
006870614  cbnz     w8, #0x687062c
006870618  adrp     x0, #0x8f09000
00687061C  ldr      x0, [x0, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
006870620  bl       #0x382bd14 ; 
006870624  mov      w8, #1
006870628  strb     w8, [x28, #0x4c7]
00687062C  adrp     x29, #0x8f09000
006870630  ldr      x29, [x29, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
006870634  ldr      x1, [x29]
006870638  ldrb     w8, [x1, #0x53]
00687063C  tbnz     w8, #5, #0x6870648
006870640  ldr      x2, [x19, #0x58]
006870644  b        #0x6870658 ; 
006870648  ldr      x8, [x1, #0x60]
00687064C  mov      x0, x19
006870650  blr      x8
006870654  mov      x2, x0
006870658  cbz      x22, #0x6871260
00687065C  ldr      x8, [x22]
006870660  add      x3, sp, #0xc
006870664  mov      x0, x22
006870668  mov      x1, x20
00687066C  ldr      x9, [x8, #0x2a8]
006870670  ldr      x4, [x8, #0x2b0]
006870674  blr      x9
006870678  tbz      w0, #0, #0x68706b0
00687067C  cbz      x20, #0x6871260
006870680  ldr      w8, [x20, #0x18]
006870684  cmp      w8, #1
006870688  b.lt     #0x68706b0
00687068C  mov      w8, #1
006870690  strb     w8, [x19, #0x90]
006870694  adrp     x8, #0x8f23000
006870698  ldr      x8, [x8, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
00687069C  ldr      x1, [x8]
0068706A0  ldrb     w8, [x1, #0x53]
0068706A4  tbnz     w8, #5, #0x687076c
0068706A8  ldr      x0, [x19, #0x30]
0068706AC  b        #0x6870778 ; 
0068706B0  ldrb     w8, [x26, #0xa4b]
0068706B4  cbnz     w8, #0x68706cc
0068706B8  adrp     x0, #0x8ee5000
0068706BC  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068706C0  bl       #0x382bd14 ; 
0068706C4  mov      w8, #1
0068706C8  strb     w8, [x26, #0xa4b]
0068706CC  ldr      x1, [x27]
0068706D0  ldrb     w8, [x1, #0x53]
0068706D4  tbnz     w8, #5, #0x68706e0
0068706D8  ldr      x19, [x19, #0x20]
0068706DC  b        #0x68706f0 ; 
0068706E0  ldr      x8, [x1, #0x60]
0068706E4  mov      x0, x19
0068706E8  blr      x8
0068706EC  mov      x19, x0
0068706F0  cbz      x19, #0x6871260
0068706F4  ldrb     w8, [x24, #0xa90]
0068706F8  cbnz     w8, #0x6870710
0068706FC  adrp     x0, #0x8ee6000
006870700  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006870704  bl       #0x382bd14 ; 
006870708  mov      w8, #1
00687070C  strb     w8, [x24, #0xa90]
006870710  ldr      x1, [x23]
006870714  ldrb     w8, [x1, #0x53]
006870718  tbnz     w8, #5, #0x6870724
00687071C  ldr      x0, [x19, #0x230]
006870720  b        #0x6870730 ; 
006870724  ldr      x8, [x1, #0x60]
006870728  mov      x0, x19
00687072C  blr      x8
006870730  cbz      x0, #0x6871260
006870734  adrp     x8, #0x8f08000
006870738  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
00687073C  mov      x1, x20
006870740  ldr      x2, [x8]
006870744  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
006870748  mov      w0, wzr
00687074C  ldp      x20, x19, [sp, #0x60]
006870750  ldp      x22, x21, [sp, #0x50]
006870754  ldp      x24, x23, [sp, #0x40]
006870758  ldp      x26, x25, [sp, #0x30]
00687075C  ldp      x28, x27, [sp, #0x20]
006870760  ldp      x29, x30, [sp, #0x10]
006870764  add      sp, sp, #0x70
006870768  ret      
00687076C  ldr      x8, [x1, #0x60]
006870770  mov      x0, x19
006870774  blr      x8
006870778  cbz      x0, #0x6871260
00687077C  adrp     x8, #0x8f09000
006870780  ldr      x8, [x8, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentExp>() @ 0x9210118
006870784  ldr      x1, [x8]
006870788  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00687078C  cbz      x0, #0x6871260
006870790  mov      x1, xzr
006870794  bl       #0x6857998 ; HotFix.BattleLogic.HeroComponentExp$$GetLevel
006870798  ldr      x22, [x19, #0x80]
00687079C  cbz      x22, #0x6871260
0068707A0  ldr      w8, [x22, #0x14]
0068707A4  strb     wzr, [x22, #0x24]
0068707A8  stp      w0, wzr, [x22, #0x1c]
0068707AC  add      w8, w8, #1
0068707B0  stp      w8, wzr, [x22, #0x14]
0068707B4  ldr      x23, [x19, #0x88]
0068707B8  cbz      x23, #0x6871260
0068707BC  adrp     x25, #0x959b000
0068707C0  ldrb     w8, [x25, #0xbb1]
0068707C4  cbnz     w8, #0x68707dc
0068707C8  adrp     x0, #0x8f24000
0068707CC  ldr      x0, [x0, #0x200] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.get_RandomIndex() @ 0x927fea0
0068707D0  bl       #0x382bd14 ; 
0068707D4  mov      w8, #1
0068707D8  strb     w8, [x25, #0xbb1]
0068707DC  adrp     x8, #0x8f24000
0068707E0  ldr      x8, [x8, #0x200] ; GLOBAL Method$HotFix.BattleLogic.HeroSkillCreator.get_RandomIndex() @ 0x927fea0
0068707E4  ldr      x1, [x8]
0068707E8  ldrb     w8, [x1, #0x53]
0068707EC  tbnz     w8, #5, #0x68707f8
0068707F0  ldr      w0, [x23, #0x60]
0068707F4  b        #0x6870804 ; 
0068707F8  ldr      x8, [x1, #0x60]
0068707FC  mov      x0, x23
006870800  blr      x8
006870804  adrp     x25, #0x959b000
006870808  ldrb     w8, [x25, #0xb91]
00687080C  add      w23, w0, #1
006870810  cbnz     w8, #0x6870828
006870814  adrp     x0, #0x8f23000
006870818  ldr      x0, [x0, #0xef0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_SkillQuality() @ 0x929ce98
00687081C  bl       #0x382bd14 ; 
006870820  mov      w8, #1
006870824  strb     w8, [x25, #0xb91]
006870828  adrp     x8, #0x8f23000
00687082C  ldr      x8, [x8, #0xef0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_SkillQuality() @ 0x929ce98
006870830  ldr      x2, [x8]
006870834  ldrb     w8, [x2, #0x53]
006870838  tbnz     w8, #5, #0x6870844
00687083C  str      w23, [x22, #0x68]
006870840  b        #0x6870854 ; 
006870844  ldr      x8, [x2, #0x60]
006870848  mov      x0, x22
00687084C  mov      w1, w23
006870850  blr      x8
006870854  ldr      x22, [x19, #0x80]
006870858  cbz      x22, #0x6871260
00687085C  strb     wzr, [x22, #0x26]
006870860  ldrb     w8, [x28, #0x4c7]
006870864  cbnz     w8, #0x687087c
006870868  adrp     x0, #0x8f09000
00687086C  ldr      x0, [x0, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.HeroComponentRandomSkill.get_AllSkills() @ 0x927faf0
006870870  bl       #0x382bd14 ; 
006870874  mov      w8, #1
006870878  strb     w8, [x28, #0x4c7]
00687087C  ldr      x1, [x29]
006870880  ldrb     w8, [x1, #0x53]
006870884  tbnz     w8, #5, #0x6870890
006870888  ldr      x1, [x19, #0x58]
00687088C  b        #0x68708a0 ; 
006870890  ldr      x8, [x1, #0x60]
006870894  mov      x0, x19
006870898  blr      x8
00687089C  mov      x1, x0
0068708A0  str      x1, [x22, #0x30]!
0068708A4  mov      x0, x22
0068708A8  bl       #0x382bcb8 ; 
0068708AC  ldr      x0, [x19, #0x80]
0068708B0  cbz      x0, #0x6871260
0068708B4  mov      x1, x20
0068708B8  bl       #0x6866748 ; HotFix.BattleLogic.RandomSkillResult$$InitByList
0068708BC  adrp     x8, #0x8ee3000
0068708C0  ldr      x22, [x19, #0x80]
0068708C4  ldr      x0, [x19, #0x50]
0068708C8  ldr      x8, [x8, #0xf48] ; GLOBAL Method$System.Linq.Enumerable.ToArray<int>() @ 0x92658e8
0068708CC  ldr      x1, [x8]
0068708D0  bl       #0x45d921c ; System.Linq.Enumerable$$ToArray<int>
0068708D4  cbz      x22, #0x6871260
0068708D8  adrp     x25, #0x959b000
0068708DC  ldrb     w8, [x25, #0xb95]
0068708E0  mov      x23, x0
0068708E4  cbnz     w8, #0x68708fc
0068708E8  adrp     x0, #0x8f23000
0068708EC  ldr      x0, [x0, #0xee0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_OwnSkills() @ 0x929ce70
0068708F0  bl       #0x382bd14 ; 
0068708F4  mov      w8, #1
0068708F8  strb     w8, [x25, #0xb95]
0068708FC  adrp     x8, #0x8f23000
006870900  ldr      x8, [x8, #0xee0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_OwnSkills() @ 0x929ce70
006870904  ldr      x2, [x8]
006870908  ldrb     w8, [x2, #0x53]
00687090C  tbnz     w8, #5, #0x6870924
006870910  str      x23, [x22, #0x58]!
006870914  mov      x0, x22
006870918  mov      x1, x23
00687091C  bl       #0x382bcb8 ; 
006870920  b        #0x6870934 ; 
006870924  ldr      x8, [x2, #0x60]
006870928  mov      x0, x22
00687092C  mov      x1, x23
006870930  blr      x8
006870934  ldrb     w8, [x26, #0xa4b]
006870938  ldr      x22, [x19, #0x80]
00687093C  cbnz     w8, #0x6870954
006870940  adrp     x0, #0x8ee5000
006870944  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006870948  bl       #0x382bd14 ; 
00687094C  mov      w8, #1
006870950  strb     w8, [x26, #0xa4b]
006870954  ldr      x1, [x27]
006870958  ldrb     w8, [x1, #0x53]
00687095C  tbnz     w8, #5, #0x6870968
006870960  ldr      x23, [x19, #0x20]
006870964  b        #0x6870978 ; 
006870968  ldr      x8, [x1, #0x60]
00687096C  mov      x0, x19
006870970  blr      x8
006870974  mov      x23, x0
006870978  cbz      x23, #0x6871260
00687097C  adrp     x29, #0x9598000
006870980  ldrb     w8, [x29, #0xfc4]
006870984  cbnz     w8, #0x687099c
006870988  adrp     x0, #0x8f05000
00687098C  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006870990  bl       #0x382bd14 ; 
006870994  mov      w8, #1
006870998  strb     w8, [x29, #0xfc4]
00687099C  adrp     x28, #0x8f05000
0068709A0  ldr      x28, [x28, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0068709A4  ldr      x1, [x28]
0068709A8  ldrb     w8, [x1, #0x53]
0068709AC  tbnz     w8, #5, #0x68709b8
0068709B0  ldr      x0, [x23, #0x220]
0068709B4  b        #0x68709c4 ; 
0068709B8  ldr      x8, [x1, #0x60]
0068709BC  mov      x0, x23
0068709C0  blr      x8
0068709C4  cbz      x0, #0x6871260
0068709C8  mov      x1, xzr
0068709CC  bl       #0x6585324 ; HotFix.BattleLogic.BattleManager$$IsBossWave
0068709D0  cbz      x22, #0x6871260
0068709D4  adrp     x25, #0x959b000
0068709D8  ldrb     w8, [x25, #0xb97]
0068709DC  mov      w23, w0
0068709E0  cbnz     w8, #0x68709f8
0068709E4  adrp     x0, #0x8f23000
0068709E8  ldr      x0, [x0, #0xe80] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsBossWave() @ 0x929ce50
0068709EC  bl       #0x382bd14 ; 
0068709F0  mov      w8, #1
0068709F4  strb     w8, [x25, #0xb97]
0068709F8  adrp     x8, #0x8f23000
0068709FC  ldr      x8, [x8, #0xe80] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsBossWave() @ 0x929ce50
006870A00  ldr      x2, [x8]
006870A04  ldrb     w8, [x2, #0x53]
006870A08  tbnz     w8, #5, #0x6870a18
006870A0C  and      w8, w23, #1
006870A10  strb     w8, [x22, #0x3c]
006870A14  b        #0x6870a28 ; 
006870A18  ldr      x8, [x2, #0x60]
006870A1C  and      w1, w23, #1
006870A20  mov      x0, x22
006870A24  blr      x8
006870A28  ldr      x22, [x19, #0x80]
006870A2C  cbz      x22, #0x6871260
006870A30  adrp     x23, #0x959b000
006870A34  ldrb     w8, [x23, #0xb99]
006870A38  cbnz     w8, #0x6870a50
006870A3C  adrp     x0, #0x8f23000
006870A40  ldr      x0, [x0, #0xeb0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsChapterSurvivor() @ 0x929ce58
006870A44  bl       #0x382bd14 ; 
006870A48  mov      w8, #1
006870A4C  strb     w8, [x23, #0xb99]
006870A50  adrp     x8, #0x8f23000
006870A54  ldr      x8, [x8, #0xeb0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsChapterSurvivor() @ 0x929ce58
006870A58  ldr      x2, [x8]
006870A5C  ldrb     w8, [x2, #0x53]
006870A60  tbnz     w8, #5, #0x6870a6c
006870A64  strb     wzr, [x22, #0x48]
006870A68  b        #0x6870a7c ; 
006870A6C  ldr      x8, [x2, #0x60]
006870A70  mov      x0, x22
006870A74  mov      w1, wzr
006870A78  blr      x8
006870A7C  ldrb     w8, [x26, #0xa4b]
006870A80  cbnz     w8, #0x6870a98
006870A84  adrp     x0, #0x8ee5000
006870A88  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006870A8C  bl       #0x382bd14 ; 
006870A90  mov      w8, #1
006870A94  strb     w8, [x26, #0xa4b]
006870A98  ldr      x1, [x27]
006870A9C  ldrb     w8, [x1, #0x53]
006870AA0  tbnz     w8, #5, #0x6870aac
006870AA4  ldr      x22, [x19, #0x20]
006870AA8  b        #0x6870abc ; 
006870AAC  ldr      x8, [x1, #0x60]
006870AB0  mov      x0, x19
006870AB4  blr      x8
006870AB8  mov      x22, x0
006870ABC  cbz      x22, #0x6871260
006870AC0  ldrb     w8, [x29, #0xfc4]
006870AC4  cbnz     w8, #0x6870adc
006870AC8  adrp     x0, #0x8f05000
006870ACC  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006870AD0  bl       #0x382bd14 ; 
006870AD4  mov      w8, #1
006870AD8  strb     w8, [x29, #0xfc4]
006870ADC  ldr      x1, [x28]
006870AE0  ldrb     w8, [x1, #0x53]
006870AE4  tbnz     w8, #5, #0x6870af0
006870AE8  ldr      x0, [x22, #0x220]
006870AEC  b        #0x6870afc ; 
006870AF0  ldr      x8, [x1, #0x60]
006870AF4  mov      x0, x22
006870AF8  blr      x8
006870AFC  cbz      x0, #0x6871260
006870B00  ldr      x8, [x0]
006870B04  ldp      x9, x1, [x8, #0x1a8]
006870B08  blr      x9
006870B0C  tbz      w0, #0, #0x6870bec
006870B10  ldrb     w8, [x26, #0xa4b]
006870B14  cbnz     w8, #0x6870b2c
006870B18  adrp     x0, #0x8ee5000
006870B1C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006870B20  bl       #0x382bd14 ; 
006870B24  mov      w8, #1
006870B28  strb     w8, [x26, #0xa4b]
006870B2C  ldr      x1, [x27]
006870B30  ldrb     w8, [x1, #0x53]
006870B34  tbnz     w8, #5, #0x6870b40
006870B38  ldr      x22, [x19, #0x20]
006870B3C  b        #0x6870b50 ; 
006870B40  ldr      x8, [x1, #0x60]
006870B44  mov      x0, x19
006870B48  blr      x8
006870B4C  mov      x22, x0
006870B50  cbz      x22, #0x6871260
006870B54  adrp     x23, #0x9599000
006870B58  ldrb     w8, [x23, #0x29b]
006870B5C  cbnz     w8, #0x6870b74
006870B60  adrp     x0, #0x8f08000
006870B64  ldr      x0, [x0, #0x68] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_pauseEntity() @ 0x9240020
006870B68  bl       #0x382bd14 ; 
006870B6C  mov      w8, #1
006870B70  strb     w8, [x23, #0x29b]
006870B74  adrp     x8, #0x8f08000
006870B78  ldr      x8, [x8, #0x68] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_pauseEntity() @ 0x9240020
006870B7C  ldr      x1, [x8]
006870B80  ldrb     w8, [x1, #0x53]
006870B84  tbnz     w8, #5, #0x6870b90
006870B88  ldr      w0, [x22, #0x18c]
006870B8C  b        #0x6870b9c ; 
006870B90  ldr      x8, [x1, #0x60]
006870B94  mov      x0, x22
006870B98  blr      x8
006870B9C  adrp     x25, #0x9599000
006870BA0  ldrb     w8, [x25, #0x4be]
006870BA4  add      w23, w0, #1
006870BA8  cbnz     w8, #0x6870bc0
006870BAC  adrp     x0, #0x8f08000
006870BB0  ldr      x0, [x0, #0xe90] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_pauseEntity() @ 0x9240110
006870BB4  bl       #0x382bd14 ; 
006870BB8  mov      w8, #1
006870BBC  strb     w8, [x25, #0x4be]
006870BC0  adrp     x8, #0x8f08000
006870BC4  ldr      x8, [x8, #0xe90] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_pauseEntity() @ 0x9240110
006870BC8  ldr      x2, [x8]
006870BCC  ldrb     w8, [x2, #0x53]
006870BD0  tbnz     w8, #5, #0x6870bdc
006870BD4  str      w23, [x22, #0x18c]
006870BD8  b        #0x6870bec ; 
006870BDC  ldr      x8, [x2, #0x60]
006870BE0  mov      x0, x22
006870BE4  mov      w1, w23
006870BE8  blr      x8
006870BEC  ldrb     w8, [x26, #0xa4b]
006870BF0  cbnz     w8, #0x6870c08
006870BF4  adrp     x0, #0x8ee5000
006870BF8  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006870BFC  bl       #0x382bd14 ; 
006870C00  mov      w8, #1
006870C04  strb     w8, [x26, #0xa4b]
006870C08  ldr      x1, [x27]
006870C0C  ldrb     w8, [x1, #0x53]
006870C10  tbnz     w8, #5, #0x6870c1c
006870C14  ldr      x0, [x19, #0x20]
006870C18  b        #0x6870c28 ; 
006870C1C  ldr      x8, [x1, #0x60]
006870C20  mov      x0, x19
006870C24  blr      x8
006870C28  cbz      x0, #0x6871260
006870C2C  mov      x1, xzr
006870C30  bl       #0x6a005a4 ; HotFix.BattleLogic.BattleWorldContext$$IsMultiPlayerBattle
006870C34  tbnz     w0, #0, #0x6870c84
006870C38  ldrb     w8, [x26, #0xa4b]
006870C3C  cbnz     w8, #0x6870c54
006870C40  adrp     x0, #0x8ee5000
006870C44  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006870C48  bl       #0x382bd14 ; 
006870C4C  mov      w8, #1
006870C50  strb     w8, [x26, #0xa4b]
006870C54  ldr      x1, [x27]
006870C58  ldrb     w8, [x1, #0x53]
006870C5C  tbnz     w8, #5, #0x6870c68
006870C60  ldr      x0, [x19, #0x20]
006870C64  b        #0x6870c74 ; 
006870C68  ldr      x8, [x1, #0x60]
006870C6C  mov      x0, x19
006870C70  blr      x8
006870C74  cbz      x0, #0x6871260
006870C78  mov      w1, #4
006870C7C  mov      x2, xzr
006870C80  bl       #0x6a052e4 ; HotFix.BattleLogic.BattleWorldContext$$SetBattleFlag
006870C84  ldrb     w8, [x26, #0xa4b]
006870C88  ldr      x22, [x19, #0x80]
006870C8C  cbnz     w8, #0x6870ca4
006870C90  adrp     x0, #0x8ee5000
006870C94  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006870C98  bl       #0x382bd14 ; 
006870C9C  mov      w8, #1
006870CA0  strb     w8, [x26, #0xa4b]
006870CA4  ldr      x1, [x27]
006870CA8  ldrb     w8, [x1, #0x53]
006870CAC  tbnz     w8, #5, #0x6870cb8
006870CB0  ldr      x23, [x19, #0x20]
006870CB4  b        #0x6870cc8 ; 
006870CB8  ldr      x8, [x1, #0x60]
006870CBC  mov      x0, x19
006870CC0  blr      x8
006870CC4  mov      x23, x0
006870CC8  cbz      x23, #0x6871260
006870CCC  ldrb     w8, [x29, #0xfc4]
006870CD0  cbnz     w8, #0x6870ce8
006870CD4  adrp     x0, #0x8f05000
006870CD8  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006870CDC  bl       #0x382bd14 ; 
006870CE0  mov      w8, #1
006870CE4  strb     w8, [x29, #0xfc4]
006870CE8  ldr      x1, [x28]
006870CEC  ldrb     w8, [x1, #0x53]
006870CF0  tbnz     w8, #5, #0x6870cfc
006870CF4  ldr      x0, [x23, #0x220]
006870CF8  b        #0x6870d08 ; 
006870CFC  ldr      x8, [x1, #0x60]
006870D00  mov      x0, x23
006870D04  blr      x8
006870D08  cbz      x0, #0x6871260
006870D0C  ldr      x8, [x0]
006870D10  ldr      x9, [x8, #0x518]
006870D14  ldr      x1, [x8, #0x520]
006870D18  blr      x9
006870D1C  cbz      x22, #0x6871260
006870D20  adrp     x25, #0x959b000
006870D24  ldrb     w8, [x25, #0xb9f]
006870D28  mov      w23, w0
006870D2C  cbnz     w8, #0x6870d44
006870D30  adrp     x0, #0x8f23000
006870D34  ldr      x0, [x0, #0xe90] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_Wave() @ 0x929cea8
006870D38  bl       #0x382bd14 ; 
006870D3C  mov      w8, #1
006870D40  strb     w8, [x25, #0xb9f]
006870D44  adrp     x8, #0x8f23000
006870D48  ldr      x8, [x8, #0xe90] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_Wave() @ 0x929cea8
006870D4C  ldr      x2, [x8]
006870D50  ldrb     w8, [x2, #0x53]
006870D54  tbnz     w8, #5, #0x6870d60
006870D58  str      w23, [x22, #0x40]
006870D5C  b        #0x6870d70 ; 
006870D60  ldr      x8, [x2, #0x60]
006870D64  mov      x0, x22
006870D68  mov      w1, w23
006870D6C  blr      x8
006870D70  ldrb     w8, [x26, #0xa4b]
006870D74  ldr      x22, [x19, #0x80]
006870D78  cbnz     w8, #0x6870d90
006870D7C  adrp     x0, #0x8ee5000
006870D80  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006870D84  bl       #0x382bd14 ; 
006870D88  mov      w8, #1
006870D8C  strb     w8, [x26, #0xa4b]
006870D90  ldr      x1, [x27]
006870D94  ldrb     w8, [x1, #0x53]
006870D98  tbnz     w8, #5, #0x6870da4
006870D9C  ldr      x23, [x19, #0x20]
006870DA0  b        #0x6870db4 ; 
006870DA4  ldr      x8, [x1, #0x60]
006870DA8  mov      x0, x19
006870DAC  blr      x8
006870DB0  mov      x23, x0
006870DB4  cbz      x23, #0x6871260
006870DB8  ldrb     w8, [x29, #0xfc4]
006870DBC  cbnz     w8, #0x6870dd4
006870DC0  adrp     x0, #0x8f05000
006870DC4  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006870DC8  bl       #0x382bd14 ; 
006870DCC  mov      w8, #1
006870DD0  strb     w8, [x29, #0xfc4]
006870DD4  ldr      x1, [x28]
006870DD8  ldrb     w8, [x1, #0x53]
006870DDC  tbnz     w8, #5, #0x6870de8
006870DE0  ldr      x0, [x23, #0x220]
006870DE4  b        #0x6870df4 ; 
006870DE8  ldr      x8, [x1, #0x60]
006870DEC  mov      x0, x23
006870DF0  blr      x8
006870DF4  adrp     x28, #0x8f23000
006870DF8  ldr      x28, [x28, #0x140] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityHero>.get_Entity() @ 0x9210268
006870DFC  cbz      x0, #0x6871260
006870E00  ldr      x8, [x0]
006870E04  ldr      x9, [x8, #0x528]
006870E08  ldr      x1, [x8, #0x530]
006870E0C  blr      x9
006870E10  cbz      x22, #0x6871260
006870E14  adrp     x25, #0x959b000
006870E18  ldrb     w8, [x25, #0xba1]
006870E1C  mov      w23, w0
006870E20  cbnz     w8, #0x6870e38
006870E24  adrp     x0, #0x8f23000
006870E28  ldr      x0, [x0, #0xe70] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_ShowWave() @ 0x929ce90
006870E2C  bl       #0x382bd14 ; 
006870E30  mov      w8, #1
006870E34  strb     w8, [x25, #0xba1]
006870E38  adrp     x8, #0x8f23000
006870E3C  ldr      x8, [x8, #0xe70] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_ShowWave() @ 0x929ce90
006870E40  ldr      x2, [x8]
006870E44  ldrb     w8, [x2, #0x53]
006870E48  tbnz     w8, #5, #0x6870e54
006870E4C  str      w23, [x22, #0x38]
006870E50  b        #0x6870e64 ; 
006870E54  ldr      x8, [x2, #0x60]
006870E58  mov      x0, x22
006870E5C  mov      w1, w23
006870E60  blr      x8
006870E64  ldr      x1, [x28]
006870E68  ldr      x22, [x19, #0x80]
006870E6C  ldrb     w8, [x1, #0x53]
006870E70  tbnz     w8, #5, #0x6870e7c
006870E74  ldr      x0, [x19, #0x30]
006870E78  b        #0x6870e88 ; 
006870E7C  ldr      x8, [x1, #0x60]
006870E80  mov      x0, x19
006870E84  blr      x8
006870E88  cbz      x0, #0x6871260
006870E8C  adrp     x8, #0x8ee6000
006870E90  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006870E94  ldr      x1, [x8]
006870E98  ldrb     w8, [x1, #0x53]
006870E9C  tbnz     w8, #5, #0x6870ea8
006870EA0  ldr      x23, [x0, #0x38]
006870EA4  b        #0x6870eb4 ; 
006870EA8  ldr      x8, [x1, #0x60]
006870EAC  blr      x8
006870EB0  mov      x23, x0
006870EB4  cbz      x23, #0x6871260
006870EB8  adrp     x25, #0x9591000
006870EBC  ldrb     w8, [x25, #0xa7f]
006870EC0  cbnz     w8, #0x6870ed8
006870EC4  adrp     x0, #0x8ee6000
006870EC8  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006870ECC  bl       #0x382bd14 ; 
006870ED0  mov      w8, #1
006870ED4  strb     w8, [x25, #0xa7f]
006870ED8  adrp     x8, #0x8ee6000
006870EDC  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006870EE0  ldr      x1, [x8]
006870EE4  ldrb     w8, [x1, #0x53]
006870EE8  tbnz     w8, #5, #0x6870ef4
006870EEC  ldr      x0, [x23, #0x178]
006870EF0  b        #0x6870f00 ; 
006870EF4  ldr      x8, [x1, #0x60]
006870EF8  mov      x0, x23
006870EFC  blr      x8
006870F00  cbz      x0, #0x6871260
006870F04  mov      x1, xzr
006870F08  bl       #0x6b3cf00 ; HotFix.Common.AttributeData$$GetAttack
006870F0C  cbz      x22, #0x6871260
006870F10  adrp     x25, #0x959b000
006870F14  ldrb     w8, [x25, #0xb9b]
006870F18  lsr      x23, x0, #0x10
006870F1C  cbnz     w8, #0x6870f34
006870F20  adrp     x0, #0x8f23000
006870F24  ldr      x0, [x0, #0xec0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_PlayerCurAttack() @ 0x929ce78
006870F28  bl       #0x382bd14 ; 
006870F2C  mov      w8, #1
006870F30  strb     w8, [x25, #0xb9b]
006870F34  adrp     x8, #0x8f23000
006870F38  ldr      x8, [x8, #0xec0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_PlayerCurAttack() @ 0x929ce78
006870F3C  ldr      x2, [x8]
006870F40  ldrb     w8, [x2, #0x53]
006870F44  tbnz     w8, #5, #0x6870f50
006870F48  str      w23, [x22, #0x4c]
006870F4C  b        #0x6870f60 ; 
006870F50  ldr      x8, [x2, #0x60]
006870F54  mov      x0, x22
006870F58  mov      w1, w23
006870F5C  blr      x8
006870F60  ldr      x1, [x28]
006870F64  ldr      x22, [x19, #0x80]
006870F68  ldrb     w8, [x1, #0x53]
006870F6C  tbnz     w8, #5, #0x6870f78
006870F70  ldr      x0, [x19, #0x30]
006870F74  b        #0x6870f84 ; 
006870F78  ldr      x8, [x1, #0x60]
006870F7C  mov      x0, x19
006870F80  blr      x8
006870F84  cbz      x0, #0x6871260
006870F88  ldr      x8, [x0]
006870F8C  ldr      x9, [x8, #0x498]
006870F90  ldr      x1, [x8, #0x4a0]
006870F94  blr      x9
006870F98  cbz      x22, #0x6871260
006870F9C  adrp     x25, #0x959b000
006870FA0  ldrb     w8, [x25, #0xb9d]
006870FA4  mov      w23, w0
006870FA8  cbnz     w8, #0x6870fc0
006870FAC  adrp     x0, #0x8f23000
006870FB0  ldr      x0, [x0, #0xed0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_PlayerCurHp() @ 0x929ce80
006870FB4  bl       #0x382bd14 ; 
006870FB8  mov      w8, #1
006870FBC  strb     w8, [x25, #0xb9d]
006870FC0  adrp     x8, #0x8f23000
006870FC4  ldr      x8, [x8, #0xed0] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_PlayerCurHp() @ 0x929ce80
006870FC8  ldr      x2, [x8]
006870FCC  ldrb     w8, [x2, #0x53]
006870FD0  tbnz     w8, #5, #0x6870fdc
006870FD4  str      w23, [x22, #0x50]
006870FD8  b        #0x6870fec ; 
006870FDC  ldr      x8, [x2, #0x60]
006870FE0  mov      x0, x22
006870FE4  mov      w1, w23
006870FE8  blr      x8
006870FEC  ldr      x22, [x19, #0x80]
006870FF0  cbz      x22, #0x6871260
006870FF4  adrp     x23, #0x959b000
006870FF8  ldrb     w8, [x23, #0xba3]
006870FFC  cbnz     w8, #0x6871014
006871000  adrp     x0, #0x8f23000
006871004  ldr      x0, [x0, #0xf00] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsGuideOverride() @ 0x929ce60
006871008  bl       #0x382bd14 ; 
00687100C  mov      w8, #1
006871010  strb     w8, [x23, #0xba3]
006871014  adrp     x8, #0x8f23000
006871018  ldr      x8, [x8, #0xf00] ; GLOBAL Method$HotFix.BattleLogic.RandomSkillResult.set_IsGuideOverride() @ 0x929ce60
00687101C  ldr      x2, [x8]
006871020  ldrb     w8, [x2, #0x53]
006871024  tbnz     w8, #5, #0x6871030
006871028  strb     wzr, [x22, #0x6c]
00687102C  b        #0x6871040 ; 
006871030  ldr      x8, [x2, #0x60]
006871034  mov      x0, x22
006871038  mov      w1, wzr
00687103C  blr      x8
006871040  ldr      x22, [x19, #0x80]
006871044  cbz      x22, #0x6871260
006871048  ldr      w8, [sp, #0xc]
00687104C  str      w8, [x22, #0x10]
006871050  ldrb     w8, [x26, #0xa4b]
006871054  cbnz     w8, #0x687106c
006871058  adrp     x0, #0x8ee5000
00687105C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006871060  bl       #0x382bd14 ; 
006871064  mov      w8, #1
006871068  strb     w8, [x26, #0xa4b]
00687106C  ldr      x1, [x27]
006871070  ldrb     w8, [x1, #0x53]
006871074  tbnz     w8, #5, #0x6871080
006871078  ldr      x0, [x19, #0x20]
00687107C  b        #0x687108c ; 
006871080  ldr      x8, [x1, #0x60]
006871084  mov      x0, x19
006871088  blr      x8
00687108C  cbz      x0, #0x6871260
006871090  ldr      x1, [x28]
006871094  ldr      x23, [x0, #0x1d0]
006871098  ldrb     w8, [x1, #0x53]
00687109C  tbnz     w8, #5, #0x68710a8
0068710A0  ldr      x0, [x19, #0x30]
0068710A4  b        #0x68710b4 ; 
0068710A8  ldr      x8, [x1, #0x60]
0068710AC  mov      x0, x19
0068710B0  blr      x8
0068710B4  cbz      x0, #0x6871260
0068710B8  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
0068710BC  cbz      x23, #0x6871260
0068710C0  mov      w1, w0
0068710C4  mov      x0, x23
0068710C8  mov      x2, xzr
0068710CC  bl       #0x6a4802c ; HotFix.BattleLogic.WorldInitInfo$$GetPlayerInfoByPlayerID
0068710D0  cbz      x0, #0x6871260
0068710D4  adrp     x25, #0x9599000
0068710D8  ldrb     w8, [x25, #0x299]
0068710DC  mov      x23, x0
0068710E0  cbnz     w8, #0x68710f8
0068710E4  adrp     x0, #0x8f07000
0068710E8  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattlePlayerInfo.get_BanSkills() @ 0x923d9e8
0068710EC  bl       #0x382bd14 ; 
0068710F0  mov      w8, #1
0068710F4  strb     w8, [x25, #0x299]
0068710F8  adrp     x8, #0x8f07000
0068710FC  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattlePlayerInfo.get_BanSkills() @ 0x923d9e8
006871100  ldr      x1, [x8]
006871104  ldrb     w8, [x1, #0x53]
006871108  tbnz     w8, #5, #0x6871114
00687110C  ldr      x1, [x23, #0x20]
006871110  b        #0x6871124 ; 
006871114  ldr      x8, [x1, #0x60]
006871118  mov      x0, x23
00687111C  blr      x8
006871120  mov      x1, x0
006871124  adrp     x23, #0x8ee6000
006871128  ldr      x23, [x23, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00687112C  str      x1, [x22, #0x78]!
006871130  mov      x0, x22
006871134  bl       #0x382bcb8 ; 
006871138  tbz      w21, #0, #0x68711c0
00687113C  ldrb     w8, [x26, #0xa4b]
006871140  cbnz     w8, #0x6871158
006871144  adrp     x0, #0x8ee5000
006871148  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
00687114C  bl       #0x382bd14 ; 
006871150  mov      w8, #1
006871154  strb     w8, [x26, #0xa4b]
006871158  ldr      x1, [x27]
00687115C  ldrb     w8, [x1, #0x53]
006871160  tbnz     w8, #5, #0x687116c
006871164  ldr      x21, [x19, #0x20]
006871168  b        #0x687117c ; 
00687116C  ldr      x8, [x1, #0x60]
006871170  mov      x0, x19
006871174  blr      x8
006871178  mov      x21, x0
00687117C  ldr      x1, [x28]
006871180  ldrb     w8, [x1, #0x53]
006871184  tbnz     w8, #5, #0x6871190
006871188  ldr      x0, [x19, #0x30]
00687118C  b        #0x687119c ; 
006871190  ldr      x8, [x1, #0x60]
006871194  mov      x0, x19
006871198  blr      x8
00687119C  cbz      x0, #0x6871260
0068711A0  bl       #0x685aa38 ; HotFix.BattleLogic.EntityHero$$get_PlayerID
0068711A4  cbz      x21, #0x6871260
0068711A8  ldr      x3, [x19, #0x80]
0068711AC  mov      w1, w0
0068711B0  mov      w2, #4
0068711B4  mov      x0, x21
0068711B8  mov      x4, xzr
0068711BC  bl       #0x6a0f95c ; HotFix.BattleLogic.BattleWorldContext$$DisPatchOpenViewEvent
0068711C0  ldrb     w8, [x26, #0xa4b]
0068711C4  cbnz     w8, #0x68711dc
0068711C8  adrp     x0, #0x8ee5000
0068711CC  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068711D0  bl       #0x382bd14 ; 
0068711D4  mov      w8, #1
0068711D8  strb     w8, [x26, #0xa4b]
0068711DC  ldr      x1, [x27]
0068711E0  ldrb     w8, [x1, #0x53]
0068711E4  tbnz     w8, #5, #0x68711f0
0068711E8  ldr      x19, [x19, #0x20]
0068711EC  b        #0x6871200 ; 
0068711F0  ldr      x8, [x1, #0x60]
0068711F4  mov      x0, x19
0068711F8  blr      x8
0068711FC  mov      x19, x0
006871200  cbz      x19, #0x6871260
006871204  ldrb     w8, [x24, #0xa90]
006871208  cbnz     w8, #0x6871220
00687120C  adrp     x0, #0x8ee6000
006871210  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006871214  bl       #0x382bd14 ; 
006871218  mov      w8, #1
00687121C  strb     w8, [x24, #0xa90]
006871220  ldr      x1, [x23]
006871224  ldrb     w8, [x1, #0x53]
006871228  tbnz     w8, #5, #0x6871234
00687122C  ldr      x0, [x19, #0x230]
006871230  b        #0x6871240 ; 
006871234  ldr      x8, [x1, #0x60]
006871238  mov      x0, x19
00687123C  blr      x8
006871240  cbz      x0, #0x6871260
006871244  adrp     x8, #0x8f08000
006871248  ldr      x8, [x8, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
00687124C  mov      x1, x20
006871250  ldr      x2, [x8]
006871254  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
006871258  mov      w0, #1
00687125C  b        #0x687074c ; 
006871260  bl       #0x382bfb8 ; 

