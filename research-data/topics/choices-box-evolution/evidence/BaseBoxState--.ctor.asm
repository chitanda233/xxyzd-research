; HotFix.BattleLogic.BaseBoxState$$.ctor
; RVA 0x65979A4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0065979A4  stp      x30, x21, [sp, #-0x20]!
0065979A8  stp      x20, x19, [sp, #0x10]
0065979AC  adrp     x20, #0x9599000
0065979B0  adrp     x21, #0x8f08000
0065979B4  ldrb     w8, [x20, #0x2e7]
0065979B8  ldr      x21, [x21, #0xc30] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState..ctor() @ 0x923af90
0065979BC  mov      x19, x0
0065979C0  tbnz     w8, #0, #0x65979d8
0065979C4  adrp     x0, #0x8f08000
0065979C8  ldr      x0, [x0, #0xc30] ; GLOBAL Method$HotFix.BattleLogic.BaseBoxState..ctor() @ 0x923af90
0065979CC  bl       #0x382bd14 ; 
0065979D0  mov      w8, #1
0065979D4  strb     w8, [x20, #0x2e7]
0065979D8  ldr      x1, [x21]
0065979DC  ldrb     w8, [x1, #0x53]
0065979E0  tbnz     w8, #5, #0x65979f4
0065979E4  mov      x0, x19
0065979E8  ldp      x20, x19, [sp, #0x10]
0065979EC  ldp      x30, x21, [sp], #0x20
0065979F0  b        #0x6597214 ; HotFix.BattleLogic.SingleState$$.ctor
0065979F4  ldr      x2, [x1, #0x60]
0065979F8  mov      x0, x19
0065979FC  ldp      x20, x19, [sp, #0x10]
006597A00  ldp      x30, x21, [sp], #0x20
006597A04  br       x2

