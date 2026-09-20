; HotFix.BattleLogic.DropItemBuff$$Collect
; RVA 0x66610D8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066610D8  stp      x30, x21, [sp, #-0x20]!
0066610DC  stp      x20, x19, [sp, #0x10]
0066610E0  adrp     x20, #0x9599000
0066610E4  adrp     x21, #0x8f0f000
0066610E8  ldrb     w8, [x20, #0xd3a]
0066610EC  ldr      x21, [x21, #0x60] ; GLOBAL Method$HotFix.BattleLogic.DropItemBuff.Collect() @ 0x925fb68
0066610F0  mov      x19, x0
0066610F4  tbnz     w8, #0, #0x666110c
0066610F8  adrp     x0, #0x8f0f000
0066610FC  ldr      x0, [x0, #0x60] ; GLOBAL Method$HotFix.BattleLogic.DropItemBuff.Collect() @ 0x925fb68
006661100  bl       #0x382bd14 ; 
006661104  mov      w8, #1
006661108  strb     w8, [x20, #0xd3a]
00666110C  ldr      x1, [x21]
006661110  ldrb     w8, [x1, #0x53]
006661114  tbnz     w8, #5, #0x6661124
006661118  ldp      x20, x19, [sp, #0x10]
00666111C  ldp      x30, x21, [sp], #0x20
006661120  ret      
006661124  ldr      x2, [x1, #0x60]
006661128  mov      x0, x19
00666112C  ldp      x20, x19, [sp, #0x10]
006661130  ldp      x30, x21, [sp], #0x20
006661134  br       x2

