; HotFix.BattleLogic.DropItemTrigger$$OnAbsorb
; RVA 0x6669BE0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006669BE0  sub      sp, sp, #0x50
006669BE4  stp      x30, x25, [sp, #0x10]
006669BE8  stp      x24, x23, [sp, #0x20]
006669BEC  stp      x22, x21, [sp, #0x30]
006669BF0  stp      x20, x19, [sp, #0x40]
006669BF4  adrp     x20, #0x9599000
006669BF8  adrp     x21, #0x8f0f000
006669BFC  ldrb     w8, [x20, #0xd9b]
006669C00  ldr      x21, [x21, #0x460] ; GLOBAL Method$HotFix.BattleLogic.DropItemTrigger.OnAbsorb() @ 0x925ff18
006669C04  mov      x19, x0
006669C08  tbnz     w8, #0, #0x6669c38
006669C0C  adrp     x0, #0x8f0f000
006669C10  ldr      x0, [x0, #0x460] ; GLOBAL Method$HotFix.BattleLogic.DropItemTrigger.OnAbsorb() @ 0x925ff18
006669C14  bl       #0x382bd14 ; 
006669C18  adrp     x0, #0x8f0d000
006669C1C  ldr      x0, [x0, #0xad8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<CharacterComponentTrigger>() @ 0x92100e8
006669C20  bl       #0x382bd14 ; 
006669C24  adrp     x0, #0x8f0f000
006669C28  ldr      x0, [x0, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
006669C2C  bl       #0x382bd14 ; 
006669C30  mov      w8, #1
006669C34  strb     w8, [x20, #0xd9b]
006669C38  ldr      x1, [x21]
006669C3C  ldrb     w8, [x1, #0x53]
006669C40  tbnz     w8, #5, #0x6669c84
006669C44  adrp     x23, #0x9591000
006669C48  ldrb     w8, [x23, #0xa4b]
006669C4C  str      wzr, [sp, #0xc]
006669C50  cbnz     w8, #0x6669c68
006669C54  adrp     x0, #0x8ee5000
006669C58  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006669C5C  bl       #0x382bd14 ; 
006669C60  mov      w8, #1
006669C64  strb     w8, [x23, #0xa4b]
006669C68  adrp     x24, #0x8ee5000
006669C6C  ldr      x24, [x24, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006669C70  ldr      x1, [x24]
006669C74  ldrb     w8, [x1, #0x53]
006669C78  tbnz     w8, #5, #0x6669ca4
006669C7C  ldr      x20, [x19, #0x20]
006669C80  b        #0x6669cb4 ; 
006669C84  ldr      x2, [x1, #0x60]
006669C88  mov      x0, x19
006669C8C  ldp      x20, x19, [sp, #0x40]
006669C90  ldp      x22, x21, [sp, #0x30]
006669C94  ldp      x24, x23, [sp, #0x20]
006669C98  ldp      x30, x25, [sp, #0x10]
006669C9C  add      sp, sp, #0x50
006669CA0  br       x2
006669CA4  ldr      x8, [x1, #0x60]
006669CA8  mov      x0, x19
006669CAC  blr      x8
006669CB0  mov      x20, x0
006669CB4  adrp     x22, #0x8f0f000
006669CB8  ldr      x22, [x22, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
006669CBC  ldr      x1, [x22]
006669CC0  ldrb     w8, [x1, #0x53]
006669CC4  tbnz     w8, #5, #0x6669cd0
006669CC8  ldr      x0, [x19, #0x38]
006669CCC  b        #0x6669cdc ; 
006669CD0  ldr      x8, [x1, #0x60]
006669CD4  mov      x0, x19
006669CD8  blr      x8
006669CDC  cbz      x0, #0x6669f9c
006669CE0  ldr      x21, [x0, #0x78]
006669CE4  cbz      x21, #0x6669f9c
006669CE8  adrp     x25, #0x9599000
006669CEC  ldrb     w8, [x25, #0xebb]
006669CF0  cbnz     w8, #0x6669d08
006669CF4  adrp     x0, #0x8f0f000
006669CF8  ldr      x0, [x0, #0x40] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_collectSoundId() @ 0x9285d70
006669CFC  bl       #0x382bd14 ; 
006669D00  mov      w8, #1
006669D04  strb     w8, [x25, #0xebb]
006669D08  adrp     x8, #0x8f0f000
006669D0C  ldr      x8, [x8, #0x40] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_collectSoundId() @ 0x9285d70
006669D10  ldr      x1, [x8]
006669D14  ldrb     w8, [x1, #0x53]
006669D18  tbnz     w8, #5, #0x6669d24
006669D1C  ldr      w1, [x21, #0x60]
006669D20  b        #0x6669d34 ; 
006669D24  ldr      x8, [x1, #0x60]
006669D28  mov      x0, x21
006669D2C  blr      x8
006669D30  mov      w1, w0
006669D34  cbz      x20, #0x6669f9c
006669D38  mov      x0, x20
006669D3C  mov      x2, xzr
006669D40  bl       #0x6a074b4 ; HotFix.BattleLogic.BattleWorldContext$$PlaySound
006669D44  ldrb     w8, [x23, #0xa4b]
006669D48  cbnz     w8, #0x6669d60
006669D4C  adrp     x0, #0x8ee5000
006669D50  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006669D54  bl       #0x382bd14 ; 
006669D58  mov      w8, #1
006669D5C  strb     w8, [x23, #0xa4b]
006669D60  ldr      x1, [x24]
006669D64  ldrb     w8, [x1, #0x53]
006669D68  tbnz     w8, #5, #0x6669d74
006669D6C  ldr      x20, [x19, #0x20]
006669D70  b        #0x6669d84 ; 
006669D74  ldr      x8, [x1, #0x60]
006669D78  mov      x0, x19
006669D7C  blr      x8
006669D80  mov      x20, x0
006669D84  cbz      x20, #0x6669f9c
006669D88  adrp     x21, #0x9591000
006669D8C  ldrb     w8, [x21, #0xa62]
006669D90  cbnz     w8, #0x6669da8
006669D94  adrp     x0, #0x8ee6000
006669D98  ldr      x0, [x0, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
006669D9C  bl       #0x382bd14 ; 
006669DA0  mov      w8, #1
006669DA4  strb     w8, [x21, #0xa62]
006669DA8  adrp     x8, #0x8ee6000
006669DAC  ldr      x8, [x8, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
006669DB0  ldr      x1, [x8]
006669DB4  ldrb     w8, [x1, #0x53]
006669DB8  tbnz     w8, #5, #0x6669dc4
006669DBC  ldr      x20, [x20, #0x1f8]
006669DC0  b        #0x6669dd4 ; 
006669DC4  ldr      x8, [x1, #0x60]
006669DC8  mov      x0, x20
006669DCC  blr      x8
006669DD0  mov      x20, x0
006669DD4  ldr      x1, [x22]
006669DD8  ldrb     w8, [x1, #0x53]
006669DDC  tbnz     w8, #5, #0x6669de8
006669DE0  ldr      x0, [x19, #0x38]
006669DE4  b        #0x6669df4 ; 
006669DE8  ldr      x8, [x1, #0x60]
006669DEC  mov      x0, x19
006669DF0  blr      x8
006669DF4  cbz      x0, #0x6669f9c
006669DF8  cbz      x20, #0x6669f9c
006669DFC  ldr      w1, [x0, #0x80]
006669E00  mov      x0, x20
006669E04  mov      x2, xzr
006669E08  bl       #0x688052c ; HotFix.BattleLogic.EntityManager$$GetPlayer
006669E0C  cbz      x0, #0x6669f84
006669E10  ldr      x1, [x22]
006669E14  mov      x20, x0
006669E18  ldrb     w8, [x1, #0x53]
006669E1C  tbnz     w8, #5, #0x6669e28
006669E20  ldr      x0, [x19, #0x38]
006669E24  b        #0x6669e34 ; 
006669E28  ldr      x8, [x1, #0x60]
006669E2C  mov      x0, x19
006669E30  blr      x8
006669E34  cbz      x0, #0x6669f9c
006669E38  ldr      x21, [x0, #0x78]
006669E3C  cbz      x21, #0x6669f9c
006669E40  adrp     x23, #0x9598000
006669E44  ldrb     w8, [x23, #0xd61]
006669E48  cbnz     w8, #0x6669e60
006669E4C  adrp     x0, #0x8eff000
006669E50  ldr      x0, [x0, #0x538] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_id() @ 0x9285d88
006669E54  bl       #0x382bd14 ; 
006669E58  mov      w8, #1
006669E5C  strb     w8, [x23, #0xd61]
006669E60  adrp     x8, #0x8eff000
006669E64  ldr      x8, [x8, #0x538] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_id() @ 0x9285d88
006669E68  ldr      x1, [x8]
006669E6C  ldrb     w8, [x1, #0x53]
006669E70  tbnz     w8, #5, #0x6669e7c
006669E74  ldr      w1, [x21, #0x20]
006669E78  b        #0x6669e8c ; 
006669E7C  ldr      x8, [x1, #0x60]
006669E80  mov      x0, x21
006669E84  blr      x8
006669E88  mov      w1, w0
006669E8C  ldr      x8, [x20]
006669E90  mov      x0, x20
006669E94  ldr      x9, [x8, #0x578]
006669E98  ldr      x2, [x8, #0x580]
006669E9C  blr      x9
006669EA0  adrp     x8, #0x8f0d000
006669EA4  ldr      x8, [x8, #0xad8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<CharacterComponentTrigger>() @ 0x92100e8
006669EA8  mov      x0, x20
006669EAC  ldr      x1, [x8]
006669EB0  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
006669EB4  ldr      x1, [x22]
006669EB8  mov      x21, x0
006669EBC  ldrb     w8, [x1, #0x53]
006669EC0  tbnz     w8, #5, #0x6669ecc
006669EC4  ldr      x0, [x19, #0x38]
006669EC8  b        #0x6669ed8 ; 
006669ECC  ldr      x8, [x1, #0x60]
006669ED0  mov      x0, x19
006669ED4  blr      x8
006669ED8  cbz      x0, #0x6669f9c
006669EDC  ldr      x22, [x0, #0x78]
006669EE0  cbz      x22, #0x6669f9c
006669EE4  adrp     x23, #0x9599000
006669EE8  ldrb     w8, [x23, #0xebc]
006669EEC  cbnz     w8, #0x6669f04
006669EF0  adrp     x0, #0x8f0f000
006669EF4  ldr      x0, [x0, #0x48] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_parameter() @ 0x9285d98
006669EF8  bl       #0x382bd14 ; 
006669EFC  mov      w8, #1
006669F00  strb     w8, [x23, #0xebc]
006669F04  adrp     x8, #0x8f0f000
006669F08  ldr      x8, [x8, #0x48] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_parameter() @ 0x9285d98
006669F0C  ldr      x1, [x8]
006669F10  ldrb     w8, [x1, #0x53]
006669F14  tbnz     w8, #5, #0x6669f20
006669F18  ldr      w2, [x22, #0x28]
006669F1C  b        #0x6669f30 ; 
006669F20  ldr      x8, [x1, #0x60]
006669F24  mov      x0, x22
006669F28  blr      x8
006669F2C  mov      w2, w0
006669F30  cbz      x21, #0x6669f9c
006669F34  add      x3, sp, #0xc
006669F38  mov      x0, x21
006669F3C  mov      w1, wzr
006669F40  mov      x4, xzr
006669F44  bl       #0x672cd2c ; HotFix.BattleLogic.CharacterComponentTrigger$$AddTrigger
006669F48  ldr      x8, [x19]
006669F4C  mov      x0, x19
006669F50  mov      x1, x20
006669F54  ldr      x9, [x8, #0x368]
006669F58  ldr      x2, [x8, #0x370]
006669F5C  blr      x9
006669F60  ldr      x8, [x19]
006669F64  mov      w2, #3
006669F68  mov      x0, x19
006669F6C  mov      x1, x20
006669F70  ldr      x9, [x8, #0x378]
006669F74  ldr      x3, [x8, #0x380]
006669F78  blr      x9
006669F7C  mov      w8, #1
006669F80  strb     w8, [x19, #0xf0]
006669F84  ldp      x20, x19, [sp, #0x40]
006669F88  ldp      x22, x21, [sp, #0x30]
006669F8C  ldp      x24, x23, [sp, #0x20]
006669F90  ldp      x30, x25, [sp, #0x10]
006669F94  add      sp, sp, #0x50
006669F98  ret      
006669F9C  bl       #0x382bfb8 ; 

