; HotFix.BattleLogic.EntityCharacter$$InitKillBulletCounts
; RVA 0x67ED140; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067ED140  stp      x30, x21, [sp, #-0x20]!
0067ED144  stp      x20, x19, [sp, #0x10]
0067ED148  adrp     x20, #0x959b000
0067ED14C  adrp     x21, #0x8f1f000
0067ED150  ldrb     w8, [x20, #0x2e9]
0067ED154  ldr      x21, [x21, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitKillBulletCounts()
0067ED158  mov      x19, x0
0067ED15C  tbnz     w8, #0, #0x67ed18c
0067ED160  adrp     x0, #0x8ee3000
0067ED164  ldr      x0, [x0, #0xfb0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>..ctor()
0067ED168  bl       #0x382bd14 ; 
0067ED16C  adrp     x0, #0x8ee3000
0067ED170  ldr      x0, [x0, #0xfa8] ; GLOBAL System.Collections.Generic.Dictionary<int, int>_TypeInfo
0067ED174  bl       #0x382bd14 ; 
0067ED178  adrp     x0, #0x8f1f000
0067ED17C  ldr      x0, [x0, #0x2d8] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.InitKillBulletCounts()
0067ED180  bl       #0x382bd14 ; 
0067ED184  mov      w8, #1
0067ED188  strb     w8, [x20, #0x2e9]
0067ED18C  ldr      x1, [x21]
0067ED190  ldrb     w8, [x1, #0x53]
0067ED194  tbnz     w8, #5, #0x67ed1d4
0067ED198  adrp     x8, #0x8ee3000
0067ED19C  ldr      x8, [x8, #0xfa8] ; GLOBAL System.Collections.Generic.Dictionary<int, int>_TypeInfo
0067ED1A0  adrp     x20, #0x8ee3000
0067ED1A4  ldr      x0, [x8]
0067ED1A8  ldr      x20, [x20, #0xfb0] ; GLOBAL Method$System.Collections.Generic.Dictionary<int, int>..ctor()
0067ED1AC  bl       #0x382bfa0 ; 
0067ED1B0  ldr      x1, [x20]
0067ED1B4  mov      x20, x0
0067ED1B8  bl       #0x5e2737c ; System.Collections.Generic.Dictionary<int, int>$$.ctor
0067ED1BC  add      x0, x19, #0x2c8
0067ED1C0  str      x20, [x19, #0x2c8]
0067ED1C4  mov      x1, x20
0067ED1C8  ldp      x20, x19, [sp, #0x10]
0067ED1CC  ldp      x30, x21, [sp], #0x20
0067ED1D0  b        #0x382bcb8 ; 
0067ED1D4  ldr      x2, [x1, #0x60]
0067ED1D8  mov      x0, x19
0067ED1DC  ldp      x20, x19, [sp, #0x10]
0067ED1E0  ldp      x30, x21, [sp], #0x20
0067ED1E4  br       x2

