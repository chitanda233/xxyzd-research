; HotFix.BattleLogic.NormalSkillCreator$$get_UseInitBox
; RVA 0x6872CFC; native ARM64 evidence, not reconstructed C#
; Range ends at next known method address; capped at 16000 bytes. Indirect calls are not resolved.
006872CFC  stp      x30, x21, [sp, #-0x20]!
006872D00  stp      x20, x19, [sp, #0x10]
006872D04  adrp     x20, #0x959b000
006872D08  adrp     x21, #0x8f24000
006872D0C  ldrb     w8, [x20, #0xa93]
006872D10  ldr      x21, [x21, #0x420] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.get_UseInitBox() @ 0x9295ef0
006872D14  mov      x19, x0
006872D18  tbnz     w8, #0, #0x6872d30
006872D1C  adrp     x0, #0x8f24000
006872D20  ldr      x0, [x0, #0x420] ; GLOBAL Method$HotFix.BattleLogic.NormalSkillCreator.get_UseInitBox() @ 0x9295ef0
006872D24  bl       #0x382bd14 ; 
006872D28  mov      w8, #1
006872D2C  strb     w8, [x20, #0xa93]
006872D30  ldr      x1, [x21]
006872D34  ldrb     w8, [x1, #0x53]
006872D38  tbnz     w8, #5, #0x6872d58
006872D3C  mov      x0, x19
006872D40  bl       #0x685b324 ; HotFix.BattleLogic.HeroSkillCreator$$get_WorldContext
006872D44  cbz      x0, #0x6872d6c
006872D48  ldp      x20, x19, [sp, #0x10]
006872D4C  mov      x1, xzr
006872D50  ldp      x30, x21, [sp], #0x20
006872D54  b        #0x69ffe94 ; HotFix.BattleLogic.BattleWorldContext$$get_UseNvWuShenInitSkill
006872D58  ldr      x2, [x1, #0x60]
006872D5C  mov      x0, x19
006872D60  ldp      x20, x19, [sp, #0x10]
006872D64  ldp      x30, x21, [sp], #0x20
006872D68  br       x2
006872D6C  bl       #0x382bfb8 ; 

