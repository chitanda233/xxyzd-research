; HotFix.BattleLogic.DankeSkillCreator$$GetRandomSkillByCredits
; RVA 0x685D150; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00685D150  sub      sp, sp, #0x40
00685D154  str      x30, [sp, #0x10]
00685D158  stp      x22, x21, [sp, #0x20]
00685D15C  stp      x20, x19, [sp, #0x30]
00685D160  adrp     x21, #0x959b000
00685D164  adrp     x22, #0x8f23000
00685D168  ldrb     w8, [x21, #0x9ea]
00685D16C  ldr      x22, [x22, #0xb38] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetRandomSkillByCredits() @ 0x9259d70
00685D170  mov      w20, w1
00685D174  mov      x19, x0
00685D178  tbnz     w8, #0, #0x685d190
00685D17C  adrp     x0, #0x8f23000
00685D180  ldr      x0, [x0, #0xb38] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.GetRandomSkillByCredits() @ 0x9259d70
00685D184  bl       #0x382bd14 ; 
00685D188  mov      w8, #1
00685D18C  strb     w8, [x21, #0x9ea]
00685D190  ldr      x2, [x22]
00685D194  ldrb     w8, [x2, #0x53]
00685D198  tbnz     w8, #5, #0x685d1dc
00685D19C  ldr      x8, [x19, #0xa0]
00685D1A0  cmp      w20, #2
00685D1A4  str      x8, [sp, #0x18]
00685D1A8  ldr      x8, [x19, #0xa8]
00685D1AC  str      x8, [sp, #8]
00685D1B0  b.ne     #0x685d1c4
00685D1B4  ldr      x8, [x19, #0xb0]
00685D1B8  str      x8, [sp, #0x18]
00685D1BC  ldr      x8, [x19, #0xb8]
00685D1C0  str      x8, [sp, #8]
00685D1C4  add      x1, sp, #0x18
00685D1C8  mov      x0, x19
00685D1CC  bl       #0x685cfa8 ; HotFix.BattleLogic.DankeSkillCreator$$GetRandomSkillByCredits
00685D1D0  tbz      w0, #0, #0x685d1fc
00685D1D4  mov      w0, #2
00685D1D8  b        #0x685d20c ; 
00685D1DC  ldr      x3, [x2, #0x60]
00685D1E0  mov      x0, x19
00685D1E4  mov      w1, w20
00685D1E8  ldp      x20, x19, [sp, #0x30]
00685D1EC  ldp      x22, x21, [sp, #0x20]
00685D1F0  ldr      x30, [sp, #0x10]
00685D1F4  add      sp, sp, #0x40
00685D1F8  br       x3
00685D1FC  add      x1, sp, #8
00685D200  mov      x0, x19
00685D204  bl       #0x685cfa8 ; HotFix.BattleLogic.DankeSkillCreator$$GetRandomSkillByCredits
00685D208  and      w0, w0, #1
00685D20C  ldp      x20, x19, [sp, #0x30]
00685D210  ldp      x22, x21, [sp, #0x20]
00685D214  ldr      x30, [sp, #0x10]
00685D218  add      sp, sp, #0x40
00685D21C  ret      

