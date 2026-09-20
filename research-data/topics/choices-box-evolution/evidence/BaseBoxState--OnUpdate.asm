; HotFix.BattleLogic.BaseBoxState$$OnUpdate
; RVA 0x65972DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065972DC  str      x30, [sp, #-0x30]!
0065972E0  stp      x22, x21, [sp, #0x10]
0065972E4  stp      x20, x19, [sp, #0x20]
0065972E8  adrp     x21, #0x9599000
0065972EC  adrp     x22, #0x8f08000
0065972F0  ldrb     w8, [x21, #0x2e3]
0065972F4  ldr      x22, [x22, #0xc00] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState.OnUpdate() @ 0x923afa8
0065972F8  mov      x19, x1
0065972FC  mov      x20, x0
006597300  tbnz     w8, #0, #0x6597318
006597304  adrp     x0, #0x8f08000
006597308  ldr      x0, [x0, #0xc00] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState.OnUpdate() @ 0x923afa8
00659730C  bl       #0x382bd14 ; 
006597310  mov      w8, #1
006597314  strb     w8, [x21, #0x2e3]
006597318  ldr      x2, [x22]
00659731C  ldrb     w8, [x2, #0x53]
006597320  tbnz     w8, #5, #0x6597334
006597324  ldp      x20, x19, [sp, #0x20]
006597328  ldp      x22, x21, [sp, #0x10]
00659732C  ldr      x30, [sp], #0x30
006597330  ret      
006597334  ldr      x3, [x2, #0x60]
006597338  mov      x0, x20
00659733C  mov      x1, x19
006597340  ldp      x20, x19, [sp, #0x20]
006597344  ldp      x22, x21, [sp, #0x10]
006597348  ldr      x30, [sp], #0x30
00659734C  br       x3

