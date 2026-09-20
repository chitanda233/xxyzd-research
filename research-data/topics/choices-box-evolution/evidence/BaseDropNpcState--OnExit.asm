; HotFix.BattleLogic.BaseDropNpcState$$OnExit
; RVA 0x659880C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659880C  str      x30, [sp, #-0x30]!
006598810  stp      x22, x21, [sp, #0x10]
006598814  stp      x20, x19, [sp, #0x20]
006598818  adrp     x21, #0x9599000
00659881C  adrp     x22, #0x8f08000
006598820  ldrb     w8, [x21, #0x2ef]
006598824  ldr      x22, [x22, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.OnExit() @ 0x923b088
006598828  mov      x20, x1
00659882C  mov      x19, x0
006598830  tbnz     w8, #0, #0x6598848
006598834  adrp     x0, #0x8f08000
006598838  ldr      x0, [x0, #0xc98] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.OnExit() @ 0x923b088
00659883C  bl       #0x382bd14 ; 
006598840  mov      w8, #1
006598844  strb     w8, [x21, #0x2ef]
006598848  ldr      x2, [x22]
00659884C  ldrb     w8, [x2, #0x53]
006598850  tbnz     w8, #5, #0x659889c
006598854  mov      x0, x19
006598858  mov      x1, x20
00659885C  bl       #0x6598930 ; HotFix.BattleLogic.BattleState$$OnExit
006598860  adrp     x20, #0x9599000
006598864  ldrb     w8, [x20, #0x4b1]
006598868  cbnz     w8, #0x6598880
00659886C  adrp     x0, #0x8f08000
006598870  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
006598874  bl       #0x382bd14 ; 
006598878  mov      w8, #1
00659887C  strb     w8, [x20, #0x4b1]
006598880  adrp     x8, #0x8f08000
006598884  ldr      x8, [x8, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
006598888  ldr      x1, [x8]
00659888C  ldrb     w8, [x1, #0x53]
006598890  tbnz     w8, #5, #0x65988b8
006598894  ldr      x19, [x19, #0x10]
006598898  b        #0x65988c8 ; 
00659889C  ldr      x3, [x2, #0x60]
0065988A0  mov      x0, x19
0065988A4  mov      x1, x20
0065988A8  ldp      x20, x19, [sp, #0x20]
0065988AC  ldp      x22, x21, [sp, #0x10]
0065988B0  ldr      x30, [sp], #0x30
0065988B4  br       x3
0065988B8  ldr      x8, [x1, #0x60]
0065988BC  mov      x0, x19
0065988C0  blr      x8
0065988C4  mov      x19, x0
0065988C8  cbz      x19, #0x659892c
0065988CC  adrp     x20, #0x9599000
0065988D0  ldrb     w8, [x20, #0x287]
0065988D4  cbnz     w8, #0x65988ec
0065988D8  adrp     x0, #0x8f07000
0065988DC  ldr      x0, [x0, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
0065988E0  bl       #0x382bd14 ; 
0065988E4  mov      w8, #1
0065988E8  strb     w8, [x20, #0x287]
0065988EC  adrp     x8, #0x8f07000
0065988F0  ldr      x8, [x8, #0xcf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_DropMgr() @ 0x923feb8
0065988F4  ldr      x1, [x8]
0065988F8  ldrb     w8, [x1, #0x53]
0065988FC  tbnz     w8, #5, #0x6598908
006598900  ldr      x0, [x19, #0x350]
006598904  b        #0x6598914 ; 
006598908  ldr      x8, [x1, #0x60]
00659890C  mov      x0, x19
006598910  blr      x8
006598914  cbz      x0, #0x659892c
006598918  ldp      x20, x19, [sp, #0x20]
00659891C  ldp      x22, x21, [sp, #0x10]
006598920  mov      x1, xzr
006598924  ldr      x30, [sp], #0x30
006598928  b        #0x666ff78 ; HotFix.BattleLogic.DropMgr$$AbsorbAll
00659892C  bl       #0x382bfb8 ; 

