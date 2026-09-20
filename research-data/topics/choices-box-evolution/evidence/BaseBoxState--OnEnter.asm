; HotFix.BattleLogic.BaseBoxState$$OnEnter
; RVA 0x6597350; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006597350  str      x30, [sp, #-0x30]!
006597354  stp      x22, x21, [sp, #0x10]
006597358  stp      x20, x19, [sp, #0x20]
00659735C  adrp     x21, #0x9599000
006597360  adrp     x22, #0x8f08000
006597364  ldrb     w8, [x21, #0x2e4]
006597368  ldr      x22, [x22, #0xc08] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState.OnEnter() @ 0x923af98
00659736C  mov      x19, x1
006597370  mov      x20, x0
006597374  tbnz     w8, #0, #0x659738c
006597378  adrp     x0, #0x8f08000
00659737C  ldr      x0, [x0, #0xc08] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState.OnEnter() @ 0x923af98
006597380  bl       #0x382bd14 ; 
006597384  mov      w8, #1
006597388  strb     w8, [x21, #0x2e4]
00659738C  ldr      x2, [x22]
006597390  ldrb     w8, [x2, #0x53]
006597394  tbnz     w8, #5, #0x65973ac
006597398  mov      x0, x20
00659739C  ldp      x20, x19, [sp, #0x20]
0065973A0  ldp      x22, x21, [sp, #0x10]
0065973A4  ldr      x30, [sp], #0x30
0065973A8  b        #0x65973c8 ; HotFix.BattleLogic.BaseBoxState$$ShowBox
0065973AC  ldr      x3, [x2, #0x60]
0065973B0  mov      x0, x20
0065973B4  mov      x1, x19
0065973B8  ldp      x20, x19, [sp, #0x20]
0065973BC  ldp      x22, x21, [sp, #0x10]
0065973C0  ldr      x30, [sp], #0x30
0065973C4  br       x3

