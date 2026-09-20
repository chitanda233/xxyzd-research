; HotFix.BattleLogic.BaseBoxState$$ShowBox
; RVA 0x65973C8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065973C8  sub      sp, sp, #0x60
0065973CC  stp      x30, x25, [sp, #0x20]
0065973D0  stp      x24, x23, [sp, #0x30]
0065973D4  stp      x22, x21, [sp, #0x40]
0065973D8  stp      x20, x19, [sp, #0x50]
0065973DC  adrp     x20, #0x9599000
0065973E0  adrp     x21, #0x8f08000
0065973E4  ldrb     w8, [x20, #0x2e5]
0065973E8  ldr      x21, [x21, #0xc10] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState.ShowBox() @ 0x923afb0
0065973EC  mov      x19, x0
0065973F0  tbnz     w8, #0, #0x6597438
0065973F4  adrp     x0, #0x8f08000
0065973F8  ldr      x0, [x0, #0xc10] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState.ShowBox() @ 0x923afb0
0065973FC  bl       #0x382bd14 ; 
006597400  adrp     x0, #0x8f08000
006597404  ldr      x0, [x0, #0xc18] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<ShowTreasureEvent>() @ 0x923f490
006597408  bl       #0x382bd14 ; 
00659740C  adrp     x0, #0x8f07000
006597410  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
006597414  bl       #0x382bd14 ; 
006597418  adrp     x0, #0x8ee6000
00659741C  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006597420  bl       #0x382bd14 ; 
006597424  adrp     x0, #0x8f08000
006597428  ldr      x0, [x0, #0xc20] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<ShowTreasureEvent>() @ 0x9284958
00659742C  bl       #0x382bd14 ; 
006597430  mov      w8, #1
006597434  strb     w8, [x20, #0x2e5]
006597438  ldr      x1, [x21]
00659743C  ldrb     w8, [x1, #0x53]
006597440  tbnz     w8, #5, #0x659748c
006597444  ldr      x20, [x19, #0x18]
006597448  cbz      x20, #0x65978cc
00659744C  adrp     x21, #0x9599000
006597450  ldrb     w8, [x21, #0x4b0]
006597454  cbnz     w8, #0x659746c
006597458  adrp     x0, #0x8f08000
00659745C  ldr      x0, [x0, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
006597460  bl       #0x382bd14 ; 
006597464  mov      w8, #1
006597468  strb     w8, [x21, #0x4b0]
00659746C  adrp     x8, #0x8f08000
006597470  ldr      x8, [x8, #0xbc8] ; GLOBAL Method$HotFix.BattleLogic.EntityHero.SetBlockPause() @ 0x92638d0
006597474  ldr      x2, [x8]
006597478  ldrb     w8, [x2, #0x53]
00659747C  tbnz     w8, #5, #0x65974ac
006597480  mov      w8, #1
006597484  strb     w8, [x20, #0x648]
006597488  b        #0x65974bc ; 
00659748C  ldr      x2, [x1, #0x60]
006597490  mov      x0, x19
006597494  ldp      x20, x19, [sp, #0x50]
006597498  ldp      x22, x21, [sp, #0x40]
00659749C  ldp      x24, x23, [sp, #0x30]
0065974A0  ldp      x30, x25, [sp, #0x20]
0065974A4  add      sp, sp, #0x60
0065974A8  br       x2
0065974AC  ldr      x8, [x2, #0x60]
0065974B0  mov      w1, #1
0065974B4  mov      x0, x20
0065974B8  blr      x8
0065974BC  ldr      x0, [x19, #0x18]
0065974C0  cbz      x0, #0x65978cc
0065974C4  adrp     x8, #0x8f07000
0065974C8  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065974CC  ldr      x1, [x8]
0065974D0  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0065974D4  cbz      x0, #0x65978cc
0065974D8  mov      x1, xzr
0065974DC  mov      x21, x0
0065974E0  bl       #0x686f134 ; HotFix.BattleLogic.HeroComponentRandomSkill$$GetBoxRandomSkills
0065974E4  adrp     x23, #0x9599000
0065974E8  ldrb     w8, [x23, #0x4b1]
0065974EC  cbnz     w8, #0x6597504
0065974F0  adrp     x0, #0x8f08000
0065974F4  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065974F8  bl       #0x382bd14 ; 
0065974FC  mov      w8, #1
006597500  strb     w8, [x23, #0x4b1]
006597504  adrp     x24, #0x8f08000
006597508  ldr      x24, [x24, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659750C  ldr      x1, [x24]
006597510  ldrb     w8, [x1, #0x53]
006597514  tbnz     w8, #5, #0x6597520
006597518  ldr      x22, [x19, #0x10]
00659751C  b        #0x6597530 ; 
006597520  ldr      x8, [x1, #0x60]
006597524  mov      x0, x19
006597528  blr      x8
00659752C  mov      x22, x0
006597530  cbz      x22, #0x65978cc
006597534  adrp     x8, #0x8f08000
006597538  ldr      x8, [x8, #0xc18] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<ShowTreasureEvent>() @ 0x923f490
00659753C  ldr      x20, [x8]
006597540  ldr      x8, [x20, #0x38]
006597544  cbnz     x8, #0x6597550
006597548  mov      x0, x20
00659754C  bl       #0x3a7e668 ; 
006597550  ldrb     w8, [x20, #0x53]
006597554  tbnz     w8, #5, #0x6597594
006597558  adrp     x25, #0x9591000
00659755C  ldrb     w8, [x25, #0xa61]
006597560  cbnz     w8, #0x6597578
006597564  adrp     x0, #0x8ee6000
006597568  ldr      x0, [x0, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
00659756C  bl       #0x382bd14 ; 
006597570  mov      w8, #1
006597574  strb     w8, [x25, #0xa61]
006597578  adrp     x8, #0x8ee6000
00659757C  ldr      x8, [x8, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool() @ 0x923ff98
006597580  ldr      x1, [x8]
006597584  ldrb     w8, [x1, #0x53]
006597588  tbnz     w8, #5, #0x65975a8
00659758C  ldr      x0, [x22, #0x1e8]
006597590  b        #0x65975b4 ; 
006597594  ldr      x8, [x20, #0x60]
006597598  mov      x0, x22
00659759C  mov      x1, x20
0065975A0  blr      x8
0065975A4  b        #0x65975c4 ; 
0065975A8  ldr      x8, [x1, #0x60]
0065975AC  mov      x0, x22
0065975B0  blr      x8
0065975B4  cbz      x0, #0x65978cc
0065975B8  ldr      x8, [x20, #0x38]
0065975BC  ldr      x1, [x8]
0065975C0  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
0065975C4  mov      x20, x0
0065975C8  mov      x0, x21
0065975CC  mov      x1, xzr
0065975D0  bl       #0x6867f9c ; HotFix.BattleLogic.HeroComponentRandomSkill$$get_BoxSkillResult
0065975D4  ldp      q1, q0, [x0]
0065975D8  stp      q1, q0, [sp]
0065975DC  cbz      x20, #0x65978cc
0065975E0  ldp      q1, q0, [sp]
0065975E4  add      x0, x20, #0x30
0065975E8  mov      x1, xzr
0065975EC  stp      q1, q0, [x20, #0x20]
0065975F0  bl       #0x382bcb8 ; 
0065975F4  ldr      x8, [x19]
0065975F8  mov      x0, x19
0065975FC  ldp      x9, x1, [x8, #0x1c8]
006597600  blr      x9
006597604  and      w8, w0, #1
006597608  strb     w8, [x20, #0x40]
00659760C  ldrb     w8, [x23, #0x4b1]
006597610  cbnz     w8, #0x6597628
006597614  adrp     x0, #0x8f08000
006597618  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659761C  bl       #0x382bd14 ; 
006597620  mov      w8, #1
006597624  strb     w8, [x23, #0x4b1]
006597628  ldr      x1, [x24]
00659762C  ldrb     w8, [x1, #0x53]
006597630  tbnz     w8, #5, #0x659763c
006597634  ldr      x21, [x19, #0x10]
006597638  b        #0x659764c ; 
00659763C  ldr      x8, [x1, #0x60]
006597640  mov      x0, x19
006597644  blr      x8
006597648  mov      x21, x0
00659764C  cbz      x21, #0x65978cc
006597650  adrp     x22, #0x9598000
006597654  ldrb     w8, [x22, #0xfc4]
006597658  cbnz     w8, #0x6597670
00659765C  adrp     x0, #0x8f05000
006597660  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006597664  bl       #0x382bd14 ; 
006597668  mov      w8, #1
00659766C  strb     w8, [x22, #0xfc4]
006597670  adrp     x25, #0x8f05000
006597674  ldr      x25, [x25, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006597678  ldr      x1, [x25]
00659767C  ldrb     w8, [x1, #0x53]
006597680  tbnz     w8, #5, #0x659768c
006597684  ldr      x0, [x21, #0x220]
006597688  b        #0x6597698 ; 
00659768C  ldr      x8, [x1, #0x60]
006597690  mov      x0, x21
006597694  blr      x8
006597698  cbz      x0, #0x65978cc
00659769C  mov      x1, xzr
0065976A0  bl       #0x6585324 ; HotFix.BattleLogic.BattleManager$$IsBossWave
0065976A4  and      w8, w0, #1
0065976A8  strb     w8, [x20, #0x41]
0065976AC  strb     wzr, [x20, #0x42]
0065976B0  ldrb     w8, [x23, #0x4b1]
0065976B4  cbnz     w8, #0x65976cc
0065976B8  adrp     x0, #0x8f08000
0065976BC  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065976C0  bl       #0x382bd14 ; 
0065976C4  mov      w8, #1
0065976C8  strb     w8, [x23, #0x4b1]
0065976CC  ldr      x1, [x24]
0065976D0  ldrb     w8, [x1, #0x53]
0065976D4  tbnz     w8, #5, #0x65976e0
0065976D8  ldr      x21, [x19, #0x10]
0065976DC  b        #0x65976f0 ; 
0065976E0  ldr      x8, [x1, #0x60]
0065976E4  mov      x0, x19
0065976E8  blr      x8
0065976EC  mov      x21, x0
0065976F0  cbz      x21, #0x65978cc
0065976F4  ldrb     w8, [x22, #0xfc4]
0065976F8  cbnz     w8, #0x6597710
0065976FC  adrp     x0, #0x8f05000
006597700  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006597704  bl       #0x382bd14 ; 
006597708  mov      w8, #1
00659770C  strb     w8, [x22, #0xfc4]
006597710  ldr      x1, [x25]
006597714  ldrb     w8, [x1, #0x53]
006597718  tbnz     w8, #5, #0x6597724
00659771C  ldr      x0, [x21, #0x220]
006597720  b        #0x6597730 ; 
006597724  ldr      x8, [x1, #0x60]
006597728  mov      x0, x21
00659772C  blr      x8
006597730  cbz      x0, #0x65978cc
006597734  ldr      x8, [x0]
006597738  ldr      x9, [x8, #0x518]
00659773C  ldr      x1, [x8, #0x520]
006597740  blr      x9
006597744  str      w0, [x20, #0x44]
006597748  ldr      x0, [x19, #0x18]
00659774C  cbz      x0, #0x65978cc
006597750  adrp     x8, #0x8ee6000
006597754  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006597758  ldr      x1, [x8]
00659775C  ldrb     w8, [x1, #0x53]
006597760  tbnz     w8, #5, #0x659776c
006597764  ldr      x21, [x0, #0x38]
006597768  b        #0x6597778 ; 
00659776C  ldr      x8, [x1, #0x60]
006597770  blr      x8
006597774  mov      x21, x0
006597778  cbz      x21, #0x65978cc
00659777C  adrp     x22, #0x9591000
006597780  ldrb     w8, [x22, #0xa7f]
006597784  cbnz     w8, #0x659779c
006597788  adrp     x0, #0x8ee6000
00659778C  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006597790  bl       #0x382bd14 ; 
006597794  mov      w8, #1
006597798  strb     w8, [x22, #0xa7f]
00659779C  adrp     x8, #0x8ee6000
0065977A0  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
0065977A4  ldr      x1, [x8]
0065977A8  ldrb     w8, [x1, #0x53]
0065977AC  tbnz     w8, #5, #0x65977b8
0065977B0  ldr      x0, [x21, #0x178]
0065977B4  b        #0x65977c4 ; 
0065977B8  ldr      x8, [x1, #0x60]
0065977BC  mov      x0, x21
0065977C0  blr      x8
0065977C4  cbz      x0, #0x65978cc
0065977C8  mov      x1, xzr
0065977CC  bl       #0x6b3cf00 ; HotFix.Common.AttributeData$$GetAttack
0065977D0  lsr      x8, x0, #0x10
0065977D4  str      w8, [x20, #0x4c]
0065977D8  ldr      x0, [x19, #0x18]
0065977DC  cbz      x0, #0x65978cc
0065977E0  ldr      x8, [x0]
0065977E4  ldr      x9, [x8, #0x498]
0065977E8  ldr      x1, [x8, #0x4a0]
0065977EC  blr      x9
0065977F0  str      w0, [x20, #0x50]
0065977F4  ldrb     w8, [x23, #0x4b1]
0065977F8  cbnz     w8, #0x6597810
0065977FC  adrp     x0, #0x8f08000
006597800  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
006597804  bl       #0x382bd14 ; 
006597808  mov      w8, #1
00659780C  strb     w8, [x23, #0x4b1]
006597810  ldr      x1, [x24]
006597814  ldrb     w8, [x1, #0x53]
006597818  tbnz     w8, #5, #0x6597824
00659781C  ldr      x0, [x19, #0x10]
006597820  b        #0x6597830 ; 
006597824  ldr      x8, [x1, #0x60]
006597828  mov      x0, x19
00659782C  blr      x8
006597830  cbz      x0, #0x65978cc
006597834  ldr      x19, [x0, #0x1e0]
006597838  cbz      x19, #0x65978cc
00659783C  adrp     x9, #0x8f08000
006597840  ldr      x9, [x9, #0xc20] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<ShowTreasureEvent>() @ 0x9284958
006597844  ldr      x8, [x19]
006597848  ldr      x21, [x9]
00659784C  ldrh     w9, [x8, #0x12e]
006597850  ldr      x1, [x21, #0x20]
006597854  ldrh     w2, [x21, #0x50]
006597858  cbz      x9, #0x659787c
00659785C  ldr      x10, [x8, #0xb0]
006597860  add      x10, x10, #8
006597864  ldur     x11, [x10, #-8]
006597868  cmp      x11, x1
00659786C  b.eq     #0x6597888
006597870  subs     x9, x9, #1
006597874  add      x10, x10, #0x10
006597878  b.ne     #0x6597864
00659787C  mov      x0, x19
006597880  bl       #0x3a7e710 ; 
006597884  b        #0x6597898 ; 
006597888  ldr      w9, [x10]
00659788C  add      w9, w9, w2
006597890  add      x8, x8, w9, sxtw #4
006597894  add      x0, x8, #0x138
006597898  ldr      x0, [x0, #8]
00659789C  mov      x1, x21
0065978A0  bl       #0x382be88 ; 
0065978A4  mov      x2, x0
0065978A8  ldr      x3, [x0, #8]
0065978AC  mov      x0, x19
0065978B0  mov      x1, x20
0065978B4  ldp      x20, x19, [sp, #0x50]
0065978B8  ldp      x22, x21, [sp, #0x40]
0065978BC  ldp      x24, x23, [sp, #0x30]
0065978C0  ldp      x30, x25, [sp, #0x20]
0065978C4  add      sp, sp, #0x60
0065978C8  br       x3
0065978CC  bl       #0x382bfb8 ; 

