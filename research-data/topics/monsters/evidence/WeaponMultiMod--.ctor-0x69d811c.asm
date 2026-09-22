; HotFix.BattleLogic.WeaponMultiMod$$.ctor
; RVA 0x69D811C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0069D811C  stp      x30, x21, [sp, #-0x20]!
0069D8120  stp      x20, x19, [sp, #0x10]
0069D8124  adrp     x20, #0x959d000
0069D8128  adrp     x21, #0x8f31000
0069D812C  ldrb     w8, [x20, #0x37f]
0069D8130  ldr      x21, [x21, #0x390] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiMod..ctor()
0069D8134  mov      x19, x0
0069D8138  tbnz     w8, #0, #0x69d815c
0069D813C  adrp     x0, #0x8f31000
0069D8140  ldr      x0, [x0, #0x398] ; GLOBAL Method$HotFix.BattleLogic.WeaponModBase<MultiModParams, WeaponMultiModProcessor>..ctor()
0069D8144  bl       #0x382bd14 ; 
0069D8148  adrp     x0, #0x8f31000
0069D814C  ldr      x0, [x0, #0x390] ; GLOBAL Method$HotFix.BattleLogic.WeaponMultiMod..ctor()
0069D8150  bl       #0x382bd14 ; 
0069D8154  mov      w8, #1
0069D8158  strb     w8, [x20, #0x37f]
0069D815C  ldr      x1, [x21]
0069D8160  ldrb     w8, [x1, #0x53]
0069D8164  tbnz     w8, #5, #0x69d8184
0069D8168  adrp     x8, #0x8f31000
0069D816C  ldr      x8, [x8, #0x398] ; GLOBAL Method$HotFix.BattleLogic.WeaponModBase<MultiModParams, WeaponMultiModProcessor>..ctor()
0069D8170  mov      x0, x19
0069D8174  ldp      x20, x19, [sp, #0x10]
0069D8178  ldr      x1, [x8]
0069D817C  ldp      x30, x21, [sp], #0x20
0069D8180  b        #0x58c8684 ; HotFix.BattleLogic.WeaponModBase<object, object>$$.ctor
0069D8184  ldr      x2, [x1, #0x60]
0069D8188  mov      x0, x19
0069D818C  ldp      x20, x19, [sp, #0x10]
0069D8190  ldp      x30, x21, [sp], #0x20
0069D8194  br       x2

