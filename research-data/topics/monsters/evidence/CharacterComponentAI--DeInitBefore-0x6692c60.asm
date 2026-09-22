; HotFix.BattleLogic.CharacterComponentAI$$DeInitBefore
; RVA 0x6692C60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006692C60  stp      x30, x21, [sp, #-0x20]!
006692C64  stp      x20, x19, [sp, #0x10]
006692C68  adrp     x20, #0x959a000
006692C6C  adrp     x21, #0x8f10000
006692C70  ldrb     w8, [x20, #0x3e]
006692C74  ldr      x21, [x21, #0x9c8] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.DeInitBefore()
006692C78  mov      x19, x0
006692C7C  tbnz     w8, #0, #0x6692c94
006692C80  adrp     x0, #0x8f10000
006692C84  ldr      x0, [x0, #0x9c8] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.DeInitBefore()
006692C88  bl       #0x382bd14 ; 
006692C8C  mov      w8, #1
006692C90  strb     w8, [x20, #0x3e]
006692C94  ldr      x1, [x21]
006692C98  ldrb     w8, [x1, #0x53]
006692C9C  tbnz     w8, #5, #0x6692cb8
006692CA0  ldr      x0, [x19, #0x40]
006692CA4  cbz      x0, #0x6692ccc
006692CA8  ldp      x20, x19, [sp, #0x10]
006692CAC  mov      x1, xzr
006692CB0  ldp      x30, x21, [sp], #0x20
006692CB4  b        #0x6b8f558 ; HotFix.BattleLogic.AIStateController$$DeInitBefore
006692CB8  ldr      x2, [x1, #0x60]
006692CBC  mov      x0, x19
006692CC0  ldp      x20, x19, [sp, #0x10]
006692CC4  ldp      x30, x21, [sp], #0x20
006692CC8  br       x2
006692CCC  ldp      x20, x19, [sp, #0x10]
006692CD0  ldp      x30, x21, [sp], #0x20
006692CD4  ret      

