; HotFix.BattleLogic.DropItemTrigger$$Collect
; RVA 0x6669984; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006669984  stp      x30, x21, [sp, #-0x20]!
006669988  stp      x20, x19, [sp, #0x10]
00666998C  adrp     x20, #0x9599000
006669990  adrp     x21, #0x8f0f000
006669994  ldrb     w8, [x20, #0xd99]
006669998  ldr      x21, [x21, #0x448] ; GLOBAL Method$HotFix.BattleLogic.DropItemTrigger.Collect() @ 0x925ff08
00666999C  mov      x19, x0
0066699A0  tbnz     w8, #0, #0x66699b8
0066699A4  adrp     x0, #0x8f0f000
0066699A8  ldr      x0, [x0, #0x448] ; GLOBAL Method$HotFix.BattleLogic.DropItemTrigger.Collect() @ 0x925ff08
0066699AC  bl       #0x382bd14 ; 
0066699B0  mov      w8, #1
0066699B4  strb     w8, [x20, #0xd99]
0066699B8  ldr      x1, [x21]
0066699BC  ldrb     w8, [x1, #0x53]
0066699C0  tbnz     w8, #5, #0x66699d0
0066699C4  ldp      x20, x19, [sp, #0x10]
0066699C8  ldp      x30, x21, [sp], #0x20
0066699CC  ret      
0066699D0  ldr      x2, [x1, #0x60]
0066699D4  mov      x0, x19
0066699D8  ldp      x20, x19, [sp, #0x10]
0066699DC  ldp      x30, x21, [sp], #0x20
0066699E0  br       x2

