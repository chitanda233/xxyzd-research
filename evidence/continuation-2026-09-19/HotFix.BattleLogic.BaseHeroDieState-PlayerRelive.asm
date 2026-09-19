; HotFix.BattleLogic.BaseHeroDieState$$PlayerRelive
; RVA 0x659C4E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659C4E8  str      x30, [sp, #-0x30]!
00659C4EC  stp      x22, x21, [sp, #0x10]
00659C4F0  stp      x20, x19, [sp, #0x20]
00659C4F4  adrp     x21, #0x9599000
00659C4F8  adrp     x22, #0x8f08000
00659C4FC  ldrb     w8, [x21, #0x312]
00659C500  ldr      x22, [x22, #0xeb8] ; GLOBAL Method$HotFix.BattleLogic.BaseHeroDieState.PlayerRelive() @ 0x923b250
00659C504  mov      w20, w1
00659C508  mov      x19, x0
00659C50C  tbnz     w8, #0, #0x659c530
00659C510  adrp     x0, #0x8f08000
00659C514  ldr      x0, [x0, #0xeb8] ; GLOBAL Method$HotFix.BattleLogic.BaseHeroDieState.PlayerRelive() @ 0x923b250
00659C518  bl       #0x382bd14 ; 
00659C51C  adrp     x0, #0x8f08000
00659C520  ldr      x0, [x0, #0xec0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentDie>() @ 0x9210108
00659C524  bl       #0x382bd14 ; 
00659C528  mov      w8, #1
00659C52C  strb     w8, [x21, #0x312]
00659C530  ldr      x2, [x22]
00659C534  ldrb     w8, [x2, #0x53]
00659C538  tbnz     w8, #5, #0x659c578
00659C53C  adrp     x21, #0x9599000
00659C540  ldrb     w8, [x21, #0x4b1]
00659C544  cbnz     w8, #0x659c55c
00659C548  adrp     x0, #0x8f08000
00659C54C  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C550  bl       #0x382bd14 ; 
00659C554  mov      w8, #1
00659C558  strb     w8, [x21, #0x4b1]
00659C55C  adrp     x22, #0x8f08000
00659C560  ldr      x22, [x22, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C564  ldr      x1, [x22]
00659C568  ldrb     w8, [x1, #0x53]
00659C56C  tbnz     w8, #5, #0x659c594
00659C570  ldr      x0, [x19, #0x10]
00659C574  b        #0x659c5a0 ; 
00659C578  ldr      x3, [x2, #0x60]
00659C57C  mov      x0, x19
00659C580  mov      w1, w20
00659C584  ldp      x20, x19, [sp, #0x20]
00659C588  ldp      x22, x21, [sp, #0x10]
00659C58C  ldr      x30, [sp], #0x30
00659C590  br       x3
00659C594  ldr      x8, [x1, #0x60]
00659C598  mov      x0, x19
00659C59C  blr      x8
00659C5A0  cbz      x0, #0x659c640
00659C5A4  mov      w1, w20
00659C5A8  mov      x2, xzr
00659C5AC  bl       #0x6a226d0 ; HotFix.BattleLogic.BattleWorldContext$$AddReliveCount
00659C5B0  cmp      w20, #3
00659C5B4  b.ne     #0x659c604
00659C5B8  ldrb     w8, [x21, #0x4b1]
00659C5BC  cbnz     w8, #0x659c5d4
00659C5C0  adrp     x0, #0x8f08000
00659C5C4  ldr      x0, [x0, #0xbd0] ; GLOBAL Method$HotFix.BattleLogic.BattleState.get_WorldContext() @ 0x923ea18
00659C5C8  bl       #0x382bd14 ; 
00659C5CC  mov      w8, #1
00659C5D0  strb     w8, [x21, #0x4b1]
00659C5D4  ldr      x1, [x22]
00659C5D8  ldrb     w8, [x1, #0x53]
00659C5DC  tbnz     w8, #5, #0x659c5e8
00659C5E0  ldr      x0, [x19, #0x10]
00659C5E4  b        #0x659c5f4 ; 
00659C5E8  ldr      x8, [x1, #0x60]
00659C5EC  mov      x0, x19
00659C5F0  blr      x8
00659C5F4  cbz      x0, #0x659c640
00659C5F8  ldr      w8, [x0, #0x444]
00659C5FC  add      w8, w8, #1
00659C600  str      w8, [x0, #0x444]
00659C604  ldr      x0, [x19, #0x18]
00659C608  mov      w8, #0x1999
00659C60C  str      x8, [x19, #0x28]
00659C610  cbz      x0, #0x659c640
00659C614  adrp     x8, #0x8f08000
00659C618  ldr      x8, [x8, #0xec0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.GetComponent<HeroComponentDie>() @ 0x9210108
00659C61C  ldr      x1, [x8]
00659C620  bl       #0x422360c ; HotFix.BattleLogic.EntityBase<object>$$GetComponent<object>
00659C624  cbz      x0, #0x659c640
00659C628  ldr      w1, [x19, #0x20]
00659C62C  ldp      x20, x19, [sp, #0x20]
00659C630  ldp      x22, x21, [sp, #0x10]
00659C634  mov      x2, xzr
00659C638  ldr      x30, [sp], #0x30
00659C63C  b        #0x68555a0 ; HotFix.BattleLogic.HeroComponentDie$$ReBorn
00659C640  bl       #0x382bfb8 ; 

