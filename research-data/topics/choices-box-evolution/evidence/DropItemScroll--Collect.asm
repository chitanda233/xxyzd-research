; HotFix.BattleLogic.DropItemScroll$$Collect
; RVA 0x66692EC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066692EC  str      x30, [sp, #-0x30]!
0066692F0  stp      x22, x21, [sp, #0x10]
0066692F4  stp      x20, x19, [sp, #0x20]
0066692F8  adrp     x20, #0x9599000
0066692FC  adrp     x21, #0x8f0f000
006669300  ldrb     w8, [x20, #0xd93]
006669304  ldr      x21, [x21, #0x418] ; GLOBAL Method$HotFix.BattleLogic.DropItemScroll.Collect() @ 0x925fe40
006669308  mov      x19, x0
00666930C  tbnz     w8, #0, #0x6669330
006669310  adrp     x0, #0x8f0f000
006669314  ldr      x0, [x0, #0x418] ; GLOBAL Method$HotFix.BattleLogic.DropItemScroll.Collect() @ 0x925fe40
006669318  bl       #0x382bd14 ; 
00666931C  adrp     x0, #0x8f0f000
006669320  ldr      x0, [x0, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
006669324  bl       #0x382bd14 ; 
006669328  mov      w8, #1
00666932C  strb     w8, [x20, #0xd93]
006669330  ldr      x1, [x21]
006669334  ldrb     w8, [x1, #0x53]
006669338  tbnz     w8, #5, #0x6669354
00666933C  ldrb     w8, [x19, #0xf0]
006669340  cbz      w8, #0x666936c
006669344  ldp      x20, x19, [sp, #0x20]
006669348  ldp      x22, x21, [sp, #0x10]
00666934C  ldr      x30, [sp], #0x30
006669350  ret      
006669354  ldr      x2, [x1, #0x60]
006669358  mov      x0, x19
00666935C  ldp      x20, x19, [sp, #0x20]
006669360  ldp      x22, x21, [sp, #0x10]
006669364  ldr      x30, [sp], #0x30
006669368  br       x2
00666936C  mov      w8, #1
006669370  strb     w8, [x19, #0xf0]
006669374  adrp     x22, #0x8f0f000
006669378  ldr      x22, [x22, #0x20] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<DropItemData>.get_Data() @ 0x920fe88
00666937C  ldr      x1, [x22]
006669380  ldrb     w8, [x1, #0x53]
006669384  tbnz     w8, #5, #0x6669390
006669388  ldr      x0, [x19, #0x38]
00666938C  b        #0x666939c ; 
006669390  ldr      x8, [x1, #0x60]
006669394  mov      x0, x19
006669398  blr      x8
00666939C  cbz      x0, #0x666949c
0066693A0  ldr      w8, [x0, #0xc8]
0066693A4  adrp     x21, #0x9591000
0066693A8  ldrb     w9, [x21, #0xa4b]
0066693AC  cmp      w8, #0
0066693B0  csinc    w20, w8, wzr, ne
0066693B4  cbnz     w9, #0x66693cc
0066693B8  adrp     x0, #0x8ee5000
0066693BC  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0066693C0  bl       #0x382bd14 ; 
0066693C4  mov      w8, #1
0066693C8  strb     w8, [x21, #0xa4b]
0066693CC  adrp     x8, #0x8ee5000
0066693D0  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0066693D4  ldr      x1, [x8]
0066693D8  ldrb     w8, [x1, #0x53]
0066693DC  tbnz     w8, #5, #0x66693e8
0066693E0  ldr      x21, [x19, #0x20]
0066693E4  b        #0x66693f8 ; 
0066693E8  ldr      x8, [x1, #0x60]
0066693EC  mov      x0, x19
0066693F0  blr      x8
0066693F4  mov      x21, x0
0066693F8  ldr      x1, [x22]
0066693FC  ldrb     w8, [x1, #0x53]
006669400  tbnz     w8, #5, #0x666940c
006669404  ldr      x0, [x19, #0x38]
006669408  b        #0x6669418 ; 
00666940C  ldr      x8, [x1, #0x60]
006669410  mov      x0, x19
006669414  blr      x8
006669418  cbz      x0, #0x666949c
00666941C  cbz      x21, #0x666949c
006669420  ldr      x8, [x0, #0xc0]
006669424  adrp     x22, #0x9599000
006669428  ldrb     w9, [x22, #0xec6]
00666942C  lsr      x19, x8, #0x10
006669430  cbnz     w9, #0x6669448
006669434  adrp     x0, #0x8f0f000
006669438  ldr      x0, [x0, #0x2b0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddDropInfo() @ 0x923f570
00666943C  bl       #0x382bd14 ; 
006669440  mov      w8, #1
006669444  strb     w8, [x22, #0xec6]
006669448  adrp     x8, #0x8f0f000
00666944C  ldr      x8, [x8, #0x2b0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddDropInfo() @ 0x923f570
006669450  ldr      x3, [x8]
006669454  ldrb     w8, [x3, #0x53]
006669458  tbnz     w8, #5, #0x666947c
00666945C  add      x0, x21, #0x290
006669460  mov      w1, w19
006669464  mov      w2, w20
006669468  ldp      x20, x19, [sp, #0x20]
00666946C  ldp      x22, x21, [sp, #0x10]
006669470  mov      x3, xzr
006669474  ldr      x30, [sp], #0x30
006669478  b        #0x658eb6c ; HotFix.BattleLogic.BattleData$$AddDropInfo
00666947C  ldr      x4, [x3, #0x60]
006669480  mov      x0, x21
006669484  mov      w1, w19
006669488  mov      w2, w20
00666948C  ldp      x20, x19, [sp, #0x20]
006669490  ldp      x22, x21, [sp, #0x10]
006669494  ldr      x30, [sp], #0x30
006669498  br       x4
00666949C  bl       #0x382bfb8 ; 

