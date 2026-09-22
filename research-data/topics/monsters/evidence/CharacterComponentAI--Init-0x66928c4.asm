; HotFix.BattleLogic.CharacterComponentAI$$Init
; RVA 0x66928C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066928C4  str      x30, [sp, #-0x40]!
0066928C8  stp      x24, x23, [sp, #0x10]
0066928CC  stp      x22, x21, [sp, #0x20]
0066928D0  stp      x20, x19, [sp, #0x30]
0066928D4  adrp     x20, #0x959a000
0066928D8  adrp     x21, #0x8f10000
0066928DC  ldrb     w8, [x20, #0x3c]
0066928E0  ldr      x21, [x21, #0x9b8] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.Init()
0066928E4  mov      x19, x0
0066928E8  tbnz     w8, #0, #0x6692918
0066928EC  adrp     x0, #0x8f10000
0066928F0  ldr      x0, [x0, #0x9b8] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.Init()
0066928F4  bl       #0x382bd14 ; 
0066928F8  adrp     x0, #0x8ee6000
0066928FC  ldr      x0, [x0, #0x600] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityCharacter>.get_Data()
006692900  bl       #0x382bd14 ; 
006692904  adrp     x0, #0x8ee6000
006692908  ldr      x0, [x0, #0x608] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityCharacter>.get_Entity()
00669290C  bl       #0x382bd14 ; 
006692910  mov      w8, #1
006692914  strb     w8, [x20, #0x3c]
006692918  ldr      x1, [x21]
00669291C  ldrb     w8, [x1, #0x53]
006692920  tbnz     w8, #5, #0x6692960
006692924  adrp     x23, #0x9591000
006692928  ldrb     w8, [x23, #0xa4b]
00669292C  cbnz     w8, #0x6692944
006692930  adrp     x0, #0x8ee5000
006692934  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006692938  bl       #0x382bd14 ; 
00669293C  mov      w8, #1
006692940  strb     w8, [x23, #0xa4b]
006692944  adrp     x24, #0x8ee5000
006692948  ldr      x24, [x24, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
00669294C  ldr      x1, [x24]
006692950  ldrb     w8, [x1, #0x53]
006692954  tbnz     w8, #5, #0x669297c
006692958  ldr      x20, [x19, #0x20]
00669295C  b        #0x669298c ; 
006692960  ldr      x2, [x1, #0x60]
006692964  mov      x0, x19
006692968  ldp      x20, x19, [sp, #0x30]
00669296C  ldp      x22, x21, [sp, #0x20]
006692970  ldp      x24, x23, [sp, #0x10]
006692974  ldr      x30, [sp], #0x40
006692978  br       x2
00669297C  ldr      x8, [x1, #0x60]
006692980  mov      x0, x19
006692984  blr      x8
006692988  mov      x20, x0
00669298C  cbz      x20, #0x6692bc0
006692990  adrp     x21, #0x9598000
006692994  ldrb     w8, [x21, #0xfc4]
006692998  cbnz     w8, #0x66929b0
00669299C  adrp     x0, #0x8f05000
0066929A0  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr()
0066929A4  bl       #0x382bd14 ; 
0066929A8  mov      w8, #1
0066929AC  strb     w8, [x21, #0xfc4]
0066929B0  adrp     x8, #0x8f05000
0066929B4  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr()
0066929B8  ldr      x1, [x8]
0066929BC  ldrb     w8, [x1, #0x53]
0066929C0  tbnz     w8, #5, #0x66929cc
0066929C4  ldr      x0, [x20, #0x220]
0066929C8  b        #0x66929d8 ; 
0066929CC  ldr      x8, [x1, #0x60]
0066929D0  mov      x0, x20
0066929D4  blr      x8
0066929D8  cbz      x0, #0x6692bc0
0066929DC  mov      x1, xzr
0066929E0  bl       #0x658fb98 ; HotFix.BattleLogic.BattleManager$$get_BattleChapterConfigDataType
0066929E4  adrp     x21, #0x8ee6000
0066929E8  ldr      x21, [x21, #0x600] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityCharacter>.get_Data()
0066929EC  mov      w20, w0
0066929F0  ldr      x1, [x21]
0066929F4  ldrb     w8, [x1, #0x53]
0066929F8  tbnz     w8, #5, #0x6692a04
0066929FC  ldr      x0, [x19, #0x38]
006692A00  b        #0x6692a10 ; 
006692A04  ldr      x8, [x1, #0x60]
006692A08  mov      x0, x19
006692A0C  blr      x8
006692A10  cbz      x0, #0x6692bc0
006692A14  ldr      x0, [x0, #0x1b0]
006692A18  mov      x1, xzr
006692A1C  bl       #0x79e2368 ; System.String$$IsNullOrEmpty
006692A20  ldr      x1, [x21]
006692A24  mov      w22, w0
006692A28  ldrb     w8, [x1, #0x53]
006692A2C  tbnz     w8, #5, #0x6692a38
006692A30  ldr      x21, [x19, #0x38]
006692A34  b        #0x6692a48 ; 
006692A38  ldr      x8, [x1, #0x60]
006692A3C  mov      x0, x19
006692A40  blr      x8
006692A44  mov      x21, x0
006692A48  cbz      x21, #0x6692bc0
006692A4C  tbz      w22, #0, #0x6692a8c
006692A50  adrp     x22, #0x9591000
006692A54  ldrb     w8, [x22, #0xa74]
006692A58  cbnz     w8, #0x6692a70
006692A5C  adrp     x0, #0x8ee6000
006692A60  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006692A64  bl       #0x382bd14 ; 
006692A68  mov      w8, #1
006692A6C  strb     w8, [x22, #0xa74]
006692A70  adrp     x8, #0x8ee6000
006692A74  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006692A78  ldr      x1, [x8]
006692A7C  ldrb     w8, [x1, #0x53]
006692A80  tbnz     w8, #5, #0x6692a94
006692A84  ldr      x0, [x21, #0x170]
006692A88  b        #0x6692aa0 ; 
006692A8C  ldr      x20, [x21, #0x1b0]
006692A90  b        #0x6692ab0 ; 
006692A94  ldr      x8, [x1, #0x60]
006692A98  mov      x0, x21
006692A9C  blr      x8
006692AA0  mov      w1, w20
006692AA4  mov      x2, xzr
006692AA8  bl       #0x691efc0 ; HotFix.BattleLogic.GameUtils$$GetAIId
006692AAC  mov      x20, x0
006692AB0  ldrb     w8, [x23, #0xa4b]
006692AB4  cbnz     w8, #0x6692acc
006692AB8  adrp     x0, #0x8ee5000
006692ABC  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006692AC0  bl       #0x382bd14 ; 
006692AC4  mov      w8, #1
006692AC8  strb     w8, [x23, #0xa4b]
006692ACC  ldr      x1, [x24]
006692AD0  ldrb     w8, [x1, #0x53]
006692AD4  tbnz     w8, #5, #0x6692ae0
006692AD8  ldr      x21, [x19, #0x20]
006692ADC  b        #0x6692af0 ; 
006692AE0  ldr      x8, [x1, #0x60]
006692AE4  mov      x0, x19
006692AE8  blr      x8
006692AEC  mov      x21, x0
006692AF0  cbz      x21, #0x6692bc0
006692AF4  adrp     x22, #0x9591000
006692AF8  ldrb     w8, [x22, #0xa4c]
006692AFC  cbnz     w8, #0x6692b14
006692B00  adrp     x0, #0x8ee5000
006692B04  ldr      x0, [x0, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
006692B08  bl       #0x382bd14 ; 
006692B0C  mov      w8, #1
006692B10  strb     w8, [x22, #0xa4c]
006692B14  adrp     x8, #0x8ee5000
006692B18  ldr      x8, [x8, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
006692B1C  ldr      x1, [x8]
006692B20  ldrb     w8, [x1, #0x53]
006692B24  tbnz     w8, #5, #0x6692b30
006692B28  ldr      x0, [x21, #0x210]
006692B2C  b        #0x6692b3c ; 
006692B30  ldr      x8, [x1, #0x60]
006692B34  mov      x0, x21
006692B38  blr      x8
006692B3C  cbz      x0, #0x6692bc0
006692B40  mov      x1, x20
006692B44  mov      x2, xzr
006692B48  bl       #0x6a42860 ; HotFix.BattleLogic.WorldElementCreator$$CreateNewAI
006692B4C  mov      x1, x0
006692B50  mov      x20, x19
006692B54  str      x1, [x20, #0x40]!
006692B58  mov      x0, x20
006692B5C  bl       #0x382bcb8 ; 
006692B60  adrp     x8, #0x8ee6000
006692B64  ldr      x8, [x8, #0x608] ; GLOBAL Method$HotFix.BattleLogic.EntityComponentBase<EntityCharacterData, EntityCharacter>.get_Entity()
006692B68  ldr      x21, [x20]
006692B6C  ldr      x1, [x8]
006692B70  ldrb     w8, [x1, #0x53]
006692B74  tbnz     w8, #5, #0x6692b80
006692B78  ldr      x1, [x19, #0x30]
006692B7C  b        #0x6692b90 ; 
006692B80  ldr      x8, [x1, #0x60]
006692B84  mov      x0, x19
006692B88  blr      x8
006692B8C  mov      x1, x0
006692B90  cbz      x21, #0x6692bc0
006692B94  mov      x0, x21
006692B98  mov      x2, xzr
006692B9C  bl       #0x6b8db54 ; HotFix.BattleLogic.AIStateController$$SetEntity
006692BA0  ldr      x0, [x20]
006692BA4  cbz      x0, #0x6692bc0
006692BA8  ldp      x20, x19, [sp, #0x30]
006692BAC  ldp      x22, x21, [sp, #0x20]
006692BB0  ldp      x24, x23, [sp, #0x10]
006692BB4  mov      x1, xzr
006692BB8  ldr      x30, [sp], #0x40
006692BBC  b        #0x6b8ec24 ; HotFix.BattleLogic.AIStateController$$Init
006692BC0  bl       #0x382bfb8 ; 

