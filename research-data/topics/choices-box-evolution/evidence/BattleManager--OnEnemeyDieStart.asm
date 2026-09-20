; HotFix.BattleLogic.BattleManager$$OnEnemeyDieStart
; RVA 0x65895A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065895A8  stp      x30, x23, [sp, #-0x30]!
0065895AC  stp      x22, x21, [sp, #0x10]
0065895B0  stp      x20, x19, [sp, #0x20]
0065895B4  adrp     x22, #0x9599000
0065895B8  adrp     x23, #0x8f08000
0065895BC  ldrb     w8, [x22, #0x241]
0065895C0  ldr      x23, [x23, #0x2f0] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.OnEnemeyDieStart() @ 0x923cbe8
0065895C4  mov      x19, x2
0065895C8  mov      x21, x1
0065895CC  mov      x20, x0
0065895D0  tbnz     w8, #0, #0x65895f4
0065895D4  adrp     x0, #0x8f08000
0065895D8  ldr      x0, [x0, #0x2f0] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.OnEnemeyDieStart() @ 0x923cbe8
0065895DC  bl       #0x382bd14 ; 
0065895E0  adrp     x0, #0x8ee6000
0065895E4  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0065895E8  bl       #0x382bd14 ; 
0065895EC  mov      w8, #1
0065895F0  strb     w8, [x22, #0x241]
0065895F4  ldr      x3, [x23]
0065895F8  ldrb     w8, [x3, #0x53]
0065895FC  tbnz     w8, #5, #0x658963c
006589600  adrp     x22, #0x9599000
006589604  ldrb     w8, [x22, #0x286]
006589608  cbnz     w8, #0x6589620
00658960C  adrp     x0, #0x8f07000
006589610  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006589614  bl       #0x382bd14 ; 
006589618  mov      w8, #1
00658961C  strb     w8, [x22, #0x286]
006589620  adrp     x8, #0x8f07000
006589624  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006589628  ldr      x1, [x8]
00658962C  ldrb     w8, [x1, #0x53]
006589630  tbnz     w8, #5, #0x658965c
006589634  ldr      x20, [x20, #0x80]
006589638  b        #0x658966c ; 
00658963C  ldr      x4, [x3, #0x60]
006589640  mov      x0, x20
006589644  mov      x1, x21
006589648  mov      x2, x19
00658964C  ldp      x20, x19, [sp, #0x20]
006589650  ldp      x22, x21, [sp, #0x10]
006589654  ldp      x30, x23, [sp], #0x30
006589658  br       x4
00658965C  ldr      x8, [x1, #0x60]
006589660  mov      x0, x20
006589664  blr      x8
006589668  mov      x20, x0
00658966C  cbz      x21, #0x6589790
006589670  adrp     x8, #0x8ee6000
006589674  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
006589678  ldr      x1, [x8]
00658967C  ldrb     w8, [x1, #0x53]
006589680  tbnz     w8, #5, #0x658968c
006589684  ldr      x21, [x21, #0x38]
006589688  b        #0x658969c ; 
00658968C  ldr      x8, [x1, #0x60]
006589690  mov      x0, x21
006589694  blr      x8
006589698  mov      x21, x0
00658969C  cbz      x21, #0x6589790
0065896A0  adrp     x22, #0x9591000
0065896A4  ldrb     w8, [x22, #0xa73]
0065896A8  cbnz     w8, #0x65896c0
0065896AC  adrp     x0, #0x8ee6000
0065896B0  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType() @ 0x9263340
0065896B4  bl       #0x382bd14 ; 
0065896B8  mov      w8, #1
0065896BC  strb     w8, [x22, #0xa73]
0065896C0  adrp     x8, #0x8ee6000
0065896C4  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType() @ 0x9263340
0065896C8  ldr      x1, [x8]
0065896CC  ldrb     w8, [x1, #0x53]
0065896D0  tbnz     w8, #5, #0x6589760
0065896D4  adrp     x22, #0x9591000
0065896D8  ldrb     w8, [x22, #0xa74]
0065896DC  cbnz     w8, #0x65896f4
0065896E0  adrp     x0, #0x8ee6000
0065896E4  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
0065896E8  bl       #0x382bd14 ; 
0065896EC  mov      w8, #1
0065896F0  strb     w8, [x22, #0xa74]
0065896F4  adrp     x8, #0x8ee6000
0065896F8  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData() @ 0x9263488
0065896FC  ldr      x1, [x8]
006589700  ldrb     w8, [x1, #0x53]
006589704  tbnz     w8, #5, #0x6589710
006589708  ldr      x21, [x21, #0x170]
00658970C  b        #0x6589720 ; 
006589710  ldr      x8, [x1, #0x60]
006589714  mov      x0, x21
006589718  blr      x8
00658971C  mov      x21, x0
006589720  cbz      x21, #0x6589790
006589724  adrp     x22, #0x9591000
006589728  ldrb     w8, [x22, #0xa75]
00658972C  cbnz     w8, #0x6589744
006589730  adrp     x0, #0x8ee6000
006589734  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
006589738  bl       #0x382bd14 ; 
00658973C  mov      w8, #1
006589740  strb     w8, [x22, #0xa75]
006589744  adrp     x8, #0x8ee6000
006589748  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type() @ 0x924f7d8
00658974C  ldr      x1, [x8]
006589750  ldrb     w8, [x1, #0x53]
006589754  tbnz     w8, #5, #0x6589760
006589758  ldr      w1, [x21, #0x24]
00658975C  b        #0x6589770 ; 
006589760  ldr      x8, [x1, #0x60]
006589764  mov      x0, x21
006589768  blr      x8
00658976C  mov      w1, w0
006589770  cbz      x20, #0x6589790
006589774  mov      x0, x20
006589778  mov      x2, x19
00658977C  ldp      x20, x19, [sp, #0x20]
006589780  ldp      x22, x21, [sp, #0x10]
006589784  mov      x3, xzr
006589788  ldp      x30, x23, [sp], #0x30
00658978C  b        #0x6594bc4 ; 
006589790  bl       #0x382bfb8 ; 

