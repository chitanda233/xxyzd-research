; HotFix.BattleLogic.BasePunchboardState$$OnUpdate
; RVA 0x659EF98; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659EF98  str      x30, [sp, #-0x30]!
00659EF9C  stp      x22, x21, [sp, #0x10]
00659EFA0  stp      x20, x19, [sp, #0x20]
00659EFA4  adrp     x21, #0x9599000
00659EFA8  adrp     x22, #0x8f09000
00659EFAC  ldrb     w8, [x21, #0x333]
00659EFB0  ldr      x22, [x22, #0x40] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState.OnUpdate() @ 0x923b6c0
00659EFB4  mov      x19, x1
00659EFB8  mov      x20, x0
00659EFBC  tbnz     w8, #0, #0x659efd4
00659EFC0  adrp     x0, #0x8f09000
00659EFC4  ldr      x0, [x0, #0x40] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState.OnUpdate() @ 0x923b6c0
00659EFC8  bl       #0x382bd14 ; 
00659EFCC  mov      w8, #1
00659EFD0  strb     w8, [x21, #0x333]
00659EFD4  ldr      x2, [x22]
00659EFD8  ldrb     w8, [x2, #0x53]
00659EFDC  tbnz     w8, #5, #0x659eff0
00659EFE0  ldp      x20, x19, [sp, #0x20]
00659EFE4  ldp      x22, x21, [sp, #0x10]
00659EFE8  ldr      x30, [sp], #0x30
00659EFEC  ret      
00659EFF0  ldr      x3, [x2, #0x60]
00659EFF4  mov      x0, x20
00659EFF8  mov      x1, x19
00659EFFC  ldp      x20, x19, [sp, #0x20]
00659F000  ldp      x22, x21, [sp, #0x10]
00659F004  ldr      x30, [sp], #0x30
00659F008  br       x3

