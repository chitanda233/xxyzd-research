; HotFix.BattleLogic.BaseDropNpcState$$.ctor
; RVA 0x6598E50; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006598E50  stp      x30, x21, [sp, #-0x20]!
006598E54  stp      x20, x19, [sp, #0x10]
006598E58  adrp     x20, #0x9599000
006598E5C  adrp     x21, #0x8f08000
006598E60  ldrb     w8, [x20, #0x2f6]
006598E64  ldr      x21, [x21, #0xcd0] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState..ctor() @ 0x923b068
006598E68  mov      x19, x0
006598E6C  tbnz     w8, #0, #0x6598e84
006598E70  adrp     x0, #0x8f08000
006598E74  ldr      x0, [x0, #0xcd0] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState..ctor() @ 0x923b068
006598E78  bl       #0x382bd14 ; 
006598E7C  mov      w8, #1
006598E80  strb     w8, [x20, #0x2f6]
006598E84  ldr      x1, [x21]
006598E88  ldrb     w8, [x1, #0x53]
006598E8C  tbnz     w8, #5, #0x6598ea0
006598E90  mov      x0, x19
006598E94  ldp      x20, x19, [sp, #0x10]
006598E98  ldp      x30, x21, [sp], #0x20
006598E9C  b        #0x6597214 ; HotFix.BattleLogic.SingleState$$.ctor
006598EA0  ldr      x2, [x1, #0x60]
006598EA4  mov      x0, x19
006598EA8  ldp      x20, x19, [sp, #0x10]
006598EAC  ldp      x30, x21, [sp], #0x20
006598EB0  br       x2

