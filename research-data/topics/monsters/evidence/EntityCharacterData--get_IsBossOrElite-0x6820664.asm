; HotFix.BattleLogic.EntityCharacterData$$get_IsBossOrElite
; RVA 0x6820664; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006820664  stp      x30, x23, [sp, #-0x30]!
006820668  stp      x22, x21, [sp, #0x10]
00682066C  stp      x20, x19, [sp, #0x20]
006820670  adrp     x20, #0x959b000
006820674  adrp     x21, #0x8f1e000
006820678  ldrb     w8, [x20, #0x692]
00682067C  ldr      x21, [x21, #0xc20] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsBossOrElite()
006820680  mov      x19, x0
006820684  tbnz     w8, #0, #0x682069c
006820688  adrp     x0, #0x8f1e000
00682068C  ldr      x0, [x0, #0xc20] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsBossOrElite()
006820690  bl       #0x382bd14 ; 
006820694  mov      w8, #1
006820698  strb     w8, [x20, #0x692]
00682069C  ldr      x1, [x21]
0068206A0  ldrb     w8, [x1, #0x53]
0068206A4  tbnz     w8, #5, #0x6820718
0068206A8  adrp     x21, #0x9591000
0068206AC  ldrb     w8, [x21, #0xa73]
0068206B0  cbnz     w8, #0x68206c8
0068206B4  adrp     x0, #0x8ee6000
0068206B8  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0068206BC  bl       #0x382bd14 ; 
0068206C0  mov      w8, #1
0068206C4  strb     w8, [x21, #0xa73]
0068206C8  adrp     x22, #0x8ee6000
0068206CC  ldr      x22, [x22, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0068206D0  ldr      x1, [x22]
0068206D4  ldrb     w8, [x1, #0x53]
0068206D8  tbnz     w8, #5, #0x6820730
0068206DC  adrp     x20, #0x9591000
0068206E0  ldrb     w8, [x20, #0xa74]
0068206E4  cbnz     w8, #0x68206fc
0068206E8  adrp     x0, #0x8ee6000
0068206EC  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068206F0  bl       #0x382bd14 ; 
0068206F4  mov      w8, #1
0068206F8  strb     w8, [x20, #0xa74]
0068206FC  adrp     x8, #0x8ee6000
006820700  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006820704  ldr      x1, [x8]
006820708  ldrb     w8, [x1, #0x53]
00682070C  tbnz     w8, #5, #0x682073c
006820710  ldr      x20, [x19, #0x170]
006820714  b        #0x682074c ; 
006820718  ldr      x2, [x1, #0x60]
00682071C  mov      x0, x19
006820720  ldp      x20, x19, [sp, #0x20]
006820724  ldp      x22, x21, [sp, #0x10]
006820728  ldp      x30, x23, [sp], #0x30
00682072C  br       x2
006820730  ldr      x8, [x1, #0x60]
006820734  mov      x0, x19
006820738  b        #0x6820794 ; 
00682073C  ldr      x8, [x1, #0x60]
006820740  mov      x0, x19
006820744  blr      x8
006820748  mov      x20, x0
00682074C  cbz      x20, #0x6820880
006820750  adrp     x23, #0x9591000
006820754  ldrb     w8, [x23, #0xa75]
006820758  cbnz     w8, #0x6820770
00682075C  adrp     x0, #0x8ee6000
006820760  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820764  bl       #0x382bd14 ; 
006820768  mov      w8, #1
00682076C  strb     w8, [x23, #0xa75]
006820770  adrp     x8, #0x8ee6000
006820774  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820778  ldr      x1, [x8]
00682077C  ldrb     w8, [x1, #0x53]
006820780  tbnz     w8, #5, #0x682078c
006820784  ldr      w0, [x20, #0x24]
006820788  b        #0x6820798 ; 
00682078C  ldr      x8, [x1, #0x60]
006820790  mov      x0, x20
006820794  blr      x8
006820798  cmp      w0, #3
00682079C  b.ne     #0x68207a8
0068207A0  mov      w0, #1
0068207A4  b        #0x6820870 ; 
0068207A8  ldrb     w8, [x21, #0xa73]
0068207AC  cbnz     w8, #0x68207c4
0068207B0  adrp     x0, #0x8ee6000
0068207B4  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0068207B8  bl       #0x382bd14 ; 
0068207BC  mov      w8, #1
0068207C0  strb     w8, [x21, #0xa73]
0068207C4  ldr      x1, [x22]
0068207C8  ldrb     w8, [x1, #0x53]
0068207CC  tbnz     w8, #5, #0x682085c
0068207D0  adrp     x20, #0x9591000
0068207D4  ldrb     w8, [x20, #0xa74]
0068207D8  cbnz     w8, #0x68207f0
0068207DC  adrp     x0, #0x8ee6000
0068207E0  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068207E4  bl       #0x382bd14 ; 
0068207E8  mov      w8, #1
0068207EC  strb     w8, [x20, #0xa74]
0068207F0  adrp     x8, #0x8ee6000
0068207F4  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068207F8  ldr      x1, [x8]
0068207FC  ldrb     w8, [x1, #0x53]
006820800  tbnz     w8, #5, #0x682080c
006820804  ldr      x19, [x19, #0x170]
006820808  b        #0x682081c ; 
00682080C  ldr      x8, [x1, #0x60]
006820810  mov      x0, x19
006820814  blr      x8
006820818  mov      x19, x0
00682081C  cbz      x19, #0x6820880
006820820  adrp     x20, #0x9591000
006820824  ldrb     w8, [x20, #0xa75]
006820828  cbnz     w8, #0x6820840
00682082C  adrp     x0, #0x8ee6000
006820830  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820834  bl       #0x382bd14 ; 
006820838  mov      w8, #1
00682083C  strb     w8, [x20, #0xa75]
006820840  adrp     x8, #0x8ee6000
006820844  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006820848  ldr      x1, [x8]
00682084C  ldrb     w8, [x1, #0x53]
006820850  tbnz     w8, #5, #0x682085c
006820854  ldr      w0, [x19, #0x24]
006820858  b        #0x6820868 ; 
00682085C  ldr      x8, [x1, #0x60]
006820860  mov      x0, x19
006820864  blr      x8
006820868  cmp      w0, #0xc9
00682086C  cset     w0, eq
006820870  ldp      x20, x19, [sp, #0x20]
006820874  ldp      x22, x21, [sp, #0x10]
006820878  ldp      x30, x23, [sp], #0x30
00682087C  ret      
006820880  bl       #0x382bfb8 ; 

