; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnEnemeyDieStart
; RVA 0x65893A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065893A4  stp      x30, x23, [sp, #-0x30]!
0065893A8  stp      x22, x21, [sp, #0x10]
0065893AC  stp      x20, x19, [sp, #0x20]
0065893B0  adrp     x22, #0x9599000
0065893B4  adrp     x23, #0x8f08000
0065893B8  ldrb     w8, [x22, #0x191]
0065893BC  ldr      x23, [x23, #0x2e0] ; GLOBAL Method$HotFix.BattleLogic.BaseSurvivalBattleManager.OnEnemeyDieStart() @ 0x923bb60
0065893C0  mov      x20, x2
0065893C4  mov      x21, x1
0065893C8  mov      x19, x0
0065893CC  tbnz     w8, #0, #0x65893f0
0065893D0  adrp     x0, #0x8f08000
0065893D4  ldr      x0, [x0, #0x2e0] ; GLOBAL Method$HotFix.BattleLogic.BaseSurvivalBattleManager.OnEnemeyDieStart() @ 0x923bb60
0065893D8  bl       #0x382bd14 ; 
0065893DC  adrp     x0, #0x8ee6000
0065893E0  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
0065893E4  bl       #0x382bd14 ; 
0065893E8  mov      w8, #1
0065893EC  strb     w8, [x22, #0x191]
0065893F0  ldr      x3, [x23]
0065893F4  ldrb     w8, [x3, #0x53]
0065893F8  tbnz     w8, #5, #0x6589454
0065893FC  mov      x0, x19
006589400  mov      x1, x21
006589404  mov      x2, x20
006589408  bl       #0x65895a8 ; HotFix.BattleLogic.BattleManager$$OnEnemeyDieStart
00658940C  mov      x0, x19
006589410  bl       #0x658918c ; HotFix.BattleLogic.BaseSurvivalBattleManager$$IsPassed
006589414  tbz      w0, #0, #0x6589590
006589418  adrp     x20, #0x9599000
00658941C  ldrb     w8, [x20, #0x286]
006589420  cbnz     w8, #0x6589438
006589424  adrp     x0, #0x8f07000
006589428  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
00658942C  bl       #0x382bd14 ; 
006589430  mov      w8, #1
006589434  strb     w8, [x20, #0x286]
006589438  adrp     x8, #0x8f07000
00658943C  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_WorldContext() @ 0x923ccd8
006589440  ldr      x1, [x8]
006589444  ldrb     w8, [x1, #0x53]
006589448  tbnz     w8, #5, #0x6589474
00658944C  ldr      x19, [x19, #0x80]
006589450  b        #0x6589484 ; 
006589454  ldr      x4, [x3, #0x60]
006589458  mov      x0, x19
00658945C  mov      x1, x21
006589460  mov      x2, x20
006589464  ldp      x20, x19, [sp, #0x20]
006589468  ldp      x22, x21, [sp, #0x10]
00658946C  ldp      x30, x23, [sp], #0x30
006589470  br       x4
006589474  ldr      x8, [x1, #0x60]
006589478  mov      x0, x19
00658947C  blr      x8
006589480  mov      x19, x0
006589484  cbz      x19, #0x65895a0
006589488  adrp     x20, #0x9591000
00658948C  ldrb     w8, [x20, #0xa62]
006589490  cbnz     w8, #0x65894a8
006589494  adrp     x0, #0x8ee6000
006589498  ldr      x0, [x0, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
00658949C  bl       #0x382bd14 ; 
0065894A0  mov      w8, #1
0065894A4  strb     w8, [x20, #0xa62]
0065894A8  adrp     x8, #0x8ee6000
0065894AC  ldr      x8, [x8, #0x1f8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Entity() @ 0x923fec8
0065894B0  ldr      x1, [x8]
0065894B4  ldrb     w8, [x1, #0x53]
0065894B8  tbnz     w8, #5, #0x65894c4
0065894BC  ldr      x19, [x19, #0x1f8]
0065894C0  b        #0x65894d4 ; 
0065894C4  ldr      x8, [x1, #0x60]
0065894C8  mov      x0, x19
0065894CC  blr      x8
0065894D0  mov      x19, x0
0065894D4  cbz      x19, #0x65895a0
0065894D8  adrp     x20, #0x9599000
0065894DC  ldrb     w8, [x20, #0x2a5]
0065894E0  cbnz     w8, #0x65894f8
0065894E4  adrp     x0, #0x8f08000
0065894E8  ldr      x0, [x0, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.EntityManager.GetAllPlayer() @ 0x9263c28
0065894EC  bl       #0x382bd14 ; 
0065894F0  mov      w8, #1
0065894F4  strb     w8, [x20, #0x2a5]
0065894F8  adrp     x8, #0x8f08000
0065894FC  ldr      x8, [x8, #0x2e8] ; GLOBAL Method$HotFix.BattleLogic.EntityManager.GetAllPlayer() @ 0x9263c28
006589500  ldr      x1, [x8]
006589504  ldrb     w8, [x1, #0x53]
006589508  tbnz     w8, #5, #0x6589514
00658950C  ldr      x19, [x19, #0x20]
006589510  b        #0x6589524 ; 
006589514  ldr      x8, [x1, #0x60]
006589518  mov      x0, x19
00658951C  blr      x8
006589520  mov      x19, x0
006589524  cbz      x19, #0x65895a0
006589528  ldr      w8, [x19, #0x18]
00658952C  cmp      w8, #1
006589530  b.lt     #0x6589590
006589534  adrp     x21, #0x8ee6000
006589538  ldr      x21, [x21, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data() @ 0x9210180
00658953C  mov      w20, wzr
006589540  cmp      w20, w8
006589544  b.hs     #0x65895a4
006589548  add      x8, x19, w20, sxtw #3
00658954C  ldr      x0, [x8, #0x20]
006589550  cbz      x0, #0x65895a0
006589554  ldr      x1, [x21]
006589558  ldrb     w8, [x1, #0x53]
00658955C  tbnz     w8, #5, #0x6589568
006589560  ldr      x0, [x0, #0x38]
006589564  b        #0x6589570 ; 
006589568  ldr      x8, [x1, #0x60]
00658956C  blr      x8
006589570  cbz      x0, #0x65895a0
006589574  mov      w1, #0x22
006589578  mov      x2, xzr
00658957C  bl       #0x65947d4 ; 
006589580  ldr      w8, [x19, #0x18]
006589584  add      w20, w20, #1
006589588  cmp      w20, w8
00658958C  b.lt     #0x6589540
006589590  ldp      x20, x19, [sp, #0x20]
006589594  ldp      x22, x21, [sp, #0x10]
006589598  ldp      x30, x23, [sp], #0x30
00658959C  ret      
0065895A0  bl       #0x382bfb8 ; 
0065895A4  bl       #0x382bfc0 ; 

