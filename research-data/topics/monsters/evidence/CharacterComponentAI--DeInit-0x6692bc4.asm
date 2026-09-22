; HotFix.BattleLogic.CharacterComponentAI$$DeInit
; RVA 0x6692BC4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006692BC4  stp      x30, x21, [sp, #-0x20]!
006692BC8  stp      x20, x19, [sp, #0x10]
006692BCC  adrp     x20, #0x959a000
006692BD0  adrp     x21, #0x8f10000
006692BD4  ldrb     w8, [x20, #0x3d]
006692BD8  ldr      x21, [x21, #0x9c0] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.DeInit()
006692BDC  mov      x19, x0
006692BE0  tbnz     w8, #0, #0x6692bf8
006692BE4  adrp     x0, #0x8f10000
006692BE8  ldr      x0, [x0, #0x9c0] ; GLOBAL Method$HotFix.BattleLogic.CharacterComponentAI.DeInit()
006692BEC  bl       #0x382bd14 ; 
006692BF0  mov      w8, #1
006692BF4  strb     w8, [x20, #0x3d]
006692BF8  ldr      x1, [x21]
006692BFC  ldrb     w8, [x1, #0x53]
006692C00  tbnz     w8, #5, #0x6692c3c
006692C04  ldr      x0, [x19, #0x40]!
006692C08  cbz      x0, #0x6692c50
006692C0C  mov      x1, xzr
006692C10  bl       #0x6b8f620 ; HotFix.BattleLogic.AIStateController$$DeInit
006692C14  ldr      x0, [x19]
006692C18  cbz      x0, #0x6692c5c
006692C1C  mov      x1, xzr
006692C20  bl       #0x6b4d34c ; HotFix.Common.PooledElement$$Release
006692C24  str      xzr, [x19]
006692C28  mov      x0, x19
006692C2C  ldp      x20, x19, [sp, #0x10]
006692C30  mov      x1, xzr
006692C34  ldp      x30, x21, [sp], #0x20
006692C38  b        #0x382bcb8 ; 
006692C3C  ldr      x2, [x1, #0x60]
006692C40  mov      x0, x19
006692C44  ldp      x20, x19, [sp, #0x10]
006692C48  ldp      x30, x21, [sp], #0x20
006692C4C  br       x2
006692C50  ldp      x20, x19, [sp, #0x10]
006692C54  ldp      x30, x21, [sp], #0x20
006692C58  ret      
006692C5C  bl       #0x382bfb8 ; 

