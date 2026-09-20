; HotFix.BattleLogic.WaterfallStatePunchboard$$OnEnter
; RVA 0x65B56A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B56A0  str      x30, [sp, #-0x30]!
0065B56A4  stp      x22, x21, [sp, #0x10]
0065B56A8  stp      x20, x19, [sp, #0x20]
0065B56AC  adrp     x21, #0x9599000
0065B56B0  adrp     x22, #0x8f09000
0065B56B4  ldrb     w8, [x21, #0x431]
0065B56B8  ldr      x22, [x22, #0xbf0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStatePunchboard.OnEnter() @ 0x92c8858
0065B56BC  mov      x20, x1
0065B56C0  mov      x19, x0
0065B56C4  tbnz     w8, #0, #0x65b56e8
0065B56C8  adrp     x0, #0x8f08000
0065B56CC  ldr      x0, [x0, #0xf48] ; GLOBAL HotFix.BattleLogic.WaterfallBattleManager_TypeInfo @ 0x91f48a8
0065B56D0  bl       #0x382bd14 ; 
0065B56D4  adrp     x0, #0x8f09000
0065B56D8  ldr      x0, [x0, #0xbf0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStatePunchboard.OnEnter() @ 0x92c8858
0065B56DC  bl       #0x382bd14 ; 
0065B56E0  mov      w8, #1
0065B56E4  strb     w8, [x21, #0x431]
0065B56E8  ldr      x2, [x22]
0065B56EC  ldrb     w8, [x2, #0x53]
0065B56F0  tbnz     w8, #5, #0x65b573c
0065B56F4  mov      x0, x19
0065B56F8  mov      x1, x20
0065B56FC  bl       #0x659f00c ; HotFix.BattleLogic.BasePunchboardState$$OnEnter
0065B5700  adrp     x20, #0x9599000
0065B5704  ldrb     w8, [x20, #0x4b1]
0065B5708  cbnz     w8, #0x65b5720
0065B570C  adrp     x0, #0x8f08000
0065B5710  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B5714  bl       #0x382bd14 ; 
0065B5718  mov      w8, #1
0065B571C  strb     w8, [x20, #0x4b1]
0065B5720  adrp     x8, #0x8f08000
0065B5724  ldr      x8, [x8, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B5728  ldr      x1, [x8]
0065B572C  ldrb     w8, [x1, #0x53]
0065B5730  tbnz     w8, #5, #0x65b5758
0065B5734  ldr      x19, [x19, #0x10]
0065B5738  b        #0x65b5768 ; 
0065B573C  ldr      x3, [x2, #0x60]
0065B5740  mov      x0, x19
0065B5744  mov      x1, x20
0065B5748  ldp      x20, x19, [sp, #0x20]
0065B574C  ldp      x22, x21, [sp, #0x10]
0065B5750  ldr      x30, [sp], #0x30
0065B5754  br       x3
0065B5758  ldr      x8, [x1, #0x60]
0065B575C  mov      x0, x19
0065B5760  blr      x8
0065B5764  mov      x19, x0
0065B5768  cbz      x19, #0x65b5800
0065B576C  adrp     x20, #0x9598000
0065B5770  ldrb     w8, [x20, #0xfc4]
0065B5774  cbnz     w8, #0x65b578c
0065B5778  adrp     x0, #0x8f05000
0065B577C  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B5780  bl       #0x382bd14 ; 
0065B5784  mov      w8, #1
0065B5788  strb     w8, [x20, #0xfc4]
0065B578C  adrp     x8, #0x8f05000
0065B5790  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B5794  ldr      x1, [x8]
0065B5798  ldrb     w8, [x1, #0x53]
0065B579C  tbnz     w8, #5, #0x65b57a8
0065B57A0  ldr      x0, [x19, #0x220]
0065B57A4  b        #0x65b57b4 ; 
0065B57A8  ldr      x8, [x1, #0x60]
0065B57AC  mov      x0, x19
0065B57B0  blr      x8
0065B57B4  cbz      x0, #0x65b5800
0065B57B8  adrp     x9, #0x8f08000
0065B57BC  ldr      x9, [x9, #0xf48] ; GLOBAL HotFix.BattleLogic.WaterfallBattleManager_TypeInfo @ 0x91f48a8
0065B57C0  ldr      x8, [x0]
0065B57C4  ldr      x1, [x9]
0065B57C8  ldrb     w10, [x8, #0x130]
0065B57CC  ldrb     w9, [x1, #0x130]
0065B57D0  cmp      w10, w9
0065B57D4  b.lo     #0x65b5804
0065B57D8  ldr      x8, [x8, #0xc8]
0065B57DC  add      x8, x8, x9, lsl #3
0065B57E0  ldur     x8, [x8, #-8]
0065B57E4  cmp      x8, x1
0065B57E8  b.ne     #0x65b5804
0065B57EC  ldp      x20, x19, [sp, #0x20]
0065B57F0  ldp      x22, x21, [sp, #0x10]
0065B57F4  str      wzr, [x0, #0x128]
0065B57F8  ldr      x30, [sp], #0x30
0065B57FC  ret      
0065B5800  bl       #0x382bfb8 ; 
0065B5804  bl       #0x382c354 ; 

