; HotFix.BattleLogic.CharacterComponentAI$$OnDeathForAI
; RVA 0x6692DCC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006692DCC  stp      x30, x21, [sp, #-0x20]!
006692DD0  stp      x20, x19, [sp, #0x10]
006692DD4  adrp     x20, #0x959a000
006692DD8  adrp     x21, #0x8f10000
006692DDC  ldrb     w8, [x20, #0x41]
006692DE0  ldr      x21, [x21, #0x9e0] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.OnDeathForAI()
006692DE4  mov      x19, x0
006692DE8  tbnz     w8, #0, #0x6692e00
006692DEC  adrp     x0, #0x8f10000
006692DF0  ldr      x0, [x0, #0x9e0] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.OnDeathForAI()
006692DF4  bl       #0x382bd14 ; 
006692DF8  mov      w8, #1
006692DFC  strb     w8, [x20, #0x41]
006692E00  ldr      x1, [x21]
006692E04  ldrb     w8, [x1, #0x53]
006692E08  tbnz     w8, #5, #0x6692e28
006692E0C  ldr      x0, [x19, #0x40]
006692E10  cbz      x0, #0x6692e3c
006692E14  ldp      x20, x19, [sp, #0x10]
006692E18  mov      w1, #6
006692E1C  mov      x2, xzr
006692E20  ldp      x30, x21, [sp], #0x20
006692E24  b        #0x6b7ecc4 ; HotFix.BattleLogic.AIStateController$$ActiveState
006692E28  ldr      x2, [x1, #0x60]
006692E2C  mov      x0, x19
006692E30  ldp      x20, x19, [sp, #0x10]
006692E34  ldp      x30, x21, [sp], #0x20
006692E38  br       x2
006692E3C  bl       #0x382bfb8 ; 

