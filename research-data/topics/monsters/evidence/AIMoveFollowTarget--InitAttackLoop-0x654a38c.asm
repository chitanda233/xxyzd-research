; HotFix.BattleLogic.AIMoveFollowTarget$$InitAttackLoop
; RVA 0x654A38C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654A38C  stp      x30, x21, [sp, #-0x20]!
00654A390  stp      x20, x19, [sp, #0x10]
00654A394  adrp     x20, #0x9598000
00654A398  adrp     x21, #0x8f05000
00654A39C  ldrb     w8, [x20, #0xe29]
00654A3A0  ldr      x21, [x21, #0x768] ; GLOBAL Method$HotFix.BattleLogic.AIMoveFollowTarget.InitAttackLoop()
00654A3A4  mov      x19, x0
00654A3A8  tbnz     w8, #0, #0x654a3c0
00654A3AC  adrp     x0, #0x8f05000
00654A3B0  ldr      x0, [x0, #0x768] ; GLOBAL Method$HotFix.BattleLogic.AIMoveFollowTarget.InitAttackLoop()
00654A3B4  bl       #0x382bd14 ; 
00654A3B8  mov      w8, #1
00654A3BC  strb     w8, [x20, #0xe29]
00654A3C0  ldr      x1, [x21]
00654A3C4  ldrb     w8, [x1, #0x53]
00654A3C8  tbnz     w8, #5, #0x654a3f8
00654A3CC  ldr      x20, [x19, #0x58]
00654A3D0  mov      x0, x19
00654A3D4  mov      x1, xzr
00654A3D8  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
00654A3DC  cbz      x20, #0x654a40c
00654A3E0  mov      x1, x0
00654A3E4  mov      x0, x20
00654A3E8  ldp      x20, x19, [sp, #0x10]
00654A3EC  mov      x2, xzr
00654A3F0  ldp      x30, x21, [sp], #0x20
00654A3F4  b        #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
00654A3F8  ldr      x2, [x1, #0x60]
00654A3FC  mov      x0, x19
00654A400  ldp      x20, x19, [sp, #0x10]
00654A404  ldp      x30, x21, [sp], #0x20
00654A408  br       x2
00654A40C  bl       #0x382bfb8 ; 

