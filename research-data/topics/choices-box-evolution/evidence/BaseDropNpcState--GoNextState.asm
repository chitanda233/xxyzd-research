; HotFix.BattleLogic.BaseDropNpcState$$GoNextState
; RVA 0x6598C38; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006598C38  stp      x30, x21, [sp, #-0x20]!
006598C3C  stp      x20, x19, [sp, #0x10]
006598C40  adrp     x20, #0x9599000
006598C44  adrp     x21, #0x8f08000
006598C48  ldrb     w8, [x20, #0x2f2]
006598C4C  ldr      x21, [x21, #0xcb8] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.GoNextState() @ 0x923b070
006598C50  mov      x19, x0
006598C54  tbnz     w8, #0, #0x6598c6c
006598C58  adrp     x0, #0x8f08000
006598C5C  ldr      x0, [x0, #0xcb8] ; GLOBAL Method$HotFix.BattleLogic.BaseDropNpcState.GoNextState() @ 0x923b070
006598C60  bl       #0x382bd14 ; 
006598C64  mov      w8, #1
006598C68  strb     w8, [x20, #0x2f2]
006598C6C  ldr      x1, [x21]
006598C70  ldrb     w8, [x1, #0x53]
006598C74  tbnz     w8, #5, #0x6598c84
006598C78  ldp      x20, x19, [sp, #0x10]
006598C7C  ldp      x30, x21, [sp], #0x20
006598C80  ret      
006598C84  ldr      x2, [x1, #0x60]
006598C88  mov      x0, x19
006598C8C  ldp      x20, x19, [sp, #0x10]
006598C90  ldp      x30, x21, [sp], #0x20
006598C94  br       x2

