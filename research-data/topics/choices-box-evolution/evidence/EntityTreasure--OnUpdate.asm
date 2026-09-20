; HotFix.BattleLogic.EntityTreasure$$OnUpdate
; RVA 0x68D34C0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D34C0  str      x30, [sp, #-0x30]!
0068D34C4  stp      x22, x21, [sp, #0x10]
0068D34C8  stp      x20, x19, [sp, #0x20]
0068D34CC  adrp     x21, #0x959c000
0068D34D0  adrp     x22, #0x8f28000
0068D34D4  ldrb     w8, [x21, #0x776]
0068D34D8  ldr      x22, [x22, #0x880] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.OnUpdate() @ 0x9264430
0068D34DC  mov      x20, x1
0068D34E0  mov      x19, x0
0068D34E4  tbnz     w8, #0, #0x68d34fc
0068D34E8  adrp     x0, #0x8f28000
0068D34EC  ldr      x0, [x0, #0x880] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.OnUpdate() @ 0x9264430
0068D34F0  bl       #0x382bd14 ; 
0068D34F4  mov      w8, #1
0068D34F8  strb     w8, [x21, #0x776]
0068D34FC  ldr      x2, [x22]
0068D3500  ldrb     w8, [x2, #0x53]
0068D3504  tbnz     w8, #5, #0x68d353c
0068D3508  ldrb     w8, [x19, #0x638]
0068D350C  cbnz     w8, #0x68d352c
0068D3510  ldr      x8, [x19, #0x630]
0068D3514  sub      x8, x8, x20
0068D3518  cmp      x8, #0
0068D351C  str      x8, [x19, #0x630]
0068D3520  b.gt     #0x68d352c
0068D3524  mov      w8, #1
0068D3528  str      w8, [x19, #0x640]
0068D352C  ldp      x20, x19, [sp, #0x20]
0068D3530  ldp      x22, x21, [sp, #0x10]
0068D3534  ldr      x30, [sp], #0x30
0068D3538  ret      
0068D353C  ldr      x3, [x2, #0x60]
0068D3540  mov      x0, x19
0068D3544  mov      x1, x20
0068D3548  ldp      x20, x19, [sp, #0x20]
0068D354C  ldp      x22, x21, [sp, #0x10]
0068D3550  ldr      x30, [sp], #0x30
0068D3554  br       x3

