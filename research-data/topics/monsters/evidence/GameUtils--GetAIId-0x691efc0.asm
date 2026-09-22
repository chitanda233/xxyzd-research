; HotFix.BattleLogic.GameUtils$$GetAIId
; RVA 0x691EFC0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00691EFC0  str      x30, [sp, #-0x30]!
00691EFC4  stp      x22, x21, [sp, #0x10]
00691EFC8  stp      x20, x19, [sp, #0x20]
00691EFCC  adrp     x21, #0x959c000
00691EFD0  adrp     x22, #0x8f2a000
00691EFD4  ldrb     w8, [x21, #0xb9b]
00691EFD8  ldr      x22, [x22, #0xf08] ; GLOBAL Method$HotFix.BattleLogic.GameUtils.GetAIId()
00691EFDC  mov      w20, w1
00691EFE0  mov      x19, x0
00691EFE4  tbnz     w8, #0, #0x691effc
00691EFE8  adrp     x0, #0x8f2a000
00691EFEC  ldr      x0, [x0, #0xf08] ; GLOBAL Method$HotFix.BattleLogic.GameUtils.GetAIId()
00691EFF0  bl       #0x382bd14 ; 
00691EFF4  mov      w8, #1
00691EFF8  strb     w8, [x21, #0xb9b]
00691EFFC  ldr      x2, [x22]
00691F000  ldrb     w8, [x2, #0x53]
00691F004  tbnz     w8, #5, #0x691f054
00691F008  cbz      x19, #0x691f0d0
00691F00C  and      w8, w20, #0xfffffffe
00691F010  cmp      w8, #8
00691F014  b.ne     #0x691f070
00691F018  adrp     x20, #0x959c000
00691F01C  ldrb     w8, [x20, #0xbf2]
00691F020  cbnz     w8, #0x691f038
00691F024  adrp     x0, #0x8f27000
00691F028  ldr      x0, [x0, #0xbc8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WaveAIId()
00691F02C  bl       #0x382bd14 ; 
00691F030  mov      w8, #1
00691F034  strb     w8, [x20, #0xbf2]
00691F038  adrp     x8, #0x8f27000
00691F03C  ldr      x8, [x8, #0xbc8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_WaveAIId()
00691F040  ldr      x1, [x8]
00691F044  ldrb     w8, [x1, #0x53]
00691F048  tbnz     w8, #5, #0x691f0b8
00691F04C  ldr      x0, [x19, #0x100]
00691F050  b        #0x691f0a8 ; 
00691F054  ldr      x3, [x2, #0x60]
00691F058  mov      x0, x19
00691F05C  mov      w1, w20
00691F060  ldp      x20, x19, [sp, #0x20]
00691F064  ldp      x22, x21, [sp, #0x10]
00691F068  ldr      x30, [sp], #0x30
00691F06C  br       x3
00691F070  adrp     x20, #0x959c000
00691F074  ldrb     w8, [x20, #0xbf1]
00691F078  cbnz     w8, #0x691f090
00691F07C  adrp     x0, #0x8f27000
00691F080  ldr      x0, [x0, #0xba8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_AIId()
00691F084  bl       #0x382bd14 ; 
00691F088  mov      w8, #1
00691F08C  strb     w8, [x20, #0xbf1]
00691F090  adrp     x8, #0x8f27000
00691F094  ldr      x8, [x8, #0xba8] ; GLOBAL Method$LocalModels.Bean.Character_entity.get_AIId()
00691F098  ldr      x1, [x8]
00691F09C  ldrb     w8, [x1, #0x53]
00691F0A0  tbnz     w8, #5, #0x691f0b8
00691F0A4  ldr      x0, [x19, #0xf0]
00691F0A8  ldp      x20, x19, [sp, #0x20]
00691F0AC  ldp      x22, x21, [sp, #0x10]
00691F0B0  ldr      x30, [sp], #0x30
00691F0B4  ret      
00691F0B8  ldr      x2, [x1, #0x60]
00691F0BC  mov      x0, x19
00691F0C0  ldp      x20, x19, [sp, #0x20]
00691F0C4  ldp      x22, x21, [sp, #0x10]
00691F0C8  ldr      x30, [sp], #0x30
00691F0CC  br       x2
00691F0D0  bl       #0x382bfb8 ; 

