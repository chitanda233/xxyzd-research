; HotFix.BattleLogic.DankeSkillCreator$$TryUnlockUpgradeSkillsForPunchboard
; RVA 0x6861D30; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006861D30  sub      sp, sp, #0x90
006861D34  stp      x29, x30, [sp, #0x30]
006861D38  stp      x28, x27, [sp, #0x40]
006861D3C  stp      x26, x25, [sp, #0x50]
006861D40  stp      x24, x23, [sp, #0x60]
006861D44  stp      x22, x21, [sp, #0x70]
006861D48  stp      x20, x19, [sp, #0x80]
006861D4C  adrp     x19, #0x959b000
006861D50  adrp     x23, #0x8f23000
006861D54  ldrb     w8, [x19, #0x9f6]
006861D58  ldr      x23, [x23, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.TryUnlockUpgradeSkillsForPunchboard() @ 0x9259df8
006861D5C  mov      x27, x3
006861D60  mov      x20, x2
006861D64  mov      x21, x1
006861D68  mov      x22, x0
006861D6C  tbnz     w8, #0, #0x6861dcc
006861D70  adrp     x0, #0x8ee8000
006861D74  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006861D78  bl       #0x382bd14 ; 
006861D7C  adrp     x0, #0x8f23000
006861D80  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.TryUnlockUpgradeSkillsForPunchboard() @ 0x9259df8
006861D84  bl       #0x382bd14 ; 
006861D88  adrp     x0, #0x8ebf000
006861D8C  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006861D90  bl       #0x382bd14 ; 
006861D94  adrp     x0, #0x8f08000
006861D98  ldr      x0, [x0, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
006861D9C  bl       #0x382bd14 ; 
006861DA0  adrp     x0, #0x8ebf000
006861DA4  ldr      x0, [x0, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
006861DA8  bl       #0x382bd14 ; 
006861DAC  adrp     x0, #0x8ec2000
006861DB0  ldr      x0, [x0, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
006861DB4  bl       #0x382bd14 ; 
006861DB8  adrp     x0, #0x8f23000
006861DBC  ldr      x0, [x0, #0xcf8] ; GLOBAL -[TryUnlockUpgradeSkillsForPunchboard] 模拟解锁质变技能 chainIndex={0} upgradeSkillId={1} weight={2}  skillId = {3} @ 0x92eac00
006861DC0  bl       #0x382bd14 ; 
006861DC4  mov      w8, #1
006861DC8  strb     w8, [x19, #0x9f6]
006861DCC  ldr      x4, [x23]
006861DD0  ldrb     w8, [x4, #0x53]
006861DD4  tbnz     w8, #5, #0x6861e54
006861DD8  adrp     x19, #0x8ee8000
006861DDC  ldr      x19, [x19, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006861DE0  ldr      x0, [x19]
006861DE4  ldr      w8, [x0, #0xe0]
006861DE8  cbnz     w8, #0x6861df0
006861DEC  bl       #0x382be8c ; 
006861DF0  adrp     x23, #0x959b000
006861DF4  ldrb     w8, [x23, #0xb85]
006861DF8  cbnz     w8, #0x6861e1c
006861DFC  adrp     x0, #0x8efa000
006861E00  ldr      x0, [x0, #0x120] ; GLOBAL Method$LocalModels.Const.IsSkillABTestB() @ 0x9255f38
006861E04  bl       #0x382bd14 ; 
006861E08  adrp     x0, #0x8ee8000
006861E0C  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo @ 0x91e3900
006861E10  bl       #0x382bd14 ; 
006861E14  mov      w8, #1
006861E18  strb     w8, [x23, #0xb85]
006861E1C  adrp     x8, #0x8efa000
006861E20  ldr      x8, [x8, #0x120] ; GLOBAL Method$LocalModels.Const.IsSkillABTestB() @ 0x9255f38
006861E24  ldr      x0, [x8]
006861E28  ldrb     w8, [x0, #0x53]
006861E2C  tbnz     w8, #5, #0x6861e88
006861E30  ldr      x0, [x19]
006861E34  ldr      w8, [x0, #0xe0]
006861E38  cbnz     w8, #0x6861e44
006861E3C  bl       #0x382be8c ; 
006861E40  ldr      x0, [x19]
006861E44  ldr      x8, [x0, #0xb8]
006861E48  ldrb     w8, [x8, #0x530]
006861E4C  cbnz     w8, #0x68623e4
006861E50  b        #0x6861e94 ; 
006861E54  ldr      x5, [x4, #0x60]
006861E58  mov      x0, x22
006861E5C  mov      x1, x21
006861E60  mov      x2, x20
006861E64  mov      x3, x27
006861E68  ldp      x20, x19, [sp, #0x80]
006861E6C  ldp      x22, x21, [sp, #0x70]
006861E70  ldp      x24, x23, [sp, #0x60]
006861E74  ldp      x26, x25, [sp, #0x50]
006861E78  ldp      x28, x27, [sp, #0x40]
006861E7C  ldp      x29, x30, [sp, #0x30]
006861E80  add      sp, sp, #0x90
006861E84  br       x5
006861E88  ldr      x8, [x0, #0x60]
006861E8C  blr      x8
006861E90  tbnz     w0, #0, #0x68623e4
006861E94  cbz      x21, #0x6862408
006861E98  adrp     x19, #0x959b000
006861E9C  ldrb     w8, [x19, #0xb86]
006861EA0  cbnz     w8, #0x6861eb8
006861EA4  adrp     x0, #0x8f23000
006861EA8  ldr      x0, [x0, #0xcc8] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_UnlockUpgradeNeddSkill() @ 0x92ac580
006861EAC  bl       #0x382bd14 ; 
006861EB0  mov      w8, #1
006861EB4  strb     w8, [x19, #0xb86]
006861EB8  adrp     x8, #0x8f23000
006861EBC  ldr      x8, [x8, #0xcc8] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_UnlockUpgradeNeddSkill() @ 0x92ac580
006861EC0  ldr      x1, [x8]
006861EC4  ldrb     w8, [x1, #0x53]
006861EC8  tbnz     w8, #5, #0x6861ed4
006861ECC  ldr      x23, [x21, #0x48]
006861ED0  b        #0x6861ee4 ; 
006861ED4  ldr      x8, [x1, #0x60]
006861ED8  mov      x0, x21
006861EDC  blr      x8
006861EE0  mov      x23, x0
006861EE4  adrp     x19, #0x959b000
006861EE8  ldrb     w8, [x19, #0xb87]
006861EEC  cbnz     w8, #0x6861f04
006861EF0  adrp     x0, #0x8f23000
006861EF4  ldr      x0, [x0, #0xcd0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_UnlockUpgradeId() @ 0x92ac578
006861EF8  bl       #0x382bd14 ; 
006861EFC  mov      w8, #1
006861F00  strb     w8, [x19, #0xb87]
006861F04  adrp     x8, #0x8f23000
006861F08  ldr      x8, [x8, #0xcd0] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_UnlockUpgradeId() @ 0x92ac578
006861F0C  ldr      x1, [x8]
006861F10  ldrb     w8, [x1, #0x53]
006861F14  tbnz     w8, #5, #0x6861f28
006861F18  ldr      x8, [x21, #0x50]
006861F1C  str      x8, [sp, #0x18]
006861F20  cbnz     x23, #0x6861f3c
006861F24  b        #0x68623e4 ; 
006861F28  ldr      x8, [x1, #0x60]
006861F2C  mov      x0, x21
006861F30  blr      x8
006861F34  str      x0, [sp, #0x18]
006861F38  cbz      x23, #0x68623e4
006861F3C  ldr      x8, [sp, #0x18]
006861F40  cbz      x8, #0x68623e4
006861F44  adrp     x8, #0x8ebf000
006861F48  ldr      x8, [x8, #0x840] ; GLOBAL System.Math_TypeInfo @ 0x91ec0b0
006861F4C  ldr      x0, [x8]
006861F50  ldr      w8, [x0, #0xe0]
006861F54  cbnz     w8, #0x6861f5c
006861F58  bl       #0x382be8c ; 
006861F5C  ldr      x8, [sp, #0x18]
006861F60  ldr      w0, [x23, #0x18]
006861F64  mov      x2, xzr
006861F68  ldr      w1, [x8, #0x18]
006861F6C  bl       #0x7bd69a0 ; System.Math$$Min
006861F70  cmp      w0, #1
006861F74  b.lt     #0x68623e4
006861F78  ldr      x8, [sp, #0x18]
006861F7C  mov      x25, xzr
006861F80  mov      w19, w0
006861F84  add      x24, x23, #0x20
006861F88  add      x8, x8, #0x20
006861F8C  stp      x27, x8, [sp, #8]
006861F90  ldr      w8, [x23, #0x18]
006861F94  cmp      x25, x8
006861F98  b.hs     #0x6862404
006861F9C  ldr      w1, [x24, x25, lsl #2]
006861FA0  cbz      w1, #0x68623d8
006861FA4  cbz      x20, #0x6862408
006861FA8  adrp     x8, #0x8f08000
006861FAC  ldr      x8, [x8, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains() @ 0x921de60
006861FB0  mov      x0, x20
006861FB4  ldr      x2, [x8]
006861FB8  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006861FBC  tbz      w0, #0, #0x68623d8
006861FC0  ldr      x8, [sp, #0x18]
006861FC4  ldr      w8, [x8, #0x18]
006861FC8  cmp      x25, x8
006861FCC  b.hs     #0x6862404
006861FD0  ldr      x8, [sp, #0x10]
006861FD4  ldr      w8, [x8, x25, lsl #2]
006861FD8  cbz      w8, #0x68623d8
006861FDC  mov      x0, x22
006861FE0  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006861FE4  cbz      x0, #0x6862408
006861FE8  adrp     x8, #0x9598000
006861FEC  ldrb     w8, [x8, #0xfcc]
006861FF0  mov      x26, x0
006861FF4  cbnz     w8, #0x6862010
006861FF8  adrp     x0, #0x8f06000
006861FFC  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006862000  bl       #0x382bd14 ; 
006862004  adrp     x8, #0x9598000
006862008  mov      w9, #1
00686200C  strb     w9, [x8, #0xfcc]
006862010  adrp     x8, #0x8f06000
006862014  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006862018  ldr      x1, [x8]
00686201C  ldrb     w8, [x1, #0x53]
006862020  tbnz     w8, #5, #0x686202c
006862024  ldr      x0, [x26, #0x200]
006862028  b        #0x6862038 ; 
00686202C  ldr      x8, [x1, #0x60]
006862030  mov      x0, x26
006862034  blr      x8
006862038  ldr      x8, [sp, #0x18]
00686203C  ldr      w8, [x8, #0x18]
006862040  cmp      x25, x8
006862044  b.hs     #0x6862404
006862048  cbz      x0, #0x6862408
00686204C  ldr      x8, [sp, #0x10]
006862050  mov      x2, xzr
006862054  ldr      w1, [x8, x25, lsl #2]
006862058  bl       #0x64deae8 ; LocalModels.LocalModelManager$$GetSkillGroup_UpgradeSkillGroup
00686205C  cbz      x0, #0x68623d8
006862060  adrp     x8, #0x959b000
006862064  ldrb     w8, [x8, #0xb88]
006862068  mov      x26, x0
00686206C  cbnz     w8, #0x6862088
006862070  adrp     x0, #0x8f23000
006862074  ldr      x0, [x0, #0xcd8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_UpgradeSkillGroup.get_GetID() @ 0x92ab910
006862078  bl       #0x382bd14 ; 
00686207C  mov      w8, #1
006862080  adrp     x9, #0x959b000
006862084  strb     w8, [x9, #0xb88]
006862088  adrp     x8, #0x8f23000
00686208C  ldr      x8, [x8, #0xcd8] ; GLOBAL Method$LocalModels.Bean.SkillGroup_UpgradeSkillGroup.get_GetID() @ 0x92ab910
006862090  ldr      x1, [x8]
006862094  ldrb     w8, [x1, #0x53]
006862098  tbnz     w8, #5, #0x68620a4
00686209C  ldr      w28, [x26, #0x24]
0068620A0  b        #0x68620b4 ; 
0068620A4  ldr      x8, [x1, #0x60]
0068620A8  mov      x0, x26
0068620AC  blr      x8
0068620B0  mov      w28, w0
0068620B4  adrp     x8, #0x959b000
0068620B8  ldrb     w8, [x8, #0xb89]
0068620BC  cbnz     w8, #0x68620d8
0068620C0  adrp     x0, #0x8f23000
0068620C4  ldr      x0, [x0, #0xce0] ; GLOBAL Method$LocalModels.Bean.SkillGroup_UpgradeSkillGroup.get_Weight() @ 0x92ab918
0068620C8  bl       #0x382bd14 ; 
0068620CC  mov      w8, #1
0068620D0  adrp     x9, #0x959b000
0068620D4  strb     w8, [x9, #0xb89]
0068620D8  adrp     x8, #0x8f23000
0068620DC  ldr      x8, [x8, #0xce0] ; GLOBAL Method$LocalModels.Bean.SkillGroup_UpgradeSkillGroup.get_Weight() @ 0x92ab918
0068620E0  ldr      x1, [x8]
0068620E4  ldrb     w8, [x1, #0x53]
0068620E8  tbnz     w8, #5, #0x68620f4
0068620EC  ldr      w29, [x26, #0x28]
0068620F0  b        #0x6862104 ; 
0068620F4  ldr      x8, [x1, #0x60]
0068620F8  mov      x0, x26
0068620FC  blr      x8
006862100  mov      w29, w0
006862104  cmp      w29, #1
006862108  b.lt     #0x68623d8
00686210C  mov      x0, x22
006862110  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006862114  cbz      x0, #0x6862408
006862118  adrp     x8, #0x9598000
00686211C  ldrb     w8, [x8, #0xfcc]
006862120  mov      x26, x0
006862124  cbnz     w8, #0x6862140
006862128  adrp     x0, #0x8f06000
00686212C  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006862130  bl       #0x382bd14 ; 
006862134  adrp     x8, #0x9598000
006862138  mov      w9, #1
00686213C  strb     w9, [x8, #0xfcc]
006862140  adrp     x8, #0x8f06000
006862144  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006862148  ldr      x1, [x8]
00686214C  ldrb     w8, [x1, #0x53]
006862150  tbnz     w8, #5, #0x686215c
006862154  ldr      x0, [x26, #0x200]
006862158  b        #0x6862168 ; 
00686215C  ldr      x8, [x1, #0x60]
006862160  mov      x0, x26
006862164  blr      x8
006862168  cbz      x0, #0x6862408
00686216C  mov      w1, w28
006862170  mov      x2, xzr
006862174  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006862178  cbz      x0, #0x68623d8
00686217C  mov      w1, #1
006862180  mov      x2, xzr
006862184  bl       #0x64c91a0 ; LocalModelEx$$GetSkillDeepType
006862188  cbz      x27, #0x6862408
00686218C  ldr      w8, [x27, #0x18]
006862190  mov      w26, w0
006862194  cmp      w0, w8
006862198  b.hs     #0x6862404
00686219C  ldr      x8, [x22]
0068621A0  mov      x9, x27
0068621A4  sxtw     x27, w26
0068621A8  add      x9, x9, x27, lsl #3
0068621AC  ldr      x1, [x9, #0x20]
0068621B0  ldr      x9, [x8, #0x228]
0068621B4  ldr      x5, [x8, #0x230]
0068621B8  mov      x0, x22
0068621BC  mov      w2, w28
0068621C0  mov      w3, w29
0068621C4  mov      x4, x20
0068621C8  blr      x9
0068621CC  ldr      x8, [x22, #0x30]
0068621D0  cbz      x8, #0x6862408
0068621D4  ldr      w9, [x8, #0x18]
0068621D8  cmp      w26, w9
0068621DC  b.hs     #0x6862404
0068621E0  ldr      x9, [x22]
0068621E4  add      x8, x8, x27, lsl #3
0068621E8  ldr      x1, [x8, #0x20]
0068621EC  mov      x0, x22
0068621F0  ldr      x8, [x9, #0x228]
0068621F4  ldr      x5, [x9, #0x230]
0068621F8  mov      w2, w28
0068621FC  mov      w3, w29
006862200  mov      x4, x20
006862204  blr      x8
006862208  adrp     x8, #0x8ec2000
00686220C  ldr      x8, [x8, #0xbc8] ; GLOBAL object[]_TypeInfo @ 0x91df400
006862210  mov      w1, #4
006862214  ldr      x0, [x8]
006862218  bl       #0x382bdfc ; 
00686221C  adrp     x8, #0x8ebf000
006862220  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006862224  mov      x26, x0
006862228  add      x1, sp, #0x2c
00686222C  str      w25, [sp, #0x2c]
006862230  ldr      x0, [x8]
006862234  bl       #0x382be94 ; 
006862238  cbz      x26, #0x6862408
00686223C  mov      x27, x0
006862240  cbz      x0, #0x6862258
006862244  ldr      x8, [x26]
006862248  mov      x0, x27
00686224C  ldr      x1, [x8, #0x40]
006862250  bl       #0x382be90 ; 
006862254  cbz      x0, #0x686240c
006862258  ldr      w8, [x26, #0x18]
00686225C  cbz      w8, #0x6862404
006862260  mov      x0, x26
006862264  str      x27, [x0, #0x20]!
006862268  mov      x1, x27
00686226C  bl       #0x382bcb8 ; 
006862270  adrp     x8, #0x8ebf000
006862274  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006862278  add      x1, sp, #0x28
00686227C  str      w28, [sp, #0x28]
006862280  ldr      x0, [x8]
006862284  bl       #0x382be94 ; 
006862288  mov      x27, x0
00686228C  cbz      x0, #0x68622a4
006862290  ldr      x8, [x26]
006862294  mov      x0, x27
006862298  ldr      x1, [x8, #0x40]
00686229C  bl       #0x382be90 ; 
0068622A0  cbz      x0, #0x686240c
0068622A4  ldr      w8, [x26, #0x18]
0068622A8  cmp      w8, #1
0068622AC  b.ls     #0x6862404
0068622B0  mov      x0, x26
0068622B4  str      x27, [x0, #0x28]!
0068622B8  mov      x1, x27
0068622BC  bl       #0x382bcb8 ; 
0068622C0  adrp     x8, #0x8ebf000
0068622C4  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
0068622C8  add      x1, sp, #0x24
0068622CC  str      w29, [sp, #0x24]
0068622D0  ldr      x0, [x8]
0068622D4  bl       #0x382be94 ; 
0068622D8  mov      x27, x0
0068622DC  cbz      x0, #0x68622f4
0068622E0  ldr      x8, [x26]
0068622E4  mov      x0, x27
0068622E8  ldr      x1, [x8, #0x40]
0068622EC  bl       #0x382be90 ; 
0068622F0  cbz      x0, #0x686240c
0068622F4  ldr      w8, [x26, #0x18]
0068622F8  cmp      w8, #2
0068622FC  b.ls     #0x6862404
006862300  mov      x0, x26
006862304  str      x27, [x0, #0x30]!
006862308  mov      x1, x27
00686230C  bl       #0x382bcb8 ; 
006862310  adrp     x8, #0x9598000
006862314  ldrb     w8, [x8, #0xde3]
006862318  cbnz     w8, #0x6862334
00686231C  adrp     x0, #0x8f00000
006862320  ldr      x0, [x0, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
006862324  bl       #0x382bd14 ; 
006862328  mov      w8, #1
00686232C  adrp     x9, #0x9598000
006862330  strb     w8, [x9, #0xde3]
006862334  adrp     x8, #0x8f00000
006862338  ldr      x8, [x8, #0xd98] ; GLOBAL Method$LocalModels.Bean.Skill_Main.get_id() @ 0x92ac598
00686233C  ldr      x1, [x8]
006862340  ldrb     w8, [x1, #0x53]
006862344  tbnz     w8, #5, #0x6862350
006862348  ldr      w0, [x21, #0x20]
00686234C  b        #0x686235c ; 
006862350  ldr      x8, [x1, #0x60]
006862354  mov      x0, x21
006862358  blr      x8
00686235C  adrp     x8, #0x8ebf000
006862360  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006862364  str      w0, [sp, #0x20]
006862368  add      x1, sp, #0x20
00686236C  ldr      x8, [x8]
006862370  mov      x0, x8
006862374  bl       #0x382be94 ; 
006862378  mov      x27, x0
00686237C  cbz      x0, #0x6862394
006862380  ldr      x8, [x26]
006862384  mov      x0, x27
006862388  ldr      x1, [x8, #0x40]
00686238C  bl       #0x382be90 ; 
006862390  cbz      x0, #0x686240c
006862394  ldr      w8, [x26, #0x18]
006862398  cmp      w8, #3
00686239C  b.ls     #0x6862404
0068623A0  mov      x0, x26
0068623A4  str      x27, [x0, #0x38]!
0068623A8  mov      x1, x27
0068623AC  bl       #0x382bcb8 ; 
0068623B0  adrp     x8, #0x8f23000
0068623B4  ldr      x8, [x8, #0xcf8] ; GLOBAL -[TryUnlockUpgradeSkillsForPunchboard] 模拟解锁质变技能 chainIndex={0} upgradeSkillId={1} weight={2}  skillId = {3} @ 0x92eac00
0068623B8  mov      x1, x26
0068623BC  mov      x2, xzr
0068623C0  ldr      x0, [x8]
0068623C4  bl       #0x79e281c ; System.String$$Format
0068623C8  mov      x1, x0
0068623CC  mov      x0, x22
0068623D0  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
0068623D4  ldr      x27, [sp, #8]
0068623D8  add      x25, x25, #1
0068623DC  cmp      x19, x25
0068623E0  b.ne     #0x6861f90
0068623E4  ldp      x20, x19, [sp, #0x80]
0068623E8  ldp      x22, x21, [sp, #0x70]
0068623EC  ldp      x24, x23, [sp, #0x60]
0068623F0  ldp      x26, x25, [sp, #0x50]
0068623F4  ldp      x28, x27, [sp, #0x40]
0068623F8  ldp      x29, x30, [sp, #0x30]
0068623FC  add      sp, sp, #0x90
006862400  ret      
006862404  bl       #0x382bfc0 ; 
006862408  bl       #0x382bfb8 ; 
00686240C  bl       #0x382bfdc ; 
006862410  mov      x1, xzr
006862414  bl       #0x382be7c ; 

