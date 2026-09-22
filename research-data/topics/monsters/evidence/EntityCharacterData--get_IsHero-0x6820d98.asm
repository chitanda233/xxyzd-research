; HotFix.BattleLogic.EntityCharacterData$$get_IsHero
; RVA 0x6820D98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006820D98  stp      x30, x21, [sp, #-0x20]!
006820D9C  stp      x20, x19, [sp, #0x10]
006820DA0  adrp     x20, #0x959b000
006820DA4  adrp     x21, #0x8ee6000
006820DA8  ldrb     w8, [x20, #0x695]
006820DAC  ldr      x21, [x21, #0x788] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsHero()
006820DB0  mov      x19, x0
006820DB4  tbnz     w8, #0, #0x6820dcc
006820DB8  adrp     x0, #0x8ee6000
006820DBC  ldr      x0, [x0, #0x788] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsHero()
006820DC0  bl       #0x382bd14 ; 
006820DC4  mov      w8, #1
006820DC8  strb     w8, [x20, #0x695]
006820DCC  ldr      x1, [x21]
006820DD0  ldrb     w8, [x1, #0x53]
006820DD4  tbnz     w8, #5, #0x6820e48
006820DD8  adrp     x20, #0x9591000
006820DDC  ldrb     w8, [x20, #0xa73]
006820DE0  cbnz     w8, #0x6820df8
006820DE4  adrp     x0, #0x8ee6000
006820DE8  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006820DEC  bl       #0x382bd14 ; 
006820DF0  mov      w8, #1
006820DF4  strb     w8, [x20, #0xa73]
006820DF8  adrp     x8, #0x8ee6000
006820DFC  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006820E00  ldr      x1, [x8]
006820E04  ldrb     w8, [x1, #0x53]
006820E08  tbnz     w8, #5, #0x6820eac
006820E0C  adrp     x20, #0x9591000
006820E10  ldrb     w8, [x20, #0xa74]
006820E14  cbnz     w8, #0x6820e2c
006820E18  adrp     x0, #0x8ee6000
006820E1C  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820E20  bl       #0x382bd14 ; 
006820E24  mov      w8, #1
006820E28  strb     w8, [x20, #0xa74]
006820E2C  adrp     x8, #0x8ee6000
006820E30  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820E34  ldr      x1, [x8]
006820E38  ldrb     w8, [x1, #0x53]
006820E3C  tbnz     w8, #5, #0x6820e5c
006820E40  ldr      x19, [x19, #0x170]
006820E44  b        #0x6820e6c ; 
006820E48  ldr      x2, [x1, #0x60]
006820E4C  mov      x0, x19
006820E50  ldp      x20, x19, [sp, #0x10]
006820E54  ldp      x30, x21, [sp], #0x20
006820E58  br       x2
006820E5C  ldr      x8, [x1, #0x60]
006820E60  mov      x0, x19
006820E64  blr      x8
006820E68  mov      x19, x0
006820E6C  cbz      x19, #0x6820ecc
006820E70  adrp     x20, #0x9591000
006820E74  ldrb     w8, [x20, #0xa75]
006820E78  cbnz     w8, #0x6820e90
006820E7C  adrp     x0, #0x8ee6000
006820E80  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820E84  bl       #0x382bd14 ; 
006820E88  mov      w8, #1
006820E8C  strb     w8, [x20, #0xa75]
006820E90  adrp     x8, #0x8ee6000
006820E94  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820E98  ldr      x1, [x8]
006820E9C  ldrb     w8, [x1, #0x53]
006820EA0  tbnz     w8, #5, #0x6820eac
006820EA4  ldr      w0, [x19, #0x24]
006820EA8  b        #0x6820eb8 ; 
006820EAC  ldr      x8, [x1, #0x60]
006820EB0  mov      x0, x19
006820EB4  blr      x8
006820EB8  ldp      x20, x19, [sp, #0x10]
006820EBC  cmp      w0, #1
006820EC0  cset     w0, eq
006820EC4  ldp      x30, x21, [sp], #0x20
006820EC8  ret      
006820ECC  bl       #0x382bfb8 ; 

