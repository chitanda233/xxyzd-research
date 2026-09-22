; HotFix.BattleLogic.EntityCharacterData$$SetTableData
; RVA 0x6825978; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006825978  sub      sp, sp, #0x130
00682597C  stp      x29, x30, [sp, #0xe0]
006825980  stp      x26, x25, [sp, #0xf0]
006825984  stp      x24, x23, [sp, #0x100]
006825988  stp      x22, x21, [sp, #0x110]
00682598C  stp      x20, x19, [sp, #0x120]
006825990  mrs      x23, tpidr_el0
006825994  ldr      x8, [x23, #0x28]
006825998  adrp     x22, #0x959b000
00682599C  adrp     x24, #0x8f22000
0068259A0  mov      x20, x2
0068259A4  str      x8, [sp, #0xd8]
0068259A8  ldrb     w8, [x22, #0x6ec]
0068259AC  ldr      x24, [x24, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetTableData()
0068259B0  mov      x21, x1
0068259B4  mov      x19, x0
0068259B8  tbnz     w8, #0, #0x68259d0
0068259BC  adrp     x0, #0x8f22000
0068259C0  ldr      x0, [x0, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetTableData()
0068259C4  bl       #0x382bd14 ; 
0068259C8  mov      w8, #1
0068259CC  strb     w8, [x22, #0x6ec]
0068259D0  ldr      x3, [x24]
0068259D4  ldrb     w8, [x3, #0x53]
0068259D8  tbnz     w8, #5, #0x6825a18
0068259DC  adrp     x24, #0x9591000
0068259E0  ldrb     w8, [x24, #0xa74]
0068259E4  cbnz     w8, #0x68259fc
0068259E8  adrp     x0, #0x8ee6000
0068259EC  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068259F0  bl       #0x382bd14 ; 
0068259F4  mov      w8, #1
0068259F8  strb     w8, [x24, #0xa74]
0068259FC  adrp     x25, #0x8ee6000
006825A00  ldr      x25, [x25, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006825A04  ldr      x1, [x25]
006825A08  ldrb     w8, [x1, #0x53]
006825A0C  tbnz     w8, #5, #0x6825a30
006825A10  ldr      x0, [x19, #0x170]
006825A14  b        #0x6825a3c ; 
006825A18  ldr      x8, [x3, #0x60]
006825A1C  mov      x0, x19
006825A20  mov      x1, x21
006825A24  mov      x2, x20
006825A28  blr      x8
006825A2C  b        #0x6826144 ; 
006825A30  ldr      x8, [x1, #0x60]
006825A34  mov      x0, x19
006825A38  blr      x8
006825A3C  cbnz     x0, #0x682631c
006825A40  cbz      x21, #0x6826314
006825A44  adrp     x22, #0x9598000
006825A48  ldrb     w8, [x22, #0xcbd]
006825A4C  cbnz     w8, #0x6825a64
006825A50  adrp     x0, #0x8efd000
006825A54  ldr      x0, [x0, #0x600] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_ID()
006825A58  bl       #0x382bd14 ; 
006825A5C  mov      w8, #1
006825A60  strb     w8, [x22, #0xcbd]
006825A64  adrp     x8, #0x8efd000
006825A68  ldr      x8, [x8, #0x600] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_ID()
006825A6C  ldr      x1, [x8]
006825A70  ldrb     w8, [x1, #0x53]
006825A74  tbnz     w8, #5, #0x6825a80
006825A78  ldr      w22, [x21, #0x20]
006825A7C  b        #0x6825a90 ; 
006825A80  ldr      x8, [x1, #0x60]
006825A84  mov      x0, x21
006825A88  blr      x8
006825A8C  mov      w22, w0
006825A90  adrp     x26, #0x959b000
006825A94  ldrb     w8, [x26, #0x788]
006825A98  cbnz     w8, #0x6825ab0
006825A9C  adrp     x0, #0x8f21000
006825AA0  ldr      x0, [x0, #0xfe8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_EntityId()
006825AA4  bl       #0x382bd14 ; 
006825AA8  mov      w8, #1
006825AAC  strb     w8, [x26, #0x788]
006825AB0  adrp     x8, #0x8f21000
006825AB4  ldr      x8, [x8, #0xfe8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_EntityId()
006825AB8  ldr      x2, [x8]
006825ABC  ldrb     w8, [x2, #0x53]
006825AC0  tbnz     w8, #5, #0x6825acc
006825AC4  str      w22, [x19, #0x168]
006825AC8  b        #0x6825adc ; 
006825ACC  ldr      x8, [x2, #0x60]
006825AD0  mov      x0, x19
006825AD4  mov      w1, w22
006825AD8  blr      x8
006825ADC  adrp     x22, #0x959b000
006825AE0  ldrb     w8, [x22, #0x789]
006825AE4  cbnz     w8, #0x6825afc
006825AE8  adrp     x0, #0x8f21000
006825AEC  ldr      x0, [x0, #0xff0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_TableData()
006825AF0  bl       #0x382bd14 ; 
006825AF4  mov      w8, #1
006825AF8  strb     w8, [x22, #0x789]
006825AFC  adrp     x8, #0x8f21000
006825B00  ldr      x8, [x8, #0xff0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_TableData()
006825B04  ldr      x2, [x8]
006825B08  ldrb     w8, [x2, #0x53]
006825B0C  tbnz     w8, #5, #0x6825b24
006825B10  add      x0, x19, #0x170
006825B14  mov      x1, x21
006825B18  str      x21, [x19, #0x170]
006825B1C  bl       #0x382bcb8 ; 
006825B20  b        #0x6825b34 ; 
006825B24  ldr      x8, [x2, #0x60]
006825B28  mov      x0, x19
006825B2C  mov      x1, x21
006825B30  blr      x8
006825B34  adrp     x21, #0x9591000
006825B38  ldrb     w8, [x21, #0xa73]
006825B3C  cbnz     w8, #0x6825b54
006825B40  adrp     x0, #0x8ee6000
006825B44  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006825B48  bl       #0x382bd14 ; 
006825B4C  mov      w8, #1
006825B50  strb     w8, [x21, #0xa73]
006825B54  adrp     x8, #0x8ee6000
006825B58  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006825B5C  ldr      x1, [x8]
006825B60  ldrb     w8, [x1, #0x53]
006825B64  tbnz     w8, #5, #0x6825b98
006825B68  ldrb     w8, [x24, #0xa74]
006825B6C  cbnz     w8, #0x6825b84
006825B70  adrp     x0, #0x8ee6000
006825B74  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006825B78  bl       #0x382bd14 ; 
006825B7C  mov      w8, #1
006825B80  strb     w8, [x24, #0xa74]
006825B84  ldr      x1, [x25]
006825B88  ldrb     w8, [x1, #0x53]
006825B8C  tbnz     w8, #5, #0x6825ba4
006825B90  ldr      x21, [x19, #0x170]
006825B94  b        #0x6825bb4 ; 
006825B98  ldr      x8, [x1, #0x60]
006825B9C  mov      x0, x19
006825BA0  b        #0x6825bfc ; 
006825BA4  ldr      x8, [x1, #0x60]
006825BA8  mov      x0, x19
006825BAC  blr      x8
006825BB0  mov      x21, x0
006825BB4  cbz      x21, #0x6826314
006825BB8  adrp     x22, #0x9591000
006825BBC  ldrb     w8, [x22, #0xa75]
006825BC0  cbnz     w8, #0x6825bd8
006825BC4  adrp     x0, #0x8ee6000
006825BC8  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006825BCC  bl       #0x382bd14 ; 
006825BD0  mov      w8, #1
006825BD4  strb     w8, [x22, #0xa75]
006825BD8  adrp     x8, #0x8ee6000
006825BDC  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006825BE0  ldr      x1, [x8]
006825BE4  ldrb     w8, [x1, #0x53]
006825BE8  tbnz     w8, #5, #0x6825bf4
006825BEC  ldr      w21, [x21, #0x24]
006825BF0  b        #0x6825c04 ; 
006825BF4  ldr      x8, [x1, #0x60]
006825BF8  mov      x0, x21
006825BFC  blr      x8
006825C00  mov      w21, w0
006825C04  ldrb     w8, [x24, #0xa74]
006825C08  cbnz     w8, #0x6825c20
006825C0C  adrp     x0, #0x8ee6000
006825C10  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006825C14  bl       #0x382bd14 ; 
006825C18  mov      w8, #1
006825C1C  strb     w8, [x24, #0xa74]
006825C20  ldr      x1, [x25]
006825C24  ldrb     w8, [x1, #0x53]
006825C28  tbnz     w8, #5, #0x6825c34
006825C2C  ldr      x22, [x19, #0x170]
006825C30  b        #0x6825c44 ; 
006825C34  ldr      x8, [x1, #0x60]
006825C38  mov      x0, x19
006825C3C  blr      x8
006825C40  mov      x22, x0
006825C44  cbz      x22, #0x6826314
006825C48  adrp     x26, #0x9598000
006825C4C  ldrb     w8, [x26, #0xfc9]
006825C50  cbnz     w8, #0x6825c68
006825C54  adrp     x0, #0x8f06000
006825C58  ldr      x0, [x0, #0xab8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_moveType()
006825C5C  bl       #0x382bd14 ; 
006825C60  mov      w8, #1
006825C64  strb     w8, [x26, #0xfc9]
006825C68  adrp     x8, #0x8f06000
006825C6C  ldr      x8, [x8, #0xab8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_moveType()
006825C70  ldr      x1, [x8]
006825C74  ldrb     w8, [x1, #0x53]
006825C78  tbnz     w8, #5, #0x6825c84
006825C7C  ldr      w22, [x22, #0x1c0]
006825C80  b        #0x6825c94 ; 
006825C84  ldr      x8, [x1, #0x60]
006825C88  mov      x0, x22
006825C8C  blr      x8
006825C90  mov      w22, w0
006825C94  adrp     x26, #0x959b000
006825C98  ldrb     w8, [x26, #0x78a]
006825C9C  cbnz     w8, #0x6825cb4
006825CA0  adrp     x0, #0x8f22000
006825CA4  ldr      x0, [x0, #0x120] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetRaceType()
006825CA8  bl       #0x382bd14 ; 
006825CAC  mov      w8, #1
006825CB0  strb     w8, [x26, #0x78a]
006825CB4  adrp     x8, #0x8f22000
006825CB8  ldr      x8, [x8, #0x120] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetRaceType()
006825CBC  ldr      x3, [x8]
006825CC0  ldrb     w8, [x3, #0x53]
006825CC4  tbz      w8, #5, #0x6825cdc
006825CC8  ldr      x8, [x3, #0x60]
006825CCC  mov      x0, x19
006825CD0  mov      w1, w21
006825CD4  mov      w2, w22
006825CD8  blr      x8
006825CDC  adrp     x21, #0x9591000
006825CE0  ldrb     w8, [x21, #0xa92]
006825CE4  cbnz     w8, #0x6825cfc
006825CE8  adrp     x0, #0x8ee6000
006825CEC  ldr      x0, [x0, #0x3f0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Camp()
006825CF0  bl       #0x382bd14 ; 
006825CF4  mov      w8, #1
006825CF8  strb     w8, [x21, #0xa92]
006825CFC  adrp     x8, #0x8ee6000
006825D00  ldr      x8, [x8, #0x3f0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Camp()
006825D04  ldr      x1, [x8]
006825D08  ldrb     w8, [x1, #0x53]
006825D0C  tbnz     w8, #5, #0x6825d18
006825D10  ldr      w0, [x19, #0x150]
006825D14  b        #0x6825d24 ; 
006825D18  ldr      x8, [x1, #0x60]
006825D1C  mov      x0, x19
006825D20  blr      x8
006825D24  cbz      w0, #0x6826338
006825D28  adrp     x21, #0x959b000
006825D2C  ldrb     w8, [x21, #0x78b]
006825D30  cbnz     w8, #0x6825d48
006825D34  adrp     x0, #0x8f21000
006825D38  ldr      x0, [x0, #0xff8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Attribute()
006825D3C  bl       #0x382bd14 ; 
006825D40  mov      w8, #1
006825D44  strb     w8, [x21, #0x78b]
006825D48  adrp     x8, #0x8f21000
006825D4C  ldr      x8, [x8, #0xff8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Attribute()
006825D50  ldr      x2, [x8]
006825D54  ldrb     w8, [x2, #0x53]
006825D58  tbnz     w8, #5, #0x6825d70
006825D5C  add      x0, x19, #0x178
006825D60  mov      x1, x20
006825D64  str      x20, [x19, #0x178]
006825D68  bl       #0x382bcb8 ; 
006825D6C  b        #0x6825d80 ; 
006825D70  ldr      x8, [x2, #0x60]
006825D74  mov      x0, x19
006825D78  mov      x1, x20
006825D7C  blr      x8
006825D80  ldrb     w8, [x24, #0xa74]
006825D84  cbnz     w8, #0x6825d9c
006825D88  adrp     x0, #0x8ee6000
006825D8C  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006825D90  bl       #0x382bd14 ; 
006825D94  mov      w8, #1
006825D98  strb     w8, [x24, #0xa74]
006825D9C  ldr      x1, [x25]
006825DA0  ldrb     w8, [x1, #0x53]
006825DA4  tbnz     w8, #5, #0x6825db0
006825DA8  ldr      x20, [x19, #0x170]
006825DAC  b        #0x6825dc0 ; 
006825DB0  ldr      x8, [x1, #0x60]
006825DB4  mov      x0, x19
006825DB8  blr      x8
006825DBC  mov      x20, x0
006825DC0  cbz      x20, #0x6826314
006825DC4  adrp     x22, #0x9598000
006825DC8  ldrb     w8, [x22, #0xfbb]
006825DCC  cbnz     w8, #0x6825de4
006825DD0  adrp     x0, #0x8f05000
006825DD4  ldr      x0, [x0, #0xa88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Shape()
006825DD8  bl       #0x382bd14 ; 
006825DDC  mov      w8, #1
006825DE0  strb     w8, [x22, #0xfbb]
006825DE4  adrp     x26, #0x8f05000
006825DE8  ldr      x26, [x26, #0xa88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Shape()
006825DEC  ldr      x1, [x26]
006825DF0  ldrb     w8, [x1, #0x53]
006825DF4  tbnz     w8, #5, #0x6825e00
006825DF8  ldr      x0, [x20, #0x48]
006825DFC  b        #0x6825e0c ; 
006825E00  ldr      x8, [x1, #0x60]
006825E04  mov      x0, x20
006825E08  blr      x8
006825E0C  cbz      x0, #0x6826314
006825E10  ldrb     w8, [x24, #0xa74]
006825E14  ldr      w21, [x0, #0x18]
006825E18  cbnz     w8, #0x6825e30
006825E1C  adrp     x0, #0x8ee6000
006825E20  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006825E24  bl       #0x382bd14 ; 
006825E28  mov      w8, #1
006825E2C  strb     w8, [x24, #0xa74]
006825E30  ldr      x1, [x25]
006825E34  ldrb     w8, [x1, #0x53]
006825E38  tbnz     w8, #5, #0x6825e44
006825E3C  ldr      x20, [x19, #0x170]
006825E40  b        #0x6825e54 ; 
006825E44  ldr      x8, [x1, #0x60]
006825E48  mov      x0, x19
006825E4C  blr      x8
006825E50  mov      x20, x0
006825E54  cbz      x20, #0x6826314
006825E58  ldrb     w8, [x22, #0xfbb]
006825E5C  cbnz     w8, #0x6825e74
006825E60  adrp     x0, #0x8f05000
006825E64  ldr      x0, [x0, #0xa88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Shape()
006825E68  bl       #0x382bd14 ; 
006825E6C  mov      w8, #1
006825E70  strb     w8, [x22, #0xfbb]
006825E74  ldr      x1, [x26]
006825E78  ldrb     w8, [x1, #0x53]
006825E7C  tbnz     w8, #5, #0x6825e88
006825E80  ldr      x0, [x20, #0x48]
006825E84  b        #0x6825e94 ; 
006825E88  ldr      x8, [x1, #0x60]
006825E8C  mov      x0, x20
006825E90  blr      x8
006825E94  cbz      x0, #0x6826314
006825E98  ldr      w8, [x0, #0x18]
006825E9C  cmp      w21, #2
006825EA0  b.ne     #0x6825edc
006825EA4  cbz      w8, #0x6826318
006825EA8  ldrb     w8, [x24, #0xa74]
006825EAC  ldr      x20, [x0, #0x20]
006825EB0  cbnz     w8, #0x6825ec8
006825EB4  adrp     x0, #0x8ee6000
006825EB8  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006825EBC  bl       #0x382bd14 ; 
006825EC0  mov      w8, #1
006825EC4  strb     w8, [x24, #0xa74]
006825EC8  ldr      x1, [x25]
006825ECC  ldrb     w8, [x1, #0x53]
006825ED0  tbnz     w8, #5, #0x6825f14
006825ED4  ldr      x21, [x19, #0x170]
006825ED8  b        #0x6825f24 ; 
006825EDC  cmp      w8, #1
006825EE0  b.ne     #0x6826144
006825EE4  ldrb     w8, [x24, #0xa74]
006825EE8  cbnz     w8, #0x6825f00
006825EEC  adrp     x0, #0x8ee6000
006825EF0  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006825EF4  bl       #0x382bd14 ; 
006825EF8  mov      w8, #1
006825EFC  strb     w8, [x24, #0xa74]
006825F00  ldr      x1, [x25]
006825F04  ldrb     w8, [x1, #0x53]
006825F08  tbnz     w8, #5, #0x6826170
006825F0C  ldr      x20, [x19, #0x170]
006825F10  b        #0x6826180 ; 
006825F14  ldr      x8, [x1, #0x60]
006825F18  mov      x0, x19
006825F1C  blr      x8
006825F20  mov      x21, x0
006825F24  cbz      x21, #0x6826314
006825F28  ldrb     w8, [x22, #0xfbb]
006825F2C  cbnz     w8, #0x6825f44
006825F30  adrp     x0, #0x8f05000
006825F34  ldr      x0, [x0, #0xa88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Shape()
006825F38  bl       #0x382bd14 ; 
006825F3C  mov      w8, #1
006825F40  strb     w8, [x22, #0xfbb]
006825F44  ldr      x1, [x26]
006825F48  ldrb     w8, [x1, #0x53]
006825F4C  tbnz     w8, #5, #0x6825f58
006825F50  ldr      x0, [x21, #0x48]
006825F54  b        #0x6825f64 ; 
006825F58  ldr      x8, [x1, #0x60]
006825F5C  mov      x0, x21
006825F60  blr      x8
006825F64  cbz      x0, #0x6826314
006825F68  ldr      w8, [x0, #0x18]
006825F6C  cmp      w8, #1
006825F70  b.ls     #0x6826318
006825F74  ldr      x2, [x0, #0x28]
006825F78  add      x0, sp, #0x80
006825F7C  mov      x1, x20
006825F80  mov      x3, xzr
006825F84  stp      xzr, xzr, [sp, #0x80]
006825F88  bl       #0x7d4e1f0 ; Photon.Deterministic.FPVector2$$.ctor
006825F8C  ldp      x0, x1, [sp, #0x80]
006825F90  add      x8, sp, #0x90
006825F94  mov      x2, xzr
006825F98  mov      x3, xzr
006825F9C  mov      x4, xzr
006825FA0  mov      x5, xzr
006825FA4  bl       #0x7e292c4 ; Quantum.Shape2D$$CreateBox
006825FA8  adrp     x20, #0x959b000
006825FAC  ldp      q0, q1, [sp, #0x90]
006825FB0  ldp      q2, q3, [sp, #0xb0]
006825FB4  ldrb     w8, [x20, #0x78d]
006825FB8  stp      q0, q1, [sp, #0x40]
006825FBC  stp      q2, q3, [sp, #0x60]
006825FC0  cbnz     w8, #0x6825fd8
006825FC4  adrp     x0, #0x8f22000
006825FC8  ldr      x0, [x0, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Shape()
006825FCC  bl       #0x382bd14 ; 
006825FD0  mov      w8, #1
006825FD4  strb     w8, [x20, #0x78d]
006825FD8  adrp     x8, #0x8f22000
006825FDC  ldr      x8, [x8, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Shape()
006825FE0  ldr      x2, [x8]
006825FE4  ldrb     w8, [x2, #0x53]
006825FE8  tbnz     w8, #5, #0x6826000
006825FEC  ldp      q1, q0, [sp, #0x60]
006825FF0  ldp      q3, q2, [sp, #0x40]
006825FF4  stp      q1, q0, [x19, #0x1e0]
006825FF8  stp      q3, q2, [x19, #0x1c0]
006825FFC  b        #0x6826020 ; 
006826000  ldr      x8, [x2, #0x60]
006826004  ldp      q0, q1, [sp, #0x40]
006826008  ldp      q2, q3, [sp, #0x60]
00682600C  add      x1, sp, #0x90
006826010  mov      x0, x19
006826014  stp      q0, q1, [sp, #0x90]
006826018  stp      q2, q3, [sp, #0xb0]
00682601C  blr      x8
006826020  adrp     x20, #0x9594000
006826024  ldrb     w8, [x20, #0x274]
006826028  cbnz     w8, #0x6826040
00682602C  adrp     x0, #0x8ee9000
006826030  ldr      x0, [x0, #0xf48] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Shape()
006826034  bl       #0x382bd14 ; 
006826038  mov      w8, #1
00682603C  strb     w8, [x20, #0x274]
006826040  adrp     x8, #0x8ee9000
006826044  ldr      x8, [x8, #0xf48] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Shape()
006826048  ldr      x1, [x8]
00682604C  ldrb     w8, [x1, #0x53]
006826050  tbnz     w8, #5, #0x6826068
006826054  ldp      q1, q0, [x19, #0x1e0]
006826058  ldp      q3, q2, [x19, #0x1c0]
00682605C  stp      q1, q0, [sp, #0xb0]
006826060  stp      q3, q2, [sp, #0x90]
006826064  b        #0x6826078 ; 
006826068  ldr      x9, [x1, #0x60]
00682606C  add      x8, sp, #0x90
006826070  mov      x0, x19
006826074  blr      x9
006826078  ldp      x20, x21, [sp, #0xb8]
00682607C  mov      x1, xzr
006826080  mul      x9, x21, x21
006826084  mul      x8, x20, x20
006826088  asr      x9, x9, #0x10
00682608C  add      x0, x9, x8, asr #16
006826090  bl       #0x7d472cc ; Photon.Deterministic.FPMath$$SqrtRaw
006826094  adrp     x24, #0x959b000
006826098  ldrb     w8, [x24, #0x78e]
00682609C  mov      x22, x0
0068260A0  cbnz     w8, #0x68260b8
0068260A4  adrp     x0, #0x8f22000
0068260A8  ldr      x0, [x0, #0xa8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius()
0068260AC  bl       #0x382bd14 ; 
0068260B0  mov      w8, #1
0068260B4  strb     w8, [x24, #0x78e]
0068260B8  adrp     x8, #0x8f22000
0068260BC  ldr      x8, [x8, #0xa8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius()
0068260C0  ldr      x2, [x8]
0068260C4  ldrb     w8, [x2, #0x53]
0068260C8  tbnz     w8, #5, #0x68260d4
0068260CC  str      x22, [x19, #0x200]
0068260D0  b        #0x68260e4 ; 
0068260D4  ldr      x8, [x2, #0x60]
0068260D8  mov      x0, x19
0068260DC  mov      x1, x22
0068260E0  blr      x8
0068260E4  mov      x0, x20
0068260E8  mov      x1, x21
0068260EC  mov      x2, xzr
0068260F0  bl       #0x7d46f8c ; Photon.Deterministic.FPMath$$Min
0068260F4  adrp     x21, #0x959b000
0068260F8  ldrb     w8, [x21, #0x78f]
0068260FC  mov      x20, x0
006826100  cbnz     w8, #0x6826118
006826104  adrp     x0, #0x8f22000
006826108  ldr      x0, [x0, #0xb0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius2()
00682610C  bl       #0x382bd14 ; 
006826110  mov      w8, #1
006826114  strb     w8, [x21, #0x78f]
006826118  adrp     x8, #0x8f22000
00682611C  ldr      x8, [x8, #0xb0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius2()
006826120  ldr      x2, [x8]
006826124  ldrb     w8, [x2, #0x53]
006826128  tbnz     w8, #5, #0x6826134
00682612C  str      x20, [x19, #0x208]
006826130  b        #0x6826144 ; 
006826134  ldr      x8, [x2, #0x60]
006826138  mov      x0, x19
00682613C  mov      x1, x20
006826140  blr      x8
006826144  ldr      x8, [x23, #0x28]
006826148  ldr      x9, [sp, #0xd8]
00682614C  cmp      x8, x9
006826150  b.ne     #0x682639c
006826154  ldp      x20, x19, [sp, #0x120]
006826158  ldp      x22, x21, [sp, #0x110]
00682615C  ldp      x24, x23, [sp, #0x100]
006826160  ldp      x26, x25, [sp, #0xf0]
006826164  ldp      x29, x30, [sp, #0xe0]
006826168  add      sp, sp, #0x130
00682616C  ret      
006826170  ldr      x8, [x1, #0x60]
006826174  mov      x0, x19
006826178  blr      x8
00682617C  mov      x20, x0
006826180  cbz      x20, #0x6826314
006826184  ldrb     w8, [x22, #0xfbb]
006826188  cbnz     w8, #0x68261a0
00682618C  adrp     x0, #0x8f05000
006826190  ldr      x0, [x0, #0xa88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Shape()
006826194  bl       #0x382bd14 ; 
006826198  mov      w8, #1
00682619C  strb     w8, [x22, #0xfbb]
0068261A0  ldr      x1, [x26]
0068261A4  ldrb     w8, [x1, #0x53]
0068261A8  tbnz     w8, #5, #0x68261b4
0068261AC  ldr      x0, [x20, #0x48]
0068261B0  b        #0x68261c0 ; 
0068261B4  ldr      x8, [x1, #0x60]
0068261B8  mov      x0, x20
0068261BC  blr      x8
0068261C0  cbz      x0, #0x6826314
0068261C4  ldr      w8, [x0, #0x18]
0068261C8  cbz      w8, #0x6826318
0068261CC  ldr      x0, [x0, #0x20]
0068261D0  add      x8, sp, #0x90
0068261D4  mov      x1, xzr
0068261D8  mov      x2, xzr
0068261DC  mov      x3, xzr
0068261E0  bl       #0x7e29220 ; Quantum.Shape2D$$CreateCircle
0068261E4  adrp     x20, #0x959b000
0068261E8  ldp      q0, q1, [sp, #0x90]
0068261EC  ldp      q2, q3, [sp, #0xb0]
0068261F0  ldrb     w8, [x20, #0x78d]
0068261F4  stp      q0, q1, [sp]
0068261F8  stp      q2, q3, [sp, #0x20]
0068261FC  cbnz     w8, #0x6826214
006826200  adrp     x0, #0x8f22000
006826204  ldr      x0, [x0, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Shape()
006826208  bl       #0x382bd14 ; 
00682620C  mov      w8, #1
006826210  strb     w8, [x20, #0x78d]
006826214  adrp     x8, #0x8f22000
006826218  ldr      x8, [x8, #0xa0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Shape()
00682621C  ldr      x2, [x8]
006826220  ldrb     w8, [x2, #0x53]
006826224  tbnz     w8, #5, #0x682623c
006826228  ldp      q1, q0, [sp, #0x20]
00682622C  ldp      q3, q2, [sp]
006826230  stp      q1, q0, [x19, #0x1e0]
006826234  stp      q3, q2, [x19, #0x1c0]
006826238  b        #0x682625c ; 
00682623C  ldr      x8, [x2, #0x60]
006826240  ldp      q0, q1, [sp]
006826244  ldp      q2, q3, [sp, #0x20]
006826248  add      x1, sp, #0x90
00682624C  mov      x0, x19
006826250  stp      q0, q1, [sp, #0x90]
006826254  stp      q2, q3, [sp, #0xb0]
006826258  blr      x8
00682625C  adrp     x20, #0x9594000
006826260  ldrb     w8, [x20, #0x274]
006826264  cbnz     w8, #0x682627c
006826268  adrp     x0, #0x8ee9000
00682626C  ldr      x0, [x0, #0xf48] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Shape()
006826270  bl       #0x382bd14 ; 
006826274  mov      w8, #1
006826278  strb     w8, [x20, #0x274]
00682627C  adrp     x8, #0x8ee9000
006826280  ldr      x8, [x8, #0xf48] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_Shape()
006826284  ldr      x1, [x8]
006826288  ldrb     w8, [x1, #0x53]
00682628C  tbnz     w8, #5, #0x68262a4
006826290  ldp      q1, q0, [x19, #0x1e0]
006826294  ldp      q3, q2, [x19, #0x1c0]
006826298  stp      q1, q0, [sp, #0xb0]
00682629C  stp      q3, q2, [sp, #0x90]
0068262A0  b        #0x68262b4 ; 
0068262A4  ldr      x9, [x1, #0x60]
0068262A8  add      x8, sp, #0x90
0068262AC  mov      x0, x19
0068262B0  blr      x9
0068262B4  adrp     x21, #0x959b000
0068262B8  ldrb     w8, [x21, #0x78e]
0068262BC  ldr      x20, [sp, #0xb0]
0068262C0  cbnz     w8, #0x68262d8
0068262C4  adrp     x0, #0x8f22000
0068262C8  ldr      x0, [x0, #0xa8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius()
0068262CC  bl       #0x382bd14 ; 
0068262D0  mov      w8, #1
0068262D4  strb     w8, [x21, #0x78e]
0068262D8  adrp     x8, #0x8f22000
0068262DC  ldr      x8, [x8, #0xa8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_ShapeRadius()
0068262E0  ldr      x2, [x8]
0068262E4  ldrb     w8, [x2, #0x53]
0068262E8  tbnz     w8, #5, #0x68262f4
0068262EC  str      x20, [x19, #0x200]
0068262F0  b        #0x6826304 ; 
0068262F4  ldr      x8, [x2, #0x60]
0068262F8  mov      x0, x19
0068262FC  mov      x1, x20
006826300  blr      x8
006826304  adrp     x21, #0x959b000
006826308  ldrb     w8, [x21, #0x78f]
00682630C  cbnz     w8, #0x6826118
006826310  b        #0x6826104 ; 
006826314  bl       #0x382bfb8 ; 
006826318  bl       #0x382bfc0 ; 
00682631C  mov      x0, x19
006826320  mov      x1, xzr
006826324  bl       #0x7c33c40 ; System.Object$$GetType
006826328  mov      x19, x0
00682632C  adrp     x0, #0x8f22000
006826330  ldr      x0, [x0, #0x140] ; GLOBAL {0}Entity table data is not null!
006826334  b        #0x6826350 ; 
006826338  mov      x0, x19
00682633C  mov      x1, xzr
006826340  bl       #0x7c33c40 ; System.Object$$GetType
006826344  mov      x19, x0
006826348  adrp     x0, #0x8f22000
00682634C  ldr      x0, [x0, #0x158] ; GLOBAL {0}.SetTableData camp error
006826350  bl       #0x382bd28 ; 
006826354  mov      x1, x19
006826358  mov      x2, xzr
00682635C  bl       #0x79d140c ; System.String$$Format
006826360  mov      x19, x0
006826364  adrp     x0, #0x8ebf000
006826368  ldr      x0, [x0, #0xc70] ; GLOBAL System.Exception_TypeInfo
00682636C  bl       #0x382bd28 ; 
006826370  bl       #0x382bfa0 ; 
006826374  mov      x1, x19
006826378  mov      x2, xzr
00682637C  mov      x20, x0
006826380  bl       #0x7c15e34 ; System.Exception$$.ctor
006826384  adrp     x0, #0x8f22000
006826388  ldr      x0, [x0, #0x150] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetTableData()
00682638C  bl       #0x382bd28 ; 
006826390  mov      x1, x0
006826394  mov      x0, x20
006826398  bl       #0x382be7c ; 
00682639C  bl       #0x89edb60 ; 

