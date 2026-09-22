; HotFix.BattleLogic.AIMoveForward$$InitAttackLoop
; RVA 0x654AAF4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654AAF4  stp      x30, x21, [sp, #-0x20]!
00654AAF8  stp      x20, x19, [sp, #0x10]
00654AAFC  adrp     x20, #0x9598000
00654AB00  adrp     x21, #0x8f05000
00654AB04  ldrb     w8, [x20, #0xe2f]
00654AB08  ldr      x21, [x21, #0x7b0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveForward.InitAttackLoop()
00654AB0C  mov      x19, x0
00654AB10  tbnz     w8, #0, #0x654ab34
00654AB14  adrp     x0, #0x8f05000
00654AB18  ldr      x0, [x0, #0x7b0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveForward.InitAttackLoop()
00654AB1C  bl       #0x382bd14 ; 
00654AB20  adrp     x0, #0x8f05000
00654AB24  ldr      x0, [x0, #0x7b8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MoveOnPathEnd>()
00654AB28  bl       #0x382bd14 ; 
00654AB2C  mov      w8, #1
00654AB30  strb     w8, [x20, #0xe2f]
00654AB34  ldr      x1, [x21]
00654AB38  ldrb     w8, [x1, #0x53]
00654AB3C  tbnz     w8, #5, #0x654aba4
00654AB40  ldr      x20, [x19, #0x58]
00654AB44  mov      x0, x19
00654AB48  mov      x1, xzr
00654AB4C  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
00654AB50  cbz      x20, #0x654abb8
00654AB54  mov      x1, x0
00654AB58  mov      x0, x20
00654AB5C  mov      x2, xzr
00654AB60  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
00654AB64  adrp     x8, #0x8f05000
00654AB68  ldr      x8, [x8, #0x7b8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MoveOnPathEnd>()
00654AB6C  mov      x0, x19
00654AB70  ldr      x1, [x8]
00654AB74  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654AB78  ldr      x8, [x19, #0x118]
00654AB7C  cbz      x8, #0x654abb8
00654AB80  mov      x1, x0
00654AB84  cbz      x0, #0x654abb8
00654AB88  ldr      x8, [x8, #0x10]
00654AB8C  mov      x0, x19
00654AB90  ldp      x20, x19, [sp, #0x10]
00654AB94  mov      x2, xzr
00654AB98  str      x8, [x1, #0x78]
00654AB9C  ldp      x30, x21, [sp], #0x20
00654ABA0  b        #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00654ABA4  ldr      x2, [x1, #0x60]
00654ABA8  mov      x0, x19
00654ABAC  ldp      x20, x19, [sp, #0x10]
00654ABB0  ldp      x30, x21, [sp], #0x20
00654ABB4  br       x2
00654ABB8  bl       #0x382bfb8 ; 

