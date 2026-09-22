; HotFix.BattleLogic.CharacterComponentAI$$ActiveState
; RVA 0x6692E40; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006692E40  str      x30, [sp, #-0x30]!
006692E44  stp      x22, x21, [sp, #0x10]
006692E48  stp      x20, x19, [sp, #0x20]
006692E4C  adrp     x21, #0x959a000
006692E50  adrp     x22, #0x8f10000
006692E54  ldrb     w8, [x21, #0x42]
006692E58  ldr      x22, [x22, #0x9e8] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.ActiveState()
006692E5C  mov      w19, w1
006692E60  mov      x20, x0
006692E64  tbnz     w8, #0, #0x6692e7c
006692E68  adrp     x0, #0x8f10000
006692E6C  ldr      x0, [x0, #0x9e8] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.ActiveState()
006692E70  bl       #0x382bd14 ; 
006692E74  mov      w8, #1
006692E78  strb     w8, [x21, #0x42]
006692E7C  ldr      x2, [x22]
006692E80  ldrb     w8, [x2, #0x53]
006692E84  tbnz     w8, #5, #0x6692ea8
006692E88  ldr      x0, [x20, #0x40]
006692E8C  cbz      x0, #0x6692ec4
006692E90  mov      w1, w19
006692E94  ldp      x20, x19, [sp, #0x20]
006692E98  ldp      x22, x21, [sp, #0x10]
006692E9C  mov      x2, xzr
006692EA0  ldr      x30, [sp], #0x30
006692EA4  b        #0x6b7ecc4 ; HotFix.BattleLogic.AIStateController$$ActiveState
006692EA8  ldr      x3, [x2, #0x60]
006692EAC  mov      x0, x20
006692EB0  mov      w1, w19
006692EB4  ldp      x20, x19, [sp, #0x20]
006692EB8  ldp      x22, x21, [sp, #0x10]
006692EBC  ldr      x30, [sp], #0x30
006692EC0  br       x3
006692EC4  bl       #0x382bfb8 ; 

