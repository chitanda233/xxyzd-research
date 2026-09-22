; HotFix.BattleLogic.AIMoveOnPathAttackLoopBorn$$InitAttackLoop
; RVA 0x654C51C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654C51C  sub      sp, sp, #0x80
00654C520  str      x30, [sp, #0x50]
00654C524  stp      x22, x21, [sp, #0x60]
00654C528  stp      x20, x19, [sp, #0x70]
00654C52C  mrs      x22, tpidr_el0
00654C530  ldr      x8, [x22, #0x28]
00654C534  adrp     x20, #0x9598000
00654C538  adrp     x21, #0x8f05000
00654C53C  mov      x19, x0
00654C540  str      x8, [sp, #0x48]
00654C544  ldrb     w8, [x20, #0xe47]
00654C548  ldr      x21, [x21, #0x908] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBorn.InitAttackLoop()
00654C54C  tbnz     w8, #0, #0x654c588
00654C550  adrp     x0, #0x8f05000
00654C554  ldr      x0, [x0, #0x908] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBorn.InitAttackLoop()
00654C558  bl       #0x382bd14 ; 
00654C55C  adrp     x0, #0x8f05000
00654C560  ldr      x0, [x0, #0x910] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBorn.OnMovePath()
00654C564  bl       #0x382bd14 ; 
00654C568  adrp     x0, #0x8f05000
00654C56C  ldr      x0, [x0, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveOnPath>()
00654C570  bl       #0x382bd14 ; 
00654C574  adrp     x0, #0x8f05000
00654C578  ldr      x0, [x0, #0x8c8] ; GLOBAL System.Action<FP>_TypeInfo
00654C57C  bl       #0x382bd14 ; 
00654C580  mov      w8, #1
00654C584  strb     w8, [x20, #0xe47]
00654C588  ldr      x1, [x21]
00654C58C  ldrb     w8, [x1, #0x53]
00654C590  tbnz     w8, #5, #0x654c62c
00654C594  ldr      x8, [x19, #0x118]
00654C598  cbz      x8, #0x654c758
00654C59C  ldr      w9, [x8, #0x38]
00654C5A0  cbnz     w9, #0x654c5d0
00654C5A4  ldr      x20, [x19, #0x58]
00654C5A8  mov      x0, x19
00654C5AC  mov      x1, xzr
00654C5B0  bl       #0x6b7ec5c ; HotFix.BattleLogic.AIStateController$$SelectEntity_NearOne
00654C5B4  cbz      x20, #0x654c758
00654C5B8  mov      x1, x0
00654C5BC  mov      x0, x20
00654C5C0  mov      x2, xzr
00654C5C4  bl       #0x67d61b8 ; HotFix.BattleLogic.EntityCharacter$$SetTarget
00654C5C8  ldr      x8, [x19, #0x118]
00654C5CC  cbz      x8, #0x654c758
00654C5D0  ldr      x8, [x8, #0x20]
00654C5D4  ldrb     w9, [x19, #0x128]
00654C5D8  str      x8, [x19, #0x120]
00654C5DC  cbz      w9, #0x654c698
00654C5E0  ldrb     w8, [x19, #0x129]
00654C5E4  cbnz     w8, #0x654c698
00654C5E8  ldr      x20, [x19, #0x58]
00654C5EC  cbz      x20, #0x654c758
00654C5F0  adrp     x21, #0x9598000
00654C5F4  ldrb     w8, [x21, #0xfb7]
00654C5F8  cbnz     w8, #0x654c610
00654C5FC  adrp     x0, #0x8f05000
00654C600  ldr      x0, [x0, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00654C604  bl       #0x382bd14 ; 
00654C608  mov      w8, #1
00654C60C  strb     w8, [x21, #0xfb7]
00654C610  adrp     x8, #0x8f05000
00654C614  ldr      x8, [x8, #0x730] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.get_Transform()
00654C618  ldr      x1, [x8]
00654C61C  ldrb     w8, [x1, #0x53]
00654C620  tbnz     w8, #5, #0x654c63c
00654C624  ldr      x20, [x20, #0x118]
00654C628  b        #0x654c64c ; 
00654C62C  ldr      x8, [x1, #0x60]
00654C630  mov      x0, x19
00654C634  blr      x8
00654C638  b        #0x654c734 ; 
00654C63C  ldr      x8, [x1, #0x60]
00654C640  mov      x0, x20
00654C644  blr      x8
00654C648  mov      x20, x0
00654C64C  ldr      x0, [x19, #0x58]
00654C650  cbz      x0, #0x654c758
00654C654  add      x8, sp, #0x18
00654C658  mov      x1, xzr
00654C65C  bl       #0x67d6328 ; HotFix.BattleLogic.EntityCharacter$$GetLoopMoveRestartPos
00654C660  ldur     q0, [sp, #0x18]
00654C664  ldr      x8, [sp, #0x28]
00654C668  str      q0, [sp, #0x30]
00654C66C  str      x8, [sp, #0x40]
00654C670  cbz      x20, #0x654c758
00654C674  ldr      q0, [sp, #0x30]
00654C678  ldr      x8, [sp, #0x40]
00654C67C  mov      x1, sp
00654C680  mov      w2, #1
00654C684  mov      x0, x20
00654C688  mov      x3, xzr
00654C68C  str      q0, [sp]
00654C690  str      x8, [sp, #0x10]
00654C694  bl       #0x672c418 ; HotFix.BattleLogic.CharacterComponentTransform$$MoveToPosition
00654C698  mov      w8, #1
00654C69C  strh     w8, [x19, #0x128]
00654C6A0  adrp     x8, #0x8f05000
00654C6A4  ldr      x8, [x8, #0x8c0] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MonsterMoveOnPath>()
00654C6A8  mov      x0, x19
00654C6AC  ldr      x1, [x8]
00654C6B0  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654C6B4  ldr      x8, [x19, #0x118]
00654C6B8  cbz      x8, #0x654c758
00654C6BC  mov      x20, x0
00654C6C0  cbz      x0, #0x654c758
00654C6C4  ldr      w8, [x8, #0x10]
00654C6C8  strh     wzr, [x20, #0x74]
00654C6CC  str      w8, [x20, #0x70]
00654C6D0  adrp     x8, #0x8f05000
00654C6D4  ldr      x8, [x8, #0x8c8] ; GLOBAL System.Action<FP>_TypeInfo
00654C6D8  ldr      x0, [x8]
00654C6DC  bl       #0x382bfa0 ; 
00654C6E0  adrp     x8, #0x8f05000
00654C6E4  ldr      x8, [x8, #0x910] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathAttackLoopBorn.OnMovePath()
00654C6E8  mov      x1, x19
00654C6EC  mov      x3, xzr
00654C6F0  mov      x21, x0
00654C6F4  ldr      x2, [x8]
00654C6F8  bl       #0x5f40564 ; System.Action<FP>$$.ctor
00654C6FC  mov      x0, x20
00654C700  str      x21, [x0, #0x88]!
00654C704  mov      x1, x21
00654C708  bl       #0x382bcb8 ; 
00654C70C  ldr      x8, [x19, #0x118]
00654C710  cbz      x8, #0x654c758
00654C714  ldr      w8, [x8, #0x28]
00654C718  mov      x0, x19
00654C71C  mov      x1, x20
00654C720  mov      x2, xzr
00654C724  cmp      w8, #1
00654C728  cset     w8, eq
00654C72C  strb     w8, [x20, #0x90]
00654C730  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00654C734  ldr      x8, [x22, #0x28]
00654C738  ldr      x9, [sp, #0x48]
00654C73C  cmp      x8, x9
00654C740  b.ne     #0x654c75c
00654C744  ldp      x20, x19, [sp, #0x70]
00654C748  ldp      x22, x21, [sp, #0x60]
00654C74C  ldr      x30, [sp, #0x50]
00654C750  add      sp, sp, #0x80
00654C754  ret      
00654C758  bl       #0x382bfb8 ; 
00654C75C  bl       #0x89edb60 ; 

