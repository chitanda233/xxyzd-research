; HotFix.BattleLogic.CharacterComponentAI$$OnUpdate
; RVA 0x6692CD8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006692CD8  str      x30, [sp, #-0x30]!
006692CDC  stp      x22, x21, [sp, #0x10]
006692CE0  stp      x20, x19, [sp, #0x20]
006692CE4  adrp     x21, #0x959a000
006692CE8  adrp     x22, #0x8f10000
006692CEC  ldrb     w8, [x21, #0x3f]
006692CF0  ldr      x22, [x22, #0x9d0] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.OnUpdate()
006692CF4  mov      x19, x1
006692CF8  mov      x20, x0
006692CFC  tbnz     w8, #0, #0x6692d14
006692D00  adrp     x0, #0x8f10000
006692D04  ldr      x0, [x0, #0x9d0] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.OnUpdate()
006692D08  bl       #0x382bd14 ; 
006692D0C  mov      w8, #1
006692D10  strb     w8, [x21, #0x3f]
006692D14  ldr      x2, [x22]
006692D18  ldrb     w8, [x2, #0x53]
006692D1C  tbnz     w8, #5, #0x6692d38
006692D20  ldr      x0, [x20, #0x40]
006692D24  cbz      x0, #0x6692d54
006692D28  ldr      x8, [x0]
006692D2C  ldr      x3, [x8, #0x298]
006692D30  ldr      x2, [x8, #0x2a0]
006692D34  b        #0x6692d40 ; 
006692D38  ldr      x3, [x2, #0x60]
006692D3C  mov      x0, x20
006692D40  mov      x1, x19
006692D44  ldp      x20, x19, [sp, #0x20]
006692D48  ldp      x22, x21, [sp, #0x10]
006692D4C  ldr      x30, [sp], #0x30
006692D50  br       x3
006692D54  bl       #0x382bfb8 ; 

