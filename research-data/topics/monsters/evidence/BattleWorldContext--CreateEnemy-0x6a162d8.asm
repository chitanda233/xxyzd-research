; HotFix.BattleLogic.BattleWorldContext$$CreateEnemy
; RVA 0x6A162D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A162D8  sub      sp, sp, #0x1f0
006A162DC  stp      x29, x30, [sp, #0x190]
006A162E0  stp      x28, x27, [sp, #0x1a0]
006A162E4  stp      x26, x25, [sp, #0x1b0]
006A162E8  stp      x24, x23, [sp, #0x1c0]
006A162EC  stp      x22, x21, [sp, #0x1d0]
006A162F0  stp      x20, x19, [sp, #0x1e0]
006A162F4  mrs      x26, tpidr_el0
006A162F8  ldr      x8, [x26, #0x28]
006A162FC  adrp     x27, #0x959d000
006A16300  adrp     x28, #0x8f33000
006A16304  mov      x20, x6
006A16308  str      x8, [sp, #0x188]
006A1630C  ldrb     w8, [x27, #0x5e1]
006A16310  ldr      x28, [x28] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEnemy()
006A16314  mov      x21, x5
006A16318  mov      x22, x4
006A1631C  mov      x23, x3
006A16320  mov      x25, x2
006A16324  mov      w24, w1
006A16328  mov      x19, x0
006A1632C  tbnz     w8, #0, #0x6a16344
006A16330  adrp     x0, #0x8f33000
006A16334  ldr      x0, [x0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEnemy()
006A16338  bl       #0x382bd14 ; 
006A1633C  mov      w8, #1
006A16340  strb     w8, [x27, #0x5e1]
006A16344  ldr      x7, [x28]
006A16348  ldrb     w8, [x7, #0x53]
006A1634C  tbnz     w8, #5, #0x6a163cc
006A16350  add      x0, sp, #0xb8
006A16354  mov      w2, #0x98
006A16358  mov      w1, wzr
006A1635C  bl       #0x89edb70 ; 
006A16360  add      x0, sp, #0x20
006A16364  mov      w2, #0x98
006A16368  mov      w1, wzr
006A1636C  bl       #0x89edb70 ; 
006A16370  str      w24, [sp, #0x20]
006A16374  adrp     x24, #0x9598000
006A16378  ldr      x8, [x25, #0x10]
006A1637C  ldr      q0, [x25]
006A16380  ldrb     w9, [x24, #0xfbe]
006A16384  str      x8, [sp, #0x10]
006A16388  str      q0, [sp]
006A1638C  cbnz     w9, #0x6a163a4
006A16390  adrp     x0, #0x8f05000
006A16394  ldr      x0, [x0, #0xce8] ; GLOBAL Method$HotFix.BattleLogic.EnemyCreateData.set_Position()
006A16398  bl       #0x382bd14 ; 
006A1639C  mov      w8, #1
006A163A0  strb     w8, [x24, #0xfbe]
006A163A4  adrp     x8, #0x8f05000
006A163A8  ldr      x8, [x8, #0xce8] ; GLOBAL Method$HotFix.BattleLogic.EnemyCreateData.set_Position()
006A163AC  ldr      x2, [x8]
006A163B0  ldrb     w8, [x2, #0x53]
006A163B4  tbnz     w8, #5, #0x6a16404
006A163B8  ldr      q0, [sp]
006A163BC  ldr      x8, [sp, #0x10]
006A163C0  stur     q0, [sp, #0x28]
006A163C4  str      x8, [sp, #0x38]
006A163C8  b        #0x6a16424 ; 
006A163CC  ldr      x8, [x25, #0x10]
006A163D0  ldr      q0, [x25]
006A163D4  ldr      x9, [x7, #0x60]
006A163D8  add      x2, sp, #0x150
006A163DC  mov      x0, x19
006A163E0  mov      w1, w24
006A163E4  mov      x3, x23
006A163E8  mov      x4, x22
006A163EC  mov      x5, x21
006A163F0  mov      x6, x20
006A163F4  str      x8, [sp, #0x160]
006A163F8  str      q0, [sp, #0x150]
006A163FC  blr      x9
006A16400  b        #0x6a16468 ; 
006A16404  ldr      q0, [sp]
006A16408  ldr      x8, [sp, #0x10]
006A1640C  ldr      x9, [x2, #0x60]
006A16410  add      x0, sp, #0x20
006A16414  add      x1, sp, #0x170
006A16418  str      q0, [sp, #0x170]
006A1641C  str      x8, [sp, #0x180]
006A16420  blr      x9
006A16424  add      x8, sp, #0x20
006A16428  add      x0, x8, #0x78
006A1642C  mov      x1, x22
006A16430  str      x23, [sp, #0x58]
006A16434  str      x22, [sp, #0x98]
006A16438  bl       #0x382bcb8 ; 
006A1643C  add      x0, sp, #0xb8
006A16440  add      x1, sp, #0x20
006A16444  mov      w2, #0x98
006A16448  stp      x21, x20, [sp, #0x88]
006A1644C  bl       #0x89edad0 ; 
006A16450  add      x1, sp, #0xb8
006A16454  mov      x0, x19
006A16458  mov      x2, xzr
006A1645C  mov      x3, xzr
006A16460  mov      w4, wzr
006A16464  bl       #0x6a11ce8 ; HotFix.BattleLogic.BattleWorldContext$$CreateEnemy
006A16468  ldr      x8, [x26, #0x28]
006A1646C  ldr      x9, [sp, #0x188]
006A16470  cmp      x8, x9
006A16474  b.ne     #0x6a16498
006A16478  ldp      x20, x19, [sp, #0x1e0]
006A1647C  ldp      x22, x21, [sp, #0x1d0]
006A16480  ldp      x24, x23, [sp, #0x1c0]
006A16484  ldp      x26, x25, [sp, #0x1b0]
006A16488  ldp      x28, x27, [sp, #0x1a0]
006A1648C  ldp      x29, x30, [sp, #0x190]
006A16490  add      sp, sp, #0x1f0
006A16494  ret      
006A16498  bl       #0x89edb60 ; 

