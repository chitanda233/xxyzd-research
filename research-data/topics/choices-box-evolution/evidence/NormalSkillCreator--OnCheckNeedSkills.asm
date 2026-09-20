; HotFix.BattleLogic.NormalSkillCreator$$OnCheckNeedSkills
; RVA 0x6865D44; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006865D44  str      x30, [sp, #-0x30]!
006865D48  stp      x22, x21, [sp, #0x10]
006865D4C  stp      x20, x19, [sp, #0x20]
006865D50  adrp     x21, #0x959b000
006865D54  adrp     x22, #0x8f23000
006865D58  ldrb     w8, [x21, #0xaa2]
006865D5C  ldr      x22, [x22, #0xdf0] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnCheckNeedSkills() @ 0x9295eb0
006865D60  mov      w19, w1
006865D64  mov      x20, x0
006865D68  tbnz     w8, #0, #0x6865d80
006865D6C  adrp     x0, #0x8f23000
006865D70  ldr      x0, [x0, #0xdf0] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnCheckNeedSkills() @ 0x9295eb0
006865D74  bl       #0x382bd14 ; 
006865D78  mov      w8, #1
006865D7C  strb     w8, [x21, #0xaa2]
006865D80  ldr      x2, [x22]
006865D84  ldrb     w8, [x2, #0x53]
006865D88  tbnz     w8, #5, #0x6865e58
006865D8C  mov      x0, x20
006865D90  mov      w1, w19
006865D94  bl       #0x6874bc8 ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnCheckNeedSkills
006865D98  ldr      x8, [x20, #0x80]
006865D9C  cbz      x8, #0x6865e00
006865DA0  ldr      x8, [x20]
006865DA4  mov      x0, x20
006865DA8  ldr      x9, [x8, #0x2e8]
006865DAC  ldr      x1, [x8, #0x2f0]
006865DB0  blr      x9
006865DB4  tbz      w0, #0, #0x6865e00
006865DB8  ldr      x21, [x20, #0x80]
006865DBC  cbz      x21, #0x6865e74
006865DC0  ldr      w8, [x21, #0x18]
006865DC4  cmp      w8, #1
006865DC8  b.lt     #0x6865e00
006865DCC  mov      w22, wzr
006865DD0  cmp      w22, w8
006865DD4  b.hs     #0x6865e78
006865DD8  add      x8, x21, w22, sxtw #3
006865DDC  ldr      x0, [x8, #0x20]
006865DE0  cbz      x0, #0x6865e74
006865DE4  mov      w1, w19
006865DE8  mov      x2, xzr
006865DEC  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006865DF0  ldr      w8, [x21, #0x18]
006865DF4  add      w22, w22, #1
006865DF8  cmp      w22, w8
006865DFC  b.lt     #0x6865dd0
006865E00  ldr      x20, [x20, #0x88]
006865E04  cbz      x20, #0x6865e74
006865E08  ldr      w8, [x20, #0x18]
006865E0C  cmp      w8, #1
006865E10  b.lt     #0x6865e48
006865E14  mov      w21, wzr
006865E18  cmp      w21, w8
006865E1C  b.hs     #0x6865e78
006865E20  add      x8, x20, w21, sxtw #3
006865E24  ldr      x0, [x8, #0x20]
006865E28  cbz      x0, #0x6865e74
006865E2C  mov      w1, w19
006865E30  mov      x2, xzr
006865E34  bl       #0x66335e8 ; HotFix.BattleLogic.WeightRandom$$OnCheckNeedSkills
006865E38  ldr      w8, [x20, #0x18]
006865E3C  add      w21, w21, #1
006865E40  cmp      w21, w8
006865E44  b.lt     #0x6865e18
006865E48  ldp      x20, x19, [sp, #0x20]
006865E4C  ldp      x22, x21, [sp, #0x10]
006865E50  ldr      x30, [sp], #0x30
006865E54  ret      
006865E58  ldr      x3, [x2, #0x60]
006865E5C  mov      x0, x20
006865E60  mov      w1, w19
006865E64  ldp      x20, x19, [sp, #0x20]
006865E68  ldp      x22, x21, [sp, #0x10]
006865E6C  ldr      x30, [sp], #0x30
006865E70  br       x3
006865E74  bl       #0x382bfb8 ; 
006865E78  bl       #0x382bfc0 ; 

