; HotFix.BattleLogic.AIPunchboard$$InitAttackLoop
; RVA 0x6B8A3C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B8A3C0  stp      x30, x21, [sp, #-0x20]!
006B8A3C4  stp      x20, x19, [sp, #0x10]
006B8A3C8  adrp     x20, #0x959f000
006B8A3CC  adrp     x21, #0x8f43000
006B8A3D0  ldrb     w8, [x20, #0xf7c]
006B8A3D4  ldr      x21, [x21, #0x860] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.InitAttackLoop() @ 0x92323e8
006B8A3D8  mov      x19, x0
006B8A3DC  tbnz     w8, #0, #0x6b8a3f4
006B8A3E0  adrp     x0, #0x8f43000
006B8A3E4  ldr      x0, [x0, #0x860] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.InitAttackLoop() @ 0x92323e8
006B8A3E8  bl       #0x382bd14 ; 
006B8A3EC  mov      w8, #1
006B8A3F0  strb     w8, [x20, #0xf7c]
006B8A3F4  ldr      x1, [x21]
006B8A3F8  ldrb     w8, [x1, #0x53]
006B8A3FC  tbnz     w8, #5, #0x6b8a40c
006B8A400  ldp      x20, x19, [sp, #0x10]
006B8A404  ldp      x30, x21, [sp], #0x20
006B8A408  ret      
006B8A40C  ldr      x2, [x1, #0x60]
006B8A410  mov      x0, x19
006B8A414  ldp      x20, x19, [sp, #0x10]
006B8A418  ldp      x30, x21, [sp], #0x20
006B8A41C  br       x2

