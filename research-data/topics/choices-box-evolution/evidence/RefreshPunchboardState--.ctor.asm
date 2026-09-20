; HotFix.BattleLogic.RefreshPunchboardState$$.ctor
; RVA 0x65BE0B0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BE0B0  stp      x30, x21, [sp, #-0x20]!
0065BE0B4  stp      x20, x19, [sp, #0x10]
0065BE0B8  adrp     x20, #0x9599000
0065BE0BC  adrp     x21, #0x8f0a000
0065BE0C0  ldrb     w8, [x20, #0x4f7]
0065BE0C4  ldr      x21, [x21, #0x1b8] ; GLOBAL Method$HotFix.BattleLogic.RefreshPunchboardState..ctor() @ 0x929e760
0065BE0C8  mov      x19, x0
0065BE0CC  tbnz     w8, #0, #0x65be0e4
0065BE0D0  adrp     x0, #0x8f0a000
0065BE0D4  ldr      x0, [x0, #0x1b8] ; GLOBAL Method$HotFix.BattleLogic.RefreshPunchboardState..ctor() @ 0x929e760
0065BE0D8  bl       #0x382bd14 ; 
0065BE0DC  mov      w8, #1
0065BE0E0  strb     w8, [x20, #0x4f7]
0065BE0E4  ldr      x1, [x21]
0065BE0E8  ldrb     w8, [x1, #0x53]
0065BE0EC  tbnz     w8, #5, #0x65be100
0065BE0F0  mov      x0, x19
0065BE0F4  ldp      x20, x19, [sp, #0x10]
0065BE0F8  ldp      x30, x21, [sp], #0x20
0065BE0FC  b        #0x65be114 ; HotFix.BattleLogic.RefreshStateBase$$.ctor
0065BE100  ldr      x2, [x1, #0x60]
0065BE104  mov      x0, x19
0065BE108  ldp      x20, x19, [sp, #0x10]
0065BE10C  ldp      x30, x21, [sp], #0x20
0065BE110  br       x2

