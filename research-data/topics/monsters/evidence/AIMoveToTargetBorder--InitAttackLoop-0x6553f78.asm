; HotFix.BattleLogic.AIMoveToTargetBorder$$InitAttackLoop
; RVA 0x6553F78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006553F78  str      x30, [sp, #-0x40]!
006553F7C  stp      x24, x23, [sp, #0x10]
006553F80  stp      x22, x21, [sp, #0x20]
006553F84  stp      x20, x19, [sp, #0x30]
006553F88  adrp     x20, #0x9598000
006553F8C  adrp     x21, #0x8f05000
006553F90  ldrb     w8, [x20, #0xe9b]
006553F94  ldr      x21, [x21, #0xd40] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToTargetBorder.InitAttackLoop()
006553F98  mov      x19, x0
006553F9C  tbnz     w8, #0, #0x6554038
006553FA0  adrp     x0, #0x8f05000
006553FA4  ldr      x0, [x0, #0xd40] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToTargetBorder.InitAttackLoop()
006553FA8  bl       #0x382bd14 ; 
006553FAC  adrp     x0, #0x8f05000
006553FB0  ldr      x0, [x0, #0xd48] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToTargetBorder.OnMoveEndIntervalCallback()
006553FB4  bl       #0x382bd14 ; 
006553FB8  adrp     x0, #0x8f05000
006553FBC  ldr      x0, [x0, #0xd50] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToTargetBorder.OnMoveIntervalCallBack()
006553FC0  bl       #0x382bd14 ; 
006553FC4  adrp     x0, #0x8f05000
006553FC8  ldr      x0, [x0, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToTargetBorder.<InitAttackLoop>b__7_0()
006553FCC  bl       #0x382bd14 ; 
006553FD0  adrp     x0, #0x8f05000
006553FD4  ldr      x0, [x0, #0xc80] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveRandomReverse>()
006553FD8  bl       #0x382bd14 ; 
006553FDC  adrp     x0, #0x8f05000
006553FE0  ldr      x0, [x0, #0xd60] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveToTargetBorder>()
006553FE4  bl       #0x382bd14 ; 
006553FE8  adrp     x0, #0x8f05000
006553FEC  ldr      x0, [x0, #0xc90] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<RandomDurationAction>()
006553FF0  bl       #0x382bd14 ; 
006553FF4  adrp     x0, #0x8f05000
006553FF8  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<DoEventAction<FP>>()
006553FFC  bl       #0x382bd14 ; 
006554000  adrp     x0, #0x8f05000
006554004  ldr      x0, [x0, #0xca0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<ParallelAny<FP>>()
006554008  bl       #0x382bd14 ; 
00655400C  adrp     x0, #0x8ec1000
006554010  ldr      x0, [x0, #0x6e8] ; GLOBAL System.Action_TypeInfo
006554014  bl       #0x382bd14 ; 
006554018  adrp     x0, #0x8f05000
00655401C  ldr      x0, [x0, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
006554020  bl       #0x382bd14 ; 
006554024  adrp     x0, #0x8f05000
006554028  ldr      x0, [x0, #0x828] ; GLOBAL Idle
00655402C  bl       #0x382bd14 ; 
006554030  mov      w8, #1
006554034  strb     w8, [x20, #0xe9b]
006554038  ldr      x1, [x21]
00655403C  ldrb     w8, [x1, #0x53]
006554040  tbnz     w8, #5, #0x65541d4
006554044  mov      x0, x19
006554048  mov      x1, xzr
00655404C  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
006554050  ldr      x8, [x19, #0x58]
006554054  cbz      x8, #0x65542e8
006554058  mov      x20, x0
00655405C  mov      x0, x8
006554060  mov      x1, x20
006554064  mov      x2, xzr
006554068  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
00655406C  adrp     x8, #0x8f05000
006554070  ldr      x8, [x8, #0xca0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<ParallelAny<FP>>()
006554074  mov      x0, x19
006554078  ldr      x1, [x8]
00655407C  bl       #0x44b3b00 ; HotFix.BattleLogic.AIStateController$$GetTask<object>
006554080  adrp     x8, #0x8f05000
006554084  ldr      x8, [x8, #0xc80] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveRandomReverse>()
006554088  mov      x21, x0
00655408C  mov      x0, x19
006554090  ldr      x1, [x8]
006554094  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
006554098  cbz      x0, #0x65542e8
00655409C  mov      w8, #1
0065540A0  strb     w8, [x0, #0xc0]
0065540A4  ldr      x8, [x19, #0x118]
0065540A8  mov      x22, x0
0065540AC  cbz      x8, #0x65542e8
0065540B0  ldp      x1, x2, [x8, #0x10]
0065540B4  mov      x0, x22
0065540B8  mov      x3, xzr
0065540BC  bl       #0x6617434 ; HotFix.BattleLogic.MonsterMoveRandomReverse$$SetMinMaxZ
0065540C0  adrp     x8, #0x8f05000
0065540C4  ldr      x8, [x8, #0xc90] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<RandomDurationAction>()
0065540C8  mov      x0, x19
0065540CC  ldr      x1, [x8]
0065540D0  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
0065540D4  ldr      x8, [x19, #0x118]
0065540D8  cbz      x8, #0x65542e8
0065540DC  mov      x23, x0
0065540E0  cbz      x0, #0x65542e8
0065540E4  ldp      x1, x2, [x8, #0x20]
0065540E8  mov      x0, x23
0065540EC  mov      x3, xzr
0065540F0  bl       #0x6624304 ; HotFix.BattleLogic.RandomDurationAction$$SetData
0065540F4  cbz      x21, #0x65542e8
0065540F8  adrp     x24, #0x8f05000
0065540FC  ldr      x24, [x24, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
006554100  mov      x0, x21
006554104  mov      x1, x22
006554108  ldr      x2, [x24]
00655410C  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
006554110  ldr      x2, [x24]
006554114  mov      x0, x21
006554118  mov      x1, x23
00655411C  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
006554120  mov      x0, x19
006554124  mov      x1, x21
006554128  mov      x2, xzr
00655412C  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
006554130  adrp     x8, #0x8f05000
006554134  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<DoEventAction<FP>>()
006554138  mov      x0, x19
00655413C  ldr      x1, [x8]
006554140  bl       #0x44b3b00 ; HotFix.BattleLogic.AIStateController$$GetTask<object>
006554144  adrp     x23, #0x8ec1000
006554148  ldr      x23, [x23, #0x6e8] ; GLOBAL System.Action_TypeInfo
00655414C  mov      x21, x0
006554150  ldr      x8, [x23]
006554154  mov      x0, x8
006554158  bl       #0x382bfa0 ; 
00655415C  adrp     x8, #0x8f05000
006554160  ldr      x8, [x8, #0xd58] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToTargetBorder.<InitAttackLoop>b__7_0()
006554164  mov      x1, x19
006554168  mov      x3, xzr
00655416C  mov      x22, x0
006554170  ldr      x2, [x8]
006554174  bl       #0x7ade578 ; System.Action$$.ctor
006554178  cbz      x21, #0x65542e8
00655417C  mov      x0, x21
006554180  str      x22, [x0, #0x50]!
006554184  mov      x1, x22
006554188  bl       #0x382bcb8 ; 
00655418C  mov      x0, x19
006554190  mov      x1, x21
006554194  mov      x2, xzr
006554198  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00655419C  ldr      x9, [x19, #0x118]
0065541A0  cbz      x9, #0x65542e8
0065541A4  ldr      w8, [x9, #0x38]
0065541A8  cmp      w8, #1
0065541AC  b.lt     #0x65541f0
0065541B0  ldr      x9, [x9, #0x30]
0065541B4  mov      x1, xzr
0065541B8  lsl      x10, x9, #0x11
0065541BC  add      x10, x1, x10, asr #16
0065541C0  subs     w8, w8, #1
0065541C4  add      x1, x10, #0xccb
0065541C8  sbfx     x9, x9, #1, #0x30
0065541CC  b.ne     #0x65541b8
0065541D0  b        #0x65541f4 ; 
0065541D4  ldr      x2, [x1, #0x60]
0065541D8  mov      x0, x19
0065541DC  ldp      x20, x19, [sp, #0x30]
0065541E0  ldp      x22, x21, [sp, #0x20]
0065541E4  ldp      x24, x23, [sp, #0x10]
0065541E8  ldr      x30, [sp], #0x40
0065541EC  br       x2
0065541F0  mov      x1, xzr
0065541F4  mov      x0, x19
0065541F8  mov      x2, xzr
0065541FC  bl       #0x6b809a0 ; HotFix.BattleLogic.AIStateController$$AddTaskWait
006554200  ldr      x0, [x19, #0x58]
006554204  cbz      x0, #0x65542e8
006554208  adrp     x8, #0x8f05000
00655420C  ldr      x8, [x8, #0x828] ; GLOBAL Idle
006554210  mov      x2, xzr
006554214  ldr      x1, [x8]
006554218  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
00655421C  adrp     x8, #0x8f05000
006554220  ldr      x8, [x8, #0xd60] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveToTargetBorder>()
006554224  mov      x0, x19
006554228  ldr      x1, [x8]
00655422C  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
006554230  ldr      x8, [x23]
006554234  mov      x21, x0
006554238  mov      x0, x8
00655423C  bl       #0x382bfa0 ; 
006554240  adrp     x8, #0x8f05000
006554244  ldr      x8, [x8, #0xd50] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToTargetBorder.OnMoveIntervalCallBack()
006554248  mov      x1, x19
00655424C  mov      x3, xzr
006554250  mov      x22, x0
006554254  ldr      x2, [x8]
006554258  bl       #0x7ade578 ; System.Action$$.ctor
00655425C  cbz      x21, #0x65542e8
006554260  mov      x0, x21
006554264  str      x22, [x0, #0x98]!
006554268  mov      x1, x22
00655426C  bl       #0x382bcb8 ; 
006554270  ldr      x0, [x23]
006554274  bl       #0x382bfa0 ; 
006554278  adrp     x8, #0x8f05000
00655427C  ldr      x8, [x8, #0xd48] ; GLOBAL Method$HotFix.BattleLogic.AIMoveToTargetBorder.OnMoveEndIntervalCallback()
006554280  mov      x1, x19
006554284  mov      x3, xzr
006554288  mov      x22, x0
00655428C  ldr      x2, [x8]
006554290  bl       #0x7ade578 ; System.Action$$.ctor
006554294  mov      x0, x21
006554298  str      x22, [x0, #0xd8]!
00655429C  mov      x1, x22
0065542A0  bl       #0x382bcb8 ; 
0065542A4  ldr      x8, [x19, #0x118]
0065542A8  cbz      x8, #0x65542e8
0065542AC  ldr      x2, [x8, #0x58]
0065542B0  ldr      w3, [x8, #0x60]
0065542B4  ldp      x4, x5, [x8, #0x68]
0065542B8  mov      x0, x21
0065542BC  mov      x1, x20
0065542C0  mov      x6, xzr
0065542C4  bl       #0x661ca6c ; HotFix.BattleLogic.MonsterMoveToTargetBorder$$SetData
0065542C8  mov      x0, x19
0065542CC  mov      x1, x21
0065542D0  ldp      x20, x19, [sp, #0x30]
0065542D4  ldp      x22, x21, [sp, #0x20]
0065542D8  ldp      x24, x23, [sp, #0x10]
0065542DC  mov      x2, xzr
0065542E0  ldr      x30, [sp], #0x40
0065542E4  b        #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
0065542E8  bl       #0x382bfb8 ; 

