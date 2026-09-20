; HotFix.BattleLogic.NormalSkillCreator$$OnDeInit
; RVA 0x6874638; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874638  stp      x30, x21, [sp, #-0x20]!
00687463C  stp      x20, x19, [sp, #0x10]
006874640  adrp     x20, #0x959b000
006874644  adrp     x21, #0x8f24000
006874648  ldrb     w8, [x20, #0xa9f]
00687464C  ldr      x21, [x21, #0x4a0] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnDeInit() @ 0x9295ec0
006874650  mov      x19, x0
006874654  tbnz     w8, #0, #0x687466c
006874658  adrp     x0, #0x8f24000
00687465C  ldr      x0, [x0, #0x4a0] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnDeInit() @ 0x9295ec0
006874660  bl       #0x382bd14 ; 
006874664  mov      w8, #1
006874668  strb     w8, [x20, #0xa9f]
00687466C  ldr      x1, [x21]
006874670  ldrb     w8, [x1, #0x53]
006874674  tbnz     w8, #5, #0x68746b8
006874678  mov      x0, x19
00687467C  bl       #0x68746cc ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnDeInit
006874680  mov      x20, x19
006874684  ldr      x1, [x20, #0x80]!
006874688  cbz      x1, #0x68746a4
00687468C  mov      x0, x19
006874690  bl       #0x6872230 ; HotFix.BattleLogic.HeroSkillCreator$$ReleaseRandoms
006874694  mov      x0, x20
006874698  mov      x1, xzr
00687469C  str      xzr, [x19, #0x80]
0068746A0  bl       #0x382bcb8 ; 
0068746A4  ldr      x1, [x19, #0x88]
0068746A8  mov      x0, x19
0068746AC  ldp      x20, x19, [sp, #0x10]
0068746B0  ldp      x30, x21, [sp], #0x20
0068746B4  b        #0x6872230 ; HotFix.BattleLogic.HeroSkillCreator$$ReleaseRandoms
0068746B8  ldr      x2, [x1, #0x60]
0068746BC  mov      x0, x19
0068746C0  ldp      x20, x19, [sp, #0x10]
0068746C4  ldp      x30, x21, [sp], #0x20
0068746C8  br       x2

