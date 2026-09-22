; HotFix.BattleLogic.AICommonBoss2$$InitAttackLoop
; RVA 0x65693C4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065693C4  stp      x30, x21, [sp, #-0x20]!
0065693C8  stp      x20, x19, [sp, #0x10]
0065693CC  adrp     x20, #0x9598000
0065693D0  adrp     x21, #0x8f06000
0065693D4  ldrb     w8, [x20, #0xfad]
0065693D8  ldr      x21, [x21, #0xa50] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss2.InitAttackLoop()
0065693DC  mov      x19, x0
0065693E0  tbnz     w8, #0, #0x6569404
0065693E4  adrp     x0, #0x8f06000
0065693E8  ldr      x0, [x0, #0xa50] ; GLOBAL Method$HotFix.BattleLogic.AICommonBoss2.InitAttackLoop()
0065693EC  bl       #0x382bd14 ; 
0065693F0  adrp     x0, #0x8f05000
0065693F4  ldr      x0, [x0, #0x828] ; GLOBAL Idle
0065693F8  bl       #0x382bd14 ; 
0065693FC  mov      w8, #1
006569400  strb     w8, [x20, #0xfad]
006569404  ldr      x1, [x21]
006569408  ldrb     w8, [x1, #0x53]
00656940C  tbnz     w8, #5, #0x65694a0
006569410  ldr      x0, [x19, #0x58]
006569414  cbz      x0, #0x65694fc
006569418  adrp     x8, #0x8f05000
00656941C  ldr      x8, [x8, #0x828] ; GLOBAL Idle
006569420  mov      x2, xzr
006569424  ldr      x1, [x8]
006569428  bl       #0x67dc57c ; HotFix.BattleLogic.EntityCharacter$$PlayAnimation
00656942C  ldr      x20, [x19, #0x58]
006569430  mov      x0, x19
006569434  mov      x1, xzr
006569438  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
00656943C  cbz      x20, #0x65694fc
006569440  mov      x1, x0
006569444  mov      x0, x20
006569448  mov      x2, xzr
00656944C  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
006569450  ldr      x1, [x19, #0x148]
006569454  mov      x0, x19
006569458  mov      x2, xzr
00656945C  bl       #0x6b90668 ; HotFix.BattleLogic.AIStateController$$SelectWeightedRandomIndex
006569460  cmp      w0, #2
006569464  b.eq     #0x65694b4
006569468  cmp      w0, #1
00656946C  b.eq     #0x65694c8
006569470  cbnz     w0, #0x65694f0
006569474  ldr      x8, [x19, #0x118]
006569478  cbz      x8, #0x65694fc
00656947C  ldr      x1, [x8, #0x20]
006569480  mov      x0, x19
006569484  mov      x2, xzr
006569488  bl       #0x6b90668 ; HotFix.BattleLogic.AIStateController$$SelectWeightedRandomIndex
00656948C  mov      w1, w0
006569490  mov      x0, x19
006569494  ldp      x20, x19, [sp, #0x10]
006569498  ldp      x30, x21, [sp], #0x20
00656949C  b        #0x6569500 ; HotFix.BattleLogic.AICommonBoss2$$onRandomAI
0065694A0  ldr      x2, [x1, #0x60]
0065694A4  mov      x0, x19
0065694A8  ldp      x20, x19, [sp, #0x10]
0065694AC  ldp      x30, x21, [sp], #0x20
0065694B0  br       x2
0065694B4  ldr      x0, [x19, #0x170]
0065694B8  cbz      x0, #0x65694f0
0065694BC  mov      x1, xzr
0065694C0  bl       #0x656fa34 ; HotFix.BattleLogic.RushBehaviorHandler$$CreateRushTask
0065694C4  b        #0x65694d8 ; 
0065694C8  ldr      x0, [x19, #0x168]
0065694CC  cbz      x0, #0x65694f0
0065694D0  mov      x1, xzr
0065694D4  bl       #0x656dcf8 ; HotFix.BattleLogic.CallMonsterBehaviorHandler$$CreateCallMonsterTask
0065694D8  mov      x1, x0
0065694DC  mov      x0, x19
0065694E0  ldp      x20, x19, [sp, #0x10]
0065694E4  mov      x2, xzr
0065694E8  ldp      x30, x21, [sp], #0x20
0065694EC  b        #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
0065694F0  ldp      x20, x19, [sp, #0x10]
0065694F4  ldp      x30, x21, [sp], #0x20
0065694F8  ret      
0065694FC  bl       #0x382bfb8 ; 

