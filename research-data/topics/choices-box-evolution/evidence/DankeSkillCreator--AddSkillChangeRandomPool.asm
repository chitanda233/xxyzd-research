; HotFix.BattleLogic.DankeSkillCreator$$AddSkillChangeRandomPool
; RVA 0x6860D20; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006860D20  sub      sp, sp, #0x40
006860D24  stp      x30, x23, [sp, #0x10]
006860D28  stp      x22, x21, [sp, #0x20]
006860D2C  stp      x20, x19, [sp, #0x30]
006860D30  adrp     x22, #0x959b000
006860D34  adrp     x23, #0x8f23000
006860D38  ldrb     w8, [x22, #0x9f3]
006860D3C  ldr      x23, [x23, #0xc88] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.AddSkillChangeRandomPool() @ 0x9259cf0
006860D40  mov      x19, x2
006860D44  mov      w21, w1
006860D48  mov      x20, x0
006860D4C  tbnz     w8, #0, #0x6860d7c
006860D50  adrp     x0, #0x8f23000
006860D54  ldr      x0, [x0, #0xc88] ; GLOBAL Method$HotFix.BattleLogic.DankeSkillCreator.AddSkillChangeRandomPool() @ 0x9259cf0
006860D58  bl       #0x382bd14 ; 
006860D5C  adrp     x0, #0x8ebf000
006860D60  ldr      x0, [x0, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006860D64  bl       #0x382bd14 ; 
006860D68  adrp     x0, #0x8f23000
006860D6C  ldr      x0, [x0, #0xc90] ; GLOBAL -[AddSkillChangeRandomPool] 技能id = {0} @ 0x92eab70
006860D70  bl       #0x382bd14 ; 
006860D74  mov      w8, #1
006860D78  strb     w8, [x22, #0x9f3]
006860D7C  ldr      x3, [x23]
006860D80  ldrb     w8, [x3, #0x53]
006860D84  tbnz     w8, #5, #0x6860e24
006860D88  adrp     x22, #0x8ebf000
006860D8C  adrp     x23, #0x8f23000
006860D90  ldr      x22, [x22, #0xba0] ; GLOBAL int_TypeInfo @ 0x91ead28
006860D94  ldr      x23, [x23, #0xc90] ; GLOBAL -[AddSkillChangeRandomPool] 技能id = {0} @ 0x92eab70
006860D98  mov      x0, x20
006860D9C  mov      w1, w21
006860DA0  mov      x2, x19
006860DA4  bl       #0x6860ea0 ; HotFix.BattleLogic.NormalSkillCreator$$AddSkillChangeRandomPool
006860DA8  ldr      x0, [x22]
006860DAC  add      x1, sp, #0xc
006860DB0  str      w21, [sp, #0xc]
006860DB4  bl       #0x382be94 ; 
006860DB8  ldr      x8, [x23]
006860DBC  mov      x1, x0
006860DC0  mov      x2, xzr
006860DC4  mov      x0, x8
006860DC8  bl       #0x79d140c ; System.String$$Format
006860DCC  mov      x1, x0
006860DD0  mov      x0, x20
006860DD4  bl       #0x6860c34 ; HotFix.BattleLogic.DankeSkillCreator$$LogError
006860DD8  mov      x0, x20
006860DDC  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006860DE0  cbz      x0, #0x6860e9c
006860DE4  adrp     x23, #0x9598000
006860DE8  ldrb     w8, [x23, #0xfcc]
006860DEC  mov      x22, x0
006860DF0  cbnz     w8, #0x6860e08
006860DF4  adrp     x0, #0x8f06000
006860DF8  ldr      x0, [x0, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006860DFC  bl       #0x382bd14 ; 
006860E00  mov      w8, #1
006860E04  strb     w8, [x23, #0xfcc]
006860E08  adrp     x8, #0x8f06000
006860E0C  ldr      x8, [x8, #0x470] ; GLOBAL Method$HotFix.BattleLogic.BattleWorldContext.get_Table() @ 0x923ffc8
006860E10  ldr      x1, [x8]
006860E14  ldrb     w8, [x1, #0x53]
006860E18  tbnz     w8, #5, #0x6860e48
006860E1C  ldr      x0, [x22, #0x200]
006860E20  b        #0x6860e54 ; 
006860E24  ldr      x4, [x3, #0x60]
006860E28  mov      x0, x20
006860E2C  mov      w1, w21
006860E30  mov      x2, x19
006860E34  ldp      x20, x19, [sp, #0x30]
006860E38  ldp      x22, x21, [sp, #0x20]
006860E3C  ldp      x30, x23, [sp, #0x10]
006860E40  add      sp, sp, #0x40
006860E44  br       x4
006860E48  ldr      x8, [x1, #0x60]
006860E4C  mov      x0, x22
006860E50  blr      x8
006860E54  cbz      x0, #0x6860e9c
006860E58  mov      w1, w21
006860E5C  mov      x2, xzr
006860E60  bl       #0x64e1bd8 ; LocalModels.LocalModelManager$$GetSkill_Main
006860E64  mov      x21, x0
006860E68  mov      x0, x20
006860E6C  mov      x1, x21
006860E70  mov      x2, x19
006860E74  bl       #0x6860f1c ; HotFix.BattleLogic.DankeSkillCreator$$RemoveSkill
006860E78  mov      x0, x20
006860E7C  mov      x1, x21
006860E80  mov      x2, x19
006860E84  bl       #0x686145c ; HotFix.BattleLogic.DankeSkillCreator$$TryUnlockUpgradeSkills
006860E88  ldp      x20, x19, [sp, #0x30]
006860E8C  ldp      x22, x21, [sp, #0x20]
006860E90  ldp      x30, x23, [sp, #0x10]
006860E94  add      sp, sp, #0x40
006860E98  ret      
006860E9C  bl       #0x382bfb8 ; 

