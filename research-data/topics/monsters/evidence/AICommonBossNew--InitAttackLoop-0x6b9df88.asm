; HotFix.BattleLogic.AICommonBossNew$$InitAttackLoop
; RVA 0x6B9DF88; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B9DF88  stp      x30, x21, [sp, #-0x20]!
006B9DF8C  stp      x20, x19, [sp, #0x10]
006B9DF90  adrp     x20, #0x95a0000
006B9DF94  adrp     x21, #0x8f44000
006B9DF98  ldrb     w8, [x20, #0x94]
006B9DF9C  ldr      x21, [x21, #0x260] ; GLOBAL Method$HotFix.BattleLogic.AICommonBossNew.InitAttackLoop()
006B9DFA0  mov      x19, x0
006B9DFA4  tbnz     w8, #0, #0x6b9dfc8
006B9DFA8  adrp     x0, #0x8f44000
006B9DFAC  ldr      x0, [x0, #0x260] ; GLOBAL Method$HotFix.BattleLogic.AICommonBossNew.InitAttackLoop()
006B9DFB0  bl       #0x382bd14 ; 
006B9DFB4  adrp     x0, #0x8f05000
006B9DFB8  ldr      x0, [x0, #0x828] ; GLOBAL Idle
006B9DFBC  bl       #0x382bd14 ; 
006B9DFC0  mov      w8, #1
006B9DFC4  strb     w8, [x20, #0x94]
006B9DFC8  ldr      x1, [x21]
006B9DFCC  ldrb     w8, [x1, #0x53]
006B9DFD0  tbnz     w8, #5, #0x6b9e048
006B9DFD4  ldr      x1, [x19, #0x148]
006B9DFD8  mov      x0, x19
006B9DFDC  bl       #0x6b90668 ; HotFix.BattleLogic.AIStateController$$SelectWeightedRandomIndex
006B9DFE0  cbz      w0, #0x6b9e05c
006B9DFE4  mov      w20, w0
006B9DFE8  ldr      x0, [x19, #0x58]
006B9DFEC  cbz      x0, #0x6b9e0a4
006B9DFF0  adrp     x8, #0x8f05000
006B9DFF4  ldr      x8, [x8, #0x828] ; GLOBAL Idle
006B9DFF8  mov      x2, xzr
006B9DFFC  ldr      x1, [x8]
006B9E000  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
006B9E004  ldr      x21, [x19, #0x58]
006B9E008  mov      x0, x19
006B9E00C  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
006B9E010  cbz      x21, #0x6b9e0a4
006B9E014  mov      x1, x0
006B9E018  mov      x0, x21
006B9E01C  mov      x2, xzr
006B9E020  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
006B9E024  cmp      w20, #2
006B9E028  b.eq     #0x6b9e074
006B9E02C  cmp      w20, #1
006B9E030  b.ne     #0x6b9e098
006B9E034  ldr      x0, [x19, #0x168]
006B9E038  cbz      x0, #0x6b9e098
006B9E03C  mov      x1, xzr
006B9E040  bl       #0x656dcf8 ; HotFix.BattleLogic.CallMonsterBehaviorHandler$$CreateCallMonsterTask
006B9E044  b        #0x6b9e084 ; 
006B9E048  ldr      x2, [x1, #0x60]
006B9E04C  mov      x0, x19
006B9E050  ldp      x20, x19, [sp, #0x10]
006B9E054  ldp      x30, x21, [sp], #0x20
006B9E058  br       x2
006B9E05C  ldr      x0, [x19, #0x50]
006B9E060  cbz      x0, #0x6b9e0a4
006B9E064  ldp      x20, x19, [sp, #0x10]
006B9E068  mov      x1, xzr
006B9E06C  ldp      x30, x21, [sp], #0x20
006B9E070  b        #0x6572114 ; HotFix.BattleLogic.AIStatusManager$$ExecuteEntityBehaviour
006B9E074  ldr      x0, [x19, #0x170]
006B9E078  cbz      x0, #0x6b9e098
006B9E07C  mov      x1, xzr
006B9E080  bl       #0x656fa34 ; HotFix.BattleLogic.RushBehaviorHandler$$CreateRushTask
006B9E084  mov      x1, x0
006B9E088  mov      x0, x19
006B9E08C  ldp      x20, x19, [sp, #0x10]
006B9E090  ldp      x30, x21, [sp], #0x20
006B9E094  b        #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
006B9E098  ldp      x20, x19, [sp, #0x10]
006B9E09C  ldp      x30, x21, [sp], #0x20
006B9E0A0  ret      
006B9E0A4  bl       #0x382bfb8 ; 

