; HotFix.BattleLogic.DankeSkillCreator$$OnCreateRandoms
; RVA 0x685CDDC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685CDDC  stp      x30, x21, [sp, #-0x20]!
00685CDE0  stp      x20, x19, [sp, #0x10]
00685CDE4  adrp     x20, #0x959b000
00685CDE8  adrp     x21, #0x8f23000
00685CDEC  ldrb     w8, [x20, #0x9e8]
00685CDF0  ldr      x21, [x21, #0xb18] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.OnCreateRandoms() @ 0x9259dc8
00685CDF4  mov      x19, x0
00685CDF8  tbnz     w8, #0, #0x685ce1c
00685CDFC  adrp     x0, #0x8f23000
00685CE00  ldr      x0, [x0, #0xb18] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.OnCreateRandoms() @ 0x9259dc8
00685CE04  bl       #0x382bd14 ; 
00685CE08  adrp     x0, #0x8f23000
00685CE0C  ldr      x0, [x0, #0xb20] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<WeightRandom>() @ 0x92ceb38
00685CE10  bl       #0x382bd14 ; 
00685CE14  mov      w8, #1
00685CE18  strb     w8, [x20, #0x9e8]
00685CE1C  ldr      x1, [x21]
00685CE20  ldrb     w8, [x1, #0x53]
00685CE24  tbnz     w8, #5, #0x685ce7c
00685CE28  mov      x0, x19
00685CE2C  bl       #0x685cecc ; HotFix.BattleLogic.NormalSkillCreator$$OnCreateRandoms
00685CE30  mov      x0, x19
00685CE34  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685CE38  cbz      x0, #0x685cec8
00685CE3C  adrp     x21, #0x9591000
00685CE40  ldrb     w8, [x21, #0xa4c]
00685CE44  mov      x20, x0
00685CE48  cbnz     w8, #0x685ce60
00685CE4C  adrp     x0, #0x8ee5000
00685CE50  ldr      x0, [x0, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator() @ 0x923fe80
00685CE54  bl       #0x382bd14 ; 
00685CE58  mov      w8, #1
00685CE5C  strb     w8, [x21, #0xa4c]
00685CE60  adrp     x8, #0x8ee5000
00685CE64  ldr      x8, [x8, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator() @ 0x923fe80
00685CE68  ldr      x1, [x8]
00685CE6C  ldrb     w8, [x1, #0x53]
00685CE70  tbnz     w8, #5, #0x685ce90
00685CE74  ldr      x0, [x20, #0x210]
00685CE78  b        #0x685ce9c ; 
00685CE7C  ldr      x2, [x1, #0x60]
00685CE80  mov      x0, x19
00685CE84  ldp      x20, x19, [sp, #0x10]
00685CE88  ldp      x30, x21, [sp], #0x20
00685CE8C  br       x2
00685CE90  ldr      x8, [x1, #0x60]
00685CE94  mov      x0, x20
00685CE98  blr      x8
00685CE9C  cbz      x0, #0x685cec8
00685CEA0  adrp     x8, #0x8f23000
00685CEA4  ldr      x8, [x8, #0xb20] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<WeightRandom>() @ 0x92ceb38
00685CEA8  ldr      x1, [x8]
00685CEAC  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
00685CEB0  str      x0, [x19, #0x98]!
00685CEB4  mov      x1, x0
00685CEB8  mov      x0, x19
00685CEBC  ldp      x20, x19, [sp, #0x10]
00685CEC0  ldp      x30, x21, [sp], #0x20
00685CEC4  b        #0x382bcb8 ; 
00685CEC8  bl       #0x382bfb8 ; 

