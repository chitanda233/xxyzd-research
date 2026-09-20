; HotFix.BattleLogic.BaseSurvivalBattleManager$$EnemySpecialDie
; RVA 0x65875AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065875AC  stp      x30, x21, [sp, #-0x20]!
0065875B0  stp      x20, x19, [sp, #0x10]
0065875B4  adrp     x20, #0x9599000
0065875B8  adrp     x21, #0x8f08000
0065875BC  ldrb     w8, [x20, #0x170]
0065875C0  ldr      x21, [x21, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.BaseSurvivalBattleManager.EnemySpecialDie() @ 0x923bab0
0065875C4  mov      x19, x0
0065875C8  tbnz     w8, #0, #0x65875e0
0065875CC  adrp     x0, #0x8f08000
0065875D0  ldr      x0, [x0, #0xe8] ; GLOBAL Method$HotFix.BattleLogic.BaseSurvivalBattleManager.EnemySpecialDie() @ 0x923bab0
0065875D4  bl       #0x382bd14 ; 
0065875D8  mov      w8, #1
0065875DC  strb     w8, [x20, #0x170]
0065875E0  ldr      x1, [x21]
0065875E4  ldrb     w8, [x1, #0x53]
0065875E8  tbnz     w8, #5, #0x6587604
0065875EC  mov      x0, x19
0065875F0  ldp      x20, x19, [sp, #0x10]
0065875F4  mov      w1, wzr
0065875F8  mov      w2, wzr
0065875FC  ldp      x30, x21, [sp], #0x20
006587600  b        #0x6587518 ; HotFix.BattleLogic.BaseSurvivalBattleManager$$SetRefreshState
006587604  ldr      x2, [x1, #0x60]
006587608  mov      x0, x19
00658760C  ldp      x20, x19, [sp, #0x10]
006587610  ldp      x30, x21, [sp], #0x20
006587614  br       x2

