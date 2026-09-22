; HotFix.BattleLogic.AIMoveReboundWall$$InitAttackLoop
; RVA 0x654E414; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654E414  sub      sp, sp, #0x80
00654E418  str      x30, [sp, #0x50]
00654E41C  stp      x22, x21, [sp, #0x60]
00654E420  stp      x20, x19, [sp, #0x70]
00654E424  mrs      x21, tpidr_el0
00654E428  ldr      x8, [x21, #0x28]
00654E42C  adrp     x20, #0x9598000
00654E430  adrp     x22, #0x8f05000
00654E434  mov      x19, x0
00654E438  str      x8, [sp, #0x48]
00654E43C  ldrb     w8, [x20, #0xe64]
00654E440  ldr      x22, [x22, #0xa58] ; GLOBAL Method$HotFix.BattleLogic.AIMoveReboundWall.InitAttackLoop()
00654E444  tbnz     w8, #0, #0x654e474
00654E448  adrp     x0, #0x8f05000
00654E44C  ldr      x0, [x0, #0xa58] ; GLOBAL Method$HotFix.BattleLogic.AIMoveReboundWall.InitAttackLoop()
00654E450  bl       #0x382bd14 ; 
00654E454  adrp     x0, #0x8f05000
00654E458  ldr      x0, [x0, #0xa60] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MoveOnStraightForward>()
00654E45C  bl       #0x382bd14 ; 
00654E460  adrp     x0, #0x8ee6000
00654E464  ldr      x0, [x0, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
00654E468  bl       #0x382bd14 ; 
00654E46C  mov      w8, #1
00654E470  strb     w8, [x20, #0xe64]
00654E474  ldr      x1, [x22]
00654E478  ldrb     w8, [x1, #0x53]
00654E47C  tbnz     w8, #5, #0x654e4dc
00654E480  adrp     x20, #0x8f05000
00654E484  ldr      x20, [x20, #0xa60] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.GetEntityTask<MoveOnStraightForward>()
00654E488  mov      x0, x19
00654E48C  mov      x1, xzr
00654E490  bl       #0x6b92a68 ; HotFix.BattleLogic.AIStateController$$InitAttackLoop
00654E494  strh     wzr, [x19, #0x188]
00654E498  ldr      x1, [x20]
00654E49C  mov      x0, x19
00654E4A0  bl       #0x44b39e0 ; HotFix.BattleLogic.AIStateController$$GetEntityTask<object>
00654E4A4  mov      x1, x0
00654E4A8  add      x0, x19, #0x180
00654E4AC  str      x1, [x19, #0x180]
00654E4B0  bl       #0x382bcb8 ; 
00654E4B4  ldr      x0, [x19, #0x58]
00654E4B8  cbz      x0, #0x654e574
00654E4BC  adrp     x8, #0x8ee6000
00654E4C0  ldr      x8, [x8, #0xd8] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.get_Data()
00654E4C4  ldr      x20, [x19, #0x180]
00654E4C8  ldr      x1, [x8]
00654E4CC  ldrb     w8, [x1, #0x53]
00654E4D0  tbnz     w8, #5, #0x654e4ec
00654E4D4  ldr      x0, [x0, #0x38]
00654E4D8  b        #0x654e4f4 ; 
00654E4DC  ldr      x8, [x1, #0x60]
00654E4E0  mov      x0, x19
00654E4E4  blr      x8
00654E4E8  b        #0x654e550 ; 
00654E4EC  ldr      x8, [x1, #0x60]
00654E4F0  blr      x8
00654E4F4  cbz      x0, #0x654e574
00654E4F8  mov      x1, xzr
00654E4FC  bl       #0x6b28bd4 ; HotFix.EntityData$$get_XTransform
00654E500  add      x8, sp, #0x18
00654E504  mov      x1, xzr
00654E508  bl       #0x6b29da0 ; HotFix.XTransform$$get_Forward
00654E50C  ldur     q0, [sp, #0x18]
00654E510  ldr      x8, [sp, #0x28]
00654E514  str      q0, [sp, #0x30]
00654E518  str      x8, [sp, #0x40]
00654E51C  cbz      x20, #0x654e574
00654E520  ldr      q0, [sp, #0x30]
00654E524  ldr      x8, [sp, #0x40]
00654E528  mov      x1, sp
00654E52C  mov      x0, x20
00654E530  mov      x2, xzr
00654E534  str      q0, [sp]
00654E538  str      x8, [sp, #0x10]
00654E53C  bl       #0x661fddc ; HotFix.BattleLogic.MoveOnStraightForward$$SetData
00654E540  ldr      x1, [x19, #0x180]
00654E544  mov      x0, x19
00654E548  mov      x2, xzr
00654E54C  bl       #0x6b7f604 ; HotFix.BattleLogic.AIStateController$$AddTask
00654E550  ldr      x8, [x21, #0x28]
00654E554  ldr      x9, [sp, #0x48]
00654E558  cmp      x8, x9
00654E55C  b.ne     #0x654e578
00654E560  ldp      x20, x19, [sp, #0x70]
00654E564  ldp      x22, x21, [sp, #0x60]
00654E568  ldr      x30, [sp, #0x50]
00654E56C  add      sp, sp, #0x80
00654E570  ret      
00654E574  bl       #0x382bfb8 ; 
00654E578  bl       #0x89edb60 ; 

