; HotFix.BattleLogic.WeaponMultiAngleModProcessor$$DeInit
; RVA 0x69D7DA8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D7DA8  stp      x30, x21, [sp, #-0x20]!
0069D7DAC  stp      x20, x19, [sp, #0x10]
0069D7DB0  adrp     x20, #0x959d000
0069D7DB4  adrp     x21, #0x8f31000
0069D7DB8  ldrb     w8, [x20, #0x379]
0069D7DBC  ldr      x21, [x21, #0x348] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleModProcessor.DeInit()
0069D7DC0  mov      x19, x0
0069D7DC4  tbnz     w8, #0, #0x69d7ddc
0069D7DC8  adrp     x0, #0x8f31000
0069D7DCC  ldr      x0, [x0, #0x348] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleModProcessor.DeInit()
0069D7DD0  bl       #0x382bd14 ; 
0069D7DD4  mov      w8, #1
0069D7DD8  strb     w8, [x20, #0x379]
0069D7DDC  ldr      x1, [x21]
0069D7DE0  ldrb     w8, [x1, #0x53]
0069D7DE4  tbnz     w8, #5, #0x69d7df4
0069D7DE8  ldp      x20, x19, [sp, #0x10]
0069D7DEC  ldp      x30, x21, [sp], #0x20
0069D7DF0  ret      
0069D7DF4  ldr      x2, [x1, #0x60]
0069D7DF8  mov      x0, x19
0069D7DFC  ldp      x20, x19, [sp, #0x10]
0069D7E00  ldp      x30, x21, [sp], #0x20
0069D7E04  br       x2

