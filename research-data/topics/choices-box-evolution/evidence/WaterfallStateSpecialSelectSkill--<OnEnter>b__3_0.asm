; HotFix.BattleLogic.WaterfallStateSpecialSelectSkill$$<OnEnter>b__3_0
; RVA 0x65B7DB4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B7DB4  stp      x30, x21, [sp, #-0x20]!
0065B7DB8  stp      x20, x19, [sp, #0x10]
0065B7DBC  adrp     x20, #0x9599000
0065B7DC0  adrp     x21, #0x8f09000
0065B7DC4  ldrb     w8, [x20, #0x44d]
0065B7DC8  ldr      x21, [x21, #0xcb8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_0() @ 0x92c88c8
0065B7DCC  mov      x19, x0
0065B7DD0  tbnz     w8, #0, #0x65b7de8
0065B7DD4  adrp     x0, #0x8f09000
0065B7DD8  ldr      x0, [x0, #0xcb8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_0() @ 0x92c88c8
0065B7DDC  bl       #0x382bd14 ; 
0065B7DE0  mov      w8, #1
0065B7DE4  strb     w8, [x20, #0x44d]
0065B7DE8  ldr      x1, [x21]
0065B7DEC  ldrb     w8, [x1, #0x53]
0065B7DF0  tbnz     w8, #5, #0x65b7e30
0065B7DF4  adrp     x20, #0x9599000
0065B7DF8  ldrb     w8, [x20, #0x4b1]
0065B7DFC  cbnz     w8, #0x65b7e14
0065B7E00  adrp     x0, #0x8f08000
0065B7E04  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B7E08  bl       #0x382bd14 ; 
0065B7E0C  mov      w8, #1
0065B7E10  strb     w8, [x20, #0x4b1]
0065B7E14  adrp     x8, #0x8f08000
0065B7E18  ldr      x8, [x8, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B7E1C  ldr      x1, [x8]
0065B7E20  ldrb     w8, [x1, #0x53]
0065B7E24  tbnz     w8, #5, #0x65b7e44
0065B7E28  ldr      x0, [x19, #0x10]
0065B7E2C  b        #0x65b7e50 ; 
0065B7E30  ldr      x2, [x1, #0x60]
0065B7E34  mov      x0, x19
0065B7E38  ldp      x20, x19, [sp, #0x10]
0065B7E3C  ldp      x30, x21, [sp], #0x20
0065B7E40  br       x2
0065B7E44  ldr      x8, [x1, #0x60]
0065B7E48  mov      x0, x19
0065B7E4C  blr      x8
0065B7E50  cbz      x0, #0x65b7e64
0065B7E54  ldp      x20, x19, [sp, #0x10]
0065B7E58  mov      x1, xzr
0065B7E5C  ldp      x30, x21, [sp], #0x20
0065B7E60  b        #0x6a0fb34 ; HotFix.BattleLogic.BattleWorldContext$$DispatchPlayExpLevelUpAnimEvent
0065B7E64  bl       #0x382bfb8 ; 

