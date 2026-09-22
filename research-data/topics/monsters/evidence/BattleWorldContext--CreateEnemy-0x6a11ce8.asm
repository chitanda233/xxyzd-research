; HotFix.BattleLogic.BattleWorldContext$$CreateEnemy
; RVA 0x6A11CE8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A11CE8  stp      x29, x30, [sp, #-0x60]!
006A11CEC  stp      x28, x27, [sp, #0x10]
006A11CF0  stp      x26, x25, [sp, #0x20]
006A11CF4  stp      x24, x23, [sp, #0x30]
006A11CF8  stp      x22, x21, [sp, #0x40]
006A11CFC  stp      x20, x19, [sp, #0x50]
006A11D00  sub      sp, sp, #0x1c0
006A11D04  mrs      x21, tpidr_el0
006A11D08  ldr      x8, [x21, #0x28]
006A11D0C  adrp     x19, #0x959d000
006A11D10  adrp     x20, #0x8f32000
006A11D14  mov      w23, w4
006A11D18  str      x8, [sp, #0x1b8]
006A11D1C  ldrb     w8, [x19, #0x5da]
006A11D20  ldr      x20, [x20, #0xef0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEnemy()
006A11D24  mov      x25, x3
006A11D28  mov      x26, x2
006A11D2C  mov      x29, x1
006A11D30  mov      x28, x0
006A11D34  tbnz     w8, #0, #0x6a11e90
006A11D38  adrp     x0, #0x8f32000
006A11D3C  ldr      x0, [x0, #0xeb8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateCharacter<EntityMonster>()
006A11D40  bl       #0x382bd14 ; 
006A11D44  adrp     x0, #0x8f32000
006A11D48  ldr      x0, [x0, #0xef0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEnemy()
006A11D4C  bl       #0x382bd14 ; 
006A11D50  adrp     x0, #0x8f32000
006A11D54  ldr      x0, [x0, #0xec0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<CreateMonsterEvent>()
006A11D58  bl       #0x382bd14 ; 
006A11D5C  adrp     x0, #0x8f32000
006A11D60  ldr      x0, [x0, #0xef8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<NewMonsterAppearEvent>()
006A11D64  bl       #0x382bd14 ; 
006A11D68  adrp     x0, #0x8ee8000
006A11D6C  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo
006A11D70  bl       #0x382bd14 ; 
006A11D74  adrp     x0, #0x8f07000
006A11D78  ldr      x0, [x0, #0xfd0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.PushComponent()
006A11D7C  bl       #0x382bd14 ; 
006A11D80  adrp     x0, #0x8ee6000
006A11D84  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
006A11D88  bl       #0x382bd14 ; 
006A11D8C  adrp     x0, #0x8f18000
006A11D90  ldr      x0, [x0, #0xe60] ; GLOBAL Method$System.Collections.Generic.List.Enumerator<AttributeOneElement>.Dispose()
006A11D94  bl       #0x382bd14 ; 
006A11D98  adrp     x0, #0x8f18000
006A11D9C  ldr      x0, [x0, #0xe68] ; GLOBAL Method$System.Collections.Generic.List.Enumerator<AttributeOneElement>.MoveNext()
006A11DA0  bl       #0x382bd14 ; 
006A11DA4  adrp     x0, #0x8f18000
006A11DA8  ldr      x0, [x0, #0xe70] ; GLOBAL Method$System.Collections.Generic.List.Enumerator<AttributeOneElement>.get_Current()
006A11DAC  bl       #0x382bd14 ; 
006A11DB0  adrp     x0, #0x8f32000
006A11DB4  ldr      x0, [x0, #0xec8] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<CreateMonsterEvent>()
006A11DB8  bl       #0x382bd14 ; 
006A11DBC  adrp     x0, #0x8f32000
006A11DC0  ldr      x0, [x0, #0xf00] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<NewMonsterAppearEvent>()
006A11DC4  bl       #0x382bd14 ; 
006A11DC8  adrp     x0, #0x8f09000
006A11DCC  ldr      x0, [x0, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
006A11DD0  bl       #0x382bd14 ; 
006A11DD4  adrp     x0, #0x8ebf000
006A11DD8  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo
006A11DDC  bl       #0x382bd14 ; 
006A11DE0  adrp     x0, #0x8f08000
006A11DE4  ldr      x0, [x0, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains()
006A11DE8  bl       #0x382bd14 ; 
006A11DEC  adrp     x0, #0x8f18000
006A11DF0  ldr      x0, [x0, #0xe78] ; GLOBAL Method$System.Collections.Generic.List<AttributeOneElement>.GetEnumerator()
006A11DF4  bl       #0x382bd14 ; 
006A11DF8  adrp     x0, #0x8ee1000
006A11DFC  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo
006A11E00  bl       #0x382bd14 ; 
006A11E04  adrp     x0, #0x8f08000
006A11E08  ldr      x0, [x0, #0x828] ; GLOBAL AddExpMission
006A11E0C  bl       #0x382bd14 ; 
006A11E10  adrp     x0, #0x8f22000
006A11E14  ldr      x0, [x0, #0x308] ; GLOBAL DizzyInterval
006A11E18  bl       #0x382bd14 ; 
006A11E1C  adrp     x0, #0x8f32000
006A11E20  ldr      x0, [x0, #0xf08] ; GLOBAL HPMax
006A11E24  bl       #0x382bd14 ; 
006A11E28  adrp     x0, #0x8f07000
006A11E2C  ldr      x0, [x0, #0x1b0] ; GLOBAL Attack
006A11E30  bl       #0x382bd14 ; 
006A11E34  adrp     x0, #0x8f32000
006A11E38  ldr      x0, [x0, #0xed0] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\World\BattleWorldContextUtil.cs
006A11E3C  bl       #0x382bd14 ; 
006A11E40  adrp     x0, #0x8f32000
006A11E44  ldr      x0, [x0, #0xf10] ; GLOBAL CreateEnemy
006A11E48  bl       #0x382bd14 ; 
006A11E4C  adrp     x0, #0x8f32000
006A11E50  ldr      x0, [x0, #0x188] ; GLOBAL BodyAttack
006A11E54  bl       #0x382bd14 ; 
006A11E58  adrp     x0, #0x8f08000
006A11E5C  ldr      x0, [x0, #0x830] ; GLOBAL HPPickUpAddMission
006A11E60  bl       #0x382bd14 ; 
006A11E64  adrp     x0, #0x8f08000
006A11E68  ldr      x0, [x0, #0x838] ; GLOBAL AttackMission
006A11E6C  bl       #0x382bd14 ; 
006A11E70  adrp     x0, #0x8f32000
006A11E74  ldr      x0, [x0, #0xee0] ; GLOBAL entityTable = null where entityId = {0}
006A11E78  bl       #0x382bd14 ; 
006A11E7C  adrp     x0, #0x8f08000
006A11E80  ldr      x0, [x0, #0x840] ; GLOBAL HPMaxMission
006A11E84  bl       #0x382bd14 ; 
006A11E88  mov      w8, #1
006A11E8C  strb     w8, [x19, #0x5da]
006A11E90  ldr      x5, [x20]
006A11E94  ldrb     w8, [x5, #0x53]
006A11E98  tbnz     w8, #5, #0x6a11f40
006A11E9C  movi     v0.2d, #0000000000000000
006A11EA0  mov      x0, x28
006A11EA4  str      x21, [sp, #0x20]
006A11EA8  str      xzr, [sp, #0x100]
006A11EAC  stp      xzr, xzr, [sp, #0xc0]
006A11EB0  str      xzr, [sp, #0xd0]
006A11EB4  stp      xzr, xzr, [sp, #0xa0]
006A11EB8  stp      q0, q0, [sp, #0xe0]
006A11EBC  str      xzr, [sp, #0xb0]
006A11EC0  bl       #0x69fd618 ; HotFix.BattleLogic.BattleWorldContext$$CreateQMonsterEntity
006A11EC4  adrp     x19, #0x959d000
006A11EC8  ldrb     w8, [x19, #0x68d]
006A11ECC  ldr      w22, [x29]
006A11ED0  mov      x24, x0
006A11ED4  cbnz     w8, #0x6a11eec
006A11ED8  adrp     x0, #0x8f32000
006A11EDC  ldr      x0, [x0, #0x650] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.GetCharacterEntity()
006A11EE0  bl       #0x382bd14 ; 
006A11EE4  mov      w8, #1
006A11EE8  strb     w8, [x19, #0x68d]
006A11EEC  adrp     x8, #0x8f32000
006A11EF0  ldr      x8, [x8, #0x650] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.GetCharacterEntity()
006A11EF4  adrp     x9, #0x9598000
006A11EF8  ldr      x2, [x8]
006A11EFC  ldrb     w8, [x2, #0x53]
006A11F00  tbnz     w8, #5, #0x6a11f70
006A11F04  ldrb     w8, [x9, #0xfcc]
006A11F08  cbnz     w8, #0x6a11f24
006A11F0C  adrp     x0, #0x8f06000
006A11F10  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
006A11F14  bl       #0x382bd14 ; 
006A11F18  mov      w8, #1
006A11F1C  adrp     x9, #0x9598000
006A11F20  strb     w8, [x9, #0xfcc]
006A11F24  adrp     x8, #0x8f06000
006A11F28  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
006A11F2C  ldr      x1, [x8]
006A11F30  ldrb     w8, [x1, #0x53]
006A11F34  tbnz     w8, #5, #0x6a11f84
006A11F38  ldr      x0, [x28, #0x200]
006A11F3C  b        #0x6a11f90 ; 
006A11F40  ldr      x8, [x5, #0x60]
006A11F44  and      w4, w23, #1
006A11F48  mov      x0, x28
006A11F4C  mov      x1, x29
006A11F50  mov      x2, x26
006A11F54  mov      x3, x25
006A11F58  blr      x8
006A11F5C  ldr      x8, [x21, #0x28]
006A11F60  ldr      x9, [sp, #0x1b8]
006A11F64  cmp      x8, x9
006A11F68  b.eq     #0x6a136e8
006A11F6C  b        #0x6a1371c ; 
006A11F70  ldr      x8, [x2, #0x60]
006A11F74  mov      x0, x28
006A11F78  mov      w1, w22
006A11F7C  blr      x8
006A11F80  b        #0x6a11fa0 ; 
006A11F84  ldr      x8, [x1, #0x60]
006A11F88  mov      x0, x28
006A11F8C  blr      x8
006A11F90  cbz      x0, #0x6a1370c
006A11F94  mov      w1, w22
006A11F98  mov      x2, xzr
006A11F9C  bl       #0x64d8650 ; LocalModels.LocalModelManager$$GetCharacter_entity
006A11FA0  mov      x22, x0
006A11FA4  cbnz     x0, #0x6a12028
006A11FA8  adrp     x9, #0x8ebf000
006A11FAC  ldr      w8, [x29]
006A11FB0  ldr      x9, [x9, #0xba0] ; GLOBAL int_TypeInfo
006A11FB4  add      x1, sp, #0x110
006A11FB8  str      w8, [sp, #0x110]
006A11FBC  ldr      x0, [x9]
006A11FC0  bl       #0x382be94 ; 
006A11FC4  adrp     x8, #0x8f32000
006A11FC8  ldr      x8, [x8, #0xee0] ; GLOBAL entityTable = null where entityId = {0}
006A11FCC  mov      x1, x0
006A11FD0  mov      x2, xzr
006A11FD4  ldr      x8, [x8]
006A11FD8  mov      x0, x8
006A11FDC  bl       #0x79d140c ; System.String$$Format
006A11FE0  adrp     x8, #0x8ee1000
006A11FE4  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
006A11FE8  mov      x27, x0
006A11FEC  ldr      x8, [x8]
006A11FF0  ldr      w9, [x8, #0xe0]
006A11FF4  cbnz     w9, #0x6a12000
006A11FF8  mov      x0, x8
006A11FFC  bl       #0x382be8c ; 
006A12000  adrp     x8, #0x8f32000
006A12004  adrp     x9, #0x8f32000
006A12008  ldr      x8, [x8, #0xf10] ; GLOBAL CreateEnemy
006A1200C  ldr      x9, [x9, #0xed0] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\World\BattleWorldContextUtil.cs
006A12010  mov      w3, #0xb4
006A12014  mov      x0, x27
006A12018  ldr      x1, [x8]
006A1201C  ldr      x2, [x9]
006A12020  mov      x4, xzr
006A12024  bl       #0x7997754 ; Logger$$LogError
006A12028  mov      w2, #2
006A1202C  mov      x0, x28
006A12030  mov      x1, x24
006A12034  mov      x3, x22
006A12038  mov      x4, xzr
006A1203C  mov      x5, xzr
006A12040  bl       #0x69fe730 ; HotFix.BattleLogic.BattleWorldContext$$CreateCharacterData
006A12044  adrp     x19, #0x959b000
006A12048  ldrb     w8, [x19, #0xbc4]
006A1204C  mov      x24, x0
006A12050  cbnz     w8, #0x6a12068
006A12054  adrp     x0, #0x8f24000
006A12058  ldr      x0, [x0, #0xc88] ; GLOBAL Method$HotFix.BattleLogic.EnemyCreateData.get_Position()
006A1205C  bl       #0x382bd14 ; 
006A12060  mov      w8, #1
006A12064  strb     w8, [x19, #0xbc4]
006A12068  adrp     x8, #0x8f24000
006A1206C  ldr      x8, [x8, #0xc88] ; GLOBAL Method$HotFix.BattleLogic.EnemyCreateData.get_Position()
006A12070  ldr      x1, [x8]
006A12074  ldrb     w8, [x1, #0x53]
006A12078  tbnz     w8, #5, #0x6a12090
006A1207C  ldr      x8, [x29, #0x18]
006A12080  ldur     q0, [x29, #8]
006A12084  str      x8, [sp, #0x120]
006A12088  str      q0, [sp, #0x110]
006A1208C  b        #0x6a120a0 ; 
006A12090  ldr      x9, [x1, #0x60]
006A12094  add      x8, sp, #0x110
006A12098  mov      x0, x29
006A1209C  blr      x9
006A120A0  ldr      q0, [sp, #0x110]
006A120A4  ldr      x8, [sp, #0x120]
006A120A8  str      q0, [sp, #0x1a0]
006A120AC  str      x8, [sp, #0x1b0]
006A120B0  cbz      x24, #0x6a1370c
006A120B4  ldr      q0, [sp, #0x1a0]
006A120B8  ldr      x8, [sp, #0x1b0]
006A120BC  add      x1, sp, #0x180
006A120C0  mov      x0, x24
006A120C4  mov      x2, xzr
006A120C8  str      q0, [sp, #0x180]
006A120CC  str      x8, [sp, #0x190]
006A120D0  bl       #0x6b29288 ; HotFix.EntityData$$set_Position
006A120D4  adrp     x19, #0x959b000
006A120D8  ldrb     w8, [x19, #0x794]
006A120DC  ldr      x27, [x29, #0x38]
006A120E0  cbnz     w8, #0x6a120f8
006A120E4  adrp     x0, #0x8f21000
006A120E8  ldr      x0, [x0, #0xfe0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_InitAngle()
006A120EC  bl       #0x382bd14 ; 
006A120F0  mov      w8, #1
006A120F4  strb     w8, [x19, #0x794]
006A120F8  adrp     x8, #0x8f21000
006A120FC  ldr      x8, [x8, #0xfe0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_InitAngle()
006A12100  ldr      x2, [x8]
006A12104  ldrb     w8, [x2, #0x53]
006A12108  tbnz     w8, #5, #0x6a12114
006A1210C  str      x27, [x24, #0x160]
006A12110  b        #0x6a12124 ; 
006A12114  ldr      x8, [x2, #0x60]
006A12118  mov      x0, x24
006A1211C  mov      x1, x27
006A12120  blr      x8
006A12124  adrp     x19, #0x959d000
006A12128  ldur     q0, [x29, #0x48]
006A1212C  ldr      x8, [x29, #0x58]
006A12130  ldrb     w9, [x19, #0x695]
006A12134  str      q0, [sp, #0x160]
006A12138  str      x8, [sp, #0x170]
006A1213C  cbnz     w9, #0x6a12154
006A12140  adrp     x0, #0x8f22000
006A12144  ldr      x0, [x0, #0xf0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_SplitBornPos()
006A12148  bl       #0x382bd14 ; 
006A1214C  mov      w8, #1
006A12150  strb     w8, [x19, #0x695]
006A12154  adrp     x8, #0x8f22000
006A12158  ldr      x8, [x8, #0xf0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_SplitBornPos()
006A1215C  ldr      x2, [x8]
006A12160  ldrb     w8, [x2, #0x53]
006A12164  tbnz     w8, #5, #0x6a1217c
006A12168  ldr      x8, [sp, #0x170]
006A1216C  ldr      q0, [sp, #0x160]
006A12170  str      x8, [x24, #0x240]
006A12174  str      q0, [x24, #0x230]
006A12178  b        #0x6a1219c ; 
006A1217C  ldr      q0, [sp, #0x160]
006A12180  ldr      x8, [sp, #0x170]
006A12184  ldr      x9, [x2, #0x60]
006A12188  add      x1, sp, #0x110
006A1218C  mov      x0, x24
006A12190  str      q0, [sp, #0x110]
006A12194  str      x8, [sp, #0x120]
006A12198  blr      x9
006A1219C  adrp     x20, #0x959b000
006A121A0  ldrb     w8, [x20, #0x792]
006A121A4  ldrb     w19, [x29, #0x40]
006A121A8  cbnz     w8, #0x6a121c0
006A121AC  adrp     x0, #0x8f22000
006A121B0  ldr      x0, [x0, #0xe0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_SplitBorn()
006A121B4  bl       #0x382bd14 ; 
006A121B8  mov      w8, #1
006A121BC  strb     w8, [x20, #0x792]
006A121C0  adrp     x8, #0x8f22000
006A121C4  ldr      x8, [x8, #0xe0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_SplitBorn()
006A121C8  ldr      x2, [x8]
006A121CC  ldrb     w8, [x2, #0x53]
006A121D0  tbnz     w8, #5, #0x6a121dc
006A121D4  strb     w19, [x24, #0x22c]
006A121D8  b        #0x6a121f0 ; 
006A121DC  ldr      x8, [x2, #0x60]
006A121E0  cmp      w19, #0
006A121E4  cset     w1, ne
006A121E8  mov      x0, x24
006A121EC  blr      x8
006A121F0  add      x0, x24, #0x1b0
006A121F4  mov      x1, x26
006A121F8  str      x26, [x24, #0x1b0]
006A121FC  bl       #0x382bcb8 ; 
006A12200  add      x0, x24, #0x1b8
006A12204  mov      x1, x25
006A12208  str      x25, [x24, #0x1b8]
006A1220C  bl       #0x382bcb8 ; 
006A12210  ldr      x8, [x29, #0x30]
006A12214  ldr      q0, [x29, #0x20]
006A12218  add      x1, sp, #0x140
006A1221C  mov      x0, x24
006A12220  mov      x2, xzr
006A12224  str      x8, [sp, #0x150]
006A12228  str      q0, [sp, #0x140]
006A1222C  bl       #0x6821670 ; HotFix.BattleLogic.EntityCharacterData$$SetBirthPos
006A12230  ldrb     w8, [x29, #0x80]
006A12234  mov      x25, x24
006A12238  strb     w8, [x24, #0x251]
006A1223C  ldr      x1, [x29, #0x88]
006A12240  str      x1, [x25, #0x80]!
006A12244  mov      x0, x25
006A12248  bl       #0x382bcb8 ; 
006A1224C  ldrb     w8, [x29, #0x90]
006A12250  adrp     x19, #0x8f22000
006A12254  adrp     x20, #0x959d000
006A12258  strb     w8, [x25, #8]
006A1225C  ldr      x8, [x29, #0x78]
006A12260  ldr      x19, [x19, #0xb8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_OrbitGroupId()
006A12264  cbz      x8, #0x6a122a8
006A12268  ldr      w9, [x8, #0x18]
006A1226C  cmp      w9, #1
006A12270  b.lt     #0x6a122a8
006A12274  ldrb     w9, [x20, #0x697]
006A12278  ldr      w25, [x8, #0x20]
006A1227C  cbnz     w9, #0x6a12294
006A12280  adrp     x0, #0x8f22000
006A12284  ldr      x0, [x0, #0xb8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_OrbitGroupId()
006A12288  bl       #0x382bd14 ; 
006A1228C  mov      w8, #1
006A12290  strb     w8, [x20, #0x697]
006A12294  ldr      x2, [x19]
006A12298  ldrb     w8, [x2, #0x53]
006A1229C  tbnz     w8, #5, #0x6a12390
006A122A0  str      w25, [x24, #0x210]
006A122A4  b        #0x6a123a0 ; 
006A122A8  ldrb     w8, [x20, #0x697]
006A122AC  cbnz     w8, #0x6a122c4
006A122B0  adrp     x0, #0x8f22000
006A122B4  ldr      x0, [x0, #0xb8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_OrbitGroupId()
006A122B8  bl       #0x382bd14 ; 
006A122BC  mov      w8, #1
006A122C0  strb     w8, [x20, #0x697]
006A122C4  ldr      x2, [x19]
006A122C8  ldrb     w8, [x2, #0x53]
006A122CC  tbnz     w8, #5, #0x6a122dc
006A122D0  mov      w8, #-1
006A122D4  str      w8, [x24, #0x210]
006A122D8  b        #0x6a122ec ; 
006A122DC  ldr      x8, [x2, #0x60]
006A122E0  mov      w1, #-1
006A122E4  mov      x0, x24
006A122E8  blr      x8
006A122EC  adrp     x19, #0x959d000
006A122F0  ldrb     w8, [x19, #0x698]
006A122F4  cbnz     w8, #0x6a1230c
006A122F8  adrp     x0, #0x8f22000
006A122FC  ldr      x0, [x0, #0xc0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_OrbitGroupIndex()
006A12300  bl       #0x382bd14 ; 
006A12304  mov      w8, #1
006A12308  strb     w8, [x19, #0x698]
006A1230C  adrp     x8, #0x8f22000
006A12310  ldr      x8, [x8, #0xc0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_OrbitGroupIndex()
006A12314  ldr      x2, [x8]
006A12318  ldrb     w8, [x2, #0x53]
006A1231C  tbnz     w8, #5, #0x6a1232c
006A12320  mov      w8, #-1
006A12324  str      w8, [x24, #0x214]
006A12328  b        #0x6a1233c ; 
006A1232C  ldr      x8, [x2, #0x60]
006A12330  mov      w1, #-1
006A12334  mov      x0, x24
006A12338  blr      x8
006A1233C  adrp     x19, #0x959d000
006A12340  ldrb     w8, [x19, #0x699]
006A12344  cbnz     w8, #0x6a1235c
006A12348  adrp     x0, #0x8f22000
006A1234C  ldr      x0, [x0, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_OrbitTableId()
006A12350  bl       #0x382bd14 ; 
006A12354  mov      w8, #1
006A12358  strb     w8, [x19, #0x699]
006A1235C  adrp     x8, #0x8f22000
006A12360  ldr      x8, [x8, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_OrbitTableId()
006A12364  ldr      x2, [x8]
006A12368  ldrb     w8, [x2, #0x53]
006A1236C  tbnz     w8, #5, #0x6a12380
006A12370  mov      w8, #-1
006A12374  str      w8, [x24, #0x218]
006A12378  tbnz     w23, #0, #0x6a12470
006A1237C  b        #0x6a12480 ; 
006A12380  ldr      x8, [x2, #0x60]
006A12384  mov      w1, #-1
006A12388  mov      x0, x24
006A1238C  b        #0x6a12468 ; 
006A12390  ldr      x8, [x2, #0x60]
006A12394  mov      x0, x24
006A12398  mov      w1, w25
006A1239C  blr      x8
006A123A0  ldr      x8, [x29, #0x78]
006A123A4  cbz      x8, #0x6a1370c
006A123A8  ldr      w9, [x8, #0x18]
006A123AC  cmp      w9, #1
006A123B0  b.ls     #0x6a13710
006A123B4  adrp     x19, #0x959d000
006A123B8  ldrb     w9, [x19, #0x698]
006A123BC  ldr      w25, [x8, #0x24]
006A123C0  cbnz     w9, #0x6a123d8
006A123C4  adrp     x0, #0x8f22000
006A123C8  ldr      x0, [x0, #0xc0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_OrbitGroupIndex()
006A123CC  bl       #0x382bd14 ; 
006A123D0  mov      w8, #1
006A123D4  strb     w8, [x19, #0x698]
006A123D8  adrp     x8, #0x8f22000
006A123DC  ldr      x8, [x8, #0xc0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_OrbitGroupIndex()
006A123E0  ldr      x2, [x8]
006A123E4  ldrb     w8, [x2, #0x53]
006A123E8  tbnz     w8, #5, #0x6a123f4
006A123EC  str      w25, [x24, #0x214]
006A123F0  b        #0x6a12404 ; 
006A123F4  ldr      x8, [x2, #0x60]
006A123F8  mov      x0, x24
006A123FC  mov      w1, w25
006A12400  blr      x8
006A12404  ldr      x8, [x29, #0x78]
006A12408  cbz      x8, #0x6a1370c
006A1240C  ldr      w9, [x8, #0x18]
006A12410  cmp      w9, #2
006A12414  b.ls     #0x6a13710
006A12418  adrp     x19, #0x959d000
006A1241C  ldrb     w9, [x19, #0x699]
006A12420  ldr      w25, [x8, #0x28]
006A12424  cbnz     w9, #0x6a1243c
006A12428  adrp     x0, #0x8f22000
006A1242C  ldr      x0, [x0, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_OrbitTableId()
006A12430  bl       #0x382bd14 ; 
006A12434  mov      w8, #1
006A12438  strb     w8, [x19, #0x699]
006A1243C  adrp     x8, #0x8f22000
006A12440  ldr      x8, [x8, #0xc8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_OrbitTableId()
006A12444  ldr      x2, [x8]
006A12448  ldrb     w8, [x2, #0x53]
006A1244C  tbnz     w8, #5, #0x6a1245c
006A12450  str      w25, [x24, #0x218]
006A12454  tbnz     w23, #0, #0x6a12470
006A12458  b        #0x6a12480 ; 
006A1245C  ldr      x8, [x2, #0x60]
006A12460  mov      x0, x24
006A12464  mov      w1, w25
006A12468  blr      x8
006A1246C  tbz      w23, #0, #0x6a12480
006A12470  mov      w1, #0x19
006A12474  mov      x0, x24
006A12478  mov      x2, xzr
006A1247C  bl       #0x65947d4 ; 
006A12480  adrp     x8, #0x8f32000
006A12484  ldr      x8, [x8, #0xeb8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateCharacter<EntityMonster>()
006A12488  mov      x0, x28
006A1248C  mov      x1, x24
006A12490  ldr      x2, [x8]
006A12494  bl       #0x453ffcc ; HotFix.BattleLogic.BattleWorldContext$$CreateCharacter<object>
006A12498  cbz      x0, #0x6a1370c
006A1249C  ldr      x8, [x29, #0x68]
006A124A0  adrp     x21, #0x9591000
006A124A4  mov      x23, x0
006A124A8  str      x8, [x0, #0x90]
006A124AC  ldr      x8, [x29, #0x70]
006A124B0  str      x8, [x0, #0x98]
006A124B4  ldrb     w8, [x21, #0xa7f]
006A124B8  cbnz     w8, #0x6a124d0
006A124BC  adrp     x0, #0x8ee6000
006A124C0  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
006A124C4  bl       #0x382bd14 ; 
006A124C8  mov      w8, #1
006A124CC  strb     w8, [x21, #0xa7f]
006A124D0  adrp     x8, #0x8ee6000
006A124D4  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
006A124D8  ldr      x1, [x8]
006A124DC  ldrb     w8, [x1, #0x53]
006A124E0  tbnz     w8, #5, #0x6a124ec
006A124E4  ldr      x25, [x24, #0x178]
006A124E8  b        #0x6a124fc ; 
006A124EC  ldr      x8, [x1, #0x60]
006A124F0  mov      x0, x24
006A124F4  blr      x8
006A124F8  mov      x25, x0
006A124FC  ldr      w8, [x29, #0x94]
006A12500  stp      x29, x28, [sp, #0x28]
006A12504  str      x23, [sp, #0x38]
006A12508  cmp      w8, #1
006A1250C  b.lt     #0x6a12550
006A12510  adrp     x8, #0x9598000
006A12514  ldrb     w8, [x8, #0xfcc]
006A12518  cbnz     w8, #0x6a12534
006A1251C  adrp     x0, #0x8f06000
006A12520  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
006A12524  bl       #0x382bd14 ; 
006A12528  mov      w8, #1
006A1252C  adrp     x9, #0x9598000
006A12530  strb     w8, [x9, #0xfcc]
006A12534  adrp     x8, #0x8f06000
006A12538  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
006A1253C  ldr      x1, [x8]
006A12540  ldrb     w8, [x1, #0x53]
006A12544  tbnz     w8, #5, #0x6a127ac
006A12548  ldr      x0, [x28, #0x200]
006A1254C  b        #0x6a127b8 ; 
006A12550  ldr      x0, [x28, #0x300]
006A12554  cbz      x0, #0x6a12a14
006A12558  adrp     x8, #0x8f18000
006A1255C  ldr      x8, [x8, #0xe78] ; GLOBAL Method$System.Collections.Generic.List<AttributeOneElement>.GetEnumerator()
006A12560  mov      x19, x22
006A12564  ldr      x1, [x8]
006A12568  add      x8, sp, #0x110
006A1256C  bl       #0x4c938d4 ; System.Collections.Generic.List<AttributeOneElement>$$GetEnumerator
006A12570  ldp      q0, q1, [sp, #0x110]
006A12574  ldr      x8, [sp, #0x130]
006A12578  adrp     x28, #0x8f18000
006A1257C  adrp     x26, #0x8f0d000
006A12580  adrp     x21, #0x8f08000
006A12584  adrp     x27, #0x8f0d000
006A12588  ldr      x28, [x28, #0xe68] ; GLOBAL Method$System.Collections.Generic.List.Enumerator<AttributeOneElement>.MoveNext()
006A1258C  ldr      x26, [x26, #0x1c8] ; GLOBAL Method$HotFix.Common.AttributeOneElement.get_Header()
006A12590  ldr      x21, [x21, #0x840] ; GLOBAL HPMaxMission
006A12594  ldr      x27, [x27, #0x1c0] ; GLOBAL Method$HotFix.Common.AttributeOneElement.get_Value()
006A12598  add      x9, sp, #0xe0
006A1259C  adrp     x29, #0x9599000
006A125A0  mov      w22, #1
006A125A4  adrp     x20, #0x9599000
006A125A8  add      x23, x9, #0x10
006A125AC  stp      q0, q1, [sp, #0xe0]
006A125B0  str      x8, [sp, #0x100]
006A125B4  ldr      x1, [x28]
006A125B8  add      x0, sp, #0xe0
006A125BC  bl       #0x60d5ec4 ; System.Collections.Generic.List.Enumerator<AttributeOneElement>$$MoveNext
006A125C0  tbz      w0, #0, #0x6a12818
006A125C4  ldr      q0, [x23]
006A125C8  ldr      x8, [x23, #0x10]
006A125CC  ldrb     w9, [x29, #0xad2]
006A125D0  str      q0, [sp, #0xc0]
006A125D4  str      x8, [sp, #0xd0]
006A125D8  cbnz     w9, #0x6a125e8
006A125DC  mov      x0, x26
006A125E0  bl       #0x382bd14 ; 
006A125E4  strb     w22, [x29, #0xad2]
006A125E8  ldr      x1, [x26]
006A125EC  ldrb     w8, [x1, #0x53]
006A125F0  tbnz     w8, #5, #0x6a125fc
006A125F4  ldr      x0, [sp, #0xc0]
006A125F8  b        #0x6a12608 ; 
006A125FC  ldr      x8, [x1, #0x60]
006A12600  add      x0, sp, #0xc0
006A12604  blr      x8
006A12608  ldr      x1, [x21]
006A1260C  mov      x2, xzr
006A12610  bl       #0x79d1644 ; System.String$$op_Equality
006A12614  tbnz     w0, #0, #0x6a126fc
006A12618  ldrb     w8, [x29, #0xad2]
006A1261C  cbnz     w8, #0x6a1262c
006A12620  mov      x0, x26
006A12624  bl       #0x382bd14 ; 
006A12628  strb     w22, [x29, #0xad2]
006A1262C  ldr      x1, [x26]
006A12630  ldrb     w8, [x1, #0x53]
006A12634  tbnz     w8, #5, #0x6a12640
006A12638  ldr      x0, [sp, #0xc0]
006A1263C  b        #0x6a1264c ; 
006A12640  ldr      x8, [x1, #0x60]
006A12644  add      x0, sp, #0xc0
006A12648  blr      x8
006A1264C  adrp     x8, #0x8f08000
006A12650  ldr      x8, [x8, #0x838] ; GLOBAL AttackMission
006A12654  ldr      x1, [x8]
006A12658  mov      x2, xzr
006A1265C  bl       #0x79d1644 ; System.String$$op_Equality
006A12660  tbnz     w0, #0, #0x6a126fc
006A12664  ldrb     w8, [x29, #0xad2]
006A12668  cbnz     w8, #0x6a12678
006A1266C  mov      x0, x26
006A12670  bl       #0x382bd14 ; 
006A12674  strb     w22, [x29, #0xad2]
006A12678  ldr      x1, [x26]
006A1267C  ldrb     w8, [x1, #0x53]
006A12680  tbnz     w8, #5, #0x6a1268c
006A12684  ldr      x0, [sp, #0xc0]
006A12688  b        #0x6a12698 ; 
006A1268C  ldr      x8, [x1, #0x60]
006A12690  add      x0, sp, #0xc0
006A12694  blr      x8
006A12698  adrp     x8, #0x8f08000
006A1269C  ldr      x8, [x8, #0x828] ; GLOBAL AddExpMission
006A126A0  ldr      x1, [x8]
006A126A4  mov      x2, xzr
006A126A8  bl       #0x79d1644 ; System.String$$op_Equality
006A126AC  tbnz     w0, #0, #0x6a126fc
006A126B0  ldrb     w8, [x29, #0xad2]
006A126B4  cbnz     w8, #0x6a126c4
006A126B8  mov      x0, x26
006A126BC  bl       #0x382bd14 ; 
006A126C0  strb     w22, [x29, #0xad2]
006A126C4  ldr      x1, [x26]
006A126C8  ldrb     w8, [x1, #0x53]
006A126CC  tbnz     w8, #5, #0x6a126d8
006A126D0  ldr      x0, [sp, #0xc0]
006A126D4  b        #0x6a126e4 ; 
006A126D8  ldr      x8, [x1, #0x60]
006A126DC  add      x0, sp, #0xc0
006A126E0  blr      x8
006A126E4  adrp     x8, #0x8f08000
006A126E8  ldr      x8, [x8, #0x830] ; GLOBAL HPPickUpAddMission
006A126EC  ldr      x1, [x8]
006A126F0  mov      x2, xzr
006A126F4  bl       #0x79d1644 ; System.String$$op_Equality
006A126F8  tbz      w0, #0, #0x6a12770
006A126FC  ldrb     w8, [x20, #0xad1]
006A12700  cbnz     w8, #0x6a12710
006A12704  mov      x0, x27
006A12708  bl       #0x382bd14 ; 
006A1270C  strb     w22, [x20, #0xad1]
006A12710  ldr      x1, [x27]
006A12714  ldrb     w8, [x1, #0x53]
006A12718  tbnz     w8, #5, #0x6a12724
006A1271C  ldr      x0, [sp, #0xc8]
006A12720  b        #0x6a12730 ; 
006A12724  ldr      x8, [x1, #0x60]
006A12728  add      x0, sp, #0xc0
006A1272C  blr      x8
006A12730  cbz      x0, #0x6a125b4
006A12734  ldr      q0, [sp, #0xc0]
006A12738  ldr      x8, [sp, #0xd0]
006A1273C  str      q0, [sp, #0x110]
006A12740  str      x8, [sp, #0x120]
006A12744  cbz      x25, #0x6a13714
006A12748  ldr      q0, [sp, #0x110]
006A1274C  ldr      x8, [sp, #0x120]
006A12750  str      q0, [sp, #0x80]
006A12754  str      x8, [sp, #0x90]
006A12758  add      x1, sp, #0x80
006A1275C  mov      x0, x25
006A12760  mov      w2, wzr
006A12764  mov      x3, xzr
006A12768  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
006A1276C  b        #0x6a125b4 ; 
006A12770  ldr      q0, [sp, #0xc0]
006A12774  ldr      x8, [sp, #0xd0]
006A12778  str      q0, [sp, #0x110]
006A1277C  str      x8, [sp, #0x120]
006A12780  cbz      x25, #0x6a13718
006A12784  ldr      q0, [sp, #0x110]
006A12788  ldr      x8, [sp, #0x120]
006A1278C  str      q0, [sp, #0x60]
006A12790  str      x8, [sp, #0x70]
006A12794  add      x1, sp, #0x60
006A12798  mov      x0, x25
006A1279C  mov      w2, wzr
006A127A0  mov      x3, xzr
006A127A4  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
006A127A8  b        #0x6a125b4 ; 
006A127AC  ldr      x8, [x1, #0x60]
006A127B0  mov      x0, x28
006A127B4  blr      x8
006A127B8  ldr      w1, [x28, #0x1c8]
006A127BC  ldr      w2, [x29, #0x94]
006A127C0  mov      x3, xzr
006A127C4  bl       #0x6b3971c ; HotFix.TableExtension$$GetMissionData
006A127C8  cbz      x0, #0x6a12a14
006A127CC  adrp     x19, #0x8f09000
006A127D0  ldr      x8, [x0]
006A127D4  ldr      x19, [x19, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
006A127D8  mov      x26, x0
006A127DC  ldrh     w9, [x8, #0x12e]
006A127E0  ldr      x1, [x19]
006A127E4  cbz      x9, #0x6a12808
006A127E8  ldr      x10, [x8, #0xb0]
006A127EC  add      x10, x10, #8
006A127F0  ldur     x11, [x10, #-8]
006A127F4  cmp      x11, x1
006A127F8  b.eq     #0x6a12840
006A127FC  subs     x9, x9, #1
006A12800  add      x10, x10, #0x10
006A12804  b.ne     #0x6a127f0
006A12808  mov      w2, #0x1c
006A1280C  mov      x0, x26
006A12810  bl       #0x3a7e710 ; 
006A12814  b        #0x6a12850 ; 
006A12818  adrp     x8, #0x8f18000
006A1281C  ldr      x8, [x8, #0xe60] ; GLOBAL Method$System.Collections.Generic.List.Enumerator<AttributeOneElement>.Dispose()
006A12820  add      x0, sp, #0xe0
006A12824  ldr      x1, [x8]
006A12828  bl       #0x60d5ec0 ; System.Collections.Generic.List.Enumerator<AttributeOneElement>$$Dispose
006A1282C  ldp      x29, x28, [sp, #0x28]
006A12830  ldr      x23, [sp, #0x38]
006A12834  mov      x22, x19
006A12838  adrp     x21, #0x9591000
006A1283C  b        #0x6a12a14 ; 
006A12840  ldr      w9, [x10]
006A12844  add      w9, w9, #0x1c
006A12848  add      x8, x8, w9, sxtw #4
006A1284C  add      x0, x8, #0x138
006A12850  ldp      x8, x1, [x0]
006A12854  mov      x0, x26
006A12858  blr      x8
006A1285C  ldr      x8, [x26]
006A12860  ldr      x1, [x19]
006A12864  mov      x27, x0
006A12868  ldrh     w9, [x8, #0x12e]
006A1286C  cbz      x9, #0x6a12890
006A12870  ldr      x10, [x8, #0xb0]
006A12874  add      x10, x10, #8
006A12878  ldur     x11, [x10, #-8]
006A1287C  cmp      x11, x1
006A12880  b.eq     #0x6a128a0
006A12884  subs     x9, x9, #1
006A12888  add      x10, x10, #0x10
006A1288C  b.ne     #0x6a12878
006A12890  mov      w2, #0x1e
006A12894  mov      x0, x26
006A12898  bl       #0x3a7e710 ; 
006A1289C  b        #0x6a128b0 ; 
006A128A0  ldr      w9, [x10]
006A128A4  add      w9, w9, #0x1e
006A128A8  add      x8, x8, w9, sxtw #4
006A128AC  add      x0, x8, #0x138
006A128B0  ldp      x8, x1, [x0]
006A128B4  mov      x0, x26
006A128B8  blr      x8
006A128BC  ldr      x8, [x26]
006A128C0  ldr      x1, [x19]
006A128C4  mov      x28, x0
006A128C8  ldrh     w9, [x8, #0x12e]
006A128CC  cbz      x9, #0x6a128f0
006A128D0  ldr      x10, [x8, #0xb0]
006A128D4  add      x10, x10, #8
006A128D8  ldur     x11, [x10, #-8]
006A128DC  cmp      x11, x1
006A128E0  b.eq     #0x6a12900
006A128E4  subs     x9, x9, #1
006A128E8  add      x10, x10, #0x10
006A128EC  b.ne     #0x6a128d8
006A128F0  mov      w2, #0x20
006A128F4  mov      x0, x26
006A128F8  bl       #0x3a7e710 ; 
006A128FC  b        #0x6a12910 ; 
006A12900  ldr      w9, [x10]
006A12904  add      w9, w9, #0x20
006A12908  add      x8, x8, w9, sxtw #4
006A1290C  add      x0, x8, #0x138
006A12910  ldp      x8, x1, [x0]
006A12914  mov      x0, x26
006A12918  blr      x8
006A1291C  ldr      x8, [x26]
006A12920  ldr      x1, [x19]
006A12924  mov      x29, x0
006A12928  ldrh     w9, [x8, #0x12e]
006A1292C  cbz      x9, #0x6a12950
006A12930  ldr      x10, [x8, #0xb0]
006A12934  add      x10, x10, #8
006A12938  ldur     x11, [x10, #-8]
006A1293C  cmp      x11, x1
006A12940  b.eq     #0x6a12960
006A12944  subs     x9, x9, #1
006A12948  add      x10, x10, #0x10
006A1294C  b.ne     #0x6a12938
006A12950  mov      w2, #0x22
006A12954  mov      x0, x26
006A12958  bl       #0x3a7e710 ; 
006A1295C  b        #0x6a12970 ; 
006A12960  ldr      w9, [x10]
006A12964  add      w9, w9, #0x22
006A12968  add      x8, x8, w9, sxtw #4
006A1296C  add      x0, x8, #0x138
006A12970  ldp      x8, x1, [x0]
006A12974  mov      x0, x26
006A12978  blr      x8
006A1297C  mov      x26, x0
006A12980  cbz      x27, #0x6a129a4
006A12984  cbz      x25, #0x6a1370c
006A12988  adrp     x8, #0x8f08000
006A1298C  ldr      x8, [x8, #0x840] ; GLOBAL HPMaxMission
006A12990  mov      x0, x25
006A12994  mov      x2, x27
006A12998  mov      x3, xzr
006A1299C  ldr      x1, [x8]
006A129A0  bl       #0x6b3bf64 ; HotFix.Common.AttributeData$$MultiAttributeValue
006A129A4  cbz      x28, #0x6a129c8
006A129A8  cbz      x25, #0x6a1370c
006A129AC  adrp     x8, #0x8f08000
006A129B0  ldr      x8, [x8, #0x838] ; GLOBAL AttackMission
006A129B4  mov      x0, x25
006A129B8  mov      x2, x28
006A129BC  mov      x3, xzr
006A129C0  ldr      x1, [x8]
006A129C4  bl       #0x6b3bf64 ; HotFix.Common.AttributeData$$MultiAttributeValue
006A129C8  cbz      x29, #0x6a129ec
006A129CC  cbz      x25, #0x6a1370c
006A129D0  adrp     x8, #0x8f08000
006A129D4  ldr      x8, [x8, #0x828] ; GLOBAL AddExpMission
006A129D8  mov      x0, x25
006A129DC  mov      x2, x29
006A129E0  mov      x3, xzr
006A129E4  ldr      x1, [x8]
006A129E8  bl       #0x6b3bf64 ; HotFix.Common.AttributeData$$MultiAttributeValue
006A129EC  ldp      x29, x28, [sp, #0x28]
006A129F0  cbz      x26, #0x6a12a14
006A129F4  cbz      x25, #0x6a1370c
006A129F8  adrp     x8, #0x8f08000
006A129FC  ldr      x8, [x8, #0x830] ; GLOBAL HPPickUpAddMission
006A12A00  mov      x0, x25
006A12A04  mov      x2, x26
006A12A08  mov      x3, xzr
006A12A0C  ldr      x1, [x8]
006A12A10  bl       #0x6b3bf64 ; HotFix.Common.AttributeData$$MultiAttributeValue
006A12A14  ldr      x2, [x28, #0x1a8]
006A12A18  cmp      x2, #0x10, lsl #12
006A12A1C  b.eq     #0x6a12a3c
006A12A20  cbz      x25, #0x6a1370c
006A12A24  adrp     x8, #0x8f08000
006A12A28  ldr      x8, [x8, #0x840] ; GLOBAL HPMaxMission
006A12A2C  mov      x0, x25
006A12A30  mov      x3, xzr
006A12A34  ldr      x1, [x8]
006A12A38  bl       #0x6b3bf64 ; HotFix.Common.AttributeData$$MultiAttributeValue
006A12A3C  ldr      x0, [x28, #0x308]
006A12A40  cbz      x0, #0x6a12c44
006A12A44  stp      x24, x22, [sp, #0x10]
006A12A48  adrp     x8, #0x8f18000
006A12A4C  ldr      x8, [x8, #0xe78] ; GLOBAL Method$System.Collections.Generic.List<AttributeOneElement>.GetEnumerator()
006A12A50  ldr      x1, [x8]
006A12A54  add      x8, sp, #0x110
006A12A58  bl       #0x4c938d4 ; System.Collections.Generic.List<AttributeOneElement>$$GetEnumerator
006A12A5C  adrp     x20, #0x8f18000
006A12A60  adrp     x26, #0x8f0d000
006A12A64  adrp     x23, #0x8f08000
006A12A68  adrp     x28, #0x8f07000
006A12A6C  adrp     x29, #0x8f32000
006A12A70  adrp     x24, #0x8f08000
006A12A74  ldp      q0, q1, [sp, #0x110]
006A12A78  ldr      x8, [sp, #0x130]
006A12A7C  ldr      x20, [x20, #0xe68] ; GLOBAL Method$System.Collections.Generic.List.Enumerator<AttributeOneElement>.MoveNext()
006A12A80  ldr      x26, [x26, #0x1c8] ; GLOBAL Method$HotFix.Common.AttributeOneElement.get_Header()
006A12A84  ldr      x23, [x23, #0x838] ; GLOBAL AttackMission
006A12A88  ldr      x28, [x28, #0x1b0] ; GLOBAL Attack
006A12A8C  ldr      x29, [x29, #0x188] ; GLOBAL BodyAttack
006A12A90  ldr      x24, [x24, #0x840] ; GLOBAL HPMaxMission
006A12A94  add      x9, sp, #0xe0
006A12A98  adrp     x21, #0x9599000
006A12A9C  mov      w22, #1
006A12AA0  add      x19, x9, #0x10
006A12AA4  stp      q0, q1, [sp, #0xe0]
006A12AA8  str      x8, [sp, #0x100]
006A12AAC  ldr      x1, [x20]
006A12AB0  add      x0, sp, #0xe0
006A12AB4  bl       #0x60d5ec4 ; System.Collections.Generic.List.Enumerator<AttributeOneElement>$$MoveNext
006A12AB8  tbz      w0, #0, #0x6a12c20
006A12ABC  ldr      x8, [x19, #0x10]
006A12AC0  ldr      q0, [x19]
006A12AC4  ldr      x9, [x19, #0x10]
006A12AC8  ldr      q1, [x19]
006A12ACC  str      x8, [sp, #0xb0]
006A12AD0  str      q0, [sp, #0xa0]
006A12AD4  str      x9, [sp, #0x120]
006A12AD8  str      q1, [sp, #0x110]
006A12ADC  cbz      x25, #0x6a13708
006A12AE0  ldr      q0, [sp, #0x110]
006A12AE4  ldr      x8, [sp, #0x120]
006A12AE8  str      q0, [sp, #0x40]
006A12AEC  str      x8, [sp, #0x50]
006A12AF0  add      x1, sp, #0x40
006A12AF4  mov      x0, x25
006A12AF8  mov      w2, wzr
006A12AFC  mov      x3, xzr
006A12B00  bl       #0x6b3c714 ; HotFix.Common.AttributeData$$MergeAttribute
006A12B04  ldrb     w8, [x21, #0xad2]
006A12B08  cbnz     w8, #0x6a12b18
006A12B0C  mov      x0, x26
006A12B10  bl       #0x382bd14 ; 
006A12B14  strb     w22, [x21, #0xad2]
006A12B18  ldr      x1, [x26]
006A12B1C  ldrb     w8, [x1, #0x53]
006A12B20  tbnz     w8, #5, #0x6a12b2c
006A12B24  ldr      x1, [sp, #0xa0]
006A12B28  b        #0x6a12b3c ; 
006A12B2C  ldr      x8, [x1, #0x60]
006A12B30  add      x0, sp, #0xa0
006A12B34  blr      x8
006A12B38  mov      x1, x0
006A12B3C  mov      x0, x25
006A12B40  mov      x2, xzr
006A12B44  bl       #0x6b3bc94 ; HotFix.Common.AttributeData$$GetAttributeValue
006A12B48  ldrb     w8, [x21, #0xad2]
006A12B4C  mov      x27, x0
006A12B50  cbnz     w8, #0x6a12b60
006A12B54  mov      x0, x26
006A12B58  bl       #0x382bd14 ; 
006A12B5C  strb     w22, [x21, #0xad2]
006A12B60  ldr      x1, [x26]
006A12B64  ldrb     w8, [x1, #0x53]
006A12B68  tbnz     w8, #5, #0x6a12b74
006A12B6C  ldr      x0, [sp, #0xa0]
006A12B70  b        #0x6a12b80 ; 
006A12B74  ldr      x8, [x1, #0x60]
006A12B78  add      x0, sp, #0xa0
006A12B7C  blr      x8
006A12B80  ldr      x1, [x23]
006A12B84  mov      x2, xzr
006A12B88  bl       #0x79d1644 ; System.String$$op_Equality
006A12B8C  tbz      w0, #0, #0x6a12bbc
006A12B90  ldr      x1, [x28]
006A12B94  mov      x0, x25
006A12B98  mov      x2, x27
006A12B9C  mov      x3, xzr
006A12BA0  bl       #0x6b3bf64 ; HotFix.Common.AttributeData$$MultiAttributeValue
006A12BA4  ldr      x1, [x29]
006A12BA8  mov      x0, x25
006A12BAC  mov      x2, x27
006A12BB0  mov      x3, xzr
006A12BB4  bl       #0x6b3bf64 ; HotFix.Common.AttributeData$$MultiAttributeValue
006A12BB8  b        #0x6a12aac ; 
006A12BBC  ldrb     w8, [x21, #0xad2]
006A12BC0  cbnz     w8, #0x6a12bd0
006A12BC4  mov      x0, x26
006A12BC8  bl       #0x382bd14 ; 
006A12BCC  strb     w22, [x21, #0xad2]
006A12BD0  ldr      x1, [x26]
006A12BD4  ldrb     w8, [x1, #0x53]
006A12BD8  tbnz     w8, #5, #0x6a12be4
006A12BDC  ldr      x0, [sp, #0xa0]
006A12BE0  b        #0x6a12bf0 ; 
006A12BE4  ldr      x8, [x1, #0x60]
006A12BE8  add      x0, sp, #0xa0
006A12BEC  blr      x8
006A12BF0  ldr      x1, [x24]
006A12BF4  mov      x2, xzr
006A12BF8  bl       #0x79d1644 ; System.String$$op_Equality
006A12BFC  tbz      w0, #0, #0x6a12aac
006A12C00  adrp     x8, #0x8f32000
006A12C04  ldr      x8, [x8, #0xf08] ; GLOBAL HPMax
006A12C08  ldr      x1, [x8]
006A12C0C  mov      x0, x25
006A12C10  mov      x2, x27
006A12C14  mov      x3, xzr
006A12C18  bl       #0x6b3bf64 ; HotFix.Common.AttributeData$$MultiAttributeValue
006A12C1C  b        #0x6a12aac ; 
006A12C20  adrp     x8, #0x8f18000
006A12C24  ldr      x8, [x8, #0xe60] ; GLOBAL Method$System.Collections.Generic.List.Enumerator<AttributeOneElement>.Dispose()
006A12C28  add      x0, sp, #0xe0
006A12C2C  ldr      x1, [x8]
006A12C30  bl       #0x60d5ec0 ; System.Collections.Generic.List.Enumerator<AttributeOneElement>$$Dispose
006A12C34  ldp      x29, x28, [sp, #0x28]
006A12C38  ldp      x24, x22, [sp, #0x10]
006A12C3C  ldr      x23, [sp, #0x38]
006A12C40  adrp     x21, #0x9591000
006A12C44  mov      x0, x23
006A12C48  mov      x1, xzr
006A12C4C  bl       #0x6594ab4 ; 
006A12C50  adrp     x19, #0x959b000
006A12C54  ldrb     w8, [x19, #0x39e]
006A12C58  cbnz     w8, #0x6a12c70
006A12C5C  adrp     x0, #0x8f1e000
006A12C60  ldr      x0, [x0, #0xc20] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsBossOrElite()
006A12C64  bl       #0x382bd14 ; 
006A12C68  mov      w8, #1
006A12C6C  strb     w8, [x19, #0x39e]
006A12C70  adrp     x8, #0x8f1e000
006A12C74  ldr      x8, [x8, #0xc20] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsBossOrElite()
006A12C78  ldr      x1, [x8]
006A12C7C  ldrb     w8, [x1, #0x53]
006A12C80  tbnz     w8, #5, #0x6a12cf8
006A12C84  adrp     x19, #0x9591000
006A12C88  ldrb     w8, [x19, #0xa73]
006A12C8C  cbnz     w8, #0x6a12ca4
006A12C90  adrp     x0, #0x8ee6000
006A12C94  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006A12C98  bl       #0x382bd14 ; 
006A12C9C  mov      w8, #1
006A12CA0  strb     w8, [x19, #0xa73]
006A12CA4  adrp     x20, #0x8ee6000
006A12CA8  ldr      x20, [x20, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006A12CAC  ldr      x1, [x20]
006A12CB0  ldrb     w8, [x1, #0x53]
006A12CB4  tbnz     w8, #5, #0x6a12d0c
006A12CB8  mov      x26, x21
006A12CBC  adrp     x21, #0x9591000
006A12CC0  ldrb     w8, [x21, #0xa74]
006A12CC4  cbnz     w8, #0x6a12cdc
006A12CC8  adrp     x0, #0x8ee6000
006A12CCC  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006A12CD0  bl       #0x382bd14 ; 
006A12CD4  mov      w8, #1
006A12CD8  strb     w8, [x21, #0xa74]
006A12CDC  adrp     x8, #0x8ee6000
006A12CE0  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006A12CE4  ldr      x1, [x8]
006A12CE8  ldrb     w8, [x1, #0x53]
006A12CEC  tbnz     w8, #5, #0x6a12d1c
006A12CF0  ldr      x25, [x24, #0x170]
006A12CF4  b        #0x6a12d2c ; 
006A12CF8  ldr      x8, [x1, #0x60]
006A12CFC  mov      x0, x24
006A12D00  blr      x8
006A12D04  tbnz     w0, #0, #0x6a12e58
006A12D08  b        #0x6a12e90 ; 
006A12D0C  ldr      x8, [x1, #0x60]
006A12D10  mov      x0, x24
006A12D14  blr      x8
006A12D18  b        #0x6a12d7c ; 
006A12D1C  ldr      x8, [x1, #0x60]
006A12D20  mov      x0, x24
006A12D24  blr      x8
006A12D28  mov      x25, x0
006A12D2C  cbz      x25, #0x6a1370c
006A12D30  adrp     x21, #0x9591000
006A12D34  ldrb     w8, [x21, #0xa75]
006A12D38  cbnz     w8, #0x6a12d50
006A12D3C  adrp     x0, #0x8ee6000
006A12D40  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006A12D44  bl       #0x382bd14 ; 
006A12D48  mov      w8, #1
006A12D4C  strb     w8, [x21, #0xa75]
006A12D50  adrp     x8, #0x8ee6000
006A12D54  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006A12D58  ldr      x1, [x8]
006A12D5C  ldrb     w8, [x1, #0x53]
006A12D60  tbnz     w8, #5, #0x6a12d6c
006A12D64  ldr      w0, [x25, #0x24]
006A12D68  b        #0x6a12d78 ; 
006A12D6C  ldr      x8, [x1, #0x60]
006A12D70  mov      x0, x25
006A12D74  blr      x8
006A12D78  mov      x21, x26
006A12D7C  cmp      w0, #3
006A12D80  b.eq     #0x6a12e58
006A12D84  ldrb     w8, [x19, #0xa73]
006A12D88  cbnz     w8, #0x6a12da0
006A12D8C  adrp     x0, #0x8ee6000
006A12D90  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006A12D94  bl       #0x382bd14 ; 
006A12D98  mov      w8, #1
006A12D9C  strb     w8, [x19, #0xa73]
006A12DA0  ldr      x1, [x20]
006A12DA4  ldrb     w8, [x1, #0x53]
006A12DA8  tbnz     w8, #5, #0x6a12de8
006A12DAC  adrp     x19, #0x9591000
006A12DB0  ldrb     w8, [x19, #0xa74]
006A12DB4  cbnz     w8, #0x6a12dcc
006A12DB8  adrp     x0, #0x8ee6000
006A12DBC  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006A12DC0  bl       #0x382bd14 ; 
006A12DC4  mov      w8, #1
006A12DC8  strb     w8, [x19, #0xa74]
006A12DCC  adrp     x8, #0x8ee6000
006A12DD0  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006A12DD4  ldr      x1, [x8]
006A12DD8  ldrb     w8, [x1, #0x53]
006A12DDC  tbnz     w8, #5, #0x6a12df4
006A12DE0  ldr      x25, [x24, #0x170]
006A12DE4  b        #0x6a12e04 ; 
006A12DE8  ldr      x8, [x1, #0x60]
006A12DEC  mov      x0, x24
006A12DF0  b        #0x6a12e4c ; 
006A12DF4  ldr      x8, [x1, #0x60]
006A12DF8  mov      x0, x24
006A12DFC  blr      x8
006A12E00  mov      x25, x0
006A12E04  cbz      x25, #0x6a1370c
006A12E08  adrp     x19, #0x9591000
006A12E0C  ldrb     w8, [x19, #0xa75]
006A12E10  cbnz     w8, #0x6a12e28
006A12E14  adrp     x0, #0x8ee6000
006A12E18  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006A12E1C  bl       #0x382bd14 ; 
006A12E20  mov      w8, #1
006A12E24  strb     w8, [x19, #0xa75]
006A12E28  adrp     x8, #0x8ee6000
006A12E2C  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006A12E30  ldr      x1, [x8]
006A12E34  ldrb     w8, [x1, #0x53]
006A12E38  tbnz     w8, #5, #0x6a12e44
006A12E3C  ldr      w0, [x25, #0x24]
006A12E40  b        #0x6a12e50 ; 
006A12E44  ldr      x8, [x1, #0x60]
006A12E48  mov      x0, x25
006A12E4C  blr      x8
006A12E50  cmp      w0, #0xc9
006A12E54  b.ne     #0x6a12e90
006A12E58  ldrb     w8, [x21, #0xa7f]
006A12E5C  cbnz     w8, #0x6a12e74
006A12E60  adrp     x0, #0x8ee6000
006A12E64  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
006A12E68  bl       #0x382bd14 ; 
006A12E6C  mov      w8, #1
006A12E70  strb     w8, [x21, #0xa7f]
006A12E74  adrp     x8, #0x8ee6000
006A12E78  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
006A12E7C  ldr      x1, [x8]
006A12E80  ldrb     w8, [x1, #0x53]
006A12E84  tbnz     w8, #5, #0x6a12f34
006A12E88  ldr      x24, [x24, #0x178]
006A12E8C  b        #0x6a12f44 ; 
006A12E90  adrp     x19, #0x9591000
006A12E94  ldrb     w8, [x19, #0xa94]
006A12E98  cbnz     w8, #0x6a12eb0
006A12E9C  adrp     x0, #0x8ee6000
006A12EA0  ldr      x0, [x0, #0x788] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsHero()
006A12EA4  bl       #0x382bd14 ; 
006A12EA8  mov      w8, #1
006A12EAC  strb     w8, [x19, #0xa94]
006A12EB0  adrp     x8, #0x8ee6000
006A12EB4  ldr      x8, [x8, #0x788] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsHero()
006A12EB8  ldr      x1, [x8]
006A12EBC  ldrb     w8, [x1, #0x53]
006A12EC0  tbnz     w8, #5, #0x6a12f78
006A12EC4  adrp     x19, #0x9591000
006A12EC8  ldrb     w8, [x19, #0xa73]
006A12ECC  cbnz     w8, #0x6a12ee4
006A12ED0  adrp     x0, #0x8ee6000
006A12ED4  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006A12ED8  bl       #0x382bd14 ; 
006A12EDC  mov      w8, #1
006A12EE0  strb     w8, [x19, #0xa73]
006A12EE4  adrp     x8, #0x8ee6000
006A12EE8  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006A12EEC  ldr      x1, [x8]
006A12EF0  ldrb     w8, [x1, #0x53]
006A12EF4  tbnz     w8, #5, #0x6a12f8c
006A12EF8  adrp     x19, #0x9591000
006A12EFC  ldrb     w8, [x19, #0xa74]
006A12F00  cbnz     w8, #0x6a12f18
006A12F04  adrp     x0, #0x8ee6000
006A12F08  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006A12F0C  bl       #0x382bd14 ; 
006A12F10  mov      w8, #1
006A12F14  strb     w8, [x19, #0xa74]
006A12F18  adrp     x8, #0x8ee6000
006A12F1C  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006A12F20  ldr      x1, [x8]
006A12F24  ldrb     w8, [x1, #0x53]
006A12F28  tbnz     w8, #5, #0x6a12f98
006A12F2C  ldr      x25, [x24, #0x170]
006A12F30  b        #0x6a12fa8 ; 
006A12F34  ldr      x8, [x1, #0x60]
006A12F38  mov      x0, x24
006A12F3C  blr      x8
006A12F40  mov      x24, x0
006A12F44  adrp     x19, #0x8ee8000
006A12F48  ldr      x19, [x19, #0x898] ; GLOBAL LocalModels.Const_TypeInfo
006A12F4C  ldr      x0, [x19]
006A12F50  ldr      w8, [x0, #0xe0]
006A12F54  cbnz     w8, #0x6a12f5c
006A12F58  bl       #0x382be8c ; 
006A12F5C  cbz      x24, #0x6a1370c
006A12F60  ldr      x8, [x19]
006A12F64  adrp     x9, #0x8f22000
006A12F68  ldr      x8, [x8, #0xb8]
006A12F6C  ldr      x9, [x9, #0x308] ; GLOBAL DizzyInterval
006A12F70  ldr      x2, [x8, #0x1e0]
006A12F74  b        #0x6a13074 ; 
006A12F78  ldr      x8, [x1, #0x60]
006A12F7C  mov      x0, x24
006A12F80  blr      x8
006A12F84  tbnz     w0, #0, #0x6a12ffc
006A12F88  b        #0x6a13084 ; 
006A12F8C  ldr      x8, [x1, #0x60]
006A12F90  mov      x0, x24
006A12F94  b        #0x6a12ff0 ; 
006A12F98  ldr      x8, [x1, #0x60]
006A12F9C  mov      x0, x24
006A12FA0  blr      x8
006A12FA4  mov      x25, x0
006A12FA8  cbz      x25, #0x6a1370c
006A12FAC  adrp     x19, #0x9591000
006A12FB0  ldrb     w8, [x19, #0xa75]
006A12FB4  cbnz     w8, #0x6a12fcc
006A12FB8  adrp     x0, #0x8ee6000
006A12FBC  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006A12FC0  bl       #0x382bd14 ; 
006A12FC4  mov      w8, #1
006A12FC8  strb     w8, [x19, #0xa75]
006A12FCC  adrp     x8, #0x8ee6000
006A12FD0  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006A12FD4  ldr      x1, [x8]
006A12FD8  ldrb     w8, [x1, #0x53]
006A12FDC  tbnz     w8, #5, #0x6a12fe8
006A12FE0  ldr      w0, [x25, #0x24]
006A12FE4  b        #0x6a12ff4 ; 
006A12FE8  ldr      x8, [x1, #0x60]
006A12FEC  mov      x0, x25
006A12FF0  blr      x8
006A12FF4  cmp      w0, #1
006A12FF8  b.ne     #0x6a13084
006A12FFC  ldrb     w8, [x21, #0xa7f]
006A13000  cbnz     w8, #0x6a13018
006A13004  adrp     x0, #0x8ee6000
006A13008  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
006A1300C  bl       #0x382bd14 ; 
006A13010  mov      w8, #1
006A13014  strb     w8, [x21, #0xa7f]
006A13018  adrp     x8, #0x8ee6000
006A1301C  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute()
006A13020  ldr      x1, [x8]
006A13024  ldrb     w8, [x1, #0x53]
006A13028  tbnz     w8, #5, #0x6a13034
006A1302C  ldr      x24, [x24, #0x178]
006A13030  b        #0x6a13044 ; 
006A13034  ldr      x8, [x1, #0x60]
006A13038  mov      x0, x24
006A1303C  blr      x8
006A13040  mov      x24, x0
006A13044  adrp     x19, #0x8ee8000
006A13048  ldr      x19, [x19, #0x898] ; GLOBAL LocalModels.Const_TypeInfo
006A1304C  ldr      x0, [x19]
006A13050  ldr      w8, [x0, #0xe0]
006A13054  cbnz     w8, #0x6a1305c
006A13058  bl       #0x382be8c ; 
006A1305C  cbz      x24, #0x6a1370c
006A13060  ldr      x8, [x19]
006A13064  adrp     x9, #0x8f22000
006A13068  ldr      x8, [x8, #0xb8]
006A1306C  ldr      x9, [x9, #0x308] ; GLOBAL DizzyInterval
006A13070  ldr      x2, [x8, #0x240]
006A13074  ldr      x1, [x9]
006A13078  mov      x0, x24
006A1307C  mov      x3, xzr
006A13080  bl       #0x6b3bebc ; HotFix.Common.AttributeData$$AddAttributeValue
006A13084  mov      x0, x28
006A13088  mov      x1, x23
006A1308C  bl       #0x6a1387c ; HotFix.BattleLogic.BattleWorldContext$$ParseMonsterAbilityEffects
006A13090  mov      x0, x28
006A13094  mov      x1, x23
006A13098  bl       #0x6a13a68 ; HotFix.BattleLogic.BattleWorldContext$$TryApplyGuildBossAbilityEffects
006A1309C  tbz      w0, #0, #0x6a130ac
006A130A0  mov      x0, x23
006A130A4  mov      x1, xzr
006A130A8  bl       #0x6594ab4 ; 
006A130AC  adrp     x19, #0x9598000
006A130B0  ldrb     w8, [x19, #0xfc4]
006A130B4  cbnz     w8, #0x6a130cc
006A130B8  adrp     x0, #0x8f05000
006A130BC  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr()
006A130C0  bl       #0x382bd14 ; 
006A130C4  mov      w8, #1
006A130C8  strb     w8, [x19, #0xfc4]
006A130CC  adrp     x8, #0x8f05000
006A130D0  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr()
006A130D4  ldr      x1, [x8]
006A130D8  ldrb     w8, [x1, #0x53]
006A130DC  tbnz     w8, #5, #0x6a130e8
006A130E0  ldr      x0, [x28, #0x220]
006A130E4  b        #0x6a130f4 ; 
006A130E8  ldr      x8, [x1, #0x60]
006A130EC  mov      x0, x28
006A130F0  blr      x8
006A130F4  cbz      x0, #0x6a1370c
006A130F8  ldr      x8, [x0]
006A130FC  mov      x1, x23
006A13100  ldr      x9, [x8, #0x368]
006A13104  ldr      x2, [x8, #0x370]
006A13108  blr      x9
006A1310C  adrp     x8, #0x8f32000
006A13110  ldr      x8, [x8, #0xec0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<CreateMonsterEvent>()
006A13114  ldr      x24, [x8]
006A13118  ldr      x8, [x24, #0x38]
006A1311C  cbnz     x8, #0x6a13128
006A13120  mov      x0, x24
006A13124  bl       #0x3a7e668 ; 
006A13128  ldrb     w8, [x24, #0x53]
006A1312C  tbnz     w8, #5, #0x6a1316c
006A13130  adrp     x19, #0x9591000
006A13134  ldrb     w8, [x19, #0xa61]
006A13138  cbnz     w8, #0x6a13150
006A1313C  adrp     x0, #0x8ee6000
006A13140  ldr      x0, [x0, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool()
006A13144  bl       #0x382bd14 ; 
006A13148  mov      w8, #1
006A1314C  strb     w8, [x19, #0xa61]
006A13150  adrp     x8, #0x8ee6000
006A13154  ldr      x8, [x8, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool()
006A13158  ldr      x1, [x8]
006A1315C  ldrb     w8, [x1, #0x53]
006A13160  tbnz     w8, #5, #0x6a13180
006A13164  ldr      x0, [x28, #0x1e8]
006A13168  b        #0x6a1318c ; 
006A1316C  ldr      x8, [x24, #0x60]
006A13170  mov      x0, x28
006A13174  mov      x1, x24
006A13178  blr      x8
006A1317C  b        #0x6a1319c ; 
006A13180  ldr      x8, [x1, #0x60]
006A13184  mov      x0, x28
006A13188  blr      x8
006A1318C  cbz      x0, #0x6a1370c
006A13190  ldr      x8, [x24, #0x38]
006A13194  ldr      x1, [x8]
006A13198  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
006A1319C  adrp     x8, #0x8ee6000
006A131A0  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
006A131A4  mov      x24, x0
006A131A8  ldr      x1, [x8]
006A131AC  ldrb     w8, [x1, #0x53]
006A131B0  tbnz     w8, #5, #0x6a131bc
006A131B4  ldr      x1, [x23, #0x38]
006A131B8  b        #0x6a131cc ; 
006A131BC  ldr      x8, [x1, #0x60]
006A131C0  mov      x0, x23
006A131C4  blr      x8
006A131C8  mov      x1, x0
006A131CC  cbz      x24, #0x6a1370c
006A131D0  mov      x25, x24
006A131D4  str      x1, [x25, #0x20]!
006A131D8  mov      x0, x25
006A131DC  bl       #0x382bcb8 ; 
006A131E0  ldr      x8, [x23]
006A131E4  mov      x0, x23
006A131E8  ldr      x9, [x8, #0x498]
006A131EC  ldr      x1, [x8, #0x4a0]
006A131F0  blr      x9
006A131F4  str      w0, [x25, #0x18]
006A131F8  adrp     x19, #0x959d000
006A131FC  ldrb     w8, [x19, #0x694]
006A13200  cbnz     w8, #0x6a13218
006A13204  adrp     x0, #0x8f1e000
006A13208  ldr      x0, [x0, #0x5b0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.GetAnimator()
006A1320C  bl       #0x382bd14 ; 
006A13210  mov      w8, #1
006A13214  strb     w8, [x19, #0x694]
006A13218  adrp     x8, #0x8f1e000
006A1321C  ldr      x8, [x8, #0x5b0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.GetAnimator()
006A13220  ldr      x1, [x8]
006A13224  ldrb     w8, [x1, #0x53]
006A13228  tbnz     w8, #5, #0x6a13234
006A1322C  ldr      x1, [x23, #0x80]
006A13230  b        #0x6a13244 ; 
006A13234  ldr      x8, [x1, #0x60]
006A13238  mov      x0, x23
006A1323C  blr      x8
006A13240  mov      x1, x0
006A13244  mov      x0, x24
006A13248  str      x1, [x0, #0x28]!
006A1324C  bl       #0x382bcb8 ; 
006A13250  ldr      x25, [x28, #0x1e0]
006A13254  cbz      x25, #0x6a1370c
006A13258  adrp     x9, #0x8f32000
006A1325C  ldr      x9, [x9, #0xec8] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<CreateMonsterEvent>()
006A13260  ldr      x8, [x25]
006A13264  ldr      x26, [x9]
006A13268  ldrh     w9, [x8, #0x12e]
006A1326C  ldr      x1, [x26, #0x20]
006A13270  ldrh     w2, [x26, #0x50]
006A13274  cbz      x9, #0x6a13298
006A13278  ldr      x10, [x8, #0xb0]
006A1327C  add      x10, x10, #8
006A13280  ldur     x11, [x10, #-8]
006A13284  cmp      x11, x1
006A13288  b.eq     #0x6a132a4
006A1328C  subs     x9, x9, #1
006A13290  add      x10, x10, #0x10
006A13294  b.ne     #0x6a13280
006A13298  mov      x0, x25
006A1329C  bl       #0x3a7e710 ; 
006A132A0  b        #0x6a132b4 ; 
006A132A4  ldr      w9, [x10]
006A132A8  add      w9, w9, w2
006A132AC  add      x8, x8, w9, sxtw #4
006A132B0  add      x0, x8, #0x138
006A132B4  ldr      x0, [x0, #8]
006A132B8  mov      x1, x26
006A132BC  bl       #0x382be88 ; 
006A132C0  ldr      x8, [x0, #8]
006A132C4  mov      x2, x0
006A132C8  mov      x0, x25
006A132CC  mov      x1, x24
006A132D0  blr      x8
006A132D4  adrp     x8, #0x8f07000
006A132D8  ldr      x8, [x8, #0xfd0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.PushComponent()
006A132DC  mov      w1, #1
006A132E0  mov      x0, x23
006A132E4  ldr      x2, [x8]
006A132E8  bl       #0x60b34ec ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
006A132EC  ldr      w8, [x28, #0x1c8]
006A132F0  cmp      w8, #4
006A132F4  b.ne     #0x6a13350
006A132F8  adrp     x19, #0x9599000
006A132FC  ldrb     w8, [x19, #0x64c]
006A13300  cbnz     w8, #0x6a13318
006A13304  adrp     x0, #0x8f0a000
006A13308  ldr      x0, [x0, #0x608] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_TermManger()
006A1330C  bl       #0x382bd14 ; 
006A13310  mov      w8, #1
006A13314  strb     w8, [x19, #0x64c]
006A13318  adrp     x8, #0x8f0a000
006A1331C  ldr      x8, [x8, #0x608] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_TermManger()
006A13320  ldr      x1, [x8]
006A13324  ldrb     w8, [x1, #0x53]
006A13328  tbnz     w8, #5, #0x6a13334
006A1332C  ldr      x0, [x28, #0x248]
006A13330  b        #0x6a13340 ; 
006A13334  ldr      x8, [x1, #0x60]
006A13338  mov      x0, x28
006A1333C  blr      x8
006A13340  cbz      x0, #0x6a1370c
006A13344  mov      x1, x23
006A13348  mov      x2, xzr
006A1334C  bl       #0x65b9714 ; HotFix.BattleLogic.BattleTermManger$$OnMonsterCreate
006A13350  cbz      x22, #0x6a134d0
006A13354  adrp     x19, #0x959d000
006A13358  ldrb     w8, [x19, #0x69a]
006A1335C  cbnz     w8, #0x6a13374
006A13360  adrp     x0, #0x8f27000
006A13364  ldr      x0, [x0, #0xb00] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_MonsterTraitID()
006A13368  bl       #0x382bd14 ; 
006A1336C  mov      w8, #1
006A13370  strb     w8, [x19, #0x69a]
006A13374  adrp     x8, #0x8f27000
006A13378  ldr      x8, [x8, #0xb00] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_MonsterTraitID()
006A1337C  ldr      x1, [x8]
006A13380  ldrb     w8, [x1, #0x53]
006A13384  tbnz     w8, #5, #0x6a13390
006A13388  ldr      x22, [x22, #0x98]
006A1338C  b        #0x6a133a0 ; 
006A13390  ldr      x8, [x1, #0x60]
006A13394  mov      x0, x22
006A13398  blr      x8
006A1339C  mov      x22, x0
006A133A0  cbz      x22, #0x6a1370c
006A133A4  ldr      x8, [x22, #0x18]
006A133A8  cmp      w8, #1
006A133AC  b.lt     #0x6a134d0
006A133B0  adrp     x24, #0x8f32000
006A133B4  adrp     x25, #0x8f28000
006A133B8  ldr      x24, [x24, #0x658] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.GetMonsterTrait()
006A133BC  ldr      x25, [x25, #0x1a8] ; GLOBAL Method$LocalModels.Bean.Character_MonsterTrait.get_SkillId()
006A133C0  mov      x19, xzr
006A133C4  and      x8, x8, #0xffffffff
006A133C8  add      x20, x22, #0x20
006A133CC  adrp     x21, #0x959d000
006A133D0  mov      w23, #1
006A133D4  adrp     x27, #0x959d000
006A133D8  cmp      x19, w8, uxtw
006A133DC  b.hs     #0x6a13710
006A133E0  ldrb     w8, [x21, #0x69b]
006A133E4  ldr      w26, [x20, x19, lsl #2]
006A133E8  cbnz     w8, #0x6a133f8
006A133EC  mov      x0, x24
006A133F0  bl       #0x382bd14 ; 
006A133F4  strb     w23, [x21, #0x69b]
006A133F8  ldr      x2, [x24]
006A133FC  ldrb     w8, [x2, #0x53]
006A13400  tbnz     w8, #5, #0x6a13440
006A13404  adrp     x8, #0x9598000
006A13408  ldrb     w8, [x8, #0xfcc]
006A1340C  cbnz     w8, #0x6a13424
006A13410  adrp     x0, #0x8f06000
006A13414  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
006A13418  bl       #0x382bd14 ; 
006A1341C  adrp     x8, #0x9598000
006A13420  strb     w23, [x8, #0xfcc]
006A13424  adrp     x8, #0x8f06000
006A13428  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
006A1342C  ldr      x1, [x8]
006A13430  ldrb     w8, [x1, #0x53]
006A13434  tbnz     w8, #5, #0x6a13454
006A13438  ldr      x0, [x28, #0x200]
006A1343C  b        #0x6a13460 ; 
006A13440  ldr      x8, [x2, #0x60]
006A13444  mov      x0, x28
006A13448  mov      w1, w26
006A1344C  blr      x8
006A13450  b        #0x6a13470 ; 
006A13454  ldr      x8, [x1, #0x60]
006A13458  mov      x0, x28
006A1345C  blr      x8
006A13460  cbz      x0, #0x6a1370c
006A13464  mov      w1, w26
006A13468  mov      x2, xzr
006A1346C  bl       #0x64d5404 ; LocalModels.LocalModelManager$$GetCharacter_MonsterTrait
006A13470  mov      x26, x0
006A13474  cbz      x0, #0x6a134c0
006A13478  ldrb     w8, [x27, #0x69c]
006A1347C  cbnz     w8, #0x6a1348c
006A13480  mov      x0, x25
006A13484  bl       #0x382bd14 ; 
006A13488  strb     w23, [x27, #0x69c]
006A1348C  ldr      x1, [x25]
006A13490  ldrb     w8, [x1, #0x53]
006A13494  tbnz     w8, #5, #0x6a134a0
006A13498  ldr      w2, [x26, #0x24]
006A1349C  b        #0x6a134b0 ; 
006A134A0  ldr      x8, [x1, #0x60]
006A134A4  mov      x0, x26
006A134A8  blr      x8
006A134AC  mov      w2, w0
006A134B0  ldr      x1, [sp, #0x38]
006A134B4  mov      w3, #1
006A134B8  mov      x0, x28
006A134BC  bl       #0x6a13d58 ; HotFix.BattleLogic.BattleWorldContext$$AddSkillToMonster
006A134C0  ldr      w8, [x22, #0x18]
006A134C4  add      x19, x19, #1
006A134C8  cmp      x19, w8, sxtw
006A134CC  b.lt     #0x6a133d8
006A134D0  mov      x0, x28
006A134D4  bl       #0x6a145d0 ; HotFix.BattleLogic.BattleWorldContext$$IsLatestChapter
006A134D8  ldr      x21, [sp, #0x20]
006A134DC  tbz      w0, #0, #0x6a13674
006A134E0  ldr      x0, [x28, #0x2b8]
006A134E4  cbz      x0, #0x6a13500
006A134E8  adrp     x8, #0x8f08000
006A134EC  ldr      w1, [x29]
006A134F0  ldr      x8, [x8, #0x630] ; GLOBAL Method$System.Collections.Generic.List<int>.Contains()
006A134F4  ldr      x2, [x8]
006A134F8  bl       #0x4d648cc ; System.Collections.Generic.List<int>$$Contains
006A134FC  tbnz     w0, #0, #0x6a13674
006A13500  ldr      x0, [x28, #0x3b8]
006A13504  mov      x1, xzr
006A13508  bl       #0x6b27438 ; LocalModels.Bean.ChapterABTestExtension$$GetABNewMonsters
006A1350C  cbz      x0, #0x6a13674
006A13510  ldr      w8, [x0, #0x18]
006A13514  cmp      w8, #1
006A13518  b.lt     #0x6a13674
006A1351C  ldr      w10, [x29]
006A13520  mov      x9, xzr
006A13524  add      x11, x0, #0x20
006A13528  cmp      w9, w8
006A1352C  b.hs     #0x6a13710
006A13530  ldr      w12, [x11, x9, lsl #2]
006A13534  cmp      w12, w10
006A13538  b.eq     #0x6a1354c
006A1353C  add      x9, x9, #1
006A13540  cmp      w9, w8
006A13544  b.lt     #0x6a13528
006A13548  b        #0x6a13674 ; 
006A1354C  adrp     x8, #0x8f32000
006A13550  ldr      x8, [x8, #0xef8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateRenderEvent<NewMonsterAppearEvent>()
006A13554  ldr      x21, [x8]
006A13558  ldr      x8, [x21, #0x38]
006A1355C  cbnz     x8, #0x6a13568
006A13560  mov      x0, x21
006A13564  bl       #0x3a7e668 ; 
006A13568  ldrb     w8, [x21, #0x53]
006A1356C  tbnz     w8, #5, #0x6a135ac
006A13570  adrp     x19, #0x9591000
006A13574  ldrb     w8, [x19, #0xa61]
006A13578  cbnz     w8, #0x6a13590
006A1357C  adrp     x0, #0x8ee6000
006A13580  ldr      x0, [x0, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool()
006A13584  bl       #0x382bd14 ; 
006A13588  mov      w8, #1
006A1358C  strb     w8, [x19, #0xa61]
006A13590  adrp     x8, #0x8ee6000
006A13594  ldr      x8, [x8, #0x308] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_RenderEventPool()
006A13598  ldr      x1, [x8]
006A1359C  ldrb     w8, [x1, #0x53]
006A135A0  tbnz     w8, #5, #0x6a135c0
006A135A4  ldr      x0, [x28, #0x1e8]
006A135A8  b        #0x6a135cc ; 
006A135AC  ldr      x8, [x21, #0x60]
006A135B0  mov      x0, x28
006A135B4  mov      x1, x21
006A135B8  blr      x8
006A135BC  b        #0x6a135dc ; 
006A135C0  ldr      x8, [x1, #0x60]
006A135C4  mov      x0, x28
006A135C8  blr      x8
006A135CC  cbz      x0, #0x6a1370c
006A135D0  ldr      x8, [x21, #0x38]
006A135D4  ldr      x1, [x8]
006A135D8  bl       #0x46bd6bc ; HotFix.BattleLogic.RenderEventPool$$CreateRenderEvent<object>
006A135DC  mov      x21, x0
006A135E0  cbz      x0, #0x6a1370c
006A135E4  ldr      w8, [x29]
006A135E8  str      w8, [x21, #0x20]
006A135EC  ldr      x22, [x28, #0x1e0]
006A135F0  cbz      x22, #0x6a1370c
006A135F4  adrp     x9, #0x8f32000
006A135F8  ldr      x9, [x9, #0xf00] ; GLOBAL Method$HotFix.BattleLogic.IRenderBridge.DispatchRenderEvent<NewMonsterAppearEvent>()
006A135FC  ldr      x8, [x22]
006A13600  ldr      x24, [x9]
006A13604  ldrh     w9, [x8, #0x12e]
006A13608  ldr      x1, [x24, #0x20]
006A1360C  ldrh     w2, [x24, #0x50]
006A13610  cbz      x9, #0x6a13634
006A13614  ldr      x10, [x8, #0xb0]
006A13618  add      x10, x10, #8
006A1361C  ldur     x11, [x10, #-8]
006A13620  cmp      x11, x1
006A13624  b.eq     #0x6a13640
006A13628  subs     x9, x9, #1
006A1362C  add      x10, x10, #0x10
006A13630  b.ne     #0x6a1361c
006A13634  mov      x0, x22
006A13638  bl       #0x3a7e710 ; 
006A1363C  b        #0x6a13650 ; 
006A13640  ldr      w9, [x10]
006A13644  add      w9, w9, w2
006A13648  add      x8, x8, w9, sxtw #4
006A1364C  add      x0, x8, #0x138
006A13650  ldr      x0, [x0, #8]
006A13654  mov      x1, x24
006A13658  bl       #0x382be88 ; 
006A1365C  ldr      x8, [x0, #8]
006A13660  mov      x2, x0
006A13664  mov      x0, x22
006A13668  mov      x1, x21
006A1366C  blr      x8
006A13670  ldr      x21, [sp, #0x20]
006A13674  adrp     x19, #0x959d000
006A13678  ldrb     w8, [x19, #0x69d]
006A1367C  ldr      w20, [x29]
006A13680  cbnz     w8, #0x6a13698
006A13684  adrp     x0, #0x8f32000
006A13688  ldr      x0, [x0, #0x760] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddCreateMonster()
006A1368C  bl       #0x382bd14 ; 
006A13690  mov      w8, #1
006A13694  strb     w8, [x19, #0x69d]
006A13698  adrp     x8, #0x8f32000
006A1369C  ldr      x8, [x8, #0x760] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddCreateMonster()
006A136A0  ldr      x19, [sp, #0x38]
006A136A4  ldr      x2, [x8]
006A136A8  ldrb     w8, [x2, #0x53]
006A136AC  tbnz     w8, #5, #0x6a136c4
006A136B0  add      x0, x28, #0x290
006A136B4  mov      w1, w20
006A136B8  mov      x2, xzr
006A136BC  bl       #0x658e740 ; HotFix.BattleLogic.BattleData$$AddCreateMonster
006A136C0  b        #0x6a136d4 ; 
006A136C4  ldr      x8, [x2, #0x60]
006A136C8  mov      x0, x28
006A136CC  mov      w1, w20
006A136D0  blr      x8
006A136D4  ldr      x8, [x21, #0x28]
006A136D8  ldr      x9, [sp, #0x1b8]
006A136DC  cmp      x8, x9
006A136E0  b.ne     #0x6a1371c
006A136E4  mov      x0, x19
006A136E8  add      sp, sp, #0x1c0
006A136EC  ldp      x20, x19, [sp, #0x50]
006A136F0  ldp      x22, x21, [sp, #0x40]
006A136F4  ldp      x24, x23, [sp, #0x30]
006A136F8  ldp      x26, x25, [sp, #0x20]
006A136FC  ldp      x28, x27, [sp, #0x10]
006A13700  ldp      x29, x30, [sp], #0x60
006A13704  ret      
006A13708  bl       #0x382bfb8 ; 
006A1370C  bl       #0x382bfb8 ; 
006A13710  bl       #0x382bfc0 ; 
006A13714  bl       #0x382bfb8 ; 
006A13718  bl       #0x382bfb8 ; 
006A1371C  bl       #0x89edb60 ; 
006A13720  b        #0x6a13758 ; 
006A13724  b        #0x6a13758 ; 
006A13728  b        #0x6a13758 ; 
006A1372C  b        #0x6a13758 ; 
006A13730  b        #0x6a13758 ; 
006A13734  b        #0x6a13758 ; 
006A13738  b        #0x6a13758 ; 
006A1373C  b        #0x6a13758 ; 
006A13740  b        #0x6a13758 ; 
006A13744  b        #0x6a13758 ; 
006A13748  b        #0x6a137f8 ; 
006A1374C  b        #0x6a13758 ; 
006A13750  b        #0x6a13758 ; 
006A13754  b        #0x6a13758 ; 
006A13758  mov      x26, x0
006A1375C  cmp      w1, #1
006A13760  b.ne     #0x6a137a4
006A13764  mov      x0, x26
006A13768  bl       #0x89eda50 ; 
006A1376C  ldr      x27, [x0]
006A13770  bl       #0x89eda60 ; 
006A13774  adrp     x8, #0x8f18000
006A13778  ldr      x8, [x8, #0xe60] ; GLOBAL Method$System.Collections.Generic.List.Enumerator<AttributeOneElement>.Dispose()
006A1377C  add      x0, sp, #0xe0
006A13780  ldr      x1, [x8]
006A13784  bl       #0x60d5ec0 ; System.Collections.Generic.List.Enumerator<AttributeOneElement>$$Dispose
006A13788  ldp      x29, x28, [sp, #0x28]
006A1378C  ldr      x23, [sp, #0x38]
006A13790  mov      x22, x19
006A13794  adrp     x21, #0x9591000
006A13798  cbz      x27, #0x6a12a14
006A1379C  mov      x0, x27
006A137A0  bl       #0x382bfb0 ; 
006A137A4  mov      x27, xzr
006A137A8  b        #0x6a137b0 ; 
006A137AC  mov      x26, x0
006A137B0  adrp     x8, #0x8f18000
006A137B4  ldr      x8, [x8, #0xe60] ; GLOBAL Method$System.Collections.Generic.List.Enumerator<AttributeOneElement>.Dispose()
006A137B8  ldr      x1, [x8]
006A137BC  add      x0, sp, #0xe0
006A137C0  bl       #0x60d5ec0 ; System.Collections.Generic.List.Enumerator<AttributeOneElement>$$Dispose
006A137C4  cbz      x27, #0x6a13868
006A137C8  mov      x0, x27
006A137CC  bl       #0x382bfb0 ; 
006A137D0  b        #0x6a137f8 ; 
006A137D4  b        #0x6a137f8 ; 
006A137D8  b        #0x6a137f8 ; 
006A137DC  b        #0x6a137f8 ; 
006A137E0  b        #0x6a137f8 ; 
006A137E4  b        #0x6a137f8 ; 
006A137E8  b        #0x6a137f8 ; 
006A137EC  b        #0x6a137f8 ; 
006A137F0  b        #0x6a137f8 ; 
006A137F4  b        #0x6a137f8 ; 
006A137F8  mov      x26, x0
006A137FC  cmp      w1, #1
006A13800  b.ne     #0x6a13844
006A13804  mov      x0, x26
006A13808  bl       #0x89eda50 ; 
006A1380C  ldr      x25, [x0]
006A13810  bl       #0x89eda60 ; 
006A13814  adrp     x8, #0x8f18000
006A13818  ldr      x8, [x8, #0xe60] ; GLOBAL Method$System.Collections.Generic.List.Enumerator<AttributeOneElement>.Dispose()
006A1381C  add      x0, sp, #0xe0
006A13820  ldr      x1, [x8]
006A13824  bl       #0x60d5ec0 ; System.Collections.Generic.List.Enumerator<AttributeOneElement>$$Dispose
006A13828  ldp      x29, x28, [sp, #0x28]
006A1382C  ldp      x24, x22, [sp, #0x10]
006A13830  ldr      x23, [sp, #0x38]
006A13834  adrp     x21, #0x9591000
006A13838  cbz      x25, #0x6a12c44
006A1383C  mov      x0, x25
006A13840  bl       #0x382bfb0 ; 
006A13844  mov      x25, xzr
006A13848  b        #0x6a13850 ; 
006A1384C  mov      x26, x0
006A13850  adrp     x8, #0x8f18000
006A13854  ldr      x8, [x8, #0xe60] ; GLOBAL Method$System.Collections.Generic.List.Enumerator<AttributeOneElement>.Dispose()
006A13858  ldr      x1, [x8]
006A1385C  add      x0, sp, #0xe0
006A13860  bl       #0x60d5ec0 ; System.Collections.Generic.List.Enumerator<AttributeOneElement>$$Dispose
006A13864  cbnz     x25, #0x6a13870
006A13868  mov      x0, x26
006A1386C  bl       #0x3b56bfc ; 
006A13870  mov      x0, x25
006A13874  bl       #0x382bfb0 ; 
006A13878  bl       #0x3442448 ; 

