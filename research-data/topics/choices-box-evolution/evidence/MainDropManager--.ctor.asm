; HotFix.BattleLogic.MainDropManager$$.ctor
; RVA 0x6671D60; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006671D60  stp      x30, x21, [sp, #-0x20]!
006671D64  stp      x20, x19, [sp, #0x10]
006671D68  adrp     x20, #0x9599000
006671D6C  adrp     x21, #0x8f0f000
006671D70  ldrb     w8, [x20, #0xde8]
006671D74  ldr      x21, [x21, #0x780] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager..ctor() @ 0x928dbf8
006671D78  mov      x19, x0
006671D7C  tbnz     w8, #0, #0x6671d94
006671D80  adrp     x0, #0x8f0f000
006671D84  ldr      x0, [x0, #0x780] ; GLOBAL Method$HotFix.BattleLogic.MainDropManager..ctor() @ 0x928dbf8
006671D88  bl       #0x382bd14 ; 
006671D8C  mov      w8, #1
006671D90  strb     w8, [x20, #0xde8]
006671D94  ldr      x1, [x21]
006671D98  ldrb     w8, [x1, #0x53]
006671D9C  tbnz     w8, #5, #0x6671db0
006671DA0  mov      x0, x19
006671DA4  ldp      x20, x19, [sp, #0x10]
006671DA8  ldp      x30, x21, [sp], #0x20
006671DAC  b        #0x6660484 ; HotFix.BattleLogic.DropMgr$$.ctor
006671DB0  ldr      x2, [x1, #0x60]
006671DB4  mov      x0, x19
006671DB8  ldp      x20, x19, [sp, #0x10]
006671DBC  ldp      x30, x21, [sp], #0x20
006671DC0  br       x2

