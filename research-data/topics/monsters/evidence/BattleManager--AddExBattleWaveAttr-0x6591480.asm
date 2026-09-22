; HotFix.BattleLogic.BattleManager$$AddExBattleWaveAttr
; RVA 0x6591480; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006591480  stp      x30, x27, [sp, #-0x50]!
006591484  stp      x26, x25, [sp, #0x10]
006591488  stp      x24, x23, [sp, #0x20]
00659148C  stp      x22, x21, [sp, #0x30]
006591490  stp      x20, x19, [sp, #0x40]
006591494  adrp     x21, #0x9599000
006591498  adrp     x22, #0x8f08000
00659149C  ldrb     w8, [x21, #0x245]
0065914A0  ldr      x22, [x22, #0x850] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.AddExBattleWaveAttr()
0065914A4  mov      x20, x1
0065914A8  mov      x19, x0
0065914AC  tbnz     w8, #0, #0x65914f4
0065914B0  adrp     x0, #0x8f08000
0065914B4  ldr      x0, [x0, #0x850] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.AddExBattleWaveAttr()
0065914B8  bl       #0x382bd14 ; 
0065914BC  adrp     x0, #0x8f08000
0065914C0  ldr      x0, [x0, #0x828] ; GLOBAL AddExpMission
0065914C4  bl       #0x382bd14 ; 
0065914C8  adrp     x0, #0x8f08000
0065914CC  ldr      x0, [x0, #0x830] ; GLOBAL HPPickUpAddMission
0065914D0  bl       #0x382bd14 ; 
0065914D4  adrp     x0, #0x8f08000
0065914D8  ldr      x0, [x0, #0x838] ; GLOBAL AttackMission
0065914DC  bl       #0x382bd14 ; 
0065914E0  adrp     x0, #0x8f08000
0065914E4  ldr      x0, [x0, #0x840] ; GLOBAL HPMaxMission
0065914E8  bl       #0x382bd14 ; 
0065914EC  mov      w8, #1
0065914F0  strb     w8, [x21, #0x245]
0065914F4  ldr      x2, [x22]
0065914F8  ldrb     w8, [x2, #0x53]
0065914FC  tbnz     w8, #5, #0x659153c
006591500  adrp     x24, #0x9599000
006591504  ldrb     w8, [x24, #0x286]
006591508  cbnz     w8, #0x6591520
00659150C  adrp     x0, #0x8f07000
006591510  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
006591514  bl       #0x382bd14 ; 
006591518  mov      w8, #1
00659151C  strb     w8, [x24, #0x286]
006591520  adrp     x25, #0x8f07000
006591524  ldr      x25, [x25, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
006591528  ldr      x1, [x25]
00659152C  ldrb     w8, [x1, #0x53]
006591530  tbnz     w8, #5, #0x6591560
006591534  ldr      x21, [x19, #0x80]
006591538  b        #0x6591570 ; 
00659153C  ldr      x3, [x2, #0x60]
006591540  mov      x0, x19
006591544  mov      x1, x20
006591548  ldp      x20, x19, [sp, #0x40]
00659154C  ldp      x22, x21, [sp, #0x30]
006591550  ldp      x24, x23, [sp, #0x20]
006591554  ldp      x26, x25, [sp, #0x10]
006591558  ldp      x30, x27, [sp], #0x50
00659155C  br       x3
006591560  ldr      x8, [x1, #0x60]
006591564  mov      x0, x19
006591568  blr      x8
00659156C  mov      x21, x0
006591570  cbz      x21, #0x6591b0c
006591574  adrp     x22, #0x9599000
006591578  ldrb     w8, [x22, #0x2bd]
00659157C  cbnz     w8, #0x6591594
006591580  adrp     x0, #0x8f08000
006591584  ldr      x0, [x0, #0x858] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.ClearBattleWaveAttr()
006591588  bl       #0x382bd14 ; 
00659158C  mov      w8, #1
006591590  strb     w8, [x22, #0x2bd]
006591594  adrp     x8, #0x8f08000
006591598  ldr      x8, [x8, #0x858] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.ClearBattleWaveAttr()
00659159C  ldr      x1, [x8]
0065915A0  ldrb     w8, [x1, #0x53]
0065915A4  tbnz     w8, #5, #0x65915e4
0065915A8  add      x0, x21, #0x290
0065915AC  bl       #0x658f570 ; HotFix.BattleLogic.BattleData$$ClearExBattleWaveAttr
0065915B0  cbz      x20, #0x65915f4
0065915B4  ldrb     w8, [x24, #0x286]
0065915B8  cbnz     w8, #0x65915d0
0065915BC  adrp     x0, #0x8f07000
0065915C0  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065915C4  bl       #0x382bd14 ; 
0065915C8  mov      w8, #1
0065915CC  strb     w8, [x24, #0x286]
0065915D0  ldr      x1, [x25]
0065915D4  ldrb     w8, [x1, #0x53]
0065915D8  tbnz     w8, #5, #0x659160c
0065915DC  ldr      x21, [x19, #0x80]
0065915E0  b        #0x659161c ; 
0065915E4  ldr      x8, [x1, #0x60]
0065915E8  mov      x0, x21
0065915EC  blr      x8
0065915F0  cbnz     x20, #0x65915b4
0065915F4  ldp      x20, x19, [sp, #0x40]
0065915F8  ldp      x22, x21, [sp, #0x30]
0065915FC  ldp      x24, x23, [sp, #0x20]
006591600  ldp      x26, x25, [sp, #0x10]
006591604  ldp      x30, x27, [sp], #0x50
006591608  ret      
00659160C  ldr      x8, [x1, #0x60]
006591610  mov      x0, x19
006591614  blr      x8
006591618  mov      x21, x0
00659161C  adrp     x22, #0x9599000
006591620  ldrb     w8, [x22, #0x2be]
006591624  cbnz     w8, #0x659163c
006591628  adrp     x0, #0x8f08000
00659162C  ldr      x0, [x0, #0x860] ; GLOBAL Method$LocalModels.Bean.ChapterWave_Waves.get_hpUpgrade()
006591630  bl       #0x382bd14 ; 
006591634  mov      w8, #1
006591638  strb     w8, [x22, #0x2be]
00659163C  adrp     x8, #0x8f08000
006591640  ldr      x8, [x8, #0x860] ; GLOBAL Method$LocalModels.Bean.ChapterWave_Waves.get_hpUpgrade()
006591644  ldr      x1, [x8]
006591648  ldrb     w8, [x1, #0x53]
00659164C  tbnz     w8, #5, #0x6591658
006591650  ldr      x22, [x20, #0x48]
006591654  b        #0x6591668 ; 
006591658  ldr      x8, [x1, #0x60]
00659165C  mov      x0, x20
006591660  blr      x8
006591664  mov      x22, x0
006591668  ldrb     w8, [x24, #0x286]
00659166C  cbnz     w8, #0x6591684
006591670  adrp     x0, #0x8f07000
006591674  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
006591678  bl       #0x382bd14 ; 
00659167C  mov      w8, #1
006591680  strb     w8, [x24, #0x286]
006591684  ldr      x1, [x25]
006591688  ldrb     w8, [x1, #0x53]
00659168C  tbnz     w8, #5, #0x6591698
006591690  ldr      x0, [x19, #0x80]
006591694  b        #0x65916a4 ; 
006591698  ldr      x8, [x1, #0x60]
00659169C  mov      x0, x19
0065916A0  blr      x8
0065916A4  cbz      x0, #0x6591b0c
0065916A8  ldr      x0, [x0, #0x3b8]
0065916AC  mov      x1, xzr
0065916B0  bl       #0x6b261a8 ; LocalModels.Bean.ChapterABTestExtension$$GetABHpUpgrade
0065916B4  cbz      x21, #0x6591b0c
0065916B8  adrp     x8, #0x8f08000
0065916BC  ldr      x8, [x8, #0x840] ; GLOBAL HPMaxMission
0065916C0  adrp     x26, #0x9599000
0065916C4  ldrb     w9, [x26, #0x2bf]
0065916C8  ldr      x23, [x8]
0065916CC  mul      x8, x0, x22
0065916D0  asr      x22, x8, #0x10
0065916D4  cbnz     w9, #0x65916ec
0065916D8  adrp     x0, #0x8f08000
0065916DC  ldr      x0, [x0, #0x868] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleWaveAttr()
0065916E0  bl       #0x382bd14 ; 
0065916E4  mov      w8, #1
0065916E8  strb     w8, [x26, #0x2bf]
0065916EC  adrp     x27, #0x8f08000
0065916F0  ldr      x27, [x27, #0x868] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleWaveAttr()
0065916F4  ldr      x3, [x27]
0065916F8  ldrb     w8, [x3, #0x53]
0065916FC  tbnz     w8, #5, #0x6591714
006591700  add      x0, x21, #0x290
006591704  mov      x1, x23
006591708  mov      x2, x22
00659170C  bl       #0x658f09c ; HotFix.BattleLogic.BattleData$$AddExBattleWaveAttr
006591710  b        #0x6591728 ; 
006591714  ldr      x8, [x3, #0x60]
006591718  mov      x0, x21
00659171C  mov      x1, x23
006591720  mov      x2, x22
006591724  blr      x8
006591728  ldrb     w8, [x24, #0x286]
00659172C  cbnz     w8, #0x6591744
006591730  adrp     x0, #0x8f07000
006591734  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
006591738  bl       #0x382bd14 ; 
00659173C  mov      w8, #1
006591740  strb     w8, [x24, #0x286]
006591744  ldr      x1, [x25]
006591748  ldrb     w8, [x1, #0x53]
00659174C  tbnz     w8, #5, #0x6591758
006591750  ldr      x21, [x19, #0x80]
006591754  b        #0x6591768 ; 
006591758  ldr      x8, [x1, #0x60]
00659175C  mov      x0, x19
006591760  blr      x8
006591764  mov      x21, x0
006591768  adrp     x22, #0x9599000
00659176C  ldrb     w8, [x22, #0x2c0]
006591770  cbnz     w8, #0x6591788
006591774  adrp     x0, #0x8f08000
006591778  ldr      x0, [x0, #0x870] ; GLOBAL Method$LocalModels.Bean.ChapterWave_Waves.get_attackUp()
00659177C  bl       #0x382bd14 ; 
006591780  mov      w8, #1
006591784  strb     w8, [x22, #0x2c0]
006591788  adrp     x8, #0x8f08000
00659178C  ldr      x8, [x8, #0x870] ; GLOBAL Method$LocalModels.Bean.ChapterWave_Waves.get_attackUp()
006591790  ldr      x1, [x8]
006591794  ldrb     w8, [x1, #0x53]
006591798  tbnz     w8, #5, #0x65917a4
00659179C  ldr      x22, [x20, #0x50]
0065917A0  b        #0x65917b4 ; 
0065917A4  ldr      x8, [x1, #0x60]
0065917A8  mov      x0, x20
0065917AC  blr      x8
0065917B0  mov      x22, x0
0065917B4  ldrb     w8, [x24, #0x286]
0065917B8  cbnz     w8, #0x65917d0
0065917BC  adrp     x0, #0x8f07000
0065917C0  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065917C4  bl       #0x382bd14 ; 
0065917C8  mov      w8, #1
0065917CC  strb     w8, [x24, #0x286]
0065917D0  ldr      x1, [x25]
0065917D4  ldrb     w8, [x1, #0x53]
0065917D8  tbnz     w8, #5, #0x65917e4
0065917DC  ldr      x0, [x19, #0x80]
0065917E0  b        #0x65917f0 ; 
0065917E4  ldr      x8, [x1, #0x60]
0065917E8  mov      x0, x19
0065917EC  blr      x8
0065917F0  cbz      x0, #0x6591b0c
0065917F4  ldr      x0, [x0, #0x3b8]
0065917F8  mov      x1, xzr
0065917FC  bl       #0x6b26470 ; LocalModels.Bean.ChapterABTestExtension$$GetABAttackUp
006591800  cbz      x21, #0x6591b0c
006591804  adrp     x8, #0x8f08000
006591808  ldr      x8, [x8, #0x838] ; GLOBAL AttackMission
00659180C  ldrb     w9, [x26, #0x2bf]
006591810  ldr      x23, [x8]
006591814  mul      x8, x0, x22
006591818  asr      x22, x8, #0x10
00659181C  cbnz     w9, #0x6591834
006591820  adrp     x0, #0x8f08000
006591824  ldr      x0, [x0, #0x868] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleWaveAttr()
006591828  bl       #0x382bd14 ; 
00659182C  mov      w8, #1
006591830  strb     w8, [x26, #0x2bf]
006591834  ldr      x3, [x27]
006591838  ldrb     w8, [x3, #0x53]
00659183C  tbnz     w8, #5, #0x6591854
006591840  add      x0, x21, #0x290
006591844  mov      x1, x23
006591848  mov      x2, x22
00659184C  bl       #0x658f09c ; HotFix.BattleLogic.BattleData$$AddExBattleWaveAttr
006591850  b        #0x6591868 ; 
006591854  ldr      x8, [x3, #0x60]
006591858  mov      x0, x21
00659185C  mov      x1, x23
006591860  mov      x2, x22
006591864  blr      x8
006591868  ldrb     w8, [x24, #0x286]
00659186C  cbnz     w8, #0x6591884
006591870  adrp     x0, #0x8f07000
006591874  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
006591878  bl       #0x382bd14 ; 
00659187C  mov      w8, #1
006591880  strb     w8, [x24, #0x286]
006591884  ldr      x1, [x25]
006591888  ldrb     w8, [x1, #0x53]
00659188C  tbnz     w8, #5, #0x6591898
006591890  ldr      x21, [x19, #0x80]
006591894  b        #0x65918a8 ; 
006591898  ldr      x8, [x1, #0x60]
00659189C  mov      x0, x19
0065918A0  blr      x8
0065918A4  mov      x21, x0
0065918A8  adrp     x22, #0x9599000
0065918AC  ldrb     w8, [x22, #0x2c1]
0065918B0  cbnz     w8, #0x65918c8
0065918B4  adrp     x0, #0x8f08000
0065918B8  ldr      x0, [x0, #0x878] ; GLOBAL Method$LocalModels.Bean.ChapterWave_Waves.get_addExpUpgrade()
0065918BC  bl       #0x382bd14 ; 
0065918C0  mov      w8, #1
0065918C4  strb     w8, [x22, #0x2c1]
0065918C8  adrp     x8, #0x8f08000
0065918CC  ldr      x8, [x8, #0x878] ; GLOBAL Method$LocalModels.Bean.ChapterWave_Waves.get_addExpUpgrade()
0065918D0  ldr      x1, [x8]
0065918D4  ldrb     w8, [x1, #0x53]
0065918D8  tbnz     w8, #5, #0x65918e4
0065918DC  ldr      x22, [x20, #0x58]
0065918E0  b        #0x65918f4 ; 
0065918E4  ldr      x8, [x1, #0x60]
0065918E8  mov      x0, x20
0065918EC  blr      x8
0065918F0  mov      x22, x0
0065918F4  ldrb     w8, [x24, #0x286]
0065918F8  cbnz     w8, #0x6591910
0065918FC  adrp     x0, #0x8f07000
006591900  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
006591904  bl       #0x382bd14 ; 
006591908  mov      w8, #1
00659190C  strb     w8, [x24, #0x286]
006591910  ldr      x1, [x25]
006591914  ldrb     w8, [x1, #0x53]
006591918  tbnz     w8, #5, #0x6591924
00659191C  ldr      x0, [x19, #0x80]
006591920  b        #0x6591930 ; 
006591924  ldr      x8, [x1, #0x60]
006591928  mov      x0, x19
00659192C  blr      x8
006591930  cbz      x0, #0x6591b0c
006591934  ldr      x0, [x0, #0x3b8]
006591938  mov      x1, xzr
00659193C  bl       #0x6b26738 ; LocalModels.Bean.ChapterABTestExtension$$GetABAddExpUpgrade
006591940  cbz      x21, #0x6591b0c
006591944  adrp     x8, #0x8f08000
006591948  ldr      x8, [x8, #0x828] ; GLOBAL AddExpMission
00659194C  ldrb     w9, [x26, #0x2bf]
006591950  ldr      x23, [x8]
006591954  mul      x8, x0, x22
006591958  asr      x22, x8, #0x10
00659195C  cbnz     w9, #0x6591974
006591960  adrp     x0, #0x8f08000
006591964  ldr      x0, [x0, #0x868] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleWaveAttr()
006591968  bl       #0x382bd14 ; 
00659196C  mov      w8, #1
006591970  strb     w8, [x26, #0x2bf]
006591974  ldr      x3, [x27]
006591978  ldrb     w8, [x3, #0x53]
00659197C  tbnz     w8, #5, #0x6591994
006591980  add      x0, x21, #0x290
006591984  mov      x1, x23
006591988  mov      x2, x22
00659198C  bl       #0x658f09c ; HotFix.BattleLogic.BattleData$$AddExBattleWaveAttr
006591990  b        #0x65919a8 ; 
006591994  ldr      x8, [x3, #0x60]
006591998  mov      x0, x21
00659199C  mov      x1, x23
0065919A0  mov      x2, x22
0065919A4  blr      x8
0065919A8  ldrb     w8, [x24, #0x286]
0065919AC  cbnz     w8, #0x65919c4
0065919B0  adrp     x0, #0x8f07000
0065919B4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065919B8  bl       #0x382bd14 ; 
0065919BC  mov      w8, #1
0065919C0  strb     w8, [x24, #0x286]
0065919C4  ldr      x1, [x25]
0065919C8  ldrb     w8, [x1, #0x53]
0065919CC  tbnz     w8, #5, #0x65919d8
0065919D0  ldr      x21, [x19, #0x80]
0065919D4  b        #0x65919e8 ; 
0065919D8  ldr      x8, [x1, #0x60]
0065919DC  mov      x0, x19
0065919E0  blr      x8
0065919E4  mov      x21, x0
0065919E8  adrp     x22, #0x9599000
0065919EC  ldrb     w8, [x22, #0x2c2]
0065919F0  cbnz     w8, #0x6591a08
0065919F4  adrp     x0, #0x8f08000
0065919F8  ldr      x0, [x0, #0x880] ; GLOBAL Method$LocalModels.Bean.ChapterWave_Waves.get_HPPickUpAddPercent()
0065919FC  bl       #0x382bd14 ; 
006591A00  mov      w8, #1
006591A04  strb     w8, [x22, #0x2c2]
006591A08  adrp     x8, #0x8f08000
006591A0C  ldr      x8, [x8, #0x880] ; GLOBAL Method$LocalModels.Bean.ChapterWave_Waves.get_HPPickUpAddPercent()
006591A10  ldr      x1, [x8]
006591A14  ldrb     w8, [x1, #0x53]
006591A18  tbnz     w8, #5, #0x6591a24
006591A1C  ldr      x20, [x20, #0x60]
006591A20  b        #0x6591a34 ; 
006591A24  ldr      x8, [x1, #0x60]
006591A28  mov      x0, x20
006591A2C  blr      x8
006591A30  mov      x20, x0
006591A34  ldrb     w8, [x24, #0x286]
006591A38  cbnz     w8, #0x6591a50
006591A3C  adrp     x0, #0x8f07000
006591A40  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
006591A44  bl       #0x382bd14 ; 
006591A48  mov      w8, #1
006591A4C  strb     w8, [x24, #0x286]
006591A50  ldr      x1, [x25]
006591A54  ldrb     w8, [x1, #0x53]
006591A58  tbnz     w8, #5, #0x6591a64
006591A5C  ldr      x0, [x19, #0x80]
006591A60  b        #0x6591a70 ; 
006591A64  ldr      x8, [x1, #0x60]
006591A68  mov      x0, x19
006591A6C  blr      x8
006591A70  cbz      x0, #0x6591b0c
006591A74  ldr      x0, [x0, #0x3b8]
006591A78  mov      x1, xzr
006591A7C  bl       #0x6b26a00 ; LocalModels.Bean.ChapterABTestExtension$$GetABHPPickUpAddPercent
006591A80  cbz      x21, #0x6591b0c
006591A84  adrp     x8, #0x8f08000
006591A88  ldr      x8, [x8, #0x830] ; GLOBAL HPPickUpAddMission
006591A8C  ldrb     w9, [x26, #0x2bf]
006591A90  ldr      x22, [x8]
006591A94  mul      x8, x0, x20
006591A98  asr      x19, x8, #0x10
006591A9C  cbnz     w9, #0x6591ab4
006591AA0  adrp     x0, #0x8f08000
006591AA4  ldr      x0, [x0, #0x868] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleWaveAttr()
006591AA8  bl       #0x382bd14 ; 
006591AAC  mov      w8, #1
006591AB0  strb     w8, [x26, #0x2bf]
006591AB4  ldr      x3, [x27]
006591AB8  ldrb     w8, [x3, #0x53]
006591ABC  tbnz     w8, #5, #0x6591ae4
006591AC0  add      x0, x21, #0x290
006591AC4  mov      x1, x22
006591AC8  mov      x2, x19
006591ACC  ldp      x20, x19, [sp, #0x40]
006591AD0  ldp      x22, x21, [sp, #0x30]
006591AD4  ldp      x24, x23, [sp, #0x20]
006591AD8  ldp      x26, x25, [sp, #0x10]
006591ADC  ldp      x30, x27, [sp], #0x50
006591AE0  b        #0x658f09c ; HotFix.BattleLogic.BattleData$$AddExBattleWaveAttr
006591AE4  ldr      x4, [x3, #0x60]
006591AE8  mov      x0, x21
006591AEC  mov      x1, x22
006591AF0  mov      x2, x19
006591AF4  ldp      x20, x19, [sp, #0x40]
006591AF8  ldp      x22, x21, [sp, #0x30]
006591AFC  ldp      x24, x23, [sp, #0x20]
006591B00  ldp      x26, x25, [sp, #0x10]
006591B04  ldp      x30, x27, [sp], #0x50
006591B08  br       x4
006591B0C  bl       #0x382bfb8 ; 

