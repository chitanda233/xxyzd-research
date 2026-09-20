; HotFix.BattleLogic.EntityTreasure$$CreateMonster
; RVA 0x68D31F0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D31F0  sub      sp, sp, #0xc0
0068D31F4  stp      x30, x25, [sp, #0x80]
0068D31F8  stp      x24, x23, [sp, #0x90]
0068D31FC  stp      x22, x21, [sp, #0xa0]
0068D3200  stp      x20, x19, [sp, #0xb0]
0068D3204  mrs      x22, tpidr_el0
0068D3208  ldr      x8, [x22, #0x28]
0068D320C  adrp     x20, #0x959c000
0068D3210  adrp     x21, #0x8f28000
0068D3214  mov      x19, x0
0068D3218  str      x8, [sp, #0x78]
0068D321C  ldrb     w8, [x20, #0x774]
0068D3220  ldr      x21, [x21, #0x870] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.CreateMonster() @ 0x9264410
0068D3224  tbnz     w8, #0, #0x68d323c
0068D3228  adrp     x0, #0x8f28000
0068D322C  ldr      x0, [x0, #0x870] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.CreateMonster() @ 0x9264410
0068D3230  bl       #0x382bd14 ; 
0068D3234  mov      w8, #1
0068D3238  strb     w8, [x20, #0x774]
0068D323C  ldr      x1, [x21]
0068D3240  ldrb     w8, [x1, #0x53]
0068D3244  tbnz     w8, #5, #0x68d328c
0068D3248  adrp     x20, #0x959c000
0068D324C  ldrb     w8, [x20, #0x955]
0068D3250  stp      xzr, xzr, [sp, #0x60]
0068D3254  str      xzr, [sp, #0x70]
0068D3258  cbnz     w8, #0x68d3270
0068D325C  adrp     x0, #0x8f28000
0068D3260  ldr      x0, [x0, #0x868] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.GetMonsterId() @ 0x9264418
0068D3264  bl       #0x382bd14 ; 
0068D3268  mov      w8, #1
0068D326C  strb     w8, [x20, #0x955]
0068D3270  adrp     x8, #0x8f28000
0068D3274  ldr      x8, [x8, #0x868] ; GLOBAL Method$HotFix.BattleLogic.EntityTreasure.GetMonsterId() @ 0x9264418
0068D3278  ldr      x1, [x8]
0068D327C  ldrb     w8, [x1, #0x53]
0068D3280  tbnz     w8, #5, #0x68d329c
0068D3284  ldr      w20, [x19, #0x63c]
0068D3288  b        #0x68d32ac ; 
0068D328C  ldr      x8, [x1, #0x60]
0068D3290  mov      x0, x19
0068D3294  blr      x8
0068D3298  b        #0x68d33ec ; 
0068D329C  ldr      x8, [x1, #0x60]
0068D32A0  mov      x0, x19
0068D32A4  blr      x8
0068D32A8  mov      w20, w0
0068D32AC  adrp     x23, #0x9591000
0068D32B0  ldrb     w8, [x23, #0xa4b]
0068D32B4  cbnz     w8, #0x68d32cc
0068D32B8  adrp     x0, #0x8ee5000
0068D32BC  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068D32C0  bl       #0x382bd14 ; 
0068D32C4  mov      w8, #1
0068D32C8  strb     w8, [x23, #0xa4b]
0068D32CC  adrp     x24, #0x8ee5000
0068D32D0  ldr      x24, [x24, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068D32D4  ldr      x1, [x24]
0068D32D8  ldrb     w8, [x1, #0x53]
0068D32DC  tbnz     w8, #5, #0x68d32e8
0068D32E0  ldr      x21, [x19, #0x20]
0068D32E4  b        #0x68d32f8 ; 
0068D32E8  ldr      x8, [x1, #0x60]
0068D32EC  mov      x0, x19
0068D32F0  blr      x8
0068D32F4  mov      x21, x0
0068D32F8  cbz      x21, #0x68d3414
0068D32FC  adrp     x25, #0x9591000
0068D3300  ldrb     w8, [x25, #0xa9c]
0068D3304  cbnz     w8, #0x68d331c
0068D3308  adrp     x0, #0x8ee6000
0068D330C  ldr      x0, [x0, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr() @ 0x923ff20
0068D3310  bl       #0x382bd14 ; 
0068D3314  mov      w8, #1
0068D3318  strb     w8, [x25, #0xa9c]
0068D331C  adrp     x8, #0x8ee6000
0068D3320  ldr      x8, [x8, #0xaf0] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_MapMgr() @ 0x923ff20
0068D3324  ldr      x1, [x8]
0068D3328  ldrb     w8, [x1, #0x53]
0068D332C  tbnz     w8, #5, #0x68d3338
0068D3330  ldr      x0, [x21, #0x240]
0068D3334  b        #0x68d3344 ; 
0068D3338  ldr      x8, [x1, #0x60]
0068D333C  mov      x0, x21
0068D3340  blr      x8
0068D3344  cbz      x0, #0x68d3414
0068D3348  add      x8, sp, #0x40
0068D334C  mov      x1, xzr
0068D3350  bl       #0x6907e1c ; HotFix.BattleLogic.MapManager$$GetRandomTilePosInMap
0068D3354  ldr      q0, [sp, #0x40]
0068D3358  ldr      x8, [sp, #0x50]
0068D335C  ldrb     w9, [x23, #0xa4b]
0068D3360  str      q0, [sp, #0x60]
0068D3364  str      x8, [sp, #0x70]
0068D3368  cbnz     w9, #0x68d3380
0068D336C  adrp     x0, #0x8ee5000
0068D3370  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068D3374  bl       #0x382bd14 ; 
0068D3378  mov      w8, #1
0068D337C  strb     w8, [x23, #0xa4b]
0068D3380  ldr      x1, [x24]
0068D3384  ldrb     w8, [x1, #0x53]
0068D3388  tbnz     w8, #5, #0x68d3394
0068D338C  ldr      x0, [x19, #0x20]
0068D3390  b        #0x68d33a0 ; 
0068D3394  ldr      x8, [x1, #0x60]
0068D3398  mov      x0, x19
0068D339C  blr      x8
0068D33A0  ldr      q0, [sp, #0x60]
0068D33A4  ldr      x8, [sp, #0x70]
0068D33A8  str      q0, [sp, #0x40]
0068D33AC  str      x8, [sp, #0x50]
0068D33B0  cbz      x0, #0x68d3414
0068D33B4  ldr      q0, [sp, #0x40]
0068D33B8  ldr      x8, [sp, #0x50]
0068D33BC  add      x2, sp, #0x20
0068D33C0  mov      w1, w20
0068D33C4  mov      x3, xzr
0068D33C8  mov      x4, xzr
0068D33CC  mov      w5, wzr
0068D33D0  mov      x6, xzr
0068D33D4  mov      w7, wzr
0068D33D8  str      q0, [sp, #0x20]
0068D33DC  str      x8, [sp, #0x30]
0068D33E0  stp      xzr, xzr, [sp, #8]
0068D33E4  str      wzr, [sp]
0068D33E8  bl       #0x6a15ea4 ; HotFix.BattleLogic.BattleWorldContext$$CreateEnemy
0068D33EC  ldr      x8, [x22, #0x28]
0068D33F0  ldr      x9, [sp, #0x78]
0068D33F4  cmp      x8, x9
0068D33F8  b.ne     #0x68d3418
0068D33FC  ldp      x20, x19, [sp, #0xb0]
0068D3400  ldp      x22, x21, [sp, #0xa0]
0068D3404  ldp      x24, x23, [sp, #0x90]
0068D3408  ldp      x30, x25, [sp, #0x80]
0068D340C  add      sp, sp, #0xc0
0068D3410  ret      
0068D3414  bl       #0x382bfb8 ; 
0068D3418  bl       #0x89edb60 ; 

