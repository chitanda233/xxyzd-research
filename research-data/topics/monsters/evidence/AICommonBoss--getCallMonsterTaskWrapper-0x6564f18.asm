; HotFix.BattleLogic.AICommonBoss$$getCallMonsterTaskWrapper
; RVA 0x6564F18; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006564F18  stp      x30, x21, [sp, #-0x20]!
006564F1C  stp      x20, x19, [sp, #0x10]
006564F20  adrp     x20, #0x9598000
006564F24  adrp     x21, #0x8f06000
006564F28  ldrb     w8, [x20, #0xf91]
006564F2C  ldr      x21, [x21, #0x828] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss.getCallMonsterTaskWrapper()
006564F30  mov      x19, x0
006564F34  tbnz     w8, #0, #0x6564f64
006564F38  adrp     x0, #0x8f06000
006564F3C  ldr      x0, [x0, #0x828] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss.getCallMonsterTaskWrapper()
006564F40  bl       #0x382bd14 ; 
006564F44  adrp     x0, #0x8f05000
006564F48  ldr      x0, [x0, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<Parallel<FP>>()
006564F4C  bl       #0x382bd14 ; 
006564F50  adrp     x0, #0x8f05000
006564F54  ldr      x0, [x0, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
006564F58  bl       #0x382bd14 ; 
006564F5C  mov      w8, #1
006564F60  strb     w8, [x20, #0xf91]
006564F64  ldr      x1, [x21]
006564F68  ldrb     w8, [x1, #0x53]
006564F6C  tbnz     w8, #5, #0x6564fd0
006564F70  adrp     x8, #0x8f05000
006564F74  ldr      x8, [x8, #0x810] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetTask<Parallel<FP>>()
006564F78  mov      x0, x19
006564F7C  ldr      x1, [x8]
006564F80  bl       #0x44b3b00 ; HotFix.BattleLogic.AIStateController$$GetTask<object>
006564F84  mov      x20, x0
006564F88  mov      x0, x19
006564F8C  bl       #0x6565b40 ; HotFix.BattleLogic.AICommonBoss$$checkIfEnableCallMonster
006564F90  tbz      w0, #0, #0x6565070
006564F94  adrp     x21, #0x9591000
006564F98  ldrb     w8, [x21, #0xa4b]
006564F9C  cbnz     w8, #0x6564fb4
006564FA0  adrp     x0, #0x8ee5000
006564FA4  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006564FA8  bl       #0x382bd14 ; 
006564FAC  mov      w8, #1
006564FB0  strb     w8, [x21, #0xa4b]
006564FB4  adrp     x8, #0x8ee5000
006564FB8  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
006564FBC  ldr      x1, [x8]
006564FC0  ldrb     w8, [x1, #0x53]
006564FC4  tbnz     w8, #5, #0x6564fe4
006564FC8  ldr      x0, [x19, #0x20]
006564FCC  b        #0x6564ff0 ; 
006564FD0  ldr      x2, [x1, #0x60]
006564FD4  mov      x0, x19
006564FD8  ldp      x20, x19, [sp, #0x10]
006564FDC  ldp      x30, x21, [sp], #0x20
006564FE0  br       x2
006564FE4  ldr      x8, [x1, #0x60]
006564FE8  mov      x0, x19
006564FEC  blr      x8
006564FF0  cbz      x0, #0x6565080
006564FF4  ldr      x9, [x0, #0x128]
006564FF8  ldr      x8, [x19, #0x118]
006564FFC  str      x9, [x19, #0x198]
006565000  cbz      x8, #0x6565080
006565004  ldr      x1, [x8, #0x48]
006565008  cmp      x1, #1
00656500C  b.lt     #0x656504c
006565010  mov      x0, x19
006565014  mov      x2, xzr
006565018  bl       #0x6b95544 ; HotFix.BattleLogic.AIStateController$$GetTaskWait
00656501C  cbz      x20, #0x6565080
006565020  adrp     x21, #0x8f05000
006565024  ldr      x21, [x21, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
006565028  mov      x1, x0
00656502C  mov      x0, x20
006565030  ldr      x2, [x21]
006565034  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
006565038  mov      x0, x19
00656503C  bl       #0x6565c20 ; HotFix.BattleLogic.AICommonBoss$$getCallMonsterTask
006565040  ldr      x2, [x21]
006565044  mov      x1, x0
006565048  b        #0x6565068 ; 
00656504C  mov      x0, x19
006565050  bl       #0x6565c20 ; HotFix.BattleLogic.AICommonBoss$$getCallMonsterTask
006565054  cbz      x20, #0x6565080
006565058  adrp     x8, #0x8f05000
00656505C  ldr      x8, [x8, #0x820] ; GLOBAL Method$HotFix.Common.ParentTaskBase<TaskBase<FP>, FP>.AddChild()
006565060  mov      x1, x0
006565064  ldr      x2, [x8]
006565068  mov      x0, x20
00656506C  bl       #0x52581f0 ; HotFix.Common.ParentTaskBase<object, FP>$$AddChild
006565070  mov      x0, x20
006565074  ldp      x20, x19, [sp, #0x10]
006565078  ldp      x30, x21, [sp], #0x20
00656507C  ret      
006565080  bl       #0x382bfb8 ; 

