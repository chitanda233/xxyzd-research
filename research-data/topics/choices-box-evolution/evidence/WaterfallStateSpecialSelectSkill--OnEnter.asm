; HotFix.BattleLogic.WaterfallStateSpecialSelectSkill$$OnEnter
; RVA 0x65B73A0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B73A0  str      x30, [sp, #-0x40]!
0065B73A4  stp      x24, x23, [sp, #0x10]
0065B73A8  stp      x22, x21, [sp, #0x20]
0065B73AC  stp      x20, x19, [sp, #0x30]
0065B73B0  adrp     x21, #0x9599000
0065B73B4  adrp     x22, #0x8f09000
0065B73B8  ldrb     w8, [x21, #0x444]
0065B73BC  ldr      x22, [x22, #0xcb0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.OnEnter() @ 0x92c88f8
0065B73C0  mov      x20, x1
0065B73C4  mov      x19, x0
0065B73C8  tbnz     w8, #0, #0x65b7428
0065B73CC  adrp     x0, #0x8ec1000
0065B73D0  ldr      x0, [x0, #0x6e8] ; GLOBAL System.Action_TypeInfo @ 0x91e0118
0065B73D4  bl       #0x382bd14 ; 
0065B73D8  adrp     x0, #0x8ec2000
0065B73DC  ldr      x0, [x0, #0xf78] ; GLOBAL System.Func<bool>_TypeInfo @ 0x91d3888
0065B73E0  bl       #0x382bd14 ; 
0065B73E4  adrp     x0, #0x8f08000
0065B73E8  ldr      x0, [x0, #0x258] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.Init() @ 0x922db10
0065B73EC  bl       #0x382bd14 ; 
0065B73F0  adrp     x0, #0x8f09000
0065B73F4  ldr      x0, [x0, #0xcb0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.OnEnter() @ 0x92c88f8
0065B73F8  bl       #0x382bd14 ; 
0065B73FC  adrp     x0, #0x8f09000
0065B7400  ldr      x0, [x0, #0xcb8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_0() @ 0x92c88c8
0065B7404  bl       #0x382bd14 ; 
0065B7408  adrp     x0, #0x8f09000
0065B740C  ldr      x0, [x0, #0xcc0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_1() @ 0x92c88d0
0065B7410  bl       #0x382bd14 ; 
0065B7414  adrp     x0, #0x8f09000
0065B7418  ldr      x0, [x0, #0xcc8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_2() @ 0x92c88d8
0065B741C  bl       #0x382bd14 ; 
0065B7420  mov      w8, #1
0065B7424  strb     w8, [x21, #0x444]
0065B7428  ldr      x2, [x22]
0065B742C  ldrb     w8, [x2, #0x53]
0065B7430  tbnz     w8, #5, #0x65b7470
0065B7434  adrp     x22, #0x9599000
0065B7438  ldrb     w8, [x22, #0x4b1]
0065B743C  cbnz     w8, #0x65b7454
0065B7440  adrp     x0, #0x8f08000
0065B7444  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B7448  bl       #0x382bd14 ; 
0065B744C  mov      w8, #1
0065B7450  strb     w8, [x22, #0x4b1]
0065B7454  adrp     x23, #0x8f08000
0065B7458  ldr      x23, [x23, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B745C  ldr      x1, [x23]
0065B7460  ldrb     w8, [x1, #0x53]
0065B7464  tbnz     w8, #5, #0x65b7490
0065B7468  ldr      x20, [x19, #0x10]
0065B746C  b        #0x65b74a0 ; 
0065B7470  ldr      x3, [x2, #0x60]
0065B7474  mov      x0, x19
0065B7478  mov      x1, x20
0065B747C  ldp      x20, x19, [sp, #0x30]
0065B7480  ldp      x22, x21, [sp, #0x20]
0065B7484  ldp      x24, x23, [sp, #0x10]
0065B7488  ldr      x30, [sp], #0x40
0065B748C  br       x3
0065B7490  ldr      x8, [x1, #0x60]
0065B7494  mov      x0, x19
0065B7498  blr      x8
0065B749C  mov      x20, x0
0065B74A0  cbz      x20, #0x65b7674
0065B74A4  adrp     x21, #0x9599000
0065B74A8  ldrb     w8, [x21, #0x29c]
0065B74AC  cbnz     w8, #0x65b74c4
0065B74B0  adrp     x0, #0x8f08000
0065B74B4  ldr      x0, [x0, #0x70] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_pauseUpdateExp() @ 0x9240028
0065B74B8  bl       #0x382bd14 ; 
0065B74BC  mov      w8, #1
0065B74C0  strb     w8, [x21, #0x29c]
0065B74C4  adrp     x8, #0x8f08000
0065B74C8  ldr      x8, [x8, #0x70] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_pauseUpdateExp() @ 0x9240028
0065B74CC  ldr      x1, [x8]
0065B74D0  ldrb     w8, [x1, #0x53]
0065B74D4  tbnz     w8, #5, #0x65b74e0
0065B74D8  ldr      w0, [x20, #0x190]
0065B74DC  b        #0x65b74ec ; 
0065B74E0  ldr      x8, [x1, #0x60]
0065B74E4  mov      x0, x20
0065B74E8  blr      x8
0065B74EC  adrp     x24, #0x9599000
0065B74F0  ldrb     w8, [x24, #0x4de]
0065B74F4  add      w21, w0, #1
0065B74F8  cbnz     w8, #0x65b7510
0065B74FC  adrp     x0, #0x8f09000
0065B7500  ldr      x0, [x0, #0xc50] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_pauseUpdateExp() @ 0x9240118
0065B7504  bl       #0x382bd14 ; 
0065B7508  mov      w8, #1
0065B750C  strb     w8, [x24, #0x4de]
0065B7510  adrp     x8, #0x8f09000
0065B7514  ldr      x8, [x8, #0xc50] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.set_pauseUpdateExp() @ 0x9240118
0065B7518  ldr      x2, [x8]
0065B751C  ldrb     w8, [x2, #0x53]
0065B7520  tbnz     w8, #5, #0x65b752c
0065B7524  str      w21, [x20, #0x190]
0065B7528  b        #0x65b753c ; 
0065B752C  ldr      x8, [x2, #0x60]
0065B7530  mov      x0, x20
0065B7534  mov      w1, w21
0065B7538  blr      x8
0065B753C  ldrb     w8, [x22, #0x4b1]
0065B7540  cbnz     w8, #0x65b7558
0065B7544  adrp     x0, #0x8f08000
0065B7548  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B754C  bl       #0x382bd14 ; 
0065B7550  mov      w8, #1
0065B7554  strb     w8, [x22, #0x4b1]
0065B7558  ldr      x1, [x23]
0065B755C  ldrb     w8, [x1, #0x53]
0065B7560  tbnz     w8, #5, #0x65b756c
0065B7564  ldr      x0, [x19, #0x10]
0065B7568  b        #0x65b7578 ; 
0065B756C  ldr      x8, [x1, #0x60]
0065B7570  mov      x0, x19
0065B7574  blr      x8
0065B7578  cbz      x0, #0x65b7674
0065B757C  mov      w1, #4
0065B7580  mov      x2, xzr
0065B7584  bl       #0x6a052e4 ; HotFix.BattleLogic.BattleWorldContext$$SetBattleFlag
0065B7588  ldr      x0, [x19, #0x28]
0065B758C  cbz      x0, #0x65b7674
0065B7590  adrp     x8, #0x8f08000
0065B7594  ldr      x8, [x8, #0x258] ; GLOBAL Method$HotFix.Common.TaskQueue<FP>.Init() @ 0x922db10
0065B7598  ldr      x1, [x8]
0065B759C  bl       #0x556fd48 ; HotFix.Common.TaskQueue<FP>$$Init
0065B75A0  adrp     x21, #0x8ec1000
0065B75A4  ldr      x21, [x21, #0x6e8] ; GLOBAL System.Action_TypeInfo @ 0x91e0118
0065B75A8  ldr      x0, [x21]
0065B75AC  bl       #0x382bfa0 ; 
0065B75B0  adrp     x8, #0x8f09000
0065B75B4  ldr      x8, [x8, #0xcb8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_0() @ 0x92c88c8
0065B75B8  mov      x1, x19
0065B75BC  mov      x3, xzr
0065B75C0  mov      x20, x0
0065B75C4  ldr      x2, [x8]
0065B75C8  bl       #0x7ade578 ; System.Action$$.ctor
0065B75CC  mov      x0, x19
0065B75D0  mov      x1, x20
0065B75D4  bl       #0x65b7678 ; HotFix.BattleLogic.WaterfallStateSpecialSelectSkill$$AddEventAction
0065B75D8  ldr      x0, [x21]
0065B75DC  bl       #0x382bfa0 ; 
0065B75E0  ldr      x8, [x19]
0065B75E4  mov      x1, x19
0065B75E8  mov      x3, xzr
0065B75EC  mov      x20, x0
0065B75F0  ldr      x2, [x8, #0x1c0]
0065B75F4  bl       #0x7ade578 ; System.Action$$.ctor
0065B75F8  mov      x0, x19
0065B75FC  mov      x1, x20
0065B7600  bl       #0x65b7678 ; HotFix.BattleLogic.WaterfallStateSpecialSelectSkill$$AddEventAction
0065B7604  adrp     x8, #0x8ec2000
0065B7608  ldr      x8, [x8, #0xf78] ; GLOBAL System.Func<bool>_TypeInfo @ 0x91d3888
0065B760C  ldr      x0, [x8]
0065B7610  bl       #0x382bfa0 ; 
0065B7614  adrp     x8, #0x8f09000
0065B7618  ldr      x8, [x8, #0xcc0] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_1() @ 0x92c88d0
0065B761C  mov      x1, x19
0065B7620  mov      x3, xzr
0065B7624  mov      x20, x0
0065B7628  ldr      x2, [x8]
0065B762C  bl       #0x635ad78 ; System.Func<bool>$$.ctor
0065B7630  ldr      x0, [x21]
0065B7634  bl       #0x382bfa0 ; 
0065B7638  adrp     x8, #0x8f09000
0065B763C  ldr      x8, [x8, #0xcc8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStateSpecialSelectSkill.<OnEnter>b__3_2() @ 0x92c88d8
0065B7640  mov      x1, x19
0065B7644  mov      x3, xzr
0065B7648  mov      x21, x0
0065B764C  ldr      x2, [x8]
0065B7650  bl       #0x7ade578 ; System.Action$$.ctor
0065B7654  mov      x0, x19
0065B7658  mov      x1, x20
0065B765C  mov      x2, x21
0065B7660  ldp      x20, x19, [sp, #0x30]
0065B7664  ldp      x22, x21, [sp, #0x20]
0065B7668  ldp      x24, x23, [sp, #0x10]
0065B766C  ldr      x30, [sp], #0x40
0065B7670  b        #0x65b76f8 ; HotFix.BattleLogic.WaterfallStateSpecialSelectSkill$$AddConditional
0065B7674  bl       #0x382bfb8 ; 

