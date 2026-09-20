; HotFix.BattleLogic.BattleWorldContext$$IsDankeSkill
; RVA 0x6A04794; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A04794  stp      x30, x21, [sp, #-0x20]!
006A04798  stp      x20, x19, [sp, #0x10]
006A0479C  adrp     x20, #0x959d000
006A047A0  adrp     x21, #0x8f32000
006A047A4  ldrb     w8, [x20, #0x58e]
006A047A8  ldr      x21, [x21, #0x790] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.IsDankeSkill() @ 0x923fa78
006A047AC  mov      x19, x0
006A047B0  tbnz     w8, #0, #0x6a047c8
006A047B4  adrp     x0, #0x8f32000
006A047B8  ldr      x0, [x0, #0x790] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.IsDankeSkill() @ 0x923fa78
006A047BC  bl       #0x382bd14 ; 
006A047C0  mov      w8, #1
006A047C4  strb     w8, [x20, #0x58e]
006A047C8  ldr      x1, [x21]
006A047CC  ldrb     w8, [x1, #0x53]
006A047D0  tbnz     w8, #5, #0x6a047f0
006A047D4  mov      x0, x19
006A047D8  bl       #0x6a04804 ; HotFix.BattleLogic.BattleWorldContext$$GetChapterSkillType
006A047DC  ldp      x20, x19, [sp, #0x10]
006A047E0  cmp      w0, #2
006A047E4  cset     w0, eq
006A047E8  ldp      x30, x21, [sp], #0x20
006A047EC  ret      
006A047F0  ldr      x2, [x1, #0x60]
006A047F4  mov      x0, x19
006A047F8  ldp      x20, x19, [sp, #0x10]
006A047FC  ldp      x30, x21, [sp], #0x20
006A04800  br       x2

