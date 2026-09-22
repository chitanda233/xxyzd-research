; HotFix.BattleLogic.AICommonBoss$$onRandomAI
; RVA 0x6564B48; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006564B48  stp      x30, x27, [sp, #-0x50]!
006564B4C  stp      x26, x25, [sp, #0x10]
006564B50  stp      x24, x23, [sp, #0x20]
006564B54  stp      x22, x21, [sp, #0x30]
006564B58  stp      x20, x19, [sp, #0x40]
006564B5C  adrp     x21, #0x9598000
006564B60  adrp     x22, #0x8f06000
006564B64  ldrb     w8, [x21, #0xf8d]
006564B68  ldr      x22, [x22, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss.onRandomAI()
006564B6C  mov      w20, w1
006564B70  mov      x19, x0
006564B74  tbnz     w8, #0, #0x6564ba4
006564B78  adrp     x0, #0x8f06000
006564B7C  ldr      x0, [x0, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss.onRandomAI()
006564B80  bl       #0x382bd14 ; 
006564B84  adrp     x0, #0x8ee2000
006564B88  ldr      x0, [x0, #0xe10] ; GLOBAL Photon.Deterministic.FP[]_TypeInfo
006564B8C  bl       #0x382bd14 ; 
006564B90  adrp     x0, #0x8f06000
006564B94  ldr      x0, [x0, #0x818] ; GLOBAL laser
006564B98  bl       #0x382bd14 ; 
006564B9C  mov      w8, #1
006564BA0  strb     w8, [x21, #0xf8d]
006564BA4  ldr      x2, [x22]
006564BA8  ldrb     w8, [x2, #0x53]
006564BAC  tbnz     w8, #5, #0x6564c38
006564BB0  ldr      x8, [x19, #0x78]
006564BB4  cbz      x8, #0x6564f10
006564BB8  ldr      w9, [x8, #0x18]
006564BBC  cmp      w9, w20
006564BC0  b.ls     #0x6564f14
006564BC4  ldr      x9, [x19, #0x118]
006564BC8  cbz      x9, #0x6564f10
006564BCC  ldr      x9, [x9, #0x28]
006564BD0  cbz      x9, #0x6564f10
006564BD4  ldr      w10, [x9, #0x18]
006564BD8  cmp      w10, w20
006564BDC  b.ls     #0x6564f14
006564BE0  ldr      x23, [x19, #0x58]
006564BE4  cbz      x23, #0x6564f10
006564BE8  sxtw     x25, w20
006564BEC  adrp     x26, #0x9591000
006564BF0  add      x8, x8, x25, lsl #3
006564BF4  add      x9, x9, x25, lsl #2
006564BF8  ldrb     w10, [x26, #0xa4b]
006564BFC  ldr      x22, [x8, #0x20]
006564C00  ldr      w21, [x9, #0x20]
006564C04  cbnz     w10, #0x6564c1c
006564C08  adrp     x0, #0x8ee5000
006564C0C  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006564C10  bl       #0x382bd14 ; 
006564C14  mov      w8, #1
006564C18  strb     w8, [x26, #0xa4b]
006564C1C  adrp     x27, #0x8ee5000
006564C20  ldr      x27, [x27, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006564C24  ldr      x1, [x27]
006564C28  ldrb     w8, [x1, #0x53]
006564C2C  tbnz     w8, #5, #0x6564c5c
006564C30  ldr      x23, [x23, #0x20]
006564C34  b        #0x6564c6c ; 
006564C38  ldr      x3, [x2, #0x60]
006564C3C  mov      x0, x19
006564C40  mov      w1, w20
006564C44  ldp      x20, x19, [sp, #0x40]
006564C48  ldp      x22, x21, [sp, #0x30]
006564C4C  ldp      x24, x23, [sp, #0x20]
006564C50  ldp      x26, x25, [sp, #0x10]
006564C54  ldp      x30, x27, [sp], #0x50
006564C58  br       x3
006564C5C  ldr      x8, [x1, #0x60]
006564C60  mov      x0, x23
006564C64  blr      x8
006564C68  mov      x23, x0
006564C6C  cbz      x23, #0x6564f10
006564C70  adrp     x24, #0x9598000
006564C74  ldrb     w8, [x24, #0xfcc]
006564C78  cbnz     w8, #0x6564c90
006564C7C  adrp     x0, #0x8f06000
006564C80  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
006564C84  bl       #0x382bd14 ; 
006564C88  mov      w8, #1
006564C8C  strb     w8, [x24, #0xfcc]
006564C90  adrp     x8, #0x8f06000
006564C94  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
006564C98  ldr      x1, [x8]
006564C9C  ldrb     w8, [x1, #0x53]
006564CA0  tbnz     w8, #5, #0x6564cac
006564CA4  ldr      x0, [x23, #0x200]
006564CA8  b        #0x6564cb8 ; 
006564CAC  ldr      x8, [x1, #0x60]
006564CB0  mov      x0, x23
006564CB4  blr      x8
006564CB8  cbz      x0, #0x6564f10
006564CBC  mov      w1, w22
006564CC0  mov      x2, xzr
006564CC4  bl       #0x64e4e24 ; LocalModels.LocalModelManager$$GetWeapon_Weapon
006564CC8  ldr      x24, [x19, #0x58]
006564CCC  cbz      x24, #0x6564f10
006564CD0  ldrb     w8, [x26, #0xa4b]
006564CD4  mov      x23, x0
006564CD8  cbnz     w8, #0x6564cf0
006564CDC  adrp     x0, #0x8ee5000
006564CE0  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006564CE4  bl       #0x382bd14 ; 
006564CE8  mov      w8, #1
006564CEC  strb     w8, [x26, #0xa4b]
006564CF0  ldr      x1, [x27]
006564CF4  ldrb     w8, [x1, #0x53]
006564CF8  tbnz     w8, #5, #0x6564d04
006564CFC  ldr      x0, [x24, #0x20]
006564D00  b        #0x6564d10 ; 
006564D04  ldr      x8, [x1, #0x60]
006564D08  mov      x0, x24
006564D0C  blr      x8
006564D10  ldr      x8, [x19, #0x118]
006564D14  cbz      x8, #0x6564f10
006564D18  ldr      x8, [x8, #0x30]
006564D1C  cbz      x8, #0x6564f10
006564D20  ldr      w9, [x8, #0x18]
006564D24  cbz      w9, #0x6564f14
006564D28  cmp      w9, #1
006564D2C  b.eq     #0x6564f14
006564D30  cbz      x0, #0x6564f10
006564D34  ldp      x1, x2, [x8, #0x20]
006564D38  mov      x3, xzr
006564D3C  bl       #0x563860c ; 
006564D40  cbz      x23, #0x6564f10
006564D44  adrp     x26, #0x9598000
006564D48  ldrb     w8, [x26, #0xfcf]
006564D4C  mov      x24, x0
006564D50  cbnz     w8, #0x6564d68
006564D54  adrp     x0, #0x8f06000
006564D58  ldr      x0, [x0, #0x820] ; GLOBAL Method$LocalModels.Bean.Weapon_Weapon.get_Trajectory()
006564D5C  bl       #0x382bd14 ; 
006564D60  mov      w8, #1
006564D64  strb     w8, [x26, #0xfcf]
006564D68  adrp     x8, #0x8f06000
006564D6C  ldr      x8, [x8, #0x820] ; GLOBAL Method$LocalModels.Bean.Weapon_Weapon.get_Trajectory()
006564D70  ldr      x1, [x8]
006564D74  ldrb     w8, [x1, #0x53]
006564D78  tbnz     w8, #5, #0x6564d84
006564D7C  ldr      x0, [x23, #0x78]
006564D80  b        #0x6564d90 ; 
006564D84  ldr      x8, [x1, #0x60]
006564D88  mov      x0, x23
006564D8C  blr      x8
006564D90  cbz      x0, #0x6564f10
006564D94  mov      x1, xzr
006564D98  bl       #0x79e65c8 ; System.String$$ToLower
006564D9C  cbz      x0, #0x6564f10
006564DA0  adrp     x8, #0x8f06000
006564DA4  ldr      x8, [x8, #0x818] ; GLOBAL laser
006564DA8  mov      x2, xzr
006564DAC  ldr      x1, [x8]
006564DB0  bl       #0x79e6d18 ; System.String$$Contains
006564DB4  tbz      w0, #0, #0x6564e6c
006564DB8  adrp     x8, #0x8ee2000
006564DBC  ldrb     w26, [x19, #0x180]
006564DC0  ldr      x8, [x8, #0xe10] ; GLOBAL Photon.Deterministic.FP[]_TypeInfo
006564DC4  mov      w1, #2
006564DC8  ldr      x0, [x8]
006564DCC  bl       #0x382bdfc ; 
006564DD0  ldr      x8, [x19, #0x118]
006564DD4  cbz      x8, #0x6564f10
006564DD8  ldr      x9, [x8, #0x10]
006564DDC  cbz      x9, #0x6564f10
006564DE0  ldr      w8, [x9, #0x18]
006564DE4  cmp      w8, w20
006564DE8  b.ls     #0x6564f14
006564DEC  mov      x6, x0
006564DF0  cbz      x0, #0x6564f10
006564DF4  ldr      w8, [x6, #0x18]
006564DF8  cbz      w8, #0x6564f14
006564DFC  add      x9, x9, x25, lsl #3
006564E00  ldr      x9, [x9, #0x20]
006564E04  str      x9, [x6, #0x20]
006564E08  ldr      x9, [x19, #0x118]
006564E0C  cbz      x9, #0x6564f10
006564E10  ldr      x9, [x9, #0x18]
006564E14  cbz      x9, #0x6564f10
006564E18  ldr      w10, [x9, #0x18]
006564E1C  cmp      w10, w20
006564E20  b.ls     #0x6564f14
006564E24  cmp      w8, #1
006564E28  b.ls     #0x6564f14
006564E2C  add      x8, x9, x25, lsl #3
006564E30  ldr      x8, [x8, #0x20]
006564E34  cmp      w26, #0
006564E38  mov      x0, x19
006564E3C  mov      x1, x22
006564E40  mov      w2, w21
006564E44  mov      x3, x24
006564E48  mov      x4, x23
006564E4C  ldp      x20, x19, [sp, #0x40]
006564E50  ldp      x22, x21, [sp, #0x30]
006564E54  ldp      x24, x23, [sp, #0x20]
006564E58  ldp      x26, x25, [sp, #0x10]
006564E5C  cset     w5, ne
006564E60  str      x8, [x6, #0x28]
006564E64  ldp      x30, x27, [sp], #0x50
006564E68  b        #0x65653b8 ; HotFix.BattleLogic.AICommonBoss$$onLaser
006564E6C  adrp     x8, #0x8ee2000
006564E70  ldr      x8, [x8, #0xe10] ; GLOBAL Photon.Deterministic.FP[]_TypeInfo
006564E74  mov      w1, #2
006564E78  ldr      x0, [x8]
006564E7C  bl       #0x382bdfc ; 
006564E80  ldr      x8, [x19, #0x118]
006564E84  cbz      x8, #0x6564f10
006564E88  ldr      x9, [x8, #0x10]
006564E8C  cbz      x9, #0x6564f10
006564E90  ldr      w8, [x9, #0x18]
006564E94  cmp      w8, w20
006564E98  b.ls     #0x6564f14
006564E9C  mov      x4, x0
006564EA0  cbz      x0, #0x6564f10
006564EA4  ldr      w8, [x4, #0x18]
006564EA8  cbz      w8, #0x6564f14
006564EAC  add      x9, x9, x25, lsl #3
006564EB0  ldr      x9, [x9, #0x20]
006564EB4  str      x9, [x4, #0x20]
006564EB8  ldr      x9, [x19, #0x118]
006564EBC  cbz      x9, #0x6564f10
006564EC0  ldr      x9, [x9, #0x18]
006564EC4  cbz      x9, #0x6564f10
006564EC8  ldr      w10, [x9, #0x18]
006564ECC  cmp      w10, w20
006564ED0  b.ls     #0x6564f14
006564ED4  cmp      w8, #1
006564ED8  b.ls     #0x6564f14
006564EDC  add      x8, x9, x25, lsl #3
006564EE0  ldr      x8, [x8, #0x20]
006564EE4  mov      x0, x19
006564EE8  mov      x1, x22
006564EEC  mov      w2, w21
006564EF0  mov      x3, x24
006564EF4  ldp      x20, x19, [sp, #0x40]
006564EF8  ldp      x22, x21, [sp, #0x30]
006564EFC  ldp      x24, x23, [sp, #0x20]
006564F00  ldp      x26, x25, [sp, #0x10]
006564F04  str      x8, [x4, #0x28]
006564F08  ldp      x30, x27, [sp], #0x50
006564F0C  b        #0x6565834 ; HotFix.BattleLogic.AICommonBoss$$onCommon
006564F10  bl       #0x382bfb8 ; 
006564F14  bl       #0x382bfc0 ; 

