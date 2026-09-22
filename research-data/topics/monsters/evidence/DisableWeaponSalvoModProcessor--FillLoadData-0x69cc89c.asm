; HotFix.BattleLogic.DisableWeaponSalvoModProcessor$$FillLoadData
; RVA 0x69CC89C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069CC89C  str      x30, [sp, #-0x30]!
0069CC8A0  stp      x22, x21, [sp, #0x10]
0069CC8A4  stp      x20, x19, [sp, #0x20]
0069CC8A8  adrp     x21, #0x959d000
0069CC8AC  adrp     x22, #0x8f30000
0069CC8B0  ldrb     w8, [x21, #0x2b7]
0069CC8B4  ldr      x22, [x22, #0x850] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModProcessor.FillLoadData()
0069CC8B8  mov      x19, x1
0069CC8BC  mov      x20, x0
0069CC8C0  tbnz     w8, #0, #0x69cc8d8
0069CC8C4  adrp     x0, #0x8f30000
0069CC8C8  ldr      x0, [x0, #0x850] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModProcessor.FillLoadData()
0069CC8CC  bl       #0x382bd14 ; 
0069CC8D0  mov      w8, #1
0069CC8D4  strb     w8, [x21, #0x2b7]
0069CC8D8  ldr      x2, [x22]
0069CC8DC  ldrb     w8, [x2, #0x53]
0069CC8E0  tbnz     w8, #5, #0x69cc8f4
0069CC8E4  ldp      x20, x19, [sp, #0x20]
0069CC8E8  ldp      x22, x21, [sp, #0x10]
0069CC8EC  ldr      x30, [sp], #0x30
0069CC8F0  ret      
0069CC8F4  ldr      x3, [x2, #0x60]
0069CC8F8  mov      x0, x20
0069CC8FC  mov      x1, x19
0069CC900  ldp      x20, x19, [sp, #0x20]
0069CC904  ldp      x22, x21, [sp, #0x10]
0069CC908  ldr      x30, [sp], #0x30
0069CC90C  br       x3

