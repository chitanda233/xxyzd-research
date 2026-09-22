; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileMonster
; RVA 0x65CE8E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CE8E8  sub      sp, sp, #0xe0
0065CE8EC  stp      x29, x30, [sp, #0x80]
0065CE8F0  stp      x28, x27, [sp, #0x90]
0065CE8F4  stp      x26, x25, [sp, #0xa0]
0065CE8F8  stp      x24, x23, [sp, #0xb0]
0065CE8FC  stp      x22, x21, [sp, #0xc0]
0065CE900  stp      x20, x19, [sp, #0xd0]
0065CE904  str      x1, [sp, #0x40]
0065CE908  mrs      x24, tpidr_el0
0065CE90C  ldr      x8, [x24, #0x28]
0065CE910  adrp     x20, #0x9599000
0065CE914  adrp     x21, #0x8f0a000
0065CE918  mov      x19, x0
0065CE91C  str      x8, [sp, #0x78]
0065CE920  ldrb     w8, [x20, #0x585]
0065CE924  ldr      x21, [x21, #0x908] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreateTileMonster()
0065CE928  tbnz     w8, #0, #0x65ce9ac
0065CE92C  adrp     x0, #0x8ee8000
0065CE930  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo
0065CE934  bl       #0x382bd14 ; 
0065CE938  adrp     x0, #0x8f0a000
0065CE93C  ldr      x0, [x0, #0x910] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.get_Item()
0065CE940  bl       #0x382bd14 ; 
0065CE944  adrp     x0, #0x8f09000
0065CE948  ldr      x0, [x0, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CE94C  bl       #0x382bd14 ; 
0065CE950  adrp     x0, #0x8ee1000
0065CE954  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo
0065CE958  bl       #0x382bd14 ; 
0065CE95C  adrp     x0, #0x8f05000
0065CE960  ldr      x0, [x0, #0xa78] ; GLOBAL HotFix.BattleLogic.MapManager_TypeInfo
0065CE964  bl       #0x382bd14 ; 
0065CE968  adrp     x0, #0x8f0a000
0065CE96C  ldr      x0, [x0, #0x908] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreateTileMonster()
0065CE970  bl       #0x382bd14 ; 
0065CE974  adrp     x0, #0x8f0a000
0065CE978  ldr      x0, [x0, #0x918] ; GLOBAL 刷怪数量超过最大数量，超过的部分不会刷出来
0065CE97C  bl       #0x382bd14 ; 
0065CE980  adrp     x0, #0x8f0a000
0065CE984  ldr      x0, [x0, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065CE988  bl       #0x382bd14 ; 
0065CE98C  adrp     x0, #0x8f0a000
0065CE990  ldr      x0, [x0, #0x8c8] ; GLOBAL 刷怪配置不存在
0065CE994  bl       #0x382bd14 ; 
0065CE998  adrp     x0, #0x8f0a000
0065CE99C  ldr      x0, [x0, #0x920] ; GLOBAL CreateTileMonster
0065CE9A0  bl       #0x382bd14 ; 
0065CE9A4  mov      w8, #1
0065CE9A8  strb     w8, [x20, #0x585]
0065CE9AC  ldr      x2, [x21]
0065CE9B0  ldrb     w8, [x2, #0x53]
0065CE9B4  tbnz     w8, #5, #0x65ce9fc
0065CE9B8  adrp     x8, #0x9599000
0065CE9BC  ldrb     w8, [x8, #0x286]
0065CE9C0  cbnz     w8, #0x65ce9dc
0065CE9C4  adrp     x0, #0x8f07000
0065CE9C8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CE9CC  bl       #0x382bd14 ; 
0065CE9D0  mov      w8, #1
0065CE9D4  adrp     x9, #0x9599000
0065CE9D8  strb     w8, [x9, #0x286]
0065CE9DC  adrp     x8, #0x8f07000
0065CE9E0  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CE9E4  mov      x27, x19
0065CE9E8  ldr      x1, [x8]
0065CE9EC  ldrb     w8, [x1, #0x53]
0065CE9F0  tbnz     w8, #5, #0x65cea10
0065CE9F4  ldr      x22, [x19, #0x80]
0065CE9F8  b        #0x65cea20 ; 
0065CE9FC  ldr      x8, [x2, #0x60]
0065CEA00  ldr      x1, [sp, #0x40]
0065CEA04  mov      x0, x19
0065CEA08  blr      x8
0065CEA0C  b        #0x65cf320 ; 
0065CEA10  ldr      x8, [x1, #0x60]
0065CEA14  mov      x0, x19
0065CEA18  blr      x8
0065CEA1C  mov      x22, x0
0065CEA20  cbz      x22, #0x65cf350
0065CEA24  adrp     x20, #0x9591000
0065CEA28  ldrb     w8, [x20, #0xa9c]
0065CEA2C  cbnz     w8, #0x65cea44
0065CEA30  adrp     x0, #0x8ee6000
0065CEA34  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065CEA38  bl       #0x382bd14 ; 
0065CEA3C  mov      w8, #1
0065CEA40  strb     w8, [x20, #0xa9c]
0065CEA44  adrp     x8, #0x8ee6000
0065CEA48  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065CEA4C  ldr      x1, [x8]
0065CEA50  ldrb     w8, [x1, #0x53]
0065CEA54  tbnz     w8, #5, #0x65cea60
0065CEA58  ldr      x21, [x22, #0x240]
0065CEA5C  b        #0x65cea70 ; 
0065CEA60  ldr      x8, [x1, #0x60]
0065CEA64  mov      x0, x22
0065CEA68  blr      x8
0065CEA6C  mov      x21, x0
0065CEA70  cbz      x21, #0x65cf350
0065CEA74  adrp     x20, #0x9599000
0065CEA78  ldrb     w8, [x20, #0x26f]
0065CEA7C  mov      x19, x27
0065CEA80  cbnz     w8, #0x65cea98
0065CEA84  adrp     x0, #0x8f06000
0065CEA88  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData()
0065CEA8C  bl       #0x382bd14 ; 
0065CEA90  mov      w8, #1
0065CEA94  strb     w8, [x20, #0x26f]
0065CEA98  adrp     x23, #0x8f06000
0065CEA9C  ldr      x23, [x23, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData()
0065CEAA0  ldr      x1, [x23]
0065CEAA4  ldrb     w8, [x1, #0x53]
0065CEAA8  tbnz     w8, #5, #0x65ceab4
0065CEAAC  ldr      x0, [x21, #0x20]
0065CEAB0  b        #0x65ceac0 ; 
0065CEAB4  ldr      x8, [x1, #0x60]
0065CEAB8  mov      x0, x21
0065CEABC  blr      x8
0065CEAC0  cbz      x0, #0x65cf350
0065CEAC4  ldr      x26, [x0, #0x158]
0065CEAC8  cbz      x26, #0x65cf320
0065CEACC  str      x24, [sp]
0065CEAD0  ldr      x24, [x19, #0x188]
0065CEAD4  cbz      x24, #0x65cf350
0065CEAD8  adrp     x10, #0x8f09000
0065CEADC  ldr      x8, [x24]
0065CEAE0  ldr      x22, [x19, #0x1f0]
0065CEAE4  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CEAE8  ldrh     w9, [x8, #0x12e]
0065CEAEC  ldr      x1, [x10]
0065CEAF0  cbz      x9, #0x65ceb14
0065CEAF4  ldr      x10, [x8, #0xb0]
0065CEAF8  add      x10, x10, #8
0065CEAFC  ldur     x11, [x10, #-8]
0065CEB00  cmp      x11, x1
0065CEB04  b.eq     #0x65ceb24
0065CEB08  subs     x9, x9, #1
0065CEB0C  add      x10, x10, #0x10
0065CEB10  b.ne     #0x65ceafc
0065CEB14  mov      x0, x24
0065CEB18  mov      w2, wzr
0065CEB1C  bl       #0x3a7e710 ; 
0065CEB20  b        #0x65ceb30 ; 
0065CEB24  ldrsw    x9, [x10]
0065CEB28  add      x8, x8, x9, lsl #4
0065CEB2C  add      x0, x8, #0x138
0065CEB30  ldp      x8, x1, [x0]
0065CEB34  mov      x0, x24
0065CEB38  blr      x8
0065CEB3C  cbz      x22, #0x65cf350
0065CEB40  adrp     x8, #0x8f0a000
0065CEB44  ldr      x8, [x8, #0x910] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.get_Item()
0065CEB48  mov      w1, w0
0065CEB4C  mov      x0, x22
0065CEB50  ldr      x2, [x8]
0065CEB54  bl       #0x5e5f99c ; System.Collections.Generic.Dictionary<int, object>$$get_Item
0065CEB58  ldr      x24, [x27, #0x188]
0065CEB5C  cbz      x24, #0x65cf350
0065CEB60  ldr      x8, [x24]
0065CEB64  adrp     x10, #0x8f09000
0065CEB68  mov      x22, x27
0065CEB6C  ldrh     w9, [x8, #0x12e]
0065CEB70  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CEB74  str      x0, [sp, #0x18]
0065CEB78  ldr      x1, [x10]
0065CEB7C  cbz      x9, #0x65ceba0
0065CEB80  ldr      x10, [x8, #0xb0]
0065CEB84  add      x10, x10, #8
0065CEB88  ldur     x11, [x10, #-8]
0065CEB8C  cmp      x11, x1
0065CEB90  b.eq     #0x65cebb0
0065CEB94  subs     x9, x9, #1
0065CEB98  add      x10, x10, #0x10
0065CEB9C  b.ne     #0x65ceb88
0065CEBA0  mov      w2, #0xe
0065CEBA4  mov      x0, x24
0065CEBA8  bl       #0x3a7e710 ; 
0065CEBAC  b        #0x65cebc0 ; 
0065CEBB0  ldr      w9, [x10]
0065CEBB4  add      w9, w9, #0xe
0065CEBB8  add      x8, x8, w9, sxtw #4
0065CEBBC  add      x0, x8, #0x138
0065CEBC0  ldp      x8, x1, [x0]
0065CEBC4  mov      x0, x24
0065CEBC8  blr      x8
0065CEBCC  cmp      w0, #1
0065CEBD0  b.lt     #0x65ceda4
0065CEBD4  adrp     x8, #0x9599000
0065CEBD8  ldrb     w8, [x8, #0x286]
0065CEBDC  mov      w24, w0
0065CEBE0  cbnz     w8, #0x65cebfc
0065CEBE4  adrp     x0, #0x8f07000
0065CEBE8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CEBEC  bl       #0x382bd14 ; 
0065CEBF0  mov      w8, #1
0065CEBF4  adrp     x9, #0x9599000
0065CEBF8  strb     w8, [x9, #0x286]
0065CEBFC  adrp     x8, #0x8f07000
0065CEC00  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CEC04  ldr      x1, [x8]
0065CEC08  ldrb     w8, [x1, #0x53]
0065CEC0C  tbnz     w8, #5, #0x65cec18
0065CEC10  ldr      x25, [x22, #0x80]
0065CEC14  b        #0x65cec28 ; 
0065CEC18  ldr      x8, [x1, #0x60]
0065CEC1C  mov      x0, x22
0065CEC20  blr      x8
0065CEC24  mov      x25, x0
0065CEC28  cbz      x25, #0x65cf350
0065CEC2C  adrp     x22, #0x9598000
0065CEC30  ldrb     w8, [x22, #0xfcc]
0065CEC34  cbnz     w8, #0x65cec4c
0065CEC38  adrp     x0, #0x8f06000
0065CEC3C  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065CEC40  bl       #0x382bd14 ; 
0065CEC44  mov      w8, #1
0065CEC48  strb     w8, [x22, #0xfcc]
0065CEC4C  adrp     x8, #0x8f06000
0065CEC50  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065CEC54  ldr      x1, [x8]
0065CEC58  ldrb     w8, [x1, #0x53]
0065CEC5C  tbnz     w8, #5, #0x65cec68
0065CEC60  ldr      x0, [x25, #0x200]
0065CEC64  b        #0x65cec74 ; 
0065CEC68  ldr      x8, [x1, #0x60]
0065CEC6C  mov      x0, x25
0065CEC70  blr      x8
0065CEC74  cbz      x0, #0x65cf350
0065CEC78  mov      w1, w24
0065CEC7C  mov      x2, xzr
0065CEC80  bl       #0x64d3fa0 ; LocalModels.LocalModelManager$$GetMission_PositionMonsterFlushConfig
0065CEC84  cbz      x0, #0x65cecc8
0065CEC88  adrp     x22, #0x9599000
0065CEC8C  ldrb     w8, [x22, #0x657]
0065CEC90  mov      x24, x0
0065CEC94  cbnz     w8, #0x65cecac
0065CEC98  adrp     x0, #0x8f0a000
0065CEC9C  ldr      x0, [x0, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool()
0065CECA0  bl       #0x382bd14 ; 
0065CECA4  mov      w8, #1
0065CECA8  strb     w8, [x22, #0x657]
0065CECAC  adrp     x8, #0x8f0a000
0065CECB0  ldr      x8, [x8, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool()
0065CECB4  ldr      x1, [x8]
0065CECB8  ldrb     w8, [x1, #0x53]
0065CECBC  tbnz     w8, #5, #0x65ced1c
0065CECC0  ldr      x0, [x24, #0x28]
0065CECC4  b        #0x65ced28 ; 
0065CECC8  adrp     x8, #0x8ee1000
0065CECCC  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
0065CECD0  ldr      x0, [x8]
0065CECD4  ldr      w8, [x0, #0xe0]
0065CECD8  cbnz     w8, #0x65cece0
0065CECDC  bl       #0x382be8c ; 
0065CECE0  adrp     x8, #0x8f0a000
0065CECE4  adrp     x9, #0x8f0a000
0065CECE8  adrp     x10, #0x8f0a000
0065CECEC  ldr      x8, [x8, #0x8c8] ; GLOBAL 刷怪配置不存在
0065CECF0  ldr      x9, [x9, #0x920] ; GLOBAL CreateTileMonster
0065CECF4  ldr      x10, [x10, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065CECF8  mov      w3, #0x2e2
0065CECFC  ldr      x0, [x8]
0065CED00  ldr      x1, [x9]
0065CED04  ldr      x2, [x10]
0065CED08  mov      x4, xzr
0065CED0C  bl       #0x7997754 ; Logger$$LogError
0065CED10  ldr      x8, [sp]
0065CED14  ldr      x8, [x8, #0x28]
0065CED18  b        #0x65cf324 ; 
0065CED1C  ldr      x8, [x1, #0x60]
0065CED20  mov      x0, x24
0065CED24  blr      x8
0065CED28  mov      x22, x27
0065CED2C  cbz      x0, #0x65cf350
0065CED30  ldr      x8, [x0, #0x18]
0065CED34  ldr      x9, [sp, #0x18]
0065CED38  cbz      x8, #0x65ceda4
0065CED3C  cbz      x9, #0x65cf350
0065CED40  ldrb     w8, [x20, #0x26f]
0065CED44  ldrsw    x22, [x9, #0x10]
0065CED48  cbnz     w8, #0x65ced60
0065CED4C  adrp     x0, #0x8f06000
0065CED50  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData()
0065CED54  bl       #0x382bd14 ; 
0065CED58  mov      w8, #1
0065CED5C  strb     w8, [x20, #0x26f]
0065CED60  ldr      x1, [x23]
0065CED64  ldrb     w8, [x1, #0x53]
0065CED68  tbnz     w8, #5, #0x65ced74
0065CED6C  ldr      x0, [x21, #0x20]
0065CED70  b        #0x65ced80 ; 
0065CED74  ldr      x8, [x1, #0x60]
0065CED78  mov      x0, x21
0065CED7C  blr      x8
0065CED80  cbz      x0, #0x65cf350
0065CED84  ldr      x8, [x0, #0x140]
0065CED88  cbz      x8, #0x65cf350
0065CED8C  ldr      w9, [x8, #0x18]
0065CED90  cmp      w22, w9
0065CED94  b.hs     #0x65cf354
0065CED98  add      x8, x8, x22, lsl #4
0065CED9C  ldr      x26, [x8, #0x28]
0065CEDA0  mov      x22, x27
0065CEDA4  cbz      x26, #0x65cf350
0065CEDA8  ldr      w9, [x26, #0x18]
0065CEDAC  ldr      w8, [x22, #0xa8]
0065CEDB0  add      w8, w8, w9
0065CEDB4  cmp      w8, #0x259
0065CEDB8  b.lt     #0x65cee10
0065CEDBC  adrp     x8, #0x8ee1000
0065CEDC0  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
0065CEDC4  ldr      x0, [x8]
0065CEDC8  ldr      w8, [x0, #0xe0]
0065CEDCC  cbnz     w8, #0x65cedd4
0065CEDD0  bl       #0x382be8c ; 
0065CEDD4  adrp     x8, #0x8f0a000
0065CEDD8  adrp     x9, #0x8f0a000
0065CEDDC  adrp     x10, #0x8f0a000
0065CEDE0  ldr      x8, [x8, #0x918] ; GLOBAL 刷怪数量超过最大数量，超过的部分不会刷出来
0065CEDE4  ldr      x9, [x9, #0x920] ; GLOBAL CreateTileMonster
0065CEDE8  ldr      x10, [x10, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065CEDEC  mov      w3, #0x2f1
0065CEDF0  ldr      x0, [x8]
0065CEDF4  ldr      x1, [x9]
0065CEDF8  ldr      x2, [x10]
0065CEDFC  mov      x4, xzr
0065CEE00  bl       #0x7997754 ; Logger$$LogError
0065CEE04  ldr      w8, [x22, #0xa8]
0065CEE08  mov      w9, #0x258
0065CEE0C  sub      w9, w9, w8
0065CEE10  cmp      w9, #1
0065CEE14  str      w9, [sp, #0xc]
0065CEE18  b.lt     #0x65cf30c
0065CEE1C  ldr      w9, [x26, #0x18]
0065CEE20  cbz      w9, #0x65cf354
0065CEE24  ldr      w23, [sp, #0xc]
0065CEE28  ldr      x19, [x26, #0x38]
0065CEE2C  subs     w8, w23, #2
0065CEE30  b.lt     #0x65cee70
0065CEE34  mov      w11, w23
0065CEE38  sub      w9, w9, #1
0065CEE3C  add      x10, x26, #0x70
0065CEE40  sub      x11, x11, #1
0065CEE44  mov      x24, x19
0065CEE48  cmp      w9, w8
0065CEE4C  b.ls     #0x65cf354
0065CEE50  ldr      x12, [x10], #0x38
0065CEE54  cmp      x12, x19
0065CEE58  csel     x19, x12, x19, lt
0065CEE5C  cmp      x12, x24
0065CEE60  csel     x24, x12, x24, gt
0065CEE64  subs     x11, x11, #1
0065CEE68  b.ne     #0x65cee48
0065CEE6C  b        #0x65cee74 ; 
0065CEE70  mov      x24, x19
0065CEE74  ldr      x8, [x21, #0x10]
0065CEE78  cbz      x8, #0x65cf350
0065CEE7C  adrp     x20, #0x8f05000
0065CEE80  ldr      x20, [x20, #0xa78] ; GLOBAL HotFix.BattleLogic.MapManager_TypeInfo
0065CEE84  ldr      x8, [x8, #0x20]
0065CEE88  ldr      x0, [x20]
0065CEE8C  subs     x8, x19, x8
0065CEE90  cneg     x21, x8, mi
0065CEE94  ldr      w9, [x0, #0xe0]
0065CEE98  cbnz     w9, #0x65ceea4
0065CEE9C  bl       #0x382be8c ; 
0065CEEA0  ldr      x0, [x20]
0065CEEA4  cmp      w23, #1
0065CEEA8  b.lt     #0x65cf30c
0065CEEAC  ldr      w9, [sp, #0xc]
0065CEEB0  ldr      x8, [x0, #0xb8]
0065CEEB4  adrp     x27, #0x8ee8000
0065CEEB8  mov      x20, xzr
0065CEEBC  mov      w9, w9
0065CEEC0  str      x9, [sp, #0x20]
0065CEEC4  ldr      x27, [x27, #0x898] ; GLOBAL LocalModels.Const_TypeInfo
0065CEEC8  ldr      x8, [x8, #0x10]
0065CEECC  stp      x26, x24, [sp, #0x28]
0065CEED0  str      x19, [sp, #0x38]
0065CEED4  add      x8, x8, x21
0065CEED8  str      x8, [sp, #0x10]
0065CEEDC  ldr      x23, [x22, #0xa0]
0065CEEE0  cbz      x23, #0x65cf350
0065CEEE4  ldr      w8, [x22, #0xa8]
0065CEEE8  ldr      w9, [x23, #0x18]
0065CEEEC  add      w21, w8, w20
0065CEEF0  cmp      w21, w9
0065CEEF4  b.hs     #0x65cf354
0065CEEF8  ldr      w8, [x26, #0x18]
0065CEEFC  cmp      x20, x8
0065CEF00  b.hs     #0x65cf354
0065CEF04  ldr      x29, [x22, #0x188]
0065CEF08  cbz      x29, #0x65cf350
0065CEF0C  mov      w8, #0x38
0065CEF10  madd     x9, x20, x8, x26
0065CEF14  ldr      w10, [x9, #0x20]
0065CEF18  ldr      x8, [x29]
0065CEF1C  mov      x19, x22
0065CEF20  ldp      x28, x24, [x9, #0x28]
0065CEF24  str      w10, [sp, #0x5c]
0065CEF28  adrp     x10, #0x8f09000
0065CEF2C  ldp      x25, x13, [x9, #0x38]
0065CEF30  ldp      x22, x12, [x9, #0x48]
0065CEF34  ldrh     w9, [x8, #0x12e]
0065CEF38  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CEF3C  stp      x13, x12, [sp, #0x48]
0065CEF40  ldr      x1, [x10]
0065CEF44  cbz      x9, #0x65cef68
0065CEF48  ldr      x10, [x8, #0xb0]
0065CEF4C  add      x10, x10, #8
0065CEF50  ldur     x11, [x10, #-8]
0065CEF54  cmp      x11, x1
0065CEF58  b.eq     #0x65cef78
0065CEF5C  subs     x9, x9, #1
0065CEF60  add      x10, x10, #0x10
0065CEF64  b.ne     #0x65cef50
0065CEF68  mov      w2, #6
0065CEF6C  mov      x0, x29
0065CEF70  bl       #0x3a7e710 ; 
0065CEF74  b        #0x65cef88 ; 
0065CEF78  ldr      w9, [x10]
0065CEF7C  add      w9, w9, #6
0065CEF80  add      x8, x8, w9, sxtw #4
0065CEF84  add      x0, x8, #0x138
0065CEF88  ldp      x8, x1, [x0]
0065CEF8C  mov      x0, x29
0065CEF90  sxtw     x21, w21
0065CEF94  blr      x8
0065CEF98  ldr      x8, [sp, #0x40]
0065CEF9C  mov      x26, x21
0065CEFA0  add      x21, x23, x21, lsl #7
0065CEFA4  add      x8, x22, x8
0065CEFA8  add      x8, x8, x0
0065CEFAC  str      x8, [x21, #0x20]
0065CEFB0  ldr      x0, [x27]
0065CEFB4  ldr      w8, [x0, #0xe0]
0065CEFB8  cbnz     w8, #0x65cefc4
0065CEFBC  bl       #0x382be8c ; 
0065CEFC0  ldr      x0, [x27]
0065CEFC4  ldr      x8, [x0, #0xb8]
0065CEFC8  mov      x22, x19
0065CEFCC  ldr      x8, [x8, #0xb0]
0065CEFD0  str      x8, [x21, #0x28]
0065CEFD4  ldr      x29, [x19, #0x188]
0065CEFD8  cbz      x29, #0x65cf350
0065CEFDC  ldr      x8, [x29]
0065CEFE0  adrp     x10, #0x8f09000
0065CEFE4  mov      x19, x24
0065CEFE8  mov      x24, x28
0065CEFEC  ldrh     w9, [x8, #0x12e]
0065CEFF0  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CEFF4  ldr      w28, [sp, #0x5c]
0065CEFF8  ldr      x1, [x10]
0065CEFFC  cbz      x9, #0x65cf020
0065CF000  ldr      x10, [x8, #0xb0]
0065CF004  add      x10, x10, #8
0065CF008  ldur     x11, [x10, #-8]
0065CF00C  cmp      x11, x1
0065CF010  b.eq     #0x65cf030
0065CF014  subs     x9, x9, #1
0065CF018  add      x10, x10, #0x10
0065CF01C  b.ne     #0x65cf008
0065CF020  mov      w2, #0x10
0065CF024  mov      x0, x29
0065CF028  bl       #0x3a7e710 ; 
0065CF02C  b        #0x65cf040 ; 
0065CF030  ldr      w9, [x10]
0065CF034  add      w9, w9, #0x10
0065CF038  add      x8, x8, w9, sxtw #4
0065CF03C  add      x0, x8, #0x138
0065CF040  ldp      x8, x1, [x0]
0065CF044  mov      x0, x29
0065CF048  blr      x8
0065CF04C  cbz      x0, #0x65cf350
0065CF050  ldr      x8, [x0, #0x18]
0065CF054  cbz      x8, #0x65cf0e8
0065CF058  ldr      x9, [sp, #0x18]
0065CF05C  cbz      x9, #0x65cf350
0065CF060  ldr      x28, [x22, #0x188]
0065CF064  cbz      x28, #0x65cf350
0065CF068  ldr      x8, [x28]
0065CF06C  adrp     x10, #0x8f09000
0065CF070  ldrsw    x21, [x9, #0x14]
0065CF074  ldrh     w9, [x8, #0x12e]
0065CF078  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CF07C  ldr      x1, [x10]
0065CF080  cbz      x9, #0x65cf0a4
0065CF084  ldr      x10, [x8, #0xb0]
0065CF088  add      x10, x10, #8
0065CF08C  ldur     x11, [x10, #-8]
0065CF090  cmp      x11, x1
0065CF094  b.eq     #0x65cf0b4
0065CF098  subs     x9, x9, #1
0065CF09C  add      x10, x10, #0x10
0065CF0A0  b.ne     #0x65cf08c
0065CF0A4  mov      w2, #0x10
0065CF0A8  mov      x0, x28
0065CF0AC  bl       #0x3a7e710 ; 
0065CF0B0  b        #0x65cf0c4 ; 
0065CF0B4  ldr      w9, [x10]
0065CF0B8  add      w9, w9, #0x10
0065CF0BC  add      x8, x8, w9, sxtw #4
0065CF0C0  add      x0, x8, #0x138
0065CF0C4  ldp      x8, x1, [x0]
0065CF0C8  mov      x0, x28
0065CF0CC  blr      x8
0065CF0D0  cbz      x0, #0x65cf350
0065CF0D4  ldr      w8, [x0, #0x18]
0065CF0D8  cmp      w21, w8
0065CF0DC  b.hs     #0x65cf354
0065CF0E0  add      x8, x0, x21, lsl #2
0065CF0E4  ldr      w28, [x8, #0x20]
0065CF0E8  adrp     x8, #0x9599000
0065CF0EC  ldrb     w8, [x8, #0x286]
0065CF0F0  cbnz     w8, #0x65cf10c
0065CF0F4  adrp     x0, #0x8f07000
0065CF0F8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CF0FC  bl       #0x382bd14 ; 
0065CF100  adrp     x8, #0x9599000
0065CF104  mov      w9, #1
0065CF108  strb     w9, [x8, #0x286]
0065CF10C  adrp     x8, #0x8f07000
0065CF110  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CF114  ldr      x1, [x8]
0065CF118  ldrb     w8, [x1, #0x53]
0065CF11C  tbnz     w8, #5, #0x65cf128
0065CF120  ldr      x29, [x22, #0x80]
0065CF124  b        #0x65cf138 ; 
0065CF128  ldr      x8, [x1, #0x60]
0065CF12C  mov      x0, x22
0065CF130  blr      x8
0065CF134  mov      x29, x0
0065CF138  cbz      x29, #0x65cf350
0065CF13C  adrp     x8, #0x9598000
0065CF140  ldrb     w8, [x8, #0xfcc]
0065CF144  cbnz     w8, #0x65cf160
0065CF148  adrp     x0, #0x8f06000
0065CF14C  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065CF150  bl       #0x382bd14 ; 
0065CF154  mov      w8, #1
0065CF158  adrp     x9, #0x9598000
0065CF15C  strb     w8, [x9, #0xfcc]
0065CF160  adrp     x8, #0x8f06000
0065CF164  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065CF168  ldr      x1, [x8]
0065CF16C  ldrb     w8, [x1, #0x53]
0065CF170  tbnz     w8, #5, #0x65cf17c
0065CF174  ldr      x0, [x29, #0x200]
0065CF178  b        #0x65cf188 ; 
0065CF17C  ldr      x8, [x1, #0x60]
0065CF180  mov      x0, x29
0065CF184  blr      x8
0065CF188  cbz      x0, #0x65cf350
0065CF18C  mov      w1, w28
0065CF190  mov      x2, xzr
0065CF194  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065CF198  mov      x29, x0
0065CF19C  cbz      x0, #0x65cf204
0065CF1A0  adrp     x8, #0x9599000
0065CF1A4  ldrb     w8, [x8, #0x29e]
0065CF1A8  cbnz     w8, #0x65cf1c4
0065CF1AC  adrp     x0, #0x8f08000
0065CF1B0  ldr      x0, [x0, #0x90] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_bornType()
0065CF1B4  bl       #0x382bd14 ; 
0065CF1B8  mov      w8, #1
0065CF1BC  adrp     x9, #0x9599000
0065CF1C0  strb     w8, [x9, #0x29e]
0065CF1C4  adrp     x8, #0x8f08000
0065CF1C8  ldr      x8, [x8, #0x90] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_bornType()
0065CF1CC  ldr      x1, [x8]
0065CF1D0  ldrb     w8, [x1, #0x53]
0065CF1D4  tbnz     w8, #5, #0x65cf1e0
0065CF1D8  ldr      w0, [x29, #0x120]
0065CF1DC  b        #0x65cf1ec ; 
0065CF1E0  ldr      x8, [x1, #0x60]
0065CF1E4  mov      x0, x29
0065CF1E8  blr      x8
0065CF1EC  cmp      w0, #1
0065CF1F0  b.ne     #0x65cf204
0065CF1F4  add      x8, x23, x26, lsl #7
0065CF1F8  stp      x24, x19, [x8, #0x30]
0065CF1FC  str      x25, [x8, #0x40]
0065CF200  b        #0x65cf23c ; 
0065CF204  ldr      x8, [sp, #0x10]
0065CF208  add      x0, sp, #0x60
0065CF20C  mov      x1, x24
0065CF210  mov      x2, x19
0065CF214  add      x3, x25, x8
0065CF218  mov      x4, xzr
0065CF21C  stp      xzr, xzr, [sp, #0x60]
0065CF220  str      xzr, [sp, #0x70]
0065CF224  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065CF228  ldr      x8, [sp, #0x70]
0065CF22C  ldr      q0, [sp, #0x60]
0065CF230  add      x9, x23, x26, lsl #7
0065CF234  str      x8, [x9, #0x40]
0065CF238  str      q0, [x9, #0x30]
0065CF23C  ldp      x8, x1, [sp, #0x48]
0065CF240  add      x21, x23, x26, lsl #7
0065CF244  str      x1, [x21, #0x70]!
0065CF248  mov      x0, x21
0065CF24C  str      wzr, [x21, #0x10]
0065CF250  stp      x24, x19, [x21, #-0x28]
0065CF254  stur     x25, [x21, #-0x18]
0065CF258  stur     w28, [x21, #-0x10]
0065CF25C  stur     x8, [x21, #-8]
0065CF260  bl       #0x382bcb8 ; 
0065CF264  ldp      x24, x19, [sp, #0x30]
0065CF268  str      xzr, [x21, #8]
0065CF26C  sub      x8, x25, x24
0065CF270  sub      x9, x25, x19
0065CF274  stp      x8, x9, [x21, #0x18]
0065CF278  ldr      x25, [x22, #0x188]
0065CF27C  cbz      x25, #0x65cf350
0065CF280  ldr      x8, [x25]
0065CF284  adrp     x10, #0x8f09000
0065CF288  ldrh     w9, [x8, #0x12e]
0065CF28C  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CF290  ldr      x1, [x10]
0065CF294  cbz      x9, #0x65cf2b8
0065CF298  ldr      x10, [x8, #0xb0]
0065CF29C  add      x10, x10, #8
0065CF2A0  ldur     x11, [x10, #-8]
0065CF2A4  cmp      x11, x1
0065CF2A8  b.eq     #0x65cf2c8
0065CF2AC  subs     x9, x9, #1
0065CF2B0  add      x10, x10, #0x10
0065CF2B4  b.ne     #0x65cf2a0
0065CF2B8  mov      x0, x25
0065CF2BC  mov      w2, wzr
0065CF2C0  bl       #0x3a7e710 ; 
0065CF2C4  b        #0x65cf2d4 ; 
0065CF2C8  ldrsw    x9, [x10]
0065CF2CC  add      x8, x8, x9, lsl #4
0065CF2D0  add      x0, x8, #0x138
0065CF2D4  ldp      x8, x1, [x0]
0065CF2D8  mov      x0, x25
0065CF2DC  blr      x8
0065CF2E0  add      x21, x23, x26, lsl #7
0065CF2E4  str      w0, [x21, #0x98]
0065CF2E8  mov      x0, x22
0065CF2EC  mov      x1, x29
0065CF2F0  bl       #0x65d0b58 ; HotFix.BattleLogic.WaterfallBattleManager$$AddGoldMonster
0065CF2F4  ldp      x9, x26, [sp, #0x20]
0065CF2F8  add      x20, x20, #1
0065CF2FC  and      w8, w0, #1
0065CF300  strb     w8, [x21, #0x9c]
0065CF304  cmp      x20, x9
0065CF308  b.ne     #0x65ceedc
0065CF30C  ldr      w8, [x22, #0xa8]
0065CF310  ldr      w9, [sp, #0xc]
0065CF314  ldr      x24, [sp]
0065CF318  add      w8, w8, w9
0065CF31C  str      w8, [x22, #0xa8]
0065CF320  ldr      x8, [x24, #0x28]
0065CF324  ldr      x9, [sp, #0x78]
0065CF328  cmp      x8, x9
0065CF32C  b.ne     #0x65cf358
0065CF330  ldp      x20, x19, [sp, #0xd0]
0065CF334  ldp      x22, x21, [sp, #0xc0]
0065CF338  ldp      x24, x23, [sp, #0xb0]
0065CF33C  ldp      x26, x25, [sp, #0xa0]
0065CF340  ldp      x28, x27, [sp, #0x90]
0065CF344  ldp      x29, x30, [sp, #0x80]
0065CF348  add      sp, sp, #0xe0
0065CF34C  ret      
0065CF350  bl       #0x382bfb8 ; 
0065CF354  bl       #0x382bfc0 ; 
0065CF358  bl       #0x89edb60 ; 

