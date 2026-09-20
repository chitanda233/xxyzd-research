; HotFix.TreasureViewModule$$OnClickOK1
; RVA 0x7667AEC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
007667AEC  stp      x30, x23, [sp, #-0x30]!
007667AF0  stp      x22, x21, [sp, #0x10]
007667AF4  stp      x20, x19, [sp, #0x20]
007667AF8  adrp     x20, #0x95aa000
007667AFC  adrp     x21, #0x8fae000
007667B00  ldrb     w8, [x20, #0x3f2]
007667B04  ldr      x21, [x21, #0x1f0] ; GLOBAL Method$HotFix.TreasureViewModule.OnClickOK1() @ 0x92b5e88
007667B08  mov      x19, x0
007667B0C  tbnz     w8, #0, #0x7667b60
007667B10  adrp     x0, #0x8f73000
007667B14  ldr      x0, [x0, #0xda0] ; GLOBAL Method$HotFix.BattleWorldElementCreator.CreateCommand<SelectTreasureSkillCommand>() @ 0x92402f0
007667B18  bl       #0x382bd14 ; 
007667B1C  adrp     x0, #0x8ee1000
007667B20  ldr      x0, [x0, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
007667B24  bl       #0x382bd14 ; 
007667B28  adrp     x0, #0x8f6b000
007667B2C  ldr      x0, [x0, #0xbf8] ; GLOBAL HotFix.Tracker_TypeInfo @ 0x91f2b68
007667B30  bl       #0x382bd14 ; 
007667B34  adrp     x0, #0x8fae000
007667B38  ldr      x0, [x0, #0x1f0] ; GLOBAL Method$HotFix.TreasureViewModule.OnClickOK1() @ 0x92b5e88
007667B3C  bl       #0x382bd14 ; 
007667B40  adrp     x0, #0x8f6e000
007667B44  ldr      x0, [x0, #0x600] ; GLOBAL HotFix.TreasureViewModule_TypeInfo @ 0x91f2d00
007667B48  bl       #0x382bd14 ; 
007667B4C  adrp     x0, #0x8fae000
007667B50  ldr      x0, [x0, #0x200] ; GLOBAL 女武神 @ 0x932d068
007667B54  bl       #0x382bd14 ; 
007667B58  mov      w8, #1
007667B5C  strb     w8, [x20, #0x3f2]
007667B60  ldr      x1, [x21]
007667B64  ldrb     w8, [x1, #0x53]
007667B68  tbnz     w8, #5, #0x7667bcc
007667B6C  ldrb     w8, [x19, #0xa8]
007667B70  cbnz     w8, #0x7667c74
007667B74  adrp     x20, #0x95a4000
007667B78  ldrb     w8, [x20, #0x459]
007667B7C  cbnz     w8, #0x7667ba0
007667B80  adrp     x0, #0x8f6c000
007667B84  ldr      x0, [x0, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
007667B88  bl       #0x382bd14 ; 
007667B8C  adrp     x0, #0x8f6c000
007667B90  ldr      x0, [x0, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
007667B94  bl       #0x382bd14 ; 
007667B98  mov      w8, #1
007667B9C  strb     w8, [x20, #0x459]
007667BA0  adrp     x21, #0x8f6c000
007667BA4  ldr      x21, [x21, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
007667BA8  ldr      x0, [x21]
007667BAC  ldrb     w8, [x0, #0x53]
007667BB0  tbnz     w8, #5, #0x7667be4
007667BB4  adrp     x8, #0x8f6c000
007667BB8  ldr      x8, [x8, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
007667BBC  ldr      x8, [x8]
007667BC0  ldr      x8, [x8, #0xb8]
007667BC4  ldr      x0, [x8]
007667BC8  b        #0x7667bec ; 
007667BCC  ldr      x2, [x1, #0x60]
007667BD0  mov      x0, x19
007667BD4  ldp      x20, x19, [sp, #0x20]
007667BD8  ldp      x22, x21, [sp, #0x10]
007667BDC  ldp      x30, x23, [sp], #0x30
007667BE0  br       x2
007667BE4  ldr      x8, [x0, #0x60]
007667BE8  blr      x8
007667BEC  cbz      x0, #0x7667e00
007667BF0  mov      x1, xzr
007667BF4  bl       #0x70507e4 ; HotFix.WorldBattle$$get_CanEndSkillSelect
007667BF8  tbz      w0, #0, #0x7667c74
007667BFC  mov      w8, #1
007667C00  mov      x0, xzr
007667C04  strb     w8, [x19, #0xa8]
007667C08  bl       #0x6f993bc ; HotFix.BattleGame$$get_ElementCreator
007667C0C  cbz      x0, #0x7667e00
007667C10  adrp     x8, #0x8f73000
007667C14  ldr      x8, [x8, #0xda0] ; GLOBAL Method$HotFix.BattleWorldElementCreator.CreateCommand<SelectTreasureSkillCommand>() @ 0x92402f0
007667C18  mov      w1, #8
007667C1C  ldr      x2, [x8]
007667C20  bl       #0x4540634 ; HotFix.BattleWorldElementCreator$$CreateCommand<object>
007667C24  ldrb     w8, [x20, #0x459]
007667C28  mov      x19, x0
007667C2C  cbnz     w8, #0x7667c50
007667C30  adrp     x0, #0x8f6c000
007667C34  ldr      x0, [x0, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
007667C38  bl       #0x382bd14 ; 
007667C3C  adrp     x0, #0x8f6c000
007667C40  ldr      x0, [x0, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
007667C44  bl       #0x382bd14 ; 
007667C48  mov      w8, #1
007667C4C  strb     w8, [x20, #0x459]
007667C50  ldr      x0, [x21]
007667C54  ldrb     w8, [x0, #0x53]
007667C58  tbnz     w8, #5, #0x7667c84
007667C5C  adrp     x8, #0x8f6c000
007667C60  ldr      x8, [x8, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
007667C64  ldr      x8, [x8]
007667C68  ldr      x8, [x8, #0xb8]
007667C6C  ldr      x0, [x8]
007667C70  b        #0x7667c8c ; 
007667C74  ldp      x20, x19, [sp, #0x20]
007667C78  ldp      x22, x21, [sp, #0x10]
007667C7C  ldp      x30, x23, [sp], #0x30
007667C80  ret      
007667C84  ldr      x8, [x0, #0x60]
007667C88  blr      x8
007667C8C  cbz      x0, #0x7667e00
007667C90  cbz      x19, #0x7667e00
007667C94  ldr      w8, [x0, #0x6c]
007667C98  strb     wzr, [x19, #0x21]
007667C9C  adrp     x22, #0x8ee1000
007667CA0  strb     w8, [x19, #0x20]
007667CA4  ldr      x22, [x22, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
007667CA8  ldr      x0, [x22]
007667CAC  ldr      w8, [x0, #0xe0]
007667CB0  cbnz     w8, #0x7667cb8
007667CB4  bl       #0x382be8c ; 
007667CB8  adrp     x23, #0x9591000
007667CBC  ldrb     w8, [x23, #0x5ba]
007667CC0  cbnz     w8, #0x7667cd8
007667CC4  adrp     x0, #0x8ee1000
007667CC8  ldr      x0, [x0, #0x5e0] ; GLOBAL Framework.GameApp_TypeInfo @ 0x91e70b8
007667CCC  bl       #0x382bd14 ; 
007667CD0  mov      w8, #1
007667CD4  strb     w8, [x23, #0x5ba]
007667CD8  ldr      x0, [x22]
007667CDC  ldr      w8, [x0, #0xe0]
007667CE0  cbnz     w8, #0x7667cec
007667CE4  bl       #0x382be8c ; 
007667CE8  ldr      x0, [x22]
007667CEC  ldr      x8, [x0, #0xb8]
007667CF0  mov      w1, #0x98
007667CF4  mov      x2, x19
007667CF8  mov      x3, xzr
007667CFC  ldr      x0, [x8, #0x10]
007667D00  bl       #0x7270dbc ; HotFix.FrameworkExpand$$DispatchNow
007667D04  adrp     x19, #0x8f6e000
007667D08  ldr      x19, [x19, #0x600] ; GLOBAL HotFix.TreasureViewModule_TypeInfo @ 0x91f2d00
007667D0C  ldr      x0, [x19]
007667D10  ldr      w8, [x0, #0xe0]
007667D14  cbnz     w8, #0x7667d20
007667D18  bl       #0x382be8c ; 
007667D1C  ldr      x0, [x19]
007667D20  ldr      x8, [x0, #0xb8]
007667D24  ldr      x8, [x8]
007667D28  cbz      x8, #0x7667e00
007667D2C  ldrb     w8, [x8, #0x1c]
007667D30  cbz      w8, #0x7667d98
007667D34  ldrb     w8, [x20, #0x459]
007667D38  cbnz     w8, #0x7667d5c
007667D3C  adrp     x0, #0x8f6c000
007667D40  ldr      x0, [x0, #0x980] ; GLOBAL Method$HotFix.BattleGame.get_World() @ 0x923c708
007667D44  bl       #0x382bd14 ; 
007667D48  adrp     x0, #0x8f6c000
007667D4C  ldr      x0, [x0, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
007667D50  bl       #0x382bd14 ; 
007667D54  mov      w8, #1
007667D58  strb     w8, [x20, #0x459]
007667D5C  ldr      x0, [x21]
007667D60  ldrb     w8, [x0, #0x53]
007667D64  tbnz     w8, #5, #0x7667d80
007667D68  adrp     x8, #0x8f6c000
007667D6C  ldr      x8, [x8, #0x988] ; GLOBAL HotFix.BattleGame_TypeInfo @ 0x91e1358
007667D70  ldr      x8, [x8]
007667D74  ldr      x8, [x8, #0xb8]
007667D78  ldr      x0, [x8]
007667D7C  b        #0x7667d88 ; 
007667D80  ldr      x8, [x0, #0x60]
007667D84  blr      x8
007667D88  cbz      x0, #0x7667e00
007667D8C  mov      x1, xzr
007667D90  bl       #0x704d71c ; HotFix.WorldBattle$$ResetTime
007667D94  ldr      x0, [x19]
007667D98  ldr      w8, [x0, #0xe0]
007667D9C  cbnz     w8, #0x7667da8
007667DA0  bl       #0x382be8c ; 
007667DA4  ldr      x0, [x19]
007667DA8  ldr      x8, [x0, #0xb8]
007667DAC  ldr      x19, [x8]
007667DB0  cbz      x19, #0x7667e00
007667DB4  adrp     x8, #0x8f6b000
007667DB8  ldr      x8, [x8, #0xbf8] ; GLOBAL HotFix.Tracker_TypeInfo @ 0x91f2b68
007667DBC  ldr      w20, [x19, #0x10]
007667DC0  ldr      x0, [x8]
007667DC4  ldr      w8, [x0, #0xe0]
007667DC8  cbnz     w8, #0x7667dd0
007667DCC  bl       #0x382be8c ; 
007667DD0  adrp     x8, #0x8fae000
007667DD4  ldr      x8, [x8, #0x200] ; GLOBAL 女武神 @ 0x932d068
007667DD8  mov      x0, x19
007667DDC  mov      w2, w20
007667DE0  ldp      x20, x19, [sp, #0x20]
007667DE4  ldr      x1, [x8]
007667DE8  ldp      x22, x21, [sp, #0x10]
007667DEC  mov      w4, #1
007667DF0  mov      x3, xzr
007667DF4  mov      x5, xzr
007667DF8  ldp      x30, x23, [sp], #0x30
007667DFC  b        #0x781bbc4 ; HotFix.Tracker$$TrackSkillSelect
007667E00  bl       #0x382bfb8 ; 

