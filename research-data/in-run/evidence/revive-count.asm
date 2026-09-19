; HotFix.BattleLogic.BattleWorldContext$$AddReliveCount
; RVA 0x6A226D0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A226D0  str      x30, [sp, #-0x30]!
006A226D4  stp      x22, x21, [sp, #0x10]
006A226D8  stp      x20, x19, [sp, #0x20]
006A226DC  adrp     x21, #0x959d000
006A226E0  adrp     x22, #0x8f33000
006A226E4  ldrb     w8, [x21, #0x632]
006A226E8  ldr      x22, [x22, #0x510] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddReliveCount() @ 0x923f5a8
006A226EC  mov      w20, w1
006A226F0  mov      x19, x0
006A226F4  tbnz     w8, #0, #0x6a2270c
006A226F8  adrp     x0, #0x8f33000
006A226FC  ldr      x0, [x0, #0x510] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddReliveCount() @ 0x923f5a8
006A22700  bl       #0x382bd14 ; 
006A22704  mov      w8, #1
006A22708  strb     w8, [x21, #0x632]
006A2270C  ldr      x2, [x22]
006A22710  ldrb     w8, [x2, #0x53]
006A22714  tbnz     w8, #5, #0x6a2275c
006A22718  cmp      w20, #3
006A2271C  b.ne     #0x6a228b8
006A22720  adrp     x20, #0x9599000
006A22724  ldrb     w8, [x20, #0x4bd]
006A22728  cbnz     w8, #0x6a22740
006A2272C  adrp     x0, #0x8f08000
006A22730  ldr      x0, [x0, #0xe88] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveCount() @ 0x923ff78
006A22734  bl       #0x382bd14 ; 
006A22738  mov      w8, #1
006A2273C  strb     w8, [x20, #0x4bd]
006A22740  adrp     x8, #0x8f08000
006A22744  ldr      x8, [x8, #0xe88] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveCount() @ 0x923ff78
006A22748  ldr      x1, [x8]
006A2274C  ldrb     w8, [x1, #0x53]
006A22750  tbnz     w8, #5, #0x6a22778
006A22754  ldr      w20, [x19, #0x2c8]
006A22758  b        #0x6a22788 ; 
006A2275C  ldr      x3, [x2, #0x60]
006A22760  mov      x0, x19
006A22764  mov      w1, w20
006A22768  ldp      x20, x19, [sp, #0x20]
006A2276C  ldp      x22, x21, [sp, #0x10]
006A22770  ldr      x30, [sp], #0x30
006A22774  br       x3
006A22778  ldr      x8, [x1, #0x60]
006A2277C  mov      x0, x19
006A22780  blr      x8
006A22784  mov      w20, w0
006A22788  adrp     x21, #0x9599000
006A2278C  ldrb     w8, [x21, #0x64d]
006A22790  cbnz     w8, #0x6a227a8
006A22794  adrp     x0, #0x8f0a000
006A22798  ldr      x0, [x0, #0x628] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_ReliveCount() @ 0x92400b0
006A2279C  bl       #0x382bd14 ; 
006A227A0  mov      w8, #1
006A227A4  strb     w8, [x21, #0x64d]
006A227A8  adrp     x8, #0x8f0a000
006A227AC  ldr      x8, [x8, #0x628] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_ReliveCount() @ 0x92400b0
006A227B0  sub      w1, w20, #1
006A227B4  ldr      x2, [x8]
006A227B8  ldrb     w8, [x2, #0x53]
006A227BC  tbnz     w8, #5, #0x6a227c8
006A227C0  str      w1, [x19, #0x2c8]
006A227C4  b        #0x6a227d4 ; 
006A227C8  ldr      x8, [x2, #0x60]
006A227CC  mov      x0, x19
006A227D0  blr      x8
006A227D4  adrp     x20, #0x9599000
006A227D8  ldrb     w8, [x20, #0x4af]
006A227DC  cbnz     w8, #0x6a227f4
006A227E0  adrp     x0, #0x8f08000
006A227E4  ldr      x0, [x0, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveUsedCount() @ 0x923ff88
006A227E8  bl       #0x382bd14 ; 
006A227EC  mov      w8, #1
006A227F0  strb     w8, [x20, #0x4af]
006A227F4  adrp     x8, #0x8f08000
006A227F8  ldr      x8, [x8, #0xae8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_ReliveUsedCount() @ 0x923ff88
006A227FC  ldr      x1, [x8]
006A22800  ldrb     w8, [x1, #0x53]
006A22804  tbnz     w8, #5, #0x6a22810
006A22808  ldr      w0, [x19, #0x2d0]
006A2280C  b        #0x6a2281c ; 
006A22810  ldr      x8, [x1, #0x60]
006A22814  mov      x0, x19
006A22818  blr      x8
006A2281C  adrp     x21, #0x9599000
006A22820  ldrb     w8, [x21, #0x64f]
006A22824  add      w20, w0, #1
006A22828  cbnz     w8, #0x6a22840
006A2282C  adrp     x0, #0x8f0a000
006A22830  ldr      x0, [x0, #0x638] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_ReliveUsedCount() @ 0x92400b8
006A22834  bl       #0x382bd14 ; 
006A22838  mov      w8, #1
006A2283C  strb     w8, [x21, #0x64f]
006A22840  adrp     x8, #0x8f0a000
006A22844  ldr      x8, [x8, #0x638] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_ReliveUsedCount() @ 0x92400b8
006A22848  ldr      x2, [x8]
006A2284C  ldrb     w8, [x2, #0x53]
006A22850  tbnz     w8, #5, #0x6a2285c
006A22854  str      w20, [x19, #0x2d0]
006A22858  b        #0x6a2286c ; 
006A2285C  ldr      x8, [x2, #0x60]
006A22860  mov      x0, x19
006A22864  mov      w1, w20
006A22868  blr      x8
006A2286C  mov      w1, #0x13
006A22870  mov      x0, x19
006A22874  bl       #0x69fcc24 ; HotFix.BattleLogic.BattleWorldContext$$CheckBattleFlag
006A22878  tbz      w0, #0, #0x6a228b8
006A2287C  adrp     x20, #0x9599000
006A22880  ldrb     w8, [x20, #0x2b9]
006A22884  cbnz     w8, #0x6a2289c
006A22888  adrp     x0, #0x8f08000
006A2288C  ldr      x0, [x0, #0xa78] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_StarMgr() @ 0x923ffc0
006A22890  bl       #0x382bd14 ; 
006A22894  mov      w8, #1
006A22898  strb     w8, [x20, #0x2b9]
006A2289C  adrp     x8, #0x8f08000
006A228A0  ldr      x8, [x8, #0xa78] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_StarMgr() @ 0x923ffc0
006A228A4  ldr      x1, [x8]
006A228A8  ldrb     w8, [x1, #0x53]
006A228AC  tbnz     w8, #5, #0x6a228c8
006A228B0  ldr      x0, [x19, #0x228]
006A228B4  b        #0x6a228d4 ; 
006A228B8  ldp      x20, x19, [sp, #0x20]
006A228BC  ldp      x22, x21, [sp, #0x10]
006A228C0  ldr      x30, [sp], #0x30
006A228C4  ret      
006A228C8  ldr      x8, [x1, #0x60]
006A228CC  mov      x0, x19
006A228D0  blr      x8
006A228D4  cbz      x0, #0x6a228ec
006A228D8  ldp      x20, x19, [sp, #0x20]
006A228DC  ldp      x22, x21, [sp, #0x10]
006A228E0  mov      x1, xzr
006A228E4  ldr      x30, [sp], #0x30
006A228E8  b        #0x659654c ; HotFix.BattleLogic.BattleStarManager$$OnPlayerRelive
006A228EC  bl       #0x382bfb8 ; 

