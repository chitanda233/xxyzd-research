; HotFix.BattleLogic.EntityTreasure$$OnRelease
; RVA 0x68D3558; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D3558  stp      x30, x21, [sp, #-0x20]!
0068D355C  stp      x20, x19, [sp, #0x10]
0068D3560  adrp     x20, #0x959c000
0068D3564  adrp     x21, #0x8f28000
0068D3568  ldrb     w8, [x20, #0x777]
0068D356C  ldr      x21, [x21, #0x888] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.OnRelease() @ 0x9264428
0068D3570  mov      x19, x0
0068D3574  tbnz     w8, #0, #0x68d3598
0068D3578  adrp     x0, #0x8f28000
0068D357C  ldr      x0, [x0, #0x890] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.OnRelease() @ 0x9210158
0068D3580  bl       #0x382bd14 ; 
0068D3584  adrp     x0, #0x8f28000
0068D3588  ldr      x0, [x0, #0x888] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.OnRelease() @ 0x9264428
0068D358C  bl       #0x382bd14 ; 
0068D3590  mov      w8, #1
0068D3594  strb     w8, [x20, #0x777]
0068D3598  ldr      x1, [x21]
0068D359C  ldrb     w8, [x1, #0x53]
0068D35A0  tbnz     w8, #5, #0x68d35dc
0068D35A4  adrp     x8, #0x8f28000
0068D35A8  ldr      x8, [x8, #0x890] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.OnRelease() @ 0x9210158
0068D35AC  mov      x0, x19
0068D35B0  ldr      x1, [x8]
0068D35B4  bl       #0x60b2114 ; HotFix.BattleLogic.EntityBase<object>$$OnRelease
0068D35B8  add      x0, x19, #0x628
0068D35BC  mov      x1, xzr
0068D35C0  str      xzr, [x19, #0x628]
0068D35C4  bl       #0x382bcb8 ; 
0068D35C8  strb     wzr, [x19, #0x638]
0068D35CC  str      wzr, [x19, #0x640]
0068D35D0  ldp      x20, x19, [sp, #0x10]
0068D35D4  ldp      x30, x21, [sp], #0x20
0068D35D8  ret      
0068D35DC  ldr      x2, [x1, #0x60]
0068D35E0  mov      x0, x19
0068D35E4  ldp      x20, x19, [sp, #0x10]
0068D35E8  ldp      x30, x21, [sp], #0x20
0068D35EC  br       x2

