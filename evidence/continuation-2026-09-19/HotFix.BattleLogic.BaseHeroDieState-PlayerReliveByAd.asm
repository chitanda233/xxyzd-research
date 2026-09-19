; HotFix.BattleLogic.BaseHeroDieState$$PlayerReliveByAd
; RVA 0x659C428; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659C428  stp      x30, x21, [sp, #-0x20]!
00659C42C  stp      x20, x19, [sp, #0x10]
00659C430  adrp     x20, #0x9599000
00659C434  adrp     x21, #0x8f08000
00659C438  ldrb     w8, [x20, #0x311]
00659C43C  ldr      x21, [x21, #0xeb0] ; GLOBAL Method$HotFix.BattleLogic.BaseHeroDieState.PlayerReliveByAd() @ 0x923b258
00659C440  mov      x19, x0
00659C444  tbnz     w8, #0, #0x659c45c
00659C448  adrp     x0, #0x8f08000
00659C44C  ldr      x0, [x0, #0xeb0] ; GLOBAL Method$HotFix.BattleLogic.BaseHeroDieState.PlayerReliveByAd() @ 0x923b258
00659C450  bl       #0x382bd14 ; 
00659C454  mov      w8, #1
00659C458  strb     w8, [x20, #0x311]
00659C45C  ldr      x1, [x21]
00659C460  ldrb     w8, [x1, #0x53]
00659C464  tbnz     w8, #5, #0x659c4a4
00659C468  adrp     x20, #0x9599000
00659C46C  ldrb     w8, [x20, #0x4b1]
00659C470  cbnz     w8, #0x659c488
00659C474  adrp     x0, #0x8f08000
00659C478  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C47C  bl       #0x382bd14 ; 
00659C480  mov      w8, #1
00659C484  strb     w8, [x20, #0x4b1]
00659C488  adrp     x8, #0x8f08000
00659C48C  ldr      x8, [x8, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C490  ldr      x1, [x8]
00659C494  ldrb     w8, [x1, #0x53]
00659C498  tbnz     w8, #5, #0x659c4b8
00659C49C  ldr      x0, [x19, #0x10]
00659C4A0  b        #0x659c4c4 ; 
00659C4A4  ldr      x2, [x1, #0x60]
00659C4A8  mov      x0, x19
00659C4AC  ldp      x20, x19, [sp, #0x10]
00659C4B0  ldp      x30, x21, [sp], #0x20
00659C4B4  br       x2
00659C4B8  ldr      x8, [x1, #0x60]
00659C4BC  mov      x0, x19
00659C4C0  blr      x8
00659C4C4  cbz      x0, #0x659c4e4
00659C4C8  mov      x1, xzr
00659C4CC  bl       #0x6a228f0 ; HotFix.BattleLogic.BattleWorldContext$$AddAdReliveCount
00659C4D0  mov      x0, x19
00659C4D4  ldp      x20, x19, [sp, #0x10]
00659C4D8  mov      w1, #3
00659C4DC  ldp      x30, x21, [sp], #0x20
00659C4E0  b        #0x659c4e8 ; HotFix.BattleLogic.BaseHeroDieState$$PlayerRelive
00659C4E4  bl       #0x382bfb8 ; 

