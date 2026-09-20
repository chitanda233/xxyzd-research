; HotFix.BattleLogic.WeightRandomData$$GetSkillFlags
; RVA 0x6631D78; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006631D78  stp      x30, x21, [sp, #-0x20]!
006631D7C  stp      x20, x19, [sp, #0x10]
006631D80  adrp     x20, #0x9599000
006631D84  adrp     x21, #0x8f0c000
006631D88  ldrb     w8, [x20, #0x9bb]
006631D8C  ldr      x21, [x21, #0xea0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetSkillFlags() @ 0x92cbba8
006631D90  mov      x19, x0
006631D94  tbnz     w8, #0, #0x6631dac
006631D98  adrp     x0, #0x8f0c000
006631D9C  ldr      x0, [x0, #0xea0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.GetSkillFlags() @ 0x92cbba8
006631DA0  bl       #0x382bd14 ; 
006631DA4  mov      w8, #1
006631DA8  strb     w8, [x20, #0x9bb]
006631DAC  ldr      x1, [x21]
006631DB0  ldrb     w8, [x1, #0x53]
006631DB4  tbnz     w8, #5, #0x6631dc8
006631DB8  ldr      x0, [x19, #0x10]
006631DBC  ldp      x20, x19, [sp, #0x10]
006631DC0  ldp      x30, x21, [sp], #0x20
006631DC4  ret      
006631DC8  ldr      x2, [x1, #0x60]
006631DCC  mov      x0, x19
006631DD0  ldp      x20, x19, [sp, #0x10]
006631DD4  ldp      x30, x21, [sp], #0x20
006631DD8  br       x2

