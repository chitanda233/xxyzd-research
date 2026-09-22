; HotFix.BattleLogic.EntityBullet$$CheckDead
; RVA 0x66849BC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066849BC  sub      sp, sp, #0xe0
0066849C0  stp      x29, x30, [sp, #0x80]
0066849C4  stp      x28, x27, [sp, #0x90]
0066849C8  stp      x26, x25, [sp, #0xa0]
0066849CC  stp      x24, x23, [sp, #0xb0]
0066849D0  stp      x22, x21, [sp, #0xc0]
0066849D4  stp      x20, x19, [sp, #0xd0]
0066849D8  mrs      x23, tpidr_el0
0066849DC  ldr      x8, [x23, #0x28]
0066849E0  adrp     x20, #0x9599000
0066849E4  adrp     x21, #0x8f10000
0066849E8  mov      x19, x0
0066849EC  str      x8, [sp, #0x78]
0066849F0  ldrb     w8, [x20, #0xf9e]
0066849F4  ldr      x21, [x21, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityBullet.CheckDead()
0066849F8  tbnz     w8, #0, #0x6684a40
0066849FC  adrp     x0, #0x8ee8000
006684A00  ldr      x0, [x0, #0x898] ; GLOBAL LocalModels.Const_TypeInfo
006684A04  bl       #0x382bd14 ; 
006684A08  adrp     x0, #0x8ee6000
006684A0C  ldr      x0, [x0, #0xe0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<BulletData>.get_Data()
006684A10  bl       #0x382bd14 ; 
006684A14  adrp     x0, #0x8f10000
006684A18  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityBullet.CheckDead()
006684A1C  bl       #0x382bd14 ; 
006684A20  adrp     x0, #0x8ee6000
006684A24  ldr      x0, [x0, #0x1b8] ; GLOBAL Bullet_LifeTime
006684A28  bl       #0x382bd14 ; 
006684A2C  adrp     x0, #0x8f10000
006684A30  ldr      x0, [x0, #0x2e0] ; GLOBAL DynamicBulletLifeTime%
006684A34  bl       #0x382bd14 ; 
006684A38  mov      w8, #1
006684A3C  strb     w8, [x20, #0xf9e]
006684A40  ldr      x1, [x21]
006684A44  ldrb     w8, [x1, #0x53]
006684A48  tbnz     w8, #5, #0x6684a98
006684A4C  mov      w1, #4
006684A50  mov      x0, x19
006684A54  bl       #0x6681fc4 ; HotFix.BattleLogic.EntityBullet$$HaveBulletFlag
006684A58  tbz      w0, #0, #0x6684b8c
006684A5C  adrp     x20, #0x9591000
006684A60  ldrb     w8, [x20, #0xa4b]
006684A64  cbnz     w8, #0x6684a7c
006684A68  adrp     x0, #0x8ee5000
006684A6C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006684A70  bl       #0x382bd14 ; 
006684A74  mov      w8, #1
006684A78  strb     w8, [x20, #0xa4b]
006684A7C  adrp     x8, #0x8ee5000
006684A80  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006684A84  ldr      x1, [x8]
006684A88  ldrb     w8, [x1, #0x53]
006684A8C  tbnz     w8, #5, #0x6684abc
006684A90  ldr      x20, [x19, #0x20]
006684A94  b        #0x6684acc ; 
006684A98  ldr      x8, [x1, #0x60]
006684A9C  mov      x0, x19
006684AA0  blr      x8
006684AA4  ldr      x8, [x23, #0x28]
006684AA8  ldr      x9, [sp, #0x78]
006684AAC  cmp      x8, x9
006684AB0  b.ne     #0x6684e98
006684AB4  and      w0, w0, #1
006684AB8  b        #0x6684f54 ; 
006684ABC  ldr      x8, [x1, #0x60]
006684AC0  mov      x0, x19
006684AC4  blr      x8
006684AC8  mov      x20, x0
006684ACC  cbz      x20, #0x6684ff0
006684AD0  adrp     x21, #0x9591000
006684AD4  ldrb     w8, [x21, #0xa9c]
006684AD8  cbnz     w8, #0x6684af0
006684ADC  adrp     x0, #0x8ee6000
006684AE0  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
006684AE4  bl       #0x382bd14 ; 
006684AE8  mov      w8, #1
006684AEC  strb     w8, [x21, #0xa9c]
006684AF0  adrp     x8, #0x8ee6000
006684AF4  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr()
006684AF8  ldr      x1, [x8]
006684AFC  ldrb     w8, [x1, #0x53]
006684B00  tbnz     w8, #5, #0x6684b0c
006684B04  ldr      x20, [x20, #0x240]
006684B08  b        #0x6684b1c ; 
006684B0C  ldr      x8, [x1, #0x60]
006684B10  mov      x0, x20
006684B14  blr      x8
006684B18  mov      x20, x0
006684B1C  adrp     x8, #0x8ee6000
006684B20  ldr      x8, [x8, #0xe0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<BulletData>.get_Data()
006684B24  ldr      x1, [x8]
006684B28  ldrb     w8, [x1, #0x53]
006684B2C  tbnz     w8, #5, #0x6684b38
006684B30  ldr      x0, [x19, #0x38]
006684B34  b        #0x6684b44 ; 
006684B38  ldr      x8, [x1, #0x60]
006684B3C  mov      x0, x19
006684B40  blr      x8
006684B44  cbz      x0, #0x6684ff0
006684B48  add      x8, sp, #0x48
006684B4C  mov      x1, xzr
006684B50  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006684B54  ldur     q0, [sp, #0x48]
006684B58  ldr      x8, [sp, #0x58]
006684B5C  str      q0, [sp, #0x60]
006684B60  str      x8, [sp, #0x70]
006684B64  cbz      x20, #0x6684ff0
006684B68  ldr      q0, [sp, #0x60]
006684B6C  ldr      x8, [sp, #0x70]
006684B70  add      x1, sp, #0x30
006684B74  mov      x0, x20
006684B78  mov      x2, xzr
006684B7C  str      q0, [sp, #0x30]
006684B80  str      x8, [sp, #0x40]
006684B84  bl       #0x690906c ; HotFix.BattleLogic.MapManager$$IsPosInMapGround
006684B88  tbz      w0, #0, #0x6684f40
006684B8C  mov      x0, x19
006684B90  bl       #0x6681f5c ; HotFix.BattleLogic.EntityBullet$$get_Persistence
006684B94  tbz      w0, #0, #0x6684ba0
006684B98  mov      w0, wzr
006684B9C  b        #0x6684f44 ; 
006684BA0  adrp     x24, #0x9591000
006684BA4  ldrb     w8, [x24, #0xa4b]
006684BA8  cbnz     w8, #0x6684bc0
006684BAC  adrp     x0, #0x8ee5000
006684BB0  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006684BB4  bl       #0x382bd14 ; 
006684BB8  mov      w8, #1
006684BBC  strb     w8, [x24, #0xa4b]
006684BC0  adrp     x25, #0x8ee5000
006684BC4  ldr      x25, [x25, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006684BC8  ldr      x1, [x25]
006684BCC  ldrb     w8, [x1, #0x53]
006684BD0  tbnz     w8, #5, #0x6684bdc
006684BD4  ldr      x0, [x19, #0x20]
006684BD8  b        #0x6684be8 ; 
006684BDC  ldr      x8, [x1, #0x60]
006684BE0  mov      x0, x19
006684BE4  blr      x8
006684BE8  cbz      x0, #0x6684ff0
006684BEC  adrp     x20, #0x959a000
006684BF0  ldrb     w8, [x20, #0xce]
006684BF4  ldr      x27, [x0, #0x128]
006684BF8  cbnz     w8, #0x6684c10
006684BFC  adrp     x0, #0x8f10000
006684C00  ldr      x0, [x0, #0xf0] ; GLOBAL Method$HotFix.BattleLogic.EntityBullet.get_BornTime()
006684C04  bl       #0x382bd14 ; 
006684C08  mov      w8, #1
006684C0C  strb     w8, [x20, #0xce]
006684C10  adrp     x8, #0x8f10000
006684C14  ldr      x8, [x8, #0xf0] ; GLOBAL Method$HotFix.BattleLogic.EntityBullet.get_BornTime()
006684C18  ldr      x1, [x8]
006684C1C  ldrb     w8, [x1, #0x53]
006684C20  tbnz     w8, #5, #0x6684c2c
006684C24  ldr      x20, [x19, #0x50]
006684C28  b        #0x6684c3c ; 
006684C2C  ldr      x8, [x1, #0x60]
006684C30  mov      x0, x19
006684C34  blr      x8
006684C38  mov      x20, x0
006684C3C  adrp     x26, #0x8ee6000
006684C40  ldr      x26, [x26, #0xe0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<BulletData>.get_Data()
006684C44  ldr      x1, [x26]
006684C48  ldrb     w8, [x1, #0x53]
006684C4C  tbnz     w8, #5, #0x6684c58
006684C50  ldr      x21, [x19, #0x38]
006684C54  b        #0x6684c68 ; 
006684C58  ldr      x8, [x1, #0x60]
006684C5C  mov      x0, x19
006684C60  blr      x8
006684C64  mov      x21, x0
006684C68  cbz      x21, #0x6684ff0
006684C6C  adrp     x28, #0x9591000
006684C70  ldrb     w8, [x28, #0xa72]
006684C74  cbnz     w8, #0x6684c8c
006684C78  adrp     x0, #0x8ee6000
006684C7C  ldr      x0, [x0, #0x278] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Attribute()
006684C80  bl       #0x382bd14 ; 
006684C84  mov      w8, #1
006684C88  strb     w8, [x28, #0xa72]
006684C8C  adrp     x29, #0x8ee6000
006684C90  ldr      x29, [x29, #0x278] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Attribute()
006684C94  ldr      x1, [x29]
006684C98  ldrb     w8, [x1, #0x53]
006684C9C  tbnz     w8, #5, #0x6684ca8
006684CA0  ldr      x0, [x21, #0x180]
006684CA4  b        #0x6684cb4 ; 
006684CA8  ldr      x8, [x1, #0x60]
006684CAC  mov      x0, x21
006684CB0  blr      x8
006684CB4  cbz      x0, #0x6684ff0
006684CB8  adrp     x8, #0x8ee6000
006684CBC  ldr      x8, [x8, #0x1b8] ; GLOBAL Bullet_LifeTime
006684CC0  mov      x2, xzr
006684CC4  ldr      x1, [x8]
006684CC8  bl       #0x6b3bc94 ; HotFix.Common.AttributeData$$GetAttributeValue
006684CCC  ldr      x1, [x26]
006684CD0  mov      x21, x0
006684CD4  ldrb     w8, [x1, #0x53]
006684CD8  tbnz     w8, #5, #0x6684ce4
006684CDC  ldr      x22, [x19, #0x38]
006684CE0  b        #0x6684cf4 ; 
006684CE4  ldr      x8, [x1, #0x60]
006684CE8  mov      x0, x19
006684CEC  blr      x8
006684CF0  mov      x22, x0
006684CF4  cbz      x22, #0x6684ff0
006684CF8  ldrb     w8, [x28, #0xa72]
006684CFC  cbnz     w8, #0x6684d14
006684D00  adrp     x0, #0x8ee6000
006684D04  ldr      x0, [x0, #0x278] ; GLOBAL Method$HotFix.BattleLogic.BulletData.get_Attribute()
006684D08  bl       #0x382bd14 ; 
006684D0C  mov      w8, #1
006684D10  strb     w8, [x28, #0xa72]
006684D14  ldr      x1, [x29]
006684D18  ldrb     w8, [x1, #0x53]
006684D1C  tbnz     w8, #5, #0x6684d28
006684D20  ldr      x0, [x22, #0x180]
006684D24  b        #0x6684d34 ; 
006684D28  ldr      x8, [x1, #0x60]
006684D2C  mov      x0, x22
006684D30  blr      x8
006684D34  cbz      x0, #0x6684ff0
006684D38  adrp     x8, #0x8f10000
006684D3C  ldr      x8, [x8, #0x2e0] ; GLOBAL DynamicBulletLifeTime%
006684D40  mov      x2, xzr
006684D44  sub      x20, x27, x20
006684D48  ldr      x1, [x8]
006684D4C  bl       #0x6b3bc94 ; HotFix.Common.AttributeData$$GetAttributeValue
006684D50  add      x8, x0, #0x10, lsl #12
006684D54  mul      x8, x8, x21
006684D58  mov      x0, x19
006684D5C  cmp      x20, x8, asr #16
006684D60  b.ge     #0x6684d80
006684D64  bl       #0x6682530 ; HotFix.BattleLogic.EntityBullet$$get_IgnoreDisCheck
006684D68  tbnz     w0, #0, #0x6684b98
006684D6C  ldr      x1, [x26]
006684D70  ldrb     w8, [x1, #0x53]
006684D74  tbnz     w8, #5, #0x6684e9c
006684D78  ldr      x0, [x19, #0x38]
006684D7C  b        #0x6684ea8 ; 
006684D80  bl       #0x6682598 ; HotFix.BattleLogic.EntityBullet$$get_IsLaserStickBullet
006684D84  tbz      w0, #0, #0x6684dd0
006684D88  ldrb     w8, [x19, #0xf0]
006684D8C  cbnz     w8, #0x6684dd0
006684D90  mov      x0, x19
006684D94  bl       #0x6682910 ; HotFix.BattleLogic.EntityBullet$$HasLaserStickExtraLifetimeSkill
006684D98  tbz      w0, #0, #0x6684dd0
006684D9C  mov      w20, #1
006684DA0  strb     w20, [x19, #0xf0]
006684DA4  ldrb     w8, [x24, #0xa4b]
006684DA8  cbnz     w8, #0x6684dbc
006684DAC  adrp     x0, #0x8ee5000
006684DB0  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006684DB4  bl       #0x382bd14 ; 
006684DB8  strb     w20, [x24, #0xa4b]
006684DBC  ldr      x1, [x25]
006684DC0  ldrb     w8, [x1, #0x53]
006684DC4  tbnz     w8, #5, #0x6684fcc
006684DC8  ldr      x8, [x19, #0x20]
006684DCC  b        #0x6684fdc ; 
006684DD0  ldrb     w8, [x19, #0xf0]
006684DD4  cbz      w8, #0x6684f40
006684DD8  mov      x0, x19
006684DDC  bl       #0x6680c30 ; HotFix.BattleLogic.EntityBullet$$get_OwnerEntity
006684DE0  cbz      x0, #0x6684ff0
006684DE4  adrp     x21, #0x959a000
006684DE8  ldrb     w8, [x21, #0xc5]
006684DEC  mov      x20, x0
006684DF0  cbnz     w8, #0x6684e08
006684DF4  adrp     x0, #0x8f10000
006684DF8  ldr      x0, [x0, #0x1f0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_LaserStickExtraLifetimeDuration()
006684DFC  bl       #0x382bd14 ; 
006684E00  mov      w8, #1
006684E04  strb     w8, [x21, #0xc5]
006684E08  adrp     x8, #0x8f10000
006684E0C  ldr      x8, [x8, #0x1f0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_LaserStickExtraLifetimeDuration()
006684E10  ldr      x1, [x8]
006684E14  ldrb     w8, [x1, #0x53]
006684E18  tbnz     w8, #5, #0x6684e24
006684E1C  ldr      x20, [x20, #0x148]
006684E20  b        #0x6684e34 ; 
006684E24  ldr      x8, [x1, #0x60]
006684E28  mov      x0, x20
006684E2C  blr      x8
006684E30  mov      x20, x0
006684E34  ldrb     w8, [x24, #0xa4b]
006684E38  cbnz     w8, #0x6684e50
006684E3C  adrp     x0, #0x8ee5000
006684E40  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006684E44  bl       #0x382bd14 ; 
006684E48  mov      w8, #1
006684E4C  strb     w8, [x24, #0xa4b]
006684E50  ldr      x1, [x25]
006684E54  ldrb     w8, [x1, #0x53]
006684E58  tbnz     w8, #5, #0x6684e64
006684E5C  ldr      x0, [x19, #0x20]
006684E60  b        #0x6684e70 ; 
006684E64  ldr      x8, [x1, #0x60]
006684E68  mov      x0, x19
006684E6C  blr      x8
006684E70  cbz      x0, #0x6684ff0
006684E74  ldr      x8, [x0, #0x128]
006684E78  ldr      x9, [x19, #0xe8]
006684E7C  ldr      x10, [x23, #0x28]
006684E80  ldr      x11, [sp, #0x78]
006684E84  sub      x8, x8, x9
006684E88  cmp      x8, x20
006684E8C  cset     w0, ge
006684E90  cmp      x10, x11
006684E94  b.eq     #0x6684f54
006684E98  bl       #0x89edb60 ; 
006684E9C  ldr      x8, [x1, #0x60]
006684EA0  mov      x0, x19
006684EA4  blr      x8
006684EA8  cbz      x0, #0x6684ff0
006684EAC  add      x8, sp, #0x60
006684EB0  mov      x1, xzr
006684EB4  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006684EB8  ldr      x1, [x26]
006684EBC  ldr      x21, [sp, #0x60]
006684EC0  ldr      x20, [sp, #0x70]
006684EC4  ldrb     w8, [x1, #0x53]
006684EC8  tbnz     w8, #5, #0x6684ed4
006684ECC  ldr      x0, [x19, #0x38]
006684ED0  b        #0x6684ee0 ; 
006684ED4  ldr      x8, [x1, #0x60]
006684ED8  mov      x0, x19
006684EDC  blr      x8
006684EE0  cbz      x0, #0x6684ff0
006684EE4  ldr      x8, [x19, #0xa0]
006684EE8  ldr      q0, [x19, #0x90]
006684EEC  ldr      x22, [x0, #0x260]
006684EF0  add      x0, sp, #0x18
006684EF4  mov      x1, sp
006684EF8  mov      x2, xzr
006684EFC  stp      x21, xzr, [sp, #0x18]
006684F00  str      x8, [sp, #0x10]
006684F04  str      q0, [sp]
006684F08  str      x20, [sp, #0x28]
006684F0C  bl       #0x7d5077c ; Photon.Deterministic.FPVector3$$DistanceSquared
006684F10  mul      x8, x22, x22
006684F14  cmp      x0, x8, asr #16
006684F18  b.lt     #0x6684b98
006684F1C  mov      w1, #0x400000
006684F20  mov      x0, x19
006684F24  bl       #0x6681fc4 ; HotFix.BattleLogic.EntityBullet$$HaveBulletFlag
006684F28  tbz      w0, #0, #0x6684f40
006684F2C  ldr      x1, [x26]
006684F30  ldrb     w8, [x1, #0x53]
006684F34  tbnz     w8, #5, #0x6684f74
006684F38  ldr      x20, [x19, #0x38]
006684F3C  b        #0x6684f84 ; 
006684F40  mov      w0, #1
006684F44  ldr      x8, [x23, #0x28]
006684F48  ldr      x9, [sp, #0x78]
006684F4C  cmp      x8, x9
006684F50  b.ne     #0x6684e98
006684F54  ldp      x20, x19, [sp, #0xd0]
006684F58  ldp      x22, x21, [sp, #0xc0]
006684F5C  ldp      x24, x23, [sp, #0xb0]
006684F60  ldp      x26, x25, [sp, #0xa0]
006684F64  ldp      x28, x27, [sp, #0x90]
006684F68  ldp      x29, x30, [sp, #0x80]
006684F6C  add      sp, sp, #0xe0
006684F70  ret      
006684F74  ldr      x8, [x1, #0x60]
006684F78  mov      x0, x19
006684F7C  blr      x8
006684F80  mov      x20, x0
006684F84  cbz      x20, #0x6684ff0
006684F88  adrp     x22, #0x8ee8000
006684F8C  ldr      x22, [x22, #0x898] ; GLOBAL LocalModels.Const_TypeInfo
006684F90  ldr      x21, [x20, #0x288]
006684F94  ldr      x0, [x22]
006684F98  ldr      w8, [x0, #0xe0]
006684F9C  cbnz     w8, #0x6684fa8
006684FA0  bl       #0x382be8c ; 
006684FA4  ldr      x0, [x22]
006684FA8  ldr      x8, [x0, #0xb8]
006684FAC  mov      w1, #0x200
006684FB0  mov      x0, x19
006684FB4  ldr      x8, [x8, #0x270]
006684FB8  mul      x8, x8, x21
006684FBC  asr      x8, x8, #0x10
006684FC0  str      x8, [x20, #0x288]
006684FC4  bl       #0x6684ff4 ; HotFix.BattleLogic.EntityBullet$$AddBulletFlag
006684FC8  b        #0x6684b98 ; 
006684FCC  ldr      x8, [x1, #0x60]
006684FD0  mov      x0, x19
006684FD4  blr      x8
006684FD8  mov      x8, x0
006684FDC  cbz      x8, #0x6684ff0
006684FE0  ldr      x8, [x8, #0x128]
006684FE4  mov      w0, wzr
006684FE8  str      x8, [x19, #0xe8]
006684FEC  b        #0x6684f44 ; 
006684FF0  bl       #0x382bfb8 ; 

