; HotFix.BattleLogic.EntityCharacter$$InitDmgStats
; RVA 0x67F5444; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067F5444  stp      x30, x21, [sp, #-0x20]!
0067F5448  stp      x20, x19, [sp, #0x10]
0067F544C  adrp     x20, #0x959b000
0067F5450  adrp     x21, #0x8f1f000
0067F5454  ldrb     w8, [x20, #0x2f5]
0067F5458  ldr      x21, [x21, #0x9e8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitDmgStats()
0067F545C  mov      x19, x0
0067F5460  tbnz     w8, #0, #0x67f5490
0067F5464  adrp     x0, #0x8f1f000
0067F5468  ldr      x0, [x0, #0x9f0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, DamageStatsVO>..ctor()
0067F546C  bl       #0x382bd14 ; 
0067F5470  adrp     x0, #0x8f1f000
0067F5474  ldr      x0, [x0, #0x9f8] ; GLOBAL System.Collections.Generic.Dictionary<int, DamageStatsVO>_TypeInfo
0067F5478  bl       #0x382bd14 ; 
0067F547C  adrp     x0, #0x8f1f000
0067F5480  ldr      x0, [x0, #0x9e8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitDmgStats()
0067F5484  bl       #0x382bd14 ; 
0067F5488  mov      w8, #1
0067F548C  strb     w8, [x20, #0x2f5]
0067F5490  ldr      x1, [x21]
0067F5494  ldrb     w8, [x1, #0x53]
0067F5498  tbnz     w8, #5, #0x67f54d8
0067F549C  adrp     x8, #0x8f1f000
0067F54A0  ldr      x8, [x8, #0x9f8] ; GLOBAL System.Collections.Generic.Dictionary<int, DamageStatsVO>_TypeInfo
0067F54A4  adrp     x20, #0x8f1f000
0067F54A8  ldr      x0, [x8]
0067F54AC  ldr      x20, [x20, #0x9f0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, DamageStatsVO>..ctor()
0067F54B0  bl       #0x382bfa0 ; 
0067F54B4  ldr      x1, [x20]
0067F54B8  mov      x20, x0
0067F54BC  bl       #0x5e5ec40 ; System.Collections.Generic.Dictionary<int, object>$$.ctor
0067F54C0  add      x0, x19, #0x2e0
0067F54C4  str      x20, [x19, #0x2e0]
0067F54C8  mov      x1, x20
0067F54CC  ldp      x20, x19, [sp, #0x10]
0067F54D0  ldp      x30, x21, [sp], #0x20
0067F54D4  b        #0x382bcb8 ; 
0067F54D8  ldr      x2, [x1, #0x60]
0067F54DC  mov      x0, x19
0067F54E0  ldp      x20, x19, [sp, #0x10]
0067F54E4  ldp      x30, x21, [sp], #0x20
0067F54E8  br       x2

