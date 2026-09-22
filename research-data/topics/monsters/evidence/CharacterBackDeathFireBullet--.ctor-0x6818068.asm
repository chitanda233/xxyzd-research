; HotFix.BattleLogic.CharacterBackDeathFireBullet$$.ctor
; RVA 0x6818068; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006818068  stp      x30, x21, [sp, #-0x20]!
00681806C  stp      x20, x19, [sp, #0x10]
006818070  adrp     x20, #0x959b000
006818074  adrp     x21, #0x8f21000
006818078  ldrb     w8, [x20, #0x5fb]
00681807C  ldr      x21, [x21, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.CharacterBackDeathFireBullet..ctor()
006818080  mov      x19, x0
006818084  tbnz     w8, #0, #0x681809c
006818088  adrp     x0, #0x8f21000
00681808C  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.CharacterBackDeathFireBullet..ctor()
006818090  bl       #0x382bd14 ; 
006818094  mov      w8, #1
006818098  strb     w8, [x20, #0x5fb]
00681809C  ldr      x1, [x21]
0068180A0  ldrb     w8, [x1, #0x53]
0068180A4  tbnz     w8, #5, #0x68180b8
0068180A8  mov      x0, x19
0068180AC  ldp      x20, x19, [sp, #0x10]
0068180B0  ldp      x30, x21, [sp], #0x20
0068180B4  b        #0x6817620 ; HotFix.BattleLogic.CharacterExplosionBackDeath$$.ctor
0068180B8  ldr      x2, [x1, #0x60]
0068180BC  mov      x0, x19
0068180C0  ldp      x20, x19, [sp, #0x10]
0068180C4  ldp      x30, x21, [sp], #0x20
0068180C8  br       x2

