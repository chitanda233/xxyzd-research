; HotFix.BattleLogic.CharacterComponentAI$$StopAIAndAction
; RVA 0x6692EC8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006692EC8  stp      x30, x21, [sp, #-0x20]!
006692ECC  stp      x20, x19, [sp, #0x10]
006692ED0  adrp     x20, #0x959a000
006692ED4  adrp     x21, #0x8f10000
006692ED8  ldrb     w8, [x20, #0x43]
006692EDC  ldr      x21, [x21, #0x9f0] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.StopAIAndAction()
006692EE0  mov      x19, x0
006692EE4  tbnz     w8, #0, #0x6692efc
006692EE8  adrp     x0, #0x8f10000
006692EEC  ldr      x0, [x0, #0x9f0] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.StopAIAndAction()
006692EF0  bl       #0x382bd14 ; 
006692EF4  mov      w8, #1
006692EF8  strb     w8, [x20, #0x43]
006692EFC  ldr      x1, [x21]
006692F00  ldrb     w8, [x1, #0x53]
006692F04  tbnz     w8, #5, #0x6692f20
006692F08  ldr      x0, [x19, #0x40]
006692F0C  cbz      x0, #0x6692f34
006692F10  ldp      x20, x19, [sp, #0x10]
006692F14  mov      x1, xzr
006692F18  ldp      x30, x21, [sp], #0x20
006692F1C  b        #0x6b8fc8c ; HotFix.BattleLogic.AIStateController$$StopAIAndAction
006692F20  ldr      x2, [x1, #0x60]
006692F24  mov      x0, x19
006692F28  ldp      x20, x19, [sp, #0x10]
006692F2C  ldp      x30, x21, [sp], #0x20
006692F30  br       x2
006692F34  ldp      x20, x19, [sp, #0x10]
006692F38  ldp      x30, x21, [sp], #0x20
006692F3C  ret      

