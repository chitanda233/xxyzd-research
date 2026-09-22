; HotFix.BattleLogic.MonsterMoveToPoint$$.ctor
; RVA 0x661C3A8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00661C3A8  stp      x30, x21, [sp, #-0x20]!
00661C3AC  stp      x20, x19, [sp, #0x10]
00661C3B0  adrp     x20, #0x9599000
00661C3B4  adrp     x21, #0x8f0c000
00661C3B8  ldrb     w8, [x20, #0x8b7]
00661C3BC  ldr      x21, [x21, #0x5a0] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint..ctor()
00661C3C0  mov      x19, x0
00661C3C4  tbnz     w8, #0, #0x661c3e8
00661C3C8  adrp     x0, #0x8f0a000
00661C3CC  ldr      x0, [x0, #0xfb8] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>..ctor()
00661C3D0  bl       #0x382bd14 ; 
00661C3D4  adrp     x0, #0x8f0c000
00661C3D8  ldr      x0, [x0, #0x5a0] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveToPoint..ctor()
00661C3DC  bl       #0x382bd14 ; 
00661C3E0  mov      w8, #1
00661C3E4  strb     w8, [x20, #0x8b7]
00661C3E8  ldr      x1, [x21]
00661C3EC  ldrb     w8, [x1, #0x53]
00661C3F0  tbnz     w8, #5, #0x661c410
00661C3F4  adrp     x8, #0x8f0a000
00661C3F8  ldr      x8, [x8, #0xfb8] ; GLOBAL Method$HotFix.BattleLogic.BehaviorAction<EntityCharacter>..ctor()
00661C3FC  mov      x0, x19
00661C400  ldp      x20, x19, [sp, #0x10]
00661C404  ldr      x1, [x8]
00661C408  ldp      x30, x21, [sp], #0x20
00661C40C  b        #0x5b86ac0 ; HotFix.BattleLogic.BehaviorAction<object>$$.ctor
00661C410  ldr      x2, [x1, #0x60]
00661C414  mov      x0, x19
00661C418  ldp      x20, x19, [sp, #0x10]
00661C41C  ldp      x30, x21, [sp], #0x20
00661C420  br       x2

