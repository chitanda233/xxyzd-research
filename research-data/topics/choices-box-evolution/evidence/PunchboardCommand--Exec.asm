; HotFix.BattleLogic.PunchboardCommand$$Exec
; RVA 0x6658CB8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006658CB8  str      x30, [sp, #-0x40]!
006658CBC  stp      x24, x23, [sp, #0x10]
006658CC0  stp      x22, x21, [sp, #0x20]
006658CC4  stp      x20, x19, [sp, #0x30]
006658CC8  adrp     x20, #0x9599000
006658CCC  adrp     x21, #0x8f0e000
006658CD0  ldrb     w8, [x20, #0xcb1]
006658CD4  ldr      x21, [x21, #0xa58] ; GLOBAL Method$HotFix.BattleLogic.PunchboardCommand.Exec() @ 0x929b8f8
006658CD8  mov      x19, x0
006658CDC  tbnz     w8, #0, #0x6658d00
006658CE0  adrp     x0, #0x8ee6000
006658CE4  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006658CE8  bl       #0x382bd14 ; 
006658CEC  adrp     x0, #0x8f0e000
006658CF0  ldr      x0, [x0, #0xa58] ; GLOBAL Method$HotFix.BattleLogic.PunchboardCommand.Exec() @ 0x929b8f8
006658CF4  bl       #0x382bd14 ; 
006658CF8  mov      w8, #1
006658CFC  strb     w8, [x20, #0xcb1]
006658D00  ldr      x1, [x21]
006658D04  ldrb     w8, [x1, #0x53]
006658D08  tbnz     w8, #5, #0x6658d48
006658D0C  adrp     x22, #0x9599000
006658D10  ldrb     w8, [x22, #0xeb0]
006658D14  cbnz     w8, #0x6658d2c
006658D18  adrp     x0, #0x8f0d000
006658D1C  ldr      x0, [x0, #0xc48] ; GLOBAL Method$HotFix.BattleLogic.FrameCommand.get_WorldContext() @ 0x926ed38
006658D20  bl       #0x382bd14 ; 
006658D24  mov      w8, #1
006658D28  strb     w8, [x22, #0xeb0]
006658D2C  adrp     x23, #0x8f0d000
006658D30  ldr      x23, [x23, #0xc48] ; GLOBAL Method$HotFix.BattleLogic.FrameCommand.get_WorldContext() @ 0x926ed38
006658D34  ldr      x1, [x23]
006658D38  ldrb     w8, [x1, #0x53]
006658D3C  tbnz     w8, #5, #0x6658d64
006658D40  ldr      x0, [x19, #0x10]
006658D44  b        #0x6658d70 ; 
006658D48  ldr      x2, [x1, #0x60]
006658D4C  mov      x0, x19
006658D50  ldp      x20, x19, [sp, #0x30]
006658D54  ldp      x22, x21, [sp, #0x20]
006658D58  ldp      x24, x23, [sp, #0x10]
006658D5C  ldr      x30, [sp], #0x40
006658D60  br       x2
006658D64  ldr      x8, [x1, #0x60]
006658D68  mov      x0, x19
006658D6C  blr      x8
006658D70  cbz      x0, #0x6658f84
006658D74  ldrb     w1, [x19, #0x20]
006658D78  mov      x2, xzr
006658D7C  bl       #0x69ff9f4 ; HotFix.BattleLogic.BattleWorldContext$$GetPlayer
006658D80  ldrb     w8, [x22, #0xeb0]
006658D84  mov      x20, x0
006658D88  cbnz     w8, #0x6658da0
006658D8C  adrp     x0, #0x8f0d000
006658D90  ldr      x0, [x0, #0xc48] ; GLOBAL Method$HotFix.BattleLogic.FrameCommand.get_WorldContext() @ 0x926ed38
006658D94  bl       #0x382bd14 ; 
006658D98  mov      w8, #1
006658D9C  strb     w8, [x22, #0xeb0]
006658DA0  ldr      x1, [x23]
006658DA4  ldrb     w8, [x1, #0x53]
006658DA8  tbnz     w8, #5, #0x6658db4
006658DAC  ldr      x0, [x19, #0x10]
006658DB0  b        #0x6658dc0 ; 
006658DB4  ldr      x8, [x1, #0x60]
006658DB8  mov      x0, x19
006658DBC  blr      x8
006658DC0  cbz      x0, #0x6658f84
006658DC4  mov      x1, xzr
006658DC8  bl       #0x6a005a4 ; HotFix.BattleLogic.BattleWorldContext$$IsMultiPlayerBattle
006658DCC  tbz      w0, #0, #0x6658e58
006658DD0  cbz      x20, #0x6658f84
006658DD4  adrp     x8, #0x8ee6000
006658DD8  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006658DDC  ldr      x1, [x8]
006658DE0  ldrb     w8, [x1, #0x53]
006658DE4  tbnz     w8, #5, #0x6658df0
006658DE8  ldr      x21, [x20, #0x38]
006658DEC  b        #0x6658e00 ; 
006658DF0  ldr      x8, [x1, #0x60]
006658DF4  mov      x0, x20
006658DF8  blr      x8
006658DFC  mov      x21, x0
006658E00  cbz      x21, #0x6658f84
006658E04  adrp     x24, #0x9591000
006658E08  ldrb     w8, [x24, #0xa8f]
006658E0C  cbnz     w8, #0x6658e24
006658E10  adrp     x0, #0x8ee6000
006658E14  ldr      x0, [x0, #0x3d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.CheckEntityFlag() @ 0x92631a0
006658E18  bl       #0x382bd14 ; 
006658E1C  mov      w8, #1
006658E20  strb     w8, [x24, #0xa8f]
006658E24  adrp     x8, #0x8ee6000
006658E28  ldr      x8, [x8, #0x3d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.CheckEntityFlag() @ 0x92631a0
006658E2C  ldr      x2, [x8]
006658E30  ldrb     w8, [x2, #0x53]
006658E34  tbnz     w8, #5, #0x6658e44
006658E38  ldrb     w8, [x21, #0x224]
006658E3C  tbnz     w8, #0, #0x6658e58
006658E40  b        #0x6658f70 ; 
006658E44  ldr      x8, [x2, #0x60]
006658E48  mov      w1, #0x20
006658E4C  mov      x0, x21
006658E50  blr      x8
006658E54  tbz      w0, #0, #0x6658f70
006658E58  ldrb     w8, [x22, #0xeb0]
006658E5C  cbnz     w8, #0x6658e74
006658E60  adrp     x0, #0x8f0d000
006658E64  ldr      x0, [x0, #0xc48] ; GLOBAL Method$HotFix.BattleLogic.FrameCommand.get_WorldContext() @ 0x926ed38
006658E68  bl       #0x382bd14 ; 
006658E6C  mov      w8, #1
006658E70  strb     w8, [x22, #0xeb0]
006658E74  ldr      x1, [x23]
006658E78  ldrb     w8, [x1, #0x53]
006658E7C  tbnz     w8, #5, #0x6658e88
006658E80  ldr      x0, [x19, #0x10]
006658E84  b        #0x6658e94 ; 
006658E88  ldr      x8, [x1, #0x60]
006658E8C  mov      x0, x19
006658E90  blr      x8
006658E94  cbz      x0, #0x6658f84
006658E98  ldr      x2, [x19, #0x28]
006658E9C  mov      x1, x20
006658EA0  mov      x3, xzr
006658EA4  bl       #0x6a1f3e0 ; HotFix.BattleLogic.BattleWorldContext$$ApplyPunchboardSkillsToPlayer
006658EA8  ldrb     w8, [x22, #0xeb0]
006658EAC  cbnz     w8, #0x6658ec4
006658EB0  adrp     x0, #0x8f0d000
006658EB4  ldr      x0, [x0, #0xc48] ; GLOBAL Method$HotFix.BattleLogic.FrameCommand.get_WorldContext() @ 0x926ed38
006658EB8  bl       #0x382bd14 ; 
006658EBC  mov      w8, #1
006658EC0  strb     w8, [x22, #0xeb0]
006658EC4  ldr      x1, [x23]
006658EC8  ldrb     w8, [x1, #0x53]
006658ECC  tbnz     w8, #5, #0x6658ed8
006658ED0  ldr      x21, [x19, #0x10]
006658ED4  b        #0x6658ee8 ; 
006658ED8  ldr      x8, [x1, #0x60]
006658EDC  mov      x0, x19
006658EE0  blr      x8
006658EE4  mov      x21, x0
006658EE8  cbz      x21, #0x6658f84
006658EEC  adrp     x22, #0x9598000
006658EF0  ldrb     w8, [x22, #0xfc4]
006658EF4  cbnz     w8, #0x6658f0c
006658EF8  adrp     x0, #0x8f05000
006658EFC  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006658F00  bl       #0x382bd14 ; 
006658F04  mov      w8, #1
006658F08  strb     w8, [x22, #0xfc4]
006658F0C  adrp     x8, #0x8f05000
006658F10  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
006658F14  ldr      x1, [x8]
006658F18  ldrb     w8, [x1, #0x53]
006658F1C  tbnz     w8, #5, #0x6658f28
006658F20  ldr      x0, [x21, #0x220]
006658F24  b        #0x6658f34 ; 
006658F28  ldr      x8, [x1, #0x60]
006658F2C  mov      x0, x21
006658F30  blr      x8
006658F34  cbz      x0, #0x6658f84
006658F38  ldr      x8, [x0]
006658F3C  ldrb     w1, [x19, #0x20]
006658F40  ldr      x9, [x8, #0x4d8]
006658F44  ldr      x2, [x8, #0x4e0]
006658F48  blr      x9
006658F4C  cbz      x20, #0x6658f84
006658F50  ldr      x0, [x20, #0x158]
006658F54  cbz      x0, #0x6658f70
006658F58  ldp      x20, x19, [sp, #0x30]
006658F5C  ldp      x22, x21, [sp, #0x20]
006658F60  ldp      x24, x23, [sp, #0x10]
006658F64  mov      x1, xzr
006658F68  ldr      x30, [sp], #0x40
006658F6C  b        #0x66c5dbc ; HotFix.BattleLogic.CharacterComponentOnHit$$NotifyFollowersOnHeroSkillSelected
006658F70  ldp      x20, x19, [sp, #0x30]
006658F74  ldp      x22, x21, [sp, #0x20]
006658F78  ldp      x24, x23, [sp, #0x10]
006658F7C  ldr      x30, [sp], #0x40
006658F80  ret      
006658F84  bl       #0x382bfb8 ; 

