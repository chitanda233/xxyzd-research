; HotFix.BattleLogic.DisableWeaponSalvoMod$$.ctor
; RVA 0x69CC63C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069CC63C  stp      x30, x21, [sp, #-0x20]!
0069CC640  stp      x20, x19, [sp, #0x10]
0069CC644  adrp     x20, #0x959d000
0069CC648  adrp     x21, #0x8f30000
0069CC64C  ldrb     w8, [x20, #0x2b4]
0069CC650  ldr      x21, [x21, #0x820] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoMod..ctor()
0069CC654  mov      x19, x0
0069CC658  tbnz     w8, #0, #0x69cc67c
0069CC65C  adrp     x0, #0x8f30000
0069CC660  ldr      x0, [x0, #0x820] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoMod..ctor()
0069CC664  bl       #0x382bd14 ; 
0069CC668  adrp     x0, #0x8f30000
0069CC66C  ldr      x0, [x0, #0x828] ; GLOBAL Method$HotFix.BattleLogic.WeaponModBase<DisableWeaponSalvoModParams, DisableWeaponSalvoModProcessor>..ctor()
0069CC670  bl       #0x382bd14 ; 
0069CC674  mov      w8, #1
0069CC678  strb     w8, [x20, #0x2b4]
0069CC67C  ldr      x1, [x21]
0069CC680  ldrb     w8, [x1, #0x53]
0069CC684  tbnz     w8, #5, #0x69cc6a4
0069CC688  adrp     x8, #0x8f30000
0069CC68C  ldr      x8, [x8, #0x828] ; GLOBAL Method$HotFix.BattleLogic.WeaponModBase<DisableWeaponSalvoModParams, DisableWeaponSalvoModProcessor>..ctor()
0069CC690  mov      x0, x19
0069CC694  ldp      x20, x19, [sp, #0x10]
0069CC698  ldr      x1, [x8]
0069CC69C  ldp      x30, x21, [sp], #0x20
0069CC6A0  b        #0x58c8684 ; HotFix.BattleLogic.WeaponModBase<object, object>$$.ctor
0069CC6A4  ldr      x2, [x1, #0x60]
0069CC6A8  mov      x0, x19
0069CC6AC  ldp      x20, x19, [sp, #0x10]
0069CC6B0  ldp      x30, x21, [sp], #0x20
0069CC6B4  br       x2

