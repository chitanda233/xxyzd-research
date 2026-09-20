; HotFix.TreasureViewModule$$OnClickOK2
; RVA 0x7667E04; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007667E04  stp      x30, x23, [sp, #-0x30]!
007667E08  stp      x22, x21, [sp, #0x10]
007667E0C  stp      x20, x19, [sp, #0x20]
007667E10  adrp     x20, #0x95aa000
007667E14  adrp     x21, #0x8fae000
007667E18  ldrb     w8, [x20, #0x3f3]
007667E1C  ldr      x21, [x21, #0x1f8] ; GLOBAL Method$HotFix.TreasureViewModule.OnClickOK2() @ 0x92b5e90
007667E20  mov      x19, x0
007667E24  tbnz     w8, #0, #0x7667e78
007667E28  adrp     x0, #0x8f73000
007667E2C  ldr      x0, [x0, #0xda0] ; GLOBAL Method$HotFix.BattleWorldElementCreator.CreateCommand<SelectTreasureSkillCommand>() @ 0x92402f0
007667E30  bl       #0x382bd14 ; 
007667E34  adrp     x0, #0x8ee1000
007667E38  ldr      x0, [x0, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
007667E3C  bl       #0x382bd14 ; 
007667E40  adrp     x0, #0x8f6b000
007667E44  ldr      x0, [x0, #0xbf8] ; GLOBAL HotFix.Tracker_TypeInfo @ 0x91f2b68
007667E48  bl       #0x382bd14 ; 
007667E4C  adrp     x0, #0x8fae000
007667E50  ldr      x0, [x0, #0x1f8] ; GLOBAL Method$HotFix.TreasureViewModule.OnClickOK2() @ 0x92b5e90
007667E54  bl       #0x382bd14 ; 
007667E58  adrp     x0, #0x8f6e000
007667E5C  ldr      x0, [x0, #0x600] ; GLOBAL HotFix.TreasureViewModule_TypeInfo @ 0x91f2d00
007667E60  bl       #0x382bd14 ; 
007667E64  adrp     x0, #0x8fae000
007667E68  ldr      x0, [x0, #0x200] ; GLOBAL 女武神 @ 0x932d068
007667E6C  bl       #0x382bd14 ; 
007667E70  mov      w8, #1
007667E74  strb     w8, [x20, #0x3f3]
007667E78  ldr      x1, [x21]
007667E7C  ldrb     w8, [x1, #0x53]
007667E80  tbnz     w8, #5, #0x7667ee4
007667E84  ldrb     w8, [x19, #0xa8]
007667E88  cbnz     w8, #0x7667f8c
007667E8C  adrp     x20, #0x95a4000
007667E90  ldrb     w8, [x20, #0x459]
007667E94  cbnz     w8, #0x7667eb8
007667E98  adrp     x0, #0x8f6c000
007667E9C  ldr      x0, [x0, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
007667EA0  bl       #0x382bd14 ; 
007667EA4  adrp     x0, #0x8f6c000
007667EA8  ldr      x0, [x0, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
007667EAC  bl       #0x382bd14 ; 
007667EB0  mov      w8, #1
007667EB4  strb     w8, [x20, #0x459]
007667EB8  adrp     x21, #0x8f6c000
007667EBC  ldr      x21, [x21, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
007667EC0  ldr      x0, [x21]
007667EC4  ldrb     w8, [x0, #0x53]
007667EC8  tbnz     w8, #5, #0x7667efc
007667ECC  adrp     x8, #0x8f6c000
007667ED0  ldr      x8, [x8, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
007667ED4  ldr      x8, [x8]
007667ED8  ldr      x8, [x8, #0xb8]
007667EDC  ldr      x0, [x8]
007667EE0  b        #0x7667f04 ; 
007667EE4  ldr      x2, [x1, #0x60]
007667EE8  mov      x0, x19
007667EEC  ldp      x20, x19, [sp, #0x20]
007667EF0  ldp      x22, x21, [sp, #0x10]
007667EF4  ldp      x30, x23, [sp], #0x30
007667EF8  br       x2
007667EFC  ldr      x8, [x0, #0x60]
007667F00  blr      x8
007667F04  cbz      x0, #0x766811c
007667F08  mov      x1, xzr
007667F0C  bl       #0x70507e4 ; HotFix.WorldBattle$$get_CanEndSkillSelect
007667F10  tbz      w0, #0, #0x7667f8c
007667F14  mov      w8, #1
007667F18  mov      x0, xzr
007667F1C  strb     w8, [x19, #0xa8]
007667F20  bl       #0x6f993bc ; HotFix.BattleGame$$get_ElementCreator
007667F24  cbz      x0, #0x766811c
007667F28  adrp     x8, #0x8f73000
007667F2C  ldr      x8, [x8, #0xda0] ; GLOBAL Method$HotFix.BattleWorldElementCreator.CreateCommand<SelectTreasureSkillCommand>() @ 0x92402f0
007667F30  mov      w1, #8
007667F34  ldr      x2, [x8]
007667F38  bl       #0x4540634 ; HotFix.BattleWorldElementCreator$$CreateCommand<object>
007667F3C  ldrb     w8, [x20, #0x459]
007667F40  mov      x19, x0
007667F44  cbnz     w8, #0x7667f68
007667F48  adrp     x0, #0x8f6c000
007667F4C  ldr      x0, [x0, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
007667F50  bl       #0x382bd14 ; 
007667F54  adrp     x0, #0x8f6c000
007667F58  ldr      x0, [x0, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
007667F5C  bl       #0x382bd14 ; 
007667F60  mov      w8, #1
007667F64  strb     w8, [x20, #0x459]
007667F68  ldr      x0, [x21]
007667F6C  ldrb     w8, [x0, #0x53]
007667F70  tbnz     w8, #5, #0x7667f9c
007667F74  adrp     x8, #0x8f6c000
007667F78  ldr      x8, [x8, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
007667F7C  ldr      x8, [x8]
007667F80  ldr      x8, [x8, #0xb8]
007667F84  ldr      x0, [x8]
007667F88  b        #0x7667fa4 ; 
007667F8C  ldp      x20, x19, [sp, #0x20]
007667F90  ldp      x22, x21, [sp, #0x10]
007667F94  ldp      x30, x23, [sp], #0x30
007667F98  ret      
007667F9C  ldr      x8, [x0, #0x60]
007667FA0  blr      x8
007667FA4  cbz      x0, #0x766811c
007667FA8  cbz      x19, #0x766811c
007667FAC  ldr      w8, [x0, #0x6c]
007667FB0  mov      w9, #1
007667FB4  strb     w9, [x19, #0x21]
007667FB8  adrp     x22, #0x8ee1000
007667FBC  strb     w8, [x19, #0x20]
007667FC0  ldr      x22, [x22, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
007667FC4  ldr      x0, [x22]
007667FC8  ldr      w8, [x0, #0xe0]
007667FCC  cbnz     w8, #0x7667fd4
007667FD0  bl       #0x382be8c ; 
007667FD4  adrp     x23, #0x9591000
007667FD8  ldrb     w8, [x23, #0x5ba]
007667FDC  cbnz     w8, #0x7667ff4
007667FE0  adrp     x0, #0x8ee1000
007667FE4  ldr      x0, [x0, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
007667FE8  bl       #0x382bd14 ; 
007667FEC  mov      w8, #1
007667FF0  strb     w8, [x23, #0x5ba]
007667FF4  ldr      x0, [x22]
007667FF8  ldr      w8, [x0, #0xe0]
007667FFC  cbnz     w8, #0x7668008
007668000  bl       #0x382be8c ; 
007668004  ldr      x0, [x22]
007668008  ldr      x8, [x0, #0xb8]
00766800C  mov      w1, #0x98
007668010  mov      x2, x19
007668014  mov      x3, xzr
007668018  ldr      x0, [x8, #0x10]
00766801C  bl       #0x7270dbc ; HotFix.FrameworkExpand$$DispatchNow
007668020  adrp     x19, #0x8f6e000
007668024  ldr      x19, [x19, #0x600] ; GLOBAL HotFix.TreasureViewModule_TypeInfo @ 0x91f2d00
007668028  ldr      x0, [x19]
00766802C  ldr      w8, [x0, #0xe0]
007668030  cbnz     w8, #0x766803c
007668034  bl       #0x382be8c ; 
007668038  ldr      x0, [x19]
00766803C  ldr      x8, [x0, #0xb8]
007668040  ldr      x8, [x8]
007668044  cbz      x8, #0x766811c
007668048  ldrb     w8, [x8, #0x1c]
00766804C  cbz      w8, #0x76680b4
007668050  ldrb     w8, [x20, #0x459]
007668054  cbnz     w8, #0x7668078
007668058  adrp     x0, #0x8f6c000
00766805C  ldr      x0, [x0, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
007668060  bl       #0x382bd14 ; 
007668064  adrp     x0, #0x8f6c000
007668068  ldr      x0, [x0, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
00766806C  bl       #0x382bd14 ; 
007668070  mov      w8, #1
007668074  strb     w8, [x20, #0x459]
007668078  ldr      x0, [x21]
00766807C  ldrb     w8, [x0, #0x53]
007668080  tbnz     w8, #5, #0x766809c
007668084  adrp     x8, #0x8f6c000
007668088  ldr      x8, [x8, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
00766808C  ldr      x8, [x8]
007668090  ldr      x8, [x8, #0xb8]
007668094  ldr      x0, [x8]
007668098  b        #0x76680a4 ; 
00766809C  ldr      x8, [x0, #0x60]
0076680A0  blr      x8
0076680A4  cbz      x0, #0x766811c
0076680A8  mov      x1, xzr
0076680AC  bl       #0x704d71c ; HotFix.WorldBattle$$ResetTime
0076680B0  ldr      x0, [x19]
0076680B4  ldr      w8, [x0, #0xe0]
0076680B8  cbnz     w8, #0x76680c4
0076680BC  bl       #0x382be8c ; 
0076680C0  ldr      x0, [x19]
0076680C4  ldr      x8, [x0, #0xb8]
0076680C8  ldr      x19, [x8]
0076680CC  cbz      x19, #0x766811c
0076680D0  adrp     x8, #0x8f6b000
0076680D4  ldr      x8, [x8, #0xbf8] ; GLOBAL HotFix.Tracker_TypeInfo @ 0x91f2b68
0076680D8  ldr      w20, [x19, #0x14]
0076680DC  ldr      x0, [x8]
0076680E0  ldr      w8, [x0, #0xe0]
0076680E4  cbnz     w8, #0x76680ec
0076680E8  bl       #0x382be8c ; 
0076680EC  adrp     x8, #0x8fae000
0076680F0  ldr      x8, [x8, #0x200] ; GLOBAL 女武神 @ 0x932d068
0076680F4  mov      x0, x19
0076680F8  mov      w2, w20
0076680FC  ldp      x20, x19, [sp, #0x20]
007668100  ldr      x1, [x8]
007668104  ldp      x22, x21, [sp, #0x10]
007668108  mov      w4, #1
00766810C  mov      x3, xzr
007668110  mov      x5, xzr
007668114  ldp      x30, x23, [sp], #0x30
007668118  b        #0x781bbc4 ; HotFix.Tracker$$TrackSkillSelect
00766811C  bl       #0x382bfb8 ; 

