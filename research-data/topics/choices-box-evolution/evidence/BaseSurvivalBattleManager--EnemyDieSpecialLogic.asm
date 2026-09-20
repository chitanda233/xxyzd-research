; HotFix.BattleLogic.BaseSurvivalBattleManager$$EnemyDieSpecialLogic
; RVA 0x6588F5C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006588F5C  str      x30, [sp, #-0x30]!
006588F60  stp      x22, x21, [sp, #0x10]
006588F64  stp      x20, x19, [sp, #0x20]
006588F68  adrp     x21, #0x9599000
006588F6C  adrp     x22, #0x8f08000
006588F70  ldrb     w8, [x21, #0x18d]
006588F74  ldr      x22, [x22, #0x2b0] ; GLOBAL Method$HotFix.BattleLogic.BaseSurvivalBattleManager.EnemyDieSpecialLogic() @ 0x923baa8
006588F78  mov      x20, x1
006588F7C  mov      x19, x0
006588F80  tbnz     w8, #0, #0x6588fa4
006588F84  adrp     x0, #0x8f08000
006588F88  ldr      x0, [x0, #0x2b0] ; GLOBAL Method$HotFix.BattleLogic.BaseSurvivalBattleManager.EnemyDieSpecialLogic() @ 0x923baa8
006588F8C  bl       #0x382bd14 ; 
006588F90  adrp     x0, #0x8ee6000
006588F94  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006588F98  bl       #0x382bd14 ; 
006588F9C  mov      w8, #1
006588FA0  strb     w8, [x21, #0x18d]
006588FA4  ldr      x2, [x22]
006588FA8  ldrb     w8, [x2, #0x53]
006588FAC  tbnz     w8, #5, #0x6588fd0
006588FB0  cbz      x20, #0x65890c4
006588FB4  adrp     x8, #0x8ee6000
006588FB8  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006588FBC  ldr      x1, [x8]
006588FC0  ldrb     w8, [x1, #0x53]
006588FC4  tbnz     w8, #5, #0x6588fec
006588FC8  ldr      x20, [x20, #0x38]
006588FCC  b        #0x6588ffc ; 
006588FD0  ldr      x3, [x2, #0x60]
006588FD4  mov      x0, x19
006588FD8  mov      x1, x20
006588FDC  ldp      x20, x19, [sp, #0x20]
006588FE0  ldp      x22, x21, [sp, #0x10]
006588FE4  ldr      x30, [sp], #0x30
006588FE8  br       x3
006588FEC  ldr      x8, [x1, #0x60]
006588FF0  mov      x0, x20
006588FF4  blr      x8
006588FF8  mov      x20, x0
006588FFC  cbz      x20, #0x65890c4
006589000  adrp     x21, #0x9591000
006589004  ldrb     w8, [x21, #0xa74]
006589008  cbnz     w8, #0x6589020
00658900C  adrp     x0, #0x8ee6000
006589010  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
006589014  bl       #0x382bd14 ; 
006589018  mov      w8, #1
00658901C  strb     w8, [x21, #0xa74]
006589020  adrp     x8, #0x8ee6000
006589024  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
006589028  ldr      x1, [x8]
00658902C  ldrb     w8, [x1, #0x53]
006589030  tbnz     w8, #5, #0x658903c
006589034  ldr      x20, [x20, #0x170]
006589038  b        #0x658904c ; 
00658903C  ldr      x8, [x1, #0x60]
006589040  mov      x0, x20
006589044  blr      x8
006589048  mov      x20, x0
00658904C  cbz      x20, #0x65890c4
006589050  adrp     x21, #0x9591000
006589054  ldrb     w8, [x21, #0xa75]
006589058  cbnz     w8, #0x6589070
00658905C  adrp     x0, #0x8ee6000
006589060  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
006589064  bl       #0x382bd14 ; 
006589068  mov      w8, #1
00658906C  strb     w8, [x21, #0xa75]
006589070  adrp     x8, #0x8ee6000
006589074  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
006589078  ldr      x1, [x8]
00658907C  ldrb     w8, [x1, #0x53]
006589080  tbnz     w8, #5, #0x658908c
006589084  ldr      w0, [x20, #0x24]
006589088  b        #0x6589098 ; 
00658908C  ldr      x8, [x1, #0x60]
006589090  mov      x0, x20
006589094  blr      x8
006589098  cmp      w0, #3
00658909C  b.ne     #0x65890b4
0065890A0  mov      x0, x19
0065890A4  ldp      x20, x19, [sp, #0x20]
0065890A8  ldp      x22, x21, [sp, #0x10]
0065890AC  ldr      x30, [sp], #0x30
0065890B0  b        #0x658783c ; HotFix.BattleLogic.BaseSurvivalBattleManager$$ClearMonsterCreateData
0065890B4  ldp      x20, x19, [sp, #0x20]
0065890B8  ldp      x22, x21, [sp, #0x10]
0065890BC  ldr      x30, [sp], #0x30
0065890C0  ret      
0065890C4  bl       #0x382bfb8 ; 

