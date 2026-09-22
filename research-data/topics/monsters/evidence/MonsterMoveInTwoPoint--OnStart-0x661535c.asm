; HotFix.BattleLogic.MonsterMoveInTwoPoint$$OnStart
; RVA 0x661535C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00661535C  sub      sp, sp, #0x70
006615360  str      x30, [sp, #0x40]
006615364  stp      x22, x21, [sp, #0x50]
006615368  stp      x20, x19, [sp, #0x60]
00661536C  mrs      x20, tpidr_el0
006615370  ldr      x8, [x20, #0x28]
006615374  adrp     x21, #0x9599000
006615378  adrp     x22, #0x8f0c000
00661537C  mov      x19, x0
006615380  str      x8, [sp, #0x38]
006615384  ldrb     w8, [x21, #0x87a]
006615388  ldr      x22, [x22, #0x3a8] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint.OnStart()
00661538C  tbnz     w8, #0, #0x66153bc
006615390  adrp     x0, #0x8f0a000
006615394  ldr      x0, [x0, #0xf88] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>.get_Entity()
006615398  bl       #0x382bd14 ; 
00661539C  adrp     x0, #0x8ee6000
0066153A0  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
0066153A4  bl       #0x382bd14 ; 
0066153A8  adrp     x0, #0x8f0c000
0066153AC  ldr      x0, [x0, #0x3a8] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint.OnStart()
0066153B0  bl       #0x382bd14 ; 
0066153B4  mov      w8, #1
0066153B8  strb     w8, [x21, #0x87a]
0066153BC  ldr      x1, [x22]
0066153C0  ldrb     w8, [x1, #0x53]
0066153C4  tbnz     w8, #5, #0x66153e4
0066153C8  adrp     x8, #0x8f0a000
0066153CC  ldr      x8, [x8, #0xf88] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>.get_Entity()
0066153D0  ldr      x1, [x8]
0066153D4  ldrb     w8, [x1, #0x53]
0066153D8  tbnz     w8, #5, #0x66153f4
0066153DC  ldr      x0, [x19, #0x58]
0066153E0  b        #0x6615400 ; 
0066153E4  ldr      x8, [x1, #0x60]
0066153E8  mov      x0, x19
0066153EC  blr      x8
0066153F0  b        #0x6615460 ; 
0066153F4  ldr      x8, [x1, #0x60]
0066153F8  mov      x0, x19
0066153FC  blr      x8
006615400  cbz      x0, #0x6615484
006615404  adrp     x8, #0x8ee6000
006615408  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
00661540C  ldr      x1, [x8]
006615410  ldrb     w8, [x1, #0x53]
006615414  tbnz     w8, #5, #0x6615420
006615418  ldr      x0, [x0, #0x38]
00661541C  b        #0x6615428 ; 
006615420  ldr      x8, [x1, #0x60]
006615424  blr      x8
006615428  cbz      x0, #0x6615484
00661542C  add      x8, sp, #8
006615430  mov      x1, xzr
006615434  bl       #0x6b2914c ; HotFix.EntityData$$get_Position
006615438  ldr      x8, [sp, #0x18]
00661543C  ldur     q0, [sp, #8]
006615440  str      x8, [sp, #0x30]
006615444  str      q0, [sp, #0x20]
006615448  ldur     q1, [x19, #0x88]
00661544C  ldr      x9, [x19, #0x98]
006615450  str      x8, [x19, #0x80]
006615454  str      q0, [x19, #0x70]
006615458  str      q1, [x19, #0xa0]
00661545C  str      x9, [x19, #0xb0]
006615460  ldr      x8, [x20, #0x28]
006615464  ldr      x9, [sp, #0x38]
006615468  cmp      x8, x9
00661546C  b.ne     #0x6615488
006615470  ldp      x20, x19, [sp, #0x60]
006615474  ldp      x22, x21, [sp, #0x50]
006615478  ldr      x30, [sp, #0x40]
00661547C  add      sp, sp, #0x70
006615480  ret      
006615484  bl       #0x382bfb8 ; 
006615488  bl       #0x89edb60 ; 

