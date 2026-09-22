; HotFix.BattleLogic.DisableWeaponSalvoModParams$$.ctor
; RVA 0x69CC3DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069CC3DC  stp      x30, x21, [sp, #-0x20]!
0069CC3E0  stp      x20, x19, [sp, #0x10]
0069CC3E4  adrp     x20, #0x959d000
0069CC3E8  adrp     x21, #0x8f30000
0069CC3EC  ldrb     w8, [x20, #0x2b1]
0069CC3F0  ldr      x21, [x21, #0x7f8] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModParams..ctor()
0069CC3F4  mov      x19, x0
0069CC3F8  tbnz     w8, #0, #0x69cc410
0069CC3FC  adrp     x0, #0x8f30000
0069CC400  ldr      x0, [x0, #0x7f8] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModParams..ctor()
0069CC404  bl       #0x382bd14 ; 
0069CC408  mov      w8, #1
0069CC40C  strb     w8, [x20, #0x2b1]
0069CC410  ldr      x1, [x21]
0069CC414  ldrb     w8, [x1, #0x53]
0069CC418  tbnz     w8, #5, #0x69cc434
0069CC41C  mov      w8, #-0x3e8
0069CC420  str      w8, [x19, #0x14]
0069CC424  mov      x0, x19
0069CC428  ldp      x20, x19, [sp, #0x10]
0069CC42C  ldp      x30, x21, [sp], #0x20
0069CC430  b        #0x69b710c ; HotFix.BattleLogic.ModParams$$.ctor
0069CC434  ldr      x2, [x1, #0x60]
0069CC438  mov      x0, x19
0069CC43C  ldp      x20, x19, [sp, #0x10]
0069CC440  ldp      x30, x21, [sp], #0x20
0069CC444  br       x2

