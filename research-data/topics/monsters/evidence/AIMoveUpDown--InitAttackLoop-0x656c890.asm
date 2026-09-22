; HotFix.BattleLogic.AIMoveUpDown$$InitAttackLoop
; RVA 0x656C890; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00656C890  stp      x30, x23, [sp, #-0x30]!
00656C894  stp      x22, x21, [sp, #0x10]
00656C898  stp      x20, x19, [sp, #0x20]
00656C89C  adrp     x20, #0x9599000
00656C8A0  adrp     x21, #0x8f06000
00656C8A4  ldrb     w8, [x20, #9]
00656C8A8  ldr      x21, [x21, #0xbe8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveUpDown.InitAttackLoop()
00656C8AC  mov      x19, x0
00656C8B0  tbnz     w8, #0, #0x656c94c
00656C8B4  adrp     x0, #0x8f06000
00656C8B8  ldr      x0, [x0, #0xbe8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveUpDown.InitAttackLoop()
00656C8BC  bl       #0x382bd14 ; 
00656C8C0  adrp     x0, #0x8f06000
00656C8C4  ldr      x0, [x0, #0xbf0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveUpDown.<InitAttackLoop>b__7_0()
00656C8C8  bl       #0x382bd14 ; 
00656C8CC  adrp     x0, #0x8f06000
00656C8D0  ldr      x0, [x0, #0xbf8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveUpDown.onMoveDownCallback()
00656C8D4  bl       #0x382bd14 ; 
00656C8D8  adrp     x0, #0x8f06000
00656C8DC  ldr      x0, [x0, #0xc00] ; GLOBAL Method$HotFix.BattleLogic.AIMoveUpDown.onMoveUpCallback()
00656C8E0  bl       #0x382bd14 ; 
00656C8E4  adrp     x0, #0x8f05000
00656C8E8  ldr      x0, [x0, #0xc80] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveRandomReverse>()
00656C8EC  bl       #0x382bd14 ; 
00656C8F0  adrp     x0, #0x8f06000
00656C8F4  ldr      x0, [x0, #0xc08] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveTopToBottom>()
00656C8F8  bl       #0x382bd14 ; 
00656C8FC  adrp     x0, #0x8f05000
00656C900  ldr      x0, [x0, #0xc90] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<RandomDurationAction>()
00656C904  bl       #0x382bd14 ; 
00656C908  adrp     x0, #0x8f05000
00656C90C  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<DoEventAction<FP>>()
00656C910  bl       #0x382bd14 ; 
00656C914  adrp     x0, #0x8f05000
00656C918  ldr      x0, [x0, #0xca0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<ParallelAny<FP>>()
00656C91C  bl       #0x382bd14 ; 
00656C920  adrp     x0, #0x8ec1000
00656C924  ldr      x0, [x0, #0x6e8] ; GLOBAL System.Action_TypeInfo
00656C928  bl       #0x382bd14 ; 
00656C92C  adrp     x0, #0x8f05000
00656C930  ldr      x0, [x0, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
00656C934  bl       #0x382bd14 ; 
00656C938  adrp     x0, #0x8f05000
00656C93C  ldr      x0, [x0, #0x828] ; GLOBAL Idle
00656C940  bl       #0x382bd14 ; 
00656C944  mov      w8, #1
00656C948  strb     w8, [x20, #9]
00656C94C  ldr      x1, [x21]
00656C950  ldrb     w8, [x1, #0x53]
00656C954  tbnz     w8, #5, #0x656cabc
00656C958  adrp     x8, #0x8f05000
00656C95C  ldr      x8, [x8, #0xca0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<ParallelAny<FP>>()
00656C960  adrp     x20, #0x8f05000
00656C964  mov      x0, x19
00656C968  ldr      x1, [x8]
00656C96C  ldr      x20, [x20, #0xc80] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveRandomReverse>()
00656C970  bl       #0x44b3b00 ; HotFix.BattleLogic.AIStateController$$GetTask<object>
00656C974  ldr      x1, [x20]
00656C978  mov      x20, x0
00656C97C  mov      x0, x19
00656C980  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00656C984  cbz      x0, #0x656cc98
00656C988  mov      w8, #1
00656C98C  strb     w8, [x0, #0xc0]
00656C990  ldr      x8, [x19, #0x118]
00656C994  mov      x21, x0
00656C998  cbz      x8, #0x656cc98
00656C99C  ldp      x1, x2, [x8, #0x10]
00656C9A0  mov      x0, x21
00656C9A4  mov      x3, xzr
00656C9A8  bl       #0x6617434 ; HotFix.BattleLogic.MonsterMoveRandomReverse$$SetMinMaxZ
00656C9AC  adrp     x8, #0x8f05000
00656C9B0  ldr      x8, [x8, #0xc90] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<RandomDurationAction>()
00656C9B4  mov      x0, x19
00656C9B8  ldr      x1, [x8]
00656C9BC  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00656C9C0  ldr      x8, [x19, #0x118]
00656C9C4  cbz      x8, #0x656cc98
00656C9C8  mov      x22, x0
00656C9CC  cbz      x0, #0x656cc98
00656C9D0  ldp      x1, x2, [x8, #0x38]
00656C9D4  mov      x0, x22
00656C9D8  mov      x3, xzr
00656C9DC  bl       #0x6624304 ; HotFix.BattleLogic.RandomDurationAction$$SetData
00656C9E0  cbz      x20, #0x656cc98
00656C9E4  adrp     x23, #0x8f05000
00656C9E8  ldr      x23, [x23, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
00656C9EC  mov      x0, x20
00656C9F0  mov      x1, x21
00656C9F4  ldr      x2, [x23]
00656C9F8  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
00656C9FC  ldr      x2, [x23]
00656CA00  mov      x0, x20
00656CA04  mov      x1, x22
00656CA08  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
00656CA0C  mov      x0, x19
00656CA10  mov      x1, x20
00656CA14  mov      x2, xzr
00656CA18  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00656CA1C  adrp     x8, #0x8f05000
00656CA20  ldr      x8, [x8, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<DoEventAction<FP>>()
00656CA24  mov      x0, x19
00656CA28  ldr      x1, [x8]
00656CA2C  bl       #0x44b3b00 ; HotFix.BattleLogic.AIStateController$$GetTask<object>
00656CA30  adrp     x22, #0x8ec1000
00656CA34  ldr      x22, [x22, #0x6e8] ; GLOBAL System.Action_TypeInfo
00656CA38  mov      x20, x0
00656CA3C  ldr      x8, [x22]
00656CA40  mov      x0, x8
00656CA44  bl       #0x382bfa0 ; 
00656CA48  adrp     x8, #0x8f06000
00656CA4C  ldr      x8, [x8, #0xbf0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveUpDown.<InitAttackLoop>b__7_0()
00656CA50  mov      x1, x19
00656CA54  mov      x3, xzr
00656CA58  mov      x21, x0
00656CA5C  ldr      x2, [x8]
00656CA60  bl       #0x7ade578 ; System.Action$$.ctor
00656CA64  cbz      x20, #0x656cc98
00656CA68  mov      x0, x20
00656CA6C  str      x21, [x0, #0x50]!
00656CA70  mov      x1, x21
00656CA74  bl       #0x382bcb8 ; 
00656CA78  mov      x0, x19
00656CA7C  mov      x1, x20
00656CA80  mov      x2, xzr
00656CA84  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00656CA88  ldr      x9, [x19, #0x118]
00656CA8C  cbz      x9, #0x656cc98
00656CA90  ldr      w8, [x9, #0x50]
00656CA94  cmp      w8, #1
00656CA98  b.lt     #0x656cad4
00656CA9C  ldr      x9, [x9, #0x48]
00656CAA0  mov      x1, xzr
00656CAA4  add      x10, x1, x9, lsl #1
00656CAA8  subs     w8, w8, #1
00656CAAC  add      x1, x10, #0xccb
00656CAB0  sbfx     x9, x9, #1, #0x30
00656CAB4  b.ne     #0x656caa4
00656CAB8  b        #0x656cad8 ; 
00656CABC  ldr      x2, [x1, #0x60]
00656CAC0  mov      x0, x19
00656CAC4  ldp      x20, x19, [sp, #0x20]
00656CAC8  ldp      x22, x21, [sp, #0x10]
00656CACC  ldp      x30, x23, [sp], #0x30
00656CAD0  br       x2
00656CAD4  mov      x1, xzr
00656CAD8  mov      x0, x19
00656CADC  mov      x2, xzr
00656CAE0  bl       #0x6b809a0 ; HotFix.BattleLogic.AIStateController$$AddTaskWait
00656CAE4  ldr      x0, [x19, #0x58]
00656CAE8  cbz      x0, #0x656cc98
00656CAEC  adrp     x8, #0x8f05000
00656CAF0  ldr      x8, [x8, #0x828] ; GLOBAL Idle
00656CAF4  mov      x2, xzr
00656CAF8  ldr      x1, [x8]
00656CAFC  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
00656CB00  adrp     x8, #0x8f06000
00656CB04  ldr      x8, [x8, #0xc08] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveTopToBottom>()
00656CB08  mov      x0, x19
00656CB0C  ldr      x1, [x8]
00656CB10  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00656CB14  ldr      x8, [x19, #0x118]
00656CB18  cbz      x8, #0x656cc98
00656CB1C  mov      x20, x0
00656CB20  cbz      x0, #0x656cc98
00656CB24  adrp     x23, #0x9599000
00656CB28  ldrb     w9, [x23, #0x26c]
00656CB2C  ldr      x21, [x8, #0x70]
00656CB30  cbnz     w9, #0x656cb48
00656CB34  adrp     x0, #0x8f06000
00656CB38  ldr      x0, [x0, #0xc10] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveTopToBottom.SetRushSpeed()
00656CB3C  bl       #0x382bd14 ; 
00656CB40  mov      w8, #1
00656CB44  strb     w8, [x23, #0x26c]
00656CB48  adrp     x8, #0x8f06000
00656CB4C  ldr      x8, [x8, #0xc10] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveTopToBottom.SetRushSpeed()
00656CB50  ldr      x2, [x8]
00656CB54  ldrb     w8, [x2, #0x53]
00656CB58  tbnz     w8, #5, #0x656cb64
00656CB5C  str      x21, [x20, #0x120]
00656CB60  b        #0x656cb74 ; 
00656CB64  ldr      x8, [x2, #0x60]
00656CB68  mov      x0, x20
00656CB6C  mov      x1, x21
00656CB70  blr      x8
00656CB74  ldr      x0, [x22]
00656CB78  bl       #0x382bfa0 ; 
00656CB7C  adrp     x8, #0x8f06000
00656CB80  ldr      x8, [x8, #0xbf8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveUpDown.onMoveDownCallback()
00656CB84  mov      x1, x19
00656CB88  mov      x3, xzr
00656CB8C  mov      x21, x0
00656CB90  ldr      x2, [x8]
00656CB94  bl       #0x7ade578 ; System.Action$$.ctor
00656CB98  adrp     x23, #0x9599000
00656CB9C  ldrb     w8, [x23, #0x26d]
00656CBA0  cbnz     w8, #0x656cbb8
00656CBA4  adrp     x0, #0x8f06000
00656CBA8  ldr      x0, [x0, #0xc18] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveTopToBottom.set_OnMoveDownCallback()
00656CBAC  bl       #0x382bd14 ; 
00656CBB0  mov      w8, #1
00656CBB4  strb     w8, [x23, #0x26d]
00656CBB8  adrp     x8, #0x8f06000
00656CBBC  ldr      x8, [x8, #0xc18] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveTopToBottom.set_OnMoveDownCallback()
00656CBC0  ldr      x2, [x8]
00656CBC4  ldrb     w8, [x2, #0x53]
00656CBC8  tbnz     w8, #5, #0x656cbe0
00656CBCC  add      x0, x20, #0x100
00656CBD0  mov      x1, x21
00656CBD4  str      x21, [x20, #0x100]
00656CBD8  bl       #0x382bcb8 ; 
00656CBDC  b        #0x656cbf0 ; 
00656CBE0  ldr      x8, [x2, #0x60]
00656CBE4  mov      x0, x20
00656CBE8  mov      x1, x21
00656CBEC  blr      x8
00656CBF0  ldr      x0, [x22]
00656CBF4  bl       #0x382bfa0 ; 
00656CBF8  adrp     x8, #0x8f06000
00656CBFC  ldr      x8, [x8, #0xc00] ; GLOBAL Method$HotFix.BattleLogic.AIMoveUpDown.onMoveUpCallback()
00656CC00  mov      x1, x19
00656CC04  mov      x3, xzr
00656CC08  mov      x21, x0
00656CC0C  ldr      x2, [x8]
00656CC10  bl       #0x7ade578 ; System.Action$$.ctor
00656CC14  adrp     x22, #0x9599000
00656CC18  ldrb     w8, [x22, #0x26e]
00656CC1C  cbnz     w8, #0x656cc34
00656CC20  adrp     x0, #0x8f06000
00656CC24  ldr      x0, [x0, #0xc20] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveTopToBottom.set_OnMoveUpCallback()
00656CC28  bl       #0x382bd14 ; 
00656CC2C  mov      w8, #1
00656CC30  strb     w8, [x22, #0x26e]
00656CC34  adrp     x8, #0x8f06000
00656CC38  ldr      x8, [x8, #0xc20] ; GLOBAL Method$HotFix.BattleLogic.MonsterMoveTopToBottom.set_OnMoveUpCallback()
00656CC3C  ldr      x2, [x8]
00656CC40  ldrb     w8, [x2, #0x53]
00656CC44  tbnz     w8, #5, #0x656cc5c
00656CC48  add      x0, x20, #0x108
00656CC4C  mov      x1, x21
00656CC50  str      x21, [x20, #0x108]
00656CC54  bl       #0x382bcb8 ; 
00656CC58  b        #0x656cc6c ; 
00656CC5C  ldr      x8, [x2, #0x60]
00656CC60  mov      x0, x20
00656CC64  mov      x1, x21
00656CC68  blr      x8
00656CC6C  ldr      x1, [x19, #0x118]
00656CC70  mov      x0, x20
00656CC74  mov      x2, xzr
00656CC78  bl       #0x661af24 ; HotFix.BattleLogic.MonsterMoveTopToBottom$$SetByDataParams
00656CC7C  mov      x0, x19
00656CC80  mov      x1, x20
00656CC84  ldp      x20, x19, [sp, #0x20]
00656CC88  ldp      x22, x21, [sp, #0x10]
00656CC8C  mov      x2, xzr
00656CC90  ldp      x30, x23, [sp], #0x30
00656CC94  b        #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00656CC98  bl       #0x382bfb8 ; 

