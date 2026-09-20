; HotFix.BattleLogic.WaterfallStatePunchboard$$OnExit
; RVA 0x65B5808; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065B5808  str      x30, [sp, #-0x30]!
0065B580C  stp      x22, x21, [sp, #0x10]
0065B5810  stp      x20, x19, [sp, #0x20]
0065B5814  adrp     x21, #0x9599000
0065B5818  adrp     x22, #0x8f09000
0065B581C  ldrb     w8, [x21, #0x432]
0065B5820  ldr      x22, [x22, #0xbf8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStatePunchboard.OnExit() @ 0x92c8860
0065B5824  mov      x20, x1
0065B5828  mov      x19, x0
0065B582C  tbnz     w8, #0, #0x65b5850
0065B5830  adrp     x0, #0x8f07000
0065B5834  ldr      x0, [x0, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065B5838  bl       #0x382bd14 ; 
0065B583C  adrp     x0, #0x8f09000
0065B5840  ldr      x0, [x0, #0xbf8] ; GLOBAL Method$HotFix.BattleLogic.WaterfallStatePunchboard.OnExit() @ 0x92c8860
0065B5844  bl       #0x382bd14 ; 
0065B5848  mov      w8, #1
0065B584C  strb     w8, [x21, #0x432]
0065B5850  ldr      x2, [x22]
0065B5854  ldrb     w8, [x2, #0x53]
0065B5858  tbnz     w8, #5, #0x65b58cc
0065B585C  mov      x0, x19
0065B5860  mov      x1, x20
0065B5864  bl       #0x65a00a0 ; HotFix.BattleLogic.BasePunchboardState$$OnExit
0065B5868  ldr      x0, [x19, #0x18]
0065B586C  cbz      x0, #0x65b5978
0065B5870  adrp     x8, #0x8f07000
0065B5874  ldr      x8, [x8, #0xe68] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentRandomSkill>() @ 0x9210120
0065B5878  ldr      x1, [x8]
0065B587C  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
0065B5880  cbz      x0, #0x65b5978
0065B5884  mov      x1, xzr
0065B5888  bl       #0x6870404 ; HotFix.BattleLogic.HeroComponentRandomSkill$$CheckNeedOpenSpecialSkill
0065B588C  tbz      w0, #0, #0x65b58e8
0065B5890  adrp     x20, #0x9599000
0065B5894  ldrb     w8, [x20, #0x4b1]
0065B5898  cbnz     w8, #0x65b58b0
0065B589C  adrp     x0, #0x8f08000
0065B58A0  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B58A4  bl       #0x382bd14 ; 
0065B58A8  mov      w8, #1
0065B58AC  strb     w8, [x20, #0x4b1]
0065B58B0  adrp     x8, #0x8f08000
0065B58B4  ldr      x8, [x8, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
0065B58B8  ldr      x1, [x8]
0065B58BC  ldrb     w8, [x1, #0x53]
0065B58C0  tbnz     w8, #5, #0x65b58f8
0065B58C4  ldr      x19, [x19, #0x10]
0065B58C8  b        #0x65b5908 ; 
0065B58CC  ldr      x3, [x2, #0x60]
0065B58D0  mov      x0, x19
0065B58D4  mov      x1, x20
0065B58D8  ldp      x20, x19, [sp, #0x20]
0065B58DC  ldp      x22, x21, [sp, #0x10]
0065B58E0  ldr      x30, [sp], #0x30
0065B58E4  br       x3
0065B58E8  ldp      x20, x19, [sp, #0x20]
0065B58EC  ldp      x22, x21, [sp, #0x10]
0065B58F0  ldr      x30, [sp], #0x30
0065B58F4  ret      
0065B58F8  ldr      x8, [x1, #0x60]
0065B58FC  mov      x0, x19
0065B5900  blr      x8
0065B5904  mov      x19, x0
0065B5908  cbz      x19, #0x65b5978
0065B590C  adrp     x20, #0x9598000
0065B5910  ldrb     w8, [x20, #0xfc4]
0065B5914  cbnz     w8, #0x65b592c
0065B5918  adrp     x0, #0x8f05000
0065B591C  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B5920  bl       #0x382bd14 ; 
0065B5924  mov      w8, #1
0065B5928  strb     w8, [x20, #0xfc4]
0065B592C  adrp     x8, #0x8f05000
0065B5930  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0065B5934  ldr      x1, [x8]
0065B5938  ldrb     w8, [x1, #0x53]
0065B593C  tbnz     w8, #5, #0x65b5948
0065B5940  ldr      x0, [x19, #0x220]
0065B5944  b        #0x65b5954 ; 
0065B5948  ldr      x8, [x1, #0x60]
0065B594C  mov      x0, x19
0065B5950  blr      x8
0065B5954  cbz      x0, #0x65b5978
0065B5958  ldp      x20, x19, [sp, #0x20]
0065B595C  ldp      x22, x21, [sp, #0x10]
0065B5960  mov      w1, #0xc
0065B5964  mov      x2, xzr
0065B5968  mov      w3, wzr
0065B596C  mov      x4, xzr
0065B5970  ldr      x30, [sp], #0x30
0065B5974  b        #0x6580ee4 ; HotFix.BattleLogic.BattleManager$$ActiveState
0065B5978  bl       #0x382bfb8 ; 

