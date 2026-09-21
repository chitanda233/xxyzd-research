; HotFix.BattleLogic.WaterfallBattleManager$$RandomPos
0065D0668  ldr      x9, [sp, #0x68]
0065D066C  ldr      x8, [sp, #0x78]
0065D0670  mov      x26, xzr
0065D0674  stp      x8, x9, [sp, #0x30]
0065D0678  adrp     x20, #0x9599000
0065D067C  adrp     x21, #0x8f0a000
0065D0680  ldrb     w8, [x20, #0x65e]
0065D0684  ldr      x21, [x21, #0x988] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_entityId() @ 0x9291458
0065D0688  cbnz     w8, #0x65d069c
0065D068C  mov      x0, x21
0065D0690  bl       #0x382bd14 ; 
0065D0694  mov      w8, #1
0065D0698  strb     w8, [x20, #0x65e]
0065D069C  ldr      x1, [x21]
0065D06A0  ldrb     w8, [x1, #0x53]
0065D06A4  tbnz     w8, #5, #0x65d06b0
0065D06A8  ldr      x0, [x23, #0x28]
0065D06AC  b        #0x65d06bc ; 
0065D06B0  ldr      x8, [x1, #0x60]
0065D06B4  mov      x0, x23
0065D06B8  blr      x8
0065D06BC  cbz      x0, #0x65d0b4c
0065D06C0  ldrsw    x8, [x0, #0x18]
0065D06C4  cmp      x26, x8
0065D06C8  b.ge     #0x65d0ab0
0065D06CC  ldrb     w8, [x20, #0x65e]
0065D06D0  cbnz     w8, #0x65d06e4
0065D06D4  mov      x0, x21
0065D06D8  bl       #0x382bd14 ; 
0065D06DC  mov      w8, #1
0065D06E0  strb     w8, [x20, #0x65e]
0065D06E4  ldr      x1, [x21]
0065D06E8  ldrb     w8, [x1, #0x53]
0065D06EC  tbnz     w8, #5, #0x65d06f8
0065D06F0  ldr      x0, [x23, #0x28]
0065D06F4  b        #0x65d0704 ; 
0065D06F8  ldr      x8, [x1, #0x60]
0065D06FC  mov      x0, x23
0065D0700  blr      x8
0065D0704  cbz      x0, #0x65d0b4c
0065D0708  ldr      w8, [x0, #0x18]
0065D070C  cmp      x26, x8
0065D0710  b.hs     #0x65d0b50
0065D0714  ldr      x29, [x19, #0xa0]
0065D0718  cbz      x29, #0x65d0b4c
0065D071C  ldr      w8, [x19, #0xa8]
0065D0720  ldr      w9, [x29, #0x18]
0065D0724  mov      w21, w28
0065D0728  mov      x10, x19
0065D072C  add      w28, w8, w22
0065D0730  cmp      w28, w9
0065D0734  b.hs     #0x65d0b50
0065D0738  ldr      x24, [x10, #0x188]
0065D073C  cbz      x24, #0x65d0b4c
0065D0740  ldr      x8, [x24]
0065D0744  add      x9, x0, x26, lsl #2
0065D0748  adrp     x10, #0x8f09000
0065D074C  ldr      w20, [x9, #0x20]
0065D0750  ldrh     w9, [x8, #0x12e]
0065D0754  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo @ 0x91ea930
0065D0758  ldr      x1, [x10]
0065D075C  cbz      x9, #0x65d0780
0065D0760  ldr      x10, [x8, #0xb0]
0065D0764  add      x10, x10, #8
0065D0768  ldur     x11, [x10, #-8]
0065D076C  cmp      x11, x1
0065D0770  b.eq     #0x65d0790
0065D0774  subs     x9, x9, #1
0065D0778  add      x10, x10, #0x10
0065D077C  b.ne     #0x65d0768
0065D0780  mov      w2, #6
0065D0784  mov      x0, x24
0065D0788  bl       #0x3a7e710 ; 
0065D078C  b        #0x65d07a0 ; 
0065D0790  ldr      w9, [x10]
0065D0794  add      w9, w9, #6
0065D0798  add      x8, x8, w9, sxtw #4
0065D079C  add      x0, x8, #0x138
0065D07A0  ldp      x8, x1, [x0]
0065D07A4  mov      x0, x24
0065D07A8  sxtw     x28, w28
0065D07AC  blr      x8
0065D07B0  ldr      x8, [sp, #0x40]
0065D07B4  add      x24, x29, x28, lsl #7
0065D07B8  adrp     x9, #0x8ee8000
0065D07BC  add      x8, x0, x8
0065D07C0  str      x8, [x24, #0x20]
0065D07C4  ldr      x9, [x9, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
0065D07C8  ldr      x0, [x9]
0065D07CC  ldr      w8, [x0, #0xe0]
0065D07D0  cbnz     w8, #0x65d07e0
0065D07D4  mov      x25, x9
0065D07D8  bl       #0x382be8c ; 
0065D07DC  ldr      x0, [x25]
0065D07E0  ldr      x8, [x0, #0xb8]
0065D07E4  ldr      x8, [x8, #0xb0]
0065D07E8  str      x8, [x24, #0x28]
0065D07EC  adrp     x8, #0x9599000
0065D07F0  ldrb     w8, [x8, #0x660]
0065D07F4  cbnz     w8, #0x65d0810
0065D07F8  adrp     x0, #0x8f0a000
0065D07FC  ldr      x0, [x0, #0x990] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_weight() @ 0x9291470
0065D0800  bl       #0x382bd14 ; 
0065D0804  mov      w8, #1
0065D0808  adrp     x9, #0x9599000
0065D080C  strb     w8, [x9, #0x660]
0065D0810  adrp     x8, #0x8f0a000
0065D0814  ldr      x8, [x8, #0x990] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_weight() @ 0x9291470
0065D0818  ldr      x1, [x8]
0065D081C  ldrb     w8, [x1, #0x53]
0065D0820  tbnz     w8, #5, #0x65d082c
0065D0824  ldr      x0, [x23, #0x38]
0065D0828  b        #0x65d0838 ; 
0065D082C  ldr      x8, [x1, #0x60]
0065D0830  mov      x0, x23
0065D0834  blr      x8
0065D0838  ldr      x8, [sp, #0x48]
0065D083C  ldr      x8, [x8, #0x10]
0065D0840  cbz      x8, #0x65d0b4c
0065D0844  ldr      x8, [x8, #0x18]
0065D0848  ldr      x10, [sp, #0x38]
0065D084C  adrp     x9, #0x9599000
0065D0850  ldrb     w9, [x9, #0x661]
0065D0854  sub      x8, x8, #0x10, lsl #12
0065D0858  madd     x10, x0, x26, x10
0065D085C  cmp      x10, x8
0065D0860  csel     x24, x8, x10, gt
0065D0864  cbnz     w9, #0x65d0880
0065D0868  adrp     x0, #0x8f0a000
0065D086C  ldr      x0, [x0, #0x998] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_height() @ 0x9291460
0065D0870  bl       #0x382bd14 ; 
0065D0874  mov      w8, #1
0065D0878  adrp     x9, #0x9599000
0065D087C  strb     w8, [x9, #0x661]
0065D0880  adrp     x8, #0x8f0a000
0065D0884  ldr      x8, [x8, #0x998] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_height() @ 0x9291460
0065D0888  ldr      x1, [x8]
0065D088C  ldrb     w8, [x1, #0x53]
0065D0890  tbnz     w8, #5, #0x65d089c
0065D0894  ldr      x0, [x23, #0x30]
0065D0898  b        #0x65d08a8 ; 
0065D089C  ldr      x8, [x1, #0x60]
0065D08A0  mov      x0, x23
0065D08A4  blr      x8
0065D08A8  ldr      x8, [sp, #0x30]
0065D08AC  mov      x1, x24
0065D08B0  mov      x2, xzr
0065D08B4  mov      x4, xzr
0065D08B8  madd     x3, x0, x26, x8
0065D08BC  add      x0, sp, #0x80
0065D08C0  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
0065D08C4  ldr      w8, [x19, #0xa8]
0065D08C8  ldr      q0, [sp, #0x80]
0065D08CC  ldr      x9, [sp, #0x90]
0065D08D0  mov      x0, x19
0065D08D4  add      w24, w8, w22
0065D08D8  add      x2, sp, #0x50
0065D08DC  mov      w1, w24
0065D08E0  str      q0, [sp, #0x50]
0065D08E4  str      x9, [sp, #0x60]
0065D08E8  bl       #0x65d3c88 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckPosValid
0065D08EC  tbnz     w0, #0, #0x65d091c
0065D08F0  ldr      x1, [sp, #0x18]
0065D08F4  ldr      w2, [sp, #0x24]
0065D08F8  ldr      x3, [sp, #0x48]
0065D08FC  add      x8, sp, #0x68
0065D0900  mov      x0, x19
0065D0904  mov      w4, w24
0065D0908  bl       #0x65d3a78 ; HotFix.BattleLogic.WaterfallBattleManager$$RandomPos
0065D090C  ldur     q0, [sp, #0x68]
0065D0910  ldr      x8, [sp, #0x78]
0065D0914  str      q0, [sp, #0x80]
0065D0918  str      x8, [sp, #0x90]
0065D091C  adrp     x8, #0x9599000
0065D0920  adrp     x24, #0x8f07000
0065D0924  ldrb     w8, [x8, #0x286]
0065D0928  ldr      x24, [x24, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065D092C  cbnz     w8, #0x65d0944
0065D0930  mov      x0, x24
0065D0934  bl       #0x382bd14 ; 
0065D0938  adrp     x8, #0x9599000
0065D093C  mov      w9, #1
0065D0940  strb     w9, [x8, #0x286]
0065D0944  ldr      x1, [x24]
0065D0948  ldrb     w8, [x1, #0x53]
0065D094C  tbnz     w8, #5, #0x65d0958
0065D0950  ldr      x24, [x19, #0x80]
0065D0954  b        #0x65d0968 ; 
0065D0958  ldr      x8, [x1, #0x60]
0065D095C  mov      x0, x19
0065D0960  blr      x8
0065D0964  mov      x24, x0
0065D0968  cbz      x24, #0x65d0b4c
0065D096C  adrp     x8, #0x9598000
0065D0970  ldrb     w8, [x8, #0xfcc]
0065D0974  cbnz     w8, #0x65d0990
0065D0978  adrp     x0, #0x8f06000
0065D097C  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0065D0980  bl       #0x382bd14 ; 
0065D0984  mov      w8, #1
0065D0988  adrp     x9, #0x9598000
0065D098C  strb     w8, [x9, #0xfcc]
0065D0990  adrp     x8, #0x8f06000
0065D0994  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0065D0998  ldr      x1, [x8]
0065D099C  ldrb     w8, [x1, #0x53]
0065D09A0  tbnz     w8, #5, #0x65d09ac
0065D09A4  ldr      x0, [x24, #0x200]
0065D09A8  b        #0x65d09b8 ; 
0065D09AC  ldr      x8, [x1, #0x60]
0065D09B0  mov      x0, x24
0065D09B4  blr      x8
0065D09B8  cbz      x0, #0x65d0b4c
0065D09BC  mov      w1, w20
0065D09C0  mov      x2, xzr
0065D09C4  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
0065D09C8  ldr      q0, [sp, #0x80]
0065D09CC  add      x8, x29, x28, lsl #7
0065D09D0  ldr      x9, [sp, #0x90]
0065D09D4  mov      w10, #1
0065D09D8  str      q0, [x8, #0x30]
0065D09DC  ldr      q0, [x8, #0x30]
0065D09E0  str      w20, [x8, #0x60]
0065D09E4  str      xzr, [x8, #0x68]
0065D09E8  str      x9, [x8, #0x40]
0065D09EC  str      xzr, [x8, #0x78]
0065D09F0  str      w10, [x8, #0x80]
0065D09F4  str      x9, [x8, #0x58]
0065D09F8  stur     q0, [x8, #0x48]
0065D09FC  stp      xzr, xzr, [x8, #0x88]
0065D0A00  ldr      x24, [x19, #0x188]
0065D0A04  cbz      x24, #0x65d0b4c
0065D0A08  ldr      x8, [x24]
0065D0A0C  adrp     x10, #0x8f09000
0065D0A10  mov      x20, x0
0065D0A14  ldrh     w9, [x8, #0x12e]
0065D0A18  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo @ 0x91ea930
0065D0A1C  ldr      x1, [x10]
0065D0A20  cbz      x9, #0x65d0a44
0065D0A24  ldr      x10, [x8, #0xb0]
0065D0A28  add      x10, x10, #8
0065D0A2C  ldur     x11, [x10, #-8]
0065D0A30  cmp      x11, x1
0065D0A34  b.eq     #0x65d0a54
0065D0A38  subs     x9, x9, #1
0065D0A3C  add      x10, x10, #0x10
0065D0A40  b.ne     #0x65d0a2c
0065D0A44  mov      x0, x24
0065D0A48  mov      w2, wzr
0065D0A4C  bl       #0x3a7e710 ; 
0065D0A50  b        #0x65d0a60 ; 
0065D0A54  ldrsw    x9, [x10]
0065D0A58  add      x8, x8, x9, lsl #4
0065D0A5C  add      x0, x8, #0x138
0065D0A60  ldp      x8, x1, [x0]
0065D0A64  mov      x0, x24
0065D0A68  blr      x8
0065D0A6C  add      x24, x29, x28, lsl #7
0065D0A70  str      w0, [x24, #0x98]
0065D0A74  mov      x0, x19
0065D0A78  mov      x1, x20
0065D0A7C  bl       #0x65d0b58 ; HotFix.BattleLogic.WaterfallBattleManager$$AddGoldMonster
0065D0A80  and      w8, w0, #1
0065D0A84  strb     w8, [x24, #0x9c]
0065D0A88  adrp     x24, #0x8f07000
0065D0A8C  adrp     x25, #0x8ec2000
0065D0A90  ldr      x24, [x24, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065D0A94  ldr      x29, [sp, #0x28]
0065D0A98  ldr      x25, [x25, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
0065D0A9C  add      w22, w22, #1
0065D0AA0  mov      w28, w21
0065D0AA4  cmp      w21, w22
0065D0AA8  add      x26, x26, #1
0065D0AAC  b.gt     #0x65d0678
0065D0AB0  cmp      w28, w22
0065D0AB4  adrp     x26, #0x9599000
0065D0AB8  mov      x21, x19
0065D0ABC  b.gt     #0x65d04c4
0065D0AC0  ldr      w8, [x21, #0xa8]
0065D0AC4  add      w8, w8, w28
0065D0AC8  str      w8, [x21, #0xa8]
0065D0ACC  b        #0x65d0b18 ; 
0065D0AD0  adrp     x8, #0x8ee1000
0065D0AD4  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
0065D0AD8  ldr      x0, [x8]
0065D0ADC  ldr      w8, [x0, #0xe0]
0065D0AE0  cbnz     w8, #0x65d0ae8
0065D0AE4  bl       #0x382be8c ; 
0065D0AE8  adrp     x8, #0x8f0a000
0065D0AEC  adrp     x9, #0x8f0a000
0065D0AF0  adrp     x10, #0x8f0a000
0065D0AF4  ldr      x8, [x8, #0x980] ; GLOBAL 刷怪配置错误，刷怪配置的entityId为空 @ 0x932cdb8
0065D0AF8  ldr      x9, [x9, #0x978] ; GLOBAL CreateRandomMonster @ 0x92f7710
0065D0AFC  ldr      x10, [x10, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs @ 0x92f7e18
0065D0B00  mov      w3, #0x5ac
0065D0B04  ldr      x0, [x8]
0065D0B08  ldr      x1, [x9]
0065D0B0C  ldr      x2, [x10]
0065D0B10  mov      x4, xzr
0065D0B14  bl       #0x7997754 ; Logger$$LogError
0065D0B18  ldr      x22, [sp, #8]
0065D0B1C  ldr      x8, [x22, #0x28]
0065D0B20  ldr      x9, [sp, #0x98]
0065D0B24  cmp      x8, x9
0065D0B28  b.ne     #0x65d0b54
0065D0B2C  ldp      x20, x19, [sp, #0xf0]
0065D0B30  ldp      x22, x21, [sp, #0xe0]
0065D0B34  ldp      x24, x23, [sp, #0xd0]
0065D0B38  ldp      x26, x25, [sp, #0xc0]
0065D0B3C  ldp      x28, x27, [sp, #0xb0]
0065D0B40  ldp      x29, x30, [sp, #0xa0]
0065D0B44  add      sp, sp, #0x100
0065D0B48  ret      
0065D0B4C  bl       #0x382bfb8 ; 
0065D0B50  bl       #0x382bfc0 ; 
0065D0B54  bl       #0x89edb60 ; 
