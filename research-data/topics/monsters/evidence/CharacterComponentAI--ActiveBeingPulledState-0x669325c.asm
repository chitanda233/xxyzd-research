; HotFix.BattleLogic.CharacterComponentAI$$ActiveBeingPulledState
; RVA 0x669325C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00669325C  stp      x30, x25, [sp, #-0x40]!
006693260  stp      x24, x23, [sp, #0x10]
006693264  stp      x22, x21, [sp, #0x20]
006693268  stp      x20, x19, [sp, #0x30]
00669326C  adrp     x24, #0x959a000
006693270  adrp     x25, #0x8f10000
006693274  ldrb     w8, [x24, #0x49]
006693278  ldr      x25, [x25, #0xa20] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.ActiveBeingPulledState()
00669327C  mov      w22, w4
006693280  mov      x19, x3
006693284  mov      x20, x2
006693288  mov      x21, x1
00669328C  mov      x23, x0
006693290  tbnz     w8, #0, #0x66932a8
006693294  adrp     x0, #0x8f10000
006693298  ldr      x0, [x0, #0xa20] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.ActiveBeingPulledState()
00669329C  bl       #0x382bd14 ; 
0066932A0  mov      w8, #1
0066932A4  strb     w8, [x24, #0x49]
0066932A8  ldr      x5, [x25]
0066932AC  ldrb     w8, [x5, #0x53]
0066932B0  tbnz     w8, #5, #0x66932e4
0066932B4  ldr      x0, [x23, #0x40]
0066932B8  cbz      x0, #0x6693310
0066932BC  and      w4, w22, #1
0066932C0  mov      x1, x21
0066932C4  mov      x2, x20
0066932C8  mov      x3, x19
0066932CC  ldp      x20, x19, [sp, #0x30]
0066932D0  ldp      x22, x21, [sp, #0x20]
0066932D4  ldp      x24, x23, [sp, #0x10]
0066932D8  mov      x5, xzr
0066932DC  ldp      x30, x25, [sp], #0x40
0066932E0  b        #0x6b917f0 ; HotFix.BattleLogic.AIStateController$$ActiveBeingPulledState
0066932E4  ldr      x6, [x5, #0x60]
0066932E8  and      w4, w22, #1
0066932EC  mov      x0, x23
0066932F0  mov      x1, x21
0066932F4  mov      x2, x20
0066932F8  mov      x3, x19
0066932FC  ldp      x20, x19, [sp, #0x30]
006693300  ldp      x22, x21, [sp, #0x20]
006693304  ldp      x24, x23, [sp, #0x10]
006693308  ldp      x30, x25, [sp], #0x40
00669330C  br       x6
006693310  bl       #0x382bfb8 ; 

