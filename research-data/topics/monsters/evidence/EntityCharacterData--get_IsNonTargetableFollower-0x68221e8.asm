; HotFix.BattleLogic.EntityCharacterData$$get_IsNonTargetableFollower
; RVA 0x68221E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068221E8  stp      x30, x23, [sp, #-0x30]!
0068221EC  stp      x22, x21, [sp, #0x10]
0068221F0  stp      x20, x19, [sp, #0x20]
0068221F4  adrp     x20, #0x959b000
0068221F8  adrp     x21, #0x8ee6000
0068221FC  ldrb     w8, [x20, #0x6b7]
006822200  ldr      x21, [x21, #0x3f8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsNonTargetableFollower()
006822204  mov      x19, x0
006822208  tbnz     w8, #0, #0x6822220
00682220C  adrp     x0, #0x8ee6000
006822210  ldr      x0, [x0, #0x3f8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_IsNonTargetableFollower()
006822214  bl       #0x382bd14 ; 
006822218  mov      w8, #1
00682221C  strb     w8, [x20, #0x6b7]
006822220  ldr      x1, [x21]
006822224  ldrb     w8, [x1, #0x53]
006822228  tbnz     w8, #5, #0x682229c
00682222C  adrp     x21, #0x9591000
006822230  ldrb     w8, [x21, #0xa73]
006822234  cbnz     w8, #0x682224c
006822238  adrp     x0, #0x8ee6000
00682223C  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822240  bl       #0x382bd14 ; 
006822244  mov      w8, #1
006822248  strb     w8, [x21, #0xa73]
00682224C  adrp     x22, #0x8ee6000
006822250  ldr      x22, [x22, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822254  ldr      x1, [x22]
006822258  ldrb     w8, [x1, #0x53]
00682225C  tbnz     w8, #5, #0x68222b4
006822260  adrp     x20, #0x9591000
006822264  ldrb     w8, [x20, #0xa74]
006822268  cbnz     w8, #0x6822280
00682226C  adrp     x0, #0x8ee6000
006822270  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822274  bl       #0x382bd14 ; 
006822278  mov      w8, #1
00682227C  strb     w8, [x20, #0xa74]
006822280  adrp     x8, #0x8ee6000
006822284  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822288  ldr      x1, [x8]
00682228C  ldrb     w8, [x1, #0x53]
006822290  tbnz     w8, #5, #0x68222c0
006822294  ldr      x20, [x19, #0x170]
006822298  b        #0x68222d0 ; 
00682229C  ldr      x2, [x1, #0x60]
0068222A0  mov      x0, x19
0068222A4  ldp      x20, x19, [sp, #0x20]
0068222A8  ldp      x22, x21, [sp, #0x10]
0068222AC  ldp      x30, x23, [sp], #0x30
0068222B0  br       x2
0068222B4  ldr      x8, [x1, #0x60]
0068222B8  mov      x0, x19
0068222BC  b        #0x6822318 ; 
0068222C0  ldr      x8, [x1, #0x60]
0068222C4  mov      x0, x19
0068222C8  blr      x8
0068222CC  mov      x20, x0
0068222D0  cbz      x20, #0x68224d8
0068222D4  adrp     x23, #0x9591000
0068222D8  ldrb     w8, [x23, #0xa75]
0068222DC  cbnz     w8, #0x68222f4
0068222E0  adrp     x0, #0x8ee6000
0068222E4  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0068222E8  bl       #0x382bd14 ; 
0068222EC  mov      w8, #1
0068222F0  strb     w8, [x23, #0xa75]
0068222F4  adrp     x8, #0x8ee6000
0068222F8  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0068222FC  ldr      x1, [x8]
006822300  ldrb     w8, [x1, #0x53]
006822304  tbnz     w8, #5, #0x6822310
006822308  ldr      w0, [x20, #0x24]
00682230C  b        #0x682231c ; 
006822310  ldr      x8, [x1, #0x60]
006822314  mov      x0, x20
006822318  blr      x8
00682231C  cmp      w0, #9
006822320  b.eq     #0x68223f8
006822324  ldrb     w8, [x21, #0xa73]
006822328  cbnz     w8, #0x6822340
00682232C  adrp     x0, #0x8ee6000
006822330  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822334  bl       #0x382bd14 ; 
006822338  mov      w8, #1
00682233C  strb     w8, [x21, #0xa73]
006822340  ldr      x1, [x22]
006822344  ldrb     w8, [x1, #0x53]
006822348  tbnz     w8, #5, #0x6822388
00682234C  adrp     x20, #0x9591000
006822350  ldrb     w8, [x20, #0xa74]
006822354  cbnz     w8, #0x682236c
006822358  adrp     x0, #0x8ee6000
00682235C  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822360  bl       #0x382bd14 ; 
006822364  mov      w8, #1
006822368  strb     w8, [x20, #0xa74]
00682236C  adrp     x8, #0x8ee6000
006822370  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822374  ldr      x1, [x8]
006822378  ldrb     w8, [x1, #0x53]
00682237C  tbnz     w8, #5, #0x6822394
006822380  ldr      x20, [x19, #0x170]
006822384  b        #0x68223a4 ; 
006822388  ldr      x8, [x1, #0x60]
00682238C  mov      x0, x19
006822390  b        #0x68223ec ; 
006822394  ldr      x8, [x1, #0x60]
006822398  mov      x0, x19
00682239C  blr      x8
0068223A0  mov      x20, x0
0068223A4  cbz      x20, #0x68224d8
0068223A8  adrp     x23, #0x9591000
0068223AC  ldrb     w8, [x23, #0xa75]
0068223B0  cbnz     w8, #0x68223c8
0068223B4  adrp     x0, #0x8ee6000
0068223B8  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0068223BC  bl       #0x382bd14 ; 
0068223C0  mov      w8, #1
0068223C4  strb     w8, [x23, #0xa75]
0068223C8  adrp     x8, #0x8ee6000
0068223CC  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0068223D0  ldr      x1, [x8]
0068223D4  ldrb     w8, [x1, #0x53]
0068223D8  tbnz     w8, #5, #0x68223e4
0068223DC  ldr      w0, [x20, #0x24]
0068223E0  b        #0x68223f0 ; 
0068223E4  ldr      x8, [x1, #0x60]
0068223E8  mov      x0, x20
0068223EC  blr      x8
0068223F0  cmp      w0, #0xc
0068223F4  b.ne     #0x6822400
0068223F8  mov      w0, #1
0068223FC  b        #0x68224c8 ; 
006822400  ldrb     w8, [x21, #0xa73]
006822404  cbnz     w8, #0x682241c
006822408  adrp     x0, #0x8ee6000
00682240C  ldr      x0, [x0, #0x280] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_EntityCharacterType()
006822410  bl       #0x382bd14 ; 
006822414  mov      w8, #1
006822418  strb     w8, [x21, #0xa73]
00682241C  ldr      x1, [x22]
006822420  ldrb     w8, [x1, #0x53]
006822424  tbnz     w8, #5, #0x68224b4
006822428  adrp     x20, #0x9591000
00682242C  ldrb     w8, [x20, #0xa74]
006822430  cbnz     w8, #0x6822448
006822434  adrp     x0, #0x8ee6000
006822438  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
00682243C  bl       #0x382bd14 ; 
006822440  mov      w8, #1
006822444  strb     w8, [x20, #0xa74]
006822448  adrp     x8, #0x8ee6000
00682244C  ldr      x8, [x8, #0x288] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacterData.get_TableData()
006822450  ldr      x1, [x8]
006822454  ldrb     w8, [x1, #0x53]
006822458  tbnz     w8, #5, #0x6822464
00682245C  ldr      x19, [x19, #0x170]
006822460  b        #0x6822474 ; 
006822464  ldr      x8, [x1, #0x60]
006822468  mov      x0, x19
00682246C  blr      x8
006822470  mov      x19, x0
006822474  cbz      x19, #0x68224d8
006822478  adrp     x20, #0x9591000
00682247C  ldrb     w8, [x20, #0xa75]
006822480  cbnz     w8, #0x6822498
006822484  adrp     x0, #0x8ee6000
006822488  ldr      x0, [x0, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
00682248C  bl       #0x382bd14 ; 
006822490  mov      w8, #1
006822494  strb     w8, [x20, #0xa75]
006822498  adrp     x8, #0x8ee6000
00682249C  ldr      x8, [x8, #0x290] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_Type()
0068224A0  ldr      x1, [x8]
0068224A4  ldrb     w8, [x1, #0x53]
0068224A8  tbnz     w8, #5, #0x68224b4
0068224AC  ldr      w0, [x19, #0x24]
0068224B0  b        #0x68224c0 ; 
0068224B4  ldr      x8, [x1, #0x60]
0068224B8  mov      x0, x19
0068224BC  blr      x8
0068224C0  cmp      w0, #0xe
0068224C4  cset     w0, eq
0068224C8  ldp      x20, x19, [sp, #0x20]
0068224CC  ldp      x22, x21, [sp, #0x10]
0068224D0  ldp      x30, x23, [sp], #0x30
0068224D4  ret      
0068224D8  bl       #0x382bfb8 ; 

