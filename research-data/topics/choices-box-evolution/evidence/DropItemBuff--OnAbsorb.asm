; HotFix.BattleLogic.DropItemBuff$$OnAbsorb
; RVA 0x6660A14; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006660A14  sub      sp, sp, #0x50
006660A18  stp      x30, x25, [sp, #0x10]
006660A1C  stp      x24, x23, [sp, #0x20]
006660A20  stp      x22, x21, [sp, #0x30]
006660A24  stp      x20, x19, [sp, #0x40]
006660A28  adrp     x20, #0x9599000
006660A2C  adrp     x21, #0x8f0f000
006660A30  ldrb     w8, [x20, #0xd37]
006660A34  ldr      x21, [x21, #0x38] ; GLOBAL Method$HotFix.BattleLogic.DropItemBuff.OnAbsorb() @ 0x925fb78
006660A38  mov      x19, x0
006660A3C  tbnz     w8, #0, #0x6660a6c
006660A40  adrp     x0, #0x8f0f000
006660A44  ldr      x0, [x0, #0x38] ; GLOBAL Method$HotFix.BattleLogic.DropItemBuff.OnAbsorb() @ 0x925fb78
006660A48  bl       #0x382bd14 ; 
006660A4C  adrp     x0, #0x8ee6000
006660A50  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006660A54  bl       #0x382bd14 ; 
006660A58  adrp     x0, #0x8f0f000
006660A5C  ldr      x0, [x0, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
006660A60  bl       #0x382bd14 ; 
006660A64  mov      w8, #1
006660A68  strb     w8, [x20, #0xd37]
006660A6C  ldr      x1, [x21]
006660A70  ldrb     w8, [x1, #0x53]
006660A74  tbnz     w8, #5, #0x6660ab4
006660A78  adrp     x22, #0x9591000
006660A7C  ldrb     w8, [x22, #0xa4b]
006660A80  cbnz     w8, #0x6660a98
006660A84  adrp     x0, #0x8ee5000
006660A88  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006660A8C  bl       #0x382bd14 ; 
006660A90  mov      w8, #1
006660A94  strb     w8, [x22, #0xa4b]
006660A98  adrp     x24, #0x8ee5000
006660A9C  ldr      x24, [x24, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006660AA0  ldr      x1, [x24]
006660AA4  ldrb     w8, [x1, #0x53]
006660AA8  tbnz     w8, #5, #0x6660ad4
006660AAC  ldr      x20, [x19, #0x20]
006660AB0  b        #0x6660ae4 ; 
006660AB4  ldr      x2, [x1, #0x60]
006660AB8  mov      x0, x19
006660ABC  ldp      x20, x19, [sp, #0x40]
006660AC0  ldp      x22, x21, [sp, #0x30]
006660AC4  ldp      x24, x23, [sp, #0x20]
006660AC8  ldp      x30, x25, [sp, #0x10]
006660ACC  add      sp, sp, #0x50
006660AD0  br       x2
006660AD4  ldr      x8, [x1, #0x60]
006660AD8  mov      x0, x19
006660ADC  blr      x8
006660AE0  mov      x20, x0
006660AE4  adrp     x23, #0x8f0f000
006660AE8  ldr      x23, [x23, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
006660AEC  ldr      x1, [x23]
006660AF0  ldrb     w8, [x1, #0x53]
006660AF4  tbnz     w8, #5, #0x6660b00
006660AF8  ldr      x0, [x19, #0x38]
006660AFC  b        #0x6660b0c ; 
006660B00  ldr      x8, [x1, #0x60]
006660B04  mov      x0, x19
006660B08  blr      x8
006660B0C  cbz      x0, #0x6660e80
006660B10  ldr      x21, [x0, #0x78]
006660B14  cbz      x21, #0x6660e80
006660B18  adrp     x25, #0x9599000
006660B1C  ldrb     w8, [x25, #0xebb]
006660B20  cbnz     w8, #0x6660b38
006660B24  adrp     x0, #0x8f0f000
006660B28  ldr      x0, [x0, #0x40] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_collectSoundId() @ 0x9285d70
006660B2C  bl       #0x382bd14 ; 
006660B30  mov      w8, #1
006660B34  strb     w8, [x25, #0xebb]
006660B38  adrp     x8, #0x8f0f000
006660B3C  ldr      x8, [x8, #0x40] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_collectSoundId() @ 0x9285d70
006660B40  ldr      x1, [x8]
006660B44  ldrb     w8, [x1, #0x53]
006660B48  tbnz     w8, #5, #0x6660b54
006660B4C  ldr      w1, [x21, #0x60]
006660B50  b        #0x6660b64 ; 
006660B54  ldr      x8, [x1, #0x60]
006660B58  mov      x0, x21
006660B5C  blr      x8
006660B60  mov      w1, w0
006660B64  cbz      x20, #0x6660e80
006660B68  mov      x0, x20
006660B6C  mov      x2, xzr
006660B70  bl       #0x6a074b4 ; HotFix.BattleLogic.BattleWorldContext$$PlaySound
006660B74  ldrb     w8, [x22, #0xa4b]
006660B78  cbnz     w8, #0x6660b90
006660B7C  adrp     x0, #0x8ee5000
006660B80  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006660B84  bl       #0x382bd14 ; 
006660B88  mov      w8, #1
006660B8C  strb     w8, [x22, #0xa4b]
006660B90  ldr      x1, [x24]
006660B94  ldrb     w8, [x1, #0x53]
006660B98  tbnz     w8, #5, #0x6660ba4
006660B9C  ldr      x20, [x19, #0x20]
006660BA0  b        #0x6660bb4 ; 
006660BA4  ldr      x8, [x1, #0x60]
006660BA8  mov      x0, x19
006660BAC  blr      x8
006660BB0  mov      x20, x0
006660BB4  cbz      x20, #0x6660e80
006660BB8  adrp     x21, #0x9591000
006660BBC  ldrb     w8, [x21, #0xa62]
006660BC0  cbnz     w8, #0x6660bd8
006660BC4  adrp     x0, #0x8ee6000
006660BC8  ldr      x0, [x0, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
006660BCC  bl       #0x382bd14 ; 
006660BD0  mov      w8, #1
006660BD4  strb     w8, [x21, #0xa62]
006660BD8  adrp     x8, #0x8ee6000
006660BDC  ldr      x8, [x8, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
006660BE0  ldr      x1, [x8]
006660BE4  ldrb     w8, [x1, #0x53]
006660BE8  tbnz     w8, #5, #0x6660bf4
006660BEC  ldr      x20, [x20, #0x1f8]
006660BF0  b        #0x6660c04 ; 
006660BF4  ldr      x8, [x1, #0x60]
006660BF8  mov      x0, x20
006660BFC  blr      x8
006660C00  mov      x20, x0
006660C04  ldr      x1, [x23]
006660C08  ldrb     w8, [x1, #0x53]
006660C0C  tbnz     w8, #5, #0x6660c18
006660C10  ldr      x0, [x19, #0x38]
006660C14  b        #0x6660c24 ; 
006660C18  ldr      x8, [x1, #0x60]
006660C1C  mov      x0, x19
006660C20  blr      x8
006660C24  cbz      x0, #0x6660e80
006660C28  cbz      x20, #0x6660e80
006660C2C  ldr      w1, [x0, #0x80]
006660C30  mov      x0, x20
006660C34  mov      x2, xzr
006660C38  bl       #0x688052c ; HotFix.BattleLogic.EntityManager$$GetPlayer
006660C3C  cbz      x0, #0x6660e68
006660C40  ldr      x1, [x23]
006660C44  mov      x20, x0
006660C48  ldrb     w8, [x1, #0x53]
006660C4C  tbnz     w8, #5, #0x6660c58
006660C50  ldr      x0, [x19, #0x38]
006660C54  b        #0x6660c64 ; 
006660C58  ldr      x8, [x1, #0x60]
006660C5C  mov      x0, x19
006660C60  blr      x8
006660C64  cbz      x0, #0x6660e80
006660C68  ldr      x21, [x0, #0x78]
006660C6C  cbz      x21, #0x6660e80
006660C70  adrp     x25, #0x9598000
006660C74  ldrb     w8, [x25, #0xd61]
006660C78  cbnz     w8, #0x6660c90
006660C7C  adrp     x0, #0x8eff000
006660C80  ldr      x0, [x0, #0x538] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_id() @ 0x9285d88
006660C84  bl       #0x382bd14 ; 
006660C88  mov      w8, #1
006660C8C  strb     w8, [x25, #0xd61]
006660C90  adrp     x8, #0x8eff000
006660C94  ldr      x8, [x8, #0x538] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_id() @ 0x9285d88
006660C98  ldr      x1, [x8]
006660C9C  ldrb     w8, [x1, #0x53]
006660CA0  tbnz     w8, #5, #0x6660cac
006660CA4  ldr      w1, [x21, #0x20]
006660CA8  b        #0x6660cbc ; 
006660CAC  ldr      x8, [x1, #0x60]
006660CB0  mov      x0, x21
006660CB4  blr      x8
006660CB8  mov      w1, w0
006660CBC  ldr      x8, [x20]
006660CC0  mov      x0, x20
006660CC4  ldr      x9, [x8, #0x578]
006660CC8  ldr      x2, [x8, #0x580]
006660CCC  blr      x9
006660CD0  ldrb     w8, [x22, #0xa4b]
006660CD4  cbnz     w8, #0x6660cec
006660CD8  adrp     x0, #0x8ee5000
006660CDC  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
006660CE0  bl       #0x382bd14 ; 
006660CE4  mov      w8, #1
006660CE8  strb     w8, [x22, #0xa4b]
006660CEC  ldr      x1, [x24]
006660CF0  ldrb     w8, [x1, #0x53]
006660CF4  tbnz     w8, #5, #0x6660d00
006660CF8  ldr      x21, [x19, #0x20]
006660CFC  b        #0x6660d10 ; 
006660D00  ldr      x8, [x1, #0x60]
006660D04  mov      x0, x19
006660D08  blr      x8
006660D0C  mov      x21, x0
006660D10  adrp     x8, #0x8ee6000
006660D14  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006660D18  ldr      x1, [x8]
006660D1C  ldrb     w8, [x1, #0x53]
006660D20  tbnz     w8, #5, #0x6660d2c
006660D24  ldr      x22, [x20, #0x38]
006660D28  b        #0x6660d3c ; 
006660D2C  ldr      x8, [x1, #0x60]
006660D30  mov      x0, x20
006660D34  blr      x8
006660D38  mov      x22, x0
006660D3C  cbz      x22, #0x6660e80
006660D40  adrp     x24, #0x9591000
006660D44  ldrb     w8, [x24, #0xa7f]
006660D48  cbnz     w8, #0x6660d60
006660D4C  adrp     x0, #0x8ee6000
006660D50  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006660D54  bl       #0x382bd14 ; 
006660D58  mov      w8, #1
006660D5C  strb     w8, [x24, #0xa7f]
006660D60  adrp     x8, #0x8ee6000
006660D64  ldr      x8, [x8, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Attribute() @ 0x9263310
006660D68  ldr      x1, [x8]
006660D6C  ldrb     w8, [x1, #0x53]
006660D70  tbnz     w8, #5, #0x6660d7c
006660D74  ldr      x22, [x22, #0x178]
006660D78  b        #0x6660d8c ; 
006660D7C  ldr      x8, [x1, #0x60]
006660D80  mov      x0, x22
006660D84  blr      x8
006660D88  mov      x22, x0
006660D8C  ldr      x1, [x23]
006660D90  ldrb     w8, [x1, #0x53]
006660D94  tbnz     w8, #5, #0x6660da0
006660D98  ldr      x0, [x19, #0x38]
006660D9C  b        #0x6660dac ; 
006660DA0  ldr      x8, [x1, #0x60]
006660DA4  mov      x0, x19
006660DA8  blr      x8
006660DAC  cbz      x0, #0x6660e80
006660DB0  ldr      x23, [x0, #0x78]
006660DB4  cbz      x23, #0x6660e80
006660DB8  adrp     x24, #0x9599000
006660DBC  ldrb     w8, [x24, #0xebc]
006660DC0  cbnz     w8, #0x6660dd8
006660DC4  adrp     x0, #0x8f0f000
006660DC8  ldr      x0, [x0, #0x48] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_parameter() @ 0x9285d98
006660DCC  bl       #0x382bd14 ; 
006660DD0  mov      w8, #1
006660DD4  strb     w8, [x24, #0xebc]
006660DD8  adrp     x8, #0x8f0f000
006660DDC  ldr      x8, [x8, #0x48] ; GLOBAL Method$LocalModels.Bean.Item_battle.get_parameter() @ 0x9285d98
006660DE0  ldr      x1, [x8]
006660DE4  ldrb     w8, [x1, #0x53]
006660DE8  tbnz     w8, #5, #0x6660df4
006660DEC  ldr      w4, [x23, #0x28]
006660DF0  b        #0x6660e04 ; 
006660DF4  ldr      x8, [x1, #0x60]
006660DF8  mov      x0, x23
006660DFC  blr      x8
006660E00  mov      w4, w0
006660E04  cbz      x21, #0x6660e80
006660E08  mov      w5, #0x10000
006660E0C  mov      x0, x21
006660E10  mov      x1, x20
006660E14  mov      x2, x22
006660E18  mov      x3, x20
006660E1C  mov      w6, wzr
006660E20  mov      w7, wzr
006660E24  str      xzr, [sp]
006660E28  bl       #0x6a0d17c ; HotFix.BattleLogic.BattleWorldContext$$AddBuffToEntity
006660E2C  ldr      x8, [x19]
006660E30  mov      x0, x19
006660E34  mov      x1, x20
006660E38  ldr      x9, [x8, #0x368]
006660E3C  ldr      x2, [x8, #0x370]
006660E40  blr      x9
006660E44  ldr      x8, [x19]
006660E48  mov      w2, #3
006660E4C  mov      x0, x19
006660E50  mov      x1, x20
006660E54  ldr      x9, [x8, #0x378]
006660E58  ldr      x3, [x8, #0x380]
006660E5C  blr      x9
006660E60  mov      w8, #1
006660E64  strb     w8, [x19, #0xf0]
006660E68  ldp      x20, x19, [sp, #0x40]
006660E6C  ldp      x22, x21, [sp, #0x30]
006660E70  ldp      x24, x23, [sp, #0x20]
006660E74  ldp      x30, x25, [sp, #0x10]
006660E78  add      sp, sp, #0x50
006660E7C  ret      
006660E80  bl       #0x382bfb8 ; 

