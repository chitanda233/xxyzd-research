; HotFix.BattleLogic.DisableWeaponSalvoModParams$$set_UpdateOrder
; RVA 0x69CC364; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069CC364  str      x30, [sp, #-0x30]!
0069CC368  stp      x22, x21, [sp, #0x10]
0069CC36C  stp      x20, x19, [sp, #0x20]
0069CC370  adrp     x21, #0x959d000
0069CC374  adrp     x22, #0x8f30000
0069CC378  ldrb     w8, [x21, #0x2b0]
0069CC37C  ldr      x22, [x22, #0x7f0] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModParams.set_UpdateOrder()
0069CC380  mov      w19, w1
0069CC384  mov      x20, x0
0069CC388  tbnz     w8, #0, #0x69cc3a0
0069CC38C  adrp     x0, #0x8f30000
0069CC390  ldr      x0, [x0, #0x7f0] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModParams.set_UpdateOrder()
0069CC394  bl       #0x382bd14 ; 
0069CC398  mov      w8, #1
0069CC39C  strb     w8, [x21, #0x2b0]
0069CC3A0  ldr      x2, [x22]
0069CC3A4  ldrb     w8, [x2, #0x53]
0069CC3A8  tbnz     w8, #5, #0x69cc3c0
0069CC3AC  str      w19, [x20, #0x14]
0069CC3B0  ldp      x20, x19, [sp, #0x20]
0069CC3B4  ldp      x22, x21, [sp, #0x10]
0069CC3B8  ldr      x30, [sp], #0x30
0069CC3BC  ret      
0069CC3C0  ldr      x3, [x2, #0x60]
0069CC3C4  mov      x0, x20
0069CC3C8  mov      w1, w19
0069CC3CC  ldp      x20, x19, [sp, #0x20]
0069CC3D0  ldp      x22, x21, [sp, #0x10]
0069CC3D4  ldr      x30, [sp], #0x30
0069CC3D8  br       x3

