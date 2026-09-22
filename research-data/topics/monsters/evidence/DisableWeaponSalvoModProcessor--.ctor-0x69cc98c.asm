; HotFix.BattleLogic.DisableWeaponSalvoModProcessor$$.ctor
; RVA 0x69CC98C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069CC98C  stp      x30, x21, [sp, #-0x20]!
0069CC990  stp      x20, x19, [sp, #0x10]
0069CC994  adrp     x20, #0x959d000
0069CC998  adrp     x21, #0x8f30000
0069CC99C  ldrb     w8, [x20, #0x2b9]
0069CC9A0  ldr      x21, [x21, #0x860] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModProcessor..ctor()
0069CC9A4  mov      x19, x0
0069CC9A8  tbnz     w8, #0, #0x69cc9cc
0069CC9AC  adrp     x0, #0x8f30000
0069CC9B0  ldr      x0, [x0, #0x860] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModProcessor..ctor()
0069CC9B4  bl       #0x382bd14 ; 
0069CC9B8  adrp     x0, #0x8f30000
0069CC9BC  ldr      x0, [x0, #0x868] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<DisableWeaponSalvoModParams>..ctor()
0069CC9C0  bl       #0x382bd14 ; 
0069CC9C4  mov      w8, #1
0069CC9C8  strb     w8, [x20, #0x2b9]
0069CC9CC  ldr      x1, [x21]
0069CC9D0  ldrb     w8, [x1, #0x53]
0069CC9D4  tbnz     w8, #5, #0x69cc9f4
0069CC9D8  adrp     x8, #0x8f30000
0069CC9DC  ldr      x8, [x8, #0x868] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<DisableWeaponSalvoModParams>..ctor()
0069CC9E0  mov      x0, x19
0069CC9E4  ldp      x20, x19, [sp, #0x10]
0069CC9E8  ldr      x1, [x8]
0069CC9EC  ldp      x30, x21, [sp], #0x20
0069CC9F0  b        #0x58c8790 ; HotFix.BattleLogic.WeaponModProcessorBase<object>$$.ctor
0069CC9F4  ldr      x2, [x1, #0x60]
0069CC9F8  mov      x0, x19
0069CC9FC  ldp      x20, x19, [sp, #0x10]
0069CCA00  ldp      x30, x21, [sp], #0x20
0069CCA04  br       x2

