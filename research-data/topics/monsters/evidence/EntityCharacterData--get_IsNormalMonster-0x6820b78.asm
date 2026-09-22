; HotFix.BattleLogic.EntityCharacterData$$get_IsNormalMonster
; RVA 0x6820B78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006820B78  stp      x30, x23, [sp, #-0x30]!
006820B7C  stp      x22, x21, [sp, #0x10]
006820B80  stp      x20, x19, [sp, #0x20]
006820B84  adrp     x20, #0x959b000
006820B88  adrp     x21, #0x8f08000
006820B8C  ldrb     w8, [x20, #0x694]
006820B90  ldr      x21, [x21, #0x818] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsNormalMonster()
006820B94  mov      x19, x0
006820B98  tbnz     w8, #0, #0x6820bb0
006820B9C  adrp     x0, #0x8f08000
006820BA0  ldr      x0, [x0, #0x818] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsNormalMonster()
006820BA4  bl       #0x382bd14 ; 
006820BA8  mov      w8, #1
006820BAC  strb     w8, [x20, #0x694]
006820BB0  ldr      x1, [x21]
006820BB4  ldrb     w8, [x1, #0x53]
006820BB8  tbnz     w8, #5, #0x6820c2c
006820BBC  adrp     x21, #0x9591000
006820BC0  ldrb     w8, [x21, #0xa73]
006820BC4  cbnz     w8, #0x6820bdc
006820BC8  adrp     x0, #0x8ee6000
006820BCC  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006820BD0  bl       #0x382bd14 ; 
006820BD4  mov      w8, #1
006820BD8  strb     w8, [x21, #0xa73]
006820BDC  adrp     x22, #0x8ee6000
006820BE0  ldr      x22, [x22, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006820BE4  ldr      x1, [x22]
006820BE8  ldrb     w8, [x1, #0x53]
006820BEC  tbnz     w8, #5, #0x6820c44
006820BF0  adrp     x20, #0x9591000
006820BF4  ldrb     w8, [x20, #0xa74]
006820BF8  cbnz     w8, #0x6820c10
006820BFC  adrp     x0, #0x8ee6000
006820C00  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820C04  bl       #0x382bd14 ; 
006820C08  mov      w8, #1
006820C0C  strb     w8, [x20, #0xa74]
006820C10  adrp     x8, #0x8ee6000
006820C14  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820C18  ldr      x1, [x8]
006820C1C  ldrb     w8, [x1, #0x53]
006820C20  tbnz     w8, #5, #0x6820c50
006820C24  ldr      x20, [x19, #0x170]
006820C28  b        #0x6820c60 ; 
006820C2C  ldr      x2, [x1, #0x60]
006820C30  mov      x0, x19
006820C34  ldp      x20, x19, [sp, #0x20]
006820C38  ldp      x22, x21, [sp, #0x10]
006820C3C  ldp      x30, x23, [sp], #0x30
006820C40  br       x2
006820C44  ldr      x8, [x1, #0x60]
006820C48  mov      x0, x19
006820C4C  b        #0x6820ca8 ; 
006820C50  ldr      x8, [x1, #0x60]
006820C54  mov      x0, x19
006820C58  blr      x8
006820C5C  mov      x20, x0
006820C60  cbz      x20, #0x6820d94
006820C64  adrp     x23, #0x9591000
006820C68  ldrb     w8, [x23, #0xa75]
006820C6C  cbnz     w8, #0x6820c84
006820C70  adrp     x0, #0x8ee6000
006820C74  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820C78  bl       #0x382bd14 ; 
006820C7C  mov      w8, #1
006820C80  strb     w8, [x23, #0xa75]
006820C84  adrp     x8, #0x8ee6000
006820C88  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820C8C  ldr      x1, [x8]
006820C90  ldrb     w8, [x1, #0x53]
006820C94  tbnz     w8, #5, #0x6820ca0
006820C98  ldr      w0, [x20, #0x24]
006820C9C  b        #0x6820cac ; 
006820CA0  ldr      x8, [x1, #0x60]
006820CA4  mov      x0, x20
006820CA8  blr      x8
006820CAC  cmp      w0, #2
006820CB0  b.ne     #0x6820cbc
006820CB4  mov      w0, #1
006820CB8  b        #0x6820d84 ; 
006820CBC  ldrb     w8, [x21, #0xa73]
006820CC0  cbnz     w8, #0x6820cd8
006820CC4  adrp     x0, #0x8ee6000
006820CC8  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006820CCC  bl       #0x382bd14 ; 
006820CD0  mov      w8, #1
006820CD4  strb     w8, [x21, #0xa73]
006820CD8  ldr      x1, [x22]
006820CDC  ldrb     w8, [x1, #0x53]
006820CE0  tbnz     w8, #5, #0x6820d70
006820CE4  adrp     x20, #0x9591000
006820CE8  ldrb     w8, [x20, #0xa74]
006820CEC  cbnz     w8, #0x6820d04
006820CF0  adrp     x0, #0x8ee6000
006820CF4  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820CF8  bl       #0x382bd14 ; 
006820CFC  mov      w8, #1
006820D00  strb     w8, [x20, #0xa74]
006820D04  adrp     x8, #0x8ee6000
006820D08  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820D0C  ldr      x1, [x8]
006820D10  ldrb     w8, [x1, #0x53]
006820D14  tbnz     w8, #5, #0x6820d20
006820D18  ldr      x19, [x19, #0x170]
006820D1C  b        #0x6820d30 ; 
006820D20  ldr      x8, [x1, #0x60]
006820D24  mov      x0, x19
006820D28  blr      x8
006820D2C  mov      x19, x0
006820D30  cbz      x19, #0x6820d94
006820D34  adrp     x20, #0x9591000
006820D38  ldrb     w8, [x20, #0xa75]
006820D3C  cbnz     w8, #0x6820d54
006820D40  adrp     x0, #0x8ee6000
006820D44  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820D48  bl       #0x382bd14 ; 
006820D4C  mov      w8, #1
006820D50  strb     w8, [x20, #0xa75]
006820D54  adrp     x8, #0x8ee6000
006820D58  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820D5C  ldr      x1, [x8]
006820D60  ldrb     w8, [x1, #0x53]
006820D64  tbnz     w8, #5, #0x6820d70
006820D68  ldr      w0, [x19, #0x24]
006820D6C  b        #0x6820d7c ; 
006820D70  ldr      x8, [x1, #0x60]
006820D74  mov      x0, x19
006820D78  blr      x8
006820D7C  cmp      w0, #0xc9
006820D80  cset     w0, eq
006820D84  ldp      x20, x19, [sp, #0x20]
006820D88  ldp      x22, x21, [sp, #0x10]
006820D8C  ldp      x30, x23, [sp], #0x30
006820D90  ret      
006820D94  bl       #0x382bfb8 ; 

