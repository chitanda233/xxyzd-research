; HotFix.BattleLogic.WaterfallBattleManager$$CreateRandomMonster
; RVA 0x65CFF58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CFF58  sub      sp, sp, #0x100
0065CFF5C  stp      x29, x30, [sp, #0xa0]
0065CFF60  stp      x28, x27, [sp, #0xb0]
0065CFF64  stp      x26, x25, [sp, #0xc0]
0065CFF68  stp      x24, x23, [sp, #0xd0]
0065CFF6C  stp      x22, x21, [sp, #0xe0]
0065CFF70  stp      x20, x19, [sp, #0xf0]
0065CFF74  str      x1, [sp, #0x40]
0065CFF78  mrs      x22, tpidr_el0
0065CFF7C  ldr      x8, [x22, #0x28]
0065CFF80  adrp     x20, #0x9599000
0065CFF84  adrp     x19, #0x8f0a000
0065CFF88  mov      x21, x0
0065CFF8C  str      x8, [sp, #0x98]
0065CFF90  ldrb     w8, [x20, #0x591]
0065CFF94  ldr      x19, [x19, #0x970] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreateRandomMonster()
0065CFF98  tbnz     w8, #0, #0x65d001c
0065CFF9C  adrp     x0, #0x8ee8000
0065CFFA0  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo
0065CFFA4  bl       #0x382bd14 ; 
0065CFFA8  adrp     x0, #0x8f0a000
0065CFFAC  ldr      x0, [x0, #0x910] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.get_Item()
0065CFFB0  bl       #0x382bd14 ; 
0065CFFB4  adrp     x0, #0x8f09000
0065CFFB8  ldr      x0, [x0, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CFFBC  bl       #0x382bd14 ; 
0065CFFC0  adrp     x0, #0x8ec2000
0065CFFC4  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item()
0065CFFC8  bl       #0x382bd14 ; 
0065CFFCC  adrp     x0, #0x8ee1000
0065CFFD0  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo
0065CFFD4  bl       #0x382bd14 ; 
0065CFFD8  adrp     x0, #0x8f0a000
0065CFFDC  ldr      x0, [x0, #0x970] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreateRandomMonster()
0065CFFE0  bl       #0x382bd14 ; 
0065CFFE4  adrp     x0, #0x8f0a000
0065CFFE8  ldr      x0, [x0, #0x918] ; GLOBAL 刷怪数量超过最大数量，超过的部分不会刷出来
0065CFFEC  bl       #0x382bd14 ; 
0065CFFF0  adrp     x0, #0x8f0a000
0065CFFF4  ldr      x0, [x0, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065CFFF8  bl       #0x382bd14 ; 
0065CFFFC  adrp     x0, #0x8f0a000
0065D0000  ldr      x0, [x0, #0x978] ; GLOBAL CreateRandomMonster
0065D0004  bl       #0x382bd14 ; 
0065D0008  adrp     x0, #0x8f0a000
0065D000C  ldr      x0, [x0, #0x980] ; GLOBAL 刷怪配置错误，刷怪配置的entityId为空
0065D0010  bl       #0x382bd14 ; 
0065D0014  mov      w8, #1
0065D0018  strb     w8, [x20, #0x591]
0065D001C  ldr      x2, [x19]
0065D0020  ldrb     w8, [x2, #0x53]
0065D0024  tbnz     w8, #5, #0x65d0080
0065D0028  stp      xzr, xzr, [sp, #0x80]
0065D002C  str      xzr, [sp, #0x90]
0065D0030  ldr      x20, [x21, #0x188]
0065D0034  cbz      x20, #0x65d0b4c
0065D0038  adrp     x10, #0x8f09000
0065D003C  ldr      x8, [x20]
0065D0040  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D0044  ldrh     w9, [x8, #0x12e]
0065D0048  ldr      x1, [x10]
0065D004C  cbz      x9, #0x65d0070
0065D0050  ldr      x10, [x8, #0xb0]
0065D0054  add      x10, x10, #8
0065D0058  ldur     x11, [x10, #-8]
0065D005C  cmp      x11, x1
0065D0060  b.eq     #0x65d0094
0065D0064  subs     x9, x9, #1
0065D0068  add      x10, x10, #0x10
0065D006C  b.ne     #0x65d0058
0065D0070  mov      w2, #0x18
0065D0074  mov      x0, x20
0065D0078  bl       #0x3a7e710 ; 
0065D007C  b        #0x65d00a4 ; 
0065D0080  ldr      x8, [x2, #0x60]
0065D0084  ldr      x1, [sp, #0x40]
0065D0088  mov      x0, x21
0065D008C  blr      x8
0065D0090  b        #0x65d0b1c ; 
0065D0094  ldr      w9, [x10]
0065D0098  add      w9, w9, #0x18
0065D009C  add      x8, x8, w9, sxtw #4
0065D00A0  add      x0, x8, #0x138
0065D00A4  ldp      x8, x1, [x0]
0065D00A8  mov      x0, x20
0065D00AC  blr      x8
0065D00B0  cmp      w0, #1
0065D00B4  b.lt     #0x65d0b1c
0065D00B8  ldr      x20, [x21, #0x188]
0065D00BC  cbz      x20, #0x65d0b4c
0065D00C0  ldr      x8, [x20]
0065D00C4  adrp     x10, #0x8f09000
0065D00C8  ldrh     w9, [x8, #0x12e]
0065D00CC  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D00D0  ldr      x1, [x10]
0065D00D4  cbz      x9, #0x65d00f8
0065D00D8  ldr      x10, [x8, #0xb0]
0065D00DC  add      x10, x10, #8
0065D00E0  ldur     x11, [x10, #-8]
0065D00E4  cmp      x11, x1
0065D00E8  b.eq     #0x65d0108
0065D00EC  subs     x9, x9, #1
0065D00F0  add      x10, x10, #0x10
0065D00F4  b.ne     #0x65d00e0
0065D00F8  mov      w2, #0x16
0065D00FC  mov      x0, x20
0065D0100  bl       #0x3a7e710 ; 
0065D0104  b        #0x65d0118 ; 
0065D0108  ldr      w9, [x10]
0065D010C  add      w9, w9, #0x16
0065D0110  add      x8, x8, w9, sxtw #4
0065D0114  add      x0, x8, #0x138
0065D0118  ldp      x8, x1, [x0]
0065D011C  mov      x0, x20
0065D0120  blr      x8
0065D0124  cbz      x0, #0x65d0b1c
0065D0128  ldr      x20, [x21, #0x188]
0065D012C  cbz      x20, #0x65d0b4c
0065D0130  ldr      x8, [x20]
0065D0134  adrp     x10, #0x8f09000
0065D0138  ldrh     w9, [x8, #0x12e]
0065D013C  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D0140  ldr      x1, [x10]
0065D0144  cbz      x9, #0x65d0168
0065D0148  ldr      x10, [x8, #0xb0]
0065D014C  add      x10, x10, #8
0065D0150  ldur     x11, [x10, #-8]
0065D0154  cmp      x11, x1
0065D0158  b.eq     #0x65d0178
0065D015C  subs     x9, x9, #1
0065D0160  add      x10, x10, #0x10
0065D0164  b.ne     #0x65d0150
0065D0168  mov      w2, #0x16
0065D016C  mov      x0, x20
0065D0170  bl       #0x3a7e710 ; 
0065D0174  b        #0x65d0188 ; 
0065D0178  ldr      w9, [x10]
0065D017C  add      w9, w9, #0x16
0065D0180  add      x8, x8, w9, sxtw #4
0065D0184  add      x0, x8, #0x138
0065D0188  ldp      x8, x1, [x0]
0065D018C  mov      x0, x20
0065D0190  blr      x8
0065D0194  cbz      x0, #0x65d0b4c
0065D0198  ldr      x8, [x0, #0x18]
0065D019C  cbz      x8, #0x65d0b1c
0065D01A0  adrp     x26, #0x9599000
0065D01A4  ldrb     w8, [x26, #0x286]
0065D01A8  cbnz     w8, #0x65d01c0
0065D01AC  adrp     x0, #0x8f07000
0065D01B0  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D01B4  bl       #0x382bd14 ; 
0065D01B8  mov      w8, #1
0065D01BC  strb     w8, [x26, #0x286]
0065D01C0  adrp     x8, #0x8f07000
0065D01C4  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D01C8  ldr      x1, [x8]
0065D01CC  ldrb     w8, [x1, #0x53]
0065D01D0  tbnz     w8, #5, #0x65d01dc
0065D01D4  ldr      x20, [x21, #0x80]
0065D01D8  b        #0x65d01ec ; 
0065D01DC  ldr      x8, [x1, #0x60]
0065D01E0  mov      x0, x21
0065D01E4  blr      x8
0065D01E8  mov      x20, x0
0065D01EC  cbz      x20, #0x65d0b4c
0065D01F0  adrp     x19, #0x9591000
0065D01F4  ldrb     w8, [x19, #0xa9c]
0065D01F8  cbnz     w8, #0x65d0210
0065D01FC  adrp     x0, #0x8ee6000
0065D0200  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065D0204  bl       #0x382bd14 ; 
0065D0208  mov      w8, #1
0065D020C  strb     w8, [x19, #0xa9c]
0065D0210  adrp     x8, #0x8ee6000
0065D0214  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
0065D0218  ldr      x1, [x8]
0065D021C  ldrb     w8, [x1, #0x53]
0065D0220  tbnz     w8, #5, #0x65d022c
0065D0224  ldr      x27, [x20, #0x240]
0065D0228  b        #0x65d023c ; 
0065D022C  ldr      x8, [x1, #0x60]
0065D0230  mov      x0, x20
0065D0234  blr      x8
0065D0238  mov      x27, x0
0065D023C  cbz      x27, #0x65d0b4c
0065D0240  ldr      x9, [x27, #0x10]
0065D0244  cbz      x9, #0x65d0b4c
0065D0248  ldr      x20, [x21, #0x188]
0065D024C  cbz      x20, #0x65d0b4c
0065D0250  ldr      x8, [x20]
0065D0254  adrp     x10, #0x8f09000
0065D0258  ldp      x24, x19, [x9, #0x10]
0065D025C  ldrh     w9, [x8, #0x12e]
0065D0260  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D0264  ldr      x1, [x10]
0065D0268  cbz      x9, #0x65d028c
0065D026C  ldr      x10, [x8, #0xb0]
0065D0270  add      x10, x10, #8
0065D0274  ldur     x11, [x10, #-8]
0065D0278  cmp      x11, x1
0065D027C  b.eq     #0x65d029c
0065D0280  subs     x9, x9, #1
0065D0284  add      x10, x10, #0x10
0065D0288  b.ne     #0x65d0274
0065D028C  mov      w2, #0x1a
0065D0290  mov      x0, x20
0065D0294  bl       #0x3a7e710 ; 
0065D0298  b        #0x65d02ac ; 
0065D029C  ldr      w9, [x10]
0065D02A0  add      w9, w9, #0x1a
0065D02A4  add      x8, x8, w9, sxtw #4
0065D02A8  add      x0, x8, #0x138
0065D02AC  ldp      x8, x1, [x0]
0065D02B0  mov      x0, x20
0065D02B4  blr      x8
0065D02B8  ldr      x20, [x21, #0x188]
0065D02BC  str      w0, [sp, #0x24]
0065D02C0  cbz      x20, #0x65d0b4c
0065D02C4  ldr      x8, [x20]
0065D02C8  adrp     x10, #0x8f09000
0065D02CC  ldrh     w9, [x8, #0x12e]
0065D02D0  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D02D4  ldr      x1, [x10]
0065D02D8  cbz      x9, #0x65d02fc
0065D02DC  ldr      x10, [x8, #0xb0]
0065D02E0  add      x10, x10, #8
0065D02E4  ldur     x11, [x10, #-8]
0065D02E8  cmp      x11, x1
0065D02EC  b.eq     #0x65d030c
0065D02F0  subs     x9, x9, #1
0065D02F4  add      x10, x10, #0x10
0065D02F8  b.ne     #0x65d02e4
0065D02FC  mov      w2, #0x18
0065D0300  mov      x0, x20
0065D0304  bl       #0x3a7e710 ; 
0065D0308  b        #0x65d031c ; 
0065D030C  ldr      w9, [x10]
0065D0310  add      w9, w9, #0x18
0065D0314  add      x8, x8, w9, sxtw #4
0065D0318  add      x0, x8, #0x138
0065D031C  ldp      x8, x1, [x0]
0065D0320  mov      x0, x20
0065D0324  blr      x8
0065D0328  ldr      w8, [x21, #0xa8]
0065D032C  mov      w28, w0
0065D0330  add      w8, w8, w0
0065D0334  cmp      w8, #0x259
0065D0338  b.lt     #0x65d0390
0065D033C  adrp     x8, #0x8ee1000
0065D0340  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
0065D0344  ldr      x0, [x8]
0065D0348  ldr      w8, [x0, #0xe0]
0065D034C  cbnz     w8, #0x65d0354
0065D0350  bl       #0x382be8c ; 
0065D0354  adrp     x8, #0x8f0a000
0065D0358  adrp     x9, #0x8f0a000
0065D035C  adrp     x10, #0x8f0a000
0065D0360  ldr      x8, [x8, #0x918] ; GLOBAL 刷怪数量超过最大数量，超过的部分不会刷出来
0065D0364  ldr      x9, [x9, #0x978] ; GLOBAL CreateRandomMonster
0065D0368  ldr      x10, [x10, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
0065D036C  mov      w3, #0x597
0065D0370  ldr      x0, [x8]
0065D0374  ldr      x1, [x9]
0065D0378  ldr      x2, [x10]
0065D037C  mov      x4, xzr
0065D0380  bl       #0x7997754 ; Logger$$LogError
0065D0384  ldr      w8, [x21, #0xa8]
0065D0388  mov      w9, #0x258
0065D038C  sub      w28, w9, w8
0065D0390  cbz      w28, #0x65d0b1c
0065D0394  ldr      x20, [x21, #0x188]
0065D0398  cbz      x20, #0x65d0b4c
0065D039C  ldr      x8, [x20]
0065D03A0  adrp     x10, #0x8f09000
0065D03A4  ldrh     w9, [x8, #0x12e]
0065D03A8  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D03AC  ldr      x1, [x10]
0065D03B0  cbz      x9, #0x65d03d4
0065D03B4  ldr      x10, [x8, #0xb0]
0065D03B8  add      x10, x10, #8
0065D03BC  ldur     x11, [x10, #-8]
0065D03C0  cmp      x11, x1
0065D03C4  b.eq     #0x65d03e4
0065D03C8  subs     x9, x9, #1
0065D03CC  add      x10, x10, #0x10
0065D03D0  b.ne     #0x65d03bc
0065D03D4  mov      w2, #0x16
0065D03D8  mov      x0, x20
0065D03DC  bl       #0x3a7e710 ; 
0065D03E0  b        #0x65d03f4 ; 
0065D03E4  ldr      w9, [x10]
0065D03E8  add      w9, w9, #0x16
0065D03EC  add      x8, x8, w9, sxtw #4
0065D03F0  add      x0, x8, #0x138
0065D03F4  ldp      x8, x1, [x0]
0065D03F8  mov      x0, x20
0065D03FC  blr      x8
0065D0400  ldr      x23, [x21, #0x188]
0065D0404  str      x0, [sp, #0x10]
0065D0408  cbz      x23, #0x65d0b4c
0065D040C  ldr      x8, [x23]
0065D0410  adrp     x10, #0x8f09000
0065D0414  ldr      x20, [x21, #0x1f0]
0065D0418  ldrh     w9, [x8, #0x12e]
0065D041C  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065D0420  ldr      x1, [x10]
0065D0424  cbz      x9, #0x65d0448
0065D0428  ldr      x10, [x8, #0xb0]
0065D042C  add      x10, x10, #8
0065D0430  ldur     x11, [x10, #-8]
0065D0434  cmp      x11, x1
0065D0438  b.eq     #0x65d0458
0065D043C  subs     x9, x9, #1
0065D0440  add      x10, x10, #0x10
0065D0444  b.ne     #0x65d0430
0065D0448  mov      x0, x23
0065D044C  mov      w2, wzr
0065D0450  bl       #0x3a7e710 ; 
0065D0454  b        #0x65d0464 ; 
0065D0458  ldrsw    x9, [x10]
0065D045C  add      x8, x8, x9, lsl #4
0065D0460  add      x0, x8, #0x138
0065D0464  ldp      x8, x1, [x0]
0065D0468  mov      x0, x23
0065D046C  blr      x8
0065D0470  cbz      x20, #0x65d0b4c
0065D0474  str      x27, [sp, #0x48]
0065D0478  str      x22, [sp, #8]
0065D047C  adrp     x8, #0x8f0a000
0065D0480  ldr      x8, [x8, #0x910] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, WaveMissionRandomData>.get_Item()
0065D0484  mov      w1, w0
0065D0488  mov      x0, x20
0065D048C  ldr      x2, [x8]
0065D0490  bl       #0x5e5f99c ; System.Collections.Generic.Dictionary<int, object>$$get_Item
0065D0494  cbz      x0, #0x65d0b4c
0065D0498  sub      x8, x19, x24
0065D049C  adrp     x25, #0x8ec2000
0065D04A0  sub      x8, x8, #0x20, lsl #12
0065D04A4  ldr      x25, [x25, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item()
0065D04A8  str      x8, [sp, #0x18]
0065D04AC  adrp     x24, #0x8f07000
0065D04B0  ldr      x24, [x24, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D04B4  mov      x29, x0
0065D04B8  mov      w27, wzr
0065D04BC  mov      w22, wzr
0065D04C0  str      x0, [sp, #0x28]
0065D04C4  ldr      x19, [sp, #0x10]
0065D04C8  ldr      x0, [x29, #0x28]
0065D04CC  cbz      x0, #0x65d0b4c
0065D04D0  ldr      x2, [x25]
0065D04D4  mov      w1, w27
0065D04D8  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
0065D04DC  cbz      x19, #0x65d0b4c
0065D04E0  ldr      w8, [x19, #0x18]
0065D04E4  cmp      w0, w8
0065D04E8  b.hs     #0x65d0b50
0065D04EC  add      x8, x19, w0, sxtw #2
0065D04F0  ldrb     w9, [x26, #0x286]
0065D04F4  ldr      w20, [x8, #0x20]
0065D04F8  cbnz     w9, #0x65d050c
0065D04FC  mov      x0, x24
0065D0500  bl       #0x382bd14 ; 
0065D0504  mov      w8, #1
0065D0508  strb     w8, [x26, #0x286]
0065D050C  ldr      x1, [x24]
0065D0510  ldrb     w8, [x1, #0x53]
0065D0514  tbnz     w8, #5, #0x65d0520
0065D0518  ldr      x23, [x21, #0x80]
0065D051C  b        #0x65d0530 ; 
0065D0520  ldr      x8, [x1, #0x60]
0065D0524  mov      x0, x21
0065D0528  blr      x8
0065D052C  mov      x23, x0
0065D0530  cbz      x23, #0x65d0b4c
0065D0534  adrp     x8, #0x9598000
0065D0538  ldrb     w8, [x8, #0xfcc]
0065D053C  cbnz     w8, #0x65d0558
0065D0540  adrp     x0, #0x8f06000
0065D0544  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D0548  bl       #0x382bd14 ; 
0065D054C  mov      w8, #1
0065D0550  adrp     x9, #0x9598000
0065D0554  strb     w8, [x9, #0xfcc]
0065D0558  adrp     x8, #0x8f06000
0065D055C  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D0560  ldr      x1, [x8]
0065D0564  ldrb     w8, [x1, #0x53]
0065D0568  tbnz     w8, #5, #0x65d0574
0065D056C  ldr      x0, [x23, #0x200]
0065D0570  b        #0x65d0580 ; 
0065D0574  ldr      x8, [x1, #0x60]
0065D0578  mov      x0, x23
0065D057C  blr      x8
0065D0580  cbz      x0, #0x65d0b4c
0065D0584  mov      w1, w20
0065D0588  mov      x2, xzr
0065D058C  add      w27, w27, #1
0065D0590  bl       #0x64e54f0 ; LocalModels.LocalModelManager$$GetMission_RandomMonsterFlushConfig
0065D0594  cbz      x0, #0x65d04c8
0065D0598  adrp     x8, #0x9599000
0065D059C  ldrb     w8, [x8, #0x65e]
0065D05A0  mov      x23, x0
0065D05A4  cbnz     w8, #0x65d05c0
0065D05A8  adrp     x0, #0x8f0a000
0065D05AC  ldr      x0, [x0, #0x988] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_entityId()
0065D05B0  bl       #0x382bd14 ; 
0065D05B4  mov      w8, #1
0065D05B8  adrp     x9, #0x9599000
0065D05BC  strb     w8, [x9, #0x65e]
0065D05C0  adrp     x8, #0x8f0a000
0065D05C4  ldr      x8, [x8, #0x988] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_entityId()
0065D05C8  ldr      x1, [x8]
0065D05CC  ldrb     w8, [x1, #0x53]
0065D05D0  tbnz     w8, #5, #0x65d05dc
0065D05D4  ldr      x0, [x23, #0x28]
0065D05D8  b        #0x65d05e8 ; 
0065D05DC  ldr      x8, [x1, #0x60]
0065D05E0  mov      x0, x23
0065D05E4  blr      x8
0065D05E8  cbz      x0, #0x65d0ad0
0065D05EC  adrp     x8, #0x9599000
0065D05F0  ldrb     w8, [x8, #0x65e]
0065D05F4  cbnz     w8, #0x65d0610
0065D05F8  adrp     x0, #0x8f0a000
0065D05FC  ldr      x0, [x0, #0x988] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_entityId()
0065D0600  bl       #0x382bd14 ; 
0065D0604  mov      w8, #1
0065D0608  adrp     x9, #0x9599000
0065D060C  strb     w8, [x9, #0x65e]
0065D0610  adrp     x8, #0x8f0a000
0065D0614  ldr      x8, [x8, #0x988] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_entityId()
0065D0618  ldr      x1, [x8]
0065D061C  ldrb     w8, [x1, #0x53]
0065D0620  tbnz     w8, #5, #0x65d062c
0065D0624  ldr      x0, [x23, #0x28]
0065D0628  b        #0x65d0638 ; 
0065D062C  ldr      x8, [x1, #0x60]
0065D0630  mov      x0, x23
0065D0634  blr      x8
0065D0638  cbz      x0, #0x65d0b4c
0065D063C  ldr      x8, [x0, #0x18]
0065D0640  cbz      x8, #0x65d0ad0
0065D0644  ldr      w8, [x21, #0xa8]
0065D0648  ldr      x1, [sp, #0x18]
0065D064C  ldr      w2, [sp, #0x24]
0065D0650  ldr      x3, [sp, #0x48]
0065D0654  add      w4, w8, w22
0065D0658  add      x8, sp, #0x68
0065D065C  mov      x0, x21
0065D0660  mov      x19, x21
0065D0664  bl       #0x65d3a78 ; HotFix.BattleLogic.WaterfallBattleManager$$RandomPos
0065D0668  ldr      x9, [sp, #0x68]
0065D066C  ldr      x8, [sp, #0x78]
0065D0670  mov      x26, xzr
0065D0674  stp      x8, x9, [sp, #0x30]
0065D0678  adrp     x20, #0x9599000
0065D067C  adrp     x21, #0x8f0a000
0065D0680  ldrb     w8, [x20, #0x65e]
0065D0684  ldr      x21, [x21, #0x988] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_entityId()
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
0065D0754  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
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
0065D07C4  ldr      x9, [x9, #0x898] ; GLOBAL LocalModels.Const_TypeInfo
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
0065D07FC  ldr      x0, [x0, #0x990] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_weight()
0065D0800  bl       #0x382bd14 ; 
0065D0804  mov      w8, #1
0065D0808  adrp     x9, #0x9599000
0065D080C  strb     w8, [x9, #0x660]
0065D0810  adrp     x8, #0x8f0a000
0065D0814  ldr      x8, [x8, #0x990] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_weight()
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
0065D086C  ldr      x0, [x0, #0x998] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_height()
0065D0870  bl       #0x382bd14 ; 
0065D0874  mov      w8, #1
0065D0878  adrp     x9, #0x9599000
0065D087C  strb     w8, [x9, #0x661]
0065D0880  adrp     x8, #0x8f0a000
0065D0884  ldr      x8, [x8, #0x998] ; GLOBAL Method$LocalModels.Bean.Mission_RandomMonsterFlushConfig.get_height()
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
0065D0928  ldr      x24, [x24, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
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
0065D097C  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
0065D0980  bl       #0x382bd14 ; 
0065D0984  mov      w8, #1
0065D0988  adrp     x9, #0x9598000
0065D098C  strb     w8, [x9, #0xfcc]
0065D0990  adrp     x8, #0x8f06000
0065D0994  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
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
0065D0A18  ldr      x10, [x10, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
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
0065D0A90  ldr      x24, [x24, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext()
0065D0A94  ldr      x29, [sp, #0x28]
0065D0A98  ldr      x25, [x25, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item()
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
0065D0AD4  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
0065D0AD8  ldr      x0, [x8]
0065D0ADC  ldr      w8, [x0, #0xe0]
0065D0AE0  cbnz     w8, #0x65d0ae8
0065D0AE4  bl       #0x382be8c ; 
0065D0AE8  adrp     x8, #0x8f0a000
0065D0AEC  adrp     x9, #0x8f0a000
0065D0AF0  adrp     x10, #0x8f0a000
0065D0AF4  ldr      x8, [x8, #0x980] ; GLOBAL 刷怪配置错误，刷怪配置的entityId为空
0065D0AF8  ldr      x9, [x9, #0x978] ; GLOBAL CreateRandomMonster
0065D0AFC  ldr      x10, [x10, #0x8b8] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\Battle\WaterfallBattleManager.cs
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

