; HotFix.BattleLogic.AIMoveOnPathLoopBorn$$InitAttackLoop
; RVA 0x654D7E4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654D7E4  sub      sp, sp, #0x80
00654D7E8  str      x30, [sp, #0x50]
00654D7EC  stp      x22, x21, [sp, #0x60]
00654D7F0  stp      x20, x19, [sp, #0x70]
00654D7F4  mrs      x22, tpidr_el0
00654D7F8  ldr      x8, [x22, #0x28]
00654D7FC  adrp     x20, #0x9598000
00654D800  adrp     x21, #0x8f05000
00654D804  mov      x19, x0
00654D808  str      x8, [sp, #0x48]
00654D80C  ldrb     w8, [x20, #0xe57]
00654D810  ldr      x21, [x21, #0x9b0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathLoopBorn.InitAttackLoop()
00654D814  tbnz     w8, #0, #0x654d874
00654D818  adrp     x0, #0x8f05000
00654D81C  ldr      x0, [x0, #0x9b0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathLoopBorn.InitAttackLoop()
00654D820  bl       #0x382bd14 ; 
00654D824  adrp     x0, #0x8f05000
00654D828  ldr      x0, [x0, #0x9b8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathLoopBorn.<InitAttackLoop>b__7_0()
00654D82C  bl       #0x382bd14 ; 
00654D830  adrp     x0, #0x8f05000
00654D834  ldr      x0, [x0, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveOnPath>()
00654D838  bl       #0x382bd14 ; 
00654D83C  adrp     x0, #0x8f05000
00654D840  ldr      x0, [x0, #0x9c0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MoveOnStraightDown>()
00654D844  bl       #0x382bd14 ; 
00654D848  adrp     x0, #0x8f05000
00654D84C  ldr      x0, [x0, #0x9c8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.SelectEntity_NearOne()
00654D850  bl       #0x382bd14 ; 
00654D854  adrp     x0, #0x8ec1000
00654D858  ldr      x0, [x0, #0x6e8] ; GLOBAL System.Action_TypeInfo
00654D85C  bl       #0x382bd14 ; 
00654D860  adrp     x0, #0x8f05000
00654D864  ldr      x0, [x0, #0x9d0] ; GLOBAL System.Func<EntityCharacter>_TypeInfo
00654D868  bl       #0x382bd14 ; 
00654D86C  mov      w8, #1
00654D870  strb     w8, [x20, #0xe57]
00654D874  ldr      x1, [x21]
00654D878  ldrb     w8, [x1, #0x53]
00654D87C  tbnz     w8, #5, #0x654d8d4
00654D880  ldrb     w8, [x19, #0x120]
00654D884  cbz      w8, #0x654d940
00654D888  ldrb     w8, [x19, #0x121]
00654D88C  cbnz     w8, #0x654d940
00654D890  ldr      x20, [x19, #0x58]
00654D894  cbz      x20, #0x654da80
00654D898  adrp     x21, #0x9598000
00654D89C  ldrb     w8, [x21, #0xfb7]
00654D8A0  cbnz     w8, #0x654d8b8
00654D8A4  adrp     x0, #0x8f05000
00654D8A8  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00654D8AC  bl       #0x382bd14 ; 
00654D8B0  mov      w8, #1
00654D8B4  strb     w8, [x21, #0xfb7]
00654D8B8  adrp     x8, #0x8f05000
00654D8BC  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00654D8C0  ldr      x1, [x8]
00654D8C4  ldrb     w8, [x1, #0x53]
00654D8C8  tbnz     w8, #5, #0x654d8e4
00654D8CC  ldr      x20, [x20, #0x118]
00654D8D0  b        #0x654d8f4 ; 
00654D8D4  ldr      x8, [x1, #0x60]
00654D8D8  mov      x0, x19
00654D8DC  blr      x8
00654D8E0  b        #0x654da5c ; 
00654D8E4  ldr      x8, [x1, #0x60]
00654D8E8  mov      x0, x20
00654D8EC  blr      x8
00654D8F0  mov      x20, x0
00654D8F4  ldr      x0, [x19, #0x58]
00654D8F8  cbz      x0, #0x654da80
00654D8FC  add      x8, sp, #0x18
00654D900  mov      x1, xzr
00654D904  bl       #0x67d6328 ; HotFix.BattleLogic.EntityCharacter$$GetLoopMoveRestartPos
00654D908  ldur     q0, [sp, #0x18]
00654D90C  ldr      x8, [sp, #0x28]
00654D910  str      q0, [sp, #0x30]
00654D914  str      x8, [sp, #0x40]
00654D918  cbz      x20, #0x654da80
00654D91C  ldr      q0, [sp, #0x30]
00654D920  ldr      x8, [sp, #0x40]
00654D924  mov      x1, sp
00654D928  mov      w2, #1
00654D92C  mov      x0, x20
00654D930  mov      x3, xzr
00654D934  str      q0, [sp]
00654D938  str      x8, [sp, #0x10]
00654D93C  bl       #0x672c418 ; HotFix.BattleLogic.CharacterComponentTransform$$MoveToPosition
00654D940  mov      w8, #1
00654D944  strh     w8, [x19, #0x120]
00654D948  adrp     x8, #0x8f05000
00654D94C  ldr      x8, [x8, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveOnPath>()
00654D950  mov      x0, x19
00654D954  ldr      x1, [x8]
00654D958  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654D95C  ldr      x8, [x19, #0x118]
00654D960  cbz      x8, #0x654da80
00654D964  mov      x1, x0
00654D968  cbz      x0, #0x654da80
00654D96C  ldr      w8, [x8, #0x10]
00654D970  mov      x0, x19
00654D974  mov      x2, xzr
00654D978  strh     wzr, [x1, #0x74]
00654D97C  str      w8, [x1, #0x70]
00654D980  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00654D984  adrp     x8, #0x8ec1000
00654D988  ldr      x8, [x8, #0x6e8] ; GLOBAL System.Action_TypeInfo
00654D98C  ldr      x0, [x8]
00654D990  bl       #0x382bfa0 ; 
00654D994  adrp     x8, #0x8f05000
00654D998  ldr      x8, [x8, #0x9b8] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathLoopBorn.<InitAttackLoop>b__7_0()
00654D99C  mov      x1, x19
00654D9A0  mov      x3, xzr
00654D9A4  mov      x20, x0
00654D9A8  ldr      x2, [x8]
00654D9AC  bl       #0x7ade578 ; System.Action$$.ctor
00654D9B0  mov      x0, x19
00654D9B4  mov      x1, x20
00654D9B8  mov      x2, xzr
00654D9BC  bl       #0x6b7f70c ; HotFix.BattleLogic.AIStateController$$AddTaskDoEvent
00654D9C0  ldr      x8, [x19, #0x40]
00654D9C4  cbz      x8, #0x654da80
00654D9C8  ldr      x1, [x8, #0x18]
00654D9CC  mov      x0, x19
00654D9D0  mov      x2, xzr
00654D9D4  bl       #0x6b809a0 ; HotFix.BattleLogic.AIStateController$$AddTaskWait
00654D9D8  adrp     x8, #0x8f05000
00654D9DC  ldr      x8, [x8, #0x9c0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MoveOnStraightDown>()
00654D9E0  mov      x0, x19
00654D9E4  ldr      x1, [x8]
00654D9E8  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654D9EC  adrp     x8, #0x8f05000
00654D9F0  ldr      x8, [x8, #0x9d0] ; GLOBAL System.Func<EntityCharacter>_TypeInfo
00654D9F4  mov      x20, x0
00654D9F8  ldr      x8, [x8]
00654D9FC  mov      x0, x8
00654DA00  bl       #0x382bfa0 ; 
00654DA04  adrp     x8, #0x8f05000
00654DA08  ldr      x8, [x8, #0x9c8] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.SelectEntity_NearOne()
00654DA0C  mov      x1, x19
00654DA10  mov      x3, xzr
00654DA14  mov      x21, x0
00654DA18  ldr      x2, [x8]
00654DA1C  bl       #0x635be3c ; System.Func<object>$$.ctor
00654DA20  ldr      x8, [x19, #0x118]
00654DA24  cbz      x8, #0x654da80
00654DA28  cbz      x20, #0x654da80
00654DA2C  ldr      w9, [x8, #0x20]
00654DA30  ldr      x3, [x8, #0x18]
00654DA34  mov      x0, x20
00654DA38  mov      x1, x21
00654DA3C  cmp      w9, #1
00654DA40  cset     w2, eq
00654DA44  mov      x4, xzr
00654DA48  bl       #0x661f5b8 ; HotFix.BattleLogic.MoveOnStraightDown$$SetData
00654DA4C  mov      x0, x19
00654DA50  mov      x1, x20
00654DA54  mov      x2, xzr
00654DA58  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00654DA5C  ldr      x8, [x22, #0x28]
00654DA60  ldr      x9, [sp, #0x48]
00654DA64  cmp      x8, x9
00654DA68  b.ne     #0x654da84
00654DA6C  ldp      x20, x19, [sp, #0x70]
00654DA70  ldp      x22, x21, [sp, #0x60]
00654DA74  ldr      x30, [sp, #0x50]
00654DA78  add      sp, sp, #0x80
00654DA7C  ret      
00654DA80  bl       #0x382bfb8 ; 
00654DA84  bl       #0x89edb60 ; 

