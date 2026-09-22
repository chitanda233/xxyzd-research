; HotFix.BattleLogic.WeaponMultiAngleModProcessor$$.ctor
; RVA 0x69D7E84; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D7E84  stp      x30, x21, [sp, #-0x20]!
0069D7E88  stp      x20, x19, [sp, #0x10]
0069D7E8C  adrp     x20, #0x959d000
0069D7E90  adrp     x21, #0x8f31000
0069D7E94  ldrb     w8, [x20, #0x37b]
0069D7E98  ldr      x21, [x21, #0x358] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleModProcessor..ctor()
0069D7E9C  mov      x19, x0
0069D7EA0  tbnz     w8, #0, #0x69d7ec4
0069D7EA4  adrp     x0, #0x8f31000
0069D7EA8  ldr      x0, [x0, #0x360] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<MultiAngleModParams>..ctor()
0069D7EAC  bl       #0x382bd14 ; 
0069D7EB0  adrp     x0, #0x8f31000
0069D7EB4  ldr      x0, [x0, #0x358] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleModProcessor..ctor()
0069D7EB8  bl       #0x382bd14 ; 
0069D7EBC  mov      w8, #1
0069D7EC0  strb     w8, [x20, #0x37b]
0069D7EC4  ldr      x1, [x21]
0069D7EC8  ldrb     w8, [x1, #0x53]
0069D7ECC  tbnz     w8, #5, #0x69d7eec
0069D7ED0  adrp     x8, #0x8f31000
0069D7ED4  ldr      x8, [x8, #0x360] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<MultiAngleModParams>..ctor()
0069D7ED8  mov      x0, x19
0069D7EDC  ldp      x20, x19, [sp, #0x10]
0069D7EE0  ldr      x1, [x8]
0069D7EE4  ldp      x30, x21, [sp], #0x20
0069D7EE8  b        #0x58c8790 ; HotFix.BattleLogic.WeaponModProcessorBase<object>$$.ctor
0069D7EEC  ldr      x2, [x1, #0x60]
0069D7EF0  mov      x0, x19
0069D7EF4  ldp      x20, x19, [sp, #0x10]
0069D7EF8  ldp      x30, x21, [sp], #0x20
0069D7EFC  br       x2

