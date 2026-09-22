; HotFix.BattleLogic.WeaponMultiMod$$get_FireHoldTime
; RVA 0x69D807C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D807C  stp      x30, x21, [sp, #-0x20]!
0069D8080  stp      x20, x19, [sp, #0x10]
0069D8084  adrp     x20, #0x959d000
0069D8088  adrp     x21, #0x8f31000
0069D808C  ldrb     w8, [x20, #0x37e]
0069D8090  ldr      x21, [x21, #0x380] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiMod.get_FireHoldTime()
0069D8094  mov      x19, x0
0069D8098  tbnz     w8, #0, #0x69d80bc
0069D809C  adrp     x0, #0x8f31000
0069D80A0  ldr      x0, [x0, #0x388] ; GLOBAL Method$HotFix.BattleLogic.ModBase<MultiModParams, WeaponMultiModProcessor>.get_Params()
0069D80A4  bl       #0x382bd14 ; 
0069D80A8  adrp     x0, #0x8f31000
0069D80AC  ldr      x0, [x0, #0x380] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiMod.get_FireHoldTime()
0069D80B0  bl       #0x382bd14 ; 
0069D80B4  mov      w8, #1
0069D80B8  strb     w8, [x20, #0x37e]
0069D80BC  ldr      x1, [x21]
0069D80C0  ldrb     w8, [x1, #0x53]
0069D80C4  tbnz     w8, #5, #0x69d80e4
0069D80C8  adrp     x8, #0x8f31000
0069D80CC  ldr      x8, [x8, #0x388] ; GLOBAL Method$HotFix.BattleLogic.ModBase<MultiModParams, WeaponMultiModProcessor>.get_Params()
0069D80D0  ldr      x1, [x8]
0069D80D4  ldrb     w8, [x1, #0x53]
0069D80D8  tbnz     w8, #5, #0x69d80f8
0069D80DC  ldr      x0, [x19, #0x30]
0069D80E0  b        #0x69d8104 ; 
0069D80E4  ldr      x2, [x1, #0x60]
0069D80E8  mov      x0, x19
0069D80EC  ldp      x20, x19, [sp, #0x10]
0069D80F0  ldp      x30, x21, [sp], #0x20
0069D80F4  br       x2
0069D80F8  ldr      x8, [x1, #0x60]
0069D80FC  mov      x0, x19
0069D8100  blr      x8
0069D8104  cbz      x0, #0x69d8118
0069D8108  ldr      x0, [x0, #0x18]
0069D810C  ldp      x20, x19, [sp, #0x10]
0069D8110  ldp      x30, x21, [sp], #0x20
0069D8114  ret      
0069D8118  bl       #0x382bfb8 ; 

