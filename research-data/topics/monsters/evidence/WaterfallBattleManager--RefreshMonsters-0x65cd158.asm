; HotFix.BattleLogic.WaterfallBattleManager$$RefreshMonsters
; RVA 0x65CD158; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CD158  str      x30, [sp, #-0x50]!
0065CD15C  stp      x26, x25, [sp, #0x10]
0065CD160  stp      x24, x23, [sp, #0x20]
0065CD164  stp      x22, x21, [sp, #0x30]
0065CD168  stp      x20, x19, [sp, #0x40]
0065CD16C  adrp     x20, #0x9599000
0065CD170  adrp     x21, #0x8f0a000
0065CD174  ldrb     w8, [x20, #0x581]
0065CD178  ldr      x21, [x21, #0x890] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.RefreshMonsters()
0065CD17C  mov      x19, x0
0065CD180  tbnz     w8, #0, #0x65cd1a4
0065CD184  adrp     x0, #0x8f09000
0065CD188  ldr      x0, [x0, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CD18C  bl       #0x382bd14 ; 
0065CD190  adrp     x0, #0x8f0a000
0065CD194  ldr      x0, [x0, #0x890] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.RefreshMonsters()
0065CD198  bl       #0x382bd14 ; 
0065CD19C  mov      w8, #1
0065CD1A0  strb     w8, [x20, #0x581]
0065CD1A4  ldr      x1, [x21]
0065CD1A8  ldrb     w8, [x1, #0x53]
0065CD1AC  tbnz     w8, #5, #0x65cd1d0
0065CD1B0  ldrb     w8, [x19, #0x78]
0065CD1B4  cbz      w8, #0x65cd1f0
0065CD1B8  ldp      x20, x19, [sp, #0x40]
0065CD1BC  ldp      x22, x21, [sp, #0x30]
0065CD1C0  ldp      x24, x23, [sp, #0x20]
0065CD1C4  ldp      x26, x25, [sp, #0x10]
0065CD1C8  ldr      x30, [sp], #0x50
0065CD1CC  ret      
0065CD1D0  ldr      x2, [x1, #0x60]
0065CD1D4  mov      x0, x19
0065CD1D8  ldp      x20, x19, [sp, #0x40]
0065CD1DC  ldp      x22, x21, [sp, #0x30]
0065CD1E0  ldp      x24, x23, [sp, #0x20]
0065CD1E4  ldp      x26, x25, [sp, #0x10]
0065CD1E8  ldr      x30, [sp], #0x50
0065CD1EC  br       x2
0065CD1F0  mov      x0, x19
0065CD1F4  mov      x1, xzr
0065CD1F8  bl       #0x6587904 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$MarkLastMissionRefreshStarted
0065CD1FC  ldr      x20, [x19, #0x188]
0065CD200  cbz      x20, #0x65cd7c0
0065CD204  adrp     x26, #0x8f09000
0065CD208  ldr      x8, [x20]
0065CD20C  ldr      x26, [x26, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CD210  ldrh     w9, [x8, #0x12e]
0065CD214  ldr      x1, [x26]
0065CD218  cbz      x9, #0x65cd23c
0065CD21C  ldr      x10, [x8, #0xb0]
0065CD220  add      x10, x10, #8
0065CD224  ldur     x11, [x10, #-8]
0065CD228  cmp      x11, x1
0065CD22C  b.eq     #0x65cd24c
0065CD230  subs     x9, x9, #1
0065CD234  add      x10, x10, #0x10
0065CD238  b.ne     #0x65cd224
0065CD23C  mov      w2, #8
0065CD240  mov      x0, x20
0065CD244  bl       #0x3a7e710 ; 
0065CD248  b        #0x65cd25c ; 
0065CD24C  ldr      w9, [x10]
0065CD250  add      w9, w9, #8
0065CD254  add      x8, x8, w9, sxtw #4
0065CD258  add      x0, x8, #0x138
0065CD25C  ldp      x8, x1, [x0]
0065CD260  mov      x0, x20
0065CD264  blr      x8
0065CD268  adrp     x24, #0x8f07000
0065CD26C  ldr      x24, [x24, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CD270  cmp      w0, #9
0065CD274  adrp     x25, #0x9599000
0065CD278  b.eq     #0x65cd36c
0065CD27C  ldr      x20, [x19, #0x140]
0065CD280  cbz      x20, #0x65cd7c0
0065CD284  adrp     x22, #0x9599000
0065CD288  ldrb     w8, [x22, #0x656]
0065CD28C  cbnz     w8, #0x65cd2a4
0065CD290  adrp     x0, #0x8f0a000
0065CD294  ldr      x0, [x0, #0x898] ; GLOBAL Method$LocalModels.Bean.ChapterWave_Waves.get_bgMusic()
0065CD298  bl       #0x382bd14 ; 
0065CD29C  mov      w8, #1
0065CD2A0  strb     w8, [x22, #0x656]
0065CD2A4  adrp     x23, #0x8f0a000
0065CD2A8  ldr      x23, [x23, #0x898] ; GLOBAL Method$LocalModels.Bean.ChapterWave_Waves.get_bgMusic()
0065CD2AC  ldr      x1, [x23]
0065CD2B0  ldrb     w8, [x1, #0x53]
0065CD2B4  tbnz     w8, #5, #0x65cd2c0
0065CD2B8  ldr      w0, [x20, #0x68]
0065CD2BC  b        #0x65cd2cc ; 
0065CD2C0  ldr      x8, [x1, #0x60]
0065CD2C4  mov      x0, x20
0065CD2C8  blr      x8
0065CD2CC  cmp      w0, #1
0065CD2D0  b.lt     #0x65cd36c
0065CD2D4  ldrb     w8, [x25, #0x286]
0065CD2D8  cbnz     w8, #0x65cd2f0
0065CD2DC  adrp     x0, #0x8f07000
0065CD2E0  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CD2E4  bl       #0x382bd14 ; 
0065CD2E8  mov      w8, #1
0065CD2EC  strb     w8, [x25, #0x286]
0065CD2F0  ldr      x1, [x24]
0065CD2F4  ldrb     w8, [x1, #0x53]
0065CD2F8  tbnz     w8, #5, #0x65cd304
0065CD2FC  ldr      x20, [x19, #0x80]
0065CD300  b        #0x65cd314 ; 
0065CD304  ldr      x8, [x1, #0x60]
0065CD308  mov      x0, x19
0065CD30C  blr      x8
0065CD310  mov      x20, x0
0065CD314  ldr      x21, [x19, #0x140]
0065CD318  cbz      x21, #0x65cd7c0
0065CD31C  ldrb     w8, [x22, #0x656]
0065CD320  cbnz     w8, #0x65cd338
0065CD324  adrp     x0, #0x8f0a000
0065CD328  ldr      x0, [x0, #0x898] ; GLOBAL Method$LocalModels.Bean.ChapterWave_Waves.get_bgMusic()
0065CD32C  bl       #0x382bd14 ; 
0065CD330  mov      w8, #1
0065CD334  strb     w8, [x22, #0x656]
0065CD338  ldr      x1, [x23]
0065CD33C  ldrb     w8, [x1, #0x53]
0065CD340  tbnz     w8, #5, #0x65cd34c
0065CD344  ldr      w1, [x21, #0x68]
0065CD348  b        #0x65cd35c ; 
0065CD34C  ldr      x8, [x1, #0x60]
0065CD350  mov      x0, x21
0065CD354  blr      x8
0065CD358  mov      w1, w0
0065CD35C  cbz      x20, #0x65cd7c0
0065CD360  mov      x0, x20
0065CD364  mov      x2, xzr
0065CD368  bl       #0x6a076cc ; HotFix.BattleLogic.BattleWorldContext$$PlayMusic
0065CD36C  ldr      w8, [x19, #0xe0]
0065CD370  mov      x0, x19
0065CD374  cmp      w8, #9
0065CD378  b.ne     #0x65cd384
0065CD37C  bl       #0x65cd7c4 ; HotFix.BattleLogic.WaterfallBattleManager$$CreatePunchboardNpc
0065CD380  b        #0x65cd390 ; 
0065CD384  mov      x1, xzr
0065CD388  mov      x2, xzr
0065CD38C  bl       #0x6588698 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$CreateMissionNpc
0065CD390  ldr      w8, [x19, #0xe0]
0065CD394  cmp      w8, #0xa
0065CD398  b.ne     #0x65cd3ac
0065CD39C  mov      w1, #1
0065CD3A0  mov      x0, x19
0065CD3A4  mov      w2, wzr
0065CD3A8  bl       #0x65c0900 ; HotFix.BattleLogic.SinglePlayerBattleManager$$CreateHp
0065CD3AC  mov      x0, x19
0065CD3B0  bl       #0x65cd8ec ; HotFix.BattleLogic.WaterfallBattleManager$$RefreshRandomNpc
0065CD3B4  ldr      x20, [x19, #0x188]
0065CD3B8  cbz      x20, #0x65cd7c0
0065CD3BC  ldr      x8, [x20]
0065CD3C0  ldr      x1, [x26]
0065CD3C4  ldrh     w9, [x8, #0x12e]
0065CD3C8  cbz      x9, #0x65cd3ec
0065CD3CC  ldr      x10, [x8, #0xb0]
0065CD3D0  add      x10, x10, #8
0065CD3D4  ldur     x11, [x10, #-8]
0065CD3D8  cmp      x11, x1
0065CD3DC  b.eq     #0x65cd3fc
0065CD3E0  subs     x9, x9, #1
0065CD3E4  add      x10, x10, #0x10
0065CD3E8  b.ne     #0x65cd3d4
0065CD3EC  mov      w2, #0x1c
0065CD3F0  mov      x0, x20
0065CD3F4  bl       #0x3a7e710 ; 
0065CD3F8  b        #0x65cd40c ; 
0065CD3FC  ldr      w9, [x10]
0065CD400  add      w9, w9, #0x1c
0065CD404  add      x8, x8, w9, sxtw #4
0065CD408  add      x0, x8, #0x138
0065CD40C  ldp      x8, x1, [x0]
0065CD410  mov      x0, x20
0065CD414  blr      x8
0065CD418  ldr      x21, [x19, #0x188]
0065CD41C  cbz      x21, #0x65cd7c0
0065CD420  ldr      x8, [x21]
0065CD424  ldr      x1, [x26]
0065CD428  mov      x20, x0
0065CD42C  ldrh     w9, [x8, #0x12e]
0065CD430  cbz      x9, #0x65cd454
0065CD434  ldr      x10, [x8, #0xb0]
0065CD438  add      x10, x10, #8
0065CD43C  ldur     x11, [x10, #-8]
0065CD440  cmp      x11, x1
0065CD444  b.eq     #0x65cd464
0065CD448  subs     x9, x9, #1
0065CD44C  add      x10, x10, #0x10
0065CD450  b.ne     #0x65cd43c
0065CD454  mov      w2, #0x1e
0065CD458  mov      x0, x21
0065CD45C  bl       #0x3a7e710 ; 
0065CD460  b        #0x65cd474 ; 
0065CD464  ldr      w9, [x10]
0065CD468  add      w9, w9, #0x1e
0065CD46C  add      x8, x8, w9, sxtw #4
0065CD470  add      x0, x8, #0x138
0065CD474  ldp      x8, x1, [x0]
0065CD478  mov      x0, x21
0065CD47C  blr      x8
0065CD480  ldr      x22, [x19, #0x188]
0065CD484  cbz      x22, #0x65cd7c0
0065CD488  ldr      x8, [x22]
0065CD48C  ldr      x1, [x26]
0065CD490  mov      x21, x0
0065CD494  ldrh     w9, [x8, #0x12e]
0065CD498  cbz      x9, #0x65cd4bc
0065CD49C  ldr      x10, [x8, #0xb0]
0065CD4A0  add      x10, x10, #8
0065CD4A4  ldur     x11, [x10, #-8]
0065CD4A8  cmp      x11, x1
0065CD4AC  b.eq     #0x65cd4cc
0065CD4B0  subs     x9, x9, #1
0065CD4B4  add      x10, x10, #0x10
0065CD4B8  b.ne     #0x65cd4a4
0065CD4BC  mov      w2, #0x20
0065CD4C0  mov      x0, x22
0065CD4C4  bl       #0x3a7e710 ; 
0065CD4C8  b        #0x65cd4dc ; 
0065CD4CC  ldr      w9, [x10]
0065CD4D0  add      w9, w9, #0x20
0065CD4D4  add      x8, x8, w9, sxtw #4
0065CD4D8  add      x0, x8, #0x138
0065CD4DC  ldp      x8, x1, [x0]
0065CD4E0  mov      x0, x22
0065CD4E4  blr      x8
0065CD4E8  ldr      x23, [x19, #0x188]
0065CD4EC  cbz      x23, #0x65cd7c0
0065CD4F0  ldr      x8, [x23]
0065CD4F4  ldr      x1, [x26]
0065CD4F8  mov      x22, x0
0065CD4FC  ldrh     w9, [x8, #0x12e]
0065CD500  cbz      x9, #0x65cd524
0065CD504  ldr      x10, [x8, #0xb0]
0065CD508  add      x10, x10, #8
0065CD50C  ldur     x11, [x10, #-8]
0065CD510  cmp      x11, x1
0065CD514  b.eq     #0x65cd534
0065CD518  subs     x9, x9, #1
0065CD51C  add      x10, x10, #0x10
0065CD520  b.ne     #0x65cd50c
0065CD524  mov      w2, #0x22
0065CD528  mov      x0, x23
0065CD52C  bl       #0x3a7e710 ; 
0065CD530  b        #0x65cd544 ; 
0065CD534  ldr      w9, [x10]
0065CD538  add      w9, w9, #0x22
0065CD53C  add      x8, x8, w9, sxtw #4
0065CD540  add      x0, x8, #0x138
0065CD544  ldp      x8, x1, [x0]
0065CD548  mov      x0, x23
0065CD54C  blr      x8
0065CD550  mov      x4, x0
0065CD554  mov      x0, x19
0065CD558  mov      x1, x20
0065CD55C  mov      x2, x21
0065CD560  mov      x3, x22
0065CD564  mov      x5, xzr
0065CD568  bl       #0x65910f4 ; HotFix.BattleLogic.BattleManager$$AddExBattleAttr
0065CD56C  ldrb     w8, [x25, #0x286]
0065CD570  cbnz     w8, #0x65cd588
0065CD574  adrp     x0, #0x8f07000
0065CD578  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CD57C  bl       #0x382bd14 ; 
0065CD580  mov      w8, #1
0065CD584  strb     w8, [x25, #0x286]
0065CD588  ldr      x1, [x24]
0065CD58C  ldrb     w8, [x1, #0x53]
0065CD590  tbnz     w8, #5, #0x65cd59c
0065CD594  ldr      x20, [x19, #0x80]
0065CD598  b        #0x65cd5ac ; 
0065CD59C  ldr      x8, [x1, #0x60]
0065CD5A0  mov      x0, x19
0065CD5A4  blr      x8
0065CD5A8  mov      x20, x0
0065CD5AC  cbz      x20, #0x65cd7c0
0065CD5B0  adrp     x21, #0x9591000
0065CD5B4  ldrb     w8, [x21, #0xa9c]
0065CD5B8  cbnz     w8, #0x65cd5d0
0065CD5BC  adrp     x0, #0x8ee6000
0065CD5C0  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065CD5C4  bl       #0x382bd14 ; 
0065CD5C8  mov      w8, #1
0065CD5CC  strb     w8, [x21, #0xa9c]
0065CD5D0  adrp     x8, #0x8ee6000
0065CD5D4  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065CD5D8  ldr      x1, [x8]
0065CD5DC  ldrb     w8, [x1, #0x53]
0065CD5E0  tbnz     w8, #5, #0x65cd5ec
0065CD5E4  ldr      x20, [x20, #0x240]
0065CD5E8  b        #0x65cd5fc ; 
0065CD5EC  ldr      x8, [x1, #0x60]
0065CD5F0  mov      x0, x20
0065CD5F4  blr      x8
0065CD5F8  mov      x20, x0
0065CD5FC  cbz      x20, #0x65cd7c0
0065CD600  adrp     x21, #0x9599000
0065CD604  ldrb     w8, [x21, #0x26f]
0065CD608  cbnz     w8, #0x65cd620
0065CD60C  adrp     x0, #0x8f06000
0065CD610  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData()
0065CD614  bl       #0x382bd14 ; 
0065CD618  mov      w8, #1
0065CD61C  strb     w8, [x21, #0x26f]
0065CD620  adrp     x8, #0x8f06000
0065CD624  ldr      x8, [x8, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData()
0065CD628  ldr      x1, [x8]
0065CD62C  ldrb     w8, [x1, #0x53]
0065CD630  tbnz     w8, #5, #0x65cd63c
0065CD634  ldr      x20, [x20, #0x20]
0065CD638  b        #0x65cd64c ; 
0065CD63C  ldr      x8, [x1, #0x60]
0065CD640  mov      x0, x20
0065CD644  blr      x8
0065CD648  mov      x20, x0
0065CD64C  ldrb     w8, [x25, #0x286]
0065CD650  cbnz     w8, #0x65cd668
0065CD654  adrp     x0, #0x8f07000
0065CD658  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CD65C  bl       #0x382bd14 ; 
0065CD660  mov      w8, #1
0065CD664  strb     w8, [x25, #0x286]
0065CD668  ldr      x1, [x24]
0065CD66C  ldrb     w8, [x1, #0x53]
0065CD670  tbnz     w8, #5, #0x65cd67c
0065CD674  ldr      x21, [x19, #0x80]
0065CD678  b        #0x65cd68c ; 
0065CD67C  ldr      x8, [x1, #0x60]
0065CD680  mov      x0, x19
0065CD684  blr      x8
0065CD688  mov      x21, x0
0065CD68C  cbz      x21, #0x65cd7c0
0065CD690  adrp     x22, #0x9599000
0065CD694  ldrb     w8, [x22, #0x28d]
0065CD698  cbnz     w8, #0x65cd6b0
0065CD69C  adrp     x0, #0x8f07000
0065CD6A0  ldr      x0, [x0, #0xe98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurMissionIndex()
0065CD6A4  bl       #0x382bd14 ; 
0065CD6A8  mov      w8, #1
0065CD6AC  strb     w8, [x22, #0x28d]
0065CD6B0  adrp     x8, #0x8f07000
0065CD6B4  ldr      x8, [x8, #0xe98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_CurMissionIndex()
0065CD6B8  ldr      x1, [x8]
0065CD6BC  ldrb     w8, [x1, #0x53]
0065CD6C0  tbnz     w8, #5, #0x65cd700
0065CD6C4  adrp     x22, #0x9599000
0065CD6C8  ldrb     w8, [x22, #0x2ab]
0065CD6CC  cbnz     w8, #0x65cd6e4
0065CD6D0  adrp     x0, #0x8f07000
0065CD6D4  ldr      x0, [x0, #0xea0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.get_MissionIndex()
0065CD6D8  bl       #0x382bd14 ; 
0065CD6DC  mov      w8, #1
0065CD6E0  strb     w8, [x22, #0x2ab]
0065CD6E4  adrp     x8, #0x8f07000
0065CD6E8  ldr      x8, [x8, #0xea0] ; GLOBAL Method$HotFix.BattleLogic.BattleData.get_MissionIndex()
0065CD6EC  ldr      x1, [x8]
0065CD6F0  ldrb     w8, [x1, #0x53]
0065CD6F4  tbnz     w8, #5, #0x65cd70c
0065CD6F8  ldr      w1, [x21, #0x324]
0065CD6FC  b        #0x65cd71c ; 
0065CD700  ldr      x8, [x1, #0x60]
0065CD704  mov      x0, x21
0065CD708  b        #0x65cd714 ; 
0065CD70C  ldr      x8, [x1, #0x60]
0065CD710  add      x0, x21, #0x290
0065CD714  blr      x8
0065CD718  mov      w1, w0
0065CD71C  cbz      x20, #0x65cd7c0
0065CD720  mov      x0, x20
0065CD724  mov      x2, xzr
0065CD728  bl       #0x64c63c8 ; MissionData$$LoadPreCountMonsterData
0065CD72C  ldr      w8, [x19, #0xe0]
0065CD730  cmp      w8, #0xb
0065CD734  b.ne     #0x65cd754
0065CD738  mov      x0, x19
0065CD73C  ldp      x20, x19, [sp, #0x40]
0065CD740  ldp      x22, x21, [sp, #0x30]
0065CD744  ldp      x24, x23, [sp, #0x20]
0065CD748  ldp      x26, x25, [sp, #0x10]
0065CD74C  ldr      x30, [sp], #0x50
0065CD750  b        #0x65cdb00 ; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileNpc
0065CD754  ldrb     w8, [x25, #0x286]
0065CD758  cbnz     w8, #0x65cd770
0065CD75C  adrp     x0, #0x8f07000
0065CD760  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065CD764  bl       #0x382bd14 ; 
0065CD768  mov      w8, #1
0065CD76C  strb     w8, [x25, #0x286]
0065CD770  ldr      x1, [x24]
0065CD774  ldrb     w8, [x1, #0x53]
0065CD778  tbnz     w8, #5, #0x65cd784
0065CD77C  ldr      x0, [x19, #0x80]
0065CD780  b        #0x65cd790 ; 
0065CD784  ldr      x8, [x1, #0x60]
0065CD788  mov      x0, x19
0065CD78C  blr      x8
0065CD790  cbz      x0, #0x65cd7c0
0065CD794  ldrb     w8, [x0, #0x15]
0065CD798  cbz      w8, #0x65cd7a4
0065CD79C  mov      x0, x19
0065CD7A0  bl       #0x65ce0b0 ; HotFix.BattleLogic.WaterfallBattleManager$$CreateBeeMonsterCreator
0065CD7A4  mov      x0, x19
0065CD7A8  ldp      x20, x19, [sp, #0x40]
0065CD7AC  ldp      x22, x21, [sp, #0x30]
0065CD7B0  ldp      x24, x23, [sp, #0x20]
0065CD7B4  ldp      x26, x25, [sp, #0x10]
0065CD7B8  ldr      x30, [sp], #0x50
0065CD7BC  b        #0x65ce3f4 ; HotFix.BattleLogic.WaterfallBattleManager$$CreateIntervalMonster
0065CD7C0  bl       #0x382bfb8 ; 

