; HotFix.BattleLogic.WeightRandomData$$TryAddFlag
; RVA 0x66322DC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
0066322DC  str      x30, [sp, #-0x30]!
0066322E0  stp      x22, x21, [sp, #0x10]
0066322E4  stp      x20, x19, [sp, #0x20]
0066322E8  adrp     x21, #0x9599000
0066322EC  adrp     x22, #0x8f0c000
0066322F0  ldrb     w8, [x21, #0x9cb]
0066322F4  ldr      x22, [x22, #0xee0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.TryAddFlag() @ 0x92cbbc8
0066322F8  mov      w20, w1
0066322FC  mov      x19, x0
006632300  tbnz     w8, #0, #0x6632318
006632304  adrp     x0, #0x8f0c000
006632308  ldr      x0, [x0, #0xee0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.TryAddFlag() @ 0x92cbbc8
00663230C  bl       #0x382bd14 ; 
006632310  mov      w8, #1
006632314  strb     w8, [x21, #0x9cb]
006632318  ldr      x2, [x22]
00663231C  ldrb     w8, [x2, #0x53]
006632320  tbnz     w8, #5, #0x6632350
006632324  ldr      w8, [x19, #0xc]
006632328  mov      w0, wzr
00663232C  cbz      w8, #0x6632340
006632330  cmp      w8, w20
006632334  b.ne     #0x6632340
006632338  mov      w0, #1
00663233C  str      wzr, [x19, #0xc]
006632340  ldp      x20, x19, [sp, #0x20]
006632344  ldp      x22, x21, [sp, #0x10]
006632348  ldr      x30, [sp], #0x30
00663234C  ret      
006632350  ldr      x3, [x2, #0x60]
006632354  mov      x0, x19
006632358  mov      w1, w20
00663235C  ldp      x20, x19, [sp, #0x20]
006632360  ldp      x22, x21, [sp, #0x10]
006632364  ldr      x30, [sp], #0x30
006632368  br       x3

