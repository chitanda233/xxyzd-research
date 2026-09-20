; HotFix.BattleLogic.BaseSurvivalBattleManager$$OnEnemyDie
; RVA 0x6588C68; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006588C68  stp      x30, x23, [sp, #-0x30]!
006588C6C  stp      x22, x21, [sp, #0x10]
006588C70  stp      x20, x19, [sp, #0x20]
006588C74  adrp     x22, #0x9599000
006588C78  adrp     x23, #0x8f08000
006588C7C  ldrb     w8, [x22, #0x18c]
006588C80  ldr      x23, [x23, #0x290] ; GLOBAL Method$HotFix.BattleLogic.BaseSurvivalBattleManager.OnEnemyDie() @ 0x923bb68
006588C84  mov      x21, x2
006588C88  mov      x20, x1
006588C8C  mov      x19, x0
006588C90  tbnz     w8, #0, #0x6588ca8
006588C94  adrp     x0, #0x8f08000
006588C98  ldr      x0, [x0, #0x290] ; GLOBAL Method$HotFix.BattleLogic.BaseSurvivalBattleManager.OnEnemyDie() @ 0x923bb68
006588C9C  bl       #0x382bd14 ; 
006588CA0  mov      w8, #1
006588CA4  strb     w8, [x22, #0x18c]
006588CA8  ldr      x3, [x23]
006588CAC  ldrb     w8, [x3, #0x53]
006588CB0  tbnz     w8, #5, #0x6588d48
006588CB4  mov      x0, x19
006588CB8  mov      x1, x20
006588CBC  mov      x2, x21
006588CC0  bl       #0x6588dcc ; HotFix.BattleLogic.BattleManager$$OnEnemyDie
006588CC4  adrp     x21, #0x9599000
006588CC8  ldrb     w8, [x21, #0x2a1]
006588CCC  cbnz     w8, #0x6588ce4
006588CD0  adrp     x0, #0x8f08000
006588CD4  ldr      x0, [x0, #0x298] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_HasJoyGuide() @ 0x923cca8
006588CD8  bl       #0x382bd14 ; 
006588CDC  mov      w8, #1
006588CE0  strb     w8, [x21, #0x2a1]
006588CE4  adrp     x8, #0x8f08000
006588CE8  ldr      x8, [x8, #0x298] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.get_HasJoyGuide() @ 0x923cca8
006588CEC  ldr      x1, [x8]
006588CF0  ldrb     w8, [x1, #0x53]
006588CF4  tbnz     w8, #5, #0x6588d68
006588CF8  ldrb     w8, [x19, #0x18]
006588CFC  cbz      w8, #0x6588d78
006588D00  adrp     x20, #0x9599000
006588D04  ldrb     w8, [x20, #0x2a2]
006588D08  cbnz     w8, #0x6588d20
006588D0C  adrp     x0, #0x8f08000
006588D10  ldr      x0, [x0, #0x2a0] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.set_HasJoyGuide() @ 0x923cce8
006588D14  bl       #0x382bd14 ; 
006588D18  mov      w8, #1
006588D1C  strb     w8, [x20, #0x2a2]
006588D20  adrp     x8, #0x8f08000
006588D24  ldr      x8, [x8, #0x2a0] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.set_HasJoyGuide() @ 0x923cce8
006588D28  ldr      x2, [x8]
006588D2C  ldrb     w8, [x2, #0x53]
006588D30  tbnz     w8, #5, #0x6588db0
006588D34  strb     wzr, [x19, #0x18]
006588D38  ldp      x20, x19, [sp, #0x20]
006588D3C  ldp      x22, x21, [sp, #0x10]
006588D40  ldp      x30, x23, [sp], #0x30
006588D44  ret      
006588D48  ldr      x4, [x3, #0x60]
006588D4C  mov      x0, x19
006588D50  mov      x1, x20
006588D54  mov      x2, x21
006588D58  ldp      x20, x19, [sp, #0x20]
006588D5C  ldp      x22, x21, [sp, #0x10]
006588D60  ldp      x30, x23, [sp], #0x30
006588D64  br       x4
006588D68  ldr      x8, [x1, #0x60]
006588D6C  mov      x0, x19
006588D70  blr      x8
006588D74  tbnz     w0, #0, #0x6588d00
006588D78  ldr      x8, [x19]
006588D7C  mov      x0, x19
006588D80  mov      x1, x20
006588D84  ldr      x9, [x8, #0x5f8]
006588D88  ldr      x2, [x8, #0x600]
006588D8C  blr      x9
006588D90  ldr      x8, [x19]
006588D94  mov      x0, x19
006588D98  ldp      x20, x19, [sp, #0x20]
006588D9C  ldp      x22, x21, [sp, #0x10]
006588DA0  ldr      x2, [x8, #0x218]
006588DA4  ldr      x1, [x8, #0x220]
006588DA8  ldp      x30, x23, [sp], #0x30
006588DAC  br       x2
006588DB0  ldr      x3, [x2, #0x60]
006588DB4  mov      x0, x19
006588DB8  ldp      x20, x19, [sp, #0x20]
006588DBC  ldp      x22, x21, [sp, #0x10]
006588DC0  mov      w1, wzr
006588DC4  ldp      x30, x23, [sp], #0x30
006588DC8  br       x3

