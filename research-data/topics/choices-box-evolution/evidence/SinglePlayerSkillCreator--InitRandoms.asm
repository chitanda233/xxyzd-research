; HotFix.BattleLogic.SinglePlayerSkillCreator$$InitRandoms
; RVA 0x6875D08; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006875D08  stp      x29, x30, [sp, #-0x60]!
006875D0C  stp      x28, x27, [sp, #0x10]
006875D10  stp      x26, x25, [sp, #0x20]
006875D14  stp      x24, x23, [sp, #0x30]
006875D18  stp      x22, x21, [sp, #0x40]
006875D1C  stp      x20, x19, [sp, #0x50]
006875D20  adrp     x21, #0x959b000
006875D24  adrp     x23, #0x8f24000
006875D28  ldrb     w8, [x21, #0xab3]
006875D2C  ldr      x23, [x23, #0x520] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.InitRandoms() @ 0x92aa978
006875D30  mov      x20, x2
006875D34  mov      w22, w1
006875D38  mov      x19, x0
006875D3C  tbnz     w8, #0, #0x6875de4
006875D40  adrp     x0, #0x8ebf000
006875D44  ldr      x0, [x0, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
006875D48  bl       #0x382bd14 ; 
006875D4C  adrp     x0, #0x8f24000
006875D50  ldr      x0, [x0, #0x528] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_InitBaseGroup>_TypeInfo @ 0x91d76b8
006875D54  bl       #0x382bd14 ; 
006875D58  adrp     x0, #0x8f24000
006875D5C  ldr      x0, [x0, #0x530] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_InfinateSkillGroup>_TypeInfo @ 0x91d76a8
006875D60  bl       #0x382bd14 ; 
006875D64  adrp     x0, #0x8f23000
006875D68  ldr      x0, [x0, #0xdb0] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_SurvivorGroup>_TypeInfo @ 0x91d76c8
006875D6C  bl       #0x382bd14 ; 
006875D70  adrp     x0, #0x8f24000
006875D74  ldr      x0, [x0, #0x538] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_BaseGroup>_TypeInfo @ 0x91d76a0
006875D78  bl       #0x382bd14 ; 
006875D7C  adrp     x0, #0x8f24000
006875D80  ldr      x0, [x0, #0x540] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_InitSurvivorGroup>_TypeInfo @ 0x91d76c0
006875D84  bl       #0x382bd14 ; 
006875D88  adrp     x0, #0x8f23000
006875D8C  ldr      x0, [x0, #0xdb8] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_SurvivorGroup>_TypeInfo @ 0x91d80e0
006875D90  bl       #0x382bd14 ; 
006875D94  adrp     x0, #0x8f24000
006875D98  ldr      x0, [x0, #0x548] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_InitBaseGroup>_TypeInfo @ 0x91d80d0
006875D9C  bl       #0x382bd14 ; 
006875DA0  adrp     x0, #0x8f24000
006875DA4  ldr      x0, [x0, #0x550] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_InitSurvivorGroup>_TypeInfo @ 0x91d80d8
006875DA8  bl       #0x382bd14 ; 
006875DAC  adrp     x0, #0x8f24000
006875DB0  ldr      x0, [x0, #0x558] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_BaseGroup>_TypeInfo @ 0x91d80b8
006875DB4  bl       #0x382bd14 ; 
006875DB8  adrp     x0, #0x8f24000
006875DBC  ldr      x0, [x0, #0x560] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_InfinateSkillGroup>_TypeInfo @ 0x91d80c0
006875DC0  bl       #0x382bd14 ; 
006875DC4  adrp     x0, #0x8ebf000
006875DC8  ldr      x0, [x0, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
006875DCC  bl       #0x382bd14 ; 
006875DD0  adrp     x0, #0x8f24000
006875DD4  ldr      x0, [x0, #0x520] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.InitRandoms() @ 0x92aa978
006875DD8  bl       #0x382bd14 ; 
006875DDC  mov      w8, #1
006875DE0  strb     w8, [x21, #0xab3]
006875DE4  ldr      x3, [x23]
006875DE8  ldrb     w8, [x3, #0x53]
006875DEC  tbnz     w8, #5, #0x6875e70
006875DF0  cmp      w22, #8
006875DF4  adrp     x25, #0x9598000
006875DF8  b.hi     #0x68765f8
006875DFC  mov      w8, #1
006875E00  lsl      w8, w8, w22
006875E04  mov      w9, #0x190
006875E08  tst      w8, w9
006875E0C  b.eq     #0x68765f8
006875E10  mov      x0, x19
006875E14  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006875E18  cbz      x0, #0x6876a64
006875E1C  mov      x1, xzr
006875E20  bl       #0x6a04794 ; HotFix.BattleLogic.BattleWorldContext$$IsDankeSkill
006875E24  tbz      w0, #0, #0x68765f8
006875E28  mov      x0, x19
006875E2C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006875E30  cbz      x0, #0x6876a64
006875E34  ldrb     w8, [x25, #0xfcc]
006875E38  mov      x22, x0
006875E3C  cbnz     w8, #0x6875e54
006875E40  adrp     x0, #0x8f06000
006875E44  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006875E48  bl       #0x382bd14 ; 
006875E4C  mov      w8, #1
006875E50  strb     w8, [x25, #0xfcc]
006875E54  adrp     x8, #0x8f06000
006875E58  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006875E5C  ldr      x1, [x8]
006875E60  ldrb     w8, [x1, #0x53]
006875E64  tbnz     w8, #5, #0x6875e9c
006875E68  ldr      x0, [x22, #0x200]
006875E6C  b        #0x6875ea8 ; 
006875E70  ldr      x4, [x3, #0x60]
006875E74  mov      x0, x19
006875E78  mov      w1, w22
006875E7C  mov      x2, x20
006875E80  ldp      x20, x19, [sp, #0x50]
006875E84  ldp      x22, x21, [sp, #0x40]
006875E88  ldp      x24, x23, [sp, #0x30]
006875E8C  ldp      x26, x25, [sp, #0x20]
006875E90  ldp      x28, x27, [sp, #0x10]
006875E94  ldp      x29, x30, [sp], #0x60
006875E98  br       x4
006875E9C  ldr      x8, [x1, #0x60]
006875EA0  mov      x0, x22
006875EA4  blr      x8
006875EA8  cbz      x0, #0x6876a64
006875EAC  mov      x1, xzr
006875EB0  bl       #0x64d08d0 ; LocalModels.LocalModelManager$$GetSkillGroup_SurvivorGroupElements
006875EB4  cbz      x0, #0x6876a64
006875EB8  adrp     x10, #0x8f23000
006875EBC  ldr      x8, [x0]
006875EC0  ldr      x10, [x10, #0xdb0] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_SurvivorGroup>_TypeInfo @ 0x91d76c8
006875EC4  mov      x22, x0
006875EC8  ldrh     w9, [x8, #0x12e]
006875ECC  ldr      x1, [x10]
006875ED0  cbz      x9, #0x6875ef4
006875ED4  ldr      x10, [x8, #0xb0]
006875ED8  add      x10, x10, #8
006875EDC  ldur     x11, [x10, #-8]
006875EE0  cmp      x11, x1
006875EE4  b.eq     #0x6875f04
006875EE8  subs     x9, x9, #1
006875EEC  add      x10, x10, #0x10
006875EF0  b.ne     #0x6875edc
006875EF4  mov      x0, x22
006875EF8  mov      w2, wzr
006875EFC  bl       #0x3a7e710 ; 
006875F00  b        #0x6875f10 ; 
006875F04  ldrsw    x9, [x10]
006875F08  add      x8, x8, x9, lsl #4
006875F0C  add      x0, x8, #0x138
006875F10  ldp      x8, x1, [x0]
006875F14  mov      x0, x22
006875F18  blr      x8
006875F1C  mov      x22, x0
006875F20  cbz      x0, #0x6876a8c
006875F24  adrp     x21, #0x8ebf000
006875F28  adrp     x23, #0x8f23000
006875F2C  ldr      x21, [x21, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
006875F30  ldr      x23, [x23, #0xdb8] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_SurvivorGroup>_TypeInfo @ 0x91d80e0
006875F34  ldr      x8, [x22]
006875F38  ldr      x1, [x21]
006875F3C  ldrh     w9, [x8, #0x12e]
006875F40  cbz      x9, #0x6875f64
006875F44  ldr      x10, [x8, #0xb0]
006875F48  add      x10, x10, #8
006875F4C  ldur     x11, [x10, #-8]
006875F50  cmp      x11, x1
006875F54  b.eq     #0x6875f74
006875F58  subs     x9, x9, #1
006875F5C  add      x10, x10, #0x10
006875F60  b.ne     #0x6875f4c
006875F64  mov      x0, x22
006875F68  mov      w2, wzr
006875F6C  bl       #0x3a7e710 ; 
006875F70  b        #0x6875f80 ; 
006875F74  ldrsw    x9, [x10]
006875F78  add      x8, x8, x9, lsl #4
006875F7C  add      x0, x8, #0x138
006875F80  ldp      x8, x1, [x0]
006875F84  mov      x0, x22
006875F88  blr      x8
006875F8C  tbz      w0, #0, #0x6876000
006875F90  ldr      x8, [x22]
006875F94  ldr      x1, [x23]
006875F98  ldrh     w9, [x8, #0x12e]
006875F9C  cbz      x9, #0x6875fc0
006875FA0  ldr      x10, [x8, #0xb0]
006875FA4  add      x10, x10, #8
006875FA8  ldur     x11, [x10, #-8]
006875FAC  cmp      x11, x1
006875FB0  b.eq     #0x6875fd0
006875FB4  subs     x9, x9, #1
006875FB8  add      x10, x10, #0x10
006875FBC  b.ne     #0x6875fa8
006875FC0  mov      x0, x22
006875FC4  mov      w2, wzr
006875FC8  bl       #0x3a7e710 ; 
006875FCC  b        #0x6875fdc ; 
006875FD0  ldrsw    x9, [x10]
006875FD4  add      x8, x8, x9, lsl #4
006875FD8  add      x0, x8, #0x138
006875FDC  ldp      x8, x1, [x0]
006875FE0  mov      x0, x22
006875FE4  blr      x8
006875FE8  ldr      x1, [x19, #0x48]
006875FEC  mov      x2, x0
006875FF0  mov      x0, x19
006875FF4  mov      x3, x20
006875FF8  bl       #0x687260c ; HotFix.BattleLogic.HeroSkillCreator$$AddDankeSkillGroupToRandom
006875FFC  b        #0x6875f34 ; 
006876000  mov      x24, xzr
006876004  mov      w21, #6
006876008  cbz      x22, #0x687606c
00687600C  adrp     x10, #0x8ebf000
006876010  ldr      x8, [x22]
006876014  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
006876018  ldrh     w9, [x8, #0x12e]
00687601C  ldr      x1, [x10]
006876020  cbz      x9, #0x6876044
006876024  ldr      x10, [x8, #0xb0]
006876028  add      x10, x10, #8
00687602C  ldur     x11, [x10, #-8]
006876030  cmp      x11, x1
006876034  b.eq     #0x6876054
006876038  subs     x9, x9, #1
00687603C  add      x10, x10, #0x10
006876040  b.ne     #0x687602c
006876044  mov      x0, x22
006876048  mov      w2, wzr
00687604C  bl       #0x3a7e710 ; 
006876050  b        #0x6876060 ; 
006876054  ldrsw    x9, [x10]
006876058  add      x8, x8, x9, lsl #4
00687605C  add      x0, x8, #0x138
006876060  ldp      x8, x1, [x0]
006876064  mov      x0, x22
006876068  blr      x8
00687606C  cbnz     x24, #0x6876a74
006876070  cmp      w21, #6
006876074  b.eq     #0x687607c
006876078  cbnz     w21, #0x6876a48
00687607C  mov      x0, x19
006876080  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006876084  cbz      x0, #0x6876a64
006876088  ldrb     w8, [x25, #0xfcc]
00687608C  mov      x22, x0
006876090  cbnz     w8, #0x68760a8
006876094  adrp     x0, #0x8f06000
006876098  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00687609C  bl       #0x382bd14 ; 
0068760A0  mov      w8, #1
0068760A4  strb     w8, [x25, #0xfcc]
0068760A8  adrp     x8, #0x8f06000
0068760AC  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068760B0  ldr      x1, [x8]
0068760B4  ldrb     w8, [x1, #0x53]
0068760B8  tbnz     w8, #5, #0x68760c4
0068760BC  ldr      x0, [x22, #0x200]
0068760C0  b        #0x68760d0 ; 
0068760C4  ldr      x8, [x1, #0x60]
0068760C8  mov      x0, x22
0068760CC  blr      x8
0068760D0  cbz      x0, #0x6876a64
0068760D4  mov      x1, xzr
0068760D8  bl       #0x64d7434 ; LocalModels.LocalModelManager$$GetSkillGroup_InitSurvivorGroupElements
0068760DC  cbz      x0, #0x6876a64
0068760E0  adrp     x10, #0x8f24000
0068760E4  ldr      x8, [x0]
0068760E8  ldr      x10, [x10, #0x540] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_InitSurvivorGroup>_TypeInfo @ 0x91d76c0
0068760EC  mov      x22, x0
0068760F0  ldrh     w9, [x8, #0x12e]
0068760F4  ldr      x1, [x10]
0068760F8  cbz      x9, #0x687611c
0068760FC  ldr      x10, [x8, #0xb0]
006876100  add      x10, x10, #8
006876104  ldur     x11, [x10, #-8]
006876108  cmp      x11, x1
00687610C  b.eq     #0x687612c
006876110  subs     x9, x9, #1
006876114  add      x10, x10, #0x10
006876118  b.ne     #0x6876104
00687611C  mov      x0, x22
006876120  mov      w2, wzr
006876124  bl       #0x3a7e710 ; 
006876128  b        #0x6876138 ; 
00687612C  ldrsw    x9, [x10]
006876130  add      x8, x8, x9, lsl #4
006876134  add      x0, x8, #0x138
006876138  ldp      x8, x1, [x0]
00687613C  mov      x0, x22
006876140  blr      x8
006876144  mov      x22, x0
006876148  cbz      x0, #0x6876a90
00687614C  adrp     x21, #0x8ebf000
006876150  adrp     x23, #0x8f24000
006876154  ldr      x21, [x21, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
006876158  ldr      x23, [x23, #0x550] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_InitSurvivorGroup>_TypeInfo @ 0x91d80d8
00687615C  ldr      x8, [x22]
006876160  ldr      x1, [x21]
006876164  ldrh     w9, [x8, #0x12e]
006876168  cbz      x9, #0x687618c
00687616C  ldr      x10, [x8, #0xb0]
006876170  add      x10, x10, #8
006876174  ldur     x11, [x10, #-8]
006876178  cmp      x11, x1
00687617C  b.eq     #0x687619c
006876180  subs     x9, x9, #1
006876184  add      x10, x10, #0x10
006876188  b.ne     #0x6876174
00687618C  mov      x0, x22
006876190  mov      w2, wzr
006876194  bl       #0x3a7e710 ; 
006876198  b        #0x68761a8 ; 
00687619C  ldrsw    x9, [x10]
0068761A0  add      x8, x8, x9, lsl #4
0068761A4  add      x0, x8, #0x138
0068761A8  ldp      x8, x1, [x0]
0068761AC  mov      x0, x22
0068761B0  blr      x8
0068761B4  tbz      w0, #0, #0x6876228
0068761B8  ldr      x8, [x22]
0068761BC  ldr      x1, [x23]
0068761C0  ldrh     w9, [x8, #0x12e]
0068761C4  cbz      x9, #0x68761e8
0068761C8  ldr      x10, [x8, #0xb0]
0068761CC  add      x10, x10, #8
0068761D0  ldur     x11, [x10, #-8]
0068761D4  cmp      x11, x1
0068761D8  b.eq     #0x68761f8
0068761DC  subs     x9, x9, #1
0068761E0  add      x10, x10, #0x10
0068761E4  b.ne     #0x68761d0
0068761E8  mov      x0, x22
0068761EC  mov      w2, wzr
0068761F0  bl       #0x3a7e710 ; 
0068761F4  b        #0x6876204 ; 
0068761F8  ldrsw    x9, [x10]
0068761FC  add      x8, x8, x9, lsl #4
006876200  add      x0, x8, #0x138
006876204  ldp      x8, x1, [x0]
006876208  mov      x0, x22
00687620C  blr      x8
006876210  ldr      x1, [x19, #0x18]
006876214  mov      x2, x0
006876218  mov      x0, x19
00687621C  mov      x3, x20
006876220  bl       #0x687260c ; HotFix.BattleLogic.HeroSkillCreator$$AddDankeSkillGroupToRandom
006876224  b        #0x687615c ; 
006876228  mov      x24, xzr
00687622C  mov      w21, #9
006876230  cbz      x22, #0x6876294
006876234  adrp     x10, #0x8ebf000
006876238  ldr      x8, [x22]
00687623C  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
006876240  ldrh     w9, [x8, #0x12e]
006876244  ldr      x1, [x10]
006876248  cbz      x9, #0x687626c
00687624C  ldr      x10, [x8, #0xb0]
006876250  add      x10, x10, #8
006876254  ldur     x11, [x10, #-8]
006876258  cmp      x11, x1
00687625C  b.eq     #0x687627c
006876260  subs     x9, x9, #1
006876264  add      x10, x10, #0x10
006876268  b.ne     #0x6876254
00687626C  mov      x0, x22
006876270  mov      w2, wzr
006876274  bl       #0x3a7e710 ; 
006876278  b        #0x6876288 ; 
00687627C  ldrsw    x9, [x10]
006876280  add      x8, x8, x9, lsl #4
006876284  add      x0, x8, #0x138
006876288  ldp      x8, x1, [x0]
00687628C  mov      x0, x22
006876290  blr      x8
006876294  cbnz     x24, #0x6876a74
006876298  cmp      w21, #9
00687629C  b.eq     #0x68762a4
0068762A0  cbnz     w21, #0x6876a48
0068762A4  mov      x0, x19
0068762A8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068762AC  cbz      x0, #0x6876a64
0068762B0  ldrb     w8, [x25, #0xfcc]
0068762B4  mov      x22, x0
0068762B8  cbnz     w8, #0x68762d0
0068762BC  adrp     x0, #0x8f06000
0068762C0  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068762C4  bl       #0x382bd14 ; 
0068762C8  mov      w8, #1
0068762CC  strb     w8, [x25, #0xfcc]
0068762D0  adrp     x8, #0x8f06000
0068762D4  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068762D8  ldr      x1, [x8]
0068762DC  ldrb     w8, [x1, #0x53]
0068762E0  tbnz     w8, #5, #0x68762ec
0068762E4  ldr      x0, [x22, #0x200]
0068762E8  b        #0x68762f8 ; 
0068762EC  ldr      x8, [x1, #0x60]
0068762F0  mov      x0, x22
0068762F4  blr      x8
0068762F8  cbz      x0, #0x6876a64
0068762FC  mov      x1, xzr
006876300  bl       #0x64e24ec ; LocalModels.LocalModelManager$$GetSkillGroup_InfinateSkillGroupElements
006876304  cbz      x0, #0x6876a64
006876308  adrp     x10, #0x8f24000
00687630C  ldr      x8, [x0]
006876310  ldr      x10, [x10, #0x530] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_InfinateSkillGroup>_TypeInfo @ 0x91d76a8
006876314  mov      x22, x0
006876318  ldrh     w9, [x8, #0x12e]
00687631C  ldr      x1, [x10]
006876320  cbz      x9, #0x6876344
006876324  ldr      x10, [x8, #0xb0]
006876328  add      x10, x10, #8
00687632C  ldur     x11, [x10, #-8]
006876330  cmp      x11, x1
006876334  b.eq     #0x6876354
006876338  subs     x9, x9, #1
00687633C  add      x10, x10, #0x10
006876340  b.ne     #0x687632c
006876344  mov      x0, x22
006876348  mov      w2, wzr
00687634C  bl       #0x3a7e710 ; 
006876350  b        #0x6876360 ; 
006876354  ldrsw    x9, [x10]
006876358  add      x8, x8, x9, lsl #4
00687635C  add      x0, x8, #0x138
006876360  ldp      x8, x1, [x0]
006876364  mov      x0, x22
006876368  mov      x24, x25
00687636C  blr      x8
006876370  mov      x22, x0
006876374  cbz      x0, #0x6876a94
006876378  adrp     x29, #0x8ebf000
00687637C  adrp     x21, #0x8f24000
006876380  adrp     x23, #0x8f24000
006876384  ldr      x29, [x29, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
006876388  ldr      x21, [x21, #0x560] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_InfinateSkillGroup>_TypeInfo @ 0x91d80c0
00687638C  ldr      x23, [x23, #0x568] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InfinateSkillGroup.get_GetID() @ 0x92ab180
006876390  adrp     x28, #0x959b000
006876394  ldr      x8, [x22]
006876398  ldr      x1, [x29]
00687639C  ldrh     w9, [x8, #0x12e]
0068763A0  cbz      x9, #0x68763c4
0068763A4  ldr      x10, [x8, #0xb0]
0068763A8  add      x10, x10, #8
0068763AC  ldur     x11, [x10, #-8]
0068763B0  cmp      x11, x1
0068763B4  b.eq     #0x68763d4
0068763B8  subs     x9, x9, #1
0068763BC  add      x10, x10, #0x10
0068763C0  b.ne     #0x68763ac
0068763C4  mov      x0, x22
0068763C8  mov      w2, wzr
0068763CC  bl       #0x3a7e710 ; 
0068763D0  b        #0x68763e0 ; 
0068763D4  ldrsw    x9, [x10]
0068763D8  add      x8, x8, x9, lsl #4
0068763DC  add      x0, x8, #0x138
0068763E0  ldp      x8, x1, [x0]
0068763E4  mov      x0, x22
0068763E8  blr      x8
0068763EC  tbz      w0, #0, #0x6876580
0068763F0  ldr      x8, [x22]
0068763F4  ldr      x1, [x21]
0068763F8  ldrh     w9, [x8, #0x12e]
0068763FC  cbz      x9, #0x6876420
006876400  ldr      x10, [x8, #0xb0]
006876404  add      x10, x10, #8
006876408  ldur     x11, [x10, #-8]
00687640C  cmp      x11, x1
006876410  b.eq     #0x6876430
006876414  subs     x9, x9, #1
006876418  add      x10, x10, #0x10
00687641C  b.ne     #0x6876408
006876420  mov      x0, x22
006876424  mov      w2, wzr
006876428  bl       #0x3a7e710 ; 
00687642C  b        #0x687643c ; 
006876430  ldrsw    x9, [x10]
006876434  add      x8, x8, x9, lsl #4
006876438  add      x0, x8, #0x138
00687643C  ldp      x8, x1, [x0]
006876440  mov      x0, x22
006876444  blr      x8
006876448  mov      x25, x0
00687644C  cbz      x0, #0x6876a68
006876450  ldrb     w8, [x28, #0xbb8]
006876454  cbnz     w8, #0x6876468
006876458  mov      x0, x23
00687645C  bl       #0x382bd14 ; 
006876460  mov      w8, #1
006876464  strb     w8, [x28, #0xbb8]
006876468  ldr      x1, [x23]
00687646C  ldrb     w8, [x1, #0x53]
006876470  tbnz     w8, #5, #0x6876480
006876474  ldr      w26, [x25, #0x24]
006876478  cbnz     x20, #0x6876494
00687647C  b        #0x68764a4 ; 
006876480  ldr      x8, [x1, #0x60]
006876484  mov      x0, x25
006876488  blr      x8
00687648C  mov      w26, w0
006876490  cbz      x20, #0x68764a4
006876494  mov      x0, x20
006876498  mov      w1, w26
00687649C  bl       #0x685b6b8 ; HotFix.BattleLogic.HeroSkillCreator$$IsContain
0068764A0  tbnz     w0, #0, #0x6876394
0068764A4  mov      x0, x19
0068764A8  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
0068764AC  mov      x27, x0
0068764B0  cbz      x0, #0x6876a6c
0068764B4  ldrb     w8, [x24, #0xfcc]
0068764B8  cbnz     w8, #0x68764d0
0068764BC  adrp     x0, #0x8f06000
0068764C0  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068764C4  bl       #0x382bd14 ; 
0068764C8  mov      w8, #1
0068764CC  strb     w8, [x24, #0xfcc]
0068764D0  adrp     x8, #0x8f06000
0068764D4  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
0068764D8  ldr      x1, [x8]
0068764DC  ldrb     w8, [x1, #0x53]
0068764E0  tbnz     w8, #5, #0x68764ec
0068764E4  ldr      x0, [x27, #0x200]
0068764E8  b        #0x68764f8 ; 
0068764EC  ldr      x8, [x1, #0x60]
0068764F0  mov      x0, x27
0068764F4  blr      x8
0068764F8  cbz      x0, #0x6876a70
0068764FC  mov      w1, w26
006876500  mov      x2, xzr
006876504  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006876508  adrp     x8, #0x959b000
00687650C  ldrb     w8, [x8, #0xbb9]
006876510  ldr      x27, [x19, #0x40]
006876514  cbnz     w8, #0x6876530
006876518  adrp     x0, #0x8f24000
00687651C  ldr      x0, [x0, #0x570] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InfinateSkillGroup.get_Weight() @ 0x92ab188
006876520  bl       #0x382bd14 ; 
006876524  mov      w8, #1
006876528  adrp     x9, #0x959b000
00687652C  strb     w8, [x9, #0xbb9]
006876530  adrp     x8, #0x8f24000
006876534  ldr      x8, [x8, #0x570] ; GLOBAL Method$LocalModels.Bean.SkillGroup_InfinateSkillGroup.get_Weight() @ 0x92ab188
006876538  ldr      x1, [x8]
00687653C  ldrb     w8, [x1, #0x53]
006876540  tbnz     w8, #5, #0x687654c
006876544  ldr      w3, [x25, #0x28]
006876548  b        #0x687655c ; 
00687654C  ldr      x8, [x1, #0x60]
006876550  mov      x0, x25
006876554  blr      x8
006876558  mov      w3, w0
00687655C  ldr      x8, [x19]
006876560  ldr      x9, [x8, #0x228]
006876564  ldr      x5, [x8, #0x230]
006876568  mov      x0, x19
00687656C  mov      x1, x27
006876570  mov      w2, w26
006876574  mov      x4, xzr
006876578  blr      x9
00687657C  b        #0x6876394 ; 
006876580  mov      x26, xzr
006876584  mov      w21, wzr
006876588  mov      x25, x24
00687658C  cbz      x22, #0x68765f0
006876590  adrp     x10, #0x8ebf000
006876594  ldr      x8, [x22]
006876598  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
00687659C  ldrh     w9, [x8, #0x12e]
0068765A0  ldr      x1, [x10]
0068765A4  cbz      x9, #0x68765c8
0068765A8  ldr      x10, [x8, #0xb0]
0068765AC  add      x10, x10, #8
0068765B0  ldur     x11, [x10, #-8]
0068765B4  cmp      x11, x1
0068765B8  b.eq     #0x68765d8
0068765BC  subs     x9, x9, #1
0068765C0  add      x10, x10, #0x10
0068765C4  b.ne     #0x68765b0
0068765C8  mov      x0, x22
0068765CC  mov      w2, wzr
0068765D0  bl       #0x3a7e710 ; 
0068765D4  b        #0x68765e4 ; 
0068765D8  ldrsw    x9, [x10]
0068765DC  add      x8, x8, x9, lsl #4
0068765E0  add      x0, x8, #0x138
0068765E4  ldp      x8, x1, [x0]
0068765E8  mov      x0, x22
0068765EC  blr      x8
0068765F0  cbnz     x26, #0x6876a98
0068765F4  cbz      w21, #0x6876a48
0068765F8  mov      x0, x19
0068765FC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006876600  cbz      x0, #0x6876a64
006876604  ldrb     w8, [x25, #0xfcc]
006876608  mov      x22, x0
00687660C  cbnz     w8, #0x6876624
006876610  adrp     x0, #0x8f06000
006876614  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006876618  bl       #0x382bd14 ; 
00687661C  mov      w8, #1
006876620  strb     w8, [x25, #0xfcc]
006876624  adrp     x8, #0x8f06000
006876628  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00687662C  ldr      x1, [x8]
006876630  ldrb     w8, [x1, #0x53]
006876634  tbnz     w8, #5, #0x6876640
006876638  ldr      x0, [x22, #0x200]
00687663C  b        #0x687664c ; 
006876640  ldr      x8, [x1, #0x60]
006876644  mov      x0, x22
006876648  blr      x8
00687664C  cbz      x0, #0x6876a64
006876650  mov      x1, xzr
006876654  bl       #0x64d22a4 ; LocalModels.LocalModelManager$$GetSkillGroup_BaseGroupElements
006876658  cbz      x0, #0x6876a64
00687665C  adrp     x10, #0x8f24000
006876660  ldr      x8, [x0]
006876664  ldr      x10, [x10, #0x538] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_BaseGroup>_TypeInfo @ 0x91d76a0
006876668  mov      x22, x0
00687666C  ldrh     w9, [x8, #0x12e]
006876670  ldr      x1, [x10]
006876674  cbz      x9, #0x6876698
006876678  ldr      x10, [x8, #0xb0]
00687667C  add      x10, x10, #8
006876680  ldur     x11, [x10, #-8]
006876684  cmp      x11, x1
006876688  b.eq     #0x68766a8
00687668C  subs     x9, x9, #1
006876690  add      x10, x10, #0x10
006876694  b.ne     #0x6876680
006876698  mov      x0, x22
00687669C  mov      w2, wzr
0068766A0  bl       #0x3a7e710 ; 
0068766A4  b        #0x68766b4 ; 
0068766A8  ldrsw    x9, [x10]
0068766AC  add      x8, x8, x9, lsl #4
0068766B0  add      x0, x8, #0x138
0068766B4  ldp      x8, x1, [x0]
0068766B8  mov      x0, x22
0068766BC  blr      x8
0068766C0  mov      x22, x0
0068766C4  cbz      x0, #0x6876a7c
0068766C8  adrp     x21, #0x8ebf000
0068766CC  adrp     x23, #0x8f24000
0068766D0  ldr      x21, [x21, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
0068766D4  ldr      x23, [x23, #0x558] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_BaseGroup>_TypeInfo @ 0x91d80b8
0068766D8  ldr      x8, [x22]
0068766DC  ldr      x1, [x21]
0068766E0  ldrh     w9, [x8, #0x12e]
0068766E4  cbz      x9, #0x6876708
0068766E8  ldr      x10, [x8, #0xb0]
0068766EC  add      x10, x10, #8
0068766F0  ldur     x11, [x10, #-8]
0068766F4  cmp      x11, x1
0068766F8  b.eq     #0x6876718
0068766FC  subs     x9, x9, #1
006876700  add      x10, x10, #0x10
006876704  b.ne     #0x68766f0
006876708  mov      x0, x22
00687670C  mov      w2, wzr
006876710  bl       #0x3a7e710 ; 
006876714  b        #0x6876724 ; 
006876718  ldrsw    x9, [x10]
00687671C  add      x8, x8, x9, lsl #4
006876720  add      x0, x8, #0x138
006876724  ldp      x8, x1, [x0]
006876728  mov      x0, x22
00687672C  blr      x8
006876730  tbz      w0, #0, #0x68767a4
006876734  ldr      x8, [x22]
006876738  ldr      x1, [x23]
00687673C  ldrh     w9, [x8, #0x12e]
006876740  cbz      x9, #0x6876764
006876744  ldr      x10, [x8, #0xb0]
006876748  add      x10, x10, #8
00687674C  ldur     x11, [x10, #-8]
006876750  cmp      x11, x1
006876754  b.eq     #0x6876774
006876758  subs     x9, x9, #1
00687675C  add      x10, x10, #0x10
006876760  b.ne     #0x687674c
006876764  mov      x0, x22
006876768  mov      w2, wzr
00687676C  bl       #0x3a7e710 ; 
006876770  b        #0x6876780 ; 
006876774  ldrsw    x9, [x10]
006876778  add      x8, x8, x9, lsl #4
00687677C  add      x0, x8, #0x138
006876780  ldp      x8, x1, [x0]
006876784  mov      x0, x22
006876788  blr      x8
00687678C  ldr      x1, [x19, #0x48]
006876790  mov      x2, x0
006876794  mov      x0, x19
006876798  mov      x3, x20
00687679C  bl       #0x6872370 ; HotFix.BattleLogic.HeroSkillCreator$$AddSkillGroupToNormalRandom
0068767A0  b        #0x68766d8 ; 
0068767A4  mov      x24, xzr
0068767A8  cbz      x22, #0x687680c
0068767AC  adrp     x10, #0x8ebf000
0068767B0  ldr      x8, [x22]
0068767B4  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
0068767B8  ldrh     w9, [x8, #0x12e]
0068767BC  ldr      x1, [x10]
0068767C0  cbz      x9, #0x68767e4
0068767C4  ldr      x10, [x8, #0xb0]
0068767C8  add      x10, x10, #8
0068767CC  ldur     x11, [x10, #-8]
0068767D0  cmp      x11, x1
0068767D4  b.eq     #0x68767f4
0068767D8  subs     x9, x9, #1
0068767DC  add      x10, x10, #0x10
0068767E0  b.ne     #0x68767cc
0068767E4  mov      x0, x22
0068767E8  mov      w2, wzr
0068767EC  bl       #0x3a7e710 ; 
0068767F0  b        #0x6876800 ; 
0068767F4  ldrsw    x9, [x10]
0068767F8  add      x8, x8, x9, lsl #4
0068767FC  add      x0, x8, #0x138
006876800  ldp      x8, x1, [x0]
006876804  mov      x0, x22
006876808  blr      x8
00687680C  cbnz     x24, #0x6876a74
006876810  ldr      x8, [x19, #0x48]
006876814  cbz      x8, #0x6876a64
006876818  mov      x0, x19
00687681C  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006876820  cbz      x0, #0x6876a64
006876824  ldrb     w8, [x25, #0xfcc]
006876828  mov      x22, x0
00687682C  cbnz     w8, #0x6876844
006876830  adrp     x0, #0x8f06000
006876834  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006876838  bl       #0x382bd14 ; 
00687683C  mov      w8, #1
006876840  strb     w8, [x25, #0xfcc]
006876844  adrp     x8, #0x8f06000
006876848  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
00687684C  ldr      x1, [x8]
006876850  ldrb     w8, [x1, #0x53]
006876854  tbnz     w8, #5, #0x6876860
006876858  ldr      x0, [x22, #0x200]
00687685C  b        #0x687686c ; 
006876860  ldr      x8, [x1, #0x60]
006876864  mov      x0, x22
006876868  blr      x8
00687686C  cbz      x0, #0x6876a64
006876870  mov      x1, xzr
006876874  bl       #0x64d3c78 ; LocalModels.LocalModelManager$$GetSkillGroup_InitBaseGroupElements
006876878  cbz      x0, #0x6876a64
00687687C  adrp     x10, #0x8f24000
006876880  ldr      x8, [x0]
006876884  ldr      x10, [x10, #0x528] ; GLOBAL System.Collections.Generic.IEnumerable<SkillGroup_InitBaseGroup>_TypeInfo @ 0x91d76b8
006876888  mov      x21, x0
00687688C  ldrh     w9, [x8, #0x12e]
006876890  ldr      x1, [x10]
006876894  cbz      x9, #0x68768b8
006876898  ldr      x10, [x8, #0xb0]
00687689C  add      x10, x10, #8
0068768A0  ldur     x11, [x10, #-8]
0068768A4  cmp      x11, x1
0068768A8  b.eq     #0x68768c8
0068768AC  subs     x9, x9, #1
0068768B0  add      x10, x10, #0x10
0068768B4  b.ne     #0x68768a0
0068768B8  mov      x0, x21
0068768BC  mov      w2, wzr
0068768C0  bl       #0x3a7e710 ; 
0068768C4  b        #0x68768d4 ; 
0068768C8  ldrsw    x9, [x10]
0068768CC  add      x8, x8, x9, lsl #4
0068768D0  add      x0, x8, #0x138
0068768D4  ldp      x8, x1, [x0]
0068768D8  mov      x0, x21
0068768DC  blr      x8
0068768E0  mov      x21, x0
0068768E4  cbz      x0, #0x6876a80
0068768E8  adrp     x22, #0x8ebf000
0068768EC  adrp     x23, #0x8f24000
0068768F0  ldr      x22, [x22, #0x4f0] ; GLOBAL System.Collections.IEnumerator_TypeInfo @ 0x91e95d0
0068768F4  ldr      x23, [x23, #0x548] ; GLOBAL System.Collections.Generic.IEnumerator<SkillGroup_InitBaseGroup>_TypeInfo @ 0x91d80d0
0068768F8  ldr      x8, [x21]
0068768FC  ldr      x1, [x22]
006876900  ldrh     w9, [x8, #0x12e]
006876904  cbz      x9, #0x6876928
006876908  ldr      x10, [x8, #0xb0]
00687690C  add      x10, x10, #8
006876910  ldur     x11, [x10, #-8]
006876914  cmp      x11, x1
006876918  b.eq     #0x6876938
00687691C  subs     x9, x9, #1
006876920  add      x10, x10, #0x10
006876924  b.ne     #0x6876910
006876928  mov      x0, x21
00687692C  mov      w2, wzr
006876930  bl       #0x3a7e710 ; 
006876934  b        #0x6876944 ; 
006876938  ldrsw    x9, [x10]
00687693C  add      x8, x8, x9, lsl #4
006876940  add      x0, x8, #0x138
006876944  ldp      x8, x1, [x0]
006876948  mov      x0, x21
00687694C  blr      x8
006876950  tbz      w0, #0, #0x68769c4
006876954  ldr      x8, [x21]
006876958  ldr      x1, [x23]
00687695C  ldrh     w9, [x8, #0x12e]
006876960  cbz      x9, #0x6876984
006876964  ldr      x10, [x8, #0xb0]
006876968  add      x10, x10, #8
00687696C  ldur     x11, [x10, #-8]
006876970  cmp      x11, x1
006876974  b.eq     #0x6876994
006876978  subs     x9, x9, #1
00687697C  add      x10, x10, #0x10
006876980  b.ne     #0x687696c
006876984  mov      x0, x21
006876988  mov      w2, wzr
00687698C  bl       #0x3a7e710 ; 
006876990  b        #0x68769a0 ; 
006876994  ldrsw    x9, [x10]
006876998  add      x8, x8, x9, lsl #4
00687699C  add      x0, x8, #0x138
0068769A0  ldp      x8, x1, [x0]
0068769A4  mov      x0, x21
0068769A8  blr      x8
0068769AC  ldr      x1, [x19, #0x18]
0068769B0  mov      x2, x0
0068769B4  mov      x0, x19
0068769B8  mov      x3, x20
0068769BC  bl       #0x6872370 ; HotFix.BattleLogic.HeroSkillCreator$$AddSkillGroupToNormalRandom
0068769C0  b        #0x68768f8 ; 
0068769C4  mov      x20, xzr
0068769C8  mov      w22, #0x15
0068769CC  cbz      x21, #0x6876a30
0068769D0  adrp     x10, #0x8ebf000
0068769D4  ldr      x8, [x21]
0068769D8  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
0068769DC  ldrh     w9, [x8, #0x12e]
0068769E0  ldr      x1, [x10]
0068769E4  cbz      x9, #0x6876a08
0068769E8  ldr      x10, [x8, #0xb0]
0068769EC  add      x10, x10, #8
0068769F0  ldur     x11, [x10, #-8]
0068769F4  cmp      x11, x1
0068769F8  b.eq     #0x6876a18
0068769FC  subs     x9, x9, #1
006876A00  add      x10, x10, #0x10
006876A04  b.ne     #0x68769f0
006876A08  mov      x0, x21
006876A0C  mov      w2, wzr
006876A10  bl       #0x3a7e710 ; 
006876A14  b        #0x6876a24 ; 
006876A18  ldrsw    x9, [x10]
006876A1C  add      x8, x8, x9, lsl #4
006876A20  add      x0, x8, #0x138
006876A24  ldp      x8, x1, [x0]
006876A28  mov      x0, x21
006876A2C  blr      x8
006876A30  cbnz     x20, #0x6876a84
006876A34  cmp      w22, #0x15
006876A38  b.eq     #0x6876a40
006876A3C  cbnz     w22, #0x6876a48
006876A40  ldr      x8, [x19, #0x18]
006876A44  cbz      x8, #0x6876a64
006876A48  ldp      x20, x19, [sp, #0x50]
006876A4C  ldp      x22, x21, [sp, #0x40]
006876A50  ldp      x24, x23, [sp, #0x30]
006876A54  ldp      x26, x25, [sp, #0x20]
006876A58  ldp      x28, x27, [sp, #0x10]
006876A5C  ldp      x29, x30, [sp], #0x60
006876A60  ret      
006876A64  bl       #0x382bfb8 ; 
006876A68  bl       #0x382bfb8 ; 
006876A6C  bl       #0x382bfb8 ; 
006876A70  bl       #0x382bfb8 ; 
006876A74  mov      x0, x24
006876A78  bl       #0x382bfb0 ; 
006876A7C  bl       #0x382bfb8 ; 
006876A80  bl       #0x382bfb8 ; 
006876A84  mov      x0, x20
006876A88  bl       #0x382bfb0 ; 
006876A8C  bl       #0x382bfb8 ; 
006876A90  bl       #0x382bfb8 ; 
006876A94  bl       #0x382bfb8 ; 
006876A98  mov      x0, x26
006876A9C  bl       #0x382bfb0 ; 
006876AA0  b        #0x6876ae0 ; 
006876AA4  b        #0x6876b88 ; 
006876AA8  b        #0x6876c30 ; 
006876AAC  b        #0x6876ce4 ; 
006876AB0  b        #0x6876d88 ; 
006876AB4  b        #0x6876ae0 ; 
006876AB8  b        #0x6876ae0 ; 
006876ABC  b        #0x6876ae0 ; 
006876AC0  b        #0x6876ae0 ; 
006876AC4  b        #0x6876ae0 ; 
006876AC8  b        #0x6876ae0 ; 
006876ACC  b        #0x6876ae0 ; 
006876AD0  b        #0x6876ae0 ; 
006876AD4  b        #0x6876ae0 ; 
006876AD8  b        #0x6876b88 ; 
006876ADC  b        #0x6876ae0 ; 
006876AE0  mov      x23, x0
006876AE4  cmp      w1, #1
006876AE8  b.ne     #0x6876b04
006876AEC  mov      x0, x23
006876AF0  bl       #0x89eda50 ; 
006876AF4  ldr      x26, [x0]
006876AF8  bl       #0x89eda60 ; 
006876AFC  mov      w21, #1
006876B00  b        #0x6876588 ; 
006876B04  mov      x26, xzr
006876B08  b        #0x6876b10 ; 
006876B0C  mov      x23, x0
006876B10  cbz      x22, #0x6876b74
006876B14  adrp     x10, #0x8ebf000
006876B18  ldr      x8, [x22]
006876B1C  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
006876B20  ldrh     w9, [x8, #0x12e]
006876B24  ldr      x1, [x10]
006876B28  cbz      x9, #0x6876b4c
006876B2C  ldr      x10, [x8, #0xb0]
006876B30  add      x10, x10, #8
006876B34  ldur     x11, [x10, #-8]
006876B38  cmp      x11, x1
006876B3C  b.eq     #0x6876b5c
006876B40  subs     x9, x9, #1
006876B44  add      x10, x10, #0x10
006876B48  b.ne     #0x6876b34
006876B4C  mov      x0, x22
006876B50  mov      w2, wzr
006876B54  bl       #0x3a7e710 ; 
006876B58  b        #0x6876b68 ; 
006876B5C  ldrsw    x9, [x10]
006876B60  add      x8, x8, x9, lsl #4
006876B64  add      x0, x8, #0x138
006876B68  ldp      x8, x1, [x0]
006876B6C  mov      x0, x22
006876B70  blr      x8
006876B74  cbz      x26, #0x6876e1c
006876B78  mov      x0, x26
006876B7C  bl       #0x382bfb0 ; 
006876B80  b        #0x6876c30 ; 
006876B84  b        #0x6876b88 ; 
006876B88  mov      x23, x0
006876B8C  cmp      w1, #1
006876B90  b.ne     #0x6876bb0
006876B94  mov      x0, x23
006876B98  bl       #0x89eda50 ; 
006876B9C  ldr      x24, [x0]
006876BA0  bl       #0x89eda60 ; 
006876BA4  mov      w21, wzr
006876BA8  cbnz     x22, #0x6876234
006876BAC  b        #0x6876294 ; 
006876BB0  mov      x24, xzr
006876BB4  b        #0x6876bbc ; 
006876BB8  mov      x23, x0
006876BBC  cbz      x22, #0x6876c20
006876BC0  adrp     x10, #0x8ebf000
006876BC4  ldr      x8, [x22]
006876BC8  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
006876BCC  ldrh     w9, [x8, #0x12e]
006876BD0  ldr      x1, [x10]
006876BD4  cbz      x9, #0x6876bf8
006876BD8  ldr      x10, [x8, #0xb0]
006876BDC  add      x10, x10, #8
006876BE0  ldur     x11, [x10, #-8]
006876BE4  cmp      x11, x1
006876BE8  b.eq     #0x6876c08
006876BEC  subs     x9, x9, #1
006876BF0  add      x10, x10, #0x10
006876BF4  b.ne     #0x6876be0
006876BF8  mov      x0, x22
006876BFC  mov      w2, wzr
006876C00  bl       #0x3a7e710 ; 
006876C04  b        #0x6876c14 ; 
006876C08  ldrsw    x9, [x10]
006876C0C  add      x8, x8, x9, lsl #4
006876C10  add      x0, x8, #0x138
006876C14  ldp      x8, x1, [x0]
006876C18  mov      x0, x22
006876C1C  blr      x8
006876C20  cbz      x24, #0x6876e1c
006876C24  mov      x0, x24
006876C28  bl       #0x382bfb0 ; 
006876C2C  b        #0x6876c30 ; 
006876C30  mov      x23, x0
006876C34  cmp      w1, #1
006876C38  b.ne     #0x6876c58
006876C3C  mov      x0, x23
006876C40  bl       #0x89eda50 ; 
006876C44  ldr      x24, [x0]
006876C48  bl       #0x89eda60 ; 
006876C4C  mov      w21, wzr
006876C50  cbnz     x22, #0x687600c
006876C54  b        #0x687606c ; 
006876C58  mov      x24, xzr
006876C5C  b        #0x6876c64 ; 
006876C60  mov      x23, x0
006876C64  cbz      x22, #0x6876cc8
006876C68  adrp     x10, #0x8ebf000
006876C6C  ldr      x8, [x22]
006876C70  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
006876C74  ldrh     w9, [x8, #0x12e]
006876C78  ldr      x1, [x10]
006876C7C  cbz      x9, #0x6876ca0
006876C80  ldr      x10, [x8, #0xb0]
006876C84  add      x10, x10, #8
006876C88  ldur     x11, [x10, #-8]
006876C8C  cmp      x11, x1
006876C90  b.eq     #0x6876cb0
006876C94  subs     x9, x9, #1
006876C98  add      x10, x10, #0x10
006876C9C  b.ne     #0x6876c88
006876CA0  mov      x0, x22
006876CA4  mov      w2, wzr
006876CA8  bl       #0x3a7e710 ; 
006876CAC  b        #0x6876cbc ; 
006876CB0  ldrsw    x9, [x10]
006876CB4  add      x8, x8, x9, lsl #4
006876CB8  add      x0, x8, #0x138
006876CBC  ldp      x8, x1, [x0]
006876CC0  mov      x0, x22
006876CC4  blr      x8
006876CC8  cbz      x24, #0x6876e1c
006876CCC  mov      x0, x24
006876CD0  bl       #0x382bfb0 ; 
006876CD4  b        #0x6876ce4 ; 
006876CD8  b        #0x6876d88 ; 
006876CDC  b        #0x6876ce4 ; 
006876CE0  b        #0x6876d88 ; 
006876CE4  mov      x23, x0
006876CE8  cmp      w1, #1
006876CEC  b.ne     #0x6876d0c
006876CF0  mov      x0, x23
006876CF4  bl       #0x89eda50 ; 
006876CF8  ldr      x20, [x0]
006876CFC  bl       #0x89eda60 ; 
006876D00  mov      w22, wzr
006876D04  cbnz     x21, #0x68769d0
006876D08  b        #0x6876a30 ; 
006876D0C  mov      x20, xzr
006876D10  b        #0x6876d18 ; 
006876D14  mov      x23, x0
006876D18  cbz      x21, #0x6876d7c
006876D1C  adrp     x10, #0x8ebf000
006876D20  ldr      x8, [x21]
006876D24  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
006876D28  ldrh     w9, [x8, #0x12e]
006876D2C  ldr      x1, [x10]
006876D30  cbz      x9, #0x6876d54
006876D34  ldr      x10, [x8, #0xb0]
006876D38  add      x10, x10, #8
006876D3C  ldur     x11, [x10, #-8]
006876D40  cmp      x11, x1
006876D44  b.eq     #0x6876d64
006876D48  subs     x9, x9, #1
006876D4C  add      x10, x10, #0x10
006876D50  b.ne     #0x6876d3c
006876D54  mov      x0, x21
006876D58  mov      w2, wzr
006876D5C  bl       #0x3a7e710 ; 
006876D60  b        #0x6876d70 ; 
006876D64  ldrsw    x9, [x10]
006876D68  add      x8, x8, x9, lsl #4
006876D6C  add      x0, x8, #0x138
006876D70  ldp      x8, x1, [x0]
006876D74  mov      x0, x21
006876D78  blr      x8
006876D7C  cbz      x20, #0x6876e1c
006876D80  mov      x0, x20
006876D84  bl       #0x382bfb0 ; 
006876D88  mov      x23, x0
006876D8C  cmp      w1, #1
006876D90  b.ne     #0x6876da8
006876D94  mov      x0, x23
006876D98  bl       #0x89eda50 ; 
006876D9C  ldr      x24, [x0]
006876DA0  bl       #0x89eda60 ; 
006876DA4  b        #0x68767a8 ; 
006876DA8  mov      x24, xzr
006876DAC  b        #0x6876db4 ; 
006876DB0  mov      x23, x0
006876DB4  cbz      x22, #0x6876e18
006876DB8  adrp     x10, #0x8ebf000
006876DBC  ldr      x8, [x22]
006876DC0  ldr      x10, [x10, #0x4e8] ; GLOBAL System.IDisposable_TypeInfo @ 0x91e9490
006876DC4  ldrh     w9, [x8, #0x12e]
006876DC8  ldr      x1, [x10]
006876DCC  cbz      x9, #0x6876df0
006876DD0  ldr      x10, [x8, #0xb0]
006876DD4  add      x10, x10, #8
006876DD8  ldur     x11, [x10, #-8]
006876DDC  cmp      x11, x1
006876DE0  b.eq     #0x6876e00
006876DE4  subs     x9, x9, #1
006876DE8  add      x10, x10, #0x10
006876DEC  b.ne     #0x6876dd8
006876DF0  mov      x0, x22
006876DF4  mov      w2, wzr
006876DF8  bl       #0x3a7e710 ; 
006876DFC  b        #0x6876e0c ; 
006876E00  ldrsw    x9, [x10]
006876E04  add      x8, x8, x9, lsl #4
006876E08  add      x0, x8, #0x138
006876E0C  ldp      x8, x1, [x0]
006876E10  mov      x0, x22
006876E14  blr      x8
006876E18  cbnz     x24, #0x6876e24
006876E1C  mov      x0, x23
006876E20  bl       #0x3b56bfc ; 
006876E24  mov      x0, x24
006876E28  bl       #0x382bfb0 ; 
006876E2C  bl       #0x3442448 ; 

