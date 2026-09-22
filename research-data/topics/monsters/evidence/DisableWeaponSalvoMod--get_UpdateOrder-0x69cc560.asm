; HotFix.BattleLogic.DisableWeaponSalvoMod$$get_UpdateOrder
; RVA 0x69CC560; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069CC560  stp      x30, x21, [sp, #-0x20]!
0069CC564  stp      x20, x19, [sp, #0x10]
0069CC568  adrp     x20, #0x959d000
0069CC56C  adrp     x21, #0x8f30000
0069CC570  ldrb     w8, [x20, #0x2b3]
0069CC574  ldr      x21, [x21, #0x810] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoMod.get_UpdateOrder()
0069CC578  mov      x19, x0
0069CC57C  tbnz     w8, #0, #0x69cc5a0
0069CC580  adrp     x0, #0x8f30000
0069CC584  ldr      x0, [x0, #0x810] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoMod.get_UpdateOrder()
0069CC588  bl       #0x382bd14 ; 
0069CC58C  adrp     x0, #0x8f30000
0069CC590  ldr      x0, [x0, #0x818] ; GLOBAL Method$HotFix.BattleLogic.ModBase<DisableWeaponSalvoModParams, DisableWeaponSalvoModProcessor>.get_Params()
0069CC594  bl       #0x382bd14 ; 
0069CC598  mov      w8, #1
0069CC59C  strb     w8, [x20, #0x2b3]
0069CC5A0  ldr      x1, [x21]
0069CC5A4  ldrb     w8, [x1, #0x53]
0069CC5A8  tbnz     w8, #5, #0x69cc604
0069CC5AC  adrp     x8, #0x8f30000
0069CC5B0  ldr      x8, [x8, #0x818] ; GLOBAL Method$HotFix.BattleLogic.ModBase<DisableWeaponSalvoModParams, DisableWeaponSalvoModProcessor>.get_Params()
0069CC5B4  ldr      x1, [x8]
0069CC5B8  ldrb     w8, [x1, #0x53]
0069CC5BC  tbnz     w8, #5, #0x69cc618
0069CC5C0  ldr      x19, [x19, #0x30]
0069CC5C4  cbz      x19, #0x69cc62c
0069CC5C8  adrp     x20, #0x959d000
0069CC5CC  ldrb     w8, [x20, #0x47c]
0069CC5D0  cbnz     w8, #0x69cc5e8
0069CC5D4  adrp     x0, #0x8f30000
0069CC5D8  ldr      x0, [x0, #0x7e8] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModParams.get_UpdateOrder()
0069CC5DC  bl       #0x382bd14 ; 
0069CC5E0  mov      w8, #1
0069CC5E4  strb     w8, [x20, #0x47c]
0069CC5E8  adrp     x8, #0x8f30000
0069CC5EC  ldr      x8, [x8, #0x7e8] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModParams.get_UpdateOrder()
0069CC5F0  ldr      x1, [x8]
0069CC5F4  ldrb     w8, [x1, #0x53]
0069CC5F8  tbnz     w8, #5, #0x69cc604
0069CC5FC  ldr      w0, [x19, #0x14]
0069CC600  b        #0x69cc630 ; 
0069CC604  ldr      x2, [x1, #0x60]
0069CC608  mov      x0, x19
0069CC60C  ldp      x20, x19, [sp, #0x10]
0069CC610  ldp      x30, x21, [sp], #0x20
0069CC614  br       x2
0069CC618  ldr      x8, [x1, #0x60]
0069CC61C  mov      x0, x19
0069CC620  blr      x8
0069CC624  mov      x19, x0
0069CC628  cbnz     x19, #0x69cc5c8
0069CC62C  mov      w0, #-0x3e8
0069CC630  ldp      x20, x19, [sp, #0x10]
0069CC634  ldp      x30, x21, [sp], #0x20
0069CC638  ret      

