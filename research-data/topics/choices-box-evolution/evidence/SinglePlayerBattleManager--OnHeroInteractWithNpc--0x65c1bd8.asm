; HotFix.BattleLogic.SinglePlayerBattleManager$$OnHeroInteractWithNpc
; RVA 0x65C1BD8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065C1BD8  stp      x30, x23, [sp, #-0x30]!
0065C1BDC  stp      x22, x21, [sp, #0x10]
0065C1BE0  stp      x20, x19, [sp, #0x20]
0065C1BE4  adrp     x22, #0x9599000
0065C1BE8  adrp     x23, #0x8f0a000
0065C1BEC  ldrb     w8, [x22, #0x53e]
0065C1BF0  ldr      x23, [x23, #0x418] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleManager.OnHeroInteractWithNpc() @ 0x92aa8c0
0065C1BF4  mov      x20, x2
0065C1BF8  mov      x21, x1
0065C1BFC  mov      x19, x0
0065C1C00  tbnz     w8, #0, #0x65c1c18
0065C1C04  adrp     x0, #0x8f0a000
0065C1C08  ldr      x0, [x0, #0x418] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerBattleManager.OnHeroInteractWithNpc() @ 0x92aa8c0
0065C1C0C  bl       #0x382bd14 ; 
0065C1C10  mov      w8, #1
0065C1C14  strb     w8, [x22, #0x53e]
0065C1C18  ldr      x3, [x23]
0065C1C1C  ldrb     w8, [x3, #0x53]
0065C1C20  tbnz     w8, #5, #0x65c1c60
0065C1C24  mov      x21, x19
0065C1C28  str      x20, [x21, #0x98]!
0065C1C2C  mov      x0, x21
0065C1C30  mov      x1, x20
0065C1C34  bl       #0x382bcb8 ; 
0065C1C38  ldur     x0, [x21, #-0x10]
0065C1C3C  cbz      x0, #0x65c1c80
0065C1C40  mov      w1, #1
0065C1C44  mov      x2, xzr
0065C1C48  bl       #0x687e9f8 ; HotFix.BattleLogic.EntityHeroNormal$$SetForceNoMove
0065C1C4C  mov      x0, x19
0065C1C50  ldp      x20, x19, [sp, #0x20]
0065C1C54  ldp      x22, x21, [sp, #0x10]
0065C1C58  ldp      x30, x23, [sp], #0x30
0065C1C5C  b        #0x65c1c84 ; HotFix.BattleLogic.SinglePlayerBattleManager$$OnHeroInteractWithNpc
0065C1C60  ldr      x4, [x3, #0x60]
0065C1C64  mov      x0, x19
0065C1C68  mov      x1, x21
0065C1C6C  mov      x2, x20
0065C1C70  ldp      x20, x19, [sp, #0x20]
0065C1C74  ldp      x22, x21, [sp, #0x10]
0065C1C78  ldp      x30, x23, [sp], #0x30
0065C1C7C  br       x4
0065C1C80  bl       #0x382bfb8 ; 

