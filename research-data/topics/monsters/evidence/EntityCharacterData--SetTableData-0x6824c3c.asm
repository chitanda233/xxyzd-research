; HotFix.BattleLogic.EntityCharacterData$$SetTableData
; RVA 0x6824C3C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006824C3C  stp      x30, x27, [sp, #-0x50]!
006824C40  stp      x26, x25, [sp, #0x10]
006824C44  stp      x24, x23, [sp, #0x20]
006824C48  stp      x22, x21, [sp, #0x30]
006824C4C  stp      x20, x19, [sp, #0x40]
006824C50  adrp     x22, #0x959b000
006824C54  adrp     x23, #0x8f22000
006824C58  ldrb     w8, [x22, #0x6ea]
006824C5C  ldr      x23, [x23, #0x128] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetTableData()
006824C60  mov      x20, x2
006824C64  mov      x21, x1
006824C68  mov      x19, x0
006824C6C  tbnz     w8, #0, #0x6824ca8
006824C70  adrp     x0, #0x8ee8000
006824C74  ldr      x0, [x0, #0x910] ; GLOBAL HotFix.Common.BattleLayerManager_TypeInfo
006824C78  bl       #0x382bd14 ; 
006824C7C  adrp     x0, #0x8f22000
006824C80  ldr      x0, [x0, #0x130] ; GLOBAL HotFix.Common.CharacterAttributeData_TypeInfo
006824C84  bl       #0x382bd14 ; 
006824C88  adrp     x0, #0x8f22000
006824C8C  ldr      x0, [x0, #0x138] ; GLOBAL HotFix.Common.CommonUtils_TypeInfo
006824C90  bl       #0x382bd14 ; 
006824C94  adrp     x0, #0x8f22000
006824C98  ldr      x0, [x0, #0x128] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetTableData()
006824C9C  bl       #0x382bd14 ; 
006824CA0  mov      w8, #1
006824CA4  strb     w8, [x22, #0x6ea]
006824CA8  ldr      x3, [x23]
006824CAC  ldrb     w8, [x3, #0x53]
006824CB0  tbnz     w8, #5, #0x6824cf0
006824CB4  adrp     x23, #0x9591000
006824CB8  ldrb     w8, [x23, #0xa74]
006824CBC  cbnz     w8, #0x6824cd4
006824CC0  adrp     x0, #0x8ee6000
006824CC4  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006824CC8  bl       #0x382bd14 ; 
006824CCC  mov      w8, #1
006824CD0  strb     w8, [x23, #0xa74]
006824CD4  adrp     x24, #0x8ee6000
006824CD8  ldr      x24, [x24, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006824CDC  ldr      x1, [x24]
006824CE0  ldrb     w8, [x1, #0x53]
006824CE4  tbnz     w8, #5, #0x6824d18
006824CE8  ldr      x0, [x19, #0x170]
006824CEC  b        #0x6824d24 ; 
006824CF0  ldr      x4, [x3, #0x60]
006824CF4  mov      x0, x19
006824CF8  mov      x1, x21
006824CFC  mov      x2, x20
006824D00  ldp      x20, x19, [sp, #0x40]
006824D04  ldp      x22, x21, [sp, #0x30]
006824D08  ldp      x24, x23, [sp, #0x20]
006824D0C  ldp      x26, x25, [sp, #0x10]
006824D10  ldp      x30, x27, [sp], #0x50
006824D14  br       x4
006824D18  ldr      x8, [x1, #0x60]
006824D1C  mov      x0, x19
006824D20  blr      x8
006824D24  cbnz     x0, #0x6825260
006824D28  cbz      x21, #0x682525c
006824D2C  adrp     x22, #0x9598000
006824D30  ldrb     w8, [x22, #0xcbd]
006824D34  cbnz     w8, #0x6824d4c
006824D38  adrp     x0, #0x8efd000
006824D3C  ldr      x0, [x0, #0x600] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_ID()
006824D40  bl       #0x382bd14 ; 
006824D44  mov      w8, #1
006824D48  strb     w8, [x22, #0xcbd]
006824D4C  adrp     x8, #0x8efd000
006824D50  ldr      x8, [x8, #0x600] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_ID()
006824D54  ldr      x1, [x8]
006824D58  ldrb     w8, [x1, #0x53]
006824D5C  tbnz     w8, #5, #0x6824d68
006824D60  ldr      w22, [x21, #0x20]
006824D64  b        #0x6824d78 ; 
006824D68  ldr      x8, [x1, #0x60]
006824D6C  mov      x0, x21
006824D70  blr      x8
006824D74  mov      w22, w0
006824D78  adrp     x25, #0x959b000
006824D7C  ldrb     w8, [x25, #0x788]
006824D80  cbnz     w8, #0x6824d98
006824D84  adrp     x0, #0x8f21000
006824D88  ldr      x0, [x0, #0xfe8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_EntityId()
006824D8C  bl       #0x382bd14 ; 
006824D90  mov      w8, #1
006824D94  strb     w8, [x25, #0x788]
006824D98  adrp     x8, #0x8f21000
006824D9C  ldr      x8, [x8, #0xfe8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_EntityId()
006824DA0  ldr      x2, [x8]
006824DA4  ldrb     w8, [x2, #0x53]
006824DA8  tbnz     w8, #5, #0x6824db4
006824DAC  str      w22, [x19, #0x168]
006824DB0  b        #0x6824dc4 ; 
006824DB4  ldr      x8, [x2, #0x60]
006824DB8  mov      x0, x19
006824DBC  mov      w1, w22
006824DC0  blr      x8
006824DC4  adrp     x22, #0x959b000
006824DC8  ldrb     w8, [x22, #0x789]
006824DCC  cbnz     w8, #0x6824de4
006824DD0  adrp     x0, #0x8f21000
006824DD4  ldr      x0, [x0, #0xff0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_TableData()
006824DD8  bl       #0x382bd14 ; 
006824DDC  mov      w8, #1
006824DE0  strb     w8, [x22, #0x789]
006824DE4  adrp     x8, #0x8f21000
006824DE8  ldr      x8, [x8, #0xff0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_TableData()
006824DEC  ldr      x2, [x8]
006824DF0  ldrb     w8, [x2, #0x53]
006824DF4  tbnz     w8, #5, #0x6824e0c
006824DF8  add      x0, x19, #0x170
006824DFC  mov      x1, x21
006824E00  str      x21, [x19, #0x170]
006824E04  bl       #0x382bcb8 ; 
006824E08  b        #0x6824e1c ; 
006824E0C  ldr      x8, [x2, #0x60]
006824E10  mov      x0, x19
006824E14  mov      x1, x21
006824E18  blr      x8
006824E1C  adrp     x25, #0x9591000
006824E20  ldrb     w8, [x25, #0xa73]
006824E24  cbnz     w8, #0x6824e3c
006824E28  adrp     x0, #0x8ee6000
006824E2C  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006824E30  bl       #0x382bd14 ; 
006824E34  mov      w8, #1
006824E38  strb     w8, [x25, #0xa73]
006824E3C  adrp     x26, #0x8ee6000
006824E40  ldr      x26, [x26, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006824E44  ldr      x1, [x26]
006824E48  ldrb     w8, [x1, #0x53]
006824E4C  tbnz     w8, #5, #0x6824e80
006824E50  ldrb     w8, [x23, #0xa74]
006824E54  cbnz     w8, #0x6824e6c
006824E58  adrp     x0, #0x8ee6000
006824E5C  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006824E60  bl       #0x382bd14 ; 
006824E64  mov      w8, #1
006824E68  strb     w8, [x23, #0xa74]
006824E6C  ldr      x1, [x24]
006824E70  ldrb     w8, [x1, #0x53]
006824E74  tbnz     w8, #5, #0x6824e8c
006824E78  ldr      x21, [x19, #0x170]
006824E7C  b        #0x6824e9c ; 
006824E80  ldr      x8, [x1, #0x60]
006824E84  mov      x0, x19
006824E88  b        #0x6824ee4 ; 
006824E8C  ldr      x8, [x1, #0x60]
006824E90  mov      x0, x19
006824E94  blr      x8
006824E98  mov      x21, x0
006824E9C  cbz      x21, #0x682525c
006824EA0  adrp     x22, #0x9591000
006824EA4  ldrb     w8, [x22, #0xa75]
006824EA8  cbnz     w8, #0x6824ec0
006824EAC  adrp     x0, #0x8ee6000
006824EB0  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006824EB4  bl       #0x382bd14 ; 
006824EB8  mov      w8, #1
006824EBC  strb     w8, [x22, #0xa75]
006824EC0  adrp     x8, #0x8ee6000
006824EC4  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006824EC8  ldr      x1, [x8]
006824ECC  ldrb     w8, [x1, #0x53]
006824ED0  tbnz     w8, #5, #0x6824edc
006824ED4  ldr      w21, [x21, #0x24]
006824ED8  b        #0x6824eec ; 
006824EDC  ldr      x8, [x1, #0x60]
006824EE0  mov      x0, x21
006824EE4  blr      x8
006824EE8  mov      w21, w0
006824EEC  ldrb     w8, [x23, #0xa74]
006824EF0  cbnz     w8, #0x6824f08
006824EF4  adrp     x0, #0x8ee6000
006824EF8  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006824EFC  bl       #0x382bd14 ; 
006824F00  mov      w8, #1
006824F04  strb     w8, [x23, #0xa74]
006824F08  ldr      x1, [x24]
006824F0C  ldrb     w8, [x1, #0x53]
006824F10  tbnz     w8, #5, #0x6824f1c
006824F14  ldr      x22, [x19, #0x170]
006824F18  b        #0x6824f2c ; 
006824F1C  ldr      x8, [x1, #0x60]
006824F20  mov      x0, x19
006824F24  blr      x8
006824F28  mov      x22, x0
006824F2C  cbz      x22, #0x682525c
006824F30  adrp     x27, #0x9598000
006824F34  ldrb     w8, [x27, #0xfc9]
006824F38  cbnz     w8, #0x6824f50
006824F3C  adrp     x0, #0x8f06000
006824F40  ldr      x0, [x0, #0xab8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_moveType()
006824F44  bl       #0x382bd14 ; 
006824F48  mov      w8, #1
006824F4C  strb     w8, [x27, #0xfc9]
006824F50  adrp     x8, #0x8f06000
006824F54  ldr      x8, [x8, #0xab8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_moveType()
006824F58  ldr      x1, [x8]
006824F5C  ldrb     w8, [x1, #0x53]
006824F60  tbnz     w8, #5, #0x6824f6c
006824F64  ldr      w22, [x22, #0x1c0]
006824F68  b        #0x6824f7c ; 
006824F6C  ldr      x8, [x1, #0x60]
006824F70  mov      x0, x22
006824F74  blr      x8
006824F78  mov      w22, w0
006824F7C  adrp     x27, #0x959b000
006824F80  ldrb     w8, [x27, #0x78a]
006824F84  cbnz     w8, #0x6824f9c
006824F88  adrp     x0, #0x8f22000
006824F8C  ldr      x0, [x0, #0x120] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetRaceType()
006824F90  bl       #0x382bd14 ; 
006824F94  mov      w8, #1
006824F98  strb     w8, [x27, #0x78a]
006824F9C  adrp     x8, #0x8f22000
006824FA0  ldr      x8, [x8, #0x120] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetRaceType()
006824FA4  ldr      x3, [x8]
006824FA8  ldrb     w8, [x3, #0x53]
006824FAC  tbz      w8, #5, #0x6824fc4
006824FB0  ldr      x8, [x3, #0x60]
006824FB4  mov      x0, x19
006824FB8  mov      w1, w21
006824FBC  mov      w2, w22
006824FC0  blr      x8
006824FC4  ldrb     w8, [x23, #0xa74]
006824FC8  cbnz     w8, #0x6824fe0
006824FCC  adrp     x0, #0x8ee6000
006824FD0  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006824FD4  bl       #0x382bd14 ; 
006824FD8  mov      w8, #1
006824FDC  strb     w8, [x23, #0xa74]
006824FE0  ldr      x1, [x24]
006824FE4  ldrb     w8, [x1, #0x53]
006824FE8  tbnz     w8, #5, #0x6824ff4
006824FEC  ldr      x21, [x19, #0x170]
006824FF0  b        #0x6825004 ; 
006824FF4  ldr      x8, [x1, #0x60]
006824FF8  mov      x0, x19
006824FFC  blr      x8
006825000  mov      x21, x0
006825004  adrp     x8, #0x8f22000
006825008  ldr      x8, [x8, #0x138] ; GLOBAL HotFix.Common.CommonUtils_TypeInfo
00682500C  ldr      x0, [x8]
006825010  ldr      w8, [x0, #0xe0]
006825014  cbnz     w8, #0x682501c
006825018  bl       #0x382be8c ; 
00682501C  mov      w2, #1
006825020  mov      x0, x20
006825024  mov      x1, x21
006825028  mov      x3, xzr
00682502C  bl       #0x6b5066c ; HotFix.Common.CommonUtils$$CreateAttributeData
006825030  mov      x20, x0
006825034  cbz      x0, #0x6825050
006825038  adrp     x8, #0x8f22000
00682503C  ldr      x8, [x8, #0x130] ; GLOBAL HotFix.Common.CharacterAttributeData_TypeInfo
006825040  ldr      x1, [x8]
006825044  ldr      x8, [x20]
006825048  cmp      x8, x1
00682504C  b.ne     #0x68252c4
006825050  adrp     x21, #0x959b000
006825054  ldrb     w8, [x21, #0x78b]
006825058  cbnz     w8, #0x6825070
00682505C  adrp     x0, #0x8f21000
006825060  ldr      x0, [x0, #0xff8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Attribute()
006825064  bl       #0x382bd14 ; 
006825068  mov      w8, #1
00682506C  strb     w8, [x21, #0x78b]
006825070  adrp     x8, #0x8f21000
006825074  ldr      x8, [x8, #0xff8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Attribute()
006825078  ldr      x2, [x8]
00682507C  ldrb     w8, [x2, #0x53]
006825080  tbnz     w8, #5, #0x6825098
006825084  add      x0, x19, #0x178
006825088  mov      x1, x20
00682508C  str      x20, [x19, #0x178]
006825090  bl       #0x382bcb8 ; 
006825094  b        #0x68250a8 ; 
006825098  ldr      x8, [x2, #0x60]
00682509C  mov      x0, x19
0068250A0  mov      x1, x20
0068250A4  blr      x8
0068250A8  mov      w1, #0x10000
0068250AC  mov      x0, x19
0068250B0  bl       #0x68252cc ; HotFix.BattleLogic.EntityCharacterData$$SetShapeScale
0068250B4  ldrb     w8, [x25, #0xa73]
0068250B8  cbnz     w8, #0x68250d0
0068250BC  adrp     x0, #0x8ee6000
0068250C0  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0068250C4  bl       #0x382bd14 ; 
0068250C8  mov      w8, #1
0068250CC  strb     w8, [x25, #0xa73]
0068250D0  ldr      x1, [x26]
0068250D4  ldrb     w8, [x1, #0x53]
0068250D8  tbnz     w8, #5, #0x682510c
0068250DC  ldrb     w8, [x23, #0xa74]
0068250E0  cbnz     w8, #0x68250f8
0068250E4  adrp     x0, #0x8ee6000
0068250E8  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068250EC  bl       #0x382bd14 ; 
0068250F0  mov      w8, #1
0068250F4  strb     w8, [x23, #0xa74]
0068250F8  ldr      x1, [x24]
0068250FC  ldrb     w8, [x1, #0x53]
006825100  tbnz     w8, #5, #0x6825118
006825104  ldr      x20, [x19, #0x170]
006825108  b        #0x6825128 ; 
00682510C  ldr      x8, [x1, #0x60]
006825110  mov      x0, x19
006825114  b        #0x6825170 ; 
006825118  ldr      x8, [x1, #0x60]
00682511C  mov      x0, x19
006825120  blr      x8
006825124  mov      x20, x0
006825128  cbz      x20, #0x682525c
00682512C  adrp     x21, #0x9591000
006825130  ldrb     w8, [x21, #0xa75]
006825134  cbnz     w8, #0x682514c
006825138  adrp     x0, #0x8ee6000
00682513C  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006825140  bl       #0x382bd14 ; 
006825144  mov      w8, #1
006825148  strb     w8, [x21, #0xa75]
00682514C  adrp     x8, #0x8ee6000
006825150  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006825154  ldr      x1, [x8]
006825158  ldrb     w8, [x1, #0x53]
00682515C  tbnz     w8, #5, #0x6825168
006825160  ldr      w0, [x20, #0x24]
006825164  b        #0x6825174 ; 
006825168  ldr      x8, [x1, #0x60]
00682516C  mov      x0, x20
006825170  blr      x8
006825174  cmp      w0, #0xc
006825178  b.le     #0x6825190
00682517C  cmp      w0, #0xe
006825180  b.eq     #0x68251a8
006825184  cmp      w0, #0xc9
006825188  b.eq     #0x68251a8
00682518C  b        #0x68251f4 ; 
006825190  b.hi     #0x68251f4
006825194  mov      w8, #1
006825198  lsl      w8, w8, w0
00682519C  mov      w9, #0x102c
0068251A0  tst      w8, w9
0068251A4  b.eq     #0x6825230
0068251A8  adrp     x8, #0x8ee8000
0068251AC  ldr      x8, [x8, #0x910] ; GLOBAL HotFix.Common.BattleLayerManager_TypeInfo
0068251B0  adrp     x21, #0x959b000
0068251B4  ldrb     w9, [x21, #0x78c]
0068251B8  ldr      x8, [x8]
0068251BC  ldr      x8, [x8, #0xb8]
0068251C0  ldr      w20, [x8, #4]
0068251C4  cbnz     w9, #0x68251dc
0068251C8  adrp     x0, #0x8f22000
0068251CC  ldr      x0, [x0, #0xd0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Layer()
0068251D0  bl       #0x382bd14 ; 
0068251D4  mov      w8, #1
0068251D8  strb     w8, [x21, #0x78c]
0068251DC  adrp     x8, #0x8f22000
0068251E0  ldr      x8, [x8, #0xd0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.set_Layer()
0068251E4  ldr      x2, [x8]
0068251E8  ldrb     w8, [x2, #0x53]
0068251EC  tbnz     w8, #5, #0x682520c
0068251F0  str      w20, [x19, #0x21c]
0068251F4  ldp      x20, x19, [sp, #0x40]
0068251F8  ldp      x22, x21, [sp, #0x30]
0068251FC  ldp      x24, x23, [sp, #0x20]
006825200  ldp      x26, x25, [sp, #0x10]
006825204  ldp      x30, x27, [sp], #0x50
006825208  ret      
00682520C  ldr      x3, [x2, #0x60]
006825210  mov      x0, x19
006825214  mov      w1, w20
006825218  ldp      x20, x19, [sp, #0x40]
00682521C  ldp      x22, x21, [sp, #0x30]
006825220  ldp      x24, x23, [sp, #0x20]
006825224  ldp      x26, x25, [sp, #0x10]
006825228  ldp      x30, x27, [sp], #0x50
00682522C  br       x3
006825230  cmp      w0, #1
006825234  b.ne     #0x68251f4
006825238  adrp     x8, #0x8ee8000
00682523C  ldr      x8, [x8, #0x910] ; GLOBAL HotFix.Common.BattleLayerManager_TypeInfo
006825240  adrp     x21, #0x959b000
006825244  ldrb     w9, [x21, #0x78c]
006825248  ldr      x8, [x8]
00682524C  ldr      x8, [x8, #0xb8]
006825250  ldr      w20, [x8, #8]
006825254  cbnz     w9, #0x68251dc
006825258  b        #0x68251c8 ; 
00682525C  bl       #0x382bfb8 ; 
006825260  mov      x0, x19
006825264  mov      x1, xzr
006825268  bl       #0x7c33c40 ; System.Object$$GetType
00682526C  mov      x19, x0
006825270  adrp     x0, #0x8f22000
006825274  ldr      x0, [x0, #0x140] ; GLOBAL {0}Entity table data is not null!
006825278  bl       #0x382bd28 ; 
00682527C  mov      x1, x19
006825280  mov      x2, xzr
006825284  bl       #0x79d140c ; System.String$$Format
006825288  mov      x19, x0
00682528C  adrp     x0, #0x8ebf000
006825290  ldr      x0, [x0, #0xc70] ; GLOBAL System.Exception_TypeInfo
006825294  bl       #0x382bd28 ; 
006825298  bl       #0x382bfa0 ; 
00682529C  mov      x1, x19
0068252A0  mov      x2, xzr
0068252A4  mov      x20, x0
0068252A8  bl       #0x7c15e34 ; System.Exception$$.ctor
0068252AC  adrp     x0, #0x8f22000
0068252B0  ldr      x0, [x0, #0x128] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.SetTableData()
0068252B4  bl       #0x382bd28 ; 
0068252B8  mov      x1, x0
0068252BC  mov      x0, x20
0068252C0  bl       #0x382be7c ; 
0068252C4  mov      x0, x20
0068252C8  bl       #0x382c354 ; 

