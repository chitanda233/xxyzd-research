; HotFix.BattleLogic.BattleWorldContext$$CreateEnemy
; RVA 0x6A160A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A160A4  stp      x29, x30, [sp, #-0x60]!
006A160A8  stp      x28, x27, [sp, #0x10]
006A160AC  stp      x26, x25, [sp, #0x20]
006A160B0  stp      x24, x23, [sp, #0x30]
006A160B4  stp      x22, x21, [sp, #0x40]
006A160B8  stp      x20, x19, [sp, #0x50]
006A160BC  sub      sp, sp, #0x1e0
006A160C0  mrs      x27, tpidr_el0
006A160C4  ldr      x8, [x27, #0x28]
006A160C8  adrp     x29, #0x959d000
006A160CC  adrp     x28, #0x8f32000
006A160D0  mov      x21, x7
006A160D4  str      x8, [sp, #0x1d8]
006A160D8  ldrb     w8, [x29, #0x5e0]
006A160DC  ldr      x28, [x28, #0xff8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEnemy()
006A160E0  mov      w20, w6
006A160E4  mov      x22, x5
006A160E8  mov      x23, x4
006A160EC  mov      x24, x3
006A160F0  mov      x26, x2
006A160F4  mov      w25, w1
006A160F8  mov      x19, x0
006A160FC  tbnz     w8, #0, #0x6a16114
006A16100  adrp     x0, #0x8f32000
006A16104  ldr      x0, [x0, #0xff8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEnemy()
006A16108  bl       #0x382bd14 ; 
006A1610C  mov      w8, #1
006A16110  strb     w8, [x29, #0x5e0]
006A16114  ldr      x9, [x28]
006A16118  ldrb     w8, [sp, #0x240]
006A1611C  ldr      x28, [sp, #0x250]
006A16120  ldr      w29, [sp, #0x248]
006A16124  ldrb     w10, [x9, #0x53]
006A16128  tbnz     w10, #5, #0x6a161b0
006A1612C  and      w8, w8, #1
006A16130  add      x0, sp, #0xe8
006A16134  mov      w2, #0x98
006A16138  mov      w1, wzr
006A1613C  str      w8, [sp, #0x2c]
006A16140  bl       #0x89edb70 ; 
006A16144  add      x0, sp, #0x50
006A16148  mov      w2, #0x98
006A1614C  mov      w1, wzr
006A16150  bl       #0x89edb70 ; 
006A16154  str      w25, [sp, #0x50]
006A16158  adrp     x25, #0x9598000
006A1615C  ldr      x8, [x26, #0x10]
006A16160  ldr      q0, [x26]
006A16164  ldrb     w9, [x25, #0xfbe]
006A16168  str      x8, [sp, #0x40]
006A1616C  str      q0, [sp, #0x30]
006A16170  cbnz     w9, #0x6a16188
006A16174  adrp     x0, #0x8f05000
006A16178  ldr      x0, [x0, #0xce8] ; GLOBAL Method$HotFix.BattleLogic.EnemyCreateData.set_Position()
006A1617C  bl       #0x382bd14 ; 
006A16180  mov      w8, #1
006A16184  strb     w8, [x25, #0xfbe]
006A16188  adrp     x8, #0x8f05000
006A1618C  ldr      x8, [x8, #0xce8] ; GLOBAL Method$HotFix.BattleLogic.EnemyCreateData.set_Position()
006A16190  ldr      x2, [x8]
006A16194  ldrb     w8, [x2, #0x53]
006A16198  tbnz     w8, #5, #0x6a1620c
006A1619C  ldr      q0, [sp, #0x30]
006A161A0  ldr      x8, [sp, #0x40]
006A161A4  stur     q0, [sp, #0x58]
006A161A8  str      x8, [sp, #0x68]
006A161AC  b        #0x6a1622c ; 
006A161B0  ldr      x10, [x26, #0x10]
006A161B4  ldr      q0, [x26]
006A161B8  ldr      x11, [x9, #0x60]
006A161BC  and      w8, w8, #1
006A161C0  str      x10, [sp, #0x1b0]
006A161C4  str      q0, [sp, #0x1a0]
006A161C8  ldr      x10, [x24, #0x10]
006A161CC  ldr      q0, [x24]
006A161D0  and      w6, w20, #1
006A161D4  add      x2, sp, #0x1a0
006A161D8  add      x3, sp, #0x180
006A161DC  mov      x0, x19
006A161E0  mov      w1, w25
006A161E4  mov      x4, x23
006A161E8  mov      x5, x22
006A161EC  mov      x7, x21
006A161F0  str      x10, [sp, #0x190]
006A161F4  str      q0, [sp, #0x180]
006A161F8  stp      x28, x9, [sp, #0x10]
006A161FC  str      w29, [sp, #8]
006A16200  strb     w8, [sp]
006A16204  blr      x11
006A16208  b        #0x6a162a4 ; 
006A1620C  ldr      q0, [sp, #0x30]
006A16210  ldr      x8, [sp, #0x40]
006A16214  ldr      x9, [x2, #0x60]
006A16218  add      x0, sp, #0x50
006A1621C  add      x1, sp, #0x1c0
006A16220  str      q0, [sp, #0x1c0]
006A16224  str      x8, [sp, #0x1d0]
006A16228  blr      x9
006A1622C  add      x25, sp, #0x50
006A16230  mov      w8, #0xb40000
006A16234  add      x0, x25, #0x78
006A16238  mov      x1, x23
006A1623C  str      x8, [sp, #0x88]
006A16240  str      x23, [sp, #0xc8]
006A16244  bl       #0x382bcb8 ; 
006A16248  str      x22, [sp, #0xb8]
006A1624C  ldr      q0, [x24]
006A16250  ldr      x8, [x24, #0x10]
006A16254  add      x0, x25, #0x88
006A16258  mov      x1, x21
006A1625C  str      q0, [sp, #0x70]
006A16260  str      x8, [sp, #0x80]
006A16264  str      x21, [sp, #0xd8]
006A16268  bl       #0x382bcb8 ; 
006A1626C  ldr      w8, [sp, #0x2c]
006A16270  add      x0, sp, #0xe8
006A16274  add      x1, sp, #0x50
006A16278  mov      w2, #0x98
006A1627C  strb     w8, [sp, #0xe0]
006A16280  str      w29, [sp, #0xe4]
006A16284  str      x28, [sp, #0xc0]
006A16288  bl       #0x89edad0 ; 
006A1628C  and      w4, w20, #1
006A16290  add      x1, sp, #0xe8
006A16294  mov      x0, x19
006A16298  mov      x2, xzr
006A1629C  mov      x3, xzr
006A162A0  bl       #0x6a11ce8 ; HotFix.BattleLogic.BattleWorldContext$$CreateEnemy
006A162A4  ldr      x8, [x27, #0x28]
006A162A8  ldr      x9, [sp, #0x1d8]
006A162AC  cmp      x8, x9
006A162B0  b.ne     #0x6a162d4
006A162B4  add      sp, sp, #0x1e0
006A162B8  ldp      x20, x19, [sp, #0x50]
006A162BC  ldp      x22, x21, [sp, #0x40]
006A162C0  ldp      x24, x23, [sp, #0x30]
006A162C4  ldp      x26, x25, [sp, #0x20]
006A162C8  ldp      x28, x27, [sp, #0x10]
006A162CC  ldp      x29, x30, [sp], #0x60
006A162D0  ret      
006A162D4  bl       #0x89edb60 ; 

