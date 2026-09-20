; HotFix.BattleLogic.RefreshPunchboardState$$get_StateId
; RVA 0x65BE04C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065BE04C  stp      x30, x21, [sp, #-0x20]!
0065BE050  stp      x20, x19, [sp, #0x10]
0065BE054  adrp     x20, #0x9599000
0065BE058  adrp     x21, #0x8f0a000
0065BE05C  ldrb     w8, [x20, #0x4f6]
0065BE060  ldr      x21, [x21, #0x1b0] ; GLOBAL Method$HotFix.BattleLogic.RefreshPunchboardState.get_StateId() @ 0x929e768
0065BE064  mov      x19, x0
0065BE068  tbnz     w8, #0, #0x65be080
0065BE06C  adrp     x0, #0x8f0a000
0065BE070  ldr      x0, [x0, #0x1b0] ; GLOBAL Method$HotFix.BattleLogic.RefreshPunchboardState.get_StateId() @ 0x929e768
0065BE074  bl       #0x382bd14 ; 
0065BE078  mov      w8, #1
0065BE07C  strb     w8, [x20, #0x4f6]
0065BE080  ldr      x1, [x21]
0065BE084  ldrb     w8, [x1, #0x53]
0065BE088  tbnz     w8, #5, #0x65be09c
0065BE08C  ldp      x20, x19, [sp, #0x10]
0065BE090  mov      w0, #6
0065BE094  ldp      x30, x21, [sp], #0x20
0065BE098  ret      
0065BE09C  ldr      x2, [x1, #0x60]
0065BE0A0  mov      x0, x19
0065BE0A4  ldp      x20, x19, [sp, #0x10]
0065BE0A8  ldp      x30, x21, [sp], #0x20
0065BE0AC  br       x2

