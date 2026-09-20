; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileNpc
; RVA 0x65CDB00; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CDB00  sub      sp, sp, #0xa0
0065CDB04  str      x30, [sp, #0x40]
0065CDB08  stp      x28, x27, [sp, #0x50]
0065CDB0C  stp      x26, x25, [sp, #0x60]
0065CDB10  stp      x24, x23, [sp, #0x70]
0065CDB14  stp      x22, x21, [sp, #0x80]
0065CDB18  stp      x20, x19, [sp, #0x90]
0065CDB1C  mrs      x23, tpidr_el0
0065CDB20  ldr      x8, [x23, #0x28]
0065CDB24  adrp     x20, #0x9599000
0065CDB28  adrp     x21, #0x8f0a000
0065CDB2C  mov      x19, x0
0065CDB30  str      x8, [sp, #0x38]
0065CDB34  ldrb     w8, [x20, #0x586]
0065CDB38  ldr      x21, [x21, #0x8b0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreateTileNpc() @ 0x92c80b0
0065CDB3C  tbnz     w8, #0, #0x65cdb9c
0065CDB40  adrp     x0, #0x8f09000
0065CDB44  ldr      x0, [x0, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo @ 0x91ea930
0065CDB48  bl       #0x382bd14 ; 
0065CDB4C  adrp     x0, #0x8ee1000
0065CDB50  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
0065CDB54  bl       #0x382bd14 ; 
0065CDB58  adrp     x0, #0x8f05000
0065CDB5C  ldr      x0, [x0, #0xa78] ; GLOBAL HotFix.BattleLogic.MapManager_TypeInfo @ 0x91ebf60
0065CDB60  bl       #0x382bd14 ; 
0065CDB64  adrp     x0, #0x8f0a000
0065CDB68  ldr      x0, [x0, #0x8b0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreateTileNpc() @ 0x92c80b0
0065CDB6C  bl       #0x382bd14 ; 
0065CDB70  adrp     x0, #0x8f0a000
0065CDB74  ldr      x0, [x0, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs @ 0x92f7e18
0065CDB78  bl       #0x382bd14 ; 
0065CDB7C  adrp     x0, #0x8f0a000
0065CDB80  ldr      x0, [x0, #0x8c0] ; GLOBAL CreateTileNpc @ 0x92f7790
0065CDB84  bl       #0x382bd14 ; 
0065CDB88  adrp     x0, #0x8f0a000
0065CDB8C  ldr      x0, [x0, #0x8c8] ; GLOBAL 刷怪配置不存在 @ 0x932cda8
0065CDB90  bl       #0x382bd14 ; 
0065CDB94  mov      w8, #1
0065CDB98  strb     w8, [x20, #0x586]
0065CDB9C  ldr      x1, [x21]
0065CDBA0  ldrb     w8, [x1, #0x53]
0065CDBA4  tbnz     w8, #5, #0x65cdbec
0065CDBA8  adrp     x22, #0x9599000
0065CDBAC  ldrb     w8, [x22, #0x286]
0065CDBB0  stp      xzr, xzr, [sp, #0x20]
0065CDBB4  str      xzr, [sp, #0x30]
0065CDBB8  cbnz     w8, #0x65cdbd0
0065CDBBC  adrp     x0, #0x8f07000
0065CDBC0  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065CDBC4  bl       #0x382bd14 ; 
0065CDBC8  mov      w8, #1
0065CDBCC  strb     w8, [x22, #0x286]
0065CDBD0  adrp     x28, #0x8f07000
0065CDBD4  ldr      x28, [x28, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065CDBD8  ldr      x1, [x28]
0065CDBDC  ldrb     w8, [x1, #0x53]
0065CDBE0  tbnz     w8, #5, #0x65cdbfc
0065CDBE4  ldr      x20, [x19, #0x80]
0065CDBE8  b        #0x65cdc0c ; 
0065CDBEC  ldr      x8, [x1, #0x60]
0065CDBF0  mov      x0, x19
0065CDBF4  blr      x8
0065CDBF8  b        #0x65ce074 ; 
0065CDBFC  ldr      x8, [x1, #0x60]
0065CDC00  mov      x0, x19
0065CDC04  blr      x8
0065CDC08  mov      x20, x0
0065CDC0C  cbz      x20, #0x65ce0a8
0065CDC10  adrp     x21, #0x9591000
0065CDC14  ldrb     w8, [x21, #0xa9c]
0065CDC18  cbnz     w8, #0x65cdc30
0065CDC1C  adrp     x0, #0x8ee6000
0065CDC20  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr() @ 0x923ff20
0065CDC24  bl       #0x382bd14 ; 
0065CDC28  mov      w8, #1
0065CDC2C  strb     w8, [x21, #0xa9c]
0065CDC30  adrp     x8, #0x8ee6000
0065CDC34  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr() @ 0x923ff20
0065CDC38  ldr      x1, [x8]
0065CDC3C  ldrb     w8, [x1, #0x53]
0065CDC40  tbnz     w8, #5, #0x65cdc4c
0065CDC44  ldr      x20, [x20, #0x240]
0065CDC48  b        #0x65cdc5c ; 
0065CDC4C  ldr      x8, [x1, #0x60]
0065CDC50  mov      x0, x20
0065CDC54  blr      x8
0065CDC58  mov      x20, x0
0065CDC5C  cbz      x20, #0x65ce0a8
0065CDC60  adrp     x26, #0x9599000
0065CDC64  ldrb     w8, [x26, #0x26f]
0065CDC68  cbnz     w8, #0x65cdc80
0065CDC6C  adrp     x0, #0x8f06000
0065CDC70  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData() @ 0x928e768
0065CDC74  bl       #0x382bd14 ; 
0065CDC78  mov      w8, #1
0065CDC7C  strb     w8, [x26, #0x26f]
0065CDC80  adrp     x27, #0x8f06000
0065CDC84  ldr      x27, [x27, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData() @ 0x928e768
0065CDC88  ldr      x1, [x27]
0065CDC8C  ldrb     w8, [x1, #0x53]
0065CDC90  tbnz     w8, #5, #0x65cdc9c
0065CDC94  ldr      x0, [x20, #0x20]
0065CDC98  b        #0x65cdca8 ; 
0065CDC9C  ldr      x8, [x1, #0x60]
0065CDCA0  mov      x0, x20
0065CDCA4  blr      x8
0065CDCA8  cbz      x0, #0x65ce0a8
0065CDCAC  ldr      x24, [x0, #0x158]
0065CDCB0  cbz      x24, #0x65ce074
0065CDCB4  ldr      x21, [x19, #0x188]
0065CDCB8  cbz      x21, #0x65ce0a8
0065CDCBC  adrp     x25, #0x8f09000
0065CDCC0  ldr      x8, [x21]
0065CDCC4  ldr      x25, [x25, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo @ 0x91ea930
0065CDCC8  ldrh     w9, [x8, #0x12e]
0065CDCCC  ldr      x1, [x25]
0065CDCD0  cbz      x9, #0x65cdcf4
0065CDCD4  ldr      x10, [x8, #0xb0]
0065CDCD8  add      x10, x10, #8
0065CDCDC  ldur     x11, [x10, #-8]
0065CDCE0  cmp      x11, x1
0065CDCE4  b.eq     #0x65cdd04
0065CDCE8  subs     x9, x9, #1
0065CDCEC  add      x10, x10, #0x10
0065CDCF0  b.ne     #0x65cdcdc
0065CDCF4  mov      w2, #0xe
0065CDCF8  mov      x0, x21
0065CDCFC  bl       #0x3a7e710 ; 
0065CDD00  b        #0x65cdd14 ; 
0065CDD04  ldr      w9, [x10]
0065CDD08  add      w9, w9, #0xe
0065CDD0C  add      x8, x8, w9, sxtw #4
0065CDD10  add      x0, x8, #0x138
0065CDD14  ldp      x8, x1, [x0]
0065CDD18  mov      x0, x21
0065CDD1C  blr      x8
0065CDD20  cmp      w0, #1
0065CDD24  b.lt     #0x65cdf20
0065CDD28  ldrb     w8, [x22, #0x286]
0065CDD2C  mov      w21, w0
0065CDD30  cbnz     w8, #0x65cdd48
0065CDD34  adrp     x0, #0x8f07000
0065CDD38  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065CDD3C  bl       #0x382bd14 ; 
0065CDD40  mov      w8, #1
0065CDD44  strb     w8, [x22, #0x286]
0065CDD48  ldr      x1, [x28]
0065CDD4C  ldrb     w8, [x1, #0x53]
0065CDD50  tbnz     w8, #5, #0x65cdd5c
0065CDD54  ldr      x22, [x19, #0x80]
0065CDD58  b        #0x65cdd6c ; 
0065CDD5C  ldr      x8, [x1, #0x60]
0065CDD60  mov      x0, x19
0065CDD64  blr      x8
0065CDD68  mov      x22, x0
0065CDD6C  cbz      x22, #0x65ce0a8
0065CDD70  adrp     x28, #0x9598000
0065CDD74  ldrb     w8, [x28, #0xfcc]
0065CDD78  cbnz     w8, #0x65cdd90
0065CDD7C  adrp     x0, #0x8f06000
0065CDD80  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0065CDD84  bl       #0x382bd14 ; 
0065CDD88  mov      w8, #1
0065CDD8C  strb     w8, [x28, #0xfcc]
0065CDD90  adrp     x8, #0x8f06000
0065CDD94  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0065CDD98  ldr      x1, [x8]
0065CDD9C  ldrb     w8, [x1, #0x53]
0065CDDA0  tbnz     w8, #5, #0x65cddac
0065CDDA4  ldr      x0, [x22, #0x200]
0065CDDA8  b        #0x65cddb8 ; 
0065CDDAC  ldr      x8, [x1, #0x60]
0065CDDB0  mov      x0, x22
0065CDDB4  blr      x8
0065CDDB8  cbz      x0, #0x65ce0a8
0065CDDBC  mov      w1, w21
0065CDDC0  mov      x2, xzr
0065CDDC4  bl       #0x64d3fa0 ; LocalModels.LocalModelManager$$GetMission_PositionMonsterFlushConfig
0065CDDC8  cbz      x0, #0x65cde0c
0065CDDCC  adrp     x22, #0x9599000
0065CDDD0  ldrb     w8, [x22, #0x657]
0065CDDD4  mov      x21, x0
0065CDDD8  cbnz     w8, #0x65cddf0
0065CDDDC  adrp     x0, #0x8f0a000
0065CDDE0  ldr      x0, [x0, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool() @ 0x9291360
0065CDDE4  bl       #0x382bd14 ; 
0065CDDE8  mov      w8, #1
0065CDDEC  strb     w8, [x22, #0x657]
0065CDDF0  adrp     x28, #0x8f0a000
0065CDDF4  ldr      x28, [x28, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool() @ 0x9291360
0065CDDF8  ldr      x1, [x28]
0065CDDFC  ldrb     w8, [x1, #0x53]
0065CDE00  tbnz     w8, #5, #0x65cde58
0065CDE04  ldr      x0, [x21, #0x28]
0065CDE08  b        #0x65cde64 ; 
0065CDE0C  adrp     x8, #0x8ee1000
0065CDE10  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
0065CDE14  ldr      x0, [x8]
0065CDE18  ldr      w8, [x0, #0xe0]
0065CDE1C  cbnz     w8, #0x65cde24
0065CDE20  bl       #0x382be8c ; 
0065CDE24  adrp     x8, #0x8f0a000
0065CDE28  adrp     x9, #0x8f0a000
0065CDE2C  adrp     x10, #0x8f0a000
0065CDE30  ldr      x8, [x8, #0x8c8] ; GLOBAL 刷怪配置不存在 @ 0x932cda8
0065CDE34  ldr      x9, [x9, #0x8c0] ; GLOBAL CreateTileNpc @ 0x92f7790
0065CDE38  ldr      x10, [x10, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs @ 0x92f7e18
0065CDE3C  mov      w3, #0x34a
0065CDE40  ldr      x0, [x8]
0065CDE44  ldr      x1, [x9]
0065CDE48  ldr      x2, [x10]
0065CDE4C  mov      x4, xzr
0065CDE50  bl       #0x7997754 ; Logger$$LogError
0065CDE54  b        #0x65ce074 ; 
0065CDE58  ldr      x8, [x1, #0x60]
0065CDE5C  mov      x0, x21
0065CDE60  blr      x8
0065CDE64  cbz      x0, #0x65ce0a8
0065CDE68  ldr      w8, [x0, #0x18]
0065CDE6C  cmp      w8, #2
0065CDE70  b.lt     #0x65cdf20
0065CDE74  ldrb     w8, [x22, #0x657]
0065CDE78  cbnz     w8, #0x65cde90
0065CDE7C  adrp     x0, #0x8f0a000
0065CDE80  ldr      x0, [x0, #0x8d0] ; GLOBAL Method$LocalModels.Bean.Mission_PositionMonsterFlushConfig.get_missionPool() @ 0x9291360
0065CDE84  bl       #0x382bd14 ; 
0065CDE88  mov      w8, #1
0065CDE8C  strb     w8, [x22, #0x657]
0065CDE90  ldr      x1, [x28]
0065CDE94  ldrb     w8, [x1, #0x53]
0065CDE98  tbnz     w8, #5, #0x65cdea4
0065CDE9C  ldr      x1, [x21, #0x28]
0065CDEA0  b        #0x65cdeb4 ; 
0065CDEA4  ldr      x8, [x1, #0x60]
0065CDEA8  mov      x0, x21
0065CDEAC  blr      x8
0065CDEB0  mov      x1, x0
0065CDEB4  mov      x0, x20
0065CDEB8  mov      x2, xzr
0065CDEBC  bl       #0x6903320 ; HotFix.BattleLogic.MapManager$$WaterfallRandomMap
0065CDEC0  ldrb     w8, [x26, #0x26f]
0065CDEC4  mov      w21, w0
0065CDEC8  cbnz     w8, #0x65cdee0
0065CDECC  adrp     x0, #0x8f06000
0065CDED0  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.MapManager.get_MissionData() @ 0x928e768
0065CDED4  bl       #0x382bd14 ; 
0065CDED8  mov      w8, #1
0065CDEDC  strb     w8, [x26, #0x26f]
0065CDEE0  ldr      x1, [x27]
0065CDEE4  ldrb     w8, [x1, #0x53]
0065CDEE8  tbnz     w8, #5, #0x65cdef4
0065CDEEC  ldr      x0, [x20, #0x20]
0065CDEF0  b        #0x65cdf00 ; 
0065CDEF4  ldr      x8, [x1, #0x60]
0065CDEF8  mov      x0, x20
0065CDEFC  blr      x8
0065CDF00  cbz      x0, #0x65ce0a8
0065CDF04  ldr      x8, [x0, #0x140]
0065CDF08  cbz      x8, #0x65ce0a8
0065CDF0C  ldr      w9, [x8, #0x18]
0065CDF10  cmp      w21, w9
0065CDF14  b.hs     #0x65ce0a4
0065CDF18  add      x8, x8, w21, sxtw #4
0065CDF1C  ldr      x24, [x8, #0x28]
0065CDF20  cbz      x24, #0x65ce0a8
0065CDF24  ldr      x22, [x24, #0x18]
0065CDF28  cmp      w22, #1
0065CDF2C  and      x21, x22, #0xffffffff
0065CDF30  b.lt     #0x65cdf98
0065CDF34  ldr      x8, [x24, #0x38]
0065CDF38  b.eq     #0x65cdf58
0065CDF3C  add      x9, x24, #0x70
0065CDF40  sub      x10, x21, #1
0065CDF44  ldr      x11, [x9], #0x38
0065CDF48  cmp      x11, x8
0065CDF4C  csel     x8, x11, x8, lt
0065CDF50  subs     x10, x10, #1
0065CDF54  b.ne     #0x65cdf44
0065CDF58  ldr      x9, [x20, #0x10]
0065CDF5C  cbz      x9, #0x65ce0a8
0065CDF60  adrp     x26, #0x8f05000
0065CDF64  ldr      x26, [x26, #0xa78] ; GLOBAL HotFix.BattleLogic.MapManager_TypeInfo @ 0x91ebf60
0065CDF68  ldr      x9, [x9, #0x20]
0065CDF6C  ldr      x0, [x26]
0065CDF70  subs     x8, x8, x9
0065CDF74  cneg     x20, x8, mi
0065CDF78  ldr      w10, [x0, #0xe0]
0065CDF7C  cbnz     w10, #0x65cdf88
0065CDF80  bl       #0x382be8c ; 
0065CDF84  ldr      x0, [x26]
0065CDF88  ldr      x8, [x0, #0xb8]
0065CDF8C  ldr      x8, [x8, #0x10]
0065CDF90  add      x26, x8, x20
0065CDF94  b        #0x65cdf9c ; 
0065CDF98  mov      x26, xzr
0065CDF9C  ldr      x20, [x19, #0x188]
0065CDFA0  cbz      x20, #0x65ce0a8
0065CDFA4  ldr      x8, [x20]
0065CDFA8  ldr      x1, [x25]
0065CDFAC  ldrh     w9, [x8, #0x12e]
0065CDFB0  cbz      x9, #0x65cdfd4
0065CDFB4  ldr      x10, [x8, #0xb0]
0065CDFB8  add      x10, x10, #8
0065CDFBC  ldur     x11, [x10, #-8]
0065CDFC0  cmp      x11, x1
0065CDFC4  b.eq     #0x65cdfe4
0065CDFC8  subs     x9, x9, #1
0065CDFCC  add      x10, x10, #0x10
0065CDFD0  b.ne     #0x65cdfbc
0065CDFD4  mov      w2, #0x10
0065CDFD8  mov      x0, x20
0065CDFDC  bl       #0x3a7e710 ; 
0065CDFE0  b        #0x65cdff4 ; 
0065CDFE4  ldr      w9, [x10]
0065CDFE8  add      w9, w9, #0x10
0065CDFEC  add      x8, x8, w9, sxtw #4
0065CDFF0  add      x0, x8, #0x138
0065CDFF4  ldp      x8, x1, [x0]
0065CDFF8  mov      x0, x20
0065CDFFC  blr      x8
0065CE000  cbz      x0, #0x65ce0a8
0065CE004  ldr      w8, [x0, #0x18]
0065CE008  cbz      w8, #0x65ce0a4
0065CE00C  cmp      w22, #1
0065CE010  b.lt     #0x65ce074
0065CE014  ldr      w20, [x0, #0x20]
0065CE018  mov      x22, xzr
0065CE01C  add      x25, x24, #0x38
0065CE020  ldr      w8, [x24, #0x18]
0065CE024  cmp      x22, x8
0065CE028  b.hs     #0x65ce0a4
0065CE02C  ldp      x2, x8, [x25, #-8]
0065CE030  ldur     x1, [x25, #-0x10]
0065CE034  add      x0, sp, #0x20
0065CE038  mov      x4, xzr
0065CE03C  add      x3, x8, x26
0065CE040  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065CE044  ldr      q0, [sp, #0x20]
0065CE048  ldr      x8, [sp, #0x30]
0065CE04C  mov      x2, sp
0065CE050  mov      x0, x19
0065CE054  mov      w1, w20
0065CE058  str      q0, [sp]
0065CE05C  str      x8, [sp, #0x10]
0065CE060  bl       #0x65c0c04 ; HotFix.BattleLogic.SinglePlayerBattleManager$$CreateDropNpc
0065CE064  add      x22, x22, #1
0065CE068  cmp      x21, x22
0065CE06C  add      x25, x25, #0x38
0065CE070  b.ne     #0x65ce020
0065CE074  ldr      x8, [x23, #0x28]
0065CE078  ldr      x9, [sp, #0x38]
0065CE07C  cmp      x8, x9
0065CE080  b.ne     #0x65ce0ac
0065CE084  ldp      x20, x19, [sp, #0x90]
0065CE088  ldp      x22, x21, [sp, #0x80]
0065CE08C  ldp      x24, x23, [sp, #0x70]
0065CE090  ldp      x26, x25, [sp, #0x60]
0065CE094  ldp      x28, x27, [sp, #0x50]
0065CE098  ldr      x30, [sp, #0x40]
0065CE09C  add      sp, sp, #0xa0
0065CE0A0  ret      
0065CE0A4  bl       #0x382bfc0 ; 
0065CE0A8  bl       #0x382bfb8 ; 
0065CE0AC  bl       #0x89edb60 ; 

