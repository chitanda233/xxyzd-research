; HotFix.BattleLogic.WaterfallBattleManager$$EnemyDieSpecialLogic
; RVA 0x65D4E80; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065D4E80  str      x30, [sp, #-0x50]!
0065D4E84  stp      x26, x25, [sp, #0x10]
0065D4E88  stp      x24, x23, [sp, #0x20]
0065D4E8C  stp      x22, x21, [sp, #0x30]
0065D4E90  stp      x20, x19, [sp, #0x40]
0065D4E94  adrp     x21, #0x9599000
0065D4E98  adrp     x22, #0x8f0a000
0065D4E9C  ldrb     w8, [x21, #0x5a2]
0065D4EA0  ldr      x22, [x22, #0xb18] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.EnemyDieSpecialLogic() @ 0x92c80c0
0065D4EA4  mov      x20, x1
0065D4EA8  mov      x19, x0
0065D4EAC  tbnz     w8, #0, #0x65d4ed0
0065D4EB0  adrp     x0, #0x8ee6000
0065D4EB4  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0065D4EB8  bl       #0x382bd14 ; 
0065D4EBC  adrp     x0, #0x8f0a000
0065D4EC0  ldr      x0, [x0, #0xb18] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.EnemyDieSpecialLogic() @ 0x92c80c0
0065D4EC4  bl       #0x382bd14 ; 
0065D4EC8  mov      w8, #1
0065D4ECC  strb     w8, [x21, #0x5a2]
0065D4ED0  ldr      x2, [x22]
0065D4ED4  ldrb     w8, [x2, #0x53]
0065D4ED8  tbnz     w8, #5, #0x65d4f08
0065D4EDC  mov      x0, x19
0065D4EE0  bl       #0x65d3784 ; HotFix.BattleLogic.WaterfallBattleManager$$CheckStopByEliteOrBossKilled
0065D4EE4  tbz      w0, #0, #0x65d50a4
0065D4EE8  cbz      x20, #0x65d5140
0065D4EEC  adrp     x24, #0x8ee6000
0065D4EF0  ldr      x24, [x24, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0065D4EF4  ldr      x1, [x24]
0065D4EF8  ldrb     w8, [x1, #0x53]
0065D4EFC  tbnz     w8, #5, #0x65d4f2c
0065D4F00  ldr      x21, [x20, #0x38]
0065D4F04  b        #0x65d4f3c ; 
0065D4F08  ldr      x3, [x2, #0x60]
0065D4F0C  mov      x0, x19
0065D4F10  mov      x1, x20
0065D4F14  ldp      x20, x19, [sp, #0x40]
0065D4F18  ldp      x22, x21, [sp, #0x30]
0065D4F1C  ldp      x24, x23, [sp, #0x20]
0065D4F20  ldp      x26, x25, [sp, #0x10]
0065D4F24  ldr      x30, [sp], #0x50
0065D4F28  br       x3
0065D4F2C  ldr      x8, [x1, #0x60]
0065D4F30  mov      x0, x20
0065D4F34  blr      x8
0065D4F38  mov      x21, x0
0065D4F3C  cbz      x21, #0x65d5140
0065D4F40  adrp     x22, #0x9591000
0065D4F44  ldrb     w8, [x22, #0xa74]
0065D4F48  cbnz     w8, #0x65d4f60
0065D4F4C  adrp     x0, #0x8ee6000
0065D4F50  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
0065D4F54  bl       #0x382bd14 ; 
0065D4F58  mov      w8, #1
0065D4F5C  strb     w8, [x22, #0xa74]
0065D4F60  adrp     x25, #0x8ee6000
0065D4F64  ldr      x25, [x25, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
0065D4F68  ldr      x1, [x25]
0065D4F6C  ldrb     w8, [x1, #0x53]
0065D4F70  tbnz     w8, #5, #0x65d4f7c
0065D4F74  ldr      x21, [x21, #0x170]
0065D4F78  b        #0x65d4f8c ; 
0065D4F7C  ldr      x8, [x1, #0x60]
0065D4F80  mov      x0, x21
0065D4F84  blr      x8
0065D4F88  mov      x21, x0
0065D4F8C  cbz      x21, #0x65d5140
0065D4F90  adrp     x23, #0x9591000
0065D4F94  ldrb     w8, [x23, #0xa75]
0065D4F98  cbnz     w8, #0x65d4fb0
0065D4F9C  adrp     x0, #0x8ee6000
0065D4FA0  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
0065D4FA4  bl       #0x382bd14 ; 
0065D4FA8  mov      w8, #1
0065D4FAC  strb     w8, [x23, #0xa75]
0065D4FB0  adrp     x26, #0x8ee6000
0065D4FB4  ldr      x26, [x26, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
0065D4FB8  ldr      x1, [x26]
0065D4FBC  ldrb     w8, [x1, #0x53]
0065D4FC0  tbnz     w8, #5, #0x65d4fcc
0065D4FC4  ldr      w0, [x21, #0x24]
0065D4FC8  b        #0x65d4fd8 ; 
0065D4FCC  ldr      x8, [x1, #0x60]
0065D4FD0  mov      x0, x21
0065D4FD4  blr      x8
0065D4FD8  cmp      w0, #0xc9
0065D4FDC  b.eq     #0x65d5090
0065D4FE0  ldr      x1, [x24]
0065D4FE4  ldrb     w8, [x1, #0x53]
0065D4FE8  tbnz     w8, #5, #0x65d4ff4
0065D4FEC  ldr      x20, [x20, #0x38]
0065D4FF0  b        #0x65d5004 ; 
0065D4FF4  ldr      x8, [x1, #0x60]
0065D4FF8  mov      x0, x20
0065D4FFC  blr      x8
0065D5000  mov      x20, x0
0065D5004  cbz      x20, #0x65d5140
0065D5008  ldrb     w8, [x22, #0xa74]
0065D500C  cbnz     w8, #0x65d5024
0065D5010  adrp     x0, #0x8ee6000
0065D5014  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
0065D5018  bl       #0x382bd14 ; 
0065D501C  mov      w8, #1
0065D5020  strb     w8, [x22, #0xa74]
0065D5024  ldr      x1, [x25]
0065D5028  ldrb     w8, [x1, #0x53]
0065D502C  tbnz     w8, #5, #0x65d5038
0065D5030  ldr      x20, [x20, #0x170]
0065D5034  b        #0x65d5048 ; 
0065D5038  ldr      x8, [x1, #0x60]
0065D503C  mov      x0, x20
0065D5040  blr      x8
0065D5044  mov      x20, x0
0065D5048  cbz      x20, #0x65d5140
0065D504C  ldrb     w8, [x23, #0xa75]
0065D5050  cbnz     w8, #0x65d5068
0065D5054  adrp     x0, #0x8ee6000
0065D5058  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
0065D505C  bl       #0x382bd14 ; 
0065D5060  mov      w8, #1
0065D5064  strb     w8, [x23, #0xa75]
0065D5068  ldr      x1, [x26]
0065D506C  ldrb     w8, [x1, #0x53]
0065D5070  tbnz     w8, #5, #0x65d507c
0065D5074  ldr      w0, [x20, #0x24]
0065D5078  b        #0x65d5088 ; 
0065D507C  ldr      x8, [x1, #0x60]
0065D5080  mov      x0, x20
0065D5084  blr      x8
0065D5088  cmp      w0, #3
0065D508C  b.ne     #0x65d50a4
0065D5090  ldr      w8, [x19, #0x148]
0065D5094  sub      w8, w8, #1
0065D5098  cmp      w8, #0
0065D509C  str      w8, [x19, #0x148]
0065D50A0  b.le     #0x65d50bc
0065D50A4  ldp      x20, x19, [sp, #0x40]
0065D50A8  ldp      x22, x21, [sp, #0x30]
0065D50AC  ldp      x24, x23, [sp, #0x20]
0065D50B0  ldp      x26, x25, [sp, #0x10]
0065D50B4  ldr      x30, [sp], #0x50
0065D50B8  ret      
0065D50BC  mov      x0, x19
0065D50C0  mov      x1, xzr
0065D50C4  bl       #0x65875ac ; HotFix.BattleLogic.BaseSurvivalBattleManager$$EnemySpecialDie
0065D50C8  adrp     x20, #0x9599000
0065D50CC  ldrb     w8, [x20, #0x286]
0065D50D0  cbnz     w8, #0x65d50e8
0065D50D4  adrp     x0, #0x8f07000
0065D50D8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065D50DC  bl       #0x382bd14 ; 
0065D50E0  mov      w8, #1
0065D50E4  strb     w8, [x20, #0x286]
0065D50E8  adrp     x8, #0x8f07000
0065D50EC  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
0065D50F0  ldr      x1, [x8]
0065D50F4  ldrb     w8, [x1, #0x53]
0065D50F8  tbnz     w8, #5, #0x65d5104
0065D50FC  ldr      x0, [x19, #0x80]
0065D5100  b        #0x65d5110 ; 
0065D5104  ldr      x8, [x1, #0x60]
0065D5108  mov      x0, x19
0065D510C  blr      x8
0065D5110  cbz      x0, #0x65d5140
0065D5114  ldr      w1, [x19, #0x138]
0065D5118  mov      x2, xzr
0065D511C  bl       #0x6a01c08 ; HotFix.BattleLogic.BattleWorldContext$$SetCurMissionId
0065D5120  mov      x0, x19
0065D5124  ldp      x20, x19, [sp, #0x40]
0065D5128  ldp      x22, x21, [sp, #0x30]
0065D512C  ldp      x24, x23, [sp, #0x20]
0065D5130  ldp      x26, x25, [sp, #0x10]
0065D5134  mov      x1, xzr
0065D5138  ldr      x30, [sp], #0x50
0065D513C  b        #0x658783c ; HotFix.BattleLogic.BaseSurvivalBattleManager$$ClearMonsterCreateData
0065D5140  bl       #0x382bfb8 ; 

