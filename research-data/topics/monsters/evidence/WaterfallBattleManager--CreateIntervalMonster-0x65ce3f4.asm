; HotFix.BattleLogic.WaterfallBattleManager$$CreateIntervalMonster
; RVA 0x65CE3F4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065CE3F4  str      x30, [sp, #-0x30]!
0065CE3F8  stp      x22, x21, [sp, #0x10]
0065CE3FC  stp      x20, x19, [sp, #0x20]
0065CE400  adrp     x20, #0x9599000
0065CE404  adrp     x21, #0x8f0a000
0065CE408  ldrb     w8, [x20, #0x584]
0065CE40C  ldr      x21, [x21, #0x8f0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreateIntervalMonster()
0065CE410  mov      x19, x0
0065CE414  tbnz     w8, #0, #0x65ce438
0065CE418  adrp     x0, #0x8f09000
0065CE41C  ldr      x0, [x0, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CE420  bl       #0x382bd14 ; 
0065CE424  adrp     x0, #0x8f0a000
0065CE428  ldr      x0, [x0, #0x8f0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallBattleManager.CreateIntervalMonster()
0065CE42C  bl       #0x382bd14 ; 
0065CE430  mov      w8, #1
0065CE434  strb     w8, [x20, #0x584]
0065CE438  ldr      x1, [x21]
0065CE43C  ldrb     w8, [x1, #0x53]
0065CE440  tbnz     w8, #5, #0x65ce494
0065CE444  ldr      x20, [x19, #0x188]
0065CE448  cbz      x20, #0x65ce620
0065CE44C  adrp     x21, #0x8f09000
0065CE450  ldr      x8, [x20]
0065CE454  ldr      x21, [x21, #0xc08] ; GLOBAL LocalModels.Bean.IWaterfallMission_TypeInfo
0065CE458  ldrh     w9, [x8, #0x12e]
0065CE45C  ldr      x1, [x21]
0065CE460  cbz      x9, #0x65ce484
0065CE464  ldr      x10, [x8, #0xb0]
0065CE468  add      x10, x10, #8
0065CE46C  ldur     x11, [x10, #-8]
0065CE470  cmp      x11, x1
0065CE474  b.eq     #0x65ce4ac
0065CE478  subs     x9, x9, #1
0065CE47C  add      x10, x10, #0x10
0065CE480  b.ne     #0x65ce46c
0065CE484  mov      w2, #0xa
0065CE488  mov      x0, x20
0065CE48C  bl       #0x3a7e710 ; 
0065CE490  b        #0x65ce4bc ; 
0065CE494  ldr      x2, [x1, #0x60]
0065CE498  mov      x0, x19
0065CE49C  ldp      x20, x19, [sp, #0x20]
0065CE4A0  ldp      x22, x21, [sp, #0x10]
0065CE4A4  ldr      x30, [sp], #0x30
0065CE4A8  br       x2
0065CE4AC  ldr      w9, [x10]
0065CE4B0  add      w9, w9, #0xa
0065CE4B4  add      x8, x8, w9, sxtw #4
0065CE4B8  add      x0, x8, #0x138
0065CE4BC  ldp      x8, x1, [x0]
0065CE4C0  mov      x0, x20
0065CE4C4  blr      x8
0065CE4C8  cbz      x0, #0x65ce620
0065CE4CC  ldr      x8, [x0, #0x18]
0065CE4D0  cbz      x8, #0x65ce51c
0065CE4D4  ldr      x20, [x19, #0x188]
0065CE4D8  cbz      x20, #0x65ce620
0065CE4DC  ldr      x8, [x20]
0065CE4E0  ldr      x1, [x21]
0065CE4E4  ldrh     w9, [x8, #0x12e]
0065CE4E8  cbz      x9, #0x65ce50c
0065CE4EC  ldr      x10, [x8, #0xb0]
0065CE4F0  add      x10, x10, #8
0065CE4F4  ldur     x11, [x10, #-8]
0065CE4F8  cmp      x11, x1
0065CE4FC  b.eq     #0x65ce528
0065CE500  subs     x9, x9, #1
0065CE504  add      x10, x10, #0x10
0065CE508  b.ne     #0x65ce4f4
0065CE50C  mov      w2, #0xa
0065CE510  mov      x0, x20
0065CE514  bl       #0x3a7e710 ; 
0065CE518  b        #0x65ce538 ; 
0065CE51C  mov      x21, xzr
0065CE520  mov      w8, #1
0065CE524  b        #0x65ce5d8 ; 
0065CE528  ldr      w9, [x10]
0065CE52C  add      w9, w9, #0xa
0065CE530  add      x8, x8, w9, sxtw #4
0065CE534  add      x0, x8, #0x138
0065CE538  ldp      x8, x1, [x0]
0065CE53C  mov      x0, x20
0065CE540  blr      x8
0065CE544  cbz      x0, #0x65ce620
0065CE548  ldr      w8, [x0, #0x18]
0065CE54C  cbz      w8, #0x65ce624
0065CE550  ldr      x20, [x19, #0x188]
0065CE554  cbz      x20, #0x65ce620
0065CE558  ldr      x8, [x20]
0065CE55C  ldr      x22, [x0, #0x20]
0065CE560  ldr      x1, [x21]
0065CE564  ldrh     w9, [x8, #0x12e]
0065CE568  cbz      x9, #0x65ce58c
0065CE56C  ldr      x10, [x8, #0xb0]
0065CE570  add      x10, x10, #8
0065CE574  ldur     x11, [x10, #-8]
0065CE578  cmp      x11, x1
0065CE57C  b.eq     #0x65ce59c
0065CE580  subs     x9, x9, #1
0065CE584  add      x10, x10, #0x10
0065CE588  b.ne     #0x65ce574
0065CE58C  mov      w2, #0xa
0065CE590  mov      x0, x20
0065CE594  bl       #0x3a7e710 ; 
0065CE598  b        #0x65ce5ac ; 
0065CE59C  ldr      w9, [x10]
0065CE5A0  add      w9, w9, #0xa
0065CE5A4  add      x8, x8, w9, sxtw #4
0065CE5A8  add      x0, x8, #0x138
0065CE5AC  ldp      x8, x1, [x0]
0065CE5B0  mov      x0, x20
0065CE5B4  blr      x8
0065CE5B8  cbz      x0, #0x65ce620
0065CE5BC  ldr      w8, [x0, #0x18]
0065CE5C0  cmp      w8, #1
0065CE5C4  b.ls     #0x65ce624
0065CE5C8  lsr      x8, x22, #0x10
0065CE5CC  cmp      w8, #1
0065CE5D0  b.lt     #0x65ce610
0065CE5D4  ldr      x21, [x0, #0x28]
0065CE5D8  mov      x20, xzr
0065CE5DC  and      x22, x8, #0xffffffff
0065CE5E0  mov      x0, x19
0065CE5E4  mov      x1, x20
0065CE5E8  bl       #0x65ce8e8 ; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileMonster
0065CE5EC  mov      x0, x19
0065CE5F0  mov      x1, x20
0065CE5F4  bl       #0x65cf35c ; HotFix.BattleLogic.WaterfallBattleManager$$CreateTileGroupMonster
0065CE5F8  mov      x0, x19
0065CE5FC  mov      x1, x20
0065CE600  bl       #0x65cff58 ; HotFix.BattleLogic.WaterfallBattleManager$$CreateRandomMonster
0065CE604  subs     x22, x22, #1
0065CE608  add      x20, x20, x21
0065CE60C  b.ne     #0x65ce5e0
0065CE610  ldp      x20, x19, [sp, #0x20]
0065CE614  ldp      x22, x21, [sp, #0x10]
0065CE618  ldr      x30, [sp], #0x30
0065CE61C  ret      
0065CE620  bl       #0x382bfb8 ; 
0065CE624  bl       #0x382bfc0 ; 

