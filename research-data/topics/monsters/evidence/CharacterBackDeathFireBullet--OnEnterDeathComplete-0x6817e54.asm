; HotFix.BattleLogic.CharacterBackDeathFireBullet$$OnEnterDeathComplete
; RVA 0x6817E54; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006817E54  sub      sp, sp, #0x70
006817E58  stp      x30, x23, [sp, #0x40]
006817E5C  stp      x22, x21, [sp, #0x50]
006817E60  stp      x20, x19, [sp, #0x60]
006817E64  mrs      x20, tpidr_el0
006817E68  ldr      x8, [x20, #0x28]
006817E6C  adrp     x21, #0x959b000
006817E70  adrp     x22, #0x8f21000
006817E74  mov      x19, x0
006817E78  str      x8, [sp, #0x38]
006817E7C  ldrb     w8, [x21, #0x5fa]
006817E80  ldr      x22, [x22, #0xad0] ; GLOBAL Method$HotFix.BattleLogic.CharacterBackDeathFireBullet.OnEnterDeathComplete()
006817E84  tbnz     w8, #0, #0x6817ee4
006817E88  adrp     x0, #0x8f21000
006817E8C  ldr      x0, [x0, #0xad0] ; GLOBAL Method$HotFix.BattleLogic.CharacterBackDeathFireBullet.OnEnterDeathComplete()
006817E90  bl       #0x382bd14 ; 
006817E94  adrp     x0, #0x8f21000
006817E98  ldr      x0, [x0, #0xab8] ; GLOBAL HotFix.BattleLogic.CharacterBackDeathFireBullet.DieBulletData_TypeInfo
006817E9C  bl       #0x382bd14 ; 
006817EA0  adrp     x0, #0x8ee6000
006817EA4  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
006817EA8  bl       #0x382bd14 ; 
006817EAC  adrp     x0, #0x8ee1000
006817EB0  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo
006817EB4  bl       #0x382bd14 ; 
006817EB8  adrp     x0, #0x8f21000
006817EBC  ldr      x0, [x0, #0xad8] ; GLOBAL OnEnterDeathComplete
006817EC0  bl       #0x382bd14 ; 
006817EC4  adrp     x0, #0x8f21000
006817EC8  ldr      x0, [x0, #0xae0] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityCharacter\Death\CharacterBackDeathFireBullet.cs
006817ECC  bl       #0x382bd14 ; 
006817ED0  adrp     x0, #0x8f21000
006817ED4  ldr      x0, [x0, #0xae8] ; GLOBAL 死亡后生成子弹的武器ID为0
006817ED8  bl       #0x382bd14 ; 
006817EDC  mov      w8, #1
006817EE0  strb     w8, [x21, #0x5fa]
006817EE4  ldr      x1, [x22]
006817EE8  ldrb     w8, [x1, #0x53]
006817EEC  tbnz     w8, #5, #0x6817f6c
006817EF0  ldr      x0, [x19, #0x80]
006817EF4  cbz      x0, #0x681805c
006817EF8  adrp     x9, #0x8f21000
006817EFC  ldr      x9, [x9, #0xab8] ; GLOBAL HotFix.BattleLogic.CharacterBackDeathFireBullet.DieBulletData_TypeInfo
006817F00  ldr      x8, [x0]
006817F04  ldr      x1, [x9]
006817F08  ldrb     w10, [x8, #0x130]
006817F0C  ldrb     w9, [x1, #0x130]
006817F10  cmp      w10, w9
006817F14  b.lo     #0x6818060
006817F18  ldr      x8, [x8, #0xc8]
006817F1C  add      x8, x8, x9, lsl #3
006817F20  ldur     x8, [x8, #-8]
006817F24  cmp      x8, x1
006817F28  b.ne     #0x6818060
006817F2C  ldr      w1, [x0, #0x28]
006817F30  cbz      w1, #0x6817f7c
006817F34  ldr      x0, [x19, #0x38]
006817F38  cbz      x0, #0x681805c
006817F3C  mov      w2, wzr
006817F40  mov      x3, xzr
006817F44  bl       #0x67fcf20 ; HotFix.BattleLogic.EntityCharacter$$ChangeWeapon
006817F48  ldr      x19, [x19, #0x38]
006817F4C  cbz      x19, #0x681805c
006817F50  adrp     x8, #0x8ee6000
006817F54  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
006817F58  ldr      x1, [x8]
006817F5C  ldrb     w8, [x1, #0x53]
006817F60  tbnz     w8, #5, #0x6817fc8
006817F64  ldr      x0, [x19, #0x38]
006817F68  b        #0x6817fd4 ; 
006817F6C  ldr      x8, [x1, #0x60]
006817F70  mov      x0, x19
006817F74  blr      x8
006817F78  b        #0x6818038 ; 
006817F7C  adrp     x8, #0x8ee1000
006817F80  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
006817F84  ldr      x0, [x8]
006817F88  ldr      w8, [x0, #0xe0]
006817F8C  cbnz     w8, #0x6817f94
006817F90  bl       #0x382be8c ; 
006817F94  adrp     x8, #0x8f21000
006817F98  adrp     x9, #0x8f21000
006817F9C  adrp     x10, #0x8f21000
006817FA0  ldr      x8, [x8, #0xae8] ; GLOBAL 死亡后生成子弹的武器ID为0
006817FA4  ldr      x9, [x9, #0xad8] ; GLOBAL OnEnterDeathComplete
006817FA8  ldr      x10, [x10, #0xae0] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\EntityCharacter\Death\CharacterBackDeathFireBullet.cs
006817FAC  mov      w3, #0x25
006817FB0  ldr      x0, [x8]
006817FB4  ldr      x1, [x9]
006817FB8  ldr      x2, [x10]
006817FBC  mov      x4, xzr
006817FC0  bl       #0x7997754 ; Logger$$LogError
006817FC4  b        #0x6818038 ; 
006817FC8  ldr      x8, [x1, #0x60]
006817FCC  mov      x0, x19
006817FD0  blr      x8
006817FD4  cbz      x0, #0x681805c
006817FD8  add      x8, sp, #0x20
006817FDC  mov      x1, xzr
006817FE0  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006817FE4  ldp      x21, x22, [sp, #0x20]
006817FE8  ldr      x23, [sp, #0x30]
006817FEC  add      x0, sp, #0x20
006817FF0  mov      w2, #0x8000
006817FF4  mov      x1, xzr
006817FF8  mov      x3, xzr
006817FFC  mov      x4, xzr
006818000  stp      xzr, xzr, [sp, #0x20]
006818004  str      xzr, [sp, #0x30]
006818008  bl       #0x7d4dde4 ; Photon.Deterministic.FPVector3$$.ctor
00681800C  ldp      x8, x9, [sp, #0x20]
006818010  ldr      x10, [sp, #0x30]
006818014  add      x1, sp, #8
006818018  mov      x0, x19
00681801C  add      x8, x8, x21
006818020  add      x9, x9, x22
006818024  add      x10, x10, x23
006818028  mov      x2, xzr
00681802C  stp      x8, x9, [sp, #8]
006818030  str      x10, [sp, #0x18]
006818034  bl       #0x68006e4 ; HotFix.BattleLogic.EntityCharacter$$FireNow
006818038  ldr      x8, [x20, #0x28]
00681803C  ldr      x9, [sp, #0x38]
006818040  cmp      x8, x9
006818044  b.ne     #0x6818064
006818048  ldp      x20, x19, [sp, #0x60]
00681804C  ldp      x22, x21, [sp, #0x50]
006818050  ldp      x30, x23, [sp, #0x40]
006818054  add      sp, sp, #0x70
006818058  ret      
00681805C  bl       #0x382bfb8 ; 
006818060  bl       #0x382c354 ; 
006818064  bl       #0x89edb60 ; 

