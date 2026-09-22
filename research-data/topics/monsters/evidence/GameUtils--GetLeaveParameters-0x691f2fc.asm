; HotFix.BattleLogic.GameUtils$$GetLeaveParameters
; RVA 0x691F2FC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00691F2FC  str      x30, [sp, #-0x30]!
00691F300  stp      x22, x21, [sp, #0x10]
00691F304  stp      x20, x19, [sp, #0x20]
00691F308  adrp     x21, #0x959c000
00691F30C  adrp     x22, #0x8f2a000
00691F310  ldrb     w8, [x21, #0xb9e]
00691F314  ldr      x22, [x22, #0xf20] ; GLOBAL Method$HotFix.BattleLogic.GameUtils.GetLeaveParameters()
00691F318  mov      w20, w1
00691F31C  mov      x19, x0
00691F320  tbnz     w8, #0, #0x691f338
00691F324  adrp     x0, #0x8f2a000
00691F328  ldr      x0, [x0, #0xf20] ; GLOBAL Method$HotFix.BattleLogic.GameUtils.GetLeaveParameters()
00691F32C  bl       #0x382bd14 ; 
00691F330  mov      w8, #1
00691F334  strb     w8, [x21, #0xb9e]
00691F338  ldr      x2, [x22]
00691F33C  ldrb     w8, [x2, #0x53]
00691F340  tbnz     w8, #5, #0x691f390
00691F344  cbz      x19, #0x691f40c
00691F348  and      w8, w20, #0xfffffffe
00691F34C  cmp      w8, #8
00691F350  b.ne     #0x691f3ac
00691F354  adrp     x20, #0x959c000
00691F358  ldrb     w8, [x20, #0xbf8]
00691F35C  cbnz     w8, #0x691f374
00691F360  adrp     x0, #0x8f27000
00691F364  ldr      x0, [x0, #0xca8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WaveleaveParameters()
00691F368  bl       #0x382bd14 ; 
00691F36C  mov      w8, #1
00691F370  strb     w8, [x20, #0xbf8]
00691F374  adrp     x8, #0x8f27000
00691F378  ldr      x8, [x8, #0xca8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WaveleaveParameters()
00691F37C  ldr      x1, [x8]
00691F380  ldrb     w8, [x1, #0x53]
00691F384  tbnz     w8, #5, #0x691f3f4
00691F388  ldr      x0, [x19, #0x170]
00691F38C  b        #0x691f3e4 ; 
00691F390  ldr      x3, [x2, #0x60]
00691F394  mov      x0, x19
00691F398  mov      w1, w20
00691F39C  ldp      x20, x19, [sp, #0x20]
00691F3A0  ldp      x22, x21, [sp, #0x10]
00691F3A4  ldr      x30, [sp], #0x30
00691F3A8  br       x3
00691F3AC  adrp     x20, #0x959c000
00691F3B0  ldrb     w8, [x20, #0xbf7]
00691F3B4  cbnz     w8, #0x691f3cc
00691F3B8  adrp     x0, #0x8f27000
00691F3BC  ldr      x0, [x0, #0xc98] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_leaveParameters()
00691F3C0  bl       #0x382bd14 ; 
00691F3C4  mov      w8, #1
00691F3C8  strb     w8, [x20, #0xbf7]
00691F3CC  adrp     x8, #0x8f27000
00691F3D0  ldr      x8, [x8, #0xc98] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_leaveParameters()
00691F3D4  ldr      x1, [x8]
00691F3D8  ldrb     w8, [x1, #0x53]
00691F3DC  tbnz     w8, #5, #0x691f3f4
00691F3E0  ldr      x0, [x19, #0x168]
00691F3E4  ldp      x20, x19, [sp, #0x20]
00691F3E8  ldp      x22, x21, [sp, #0x10]
00691F3EC  ldr      x30, [sp], #0x30
00691F3F0  ret      
00691F3F4  ldr      x2, [x1, #0x60]
00691F3F8  mov      x0, x19
00691F3FC  ldp      x20, x19, [sp, #0x20]
00691F400  ldp      x22, x21, [sp, #0x10]
00691F404  ldr      x30, [sp], #0x30
00691F408  br       x2
00691F40C  bl       #0x382bfb8 ; 

