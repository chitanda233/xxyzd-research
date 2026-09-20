; HotFix.BattleLogic.EntityMonster$$OnDeath
; RVA 0x68D2100; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D2100  str      x30, [sp, #-0x30]!
0068D2104  stp      x22, x21, [sp, #0x10]
0068D2108  stp      x20, x19, [sp, #0x20]
0068D210C  adrp     x21, #0x959c000
0068D2110  adrp     x22, #0x8f28000
0068D2114  ldrb     w8, [x21, #0x767]
0068D2118  ldr      x22, [x22, #0x808] ; GLOBAL Method$HotFix.BattleLogic.EntityMonster.OnDeath() @ 0x9263d08
0068D211C  mov      x20, x1
0068D2120  mov      x19, x0
0068D2124  tbnz     w8, #0, #0x68d2148
0068D2128  adrp     x0, #0x8f07000
0068D212C  ldr      x0, [x0, #0xfd0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.PushComponent() @ 0x9210160
0068D2130  bl       #0x382bd14 ; 
0068D2134  adrp     x0, #0x8f28000
0068D2138  ldr      x0, [x0, #0x808] ; GLOBAL Method$HotFix.BattleLogic.EntityMonster.OnDeath() @ 0x9263d08
0068D213C  bl       #0x382bd14 ; 
0068D2140  mov      w8, #1
0068D2144  strb     w8, [x21, #0x767]
0068D2148  ldr      x2, [x22]
0068D214C  ldrb     w8, [x2, #0x53]
0068D2150  tbnz     w8, #5, #0x68d21a4
0068D2154  mov      x0, x19
0068D2158  mov      x1, x20
0068D215C  mov      x2, xzr
0068D2160  bl       #0x67dec14 ; HotFix.BattleLogic.EntityCharacter$$OnDeath
0068D2164  adrp     x20, #0x959c000
0068D2168  ldrb     w8, [x20, #0x954]
0068D216C  cbnz     w8, #0x68d2184
0068D2170  adrp     x0, #0x8f28000
0068D2174  ldr      x0, [x0, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.EntityMonster.get_Parent() @ 0x9263d20
0068D2178  bl       #0x382bd14 ; 
0068D217C  mov      w8, #1
0068D2180  strb     w8, [x20, #0x954]
0068D2184  adrp     x21, #0x8f28000
0068D2188  ldr      x21, [x21, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.EntityMonster.get_Parent() @ 0x9263d20
0068D218C  ldr      x1, [x21]
0068D2190  ldrb     w8, [x1, #0x53]
0068D2194  tbnz     w8, #5, #0x68d21c0
0068D2198  ldr      x0, [x19, #0x628]
0068D219C  cbnz     x0, #0x68d21d0
0068D21A0  b        #0x68d21dc ; 
0068D21A4  ldr      x3, [x2, #0x60]
0068D21A8  mov      x0, x19
0068D21AC  mov      x1, x20
0068D21B0  ldp      x20, x19, [sp, #0x20]
0068D21B4  ldp      x22, x21, [sp, #0x10]
0068D21B8  ldr      x30, [sp], #0x30
0068D21BC  br       x3
0068D21C0  ldr      x8, [x1, #0x60]
0068D21C4  mov      x0, x19
0068D21C8  blr      x8
0068D21CC  cbz      x0, #0x68d21dc
0068D21D0  mov      x1, xzr
0068D21D4  bl       #0x67dbe24 ; HotFix.BattleLogic.EntityCharacter$$get_IsDead
0068D21D8  tbz      w0, #0, #0x68d21ec
0068D21DC  ldp      x20, x19, [sp, #0x20]
0068D21E0  ldp      x22, x21, [sp, #0x10]
0068D21E4  ldr      x30, [sp], #0x30
0068D21E8  ret      
0068D21EC  ldrb     w8, [x20, #0x954]
0068D21F0  cbnz     w8, #0x68d2208
0068D21F4  adrp     x0, #0x8f28000
0068D21F8  ldr      x0, [x0, #0x7c0] ; GLOBAL Method$HotFix.BattleLogic.EntityMonster.get_Parent() @ 0x9263d20
0068D21FC  bl       #0x382bd14 ; 
0068D2200  mov      w8, #1
0068D2204  strb     w8, [x20, #0x954]
0068D2208  ldr      x1, [x21]
0068D220C  ldrb     w8, [x1, #0x53]
0068D2210  tbnz     w8, #5, #0x68d221c
0068D2214  ldr      x0, [x19, #0x628]
0068D2218  b        #0x68d2228 ; 
0068D221C  ldr      x8, [x1, #0x60]
0068D2220  mov      x0, x19
0068D2224  blr      x8
0068D2228  cbz      x0, #0x68d224c
0068D222C  adrp     x8, #0x8f07000
0068D2230  ldr      x8, [x8, #0xfd0] ; GLOBAL Method$HotFix.BattleLogic.EntityBase<EntityCharacterData>.PushComponent() @ 0x9210160
0068D2234  ldp      x20, x19, [sp, #0x20]
0068D2238  ldp      x22, x21, [sp, #0x10]
0068D223C  mov      w1, #0xd
0068D2240  ldr      x2, [x8]
0068D2244  ldr      x30, [sp], #0x30
0068D2248  b        #0x60b34ec ; HotFix.BattleLogic.EntityBase<object>$$PushComponent
0068D224C  bl       #0x382bfb8 ; 

