; HotFix.BattleLogic.NormalSkillCreator$$OnAddRejectSkills
; RVA 0x6874CF4; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874CF4  str      x30, [sp, #-0x30]!
006874CF8  stp      x22, x21, [sp, #0x10]
006874CFC  stp      x20, x19, [sp, #0x20]
006874D00  adrp     x21, #0x959b000
006874D04  adrp     x22, #0x8f24000
006874D08  ldrb     w8, [x21, #0xaa3]
006874D0C  ldr      x22, [x22, #0x4d8] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnAddRejectSkills() @ 0x9295ea0
006874D10  mov      x19, x1
006874D14  mov      x20, x0
006874D18  tbnz     w8, #0, #0x6874d30
006874D1C  adrp     x0, #0x8f24000
006874D20  ldr      x0, [x0, #0x4d8] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.OnAddRejectSkills() @ 0x9295ea0
006874D24  bl       #0x382bd14 ; 
006874D28  mov      w8, #1
006874D2C  strb     w8, [x21, #0xaa3]
006874D30  ldr      x2, [x22]
006874D34  ldrb     w8, [x2, #0x53]
006874D38  tbnz     w8, #5, #0x6874e08
006874D3C  mov      x0, x20
006874D40  mov      x1, x19
006874D44  bl       #0x6874e2c ; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddRejectSkills
006874D48  ldr      x8, [x20, #0x80]
006874D4C  cbz      x8, #0x6874db0
006874D50  ldr      x8, [x20]
006874D54  mov      x0, x20
006874D58  ldr      x9, [x8, #0x2e8]
006874D5C  ldr      x1, [x8, #0x2f0]
006874D60  blr      x9
006874D64  tbz      w0, #0, #0x6874db0
006874D68  ldr      x21, [x20, #0x80]
006874D6C  cbz      x21, #0x6874e24
006874D70  ldr      w8, [x21, #0x18]
006874D74  cmp      w8, #1
006874D78  b.lt     #0x6874db0
006874D7C  mov      w22, wzr
006874D80  cmp      w22, w8
006874D84  b.hs     #0x6874e28
006874D88  add      x8, x21, w22, sxtw #3
006874D8C  ldr      x0, [x8, #0x20]
006874D90  cbz      x0, #0x6874e24
006874D94  mov      x1, x19
006874D98  mov      x2, xzr
006874D9C  bl       #0x66333ac ; HotFix.BattleLogic.WeightRandom$$OnAddRejectSkills
006874DA0  ldr      w8, [x21, #0x18]
006874DA4  add      w22, w22, #1
006874DA8  cmp      w22, w8
006874DAC  b.lt     #0x6874d80
006874DB0  ldr      x20, [x20, #0x88]
006874DB4  cbz      x20, #0x6874e24
006874DB8  ldr      w8, [x20, #0x18]
006874DBC  cmp      w8, #1
006874DC0  b.lt     #0x6874df8
006874DC4  mov      w21, wzr
006874DC8  cmp      w21, w8
006874DCC  b.hs     #0x6874e28
006874DD0  add      x8, x20, w21, sxtw #3
006874DD4  ldr      x0, [x8, #0x20]
006874DD8  cbz      x0, #0x6874e24
006874DDC  mov      x1, x19
006874DE0  mov      x2, xzr
006874DE4  bl       #0x66333ac ; HotFix.BattleLogic.WeightRandom$$OnAddRejectSkills
006874DE8  ldr      w8, [x20, #0x18]
006874DEC  add      w21, w21, #1
006874DF0  cmp      w21, w8
006874DF4  b.lt     #0x6874dc8
006874DF8  ldp      x20, x19, [sp, #0x20]
006874DFC  ldp      x22, x21, [sp, #0x10]
006874E00  ldr      x30, [sp], #0x30
006874E04  ret      
006874E08  ldr      x3, [x2, #0x60]
006874E0C  mov      x0, x20
006874E10  mov      x1, x19
006874E14  ldp      x20, x19, [sp, #0x20]
006874E18  ldp      x22, x21, [sp, #0x10]
006874E1C  ldr      x30, [sp], #0x30
006874E20  br       x3
006874E24  bl       #0x382bfb8 ; 
006874E28  bl       #0x382bfc0 ; 

