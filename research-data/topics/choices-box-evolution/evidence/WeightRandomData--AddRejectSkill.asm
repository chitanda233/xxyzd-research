; HotFix.BattleLogic.WeightRandomData$$AddRejectSkill
; RVA 0x663236C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00663236C  stp      x30, x21, [sp, #-0x20]!
006632370  stp      x20, x19, [sp, #0x10]
006632374  adrp     x20, #0x9599000
006632378  adrp     x21, #0x8f0c000
00663237C  ldrb     w8, [x20, #0x9cd]
006632380  ldr      x21, [x21, #0xee8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.AddRejectSkill() @ 0x92cbb78
006632384  mov      x19, x0
006632388  tbnz     w8, #0, #0x66323a0
00663238C  adrp     x0, #0x8f0c000
006632390  ldr      x0, [x0, #0xee8] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.AddRejectSkill() @ 0x92cbb78
006632394  bl       #0x382bd14 ; 
006632398  mov      w8, #1
00663239C  strb     w8, [x20, #0x9cd]
0066323A0  ldr      x1, [x21]
0066323A4  ldrb     w8, [x1, #0x53]
0066323A8  tbnz     w8, #5, #0x66323bc
0066323AC  ldrb     w8, [x19, #0x21]
0066323B0  cbz      w8, #0x66323d0
0066323B4  mov      w0, wzr
0066323B8  b        #0x66323d8 ; 
0066323BC  ldr      x2, [x1, #0x60]
0066323C0  mov      x0, x19
0066323C4  ldp      x20, x19, [sp, #0x10]
0066323C8  ldp      x30, x21, [sp], #0x20
0066323CC  br       x2
0066323D0  mov      w0, #1
0066323D4  strb     w0, [x19, #0x21]
0066323D8  ldp      x20, x19, [sp, #0x10]
0066323DC  ldp      x30, x21, [sp], #0x20
0066323E0  ret      

