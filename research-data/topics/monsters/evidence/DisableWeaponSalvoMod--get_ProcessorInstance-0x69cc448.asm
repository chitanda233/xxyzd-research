; HotFix.BattleLogic.DisableWeaponSalvoMod$$get_ProcessorInstance
; RVA 0x69CC448; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069CC448  stp      x30, x21, [sp, #-0x20]!
0069CC44C  stp      x20, x19, [sp, #0x10]
0069CC450  adrp     x20, #0x959d000
0069CC454  adrp     x21, #0x8f30000
0069CC458  ldrb     w8, [x20, #0x2b2]
0069CC45C  ldr      x21, [x21, #0x800] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoMod.get_ProcessorInstance()
0069CC460  mov      x19, x0
0069CC464  tbnz     w8, #0, #0x69cc488
0069CC468  adrp     x0, #0x8f30000
0069CC46C  ldr      x0, [x0, #0x800] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoMod.get_ProcessorInstance()
0069CC470  bl       #0x382bd14 ; 
0069CC474  adrp     x0, #0x8f30000
0069CC478  ldr      x0, [x0, #0x808] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<DisableWeaponSalvoModProcessor>()
0069CC47C  bl       #0x382bd14 ; 
0069CC480  mov      w8, #1
0069CC484  strb     w8, [x20, #0x2b2]
0069CC488  ldr      x1, [x21]
0069CC48C  ldrb     w8, [x1, #0x53]
0069CC490  tbnz     w8, #5, #0x69cc4d0
0069CC494  adrp     x20, #0x9591000
0069CC498  ldrb     w8, [x20, #0xa4b]
0069CC49C  cbnz     w8, #0x69cc4b4
0069CC4A0  adrp     x0, #0x8ee5000
0069CC4A4  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069CC4A8  bl       #0x382bd14 ; 
0069CC4AC  mov      w8, #1
0069CC4B0  strb     w8, [x20, #0xa4b]
0069CC4B4  adrp     x8, #0x8ee5000
0069CC4B8  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext()
0069CC4BC  ldr      x1, [x8]
0069CC4C0  ldrb     w8, [x1, #0x53]
0069CC4C4  tbnz     w8, #5, #0x69cc4e4
0069CC4C8  ldr      x19, [x19, #0x20]
0069CC4CC  b        #0x69cc4f4 ; 
0069CC4D0  ldr      x2, [x1, #0x60]
0069CC4D4  mov      x0, x19
0069CC4D8  ldp      x20, x19, [sp, #0x10]
0069CC4DC  ldp      x30, x21, [sp], #0x20
0069CC4E0  br       x2
0069CC4E4  ldr      x8, [x1, #0x60]
0069CC4E8  mov      x0, x19
0069CC4EC  blr      x8
0069CC4F0  mov      x19, x0
0069CC4F4  cbz      x19, #0x69cc55c
0069CC4F8  adrp     x20, #0x9591000
0069CC4FC  ldrb     w8, [x20, #0xa4c]
0069CC500  cbnz     w8, #0x69cc518
0069CC504  adrp     x0, #0x8ee5000
0069CC508  ldr      x0, [x0, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
0069CC50C  bl       #0x382bd14 ; 
0069CC510  mov      w8, #1
0069CC514  strb     w8, [x20, #0xa4c]
0069CC518  adrp     x8, #0x8ee5000
0069CC51C  ldr      x8, [x8, #0xb30] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Creator()
0069CC520  ldr      x1, [x8]
0069CC524  ldrb     w8, [x1, #0x53]
0069CC528  tbnz     w8, #5, #0x69cc534
0069CC52C  ldr      x0, [x19, #0x210]
0069CC530  b        #0x69cc540 ; 
0069CC534  ldr      x8, [x1, #0x60]
0069CC538  mov      x0, x19
0069CC53C  blr      x8
0069CC540  cbz      x0, #0x69cc55c
0069CC544  adrp     x8, #0x8f30000
0069CC548  ldr      x8, [x8, #0x808] ; GLOBAL Method$HotFix.BattleLogic.WorldElementCreator.CreateWorldElement<DisableWeaponSalvoModProcessor>()
0069CC54C  ldp      x20, x19, [sp, #0x10]
0069CC550  ldr      x1, [x8]
0069CC554  ldp      x30, x21, [sp], #0x20
0069CC558  b        #0x4782e7c ; HotFix.BattleLogic.WorldElementCreator$$CreateWorldElement<object>
0069CC55C  bl       #0x382bfb8 ; 

