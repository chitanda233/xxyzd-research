; HotFix.BattleLogic.BattleStarManager$$CollectStar
; RVA 0x6595408; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006595408  str      x30, [sp, #-0x30]!
00659540C  stp      x22, x21, [sp, #0x10]
006595410  stp      x20, x19, [sp, #0x20]
006595414  adrp     x21, #0x9599000
006595418  adrp     x22, #0x8f08000
00659541C  ldrb     w8, [x21, #0x2cf]
006595420  ldr      x22, [x22, #0xad0] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.CollectStar() @ 0x923e930
006595424  mov      w20, w1
006595428  mov      x19, x0
00659542C  tbnz     w8, #0, #0x6595444
006595430  adrp     x0, #0x8f08000
006595434  ldr      x0, [x0, #0xad0] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.CollectStar() @ 0x923e930
006595438  bl       #0x382bd14 ; 
00659543C  mov      w8, #1
006595440  strb     w8, [x21, #0x2cf]
006595444  ldr      x2, [x22]
006595448  ldrb     w8, [x2, #0x53]
00659544C  tbnz     w8, #5, #0x659548c
006595450  adrp     x21, #0x9599000
006595454  ldrb     w8, [x21, #0x4aa]
006595458  cbnz     w8, #0x6595470
00659545C  adrp     x0, #0x8f08000
006595460  ldr      x0, [x0, #0xa98] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.get_WorldContext() @ 0x923e980
006595464  bl       #0x382bd14 ; 
006595468  mov      w8, #1
00659546C  strb     w8, [x21, #0x4aa]
006595470  adrp     x8, #0x8f08000
006595474  ldr      x8, [x8, #0xa98] ; GLOBAL Method$HotFix.BattleLogic.BattleStarManager.get_WorldContext() @ 0x923e980
006595478  ldr      x1, [x8]
00659547C  ldrb     w8, [x1, #0x53]
006595480  tbnz     w8, #5, #0x65954a8
006595484  ldr      x0, [x19, #0x10]
006595488  b        #0x65954b4 ; 
00659548C  ldr      x3, [x2, #0x60]
006595490  mov      x0, x19
006595494  mov      w1, w20
006595498  ldp      x20, x19, [sp, #0x20]
00659549C  ldp      x22, x21, [sp, #0x10]
0065954A0  ldr      x30, [sp], #0x30
0065954A4  br       x3
0065954A8  ldr      x8, [x1, #0x60]
0065954AC  mov      x0, x19
0065954B0  blr      x8
0065954B4  cbz      x0, #0x659553c
0065954B8  ldr      x8, [x0, #0x1b0]
0065954BC  mov      x0, x19
0065954C0  lsr      x8, x8, #0x10
0065954C4  str      w8, [x19, #0x20]
0065954C8  bl       #0x6595540 ; HotFix.BattleLogic.BattleStarManager$$CheckTime
0065954CC  mov      x0, x19
0065954D0  mov      w1, wzr
0065954D4  bl       #0x6595624 ; HotFix.BattleLogic.BattleStarManager$$CheckAliveCount
0065954D8  mov      x0, x19
0065954DC  mov      w1, w20
0065954E0  bl       #0x659586c ; HotFix.BattleLogic.BattleStarManager$$CheckHpPercent
0065954E4  ldr      x10, [x19, #0x18]
0065954E8  cbz      x10, #0x659553c
0065954EC  ldr      w9, [x10, #0x18]
0065954F0  mov      x8, xzr
0065954F4  mov      w0, wzr
0065954F8  add      x10, x10, #0x2c
0065954FC  mov      w11, #1
006595500  cmp      x8, x9
006595504  b.hs     #0x6595538
006595508  ldr      w12, [x10], #0x10
00659550C  lsl      w13, w11, w8
006595510  add      x8, x8, #1
006595514  cmp      w12, #1
006595518  csel     w12, w13, wzr, eq
00659551C  cmp      x8, #3
006595520  orr      w0, w12, w0
006595524  b.ne     #0x6595500
006595528  ldp      x20, x19, [sp, #0x20]
00659552C  ldp      x22, x21, [sp, #0x10]
006595530  ldr      x30, [sp], #0x30
006595534  ret      
006595538  bl       #0x382bfc0 ; 
00659553C  bl       #0x382bfb8 ; 

