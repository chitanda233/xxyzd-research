; HotFix.BattleLogic.BattleWorldContext$$CreateEnemy
; RVA 0x6A15EA4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A15EA4  stp      x29, x30, [sp, #-0x60]!
006A15EA8  stp      x28, x27, [sp, #0x10]
006A15EAC  stp      x26, x25, [sp, #0x20]
006A15EB0  stp      x24, x23, [sp, #0x30]
006A15EB4  stp      x22, x21, [sp, #0x40]
006A15EB8  stp      x20, x19, [sp, #0x50]
006A15EBC  sub      sp, sp, #0x1b0
006A15EC0  mrs      x27, tpidr_el0
006A15EC4  ldr      x8, [x27, #0x28]
006A15EC8  adrp     x29, #0x959d000
006A15ECC  adrp     x28, #0x8f32000
006A15ED0  mov      w26, w7
006A15ED4  str      x8, [sp, #0x1a8]
006A15ED8  ldrb     w8, [x29, #0x5df]
006A15EDC  ldr      x28, [x28, #0xff0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEnemy()
006A15EE0  mov      x21, x6
006A15EE4  mov      w20, w5
006A15EE8  mov      x22, x4
006A15EEC  mov      x23, x3
006A15EF0  mov      x25, x2
006A15EF4  mov      w24, w1
006A15EF8  mov      x19, x0
006A15EFC  tbnz     w8, #0, #0x6a15f14
006A15F00  adrp     x0, #0x8f32000
006A15F04  ldr      x0, [x0, #0xff0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.CreateEnemy()
006A15F08  bl       #0x382bd14 ; 
006A15F0C  mov      w8, #1
006A15F10  strb     w8, [x29, #0x5df]
006A15F14  ldr      x8, [x28]
006A15F18  ldr      x29, [sp, #0x218]
006A15F1C  ldr      w28, [sp, #0x210]
006A15F20  ldrb     w9, [x8, #0x53]
006A15F24  tbnz     w9, #5, #0x6a15fa8
006A15F28  add      x0, sp, #0xd8
006A15F2C  mov      w2, #0x98
006A15F30  mov      w1, wzr
006A15F34  and      w26, w26, #1
006A15F38  bl       #0x89edb70 ; 
006A15F3C  add      x0, sp, #0x40
006A15F40  mov      w2, #0x98
006A15F44  mov      w1, wzr
006A15F48  bl       #0x89edb70 ; 
006A15F4C  str      w24, [sp, #0x40]
006A15F50  adrp     x24, #0x9598000
006A15F54  ldr      x8, [x25, #0x10]
006A15F58  ldr      q0, [x25]
006A15F5C  ldrb     w9, [x24, #0xfbe]
006A15F60  str      x8, [sp, #0x30]
006A15F64  str      q0, [sp, #0x20]
006A15F68  cbnz     w9, #0x6a15f80
006A15F6C  adrp     x0, #0x8f05000
006A15F70  ldr      x0, [x0, #0xce8] ; GLOBAL Method$HotFix.BattleLogic.EnemyCreateData.set_Position()
006A15F74  bl       #0x382bd14 ; 
006A15F78  mov      w8, #1
006A15F7C  strb     w8, [x24, #0xfbe]
006A15F80  adrp     x8, #0x8f05000
006A15F84  ldr      x8, [x8, #0xce8] ; GLOBAL Method$HotFix.BattleLogic.EnemyCreateData.set_Position()
006A15F88  ldr      x2, [x8]
006A15F8C  ldrb     w8, [x2, #0x53]
006A15F90  tbnz     w8, #5, #0x6a15fec
006A15F94  ldr      q0, [sp, #0x20]
006A15F98  ldr      x8, [sp, #0x30]
006A15F9C  stur     q0, [sp, #0x48]
006A15FA0  str      x8, [sp, #0x58]
006A15FA4  b        #0x6a1600c ; 
006A15FA8  ldr      x9, [x25, #0x10]
006A15FAC  ldr      q0, [x25]
006A15FB0  ldr      x10, [x8, #0x60]
006A15FB4  and      w5, w20, #1
006A15FB8  and      w7, w26, #1
006A15FBC  add      x2, sp, #0x170
006A15FC0  mov      x0, x19
006A15FC4  mov      w1, w24
006A15FC8  mov      x3, x23
006A15FCC  mov      x4, x22
006A15FD0  mov      x6, x21
006A15FD4  str      x9, [sp, #0x180]
006A15FD8  str      q0, [sp, #0x170]
006A15FDC  stp      x29, x8, [sp, #8]
006A15FE0  str      w28, [sp]
006A15FE4  blr      x10
006A15FE8  b        #0x6a16070 ; 
006A15FEC  ldr      q0, [sp, #0x20]
006A15FF0  ldr      x8, [sp, #0x30]
006A15FF4  ldr      x9, [x2, #0x60]
006A15FF8  add      x0, sp, #0x40
006A15FFC  add      x1, sp, #0x190
006A16000  str      q0, [sp, #0x190]
006A16004  str      x8, [sp, #0x1a0]
006A16008  blr      x9
006A1600C  add      x24, sp, #0x40
006A16010  mov      w8, #0xb40000
006A16014  add      x0, x24, #0x78
006A16018  mov      x1, x23
006A1601C  str      x8, [sp, #0x78]
006A16020  str      x23, [sp, #0xb8]
006A16024  bl       #0x382bcb8 ; 
006A16028  add      x0, x24, #0x88
006A1602C  mov      x1, x21
006A16030  str      x22, [sp, #0xa8]
006A16034  str      x21, [sp, #0xc8]
006A16038  bl       #0x382bcb8 ; 
006A1603C  add      x0, sp, #0xd8
006A16040  add      x1, sp, #0x40
006A16044  mov      w2, #0x98
006A16048  strb     w26, [sp, #0xd0]
006A1604C  str      w28, [sp, #0xd4]
006A16050  str      x29, [sp, #0xb0]
006A16054  bl       #0x89edad0 ; 
006A16058  and      w4, w20, #1
006A1605C  add      x1, sp, #0xd8
006A16060  mov      x0, x19
006A16064  mov      x2, xzr
006A16068  mov      x3, xzr
006A1606C  bl       #0x6a11ce8 ; HotFix.BattleLogic.BattleWorldContext$$CreateEnemy
006A16070  ldr      x8, [x27, #0x28]
006A16074  ldr      x9, [sp, #0x1a8]
006A16078  cmp      x8, x9
006A1607C  b.ne     #0x6a160a0
006A16080  add      sp, sp, #0x1b0
006A16084  ldp      x20, x19, [sp, #0x50]
006A16088  ldp      x22, x21, [sp, #0x40]
006A1608C  ldp      x24, x23, [sp, #0x30]
006A16090  ldp      x26, x25, [sp, #0x20]
006A16094  ldp      x28, x27, [sp, #0x10]
006A16098  ldp      x29, x30, [sp], #0x60
006A1609C  ret      
006A160A0  bl       #0x89edb60 ; 

