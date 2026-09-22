; HotFix.BattleLogic.EntityCharacterData$$get_IsNpc
; RVA 0x682287C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00682287C  stp      x30, x21, [sp, #-0x20]!
006822880  stp      x20, x19, [sp, #0x10]
006822884  adrp     x20, #0x959b000
006822888  adrp     x21, #0x8f22000
00682288C  ldrb     w8, [x20, #0x6bb]
006822890  ldr      x21, [x21, #0x48] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsNpc()
006822894  mov      x19, x0
006822898  tbnz     w8, #0, #0x68228b0
00682289C  adrp     x0, #0x8f22000
0068228A0  ldr      x0, [x0, #0x48] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsNpc()
0068228A4  bl       #0x382bd14 ; 
0068228A8  mov      w8, #1
0068228AC  strb     w8, [x20, #0x6bb]
0068228B0  ldr      x1, [x21]
0068228B4  ldrb     w8, [x1, #0x53]
0068228B8  tbnz     w8, #5, #0x682292c
0068228BC  adrp     x20, #0x9591000
0068228C0  ldrb     w8, [x20, #0xa73]
0068228C4  cbnz     w8, #0x68228dc
0068228C8  adrp     x0, #0x8ee6000
0068228CC  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0068228D0  bl       #0x382bd14 ; 
0068228D4  mov      w8, #1
0068228D8  strb     w8, [x20, #0xa73]
0068228DC  adrp     x8, #0x8ee6000
0068228E0  ldr      x8, [x8, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
0068228E4  ldr      x1, [x8]
0068228E8  ldrb     w8, [x1, #0x53]
0068228EC  tbnz     w8, #5, #0x6822990
0068228F0  adrp     x20, #0x9591000
0068228F4  ldrb     w8, [x20, #0xa74]
0068228F8  cbnz     w8, #0x6822910
0068228FC  adrp     x0, #0x8ee6000
006822900  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822904  bl       #0x382bd14 ; 
006822908  mov      w8, #1
00682290C  strb     w8, [x20, #0xa74]
006822910  adrp     x8, #0x8ee6000
006822914  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822918  ldr      x1, [x8]
00682291C  ldrb     w8, [x1, #0x53]
006822920  tbnz     w8, #5, #0x6822940
006822924  ldr      x19, [x19, #0x170]
006822928  b        #0x6822950 ; 
00682292C  ldr      x2, [x1, #0x60]
006822930  mov      x0, x19
006822934  ldp      x20, x19, [sp, #0x10]
006822938  ldp      x30, x21, [sp], #0x20
00682293C  br       x2
006822940  ldr      x8, [x1, #0x60]
006822944  mov      x0, x19
006822948  blr      x8
00682294C  mov      x19, x0
006822950  cbz      x19, #0x68229b0
006822954  adrp     x20, #0x9591000
006822958  ldrb     w8, [x20, #0xa75]
00682295C  cbnz     w8, #0x6822974
006822960  adrp     x0, #0x8ee6000
006822964  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
006822968  bl       #0x382bd14 ; 
00682296C  mov      w8, #1
006822970  strb     w8, [x20, #0xa75]
006822974  adrp     x8, #0x8ee6000
006822978  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
00682297C  ldr      x1, [x8]
006822980  ldrb     w8, [x1, #0x53]
006822984  tbnz     w8, #5, #0x6822990
006822988  ldr      w0, [x19, #0x24]
00682298C  b        #0x682299c ; 
006822990  ldr      x8, [x1, #0x60]
006822994  mov      x0, x19
006822998  blr      x8
00682299C  ldp      x20, x19, [sp, #0x10]
0068229A0  cmp      w0, #5
0068229A4  cset     w0, eq
0068229A8  ldp      x30, x21, [sp], #0x20
0068229AC  ret      
0068229B0  bl       #0x382bfb8 ; 

