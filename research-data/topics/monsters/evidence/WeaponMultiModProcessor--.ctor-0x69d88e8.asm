; HotFix.BattleLogic.WeaponMultiModProcessor$$.ctor
; RVA 0x69D88E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D88E8  stp      x30, x21, [sp, #-0x20]!
0069D88EC  stp      x20, x19, [sp, #0x10]
0069D88F0  adrp     x20, #0x959d000
0069D88F4  adrp     x21, #0x8f31000
0069D88F8  ldrb     w8, [x20, #0x385]
0069D88FC  ldr      x21, [x21, #0x3d8] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor..ctor()
0069D8900  mov      x19, x0
0069D8904  tbnz     w8, #0, #0x69d8928
0069D8908  adrp     x0, #0x8f31000
0069D890C  ldr      x0, [x0, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<MultiModParams>..ctor()
0069D8910  bl       #0x382bd14 ; 
0069D8914  adrp     x0, #0x8f31000
0069D8918  ldr      x0, [x0, #0x3d8] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiModProcessor..ctor()
0069D891C  bl       #0x382bd14 ; 
0069D8920  mov      w8, #1
0069D8924  strb     w8, [x20, #0x385]
0069D8928  ldr      x1, [x21]
0069D892C  ldrb     w8, [x1, #0x53]
0069D8930  tbnz     w8, #5, #0x69d8950
0069D8934  adrp     x8, #0x8f31000
0069D8938  ldr      x8, [x8, #0x3e0] ; GLOBAL Method$HotFix.BattleLogic.WeaponModProcessorBase<MultiModParams>..ctor()
0069D893C  mov      x0, x19
0069D8940  ldp      x20, x19, [sp, #0x10]
0069D8944  ldr      x1, [x8]
0069D8948  ldp      x30, x21, [sp], #0x20
0069D894C  b        #0x58c8790 ; HotFix.BattleLogic.WeaponModProcessorBase<object>$$.ctor
0069D8950  ldr      x2, [x1, #0x60]
0069D8954  mov      x0, x19
0069D8958  ldp      x20, x19, [sp, #0x10]
0069D895C  ldp      x30, x21, [sp], #0x20
0069D8960  br       x2

