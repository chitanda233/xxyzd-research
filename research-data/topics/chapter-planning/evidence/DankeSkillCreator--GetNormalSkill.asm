; HotFix.BattleLogic.DankeSkillCreator$$GetNormalSkill
; RVA 0x685DFAC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685DFAC  sub      sp, sp, #0xd0
00685DFB0  stp      x29, x30, [sp, #0x70]
00685DFB4  stp      x28, x27, [sp, #0x80]
00685DFB8  stp      x26, x25, [sp, #0x90]
00685DFBC  stp      x24, x23, [sp, #0xa0]
00685DFC0  stp      x22, x21, [sp, #0xb0]
00685DFC4  stp      x20, x19, [sp, #0xc0]
00685DFC8  str      w4, [sp, #0x44]
00685DFCC  str      x3, [sp, #0x48]
00685DFD0  str      w2, [sp, #0x3c]
00685DFD4  adrp     x21, #0x959b000
00685DFD8  adrp     x23, #0x8f23000
00685DFDC  ldrb     w8, [x21, #0x9f1]
00685DFE0  ldr      x23, [x23, #0xba0] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetNormalSkill() @ 0x9259d48
00685DFE4  mov      x24, x7
00685DFE8  mov      x22, x6
00685DFEC  mov      x26, x5
00685DFF0  mov      x20, x1
00685DFF4  mov      x19, x0
00685DFF8  tbnz     w8, #0, #0x685e10c
00685DFFC  adrp     x0, #0x8f0c000
00685E000  ldr      x0, [x0, #0x1c0] ; GLOBAL Method$System.Array.IndexOf<int>() @ 0x92370c8
00685E004  bl       #0x382bd14 ; 
00685E008  adrp     x0, #0x8ee8000
00685E00C  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00685E010  bl       #0x382bd14 ; 
00685E014  adrp     x0, #0x8f23000
00685E018  ldr      x0, [x0, #0xba0] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetNormalSkill() @ 0x9259d48
00685E01C  bl       #0x382bd14 ; 
00685E020  adrp     x0, #0x8eeb000
00685E024  ldr      x0, [x0, #0xd28] ; GLOBAL Method$System.Linq.Enumerable.Count<int>() @ 0x9264c78
00685E028  bl       #0x382bd14 ; 
00685E02C  adrp     x0, #0x8f23000
00685E030  ldr      x0, [x0, #0xba8] ; GLOBAL Method$System.Linq.Enumerable.Last<int>() @ 0x92650b0
00685E034  bl       #0x382bd14 ; 
00685E038  adrp     x0, #0x8f08000
00685E03C  ldr      x0, [x0, #0x40] ; GLOBAL LocalModels.Bean.IChapter_TypeInfo @ 0x91e9160
00685E040  bl       #0x382bd14 ; 
00685E044  adrp     x0, #0x8ebf000
00685E048  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685E04C  bl       #0x382bd14 ; 
00685E050  adrp     x0, #0x8f23000
00685E054  ldr      x0, [x0, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<NewPlayerBoostRecord>.Add() @ 0x921eb98
00685E058  bl       #0x382bd14 ; 
00685E05C  adrp     x0, #0x8f23000
00685E060  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$System.Collections.Generic.List<NewPlayerBoostRecord>.Clear() @ 0x921eba0
00685E064  bl       #0x382bd14 ; 
00685E068  adrp     x0, #0x8f08000
00685E06C  ldr      x0, [x0, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
00685E070  bl       #0x382bd14 ; 
00685E074  adrp     x0, #0x8ed2000
00685E078  ldr      x0, [x0, #0xdd8] ; GLOBAL Method$System.Collections.Generic.List<int>.RemoveAt() @ 0x921de98
00685E07C  bl       #0x382bd14 ; 
00685E080  adrp     x0, #0x8eea000
00685E084  ldr      x0, [x0, #0xf18] ; GLOBAL Method$System.Collections.Generic.List<int>.ToArray() @ 0x921dec0
00685E088  bl       #0x382bd14 ; 
00685E08C  adrp     x0, #0x8f23000
00685E090  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$System.Collections.Generic.List<NewPlayerBoostRecord>.get_Count() @ 0x921eba8
00685E094  bl       #0x382bd14 ; 
00685E098  adrp     x0, #0x8ec2000
00685E09C  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
00685E0A0  bl       #0x382bd14 ; 
00685E0A4  adrp     x0, #0x8f23000
00685E0A8  ldr      x0, [x0, #0xbc8] ; GLOBAL Method$System.Collections.Generic.List<NewPlayerBoostRecord>.get_Item() @ 0x921ebb0
00685E0AC  bl       #0x382bd14 ; 
00685E0B0  adrp     x0, #0x8ec2000
00685E0B4  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00685E0B8  bl       #0x382bd14 ; 
00685E0BC  adrp     x0, #0x8f0a000
00685E0C0  ldr      x0, [x0, #0x9e8] ; GLOBAL Method$System.Collections.Generic.List<int>.set_Item() @ 0x921dee8
00685E0C4  bl       #0x382bd14 ; 
00685E0C8  adrp     x0, #0x8ec2000
00685E0CC  ldr      x0, [x0, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
00685E0D0  bl       #0x382bd14 ; 
00685E0D4  adrp     x0, #0x8f09000
00685E0D8  ldr      x0, [x0, #0xa98] ; GLOBAL Method$System.String.Join<int>() @ 0x92b0100
00685E0DC  bl       #0x382bd14 ; 
00685E0E0  adrp     x0, #0x8f23000
00685E0E4  ldr      x0, [x0, #0xbd0] ; GLOBAL -[RandomSkill] 随机三个辅助技能结果 = {0}, 变化的index = {1} 变化前为 = {2}, 变化后为 = {3} @ 0x92eaba8
00685E0E8  bl       #0x382bd14 ; 
00685E0EC  adrp     x0, #0x8f23000
00685E0F0  ldr      x0, [x0, #0xbd8] ; GLOBAL -[RandomSkill] 随机技能结果 =  @ 0x92eabd0
00685E0F4  bl       #0x382bd14 ; 
00685E0F8  adrp     x0, #0x8ec2000
00685E0FC  ldr      x0, [x0, #0x4e0] ; GLOBAL , @ 0x92ea038
00685E100  bl       #0x382bd14 ; 
00685E104  mov      w8, #1
00685E108  strb     w8, [x21, #0x9f1]
00685E10C  ldr      x8, [x23]
00685E110  ldrb     w9, [x8, #0x53]
00685E114  tbnz     w9, #5, #0x685e144
00685E118  str      xzr, [sp, #0x68]
00685E11C  ldr      x24, [x19, #0x48]
00685E120  mov      x0, x19
00685E124  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685E128  cbz      x0, #0x685e9f8
00685E12C  ldrb     w8, [x0, #0x25]
00685E130  str      x26, [sp, #0x30]
00685E134  cbz      w8, #0x685e194
00685E138  str      wzr, [sp, #0x40]
00685E13C  str      wzr, [sp, #0x2c]
00685E140  b        #0x685e3c0 ; 
00685E144  ldr      w10, [sp, #0x3c]
00685E148  ldr      x9, [x8, #0x60]
00685E14C  mov      x0, x19
00685E150  mov      x1, x20
00685E154  and      w2, w10, #1
00685E158  ldr      w10, [sp, #0x44]
00685E15C  ldr      x3, [sp, #0x48]
00685E160  mov      x5, x26
00685E164  mov      x6, x22
00685E168  mov      x7, x24
00685E16C  ldp      x20, x19, [sp, #0xc0]
00685E170  ldp      x22, x21, [sp, #0xb0]
00685E174  ldp      x24, x23, [sp, #0xa0]
00685E178  ldp      x26, x25, [sp, #0x90]
00685E17C  ldp      x28, x27, [sp, #0x80]
00685E180  ldp      x29, x30, [sp, #0x70]
00685E184  and      w4, w10, #1
00685E188  str      x8, [sp, #0xd0]
00685E18C  add      sp, sp, #0xd0
00685E190  br       x9
00685E194  mov      x0, x19
00685E198  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685E19C  cbz      x0, #0x685e9f8
00685E1A0  adrp     x21, #0x959b000
00685E1A4  ldrb     w8, [x21, #0xb84]
00685E1A8  mov      x22, x0
00685E1AC  cbnz     w8, #0x685e1c4
00685E1B0  adrp     x0, #0x8f23000
00685E1B4  ldr      x0, [x0, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
00685E1B8  bl       #0x382bd14 ; 
00685E1BC  mov      w8, #1
00685E1C0  strb     w8, [x21, #0xb84]
00685E1C4  adrp     x8, #0x8f23000
00685E1C8  ldr      x8, [x8, #0xb98] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_InitSkillGroupCount() @ 0x923fee8
00685E1CC  ldr      x1, [x8]
00685E1D0  ldrb     w8, [x1, #0x53]
00685E1D4  tbnz     w8, #5, #0x685e1e0
00685E1D8  ldr      w0, [x22, #0x2c4]
00685E1DC  b        #0x685e1ec ; 
00685E1E0  ldr      x8, [x1, #0x60]
00685E1E4  mov      x0, x22
00685E1E8  blr      x8
00685E1EC  cmp      w0, #1
00685E1F0  b.lt     #0x685e138
00685E1F4  ldr      x24, [x19, #0x18]
00685E1F8  mov      x0, x19
00685E1FC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685E200  cbz      x0, #0x685e9f8
00685E204  adrp     x21, #0x959b000
00685E208  ldrb     w8, [x21, #0xb83]
00685E20C  mov      x22, x0
00685E210  cbnz     w8, #0x685e228
00685E214  adrp     x0, #0x8f23000
00685E218  ldr      x0, [x0, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroup() @ 0x923f8b8
00685E21C  bl       #0x382bd14 ; 
00685E220  mov      w8, #1
00685E224  strb     w8, [x21, #0xb83]
00685E228  adrp     x8, #0x8f23000
00685E22C  ldr      x8, [x8, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroup() @ 0x923f8b8
00685E230  ldr      x1, [x8]
00685E234  ldrb     w8, [x1, #0x53]
00685E238  tbnz     w8, #5, #0x685e24c
00685E23C  ldr      w8, [x22, #0x2c4]
00685E240  sub      w8, w8, #1
00685E244  str      w8, [x22, #0x2c4]
00685E248  b        #0x685e258 ; 
00685E24C  ldr      x8, [x1, #0x60]
00685E250  mov      x0, x22
00685E254  blr      x8
00685E258  mov      x0, x19
00685E25C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685E260  cbz      x0, #0x685e9f8
00685E264  ldr      w8, [x0, #0x1c8]
00685E268  cmp      w8, #1
00685E26C  b.ne     #0x685e3b4
00685E270  mov      x0, x19
00685E274  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685E278  cbz      x0, #0x685e9f8
00685E27C  ldr      x22, [x0, #0x3b8]
00685E280  cbz      x22, #0x685e9f8
00685E284  adrp     x21, #0x8f08000
00685E288  ldr      x8, [x22]
00685E28C  ldr      x21, [x21, #0x40] ; GLOBAL LocalModels.Bean.IChapter_TypeInfo @ 0x91e9160
00685E290  ldrh     w9, [x8, #0x12e]
00685E294  ldr      x1, [x21]
00685E298  cbz      x9, #0x685e2bc
00685E29C  ldr      x10, [x8, #0xb0]
00685E2A0  add      x10, x10, #8
00685E2A4  ldur     x11, [x10, #-8]
00685E2A8  cmp      x11, x1
00685E2AC  b.eq     #0x685e2cc
00685E2B0  subs     x9, x9, #1
00685E2B4  add      x10, x10, #0x10
00685E2B8  b.ne     #0x685e2a4
00685E2BC  mov      w2, #0x1e
00685E2C0  mov      x0, x22
00685E2C4  bl       #0x3a7e710 ; 
00685E2C8  b        #0x685e2dc ; 
00685E2CC  ldr      w9, [x10]
00685E2D0  add      w9, w9, #0x1e
00685E2D4  add      x8, x8, w9, sxtw #4
00685E2D8  add      x0, x8, #0x138
00685E2DC  ldp      x8, x1, [x0]
00685E2E0  mov      x0, x22
00685E2E4  blr      x8
00685E2E8  cbz      x0, #0x685e3b4
00685E2EC  mov      x0, x19
00685E2F0  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685E2F4  cbz      x0, #0x685e9f8
00685E2F8  ldr      x22, [x0, #0x3b8]
00685E2FC  cbz      x22, #0x685e9f8
00685E300  ldr      x8, [x22]
00685E304  ldr      x1, [x21]
00685E308  ldrh     w9, [x8, #0x12e]
00685E30C  cbz      x9, #0x685e330
00685E310  ldr      x10, [x8, #0xb0]
00685E314  add      x10, x10, #8
00685E318  ldur     x11, [x10, #-8]
00685E31C  cmp      x11, x1
00685E320  b.eq     #0x685e340
00685E324  subs     x9, x9, #1
00685E328  add      x10, x10, #0x10
00685E32C  b.ne     #0x685e318
00685E330  mov      w2, #0x1e
00685E334  mov      x0, x22
00685E338  bl       #0x3a7e710 ; 
00685E33C  b        #0x685e350 ; 
00685E340  ldr      w9, [x10]
00685E344  add      w9, w9, #0x1e
00685E348  add      x8, x8, w9, sxtw #4
00685E34C  add      x0, x8, #0x138
00685E350  ldp      x8, x1, [x0]
00685E354  mov      x0, x22
00685E358  blr      x8
00685E35C  adrp     x8, #0x8f0c000
00685E360  ldr      x8, [x8, #0x1c0] ; GLOBAL Method$System.Array.IndexOf<int>() @ 0x92370c8
00685E364  mov      w1, #3
00685E368  ldr      x2, [x8]
00685E36C  bl       #0x47b3cd0 ; System.Array$$IndexOf<int>
00685E370  tbnz     w0, #0x1f, #0x685e3b4
00685E374  adrp     x25, #0x8ee8000
00685E378  ldr      x25, [x25, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
00685E37C  ldr      x0, [x25]
00685E380  ldr      w8, [x0, #0xe0]
00685E384  cbnz     w8, #0x685e38c
00685E388  bl       #0x382be8c ; 
00685E38C  cbz      x26, #0x685e9f8
00685E390  ldr      x8, [x25]
00685E394  adrp     x9, #0x8f08000
00685E398  mov      x0, x26
00685E39C  ldr      x8, [x8, #0xb8]
00685E3A0  ldr      x9, [x9, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
00685E3A4  ldr      w1, [x8, #0x490]
00685E3A8  ldr      x2, [x9]
00685E3AC  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
00685E3B0  tbz      w0, #0, #0x685ea8c
00685E3B4  str      wzr, [sp, #0x2c]
00685E3B8  mov      w8, #1
00685E3BC  str      w8, [sp, #0x40]
00685E3C0  mov      x0, x19
00685E3C4  bl       #0x685ecf8 ; HotFix.BattleLogic.DankeSkillCreator$$InitDankeAlreadyStudySkills
00685E3C8  mov      x0, x19
00685E3CC  bl       #0x685ee54 ; HotFix.BattleLogic.DankeSkillCreator$$InitDankeReadyStudySkills
00685E3D0  add      x2, sp, #0x6c
00685E3D4  add      x3, sp, #0x68
00685E3D8  mov      x0, x19
00685E3DC  mov      x1, x26
00685E3E0  bl       #0x685efb0 ; HotFix.BattleLogic.DankeSkillCreator$$GetSkillCountOnType
00685E3E4  mov      x0, x19
00685E3E8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685E3EC  cbz      x0, #0x685e9f8
00685E3F0  adrp     x29, #0x8f05000
00685E3F4  ldr      x29, [x29, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00685E3F8  mov      x23, x0
00685E3FC  mov      w28, wzr
00685E400  mov      w22, wzr
00685E404  add      x27, x19, #0x60
00685E408  adrp     x21, #0x9598000
00685E40C  mov      w25, #1
00685E410  ldrb     w8, [x21, #0xfc4]
00685E414  cbnz     w8, #0x685e424
00685E418  mov      x0, x29
00685E41C  bl       #0x382bd14 ; 
00685E420  strb     w25, [x21, #0xfc4]
00685E424  ldr      x1, [x29]
00685E428  ldrb     w8, [x1, #0x53]
00685E42C  tbnz     w8, #5, #0x685e438
00685E430  ldr      x0, [x23, #0x220]
00685E434  b        #0x685e444 ; 
00685E438  ldr      x8, [x1, #0x60]
00685E43C  mov      x0, x23
00685E440  blr      x8
00685E444  cbz      x0, #0x685e9f8
00685E448  ldr      x8, [x0]
00685E44C  ldp      x9, x1, [x8, #0x1c8]
00685E450  blr      x9
00685E454  cmp      w22, w0
00685E458  b.ge     #0x685e574
00685E45C  ldp      w9, w8, [sp, #0x68]
00685E460  ldr      w10, [sp, #0x40]
00685E464  ldr      x6, [sp, #0x48]
00685E468  mov      w4, #1
00685E46C  str      w9, [sp, #0x10]
00685E470  str      w8, [sp, #8]
00685E474  ldr      w8, [sp, #0x3c]
00685E478  ldr      w9, [sp, #0x44]
00685E47C  mov      x0, x19
00685E480  mov      x1, x20
00685E484  and      w8, w8, #1
00685E488  and      w7, w9, #1
00685E48C  mov      x2, x26
00685E490  mov      x3, x24
00685E494  mov      x5, x27
00685E498  strb     w10, [sp, #0x18]
00685E49C  strb     w8, [sp]
00685E4A0  bl       #0x685f434 ; HotFix.BattleLogic.DankeSkillCreator$$GetRandomSkills
00685E4A4  cbz      x20, #0x685e9f8
00685E4A8  ldr      w26, [x20, #0x18]
00685E4AC  add      w8, w22, #1
00685E4B0  cmp      w26, w8
00685E4B4  b.ne     #0x685e57c
00685E4B8  mov      x0, x19
00685E4BC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685E4C0  cbz      x0, #0x685e9f8
00685E4C4  adrp     x8, #0x9598000
00685E4C8  ldrb     w8, [x8, #0xfcc]
00685E4CC  mov      x23, x0
00685E4D0  cbnz     w8, #0x685e4e8
00685E4D4  adrp     x0, #0x8f06000
00685E4D8  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00685E4DC  bl       #0x382bd14 ; 
00685E4E0  adrp     x8, #0x9598000
00685E4E4  strb     w25, [x8, #0xfcc]
00685E4E8  adrp     x8, #0x8f06000
00685E4EC  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00685E4F0  ldr      x1, [x8]
00685E4F4  ldrb     w8, [x1, #0x53]
00685E4F8  tbnz     w8, #5, #0x685e504
00685E4FC  ldr      x23, [x23, #0x200]
00685E500  b        #0x685e514 ; 
00685E504  ldr      x8, [x1, #0x60]
00685E508  mov      x0, x23
00685E50C  blr      x8
00685E510  mov      x23, x0
00685E514  adrp     x8, #0x8ec2000
00685E518  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00685E51C  mov      x0, x20
00685E520  mov      w1, w22
00685E524  ldr      x2, [x8]
00685E528  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00685E52C  cbz      x23, #0x685e9f8
00685E530  mov      w1, w0
00685E534  mov      x0, x23
00685E538  mov      x2, xzr
00685E53C  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
00685E540  mov      w1, #1
00685E544  mov      x2, xzr
00685E548  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
00685E54C  and      w8, w0, #0xfffffffe
00685E550  cmp      w8, #2
00685E554  mov      x0, x19
00685E558  cinc     w28, w28, eq
00685E55C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685E560  mov      w22, w26
00685E564  ldr      x26, [sp, #0x30]
00685E568  mov      x23, x0
00685E56C  cbnz     x0, #0x685e410
00685E570  b        #0x685e9f8 ; 
00685E574  cbz      x20, #0x685e9f8
00685E578  ldr      w26, [x20, #0x18]
00685E57C  mov      x0, x19
00685E580  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685E584  cbz      x0, #0x685e9f8
00685E588  ldrb     w8, [x21, #0xfc4]
00685E58C  mov      x22, x0
00685E590  cbnz     w8, #0x685e5a8
00685E594  adrp     x0, #0x8f05000
00685E598  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
00685E59C  bl       #0x382bd14 ; 
00685E5A0  mov      w8, #1
00685E5A4  strb     w8, [x21, #0xfc4]
00685E5A8  ldr      x1, [x29]
00685E5AC  ldrb     w8, [x1, #0x53]
00685E5B0  tbnz     w8, #5, #0x685e5bc
00685E5B4  ldr      x0, [x22, #0x220]
00685E5B8  b        #0x685e5c8 ; 
00685E5BC  ldr      x8, [x1, #0x60]
00685E5C0  mov      x0, x22
00685E5C4  blr      x8
00685E5C8  cbz      x0, #0x685e9f8
00685E5CC  ldr      x8, [x0]
00685E5D0  ldp      x9, x1, [x8, #0x1c8]
00685E5D4  blr      x9
00685E5D8  cmp      w26, #1
00685E5DC  b.le     #0x685e96c
00685E5E0  ldr      x26, [sp, #0x30]
00685E5E4  subs     w21, w28, #1
00685E5E8  b.ge     #0x685e984
00685E5EC  mov      w22, w0
00685E5F0  mov      x0, x19
00685E5F4  mov      x1, x20
00685E5F8  bl       #0x6860978 ; HotFix.BattleLogic.DankeSkillCreator$$GetChangeIndex
00685E5FC  mov      w9, #1
00685E600  sub      w9, w9, w28
00685E604  mov      w8, #2
00685E608  mov      w28, #1
00685E60C  cmp      w9, #1
00685E610  str      w8, [x19, #0x60]
00685E614  b.lt     #0x685e984
00685E618  mov      w25, w0
00685E61C  add      w23, w22, #1
00685E620  ldp      w9, w8, [sp, #0x68]
00685E624  ldr      w10, [sp, #0x40]
00685E628  ldr      x6, [sp, #0x48]
00685E62C  mov      w4, #1
00685E630  str      w8, [sp, #8]
00685E634  ldr      w8, [sp, #0x44]
00685E638  mov      x0, x19
00685E63C  mov      x1, x20
00685E640  mov      x2, x26
00685E644  and      w7, w8, #1
00685E648  mov      x3, x24
00685E64C  mov      x5, x27
00685E650  strb     w10, [sp, #0x18]
00685E654  str      w9, [sp, #0x10]
00685E658  strb     w28, [sp]
00685E65C  bl       #0x685f434 ; HotFix.BattleLogic.DankeSkillCreator$$GetRandomSkills
00685E660  adrp     x8, #0x8ec2000
00685E664  ldr      x8, [x8, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
00685E668  mov      w1, #4
00685E66C  ldr      x0, [x8]
00685E670  bl       #0x382bdfc ; 
00685E674  adrp     x8, #0x8eea000
00685E678  ldr      x8, [x8, #0xf18] ; GLOBAL Method$System.Collections.Generic.List<int>.ToArray() @ 0x921dec0
00685E67C  mov      x29, x0
00685E680  mov      x0, x20
00685E684  ldr      x1, [x8]
00685E688  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
00685E68C  adrp     x8, #0x8ec2000
00685E690  ldr      x8, [x8, #0x4e0] ; GLOBAL , @ 0x92ea038
00685E694  adrp     x9, #0x8f09000
00685E698  mov      x1, x0
00685E69C  ldr      x8, [x8]
00685E6A0  ldr      x9, [x9, #0xa98] ; GLOBAL Method$System.String.Join<int>() @ 0x92b0100
00685E6A4  mov      x0, x8
00685E6A8  ldr      x2, [x9]
00685E6AC  bl       #0x4702f28 ; System.String$$Join<int>
00685E6B0  cbz      x29, #0x685e9f8
00685E6B4  mov      x22, x0
00685E6B8  cbz      x0, #0x685e6d0
00685E6BC  ldr      x8, [x29]
00685E6C0  mov      x0, x22
00685E6C4  ldr      x1, [x8, #0x40]
00685E6C8  bl       #0x382be90 ; 
00685E6CC  cbz      x0, #0x685ec54
00685E6D0  ldr      w8, [x29, #0x18]
00685E6D4  cbz      w8, #0x685ec50
00685E6D8  mov      x0, x29
00685E6DC  str      x22, [x0, #0x20]!
00685E6E0  mov      x1, x22
00685E6E4  bl       #0x382bcb8 ; 
00685E6E8  adrp     x8, #0x8ebf000
00685E6EC  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685E6F0  add      x1, sp, #0x58
00685E6F4  str      w25, [sp, #0x58]
00685E6F8  ldr      x0, [x8]
00685E6FC  bl       #0x382be94 ; 
00685E700  mov      x22, x0
00685E704  cbz      x0, #0x685e71c
00685E708  ldr      x8, [x29]
00685E70C  mov      x0, x22
00685E710  ldr      x1, [x8, #0x40]
00685E714  bl       #0x382be90 ; 
00685E718  cbz      x0, #0x685ec54
00685E71C  ldr      w8, [x29, #0x18]
00685E720  cmp      w8, #1
00685E724  b.ls     #0x685ec50
00685E728  mov      x0, x29
00685E72C  str      x22, [x0, #0x28]!
00685E730  mov      x1, x22
00685E734  bl       #0x382bcb8 ; 
00685E738  adrp     x8, #0x8ec2000
00685E73C  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00685E740  mov      x0, x20
00685E744  mov      w1, w25
00685E748  ldr      x2, [x8]
00685E74C  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00685E750  adrp     x8, #0x8ebf000
00685E754  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685E758  str      w0, [sp, #0x54]
00685E75C  add      x1, sp, #0x54
00685E760  ldr      x8, [x8]
00685E764  mov      x0, x8
00685E768  bl       #0x382be94 ; 
00685E76C  mov      x22, x0
00685E770  cbz      x0, #0x685e788
00685E774  ldr      x8, [x29]
00685E778  mov      x0, x22
00685E77C  ldr      x1, [x8, #0x40]
00685E780  bl       #0x382be90 ; 
00685E784  cbz      x0, #0x685ec54
00685E788  ldr      w8, [x29, #0x18]
00685E78C  cmp      w8, #2
00685E790  b.ls     #0x685ec50
00685E794  mov      x0, x29
00685E798  str      x22, [x0, #0x30]!
00685E79C  mov      x1, x22
00685E7A0  bl       #0x382bcb8 ; 
00685E7A4  adrp     x8, #0x8f23000
00685E7A8  ldr      x8, [x8, #0xba8] ; GLOBAL Method$System.Linq.Enumerable.Last<int>() @ 0x92650b0
00685E7AC  mov      x0, x20
00685E7B0  ldr      x1, [x8]
00685E7B4  bl       #0x45ae18c ; System.Linq.Enumerable$$Last<int>
00685E7B8  adrp     x8, #0x8ebf000
00685E7BC  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
00685E7C0  str      w0, [sp, #0x50]
00685E7C4  add      x1, sp, #0x50
00685E7C8  ldr      x8, [x8]
00685E7CC  mov      x0, x8
00685E7D0  bl       #0x382be94 ; 
00685E7D4  mov      x22, x0
00685E7D8  cbz      x0, #0x685e7f0
00685E7DC  ldr      x8, [x29]
00685E7E0  mov      x0, x22
00685E7E4  ldr      x1, [x8, #0x40]
00685E7E8  bl       #0x382be90 ; 
00685E7EC  cbz      x0, #0x685ec54
00685E7F0  ldr      w8, [x29, #0x18]
00685E7F4  cmp      w8, #3
00685E7F8  b.ls     #0x685ec50
00685E7FC  mov      x0, x29
00685E800  str      x22, [x0, #0x38]!
00685E804  mov      x1, x22
00685E808  bl       #0x382bcb8 ; 
00685E80C  adrp     x8, #0x8f23000
00685E810  ldr      x8, [x8, #0xbd0] ; GLOBAL -[RandomSkill] 随机三个辅助技能结果 = {0}, 变化的index = {1} 变化前为 = {2}, 变化后为 = {3} @ 0x92eaba8
00685E814  mov      x1, x29
00685E818  mov      x2, xzr
00685E81C  ldr      x0, [x8]
00685E820  bl       #0x79e281c ; System.String$$Format
00685E824  mov      x1, x0
00685E828  mov      x0, x19
00685E82C  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
00685E830  adrp     x8, #0x8eeb000
00685E834  ldr      x8, [x8, #0xd28] ; GLOBAL Method$System.Linq.Enumerable.Count<int>() @ 0x9264c78
00685E838  mov      x0, x20
00685E83C  ldr      x1, [x8]
00685E840  bl       #0x45a3644 ; System.Linq.Enumerable$$Count<int>
00685E844  cmp      w0, w23
00685E848  b.ne     #0x685e950
00685E84C  adrp     x8, #0x8f23000
00685E850  ldr      x8, [x8, #0xba8] ; GLOBAL Method$System.Linq.Enumerable.Last<int>() @ 0x92650b0
00685E854  mov      x0, x20
00685E858  mov      w29, w23
00685E85C  ldr      x1, [x8]
00685E860  bl       #0x45ae18c ; System.Linq.Enumerable$$Last<int>
00685E864  mov      w22, w0
00685E868  mov      x0, x19
00685E86C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685E870  cbz      x0, #0x685e9f8
00685E874  adrp     x8, #0x9598000
00685E878  ldrb     w8, [x8, #0xfcc]
00685E87C  mov      x23, x0
00685E880  cbnz     w8, #0x685e898
00685E884  adrp     x0, #0x8f06000
00685E888  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00685E88C  bl       #0x382bd14 ; 
00685E890  adrp     x8, #0x9598000
00685E894  strb     w28, [x8, #0xfcc]
00685E898  adrp     x8, #0x8f06000
00685E89C  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00685E8A0  ldr      x1, [x8]
00685E8A4  ldrb     w8, [x1, #0x53]
00685E8A8  tbnz     w8, #5, #0x685e8b4
00685E8AC  ldr      x0, [x23, #0x200]
00685E8B0  b        #0x685e8c0 ; 
00685E8B4  ldr      x8, [x1, #0x60]
00685E8B8  mov      x0, x23
00685E8BC  blr      x8
00685E8C0  cbz      x0, #0x685e9f8
00685E8C4  mov      w1, w22
00685E8C8  mov      x2, xzr
00685E8CC  mov      w23, w29
00685E8D0  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
00685E8D4  mov      w1, wzr
00685E8D8  mov      x2, xzr
00685E8DC  mov      x22, x0
00685E8E0  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
00685E8E4  cmp      w0, #2
00685E8E8  b.eq     #0x685e904
00685E8EC  mov      x0, x22
00685E8F0  mov      w1, wzr
00685E8F4  mov      x2, xzr
00685E8F8  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
00685E8FC  cmp      w0, #3
00685E900  b.ne     #0x685e934
00685E904  adrp     x8, #0x8f23000
00685E908  ldr      x8, [x8, #0xba8] ; GLOBAL Method$System.Linq.Enumerable.Last<int>() @ 0x92650b0
00685E90C  mov      x0, x20
00685E910  ldr      x1, [x8]
00685E914  bl       #0x45ae18c ; System.Linq.Enumerable$$Last<int>
00685E918  adrp     x8, #0x8f0a000
00685E91C  ldr      x8, [x8, #0x9e8] ; GLOBAL Method$System.Collections.Generic.List<int>.set_Item() @ 0x921dee8
00685E920  mov      w2, w0
00685E924  mov      x0, x20
00685E928  mov      w1, w25
00685E92C  ldr      x3, [x8]
00685E930  bl       #0x4d642b8 ; System.Collections.Generic.List<int>$$set_Item
00685E934  adrp     x9, #0x8ed2000
00685E938  ldr      w8, [x20, #0x18]
00685E93C  ldr      x9, [x9, #0xdd8] ; GLOBAL Method$System.Collections.Generic.List<int>.RemoveAt() @ 0x921de98
00685E940  mov      x0, x20
00685E944  sub      w1, w8, #1
00685E948  ldr      x2, [x9]
00685E94C  bl       #0x4d6603c ; System.Collections.Generic.List<int>$$RemoveAt
00685E950  mov      x0, x19
00685E954  mov      x1, x20
00685E958  bl       #0x6860978 ; HotFix.BattleLogic.DankeSkillCreator$$GetChangeIndex
00685E95C  adds     w21, w21, #1
00685E960  mov      w25, w0
00685E964  b.lo     #0x685e620
00685E968  b        #0x685e984 ; 
00685E96C  ldr      x2, [sp, #0x30]
00685E970  mov      w8, #2
00685E974  sub      w3, w8, w26
00685E978  mov      x0, x19
00685E97C  mov      x1, x20
00685E980  bl       #0x68606ec ; HotFix.BattleLogic.SinglePlayerSkillCreator$$GetInginiteSkill
00685E984  ldr      w8, [sp, #0x2c]
00685E988  cbz      w8, #0x685ea08
00685E98C  ldr      x0, [x19, #0x70]
00685E990  cbz      x0, #0x685e9f8
00685E994  adrp     x22, #0x8f23000
00685E998  ldr      x22, [x22, #0xbc8] ; GLOBAL Method$System.Collections.Generic.List<NewPlayerBoostRecord>.get_Item() @ 0x921ebb0
00685E99C  mov      w21, wzr
00685E9A0  ldr      w8, [x0, #0x18]
00685E9A4  cmp      w21, w8
00685E9A8  b.ge     #0x685e9fc
00685E9AC  ldr      x2, [x22]
00685E9B0  mov      w1, w21
00685E9B4  bl       #0x4dacd78 ; System.Collections.Generic.List<NewPlayerBoostRecord>$$get_Item
00685E9B8  cbz      x24, #0x685e9f8
00685E9BC  ldr      w8, [x24, #0x18]
00685E9C0  cmp      w0, w8
00685E9C4  b.hs     #0x685ec50
00685E9C8  lsl      x8, x0, #0x20
00685E9CC  add      x8, x24, x8, asr #29
00685E9D0  ldr      x8, [x8, #0x20]
00685E9D4  cbz      x8, #0x685e9f8
00685E9D8  mov      x2, x1
00685E9DC  lsr      x1, x0, #0x20
00685E9E0  mov      x0, x8
00685E9E4  mov      x3, xzr
00685E9E8  bl       #0x6633908 ; HotFix.BattleLogic.WeightRandom$$RevertWeightBoost
00685E9EC  ldr      x0, [x19, #0x70]
00685E9F0  add      w21, w21, #1
00685E9F4  cbnz     x0, #0x685e9a0
00685E9F8  bl       #0x382bfb8 ; 
00685E9FC  ldr      w8, [x0, #0x1c]
00685EA00  add      w8, w8, #1
00685EA04  stp      wzr, w8, [x0, #0x18]
00685EA08  adrp     x8, #0x8eea000
00685EA0C  ldr      x8, [x8, #0xf18] ; GLOBAL Method$System.Collections.Generic.List<int>.ToArray() @ 0x921dec0
00685EA10  mov      x0, x20
00685EA14  ldr      x1, [x8]
00685EA18  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
00685EA1C  adrp     x8, #0x8ec2000
00685EA20  ldr      x8, [x8, #0x4e0] ; GLOBAL , @ 0x92ea038
00685EA24  adrp     x9, #0x8f09000
00685EA28  ldr      x9, [x9, #0xa98] ; GLOBAL Method$System.String.Join<int>() @ 0x92b0100
00685EA2C  mov      x1, x0
00685EA30  ldr      x8, [x8]
00685EA34  ldr      x2, [x9]
00685EA38  mov      x0, x8
00685EA3C  bl       #0x4702f28 ; System.String$$Join<int>
00685EA40  adrp     x8, #0x8f23000
00685EA44  ldr      x8, [x8, #0xbd8] ; GLOBAL -[RandomSkill] 随机技能结果 =  @ 0x92eabd0
00685EA48  mov      x1, x0
00685EA4C  mov      x2, xzr
00685EA50  ldr      x8, [x8]
00685EA54  mov      x0, x8
00685EA58  bl       #0x79d469c ; System.String$$Concat
00685EA5C  mov      x1, x0
00685EA60  mov      x0, x19
00685EA64  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
00685EA68  ldr      w0, [sp, #0x40]
00685EA6C  ldp      x20, x19, [sp, #0xc0]
00685EA70  ldp      x22, x21, [sp, #0xb0]
00685EA74  ldp      x24, x23, [sp, #0xa0]
00685EA78  ldp      x26, x25, [sp, #0x90]
00685EA7C  ldp      x28, x27, [sp, #0x80]
00685EA80  ldp      x29, x30, [sp, #0x70]
00685EA84  add      sp, sp, #0xd0
00685EA88  ret      
00685EA8C  ldr      x8, [x19, #0x70]
00685EA90  cbz      x8, #0x685e9f8
00685EA94  ldr      w9, [x8, #0x1c]
00685EA98  adrp     x29, #0x8f23000
00685EA9C  ldr      x29, [x29, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<NewPlayerBoostRecord>.Add() @ 0x921eb98
00685EAA0  mov      w28, wzr
00685EAA4  add      w9, w9, #1
00685EAA8  mov      w21, wzr
00685EAAC  stp      wzr, w9, [x8, #0x18]
00685EAB0  ldr      x0, [x25]
00685EAB4  ldr      w8, [x0, #0xe0]
00685EAB8  cbnz     w8, #0x685eac4
00685EABC  bl       #0x382be8c ; 
00685EAC0  ldr      x0, [x25]
00685EAC4  ldr      x8, [x0, #0xb8]
00685EAC8  ldr      x8, [x8, #0x498]
00685EACC  cbz      x8, #0x685e9f8
00685EAD0  ldr      w9, [x8, #0x18]
00685EAD4  cmp      w28, w9
00685EAD8  b.ge     #0x685ec44
00685EADC  ldr      w9, [x0, #0xe0]
00685EAE0  cbnz     w9, #0x685eaf8
00685EAE4  bl       #0x382be8c ; 
00685EAE8  ldr      x8, [x25]
00685EAEC  ldr      x8, [x8, #0xb8]
00685EAF0  ldr      x8, [x8, #0x498]
00685EAF4  cbz      x8, #0x685e9f8
00685EAF8  ldr      w9, [x8, #0x18]
00685EAFC  cmp      w28, w9
00685EB00  b.hs     #0x685ec50
00685EB04  add      x8, x8, w28, sxtw #3
00685EB08  ldr      x0, [x8, #0x20]
00685EB0C  cbz      x0, #0x685e9f8
00685EB10  mov      w1, #0x7c
00685EB14  mov      w2, wzr
00685EB18  mov      x3, xzr
00685EB1C  bl       #0x79e4950 ; System.String$$Split
00685EB20  cbz      x0, #0x685e9f8
00685EB24  ldr      w8, [x0, #0x18]
00685EB28  mov      x23, x0
00685EB2C  cmp      w8, #2
00685EB30  b.lt     #0x685ec38
00685EB34  ldr      x0, [x23, #0x20]
00685EB38  mov      x1, xzr
00685EB3C  bl       #0x7bd25d0 ; System.Int32$$Parse
00685EB40  ldr      w8, [x23, #0x18]
00685EB44  cmp      w8, #1
00685EB48  b.ls     #0x685ec50
00685EB4C  mov      w22, w0
00685EB50  ldr      x0, [x23, #0x28]
00685EB54  mov      x1, xzr
00685EB58  bl       #0x7bd25d0 ; System.Int32$$Parse
00685EB5C  cbz      x24, #0x685e9f8
00685EB60  ldr      w8, [x24, #0x18]
00685EB64  cmp      w8, #1
00685EB68  b.lt     #0x685ec38
00685EB6C  mov      w26, w0
00685EB70  mov      w27, wzr
00685EB74  cmp      w27, w8
00685EB78  b.hs     #0x685ec50
00685EB7C  add      x8, x24, w27, sxtw #3
00685EB80  ldr      x0, [x8, #0x20]
00685EB84  cbz      x0, #0x685e9f8
00685EB88  mov      w1, w22
00685EB8C  mov      w2, w26
00685EB90  mov      x3, xzr
00685EB94  bl       #0x6633824 ; HotFix.BattleLogic.WeightRandom$$BoostWeightByPercent
00685EB98  cmp      w0, #1
00685EB9C  b.lt     #0x685ec28
00685EBA0  ldr      x23, [x19, #0x70]
00685EBA4  mov      w3, w0
00685EBA8  add      x0, sp, #0x58
00685EBAC  mov      w1, w27
00685EBB0  mov      w2, w22
00685EBB4  str      wzr, [sp, #0x60]
00685EBB8  str      xzr, [sp, #0x58]
00685EBBC  bl       #0x685ec60 ; HotFix.BattleLogic.NewPlayerBoostRecord$$.ctor
00685EBC0  cbz      x23, #0x685e9f8
00685EBC4  ldr      w10, [x23, #0x1c]
00685EBC8  ldr      x1, [sp, #0x58]
00685EBCC  ldr      w2, [sp, #0x60]
00685EBD0  ldr      x8, [x23, #0x10]
00685EBD4  ldr      x9, [x29]
00685EBD8  add      w10, w10, #1
00685EBDC  str      w10, [x23, #0x1c]
00685EBE0  cbz      x8, #0x685e9f8
00685EBE4  ldrsw    x10, [x23, #0x18]
00685EBE8  ldr      w11, [x8, #0x18]
00685EBEC  cmp      w10, w11
00685EBF0  b.hs     #0x685ec10
00685EBF4  mov      w11, #0xc
00685EBF8  add      w9, w10, #1
00685EBFC  madd     x8, x10, x11, x8
00685EC00  str      w9, [x23, #0x18]
00685EC04  str      x1, [x8, #0x20]
00685EC08  str      w2, [x8, #0x28]
00685EC0C  b        #0x685ec24 ; 
00685EC10  ldr      x8, [x9, #0x20]
00685EC14  mov      x0, x23
00685EC18  ldr      x8, [x8, #0xc0]
00685EC1C  ldr      x3, [x8, #0x70]
00685EC20  bl       #0x4dad0a0 ; System.Collections.Generic.List<NewPlayerBoostRecord>$$AddWithResize
00685EC24  mov      w21, #1
00685EC28  ldr      w8, [x24, #0x18]
00685EC2C  add      w27, w27, #1
00685EC30  cmp      w27, w8
00685EC34  b.lt     #0x685eb74
00685EC38  ldr      x26, [sp, #0x30]
00685EC3C  add      w28, w28, #1
00685EC40  b        #0x685eab0 ; 
00685EC44  and      w8, w21, #1
00685EC48  str      w8, [sp, #0x2c]
00685EC4C  b        #0x685e3b8 ; 
00685EC50  bl       #0x382bfc0 ; 
00685EC54  bl       #0x382bfdc ; 
00685EC58  mov      x1, xzr
00685EC5C  bl       #0x382be7c ; 

