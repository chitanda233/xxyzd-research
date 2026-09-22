; HotFix.BattleLogic.WaterfallBattleManager$$CalTileSpecialMonsterCount
; RVA 0x65D1854; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D1854  sub      sp, sp, #0x70
0065D1858  stp      x29, x30, [sp, #0x10]
0065D185C  stp      x28, x27, [sp, #0x20]
0065D1860  stp      x26, x25, [sp, #0x30]
0065D1864  stp      x24, x23, [sp, #0x40]
0065D1868  stp      x22, x21, [sp, #0x50]
0065D186C  stp      x20, x19, [sp, #0x60]
0065D1870  adrp     x19, #0x9599000
0065D1874  adrp     x22, #0x8f0a000
0065D1878  ldrb     w8, [x19, #0x58d]
0065D187C  ldr      x22, [x22, #0x9f0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CalTileSpecialMonsterCount()
0065D1880  mov      w23, w2
0065D1884  mov      x20, x1
0065D1888  mov      x21, x0
0065D188C  tbnz     w8, #0, #0x65d1910
0065D1890  adrp     x0, #0x8f0a000
0065D1894  ldr      x0, [x0, #0x9f8] ; GLOBAL HotFix.BattleLogic.CalMonsterCountData_TypeInfo
0065D1898  bl       #0x382bd14 ; 
0065D189C  adrp     x0, #0x8f0a000
0065D18A0  ldr      x0, [x0, #0xa00] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.Add()
0065D18A4  bl       #0x382bd14 ; 
0065D18A8  adrp     x0, #0x8f0a000
0065D18AC  ldr      x0, [x0, #0xa08] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.TryGetValue()
0065D18B0  bl       #0x382bd14 ; 
0065D18B4  adrp     x0, #0x8f09000
0065D18B8  ldr      x0, [x0, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D18BC  bl       #0x382bd14 ; 
0065D18C0  adrp     x0, #0x8ee1000
0065D18C4  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo
0065D18C8  bl       #0x382bd14 ; 
0065D18CC  adrp     x0, #0x8f0a000
0065D18D0  ldr      x0, [x0, #0x9f0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CalTileSpecialMonsterCount()
0065D18D4  bl       #0x382bd14 ; 
0065D18D8  adrp     x0, #0x8f0a000
0065D18DC  ldr      x0, [x0, #0xa10] ; GLOBAL HotFix.BattleLogic.WaveMissionRandomData_TypeInfo
0065D18E0  bl       #0x382bd14 ; 
0065D18E4  adrp     x0, #0x8f0a000
0065D18E8  ldr      x0, [x0, #0xa18] ; GLOBAL CalTileSpecialMonsterCount
0065D18EC  bl       #0x382bd14 ; 
0065D18F0  adrp     x0, #0x8f0a000
0065D18F4  ldr      x0, [x0, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065D18F8  bl       #0x382bd14 ; 
0065D18FC  adrp     x0, #0x8f0a000
0065D1900  ldr      x0, [x0, #0x8c8] ; GLOBAL 刷怪配置不存在
0065D1904  bl       #0x382bd14 ; 
0065D1908  mov      w8, #1
0065D190C  strb     w8, [x19, #0x58d]
0065D1910  ldr      x3, [x22]
0065D1914  ldrb     w8, [x3, #0x53]
0065D1918  tbnz     w8, #5, #0x65d1978
0065D191C  adrp     x8, #0x8f0a000
0065D1920  ldr      x8, [x8, #0x9f8] ; GLOBAL HotFix.BattleLogic.CalMonsterCountData_TypeInfo
0065D1924  str      xzr, [sp, #8]
0065D1928  ldr      x0, [x8]
0065D192C  bl       #0x382bfa0 ; 
0065D1930  mov      x22, x0
0065D1934  bl       #0x65c7420 ; HotFix.BattleLogic.CalMonsterCountData$$.ctor
0065D1938  adrp     x8, #0x9599000
0065D193C  ldrb     w8, [x8, #0x286]
0065D1940  cbnz     w8, #0x65d195c
0065D1944  adrp     x0, #0x8f07000
0065D1948  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D194C  bl       #0x382bd14 ; 
0065D1950  mov      w8, #1
0065D1954  adrp     x9, #0x9599000
0065D1958  strb     w8, [x9, #0x286]
0065D195C  adrp     x8, #0x8f07000
0065D1960  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D1964  ldr      x1, [x8]
0065D1968  ldrb     w8, [x1, #0x53]
0065D196C  tbnz     w8, #5, #0x65d19a8
0065D1970  ldr      x24, [x21, #0x80]
0065D1974  b        #0x65d19b8 ; 
0065D1978  ldr      x4, [x3, #0x60]
0065D197C  mov      x0, x21
0065D1980  mov      x1, x20
0065D1984  mov      w2, w23
0065D1988  ldp      x20, x19, [sp, #0x60]
0065D198C  ldp      x22, x21, [sp, #0x50]
0065D1990  ldp      x24, x23, [sp, #0x40]
0065D1994  ldp      x26, x25, [sp, #0x30]
0065D1998  ldp      x28, x27, [sp, #0x20]
0065D199C  ldp      x29, x30, [sp, #0x10]
0065D19A0  add      sp, sp, #0x70
0065D19A4  br       x4
0065D19A8  ldr      x8, [x1, #0x60]
0065D19AC  mov      x0, x21
0065D19B0  blr      x8
0065D19B4  mov      x24, x0
0065D19B8  cbz      x24, #0x65d223c
0065D19BC  adrp     x19, #0x9591000
0065D19C0  ldrb     w8, [x19, #0xa9c]
0065D19C4  cbnz     w8, #0x65d19dc
0065D19C8  adrp     x0, #0x8ee6000
0065D19CC  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065D19D0  bl       #0x382bd14 ; 
0065D19D4  mov      w8, #1
0065D19D8  strb     w8, [x19, #0xa9c]
0065D19DC  adrp     x8, #0x8ee6000
0065D19E0  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065D19E4  ldr      x1, [x8]
0065D19E8  ldrb     w8, [x1, #0x53]
0065D19EC  tbnz     w8, #5, #0x65d19f8
0065D19F0  ldr      x26, [x24, #0x240]
0065D19F4  b        #0x65d1a08 ; 
0065D19F8  ldr      x8, [x1, #0x60]
0065D19FC  mov      x0, x24
0065D1A00  blr      x8
0065D1A04  mov      x26, x0
0065D1A08  cbz      x20, #0x65d223c
0065D1A0C  adrp     x10, #0x8f09000
0065D1A10  ldr      x8, [x20]
0065D1A14  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D1A18  ldrh     w9, [x8, #0x12e]
0065D1A1C  ldr      x1, [x10]
0065D1A20  cbz      x9, #0x65d1a44
0065D1A24  ldr      x10, [x8, #0xb0]
0065D1A28  add      x10, x10, #8
0065D1A2C  ldur     x11, [x10, #-8]
0065D1A30  cmp      x11, x1
0065D1A34  b.eq     #0x65d1a54
0065D1A38  subs     x9, x9, #1
0065D1A3C  add      x10, x10, #0x10
0065D1A40  b.ne     #0x65d1a2c
0065D1A44  mov      w2, #0xe
0065D1A48  mov      x0, x20
0065D1A4C  bl       #0x3a7e710 ; 
0065D1A50  b        #0x65d1a64 ; 
0065D1A54  ldr      w9, [x10]
0065D1A58  add      w9, w9, #0xe
0065D1A5C  add      x8, x8, w9, sxtw #4
0065D1A60  add      x0, x8, #0x138
0065D1A64  ldp      x8, x1, [x0]
0065D1A68  mov      x0, x20
0065D1A6C  blr      x8
0065D1A70  ldr      x8, [x20]
0065D1A74  adrp     x10, #0x8f09000
0065D1A78  mov      w27, w0
0065D1A7C  ldrh     w9, [x8, #0x12e]
0065D1A80  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D1A84  ldr      x1, [x10]
0065D1A88  cbz      x9, #0x65d1aac
0065D1A8C  ldr      x10, [x8, #0xb0]
0065D1A90  add      x10, x10, #8
0065D1A94  ldur     x11, [x10, #-8]
0065D1A98  cmp      x11, x1
0065D1A9C  b.eq     #0x65d1abc
0065D1AA0  subs     x9, x9, #1
0065D1AA4  add      x10, x10, #0x10
0065D1AA8  b.ne     #0x65d1a94
0065D1AAC  mov      x0, x20
0065D1AB0  mov      w2, wzr
0065D1AB4  bl       #0x3a7e710 ; 
0065D1AB8  b        #0x65d1ac8 ; 
0065D1ABC  ldrsw    x9, [x10]
0065D1AC0  add      x8, x8, x9, lsl #4
0065D1AC4  add      x0, x8, #0x138
0065D1AC8  ldp      x8, x1, [x0]
0065D1ACC  mov      x0, x20
0065D1AD0  blr      x8
0065D1AD4  mov      w24, w0
0065D1AD8  mov      x0, x21
0065D1ADC  bl       #0x65d3784 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
0065D1AE0  ldr      x8, [x21, #0x1f0]
0065D1AE4  cbz      x8, #0x65d223c
0065D1AE8  adrp     x9, #0x8f0a000
0065D1AEC  ldr      x9, [x9, #0xa08] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.TryGetValue()
0065D1AF0  mov      w29, w0
0065D1AF4  add      x2, sp, #8
0065D1AF8  mov      x0, x8
0065D1AFC  ldr      x3, [x9]
0065D1B00  mov      w1, w24
0065D1B04  bl       #0x5e614ec ; System.Collections.Generic.Dictionary<int, object>$$TryGetValue
0065D1B08  tbnz     w0, #0, #0x65d1b48
0065D1B0C  adrp     x8, #0x8f0a000
0065D1B10  ldr      x8, [x8, #0xa10] ; GLOBAL HotFix.BattleLogic.WaveMissionRandomData_TypeInfo
0065D1B14  ldr      x0, [x8]
0065D1B18  bl       #0x382bfa0 ; 
0065D1B1C  mov      x28, x0
0065D1B20  bl       #0x65c74f0 ; HotFix.BattleLogic.WaveMissionRandomData$$.ctor
0065D1B24  str      x28, [sp, #8]
0065D1B28  ldr      x0, [x21, #0x1f0]
0065D1B2C  cbz      x0, #0x65d223c
0065D1B30  adrp     x8, #0x8f0a000
0065D1B34  ldr      x8, [x8, #0xa00] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.Add()
0065D1B38  mov      w1, w24
0065D1B3C  mov      x2, x28
0065D1B40  ldr      x3, [x8]
0065D1B44  bl       #0x5e5fa3c ; System.Collections.Generic.Dictionary<int, object>$$Add
0065D1B48  cmp      w27, #1
0065D1B4C  str      w23, [sp, #4]
0065D1B50  b.lt     #0x65d2218
0065D1B54  adrp     x8, #0x9599000
0065D1B58  ldrb     w8, [x8, #0x286]
0065D1B5C  cbnz     w8, #0x65d1b78
0065D1B60  adrp     x0, #0x8f07000
0065D1B64  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D1B68  bl       #0x382bd14 ; 
0065D1B6C  mov      w8, #1
0065D1B70  adrp     x9, #0x9599000
0065D1B74  strb     w8, [x9, #0x286]
0065D1B78  adrp     x8, #0x8f07000
0065D1B7C  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D1B80  ldr      x1, [x8]
0065D1B84  ldrb     w8, [x1, #0x53]
0065D1B88  tbnz     w8, #5, #0x65d1b94
0065D1B8C  ldr      x28, [x21, #0x80]
0065D1B90  b        #0x65d1ba4 ; 
0065D1B94  ldr      x8, [x1, #0x60]
0065D1B98  mov      x0, x21
0065D1B9C  blr      x8
0065D1BA0  mov      x28, x0
0065D1BA4  cbz      x28, #0x65d223c
0065D1BA8  adrp     x8, #0x9598000
0065D1BAC  ldrb     w8, [x8, #0xfcc]
0065D1BB0  cbnz     w8, #0x65d1bcc
0065D1BB4  adrp     x0, #0x8f06000
0065D1BB8  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D1BBC  bl       #0x382bd14 ; 
0065D1BC0  mov      w8, #1
0065D1BC4  adrp     x9, #0x9598000
0065D1BC8  strb     w8, [x9, #0xfcc]
0065D1BCC  adrp     x8, #0x8f06000
0065D1BD0  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D1BD4  ldr      x1, [x8]
0065D1BD8  ldrb     w8, [x1, #0x53]
0065D1BDC  tbnz     w8, #5, #0x65d1be8
0065D1BE0  ldr      x0, [x28, #0x200]
0065D1BE4  b        #0x65d1bf4 ; 
0065D1BE8  ldr      x8, [x1, #0x60]
0065D1BEC  mov      x0, x28
0065D1BF0  blr      x8
0065D1BF4  cbz      x0, #0x65d223c
0065D1BF8  mov      w1, w27
0065D1BFC  mov      x2, xzr
0065D1C00  bl       #0x64d3fa0 ; LocalModels.LocalModelManager$$GetMission_PositionMonsterFlushConfig
0065D1C04  cbz      x0, #0x65d1c48
0065D1C08  adrp     x19, #0x9599000
0065D1C0C  ldrb     w8, [x19, #0x657]
0065D1C10  mov      x27, x0
0065D1C14  cbnz     w8, #0x65d1c2c
0065D1C18  adrp     x0, #0x8f0a000
0065D1C1C  ldr      x0, [x0, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool()
0065D1C20  bl       #0x382bd14 ; 
0065D1C24  mov      w8, #1
0065D1C28  strb     w8, [x19, #0x657]
0065D1C2C  adrp     x23, #0x8f0a000
0065D1C30  ldr      x23, [x23, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool()
0065D1C34  ldr      x1, [x23]
0065D1C38  ldrb     w8, [x1, #0x53]
0065D1C3C  tbnz     w8, #5, #0x65d1c94
0065D1C40  ldr      x0, [x27, #0x28]
0065D1C44  b        #0x65d1ca0 ; 
0065D1C48  adrp     x8, #0x8ee1000
0065D1C4C  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
0065D1C50  ldr      x0, [x8]
0065D1C54  ldr      w8, [x0, #0xe0]
0065D1C58  cbnz     w8, #0x65d1c60
0065D1C5C  bl       #0x382be8c ; 
0065D1C60  adrp     x8, #0x8f0a000
0065D1C64  adrp     x9, #0x8f0a000
0065D1C68  adrp     x10, #0x8f0a000
0065D1C6C  ldr      x8, [x8, #0x8c8] ; GLOBAL 刷怪配置不存在
0065D1C70  ldr      x9, [x9, #0xa18] ; GLOBAL CalTileSpecialMonsterCount
0065D1C74  ldr      x10, [x10, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065D1C78  mov      w3, #0x486
0065D1C7C  ldr      x0, [x8]
0065D1C80  ldr      x1, [x9]
0065D1C84  ldr      x2, [x10]
0065D1C88  mov      x4, xzr
0065D1C8C  bl       #0x7997754 ; Logger$$LogError
0065D1C90  b        #0x65d2218 ; 
0065D1C94  ldr      x8, [x1, #0x60]
0065D1C98  mov      x0, x27
0065D1C9C  blr      x8
0065D1CA0  cbz      x0, #0x65d223c
0065D1CA4  ldr      x8, [x0, #0x18]
0065D1CA8  cbz      x8, #0x65d2218
0065D1CAC  ldrb     w8, [x19, #0x657]
0065D1CB0  cbnz     w8, #0x65d1cc8
0065D1CB4  adrp     x0, #0x8f0a000
0065D1CB8  ldr      x0, [x0, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool()
0065D1CBC  bl       #0x382bd14 ; 
0065D1CC0  mov      w8, #1
0065D1CC4  strb     w8, [x19, #0x657]
0065D1CC8  ldr      x1, [x23]
0065D1CCC  ldrb     w8, [x1, #0x53]
0065D1CD0  tbnz     w8, #5, #0x65d1cdc
0065D1CD4  ldr      x1, [x27, #0x28]
0065D1CD8  b        #0x65d1cec ; 
0065D1CDC  ldr      x8, [x1, #0x60]
0065D1CE0  mov      x0, x27
0065D1CE4  blr      x8
0065D1CE8  mov      x1, x0
0065D1CEC  cbz      x26, #0x65d223c
0065D1CF0  mov      x0, x26
0065D1CF4  mov      x2, xzr
0065D1CF8  bl       #0x6903320 ; HotFix.BattleLogic.MapManager$$WaterfallRandomMap
0065D1CFC  ldr      x8, [sp, #8]
0065D1D00  cbz      x8, #0x65d223c
0065D1D04  str      w0, [x8, #0x10]
0065D1D08  adrp     x19, #0x9599000
0065D1D0C  ldrb     w8, [x19, #0x26f]
0065D1D10  mov      w27, w0
0065D1D14  cbnz     w8, #0x65d1d2c
0065D1D18  adrp     x0, #0x8f06000
0065D1D1C  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData()
0065D1D20  bl       #0x382bd14 ; 
0065D1D24  mov      w8, #1
0065D1D28  strb     w8, [x19, #0x26f]
0065D1D2C  adrp     x8, #0x8f06000
0065D1D30  ldr      x8, [x8, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData()
0065D1D34  ldr      x1, [x8]
0065D1D38  ldrb     w8, [x1, #0x53]
0065D1D3C  tbnz     w8, #5, #0x65d1d48
0065D1D40  ldr      x0, [x26, #0x20]
0065D1D44  b        #0x65d1d54 ; 
0065D1D48  ldr      x8, [x1, #0x60]
0065D1D4C  mov      x0, x26
0065D1D50  blr      x8
0065D1D54  cbz      x0, #0x65d223c
0065D1D58  ldr      x8, [x0, #0x140]
0065D1D5C  cbz      x8, #0x65d223c
0065D1D60  ldr      w9, [x8, #0x18]
0065D1D64  cmp      w27, w9
0065D1D68  b.hs     #0x65d2240
0065D1D6C  add      x8, x8, w27, sxtw #4
0065D1D70  ldr      x23, [x8, #0x28]
0065D1D74  cbz      x23, #0x65d2218
0065D1D78  ldr      x8, [x20]
0065D1D7C  adrp     x10, #0x8f09000
0065D1D80  ldr      x25, [x23, #0x18]
0065D1D84  ldrh     w9, [x8, #0x12e]
0065D1D88  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D1D8C  ldr      x1, [x10]
0065D1D90  cbz      x9, #0x65d1db4
0065D1D94  ldr      x10, [x8, #0xb0]
0065D1D98  add      x10, x10, #8
0065D1D9C  ldur     x11, [x10, #-8]
0065D1DA0  cmp      x11, x1
0065D1DA4  b.eq     #0x65d1dc4
0065D1DA8  subs     x9, x9, #1
0065D1DAC  add      x10, x10, #0x10
0065D1DB0  b.ne     #0x65d1d9c
0065D1DB4  mov      w2, #0x10
0065D1DB8  mov      x0, x20
0065D1DBC  bl       #0x3a7e710 ; 
0065D1DC0  b        #0x65d1dd4 ; 
0065D1DC4  ldr      w9, [x10]
0065D1DC8  add      w9, w9, #0x10
0065D1DCC  add      x8, x8, w9, sxtw #4
0065D1DD0  add      x0, x8, #0x138
0065D1DD4  ldp      x8, x1, [x0]
0065D1DD8  mov      x0, x20
0065D1DDC  blr      x8
0065D1DE0  cbz      x0, #0x65d223c
0065D1DE4  ldr      x8, [x0, #0x18]
0065D1DE8  cbz      x8, #0x65d1e2c
0065D1DEC  adrp     x8, #0x9599000
0065D1DF0  ldrb     w8, [x8, #0x286]
0065D1DF4  cbnz     w8, #0x65d1e10
0065D1DF8  adrp     x0, #0x8f07000
0065D1DFC  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D1E00  bl       #0x382bd14 ; 
0065D1E04  mov      w8, #1
0065D1E08  adrp     x9, #0x9599000
0065D1E0C  strb     w8, [x9, #0x286]
0065D1E10  adrp     x8, #0x8f07000
0065D1E14  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D1E18  ldr      x1, [x8]
0065D1E1C  ldrb     w8, [x1, #0x53]
0065D1E20  tbnz     w8, #5, #0x65d1e34
0065D1E24  ldr      x26, [x21, #0x80]
0065D1E28  b        #0x65d1e44 ; 
0065D1E2C  mov      w24, wzr
0065D1E30  b        #0x65d1f50 ; 
0065D1E34  ldr      x8, [x1, #0x60]
0065D1E38  mov      x0, x21
0065D1E3C  blr      x8
0065D1E40  mov      x26, x0
0065D1E44  ldr      x8, [x20]
0065D1E48  adrp     x10, #0x8f09000
0065D1E4C  ldrh     w9, [x8, #0x12e]
0065D1E50  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D1E54  ldr      x1, [x10]
0065D1E58  cbz      x9, #0x65d1e7c
0065D1E5C  ldr      x10, [x8, #0xb0]
0065D1E60  add      x10, x10, #8
0065D1E64  ldur     x11, [x10, #-8]
0065D1E68  cmp      x11, x1
0065D1E6C  b.eq     #0x65d1e8c
0065D1E70  subs     x9, x9, #1
0065D1E74  add      x10, x10, #0x10
0065D1E78  b.ne     #0x65d1e64
0065D1E7C  mov      w2, #0x10
0065D1E80  mov      x0, x20
0065D1E84  bl       #0x3a7e710 ; 
0065D1E88  b        #0x65d1e9c ; 
0065D1E8C  ldr      w9, [x10]
0065D1E90  add      w9, w9, #0x10
0065D1E94  add      x8, x8, w9, sxtw #4
0065D1E98  add      x0, x8, #0x138
0065D1E9C  ldp      x8, x1, [x0]
0065D1EA0  mov      x0, x20
0065D1EA4  blr      x8
0065D1EA8  cbz      x0, #0x65d223c
0065D1EAC  cbz      x26, #0x65d223c
0065D1EB0  ldr      w2, [x0, #0x18]
0065D1EB4  mov      x0, x26
0065D1EB8  mov      w1, wzr
0065D1EBC  mov      x3, xzr
0065D1EC0  bl       #0x54b65d8 ; 
0065D1EC4  ldr      x8, [sp, #8]
0065D1EC8  cbz      x8, #0x65d223c
0065D1ECC  str      w0, [x8, #0x14]
0065D1ED0  ldr      x8, [x20]
0065D1ED4  adrp     x10, #0x8f09000
0065D1ED8  mov      w26, w0
0065D1EDC  ldrh     w9, [x8, #0x12e]
0065D1EE0  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D1EE4  ldr      x1, [x10]
0065D1EE8  cbz      x9, #0x65d1f0c
0065D1EEC  ldr      x10, [x8, #0xb0]
0065D1EF0  add      x10, x10, #8
0065D1EF4  ldur     x11, [x10, #-8]
0065D1EF8  cmp      x11, x1
0065D1EFC  b.eq     #0x65d1f1c
0065D1F00  subs     x9, x9, #1
0065D1F04  add      x10, x10, #0x10
0065D1F08  b.ne     #0x65d1ef4
0065D1F0C  mov      w2, #0x10
0065D1F10  mov      x0, x20
0065D1F14  bl       #0x3a7e710 ; 
0065D1F18  b        #0x65d1f2c ; 
0065D1F1C  ldr      w9, [x10]
0065D1F20  add      w9, w9, #0x10
0065D1F24  add      x8, x8, w9, sxtw #4
0065D1F28  add      x0, x8, #0x138
0065D1F2C  ldp      x8, x1, [x0]
0065D1F30  mov      x0, x20
0065D1F34  blr      x8
0065D1F38  cbz      x0, #0x65d223c
0065D1F3C  ldr      w8, [x0, #0x18]
0065D1F40  cmp      w26, w8
0065D1F44  b.hs     #0x65d2240
0065D1F48  add      x8, x0, w26, sxtw #2
0065D1F4C  ldr      w24, [x8, #0x20]
0065D1F50  cmp      w25, #1
0065D1F54  b.lt     #0x65d2218
0065D1F58  adrp     x27, #0x8f0a000
0065D1F5C  ldr      x27, [x27, #0xa20] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_expWeight()
0065D1F60  mov      x19, xzr
0065D1F64  and      x26, x25, #0xffffffff
0065D1F68  mov      w25, #1
0065D1F6C  and      w8, w29, #1
0065D1F70  str      w8, [sp]
0065D1F74  ldr      w8, [x23, #0x18]
0065D1F78  cmp      x19, x8
0065D1F7C  b.hs     #0x65d2240
0065D1F80  ldr      x8, [x20]
0065D1F84  mov      w9, #0x38
0065D1F88  madd     x9, x19, x9, x23
0065D1F8C  adrp     x10, #0x8f09000
0065D1F90  ldr      w28, [x9, #0x20]
0065D1F94  ldrh     w9, [x8, #0x12e]
0065D1F98  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D1F9C  ldr      x1, [x10]
0065D1FA0  cbz      x9, #0x65d1fc4
0065D1FA4  ldr      x10, [x8, #0xb0]
0065D1FA8  add      x10, x10, #8
0065D1FAC  ldur     x11, [x10, #-8]
0065D1FB0  cmp      x11, x1
0065D1FB4  b.eq     #0x65d1fd4
0065D1FB8  subs     x9, x9, #1
0065D1FBC  add      x10, x10, #0x10
0065D1FC0  b.ne     #0x65d1fac
0065D1FC4  mov      w2, #0x10
0065D1FC8  mov      x0, x20
0065D1FCC  bl       #0x3a7e710 ; 
0065D1FD0  b        #0x65d1fe4 ; 
0065D1FD4  ldr      w9, [x10]
0065D1FD8  add      w9, w9, #0x10
0065D1FDC  add      x8, x8, w9, sxtw #4
0065D1FE0  add      x0, x8, #0x138
0065D1FE4  ldp      x8, x1, [x0]
0065D1FE8  mov      x0, x20
0065D1FEC  blr      x8
0065D1FF0  cbz      x0, #0x65d223c
0065D1FF4  ldr      x8, [x0, #0x18]
0065D1FF8  adrp     x9, #0x9599000
0065D1FFC  ldrb     w9, [x9, #0x286]
0065D2000  cmp      x8, #0
0065D2004  csel     w28, w28, w24, eq
0065D2008  cbnz     w9, #0x65d2020
0065D200C  adrp     x0, #0x8f07000
0065D2010  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D2014  bl       #0x382bd14 ; 
0065D2018  adrp     x8, #0x9599000
0065D201C  strb     w25, [x8, #0x286]
0065D2020  adrp     x8, #0x8f07000
0065D2024  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D2028  ldr      x1, [x8]
0065D202C  ldrb     w8, [x1, #0x53]
0065D2030  tbnz     w8, #5, #0x65d203c
0065D2034  ldr      x29, [x21, #0x80]
0065D2038  b        #0x65d204c ; 
0065D203C  ldr      x8, [x1, #0x60]
0065D2040  mov      x0, x21
0065D2044  blr      x8
0065D2048  mov      x29, x0
0065D204C  cbz      x29, #0x65d223c
0065D2050  adrp     x8, #0x9598000
0065D2054  ldrb     w8, [x8, #0xfcc]
0065D2058  cbnz     w8, #0x65d2070
0065D205C  adrp     x0, #0x8f06000
0065D2060  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D2064  bl       #0x382bd14 ; 
0065D2068  adrp     x8, #0x9598000
0065D206C  strb     w25, [x8, #0xfcc]
0065D2070  adrp     x8, #0x8f06000
0065D2074  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D2078  ldr      x1, [x8]
0065D207C  ldrb     w8, [x1, #0x53]
0065D2080  tbnz     w8, #5, #0x65d208c
0065D2084  ldr      x0, [x29, #0x200]
0065D2088  b        #0x65d2098 ; 
0065D208C  ldr      x8, [x1, #0x60]
0065D2090  mov      x0, x29
0065D2094  blr      x8
0065D2098  cbz      x0, #0x65d223c
0065D209C  mov      w1, w28
0065D20A0  mov      x2, xzr
0065D20A4  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065D20A8  cbz      x0, #0x65d220c
0065D20AC  adrp     x8, #0x9591000
0065D20B0  ldrb     w8, [x8, #0xa75]
0065D20B4  mov      x28, x0
0065D20B8  cbnz     w8, #0x65d20d0
0065D20BC  adrp     x0, #0x8ee6000
0065D20C0  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0065D20C4  bl       #0x382bd14 ; 
0065D20C8  adrp     x8, #0x9591000
0065D20CC  strb     w25, [x8, #0xa75]
0065D20D0  adrp     x8, #0x8ee6000
0065D20D4  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0065D20D8  ldr      x1, [x8]
0065D20DC  ldrb     w8, [x1, #0x53]
0065D20E0  tbnz     w8, #5, #0x65d20ec
0065D20E4  ldr      w0, [x28, #0x24]
0065D20E8  b        #0x65d20f8 ; 
0065D20EC  ldr      x8, [x1, #0x60]
0065D20F0  mov      x0, x28
0065D20F4  blr      x8
0065D20F8  cmp      w0, #0xc9
0065D20FC  b.eq     #0x65d2150
0065D2100  adrp     x8, #0x9591000
0065D2104  ldrb     w8, [x8, #0xa75]
0065D2108  cbnz     w8, #0x65d2120
0065D210C  adrp     x0, #0x8ee6000
0065D2110  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0065D2114  bl       #0x382bd14 ; 
0065D2118  adrp     x8, #0x9591000
0065D211C  strb     w25, [x8, #0xa75]
0065D2120  adrp     x8, #0x8ee6000
0065D2124  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0065D2128  ldr      x1, [x8]
0065D212C  ldrb     w8, [x1, #0x53]
0065D2130  tbnz     w8, #5, #0x65d213c
0065D2134  ldr      w0, [x28, #0x24]
0065D2138  b        #0x65d2148 ; 
0065D213C  ldr      x8, [x1, #0x60]
0065D2140  mov      x0, x28
0065D2144  blr      x8
0065D2148  cmp      w0, #3
0065D214C  b.ne     #0x65d2160
0065D2150  cbz      x22, #0x65d223c
0065D2154  ldr      w8, [x22, #0x14]
0065D2158  add      w8, w8, #1
0065D215C  str      w8, [x22, #0x14]
0065D2160  adrp     x8, #0x9599000
0065D2164  ldrb     w8, [x8, #0x65d]
0065D2168  cbnz     w8, #0x65d217c
0065D216C  mov      x0, x27
0065D2170  bl       #0x382bd14 ; 
0065D2174  adrp     x8, #0x9599000
0065D2178  strb     w25, [x8, #0x65d]
0065D217C  ldr      x1, [x27]
0065D2180  ldrb     w8, [x1, #0x53]
0065D2184  tbnz     w8, #5, #0x65d2190
0065D2188  ldr      w0, [x28, #0x24c]
0065D218C  b        #0x65d219c ; 
0065D2190  ldr      x8, [x1, #0x60]
0065D2194  mov      x0, x28
0065D2198  blr      x8
0065D219C  cmp      w0, #1
0065D21A0  b.lt     #0x65d21fc
0065D21A4  cbz      x22, #0x65d223c
0065D21A8  ldr      w8, [x22, #0x10]
0065D21AC  ldr      w29, [x22, #0x18]
0065D21B0  add      w8, w8, #1
0065D21B4  str      w8, [x22, #0x10]
0065D21B8  adrp     x8, #0x9599000
0065D21BC  ldrb     w8, [x8, #0x65d]
0065D21C0  cbnz     w8, #0x65d21d4
0065D21C4  mov      x0, x27
0065D21C8  bl       #0x382bd14 ; 
0065D21CC  adrp     x8, #0x9599000
0065D21D0  strb     w25, [x8, #0x65d]
0065D21D4  ldr      x1, [x27]
0065D21D8  ldrb     w8, [x1, #0x53]
0065D21DC  tbnz     w8, #5, #0x65d21e8
0065D21E0  ldr      w0, [x28, #0x24c]
0065D21E4  b        #0x65d21f4 ; 
0065D21E8  ldr      x8, [x1, #0x60]
0065D21EC  mov      x0, x28
0065D21F0  blr      x8
0065D21F4  add      w8, w0, w29
0065D21F8  str      w8, [x22, #0x18]
0065D21FC  ldp      w2, w3, [sp]
0065D2200  mov      x0, x21
0065D2204  mov      x1, x28
0065D2208  bl       #0x65d3844 ; HotFix.BattleLogic.WaterfallBattleManager$$AddDropType2Count
0065D220C  add      x19, x19, #1
0065D2210  cmp      x19, x26
0065D2214  b.ne     #0x65d1f74
0065D2218  mov      x0, x22
0065D221C  ldp      x20, x19, [sp, #0x60]
0065D2220  ldp      x22, x21, [sp, #0x50]
0065D2224  ldp      x24, x23, [sp, #0x40]
0065D2228  ldp      x26, x25, [sp, #0x30]
0065D222C  ldp      x28, x27, [sp, #0x20]
0065D2230  ldp      x29, x30, [sp, #0x10]
0065D2234  add      sp, sp, #0x70
0065D2238  ret      
0065D223C  bl       #0x382bfb8 ; 
0065D2240  bl       #0x382bfc0 ; 

