; HotFix.BattleLogic.GameUtils$$GetLeaveType
; RVA 0x691F1E8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00691F1E8  str      x30, [sp, #-0x30]!
00691F1EC  stp      x22, x21, [sp, #0x10]
00691F1F0  stp      x20, x19, [sp, #0x20]
00691F1F4  adrp     x21, #0x959c000
00691F1F8  adrp     x22, #0x8f2a000
00691F1FC  ldrb     w8, [x21, #0xb9d]
00691F200  ldr      x22, [x22, #0xf18] ; GLOBAL Method$HotFix.BattleLogic.GameUtils.GetLeaveType()
00691F204  mov      w20, w1
00691F208  mov      x19, x0
00691F20C  tbnz     w8, #0, #0x691f224
00691F210  adrp     x0, #0x8f2a000
00691F214  ldr      x0, [x0, #0xf18] ; GLOBAL Method$HotFix.BattleLogic.GameUtils.GetLeaveType()
00691F218  bl       #0x382bd14 ; 
00691F21C  mov      w8, #1
00691F220  strb     w8, [x21, #0xb9d]
00691F224  ldr      x2, [x22]
00691F228  ldrb     w8, [x2, #0x53]
00691F22C  tbnz     w8, #5, #0x691f27c
00691F230  cbz      x19, #0x691f2f8
00691F234  and      w8, w20, #0xfffffffe
00691F238  cmp      w8, #8
00691F23C  b.ne     #0x691f298
00691F240  adrp     x20, #0x959c000
00691F244  ldrb     w8, [x20, #0xbf6]
00691F248  cbnz     w8, #0x691f260
00691F24C  adrp     x0, #0x8f27000
00691F250  ldr      x0, [x0, #0xc88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WaveleaveType()
00691F254  bl       #0x382bd14 ; 
00691F258  mov      w8, #1
00691F25C  strb     w8, [x20, #0xbf6]
00691F260  adrp     x8, #0x8f27000
00691F264  ldr      x8, [x8, #0xc88] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WaveleaveType()
00691F268  ldr      x1, [x8]
00691F26C  ldrb     w8, [x1, #0x53]
00691F270  tbnz     w8, #5, #0x691f2e0
00691F274  ldr      w0, [x19, #0x164]
00691F278  b        #0x691f2d0 ; 
00691F27C  ldr      x3, [x2, #0x60]
00691F280  mov      x0, x19
00691F284  mov      w1, w20
00691F288  ldp      x20, x19, [sp, #0x20]
00691F28C  ldp      x22, x21, [sp, #0x10]
00691F290  ldr      x30, [sp], #0x30
00691F294  br       x3
00691F298  adrp     x20, #0x959c000
00691F29C  ldrb     w8, [x20, #0xbf5]
00691F2A0  cbnz     w8, #0x691f2b8
00691F2A4  adrp     x0, #0x8f27000
00691F2A8  ldr      x0, [x0, #0xc78] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_leaveType()
00691F2AC  bl       #0x382bd14 ; 
00691F2B0  mov      w8, #1
00691F2B4  strb     w8, [x20, #0xbf5]
00691F2B8  adrp     x8, #0x8f27000
00691F2BC  ldr      x8, [x8, #0xc78] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_leaveType()
00691F2C0  ldr      x1, [x8]
00691F2C4  ldrb     w8, [x1, #0x53]
00691F2C8  tbnz     w8, #5, #0x691f2e0
00691F2CC  ldr      w0, [x19, #0x160]
00691F2D0  ldp      x20, x19, [sp, #0x20]
00691F2D4  ldp      x22, x21, [sp, #0x10]
00691F2D8  ldr      x30, [sp], #0x30
00691F2DC  ret      
00691F2E0  ldr      x2, [x1, #0x60]
00691F2E4  mov      x0, x19
00691F2E8  ldp      x20, x19, [sp, #0x20]
00691F2EC  ldp      x22, x21, [sp, #0x10]
00691F2F0  ldr      x30, [sp], #0x30
00691F2F4  br       x2
00691F2F8  bl       #0x382bfb8 ; 

