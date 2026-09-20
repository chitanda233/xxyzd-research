; HotFix.BattleLogic.BattleManager$$RealColliderWithNpc
; RVA 0x6591EB0; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006591EB0  stp      x30, x23, [sp, #-0x30]!
006591EB4  stp      x22, x21, [sp, #0x10]
006591EB8  stp      x20, x19, [sp, #0x20]
006591EBC  adrp     x22, #0x9599000
006591EC0  adrp     x23, #0x8f08000
006591EC4  ldrb     w8, [x22, #0x249]
006591EC8  ldr      x23, [x23, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.RealColliderWithNpc() @ 0x923cc50
006591ECC  mov      x19, x2
006591ED0  mov      x20, x1
006591ED4  mov      x21, x0
006591ED8  tbnz     w8, #0, #0x6591ef0
006591EDC  adrp     x0, #0x8f08000
006591EE0  ldr      x0, [x0, #0x8a0] ; GLOBAL Method$HotFix.BattleLogic.BattleManager.RealColliderWithNpc() @ 0x923cc50
006591EE4  bl       #0x382bd14 ; 
006591EE8  mov      w8, #1
006591EEC  strb     w8, [x22, #0x249]
006591EF0  ldr      x3, [x23]
006591EF4  ldrb     w8, [x3, #0x53]
006591EF8  tbnz     w8, #5, #0x6591f2c
006591EFC  cbz      x19, #0x6591f4c
006591F00  ldr      w8, [x19, #0x62c]
006591F04  mov      x0, x19
006591F08  mov      x1, x20
006591F0C  mov      x2, xzr
006591F10  sub      w8, w8, #1
006591F14  str      w8, [x19, #0x62c]
006591F18  bl       #0x68d2bf0 ; HotFix.BattleLogic.EntityNpc$$OnColliderWithHero
006591F1C  ldr      x8, [x21]
006591F20  ldr      x4, [x8, #0x3a8]
006591F24  ldr      x3, [x8, #0x3b0]
006591F28  b        #0x6591f30 ; 
006591F2C  ldr      x4, [x3, #0x60]
006591F30  mov      x0, x21
006591F34  mov      x1, x20
006591F38  mov      x2, x19
006591F3C  ldp      x20, x19, [sp, #0x20]
006591F40  ldp      x22, x21, [sp, #0x10]
006591F44  ldp      x30, x23, [sp], #0x30
006591F48  br       x4
006591F4C  bl       #0x382bfb8 ; 

