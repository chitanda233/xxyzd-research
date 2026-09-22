; HotFix.BattleLogic.CharacterComponentAI$$IsBornState
; RVA 0x66931EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066931EC  stp      x30, x21, [sp, #-0x20]!
0066931F0  stp      x20, x19, [sp, #0x10]
0066931F4  adrp     x20, #0x959a000
0066931F8  adrp     x21, #0x8f10000
0066931FC  ldrb     w8, [x20, #0x48]
006693200  ldr      x21, [x21, #0xa18] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.IsBornState()
006693204  mov      x19, x0
006693208  tbnz     w8, #0, #0x6693220
00669320C  adrp     x0, #0x8f10000
006693210  ldr      x0, [x0, #0xa18] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.IsBornState()
006693214  bl       #0x382bd14 ; 
006693218  mov      w8, #1
00669321C  strb     w8, [x20, #0x48]
006693220  ldr      x1, [x21]
006693224  ldrb     w8, [x1, #0x53]
006693228  tbnz     w8, #5, #0x6693244
00669322C  ldr      x0, [x19, #0x40]
006693230  cbz      x0, #0x6693258
006693234  ldp      x20, x19, [sp, #0x10]
006693238  mov      x1, xzr
00669323C  ldp      x30, x21, [sp], #0x20
006693240  b        #0x6b94e1c ; HotFix.BattleLogic.AIStateController$$IsBornState
006693244  ldr      x2, [x1, #0x60]
006693248  mov      x0, x19
00669324C  ldp      x20, x19, [sp, #0x10]
006693250  ldp      x30, x21, [sp], #0x20
006693254  br       x2
006693258  bl       #0x382bfb8 ; 

