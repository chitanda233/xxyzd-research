; HotFix.BattleLogic.EntityNpc$$OnColliderWithHero
; RVA 0x68D2BF0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0068D2BF0  str      x30, [sp, #-0x30]!
0068D2BF4  stp      x22, x21, [sp, #0x10]
0068D2BF8  stp      x20, x19, [sp, #0x20]
0068D2BFC  adrp     x21, #0x959c000
0068D2C00  adrp     x22, #0x8f28000
0068D2C04  ldrb     w8, [x21, #0x76e]
0068D2C08  ldr      x22, [x22, #0x840] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc.OnColliderWithHero() @ 0x9263da8
0068D2C0C  mov      x19, x1
0068D2C10  mov      x20, x0
0068D2C14  tbnz     w8, #0, #0x68d2c2c
0068D2C18  adrp     x0, #0x8f28000
0068D2C1C  ldr      x0, [x0, #0x840] ; GLOBAL Method$HotFix.BattleLogic.EntityNpc.OnColliderWithHero() @ 0x9263da8
0068D2C20  bl       #0x382bd14 ; 
0068D2C24  mov      w8, #1
0068D2C28  strb     w8, [x21, #0x76e]
0068D2C2C  ldr      x2, [x22]
0068D2C30  ldrb     w8, [x2, #0x53]
0068D2C34  tbnz     w8, #5, #0x68d2c74
0068D2C38  adrp     x21, #0x9591000
0068D2C3C  ldrb     w8, [x21, #0xa4b]
0068D2C40  cbnz     w8, #0x68d2c58
0068D2C44  adrp     x0, #0x8ee5000
0068D2C48  ldr      x0, [x0, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068D2C4C  bl       #0x382bd14 ; 
0068D2C50  mov      w8, #1
0068D2C54  strb     w8, [x21, #0xa4b]
0068D2C58  adrp     x8, #0x8ee5000
0068D2C5C  ldr      x8, [x8, #0xb28] ; GLOBAL Method$HotFix.BattleLogic.PooledWorldElement.get_WorldContext() @ 0x929a6f0
0068D2C60  ldr      x1, [x8]
0068D2C64  ldrb     w8, [x1, #0x53]
0068D2C68  tbnz     w8, #5, #0x68d2c90
0068D2C6C  ldr      x21, [x20, #0x20]
0068D2C70  b        #0x68d2ca0 ; 
0068D2C74  ldr      x3, [x2, #0x60]
0068D2C78  mov      x0, x20
0068D2C7C  mov      x1, x19
0068D2C80  ldp      x20, x19, [sp, #0x20]
0068D2C84  ldp      x22, x21, [sp, #0x10]
0068D2C88  ldr      x30, [sp], #0x30
0068D2C8C  br       x3
0068D2C90  ldr      x8, [x1, #0x60]
0068D2C94  mov      x0, x20
0068D2C98  blr      x8
0068D2C9C  mov      x21, x0
0068D2CA0  cbz      x21, #0x68d2d0c
0068D2CA4  adrp     x22, #0x9598000
0068D2CA8  ldrb     w8, [x22, #0xfc4]
0068D2CAC  cbnz     w8, #0x68d2cc4
0068D2CB0  adrp     x0, #0x8f05000
0068D2CB4  ldr      x0, [x0, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0068D2CB8  bl       #0x382bd14 ; 
0068D2CBC  mov      w8, #1
0068D2CC0  strb     w8, [x22, #0xfc4]
0068D2CC4  adrp     x8, #0x8f05000
0068D2CC8  ldr      x8, [x8, #0xfd8] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_BattleMgr() @ 0x923fe60
0068D2CCC  ldr      x1, [x8]
0068D2CD0  ldrb     w8, [x1, #0x53]
0068D2CD4  tbnz     w8, #5, #0x68d2ce0
0068D2CD8  ldr      x0, [x21, #0x220]
0068D2CDC  b        #0x68d2cec ; 
0068D2CE0  ldr      x8, [x1, #0x60]
0068D2CE4  mov      x0, x21
0068D2CE8  blr      x8
0068D2CEC  cbz      x0, #0x68d2d0c
0068D2CF0  mov      x1, x19
0068D2CF4  mov      x2, x20
0068D2CF8  ldp      x20, x19, [sp, #0x20]
0068D2CFC  ldp      x22, x21, [sp, #0x10]
0068D2D00  mov      x3, xzr
0068D2D04  ldr      x30, [sp], #0x30
0068D2D08  b        #0x6591b74 ; HotFix.BattleLogic.BattleManager$$OnHeroColliderWithNpc
0068D2D0C  bl       #0x382bfb8 ; 

