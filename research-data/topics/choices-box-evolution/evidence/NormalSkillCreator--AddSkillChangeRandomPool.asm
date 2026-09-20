; HotFix.BattleLogic.NormalSkillCreator$$AddSkillChangeRandomPool
; RVA 0x6860EA0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006860EA0  stp      x30, x23, [sp, #-0x30]!
006860EA4  stp      x22, x21, [sp, #0x10]
006860EA8  stp      x20, x19, [sp, #0x20]
006860EAC  adrp     x22, #0x959b000
006860EB0  adrp     x23, #0x8f23000
006860EB4  ldrb     w8, [x22, #0xa98]
006860EB8  ldr      x23, [x23, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.AddSkillChangeRandomPool() @ 0x9295e60
006860EBC  mov      x19, x2
006860EC0  mov      w20, w1
006860EC4  mov      x21, x0
006860EC8  tbnz     w8, #0, #0x6860ee0
006860ECC  adrp     x0, #0x8f23000
006860ED0  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.AddSkillChangeRandomPool() @ 0x9295e60
006860ED4  bl       #0x382bd14 ; 
006860ED8  mov      w8, #1
006860EDC  strb     w8, [x22, #0xa98]
006860EE0  ldr      x3, [x23]
006860EE4  ldrb     w8, [x3, #0x53]
006860EE8  tbnz     w8, #5, #0x6860efc
006860EEC  ldp      x20, x19, [sp, #0x20]
006860EF0  ldp      x22, x21, [sp, #0x10]
006860EF4  ldp      x30, x23, [sp], #0x30
006860EF8  ret      
006860EFC  ldr      x4, [x3, #0x60]
006860F00  mov      x0, x21
006860F04  mov      w1, w20
006860F08  mov      x2, x19
006860F0C  ldp      x20, x19, [sp, #0x20]
006860F10  ldp      x22, x21, [sp, #0x10]
006860F14  ldp      x30, x23, [sp], #0x30
006860F18  br       x4

