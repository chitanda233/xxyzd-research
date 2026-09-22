; HotFix.BattleLogic.CharacterComponentAI$$SetExAIParam
; RVA 0x6693054; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006693054  str      x30, [sp, #-0x30]!
006693058  stp      x22, x21, [sp, #0x10]
00669305C  stp      x20, x19, [sp, #0x20]
006693060  adrp     x21, #0x959a000
006693064  adrp     x22, #0x8f10000
006693068  ldrb     w8, [x21, #0x45]
00669306C  ldr      x22, [x22, #0xa00] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.SetExAIParam()
006693070  mov      x19, x1
006693074  mov      x20, x0
006693078  tbnz     w8, #0, #0x6693090
00669307C  adrp     x0, #0x8f10000
006693080  ldr      x0, [x0, #0xa00] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.SetExAIParam()
006693084  bl       #0x382bd14 ; 
006693088  mov      w8, #1
00669308C  strb     w8, [x21, #0x45]
006693090  ldr      x2, [x22]
006693094  ldrb     w8, [x2, #0x53]
006693098  tbnz     w8, #5, #0x66930c0
00669309C  ldr      x0, [x20, #0x40]
0066930A0  cbz      x0, #0x66930dc
0066930A4  mov      x2, x19
0066930A8  ldp      x20, x19, [sp, #0x20]
0066930AC  ldp      x22, x21, [sp, #0x10]
0066930B0  mov      w1, #6
0066930B4  mov      x3, xzr
0066930B8  ldr      x30, [sp], #0x30
0066930BC  b        #0x6b918f4 ; HotFix.BattleLogic.AIStateController$$OnEvent
0066930C0  ldr      x3, [x2, #0x60]
0066930C4  mov      x0, x20
0066930C8  mov      x1, x19
0066930CC  ldp      x20, x19, [sp, #0x20]
0066930D0  ldp      x22, x21, [sp, #0x10]
0066930D4  ldr      x30, [sp], #0x30
0066930D8  br       x3
0066930DC  bl       #0x382bfb8 ; 

