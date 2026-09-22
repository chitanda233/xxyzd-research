; HotFix.BattleLogic.WaterfallBattleManager$$CalPositionGroupSpecialMonsterCount
; RVA 0x65D2244; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D2244  sub      sp, sp, #0x90
0065D2248  stp      x29, x30, [sp, #0x30]
0065D224C  stp      x28, x27, [sp, #0x40]
0065D2250  stp      x26, x25, [sp, #0x50]
0065D2254  stp      x24, x23, [sp, #0x60]
0065D2258  stp      x22, x21, [sp, #0x70]
0065D225C  stp      x20, x19, [sp, #0x80]
0065D2260  str      w2, [sp, #0x20]
0065D2264  adrp     x19, #0x9599000
0065D2268  adrp     x21, #0x8f0a000
0065D226C  ldrb     w8, [x19, #0x58a]
0065D2270  ldr      x21, [x21, #0xa28] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CalPositionGroupSpecialMonsterCount()
0065D2274  mov      x24, x1
0065D2278  mov      x20, x0
0065D227C  tbnz     w8, #0, #0x65d2360
0065D2280  adrp     x0, #0x8f0a000
0065D2284  ldr      x0, [x0, #0x9f8] ; GLOBAL HotFix.BattleLogic.CalMonsterCountData_TypeInfo
0065D2288  bl       #0x382bd14 ; 
0065D228C  adrp     x0, #0x8f0a000
0065D2290  ldr      x0, [x0, #0xa00] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.Add()
0065D2294  bl       #0x382bd14 ; 
0065D2298  adrp     x0, #0x8f0a000
0065D229C  ldr      x0, [x0, #0xa08] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.TryGetValue()
0065D22A0  bl       #0x382bd14 ; 
0065D22A4  adrp     x0, #0x8f09000
0065D22A8  ldr      x0, [x0, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D22AC  bl       #0x382bd14 ; 
0065D22B0  adrp     x0, #0x8f0a000
0065D22B4  ldr      x0, [x0, #0x930] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<List<MonsterGroupFlushConfig>>()
0065D22B8  bl       #0x382bd14 ; 
0065D22BC  adrp     x0, #0x8ee2000
0065D22C0  ldr      x0, [x0, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo
0065D22C4  bl       #0x382bd14 ; 
0065D22C8  adrp     x0, #0x8f0a000
0065D22CC  ldr      x0, [x0, #0xa30] ; GLOBAL Method$System.Collections.Generic.List<MissionPositionGroupMonsterRandomData>.Add()
0065D22D0  bl       #0x382bd14 ; 
0065D22D4  adrp     x0, #0x8f0a000
0065D22D8  ldr      x0, [x0, #0xa38] ; GLOBAL Method$System.Collections.Generic.List<MissionPositionGroupMonsterRandomData>..ctor()
0065D22DC  bl       #0x382bd14 ; 
0065D22E0  adrp     x0, #0x8f0a000
0065D22E4  ldr      x0, [x0, #0x938] ; GLOBAL Method$System.Collections.Generic.List<MonsterGroupFlushConfig>.get_Count()
0065D22E8  bl       #0x382bd14 ; 
0065D22EC  adrp     x0, #0x8f0a000
0065D22F0  ldr      x0, [x0, #0x940] ; GLOBAL Method$System.Collections.Generic.List<MonsterGroupFlushConfig>.get_Item()
0065D22F4  bl       #0x382bd14 ; 
0065D22F8  adrp     x0, #0x8f0a000
0065D22FC  ldr      x0, [x0, #0xa40] ; GLOBAL System.Collections.Generic.List<MissionPositionGroupMonsterRandomData>_TypeInfo
0065D2300  bl       #0x382bd14 ; 
0065D2304  adrp     x0, #0x8ee1000
0065D2308  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo
0065D230C  bl       #0x382bd14 ; 
0065D2310  adrp     x0, #0x8f0a000
0065D2314  ldr      x0, [x0, #0xa48] ; GLOBAL HotFix.BattleLogic.MissionPositionGroupMonsterRandomData_TypeInfo
0065D2318  bl       #0x382bd14 ; 
0065D231C  adrp     x0, #0x8f0a000
0065D2320  ldr      x0, [x0, #0xa28] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CalPositionGroupSpecialMonsterCount()
0065D2324  bl       #0x382bd14 ; 
0065D2328  adrp     x0, #0x8f0a000
0065D232C  ldr      x0, [x0, #0xa10] ; GLOBAL HotFix.BattleLogic.WaveMissionRandomData_TypeInfo
0065D2330  bl       #0x382bd14 ; 
0065D2334  adrp     x0, #0x8f0a000
0065D2338  ldr      x0, [x0, #0x950] ; GLOBAL 刷怪配置不存在 flushConfigId = 
0065D233C  bl       #0x382bd14 ; 
0065D2340  adrp     x0, #0x8f0a000
0065D2344  ldr      x0, [x0, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065D2348  bl       #0x382bd14 ; 
0065D234C  adrp     x0, #0x8f0a000
0065D2350  ldr      x0, [x0, #0xa50] ; GLOBAL CalPositionGroupSpecialMonsterCount
0065D2354  bl       #0x382bd14 ; 
0065D2358  mov      w8, #1
0065D235C  strb     w8, [x19, #0x58a]
0065D2360  ldr      x3, [x21]
0065D2364  ldrb     w8, [x3, #0x53]
0065D2368  tbnz     w8, #5, #0x65d23c8
0065D236C  adrp     x8, #0x8f0a000
0065D2370  ldr      x8, [x8, #0x9f8] ; GLOBAL HotFix.BattleLogic.CalMonsterCountData_TypeInfo
0065D2374  str      xzr, [sp, #0x28]
0065D2378  str      wzr, [sp, #0x24]
0065D237C  ldr      x0, [x8]
0065D2380  bl       #0x382bfa0 ; 
0065D2384  mov      x21, x0
0065D2388  bl       #0x65c7420 ; HotFix.BattleLogic.CalMonsterCountData$$.ctor
0065D238C  adrp     x19, #0x9599000
0065D2390  ldrb     w8, [x19, #0x286]
0065D2394  cbnz     w8, #0x65d23ac
0065D2398  adrp     x0, #0x8f07000
0065D239C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D23A0  bl       #0x382bd14 ; 
0065D23A4  mov      w8, #1
0065D23A8  strb     w8, [x19, #0x286]
0065D23AC  adrp     x8, #0x8f07000
0065D23B0  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D23B4  ldr      x1, [x8]
0065D23B8  ldrb     w8, [x1, #0x53]
0065D23BC  tbnz     w8, #5, #0x65d23f8
0065D23C0  ldr      x22, [x20, #0x80]
0065D23C4  b        #0x65d2408 ; 
0065D23C8  ldr      x4, [x3, #0x60]
0065D23CC  mov      x0, x20
0065D23D0  mov      x1, x24
0065D23D4  ldr      w2, [sp, #0x20]
0065D23D8  ldp      x20, x19, [sp, #0x80]
0065D23DC  ldp      x22, x21, [sp, #0x70]
0065D23E0  ldp      x24, x23, [sp, #0x60]
0065D23E4  ldp      x26, x25, [sp, #0x50]
0065D23E8  ldp      x28, x27, [sp, #0x40]
0065D23EC  ldp      x29, x30, [sp, #0x30]
0065D23F0  add      sp, sp, #0x90
0065D23F4  br       x4
0065D23F8  ldr      x8, [x1, #0x60]
0065D23FC  mov      x0, x20
0065D2400  blr      x8
0065D2404  mov      x22, x0
0065D2408  cbz      x22, #0x65d2d94
0065D240C  adrp     x19, #0x9591000
0065D2410  ldrb     w8, [x19, #0xa9c]
0065D2414  cbnz     w8, #0x65d242c
0065D2418  adrp     x0, #0x8ee6000
0065D241C  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065D2420  bl       #0x382bd14 ; 
0065D2424  mov      w8, #1
0065D2428  strb     w8, [x19, #0xa9c]
0065D242C  adrp     x8, #0x8ee6000
0065D2430  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065D2434  ldr      x1, [x8]
0065D2438  ldrb     w8, [x1, #0x53]
0065D243C  tbnz     w8, #5, #0x65d244c
0065D2440  ldr      x8, [x22, #0x240]
0065D2444  str      x8, [sp, #0x10]
0065D2448  b        #0x65d245c ; 
0065D244C  ldr      x8, [x1, #0x60]
0065D2450  mov      x0, x22
0065D2454  blr      x8
0065D2458  str      x0, [sp, #0x10]
0065D245C  mov      x0, x20
0065D2460  bl       #0x65d3784 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
0065D2464  cbz      x24, #0x65d2d94
0065D2468  adrp     x19, #0x8f09000
0065D246C  ldr      x8, [x24]
0065D2470  ldr      x19, [x19, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D2474  mov      w23, w0
0065D2478  ldrh     w9, [x8, #0x12e]
0065D247C  ldr      x1, [x19]
0065D2480  cbz      x9, #0x65d24a4
0065D2484  ldr      x10, [x8, #0xb0]
0065D2488  add      x10, x10, #8
0065D248C  ldur     x11, [x10, #-8]
0065D2490  cmp      x11, x1
0065D2494  b.eq     #0x65d24b4
0065D2498  subs     x9, x9, #1
0065D249C  add      x10, x10, #0x10
0065D24A0  b.ne     #0x65d248c
0065D24A4  mov      x0, x24
0065D24A8  mov      w2, wzr
0065D24AC  bl       #0x3a7e710 ; 
0065D24B0  b        #0x65d24c0 ; 
0065D24B4  ldrsw    x9, [x10]
0065D24B8  add      x8, x8, x9, lsl #4
0065D24BC  add      x0, x8, #0x138
0065D24C0  ldp      x8, x1, [x0]
0065D24C4  mov      x0, x24
0065D24C8  blr      x8
0065D24CC  ldr      x8, [x20, #0x1f0]
0065D24D0  cbz      x8, #0x65d2d94
0065D24D4  adrp     x9, #0x8f0a000
0065D24D8  ldr      x9, [x9, #0xa08] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.TryGetValue()
0065D24DC  mov      w22, w0
0065D24E0  add      x2, sp, #0x28
0065D24E4  mov      x0, x8
0065D24E8  ldr      x3, [x9]
0065D24EC  mov      w1, w22
0065D24F0  bl       #0x5e614ec ; System.Collections.Generic.Dictionary<int, object>$$TryGetValue
0065D24F4  tbnz     w0, #0, #0x65d2534
0065D24F8  adrp     x8, #0x8f0a000
0065D24FC  ldr      x8, [x8, #0xa10] ; GLOBAL HotFix.BattleLogic.WaveMissionRandomData_TypeInfo
0065D2500  ldr      x0, [x8]
0065D2504  bl       #0x382bfa0 ; 
0065D2508  mov      x25, x0
0065D250C  bl       #0x65c74f0 ; HotFix.BattleLogic.WaveMissionRandomData$$.ctor
0065D2510  str      x25, [sp, #0x28]
0065D2514  ldr      x0, [x20, #0x1f0]
0065D2518  cbz      x0, #0x65d2d94
0065D251C  adrp     x8, #0x8f0a000
0065D2520  ldr      x8, [x8, #0xa00] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.Add()
0065D2524  mov      w1, w22
0065D2528  mov      x2, x25
0065D252C  ldr      x3, [x8]
0065D2530  bl       #0x5e5fa3c ; System.Collections.Generic.Dictionary<int, object>$$Add
0065D2534  ldr      x8, [x24]
0065D2538  ldr      x1, [x19]
0065D253C  ldrh     w9, [x8, #0x12e]
0065D2540  cbz      x9, #0x65d2564
0065D2544  ldr      x10, [x8, #0xb0]
0065D2548  add      x10, x10, #8
0065D254C  ldur     x11, [x10, #-8]
0065D2550  cmp      x11, x1
0065D2554  b.eq     #0x65d2574
0065D2558  subs     x9, x9, #1
0065D255C  add      x10, x10, #0x10
0065D2560  b.ne     #0x65d254c
0065D2564  mov      w2, #0x14
0065D2568  mov      x0, x24
0065D256C  bl       #0x3a7e710 ; 
0065D2570  b        #0x65d2584 ; 
0065D2574  ldr      w9, [x10]
0065D2578  add      w9, w9, #0x14
0065D257C  add      x8, x8, w9, sxtw #4
0065D2580  add      x0, x8, #0x138
0065D2584  ldp      x8, x1, [x0]
0065D2588  mov      x0, x24
0065D258C  blr      x8
0065D2590  cbz      x0, #0x65d2d94
0065D2594  ldr      w24, [x0, #0x18]
0065D2598  mov      x22, x0
0065D259C  cmp      w24, #1
0065D25A0  b.lt     #0x65d2d70
0065D25A4  adrp     x8, #0x9599000
0065D25A8  ldrb     w8, [x8, #0x286]
0065D25AC  cbnz     w8, #0x65d25c8
0065D25B0  adrp     x0, #0x8f07000
0065D25B4  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D25B8  bl       #0x382bd14 ; 
0065D25BC  mov      w8, #1
0065D25C0  adrp     x9, #0x9599000
0065D25C4  strb     w8, [x9, #0x286]
0065D25C8  adrp     x8, #0x8f07000
0065D25CC  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D25D0  ldr      x1, [x8]
0065D25D4  ldrb     w8, [x1, #0x53]
0065D25D8  tbnz     w8, #5, #0x65d25e4
0065D25DC  ldr      x0, [x20, #0x80]
0065D25E0  b        #0x65d25f0 ; 
0065D25E4  ldr      x8, [x1, #0x60]
0065D25E8  mov      x0, x20
0065D25EC  blr      x8
0065D25F0  cbz      x0, #0x65d2d94
0065D25F4  mov      w1, wzr
0065D25F8  mov      w2, w24
0065D25FC  mov      x3, xzr
0065D2600  bl       #0x54b65d8 ; 
0065D2604  ldr      x8, [sp, #0x28]
0065D2608  cbz      x8, #0x65d2d94
0065D260C  str      w0, [x8, #0x18]
0065D2610  adrp     x8, #0x9599000
0065D2614  ldrb     w8, [x8, #0x286]
0065D2618  mov      w25, w0
0065D261C  cbnz     w8, #0x65d2638
0065D2620  adrp     x0, #0x8f07000
0065D2624  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D2628  bl       #0x382bd14 ; 
0065D262C  mov      w8, #1
0065D2630  adrp     x9, #0x9599000
0065D2634  strb     w8, [x9, #0x286]
0065D2638  adrp     x8, #0x8f07000
0065D263C  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D2640  ldr      x1, [x8]
0065D2644  ldrb     w8, [x1, #0x53]
0065D2648  tbnz     w8, #5, #0x65d2654
0065D264C  ldr      x26, [x20, #0x80]
0065D2650  b        #0x65d2664 ; 
0065D2654  ldr      x8, [x1, #0x60]
0065D2658  mov      x0, x20
0065D265C  blr      x8
0065D2660  mov      x26, x0
0065D2664  cbz      x26, #0x65d2d94
0065D2668  adrp     x8, #0x9598000
0065D266C  ldrb     w8, [x8, #0xfcc]
0065D2670  cbnz     w8, #0x65d268c
0065D2674  adrp     x0, #0x8f06000
0065D2678  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D267C  bl       #0x382bd14 ; 
0065D2680  mov      w8, #1
0065D2684  adrp     x9, #0x9598000
0065D2688  strb     w8, [x9, #0xfcc]
0065D268C  adrp     x8, #0x8f06000
0065D2690  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D2694  ldr      x1, [x8]
0065D2698  ldrb     w8, [x1, #0x53]
0065D269C  tbnz     w8, #5, #0x65d26a8
0065D26A0  ldr      x0, [x26, #0x200]
0065D26A4  b        #0x65d26b4 ; 
0065D26A8  ldr      x8, [x1, #0x60]
0065D26AC  mov      x0, x26
0065D26B0  blr      x8
0065D26B4  ldr      w8, [x22, #0x18]
0065D26B8  cmp      w25, w8
0065D26BC  b.hs     #0x65d2d98
0065D26C0  cbz      x0, #0x65d2d94
0065D26C4  add      x8, x22, w25, sxtw #2
0065D26C8  ldr      w1, [x8, #0x20]
0065D26CC  mov      x2, xzr
0065D26D0  bl       #0x64d8fd4 ; LocalModels.LocalModelManager$$GetMission_PositionGroupMonsterFlushConfig
0065D26D4  cbz      x0, #0x65d2d94
0065D26D8  adrp     x19, #0x9599000
0065D26DC  ldrb     w8, [x19, #0x65c]
0065D26E0  mov      x22, x0
0065D26E4  cbnz     w8, #0x65d26fc
0065D26E8  adrp     x0, #0x8f0a000
0065D26EC  ldr      x0, [x0, #0x968] ; GLOBAL Method$LocalModels.Bean.Mission_PositionGroupMonsterFlushConfig.get_flushPool()
0065D26F0  bl       #0x382bd14 ; 
0065D26F4  mov      w8, #1
0065D26F8  strb     w8, [x19, #0x65c]
0065D26FC  adrp     x8, #0x8f0a000
0065D2700  ldr      x8, [x8, #0x968] ; GLOBAL Method$LocalModels.Bean.Mission_PositionGroupMonsterFlushConfig.get_flushPool()
0065D2704  ldr      x1, [x8]
0065D2708  ldrb     w8, [x1, #0x53]
0065D270C  tbnz     w8, #5, #0x65d2718
0065D2710  ldr      x22, [x22, #0x28]
0065D2714  b        #0x65d2728 ; 
0065D2718  ldr      x8, [x1, #0x60]
0065D271C  mov      x0, x22
0065D2720  blr      x8
0065D2724  mov      x22, x0
0065D2728  adrp     x8, #0x8ee2000
0065D272C  ldr      x8, [x8, #0xa58] ; GLOBAL LitJson.JsonMapperLockStep_TypeInfo
0065D2730  ldr      x0, [x8]
0065D2734  ldr      w8, [x0, #0xe0]
0065D2738  cbnz     w8, #0x65d2740
0065D273C  bl       #0x382be8c ; 
0065D2740  adrp     x8, #0x8f0a000
0065D2744  ldr      x8, [x8, #0x930] ; GLOBAL Method$LitJson.JsonMapperLockStep.ToObjectFp<List<MonsterGroupFlushConfig>>()
0065D2748  mov      x0, x22
0065D274C  ldr      x1, [x8]
0065D2750  bl       #0x4652a8c ; LitJson.JsonMapperLockStep$$ToObjectFp<object>
0065D2754  ldr      x8, [sp, #0x28]
0065D2758  cbz      x8, #0x65d2d94
0065D275C  ldr      x19, [x8, #0x20]
0065D2760  mov      x22, x0
0065D2764  cbnz     x19, #0x65d27a0
0065D2768  adrp     x8, #0x8f0a000
0065D276C  ldr      x8, [x8, #0xa40] ; GLOBAL System.Collections.Generic.List<MissionPositionGroupMonsterRandomData>_TypeInfo
0065D2770  ldr      x0, [x8]
0065D2774  bl       #0x382bfa0 ; 
0065D2778  adrp     x8, #0x8f0a000
0065D277C  ldr      x8, [x8, #0xa38] ; GLOBAL Method$System.Collections.Generic.List<MissionPositionGroupMonsterRandomData>..ctor()
0065D2780  mov      x19, x0
0065D2784  ldr      x1, [x8]
0065D2788  bl       #0x4daf5fc ; System.Collections.Generic.List<object>$$.ctor
0065D278C  ldr      x0, [sp, #0x28]
0065D2790  cbz      x0, #0x65d2d94
0065D2794  str      x19, [x0, #0x20]!
0065D2798  mov      x1, x19
0065D279C  bl       #0x382bcb8 ; 
0065D27A0  str      x19, [sp, #8]
0065D27A4  cbz      x22, #0x65d2d94
0065D27A8  ldr      w8, [x22, #0x18]
0065D27AC  cmp      w8, #1
0065D27B0  b.lt     #0x65d2d70
0065D27B4  adrp     x26, #0x8f0a000
0065D27B8  adrp     x29, #0x8ee6000
0065D27BC  adrp     x28, #0x8f0a000
0065D27C0  ldr      x26, [x26, #0x940] ; GLOBAL Method$System.Collections.Generic.List<MonsterGroupFlushConfig>.get_Item()
0065D27C4  ldr      x29, [x29, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0065D27C8  ldr      x28, [x28, #0xa20] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_expWeight()
0065D27CC  mov      w25, wzr
0065D27D0  mov      w19, #1
0065D27D4  adrp     x24, #0x9591000
0065D27D8  adrp     x27, #0x9599000
0065D27DC  and      w8, w23, #1
0065D27E0  str      w8, [sp, #0x1c]
0065D27E4  str      x22, [sp]
0065D27E8  ldr      x2, [x26]
0065D27EC  mov      x0, x22
0065D27F0  mov      w1, w25
0065D27F4  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065D27F8  cbz      x0, #0x65d2d94
0065D27FC  ldr      w8, [x0, #0x10]
0065D2800  ldr      x2, [x26]
0065D2804  mov      x0, x22
0065D2808  mov      w1, w25
0065D280C  str      w8, [sp, #0x24]
0065D2810  bl       #0x4dafb60 ; System.Collections.Generic.List<object>$$get_Item
0065D2814  adrp     x23, #0x9599000
0065D2818  cbz      x0, #0x65d2d94
0065D281C  ldrb     w8, [x23, #0x286]
0065D2820  ldr      x26, [x0, #0x18]
0065D2824  cbnz     w8, #0x65d2838
0065D2828  adrp     x0, #0x8f07000
0065D282C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D2830  bl       #0x382bd14 ; 
0065D2834  strb     w19, [x23, #0x286]
0065D2838  adrp     x8, #0x8f07000
0065D283C  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D2840  ldr      x1, [x8]
0065D2844  ldrb     w8, [x1, #0x53]
0065D2848  tbnz     w8, #5, #0x65d2854
0065D284C  ldr      x0, [x20, #0x80]
0065D2850  b        #0x65d2860 ; 
0065D2854  ldr      x8, [x1, #0x60]
0065D2858  mov      x0, x20
0065D285C  blr      x8
0065D2860  cbz      x26, #0x65d2d94
0065D2864  str      w25, [sp, #0x18]
0065D2868  cbz      x0, #0x65d2d94
0065D286C  ldr      w2, [x26, #0x18]
0065D2870  mov      w1, wzr
0065D2874  mov      x3, xzr
0065D2878  bl       #0x54b65d8 ; 
0065D287C  adrp     x8, #0x8f0a000
0065D2880  ldr      x8, [x8, #0xa48] ; GLOBAL HotFix.BattleLogic.MissionPositionGroupMonsterRandomData_TypeInfo
0065D2884  mov      w25, w0
0065D2888  ldr      x8, [x8]
0065D288C  mov      x0, x8
0065D2890  bl       #0x382bfa0 ; 
0065D2894  mov      x22, x0
0065D2898  bl       #0x65c7488 ; HotFix.BattleLogic.MissionPositionGroupMonsterRandomData$$.ctor
0065D289C  ldr      x12, [sp, #8]
0065D28A0  cbz      x12, #0x65d2d94
0065D28A4  adrp     x9, #0x8f0a000
0065D28A8  ldr      w10, [x12, #0x1c]
0065D28AC  ldr      x8, [x12, #0x10]
0065D28B0  ldr      x9, [x9, #0xa30] ; GLOBAL Method$System.Collections.Generic.List<MissionPositionGroupMonsterRandomData>.Add()
0065D28B4  add      w10, w10, #1
0065D28B8  ldr      x9, [x9]
0065D28BC  str      w10, [x12, #0x1c]
0065D28C0  cbz      x8, #0x65d2d94
0065D28C4  ldrsw    x10, [x12, #0x18]
0065D28C8  ldr      w11, [x8, #0x18]
0065D28CC  cmp      w10, w11
0065D28D0  b.hs     #0x65d28f0
0065D28D4  add      w9, w10, #1
0065D28D8  add      x0, x8, x10, lsl #3
0065D28DC  str      w9, [x12, #0x18]
0065D28E0  str      x22, [x0, #0x20]!
0065D28E4  mov      x1, x22
0065D28E8  bl       #0x382bcb8 ; 
0065D28EC  b        #0x65d2908 ; 
0065D28F0  ldr      x8, [x9, #0x20]
0065D28F4  mov      x0, x12
0065D28F8  mov      x1, x22
0065D28FC  ldr      x8, [x8, #0xc0]
0065D2900  ldr      x2, [x8, #0x70]
0065D2904  bl       #0x4dafe30 ; System.Collections.Generic.List<object>$$AddWithResize
0065D2908  cbz      x22, #0x65d2d94
0065D290C  str      w25, [x22, #0x14]
0065D2910  ldr      w8, [x26, #0x18]
0065D2914  cmp      w25, w8
0065D2918  b.hs     #0x65d2d98
0065D291C  add      x8, x26, w25, sxtw #2
0065D2920  ldrb     w9, [x23, #0x286]
0065D2924  ldr      w25, [x8, #0x20]
0065D2928  cbnz     w9, #0x65d293c
0065D292C  adrp     x0, #0x8f07000
0065D2930  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D2934  bl       #0x382bd14 ; 
0065D2938  strb     w19, [x23, #0x286]
0065D293C  adrp     x8, #0x8f07000
0065D2940  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D2944  ldr      x1, [x8]
0065D2948  ldrb     w8, [x1, #0x53]
0065D294C  tbnz     w8, #5, #0x65d2958
0065D2950  ldr      x26, [x20, #0x80]
0065D2954  b        #0x65d2968 ; 
0065D2958  ldr      x8, [x1, #0x60]
0065D295C  mov      x0, x20
0065D2960  blr      x8
0065D2964  mov      x26, x0
0065D2968  cbz      x26, #0x65d2d94
0065D296C  adrp     x8, #0x9598000
0065D2970  ldrb     w8, [x8, #0xfcc]
0065D2974  cbnz     w8, #0x65d298c
0065D2978  adrp     x0, #0x8f06000
0065D297C  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D2980  bl       #0x382bd14 ; 
0065D2984  adrp     x8, #0x9598000
0065D2988  strb     w19, [x8, #0xfcc]
0065D298C  adrp     x8, #0x8f06000
0065D2990  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D2994  ldr      x1, [x8]
0065D2998  ldrb     w8, [x1, #0x53]
0065D299C  tbnz     w8, #5, #0x65d29a8
0065D29A0  ldr      x0, [x26, #0x200]
0065D29A4  b        #0x65d29b4 ; 
0065D29A8  ldr      x8, [x1, #0x60]
0065D29AC  mov      x0, x26
0065D29B0  blr      x8
0065D29B4  cbz      x0, #0x65d2d94
0065D29B8  ldr      w1, [sp, #0x24]
0065D29BC  mov      x2, xzr
0065D29C0  bl       #0x64d3fa0 ; LocalModels.LocalModelManager$$GetMission_PositionMonsterFlushConfig
0065D29C4  cbz      x0, #0x65d2d00
0065D29C8  adrp     x8, #0x9599000
0065D29CC  ldrb     w8, [x8, #0x657]
0065D29D0  mov      x26, x0
0065D29D4  cbnz     w8, #0x65d29ec
0065D29D8  adrp     x0, #0x8f0a000
0065D29DC  ldr      x0, [x0, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool()
0065D29E0  bl       #0x382bd14 ; 
0065D29E4  adrp     x8, #0x9599000
0065D29E8  strb     w19, [x8, #0x657]
0065D29EC  adrp     x8, #0x8f0a000
0065D29F0  ldr      x8, [x8, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool()
0065D29F4  ldr      x1, [x8]
0065D29F8  ldrb     w8, [x1, #0x53]
0065D29FC  tbnz     w8, #5, #0x65d2a08
0065D2A00  ldr      x0, [x26, #0x28]
0065D2A04  b        #0x65d2a14 ; 
0065D2A08  ldr      x8, [x1, #0x60]
0065D2A0C  mov      x0, x26
0065D2A10  blr      x8
0065D2A14  cbz      x0, #0x65d2d94
0065D2A18  ldr      w8, [x0, #0x18]
0065D2A1C  cmp      w8, #1
0065D2A20  b.lt     #0x65d2cdc
0065D2A24  adrp     x8, #0x9599000
0065D2A28  ldrb     w8, [x8, #0x657]
0065D2A2C  cbnz     w8, #0x65d2a44
0065D2A30  adrp     x0, #0x8f0a000
0065D2A34  ldr      x0, [x0, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool()
0065D2A38  bl       #0x382bd14 ; 
0065D2A3C  adrp     x8, #0x9599000
0065D2A40  strb     w19, [x8, #0x657]
0065D2A44  adrp     x8, #0x8f0a000
0065D2A48  ldr      x8, [x8, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool()
0065D2A4C  ldr      x1, [x8]
0065D2A50  ldrb     w8, [x1, #0x53]
0065D2A54  tbnz     w8, #5, #0x65d2a60
0065D2A58  ldr      x1, [x26, #0x28]
0065D2A5C  b        #0x65d2a70 ; 
0065D2A60  ldr      x8, [x1, #0x60]
0065D2A64  mov      x0, x26
0065D2A68  blr      x8
0065D2A6C  mov      x1, x0
0065D2A70  ldr      x0, [sp, #0x10]
0065D2A74  cbz      x0, #0x65d2d94
0065D2A78  mov      x2, xzr
0065D2A7C  bl       #0x6903320 ; HotFix.BattleLogic.MapManager$$WaterfallRandomMap
0065D2A80  str      w0, [x22, #0x10]
0065D2A84  adrp     x8, #0x9599000
0065D2A88  ldrb     w8, [x8, #0x26f]
0065D2A8C  mov      w26, w0
0065D2A90  cbnz     w8, #0x65d2aa8
0065D2A94  adrp     x0, #0x8f06000
0065D2A98  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData()
0065D2A9C  bl       #0x382bd14 ; 
0065D2AA0  adrp     x8, #0x9599000
0065D2AA4  strb     w19, [x8, #0x26f]
0065D2AA8  adrp     x8, #0x8f06000
0065D2AAC  ldr      x8, [x8, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData()
0065D2AB0  ldr      x1, [x8]
0065D2AB4  ldrb     w8, [x1, #0x53]
0065D2AB8  tbnz     w8, #5, #0x65d2ac8
0065D2ABC  ldr      x8, [sp, #0x10]
0065D2AC0  ldr      x0, [x8, #0x20]
0065D2AC4  b        #0x65d2ad4 ; 
0065D2AC8  ldr      x8, [x1, #0x60]
0065D2ACC  ldr      x0, [sp, #0x10]
0065D2AD0  blr      x8
0065D2AD4  cbz      x0, #0x65d2d94
0065D2AD8  ldr      x8, [x0, #0x140]
0065D2ADC  cbz      x8, #0x65d2d94
0065D2AE0  ldr      w9, [x8, #0x18]
0065D2AE4  cmp      w26, w9
0065D2AE8  b.hs     #0x65d2d98
0065D2AEC  add      x8, x8, w26, sxtw #4
0065D2AF0  ldr      x8, [x8, #0x28]
0065D2AF4  cbz      x8, #0x65d2d94
0065D2AF8  ldr      w26, [x8, #0x18]
0065D2AFC  cmp      w26, #1
0065D2B00  b.lt     #0x65d2cdc
0065D2B04  ldrb     w8, [x23, #0x286]
0065D2B08  cbnz     w8, #0x65d2b1c
0065D2B0C  adrp     x0, #0x8f07000
0065D2B10  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D2B14  bl       #0x382bd14 ; 
0065D2B18  strb     w19, [x23, #0x286]
0065D2B1C  adrp     x8, #0x8f07000
0065D2B20  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D2B24  ldr      x1, [x8]
0065D2B28  ldrb     w8, [x1, #0x53]
0065D2B2C  tbnz     w8, #5, #0x65d2b38
0065D2B30  ldr      x22, [x20, #0x80]
0065D2B34  b        #0x65d2b48 ; 
0065D2B38  ldr      x8, [x1, #0x60]
0065D2B3C  mov      x0, x20
0065D2B40  blr      x8
0065D2B44  mov      x22, x0
0065D2B48  cbz      x22, #0x65d2d94
0065D2B4C  adrp     x8, #0x9598000
0065D2B50  ldrb     w8, [x8, #0xfcc]
0065D2B54  cbnz     w8, #0x65d2b6c
0065D2B58  adrp     x0, #0x8f06000
0065D2B5C  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D2B60  bl       #0x382bd14 ; 
0065D2B64  adrp     x8, #0x9598000
0065D2B68  strb     w19, [x8, #0xfcc]
0065D2B6C  adrp     x8, #0x8f06000
0065D2B70  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D2B74  ldr      x1, [x8]
0065D2B78  ldrb     w8, [x1, #0x53]
0065D2B7C  tbnz     w8, #5, #0x65d2b88
0065D2B80  ldr      x0, [x22, #0x200]
0065D2B84  b        #0x65d2b94 ; 
0065D2B88  ldr      x8, [x1, #0x60]
0065D2B8C  mov      x0, x22
0065D2B90  blr      x8
0065D2B94  cbz      x0, #0x65d2d94
0065D2B98  mov      w1, w25
0065D2B9C  mov      x2, xzr
0065D2BA0  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065D2BA4  cbz      x0, #0x65d2d94
0065D2BA8  ldrb     w8, [x24, #0xa75]
0065D2BAC  mov      x22, x0
0065D2BB0  cbnz     w8, #0x65d2bc0
0065D2BB4  mov      x0, x29
0065D2BB8  bl       #0x382bd14 ; 
0065D2BBC  strb     w19, [x24, #0xa75]
0065D2BC0  ldr      x1, [x29]
0065D2BC4  ldrb     w8, [x1, #0x53]
0065D2BC8  tbnz     w8, #5, #0x65d2bd4
0065D2BCC  ldr      w0, [x22, #0x24]
0065D2BD0  b        #0x65d2be0 ; 
0065D2BD4  ldr      x8, [x1, #0x60]
0065D2BD8  mov      x0, x22
0065D2BDC  blr      x8
0065D2BE0  cmp      w0, #0xc9
0065D2BE4  b.eq     #0x65d2c24
0065D2BE8  ldrb     w8, [x24, #0xa75]
0065D2BEC  cbnz     w8, #0x65d2bfc
0065D2BF0  mov      x0, x29
0065D2BF4  bl       #0x382bd14 ; 
0065D2BF8  strb     w19, [x24, #0xa75]
0065D2BFC  ldr      x1, [x29]
0065D2C00  ldrb     w8, [x1, #0x53]
0065D2C04  tbnz     w8, #5, #0x65d2c10
0065D2C08  ldr      w0, [x22, #0x24]
0065D2C0C  b        #0x65d2c1c ; 
0065D2C10  ldr      x8, [x1, #0x60]
0065D2C14  mov      x0, x22
0065D2C18  blr      x8
0065D2C1C  cmp      w0, #3
0065D2C20  b.ne     #0x65d2c34
0065D2C24  cbz      x21, #0x65d2d94
0065D2C28  ldr      w8, [x21, #0x14]
0065D2C2C  add      w8, w8, #1
0065D2C30  str      w8, [x21, #0x14]
0065D2C34  ldrb     w8, [x27, #0x65d]
0065D2C38  cbnz     w8, #0x65d2c48
0065D2C3C  mov      x0, x28
0065D2C40  bl       #0x382bd14 ; 
0065D2C44  strb     w19, [x27, #0x65d]
0065D2C48  ldr      x1, [x28]
0065D2C4C  ldrb     w8, [x1, #0x53]
0065D2C50  tbnz     w8, #5, #0x65d2c5c
0065D2C54  ldr      w0, [x22, #0x24c]
0065D2C58  b        #0x65d2c68 ; 
0065D2C5C  ldr      x8, [x1, #0x60]
0065D2C60  mov      x0, x22
0065D2C64  blr      x8
0065D2C68  cmp      w0, #1
0065D2C6C  b.lt     #0x65d2cc4
0065D2C70  cbz      x21, #0x65d2d94
0065D2C74  ldr      w8, [x21, #0x10]
0065D2C78  ldr      w23, [x21, #0x18]
0065D2C7C  add      w8, w8, #1
0065D2C80  str      w8, [x21, #0x10]
0065D2C84  ldrb     w8, [x27, #0x65d]
0065D2C88  cbnz     w8, #0x65d2c98
0065D2C8C  mov      x0, x28
0065D2C90  bl       #0x382bd14 ; 
0065D2C94  strb     w19, [x27, #0x65d]
0065D2C98  ldr      x1, [x28]
0065D2C9C  ldrb     w8, [x1, #0x53]
0065D2CA0  tbnz     w8, #5, #0x65d2cac
0065D2CA4  ldr      w0, [x22, #0x24c]
0065D2CA8  b        #0x65d2cb8 ; 
0065D2CAC  ldr      x8, [x1, #0x60]
0065D2CB0  mov      x0, x22
0065D2CB4  blr      x8
0065D2CB8  add      w8, w0, w23
0065D2CBC  adrp     x23, #0x9599000
0065D2CC0  str      w8, [x21, #0x18]
0065D2CC4  ldp      w2, w3, [sp, #0x1c]
0065D2CC8  mov      x0, x20
0065D2CCC  mov      x1, x22
0065D2CD0  bl       #0x65d3844 ; HotFix.BattleLogic.WaterfallBattleManager$$AddDropType2Count
0065D2CD4  subs     w26, w26, #1
0065D2CD8  b.ne     #0x65d2b04
0065D2CDC  ldr      x22, [sp]
0065D2CE0  ldr      w25, [sp, #0x18]
0065D2CE4  adrp     x26, #0x8f0a000
0065D2CE8  ldr      w8, [x22, #0x18]
0065D2CEC  ldr      x26, [x26, #0x940] ; GLOBAL Method$System.Collections.Generic.List<MonsterGroupFlushConfig>.get_Item()
0065D2CF0  add      w25, w25, #1
0065D2CF4  cmp      w25, w8
0065D2CF8  b.lt     #0x65d27e8
0065D2CFC  b        #0x65d2d70 ; 
0065D2D00  add      x0, sp, #0x24
0065D2D04  mov      x1, xzr
0065D2D08  bl       #0x7bd22a0 ; System.Int32$$ToString
0065D2D0C  adrp     x8, #0x8f0a000
0065D2D10  ldr      x8, [x8, #0x950] ; GLOBAL 刷怪配置不存在 flushConfigId = 
0065D2D14  mov      x1, x0
0065D2D18  mov      x2, xzr
0065D2D1C  ldr      x8, [x8]
0065D2D20  mov      x0, x8
0065D2D24  bl       #0x79d469c ; System.String$$Concat
0065D2D28  adrp     x8, #0x8ee1000
0065D2D2C  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
0065D2D30  mov      x19, x0
0065D2D34  ldr      x8, [x8]
0065D2D38  ldr      w9, [x8, #0xe0]
0065D2D3C  cbnz     w9, #0x65d2d48
0065D2D40  mov      x0, x8
0065D2D44  bl       #0x382be8c ; 
0065D2D48  adrp     x8, #0x8f0a000
0065D2D4C  adrp     x9, #0x8f0a000
0065D2D50  ldr      x8, [x8, #0xa50] ; GLOBAL CalPositionGroupSpecialMonsterCount
0065D2D54  ldr      x9, [x9, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065D2D58  mov      w3, #0x42c
0065D2D5C  mov      x0, x19
0065D2D60  ldr      x1, [x8]
0065D2D64  ldr      x2, [x9]
0065D2D68  mov      x4, xzr
0065D2D6C  bl       #0x7997754 ; Logger$$LogError
0065D2D70  mov      x0, x21
0065D2D74  ldp      x20, x19, [sp, #0x80]
0065D2D78  ldp      x22, x21, [sp, #0x70]
0065D2D7C  ldp      x24, x23, [sp, #0x60]
0065D2D80  ldp      x26, x25, [sp, #0x50]
0065D2D84  ldp      x28, x27, [sp, #0x40]
0065D2D88  ldp      x29, x30, [sp, #0x30]
0065D2D8C  add      sp, sp, #0x90
0065D2D90  ret      
0065D2D94  bl       #0x382bfb8 ; 
0065D2D98  bl       #0x382bfc0 ; 

