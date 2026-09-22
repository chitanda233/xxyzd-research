; HotFix.BattleLogic.DisableWeaponSalvoModParams$$get_UpdateOrder
; RVA 0x69CC300; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069CC300  stp      x30, x21, [sp, #-0x20]!
0069CC304  stp      x20, x19, [sp, #0x10]
0069CC308  adrp     x20, #0x959d000
0069CC30C  adrp     x21, #0x8f30000
0069CC310  ldrb     w8, [x20, #0x2af]
0069CC314  ldr      x21, [x21, #0x7e8] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModParams.get_UpdateOrder()
0069CC318  mov      x19, x0
0069CC31C  tbnz     w8, #0, #0x69cc334
0069CC320  adrp     x0, #0x8f30000
0069CC324  ldr      x0, [x0, #0x7e8] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModParams.get_UpdateOrder()
0069CC328  bl       #0x382bd14 ; 
0069CC32C  mov      w8, #1
0069CC330  strb     w8, [x20, #0x2af]
0069CC334  ldr      x1, [x21]
0069CC338  ldrb     w8, [x1, #0x53]
0069CC33C  tbnz     w8, #5, #0x69cc350
0069CC340  ldr      w0, [x19, #0x14]
0069CC344  ldp      x20, x19, [sp, #0x10]
0069CC348  ldp      x30, x21, [sp], #0x20
0069CC34C  ret      
0069CC350  ldr      x2, [x1, #0x60]
0069CC354  mov      x0, x19
0069CC358  ldp      x20, x19, [sp, #0x10]
0069CC35C  ldp      x30, x21, [sp], #0x20
0069CC360  br       x2

