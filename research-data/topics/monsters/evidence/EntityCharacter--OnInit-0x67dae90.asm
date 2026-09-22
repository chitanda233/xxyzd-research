; HotFix.BattleLogic.EntityCharacter$$OnInit
; RVA 0x67DAE90; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0067DAE90  stp      x30, x21, [sp, #-0x20]!
0067DAE94  stp      x20, x19, [sp, #0x10]
0067DAE98  adrp     x20, #0x959b000
0067DAE9C  adrp     x21, #0x8f1e000
0067DAEA0  ldrb     w8, [x20, #0x1e5]
0067DAEA4  ldr      x21, [x21, #0x948] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.OnInit()
0067DAEA8  mov      x19, x0
0067DAEAC  tbnz     w8, #0, #0x67daec4
0067DAEB0  adrp     x0, #0x8f1e000
0067DAEB4  ldr      x0, [x0, #0x948] ; GLOBAL Method$HotFix.BattleLogic.EntityCharacter.OnInit()
0067DAEB8  bl       #0x382bd14 ; 
0067DAEBC  mov      w8, #1
0067DAEC0  strb     w8, [x20, #0x1e5]
0067DAEC4  ldr      x1, [x21]
0067DAEC8  ldrb     w8, [x1, #0x53]
0067DAECC  tbnz     w8, #5, #0x67daedc
0067DAED0  ldp      x20, x19, [sp, #0x10]
0067DAED4  ldp      x30, x21, [sp], #0x20
0067DAED8  ret      
0067DAEDC  ldr      x2, [x1, #0x60]
0067DAEE0  mov      x0, x19
0067DAEE4  ldp      x20, x19, [sp, #0x10]
0067DAEE8  ldp      x30, x21, [sp], #0x20
0067DAEEC  br       x2

