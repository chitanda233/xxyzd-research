; HotFix.BattleLogic.DisableWeaponSalvoModProcessor$$DeInit
; RVA 0x69CC7AC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069CC7AC  stp      x30, x21, [sp, #-0x20]!
0069CC7B0  stp      x20, x19, [sp, #0x10]
0069CC7B4  adrp     x20, #0x959d000
0069CC7B8  adrp     x21, #0x8f30000
0069CC7BC  ldrb     w8, [x20, #0x2b6]
0069CC7C0  ldr      x21, [x21, #0x848] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModProcessor.DeInit()
0069CC7C4  mov      x19, x0
0069CC7C8  tbnz     w8, #0, #0x69cc7ec
0069CC7CC  adrp     x0, #0x8f30000
0069CC7D0  ldr      x0, [x0, #0x848] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModProcessor.DeInit()
0069CC7D4  bl       #0x382bd14 ; 
0069CC7D8  adrp     x0, #0x8f30000
0069CC7DC  ldr      x0, [x0, #0x838] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<DisableWeaponSalvoModParams>.get_Weapon()
0069CC7E0  bl       #0x382bd14 ; 
0069CC7E4  mov      w8, #1
0069CC7E8  strb     w8, [x20, #0x2b6]
0069CC7EC  ldr      x1, [x21]
0069CC7F0  ldrb     w8, [x1, #0x53]
0069CC7F4  tbnz     w8, #5, #0x69cc814
0069CC7F8  adrp     x8, #0x8f30000
0069CC7FC  ldr      x8, [x8, #0x838] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<DisableWeaponSalvoModParams>.get_Weapon()
0069CC800  ldr      x1, [x8]
0069CC804  ldrb     w8, [x1, #0x53]
0069CC808  tbnz     w8, #5, #0x69cc828
0069CC80C  ldr      x19, [x19, #0x40]
0069CC810  b        #0x69cc838 ; 
0069CC814  ldr      x2, [x1, #0x60]
0069CC818  mov      x0, x19
0069CC81C  ldp      x20, x19, [sp, #0x10]
0069CC820  ldp      x30, x21, [sp], #0x20
0069CC824  br       x2
0069CC828  ldr      x8, [x1, #0x60]
0069CC82C  mov      x0, x19
0069CC830  blr      x8
0069CC834  mov      x19, x0
0069CC838  cbz      x19, #0x69cc898
0069CC83C  adrp     x20, #0x959d000
0069CC840  ldrb     w8, [x20, #0x47d]
0069CC844  cbnz     w8, #0x69cc85c
0069CC848  adrp     x0, #0x8f30000
0069CC84C  ldr      x0, [x0, #0x840] ; GLOBAL Method$HotFix.BattleLogic.Weapon.set_DisableSalvo()
0069CC850  bl       #0x382bd14 ; 
0069CC854  mov      w8, #1
0069CC858  strb     w8, [x20, #0x47d]
0069CC85C  adrp     x8, #0x8f30000
0069CC860  ldr      x8, [x8, #0x840] ; GLOBAL Method$HotFix.BattleLogic.Weapon.set_DisableSalvo()
0069CC864  ldr      x2, [x8]
0069CC868  ldrb     w8, [x2, #0x53]
0069CC86C  tbnz     w8, #5, #0x69cc880
0069CC870  strb     wzr, [x19, #0x2a]
0069CC874  ldp      x20, x19, [sp, #0x10]
0069CC878  ldp      x30, x21, [sp], #0x20
0069CC87C  ret      
0069CC880  ldr      x3, [x2, #0x60]
0069CC884  mov      x0, x19
0069CC888  ldp      x20, x19, [sp, #0x10]
0069CC88C  mov      w1, wzr
0069CC890  ldp      x30, x21, [sp], #0x20
0069CC894  br       x3
0069CC898  bl       #0x382bfb8 ; 

