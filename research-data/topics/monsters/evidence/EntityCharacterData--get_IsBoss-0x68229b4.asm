; HotFix.BattleLogic.EntityCharacterData$$get_IsBoss
; RVA 0x68229B4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068229B4  stp      x30, x21, [sp, #-0x20]!
0068229B8  stp      x20, x19, [sp, #0x10]
0068229BC  adrp     x20, #0x959b000
0068229C0  adrp     x21, #0x8f0f000
0068229C4  ldrb     w8, [x20, #0x6bc]
0068229C8  ldr      x21, [x21, #0x600] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsBoss()
0068229CC  mov      x19, x0
0068229D0  tbnz     w8, #0, #0x68229e8
0068229D4  adrp     x0, #0x8f0f000
0068229D8  ldr      x0, [x0, #0x600] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsBoss()
0068229DC  bl       #0x382bd14 ; 
0068229E0  mov      w8, #1
0068229E4  strb     w8, [x20, #0x6bc]
0068229E8  ldr      x1, [x21]
0068229EC  ldrb     w8, [x1, #0x53]
0068229F0  tbnz     w8, #5, #0x6822a64
0068229F4  adrp     x20, #0x9591000
0068229F8  ldrb     w8, [x20, #0xa73]
0068229FC  cbnz     w8, #0x6822a14
006822A00  adrp     x0, #0x8ee6000
006822A04  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822A08  bl       #0x382bd14 ; 
006822A0C  mov      w8, #1
006822A10  strb     w8, [x20, #0xa73]
006822A14  adrp     x8, #0x8ee6000
006822A18  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822A1C  ldr      x1, [x8]
006822A20  ldrb     w8, [x1, #0x53]
006822A24  tbnz     w8, #5, #0x6822ac8
006822A28  adrp     x20, #0x9591000
006822A2C  ldrb     w8, [x20, #0xa74]
006822A30  cbnz     w8, #0x6822a48
006822A34  adrp     x0, #0x8ee6000
006822A38  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822A3C  bl       #0x382bd14 ; 
006822A40  mov      w8, #1
006822A44  strb     w8, [x20, #0xa74]
006822A48  adrp     x8, #0x8ee6000
006822A4C  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822A50  ldr      x1, [x8]
006822A54  ldrb     w8, [x1, #0x53]
006822A58  tbnz     w8, #5, #0x6822a78
006822A5C  ldr      x19, [x19, #0x170]
006822A60  b        #0x6822a88 ; 
006822A64  ldr      x2, [x1, #0x60]
006822A68  mov      x0, x19
006822A6C  ldp      x20, x19, [sp, #0x10]
006822A70  ldp      x30, x21, [sp], #0x20
006822A74  br       x2
006822A78  ldr      x8, [x1, #0x60]
006822A7C  mov      x0, x19
006822A80  blr      x8
006822A84  mov      x19, x0
006822A88  cbz      x19, #0x6822ae8
006822A8C  adrp     x20, #0x9591000
006822A90  ldrb     w8, [x20, #0xa75]
006822A94  cbnz     w8, #0x6822aac
006822A98  adrp     x0, #0x8ee6000
006822A9C  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006822AA0  bl       #0x382bd14 ; 
006822AA4  mov      w8, #1
006822AA8  strb     w8, [x20, #0xa75]
006822AAC  adrp     x8, #0x8ee6000
006822AB0  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006822AB4  ldr      x1, [x8]
006822AB8  ldrb     w8, [x1, #0x53]
006822ABC  tbnz     w8, #5, #0x6822ac8
006822AC0  ldr      w0, [x19, #0x24]
006822AC4  b        #0x6822ad4 ; 
006822AC8  ldr      x8, [x1, #0x60]
006822ACC  mov      x0, x19
006822AD0  blr      x8
006822AD4  ldp      x20, x19, [sp, #0x10]
006822AD8  cmp      w0, #3
006822ADC  cset     w0, eq
006822AE0  ldp      x30, x21, [sp], #0x20
006822AE4  ret      
006822AE8  bl       #0x382bfb8 ; 

