; HotFix.BattleLogic.CharacterComponentAI$$.ctor
; RVA 0x6693314; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006693314  stp      x30, x21, [sp, #-0x20]!
006693318  stp      x20, x19, [sp, #0x10]
00669331C  adrp     x20, #0x959a000
006693320  adrp     x21, #0x8f10000
006693324  ldrb     w8, [x20, #0x4a]
006693328  ldr      x21, [x21, #0xa28] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI..ctor()
00669332C  mov      x19, x0
006693330  tbnz     w8, #0, #0x6693348
006693334  adrp     x0, #0x8f10000
006693338  ldr      x0, [x0, #0xa28] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI..ctor()
00669333C  bl       #0x382bd14 ; 
006693340  mov      w8, #1
006693344  strb     w8, [x20, #0x4a]
006693348  ldr      x1, [x21]
00669334C  ldrb     w8, [x1, #0x53]
006693350  tbnz     w8, #5, #0x6693364
006693354  mov      x0, x19
006693358  ldp      x20, x19, [sp, #0x10]
00669335C  ldp      x30, x21, [sp], #0x20
006693360  b        #0x6693378 ; HotFix.BattleLogic.CharacterComponentBase$$.ctor
006693364  ldr      x2, [x1, #0x60]
006693368  mov      x0, x19
00669336C  ldp      x20, x19, [sp, #0x10]
006693370  ldp      x30, x21, [sp], #0x20
006693374  br       x2

