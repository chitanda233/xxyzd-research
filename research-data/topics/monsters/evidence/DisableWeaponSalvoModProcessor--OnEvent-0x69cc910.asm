; HotFix.BattleLogic.DisableWeaponSalvoModProcessor$$OnEvent
; RVA 0x69CC910; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069CC910  stp      x30, x23, [sp, #-0x30]!
0069CC914  stp      x22, x21, [sp, #0x10]
0069CC918  stp      x20, x19, [sp, #0x20]
0069CC91C  adrp     x22, #0x959d000
0069CC920  adrp     x23, #0x8f30000
0069CC924  ldrb     w8, [x22, #0x2b8]
0069CC928  ldr      x23, [x23, #0x858] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModProcessor.OnEvent()
0069CC92C  mov      x19, x2
0069CC930  mov      w20, w1
0069CC934  mov      x21, x0
0069CC938  tbnz     w8, #0, #0x69cc950
0069CC93C  adrp     x0, #0x8f30000
0069CC940  ldr      x0, [x0, #0x858] ; GLOBAL Method$HotFix.BattleLogic.DisableWeaponSalvoModProcessor.OnEvent()
0069CC944  bl       #0x382bd14 ; 
0069CC948  mov      w8, #1
0069CC94C  strb     w8, [x22, #0x2b8]
0069CC950  ldr      x3, [x23]
0069CC954  ldrb     w8, [x3, #0x53]
0069CC958  tbnz     w8, #5, #0x69cc96c
0069CC95C  ldp      x20, x19, [sp, #0x20]
0069CC960  ldp      x22, x21, [sp, #0x10]
0069CC964  ldp      x30, x23, [sp], #0x30
0069CC968  ret      
0069CC96C  ldr      x4, [x3, #0x60]
0069CC970  mov      x0, x21
0069CC974  mov      w1, w20
0069CC978  mov      x2, x19
0069CC97C  ldp      x20, x19, [sp, #0x20]
0069CC980  ldp      x22, x21, [sp, #0x10]
0069CC984  ldp      x30, x23, [sp], #0x30
0069CC988  br       x4

