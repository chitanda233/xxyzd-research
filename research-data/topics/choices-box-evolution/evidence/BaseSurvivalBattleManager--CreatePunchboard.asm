; HotFix.BattleLogic.BaseSurvivalBattleManager$$CreatePunchboard
; RVA 0x6588BE0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006588BE0  str      x30, [sp, #-0x30]!
006588BE4  stp      x22, x21, [sp, #0x10]
006588BE8  stp      x20, x19, [sp, #0x20]
006588BEC  adrp     x21, #0x9599000
006588BF0  adrp     x22, #0x8f08000
006588BF4  ldrb     w8, [x21, #0x18b]
006588BF8  ldr      x22, [x22, #0x288] ; GLOBAL Method$HotFix.BattleLogic.BaseSurvivalBattleManager.CreatePunchboard() @ 0x923ba98
006588BFC  mov      x19, x1
006588C00  mov      x20, x0
006588C04  tbnz     w8, #0, #0x6588c1c
006588C08  adrp     x0, #0x8f08000
006588C0C  ldr      x0, [x0, #0x288] ; GLOBAL Method$HotFix.BattleLogic.BaseSurvivalBattleManager.CreatePunchboard() @ 0x923ba98
006588C10  bl       #0x382bd14 ; 
006588C14  mov      w8, #1
006588C18  strb     w8, [x21, #0x18b]
006588C1C  ldr      x2, [x22]
006588C20  ldrb     w8, [x2, #0x53]
006588C24  tbnz     w8, #5, #0x6588c4c
006588C28  mov      x0, x20
006588C2C  mov      x4, x19
006588C30  ldp      x20, x19, [sp, #0x20]
006588C34  ldp      x22, x21, [sp, #0x10]
006588C38  mov      w1, #8
006588C3C  mov      w2, #1
006588C40  mov      x3, xzr
006588C44  ldr      x30, [sp], #0x30
006588C48  b        #0x6588780 ; HotFix.BattleLogic.BattleManager$$TriggerMissionEvent
006588C4C  ldr      x3, [x2, #0x60]
006588C50  mov      x0, x20
006588C54  mov      x1, x19
006588C58  ldp      x20, x19, [sp, #0x20]
006588C5C  ldp      x22, x21, [sp, #0x10]
006588C60  ldr      x30, [sp], #0x30
006588C64  br       x3

