; HotFix.BattleLogic.BasePunchboardState$$get_StopTime
; RVA 0x659EF34; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00659EF34  stp      x30, x21, [sp, #-0x20]!
00659EF38  stp      x20, x19, [sp, #0x10]
00659EF3C  adrp     x20, #0x9599000
00659EF40  adrp     x21, #0x8f09000
00659EF44  ldrb     w8, [x20, #0x332]
00659EF48  ldr      x21, [x21, #0x38] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState.get_StopTime() @ 0x923b6c8
00659EF4C  mov      x19, x0
00659EF50  tbnz     w8, #0, #0x659ef68
00659EF54  adrp     x0, #0x8f09000
00659EF58  ldr      x0, [x0, #0x38] ; GLOBAL Method$HotFix.BattleLogic.BasePunchboardState.get_StopTime() @ 0x923b6c8
00659EF5C  bl       #0x382bd14 ; 
00659EF60  mov      w8, #1
00659EF64  strb     w8, [x20, #0x332]
00659EF68  ldr      x1, [x21]
00659EF6C  ldrb     w8, [x1, #0x53]
00659EF70  tbnz     w8, #5, #0x659ef84
00659EF74  ldp      x20, x19, [sp, #0x10]
00659EF78  mov      w0, #1
00659EF7C  ldp      x30, x21, [sp], #0x20
00659EF80  ret      
00659EF84  ldr      x2, [x1, #0x60]
00659EF88  mov      x0, x19
00659EF8C  ldp      x20, x19, [sp, #0x10]
00659EF90  ldp      x30, x21, [sp], #0x20
00659EF94  br       x2

