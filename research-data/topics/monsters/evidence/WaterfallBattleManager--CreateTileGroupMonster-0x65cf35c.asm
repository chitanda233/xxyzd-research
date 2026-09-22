; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileGroupMonster
; RVA 0x65CF35C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CF35C  sub      sp, sp, #0xf0
0065CF360  stp      x29, x30, [sp, #0x90]
0065CF364  stp      x28, x27, [sp, #0xa0]
0065CF368  stp      x26, x25, [sp, #0xb0]
0065CF36C  stp      x24, x23, [sp, #0xc0]
0065CF370  stp      x22, x21, [sp, #0xd0]
0065CF374  stp      x20, x19, [sp, #0xe0]
0065CF378  str      x1, [sp, #0x48]
0065CF37C  mrs      x22, tpidr_el0
0065CF380  ldr      x8, [x22, #0x28]
0065CF384  adrp     x19, #0x9599000
0065CF388  adrp     x20, #0x8f0a000
0065CF38C  mov      x21, x0
0065CF390  str      x8, [sp, #0x88]
0065CF394  ldrb     w8, [x19, #0x590]
0065CF398  ldr      x20, [x20, #0x928] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreateTileGroupMonster()
0065CF39C  tbnz     w8, #0, #0x65cf468
0065CF3A0  adrp     x0, #0x8ee8000
0065CF3A4  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo
0065CF3A8  bl       #0x382bd14 ; 
0065CF3AC  adrp     x0, #0x8f0a000
0065CF3B0  ldr      x0, [x0, #0x910] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.get_Item()
0065CF3B4  bl       #0x382bd14 ; 
0065CF3B8  adrp     x0, #0x8f09000
0065CF3BC  ldr      x0, [x0, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CF3C0  bl       #0x382bd14 ; 
0065CF3C4  adrp     x0, #0x8ebf000
0065CF3C8  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo
0065CF3CC  bl       #0x382bd14 ; 
0065CF3D0  adrp     x0, #0x8f0a000
0065CF3D4  ldr      x0, [x0, #0x930] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<List<MonsterGroupFlushConfig>>()
0065CF3D8  bl       #0x382bd14 ; 
0065CF3DC  adrp     x0, #0x8ee2000
0065CF3E0  ldr      x0, [x0, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo
0065CF3E4  bl       #0x382bd14 ; 
0065CF3E8  adrp     x0, #0x8f0a000
0065CF3EC  ldr      x0, [x0, #0x938] ; GLOBAL Method$System.Collections.Generic.List<MonsterGroupFlushConfig>.get_Count()
0065CF3F0  bl       #0x382bd14 ; 
0065CF3F4  adrp     x0, #0x8f0a000
0065CF3F8  ldr      x0, [x0, #0x940] ; GLOBAL Method$System.Collections.Generic.List<MonsterGroupFlushConfig>.get_Item()
0065CF3FC  bl       #0x382bd14 ; 
0065CF400  adrp     x0, #0x8f0a000
0065CF404  ldr      x0, [x0, #0x948] ; GLOBAL Method$System.Collections.Generic.List<MissionPositionGroupMonsterRandomData>.get_Item()
0065CF408  bl       #0x382bd14 ; 
0065CF40C  adrp     x0, #0x8ee1000
0065CF410  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo
0065CF414  bl       #0x382bd14 ; 
0065CF418  adrp     x0, #0x8f05000
0065CF41C  ldr      x0, [x0, #0xa78] ; GLOBAL HotFix.BattleLogic.MapManager_TypeInfo
0065CF420  bl       #0x382bd14 ; 
0065CF424  adrp     x0, #0x8f0a000
0065CF428  ldr      x0, [x0, #0x928] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreateTileGroupMonster()
0065CF42C  bl       #0x382bd14 ; 
0065CF430  adrp     x0, #0x8f0a000
0065CF434  ldr      x0, [x0, #0x950] ; GLOBAL 刷怪配置不存在 flushConfigId = 
0065CF438  bl       #0x382bd14 ; 
0065CF43C  adrp     x0, #0x8f0a000
0065CF440  ldr      x0, [x0, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065CF444  bl       #0x382bd14 ; 
0065CF448  adrp     x0, #0x8f0a000
0065CF44C  ldr      x0, [x0, #0x958] ; GLOBAL 刷怪数量超过最大数量，超过的部分不会刷出来   请缩小  刷新模板一次延迟刷新怪物数量.限制在{0}内.
0065CF450  bl       #0x382bd14 ; 
0065CF454  adrp     x0, #0x8f0a000
0065CF458  ldr      x0, [x0, #0x960] ; GLOBAL CreateTileGroupMonster
0065CF45C  bl       #0x382bd14 ; 
0065CF460  mov      w8, #1
0065CF464  strb     w8, [x19, #0x590]
0065CF468  ldr      x2, [x20]
0065CF46C  ldrb     w8, [x2, #0x53]
0065CF470  tbnz     w8, #5, #0x65cf4bc
0065CF474  adrp     x8, #0x9599000
0065CF478  ldrb     w8, [x8, #0x286]
0065CF47C  str      wzr, [sp, #0x6c]
0065CF480  cbnz     w8, #0x65cf49c
0065CF484  adrp     x0, #0x8f07000
0065CF488  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CF48C  bl       #0x382bd14 ; 
0065CF490  mov      w8, #1
0065CF494  adrp     x9, #0x9599000
0065CF498  strb     w8, [x9, #0x286]
0065CF49C  str      x22, [sp, #8]
0065CF4A0  adrp     x8, #0x8f07000
0065CF4A4  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CF4A8  ldr      x1, [x8]
0065CF4AC  ldrb     w8, [x1, #0x53]
0065CF4B0  tbnz     w8, #5, #0x65cf4d4
0065CF4B4  ldr      x22, [x21, #0x80]
0065CF4B8  b        #0x65cf4e4 ; 
0065CF4BC  ldr      x8, [x2, #0x60]
0065CF4C0  ldr      x1, [sp, #0x48]
0065CF4C4  mov      x0, x21
0065CF4C8  blr      x8
0065CF4CC  ldr      x8, [x22, #0x28]
0065CF4D0  b        #0x65cff20 ; 
0065CF4D4  ldr      x8, [x1, #0x60]
0065CF4D8  mov      x0, x21
0065CF4DC  blr      x8
0065CF4E0  mov      x22, x0
0065CF4E4  cbz      x22, #0x65cff4c
0065CF4E8  adrp     x19, #0x9591000
0065CF4EC  ldrb     w8, [x19, #0xa9c]
0065CF4F0  cbnz     w8, #0x65cf508
0065CF4F4  adrp     x0, #0x8ee6000
0065CF4F8  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065CF4FC  bl       #0x382bd14 ; 
0065CF500  mov      w8, #1
0065CF504  strb     w8, [x19, #0xa9c]
0065CF508  adrp     x8, #0x8ee6000
0065CF50C  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065CF510  ldr      x1, [x8]
0065CF514  ldrb     w8, [x1, #0x53]
0065CF518  tbnz     w8, #5, #0x65cf524
0065CF51C  ldr      x25, [x22, #0x240]
0065CF520  b        #0x65cf534 ; 
0065CF524  ldr      x8, [x1, #0x60]
0065CF528  mov      x0, x22
0065CF52C  blr      x8
0065CF530  mov      x25, x0
0065CF534  ldr      x22, [x21, #0x188]
0065CF538  cbz      x22, #0x65cff4c
0065CF53C  adrp     x10, #0x8f09000
0065CF540  ldr      x8, [x22]
0065CF544  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CF548  ldrh     w9, [x8, #0x12e]
0065CF54C  ldr      x1, [x10]
0065CF550  cbz      x9, #0x65cf574
0065CF554  ldr      x10, [x8, #0xb0]
0065CF558  add      x10, x10, #8
0065CF55C  ldur     x11, [x10, #-8]
0065CF560  cmp      x11, x1
0065CF564  b.eq     #0x65cf584
0065CF568  subs     x9, x9, #1
0065CF56C  add      x10, x10, #0x10
0065CF570  b.ne     #0x65cf55c
0065CF574  mov      w2, #0x14
0065CF578  mov      x0, x22
0065CF57C  bl       #0x3a7e710 ; 
0065CF580  b        #0x65cf594 ; 
0065CF584  ldr      w9, [x10]
0065CF588  add      w9, w9, #0x14
0065CF58C  add      x8, x8, w9, sxtw #4
0065CF590  add      x0, x8, #0x138
0065CF594  ldp      x8, x1, [x0]
0065CF598  mov      x0, x22
0065CF59C  blr      x8
0065CF5A0  cbz      x0, #0x65cff4c
0065CF5A4  ldr      x24, [x21, #0x188]
0065CF5A8  cbz      x24, #0x65cff4c
0065CF5AC  ldr      x8, [x24]
0065CF5B0  adrp     x10, #0x8f09000
0065CF5B4  ldr      x23, [x21, #0x1f0]
0065CF5B8  mov      x22, x0
0065CF5BC  ldrh     w9, [x8, #0x12e]
0065CF5C0  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CF5C4  ldr      x1, [x10]
0065CF5C8  cbz      x9, #0x65cf5ec
0065CF5CC  ldr      x10, [x8, #0xb0]
0065CF5D0  add      x10, x10, #8
0065CF5D4  ldur     x11, [x10, #-8]
0065CF5D8  cmp      x11, x1
0065CF5DC  b.eq     #0x65cf5fc
0065CF5E0  subs     x9, x9, #1
0065CF5E4  add      x10, x10, #0x10
0065CF5E8  b.ne     #0x65cf5d4
0065CF5EC  mov      x0, x24
0065CF5F0  mov      w2, wzr
0065CF5F4  bl       #0x3a7e710 ; 
0065CF5F8  b        #0x65cf608 ; 
0065CF5FC  ldrsw    x9, [x10]
0065CF600  add      x8, x8, x9, lsl #4
0065CF604  add      x0, x8, #0x138
0065CF608  ldp      x8, x1, [x0]
0065CF60C  mov      x0, x24
0065CF610  blr      x8
0065CF614  cbz      x23, #0x65cff4c
0065CF618  adrp     x8, #0x8f0a000
0065CF61C  ldr      x8, [x8, #0x910] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.get_Item()
0065CF620  mov      w1, w0
0065CF624  mov      x0, x23
0065CF628  ldr      x2, [x8]
0065CF62C  bl       #0x5e5f99c ; System.Collections.Generic.Dictionary<int, object>$$get_Item
0065CF630  ldr      w8, [x22, #0x18]
0065CF634  cmp      w8, #1
0065CF638  b.lt     #0x65cff18
0065CF63C  mov      x24, x0
0065CF640  cbz      x0, #0x65cff4c
0065CF644  adrp     x8, #0x9599000
0065CF648  ldrb     w8, [x8, #0x286]
0065CF64C  ldrsw    x19, [x24, #0x18]
0065CF650  cbnz     w8, #0x65cf66c
0065CF654  adrp     x0, #0x8f07000
0065CF658  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CF65C  bl       #0x382bd14 ; 
0065CF660  mov      w8, #1
0065CF664  adrp     x9, #0x9599000
0065CF668  strb     w8, [x9, #0x286]
0065CF66C  adrp     x8, #0x8f07000
0065CF670  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CF674  ldr      x1, [x8]
0065CF678  ldrb     w8, [x1, #0x53]
0065CF67C  tbnz     w8, #5, #0x65cf688
0065CF680  ldr      x23, [x21, #0x80]
0065CF684  b        #0x65cf698 ; 
0065CF688  ldr      x8, [x1, #0x60]
0065CF68C  mov      x0, x21
0065CF690  blr      x8
0065CF694  mov      x23, x0
0065CF698  cbz      x23, #0x65cff4c
0065CF69C  adrp     x8, #0x9598000
0065CF6A0  ldrb     w8, [x8, #0xfcc]
0065CF6A4  cbnz     w8, #0x65cf6c0
0065CF6A8  adrp     x0, #0x8f06000
0065CF6AC  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065CF6B0  bl       #0x382bd14 ; 
0065CF6B4  mov      w8, #1
0065CF6B8  adrp     x9, #0x9598000
0065CF6BC  strb     w8, [x9, #0xfcc]
0065CF6C0  adrp     x8, #0x8f06000
0065CF6C4  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065CF6C8  ldr      x1, [x8]
0065CF6CC  ldrb     w8, [x1, #0x53]
0065CF6D0  tbnz     w8, #5, #0x65cf6dc
0065CF6D4  ldr      x0, [x23, #0x200]
0065CF6D8  b        #0x65cf6e8 ; 
0065CF6DC  ldr      x8, [x1, #0x60]
0065CF6E0  mov      x0, x23
0065CF6E4  blr      x8
0065CF6E8  ldr      w8, [x22, #0x18]
0065CF6EC  cmp      w19, w8
0065CF6F0  b.hs     #0x65cff50
0065CF6F4  cbz      x0, #0x65cff4c
0065CF6F8  add      x8, x22, x19, lsl #2
0065CF6FC  ldr      w1, [x8, #0x20]
0065CF700  mov      x2, xzr
0065CF704  bl       #0x64d8fd4 ; LocalModels.LocalModelManager$$GetMission_PositionGroupMonsterFlushConfig
0065CF708  cbz      x0, #0x65cff4c
0065CF70C  adrp     x19, #0x9599000
0065CF710  ldrb     w8, [x19, #0x65c]
0065CF714  mov      x22, x0
0065CF718  cbnz     w8, #0x65cf730
0065CF71C  adrp     x0, #0x8f0a000
0065CF720  ldr      x0, [x0, #0x968] ; GLOBAL Method$LocalModels.Bean.Mission_PositionGroupMonsterFlushConfig.get_flushPool()
0065CF724  bl       #0x382bd14 ; 
0065CF728  mov      w8, #1
0065CF72C  strb     w8, [x19, #0x65c]
0065CF730  adrp     x8, #0x8f0a000
0065CF734  ldr      x8, [x8, #0x968] ; GLOBAL Method$LocalModels.Bean.Mission_PositionGroupMonsterFlushConfig.get_flushPool()
0065CF738  ldr      x1, [x8]
0065CF73C  ldrb     w8, [x1, #0x53]
0065CF740  tbnz     w8, #5, #0x65cf74c
0065CF744  ldr      x22, [x22, #0x28]
0065CF748  b        #0x65cf75c ; 
0065CF74C  ldr      x8, [x1, #0x60]
0065CF750  mov      x0, x22
0065CF754  blr      x8
0065CF758  mov      x22, x0
0065CF75C  adrp     x8, #0x8ee2000
0065CF760  ldr      x8, [x8, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo
0065CF764  ldr      x0, [x8]
0065CF768  ldr      w8, [x0, #0xe0]
0065CF76C  cbnz     w8, #0x65cf774
0065CF770  bl       #0x382be8c ; 
0065CF774  adrp     x8, #0x8f0a000
0065CF778  ldr      x8, [x8, #0x930] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<List<MonsterGroupFlushConfig>>()
0065CF77C  mov      x0, x22
0065CF780  ldr      x1, [x8]
0065CF784  bl       #0x4652a8c ; LitJson.JsonMapperLockStep$$ToObjectFp<object>
0065CF788  cbz      x0, #0x65cff4c
0065CF78C  ldr      w8, [x0, #0x18]
0065CF790  mov      x26, x0
0065CF794  cmp      w8, #1
0065CF798  b.lt     #0x65cff18
0065CF79C  adrp     x28, #0x8f0a000
0065CF7A0  adrp     x19, #0x8f0a000
0065CF7A4  ldr      x28, [x28, #0x948] ; GLOBAL Method$System.Collections.Generic.List<MissionPositionGroupMonsterRandomData>.get_Item()
0065CF7A8  ldr      x19, [x19, #0x940] ; GLOBAL Method$System.Collections.Generic.List<MonsterGroupFlushConfig>.get_Item()
0065CF7AC  mov      w27, wzr
0065CF7B0  mov      w20, #0x258
0065CF7B4  stp      x24, x25, [sp, #0x10]
0065CF7B8  str      x26, [sp, #0x40]
0065CF7BC  ldr      x0, [x24, #0x20]
0065CF7C0  cbz      x0, #0x65cff4c
0065CF7C4  ldr      x2, [x28]
0065CF7C8  mov      w1, w27
0065CF7CC  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065CF7D0  ldr      x2, [x19]
0065CF7D4  mov      x22, x0
0065CF7D8  mov      x0, x26
0065CF7DC  mov      w1, w27
0065CF7E0  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065CF7E4  cbz      x0, #0x65cff4c
0065CF7E8  ldr      w8, [x0, #0x10]
0065CF7EC  ldr      x2, [x19]
0065CF7F0  mov      x0, x26
0065CF7F4  mov      w1, w27
0065CF7F8  str      w8, [sp, #0x6c]
0065CF7FC  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065CF800  cbz      x0, #0x65cff4c
0065CF804  cbz      x22, #0x65cff4c
0065CF808  ldr      x8, [x0, #0x18]
0065CF80C  cbz      x8, #0x65cff4c
0065CF810  ldrsw    x9, [x22, #0x14]
0065CF814  ldr      w10, [x8, #0x18]
0065CF818  cmp      w9, w10
0065CF81C  b.hs     #0x65cff50
0065CF820  add      x8, x8, x9, lsl #2
0065CF824  adrp     x9, #0x9599000
0065CF828  ldrb     w9, [x9, #0x286]
0065CF82C  ldr      w8, [x8, #0x20]
0065CF830  str      w8, [sp, #0x68]
0065CF834  cbnz     w9, #0x65cf850
0065CF838  adrp     x0, #0x8f07000
0065CF83C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CF840  bl       #0x382bd14 ; 
0065CF844  adrp     x8, #0x9599000
0065CF848  mov      w9, #1
0065CF84C  strb     w9, [x8, #0x286]
0065CF850  adrp     x8, #0x8f07000
0065CF854  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CF858  ldr      x1, [x8]
0065CF85C  ldrb     w8, [x1, #0x53]
0065CF860  tbnz     w8, #5, #0x65cf86c
0065CF864  ldr      x23, [x21, #0x80]
0065CF868  b        #0x65cf87c ; 
0065CF86C  ldr      x8, [x1, #0x60]
0065CF870  mov      x0, x21
0065CF874  blr      x8
0065CF878  mov      x23, x0
0065CF87C  cbz      x23, #0x65cff4c
0065CF880  adrp     x8, #0x9598000
0065CF884  ldrb     w8, [x8, #0xfcc]
0065CF888  cbnz     w8, #0x65cf8a4
0065CF88C  adrp     x0, #0x8f06000
0065CF890  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065CF894  bl       #0x382bd14 ; 
0065CF898  adrp     x8, #0x9598000
0065CF89C  mov      w9, #1
0065CF8A0  strb     w9, [x8, #0xfcc]
0065CF8A4  adrp     x8, #0x8f06000
0065CF8A8  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065CF8AC  ldr      x1, [x8]
0065CF8B0  ldrb     w8, [x1, #0x53]
0065CF8B4  tbnz     w8, #5, #0x65cf8c0
0065CF8B8  ldr      x0, [x23, #0x200]
0065CF8BC  b        #0x65cf8cc ; 
0065CF8C0  ldr      x8, [x1, #0x60]
0065CF8C4  mov      x0, x23
0065CF8C8  blr      x8
0065CF8CC  cbz      x0, #0x65cff4c
0065CF8D0  ldr      w1, [sp, #0x6c]
0065CF8D4  mov      x2, xzr
0065CF8D8  bl       #0x64d3fa0 ; LocalModels.LocalModelManager$$GetMission_PositionMonsterFlushConfig
0065CF8DC  cbz      x0, #0x65cfea8
0065CF8E0  adrp     x8, #0x9599000
0065CF8E4  ldrb     w8, [x8, #0x657]
0065CF8E8  mov      x23, x0
0065CF8EC  cbnz     w8, #0x65cf908
0065CF8F0  adrp     x0, #0x8f0a000
0065CF8F4  ldr      x0, [x0, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool()
0065CF8F8  bl       #0x382bd14 ; 
0065CF8FC  mov      w8, #1
0065CF900  adrp     x9, #0x9599000
0065CF904  strb     w8, [x9, #0x657]
0065CF908  adrp     x8, #0x8f0a000
0065CF90C  ldr      x8, [x8, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool()
0065CF910  ldr      x1, [x8]
0065CF914  ldrb     w8, [x1, #0x53]
0065CF918  tbnz     w8, #5, #0x65cf924
0065CF91C  ldr      x0, [x23, #0x28]
0065CF920  b        #0x65cf930 ; 
0065CF924  ldr      x8, [x1, #0x60]
0065CF928  mov      x0, x23
0065CF92C  blr      x8
0065CF930  cbz      x0, #0x65cff4c
0065CF934  ldr      w8, [x0, #0x18]
0065CF938  cmp      w8, #1
0065CF93C  b.lt     #0x65cfe94
0065CF940  cbz      x25, #0x65cff4c
0065CF944  adrp     x8, #0x9599000
0065CF948  ldrb     w8, [x8, #0x26f]
0065CF94C  ldrsw    x19, [x22, #0x10]
0065CF950  cbnz     w8, #0x65cf96c
0065CF954  adrp     x0, #0x8f06000
0065CF958  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData()
0065CF95C  bl       #0x382bd14 ; 
0065CF960  mov      w8, #1
0065CF964  adrp     x9, #0x9599000
0065CF968  strb     w8, [x9, #0x26f]
0065CF96C  adrp     x8, #0x8f06000
0065CF970  ldr      x8, [x8, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData()
0065CF974  ldr      x1, [x8]
0065CF978  ldrb     w8, [x1, #0x53]
0065CF97C  tbnz     w8, #5, #0x65cf988
0065CF980  ldr      x0, [x25, #0x20]
0065CF984  b        #0x65cf994 ; 
0065CF988  ldr      x8, [x1, #0x60]
0065CF98C  mov      x0, x25
0065CF990  blr      x8
0065CF994  cbz      x0, #0x65cff4c
0065CF998  ldr      x8, [x0, #0x140]
0065CF99C  cbz      x8, #0x65cff4c
0065CF9A0  ldr      w9, [x8, #0x18]
0065CF9A4  cmp      w19, w9
0065CF9A8  b.hs     #0x65cff50
0065CF9AC  add      x8, x8, x19, lsl #4
0065CF9B0  ldr      x23, [x8, #0x28]
0065CF9B4  cbz      x23, #0x65cff4c
0065CF9B8  ldr      x8, [x23, #0x18]
0065CF9BC  cmp      w8, #1
0065CF9C0  mov      x29, x8
0065CF9C4  b.lt     #0x65cf9e0
0065CF9C8  ldr      x12, [x23, #0x38]
0065CF9CC  b.ne     #0x65cf9f0
0065CF9D0  adrp     x11, #0x8f05000
0065CF9D4  ldr      x11, [x11, #0xa78] ; GLOBAL HotFix.BattleLogic.MapManager_TypeInfo
0065CF9D8  mov      x19, x12
0065CF9DC  b        #0x65cfa24 ; 
0065CF9E0  str      xzr, [sp, #0x50]
0065CF9E4  mov      x19, xzr
0065CF9E8  str      xzr, [sp, #0x28]
0065CF9EC  b        #0x65cfa68 ; 
0065CF9F0  adrp     x11, #0x8f05000
0065CF9F4  ldr      x11, [x11, #0xa78] ; GLOBAL HotFix.BattleLogic.MapManager_TypeInfo
0065CF9F8  and      x9, x8, #0xffffffff
0065CF9FC  add      x8, x23, #0x70
0065CFA00  sub      x9, x9, #1
0065CFA04  mov      x19, x12
0065CFA08  ldr      x10, [x8], #0x38
0065CFA0C  cmp      x10, x12
0065CFA10  csel     x12, x10, x12, lt
0065CFA14  cmp      x10, x19
0065CFA18  csel     x19, x10, x19, gt
0065CFA1C  subs     x9, x9, #1
0065CFA20  b.ne     #0x65cfa08
0065CFA24  ldr      x8, [x25, #0x10]
0065CFA28  cbz      x8, #0x65cff4c
0065CFA2C  ldr      x0, [x11]
0065CFA30  ldr      x8, [x8, #0x20]
0065CFA34  str      x12, [sp, #0x50]
0065CFA38  ldr      w9, [x0, #0xe0]
0065CFA3C  subs     x8, x12, x8
0065CFA40  cneg     x20, x8, mi
0065CFA44  cbnz     w9, #0x65cfa54
0065CFA48  mov      x22, x11
0065CFA4C  bl       #0x382be8c ; 
0065CFA50  ldr      x0, [x22]
0065CFA54  ldr      x8, [x0, #0xb8]
0065CFA58  ldr      x8, [x8, #0x10]
0065CFA5C  add      x8, x8, x20
0065CFA60  mov      w20, #0x258
0065CFA64  str      x8, [sp, #0x28]
0065CFA68  ldr      w8, [x21, #0xa8]
0065CFA6C  add      w9, w8, w29
0065CFA70  cmp      w9, #0x259
0065CFA74  b.lt     #0x65cfafc
0065CFA78  adrp     x8, #0x8ebf000
0065CFA7C  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo
0065CFA80  add      x1, sp, #0x70
0065CFA84  str      w20, [sp, #0x70]
0065CFA88  ldr      x0, [x8]
0065CFA8C  bl       #0x382be94 ; 
0065CFA90  adrp     x8, #0x8f0a000
0065CFA94  ldr      x8, [x8, #0x958] ; GLOBAL 刷怪数量超过最大数量，超过的部分不会刷出来   请缩小  刷新模板一次延迟刷新怪物数量.限制在{0}内.
0065CFA98  mov      x1, x0
0065CFA9C  mov      x2, xzr
0065CFAA0  ldr      x8, [x8]
0065CFAA4  mov      x0, x8
0065CFAA8  bl       #0x79d140c ; System.String$$Format
0065CFAAC  adrp     x8, #0x8ee1000
0065CFAB0  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
0065CFAB4  mov      x22, x0
0065CFAB8  ldr      x8, [x8]
0065CFABC  ldr      w9, [x8, #0xe0]
0065CFAC0  cbnz     w9, #0x65cfacc
0065CFAC4  mov      x0, x8
0065CFAC8  bl       #0x382be8c ; 
0065CFACC  adrp     x8, #0x8f0a000
0065CFAD0  ldr      x8, [x8, #0x960] ; GLOBAL CreateTileGroupMonster
0065CFAD4  mov      w3, #0x559
0065CFAD8  mov      x0, x22
0065CFADC  mov      x4, xzr
0065CFAE0  ldr      x1, [x8]
0065CFAE4  adrp     x8, #0x8f0a000
0065CFAE8  ldr      x8, [x8, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065CFAEC  ldr      x2, [x8]
0065CFAF0  bl       #0x7997754 ; Logger$$LogError
0065CFAF4  ldr      w8, [x21, #0xa8]
0065CFAF8  sub      w29, w20, w8
0065CFAFC  cmp      w29, #1
0065CFB00  b.lt     #0x65cfe84
0065CFB04  mov      x26, xzr
0065CFB08  mov      w8, w29
0065CFB0C  str      w27, [sp, #0x5c]
0065CFB10  str      x29, [sp, #0x20]
0065CFB14  stp      x8, x23, [sp, #0x30]
0065CFB18  ldr      x28, [x21, #0xa0]
0065CFB1C  cbz      x28, #0x65cff4c
0065CFB20  ldr      w8, [x21, #0xa8]
0065CFB24  ldr      w9, [x28, #0x18]
0065CFB28  add      w20, w8, w26
0065CFB2C  cmp      w20, w9
0065CFB30  b.hs     #0x65cff50
0065CFB34  ldr      w8, [x23, #0x18]
0065CFB38  cmp      x26, x8
0065CFB3C  b.hs     #0x65cff50
0065CFB40  ldr      x29, [x21, #0x188]
0065CFB44  cbz      x29, #0x65cff4c
0065CFB48  mov      w8, #0x38
0065CFB4C  madd     x9, x26, x8, x23
0065CFB50  ldp      x24, x10, [x9, #0x38]
0065CFB54  ldr      x8, [x29]
0065CFB58  mov      x27, x21
0065CFB5C  ldp      x22, x23, [x9, #0x28]
0065CFB60  str      x10, [sp, #0x60]
0065CFB64  adrp     x10, #0x8f09000
0065CFB68  ldp      x21, x25, [x9, #0x48]
0065CFB6C  ldrh     w9, [x8, #0x12e]
0065CFB70  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CFB74  ldr      x1, [x10]
0065CFB78  cbz      x9, #0x65cfb9c
0065CFB7C  ldr      x10, [x8, #0xb0]
0065CFB80  add      x10, x10, #8
0065CFB84  ldur     x11, [x10, #-8]
0065CFB88  cmp      x11, x1
0065CFB8C  b.eq     #0x65cfbac
0065CFB90  subs     x9, x9, #1
0065CFB94  add      x10, x10, #0x10
0065CFB98  b.ne     #0x65cfb84
0065CFB9C  mov      w2, #6
0065CFBA0  mov      x0, x29
0065CFBA4  bl       #0x3a7e710 ; 
0065CFBA8  b        #0x65cfbbc ; 
0065CFBAC  ldr      w9, [x10]
0065CFBB0  add      w9, w9, #6
0065CFBB4  add      x8, x8, w9, sxtw #4
0065CFBB8  add      x0, x8, #0x138
0065CFBBC  ldp      x8, x1, [x0]
0065CFBC0  mov      x0, x29
0065CFBC4  blr      x8
0065CFBC8  adrp     x8, #0x8f0a000
0065CFBCC  ldr      x8, [x8, #0x940] ; GLOBAL Method$System.Collections.Generic.List<MonsterGroupFlushConfig>.get_Item()
0065CFBD0  mov      x29, x0
0065CFBD4  ldr      x0, [sp, #0x40]
0065CFBD8  ldr      w1, [sp, #0x5c]
0065CFBDC  ldr      x2, [x8]
0065CFBE0  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065CFBE4  cbz      x0, #0x65cff4c
0065CFBE8  ldr      x9, [sp, #0x48]
0065CFBEC  ldr      x8, [x0, #0x20]
0065CFBF0  sxtw     x20, w20
0065CFBF4  add      x9, x21, x9
0065CFBF8  add      x9, x9, x29
0065CFBFC  add      x8, x9, x8
0065CFC00  add      x21, x28, x20, lsl #7
0065CFC04  str      x8, [x21, #0x20]
0065CFC08  adrp     x29, #0x8ee8000
0065CFC0C  ldr      x29, [x29, #0x898] ; GLOBAL LocalModels.Const_TypeInfo
0065CFC10  ldr      x0, [x29]
0065CFC14  ldr      w8, [x0, #0xe0]
0065CFC18  cbnz     w8, #0x65cfc24
0065CFC1C  bl       #0x382be8c ; 
0065CFC20  ldr      x0, [x29]
0065CFC24  ldr      x8, [x0, #0xb8]
0065CFC28  ldr      x8, [x8, #0xb0]
0065CFC2C  str      x8, [x21, #0x28]
0065CFC30  adrp     x8, #0x9599000
0065CFC34  ldrb     w8, [x8, #0x286]
0065CFC38  cbnz     w8, #0x65cfc54
0065CFC3C  adrp     x0, #0x8f07000
0065CFC40  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CFC44  bl       #0x382bd14 ; 
0065CFC48  adrp     x8, #0x9599000
0065CFC4C  mov      w9, #1
0065CFC50  strb     w9, [x8, #0x286]
0065CFC54  adrp     x8, #0x8f07000
0065CFC58  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CFC5C  ldr      x1, [x8]
0065CFC60  ldrb     w8, [x1, #0x53]
0065CFC64  tbnz     w8, #5, #0x65cfc70
0065CFC68  ldr      x29, [x27, #0x80]
0065CFC6C  b        #0x65cfc80 ; 
0065CFC70  ldr      x8, [x1, #0x60]
0065CFC74  mov      x0, x27
0065CFC78  blr      x8
0065CFC7C  mov      x29, x0
0065CFC80  cbz      x29, #0x65cff4c
0065CFC84  adrp     x8, #0x9598000
0065CFC88  ldrb     w8, [x8, #0xfcc]
0065CFC8C  cbnz     w8, #0x65cfca8
0065CFC90  adrp     x0, #0x8f06000
0065CFC94  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065CFC98  bl       #0x382bd14 ; 
0065CFC9C  adrp     x8, #0x9598000
0065CFCA0  mov      w9, #1
0065CFCA4  strb     w9, [x8, #0xfcc]
0065CFCA8  adrp     x8, #0x8f06000
0065CFCAC  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065CFCB0  ldr      x1, [x8]
0065CFCB4  ldrb     w8, [x1, #0x53]
0065CFCB8  tbnz     w8, #5, #0x65cfcc4
0065CFCBC  ldr      x0, [x29, #0x200]
0065CFCC0  b        #0x65cfcd0 ; 
0065CFCC4  ldr      x8, [x1, #0x60]
0065CFCC8  mov      x0, x29
0065CFCCC  blr      x8
0065CFCD0  cbz      x0, #0x65cff4c
0065CFCD4  ldr      w1, [sp, #0x68]
0065CFCD8  mov      x2, xzr
0065CFCDC  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065CFCE0  mov      x29, x0
0065CFCE4  cbz      x0, #0x65cfd4c
0065CFCE8  adrp     x8, #0x9599000
0065CFCEC  ldrb     w8, [x8, #0x29e]
0065CFCF0  cbnz     w8, #0x65cfd0c
0065CFCF4  adrp     x0, #0x8f08000
0065CFCF8  ldr      x0, [x0, #0x90] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_bornType()
0065CFCFC  bl       #0x382bd14 ; 
0065CFD00  mov      w8, #1
0065CFD04  adrp     x9, #0x9599000
0065CFD08  strb     w8, [x9, #0x29e]
0065CFD0C  adrp     x8, #0x8f08000
0065CFD10  ldr      x8, [x8, #0x90] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_bornType()
0065CFD14  ldr      x1, [x8]
0065CFD18  ldrb     w8, [x1, #0x53]
0065CFD1C  tbnz     w8, #5, #0x65cfd28
0065CFD20  ldr      w0, [x29, #0x120]
0065CFD24  b        #0x65cfd34 ; 
0065CFD28  ldr      x8, [x1, #0x60]
0065CFD2C  mov      x0, x29
0065CFD30  blr      x8
0065CFD34  cmp      w0, #1
0065CFD38  b.ne     #0x65cfd4c
0065CFD3C  add      x8, x28, x20, lsl #7
0065CFD40  stp      x22, x23, [x8, #0x30]
0065CFD44  str      x24, [x8, #0x40]
0065CFD48  b        #0x65cfd84 ; 
0065CFD4C  ldr      x8, [sp, #0x28]
0065CFD50  add      x0, sp, #0x70
0065CFD54  mov      x1, x22
0065CFD58  mov      x2, x23
0065CFD5C  add      x3, x24, x8
0065CFD60  mov      x4, xzr
0065CFD64  stp      xzr, xzr, [sp, #0x70]
0065CFD68  str      xzr, [sp, #0x80]
0065CFD6C  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065CFD70  ldr      x8, [sp, #0x80]
0065CFD74  ldr      q0, [sp, #0x70]
0065CFD78  add      x9, x28, x20, lsl #7
0065CFD7C  str      x8, [x9, #0x40]
0065CFD80  str      q0, [x9, #0x30]
0065CFD84  ldr      w8, [sp, #0x68]
0065CFD88  add      x21, x28, x20, lsl #7
0065CFD8C  str      x25, [x21, #0x70]!
0065CFD90  mov      x0, x21
0065CFD94  stur     w8, [x21, #-0x10]
0065CFD98  ldr      x8, [sp, #0x60]
0065CFD9C  mov      x1, x25
0065CFDA0  str      wzr, [x21, #0x10]
0065CFDA4  stp      x22, x23, [x21, #-0x28]
0065CFDA8  stur     x24, [x21, #-0x18]
0065CFDAC  stur     x8, [x21, #-8]
0065CFDB0  bl       #0x382bcb8 ; 
0065CFDB4  ldr      x9, [sp, #0x50]
0065CFDB8  sub      x8, x24, x19
0065CFDBC  str      xzr, [x21, #8]
0065CFDC0  sub      x9, x24, x9
0065CFDC4  stp      x8, x9, [x21, #0x18]
0065CFDC8  ldr      x22, [x27, #0x188]
0065CFDCC  cbz      x22, #0x65cff4c
0065CFDD0  ldr      x8, [x22]
0065CFDD4  adrp     x10, #0x8f09000
0065CFDD8  mov      x21, x27
0065CFDDC  ldrh     w9, [x8, #0x12e]
0065CFDE0  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CFDE4  ldr      x23, [sp, #0x38]
0065CFDE8  ldr      x1, [x10]
0065CFDEC  cbz      x9, #0x65cfe10
0065CFDF0  ldr      x10, [x8, #0xb0]
0065CFDF4  add      x10, x10, #8
0065CFDF8  ldur     x11, [x10, #-8]
0065CFDFC  cmp      x11, x1
0065CFE00  b.eq     #0x65cfe20
0065CFE04  subs     x9, x9, #1
0065CFE08  add      x10, x10, #0x10
0065CFE0C  b.ne     #0x65cfdf8
0065CFE10  mov      x0, x22
0065CFE14  mov      w2, wzr
0065CFE18  bl       #0x3a7e710 ; 
0065CFE1C  b        #0x65cfe2c ; 
0065CFE20  ldrsw    x9, [x10]
0065CFE24  add      x8, x8, x9, lsl #4
0065CFE28  add      x0, x8, #0x138
0065CFE2C  ldp      x8, x1, [x0]
0065CFE30  mov      x0, x22
0065CFE34  blr      x8
0065CFE38  add      x20, x28, x20, lsl #7
0065CFE3C  str      w0, [x20, #0x98]
0065CFE40  mov      x0, x21
0065CFE44  mov      x1, x29
0065CFE48  bl       #0x65d0b58 ; HotFix.BattleLogic.WaterfallBattleManager$$AddGoldMonster
0065CFE4C  ldr      x9, [sp, #0x30]
0065CFE50  add      x26, x26, #1
0065CFE54  and      w8, w0, #1
0065CFE58  strb     w8, [x20, #0x9c]
0065CFE5C  cmp      x26, x9
0065CFE60  b.ne     #0x65cfb18
0065CFE64  adrp     x28, #0x8f0a000
0065CFE68  ldr      w8, [x21, #0xa8]
0065CFE6C  ldp      x24, x25, [sp, #0x10]
0065CFE70  ldr      x26, [sp, #0x40]
0065CFE74  ldr      w27, [sp, #0x5c]
0065CFE78  ldr      x28, [x28, #0x948] ; GLOBAL Method$System.Collections.Generic.List<MissionPositionGroupMonsterRandomData>.get_Item()
0065CFE7C  ldr      x29, [sp, #0x20]
0065CFE80  mov      w20, #0x258
0065CFE84  add      w8, w8, w29
0065CFE88  str      w8, [x21, #0xa8]
0065CFE8C  adrp     x19, #0x8f0a000
0065CFE90  ldr      x19, [x19, #0x940] ; GLOBAL Method$System.Collections.Generic.List<MonsterGroupFlushConfig>.get_Item()
0065CFE94  ldr      w8, [x26, #0x18]
0065CFE98  add      w27, w27, #1
0065CFE9C  cmp      w27, w8
0065CFEA0  b.lt     #0x65cf7bc
0065CFEA4  b        #0x65cff18 ; 
0065CFEA8  add      x0, sp, #0x6c
0065CFEAC  mov      x1, xzr
0065CFEB0  bl       #0x7bd22a0 ; System.Int32$$ToString
0065CFEB4  adrp     x8, #0x8f0a000
0065CFEB8  ldr      x8, [x8, #0x950] ; GLOBAL 刷怪配置不存在 flushConfigId = 
0065CFEBC  mov      x1, x0
0065CFEC0  mov      x2, xzr
0065CFEC4  ldr      x8, [x8]
0065CFEC8  mov      x0, x8
0065CFECC  bl       #0x79d469c ; System.String$$Concat
0065CFED0  adrp     x8, #0x8ee1000
0065CFED4  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
0065CFED8  mov      x19, x0
0065CFEDC  ldr      x8, [x8]
0065CFEE0  ldr      w9, [x8, #0xe0]
0065CFEE4  cbnz     w9, #0x65cfef0
0065CFEE8  mov      x0, x8
0065CFEEC  bl       #0x382be8c ; 
0065CFEF0  adrp     x8, #0x8f0a000
0065CFEF4  ldr      x8, [x8, #0x960] ; GLOBAL CreateTileGroupMonster
0065CFEF8  mov      w3, #0x531
0065CFEFC  mov      x0, x19
0065CFF00  mov      x4, xzr
0065CFF04  ldr      x1, [x8]
0065CFF08  adrp     x8, #0x8f0a000
0065CFF0C  ldr      x8, [x8, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065CFF10  ldr      x2, [x8]
0065CFF14  bl       #0x7997754 ; Logger$$LogError
0065CFF18  ldr      x8, [sp, #8]
0065CFF1C  ldr      x8, [x8, #0x28]
0065CFF20  ldr      x9, [sp, #0x88]
0065CFF24  cmp      x8, x9
0065CFF28  b.ne     #0x65cff54
0065CFF2C  ldp      x20, x19, [sp, #0xe0]
0065CFF30  ldp      x22, x21, [sp, #0xd0]
0065CFF34  ldp      x24, x23, [sp, #0xc0]
0065CFF38  ldp      x26, x25, [sp, #0xb0]
0065CFF3C  ldp      x28, x27, [sp, #0xa0]
0065CFF40  ldp      x29, x30, [sp, #0x90]
0065CFF44  add      sp, sp, #0xf0
0065CFF48  ret      
0065CFF4C  bl       #0x382bfb8 ; 
0065CFF50  bl       #0x382bfc0 ; 
0065CFF54  bl       #0x89edb60 ; 

