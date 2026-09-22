; HotFix.BattleLogic.WeaponMultiModProcessor$$OnEvent
; RVA 0x69D886C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D886C  stp      x30, x23, [sp, #-0x30]!
0069D8870  stp      x22, x21, [sp, #0x10]
0069D8874  stp      x20, x19, [sp, #0x20]
0069D8878  adrp     x22, #0x959d000
0069D887C  adrp     x23, #0x8f31000
0069D8880  ldrb     w8, [x22, #0x384]
0069D8884  ldr      x23, [x23, #0x3d0] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor.OnEvent()
0069D8888  mov      x19, x2
0069D888C  mov      w20, w1
0069D8890  mov      x21, x0
0069D8894  tbnz     w8, #0, #0x69d88ac
0069D8898  adrp     x0, #0x8f31000
0069D889C  ldr      x0, [x0, #0x3d0] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor.OnEvent()
0069D88A0  bl       #0x382bd14 ; 
0069D88A4  mov      w8, #1
0069D88A8  strb     w8, [x22, #0x384]
0069D88AC  ldr      x3, [x23]
0069D88B0  ldrb     w8, [x3, #0x53]
0069D88B4  tbnz     w8, #5, #0x69d88c8
0069D88B8  ldp      x20, x19, [sp, #0x20]
0069D88BC  ldp      x22, x21, [sp, #0x10]
0069D88C0  ldp      x30, x23, [sp], #0x30
0069D88C4  ret      
0069D88C8  ldr      x4, [x3, #0x60]
0069D88CC  mov      x0, x21
0069D88D0  mov      w1, w20
0069D88D4  mov      x2, x19
0069D88D8  ldp      x20, x19, [sp, #0x20]
0069D88DC  ldp      x22, x21, [sp, #0x10]
0069D88E0  ldp      x30, x23, [sp], #0x30
0069D88E4  br       x4

