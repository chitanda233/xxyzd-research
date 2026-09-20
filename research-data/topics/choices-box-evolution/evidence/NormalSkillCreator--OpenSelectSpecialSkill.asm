; HotFix.BattleLogic.NormalSkillCreator$$OpenSelectSpecialSkill
; RVA 0x6873690; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006873690  str      x30, [sp, #-0x40]!
006873694  stp      x24, x23, [sp, #0x10]
006873698  stp      x22, x21, [sp, #0x20]
00687369C  stp      x20, x19, [sp, #0x30]
0068736A0  adrp     x23, #0x959b000
0068736A4  adrp     x24, #0x8f24000
0068736A8  ldrb     w8, [x23, #0xa99]
0068736AC  ldr      x24, [x24, #0x460] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OpenSelectSpecialSkill() @ 0x9295ed8
0068736B0  mov      x19, x3
0068736B4  mov      x20, x2
0068736B8  mov      x21, x1
0068736BC  mov      x22, x0
0068736C0  tbnz     w8, #0, #0x68736d8
0068736C4  adrp     x0, #0x8f24000
0068736C8  ldr      x0, [x0, #0x460] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OpenSelectSpecialSkill() @ 0x9295ed8
0068736CC  bl       #0x382bd14 ; 
0068736D0  mov      w8, #1
0068736D4  strb     w8, [x23, #0xa99]
0068736D8  ldr      x4, [x24]
0068736DC  ldrb     w8, [x4, #0x53]
0068736E0  tbnz     w8, #5, #0x6873700
0068736E4  str      wzr, [x19]
0068736E8  ldp      x20, x19, [sp, #0x30]
0068736EC  ldp      x22, x21, [sp, #0x20]
0068736F0  ldp      x24, x23, [sp, #0x10]
0068736F4  mov      w0, wzr
0068736F8  ldr      x30, [sp], #0x40
0068736FC  ret      
006873700  ldr      x5, [x4, #0x60]
006873704  mov      x0, x22
006873708  mov      x1, x21
00687370C  mov      x2, x20
006873710  mov      x3, x19
006873714  ldp      x20, x19, [sp, #0x30]
006873718  ldp      x22, x21, [sp, #0x20]
00687371C  ldp      x24, x23, [sp, #0x10]
006873720  ldr      x30, [sp], #0x40
006873724  br       x5

