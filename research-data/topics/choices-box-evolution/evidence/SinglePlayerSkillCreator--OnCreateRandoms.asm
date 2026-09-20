; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnCreateRandoms
; RVA 0x68740D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068740D8  stp      x30, x21, [sp, #-0x20]!
0068740DC  stp      x20, x19, [sp, #0x10]
0068740E0  adrp     x20, #0x959b000
0068740E4  adrp     x21, #0x8f24000
0068740E8  ldrb     w8, [x20, #0xaab]
0068740EC  ldr      x21, [x21, #0x480] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnCreateRandoms() @ 0x92aa9a0
0068740F0  mov      x19, x0
0068740F4  tbnz     w8, #0, #0x6874118
0068740F8  adrp     x0, #0x8f24000
0068740FC  ldr      x0, [x0, #0x480] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnCreateRandoms() @ 0x92aa9a0
006874100  bl       #0x382bd14 ; 
006874104  adrp     x0, #0x8f23000
006874108  ldr      x0, [x0, #0xb20] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<WeightRandom>() @ 0x92ceb38
00687410C  bl       #0x382bd14 ; 
006874110  mov      w8, #1
006874114  strb     w8, [x20, #0xaab]
006874118  ldr      x1, [x21]
00687411C  ldrb     w8, [x1, #0x53]
006874120  tbnz     w8, #5, #0x6874170
006874124  mov      x0, x19
006874128  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
00687412C  cbz      x0, #0x68741f8
006874130  adrp     x21, #0x9591000
006874134  ldrb     w8, [x21, #0xa4c]
006874138  mov      x20, x0
00687413C  cbnz     w8, #0x6874154
006874140  adrp     x0, #0x8ee5000
006874144  ldr      x0, [x0, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator() @ 0x923fe80
006874148  bl       #0x382bd14 ; 
00687414C  mov      w8, #1
006874150  strb     w8, [x21, #0xa4c]
006874154  adrp     x8, #0x8ee5000
006874158  ldr      x8, [x8, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator() @ 0x923fe80
00687415C  ldr      x1, [x8]
006874160  ldrb     w8, [x1, #0x53]
006874164  tbnz     w8, #5, #0x6874184
006874168  ldr      x0, [x20, #0x210]
00687416C  b        #0x6874190 ; 
006874170  ldr      x2, [x1, #0x60]
006874174  mov      x0, x19
006874178  ldp      x20, x19, [sp, #0x10]
00687417C  ldp      x30, x21, [sp], #0x20
006874180  br       x2
006874184  ldr      x8, [x1, #0x60]
006874188  mov      x0, x20
00687418C  blr      x8
006874190  cbz      x0, #0x68741f8
006874194  adrp     x8, #0x8f23000
006874198  ldr      x8, [x8, #0xb20] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<WeightRandom>() @ 0x92ceb38
00687419C  ldr      x1, [x8]
0068741A0  bl       #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0068741A4  mov      x1, x0
0068741A8  mov      x0, x19
0068741AC  str      x1, [x0, #0x40]!
0068741B0  bl       #0x382bcb8 ; 
0068741B4  ldr      x1, [x19, #0x18]
0068741B8  mov      x0, x19
0068741BC  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
0068741C0  ldr      x1, [x19, #0x20]
0068741C4  mov      x0, x19
0068741C8  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
0068741CC  ldr      x1, [x19, #0x30]
0068741D0  mov      x0, x19
0068741D4  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
0068741D8  ldr      x1, [x19, #0x38]
0068741DC  mov      x0, x19
0068741E0  bl       #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
0068741E4  ldr      x1, [x19, #0x28]
0068741E8  mov      x0, x19
0068741EC  ldp      x20, x19, [sp, #0x10]
0068741F0  ldp      x30, x21, [sp], #0x20
0068741F4  b        #0x6871fe4 ; HotFix.BattleLogic.HeroSkillCreator$$CreateRandoms
0068741F8  bl       #0x382bfb8 ; 

