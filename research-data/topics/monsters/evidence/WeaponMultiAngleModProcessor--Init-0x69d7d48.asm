; HotFix.BattleLogic.WeaponMultiAngleModProcessor$$Init
; RVA 0x69D7D48; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D7D48  stp      x30, x21, [sp, #-0x20]!
0069D7D4C  stp      x20, x19, [sp, #0x10]
0069D7D50  adrp     x20, #0x959d000
0069D7D54  adrp     x21, #0x8f31000
0069D7D58  ldrb     w8, [x20, #0x378]
0069D7D5C  ldr      x21, [x21, #0x340] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleModProcessor.Init()
0069D7D60  mov      x19, x0
0069D7D64  tbnz     w8, #0, #0x69d7d7c
0069D7D68  adrp     x0, #0x8f31000
0069D7D6C  ldr      x0, [x0, #0x340] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleModProcessor.Init()
0069D7D70  bl       #0x382bd14 ; 
0069D7D74  mov      w8, #1
0069D7D78  strb     w8, [x20, #0x378]
0069D7D7C  ldr      x1, [x21]
0069D7D80  ldrb     w8, [x1, #0x53]
0069D7D84  tbnz     w8, #5, #0x69d7d94
0069D7D88  ldp      x20, x19, [sp, #0x10]
0069D7D8C  ldp      x30, x21, [sp], #0x20
0069D7D90  ret      
0069D7D94  ldr      x2, [x1, #0x60]
0069D7D98  mov      x0, x19
0069D7D9C  ldp      x20, x19, [sp, #0x10]
0069D7DA0  ldp      x30, x21, [sp], #0x20
0069D7DA4  br       x2

