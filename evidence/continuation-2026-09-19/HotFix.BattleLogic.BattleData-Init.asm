; HotFix.BattleLogic.BattleData$$Init
; RVA 0x658E344; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00658E344  stp      x30, x23, [sp, #-0x30]!
00658E348  stp      x22, x21, [sp, #0x10]
00658E34C  stp      x20, x19, [sp, #0x20]
00658E350  adrp     x22, #0x9599000
00658E354  adrp     x23, #0x8f08000
00658E358  ldrb     w8, [x22, #0x1fb]
00658E35C  ldr      x23, [x23, #0x608] ; GLOBAL Method$HotFix.BattleLogic.BattleData.Init() @ 0x923c360
00658E360  mov      x19, x2
00658E364  mov      w20, w1
00658E368  mov      x21, x0
00658E36C  tbnz     w8, #0, #0x658e384
00658E370  adrp     x0, #0x8f08000
00658E374  ldr      x0, [x0, #0x608] ; GLOBAL Method$HotFix.BattleLogic.BattleData.Init() @ 0x923c360
00658E378  bl       #0x382bd14 ; 
00658E37C  mov      w8, #1
00658E380  strb     w8, [x22, #0x1fb]
00658E384  ldr      x3, [x23]
00658E388  ldrb     w8, [x3, #0x53]
00658E38C  tbnz     w8, #5, #0x658e3b0
00658E390  str      x19, [x21, #0x60]!
00658E394  stur     w20, [x21, #-4]
00658E398  mov      x0, x21
00658E39C  mov      x1, x19
00658E3A0  ldp      x20, x19, [sp, #0x20]
00658E3A4  ldp      x22, x21, [sp, #0x10]
00658E3A8  ldp      x30, x23, [sp], #0x30
00658E3AC  b        #0x382bcb8 ; 
00658E3B0  ldr      x4, [x3, #0x60]
00658E3B4  mov      x0, x21
00658E3B8  mov      w1, w20
00658E3BC  mov      x2, x19
00658E3C0  ldp      x20, x19, [sp, #0x20]
00658E3C4  ldp      x22, x21, [sp, #0x10]
00658E3C8  ldp      x30, x23, [sp], #0x30
00658E3CC  br       x4

