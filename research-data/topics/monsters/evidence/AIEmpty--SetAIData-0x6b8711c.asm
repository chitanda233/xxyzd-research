; HotFix.BattleLogic.AIEmpty$$SetAIData
; RVA 0x6B8711C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B8711C  str      x30, [sp, #-0x30]!
006B87120  stp      x22, x21, [sp, #0x10]
006B87124  stp      x20, x19, [sp, #0x20]
006B87128  adrp     x21, #0x959f000
006B8712C  adrp     x22, #0x8f43000
006B87130  ldrb     w8, [x21, #0xf42]
006B87134  ldr      x22, [x22, #0x5d8] ; GLOBAL Method$HotFix.BattleLogic.AIEmpty.SetAIData()
006B87138  mov      x19, x1
006B8713C  mov      x20, x0
006B87140  tbnz     w8, #0, #0x6b87158
006B87144  adrp     x0, #0x8f43000
006B87148  ldr      x0, [x0, #0x5d8] ; GLOBAL Method$HotFix.BattleLogic.AIEmpty.SetAIData()
006B8714C  bl       #0x382bd14 ; 
006B87150  mov      w8, #1
006B87154  strb     w8, [x21, #0xf42]
006B87158  ldr      x2, [x22]
006B8715C  ldrb     w8, [x2, #0x53]
006B87160  tbnz     w8, #5, #0x6b87174
006B87164  ldp      x20, x19, [sp, #0x20]
006B87168  ldp      x22, x21, [sp, #0x10]
006B8716C  ldr      x30, [sp], #0x30
006B87170  ret      
006B87174  ldr      x3, [x2, #0x60]
006B87178  mov      x0, x20
006B8717C  mov      x1, x19
006B87180  ldp      x20, x19, [sp, #0x20]
006B87184  ldp      x22, x21, [sp, #0x10]
006B87188  ldr      x30, [sp], #0x30
006B8718C  br       x3

