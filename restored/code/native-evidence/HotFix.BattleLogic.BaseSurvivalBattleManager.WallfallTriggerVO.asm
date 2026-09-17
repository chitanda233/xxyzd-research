; HotFix.BattleLogic.BaseSurvivalBattleManager.WallfallTriggerVO$$.ctor
; RVA 0x658A6F8; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658A6F8  str      x30, [sp, #-0x40]!
00658A6FC  stp      x24, x23, [sp, #0x10]
00658A700  stp      x22, x21, [sp, #0x20]
00658A704  stp      x20, x19, [sp, #0x30]
00658A708  adrp     x23, #0x9599000
00658A70C  adrp     x24, #0x8f08000
00658A710  ldrb     w8, [x23, #0x1a6]
00658A714  ldr      x24, [x24, #0x3a8]
00658A718  mov      x19, x3
00658A71C  mov      x20, x2
00658A720  mov      w21, w1
00658A724  mov      x22, x0
00658A728  tbnz     w8, #0, #0x658a740
00658A72C  adrp     x0, #0x8f08000
00658A730  ldr      x0, [x0, #0x3a8]
00658A734  bl       #0x382bd14 ; 
00658A738  mov      w8, #1
00658A73C  strb     w8, [x23, #0x1a6]
00658A740  ldr      x4, [x24]
00658A744  ldrb     w8, [x4, #0x53]
00658A748  tbnz     w8, #5, #0x658a780
00658A74C  mov      x0, x22
00658A750  mov      x1, xzr
00658A754  bl       #0x7c335dc ; System.Object$$.ctor
00658A758  str      x19, [x22, #0x20]!
00658A75C  stur     w21, [x22, #-0x10]
00658A760  stur     x20, [x22, #-8]
00658A764  mov      x0, x22
00658A768  mov      x1, x19
00658A76C  ldp      x20, x19, [sp, #0x30]
00658A770  ldp      x22, x21, [sp, #0x20]
00658A774  ldp      x24, x23, [sp, #0x10]
00658A778  ldr      x30, [sp], #0x40
00658A77C  b        #0x382bcb8 ; 
00658A780  ldr      x5, [x4, #0x60]
00658A784  mov      x0, x22
00658A788  mov      w1, w21
00658A78C  mov      x2, x20
00658A790  mov      x3, x19
00658A794  ldp      x20, x19, [sp, #0x30]
00658A798  ldp      x22, x21, [sp, #0x20]
00658A79C  ldp      x24, x23, [sp, #0x10]
00658A7A0  ldr      x30, [sp], #0x40
00658A7A4  br       x5

