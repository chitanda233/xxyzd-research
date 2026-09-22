; HotFix.BattleLogic.CharacterComponentAI$$OnLateUpdate
; RVA 0x6692D58; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006692D58  str      x30, [sp, #-0x30]!
006692D5C  stp      x22, x21, [sp, #0x10]
006692D60  stp      x20, x19, [sp, #0x20]
006692D64  adrp     x21, #0x959a000
006692D68  adrp     x22, #0x8f10000
006692D6C  ldrb     w8, [x21, #0x40]
006692D70  ldr      x22, [x22, #0x9d8] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.OnLateUpdate()
006692D74  mov      x19, x1
006692D78  mov      x20, x0
006692D7C  tbnz     w8, #0, #0x6692d94
006692D80  adrp     x0, #0x8f10000
006692D84  ldr      x0, [x0, #0x9d8] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.OnLateUpdate()
006692D88  bl       #0x382bd14 ; 
006692D8C  mov      w8, #1
006692D90  strb     w8, [x21, #0x40]
006692D94  ldr      x2, [x22]
006692D98  ldrb     w8, [x2, #0x53]
006692D9C  tbnz     w8, #5, #0x6692db0
006692DA0  ldp      x20, x19, [sp, #0x20]
006692DA4  ldp      x22, x21, [sp, #0x10]
006692DA8  ldr      x30, [sp], #0x30
006692DAC  ret      
006692DB0  ldr      x3, [x2, #0x60]
006692DB4  mov      x0, x20
006692DB8  mov      x1, x19
006692DBC  ldp      x20, x19, [sp, #0x20]
006692DC0  ldp      x22, x21, [sp, #0x10]
006692DC4  ldr      x30, [sp], #0x30
006692DC8  br       x3

