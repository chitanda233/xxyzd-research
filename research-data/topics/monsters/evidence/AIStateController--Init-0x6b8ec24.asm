; HotFix.BattleLogic.AIStateController$$Init
; RVA 0x6B8EC24; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B8EC24  stp      x30, x21, [sp, #-0x20]!
006B8EC28  stp      x20, x19, [sp, #0x10]
006B8EC2C  adrp     x20, #0x959f000
006B8EC30  adrp     x21, #0x8f43000
006B8EC34  ldrb     w8, [x20, #0xfbb]
006B8EC38  ldr      x21, [x21, #0xb08] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.Init()
006B8EC3C  mov      x19, x0
006B8EC40  tbnz     w8, #0, #0x6b8ec58
006B8EC44  adrp     x0, #0x8f43000
006B8EC48  ldr      x0, [x0, #0xb08] ; GLOBAL Method$HotFix.BattleLogic.AIStateController.Init()
006B8EC4C  bl       #0x382bd14 ; 
006B8EC50  mov      w8, #1
006B8EC54  strb     w8, [x20, #0xfbb]
006B8EC58  ldr      x1, [x21]
006B8EC5C  ldrb     w8, [x1, #0x53]
006B8EC60  tbnz     w8, #5, #0x6b8eca0
006B8EC64  mov      x0, x19
006B8EC68  bl       #0x6b8ecb4 ; HotFix.BattleLogic.AIStateController$$InitTask
006B8EC6C  mov      w1, #1
006B8EC70  mov      x0, x19
006B8EC74  bl       #0x6b7ecc4 ; HotFix.BattleLogic.AIStateController$$ActiveState
006B8EC78  ldr      x8, [x19]
006B8EC7C  mov      x0, x19
006B8EC80  ldp      x9, x1, [x8, #0x1f8]
006B8EC84  blr      x9
006B8EC88  mov      x0, x19
006B8EC8C  bl       #0x6b8ed18 ; HotFix.BattleLogic.AIStateController$$initLeaveData
006B8EC90  ldr      x8, [x19]
006B8EC94  ldr      x2, [x8, #0x218]
006B8EC98  ldr      x1, [x8, #0x220]
006B8EC9C  b        #0x6b8eca4 ; 
006B8ECA0  ldr      x2, [x1, #0x60]
006B8ECA4  mov      x0, x19
006B8ECA8  ldp      x20, x19, [sp, #0x10]
006B8ECAC  ldp      x30, x21, [sp], #0x20
006B8ECB0  br       x2

