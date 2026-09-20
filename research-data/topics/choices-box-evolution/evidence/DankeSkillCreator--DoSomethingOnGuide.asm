; HotFix.BattleLogic.DankeSkillCreator$$DoSomethingOnGuide
; RVA 0x685DDCC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685DDCC  stp      x30, x21, [sp, #-0x20]!
00685DDD0  stp      x20, x19, [sp, #0x10]
00685DDD4  adrp     x20, #0x959b000
00685DDD8  adrp     x21, #0x8f23000
00685DDDC  ldrb     w8, [x20, #0x9ef]
00685DDE0  ldr      x21, [x21, #0xb78] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.DoSomethingOnGuide() @ 0x9259d20
00685DDE4  mov      x19, x0
00685DDE8  tbnz     w8, #0, #0x685de00
00685DDEC  adrp     x0, #0x8f23000
00685DDF0  ldr      x0, [x0, #0xb78] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.DoSomethingOnGuide() @ 0x9259d20
00685DDF4  bl       #0x382bd14 ; 
00685DDF8  mov      w8, #1
00685DDFC  strb     w8, [x20, #0x9ef]
00685DE00  ldr      x1, [x21]
00685DE04  ldrb     w8, [x1, #0x53]
00685DE08  tbnz     w8, #5, #0x685de70
00685DE0C  mov      x0, x19
00685DE10  bl       #0x685de88 ; HotFix.BattleLogic.HeroSkillCreator$$DoSomethingOnGuide
00685DE14  mov      x0, x19
00685DE18  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00685DE1C  cbz      x0, #0x685de84
00685DE20  adrp     x20, #0x959b000
00685DE24  ldrb     w8, [x20, #0xb83]
00685DE28  mov      x19, x0
00685DE2C  cbnz     w8, #0x685de44
00685DE30  adrp     x0, #0x8f23000
00685DE34  ldr      x0, [x0, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroup() @ 0x923f8b8
00685DE38  bl       #0x382bd14 ; 
00685DE3C  mov      w8, #1
00685DE40  strb     w8, [x20, #0xb83]
00685DE44  adrp     x8, #0x8f23000
00685DE48  ldr      x8, [x8, #0xb80] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.DoInitSkillGroup() @ 0x923f8b8
00685DE4C  ldr      x1, [x8]
00685DE50  ldrb     w8, [x1, #0x53]
00685DE54  tbnz     w8, #5, #0x685de70
00685DE58  ldr      w8, [x19, #0x2c4]
00685DE5C  sub      w8, w8, #1
00685DE60  str      w8, [x19, #0x2c4]
00685DE64  ldp      x20, x19, [sp, #0x10]
00685DE68  ldp      x30, x21, [sp], #0x20
00685DE6C  ret      
00685DE70  ldr      x2, [x1, #0x60]
00685DE74  mov      x0, x19
00685DE78  ldp      x20, x19, [sp, #0x10]
00685DE7C  ldp      x30, x21, [sp], #0x20
00685DE80  br       x2
00685DE84  bl       #0x382bfb8 ; 

