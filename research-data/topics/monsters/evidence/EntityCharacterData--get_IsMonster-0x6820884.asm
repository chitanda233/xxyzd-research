; HotFix.BattleLogic.EntityCharacterData$$get_IsMonster
; RVA 0x6820884; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006820884  stp      x30, x23, [sp, #-0x30]!
006820888  stp      x22, x21, [sp, #0x10]
00682088C  stp      x20, x19, [sp, #0x20]
006820890  adrp     x20, #0x959b000
006820894  adrp     x21, #0x8f09000
006820898  ldrb     w8, [x20, #0x693]
00682089C  ldr      x21, [x21, #0x6f0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsMonster()
0068208A0  mov      x19, x0
0068208A4  tbnz     w8, #0, #0x68208bc
0068208A8  adrp     x0, #0x8f09000
0068208AC  ldr      x0, [x0, #0x6f0] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsMonster()
0068208B0  bl       #0x382bd14 ; 
0068208B4  mov      w8, #1
0068208B8  strb     w8, [x20, #0x693]
0068208BC  ldr      x1, [x21]
0068208C0  ldrb     w8, [x1, #0x53]
0068208C4  tbnz     w8, #5, #0x6820938
0068208C8  adrp     x21, #0x9591000
0068208CC  ldrb     w8, [x21, #0xa73]
0068208D0  cbnz     w8, #0x68208e8
0068208D4  adrp     x0, #0x8ee6000
0068208D8  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0068208DC  bl       #0x382bd14 ; 
0068208E0  mov      w8, #1
0068208E4  strb     w8, [x21, #0xa73]
0068208E8  adrp     x22, #0x8ee6000
0068208EC  ldr      x22, [x22, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0068208F0  ldr      x1, [x22]
0068208F4  ldrb     w8, [x1, #0x53]
0068208F8  tbnz     w8, #5, #0x6820950
0068208FC  adrp     x20, #0x9591000
006820900  ldrb     w8, [x20, #0xa74]
006820904  cbnz     w8, #0x682091c
006820908  adrp     x0, #0x8ee6000
00682090C  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820910  bl       #0x382bd14 ; 
006820914  mov      w8, #1
006820918  strb     w8, [x20, #0xa74]
00682091C  adrp     x8, #0x8ee6000
006820920  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820924  ldr      x1, [x8]
006820928  ldrb     w8, [x1, #0x53]
00682092C  tbnz     w8, #5, #0x682095c
006820930  ldr      x20, [x19, #0x170]
006820934  b        #0x682096c ; 
006820938  ldr      x2, [x1, #0x60]
00682093C  mov      x0, x19
006820940  ldp      x20, x19, [sp, #0x20]
006820944  ldp      x22, x21, [sp, #0x10]
006820948  ldp      x30, x23, [sp], #0x30
00682094C  br       x2
006820950  ldr      x8, [x1, #0x60]
006820954  mov      x0, x19
006820958  b        #0x68209b4 ; 
00682095C  ldr      x8, [x1, #0x60]
006820960  mov      x0, x19
006820964  blr      x8
006820968  mov      x20, x0
00682096C  cbz      x20, #0x6820b74
006820970  adrp     x23, #0x9591000
006820974  ldrb     w8, [x23, #0xa75]
006820978  cbnz     w8, #0x6820990
00682097C  adrp     x0, #0x8ee6000
006820980  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820984  bl       #0x382bd14 ; 
006820988  mov      w8, #1
00682098C  strb     w8, [x23, #0xa75]
006820990  adrp     x8, #0x8ee6000
006820994  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820998  ldr      x1, [x8]
00682099C  ldrb     w8, [x1, #0x53]
0068209A0  tbnz     w8, #5, #0x68209ac
0068209A4  ldr      w0, [x20, #0x24]
0068209A8  b        #0x68209b8 ; 
0068209AC  ldr      x8, [x1, #0x60]
0068209B0  mov      x0, x20
0068209B4  blr      x8
0068209B8  cmp      w0, #2
0068209BC  b.eq     #0x6820a94
0068209C0  ldrb     w8, [x21, #0xa73]
0068209C4  cbnz     w8, #0x68209dc
0068209C8  adrp     x0, #0x8ee6000
0068209CC  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0068209D0  bl       #0x382bd14 ; 
0068209D4  mov      w8, #1
0068209D8  strb     w8, [x21, #0xa73]
0068209DC  ldr      x1, [x22]
0068209E0  ldrb     w8, [x1, #0x53]
0068209E4  tbnz     w8, #5, #0x6820a24
0068209E8  adrp     x20, #0x9591000
0068209EC  ldrb     w8, [x20, #0xa74]
0068209F0  cbnz     w8, #0x6820a08
0068209F4  adrp     x0, #0x8ee6000
0068209F8  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068209FC  bl       #0x382bd14 ; 
006820A00  mov      w8, #1
006820A04  strb     w8, [x20, #0xa74]
006820A08  adrp     x8, #0x8ee6000
006820A0C  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820A10  ldr      x1, [x8]
006820A14  ldrb     w8, [x1, #0x53]
006820A18  tbnz     w8, #5, #0x6820a30
006820A1C  ldr      x20, [x19, #0x170]
006820A20  b        #0x6820a40 ; 
006820A24  ldr      x8, [x1, #0x60]
006820A28  mov      x0, x19
006820A2C  b        #0x6820a88 ; 
006820A30  ldr      x8, [x1, #0x60]
006820A34  mov      x0, x19
006820A38  blr      x8
006820A3C  mov      x20, x0
006820A40  cbz      x20, #0x6820b74
006820A44  adrp     x23, #0x9591000
006820A48  ldrb     w8, [x23, #0xa75]
006820A4C  cbnz     w8, #0x6820a64
006820A50  adrp     x0, #0x8ee6000
006820A54  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820A58  bl       #0x382bd14 ; 
006820A5C  mov      w8, #1
006820A60  strb     w8, [x23, #0xa75]
006820A64  adrp     x8, #0x8ee6000
006820A68  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820A6C  ldr      x1, [x8]
006820A70  ldrb     w8, [x1, #0x53]
006820A74  tbnz     w8, #5, #0x6820a80
006820A78  ldr      w0, [x20, #0x24]
006820A7C  b        #0x6820a8c ; 
006820A80  ldr      x8, [x1, #0x60]
006820A84  mov      x0, x20
006820A88  blr      x8
006820A8C  cmp      w0, #0xc9
006820A90  b.ne     #0x6820a9c
006820A94  mov      w0, #1
006820A98  b        #0x6820b64 ; 
006820A9C  ldrb     w8, [x21, #0xa73]
006820AA0  cbnz     w8, #0x6820ab8
006820AA4  adrp     x0, #0x8ee6000
006820AA8  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006820AAC  bl       #0x382bd14 ; 
006820AB0  mov      w8, #1
006820AB4  strb     w8, [x21, #0xa73]
006820AB8  ldr      x1, [x22]
006820ABC  ldrb     w8, [x1, #0x53]
006820AC0  tbnz     w8, #5, #0x6820b50
006820AC4  adrp     x20, #0x9591000
006820AC8  ldrb     w8, [x20, #0xa74]
006820ACC  cbnz     w8, #0x6820ae4
006820AD0  adrp     x0, #0x8ee6000
006820AD4  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820AD8  bl       #0x382bd14 ; 
006820ADC  mov      w8, #1
006820AE0  strb     w8, [x20, #0xa74]
006820AE4  adrp     x8, #0x8ee6000
006820AE8  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820AEC  ldr      x1, [x8]
006820AF0  ldrb     w8, [x1, #0x53]
006820AF4  tbnz     w8, #5, #0x6820b00
006820AF8  ldr      x19, [x19, #0x170]
006820AFC  b        #0x6820b10 ; 
006820B00  ldr      x8, [x1, #0x60]
006820B04  mov      x0, x19
006820B08  blr      x8
006820B0C  mov      x19, x0
006820B10  cbz      x19, #0x6820b74
006820B14  adrp     x20, #0x9591000
006820B18  ldrb     w8, [x20, #0xa75]
006820B1C  cbnz     w8, #0x6820b34
006820B20  adrp     x0, #0x8ee6000
006820B24  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820B28  bl       #0x382bd14 ; 
006820B2C  mov      w8, #1
006820B30  strb     w8, [x20, #0xa75]
006820B34  adrp     x8, #0x8ee6000
006820B38  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820B3C  ldr      x1, [x8]
006820B40  ldrb     w8, [x1, #0x53]
006820B44  tbnz     w8, #5, #0x6820b50
006820B48  ldr      w0, [x19, #0x24]
006820B4C  b        #0x6820b5c ; 
006820B50  ldr      x8, [x1, #0x60]
006820B54  mov      x0, x19
006820B58  blr      x8
006820B5C  cmp      w0, #3
006820B60  cset     w0, eq
006820B64  ldp      x20, x19, [sp, #0x20]
006820B68  ldp      x22, x21, [sp, #0x10]
006820B6C  ldp      x30, x23, [sp], #0x30
006820B70  ret      
006820B74  bl       #0x382bfb8 ; 

