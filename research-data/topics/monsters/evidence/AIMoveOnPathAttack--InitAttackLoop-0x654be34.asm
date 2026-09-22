; HotFix.BattleLogic.AIMoveOnPathAttack$$InitAttackLoop
; RVA 0x654BE34; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654BE34  stp      x30, x21, [sp, #-0x20]!
00654BE38  stp      x20, x19, [sp, #0x10]
00654BE3C  adrp     x20, #0x9598000
00654BE40  adrp     x21, #0x8f05000
00654BE44  ldrb     w8, [x20, #0xe40]
00654BE48  ldr      x21, [x21, #0x8b0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttack.InitAttackLoop()
00654BE4C  mov      x19, x0
00654BE50  tbnz     w8, #0, #0x654be98
00654BE54  adrp     x0, #0x8f05000
00654BE58  ldr      x0, [x0, #0x8b0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttack.InitAttackLoop()
00654BE5C  bl       #0x382bd14 ; 
00654BE60  adrp     x0, #0x8f05000
00654BE64  ldr      x0, [x0, #0x8b8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttack.OnMovePath()
00654BE68  bl       #0x382bd14 ; 
00654BE6C  adrp     x0, #0x8f05000
00654BE70  ldr      x0, [x0, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveOnPath>()
00654BE74  bl       #0x382bd14 ; 
00654BE78  adrp     x0, #0x8f05000
00654BE7C  ldr      x0, [x0, #0x7b8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MoveOnPathEnd>()
00654BE80  bl       #0x382bd14 ; 
00654BE84  adrp     x0, #0x8f05000
00654BE88  ldr      x0, [x0, #0x8c8] ; GLOBAL System.Action<FP>_TypeInfo
00654BE8C  bl       #0x382bd14 ; 
00654BE90  mov      w8, #1
00654BE94  strb     w8, [x20, #0xe40]
00654BE98  ldr      x1, [x21]
00654BE9C  ldrb     w8, [x1, #0x53]
00654BEA0  tbnz     w8, #5, #0x654bf80
00654BEA4  ldr      x20, [x19, #0x58]
00654BEA8  mov      x0, x19
00654BEAC  mov      x1, xzr
00654BEB0  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
00654BEB4  cbz      x20, #0x654bf94
00654BEB8  mov      x1, x0
00654BEBC  mov      x0, x20
00654BEC0  mov      x2, xzr
00654BEC4  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
00654BEC8  adrp     x8, #0x8f05000
00654BECC  ldr      x8, [x8, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveOnPath>()
00654BED0  mov      x0, x19
00654BED4  ldr      x1, [x8]
00654BED8  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654BEDC  ldr      x8, [x19, #0x118]
00654BEE0  cbz      x8, #0x654bf94
00654BEE4  mov      x20, x0
00654BEE8  cbz      x0, #0x654bf94
00654BEEC  ldr      w9, [x8, #0x10]
00654BEF0  str      w9, [x20, #0x70]
00654BEF4  ldr      w8, [x8, #0x18]
00654BEF8  strb     wzr, [x20, #0x75]
00654BEFC  cmp      w8, #1
00654BF00  cset     w8, eq
00654BF04  strb     w8, [x20, #0x74]
00654BF08  adrp     x8, #0x8f05000
00654BF0C  ldr      x8, [x8, #0x8c8] ; GLOBAL System.Action<FP>_TypeInfo
00654BF10  ldr      x0, [x8]
00654BF14  bl       #0x382bfa0 ; 
00654BF18  adrp     x8, #0x8f05000
00654BF1C  ldr      x8, [x8, #0x8b8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttack.OnMovePath()
00654BF20  mov      x1, x19
00654BF24  mov      x3, xzr
00654BF28  mov      x21, x0
00654BF2C  ldr      x2, [x8]
00654BF30  bl       #0x5f40564 ; System.Action<FP>$$.ctor
00654BF34  mov      x0, x20
00654BF38  str      x21, [x0, #0x88]!
00654BF3C  mov      x1, x21
00654BF40  bl       #0x382bcb8 ; 
00654BF44  mov      x0, x19
00654BF48  mov      x1, x20
00654BF4C  mov      x2, xzr
00654BF50  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00654BF54  adrp     x8, #0x8f05000
00654BF58  ldr      x8, [x8, #0x7b8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MoveOnPathEnd>()
00654BF5C  mov      x0, x19
00654BF60  ldr      x1, [x8]
00654BF64  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654BF68  mov      x1, x0
00654BF6C  mov      x0, x19
00654BF70  ldp      x20, x19, [sp, #0x10]
00654BF74  mov      x2, xzr
00654BF78  ldp      x30, x21, [sp], #0x20
00654BF7C  b        #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00654BF80  ldr      x2, [x1, #0x60]
00654BF84  mov      x0, x19
00654BF88  ldp      x20, x19, [sp, #0x10]
00654BF8C  ldp      x30, x21, [sp], #0x20
00654BF90  br       x2
00654BF94  bl       #0x382bfb8 ; 

