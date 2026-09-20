; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnDeInit
; RVA 0x68746CC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068746CC  stp      x30, x21, [sp, #-0x20]!
0068746D0  stp      x20, x19, [sp, #0x10]
0068746D4  adrp     x20, #0x959b000
0068746D8  adrp     x21, #0x8f24000
0068746DC  ldrb     w8, [x20, #0xaae]
0068746E0  ldr      x21, [x21, #0x4a8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnDeInit() @ 0x92aa9a8
0068746E4  mov      x19, x0
0068746E8  tbnz     w8, #0, #0x6874700
0068746EC  adrp     x0, #0x8f24000
0068746F0  ldr      x0, [x0, #0x4a8] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnDeInit() @ 0x92aa9a8
0068746F4  bl       #0x382bd14 ; 
0068746F8  mov      w8, #1
0068746FC  strb     w8, [x20, #0xaae]
006874700  ldr      x1, [x21]
006874704  ldrb     w8, [x1, #0x53]
006874708  tbnz     w8, #5, #0x687472c
00687470C  ldr      x1, [x19, #0x18]
006874710  mov      x0, x19
006874714  bl       #0x6872230 ; HotFix.BattleLogic.HeroSkillCreator$$ReleaseRandoms
006874718  ldr      x1, [x19, #0x20]
00687471C  mov      x0, x19
006874720  ldp      x20, x19, [sp, #0x10]
006874724  ldp      x30, x21, [sp], #0x20
006874728  b        #0x6872230 ; HotFix.BattleLogic.HeroSkillCreator$$ReleaseRandoms
00687472C  ldr      x2, [x1, #0x60]
006874730  mov      x0, x19
006874734  ldp      x20, x19, [sp, #0x10]
006874738  ldp      x30, x21, [sp], #0x20
00687473C  br       x2

