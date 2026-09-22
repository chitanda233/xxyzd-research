; HotFix.BattleLogic.BattleWorldContext$$AddBattleWaveAttr
; RVA 0x6A03BE0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006A03BE0  stp      x30, x23, [sp, #-0x30]!
006A03BE4  stp      x22, x21, [sp, #0x10]
006A03BE8  stp      x20, x19, [sp, #0x20]
006A03BEC  adrp     x22, #0x959d000
006A03BF0  adrp     x23, #0x8f08000
006A03BF4  ldrb     w8, [x22, #0x583]
006A03BF8  ldr      x23, [x23, #0x868] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleWaveAttr()
006A03BFC  mov      x19, x2
006A03C00  mov      x20, x1
006A03C04  mov      x21, x0
006A03C08  tbnz     w8, #0, #0x6a03c20
006A03C0C  adrp     x0, #0x8f08000
006A03C10  ldr      x0, [x0, #0x868] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.AddBattleWaveAttr()
006A03C14  bl       #0x382bd14 ; 
006A03C18  mov      w8, #1
006A03C1C  strb     w8, [x22, #0x583]
006A03C20  ldr      x3, [x23]
006A03C24  ldrb     w8, [x3, #0x53]
006A03C28  tbnz     w8, #5, #0x6a03c4c
006A03C2C  add      x0, x21, #0x290
006A03C30  mov      x1, x20
006A03C34  mov      x2, x19
006A03C38  ldp      x20, x19, [sp, #0x20]
006A03C3C  ldp      x22, x21, [sp, #0x10]
006A03C40  mov      x3, xzr
006A03C44  ldp      x30, x23, [sp], #0x30
006A03C48  b        #0x658f09c ; HotFix.BattleLogic.BattleData$$AddExBattleWaveAttr
006A03C4C  ldr      x4, [x3, #0x60]
006A03C50  mov      x0, x21
006A03C54  mov      x1, x20
006A03C58  mov      x2, x19
006A03C5C  ldp      x20, x19, [sp, #0x20]
006A03C60  ldp      x22, x21, [sp, #0x10]
006A03C64  ldp      x30, x23, [sp], #0x30
006A03C68  br       x4

