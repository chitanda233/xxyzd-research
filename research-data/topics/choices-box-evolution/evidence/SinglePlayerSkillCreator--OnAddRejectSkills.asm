; HotFix.BattleLogic.SinglePlayerSkillCreator$$OnAddRejectSkills
; RVA 0x6874E2C; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006874E2C  str      x30, [sp, #-0x30]!
006874E30  stp      x22, x21, [sp, #0x10]
006874E34  stp      x20, x19, [sp, #0x20]
006874E38  adrp     x21, #0x959b000
006874E3C  adrp     x22, #0x8f24000
006874E40  ldrb     w8, [x21, #0xab2]
006874E44  ldr      x22, [x22, #0x4e0] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnAddRejectSkills() @ 0x92aa988
006874E48  mov      x19, x1
006874E4C  mov      x20, x0
006874E50  tbnz     w8, #0, #0x6874e68
006874E54  adrp     x0, #0x8f24000
006874E58  ldr      x0, [x0, #0x4e0] ; GLOBAL Method$HotFix.BattleLogic.SinglePlayerSkillCreator.OnAddRejectSkills() @ 0x92aa988
006874E5C  bl       #0x382bd14 ; 
006874E60  mov      w8, #1
006874E64  strb     w8, [x21, #0xab2]
006874E68  ldr      x2, [x22]
006874E6C  ldrb     w8, [x2, #0x53]
006874E70  tbnz     w8, #5, #0x6874f14
006874E74  ldr      x21, [x20, #0x18]
006874E78  cbz      x21, #0x6874f34
006874E7C  ldr      w8, [x21, #0x18]
006874E80  cmp      w8, #1
006874E84  b.lt     #0x6874ebc
006874E88  mov      w22, wzr
006874E8C  cmp      w22, w8
006874E90  b.hs     #0x6874f30
006874E94  add      x8, x21, w22, sxtw #3
006874E98  ldr      x0, [x8, #0x20]
006874E9C  cbz      x0, #0x6874f34
006874EA0  mov      x1, x19
006874EA4  mov      x2, xzr
006874EA8  bl       #0x66333ac ; HotFix.BattleLogic.WeightRandom$$OnAddRejectSkills
006874EAC  ldr      w8, [x21, #0x18]
006874EB0  add      w22, w22, #1
006874EB4  cmp      w22, w8
006874EB8  b.lt     #0x6874e8c
006874EBC  ldr      x20, [x20, #0x20]
006874EC0  cbz      x20, #0x6874f34
006874EC4  ldr      w8, [x20, #0x18]
006874EC8  cmp      w8, #1
006874ECC  b.lt     #0x6874f04
006874ED0  mov      w21, wzr
006874ED4  cmp      w21, w8
006874ED8  b.hs     #0x6874f30
006874EDC  add      x8, x20, w21, sxtw #3
006874EE0  ldr      x0, [x8, #0x20]
006874EE4  cbz      x0, #0x6874f34
006874EE8  mov      x1, x19
006874EEC  mov      x2, xzr
006874EF0  bl       #0x66333ac ; HotFix.BattleLogic.WeightRandom$$OnAddRejectSkills
006874EF4  ldr      w8, [x20, #0x18]
006874EF8  add      w21, w21, #1
006874EFC  cmp      w21, w8
006874F00  b.lt     #0x6874ed4
006874F04  ldp      x20, x19, [sp, #0x20]
006874F08  ldp      x22, x21, [sp, #0x10]
006874F0C  ldr      x30, [sp], #0x30
006874F10  ret      
006874F14  ldr      x3, [x2, #0x60]
006874F18  mov      x0, x20
006874F1C  mov      x1, x19
006874F20  ldp      x20, x19, [sp, #0x20]
006874F24  ldp      x22, x21, [sp, #0x10]
006874F28  ldr      x30, [sp], #0x30
006874F2C  br       x3
006874F30  bl       #0x382bfc0 ; 
006874F34  bl       #0x382bfb8 ; 

