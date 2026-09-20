; HotFix.BattleLogic.WeightRandomData$$Weight
; RVA 0x663206C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
00663206C  stp      x30, x21, [sp, #-0x20]!
006632070  stp      x20, x19, [sp, #0x10]
006632074  adrp     x20, #0x9599000
006632078  adrp     x21, #0x8f0c000
00663207C  ldrb     w8, [x20, #0x9c3]
006632080  ldr      x21, [x21, #0xec0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.Weight() @ 0x92cbbd8
006632084  mov      x19, x0
006632088  tbnz     w8, #0, #0x66320ac
00663208C  adrp     x0, #0x8ec2000
006632090  ldr      x0, [x0, #0x268] ; GLOBAL Method$System.Collections.Generic.List<int>.get_Count() @ 0x921ded0
006632094  bl       #0x382bd14 ; 
006632098  adrp     x0, #0x8f0c000
00663209C  ldr      x0, [x0, #0xec0] ; GLOBAL Method$HotFix.BattleLogic.WeightRandomData.Weight() @ 0x92cbbd8
0066320A0  bl       #0x382bd14 ; 
0066320A4  mov      w8, #1
0066320A8  strb     w8, [x20, #0x9c3]
0066320AC  ldr      x1, [x21]
0066320B0  ldrb     w8, [x1, #0x53]
0066320B4  tbnz     w8, #5, #0x66320f8
0066320B8  ldr      w8, [x19, #0xc]
0066320BC  cbnz     w8, #0x66320e8
0066320C0  ldrb     w8, [x19, #0x30]
0066320C4  cbnz     w8, #0x66320e8
0066320C8  ldr      x8, [x19, #0x28]
0066320CC  cbz      x8, #0x663211c
0066320D0  ldr      w8, [x8, #0x18]
0066320D4  cbnz     w8, #0x66320e8
0066320D8  ldrb     w8, [x19, #0x20]
0066320DC  cbnz     w8, #0x66320e8
0066320E0  ldrb     w8, [x19, #0x21]
0066320E4  cbz      w8, #0x663210c
0066320E8  ldp      x20, x19, [sp, #0x10]
0066320EC  mov      w0, wzr
0066320F0  ldp      x30, x21, [sp], #0x20
0066320F4  ret      
0066320F8  ldr      x2, [x1, #0x60]
0066320FC  mov      x0, x19
006632100  ldp      x20, x19, [sp, #0x10]
006632104  ldp      x30, x21, [sp], #0x20
006632108  br       x2
00663210C  mov      x0, x19
006632110  ldp      x20, x19, [sp, #0x10]
006632114  ldp      x30, x21, [sp], #0x20
006632118  b        #0x6632120 ; HotFix.BattleLogic.WeightRandomData$$PracticalWeight
00663211C  bl       #0x382bfb8 ; 

