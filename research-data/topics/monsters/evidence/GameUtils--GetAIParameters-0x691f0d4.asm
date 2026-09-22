; HotFix.BattleLogic.GameUtils$$GetAIParameters
; RVA 0x691F0D4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00691F0D4  str      x30, [sp, #-0x30]!
00691F0D8  stp      x22, x21, [sp, #0x10]
00691F0DC  stp      x20, x19, [sp, #0x20]
00691F0E0  adrp     x21, #0x959c000
00691F0E4  adrp     x22, #0x8f2a000
00691F0E8  ldrb     w8, [x21, #0xb9c]
00691F0EC  ldr      x22, [x22, #0xf10] ; GLOBAL Method$HotFix.BattleLogic.GameUtils.GetAIParameters()
00691F0F0  mov      w20, w1
00691F0F4  mov      x19, x0
00691F0F8  tbnz     w8, #0, #0x691f110
00691F0FC  adrp     x0, #0x8f2a000
00691F100  ldr      x0, [x0, #0xf10] ; GLOBAL Method$HotFix.BattleLogic.GameUtils.GetAIParameters()
00691F104  bl       #0x382bd14 ; 
00691F108  mov      w8, #1
00691F10C  strb     w8, [x21, #0xb9c]
00691F110  ldr      x2, [x22]
00691F114  ldrb     w8, [x2, #0x53]
00691F118  tbnz     w8, #5, #0x691f168
00691F11C  cbz      x19, #0x691f1e4
00691F120  and      w8, w20, #0xfffffffe
00691F124  cmp      w8, #8
00691F128  b.ne     #0x691f184
00691F12C  adrp     x20, #0x959c000
00691F130  ldrb     w8, [x20, #0xbf4]
00691F134  cbnz     w8, #0x691f14c
00691F138  adrp     x0, #0x8f27000
00691F13C  ldr      x0, [x0, #0xbd8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WaveAIParameters()
00691F140  bl       #0x382bd14 ; 
00691F144  mov      w8, #1
00691F148  strb     w8, [x20, #0xbf4]
00691F14C  adrp     x8, #0x8f27000
00691F150  ldr      x8, [x8, #0xbd8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WaveAIParameters()
00691F154  ldr      x1, [x8]
00691F158  ldrb     w8, [x1, #0x53]
00691F15C  tbnz     w8, #5, #0x691f1cc
00691F160  ldr      x0, [x19, #0x108]
00691F164  b        #0x691f1bc ; 
00691F168  ldr      x3, [x2, #0x60]
00691F16C  mov      x0, x19
00691F170  mov      w1, w20
00691F174  ldp      x20, x19, [sp, #0x20]
00691F178  ldp      x22, x21, [sp, #0x10]
00691F17C  ldr      x30, [sp], #0x30
00691F180  br       x3
00691F184  adrp     x20, #0x959c000
00691F188  ldrb     w8, [x20, #0xbf3]
00691F18C  cbnz     w8, #0x691f1a4
00691F190  adrp     x0, #0x8f27000
00691F194  ldr      x0, [x0, #0xbb8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_AIParameters()
00691F198  bl       #0x382bd14 ; 
00691F19C  mov      w8, #1
00691F1A0  strb     w8, [x20, #0xbf3]
00691F1A4  adrp     x8, #0x8f27000
00691F1A8  ldr      x8, [x8, #0xbb8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_AIParameters()
00691F1AC  ldr      x1, [x8]
00691F1B0  ldrb     w8, [x1, #0x53]
00691F1B4  tbnz     w8, #5, #0x691f1cc
00691F1B8  ldr      x0, [x19, #0xf8]
00691F1BC  ldp      x20, x19, [sp, #0x20]
00691F1C0  ldp      x22, x21, [sp, #0x10]
00691F1C4  ldr      x30, [sp], #0x30
00691F1C8  ret      
00691F1CC  ldr      x2, [x1, #0x60]
00691F1D0  mov      x0, x19
00691F1D4  ldp      x20, x19, [sp, #0x20]
00691F1D8  ldp      x22, x21, [sp, #0x10]
00691F1DC  ldr      x30, [sp], #0x30
00691F1E0  br       x2
00691F1E4  bl       #0x382bfb8 ; 

