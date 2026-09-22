; HotFix.BattleLogic.WeaponMultiAngleModProcessor$$OnEvent
; RVA 0x69D7E08; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D7E08  stp      x30, x23, [sp, #-0x30]!
0069D7E0C  stp      x22, x21, [sp, #0x10]
0069D7E10  stp      x20, x19, [sp, #0x20]
0069D7E14  adrp     x22, #0x959d000
0069D7E18  adrp     x23, #0x8f31000
0069D7E1C  ldrb     w8, [x22, #0x37a]
0069D7E20  ldr      x23, [x23, #0x350] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleModProcessor.OnEvent()
0069D7E24  mov      x19, x2
0069D7E28  mov      w20, w1
0069D7E2C  mov      x21, x0
0069D7E30  tbnz     w8, #0, #0x69d7e48
0069D7E34  adrp     x0, #0x8f31000
0069D7E38  ldr      x0, [x0, #0x350] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiAngleModProcessor.OnEvent()
0069D7E3C  bl       #0x382bd14 ; 
0069D7E40  mov      w8, #1
0069D7E44  strb     w8, [x22, #0x37a]
0069D7E48  ldr      x3, [x23]
0069D7E4C  ldrb     w8, [x3, #0x53]
0069D7E50  tbnz     w8, #5, #0x69d7e64
0069D7E54  ldp      x20, x19, [sp, #0x20]
0069D7E58  ldp      x22, x21, [sp, #0x10]
0069D7E5C  ldp      x30, x23, [sp], #0x30
0069D7E60  ret      
0069D7E64  ldr      x4, [x3, #0x60]
0069D7E68  mov      x0, x21
0069D7E6C  mov      w1, w20
0069D7E70  mov      x2, x19
0069D7E74  ldp      x20, x19, [sp, #0x20]
0069D7E78  ldp      x22, x21, [sp, #0x10]
0069D7E7C  ldp      x30, x23, [sp], #0x30
0069D7E80  br       x4

