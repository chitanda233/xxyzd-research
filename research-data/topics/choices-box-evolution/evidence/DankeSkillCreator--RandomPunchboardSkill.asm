; HotFix.BattleLogic.DankeSkillCreator$$RandomPunchboardSkill
; RVA 0x6863D14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006863D14  sub      sp, sp, #0x140
006863D18  stp      x29, x30, [sp, #0xe0]
006863D1C  stp      x28, x27, [sp, #0xf0]
006863D20  stp      x26, x25, [sp, #0x100]
006863D24  stp      x24, x23, [sp, #0x110]
006863D28  stp      x22, x21, [sp, #0x120]
006863D2C  stp      x20, x19, [sp, #0x130]
006863D30  ldr      w9, [sp, #0x140]
006863D34  stp      w2, w7, [sp, #0x58]
006863D38  stp      w4, w5, [sp, #0x40]
006863D3C  str      x3, [sp, #0x48]
006863D40  adrp     x20, #0x959b000
006863D44  str      w9, [sp, #0x54]
006863D48  adrp     x21, #0x8f23000
006863D4C  ldrb     w8, [x20, #0x9fd]
006863D50  ldr      x21, [x21, #0xd78] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.RandomPunchboardSkill() @ 0x9259de0
006863D54  mov      x25, x6
006863D58  mov      x23, x1
006863D5C  mov      x19, x0
006863D60  tbnz     w8, #0, #0x6863eec
006863D64  adrp     x0, #0x8f23000
006863D68  ldr      x0, [x0, #0xd78] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.RandomPunchboardSkill() @ 0x9259de0
006863D6C  bl       #0x382bd14 ; 
006863D70  adrp     x0, #0x8eea000
006863D74  ldr      x0, [x0, #0xf0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.Clear() @ 0x920b048
006863D78  bl       #0x382bd14 ; 
006863D7C  adrp     x0, #0x8f09000
006863D80  ldr      x0, [x0, #0x238] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.GetEnumerator() @ 0x920b060
006863D84  bl       #0x382bd14 ; 
006863D88  adrp     x0, #0x8ee3000
006863D8C  ldr      x0, [x0, #0xfb0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>..ctor() @ 0x920b020
006863D90  bl       #0x382bd14 ; 
006863D94  adrp     x0, #0x8f1e000
006863D98  ldr      x0, [x0, #0x4d0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.get_Count() @ 0x920b080
006863D9C  bl       #0x382bd14 ; 
006863DA0  adrp     x0, #0x8ee3000
006863DA4  ldr      x0, [x0, #0xfa0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.set_Item() @ 0x920b0a0
006863DA8  bl       #0x382bd14 ; 
006863DAC  adrp     x0, #0x8ee3000
006863DB0  ldr      x0, [x0, #0xfa8] ; GLOBAL System.Collections.Generic.Dictionary<int, int>_TypeInfo @ 0x91d1c50
006863DB4  bl       #0x382bd14 ; 
006863DB8  adrp     x0, #0x8f09000
006863DBC  ldr      x0, [x0, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006863DC0  bl       #0x382bd14 ; 
006863DC4  adrp     x0, #0x8f09000
006863DC8  ldr      x0, [x0, #0x258] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.MoveNext() @ 0x9214798
006863DCC  bl       #0x382bd14 ; 
006863DD0  adrp     x0, #0x8f09000
006863DD4  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.get_Current() @ 0x92147a0
006863DD8  bl       #0x382bd14 ; 
006863DDC  adrp     x0, #0x8ebf000
006863DE0  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006863DE4  bl       #0x382bd14 ; 
006863DE8  adrp     x0, #0x8ee6000
006863DEC  ldr      x0, [x0, #0xf00] ; GLOBAL Method$System.Collections.Generic.KeyValuePair<int, int>.get_Key() @ 0x9217b08
006863DF0  bl       #0x382bd14 ; 
006863DF4  adrp     x0, #0x8ee6000
006863DF8  ldr      x0, [x0, #0xf08] ; GLOBAL Method$System.Collections.Generic.KeyValuePair<int, int>.get_Value() @ 0x9217b10
006863DFC  bl       #0x382bd14 ; 
006863E00  adrp     x0, #0x8f08000
006863E04  ldr      x0, [x0, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
006863E08  bl       #0x382bd14 ; 
006863E0C  adrp     x0, #0x8ec2000
006863E10  ldr      x0, [x0, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
006863E14  bl       #0x382bd14 ; 
006863E18  adrp     x0, #0x8ec2000
006863E1C  ldr      x0, [x0, #0x240] ; GLOBAL Method$System.Collections.Generic.List<int>.Clear() @ 0x921de58
006863E20  bl       #0x382bd14 ; 
006863E24  adrp     x0, #0x8f08000
006863E28  ldr      x0, [x0, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
006863E2C  bl       #0x382bd14 ; 
006863E30  adrp     x0, #0x8eea000
006863E34  ldr      x0, [x0, #0xf18] ; GLOBAL Method$System.Collections.Generic.List<int>.ToArray() @ 0x921dec0
006863E38  bl       #0x382bd14 ; 
006863E3C  adrp     x0, #0x8ec2000
006863E40  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
006863E44  bl       #0x382bd14 ; 
006863E48  adrp     x0, #0x8ec2000
006863E4C  ldr      x0, [x0, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006863E50  bl       #0x382bd14 ; 
006863E54  adrp     x0, #0x8ee1000
006863E58  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006863E5C  bl       #0x382bd14 ; 
006863E60  adrp     x0, #0x8f09000
006863E64  ldr      x0, [x0, #0xa98] ; GLOBAL Method$System.String.Join<int>() @ 0x92b0100
006863E68  bl       #0x382bd14 ; 
006863E6C  adrp     x0, #0x8f23000
006863E70  ldr      x0, [x0, #0xca8] ; GLOBAL Method$HotFix.Common.XDictionaryHelper.Get<int, int>() @ 0x92cfb30
006863E74  bl       #0x382bd14 ; 
006863E78  adrp     x0, #0x8f23000
006863E7C  ldr      x0, [x0, #0xcb0] ; GLOBAL Method$HotFix.Common.XDictionaryHelper.Push<int, int>() @ 0x92cfb40
006863E80  bl       #0x382bd14 ; 
006863E84  adrp     x0, #0x8f08000
006863E88  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
006863E8C  bl       #0x382bd14 ; 
006863E90  adrp     x0, #0x8f08000
006863E94  ldr      x0, [x0, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
006863E98  bl       #0x382bd14 ; 
006863E9C  adrp     x0, #0x8f23000
006863EA0  ldr      x0, [x0, #0xd80] ; GLOBAL [Temp]-[RandomSkill]-[Danke] doSub  AllSkills =  @ 0x9318ff0
006863EA4  bl       #0x382bd14 ; 
006863EA8  adrp     x0, #0x8f23000
006863EAC  ldr      x0, [x0, #0xd88] ; GLOBAL RandomPunchboardSkill @ 0x930b030
006863EB0  bl       #0x382bd14 ; 
006863EB4  adrp     x0, #0x8f23000
006863EB8  ldr      x0, [x0, #0xd90] ; GLOBAL addSkillId is null  @ 0x931af08
006863EBC  bl       #0x382bd14 ; 
006863EC0  adrp     x0, #0x8f23000
006863EC4  ldr      x0, [x0, #0xc80] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\DankeSkillCreator.cs @ 0x92f8028
006863EC8  bl       #0x382bd14 ; 
006863ECC  adrp     x0, #0x8ec2000
006863ED0  ldr      x0, [x0, #0x4e0] ; GLOBAL , @ 0x92ea038
006863ED4  bl       #0x382bd14 ; 
006863ED8  adrp     x0, #0x8f23000
006863EDC  ldr      x0, [x0, #0xd98] ; GLOBAL [Temp]-[RandomSkill]-[Danke] doSub deepType = {0}  curSkill = {1}  coverSkill = {2} @ 0x9318ff8
006863EE0  bl       #0x382bd14 ; 
006863EE4  mov      w8, #1
006863EE8  strb     w8, [x20, #0x9fd]
006863EEC  ldr      x8, [x21]
006863EF0  ldrb     w9, [x8, #0x53]
006863EF4  tbnz     w9, #5, #0x6863f50
006863EF8  movi     v0.2d, #0000000000000000
006863EFC  mov      x0, x19
006863F00  stp      q0, q0, [sp, #0xc0]
006863F04  str      wzr, [sp, #0xbc]
006863F08  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006863F0C  cbz      x0, #0x68653dc
006863F10  adrp     x21, #0x959a000
006863F14  ldrb     w8, [x21, #0xc8e]
006863F18  mov      x20, x0
006863F1C  cbnz     w8, #0x6863f34
006863F20  adrp     x0, #0x8f19000
006863F24  ldr      x0, [x0, #0x910] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DictionaryPool() @ 0x923feb0
006863F28  bl       #0x382bd14 ; 
006863F2C  mov      w8, #1
006863F30  strb     w8, [x21, #0xc8e]
006863F34  adrp     x8, #0x8f19000
006863F38  ldr      x8, [x8, #0x910] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DictionaryPool() @ 0x923feb0
006863F3C  ldr      x1, [x8]
006863F40  ldrb     w8, [x1, #0x53]
006863F44  tbnz     w8, #5, #0x6863fa4
006863F48  ldr      x0, [x20, #0x250]
006863F4C  b        #0x6863fb0 ; 
006863F50  ldr      x9, [x8, #0x60]
006863F54  str      x8, [sp, #0x148]
006863F58  ldr      w8, [sp, #0x40]
006863F5C  mov      x0, x19
006863F60  mov      x1, x23
006863F64  ldr      x3, [sp, #0x48]
006863F68  and      w4, w8, #1
006863F6C  ldr      w8, [sp, #0x44]
006863F70  mov      x6, x25
006863F74  ldr      w7, [sp, #0x5c]
006863F78  ldp      x20, x19, [sp, #0x130]
006863F7C  and      w5, w8, #1
006863F80  ldp      w8, w2, [sp, #0x54]
006863F84  ldp      x22, x21, [sp, #0x120]
006863F88  ldp      x24, x23, [sp, #0x110]
006863F8C  ldp      x26, x25, [sp, #0x100]
006863F90  ldp      x28, x27, [sp, #0xf0]
006863F94  ldp      x29, x30, [sp, #0xe0]
006863F98  str      w8, [sp, #0x140]
006863F9C  add      sp, sp, #0x140
006863FA0  br       x9
006863FA4  ldr      x8, [x1, #0x60]
006863FA8  mov      x0, x20
006863FAC  blr      x8
006863FB0  cbz      x0, #0x68653dc
006863FB4  adrp     x8, #0x8f23000
006863FB8  ldr      x8, [x8, #0xca8] ; GLOBAL Method$HotFix.Common.XDictionaryHelper.Get<int, int>() @ 0x92cfb30
006863FBC  ldr      x1, [x8]
006863FC0  bl       #0x47831d8 ; HotFix.Common.XDictionaryHelper$$Get<int, int>
006863FC4  str      x0, [sp, #0x88]
006863FC8  mov      x0, x19
006863FCC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006863FD0  cbz      x0, #0x68653dc
006863FD4  adrp     x22, #0x9591000
006863FD8  ldrb     w8, [x22, #0xa90]
006863FDC  mov      x20, x0
006863FE0  cbnz     w8, #0x6863ff8
006863FE4  adrp     x0, #0x8ee6000
006863FE8  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006863FEC  bl       #0x382bd14 ; 
006863FF0  mov      w8, #1
006863FF4  strb     w8, [x22, #0xa90]
006863FF8  adrp     x24, #0x8ee6000
006863FFC  ldr      x24, [x24, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006864000  ldr      x1, [x24]
006864004  ldrb     w8, [x1, #0x53]
006864008  tbnz     w8, #5, #0x6864014
00686400C  ldr      x0, [x20, #0x230]
006864010  b        #0x6864020 ; 
006864014  ldr      x8, [x1, #0x60]
006864018  mov      x0, x20
00686401C  blr      x8
006864020  cbz      x0, #0x68653dc
006864024  adrp     x21, #0x8f08000
006864028  ldr      x21, [x21, #0xbb8] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Get<int>() @ 0x92cfd68
00686402C  ldr      x1, [x21]
006864030  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006864034  mov      x28, x0
006864038  mov      x0, x19
00686403C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006864040  cbz      x0, #0x68653dc
006864044  ldrb     w8, [x22, #0xa90]
006864048  mov      x20, x0
00686404C  cbnz     w8, #0x6864064
006864050  adrp     x0, #0x8ee6000
006864054  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006864058  bl       #0x382bd14 ; 
00686405C  mov      w8, #1
006864060  strb     w8, [x22, #0xa90]
006864064  ldr      x1, [x24]
006864068  ldrb     w8, [x1, #0x53]
00686406C  tbnz     w8, #5, #0x6864078
006864070  ldr      x0, [x20, #0x230]
006864074  b        #0x6864084 ; 
006864078  ldr      x8, [x1, #0x60]
00686407C  mov      x0, x20
006864080  blr      x8
006864084  cbz      x0, #0x68653dc
006864088  ldr      x1, [x21]
00686408C  bl       #0x4784c3c ; HotFix.Common.XListPoolHelper$$Get<int>
006864090  adrp     x8, #0x8ee3000
006864094  ldr      x8, [x8, #0xfa8] ; GLOBAL System.Collections.Generic.Dictionary<int, int>_TypeInfo @ 0x91d1c50
006864098  str      x0, [sp, #0x60]
00686409C  ldr      x8, [x8]
0068640A0  mov      x0, x8
0068640A4  bl       #0x382bfa0 ; 
0068640A8  adrp     x8, #0x8ee3000
0068640AC  ldr      x8, [x8, #0xfb0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>..ctor() @ 0x920b020
0068640B0  str      x0, [sp, #0x78]
0068640B4  ldr      x1, [x8]
0068640B8  bl       #0x5e2737c ; System.Collections.Generic.Dictionary<int, int>$$.ctor
0068640BC  cbz      x23, #0x68653dc
0068640C0  ldr      w8, [sp, #0x58]
0068640C4  cmp      w8, #1
0068640C8  b.lt     #0x686527c
0068640CC  ldr      w8, [x23, #0x18]
0068640D0  adrp     x29, #0x8f08000
0068640D4  adrp     x20, #0x8f00000
0068640D8  adrp     x26, #0x8f09000
0068640DC  str      w8, [sp, #0x3c]
0068640E0  add      x8, x19, #0x60
0068640E4  str      x8, [sp, #0x30]
0068640E8  ldr      x29, [x29, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
0068640EC  ldr      x20, [x20, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
0068640F0  ldr      x26, [x26, #0x258] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.MoveNext() @ 0x9214798
0068640F4  mov      w9, wzr
0068640F8  adrp     x24, #0x9598000
0068640FC  str      x25, [sp, #0x80]
006864100  str      x23, [sp, #0x70]
006864104  ldr      w8, [sp, #0x54]
006864108  ldr      x3, [x19, #0x28]
00686410C  str      w9, [sp, #0x6c]
006864110  ldr      x5, [sp, #0x30]
006864114  str      w8, [sp, #0x10]
006864118  ldr      w8, [sp, #0x5c]
00686411C  ldr      x6, [sp, #0x48]
006864120  mov      w4, #1
006864124  mov      x0, x19
006864128  str      w8, [sp, #8]
00686412C  ldp      w9, w8, [sp, #0x40]
006864130  mov      x1, x23
006864134  mov      x2, x25
006864138  strb     wzr, [sp, #0x18]
00686413C  and      w8, w8, #1
006864140  and      w7, w9, #1
006864144  strb     w8, [sp]
006864148  bl       #0x685f434 ; HotFix.BattleLogic.DankeSkillCreator$$GetRandomSkills
00686414C  ldr      w9, [sp, #0x6c]
006864150  ldr      w10, [sp, #0x3c]
006864154  ldr      w8, [x23, #0x18]
006864158  add      w1, w9, w10
00686415C  add      w9, w1, #1
006864160  cmp      w8, w9
006864164  b.ne     #0x686527c
006864168  adrp     x8, #0x8ec2000
00686416C  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
006864170  mov      x0, x23
006864174  ldr      x2, [x8]
006864178  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
00686417C  mov      w27, w0
006864180  mov      x0, x19
006864184  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006864188  cbz      x0, #0x68653dc
00686418C  adrp     x8, #0x9598000
006864190  ldrb     w8, [x8, #0xfcc]
006864194  mov      x22, x0
006864198  cbnz     w8, #0x68641b4
00686419C  adrp     x0, #0x8f06000
0068641A0  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068641A4  bl       #0x382bd14 ; 
0068641A8  mov      w8, #1
0068641AC  adrp     x9, #0x9598000
0068641B0  strb     w8, [x9, #0xfcc]
0068641B4  adrp     x8, #0x8f06000
0068641B8  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068641BC  ldr      x1, [x8]
0068641C0  ldrb     w8, [x1, #0x53]
0068641C4  tbnz     w8, #5, #0x68641d0
0068641C8  ldr      x0, [x22, #0x200]
0068641CC  b        #0x68641dc ; 
0068641D0  ldr      x8, [x1, #0x60]
0068641D4  mov      x0, x22
0068641D8  blr      x8
0068641DC  cbz      x0, #0x68653dc
0068641E0  mov      w1, w27
0068641E4  mov      x2, xzr
0068641E8  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
0068641EC  mov      w1, #1
0068641F0  mov      x2, xzr
0068641F4  mov      x23, x0
0068641F8  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
0068641FC  cbz      x23, #0x68653dc
006864200  adrp     x8, #0x959b000
006864204  ldrb     w8, [x8, #0xb8b]
006864208  mov      w22, w0
00686420C  cbnz     w8, #0x6864228
006864210  adrp     x0, #0x8f23000
006864214  ldr      x0, [x0, #0xda0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_CoverSkill() @ 0x92ac410
006864218  bl       #0x382bd14 ; 
00686421C  mov      w8, #1
006864220  adrp     x9, #0x959b000
006864224  strb     w8, [x9, #0xb8b]
006864228  adrp     x8, #0x8f23000
00686422C  ldr      x8, [x8, #0xda0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_CoverSkill() @ 0x92ac410
006864230  ldr      x1, [x8]
006864234  ldrb     w8, [x1, #0x53]
006864238  tbnz     w8, #5, #0x6864244
00686423C  ldr      w1, [x23, #0xa0]
006864240  b        #0x6864254 ; 
006864244  ldr      x8, [x1, #0x60]
006864248  mov      x0, x23
00686424C  blr      x8
006864250  mov      w1, w0
006864254  cbz      x25, #0x68653dc
006864258  ldr      x2, [x29]
00686425C  mov      x0, x25
006864260  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006864264  tbnz     w0, #0, #0x68642c8
006864268  adrp     x8, #0x959b000
00686426C  ldrb     w8, [x8, #0xb8b]
006864270  cbnz     w8, #0x686428c
006864274  adrp     x0, #0x8f23000
006864278  ldr      x0, [x0, #0xda0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_CoverSkill() @ 0x92ac410
00686427C  bl       #0x382bd14 ; 
006864280  mov      w8, #1
006864284  adrp     x9, #0x959b000
006864288  strb     w8, [x9, #0xb8b]
00686428C  adrp     x8, #0x8f23000
006864290  ldr      x8, [x8, #0xda0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_CoverSkill() @ 0x92ac410
006864294  ldr      x1, [x8]
006864298  ldrb     w8, [x1, #0x53]
00686429C  tbnz     w8, #5, #0x68642a8
0068642A0  ldr      w1, [x23, #0xa0]
0068642A4  b        #0x68642b8 ; 
0068642A8  ldr      x8, [x1, #0x60]
0068642AC  mov      x0, x23
0068642B0  blr      x8
0068642B4  mov      w1, w0
0068642B8  ldr      x2, [x29]
0068642BC  ldr      x0, [sp, #0x70]
0068642C0  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
0068642C4  tbz      w0, #0, #0x6864374
0068642C8  ldr      x0, [sp, #0x88]
0068642CC  cbz      x0, #0x68653dc
0068642D0  adrp     x8, #0x8eea000
0068642D4  ldr      x8, [x8, #0xf0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.Clear() @ 0x920b048
0068642D8  ldr      x1, [x8]
0068642DC  bl       #0x5e282e0 ; System.Collections.Generic.Dictionary<int, int>$$Clear
0068642E0  adrp     x8, #0x9598000
0068642E4  ldrb     w8, [x8, #0x35e]
0068642E8  cbnz     w8, #0x6864304
0068642EC  adrp     x0, #0x8ef9000
0068642F0  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0068642F4  bl       #0x382bd14 ; 
0068642F8  mov      w8, #1
0068642FC  adrp     x9, #0x9598000
006864300  strb     w8, [x9, #0x35e]
006864304  adrp     x8, #0x8ef9000
006864308  ldr      x8, [x8, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
00686430C  ldr      x1, [x8]
006864310  ldrb     w8, [x1, #0x53]
006864314  tbnz     w8, #5, #0x6864320
006864318  ldr      w0, [x23, #0x68]
00686431C  b        #0x686432c ; 
006864320  ldr      x8, [x1, #0x60]
006864324  mov      x0, x23
006864328  blr      x8
00686432C  cmp      w0, #4
006864330  b.eq     #0x686449c
006864334  adrp     x8, #0x9598000
006864338  ldrb     w8, [x8, #0x35e]
00686433C  cbnz     w8, #0x6864358
006864340  adrp     x0, #0x8ef9000
006864344  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006864348  bl       #0x382bd14 ; 
00686434C  mov      w8, #1
006864350  adrp     x9, #0x9598000
006864354  strb     w8, [x9, #0x35e]
006864358  adrp     x8, #0x8ef9000
00686435C  ldr      x8, [x8, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006864360  ldr      x1, [x8]
006864364  ldrb     w8, [x1, #0x53]
006864368  tbnz     w8, #5, #0x6864488
00686436C  ldr      w0, [x23, #0x68]
006864370  b        #0x6864494 ; 
006864374  cmp      w22, #2
006864378  b.eq     #0x6864ed8
00686437C  ldr      x0, [sp, #0x88]
006864380  cmp      w22, #1
006864384  b.ne     #0x68642cc
006864388  ldr      w8, [sp, #0x5c]
00686438C  subs     w8, w8, #1
006864390  str      w8, [sp, #0x5c]
006864394  b.pl     #0x68642cc
006864398  adrp     x8, #0x8eea000
00686439C  ldr      x8, [x8, #0xf18] ; GLOBAL Method$System.Collections.Generic.List<int>.ToArray() @ 0x921dec0
0068643A0  mov      x0, x25
0068643A4  ldr      x1, [x8]
0068643A8  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
0068643AC  adrp     x8, #0x8ec2000
0068643B0  ldr      x8, [x8, #0x4e0] ; GLOBAL , @ 0x92ea038
0068643B4  adrp     x9, #0x8f09000
0068643B8  mov      x1, x0
0068643BC  ldr      x8, [x8]
0068643C0  ldr      x9, [x9, #0xa98] ; GLOBAL Method$System.String.Join<int>() @ 0x92b0100
0068643C4  mov      x0, x8
0068643C8  ldr      x2, [x9]
0068643CC  bl       #0x4702f28 ; System.String$$Join<int>
0068643D0  adrp     x8, #0x8f23000
0068643D4  ldr      x8, [x8, #0xd80] ; GLOBAL [Temp]-[RandomSkill]-[Danke] doSub  AllSkills =  @ 0x9318ff0
0068643D8  mov      x1, x0
0068643DC  mov      x2, xzr
0068643E0  ldr      x8, [x8]
0068643E4  mov      x0, x8
0068643E8  bl       #0x79d469c ; System.String$$Concat
0068643EC  mov      x1, x0
0068643F0  mov      x0, x19
0068643F4  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
0068643F8  adrp     x21, #0x8ebf000
0068643FC  ldr      x21, [x21, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006864400  mov      w8, #1
006864404  ldr      x0, [x21]
006864408  add      x1, sp, #0x90
00686440C  str      w8, [sp, #0x90]
006864410  bl       #0x382be94 ; 
006864414  adrp     x8, #0x8ec2000
006864418  ldr      x8, [x8, #0x270] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Item() @ 0x921ded8
00686441C  mov      x25, x0
006864420  ldr      x0, [sp, #0x70]
006864424  ldr      w1, [sp, #0x6c]
006864428  ldr      x2, [x8]
00686442C  bl       #0x4d64264 ; System.Collections.Generic.List<int>$$get_Item
006864430  ldr      x8, [x21]
006864434  str      w0, [sp, #0xb8]
006864438  add      x1, sp, #0xb8
00686443C  mov      x0, x8
006864440  bl       #0x382be94 ; 
006864444  adrp     x8, #0x959b000
006864448  ldrb     w8, [x8, #0xb8b]
00686444C  mov      x21, x0
006864450  cbnz     w8, #0x686446c
006864454  adrp     x0, #0x8f23000
006864458  ldr      x0, [x0, #0xda0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_CoverSkill() @ 0x92ac410
00686445C  bl       #0x382bd14 ; 
006864460  mov      w8, #1
006864464  adrp     x9, #0x959b000
006864468  strb     w8, [x9, #0xb8b]
00686446C  adrp     x8, #0x8f23000
006864470  ldr      x8, [x8, #0xda0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_CoverSkill() @ 0x92ac410
006864474  ldr      x1, [x8]
006864478  ldrb     w8, [x1, #0x53]
00686447C  tbnz     w8, #5, #0x6864f80
006864480  ldr      w0, [x23, #0xa0]
006864484  b        #0x6864f8c ; 
006864488  ldr      x8, [x1, #0x60]
00686448C  mov      x0, x23
006864490  blr      x8
006864494  cmp      w0, #5
006864498  b.ne     #0x6864728
00686449C  mov      x0, x19
0068644A0  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068644A4  cbz      x0, #0x68653dc
0068644A8  adrp     x8, #0x9598000
0068644AC  ldrb     w8, [x8, #0xfcc]
0068644B0  mov      x25, x0
0068644B4  cbnz     w8, #0x68644d0
0068644B8  adrp     x0, #0x8f06000
0068644BC  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068644C0  bl       #0x382bd14 ; 
0068644C4  mov      w8, #1
0068644C8  adrp     x9, #0x9598000
0068644CC  strb     w8, [x9, #0xfcc]
0068644D0  adrp     x8, #0x8f06000
0068644D4  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068644D8  ldr      x1, [x8]
0068644DC  ldrb     w8, [x1, #0x53]
0068644E0  tbnz     w8, #5, #0x68644ec
0068644E4  ldr      x25, [x25, #0x200]
0068644E8  b        #0x68644fc ; 
0068644EC  ldr      x8, [x1, #0x60]
0068644F0  mov      x0, x25
0068644F4  blr      x8
0068644F8  mov      x25, x0
0068644FC  ldrb     w8, [x24, #0xde3]
006864500  cbnz     w8, #0x6864514
006864504  mov      x0, x20
006864508  bl       #0x382bd14 ; 
00686450C  mov      w8, #1
006864510  strb     w8, [x24, #0xde3]
006864514  ldr      x1, [x20]
006864518  ldrb     w8, [x1, #0x53]
00686451C  tbnz     w8, #5, #0x6864528
006864520  ldr      w3, [x23, #0x20]
006864524  b        #0x6864538 ; 
006864528  ldr      x8, [x1, #0x60]
00686452C  mov      x0, x23
006864530  blr      x8
006864534  mov      w3, w0
006864538  ldr      x1, [sp, #0x80]
00686453C  ldr      x2, [sp, #0x70]
006864540  ldr      x4, [sp, #0x60]
006864544  mov      x0, x25
006864548  mov      x5, xzr
00686454C  bl       #0x692b9a8 ; HotFix.BattleLogic.SkillTableHelper$$GetPunchboardParentSkillId
006864550  ldr      x8, [x19, #0x30]
006864554  cbz      x8, #0x68653dc
006864558  ldr      w9, [x8, #0x18]
00686455C  cmp      w22, w9
006864560  b.hs     #0x68653e0
006864564  sxtw     x21, w22
006864568  add      x8, x8, x21, lsl #3
00686456C  mov      w25, w0
006864570  ldr      x0, [x8, #0x20]
006864574  cbz      x0, #0x68653dc
006864578  mov      w1, w25
00686457C  mov      w2, wzr
006864580  mov      x3, xzr
006864584  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
006864588  ldr      x8, [x19, #0x38]
00686458C  cbz      x8, #0x68653dc
006864590  ldr      w9, [x8, #0x18]
006864594  cmp      w22, w9
006864598  b.hs     #0x68653e0
00686459C  add      x8, x8, x21, lsl #3
0068645A0  ldr      x0, [x8, #0x20]
0068645A4  cbz      x0, #0x68653dc
0068645A8  mov      w1, w25
0068645AC  mov      w2, wzr
0068645B0  mov      x3, xzr
0068645B4  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
0068645B8  ldr      x8, [x19, #0x28]
0068645BC  cbz      x8, #0x68653dc
0068645C0  ldr      w9, [x8, #0x18]
0068645C4  cmp      w22, w9
0068645C8  b.hs     #0x68653e0
0068645CC  add      x8, x8, x21, lsl #3
0068645D0  ldr      x0, [x8, #0x20]
0068645D4  cbz      x0, #0x68653dc
0068645D8  mov      w1, w25
0068645DC  mov      w2, wzr
0068645E0  mov      x3, xzr
0068645E4  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
0068645E8  mov      x0, x19
0068645EC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068645F0  cbz      x0, #0x68653dc
0068645F4  adrp     x8, #0x9598000
0068645F8  ldrb     w8, [x8, #0xfcc]
0068645FC  mov      x21, x0
006864600  cbnz     w8, #0x686461c
006864604  adrp     x0, #0x8f06000
006864608  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00686460C  bl       #0x382bd14 ; 
006864610  mov      w8, #1
006864614  adrp     x9, #0x9598000
006864618  strb     w8, [x9, #0xfcc]
00686461C  adrp     x8, #0x8f06000
006864620  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006864624  ldr      x1, [x8]
006864628  ldrb     w8, [x1, #0x53]
00686462C  tbnz     w8, #5, #0x6864638
006864630  ldr      x0, [x21, #0x200]
006864634  b        #0x6864644 ; 
006864638  ldr      x8, [x1, #0x60]
00686463C  mov      x0, x21
006864640  blr      x8
006864644  cbz      x0, #0x68653dc
006864648  mov      w1, w25
00686464C  mov      x2, xzr
006864650  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006864654  ldr      x21, [sp, #0x60]
006864658  ldp      x2, x3, [sp, #0x80]
00686465C  mov      x1, x0
006864660  mov      x0, x19
006864664  mov      x4, x21
006864668  bl       #0x6862418 ; HotFix.BattleLogic.DankeSkillCreator$$GetAddSkillId
00686466C  cbz      x21, #0x68653dc
006864670  adrp     x9, #0x8ec2000
006864674  ldr      w10, [x21, #0x1c]
006864678  ldr      x8, [x21, #0x10]
00686467C  ldr      x9, [x9, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
006864680  add      w10, w10, #1
006864684  ldr      x9, [x9]
006864688  str      w10, [x21, #0x1c]
00686468C  cbz      x8, #0x68653dc
006864690  ldrsw    x10, [x21, #0x18]
006864694  ldr      w11, [x8, #0x18]
006864698  cmp      w10, w11
00686469C  b.hs     #0x68646b4
0068646A0  add      w9, w10, #1
0068646A4  add      x8, x8, x10, lsl #2
0068646A8  str      w9, [x21, #0x18]
0068646AC  str      w25, [x8, #0x20]
0068646B0  b        #0x68646cc ; 
0068646B4  ldr      x8, [x9, #0x20]
0068646B8  mov      x0, x21
0068646BC  mov      w1, w25
0068646C0  ldr      x8, [x8, #0xc0]
0068646C4  ldr      x2, [x8, #0x70]
0068646C8  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
0068646CC  ldrb     w8, [x24, #0xde3]
0068646D0  cbnz     w8, #0x68646e4
0068646D4  mov      x0, x20
0068646D8  bl       #0x382bd14 ; 
0068646DC  mov      w8, #1
0068646E0  strb     w8, [x24, #0xde3]
0068646E4  ldr      x1, [x20]
0068646E8  ldrb     w8, [x1, #0x53]
0068646EC  tbnz     w8, #5, #0x68646f8
0068646F0  ldr      w2, [x23, #0x20]
0068646F4  b        #0x6864708 ; 
0068646F8  ldr      x8, [x1, #0x60]
0068646FC  mov      x0, x23
006864700  blr      x8
006864704  mov      w2, w0
006864708  ldr      x0, [sp, #0x78]
00686470C  cbz      x0, #0x68653dc
006864710  adrp     x8, #0x8ee3000
006864714  ldr      x8, [x8, #0xfa0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.set_Item() @ 0x920b0a0
006864718  mov      w1, w25
00686471C  ldr      x3, [x8]
006864720  bl       #0x5e2814c ; System.Collections.Generic.Dictionary<int, int>$$set_Item
006864724  b        #0x6864740 ; 
006864728  ldr      x3, [sp, #0x88]
00686472C  ldr      x4, [sp, #0x60]
006864730  mov      x0, x19
006864734  mov      x1, x23
006864738  mov      x2, x25
00686473C  bl       #0x6862418 ; HotFix.BattleLogic.DankeSkillCreator$$GetAddSkillId
006864740  ldr      x8, [x19, #0x30]
006864744  cbz      x8, #0x68653dc
006864748  ldr      w9, [x8, #0x18]
00686474C  cmp      w22, w9
006864750  b.hs     #0x68653e0
006864754  mov      w9, w22
006864758  sxtw     x21, w9
00686475C  add      x8, x8, x21, lsl #3
006864760  ldrb     w9, [x24, #0xde3]
006864764  ldr      x25, [x8, #0x20]
006864768  cbnz     w9, #0x686477c
00686476C  mov      x0, x20
006864770  bl       #0x382bd14 ; 
006864774  mov      w8, #1
006864778  strb     w8, [x24, #0xde3]
00686477C  ldr      x1, [x20]
006864780  ldrb     w8, [x1, #0x53]
006864784  tbnz     w8, #5, #0x6864790
006864788  ldr      w1, [x23, #0x20]
00686478C  b        #0x68647a0 ; 
006864790  ldr      x8, [x1, #0x60]
006864794  mov      x0, x23
006864798  blr      x8
00686479C  mov      w1, w0
0068647A0  cbz      x25, #0x68653dc
0068647A4  mov      x0, x25
0068647A8  mov      w2, wzr
0068647AC  mov      x3, xzr
0068647B0  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
0068647B4  ldr      x8, [x19, #0x38]
0068647B8  cbz      x8, #0x68653dc
0068647BC  ldr      w9, [x8, #0x18]
0068647C0  cmp      w22, w9
0068647C4  b.hs     #0x68653e0
0068647C8  add      x8, x8, x21, lsl #3
0068647CC  ldrb     w9, [x24, #0xde3]
0068647D0  ldr      x25, [x8, #0x20]
0068647D4  cbnz     w9, #0x68647e8
0068647D8  mov      x0, x20
0068647DC  bl       #0x382bd14 ; 
0068647E0  mov      w8, #1
0068647E4  strb     w8, [x24, #0xde3]
0068647E8  ldr      x1, [x20]
0068647EC  ldrb     w8, [x1, #0x53]
0068647F0  tbnz     w8, #5, #0x68647fc
0068647F4  ldr      w1, [x23, #0x20]
0068647F8  b        #0x686480c ; 
0068647FC  ldr      x8, [x1, #0x60]
006864800  mov      x0, x23
006864804  blr      x8
006864808  mov      w1, w0
00686480C  cbz      x25, #0x68653dc
006864810  mov      x0, x25
006864814  mov      w2, wzr
006864818  mov      x3, xzr
00686481C  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
006864820  ldr      x8, [x19, #0x28]
006864824  cbz      x8, #0x68653dc
006864828  ldr      w9, [x8, #0x18]
00686482C  adrp     x25, #0x8ec2000
006864830  cmp      w22, w9
006864834  ldr      x22, [sp, #0x80]
006864838  ldr      x25, [x25, #0x260] ; GLOBAL Method$System.Collections.Generic.List<int>.Add() @ 0x921de38
00686483C  b.hs     #0x68653e0
006864840  add      x8, x8, x21, lsl #3
006864844  ldr      x0, [x8, #0x20]
006864848  cbz      x0, #0x68653dc
00686484C  mov      w1, w27
006864850  mov      w2, wzr
006864854  mov      x3, xzr
006864858  bl       #0x6632ce4 ; HotFix.BattleLogic.WeightRandom$$RemoveRandom
00686485C  cbz      x28, #0x68653dc
006864860  ldr      w8, [x28, #0x1c]
006864864  adrp     x21, #0x8f08000
006864868  mov      x0, x28
00686486C  mov      x1, x22
006864870  add      w8, w8, #1
006864874  stp      wzr, w8, [x28, #0x18]
006864878  ldr      x21, [x21, #0xbb0] ; GLOBAL Method$System.Collections.Generic.List<int>.AddRange() @ 0x921de40
00686487C  ldr      x2, [x21]
006864880  bl       #0x4d64760 ; System.Collections.Generic.List<int>$$AddRange
006864884  ldr      x2, [x21]
006864888  ldr      x1, [sp, #0x70]
00686488C  mov      x0, x28
006864890  bl       #0x4d64760 ; System.Collections.Generic.List<int>$$AddRange
006864894  ldr      x0, [sp, #0x78]
006864898  cbz      x0, #0x68653dc
00686489C  adrp     x8, #0x8f09000
0068648A0  ldr      x8, [x8, #0x238] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.GetEnumerator() @ 0x920b060
0068648A4  ldr      x1, [x8]
0068648A8  add      x8, sp, #0x90
0068648AC  bl       #0x5e28538 ; System.Collections.Generic.Dictionary<int, int>$$GetEnumerator
0068648B0  ldp      q0, q1, [sp, #0x90]
0068648B4  stp      q0, q1, [sp, #0xc0]
0068648B8  ldr      x1, [x26]
0068648BC  add      x0, sp, #0xc0
0068648C0  bl       #0x614eb48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$MoveNext
0068648C4  tbz      w0, #0, #0x6864938
0068648C8  ldr      w22, [sp, #0xd0]
0068648CC  ldr      x2, [x29]
0068648D0  mov      x0, x28
0068648D4  mov      w1, w22
0068648D8  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
0068648DC  tbnz     w0, #0, #0x68648b8
0068648E0  ldr      w10, [x28, #0x1c]
0068648E4  ldr      x8, [x28, #0x10]
0068648E8  ldr      x9, [x25]
0068648EC  add      w10, w10, #1
0068648F0  str      w10, [x28, #0x1c]
0068648F4  cbz      x8, #0x68650dc
0068648F8  ldrsw    x10, [x28, #0x18]
0068648FC  ldr      w11, [x8, #0x18]
006864900  cmp      w10, w11
006864904  b.hs     #0x686491c
006864908  add      w9, w10, #1
00686490C  add      x8, x8, x10, lsl #2
006864910  str      w9, [x28, #0x18]
006864914  str      w22, [x8, #0x20]
006864918  b        #0x68648b8 ; 
00686491C  ldr      x8, [x9, #0x20]
006864920  ldr      x8, [x8, #0xc0]
006864924  ldr      x2, [x8, #0x70]
006864928  mov      x0, x28
00686492C  mov      w1, w22
006864930  bl       #0x4d64554 ; System.Collections.Generic.List<int>$$AddWithResize
006864934  b        #0x68648b8 ; 
006864938  adrp     x8, #0x8f09000
00686493C  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006864940  add      x0, sp, #0xc0
006864944  ldr      x1, [x8]
006864948  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
00686494C  ldr      x8, [x19, #0x28]
006864950  cbz      x8, #0x68653dc
006864954  mov      x21, xzr
006864958  ldr      w9, [x8, #0x18]
00686495C  cmp      w21, w9
006864960  b.ge     #0x6864994
006864964  cmp      w21, w9
006864968  b.hs     #0x68653e0
00686496C  add      x8, x8, x21, lsl #3
006864970  ldr      x0, [x8, #0x20]
006864974  cbz      x0, #0x68653dc
006864978  mov      w1, w27
00686497C  mov      x2, xzr
006864980  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006864984  ldr      x8, [x19, #0x28]
006864988  add      x21, x21, #1
00686498C  cbnz     x8, #0x6864958
006864990  b        #0x68653dc ; 
006864994  adrp     x8, #0x9598000
006864998  ldrb     w8, [x8, #0x35e]
00686499C  cbnz     w8, #0x68649b8
0068649A0  adrp     x0, #0x8ef9000
0068649A4  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0068649A8  bl       #0x382bd14 ; 
0068649AC  mov      w8, #1
0068649B0  adrp     x9, #0x9598000
0068649B4  strb     w8, [x9, #0x35e]
0068649B8  adrp     x8, #0x8ef9000
0068649BC  ldr      x8, [x8, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0068649C0  ldr      x1, [x8]
0068649C4  ldrb     w8, [x1, #0x53]
0068649C8  tbnz     w8, #5, #0x68649d4
0068649CC  ldr      w0, [x23, #0x68]
0068649D0  b        #0x68649e0 ; 
0068649D4  ldr      x8, [x1, #0x60]
0068649D8  mov      x0, x23
0068649DC  blr      x8
0068649E0  cmp      w0, #4
0068649E4  b.eq     #0x6864a3c
0068649E8  adrp     x8, #0x9598000
0068649EC  ldrb     w8, [x8, #0x35e]
0068649F0  cbnz     w8, #0x6864a0c
0068649F4  adrp     x0, #0x8ef9000
0068649F8  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
0068649FC  bl       #0x382bd14 ; 
006864A00  mov      w8, #1
006864A04  adrp     x9, #0x9598000
006864A08  strb     w8, [x9, #0x35e]
006864A0C  adrp     x8, #0x8ef9000
006864A10  ldr      x8, [x8, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006864A14  ldr      x1, [x8]
006864A18  ldrb     w8, [x1, #0x53]
006864A1C  tbnz     w8, #5, #0x6864a28
006864A20  ldr      w0, [x23, #0x68]
006864A24  b        #0x6864a34 ; 
006864A28  ldr      x8, [x1, #0x60]
006864A2C  mov      x0, x23
006864A30  blr      x8
006864A34  cmp      w0, #5
006864A38  b.ne     #0x6864b14
006864A3C  adrp     x8, #0x8f09000
006864A40  ldr      x8, [x8, #0x238] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.GetEnumerator() @ 0x920b060
006864A44  ldr      x0, [sp, #0x78]
006864A48  ldr      x1, [x8]
006864A4C  add      x8, sp, #0x90
006864A50  bl       #0x5e28538 ; System.Collections.Generic.Dictionary<int, int>$$GetEnumerator
006864A54  ldp      q0, q1, [sp, #0x90]
006864A58  stp      q0, q1, [sp, #0xc0]
006864A5C  ldr      x1, [x26]
006864A60  add      x0, sp, #0xc0
006864A64  bl       #0x614eb48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$MoveNext
006864A68  tbz      w0, #0, #0x6864b00
006864A6C  ldrb     w8, [x24, #0xde3]
006864A70  ldr      x22, [sp, #0xd0]
006864A74  cbnz     w8, #0x6864a88
006864A78  mov      x0, x20
006864A7C  bl       #0x382bd14 ; 
006864A80  mov      w8, #1
006864A84  strb     w8, [x24, #0xde3]
006864A88  ldr      x1, [x20]
006864A8C  ldrb     w8, [x1, #0x53]
006864A90  tbnz     w8, #5, #0x6864a9c
006864A94  ldr      w0, [x23, #0x20]
006864A98  b        #0x6864aa8 ; 
006864A9C  ldr      x8, [x1, #0x60]
006864AA0  mov      x0, x23
006864AA4  blr      x8
006864AA8  lsr      x8, x22, #0x20
006864AAC  cmp      w0, w8
006864AB0  b.ne     #0x6864a5c
006864AB4  ldr      x8, [x19, #0x28]
006864AB8  cbz      x8, #0x6864af8
006864ABC  mov      x21, xzr
006864AC0  ldr      w9, [x8, #0x18]
006864AC4  cmp      w21, w9
006864AC8  b.ge     #0x6864b00
006864ACC  cmp      w21, w9
006864AD0  b.hs     #0x6865104
006864AD4  add      x8, x8, x21, lsl #3
006864AD8  ldr      x0, [x8, #0x20]
006864ADC  cbz      x0, #0x686510c
006864AE0  mov      w1, w22
006864AE4  mov      x2, xzr
006864AE8  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006864AEC  ldr      x8, [x19, #0x28]
006864AF0  add      x21, x21, #1
006864AF4  cbnz     x8, #0x6864ac0
006864AF8  bl       #0x382bfb8 ; 
006864AFC  b        #0x68653fc ; 
006864B00  adrp     x8, #0x8f09000
006864B04  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006864B08  add      x0, sp, #0xc0
006864B0C  ldr      x1, [x8]
006864B10  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
006864B14  adrp     x8, #0x8f1e000
006864B18  ldr      x8, [x8, #0x4d0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.get_Count() @ 0x920b080
006864B1C  ldr      x0, [sp, #0x88]
006864B20  ldr      x1, [x8]
006864B24  bl       #0x5e27e14 ; System.Collections.Generic.Dictionary<int, int>$$get_Count
006864B28  cmp      w0, #1
006864B2C  b.lt     #0x6864cec
006864B30  adrp     x8, #0x8f09000
006864B34  ldr      x8, [x8, #0x238] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.GetEnumerator() @ 0x920b060
006864B38  ldr      x0, [sp, #0x88]
006864B3C  ldr      x1, [x8]
006864B40  add      x8, sp, #0x90
006864B44  bl       #0x5e28538 ; System.Collections.Generic.Dictionary<int, int>$$GetEnumerator
006864B48  ldp      q0, q1, [sp, #0x90]
006864B4C  stp      q0, q1, [sp, #0xc0]
006864B50  ldr      x1, [x26]
006864B54  add      x0, sp, #0xc0
006864B58  bl       #0x614eb48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$MoveNext
006864B5C  tbz      w0, #0, #0x6864cd8
006864B60  ldr      x21, [sp, #0xd0]
006864B64  str      w21, [sp, #0xbc]
006864B68  mov      x0, x19
006864B6C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006864B70  mov      x22, x0
006864B74  cbz      x0, #0x68650cc
006864B78  adrp     x8, #0x9598000
006864B7C  ldrb     w8, [x8, #0xfcc]
006864B80  cbnz     w8, #0x6864b9c
006864B84  adrp     x0, #0x8f06000
006864B88  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006864B8C  bl       #0x382bd14 ; 
006864B90  mov      w8, #1
006864B94  adrp     x9, #0x9598000
006864B98  strb     w8, [x9, #0xfcc]
006864B9C  adrp     x8, #0x8f06000
006864BA0  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006864BA4  ldr      x1, [x8]
006864BA8  ldrb     w8, [x1, #0x53]
006864BAC  tbnz     w8, #5, #0x6864bb8
006864BB0  ldr      x0, [x22, #0x200]
006864BB4  b        #0x6864bc4 ; 
006864BB8  ldr      x8, [x1, #0x60]
006864BBC  mov      x0, x22
006864BC0  blr      x8
006864BC4  cbz      x0, #0x68650d4
006864BC8  ldr      w1, [sp, #0xbc]
006864BCC  mov      x2, xzr
006864BD0  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006864BD4  cbz      x0, #0x6864c6c
006864BD8  mov      w1, #1
006864BDC  mov      x2, xzr
006864BE0  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
006864BE4  ldr      x8, [x19, #0x30]
006864BE8  cbz      x8, #0x68650ec
006864BEC  ldr      w9, [x8, #0x18]
006864BF0  mov      w22, w0
006864BF4  cmp      w0, w9
006864BF8  b.hs     #0x68650fc
006864BFC  ldr      x9, [x19]
006864C00  sxtw     x27, w22
006864C04  add      x8, x8, x27, lsl #3
006864C08  ldr      x1, [x8, #0x20]
006864C0C  ldr      w2, [sp, #0xbc]
006864C10  ldr      x8, [x9, #0x228]
006864C14  ldr      x5, [x9, #0x230]
006864C18  lsr      x25, x21, #0x20
006864C1C  mov      x0, x19
006864C20  mov      w3, w25
006864C24  mov      x4, x28
006864C28  blr      x8
006864C2C  ldr      x8, [x19, #0x28]
006864C30  cbz      x8, #0x68650e4
006864C34  ldr      w9, [x8, #0x18]
006864C38  cmp      w22, w9
006864C3C  b.hs     #0x68650f4
006864C40  ldr      x9, [x19]
006864C44  add      x8, x8, x27, lsl #3
006864C48  ldr      x1, [x8, #0x20]
006864C4C  ldr      w2, [sp, #0xbc]
006864C50  ldr      x8, [x9, #0x228]
006864C54  ldr      x5, [x9, #0x230]
006864C58  mov      x0, x19
006864C5C  mov      w3, w25
006864C60  mov      x4, x28
006864C64  blr      x8
006864C68  b        #0x6864b50 ; 
006864C6C  add      x0, sp, #0xbc
006864C70  mov      x1, xzr
006864C74  bl       #0x7bd22a0 ; System.Int32$$ToString
006864C78  mov      x1, x0
006864C7C  adrp     x8, #0x8f23000
006864C80  ldr      x8, [x8, #0xd90] ; GLOBAL addSkillId is null  @ 0x931af08
006864C84  ldr      x0, [x8]
006864C88  mov      x2, xzr
006864C8C  bl       #0x79d469c ; System.String$$Concat
006864C90  adrp     x8, #0x8ee1000
006864C94  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo @ 0x91ebc40
006864C98  mov      x22, x0
006864C9C  ldr      x0, [x8]
006864CA0  ldr      w8, [x0, #0xe0]
006864CA4  cbnz     w8, #0x6864cac
006864CA8  bl       #0x382be8c ; 
006864CAC  adrp     x8, #0x8f23000
006864CB0  ldr      x8, [x8, #0xd88] ; GLOBAL RandomPunchboardSkill @ 0x930b030
006864CB4  ldr      x1, [x8]
006864CB8  adrp     x8, #0x8f23000
006864CBC  ldr      x8, [x8, #0xc80] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityHero\Component\Skill\DankeSkillCreator.cs @ 0x92f8028
006864CC0  ldr      x2, [x8]
006864CC4  mov      w3, #0x32e
006864CC8  mov      x0, x22
006864CCC  mov      x4, xzr
006864CD0  bl       #0x7997754 ; Logger$$LogError
006864CD4  b        #0x6864b50 ; 
006864CD8  adrp     x8, #0x8f09000
006864CDC  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006864CE0  add      x0, sp, #0xc0
006864CE4  ldr      x1, [x8]
006864CE8  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
006864CEC  ldr      x3, [x19, #0x28]
006864CF0  mov      x0, x19
006864CF4  mov      x1, x23
006864CF8  mov      x2, x28
006864CFC  bl       #0x6861d30 ; HotFix.BattleLogic.DankeSkillCreator$$TryUnlockUpgradeSkillsForPunchboard
006864D00  adrp     x8, #0x9598000
006864D04  ldrb     w8, [x8, #0x35e]
006864D08  cbnz     w8, #0x6864d24
006864D0C  adrp     x0, #0x8ef9000
006864D10  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006864D14  bl       #0x382bd14 ; 
006864D18  mov      w8, #1
006864D1C  adrp     x9, #0x9598000
006864D20  strb     w8, [x9, #0x35e]
006864D24  adrp     x8, #0x8ef9000
006864D28  ldr      x8, [x8, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006864D2C  ldr      x25, [sp, #0x80]
006864D30  ldr      x1, [x8]
006864D34  ldrb     w8, [x1, #0x53]
006864D38  tbnz     w8, #5, #0x6864d44
006864D3C  ldr      w0, [x23, #0x68]
006864D40  b        #0x6864d50 ; 
006864D44  ldr      x8, [x1, #0x60]
006864D48  mov      x0, x23
006864D4C  blr      x8
006864D50  cmp      w0, #4
006864D54  b.eq     #0x6864dac
006864D58  adrp     x8, #0x9598000
006864D5C  ldrb     w8, [x8, #0x35e]
006864D60  cbnz     w8, #0x6864d7c
006864D64  adrp     x0, #0x8ef9000
006864D68  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006864D6C  bl       #0x382bd14 ; 
006864D70  mov      w8, #1
006864D74  adrp     x9, #0x9598000
006864D78  strb     w8, [x9, #0x35e]
006864D7C  adrp     x8, #0x8ef9000
006864D80  ldr      x8, [x8, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006864D84  ldr      x1, [x8]
006864D88  ldrb     w8, [x1, #0x53]
006864D8C  tbnz     w8, #5, #0x6864d98
006864D90  ldr      w0, [x23, #0x68]
006864D94  b        #0x6864da4 ; 
006864D98  ldr      x8, [x1, #0x60]
006864D9C  mov      x0, x23
006864DA0  blr      x8
006864DA4  cmp      w0, #5
006864DA8  b.ne     #0x6864ebc
006864DAC  adrp     x8, #0x8f09000
006864DB0  ldr      x8, [x8, #0x238] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>.GetEnumerator() @ 0x920b060
006864DB4  ldr      x0, [sp, #0x78]
006864DB8  ldr      x1, [x8]
006864DBC  add      x8, sp, #0x90
006864DC0  bl       #0x5e28538 ; System.Collections.Generic.Dictionary<int, int>$$GetEnumerator
006864DC4  ldp      q0, q1, [sp, #0x90]
006864DC8  stp      q0, q1, [sp, #0xc0]
006864DCC  ldr      x1, [x26]
006864DD0  add      x0, sp, #0xc0
006864DD4  bl       #0x614eb48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$MoveNext
006864DD8  tbz      w0, #0, #0x6864ea8
006864DDC  ldrb     w8, [x24, #0xde3]
006864DE0  ldr      x22, [sp, #0xd0]
006864DE4  cbnz     w8, #0x6864df8
006864DE8  mov      x0, x20
006864DEC  bl       #0x382bd14 ; 
006864DF0  mov      w8, #1
006864DF4  strb     w8, [x24, #0xde3]
006864DF8  ldr      x1, [x20]
006864DFC  ldrb     w8, [x1, #0x53]
006864E00  tbnz     w8, #5, #0x6864e0c
006864E04  ldr      w0, [x23, #0x20]
006864E08  b        #0x6864e18 ; 
006864E0C  ldr      x8, [x1, #0x60]
006864E10  mov      x0, x23
006864E14  blr      x8
006864E18  lsr      x8, x22, #0x20
006864E1C  cmp      w0, w8
006864E20  b.ne     #0x6864dcc
006864E24  mov      x0, x19
006864E28  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006864E2C  mov      x23, x0
006864E30  cbz      x0, #0x6865114
006864E34  adrp     x8, #0x9598000
006864E38  ldrb     w8, [x8, #0xfcc]
006864E3C  cbnz     w8, #0x6864e58
006864E40  adrp     x0, #0x8f06000
006864E44  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006864E48  bl       #0x382bd14 ; 
006864E4C  mov      w8, #1
006864E50  adrp     x9, #0x9598000
006864E54  strb     w8, [x9, #0xfcc]
006864E58  adrp     x8, #0x8f06000
006864E5C  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006864E60  ldr      x1, [x8]
006864E64  ldrb     w8, [x1, #0x53]
006864E68  tbnz     w8, #5, #0x6864e74
006864E6C  ldr      x0, [x23, #0x200]
006864E70  b        #0x6864e80 ; 
006864E74  ldr      x8, [x1, #0x60]
006864E78  mov      x0, x23
006864E7C  blr      x8
006864E80  cbz      x0, #0x686511c
006864E84  mov      w1, w22
006864E88  mov      x2, xzr
006864E8C  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006864E90  mov      x1, x0
006864E94  cbz      x1, #0x6864ea8
006864E98  ldr      x3, [x19, #0x28]
006864E9C  mov      x0, x19
006864EA0  mov      x2, x28
006864EA4  bl       #0x6861d30 ; HotFix.BattleLogic.DankeSkillCreator$$TryUnlockUpgradeSkillsForPunchboard
006864EA8  adrp     x8, #0x8f09000
006864EAC  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006864EB0  add      x0, sp, #0xc0
006864EB4  ldr      x1, [x8]
006864EB8  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
006864EBC  ldr      w9, [sp, #0x6c]
006864EC0  ldr      w8, [sp, #0x58]
006864EC4  ldr      x23, [sp, #0x70]
006864EC8  add      w9, w9, #1
006864ECC  cmp      w9, w8
006864ED0  b.ne     #0x6864104
006864ED4  b        #0x686527c ; 
006864ED8  mov      x0, x23
006864EDC  mov      x1, xzr
006864EE0  bl       #0x6b0a2d4 ; LocalModels.Bean.Skill_Main$$GetIsUpgrade
006864EE4  cmp      w0, #1
006864EE8  b.eq     #0x68642c8
006864EEC  adrp     x8, #0x9598000
006864EF0  ldrb     w8, [x8, #0x35e]
006864EF4  cbnz     w8, #0x6864f10
006864EF8  adrp     x0, #0x8ef9000
006864EFC  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006864F00  bl       #0x382bd14 ; 
006864F04  mov      w8, #1
006864F08  adrp     x9, #0x9598000
006864F0C  strb     w8, [x9, #0x35e]
006864F10  adrp     x8, #0x8ef9000
006864F14  ldr      x8, [x8, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006864F18  ldr      x1, [x8]
006864F1C  ldrb     w8, [x1, #0x53]
006864F20  tbnz     w8, #5, #0x6864f2c
006864F24  ldr      w0, [x23, #0x68]
006864F28  b        #0x6864f38 ; 
006864F2C  ldr      x8, [x1, #0x60]
006864F30  mov      x0, x23
006864F34  blr      x8
006864F38  cmp      w0, #3
006864F3C  b.eq     #0x68642c8
006864F40  adrp     x8, #0x9598000
006864F44  ldrb     w8, [x8, #0x35e]
006864F48  cbnz     w8, #0x6864f64
006864F4C  adrp     x0, #0x8ef9000
006864F50  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006864F54  bl       #0x382bd14 ; 
006864F58  mov      w8, #1
006864F5C  adrp     x9, #0x9598000
006864F60  strb     w8, [x9, #0x35e]
006864F64  adrp     x8, #0x8ef9000
006864F68  ldr      x8, [x8, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006864F6C  ldr      x1, [x8]
006864F70  ldrb     w8, [x1, #0x53]
006864F74  tbnz     w8, #5, #0x6864fe0
006864F78  ldr      w0, [x23, #0x68]
006864F7C  b        #0x6864fec ; 
006864F80  ldr      x8, [x1, #0x60]
006864F84  mov      x0, x23
006864F88  blr      x8
006864F8C  adrp     x8, #0x8ebf000
006864F90  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006864F94  str      w0, [sp, #0xb4]
006864F98  add      x1, sp, #0xb4
006864F9C  ldr      x8, [x8]
006864FA0  mov      x0, x8
006864FA4  bl       #0x382be94 ; 
006864FA8  adrp     x8, #0x8f23000
006864FAC  ldr      x8, [x8, #0xd98] ; GLOBAL [Temp]-[RandomSkill]-[Danke] doSub deepType = {0}  curSkill = {1}  coverSkill = {2} @ 0x9318ff8
006864FB0  mov      x3, x0
006864FB4  mov      x1, x25
006864FB8  mov      x2, x21
006864FBC  ldr      x8, [x8]
006864FC0  mov      x4, xzr
006864FC4  mov      x0, x8
006864FC8  bl       #0x79e27d8 ; System.String$$Format
006864FCC  mov      x1, x0
006864FD0  mov      x0, x19
006864FD4  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
006864FD8  ldr      x25, [sp, #0x80]
006864FDC  b        #0x68642c8 ; 
006864FE0  ldr      x8, [x1, #0x60]
006864FE4  mov      x0, x23
006864FE8  blr      x8
006864FEC  cmp      w0, #4
006864FF0  b.eq     #0x68642c8
006864FF4  adrp     x8, #0x9598000
006864FF8  ldrb     w8, [x8, #0x35e]
006864FFC  cbnz     w8, #0x6865018
006865000  adrp     x0, #0x8ef9000
006865004  ldr      x0, [x0, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006865008  bl       #0x382bd14 ; 
00686500C  mov      w8, #1
006865010  adrp     x9, #0x9598000
006865014  strb     w8, [x9, #0x35e]
006865018  adrp     x8, #0x8ef9000
00686501C  ldr      x8, [x8, #0xf30] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_SkillType() @ 0x92ac548
006865020  ldr      x1, [x8]
006865024  ldrb     w8, [x1, #0x53]
006865028  tbnz     w8, #5, #0x6865034
00686502C  ldr      w0, [x23, #0x68]
006865030  b        #0x6865040 ; 
006865034  ldr      x8, [x1, #0x60]
006865038  mov      x0, x23
00686503C  blr      x8
006865040  cmp      w0, #5
006865044  b.eq     #0x68642c8
006865048  ldr      w8, [sp, #0x54]
00686504C  ldr      x0, [sp, #0x88]
006865050  subs     w8, w8, #1
006865054  str      w8, [sp, #0x54]
006865058  b.pl     #0x68642cc
00686505C  adrp     x8, #0x8eea000
006865060  ldr      x8, [x8, #0xf18] ; GLOBAL Method$System.Collections.Generic.List<int>.ToArray() @ 0x921dec0
006865064  mov      x0, x25
006865068  ldr      x1, [x8]
00686506C  bl       #0x4d66374 ; System.Collections.Generic.List<int>$$ToArray
006865070  adrp     x8, #0x8ec2000
006865074  ldr      x8, [x8, #0x4e0] ; GLOBAL , @ 0x92ea038
006865078  adrp     x9, #0x8f09000
00686507C  mov      x1, x0
006865080  ldr      x8, [x8]
006865084  ldr      x9, [x9, #0xa98] ; GLOBAL Method$System.String.Join<int>() @ 0x92b0100
006865088  mov      x0, x8
00686508C  ldr      x2, [x9]
006865090  bl       #0x4702f28 ; System.String$$Join<int>
006865094  adrp     x8, #0x8f23000
006865098  ldr      x8, [x8, #0xd80] ; GLOBAL [Temp]-[RandomSkill]-[Danke] doSub  AllSkills =  @ 0x9318ff0
00686509C  mov      x1, x0
0068650A0  mov      x2, xzr
0068650A4  ldr      x8, [x8]
0068650A8  mov      x0, x8
0068650AC  bl       #0x79d469c ; System.String$$Concat
0068650B0  mov      x1, x0
0068650B4  mov      x0, x19
0068650B8  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
0068650BC  adrp     x21, #0x8ebf000
0068650C0  ldr      x21, [x21, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
0068650C4  mov      w8, #2
0068650C8  b        #0x6864404 ; 
0068650CC  bl       #0x382bfb8 ; 
0068650D0  b        #0x68653fc ; 
0068650D4  bl       #0x382bfb8 ; 
0068650D8  b        #0x68653fc ; 
0068650DC  bl       #0x382bfb8 ; 
0068650E0  b        #0x68653fc ; 
0068650E4  bl       #0x382bfb8 ; 
0068650E8  b        #0x68653fc ; 
0068650EC  bl       #0x382bfb8 ; 
0068650F0  b        #0x68653fc ; 
0068650F4  bl       #0x382bfc0 ; 
0068650F8  b        #0x68653fc ; 
0068650FC  bl       #0x382bfc0 ; 
006865100  b        #0x68653fc ; 
006865104  bl       #0x382bfc0 ; 
006865108  b        #0x68653fc ; 
00686510C  bl       #0x382bfb8 ; 
006865110  b        #0x68653fc ; 
006865114  bl       #0x382bfb8 ; 
006865118  b        #0x68653fc ; 
00686511C  bl       #0x382bfb8 ; 
006865120  b        #0x68653fc ; 
006865124  b        #0x6865174 ; 
006865128  b        #0x6865174 ; 
00686512C  b        #0x6865174 ; 
006865130  b        #0x6865174 ; 
006865134  b        #0x6865174 ; 
006865138  b        #0x6865204 ; 
00686513C  b        #0x6865240 ; 
006865140  b        #0x6865174 ; 
006865144  b        #0x68651b0 ; 
006865148  b        #0x68651b0 ; 
00686514C  b        #0x68651b0 ; 
006865150  b        #0x68651b0 ; 
006865154  b        #0x68651b0 ; 
006865158  b        #0x6865204 ; 
00686515C  b        #0x6865204 ; 
006865160  b        #0x6865204 ; 
006865164  b        #0x6865204 ; 
006865168  b        #0x6865204 ; 
00686516C  b        #0x6865204 ; 
006865170  b        #0x6865204 ; 
006865174  mov      x22, x0
006865178  cmp      w1, #1
00686517C  b.ne     #0x68653fc
006865180  mov      x0, x22
006865184  bl       #0x89eda50 ; 
006865188  ldr      x23, [x0]
00686518C  bl       #0x89eda60 ; 
006865190  adrp     x8, #0x8f09000
006865194  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006865198  add      x0, sp, #0xc0
00686519C  ldr      x1, [x8]
0068651A0  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
0068651A4  ldr      x25, [sp, #0x80]
0068651A8  cbz      x23, #0x6864ebc
0068651AC  b        #0x6865404 ; 
0068651B0  mov      x22, x0
0068651B4  cmp      w1, #1
0068651B8  b.ne     #0x68653f4
0068651BC  mov      x0, x22
0068651C0  bl       #0x89eda50 ; 
0068651C4  ldr      x25, [x0]
0068651C8  bl       #0x89eda60 ; 
0068651CC  adrp     x8, #0x8f09000
0068651D0  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
0068651D4  add      x0, sp, #0xc0
0068651D8  ldr      x1, [x8]
0068651DC  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
0068651E0  cbz      x25, #0x6864b14
0068651E4  b        #0x6865274 ; 
0068651E8  b        #0x6865240 ; 
0068651EC  b        #0x6865204 ; 
0068651F0  b        #0x6865204 ; 
0068651F4  b        #0x6865204 ; 
0068651F8  b        #0x6865204 ; 
0068651FC  b        #0x6865204 ; 
006865200  b        #0x6865204 ; 
006865204  mov      x22, x0
006865208  cmp      w1, #1
00686520C  b.ne     #0x68653e4
006865210  mov      x0, x22
006865214  bl       #0x89eda50 ; 
006865218  ldr      x25, [x0]
00686521C  bl       #0x89eda60 ; 
006865220  adrp     x8, #0x8f09000
006865224  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006865228  add      x0, sp, #0xc0
00686522C  ldr      x1, [x8]
006865230  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
006865234  cbz      x25, #0x6864cec
006865238  b        #0x6865274 ; 
00686523C  b        #0x6865240 ; 
006865240  mov      x22, x0
006865244  cmp      w1, #1
006865248  b.ne     #0x68653ec
00686524C  mov      x0, x22
006865250  bl       #0x89eda50 ; 
006865254  ldr      x25, [x0]
006865258  bl       #0x89eda60 ; 
00686525C  adrp     x8, #0x8f09000
006865260  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006865264  add      x0, sp, #0xc0
006865268  ldr      x1, [x8]
00686526C  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
006865270  cbz      x25, #0x686494c
006865274  mov      x0, x25
006865278  bl       #0x382bfb0 ; 
00686527C  mov      x0, x19
006865280  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006865284  cbz      x0, #0x68653dc
006865288  adrp     x22, #0x959a000
00686528C  adrp     x23, #0x8f19000
006865290  ldrb     w8, [x22, #0xc8e]
006865294  ldr      x23, [x23, #0x910] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DictionaryPool() @ 0x923feb0
006865298  mov      x20, x0
00686529C  adrp     x21, #0x9591000
0068652A0  cbnz     w8, #0x68652b8
0068652A4  adrp     x0, #0x8f19000
0068652A8  ldr      x0, [x0, #0x910] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DictionaryPool() @ 0x923feb0
0068652AC  bl       #0x382bd14 ; 
0068652B0  mov      w8, #1
0068652B4  strb     w8, [x22, #0xc8e]
0068652B8  ldr      x1, [x23]
0068652BC  adrp     x22, #0x8ee6000
0068652C0  ldrb     w8, [x1, #0x53]
0068652C4  ldr      x22, [x22, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
0068652C8  tbnz     w8, #5, #0x68652d4
0068652CC  ldr      x0, [x20, #0x250]
0068652D0  b        #0x68652e0 ; 
0068652D4  ldr      x8, [x1, #0x60]
0068652D8  mov      x0, x20
0068652DC  blr      x8
0068652E0  cbz      x0, #0x68653dc
0068652E4  adrp     x8, #0x8f23000
0068652E8  ldr      x8, [x8, #0xcb0] ; GLOBAL Method$HotFix.Common.XDictionaryHelper.Push<int, int>() @ 0x92cfb40
0068652EC  ldr      x1, [sp, #0x88]
0068652F0  ldr      x2, [x8]
0068652F4  bl       #0x47839d4 ; HotFix.Common.XDictionaryHelper$$Push<int, int>
0068652F8  mov      x0, x19
0068652FC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006865300  cbz      x0, #0x68653dc
006865304  ldrb     w8, [x21, #0xa90]
006865308  mov      x20, x0
00686530C  cbnz     w8, #0x6865324
006865310  adrp     x0, #0x8ee6000
006865314  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
006865318  bl       #0x382bd14 ; 
00686531C  mov      w8, #1
006865320  strb     w8, [x21, #0xa90]
006865324  ldr      x1, [x22]
006865328  ldrb     w8, [x1, #0x53]
00686532C  tbnz     w8, #5, #0x6865338
006865330  ldr      x0, [x20, #0x230]
006865334  b        #0x6865344 ; 
006865338  ldr      x8, [x1, #0x60]
00686533C  mov      x0, x20
006865340  blr      x8
006865344  cbz      x0, #0x68653dc
006865348  adrp     x20, #0x8f08000
00686534C  ldr      x20, [x20, #0xbc0] ; GLOBAL Method$HotFix.Common.XListPoolHelper.Push<int>() @ 0x92cfe00
006865350  mov      x1, x28
006865354  ldr      x2, [x20]
006865358  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
00686535C  mov      x0, x19
006865360  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006865364  cbz      x0, #0x68653dc
006865368  ldrb     w8, [x21, #0xa90]
00686536C  mov      x19, x0
006865370  cbnz     w8, #0x6865388
006865374  adrp     x0, #0x8ee6000
006865378  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ListPool() @ 0x923ff10
00686537C  bl       #0x382bd14 ; 
006865380  mov      w8, #1
006865384  strb     w8, [x21, #0xa90]
006865388  ldr      x1, [x22]
00686538C  ldrb     w8, [x1, #0x53]
006865390  tbnz     w8, #5, #0x686539c
006865394  ldr      x0, [x19, #0x230]
006865398  b        #0x68653a8 ; 
00686539C  ldr      x8, [x1, #0x60]
0068653A0  mov      x0, x19
0068653A4  blr      x8
0068653A8  cbz      x0, #0x68653dc
0068653AC  ldr      x2, [x20]
0068653B0  ldr      x1, [sp, #0x60]
0068653B4  bl       #0x47865fc ; HotFix.Common.XListPoolHelper$$Push<int>
0068653B8  ldr      x0, [sp, #0x78]
0068653BC  ldp      x20, x19, [sp, #0x130]
0068653C0  ldp      x22, x21, [sp, #0x120]
0068653C4  ldp      x24, x23, [sp, #0x110]
0068653C8  ldp      x26, x25, [sp, #0x100]
0068653CC  ldp      x28, x27, [sp, #0xf0]
0068653D0  ldp      x29, x30, [sp, #0xe0]
0068653D4  add      sp, sp, #0x140
0068653D8  ret      
0068653DC  bl       #0x382bfb8 ; 
0068653E0  bl       #0x382bfc0 ; 
0068653E4  mov      x25, xzr
0068653E8  b        #0x686547c ; 
0068653EC  mov      x25, xzr
0068653F0  b        #0x6865458 ; 
0068653F4  mov      x25, xzr
0068653F8  b        #0x6865434 ; 
0068653FC  mov      x23, xzr
006865400  b        #0x6865410 ; 
006865404  mov      x0, x23
006865408  bl       #0x382bfb0 ; 
00686540C  mov      x22, x0
006865410  adrp     x8, #0x8f09000
006865414  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006865418  ldr      x1, [x8]
00686541C  add      x0, sp, #0xc0
006865420  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
006865424  cbz      x23, #0x6865494
006865428  mov      x0, x23
00686542C  bl       #0x382bfb0 ; 
006865430  mov      x22, x0
006865434  adrp     x8, #0x8f09000
006865438  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
00686543C  ldr      x1, [x8]
006865440  add      x0, sp, #0xc0
006865444  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
006865448  cbz      x25, #0x6865494
00686544C  mov      x0, x25
006865450  bl       #0x382bfb0 ; 
006865454  mov      x22, x0
006865458  adrp     x8, #0x8f09000
00686545C  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006865460  ldr      x1, [x8]
006865464  add      x0, sp, #0xc0
006865468  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
00686546C  cbz      x25, #0x6865494
006865470  mov      x0, x25
006865474  bl       #0x382bfb0 ; 
006865478  mov      x22, x0
00686547C  adrp     x8, #0x8f09000
006865480  ldr      x8, [x8, #0x240] ; GLOBAL Method$System.Collections.Generic.Dictionary.Enumerator<int, int>.Dispose() @ 0x9214790
006865484  ldr      x1, [x8]
006865488  add      x0, sp, #0xc0
00686548C  bl       #0x614ec48 ; System.Collections.Generic.Dictionary.Enumerator<int, int>$$Dispose
006865490  cbnz     x25, #0x686549c
006865494  mov      x0, x22
006865498  bl       #0x3b56bfc ; 
00686549C  mov      x0, x25
0068654A0  bl       #0x382bfb0 ; 
0068654A4  bl       #0x3442448 ; 

