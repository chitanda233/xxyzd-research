; HotFix.BattleLogic.EntityTreasure$$OnColliderWithHero
; RVA 0x68D341C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D341C  str      x30, [sp, #-0x30]!
0068D3420  stp      x22, x21, [sp, #0x10]
0068D3424  stp      x20, x19, [sp, #0x20]
0068D3428  adrp     x21, #0x959c000
0068D342C  adrp     x22, #0x8f28000
0068D3430  ldrb     w8, [x21, #0x775]
0068D3434  ldr      x22, [x22, #0x878] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.OnColliderWithHero() @ 0x9264420
0068D3438  mov      x20, x1
0068D343C  mov      x19, x0
0068D3440  tbnz     w8, #0, #0x68d3458
0068D3444  adrp     x0, #0x8f28000
0068D3448  ldr      x0, [x0, #0x878] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.OnColliderWithHero() @ 0x9264420
0068D344C  bl       #0x382bd14 ; 
0068D3450  mov      w8, #1
0068D3454  strb     w8, [x21, #0x775]
0068D3458  ldr      x2, [x22]
0068D345C  ldrb     w8, [x2, #0x53]
0068D3460  tbnz     w8, #5, #0x68d3488
0068D3464  ldrb     w8, [x19, #0x638]
0068D3468  cbnz     w8, #0x68d3478
0068D346C  ldr      w8, [x19, #0x640]
0068D3470  cmp      w8, #0
0068D3474  b.le     #0x68d34a4
0068D3478  ldp      x20, x19, [sp, #0x20]
0068D347C  ldp      x22, x21, [sp, #0x10]
0068D3480  ldr      x30, [sp], #0x30
0068D3484  ret      
0068D3488  ldr      x3, [x2, #0x60]
0068D348C  mov      x0, x19
0068D3490  mov      x1, x20
0068D3494  ldp      x20, x19, [sp, #0x20]
0068D3498  ldp      x22, x21, [sp, #0x10]
0068D349C  ldr      x30, [sp], #0x30
0068D34A0  br       x3
0068D34A4  mov      w8, #1
0068D34A8  strb     w8, [x19, #0x638]
0068D34AC  mov      x0, x19
0068D34B0  ldp      x20, x19, [sp, #0x20]
0068D34B4  ldp      x22, x21, [sp, #0x10]
0068D34B8  ldr      x30, [sp], #0x30
0068D34BC  b        #0x68d31f0 ; HotFix.BattleLogic.EntityTreasure$$CreateMonster

