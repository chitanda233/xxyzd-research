; HotFix.BattleLogic.AICommonBoss$$InitWeapons
; RVA 0x6563D2C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006563D2C  sub      sp, sp, #0x80
006563D30  stp      x29, x30, [sp, #0x20]
006563D34  stp      x28, x27, [sp, #0x30]
006563D38  stp      x26, x25, [sp, #0x40]
006563D3C  stp      x24, x23, [sp, #0x50]
006563D40  stp      x22, x21, [sp, #0x60]
006563D44  stp      x20, x19, [sp, #0x70]
006563D48  adrp     x20, #0x9598000
006563D4C  adrp     x21, #0x8f06000
006563D50  ldrb     w8, [x20, #0xf83]
006563D54  ldr      x21, [x21, #0x798] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss.InitWeapons()
006563D58  mov      x19, x0
006563D5C  tbnz     w8, #0, #0x6563dec
006563D60  adrp     x0, #0x8f06000
006563D64  ldr      x0, [x0, #0x798] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss.InitWeapons()
006563D68  bl       #0x382bd14 ; 
006563D6C  adrp     x0, #0x8ee6000
006563D70  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
006563D74  bl       #0x382bd14 ; 
006563D78  adrp     x0, #0x8ee2000
006563D7C  ldr      x0, [x0, #0xe10] ; GLOBAL Photon.Deterministic.FP[]_TypeInfo
006563D80  bl       #0x382bd14 ; 
006563D84  adrp     x0, #0x8ec1000
006563D88  ldr      x0, [x0, #0x240] ; GLOBAL int[]_TypeInfo
006563D8C  bl       #0x382bd14 ; 
006563D90  adrp     x0, #0x8ebf000
006563D94  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo
006563D98  bl       #0x382bd14 ; 
006563D9C  adrp     x0, #0x8ee1000
006563DA0  ldr      x0, [x0, #0x6e8] ; GLOBAL Logger_TypeInfo
006563DA4  bl       #0x382bd14 ; 
006563DA8  adrp     x0, #0x8f06000
006563DAC  ldr      x0, [x0, #0x430] ; GLOBAL HotFix.BattleLogic.WeaponInfo[]_TypeInfo
006563DB0  bl       #0x382bd14 ; 
006563DB4  adrp     x0, #0x8f06000
006563DB8  ldr      x0, [x0, #0x7a0] ; GLOBAL InitWeapons
006563DBC  bl       #0x382bd14 ; 
006563DC0  adrp     x0, #0x8f06000
006563DC4  ldr      x0, [x0, #0x7a8] ; GLOBAL [AICommonBoss] weaponMeta = null where weaponId = {0}
006563DC8  bl       #0x382bd14 ; 
006563DCC  adrp     x0, #0x8f06000
006563DD0  ldr      x0, [x0, #0x7b0] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\AISTG\Boss\AICommonBoss.cs
006563DD4  bl       #0x382bd14 ; 
006563DD8  adrp     x0, #0x8f06000
006563DDC  ldr      x0, [x0, #0x7b8] ; GLOBAL [AICommonBoss] animationId = 0 where weaponId = {0}
006563DE0  bl       #0x382bd14 ; 
006563DE4  mov      w8, #1
006563DE8  strb     w8, [x20, #0xf83]
006563DEC  ldr      x1, [x21]
006563DF0  ldrb     w8, [x1, #0x53]
006563DF4  tbnz     w8, #5, #0x6563e1c
006563DF8  ldr      x0, [x19, #0x58]
006563DFC  cbz      x0, #0x65645c8
006563E00  adrp     x8, #0x8ee6000
006563E04  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
006563E08  ldr      x1, [x8]
006563E0C  ldrb     w8, [x1, #0x53]
006563E10  tbnz     w8, #5, #0x6563e44
006563E14  ldr      x20, [x0, #0x38]
006563E18  b        #0x6563e50 ; 
006563E1C  ldr      x2, [x1, #0x60]
006563E20  mov      x0, x19
006563E24  ldp      x20, x19, [sp, #0x70]
006563E28  ldp      x22, x21, [sp, #0x60]
006563E2C  ldp      x24, x23, [sp, #0x50]
006563E30  ldp      x26, x25, [sp, #0x40]
006563E34  ldp      x28, x27, [sp, #0x30]
006563E38  ldp      x29, x30, [sp, #0x20]
006563E3C  add      sp, sp, #0x80
006563E40  br       x2
006563E44  ldr      x8, [x1, #0x60]
006563E48  blr      x8
006563E4C  mov      x20, x0
006563E50  cbz      x20, #0x65645c8
006563E54  adrp     x21, #0x9591000
006563E58  ldrb     w8, [x21, #0xa74]
006563E5C  cbnz     w8, #0x6563e74
006563E60  adrp     x0, #0x8ee6000
006563E64  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006563E68  bl       #0x382bd14 ; 
006563E6C  mov      w8, #1
006563E70  strb     w8, [x21, #0xa74]
006563E74  adrp     x8, #0x8ee6000
006563E78  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006563E7C  ldr      x1, [x8]
006563E80  ldrb     w8, [x1, #0x53]
006563E84  tbnz     w8, #5, #0x6563e90
006563E88  ldr      x21, [x20, #0x170]
006563E8C  b        #0x6563ea0 ; 
006563E90  ldr      x8, [x1, #0x60]
006563E94  mov      x0, x20
006563E98  blr      x8
006563E9C  mov      x21, x0
006563EA0  cbz      x21, #0x65645c8
006563EA4  adrp     x8, #0x9598000
006563EA8  ldrb     w8, [x8, #0xfbd]
006563EAC  cbnz     w8, #0x6563ec8
006563EB0  adrp     x0, #0x8f05000
006563EB4  ldr      x0, [x0, #0xc50] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WeaponID()
006563EB8  bl       #0x382bd14 ; 
006563EBC  mov      w8, #1
006563EC0  adrp     x9, #0x9598000
006563EC4  strb     w8, [x9, #0xfbd]
006563EC8  adrp     x22, #0x8f05000
006563ECC  ldr      x22, [x22, #0xc50] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WeaponID()
006563ED0  ldr      x1, [x22]
006563ED4  ldrb     w8, [x1, #0x53]
006563ED8  tbnz     w8, #5, #0x6563ee4
006563EDC  ldr      x0, [x21, #0x90]
006563EE0  b        #0x6563ef0 ; 
006563EE4  ldr      x8, [x1, #0x60]
006563EE8  mov      x0, x21
006563EEC  blr      x8
006563EF0  cbz      x0, #0x65645c8
006563EF4  mov      x9, x19
006563EF8  ldr      x20, [x0, #0x18]
006563EFC  ldr      x8, [x9, #0x78]!
006563F00  str      x9, [sp, #8]
006563F04  cbz      x8, #0x6563f14
006563F08  ldr      w8, [x8, #0x18]
006563F0C  cmp      w8, w20
006563F10  b.eq     #0x6563f38
006563F14  adrp     x8, #0x8f06000
006563F18  ldr      x8, [x8, #0x430] ; GLOBAL HotFix.BattleLogic.WeaponInfo[]_TypeInfo
006563F1C  mov      w1, w20
006563F20  ldr      x0, [x8]
006563F24  bl       #0x382bdfc ; 
006563F28  mov      x1, x0
006563F2C  ldr      x0, [sp, #8]
006563F30  str      x1, [x0]
006563F34  bl       #0x382bcb8 ; 
006563F38  cmp      w20, #1
006563F3C  and      x8, x20, #0xffffffff
006563F40  str      x20, [sp]
006563F44  str      x8, [sp, #0x10]
006563F48  b.lt     #0x65641c0
006563F4C  adrp     x25, #0x8ee5000
006563F50  adrp     x26, #0x8f06000
006563F54  ldr      x25, [x25, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006563F58  ldr      x26, [x26, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table()
006563F5C  mov      x24, xzr
006563F60  mov      w23, #1
006563F64  adrp     x27, #0x9591000
006563F68  adrp     x20, #0x9598000
006563F6C  adrp     x8, #0x9598000
006563F70  ldrb     w8, [x8, #0xfbd]
006563F74  cbnz     w8, #0x6563f88
006563F78  mov      x0, x22
006563F7C  bl       #0x382bd14 ; 
006563F80  adrp     x8, #0x9598000
006563F84  strb     w23, [x8, #0xfbd]
006563F88  ldr      x1, [x22]
006563F8C  ldrb     w8, [x1, #0x53]
006563F90  tbnz     w8, #5, #0x6563f9c
006563F94  ldr      x0, [x21, #0x90]
006563F98  b        #0x6563fa8 ; 
006563F9C  ldr      x8, [x1, #0x60]
006563FA0  mov      x0, x21
006563FA4  blr      x8
006563FA8  cbz      x0, #0x65645c8
006563FAC  ldr      w8, [x0, #0x18]
006563FB0  cmp      x24, x8
006563FB4  b.hs     #0x65645cc
006563FB8  ldr      x29, [x19, #0x58]
006563FBC  cbz      x29, #0x65645c8
006563FC0  add      x8, x0, x24, lsl #2
006563FC4  ldrb     w9, [x27, #0xa4b]
006563FC8  ldr      w28, [x8, #0x20]
006563FCC  cbnz     w9, #0x6563fdc
006563FD0  mov      x0, x25
006563FD4  bl       #0x382bd14 ; 
006563FD8  strb     w23, [x27, #0xa4b]
006563FDC  ldr      x1, [x25]
006563FE0  ldrb     w8, [x1, #0x53]
006563FE4  tbnz     w8, #5, #0x6563ff0
006563FE8  ldr      x29, [x29, #0x20]
006563FEC  b        #0x6564000 ; 
006563FF0  ldr      x8, [x1, #0x60]
006563FF4  mov      x0, x29
006563FF8  blr      x8
006563FFC  mov      x29, x0
006564000  cbz      x29, #0x65645c8
006564004  ldrb     w8, [x20, #0xfcc]
006564008  cbnz     w8, #0x6564018
00656400C  mov      x0, x26
006564010  bl       #0x382bd14 ; 
006564014  strb     w23, [x20, #0xfcc]
006564018  ldr      x1, [x26]
00656401C  ldrb     w8, [x1, #0x53]
006564020  tbnz     w8, #5, #0x656402c
006564024  ldr      x0, [x29, #0x200]
006564028  b        #0x6564038 ; 
00656402C  ldr      x8, [x1, #0x60]
006564030  mov      x0, x29
006564034  blr      x8
006564038  cbz      x0, #0x65645c8
00656403C  mov      w1, w28
006564040  mov      x2, xzr
006564044  bl       #0x64e4e24 ; LocalModels.LocalModelManager$$GetWeapon_Weapon
006564048  cbz      x0, #0x65640c0
00656404C  adrp     x8, #0x9598000
006564050  ldrb     w8, [x8, #0xfce]
006564054  mov      x29, x0
006564058  cbnz     w8, #0x6564070
00656405C  adrp     x0, #0x8f06000
006564060  ldr      x0, [x0, #0x7c0] ; GLOBAL Method$LocalModels.Bean.Weapon_Weapon.get_animationId()
006564064  bl       #0x382bd14 ; 
006564068  adrp     x8, #0x9598000
00656406C  strb     w23, [x8, #0xfce]
006564070  adrp     x8, #0x8f06000
006564074  ldr      x8, [x8, #0x7c0] ; GLOBAL Method$LocalModels.Bean.Weapon_Weapon.get_animationId()
006564078  ldr      x1, [x8]
00656407C  ldrb     w8, [x1, #0x53]
006564080  tbnz     w8, #5, #0x6564124
006564084  ldr      w0, [x29, #0x4c]
006564088  cbz      w0, #0x6564134
00656408C  ldr      x8, [sp, #8]
006564090  mov      x0, x21
006564094  mov      w1, w24
006564098  mov      x2, xzr
00656409C  ldr      x28, [x8]
0065640A0  bl       #0x691f768 ; HotFix.BattleLogic.GameUtils$$GetWeaponInfo
0065640A4  cbz      x28, #0x65645c8
0065640A8  ldr      w8, [x28, #0x18]
0065640AC  cmp      x24, x8
0065640B0  b.hs     #0x65645cc
0065640B4  add      x8, x28, x24, lsl #3
0065640B8  str      x0, [x8, #0x20]
0065640BC  b        #0x65641b0 ; 
0065640C0  adrp     x8, #0x8ebf000
0065640C4  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo
0065640C8  add      x1, sp, #0x1c
0065640CC  str      w28, [sp, #0x1c]
0065640D0  ldr      x0, [x8]
0065640D4  bl       #0x382be94 ; 
0065640D8  adrp     x8, #0x8f06000
0065640DC  ldr      x8, [x8, #0x7a8] ; GLOBAL [AICommonBoss] weaponMeta = null where weaponId = {0}
0065640E0  mov      x1, x0
0065640E4  mov      x2, xzr
0065640E8  ldr      x8, [x8]
0065640EC  mov      x0, x8
0065640F0  bl       #0x79d140c ; System.String$$Format
0065640F4  adrp     x8, #0x8ee1000
0065640F8  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
0065640FC  mov      x28, x0
006564100  ldr      x8, [x8]
006564104  ldr      w9, [x8, #0xe0]
006564108  cbnz     w9, #0x6564114
00656410C  mov      x0, x8
006564110  bl       #0x382be8c ; 
006564114  adrp     x8, #0x8f06000
006564118  ldr      x8, [x8, #0x7a0] ; GLOBAL InitWeapons
00656411C  mov      w3, #0x8e
006564120  b        #0x6564194 ; 
006564124  ldr      x8, [x1, #0x60]
006564128  mov      x0, x29
00656412C  blr      x8
006564130  cbnz     w0, #0x656408c
006564134  adrp     x8, #0x8ebf000
006564138  ldr      x8, [x8, #0xba0] ; GLOBAL int_TypeInfo
00656413C  add      x1, sp, #0x18
006564140  str      w28, [sp, #0x18]
006564144  ldr      x0, [x8]
006564148  bl       #0x382be94 ; 
00656414C  adrp     x8, #0x8f06000
006564150  ldr      x8, [x8, #0x7b8] ; GLOBAL [AICommonBoss] animationId = 0 where weaponId = {0}
006564154  mov      x1, x0
006564158  mov      x2, xzr
00656415C  ldr      x8, [x8]
006564160  mov      x0, x8
006564164  bl       #0x79d140c ; System.String$$Format
006564168  adrp     x8, #0x8ee1000
00656416C  ldr      x8, [x8, #0x6e8] ; GLOBAL Logger_TypeInfo
006564170  mov      x28, x0
006564174  ldr      x8, [x8]
006564178  ldr      w9, [x8, #0xe0]
00656417C  cbnz     w9, #0x6564188
006564180  mov      x0, x8
006564184  bl       #0x382be8c ; 
006564188  adrp     x8, #0x8f06000
00656418C  ldr      x8, [x8, #0x7a0] ; GLOBAL InitWeapons
006564190  mov      w3, #0x93
006564194  ldr      x1, [x8]
006564198  adrp     x8, #0x8f06000
00656419C  ldr      x8, [x8, #0x7b0] ; GLOBAL D:\jenkins\workspace\prod_android_package_cn\UnityProject\Assets\HotFixBattle\Runtime\Battle\AISTG\Boss\AICommonBoss.cs
0065641A0  ldr      x2, [x8]
0065641A4  mov      x0, x28
0065641A8  mov      x4, xzr
0065641AC  bl       #0x7997754 ; Logger$$LogError
0065641B0  ldr      x8, [sp, #0x10]
0065641B4  add      x24, x24, #1
0065641B8  cmp      x8, x24
0065641BC  b.ne     #0x6563f6c
0065641C0  ldr      x21, [x19, #0x118]
0065641C4  str      wzr, [x19, #0x80]
0065641C8  str      wzr, [x19, #0x128]
0065641CC  cbz      x21, #0x65645c8
0065641D0  mov      x22, x21
0065641D4  ldr      x8, [x22, #0x20]!
0065641D8  cbnz     x8, #0x6564208
0065641DC  adrp     x8, #0x8ee2000
0065641E0  ldr      x8, [x8, #0xe10] ; GLOBAL Photon.Deterministic.FP[]_TypeInfo
0065641E4  mov      w1, wzr
0065641E8  ldr      x0, [x8]
0065641EC  bl       #0x382bdfc ; 
0065641F0  mov      x1, x0
0065641F4  str      x0, [x22]
0065641F8  mov      x0, x22
0065641FC  bl       #0x382bcb8 ; 
006564200  ldr      x21, [x19, #0x118]
006564204  cbz      x21, #0x65645c8
006564208  mov      x22, x21
00656420C  ldr      x8, [x22, #0x28]!
006564210  cbnz     x8, #0x6564240
006564214  adrp     x8, #0x8ec1000
006564218  ldr      x8, [x8, #0x240] ; GLOBAL int[]_TypeInfo
00656421C  mov      w1, wzr
006564220  ldr      x0, [x8]
006564224  bl       #0x382bdfc ; 
006564228  mov      x1, x0
00656422C  str      x0, [x22]
006564230  mov      x0, x22
006564234  bl       #0x382bcb8 ; 
006564238  ldr      x21, [x19, #0x118]
00656423C  cbz      x21, #0x65645c8
006564240  mov      x22, x21
006564244  ldr      x8, [x22, #0x30]!
006564248  ldr      x25, [sp]
00656424C  cbnz     x8, #0x656427c
006564250  adrp     x8, #0x8ee2000
006564254  ldr      x8, [x8, #0xe10] ; GLOBAL Photon.Deterministic.FP[]_TypeInfo
006564258  mov      w1, wzr
00656425C  ldr      x0, [x8]
006564260  bl       #0x382bdfc ; 
006564264  mov      x1, x0
006564268  str      x0, [x22]
00656426C  mov      x0, x22
006564270  bl       #0x382bcb8 ; 
006564274  ldr      x21, [x19, #0x118]
006564278  cbz      x21, #0x65645c8
00656427C  mov      x22, x21
006564280  ldr      x8, [x22, #0x18]!
006564284  cbnz     x8, #0x65642b4
006564288  adrp     x8, #0x8ee2000
00656428C  ldr      x8, [x8, #0xe10] ; GLOBAL Photon.Deterministic.FP[]_TypeInfo
006564290  mov      w1, wzr
006564294  ldr      x0, [x8]
006564298  bl       #0x382bdfc ; 
00656429C  mov      x1, x0
0065642A0  str      x0, [x22]
0065642A4  mov      x0, x22
0065642A8  bl       #0x382bcb8 ; 
0065642AC  ldr      x21, [x19, #0x118]
0065642B0  cbz      x21, #0x65645c8
0065642B4  mov      x22, x21
0065642B8  ldr      x8, [x22, #0x10]!
0065642BC  cbnz     x8, #0x65642ec
0065642C0  adrp     x8, #0x8ee2000
0065642C4  ldr      x8, [x8, #0xe10] ; GLOBAL Photon.Deterministic.FP[]_TypeInfo
0065642C8  mov      w1, wzr
0065642CC  ldr      x0, [x8]
0065642D0  bl       #0x382bdfc ; 
0065642D4  mov      x1, x0
0065642D8  str      x0, [x22]
0065642DC  mov      x0, x22
0065642E0  bl       #0x382bcb8 ; 
0065642E4  ldr      x21, [x19, #0x118]
0065642E8  cbz      x21, #0x65645c8
0065642EC  ldr      x8, [x21, #0x20]
0065642F0  cbz      x8, #0x65645c8
0065642F4  ldr      w8, [x8, #0x18]
0065642F8  cmp      w8, w25
0065642FC  b.ne     #0x656433c
006564300  ldr      x8, [x21, #0x28]
006564304  cbz      x8, #0x65645c8
006564308  ldr      w8, [x8, #0x18]
00656430C  cmp      w8, w25
006564310  b.ne     #0x656433c
006564314  ldr      x8, [x21, #0x10]
006564318  cbz      x8, #0x65645c8
00656431C  ldr      w8, [x8, #0x18]
006564320  cmp      w8, w25
006564324  b.ne     #0x656433c
006564328  ldr      x8, [x21, #0x18]
00656432C  cbz      x8, #0x65645c8
006564330  ldr      w8, [x8, #0x18]
006564334  cmp      w8, w25
006564338  b.eq     #0x656454c
00656433C  adrp     x20, #0x8ee2000
006564340  ldr      x20, [x20, #0xe10] ; GLOBAL Photon.Deterministic.FP[]_TypeInfo
006564344  mov      w1, w25
006564348  ldr      x0, [x20]
00656434C  bl       #0x382bdfc ; 
006564350  adrp     x8, #0x8ec1000
006564354  ldr      x8, [x8, #0x240] ; GLOBAL int[]_TypeInfo
006564358  mov      x24, x0
00656435C  mov      w1, w25
006564360  ldr      x8, [x8]
006564364  mov      x0, x8
006564368  bl       #0x382bdfc ; 
00656436C  ldr      x8, [x20]
006564370  mov      x23, x0
006564374  mov      w1, w25
006564378  mov      x0, x8
00656437C  bl       #0x382bdfc ; 
006564380  ldr      x8, [x20]
006564384  mov      x22, x0
006564388  mov      w1, w25
00656438C  mov      x0, x8
006564390  bl       #0x382bdfc ; 
006564394  ldr      x3, [x19, #0x118]
006564398  cbz      x3, #0x65645c8
00656439C  mov      x21, x0
0065643A0  add      x16, x0, #0x20
0065643A4  ldr      x0, [sp, #0x10]
0065643A8  cmp      w25, #0
0065643AC  mov      x8, xzr
0065643B0  add      x9, x19, #0x128
0065643B4  add      x10, x19, #0x120
0065643B8  add      x11, x19, #0x130
0065643BC  add      x12, x19, #0x138
0065643C0  add      x13, x24, #0x20
0065643C4  add      x14, x23, #0x20
0065643C8  add      x15, x22, #0x20
0065643CC  mov      w17, #0x20
0065643D0  csel     x1, x0, xzr, gt
0065643D4  mov      w2, #0x20
0065643D8  cmp      x1, x8
0065643DC  add      x0, x3, #0x20
0065643E0  b.eq     #0x65644fc
0065643E4  ldr      x0, [x0]
0065643E8  cbz      x0, #0x65645c8
0065643EC  ldr      w4, [x0, #0x18]
0065643F0  mov      x3, x10
0065643F4  cmp      x8, w4, sxtw
0065643F8  b.ge     #0x6564408
0065643FC  cmp      x8, x4
006564400  b.hs     #0x65645cc
006564404  add      x3, x0, x2
006564408  cbz      x24, #0x65645c8
00656440C  ldr      w0, [x24, #0x18]
006564410  cmp      x8, x0
006564414  b.hs     #0x65645cc
006564418  ldr      x0, [x3]
00656441C  str      x0, [x13, x8, lsl #3]
006564420  ldr      x0, [x19, #0x118]
006564424  cbz      x0, #0x65645c8
006564428  ldr      x3, [x0, #0x28]
00656442C  cbz      x3, #0x65645c8
006564430  ldr      w5, [x3, #0x18]
006564434  mov      x4, x9
006564438  cmp      x8, w5, sxtw
00656443C  b.ge     #0x656444c
006564440  cmp      x8, x5
006564444  b.hs     #0x65645cc
006564448  add      x4, x3, x17
00656444C  cbz      x23, #0x65645c8
006564450  ldr      w3, [x23, #0x18]
006564454  cmp      x8, x3
006564458  b.hs     #0x65645cc
00656445C  ldr      w3, [x4]
006564460  str      w3, [x14, x8, lsl #2]
006564464  ldr      x0, [x0, #0x10]
006564468  cbz      x0, #0x65645c8
00656446C  ldr      w4, [x0, #0x18]
006564470  mov      x3, x11
006564474  cmp      x8, w4, sxtw
006564478  b.ge     #0x6564488
00656447C  cmp      x8, x4
006564480  b.hs     #0x65645cc
006564484  add      x3, x0, x2
006564488  cbz      x22, #0x65645c8
00656448C  ldr      w0, [x22, #0x18]
006564490  cmp      x8, x0
006564494  b.hs     #0x65645cc
006564498  ldr      x0, [x3]
00656449C  str      x0, [x15, x8, lsl #3]
0065644A0  ldr      x0, [x19, #0x118]
0065644A4  cbz      x0, #0x65645c8
0065644A8  ldr      x0, [x0, #0x18]
0065644AC  cbz      x0, #0x65645c8
0065644B0  ldr      w4, [x0, #0x18]
0065644B4  mov      x3, x12
0065644B8  cmp      x8, w4, sxtw
0065644BC  b.ge     #0x65644cc
0065644C0  cmp      x8, x4
0065644C4  b.hs     #0x65645cc
0065644C8  add      x3, x0, x2
0065644CC  cbz      x21, #0x65645c8
0065644D0  ldr      w0, [x21, #0x18]
0065644D4  cmp      x8, x0
0065644D8  b.hs     #0x65645cc
0065644DC  ldr      x0, [x3]
0065644E0  add      x2, x2, #8
0065644E4  add      x17, x17, #4
0065644E8  str      x0, [x16, x8, lsl #3]
0065644EC  ldr      x3, [x19, #0x118]
0065644F0  add      x8, x8, #1
0065644F4  cbnz     x3, #0x65643d8
0065644F8  b        #0x65645c8 ; 
0065644FC  mov      x1, x24
006564500  str      x24, [x0]
006564504  bl       #0x382bcb8 ; 
006564508  ldr      x0, [x19, #0x118]
00656450C  cbz      x0, #0x65645c8
006564510  str      x23, [x0, #0x28]!
006564514  mov      x1, x23
006564518  bl       #0x382bcb8 ; 
00656451C  ldr      x0, [x19, #0x118]
006564520  cbz      x0, #0x65645c8
006564524  str      x22, [x0, #0x10]!
006564528  mov      x1, x22
00656452C  bl       #0x382bcb8 ; 
006564530  ldr      x0, [x19, #0x118]
006564534  cbz      x0, #0x65645c8
006564538  str      x21, [x0, #0x18]!
00656453C  mov      x1, x21
006564540  bl       #0x382bcb8 ; 
006564544  ldr      x21, [x19, #0x118]
006564548  cbz      x21, #0x65645c8
00656454C  ldr      x8, [x21, #0x30]!
006564550  cbz      x8, #0x65645c8
006564554  ldr      w8, [x8, #0x18]
006564558  cmp      w8, #1
00656455C  b.gt     #0x65645a8
006564560  adrp     x8, #0x8ee2000
006564564  ldr      x8, [x8, #0xe10] ; GLOBAL Photon.Deterministic.FP[]_TypeInfo
006564568  mov      w1, #2
00656456C  ldr      x0, [x8]
006564570  bl       #0x382bdfc ; 
006564574  cbz      x0, #0x65645c8
006564578  ldr      w8, [x0, #0x18]
00656457C  mov      x1, x0
006564580  cbz      w8, #0x65645cc
006564584  ldr      x9, [x19, #0x140]
006564588  cmp      w8, #1
00656458C  str      x9, [x1, #0x20]
006564590  b.eq     #0x65645cc
006564594  ldr      x8, [x19, #0x140]
006564598  mov      x0, x21
00656459C  str      x8, [x1, #0x28]
0065645A0  str      x1, [x21]
0065645A4  bl       #0x382bcb8 ; 
0065645A8  ldp      x20, x19, [sp, #0x70]
0065645AC  ldp      x22, x21, [sp, #0x60]
0065645B0  ldp      x24, x23, [sp, #0x50]
0065645B4  ldp      x26, x25, [sp, #0x40]
0065645B8  ldp      x28, x27, [sp, #0x30]
0065645BC  ldp      x29, x30, [sp, #0x20]
0065645C0  add      sp, sp, #0x80
0065645C4  ret      
0065645C8  bl       #0x382bfb8 ; 
0065645CC  bl       #0x382bfc0 ; 

