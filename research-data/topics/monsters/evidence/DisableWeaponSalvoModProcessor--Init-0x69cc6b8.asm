; HotFix.BattleLogic.DisableWeaponSalvoModProcessor$$Init
; RVA 0x69CC6B8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069CC6B8  stp      x30, x21, [sp, #-0x20]!
0069CC6BC  stp      x20, x19, [sp, #0x10]
0069CC6C0  adrp     x20, #0x959d000
0069CC6C4  adrp     x21, #0x8f30000
0069CC6C8  ldrb     w8, [x20, #0x2b5]
0069CC6CC  ldr      x21, [x21, #0x830] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModProcessor.Init()
0069CC6D0  mov      x19, x0
0069CC6D4  tbnz     w8, #0, #0x69cc6f8
0069CC6D8  adrp     x0, #0x8f30000
0069CC6DC  ldr      x0, [x0, #0x830] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModProcessor.Init()
0069CC6E0  bl       #0x382bd14 ; 
0069CC6E4  adrp     x0, #0x8f30000
0069CC6E8  ldr      x0, [x0, #0x838] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<DisableWeaponSalvoModParams>.get_Weapon()
0069CC6EC  bl       #0x382bd14 ; 
0069CC6F0  mov      w8, #1
0069CC6F4  strb     w8, [x20, #0x2b5]
0069CC6F8  ldr      x1, [x21]
0069CC6FC  ldrb     w8, [x1, #0x53]
0069CC700  tbnz     w8, #5, #0x69cc720
0069CC704  adrp     x8, #0x8f30000
0069CC708  ldr      x8, [x8, #0x838] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<DisableWeaponSalvoModParams>.get_Weapon()
0069CC70C  ldr      x1, [x8]
0069CC710  ldrb     w8, [x1, #0x53]
0069CC714  tbnz     w8, #5, #0x69cc734
0069CC718  ldr      x19, [x19, #0x40]
0069CC71C  b        #0x69cc744 ; 
0069CC720  ldr      x2, [x1, #0x60]
0069CC724  mov      x0, x19
0069CC728  ldp      x20, x19, [sp, #0x10]
0069CC72C  ldp      x30, x21, [sp], #0x20
0069CC730  br       x2
0069CC734  ldr      x8, [x1, #0x60]
0069CC738  mov      x0, x19
0069CC73C  blr      x8
0069CC740  mov      x19, x0
0069CC744  cbz      x19, #0x69cc7a8
0069CC748  adrp     x20, #0x959d000
0069CC74C  ldrb     w8, [x20, #0x47d]
0069CC750  cbnz     w8, #0x69cc768
0069CC754  adrp     x0, #0x8f30000
0069CC758  ldr      x0, [x0, #0x840] ; GLOBAL Method$HotFix.BattleLogic.Weapon.set_DisableSalvo()
0069CC75C  bl       #0x382bd14 ; 
0069CC760  mov      w8, #1
0069CC764  strb     w8, [x20, #0x47d]
0069CC768  adrp     x8, #0x8f30000
0069CC76C  ldr      x8, [x8, #0x840] ; GLOBAL Method$HotFix.BattleLogic.Weapon.set_DisableSalvo()
0069CC770  ldr      x2, [x8]
0069CC774  ldrb     w8, [x2, #0x53]
0069CC778  tbnz     w8, #5, #0x69cc790
0069CC77C  mov      w8, #1
0069CC780  strb     w8, [x19, #0x2a]
0069CC784  ldp      x20, x19, [sp, #0x10]
0069CC788  ldp      x30, x21, [sp], #0x20
0069CC78C  ret      
0069CC790  ldr      x3, [x2, #0x60]
0069CC794  mov      x0, x19
0069CC798  ldp      x20, x19, [sp, #0x10]
0069CC79C  mov      w1, #1
0069CC7A0  ldp      x30, x21, [sp], #0x20
0069CC7A4  br       x3
0069CC7A8  bl       #0x382bfb8 ; 

