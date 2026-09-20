; HotFix.BattleLogic.NormalSkillCreator$$OnCreateRandoms
; RVA 0x685CECC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685CECC  stp      x30, x21, [sp, #-0x20]!
00685CED0  stp      x20, x19, [sp, #0x10]
00685CED4  adrp     x20, #0x959b000
00685CED8  adrp     x21, #0x8f23000
00685CEDC  ldrb     w8, [x20, #0xa9d]
00685CEE0  ldr      x21, [x21, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnCreateRandoms() @ 0x9295eb8
00685CEE4  mov      x19, x0
00685CEE8  tbnz     w8, #0, #0x685cf0c
00685CEEC  adrp     x0, #0x8f23000
00685CEF0  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnCreateRandoms() @ 0x9295eb8
00685CEF4  bl       #0x382bd14 ; 
00685CEF8  adrp     x0, #0x8f23000
00685CEFC  ldr      x0, [x0, #0xb08] ; GLOBAL HotFix.BattleLogic.WeightRandom[]_TypeInfo @ 0x91df948
00685CF00  bl       #0x382bd14 ; 
00685CF04  mov      w8, #1
00685CF08  strb     w8, [x20, #0xa9d]
00685CF0C  ldr      x1, [x21]
00685CF10  ldrb     w8, [x1, #0x53]
00685CF14  tbnz     w8, #5, #0x685cf88
00685CF18  mov      x0, x19
00685CF1C  bl       #0x68740d8 ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnCreateRandoms
00685CF20  mov      x0, x19
00685CF24  bl       #0x68741fc ; HotFix.BattleLogic.NormalSkillCreator$$CreateAngelRandoms
00685CF28  ldr      x1, [x19, #0x88]
00685CF2C  mov      x0, x19
00685CF30  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
00685CF34  ldr      x8, [x19]
00685CF38  mov      x0, x19
00685CF3C  ldr      x9, [x8, #0x2e8]
00685CF40  ldr      x1, [x8, #0x2f0]
00685CF44  blr      x9
00685CF48  tbz      w0, #0, #0x685cf9c
00685CF4C  adrp     x8, #0x8f23000
00685CF50  ldr      x8, [x8, #0xb08] ; GLOBAL HotFix.BattleLogic.WeightRandom[]_TypeInfo @ 0x91df948
00685CF54  mov      w1, #3
00685CF58  ldr      x0, [x8]
00685CF5C  bl       #0x382bdfc ; 
00685CF60  mov      x20, x19
00685CF64  str      x0, [x20, #0x80]!
00685CF68  mov      x1, x0
00685CF6C  mov      x0, x20
00685CF70  bl       #0x382bcb8 ; 
00685CF74  ldr      x1, [x20]
00685CF78  mov      x0, x19
00685CF7C  ldp      x20, x19, [sp, #0x10]
00685CF80  ldp      x30, x21, [sp], #0x20
00685CF84  b        #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
00685CF88  ldr      x2, [x1, #0x60]
00685CF8C  mov      x0, x19
00685CF90  ldp      x20, x19, [sp, #0x10]
00685CF94  ldp      x30, x21, [sp], #0x20
00685CF98  br       x2
00685CF9C  ldp      x20, x19, [sp, #0x10]
00685CFA0  ldp      x30, x21, [sp], #0x20
00685CFA4  ret      

