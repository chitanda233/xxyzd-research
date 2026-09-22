; HotFix.BattleLogic.MonsterMoveInTwoPoint$$.ctor
; RVA 0x661580C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00661580C  stp      x30, x21, [sp, #-0x20]!
006615810  stp      x20, x19, [sp, #0x10]
006615814  adrp     x20, #0x9599000
006615818  adrp     x21, #0x8f0c000
00661581C  ldrb     w8, [x20, #0x87c]
006615820  ldr      x21, [x21, #0x3b8] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint..ctor()
006615824  mov      x19, x0
006615828  tbnz     w8, #0, #0x661584c
00661582C  adrp     x0, #0x8f0a000
006615830  ldr      x0, [x0, #0xfb8] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>..ctor()
006615834  bl       #0x382bd14 ; 
006615838  adrp     x0, #0x8f0c000
00661583C  ldr      x0, [x0, #0x3b8] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveInTwoPoint..ctor()
006615840  bl       #0x382bd14 ; 
006615844  mov      w8, #1
006615848  strb     w8, [x20, #0x87c]
00661584C  ldr      x1, [x21]
006615850  ldrb     w8, [x1, #0x53]
006615854  tbnz     w8, #5, #0x6615874
006615858  adrp     x8, #0x8f0a000
00661585C  ldr      x8, [x8, #0xfb8] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>..ctor()
006615860  mov      x0, x19
006615864  ldp      x20, x19, [sp, #0x10]
006615868  ldr      x1, [x8]
00661586C  ldp      x30, x21, [sp], #0x20
006615870  b        #0x5b86ac0 ; HotFix.BattleLogic.BehaviorAction<object>$$.ctor
006615874  ldr      x2, [x1, #0x60]
006615878  mov      x0, x19
00661587C  ldp      x20, x19, [sp, #0x10]
006615880  ldp      x30, x21, [sp], #0x20
006615884  br       x2

