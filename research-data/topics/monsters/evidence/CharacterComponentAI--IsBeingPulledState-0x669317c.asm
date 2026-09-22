; HotFix.BattleLogic.CharacterComponentAI$$IsBeingPulledState
; RVA 0x669317C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00669317C  stp      x30, x21, [sp, #-0x20]!
006693180  stp      x20, x19, [sp, #0x10]
006693184  adrp     x20, #0x959a000
006693188  adrp     x21, #0x8f10000
00669318C  ldrb     w8, [x20, #0x47]
006693190  ldr      x21, [x21, #0xa10] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.IsBeingPulledState()
006693194  mov      x19, x0
006693198  tbnz     w8, #0, #0x66931b0
00669319C  adrp     x0, #0x8f10000
0066931A0  ldr      x0, [x0, #0xa10] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.IsBeingPulledState()
0066931A4  bl       #0x382bd14 ; 
0066931A8  mov      w8, #1
0066931AC  strb     w8, [x20, #0x47]
0066931B0  ldr      x1, [x21]
0066931B4  ldrb     w8, [x1, #0x53]
0066931B8  tbnz     w8, #5, #0x66931d4
0066931BC  ldr      x0, [x19, #0x40]
0066931C0  cbz      x0, #0x66931e8
0066931C4  ldp      x20, x19, [sp, #0x10]
0066931C8  mov      x1, xzr
0066931CC  ldp      x30, x21, [sp], #0x20
0066931D0  b        #0x6b94db0 ; HotFix.BattleLogic.AIStateController$$IsBeingPulledState
0066931D4  ldr      x2, [x1, #0x60]
0066931D8  mov      x0, x19
0066931DC  ldp      x20, x19, [sp, #0x10]
0066931E0  ldp      x30, x21, [sp], #0x20
0066931E4  br       x2
0066931E8  bl       #0x382bfb8 ; 

