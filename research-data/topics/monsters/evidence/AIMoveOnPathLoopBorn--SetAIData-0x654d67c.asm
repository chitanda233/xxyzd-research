; HotFix.BattleLogic.AIMoveOnPathLoopBorn$$SetAIData
; RVA 0x654D67C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00654D67C  str      x30, [sp, #-0x30]!
00654D680  stp      x22, x21, [sp, #0x10]
00654D684  stp      x20, x19, [sp, #0x20]
00654D688  adrp     x21, #0x9598000
00654D68C  adrp     x22, #0x8f05000
00654D690  ldrb     w8, [x21, #0xe55]
00654D694  ldr      x22, [x22, #0x9a0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathLoopBorn.SetAIData()
00654D698  mov      x19, x1
00654D69C  mov      x20, x0
00654D6A0  tbnz     w8, #0, #0x654d6c4
00654D6A4  adrp     x0, #0x8f05000
00654D6A8  ldr      x0, [x0, #0x9a0] ; GLOBAL Method$HotFix.BattleLogic.AIMoveOnPathLoopBorn.SetAIData()
00654D6AC  bl       #0x382bd14 ; 
00654D6B0  adrp     x0, #0x8f05000
00654D6B4  ldr      x0, [x0, #0x988] ; GLOBAL HotFix.BattleLogic.AIMoveOnPathLoopBorn.Data_TypeInfo
00654D6B8  bl       #0x382bd14 ; 
00654D6BC  mov      w8, #1
00654D6C0  strb     w8, [x21, #0xe55]
00654D6C4  ldr      x2, [x22]
00654D6C8  ldrb     w8, [x2, #0x53]
00654D6CC  tbnz     w8, #5, #0x654d734
00654D6D0  cbz      x19, #0x654d750
00654D6D4  adrp     x8, #0x8f05000
00654D6D8  ldr      x8, [x8, #0x988] ; GLOBAL HotFix.BattleLogic.AIMoveOnPathLoopBorn.Data_TypeInfo
00654D6DC  ldr      x9, [x19]
00654D6E0  ldr      x1, [x8]
00654D6E4  ldrb     w10, [x9, #0x130]
00654D6E8  ldrb     w8, [x1, #0x130]
00654D6EC  cmp      w10, w8
00654D6F0  b.lo     #0x654d76c
00654D6F4  ldr      x10, [x9, #0xc8]
00654D6F8  sub      x9, x8, #1
00654D6FC  ldr      x10, [x10, x9, lsl #3]
00654D700  cmp      x10, x1
00654D704  b.ne     #0x654d76c
00654D708  str      x19, [x20, #0x118]
00654D70C  ldr      x10, [x19]
00654D710  ldrb     w11, [x10, #0x130]
00654D714  cmp      w11, w8
00654D718  b.lo     #0x654d76c
00654D71C  ldr      x8, [x10, #0xc8]
00654D720  ldr      x8, [x8, x9, lsl #3]
00654D724  cmp      x8, x1
00654D728  b.ne     #0x654d76c
00654D72C  add      x0, x20, #0x118
00654D730  b        #0x654d758 ; 
00654D734  ldr      x3, [x2, #0x60]
00654D738  mov      x0, x20
00654D73C  mov      x1, x19
00654D740  ldp      x20, x19, [sp, #0x20]
00654D744  ldp      x22, x21, [sp, #0x10]
00654D748  ldr      x30, [sp], #0x30
00654D74C  br       x3
00654D750  add      x0, x20, #0x118
00654D754  str      xzr, [x20, #0x118]
00654D758  mov      x1, x19
00654D75C  ldp      x20, x19, [sp, #0x20]
00654D760  ldp      x22, x21, [sp, #0x10]
00654D764  ldr      x30, [sp], #0x30
00654D768  b        #0x382bcb8 ; 
00654D76C  mov      x0, x19
00654D770  bl       #0x382c354 ; 

