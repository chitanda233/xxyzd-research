; HotFix.BattleLogic.EntityCharacterData$$get_IsElite
; RVA 0x6822744; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006822744  stp      x30, x21, [sp, #-0x20]!
006822748  stp      x20, x19, [sp, #0x10]
00682274C  adrp     x20, #0x959b000
006822750  adrp     x21, #0x8f22000
006822754  ldrb     w8, [x20, #0x6ba]
006822758  ldr      x21, [x21, #0x40] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsElite()
00682275C  mov      x19, x0
006822760  tbnz     w8, #0, #0x6822778
006822764  adrp     x0, #0x8f22000
006822768  ldr      x0, [x0, #0x40] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsElite()
00682276C  bl       #0x382bd14 ; 
006822770  mov      w8, #1
006822774  strb     w8, [x20, #0x6ba]
006822778  ldr      x1, [x21]
00682277C  ldrb     w8, [x1, #0x53]
006822780  tbnz     w8, #5, #0x68227f4
006822784  adrp     x20, #0x9591000
006822788  ldrb     w8, [x20, #0xa73]
00682278C  cbnz     w8, #0x68227a4
006822790  adrp     x0, #0x8ee6000
006822794  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822798  bl       #0x382bd14 ; 
00682279C  mov      w8, #1
0068227A0  strb     w8, [x20, #0xa73]
0068227A4  adrp     x8, #0x8ee6000
0068227A8  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0068227AC  ldr      x1, [x8]
0068227B0  ldrb     w8, [x1, #0x53]
0068227B4  tbnz     w8, #5, #0x6822858
0068227B8  adrp     x20, #0x9591000
0068227BC  ldrb     w8, [x20, #0xa74]
0068227C0  cbnz     w8, #0x68227d8
0068227C4  adrp     x0, #0x8ee6000
0068227C8  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068227CC  bl       #0x382bd14 ; 
0068227D0  mov      w8, #1
0068227D4  strb     w8, [x20, #0xa74]
0068227D8  adrp     x8, #0x8ee6000
0068227DC  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
0068227E0  ldr      x1, [x8]
0068227E4  ldrb     w8, [x1, #0x53]
0068227E8  tbnz     w8, #5, #0x6822808
0068227EC  ldr      x19, [x19, #0x170]
0068227F0  b        #0x6822818 ; 
0068227F4  ldr      x2, [x1, #0x60]
0068227F8  mov      x0, x19
0068227FC  ldp      x20, x19, [sp, #0x10]
006822800  ldp      x30, x21, [sp], #0x20
006822804  br       x2
006822808  ldr      x8, [x1, #0x60]
00682280C  mov      x0, x19
006822810  blr      x8
006822814  mov      x19, x0
006822818  cbz      x19, #0x6822878
00682281C  adrp     x20, #0x9591000
006822820  ldrb     w8, [x20, #0xa75]
006822824  cbnz     w8, #0x682283c
006822828  adrp     x0, #0x8ee6000
00682282C  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006822830  bl       #0x382bd14 ; 
006822834  mov      w8, #1
006822838  strb     w8, [x20, #0xa75]
00682283C  adrp     x8, #0x8ee6000
006822840  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006822844  ldr      x1, [x8]
006822848  ldrb     w8, [x1, #0x53]
00682284C  tbnz     w8, #5, #0x6822858
006822850  ldr      w0, [x19, #0x24]
006822854  b        #0x6822864 ; 
006822858  ldr      x8, [x1, #0x60]
00682285C  mov      x0, x19
006822860  blr      x8
006822864  ldp      x20, x19, [sp, #0x10]
006822868  cmp      w0, #0xc9
00682286C  cset     w0, eq
006822870  ldp      x30, x21, [sp], #0x20
006822874  ret      
006822878  bl       #0x382bfb8 ; 

