; HotFix.BattleLogic.AIPunchboard$$OnDeInit
; RVA 0x6B8A304; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006B8A304  stp      x30, x21, [sp, #-0x20]!
006B8A308  stp      x20, x19, [sp, #0x10]
006B8A30C  adrp     x20, #0x959f000
006B8A310  adrp     x21, #0x8f43000
006B8A314  ldrb     w8, [x20, #0xf7b]
006B8A318  ldr      x21, [x21, #0x858] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.OnDeInit() @ 0x9232400
006B8A31C  mov      x19, x0
006B8A320  tbnz     w8, #0, #0x6b8a338
006B8A324  adrp     x0, #0x8f43000
006B8A328  ldr      x0, [x0, #0x858] ; GLOBAL Method$HotFix.BattleLogic.AIPunchboard.OnDeInit() @ 0x9232400
006B8A32C  bl       #0x382bd14 ; 
006B8A330  mov      w8, #1
006B8A334  strb     w8, [x20, #0xf7b]
006B8A338  ldr      x1, [x21]
006B8A33C  ldrb     w8, [x1, #0x53]
006B8A340  tbnz     w8, #5, #0x6b8a3a8
006B8A344  mov      x0, x19
006B8A348  bl       #0x6b89b54 ; HotFix.BattleLogic.AIStateController$$OnDeInit
006B8A34C  mov      w8, #0x100
006B8A350  add      x0, x19, #0x120
006B8A354  mov      x1, xzr
006B8A358  str      xzr, [x19, #0x130]
006B8A35C  strh     w8, [x19, #0x148]
006B8A360  str      xzr, [x19, #0x120]
006B8A364  bl       #0x382bcb8 ; 
006B8A368  ldr      x0, [x19, #0x58]
006B8A36C  cbz      x0, #0x6b8a3bc
006B8A370  mov      x1, xzr
006B8A374  mov      x2, xzr
006B8A378  bl       #0x67f63a4 ; HotFix.BattleLogic.EntityCharacter$$SetPickupProgress
006B8A37C  ldr      x1, [x19, #0x128]
006B8A380  cmp      x1, #1
006B8A384  b.lt     #0x6b8a39c
006B8A388  ldr      x0, [x19, #0x58]
006B8A38C  cbz      x0, #0x6b8a3bc
006B8A390  mov      x2, xzr
006B8A394  bl       #0x67f5dd8 ; HotFix.BattleLogic.EntityCharacter$$RemoveEffectFromBody
006B8A398  str      xzr, [x19, #0x128]
006B8A39C  ldp      x20, x19, [sp, #0x10]
006B8A3A0  ldp      x30, x21, [sp], #0x20
006B8A3A4  ret      
006B8A3A8  ldr      x2, [x1, #0x60]
006B8A3AC  mov      x0, x19
006B8A3B0  ldp      x20, x19, [sp, #0x10]
006B8A3B4  ldp      x30, x21, [sp], #0x20
006B8A3B8  br       x2
006B8A3BC  bl       #0x382bfb8 ; 

