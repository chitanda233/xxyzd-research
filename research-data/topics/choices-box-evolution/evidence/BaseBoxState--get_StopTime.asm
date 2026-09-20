; HotFix.BattleLogic.BaseBoxState$$get_StopTime
; RVA 0x6597278; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006597278  stp      x30, x21, [sp, #-0x20]!
00659727C  stp      x20, x19, [sp, #0x10]
006597280  adrp     x20, #0x9599000
006597284  adrp     x21, #0x8f08000
006597288  ldrb     w8, [x20, #0x2e2]
00659728C  ldr      x21, [x21, #0xbf8] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState.get_StopTime() @ 0x923afb8
006597290  mov      x19, x0
006597294  tbnz     w8, #0, #0x65972ac
006597298  adrp     x0, #0x8f08000
00659729C  ldr      x0, [x0, #0xbf8] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState.get_StopTime() @ 0x923afb8
0065972A0  bl       #0x382bd14 ; 
0065972A4  mov      w8, #1
0065972A8  strb     w8, [x20, #0x2e2]
0065972AC  ldr      x1, [x21]
0065972B0  ldrb     w8, [x1, #0x53]
0065972B4  tbnz     w8, #5, #0x65972c8
0065972B8  ldp      x20, x19, [sp, #0x10]
0065972BC  mov      w0, #1
0065972C0  ldp      x30, x21, [sp], #0x20
0065972C4  ret      
0065972C8  ldr      x2, [x1, #0x60]
0065972CC  mov      x0, x19
0065972D0  ldp      x20, x19, [sp, #0x10]
0065972D4  ldp      x30, x21, [sp], #0x20
0065972D8  br       x2

