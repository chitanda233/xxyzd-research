; HotFix.BattleLogic.EntityCharacterData$$get_IsFollowSprite
; RVA 0x6822AEC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006822AEC  stp      x30, x21, [sp, #-0x20]!
006822AF0  stp      x20, x19, [sp, #0x10]
006822AF4  adrp     x20, #0x959b000
006822AF8  adrp     x21, #0x8f22000
006822AFC  ldrb     w8, [x20, #0x6bd]
006822B00  ldr      x21, [x21, #0x50] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsFollowSprite()
006822B04  mov      x19, x0
006822B08  tbnz     w8, #0, #0x6822b20
006822B0C  adrp     x0, #0x8f22000
006822B10  ldr      x0, [x0, #0x50] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsFollowSprite()
006822B14  bl       #0x382bd14 ; 
006822B18  mov      w8, #1
006822B1C  strb     w8, [x20, #0x6bd]
006822B20  ldr      x1, [x21]
006822B24  ldrb     w8, [x1, #0x53]
006822B28  tbnz     w8, #5, #0x6822b9c
006822B2C  adrp     x20, #0x9591000
006822B30  ldrb     w8, [x20, #0xa73]
006822B34  cbnz     w8, #0x6822b4c
006822B38  adrp     x0, #0x8ee6000
006822B3C  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822B40  bl       #0x382bd14 ; 
006822B44  mov      w8, #1
006822B48  strb     w8, [x20, #0xa73]
006822B4C  adrp     x8, #0x8ee6000
006822B50  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822B54  ldr      x1, [x8]
006822B58  ldrb     w8, [x1, #0x53]
006822B5C  tbnz     w8, #5, #0x6822c00
006822B60  adrp     x20, #0x9591000
006822B64  ldrb     w8, [x20, #0xa74]
006822B68  cbnz     w8, #0x6822b80
006822B6C  adrp     x0, #0x8ee6000
006822B70  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822B74  bl       #0x382bd14 ; 
006822B78  mov      w8, #1
006822B7C  strb     w8, [x20, #0xa74]
006822B80  adrp     x8, #0x8ee6000
006822B84  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822B88  ldr      x1, [x8]
006822B8C  ldrb     w8, [x1, #0x53]
006822B90  tbnz     w8, #5, #0x6822bb0
006822B94  ldr      x19, [x19, #0x170]
006822B98  b        #0x6822bc0 ; 
006822B9C  ldr      x2, [x1, #0x60]
006822BA0  mov      x0, x19
006822BA4  ldp      x20, x19, [sp, #0x10]
006822BA8  ldp      x30, x21, [sp], #0x20
006822BAC  br       x2
006822BB0  ldr      x8, [x1, #0x60]
006822BB4  mov      x0, x19
006822BB8  blr      x8
006822BBC  mov      x19, x0
006822BC0  cbz      x19, #0x6822c20
006822BC4  adrp     x20, #0x9591000
006822BC8  ldrb     w8, [x20, #0xa75]
006822BCC  cbnz     w8, #0x6822be4
006822BD0  adrp     x0, #0x8ee6000
006822BD4  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006822BD8  bl       #0x382bd14 ; 
006822BDC  mov      w8, #1
006822BE0  strb     w8, [x20, #0xa75]
006822BE4  adrp     x8, #0x8ee6000
006822BE8  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006822BEC  ldr      x1, [x8]
006822BF0  ldrb     w8, [x1, #0x53]
006822BF4  tbnz     w8, #5, #0x6822c00
006822BF8  ldr      w0, [x19, #0x24]
006822BFC  b        #0x6822c0c ; 
006822C00  ldr      x8, [x1, #0x60]
006822C04  mov      x0, x19
006822C08  blr      x8
006822C0C  ldp      x20, x19, [sp, #0x10]
006822C10  cmp      w0, #9
006822C14  cset     w0, eq
006822C18  ldp      x30, x21, [sp], #0x20
006822C1C  ret      
006822C20  bl       #0x382bfb8 ; 

